using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal static class Class2
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct0 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public float float_0;

		private IReadOnlyList<Struct76> ireadOnlyList_0;

		private bool bool_0;

		private float float_1;

		private float float_2;

		private int int_1;

		private Struct76 struct76_0;

		private TaskAwaiter<IReadOnlyList<Struct76>> taskAwaiter_0;

		private TaskAwaiter taskAwaiter_1;

		private TaskAwaiter<bool> taskAwaiter_2;

		private Class83 class83_0;

		private Class119 class119_0;

		private bool bool_1;

		private TaskAwaiter<string> taskAwaiter_3;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<IReadOnlyList<Struct76>> awaiter5;
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter4;
				TaskAwaiter<bool> awaiter3;
				TaskAwaiter<string> awaiter2;
				TaskAwaiter awaiter;
				IReadOnlyList<Struct76> result2;
				int num6;
				bool result4;
				float? num2;
				float? num3;
				float? num4;
				byte? b;
				byte? b2;
				float value;
				bool result5;
				bool result6;
				bool result7;
				string result3;
				int num12;
				switch (num)
				{
				default:
					awaiter5 = gform0_0.smethod_16().GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter5;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
						return;
					}
					goto IL_00ad;
				case 0:
					awaiter5 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<IReadOnlyList<Struct76>>);
					num = -1;
					int_0 = -1;
					goto IL_00ad;
				case 1:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0193;
				case 2:
					awaiter3 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_01bd;
				case 3:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_043a;
				case 4:
					awaiter3 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_07e8;
				case 5:
					awaiter2 = taskAwaiter_3;
					taskAwaiter_3 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_0857;
				case 6:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0bf3;
				case 7:
					awaiter4 = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0c67;
				case 8:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0cf5;
				case 9:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0d47;
				case 10:
					awaiter3 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0d99;
				case 11:
					awaiter3 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0eeb;
				case 12:
					awaiter2 = taskAwaiter_3;
					taskAwaiter_3 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_0f5c;
				case 13:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_107f;
				case 14:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_10bf;
				case 15:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_10e9;
				case 16:
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_0c73:
					if (class119_0.method_177(struct76_0.float_0, struct76_0.float_1, struct76_0.float_2, bool_17: true, Class185.smethod_0(-1141038771)))
					{
						class115_0.method_10(class83_0.long_0, float_1, float_2, DateTime.UtcNow);
					}
					result = true;
					goto end_IL_0007;
					IL_00ad:
					result2 = awaiter5.GetResult();
					ireadOnlyList_0 = result2;
					if (gform0_0.method_5().method_0() != null)
					{
						if (ireadOnlyList_0 != null && ireadOnlyList_0.Count != 0)
						{
							awaiter3 = gform0_0.smethod_6(51).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 2;
								int_0 = 2;
								taskAwaiter_2 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_01bd;
						}
						smethod_8();
						awaiter = gform0_0.smethod_13(73, string.Empty).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0193;
					}
					result = false;
					goto end_IL_0007;
					IL_043a:
					awaiter.GetResult();
					num2 = gform0_0.method_5().method_0()?.float_0;
					num3 = gform0_0.method_5().method_0()?.float_1;
					num4 = gform0_0.method_5().method_0()?.float_2;
					b = gform0_0.method_5().method_0()?.byte_0;
					b2 = gform0_0.method_5().method_0()?.byte_3;
					if (num2.HasValue && num3.HasValue && num4.HasValue && b.HasValue && b2.HasValue)
					{
						float_1 = num2.Value;
						value = num3.Value;
						float_2 = num4.Value;
						_ = b.Value;
						byte value2 = b2.Value;
						struct76_0 = ireadOnlyList_0[int_1];
						float num5 = Class440.smethod_19(float_1, float_2, struct76_0.float_0, struct76_0.float_2);
						if (!Class2.bool_0 && !Class440.smethod_20(num5))
						{
							awaiter3 = gform0_0.smethod_6(76).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 4;
								int_0 = 4;
								taskAwaiter_2 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_07e8;
						}
						dateTime_2 = DateTime.MinValue;
						class115_0.method_15();
						if (!Class2.bool_0)
						{
							Class2.bool_0 = true;
							dateTime_0 = DateTime.MinValue;
							dateTime_1 = DateTime.MinValue;
							Class2.bool_1 = false;
							Class412.smethod_6(float_1, value, float_2);
						}
						if (struct76_0.bool_0)
						{
							awaiter = gform0_0.smethod_13(73, smethod_2(Class185.smethod_0(-1141319176), struct76_0.int_0, dateTime_1) ?? string.Empty).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 8;
								int_0 = 8;
								taskAwaiter_1 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0cf5;
						}
						if (dateTime_1 != DateTime.MinValue)
						{
							awaiter = gform0_0.smethod_13(73, smethod_2(Class185.smethod_0(-1141319176), struct76_0.int_0, dateTime_1) ?? string.Empty).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 9;
								int_0 = 9;
								taskAwaiter_1 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0d47;
						}
						Class398 @class = Class412.smethod_1();
						awaiter3 = Class65.smethod_1(gform0_0, float_0, @class.float_0, @class.float_1, @class.float_2).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = 10;
							int_0 = 10;
							taskAwaiter_2 = awaiter3;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_0d99;
					}
					result = false;
					goto end_IL_0007;
					IL_0cf5:
					awaiter.GetResult();
					if (smethod_3(struct76_0.int_0))
					{
						smethod_4(ireadOnlyList_0.Count, bool_0);
					}
					result = true;
					goto end_IL_0007;
					IL_107f:
					awaiter.GetResult();
					smethod_4(ireadOnlyList_0.Count, bool_0);
					result = true;
					goto end_IL_0007;
					IL_0857:
					result3 = awaiter2.GetResult();
					num6 = Class440.smethod_1(bool_1, result3);
					b = gform0_0.method_5().method_0()?.byte_0;
					b2 = gform0_0.method_5().method_0()?.byte_3;
					if (b.HasValue && b2.HasValue)
					{
						_ = b.Value;
						byte value2 = b2.Value;
						Class2.bool_0 = false;
						Class412.smethod_7();
						class83_0 = gform0_0.method_5().method_0();
						if (class83_0 == null)
						{
							result = false;
						}
						else
						{
							float_1 = class83_0.float_0;
							value = class83_0.float_1;
							float_2 = class83_0.float_2;
							byte byte_ = class83_0.byte_0;
							value2 = class83_0.byte_3;
							bool flag;
							if (flag = byte_ != 0 || value2 != 0)
							{
								dateTime_2 = DateTime.MinValue;
							}
							else if (dateTime_2 == DateTime.MinValue)
							{
								dateTime_2 = DateTime.Now;
							}
							if (class115_0.method_14(class83_0.long_0, float_1, float_2, DateTime.UtcNow))
							{
								dateTime_2 = DateTime.MinValue;
								result = true;
							}
							else if (class115_0.method_4())
							{
								result = true;
							}
							else
							{
								class119_0 = gform0_0.method_7();
								if (class119_0 == null)
								{
									result = false;
								}
								else
								{
									bool flag2 = num6 > 0 && !flag && dateTime_2 != DateTime.MinValue && (DateTime.Now - dateTime_2).TotalSeconds >= (double)num6;
									if (!(class115_0.method_8() || flag2))
									{
										goto IL_0a6c;
									}
									if (!flag)
									{
										class115_0.method_11();
										goto IL_0a6c;
									}
									result = true;
								}
							}
						}
					}
					else
					{
						result = false;
					}
					goto end_IL_0007;
					IL_0c67:
					awaiter4.GetResult();
					Class412.smethod_14();
					goto IL_0c73;
					IL_01bd:
					result4 = awaiter3.GetResult();
					bool_0 = result4;
					num2 = gform0_0.method_5().method_0()?.float_0;
					num3 = gform0_0.method_5().method_0()?.float_1;
					num4 = gform0_0.method_5().method_0()?.float_2;
					b = gform0_0.method_5().method_0()?.byte_0;
					b2 = gform0_0.method_5().method_0()?.byte_3;
					if (num2.HasValue && num3.HasValue && num4.HasValue && b.HasValue && b2.HasValue)
					{
						float_1 = num2.Value;
						value = num3.Value;
						float_2 = num4.Value;
						_ = b.Value;
						byte value2 = b2.Value;
						int_1 = smethod_6();
						if (int_1 < 0 || int_1 >= ireadOnlyList_0.Count)
						{
							int_1 = (bool_0 ? smethod_1(ireadOnlyList_0.Count) : Class440.smethod_17(new List<Struct76>(ireadOnlyList_0), float_1, float_2));
							smethod_7(int_1);
							dateTime_0 = DateTime.MinValue;
							dateTime_1 = DateTime.MinValue;
							dateTime_2 = DateTime.MinValue;
							Class2.bool_1 = false;
							Class2.bool_0 = false;
							Class412.smethod_7();
							class115_0.method_15();
						}
						awaiter = gform0_0.smethod_19(ireadOnlyList_0[int_1].int_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 3;
							int_0 = 3;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_043a;
					}
					result = false;
					goto end_IL_0007;
					IL_10bf:
					awaiter.GetResult();
					result = true;
					goto end_IL_0007;
					IL_07e8:
					result5 = awaiter3.GetResult();
					bool_1 = result5;
					awaiter2 = gform0_0.smethod_8(46).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 5;
						int_0 = 5;
						taskAwaiter_3 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0857;
					IL_0a6c:
					if (!class115_0.method_6())
					{
						awaiter = gform0_0.smethod_13(73, smethod_2(Class185.smethod_0(-1141319270), num6, dateTime_2) ?? string.Empty).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 6;
							int_0 = 6;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0bf3;
					}
					if (class115_0.method_9())
					{
						smethod_4(ireadOnlyList_0.Count, bool_0);
						result = true;
					}
					else
					{
						int num7 = class115_0.method_2();
						float num8 = num7 switch
						{
							3 => 0f, 
							2 => 0f, 
							1 => -5f, 
							0 => 5f, 
							_ => 3.5f, 
						};
						float num9 = num7 switch
						{
							4 => 3.5f, 
							3 => -5f, 
							2 => 5f, 
							_ => 0f, 
						};
						float num10 = float_1 + num8;
						float num11 = float_2 + num9;
						if (class119_0.method_177(num10, value, num11, bool_17: true, Class185.smethod_0(-1141038745)))
						{
							class115_0.method_12(class83_0.long_0, float_1, float_2, DateTime.UtcNow);
						}
						result = true;
					}
					goto end_IL_0007;
					IL_0eeb:
					result6 = awaiter3.GetResult();
					bool_1 = result6;
					awaiter2 = gform0_0.smethod_8(45).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 12;
						int_0 = 12;
						taskAwaiter_3 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0f5c;
					IL_0d99:
					result7 = awaiter3.GetResult();
					if (gform0_0.method_5().method_0() != null)
					{
						if (result7)
						{
							awaiter3 = gform0_0.smethod_6(75).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 11;
								int_0 = 11;
								taskAwaiter_2 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_0eeb;
						}
						dateTime_0 = DateTime.MinValue;
						if (!Class2.bool_1)
						{
							Class2.bool_1 = true;
							awaiter = gform0_0.smethod_13(73, string.Empty).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 15;
								int_0 = 15;
								taskAwaiter_1 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_10e9;
						}
						awaiter = gform0_0.smethod_13(73, smethod_2(Class185.smethod_0(-1141319176), struct76_0.int_0, dateTime_1) ?? string.Empty).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 16;
							int_0 = 16;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
					result = false;
					goto end_IL_0007;
					IL_0d47:
					awaiter.GetResult();
					if (smethod_3(struct76_0.int_0))
					{
						smethod_4(ireadOnlyList_0.Count, bool_0);
					}
					result = true;
					goto end_IL_0007;
					IL_0f5c:
					result3 = awaiter2.GetResult();
					num12 = Class440.smethod_1(bool_1, result3);
					Class2.bool_1 = false;
					if (dateTime_0 == DateTime.MinValue)
					{
						dateTime_0 = DateTime.Now;
					}
					if (num12 > 0 && (DateTime.Now - dateTime_0).TotalSeconds >= (double)num12)
					{
						awaiter = gform0_0.smethod_13(73, string.Empty).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 13;
							int_0 = 13;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_107f;
					}
					awaiter = gform0_0.smethod_13(73, smethod_2(Class185.smethod_0(-1141319207), num12, dateTime_0) ?? string.Empty).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 14;
						int_0 = 14;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_10bf;
					IL_0bf3:
					awaiter.GetResult();
					if (Class412.smethod_0())
					{
						awaiter4 = class119_0.method_130().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num = 7;
							int_0 = 7;
							configuredTaskAwaiter_0 = awaiter4;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_0c67;
					}
					goto IL_0c73;
					IL_0193:
					awaiter.GetResult();
					result = false;
					goto end_IL_0007;
					IL_10e9:
					awaiter.GetResult();
					result = true;
					goto end_IL_0007;
				}
				awaiter.GetResult();
				if (smethod_3(struct76_0.int_0))
				{
					smethod_4(ireadOnlyList_0.Count, bool_0);
				}
				result = true;
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

	private static readonly Class115 class115_0 = new Class115();

	private static int int_0 = -1;

	private static DateTime dateTime_0 = DateTime.MinValue;

	private static DateTime dateTime_1 = DateTime.MinValue;

	private static DateTime dateTime_2 = DateTime.MinValue;

	private static List<int> list_0 = new List<int>();

	private static int int_1;

	private static bool bool_0;

	private static bool bool_1;

	public static async Task<bool> smethod_0(GForm0 gform0_0, float float_0)
	{
		IReadOnlyList<Struct76> readOnlyList = await gform0_0.smethod_16();
		if (gform0_0.method_5().method_0() == null)
		{
			return false;
		}
		if (readOnlyList == null || readOnlyList.Count == 0)
		{
			smethod_8();
			await gform0_0.smethod_13(73, string.Empty);
			return false;
		}
		bool flag = await gform0_0.smethod_6(51);
		float? num = gform0_0.method_5().method_0()?.float_0;
		float? num2 = gform0_0.method_5().method_0()?.float_1;
		float? num3 = gform0_0.method_5().method_0()?.float_2;
		byte? b = gform0_0.method_5().method_0()?.byte_0;
		byte? b2 = gform0_0.method_5().method_0()?.byte_3;
		if (num.HasValue && num2.HasValue && num3.HasValue && b.HasValue && b2.HasValue)
		{
			float value = num.Value;
			_ = num2.Value;
			float value2 = num3.Value;
			_ = b.Value;
			_ = b2.Value;
			int num4 = smethod_6();
			if (num4 < 0 || num4 >= readOnlyList.Count)
			{
				num4 = (flag ? smethod_1(readOnlyList.Count) : Class440.smethod_17(new List<Struct76>(readOnlyList), value, value2));
				smethod_7(num4);
				dateTime_0 = DateTime.MinValue;
				dateTime_1 = DateTime.MinValue;
				dateTime_2 = DateTime.MinValue;
				bool_1 = false;
				bool_0 = false;
				Class412.smethod_7();
				class115_0.method_15();
			}
			await gform0_0.smethod_19(readOnlyList[num4].int_1);
			num = gform0_0.method_5().method_0()?.float_0;
			num2 = gform0_0.method_5().method_0()?.float_1;
			num3 = gform0_0.method_5().method_0()?.float_2;
			b = gform0_0.method_5().method_0()?.byte_0;
			b2 = gform0_0.method_5().method_0()?.byte_3;
			if (num.HasValue && num2.HasValue && num3.HasValue && b.HasValue && b2.HasValue)
			{
				value = num.Value;
				float value3 = num2.Value;
				value2 = num3.Value;
				_ = b.Value;
				_ = b2.Value;
				Struct76 @struct = readOnlyList[num4];
				float float_1 = Class440.smethod_19(value, value2, @struct.float_0, @struct.float_2);
				if (bool_0 || Class440.smethod_20(float_1))
				{
					dateTime_2 = DateTime.MinValue;
					class115_0.method_15();
					if (!bool_0)
					{
						bool_0 = true;
						dateTime_0 = DateTime.MinValue;
						dateTime_1 = DateTime.MinValue;
						bool_1 = false;
						Class412.smethod_6(value, value3, value2);
					}
					if (!@struct.bool_0)
					{
						if (!(dateTime_1 != DateTime.MinValue))
						{
							Class398 @class = Class412.smethod_1();
							bool flag2 = await Class65.smethod_1(gform0_0, float_0, @class.float_0, @class.float_1, @class.float_2);
							if (gform0_0.method_5().method_0() == null)
							{
								return false;
							}
							if (!flag2)
							{
								dateTime_0 = DateTime.MinValue;
								if (!bool_1)
								{
									bool_1 = true;
									await gform0_0.smethod_13(73, string.Empty);
									return true;
								}
								await gform0_0.smethod_13(73, smethod_2(Class185.smethod_0(-1141319176), @struct.int_0, dateTime_1) ?? string.Empty);
								if (smethod_3(@struct.int_0))
								{
									smethod_4(readOnlyList.Count, flag);
								}
								return true;
							}
							int num5 = Class440.smethod_1(await gform0_0.smethod_6(75), await gform0_0.smethod_8(45));
							bool_1 = false;
							if (dateTime_0 == DateTime.MinValue)
							{
								dateTime_0 = DateTime.Now;
							}
							if (num5 > 0 && (DateTime.Now - dateTime_0).TotalSeconds >= (double)num5)
							{
								await gform0_0.smethod_13(73, string.Empty);
								smethod_4(readOnlyList.Count, flag);
								return true;
							}
							await gform0_0.smethod_13(73, smethod_2(Class185.smethod_0(-1141319207), num5, dateTime_0) ?? string.Empty);
							return true;
						}
						await gform0_0.smethod_13(73, smethod_2(Class185.smethod_0(-1141319176), @struct.int_0, dateTime_1) ?? string.Empty);
						if (smethod_3(@struct.int_0))
						{
							smethod_4(readOnlyList.Count, flag);
						}
						return true;
					}
					await gform0_0.smethod_13(73, smethod_2(Class185.smethod_0(-1141319176), @struct.int_0, dateTime_1) ?? string.Empty);
					if (smethod_3(@struct.int_0))
					{
						smethod_4(readOnlyList.Count, flag);
					}
					return true;
				}
				int num6 = Class440.smethod_1(await gform0_0.smethod_6(76), await gform0_0.smethod_8(46));
				b = gform0_0.method_5().method_0()?.byte_0;
				b2 = gform0_0.method_5().method_0()?.byte_3;
				if (b.HasValue && b2.HasValue)
				{
					_ = b.Value;
					_ = b2.Value;
					bool_0 = false;
					Class412.smethod_7();
					Class83 class2 = gform0_0.method_5().method_0();
					if (class2 == null)
					{
						return false;
					}
					value = class2.float_0;
					value3 = class2.float_1;
					value2 = class2.float_2;
					byte byte_ = class2.byte_0;
					byte byte_2 = class2.byte_3;
					bool flag3;
					if (flag3 = byte_ != 0 || byte_2 != 0)
					{
						dateTime_2 = DateTime.MinValue;
					}
					else if (dateTime_2 == DateTime.MinValue)
					{
						dateTime_2 = DateTime.Now;
					}
					if (class115_0.method_14(class2.long_0, value, value2, DateTime.UtcNow))
					{
						dateTime_2 = DateTime.MinValue;
						return true;
					}
					if (class115_0.method_4())
					{
						return true;
					}
					Class119 class3 = gform0_0.method_7();
					if (class3 == null)
					{
						return false;
					}
					bool flag4 = num6 > 0 && !flag3 && dateTime_2 != DateTime.MinValue && (DateTime.Now - dateTime_2).TotalSeconds >= (double)num6;
					if (class115_0.method_8() || flag4)
					{
						if (flag3)
						{
							return true;
						}
						class115_0.method_11();
					}
					if (class115_0.method_6())
					{
						if (class115_0.method_9())
						{
							smethod_4(readOnlyList.Count, flag);
							return true;
						}
						int num7 = class115_0.method_2();
						float num8 = num7 switch
						{
							3 => 0f, 
							2 => 0f, 
							1 => -5f, 
							0 => 5f, 
							_ => 3.5f, 
						};
						float num9 = num7 switch
						{
							4 => 3.5f, 
							3 => -5f, 
							2 => 5f, 
							_ => 0f, 
						};
						float float_2 = value + num8;
						float float_3 = value2 + num9;
						if (class3.method_177(float_2, value3, float_3, bool_17: true, Class185.smethod_0(-1141038745)))
						{
							class115_0.method_12(class2.long_0, value, value2, DateTime.UtcNow);
						}
						return true;
					}
					await gform0_0.smethod_13(73, smethod_2(Class185.smethod_0(-1141319270), num6, dateTime_2) ?? string.Empty);
					if (Class412.smethod_0())
					{
						await class3.method_130().ConfigureAwait(continueOnCapturedContext: false);
						Class412.smethod_14();
					}
					if (class3.method_177(@struct.float_0, @struct.float_1, @struct.float_2, bool_17: true, Class185.smethod_0(-1141038771)))
					{
						class115_0.method_10(class2.long_0, value, value2, DateTime.UtcNow);
					}
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	internal static int smethod_1(int int_2)
	{
		if (list_0.Count != int_2 || int_1 >= list_0.Count)
		{
			list_0 = new List<int>();
			for (int i = 0; i < int_2; i++)
			{
				list_0.Add(i);
			}
			Random random = new Random();
			for (int num = list_0.Count - 1; num > 0; num--)
			{
				int index = random.Next(0, num + 1);
				int value = list_0[num];
				list_0[num] = list_0[index];
				list_0[index] = value;
			}
			int_1 = 0;
		}
		return list_0[int_1++];
	}

	internal static string smethod_2(string string_0, int int_2, DateTime dateTime_3)
	{
		if (int_2 > 0 && !(dateTime_3 == DateTime.MinValue))
		{
			double num = (double)int_2 - (DateTime.Now - dateTime_3).TotalSeconds;
			if (num < 0.0)
			{
				num = 0.0;
			}
			return string_0 + Class185.smethod_0(-1141299597) + num.ToString(Class185.smethod_0(-1141277524), CultureInfo.InvariantCulture) + Class185.smethod_0(-1141253640);
		}
		return null;
	}

	private static bool smethod_3(int int_2)
	{
		if (dateTime_1 == DateTime.MinValue)
		{
			dateTime_1 = DateTime.Now;
		}
		return (DateTime.Now - dateTime_1).TotalSeconds >= (double)int_2;
	}

	private static void smethod_4(int int_2, bool bool_2)
	{
		int num = smethod_6();
		smethod_7(bool_2 ? smethod_1(int_2) : Class440.smethod_18(num, int_2));
		dateTime_0 = DateTime.MinValue;
		dateTime_1 = DateTime.MinValue;
		dateTime_2 = DateTime.MinValue;
		bool_1 = false;
		bool_0 = false;
		Class412.smethod_7();
		class115_0.method_15();
	}

	public static void smethod_5()
	{
		bool_0 = false;
		class115_0.method_15();
	}

	public static int smethod_6()
	{
		return Volatile.Read(ref int_0);
	}

	internal static void smethod_7(int int_2)
	{
		Volatile.Write(ref int_0, int_2);
	}

	public static void smethod_8()
	{
		smethod_7(-1);
		dateTime_0 = DateTime.MinValue;
		dateTime_1 = DateTime.MinValue;
		dateTime_2 = DateTime.MinValue;
		bool_0 = false;
		Class412.smethod_7();
		bool_1 = false;
		class115_0.method_15();
	}
}
