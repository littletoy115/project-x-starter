using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

internal static class Class195
{
	private sealed class Class196
	{
		public Class133 class133_0;

		internal bool method_0(Class45 class45_0)
		{
			return class45_0.int_0 == class133_0.int_0;
		}
	}

	[Serializable]
	private sealed class Class197
	{
		public static readonly Class197 class197_0 = new Class197();

		public static Func<Class45, int> func_0;

		public static Func<Class45, int> func_1;

		internal int method_0(Class45 class45_0)
		{
			return class45_0.int_0;
		}

		internal int method_1(Class45 class45_0)
		{
			return class45_0.int_0;
		}
	}

	internal static Class87 smethod_0(Class380 class380_0, int int_0)
	{
		if (class380_0 == null)
		{
			return smethod_9("runner health snapshot was not available");
		}
		if (!class380_0.bool_0)
		{
			return smethod_9(smethod_10(class380_0, "runner pidfile probe failed"));
		}
		if (!class380_0.bool_1)
		{
			return smethod_9(smethod_10(class380_0, "runner process-list probe failed"));
		}
		bool flag = false;
		foreach (Class133 item in class380_0.ireadOnlyList_0 ?? new Class133[0])
		{
			if (item != null)
			{
				ulong ulong_;
				if (!item.bool_0)
				{
					flag = true;
				}
				else if (smethod_12(item.string_0) && (!item.bool_1 || !item.bool_2 || !smethod_4(item.string_1, item.int_0, out ulong_)))
				{
					flag = true;
				}
			}
		}
		if (!flag && class380_0.bool_2 && class380_0.bool_3)
		{
			if (smethod_6(class380_0, int_0, out var int_1))
			{
				smethod_5(class380_0, int_0, out var int_2);
				return new Class87(Enum1.Healthy, int_2, int_1, (int_2 == int_1) ? "verified current runner owns the listener" : "verified runner owns the listener but the pidfile is stale");
			}
			return new Class87(Enum1.Unhealthy, 0, 0, "no verified runner owns the configured listener");
		}
		return smethod_9(smethod_10(class380_0, flag ? "one or more runner process probes failed" : "runner socket-table probe failed"));
	}

	internal static IReadOnlyList<Class45> smethod_1(Class380 class380_0)
	{
		List<Class45> list = new List<Class45>();
		if (class380_0 != null && class380_0.bool_1 && class380_0.ireadOnlyList_0 != null)
		{
			using (IEnumerator<Class133> enumerator = class380_0.ireadOnlyList_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class196 @class = new Class196();
					@class.class133_0 = enumerator.Current;
					if (@class.class133_0 != null && @class.class133_0.bool_0 && @class.class133_0.bool_1 && smethod_12(@class.class133_0.string_0) && smethod_4(@class.class133_0.string_1, @class.class133_0.int_0, out var ulong_) && !list.Any(@class.method_0))
					{
						list.Add(new Class45(@class.class133_0.int_0, ulong_));
					}
				}
			}
			return list.OrderBy(Class197.class197_0.method_0).ToArray();
		}
		return list;
	}

	internal static IReadOnlyList<int> smethod_2(Class380 class380_0)
	{
		return smethod_1(class380_0).Select(Class197.class197_0.method_1).ToArray();
	}

	internal static bool smethod_3(Class133 class133_0, Class45 class45_0)
	{
		if (class133_0 != null && class45_0 != null && class133_0.int_0 == class45_0.int_0 && class133_0.bool_0 && class133_0.bool_1 && smethod_12(class133_0.string_0))
		{
			if (smethod_4(class133_0.string_1, class133_0.int_0, out var ulong_))
			{
				return ulong_ == class45_0.ulong_0;
			}
			return false;
		}
		return false;
	}

	internal static bool smethod_4(string string_0, int int_0, out ulong ulong_0)
	{
		ulong_0 = 0uL;
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return false;
		}
		int num = string_0.IndexOf('(');
		int num2 = string_0.LastIndexOf(')');
		if (num > 0 && num2 > num)
		{
			if (int.TryParse(string_0.Substring(0, num).Trim(), NumberStyles.None, CultureInfo.InvariantCulture, out var result) && result == int_0)
			{
				string[] array = string_0.Substring(num2 + 1).Trim().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length > 19)
				{
					return ulong.TryParse(array[19], NumberStyles.None, CultureInfo.InvariantCulture, out ulong_0);
				}
				return false;
			}
			return false;
		}
		return false;
	}

	internal static bool smethod_5(Class380 class380_0, int int_0, out int int_1)
	{
		int_1 = 0;
		if (class380_0 != null && class380_0.bool_0 && class380_0.bool_1 && class380_0.int_0 > 0)
		{
			Class133 @class = smethod_11(class380_0, class380_0.int_0);
			if (smethod_8(@class) && smethod_13(@class, smethod_14(class380_0, int_0)))
			{
				int_1 = @class.int_0;
				return true;
			}
			return false;
		}
		return false;
	}

	internal static bool smethod_6(Class380 class380_0, int int_0, out int int_1)
	{
		int_1 = 0;
		if (class380_0 != null && class380_0.bool_1 && (class380_0.bool_2 || class380_0.bool_3) && class380_0.ireadOnlyList_0 != null)
		{
			HashSet<string> hashSet_ = smethod_14(class380_0, int_0);
			foreach (Class133 item in class380_0.ireadOnlyList_0)
			{
				if (smethod_8(item) && smethod_13(item, hashSet_))
				{
					if (int_1 != 0)
					{
						return false;
					}
					int_1 = item.int_0;
				}
			}
			return int_1 > 0;
		}
		return false;
	}

	internal static bool smethod_7(string string_0, bool bool_0, Enum1 enum1_0, bool bool_1)
	{
		if (bool_0 && enum1_0 == Enum1.Unhealthy && !bool_1 && string_0 != null)
		{
			return string_0.IndexOf("attach failed: Connection closed", StringComparison.OrdinalIgnoreCase) >= 0;
		}
		return false;
	}

	private static bool smethod_8(Class133 class133_0)
	{
		ulong ulong_;
		if (class133_0 != null && class133_0.bool_0 && class133_0.bool_1 && class133_0.bool_2 && smethod_12(class133_0.string_0))
		{
			return smethod_4(class133_0.string_1, class133_0.int_0, out ulong_);
		}
		return false;
	}

	private static Class87 smethod_9(string string_0)
	{
		return new Class87(Enum1.Unknown, 0, 0, string_0);
	}

	private static string smethod_10(Class380 class380_0, string string_0)
	{
		if (!string.IsNullOrWhiteSpace(class380_0.string_2))
		{
			return class380_0.string_2;
		}
		return string_0;
	}

	private static Class133 smethod_11(Class380 class380_0, int int_0)
	{
		if (class380_0.ireadOnlyList_0 == null)
		{
			return null;
		}
		foreach (Class133 item in class380_0.ireadOnlyList_0)
		{
			if (item != null && item.int_0 == int_0)
			{
				return item;
			}
		}
		return null;
	}

	private static bool smethod_12(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return false;
		}
		int num = string_0.IndexOf('\0');
		if (num < 0)
		{
			num = string_0.IndexOf(' ');
		}
		if (num < 0)
		{
			num = string_0.Length;
		}
		return string.Equals(string_0.Substring(0, num), "/data/local/tmp/.klxsvc", StringComparison.Ordinal);
	}

	private static bool smethod_13(Class133 class133_0, HashSet<string> hashSet_0)
	{
		if (hashSet_0.Count != 0 && !string.IsNullOrEmpty(class133_0.string_2))
		{
			foreach (string item in hashSet_0)
			{
				if (class133_0.string_2.IndexOf("socket:[" + item + "]", StringComparison.Ordinal) >= 0)
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	private static HashSet<string> smethod_14(Class380 class380_0, int int_0)
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
		string string_ = int_0.ToString("X4", CultureInfo.InvariantCulture);
		if (class380_0.bool_2)
		{
			smethod_15(class380_0.string_0, string_, hashSet);
		}
		if (class380_0.bool_3)
		{
			smethod_15(class380_0.string_1, string_, hashSet);
		}
		return hashSet;
	}

	private static void smethod_15(string string_0, string string_1, HashSet<string> hashSet_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		string[] array = string_0.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
			if (array2.Length > 9 && !(array2[3] != "0A"))
			{
				int num = array2[1].LastIndexOf(':');
				if (num >= 0 && string.Equals(array2[1].Substring(num + 1), string_1, StringComparison.OrdinalIgnoreCase))
				{
					hashSet_0.Add(array2[9]);
				}
			}
		}
	}
}
