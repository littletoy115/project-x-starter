using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

internal sealed class Class169
{
	private sealed class Class170 : IDisposable
	{
		private readonly Class169 class169_0;

		private int int_0;

		internal Class170(Class169 class169_1)
		{
			class169_0 = class169_1;
		}

		public void Dispose()
		{
			if (Interlocked.Exchange(ref int_0, 1) == 0)
			{
				asyncLocal_0.Value = class169_0;
			}
		}
	}

	[Serializable]
	private sealed class Class171
	{
		public static readonly Class171 class171_0 = new Class171();

		public static Func<int, Task> func_0;

		public static Func<Class119, bool> func_1;

		internal Task method_0(int int_0)
		{
			return Task.CompletedTask;
		}

		internal bool method_1(Class119 class119_0)
		{
			return class119_0.method_136();
		}

		internal bool method_2(Class119 class119_0)
		{
			return class119_0.method_135();
		}

		internal Task method_3(int int_0)
		{
			return Task.Delay(int_0);
		}
	}

	private static readonly AsyncLocal<Class169> asyncLocal_0 = new AsyncLocal<Class169>();

	private static readonly Class169 class169_0 = new Class169(Stopwatch.GetTimestamp, Stopwatch.Frequency, Class171.class171_0.method_2, null, Class171.class171_0.method_3, smethod_4);

	private static readonly object object_0 = new object();

	private static readonly Random random_0 = new Random();

	internal readonly Func<long> func_0;

	internal readonly long long_0;

	private readonly Func<Class119, bool> func_1;

	private readonly Action action_0;

	private readonly Func<int, Task> func_2;

	private readonly Func<int, int, int> func_3;

	private Class169(Func<long> func_4, long long_1, Func<Class119, bool> func_5, Action action_1, Func<int, Task> func_6, Func<int, int, int> func_7)
	{
		if (func_4 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141035588));
		}
		if (long_1 <= 0L)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(-1141035607));
		}
		if (func_5 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141035610));
		}
		if (func_6 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141035629));
		}
		if (func_7 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141035640));
		}
		func_0 = func_4;
		long_0 = long_1;
		func_1 = func_5;
		action_0 = action_1;
		func_2 = func_6;
		func_3 = func_7;
	}

	internal static Class169 smethod_0()
	{
		return asyncLocal_0.Value ?? class169_0;
	}

	internal static IDisposable smethod_1(Func<long> func_4, long long_1)
	{
		return smethod_2(func_4, long_1, null);
	}

	internal static IDisposable smethod_2(Func<long> func_4, long long_1, Action action_1)
	{
		return smethod_3(func_4, long_1, action_1, Class171.class171_0.method_0, smethod_4);
	}

	internal static IDisposable smethod_3(Func<long> func_4, long long_1, Action action_1, Func<int, Task> func_5, Func<int, int, int> func_6)
	{
		Class169 value = asyncLocal_0.Value;
		asyncLocal_0.Value = new Class169(func_4, long_1, Class171.class171_0.method_1, action_1, func_5, func_6);
		return new Class170(value);
	}

	internal bool method_0(Class119 class119_0)
	{
		if (class119_0 != null)
		{
			return func_1(class119_0);
		}
		return false;
	}

	internal void method_1()
	{
		if (action_0 != null)
		{
			action_0();
		}
	}

	internal Task method_2(int int_0)
	{
		return func_2(int_0);
	}

	internal int method_3(int int_0, int int_1)
	{
		return func_3(int_0, int_1);
	}

	private static int smethod_4(int int_0, int int_1)
	{
		lock (object_0)
		{
			return random_0.Next(int_0, int_1);
		}
	}
}
