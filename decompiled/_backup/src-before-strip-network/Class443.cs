using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal static class Class443
{
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool WritePrivateProfileStringW(string string_0, string string_1, string string_2, string string_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int GetPrivateProfileStringW(string string_0, string string_1, string string_2, StringBuilder stringBuilder_0, int int_0, string string_3);

	internal static string smethod_0(string string_0, string string_1)
	{
		return Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string_1 ?? "config"), string_0);
	}

	internal static bool smethod_1(string string_0, string string_1, string string_2, string string_3, string string_4)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1) && !string.IsNullOrEmpty(string_2))
		{
			string text = smethod_0(string_0, string_4);
			try
			{
				Directory.CreateDirectory(Path.GetDirectoryName(text));
			}
			catch (Exception)
			{
				return false;
			}
			return WritePrivateProfileStringW(string_1, string_2, string_3 ?? string.Empty, text);
		}
		return false;
	}

	internal static string smethod_2(string string_0, string string_1, string string_2, string string_3, string string_4)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1) && !string.IsNullOrEmpty(string_2))
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			GetPrivateProfileStringW(string_1, string_2, string_3 ?? string.Empty, stringBuilder, stringBuilder.Capacity, smethod_0(string_0, string_4));
			return stringBuilder.ToString();
		}
		return string_3;
	}
}
