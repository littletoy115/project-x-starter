using System.Globalization;

internal static class Class397
{
	internal static string smethod_0(byte byte_0, uint uint_0, uint uint_1)
	{
		return "{\"cmd\":\"pick\",\"type\":" + smethod_2(byte_0) + ",\"id\":" + smethod_3(uint_0) + ",\"req\":" + smethod_3(uint_1) + "}";
	}

	internal static string smethod_1()
	{
		return "{\"cmd\":\"pick_status\"}";
	}

	private static string smethod_2(byte byte_0)
	{
		return byte_0.ToString(CultureInfo.InvariantCulture);
	}

	private static string smethod_3(uint uint_0)
	{
		return uint_0.ToString(CultureInfo.InvariantCulture);
	}
}
