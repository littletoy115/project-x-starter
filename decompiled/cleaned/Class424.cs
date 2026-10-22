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
						smethod_2(Class185.smethod_0(-1141274467));
						gform2_0.method_0(Class185.smethod_0(-1141274495));
						gform2_0.method_1(20);
						gclass1_0 = new GClass1();
						string_0 = gclass1_0.method_1();
						string_1 = gclass1_0.method_2();
						gform2_0.method_1(35);
						gclass20_0 = new GClass20();
						gform2_0.method_0(Class185.smethod_0(-1141265671));
						gform2_0.method_1(45);
						smethod_2(Class185.smethod_0(-1141274532) + stopwatch_0.ElapsedMilliseconds);
						awaiter3 = gclass20_0.method_2(string_0).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter3;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_015a;
					case 0:
						awaiter3 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<GClass0>);
						num = -1;
						int_0 = -1;
						goto IL_015a;
					case 1:
						awaiter2 = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_037b;
					case 2:
						{
							awaiter = taskAwaiter_2;
							taskAwaiter_2 = default(TaskAwaiter<(GClass17, GClass0)>);
							num = -1;
							int_0 = -1;
							goto IL_047e;
						}
						IL_037b:
						result = awaiter2.GetResult();
						smethod_2(Class185.smethod_0(-1141273721) + stopwatch_0.ElapsedMilliseconds + Class185.smethod_0(-1141273753) + result);
						if (result)
						{
							gform2_0.method_1(70);
							smethod_2(Class185.smethod_0(-1141273770) + stopwatch_0.ElapsedMilliseconds);
							awaiter = gclass20_0.method_1(gclass0_0.LicenseKey, string_0, string_1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 2;
								int_0 = 2;
								taskAwaiter_2 = awaiter;
								asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_047e;
						}
						gform2_0.Hide();
						Application.Exit();
						goto end_IL_001a;
						IL_015a:
						result2 = awaiter3.GetResult();
						gclass0_0 = result2;
						smethod_2(Class185.smethod_0(-1141274570) + stopwatch_0.ElapsedMilliseconds + Class185.smethod_0(-1141274614) + ((gclass0_0 == null) ? Class185.smethod_0(-1141273631) : (gclass0_0.IsValid ? Class185.smethod_0(-1141273611) : Class185.smethod_0(-1141273605))));
						if (gclass0_0 != null && gclass0_0.IsValid)
						{
							Class426 @class = new Class426();
							gform2_0.method_0(Class185.smethod_0(-1141273634));
							smethod_2(Class185.smethod_0(-1141273695) + stopwatch_0.ElapsedMilliseconds);
							@class.synchronizationContext_0 = SynchronizationContext.Current;
							if (@class.synchronizationContext_0 == null)
							{
								throw new InvalidOperationException(Class185.smethod_0(-1141265455));
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
							goto IL_037b;
						}
						gform2_0.Hide();
						gForm = new GForm1();
						gForm.FormClosed += Class427.class427_0.method_3;
						gForm.Show();
						break;
						IL_047e:
						result3 = awaiter.GetResult();
						smethod_2(Class185.smethod_0(-1141273809) + stopwatch_0.ElapsedMilliseconds);
						if (result3.Item1 != null && result3.Item1.Success)
						{
							gform2_0.method_1(100);
							smethod_2(Class185.smethod_0(-1141273854) + stopwatch_0.ElapsedMilliseconds);
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
							smethod_2(Class185.smethod_0(-1141273882) + stopwatch_0.ElapsedMilliseconds + Class185.smethod_0(-1141273925) + flag);
						}
						else
						{
							Class429.smethod_1(Class185.smethod_0(-1141273944));
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
					smethod_2(Class185.smethod_0(-1141274007) + ex.GetType().FullName + Class185.smethod_0(-1141274025) + ex.Message);
					Class429.smethod_2(Class185.smethod_0(-1141274041) + ex.Message, Class185.smethod_0(-1141295830), MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

	private static readonly string string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Class185.smethod_0(-1141297631), Class185.smethod_0(-1141274088));

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
			int num = Array.IndexOf(args, Class185.smethod_0(-1141274098));
			if (num >= 0)
			{
				if (num + 1 < args.Length && int.TryParse(args[num + 1], out var result) && result >= 0 && result <= 60000)
				{
					Thread.Sleep(result);
					return 0;
				}
				Console.Error.WriteLine(Class185.smethod_0(-1141246489));
				return 2;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246566)) >= 0)
			{
				return (Class198.smethod_251() != 0) ? 1 : 0;
			}
			int num2 = Array.IndexOf(args, Class185.smethod_0(-1141246598));
			if (num2 >= 0)
			{
				return (Class198.smethod_0((num2 + 1 < args.Length) ? args[num2 + 1] : null) != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246626)) >= 0)
			{
				return (Class198.smethod_3() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246660)) >= 0)
			{
				return (Class198.smethod_8() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246702)) >= 0)
			{
				return (Class198.smethod_20() != 0) ? 1 : 0;
			}
			int num3 = Array.IndexOf(args, Class185.smethod_0(-1141246721));
			if (num3 >= 0)
			{
				if (num3 + 2 >= args.Length)
				{
					Console.Error.WriteLine(Class185.smethod_0(-1141246765));
					return 2;
				}
				return Class198.smethod_16(args[num3 + 1], args[num3 + 2]);
			}
			int num4 = Array.IndexOf(args, Class185.smethod_0(-1141246838));
			if (num4 >= 0)
			{
				if (num4 + 2 >= args.Length)
				{
					Console.Error.WriteLine(Class185.smethod_0(-1141246877) + Class135.smethod_4() + Class185.smethod_0(-1141246883));
					return 2;
				}
				return Class198.smethod_4(args[num4 + 1], args[num4 + 2]);
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246947)) >= 0)
			{
				bool num5 = smethod_2(Class185.smethod_0(-1141246972));
				Console.WriteLine(num5 ? (Class185.smethod_0(-1141246014) + string_0) : Class185.smethod_0(-1141245983));
				return (!num5) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246034)) >= 0)
			{
				return (Class198.smethod_46() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246051)) >= 0)
			{
				return (Class198.smethod_266() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246076)) >= 0)
			{
				return (Class198.smethod_268() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246107)) >= 0)
			{
				return (Class198.smethod_275() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246143)) >= 0)
			{
				return (Class198.smethod_281() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246161)) >= 0)
			{
				return (Class198.smethod_293() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246185)) >= 0)
			{
				return (Class198.smethod_278() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246216)) >= 0)
			{
				return (Class198.smethod_279() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246233)) >= 0)
			{
				return (Class198.smethod_280() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246263)) >= 0)
			{
				return Class436.smethod_3();
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246283)) >= 0)
			{
				return (Class198.smethod_285() != 0) ? 1 : 0;
			}
			int num6 = Array.IndexOf(args, Class185.smethod_0(-1141246320));
			if (num6 >= 0)
			{
				if (num6 + 1 >= args.Length)
				{
					Console.Error.WriteLine(Class185.smethod_0(-1141246877) + Class135.smethod_4() + Class185.smethod_0(-1141246329));
					return 2;
				}
				return Class198.smethod_274(args[num6 + 1]);
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246362)) >= 0)
			{
				return Class198.smethod_269();
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246388)) >= 0)
			{
				return Class198.smethod_270();
			}
			int num7 = Array.IndexOf(args, Class185.smethod_0(-1141246416));
			if (num7 >= 0)
			{
				if (num7 + 2 >= args.Length)
				{
					Console.Error.WriteLine(Class185.smethod_0(-1141246877) + Class135.smethod_4() + Class185.smethod_0(-1141246436));
					return 2;
				}
				return Class198.smethod_265(args[num7 + 1], args[num7 + 2]);
			}
			int num8 = Array.IndexOf(args, Class185.smethod_0(-1141247521));
			if (num8 >= 0)
			{
				return Class198.smethod_271((num8 + 1 < args.Length) ? args[num8 + 1] : null);
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247551)) >= 0)
			{
				return (Class198.smethod_284() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247563)) >= 0)
			{
				return (Class198.smethod_286() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247599)) >= 0)
			{
				return smethod_1(args);
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247620)) >= 0)
			{
				return (Class198.smethod_290() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247647)) >= 0)
			{
				return (Class198.smethod_291() != 0) ? 1 : 0;
			}
			int num9 = Array.IndexOf(args, Class185.smethod_0(-1141247669));
			if (num9 >= 0)
			{
				if (num9 + 2 >= args.Length)
				{
					Console.Error.WriteLine(Class185.smethod_0(-1141246877) + Class135.smethod_4() + Class185.smethod_0(-1141247697));
					return 2;
				}
				return Class198.smethod_33(args[num9 + 1], args[num9 + 2]);
			}
			int num10 = Array.IndexOf(args, Class185.smethod_0(-1141247775));
			if (num10 >= 0)
			{
				if (num10 + 1 >= args.Length)
				{
					Console.Error.WriteLine(Class185.smethod_0(-1141246877) + Class135.smethod_4() + Class185.smethod_0(-1141247809));
					return 2;
				}
				return Class198.smethod_34(args[num10 + 1]);
			}
			int num11 = Array.IndexOf(args, Class185.smethod_0(-1141247880));
			if (num11 >= 0)
			{
				if (num11 + 2 >= args.Length)
				{
					Console.Error.WriteLine(Class185.smethod_0(-1141246877) + Class135.smethod_4() + Class185.smethod_0(-1141247926));
					return 2;
				}
				return Class198.smethod_35(args[num11 + 1], args[num11 + 2]);
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141246982)) >= 0)
			{
				return (Class198.smethod_57() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247002)) >= 0)
			{
				return (Class198.smethod_276() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247039)) >= 0)
			{
				return (Class198.smethod_100() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247064)) >= 0)
			{
				return (Class198.smethod_101() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247088)) >= 0)
			{
				return (Class198.smethod_115() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247111)) >= 0)
			{
				return (Class198.smethod_116() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247124)) >= 0)
			{
				return (Class198.smethod_117() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247146)) >= 0)
			{
				return (Class198.smethod_118() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247174)) >= 0)
			{
				return (Class198.smethod_119() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247200)) >= 0)
			{
				return (Class198.smethod_246() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247223)) >= 0)
			{
				return (Class198.smethod_245() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247234)) >= 0)
			{
				return (Class198.smethod_247() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247251)) >= 0)
			{
				return (Class198.smethod_248() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247286)) >= 0)
			{
				return (Class198.smethod_102() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247309)) >= 0)
			{
				return (Class198.smethod_103() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247327)) >= 0)
			{
				return (Class198.smethod_120() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247340)) >= 0)
			{
				return (Class198.smethod_147() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247365)) >= 0)
			{
				return (Class198.smethod_148() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247378)) >= 0)
			{
				return (Class198.smethod_149() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247407)) >= 0)
			{
				return (Class198.smethod_150() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247430)) >= 0)
			{
				return (Class198.smethod_151() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247442)) >= 0)
			{
				return (Class198.smethod_231() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247465)) >= 0)
			{
				return (Class198.smethod_152() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141247482)) >= 0)
			{
				return (Class198.smethod_44() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244445)) >= 0)
			{
				return (Class198.smethod_232() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244463)) >= 0)
			{
				return (Class198.smethod_125() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244476)) >= 0)
			{
				return (Class198.smethod_126() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244504)) >= 0)
			{
				return (Class198.smethod_127() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244526)) >= 0)
			{
				return (Class198.smethod_128() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244538)) >= 0)
			{
				return (Class198.smethod_144() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244568)) >= 0)
			{
				return (Class198.smethod_130() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244589)) >= 0)
			{
				return (Class198.smethod_294() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244615)) >= 0)
			{
				return (Class198.smethod_295() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244634)) >= 0)
			{
				return (Class198.smethod_296() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244666)) >= 0)
			{
				return (Class198.smethod_297() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244692)) >= 0)
			{
				return (Class198.smethod_298() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244733)) >= 0)
			{
				return (Class198.smethod_299() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244774)) >= 0)
			{
				return (Class198.smethod_154() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244787)) >= 0)
			{
				return (Class198.smethod_155() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244813)) >= 0)
			{
				return (Class198.smethod_212() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244825)) >= 0)
			{
				return (Class198.smethod_213() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244850)) >= 0)
			{
				return (Class198.smethod_48() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244881)) >= 0)
			{
				return (Class198.smethod_47() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244906)) >= 0)
			{
				return (Class198.smethod_282() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141243909)) >= 0)
			{
				return (Class198.smethod_129() != 0) ? 1 : 0;
			}
			int num12 = Array.IndexOf(args, Class185.smethod_0(-1141243934));
			if (num12 >= 0)
			{
				if (num12 + 2 >= args.Length)
				{
					Console.Error.WriteLine(Class185.smethod_0(-1141246877) + Class135.smethod_4() + Class185.smethod_0(-1141243966));
					return 2;
				}
				return Class198.smethod_53(args[num12 + 1], args[num12 + 2]);
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244023)) >= 0)
			{
				return (Class198.smethod_52() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244042)) >= 0)
			{
				return (Class198.smethod_42() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244077)) >= 0)
			{
				return (Class198.smethod_45() != 0) ? 1 : 0;
			}
			if (Array.IndexOf(args, Class185.smethod_0(-1141244098)) >= 0)
			{
				return (Class198.smethod_43() != 0) ? 1 : 0;
			}
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141244121));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141244178));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141244228));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141244289));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141244354));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245470));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245532));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245595));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245678));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245744));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245801));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245875));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245946));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141244995));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245066));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245156));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245239));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245342));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141245406));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250601));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250674));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250744));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250804));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250874));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250954));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251018));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250057));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250126));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250190));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250256));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250308));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250392));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250459));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141250538));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251648));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251717));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251771));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251848));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251909));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251989));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141252061));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251106));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251174));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251246));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251308));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251383));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251444));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141251513));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248520));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248579));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248656));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248732));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248796));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248869));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248924));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248996));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248053));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248131));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248213));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248280));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248358));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141248429));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141249539));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141249617));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141249727));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141249811));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141249900));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141249971));
			Console.WriteLine(Class135.smethod_4() + Class185.smethod_0(-1141249077));
			return 2;
		}
		smethod_0();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		if (!Class384.smethod_0(out var string_))
		{
			Class429.smethod_2(Class185.smethod_0(-1141249197) + string_, Class185.smethod_0(-1141249237), MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
				Class429.smethod_2(Class185.smethod_0(-1141249249) + ex.Message, Class185.smethod_0(-1141302218), MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
				Class429.smethod_2(Class185.smethod_0(-1141249249) + ex2.Message, Class185.smethod_0(-1141302218), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return 4;
			}
		}
		return 0;
	}

	private static int smethod_1(string[] string_1)
	{
		int num = Array.IndexOf(string_1, Class185.smethod_0(-1141249320));
		if (num >= 0 && num + 1 < string_1.Length && !string.IsNullOrWhiteSpace(string_1[num + 1]))
		{
			string environmentVariable = Environment.GetEnvironmentVariable(string_1[num + 1]);
			if (string.IsNullOrWhiteSpace(environmentVariable))
			{
				Console.Error.WriteLine(Class185.smethod_0(-1141249404));
				return 2;
			}
			int result2;
			try
			{
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMinutes(2.0));
				try
				{
					Class438 result = Class21.smethod_0(Class135.smethod_6(), Class135.smethod_7(), Class135.smethod_2(), AppDomain.CurrentDomain.BaseDirectory, environmentVariable, cancellationTokenSource.Token).GetAwaiter().GetResult();
					Console.WriteLine(Class185.smethod_0(-1141249478) + result.String_0);
					Console.WriteLine(Class185.smethod_0(-1141249494) + result.Int64_0);
					string text = Class185.smethod_0(-1141249518);
					result2 = result.IReadOnlyList_0.Count;
					Console.WriteLine(text + result2);
					string text2 = Class185.smethod_0(-1141249532);
					result2 = result.IReadOnlyList_1.Count;
					Console.WriteLine(text2 + result2);
					Console.WriteLine(Class185.smethod_0(-1141254683) + result.Int64_3);
					foreach (Class94 item in result.IReadOnlyList_1)
					{
						Console.WriteLine(item.String_3 + Class185.smethod_0(-1141299597) + item.String_0 + Class185.smethod_0(-1141299597) + item.String_1);
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
				Console.Error.WriteLine(Class185.smethod_0(-1141254706) + ex.GetType().Name);
				result2 = 1;
			}
			return result2;
		}
		Console.Error.WriteLine(Class185.smethod_0(-1141246877) + Class135.smethod_4() + Class185.smethod_0(-1141249330));
		return 2;
	}

	private static bool smethod_2(string string_1)
	{
		try
		{
			Directory.CreateDirectory(Path.GetDirectoryName(string_0));
			File.AppendAllText(string_0, DateTime.Now.ToString(Class185.smethod_0(-1141307993)) + Class185.smethod_0(-1141254743) + Process.GetCurrentProcess().Id + Class185.smethod_0(-1141299597) + string_1 + Environment.NewLine);
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
			smethod_2(Class185.smethod_0(-1141274467));
			gform2_0.method_0(Class185.smethod_0(-1141274495));
			gform2_0.method_1(20);
			GClass1 gClass = new GClass1();
			string text = gClass.method_1();
			string string_ = gClass.method_2();
			gform2_0.method_1(35);
			GClass20 gClass2 = new GClass20();
			gform2_0.method_0(Class185.smethod_0(-1141265671));
			gform2_0.method_1(45);
			smethod_2(Class185.smethod_0(-1141274532) + stopwatch.ElapsedMilliseconds);
			GClass0 gClass3 = await gClass2.method_2(text);
			smethod_2(Class185.smethod_0(-1141274570) + stopwatch.ElapsedMilliseconds + Class185.smethod_0(-1141274614) + ((gClass3 == null) ? Class185.smethod_0(-1141273631) : (gClass3.IsValid ? Class185.smethod_0(-1141273611) : Class185.smethod_0(-1141273605))));
			if (gClass3 != null && gClass3.IsValid)
			{
				Class426 class2 = new Class426();
				gform2_0.method_0(Class185.smethod_0(-1141273634));
				smethod_2(Class185.smethod_0(-1141273695) + stopwatch.ElapsedMilliseconds);
				class2.synchronizationContext_0 = SynchronizationContext.Current;
				if (class2.synchronizationContext_0 == null)
				{
					throw new InvalidOperationException(Class185.smethod_0(-1141265455));
				}
				Class17 class3 = new Class17();
				@class = new Class92(Class135.smethod_3(), Class92.timeSpan_1, Class343.smethod_3, class2.method_0, class3.method_0, Class427.class427_0.method_1);
				Class343.smethod_5();
				bool flag2 = await @class.method_0(Class343.smethod_4, Class92.timeSpan_0, Class92.timeSpan_1, CancellationToken.None);
				smethod_2(Class185.smethod_0(-1141273721) + stopwatch.ElapsedMilliseconds + Class185.smethod_0(-1141273753) + flag2);
				if (!flag2)
				{
					gform2_0.Hide();
					Application.Exit();
					return;
				}
				gform2_0.method_1(70);
				smethod_2(Class185.smethod_0(-1141273770) + stopwatch.ElapsedMilliseconds);
				(GClass17, GClass0) tuple = await gClass2.method_1(gClass3.LicenseKey, text, string_);
				smethod_2(Class185.smethod_0(-1141273809) + stopwatch.ElapsedMilliseconds);
				if (tuple.Item1 != null && tuple.Item1.Success)
				{
					gform2_0.method_1(100);
					smethod_2(Class185.smethod_0(-1141273854) + stopwatch.ElapsedMilliseconds);
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
					smethod_2(Class185.smethod_0(-1141273882) + stopwatch.ElapsedMilliseconds + Class185.smethod_0(-1141273925) + flag3);
				}
				else
				{
					Class429.smethod_1(Class185.smethod_0(-1141273944));
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
			smethod_2(Class185.smethod_0(-1141274007) + ex.GetType().FullName + Class185.smethod_0(-1141274025) + ex.Message);
			Class429.smethod_2(Class185.smethod_0(-1141274041) + ex.Message, Class185.smethod_0(-1141295830), MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
