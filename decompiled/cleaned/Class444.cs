using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

internal static class Class444
{
	private delegate bool Delegate17(IntPtr intptr_0, IntPtr intptr_1);

	private sealed class Class445
	{
		public List<Class34> list_0;

		internal bool method_0(IntPtr intptr_0, IntPtr intptr_1)
		{
			if (!IsWindowVisible(intptr_0))
			{
				return true;
			}
			StringBuilder stringBuilder = new StringBuilder(256);
			GetClassName(intptr_0, stringBuilder, stringBuilder.Capacity);
			if (stringBuilder.ToString() != Class185.smethod_0(-1141036463))
			{
				return true;
			}
			StringBuilder stringBuilder2 = new StringBuilder(512);
			GetWindowText(intptr_0, stringBuilder2, stringBuilder2.Capacity);
			GetWindowThreadProcessId(intptr_0, out var uint_);
			int num = smethod_1((int)uint_);
			if (num < 0)
			{
				return true;
			}
			list_0.Add(new Class34
			{
				intptr_0 = intptr_0,
				string_0 = stringBuilder2.ToString(),
				int_0 = (int)uint_,
				int_1 = num,
				string_1 = Class185.smethod_0(-1141303920) + (5554 + num * 2),
				int_2 = 27042 + num
			});
			return true;
		}
	}

	[DllImport("user32.dll")]
	private static extern bool EnumWindows(Delegate17 delegate17_0, IntPtr intptr_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	[DllImport("user32.dll")]
	private static extern uint GetWindowThreadProcessId(IntPtr intptr_0, out uint uint_0);

	[DllImport("user32.dll")]
	private static extern bool IsWindowVisible(IntPtr intptr_0);

	internal static List<Class34> smethod_0(string string_0)
	{
		Class445 @class = new Class445();
		@class.list_0 = new List<Class34>();
		EnumWindows(@class.method_0, IntPtr.Zero);
		if (!string.IsNullOrEmpty(string_0) && File.Exists(string_0))
		{
			string text = Class71.smethod_0(string_0, null, Class185.smethod_0(-1141036487), 8000);
			foreach (Class34 item in @class.list_0)
			{
				item.bool_0 = text.IndexOf(item.string_1, StringComparison.OrdinalIgnoreCase) >= 0;
			}
		}
		return @class.list_0;
	}

	private static int smethod_1(int int_0)
	{
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(Class185.smethod_0(-1141036501), Class185.smethod_0(-1141036518) + int_0);
			try
			{
				using ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
				foreach (ManagementObject item in managementObjectCollection)
				{
					string text = item[Class185.smethod_0(-1141041701)] as string;
					if (!string.IsNullOrEmpty(text))
					{
						Match match = Regex.Match(text, Class185.smethod_0(-1141041719), RegexOptions.IgnoreCase);
						if (match.Success)
						{
							return int.Parse(match.Groups[1].Value);
						}
						return 0;
					}
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch
		{
		}
		return -1;
	}

	internal static string smethod_2(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		string text = Path.Combine(string_0, Class185.smethod_0(-1141327908));
		if (!File.Exists(text))
		{
			return null;
		}
		return text;
	}
}
