using System;

internal sealed class Class441
{
	private uint uint_0;

	private bool bool_0;

	private long long_0;

	private float float_0;

	private float float_1;

	private DateTime dateTime_0;

	internal bool method_0(Class31 class31_0, DateTime dateTime_1)
	{
		if (class31_0 == null)
		{
			method_1();
			return false;
		}
		if (class31_0.bool_1)
		{
			return class31_0.byte_0 == 1;
		}
		if (uint_0 == class31_0.uint_0 && bool_0 == class31_0.bool_0)
		{
			if (long_0 != class31_0.long_0)
			{
				float num = class31_0.float_0 - float_0;
				float num2 = class31_0.float_2 - float_1;
				if (num * num + num2 * num2 >= 0.25f)
				{
					dateTime_0 = dateTime_1;
				}
				long_0 = class31_0.long_0;
				float_0 = class31_0.float_0;
				float_1 = class31_0.float_2;
			}
			if (dateTime_0 != DateTime.MinValue)
			{
				return (dateTime_1 - dateTime_0).TotalMilliseconds <= (double)(class31_0.bool_0 ? 1500 : 500);
			}
			return false;
		}
		uint_0 = class31_0.uint_0;
		bool_0 = class31_0.bool_0;
		long_0 = class31_0.long_0;
		float_0 = class31_0.float_0;
		float_1 = class31_0.float_2;
		dateTime_0 = DateTime.MinValue;
		return false;
	}

	internal void method_1()
	{
		uint_0 = 0u;
		long_0 = 0L;
		dateTime_0 = DateTime.MinValue;
	}
}
