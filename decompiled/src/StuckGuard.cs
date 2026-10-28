using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

// "กันตัวละครค้าง" (Monster tab, ticked per hero). Notices when the character has neither moved nor hurt its
// target for N minutes while the bot loop runs, then pushes it back into action one step at a time:
// soft reset + a short step, then a longer walk every 2 minutes, with one Discord alert on the third try.
// It only reads the hero/census snapshot the agent already streams (20 Hz / 3 Hz), so one check is a few
// comparisons; GForm0 runs it every 10 s on the UI thread.
// The reset itself is done by the bot loop (Class58) at the top of a round: the targeting state it clears
// (Class412, Class394, ...) belongs to that loop and is not safe to touch from the UI thread.
internal sealed class StuckGuard
{
	internal const string RoundStart = "round";

	// Smaller moves are jitter (attack_stop_nudge steps 2 units out and back), not progress.
	private const float MoveEpsilon = 3f;

	private static readonly TimeSpan StepGap = TimeSpan.FromMinutes(2.0);

	// Idle spells at least this long that end on their own are logged too, so short stalls can be measured.
	private static readonly TimeSpan ReportShortIdle = TimeSpan.FromSeconds(60.0);

	// The loop sleeps 300 ms per round; no new round for this long means it is blocked inside one step.
	private static readonly TimeSpan LoopBlockedAfter = TimeSpan.FromSeconds(20.0);

	// No new hero snapshot for this long: the game or the agent is frozen and a move would go nowhere.
	private static readonly TimeSpan DataFrozenAfter = TimeSpan.FromSeconds(60.0);

	internal struct Observation
	{
		// ticked, Bot ticked, loop running, attached, and not a mode that stands still on purpose
		internal bool Active;

		internal bool HasHero;

		// device clock of the newest hero snapshot (Class83.long_0); it stops changing when the stream stops
		internal long SnapshotMs;

		internal float X;

		internal float Y;

		internal float Z;

		internal int Hp;

		internal uint ActState;

		internal byte Action;

		internal byte PathActive;

		internal uint TargetId;

		internal TimeSpan Threshold;
	}

	internal sealed class Recovery
	{
		internal float X;

		internal float Y;

		internal float Z;

		internal bool AllowFar;

		internal string Source;

		internal int HoldMs;
	}

	private readonly Action<string> log;

	private readonly Func<string> heroName;

	private readonly Action<Recovery> moveNow;

	private readonly Action<TimeSpan, string> alert;

	private readonly Action<TimeSpan> alertCleared;

	private readonly Func<DateTime> utcNow;

	// --- checks (UI thread) ---
	private bool tracking;

	private DateTime progressUtc;

	private float anchorX;

	private float anchorZ;

	// where the idle spell began; walking back here (the bot returning to its spot after our step) is not progress either
	private float originX;

	private float originZ;

	// the step/walk we asked for moved the character; the next check re-anchors instead of calling it progress
	private bool reanchor;

	private uint lastTargetId;

	private long lastTargetHp = -1L;

	private long seenTargetHp = -1L;

	private long lastSnapshotMs;

	private DateTime snapshotChangedUtc;

	// 0 = fine, 1 = short step done, 2 = walked, 3 = walked and Discord told (it keeps walking after that)
	private int level;

	private int tries;

	private DateTime nextStepUtc;

	private bool alerted;

	private int walks;

	// --- bot loop probe (written by Class58, read by the checks) ---
	private readonly object loopGate = new object();

	private string loopStep = "-";

	private DateTime loopStepUtc;

	private DateTime roundUtc;

	// step where each round ended since the last progress, e.g. "pick 540" = every round stopped at picking
	private readonly Dictionary<string, int> roundEnds = new Dictionary<string, int>(StringComparer.Ordinal);

	private Recovery pending;

	internal StuckGuard(Action<string> log, Func<string> heroName, Action<Recovery> moveNow, Action<TimeSpan, string> alert, Action<TimeSpan> alertCleared, Func<DateTime> utcNow)
	{
		this.log = log ?? delegate
		{
		};
		this.heroName = heroName ?? (() => null);
		this.moveNow = moveNow ?? delegate
		{
		};
		this.alert = alert ?? delegate
		{
		};
		this.alertCleared = alertCleared ?? delegate
		{
		};
		this.utcNow = utcNow ?? (() => DateTime.UtcNow);
	}

	// Bot loop: called as it enters each step; RoundStart opens a new round (the previous one ended at the last step).
	internal void LoopStep(string step)
	{
		DateTime now = utcNow();
		lock (loopGate)
		{
			if (step == RoundStart)
			{
				if (loopStep != "-")
				{
					roundEnds.TryGetValue(loopStep, out int count);
					roundEnds[loopStep] = count + 1;
				}
				roundUtc = now;
			}
			loopStep = step;
			loopStepUtc = now;
		}
	}

	// Bot loop: the reset + move a check asked for, or null.
	internal Recovery TakeRecovery()
	{
		return Interlocked.Exchange(ref pending, null);
	}

	// Text for the label under the checkbox.
	internal string Status()
	{
		if (!tracking)
		{
			return "-";
		}
		string idle = Clock(utcNow() - progressUtc);
		return (tries == 0) ? ("ยืนเฉยมา " + idle) : ("ค้าง " + idle + " · แก้ไปแล้ว " + tries + " รอบ");
	}

	// hpOf(id): HP of that monster in the newest census, or -1 when it is not in it.
	internal void Check(Observation obs, Func<uint, long> hpOf)
	{
		DateTime now = utcNow();
		if (!obs.Active || !obs.HasHero || obs.Hp <= 0)
		{
			// Bot off, following a leader, healing, not in the world or dead: standing still is expected.
			tracking = false;
			Interlocked.Exchange(ref pending, null);
			return;
		}
		seenTargetHp = (obs.TargetId == 0) ? (-1L) : hpOf(obs.TargetId);
		if (!tracking)
		{
			Begin(now, obs);
			return;
		}
		if (obs.SnapshotMs != lastSnapshotMs)
		{
			lastSnapshotMs = obs.SnapshotMs;
			snapshotChangedUtc = now;
		}
		TimeSpan idle = now - progressUtc;
		if (reanchor)
		{
			reanchor = false;
			anchorX = obs.X;
			anchorZ = obs.Z;
		}
		else if (Progressed(obs, hpOf))
		{
			if (level > 0)
			{
				Say("moving again after " + Clock(idle) + " idle");
				if (alerted)
				{
					alertCleared(idle);
				}
			}
			else if (idle >= ReportShortIdle)
			{
				Say("idle " + Clock(idle) + ", ended by itself | " + Describe(obs, now));
			}
			Begin(now, obs);
			return;
		}
		lastTargetId = obs.TargetId;
		lastTargetHp = seenTargetHp;
		if ((level == 0) ? (idle >= obs.Threshold) : (now >= nextStepUtc))
		{
			Escalate(now, obs, idle);
		}
	}

	internal static long HpIn(IReadOnlyList<Class403> census, uint id)
	{
		if (census == null)
		{
			return -1L;
		}
		for (int i = 0; i < census.Count; i++)
		{
			Class403 record = census[i];
			if (record != null && record.uint_0 == id)
			{
				return record.ushort_2;
			}
		}
		return -1L;
	}

	private void Begin(DateTime now, Observation obs)
	{
		tracking = true;
		progressUtc = now;
		anchorX = obs.X;
		anchorZ = obs.Z;
		originX = obs.X;
		originZ = obs.Z;
		reanchor = false;
		lastTargetId = obs.TargetId;
		lastTargetHp = seenTargetHp;
		lastSnapshotMs = obs.SnapshotMs;
		snapshotChangedUtc = now;
		level = 0;
		tries = 0;
		alerted = false;
		Interlocked.Exchange(ref pending, null);
		lock (loopGate)
		{
			roundEnds.Clear();
		}
	}

	private bool Progressed(Observation obs, Func<uint, long> hpOf)
	{
		if (Away(obs, anchorX, anchorZ) && Away(obs, originX, originZ))
		{
			return true;
		}
		if (lastTargetId != 0 && lastTargetHp > 0)
		{
			// the target we were on lost HP, or left the census (almost always: it died)
			long hp = (lastTargetId == obs.TargetId) ? seenTargetHp : hpOf(lastTargetId);
			return hp < lastTargetHp;
		}
		return false;
	}

	private static bool Away(Observation obs, float x, float z)
	{
		float dx = obs.X - x;
		float dz = obs.Z - z;
		return dx * dx + dz * dz >= MoveEpsilon * MoveEpsilon;
	}

	private void Escalate(DateTime now, Observation obs, TimeSpan idle)
	{
		int next = Math.Min(level + 1, 3);
		tries++;
		string detail = Describe(obs, now);
		TimeSpan dataAge = now - snapshotChangedUtc;
		Recovery move = null;
		string what;
		string why;
		if (dataAge >= DataFrozenAfter)
		{
			what = "no new hero data for " + Clock(dataAge) + " (game or agent frozen), not moving";
			why = "ไม่ได้รับข้อมูลจากเกมมา " + Clock(dataAge) + " นาที (เกมค้างหรือหลุด)";
		}
		else
		{
			// golden-angle turns, so consecutive tries never head into the same wall
			double angle = walks++ * 137.5 * Math.PI / 180.0;
			float distance = (next == 1) ? 4f : 12f;
			move = new Recovery
			{
				X = obs.X + (float)(Math.Cos(angle) * distance),
				Y = obs.Y,
				Z = obs.Z + (float)(Math.Sin(angle) * distance),
				AllowFar = next > 1,
				Source = (next == 1) ? "stuck_nudge" : "stuck_walk",
				HoldMs = (next == 1) ? 1500 : 4000
			};
			what = (next == 1) ? "soft reset + short step" : "soft reset + walk 12";
			why = "บอทลองขยับให้แล้วยังไม่หาย · ค้างอยู่ที่ขั้น " + CurrentStep();
		}
		if (move != null)
		{
			DateTime round;
			DateTime stepSince;
			string step;
			lock (loopGate)
			{
				round = roundUtc;
				stepSince = loopStepUtc;
				step = loopStep;
			}
			if (now - round <= LoopBlockedAfter)
			{
				Interlocked.Exchange(ref pending, move);
			}
			else
			{
				// The loop is stuck inside one step and would never pick the request up. A move is safe to
				// send from here; the reset is not, so that one waits for the loop.
				moveNow(move);
				what = what + " (loop blocked in " + step + " for " + Clock(now - stepSince) + ": move sent directly)";
			}
			reanchor = true;
		}
		if (next == 3 && !alerted)
		{
			alerted = true;
			alert(idle, why);
			what += " + Discord";
		}
		Say("idle " + Clock(idle) + " -> " + what + " | " + detail);
		level = next;
		nextStepUtc = now + StepGap;
	}

	private string CurrentStep()
	{
		lock (loopGate)
		{
			return loopStep;
		}
	}

	private string Describe(Observation obs, DateTime now)
	{
		StringBuilder text = new StringBuilder();
		lock (loopGate)
		{
			text.Append("step=").Append(loopStep);
			if (loopStepUtc != default(DateTime))
			{
				text.Append(' ').Append(Clock(now - loopStepUtc));
				if (now - roundUtc > LoopBlockedAfter)
				{
					text.Append(" (loop not cycling for ").Append(Clock(now - roundUtc)).Append(')');
				}
			}
			if (roundEnds.Count != 0)
			{
				text.Append(" rounds ended at: ").Append(string.Join(", ", from e in roundEnds
					orderby e.Value descending
					select e.Key + " " + e.Value.ToString(CultureInfo.InvariantCulture)));
			}
		}
		text.Append(" | pos=").Append(F(obs.X)).Append(',').Append(F(obs.Y)).Append(',').Append(F(obs.Z));
		text.Append(" act=0x").Append(obs.ActState.ToString("x", CultureInfo.InvariantCulture));
		text.Append(" action=").Append(obs.Action.ToString(CultureInfo.InvariantCulture));
		text.Append(" path=").Append(obs.PathActive.ToString(CultureInfo.InvariantCulture));
		text.Append(" target=").Append((obs.TargetId == 0) ? "-" : (obs.TargetId.ToString(CultureInfo.InvariantCulture) + " hp=" + seenTargetHp.ToString(CultureInfo.InvariantCulture)));
		text.Append(" data age=").Append(Clock(now - snapshotChangedUtc));
		return text.ToString();
	}

	private void Say(string message)
	{
		string hero = heroName();
		log("[Stuck] " + (string.IsNullOrWhiteSpace(hero) ? "?" : hero.Trim()) + " " + message);
	}

	private static string Clock(TimeSpan t)
	{
		if (t < TimeSpan.Zero)
		{
			t = TimeSpan.Zero;
		}
		return ((int)t.TotalMinutes).ToString(CultureInfo.InvariantCulture) + ":" + t.Seconds.ToString("00", CultureInfo.InvariantCulture);
	}

	private static string F(float value)
	{
		return value.ToString("0.#", CultureInfo.InvariantCulture);
	}

	// --test-stuck-guard: the timing rules above against a fake clock, no game needed.
	internal static int SelfTest()
	{
		int failed = 0;

		Probe p = new Probe();
		p.Obs.Active = false;
		p.Run(600);
		failed += Expect("inactive/no-actions", p.Taken.Count == 0 && p.Direct.Count == 0 && p.Alerts == 0);

		p = new Probe();
		p.Obs.Hp = 0;
		p.Run(600);
		failed += Expect("inactive/dead-never-acts", p.Taken.Count == 0 && p.Direct.Count == 0);

		p = new Probe();
		p.Run(170);
		failed += Expect("idle/under-threshold", p.Taken.Count == 0);
		p.Run(30);
		failed += Expect("idle/short-step-at-threshold", p.Taken.Count == 1 && p.Taken[0].Source == "stuck_nudge" && !p.Taken[0].AllowFar);
		failed += Expect("idle/log-names-step", p.Logs.Any((string l) => l.Contains("soft reset + short step") && l.Contains("rounds ended at: attack")));
		p.Run(120);
		failed += Expect("stuck/walk-after-2min", p.Taken.Count == 2 && p.Taken[1].Source == "stuck_walk" && p.Taken[1].AllowFar);
		p.Run(120);
		failed += Expect("stuck/discord-on-third-try", p.Alerts == 1 && p.Taken.Count == 3);
		p.Run(120);
		failed += Expect("stuck/discord-only-once", p.Alerts == 1 && p.Taken.Count == 4);
		failed += Expect("stuck/own-moves-not-progress", p.Cleared == 0);
		p.Run(30, (Probe q) => q.Obs.X += 5f);
		failed += Expect("stuck/moving-again-clears", p.Cleared == 1 && p.Logs.Any((string l) => l.Contains("moving again")));
		p.Run(170);
		failed += Expect("stuck/fresh-start-after-recovery", p.Taken.Count == 4);

		// the bot walking straight back to its spot after our step ("จุดปัจจุบัน" does that) must not reset the escalation
		p = new Probe();
		p.Run(200);
		p.Run(120, delegate(Probe q)
		{
			q.Obs.X = 100f;
			q.Obs.Z = 100f;
		});
		failed += Expect("progress/walking-back-is-not-progress", p.Taken.Count == 2 && p.Taken[1].Source == "stuck_walk" && p.Cleared == 0 && !p.Logs.Any((string l) => l.Contains("moving again")));

		p = new Probe();
		bool outward = false;
		p.Run(200, delegate(Probe q)
		{
			outward = !outward;
			q.Obs.X = outward ? 102f : 100f;
		});
		failed += Expect("progress/jitter-is-not-progress", p.Taken.Count == 1);

		p = new Probe();
		p.Obs.TargetId = 7u;
		p.Hp[7u] = 100000L;
		p.Run(360, (Probe q) => q.Hp[7u] -= 100L);
		failed += Expect("progress/damage-is-progress", p.Taken.Count == 0);

		p = new Probe();
		p.Obs.TargetId = 7u;
		p.Hp[7u] = 5000L;
		p.Run(200);
		failed += Expect("progress/no-damage-no-progress", p.Taken.Count == 1);

		p = new Probe();
		p.Obs.TargetId = 7u;
		p.Hp[7u] = 5000L;
		p.Run(100);
		p.Hp.Remove(7u);
		p.Obs.TargetId = 8u;
		p.Hp[8u] = 5000L;
		p.Run(100);
		failed += Expect("progress/killed-target-is-progress", p.Taken.Count == 0);

		p = new Probe();
		p.Run(80);
		p.Run(10, (Probe q) => q.Obs.X += 10f);
		failed += Expect("idle/short-pause-logged", p.Taken.Count == 0 && p.Logs.Any((string l) => l.Contains("ended by itself")));

		p = new Probe();
		p.Run(30);
		p.LoopRuns = false;
		p.Run(170);
		failed += Expect("loop/blocked-sends-move-directly", p.Direct.Count == 1 && p.Taken.Count == 0 && p.Guard.TakeRecovery() == null);

		p = new Probe();
		p.Frozen = true;
		p.Run(200);
		failed += Expect("data/frozen-no-move", p.Taken.Count == 0 && p.Direct.Count == 0 && p.Logs.Any((string l) => l.Contains("no new hero data")));

		p = new Probe();
		p.Run(190);
		p.Obs.Active = false;
		p.LoopRuns = false;
		p.Run(10);
		failed += Expect("inactive/untick-drops-pending", p.Taken.Count == 0 && p.Guard.TakeRecovery() == null && p.Guard.Status() == "-");

		Console.WriteLine("stuck-guard: " + failed + " failed");
		return failed;
	}

	private static int Expect(string name, bool ok)
	{
		if (ok)
		{
			return 0;
		}
		Console.WriteLine("FAIL  " + name);
		return 1;
	}

	private sealed class Probe
	{
		internal DateTime Now = new DateTime(2026, 10, 24, 12, 0, 0, DateTimeKind.Utc);

		internal readonly List<string> Logs = new List<string>();

		internal readonly List<Recovery> Direct = new List<Recovery>();

		internal readonly List<Recovery> Taken = new List<Recovery>();

		internal readonly Dictionary<uint, long> Hp = new Dictionary<uint, long>();

		internal int Alerts;

		internal int Cleared;

		internal bool LoopRuns = true;

		internal bool Frozen;

		internal Observation Obs = new Observation
		{
			Active = true,
			HasHero = true,
			Hp = 100,
			X = 100f,
			Z = 100f,
			SnapshotMs = 1L,
			Threshold = TimeSpan.FromMinutes(3.0)
		};

		internal readonly StuckGuard Guard;

		internal Probe()
		{
			Guard = new StuckGuard(Logs.Add, () => "Tester", Direct.Add, delegate
			{
				Alerts++;
			}, delegate
			{
				Cleared++;
			}, () => Now);
		}

		// One check every 10 s, like the form's timer; the fake loop takes a pending recovery the way Class58 does.
		internal void Run(int seconds, Action<Probe> beforeEachCheck = null)
		{
			for (int t = 0; t < seconds; t += 10)
			{
				Now = Now.AddSeconds(10.0);
				if (LoopRuns)
				{
					Guard.LoopStep(RoundStart);
					Guard.LoopStep("attack");
					Recovery recovery = Guard.TakeRecovery();
					if (recovery != null)
					{
						Taken.Add(recovery);
						Obs.X = recovery.X;
						Obs.Z = recovery.Z;
					}
				}
				if (!Frozen)
				{
					Obs.SnapshotMs += 10000L;
				}
				beforeEachCheck?.Invoke(this);
				Guard.Check(Obs, (uint id) => Hp.TryGetValue(id, out long hp) ? hp : (-1L));
			}
		}
	}
}
