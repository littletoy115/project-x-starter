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
			return Class185.smethod_0(-1141038251);
		}
		return Class185.smethod_0(-1141038295) + class401_0.uint_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141038315) + smethod_5(class401_0.string_0) + Class185.smethod_0(-1141038329) + (class401_0.bool_0 ? Class185.smethod_0(-1141210092) : Class185.smethod_0(-1141210088)) + Class185.smethod_0(-1141038345) + (class401_0.bool_1 ? class401_0.byte_0.ToString(CultureInfo.InvariantCulture) : Class185.smethod_0(-1141037869)) + Class185.smethod_0(-1141038367) + smethod_4(class401_0.float_0, class401_0.float_1, class401_0.float_2) + Class185.smethod_0(-1141181453) + smethod_6(class401_0.bool_2, class401_0.byte_1, class401_0.ushort_0) + Class185.smethod_0(-1141181808) + long_0.ToString(CultureInfo.InvariantCulture);
	}

	internal static string smethod_2(IReadOnlyList<Class401> ireadOnlyList_0, DateTime dateTime_0)
	{
		int num = ireadOnlyList_0?.Count ?? 0;
		string text = Class185.smethod_0(-1141038371) + num.ToString(CultureInfo.InvariantCulture);
		for (int i = 0; i < num; i++)
		{
			Class401 @class = ireadOnlyList_0[i];
			if (@class != null)
			{
				long num2 = Math.Max(0L, (dateTime_0.Ticks - @class.long_0) / 10000L);
				text = text + Class185.smethod_0(-1141038395) + @class.uint_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141038315) + smethod_5(@class.string_0) + Class185.smethod_0(-1141038329) + (@class.bool_0 ? Class185.smethod_0(-1141210092) : Class185.smethod_0(-1141210088)) + Class185.smethod_0(-1141038345) + (@class.bool_1 ? @class.byte_0.ToString(CultureInfo.InvariantCulture) : Class185.smethod_0(-1141037869)) + Class185.smethod_0(-1141038367) + smethod_4(@class.float_0, @class.float_1, @class.float_2) + Class185.smethod_0(-1141181453) + smethod_6(@class.bool_2, @class.byte_1, @class.ushort_0) + Class185.smethod_0(-1141038416) + num2.ToString(CultureInfo.InvariantCulture);
			}
		}
		return text;
	}

	internal static string smethod_3(Class31 class31_0, Class83 class83_0, float float_0, float float_1, float float_2, bool bool_0, float float_3, float float_4)
	{
		if (class31_0 != null && class83_0 != null)
		{
			return Class185.smethod_0(-1141038460) + (class31_0.bool_0 ? Class185.smethod_0(-1141038511) : Class185.smethod_0(-1141038501)) + Class185.smethod_0(-1141181596) + class31_0.uint_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141038315) + smethod_5(class31_0.string_0) + Class185.smethod_0(-1141038516) + (class31_0.bool_1 ? class31_0.byte_0.ToString(CultureInfo.InvariantCulture) : Class185.smethod_0(-1141037869)) + Class185.smethod_0(-1141038531) + (bool_0 ? Class185.smethod_0(-1141210092) : Class185.smethod_0(-1141210088)) + Class185.smethod_0(-1141181675) + smethod_4(class83_0.float_0, class83_0.float_1, class83_0.float_2) + Class185.smethod_0(-1141038546) + smethod_4(class31_0.float_0, class31_0.float_1, class31_0.float_2) + Class185.smethod_0(-1141038567) + smethod_4(float_0, float_1, float_2) + Class185.smethod_0(-1141038572) + float_3.ToString(Class185.smethod_0(-1141274464), CultureInfo.InvariantCulture) + Class185.smethod_0(-1141038592) + float_4.ToString(Class185.smethod_0(-1141274464), CultureInfo.InvariantCulture) + Class185.smethod_0(-1141035535) + class31_0.long_0.ToString(CultureInfo.InvariantCulture);
		}
		return Class185.smethod_0(-1141038431);
	}

	private static string smethod_4(float float_0, float float_1, float float_2)
	{
		return Class185.smethod_0(-1141114314) + float_0.ToString(Class185.smethod_0(-1141274464), CultureInfo.InvariantCulture) + Class185.smethod_0(-1141326297) + float_1.ToString(Class185.smethod_0(-1141274464), CultureInfo.InvariantCulture) + Class185.smethod_0(-1141326297) + float_2.ToString(Class185.smethod_0(-1141274464), CultureInfo.InvariantCulture) + Class185.smethod_0(-1141308401);
	}

	private static string smethod_5(string string_0)
	{
		return (string_0 ?? string.Empty).Replace(Class185.smethod_0(-1141304355), Class185.smethod_0(-1141298972));
	}

	private static string smethod_6(bool bool_0, byte byte_0, ushort ushort_0)
	{
		if (bool_0)
		{
			if (ushort_0 != 0)
			{
				return byte_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141297577) + ushort_0.ToString(CultureInfo.InvariantCulture);
			}
			return Class185.smethod_0(-1141037869);
		}
		return Class185.smethod_0(-1141221057);
	}
}
