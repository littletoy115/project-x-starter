using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

internal static class Class179
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct68 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<Enum9> asyncTaskMethodBuilder_0;

		public int int_1;

		public Class75 class75_0;

		public double double_0;

		public int int_2;

		public GForm0 gform0_0;

		public bool bool_0;

		public bool bool_1;

		public string string_0;

		public string string_1;

		private long long_0;

		private long long_1;

		private Class119 class119_0;

		private long long_2;

		private int int_3;

		private Struct27 struct27_0;

		private float float_0;

		private float float_1;

		private Class119 class119_1;

		private long long_3;

		private TaskAwaiter taskAwaiter_0;

		private int int_4;

		private void MoveNext()
		{
			int num = int_0;
			Enum9 result;
			try
			{
				TaskAwaiter awaiter;
				Class145 @class;
				bool flag2;
				bool flag;
				bool flag3;
				float f;
				float f2;
				string value;
				long num2;
				switch (num)
				{
				default:
					long_0 = smethod_7(int_1, "delayBeforePressSeconds", class75_0.long_0);
					long_1 = smethod_7(double_0, "timeoutSeconds", class75_0.long_0);
					if (int_2 <= 0)
					{
						throw new ArgumentOutOfRangeException("pollIntervalMilliseconds");
					}
					if (gform0_0 == null)
					{
						result = (Enum9)8;
					}
					else if (!bool_0)
					{
						result = (Enum9)1;
					}
					else if (bool_1 && string.IsNullOrWhiteSpace(string_0))
					{
						result = (Enum9)3;
					}
					else
					{
						class119_0 = gform0_0.method_7();
						if (class119_0 != null)
						{
							long_2 = class75_0.func_0();
							flag = false;
							num2 = long_0;
							goto IL_010d;
						}
						result = (Enum9)8;
					}
					goto end_IL_0007;
				case 0:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_019b;
				case 1:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_02d4;
				case 2:
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						goto IL_05c5;
					}
					IL_0231:
					if ((flag = gform0_0.method_4()) || gform0_0.method_7() != class119_0)
					{
						goto IL_0331;
					}
					if (!smethod_4(@class))
					{
						goto IL_0282;
					}
					if (smethod_5(@class, string_1, out struct27_0, out flag2))
					{
						goto IL_0331;
					}
					if (flag2)
					{
						goto IL_0282;
					}
					result = (Enum9)2;
					goto end_IL_0007;
					IL_02d4:
					awaiter.GetResult();
					int_3 += int_4;
					@class = gform0_0.method_5();
					goto IL_0231;
					IL_0331:
					if (gform0_0.method_7() != class119_0)
					{
						result = (Enum9)8;
					}
					else if (flag)
					{
						result = (Enum9)7;
					}
					else
					{
						Class83 class2 = @class.method_0();
						if (flag3 = class2 != null)
						{
							float_0 = class2.float_0;
							float_1 = class2.float_2;
						}
						else
						{
							float_0 = float.NaN;
							float_1 = float.NaN;
						}
						if (gform0_0.method_7() != class119_0)
						{
							result = (Enum9)8;
						}
						else if (flag3 && !float.IsNaN(float_0) && !float.IsNaN(float_1))
						{
							class119_1 = gform0_0.method_7();
							if (class119_1 != null && class119_1 == class119_0)
							{
								Class412.smethod_15();
								if (bool_1)
								{
									class119_1.method_171(string_0.Trim(), struct27_0.int_1, struct27_0.ushort_0, struct27_0.ushort_1);
								}
								else
								{
									class119_1.method_170(struct27_0.int_1, struct27_0.ushort_0, struct27_0.ushort_1);
								}
								long_3 = class75_0.func_0();
								flag = false;
								goto IL_04c5;
							}
							result = (Enum9)8;
						}
						else
						{
							result = (Enum9)4;
						}
					}
					goto end_IL_0007;
					IL_010d:
					if (!(flag = gform0_0.method_4()) && gform0_0.method_7() == class119_0 && (num2 = smethod_8(long_2, long_0, class75_0.func_0())) > 0L)
					{
						awaiter = class75_0.func_1(smethod_9(num2, class75_0.long_0, int_2)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_019b;
					}
					if (flag)
					{
						result = (Enum9)7;
					}
					else
					{
						if (gform0_0.method_7() == class119_0)
						{
							@class = gform0_0.method_5();
							int_3 = 0;
							struct27_0 = default(Struct27);
							goto IL_0231;
						}
						result = (Enum9)8;
					}
					goto end_IL_0007;
					IL_04c5:
					if ((flag = gform0_0.method_4()) || gform0_0.method_7() != class119_1)
					{
						break;
					}
					flag3 = gform0_0.smethod_34(bool_1, out f, out f2, out value);
					if (gform0_0.method_7() == class119_1)
					{
						if (string.IsNullOrEmpty(value))
						{
							if (!flag3 || float.IsNaN(f) || float.IsNaN(f2) || Class440.smethod_19(f, f2, float_0, float_1) <= 30f)
							{
								num2 = smethod_8(long_3, long_1, class75_0.func_0());
								if (num2 > 0L)
								{
									awaiter = class75_0.func_1(smethod_9(num2, class75_0.long_0, int_2)).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 2;
										int_0 = 2;
										taskAwaiter_0 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_05c5;
								}
								result = (Enum9)6;
							}
							else
							{
								result = (Enum9)0;
							}
						}
						else
						{
							result = (Enum9)5;
						}
					}
					else
					{
						result = (Enum9)8;
					}
					goto end_IL_0007;
					IL_05c5:
					awaiter.GetResult();
					goto IL_04c5;
					IL_019b:
					awaiter.GetResult();
					goto IL_010d;
					IL_0282:
					if (int_3 < 3500)
					{
						int_4 = Math.Min(int_2, 3500 - int_3);
						awaiter = class75_0.func_1(int_4).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02d4;
					}
					result = (Enum9)1;
					goto end_IL_0007;
				}
				result = ((!flag) ? ((Enum9)8) : ((Enum9)7));
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class119_0 = null;
				class119_1 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class119_0 = null;
			class119_1 = null;
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

	internal static Task<Enum9> smethod_0(GForm0 gform0_0, int int_0, int int_1, double double_0)
	{
		Class75 @class = Class75.smethod_0();
		return smethod_3(gform0_0, "Start Point Pass", string.Empty, bool_0: false, @class.method_0(), int_0, int_1, double_0, @class);
	}

	internal static Task<Enum9> smethod_1(GForm0 gform0_0, int int_0, int int_1, double double_0)
	{
		Class75 @class = Class75.smethod_0();
		return smethod_3(gform0_0, "Back Point Pass", string.Empty, bool_0: false, @class.method_0(), int_0, int_1, double_0, @class);
	}

	internal static Task<Enum9> smethod_2(GForm0 gform0_0, string string_0, int int_0, int int_1, double double_0)
	{
		Class75 @class = Class75.smethod_0();
		return smethod_3(gform0_0, "Buddy Transmission Card", string_0, bool_0: true, @class.method_1(), int_0, int_1, double_0, @class);
	}

	private static async Task<Enum9> smethod_3(GForm0 gform0_0, string string_0, string string_1, bool bool_0, bool bool_1, int int_0, int int_1, double double_0, Class75 class75_0)
	{
		long num = smethod_7(int_0, "delayBeforePressSeconds", class75_0.long_0);
		long long_ = smethod_7(double_0, "timeoutSeconds", class75_0.long_0);
		if (int_1 <= 0)
		{
			throw new ArgumentOutOfRangeException("pollIntervalMilliseconds");
		}
		if (gform0_0 == null)
		{
			return (Enum9)8;
		}
		if (!bool_1)
		{
			return (Enum9)1;
		}
		if (bool_0 && string.IsNullOrWhiteSpace(string_1))
		{
			return (Enum9)3;
		}
		Class119 @class = gform0_0.method_7();
		if (@class == null)
		{
			return (Enum9)8;
		}
		long long_2 = class75_0.func_0();
		_ = num;
		bool flag;
		long long_3;
		while (!(flag = gform0_0.method_4()) && gform0_0.method_7() == @class && (long_3 = smethod_8(long_2, num, class75_0.func_0())) > 0L)
		{
			await class75_0.func_1(smethod_9(long_3, class75_0.long_0, int_1));
		}
		if (flag)
		{
			return (Enum9)7;
		}
		if (gform0_0.method_7() != @class)
		{
			return (Enum9)8;
		}
		Class145 class2 = gform0_0.method_5();
		int num2 = 0;
		Struct27 struct27_ = default(Struct27);
		while (!(flag = gform0_0.method_4()) && gform0_0.method_7() == @class)
		{
			if (smethod_4(class2))
			{
				if (smethod_5(class2, string_0, out struct27_, out var bool_2))
				{
					break;
				}
				if (!bool_2)
				{
					return (Enum9)2;
				}
			}
			if (num2 < 3500)
			{
				int num3 = Math.Min(int_1, 3500 - num2);
				await class75_0.func_1(num3);
				num2 += num3;
				class2 = gform0_0.method_5();
				continue;
			}
			return (Enum9)1;
		}
		if (gform0_0.method_7() != @class)
		{
			return (Enum9)8;
		}
		if (flag)
		{
			return (Enum9)7;
		}
		Class83 class3 = class2.method_0();
		float num4;
		float num5;
		bool flag2;
		if (flag2 = class3 != null)
		{
			num4 = class3.float_0;
			num5 = class3.float_2;
		}
		else
		{
			num4 = float.NaN;
			num5 = float.NaN;
		}
		if (gform0_0.method_7() != @class)
		{
			return (Enum9)8;
		}
		if (flag2 && !float.IsNaN(num4) && !float.IsNaN(num5))
		{
			Class119 class4 = gform0_0.method_7();
			if (class4 != null && class4 == @class)
			{
				Class412.smethod_15();
				if (bool_0)
				{
					class4.method_171(string_1.Trim(), struct27_.int_1, struct27_.ushort_0, struct27_.ushort_1);
				}
				else
				{
					class4.method_170(struct27_.int_1, struct27_.ushort_0, struct27_.ushort_1);
				}
				long long_4 = class75_0.func_0();
				while (!(flag = gform0_0.method_4()) && gform0_0.method_7() == class4)
				{
					flag2 = gform0_0.smethod_34(bool_0, out var float_, out var float_2, out var string_2);
					if (gform0_0.method_7() == class4)
					{
						if (string.IsNullOrEmpty(string_2))
						{
							if (!flag2 || float.IsNaN(float_) || float.IsNaN(float_2) || Class440.smethod_19(float_, float_2, num4, num5) <= 30f)
							{
								long_3 = smethod_8(long_4, long_, class75_0.func_0());
								if (long_3 <= 0L)
								{
									return (Enum9)6;
								}
								await class75_0.func_1(smethod_9(long_3, class75_0.long_0, int_1));
								continue;
							}
							return (Enum9)0;
						}
						return (Enum9)5;
					}
					return (Enum9)8;
				}
				if (flag)
				{
					return (Enum9)7;
				}
				return (Enum9)8;
			}
			return (Enum9)8;
		}
		return (Enum9)4;
	}

	private static bool smethod_4(Class145 class145_0)
	{
		if (class145_0 != null && class145_0.method_43() != 0 && string.IsNullOrEmpty(class145_0.method_51()) && class145_0.method_45() != 0L)
		{
			long num = DateTime.UtcNow.Ticks - class145_0.method_45();
			if (num >= 0L)
			{
				return num <= 30000000L;
			}
			return false;
		}
		return false;
	}

	private static bool smethod_5(Class145 class145_0, string string_0, out Struct27 struct27_0, out bool bool_0)
	{
		struct27_0 = default(Struct27);
		bool_0 = false;
		bool flag = false;
		IReadOnlyList<Struct27> readOnlyList = class145_0.method_39();
		IReadOnlyDictionary<string, string> readOnlyDictionary = ((class145_0.method_10() == null) ? null : class145_0.method_10().method_2());
		if (readOnlyList != null && readOnlyDictionary != null)
		{
			for (int i = 0; i < readOnlyList.Count; i++)
			{
				Struct27 @struct = readOnlyList[i];
				if (@struct.int_2 <= 0 || @struct.int_1 < 0 || (class145_0.method_49() > 0 && @struct.int_1 >= class145_0.method_49()))
				{
					continue;
				}
				string key = @struct.ushort_0.ToString(CultureInfo.InvariantCulture) + ":" + @struct.ushort_1.ToString(CultureInfo.InvariantCulture);
				if (readOnlyDictionary.TryGetValue(key, out var value) && !string.IsNullOrWhiteSpace(value))
				{
					if (smethod_6(value, string_0) && (!flag || @struct.int_1 < struct27_0.int_1))
					{
						struct27_0 = @struct;
						flag = true;
					}
				}
				else
				{
					bool_0 = true;
				}
			}
			return flag;
		}
		return false;
	}

	private static bool smethod_6(string string_0, string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return false;
		}
		string text = string_0.Trim();
		if (string.Equals(text, string_1, StringComparison.OrdinalIgnoreCase))
		{
			return true;
		}
		string text2 = string_1 + " [";
		if (text.StartsWith(text2, StringComparison.OrdinalIgnoreCase) && text.EndsWith("D]", StringComparison.OrdinalIgnoreCase))
		{
			int length = text2.Length;
			int num = text.Length - 2;
			if (num == length)
			{
				return false;
			}
			int num2 = length;
			while (true)
			{
				if (num2 < num)
				{
					if (text[num2] < '0' || text[num2] > '9')
					{
						break;
					}
					num2++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	private static long smethod_7(double double_0, string string_0, long long_0)
	{
		if (!double.IsNaN(double_0) && !double.IsInfinity(double_0) && double_0 >= 0.0)
		{
			decimal num;
			try
			{
				num = (decimal)double_0 * (decimal)long_0;
			}
			catch (OverflowException)
			{
				throw new ArgumentOutOfRangeException(string_0);
			}
			if (num > 9223372036854775807m)
			{
				throw new ArgumentOutOfRangeException(string_0);
			}
			return decimal.ToInt64(decimal.Ceiling(num));
		}
		throw new ArgumentOutOfRangeException(string_0);
	}

	private static long smethod_8(long long_0, long long_1, long long_2)
	{
		decimal num = (decimal)long_2 - (decimal)long_0;
		if (!(num < 0m) && !(num >= (decimal)long_1))
		{
			return long_1 - decimal.ToInt64(num);
		}
		return 0L;
	}

	private static int smethod_9(long long_0, long long_1, int int_0)
	{
		double num = (double)long_0 * 1000.0 / (double)long_1;
		int val = ((num >= 2147483647.0) ? int.MaxValue : Math.Max(1, (int)Math.Ceiling(num)));
		return Math.Min(int_0, val);
	}
}
