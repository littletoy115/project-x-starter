using System;
using Microsoft.Win32;

internal static class Class0
{
	public static string smethod_0()
	{
		return Class185.smethod_0(-1141295935);
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
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class185.smethod_0(-1141295957)) ?? Registry.LocalMachine.OpenSubKey(Class185.smethod_0(-1141296000));
			return registryKey?.GetValue(Class185.smethod_0(-1141296055)) as string;
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
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class185.smethod_0(-1141296072));
			return registryKey?.GetValue(Class185.smethod_0(-1141296126)) as string;
		}
		catch
		{
			return null;
		}
	}
}
