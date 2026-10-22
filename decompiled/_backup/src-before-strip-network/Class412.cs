using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal static class Class412
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct127 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public uint uint_0;

		private Class403 class403_0;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				switch (num)
				{
				default:
					class403_0 = smethod_12(gform0_0, uint_0);
					if (class403_0 != null && !class403_0.method_0())
					{
						if (smethod_13(class403_0))
						{
							result = false;
						}
						else
						{
							Class83 @class = gform0_0.method_5().method_0();
							if (@class != null)
							{
								if (class394_0.method_0(class403_0.uint_0, class403_0.byte_0, class403_0.ushort_0, class403_0.ushort_1, class403_0.float_0, class403_0.float_2, (int)Math.Min(class403_0.ushort_2, int.MaxValue), @class.float_0, @class.float_2, @class.byte_0, DateTime.UtcNow))
								{
									if (Class412.uint_0 == class403_0.uint_0)
									{
										Class412.uint_0 = 0u;
										Class119 class2 = gform0_0.method_7();
										if (class2 != null)
										{
											awaiter2 = class2.method_130().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
											if (!awaiter2.IsCompleted)
											{
												num = 0;
												int_0 = 0;
												configuredTaskAwaiter_0 = awaiter2;
												asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
												return;
											}
											goto IL_01cd;
										}
									}
									goto IL_01d4;
								}
								awaiter = Class138.smethod_2(gform0_0, class403_0.uint_0).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 1;
									int_0 = 1;
									taskAwaiter_0 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_01f7;
							}
							result = false;
						}
					}
					else
					{
						result = false;
					}
					goto end_IL_0007;
				case 0:
					awaiter2 = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_01cd;
				case 1:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_01f7;
				case 2:
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_01d4:
					result = false;
					goto end_IL_0007;
					IL_01f7:
					if (!awaiter.GetResult())
					{
						awaiter = gform0_0.smethod_6(69).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
					class394_0.method_1(class403_0.uint_0, DateTime.UtcNow);
					Class412.uint_0 = 0u;
					result = true;
					goto end_IL_0007;
					IL_01cd:
					awaiter2.GetResult();
					goto IL_01d4;
				}
				bool num2;
				int num4;
				if (!awaiter.GetResult())
				{
					num2 = class403_0.uint_0 != Class412.uint_0;
					if (!num2)
					{
						int? num3 = gform0_0.method_5().method_0()?.byte_0;
						if ((num3.GetValueOrDefault() == 0) & num3.HasValue)
						{
							num4 = (((DateTime.Now - dateTime_0).TotalMilliseconds > 2000.0) ? 1 : 0);
							goto IL_03a2;
						}
					}
					num4 = 0;
					goto IL_03a2;
				}
				if (class403_0.uint_0 == Class412.uint_0)
				{
					goto IL_02f7;
				}
				Class403 class3 = smethod_12(gform0_0, uint_0);
				if (class3 != null && !class3.method_0())
				{
					uint uint_ = class3.uint_0;
					Class119 class4 = gform0_0.method_7();
					if (class4 != null)
					{
						class4.method_128(uint_);
						Class412.uint_0 = uint_;
						goto IL_02f7;
					}
					result = false;
				}
				else
				{
					result = false;
				}
				goto end_IL_0007;
				IL_02f7:
				result = true;
				goto end_IL_0007;
				IL_03a2:
				bool flag = (byte)num4 != 0;
				if (!num2 && !flag)
				{
					result = true;
				}
				else
				{
					Class403 class5 = smethod_12(gform0_0, uint_0);
					if (class5 != null && !class5.method_0())
					{
						uint uint_2 = class5.uint_0;
						Class119 class6 = gform0_0.method_7();
						if (class6 == null)
						{
							result = false;
						}
						else
						{
							class6.method_127(uint_2);
							class394_0.method_1(uint_2, DateTime.UtcNow);
							Class83 class7 = gform0_0.method_5().method_0();
							if (class7 != null)
							{
								_ = $"({class7.float_0:F2},{class7.float_1:F2},{class7.float_2:F2})";
							}
							Class412.uint_0 = uint_2;
							dateTime_0 = DateTime.Now;
							result = true;
						}
					}
					else
					{
						result = false;
					}
				}
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class403_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class403_0 = null;
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct128 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public float float_0;

		private List<uint> list_0;

		private bool bool_0;

		private TaskAwaiter<List<uint>> taskAwaiter_0;

		private TaskAwaiter<int> taskAwaiter_1;

		private TaskAwaiter<bool> taskAwaiter_2;

		private TaskAwaiter taskAwaiter_3;

		private void MoveNext()
		{
			int num = int_0;
			bool result4;
			try
			{
				TaskAwaiter<List<uint>> awaiter4;
				TaskAwaiter<int> awaiter3;
				TaskAwaiter<bool> awaiter2;
				TaskAwaiter awaiter;
				List<uint> result2;
				int result3;
				float? num2;
				float? num3;
				float? num4;
				bool result;
				switch (num)
				{
				default:
					awaiter4 = Class447.smethod_7(gform0_0).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter4;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
						return;
					}
					goto IL_008d;
				case 0:
					awaiter4 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<List<uint>>);
					num = -1;
					int_0 = -1;
					goto IL_008d;
				case 1:
					awaiter3 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<int>);
					num = -1;
					int_0 = -1;
					goto IL_010b;
				case 2:
					awaiter2 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_042d;
				case 3:
					awaiter2 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_045d;
				case 4:
					awaiter2 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_048d;
				case 5:
					awaiter2 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_04bd;
				case 6:
					awaiter2 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_04ea;
				case 7:
					awaiter2 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0517;
				case 8:
					{
						awaiter = taskAwaiter_3;
						taskAwaiter_3 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_0517:
					result = awaiter2.GetResult();
					bool_0 = result;
					goto IL_0526;
					IL_008d:
					result2 = awaiter4.GetResult();
					list_0 = result2;
					awaiter3 = gform0_0.smethod_12(new int[6] { 1, 2, 3, 4, 5, 26 }).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_010b;
					IL_029f:
					awaiter2 = Class65.smethod_0(gform0_0, float_0, list_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 2;
						int_0 = 2;
						taskAwaiter_2 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_042d;
					IL_010b:
					result3 = awaiter3.GetResult();
					switch (result3)
					{
					default:
						smethod_7();
						Class2.smethod_5();
						goto IL_0227;
					case 1:
					case 2:
						break;
					case 4:
					case 5:
						goto IL_0227;
					}
					num2 = gform0_0.method_5().method_0()?.float_0;
					num3 = gform0_0.method_5().method_0()?.float_1;
					num4 = gform0_0.method_5().method_0()?.float_2;
					if (num2.HasValue && num3.HasValue && num4.HasValue)
					{
						if (!Class412.bool_0)
						{
							Class412.float_0 = num2.Value;
							float_1 = num3.Value;
							float_2 = num4.Value;
							Class412.bool_0 = true;
						}
						smethod_6(Class412.float_0, float_1, float_2);
						goto IL_0227;
					}
					result4 = false;
					goto end_IL_0007;
					IL_045d:
					result = awaiter2.GetResult();
					bool_0 = result;
					goto IL_0526;
					IL_0227:
					switch (result3)
					{
					case 26:
						goto IL_028e;
					case 1:
						goto IL_029f;
					case 2:
						goto IL_02eb;
					case 3:
						goto IL_0337;
					case 4:
						goto IL_037d;
					case 5:
						goto IL_03c3;
					}
					awaiter2 = Class65.smethod_4(gform0_0, float_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 7;
						int_0 = 7;
						taskAwaiter_2 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0517;
					IL_03c3:
					awaiter2 = Class188.smethod_0(gform0_0, float_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 6;
						int_0 = 6;
						taskAwaiter_2 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_04ea;
					IL_042d:
					result = awaiter2.GetResult();
					bool_0 = result;
					goto IL_0526;
					IL_04ea:
					result = awaiter2.GetResult();
					bool_0 = result;
					goto IL_0526;
					IL_037d:
					awaiter2 = Class2.smethod_0(gform0_0, float_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 5;
						int_0 = 5;
						taskAwaiter_2 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_04bd;
					IL_028e:
					smethod_14();
					bool_0 = false;
					goto IL_0526;
					IL_04bd:
					result = awaiter2.GetResult();
					bool_0 = result;
					goto IL_0526;
					IL_0337:
					awaiter2 = Class65.smethod_3(gform0_0, list_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 4;
						int_0 = 4;
						taskAwaiter_2 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_048d;
					IL_0526:
					awaiter = smethod_9(gform0_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 8;
						int_0 = 8;
						taskAwaiter_3 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
					IL_048d:
					result = awaiter2.GetResult();
					bool_0 = result;
					goto IL_0526;
					IL_02eb:
					awaiter2 = Class65.smethod_2(gform0_0, float_0, list_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 3;
						int_0 = 3;
						taskAwaiter_2 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_045d;
				}
				awaiter.GetResult();
				result4 = bool_0;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				list_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
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

	private sealed class Class413
	{
		public GForm0 gform0_0;

		public Class398 class398_0;

		internal void method_0()
		{
			gform0_0.smethod_26(22, class398_0.bool_0 ? Class440.smethod_3(class398_0.float_0, class398_0.float_2) : "-", class398_0.bool_0 ? Color.Green : Color.Red);
		}
	}

	private static uint uint_0;

	private static DateTime dateTime_0;

	private static bool bool_0;

	private static float float_0;

	private static float float_1;

	private static float float_2;

	private static readonly Class394 class394_0 = new Class394();

	private static Class398 class398_0 = Class398.class398_0;

	internal static bool smethod_0()
	{
		return uint_0 != 0;
	}

	internal static Class398 smethod_1()
	{
		return Volatile.Read(ref class398_0);
	}

	public static bool smethod_2()
	{
		return Volatile.Read(ref class398_0).bool_0;
	}

	public static float smethod_3()
	{
		return Volatile.Read(ref class398_0).float_0;
	}

	public static float smethod_4()
	{
		return Volatile.Read(ref class398_0).float_1;
	}

	public static float smethod_5()
	{
		return Volatile.Read(ref class398_0).float_2;
	}

	public static void smethod_6(float float_3, float float_4, float float_5)
	{
		Volatile.Write(ref class398_0, new Class398(bool_1: true, float_3, float_4, float_5));
	}

	public static void smethod_7()
	{
		Volatile.Write(ref class398_0, Class398.class398_0);
	}

	public static string smethod_8()
	{
		Class398 @class = Volatile.Read(ref class398_0);
		if (!@class.bool_0)
		{
			return "-";
		}
		return Class440.smethod_3(@class.float_0, @class.float_2);
	}

	public static Task smethod_9(GForm0 gform0_0)
	{
		Class413 @class = new Class413();
		@class.gform0_0 = gform0_0;
		@class.class398_0 = Volatile.Read(ref class398_0);
		return @class.gform0_0.smethod_1(@class.method_0);
	}

	public static async Task<bool> smethod_10(GForm0 gform0_0, float float_3)
	{
		List<uint> ireadOnlyList_ = await Class447.smethod_7(gform0_0);
		int num = await gform0_0.smethod_12(new int[6] { 1, 2, 3, 4, 5, 26 });
		switch (num)
		{
		default:
			smethod_7();
			Class2.smethod_5();
			goto case 4;
		case 1:
		case 2:
		{
			float? num2 = gform0_0.method_5().method_0()?.float_0;
			float? num3 = gform0_0.method_5().method_0()?.float_1;
			float? num4 = gform0_0.method_5().method_0()?.float_2;
			if (!num2.HasValue || !num3.HasValue || !num4.HasValue)
			{
				break;
			}
			if (!bool_0)
			{
				float_0 = num2.Value;
				float_1 = num3.Value;
				float_2 = num4.Value;
				bool_0 = true;
			}
			smethod_6(float_0, float_1, float_2);
			goto case 4;
		}
		case 4:
		case 5:
		{
			bool result;
			switch (num)
			{
			case 26:
				smethod_14();
				result = false;
				break;
			case 1:
				result = await Class65.smethod_0(gform0_0, float_3, ireadOnlyList_);
				break;
			case 2:
				result = await Class65.smethod_2(gform0_0, float_3, ireadOnlyList_);
				break;
			case 3:
				result = await Class65.smethod_3(gform0_0, ireadOnlyList_);
				break;
			case 4:
				result = await Class2.smethod_0(gform0_0, float_3);
				break;
			case 5:
				result = await Class188.smethod_0(gform0_0, float_3);
				break;
			default:
				result = await Class65.smethod_4(gform0_0, float_3);
				break;
			}
			await smethod_9(gform0_0);
			return result;
		}
		}
		return false;
	}

	public static async Task<bool> smethod_11(GForm0 gform0_0, uint uint_1)
	{
		Class403 @class = smethod_12(gform0_0, uint_1);
		bool num;
		int num3;
		if (@class != null && !@class.method_0())
		{
			if (smethod_13(@class))
			{
				return false;
			}
			Class83 class2 = gform0_0.method_5().method_0();
			if (class2 == null)
			{
				return false;
			}
			if (class394_0.method_0(@class.uint_0, @class.byte_0, @class.ushort_0, @class.ushort_1, @class.float_0, @class.float_2, (int)Math.Min(@class.ushort_2, int.MaxValue), class2.float_0, class2.float_2, class2.byte_0, DateTime.UtcNow))
			{
				if (uint_0 == @class.uint_0)
				{
					uint_0 = 0u;
					Class119 class3 = gform0_0.method_7();
					if (class3 != null)
					{
						await class3.method_130().ConfigureAwait(continueOnCapturedContext: false);
					}
				}
				return false;
			}
			if (await Class138.smethod_2(gform0_0, @class.uint_0))
			{
				class394_0.method_1(@class.uint_0, DateTime.UtcNow);
				uint_0 = 0u;
				return true;
			}
			if (await gform0_0.smethod_6(69))
			{
				if (@class.uint_0 != uint_0)
				{
					Class403 class4 = smethod_12(gform0_0, uint_1);
					if (class4 == null || class4.method_0())
					{
						return false;
					}
					uint uint_2 = class4.uint_0;
					Class119 class5 = gform0_0.method_7();
					if (class5 == null)
					{
						return false;
					}
					class5.method_128(uint_2);
					uint_0 = uint_2;
				}
				return true;
			}
			num = @class.uint_0 != uint_0;
			if (!num)
			{
				int? num2 = gform0_0.method_5().method_0()?.byte_0;
				if ((num2.GetValueOrDefault() == 0) & num2.HasValue)
				{
					num3 = (((DateTime.Now - dateTime_0).TotalMilliseconds > 2000.0) ? 1 : 0);
					goto IL_03a2;
				}
			}
			num3 = 0;
			goto IL_03a2;
		}
		return false;
		IL_03a2:
		bool flag = (byte)num3 != 0;
		if (!num && !flag)
		{
			return true;
		}
		Class403 class6 = smethod_12(gform0_0, uint_1);
		if (class6 != null && !class6.method_0())
		{
			uint uint_3 = class6.uint_0;
			Class119 class7 = gform0_0.method_7();
			if (class7 == null)
			{
				return false;
			}
			class7.method_127(uint_3);
			class394_0.method_1(uint_3, DateTime.UtcNow);
			Class83 class8 = gform0_0.method_5().method_0();
			if (class8 != null)
			{
				_ = $"({class8.float_0:F2},{class8.float_1:F2},{class8.float_2:F2})";
			}
			uint_0 = uint_3;
			dateTime_0 = DateTime.Now;
			return true;
		}
		return false;
	}

	private static Class403 smethod_12(GForm0 gform0_0, uint uint_1)
	{
		IReadOnlyList<Class403> readOnlyList = gform0_0.method_5().method_2();
		if (readOnlyList == null)
		{
			return null;
		}
		int num = 0;
		Class403 @class;
		while (true)
		{
			if (num < readOnlyList.Count)
			{
				@class = readOnlyList[num];
				if (@class != null && @class.uint_0 == uint_1)
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

	internal static bool smethod_13(Class403 class403_0)
	{
		if (class403_0 != null)
		{
			return class394_0.method_2(class403_0.uint_0, class403_0.byte_0, class403_0.ushort_0, class403_0.ushort_1, class403_0.float_0, class403_0.float_2, DateTime.UtcNow);
		}
		return false;
	}

	public static void smethod_14()
	{
		uint_0 = 0u;
	}

	public static void smethod_15()
	{
		uint_0 = 0u;
		dateTime_0 = DateTime.MinValue;
		bool_0 = false;
		smethod_7();
		class394_0.method_3();
		Class65.smethod_10();
		Class138.smethod_3();
		Class2.smethod_8();
		Class188.smethod_17();
	}
}
