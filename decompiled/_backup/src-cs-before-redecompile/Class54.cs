using System.Globalization;

internal static class Class54
{
	internal static string smethod_0(string string_0, int int_0)
	{
		return "{\"cmd\":\"sub\",\"tier\":\"" + string_0 + "\",\"hz\":" + int_0.ToString(CultureInfo.InvariantCulture) + "}";
	}

	internal static string smethod_1(string string_0)
	{
		return "{\"cmd\":\"unsub\",\"tier\":\"" + string_0 + "\"}";
	}

	internal static string smethod_2(string string_0)
	{
		return "{\"cmd\":\"ack\",\"tier\":\"" + string_0 + "\"}";
	}

	internal static string smethod_3(string string_0)
	{
		if (string_0 == "snap")
		{
			return "t1";
		}
		if (string_0 == "census_raw")
		{
			return "t2";
		}
		return null;
	}
}
