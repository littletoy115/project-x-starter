using System;

internal static class Class347
{
	internal static string smethod_0()
	{
		return "{\"cmd\":\"friends\"}";
	}

	internal static bool smethod_1(string string_0)
	{
		if (string_0 == null)
		{
			return false;
		}
		if (string.Equals(string_0, "ready", StringComparison.Ordinal))
		{
			return true;
		}
		if (string.Equals(string_0, "empty", StringComparison.Ordinal))
		{
			return true;
		}
		if (string.Equals(string_0, "refreshing", StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}

	internal static bool smethod_2(string string_0)
	{
		return string.Equals(string_0, "refreshing", StringComparison.Ordinal);
	}
}
