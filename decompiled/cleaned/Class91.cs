using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

internal static class Class91
{
	internal static readonly Color color_0 = Color.FromArgb(192, 255, 192);

	internal static readonly Color color_1 = Color.FromArgb(255, 192, 192);

	internal static int smethod_0(int int_0)
	{
		return 15 + int_0;
	}

	internal static int smethod_1(int int_0)
	{
		if (int_0 <= 6)
		{
			return 25 + int_0;
		}
		return 20;
	}

	internal static int smethod_2(int int_0)
	{
		if (int_0 <= 6)
		{
			return 13 + int_0;
		}
		return 29;
	}

	internal static (string, Color) smethod_3(bool bool_0, (ushort, ushort)[] valueTuple_0, int int_0, IReadOnlyList<GStruct3> ireadOnlyList_0, string string_0)
	{
		if (!bool_0)
		{
			return (Class185.smethod_0(-1141296459), Color.Empty);
		}
		if (valueTuple_0 == null)
		{
			return (Class185.smethod_0(-1141296459), Color.Empty);
		}
		if (int_0 >= 1 && int_0 <= 7)
		{
			if (int_0 > valueTuple_0.Length)
			{
				return (Class185.smethod_0(-1141296459), Color.Empty);
			}
			ushort item = valueTuple_0[int_0 - 1].Item1;
			ushort item2 = valueTuple_0[int_0 - 1].Item2;
			if (item != ushort.MaxValue && item2 != ushort.MaxValue)
			{
				if (ireadOnlyList_0 == null)
				{
					return (Class185.smethod_0(-1141274464), color_1);
				}
				bool flag = false;
				float num = 0f;
				for (int i = 0; i < ireadOnlyList_0.Count; i++)
				{
					if (!ireadOnlyList_0[i].bool_0 && ireadOnlyList_0[i].ushort_0 == item && ireadOnlyList_0[i].ushort_1 == item2)
					{
						flag = true;
						num = ireadOnlyList_0[i].float_0;
						break;
					}
				}
				if (!flag)
				{
					return (Class185.smethod_0(-1141274464), color_1);
				}
				if (!int.TryParse((string_0 ?? string.Empty).Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
				{
					result = 0;
				}
				string item3 = num.ToString(Class185.smethod_0(-1141277503), CultureInfo.InvariantCulture);
				if (num > (float)result)
				{
					return (item3, color_0);
				}
				return (item3, color_1);
			}
			return (Class185.smethod_0(-1141296459), Color.Empty);
		}
		return (Class185.smethod_0(-1141296459), Color.Empty);
	}

	internal static string smethod_4(GStruct4 gstruct4_0)
	{
		if (gstruct4_0.byte_0 == 0)
		{
			return Class185.smethod_0(-1141306264);
		}
		string text = Class185.smethod_0(-1141274433);
		if (gstruct4_0.float_1 >= 0f)
		{
			text = ((int)Math.Floor(gstruct4_0.float_1)).ToString(CultureInfo.InvariantCulture);
		}
		return Class185.smethod_0(-1141037212) + smethod_5(gstruct4_0.byte_0) + Class185.smethod_0(-1141299597) + text + Class185.smethod_0(-1141253640);
	}

	internal static string smethod_5(byte byte_0)
	{
		return byte_0 switch
		{
			1 => Class185.smethod_0(-1141037247), 
			2 => Class185.smethod_0(-1141306135), 
			3 => Class185.smethod_0(-1141037261), 
			4 => Class185.smethod_0(-1141037268), 
			6 => Class185.smethod_0(-1141306046), 
			9 => Class185.smethod_0(-1141037288), 
			10 => Class185.smethod_0(-1141037304), 
			11 => Class185.smethod_0(-1141037318), 
			13 => Class185.smethod_0(-1141037335), 
			_ => Class185.smethod_0(-1141037338) + byte_0.ToString(CultureInfo.InvariantCulture), 
		};
	}

	internal static bool smethod_6(long long_0, long long_1)
	{
		if (long_0 < 0L)
		{
			return true;
		}
		return long_1 - long_0 >= 10000L;
	}

	internal static bool smethod_7(bool bool_0, bool bool_1, bool bool_2, bool bool_3)
	{
		if (!bool_0)
		{
			return false;
		}
		if (!bool_1)
		{
			return false;
		}
		if (!bool_2)
		{
			return false;
		}
		if (bool_3)
		{
			return false;
		}
		return true;
	}

	internal static bool smethod_8(bool bool_0, (ushort, ushort)[] valueTuple_0, int int_0, long long_0, long long_1)
	{
		if (!bool_0)
		{
			return false;
		}
		if (valueTuple_0 == null)
		{
			return false;
		}
		if (int_0 == 0)
		{
			return false;
		}
		if (long_0 < 0L)
		{
			return true;
		}
		return long_1 - long_0 >= 500L;
	}

	internal static List<(ushort, ushort)> smethod_9(bool[] bool_0, (ushort, ushort)[] valueTuple_0)
	{
		List<(ushort, ushort)> list = new List<(ushort, ushort)>();
		if (valueTuple_0 == null)
		{
			return list;
		}
		for (int i = 1; i <= 10 && i < bool_0.Length; i++)
		{
			if (bool_0[i] && i <= valueTuple_0.Length && valueTuple_0[i - 1].Item1 != ushort.MaxValue && valueTuple_0[i - 1].Item2 != ushort.MaxValue)
			{
				list.Add(valueTuple_0[i - 1]);
			}
		}
		return list;
	}

	internal static void smethod_10(GForm0 gform0_0, Class145 class145_0, (ushort, ushort)[] valueTuple_0)
	{
		for (int i = 1; i <= 7; i++)
		{
			(string, Color) tuple = smethod_3(gform0_0.smethod_21(smethod_0(i)), string_0: gform0_0.smethod_22(smethod_1(i)), valueTuple_0: valueTuple_0, int_0: i, ireadOnlyList_0: class145_0.method_12());
			gform0_0.smethod_27(smethod_2(i), tuple.Item1, tuple.Item2);
		}
		gform0_0.smethod_25(13, smethod_4(class145_0.method_22()));
	}

	internal static (string, Color) smethod_11(bool bool_0, long long_0, long long_1, string string_0)
	{
		if (!bool_0)
		{
			return (Class185.smethod_0(-1141296459), Color.Empty);
		}
		if (long_0 < 0L)
		{
			return (Class185.smethod_0(-1141274464), color_1);
		}
		double num = (double)Class342.smethod_33(string_0) - (double)(long_1 - long_0) / 1000.0;
		if (num <= 0.0)
		{
			return (Class185.smethod_0(-1141274464), color_1);
		}
		return (num.ToString(Class185.smethod_0(-1141277503), CultureInfo.InvariantCulture), color_0);
	}

	internal static void smethod_12(GForm0 gform0_0, long long_0, long long_1)
	{
		bool bool_ = gform0_0.smethod_21(smethod_0(8));
		string string_ = gform0_0.smethod_22(21);
		(string, Color) tuple = smethod_11(bool_, long_0, long_1, string_);
		gform0_0.smethod_27(30, tuple.Item1, tuple.Item2);
	}
}
