using System;
using System.Globalization;

internal static class Class43
{
	internal static string smethod_0(uint uint_0, string string_0, uint uint_1)
	{
		if (uint_0 == 0)
		{
			throw new ArgumentOutOfRangeException("\u000e");
		}
		if (!string.IsNullOrEmpty(string_0) && string_0.Length <= 8)
		{
			if (uint_1 == 0)
			{
				throw new ArgumentOutOfRangeException("\u0006");
			}
			return "{\"cmd\":\"challenge_answer\",\"challengeId\":" + uint_0.ToString(CultureInfo.InvariantCulture) + ",\"answer\":\"" + string_0 + "\",\"req\":" + uint_1.ToString(CultureInfo.InvariantCulture) + "}";
		}
		throw new ArgumentOutOfRangeException("\u0003");
	}
}
