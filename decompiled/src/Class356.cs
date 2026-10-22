using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

internal static class Class356
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct97 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public float float_0;

		private bool bool_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<string> awaiter3;
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				string text;
				string string_;
				Class31 @class;
				uint num2;
				bool result2;
				bool result3;
				switch (num)
				{
				default:
					awaiter = gform0_0.smethod_6(97).GetAwaiter();
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
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_00eb;
				case 2:
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0157;
				case 3:
					awaiter3 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_01e7;
				case 4:
					awaiter2 = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0316;
				case 5:
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_031d:
					Class412.smethod_14();
					goto IL_0322;
					IL_0080:
					if (awaiter.GetResult())
					{
						awaiter = gform0_0.smethod_7(26).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00eb;
					}
					result = false;
					goto end_IL_0007;
					IL_01e7:
					text = awaiter3.GetResult();
					goto IL_01f0;
					IL_0316:
					awaiter2.GetResult();
					goto IL_031d;
					IL_01f0:
					string_ = text;
					@class = Class38.smethod_8(gform0_0.method_5(), string_, bool_0, gform0_0.method_110(), DateTime.UtcNow);
					if (@class != null && @class.bool_1 && @class.byte_0 == 0)
					{
						if (Class412.smethod_0())
						{
							Class119 class2 = gform0_0.method_7();
							if (class2 != null)
							{
								awaiter2 = class2.method_130().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = 4;
									int_0 = 4;
									configuredTaskAwaiter_0 = awaiter2;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0316;
							}
							goto IL_031d;
						}
						goto IL_0322;
					}
					num2 = Class38.smethod_7(gform0_0.method_5(), @class, float_0);
					if (num2 != 0)
					{
						awaiter = Class412.smethod_11(gform0_0, num2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 5;
							int_0 = 5;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
					result = false;
					goto end_IL_0007;
					IL_00eb:
					result2 = awaiter.GetResult();
					bool_0 = result2;
					awaiter = gform0_0.smethod_7(27).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 2;
						int_0 = 2;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0157;
					IL_0322:
					result = false;
					goto end_IL_0007;
					IL_0157:
					result3 = awaiter.GetResult();
					if ((bool_0 || result3) && gform0_0.smethod_4())
					{
						if (result3)
						{
							awaiter3 = gform0_0.smethod_8(41).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 3;
								int_0 = 3;
								taskAwaiter_1 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_01e7;
						}
						text = null;
						goto IL_01f0;
					}
					result = false;
					goto end_IL_0007;
				}
				result = awaiter.GetResult();
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
	private struct Struct98 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private bool bool_0;

		private Class31 class31_0;

		private DateTime dateTime_0;

		private bool bool_1;

		private float float_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private TaskAwaiter<int> taskAwaiter_2;

		private TaskAwaiter<float> taskAwaiter_3;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<bool> awaiter4;
				TaskAwaiter<string> awaiter3;
				TaskAwaiter<int> awaiter2;
				TaskAwaiter<float> awaiter;
				string string_;
				string text;
				bool result2;
				bool result3;
				int result4;
				switch (num)
				{
				default:
					awaiter4 = gform0_0.smethod_7(26).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter4;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
						return;
					}
					goto IL_007c;
				case 0:
					awaiter4 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_007c;
				case 1:
					awaiter4 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_00e8;
				case 2:
					awaiter3 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_017d;
				case 3:
					awaiter2 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<int>);
					num = -1;
					int_0 = -1;
					goto IL_0250;
				case 4:
					{
						awaiter = taskAwaiter_3;
						taskAwaiter_3 = default(TaskAwaiter<float>);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_0186:
					string_ = text;
					class31_0 = Class38.smethod_8(gform0_0.method_5(), string_, bool_0, gform0_0.method_110(), DateTime.UtcNow);
					if (class31_0 != null)
					{
						dateTime_0 = DateTime.UtcNow;
						bool_1 = class441_0.method_0(class31_0, dateTime_0);
						awaiter2 = gform0_0.smethod_10(1).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 3;
							int_0 = 3;
							taskAwaiter_2 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0250;
					}
					smethod_3();
					result = false;
					goto end_IL_0007;
					IL_007c:
					result2 = awaiter4.GetResult();
					bool_0 = result2;
					awaiter4 = gform0_0.smethod_7(27).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_0 = awaiter4;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
						return;
					}
					goto IL_00e8;
					IL_017d:
					text = awaiter3.GetResult();
					goto IL_0186;
					IL_00e8:
					result3 = awaiter4.GetResult();
					if ((bool_0 || result3) && gform0_0.smethod_4())
					{
						if (result3)
						{
							awaiter3 = gform0_0.smethod_8(41).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 2;
								int_0 = 2;
								taskAwaiter_1 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_017d;
						}
						text = null;
						goto IL_0186;
					}
					smethod_3();
					result = false;
					goto end_IL_0007;
					IL_0250:
					result4 = awaiter2.GetResult();
					float_0 = result4;
					awaiter = gform0_0.smethod_11(2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 4;
						int_0 = 4;
						taskAwaiter_3 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
				}
				float result5 = awaiter.GetResult();
				Class83 @class = gform0_0.method_5().method_0();
				float float_;
				float float_2;
				float float_3;
				if (@class == null)
				{
					result = false;
				}
				else if (!Class38.smethod_1(@class.float_0, @class.float_1, @class.float_2, class31_0.float_0, class31_0.float_1, class31_0.float_2, bool_1, float_0, result5, out float_, out float_2, out float_3))
				{
					result = bool_1;
				}
				else
				{
					Class119 class2 = gform0_0.method_7();
					if (class2 == null)
					{
						result = false;
					}
					else
					{
						if (class119_0 == class2 && uint_0 == class31_0.uint_0 && !(Class406.smethod_1(Class356.float_0, float_1, Class356.float_2, float_, float_2, float_3) > (class31_0.bool_0 ? 1f : 0.25f)) && (gform0_0.method_5().method_0()?.byte_3 == 1 || !((dateTime_0 - Class356.dateTime_0).TotalMilliseconds > 1000.0)))
						{
							goto IL_04b3;
						}
						if (class2.method_177(float_, float_2, float_3, bool_17: true, "follow_party"))
						{
							long num2 = DateTime.UtcNow.Ticks / 10000L;
							if (Class174.smethod_0(long_0, num2))
							{
								long_0 = num2;
							}
							class119_0 = class2;
							uint_0 = class31_0.uint_0;
							Class356.float_0 = float_;
							float_1 = float_2;
							Class356.float_2 = float_3;
							Class356.dateTime_0 = dateTime_0;
							goto IL_04b3;
						}
						result = false;
					}
				}
				goto end_IL_0007;
				IL_04b3:
				result = true;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class31_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class31_0 = null;
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
	private struct Struct99 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public float float_0;

		private bool bool_0;

		private string string_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private TaskAwaiter<List<uint>> taskAwaiter_2;

		private List<uint>.Enumerator enumerator_0;

		private uint uint_0;

		private void MoveNext()
		{
			int num = int_0;
			bool result3;
			try
			{
				TaskAwaiter<string> awaiter2;
				TaskAwaiter<List<uint>> awaiter;
				string text;
				bool result;
				bool result2;
				List<uint> result4;
				TaskAwaiter<bool> awaiter3;
				switch (num)
				{
				default:
					awaiter3 = gform0_0.smethod_7(26).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0080;
				case 0:
					awaiter3 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0080;
				case 1:
					awaiter3 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_00ec;
				case 2:
					awaiter2 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_017c;
				case 3:
					awaiter = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<List<uint>>);
					num = -1;
					int_0 = -1;
					goto IL_01e9;
				case 4:
				case 5:
					break;
					IL_0185:
					string_0 = text;
					awaiter = Class447.smethod_7(gform0_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 3;
						int_0 = 3;
						taskAwaiter_2 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_01e9;
					IL_0080:
					result = awaiter3.GetResult();
					bool_0 = result;
					awaiter3 = gform0_0.smethod_7(27).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_0 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_00ec;
					IL_017c:
					text = awaiter2.GetResult();
					goto IL_0185;
					IL_00ec:
					result2 = awaiter3.GetResult();
					if ((bool_0 || result2) && gform0_0.smethod_4())
					{
						if (result2)
						{
							awaiter2 = gform0_0.smethod_8(41).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 2;
								int_0 = 2;
								taskAwaiter_1 = awaiter2;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_017c;
						}
						text = null;
						goto IL_0185;
					}
					result3 = false;
					goto end_IL_0007;
					IL_01e9:
					result4 = awaiter.GetResult();
					enumerator_0 = result4.GetEnumerator();
					break;
				}
				try
				{
					if (num != 4)
					{
						if (num != 5)
						{
							goto IL_024c;
						}
						awaiter3 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_0365;
					}
					awaiter3 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0373;
					IL_0365:
					if (!awaiter3.GetResult())
					{
						goto IL_024c;
					}
					result3 = true;
					goto end_IL_0007;
					IL_024c:
					if (enumerator_0.MoveNext())
					{
						uint_0 = enumerator_0.Current;
						awaiter3 = Class65.smethod_5(gform0_0, uint_0).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = 4;
							int_0 = 4;
							taskAwaiter_0 = awaiter3;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_0373;
					}
					goto end_IL_0200;
					IL_0373:
					if (!awaiter3.GetResult())
					{
						goto IL_024c;
					}
					Class31 class31_ = Class38.smethod_8(gform0_0.method_5(), string_0, bool_0, gform0_0.method_110(), DateTime.UtcNow);
					if (Class38.smethod_4(gform0_0.method_5(), class31_))
					{
						Class403 class403_ = null;
						IEnumerator<Class403> enumerator = gform0_0.method_5().method_2().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Class403 current = enumerator.Current;
								if (current != null && current.uint_0 == uint_0)
								{
									class403_ = current;
									break;
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								enumerator?.Dispose();
							}
						}
						if (!Class38.smethod_6(class403_, class31_, float_0))
						{
							goto IL_024c;
						}
						awaiter3 = Class412.smethod_11(gform0_0, uint_0).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = 5;
							int_0 = 5;
							taskAwaiter_0 = awaiter3;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_0365;
					}
					end_IL_0200:;
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator_0/*cast due to .constrained prefix*/).Dispose();
					}
				}
				enumerator_0 = default(List<uint>.Enumerator);
				Class412.smethod_14();
				result3 = false;
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

	private static Class119 class119_0;

	private static uint uint_0;

	private static float float_0;

	private static float float_1;

	private static float float_2;

	private static DateTime dateTime_0;

	private static long long_0 = -1000L;

	private static readonly Class441 class441_0 = new Class441();

	internal static async Task<bool> smethod_0(GForm0 gform0_0)
	{
		bool flag = await gform0_0.smethod_7(26);
		bool flag2 = await gform0_0.smethod_7(27);
		if ((!flag && !flag2) || !gform0_0.smethod_4())
		{
			smethod_3();
			return false;
		}
		string text = (flag2 ? (await gform0_0.smethod_8(41)) : null);
		string string_ = text;
		Class31 @class = Class38.smethod_8(gform0_0.method_5(), string_, flag, gform0_0.method_110(), DateTime.UtcNow);
		if (@class == null)
		{
			smethod_3();
			return false;
		}
		DateTime utcNow = DateTime.UtcNow;
		bool flag3 = class441_0.method_0(@class, utcNow);
		float float_ = await gform0_0.smethod_10(1);
		float float_2 = await gform0_0.smethod_11(2);
		Class83 class2 = gform0_0.method_5().method_0();
		if (class2 == null)
		{
			return false;
		}
		if (!Class38.smethod_1(class2.float_0, class2.float_1, class2.float_2, @class.float_0, @class.float_1, @class.float_2, flag3, float_, float_2, out var float_3, out var float_4, out var float_5))
		{
			return flag3;
		}
		Class119 class3 = gform0_0.method_7();
		if (class3 == null)
		{
			return false;
		}
		if (class119_0 != class3 || uint_0 != @class.uint_0 || Class406.smethod_1(float_0, float_1, Class356.float_2, float_3, float_4, float_5) > (@class.bool_0 ? 1f : 0.25f) || (gform0_0.method_5().method_0()?.byte_3 != 1 && (utcNow - dateTime_0).TotalMilliseconds > 1000.0))
		{
			if (!class3.method_177(float_3, float_4, float_5, bool_17: true, "follow_party"))
			{
				return false;
			}
			long long_ = DateTime.UtcNow.Ticks / 10000L;
			if (Class174.smethod_0(long_0, long_))
			{
				long_0 = long_;
			}
			class119_0 = class3;
			uint_0 = @class.uint_0;
			float_0 = float_3;
			float_1 = float_4;
			Class356.float_2 = float_5;
			dateTime_0 = utcNow;
		}
		return true;
	}

	internal static async Task<bool> smethod_1(GForm0 gform0_0, float float_3)
	{
		if (!(await gform0_0.smethod_6(97)))
		{
			return false;
		}
		bool flag = await gform0_0.smethod_7(26);
		bool flag2 = await gform0_0.smethod_7(27);
		if ((!flag && !flag2) || !gform0_0.smethod_4())
		{
			return false;
		}
		string text = (flag2 ? (await gform0_0.smethod_8(41)) : null);
		string string_ = text;
		Class31 @class = Class38.smethod_8(gform0_0.method_5(), string_, flag, gform0_0.method_110(), DateTime.UtcNow);
		if (@class != null && @class.bool_1 && @class.byte_0 == 0)
		{
			if (Class412.smethod_0())
			{
				Class119 class2 = gform0_0.method_7();
				if (class2 != null)
				{
					await class2.method_130().ConfigureAwait(continueOnCapturedContext: false);
				}
				Class412.smethod_14();
			}
			return false;
		}
		uint num = Class38.smethod_7(gform0_0.method_5(), @class, float_3);
		if (num == 0)
		{
			return false;
		}
		return await Class412.smethod_11(gform0_0, num);
	}

	internal static async Task<bool> smethod_2(GForm0 gform0_0, float float_3)
	{
		bool flag = await gform0_0.smethod_7(26);
		bool flag2 = await gform0_0.smethod_7(27);
		if ((!flag && !flag2) || !gform0_0.smethod_4())
		{
			return false;
		}
		string text = (flag2 ? (await gform0_0.smethod_8(41)) : null);
		string string_ = text;
		foreach (uint item in await Class447.smethod_7(gform0_0))
		{
			if (!(await Class65.smethod_5(gform0_0, item)))
			{
				continue;
			}
			Class31 class31_ = Class38.smethod_8(gform0_0.method_5(), string_, flag, gform0_0.method_110(), DateTime.UtcNow);
			if (!Class38.smethod_4(gform0_0.method_5(), class31_))
			{
				break;
			}
			Class403 class403_ = null;
			foreach (Class403 item2 in gform0_0.method_5().method_2())
			{
				if (item2 != null && item2.uint_0 == item)
				{
					class403_ = item2;
					break;
				}
			}
			if (Class38.smethod_6(class403_, class31_, float_3) && await Class412.smethod_11(gform0_0, item))
			{
				return true;
			}
		}
		Class412.smethod_14();
		return false;
	}

	internal static void smethod_3()
	{
		class119_0 = null;
		uint_0 = 0u;
		dateTime_0 = DateTime.MinValue;
		long_0 = -1000L;
		class441_0.method_1();
	}
}
