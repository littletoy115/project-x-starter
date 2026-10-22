using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal static class Class436
{
	private sealed class Class437
	{
		public string string_0;

		internal bool method_0(string string_1)
		{
			return string.Equals(string_1, string_0, StringComparison.OrdinalIgnoreCase);
		}
	}

	internal static readonly string[] string_0 = new string[3]
	{
		Class185.smethod_0(-1141240218),
		Class185.smethod_0(-1141353537),
		Class185.smethod_0(-1141240235)
	};

	private static string smethod_0()
	{
		return Class135.smethod_4() + Class185.smethod_0(-1141265149);
	}

	internal static bool smethod_1(string string_1, out List<string> list_0)
	{
		list_0 = new List<string>();
		if (!string.IsNullOrWhiteSpace(string_1) && Path.IsPathRooted(string_1))
		{
			string fullPath = Path.GetFullPath(string_1);
			if (!Directory.Exists(fullPath))
			{
				list_0.Add(Class185.smethod_0(-1141190785) + fullPath);
				return false;
			}
			smethod_4(fullPath, list_0);
			smethod_6(fullPath, list_0);
			return list_0.Count == 0;
		}
		list_0.Add(Class185.smethod_0(-1141190730));
		return false;
	}

	internal static bool smethod_2(string string_1)
	{
		if (!string.IsNullOrWhiteSpace(string_1) && File.Exists(string_1))
		{
			try
			{
				byte[] array = new byte[20];
				using (FileStream fileStream = File.OpenRead(string_1))
				{
					if (fileStream.Read(array, 0, array.Length) != array.Length)
					{
						return false;
					}
				}
				return array[0] == 127 && array[1] == 69 && array[2] == 76 && array[3] == 70 && array[4] == 2 && array[5] == 1 && array[18] == 62 && array[19] == 0;
			}
			catch (IOException)
			{
				return false;
			}
			catch (UnauthorizedAccessException)
			{
				return false;
			}
		}
		return false;
	}

	internal static int smethod_3()
	{
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		smethod_1(baseDirectory, out var list_);
		if (IntPtr.Size != 8)
		{
			list_.Add(smethod_0() + Class185.smethod_0(-1141190825));
		}
		string text = Class18.smethod_1(baseDirectory);
		if (File.Exists(text) && !smethod_2(text))
		{
			list_.Add(Class185.smethod_0(-1141190870));
		}
		if (list_.Count == 0)
		{
			if (!Class384.smethod_0(out var string_))
			{
				list_.Add(string_);
			}
			else
			{
				try
				{
					if (string.IsNullOrWhiteSpace(Class63.smethod_1(Class63.klx_frida_version())))
					{
						list_.Add(Class185.smethod_0(-1141190935));
					}
				}
				catch (Exception ex)
				{
					list_.Add(Class185.smethod_0(-1141190985) + ex.GetType().Name + Class185.smethod_0(-1141301932) + ex.Message);
				}
			}
		}
		if (list_.Count == 0)
		{
			Console.WriteLine(Class185.smethod_0(-1141191041));
			return 0;
		}
		foreach (string item in list_)
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141191067) + item);
		}
		return 1;
	}

	private static void smethod_4(string string_1, List<string> list_0)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		foreach (string item in Directory.EnumerateFileSystemEntries(string_1))
		{
			string fileName = Path.GetFileName(item);
			if (Directory.Exists(item))
			{
				if (string.Equals(fileName, Class185.smethod_0(-1141307926), StringComparison.OrdinalIgnoreCase))
				{
					flag2 = true;
				}
				else if (string.Equals(fileName, Class185.smethod_0(-1141354158), StringComparison.OrdinalIgnoreCase))
				{
					flag3 = true;
					smethod_5(item, list_0);
				}
				else
				{
					list_0.Add(Class185.smethod_0(-1141191090) + fileName);
				}
			}
			else if (string.Equals(fileName, smethod_0(), StringComparison.OrdinalIgnoreCase))
			{
				flag = true;
			}
			else
			{
				list_0.Add(Class185.smethod_0(-1141191135) + fileName);
			}
		}
		if (!flag)
		{
			list_0.Add(Class185.smethod_0(-1141191167) + smethod_0());
		}
		if (!flag2)
		{
			list_0.Add(Class185.smethod_0(-1141192218));
		}
		if (!flag3)
		{
			list_0.Add(Class185.smethod_0(-1141192258));
		}
	}

	private static void smethod_5(string string_1, List<string> list_0)
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		foreach (string item in Directory.EnumerateFileSystemEntries(string_1))
		{
			Class437 @class = new Class437();
			@class.string_0 = Path.GetFileName(item);
			if (Directory.Exists(item))
			{
				list_0.Add(Class185.smethod_0(-1141192298) + @class.string_0);
			}
			else if (string_0.Any(@class.method_0))
			{
				hashSet.Add(@class.string_0.ToLowerInvariant());
			}
			else
			{
				list_0.Add(Class185.smethod_0(-1141192342) + @class.string_0);
			}
		}
		string[] array = string_0;
		foreach (string text in array)
		{
			if (!hashSet.Contains(text.ToLowerInvariant()))
			{
				list_0.Add(Class185.smethod_0(-1141192373) + text);
			}
		}
	}

	private static void smethod_6(string string_1, List<string> list_0)
	{
		string path = Path.Combine(string_1, Class185.smethod_0(-1141307926));
		if (!Directory.Exists(path))
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		foreach (string item in Directory.EnumerateFileSystemEntries(path))
		{
			string fileName = Path.GetFileName(item);
			if (Directory.Exists(item))
			{
				list_0.Add(Class185.smethod_0(-1141192393) + fileName);
			}
			else if (string.Equals(fileName, Class185.smethod_0(-1141353289), StringComparison.OrdinalIgnoreCase))
			{
				flag = true;
			}
			else if (string.Equals(fileName, Class185.smethod_0(-1141353344), StringComparison.OrdinalIgnoreCase))
			{
				flag2 = true;
			}
			else
			{
				list_0.Add(Class185.smethod_0(-1141192437) + fileName);
			}
		}
		if (!flag)
		{
			list_0.Add(Class185.smethod_0(-1141192460));
		}
		if (!flag2)
		{
			list_0.Add(Class185.smethod_0(-1141192511));
		}
	}
}
