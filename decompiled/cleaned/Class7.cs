using System;
using System.Globalization;

internal static class Class7
{
	internal static string smethod_0(uint uint_0, int int_0, ushort ushort_0, ushort ushort_1, int int_1, ushort ushort_2, ushort ushort_3)
	{
		smethod_3(uint_0);
		smethod_4(int_0);
		smethod_4(int_1);
		return Class185.smethod_0(-1141191420) + smethod_5(uint_0) + Class185.smethod_0(-1141191470) + smethod_6(int_0) + Class185.smethod_0(-1141191481) + smethod_6(ushort_0) + Class185.smethod_0(-1141191500) + smethod_6(ushort_1) + Class185.smethod_0(-1141191526) + smethod_6(int_1) + Class185.smethod_0(-1141191537) + smethod_6(ushort_2) + Class185.smethod_0(-1141191556) + smethod_6(ushort_3) + Class185.smethod_0(-1141174659);
	}

	internal static string smethod_1(uint uint_0, int int_0, ushort ushort_0, ushort ushort_1)
	{
		smethod_3(uint_0);
		smethod_4(int_0);
		return Class185.smethod_0(-1141191582) + smethod_5(uint_0) + Class185.smethod_0(-1141191526) + smethod_6(int_0) + Class185.smethod_0(-1141191537) + smethod_6(ushort_0) + Class185.smethod_0(-1141191556) + smethod_6(ushort_1) + Class185.smethod_0(-1141174659);
	}

	internal static string smethod_2(uint uint_0)
	{
		smethod_3(uint_0);
		return Class185.smethod_0(-1141191618) + smethod_5(uint_0) + Class185.smethod_0(-1141174659);
	}

	private static void smethod_3(uint uint_0)
	{
		if (uint_0 == 0)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(-1141191671));
		}
	}

	private static void smethod_4(int int_0)
	{
		if (int_0 < 0 || int_0 > 65535)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(-1141191674));
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
