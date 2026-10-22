using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal static class Class138
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct34 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public uint uint_0;

		private TaskAwaiter<List<int>> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<List<int>> awaiter;
				if (num == 0)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<List<int>>);
					num = -1;
					int_0 = -1;
					goto IL_008e;
				}
				Class119 @class = gform0_0.method_7();
				if (@class != null && @class.method_132())
				{
					awaiter = Class104.smethod_0(gform0_0, 6, 15).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_008e;
				}
				result = false;
				goto end_IL_0008;
				IL_008e:
				List<int> result2 = awaiter.GetResult();
				if (result2.Count == 0)
				{
					result = false;
				}
				else
				{
					int[] array = new int[result2.Count];
					for (int i = 0; i < result2.Count; i++)
					{
						array[i] = result2[i] - 5;
					}
					Class119 class2 = gform0_0.method_7();
					if (class2 != null && class2.method_132())
					{
						class2.method_134(array);
						Class52 class3 = Volatile.Read(ref class52_0);
						if (class3 == null)
						{
							result = false;
						}
						else
						{
							int num2 = 0;
							while (true)
							{
								if (num2 < array.Length)
								{
									int num3 = array[num2];
									if (!class3.method_0(num3))
									{
										num2++;
										continue;
									}
									Class119 class4 = gform0_0.method_7();
									if (class4 != null && class4.method_132())
									{
										int[] ienumerable_ = new int[1] { num3 };
										class4.method_128(uint_0);
										class4.method_133(ienumerable_);
										Class403 class5 = null;
										IReadOnlyList<Class403> readOnlyList = gform0_0.method_5().method_2();
										if (readOnlyList != null)
										{
											for (int j = 0; j < readOnlyList.Count; j++)
											{
												if (readOnlyList[j] != null && readOnlyList[j].uint_0 == uint_0)
												{
													class5 = readOnlyList[j];
													break;
												}
											}
										}
										Class83 class6 = gform0_0.method_5().method_0();
										if (class5 != null)
										{
											_ = $"({class5.float_0:F2},{class5.float_1:F2},{class5.float_2:F2})";
										}
										if (class5 != null)
										{
											_ = $"{class5.ushort_2}/{class5.ushort_3}";
										}
										if (class6 != null)
										{
											_ = $"({class6.float_0:F2},{class6.float_1:F2},{class6.float_2:F2})";
										}
										result = true;
									}
									else
									{
										result = false;
									}
									break;
								}
								result = false;
								break;
							}
						}
					}
					else
					{
						result = false;
					}
				}
				end_IL_0008:;
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

	private static Class52 class52_0;

	internal static Class52 smethod_0()
	{
		return Volatile.Read(ref class52_0);
	}

	public static void smethod_1(IReadOnlyList<GStruct1> ireadOnlyList_0)
	{
		Volatile.Write(ref class52_0, new Class52(ireadOnlyList_0));
	}

	public static async Task<bool> smethod_2(GForm0 gform0_0, uint uint_0)
	{
		Class119 @class = gform0_0.method_7();
		if (@class == null || !@class.method_132())
		{
			return false;
		}
		List<int> list = await Class104.smethod_0(gform0_0, 6, 15);
		if (list.Count == 0)
		{
			return false;
		}
		int[] array = new int[list.Count];
		for (int i = 0; i < list.Count; i++)
		{
			array[i] = list[i] - 5;
		}
		Class119 class2 = gform0_0.method_7();
		if (class2 != null && class2.method_132())
		{
			class2.method_134(array);
			Class52 class3 = Volatile.Read(ref class52_0);
			if (class3 == null)
			{
				return false;
			}
			int num = 0;
			int num2;
			while (true)
			{
				if (num < array.Length)
				{
					num2 = array[num];
					if (class3.method_0(num2))
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			Class119 class4 = gform0_0.method_7();
			if (class4 != null && class4.method_132())
			{
				int[] ienumerable_ = new int[1] { num2 };
				class4.method_128(uint_0);
				class4.method_133(ienumerable_);
				Class403 class5 = null;
				IReadOnlyList<Class403> readOnlyList = gform0_0.method_5().method_2();
				if (readOnlyList != null)
				{
					for (int j = 0; j < readOnlyList.Count; j++)
					{
						if (readOnlyList[j] != null && readOnlyList[j].uint_0 == uint_0)
						{
							class5 = readOnlyList[j];
							break;
						}
					}
				}
				Class83 class6 = gform0_0.method_5().method_0();
				if (class5 != null)
				{
					_ = $"({class5.float_0:F2},{class5.float_1:F2},{class5.float_2:F2})";
				}
				if (class5 != null)
				{
					_ = $"{class5.ushort_2}/{class5.ushort_3}";
				}
				if (class6 != null)
				{
					_ = $"({class6.float_0:F2},{class6.float_1:F2},{class6.float_2:F2})";
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public static void smethod_3()
	{
		Volatile.Write(ref class52_0, null);
	}
}
