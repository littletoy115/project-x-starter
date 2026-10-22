using System;
using System.IO;

internal static class Class18
{
	internal static string smethod_0(string string_0)
	{
		return smethod_4(string_0, "klx.dll");
	}

	internal static string smethod_1(string string_0)
	{
		return smethod_4(string_0, "klxsvc");
	}

	internal static string smethod_2()
	{
		return smethod_0(AppDomain.CurrentDomain.BaseDirectory);
	}

	internal static string smethod_3()
	{
		return smethod_1(AppDomain.CurrentDomain.BaseDirectory);
	}

	private static string smethod_4(string string_0, string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			throw new ArgumentException("A product base directory is required.", "\u000e");
		}
		if (!Path.IsPathRooted(string_0))
		{
			throw new ArgumentException("The product base directory must be absolute.", "\u000e");
		}
		return Path.GetFullPath(Path.Combine(string_0, "config", string_1));
	}
}
