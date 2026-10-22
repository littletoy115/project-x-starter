using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

internal static class Class176
{
	internal static string smethod_0(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return Class185.smethod_0(-1141032163);
		}
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		StringBuilder stringBuilder = new StringBuilder(string_0.Length);
		foreach (char c in string_0)
		{
			if (Array.IndexOf(invalidFileNameChars, c) < 0 && c != '%')
			{
				stringBuilder.Append(c);
				continue;
			}
			StringBuilder stringBuilder2 = stringBuilder.Append('%');
			int num = c;
			stringBuilder2.Append(num.ToString(Class185.smethod_0(-1141032177)));
		}
		string text = stringBuilder.ToString().Trim();
		if (text.Length != 0)
		{
			return text;
		}
		return Class185.smethod_0(-1141032163);
	}

	internal static string smethod_1(string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141032186));
		}
		return smethod_0(string_0) + Class185.smethod_0(-1141128924) + string_1;
	}

	internal static string smethod_2(string string_0, string string_1)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			string text = Class185.smethod_0(-1141128924) + string_1;
			if (string_0.Length <= text.Length)
			{
				return string.Empty;
			}
			if (!string_0.EndsWith(text, StringComparison.OrdinalIgnoreCase))
			{
				return string.Empty;
			}
			return string_0.Substring(0, string_0.Length - text.Length);
		}
		return string.Empty;
	}

	internal static List<string> smethod_3(string string_0, string string_1, string string_2)
	{
		List<string> list = new List<string>();
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			string[] files;
			try
			{
				files = Directory.GetFiles(string_0, Class185.smethod_0(-1141032205) + string_1);
			}
			catch (IOException)
			{
				return list;
			}
			catch (UnauthorizedAccessException)
			{
				return list;
			}
			for (int i = 0; i < files.Length; i++)
			{
				string text = smethod_2(Path.GetFileName(files[i]), string_1);
				if (text.Length != 0 && (string.IsNullOrEmpty(string_2) || !string.Equals(text, string_2, StringComparison.OrdinalIgnoreCase)) && !smethod_4(list, text))
				{
					list.Add(text);
				}
			}
			list.Sort(StringComparer.OrdinalIgnoreCase);
			return list;
		}
		return list;
	}

	private static bool smethod_4(List<string> list_0, string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (string.Equals(list_0[num], string_0, StringComparison.OrdinalIgnoreCase))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}
}
