using System;
using System.Collections.Generic;
using System.Globalization;

internal static class Class81
{
	internal enum Enum4
	{

	}

	internal static bool smethod_0(long long_0, long long_1)
	{
		if (long_0 < 0L)
		{
			return true;
		}
		return long_1 - long_0 >= 500L;
	}

	internal static bool smethod_1(int int_0, string string_0, int int_1, string string_1)
	{
		if (int_0 != int_1)
		{
			return true;
		}
		return !string.Equals(string_0 ?? string.Empty, string_1 ?? string.Empty, StringComparison.Ordinal);
	}

	internal static Enum4 smethod_2(bool bool_0, string string_0, string string_1, long long_0)
	{
		bool flag = !string.IsNullOrEmpty(string_1);
		bool flag2 = long_0 >= 12000L;
		if (!bool_0)
		{
			if (flag2)
			{
				if (!flag)
				{
					return (Enum4)4;
				}
				return (Enum4)3;
			}
			return (Enum4)0;
		}
		if (flag)
		{
			return (Enum4)3;
		}
		if (string.Equals(string_0, Class185.smethod_0(-1141305020), StringComparison.Ordinal))
		{
			return (Enum4)1;
		}
		if (string.Equals(string_0, Class185.smethod_0(-1141144254), StringComparison.Ordinal))
		{
			return (Enum4)2;
		}
		if (flag2)
		{
			return (Enum4)4;
		}
		return (Enum4)0;
	}

	internal static string smethod_3(long long_0)
	{
		long num = 12000L - long_0;
		if (num < 0L)
		{
			num = 0L;
		}
		long num2 = (num + 999L) / 1000L;
		return Class185.smethod_0(-1141038623) + num2.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141038663);
	}

	internal static bool smethod_4(Struct140 struct140_0)
	{
		if (struct140_0.string_0 != null)
		{
			return struct140_0.string_0.Trim().Length != 0;
		}
		return false;
	}

	internal static string smethod_5(Struct140 struct140_0)
	{
		if (!smethod_4(struct140_0))
		{
			return Class185.smethod_0(-1141127874);
		}
		return struct140_0.string_0;
	}

	internal static string smethod_6(Struct140 struct140_0)
	{
		return struct140_0.int_0.ToString(CultureInfo.InvariantCulture);
	}

	internal static string smethod_7(Struct140 struct140_0)
	{
		if (struct140_0.sbyte_0 == -1)
		{
			return Class185.smethod_0(-1141121791);
		}
		if (struct140_0.sbyte_0 == 0)
		{
			return Class185.smethod_0(-1141119300);
		}
		if (struct140_0.sbyte_0 == 1)
		{
			return Class185.smethod_0(-1141121149);
		}
		if (struct140_0.sbyte_0 == 2)
		{
			return Class185.smethod_0(-1141122889);
		}
		return struct140_0.sbyte_0.ToString(CultureInfo.InvariantCulture);
	}

	internal static string smethod_8(Struct140 struct140_0)
	{
		if (!struct140_0.bool_1)
		{
			return Class185.smethod_0(-1141122606);
		}
		if (!struct140_0.bool_0)
		{
			return Class185.smethod_0(-1141121525);
		}
		return Class185.smethod_0(-1141121832);
	}

	internal static string smethod_9(Struct140 struct140_0)
	{
		return struct140_0.byte_0.ToString(CultureInfo.InvariantCulture);
	}

	internal static string smethod_10(Struct140 struct140_0)
	{
		return struct140_0.ushort_0.ToString(CultureInfo.InvariantCulture);
	}

	internal static string smethod_11(Struct140 struct140_0)
	{
		return struct140_0.byte_1.ToString(CultureInfo.InvariantCulture);
	}

	internal static string smethod_12(Struct140 struct140_0)
	{
		if (struct140_0.byte_2 == 0)
		{
			return Class185.smethod_0(-1141123022);
		}
		if (struct140_0.byte_2 == 1)
		{
			return Class185.smethod_0(-1141121307);
		}
		if (struct140_0.byte_2 == 2)
		{
			return Class185.smethod_0(-1141122059);
		}
		return struct140_0.byte_2.ToString(CultureInfo.InvariantCulture);
	}

	internal static string[] smethod_13(Struct140 struct140_0)
	{
		return new string[8]
		{
			smethod_5(struct140_0),
			smethod_6(struct140_0),
			smethod_7(struct140_0),
			smethod_8(struct140_0),
			smethod_9(struct140_0),
			smethod_10(struct140_0),
			smethod_11(struct140_0),
			smethod_12(struct140_0)
		};
	}

	internal static string[] smethod_14()
	{
		return new string[8]
		{
			Class185.smethod_0(-1141298782),
			Class185.smethod_0(-1141121746),
			Class185.smethod_0(-1141121791),
			Class185.smethod_0(-1141121832),
			Class185.smethod_0(-1141121867),
			Class185.smethod_0(-1141121912),
			Class185.smethod_0(-1141121952),
			Class185.smethod_0(-1141121985)
		};
	}

	internal static int smethod_15(IReadOnlyList<Struct140> ireadOnlyList_0)
	{
		if (ireadOnlyList_0 == null)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < ireadOnlyList_0.Count; i++)
		{
			if (smethod_4(ireadOnlyList_0[i]))
			{
				num++;
			}
		}
		return num;
	}

	internal static string smethod_16(int int_0)
	{
		if (int_0 <= 0)
		{
			return string.Empty;
		}
		return Class185.smethod_0(-1141270620) + int_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141038668);
	}
}
