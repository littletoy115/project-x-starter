using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

internal static class Class385
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct106 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private int int_1;

		private TaskAwaiter taskAwaiter_0;

		private TaskAwaiter<int> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			bool result2;
			try
			{
				TaskAwaiter<int> awaiter2;
				TaskAwaiter awaiter;
				int result;
				switch (num)
				{
				default:
					awaiter = Task.Delay(100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_006e;
				case 0:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_006e;
				case 1:
					awaiter2 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<int>);
					num = -1;
					int_0 = -1;
					goto IL_00dd;
				case 2:
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_00dd:
					result = awaiter2.GetResult();
					int_1 = result;
					awaiter = Task.Delay(100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 2;
						int_0 = 2;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
					IL_006e:
					awaiter.GetResult();
					if (gform0_0 != null)
					{
						awaiter2 = smethod_1(gform0_0).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_00dd;
					}
					result2 = false;
					goto end_IL_0007;
				}
				awaiter.GetResult();
				result2 = int_1 > 0;
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
	private struct Struct107 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private Class386 class386_0;

		private ushort ushort_0;

		private List<Struct96> list_0;

		private int int_1;

		private int int_2;

		private TaskAwaiter<string> taskAwaiter_0;

		private TaskAwaiter<IReadOnlyList<string>> taskAwaiter_1;

		private TaskAwaiter taskAwaiter_2;

		private List<Struct96>.Enumerator enumerator_0;

		private int int_3;

		private int int_4;

		private void MoveNext()
		{
			int num = int_0;
			int result;
			try
			{
				TaskAwaiter<string> awaiter3;
				TaskAwaiter<IReadOnlyList<string>> awaiter2;
				string result2;
				uint uint_;
				IReadOnlyList<string> result3;
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					if (gform0_0 != null)
					{
						awaiter3 = gform0_0.smethod_8(61).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter3;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_008e;
					}
					result = 0;
					goto end_IL_0007;
				case 0:
					awaiter3 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_008e;
				case 1:
					awaiter2 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<IReadOnlyList<string>>);
					num = -1;
					int_0 = -1;
					goto IL_014f;
				case 2:
					awaiter = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_01d7;
				case 3:
				case 4:
					break;
					IL_008e:
					result2 = awaiter3.GetResult();
					if (!smethod_3(gform0_0, result2, out uint_))
					{
						result = 0;
					}
					else if (!smethod_4(uint_, out ushort_0))
					{
						result = 0;
					}
					else
					{
						if (!(smethod_2(gform0_0, result2, uint_) > 30f))
						{
							gform0_0.method_5().method_43();
							awaiter2 = gform0_0.smethod_14().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 1;
								int_0 = 1;
								taskAwaiter_1 = awaiter2;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_014f;
						}
						result = 0;
					}
					goto end_IL_0007;
					IL_01d7:
					awaiter.GetResult();
					int_1 = 0;
					int_2 = 0;
					enumerator_0 = list_0.GetEnumerator();
					break;
					IL_014f:
					result3 = awaiter2.GetResult();
					list_0 = smethod_5(gform0_0, result3);
					if (list_0.Count != 0)
					{
						awaiter = Task.Delay(300).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							taskAwaiter_2 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01d7;
					}
					result = 0;
					goto end_IL_0007;
				}
				try
				{
					if (num != 3)
					{
						if (num != 4)
						{
							goto IL_0348;
						}
						awaiter = taskAwaiter_2;
						taskAwaiter_2 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						goto IL_033a;
					}
					awaiter = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_047f;
					IL_047f:
					awaiter.GetResult();
					int_4++;
					goto IL_045a;
					IL_045a:
					if (int_4 < 50 && !gform0_0.method_4() && gform0_0.method_5().method_57() == int_3 && gform0_0.method_5().method_59() == string.Empty)
					{
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 3;
							int_0 = 3;
							taskAwaiter_2 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_047f;
					}
					if (!gform0_0.method_4() && gform0_0.method_7() != null && !(gform0_0.method_5().method_59() != string.Empty) && gform0_0.method_5().method_57() != int_3)
					{
						IEnumerator<Class78> enumerator = gform0_0.method_5().method_53().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								_ = enumerator.Current;
							}
						}
						finally
						{
							if (num < 0)
							{
								enumerator?.Dispose();
							}
						}
						if (gform0_0.method_5().method_53().Any(class386_0.method_0))
						{
							int_1++;
						}
						awaiter = Task.Delay(500).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 4;
							int_0 = 4;
							taskAwaiter_2 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_033a;
					}
					result = int_1;
					goto end_IL_0007;
					IL_033a:
					awaiter.GetResult();
					class386_0 = null;
					goto IL_0348;
					IL_0348:
					if (!enumerator_0.MoveNext())
					{
						goto end_IL_01fe;
					}
					class386_0 = new Class386();
					class386_0.struct96_0 = enumerator_0.Current;
					int_2++;
					if (gform0_0.method_7() != null)
					{
						int_3 = gform0_0.method_5().method_57();
						gform0_0.method_7().method_169(ushort_0, class386_0.struct96_0.int_0, class386_0.struct96_0.int_1, class386_0.struct96_0.ushort_0, class386_0.struct96_0.ushort_1);
						int_4 = 0;
						goto IL_045a;
					}
					result = int_1;
					goto end_IL_0007;
					end_IL_01fe:;
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator_0/*cast due to .constrained prefix*/).Dispose();
					}
				}
				enumerator_0 = default(List<Struct96>.Enumerator);
				result = int_1;
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

	private sealed class Class386
	{
		public Struct96 struct96_0;

		internal bool method_0(Class78 class78_0)
		{
			if (class78_0.int_0 == struct96_0.int_0 && class78_0.int_1 == struct96_0.int_1 && class78_0.ushort_0 == struct96_0.ushort_0 && class78_0.ushort_1 == struct96_0.ushort_1)
			{
				return class78_0.string_0 == Class185.smethod_0(-1141112980);
			}
			return false;
		}
	}

	public static async Task<bool> smethod_0(GForm0 gform0_0)
	{
		await Task.Delay(100);
		if (gform0_0 == null)
		{
			return false;
		}
		int num = await smethod_1(gform0_0);
		await Task.Delay(100);
		return num > 0;
	}

	private static async Task<int> smethod_1(GForm0 gform0_0)
	{
		if (gform0_0 == null)
		{
			return 0;
		}
		string string_ = await gform0_0.smethod_8(61);
		if (!smethod_3(gform0_0, string_, out var uint_))
		{
			return 0;
		}
		if (!smethod_4(uint_, out var ushort_))
		{
			return 0;
		}
		if (smethod_2(gform0_0, string_, uint_) > 30f)
		{
			return 0;
		}
		gform0_0.method_5().method_43();
		List<Struct96> list = smethod_5(gform0_0, await gform0_0.smethod_14());
		if (list.Count == 0)
		{
			return 0;
		}
		await Task.Delay(300);
		int num = 0;
		int num2 = 0;
		using (List<Struct96>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class386 @class = new Class386
				{
					struct96_0 = enumerator.Current
				};
				num2++;
				if (gform0_0.method_7() != null)
				{
					int num3 = gform0_0.method_5().method_57();
					gform0_0.method_7().method_169(ushort_, @class.struct96_0.int_0, @class.struct96_0.int_1, @class.struct96_0.ushort_0, @class.struct96_0.ushort_1);
					for (int i = 0; i < 50; i++)
					{
						if (gform0_0.method_4())
						{
							break;
						}
						if (gform0_0.method_5().method_57() != num3)
						{
							break;
						}
						if (!(gform0_0.method_5().method_59() == string.Empty))
						{
							break;
						}
						await Task.Delay(100);
					}
					if (!gform0_0.method_4() && gform0_0.method_7() != null && !(gform0_0.method_5().method_59() != string.Empty) && gform0_0.method_5().method_57() != num3)
					{
						foreach (Class78 item in gform0_0.method_5().method_53())
						{
							_ = item;
						}
						if (gform0_0.method_5().method_53().Any(@class.method_0))
						{
							num++;
						}
						await Task.Delay(500);
						continue;
					}
					return num;
				}
				return num;
			}
		}
		return num;
	}

	private static float smethod_2(GForm0 gform0_0, string string_0, uint uint_0)
	{
		if (gform0_0 != null && !string.IsNullOrWhiteSpace(string_0))
		{
			IReadOnlyList<Class403> readOnlyList = gform0_0.method_5()?.method_2();
			if (readOnlyList == null)
			{
				return float.MaxValue;
			}
			float num = float.MaxValue;
			uint num2 = 0u;
			bool flag = false;
			int count = readOnlyList.Count;
			int num3 = 0;
			while (true)
			{
				if (num3 < count)
				{
					if (readOnlyList[num3] != null && readOnlyList[num3].byte_0 == 1)
					{
						ushort ushort_ = readOnlyList[num3].ushort_0;
						ushort ushort_2 = readOnlyList[num3].ushort_1;
						float float_ = readOnlyList[num3].float_0;
						float float_2 = readOnlyList[num3].float_1;
						float float_3 = readOnlyList[num3].float_2;
						uint uint_1 = readOnlyList[num3].uint_0;
						if (Class96.smethod_0(smethod_7(gform0_0, ushort_, ushort_2), string_0))
						{
							float num4 = gform0_0.method_5().method_0()?.float_0 ?? float.NaN;
							float num5 = gform0_0.method_5().method_0()?.float_1 ?? float.NaN;
							float num6 = gform0_0.method_5().method_0()?.float_2 ?? float.NaN;
							if (float.IsNaN(num4) || float.IsNaN(num5) || float.IsNaN(num6))
							{
								break;
							}
							float num7 = smethod_11(num4, num5, num6, float_, float_2, float_3);
							if (!(num7 >= num))
							{
								num = num7;
								num2 = uint_1;
								flag = true;
							}
						}
					}
					num3++;
					continue;
				}
				if (flag && num2 == uint_0)
				{
					return num;
				}
				return float.MaxValue;
			}
			return float.MaxValue;
		}
		return float.MaxValue;
	}

	private static bool smethod_3(GForm0 gform0_0, string string_0, out uint uint_0)
	{
		uint_0 = 0u;
		if (gform0_0 != null && !string.IsNullOrWhiteSpace(string_0))
		{
			IReadOnlyList<Class403> readOnlyList = gform0_0.method_5()?.method_2();
			if (readOnlyList == null)
			{
				return false;
			}
			float num = float.MaxValue;
			bool result = false;
			int count = readOnlyList.Count;
			int num2 = 0;
			while (true)
			{
				if (num2 < count)
				{
					if (readOnlyList[num2] != null && readOnlyList[num2].byte_0 == 1)
					{
						ushort ushort_ = readOnlyList[num2].ushort_0;
						ushort ushort_2 = readOnlyList[num2].ushort_1;
						float float_ = readOnlyList[num2].float_0;
						float float_2 = readOnlyList[num2].float_1;
						float float_3 = readOnlyList[num2].float_2;
						uint uint_1 = readOnlyList[num2].uint_0;
						if (Class96.smethod_0(smethod_7(gform0_0, ushort_, ushort_2), string_0))
						{
							float num3 = gform0_0.method_5().method_0()?.float_0 ?? float.NaN;
							float num4 = gform0_0.method_5().method_0()?.float_1 ?? float.NaN;
							float num5 = gform0_0.method_5().method_0()?.float_2 ?? float.NaN;
							if (float.IsNaN(num3) || float.IsNaN(num4) || float.IsNaN(num5))
							{
								break;
							}
							float num6 = smethod_11(num3, num4, num5, float_, float_2, float_3);
							if (!(num6 >= num))
							{
								num = num6;
								uint_0 = uint_1;
								result = true;
							}
						}
					}
					num2++;
					continue;
				}
				return result;
			}
			return false;
		}
		return false;
	}

	private static bool smethod_4(uint uint_0, out ushort ushort_0)
	{
		ushort_0 = 0;
		if (uint_0 < 4096 && uint_0 != 65535)
		{
			ushort_0 = checked((ushort)uint_0);
			return true;
		}
		return false;
	}

	public static List<Struct96> smethod_5(GForm0 gform0_0, IReadOnlyList<string> ireadOnlyList_0)
	{
		List<Struct96> list = new List<Struct96>();
		if (gform0_0 != null && smethod_9(ireadOnlyList_0))
		{
			IReadOnlyList<Struct27> readOnlyList = gform0_0.method_5()?.method_39();
			if (readOnlyList != null && string.IsNullOrEmpty(gform0_0.method_5()?.method_51()))
			{
				int count = readOnlyList.Count;
				for (int i = 0; i < count; i++)
				{
					Struct27 @struct = readOnlyList[i];
					string text = smethod_8(gform0_0, @struct.ushort_0, @struct.ushort_1);
					if (text == null)
					{
						continue;
					}
					bool flag = false;
					for (int j = 0; j < ireadOnlyList_0.Count; j++)
					{
						if (Class96.smethod_0(text, ireadOnlyList_0[j]))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						Struct96 item = new Struct96
						{
							int_0 = @struct.int_0,
							int_1 = @struct.int_1,
							ushort_0 = @struct.ushort_0,
							ushort_1 = @struct.ushort_1,
							string_0 = text
						};
						int num = list.Count;
						while (num > 0 && item.int_0 > list[num - 1].int_0)
						{
							num--;
						}
						list.Insert(num, item);
					}
				}
				return list;
			}
			return list;
		}
		return list;
	}

	private static IReadOnlyList<Class409.Struct125> smethod_6(List<Struct96> list_0)
	{
		List<Class409.Struct125> list = new List<Class409.Struct125>();
		if (list_0 == null)
		{
			return list;
		}
		for (int i = 0; i < list_0.Count; i++)
		{
			Struct96 @struct = list_0[i];
			list.Add(new Class409.Struct125
			{
				int_0 = @struct.int_0,
				int_1 = @struct.int_1,
				ushort_0 = @struct.ushort_0,
				ushort_1 = @struct.ushort_1
			});
		}
		return list;
	}

	private static string smethod_7(GForm0 gform0_0, ushort ushort_0, ushort ushort_1)
	{
		IReadOnlyDictionary<string, string> readOnlyDictionary = gform0_0?.method_5()?.method_10()?.method_0();
		if (readOnlyDictionary == null)
		{
			return null;
		}
		string key = ushort_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141297577) + ushort_1.ToString(CultureInfo.InvariantCulture);
		if (readOnlyDictionary.TryGetValue(key, out var value) && value != null)
		{
			value = value.Trim();
			if (value.Length != 0)
			{
				return value;
			}
			return null;
		}
		return null;
	}

	private static string smethod_8(GForm0 gform0_0, ushort ushort_0, ushort ushort_1)
	{
		IReadOnlyDictionary<string, string> readOnlyDictionary = gform0_0?.method_5()?.method_10()?.method_2();
		if (readOnlyDictionary == null)
		{
			return null;
		}
		string key = ushort_0.ToString(CultureInfo.InvariantCulture) + Class185.smethod_0(-1141297577) + ushort_1.ToString(CultureInfo.InvariantCulture);
		if (readOnlyDictionary.TryGetValue(key, out var value) && value != null)
		{
			value = value.Trim();
			if (value.Length != 0)
			{
				return value;
			}
			return null;
		}
		return null;
	}

	private static bool smethod_9(IReadOnlyList<string> ireadOnlyList_0)
	{
		return smethod_10(ireadOnlyList_0) != 0;
	}

	private static int smethod_10(IReadOnlyList<string> ireadOnlyList_0)
	{
		int num = 0;
		if (ireadOnlyList_0 == null)
		{
			return num;
		}
		for (int i = 0; i < ireadOnlyList_0.Count; i++)
		{
			if (!string.IsNullOrWhiteSpace(ireadOnlyList_0[i]))
			{
				num++;
			}
		}
		return num;
	}

	private static float smethod_11(float float_0, float float_1, float float_2, float float_3, float float_4, float float_5)
	{
		float num = float_3 - float_0;
		float num2 = float_4 - float_1;
		float num3 = float_5 - float_2;
		return (float)Math.Sqrt(num * num + num2 * num2 + num3 * num3);
	}
}
