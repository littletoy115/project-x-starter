using System.Collections.Generic;
using System.Globalization;

internal static class Class16
{
	internal static bool smethod_0(long long_0, long long_1)
	{
		if (long_0 < 0L)
		{
			return true;
		}
		return long_1 - long_0 >= 1000L;
	}

	internal static string smethod_1(Struct27 struct27_0, int int_0)
	{
		return "bag: index=" + struct27_0.int_0.ToString(CultureInfo.InvariantCulture) + " ordinal=" + struct27_0.int_1.ToString(CultureInfo.InvariantCulture) + " slots=" + int_0.ToString(CultureInfo.InvariantCulture) + " divergent=" + ((struct27_0.int_0 != struct27_0.int_1) ? "true" : "false");
	}

	internal static List<string[]> smethod_2(Class145 class145_0)
	{
		List<string[]> list = new List<string[]>();
		if (class145_0 == null)
		{
			return list;
		}
		string text = class145_0.method_51();
		if (text != null && text.Length != 0)
		{
			list.Add(new string[3]
			{
				string.Empty,
				text,
				string.Empty
			});
			return list;
		}
		Class95 class95_ = class145_0.method_10();
		for (int i = 0; i < class145_0.method_39().Count; i++)
		{
			Struct27 @struct = class145_0.method_39()[i];
			list.Add(new string[3]
			{
				@struct.int_0.ToString(CultureInfo.InvariantCulture),
				smethod_5(class95_, @struct.ushort_0, @struct.ushort_1),
				@struct.int_2.ToString(CultureInfo.InvariantCulture)
			});
		}
		return list;
	}

	internal static string smethod_3(Class145 class145_0)
	{
		if (class145_0 == null)
		{
			return "0 / ?";
		}
		string text = class145_0.method_39().Count.ToString(CultureInfo.InvariantCulture);
		if (class145_0.method_47() <= 0)
		{
			return text + " / ?";
		}
		return text + " / " + class145_0.method_47().ToString(CultureInfo.InvariantCulture);
	}

	internal static (string, string) smethod_4(Class145 class145_0, int int_0, string string_0)
	{
		if (string_0 == null)
		{
			string_0 = string.Empty;
		}
		if (class145_0 == null)
		{
			return (string_0, string.Empty);
		}
		if (int_0 >= 0 && int_0 < class145_0.method_41().Count)
		{
			Struct19 @struct = class145_0.method_41()[int_0];
			if (@struct.ushort_0 == ushort.MaxValue)
			{
				return (string_0, string.Empty);
			}
			string item = smethod_5(class145_0.method_10(), @struct.ushort_0, @struct.ushort_1);
			if (@struct.int_1 <= 0)
			{
				return (item, string.Empty);
			}
			return (item, @struct.int_1.ToString(CultureInfo.InvariantCulture));
		}
		return (string_0, string.Empty);
	}

	internal static string smethod_5(Class95 class95_0, ushort ushort_0, ushort ushort_1)
	{
		string text = smethod_6(class95_0, ushort_0, ushort_1);
		if (text != null)
		{
			return text;
		}
		return "Item " + smethod_7(ushort_0, ushort_1);
	}

	internal static string smethod_6(Class95 class95_0, ushort ushort_0, ushort ushort_1)
	{
		if (class95_0 == null)
		{
			return null;
		}
		if (class95_0.method_2().TryGetValue(smethod_7(ushort_0, ushort_1), out var value) && value != null)
		{
			value = value.Trim();
			if (value.Length != 0)
			{
				return value;
			}
			return null;
		}
		return null;
	}

	internal static string smethod_7(ushort ushort_0, ushort ushort_1)
	{
		return ushort_0.ToString(CultureInfo.InvariantCulture) + ":" + ushort_1.ToString(CultureInfo.InvariantCulture);
	}

	internal static List<string> smethod_8(Class145 class145_0)
	{
		List<string> list = new List<string>();
		if (class145_0 == null)
		{
			return list;
		}
		for (int i = 0; i < class145_0.method_39().Count; i++)
		{
			Struct27 @struct = class145_0.method_39()[i];
			string text = smethod_6(class145_0.method_10(), @struct.ushort_0, @struct.ushort_1);
			if (text == null)
			{
				continue;
			}
			bool flag = false;
			for (int j = 0; j < list.Count; j++)
			{
				if (Class96.smethod_0(list[j], text))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				list.Add(text);
			}
		}
		return list;
	}
}
