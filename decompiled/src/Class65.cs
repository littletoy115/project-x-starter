using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

internal static class Class65
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct20 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public IReadOnlyList<uint> ireadOnlyList_0;

		public GForm0 gform0_0;

		private int int_1;

		private uint uint_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					if (num != 1)
					{
						if (ireadOnlyList_0 != null)
						{
							int_1 = 0;
							goto IL_0074;
						}
						goto IL_0143;
					}
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_00e3;
				}
				awaiter = taskAwaiter_0;
				taskAwaiter_0 = default(TaskAwaiter<bool>);
				num = -1;
				int_0 = -1;
				goto IL_00f1;
				IL_0143:
				Class412.smethod_14();
				result = false;
				goto end_IL_0007;
				IL_0074:
				if (int_1 < ireadOnlyList_0.Count)
				{
					uint_0 = ireadOnlyList_0[int_1];
					awaiter = smethod_5(gform0_0, uint_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00f1;
				}
				goto IL_0143;
				IL_00f1:
				if (!awaiter.GetResult())
				{
					goto IL_0064;
				}
				awaiter = Class412.smethod_11(gform0_0, uint_0).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					int_0 = 1;
					taskAwaiter_0 = awaiter;
					asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00e3;
				IL_0064:
				int_1++;
				goto IL_0074;
				IL_00e3:
				if (!awaiter.GetResult())
				{
					goto IL_0064;
				}
				result = true;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
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
	private struct Struct21 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public float float_0;

		public float float_1;

		public float float_2;

		public float float_3;

		private List<uint> list_0;

		private TaskAwaiter<List<uint>> taskAwaiter_0;

		private int int_1;

		private uint uint_0;

		private TaskAwaiter<bool> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<List<uint>> awaiter2;
				TaskAwaiter<bool> awaiter;
				List<uint> result2;
				switch (num)
				{
				default:
					awaiter2 = Class447.smethod_7(gform0_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0072;
				case 0:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<List<uint>>);
					num = -1;
					int_0 = -1;
					goto IL_0072;
				case 1:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_011b;
				case 2:
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_0186;
					}
					IL_0186:
					if (awaiter.GetResult())
					{
						result = true;
						break;
					}
					goto IL_014f;
					IL_0072:
					result2 = awaiter2.GetResult();
					list_0 = result2;
					int_1 = 0;
					goto IL_00cb;
					IL_00cb:
					if (int_1 < list_0.Count)
					{
						uint_0 = list_0[int_1];
						awaiter = smethod_5(gform0_0, uint_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_011b;
					}
					Class412.smethod_14();
					result = false;
					break;
					IL_014f:
					int_1++;
					goto IL_00cb;
					IL_011b:
					if (!awaiter.GetResult() || !smethod_8(gform0_0, uint_0, float_0, float_1, float_2, float_3))
					{
						goto IL_014f;
					}
					awaiter = Class412.smethod_11(gform0_0, uint_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 2;
						int_0 = 2;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0186;
				}
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
	private struct Struct22 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public float float_0;

		public IReadOnlyList<uint> ireadOnlyList_0;

		private bool bool_0;

		private float float_1;

		private float float_2;

		private float float_3;

		private bool bool_1;

		private TaskAwaiter<bool> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private TaskAwaiter taskAwaiter_2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private int int_1;

		private uint uint_0;

		private void MoveNext()
		{
			int num = int_0;
			bool result2;
			try
			{
				TaskAwaiter<string> awaiter4;
				TaskAwaiter awaiter3;
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool result;
				Class119 @class;
				int result3;
				float? num2;
				float? num3;
				float? num4;
				switch (num)
				{
				default:
					awaiter = gform0_0.smethod_6(63).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0080;
				case 0:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0080;
				case 1:
					awaiter4 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_00fd;
				case 2:
					awaiter3 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_01de;
				case 3:
					awaiter2 = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_03c5;
				case 4:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_04ab;
				case 5:
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_0520;
					}
					IL_045b:
					if (int_1 >= ireadOnlyList_0.Count)
					{
						break;
					}
					uint_0 = ireadOnlyList_0[int_1];
					awaiter = smethod_5(gform0_0, uint_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 4;
						int_0 = 4;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_04ab;
					IL_0080:
					result = awaiter.GetResult();
					bool_0 = false;
					if (result)
					{
						awaiter4 = gform0_0.smethod_8(34).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter4;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_00fd;
					}
					dateTime_0 = DateTime.MinValue;
					goto IL_0200;
					IL_01de:
					awaiter3.GetResult();
					goto IL_01e5;
					IL_03c5:
					awaiter2.GetResult();
					@class = gform0_0.method_7();
					if (@class == null)
					{
						result2 = false;
					}
					else
					{
						@class.method_176(float_1, float_2, float_3, bool_17: true, "attack_anchor");
						if (bool_1)
						{
							dateTime_0 = DateTime.MinValue;
						}
						result2 = false;
					}
					goto end_IL_0007;
					IL_00fd:
					if (int.TryParse(awaiter4.GetResult(), out result3) && result3 > 0)
					{
						if (dateTime_0 > DateTime.MinValue)
						{
							double totalSeconds = (DateTime.Now - dateTime_0).TotalSeconds;
							if (!(totalSeconds > (double)result3))
							{
								string string_ = "อ\u0e35ก " + ((double)result3 - totalSeconds).ToString("F0") + " ว\u0e34นาท\u0e35 จะว\u0e34\u0e48งกล\u0e31บกลางวงกลม";
								awaiter3 = gform0_0.smethod_13(57, string_).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num = 2;
									int_0 = 2;
									taskAwaiter_2 = awaiter3;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_01de;
							}
							bool_0 = true;
						}
						goto IL_01e5;
					}
					goto IL_0200;
					IL_01e5:
					if (dateTime_0 == DateTime.MinValue)
					{
						dateTime_0 = DateTime.Now;
					}
					goto IL_0200;
					IL_0200:
					num2 = gform0_0.method_5().method_0()?.float_0;
					num3 = gform0_0.method_5().method_0()?.float_1;
					num4 = gform0_0.method_5().method_0()?.float_2;
					if (num2.HasValue && num3.HasValue && num4.HasValue)
					{
						float value = num2.Value;
						float value2 = num3.Value;
						float value3 = num4.Value;
						Class398 class2 = Class412.smethod_1();
						float_1 = class2.float_0;
						float_2 = class2.float_1;
						float_3 = class2.float_2;
						bool_1 = Class406.smethod_3(value, value2, value3, float_1, float_2, float_3, float_0);
						if (!(!bool_1 | bool_0))
						{
							if (ireadOnlyList_0 == null)
							{
								break;
							}
							int_1 = 0;
							goto IL_045b;
						}
						Class412.smethod_14();
						Class119 class3 = gform0_0.method_7();
						if (class3 != null)
						{
							awaiter2 = class3.method_130().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 3;
								int_0 = 3;
								configuredTaskAwaiter_0 = awaiter2;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_03c5;
						}
						result2 = false;
					}
					else
					{
						result2 = false;
					}
					goto end_IL_0007;
					IL_04ab:
					if (awaiter.GetResult())
					{
						Class398 class4 = Class412.smethod_1();
						if (smethod_8(gform0_0, uint_0, class4.float_0, class4.float_1, class4.float_2, float_0))
						{
							awaiter = Class412.smethod_11(gform0_0, uint_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 5;
								int_0 = 5;
								taskAwaiter_0 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0520;
						}
					}
					goto IL_04e9;
					IL_04e9:
					int_1++;
					goto IL_045b;
					IL_0520:
					if (!awaiter.GetResult())
					{
						goto IL_04e9;
					}
					result2 = true;
					goto end_IL_0007;
				}
				Class412.smethod_14();
				result2 = false;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct23 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public uint uint_0;

		private bool bool_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			bool result3;
			try
			{
				TaskAwaiter<string> awaiter;
				TaskAwaiter<bool> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<string>);
						num = -1;
						int_0 = -1;
						goto IL_00dd;
					}
					awaiter2 = gform0_0.smethod_6(82).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
				}
				bool result = awaiter2.GetResult();
				bool_0 = result;
				awaiter = gform0_0.smethod_8(54).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					int_0 = 1;
					taskAwaiter_1 = awaiter;
					asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00dd;
				IL_00dd:
				string result2 = awaiter.GetResult();
				Class403 @class = smethod_7(gform0_0, uint_0);
				if (@class != null && !@class.method_0())
				{
					string string_ = ((!bool_0 || string.IsNullOrEmpty(result2)) ? null : Class447.smethod_4(gform0_0, @class.ushort_0, @class.ushort_1));
					result3 = !Class412.smethod_13(@class) && smethod_6(@class.byte_0, @class.uint_0, @class.ushort_2, @class.ushort_3, string_, bool_0, result2);
				}
				else
				{
					result3 = false;
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result3);
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
	private struct Struct24 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public float float_0;

		public IReadOnlyList<uint> ireadOnlyList_0;

		private float float_1;

		private float float_2;

		private float float_3;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private int int_1;

		private uint uint_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				Class119 class4;
				switch (num)
				{
				default:
				{
					Class398 @class = Class412.smethod_1();
					float_1 = @class.float_0;
					float_2 = @class.float_1;
					float_3 = @class.float_2;
					float? num2 = gform0_0.method_5().method_0()?.float_0;
					float? num3 = gform0_0.method_5().method_0()?.float_1;
					float? num4 = gform0_0.method_5().method_0()?.float_2;
					if (num2.HasValue && num3.HasValue && num4.HasValue)
					{
						float value = num2.Value;
						float value2 = num3.Value;
						float value3 = num4.Value;
						if (!Class406.smethod_3(value, value2, value3, float_1, float_2, float_3, float_0))
						{
							Class412.smethod_14();
							Class119 class2 = gform0_0.method_7();
							if (class2 == null)
							{
								result = false;
								break;
							}
							awaiter2 = class2.method_130().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 0;
								int_0 = 0;
								configuredTaskAwaiter_0 = awaiter2;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01da;
						}
						if (ireadOnlyList_0 != null && ireadOnlyList_0.Count != 0)
						{
							int_1 = 0;
							goto IL_025e;
						}
						Class412.smethod_14();
						result = false;
						break;
					}
					result = false;
					break;
				}
				case 0:
					awaiter2 = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_01da;
				case 1:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_02ae;
				case 2:
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_0323;
					}
					IL_0323:
					if (awaiter.GetResult())
					{
						result = true;
						break;
					}
					goto IL_02ec;
					IL_02ae:
					if (awaiter.GetResult())
					{
						Class398 class3 = Class412.smethod_1();
						if (smethod_8(gform0_0, uint_0, class3.float_0, class3.float_1, class3.float_2, float_0))
						{
							awaiter = Class412.smethod_11(gform0_0, uint_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 2;
								int_0 = 2;
								taskAwaiter_0 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0323;
						}
					}
					goto IL_02ec;
					IL_02ec:
					int_1++;
					goto IL_025e;
					IL_025e:
					if (int_1 < ireadOnlyList_0.Count)
					{
						uint_0 = ireadOnlyList_0[int_1];
						awaiter = smethod_5(gform0_0, uint_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02ae;
					}
					Class412.smethod_14();
					result = false;
					break;
					IL_01da:
					awaiter2.GetResult();
					class4 = gform0_0.method_7();
					if (class4 == null)
					{
						result = false;
						break;
					}
					class4.method_176(float_1, float_2, float_3, bool_17: true, "attack_anchor");
					result = false;
					break;
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
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

	private static DateTime dateTime_0 = DateTime.MinValue;

	public static async Task<bool> smethod_0(GForm0 gform0_0, float float_0, IReadOnlyList<uint> ireadOnlyList_0)
	{
		Class398 @class = Class412.smethod_1();
		float float_1 = @class.float_0;
		float float_2 = @class.float_1;
		float float_3 = @class.float_2;
		float? num = gform0_0.method_5().method_0()?.float_0;
		float? num2 = gform0_0.method_5().method_0()?.float_1;
		float? num3 = gform0_0.method_5().method_0()?.float_2;
		if (num.HasValue && num2.HasValue && num3.HasValue)
		{
			float value = num.Value;
			float value2 = num2.Value;
			float value3 = num3.Value;
			if (!Class406.smethod_3(value, value2, value3, float_1, float_2, float_3, float_0))
			{
				Class412.smethod_14();
				Class119 class2 = gform0_0.method_7();
				if (class2 == null)
				{
					return false;
				}
				await class2.method_130().ConfigureAwait(continueOnCapturedContext: false);
				Class119 class3 = gform0_0.method_7();
				if (class3 == null)
				{
					return false;
				}
				class3.method_176(float_1, float_2, float_3, bool_17: true, "attack_anchor");
				return false;
			}
			await Class412.smethod_16(gform0_0, float_0);
			if (ireadOnlyList_0 != null && ireadOnlyList_0.Count != 0)
			{
				for (int i = 0; i < ireadOnlyList_0.Count; i++)
				{
					uint num4 = ireadOnlyList_0[i];
					if (await smethod_5(gform0_0, num4))
					{
						Class398 class4 = Class412.smethod_1();
						if (smethod_8(gform0_0, num4, class4.float_0, class4.float_1, class4.float_2, float_0) && await Class412.smethod_11(gform0_0, num4))
						{
							return true;
						}
					}
				}
				Class412.smethod_14();
				return false;
			}
			Class412.smethod_14();
			return false;
		}
		return false;
	}

	public static async Task<bool> smethod_1(GForm0 gform0_0, float float_0, float float_1, float float_2, float float_3)
	{
		List<uint> list = await Class447.smethod_7(gform0_0);
		await Class412.smethod_16(gform0_0, float_0);
		for (int i = 0; i < list.Count; i++)
		{
			uint num = list[i];
			if (await smethod_5(gform0_0, num) && smethod_8(gform0_0, num, float_1, float_2, float_3, float_0) && await Class412.smethod_11(gform0_0, num))
			{
				return true;
			}
		}
		Class412.smethod_14();
		return false;
	}

	public static async Task<bool> smethod_2(GForm0 gform0_0, float float_0, IReadOnlyList<uint> ireadOnlyList_0)
	{
		bool num = await gform0_0.smethod_6(63);
		bool flag = false;
		int result;
		if (!num)
		{
			dateTime_0 = DateTime.MinValue;
		}
		else if (int.TryParse(await gform0_0.smethod_8(34), out result) && result > 0)
		{
			if (dateTime_0 > DateTime.MinValue)
			{
				double totalSeconds = (DateTime.Now - dateTime_0).TotalSeconds;
				if (totalSeconds > (double)result)
				{
					flag = true;
				}
				else
				{
					string string_ = "อ\u0e35ก " + ((double)result - totalSeconds).ToString("F0") + " ว\u0e34นาท\u0e35 จะว\u0e34\u0e48งกล\u0e31บกลางวงกลม";
					await gform0_0.smethod_13(57, string_);
				}
			}
			if (dateTime_0 == DateTime.MinValue)
			{
				dateTime_0 = DateTime.Now;
			}
		}
		float? num2 = gform0_0.method_5().method_0()?.float_0;
		float? num3 = gform0_0.method_5().method_0()?.float_1;
		float? num4 = gform0_0.method_5().method_0()?.float_2;
		if (num2.HasValue && num3.HasValue && num4.HasValue)
		{
			float value = num2.Value;
			float value2 = num3.Value;
			float value3 = num4.Value;
			Class398 @class = Class412.smethod_1();
			float float_1 = @class.float_0;
			float float_2 = @class.float_1;
			float float_3 = @class.float_2;
			bool flag2 = Class406.smethod_3(value, value2, value3, float_1, float_2, float_3, float_0);
			if (!flag2 || flag)
			{
				Class412.smethod_14();
				Class119 class2 = gform0_0.method_7();
				if (class2 == null)
				{
					return false;
				}
				await class2.method_130().ConfigureAwait(continueOnCapturedContext: false);
				Class119 class3 = gform0_0.method_7();
				if (class3 == null)
				{
					return false;
				}
				class3.method_176(float_1, float_2, float_3, bool_17: true, "attack_anchor");
				if (flag2)
				{
					dateTime_0 = DateTime.MinValue;
				}
				return false;
			}
			await Class412.smethod_16(gform0_0, float_0);
			if (ireadOnlyList_0 != null)
			{
				for (int i = 0; i < ireadOnlyList_0.Count; i++)
				{
					uint num5 = ireadOnlyList_0[i];
					if (await smethod_5(gform0_0, num5))
					{
						Class398 class4 = Class412.smethod_1();
						if (smethod_8(gform0_0, num5, class4.float_0, class4.float_1, class4.float_2, float_0) && await Class412.smethod_11(gform0_0, num5))
						{
							return true;
						}
					}
				}
			}
			Class412.smethod_14();
			return false;
		}
		return false;
	}

	public static async Task<bool> smethod_3(GForm0 gform0_0, IReadOnlyList<uint> ireadOnlyList_0)
	{
		if (ireadOnlyList_0 != null)
		{
			for (int i = 0; i < ireadOnlyList_0.Count; i++)
			{
				uint num = ireadOnlyList_0[i];
				if (await smethod_5(gform0_0, num) && await Class412.smethod_11(gform0_0, num))
				{
					return true;
				}
			}
		}
		Class412.smethod_14();
		return false;
	}

	public static Task<bool> smethod_4(GForm0 gform0_0, float float_0)
	{
		Class412.smethod_14();
		return Task.FromResult(result: false);
	}

	public static async Task<bool> smethod_5(GForm0 gform0_0, uint uint_0)
	{
		bool flag = await gform0_0.smethod_6(82);
		string text = await gform0_0.smethod_8(54);
		Class403 @class = smethod_7(gform0_0, uint_0);
		if (@class != null && !@class.method_0())
		{
			string string_ = ((!flag || string.IsNullOrEmpty(text)) ? null : Class447.smethod_4(gform0_0, @class.ushort_0, @class.ushort_1));
			if (@class.byte_0 != 2)
			{
				return false;
			}
			string text2 = (Class412.smethod_13(@class) ? "blacklisted" : smethod_11(@class.ushort_2, @class.ushort_3, string_, flag, text));
			if (text2 != null)
			{
				smethod_12(gform0_0, @class, text2);
				return false;
			}
			dictionary_0.Remove(@class.uint_0);
			return true;
		}
		return false;
	}

	private static bool smethod_6(byte byte_0, uint uint_0, long int_0, long int_1, string string_0, bool bool_0, string string_1)
	{
		if (byte_0 != 2)
		{
			return false;
		}
		return smethod_11(int_0, int_1, string_0, bool_0, string_1) == null;
	}

	// Why a monster in the census is not attacked; null = it may be attacked.
	private static string smethod_11(long int_0, long int_1, string string_0, bool bool_0, string string_1)
	{
		if (bool_0 && !string.IsNullOrEmpty(string_1))
		{
			if (string_0 == null)
			{
				return "name-unknown";
			}
			if (!smethod_9(string_0, string_1))
			{
				return "name-not-selected";
			}
		}
		if ((int_1 >= 20000 && int_0 <= 6) || (int_1 >= 10000 && int_0 <= 5) || (int_1 >= 5000 && int_0 <= 4) || (int_1 >= 1000 && int_0 <= 3) || int_0 <= 2)
		{
			return "hp-too-low";
		}
		return null;
	}

	// Last skip reason logged per monster id, so agent.log gets one line per change instead of one per tick.
	private static readonly Dictionary<uint, string> dictionary_0 = new Dictionary<uint, string>();

	private static void smethod_12(GForm0 gform0_0, Class403 class403_0, string string_0)
	{
		if (dictionary_0.TryGetValue(class403_0.uint_0, out var value) && value == string_0)
		{
			return;
		}
		if (dictionary_0.Count > 500)
		{
			dictionary_0.Clear();
		}
		dictionary_0[class403_0.uint_0] = string_0;
		string text = Class447.smethod_4(gform0_0, class403_0.ushort_0, class403_0.ushort_1) ?? "?";
		gform0_0.method_7()?.method_209("monster skip: " + string_0 + " id=" + class403_0.uint_0 + " name=" + text + " hp=" + class403_0.ushort_2 + "/" + class403_0.ushort_3);
	}

	private static Class403 smethod_7(GForm0 gform0_0, uint uint_0)
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

	private static bool smethod_8(GForm0 gform0_0, uint uint_0, float float_0, float float_1, float float_2, float float_3)
	{
		Class403 @class = smethod_7(gform0_0, uint_0);
		if (@class != null && !@class.method_0())
		{
			return Class406.smethod_3(@class.float_0, @class.float_1, @class.float_2, float_0, float_1, float_2, float_3);
		}
		return false;
	}

	private static bool smethod_9(string string_0, string string_1)
	{
		return Class447.smethod_16(string_0, string_1);
	}

	public static void smethod_10()
	{
		dateTime_0 = DateTime.MinValue;
	}
}
