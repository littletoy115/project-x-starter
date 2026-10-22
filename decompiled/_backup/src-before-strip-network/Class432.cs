using System.Drawing;
using System.Globalization;

internal static class Class432
{
	internal static readonly Color color_0 = Color.White;

	internal static readonly Color color_1 = Class96.color_0;

	internal static readonly Color color_2 = Color.Gainsboro;

	internal static readonly Color color_3 = Color.Gold;

	internal static int smethod_0(int int_0)
	{
		return 3 + int_0 % 6 * 97;
	}

	internal static int smethod_1(int int_0)
	{
		return 3 + int_0 / 6 * 56;
	}

	internal static bool smethod_2(int int_0, int int_1)
	{
		if (int_1 <= 0)
		{
			return false;
		}
		return int_0 >= int_1;
	}

	internal static Color smethod_3(Color color_4, Color color_5, int int_0)
	{
		if (int_0 <= 0)
		{
			return color_4;
		}
		if (int_0 >= 255)
		{
			return color_5;
		}
		int num = 255 - int_0;
		int red = (color_5.R * int_0 + color_4.R * num + 127) / 255;
		int green = (color_5.G * int_0 + color_4.G * num + 127) / 255;
		int blue = (color_5.B * int_0 + color_4.B * num + 127) / 255;
		return Color.FromArgb(red, green, blue);
	}

	internal static Color smethod_4(bool bool_0, bool bool_1, bool bool_2)
	{
		if (bool_1)
		{
			return color_2;
		}
		Color color = (bool_0 ? color_1 : color_0);
		if (!bool_2)
		{
			return color;
		}
		return smethod_3(color, color_3, 96);
	}

	internal static int smethod_5(Class145 class145_0, string[] string_0, string[] string_1)
	{
		if (string_0 != null && string_1 != null)
		{
			if (string_0.Length >= 60 && string_1.Length >= 60)
			{
				for (int i = 0; i < 60; i++)
				{
					string_0[i] = string.Empty;
					string_1[i] = string.Empty;
				}
				if (class145_0 == null)
				{
					return 0;
				}
				string text = class145_0.method_51();
				if (text != null && text.Length != 0)
				{
					return 0;
				}
				Class95 class95_ = class145_0.method_10();
				int num = 0;
				for (int j = 0; j < class145_0.method_39().Count; j++)
				{
					Struct27 @struct = class145_0.method_39()[j];
					if (@struct.int_0 >= 0 && @struct.int_0 < 60)
					{
						string_0[@struct.int_0] = Class16.smethod_5(class95_, @struct.ushort_0, @struct.ushort_1);
						string_1[@struct.int_0] = @struct.int_2.ToString(CultureInfo.InvariantCulture);
						num++;
					}
				}
				return num;
			}
			return 0;
		}
		return 0;
	}

	internal static string smethod_6(Class145 class145_0)
	{
		if (class145_0 == null)
		{
			return Class16.smethod_3(null);
		}
		string text = class145_0.method_51();
		if (text != null && text.Length != 0)
		{
			return text;
		}
		return Class16.smethod_3(class145_0);
	}
}
