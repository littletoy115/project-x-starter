using System;

internal sealed class Class115
{
	private static readonly TimeSpan timeSpan_0 = TimeSpan.FromMilliseconds(750.0);

	private long long_0;

	private float float_0;

	private float float_1;

	private DateTime dateTime_0;

	private int int_0;

	private int int_1;

	private bool bool_0;

	private bool bool_1;

	public int method_0()
	{
		return int_0;
	}

	private void method_1(int int_2)
	{
		int_0 = int_2;
	}

	public int method_2()
	{
		return int_1;
	}

	private void method_3(int int_2)
	{
		int_1 = int_2;
	}

	public bool method_4()
	{
		return bool_0;
	}

	private void method_5(bool bool_2)
	{
		bool_0 = bool_2;
	}

	public bool method_6()
	{
		return bool_1;
	}

	private void method_7(bool bool_2)
	{
		bool_1 = bool_2;
	}

	public bool method_8()
	{
		if (!method_4() && !method_6())
		{
			return method_0() >= 10;
		}
		return false;
	}

	public bool method_9()
	{
		if (method_6() && !method_4())
		{
			return method_2() >= 5;
		}
		return false;
	}

	public void method_10(long long_1, float float_2, float float_3, DateTime dateTime_1)
	{
		int num = method_0();
		method_1(num + 1);
		method_13(long_1, float_2, float_3, dateTime_1);
	}

	public void method_11()
	{
		method_7(bool_2: true);
	}

	public void method_12(long long_1, float float_2, float float_3, DateTime dateTime_1)
	{
		int num = method_2();
		method_3(num + 1);
		method_13(long_1, float_2, float_3, dateTime_1);
	}

	private void method_13(long long_1, float float_2, float float_3, DateTime dateTime_1)
	{
		long_0 = long_1;
		float_0 = float_2;
		float_1 = float_3;
		dateTime_0 = dateTime_1;
		method_5(bool_2: true);
	}

	public bool method_14(long long_1, float float_2, float float_3, DateTime dateTime_1)
	{
		if (method_4() && long_1 > long_0)
		{
			if (Class440.smethod_19(float_2, float_3, float_0, float_1) >= 0.5f)
			{
				method_15();
				return true;
			}
			if (dateTime_1 - dateTime_0 >= timeSpan_0)
			{
				method_5(bool_2: false);
			}
			return false;
		}
		return false;
	}

	public void method_15()
	{
		method_1(0);
		method_3(0);
		method_5(bool_2: false);
		method_7(bool_2: false);
		long_0 = 0L;
	}
}
