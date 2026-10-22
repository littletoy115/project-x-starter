using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

internal sealed class Class119 : IDisposable
{
	private sealed class Class120
	{
		public Class400 class400_0;

		public Class119 class119_0;

		internal void method_0()
		{
			class119_0.action_3?.Invoke(class400_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct32 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Class119 class119_0;

		private int int_1;

		private float float_0;

		private float float_1;

		private float float_2;

		private Func<int, Task> func_0;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class119 @class = class119_0;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0175;
				}
				if (num == 1)
				{
					awaiter = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_023a;
				}
				object object_ = @class.object_7;
				bool lockTaken = false;
				try
				{
					Monitor.Enter(object_, ref lockTaken);
					if (!@class.bool_16)
					{
						@class.bool_16 = true;
						int_1 = @class.int_16;
						@class.method_129();
						Class83 class2 = @class.method_51().method_0();
						if (class2 != null)
						{
							float_0 = class2.float_0;
							float_1 = class2.float_1;
							float_2 = class2.float_2;
							if (@class.method_177(float_0 + 2f, float_1, float_2, bool_17: false, "attack_stop_nudge"))
							{
								goto IL_00cc;
							}
						}
					}
				}
				finally
				{
					if (num < 0 && lockTaken)
					{
						Monitor.Exit(object_);
					}
				}
				goto end_IL_000e;
				IL_023a:
				awaiter.GetResult();
				goto end_IL_000e;
				IL_00cc:
				func_0 = @class.func_1;
				awaiter = ((func_0 == null) ? Task.Delay(250) : func_0(250)).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					int_0 = 0;
					configuredTaskAwaiter_0 = awaiter;
					asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0175;
				IL_0175:
				awaiter.GetResult();
				object_ = @class.object_7;
				lockTaken = false;
				try
				{
					Monitor.Enter(object_, ref lockTaken);
					if (int_1 == @class.int_16 && @class.method_177(float_0 - 2f, float_1, float_2, bool_17: false, "attack_stop_nudge"))
					{
						goto IL_01dd;
					}
				}
				finally
				{
					if (num < 0 && lockTaken)
					{
						Monitor.Exit(object_);
					}
				}
				goto end_IL_000e;
				IL_01dd:
				awaiter = ((func_0 == null) ? Task.Delay(250) : func_0(250)).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					int_0 = 1;
					configuredTaskAwaiter_0 = awaiter;
					asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_023a;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				func_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			func_0 = null;
			asyncTaskMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private sealed class Class121
	{
		public int int_0;

		public ushort ushort_0;

		public ushort ushort_1;

		public int int_1;

		public ushort ushort_2;

		public ushort ushort_3;

		internal string method_0(uint uint_0)
		{
			return Class7.smethod_0(uint_0, int_0, ushort_0, ushort_1, int_1, ushort_2, ushort_3);
		}
	}

	private enum Enum6
	{

	}

	private sealed class Class122
	{
		public Class119 class119_0;

		public long long_0;

		public Action action_0;

		internal void method_0()
		{
			bool flag;
			lock (class119_0.object_1)
			{
				flag = long_0 == Interlocked.Read(ref class119_0.long_0) && long_0 != class119_0.long_1;
			}
			if (flag)
			{
				action_0();
			}
		}
	}

	private sealed class Class123
	{
		public Class119 class119_0;

		public IntPtr intptr_0;

		public string string_0;

		internal void method_0(object object_0)
		{
			lock (class119_0.object_0)
			{
				if (intptr_0.ToInt64() == Interlocked.Read(ref class119_0.long_0))
				{
					try
					{
						class119_0.method_180(string_0);
						return;
					}
					catch (Exception ex)
					{
						class119_0.method_208("stream ACK failed: " + ex.Message);
						return;
					}
				}
			}
		}
	}

	private sealed class Class124
	{
		public int int_0;

		public ushort ushort_0;

		public ushort ushort_1;

		internal string method_0(uint uint_0)
		{
			return Class7.smethod_1(uint_0, int_0, ushort_0, ushort_1);
		}
	}

	private sealed class Class125
	{
		public Class119 class119_0;

		public string string_0;

		internal void method_0()
		{
			class119_0.action_0?.Invoke(string_0);
		}
	}

	private sealed class Class126
	{
		public Class119 class119_0;

		public int int_0;

		internal void method_0()
		{
			class119_0.action_1?.Invoke(int_0);
		}
	}

	private sealed class Class127
	{
		public Class119 class119_0;

		public string string_0;

		public string string_1;

		public int int_0;

		internal Class87 method_0()
		{
			return class119_0.method_186(string_0, string_1, 3);
		}

		internal Class9 method_1()
		{
			int int_;
			return new Class9(class119_0.method_192(string_0, string_1, out int_), int_);
		}

		internal string method_2(int int_1)
		{
			return class119_0.method_189(string_0, string_1, int_0, int_1);
		}

		internal bool method_3()
		{
			return class119_0.method_73(string_0, string_1);
		}

		internal string method_4()
		{
			return class119_0.method_81(int_0);
		}

		internal void method_5()
		{
			class119_0.method_208("Run: attach found a confirmed unhealthy runner; recovering the runner once without restarting the game");
		}
	}

	private enum Enum7
	{

	}

	private sealed class Class128
	{
		public Action action_0;

		internal void method_0(object object_0)
		{
			action_0();
		}
	}

	private sealed class Class129
	{
		public Class101 class101_0;

		public Class119 class119_0;

		internal void method_0()
		{
			class119_0.action_2?.Invoke(class101_0);
		}
	}

	private sealed class Class130
	{
		public Interface2 interface2_0;

		public IntPtr intptr_0;

		public Exception exception_0;

		public Class119 class119_0;

		public Thread thread_0;

		internal void method_0()
		{
			try
			{
				interface2_0.imethod_7(intptr_0);
			}
			catch (Exception ex)
			{
				exception_0 = ex;
			}
			finally
			{
				class119_0.method_212();
				lock (class119_0.object_2)
				{
					if (class119_0.thread_0 == thread_0)
					{
						class119_0.thread_0 = null;
					}
				}
			}
		}
	}

	private IntPtr intptr_0;

	private readonly object object_0 = new object();

	private readonly object object_1 = new object();

	private readonly object object_2 = new object();

	private Interface2 interface2_0 = new Class439();

	private long long_0;

	private long long_1 = -1L;

	private readonly string string_0 = Guid.NewGuid().ToString("N");

	private Class363 class363_0;

	private Thread thread_0;

	private int int_0 = 10000;

	private Class63.Delegate15 delegate15_0;

	private Class63.Delegate16 delegate16_0;

	private readonly ManualResetEventSlim manualResetEventSlim_0 = new ManualResetEventSlim(initialState: false);

	private int int_1;

	private readonly ManualResetEventSlim manualResetEventSlim_1 = new ManualResetEventSlim(initialState: false);

	private int int_2;

	private int int_3;

	private long long_2 = -1L;

	private bool bool_0;

	private string string_1;

	private Class32 class32_0;

	private bool bool_1;

	private bool bool_2;

	private readonly ManualResetEventSlim manualResetEventSlim_2 = new ManualResetEventSlim(initialState: false);

	private int int_4;

	private int int_5;

	private int int_6;

	private long long_3 = -1L;

	private Class393 class393_0;

	private bool bool_3;

	private string string_2;

	private bool bool_4;

	private string string_3;

	private long long_4 = -1L;

	private Class147 class147_0 = Class147.smethod_0();

	private Func<Class175> func_0;

	private readonly ManualResetEventSlim manualResetEventSlim_3 = new ManualResetEventSlim(initialState: false);

	private readonly ManualResetEventSlim manualResetEventSlim_4 = new ManualResetEventSlim(initialState: false);

	private readonly ManualResetEventSlim manualResetEventSlim_5 = new ManualResetEventSlim(initialState: false);

	private string string_4;

	private string string_5;

	private List<Class403> list_0;

	private volatile bool bool_5;

	private volatile bool bool_6;

	private volatile bool bool_7;

	private volatile bool bool_8;

	private volatile bool bool_9;

	private volatile bool bool_10;

	private volatile bool bool_11;

	private volatile bool bool_12;

	private volatile bool bool_13;

	private volatile bool bool_14;

	private long long_5;

	private bool? nullable_0;

	private int int_7;

	private readonly object object_3 = new object();

	private long long_6;

	private long long_7;

	private int int_8;

	private Class60 class60_0;

	private readonly object object_4 = new object();

	private long long_8;

	private int int_9;

	private Class93 class93_0;

	private readonly object object_5 = new object();

	private long long_9;

	private int int_10;

	private uint uint_0;

	private string string_6;

	private Class194 class194_0;

	private volatile (ushort, ushort)[] valueTuple_0;

	private volatile Class358 class358_0;

	public SynchronizationContext synchronizationContext_0;

	private Action<string> action_0;

	private Action<int> action_1;

	private Action<Class101> action_2;

	private Action<Class400> action_3;

	private int int_11;

	private int int_12;

	private readonly object object_6 = new object();

	private uint uint_1;

	private string string_7;

	private int int_13;

	public string string_8;

	private bool bool_15;

	public readonly Dictionary<string, string> dictionary_0 = new Dictionary<string, string>(StringComparer.Ordinal);

	public readonly Dictionary<string, string> dictionary_1 = new Dictionary<string, string>(StringComparer.Ordinal);

	public readonly Dictionary<string, string> dictionary_2 = new Dictionary<string, string>(StringComparer.Ordinal);

	public int int_14 = 20;

	public int int_15 = 3;

	private volatile Class145 class145_0 = Class145.class145_0;

	private readonly object object_7 = new object();

	private bool bool_16;

	private int int_16;

	private Func<int, Task> func_1;

	private Action<string> action_4;

	private Func<string, int, Class71.Class72> func_2;

	private Action<int> action_5;

	private Func<Enum3> func_3;

	private Func<int, bool> func_4;

	private Func<int, bool> func_5;

	private Func<int, bool> func_6;

	private Action action_6;

	private Action action_7;

	private Action action_8;

	private Action<Class145> action_9;

	private Action<uint, int, bool, string> action_10;

	private Action<uint, bool, bool, string> action_11;

	private Action<int, bool, string> action_12;

	private Action<IReadOnlyList<string>> action_13;

	private Action<IReadOnlyList<GStruct1>> action_14;

	private Action<Class74> action_15;

	private string string_9;

	private string string_10;

	private string string_11;

	private string string_12;

	private string string_13;

	private Class409.Struct125[] struct125_0;

	private string string_14;

	private string string_15;

	private string string_16;

	private readonly Class172.Class173 class173_0 = new Class172.Class173();

	private readonly Class172.Class173 class173_1 = new Class172.Class173();

	private readonly Class172.Class173 class173_2 = new Class172.Class173();

	private static string string_17;

	public (ushort, ushort)[] ValueTuple_0 => valueTuple_0;

	internal Class363 method_0()
	{
		return class363_0;
	}

	internal void method_1(Class363 class363_1)
	{
		class363_0 = class363_1;
	}

	public void method_2(Action<string> action_16)
	{
		Action<string> action = action_0;
		Action<string> action2;
		do
		{
			action2 = action;
			Action<string> value = (Action<string>)Delegate.Combine(action2, action_16);
			action = Interlocked.CompareExchange(ref action_0, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_3(Action<string> action_16)
	{
		Action<string> action = action_0;
		Action<string> action2;
		do
		{
			action2 = action;
			Action<string> value = (Action<string>)Delegate.Remove(action2, action_16);
			action = Interlocked.CompareExchange(ref action_0, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_4(Action<int> action_16)
	{
		Action<int> action = action_1;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, action_16);
			action = Interlocked.CompareExchange(ref action_1, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_5(Action<int> action_16)
	{
		Action<int> action = action_1;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, action_16);
			action = Interlocked.CompareExchange(ref action_1, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_6(Action<Class101> action_16)
	{
		Action<Class101> action = action_2;
		Action<Class101> action2;
		do
		{
			action2 = action;
			Action<Class101> value = (Action<Class101>)Delegate.Combine(action2, action_16);
			action = Interlocked.CompareExchange(ref action_2, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_7(Action<Class101> action_16)
	{
		Action<Class101> action = action_2;
		Action<Class101> action2;
		do
		{
			action2 = action;
			Action<Class101> value = (Action<Class101>)Delegate.Remove(action2, action_16);
			action = Interlocked.CompareExchange(ref action_2, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_8(Action<Class400> action_16)
	{
		Action<Class400> action = action_3;
		Action<Class400> action2;
		do
		{
			action2 = action;
			Action<Class400> value = (Action<Class400>)Delegate.Combine(action2, action_16);
			action = Interlocked.CompareExchange(ref action_3, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_9(Action<Class400> action_16)
	{
		Action<Class400> action = action_3;
		Action<Class400> action2;
		do
		{
			action2 = action;
			Action<Class400> value = (Action<Class400>)Delegate.Remove(action2, action_16);
			action = Interlocked.CompareExchange(ref action_3, value, action2);
		}
		while ((object)action != action2);
	}

	public bool method_10()
	{
		return Volatile.Read(ref int_11) != 0;
	}

	public uint method_11()
	{
		return uint_1;
	}

	private void method_12(uint uint_2)
	{
		uint_1 = uint_2;
	}

	public string method_13()
	{
		return string_7;
	}

	private void method_14(string string_18)
	{
		string_7 = string_18;
	}

	public int method_15()
	{
		return int_13;
	}

	private void method_16(int int_17)
	{
		int_13 = int_17;
	}

	public bool method_17()
	{
		return bool_15;
	}

	private void method_18(bool bool_17)
	{
		bool_15 = bool_17;
	}

	public Class358 method_19()
	{
		return class358_0;
	}

	internal Class60 method_20()
	{
		return Volatile.Read(ref class60_0);
	}

	internal long method_21()
	{
		return Interlocked.Read(ref long_6);
	}

	internal long method_22()
	{
		return Interlocked.Read(ref long_7);
	}

	internal Class93 method_23()
	{
		return Volatile.Read(ref class93_0);
	}

	internal long method_24()
	{
		return Interlocked.Read(ref long_8);
	}

	internal Class194 method_25()
	{
		return Volatile.Read(ref class194_0);
	}

	internal long method_26()
	{
		return Interlocked.Read(ref long_9);
	}

	internal bool method_27()
	{
		lock (object_5)
		{
			return uint_0 != 0;
		}
	}

	public bool method_28()
	{
		return Volatile.Read(ref int_12) != 0;
	}

	internal void method_29(Func<int, Task> func_7)
	{
		func_1 = func_7;
	}

	internal void method_30(Action<string> action_16)
	{
		Volatile.Write(ref action_4, action_16);
	}

	internal void method_31(Func<string, int, Class71.Class72> func_7)
	{
		func_2 = func_7;
	}

	internal void method_32(Action<int> action_16)
	{
		action_5 = action_16;
	}

	internal void method_33(Func<Enum3> func_7)
	{
		func_3 = func_7;
	}

	internal void method_34(Interface2 interface2_1)
	{
		interface2_0 = interface2_1 ?? new Class439();
	}

	internal void method_35(Func<int, bool> func_7)
	{
		func_4 = func_7;
	}

	internal void method_36(Func<int, bool> func_7)
	{
		func_5 = func_7;
	}

	internal void method_37(Func<int, bool> func_7)
	{
		func_6 = func_7;
	}

	internal void method_38(Func<Class175> func_7)
	{
		func_0 = func_7;
	}

	internal void method_39(Class32 class32_1)
	{
		class32_0 = class32_1;
	}

	internal void method_40(Action action_16)
	{
		action_6 = action_16;
	}

	internal void method_41(Action action_16)
	{
		action_7 = action_16;
	}

	internal void method_42(Action action_16)
	{
		action_8 = action_16;
	}

	internal void method_43(int int_17)
	{
		Interlocked.Exchange(ref int_7, int_17);
	}

	internal void method_44(long long_10)
	{
		Interlocked.Exchange(ref long_0, long_10);
	}

	internal void method_45(IntPtr intptr_1, IntPtr intptr_2, int int_17, IntPtr intptr_3)
	{
		method_199(intptr_1, intptr_2, int_17, intptr_3);
	}

	internal void method_46(uint uint_2)
	{
		method_12(uint_2);
	}

	internal IntPtr method_47()
	{
		return intptr_0;
	}

	internal void method_48(int int_17)
	{
		int_0 = int_17;
	}

	internal bool method_49()
	{
		return method_213();
	}

	internal Class147 method_50()
	{
		lock (object_1)
		{
			return class147_0;
		}
	}

	public Class145 method_51()
	{
		return class145_0;
	}

	public void method_52(Action<Class145> action_16)
	{
		Action<Class145> action = action_9;
		Action<Class145> action2;
		do
		{
			action2 = action;
			Action<Class145> value = (Action<Class145>)Delegate.Combine(action2, action_16);
			action = Interlocked.CompareExchange(ref action_9, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_53(Action<Class145> action_16)
	{
		Action<Class145> action = action_9;
		Action<Class145> action2;
		do
		{
			action2 = action;
			Action<Class145> value = (Action<Class145>)Delegate.Remove(action2, action_16);
			action = Interlocked.CompareExchange(ref action_9, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_54(Action<uint, int, bool, string> action_16)
	{
		Action<uint, int, bool, string> action = action_10;
		Action<uint, int, bool, string> action2;
		do
		{
			action2 = action;
			Action<uint, int, bool, string> value = (Action<uint, int, bool, string>)Delegate.Combine(action2, action_16);
			action = Interlocked.CompareExchange(ref action_10, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_55(Action<uint, int, bool, string> action_16)
	{
		Action<uint, int, bool, string> action = action_10;
		Action<uint, int, bool, string> action2;
		do
		{
			action2 = action;
			Action<uint, int, bool, string> value = (Action<uint, int, bool, string>)Delegate.Remove(action2, action_16);
			action = Interlocked.CompareExchange(ref action_10, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_56(Action<uint, bool, bool, string> action_16)
	{
		Action<uint, bool, bool, string> action = action_11;
		Action<uint, bool, bool, string> action2;
		do
		{
			action2 = action;
			Action<uint, bool, bool, string> value = (Action<uint, bool, bool, string>)Delegate.Combine(action2, action_16);
			action = Interlocked.CompareExchange(ref action_11, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_57(Action<uint, bool, bool, string> action_16)
	{
		Action<uint, bool, bool, string> action = action_11;
		Action<uint, bool, bool, string> action2;
		do
		{
			action2 = action;
			Action<uint, bool, bool, string> value = (Action<uint, bool, bool, string>)Delegate.Remove(action2, action_16);
			action = Interlocked.CompareExchange(ref action_11, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_58(Action<int, bool, string> action_16)
	{
		Action<int, bool, string> action = action_12;
		Action<int, bool, string> action2;
		do
		{
			action2 = action;
			Action<int, bool, string> value = (Action<int, bool, string>)Delegate.Combine(action2, action_16);
			action = Interlocked.CompareExchange(ref action_12, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_59(Action<int, bool, string> action_16)
	{
		Action<int, bool, string> action = action_12;
		Action<int, bool, string> action2;
		do
		{
			action2 = action;
			Action<int, bool, string> value = (Action<int, bool, string>)Delegate.Remove(action2, action_16);
			action = Interlocked.CompareExchange(ref action_12, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_60(Action<IReadOnlyList<string>> action_16)
	{
		Action<IReadOnlyList<string>> action = action_13;
		Action<IReadOnlyList<string>> action2;
		do
		{
			action2 = action;
			Action<IReadOnlyList<string>> value = (Action<IReadOnlyList<string>>)Delegate.Combine(action2, action_16);
			action = Interlocked.CompareExchange(ref action_13, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_61(Action<IReadOnlyList<string>> action_16)
	{
		Action<IReadOnlyList<string>> action = action_13;
		Action<IReadOnlyList<string>> action2;
		do
		{
			action2 = action;
			Action<IReadOnlyList<string>> value = (Action<IReadOnlyList<string>>)Delegate.Remove(action2, action_16);
			action = Interlocked.CompareExchange(ref action_13, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_62(Action<IReadOnlyList<GStruct1>> action_16)
	{
		Action<IReadOnlyList<GStruct1>> action = action_14;
		Action<IReadOnlyList<GStruct1>> action2;
		do
		{
			action2 = action;
			Action<IReadOnlyList<GStruct1>> value = (Action<IReadOnlyList<GStruct1>>)Delegate.Combine(action2, action_16);
			action = Interlocked.CompareExchange(ref action_14, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_63(Action<IReadOnlyList<GStruct1>> action_16)
	{
		Action<IReadOnlyList<GStruct1>> action = action_14;
		Action<IReadOnlyList<GStruct1>> action2;
		do
		{
			action2 = action;
			Action<IReadOnlyList<GStruct1>> value = (Action<IReadOnlyList<GStruct1>>)Delegate.Remove(action2, action_16);
			action = Interlocked.CompareExchange(ref action_14, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_64(Action<Class74> action_16)
	{
		Action<Class74> action = action_15;
		Action<Class74> action2;
		do
		{
			action2 = action;
			Action<Class74> value = (Action<Class74>)Delegate.Combine(action2, action_16);
			action = Interlocked.CompareExchange(ref action_15, value, action2);
		}
		while ((object)action != action2);
	}

	public void method_65(Action<Class74> action_16)
	{
		Action<Class74> action = action_15;
		Action<Class74> action2;
		do
		{
			action2 = action;
			Action<Class74> value = (Action<Class74>)Delegate.Remove(action2, action_16);
			action = Interlocked.CompareExchange(ref action_15, value, action2);
		}
		while ((object)action != action2);
	}

	public bool method_66(string string_18, string string_19, int int_17)
	{
		lock (object_0)
		{
			return method_67(string_18, string_19, int_17);
		}
	}

	private bool method_67(string string_18, string string_19, int int_17)
	{
		method_14(string_19);
		method_16(int_17);
		method_211();
		if (method_213())
		{
			method_208("Run: the previous native session is still closing; no device action was started");
			return false;
		}
		string text = method_70(string_18, string_19, int_17);
		if (text != null)
		{
			method_208("Run: " + text);
			return false;
		}
		text = method_74(string_18, string_19);
		if (text != null)
		{
			method_208("Run: " + text);
			return false;
		}
		text = method_71(string_18, string_19);
		if (text != null)
		{
			method_208("Run: " + text);
			return false;
		}
		text = method_81(int_17);
		if (text != null)
		{
			method_72(string_18, string_19, int_17, ref text);
			if (text != null)
			{
				method_208("Run: " + text);
				return false;
			}
		}
		if (!method_90())
		{
			return false;
		}
		Volatile.Write(ref int_11, 1);
		smethod_1(string_19, method_11());
		method_208("Run: attached and offsets sent - log into the game, then press Select");
		return true;
	}

	public bool method_68(string string_18, string string_19, int int_17)
	{
		lock (object_0)
		{
			return method_69(string_18, string_19, int_17);
		}
	}

	private bool method_69(string string_18, string string_19, int int_17)
	{
		method_14(string_19);
		method_16(int_17);
		method_211();
		if (method_213())
		{
			method_208("Attach: the previous native session is still closing; attach was not started");
			return false;
		}
		string text = method_70(string_18, string_19, int_17);
		if (text != null)
		{
			method_208("Attach: " + text);
			return false;
		}
		text = method_75(string_18, string_19);
		if (text != null)
		{
			method_208("Attach: " + text);
			return false;
		}
		if (!smethod_3(string_19, method_11()))
		{
			method_208("Attach: game pid " + method_11() + " was not started by Run (last Run pid " + smethod_2(string_19) + ") - press Run first");
			return false;
		}
		text = method_77(string_18, string_19);
		if (text != null)
		{
			method_208("Attach: " + text);
			return false;
		}
		text = method_71(string_18, string_19);
		if (text != null)
		{
			method_208("Attach: " + text);
			return false;
		}
		text = method_81(int_17);
		if (text != null)
		{
			method_72(string_18, string_19, int_17, ref text);
			if (text != null)
			{
				method_208("Attach: " + text);
				return false;
			}
		}
		if (!method_90())
		{
			return false;
		}
		Volatile.Write(ref int_11, 1);
		method_208("Attach: attached to the running game and offsets sent");
		return true;
	}

	private static string smethod_0(string string_18)
	{
		return "LastRunPid_" + (string_18 ?? string.Empty);
	}

	internal static void smethod_1(string string_18, uint uint_2)
	{
		Class340.smethod_3(smethod_0(string_18), uint_2.ToString(CultureInfo.InvariantCulture));
	}

	internal static uint smethod_2(string string_18)
	{
		if (!uint.TryParse(Class340.smethod_2(smethod_0(string_18), string.Empty), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
		{
			return 0u;
		}
		return result;
	}

	internal static bool smethod_3(string string_18, uint uint_2)
	{
		if (uint_2 != 0)
		{
			return uint_2 == smethod_2(string_18);
		}
		return false;
	}

	private string method_70(string string_18, string string_19, int int_17)
	{
		string text = Class71.smethod_0(string_18, string_19, "get-state", 8000).Trim();
		if (text != "device")
		{
			return "device not reachable: " + text;
		}
		int int_18;
		if (Class180.smethod_0())
		{
			string text2 = method_192(string_18, string_19, out int_18);
			if (text2 != null)
			{
				return text2;
			}
		}
		else
		{
			string text3 = method_198(string_18, string_19);
			if (text3 != null)
			{
				return text3;
			}
			int_18 = 27042;
			string_8 = null;
		}
		return method_189(string_18, string_19, int_17, int_18);
	}

	private string method_71(string string_18, string string_19)
	{
		try
		{
			class32_0 = Class442.smethod_0(string_18, string_19);
			method_208("Run: agent license library verified, sha256=" + class32_0.string_3);
			return null;
		}
		catch (Exception ex)
		{
			class32_0 = null;
			return "agent license library deployment failed: " + ex.Message;
		}
	}

	private bool method_72(string string_18, string string_19, int int_17, ref string string_20)
	{
		Class127 @class = new Class127();
		@class.class119_0 = this;
		@class.string_0 = string_18;
		@class.string_1 = string_19;
		@class.int_0 = int_17;
		if (method_213())
		{
			string_20 += "; the failed native session is still closing, so runner recovery was skipped";
			return false;
		}
		Class414 class414_ = new Class414
		{
			func_0 = @class.method_0,
			func_1 = @class.method_1,
			func_2 = @class.method_2,
			func_3 = @class.method_3,
			func_4 = @class.method_4,
			action_0 = @class.method_5
		};
		Class3 class2 = Class142.smethod_0(string_20, Class180.smethod_0(), class414_);
		string_20 = class2.string_0;
		if (class2.bool_0 && string_20 == null)
		{
			method_208("Run: runner recovery attached to existing game pid " + method_11());
		}
		else if (!class2.bool_0 && string_20 != null && string_20.IndexOf("runner health is unknown", StringComparison.OrdinalIgnoreCase) >= 0)
		{
			method_208("Run: " + string_20);
		}
		return class2.bool_0;
	}

	private bool method_73(string string_18, string string_19)
	{
		string[] array = method_181(string_18, string_19, "shell pidof com.klab.klassxonline", 8000).Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (uint.TryParse(array[num], out var result) && result == method_11())
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private string method_74(string string_18, string string_19)
	{
		method_208("Run: restarting com.klab.klassxonline");
		Class71.smethod_0(string_18, string_19, "shell am force-stop com.klab.klassxonline", 15000);
		Class71.smethod_0(string_18, string_19, "shell monkey -p com.klab.klassxonline -c android.intent.category.LAUNCHER 1", 20000);
		return method_76(string_18, string_19);
	}

	private string method_75(string string_18, string string_19)
	{
		int num = 0;
		uint result;
		while (true)
		{
			if (num < 30)
			{
				if (uint.TryParse(Class71.smethod_0(string_18, string_19, "shell pidof com.klab.klassxonline", 8000).Trim().Split(' ')[0], out result) && result != 0)
				{
					break;
				}
				Thread.Sleep(1000);
				num++;
				continue;
			}
			return "the game is not running";
		}
		method_12(result);
		method_208("game pid " + result);
		return null;
	}

	private string method_76(string string_18, string string_19)
	{
		string text = method_75(string_18, string_19);
		if (text != null)
		{
			return text;
		}
		return method_77(string_18, string_19);
	}

	private string method_77(string string_18, string string_19)
	{
		DateTime utcNow = DateTime.UtcNow;
		int num = 0;
		while (true)
		{
			if (num < 90)
			{
				if (int.TryParse(Class71.smethod_0(string_18, string_19, "shell \"su 0 grep -c libil2cpp /proc/" + method_11() + "/maps\"", 8000).Trim(), out var result) && result > 0)
				{
					break;
				}
				Thread.Sleep(1000);
				num++;
				continue;
			}
			return "libil2cpp.so was not mapped within 90 s";
		}
		method_208("Run: libil2cpp mapped after " + (int)(DateTime.UtcNow - utcNow).TotalMilliseconds + " ms");
		return null;
	}

	internal string method_78(int int_17)
	{
		return method_79(int_17, bool_17: false);
	}

	internal string method_79(int int_17, bool bool_17)
	{
		lock (object_0)
		{
			bool_1 = !bool_17;
			bool_2 = true;
			try
			{
				return method_81(int_17);
			}
			finally
			{
				bool_1 = false;
				bool_2 = false;
			}
		}
	}

	internal string method_80(int int_17)
	{
		lock (object_0)
		{
			return method_81(int_17);
		}
	}

	private string method_81(int int_17)
	{
		if (method_213())
		{
			return "the previous native session is still closing; attach was not started";
		}
		IntPtr intPtr = interface2_0.imethod_0();
		if (intPtr == IntPtr.Zero)
		{
			return "klx_open failed";
		}
		bool flag = false;
		long num = Interlocked.Increment(ref long_0);
		try
		{
			manualResetEventSlim_0.Reset();
			lock (object_1)
			{
				Volatile.Write(ref int_1, 0);
				long_1 = -1L;
			}
			delegate15_0 = method_199;
			delegate16_0 = method_204;
			interface2_0.imethod_4(intPtr, delegate15_0, delegate16_0, new IntPtr(num));
			string text = "127.0.0.1:" + int_17;
			if (interface2_0.imethod_1(intPtr, text, string_8, 5000) == 0)
			{
				return "connect " + text + " failed: " + interface2_0.imethod_6(intPtr);
			}
			method_208("Run: registered remote endpoint " + text);
			if (interface2_0.imethod_2(intPtr, method_11(), 1) == 0)
			{
				return "attach failed: " + interface2_0.imethod_6(intPtr);
			}
			method_208("Run: connected and attached, realm=emulated");
			string value = smethod_61();
			if (string.IsNullOrEmpty(value))
			{
				return "the embedded agent (runtime.js) is missing";
			}
			if (interface2_0.imethod_3(intPtr, value, 0) == 0)
			{
				return "load failed: " + interface2_0.imethod_6(intPtr);
			}
			Func<int, bool> func = func_4;
			bool num2;
			if (func == null)
			{
				if (!manualResetEventSlim_0.Wait(30000))
				{
					goto IL_01e9;
				}
				num2 = Volatile.Read(ref int_1) != 0;
			}
			else
			{
				num2 = func(30000);
			}
			if (num2)
			{
				action_6?.Invoke();
				string text2 = method_82(intPtr, num);
				if (text2 != null)
				{
					return text2;
				}
				if (!bool_2)
				{
					string text3 = method_83(intPtr, num);
					if (text3 != null)
					{
						return text3;
					}
				}
				lock (object_1)
				{
					if (num != Interlocked.Read(ref long_0) || long_1 == num || (func == null && Volatile.Read(ref int_1) == 0))
					{
						return "the agent detached during startup";
					}
					intptr_0 = intPtr;
					flag = true;
				}
				return null;
			}
			goto IL_01e9;
			IL_01e9:
			return "the agent never said ready";
		}
		finally
		{
			if (!flag)
			{
				lock (object_1)
				{
					Interlocked.CompareExchange(ref long_0, num + 1L, num);
				}
				method_214(intPtr);
			}
		}
	}

	private string method_82(IntPtr intptr_1, long long_10)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		Class32 @class = class32_0;
		if (@class == null)
		{
			if (!bool_1)
			{
				return "the agent license deployment descriptor is missing";
			}
			return null;
		}
		int num;
		do
		{
			num = Interlocked.Increment(ref int_2);
		}
		while (num <= 0);
		lock (object_1)
		{
			if (long_10 != Interlocked.Read(ref long_0) || long_1 == long_10)
			{
				return "the agent detached before libshare initialization";
			}
			manualResetEventSlim_1.Reset();
			int_3 = num;
			long_2 = -1L;
			bool_0 = false;
			string_1 = null;
		}
		string text = ((JToken)new JObject
		{
			["cmd"] = JToken.op_Implicit("libshare_init"),
			["req"] = JToken.op_Implicit(num),
			["package"] = JToken.op_Implicit(@class.string_0),
			["path"] = JToken.op_Implicit(@class.string_2),
			["sha256"] = JToken.op_Implicit(@class.string_3)
		}).ToString((Formatting)0, Array.Empty<JsonConverter>());
		interface2_0.imethod_5(intptr_1, text, null, 0);
		bool flag = func_5?.Invoke(10000) ?? manualResetEventSlim_1.Wait(10000);
		lock (object_1)
		{
			if (long_10 != Interlocked.Read(ref long_0) || long_1 == long_10)
			{
				return "the agent detached during libshare initialization";
			}
			if (!flag)
			{
				return "the agent never reported libshare initialization";
			}
			if (long_2 != long_10 || int_3 != num || string_1 == null)
			{
				return "the agent did not answer the current libshare request";
			}
			if (!bool_0)
			{
				return "libshare initialization failed: " + string_1;
			}
		}
		method_208("Run: libshare initialized, api=1, abi=arm64-v8a");
		return null;
	}

	private string method_83(IntPtr intptr_1, long long_10)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		Func<Class175> func = func_0;
		if (func == null)
		{
			return "agent license authenticated identity provider is missing";
		}
		Class175 class175_;
		try
		{
			class175_ = func();
			Class103.smethod_3(class175_);
		}
		catch
		{
			return "agent license authenticated identity is missing or invalid";
		}
		Stopwatch stopwatch_ = Stopwatch.StartNew();
		int num = method_85();
		lock (object_1)
		{
			if (!method_86(long_10))
			{
				return "the agent detached before license initialization";
			}
			manualResetEventSlim_2.Reset();
			int_5 = num;
			int_6 = 0;
			long_3 = -1L;
			class393_0 = null;
			bool_3 = false;
			string_2 = null;
			bool_4 = true;
			string_3 = null;
			long_4 = -1L;
			class147_0 = Class147.smethod_0();
		}
		try
		{
			interface2_0.imethod_5(intptr_1, ((JToken)new JObject
			{
				["cmd"] = JToken.op_Implicit("license_open"),
				["req"] = JToken.op_Implicit(num)
			}).ToString((Formatting)0, Array.Empty<JsonConverter>()), null, 0);
		}
		catch
		{
			method_87(intptr_1, null);
			method_88(long_10);
			return "agent license open command failed";
		}
		if (!method_84(stopwatch_))
		{
			method_87(intptr_1, null);
			method_88(long_10);
			return "the agent never reported license initialization";
		}
		bool flag;
		bool flag2;
		Class393 @class;
		string text;
		lock (object_1)
		{
			flag = !(flag2 = !method_86(long_10)) && (long_3 != long_10 || int_5 != num || (class393_0 == null && string_2 == null));
			@class = class393_0;
			text = string_2;
		}
		if (flag2)
		{
			method_87(intptr_1, null);
			return "the agent detached during license initialization";
		}
		if (flag)
		{
			method_87(intptr_1, null);
			method_88(long_10);
			return "the agent did not answer the current license request";
		}
		if (@class == null)
		{
			method_87(intptr_1, null);
			method_88(long_10);
			return "agent license handshake failed: " + text;
		}
		int num2 = method_85();
		Class103 class2;
		try
		{
			class2 = Class103.smethod_0(@class, class175_);
		}
		catch
		{
			method_87(intptr_1, @class.method_0());
			method_88(long_10);
			return "agent license cryptographic bootstrap failed";
		}
		using (Class103 class3 = class2)
		{
			lock (object_1)
			{
				if (!method_86(long_10))
				{
					return "the agent detached before license bootstrap";
				}
				manualResetEventSlim_2.Reset();
				int_5 = 0;
				int_6 = num2;
				long_3 = -1L;
				bool_3 = false;
				string_2 = null;
			}
			try
			{
				interface2_0.imethod_5(intptr_1, ((JToken)new JObject
				{
					["cmd"] = JToken.op_Implicit("license_bootstrap"),
					["req"] = JToken.op_Implicit(num2),
					["sessionId"] = JToken.op_Implicit(@class.method_0()),
					["clientPublicKey"] = JToken.op_Implicit(Class349.smethod_0(class3.byte_0)),
					["nonce"] = JToken.op_Implicit(Class349.smethod_0(class3.byte_1)),
					["tag"] = JToken.op_Implicit(Class349.smethod_0(class3.byte_2)),
					["ciphertext"] = JToken.op_Implicit(Class349.smethod_0(class3.byte_3))
				}).ToString((Formatting)0, Array.Empty<JsonConverter>()), null, 0);
			}
			catch
			{
				method_87(intptr_1, @class.method_0());
				method_88(long_10);
				return "agent license bootstrap command failed";
			}
		}
		if (!method_84(stopwatch_))
		{
			method_87(intptr_1, @class.method_0());
			method_88(long_10);
			return "the agent never reported license bootstrap";
		}
		bool flag3;
		bool flag4;
		bool flag5;
		lock (object_1)
		{
			flag3 = !(flag4 = !(flag5 = !method_86(long_10)) && (long_3 != long_10 || int_6 != num2 || string_2 == null)) && bool_3;
			text = string_2;
			if (!flag5 && !flag4 && flag3)
			{
				int_6 = 0;
			}
		}
		if (flag5)
		{
			method_87(intptr_1, @class.method_0());
			return "the agent detached during license bootstrap";
		}
		if (flag4)
		{
			method_87(intptr_1, @class.method_0());
			method_88(long_10);
			return "the agent did not answer the current license bootstrap request";
		}
		if (!flag3)
		{
			method_87(intptr_1, @class.method_0());
			method_88(long_10);
			return "agent license bootstrap failed: " + text;
		}
		method_208("Run: agent license encrypted bootstrap initialized");
		return null;
	}

	private bool method_84(Stopwatch stopwatch_0)
	{
		int num = 30000 - (int)Math.Min(30000L, stopwatch_0.ElapsedMilliseconds);
		if (num <= 0)
		{
			return false;
		}
		return func_6?.Invoke(num) ?? manualResetEventSlim_2.Wait(num);
	}

	private int method_85()
	{
		int num;
		while (true)
		{
			num = Interlocked.Increment(ref int_4);
			if (num > 0)
			{
				break;
			}
			if (num == int.MinValue)
			{
				Interlocked.CompareExchange(ref int_4, 0, num);
			}
		}
		return num;
	}

	private bool method_86(long long_10)
	{
		if (long_10 == Interlocked.Read(ref long_0))
		{
			return long_1 != long_10;
		}
		return false;
	}

	private void method_87(IntPtr intptr_1, string string_18)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		if (intptr_1 == IntPtr.Zero)
		{
			return;
		}
		try
		{
			JObject val = new JObject { ["cmd"] = JToken.op_Implicit("license_dispose") };
			if (!string.IsNullOrEmpty(string_18))
			{
				val["sessionId"] = JToken.op_Implicit(string_18);
			}
			interface2_0.imethod_5(intptr_1, ((JToken)val).ToString((Formatting)0, Array.Empty<JsonConverter>()), null, 0);
		}
		catch
		{
		}
	}

	private void method_88(long long_10)
	{
		lock (object_1)
		{
			if (long_4 == long_10 || long_4 == -1L)
			{
				method_89();
			}
		}
	}

	private void method_89()
	{
		manualResetEventSlim_2.Reset();
		int_5 = 0;
		int_6 = 0;
		long_3 = -1L;
		class393_0 = null;
		bool_3 = false;
		string_2 = null;
		bool_4 = false;
		string_3 = null;
		long_4 = -1L;
		class147_0 = Class147.smethod_0();
	}

	private bool method_90()
	{
		long long_ = Interlocked.Read(ref long_0);
		string text = Class431.smethod_0();
		if (text == null)
		{
			method_208("Run: offsets not loaded - log in first");
			return false;
		}
		manualResetEventSlim_4.Reset();
		bool_5 = false;
		bool_10 = false;
		bool_6 = false;
		bool_7 = false;
		bool_8 = false;
		bool_9 = false;
		bool_11 = false;
		bool_12 = false;
		bool_13 = false;
		method_99();
		method_146();
		method_155();
		method_162();
		class145_0 = Class145.class145_0;
		string_5 = null;
		method_178(text);
		if (!manualResetEventSlim_4.Wait(15000))
		{
			method_208("Run: the agent never answered the offsets");
			return false;
		}
		if (!smethod_58(string_5, "ok"))
		{
			method_208("Run: offsets refused: " + string_5);
			return false;
		}
		bool_5 = smethod_58(string_5, "atkReady");
		bool_10 = smethod_58(string_5, "partyReady");
		bool_6 = smethod_58(string_5, "skillReady");
		bool_7 = smethod_58(string_5, "pickReady");
		bool_8 = smethod_58(string_5, "rebuffReady");
		bool_9 = smethod_58(string_5, "bagReady");
		bool_11 = smethod_58(string_5, "loadingReady");
		bool_12 = smethod_58(string_5, "rebirthReady");
		bool_13 = smethod_58(string_5, "camReady");
		method_100(string_5, long_);
		if (Class357.smethod_34() && !bool_5)
		{
			method_208("Run: the attack tier did not arm - attack mode will not press");
		}
		if (Class357.smethod_68() && !bool_10)
		{
			method_208("Run: the party tier did not arm - player selection is unavailable");
		}
		if (Class357.smethod_36() && !bool_6)
		{
			method_208("Run: the skill tier did not arm - the rotation will not cast");
		}
		if (Class357.smethod_38() && !bool_7)
		{
			method_208("Run: the pick tier did not arm - nothing will be picked up");
		}
		if (Class357.smethod_52() && !bool_8)
		{
			method_208("Run: the rebuff tier did not arm - buffs will not be cast");
		}
		if (Class357.smethod_54() && !bool_9)
		{
			method_208("Run: the bag tier did not arm - the bag and equipment panel will stay empty");
		}
		if (Class357.smethod_60() && !bool_11)
		{
			method_208("Run: the loading tier did not arm - loading state will remain unknown");
		}
		if (Class357.smethod_62() && !bool_12)
		{
			method_208("Run: the rebirth tier did not arm - rebirth requests will be refused");
		}
		method_208("Run: offsets " + string_5);
		return true;
	}

	public bool method_91(int int_17)
	{
		DateTime dateTime = DateTime.UtcNow.AddMilliseconds(int_17);
		int num = 0;
		while (true)
		{
			if (DateTime.UtcNow < dateTime)
			{
				manualResetEventSlim_3.Reset();
				method_178("{\"cmd\":\"inworld\"}");
				if (manualResetEventSlim_3.Wait(2000) && smethod_58(string_4, "ok"))
				{
					break;
				}
				if (++num % 5 == 0)
				{
					method_208("waiting for the world ... " + num + "s");
				}
				Thread.Sleep(1000);
				continue;
			}
			method_208("not in the world - " + string_4);
			return false;
		}
		method_208("in world " + string_4);
		return true;
	}

	public List<Class403> method_92(int int_17)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			return null;
		}
		list_0 = null;
		manualResetEventSlim_5.Reset();
		method_178("{\"cmd\":\"census_raw\"}");
		if (!manualResetEventSlim_5.Wait(int_17))
		{
			method_208("Census: timed out");
			return null;
		}
		return list_0;
	}

	public void method_93()
	{
		method_178("{\"cmd\":\"frame_hook\",\"on\":true}");
	}

	public void method_94()
	{
		if (!(intptr_0 == IntPtr.Zero) && method_10())
		{
			lock (object_6)
			{
				if (intptr_0 == IntPtr.Zero || !method_10() || Volatile.Read(ref int_12) != 0)
				{
					return;
				}
				if (int_15 > 0)
				{
					method_178(Class54.smethod_0("t2", int_15));
				}
				if (int_14 > 0)
				{
					method_178(Class54.smethod_0("t1", int_14));
				}
				Volatile.Write(ref int_12, 1);
			}
			method_208("stream: subscribed" + ((int_14 > 0) ? (" t1@" + int_14) : " t1 OFF") + ((int_15 > 0) ? (" t2@" + int_15) : " t2 OFF"));
		}
		else
		{
			method_208("stream: not attached - press Run/Select first");
		}
	}

	public void method_95()
	{
		lock (object_6)
		{
			if (Volatile.Read(ref int_12) == 0)
			{
				return;
			}
			method_178(Class54.smethod_1("t1"));
			method_178(Class54.smethod_1("t2"));
			Volatile.Write(ref int_12, 0);
		}
		method_208("stream: unsubscribed");
	}

	public bool method_96()
	{
		return Class357.smethod_22();
	}

	public bool method_97()
	{
		if (Class357.smethod_30())
		{
			return bool_14;
		}
		return false;
	}

	internal long method_98()
	{
		return Interlocked.Read(ref long_5);
	}

	internal static bool smethod_4(bool bool_17, string string_18)
	{
		if (bool_17)
		{
			return smethod_58(string_18, "radarReady");
		}
		return false;
	}

	private void method_99()
	{
		lock (object_1)
		{
			nullable_0 = null;
			bool_14 = false;
			Interlocked.Increment(ref long_5);
		}
	}

	internal void method_100(string string_18, long long_10)
	{
		lock (object_1)
		{
			if (long_10 == Interlocked.Read(ref long_0) && long_10 != long_1)
			{
				bool_14 = Class357.smethod_30() && (nullable_0 ?? smethod_58(string_18, "radarReady"));
			}
		}
	}

	private void method_101(JObject jobject_0, long long_10)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		JToken val = jobject_0["ready"];
		if (val == null || (int)val.Type != 9)
		{
			return;
		}
		bool flag;
		lock (object_1)
		{
			if (long_10 != Interlocked.Read(ref long_0) || long_10 == long_1)
			{
				return;
			}
			nullable_0 = (bool)val;
			flag = (bool_14 = Class357.smethod_30() && (bool)val);
		}
		JToken val2 = jobject_0["reason"];
		string text = ((val2 == null || (int)val2.Type != 8) ? string.Empty : ((string)val2));
		if (text.Length > 512)
		{
			text = text.Substring(0, 512);
		}
		method_208("Radar: " + (flag ? "ready" : "unavailable") + (string.IsNullOrEmpty(text) ? string.Empty : ("; " + text)));
	}

	public bool method_102()
	{
		return Class357.smethod_24();
	}

	internal void method_103(bool bool_17)
	{
		lock (object_1)
		{
			bool_14 = false;
		}
		method_178(bool_17 ? "{\"cmd\":\"radar_mode\",\"on\":true}" : "{\"cmd\":\"radar_mode\",\"on\":false}");
	}

	internal void method_104(int int_17, bool bool_17)
	{
		if (bool_17)
		{
			method_178(Class428.smethod_6(int_17));
		}
		else
		{
			method_108("player", int_17);
		}
	}

	internal void method_105(int int_17, float float_0, float float_1, float float_2, bool bool_17)
	{
		if (bool_17)
		{
			method_178(Class428.smethod_7(int_17, float_0, float_1, float_2));
		}
		else
		{
			method_109("player", int_17, float_0, float_1, float_2);
		}
	}

	internal void method_106(int int_17, bool bool_17)
	{
		if (bool_17)
		{
			method_178(Class428.smethod_8(int_17));
		}
		else
		{
			method_113("player", int_17);
		}
	}

	internal void method_107(bool bool_17)
	{
		if (bool_17)
		{
			method_178(Class428.smethod_9());
		}
		else
		{
			method_114("player");
		}
	}

	public void method_108(string string_18, int int_17)
	{
		method_178(Class428.smethod_0(string_18, int_17, 1f, 0f, 0f, 0.15f));
	}

	public void method_109(string string_18, int int_17, float float_0, float float_1, float float_2)
	{
		method_178(Class428.smethod_1(string_18, int_17, 1f, 0f, 0f, 0.15f, float_0, float_1, float_2));
	}

	public void method_110(string string_18, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6, float float_7)
	{
		method_178(Class428.smethod_1(string_18, float_0, float_1, float_2, float_3, float_4, float_5, float_6, float_7));
	}

	public void method_111(string string_18, float float_0, float float_1, float float_2, float float_3, float float_4)
	{
		method_178(Class428.smethod_0(string_18, float_0, float_1, float_2, float_3, float_4));
	}

	public void method_112(string string_18, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6, float float_7, float float_8, float float_9, float float_10)
	{
		method_178(Class428.smethod_2(string_18, float_0, float_1, float_2, float_3, float_4, float_5, float_6, float_7, float_8, float_9, float_10));
	}

	public void method_113(string string_18, int int_17)
	{
		method_178(Class428.smethod_3(string_18, int_17));
	}

	public void method_114(string string_18)
	{
		method_178(Class428.smethod_4(string_18));
	}

	public bool method_115()
	{
		if (Class357.smethod_28())
		{
			return bool_13;
		}
		return false;
	}

	public void method_116()
	{
		method_178(Class178.smethod_0(1000, 5));
	}

	public void method_117()
	{
		method_178(Class178.smethod_1());
	}

	public bool method_118(float float_0, out uint uint_2)
	{
		uint_2 = 0u;
		if (!(float_0 <= 0f) && !float.IsNaN(float_0) && !float.IsInfinity(float_0))
		{
			do
			{
				uint_2 = (uint)Interlocked.Increment(ref int_7);
			}
			while (uint_2 == 0);
			return method_179(Class178.smethod_2(float_0, uint_2));
		}
		return false;
	}

	public bool method_119()
	{
		return method_179(Class178.smethod_3());
	}

	public bool method_120()
	{
		return Class357.smethod_32();
	}

	public void method_121(int int_17)
	{
		method_178(Class391.smethod_0(int_17));
	}

	public bool method_122()
	{
		if (Class357.smethod_34())
		{
			return bool_5;
		}
		return false;
	}

	public bool method_123()
	{
		if (Class357.smethod_68())
		{
			return bool_10;
		}
		return false;
	}

	public void method_124(uint uint_2)
	{
		method_178(Class418.smethod_0(uint_2));
	}

	public void method_125()
	{
		method_178(Class418.smethod_1());
	}

	public void method_126()
	{
		method_178(Class418.smethod_2());
	}

	public void method_127(uint uint_2)
	{
		lock (object_7)
		{
			bool_16 = false;
			int_16++;
			method_178(Class15.smethod_0(uint_2));
		}
	}

	public void method_128(uint uint_2)
	{
		lock (object_7)
		{
			bool_16 = false;
			int_16++;
			method_178(Class15.smethod_1(uint_2));
		}
	}

	public void method_129()
	{
		method_178(Class15.smethod_2());
	}

	public async Task method_130()
	{
		int num;
		float float_;
		float float_2;
		float float_3;
		lock (object_7)
		{
			if (bool_16)
			{
				return;
			}
			bool_16 = true;
			num = int_16;
			method_129();
			Class83 @class = method_51().method_0();
			if (@class == null)
			{
				return;
			}
			float_ = @class.float_0;
			float_2 = @class.float_1;
			float_3 = @class.float_2;
			if (!method_177(float_ + 2f, float_2, float_3, bool_17: false, "attack_stop_nudge"))
			{
				return;
			}
		}
		Func<int, Task> func = func_1;
		await ((func == null) ? Task.Delay(250) : func(250)).ConfigureAwait(continueOnCapturedContext: false);
		lock (object_7)
		{
			if (num != int_16 || !method_177(float_ - 2f, float_2, float_3, bool_17: false, "attack_stop_nudge"))
			{
				return;
			}
		}
		await ((func == null) ? Task.Delay(250) : func(250)).ConfigureAwait(continueOnCapturedContext: false);
	}

	public void method_131()
	{
		method_178(Class15.smethod_3());
	}

	public bool method_132()
	{
		if (Class357.smethod_36())
		{
			return bool_6;
		}
		return false;
	}

	public void method_133(IEnumerable<int> ienumerable_0)
	{
		method_178(Class454.smethod_0(ienumerable_0));
	}

	public void method_134(IEnumerable<int> ienumerable_0)
	{
		method_178(Class454.smethod_1(ienumerable_0));
	}

	public bool method_135()
	{
		if (Class357.smethod_38())
		{
			return bool_7;
		}
		return false;
	}

	internal bool method_136()
	{
		return bool_7;
	}

	public bool method_137()
	{
		if (Class357.smethod_60())
		{
			return bool_11;
		}
		return false;
	}

	public bool method_138()
	{
		if (Class357.smethod_62())
		{
			return bool_12;
		}
		return false;
	}

	public bool method_139()
	{
		if (Class357.smethod_52())
		{
			return bool_8;
		}
		return false;
	}

	public void method_140(byte byte_0, uint uint_2)
	{
		method_143(byte_0, uint_2, method_141());
	}

	internal uint method_141()
	{
		uint num;
		do
		{
			num = (uint)Interlocked.Increment(ref int_8);
		}
		while (num == 0);
		return num;
	}

	public bool method_142(byte byte_0, uint uint_2)
	{
		return method_143(byte_0, uint_2, method_141());
	}

	internal bool method_143(byte byte_0, uint uint_2, uint uint_3)
	{
		if (uint_3 == 0)
		{
			return false;
		}
		return method_179(Class397.smethod_0(byte_0, uint_2, uint_3));
	}

	private void method_144(uint uint_2, byte byte_0, uint uint_3, bool bool_17, string string_18)
	{
		lock (object_3)
		{
			long num = Interlocked.Increment(ref long_6);
			Volatile.Write(ref class60_0, new Class60(num, uint_2, byte_0, uint_3, bool_17, string_18));
		}
	}

	internal void method_145(uint uint_2, byte byte_0, uint uint_3, bool bool_17, string string_18)
	{
		method_144(uint_2, byte_0, uint_3, bool_17, string_18);
	}

	private void method_146()
	{
		lock (object_3)
		{
			Volatile.Write(ref class60_0, null);
			Interlocked.Increment(ref long_7);
		}
	}

	public uint method_147()
	{
		return method_150((Enum13)0);
	}

	public uint method_148()
	{
		return method_150((Enum13)1);
	}

	public uint method_149()
	{
		return method_150((Enum13)2);
	}

	private uint method_150(Enum13 enum13_0)
	{
		uint num;
		do
		{
			num = (uint)Interlocked.Increment(ref int_9);
		}
		while (num == 0);
		string string_ = Class344.smethod_1(enum13_0);
		if (!method_138())
		{
			method_151(num, string_, "rebirth unavailable");
			return num;
		}
		if (!method_179(Class344.smethod_0(enum13_0, num)))
		{
			method_151(num, string_, "session unavailable");
		}
		return num;
	}

	private void method_151(uint uint_2, string string_18, string string_19)
	{
		method_152(uint_2, string_18, bool_17: false, null, bool_18: false, string_19);
		method_208("rebirth: {\"t\":\"rebirth\",\"ok\":false,\"req\":" + uint_2.ToString(CultureInfo.InvariantCulture) + ",\"mode\":\"" + string_18 + "\",\"useRosary\":null,\"confirmed\":false,\"error\":\"" + string_19 + "\"}");
	}

	private void method_152(uint uint_2, string string_18, bool bool_17, bool? nullable_1, bool bool_18, string string_19)
	{
		lock (object_4)
		{
			long num = Interlocked.Increment(ref long_8);
			Volatile.Write(ref class93_0, new Class93(num, uint_2, string_18, bool_17, nullable_1, bool_18, string_19));
		}
	}

	internal static Class93 smethod_5(JObject jobject_0, long long_10)
	{
		if (jobject_0 == null)
		{
			return new Class93(long_10, 0u, string.Empty, bool_2: false, null, bool_3: false, string.Empty);
		}
		return new Class93(long_10, smethod_20(jobject_0, "req"), (string)jobject_0["mode"], (bool?)jobject_0["ok"] == true, smethod_21(jobject_0["useRosary"]), (bool?)jobject_0["confirmed"] == true, (string)jobject_0["error"]);
	}

	private void method_153(JObject jobject_0)
	{
		lock (object_4)
		{
			long long_ = Interlocked.Increment(ref long_8);
			Volatile.Write(ref class93_0, smethod_5(jobject_0, long_));
		}
	}

	internal void method_154(uint uint_2, string string_18, bool bool_17, bool? nullable_1, bool bool_18, string string_19)
	{
		method_152(uint_2, string_18, bool_17, nullable_1, bool_18, string_19);
	}

	private void method_155()
	{
		lock (object_4)
		{
			Volatile.Write(ref class93_0, null);
		}
	}

	public uint method_156(int int_17, ushort ushort_0, ushort ushort_1, int int_18, ushort ushort_2, ushort ushort_3)
	{
		Class121 @class = new Class121();
		@class.int_0 = int_17;
		@class.ushort_0 = ushort_0;
		@class.ushort_1 = ushort_1;
		@class.int_1 = int_18;
		@class.ushort_2 = ushort_2;
		@class.ushort_3 = ushort_3;
		return method_159("feed", @class.method_0);
	}

	public uint method_157(int int_17, ushort ushort_0, ushort ushort_1)
	{
		Class124 @class = new Class124();
		@class.int_0 = int_17;
		@class.ushort_0 = ushort_0;
		@class.ushort_1 = ushort_1;
		return method_159("summon", @class.method_0);
	}

	public uint method_158()
	{
		return method_159("dismiss", Class7.smethod_2);
	}

	private uint method_159(string string_18, Func<uint, string> func_7)
	{
		uint num;
		string string_19;
		lock (object_5)
		{
			if (uint_0 != 0)
			{
				return 0u;
			}
			do
			{
				num = (uint)Interlocked.Increment(ref int_10);
			}
			while (num == 0);
			string_19 = func_7(num);
			uint_0 = num;
			string_6 = string_18;
			Volatile.Write(ref class194_0, null);
		}
		string string_20 = "session unavailable";
		bool flag;
		try
		{
			flag = method_179(string_19);
		}
		catch (Exception ex)
		{
			flag = false;
			string_20 = ex.Message;
		}
		if (flag)
		{
			return num;
		}
		lock (object_5)
		{
			if (uint_0 == num)
			{
				method_161(num, string_18, bool_17: false, bool_18: false, null, null, null, null, null, string_20);
			}
		}
		return 0u;
	}

	private void method_160(JObject jobject_0, bool bool_17)
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Invalid comparison between Unknown and I4
		uint num = smethod_20(jobject_0, "req");
		string text = (string)jobject_0["action"];
		lock (object_5)
		{
			if (num == 0 || num != uint_0 || text != string_6 || (!bool_17 && smethod_21(jobject_0["ok"]) == true))
			{
				return;
			}
			int int_;
			byte? b = (smethod_55(jobject_0["result"], 0, 255, out int_) ? new byte?((byte)int_) : ((byte?)null));
			ushort? nullable_ = (smethod_55(jobject_0["newFullness"], 0, 65535, out int_) ? new ushort?((ushort)int_) : ((ushort?)null));
			ushort? nullable_2 = (smethod_55(jobject_0["consumedSlot"], 0, 65535, out int_) ? new ushort?((ushort)int_) : ((ushort?)null));
			ushort? nullable_3 = (smethod_55(jobject_0["cardSlot"], 0, 65535, out int_) ? new ushort?((ushort)int_) : ((ushort?)null));
			uint? nullable_4 = null;
			JToken val = jobject_0["globalId"];
			if (val != null && (int)val.Type == 6)
			{
				try
				{
					nullable_4 = (uint)val;
				}
				catch (Exception)
				{
				}
			}
			int bool_18;
			if (bool_17)
			{
				int? num2 = b;
				bool_18 = (((num2.GetValueOrDefault() == 0) & num2.HasValue) ? 1 : 0);
			}
			else
			{
				bool_18 = 0;
			}
			method_161(num, text, (byte)bool_18 != 0, bool_17 && b.HasValue, b, nullable_, nullable_2, nullable_4, nullable_3, (string)jobject_0["error"]);
		}
	}

	private void method_161(uint uint_2, string string_18, bool bool_17, bool bool_18, byte? nullable_1, ushort? nullable_2, ushort? nullable_3, uint? nullable_4, ushort? nullable_5, string string_19)
	{
		uint_0 = 0u;
		string_6 = null;
		long num = Interlocked.Increment(ref long_9);
		Volatile.Write(ref class194_0, new Class194(num, uint_2, string_18, bool_17, bool_18, nullable_1, nullable_2, nullable_3, nullable_4, nullable_5, string_19, class145_0.method_89()));
	}

	private void method_162()
	{
		lock (object_5)
		{
			uint_0 = 0u;
			string_6 = null;
			Volatile.Write(ref class194_0, null);
		}
	}

	public void method_163()
	{
		method_178(Class397.smethod_1());
	}

	public void method_164()
	{
		method_178(Class454.smethod_2());
	}

	public void method_165()
	{
		method_178(Class454.smethod_3());
	}

	public void method_166(int int_17)
	{
		method_178(Class454.smethod_4(int_17));
	}

	public void method_167()
	{
		method_178(Class341.smethod_0());
	}

	public void method_168(ushort ushort_0, IReadOnlyList<Class409.Struct125> ireadOnlyList_0)
	{
		int num = ireadOnlyList_0?.Count ?? 0;
		Class409.Struct125[] array = new Class409.Struct125[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = ireadOnlyList_0[i];
		}
		struct125_0 = array;
		class145_0 = class145_0.method_102();
		method_178(Class409.smethod_0(ushort_0, array));
	}

	public void method_169(ushort ushort_0, int int_17, int int_18, ushort ushort_1, ushort ushort_2)
	{
		method_168(ushort_0, new Class409.Struct125[1]
		{
			new Class409.Struct125
			{
				int_0 = int_17,
				int_1 = int_18,
				ushort_0 = ushort_1,
				ushort_1 = ushort_2
			}
		});
	}

	public void method_170(int int_17, int int_18, int int_19)
	{
		class145_0 = class145_0.method_105();
		method_178(Class387.smethod_0(int_17, int_18, int_19));
	}

	public void method_171(string string_18, int int_17, int int_18, int int_19)
	{
		class145_0 = class145_0.method_108();
		method_178(Class30.smethod_0(string_18, int_17, int_18, int_19));
	}

	public void method_172()
	{
		method_178(Class347.smethod_0());
	}

	public void method_173(int int_17, ushort ushort_0, ushort ushort_1)
	{
		method_178(Class454.smethod_5(int_17, ushort_0, ushort_1));
	}

	public void method_174(IList<(ushort, ushort)> ilist_0)
	{
		method_178(Class454.smethod_6(ilist_0));
	}

	public void method_175(string string_18, IEnumerable<(float, float, float)> ienumerable_0)
	{
		method_178(Class428.smethod_5(string_18, ienumerable_0));
	}

	public void method_176(float float_0, float float_1, float float_2, bool bool_17, string string_18)
	{
		method_177(float_0, float_1, float_2, bool_17, string_18);
	}

	public bool method_177(float float_0, float float_1, float float_2, bool bool_17, string string_18)
	{
		if (!method_179(Class346.smethod_0(float_0, float_1, float_2, bool_17)))
		{
			return false;
		}
		if (Class172.bool_0 && class173_0.method_0((string_18 ?? "unspecified") + ":" + Class172.smethod_11(float_0, float_1, float_2), bool_0: false, DateTime.UtcNow))
		{
			method_208(Class172.smethod_2(string_18, float_0, float_1, float_2));
		}
		return true;
	}

	public void method_178(string string_18)
	{
		method_179(string_18);
	}

	private bool method_179(string string_18)
	{
		long num = Interlocked.Read(ref long_0);
		lock (object_0)
		{
			if (num != Interlocked.Read(ref long_0))
			{
				return false;
			}
			return method_180(string_18);
		}
	}

	private bool method_180(string string_18)
	{
		Action<string> action = Volatile.Read(ref action_4);
		if (action != null)
		{
			action(string_18);
			return true;
		}
		IntPtr intPtr = intptr_0;
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		interface2_0.imethod_5(intPtr, string_18, null, 0);
		return true;
	}

	private string method_181(string string_18, string string_19, string string_20, int int_17)
	{
		return method_182(string_18, string_19, string_20, int_17).string_0;
	}

	private Class71.Class72 method_182(string string_18, string string_19, string string_20, int int_17)
	{
		Func<string, int, Class71.Class72> func = func_2;
		if (func == null)
		{
			return Class71.smethod_1(string_18, string_19, string_20, int_17);
		}
		return func(string_20, int_17);
	}

	private void method_183(int int_17)
	{
		Action<int> action = action_5;
		if (action != null)
		{
			action(int_17);
		}
		else
		{
			Thread.Sleep(int_17);
		}
	}

	private Enum3 method_184(string string_18, string string_19)
	{
		return func_3?.Invoke() ?? Class421.smethod_2(string_18, string_19);
	}

	private Class380 method_185(string string_18, string string_19)
	{
		List<string> list = new List<string>();
		bool flag;
		if (!(flag = smethod_7(method_182(string_18, string_19, smethod_6(), 8000), out var int_, out var string_20)))
		{
			list.Add("pidfile: " + string_20);
		}
		List<Class133> list2 = new List<Class133>();
		Class71.Class72 @class = method_182(string_18, string_19, "shell su 0 sh -c 'pidof .klxsvc || true'", 8000);
		bool flag2;
		string[] array = ((flag2 = smethod_9(@class)) ? @class.string_1 : string.Empty).Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			if (int.TryParse(array[i], out var result) && result > 0)
			{
				Class71.Class72 class2 = method_182(string_18, string_19, "shell su 0 cat /proc/" + result + "/cmdline", 8000);
				Class71.Class72 class3 = method_182(string_18, string_19, "shell su 0 cat /proc/" + result + "/stat", 8000);
				Class71.Class72 class4 = method_182(string_18, string_19, "shell su 0 ls -l /proc/" + result + "/fd", 8000);
				string text = smethod_10(new Class71.Class72[3] { class2, class3, class4 });
				list2.Add(new Class133(result, class2.string_1, class3.string_1, class4.string_1, smethod_9(class2), smethod_9(class3), smethod_9(class4), text));
				if (!string.IsNullOrEmpty(text))
				{
					list.Add("pid " + result + ": " + text);
				}
			}
		}
		Class71.Class72 class5 = method_182(string_18, string_19, "shell su 0 cat /proc/net/tcp", 8000);
		Class71.Class72 class6 = method_182(string_18, string_19, "shell su 0 cat /proc/net/tcp6", 8000);
		if (!flag2)
		{
			list.Add("process list: " + smethod_8(@class));
		}
		if (!smethod_9(class5))
		{
			list.Add("tcp: " + smethod_8(class5));
		}
		if (!smethod_9(class6))
		{
			list.Add("tcp6: " + smethod_8(class6));
		}
		return new Class380
		{
			int_0 = int_,
			bool_0 = flag,
			bool_1 = flag2,
			string_0 = class5.string_1,
			bool_2 = smethod_9(class5),
			string_1 = class6.string_1,
			bool_3 = smethod_9(class6),
			string_2 = string.Join("; ", list),
			ireadOnlyList_0 = list2
		};
	}

	internal static string smethod_6()
	{
		return "shell su 0 sh -c 'if [ -e /data/local/tmp/.klxsvc.pid ]; then pid=$(cat /data/local/tmp/.klxsvc.pid) || { echo KLX_PIDFILE_READ_FAILED >&2; exit 7; }; echo KLX_PIDFILE_PRESENT:$pid; else echo KLX_PIDFILE_MISSING; fi'";
	}

	internal static bool smethod_7(Class71.Class72 class72_0, out int int_17, out string string_18)
	{
		int_17 = 0;
		string_18 = null;
		if (class72_0 != null && class72_0.method_0() && string.IsNullOrWhiteSpace(class72_0.string_2))
		{
			string text = class72_0.string_1.Trim();
			if (text == "KLX_PIDFILE_MISSING")
			{
				return true;
			}
			if (text.StartsWith("KLX_PIDFILE_PRESENT:", StringComparison.Ordinal) && int.TryParse(text.Substring(20), NumberStyles.None, CultureInfo.InvariantCulture, out int_17) && int_17 > 0)
			{
				return true;
			}
			int_17 = 0;
			string_18 = "unexpected pidfile probe output: " + text;
			return false;
		}
		string_18 = smethod_8(class72_0);
		return false;
	}

	private Class87 method_186(string string_18, string string_19, int int_17)
	{
		Class380 class380_;
		return method_188(string_18, string_19, int_17, out class380_);
	}

	internal Class87 method_187(string string_18, string string_19, out bool bool_17)
	{
		Class380 class380_;
		Class87 result = method_188(string_18, string_19, 3, out class380_);
		bool_17 = class380_ != null && Class195.smethod_1(class380_).Count > 0;
		return result;
	}

	private Class87 method_188(string string_18, string string_19, int int_17, out Class380 class380_0)
	{
		Class87 @class = null;
		class380_0 = null;
		int num = 0;
		while (true)
		{
			if (num < int_17)
			{
				class380_0 = method_185(string_18, string_19);
				@class = Class195.smethod_0(class380_0, 27060);
				if (@class.enum1_0 != Enum1.Unknown)
				{
					break;
				}
				if (num + 1 < int_17)
				{
					method_183(100);
				}
				num++;
				continue;
			}
			return @class ?? new Class87(Enum1.Unknown, 0, 0, "runner health probe did not run");
		}
		return @class;
	}

	private static string smethod_8(Class71.Class72 class72_0)
	{
		if (class72_0 == null)
		{
			return "no probe result";
		}
		if (class72_0.bool_1)
		{
			return "timed out";
		}
		if (!class72_0.bool_0)
		{
			return "adb could not start: " + class72_0.string_0;
		}
		if (!string.IsNullOrWhiteSpace(class72_0.string_2))
		{
			return "exit " + class72_0.int_0 + ": " + class72_0.string_2;
		}
		return "exit " + class72_0.int_0 + (string.IsNullOrWhiteSpace(class72_0.string_0) ? string.Empty : (": " + class72_0.string_0));
	}

	private static bool smethod_9(Class71.Class72 class72_0)
	{
		if (class72_0 != null && class72_0.method_0())
		{
			return string.IsNullOrWhiteSpace(class72_0.string_2);
		}
		return false;
	}

	private static string smethod_10(Class71.Class72[] class72_0)
	{
		List<string> list = new List<string>();
		foreach (Class71.Class72 class72_1 in class72_0)
		{
			if (!smethod_9(class72_1))
			{
				list.Add(smethod_8(class72_1));
			}
		}
		return string.Join("; ", list);
	}

	private string method_189(string string_18, string string_19, int int_17, int int_18)
	{
		string text = method_181(string_18, string_19, "forward tcp:" + int_17 + " tcp:" + int_18, 8000);
		if (!smethod_11(method_181(string_18, string_19, "forward --list", 8000), string_19, int_17, int_18))
		{
			return "adb forward tcp:" + int_17 + " -> tcp:" + int_18 + " was not installed: " + text;
		}
		method_208("Run: verified forward tcp:" + int_17 + " -> tcp:" + int_18);
		return null;
	}

	internal static bool smethod_11(string string_18, string string_19, int int_17, int int_18)
	{
		if (string.IsNullOrEmpty(string_18))
		{
			return false;
		}
		string b = (string_19 ?? string.Empty) + " tcp:" + int_17 + " tcp:" + int_18;
		string[] array = string_18.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (string.Equals(array[num].Trim(), b, StringComparison.Ordinal))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private bool method_190(string string_18, string string_19)
	{
		method_181(string_18, string_19, "shell su 0 rm -f /data/local/tmp/.klxsvc.pid", 8000);
		return method_181(string_18, string_19, "shell su 0 sh -c 'test ! -e /data/local/tmp/.klxsvc.pid && echo KLX_PIDFILE_ABSENT'", 8000).Trim() == "KLX_PIDFILE_ABSENT";
	}

	private bool method_191(string string_18, string string_19, int int_17)
	{
		method_181(string_18, string_19, "shell su 0 sh -c 'echo " + int_17 + " > /data/local/tmp/.klxsvc.pid'", 8000);
		if (int.TryParse(method_181(string_18, string_19, "shell su 0 cat /data/local/tmp/.klxsvc.pid", 8000).Trim(), out var result))
		{
			return result == int_17;
		}
		return false;
	}

	internal string method_192(string string_18, string string_19, out int int_17)
	{
		int_17 = 27060;
		Class87 @class = method_188(string_18, string_19, 3, out var class380_);
		if (@class.enum1_0 == Enum1.Unknown)
		{
			return "runner health could not be verified after 3 probes: " + @class.string_0;
		}
		string string_20 = method_181(string_18, string_19, "shell su 0 cat /data/local/tmp/.klx.tok", 8000).Trim();
		if (@class.enum1_0 == Enum1.Healthy)
		{
			if (!smethod_12(string_20))
			{
				return "a verified runner is listening, but its token cannot be read; refusing to restart a possibly attached session";
			}
			if (!Class195.smethod_5(class380_, int_17, out var num))
			{
				if (!method_191(string_18, string_19, @class.int_1))
				{
					return "the runner is listening, but its stale pidfile could not be repaired";
				}
				@class = method_188(string_18, string_19, 3, out class380_);
				if (@class.enum1_0 != Enum1.Healthy || !Class195.smethod_5(class380_, int_17, out num))
				{
					return "the runner is listening, but its repaired pidfile did not verify";
				}
				method_208("Run: repaired the runner pidfile to verified pid " + num);
			}
			string_8 = string_20;
			method_208("Run: adopted verified runner pid " + num + " listening on device port " + int_17);
			if (method_184(string_18, string_19) == Enum3.Stale)
			{
				method_208("Run: it is an older build - stop it once no session is attached to upgrade it");
			}
			return null;
		}
		if (Class195.smethod_1(class380_).Count > 0)
		{
			method_208("Run: found a verified runner process without a listener; restarting only the runner");
			string text = method_194(string_18, string_19);
			if (text != null)
			{
				return text;
			}
			method_183(250);
		}
		else if (!method_190(string_18, string_19))
		{
			return "the stale runner pidfile could not be removed";
		}
		Enum3 @enum = method_184(string_18, string_19);
		if (@enum != Enum3.Unknown && @enum != Enum3.RunnerMissing)
		{
			if (@enum == Enum3.Stale)
			{
				method_208("Run: pushing klxsvc ...");
				if (!Class421.smethod_15(string_18, string_19, null, out var result))
				{
					return result;
				}
			}
			string_8 = Guid.NewGuid().ToString("N");
			method_181(string_18, string_19, "shell \"su 0 sh -c 'echo " + string_8 + " > /data/local/tmp/.klx.tok; chmod 600 /data/local/tmp/.klx.tok'\"", 8000);
			if (!method_190(string_18, string_19))
			{
				return "the runner pidfile could not be removed before launch";
			}
			method_181(string_18, string_19, "shell \"su 0 sh -c '/data/local/tmp/.klxsvc --port " + int_17 + " --token-file /data/local/tmp/.klx.tok --pidfile /data/local/tmp/.klxsvc.pid --log /data/local/tmp/.klxsvc.log >/dev/null 2>&1 &'\"", 15000);
			int num2 = 0;
			while (true)
			{
				if (num2 < 60)
				{
					@class = method_188(string_18, string_19, 1, out class380_);
					if (@class.enum1_0 == Enum1.Healthy && @class.int_0 > 0)
					{
						break;
					}
					method_183(1000);
					num2++;
					continue;
				}
				if (@class != null && @class.enum1_0 == Enum1.Unknown)
				{
					return "klxsvc readiness could not be verified: " + @class.string_0;
				}
				return "klxsvc did not come up - " + method_181(string_18, string_19, "shell su 0 tail -5 /data/local/tmp/.klxsvc.log", 8000);
			}
			method_208("Run: verified runner pid " + @class.int_0 + " listening on device port " + int_17);
			return null;
		}
		return "runner deploy state could not be verified: " + @enum;
	}

	private static bool smethod_12(string string_18)
	{
		if (string_18 != null && string_18.Length == 32)
		{
			int num = 0;
			while (true)
			{
				if (num < string_18.Length)
				{
					char c = string_18[num];
					if ((c < '0' || c > '9') && (c < 'a' || c > 'f') && (c < 'A' || c > 'F'))
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public void method_193(string string_18, string string_19)
	{
		string text = method_194(string_18, string_19);
		method_208((text == null) ? "runner stopped and verified" : ("runner stop failed: " + text));
	}

	internal string method_194(string string_18, string string_19)
	{
		Class380 class380_;
		Class87 @class = method_188(string_18, string_19, 3, out class380_);
		if (@class.enum1_0 == Enum1.Unknown)
		{
			return "runner health is unknown; refusing to signal any pid: " + @class.string_0;
		}
		IReadOnlyList<Class45> readOnlyList = Class195.smethod_1(class380_);
		foreach (Class45 item in readOnlyList)
		{
			if (method_195(string_18, string_19, item, bool_17: false) == (Enum6)2)
			{
				return "runner identity could not be atomically verified before TERM; no signal was sent";
			}
		}
		bool bool_ = false;
		for (int i = 0; i < 20; i++)
		{
			if (!method_196(string_18, string_19, readOnlyList, out bool_))
			{
				break;
			}
			method_183(100);
		}
		if (bool_)
		{
			return "runner identity probe failed while waiting for TERM";
		}
		if (method_196(string_18, string_19, readOnlyList, out bool_))
		{
			foreach (Class45 item2 in readOnlyList)
			{
				if (method_195(string_18, string_19, item2, bool_17: true) == (Enum6)2)
				{
					return "runner identity could not be atomically verified before KILL; no KILL was sent";
				}
			}
			for (int j = 0; j < 10; j++)
			{
				if (!method_196(string_18, string_19, readOnlyList, out bool_))
				{
					break;
				}
				method_183(100);
			}
			if (bool_)
			{
				return "runner identity probe failed while waiting for KILL";
			}
		}
		if (method_196(string_18, string_19, readOnlyList, out bool_))
		{
			return "a verified runner process did not exit";
		}
		if (bool_)
		{
			return "runner identity probe failed after stop";
		}
		if (!method_190(string_18, string_19))
		{
			return "the runner exited, but its pidfile could not be removed";
		}
		return null;
	}

	private Enum6 method_195(string string_18, string string_19, Class45 class45_0, bool bool_17)
	{
		Class71.Class72 @class = method_182(string_18, string_19, smethod_13(class45_0, bool_17, bool_18: false), 8000);
		if (@class.method_0() && string.IsNullOrWhiteSpace(@class.string_2))
		{
			string text = @class.string_1.Trim();
			if (text.EndsWith("KLX_SIGNAL_SENT", StringComparison.Ordinal))
			{
				return (Enum6)0;
			}
			if (!text.EndsWith("KLX_SIGNAL_GONE", StringComparison.Ordinal) && !text.EndsWith("KLX_SIGNAL_MISMATCH", StringComparison.Ordinal))
			{
				return (Enum6)2;
			}
			return (Enum6)1;
		}
		return (Enum6)2;
	}

	internal static string smethod_13(Class45 class45_0, bool bool_17, bool bool_18)
	{
		if (class45_0 == null)
		{
			throw new ArgumentNullException("identity");
		}
		string text = (bool_18 ? "echo KLX_SIGNAL_MATCH" : ((bool_17 ? "kill -9" : "kill") + " $pid || { echo KLX_SIGNAL_FAILED >&2; exit 9; }; echo KLX_SIGNAL_SENT"));
		string text2 = "pid=" + class45_0.int_0 + "; expected=" + class45_0.ulong_0.ToString(CultureInfo.InvariantCulture) + "; if [ ! -e /proc/$pid/exe ] || [ ! -r /proc/$pid/stat ]; then echo KLX_SIGNAL_GONE; exit 0; fi; exe=$(readlink /proc/$pid/exe) || { echo KLX_SIGNAL_PROBE_FAILED >&2; exit 8; }; stat=$(cat /proc/$pid/stat) || { echo KLX_SIGNAL_PROBE_FAILED >&2; exit 8; }; tail=${stat##*) }; set -- $tail; if [ $# -lt 20 ]; then echo KLX_SIGNAL_PROBE_FAILED >&2; exit 8; fi; shift 19; start=$1; if [ \"$exe\" != \"/data/local/tmp/.klxsvc\" ] || [ \"$start\" != \"$expected\" ]; then echo KLX_SIGNAL_MISMATCH; exit 0; fi; " + text;
		return "shell su 0 sh -c '" + text2 + "'";
	}

	private bool method_196(string string_18, string string_19, IReadOnlyList<Class45> ireadOnlyList_0, out bool bool_17)
	{
		bool_17 = false;
		foreach (Class45 item in ireadOnlyList_0)
		{
			Enum7 num = method_197(string_18, string_19, item);
			if (num == (Enum7)2)
			{
				bool_17 = true;
			}
			if (num == (Enum7)0)
			{
				return true;
			}
		}
		return false;
	}

	private Enum7 method_197(string string_18, string string_19, Class45 class45_0)
	{
		Class71.Class72 @class = method_182(string_18, string_19, "shell su 0 cat /proc/" + class45_0.int_0 + "/cmdline", 8000);
		Class71.Class72 class2 = method_182(string_18, string_19, "shell su 0 cat /proc/" + class45_0.int_0 + "/stat", 8000);
		if (smethod_9(@class) && smethod_9(class2))
		{
			if (!Class195.smethod_3(new Class133(class45_0.int_0, @class.string_1, class2.string_1, string.Empty, bool_3: true, bool_4: true, bool_5: false), class45_0))
			{
				return (Enum7)1;
			}
			return (Enum7)0;
		}
		if (!smethod_14(@class) && !smethod_14(class2))
		{
			return (Enum7)2;
		}
		return (Enum7)1;
	}

	private static bool smethod_14(Class71.Class72 class72_0)
	{
		if (class72_0 != null && class72_0.string_0 != null)
		{
			if (class72_0.string_0.IndexOf("No such file", StringComparison.OrdinalIgnoreCase) < 0)
			{
				return class72_0.string_0.IndexOf("does not exist", StringComparison.OrdinalIgnoreCase) >= 0;
			}
			return true;
		}
		return false;
	}

	private string method_198(string string_18, string string_19)
	{
		if (Class71.smethod_0(string_18, string_19, "shell ps -A", 15000).Contains("klassx-fs17-17-0"))
		{
			method_208("Run: frida-server already running");
			return null;
		}
		string text = "shell \"su 0 sh -c 'test -x /data/local/tmp/.klassx-fs17-17-0 && echo KLXOK'\"";
		if (!Class71.smethod_0(string_18, string_19, text, 8000).Contains("KLXOK"))
		{
			string text2 = Class180.smethod_2();
			if (string.IsNullOrEmpty(text2) || !File.Exists(text2))
			{
				return "frida-server not configured - set FridaServerLocalPath, or use the runner";
			}
			method_208("Run: pushing frida-server ...");
			Class71.smethod_0(string_18, string_19, "push \"" + text2 + "\" /data/local/tmp/.klassx-fs17-17-0", 300000);
			Class71.smethod_0(string_18, string_19, "shell \"su 0 chmod 755 /data/local/tmp/.klassx-fs17-17-0\"", 8000);
			if (!Class71.smethod_0(string_18, string_19, text, 8000).Contains("KLXOK"))
			{
				return "the push did not leave an executable at /data/local/tmp/.klassx-fs17-17-0";
			}
		}
		Class71.smethod_0(string_18, string_19, "shell \"su 0 /data/local/tmp/.klassx-fs17-17-0 -l 127.0.0.1:" + 27042 + " --directory=/data/local/tmp/klassx-frida-17.17.0 >/dev/null 2>&1 &\"", 15000);
		int num = 0;
		while (true)
		{
			if (num < 15)
			{
				if (Class71.smethod_0(string_18, string_19, "shell ps -A", 15000).Contains("klassx-fs17-17-0"))
				{
					break;
				}
				Thread.Sleep(1000);
				num++;
				continue;
			}
			return "frida-server did not come up";
		}
		method_208("Run: frida-server started");
		return null;
	}

	private void method_199(IntPtr intptr_1, IntPtr intptr_2, int int_17, IntPtr intptr_3)
	{
		//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed3: Invalid comparison between Unknown and I4
		//IL_12b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bf: Invalid comparison between Unknown and I4
		//IL_1698: Unknown result type (might be due to invalid IL or missing references)
		//IL_169f: Invalid comparison between Unknown and I4
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Invalid comparison between Unknown and I4
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Invalid comparison between Unknown and I4
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Invalid comparison between Unknown and I4
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Invalid comparison between Unknown and I4
		if (intptr_3.ToInt64() != Interlocked.Read(ref long_0))
		{
			return;
		}
		string text = Class63.smethod_1(intptr_1);
		if (text == null)
		{
			return;
		}
		JObject val;
		try
		{
			val = JObject.Parse(text);
		}
		catch
		{
			return;
		}
		JToken obj2 = val["payload"];
		JObject val2 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
		if (val2 == null)
		{
			if ((string)val["type"] == "log")
			{
				method_208("agent: " + (string)val["payload"]);
				return;
			}
			val2 = val;
		}
		string text2 = (string)val2["t"];
		if (text2 == null || text2 == null)
		{
			return;
		}
		switch (text2.Length)
		{
		case 3:
			switch (text2[0])
			{
			case 'w':
				if (text2 == "w2s")
				{
					method_208(((object)val2).ToString());
				}
				break;
			case 'c':
				if (text2 == "cam")
				{
					method_208(((object)val2).ToString());
				}
				break;
			case 'b':
			{
				if (!(text2 == "bag"))
				{
					break;
				}
				IReadOnlyList<Struct19> readOnlyList = smethod_43(val2);
				int int_18;
				bool bool_ = smethod_55(val2["seq"], 1, int.MaxValue, out int_18);
				string text3 = smethod_39(val2, readOnlyList, bool_);
				if (text3.Length != 0)
				{
					if (text3 != string_12)
					{
						method_208("bag: " + text3);
					}
					string_12 = text3;
					class145_0 = class145_0.method_99(text3);
					method_200();
				}
				else
				{
					string_12 = null;
					method_203(val2);
					IReadOnlyList<Struct27> ireadOnlyList_ = smethod_40(val2);
					int num = smethod_42(val2);
					class145_0 = class145_0.method_98(ireadOnlyList_, readOnlyList, method_202(), int_18, smethod_41(val2), num);
					method_200();
				}
				break;
			}
			}
			break;
		case 4:
			switch (text2[1])
			{
			case 'i':
				if (text2 == "pick")
				{
					bool valueOrDefault5 = (bool?)val2["ok"] == true;
					method_144((uint)smethod_19(val2, "id"), (byte)smethod_19(val2, "type"), smethod_20(val2, "req"), valueOrDefault5, (string)val2["error"]);
					if (!Class172.bool_0 || class173_2.method_0(Class172.smethod_6(val2), !valueOrDefault5, DateTime.UtcNow))
					{
						method_208(Class172.bool_0 ? Class172.smethod_5(val2) : ((object)val2).ToString());
					}
				}
				break;
			case 'l':
				if (text2 == "slot")
				{
					method_208(((object)val2).ToString());
				}
				break;
			case 'n':
				if (text2 == "snap")
				{
					class145_0 = class145_0.method_93(Class83.smethod_0(intptr_2, int_17), smethod_19(val2, "seq"), smethod_19(val2, "skipped"));
					method_200();
					action_8?.Invoke();
					method_205(Class54.smethod_2("t1"), intptr_3);
				}
				break;
			case 'o':
				if (text2 == "zone")
				{
					method_208(((object)val2).ToString());
				}
				break;
			case 'e':
			{
				if (!(text2 == "sell"))
				{
					break;
				}
				string string_4 = smethod_44(val2);
				IReadOnlyList<Class78> readOnlyList4 = smethod_45(val2, string_4, struct125_0);
				int int_28;
				bool bool_5 = smethod_55(val2["seq"], 1, int.MaxValue, out int_28);
				string text8 = smethod_48(val2, readOnlyList4, string_4, bool_5);
				if (text8.Length != 0)
				{
					if (text8 != string_13)
					{
						method_208("sell: " + text8);
					}
					string_13 = text8;
					struct125_0 = null;
					class145_0 = class145_0.method_101(text8);
					method_200();
				}
				else
				{
					string_13 = null;
					struct125_0 = null;
					class145_0 = class145_0.method_100(readOnlyList4, string_4, int_28);
					method_200();
				}
				break;
			}
			}
			break;
		case 5:
			switch (text2[0])
			{
			case 'm':
				if (text2 == "moved")
				{
					bool valueOrDefault7 = (bool?)val2["ok"] == true;
					if (!Class172.bool_0 || class173_1.method_0(Class172.smethod_4(val2), !valueOrDefault7, DateTime.UtcNow))
					{
						method_208(Class172.bool_0 ? Class172.smethod_3(val2) : ((object)val2).ToString());
					}
				}
				break;
			case 'e':
				if (text2 == "error")
				{
					method_208("agent error: " + text);
				}
				break;
			case 's':
				if (text2 == "skill")
				{
					int num3 = smethod_19(val2, "fired");
					bool valueOrDefault6 = (bool?)val2["ok"] == true;
					string arg5 = (string)val2["error"];
					string string_5 = ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>());
					if (smethod_15(num3, string_5, ref string_9))
					{
						method_208(string_5);
					}
					action_12?.Invoke(num3, valueOrDefault6, arg5);
				}
				break;
			case 'r':
				if (!(text2 == "ready"))
				{
					break;
				}
				lock (object_1)
				{
					if (intptr_3.ToInt64() == Interlocked.Read(ref long_0) && long_1 != intptr_3.ToInt64())
					{
						Volatile.Write(ref int_1, 1);
						manualResetEventSlim_0.Set();
					}
					break;
				}
			}
			break;
		case 6:
			switch (text2[0])
			{
			case 'r':
			{
				if (!(text2 == "recall"))
				{
					break;
				}
				if (smethod_49(val2, "the agent refused the recall without saying why", "the reply carried no sequence number", out var bool_4, out var string_3, out var int_27) && bool_4)
				{
					string_14 = null;
					class145_0 = class145_0.method_103(bool_2: true, int_27);
					method_200();
					break;
				}
				if (string_3 != string_14)
				{
					method_208("recall: " + string_3);
				}
				string_14 = string_3;
				class145_0 = class145_0.method_104(string_3);
				method_200();
				break;
			}
			case 'a':
				if (text2 == "attack")
				{
					uint arg2 = (uint)smethod_19(val2, "id");
					int arg3 = smethod_19(val2, "code");
					bool valueOrDefault4 = (bool?)val2["ok"] == true;
					string arg4 = (string)val2["error"];
					if (!valueOrDefault4)
					{
						method_208(((object)val2).ToString());
					}
					action_10?.Invoke(arg2, arg3, valueOrDefault4, arg4);
				}
				break;
			}
			break;
		case 7:
			switch (text2[0])
			{
			case 'i':
				if (text2 == "inworld")
				{
					this.string_4 = ((object)val2).ToString();
					manualResetEventSlim_3.Set();
				}
				break;
			case 'f':
			{
				if (!(text2 == "friends"))
				{
					break;
				}
				string string_ = smethod_50(val2);
				int int_19;
				bool bool_2 = smethod_55(val2["seq"], 1, int.MaxValue, out int_19);
				string text4 = smethod_51(val2, string_, bool_2);
				if (text4.Length != 0)
				{
					if (text4 != string_16)
					{
						method_208("friends: " + text4);
					}
					string_16 = text4;
					class145_0 = class145_0.method_110(text4);
					method_200();
				}
				else
				{
					string_16 = null;
					int int_20;
					IReadOnlyList<Struct140> ireadOnlyList_2 = smethod_52(val2, out int_20);
					class145_0 = class145_0.method_109(ireadOnlyList_2, string_, int_19, int_20);
					method_200();
				}
				break;
			}
			case 'r':
				if (text2 == "rebirth")
				{
					method_153(val2);
					method_208("rebirth: " + ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
				}
				break;
			case 'o':
				if (text2 == "offsets")
				{
					this.string_5 = ((object)val2).ToString();
					manualResetEventSlim_4.Set();
				}
				break;
			}
			break;
		case 8:
			switch (text2[0])
			{
			default:
				return;
			case 'p':
				break;
			case 'l':
			{
				if (!(text2 == "libshare") || !smethod_55(val2["req"], 1, int.MaxValue, out var int_33))
				{
					return;
				}
				lock (object_1)
				{
					long num4 = intptr_3.ToInt64();
					if (num4 != Interlocked.Read(ref long_0) || long_1 == num4 || int_33 != int_3)
					{
						return;
					}
					bool flag2;
					string value;
					if (!(flag2 = val2["ok"] != null && (int)val2["ok"].Type == 9 && (bool)val2["ok"]))
					{
						value = ((val2["error"] == null || (int)val2["error"].Type != 8) ? "the agent returned an invalid failure reply" : ((string)val2["error"]));
						if (string.IsNullOrWhiteSpace(value))
						{
							value = "the agent returned an empty failure reply";
						}
					}
					else
					{
						string a = ((val2["buildAbi"] == null || (int)val2["buildAbi"].Type != 8) ? null : ((string)val2["buildAbi"]));
						string a2 = ((val2["sha256"] == null || (int)val2["sha256"].Type != 8) ? null : ((string)val2["sha256"]));
						Class32 class8 = class32_0;
						if (smethod_55(val2["apiVersion"], 1, int.MaxValue, out var int_34) && int_34 == 1 && string.Equals(a, "arm64-v8a", StringComparison.Ordinal) && class8 != null && string.Equals(a2, class8.string_3, StringComparison.Ordinal))
						{
							value = string.Empty;
						}
						else
						{
							flag2 = false;
							value = "the agent returned an incompatible libshare descriptor";
						}
					}
					this.long_2 = num4;
					bool_0 = flag2;
					string_1 = value;
					manualResetEventSlim_1.Set();
					return;
				}
			}
			case 'c':
				if (text2 == "cam_zoom")
				{
					Class129 class7 = new Class129();
					class7.class119_0 = this;
					class7.class101_0 = smethod_26(val2);
					if (class7.class101_0 != null)
					{
						long long_4 = intptr_3.ToInt64();
						method_207(long_4, class7.method_0);
					}
				}
				return;
			}
			if (!(text2 == "pet_read"))
			{
				break;
			}
			goto IL_0d37;
		case 9:
			switch (text2[0])
			{
			case 's':
				if (text2 == "skill_bar")
				{
					method_208(((object)val2).ToString());
					action_13?.Invoke(smethod_16(val2));
				}
				break;
			case 'c':
			{
				if (!(text2 == "challenge"))
				{
					break;
				}
				Class363 class6 = method_0();
				if (class6 != null && intptr_3.ToInt64() != long_1 && smethod_62(val2["challengeId"], out var uint_4) && uint_4 != 0 && smethod_55(val2["challengeType"], 0, 255, out var int_29) && smethod_55(val2["timeoutSec"], 1, 255, out var int_30) && smethod_55(val2["attemptsLeft"], 1, 255, out var int_31) && smethod_55(val2["imageLen"], 8, 8192, out var int_32) && !(intptr_2 == IntPtr.Zero) && int_17 == int_32)
				{
					byte[] array = new byte[int_32];
					Marshal.Copy(intptr_2, array, 0, int_32);
					if (!class6.method_2(method_201(intptr_3), uint_4, int_29, int_30, int_31, array, smethod_18(val2, "receivedUnixMs"), Class357.smethod_10()))
					{
						method_208("[Challenge] capture queue is full");
					}
				}
				else
				{
					method_208("[Challenge] invalid image event");
				}
				break;
			}
			case 'b':
				if (text2 == "buff_cast")
				{
					method_208(((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
					action_15?.Invoke(smethod_53(val2));
				}
				break;
			}
			break;
		case 10:
		{
			char c = text2[0];
			if (c != 'c')
			{
				if (c != 'f')
				{
					if (c != 'p' || !(text2 == "pet_status"))
					{
						break;
					}
					goto IL_0d37;
				}
				if (text2 == "frame_hook")
				{
					method_18((bool?)val2["active"] == true);
					method_208(text);
				}
				break;
			}
			if (text2 == "census_raw")
			{
				method_203(val2);
				list_0 = smethod_57(intptr_2, int_17);
				manualResetEventSlim_5.Set();
				string text7 = smethod_24(val2);
				Class145 class4 = ((text7 == null) ? class145_0 : class145_0.method_94(text7));
				IReadOnlyList<GStruct3> readOnlyList2 = smethod_30(val2);
				IReadOnlyList<uint> readOnlyList3 = smethod_31(val2);
				IReadOnlyDictionary<uint, GStruct0> ireadOnlyDictionary_ = smethod_34(val2, readOnlyList3, list_0);
				Struct26 struct26_ = smethod_23(val2);
				class145_0 = class4.method_96(list_0, method_202(), readOnlyList2, smethod_37(val2), smethod_22(val2), smethod_19(val2, "seq"), smethod_19(val2, "skipped"), smethod_33(val2, readOnlyList3, list_0, readOnlyList2), readOnlyList3, smethod_32(val2), ireadOnlyDictionary_, struct26_);
				method_200();
				action_8?.Invoke();
				method_205(Class54.smethod_2("t2"), intptr_3);
			}
			break;
		}
		case 11:
			switch (text2[7])
			{
			case 'e':
				if (text2 == "skill_ready")
				{
					JToken val3 = val2["ok"];
					string text6 = ((val3 != null && (int)val3.Type == 9 && (bool)val3) ? null : ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
					if (text6 != null && text6 != string_11)
					{
						method_208(text6);
					}
					string_11 = text6;
					class358_0 = smethod_54(val2, Class358.smethod_0(), class358_0);
				}
				break;
			case 'a':
				if (text2 == "pick_status")
				{
					method_208(((object)val2).ToString());
				}
				break;
			case 's':
				if (text2 == "attack_stop")
				{
					method_208(((object)val2).ToString());
				}
				break;
			case 'u':
				if (text2 == "pet_request")
				{
					method_160(val2, bool_17: false);
					if (smethod_21(val2["ok"]) != true)
					{
						method_208("pet: " + ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
					}
				}
				break;
			case 'w':
			{
				if (!(text2 == "friend_warp"))
				{
					break;
				}
				if (smethod_49(val2, "the agent refused the friend warp without saying why", "the friend warp reply carried no sequence number", out var bool_3, out var string_2, out var int_24) && bool_3)
				{
					string_15 = null;
					class145_0 = class145_0.method_106(bool_2: true, int_24);
					method_200();
					break;
				}
				if (string_2 != string_15)
				{
					method_208("friend_warp: " + string_2);
				}
				string_15 = string_2;
				class145_0 = class145_0.method_107(string_2);
				method_200();
				break;
			}
			case 'h':
				if (text2 == "skill_check")
				{
					method_208(((object)val2).ToString());
					action_14?.Invoke(smethod_17(val2));
				}
				break;
			}
			break;
		case 12:
			switch (text2[1])
			{
			case 'k':
				if (text2 == "skill_status")
				{
					method_208(((object)val2).ToString());
				}
				break;
			case 'e':
				if (text2 == "pet_response")
				{
					method_160(val2, bool_17: true);
					method_208("pet: " + ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
				}
				break;
			case 'a':
			{
				if (!(text2 == "party_select"))
				{
					if (text2 == "party_status")
					{
						method_208(((object)val2).ToString());
					}
					break;
				}
				bool valueOrDefault = (bool?)val2["ok"] == true;
				uint valueOrDefault2 = ((uint?)val2["id"]).GetValueOrDefault();
				bool valueOrDefault3 = (bool?)val2["self"] == true;
				string arg = (string)val2["error"];
				method_208(((object)val2).ToString());
				action_11?.Invoke(valueOrDefault2, valueOrDefault3, valueOrDefault, arg);
				break;
			}
			}
			break;
		case 13:
			switch (text2[0])
			{
			case 's':
				if (text2 == "skill_tab_ids")
				{
					string text5 = ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>());
					if (text5 != string_10)
					{
						method_208(text5);
					}
					string_10 = text5;
					if (smethod_19(val2, "tab") == 3)
					{
						valueTuple_0 = smethod_38(val2);
					}
				}
				break;
			case 'l':
			{
				if (!(text2 == "license_hello") || !smethod_55(val2["req"], 1, int.MaxValue, out var int_21))
				{
					break;
				}
				lock (object_1)
				{
					long long_2 = intptr_3.ToInt64();
					if (!method_86(long_2) || int_21 != int_5)
					{
						break;
					}
					if (val2["ok"] == null || (int)val2["ok"].Type != 9 || !(bool)val2["ok"])
					{
						this.long_3 = long_2;
						class393_0 = null;
						this.string_2 = smethod_60(val2, "the agent rejected license initialization");
						manualResetEventSlim_2.Set();
						break;
					}
					if (!smethod_55(val2["protocol"], 1, 1, out var int_22) || !smethod_62(val2["pid"], out var uint_2) || uint_2 != method_11() || !Class349.smethod_1(smethod_59(val2["sessionId"]), 16, out var byte_) || !Class349.smethod_1(smethod_59(val2["challenge"]), 32, out var byte_2) || !Class349.smethod_1(smethod_59(val2["publicKey"]), 65, out var byte_3) || byte_3[0] != 4)
					{
						break;
					}
					try
					{
						class393_0 = new Class393(int_21, int_22, uint_2, byte_, byte_2, byte_3);
						this.long_3 = long_2;
						this.string_2 = string.Empty;
						manualResetEventSlim_2.Set();
						break;
					}
					catch
					{
						break;
					}
				}
			}
			case 'a':
				if (text2 == "attack_status")
				{
					method_208(((object)val2).ToString());
				}
				break;
			}
			break;
		case 14:
			switch (text2[0])
			{
			case 'r':
				if (text2 == "rebirth_status")
				{
					method_208(((object)val2).ToString());
				}
				break;
			case 'l':
				if (!(text2 == "license_status"))
				{
					break;
				}
				lock (object_1)
				{
					long num2 = intptr_3.ToInt64();
					if (method_86(num2) && num2 == this.long_4 && !string.IsNullOrEmpty(this.string_3) && Class147.smethod_2(val2, this.string_3, out var class3))
					{
						class147_0 = class3;
					}
					break;
				}
			}
			break;
		case 15:
			switch (text2[0])
			{
			case 'r':
				if (text2 == "radar_readiness")
				{
					method_101(val2, intptr_3.ToInt64());
				}
				break;
			case 'c':
				if (text2 == "cam_zoom_status")
				{
					Class120 class2 = new Class120();
					class2.class119_0 = this;
					class2.class400_0 = smethod_27(val2);
					if (class2.class400_0 != null)
					{
						long long_ = intptr_3.ToInt64();
						method_207(long_, class2.method_0);
					}
				}
				break;
			}
			break;
		case 16:
			if (text2 == "challenge_result")
			{
				Class363 class5 = method_0();
				if (class5 != null && intptr_3.ToInt64() != long_1 && smethod_62(val2["challengeId"], out var uint_3) && uint_3 != 0 && smethod_55(val2["result"], 0, 3, out var int_25) && smethod_55(val2["attemptsLeft"], 0, 255, out var int_26) && !class5.method_5(method_201(intptr_3), uint_3, int_25, int_26, smethod_18(val2, "receivedUnixMs")))
				{
					method_208("[Challenge] result queue is full");
				}
			}
			break;
		case 17:
		{
			if (!(text2 == "license_bootstrap") || !smethod_55(val2["req"], 1, int.MaxValue, out var int_23))
			{
				break;
			}
			lock (object_1)
			{
				long long_3 = intptr_3.ToInt64();
				if (method_86(long_3) && int_23 == int_6 && class393_0 != null && string.Equals(smethod_59(val2["sessionId"]), class393_0.method_0(), StringComparison.OrdinalIgnoreCase))
				{
					bool flag = val2["ok"] != null && (int)val2["ok"].Type == 9 && (bool)val2["ok"];
					this.long_3 = long_3;
					this.bool_3 = flag;
					this.string_2 = (flag ? string.Empty : smethod_60(val2, "the agent rejected license bootstrap"));
					if (flag)
					{
						this.string_3 = class393_0.method_0();
						this.long_4 = long_3;
						class147_0 = Class147.smethod_1(class393_0.method_0());
					}
					manualResetEventSlim_2.Set();
				}
				break;
			}
		}
		case 20:
			if (text2 == "challenge_submission")
			{
				Class363 @class = method_0();
				if (@class != null && intptr_3.ToInt64() != long_1 && smethod_62(val2["challengeId"], out var uint_) && uint_ != 0)
				{
					@class.method_4(method_201(intptr_3), uint_, (string)val2["answer"], smethod_18(val2, "observedUnixMs"));
				}
			}
			break;
		case 22:
			if (text2 == "challenge_answer_reply")
			{
				method_208("challenge_answer: " + ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
			}
			break;
		case 23:
			if (text2 == "challenge_answer_status")
			{
				method_208(((object)val2).ToString());
			}
			break;
		case 18:
		case 19:
		case 21:
			break;
			IL_0d37:
			method_208("pet: " + ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
			break;
		}
	}

	internal static bool smethod_15(int int_17, string string_18, ref string string_19)
	{
		if (int_17 == 0 && string_18 == string_19)
		{
			return false;
		}
		string_19 = ((int_17 == 0) ? string_18 : null);
		return true;
	}

	private void method_200()
	{
		action_9?.Invoke(class145_0);
	}

	internal static IReadOnlyList<string> smethod_16(JObject jobject_0)
	{
		JToken obj = jobject_0["slots"];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		List<string> list = new List<string>();
		if (val == null)
		{
			return list;
		}
		foreach (JToken item in val)
		{
			JObject val2 = (JObject)(object)((item is JObject) ? item : null);
			if (val2 == null)
			{
				continue;
			}
			int num = smethod_19(val2, "n");
			if (num >= 1 && num <= 10)
			{
				while (list.Count < num)
				{
					list.Add(string.Empty);
				}
				list[num - 1] = ((string)val2["name"]) ?? string.Empty;
			}
		}
		return list;
	}

	internal static IReadOnlyList<GStruct1> smethod_17(JObject jobject_0)
	{
		List<GStruct1> list = new List<GStruct1>();
		JToken obj = jobject_0["slots"];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		if (val != null)
		{
			foreach (JToken item in val)
			{
				JObject val2 = (JObject)(object)((item is JObject) ? item : null);
				if (val2 != null)
				{
					list.Add(new GStruct1(smethod_19(val2, "n"), smethod_19(val2, "code")));
				}
			}
		}
		return list;
	}

	private string method_201(IntPtr intptr_1)
	{
		return string_0 + "/" + intptr_1.ToInt64();
	}

	private static long smethod_18(JObject jobject_0, string string_18)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		JToken obj = jobject_0[string_18];
		JValue val = (JValue)(object)((obj is JValue) ? obj : null);
		if (val != null && (int)((JToken)val).Type == 6 && val.Value is long)
		{
			long num = (long)val.Value;
			if (num > 0L)
			{
				return num;
			}
		}
		return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
	}

	private static int smethod_19(JObject jobject_0, string string_18)
	{
		JToken val = jobject_0[string_18];
		if (val == null)
		{
			return 0;
		}
		try
		{
			return (int)val;
		}
		catch
		{
			return 0;
		}
	}

	private static uint smethod_20(JObject jobject_0, string string_18)
	{
		JToken val = jobject_0[string_18];
		if (val == null)
		{
			return 0u;
		}
		try
		{
			return (uint)val;
		}
		catch
		{
			return 0u;
		}
	}

	private static bool? smethod_21(JToken jtoken_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if (jtoken_0 != null && (int)jtoken_0.Type == 9)
		{
			return (bool?)jtoken_0;
		}
		return null;
	}

	internal static Class446 smethod_22(JObject jobject_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		Class446 @class = new Class446();
		if (jobject_0 == null)
		{
			return @class;
		}
		JToken val = jobject_0["loading"];
		@class.method_1(smethod_21(val));
		int int_2;
		if (val != null && ((int)val.Type == 9 || (int)val.Type == 10))
		{
			if (smethod_55(jobject_0["loading_source"], 0, 3, out var int_))
			{
				@class.method_3(int_);
			}
			if (smethod_55(jobject_0["loading_age_ms"], 0, int.MaxValue, out int_2))
			{
				@class.method_5(int_2);
			}
		}
		JToken val2 = jobject_0["dead"];
		@class.method_7(smethod_21(val2));
		if (val2 != null && ((int)val2.Type == 9 || (int)val2.Type == 10) && smethod_55(jobject_0["dead_age_ms"], 0, int.MaxValue, out int_2))
		{
			@class.method_10(int_2);
		}
		return @class;
	}

	internal static Struct26 smethod_23(JObject jobject_0)
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		Struct26 result = default(Struct26);
		JObject val = (JObject)((jobject_0 == null) ? null : (jobject_0["pet"] as JObject));
		if (val == null)
		{
			return result;
		}
		result.bool_0 = smethod_21(val["ready"]) == true;
		if (smethod_55(val["fullness"], 0, 65535, out var int_))
		{
			result.nullable_0 = (ushort)int_;
		}
		if (smethod_55(val["activeSlot"], 0, 65535, out int_))
		{
			result.nullable_1 = (ushort)int_;
		}
		JToken val2 = val["globalId"];
		if (val2 != null && (int)val2.Type == 6)
		{
			try
			{
				result.nullable_2 = (uint)val2;
			}
			catch (Exception)
			{
			}
		}
		result.nullable_3 = smethod_21(val["objectPresent"]);
		return result;
	}

	internal static string smethod_24(JObject jobject_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		if (jobject_0 == null)
		{
			return null;
		}
		JToken val = jobject_0["login_id"];
		if (val != null && (int)val.Type == 8)
		{
			string text = (string)val;
			if (!string.IsNullOrWhiteSpace(text))
			{
				return text.Trim();
			}
			return null;
		}
		return null;
	}

	private static float smethod_25(JObject jobject_0, string string_18, float float_0)
	{
		JToken val = jobject_0[string_18];
		if (val == null)
		{
			return float_0;
		}
		try
		{
			return (float)val;
		}
		catch
		{
			return float_0;
		}
	}

	internal static Class101 smethod_26(JObject jobject_0)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		if (jobject_0 == null)
		{
			return null;
		}
		if (smethod_62(jobject_0["req"], out var uint_) && smethod_28(jobject_0["ok"], out var bool_) && smethod_28(jobject_0["ready"], out var bool_2))
		{
			float? nullable_ = smethod_29(jobject_0["zoom"]);
			float? nullable_2 = smethod_29(jobject_0["raw"]);
			if (bool_ && !nullable_.HasValue)
			{
				return null;
			}
			if (jobject_0["raw"] != null && !nullable_2.HasValue)
			{
				return null;
			}
			JToken val = jobject_0["error"];
			string text = ((val == null || (int)val.Type != 8) ? string.Empty : ((string)val));
			return new Class101(bool_, uint_, nullable_, text, nullable_2, bool_2);
		}
		return null;
	}

	internal static Class400 smethod_27(JObject jobject_0)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		if (jobject_0 == null)
		{
			return null;
		}
		if (smethod_28(jobject_0["ready"], out var bool_) && smethod_28(jobject_0["anchored"], out var bool_2))
		{
			float? nullable_ = smethod_29(jobject_0["zoom"]);
			float? nullable_2 = smethod_29(jobject_0["raw"]);
			if (jobject_0["zoom"] != null && !nullable_.HasValue)
			{
				return null;
			}
			if (jobject_0["raw"] != null && !nullable_2.HasValue)
			{
				return null;
			}
			JToken val = jobject_0["reason"];
			string text = ((val == null || (int)val.Type != 8) ? string.Empty : ((string)val));
			return new Class400(bool_, bool_2, text, nullable_, nullable_2);
		}
		return null;
	}

	private static bool smethod_28(JToken jtoken_0, out bool bool_17)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		bool_17 = false;
		if (jtoken_0 != null && (int)jtoken_0.Type == 9)
		{
			bool_17 = (bool)jtoken_0;
			return true;
		}
		return false;
	}

	private static float? smethod_29(JToken jtoken_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (jtoken_0 != null && ((int)jtoken_0.Type == 7 || (int)jtoken_0.Type == 6))
		{
			try
			{
				float num = Convert.ToSingle(((JValue)jtoken_0).Value, CultureInfo.InvariantCulture);
				return (float.IsNaN(num) || float.IsInfinity(num)) ? ((float?)null) : new float?(num);
			}
			catch
			{
				return null;
			}
		}
		return null;
	}

	private Class95 method_202()
	{
		return new Class95(new Dictionary<string, string>(dictionary_0, StringComparer.Ordinal), new Dictionary<string, string>(dictionary_1, StringComparer.Ordinal), new Dictionary<string, string>(dictionary_2, StringComparer.Ordinal));
	}

	internal static IReadOnlyList<GStruct3> smethod_30(JObject jobject_0)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		JToken obj = jobject_0["buffs"];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		if (val == null)
		{
			return null;
		}
		List<GStruct3> list = new List<GStruct3>(((JContainer)val).Count);
		for (int i = 0; i < ((JContainer)val).Count; i++)
		{
			JToken obj2 = val[i];
			JObject val2 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
			if (val2 == null)
			{
				continue;
			}
			JToken val3 = val2["src"];
			if (val3 != null && (int)val3.Type == 8)
			{
				string text = (string)val3;
				if (!(text != "s") || !(text != "y"))
				{
					list.Add(new GStruct3
					{
						bool_0 = (text == "y"),
						int_0 = smethod_19(val2, "slot"),
						ushort_0 = (ushort)smethod_19(val2, "main"),
						ushort_1 = (ushort)smethod_19(val2, "sub"),
						int_1 = smethod_19(val2, "lv"),
						float_0 = smethod_25(val2, "left", 0f)
					});
				}
			}
		}
		return list;
	}

	internal static IReadOnlyList<uint> smethod_31(JObject jobject_0)
	{
		JArray val = (JArray)((jobject_0 == null) ? null : (jobject_0["partyIds"] as JArray));
		if (val == null)
		{
			return null;
		}
		List<uint> list = new List<uint>(((JContainer)val).Count);
		foreach (JToken item in val)
		{
			if (smethod_62(item, out var uint_))
			{
				list.Add(uint_);
				continue;
			}
			return null;
		}
		return list;
	}

	internal static IReadOnlyList<uint> smethod_32(JObject jobject_0)
	{
		JArray val = (JArray)((jobject_0 == null) ? null : (jobject_0["partyPresentIds"] as JArray));
		if (val == null)
		{
			return null;
		}
		List<uint> list = new List<uint>(((JContainer)val).Count);
		foreach (JToken item in val)
		{
			if (smethod_62(item, out var uint_))
			{
				list.Add(uint_);
				continue;
			}
			return null;
		}
		return list;
	}

	internal static IReadOnlyDictionary<uint, IReadOnlyList<GStruct2>> smethod_33(JObject jobject_0, IReadOnlyList<uint> ireadOnlyList_0, IList<Class403> ilist_0, IReadOnlyList<GStruct3> ireadOnlyList_1)
	{
		Dictionary<uint, IReadOnlyList<GStruct2>> dictionary = new Dictionary<uint, IReadOnlyList<GStruct2>>();
		if (ireadOnlyList_0 == null)
		{
			return dictionary;
		}
		uint num = 0u;
		bool flag = false;
		if (ilist_0 != null)
		{
			foreach (Class403 item in ilist_0)
			{
				if (item != null && item.byte_0 == 100 && item.method_2())
				{
					num = item.uint_0;
					flag = true;
					break;
				}
			}
		}
		JObject val = (JObject)((jobject_0 == null) ? null : (jobject_0["pbuffs"] as JObject));
		foreach (uint item2 in ireadOnlyList_0)
		{
			if (flag && item2 == num)
			{
				if (ireadOnlyList_1 != null)
				{
					dictionary[item2] = smethod_35(ireadOnlyList_1);
				}
				continue;
			}
			JArray val2 = (JArray)((val == null) ? null : (val[item2.ToString(CultureInfo.InvariantCulture)] as JArray));
			if (val2 != null)
			{
				dictionary[item2] = smethod_36(val2);
			}
		}
		return dictionary;
	}

	internal static IReadOnlyDictionary<uint, GStruct0> smethod_34(JObject jobject_0, IReadOnlyList<uint> ireadOnlyList_0, IList<Class403> ilist_0)
	{
		Dictionary<uint, GStruct0> dictionary = new Dictionary<uint, GStruct0>();
		JObject val = (JObject)((jobject_0 == null) ? null : (jobject_0["ptargets"] as JObject));
		if (val != null && ireadOnlyList_0 != null && ilist_0 != null)
		{
			HashSet<uint> hashSet = new HashSet<uint>(ireadOnlyList_0);
			{
				foreach (Class403 item in ilist_0)
				{
					if (item != null && item.byte_0 == 100 && hashSet.Contains(item.uint_0))
					{
						JToken obj = val[item.uint_0.ToString(CultureInfo.InvariantCulture)];
						JObject val2 = (JObject)(object)((obj is JObject) ? obj : null);
						if (val2 != null && smethod_55(val2["t"], 0, 255, out var int_) && smethod_55(val2["id"], 0, 65535, out var int_2))
						{
							dictionary[item.uint_0] = new GStruct0
							{
								byte_0 = (byte)int_,
								ushort_0 = (ushort)int_2
							};
						}
					}
				}
				return dictionary;
			}
		}
		return dictionary;
	}

	private static IReadOnlyList<GStruct2> smethod_35(IReadOnlyList<GStruct3> ireadOnlyList_0)
	{
		List<GStruct2> list = new List<GStruct2>();
		foreach (GStruct3 item in ireadOnlyList_0)
		{
			if (!item.bool_0)
			{
				list.Add(new GStruct2
				{
					ushort_0 = item.ushort_0,
					ushort_1 = item.ushort_1,
					int_0 = item.int_1,
					float_0 = item.float_0
				});
			}
		}
		return list;
	}

	private static IReadOnlyList<GStruct2> smethod_36(JArray jarray_0)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		List<GStruct2> list = new List<GStruct2>(((JContainer)jarray_0).Count);
		foreach (JToken item in jarray_0)
		{
			JObject val = (JObject)(object)((item is JObject) ? item : null);
			if (val == null || val["id"] == null || (int)val["id"].Type != 8)
			{
				continue;
			}
			string[] array = ((string)val["id"]).Split(':');
			if (array.Length == 2 && ushort.TryParse(array[0], NumberStyles.Integer, CultureInfo.InvariantCulture, out var result) && ushort.TryParse(array[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out var result2) && smethod_55(val["lv"], 0, 65535, out var int_))
			{
				float num = smethod_25(val, "age", float.NaN);
				if (!float.IsNaN(num) && !float.IsInfinity(num))
				{
					list.Add(new GStruct2
					{
						ushort_0 = result,
						ushort_1 = result2,
						int_0 = int_,
						float_0 = num
					});
				}
			}
		}
		return list;
	}

	internal static GStruct4 smethod_37(JObject jobject_0)
	{
		GStruct4 result = new GStruct4
		{
			float_1 = -1f
		};
		JToken obj = jobject_0["qbox"];
		JObject val = (JObject)(object)((obj is JObject) ? obj : null);
		if (val == null)
		{
			return result;
		}
		result.byte_0 = (byte)smethod_19(val, "type");
		result.float_0 = smethod_25(val, "total", 0f);
		result.float_1 = smethod_25(val, "left", -1f);
		return result;
	}

	internal static (ushort, ushort)[] smethod_38(JObject jobject_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		JToken val = jobject_0["ok"];
		if (val != null && (int)val.Type == 9 && (bool)val)
		{
			JToken obj = jobject_0["ids"];
			JArray val2 = (JArray)(object)((obj is JArray) ? obj : null);
			if (val2 != null && ((JContainer)val2).Count == 10)
			{
				(ushort, ushort)[] array = new(ushort, ushort)[10];
				int num = 0;
				while (true)
				{
					if (num < 10)
					{
						JToken val3 = val2[num];
						if (val3 == null || (int)val3.Type != 8)
						{
							break;
						}
						string[] array2 = ((string)val3).Split(':');
						if (array2.Length == 2)
						{
							if (ushort.TryParse(array2[0], NumberStyles.None, CultureInfo.InvariantCulture, out var result))
							{
								if (ushort.TryParse(array2[1], NumberStyles.None, CultureInfo.InvariantCulture, out var result2))
								{
									array[num] = (result, result2);
									num++;
									continue;
								}
								return null;
							}
							return null;
						}
						return null;
					}
					return array;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	internal static string smethod_39(JObject jobject_0, IReadOnlyList<Struct19> ireadOnlyList_0, bool bool_17)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		if (jobject_0 == null)
		{
			return "the agent refused the bag without saying why";
		}
		JToken val = jobject_0["ok"];
		if (val != null && (int)val.Type == 9 && (bool)val)
		{
			if (ireadOnlyList_0 == null)
			{
				return "the reply did not carry twelve equipment slots";
			}
			if (!bool_17)
			{
				return "the reply carried no sequence number";
			}
			return string.Empty;
		}
		JToken val2 = jobject_0["error"];
		if (val2 != null && (int)val2.Type == 8 && ((string)val2).Length != 0)
		{
			return (string)val2;
		}
		return "the agent refused the bag without saying why";
	}

	internal static IReadOnlyList<Struct27> smethod_40(JObject jobject_0)
	{
		List<Struct27> list = new List<Struct27>();
		if (jobject_0 == null)
		{
			return list;
		}
		JToken obj = jobject_0["bag"];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		if (val == null)
		{
			return list;
		}
		for (int i = 0; i < ((JContainer)val).Count; i++)
		{
			JToken obj2 = val[i];
			JObject val2 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
			if (val2 != null && smethod_55(val2["i"], 0, int.MaxValue, out var int_) && smethod_55(val2["ord"], 0, int.MaxValue, out var int_2) && smethod_55(val2["main"], 0, 65535, out var int_3) && smethod_55(val2["sub"], 0, 65535, out var int_4) && smethod_55(val2["amt"], 1, int.MaxValue, out var int_5))
			{
				Struct27 item = new Struct27
				{
					int_0 = int_,
					int_1 = int_2,
					ushort_0 = (ushort)int_3,
					ushort_1 = (ushort)int_4,
					int_2 = int_5
				};
				if (smethod_55(val2["type"], 0, 255, out var int_6))
				{
					item.nullable_0 = (byte)int_6;
				}
				list.Add(item);
			}
		}
		return list;
	}

	internal static int smethod_41(JObject jobject_0)
	{
		if (jobject_0 == null)
		{
			return 0;
		}
		if (!smethod_55(jobject_0["cap"], 1, int.MaxValue, out var int_))
		{
			return 0;
		}
		return int_;
	}

	internal static int smethod_42(JObject jobject_0)
	{
		if (jobject_0 == null)
		{
			return 0;
		}
		if (!smethod_55(jobject_0["slots"], 0, int.MaxValue, out var int_))
		{
			return 0;
		}
		return int_;
	}

	internal static IReadOnlyList<Struct19> smethod_43(JObject jobject_0)
	{
		if (jobject_0 == null)
		{
			return null;
		}
		JToken obj = jobject_0["equip"];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		if (val != null && ((JContainer)val).Count == 12)
		{
			Struct19[] array = new Struct19[12];
			int num = 0;
			while (true)
			{
				if (num >= 12)
				{
					return array;
				}
				JToken obj2 = val[num];
				JObject val2 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
				if (val2 == null)
				{
					break;
				}
				if (smethod_55(val2["i"], 0, int.MaxValue, out var int_))
				{
					if (smethod_55(val2["pos"], 0, 255, out var int_2))
					{
						if (smethod_55(val2["main"], 0, 65535, out var int_3))
						{
							if (smethod_55(val2["sub"], 0, 65535, out var int_4))
							{
								if (smethod_55(val2["amt"], int.MinValue, int.MaxValue, out var int_5))
								{
									array[num].int_0 = int_;
									array[num].byte_0 = (byte)int_2;
									array[num].ushort_0 = (ushort)int_3;
									array[num].ushort_1 = (ushort)int_4;
									array[num].int_1 = int_5;
									num++;
									continue;
								}
								return null;
							}
							return null;
						}
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	internal static string smethod_44(JObject jobject_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		if (jobject_0 == null)
		{
			return null;
		}
		JToken val = jobject_0["state"];
		if (val != null && (int)val.Type == 8)
		{
			string result = (string)val;
			if (!Class409.smethod_1(result))
			{
				return null;
			}
			return result;
		}
		return null;
	}

	internal static IReadOnlyList<Class78> smethod_45(JObject jobject_0, string string_18, IReadOnlyList<Class409.Struct125> ireadOnlyList_0)
	{
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Invalid comparison between Unknown and I4
		if (jobject_0 != null && Class409.smethod_1(string_18))
		{
			JToken obj = jobject_0["outcomes"];
			JArray val = (JArray)(object)((obj is JArray) ? obj : null);
			if (val != null && ireadOnlyList_0 != null && ireadOnlyList_0.Count != 0 && ((JContainer)val).Count == ireadOnlyList_0.Count)
			{
				List<Class78> list = new List<Class78>();
				int num = 0;
				while (true)
				{
					if (num >= ((JContainer)val).Count)
					{
						return list;
					}
					JToken obj2 = val[num];
					JObject val2 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
					if (val2 == null)
					{
						break;
					}
					if (smethod_55(val2["slot"], 0, 65535, out var int_))
					{
						if (smethod_55(val2["ord"], 0, int.MaxValue, out var int_2))
						{
							if (smethod_55(val2["main"], 0, 65535, out var int_3))
							{
								if (smethod_55(val2["sub"], 0, 65535, out var int_4))
								{
									Class409.Struct125 @struct = ireadOnlyList_0[num];
									if (int_ == @struct.int_0 && int_2 == @struct.int_1 && int_3 == @struct.ushort_0 && int_4 == @struct.ushort_1)
									{
										if (smethod_46(val2["matched"], out var bool_))
										{
											if (smethod_46(val2["attempted"], out var bool_2))
											{
												if (smethod_46(val2["gone"], out var bool_3))
												{
													JToken val3 = val2["outcome"];
													if (val3 != null && (int)val3.Type == 8)
													{
														string string_19 = (string)val3;
														if (Class409.smethod_2(string_19))
														{
															if (smethod_47(string_18, string_19, bool_, bool_2, bool_3))
															{
																list.Add(new Class78
																{
																	int_0 = int_,
																	int_1 = int_2,
																	ushort_0 = (ushort)int_3,
																	ushort_1 = (ushort)int_4,
																	bool_0 = bool_,
																	bool_1 = bool_2,
																	bool_2 = bool_3,
																	string_0 = string_19
																});
																num++;
																continue;
															}
															return null;
														}
														return null;
													}
													return null;
												}
												return null;
											}
											return null;
										}
										return null;
									}
									return null;
								}
								return null;
							}
							return null;
						}
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	private static bool smethod_46(JToken jtoken_0, out bool bool_17)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		bool_17 = false;
		if (jtoken_0 != null && (int)jtoken_0.Type == 9)
		{
			bool_17 = (bool)jtoken_0;
			return true;
		}
		return false;
	}

	private static bool smethod_47(string string_18, string string_19, bool bool_17, bool bool_18, bool bool_19)
	{
		if (string.Equals(string_19, "skipped", StringComparison.Ordinal))
		{
			if (!bool_17 && !bool_18)
			{
				return !bool_19;
			}
			return false;
		}
		if (string.Equals(string_19, "sold", StringComparison.Ordinal))
		{
			return string_18 == "complete" && bool_17 && bool_18 && bool_19;
		}
		if (string.Equals(string_19, "nochange", StringComparison.Ordinal))
		{
			if (string_18 == "complete" && bool_17 && bool_18)
			{
				return !bool_19;
			}
			return false;
		}
		return false;
	}

	internal static string smethod_48(JObject jobject_0, IReadOnlyList<Class78> ireadOnlyList_0, string string_18, bool bool_17)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		if (jobject_0 == null)
		{
			return "the agent refused the sale without saying why";
		}
		JToken val = jobject_0["ok"];
		if (val != null && (int)val.Type == 9 && (bool)val)
		{
			if (string_18 == null)
			{
				return "the reply did not carry a known sale state";
			}
			if (ireadOnlyList_0 == null)
			{
				return "the reply carried malformed sale outcomes";
			}
			if (!bool_17)
			{
				return "the reply carried no sequence number";
			}
			return string.Empty;
		}
		JToken val2 = jobject_0["error"];
		if (val2 != null && (int)val2.Type == 8 && ((string)val2).Length != 0)
		{
			return (string)val2;
		}
		return "the agent refused the sale without saying why";
	}

	internal static bool smethod_49(JObject jobject_0, string string_18, string string_19, out bool bool_17, out string string_20, out int int_17)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		bool_17 = false;
		string_20 = string.Empty;
		int_17 = 0;
		if (jobject_0 == null)
		{
			string_20 = string_18;
			return false;
		}
		JToken val = jobject_0["ok"];
		if (val != null && (int)val.Type == 9)
		{
			bool_17 = (bool)val;
			if (!bool_17)
			{
				JToken val2 = jobject_0["error"];
				string_20 = ((val2 == null || (int)val2.Type != 8 || ((string)val2).Length == 0) ? string_18 : ((string)val2));
				return true;
			}
			if (!smethod_55(jobject_0["seq"], 1, int.MaxValue, out int_17))
			{
				string_20 = string_19;
				return false;
			}
			return true;
		}
		string_20 = string_18;
		return false;
	}

	internal static string smethod_50(JObject jobject_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		if (jobject_0 == null)
		{
			return null;
		}
		JToken val = jobject_0["state"];
		if (val != null && (int)val.Type == 8)
		{
			string result = (string)val;
			if (!Class347.smethod_1(result))
			{
				return null;
			}
			return result;
		}
		return null;
	}

	internal static string smethod_51(JObject jobject_0, string string_18, bool bool_17)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		if (jobject_0 == null)
		{
			return "the agent refused the friend list without saying why";
		}
		JToken val = jobject_0["ok"];
		if (val != null && (int)val.Type == 9 && (bool)val)
		{
			if (string_18 == null)
			{
				return "the reply did not say whether the friend list is ready";
			}
			if (!bool_17)
			{
				return "the reply carried no sequence number";
			}
			return string.Empty;
		}
		JToken val2 = jobject_0["error"];
		if (val2 != null && (int)val2.Type == 8 && ((string)val2).Length != 0)
		{
			return (string)val2;
		}
		return "the agent refused the friend list without saying why";
	}

	internal static IReadOnlyList<Struct140> smethod_52(JObject jobject_0, out int int_17)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Invalid comparison between Unknown and I4
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Invalid comparison between Unknown and I4
		int_17 = 0;
		List<Struct140> list = new List<Struct140>();
		if (jobject_0 == null)
		{
			return list;
		}
		JToken obj = jobject_0["friends"];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		if (val == null)
		{
			return list;
		}
		for (int i = 0; i < ((JContainer)val).Count; i++)
		{
			JToken obj2 = val[i];
			JObject val2 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
			if (val2 == null)
			{
				int_17++;
				continue;
			}
			JToken val3 = val2["name"];
			if (val3 != null && (int)val3.Type == 8)
			{
				string text = (string)val3;
				if (text.Trim().Length == 0)
				{
					int_17++;
					continue;
				}
				if (!smethod_55(val2["id"], int.MinValue, int.MaxValue, out var int_18))
				{
					int_17++;
					continue;
				}
				if (!smethod_55(val2["flag"], -128, 127, out var int_19))
				{
					int_17++;
					continue;
				}
				if (!smethod_55(val2["ch"], 0, 255, out var int_20))
				{
					int_17++;
					continue;
				}
				if (!smethod_55(val2["lv"], 0, 65535, out var int_21))
				{
					int_17++;
					continue;
				}
				if (!smethod_55(val2["cls"], 0, 255, out var int_22))
				{
					int_17++;
					continue;
				}
				if (!smethod_55(val2["sch"], 0, 255, out var int_23))
				{
					int_17++;
					continue;
				}
				JToken val4 = val2["online"];
				if (val4 != null && (int)val4.Type == 9)
				{
					JToken val5 = val2["known"];
					if (val5 != null && (int)val5.Type == 9)
					{
						list.Add(new Struct140
						{
							string_0 = text,
							int_0 = int_18,
							sbyte_0 = (sbyte)int_19,
							bool_0 = (bool)val4,
							bool_1 = (bool)val5,
							byte_0 = (byte)int_20,
							ushort_0 = (ushort)int_21,
							byte_1 = (byte)int_22,
							byte_2 = (byte)int_23
						});
					}
					else
					{
						int_17++;
					}
				}
				else
				{
					int_17++;
				}
			}
			else
			{
				int_17++;
			}
		}
		return list;
	}

	internal static Class74 smethod_53(JObject jobject_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		Class74 obj = new Class74
		{
			int_0 = smethod_19(jobject_0, "slot")
		};
		JToken val = jobject_0["result"];
		obj.string_0 = ((val == null || (int)val.Type != 8) ? string.Empty : ((string)val));
		JToken val2 = jobject_0["code"];
		obj.int_1 = ((val2 == null || (int)val2.Type != 6) ? (-1) : ((int)val2));
		JToken val3 = jobject_0["settle_ms"];
		obj.int_2 = ((val3 == null || (int)val3.Type != 6) ? (-1) : ((int)val3));
		JToken val4 = jobject_0["timed_out"];
		obj.bool_0 = val4 != null && (int)val4.Type == 9 && (bool)val4;
		JToken val5 = jobject_0["why"];
		obj.string_1 = ((val5 == null || (int)val5.Type != 8) ? string.Empty : ((string)val5));
		return obj;
	}

	internal static Class358 smethod_54(JObject jobject_0, long long_10, Class358 class358_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		if (jobject_0 == null)
		{
			return class358_1;
		}
		JToken val = jobject_0["ok"];
		if (val != null && (int)val.Type == 9 && (bool)val)
		{
			JToken obj = jobject_0["ids"];
			JArray val2 = (JArray)(object)((obj is JArray) ? obj : null);
			if (val2 == null)
			{
				return class358_1;
			}
			List<Struct16> list = new List<Struct16>();
			for (int i = 0; i < ((JContainer)val2).Count; i++)
			{
				if (list.Count >= 10)
				{
					break;
				}
				JToken obj2 = val2[i];
				JObject val3 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
				if (val3 != null && smethod_55(val3["main"], 0, 65535, out var int_) && smethod_55(val3["sub"], 0, 65535, out var int_2))
				{
					if (!smethod_55(val3["code"], int.MinValue, int.MaxValue, out var int_3))
					{
						int_3 = -1;
					}
					list.Add(new Struct16
					{
						ushort_0 = (ushort)int_,
						ushort_1 = (ushort)int_2,
						int_0 = int_3
					});
				}
			}
			return new Class358
			{
				long_0 = long_10,
				struct16_0 = list.ToArray()
			};
		}
		return class358_1;
	}

	private static bool smethod_55(JToken jtoken_0, int int_17, int int_18, out int int_19)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		int_19 = 0;
		JValue val = (JValue)(object)((jtoken_0 is JValue) ? jtoken_0 : null);
		if (val != null && (int)((JToken)val).Type == 6 && val.Value is long)
		{
			long num = (long)val.Value;
			if (num >= int_17 && num <= int_18)
			{
				int_19 = (int)num;
				return true;
			}
			return false;
		}
		return false;
	}

	private void method_203(JObject jobject_0)
	{
		JToken obj = jobject_0["mnames"];
		smethod_56((JObject)(object)((obj is JObject) ? obj : null), dictionary_0);
		JToken obj2 = jobject_0["inames"];
		smethod_56((JObject)(object)((obj2 is JObject) ? obj2 : null), dictionary_1);
		JToken obj3 = jobject_0["pnames"];
		smethod_56((JObject)(object)((obj3 is JObject) ? obj3 : null), dictionary_2);
	}

	private static void smethod_56(JObject jobject_0, Dictionary<string, string> dictionary_3)
	{
		if (jobject_0 == null)
		{
			return;
		}
		foreach (KeyValuePair<string, JToken> item in jobject_0)
		{
			if (!string.IsNullOrEmpty(item.Key))
			{
				dictionary_3[item.Key] = (string)item.Value;
			}
		}
	}

	private static List<Class403> smethod_57(IntPtr intptr_1, int int_17)
	{
		List<Class403> list = new List<Class403>();
		if (!(intptr_1 == IntPtr.Zero) && int_17 >= 32)
		{
			byte[] array = new byte[int_17];
			Marshal.Copy(intptr_1, array, 0, int_17);
			for (int i = 0; i + 32 <= array.Length; i += 32)
			{
				// kind < 100 = มอน/บอส: HP เป็น u32 (now @6, max @28); player/item/money ยังเป็น u16
				bool flag = array[i] < 100;
				list.Add(new Class403
				{
					byte_0 = array[i],
					byte_1 = array[i + 1],
					ushort_0 = BitConverter.ToUInt16(array, i + 2),
					ushort_1 = BitConverter.ToUInt16(array, i + 4),
					ushort_2 = (flag ? BitConverter.ToUInt32(array, i + 6) : BitConverter.ToUInt16(array, i + 6)),
					ushort_3 = (flag ? BitConverter.ToUInt32(array, i + 28) : BitConverter.ToUInt16(array, i + 8)),
					ushort_4 = BitConverter.ToUInt16(array, i + 10),
					uint_0 = BitConverter.ToUInt32(array, i + 12),
					float_0 = BitConverter.ToSingle(array, i + 16),
					float_1 = BitConverter.ToSingle(array, i + 20),
					float_2 = BitConverter.ToSingle(array, i + 24),
					ushort_5 = BitConverter.ToUInt16(array, i + 28),
					byte_2 = array[i + 30],
					byte_3 = array[i + 31]
				});
			}
			return list;
		}
		return list;
	}

	internal void method_204(int int_17, IntPtr intptr_1)
	{
		Class126 @class = new Class126();
		@class.class119_0 = this;
		@class.int_0 = int_17;
		lock (object_1)
		{
			if (intptr_1.ToInt64() != Interlocked.Read(ref long_0))
			{
				return;
			}
			long_1 = intptr_1.ToInt64();
			nullable_0 = null;
			bool_14 = false;
			Interlocked.Increment(ref long_5);
			Volatile.Write(ref int_1, 0);
			long_3 = intptr_1.ToInt64();
			string_2 = "the agent detached";
			bool_3 = false;
			bool_4 = false;
			string_3 = null;
			long_4 = -1L;
			class147_0 = Class147.smethod_0();
			manualResetEventSlim_0.Set();
			manualResetEventSlim_1.Set();
			manualResetEventSlim_2.Set();
			manualResetEventSlim_3.Set();
			manualResetEventSlim_4.Set();
			manualResetEventSlim_5.Set();
		}
		method_208("detached, reason=" + @class.int_0);
		Volatile.Write(ref int_11, 0);
		bool_5 = false;
		bool_10 = false;
		bool_6 = false;
		bool_7 = false;
		bool_8 = false;
		bool_9 = false;
		bool_11 = false;
		bool_12 = false;
		bool_13 = false;
		method_146();
		method_155();
		method_162();
		class145_0 = Class145.class145_0;
		struct125_0 = null;
		string_14 = null;
		string_15 = null;
		method_95();
		method_206(@class.method_0);
	}

	private void method_205(string string_18, IntPtr intptr_1)
	{
		Class123 @class = new Class123();
		@class.class119_0 = this;
		@class.intptr_0 = intptr_1;
		@class.string_0 = string_18;
		if (@class.intptr_0.ToInt64() != Interlocked.Read(ref long_0))
		{
			return;
		}
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(object_0, 0, ref lockTaken);
			if (!lockTaken)
			{
				ThreadPool.QueueUserWorkItem(@class.method_0);
			}
			else if (@class.intptr_0.ToInt64() == Interlocked.Read(ref long_0))
			{
				method_180(@class.string_0);
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(object_0);
			}
		}
	}

	internal static bool smethod_58(string string_18, string string_19)
	{
		if (string_18 == null)
		{
			return false;
		}
		try
		{
			return (bool?)JObject.Parse(string_18)[string_19] == true;
		}
		catch
		{
			return false;
		}
	}

	private static string smethod_59(JToken jtoken_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		if (jtoken_0 != null && (int)jtoken_0.Type == 8)
		{
			return (string)jtoken_0;
		}
		return null;
	}

	private static string smethod_60(JObject jobject_0, string string_18)
	{
		string text = smethod_59((jobject_0 == null) ? null : jobject_0["error"]);
		if (!string.IsNullOrWhiteSpace(text) && text.Length <= 160)
		{
			string text2 = text;
			int num = 0;
			while (true)
			{
				if (num < text2.Length)
				{
					if (char.IsControl(text2[num]))
					{
						break;
					}
					num++;
					continue;
				}
				return text;
			}
			return string_18;
		}
		return string_18;
	}

	internal static string smethod_61()
	{
		if (string_17 != null)
		{
			return string_17;
		}
		try
		{
			using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("runtime.js");
			if (stream == null)
			{
				return null;
			}
			StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
			try
			{
				string_17 = streamReader.ReadToEnd();
			}
			finally
			{
				((IDisposable)streamReader).Dispose();
			}
		}
		catch
		{
			return null;
		}
		return string_17;
	}

	private void method_206(Action action_16)
	{
		Class128 @class = new Class128();
		@class.action_0 = action_16;
		SynchronizationContext synchronizationContext = synchronizationContext_0;
		if (synchronizationContext != null)
		{
			synchronizationContext.Post(@class.method_0, null);
		}
		else
		{
			@class.action_0();
		}
	}

	private void method_207(long long_10, Action action_16)
	{
		Class122 @class = new Class122();
		@class.class119_0 = this;
		@class.long_0 = long_10;
		@class.action_0 = action_16;
		method_206(@class.method_0);
	}

	private void method_208(string string_18)
	{
		Class125 @class = new Class125();
		@class.class119_0 = this;
		@class.string_0 = string_18;
		if (Class172.smethod_0(@class.string_0))
		{
			method_206(@class.method_0);
		}
	}

	internal void method_209(string string_18)
	{
		method_208(string_18 ?? string.Empty);
	}

	public void Dispose()
	{
		method_210();
	}

	public void method_210()
	{
		lock (object_0)
		{
			action_7?.Invoke();
			method_211();
		}
	}

	private void method_211()
	{
		class32_0 = null;
		Volatile.Write(ref int_11, 0);
		IntPtr zero = IntPtr.Zero;
		string string_ = null;
		lock (object_1)
		{
			if (intptr_0 != IntPtr.Zero && bool_4)
			{
				zero = intptr_0;
				string_ = string_3;
				bool_4 = false;
			}
		}
		if (zero != IntPtr.Zero)
		{
			method_87(zero, string_);
		}
		method_95();
		if (intptr_0 != IntPtr.Zero)
		{
			try
			{
				method_180("{\"cmd\":\"frame_hook\",\"on\":false}");
				Thread.Sleep(200);
			}
			catch
			{
			}
		}
		IntPtr intPtr;
		lock (object_1)
		{
			Interlocked.Increment(ref long_0);
			Volatile.Write(ref int_1, 0);
			long_1 = -1L;
			intPtr = intptr_0;
			intptr_0 = IntPtr.Zero;
		}
		method_212();
		if (intPtr != IntPtr.Zero)
		{
			method_214(intPtr);
		}
	}

	private void method_212()
	{
		Volatile.Write(ref int_11, 0);
		Volatile.Write(ref int_1, 0);
		manualResetEventSlim_0.Reset();
		manualResetEventSlim_1.Reset();
		int_3 = 0;
		long_2 = -1L;
		bool_0 = false;
		string_1 = null;
		lock (object_1)
		{
			method_89();
		}
		string_9 = null;
		string_10 = null;
		string_11 = null;
		string_12 = null;
		string_13 = null;
		struct125_0 = null;
		string_14 = null;
		string_15 = null;
		bool_5 = false;
		bool_10 = false;
		bool_6 = false;
		bool_7 = false;
		bool_8 = false;
		bool_9 = false;
		bool_11 = false;
		bool_12 = false;
		bool_13 = false;
		method_99();
		method_146();
		method_155();
		method_162();
		class145_0 = Class145.class145_0;
		valueTuple_0 = null;
		class358_0 = null;
	}

	private bool method_213()
	{
		lock (object_2)
		{
			if (thread_0 == null)
			{
				return false;
			}
			if (thread_0.IsAlive)
			{
				return true;
			}
			thread_0 = null;
			return false;
		}
	}

	private bool method_214(IntPtr intptr_1)
	{
		Class130 @class = new Class130();
		@class.intptr_0 = intptr_1;
		@class.class119_0 = this;
		if (@class.intptr_0 == IntPtr.Zero)
		{
			return true;
		}
		@class.interface2_0 = interface2_0;
		@class.exception_0 = null;
		@class.thread_0 = null;
		@class.thread_0 = new Thread(@class.method_0)
		{
			IsBackground = true
		};
		lock (object_2)
		{
			if (thread_0 != null && thread_0.IsAlive)
			{
				method_208("close was not started because another native close is still running");
				return false;
			}
			thread_0 = @class.thread_0;
			@class.thread_0.Start();
		}
		if (!@class.thread_0.Join(int_0))
		{
			method_208("close did not return within the wait limit; later attaches are refused until it completes");
			return false;
		}
		if (@class.exception_0 != null)
		{
			method_208("close failed: " + @class.exception_0.Message);
		}
		return true;
	}

	private static bool smethod_62(JToken jtoken_0, out uint uint_2)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		uint_2 = 0u;
		JValue val = (JValue)(object)((jtoken_0 is JValue) ? jtoken_0 : null);
		if (val != null && (int)((JToken)val).Type == 6 && val.Value is long)
		{
			long num = (long)val.Value;
			if (num >= 0L && num <= 4294967295L)
			{
				uint_2 = (uint)num;
				return true;
			}
			return false;
		}
		return false;
	}
}
