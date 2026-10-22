using System.Globalization;

internal static class Class178
{
	internal static string smethod_0(int int_0, int int_1)
	{
		return "{\"cmd\":\"cam\",\"on\":true,\"ceiling\":" + smethod_4(int_0) + ",\"topRadius\":" + smethod_4(int_1) + "}";
	}

	internal static string smethod_1()
	{
		return "{\"cmd\":\"cam\",\"on\":false}";
	}

	internal static string smethod_2(float float_0, uint uint_0)
	{
		return "{\"cmd\":\"cam_zoom\",\"zoom\":" + smethod_6(float_0) + ",\"req\":" + smethod_5(uint_0) + "}";
	}

	internal static string smethod_3()
	{
		return "{\"cmd\":\"cam_zoom_status\"}";
	}

	private static string smethod_4(int int_0)
	{
		return int_0.ToString(CultureInfo.InvariantCulture);
	}

	private static string smethod_5(uint uint_0)
	{
		return uint_0.ToString(CultureInfo.InvariantCulture);
	}

	private static string smethod_6(float float_0)
	{
		return float_0.ToString("R", CultureInfo.InvariantCulture);
	}
}
