using System;
using System.Globalization;

internal sealed class Class85
{
	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal int int_1;

	internal string string_2;

	internal bool bool_0;

	internal static Class85 smethod_0(Class34 class34_0, string string_3)
	{
		if (class34_0 == null)
		{
			return null;
		}
		return new Class85
		{
			string_0 = class34_0.string_0,
			string_1 = class34_0.string_1,
			int_0 = smethod_1(class34_0.string_1),
			int_1 = class34_0.int_2,
			bool_0 = class34_0.bool_0,
			string_2 = string_3
		};
	}

	internal static int smethod_1(string string_3)
	{
		if (string.IsNullOrEmpty(string_3))
		{
			return 0;
		}
		if (!string_3.StartsWith("emulator-", StringComparison.OrdinalIgnoreCase))
		{
			return 0;
		}
		if (!int.TryParse(string_3.Substring(9), NumberStyles.None, CultureInfo.InvariantCulture, out var result))
		{
			return 0;
		}
		if (result > 0)
		{
			return result + 1;
		}
		return 0;
	}

	public override string ToString()
	{
		string text;
		if (int_0 <= 0)
		{
			text = string_1;
			if (text == null)
			{
				return string.Empty;
			}
		}
		else
		{
			text = int_0.ToString(CultureInfo.InvariantCulture);
		}
		return text;
	}
}
