using System;

internal static class Class131
{
	internal static string smethod_0()
	{
		string text = Class135.smethod_9();
		if (Uri.TryCreate(text, UriKind.Absolute, out var result) && !(result.Scheme != Uri.UriSchemeHttps) && !(result.Host != "discord.com") && result.AbsolutePath.StartsWith("/api/webhooks/", StringComparison.Ordinal))
		{
			return text;
		}
		return null;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static bool smethod_2()
	{
		return false;
	}

	internal static string smethod_3()
	{
		return "klx.recognizer";
	}

	internal static double smethod_4()
	{
		return 90.0;
	}

	internal static double smethod_5()
	{
		return 10.0;
	}

	internal static double smethod_6()
	{
		return 10.0;
	}

	internal static double smethod_7()
	{
		return 15.0;
	}

	internal static string smethod_8()
	{
		return "OneOCR";
	}

	internal static bool smethod_9()
	{
		return true;
	}
}
