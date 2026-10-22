using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public static class GClass15
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct115 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private Struct76 struct76_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private int int_1;

		private TaskAwaiter taskAwaiter_1;

		private TaskAwaiter<bool> taskAwaiter_2;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<string> awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool flag;
				switch (num)
				{
				default:
					awaiter3 = gform0_0.smethod_8(19).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0083;
				case 0:
					awaiter3 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_0083;
				case 1:
					awaiter2 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_018f;
				case 2:
					awaiter = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0168;
				case 3:
					awaiter = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0232;
				case 4:
					awaiter2 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0306;
				case 5:
					{
						awaiter = taskAwaiter_2;
						taskAwaiter_2 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_035e;
					}
					IL_0306:
					awaiter2.GetResult();
					int_1++;
					goto IL_031f;
					IL_0083:
					if (!smethod_4(awaiter3.GetResult(), out struct76_0))
					{
						result = false;
						break;
					}
					goto IL_01f9;
					IL_031f:
					if (!(flag = int_1 < 5 && !gform0_0.method_4()))
					{
						goto IL_033d;
					}
					awaiter = gform0_0.smethod_6(42).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 5;
						int_0 = 5;
						taskAwaiter_2 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_035e;
					IL_01f9:
					if (!(flag = !gform0_0.method_4()))
					{
						goto IL_020b;
					}
					awaiter = gform0_0.smethod_6(42).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 3;
						int_0 = 3;
						taskAwaiter_2 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0232;
					IL_0168:
					flag = awaiter.GetResult();
					goto IL_0170;
					IL_0232:
					flag = awaiter.GetResult();
					goto IL_020b;
					IL_020b:
					if (flag && !Class406.smethod_2(gform0_0, struct76_0.float_0, struct76_0.float_1, struct76_0.float_2, 20f))
					{
						int_1 = 0;
						goto IL_01ba;
					}
					int_1 = 0;
					goto IL_031f;
					IL_033d:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 4;
							int_0 = 4;
							taskAwaiter_1 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0306;
					}
					result = Class406.smethod_2(gform0_0, struct76_0.float_0, struct76_0.float_1, struct76_0.float_2, 20f);
					break;
					IL_018f:
					awaiter2.GetResult();
					int_1++;
					goto IL_01ba;
					IL_01ba:
					if (flag = int_1 < 10 && !gform0_0.method_4())
					{
						awaiter = gform0_0.smethod_6(42).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							taskAwaiter_2 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0168;
					}
					goto IL_0170;
					IL_035e:
					flag = awaiter.GetResult();
					goto IL_033d;
					IL_0170:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_018f;
					}
					gform0_0.method_7().method_176(struct76_0.float_0, struct76_0.float_1, struct76_0.float_2, bool_17: true, null);
					goto IL_01f9;
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
	private struct Struct116 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private string string_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private TaskAwaiter<Enum9> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<string> awaiter2;
				TaskAwaiter<Enum9> awaiter;
				int result2;
				string text;
				switch (num)
				{
				default:
					if (gform0_0 != null)
					{
						awaiter2 = gform0_0.smethod_9("comboBox3").GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0086;
					}
					result = false;
					goto end_IL_0007;
				case 0:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_0086;
				case 1:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_00f0;
				case 2:
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<Enum9>);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_00f0:
					int.TryParse(awaiter2.GetResult(), out result2);
					text = string_0;
					if (!(text == "หย\u0e38ดการทำงาน"))
					{
						if (text == "ด\u0e35เลย\u0e4cตามเวลา และเด\u0e49งฟ\u0e49า ทำงานต\u0e48อ")
						{
							awaiter = Class179.smethod_1(gform0_0, result2, 200, 10.0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 2;
								int_0 = 2;
								taskAwaiter_1 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						result = false;
					}
					else
					{
						gform0_0.method_15(gform0_0.method_14());
						result = true;
					}
					goto end_IL_0007;
					IL_0086:
					text = awaiter2.GetResult();
					string_0 = text;
					awaiter2 = gform0_0.smethod_8(42).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_0 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_00f0;
				}
				awaiter.GetResult();
				result = true;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				string_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct117 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public int int_1;

		private TaskAwaiter<bool> taskAwaiter_0;

		private TaskAwaiter<IReadOnlyList<string>> taskAwaiter_1;

		private int int_2;

		private TaskAwaiter taskAwaiter_2;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<IReadOnlyList<string>> awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool flag2;
				bool flag;
				IReadOnlyList<string> result2;
				switch (num)
				{
				default:
					if (gform0_0 == null)
					{
						result = false;
						break;
					}
					if (!gform0_0.method_127())
					{
						result = false;
						break;
					}
					if (gform0_0.smethod_3())
					{
						result = false;
						break;
					}
					if (gform0_0.method_5().method_28() == true)
					{
						result = false;
						break;
					}
					if (flag = int_1 == 2)
					{
						awaiter = gform0_0.smethod_6(55).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_010a;
					}
					goto IL_0115;
				case 0:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_010a;
				case 1:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0185;
				case 2:
					awaiter3 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<IReadOnlyList<string>>);
					num = -1;
					int_0 = -1;
					goto IL_01f6;
				case 3:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0279;
				case 4:
					awaiter2 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_02ef;
				case 5:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_035f;
				case 6:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0410;
				case 7:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0479;
				case 8:
					awaiter2 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_04e4;
				case 9:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_053c;
				case 10:
					awaiter3 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<IReadOnlyList<string>>);
					num = -1;
					int_0 = -1;
					goto IL_05f0;
				case 11:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0669;
				case 12:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_06cd;
				case 13:
					awaiter2 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_073b;
				case 14:
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_07ab;
					}
					IL_02ef:
					awaiter2.GetResult();
					int_2++;
					goto IL_0308;
					IL_073b:
					awaiter2.GetResult();
					int_2++;
					goto IL_0754;
					IL_0308:
					if (flag = int_2 < 10)
					{
						goto IL_0316;
					}
					if (!(flag2 = gform0_0.smethod_5() && !gform0_0.method_4()))
					{
						goto IL_033e;
					}
					awaiter = gform0_0.smethod_6(42).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 5;
						int_0 = 5;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_035f;
					IL_078a:
					flag = flag2;
					goto IL_0762;
					IL_051b:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 8;
							int_0 = 8;
							taskAwaiter_2 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_04e4;
					}
					awaiter3 = gform0_0.smethod_14().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 10;
						int_0 = 10;
						taskAwaiter_1 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_05f0;
					IL_07ab:
					flag2 = awaiter.GetResult();
					goto IL_078a;
					IL_053c:
					flag = awaiter.GetResult();
					goto IL_051b;
					IL_0762:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 13;
							int_0 = 13;
							taskAwaiter_2 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_073b;
					}
					result = true;
					break;
					IL_035f:
					flag2 = awaiter.GetResult();
					goto IL_033e;
					IL_033e:
					flag = flag2;
					goto IL_0316;
					IL_010a:
					flag = !awaiter.GetResult();
					goto IL_0115;
					IL_0115:
					if (flag)
					{
						result = false;
						break;
					}
					if (flag = int_1 == 2)
					{
						awaiter = smethod_2(gform0_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0185;
					}
					goto IL_0190;
					IL_0316:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 4;
							int_0 = 4;
							taskAwaiter_2 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_02ef;
					}
					awaiter = smethod_3(gform0_0, bool_0: false, null, bool_1: false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 6;
						int_0 = 6;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0410;
					IL_0671:
					awaiter = smethod_5(gform0_0, bool_0: false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 12;
						int_0 = 12;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_06cd;
					IL_0669:
					awaiter.GetResult();
					goto IL_0671;
					IL_0410:
					if (!awaiter.GetResult())
					{
						result = false;
						break;
					}
					awaiter = Class385.smethod_0(gform0_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 7;
						int_0 = 7;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0479;
					IL_0185:
					flag = !awaiter.GetResult();
					goto IL_0190;
					IL_0190:
					if (flag)
					{
						result = false;
						break;
					}
					awaiter3 = gform0_0.smethod_14().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 2;
						int_0 = 2;
						taskAwaiter_1 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_01f6;
					IL_05f0:
					result2 = awaiter3.GetResult();
					if (Class385.smethod_5(gform0_0, result2).Count > 0)
					{
						awaiter = Class385.smethod_0(gform0_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 11;
							int_0 = 11;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0669;
					}
					goto IL_0671;
					IL_06cd:
					awaiter.GetResult();
					int_2 = 0;
					goto IL_0754;
					IL_0754:
					if (flag = int_2 < 10)
					{
						goto IL_0762;
					}
					if (!(flag2 = gform0_0.smethod_5() && !gform0_0.method_4()))
					{
						goto IL_078a;
					}
					awaiter = gform0_0.smethod_6(42).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 14;
						int_0 = 14;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_07ab;
					IL_01f6:
					result2 = awaiter3.GetResult();
					if (Class385.smethod_5(gform0_0, result2).Count == 0)
					{
						result = false;
						break;
					}
					awaiter = smethod_1(gform0_0, int_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 3;
						int_0 = 3;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0279;
					IL_0479:
					awaiter.GetResult();
					int_2 = 0;
					goto IL_04fd;
					IL_04fd:
					if (!(flag = int_2 < 5 && !gform0_0.method_4()))
					{
						goto IL_051b;
					}
					awaiter = gform0_0.smethod_6(42).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 9;
						int_0 = 9;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_053c;
					IL_04e4:
					awaiter2.GetResult();
					int_2++;
					goto IL_04fd;
					IL_0279:
					if (!awaiter.GetResult())
					{
						result = false;
						break;
					}
					int_2 = 0;
					goto IL_0308;
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
	private struct Struct118 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = gform0_0.smethod_8(39).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
				}
				result = int.TryParse(awaiter.GetResult()?.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result2) && gform0_0.method_5().method_39().Count >= result2;
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
	private struct Struct119 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public int int_1;

		private TaskAwaiter taskAwaiter_0;

		private TaskAwaiter<Enum9> taskAwaiter_1;

		private int int_2;

		private TaskAwaiter<bool> taskAwaiter_2;

		private TaskAwaiter<string> taskAwaiter_3;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<string> awaiter4;
				TaskAwaiter<Enum9> awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool flag;
				int num2;
				bool flag2;
				string result2;
				string string_;
				switch (num)
				{
				default:
					if (gform0_0 == null)
					{
						result = false;
						break;
					}
					awaiter2 = Task.Delay(1000).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0099;
				case 0:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0099;
				case 1:
					awaiter3 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<Enum9>);
					num = -1;
					int_0 = -1;
					goto IL_011d;
				case 2:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0189;
				case 3:
					awaiter = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_01f9;
				case 4:
					awaiter = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_02a8;
				case 5:
					awaiter4 = taskAwaiter_3;
					taskAwaiter_3 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_0312;
				case 6:
					awaiter3 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<Enum9>);
					num = -1;
					int_0 = -1;
					goto IL_039d;
				case 7:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0409;
				case 8:
					{
						awaiter = taskAwaiter_2;
						taskAwaiter_2 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_0479;
					}
					IL_01b0:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0189;
					}
					awaiter = gform0_0.smethod_6(101).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 4;
						int_0 = 4;
						taskAwaiter_2 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_02a8;
					IL_0422:
					if (flag = int_2 < 10)
					{
						goto IL_0430;
					}
					if (!(flag2 = gform0_0.smethod_5() && !gform0_0.method_4()))
					{
						goto IL_0458;
					}
					awaiter = gform0_0.smethod_6(42).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 8;
						int_0 = 8;
						taskAwaiter_2 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0479;
					IL_0189:
					awaiter2.GetResult();
					int_2++;
					goto IL_01a2;
					IL_0099:
					awaiter2.GetResult();
					num2 = int_1;
					if (num2 != 1 && num2 == 2)
					{
						awaiter3 = Class179.smethod_0(gform0_0, 3, 200, 10.0).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter3;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_011d;
					}
					goto IL_0125;
					IL_02a8:
					if (awaiter.GetResult())
					{
						awaiter4 = gform0_0.smethod_8(63).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num = 5;
							int_0 = 5;
							taskAwaiter_3 = awaiter4;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_0312;
					}
					goto IL_0484;
					IL_039d:
					awaiter3.GetResult();
					int_2 = 0;
					goto IL_0422;
					IL_0409:
					awaiter2.GetResult();
					int_2++;
					goto IL_0422;
					IL_011d:
					awaiter3.GetResult();
					goto IL_0125;
					IL_0125:
					int_2 = 0;
					goto IL_01a2;
					IL_01a2:
					if (flag = int_2 < 10)
					{
						goto IL_01b0;
					}
					if (!(flag2 = gform0_0.smethod_5() && !gform0_0.method_4()))
					{
						goto IL_01d8;
					}
					awaiter = gform0_0.smethod_6(42).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 3;
						int_0 = 3;
						taskAwaiter_2 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_01f9;
					IL_0312:
					result2 = awaiter4.GetResult();
					string_ = ((result2 == null) ? string.Empty : result2.Trim());
					awaiter3 = Class179.smethod_2(gform0_0, string_, 10, 200, 10.0).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 6;
						int_0 = 6;
						taskAwaiter_1 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_039d;
					IL_0430:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 7;
							int_0 = 7;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0409;
					}
					goto IL_0484;
					IL_0479:
					flag2 = awaiter.GetResult();
					goto IL_0458;
					IL_0458:
					flag = flag2;
					goto IL_0430;
					IL_0484:
					result = true;
					break;
					IL_01f9:
					flag2 = awaiter.GetResult();
					goto IL_01d8;
					IL_01d8:
					flag = flag2;
					goto IL_01b0;
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

	public static async Task<bool> smethod_0(GForm0 gform0_0, int int_0)
	{
		if (gform0_0 == null)
		{
			return false;
		}
		if (!gform0_0.method_127())
		{
			return false;
		}
		if (gform0_0.smethod_3())
		{
			return false;
		}
		if (gform0_0.method_5().method_28() == true)
		{
			return false;
		}
		bool flag;
		if (flag = int_0 == 2)
		{
			flag = !(await gform0_0.smethod_6(55));
		}
		if (flag)
		{
			return false;
		}
		if (flag = int_0 == 2)
		{
			flag = !(await smethod_2(gform0_0));
		}
		if (flag)
		{
			return false;
		}
		if (Class385.smethod_5(gform0_0, await gform0_0.smethod_14()).Count == 0)
		{
			return false;
		}
		if (!(await smethod_1(gform0_0, int_0)))
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (!(flag = num < 10))
			{
				bool flag2;
				if (flag2 = gform0_0.smethod_5() && !gform0_0.method_4())
				{
					flag2 = await gform0_0.smethod_6(42);
				}
				flag = flag2;
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		if (!(await smethod_3(gform0_0, bool_0: false, null, bool_1: false)))
		{
			return false;
		}
		await Class385.smethod_0(gform0_0);
		num = 0;
		while (true)
		{
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
		if (Class385.smethod_5(gform0_0, await gform0_0.smethod_14()).Count > 0)
		{
			await Class385.smethod_0(gform0_0);
		}
		await smethod_5(gform0_0, bool_0: false);
		num = 0;
		while (true)
		{
			if (!(flag = num < 10))
			{
				bool flag2;
				if (flag2 = gform0_0.smethod_5() && !gform0_0.method_4())
				{
					flag2 = await gform0_0.smethod_6(42);
				}
				flag = flag2;
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

	private static async Task<bool> smethod_1(GForm0 gform0_0, int int_0)
	{
		if (gform0_0 == null)
		{
			return false;
		}
		await Task.Delay(1000);
		if (int_0 != 1 && int_0 == 2)
		{
			await Class179.smethod_0(gform0_0, 3, 200, 10.0);
		}
		int num = 0;
		while (true)
		{
			bool flag;
			if (!(flag = num < 10))
			{
				bool flag2;
				if (flag2 = gform0_0.smethod_5() && !gform0_0.method_4())
				{
					flag2 = await gform0_0.smethod_6(42);
				}
				flag = flag2;
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		if (await gform0_0.smethod_6(101))
		{
			string text = await gform0_0.smethod_8(63);
			string string_ = ((text == null) ? string.Empty : text.Trim());
			await Class179.smethod_2(gform0_0, string_, 10, 200, 10.0);
			num = 0;
			while (true)
			{
				bool flag;
				if (!(flag = num < 10))
				{
					bool flag2;
					if (flag2 = gform0_0.smethod_5() && !gform0_0.method_4())
					{
						flag2 = await gform0_0.smethod_6(42);
					}
					flag = flag2;
				}
				if (!flag)
				{
					break;
				}
				await Task.Delay(200);
				num++;
			}
		}
		return true;
	}

	public static async Task<bool> smethod_2(GForm0 gform0_0)
	{
		if (!int.TryParse((await gform0_0.smethod_8(39))?.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
		{
			return false;
		}
		return gform0_0.method_5().method_39().Count >= result;
	}

	private static async Task<bool> smethod_3(GForm0 gform0_0, bool bool_0, string string_0, bool bool_1)
	{
		if (!smethod_4(await gform0_0.smethod_8(19), out var struct76_))
		{
			return false;
		}
		int num;
		while (true)
		{
			bool flag;
			if (flag = !gform0_0.method_4())
			{
				flag = await gform0_0.smethod_6(42);
			}
			if (!flag || Class406.smethod_2(gform0_0, struct76_.float_0, struct76_.float_1, struct76_.float_2, 20f))
			{
				break;
			}
			num = 0;
			while (true)
			{
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
			gform0_0.method_7().method_176(struct76_.float_0, struct76_.float_1, struct76_.float_2, bool_17: true, null);
		}
		num = 0;
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
		return Class406.smethod_2(gform0_0, struct76_.float_0, struct76_.float_1, struct76_.float_2, 20f);
	}

	private static bool smethod_4(string string_0, out Struct76 struct76_0)
	{
		struct76_0 = default(Struct76);
		if (!Class440.smethod_6(string_0, out var float_, out var float_2, out var float_3))
		{
			return false;
		}
		struct76_0 = new Struct76
		{
			float_0 = float_,
			float_1 = float_2,
			float_2 = float_3
		};
		return true;
	}

	public static async Task<bool> smethod_5(GForm0 gform0_0, bool bool_0)
	{
		if (gform0_0 == null)
		{
			return false;
		}
		string text = await gform0_0.smethod_9("comboBox3");
		int.TryParse(await gform0_0.smethod_8(42), out var result);
		string text2 = text;
		if (!(text2 == "หย\u0e38ดการทำงาน"))
		{
			if (!(text2 == "ด\u0e35เลย\u0e4cตามเวลา และเด\u0e49งฟ\u0e49า ทำงานต\u0e48อ"))
			{
				return false;
			}
			await Class179.smethod_1(gform0_0, result, 200, 10.0);
			return true;
		}
		gform0_0.method_15(gform0_0.method_14());
		return true;
	}
}
