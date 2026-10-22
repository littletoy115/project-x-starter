using System.Globalization;

internal static class Class15
{
	internal static string smethod_0(uint uint_0)
	{
		return "{\"cmd\":\"attack\",\"id\":" + smethod_4(uint_0) + "}";
	}

	internal static string smethod_1(uint uint_0)
	{
		return "{\"cmd\":\"attack\",\"id\":" + smethod_4(uint_0) + ",\"press\":false}";
	}

	internal static string smethod_2()
	{
		return "{\"cmd\":\"attack_stop\"}";
	}

	internal static string smethod_3()
	{
		return "{\"cmd\":\"attack_status\"}";
	}

	private static string smethod_4(uint uint_0)
	{
		return uint_0.ToString(CultureInfo.InvariantCulture);
	}
}
