using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

internal static class Class342
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct94 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private bool[] bool_0;

		private string[] string_0;

		private TaskAwaiter<List<int>> taskAwaiter_0;

		private int int_1;

		private string[] string_1;

		private int int_2;

		private TaskAwaiter<string> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<List<int>> awaiter2;
				TaskAwaiter<string> awaiter;
				List<int> result2;
				string result3;
				switch (num)
				{
				default:
					if (gform0_0 != null)
					{
						awaiter2 = Class104.smethod_0(gform0_0, 16, 23).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0088;
					}
					result = false;
					goto end_IL_0007;
				case 0:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<List<int>>);
					num = -1;
					int_0 = -1;
					goto IL_0088;
				case 1:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_0147;
				case 2:
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<string>);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_0088:
					result2 = awaiter2.GetResult();
					bool_0 = new bool[9];
					for (int i = 0; i < result2.Count; i++)
					{
						bool_0[result2[i] - 15] = true;
					}
					string_0 = new string[9];
					int_1 = 1;
					goto IL_00fd;
					IL_00fd:
					if (int_1 <= 7)
					{
						string_1 = string_0;
						int_2 = int_1;
						awaiter = gform0_0.smethod_8(Class91.smethod_1(int_1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0147;
					}
					string_1 = string_0;
					awaiter = gform0_0.smethod_8(21).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 2;
						int_0 = 2;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
					IL_0147:
					result3 = awaiter.GetResult();
					string_1[int_2] = result3;
					string_1 = null;
					int_1++;
					goto IL_00fd;
				}
				result3 = awaiter.GetResult();
				string_1[8] = result3;
				string_1 = null;
				Class119 @class = gform0_0.method_7();
				bool flag;
				if (@class != null && @class.method_139())
				{
					(ushort, ushort)[] valueTuple_ = @class.ValueTuple_0;
					Class358 class358_ = @class.method_19();
					long long_ = smethod_10();
					flag = smethod_25(long_, gform0_0.method_5().method_0() == null || gform0_0.method_5().method_0().ushort_0 == 0, valueTuple_, class358_, gform0_0.method_5().method_12(), bool_0, string_0, out var num2, bool_3: false);
					smethod_12(long_, string_3, string_4);
					if (num2 == 0)
					{
						goto IL_03b3;
					}
					if (gform0_0.method_5().method_0() != null && gform0_0.method_5().method_12() != null)
					{
						int num3 = num2;
						if (valueTuple_ != null && num3 <= valueTuple_.Length)
						{
							ushort item = valueTuple_[num3 - 1].Item1;
							ushort item2 = valueTuple_[num3 - 1].Item2;
							Class119 class2 = gform0_0.method_7();
							if (class2 != null && @class == class2)
							{
								smethod_14("cast slot=" + num3 + " skill=" + item + ":" + item2 + " -> tab 3");
								smethod_37(num3, item, item2, long_);
								class2.method_173(num3, item, item2);
								goto IL_03b3;
							}
							result = false;
						}
						else
						{
							result = false;
						}
					}
					else
					{
						result = false;
					}
				}
				else
				{
					smethod_12(smethod_10(), "rebuff_off", smethod_15("rebuff_off", bool_1: true, 0, string.Empty));
					result = true;
				}
				goto end_IL_0007;
				IL_03b3:
				result = flag;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				bool_0 = null;
				string_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			bool_0 = null;
			string_0 = null;
			asyncTaskMethodBuilder_0.SetResult(result);
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

	private static int int_0 = 0;

	private static int int_1;

	private static ushort ushort_0;

	private static ushort ushort_1;

	private static long long_0;

	private static long long_1;

	private static bool bool_0;

	private static readonly long[] long_2 = new long[9];

	private static long long_3 = -1L;

	private static long long_4;

	private static readonly string[] string_0 = new string[9];

	private static readonly string[] string_1 = new string[9];

	private static string string_2 = string.Empty;

	private static string string_3 = string.Empty;

	private static string string_4 = string.Empty;

	private static string string_5 = string.Empty;

	private static long long_5 = long.MinValue;

	private static Class74 class74_0;

	public static void smethod_0(Class74 class74_1)
	{
		Interlocked.Exchange(ref class74_0, class74_1);
	}

	internal static Class74 smethod_1()
	{
		return Interlocked.Exchange(ref class74_0, null);
	}

	public static void smethod_2()
	{
		int_0 = 0;
		int_1 = 0;
		ushort_0 = 0;
		ushort_1 = 0;
		long_0 = 0L;
		long_1 = 0L;
		smethod_8(bool_1: false);
		for (int i = 0; i < long_2.Length; i++)
		{
			long_2[i] = 0L;
		}
		smethod_9(-1L);
		long_4 = 0L;
		Interlocked.Exchange(ref class74_0, null);
		for (int j = 0; j < string_0.Length; j++)
		{
			string_0[j] = string.Empty;
		}
		for (int k = 0; k < string_1.Length; k++)
		{
			string_1[k] = string.Empty;
		}
		string_2 = string.Empty;
		string_3 = string.Empty;
		string_4 = string.Empty;
		string_5 = string.Empty;
		long_5 = long.MinValue;
	}

	internal static string smethod_3()
	{
		return string_2;
	}

	internal static string smethod_4()
	{
		return string_4;
	}

	internal static int smethod_5()
	{
		return int_0;
	}

	internal static long smethod_6()
	{
		return Volatile.Read(ref long_3);
	}

	internal static bool smethod_7()
	{
		return Volatile.Read(ref bool_0);
	}

	internal static void smethod_8(bool bool_1)
	{
		Volatile.Write(ref bool_0, bool_1);
	}

	internal static void smethod_9(long long_6)
	{
		Volatile.Write(ref long_3, long_6);
	}

	internal static long smethod_10()
	{
		return Class358.smethod_0();
	}

	public static async Task<bool> smethod_11(GForm0 gform0_0)
	{
		if (gform0_0 == null)
		{
			return false;
		}
		List<int> list = await Class104.smethod_0(gform0_0, 16, 23);
		bool[] array = new bool[9];
		for (int i = 0; i < list.Count; i++)
		{
			array[list[i] - 15] = true;
		}
		string[] array2 = new string[9];
		string[] array3;
		for (int j = 1; j <= 7; j++)
		{
			array3 = array2;
			int num = j;
			array3[num] = await gform0_0.smethod_8(Class91.smethod_1(j));
		}
		array3 = array2;
		array3[8] = await gform0_0.smethod_8(21);
		Class119 @class = gform0_0.method_7();
		if (@class != null && @class.method_139())
		{
			(ushort, ushort)[] valueTuple_ = @class.ValueTuple_0;
			Class358 class358_ = @class.method_19();
			long long_ = smethod_10();
			int int_;
			bool result = smethod_25(long_, gform0_0.method_5().method_0() == null || gform0_0.method_5().method_0().ushort_0 == 0, valueTuple_, class358_, gform0_0.method_5().method_12(), array, array2, out int_, bool_3: false);
			smethod_12(long_, string_3, string_4);
			if (int_ != 0)
			{
				if (gform0_0.method_5().method_0() == null || gform0_0.method_5().method_12() == null)
				{
					return false;
				}
				int num2 = int_;
				if (valueTuple_ == null || num2 > valueTuple_.Length)
				{
					return false;
				}
				ushort item = valueTuple_[num2 - 1].Item1;
				ushort item2 = valueTuple_[num2 - 1].Item2;
				Class119 class2 = gform0_0.method_7();
				if (class2 == null || @class != class2)
				{
					return false;
				}
				smethod_14("cast slot=" + num2 + " skill=" + item + ":" + item2 + " -> tab 3");
				smethod_37(num2, item, item2, long_);
				class2.method_173(num2, item, item2);
			}
			return result;
		}
		smethod_12(smethod_10(), "rebuff_off", smethod_15("rebuff_off", bool_1: true, 0, string.Empty));
		return true;
	}

	private static void smethod_12(long long_6, string string_6, string string_7)
	{
		if (smethod_13(string_2) && (!(string_6 == string_5) || long_6 - long_5 >= 2000L))
		{
			string_5 = string_6;
			long_5 = long_6;
			smethod_14(string_7);
		}
	}

	internal static bool smethod_13(string string_6)
	{
		return string_6 != "not_due";
	}

	private static void smethod_14(string string_6)
	{
	}

	internal static string smethod_15(string string_6, bool bool_1, int int_2, string string_7)
	{
		string text = string_6 + " run=" + (bool_1 ? "true" : "false") + " cast=" + int_2;
		if (string_7.Length > 0)
		{
			text = text + " " + string_7;
		}
		return text;
	}

	private static bool smethod_16(bool bool_1, int int_2, string string_6, int int_3, string string_7, string string_8)
	{
		string_2 = string_6;
		string_3 = string_6 + " run=" + bool_1 + " cast=" + int_2 + " slot=" + int_3 + " " + string_8;
		if (string_8.Length > 0)
		{
			string_7 = ((string_7.Length > 0) ? (string_7 + " slots=" + string_8) : ("slots=" + string_8));
		}
		string_4 = smethod_15(string_6, bool_1, int_2, string_7);
		return bool_1;
	}

	private static string smethod_17(int int_2, (ushort, ushort)[] valueTuple_0, IReadOnlyList<GStruct3> ireadOnlyList_0, Class358 class358_0, string string_6, long long_6)
	{
		StringBuilder stringBuilder = new StringBuilder("slot=");
		stringBuilder.Append(int_2);
		if (valueTuple_0 != null && int_2 >= 1 && int_2 <= valueTuple_0.Length)
		{
			ushort item = valueTuple_0[int_2 - 1].Item1;
			ushort item2 = valueTuple_0[int_2 - 1].Item2;
			stringBuilder.Append(" id=").Append(item).Append(':')
				.Append(item2);
			if (smethod_32(item, item2, ireadOnlyList_0, out var float_))
			{
				stringBuilder.Append(" left=").Append(float_.ToString("F1", CultureInfo.InvariantCulture)).Append('s');
			}
			else
			{
				stringBuilder.Append(" left=absent");
			}
			stringBuilder.Append((int_2 == 8) ? " every=" : " thr=").Append(smethod_33(string_6)).Append('s');
			stringBuilder.Append(" ready=").Append(smethod_18(item, item2, class358_0));
		}
		stringBuilder.Append(" age=").Append(smethod_19(class358_0, long_6));
		return stringBuilder.ToString();
	}

	private static string smethod_18(ushort ushort_2, ushort ushort_3, Class358 class358_0)
	{
		if (class358_0 != null && class358_0.struct16_0 != null)
		{
			int num = 0;
			while (true)
			{
				if (num < class358_0.struct16_0.Length)
				{
					if (class358_0.struct16_0[num].ushort_0 == ushort_2 && class358_0.struct16_0[num].ushort_1 == ushort_3)
					{
						break;
					}
					num++;
					continue;
				}
				return "none";
			}
			return class358_0.struct16_0[num].int_0.ToString(CultureInfo.InvariantCulture);
		}
		return "none";
	}

	private static string smethod_19(Class358 class358_0, long long_6)
	{
		if (class358_0 == null)
		{
			return "none";
		}
		return long_6 - class358_0.long_0 + "ms";
	}

	private static string smethod_20(int int_2)
	{
		if (string_1[int_2] == "hold")
		{
			return string_0[int_2];
		}
		return string_1[int_2];
	}

	private static string smethod_21()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i <= 8; i++)
		{
			if (string_1[i].Length != 0)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append(i).Append(':').Append(smethod_20(i));
			}
		}
		return stringBuilder.ToString();
	}

	private static int smethod_22(string string_6)
	{
		switch (string_6)
		{
		case "interval_secs_empty":
			return 3;
		default:
			return 1;
		case "slot_empty":
		case "tab3_short":
			return 2;
		case "not_due":
		case "thr_empty":
		case "interval_not_due":
			return 4;
		case "hold_busy":
		case "hold_fail":
			return 5;
		case "ready_null":
		case "ready_stale":
		case "ready_missing":
		case "ready_code":
			return 6;
		}
	}

	private static bool smethod_23((ushort, ushort)[] valueTuple_0, IReadOnlyList<GStruct3> ireadOnlyList_0, Class358 class358_0, string[] string_6, long long_6)
	{
		int num = 0;
		int num2 = 0;
		for (int i = 1; i <= 8; i++)
		{
			if (string_1[i].Length != 0 && smethod_22(smethod_20(i)) > num2)
			{
				num2 = smethod_22(smethod_20(i));
				num = i;
			}
		}
		if (num2 <= 1)
		{
			return smethod_16(bool_1: true, 0, "all_off", 0, string.Empty, smethod_21());
		}
		string text = smethod_20(num);
		string text2 = smethod_17(num, valueTuple_0, ireadOnlyList_0, class358_0, string_6[num], long_6);
		if (text == "hold_busy" || text == "hold_fail")
		{
			text2 = text2 + " hold_ms=" + (long_2[num] - long_6);
		}
		if (text == "interval_not_due")
		{
			text2 = text2 + " next_ms=" + (smethod_6() + smethod_33(string_6[num]) * 1000L - long_6);
		}
		return smethod_16(bool_1: true, 0, text, num, text2, smethod_21());
	}

	internal static bool smethod_24(long long_6, bool bool_1, (ushort, ushort)[] valueTuple_0, Class358 class358_0, IReadOnlyList<GStruct3> ireadOnlyList_0, bool[] bool_2, string[] string_6, out int int_2)
	{
		return smethod_25(long_6, bool_1, valueTuple_0, class358_0, ireadOnlyList_0, bool_2, string_6, out int_2, bool_3: true);
	}

	internal static bool smethod_25(long long_6, bool bool_1, (ushort, ushort)[] valueTuple_0, Class358 class358_0, IReadOnlyList<GStruct3> ireadOnlyList_0, bool[] bool_2, string[] string_6, out int int_2, bool bool_3)
	{
		int_2 = 0;
		if (smethod_7())
		{
			return smethod_16(bool_1: true, 0, "unavailable", 0, string.Empty, string.Empty);
		}
		if (int_0 == 1)
		{
			return smethod_35(long_6, valueTuple_0, ireadOnlyList_0, class358_0, string_6);
		}
		if (int_0 == 2)
		{
			return smethod_36(long_6, ireadOnlyList_0, string_6, valueTuple_0, class358_0);
		}
		if (long_6 < long_4)
		{
			return smethod_16(bool_1: true, 0, "gap", int_1, "gap_ms=" + (long_4 - long_6) + " after=" + string_0[int_1] + " " + smethod_17(int_1, valueTuple_0, ireadOnlyList_0, class358_0, string_6[int_1], long_6), string.Empty);
		}
		if (bool_1)
		{
			return smethod_16(bool_1: true, 0, "dead", 0, string.Empty, string.Empty);
		}
		if (valueTuple_0 == null)
		{
			return smethod_16(bool_1: true, 0, "tab3_null", 0, "age=" + smethod_19(class358_0, long_6), string.Empty);
		}
		if (ireadOnlyList_0 == null)
		{
			return smethod_16(bool_1: true, 0, "buffs_null", 0, string.Empty, string.Empty);
		}
		for (int i = 0; i < string_1.Length; i++)
		{
			string_1[i] = string.Empty;
		}
		int num = 1;
		while (true)
		{
			if (num <= 7)
			{
				if (smethod_29(bool_2[num], valueTuple_0, num, ireadOnlyList_0, string_6[num], long_2[num], long_6, out string_1[num]) && smethod_27(valueTuple_0[num - 1].Item1, valueTuple_0[num - 1].Item2, class358_0, long_6, out string_1[num]))
				{
					break;
				}
				num++;
				continue;
			}
			if (!smethod_31(bool_2[8], valueTuple_0, string_6[8], smethod_6(), long_2[8], long_6, out string_1[8]))
			{
				return smethod_23(valueTuple_0, ireadOnlyList_0, class358_0, string_6, long_6);
			}
			if (!smethod_27(valueTuple_0[7].Item1, valueTuple_0[7].Item2, class358_0, long_6, out string_1[8]))
			{
				return smethod_23(valueTuple_0, ireadOnlyList_0, class358_0, string_6, long_6);
			}
			if (bool_3)
			{
				smethod_37(8, valueTuple_0[7].Item1, valueTuple_0[7].Item2, long_6);
			}
			int_2 = 8;
			string_1[8] = "cast";
			return smethod_16(bool_1: false, 8, "cast", 8, smethod_17(8, valueTuple_0, ireadOnlyList_0, class358_0, string_6[8], long_6), smethod_21());
		}
		if (bool_3)
		{
			smethod_37(num, valueTuple_0[num - 1].Item1, valueTuple_0[num - 1].Item2, long_6);
		}
		int_2 = num;
		string_1[num] = "cast";
		return smethod_16(bool_1: false, num, "cast", num, smethod_17(num, valueTuple_0, ireadOnlyList_0, class358_0, string_6[num], long_6), smethod_21());
	}

	internal static bool smethod_26(ushort ushort_2, ushort ushort_3, Class358 class358_0, long long_6)
	{
		string string_;
		return smethod_27(ushort_2, ushort_3, class358_0, long_6, out string_);
	}

	internal static bool smethod_27(ushort ushort_2, ushort ushort_3, Class358 class358_0, long long_6, out string string_6)
	{
		string_6 = "ready_null";
		if (class358_0 == null)
		{
			return false;
		}
		if (class358_0.struct16_0 == null)
		{
			return false;
		}
		string_6 = "ready_stale";
		if (long_6 - class358_0.long_0 > 1000L)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < class358_0.struct16_0.Length)
			{
				if (class358_0.struct16_0[num].ushort_0 == ushort_2 && class358_0.struct16_0[num].ushort_1 == ushort_3)
				{
					break;
				}
				num++;
				continue;
			}
			string_6 = "ready_missing";
			return false;
		}
		string_6 = ((class358_0.struct16_0[num].int_0 == 0) ? "ready" : "ready_code");
		return class358_0.struct16_0[num].int_0 == 0;
	}

	internal static bool smethod_28(bool bool_1, (ushort, ushort)[] valueTuple_0, int int_2, IReadOnlyList<GStruct3> ireadOnlyList_0, string string_6, long long_6, long long_7)
	{
		string string_7;
		return smethod_29(bool_1, valueTuple_0, int_2, ireadOnlyList_0, string_6, long_6, long_7, out string_7);
	}

	internal static bool smethod_29(bool bool_1, (ushort, ushort)[] valueTuple_0, int int_2, IReadOnlyList<GStruct3> ireadOnlyList_0, string string_6, long long_6, long long_7, out string string_7)
	{
		string_7 = "slot_off";
		if (!bool_1)
		{
			return false;
		}
		string_7 = "tab3_null";
		if (valueTuple_0 == null)
		{
			return false;
		}
		string_7 = "bad_slot";
		if (int_2 >= 1 && int_2 <= 7)
		{
			string_7 = "tab3_short";
			if (int_2 > valueTuple_0.Length)
			{
				return false;
			}
			ushort item = valueTuple_0[int_2 - 1].Item1;
			ushort item2 = valueTuple_0[int_2 - 1].Item2;
			string_7 = "slot_empty";
			if (item != ushort.MaxValue && item2 != ushort.MaxValue)
			{
				string_7 = "hold";
				if (long_7 < long_6)
				{
					return false;
				}
				string_7 = "due";
				if (!smethod_32(item, item2, ireadOnlyList_0, out var float_))
				{
					return true;
				}
				if (float_ <= (float)smethod_33(string_6))
				{
					return true;
				}
				string_7 = (smethod_34(string_6) ? "not_due" : "thr_empty");
				return false;
			}
			return false;
		}
		return false;
	}

	internal static bool smethod_30(bool bool_1, (ushort, ushort)[] valueTuple_0, string string_6, long long_6, long long_7, long long_8)
	{
		string string_7;
		return smethod_31(bool_1, valueTuple_0, string_6, long_6, long_7, long_8, out string_7);
	}

	internal static bool smethod_31(bool bool_1, (ushort, ushort)[] valueTuple_0, string string_6, long long_6, long long_7, long long_8, out string string_7)
	{
		string_7 = "interval_off";
		if (!bool_1)
		{
			return false;
		}
		string_7 = "tab3_null";
		if (valueTuple_0 == null)
		{
			return false;
		}
		string_7 = "tab3_short";
		if (valueTuple_0.Length < 8)
		{
			return false;
		}
		string_7 = "slot_empty";
		if (valueTuple_0[7].Item1 != ushort.MaxValue && valueTuple_0[7].Item2 != ushort.MaxValue)
		{
			int num = smethod_33(string_6);
			string_7 = "interval_secs_empty";
			if (num <= 0)
			{
				return false;
			}
			string_7 = "hold";
			if (long_8 < long_7)
			{
				return false;
			}
			string_7 = "due";
			if (long_6 < 0L)
			{
				return true;
			}
			if (long_8 - long_6 >= num * 1000L)
			{
				return true;
			}
			string_7 = "interval_not_due";
			return false;
		}
		return false;
	}

	internal static bool smethod_32(ushort ushort_2, ushort ushort_3, IReadOnlyList<GStruct3> ireadOnlyList_0, out float float_0)
	{
		float_0 = 0f;
		if (ireadOnlyList_0 == null)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < ireadOnlyList_0.Count)
			{
				if (!ireadOnlyList_0[num].bool_0 && ireadOnlyList_0[num].ushort_0 == ushort_2 && ireadOnlyList_0[num].ushort_1 == ushort_3)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		float_0 = ireadOnlyList_0[num].float_0;
		return true;
	}

	internal static int smethod_33(string string_6)
	{
		if (!int.TryParse((string_6 ?? string.Empty).Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
		{
			return 0;
		}
		return result;
	}

	internal static bool smethod_34(string string_6)
	{
		int result;
		return int.TryParse((string_6 ?? string.Empty).Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
	}

	private static bool smethod_35(long long_6, (ushort, ushort)[] valueTuple_0, IReadOnlyList<GStruct3> ireadOnlyList_0, Class358 class358_0, string[] string_6)
	{
		Class74 @class = smethod_1();
		if (@class != null && @class.int_0 != int_1)
		{
			@class = null;
		}
		string text = smethod_17(int_1, valueTuple_0, ireadOnlyList_0, class358_0, string_6[int_1], long_6);
		if (@class == null && long_6 - long_0 < 7000L)
		{
			return smethod_16(bool_1: false, 0, "casting", int_1, text + " sent_ms=" + (long_6 - long_0), string.Empty);
		}
		if (@class == null)
		{
			smethod_14("reply slot=" + int_1 + " result=timeout code=-1 settle_ms=" + (long_6 - long_0) + " timed_out=true");
			smethod_39(int_1, long_6);
			int_0 = 0;
			return smethod_16(bool_1: false, 0, "cast_timeout", int_1, text, string.Empty);
		}
		smethod_14("reply slot=" + int_1 + " result=" + @class.string_0 + " code=" + @class.int_1 + " settle_ms=" + @class.int_2 + " timed_out=" + (@class.bool_0 ? "true" : "false"));
		if (!(@class.string_0 == "ok") && !(@class.string_0 == "move"))
		{
			if (@class.string_0 == "unavailable")
			{
				smethod_8(bool_1: true);
				int_0 = 0;
				return smethod_16(bool_1: false, 0, "cast_unavailable", int_1, text, string.Empty);
			}
			if (@class.string_0 == "busy")
			{
				smethod_38(int_1, long_6);
				int_0 = 0;
				return smethod_16(bool_1: false, 0, "cast_busy", int_1, text, string.Empty);
			}
			smethod_39(int_1, long_6);
			int_0 = 0;
			return smethod_16(bool_1: false, 0, "cast_refused", int_1, text + " result=" + @class.string_0 + " code=" + @class.int_1, string.Empty);
		}
		if (int_1 == 8)
		{
			smethod_9(long_6);
			int_0 = 0;
			return smethod_16(bool_1: false, 0, "cast_ok", int_1, text, string.Empty);
		}
		long_1 = long_6;
		int_0 = 2;
		return smethod_16(bool_1: false, 0, "cast_landed", int_1, text, string.Empty);
	}

	private static bool smethod_36(long long_6, IReadOnlyList<GStruct3> ireadOnlyList_0, string[] string_6, (ushort, ushort)[] valueTuple_0, Class358 class358_0)
	{
		string text = smethod_17(int_1, valueTuple_0, ireadOnlyList_0, class358_0, string_6[int_1], long_6);
		if (smethod_32(ushort_0, ushort_1, ireadOnlyList_0, out var float_) && float_ > (float)smethod_33(string_6[int_1]))
		{
			int_0 = 0;
			return smethod_16(bool_1: true, 0, "confirmed", int_1, text, string.Empty);
		}
		if (long_6 - long_1 < 5000L)
		{
			return smethod_16(bool_1: true, 0, "confirming", int_1, text + " replied_ms=" + (long_6 - long_1), string.Empty);
		}
		smethod_14("confirm slot=" + int_1 + " timed_out=true settle_ms=" + (long_6 - long_1));
		smethod_39(int_1, long_6);
		int_0 = 0;
		return smethod_16(bool_1: true, 0, "confirm_timeout", int_1, text, string.Empty);
	}

	internal static void smethod_37(int int_2, ushort ushort_2, ushort ushort_3, long long_6)
	{
		Interlocked.Exchange(ref class74_0, null);
		int_0 = 1;
		int_1 = int_2;
		ushort_0 = ushort_2;
		ushort_1 = ushort_3;
		long_0 = long_6;
	}

	private static void smethod_38(int int_2, long long_6)
	{
		long_2[int_2] = long_6 + 1000L;
		string_0[int_2] = "hold_busy";
		long_4 = long_6 + 1000L;
	}

	private static void smethod_39(int int_2, long long_6)
	{
		long_2[int_2] = long_6 + 5000L;
		string_0[int_2] = "hold_fail";
		long_4 = long_6 + 1000L;
	}

	private static void smethod_40(string string_6)
	{
	}
}
