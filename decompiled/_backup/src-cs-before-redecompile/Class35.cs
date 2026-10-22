using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

internal sealed class Class35
{
	private sealed class Class36
	{
		public string string_0;

		internal bool method_0(Class1 class1_0)
		{
			return class1_0.String_0 == string_0;
		}
	}

	[Serializable]
	private sealed class Class37
	{
		public static readonly Class37 class37_0 = new Class37();

		public static Func<char, bool> func_0;

		internal bool method_0(char char_0)
		{
			if (char_0 >= '0')
			{
				return char_0 > '9';
			}
			return true;
		}
	}

	private static readonly byte[] byte_0 = new byte[8] { 137, 80, 78, 71, 13, 10, 26, 10 };

	private readonly object object_0 = new object();

	private readonly string string_0;

	private readonly Dictionary<string, Class1> dictionary_0 = new Dictionary<string, Class1>(StringComparer.Ordinal);

	internal Class35(string string_1)
	{
		string_0 = Path.GetFullPath(string_1);
		string[] array = new string[4] { "pending", "verified", "rejected", "uploaded" };
		foreach (string path in array)
		{
			Directory.CreateDirectory(Path.Combine(string_0, path));
		}
		method_10();
	}

	internal bool method_0(string string_1, uint uint_0, int int_0, int int_1, int int_2, byte[] byte_1, long long_0, int int_3, string string_2)
	{
		if (!string.IsNullOrEmpty(string_1) && uint_0 != 0 && byte_1 != null && byte_1.Length >= byte_0.Length && byte_1.Length <= 8192 && int_1 > 0 && int_2 > 0)
		{
			int num = 0;
			while (true)
			{
				if (num < byte_0.Length)
				{
					if (byte_1[num] != byte_0[num])
					{
						break;
					}
					num++;
					continue;
				}
				string text = smethod_3(byte_1);
				lock (object_0)
				{
					if (!dictionary_0.TryGetValue(smethod_2(string_1, uint_0), out var value))
					{
						Class1 @class = new Class1
						{
							Int32_0 = 1,
							String_0 = Guid.NewGuid().ToString("N"),
							String_1 = string_1,
							String_2 = (string.IsNullOrWhiteSpace(string_2) ? null : string_2.Trim()),
							UInt32_0 = uint_0,
							Int32_2 = int_0,
							Int32_3 = int_1,
							Int32_4 = int_2,
							Int32_5 = int_2,
							Int64_0 = long_0,
							Int32_1 = int_3,
							String_3 = text,
							String_7 = "captured"
						};
						string text2 = Path.Combine(string_0, "pending", @class.String_0);
						Directory.CreateDirectory(text2);
						string text3 = Path.Combine(text2, "image.png");
						string text4 = text3 + ".tmp";
						try
						{
							File.WriteAllBytes(text4, byte_1);
							File.Move(text4, text3);
							smethod_4(text2, @class);
							dictionary_0.Add(smethod_2(string_1, uint_0), @class);
							return true;
						}
						finally
						{
							if (File.Exists(text4))
							{
								File.Delete(text4);
							}
						}
					}
					return value.String_3 == text;
				}
			}
			return false;
		}
		return false;
	}

	internal void method_1(string string_1, uint uint_0, string string_2, double double_0, string string_3, int int_0)
	{
		lock (object_0)
		{
			if (dictionary_0.TryGetValue(smethod_2(string_1, uint_0), out var value))
			{
				value.String_9 = (string.IsNullOrEmpty(string_2) ? null : string_2);
				value.Nullable_2 = double_0;
				value.String_10 = (string.IsNullOrEmpty(string_3) ? null : string_3);
				value.Nullable_3 = int_0;
				smethod_4(method_11(value), value);
			}
		}
	}

	internal void method_2(string string_1, uint uint_0, string string_2, double double_0)
	{
		lock (object_0)
		{
			if (dictionary_0.TryGetValue(smethod_2(string_1, uint_0), out var value))
			{
				value.String_11 = (string.IsNullOrEmpty(string_2) ? null : string_2);
				value.Nullable_4 = double_0;
				smethod_4(method_11(value), value);
			}
		}
	}

	internal void method_3(string string_1, uint uint_0, string string_2, long long_0)
	{
		if (string.IsNullOrEmpty(string_2) || string_2.Length > 8 || string_2.Any(Class37.class37_0.method_0))
		{
			return;
		}
		lock (object_0)
		{
			if (dictionary_0.TryGetValue(smethod_2(string_1, uint_0), out var value) && !(value.String_7 == "verified") && !(value.String_7 == "uploaded"))
			{
				value.String_4 = string_2;
				value.Nullable_0 = long_0;
				if (value.String_6 == "pass")
				{
					value.String_5 = string_2;
					value.String_7 = "verified";
					method_9(value, "verified");
				}
				else if (!smethod_0(value.String_7))
				{
					value.String_7 = "submitted";
					smethod_4(method_11(value), value);
				}
			}
		}
	}

	internal void method_4(string string_1, uint uint_0, int int_0, int int_1, long long_0)
	{
		lock (object_0)
		{
			if (!dictionary_0.TryGetValue(smethod_2(string_1, uint_0), out var value))
			{
				return;
			}
			if (smethod_0(value.String_7))
			{
				string text = Path.Combine(string_0, "pending", value.String_0);
				if (Directory.Exists(text))
				{
					if (smethod_1(value))
					{
						method_9(value, (value.String_7 == "verified") ? "verified" : "rejected");
					}
					else
					{
						smethod_4(text, value);
					}
				}
				return;
			}
			value.Int32_5 = int_1;
			value.Nullable_1 = long_0;
			switch (int_0)
			{
			case 0:
				value.String_6 = "pass";
				if (value.String_4 == null)
				{
					value.String_7 = "pass_without_observed_answer";
					smethod_4(method_11(value), value);
				}
				else
				{
					value.String_5 = value.String_4;
					value.String_7 = "verified";
					method_9(value, "verified");
				}
				break;
			case 1:
				value.String_6 = "wrong_retry";
				value.String_7 = "wrong_retry";
				smethod_4(method_11(value), value);
				break;
			case 2:
				value.String_6 = "failed";
				value.String_7 = "failed";
				method_9(value, "rejected");
				break;
			case 3:
				value.String_6 = "expired";
				value.String_7 = "expired";
				method_9(value, "rejected");
				break;
			}
		}
	}

	internal Class1 method_5(string string_1, uint uint_0)
	{
		lock (object_0)
		{
			dictionary_0.TryGetValue(smethod_2(string_1, uint_0), out var value);
			return value;
		}
	}

	internal IList<Class1> method_6()
	{
		lock (object_0)
		{
			return dictionary_0.Values.Where(method_12).ToList();
		}
	}

	internal string method_7(Class1 class1_0)
	{
		return Path.Combine(method_11(class1_0), "image.png");
	}

	internal bool method_8(string string_1, string string_2)
	{
		Class36 @class = new Class36();
		@class.string_0 = string_1;
		if (string.IsNullOrEmpty(string_2))
		{
			return false;
		}
		lock (object_0)
		{
			Class1 class2 = dictionary_0.Values.FirstOrDefault(@class.method_0);
			if (class2 != null && smethod_1(class2))
			{
				string text = method_11(class2);
				class2.String_8 = string_2;
				smethod_4(text, class2);
				Directory.Move(text, Path.Combine(string_0, "uploaded", class2.String_0));
				class2.String_7 = "uploaded";
				smethod_4(method_11(class2), class2);
				return true;
			}
			return false;
		}
	}

	private void method_9(Class1 class1_0, string string_1)
	{
		string text = Path.Combine(string_0, "pending", class1_0.String_0);
		smethod_4(text, class1_0);
		Directory.Move(text, Path.Combine(string_0, string_1, class1_0.String_0));
	}

	private void method_10()
	{
		string[] array = new string[4] { "pending", "verified", "rejected", "uploaded" };
		foreach (string text in array)
		{
			string[] directories = Directory.GetDirectories(Path.Combine(string_0, text));
			foreach (string text2 in directories)
			{
				try
				{
					string path = Path.Combine(text2, "sample.json");
					string path2 = Path.Combine(text2, "image.png");
					if (!File.Exists(path) || !File.Exists(path2))
					{
						continue;
					}
					Class1 @class = JsonConvert.DeserializeObject<Class1>(File.ReadAllText(path, Encoding.UTF8));
					if (@class != null && @class.Int32_0 == 1 && !string.IsNullOrEmpty(@class.String_0) && !string.IsNullOrEmpty(@class.String_1) && !(Path.GetFileName(text2) != @class.String_0) && !(smethod_3(File.ReadAllBytes(path2)) != @class.String_3))
					{
						string key = smethod_2(@class.String_1, @class.UInt32_0);
						if (!dictionary_0.ContainsKey(key))
						{
							dictionary_0.Add(key, @class);
						}
						if (@class.String_8 != null && text != "uploaded")
						{
							string text3 = Path.Combine(string_0, "uploaded", @class.String_0);
							Directory.Move(text2, text3);
							@class.String_7 = "uploaded";
							smethod_4(text3, @class);
						}
						else if (text == "uploaded" && @class.String_7 != "uploaded")
						{
							@class.String_7 = "uploaded";
							smethod_4(text2, @class);
						}
						else if (text == "pending" && smethod_1(@class))
						{
							Directory.Move(text2, Path.Combine(string_0, (@class.String_7 == "verified") ? "verified" : "rejected", @class.String_0));
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private string method_11(Class1 class1_0)
	{
		string path = ((class1_0.String_7 == "uploaded") ? "uploaded" : ((class1_0.String_7 == "verified") ? "verified" : ((class1_0.String_7 == "failed" || class1_0.String_7 == "expired") ? "rejected" : "pending")));
		return Path.Combine(string_0, path, class1_0.String_0);
	}

	private static bool smethod_0(string string_1)
	{
		switch (string_1)
		{
		default:
			return string_1 == "uploaded";
		case "verified":
		case "failed":
		case "expired":
		case "pass_without_observed_answer":
			return true;
		}
	}

	private static bool smethod_1(Class1 class1_0)
	{
		if (!(class1_0.String_7 == "verified") && !(class1_0.String_7 == "failed"))
		{
			return class1_0.String_7 == "expired";
		}
		return true;
	}

	private static string smethod_2(string string_1, uint uint_0)
	{
		return string_1 + "/" + uint_0;
	}

	private static string smethod_3(byte[] byte_1)
	{
		using SHA256 sHA = SHA256.Create();
		return BitConverter.ToString(sHA.ComputeHash(byte_1)).Replace("-", string.Empty).ToLowerInvariant();
	}

	private static void smethod_4(string string_1, Class1 class1_0)
	{
		string text = Path.Combine(string_1, "sample.json");
		string text2 = text + ".tmp";
		try
		{
			File.WriteAllText(text2, JsonConvert.SerializeObject((object)class1_0, (Formatting)1), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			if (File.Exists(text))
			{
				File.Replace(text2, text, null);
			}
			else
			{
				File.Move(text2, text);
			}
		}
		finally
		{
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
		}
	}

	private bool method_12(Class1 class1_0)
	{
		if (smethod_1(class1_0) && class1_0.String_8 == null)
		{
			return File.Exists(Path.Combine(method_11(class1_0), "image.png"));
		}
		return false;
	}
}
