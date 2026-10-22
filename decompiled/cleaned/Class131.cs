using System;

internal static class Class131
{
	internal static string smethod_0()
	{
		string text = Class135.smethod_9();
		if (Uri.TryCreate(text, UriKind.Absolute, out var result) && !(result.Scheme != Uri.UriSchemeHttps) && !(result.Host != Class185.smethod_0(-1141242308)) && result.AbsolutePath.StartsWith(Class185.smethod_0(-1141242334), StringComparison.Ordinal))
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
		return Class185.smethod_0(-1141180765);
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
		return Class185.smethod_0(-1141354158);
	}

	internal static bool smethod_9()
	{
		return true;
	}
}
