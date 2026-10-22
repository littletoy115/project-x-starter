using System;
using System.Globalization;
using System.Text;
using Newtonsoft.Json.Linq;

internal static class Class172
{
	internal sealed class Class173
	{
		private string string_0;

		private DateTime dateTime_0;

		internal bool method_0(string string_1, bool bool_0, DateTime dateTime_1)
		{
			string text = (bool_0 ? Class185.smethod_0(-1141182170) : Class185.smethod_0(-1141182155)) + string_1;
			if (!(text != string_0) && (dateTime_1 - dateTime_0).TotalMilliseconds < 1000.0)
			{
				return false;
			}
			string_0 = text;
			dateTime_0 = dateTime_1;
			return true;
		}

		internal void method_1()
		{
			string_0 = null;
			dateTime_0 = DateTime.MinValue;
		}
	}

	internal static bool bool_0 = true;

	internal static bool smethod_0(string string_0)
	{
		if (bool_0 && !string.IsNullOrEmpty(string_0))
		{
			if (!smethod_1(string_0, Class185.smethod_0(-1141182185)) && !smethod_1(string_0, Class185.smethod_0(-1141182196)) && !smethod_1(string_0, Class185.smethod_0(-1141182214)) && !smethod_1(string_0, Class185.smethod_0(-1141182218)) && !smethod_1(string_0, Class185.smethod_0(-1141182234)) && !smethod_1(string_0, Class185.smethod_0(-1141182252)) && !smethod_1(string_0, Class185.smethod_0(-1141182279)) && !smethod_1(string_0, Class185.smethod_0(-1141182291)) && !smethod_1(string_0, Class185.smethod_0(-1141308159)) && !smethod_1(string_0, Class185.smethod_0(-1141182317)) && !smethod_1(string_0, Class185.smethod_0(-1141182334)) && !smethod_1(string_0, Class185.smethod_0(-1141125133)) && !smethod_1(string_0, Class185.smethod_0(-1141182344)) && !smethod_1(string_0, Class185.smethod_0(-1141182357)) && !smethod_1(string_0, Class185.smethod_0(-1141182375)))
			{
				return !smethod_1(string_0, Class185.smethod_0(-1141182387));
			}
			return false;
		}
		return true;
	}

	private static bool smethod_1(string string_0, string string_1)
	{
		if (string_0.IndexOf(Class185.smethod_0(-1141182413) + string_1 + Class185.smethod_0(-1141304355), StringComparison.Ordinal) < 0)
		{
			return string_0.IndexOf(Class185.smethod_0(-1141182417) + string_1 + Class185.smethod_0(-1141304355), StringComparison.Ordinal) >= 0;
		}
		return true;
	}

	internal static string smethod_2(string string_0, float float_0, float float_1, float float_2)
	{
		return Class185.smethod_0(-1141182438) + (string.IsNullOrEmpty(string_0) ? Class185.smethod_0(-1141182451) : string_0) + Class185.smethod_0(-1141181453) + smethod_11(float_0, float_1, float_2);
	}

	internal static string smethod_3(JObject jobject_0)
	{
		bool valueOrDefault = (bool?)jobject_0[Class185.smethod_0(-1141303993)] == true;
		JToken obj = jobject_0[Class185.smethod_0(-1141181460)];
		JObject val = (JObject)(object)((obj is JObject) ? obj : null);
		string text = ((val == null) ? Class185.smethod_0(-1141293701) : smethod_11(smethod_9(val, Class185.smethod_0(-1141255982)), smethod_9(val, Class185.smethod_0(-1141255990)), smethod_9(val, Class185.smethod_0(-1141255998))));
		if (!valueOrDefault)
		{
			return Class185.smethod_0(-1141181473) + text + Class185.smethod_0(-1141241623) + smethod_10(jobject_0, Class185.smethod_0(-1141253360)) + Class185.smethod_0(-1141213831) + smethod_10(jobject_0, Class185.smethod_0(-1141259028));
		}
		return Class185.smethod_0(-1141181508) + ((bool?)jobject_0[Class185.smethod_0(-1141180506)] == true) + Class185.smethod_0(-1141181453) + text + Class185.smethod_0(-1141181550) + smethod_8(jobject_0, Class185.smethod_0(-1141181567));
	}

	internal static string smethod_4(JObject jobject_0)
	{
		JToken obj = jobject_0[Class185.smethod_0(-1141181460)];
		JObject val = (JObject)(object)((obj is JObject) ? obj : null);
		return ((bool?)jobject_0[Class185.smethod_0(-1141303993)] == true) + Class185.smethod_0(-1141297577) + ((bool?)jobject_0[Class185.smethod_0(-1141180506)] == true) + Class185.smethod_0(-1141297577) + ((val == null) ? Class185.smethod_0(-1141293701) : smethod_11(smethod_9(val, Class185.smethod_0(-1141255982)), smethod_9(val, Class185.smethod_0(-1141255990)), smethod_9(val, Class185.smethod_0(-1141255998)))) + Class185.smethod_0(-1141297577) + smethod_10(jobject_0, Class185.smethod_0(-1141253360)) + Class185.smethod_0(-1141297577) + smethod_10(jobject_0, Class185.smethod_0(-1141259028));
	}

	internal static string smethod_5(JObject jobject_0)
	{
		bool valueOrDefault = (bool?)jobject_0[Class185.smethod_0(-1141303993)] == true;
		return Class185.smethod_0(-1141181582) + valueOrDefault + Class185.smethod_0(-1141181596) + smethod_8(jobject_0, Class185.smethod_0(-1141293578)) + Class185.smethod_0(-1141181615) + smethod_8(jobject_0, Class185.smethod_0(-1141255953)) + (valueOrDefault ? string.Empty : (Class185.smethod_0(-1141241623) + smethod_10(jobject_0, Class185.smethod_0(-1141253360))));
	}

	internal static string smethod_6(JObject jobject_0)
	{
		return ((bool?)jobject_0[Class185.smethod_0(-1141303993)] == true) + Class185.smethod_0(-1141297577) + smethod_8(jobject_0, Class185.smethod_0(-1141293578)) + Class185.smethod_0(-1141297577) + smethod_8(jobject_0, Class185.smethod_0(-1141255953)) + Class185.smethod_0(-1141297577) + smethod_10(jobject_0, Class185.smethod_0(-1141253360));
	}

	internal static string smethod_7(uint uint_0, byte byte_0, string string_0, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6, float float_7, float float_8, float float_9, float float_10, float float_11, string string_1, int int_0, long long_0, int int_1)
	{
		return Class185.smethod_0(-1141181620) + string_1 + Class185.smethod_0(-1141181596) + uint_0 + Class185.smethod_0(-1141181649) + byte_0 + Class185.smethod_0(-1141181670) + smethod_13(string_0) + Class185.smethod_0(-1141181675) + smethod_11(float_0, float_1, float_2) + Class185.smethod_0(-1141181453) + smethod_11(float_3, float_4, float_5) + Class185.smethod_0(-1141181696) + smethod_12(float_6) + Class185.smethod_0(-1141181699) + smethod_12(float_7) + Class185.smethod_0(-1141181718) + smethod_12(float_8) + Class185.smethod_0(-1141181721) + smethod_12(float_9) + Class185.smethod_0(-1141181732) + smethod_12(float_10) + Class185.smethod_0(-1141181752) + smethod_12(float_11) + Class185.smethod_0(-1141181762) + int_0 + Class185.smethod_0(-1141181808) + long_0 + Class185.smethod_0(-1141181830) + int_1;
	}

	private static int smethod_8(JObject jobject_0, string string_0)
	{
		return ((int?)jobject_0[string_0]) ?? (-1);
	}

	private static float smethod_9(JObject jobject_0, string string_0)
	{
		return ((float?)jobject_0[string_0]).GetValueOrDefault();
	}

	private static string smethod_10(JObject jobject_0, string string_0)
	{
		return smethod_13((string)jobject_0[string_0]);
	}

	internal static string smethod_11(float float_0, float float_1, float float_2)
	{
		return Class185.smethod_0(-1141114314) + smethod_12(float_0) + Class185.smethod_0(-1141326297) + smethod_12(float_1) + Class185.smethod_0(-1141326297) + smethod_12(float_2) + Class185.smethod_0(-1141308401);
	}

	private static string smethod_12(float float_0)
	{
		return float_0.ToString(Class185.smethod_0(-1141181841), CultureInfo.InvariantCulture);
	}

	private static string smethod_13(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return Class185.smethod_0(-1141293701);
		}
		StringBuilder stringBuilder = new StringBuilder(Math.Min(string_0.Length, 96));
		for (int i = 0; i < string_0.Length; i++)
		{
			if (stringBuilder.Length >= 96)
			{
				break;
			}
			char c = string_0[i];
			switch (c)
			{
			case '\r':
				stringBuilder.Append(Class185.smethod_0(-1141254370));
				continue;
			case '\n':
				stringBuilder.Append(Class185.smethod_0(-1141254387));
				continue;
			case '\t':
				stringBuilder.Append(Class185.smethod_0(-1141181850));
				continue;
			}
			if (!char.IsControl(c))
			{
				stringBuilder.Append(c);
			}
		}
		if (string_0.Length > 96)
		{
			stringBuilder.Append(Class185.smethod_0(-1141181859));
		}
		return stringBuilder.ToString();
	}
}
