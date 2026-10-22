using System.Collections.Generic;
using System.Globalization;
using System.Text;

internal static class Class428
{
	internal static string smethod_0(string string_0, float float_0, float float_1, float float_2, float float_3, float float_4)
	{
		return Class185.smethod_0(-1141031930) + smethod_13(string_0) + Class185.smethod_0(-1141030941) + smethod_12(float_0) + Class185.smethod_0(-1141030961) + smethod_12(float_1) + Class185.smethod_0(-1141030981) + smethod_12(float_2) + Class185.smethod_0(-1141030985) + smethod_12(float_3) + Class185.smethod_0(-1141031005) + smethod_12(float_4) + Class185.smethod_0(-1141174659);
	}

	internal static string smethod_1(string string_0, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6, float float_7)
	{
		return Class185.smethod_0(-1141031930) + smethod_13(string_0) + Class185.smethod_0(-1141030941) + smethod_12(float_0) + Class185.smethod_0(-1141030961) + smethod_12(float_1) + Class185.smethod_0(-1141030981) + smethod_12(float_2) + Class185.smethod_0(-1141030985) + smethod_12(float_3) + Class185.smethod_0(-1141031005) + smethod_12(float_4) + Class185.smethod_0(-1141031009) + smethod_12(float_5) + Class185.smethod_0(-1141194420) + smethod_12(float_6) + Class185.smethod_0(-1141194440) + smethod_12(float_7) + Class185.smethod_0(-1141174659);
	}

	internal static string smethod_2(string string_0, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6, float float_7, float float_8, float float_9, float float_10)
	{
		return Class185.smethod_0(-1141031930) + smethod_13(string_0) + Class185.smethod_0(-1141031029) + smethod_12(float_0) + Class185.smethod_0(-1141030961) + smethod_12(float_1) + Class185.smethod_0(-1141030981) + smethod_12(float_2) + Class185.smethod_0(-1141030985) + smethod_12(float_3) + Class185.smethod_0(-1141031005) + smethod_12(float_4) + Class185.smethod_0(-1141031009) + smethod_12(float_5) + Class185.smethod_0(-1141194420) + smethod_12(float_6) + Class185.smethod_0(-1141194440) + smethod_12(float_7) + Class185.smethod_0(-1141031044) + smethod_12(float_8) + Class185.smethod_0(-1141031057) + smethod_12(float_9) + Class185.smethod_0(-1141031078) + smethod_12(float_10) + Class185.smethod_0(-1141174659);
	}

	internal static string smethod_3(string string_0, int int_0)
	{
		return Class185.smethod_0(-1141031930) + smethod_13(string_0) + Class185.smethod_0(-1141031083) + smethod_11(int_0) + Class185.smethod_0(-1141174659);
	}

	internal static string smethod_4(string string_0)
	{
		return Class185.smethod_0(-1141031930) + smethod_13(string_0) + Class185.smethod_0(-1141031109);
	}

	internal static string smethod_5(string string_0, IEnumerable<(float, float, float)> ienumerable_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class185.smethod_0(-1141031121));
		stringBuilder.Append(smethod_13(string_0)).Append(Class185.smethod_0(-1141031147));
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
		stringBuilder.Append(Class185.smethod_0(-1141156722));
		return stringBuilder.ToString();
	}

	internal static string smethod_6(int int_0)
	{
		return smethod_10(smethod_0(Class185.smethod_0(-1141228263), int_0, 0.2f, 1f, 0.3f, 0.25f));
	}

	internal static string smethod_7(int int_0, float float_0, float float_1, float float_2)
	{
		return smethod_10(smethod_1(Class185.smethod_0(-1141228263), int_0, 0.2f, 1f, 0.3f, 0.25f, float_0, float_1, float_2));
	}

	internal static string smethod_8(int int_0)
	{
		return smethod_10(smethod_3(Class185.smethod_0(-1141228263), int_0));
	}

	internal static string smethod_9()
	{
		return smethod_10(smethod_4(Class185.smethod_0(-1141228263)));
	}

	private static string smethod_10(string string_0)
	{
		return string_0.Substring(0, string_0.Length - 1) + Class185.smethod_0(-1141031163);
	}

	private static string smethod_11(int int_0)
	{
		return int_0.ToString(CultureInfo.InvariantCulture);
	}

	private static string smethod_12(float float_0)
	{
		return float_0.ToString(Class185.smethod_0(-1141194459), CultureInfo.InvariantCulture);
	}

	private static string smethod_13(string string_0)
	{
		return (string_0 ?? string.Empty).Replace(Class185.smethod_0(-1141300999), Class185.smethod_0(-1141300327)).Replace(Class185.smethod_0(-1141304355), Class185.smethod_0(-1141209113));
	}
}
