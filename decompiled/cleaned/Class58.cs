using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

internal static class Class58
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct18 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private Class148 class148_0;

		private Enum5 enum5_0;

		private TaskAwaiter taskAwaiter_0;

		private TaskAwaiter<bool> taskAwaiter_1;

		private bool bool_0;

		private bool bool_1;

		private float float_0;

		private TaskAwaiter<int> taskAwaiter_2;

		private float float_1;

		private TaskAwaiter<float> taskAwaiter_3;

		private void MoveNext()
		{
			int num = int_0;
			try
			{
				if ((uint)num > 17u)
				{
					class148_0 = gform0_0.method_14();
					enum5_0 = (Enum5)4;
				}
				try
				{
					TaskAwaiter awaiter2;
					TaskAwaiter<bool> awaiter;
					switch (num)
					{
					case 0:
						awaiter2 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						goto IL_080a;
					case 1:
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_082d;
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
					case 11:
					case 12:
					case 13:
					case 14:
					case 15:
					case 16:
					case 17:
						try
						{
							TaskAwaiter<int> awaiter4;
							TaskAwaiter<float> awaiter3;
							bool result;
							int result2;
							float result3;
							switch (num)
							{
							default:
								awaiter = GClass3.smethod_0(gform0_0).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 2;
									int_0 = 2;
									taskAwaiter_1 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_015b;
							case 2:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_015b;
							case 3:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_01c4;
							case 4:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_022a;
							case 5:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_029e;
							case 6:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_0314;
							case 7:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_037d;
							case 8:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_03e4;
							case 9:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_044d;
							case 10:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_04c8;
							case 11:
								awaiter4 = taskAwaiter_2;
								taskAwaiter_2 = default(TaskAwaiter<int>);
								num = -1;
								int_0 = -1;
								goto IL_0535;
							case 12:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_05ae;
							case 13:
								awaiter3 = taskAwaiter_3;
								taskAwaiter_3 = default(TaskAwaiter<float>);
								num = -1;
								int_0 = -1;
								goto IL_066e;
							case 14:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_06dc;
							case 15:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_078e;
							case 16:
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<bool>);
								num = -1;
								int_0 = -1;
								goto IL_07b4;
							case 17:
								{
									awaiter = taskAwaiter_1;
									taskAwaiter_1 = default(TaskAwaiter<bool>);
									num = -1;
									int_0 = -1;
									break;
								}
								IL_05ae:
								if (!awaiter.GetResult())
								{
									if (bool_0)
									{
										awaiter3 = gform0_0.smethod_11(2).GetAwaiter();
										if (!awaiter3.IsCompleted)
										{
											num = 13;
											int_0 = 13;
											taskAwaiter_3 = awaiter3;
											asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										}
										goto IL_066e;
									}
									awaiter = Class412.smethod_10(gform0_0, float_0).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 17;
										int_0 = 17;
										taskAwaiter_1 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									break;
								}
								goto end_IL_00ba;
								IL_015b:
								if (!awaiter.GetResult())
								{
									awaiter = gform0_0.smethod_7(26).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 3;
										int_0 = 3;
										taskAwaiter_1 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_01c4;
								}
								goto end_IL_00ba;
								IL_037d:
								if (awaiter.GetResult())
								{
									awaiter = GClass19.smethod_0(gform0_0).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 8;
										int_0 = 8;
										taskAwaiter_1 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_03e4;
								}
								goto end_IL_00ba;
								IL_07b4:
								awaiter.GetResult();
								goto end_IL_00ba;
								IL_01c4:
								if (!(result = awaiter.GetResult()))
								{
									awaiter = gform0_0.smethod_7(27).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 4;
										int_0 = 4;
										taskAwaiter_1 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_022a;
								}
								goto IL_0232;
								IL_04c8:
								if (!awaiter.GetResult())
								{
									awaiter4 = gform0_0.smethod_10(1).GetAwaiter();
									if (!awaiter4.IsCompleted)
									{
										num = 11;
										int_0 = 11;
										taskAwaiter_2 = awaiter4;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										return;
									}
									goto IL_0535;
								}
								goto end_IL_00ba;
								IL_03e4:
								if (!awaiter.GetResult())
								{
									awaiter = Class356.smethod_0(gform0_0).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 9;
										int_0 = 9;
										taskAwaiter_1 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_044d;
								}
								goto end_IL_00ba;
								IL_022a:
								result = awaiter.GetResult();
								goto IL_0232;
								IL_0232:
								bool_0 = result;
								if (result = bool_0)
								{
									awaiter = gform0_0.smethod_6(92).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 5;
										int_0 = 5;
										taskAwaiter_1 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_029e;
								}
								goto IL_02a6;
								IL_06dc:
								if (awaiter.GetResult())
								{
									awaiter = Class356.smethod_1(gform0_0, float_1).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 15;
										int_0 = 15;
										taskAwaiter_1 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_078e;
								}
								awaiter = Class356.smethod_2(gform0_0, float_1).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 16;
									int_0 = 16;
									taskAwaiter_1 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_07b4;
								IL_078e:
								awaiter.GetResult();
								goto end_IL_00ba;
								IL_029e:
								result = awaiter.GetResult();
								goto IL_02a6;
								IL_02a6:
								bool_1 = result;
								if (result = !bool_1)
								{
									awaiter = GClass15.smethod_0(gform0_0, 2).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 6;
										int_0 = 6;
										taskAwaiter_1 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_0314;
								}
								goto IL_031c;
								IL_044d:
								if (!awaiter.GetResult())
								{
									if (!bool_1)
									{
										awaiter = GClass7.smethod_0(gform0_0).GetAwaiter();
										if (!awaiter.IsCompleted)
										{
											num = 10;
											int_0 = 10;
											taskAwaiter_1 = awaiter;
											asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											return;
										}
										goto IL_04c8;
									}
									Class412.smethod_14();
								}
								goto end_IL_00ba;
								IL_0535:
								result2 = awaiter4.GetResult();
								float_0 = result2;
								awaiter = Class360.smethod_1(gform0_0, float_0 + 10f).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 12;
									int_0 = 12;
									taskAwaiter_1 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_05ae;
								IL_0314:
								result = awaiter.GetResult();
								goto IL_031c;
								IL_031c:
								if (!result)
								{
									awaiter = Class342.smethod_11(gform0_0).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 7;
										int_0 = 7;
										taskAwaiter_1 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_037d;
								}
								goto end_IL_00ba;
								IL_066e:
								result3 = awaiter3.GetResult();
								float_1 = result3;
								awaiter = gform0_0.smethod_6(97).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 14;
									int_0 = 14;
									taskAwaiter_1 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_06dc;
							}
							awaiter.GetResult();
							end_IL_00ba:;
						}
						catch (Exception)
						{
							enum5_0 = (Enum5)3;
							throw;
						}
						goto default;
					default:
						{
							if (!gform0_0.method_4())
							{
								awaiter2 = Task.Delay(300).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = 0;
									int_0 = 0;
									taskAwaiter_0 = awaiter2;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_080a;
							}
							if (enum5_0 == (Enum5)4)
							{
								enum5_0 = (Enum5)1;
							}
							break;
						}
						IL_080a:
						awaiter2.GetResult();
						awaiter = gform0_0.smethod_6(42).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_082d;
						IL_082d:
						if (awaiter.GetResult() && gform0_0.method_6() && gform0_0.method_5().method_0() != null)
						{
							goto case 2;
						}
						goto default;
					}
				}
				catch (Exception)
				{
					enum5_0 = (Enum5)3;
					throw;
				}
				finally
				{
					if (num < 0)
					{
						class148_0.method_11(enum5_0);
						gform0_0.method_54(class148_0);
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class148_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class148_0 = null;
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

	public static async Task smethod_0(GForm0 gform0_0)
	{
		Class148 @class = gform0_0.method_14();
		Enum5 @enum = (Enum5)4;
		try
		{
			while (!gform0_0.method_4())
			{
				await Task.Delay(300);
				if (!(await gform0_0.smethod_6(42)) || !gform0_0.method_6() || gform0_0.method_5().method_0() == null)
				{
					continue;
				}
				try
				{
					if (await GClass3.smethod_0(gform0_0))
					{
						continue;
					}
					bool num = await gform0_0.smethod_7(26);
					bool flag = num;
					if (!num)
					{
						flag = await gform0_0.smethod_7(27);
					}
					bool flag2 = flag;
					if (flag = flag2)
					{
						flag = await gform0_0.smethod_6(92);
					}
					bool flag3 = flag;
					if (flag = !flag3)
					{
						flag = await GClass15.smethod_0(gform0_0, 2);
					}
					if (flag || !(await Class342.smethod_11(gform0_0)) || await GClass19.smethod_0(gform0_0) || await Class356.smethod_0(gform0_0))
					{
						continue;
					}
					if (flag3)
					{
						Class412.smethod_14();
					}
					else
					{
						if (await GClass7.smethod_0(gform0_0))
						{
							continue;
						}
						float num2 = await gform0_0.smethod_10(1);
						if (await Class360.smethod_1(gform0_0, num2 + 10f))
						{
							continue;
						}
						if (!flag2)
						{
							await Class412.smethod_10(gform0_0, num2);
							continue;
						}
						float float_ = await gform0_0.smethod_11(2);
						if (!(await gform0_0.smethod_6(97)))
						{
							await Class356.smethod_2(gform0_0, float_);
						}
						else
						{
							await Class356.smethod_1(gform0_0, float_);
						}
						continue;
					}
				}
				catch (Exception)
				{
					@enum = (Enum5)3;
					throw;
				}
			}
			if (@enum == (Enum5)4)
			{
				@enum = (Enum5)1;
			}
		}
		catch (Exception)
		{
			@enum = (Enum5)3;
			throw;
		}
		finally
		{
			@class.method_11(@enum);
			gform0_0.method_54(@class);
		}
	}
}
