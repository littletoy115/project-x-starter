using System;
using Microsoft.Win32;

internal static class Class0
{
	public static string smethod_0()
	{
		return "Eazfuscator.NET";
	}

	public static bool smethod_1()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Platform == PlatformID.Win32NT && oSVersion.Version >= new Version(6, 0);
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_2()
	{
		try
		{
			PlatformID platform = Environment.OSVersion.Platform;
			return (uint)platform <= 2u;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_3(string string_0)
	{
		if (smethod_4() == null)
		{
			return smethod_5() == string_0;
		}
		return true;
	}

	private static string smethod_4()
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Gapotchenko\\Eazfuscator.NET") ?? Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Gapotchenko\\Eazfuscator.NET");
			return registryKey?.GetValue("InstallDir") as string;
		}
		catch
		{
			return null;
		}
	}

	private static string smethod_5()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Gapotchenko\\Eazfuscator.NET\\Deployment");
			return registryKey?.GetValue("ID") as string;
		}
		catch
		{
			return null;
		}
	}
}
