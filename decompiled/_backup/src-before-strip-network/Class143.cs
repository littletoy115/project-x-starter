using System.Globalization;

internal static class Class143
{
	internal static float smethod_0(int int_0)
	{
		return (float)int_0 / 10f;
	}

	internal static void smethod_1(ref Struct137 struct137_0, int int_0)
	{
		struct137_0.bool_0 = true;
		struct137_0.float_0 = smethod_0(int_0);
		struct137_0.int_0++;
	}

	internal static bool smethod_2(Struct1 struct1_0, Enum0 enum0_0, bool bool_0)
	{
		if (bool_0 && !struct1_0.bool_0)
		{
			if (enum0_0 != Enum0.Selected)
			{
				return enum0_0 == Enum0.Started;
			}
			return true;
		}
		return false;
	}

	internal static void smethod_3(ref Struct1 struct1_0)
	{
		struct1_0.bool_0 = true;
	}

	internal static void smethod_4(ref Struct1 struct1_0, Class400 class400_0)
	{
		if (class400_0 == null)
		{
			return;
		}
		struct1_0.bool_1 = class400_0.bool_0;
		struct1_0.bool_2 = class400_0.bool_1;
		if (class400_0.bool_0 && class400_0.bool_1)
		{
			if (class400_0.nullable_0.HasValue)
			{
				struct1_0.nullable_0 = class400_0.nullable_0;
			}
		}
		else
		{
			struct1_0.nullable_0 = null;
		}
	}

	internal static Struct17 smethod_5(Struct137 struct137_0, Struct1 struct1_0, Enum0 enum0_0, bool bool_0)
	{
		if (bool_0 && struct137_0.bool_0 && struct1_0.uint_0 == 0 && struct1_0.int_0 != struct137_0.int_0 && (enum0_0 == Enum0.Selected || enum0_0 == Enum0.Started))
		{
			return new Struct17
			{
				bool_0 = true,
				float_0 = struct137_0.float_0,
				int_0 = struct137_0.int_0
			};
		}
		return default(Struct17);
	}

	internal static void smethod_6(ref Struct1 struct1_0, Struct17 struct17_0, uint uint_0, long long_0)
	{
		struct1_0.uint_0 = uint_0;
		struct1_0.long_0 = long_0;
		struct1_0.int_0 = struct17_0.int_0;
	}

	internal static void smethod_7(ref Struct1 struct1_0)
	{
		struct1_0.uint_0 = 0u;
	}

	internal static bool smethod_8(ref Struct1 struct1_0, long long_0)
	{
		if (struct1_0.uint_0 != 0 && long_0 >= struct1_0.long_0 && long_0 - struct1_0.long_0 >= 2000L)
		{
			struct1_0.uint_0 = 0u;
			return true;
		}
		return false;
	}

	internal static bool smethod_9(ref Struct1 struct1_0, Class101 class101_0)
	{
		if (class101_0 != null && class101_0.uint_0 != 0 && class101_0.uint_0 == struct1_0.uint_0)
		{
			struct1_0.uint_0 = 0u;
			struct1_0.nullable_0 = (class101_0.bool_0 ? class101_0.nullable_0 : ((float?)null));
			return true;
		}
		return false;
	}

	internal static bool smethod_10(ref Struct1 struct1_0, Class101 class101_0)
	{
		if (class101_0 != null && class101_0.uint_0 == 0 && class101_0.bool_0 && class101_0.nullable_0.HasValue)
		{
			struct1_0.bool_1 = class101_0.bool_1;
			struct1_0.bool_2 = class101_0.bool_1;
			struct1_0.nullable_0 = class101_0.nullable_0;
			return true;
		}
		return false;
	}

	internal static string smethod_11(float? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			return "Zoom --";
		}
		return "Zoom " + nullable_0.Value.ToString("0.0###", CultureInfo.InvariantCulture) + "x";
	}

	internal static void smethod_12(ref Struct1 struct1_0)
	{
		int int_ = struct1_0.int_0;
		struct1_0 = new Struct1
		{
			int_0 = int_
		};
	}
}
