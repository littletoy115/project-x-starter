using System;
using System.Globalization;

internal static class Class43
{
	internal static string smethod_0(uint uint_0, string string_0, uint uint_1)
	{
		if (uint_0 == 0)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(-1141180644));
		}
		if (!string.IsNullOrEmpty(string_0) && string_0.Length <= 8)
		{
			if (uint_1 == 0)
			{
				throw new ArgumentOutOfRangeException(Class185.smethod_0(-1141180666));
			}
			return Class185.smethod_0(-1141180685) + uint_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141180724) + string_0 + Class185.smethod_0(-1141180750) + uint_1.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141174659);
		}
		throw new ArgumentOutOfRangeException(Class185.smethod_0(-1141180663));
	}
}
