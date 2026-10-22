using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

internal static class Class424
{
	private sealed class Class425
	{
		public GForm2 gform2_0;

		internal void method_0(object sender, EventArgs e)
		{
			smethod_3(gform2_0);
		}
	}

	private sealed class Class426
	{
		public SynchronizationContext synchronizationContext_0;

		internal void method_0(Action action_0)
		{
			synchronizationContext_0.Post(Class427.class427_0.method_0, action_0);
		}
	}

	[Serializable]
	private sealed class Class427
	{
		public static readonly Class427 class427_0 = new Class427();

		public static SendOrPostCallback sendOrPostCallback_0;

		public static Action<string> action_0;

		public static FormClosedEventHandler formClosedEventHandler_0;

		public static FormClosedEventHandler formClosedEventHandler_1;

		internal void method_0(object object_0)
		{
			((Action)object_0)();
		}

		internal void method_1(string string_0)
		{
			smethod_2(string_0);
		}

		internal void method_2(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		internal void method_3(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct138 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm2 gform2_0;

		private Class92 class92_0;

		private bool bool_0;

		private Stopwatch stopwatch_0;

		private GClass1 gclass1_0;

		private string string_0;

		private string string_1;

		private GClass20 gclass20_0;

		private GClass0 gclass0_0;

		private TaskAwaiter<GClass0> taskAwaiter_0;

		private Class17 class17_0;

		private TaskAwaiter<bool> taskAwaiter_1;

		private TaskAwaiter<(GClass17, GClass0)> taskAwaiter_2;

		private void MoveNext()
		{
			int num = int_0;
			try
			{
				if ((uint)num > 2u)
				{
					class92_0 = null;
					bool_0 = false;
				}
				try
				{
					TaskAwaiter<GClass0> awaiter3;
					TaskAwaiter<bool> awaiter2;
					TaskAwaiter<(GClass17, GClass0)> awaiter;
					bool result;
					GClass0 result2;
					GForm1 gForm;
					(GClass17, GClass0) result3;
					switch (num)
					{
					default:
						stopwatch_0 = Stopwatch.StartNew();
						smethod_2("startup begin");
						gform2_0.method_0("กำล\u0e31งตรวจสอบระบบ...");
						gform2_0.method_1(20);
						gclass1_0 = new GClass1();
						string_0 = gclass1_0.method_1();
						string_1 = gclass1_0.method_2();
						gform2_0.method_1(35);
						gclass20_0 = new GClass20();
						gform2_0.method_0("กำล\u0e31งตรวจสอบ License...");
						gform2_0.method_1(45);
						smethod_2("check-license begin elapsed_ms=" + stopwatch_0.ElapsedMilliseconds);
						awaiter3 = gclass20_0.method_2(string_0).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter3;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_0146;
					case 0:
						awaiter3 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<GClass0>);
						num = -1;
						int_0 = -1;
						goto IL_0146;
					case 1:
						awaiter2 = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_033f;
					case 2:
						{
							awaiter = taskAwaiter_2;
							taskAwaiter_2 = default(TaskAwaiter<(GClass17, GClass0)>);
							num = -1;
							int_0 = -1;
							goto IL_0433;
						}
						IL_033f:
						result = awaiter2.GetResult();
						smethod_2("heartbeat end elapsed_ms=" + stopwatch_0.ElapsedMilliseconds + " observed=" + result);
						if (result)
						{
							gform2_0.method_1(70);
							smethod_2("active-license begin elapsed_ms=" + stopwatch_0.ElapsedMilliseconds);
							awaiter = gclass20_0.method_1(gclass0_0.LicenseKey, string_0, string_1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 2;
								int_0 = 2;
								taskAwaiter_2 = awaiter;
								asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0433;
						}
						gform2_0.Hide();
						Application.Exit();
						goto end_IL_001a;
						IL_0146:
						result2 = awaiter3.GetResult();
						gclass0_0 = result2;
						smethod_2("check-license end elapsed_ms=" + stopwatch_0.ElapsedMilliseconds + " result=" + ((gclass0_0 == null) ? "null" : (gclass0_0.IsValid ? "valid" : "invalid")));
						if (gclass0_0 != null && gclass0_0.IsValid)
						{
							Class426 @class = new Class426();
							gform2_0.method_0("กำล\u0e31งเร\u0e34\u0e48ม Heartbeat...");
							smethod_2("heartbeat begin elapsed_ms=" + stopwatch_0.ElapsedMilliseconds);
							@class.synchronizationContext_0 = SynchronizationContext.Current;
							if (@class.synchronizationContext_0 == null)
							{
								throw new InvalidOperationException("The UI synchronization context is unavailable.");
							}
							class17_0 = new Class17();
							class92_0 = new Class92(Class135.smethod_3(), Class92.timeSpan_1, Class343.smethod_3, @class.method_0, class17_0.method_0, Class427.class427_0.method_1);
							Class343.smethod_5();
							awaiter2 = class92_0.method_0(Class343.smethod_4, Class92.timeSpan_0, Class92.timeSpan_1, CancellationToken.None).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 1;
								int_0 = 1;
								taskAwaiter_1 = awaiter2;
								asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_033f;
						}
						gform2_0.Hide();
						gForm = new GForm1();
						gForm.FormClosed += Class427.class427_0.method_3;
						gForm.Show();
						break;
						IL_0433:
						result3 = awaiter.GetResult();
						smethod_2("active-license end elapsed_ms=" + stopwatch_0.ElapsedMilliseconds);
						if (result3.Item1 != null && result3.Item1.Success)
						{
							gform2_0.method_1(100);
							smethod_2("form-create begin elapsed_ms=" + stopwatch_0.ElapsedMilliseconds);
							GForm0 gForm2 = new GForm0();
							gForm2.method_128(gclass0_0, gclass20_0, gclass1_0, string_0);
							gForm2.FormClosed += Class427.class427_0.method_2;
							gForm2.method_17(class92_0);
							bool_0 = true;
							bool flag;
							if (flag = class17_0.method_1(gForm2.method_19))
							{
								gForm2.Show();
							}
							gform2_0.Hide();
							smethod_2("startup complete elapsed_ms=" + stopwatch_0.ElapsedMilliseconds + " form_shown=" + flag);
						}
						else
						{
							Class429.smethod_1("ม\u0e35ป\u0e31ญหาอย\u0e48างมาก ต\u0e34ดต\u0e48อแอดม\u0e34น");
							gform2_0.Hide();
						}
						class17_0 = null;
						break;
					}
					stopwatch_0 = null;
					gclass1_0 = null;
					string_0 = null;
					string_1 = null;
					gclass20_0 = null;
					gclass0_0 = null;
					end_IL_001a:;
				}
				catch (Exception ex)
				{
					smethod_2("startup fault type=" + ex.GetType().FullName + " message=" + ex.Message);
					Class429.smethod_2("เก\u0e34ดข\u0e49อผ\u0e34ดพลาด: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					gform2_0.Hide();
				}
				finally
				{
					if (num < 0 && !bool_0 && class92_0 != null)
					{
						class92_0.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class92_0 = null;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class92_0 = null;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private static readonly string string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Capybara_Bot", "startup.log");

	[DllImport("kernel32.dll")]
	private static extern bool FreeConsole();

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_0);

	private static void smethod_0()
	{
		IntPtr consoleWindow = GetConsoleWindow();
		if (consoleWindow != IntPtr.Zero)
		{
			ShowWindow(consoleWindow, 0);
			FreeConsole();
		}
	}

	[STAThread]
	private static int Main(string[] args)
	{
		if (!Class182.smethod_4())
		{
			return 1;
		}
		Class425 @class = new Class425();
		if (args != null && args.Length != 0)
		{
			int num = Array.IndexOf(args, "--heartbeat-watchdog-probe-child");
			if (num >= 0)
			{
				if (num + 1 < args.Length && int.TryParse(args[num + 1], out var result) && result >= 0 && result <= 60000)
				{
					Thread.Sleep(result);
					return 0;
				}
				Console.Error.WriteLine("Usage: --heartbeat-watchdog-probe-child <lifetime-ms 0..60000>");
				return 2;
			}
			if (Array.IndexOf(args, "--test-heartbeat-watchdog") >= 0)
			{
				return (Class198.smethod_251() != 0) ? 1 : 0;
			}
			int num2 = Array.IndexOf(args, "--test-agent-license-resource");
			if (num2 >= 0)
			{
				return (Class198.smethod_0((num2 + 1 < args.Length) ? args[num2 + 1] : null) != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-agent-license-deploy") >= 0)
			{
				return (Class198.smethod_3() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-agent-license-crypto") >= 0)
			{
				return (Class198.smethod_8() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-agent-license") >= 0)
			{
				return (Class198.smethod_20() != 0) ? 1 : 0;
			}
			int num3 = Array.IndexOf(args, "--test-agent-license-envelope");
			if (num3 >= 0)
			{
				if (num3 + 2 >= args.Length)
				{
					Console.Error.WriteLine("Usage: --test-agent-license-envelope <handshake-hex> <output-json>");
					return 2;
				}
				return Class198.smethod_16(args[num3 + 1], args[num3 + 2]);
			}
			int num4 = Array.IndexOf(args, "--test-agent-license-deploy-live");
			if (num4 >= 0)
			{
				if (num4 + 2 >= args.Length)
				{
					Console.Error.WriteLine("Usage: " + Class135.smethod_4() + ".exe --test-agent-license-deploy-live <adb-path> <serial>");
					return 2;
				}
				return Class198.smethod_4(args[num4 + 1], args[num4 + 2]);
			}
			if (Array.IndexOf(args, "--test-startup-log") >= 0)
			{
				bool num5 = smethod_2("diagnostic self-test");
				Console.WriteLine(num5 ? ("Startup log written: " + string_0) : "Startup log write failed");
				return (!num5) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--selftest") >= 0)
			{
				return (Class198.smethod_46() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-grid-safety") >= 0)
			{
				return (Class198.smethod_266() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-challenge-capture") >= 0)
			{
				return (Class198.smethod_268() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-challenge-auto") >= 0)
			{
				return (Class198.smethod_275() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-attack-stuck") >= 0)
			{
				return (Class198.smethod_281() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-root-toast") >= 0)
			{
				return (Class198.smethod_293() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-pet-world") >= 0)
			{
				return (Class198.smethod_278() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-pet-request") >= 0)
			{
				return (Class198.smethod_279() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-pet-mode") >= 0)
			{
				return (Class198.smethod_280() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-product-layout") >= 0)
			{
				return Class436.smethod_3();
			}
			if (Array.IndexOf(args, "--test-product-profile") >= 0)
			{
				return (Class198.smethod_285() != 0) ? 1 : 0;
			}
			int num6 = Array.IndexOf(args, "--test-ocr");
			if (num6 >= 0)
			{
				if (num6 + 1 >= args.Length)
				{
					Console.Error.WriteLine("Usage: " + Class135.smethod_4() + ".exe --test-ocr <png-path>");
					return 2;
				}
				return Class198.smethod_274(args[num6 + 1]);
			}
			if (Array.IndexOf(args, "--test-ocr-thaipath") >= 0)
			{
				return Class198.smethod_269();
			}
			if (Array.IndexOf(args, "--test-shadow") >= 0)
			{
				return Class198.smethod_270();
			}
			int num7 = Array.IndexOf(args, "--test-klx-preprocess");
			if (num7 >= 0)
			{
				if (num7 + 2 >= args.Length)
				{
					Console.Error.WriteLine("Usage: " + Class135.smethod_4() + ".exe --test-klx-preprocess <png-path> <float32-output>");
					return 2;
				}
				return Class198.smethod_265(args[num7 + 1], args[num7 + 2]);
			}
			int num8 = Array.IndexOf(args, "--test-fallback");
			if (num8 >= 0)
			{
				return Class198.smethod_271((num8 + 1 < args.Length) ? args[num8 + 1] : null);
			}
			if (Array.IndexOf(args, "--test-update") >= 0)
			{
				return (Class198.smethod_284() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-catalog-update") >= 0)
			{
				return (Class198.smethod_286() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--check-catalog-update") >= 0)
			{
				return smethod_1(args);
			}
			if (Array.IndexOf(args, "--test-renew") >= 0)
			{
				return (Class198.smethod_290() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-sell-vip") >= 0)
			{
				return (Class198.smethod_291() != 0) ? 1 : 0;
			}
			int num9 = Array.IndexOf(args, "--test-native-collision-child");
			if (num9 >= 0)
			{
				if (num9 + 2 >= args.Length)
				{
					Console.Error.WriteLine("Usage: " + Class135.smethod_4() + ".exe --test-native-collision-child <decoy-path> <expected-path>");
					return 2;
				}
				return Class198.smethod_33(args[num9 + 1], args[num9 + 2]);
			}
			int num10 = Array.IndexOf(args, "--test-native-owned-reference-child");
			if (num10 >= 0)
			{
				if (num10 + 1 >= args.Length)
				{
					Console.Error.WriteLine("Usage: " + Class135.smethod_4() + ".exe --test-native-owned-reference-child <expected-path>");
					return 2;
				}
				return Class198.smethod_34(args[num10 + 1]);
			}
			int num11 = Array.IndexOf(args, "--test-native-post-load-collision-child");
			if (num11 >= 0)
			{
				if (num11 + 2 >= args.Length)
				{
					Console.Error.WriteLine("Usage: " + Class135.smethod_4() + ".exe --test-native-post-load-collision-child <decoy-path> <expected-path>");
					return 2;
				}
				return Class198.smethod_35(args[num11 + 1], args[num11 + 2]);
			}
			if (Array.IndexOf(args, "--test-automatic-loop") >= 0)
			{
				return (Class198.smethod_57() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-loading-rebirth") >= 0)
			{
				return (Class198.smethod_276() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-focusedlogs") >= 0)
			{
				return (Class198.smethod_100() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-skillcheck") >= 0)
			{
				return (Class198.smethod_101() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-followpos") >= 0)
			{
				return (Class198.smethod_115() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-redzone") >= 0)
			{
				return (Class198.smethod_116() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-waypoint") >= 0)
			{
				return (Class198.smethod_117() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-looper") >= 0)
			{
				return (Class198.smethod_118() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-routepersist") >= 0)
			{
				return (Class198.smethod_119() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-zone-mode") >= 0)
			{
				return (Class198.smethod_246() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-radar") >= 0)
			{
				return (Class198.smethod_245() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-fog") >= 0)
			{
				return (Class198.smethod_247() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-klassx-camera") >= 0)
			{
				return (Class198.smethod_248() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-zonelabel") >= 0)
			{
				return (Class198.smethod_102() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-pick") >= 0)
			{
				return (Class198.smethod_103() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-listbtn") >= 0)
			{
				return (Class198.smethod_120() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-cam") >= 0)
			{
				return (Class198.smethod_147() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-zonetop") >= 0)
			{
				return (Class198.smethod_148() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-boxbuff") >= 0)
			{
				return (Class198.smethod_149() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-selfbuffs") >= 0)
			{
				return (Class198.smethod_150() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-rebuff") >= 0)
			{
				return (Class198.smethod_151() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-grid-json") >= 0)
			{
				return (Class198.smethod_231() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-bag") >= 0)
			{
				return (Class198.smethod_152() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-pet-card-pick") >= 0)
			{
				return (Class198.smethod_44() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-sell") >= 0)
			{
				return (Class198.smethod_232() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-sellbtn") >= 0)
			{
				return (Class198.smethod_125() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-bagcat") >= 0)
			{
				return (Class198.smethod_126() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-sellfind") >= 0)
			{
				return (Class198.smethod_127() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-npcpos") >= 0)
			{
				return (Class198.smethod_128() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-sellcopy") >= 0)
			{
				return (Class198.smethod_144() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-npcpick") >= 0)
			{
				return (Class198.smethod_130() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-party-picker") >= 0)
			{
				return (Class198.smethod_294() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-party-runtime") >= 0)
			{
				return (Class198.smethod_295() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-player-buff-census") >= 0)
			{
				return (Class198.smethod_296() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-party-follow") >= 0)
			{
				return (Class198.smethod_297() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-party-follow-picker") >= 0)
			{
				return (Class198.smethod_298() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-remote-player-target-census") >= 0)
			{
				return (Class198.smethod_299() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-friends") >= 0)
			{
				return (Class198.smethod_154() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-sale") >= 0)
			{
				return (Class198.smethod_155() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-recall") >= 0)
			{
				return (Class198.smethod_212() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-card-travel") >= 0)
			{
				return (Class198.smethod_213() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-session-lifecycle") >= 0)
			{
				return (Class198.smethod_48() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-select-hero") >= 0)
			{
				return (Class198.smethod_47() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-title") >= 0)
			{
				return (Class198.smethod_282() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-grid-select") >= 0)
			{
				return (Class198.smethod_129() != 0) ? 1 : 0;
			}
			int num12 = Array.IndexOf(args, "--test-runner-health-live");
			if (num12 >= 0)
			{
				if (num12 + 2 >= args.Length)
				{
					Console.Error.WriteLine("Usage: " + Class135.smethod_4() + ".exe --test-runner-health-live <adb-path> <serial>");
					return 2;
				}
				return Class198.smethod_53(args[num12 + 1], args[num12 + 2]);
			}
			if (Array.IndexOf(args, "--test-runner-health") >= 0)
			{
				return (Class198.smethod_52() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-runner-deploy") >= 0)
			{
				return (Class198.smethod_42() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-deploy-error-ui") >= 0)
			{
				return (Class198.smethod_45() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-autoclick") >= 0)
			{
				return (Class198.smethod_43() != 0) ? 1 : 0;
			}
			Console.WriteLine(Class135.smethod_4() + ".exe             launch (splash -> license -> app)");
			Console.WriteLine(Class135.smethod_4() + ".exe --selftest  run the offline test suite");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-sell-vip  test sell licence gating offline");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-grid-safety  test shared catalogue persistence");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-challenge-capture  test challenge archive and Discord eligibility");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-challenge-auto  test the OCR auto-answer controller");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-attack-stuck  test stalled monster blacklist");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-root-toast  test Superuser notification database changes");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-pet-request  test pet commands and reply gating");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-pet-mode  test pet bag selection and decisions");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-party-follow  test party follow and local shared memory");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-party-follow-picker  test live two-tab follow picker");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-remote-player-target-census  test remote target census");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-product-layout  validate the copied customer package");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-product-profile  validate selected profile identities and package rules");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-catalog-update  test catalog update coordination offline");
			Console.WriteLine(Class135.smethod_4() + ".exe --check-catalog-update --token-env <name>  check the private catalog without changing files");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-ocr <png>  run the OneOCR engine on one image");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-klx-preprocess <png> <float32-output>  dump the KLX model tensor");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-deploy-error-ui  validate compact deploy error display");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-autoclick  test F2 autoclick start and stop");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-runner-deploy  validate offline runner deployment");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-automatic-loop  run the offline automatic-loop test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-loading-rebirth  run loading-state and rebirth protocol tests");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-focusedlogs  run the focused diagnostics test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-skillcheck  run the offline skill_check test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-followpos  run the offline follow-pos test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-redzone  run the offline position-radius test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-waypoint  run the offline waypoint overlay test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-looper  run the offline Looper cores test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-routepersist  run the offline route grid persistence test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-radar  test green Show Zone selection and legacy markers");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-klassx-camera  test one-shot KlassX zoom and actual readback");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-zone-mode  run the Classic/Modern selector and handoff test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-zonelabel  run the offline zone-label readout test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-pick  run the offline pick-mode filter test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-listbtn  run the offline List button transfer test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-cam  run the offline camera-zoom hack test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-zonetop  run the offline zonetop/zone group independence test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-boxbuff  run the offline held box buff data-path test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-selfbuffs  run the offline self buff data and display test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-rebuff  run the offline auto re-buff test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-grid-json  run the offline grid1 FollowPath JSON test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-bag  run the offline bag and equipment display test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-pet-card-pick  test bag name picker for Pet Card");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-sell  run the offline sell list and highlight test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-sellbtn  run the offline Sell tab list button test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-bagcat  run the offline bag item catalogue fold test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-sellfind  run the offline Sell tab find box test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-npcpos  run the offline NPC approach waypoint test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-sellcopy  run the offline copy-another-character's-sell-list test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-npcpick  run the offline shop-NPC picker test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-friends  run the offline friend-list read test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-sale  run the offline NPC sale decision test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-recall  run the offline sell recall/warp prelude test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-card-travel  run the offline reusable card travel test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-session-lifecycle  run the offline session-operation lifecycle test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-select-hero  run the offline Select hero-name wait test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-title  run the offline login identity title test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-grid-select  run the offline follow-pos grid highlight test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-runner-health  run the offline runner lifecycle test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-runner-health-live <adb-path> <serial>  run the read-only live runner probe");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-heartbeat-watchdog  run the offline heartbeat watchdog test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-agent-license-resource [expected-file]  validate the embedded ARM64 license library");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-agent-license-deploy  run the offline app-private library deployment test");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-agent-license-crypto  run managed protocol vectors and rejection tests");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-agent-license  run managed bootstrap lifecycle tests");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-agent-license-envelope <handshake-hex> <output-json>  encrypt fake credentials for native interop proof");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-agent-license-deploy-live <adb-path> <serial>  deploy the embedded library without launching the game");
			return 2;
		}
		smethod_0();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		if (!Class384.smethod_0(out var string_))
		{
			Class429.smethod_2("Product files are incomplete.\r\n\r\n" + string_, "Product files", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return 3;
		}
		@class.gform2_0 = new GForm2();
		@class.gform2_0.Load += @class.method_0;
		Application.Run(@class.gform2_0);
		Class39.Class40 class40_;
		if (Class39.smethod_3(out var string_2))
		{
			try
			{
				Class39.smethod_14(string_2);
			}
			catch (Exception ex)
			{
				Class429.smethod_2("ไม\u0e48สามารถเร\u0e34\u0e48มต\u0e31วอ\u0e31ปเดตได\u0e49: " + ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return 4;
			}
		}
		else if (Class39.smethod_6(out class40_))
		{
			try
			{
				Class39.smethod_15(class40_);
			}
			catch (Exception ex2)
			{
				Class429.smethod_2("ไม\u0e48สามารถเร\u0e34\u0e48มต\u0e31วอ\u0e31ปเดตได\u0e49: " + ex2.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return 4;
			}
		}
		return 0;
	}

	private static int smethod_1(string[] string_1)
	{
		int num = Array.IndexOf(string_1, "--token-env");
		if (num >= 0 && num + 1 < string_1.Length && !string.IsNullOrWhiteSpace(string_1[num + 1]))
		{
			string environmentVariable = Environment.GetEnvironmentVariable(string_1[num + 1]);
			if (string.IsNullOrWhiteSpace(environmentVariable))
			{
				Console.Error.WriteLine("The selected environment variable does not contain a token.");
				return 2;
			}
			int result2;
			try
			{
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMinutes(2.0));
				try
				{
					Class438 result = Class21.smethod_0(Class135.smethod_6(), Class135.smethod_7(), Class135.smethod_2(), AppDomain.CurrentDomain.BaseDirectory, environmentVariable, cancellationTokenSource.Token).GetAwaiter().GetResult();
					Console.WriteLine("Profile: " + result.String_0);
					Console.WriteLine("Catalog release: " + result.Int64_0);
					result2 = result.IReadOnlyList_0.Count;
					Console.WriteLine("Files checked: " + result2);
					result2 = result.IReadOnlyList_1.Count;
					Console.WriteLine("Files requiring update: " + result2);
					Console.WriteLine("Download bytes: " + result.Int64_3);
					foreach (Class94 item in result.IReadOnlyList_1)
					{
						Console.WriteLine(item.String_3 + " " + item.String_0 + " " + item.String_1);
					}
					result2 = (result.Boolean_0 ? 10 : 0);
				}
				finally
				{
					((IDisposable)cancellationTokenSource).Dispose();
				}
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Catalog check failed: " + ex.GetType().Name);
				result2 = 1;
			}
			return result2;
		}
		Console.Error.WriteLine("Usage: " + Class135.smethod_4() + ".exe --check-catalog-update --token-env <environment-variable-name>");
		return 2;
	}

	private static bool smethod_2(string string_1)
	{
		try
		{
			Directory.CreateDirectory(Path.GetDirectoryName(string_0));
			File.AppendAllText(string_0, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + " pid=" + Process.GetCurrentProcess().Id + " " + string_1 + Environment.NewLine);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static async void smethod_3(GForm2 gform2_0)
	{
		Class92 @class = null;
		bool flag = false;
		try
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			smethod_2("startup begin");
			gform2_0.method_0("กำล\u0e31งตรวจสอบระบบ...");
			gform2_0.method_1(20);
			GClass1 gClass = new GClass1();
			string text = gClass.method_1();
			string string_ = gClass.method_2();
			gform2_0.method_1(35);
			GClass20 gClass2 = new GClass20();
			gform2_0.method_0("กำล\u0e31งตรวจสอบ License...");
			gform2_0.method_1(45);
			smethod_2("check-license begin elapsed_ms=" + stopwatch.ElapsedMilliseconds);
			GClass0 gClass3 = await gClass2.method_2(text);
			smethod_2("check-license end elapsed_ms=" + stopwatch.ElapsedMilliseconds + " result=" + ((gClass3 == null) ? "null" : (gClass3.IsValid ? "valid" : "invalid")));
			if (gClass3 != null && gClass3.IsValid)
			{
				Class426 class2 = new Class426();
				gform2_0.method_0("กำล\u0e31งเร\u0e34\u0e48ม Heartbeat...");
				smethod_2("heartbeat begin elapsed_ms=" + stopwatch.ElapsedMilliseconds);
				class2.synchronizationContext_0 = SynchronizationContext.Current;
				if (class2.synchronizationContext_0 == null)
				{
					throw new InvalidOperationException("The UI synchronization context is unavailable.");
				}
				Class17 class3 = new Class17();
				@class = new Class92(Class135.smethod_3(), Class92.timeSpan_1, Class343.smethod_3, class2.method_0, class3.method_0, Class427.class427_0.method_1);
				Class343.smethod_5();
				bool flag2 = await @class.method_0(Class343.smethod_4, Class92.timeSpan_0, Class92.timeSpan_1, CancellationToken.None);
				smethod_2("heartbeat end elapsed_ms=" + stopwatch.ElapsedMilliseconds + " observed=" + flag2);
				if (!flag2)
				{
					gform2_0.Hide();
					Application.Exit();
					return;
				}
				gform2_0.method_1(70);
				smethod_2("active-license begin elapsed_ms=" + stopwatch.ElapsedMilliseconds);
				(GClass17, GClass0) tuple = await gClass2.method_1(gClass3.LicenseKey, text, string_);
				smethod_2("active-license end elapsed_ms=" + stopwatch.ElapsedMilliseconds);
				if (tuple.Item1 != null && tuple.Item1.Success)
				{
					gform2_0.method_1(100);
					smethod_2("form-create begin elapsed_ms=" + stopwatch.ElapsedMilliseconds);
					GForm0 gForm = new GForm0();
					gForm.method_128(gClass3, gClass2, gClass, text);
					gForm.FormClosed += Class427.class427_0.method_2;
					gForm.method_17(@class);
					flag = true;
					bool flag3;
					if (flag3 = class3.method_1(gForm.method_19))
					{
						gForm.Show();
					}
					gform2_0.Hide();
					smethod_2("startup complete elapsed_ms=" + stopwatch.ElapsedMilliseconds + " form_shown=" + flag3);
				}
				else
				{
					Class429.smethod_1("ม\u0e35ป\u0e31ญหาอย\u0e48างมาก ต\u0e34ดต\u0e48อแอดม\u0e34น");
					gform2_0.Hide();
				}
			}
			else
			{
				gform2_0.Hide();
				GForm1 gForm2 = new GForm1();
				gForm2.FormClosed += Class427.class427_0.method_3;
				gForm2.Show();
			}
		}
		catch (Exception ex)
		{
			smethod_2("startup fault type=" + ex.GetType().FullName + " message=" + ex.Message);
			Class429.smethod_2("เก\u0e34ดข\u0e49อผ\u0e34ดพลาด: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			gform2_0.Hide();
		}
		finally
		{
			if (!flag)
			{
				@class?.Dispose();
			}
		}
	}
}
