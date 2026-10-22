using System;
using System.Globalization;

internal static class Class344
{
	internal static string smethod_0(Enum13 enum13_0, uint uint_0)
	{
		if (uint_0 == 0)
		{
			throw new ArgumentOutOfRangeException("requestToken");
		}
		return "{\"cmd\":\"rebirth\",\"mode\":\"" + smethod_1(enum13_0) + "\",\"req\":" + uint_0.ToString(CultureInfo.InvariantCulture) + "}";
	}

	internal static string smethod_1(Enum13 enum13_0)
	{
		return enum13_0 switch
		{
			(Enum13)0 => "normal", 
			(Enum13)1 => "withneck", 
			(Enum13)2 => "auto", 
			_ => throw new ArgumentOutOfRangeException("mode"), 
		};
	}
}
