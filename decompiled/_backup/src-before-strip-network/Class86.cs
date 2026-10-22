internal static class Class86
{
	public static bool smethod_0(bool bool_0, int int_0, int int_1)
	{
		if (bool_0)
		{
			return int_0 != int_1;
		}
		return true;
	}

	public static bool smethod_1(bool bool_0, int int_0, int int_1, float float_0, float float_1, float float_2, float float_3)
	{
		if (!bool_0)
		{
			return true;
		}
		if (int_0 != int_1)
		{
			return true;
		}
		float num = float_0 - float_2;
		float num2 = float_1 - float_3;
		return num * num + num2 * num2 >= 16f;
	}
}
