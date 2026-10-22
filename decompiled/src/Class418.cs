using System.Globalization;

internal static class Class418
{
	internal static string smethod_0(uint uint_0)
	{
		return "{\"cmd\":\"party_select\",\"id\":" + uint_0.ToString(CultureInfo.InvariantCulture) + ",\"self\":false}";
	}

	internal static string smethod_1()
	{
		return "{\"cmd\":\"party_select\",\"self\":true}";
	}

	internal static string smethod_2()
	{
		return "{\"cmd\":\"party_status\"}";
	}
}
