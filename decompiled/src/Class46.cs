using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

internal static class Class46
{
	private sealed class Class47
	{
		public uint uint_0;

		internal bool method_0(Class403 class403_0)
		{
			return class403_0.uint_0 == uint_0;
		}
	}

	[Serializable]
	private sealed class Class48
	{
		public static readonly Class48 class48_0 = new Class48();

		public static Func<Class381, bool> func_0;

		internal bool method_0(Class381 class381_0)
		{
			return class381_0.bool_1;
		}
	}

	internal static List<Class381> smethod_0(Class145 class145_0, bool bool_0)
	{
		List<Class381> list = new List<Class381>();
		if (class145_0 == null)
		{
			return list;
		}
		if (!bool_0)
		{
			foreach (Class403 item in class145_0.method_4())
			{
				string text = smethod_1(class145_0, item.uint_0);
				if (!string.IsNullOrWhiteSpace(text))
				{
					list.Add(new Class381
					{
						uint_0 = item.uint_0,
						string_0 = text,
						bool_0 = item.method_2(),
						bool_1 = item.method_3(),
						bool_2 = true
					});
				}
			}
			return list;
		}
		if (class145_0.method_14() == null)
		{
			return list;
		}
		using (IEnumerator<uint> enumerator2 = class145_0.method_14().GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				Class47 @class = new Class47();
				@class.uint_0 = enumerator2.Current;
				string text2 = smethod_1(class145_0, @class.uint_0);
				if (!string.IsNullOrWhiteSpace(text2))
				{
					Class403 class2 = class145_0.method_4().FirstOrDefault(@class.method_0);
					list.Add(new Class381
					{
						uint_0 = @class.uint_0,
						string_0 = text2,
						bool_0 = (class2?.method_2() ?? false),
						bool_1 = (class2?.method_3() ?? false),
						bool_2 = (class2 != null)
					});
				}
			}
		}
		return list.OrderByDescending(Class48.class48_0.method_0).ToList();
	}

	private static string smethod_1(Class145 class145_0, uint uint_0)
	{
		if (!class145_0.method_10().method_4().TryGetValue(uint_0.ToString(CultureInfo.InvariantCulture), out var value))
		{
			return null;
		}
		return value;
	}
}
