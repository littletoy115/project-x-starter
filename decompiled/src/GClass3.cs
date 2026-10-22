using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public static class GClass3
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct10 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private int int_1;

		private TaskAwaiter taskAwaiter_0;

		private TaskAwaiter<bool> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			try
			{
				TaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool flag;
				Class119 class119_;
				switch (num)
				{
				default:
					int_1 = 0;
					goto IL_009b;
				case 0:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0082;
				case 1:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_00da;
				case 2:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0195;
				case 3:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0200;
				case 4:
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_02ad;
					}
					IL_009b:
					if (!(flag = int_1 < 5 && !gform0_0.method_4()))
					{
						goto IL_00b9;
					}
					awaiter = gform0_0.smethod_6(42).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00da;
					IL_0219:
					if (!(flag = (int_1 < 10 || (gform0_0.method_5().method_0()?.ushort_0).GetValueOrDefault() <= 0 || gform0_0.method_5().method_28() == true) && !gform0_0.method_4()))
					{
						goto IL_0289;
					}
					awaiter = gform0_0.smethod_6(42).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 4;
						int_0 = 4;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_02ad;
					IL_02ad:
					flag = awaiter.GetResult();
					goto IL_0289;
					IL_0195:
					awaiter2.GetResult();
					int_1 = 0;
					goto IL_0219;
					IL_0200:
					awaiter2.GetResult();
					int_1++;
					goto IL_0219;
					IL_00da:
					flag = awaiter.GetResult();
					goto IL_00b9;
					IL_00b9:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0082;
					}
					class119_ = gform0_0.method_7();
					awaiter2 = smethod_4(gform0_0, class119_).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 2;
						int_0 = 2;
						taskAwaiter_0 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0195;
					IL_0289:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 3;
							int_0 = 3;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0200;
					}
					break;
					IL_0082:
					awaiter2.GetResult();
					int_1++;
					goto IL_009b;
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult();
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
	private struct Struct11 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Class119 class119_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0071;
				}
				if (class119_0 != null)
				{
					Class412.smethod_15();
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0071;
				}
				goto end_IL_0007;
				IL_0071:
				awaiter.GetResult();
				class119_0.method_149();
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult();
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
	private struct Struct12 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private TaskAwaiter taskAwaiter_0;

		private TaskAwaiter<bool> taskAwaiter_1;

		private int int_1;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool flag;
				switch (num)
				{
				default:
					awaiter2 = smethod_3(gform0_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_007a;
				case 0:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_007a;
				case 1:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_00dc;
				case 2:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_013f;
				case 3:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_01be;
				case 4:
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_0217;
					}
					IL_01d7:
					if (!(flag = int_1 < 10 && !gform0_0.method_4()))
					{
						goto IL_01f6;
					}
					awaiter = gform0_0.smethod_6(42).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 4;
						int_0 = 4;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0217;
					IL_007a:
					awaiter2.GetResult();
					awaiter = gform0_0.smethod_6(45).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00dc;
					IL_0217:
					flag = awaiter.GetResult();
					goto IL_01f6;
					IL_00dc:
					if (awaiter.GetResult())
					{
						awaiter = GClass15.smethod_0(gform0_0, 1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_013f;
					}
					goto IL_0147;
					IL_01f6:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 3;
							int_0 = 3;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_01be;
					}
					result = true;
					break;
					IL_01be:
					awaiter2.GetResult();
					int_1++;
					goto IL_01d7;
					IL_013f:
					awaiter.GetResult();
					goto IL_0147;
					IL_0147:
					gform0_0.method_15(gform0_0.method_14());
					int_1 = 0;
					goto IL_01d7;
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct13 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private int int_1;

		private int int_2;

		private TaskAwaiter taskAwaiter_0;

		private TaskAwaiter<bool> taskAwaiter_1;

		private TaskAwaiter<string> taskAwaiter_2;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<string> awaiter3;
				TaskAwaiter<bool> awaiter2;
				TaskAwaiter awaiter;
				bool flag;
				string result2;
				switch (num)
				{
				default:
					if (gform0_0 == null)
					{
						result = false;
					}
					else if ((gform0_0.method_5().method_0()?.ushort_0).GetValueOrDefault() > 0)
					{
						result = false;
					}
					else
					{
						if (gform0_0.smethod_3())
						{
							int_2 = 0;
							goto IL_0100;
						}
						result = false;
					}
					goto end_IL_0007;
				case 0:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_00e7;
				case 1:
					awaiter2 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0142;
				case 2:
					awaiter3 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_01f4;
				case 3:
					awaiter3 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_0268;
				case 4:
					awaiter2 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0383;
				case 5:
					awaiter2 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_03a9;
				case 6:
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_0383:
					result = awaiter2.GetResult();
					goto end_IL_0007;
					IL_0100:
					if (!(flag = int_2 < 70 && !gform0_0.method_4()))
					{
						goto IL_0120;
					}
					awaiter2 = gform0_0.smethod_6(42).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0142;
					IL_03a9:
					result = awaiter2.GetResult();
					goto end_IL_0007;
					IL_00e7:
					awaiter.GetResult();
					int_2++;
					goto IL_0100;
					IL_01f4:
					int.TryParse(awaiter3.GetResult(), out int_1);
					awaiter3 = gform0_0.smethod_9("comboBox4").GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 3;
						int_0 = 3;
						taskAwaiter_2 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0268;
					IL_0268:
					result2 = awaiter3.GetResult();
					if (!(result2 == "หย\u0e38ดการทำงานของบอท"))
					{
						if (!(result2 == "วาปกล\u0e31บจ\u0e38ดเด\u0e34ม และทำงานต\u0e48อ"))
						{
							Class412.smethod_15();
							Class119 class119_ = gform0_0.method_7();
							awaiter = smethod_4(gform0_0, class119_).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 6;
								int_0 = 6;
								taskAwaiter_0 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						awaiter2 = smethod_2(gform0_0, int_1).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 5;
							int_0 = 5;
							taskAwaiter_1 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_03a9;
					}
					awaiter2 = smethod_1(gform0_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 4;
						int_0 = 4;
						taskAwaiter_1 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0383;
					IL_0142:
					flag = awaiter2.GetResult();
					goto IL_0120;
					IL_0120:
					if (flag)
					{
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00e7;
					}
					awaiter3 = gform0_0.smethod_8(24).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 2;
						int_0 = 2;
						taskAwaiter_2 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_01f4;
				}
				awaiter.GetResult();
				result = false;
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
	private struct Struct14 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public int int_1;

		private TaskAwaiter taskAwaiter_0;

		private TaskAwaiter<bool> taskAwaiter_1;

		private TaskAwaiter<Enum9> taskAwaiter_2;

		private int int_2;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<Enum9> awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool flag;
				switch (num)
				{
				default:
					awaiter2 = smethod_3(gform0_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0082;
				case 0:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0082;
				case 1:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_00e4;
				case 2:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_014a;
				case 3:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_01aa;
				case 4:
					awaiter3 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<Enum9>);
					num = -1;
					int_0 = -1;
					goto IL_0221;
				case 5:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_028d;
				case 6:
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_033a;
					}
					IL_028d:
					awaiter2.GetResult();
					int_2++;
					goto IL_02a6;
					IL_0082:
					awaiter2.GetResult();
					awaiter = gform0_0.smethod_6(45).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00e4;
					IL_0221:
					awaiter3.GetResult();
					int_2 = 0;
					goto IL_02a6;
					IL_00e4:
					if (awaiter.GetResult())
					{
						awaiter = GClass15.smethod_0(gform0_0, 1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_014a;
					}
					goto IL_01b1;
					IL_02a6:
					if (!(flag = (int_2 < 10 || (gform0_0.method_5().method_0()?.ushort_0).GetValueOrDefault() <= 0 || gform0_0.method_5().method_28() == true) && !gform0_0.method_4()))
					{
						goto IL_0316;
					}
					awaiter = gform0_0.smethod_6(42).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 6;
						int_0 = 6;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_033a;
					IL_0316:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 5;
							int_0 = 5;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_028d;
					}
					result = true;
					break;
					IL_014a:
					awaiter.GetResult();
					awaiter2 = Task.Delay(500).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 3;
						int_0 = 3;
						taskAwaiter_0 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_01aa;
					IL_033a:
					flag = awaiter.GetResult();
					goto IL_0316;
					IL_01aa:
					awaiter2.GetResult();
					goto IL_01b1;
					IL_01b1:
					awaiter3 = Class179.smethod_1(gform0_0, int_1, 200, 10.0).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 4;
						int_0 = 4;
						taskAwaiter_2 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0221;
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

	public static async Task<bool> smethod_0(GForm0 gform0_0)
	{
		if (gform0_0 == null)
		{
			return false;
		}
		if ((gform0_0.method_5().method_0()?.ushort_0).GetValueOrDefault() > 0)
		{
			return false;
		}
		if (!gform0_0.smethod_3())
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			bool flag;
			if (flag = num < 70 && !gform0_0.method_4())
			{
				flag = await gform0_0.smethod_6(42);
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(100);
			num++;
		}
		int.TryParse(await gform0_0.smethod_8(24), out var result);
		string text = await gform0_0.smethod_9("comboBox4");
		if (!(text == "หย\u0e38ดการทำงานของบอท"))
		{
			if (!(text == "วาปกล\u0e31บจ\u0e38ดเด\u0e34ม และทำงานต\u0e48อ"))
			{
				Class412.smethod_15();
				Class119 class119_ = gform0_0.method_7();
				await smethod_4(gform0_0, class119_);
				return false;
			}
			return await smethod_2(gform0_0, result);
		}
		return await smethod_1(gform0_0);
	}

	public static async Task<bool> smethod_1(GForm0 gform0_0)
	{
		await smethod_3(gform0_0);
		if (await gform0_0.smethod_6(45))
		{
			await GClass15.smethod_0(gform0_0, 1);
		}
		gform0_0.method_15(gform0_0.method_14());
		int num = 0;
		while (true)
		{
			bool flag;
			if (flag = num < 10 && !gform0_0.method_4())
			{
				flag = await gform0_0.smethod_6(42);
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		return true;
	}

	public static async Task<bool> smethod_2(GForm0 gform0_0, int int_0)
	{
		await smethod_3(gform0_0);
		if (await gform0_0.smethod_6(45))
		{
			await GClass15.smethod_0(gform0_0, 1);
			await Task.Delay(500);
		}
		await Class179.smethod_1(gform0_0, int_0, 200, 10.0);
		int num = 0;
		while (true)
		{
			bool flag;
			if (flag = (num < 10 || (gform0_0.method_5().method_0()?.ushort_0).GetValueOrDefault() <= 0 || gform0_0.method_5().method_28() == true) && !gform0_0.method_4())
			{
				flag = await gform0_0.smethod_6(42);
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		return true;
	}

	private static async Task smethod_3(GForm0 gform0_0)
	{
		int num = 0;
		while (true)
		{
			bool flag;
			if (flag = num < 5 && !gform0_0.method_4())
			{
				flag = await gform0_0.smethod_6(42);
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		Class119 class119_ = gform0_0.method_7();
		await smethod_4(gform0_0, class119_);
		num = 0;
		while (true)
		{
			bool flag;
			if (flag = (num < 10 || (gform0_0.method_5().method_0()?.ushort_0).GetValueOrDefault() <= 0 || gform0_0.method_5().method_28() == true) && !gform0_0.method_4())
			{
				flag = await gform0_0.smethod_6(42);
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
	}

	private static async Task smethod_4(GForm0 gform0_0, Class119 class119_0)
	{
		if (class119_0 != null)
		{
			Class412.smethod_15();
			await Task.Delay(1000);
			class119_0.method_149();
		}
	}
}
