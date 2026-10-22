using System.Globalization;

internal static class Class346
{
	internal static string smethod_0(float float_0, float float_1, float float_2, bool bool_0)
	{
		return "{\"cmd\":\"move\",\"x\":" + smethod_1(float_0) + ",\"y\":" + smethod_1(float_1) + ",\"z\":" + smethod_1(float_2) + ",\"flag\":" + (bool_0 ? "true" : "false") + "}";
	}

	private static string smethod_1(float float_0)
	{
		return float_0.ToString("0.####", CultureInfo.InvariantCulture);
	}
}
