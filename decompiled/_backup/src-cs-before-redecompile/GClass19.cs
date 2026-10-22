using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public static class GClass19
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct129 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public Class403 class403_0;

		public Class119 class119_0;

		private Class419 class419_0;

		private Action<uint, bool, bool, string> action_0;

		private TaskAwaiter<Task> taskAwaiter_0;

		private TaskAwaiter<bool> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				if ((uint)num > 1u)
				{
					class419_0 = new Class419();
					class419_0.class403_0 = class403_0;
					class419_0.taskCompletionSource_0 = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
					action_0 = class419_0.method_0;
					class119_0.method_56(action_0);
				}
				try
				{
					TaskAwaiter<bool> awaiter;
					TaskAwaiter<Task> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter<bool>);
							num = -1;
							int_0 = -1;
							goto IL_019c;
						}
						if (class419_0.class403_0.method_2())
						{
							class119_0.method_125();
						}
						else
						{
							class119_0.method_124(class419_0.class403_0.uint_0);
						}
						awaiter2 = Task.WhenAny(class419_0.taskCompletionSource_0.Task, Task.Delay(1500)).GetAwaiter();
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
						taskAwaiter_0 = default(TaskAwaiter<Task>);
						num = -1;
						int_0 = -1;
					}
					bool flag;
					if (flag = awaiter2.GetResult() == class419_0.taskCompletionSource_0.Task)
					{
						awaiter = class419_0.taskCompletionSource_0.Task.GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_019c;
					}
					goto IL_01a4;
					IL_019c:
					flag = awaiter.GetResult();
					goto IL_01a4;
					IL_01a4:
					result = flag;
				}
				finally
				{
					if (num < 0)
					{
						class119_0.method_57(action_0);
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class419_0 = null;
				action_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class419_0 = null;
			action_0 = null;
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

	private sealed class Class419
	{
		public Class403 class403_0;

		public TaskCompletionSource<bool> taskCompletionSource_0;

		internal void method_0(uint uint_0, bool bool_0, bool bool_1, string string_0)
		{
			if (bool_0 == class403_0.method_2() && (bool_0 || uint_0 == class403_0.uint_0))
			{
				taskCompletionSource_0.TrySetResult(bool_1);
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct130 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private List<string> list_0;

		private List<string> list_1;

		private bool bool_0;

		private bool bool_1;

		private Class119 class119_0;

		private (ushort, ushort)[] valueTuple_0;

		private IReadOnlyList<uint> ireadOnlyList_0;

		private int int_1;

		private int int_2;

		private TaskAwaiter<bool> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private TaskAwaiter<int> taskAwaiter_2;

		private IEnumerator<Class403> ienumerator_0;

		private void MoveNext()
		{
			int num = int_0;
			bool result2;
			try
			{
				TaskAwaiter<string> awaiter2;
				TaskAwaiter<int> awaiter;
				float num2 = default(float);
				bool flag;
				string result;
				TaskAwaiter<bool> awaiter3;
				switch (num)
				{
				default:
					awaiter3 = gform0_0.smethod_6(24).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_008c;
				case 0:
					awaiter3 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_008c;
				case 1:
					awaiter3 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_00f6;
				case 2:
					awaiter3 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0192;
				case 3:
					awaiter3 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0216;
				case 4:
					awaiter2 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_0338;
				case 5:
					awaiter2 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_03ac;
				case 6:
					awaiter = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<int>);
					num = -1;
					int_0 = -1;
					goto IL_041f;
				case 7:
				case 8:
					break;
					IL_03ac:
					result = awaiter2.GetResult();
					int_2 = Class342.smethod_33(result);
					awaiter = gform0_0.smethod_10(1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 6;
						int_0 = 6;
						taskAwaiter_2 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_041f;
					IL_008c:
					if (flag = !awaiter3.GetResult())
					{
						awaiter3 = gform0_0.smethod_6(25).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_0 = awaiter3;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_00f6;
					}
					goto IL_0102;
					IL_0216:
					flag = awaiter3.GetResult();
					bool_1 = flag && gform0_0.method_103(10, out list_1);
					if (!bool_0 && !bool_1)
					{
						result2 = false;
					}
					else
					{
						class119_0 = gform0_0.method_7();
						if (class119_0 != null && class119_0.method_139())
						{
							valueTuple_0 = class119_0.ValueTuple_0;
							if (valueTuple_0 != null && valueTuple_0.Length >= 10)
							{
								ireadOnlyList_0 = gform0_0.method_5().method_16();
								if (ireadOnlyList_0 != null)
								{
									awaiter2 = gform0_0.smethod_8(43).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num = 4;
										int_0 = 4;
										taskAwaiter_1 = awaiter2;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										return;
									}
									goto IL_0338;
								}
								result2 = false;
							}
							else
							{
								result2 = false;
							}
						}
						else
						{
							result2 = false;
						}
					}
					goto end_IL_0007;
					IL_041f:
					num2 = awaiter.GetResult();
					ienumerator_0 = gform0_0.method_5().method_4().GetEnumerator();
					break;
					IL_00f6:
					flag = !awaiter3.GetResult();
					goto IL_0102;
					IL_0102:
					if (flag)
					{
						result2 = false;
					}
					else
					{
						if (gform0_0.smethod_4())
						{
							list_0 = new List<string>();
							list_1 = new List<string>();
							awaiter3 = gform0_0.smethod_6(24).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 2;
								int_0 = 2;
								taskAwaiter_0 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_0192;
						}
						result2 = false;
					}
					goto end_IL_0007;
					IL_0192:
					flag = awaiter3.GetResult();
					bool_0 = flag && gform0_0.method_103(9, out list_0);
					awaiter3 = gform0_0.smethod_6(25).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 3;
						int_0 = 3;
						taskAwaiter_0 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0216;
					IL_0338:
					result = awaiter2.GetResult();
					int_1 = Class342.smethod_33(result);
					awaiter2 = gform0_0.smethod_8(44).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 5;
						int_0 = 5;
						taskAwaiter_1 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_03ac;
				}
				try
				{
					if (num == 7)
					{
						awaiter3 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_07a2;
					}
					if (num == 8)
					{
						awaiter3 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_0779;
					}
					Class403 current;
					while (ienumerator_0.MoveNext())
					{
						current = ienumerator_0.Current;
						if (current == null || !ireadOnlyList_0.Contains(current.uint_0) || gform0_0.method_5().method_14() == null || !gform0_0.method_5().method_14().Contains(current.uint_0) || !gform0_0.method_5().method_10().method_4()
							.TryGetValue(current.uint_0.ToString(CultureInfo.InvariantCulture), out var value))
						{
							continue;
						}
						bool flag2 = bool_0 && list_0.Contains(value, StringComparer.OrdinalIgnoreCase);
						bool flag3 = bool_1 && list_1.Contains(value, StringComparer.OrdinalIgnoreCase);
						if ((!flag2 && !flag3) || (!current.method_2() && !Class406.smethod_2(gform0_0, current.float_0, current.float_1, current.float_2, num2)) || !gform0_0.method_5().method_18().TryGetValue(current.uint_0, out var value2))
						{
							continue;
						}
						if (flag2 && smethod_1(value2, valueTuple_0[8].Item1, valueTuple_0[8].Item2, int_1) && Class342.smethod_26(valueTuple_0[8].Item1, valueTuple_0[8].Item2, class119_0.method_19(), Class342.smethod_10()))
						{
							goto IL_0678;
						}
						if (!flag3 || !smethod_1(value2, valueTuple_0[9].Item1, valueTuple_0[9].Item2, int_2) || !Class342.smethod_26(valueTuple_0[9].Item1, valueTuple_0[9].Item2, class119_0.method_19(), Class342.smethod_10()))
						{
							continue;
						}
						goto IL_06eb;
					}
					goto end_IL_0445;
					IL_0779:
					result2 = awaiter3.GetResult();
					goto end_IL_0007;
					IL_0678:
					awaiter3 = smethod_2(gform0_0, class119_0, current, num2, 9, valueTuple_0[8].Item1, valueTuple_0[8].Item2, int_1).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 7;
						int_0 = 7;
						taskAwaiter_0 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_07a2;
					IL_07a2:
					result2 = awaiter3.GetResult();
					goto end_IL_0007;
					IL_06eb:
					awaiter3 = smethod_2(gform0_0, class119_0, current, num2, 10, valueTuple_0[9].Item1, valueTuple_0[9].Item2, int_2).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 8;
						int_0 = 8;
						taskAwaiter_0 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0779;
					end_IL_0445:;
				}
				finally
				{
					if (num < 0 && ienumerator_0 != null)
					{
						ienumerator_0.Dispose();
					}
				}
				ienumerator_0 = null;
				result2 = false;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				list_0 = null;
				list_1 = null;
				class119_0 = null;
				valueTuple_0 = null;
				ireadOnlyList_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			list_0 = null;
			list_1 = null;
			class119_0 = null;
			valueTuple_0 = null;
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

	private sealed class Class420
	{
		public Class403 class403_0;

		public int int_0;

		public TaskCompletionSource<Class74> taskCompletionSource_0;

		internal bool method_0(Class403 class403_1)
		{
			if (class403_1 != null)
			{
				return class403_1.uint_0 == class403_0.uint_0;
			}
			return false;
		}

		internal void method_1(Class74 class74_0)
		{
			if (class74_0 != null && class74_0.int_0 == int_0)
			{
				taskCompletionSource_0.TrySetResult(class74_0);
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct131 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public Class403 class403_0;

		public int int_1;

		public Class119 class119_0;

		public GForm0 gform0_0;

		private Class420 class420_0;

		public float float_0;

		public ushort ushort_0;

		public ushort ushort_1;

		public int int_2;

		private Action<Class74> action_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private int int_3;

		private TaskAwaiter<Task> taskAwaiter_1;

		private TaskAwaiter<Class74> taskAwaiter_2;

		private int int_4;

		private TaskAwaiter taskAwaiter_3;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					if ((uint)(num - 1) <= 2u)
					{
						goto IL_01a2;
					}
					class420_0 = new Class420();
					class420_0.class403_0 = class403_0;
					class420_0.int_0 = int_1;
					awaiter = smethod_3(class119_0, class420_0.class403_0).GetAwaiter();
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
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
				}
				if (!awaiter.GetResult())
				{
					result = false;
				}
				else if (gform0_0.method_7() != class119_0)
				{
					result = true;
				}
				else
				{
					IReadOnlyList<uint> readOnlyList = gform0_0.method_5().method_16();
					Class403 @class = gform0_0.method_5().method_4().FirstOrDefault(class420_0.method_0);
					if (readOnlyList != null && readOnlyList.Contains(class420_0.class403_0.uint_0) && @class != null)
					{
						if (@class.method_2() || Class406.smethod_2(gform0_0, @class.float_0, @class.float_1, @class.float_2, float_0))
						{
							class420_0.taskCompletionSource_0 = new TaskCompletionSource<Class74>(TaskCreationOptions.RunContinuationsAsynchronously);
							action_0 = class420_0.method_1;
							class119_0.method_64(action_0);
							goto IL_01a2;
						}
						result = true;
					}
					else
					{
						result = true;
					}
				}
				goto end_IL_0007;
				IL_01a2:
				try
				{
					TaskAwaiter<Task> awaiter4;
					TaskAwaiter<Class74> awaiter3;
					TaskAwaiter awaiter2;
					IReadOnlyList<GStruct2> value;
					Class74 result2;
					switch (num)
					{
					default:
						int_3 = gform0_0.method_5().method_89();
						class119_0.method_173(class420_0.int_0, ushort_0, ushort_1);
						awaiter4 = Task.WhenAny(class420_0.taskCompletionSource_0.Task, Task.Delay(7000)).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter4;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_026a;
					case 1:
						awaiter4 = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<Task>);
						num = -1;
						int_0 = -1;
						goto IL_026a;
					case 2:
						awaiter3 = taskAwaiter_2;
						taskAwaiter_2 = default(TaskAwaiter<Class74>);
						num = -1;
						int_0 = -1;
						goto IL_02eb;
					case 3:
						{
							awaiter2 = taskAwaiter_3;
							taskAwaiter_3 = default(TaskAwaiter);
							num = -1;
							int_0 = -1;
							goto IL_03e0;
						}
						IL_03e0:
						awaiter2.GetResult();
						if (gform0_0.method_5().method_89() <= int_3 || !gform0_0.method_5().method_18().TryGetValue(class420_0.class403_0.uint_0, out value) || smethod_1(value, ushort_0, ushort_1, int_2))
						{
							int_4++;
							goto IL_035e;
						}
						result = true;
						goto end_IL_01a2;
						IL_026a:
						if (awaiter4.GetResult() == class420_0.taskCompletionSource_0.Task)
						{
							awaiter3 = class420_0.taskCompletionSource_0.Task.GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 2;
								int_0 = 2;
								taskAwaiter_2 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_02eb;
						}
						result = true;
						goto end_IL_01a2;
						IL_02eb:
						result2 = awaiter3.GetResult();
						if (!(result2.string_0 != "ok") || !(result2.string_0 != "move"))
						{
							int_4 = 0;
							goto IL_035e;
						}
						result = true;
						goto end_IL_01a2;
						IL_035e:
						if (int_4 >= 25 || gform0_0.method_4())
						{
							break;
						}
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 3;
							int_0 = 3;
							taskAwaiter_3 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_03e0;
					}
					result = true;
					end_IL_01a2:;
				}
				finally
				{
					if (num < 0)
					{
						class119_0.method_65(action_0);
					}
				}
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class420_0 = null;
				action_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class420_0 = null;
			action_0 = null;
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
		bool flag;
		if (flag = !(await gform0_0.smethod_6(24)))
		{
			flag = !(await gform0_0.smethod_6(25));
		}
		if (flag)
		{
			return false;
		}
		if (!gform0_0.smethod_4())
		{
			return false;
		}
		List<string> list_ = new List<string>();
		List<string> list_2 = new List<string>();
		bool flag2 = await gform0_0.smethod_6(24) && gform0_0.method_103(9, out list_);
		bool flag3 = await gform0_0.smethod_6(25) && gform0_0.method_103(10, out list_2);
		if (!flag2 && !flag3)
		{
			return false;
		}
		Class119 @class = gform0_0.method_7();
		if (@class != null && @class.method_139())
		{
			(ushort, ushort)[] valueTuple_ = @class.ValueTuple_0;
			if (valueTuple_ != null && valueTuple_.Length >= 10)
			{
				IReadOnlyList<uint> readOnlyList = gform0_0.method_5().method_16();
				if (readOnlyList == null)
				{
					return false;
				}
				int num = Class342.smethod_33(await gform0_0.smethod_8(43));
				int num2 = Class342.smethod_33(await gform0_0.smethod_8(44));
				float num3 = await gform0_0.smethod_10(1);
				foreach (Class403 item in gform0_0.method_5().method_4())
				{
					if (item == null || !readOnlyList.Contains(item.uint_0) || gform0_0.method_5().method_14() == null || !gform0_0.method_5().method_14().Contains(item.uint_0) || !gform0_0.method_5().method_10().method_4()
						.TryGetValue(item.uint_0.ToString(CultureInfo.InvariantCulture), out var value))
					{
						continue;
					}
					bool flag4 = flag2 && list_.Contains(value, StringComparer.OrdinalIgnoreCase);
					bool flag5 = flag3 && list_2.Contains(value, StringComparer.OrdinalIgnoreCase);
					if ((flag4 || flag5) && (item.method_2() || Class406.smethod_2(gform0_0, item.float_0, item.float_1, item.float_2, num3)) && gform0_0.method_5().method_18().TryGetValue(item.uint_0, out var value2))
					{
						if (flag4 && smethod_1(value2, valueTuple_[8].Item1, valueTuple_[8].Item2, num) && Class342.smethod_26(valueTuple_[8].Item1, valueTuple_[8].Item2, @class.method_19(), Class342.smethod_10()))
						{
							return await smethod_2(gform0_0, @class, item, num3, 9, valueTuple_[8].Item1, valueTuple_[8].Item2, num);
						}
						if (flag5 && smethod_1(value2, valueTuple_[9].Item1, valueTuple_[9].Item2, num2) && Class342.smethod_26(valueTuple_[9].Item1, valueTuple_[9].Item2, @class.method_19(), Class342.smethod_10()))
						{
							return await smethod_2(gform0_0, @class, item, num3, 10, valueTuple_[9].Item1, valueTuple_[9].Item2, num2);
						}
					}
				}
				return false;
			}
			return false;
		}
		return false;
	}

	internal static bool smethod_1(IReadOnlyList<GStruct2> ireadOnlyList_0, ushort ushort_0, ushort ushort_1, int int_0)
	{
		if (ireadOnlyList_0 != null && ushort_0 != ushort.MaxValue && ushort_1 != ushort.MaxValue && (ushort_0 != 0 || ushort_1 != 0))
		{
			foreach (GStruct2 item in ireadOnlyList_0)
			{
				if (item.ushort_0 == ushort_0 && item.ushort_1 == ushort_1)
				{
					return item.float_0 <= (float)int_0;
				}
			}
			return true;
		}
		return false;
	}

	private static async Task<bool> smethod_2(GForm0 gform0_0, Class119 class119_0, Class403 class403_0, float float_0, int int_0, ushort ushort_0, ushort ushort_1, int int_1)
	{
		Class420 @class = new Class420
		{
			class403_0 = class403_0,
			int_0 = int_0
		};
		if (!(await smethod_3(class119_0, @class.class403_0)))
		{
			return false;
		}
		if (gform0_0.method_7() != class119_0)
		{
			return true;
		}
		IReadOnlyList<uint> readOnlyList = gform0_0.method_5().method_16();
		Class403 class2 = gform0_0.method_5().method_4().FirstOrDefault(@class.method_0);
		if (readOnlyList != null && readOnlyList.Contains(@class.class403_0.uint_0) && class2 != null)
		{
			if (!class2.method_2() && !Class406.smethod_2(gform0_0, class2.float_0, class2.float_1, class2.float_2, float_0))
			{
				return true;
			}
			@class.taskCompletionSource_0 = new TaskCompletionSource<Class74>(TaskCreationOptions.RunContinuationsAsynchronously);
			Action<Class74> action_ = @class.method_1;
			class119_0.method_64(action_);
			try
			{
				int num = gform0_0.method_5().method_89();
				class119_0.method_173(@class.int_0, ushort_0, ushort_1);
				if (await Task.WhenAny(@class.taskCompletionSource_0.Task, Task.Delay(7000)) != @class.taskCompletionSource_0.Task)
				{
					return true;
				}
				Class74 class3 = await @class.taskCompletionSource_0.Task;
				if (class3.string_0 != "ok" && class3.string_0 != "move")
				{
					return true;
				}
				for (int i = 0; i < 25; i++)
				{
					if (gform0_0.method_4())
					{
						break;
					}
					await Task.Delay(200);
					if (gform0_0.method_5().method_89() > num && gform0_0.method_5().method_18().TryGetValue(@class.class403_0.uint_0, out var value) && !smethod_1(value, ushort_0, ushort_1, int_1))
					{
						return true;
					}
				}
				return true;
			}
			finally
			{
				class119_0.method_65(action_);
			}
		}
		return true;
	}

	private static async Task<bool> smethod_3(Class119 class119_0, Class403 class403_0)
	{
		Class419 @class = new Class419
		{
			class403_0 = class403_0,
			taskCompletionSource_0 = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously)
		};
		Action<uint, bool, bool, string> action_ = @class.method_0;
		class119_0.method_56(action_);
		try
		{
			if (@class.class403_0.method_2())
			{
				class119_0.method_125();
			}
			else
			{
				class119_0.method_124(@class.class403_0.uint_0);
			}
			bool result;
			if (result = await Task.WhenAny(@class.taskCompletionSource_0.Task, Task.Delay(1500)) == @class.taskCompletionSource_0.Task)
			{
				result = await @class.taskCompletionSource_0.Task;
			}
			return result;
		}
		finally
		{
			class119_0.method_57(action_);
		}
	}
}
