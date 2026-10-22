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
		return new Class147(string.Empty, bool_1: false, Class185.smethod_0(-1141210024), string.Empty, 0, 0, string.Empty);
	}

	internal static Class147 smethod_1(string string_4)
	{
		return new Class147(string_4, bool_1: false, Class185.smethod_0(-1141210039), string.Empty, 0, 0, string.Empty);
	}

	internal static bool smethod_2(JObject jobject_0, string string_4, out Class147 class147_0)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		class147_0 = null;
		if (jobject_0 != null && !string.IsNullOrEmpty(string_4))
		{
			JToken val = jobject_0[Class185.smethod_0(-1141253472)];
			JToken val2 = jobject_0[Class185.smethod_0(-1141259007)];
			JToken val3 = jobject_0[Class185.smethod_0(-1141259024)];
			JToken val4 = jobject_0[Class185.smethod_0(-1141259028)];
			if (val != null && (int)val.Type == 8 && string.Equals((string)val, string_4, StringComparison.OrdinalIgnoreCase) && val2 != null && (int)val2.Type == 9 && val3 != null && (int)val3.Type == 8 && val4 != null && (int)val4.Type == 8)
			{
				string text = (string)val3;
				string text2 = (string)val4;
				string text3 = smethod_3(jobject_0[Class185.smethod_0(-1141259067)]);
				int num = smethod_4(jobject_0[Class185.smethod_0(-1141259041)]);
				int num2 = smethod_4(jobject_0[Class185.smethod_0(-1141259063)]);
				if (text.Length != 0 && text.Length <= 64 && text2.Length <= 256 && text3.Length <= 128 && num >= 0 && num2 >= 0 && !smethod_5(text) && !smethod_5(text2) && !smethod_5(text3))
				{
					class147_0 = new Class147(string_4, (bool)val2, text, text2, num, num2, text3);
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
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		if (jtoken_0 != null && (int)jtoken_0.Type != 10)
		{
			if ((int)jtoken_0.Type != 8)
			{
				return new string('\0', 1);
			}
			return (string)jtoken_0;
		}
		return string.Empty;
	}

	private static int smethod_4(JToken jtoken_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		if (jtoken_0 != null && (int)jtoken_0.Type != 10)
		{
			JValue val = (JValue)(object)((jtoken_0 is JValue) ? jtoken_0 : null);
			if (val != null && (int)((JToken)val).Type == 6 && val.Value is long)
			{
				long num = (long)val.Value;
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
