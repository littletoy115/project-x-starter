using System;
using System.Collections.Generic;

internal sealed class Class394
{
	private sealed class Class395
	{
		internal uint uint_0;

		internal byte byte_0;

		internal ushort ushort_0;

		internal ushort ushort_1;

		internal float float_0;

		internal float float_1;

		internal int int_0;

		internal float float_2;

		internal float float_3;

		internal int int_1;

		internal DateTime dateTime_0;

		internal DateTime dateTime_1;
	}

	private readonly Dictionary<uint, Class395> dictionary_0 = new Dictionary<uint, Class395>();

	private readonly Dictionary<uint, Class395> dictionary_1 = new Dictionary<uint, Class395>();

	internal bool method_0(uint uint_0, byte byte_0, ushort ushort_0, ushort ushort_1, float float_0, float float_1, int int_0, float float_2, float float_3, byte byte_1, DateTime dateTime_0)
	{
		if (method_2(uint_0, byte_0, ushort_0, ushort_1, float_0, float_1, dateTime_0))
		{
			return true;
		}
		if (!dictionary_0.TryGetValue(uint_0, out var value) || !smethod_1(value, uint_0, byte_0, ushort_0, ushort_1, float_0, float_1))
		{
			value = smethod_0(uint_0, byte_0, ushort_0, ushort_1, float_0, float_1, int_0, float_2, float_3);
			dictionary_0[uint_0] = value;
		}
		if (int_0 < value.int_0 || byte_1 != 0 || smethod_2(value.float_2, value.float_3, float_2, float_3))
		{
			value.int_0 = int_0;
			value.float_2 = float_2;
			value.float_3 = float_3;
			value.int_1 = 0;
			value.dateTime_0 = DateTime.MinValue;
		}
		if (value.int_1 >= 5 && dateTime_0 - value.dateTime_0 >= TimeSpan.FromSeconds(5.0) && byte_1 == 0)
		{
			value.dateTime_1 = dateTime_0.AddSeconds(60.0);
			dictionary_1[uint_0] = value;
			dictionary_0.Remove(uint_0);
			return true;
		}
		return false;
	}

	internal void method_1(uint uint_0, DateTime dateTime_0)
	{
		if (dictionary_0.TryGetValue(uint_0, out var value))
		{
			if (value.int_1 == 0)
			{
				value.dateTime_0 = dateTime_0;
			}
			value.int_1++;
		}
	}

	internal bool method_2(uint uint_0, byte byte_0, ushort ushort_0, ushort ushort_1, float float_0, float float_1, DateTime dateTime_0)
	{
		if (!dictionary_1.TryGetValue(uint_0, out var value))
		{
			return false;
		}
		if (!(dateTime_0 >= value.dateTime_1) && smethod_1(value, uint_0, byte_0, ushort_0, ushort_1, float_0, float_1))
		{
			return true;
		}
		dictionary_1.Remove(uint_0);
		return false;
	}

	internal void method_3()
	{
		dictionary_0.Clear();
		dictionary_1.Clear();
	}

	// Forget monsters that died or left the census. The game reuses crow ids, so without this a monster
	// respawning with the same id at the same spot inherited the old one's stuck count and 60 s blacklist.
	internal void method_4(IReadOnlyList<Class403> ireadOnlyList_0)
	{
		if (dictionary_0.Count == 0 && dictionary_1.Count == 0)
		{
			return;
		}
		HashSet<uint> hashSet = new HashSet<uint>();
		if (ireadOnlyList_0 != null)
		{
			for (int i = 0; i < ireadOnlyList_0.Count; i++)
			{
				Class403 @class = ireadOnlyList_0[i];
				if (@class != null && !@class.method_0())
				{
					hashSet.Add(@class.uint_0);
				}
			}
		}
		smethod_3(dictionary_0, hashSet);
		smethod_3(dictionary_1, hashSet);
	}

	private static void smethod_3(Dictionary<uint, Class395> dictionary_2, HashSet<uint> hashSet_0)
	{
		List<uint> list = null;
		foreach (uint key in dictionary_2.Keys)
		{
			if (!hashSet_0.Contains(key))
			{
				(list ?? (list = new List<uint>())).Add(key);
			}
		}
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				dictionary_2.Remove(list[i]);
			}
		}
	}

	private static Class395 smethod_0(uint uint_0, byte byte_0, ushort ushort_0, ushort ushort_1, float float_0, float float_1, int int_0, float float_2, float float_3)
	{
		return new Class395
		{
			uint_0 = uint_0,
			byte_0 = byte_0,
			ushort_0 = ushort_0,
			ushort_1 = ushort_1,
			float_0 = float_0,
			float_1 = float_1,
			int_0 = int_0,
			float_2 = float_2,
			float_3 = float_3
		};
	}

	private static bool smethod_1(Class395 class395_0, uint uint_0, byte byte_0, ushort ushort_0, ushort ushort_1, float float_0, float float_1)
	{
		if (class395_0.uint_0 == uint_0 && class395_0.byte_0 == byte_0 && class395_0.ushort_0 == ushort_0 && class395_0.ushort_1 == ushort_1)
		{
			return !smethod_2(class395_0.float_0, class395_0.float_1, float_0, float_1);
		}
		return false;
	}

	private static bool smethod_2(float float_0, float float_1, float float_2, float float_3)
	{
		float num = float_0 - float_2;
		float num2 = float_1 - float_3;
		return num * num + num2 * num2 > 2.25f;
	}
}
