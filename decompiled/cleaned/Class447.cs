using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

internal static class Class447
{
	private sealed class Class448
	{
		internal uint uint_0;

		internal string string_0;

		internal int int_0;

		internal float float_0;
	}

	private sealed class Class449
	{
		public string string_0;

		internal bool method_0(Class450 class450_0)
		{
			return smethod_15(class450_0.string_0, string_0);
		}

		internal bool method_1(Class450 class450_0)
		{
			return smethod_15(class450_0.string_0, string_0);
		}
	}

	private sealed class Class450
	{
		public Class403 class403_0;

		public string string_0;

		public float float_0;
	}

	private sealed class Class451
	{
		public string string_0;

		internal bool method_0(Class448 class448_0)
		{
			return smethod_15(class448_0.string_0, string_0);
		}

		internal bool method_1(Class448 class448_0)
		{
			return smethod_15(class448_0.string_0, string_0);
		}
	}

	internal sealed class Class452
	{
		public Class403 class403_0;

		public string string_0;

		public float float_0;
	}

	[Serializable]
	private sealed class Class453
	{
		public static readonly Class453 class453_0 = new Class453();

		public static Func<Class450, ushort> func_0;

		public static Func<Class450, float> func_1;

		public static Func<Class450, float> func_2;

		public static Func<Class450, ushort> func_3;

		public static Func<Class450, float> func_4;

		public static Func<Class450, float> func_5;

		public static Func<Class450, Class403> func_6;

		public static Func<Class448, int> func_7;

		public static Func<Class448, float> func_8;

		public static Func<Class448, float> func_9;

		public static Func<Class448, int> func_10;

		public static Func<Class448, float> func_11;

		public static Func<Class448, float> func_12;

		public static Func<Class448, uint> func_13;

		internal ushort method_0(Class450 class450_0)
		{
			return class450_0.class403_0.ushort_2;
		}

		internal float method_1(Class450 class450_0)
		{
			return class450_0.float_0;
		}

		internal float method_2(Class450 class450_0)
		{
			return class450_0.float_0;
		}

		internal ushort method_3(Class450 class450_0)
		{
			return class450_0.class403_0.ushort_2;
		}

		internal float method_4(Class450 class450_0)
		{
			return class450_0.float_0;
		}

		internal float method_5(Class450 class450_0)
		{
			return class450_0.float_0;
		}

		internal Class403 method_6(Class450 class450_0)
		{
			return class450_0.class403_0;
		}

		internal int method_7(Class448 class448_0)
		{
			return class448_0.int_0;
		}

		internal float method_8(Class448 class448_0)
		{
			return class448_0.float_0;
		}

		internal float method_9(Class448 class448_0)
		{
			return class448_0.float_0;
		}

		internal int method_10(Class448 class448_0)
		{
			return class448_0.int_0;
		}

		internal float method_11(Class448 class448_0)
		{
			return class448_0.float_0;
		}

		internal float method_12(Class448 class448_0)
		{
			return class448_0.float_0;
		}

		internal uint method_13(Class448 class448_0)
		{
			return class448_0.uint_0;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct141 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<List<uint>> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private Class451 class451_0;

		private List<uint> list_0;

		private bool bool_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private TaskAwaiter<bool> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			List<uint> result4;
			try
			{
				TaskAwaiter<string> awaiter2;
				TaskAwaiter<bool> awaiter;
				bool result;
				string result2;
				switch (num)
				{
				default:
					class451_0 = new Class451();
					list_0 = smethod_8(gform0_0);
					awaiter2 = gform0_0.smethod_8(54).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0093;
				case 0:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_0093;
				case 1:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0104;
				case 2:
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_0104:
					result = awaiter.GetResult();
					bool_0 = result;
					awaiter = gform0_0.smethod_6(50).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 2;
						int_0 = 2;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
					IL_0093:
					result2 = awaiter2.GetResult();
					class451_0.string_0 = result2;
					awaiter = gform0_0.smethod_6(73).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0104;
				}
				bool result3 = awaiter.GetResult();
				float? num2 = gform0_0.method_5().method_0()?.float_0;
				float? num3 = gform0_0.method_5().method_0()?.float_1;
				float? num4 = gform0_0.method_5().method_0()?.float_2;
				if (num2.HasValue && num3.HasValue && num4.HasValue)
				{
					float value = num2.Value;
					float value2 = num3.Value;
					float value3 = num4.Value;
					List<Class448> list = new List<Class448>();
					for (int i = 0; i < list_0.Count; i++)
					{
						Class403 @class = smethod_9(gform0_0.method_5().method_2(), list_0[i]);
						if (@class != null && !@class.method_0())
						{
							list.Add(new Class448
							{
								uint_0 = @class.uint_0,
								string_0 = smethod_4(gform0_0, @class.ushort_0, @class.ushort_1),
								int_0 = @class.ushort_2,
								float_0 = Class406.smethod_1(value, value2, value3, @class.float_0, @class.float_1, @class.float_2)
							});
						}
					}
					IEnumerable<Class448> source = ((bool_0 && result3) ? list.OrderByDescending(class451_0.method_0).ThenByDescending(Class453.class453_0.method_7).ThenBy(Class453.class453_0.method_8) : (bool_0 ? list.OrderByDescending(class451_0.method_1).ThenBy(Class453.class453_0.method_9) : ((!result3) ? list.OrderBy(Class453.class453_0.method_12) : list.OrderByDescending(Class453.class453_0.method_10).ThenBy(Class453.class453_0.method_11))));
					result4 = source.Select(Class453.class453_0.method_13).ToList();
				}
				else
				{
					result4 = new List<uint>();
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class451_0 = null;
				list_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class451_0 = null;
			list_0 = null;
			asyncTaskMethodBuilder_0.SetResult(result4);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public static bool smethod_0(IReadOnlyList<Class403> ireadOnlyList_0, Class83 class83_0, float float_0, out Class403 class403_0, out float float_1)
	{
		class403_0 = null;
		float_1 = float.MaxValue;
		if (ireadOnlyList_0 == null)
		{
			return false;
		}
		for (int i = 0; i < ireadOnlyList_0.Count; i++)
		{
			Class403 @class = ireadOnlyList_0[i];
			if (@class != null && !@class.method_0())
			{
				float num = Class406.smethod_0(class83_0, @class.float_0, @class.float_1, @class.float_2);
				if (num <= float_0 && num < float_1)
				{
					float_1 = num;
					class403_0 = @class;
				}
			}
		}
		return class403_0 != null;
	}

	public static bool smethod_1(IReadOnlyList<Class403> ireadOnlyList_0, Class83 class83_0, float float_0, float float_1, float float_2, float float_3, out Class403 class403_0, out float float_4)
	{
		class403_0 = null;
		float_4 = float.MaxValue;
		if (ireadOnlyList_0 == null)
		{
			return false;
		}
		for (int i = 0; i < ireadOnlyList_0.Count; i++)
		{
			Class403 @class = ireadOnlyList_0[i];
			if (@class != null && !@class.method_0() && Class406.smethod_3(@class.float_0, @class.float_1, @class.float_2, float_0, float_1, float_2, float_3))
			{
				float num = Class406.smethod_0(class83_0, @class.float_0, @class.float_1, @class.float_2);
				if (num < float_4)
				{
					float_4 = num;
					class403_0 = @class;
				}
			}
		}
		return class403_0 != null;
	}

	public static string smethod_2(Class145 class145_0, Class403 class403_0)
	{
		if (class145_0 != null && class145_0.method_10() != null && class145_0.method_10().method_0() != null)
		{
			string key = class403_0.ushort_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141297577) + class403_0.ushort_1.ToString(CultureInfo.InvariantCulture);
			if (class145_0.method_10().method_0().TryGetValue(key, out var value) && value != null)
			{
				value = value.Trim();
				if (value.Length != 0)
				{
					return value;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public static string smethod_3(Class145 class145_0, Class403 class403_0)
	{
		if (class145_0 != null && class145_0.method_10() != null && class145_0.method_10().method_2() != null)
		{
			string key = class403_0.ushort_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141297577) + class403_0.ushort_1.ToString(CultureInfo.InvariantCulture);
			if (class145_0.method_10().method_2().TryGetValue(key, out var value) && value != null)
			{
				value = value.Trim();
				if (value.Length != 0)
				{
					return value;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	internal static string smethod_4(GForm0 gform0_0, ushort ushort_0, ushort ushort_1)
	{
		if (gform0_0.method_5().method_10() != null && gform0_0.method_5().method_10().method_0() != null)
		{
			string key = ushort_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141297577) + ushort_1.ToString(CultureInfo.InvariantCulture);
			if (gform0_0.method_5().method_10().method_0()
				.TryGetValue(key, out var value) && value != null)
			{
				value = value.Trim();
				if (value.Length != 0)
				{
					return value;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	internal static string smethod_5(GForm0 gform0_0, ushort ushort_0, ushort ushort_1)
	{
		if (gform0_0.method_5().method_10() != null && gform0_0.method_5().method_10().method_2() != null)
		{
			string key = ushort_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141297577) + ushort_1.ToString(CultureInfo.InvariantCulture);
			if (gform0_0.method_5().method_10().method_2()
				.TryGetValue(key, out var value) && value != null)
			{
				value = value.Trim();
				if (value.Length != 0)
				{
					return value;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public static List<Class403> smethod_6(Class145 class145_0, Class83 class83_0, GForm0 gform0_0)
	{
		Class449 @class = new Class449();
		List<Class450> list = new List<Class450>();
		if (class145_0 != null && class145_0.method_2() != null)
		{
			for (int i = 0; i < class145_0.method_2().Count; i++)
			{
				Class403 class2 = class145_0.method_2()[i];
				if (class2 != null && !class2.method_0())
				{
					list.Add(new Class450
					{
						class403_0 = class2,
						string_0 = smethod_2(class145_0, class2),
						float_0 = Class406.smethod_0(class83_0, class2.float_0, class2.float_1, class2.float_2)
					});
				}
			}
		}
		@class.string_0 = gform0_0.smethod_22(54);
		bool flag = gform0_0.smethod_21(73);
		bool flag2 = gform0_0.smethod_21(50);
		IEnumerable<Class450> source = ((flag && flag2) ? list.OrderByDescending(@class.method_0).ThenByDescending(Class453.class453_0.method_0).ThenBy(Class453.class453_0.method_1) : (flag ? list.OrderByDescending(@class.method_1).ThenBy(Class453.class453_0.method_2) : ((!flag2) ? list.OrderBy(Class453.class453_0.method_5) : list.OrderByDescending(Class453.class453_0.method_3).ThenBy(Class453.class453_0.method_4))));
		return source.Select(Class453.class453_0.method_6).ToList();
	}

	public static async Task<List<uint>> smethod_7(GForm0 gform0_0)
	{
		Class451 @class = new Class451();
		List<uint> list = smethod_8(gform0_0);
		@class.string_0 = await gform0_0.smethod_8(54);
		bool flag = await gform0_0.smethod_6(73);
		bool flag2 = await gform0_0.smethod_6(50);
		float? num = gform0_0.method_5().method_0()?.float_0;
		float? num2 = gform0_0.method_5().method_0()?.float_1;
		float? num3 = gform0_0.method_5().method_0()?.float_2;
		if (num.HasValue && num2.HasValue && num3.HasValue)
		{
			float value = num.Value;
			float value2 = num2.Value;
			float value3 = num3.Value;
			List<Class448> list2 = new List<Class448>();
			for (int i = 0; i < list.Count; i++)
			{
				Class403 class2 = smethod_9(gform0_0.method_5().method_2(), list[i]);
				if (class2 != null && !class2.method_0())
				{
					list2.Add(new Class448
					{
						uint_0 = class2.uint_0,
						string_0 = smethod_4(gform0_0, class2.ushort_0, class2.ushort_1),
						int_0 = class2.ushort_2,
						float_0 = Class406.smethod_1(value, value2, value3, class2.float_0, class2.float_1, class2.float_2)
					});
				}
			}
			IEnumerable<Class448> source = ((flag && flag2) ? list2.OrderByDescending(@class.method_0).ThenByDescending(Class453.class453_0.method_7).ThenBy(Class453.class453_0.method_8) : (flag ? list2.OrderByDescending(@class.method_1).ThenBy(Class453.class453_0.method_9) : ((!flag2) ? list2.OrderBy(Class453.class453_0.method_12) : list2.OrderByDescending(Class453.class453_0.method_10).ThenBy(Class453.class453_0.method_11))));
			return source.Select(Class453.class453_0.method_13).ToList();
		}
		return new List<uint>();
	}

	private static List<uint> smethod_8(GForm0 gform0_0)
	{
		List<uint> list = new List<uint>();
		IReadOnlyList<Class403> readOnlyList = gform0_0.method_5().method_2();
		if (readOnlyList == null)
		{
			return list;
		}
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			Class403 @class = readOnlyList[i];
			if (@class != null && !@class.method_0())
			{
				list.Add(@class.uint_0);
			}
		}
		return list;
	}

	private static Class403 smethod_9(IReadOnlyList<Class403> ireadOnlyList_0, uint uint_0)
	{
		if (ireadOnlyList_0 == null)
		{
			return null;
		}
		int num = 0;
		Class403 @class;
		while (true)
		{
			if (num < ireadOnlyList_0.Count)
			{
				@class = ireadOnlyList_0[num];
				if (@class != null && @class.uint_0 == uint_0)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return @class;
	}

	public static List<Class452> smethod_10(Class145 class145_0, Class83 class83_0)
	{
		List<Class452> list = new List<Class452>();
		if (class145_0 != null && class145_0.method_2() != null && class83_0 != null)
		{
			for (int i = 0; i < class145_0.method_2().Count; i++)
			{
				Class403 @class = class145_0.method_2()[i];
				if (@class != null && @class.byte_0 == 1)
				{
					Class452 class2 = new Class452
					{
						class403_0 = @class,
						string_0 = smethod_2(class145_0, @class),
						float_0 = Class406.smethod_0(class83_0, @class.float_0, @class.float_1, @class.float_2)
					};
					int num = list.Count;
					while (num > 0 && !(class2.float_0 >= list[num - 1].float_0))
					{
						num--;
					}
					list.Insert(num, class2);
				}
			}
			return list;
		}
		return list;
	}

	public static bool smethod_11(Class452 class452_0)
	{
		if (class452_0 != null && class452_0.string_0 != null)
		{
			return class452_0.string_0.Length != 0;
		}
		return false;
	}

	public static string smethod_12(Class452 class452_0)
	{
		if (class452_0 == null)
		{
			return string.Empty;
		}
		if (!smethod_11(class452_0))
		{
			return Class185.smethod_0(-1141168251);
		}
		return class452_0.string_0;
	}

	public static string smethod_13(Class452 class452_0)
	{
		if (class452_0 == null)
		{
			return string.Empty;
		}
		return Class440.smethod_2(class452_0.float_0);
	}

	public static int smethod_14(List<Class452> list_0)
	{
		if (list_0 == null)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < list_0.Count; i++)
		{
			if (smethod_11(list_0[i]))
			{
				num++;
			}
		}
		return num;
	}

	private static bool smethod_15(string string_0, string string_1)
	{
		if (!string.IsNullOrEmpty(string_1) && string_0 != null)
		{
			return string_0.Contains(string_1);
		}
		return false;
	}
}
