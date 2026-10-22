using System.Collections.Generic;
using System.Globalization;
using System.Text;

internal static class Class454
{
	internal static string smethod_0(IEnumerable<int> ienumerable_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class185.smethod_0(-1141031584));
		bool flag = true;
		if (ienumerable_0 != null)
		{
			foreach (int item in ienumerable_0)
			{
				if (!flag)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append(smethod_7(item));
				flag = false;
			}
		}
		stringBuilder.Append(Class185.smethod_0(-1141156722));
		return stringBuilder.ToString();
	}

	internal static string smethod_1(IEnumerable<int> ienumerable_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class185.smethod_0(-1141031615));
		bool flag = true;
		if (ienumerable_0 != null)
		{
			foreach (int item in ienumerable_0)
			{
				if (!flag)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append(smethod_7(item));
				flag = false;
			}
		}
		stringBuilder.Append(Class185.smethod_0(-1141156722));
		return stringBuilder.ToString();
	}

	internal static string smethod_2()
	{
		return Class185.smethod_0(-1141031644);
	}

	internal static string smethod_3()
	{
		return Class185.smethod_0(-1141031678);
	}

	internal static string smethod_4(int int_0)
	{
		return Class185.smethod_0(-1141031699) + smethod_7(int_0) + Class185.smethod_0(-1141174659);
	}

	internal static string smethod_5(int int_0, ushort ushort_0, ushort ushort_1)
	{
		return Class185.smethod_0(-1141031743) + smethod_7(int_0) + Class185.smethod_0(-1141181928) + smethod_7(ushort_0) + Class185.smethod_0(-1141181943) + smethod_7(ushort_1) + Class185.smethod_0(-1141174659);
	}

	internal static string smethod_6(IList<(ushort, ushort)> ilist_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class185.smethod_0(-1141031776));
		if (ilist_0 != null)
		{
			for (int i = 0; i < ilist_0.Count && i < 10; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append('[').Append(smethod_7(ilist_0[i].Item1)).Append(',')
					.Append(smethod_7(ilist_0[i].Item2))
					.Append(']');
			}
		}
		stringBuilder.Append(Class185.smethod_0(-1141156722));
		return stringBuilder.ToString();
	}

	private static string smethod_7(int int_0)
	{
		return int_0.ToString(CultureInfo.InvariantCulture);
	}
}
