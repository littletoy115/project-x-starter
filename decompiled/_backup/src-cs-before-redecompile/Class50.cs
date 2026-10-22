using System;
using System.Linq;

internal sealed class Class50
{
	[Serializable]
	private sealed class Class51
	{
		public static readonly Class51 class51_0 = new Class51();

		public static Func<char, bool> func_0;

		public static Func<char, bool> func_1;

		internal bool method_0(char char_0)
		{
			if (char_0 >= '0')
			{
				return char_0 <= '9';
			}
			return false;
		}

		internal bool method_1(char char_0)
		{
			return !char.IsWhiteSpace(char_0);
		}
	}

	private string string_0;

	private double double_0;

	private int int_0;

	private string string_1;

	internal string method_0()
	{
		return string_0;
	}

	internal void method_1(string string_2)
	{
		string_0 = string_2;
	}

	internal double method_2()
	{
		return double_0;
	}

	internal void method_3(double double_1)
	{
		double_0 = double_1;
	}

	internal int method_4()
	{
		return int_0;
	}

	internal void method_5(int int_1)
	{
		int_0 = int_1;
	}

	internal string method_6()
	{
		return string_1;
	}

	internal void method_7(string string_2)
	{
		string_1 = string_2;
	}

	internal string method_8()
	{
		if (string.IsNullOrEmpty(method_0()))
		{
			return null;
		}
		string text = new string(method_0().Where(Class51.class51_0.method_0).ToArray());
		if (text.Length != 0 && text.Length <= 8)
		{
			if (!(new string(method_0().Where(Class51.class51_0.method_1).ToArray()) == text))
			{
				return null;
			}
			return text;
		}
		return null;
	}
}
