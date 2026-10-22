using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

internal static class Class360
{
	private sealed class Class361 : IEquatable<Class361>
	{
		internal uint uint_0;

		internal byte byte_0;

		internal ushort ushort_0;

		internal ushort ushort_1;

		internal byte byte_1;

		internal byte byte_2;

		internal static Class361 smethod_0(Class403 class403_0)
		{
			return new Class361
			{
				uint_0 = class403_0.uint_0,
				byte_0 = class403_0.byte_0,
				ushort_0 = class403_0.ushort_0,
				ushort_1 = class403_0.ushort_1,
				byte_1 = class403_0.method_4(),
				byte_2 = class403_0.method_5()
			};
		}

		public bool Equals(Class361 other)
		{
			if (other != null && uint_0 == other.uint_0 && byte_0 == other.byte_0 && ushort_0 == other.ushort_0 && ushort_1 == other.ushort_1 && byte_1 == other.byte_1)
			{
				return byte_2 == other.byte_2;
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Class361);
		}

		public override int GetHashCode()
		{
			return (int)((((((((((uint_0 * 397) ^ byte_0) * 397) ^ ushort_0) * 397) ^ ushort_1) * 397) ^ byte_1) * 397) ^ byte_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct101 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<Enum10> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public float float_0;

		public float float_1;

		public float float_2;

		public string string_0;

		public Class361 class361_0;

		public string string_1;

		public int int_1;

		public Class169 class169_0;

		public Class398 class398_0;

		public float float_3;

		public int int_2;

		public bool bool_0;

		public bool bool_1;

		public bool bool_2;

		public int int_3;

		public IReadOnlyList<string> ireadOnlyList_0;

		private long long_0;

		private int int_4;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Enum10 result;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_01db;
				}
				Class119 @class = gform0_0.method_7();
				if (!smethod_21(@class))
				{
					result = Enum10.SessionChanged;
				}
				else
				{
					if (@class.method_177(float_0, float_1, this.float_2, bool_17: true, string_0))
					{
						smethod_25(class361_0, string_1 + Class185.smethod_0(-1141038098), int_1, (int_1 > 0) ? 5 : 0);
						long_0 = class169_0.func_0();
						int_4 = 0;
						goto IL_00c3;
					}
					result = Enum10.PostFailed;
				}
				goto end_IL_0007;
				IL_00c3:
				if (!gform0_0.method_4())
				{
					if (smethod_21(gform0_0.method_7()))
					{
						if (smethod_9(gform0_0, class361_0, class398_0, this.float_3, int_2, bool_0, bool_1, bool_2, int_3, ireadOnlyList_0, out var _, out var _, out var _, out var _, out var _, out var _))
						{
							if (smethod_6(gform0_0, out var num3, out var _, out var float_3))
							{
								if (smethod_14(num3, float_3, float_0, this.float_2) > 0.25f)
								{
									if (int_4 < 100 && smethod_22(long_0, class169_0.func_0(), class169_0.long_0) < 10000.0)
									{
										int_4++;
										awaiter = class169_0.method_2(100).GetAwaiter();
										if (!awaiter.IsCompleted)
										{
											num = 0;
											int_0 = 0;
											taskAwaiter_0 = awaiter;
											asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											return;
										}
										goto IL_01db;
									}
									result = Enum10.TimedOut;
								}
								else
								{
									result = Enum10.Arrived;
								}
							}
							else
							{
								result = Enum10.TargetUnavailable;
							}
						}
						else
						{
							result = Enum10.TargetUnavailable;
						}
					}
					else
					{
						result = Enum10.SessionChanged;
					}
				}
				else
				{
					result = Enum10.Interrupted;
				}
				goto end_IL_0007;
				IL_01db:
				awaiter.GetResult();
				goto IL_00c3;
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

	private enum Enum10
	{
		Arrived,
		PostFailed,
		TargetUnavailable,
		SessionChanged,
		TimedOut,
		Interrupted
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct102 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public float float_0;

		private Class398 class398_0;

		private int int_1;

		private int int_2;

		private bool bool_0;

		private bool bool_1;

		private bool bool_2;

		private IReadOnlyList<string> ireadOnlyList_0;

		private Class169 class169_0;

		private long long_0;

		private Class361 class361_0;

		private TaskAwaiter<int> taskAwaiter_0;

		private TaskAwaiter<List<int>> taskAwaiter_1;

		private TaskAwaiter<bool> taskAwaiter_2;

		private TaskAwaiter<IReadOnlyList<string>> taskAwaiter_3;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private int int_3;

		private TaskAwaiter<Enum10> taskAwaiter_4;

		private void MoveNext()
		{
			int num = int_0;
			bool result2;
			try
			{
				TaskAwaiter<List<int>> awaiter6;
				TaskAwaiter<int> awaiter5;
				TaskAwaiter<bool> awaiter4;
				TaskAwaiter<IReadOnlyList<string>> awaiter3;
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2;
				TaskAwaiter<Enum10> awaiter;
				IReadOnlyList<string> result;
				Class119 @class;
				long num2;
				int result3;
				float float_;
				float float_2;
				float float_3;
				byte byte_;
				byte byte_2;
				string string_;
				float float_4;
				float float_5;
				float float_6;
				int result4;
				Enum10 result5;
				float num3;
				List<int> result6;
				bool result7;
				Enum10 result8;
				switch (num)
				{
				default:
					awaiter5 = gform0_0.smethod_12(new int[6] { 1, 2, 3, 4, 5, 26 }).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter5;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
						return;
					}
					goto IL_00a2;
				case 0:
					awaiter5 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<int>);
					num = -1;
					int_0 = -1;
					goto IL_00a2;
				case 1:
					awaiter6 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<List<int>>);
					num = -1;
					int_0 = -1;
					goto IL_0139;
				case 2:
					awaiter5 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<int>);
					num = -1;
					int_0 = -1;
					goto IL_0244;
				case 3:
					awaiter4 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_02b0;
				case 4:
					awaiter4 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_031c;
				case 5:
					awaiter4 = taskAwaiter_2;
					taskAwaiter_2 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0388;
				case 6:
					awaiter3 = taskAwaiter_3;
					taskAwaiter_3 = default(TaskAwaiter<IReadOnlyList<string>>);
					num = -1;
					int_0 = -1;
					goto IL_03f5;
				case 7:
					awaiter2 = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_06a3;
				case 8:
					awaiter = taskAwaiter_4;
					taskAwaiter_4 = default(TaskAwaiter<Enum10>);
					num = -1;
					int_0 = -1;
					goto IL_085b;
				case 9:
					{
						awaiter = taskAwaiter_4;
						taskAwaiter_4 = default(TaskAwaiter<Enum10>);
						num = -1;
						int_0 = -1;
						goto IL_0a63;
					}
					IL_03f5:
					result = awaiter3.GetResult();
					ireadOnlyList_0 = result;
					@class = gform0_0.method_7();
					num2 = @class?.method_22() ?? 0L;
					if (@class != class119_0 || num2 != long_1)
					{
						smethod_20(bool_5: true);
						class119_0 = @class;
						long_1 = num2;
					}
					if (@class == null)
					{
						result2 = false;
					}
					else
					{
						class169_0 = Class169.smethod_0();
						if (!class169_0.method_0(@class))
						{
							smethod_19();
							result2 = false;
						}
						else
						{
							long_0 = class169_0.func_0();
							smethod_24(long_0);
							if (Class360.bool_0 && class362_0 != null && smethod_10(gform0_0, Class360.class361_0, class398_0, float_0, int_2, bool_0, bool_1, bool_2, int_1, ireadOnlyList_0))
							{
								class361_0 = Class360.class361_0;
								goto IL_054b;
							}
							if (smethod_2(gform0_0, class398_0, float_0, int_2, bool_0, bool_1, bool_2, int_1, ireadOnlyList_0, out class361_0))
							{
								goto IL_054b;
							}
							smethod_19();
							result2 = false;
						}
					}
					goto end_IL_0007;
					IL_00a2:
					result3 = awaiter5.GetResult();
					class398_0 = Class412.smethod_1();
					if ((result3 != 4 && result3 != 5) || class398_0.bool_0)
					{
						awaiter6 = Class104.smethod_0(gform0_0, 29, 33).GetAwaiter();
						if (!awaiter6.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter6;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
							return;
						}
						goto IL_0139;
					}
					smethod_19();
					result2 = false;
					goto end_IL_0007;
					IL_08f9:
					if (smethod_9(gform0_0, class361_0, class398_0, float_0, int_2, bool_0, bool_1, bool_2, int_1, ireadOnlyList_0, out float_, out float_2, out float_3, out byte_, out byte_2, out string_) && smethod_6(gform0_0, out float_4, out float_5, out float_6))
					{
						int_3 = Class360.int_0 - 5 + 1;
						smethod_12(class169_0, int_3, float_, float_3, float_4, float_6, out var float_7, out var float_8);
						awaiter = smethod_11(gform0_0, class361_0, float_7, float_2, float_8, Class185.smethod_0(-1141039008) + int_3, Class185.smethod_0(-1141039018), int_3, class398_0, float_0, int_2, bool_0, bool_1, bool_2, int_1, ireadOnlyList_0, class169_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 9;
							int_0 = 9;
							taskAwaiter_4 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0a63;
					}
					smethod_19();
					result2 = true;
					goto end_IL_0007;
					IL_06a3:
					awaiter2.GetResult();
					goto IL_06aa;
					IL_0244:
					result4 = awaiter5.GetResult();
					int_2 = result4;
					awaiter4 = gform0_0.smethod_6(94).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = 3;
						int_0 = 3;
						taskAwaiter_2 = awaiter4;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
						return;
					}
					goto IL_02b0;
					IL_0a63:
					result5 = awaiter.GetResult();
					if (result5 != Enum10.Arrived)
					{
						smethod_26(class361_0, Class185.smethod_0(-1141039046) + int_3, result5, int_3);
						if (result5 == Enum10.TimedOut)
						{
							smethod_23(class361_0, class169_0.func_0(), class169_0.long_0);
							smethod_25(class361_0, Class185.smethod_0(-1141038927), 60, 0);
						}
						if (result5 == Enum10.SessionChanged)
						{
							smethod_20(bool_5: true);
						}
						else
						{
							smethod_19();
						}
						result2 = true;
					}
					else
					{
						smethod_25(class361_0, Class185.smethod_0(-1141039059), int_3, 5);
						if (smethod_9(gform0_0, class361_0, class398_0, float_0, int_2, bool_0, bool_1, bool_2, int_1, ireadOnlyList_0, out float_, out float_2, out float_3, out byte_, out byte_2, out string_))
						{
							num3 = 0f;
							break;
						}
						smethod_19();
						result2 = true;
					}
					goto end_IL_0007;
					IL_061c:
					if (!Class360.bool_1 && Class412.smethod_0())
					{
						Class119 class2 = gform0_0.method_7();
						if (class2 != null)
						{
							awaiter2 = class2.method_130().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 7;
								int_0 = 7;
								configuredTaskAwaiter_0 = awaiter2;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_06a3;
						}
						goto IL_06aa;
					}
					goto IL_06b5;
					IL_0139:
					result6 = awaiter6.GetResult();
					int_1 = 0;
					if (result6.Contains(29))
					{
						int_1 |= smethod_0(1);
					}
					if (result6.Contains(30))
					{
						int_1 |= smethod_0(2);
					}
					if (result6.Contains(31))
					{
						int_1 |= smethod_0(3);
					}
					if (result6.Contains(32))
					{
						int_1 |= smethod_0(4);
					}
					if (result6.Contains(33))
					{
						int_1 |= smethod_0(6);
					}
					awaiter5 = gform0_0.smethod_12(new int[5] { 18, 19, 20, 21, 22 }).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						num = 2;
						int_0 = 2;
						taskAwaiter_0 = awaiter5;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
						return;
					}
					goto IL_0244;
					IL_06aa:
					Class412.smethod_14();
					Class360.bool_1 = true;
					goto IL_06b5;
					IL_02b0:
					result7 = awaiter4.GetResult();
					bool_0 = result7;
					awaiter4 = gform0_0.smethod_6(38).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = 4;
						int_0 = 4;
						taskAwaiter_2 = awaiter4;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
						return;
					}
					goto IL_031c;
					IL_06b5:
					class169_0.method_1();
					if (smethod_6(gform0_0, out float_4, out float_5, out float_6) && smethod_8(gform0_0, class361_0, out float_, out float_2, out float_3, out byte_, out byte_2, out string_))
					{
						num3 = Class406.smethod_1(float_4, float_5, float_6, float_, float_2, float_3);
						if (Class360.int_0 >= 5)
						{
							if (!Class360.bool_2)
							{
								awaiter = smethod_11(gform0_0, class361_0, float_, float_2, float_3, Class185.smethod_0(-1141038943), Class185.smethod_0(-1141038966), 0, class398_0, float_0, int_2, bool_0, bool_1, bool_2, int_1, ireadOnlyList_0, class169_0).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 8;
									int_0 = 8;
									taskAwaiter_4 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_085b;
							}
							goto IL_08f9;
						}
						if (!(num3 > 10f))
						{
							break;
						}
						Class119 class3 = gform0_0.method_7();
						if (!smethod_21(class3))
						{
							smethod_20(bool_5: true);
							result2 = false;
						}
						else
						{
							smethod_16(gform0_0, class361_0, num3, Class185.smethod_0(-1141254478));
							if (!class3.method_177(float_, float_2, float_3, bool_17: true, Class185.smethod_0(-1141308140)))
							{
								smethod_19();
								result2 = false;
							}
							else
							{
								result2 = true;
							}
						}
					}
					else
					{
						smethod_19();
						result2 = false;
					}
					goto end_IL_0007;
					IL_031c:
					result7 = awaiter4.GetResult();
					bool_1 = result7;
					awaiter4 = gform0_0.smethod_6(43).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = 5;
						int_0 = 5;
						taskAwaiter_2 = awaiter4;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
						return;
					}
					goto IL_0388;
					IL_054b:
					smethod_17(class361_0);
					if (!smethod_18(gform0_0, class361_0, @class, long_0, class169_0.long_0))
					{
						result2 = true;
					}
					else
					{
						if (Class360.int_0 < 10)
						{
							goto IL_061c;
						}
						smethod_23(class361_0, long_0, class169_0.long_0);
						smethod_25(class361_0, Class185.smethod_0(-1141038927), 60, 0);
						smethod_19();
						if (smethod_2(gform0_0, class398_0, float_0, int_2, bool_0, bool_1, bool_2, int_1, ireadOnlyList_0, out class361_0))
						{
							smethod_17(class361_0);
							goto IL_061c;
						}
						result2 = false;
					}
					goto end_IL_0007;
					IL_0388:
					result7 = awaiter4.GetResult();
					bool_2 = result7;
					awaiter3 = gform0_0.smethod_15().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 6;
						int_0 = 6;
						taskAwaiter_3 = awaiter3;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_03f5;
					IL_085b:
					result8 = awaiter.GetResult();
					if (result8 == Enum10.Arrived)
					{
						Class360.bool_2 = true;
						smethod_25(class361_0, Class185.smethod_0(-1141038983), 0, 0);
						goto IL_08f9;
					}
					smethod_26(class361_0, Class185.smethod_0(-1141038966), result8, 0);
					if (result8 == Enum10.TimedOut)
					{
						smethod_23(class361_0, class169_0.func_0(), class169_0.long_0);
						smethod_25(class361_0, Class185.smethod_0(-1141038927), 60, 0);
					}
					if (result8 == Enum10.SessionChanged)
					{
						smethod_20(bool_5: true);
					}
					else
					{
						smethod_19();
					}
					result2 = true;
					goto end_IL_0007;
				}
				if (Class360.int_0 < 5 && bool_4 && smethod_22(Class360.long_0, long_0, class169_0.long_0) < 400.0)
				{
					smethod_16(gform0_0, class361_0, num3, Class185.smethod_0(-1141039095));
					result2 = true;
				}
				else
				{
					Class119 class4 = gform0_0.method_7();
					if (!smethod_21(class4))
					{
						smethod_20(bool_5: true);
						result2 = false;
					}
					else
					{
						int num4 = (Class360.bool_2 ? (Class360.int_0 - 5 + 1) : (Class360.int_0 + 1));
						string text = (Class360.bool_2 ? Class185.smethod_0(-1141038086) : Class185.smethod_0(-1141259041));
						if (Class360.bool_2)
						{
							smethod_25(class361_0, Class185.smethod_0(-1141038086), num4, 5);
						}
						smethod_16(gform0_0, class361_0, num3, text + Class185.smethod_0(-1141293701) + num4 + Class185.smethod_0(-1141300031) + 5);
						uint num5 = class4.method_141();
						Class362 class5 = (class362_0 = new Class362
						{
							class361_0 = class361_0,
							byte_0 = byte_,
							uint_0 = num5,
							long_0 = class4.method_21()
						});
						if (!class4.method_143(byte_, class361_0.uint_0, num5))
						{
							smethod_19();
							result2 = false;
						}
						else
						{
							long num6 = (class5.long_1 = class169_0.func_0());
							class5.int_0 = gform0_0.method_5().method_89();
							Volatile.Write(ref class5.int_1, 1);
							Class360.long_0 = num6;
							bool_4 = true;
							result2 = true;
						}
					}
				}
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class398_0 = null;
				ireadOnlyList_0 = null;
				class169_0 = null;
				class361_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class398_0 = null;
			ireadOnlyList_0 = null;
			class169_0 = null;
			class361_0 = null;
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

	private sealed class Class362
	{
		internal Class361 class361_0;

		internal byte byte_0;

		internal uint uint_0;

		internal long long_0;

		internal int int_0;

		internal long long_1;

		internal int int_1;

		internal bool bool_0;
	}

	private static Class361 class361_0;

	private static bool bool_0;

	private static bool bool_1;

	private static int int_0;

	private static bool bool_2;

	private static bool bool_3;

	private static float float_0;

	private static float float_1;

	private static long long_0;

	private static bool bool_4;

	private static Class362 class362_0;

	private static Class119 class119_0;

	private static long long_1;

	private static readonly Dictionary<Class361, long> dictionary_0 = new Dictionary<Class361, long>();

	private static readonly Class172.Class173 class173_0 = new Class172.Class173();

	internal static int smethod_0(byte byte_0)
	{
		if (byte_0 > 15)
		{
			return 0;
		}
		return 1 << (int)byte_0;
	}

	internal static async Task<bool> smethod_1(GForm0 gform0_0, float float_2)
	{
		int num = await gform0_0.smethod_12(new int[6] { 1, 2, 3, 4, 5, 26 });
		Class398 @class = Class412.smethod_1();
		if ((num == 4 || num == 5) && !@class.bool_0)
		{
			smethod_19();
			return false;
		}
		List<int> obj = await Class104.smethod_0(gform0_0, 29, 33);
		int num2 = 0;
		if (obj.Contains(29))
		{
			num2 |= smethod_0(1);
		}
		if (obj.Contains(30))
		{
			num2 |= smethod_0(2);
		}
		if (obj.Contains(31))
		{
			num2 |= smethod_0(3);
		}
		if (obj.Contains(32))
		{
			num2 |= smethod_0(4);
		}
		if (obj.Contains(33))
		{
			num2 |= smethod_0(6);
		}
		int num3 = await gform0_0.smethod_12(new int[5] { 18, 19, 20, 21, 22 });
		bool bool_ = await gform0_0.smethod_6(94);
		bool bool_2 = await gform0_0.smethod_6(38);
		bool bool_3 = await gform0_0.smethod_6(43);
		IReadOnlyList<string> ireadOnlyList_ = await gform0_0.smethod_15();
		Class119 class2 = gform0_0.method_7();
		long num4 = class2?.method_22() ?? 0L;
		if (class2 != class119_0 || num4 != long_1)
		{
			smethod_20(bool_5: true);
			class119_0 = class2;
			long_1 = num4;
		}
		if (class2 == null)
		{
			return false;
		}
		Class169 class3 = Class169.smethod_0();
		if (!class3.method_0(class2))
		{
			smethod_19();
			return false;
		}
		long num5 = class3.func_0();
		smethod_24(num5);
		Class361 class361_;
		if (bool_0 && class362_0 != null && smethod_10(gform0_0, class361_0, @class, float_2, num3, bool_, bool_2, bool_3, num2, ireadOnlyList_))
		{
			class361_ = class361_0;
		}
		else if (!smethod_2(gform0_0, @class, float_2, num3, bool_, bool_2, bool_3, num2, ireadOnlyList_, out class361_))
		{
			smethod_19();
			return false;
		}
		smethod_17(class361_);
		if (!smethod_18(gform0_0, class361_, class2, num5, class3.long_0))
		{
			return true;
		}
		if (int_0 >= 10)
		{
			smethod_23(class361_, num5, class3.long_0);
			smethod_25(class361_, Class185.smethod_0(-1141038927), 60, 0);
			smethod_19();
			if (!smethod_2(gform0_0, @class, float_2, num3, bool_, bool_2, bool_3, num2, ireadOnlyList_, out class361_))
			{
				return false;
			}
			smethod_17(class361_);
		}
		if (!bool_1 && Class412.smethod_0())
		{
			Class119 class4 = gform0_0.method_7();
			if (class4 != null)
			{
				await class4.method_130().ConfigureAwait(continueOnCapturedContext: false);
			}
			Class412.smethod_14();
			bool_1 = true;
		}
		class3.method_1();
		if (smethod_6(gform0_0, out var float_3, out var float_4, out var float_5) && smethod_8(gform0_0, class361_, out var float_6, out var float_7, out var float_8, out var byte_, out var byte_2, out var string_))
		{
			float num6 = Class406.smethod_1(float_3, float_4, float_5, float_6, float_7, float_8);
			if (int_0 >= 5)
			{
				if (!Class360.bool_2)
				{
					Enum10 @enum = await smethod_11(gform0_0, class361_, float_6, float_7, float_8, Class185.smethod_0(-1141038943), Class185.smethod_0(-1141038966), 0, @class, float_2, num3, bool_, bool_2, bool_3, num2, ireadOnlyList_, class3);
					if (@enum != Enum10.Arrived)
					{
						smethod_26(class361_, Class185.smethod_0(-1141038966), @enum, 0);
						if (@enum == Enum10.TimedOut)
						{
							smethod_23(class361_, class3.func_0(), class3.long_0);
							smethod_25(class361_, Class185.smethod_0(-1141038927), 60, 0);
						}
						if (@enum == Enum10.SessionChanged)
						{
							smethod_20(bool_5: true);
						}
						else
						{
							smethod_19();
						}
						return true;
					}
					Class360.bool_2 = true;
					smethod_25(class361_, Class185.smethod_0(-1141038983), 0, 0);
				}
				if (!smethod_9(gform0_0, class361_, @class, float_2, num3, bool_, bool_2, bool_3, num2, ireadOnlyList_, out float_6, out float_7, out float_8, out byte_, out byte_2, out string_) || !smethod_6(gform0_0, out float_3, out float_4, out float_5))
				{
					smethod_19();
					return true;
				}
				int int_ = int_0 - 5 + 1;
				smethod_12(class3, int_, float_6, float_8, float_3, float_5, out var float_9, out var float_10);
				Enum10 enum2 = await smethod_11(gform0_0, class361_, float_9, float_7, float_10, Class185.smethod_0(-1141039008) + int_, Class185.smethod_0(-1141039018), int_, @class, float_2, num3, bool_, bool_2, bool_3, num2, ireadOnlyList_, class3);
				if (enum2 != Enum10.Arrived)
				{
					smethod_26(class361_, Class185.smethod_0(-1141039046) + int_, enum2, int_);
					if (enum2 == Enum10.TimedOut)
					{
						smethod_23(class361_, class3.func_0(), class3.long_0);
						smethod_25(class361_, Class185.smethod_0(-1141038927), 60, 0);
					}
					if (enum2 == Enum10.SessionChanged)
					{
						smethod_20(bool_5: true);
					}
					else
					{
						smethod_19();
					}
					return true;
				}
				smethod_25(class361_, Class185.smethod_0(-1141039059), int_, 5);
				if (!smethod_9(gform0_0, class361_, @class, float_2, num3, bool_, bool_2, bool_3, num2, ireadOnlyList_, out float_6, out float_7, out float_8, out byte_, out byte_2, out string_))
				{
					smethod_19();
					return true;
				}
				num6 = 0f;
			}
			else if (num6 > 10f)
			{
				Class119 class5 = gform0_0.method_7();
				if (!smethod_21(class5))
				{
					smethod_20(bool_5: true);
					return false;
				}
				smethod_16(gform0_0, class361_, num6, Class185.smethod_0(-1141254478));
				if (!class5.method_177(float_6, float_7, float_8, bool_17: true, Class185.smethod_0(-1141308140)))
				{
					smethod_19();
					return false;
				}
				return true;
			}
			if (int_0 < 5 && bool_4 && smethod_22(long_0, num5, class3.long_0) < 400.0)
			{
				smethod_16(gform0_0, class361_, num6, Class185.smethod_0(-1141039095));
				return true;
			}
			Class119 class6 = gform0_0.method_7();
			if (!smethod_21(class6))
			{
				smethod_20(bool_5: true);
				return false;
			}
			int int_2 = (Class360.bool_2 ? (int_0 - 5 + 1) : (int_0 + 1));
			string text = (Class360.bool_2 ? Class185.smethod_0(-1141038086) : Class185.smethod_0(-1141259041));
			if (Class360.bool_2)
			{
				smethod_25(class361_, Class185.smethod_0(-1141038086), int_2, 5);
			}
			smethod_16(gform0_0, class361_, num6, text + Class185.smethod_0(-1141293701) + int_2 + Class185.smethod_0(-1141300031) + 5);
			uint num7 = class6.method_141();
			Class362 class7 = (class362_0 = new Class362
			{
				class361_0 = class361_,
				byte_0 = byte_,
				uint_0 = num7,
				long_0 = class6.method_21()
			});
			if (!class6.method_143(byte_, class361_.uint_0, num7))
			{
				smethod_19();
				return false;
			}
			long num8 = (class7.long_1 = class3.func_0());
			class7.int_0 = gform0_0.method_5().method_89();
			Volatile.Write(ref class7.int_1, 1);
			long_0 = num8;
			bool_4 = true;
			return true;
		}
		smethod_19();
		return false;
	}

	private static bool smethod_2(GForm0 gform0_0, Class398 class398_0, float float_2, int int_1, bool bool_5, bool bool_6, bool bool_7, int int_2, IReadOnlyList<string> ireadOnlyList_0, out Class361 class361_1)
	{
		class361_1 = null;
		if (int_1 != 22 && int_1 >= 0 && smethod_7(gform0_0, out var float_3, out var float_4, out var float_5, out var byte_))
		{
			float float_6 = (class398_0.bool_0 ? class398_0.float_0 : float_3);
			float float_7 = (class398_0.bool_0 ? class398_0.float_1 : float_4);
			float float_8 = (class398_0.bool_0 ? class398_0.float_2 : float_5);
			if (bool_7 && smethod_3(gform0_0, float_6, float_7, float_8, float_2 - 10f))
			{
				return false;
			}
			bool bool_8 = false;
			float float_9 = float.MaxValue;
			smethod_4(gform0_0, gform0_0.method_5().method_6(), class398_0, float_2, int_1, bool_5, bool_6, int_2, ireadOnlyList_0, byte_, float_3, float_4, float_5, ref bool_8, ref class361_1, ref float_9);
			smethod_4(gform0_0, gform0_0.method_5().method_8(), class398_0, float_2, int_1, bool_5, bool_6, int_2, ireadOnlyList_0, byte_, float_3, float_4, float_5, ref bool_8, ref class361_1, ref float_9);
			return bool_8;
		}
		return false;
	}

	private static bool smethod_3(GForm0 gform0_0, float float_2, float float_3, float float_4, float float_5)
	{
		IReadOnlyList<Class403> readOnlyList = gform0_0.method_5().method_2();
		if (readOnlyList == null)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < readOnlyList.Count)
			{
				Class403 @class = readOnlyList[num];
				if (@class != null && !@class.method_0() && Class406.smethod_3(@class.float_0, @class.float_1, @class.float_2, float_2, float_3, float_4, float_5))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static void smethod_4(GForm0 gform0_0, IReadOnlyList<Class403> ireadOnlyList_0, Class398 class398_0, float float_2, int int_1, bool bool_5, bool bool_6, int int_2, IReadOnlyList<string> ireadOnlyList_1, byte byte_0, float float_3, float float_4, float float_5, ref bool bool_7, ref Class361 class361_1, ref float float_6)
	{
		if (ireadOnlyList_0 == null)
		{
			return;
		}
		for (int i = 0; i < ireadOnlyList_0.Count; i++)
		{
			Class403 @class = ireadOnlyList_0[i];
			if (@class == null || @class.method_0())
			{
				continue;
			}
			float num = Class406.smethod_1(float_3, float_4, float_5, @class.float_0, @class.float_1, @class.float_2);
			if (class398_0.bool_0)
			{
				if (!Class406.smethod_3(@class.float_0, @class.float_1, @class.float_2, class398_0.float_0, class398_0.float_1, class398_0.float_2, float_2))
				{
					continue;
				}
			}
			else if (num > float_2)
			{
				continue;
			}
			if (smethod_5(gform0_0, @class, int_1, bool_5, bool_6, int_2, ireadOnlyList_1, byte_0))
			{
				Class361 class2 = Class361.smethod_0(@class);
				if (!dictionary_0.ContainsKey(class2) && num < float_6)
				{
					float_6 = num;
					class361_1 = class2;
					bool_7 = true;
				}
			}
		}
	}

	private static bool smethod_5(GForm0 gform0_0, Class403 class403_0, int int_1, bool bool_5, bool bool_6, int int_2, IReadOnlyList<string> ireadOnlyList_0, byte byte_0)
	{
		bool flag = class403_0.byte_0 == 102;
		bool flag2 = class403_0.byte_0 == 101 && class403_0.method_4() == 16;
		string string_ = (flag ? null : Class447.smethod_5(gform0_0, class403_0.ushort_0, class403_0.ushort_1));
		if (bool_5 && flag)
		{
			return false;
		}
		if (bool_6 && flag2)
		{
			return false;
		}
		if (flag2 && (int_2 & smethod_0(class403_0.method_5())) != 0)
		{
			return false;
		}
		if (flag2 && byte_0 != 0 && (int_2 & smethod_0(byte_0)) != 0)
		{
			return false;
		}
		switch (int_1)
		{
		default:
			return true;
		case 19:
			return flag;
		case 20:
			if (!(flag || flag2))
			{
				return smethod_31(ireadOnlyList_0, string_);
			}
			return true;
		case 21:
			if (!(flag || flag2))
			{
				return !smethod_31(ireadOnlyList_0, string_);
			}
			return true;
		}
	}

	private static bool smethod_6(GForm0 gform0_0, out float float_2, out float float_3, out float float_4)
	{
		float num = 0f;
		float_4 = 0f;
		float num2 = num;
		num = 0f;
		float_3 = num2;
		float_2 = num;
		Class83 @class = gform0_0.method_5().method_0();
		if (@class == null)
		{
			return false;
		}
		float_2 = @class.float_0;
		float_3 = @class.float_1;
		float_4 = @class.float_2;
		return true;
	}

	private static bool smethod_7(GForm0 gform0_0, out float float_2, out float float_3, out float float_4, out byte byte_0)
	{
		float num = 0f;
		float_4 = 0f;
		float num2 = num;
		num = 0f;
		float_3 = num2;
		float_2 = num;
		byte_0 = 0;
		Class83 @class = gform0_0.method_5().method_0();
		if (@class == null)
		{
			return false;
		}
		float_2 = @class.float_0;
		float_3 = @class.float_1;
		float_4 = @class.float_2;
		byte_0 = @class.byte_5;
		return true;
	}

	private static bool smethod_8(GForm0 gform0_0, Class361 class361_1, out float float_2, out float float_3, out float float_4, out byte byte_0, out byte byte_1, out string string_0)
	{
		float num = 0f;
		float_4 = 0f;
		float num2 = num;
		num = 0f;
		float_3 = num2;
		float_2 = num;
		byte_0 = 0;
		byte_1 = 0;
		string_0 = Class185.smethod_0(-1141293701);
		IReadOnlyList<Class403> ireadOnlyList_ = gform0_0.method_5().method_6();
		if (smethod_15(gform0_0, ireadOnlyList_, class361_1, out float_2, out float_3, out float_4, out byte_0, out byte_1, out string_0))
		{
			return true;
		}
		ireadOnlyList_ = gform0_0.method_5().method_8();
		return smethod_15(gform0_0, ireadOnlyList_, class361_1, out float_2, out float_3, out float_4, out byte_0, out byte_1, out string_0);
	}

	private static bool smethod_9(GForm0 gform0_0, Class361 class361_1, Class398 class398_0, float float_2, int int_1, bool bool_5, bool bool_6, bool bool_7, int int_2, IReadOnlyList<string> ireadOnlyList_0, out float float_3, out float float_4, out float float_5, out byte byte_0, out byte byte_1, out string string_0)
	{
		float num = 0f;
		float_5 = 0f;
		float num2 = num;
		num = 0f;
		float_4 = num2;
		float_3 = num;
		byte_1 = 0;
		byte_0 = 0;
		string_0 = Class185.smethod_0(-1141293701);
		if (!smethod_7(gform0_0, out var float_6, out var float_7, out var float_8, out var byte_2))
		{
			return false;
		}
		if (bool_7)
		{
			float float_9 = (class398_0.bool_0 ? class398_0.float_0 : float_6);
			float float_10 = (class398_0.bool_0 ? class398_0.float_1 : float_7);
			float float_11 = (class398_0.bool_0 ? class398_0.float_2 : float_8);
			if (smethod_3(gform0_0, float_9, float_10, float_11, float_2 - 10f))
			{
				return false;
			}
		}
		if (!smethod_8(gform0_0, class361_1, out float_3, out float_4, out float_5, out byte_0, out byte_1, out string_0))
		{
			return false;
		}
		if (class398_0.bool_0)
		{
			if (!Class406.smethod_3(float_3, float_4, float_5, class398_0.float_0, class398_0.float_1, class398_0.float_2, float_2))
			{
				return false;
			}
		}
		else if (Class406.smethod_1(float_6, float_7, float_8, float_3, float_4, float_5) > float_2)
		{
			return false;
		}
		bool flag = class361_1.byte_0 == 102;
		bool flag2 = class361_1.byte_0 == 101 && class361_1.byte_1 == 16;
		if (bool_5 && flag)
		{
			return false;
		}
		if (bool_6 && flag2)
		{
			return false;
		}
		if (flag2 && (int_2 & smethod_0(class361_1.byte_2)) != 0)
		{
			return false;
		}
		if (flag2 && byte_2 != 0 && (int_2 & smethod_0(byte_2)) != 0)
		{
			return false;
		}
		switch (int_1)
		{
		default:
			return int_1 >= 0;
		case 22:
			return false;
		case 19:
			return flag;
		case 20:
			if (!(flag || flag2))
			{
				return smethod_31(ireadOnlyList_0, string_0);
			}
			return true;
		case 21:
			if (!(flag || flag2))
			{
				return !smethod_31(ireadOnlyList_0, string_0);
			}
			return true;
		}
	}

	private static bool smethod_10(GForm0 gform0_0, Class361 class361_1, Class398 class398_0, float float_2, int int_1, bool bool_5, bool bool_6, bool bool_7, int int_2, IReadOnlyList<string> ireadOnlyList_0)
	{
		float float_3;
		float float_4;
		float float_5;
		byte byte_;
		byte byte_2;
		string string_;
		return smethod_9(gform0_0, class361_1, class398_0, float_2, int_1, bool_5, bool_6, bool_7, int_2, ireadOnlyList_0, out float_3, out float_4, out float_5, out byte_, out byte_2, out string_);
	}

	private static async Task<Enum10> smethod_11(GForm0 gform0_0, Class361 class361_1, float float_2, float float_3, float float_4, string string_0, string string_1, int int_1, Class398 class398_0, float float_5, int int_2, bool bool_5, bool bool_6, bool bool_7, int int_3, IReadOnlyList<string> ireadOnlyList_0, Class169 class169_0)
	{
		Class119 @class = gform0_0.method_7();
		if (!smethod_21(@class))
		{
			return Enum10.SessionChanged;
		}
		if (!@class.method_177(float_2, float_3, float_4, bool_17: true, string_0))
		{
			return Enum10.PostFailed;
		}
		smethod_25(class361_1, string_1 + Class185.smethod_0(-1141038098), int_1, (int_1 > 0) ? 5 : 0);
		long long_ = class169_0.func_0();
		int num = 0;
		while (true)
		{
			if (!gform0_0.method_4())
			{
				if (smethod_21(gform0_0.method_7()))
				{
					if (smethod_9(gform0_0, class361_1, class398_0, float_5, int_2, bool_5, bool_6, bool_7, int_3, ireadOnlyList_0, out var _, out var _, out var _, out var _, out var _, out var _))
					{
						if (smethod_6(gform0_0, out var float_9, out var _, out var float_11))
						{
							if (smethod_14(float_9, float_11, float_2, float_4) > 0.25f)
							{
								if (num >= 100 || !(smethod_22(long_, class169_0.func_0(), class169_0.long_0) < 10000.0))
								{
									break;
								}
								num++;
								await class169_0.method_2(100);
								continue;
							}
							return Enum10.Arrived;
						}
						return Enum10.TargetUnavailable;
					}
					return Enum10.TargetUnavailable;
				}
				return Enum10.SessionChanged;
			}
			return Enum10.Interrupted;
		}
		return Enum10.TimedOut;
	}

	private static void smethod_12(Class169 class169_0, int int_1, float float_2, float float_3, float float_4, float float_5, out float float_6, out float float_7)
	{
		float num = 0f;
		float num2 = 0f;
		bool flag = false;
		for (int i = 0; i < 8; i++)
		{
			num = smethod_13(class169_0);
			num2 = smethod_13(class169_0);
			float float_8 = float_2 + num;
			float float_9 = float_3 + num2;
			if (!((bool_3 && Math.Abs(num - float_0) < 1E-06f && Math.Abs(num2 - float_1) < 1E-06f) | (smethod_14(float_4, float_5, float_8, float_9) <= 0.25f)))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			for (int j = 0; j < 4; j++)
			{
				int num3 = (int_1 - 1 + j) & 3;
				num = ((num3 < 2) ? (-1f) : 1f);
				num2 = (((num3 & 1) == 0) ? (-1f) : 1f);
				if (!((bool_3 && num == float_0 && num2 == float_1) | (smethod_14(float_4, float_5, float_2 + num, float_3 + num2) <= 0.25f)))
				{
					flag = true;
					break;
				}
			}
		}
		float_0 = num;
		float_1 = num2;
		bool_3 = true;
		float_6 = float_2 + num;
		float_7 = float_3 + num2;
	}

	private static float smethod_13(Class169 class169_0)
	{
		int num = class169_0.method_3(0, 2000001);
		if (num < 0)
		{
			num = 0;
		}
		if (num > 2000000)
		{
			num = 2000000;
		}
		return (float)num / 1000000f - 1f;
	}

	private static float smethod_14(float float_2, float float_3, float float_4, float float_5)
	{
		float num = float_4 - float_2;
		float num2 = float_5 - float_3;
		return (float)Math.Sqrt(num * num + num2 * num2);
	}

	private static bool smethod_15(GForm0 gform0_0, IReadOnlyList<Class403> ireadOnlyList_0, Class361 class361_1, out float float_2, out float float_3, out float float_4, out byte byte_0, out byte byte_1, out string string_0)
	{
		float num = 0f;
		float_4 = 0f;
		float num2 = num;
		num = 0f;
		float_3 = num2;
		float_2 = num;
		byte_0 = 0;
		byte_1 = 0;
		string_0 = Class185.smethod_0(-1141293701);
		if (ireadOnlyList_0 == null)
		{
			return false;
		}
		int num3 = 0;
		Class403 @class;
		while (true)
		{
			if (num3 < ireadOnlyList_0.Count)
			{
				@class = ireadOnlyList_0[num3];
				if (@class != null && !@class.method_0() && Class361.smethod_0(@class).Equals(class361_1))
				{
					break;
				}
				num3++;
				continue;
			}
			return false;
		}
		float_2 = @class.float_0;
		float_3 = @class.float_1;
		float_4 = @class.float_2;
		byte_1 = @class.byte_0;
		string_0 = ((byte_1 == 102) ? Class185.smethod_0(-1141038118) : (Class447.smethod_5(gform0_0, @class.ushort_0, @class.ushort_1) ?? Class185.smethod_0(-1141293701)));
		byte_0 = (byte)((@class.byte_0 == 102) ? 4u : 3u);
		return true;
	}

	private static void smethod_16(GForm0 gform0_0, Class361 class361_1, float float_2, string string_0)
	{
		if (Class172.bool_0)
		{
			string string_1 = class361_1.uint_0 + Class185.smethod_0(-1141297577) + string_0;
			if (class173_0.method_0(string_1, bool_0: false, DateTime.UtcNow) && smethod_6(gform0_0, out var float_3, out var _, out var float_5) && smethod_8(gform0_0, class361_1, out var float_6, out var _, out var float_8, out var _, out var _, out var _))
			{
				float num = float_6 - float_3;
				float num2 = float_8 - float_5;
				Math.Sqrt(num * num + num2 * num2);
			}
		}
	}

	private static void smethod_17(Class361 class361_1)
	{
		if (!bool_0 || !class361_0.Equals(class361_1))
		{
			smethod_19();
			class361_0 = class361_1;
			bool_0 = true;
		}
	}

	private static bool smethod_18(GForm0 gform0_0, Class361 class361_1, Class119 class119_1, long long_2, long long_3)
	{
		Class362 @class = class362_0;
		if (@class == null)
		{
			return true;
		}
		if (Volatile.Read(ref @class.int_1) == 0)
		{
			return false;
		}
		if (!@class.class361_0.Equals(class361_1))
		{
			class362_0 = null;
			return true;
		}
		if (!@class.bool_0)
		{
			Class60 class2 = class119_1.method_20();
			if (class2 == null || class2.long_0 <= @class.long_0 || class2.uint_0 != class361_1.uint_0 || class2.byte_0 != @class.byte_0 || class2.uint_1 != @class.uint_0)
			{
				if (smethod_22(@class.long_1, long_2, long_3) >= 2000.0)
				{
					class362_0 = null;
					return true;
				}
				return false;
			}
			if (!class2.bool_0)
			{
				class362_0 = null;
				return true;
			}
			@class.bool_0 = true;
		}
		if (gform0_0.method_5().method_89() == @class.int_0)
		{
			return false;
		}
		int_0++;
		class362_0 = null;
		return true;
	}

	private static void smethod_19()
	{
		class361_0 = null;
		bool_0 = false;
		bool_1 = false;
		int_0 = 0;
		bool_2 = false;
		bool_3 = false;
		float_0 = 0f;
		float_1 = 0f;
		long_0 = 0L;
		bool_4 = false;
		class362_0 = null;
	}

	private static void smethod_20(bool bool_5)
	{
		smethod_19();
		if (bool_5)
		{
			dictionary_0.Clear();
		}
	}

	private static bool smethod_21(Class119 class119_1)
	{
		if (class119_1 == class119_0 && class119_1 != null)
		{
			return class119_1.method_22() == long_1;
		}
		return false;
	}

	private static double smethod_22(long long_2, long long_3, long long_4)
	{
		if (long_3 <= long_2)
		{
			return 0.0;
		}
		return (double)(long_3 - long_2) * 1000.0 / (double)long_4;
	}

	private static void smethod_23(Class361 class361_1, long long_2, long long_3)
	{
		smethod_24(long_2);
		if (dictionary_0.Count >= 256)
		{
			Class361 key = null;
			long num = long.MaxValue;
			bool flag = false;
			foreach (KeyValuePair<Class361, long> item in dictionary_0)
			{
				if (!flag || item.Value < num)
				{
					key = item.Key;
					num = item.Value;
					flag = true;
				}
			}
			if (flag)
			{
				dictionary_0.Remove(key);
			}
		}
		long num2 = ((long_3 > 153722867280912930L) ? long.MaxValue : (long_3 * 60L));
		dictionary_0[class361_1] = ((long_2 > long.MaxValue - num2) ? long.MaxValue : (long_2 + num2));
	}

	private static void smethod_24(long long_2)
	{
		if (dictionary_0.Count == 0)
		{
			return;
		}
		List<Class361> list = new List<Class361>();
		foreach (KeyValuePair<Class361, long> item in dictionary_0)
		{
			if (long_2 >= item.Value)
			{
				list.Add(item.Key);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			dictionary_0.Remove(list[i]);
			smethod_25(list[i], Class185.smethod_0(-1141038122), 0, 0);
		}
	}

	private static void smethod_25(Class361 class361_1, string string_0, int int_1, int int_2)
	{
		if (!(string_0 == Class185.smethod_0(-1141038927)))
		{
			if (int_2 > 0)
			{
				int_1.ToString();
				int_2.ToString();
			}
		}
		else
		{
			int_1.ToString();
		}
	}

	private static void smethod_26(Class361 class361_1, string string_0, Enum10 enum10_0, int int_1)
	{
		if (enum10_0 != Enum10.TimedOut)
		{
			enum10_0.ToString().ToLowerInvariant();
		}
		if (int_1 > 0)
		{
			int_1.ToString();
			5.ToString();
		}
	}

	internal static Class403 smethod_27(Class145 class145_0, Class83 class83_0, bool bool_5, float float_2, float float_3, float float_4, float float_5, int int_1, bool bool_6, bool bool_7, int int_2, bool bool_8, DataGridView dataGridView_0)
	{
		if (int_1 != 22 && int_1 >= 0)
		{
			if (bool_8)
			{
				float float_6 = float_5 - 10f;
				float float_7 = (bool_5 ? float_2 : class83_0.float_0);
				float float_8 = (bool_5 ? float_3 : class83_0.float_1);
				float float_9 = (bool_5 ? float_4 : class83_0.float_2);
				if (smethod_28(class145_0, float_7, float_8, float_9, float_6))
				{
					return null;
				}
			}
			Class403 class403_ = null;
			float float_10 = float.MaxValue;
			smethod_29(class145_0, class145_0.method_6(), class83_0, bool_5, float_2, float_3, float_4, float_5, int_1, bool_6, bool_7, int_2, class83_0.byte_5, dataGridView_0, ref class403_, ref float_10);
			smethod_29(class145_0, class145_0.method_8(), class83_0, bool_5, float_2, float_3, float_4, float_5, int_1, bool_6, bool_7, int_2, class83_0.byte_5, dataGridView_0, ref class403_, ref float_10);
			return class403_;
		}
		return null;
	}

	private static bool smethod_28(Class145 class145_0, float float_2, float float_3, float float_4, float float_5)
	{
		IReadOnlyList<Class403> readOnlyList = class145_0.method_2();
		if (readOnlyList == null)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < readOnlyList.Count)
			{
				Class403 @class = readOnlyList[num];
				if (@class != null && !@class.method_0() && Class406.smethod_3(@class.float_0, @class.float_1, @class.float_2, float_2, float_3, float_4, float_5))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static void smethod_29(Class145 class145_0, IReadOnlyList<Class403> ireadOnlyList_0, Class83 class83_0, bool bool_5, float float_2, float float_3, float float_4, float float_5, int int_1, bool bool_6, bool bool_7, int int_2, byte byte_0, DataGridView dataGridView_0, ref Class403 class403_0, ref float float_6)
	{
		if (ireadOnlyList_0 == null)
		{
			return;
		}
		for (int i = 0; i < ireadOnlyList_0.Count; i++)
		{
			Class403 @class = ireadOnlyList_0[i];
			if (@class == null || @class.method_0())
			{
				continue;
			}
			float num = Class406.smethod_0(class83_0, @class.float_0, @class.float_1, @class.float_2);
			if (bool_5)
			{
				if (!Class406.smethod_3(@class.float_0, @class.float_1, @class.float_2, float_2, float_3, float_4, float_5))
				{
					continue;
				}
			}
			else if (num > float_5)
			{
				continue;
			}
			if (smethod_30(class145_0, @class, int_1, bool_6, bool_7, int_2, byte_0, dataGridView_0) && num < float_6)
			{
				float_6 = num;
				class403_0 = @class;
			}
		}
	}

	private static bool smethod_30(Class145 class145_0, Class403 class403_0, int int_1, bool bool_5, bool bool_6, int int_2, byte byte_0, DataGridView dataGridView_0)
	{
		bool flag = class403_0.byte_0 == 102;
		bool flag2 = class403_0.byte_0 == 101 && class403_0.method_4() == 16;
		string string_ = (flag ? null : Class447.smethod_3(class145_0, class403_0));
		if (bool_5 && flag)
		{
			return false;
		}
		if (bool_6 && flag2)
		{
			return false;
		}
		if (flag2 && (int_2 & smethod_0(class403_0.method_5())) != 0)
		{
			return false;
		}
		if (flag2 && byte_0 != 0 && (int_2 & smethod_0(byte_0)) != 0)
		{
			return false;
		}
		switch (int_1)
		{
		default:
			return true;
		case 19:
			return flag;
		case 20:
			if (!(flag || flag2))
			{
				return smethod_32(dataGridView_0, string_);
			}
			return true;
		case 21:
			if (!(flag || flag2))
			{
				return !smethod_32(dataGridView_0, string_);
			}
			return true;
		}
	}

	private static bool smethod_31(IReadOnlyList<string> ireadOnlyList_0, string string_0)
	{
		if (ireadOnlyList_0 != null && !string.IsNullOrEmpty(string_0))
		{
			int num = 0;
			while (true)
			{
				if (num < ireadOnlyList_0.Count)
				{
					string text = ireadOnlyList_0[num];
					if (!string.IsNullOrEmpty(text) && (text.IndexOf(string_0, StringComparison.OrdinalIgnoreCase) >= 0 || string_0.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0))
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	internal static bool smethod_32(DataGridView dataGridView_0, string string_0)
	{
		if (dataGridView_0 != null && !string.IsNullOrEmpty(string_0))
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dataGridView_0.Rows.Count; i++)
			{
				DataGridViewRow dataGridViewRow = dataGridView_0.Rows[i];
				if (!dataGridViewRow.IsNewRow && dataGridViewRow.Cells.Count != 0 && dataGridViewRow.Cells[0].Value != null)
				{
					list.Add(dataGridViewRow.Cells[0].Value.ToString());
				}
			}
			return smethod_31(list, string_0);
		}
		return false;
	}

	public static void smethod_33()
	{
		class119_0 = null;
		long_1 = 0L;
		smethod_20(bool_5: true);
		class173_0.method_1();
	}
}
