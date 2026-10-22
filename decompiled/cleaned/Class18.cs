using System;
using System.IO;

internal static class Class18
{
	internal static string smethod_0(string string_0)
	{
		return smethod_4(string_0, Class185.smethod_0(-1141353289));
	}

	internal static string smethod_1(string string_0)
	{
		return smethod_4(string_0, Class185.smethod_0(-1141353344));
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
			throw new ArgumentException(Class185.smethod_0(-1141192545), Class185.smethod_0(-1141192597));
		}
		if (!Path.IsPathRooted(string_0))
		{
			throw new ArgumentException(Class185.smethod_0(-1141192608), Class185.smethod_0(-1141192651));
		}
		return Path.GetFullPath(Path.Combine(string_0, Class185.smethod_0(-1141307926), string_1));
	}
}
