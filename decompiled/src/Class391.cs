using System.Globalization;

internal static class Class391
{
	internal static string smethod_0(int int_0)
	{
		return "{\"cmd\":\"slot\",\"use\":" + smethod_1(int_0) + "}";
	}

	private static string smethod_1(int int_0)
	{
		return int_0.ToString(CultureInfo.InvariantCulture);
	}
}
