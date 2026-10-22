using System;
using Newtonsoft.Json.Linq;

internal sealed class Class147
{
	internal readonly string string_0;

	internal readonly bool bool_0;

	internal readonly string string_1;

	internal readonly string string_2;

	internal readonly int int_0;

	internal readonly int int_1;

	internal readonly string string_3;

	internal Class147(string string_4, bool bool_1, string string_5, string string_6, int int_2, int int_3, string string_7)
	{
		string_0 = string_4 ?? string.Empty;
		bool_0 = bool_1;
		string_1 = string_5 ?? string.Empty;
		string_2 = string_6 ?? string.Empty;
		int_0 = int_2;
		int_1 = int_3;
		string_3 = string_7 ?? string.Empty;
	}

	internal static Class147 smethod_0()
	{
		return new Class147(string.Empty, bool_1: false, "inactive", string.Empty, 0, 0, string.Empty);
	}

	internal static Class147 smethod_1(string string_4)
	{
		return new Class147(string_4, bool_1: false, "configured", string.Empty, 0, 0, string.Empty);
	}

	internal static bool smethod_2(JObject jobject_0, string string_4, out Class147 class147_0)
	{
		class147_0 = null;
		if (jobject_0 != null && !string.IsNullOrEmpty(string_4))
		{
			JToken jToken = jobject_0["sessionId"];
			JToken jToken2 = jobject_0["authorized"];
			JToken jToken3 = jobject_0["state"];
			JToken jToken4 = jobject_0["reason"];
			if (jToken != null && jToken.Type == JTokenType.String && string.Equals((string?)jToken, string_4, StringComparison.OrdinalIgnoreCase) && jToken2 != null && jToken2.Type == JTokenType.Boolean && jToken3 != null && jToken3.Type == JTokenType.String && jToken4 != null && jToken4.Type == JTokenType.String)
			{
				string text = (string?)jToken3;
				string text2 = (string?)jToken4;
				string text3 = smethod_3(jobject_0["serverId"]);
				int num = smethod_4(jobject_0["attempt"]);
				int num2 = smethod_4(jobject_0["round"]);
				if (text.Length != 0 && text.Length <= 64 && text2.Length <= 256 && text3.Length <= 128 && num >= 0 && num2 >= 0 && !smethod_5(text) && !smethod_5(text2) && !smethod_5(text3))
				{
					class147_0 = new Class147(string_4, (bool)jToken2, text, text2, num, num2, text3);
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private static string smethod_3(JToken jtoken_0)
	{
		if (jtoken_0 != null && jtoken_0.Type != JTokenType.Null)
		{
			if (jtoken_0.Type != JTokenType.String)
			{
				return new string('\0', 1);
			}
			return (string?)jtoken_0;
		}
		return string.Empty;
	}

	private static int smethod_4(JToken jtoken_0)
	{
		if (jtoken_0 != null && jtoken_0.Type != JTokenType.Null)
		{
			if (jtoken_0 is JValue { Type: JTokenType.Integer } jValue && jValue.Value is long)
			{
				long num = (long)jValue.Value;
				if (num >= 0L && num <= 2147483647L)
				{
					return (int)num;
				}
				return -1;
			}
			return -1;
		}
		return 0;
	}

	private static bool smethod_5(string string_4)
	{
		int num = 0;
		while (true)
		{
			if (num < string_4.Length)
			{
				if (char.IsControl(string_4[num]))
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
