using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

public sealed class GClass18
{
	private sealed class Class416
	{
		public List<string> list_0;

		internal int method_0(IGrouping<string, string> igrouping_0)
		{
			return list_0.IndexOf(igrouping_0.Key);
		}
	}

	[Serializable]
	private sealed class Class417
	{
		public static readonly Class417 class417_0 = new Class417();

		public static Func<string, string> func_0;

		public static Func<IGrouping<string, string>, int> func_1;

		internal string method_0(string string_0)
		{
			return string_0;
		}

		internal int method_1(IGrouping<string, string> igrouping_0)
		{
			return igrouping_0.Count();
		}
	}

	private readonly string string_0;

	private readonly byte[] byte_0;

	private readonly bool bool_0;

	private static readonly string[] string_1 = new string[3]
	{
		Class185.smethod_0(-1141298106),
		Class185.smethod_0(-1141298138),
		Class185.smethod_0(-1141298170)
	};

	private static readonly string[] string_2 = new string[3]
	{
		Class185.smethod_0(-1141297178),
		Class185.smethod_0(-1141297238),
		Class185.smethod_0(-1141297295)
	};

	public GClass18(string string_3, bool bool_1 = false)
	{
		string_0 = string_3;
		byte_0 = Encoding.UTF8.GetBytes(Class185.smethod_0(-1141298094) + Environment.MachineName);
		bool_0 = bool_1;
	}

	public void method_0(string string_3, string string_4)
	{
		if (string.IsNullOrEmpty(string_3) || string.IsNullOrEmpty(string_4))
		{
			return;
		}
		try
		{
			string string_5 = Convert.ToBase64String(method_11(string_4));
			method_2(string_3, string_5);
			method_4(string_3, string_5);
			if (bool_0)
			{
				method_8(string_3, string_5);
			}
		}
		catch
		{
		}
	}

	public string method_1(string string_3)
	{
		if (string.IsNullOrEmpty(string_3))
		{
			return null;
		}
		try
		{
			Class416 @class = new Class416();
			@class.list_0 = new List<string>();
			string text = method_3(string_3);
			if (!string.IsNullOrEmpty(text))
			{
				@class.list_0.Add(text);
			}
			string text2 = method_6(string_3);
			if (!string.IsNullOrEmpty(text2))
			{
				@class.list_0.Add(text2);
			}
			if (bool_0)
			{
				string text3 = method_9(string_3);
				if (!string.IsNullOrEmpty(text3))
				{
					@class.list_0.Add(text3);
				}
			}
			if (@class.list_0.Count == 0)
			{
				return null;
			}
			if (@class.list_0.Count > 1)
			{
				string key = @class.list_0.GroupBy(Class417.class417_0.method_0).OrderByDescending(Class417.class417_0.method_1).ThenBy(@class.method_0)
					.First()
					.Key;
				@class.list_0 = new List<string> { key };
			}
			byte[] byte_ = Convert.FromBase64String(@class.list_0[0]);
			return method_12(byte_);
		}
		catch
		{
			return null;
		}
	}

	private void method_2(string string_3, string string_4)
	{
		try
		{
			string path = method_15(string_3 + Class185.smethod_0(-1141297350)).Substring(0, 10) + Class185.smethod_0(-1141297354);
			File.WriteAllText(Path.Combine(string_0, path), string_4);
		}
		catch
		{
		}
	}

	private string method_3(string string_3)
	{
		try
		{
			string path = method_15(string_3 + Class185.smethod_0(-1141297350)).Substring(0, 10) + Class185.smethod_0(-1141297354);
			string path2 = Path.Combine(string_0, path);
			if (File.Exists(path2))
			{
				return File.ReadAllText(path2);
			}
		}
		catch
		{
		}
		return null;
	}

	private void method_4(string string_3, string string_4)
	{
		method_5(string_3, string_4, string_1);
	}

	private void method_5(string string_3, string string_4, string[] string_5)
	{
		try
		{
			string name = Class185.smethod_0(-1141297373) + method_15(string_3).Substring(0, 5);
			string name2 = Class185.smethod_0(-1141297391) + method_15(string_3 + Class185.smethod_0(-1141297402)).Substring(0, 5);
			string name3 = Class185.smethod_0(-1141297410) + method_15(string_3 + Class185.smethod_0(-1141297437)).Substring(0, 5);
			int num = string_4.Length / 3;
			string value = string_4.Substring(0, num);
			string value2 = string_4.Substring(num, num);
			string value3 = string_4.Substring(num * 2);
			using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(string_5[0]))
			{
				registryKey?.SetValue(name, value);
			}
			using (RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(string_5[1]))
			{
				registryKey2?.SetValue(name2, value2);
			}
			using RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey(string_5[2]);
			registryKey3?.SetValue(name3, value3);
		}
		catch
		{
		}
	}

	private string method_6(string string_3)
	{
		string text = method_7(string_3, string_1);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return method_7(string_3, string_2);
	}

	private string method_7(string string_3, string[] string_4)
	{
		try
		{
			string name = Class185.smethod_0(-1141297373) + method_15(string_3).Substring(0, 5);
			string name2 = Class185.smethod_0(-1141297391) + method_15(string_3 + Class185.smethod_0(-1141297402)).Substring(0, 5);
			string name3 = Class185.smethod_0(-1141297410) + method_15(string_3 + Class185.smethod_0(-1141297437)).Substring(0, 5);
			string text = null;
			string text2 = null;
			string text3 = null;
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string_4[0]))
			{
				if (registryKey != null)
				{
					text = registryKey.GetValue(name) as string;
				}
			}
			using (RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(string_4[1]))
			{
				if (registryKey2 != null)
				{
					text2 = registryKey2.GetValue(name2) as string;
				}
			}
			using (RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey(string_4[2]))
			{
				if (registryKey3 != null)
				{
					text3 = registryKey3.GetValue(name3) as string;
				}
			}
			if (text != null && text2 != null && text3 != null)
			{
				return text + text2 + text3;
			}
		}
		catch
		{
		}
		return null;
	}

	private void method_8(string string_3, string string_4)
	{
		try
		{
			if (!method_10(string_0))
			{
				return;
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string text = Path.Combine(folderPath, Class185.smethod_0(-1141297445));
			if (!File.Exists(text))
			{
				string[] files = Directory.GetFiles(folderPath, Class185.smethod_0(-1141297463), SearchOption.TopDirectoryOnly);
				if (files.Length != 0)
				{
					text = files[0];
				}
				else
				{
					text = Path.Combine(folderPath, Class185.smethod_0(-1141297467));
					File.WriteAllText(text, Class185.smethod_0(-1141297484));
				}
			}
			string text2 = Class185.smethod_0(-1141297554) + method_15(string_3).Substring(0, 8);
			FileStream fileStream = new FileStream(text + Class185.smethod_0(-1141297577) + text2, FileMode.Create, FileAccess.Write);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream);
				try
				{
					streamWriter.Write(string_4);
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
		}
		catch
		{
		}
	}

	private string method_9(string string_3)
	{
		try
		{
			if (!method_10(string_0))
			{
				return null;
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string text = Path.Combine(folderPath, Class185.smethod_0(-1141297445));
			if (!File.Exists(text))
			{
				string text2 = Path.Combine(folderPath, Class185.smethod_0(-1141297467));
				if (File.Exists(text2))
				{
					text = text2;
				}
				else
				{
					string[] files = Directory.GetFiles(folderPath, Class185.smethod_0(-1141297463), SearchOption.TopDirectoryOnly);
					if (files.Length == 0)
					{
						return null;
					}
					text = files[0];
				}
			}
			string text3 = Class185.smethod_0(-1141297554) + method_15(string_3).Substring(0, 8);
			FileStream fileStream = new FileStream(text + Class185.smethod_0(-1141297577) + text3, FileMode.Open, FileAccess.Read);
			try
			{
				StreamReader streamReader = new StreamReader(fileStream);
				try
				{
					return streamReader.ReadToEnd();
				}
				finally
				{
					((IDisposable)streamReader).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
		}
		catch
		{
			return null;
		}
	}

	private bool method_10(string string_3)
	{
		try
		{
			return new DriveInfo(Path.GetPathRoot(string_3)).DriveFormat.Equals(Class185.smethod_0(-1141297585), StringComparison.OrdinalIgnoreCase);
		}
		catch
		{
			return false;
		}
	}

	private byte[] method_11(string string_3)
	{
		try
		{
			return ProtectedData.Protect(Encoding.UTF8.GetBytes(string_3), byte_0, DataProtectionScope.CurrentUser);
		}
		catch
		{
			return Encoding.UTF8.GetBytes(method_13(string_3));
		}
	}

	private string method_12(byte[] byte_1)
	{
		try
		{
			byte[] bytes = ProtectedData.Unprotect(byte_1, byte_0, DataProtectionScope.CurrentUser);
			return Encoding.UTF8.GetString(bytes);
		}
		catch
		{
		}
		try
		{
			byte[] bytes2 = ProtectedData.Unprotect(byte_1, byte_0, DataProtectionScope.LocalMachine);
			return Encoding.UTF8.GetString(bytes2);
		}
		catch
		{
		}
		return method_14(Encoding.UTF8.GetString(byte_1));
	}

	private string method_13(string string_3)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_3);
		for (int i = 0; i < bytes.Length; i++)
		{
			bytes[i] ^= byte_0[i % byte_0.Length];
		}
		return Convert.ToBase64String(bytes);
	}

	private string method_14(string string_3)
	{
		byte[] array = Convert.FromBase64String(string_3);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] ^= byte_0[i % byte_0.Length];
		}
		return Encoding.UTF8.GetString(array);
	}

	private string method_15(string string_3)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.UTF8.GetBytes(string_3);
		return BitConverter.ToString(mD.ComputeHash(bytes)).Replace(Class185.smethod_0(-1141293701), string.Empty).ToLower();
	}
}
