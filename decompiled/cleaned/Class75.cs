using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

internal sealed class Class75
{
	private sealed class Class76 : IDisposable
	{
		private readonly Class75 class75_0;

		private int int_0;

		internal Class76(Class75 class75_1)
		{
			class75_0 = class75_1;
		}

		public void Dispose()
		{
			if (Interlocked.Exchange(ref int_0, 1) == 0)
			{
				asyncLocal_0.Value = class75_0;
			}
		}
	}

	[Serializable]
	private sealed class Class77
	{
		public static readonly Class77 class77_0 = new Class77();

		internal Task method_0(int int_0)
		{
			return Task.Delay(int_0);
		}
	}

	private static readonly AsyncLocal<Class75> asyncLocal_0 = new AsyncLocal<Class75>();

	private static readonly Class75 class75_0 = new Class75(Stopwatch.GetTimestamp, Stopwatch.Frequency, Class77.class77_0.method_0, null, null);

	internal readonly Func<long> func_0;

	internal readonly long long_0;

	internal readonly Func<int, Task> func_1;

	private readonly bool? nullable_0;

	private readonly bool? nullable_1;

	private Class75(Func<long> func_2, long long_1, Func<int, Task> func_3, bool? nullable_2, bool? nullable_3)
	{
		if (func_2 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141037358));
		}
		if (long_1 <= 0L)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(-1141037361));
		}
		if (func_3 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141037372));
		}
		func_0 = func_2;
		long_0 = long_1;
		func_1 = func_3;
		nullable_0 = nullable_2;
		nullable_1 = nullable_3;
	}

	internal bool method_0()
	{
		return nullable_0 ?? Class357.smethod_42();
	}

	internal bool method_1()
	{
		return nullable_1 ?? Class357.smethod_44();
	}

	internal static Class75 smethod_0()
	{
		return asyncLocal_0.Value ?? class75_0;
	}

	internal static IDisposable smethod_1(Func<long> func_2, long long_1, Func<int, Task> func_3, bool bool_0, bool bool_1)
	{
		Class75 value = asyncLocal_0.Value;
		asyncLocal_0.Value = new Class75(func_2, long_1, func_3, bool_0, bool_1);
		return new Class76(value);
	}
}
