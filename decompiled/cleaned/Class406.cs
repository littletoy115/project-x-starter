using System;

internal static class Class406
{
	public static float smethod_0(Class83 class83_0, float float_0, float float_1, float float_2)
	{
		return smethod_1(class83_0.float_0, class83_0.float_1, class83_0.float_2, float_0, float_1, float_2);
	}

	public static float smethod_1(float float_0, float float_1, float float_2, float float_3, float float_4, float float_5)
	{
		float num = float_3 - float_0;
		float num2 = float_4 - float_1;
		float num3 = float_5 - float_2;
		return (float)Math.Sqrt(num * num + num2 * num2 + num3 * num3);
	}

	public static bool smethod_2(GForm0 gform0_0, float float_0, float float_1, float float_2, float float_3)
	{
		Class83 @class = gform0_0?.method_5().method_0();
		if (@class != null && !(float_3 < 0f) && smethod_4(float_3) && smethod_4(@class.float_0) && smethod_4(@class.float_1) && smethod_4(@class.float_2) && smethod_4(float_0) && smethod_4(float_1) && smethod_4(float_2))
		{
			return smethod_0(@class, float_0, float_1, float_2) <= float_3;
		}
		return false;
	}

	public static bool smethod_3(float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6)
	{
		float num = float_0 - float_3;
		float num2 = float_1 - float_4;
		float num3 = float_2 - float_5;
		return (float)Math.Sqrt(num * num + num2 * num2 + num3 * num3) <= float_6;
	}

	private static bool smethod_4(float float_0)
	{
		if (!float.IsNaN(float_0))
		{
			return !float.IsInfinity(float_0);
		}
		return false;
	}
}
