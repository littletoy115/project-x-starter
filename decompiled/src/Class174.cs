using System;
using System.Collections.Generic;
using System.Globalization;

internal static class Class174
{
	internal static bool smethod_0(long long_0, long long_1)
	{
		if (long_0 >= 0L)
		{
			return long_1 - long_0 >= 1000L;
		}
		return true;
	}

	internal static string smethod_1(Class401 class401_0, long long_0)
	{
		if (class401_0 == null)
		{
			return "[PartySHM] update unavailable";
		}
		return "[PartySHM] update id=" + class401_0.uint_0.ToString(CultureInfo.InvariantCulture) + " name=\"" + smethod_5(class401_0.string_0) + "\" leader=" + (class401_0.bool_0 ? "true" : "false") + " actor=" + (class401_0.bool_1 ? class401_0.byte_0.ToString(CultureInfo.InvariantCulture) : "none") + " pos=" + smethod_4(class401_0.float_0, class401_0.float_1, class401_0.float_2) + " target=" + smethod_6(class401_0.bool_2, class401_0.byte_1, class401_0.ushort_0) + " self_stamp_ms=" + long_0.ToString(CultureInfo.InvariantCulture);
	}

	internal static string smethod_2(IReadOnlyList<Class401> ireadOnlyList_0, DateTime dateTime_0)
	{
		int num = ireadOnlyList_0?.Count ?? 0;
		string text = "[PartySHM] slots=" + num.ToString(CultureInfo.InvariantCulture);
		for (int i = 0; i < num; i++)
		{
			Class401 @class = ireadOnlyList_0[i];
			if (@class != null)
			{
				long num2 = Math.Max(0L, (dateTime_0.Ticks - @class.long_0) / 10000L);
				text = text + " | id=" + @class.uint_0.ToString(CultureInfo.InvariantCulture) + " name=\"" + smethod_5(@class.string_0) + "\" leader=" + (@class.bool_0 ? "true" : "false") + " actor=" + (@class.bool_1 ? @class.byte_0.ToString(CultureInfo.InvariantCulture) : "none") + " pos=" + smethod_4(@class.float_0, @class.float_1, @class.float_2) + " target=" + smethod_6(@class.bool_2, @class.byte_1, @class.ushort_0) + " age_ms=" + num2.ToString(CultureInfo.InvariantCulture);
			}
		}
		return text;
	}

	internal static string smethod_3(Class31 class31_0, Class83 class83_0, float float_0, float float_1, float float_2, bool bool_0, float float_3, float float_4)
	{
		if (class31_0 != null && class83_0 != null)
		{
			return "[PartyFollow] move source=" + (class31_0.bool_0 ? "census" : "shm") + " id=" + class31_0.uint_0.ToString(CultureInfo.InvariantCulture) + " name=\"" + smethod_5(class31_0.string_0) + "\" actor=" + (class31_0.bool_1 ? class31_0.byte_0.ToString(CultureInfo.InvariantCulture) : "none") + " moving=" + (bool_0 ? "true" : "false") + " self=" + smethod_4(class83_0.float_0, class83_0.float_1, class83_0.float_2) + " host=" + smethod_4(class31_0.float_0, class31_0.float_1, class31_0.float_2) + " dest=" + smethod_4(float_0, float_1, float_2) + " gap=" + float_3.ToString("0.00", CultureInfo.InvariantCulture) + " radius=" + float_4.ToString("0.00", CultureInfo.InvariantCulture) + " sample=" + class31_0.long_0.ToString(CultureInfo.InvariantCulture);
		}
		return "[PartyFollow] move unavailable";
	}

	private static string smethod_4(float float_0, float float_1, float float_2)
	{
		return "(" + float_0.ToString("0.00", CultureInfo.InvariantCulture) + "," + float_1.ToString("0.00", CultureInfo.InvariantCulture) + "," + float_2.ToString("0.00", CultureInfo.InvariantCulture) + ")";
	}

	private static string smethod_5(string string_0)
	{
		return (string_0 ?? string.Empty).Replace("\"", "'");
	}

	private static string smethod_6(bool bool_0, byte byte_0, ushort ushort_0)
	{
		if (bool_0)
		{
			if (ushort_0 != 0)
			{
				return byte_0.ToString(CultureInfo.InvariantCulture) + ":" + ushort_0.ToString(CultureInfo.InvariantCulture);
			}
			return "none";
		}
		return "unknown";
	}
}
