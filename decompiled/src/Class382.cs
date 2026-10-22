using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal static class Class382
{
	[Serializable]
	private sealed class Class383
	{
		public static readonly Class383 class383_0 = new Class383();

		public static Func<string, bool> func_0;

		internal bool method_0(string string_0)
		{
			if (string_0.Length != 0 && !(string_0 == ".") && !(string_0 == "..") && !string_0.EndsWith(".", StringComparison.Ordinal) && !string_0.EndsWith(" ", StringComparison.Ordinal) && !smethod_4(string_0) && !string_0.Equals(".git", StringComparison.OrdinalIgnoreCase) && !string_0.Equals(".superpowers", StringComparison.OrdinalIgnoreCase))
			{
				return string_0.Equals("ReleaseStudio", StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}
	}

	private static readonly HashSet<string> hashSet_0 = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { ".ini", ".json", ".sqlite", ".db" };

	internal static void smethod_0(string string_0)
	{
		if (!string.IsNullOrWhiteSpace(string_0) && string_0.Length <= 512 && string_0.IndexOf('\\') < 0 && !string_0.StartsWith("/", StringComparison.Ordinal) && !Path.IsPathRooted(string_0) && string_0.IndexOf(':') < 0 && string_0.IndexOfAny(new char[6] { '"', '*', '?', '<', '>', '|' }) < 0 && !string_0.Any(char.IsControl))
		{
			string[] array = string_0.Split('/');
			if (array.Any(Class383.class383_0.method_0))
			{
				throw new InvalidDataException("Catalog destination path is unsafe.");
			}
			string text = array[array.Length - 1];
			if (hashSet_0.Contains(Path.GetExtension(text)) || text.Equals("github-token.local.txt", StringComparison.OrdinalIgnoreCase) || text.Equals("user.config", StringComparison.OrdinalIgnoreCase) || text.Equals("settings.config", StringComparison.OrdinalIgnoreCase) || text.Equals("settings.xml", StringComparison.OrdinalIgnoreCase))
			{
				throw new InvalidDataException("Catalog targets protected local settings or data.");
			}
			return;
		}
		throw new InvalidDataException("Catalog destination path is invalid.");
	}

	internal static string smethod_1(string string_0)
	{
		if (!string.IsNullOrWhiteSpace(string_0) && smethod_5(string_0))
		{
			string text = Path.GetFullPath(string_0).TrimEnd('\\', '/');
			if (text.Length == 2 && text[1] == ':')
			{
				text += "\\";
			}
			if (!Directory.Exists(text))
			{
				throw new DirectoryNotFoundException("Install root does not exist.");
			}
			smethod_3(text);
			return text;
		}
		throw new InvalidDataException("Install root must be fully qualified.");
	}

	internal static string smethod_2(string string_0, string string_1)
	{
		smethod_0(string_1);
		string fullPath = Path.GetFullPath(Path.Combine(string_0, string_1.Replace('/', '\\')));
		string value = string_0.TrimEnd('\\') + "\\";
		if (!fullPath.StartsWith(value, StringComparison.OrdinalIgnoreCase))
		{
			throw new InvalidDataException("Catalog destination escapes the install root.");
		}
		string text = string_0;
		string[] array = string_1.Split('/');
		for (int i = 0; i < array.Length; i++)
		{
			text = Path.Combine(text, array[i]);
			if (!File.Exists(text) && !Directory.Exists(text))
			{
				break;
			}
			FileAttributes attributes = File.GetAttributes(text);
			if ((attributes & FileAttributes.ReparsePoint) == 0)
			{
				bool flag = (attributes & FileAttributes.Directory) != 0;
				if ((i == array.Length - 1 && flag) || (i != array.Length - 1 && !flag))
				{
					throw new InvalidDataException("Catalog destination hierarchy conflicts with the installed tree.");
				}
				continue;
			}
			throw new InvalidDataException("Catalog destination traverses a reparse point.");
		}
		return fullPath;
	}

	private static void smethod_3(string string_0)
	{
		string text = Path.GetPathRoot(string_0);
		string[] array = string_0.Substring(text.Length).Split(new char[2] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries);
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				string path = array[num];
				text = Path.Combine(text, path);
				if ((File.GetAttributes(text) & FileAttributes.ReparsePoint) != 0)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		throw new InvalidDataException("Install root traverses a reparse point.");
	}

	private static bool smethod_4(string string_0)
	{
		string text = string_0.Split('.')[0].ToUpperInvariant();
		switch (text)
		{
		default:
			if (text.Length == 4 && (text.StartsWith("COM", StringComparison.Ordinal) || text.StartsWith("LPT", StringComparison.Ordinal)) && ((text[3] >= '1' && text[3] <= '9') || text[3] == '¹' || text[3] == '²' || text[3] == '³'))
			{
				return true;
			}
			return false;
		case "CON":
		case "PRN":
		case "AUX":
		case "NUL":
		case "CONIN$":
		case "CONOUT$":
			return true;
		}
	}

	private static bool smethod_5(string string_0)
	{
		if (string_0.Length >= 3 && char.IsLetter(string_0[0]) && string_0[1] == ':' && (string_0[2] == '\\' || string_0[2] == '/'))
		{
			return true;
		}
		if (string_0.StartsWith("\\\\", StringComparison.Ordinal) && !string_0.StartsWith("\\\\?\\", StringComparison.Ordinal) && !string_0.StartsWith("\\\\.\\", StringComparison.Ordinal))
		{
			return string_0.Substring(2).Split(new char[2] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries).Length >= 2;
		}
		return false;
	}
}
