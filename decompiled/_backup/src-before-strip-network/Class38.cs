using System;
using System.Collections.Generic;
using System.Globalization;

internal static class Class38
{
	internal static Class401 smethod_0(Class145 class145_0, string string_0, DateTime dateTime_0)
	{
		if (class145_0 != null && class145_0.method_0() != null && class145_0.method_14() != null && class145_0.method_14().Count != 0 && !string.IsNullOrWhiteSpace(string_0) && class145_0.method_0().long_0 > 0L)
		{
			foreach (Class403 item in class145_0.method_4())
			{
				if (item != null && item.method_2() && item.uint_0 != 0)
				{
					GStruct0 value = default(GStruct0);
					bool flag = class145_0.method_20() != null && class145_0.method_20().TryGetValue(item.uint_0, out value);
					return new Class401
					{
						uint_0 = item.uint_0,
						string_0 = string_0,
						bool_0 = item.method_3(),
						float_0 = class145_0.method_0().float_0,
						float_1 = class145_0.method_0().float_1,
						float_2 = class145_0.method_0().float_2,
						byte_0 = class145_0.method_0().byte_0,
						bool_1 = true,
						byte_1 = (byte)(flag ? value.byte_0 : 0),
						ushort_0 = (ushort)(flag ? value.ushort_0 : 0),
						bool_2 = flag,
						long_0 = dateTime_0.Ticks
					};
				}
			}
			return null;
		}
		return null;
	}

	internal static bool smethod_1(float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, bool bool_0, float float_6, float float_7, out float float_8, out float float_9, out float float_10)
	{
		float num = 0f;
		float_10 = 0f;
		float num2 = num;
		num = 0f;
		float_9 = num2;
		float_8 = num;
		if (smethod_11(float_0) && smethod_11(float_1) && smethod_11(float_2) && smethod_11(float_3) && smethod_11(float_4) && smethod_11(float_5) && smethod_11(float_6) && smethod_11(float_7))
		{
			float num3 = (bool_0 ? Math.Max(2f, float_6) : Math.Max(2f, float_7));
			float num4 = Math.Min(10f, Math.Max(2f, float_6 * 0.25f));
			if (!bool_0)
			{
				num4 = Math.Min(num4, Math.Max(2f, float_7 - 1f));
			}
			float num5 = float_0 - float_3;
			float num6 = float_2 - float_5;
			float num7 = (float)Math.Sqrt(num5 * num5 + num6 * num6);
			if (num7 >= 2f && num7 <= num3 + 1f)
			{
				return false;
			}
			if (num7 < 0.001f)
			{
				num5 = 1f;
				num6 = 0f;
				num7 = 1f;
			}
			if (num7 < 2f)
			{
				num4 = 2f;
			}
			float_8 = float_3 + num5 / num7 * num4;
			float_9 = float_4;
			float_10 = float_5 + num6 / num7 * num4;
			return true;
		}
		return false;
	}

	internal static IReadOnlyList<string> smethod_2(Class145 class145_0)
	{
		List<string> list = new List<string>();
		if (class145_0 != null && class145_0.method_14() != null)
		{
			uint num = 0u;
			foreach (Class403 item in class145_0.method_4())
			{
				if (item != null && item.method_2())
				{
					num = item.uint_0;
					break;
				}
			}
			{
				foreach (uint item2 in class145_0.method_14())
				{
					if (item2 != num && class145_0.method_10().method_4().TryGetValue(item2.ToString(CultureInfo.InvariantCulture), out var value) && !string.IsNullOrWhiteSpace(value) && !list.Contains(value))
					{
						list.Add(value);
					}
				}
				return list;
			}
		}
		return list;
	}

	internal static string smethod_3(Class145 class145_0)
	{
		if (class145_0 != null && class145_0.method_14() != null)
		{
			foreach (Class403 item in class145_0.method_4())
			{
				if (item != null && item.method_3() && smethod_10(class145_0.method_14(), item.uint_0) && class145_0.method_10().method_4().TryGetValue(item.uint_0.ToString(CultureInfo.InvariantCulture), out var value) && !string.IsNullOrWhiteSpace(value))
				{
					return value;
				}
			}
			return null;
		}
		return null;
	}

	internal static bool smethod_4(Class145 class145_0, Class31 class31_0)
	{
		if (class145_0 != null && class31_0 != null && class145_0.method_14() != null && class145_0.method_16() != null && smethod_10(class145_0.method_14(), class31_0.uint_0) && smethod_10(class145_0.method_16(), class31_0.uint_0))
		{
			foreach (Class403 item in class145_0.method_4())
			{
				if (item != null && item.uint_0 == class31_0.uint_0 && !item.method_2())
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	internal static bool smethod_5(Class145 class145_0, Class31 class31_0, int int_0, out Class348 class348_0)
	{
		class348_0 = null;
		if (int_0 >= 0 && smethod_4(class145_0, class31_0))
		{
			class348_0 = new Class348
			{
				uint_0 = class31_0.uint_0,
				float_0 = class31_0.float_0,
				float_1 = class31_0.float_1,
				float_2 = class31_0.float_2,
				int_0 = int_0
			};
			return true;
		}
		return false;
	}

	internal static bool smethod_6(Class403 class403_0, Class31 class31_0, float float_0)
	{
		if (class403_0 != null && class31_0 != null && !class403_0.method_0() && !(float_0 < 0f) && smethod_11(float_0) && smethod_11(class403_0.float_0) && smethod_11(class403_0.float_2) && smethod_11(class31_0.float_0) && smethod_11(class31_0.float_2))
		{
			float num = class403_0.float_0 - class31_0.float_0;
			float num2 = class403_0.float_2 - class31_0.float_2;
			return num * num + num2 * num2 <= float_0 * float_0;
		}
		return false;
	}

	internal static uint smethod_7(Class145 class145_0, Class31 class31_0, float float_0)
	{
		if (!smethod_4(class145_0, class31_0))
		{
			return 0u;
		}
		if (class31_0.bool_1 && class31_0.byte_0 == 0)
		{
			return 0u;
		}
		GStruct0 value;
		if (class31_0.bool_2)
		{
			value = new GStruct0
			{
				byte_0 = class31_0.byte_1,
				ushort_0 = class31_0.ushort_0
			};
		}
		else if (!class145_0.method_20().TryGetValue(class31_0.uint_0, out value))
		{
			return 0u;
		}
		if (value.byte_0 == 2 && value.ushort_0 != 0)
		{
			foreach (Class403 item in class145_0.method_2())
			{
				if (item != null && item.uint_0 == value.ushort_0 && smethod_6(item, class31_0, float_0))
				{
					return value.ushort_0;
				}
			}
			return 0u;
		}
		return 0u;
	}

	internal static Class31 smethod_8(Class145 class145_0, string string_0, bool bool_0, IEnumerable<Class401> ienumerable_0, DateTime dateTime_0)
	{
		if (class145_0 != null && class145_0.method_14() != null && class145_0.method_14().Count != 0 && (bool_0 || !string.IsNullOrWhiteSpace(string_0)))
		{
			string text = (bool_0 ? smethod_3(class145_0) : string_0);
			if (string.IsNullOrWhiteSpace(text))
			{
				return null;
			}
			uint uint_ = 0u;
			foreach (Class403 item in class145_0.method_4())
			{
				if (item != null && item.method_2())
				{
					uint_ = item.uint_0;
					break;
				}
			}
			if (ienumerable_0 != null)
			{
				foreach (Class401 item2 in ienumerable_0)
				{
					if (item2 != null && smethod_11(item2.float_0) && smethod_11(item2.float_1) && smethod_11(item2.float_2) && item2.long_0 > 0L && dateTime_0.Ticks - item2.long_0 >= 0L && dateTime_0.Ticks - item2.long_0 <= TimeSpan.FromSeconds(2.0).Ticks && string.Equals(item2.string_0, text, StringComparison.OrdinalIgnoreCase))
					{
						uint num = smethod_9(class145_0, item2.string_0, uint_);
						if (num != 0)
						{
							return new Class31
							{
								uint_0 = num,
								string_0 = item2.string_0,
								float_0 = item2.float_0,
								float_1 = item2.float_1,
								float_2 = item2.float_2,
								bool_0 = false,
								long_0 = item2.long_0,
								byte_0 = item2.byte_0,
								bool_1 = item2.bool_1,
								byte_1 = item2.byte_1,
								ushort_0 = item2.ushort_0,
								bool_2 = item2.bool_2
							};
						}
					}
				}
			}
			foreach (Class403 item3 in class145_0.method_4())
			{
				if (item3 != null && !item3.method_2() && smethod_10(class145_0.method_14(), item3.uint_0) && (class145_0.method_16() == null || smethod_10(class145_0.method_16(), item3.uint_0)))
				{
					class145_0.method_10().method_4().TryGetValue(item3.uint_0.ToString(CultureInfo.InvariantCulture), out var value);
					if (string.Equals(value, text, StringComparison.OrdinalIgnoreCase) && smethod_11(item3.float_0) && smethod_11(item3.float_1) && smethod_11(item3.float_2))
					{
						return new Class31
						{
							uint_0 = item3.uint_0,
							string_0 = value,
							float_0 = item3.float_0,
							float_1 = item3.float_1,
							float_2 = item3.float_2,
							bool_0 = true,
							long_0 = class145_0.method_89()
						};
					}
				}
			}
			return null;
		}
		return null;
	}

	private static uint smethod_9(Class145 class145_0, string string_0, uint uint_0)
	{
		if (class145_0 != null && class145_0.method_14() != null && !string.IsNullOrWhiteSpace(string_0))
		{
			foreach (uint item in class145_0.method_14())
			{
				if (item != uint_0 && class145_0.method_10().method_4().TryGetValue(item.ToString(CultureInfo.InvariantCulture), out var value) && string.Equals(value, string_0, StringComparison.OrdinalIgnoreCase))
				{
					return item;
				}
			}
			return 0u;
		}
		return 0u;
	}

	private static bool smethod_10(IReadOnlyList<uint> ireadOnlyList_0, uint uint_0)
	{
		int num = 0;
		while (true)
		{
			if (num < ireadOnlyList_0.Count)
			{
				if (ireadOnlyList_0[num] == uint_0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool smethod_11(float float_0)
	{
		if (!float.IsNaN(float_0))
		{
			return !float.IsInfinity(float_0);
		}
		return false;
	}
}
