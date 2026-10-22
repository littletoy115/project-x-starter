using System.Collections.Generic;
using System.Globalization;
using System.Text;

internal static class Class454
{
	internal static string smethod_0(IEnumerable<int> ienumerable_0)
	{
		StringBuilder stringBuilder = new StringBuilder("{\"cmd\":\"skill\",\"slots\":[");
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
		stringBuilder.Append("]}");
		return stringBuilder.ToString();
	}

	internal static string smethod_1(IEnumerable<int> ienumerable_0)
	{
		StringBuilder stringBuilder = new StringBuilder("{\"cmd\":\"skill_check\",\"slots\":[");
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
		stringBuilder.Append("]}");
		return stringBuilder.ToString();
	}

	internal static string smethod_2()
	{
		return "{\"cmd\":\"skill_bar\"}";
	}

	internal static string smethod_3()
	{
		return "{\"cmd\":\"skill_status\"}";
	}

	internal static string smethod_4(int int_0)
	{
		return "{\"cmd\":\"skill_tab_ids\",\"tab\":" + smethod_7(int_0) + "}";
	}

	internal static string smethod_5(int int_0, ushort ushort_0, ushort ushort_1)
	{
		return "{\"cmd\":\"buff_cast\",\"slot\":" + smethod_7(int_0) + ",\"main\":" + smethod_7(ushort_0) + ",\"sub\":" + smethod_7(ushort_1) + "}";
	}

	internal static string smethod_6(IList<(ushort, ushort)> ilist_0)
	{
		StringBuilder stringBuilder = new StringBuilder("{\"cmd\":\"skill_ready\",\"ids\":[");
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
		stringBuilder.Append("]}");
		return stringBuilder.ToString();
	}

	private static string smethod_7(int int_0)
	{
		return int_0.ToString(CultureInfo.InvariantCulture);
	}
}
