using System;

internal sealed class Class8
{
	internal static readonly Class8 class8_0 = new Class8(0L, bool_6: false, bool_7: false, bool_8: false, bool_9: false, bool_10: false, bool_11: false, null, 0);

	private readonly long long_0;

	private readonly bool bool_0;

	private readonly bool bool_1;

	private readonly bool bool_2;

	private readonly bool bool_3;

	private readonly bool bool_4;

	private readonly bool bool_5;

	private readonly Exception exception_0;

	private readonly int int_0;

	private Class8(long long_1, bool bool_6, bool bool_7, bool bool_8, bool bool_9, bool bool_10, bool bool_11, Exception exception_1, int int_1)
	{
		long_0 = long_1;
		bool_0 = bool_6;
		bool_1 = bool_7;
		bool_2 = bool_8;
		bool_3 = bool_9;
		bool_4 = bool_10;
		bool_5 = bool_11;
		exception_0 = exception_1;
		int_0 = int_1;
	}

	internal long method_0()
	{
		return long_0;
	}

	internal bool method_1()
	{
		return bool_0;
	}

	internal bool method_2()
	{
		return bool_1;
	}

	internal bool method_3()
	{
		return bool_2;
	}

	internal bool method_4()
	{
		return bool_3;
	}

	internal bool method_5()
	{
		return bool_4;
	}

	internal bool method_6()
	{
		return bool_5;
	}

	internal Exception method_7()
	{
		return exception_0;
	}

	internal int method_8()
	{
		return int_0;
	}

	internal bool method_9()
	{
		if (!method_1() && !method_2() && !method_3() && !method_4() && !method_5())
		{
			return !method_6();
		}
		return false;
	}

	internal bool method_10()
	{
		if (method_6())
		{
			return method_11() == (Enum2)1;
		}
		return false;
	}

	internal Enum2 method_11()
	{
		if (method_1())
		{
			return (Enum2)4;
		}
		if (!method_2() && !method_3())
		{
			if (!method_4() && !method_5())
			{
				if (method_6())
				{
					return (Enum2)1;
				}
				return (Enum2)0;
			}
			return (Enum2)2;
		}
		return (Enum2)3;
	}

	internal static Class8 smethod_0(long long_1)
	{
		return new Class8(long_1, bool_6: true, bool_7: false, bool_8: false, bool_9: false, bool_10: false, bool_11: false, null, 0);
	}

	internal static Class8 smethod_1(long long_1, int int_1)
	{
		return new Class8(long_1, bool_6: false, bool_7: true, bool_8: false, bool_9: false, bool_10: false, bool_11: false, null, int_1);
	}

	internal static Class8 smethod_2(long long_1, Exception exception_1)
	{
		if (exception_1 == null)
		{
			throw new ArgumentNullException("exception");
		}
		return new Class8(long_1, bool_6: false, bool_7: false, bool_8: true, bool_9: false, bool_10: false, bool_11: false, exception_1, 0);
	}

	internal static Class8 smethod_3(long long_1)
	{
		return new Class8(long_1, bool_6: false, bool_7: false, bool_8: false, bool_9: true, bool_10: false, bool_11: false, null, 0);
	}

	internal static Class8 smethod_4(long long_1)
	{
		return new Class8(long_1, bool_6: false, bool_7: false, bool_8: false, bool_9: false, bool_10: true, bool_11: false, null, 0);
	}

	internal static Class8 smethod_5(long long_1)
	{
		return new Class8(long_1, bool_6: false, bool_7: false, bool_8: false, bool_9: false, bool_10: false, bool_11: true, null, 0);
	}

	internal Class8 method_12(Class8 class8_1)
	{
		if (class8_1 != null && !class8_1.method_9())
		{
			if (method_9())
			{
				return class8_1;
			}
			if (method_0() != class8_1.method_0())
			{
				throw new InvalidOperationException("Cannot merge Stop requests from different generations.");
			}
			return new Class8(method_0(), method_1() || class8_1.method_1(), method_2() || class8_1.method_2(), method_3() || class8_1.method_3(), method_4() || class8_1.method_4(), method_5() || class8_1.method_5(), method_6() || class8_1.method_6(), method_7() ?? class8_1.method_7(), method_2() ? method_8() : class8_1.method_8());
		}
		return this;
	}
}
