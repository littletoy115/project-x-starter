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
						goto IL_0123;
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
				IL_0123:
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
				goto IL_0123;
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
					goto IL_01ed;
				case 3:
					awaiter2 = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_03d4;
				case 4:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_04bf;
				case 5:
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_0534;
					}
					IL_01ed:
					awaiter3.GetResult();
					goto IL_01f4;
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
					goto IL_020f;
					IL_01f4:
					if (dateTime_0 == DateTime.MinValue)
					{
						dateTime_0 = DateTime.Now;
					}
					goto IL_020f;
					IL_03d4:
					awaiter2.GetResult();
					@class = gform0_0.method_7();
					if (@class == null)
					{
						result2 = false;
						break;
					}
					@class.method_176(float_1, float_2, float_3, bool_17: true, Class185.smethod_0(-1141038239));
					if (bool_1)
					{
						dateTime_0 = DateTime.MinValue;
					}
					result2 = false;
					break;
					IL_00fd:
					if (int.TryParse(awaiter4.GetResult(), out result3) && result3 > 0)
					{
						if (dateTime_0 > DateTime.MinValue)
						{
							double totalSeconds = (DateTime.Now - dateTime_0).TotalSeconds;
							if (!(totalSeconds > (double)result3))
							{
								string string_ = Class185.smethod_0(-1141038146) + ((double)result3 - totalSeconds).ToString(Class185.smethod_0(-1141038161)) + Class185.smethod_0(-1141038170);
								awaiter3 = gform0_0.smethod_13(57, string_).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num = 2;
									int_0 = 2;
									taskAwaiter_2 = awaiter3;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_01ed;
							}
							bool_0 = true;
						}
						goto IL_01f4;
					}
					goto IL_020f;
					IL_020f:
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
						if (!bool_1 | bool_0)
						{
							Class412.smethod_14();
							Class119 class3 = gform0_0.method_7();
							if (class3 == null)
							{
								result2 = false;
								break;
							}
							awaiter2 = class3.method_130().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 3;
								int_0 = 3;
								configuredTaskAwaiter_0 = awaiter2;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_03d4;
						}
						if (ireadOnlyList_0 != null)
						{
							int_1 = 0;
							goto IL_046f;
						}
						goto IL_0541;
					}
					result2 = false;
					break;
					IL_046f:
					if (int_1 < ireadOnlyList_0.Count)
					{
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
						goto IL_04bf;
					}
					goto IL_0541;
					IL_0534:
					if (awaiter.GetResult())
					{
						result2 = true;
						break;
					}
					goto IL_04fd;
					IL_0541:
					Class412.smethod_14();
					result2 = false;
					break;
					IL_04bf:
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
							goto IL_0534;
						}
					}
					goto IL_04fd;
					IL_04fd:
					int_1++;
					goto IL_046f;
				}
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
							goto IL_0263;
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
					goto IL_02b3;
				case 2:
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_0328;
					}
					IL_0328:
					if (awaiter.GetResult())
					{
						result = true;
						break;
					}
					goto IL_02f1;
					IL_02b3:
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
							goto IL_0328;
						}
					}
					goto IL_02f1;
					IL_02f1:
					int_1++;
					goto IL_0263;
					IL_0263:
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
						goto IL_02b3;
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
					class4.method_176(float_1, float_2, float_3, bool_17: true, Class185.smethod_0(-1141038239));
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
				class3.method_176(float_1, float_2, float_3, bool_17: true, Class185.smethod_0(-1141038239));
				return false;
			}
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
					string string_ = Class185.smethod_0(-1141038146) + ((double)result - totalSeconds).ToString(Class185.smethod_0(-1141038161)) + Class185.smethod_0(-1141038170);
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
				class3.method_176(float_1, float_2, float_3, bool_17: true, Class185.smethod_0(-1141038239));
				if (flag2)
				{
					dateTime_0 = DateTime.MinValue;
				}
				return false;
			}
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
			return !Class412.smethod_13(@class) && smethod_6(@class.byte_0, @class.uint_0, @class.ushort_2, @class.ushort_3, string_, flag, text);
		}
		return false;
	}

	private static bool smethod_6(byte byte_0, uint uint_0, int int_0, int int_1, string string_0, bool bool_0, string string_1)
	{
		if (byte_0 != 2)
		{
			return false;
		}
		if (bool_0 && !string.IsNullOrEmpty(string_1) && (string_0 == null || !smethod_9(string_0, string_1)))
		{
			return false;
		}
		if (int_1 >= 20000 && int_0 <= 6)
		{
			return false;
		}
		if (int_1 >= 10000 && int_0 <= 5)
		{
			return false;
		}
		if (int_1 >= 5000 && int_0 <= 4)
		{
			return false;
		}
		if (int_1 >= 1000 && int_0 <= 3)
		{
			return false;
		}
		return int_0 > 2;
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
		if (string_0.Equals(string_1, StringComparison.OrdinalIgnoreCase))
		{
			return true;
		}
		if (string_1.IndexOf(string_0, StringComparison.OrdinalIgnoreCase) < 0)
		{
			return string_0.IndexOf(string_1, StringComparison.OrdinalIgnoreCase) >= 0;
		}
		return true;
	}

	public static void smethod_10()
	{
		dateTime_0 = DateTime.MinValue;
	}
}
