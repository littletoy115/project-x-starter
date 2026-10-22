using System;
using System.Collections.Generic;
using System.Globalization;

internal static class Class144
{
	internal static List<Class53> smethod_0(Class145 class145_0, string string_0, IEnumerable<string> ienumerable_0)
	{
		return smethod_1(class145_0, string_0, ienumerable_0, 0, null);
	}

	internal static List<Class53> smethod_1(Class145 class145_0, string string_0, IEnumerable<string> ienumerable_0, int int_0, (ushort, ushort)[] valueTuple_0)
	{
		List<Class53> list = new List<Class53>();
		HashSet<string> hashSet_ = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		Class403 @class = null;
		if (class145_0 != null)
		{
			foreach (Class403 item in class145_0.method_4())
			{
				if (item != null && item.method_2())
				{
					@class = item;
					break;
				}
			}
		}
		if (@class != null)
		{
			string text = smethod_4(class145_0, @class);
			bool bool_ = class145_0.method_16() == null || smethod_3(class145_0.method_16(), @class.uint_0);
			smethod_5(list, hashSet_, string.IsNullOrWhiteSpace(text) ? string_0 : text, bool_, smethod_2(class145_0, @class.uint_0, bool_, int_0, valueTuple_0));
		}
		else
		{
			smethod_5(list, hashSet_, string_0, bool_0: false, Class185.smethod_0(-1141274422));
		}
		if (class145_0 != null && class145_0.method_14() != null)
		{
			foreach (Class403 item2 in class145_0.method_4())
			{
				if (item2 != null && !item2.method_2() && smethod_3(class145_0.method_14(), item2.uint_0) && (class145_0.method_16() == null || smethod_3(class145_0.method_16(), item2.uint_0)))
				{
					smethod_5(list, hashSet_, smethod_4(class145_0, item2), bool_0: true, smethod_2(class145_0, item2.uint_0, bool_0: true, int_0, valueTuple_0));
				}
			}
		}
		if (ienumerable_0 != null)
		{
			foreach (string item3 in ienumerable_0)
			{
				smethod_5(list, hashSet_, item3, bool_0: false, Class185.smethod_0(-1141274422));
			}
		}
		return list;
	}

	private static string smethod_2(Class145 class145_0, uint uint_0, bool bool_0, int int_0, (ushort, ushort)[] valueTuple_0)
	{
		if (!bool_0)
		{
			return Class185.smethod_0(-1141274422);
		}
		if (valueTuple_0 != null && int_0 >= 1 && int_0 <= valueTuple_0.Length)
		{
			ushort item = valueTuple_0[int_0 - 1].Item1;
			ushort item2 = valueTuple_0[int_0 - 1].Item2;
			if (item != ushort.MaxValue && item2 != ushort.MaxValue && (item != 0 || item2 != 0))
			{
				if (!class145_0.method_18().TryGetValue(uint_0, out var value))
				{
					return Class185.smethod_0(-1141274433);
				}
				foreach (GStruct2 item3 in value)
				{
					if (item3.ushort_0 == item && item3.ushort_1 == item2)
					{
						return Math.Max(0f, item3.float_0).ToString(Class185.smethod_0(-1141277503), CultureInfo.InvariantCulture);
					}
				}
				return Class185.smethod_0(-1141274464);
			}
			return Class185.smethod_0(-1141274441);
		}
		return Class185.smethod_0(-1141274433);
	}

	private static bool smethod_3(IReadOnlyList<uint> ireadOnlyList_0, uint uint_0)
	{
		foreach (uint item in ireadOnlyList_0)
		{
			if (item == uint_0)
			{
				return true;
			}
		}
		return false;
	}

	private static string smethod_4(Class145 class145_0, Class403 class403_0)
	{
		if (!class145_0.method_10().method_4().TryGetValue(class403_0.uint_0.ToString(CultureInfo.InvariantCulture), out var value))
		{
			return null;
		}
		return value;
	}

	private static void smethod_5(List<Class53> list_0, HashSet<string> hashSet_0, string string_0, bool bool_0, string string_1)
	{
		if (!string.IsNullOrWhiteSpace(string_0))
		{
			string_0 = string_0.Trim();
			if (hashSet_0.Add(string_0))
			{
				list_0.Add(new Class53
				{
					string_0 = string_0,
					bool_0 = bool_0,
					string_1 = string_1
				});
			}
		}
	}
}
