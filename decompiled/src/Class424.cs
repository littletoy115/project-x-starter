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

	[Serializable]
	private sealed class Class427
	{
		public static readonly Class427 class427_0 = new Class427();

		public static FormClosedEventHandler formClosedEventHandler_0;

		internal void method_2(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
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
			if (Array.IndexOf(args, "--test-challenge-auto") >= 0)
			{
				return (Class198.smethod_275() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-attack-stuck") >= 0)
			{
				return (Class198.smethod_281() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, "--test-stuck-guard") >= 0)
			{
				return (StuckGuard.SelfTest() != 0) ? 1 : 0;
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
			Console.WriteLine(Class135.smethod_4() + ".exe             launch (splash -> app)");
			Console.WriteLine(Class135.smethod_4() + ".exe --selftest  run the offline test suite");
			Console.WriteLine(Class135.smethod_4() + ".exe --test-grid-safety  test shared catalogue persistence");
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
		@class.gform2_0.Shown += @class.method_0;
		Application.Run(@class.gform2_0);
		return 0;
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

	private static void smethod_3(GForm2 gform2_0)
	{
		try
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			smethod_2("startup begin");
			gform2_0.method_0("กำลังตรวจสอบระบบ...");
			gform2_0.method_1(20);
			string string_;
			bool flag = LocalOffsets.Load(out string_);
			smethod_2("offsets " + (flag ? "loaded" : ("not loaded: " + string_)) + " elapsed_ms=" + stopwatch.ElapsedMilliseconds);
			gform2_0.method_1(100);
			smethod_2("form-create begin elapsed_ms=" + stopwatch.ElapsedMilliseconds);
			GForm0 gForm = new GForm0();
			gForm.method_128();
			gForm.FormClosed += Class427.class427_0.method_2;
			gForm.Show();
			gform2_0.Hide();
			smethod_2("startup complete elapsed_ms=" + stopwatch.ElapsedMilliseconds);
		}
		catch (Exception ex)
		{
			smethod_2("startup fault type=" + ex.GetType().FullName + " message=" + ex.Message);
			Class429.smethod_2("เกิดข้อผิดพลาด: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			gform2_0.Hide();
		}
	}
}
