using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal static class Class188
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct69 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public float float_0;

		private IReadOnlyList<int> ireadOnlyList_0;

		private bool bool_0;

		private bool bool_1;

		private int int_1;

		private int int_2;

		private bool bool_2;

		private int int_3;

		private TaskAwaiter<IReadOnlyList<int>> taskAwaiter_0;

		private TaskAwaiter taskAwaiter_1;

		private TaskAwaiter<bool> taskAwaiter_2;

		private TaskAwaiter<IReadOnlyList<Struct76>> taskAwaiter_3;

		private Struct76 struct76_0;

		private TaskAwaiter<string> taskAwaiter_4;

		private bool bool_3;

		private void MoveNext()
		{
			int num = int_0;
			bool result2;
			try
			{
				TaskAwaiter<IReadOnlyList<int>> awaiter5;
				TaskAwaiter<IReadOnlyList<Struct76>> awaiter4;
				TaskAwaiter<bool> awaiter3;
				TaskAwaiter<string> awaiter2;
				TaskAwaiter awaiter;
				IReadOnlyList<Struct76> result;
				float? num2;
				float? num3;
				byte? b;
				byte? b2;
				int num6;
				IReadOnlyList<int> result3;
				int num7;
				bool result5;
				Class398 class2;
				bool result6;
				bool result7;
				Class119 class4;
				string result4;
				int num8;
				switch (num)
				{
				default:
					awaiter5 = smethod_2(gform0_0).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter5;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
						return;
					}
					goto IL_00b1;
				case 0:
					awaiter5 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<IReadOnlyList<int>>);
					num = -1;
					int_0 = -1;
					goto IL_00b1;
				case 1:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0197;
				case 2:
					awaiter3 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_01c1;
				case 3:
					awaiter3 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_022d;
				case 4:
					awaiter4 = taskAwaiter_3;
					taskAwaiter_3 = default(TaskAwaiter<IReadOnlyList<Struct76>>);
					num = -1;
					int_0 = -1;
					goto IL_0356;
				case 5:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_07bd;
				case 6:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0832;
				case 7:
					awaiter2 = taskAwaiter_4;
					taskAwaiter_4 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_086e;
				case 8:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0968;
				case 9:
					awaiter3 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0992;
				case 10:
					awaiter2 = taskAwaiter_4;
					taskAwaiter_4 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_0a03;
				case 11:
					awaiter3 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0a9c;
				case 12:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0caa;
				case 13:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0ce5;
				case 14:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0d0f;
				case 15:
					awaiter2 = taskAwaiter_4;
					taskAwaiter_4 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_0d3a;
				case 16:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0e3b;
				case 17:
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_0356:
					result = awaiter4.GetResult();
					num2 = gform0_0.method_5().method_0()?.float_0;
					num3 = gform0_0.method_5().method_0()?.float_2;
					b = gform0_0.method_5().method_0()?.byte_0;
					b2 = gform0_0.method_5().method_0()?.byte_3;
					if (num2.HasValue && num3.HasValue && b.HasValue && b2.HasValue)
					{
						float value = num2.Value;
						float value2 = num3.Value;
						byte value3 = b.Value;
						byte value4 = b2.Value;
						if (result != null && result.Count != 0)
						{
							if (bool_2)
							{
								if (bool_1)
								{
									awaiter = gform0_0.smethod_13(67, Class185.smethod_0(-1141038788) + int_1 + Class185.smethod_0(-1141038834)).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 6;
										int_0 = 6;
										taskAwaiter_1 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_0832;
								}
								awaiter2 = gform0_0.smethod_8(4).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = 7;
									int_0 = 7;
									taskAwaiter_4 = awaiter2;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_086e;
							}
							Class412.smethod_7();
							if (int_2 >= result.Count)
							{
								smethod_5(ireadOnlyList_0, bool_0);
								result2 = true;
							}
							else
							{
								struct76_0 = result[int_2];
								float num4 = Class440.smethod_19(value, value2, struct76_0.float_0, struct76_0.float_2);
								float num5 = Class440.smethod_21(int_2, result.Count);
								if (num4 > num5)
								{
									if (value3 == 0)
									{
										num6 = ((value4 != 0) ? 1 : 0);
										if (num6 == 0)
										{
											if (dateTime_3 == DateTime.MinValue)
											{
												dateTime_3 = DateTime.Now;
											}
											goto IL_052e;
										}
									}
									else
									{
										num6 = 1;
									}
									dateTime_3 = DateTime.MinValue;
									goto IL_052e;
								}
								dateTime_3 = DateTime.MinValue;
								if (int_2 >= result.Count - 1)
								{
									smethod_3(gform0_0);
									goto IL_06ca;
								}
								int_2++;
								smethod_12(int_1, int_2, bool_1: false);
								Struct76 @struct = result[int_2];
								Class119 @class = gform0_0.method_7();
								if (@class != null)
								{
									@class.method_176(@struct.float_0, @struct.float_1, @struct.float_2, bool_17: true, Class185.smethod_0(-1141038829));
									goto IL_06ca;
								}
								result2 = false;
							}
						}
						else
						{
							smethod_5(ireadOnlyList_0, bool_0);
							result2 = true;
						}
					}
					else
					{
						result2 = false;
					}
					goto end_IL_0007;
					IL_00b1:
					result3 = awaiter5.GetResult();
					ireadOnlyList_0 = result3;
					if (gform0_0.method_5().method_0() != null)
					{
						if (ireadOnlyList_0 != null && ireadOnlyList_0.Count != 0)
						{
							awaiter3 = gform0_0.smethod_6(54).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 2;
								int_0 = 2;
								taskAwaiter_2 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_01c1;
						}
						smethod_17();
						awaiter = gform0_0.smethod_13(67, string.Empty).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0197;
					}
					result2 = false;
					goto end_IL_0007;
					IL_0d3a:
					result4 = awaiter2.GetResult();
					num7 = Class440.smethod_1(bool_0: true, result4);
					if (smethod_10(ref dateTime_2, num7))
					{
						awaiter = gform0_0.smethod_13(67, Class185.smethod_0(-1141038788) + int_1 + Class185.smethod_0(-1141301932) + Class2.smethod_2(Class185.smethod_0(-1141038904), num7, dateTime_2)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 16;
							int_0 = 16;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0e3b;
					}
					awaiter = gform0_0.smethod_13(67, string.Empty).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 17;
						int_0 = 17;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
					IL_0caa:
					awaiter.GetResult();
					smethod_5(ireadOnlyList_0, bool_0);
					result2 = true;
					goto end_IL_0007;
					IL_06ca:
					result2 = true;
					goto end_IL_0007;
					IL_0992:
					result5 = awaiter3.GetResult();
					bool_3 = result5;
					awaiter2 = gform0_0.smethod_8(16).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 10;
						int_0 = 10;
						taskAwaiter_4 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0a03;
					IL_0a03:
					result4 = awaiter2.GetResult();
					int_3 = Class440.smethod_1(bool_3, result4);
					class2 = Class412.smethod_1();
					awaiter3 = Class65.smethod_1(gform0_0, float_0, class2.float_0, class2.float_1, class2.float_2).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 11;
						int_0 = 11;
						taskAwaiter_2 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0a9c;
					IL_01c1:
					result6 = awaiter3.GetResult();
					bool_0 = result6;
					awaiter3 = gform0_0.smethod_6(46).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 3;
						int_0 = 3;
						taskAwaiter_2 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_022d;
					IL_0832:
					awaiter.GetResult();
					smethod_5(ireadOnlyList_0, bool_0);
					result2 = true;
					goto end_IL_0007;
					IL_022d:
					result6 = awaiter3.GetResult();
					bool_1 = result6;
					if (gform0_0.method_5().method_0() != null)
					{
						Class132 class3 = smethod_11();
						int_1 = class3.int_0;
						int_2 = class3.int_1;
						bool_2 = class3.bool_0;
						if (int_1 == 0 || smethod_9(ireadOnlyList_0, int_1) < 0)
						{
							int_1 = (bool_0 ? smethod_7(ireadOnlyList_0) : ireadOnlyList_0[0]);
							smethod_4(int_1);
							class3 = smethod_11();
							int_2 = class3.int_1;
							bool_2 = class3.bool_0;
						}
						awaiter4 = gform0_0.smethod_17(int_1).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num = 4;
							int_0 = 4;
							taskAwaiter_3 = awaiter4;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_0356;
					}
					result2 = false;
					goto end_IL_0007;
					IL_0a9c:
					result7 = awaiter3.GetResult();
					if (gform0_0.method_5().method_0() != null)
					{
						if (result7)
						{
							Class188.bool_0 = false;
							if (dateTime_1 == DateTime.MinValue)
							{
								dateTime_1 = DateTime.Now;
							}
							if (int_3 > 0 && (DateTime.Now - dateTime_1).TotalSeconds >= (double)int_3)
							{
								awaiter = gform0_0.smethod_13(67, string.Empty).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 12;
									int_0 = 12;
									taskAwaiter_1 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0caa;
							}
							awaiter = gform0_0.smethod_13(67, Class185.smethod_0(-1141038788) + int_1 + Class185.smethod_0(-1141301932) + (Class2.smethod_2(Class185.smethod_0(-1141319207), int_3, dateTime_1) ?? Class185.smethod_0(-1141319207))).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 13;
								int_0 = 13;
								taskAwaiter_1 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0ce5;
						}
						dateTime_1 = DateTime.MinValue;
						if (!Class188.bool_0)
						{
							Class188.bool_0 = true;
							awaiter = gform0_0.smethod_13(67, string.Empty).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 14;
								int_0 = 14;
								taskAwaiter_1 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0d0f;
						}
						awaiter2 = gform0_0.smethod_8(8).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 15;
							int_0 = 15;
							taskAwaiter_4 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0d3a;
					}
					result2 = false;
					goto end_IL_0007;
					IL_052e:
					if (num6 != 0 || !(dateTime_3 != DateTime.MinValue) || !((DateTime.Now - dateTime_3).TotalSeconds >= 5.0))
					{
						awaiter = gform0_0.smethod_13(67, Class185.smethod_0(-1141038788) + int_1 + Class185.smethod_0(-1141038808) + (int_2 + 1) + Class185.smethod_0(-1141300031) + result.Count).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 5;
							int_0 = 5;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_07bd;
					}
					dateTime_3 = DateTime.MinValue;
					smethod_1(gform0_0, result.Count);
					result2 = true;
					goto end_IL_0007;
					IL_0968:
					awaiter.GetResult();
					result2 = true;
					goto end_IL_0007;
					IL_0197:
					awaiter.GetResult();
					result2 = false;
					goto end_IL_0007;
					IL_0d0f:
					awaiter.GetResult();
					result2 = true;
					goto end_IL_0007;
					IL_07bd:
					awaiter.GetResult();
					class4 = gform0_0.method_7();
					if (class4 == null)
					{
						result2 = false;
					}
					else
					{
						class4.method_176(struct76_0.float_0, struct76_0.float_1, struct76_0.float_2, bool_17: true, Class185.smethod_0(-1141038829));
						result2 = true;
					}
					goto end_IL_0007;
					IL_086e:
					result4 = awaiter2.GetResult();
					num8 = Class440.smethod_1(bool_0: true, result4);
					if (smethod_10(ref dateTime_0, num8))
					{
						awaiter = gform0_0.smethod_13(67, Class185.smethod_0(-1141038788) + int_1 + Class185.smethod_0(-1141301932) + Class2.smethod_2(Class185.smethod_0(-1141038873), num8, dateTime_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 8;
							int_0 = 8;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0968;
					}
					awaiter3 = gform0_0.smethod_6(68).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 9;
						int_0 = 9;
						taskAwaiter_2 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0992;
					IL_0ce5:
					awaiter.GetResult();
					result2 = true;
					goto end_IL_0007;
					IL_0e3b:
					awaiter.GetResult();
					result2 = true;
					goto end_IL_0007;
				}
				awaiter.GetResult();
				smethod_5(ireadOnlyList_0, bool_0);
				result2 = true;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				ireadOnlyList_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			ireadOnlyList_0 = null;
			asyncTaskMethodBuilder_0.SetResult(result2);
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

	private static Class132 class132_0 = new Class132(0, -1, bool_1: false);

	private static DateTime dateTime_0 = DateTime.MinValue;

	private static DateTime dateTime_1 = DateTime.MinValue;

	private static DateTime dateTime_2 = DateTime.MinValue;

	private static DateTime dateTime_3 = DateTime.MinValue;

	private static bool bool_0;

	private static List<int> list_0 = new List<int>();

	private static int int_0;

	public static async Task<bool> smethod_0(GForm0 gform0_0, float float_0)
	{
		IReadOnlyList<int> readOnlyList = await smethod_2(gform0_0);
		if (gform0_0.method_5().method_0() == null)
		{
			return false;
		}
		if (readOnlyList == null || readOnlyList.Count == 0)
		{
			smethod_17();
			await gform0_0.smethod_13(67, string.Empty);
			return false;
		}
		bool flag = await gform0_0.smethod_6(54);
		bool flag2 = await gform0_0.smethod_6(46);
		if (gform0_0.method_5().method_0() == null)
		{
			return false;
		}
		Class132 @class = smethod_11();
		int num = @class.int_0;
		int int_ = @class.int_1;
		bool flag3 = @class.bool_0;
		if (num == 0 || smethod_9(readOnlyList, num) < 0)
		{
			num = (flag ? smethod_7(readOnlyList) : readOnlyList[0]);
			smethod_4(num);
			@class = smethod_11();
			int_ = @class.int_1;
			flag3 = @class.bool_0;
		}
		IReadOnlyList<Struct76> readOnlyList2 = await gform0_0.smethod_17(num);
		float? num2 = gform0_0.method_5().method_0()?.float_0;
		float? num3 = gform0_0.method_5().method_0()?.float_2;
		byte? b = gform0_0.method_5().method_0()?.byte_0;
		byte? b2 = gform0_0.method_5().method_0()?.byte_3;
		Struct76 @struct;
		int num6;
		if (num2.HasValue && num3.HasValue && b.HasValue && b2.HasValue)
		{
			float value = num2.Value;
			float value2 = num3.Value;
			byte value3 = b.Value;
			byte value4 = b2.Value;
			if (readOnlyList2 != null && readOnlyList2.Count != 0)
			{
				if (!flag3)
				{
					Class412.smethod_7();
					if (int_ >= readOnlyList2.Count)
					{
						smethod_5(readOnlyList, flag);
						return true;
					}
					@struct = readOnlyList2[int_];
					float num4 = Class440.smethod_19(value, value2, @struct.float_0, @struct.float_2);
					float num5 = Class440.smethod_21(int_, readOnlyList2.Count);
					if (num4 > num5)
					{
						if (value3 == 0)
						{
							num6 = ((value4 != 0) ? 1 : 0);
							if (num6 == 0)
							{
								if (dateTime_3 == DateTime.MinValue)
								{
									dateTime_3 = DateTime.Now;
								}
								goto IL_052e;
							}
						}
						else
						{
							num6 = 1;
						}
						dateTime_3 = DateTime.MinValue;
						goto IL_052e;
					}
					dateTime_3 = DateTime.MinValue;
					if (int_ >= readOnlyList2.Count - 1)
					{
						smethod_3(gform0_0);
					}
					else
					{
						int_++;
						smethod_12(num, int_, bool_1: false);
						Struct76 struct2 = readOnlyList2[int_];
						Class119 class2 = gform0_0.method_7();
						if (class2 == null)
						{
							return false;
						}
						class2.method_176(struct2.float_0, struct2.float_1, struct2.float_2, bool_17: true, Class185.smethod_0(-1141038829));
					}
					return true;
				}
				if (flag2)
				{
					await gform0_0.smethod_13(67, Class185.smethod_0(-1141038788) + num + Class185.smethod_0(-1141038834));
					smethod_5(readOnlyList, flag);
					return true;
				}
				int num7 = Class440.smethod_1(bool_0: true, await gform0_0.smethod_8(4));
				if (smethod_10(ref dateTime_0, num7))
				{
					await gform0_0.smethod_13(67, Class185.smethod_0(-1141038788) + num + Class185.smethod_0(-1141301932) + Class2.smethod_2(Class185.smethod_0(-1141038873), num7, dateTime_0));
					return true;
				}
				int num8 = Class440.smethod_1(await gform0_0.smethod_6(68), await gform0_0.smethod_8(16));
				Class398 class3 = Class412.smethod_1();
				bool flag4 = await Class65.smethod_1(gform0_0, float_0, class3.float_0, class3.float_1, class3.float_2);
				if (gform0_0.method_5().method_0() == null)
				{
					return false;
				}
				if (flag4)
				{
					bool_0 = false;
					if (dateTime_1 == DateTime.MinValue)
					{
						dateTime_1 = DateTime.Now;
					}
					if (num8 > 0 && (DateTime.Now - dateTime_1).TotalSeconds >= (double)num8)
					{
						await gform0_0.smethod_13(67, string.Empty);
						smethod_5(readOnlyList, flag);
						return true;
					}
					await gform0_0.smethod_13(67, Class185.smethod_0(-1141038788) + num + Class185.smethod_0(-1141301932) + (Class2.smethod_2(Class185.smethod_0(-1141319207), num8, dateTime_1) ?? Class185.smethod_0(-1141319207)));
					return true;
				}
				dateTime_1 = DateTime.MinValue;
				if (!bool_0)
				{
					bool_0 = true;
					await gform0_0.smethod_13(67, string.Empty);
					return true;
				}
				int num9 = Class440.smethod_1(bool_0: true, await gform0_0.smethod_8(8));
				if (smethod_10(ref dateTime_2, num9))
				{
					await gform0_0.smethod_13(67, Class185.smethod_0(-1141038788) + num + Class185.smethod_0(-1141301932) + Class2.smethod_2(Class185.smethod_0(-1141038904), num9, dateTime_2));
					return true;
				}
				await gform0_0.smethod_13(67, string.Empty);
				smethod_5(readOnlyList, flag);
				return true;
			}
			smethod_5(readOnlyList, flag);
			return true;
		}
		return false;
		IL_052e:
		if (num6 == 0 && dateTime_3 != DateTime.MinValue && (DateTime.Now - dateTime_3).TotalSeconds >= 5.0)
		{
			dateTime_3 = DateTime.MinValue;
			smethod_1(gform0_0, readOnlyList2.Count);
			return true;
		}
		await gform0_0.smethod_13(67, Class185.smethod_0(-1141038788) + num + Class185.smethod_0(-1141038808) + (int_ + 1) + Class185.smethod_0(-1141300031) + readOnlyList2.Count);
		Class119 class4 = gform0_0.method_7();
		if (class4 == null)
		{
			return false;
		}
		class4.method_176(@struct.float_0, @struct.float_1, @struct.float_2, bool_17: true, Class185.smethod_0(-1141038829));
		return true;
	}

	private static void smethod_1(GForm0 gform0_0, int int_1)
	{
		Class132 @class = smethod_11();
		if (@class.int_1 >= int_1 - 1)
		{
			smethod_3(gform0_0);
		}
		else
		{
			smethod_12(@class.int_0, @class.int_1 + 1, bool_1: false);
		}
	}

	private static Task<IReadOnlyList<int>> smethod_2(GForm0 gform0_0)
	{
		return gform0_0.smethod_18();
	}

	private static void smethod_3(GForm0 gform0_0)
	{
		float? num = gform0_0.method_5().method_0()?.float_0;
		float? num2 = gform0_0.method_5().method_0()?.float_1;
		float? num3 = gform0_0.method_5().method_0()?.float_2;
		if (num.HasValue && num2.HasValue && num3.HasValue)
		{
			Class132 @class = smethod_11();
			smethod_12(@class.int_0, @class.int_1, bool_1: true);
			dateTime_0 = (dateTime_1 = (dateTime_2 = DateTime.MinValue));
			bool_0 = false;
			Class412.smethod_6(num.Value, num2.Value, num3.Value);
		}
	}

	private static void smethod_4(int int_1)
	{
		smethod_12(int_1, 0, bool_1: false);
		dateTime_0 = (dateTime_1 = (dateTime_2 = (dateTime_3 = DateTime.MinValue)));
		bool_0 = false;
		Class412.smethod_7();
	}

	private static void smethod_5(IReadOnlyList<int> ireadOnlyList_0, bool bool_1)
	{
		Class412.smethod_7();
		Class132 @class = smethod_11();
		smethod_4(bool_1 ? smethod_7(ireadOnlyList_0) : smethod_6(ireadOnlyList_0, @class.int_0));
	}

	internal static int smethod_6(IReadOnlyList<int> ireadOnlyList_0, int int_1)
	{
		if (ireadOnlyList_0 != null && ireadOnlyList_0.Count != 0)
		{
			int num = smethod_9(ireadOnlyList_0, int_1);
			if (num < 0)
			{
				return ireadOnlyList_0[0];
			}
			return ireadOnlyList_0[(num + 1) % ireadOnlyList_0.Count];
		}
		return 0;
	}

	internal static int smethod_7(IReadOnlyList<int> ireadOnlyList_0)
	{
		if (ireadOnlyList_0 != null && ireadOnlyList_0.Count != 0)
		{
			if (!smethod_8(ireadOnlyList_0) || int_0 >= list_0.Count)
			{
				list_0 = new List<int>(ireadOnlyList_0);
				Random random = new Random();
				for (int num = list_0.Count - 1; num > 0; num--)
				{
					int index = random.Next(0, num + 1);
					int value = list_0[num];
					list_0[num] = list_0[index];
					list_0[index] = value;
				}
				int_0 = 0;
			}
			return list_0[int_0++];
		}
		return 0;
	}

	private static bool smethod_8(IReadOnlyList<int> ireadOnlyList_0)
	{
		if (list_0.Count != ireadOnlyList_0.Count)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < ireadOnlyList_0.Count)
			{
				if (!list_0.Contains(ireadOnlyList_0[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static int smethod_9(IReadOnlyList<int> ireadOnlyList_0, int int_1)
	{
		if (ireadOnlyList_0 == null)
		{
			return -1;
		}
		int num = 0;
		while (true)
		{
			if (num < ireadOnlyList_0.Count)
			{
				if (ireadOnlyList_0[num] == int_1)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	private static bool smethod_10(ref DateTime dateTime_4, int int_1)
	{
		if (int_1 <= 0)
		{
			return false;
		}
		if (dateTime_4 == DateTime.MinValue)
		{
			dateTime_4 = DateTime.Now;
		}
		return (DateTime.Now - dateTime_4).TotalSeconds < (double)int_1;
	}

	internal static Class132 smethod_11()
	{
		return Volatile.Read(ref class132_0);
	}

	internal static void smethod_12(int int_1, int int_2, bool bool_1)
	{
		Volatile.Write(ref class132_0, new Class132(int_1, int_2, bool_1));
	}

	public static int smethod_13()
	{
		return smethod_11().int_0;
	}

	public static int smethod_14()
	{
		return smethod_11().method_0();
	}

	public static bool smethod_15()
	{
		return smethod_11().bool_0;
	}

	internal static void smethod_16()
	{
		list_0 = new List<int>();
		int_0 = 0;
	}

	public static void smethod_17()
	{
		smethod_12(0, -1, bool_1: false);
		dateTime_0 = (dateTime_1 = (dateTime_2 = (dateTime_3 = DateTime.MinValue)));
		bool_0 = false;
		Class412.smethod_7();
	}
}
