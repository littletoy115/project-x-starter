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
			string text = (bool_0 ? "failure:" : "success:") + string_1;
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
			if (!smethod_1(string_0, "zone") && !smethod_1(string_0, "w2s") && !smethod_1(string_0, "skill") && !smethod_1(string_0, "skill_bar") && !smethod_1(string_0, "skill_check") && !smethod_1(string_0, "skill_status") && !smethod_1(string_0, "skill_tab_ids") && !smethod_1(string_0, "skill_ready") && !smethod_1(string_0, "buff_cast") && !smethod_1(string_0, "frame_hook") && !smethod_1(string_0, "cam") && !smethod_1(string_0, "slot") && !smethod_1(string_0, "attack") && !smethod_1(string_0, "attack_stop") && !smethod_1(string_0, "attack_status"))
			{
				return !smethod_1(string_0, "pick_status");
			}
			return false;
		}
		return true;
	}

	private static bool smethod_1(string string_0, string string_1)
	{
		if (string_0.IndexOf("\"t\":\"" + string_1 + "\"", StringComparison.Ordinal) < 0)
		{
			return string_0.IndexOf("\"t\": \"" + string_1 + "\"", StringComparison.Ordinal) >= 0;
		}
		return true;
	}

	internal static string smethod_2(string string_0, float float_0, float float_1, float float_2)
	{
		return "[Move] source=" + (string.IsNullOrEmpty(string_0) ? "unspecified" : string_0) + " target=" + smethod_11(float_0, float_1, float_2);
	}

	internal static string smethod_3(JObject jobject_0)
	{
		bool valueOrDefault = (bool?)jobject_0["ok"] == true;
		string text = ((!(jobject_0["target"] is JObject jobject_1)) ? "-" : smethod_11(smethod_9(jobject_1, "x"), smethod_9(jobject_1, "y"), smethod_9(jobject_1, "z")));
		if (!valueOrDefault)
		{
			return "[MoveReply] ok=false target=" + text + " error=" + smethod_10(jobject_0, "error") + " reason=" + smethod_10(jobject_0, "reason");
		}
		return "[MoveReply] ok=true result=" + ((bool?)jobject_0["result"] == true) + " target=" + text + " total_ms=" + smethod_8(jobject_0, "total_ms");
	}

	internal static string smethod_4(JObject jobject_0)
	{
		JObject jObject = jobject_0["target"] as JObject;
		return ((bool?)jobject_0["ok"] == true) + ":" + ((bool?)jobject_0["result"] == true) + ":" + ((jObject == null) ? "-" : smethod_11(smethod_9(jObject, "x"), smethod_9(jObject, "y"), smethod_9(jObject, "z"))) + ":" + smethod_10(jobject_0, "error") + ":" + smethod_10(jobject_0, "reason");
	}

	internal static string smethod_5(JObject jobject_0)
	{
		bool valueOrDefault = (bool?)jobject_0["ok"] == true;
		return "[PickReply] ok=" + valueOrDefault + " id=" + smethod_8(jobject_0, "id") + " type=" + smethod_8(jobject_0, "type") + (valueOrDefault ? string.Empty : (" error=" + smethod_10(jobject_0, "error")));
	}

	internal static string smethod_6(JObject jobject_0)
	{
		return ((bool?)jobject_0["ok"] == true) + ":" + smethod_8(jobject_0, "id") + ":" + smethod_8(jobject_0, "type") + ":" + smethod_10(jobject_0, "error");
	}

	internal static string smethod_7(uint uint_0, byte byte_0, string string_0, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6, float float_7, float float_8, float float_9, float float_10, float float_11, string string_1, int int_0, long long_0, int int_1)
	{
		return "[PickDecision] action=" + string_1 + " id=" + uint_0 + " kind=" + byte_0 + " name=" + smethod_13(string_0) + " self=" + smethod_11(float_0, float_1, float_2) + " target=" + smethod_11(float_3, float_4, float_5) + " dx=" + smethod_12(float_6) + " dy=" + smethod_12(float_7) + " dz=" + smethod_12(float_8) + " d3=" + smethod_12(float_9) + " dXZ=" + smethod_12(float_10) + " threshold=" + smethod_12(float_11) + " compare=d3>threshold snap_seq=" + int_0 + " self_stamp_ms=" + long_0 + " census_seq=" + int_1;
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
		return smethod_13((string?)jobject_0[string_0]);
	}

	internal static string smethod_11(float float_0, float float_1, float float_2)
	{
		return "(" + smethod_12(float_0) + "," + smethod_12(float_1) + "," + smethod_12(float_2) + ")";
	}

	private static string smethod_12(float float_0)
	{
		return float_0.ToString("G9", CultureInfo.InvariantCulture);
	}

	private static string smethod_13(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return "-";
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
				stringBuilder.Append("\\r");
				continue;
			case '\n':
				stringBuilder.Append("\\n");
				continue;
			case '\t':
				stringBuilder.Append("\\t");
				continue;
			}
			if (!char.IsControl(c))
			{
				stringBuilder.Append(c);
			}
		}
		if (string_0.Length > 96)
		{
			stringBuilder.Append("...");
		}
		return stringBuilder.ToString();
	}
}
