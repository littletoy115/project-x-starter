using System.Collections.Generic;
using System.Globalization;
using System.Text;

internal static class Class428
{
	internal static string smethod_0(string string_0, float float_0, float float_1, float float_2, float float_3, float float_4)
	{
		return "{\"cmd\":\"zone\",\"id\":\"" + smethod_13(string_0) + "\",\"on\":true,\"radius\":" + smethod_12(float_0) + ",\"r\":" + smethod_12(float_1) + ",\"g\":" + smethod_12(float_2) + ",\"b\":" + smethod_12(float_3) + ",\"a\":" + smethod_12(float_4) + "}";
	}

	internal static string smethod_1(string string_0, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6, float float_7)
	{
		return "{\"cmd\":\"zone\",\"id\":\"" + smethod_13(string_0) + "\",\"on\":true,\"radius\":" + smethod_12(float_0) + ",\"r\":" + smethod_12(float_1) + ",\"g\":" + smethod_12(float_2) + ",\"b\":" + smethod_12(float_3) + ",\"a\":" + smethod_12(float_4) + ",\"x\":" + smethod_12(float_5) + ",\"y\":" + smethod_12(float_6) + ",\"z\":" + smethod_12(float_7) + "}";
	}

	internal static string smethod_2(string string_0, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6, float float_7, float float_8, float float_9, float float_10)
	{
		return "{\"cmd\":\"zone\",\"id\":\"" + smethod_13(string_0) + "\",\"on\":true,\"w\":" + smethod_12(float_0) + ",\"r\":" + smethod_12(float_1) + ",\"g\":" + smethod_12(float_2) + ",\"b\":" + smethod_12(float_3) + ",\"a\":" + smethod_12(float_4) + ",\"x\":" + smethod_12(float_5) + ",\"y\":" + smethod_12(float_6) + ",\"z\":" + smethod_12(float_7) + ",\"x2\":" + smethod_12(float_8) + ",\"y2\":" + smethod_12(float_9) + ",\"z2\":" + smethod_12(float_10) + "}";
	}

	internal static string smethod_3(string string_0, int int_0)
	{
		return "{\"cmd\":\"zone\",\"id\":\"" + smethod_13(string_0) + "\",\"radius\":" + smethod_11(int_0) + "}";
	}

	internal static string smethod_4(string string_0)
	{
		return "{\"cmd\":\"zone\",\"id\":\"" + smethod_13(string_0) + "\",\"on\":false}";
	}

	internal static string smethod_5(string string_0, IEnumerable<(float, float, float)> ienumerable_0)
	{
		StringBuilder stringBuilder = new StringBuilder("{\"cmd\":\"w2s\",\"id\":\"");
		stringBuilder.Append(smethod_13(string_0)).Append("\",\"pts\":[");
		bool flag = true;
		if (ienumerable_0 != null)
		{
			foreach (var item in ienumerable_0)
			{
				if (!flag)
				{
					stringBuilder.Append(',');
				}
				flag = false;
				stringBuilder.Append('[').Append(smethod_12(item.Item1)).Append(',')
					.Append(smethod_12(item.Item2))
					.Append(',')
					.Append(smethod_12(item.Item3))
					.Append(']');
			}
		}
		stringBuilder.Append("]}");
		return stringBuilder.ToString();
	}

	internal static string smethod_6(int int_0)
	{
		return smethod_10(smethod_0("player", int_0, 0.2f, 1f, 0.3f, 0.25f));
	}

	internal static string smethod_7(int int_0, float float_0, float float_1, float float_2)
	{
		return smethod_10(smethod_1("player", int_0, 0.2f, 1f, 0.3f, 0.25f, float_0, float_1, float_2));
	}

	internal static string smethod_8(int int_0)
	{
		return smethod_10(smethod_3("player", int_0));
	}

	internal static string smethod_9()
	{
		return smethod_10(smethod_4("player"));
	}

	private static string smethod_10(string string_0)
	{
		return string_0.Substring(0, string_0.Length - 1) + ",\"renderer\":\"radar\"}";
	}

	private static string smethod_11(int int_0)
	{
		return int_0.ToString(CultureInfo.InvariantCulture);
	}

	private static string smethod_12(float float_0)
	{
		return float_0.ToString("0.####", CultureInfo.InvariantCulture);
	}

	private static string smethod_13(string string_0)
	{
		return (string_0 ?? string.Empty).Replace("\\", "\\\\").Replace("\"", "\\\"");
	}
}
