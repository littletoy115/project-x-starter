using System;
using System.Threading;
using System.Threading.Tasks;

internal sealed class Class148
{
	private readonly long long_0;

	private Task task_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private Exception exception_0;

	internal int int_4 = -1;

	internal int int_5 = -1;

	internal uint uint_0;

	internal Class148(long long_1)
	{
		if (long_1 <= 0L)
		{
			throw new ArgumentOutOfRangeException("\u000e");
		}
		long_0 = long_1;
		int_0 = 0;
	}

	internal long method_0()
	{
		return long_0;
	}

	internal Task method_1()
	{
		return Volatile.Read(ref task_0);
	}

	internal Enum5 method_2()
	{
		return (Enum5)Volatile.Read(ref int_0);
	}

	internal bool method_3()
	{
		return Volatile.Read(ref int_1) != 0;
	}

	internal bool method_4()
	{
		return Volatile.Read(ref int_2) != 0;
	}

	internal Exception method_5()
	{
		return Interlocked.CompareExchange(ref exception_0, null, null);
	}

	internal void method_6(Task task_1)
	{
		if (task_1 == null)
		{
			throw new ArgumentNullException("\u000e");
		}
		if (Interlocked.CompareExchange(ref task_0, task_1, null) != null)
		{
			throw new InvalidOperationException("The automatic worker is already attached.");
		}
	}

	internal bool method_7()
	{
		Interlocked.Exchange(ref int_1, 1);
		return method_11((Enum5)2);
	}

	internal bool method_8()
	{
		return Interlocked.Exchange(ref int_2, 1) == 0;
	}

	internal bool method_9(Exception exception_1)
	{
		method_12(exception_1);
		return method_11((Enum5)3);
	}

	internal bool method_10()
	{
		return method_11((Enum5)4);
	}

	internal bool method_11(Enum5 enum5_0)
	{
		if (enum5_0 == (Enum5)0)
		{
			throw new ArgumentOutOfRangeException("reason");
		}
		return Interlocked.CompareExchange(ref int_0, (int)enum5_0, 0) == 0;
	}

	internal Exception method_12(Exception exception_1)
	{
		if (exception_1 == null)
		{
			throw new ArgumentNullException("\u000e");
		}
		Interlocked.CompareExchange(ref exception_0, exception_1, null);
		return Interlocked.CompareExchange(ref exception_0, null, null);
	}

	internal Exception method_13()
	{
		return method_12(new InvalidOperationException("Automatic generation " + method_0() + " completed with an unexpected exit."));
	}

	internal bool method_14(long long_1, Task task_1, Exception exception_1)
	{
		if (long_1 == method_0() && task_1 == method_1() && exception_1 == method_5())
		{
			return Interlocked.CompareExchange(ref int_3, 1, 0) == 0;
		}
		return false;
	}
}
