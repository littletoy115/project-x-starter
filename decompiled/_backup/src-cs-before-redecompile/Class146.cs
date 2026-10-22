using System.Collections.Generic;

internal static class Class146
{
	internal static string smethod_0()
	{
		return Class135.smethod_4();
	}

	internal static string smethod_1(bool bool_0, bool bool_1, string string_0, string string_1, string string_2)
	{
		List<string> list = new List<string>(3);
		string text = smethod_2(string_0);
		string text2 = smethod_2(string_1);
		string text3 = smethod_2(string_2);
		if (bool_0 && text.Length != 0)
		{
			list.Add(text);
		}
		if (bool_1 && text2.Length != 0)
		{
			list.Add(text2);
		}
		list.Add((text3.Length == 0) ? smethod_0() : text3);
		return string.Join(" : ", list.ToArray());
	}

	private static string smethod_2(string string_0)
	{
		if (!string.IsNullOrWhiteSpace(string_0))
		{
			return string_0.Trim();
		}
		return string.Empty;
	}
}
