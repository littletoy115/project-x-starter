using System.Globalization;

internal static class Class178
{
	internal static string smethod_0(int int_0, int int_1)
	{
		return Class185.smethod_0(-1141208995) + smethod_4(int_0) + Class185.smethod_0(-1141209035) + smethod_4(int_1) + Class185.smethod_0(-1141174659);
	}

	internal static string smethod_1()
	{
		return Class185.smethod_0(-1141172698);
	}

	internal static string smethod_2(float float_0, uint uint_0)
	{
		return Class185.smethod_0(-1141209063) + smethod_6(float_0) + Class185.smethod_0(-1141208071) + smethod_5(uint_0) + Class185.smethod_0(-1141174659);
	}

	internal static string smethod_3()
	{
		return Class185.smethod_0(-1141238363);
	}

	private static string smethod_4(int int_0)
	{
		return int_0.ToString(CultureInfo.InvariantCulture);
	}

	private static string smethod_5(uint uint_0)
	{
		return uint_0.ToString(CultureInfo.InvariantCulture);
	}

	private static string smethod_6(float float_0)
	{
		return float_0.ToString(Class185.smethod_0(-1141317570), CultureInfo.InvariantCulture);
	}
}
