using System.Collections.Generic;
using System.Globalization;

internal sealed class Class4
{
	private int int_0;

	private int int_1;

	internal static string smethod_0(int int_2)
	{
		return Class185.smethod_0(-1141036878) + int_2.ToString(CultureInfo.InvariantCulture);
	}

	internal static string smethod_1(int int_2)
	{
		return Class185.smethod_0(-1141036887) + int_2.ToString(CultureInfo.InvariantCulture);
	}

	internal int method_0()
	{
		return int_1 - int_0;
	}

	internal int method_1()
	{
		if (int_1 - int_0 <= 0)
		{
			return 0;
		}
		return int_1 - int_0 - 1;
	}

	internal Struct78 method_2(bool bool_0, int int_2, int int_3)
	{
		int num;
		int num2;
		if (bool_0 && int_2 > 0)
		{
			num = int_3 - 1;
			if (num < 0)
			{
				num = 0;
			}
			if (num > int_2)
			{
				num = int_2;
			}
			num2 = num + 24;
			if (num2 > int_2)
			{
				num2 = int_2;
			}
		}
		else
		{
			num2 = 0;
			num = 0;
		}
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		List<int> list3 = new List<int>();
		List<int> list4 = new List<int>();
		for (int i = int_0; i < int_1; i++)
		{
			if (i < num || i >= num2)
			{
				list2.Add(i);
			}
		}
		for (int j = num; j < num2; j++)
		{
			if (j < int_0 || j >= int_1)
			{
				list.Add(j);
			}
		}
		int num3 = ((num2 > num) ? (num2 - 1) : num);
		int num4 = ((int_1 > int_0) ? (int_1 - 1) : int_0);
		for (int k = int_0; k < num4; k++)
		{
			if (k < num || k >= num3)
			{
				list4.Add(k);
			}
		}
		for (int l = num; l < num3; l++)
		{
			if (l < int_0 || l >= num4)
			{
				list3.Add(l);
			}
		}
		int_0 = num;
		int_1 = num2;
		return new Struct78
		{
			int_0 = list.ToArray(),
			int_1 = list2.ToArray(),
			int_2 = list3.ToArray(),
			int_3 = list4.ToArray()
		};
	}

	internal void method_3()
	{
		int_1 = 0;
		int_0 = 0;
	}
}
