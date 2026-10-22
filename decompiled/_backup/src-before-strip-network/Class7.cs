using System;
using System.Globalization;

internal static class Class7
{
	internal static string smethod_0(uint uint_0, int int_0, ushort ushort_0, ushort ushort_1, int int_1, ushort ushort_2, ushort ushort_3)
	{
		smethod_3(uint_0);
		smethod_4(int_0);
		smethod_4(int_1);
		return "{\"cmd\":\"pet\",\"action\":\"feed\",\"req\":" + smethod_5(uint_0) + ",\"foodSlot\":" + smethod_6(int_0) + ",\"foodMain\":" + smethod_6(ushort_0) + ",\"foodSub\":" + smethod_6(ushort_1) + ",\"cardSlot\":" + smethod_6(int_1) + ",\"cardMain\":" + smethod_6(ushort_2) + ",\"cardSub\":" + smethod_6(ushort_3) + "}";
	}

	internal static string smethod_1(uint uint_0, int int_0, ushort ushort_0, ushort ushort_1)
	{
		smethod_3(uint_0);
		smethod_4(int_0);
		return "{\"cmd\":\"pet\",\"action\":\"summon\",\"req\":" + smethod_5(uint_0) + ",\"cardSlot\":" + smethod_6(int_0) + ",\"cardMain\":" + smethod_6(ushort_0) + ",\"cardSub\":" + smethod_6(ushort_1) + "}";
	}

	internal static string smethod_2(uint uint_0)
	{
		smethod_3(uint_0);
		return "{\"cmd\":\"pet\",\"action\":\"dismiss\",\"req\":" + smethod_5(uint_0) + "}";
	}

	private static void smethod_3(uint uint_0)
	{
		if (uint_0 == 0)
		{
			throw new ArgumentOutOfRangeException("\u000e");
		}
	}

	private static void smethod_4(int int_0)
	{
		if (int_0 < 0 || int_0 > 65535)
		{
			throw new ArgumentOutOfRangeException("\u000e");
		}
	}

	private static string smethod_5(uint uint_0)
	{
		return uint_0.ToString(CultureInfo.InvariantCulture);
	}

	private static string smethod_6(int int_0)
	{
		return int_0.ToString(CultureInfo.InvariantCulture);
	}
}
