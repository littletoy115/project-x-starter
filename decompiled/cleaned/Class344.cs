using System;
using System.Globalization;

internal static class Class344
{
	internal static string smethod_0(Enum13 enum13_0, uint uint_0)
	{
		if (uint_0 == 0)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(-1141192670));
		}
		return Class185.smethod_0(-1141192673) + smethod_1(enum13_0) + Class185.smethod_0(-1141180750) + uint_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141174659);
	}

	internal static string smethod_1(Enum13 enum13_0)
	{
		return enum13_0 switch
		{
			(Enum13)0 => Class185.smethod_0(-1141191681), 
			(Enum13)1 => Class185.smethod_0(-1141211659), 
			(Enum13)2 => Class185.smethod_0(-1141214304), 
			_ => throw new ArgumentOutOfRangeException(Class185.smethod_0(-1141191702)), 
		};
	}
}
