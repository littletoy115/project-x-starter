using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

internal static class Class409
{
	internal struct Struct125
	{
		public int int_0;

		public int int_1;

		public ushort ushort_0;

		public ushort ushort_1;
	}

	internal static string smethod_0(ushort ushort_0, IReadOnlyList<Struct125> ireadOnlyList_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class185.smethod_0(-1141031457));
		stringBuilder.Append(ushort_0.ToString(CultureInfo.InvariantCulture)).Append(Class185.smethod_0(-1141031484));
		int num = ireadOnlyList_0?.Count ?? 0;
		for (int i = 0; i < num; i++)
		{
			if (i != 0)
			{
				stringBuilder.Append(',');
			}
			Struct125 @struct = ireadOnlyList_0[i];
			stringBuilder.Append(Class185.smethod_0(-1141031509)).Append(@struct.int_0.ToString(CultureInfo.InvariantCulture)).Append(Class185.smethod_0(-1141031516))
				.Append(@struct.int_1.ToString(CultureInfo.InvariantCulture))
				.Append(Class185.smethod_0(-1141181928))
				.Append(@struct.ushort_0.ToString(CultureInfo.InvariantCulture))
				.Append(Class185.smethod_0(-1141181943))
				.Append(@struct.ushort_1.ToString(CultureInfo.InvariantCulture))
				.Append('}');
		}
		return stringBuilder.Append(Class185.smethod_0(-1141156722)).ToString();
	}

	internal static bool smethod_1(string string_0)
	{
		if (string.Equals(string_0, Class185.smethod_0(-1141192789), StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}

	internal static bool smethod_2(string string_0)
	{
		if (string.Equals(string_0, Class185.smethod_0(-1141112980), StringComparison.Ordinal))
		{
			return true;
		}
		if (string.Equals(string_0, Class185.smethod_0(-1141173131), StringComparison.Ordinal))
		{
			return true;
		}
		if (string.Equals(string_0, Class185.smethod_0(-1141192796), StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
