using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public static class GClass7
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct25 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private bool bool_0;

		private Struct27 struct27_0;

		private ushort? nullable_0;

		private Class119 class119_0;

		private bool? nullable_1;

		private TaskAwaiter<bool> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private ushort? nullable_2;

		private TaskAwaiter<int> taskAwaiter_2;

		private TaskAwaiter taskAwaiter_3;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<bool> awaiter4;
				TaskAwaiter<string> awaiter3;
				TaskAwaiter<int> awaiter2;
				TaskAwaiter awaiter;
				string result3;
				bool result2;
				int num3;
				switch (num)
				{
				default:
					if (gform0_0 != null)
					{
						awaiter4 = gform0_0.smethod_6(47).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter4;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_008e;
					}
					result = false;
					goto end_IL_0007;
				case 0:
					awaiter4 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_008e;
				case 1:
					awaiter4 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_00fc;
				case 2:
					awaiter3 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_0168;
				case 3:
					awaiter2 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<int>);
					num = -1;
					int_0 = -1;
					goto IL_0405;
				case 4:
					{
						awaiter = taskAwaiter_3;
						taskAwaiter_3 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_00fc:
					result2 = awaiter4.GetResult();
					bool_0 = result2;
					awaiter3 = gform0_0.smethod_8(6).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 2;
						int_0 = 2;
						taskAwaiter_1 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0168;
					IL_04d1:
					if (nullable_0.HasValue && nullable_0.Value != 0)
					{
						bool? flag = smethod_3(gform0_0.method_5().method_24());
						result2 = false;
						result = flag == false && class119_0.method_157(struct27_0.int_0, struct27_0.ushort_0, struct27_0.ushort_1) != 0;
					}
					else
					{
						result = false;
					}
					goto end_IL_0007;
					IL_0168:
					result3 = awaiter3.GetResult();
					if (string.IsNullOrWhiteSpace(result3))
					{
						result = false;
					}
					else if (!smethod_1(gform0_0.method_5(), result3, out struct27_0))
					{
						result = false;
					}
					else
					{
						nullable_0 = gform0_0.method_5().method_24().nullable_0;
						class119_0 = gform0_0.method_7();
						Class148 @class = gform0_0.method_14();
						if (class119_0 != null && @class != null && !class119_0.method_27() && !smethod_8(class119_0.method_25(), gform0_0.method_5().method_89()))
						{
							nullable_1 = smethod_3(gform0_0.method_5().method_24());
							if (!nullable_1.HasValue)
							{
								result = false;
							}
							else
							{
								int? num2 = nullable_0;
								num3 = 0;
								if (num2 > 0 || nullable_1 == true)
								{
									@class.int_4 = struct27_0.int_0;
								}
								if (!smethod_5(gform0_0.method_5().method_24(), @class.int_4 == struct27_0.int_0))
								{
									goto IL_0388;
								}
								if (@class.int_5 != struct27_0.int_0)
								{
									uint num4 = class119_0.method_157(struct27_0.int_0, struct27_0.ushort_0, struct27_0.ushort_1);
									if (num4 == 0)
									{
										result = false;
									}
									else
									{
										@class.int_5 = struct27_0.int_0;
										@class.uint_0 = num4;
										result = true;
									}
								}
								else
								{
									if (smethod_6(@class.uint_0, class119_0.method_25(), gform0_0.method_5().method_89()))
									{
										@class.int_4 = struct27_0.int_0;
										goto IL_0388;
									}
									result = false;
								}
							}
						}
						else
						{
							result = false;
						}
					}
					goto end_IL_0007;
					IL_008e:
					if (awaiter4.GetResult())
					{
						awaiter4 = gform0_0.smethod_6(64).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_0 = awaiter4;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_00fc;
					}
					result = false;
					goto end_IL_0007;
					IL_0388:
					if (result2 = bool_0)
					{
						nullable_2 = nullable_0;
						awaiter2 = gform0_0.smethod_10(2).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 3;
							int_0 = 3;
							taskAwaiter_2 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0405;
					}
					goto IL_041c;
					IL_0405:
					num3 = awaiter2.GetResult();
					result2 = smethod_4(nullable_2, num3);
					goto IL_041c;
					IL_041c:
					if (!result2)
					{
						goto IL_04d1;
					}
					if (nullable_1 == true)
					{
						if (smethod_2(gform0_0.method_5(), out var @struct) && class119_0.method_156(@struct.int_0, @struct.ushort_0, @struct.ushort_1, struct27_0.int_0, struct27_0.ushort_0, struct27_0.ushort_1) != 0)
						{
							awaiter = Task.Delay(2000).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 4;
								int_0 = 4;
								taskAwaiter_3 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						goto IL_04d1;
					}
					result = false;
					goto end_IL_0007;
				}
				awaiter.GetResult();
				result = true;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class119_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class119_0 = null;
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

	public static async Task<bool> smethod_0(GForm0 gform0_0)
	{
		if (gform0_0 == null)
		{
			return false;
		}
		if (!(await gform0_0.smethod_6(47)))
		{
			return false;
		}
		bool flag = await gform0_0.smethod_6(64);
		string text = await gform0_0.smethod_8(6);
		if (string.IsNullOrWhiteSpace(text))
		{
			return false;
		}
		if (!smethod_1(gform0_0.method_5(), text, out var struct27_))
		{
			return false;
		}
		ushort? nullable_ = gform0_0.method_5().method_24().nullable_0;
		Class119 @class = gform0_0.method_7();
		Class148 class2 = gform0_0.method_14();
		if (@class != null && class2 != null && !@class.method_27() && !smethod_8(@class.method_25(), gform0_0.method_5().method_89()))
		{
			bool? flag2 = smethod_3(gform0_0.method_5().method_24());
			if (!flag2.HasValue)
			{
				return false;
			}
			if (nullable_ > 0 || flag2 == true)
			{
				class2.int_4 = struct27_.int_0;
			}
			if (smethod_5(gform0_0.method_5().method_24(), class2.int_4 == struct27_.int_0))
			{
				if (class2.int_5 != struct27_.int_0)
				{
					uint num = @class.method_157(struct27_.int_0, struct27_.ushort_0, struct27_.ushort_1);
					if (num == 0)
					{
						return false;
					}
					class2.int_5 = struct27_.int_0;
					class2.uint_0 = num;
					return true;
				}
				if (!smethod_6(class2.uint_0, @class.method_25(), gform0_0.method_5().method_89()))
				{
					return false;
				}
				class2.int_4 = struct27_.int_0;
			}
			bool flag3;
			if (flag3 = flag)
			{
				ushort? nullable_2 = nullable_;
				flag3 = smethod_4(nullable_2, await gform0_0.smethod_10(2));
			}
			if (flag3)
			{
				if (flag2 != true)
				{
					return false;
				}
				if (smethod_2(gform0_0.method_5(), out var struct27_2) && @class.method_156(struct27_2.int_0, struct27_2.ushort_0, struct27_2.ushort_1, struct27_.int_0, struct27_.ushort_0, struct27_.ushort_1) != 0)
				{
					await Task.Delay(2000);
					return true;
				}
			}
			if (nullable_.HasValue && nullable_.Value != 0)
			{
				if (smethod_3(gform0_0.method_5().method_24()) != false)
				{
					return false;
				}
				return @class.method_157(struct27_.int_0, struct27_.ushort_0, struct27_.ushort_1) != 0;
			}
			return false;
		}
		return false;
	}

	internal static bool smethod_1(Class145 class145_0, string string_0, out Struct27 struct27_0)
	{
		struct27_0 = default(Struct27);
		if (class145_0 != null && class145_0.method_43() != 0 && !string.IsNullOrWhiteSpace(string_0))
		{
			int num = 0;
			Struct27 @struct;
			while (true)
			{
				if (num < class145_0.method_39().Count)
				{
					@struct = class145_0.method_39()[num];
					if (@struct.nullable_0 == 51 && @struct.int_2 > 0 && @struct.int_0 >= 0 && @struct.int_0 <= 65535 && class145_0.method_10().method_2().TryGetValue(smethod_9(@struct), out var value) && string.Equals(value.Trim(), string_0.Trim(), StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			struct27_0 = @struct;
			return true;
		}
		return false;
	}

	internal static bool smethod_2(Class145 class145_0, out Struct27 struct27_0)
	{
		struct27_0 = default(Struct27);
		if (class145_0 != null && class145_0.method_43() != 0)
		{
			int num = 0;
			Struct27 @struct;
			while (true)
			{
				if (num < class145_0.method_39().Count)
				{
					@struct = class145_0.method_39()[num];
					if (@struct.nullable_0 == 52 && @struct.int_2 > 0 && @struct.int_0 >= 0 && @struct.int_0 <= 65535)
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			struct27_0 = @struct;
			return true;
		}
		return false;
	}

	internal static bool? smethod_3(Struct26 struct26_0)
	{
		if (struct26_0.bool_0 && struct26_0.nullable_1.HasValue && struct26_0.nullable_2.HasValue && struct26_0.nullable_3.HasValue)
		{
			if (struct26_0.nullable_1.Value != ushort.MaxValue && struct26_0.nullable_2.Value != 0 && struct26_0.nullable_3.Value)
			{
				return true;
			}
			if (struct26_0.nullable_1.Value == ushort.MaxValue && struct26_0.nullable_2.Value == 0 && !struct26_0.nullable_3.Value)
			{
				return false;
			}
			return null;
		}
		return null;
	}

	internal static bool smethod_4(ushort? nullable_0, int int_0)
	{
		if (nullable_0.HasValue)
		{
			return nullable_0.Value < int_0 * 10;
		}
		return false;
	}

	internal static bool smethod_5(Struct26 struct26_0, bool bool_0)
	{
		int? num = struct26_0.nullable_0;
		if (((num.GetValueOrDefault() == 0) & num.HasValue) && smethod_3(struct26_0) == false)
		{
			return !bool_0;
		}
		return false;
	}

	internal static bool smethod_6(uint uint_0, Class194 class194_0, int int_0)
	{
		if (uint_0 != 0 && class194_0 != null && class194_0.uint_0 == uint_0 && class194_0.string_0 == "summon" && class194_0.bool_1)
		{
			return int_0 > class194_0.int_0;
		}
		return false;
	}

	internal static int smethod_7(ushort ushort_0)
	{
		return Math.Min(100, ushort_0 / 10);
	}

	internal static bool smethod_8(Class194 class194_0, int int_0)
	{
		if (class194_0 != null)
		{
			return int_0 <= class194_0.int_0;
		}
		return false;
	}

	private static string smethod_9(Struct27 struct27_0)
	{
		return struct27_0.ushort_0.ToString(CultureInfo.InvariantCulture) + ":" + struct27_0.ushort_1.ToString(CultureInfo.InvariantCulture);
	}
}
