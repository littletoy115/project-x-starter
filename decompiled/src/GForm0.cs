using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public sealed class GForm0 : Form
{
	private sealed class Class149
	{
		public Class85 class85_0;

		public bool bool_0;

		internal bool method_0()
		{
			return Class396.smethod_1(class85_0.string_2, class85_0.string_1, bool_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct37 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm0 gform0_0;

		public FormClosingEventArgs formClosingEventArgs_0;

		private object object_0;

		private int int_1;

		private object object_1;

		private int int_2;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0053;
				}
				if (num == 2)
				{
					goto IL_018c;
				}
				if (!gForm.method_3())
				{
					formClosingEventArgs_0.Cancel = true;
					gForm.method_13();
					object_0 = null;
					int_1 = 0;
					goto IL_0053;
				}
				goto end_IL_000e;
				IL_018c:
				try
				{
					TaskAwaiter awaiter;
					if (num == 2)
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						goto IL_0207;
					}
					if (gForm.class363_0 != null)
					{
						gForm.class363_0.method_0()?.Dispose();
						awaiter = gForm.class363_0.method_12().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							taskAwaiter_0 = awaiter;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0207;
					}
					goto end_IL_018c;
					IL_0207:
					awaiter.GetResult();
					end_IL_018c:;
				}
				catch (Exception)
				{
				}
				gForm.Close();
				object obj = object_0;
				if (obj != null)
				{
					ExceptionDispatchInfo.Capture((obj as Exception) ?? new Exception(obj.ToString())).Throw();
				}
				object_0 = null;
				goto end_IL_000e;
				IL_0053:
				try
				{
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_010d;
						}
						int_2 = 0;
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							long long_ = ((gForm.class148_0 == null) ? 0L : gForm.class148_0.method_0());
							awaiter = gForm.method_52(Class8.smethod_0(long_)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								int_0 = 0;
								taskAwaiter_0 = awaiter;
								asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = taskAwaiter_0;
							taskAwaiter_0 = default(TaskAwaiter);
							num = -1;
							int_0 = -1;
						}
						awaiter.GetResult();
					}
					catch (Exception ex2)
					{
						object_1 = ex2;
						int_2 = 1;
					}
					int num2 = int_2;
					if (num2 == 1)
					{
						goto IL_010d;
					}
					goto IL_0171;
					IL_0171:
					object_1 = null;
					goto end_IL_0053;
					IL_010d:
					try
					{
						TaskAwaiter awaiter;
						if (num != 1)
						{
							awaiter = gForm.method_62().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 1;
								int_0 = 1;
								taskAwaiter_0 = awaiter;
								asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = taskAwaiter_0;
							taskAwaiter_0 = default(TaskAwaiter);
							num = -1;
							int_0 = -1;
						}
						awaiter.GetResult();
					}
					catch (Exception)
					{
					}
					goto IL_0171;
					end_IL_0053:;
				}
				catch (Exception obj2)
				{
					object_0 = obj2;
				}
				gForm.bool_8 = true;
				goto IL_018c;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct38 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public bool bool_0;

		public GForm0 gform0_0;

		private Class149 class149_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				if (num == 0)
				{
					goto IL_00ed;
				}
				class149_0 = new Class149();
				class149_0.bool_0 = bool_0;
				if (!gForm.bool_22)
				{
					class149_0.class85_0 = ((gForm.class190_0 == null) ? null : gForm.class190_0.method_0());
					if (class149_0.class85_0 != null && !string.IsNullOrEmpty(class149_0.class85_0.string_2) && !string.IsNullOrEmpty(class149_0.class85_0.string_1) && string.Equals(Class444.smethod_2(gForm.textBox_6.Text), class149_0.class85_0.string_2, StringComparison.OrdinalIgnoreCase))
					{
						gForm.bool_22 = true;
						gForm.button_89.Enabled = false;
						gForm.button_90.Enabled = false;
						goto IL_00ed;
					}
				}
				goto end_IL_000e;
				IL_00ed:
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run((Func<bool>)class149_0.method_0).GetAwaiter();
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
					awaiter.GetResult();
					if (!gForm.IsDisposed && gForm.class190_0.method_0() == class149_0.class85_0)
					{
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					if (num < 0)
					{
						gForm.bool_22 = false;
						if (!gForm.IsDisposed)
						{
							gForm.button_89.Enabled = true;
							gForm.button_90.Enabled = true;
						}
					}
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class149_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class149_0 = null;
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
	private struct Struct39 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm0 gform0_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = gForm.method_136(bool_23: true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct40 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<Exception> asyncTaskMethodBuilder_0;

		public Task task_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Exception result;
			try
			{
				if (num == 0 || task_0 != null)
				{
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = task_0.GetAwaiter();
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
							taskAwaiter_0 = default(TaskAwaiter);
							num = -1;
							int_0 = -1;
						}
						awaiter.GetResult();
						result = null;
					}
					catch (Exception ex)
					{
						result = ex;
					}
				}
				else
				{
					result = null;
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

	private sealed class Class150
	{
		public int int_0;

		public Class165 class165_0;

		internal Class82 method_0()
		{
			return Class421.smethod_4(class165_0.class85_0.string_2, class165_0.class85_0.string_1, int_0);
		}
	}

	[Serializable]
	private sealed class Class151
	{
		public static readonly Class151 class151_0 = new Class151();

		public static Action<IReadOnlyList<GStruct1>> action_0;

		public static Action<Class74> action_1;

		internal void method_0(IReadOnlyList<GStruct1> ireadOnlyList_0)
		{
			Class138.smethod_1(ireadOnlyList_0);
		}

		internal void method_1(Class74 class74_0)
		{
			Class342.smethod_0(class74_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct41 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm0 gform0_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = gForm.method_51(bool_23: false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception)
				{
					if (gForm.method_9(out var _, out var _))
					{
						Class429.smethod_0(gForm, "Stop failed - see the debug log.", "Stop");
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct43 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private Class157 class157_0;

		private long long_0;

		private bool bool_0;

		private long long_1;

		private bool bool_1;

		private TaskAwaiter<Class82> taskAwaiter_0;

		private TaskAwaiter<Tuple<Class87, bool>> taskAwaiter_1;

		private TaskAwaiter<Class164<bool>> taskAwaiter_2;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				if ((uint)num <= 3u)
				{
					goto IL_00c2;
				}
				class157_0 = new Class157();
				if (!gForm.bool_12 && gForm.method_9(out class157_0.class119_0, out long_0))
				{
					if (class157_0.class119_0 == null)
					{
						Class429.smethod_0(gForm, "The session is not available.", "Run");
					}
					else
					{
						class157_0.class85_0 = gForm.class190_0.method_0();
						if (class157_0.class85_0 != null)
						{
							gForm.bool_12 = true;
							gForm.button_12.Enabled = false;
							bool_0 = false;
							goto IL_00c2;
						}
						Class429.smethod_0(gForm, "Pick an LDPlayer title first.", "Run");
					}
				}
				goto end_IL_000e;
				IL_00c2:
				try
				{
					TaskAwaiter<Tuple<Class87, bool>> awaiter2;
					TaskAwaiter<Class82> awaiter;
					Tuple<Class87, bool> result;
					Class82 result2;
					switch (num)
					{
					default:
						long_1 = ++gForm.long_4;
						gForm.enum3_0 = Enum3.Unknown;
						gForm.method_24();
						awaiter = gForm.method_23(class157_0.class85_0, long_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_016c;
					case 0:
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<Class82>);
						num = -1;
						int_0 = -1;
						goto IL_016c;
					case 1:
						awaiter2 = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<Tuple<Class87, bool>>);
						num = -1;
						int_0 = -1;
						goto IL_0285;
					case 2:
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<Class82>);
						num = -1;
						int_0 = -1;
						goto IL_03e6;
					case 3:
						break;
						IL_0285:
						result = awaiter2.GetResult();
						if (gForm.method_22(class157_0.class85_0, long_1) && gForm.method_10(class157_0.class119_0, long_0))
						{
							if (result.Item1.enum1_0 == Enum1.Unknown)
							{
								Class429.smethod_0(gForm, "Runner activity could not be verified: " + result.Item1.string_0, "Setup");
							}
							else
							{
								if (result.Item1.enum1_0 == Enum1.Healthy)
								{
									goto IL_0455;
								}
								if (!result.Item2)
								{
									Form0 form = new Form0(class157_0.class85_0.string_2, class157_0.class85_0.string_1);
									try
									{
										form.ShowDialog(gForm);
										if (form.method_0())
										{
											goto end_IL_0353;
										}
										goto end_IL_00c2;
										end_IL_0353:;
									}
									finally
									{
										if (num < 0)
										{
											((IDisposable)form)?.Dispose();
										}
									}
									awaiter = gForm.method_23(class157_0.class85_0, long_1).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 2;
										int_0 = 2;
										taskAwaiter_0 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_03e6;
								}
								Class429.smethod_0(gForm, "A runner process is still active. Stop it before setup.", "Setup");
							}
						}
						goto end_IL_00c2;
						IL_016c:
						result2 = awaiter.GetResult();
						if (gForm.method_22(class157_0.class85_0, long_1) && gForm.method_10(class157_0.class119_0, long_0))
						{
							gForm.enum3_0 = result2.enum3_0;
							gForm.method_24();
							if (result2.enum3_0 == Enum3.Unknown)
							{
								Class429.smethod_0(gForm, result2.string_0, "Runner check");
							}
							else
							{
								if (gForm.enum3_0 != Enum3.RunnerMissing)
								{
									if (gForm.enum3_0 == Enum3.Stale)
									{
										awaiter2 = Task.Run((Func<Tuple<Class87, bool>>)class157_0.method_0).GetAwaiter();
										if (!awaiter2.IsCompleted)
										{
											num = 1;
											int_0 = 1;
											taskAwaiter_1 = awaiter2;
											asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
											return;
										}
										goto IL_0285;
									}
									goto IL_0455;
								}
								Class429.smethod_0(gForm, Class392.smethod_0(gForm.enum3_0, gForm.method_16()).string_1, "Setup");
							}
						}
						goto end_IL_00c2;
						IL_0455:
						if (Class357.smethod_0())
						{
							gForm.button_33.Enabled = false;
							bool_0 = true;
							bool_1 = false;
							break;
						}
						Class429.smethod_0(gForm, "Offsets not loaded - " + LocalOffsets.LastError, "Run");
						goto end_IL_00c2;
						IL_03e6:
						result2 = awaiter.GetResult();
						if (gForm.method_22(class157_0.class85_0, long_1) && gForm.method_10(class157_0.class119_0, long_0))
						{
							gForm.enum3_0 = result2.enum3_0;
							gForm.method_24();
							if (gForm.enum3_0 == Enum3.Current)
							{
								goto IL_0455;
							}
							Class429.smethod_0(gForm, result2.string_0, "Setup");
						}
						goto end_IL_00c2;
					}
					try
					{
						TaskAwaiter<Class164<bool>> awaiter3;
						if (num != 3)
						{
							awaiter3 = gForm.method_63(class157_0.class119_0, long_0, class157_0.class85_0.string_2, class157_0.class85_0.string_1, class157_0.class85_0.int_1).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 3;
								int_0 = 3;
								taskAwaiter_2 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
						}
						else
						{
							awaiter3 = taskAwaiter_2;
							taskAwaiter_2 = default(TaskAwaiter<Class164<bool>>);
							num = -1;
							int_0 = -1;
						}
						Class164<bool> result3 = awaiter3.GetResult();
						if (gForm.method_10(class157_0.class119_0, long_0) && result3.method_0())
						{
							bool_1 = result3.method_2();
							if (!bool_1)
							{
								Class429.smethod_0(gForm, "Run failed - see the debug log.", "Run");
							}
						}
					}
					catch (Exception)
					{
						if (gForm.method_10(class157_0.class119_0, long_0))
						{
							Class429.smethod_0(gForm, "Run failed - see the debug log.", "Run");
						}
					}
					finally
					{
						if (num < 0 && gForm.method_10(class157_0.class119_0, long_0))
						{
							gForm.method_24();
							gForm.button_12.Enabled = !bool_1;
							gForm.button_33.Enabled = true;
							gForm.button_2.Enabled = false;
							gForm.button_1.Enabled = false;
						}
					}
					end_IL_00c2:;
				}
				finally
				{
					if (num < 0)
					{
						if (!bool_0 && !gForm.IsDisposed && gForm.class190_0.method_0() == class157_0.class85_0 && gForm.method_10(class157_0.class119_0, long_0))
						{
							gForm.method_24();
							gForm.button_12.Enabled = true;
						}
						gForm.bool_12 = false;
					}
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class157_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class157_0 = null;
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
	private struct Struct44 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public bool bool_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_00fa;
				}
				if (num == 1)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_019b;
				}
				if (gForm.method_16() == Enum0.Selected && gForm.method_6() && !gForm.bool_5 && !gForm.bool_2 && (gForm.task_1 == null || gForm.task_1.IsCompleted))
				{
					gForm.button_2.Enabled = false;
					gForm.method_39();
					gForm.method_100();
					awaiter = smethod_5(gForm.task_3, "manual-start-transfer").GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00fa;
				}
				goto end_IL_000e;
				IL_00fa:
				awaiter.GetResult();
				if (gForm.method_16() == Enum0.Selected && gForm.method_6() && !gForm.bool_5)
				{
					Enum11 @enum = gForm.method_91();
					bool num2;
					if (@enum != (Enum11)1)
					{
						if (@enum != 0)
						{
							goto IL_0147;
						}
						num2 = gForm.method_92((Enum11)2);
					}
					else
					{
						num2 = gForm.method_93((Enum11)1, (Enum11)2);
					}
					if (!num2)
					{
						goto IL_0147;
					}
					awaiter = gForm.method_50(bool_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_019b;
				}
				if (!gForm.bool_7)
				{
					gForm.button_2.Enabled = gForm.method_16() == Enum0.Selected && gForm.method_6();
				}
				goto end_IL_000e;
				IL_019b:
				awaiter.GetResult();
				goto end_IL_000e;
				IL_0147:
				if (!gForm.bool_7)
				{
					gForm.button_2.Enabled = true;
				}
				end_IL_000e:;
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

	private sealed class Class152
	{
		public GForm0 gform0_0;

		public long long_0;

		internal string method_0(Class119 class119_0)
		{
			return gform0_0.method_66(class119_0, long_0, 8000);
		}
	}

	private sealed class Class153
	{
		public GForm0 gform0_0;

		public Class119 class119_0;

		internal void method_0(Class101 class101_0)
		{
			gform0_0.method_34(class119_0, class101_0);
		}

		internal void method_1(Class400 class400_0)
		{
			gform0_0.method_35(class119_0, class400_0);
		}
	}

	private sealed class Class154<T>
	{
		public Func<Class119, T> func_0;

		public Class119 class119_0;

		public string string_0;

		public Func<object> func_1;

		internal object method_0()
		{
			return func_0(class119_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct45 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Task task_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = task_0.GetAwaiter();
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
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception)
				{
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
	private struct Struct46 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm0 gform0_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = gForm.method_67().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception)
				{
					if (gForm.method_9(out var _, out var _))
					{
						Class429.smethod_0(gForm, "Run failed - see the debug log.", "Run");
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct47 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<Class164<bool>> asyncTaskMethodBuilder_0;

		public string string_0;

		public string string_1;

		public int int_1;

		public GForm0 gform0_0;

		public Class119 class119_0;

		public long long_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			Class164<bool> result;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num == 0)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_00c4;
				}
				Class155 @class = new Class155();
				@class.string_0 = string_0;
				@class.string_1 = string_1;
				@class.int_0 = int_1;
				Task<bool> task = gForm.method_11("Run", class119_0, long_0, @class.method_0);
				if (task != null)
				{
					awaiter = task.GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00c4;
				}
				result = new Class164<bool>(bool_1: false, gparam_1: false);
				goto end_IL_000e;
				IL_00c4:
				bool result2 = awaiter.GetResult();
				result = new Class164<bool>(gForm.method_10(class119_0, long_0), result2);
				end_IL_000e:;
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

	private sealed class Class155
	{
		public string string_0;

		public string string_1;

		public int int_0;

		internal bool method_0(Class119 class119_0)
		{
			return class119_0.method_66(string_0, string_1, int_0);
		}
	}

	private sealed class Class156
	{
		public GForm0 gform0_0;

		public Class119 class119_0;

		public long long_0;

		public HashSet<string> hashSet_0;

		public int int_0;

		internal List<Class53> method_0()
		{
			return Class144.smethod_1((!gform0_0.method_10(class119_0, long_0) || !class119_0.method_28()) ? Class145.class145_0 : class119_0.method_51(), gform0_0.string_0, hashSet_0, int_0, class119_0.ValueTuple_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct49 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm0 gform0_0;

		private Class119 class119_0;

		private long long_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				if (num == 0)
				{
					goto IL_0044;
				}
				if (!gForm.bool_1 && gForm.method_9(out class119_0, out long_0))
				{
					gForm.button_33.Enabled = false;
					goto IL_0044;
				}
				goto end_IL_000e;
				IL_0044:
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = gForm.method_68(class119_0, long_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
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
					bool result = awaiter.GetResult();
					if (gForm.method_10(class119_0, long_0))
					{
						gForm.bool_1 = result;
						if (result)
						{
							gForm.method_31();
							gForm.smethod_25(10, gForm.trackBar_0.Value.ToString());
							gForm.method_26();
							if (gForm.timer_2 == null)
							{
								gForm.timer_2 = new System.Windows.Forms.Timer
								{
									Interval = 100
								};
								gForm.timer_2.Tick += gForm.method_108;
							}
							gForm.smethod_1(51, 66);
							gForm.button_2.Enabled = true;
							gForm.button_4.Enabled = true;
							gForm.button_3.Enabled = true;
							gForm.button_14.Enabled = true;
							gForm.button_13.Enabled = true;
							gForm.button_12.Enabled = false;
							gForm.button_34.Enabled = true;
							gForm.button_15.Enabled = true;
							gForm.button_16.Enabled = true;
							gForm.button_1.Enabled = false;
						}
						else
						{
							gForm.button_33.Enabled = true;
							gForm.button_12.Enabled = class119_0 == null || !class119_0.method_10();
						}
						gForm.method_107(gForm.method_16());
						gForm.method_25();
						gForm.method_24();
					}
				}
				catch (Exception)
				{
					if (gForm.method_10(class119_0, long_0))
					{
						gForm.button_33.Enabled = true;
						Class429.smethod_0(gForm, "Select failed - see the debug log.", "Select");
					}
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class119_0 = null;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class119_0 = null;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct51 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public Class119 class119_0;

		public GForm0 gform0_0;

		public long long_0;

		private TaskAwaiter<Class164<bool>> taskAwaiter_0;

		private TaskAwaiter<Class164<string>> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			bool result;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_004a;
				}
				if (class119_0 == null)
				{
					Class429.smethod_0(gForm, "Press Run first.", "Select");
					result = false;
				}
				else
				{
					if (gForm.method_10(class119_0, long_0))
					{
						goto IL_004a;
					}
					result = false;
				}
				goto end_IL_000e;
				IL_004a:
				try
				{
					TaskAwaiter<Class164<bool>> awaiter;
					if (num == 0)
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<Class164<bool>>);
						num = -1;
						int_0 = -1;
						goto IL_0149;
					}
					TaskAwaiter<Class164<string>> awaiter2;
					if (num == 1)
					{
						awaiter2 = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<Class164<string>>);
						num = -1;
						int_0 = -1;
						goto IL_01e4;
					}
					if (class119_0.method_10())
					{
						goto IL_019e;
					}
					Class85 @class = gForm.class190_0.method_0();
					if (@class == null)
					{
						Class429.smethod_0(gForm, "Pick an LDPlayer title first.", "Select");
						result = false;
					}
					else
					{
						if (Class357.smethod_0())
						{
							awaiter = gForm.method_64(class119_0, long_0, @class.string_2, @class.string_1, @class.int_1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								int_0 = 0;
								taskAwaiter_0 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0149;
						}
						Class429.smethod_0(gForm, "Offsets not loaded - " + LocalOffsets.LastError, "Select");
						result = false;
					}
					goto end_IL_004a;
					IL_0149:
					Class164<bool> result2 = awaiter.GetResult();
					if (!gForm.method_10(class119_0, long_0))
					{
						result = false;
					}
					else if (!result2.method_0())
					{
						result = false;
					}
					else
					{
						if (result2.method_2())
						{
							goto IL_019e;
						}
						Class429.smethod_0(gForm, "No agent in the game - press Run first.", "Select");
						result = false;
					}
					goto end_IL_004a;
					IL_019e:
					awaiter2 = gForm.method_65(class119_0, long_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_01e4;
					IL_01e4:
					Class164<string> result3 = awaiter2.GetResult();
					if (!gForm.method_10(class119_0, long_0))
					{
						result = false;
					}
					else if (!class119_0.method_10())
					{
						result = false;
					}
					else if (!result3.method_0())
					{
						result = false;
					}
					else
					{
						string text = result3.method_2();
						if (string.IsNullOrEmpty(text))
						{
							Class429.smethod_0(gForm, "Could not read the hero name - try again.", "Select");
							result = false;
						}
						else
						{
							gForm.class11_0.method_8(text, gForm);
							gForm.class67_0.method_8(text);
							gForm.method_87();
							class119_0.method_93();
							gForm.string_0 = text;
							gForm.method_28();
							result = true;
						}
					}
					end_IL_004a:;
				}
				catch (Exception)
				{
					if (gForm.method_10(class119_0, long_0))
					{
						Class429.smethod_0(gForm, "Select failed - see the debug log.", "Select");
					}
					result = false;
				}
				end_IL_000e:;
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
	private struct Struct52 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<Class82> asyncTaskMethodBuilder_0;

		public Class85 class85_0;

		private Class165 class165_0;

		public GForm0 gform0_0;

		private Class150 class150_0;

		public long long_0;

		private Class82 class82_0;

		private Stopwatch stopwatch_0;

		private int int_1;

		private TaskAwaiter<Class82> taskAwaiter_0;

		private TaskAwaiter taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			Class82 result;
			try
			{
				if (num == 0)
				{
					goto IL_0072;
				}
				if (num != 1)
				{
					class165_0 = new Class165();
					class165_0.class85_0 = class85_0;
					class82_0 = null;
					stopwatch_0 = Stopwatch.StartNew();
					int_1 = 0;
					goto IL_01a9;
				}
				TaskAwaiter awaiter = taskAwaiter_1;
				taskAwaiter_1 = default(TaskAwaiter);
				num = -1;
				int_0 = -1;
				goto IL_0189;
				IL_0189:
				awaiter.GetResult();
				class150_0 = null;
				int_1++;
				goto IL_01a9;
				IL_0253:
				result = class82_0;
				goto end_IL_000f;
				IL_0072:
				try
				{
					TaskAwaiter<Class82> awaiter2;
					if (num != 0)
					{
						awaiter2 = Task.Run((Func<Class82>)class150_0.method_0).GetAwaiter();
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
						taskAwaiter_0 = default(TaskAwaiter<Class82>);
						num = -1;
						int_0 = -1;
					}
					Class82 result2 = awaiter2.GetResult();
					class82_0 = result2;
				}
				catch (Exception ex)
				{
					class82_0 = new Class82(Enum3.Unknown, "runner check failed: " + ex.Message);
				}
				if (gForm.method_22(class150_0.class165_0.class85_0, long_0) && class82_0.enum3_0 == Enum3.Unknown && int_1 != 3)
				{
					class150_0.int_0 = 15000 - (int)stopwatch_0.ElapsedMilliseconds;
					if (class150_0.int_0 > 0)
					{
						awaiter = Task.Delay(Math.Min(500, class150_0.int_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0189;
					}
				}
				goto IL_0253;
				IL_01a9:
				if (int_1 >= 4)
				{
					goto IL_0253;
				}
				class150_0 = new Class150();
				class150_0.class165_0 = class165_0;
				class150_0.int_0 = 15000 - (int)stopwatch_0.ElapsedMilliseconds;
				if (class150_0.int_0 > 0)
				{
					goto IL_0072;
				}
				result = new Class82(Enum3.Unknown, "runner check deadline exceeded");
				end_IL_000f:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class165_0 = null;
				class82_0 = null;
				stopwatch_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class165_0 = null;
			class82_0 = null;
			stopwatch_0 = null;
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

	private sealed class Class157
	{
		public Class119 class119_0;

		public Class85 class85_0;

		internal Tuple<Class87, bool> method_0()
		{
			bool bool_;
			return Tuple.Create(class119_0.method_187(class85_0.string_2, class85_0.string_1, out bool_), bool_);
		}
	}

	private sealed class Class158
	{
		public int int_0;

		public GForm0 gform0_0;

		internal void method_0(object sender, EventArgs e)
		{
			gform0_0.method_38(int_0);
		}
	}

	private sealed class Class159
	{
		public GForm0 gform0_0;

		public Class119 class119_0;

		public long long_0;

		internal Class145 method_0()
		{
			if (gform0_0.method_10(class119_0, long_0) && class119_0.method_28())
			{
				return gform0_0.method_5();
			}
			return Class145.class145_0;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct53 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Task task_0;

		public Class148 class148_0;

		public GForm0 gform0_0;

		private TaskAwaiter<Exception> taskAwaiter_0;

		private TaskAwaiter taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				TaskAwaiter<Exception> awaiter2;
				TaskAwaiter awaiter;
				Exception result;
				switch (num)
				{
				default:
					awaiter2 = smethod_4(task_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0080;
				case 0:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<Exception>);
					num = -1;
					int_0 = -1;
					goto IL_0080;
				case 1:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0285;
				case 2:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_02aa;
				case 3:
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_02aa:
					awaiter.GetResult();
					goto end_IL_000e;
					IL_0080:
					result = awaiter2.GetResult();
					if (class148_0 == gForm.class148_0 && task_0 == gForm.task_1 && task_0 == class148_0.method_1())
					{
						if (result != null)
						{
							Exception exception_ = class148_0.method_12(result);
							class148_0.method_11((Enum5)3);
							if (!gForm.method_56(class148_0.method_0()))
							{
								awaiter = gForm.method_52(Class8.smethod_2(class148_0.method_0(), exception_)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 1;
									int_0 = 1;
									taskAwaiter_1 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0285;
							}
						}
						else
						{
							if (class148_0.method_2() == (Enum5)2 && class148_0.method_3() && !class148_0.method_4() && !gForm.method_56(class148_0.method_0()))
							{
								awaiter = gForm.method_52(Class8.smethod_4(class148_0.method_0())).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 2;
									int_0 = 2;
									taskAwaiter_1 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_02aa;
							}
							if (class148_0.method_2() == (Enum5)0 || class148_0.method_2() == (Enum5)4)
							{
								class148_0.method_11((Enum5)4);
								Exception exception_2 = class148_0.method_13();
								if (!gForm.method_56(class148_0.method_0()))
								{
									awaiter = gForm.method_52(Class8.smethod_2(class148_0.method_0(), exception_2)).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 3;
										int_0 = 3;
										taskAwaiter_1 = awaiter;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									break;
								}
							}
						}
					}
					goto end_IL_000e;
					IL_0285:
					awaiter.GetResult();
					goto end_IL_000e;
				}
				awaiter.GetResult();
				end_IL_000e:;
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
	private struct Struct54 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private Class148 class148_0;

		private long long_0;

		private Task task_0;

		private Enum11 enum11_0;

		private Task task_1;

		private Class8 class8_0;

		private YieldAwaitable.YieldAwaiter yieldAwaiter_0;

		private TaskAwaiter<Exception> taskAwaiter_0;

		private TaskAwaiter taskAwaiter_1;

		private int int_1;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				YieldAwaitable.YieldAwaiter awaiter2;
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					awaiter2 = Task.Yield().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						yieldAwaiter_0 = awaiter2;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_009e;
				case 0:
					awaiter2 = yieldAwaiter_0;
					yieldAwaiter_0 = default(YieldAwaitable.YieldAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_009e;
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
					try
					{
						TaskAwaiter<Exception> awaiter3;
						Exception result;
						Exception result2;
						Exception result3;
						Exception result4;
						Exception ex;
						Exception result5;
						Exception result6;
						switch (num)
						{
						default:
							awaiter3 = smethod_4(task_0).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 1;
								int_0 = 1;
								taskAwaiter_0 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_01c9;
						case 1:
							awaiter3 = taskAwaiter_0;
							taskAwaiter_0 = default(TaskAwaiter<Exception>);
							num = -1;
							int_0 = -1;
							goto IL_01c9;
						case 2:
							awaiter3 = taskAwaiter_0;
							taskAwaiter_0 = default(TaskAwaiter<Exception>);
							num = -1;
							int_0 = -1;
							goto IL_031f;
						case 3:
							awaiter3 = taskAwaiter_0;
							taskAwaiter_0 = default(TaskAwaiter<Exception>);
							num = -1;
							int_0 = -1;
							goto IL_0371;
						case 4:
							awaiter3 = taskAwaiter_0;
							taskAwaiter_0 = default(TaskAwaiter<Exception>);
							num = -1;
							int_0 = -1;
							goto IL_03fb;
						case 5:
							awaiter3 = taskAwaiter_0;
							taskAwaiter_0 = default(TaskAwaiter<Exception>);
							num = -1;
							int_0 = -1;
							goto IL_046b;
						case 6:
							awaiter3 = taskAwaiter_0;
							taskAwaiter_0 = default(TaskAwaiter<Exception>);
							num = -1;
							int_0 = -1;
							goto IL_04f5;
						case 7:
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter);
							num = -1;
							int_0 = -1;
							goto IL_0635;
						case 8:
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter);
							num = -1;
							int_0 = -1;
							goto IL_0877;
						case 9:
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter);
							num = -1;
							int_0 = -1;
							goto IL_09f2;
						case 10:
							{
								awaiter = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter);
								num = -1;
								int_0 = -1;
								goto IL_0a97;
							}
							IL_0371:
							result = awaiter3.GetResult();
							if (result != null)
							{
								smethod_6("manual-pass", result);
							}
							class8_0 = gForm.method_58(long_0, class8_0);
							awaiter3 = smethod_4(task_0).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 4;
								int_0 = 4;
								taskAwaiter_0 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_03fb;
							IL_01c9:
							result2 = awaiter3.GetResult();
							class8_0 = gForm.method_58(long_0, class8_0);
							if (result2 != null && class148_0 != null)
							{
								Exception exception_ = class148_0.method_12(result2);
								class148_0.method_11((Enum5)3);
								gForm.method_57(Class8.smethod_2(long_0, exception_));
								class8_0 = gForm.class8_0;
							}
							if (enum11_0 == (Enum11)2)
							{
								awaiter3 = smethod_4(task_1).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num = 2;
									int_0 = 2;
									taskAwaiter_0 = awaiter3;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_031f;
							}
							if (enum11_0 == (Enum11)1)
							{
								awaiter3 = smethod_4(task_1).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num = 3;
									int_0 = 3;
									taskAwaiter_0 = awaiter3;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_0371;
							}
							awaiter3 = smethod_4(task_1).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 5;
								int_0 = 5;
								taskAwaiter_0 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_046b;
							IL_0a97:
							awaiter.GetResult();
							class8_0 = gForm.method_58(long_0, class8_0);
							if (class8_0.method_10())
							{
								int_1++;
								goto IL_0a72;
							}
							break;
							IL_0a72:
							if (int_1 < 10)
							{
								awaiter = gForm.method_61(int_1).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 10;
									int_0 = 10;
									taskAwaiter_1 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0a97;
							}
							break;
							IL_04f5:
							result3 = awaiter3.GetResult();
							if (result3 != null && class148_0 != null)
							{
								Exception exception_2 = class148_0.method_12(result3);
								gForm.method_57(Class8.smethod_2(long_0, exception_2));
							}
							class8_0 = gForm.method_58(long_0, class8_0);
							goto IL_0544;
							IL_03fb:
							result4 = awaiter3.GetResult();
							if (result4 != null && class148_0 != null)
							{
								Exception exception_3 = class148_0.method_12(result4);
								gForm.method_57(Class8.smethod_2(long_0, exception_3));
							}
							class8_0 = gForm.method_58(long_0, class8_0);
							goto IL_0544;
							IL_0544:
							if (class148_0 != null && class148_0.method_2() == (Enum5)4)
							{
								Exception exception_4 = class148_0.method_13();
								gForm.method_57(Class8.smethod_2(long_0, exception_4));
								class8_0 = gForm.class8_0;
							}
							ex = ((class148_0 == null) ? null : class148_0.method_5());
							if (ex != null && class148_0.method_14(long_0, task_0, ex))
							{
								smethod_7(class148_0, task_0, ex);
							}
							awaiter = gForm.method_60("AttackStop", gForm.method_147).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 7;
								int_0 = 7;
								taskAwaiter_1 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0635;
							IL_031f:
							result5 = awaiter3.GetResult();
							if (result5 != null)
							{
								smethod_6("manual-pass", result5);
							}
							class8_0 = gForm.method_58(long_0, class8_0);
							goto IL_0544;
							IL_09f2:
							awaiter.GetResult();
							class8_0 = gForm.method_58(long_0, class8_0);
							goto IL_0a11;
							IL_0877:
							awaiter.GetResult();
							class8_0 = gForm.method_58(long_0, class8_0);
							gForm.bool_2 = false;
							gForm.method_59("ApplyZone", gForm.method_118);
							class8_0 = gForm.method_58(long_0, class8_0);
							if (!class8_0.method_1() && !gForm.bool_7)
							{
								if (class8_0.method_2())
								{
									gForm.bool_1 = false;
									if (gForm.timer_2 != null)
									{
										gForm.timer_2.Stop();
									}
									gForm.button_2.Enabled = false;
									gForm.button_1.Enabled = false;
									gForm.button_33.Enabled = true;
									gForm.button_12.Enabled = true;
									gForm.method_24();
								}
								else if (!class8_0.method_10())
								{
									gForm.button_2.Enabled = gForm.bool_1 && gForm.method_6() && !gForm.bool_7;
									gForm.button_1.Enabled = false;
									gForm.method_24();
									gForm.method_25();
								}
								goto IL_0a11;
							}
							awaiter = gForm.method_62().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 9;
								int_0 = 9;
								taskAwaiter_1 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_09f2;
							IL_0635:
							awaiter.GetResult();
							class8_0 = gForm.method_58(long_0, class8_0);
							gForm.method_59("Manage_Attack_Monster.Reset", Class412.smethod_15);
							gForm.method_59("FollowPartyMember.Reset", Class356.smethod_3);
							class8_0 = gForm.method_58(long_0, class8_0);
							gForm.method_59("Manage_Attack_Monster.ClearTarget", Class412.smethod_14);
							class8_0 = gForm.method_58(long_0, class8_0);
							gForm.method_59("Manage_Pick_Item.Reset", Class360.smethod_33);
							class8_0 = gForm.method_58(long_0, class8_0);
							gForm.method_59("Buff.Reset", Class342.smethod_2);
							class8_0 = gForm.method_58(long_0, class8_0);
							gForm.method_59("Manage_Follow_Pos.Reset", Class2.smethod_8);
							class8_0 = gForm.method_58(long_0, class8_0);
							gForm.method_59("Manage_Looper.Reset", Class188.smethod_17);
							class8_0 = gForm.method_58(long_0, class8_0);
							gForm.method_59("ReleaseSellDriver.Automatic", gForm.method_148);
							class8_0 = gForm.method_58(long_0, class8_0);
							gForm.method_59("ReleaseSellDriver.ManualPump", gForm.method_149);
							class8_0 = gForm.method_58(long_0, class8_0);
							gForm.method_59("Manage_Attack_Monster.NotFixZone", Class412.smethod_7);
							class8_0 = gForm.method_58(long_0, class8_0);
							awaiter = gForm.method_60("Manage_Attack_Monster.ShowZoneAsync", gForm.method_150).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 8;
								int_0 = 8;
								taskAwaiter_1 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0877;
							IL_0a11:
							if (class8_0.method_10())
							{
								gForm.button_2.Enabled = false;
								gForm.button_1.Enabled = false;
								int_1 = 0;
								goto IL_0a72;
							}
							break;
							IL_046b:
							result6 = awaiter3.GetResult();
							if (result6 != null)
							{
								smethod_6("manual-pass", result6);
							}
							class8_0 = gForm.method_58(long_0, class8_0);
							awaiter3 = smethod_4(task_0).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 6;
								int_0 = 6;
								taskAwaiter_0 = awaiter3;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_04f5;
						}
					}
					catch (Exception ex2)
					{
						smethod_6("StopCoreAsync", ex2);
						if (class148_0 != null)
						{
							Exception exception_5 = class148_0.method_12(ex2);
							gForm.method_57(Class8.smethod_2(long_0, exception_5));
						}
						class8_0 = gForm.method_58(long_0, class8_0);
						gForm.bool_2 = false;
						gForm.method_59("ApplyZone", gForm.method_118);
						if (!gForm.bool_7)
						{
							gForm.button_2.Enabled = gForm.bool_1 && gForm.method_6();
							gForm.button_1.Enabled = false;
						}
					}
					finally
					{
						if (num < 0)
						{
							class8_0 = gForm.method_58(long_0, class8_0);
							gForm.long_3 = long_0;
							gForm.bool_5 = false;
							if (!class8_0.method_1() && !class8_0.method_2() && !class8_0.method_10())
							{
								gForm.bool_6 = false;
							}
							if (!gForm.bool_7)
							{
								gForm.class8_0 = Class8.class8_0;
							}
						}
					}
					if (class8_0.method_10() && !gForm.bool_7 && class148_0 == gForm.class148_0 && class148_0 != null && class148_0.method_0() == long_0 && gForm.bool_1 && gForm.method_6())
					{
						awaiter = gForm.method_49(bool_23: false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 11;
							int_0 = 11;
							taskAwaiter_1 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
					goto end_IL_000e;
				case 11:
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						break;
					}
					IL_009e:
					awaiter2.GetResult();
					class148_0 = gForm.class148_0;
					long_0 = ((class148_0 == null) ? 0L : class148_0.method_0());
					task_0 = ((class148_0 == null || class148_0.method_1() == null) ? (gForm.task_1 ?? Task.CompletedTask) : class148_0.method_1());
					enum11_0 = gForm.method_91();
					task_1 = gForm.task_3 ?? Task.CompletedTask;
					gForm.method_100();
					class8_0 = gForm.class8_0;
					goto case 1;
				}
				awaiter.GetResult();
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class148_0 = null;
				task_0 = null;
				task_1 = null;
				class8_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class148_0 = null;
			task_0 = null;
			task_1 = null;
			class8_0 = null;
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
	private struct Struct55 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0084;
				}
				if (gForm.method_7() == null)
				{
					gForm.method_101();
				}
				else if (gForm.method_5().method_0() == null)
				{
					gForm.method_101();
				}
				else
				{
					if (gForm.method_5().method_47() != 0)
					{
						gForm.int_2 = 0;
						goto IL_0084;
					}
					gForm.int_2++;
					if (gForm.int_2 > 10)
					{
						smethod_11("pump-aborted", "reason=bag-cap-timeout");
						gForm.method_101();
					}
				}
				goto end_IL_000e;
				IL_0084:
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num == 0)
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
						goto IL_0154;
					}
					if (num != 1)
					{
						if (gForm.func_2 == null)
						{
							awaiter = GClass15.smethod_0(gForm, 1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								int_0 = 0;
								taskAwaiter_0 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0154;
						}
						awaiter = gForm.func_2().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
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
					awaiter.GetResult();
					goto end_IL_0084;
					IL_0154:
					awaiter.GetResult();
					end_IL_0084:;
				}
				finally
				{
					if (num < 0)
					{
						gForm.method_100();
						gForm.method_94((Enum11)1);
					}
				}
				end_IL_000e:;
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
	private struct Struct56 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<Class164<string>> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public long long_0;

		public Class119 class119_0;

		private Class152 class152_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			Class164<string> result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num == 0)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<string>);
					num = -1;
					int_0 = -1;
					goto IL_00d1;
				}
				class152_0 = new Class152();
				class152_0.gform0_0 = gform0_0;
				class152_0.long_0 = long_0;
				Task<string> task = gForm.method_11("Census", class119_0, class152_0.long_0, class152_0.method_0);
				if (task != null)
				{
					awaiter = task.GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00d1;
				}
				result = new Class164<string>(bool_1: false, null);
				goto end_IL_000e;
				IL_00d1:
				string result2 = awaiter.GetResult();
				result = new Class164<string>(gForm.method_10(class119_0, class152_0.long_0) && class119_0.method_10(), result2);
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class152_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class152_0 = null;
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

	private sealed class Class160
	{
		public GForm0 gform0_0;

		public Class119 class119_0;

		internal void method_0()
		{
			if (gform0_0.timer_1 != null)
			{
				gform0_0.timer_1.Stop();
				gform0_0.timer_1.Dispose();
				gform0_0.timer_1 = null;
			}
		}

		internal void method_1()
		{
			if (gform0_0.timer_2 != null)
			{
				gform0_0.timer_2.Stop();
				gform0_0.timer_2.Dispose();
				gform0_0.timer_2 = null;
			}
		}

		internal void method_2()
		{
			class119_0.method_53(gform0_0.method_109);
		}

		internal void method_3()
		{
			class119_0.method_5(gform0_0.method_20);
		}

		internal void method_4()
		{
			Action<Class119> action_ = gform0_0.action_0;
			if (action_ == null)
			{
				class119_0.Dispose();
			}
			else
			{
				action_(class119_0);
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct57 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_006c;
				}
				Class119 class119_ = gForm.class119_0;
				if (class119_ != null)
				{
					awaiter = class119_.method_130().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_006c;
				}
				goto end_IL_000e;
				IL_006c:
				awaiter.GetResult();
				end_IL_000e:;
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
	private struct Struct58 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm0 gform0_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = gForm.method_49(bool_23: true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception)
				{
					if (gForm.method_9(out var _, out var _))
					{
						Class429.smethod_0(gForm, "Start failed - see the debug log.", "Start");
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct59 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm0 gform0_0;

		public Class85 class85_0;

		private long long_0;

		private TaskAwaiter<Class82> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				TaskAwaiter<Class82> awaiter;
				if (num == 0)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<Class82>);
					num = -1;
					int_0 = -1;
					goto IL_00b9;
				}
				long_0 = ++gForm.long_4;
				gForm.enum3_0 = Enum3.Unknown;
				gForm.method_24();
				if (class85_0 != null && !string.IsNullOrEmpty(class85_0.string_1))
				{
					awaiter = gForm.method_23(class85_0, long_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00b9;
				}
				goto end_IL_000e;
				IL_00b9:
				Class82 result = awaiter.GetResult();
				if (gForm.method_22(class85_0, long_0))
				{
					gForm.enum3_0 = result.enum3_0;
					gForm.method_24();
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct60 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		public string string_0;

		public Func<Task> func_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						gForm.action_1?.Invoke(string_0);
						awaiter = func_0().GetAwaiter();
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
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception_)
				{
					smethod_6(string_0, exception_);
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
	private struct Struct61 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Task task_0;

		public string string_0;

		private TaskAwaiter<Exception> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			try
			{
				TaskAwaiter<Exception> awaiter;
				if (num != 0)
				{
					awaiter = smethod_4(task_0).GetAwaiter();
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
					taskAwaiter_0 = default(TaskAwaiter<Exception>);
					num = -1;
					int_0 = -1;
				}
				Exception result = awaiter.GetResult();
				if (result != null)
				{
					smethod_6(string_0, result);
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

	private sealed class Class161
	{
		public string string_0;

		public string string_1;

		public int int_0;

		internal bool method_0(Class119 class119_0)
		{
			return class119_0.method_68(string_0, string_1, int_0);
		}
	}

	private sealed class Class162<T>
	{
		public Func<string, Class119, Func<object>, object> func_0;

		public Class154<T> class154_0;

		internal T method_0()
		{
			if (func_0 == null)
			{
				return class154_0.func_0(class154_0.class119_0);
			}
			return (T)func_0(class154_0.string_0, class154_0.class119_0, class154_0.method_0);
		}
	}

	private sealed class Class164<T>
	{
		private bool bool_0;

		private T gparam_0;

		internal Class164(bool bool_1, T gparam_1)
		{
			method_1(bool_1);
			method_3(gparam_1);
		}

		internal bool method_0()
		{
			return bool_0;
		}

		private void method_1(bool bool_1)
		{
			bool_0 = bool_1;
		}

		internal T method_2()
		{
			return gparam_0;
		}

		private void method_3(T gparam_1)
		{
			gparam_0 = gparam_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct63 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private Class160 class160_0;

		private Task[] task_0;

		private int int_1;

		private TaskAwaiter<Exception> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				if (num != 0)
				{
					class160_0 = new Class160();
					class160_0.gform0_0 = gform0_0;
					gForm.method_13();
					gForm.method_59("SellTimer.Dispose", class160_0.method_0);
					gForm.method_59("ReadoutTimer.Dispose", class160_0.method_1);
					object object_ = gForm.object_0;
					bool lockTaken = false;
					try
					{
						Monitor.Enter(object_, ref lockTaken);
						class160_0.class119_0 = gForm.class119_1;
						task_0 = gForm.task_0;
						gForm.class119_1 = null;
						gForm.task_0 = new Task[0];
					}
					finally
					{
						if (num < 0 && lockTaken)
						{
							Monitor.Exit(object_);
						}
					}
					int_1 = 0;
					goto IL_00fb;
				}
				TaskAwaiter<Exception> awaiter = taskAwaiter_0;
				taskAwaiter_0 = default(TaskAwaiter<Exception>);
				num = -1;
				int_0 = -1;
				goto IL_013c;
				IL_00fb:
				if (int_1 < task_0.Length)
				{
					awaiter = smethod_4(task_0[int_1]).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_013c;
				}
				if (class160_0.class119_0 != null)
				{
					gForm.method_59("Session.OnSnapshot.Unsubscribe", class160_0.method_2);
					gForm.method_59("Session.OnDetached.Unsubscribe", class160_0.method_3);
					gForm.method_59("Session.StopStreaming", class160_0.class119_0.method_95);
					gForm.method_59("Session.Dispose", class160_0.method_4);
				}
				goto end_IL_000e;
				IL_013c:
				Exception result = awaiter.GetResult();
				if (result != null)
				{
					smethod_6("SessionOperation", result);
				}
				int_1++;
				goto IL_00fb;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class160_0 = null;
				task_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class160_0 = null;
			task_0 = null;
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
	private struct Struct64 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm0 gform0_0;

		public int int_1;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				if (num != 0)
				{
					gForm.method_36();
					gForm.string_0 = null;
					gForm.method_102();
					gForm.method_28();
				}
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						long long_ = ((gForm.class148_0 == null) ? 0L : gForm.class148_0.method_0());
						awaiter = gForm.method_52(Class8.smethod_1(long_, int_1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception)
				{
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct65 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm0 gform0_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = gForm.method_136(bool_23: false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct66 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<Class164<bool>> asyncTaskMethodBuilder_0;

		public string string_0;

		public string string_1;

		public int int_1;

		public GForm0 gform0_0;

		public Class119 class119_0;

		public long long_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			Class164<bool> result;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num == 0)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_00c4;
				}
				Class161 @class = new Class161();
				@class.string_0 = string_0;
				@class.string_1 = string_1;
				@class.int_0 = int_1;
				Task<bool> task = gForm.method_11("Attach", class119_0, long_0, @class.method_0);
				if (task != null)
				{
					awaiter = task.GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00c4;
				}
				result = new Class164<bool>(bool_1: false, gparam_1: false);
				goto end_IL_000e;
				IL_00c4:
				bool result2 = awaiter.GetResult();
				result = new Class164<bool>(gForm.method_10(class119_0, long_0), result2);
				end_IL_000e:;
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

	private sealed class Class165
	{
		public Class85 class85_0;
	}

	private Size size_0 = new Size(348, 597);

	private Size size_1 = new Size(668, 597);

	public GClass12 gclass12_0;

	public GClass12 gclass12_1;

	public GClass12 gclass12_2;

	public GClass12 gclass12_3;

	public GClass12 gclass12_4;

	private readonly CheckBox[] checkBox_0;

	private Class14 class14_0;

	private Class190 class190_0;

	private Class11 class11_0;

	private Class67 class67_0;

	private Form7 form7_0;

	private Class119 class119_0;

	private Class363 class363_0;

	private DiscordNotifier discordNotifier_0;

	private readonly object object_0 = new object();

	private readonly HashSet<Task> hashSet_0 = new HashSet<Task>();

	private long long_0;

	private bool bool_0;

	private Class119 class119_1;

	private Task[] task_0 = new Task[0];

	internal Func<string, Class119, Func<object>, object> func_0;

	internal Action<Class119> action_0;

	private bool bool_1;

	internal volatile bool bool_2;

	internal volatile bool bool_3;

	internal volatile bool bool_4 = true;

	private Task task_1 = Task.CompletedTask;

	private Task task_2 = Task.CompletedTask;

	private bool bool_5;

	private volatile bool bool_6;

	private bool bool_7;

	private bool bool_8;

	private long long_1;

	private long long_2 = long.MinValue;

	private long long_3 = long.MinValue;

	private Class148 class148_0;

	private Class8 class8_0 = Class8.class8_0;

	private Struct67 struct67_0;

	private Struct139 struct139_0;

	private Enum3 enum3_0;

	private long long_4;

	private readonly ToolTip toolTip_0 = new ToolTip();

	private Color color_0;

	private Color color_1;

	private bool bool_9;

	internal static readonly bool bool_10 = true;

	private IContainer icontainer_0;

	private CheckBox checkBox_1;

	private CheckBox checkBox_2;

	private TabPage tabPage_0;

	private RadioButton radioButton_0;

	private RadioButton radioButton_1;

	private RadioButton radioButton_2;

	private CheckBox checkBox_3;

	private CheckBox checkBox_4;

	private CheckBox checkBox_5;

	private CheckBox checkBox_6;

	private CheckBox checkBox_7;

	private Label label_0;

	private Label label_1;


	private TabPage tabPage_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private RadioButton radioButton_3;

	private RadioButton radioButton_4;

	private RadioButton radioButton_5;

	private RadioButton radioButton_6;

	private CheckBox checkBox_8;

	private CheckBox checkBox_9;

	private CheckBox checkBox_10;

	private Button button_1;

	private Button button_2;

	private CheckBox checkBox_11;

	private TabPage tabPage_2;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	private Label label_9;

	private Label label_10;

	private RadioButton radioButton_7;

	private RadioButton radioButton_8;

	private RadioButton radioButton_9;

	private Label label_11;

	private Label label_12;

	private Label label_13;

	private CheckBox checkBox_12;

	private CheckBox checkBox_13;

	private CheckBox checkBox_14;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private TextBox textBox_2;

	private Label label_14;

	private TextBox textBox_3;

	private TextBox textBox_4;

	private Label label_15;

	private Label label_16;

	private TabPage tabPage_3;

	private CheckBox checkBox_15;

	private CheckBox checkBox_16;

	private CheckBox checkBox_17;

	private CheckBox checkBox_18;

	private CheckBox checkBox_19;

	private CheckBox checkBox_20;

	private CheckBox checkBox_21;

	private CheckBox checkBox_22;

	private CheckBox checkBox_23;

	private CheckBox checkBox_24;

	private CheckBox checkBox_25;

	private CheckBox checkBox_26;

	private CheckBox checkBox_27;

	private CheckBox checkBox_28;

	private CheckBox checkBox_29;

	private CheckBox checkBox_30;

	private CheckBox checkBox_31;

	private TabControl tabControl_0;

	private ComboBox comboBox_0;

	private DataGridView dataGridView_0;

	private Button button_3;

	private Button button_4;

	private TrackBar trackBar_0;

	private CheckBox checkBox_32;

	private Label label_17;

	private Label label_18;

	private TabPage tabPage_4;

	private Button button_5;

	private TextBox textBox_5;

	private Button button_6;

	private Button button_7;

	private DataGridView dataGridView_1;

	private DataGridView dataGridView_2;

	private Button button_8;

	private ComboBox comboBox_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private Button button_9;

	private Label label_19;

	private Button button_10;

	private RadioButton radioButton_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private Label label_20;

	private RadioButton radioButton_11;

	private TextBox textBox_6;

	private Button button_11;

	private Button button_12;

	private CheckBox checkBox_33;

	private Label label_21;

	private Label label_23;

	private CheckBox checkBox_34;

	private CheckBox checkBox_35;

	private Label label_24;

	private Button button_13;

	private Button button_14;

	private TabPage tabPage_5;

	private DataGridView dataGridView_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridView dataGridView_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private DataGridView dataGridView_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

	private DataGridView dataGridView_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

	private DataGridView dataGridView_7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

	private DataGridView dataGridView_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

	private DataGridView dataGridView_9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

	private DataGridView dataGridView_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

	private DataGridView dataGridView_11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

	private DataGridView dataGridView_12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

	private DataGridView dataGridView_13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;

	private DataGridView dataGridView_14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;

	private DataGridView dataGridView_15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;

	private DataGridView dataGridView_16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;

	private DataGridView dataGridView_17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;

	private DataGridView dataGridView_18;

	private Button button_15;

	private Button button_16;

	private CheckBox checkBox_36;

	private Button button_17;

	private Button button_18;

	private Button button_19;

	private Button button_20;

	private Button button_21;

	private Button button_22;

	private Button button_23;

	private Button button_24;

	private Button button_25;

	private Button button_26;

	private Button button_27;

	private Button button_28;

	private Button button_29;

	private Button button_30;

	private Button button_31;

	private Button button_32;

	private Button button_33;

	private TextBox textBox_7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;

	private Button button_34;

	private Label label_25;



	private Label label_26;

	private TextBox textBox_9;

	private RadioButton radioButton_12;

	private Label label_27;

	private Label label_28;

	private Label label_29;

	private Label label_30;


	private CheckBox checkBox_38;

	private Label label_31;

	private ComboBox comboBox_2;

	private Button button_35;

	private Button button_36;

	private Label label_32;

	private TextBox textBox_10;

	private Label label_33;

	private CheckBox checkBox_39;

	private CheckBox checkBox_40;

	private TabPage tabPage_6;

	private CheckBox checkBox_41;

	private TextBox textBox_11;

	private Label label_34;

	private Label label_35;

	private ComboBox comboBox_3;

	private Label label_36;

	private Button button_37;

	private Button button_38;

	private Label label_37;

	private Button button_39;

	private Button button_40;

	private ComboBox comboBox_4;

	private Button button_41;

	private TextBox textBox_12;

	private Button button_42;

	private Button button_43;

	private DataGridView dataGridView_19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;

	private DataGridView dataGridView_20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;

	private RadioButton radioButton_14;

	private RadioButton radioButton_15;

	private RadioButton radioButton_16;

	private CheckBox checkBox_42;

	private CheckBox checkBox_43;

	private TextBox textBox_13;

	private TextBox textBox_14;

	private TextBox textBox_15;

	private TextBox textBox_16;

	private TextBox textBox_17;

	private TextBox textBox_18;

	private TabPage tabPage_7;

	private CheckBox checkBox_44;

	private CheckBox checkBox_45;

	private CheckBox checkBox_46;

	private ComboBox comboBox_5;

	private Label label_38;

	private ComboBox comboBox_6;

	private Button button_45;

	private CheckBox checkBox_47;

	private CheckBox checkBox_48;

	private DateTimePicker dateTimePicker_0;

	private CheckBox checkBox_49;

	private Label label_39;

	private DateTimePicker dateTimePicker_1;

	private Label label_40;

	private CheckBox checkBox_50;

	private DateTimePicker dateTimePicker_2;

	private DateTimePicker dateTimePicker_3;

	private GroupBox groupBox_0;

	private ComboBox comboBox_7;

	private Label label_41;

	private Label label_42;

	private TextBox textBox_19;

	private GroupBox groupBox_1;

	private ComboBox comboBox_8;

	private Label label_43;

	private Label label_44;

	private TextBox textBox_20;

	private CheckBox checkBox_51;

	private RadioButton radioButton_17;

	private RadioButton radioButton_18;

	private RadioButton radioButton_19;

	private CheckBox checkBox_52;

	private RadioButton radioButton_20;

	private RadioButton radioButton_21;

	private RadioButton radioButton_22;

	private Label label_45;

	private CheckBox checkBox_53;

	private TabPage tabPage_8;

	private Button button_46;

	private Label label_46;

	private Label label_47;

	private Label label_48;

	private Label label_49;

	private Label label_50;

	private Label label_51;

	private Label label_52;

	private Label label_53;

	private Label label_54;

	private Label label_55;

	private Label label_56;

	private Label label_57;

	private Label label_58;

	private Label label_59;

	private CheckBox checkBox_54;

	private ComboBox comboBox_9;

	private TextBox textBox_21;

	private Label label_60;

	private CheckBox checkBox_55;

	private ComboBox comboBox_10;

	private TextBox textBox_22;

	private Label label_61;

	private CheckBox checkBox_56;

	private ComboBox comboBox_11;

	private TextBox textBox_23;

	private Label label_62;

	private CheckBox checkBox_57;

	private ComboBox comboBox_12;

	private TextBox textBox_24;

	private Label label_63;

	private CheckBox checkBox_58;

	private ComboBox comboBox_13;

	private TextBox textBox_25;

	private Label label_64;

	private CheckBox checkBox_59;

	private ComboBox comboBox_14;

	private TextBox textBox_26;

	private Label label_65;

	private TextBox textBox_27;

	private TextBox textBox_28;

	private TextBox textBox_29;

	private Button button_47;

	private Button button_48;

	private Button button_49;

	private Button button_50;

	private ComboBox comboBox_15;

	private ComboBox comboBox_16;

	private ComboBox comboBox_17;

	private DataGridView dataGridView_21;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;

	private TabPage tabPage_9;

	private CheckBox checkBox_60;

	private TextBox textBox_30;

	private Label label_66;

	private TextBox textBox_31;

	private CheckBox checkBox_61;

	private CheckBox checkBox_62;

	private Label label_67;

	private CheckBox checkBox_63;

	private CheckBox checkBox_64;

	private Button button_51;

	private GroupBox groupBox_2;

	private RadioButton radioButton_23;

	private RadioButton radioButton_24;

	private Label label_68;

	private TabPage tabPage_10;

	private DataGridView dataGridView_22;

	private CheckBox checkBox_65;

	private TrackBar trackBar_1;

	private Label label_70;

	private DataGridView dataGridView_23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;

	private CheckBox checkBox_66;

	private CheckBox checkBox_67;

	private Label label_71;

	private Label label_72;

	private TabPage tabPage_11;

	private Label label_73;

	private PictureBox pictureBox_0;

	private PictureBox pictureBox_1;

	private CheckBox checkBox_68;

	private TextBox textBox_32;

	private Label label_74;

	private Label label_75;

	private TabPage tabPage_12;

	private Label label_76;

	private CheckBox checkBox_69;

	private CheckBox checkBox_70;

	private Label label_77;

	private Button button_52;

	private Button button_53;

	private Button button_54;

	private TextBox textBox_33;

	private Button button_55;

	private Button button_56;

	private Button button_57;

	private Button button_58;

	private DataGridView dataGridView_24;

	private DataGridView dataGridView_25;

	private DataGridView dataGridView_26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;

	private DataGridView dataGridView_27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;

	private Label label_78;

	private Label label_79;

	private TextBox textBox_34;

	private Label label_80;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;

	private Button button_59;

	private Label label_81;

	private ComboBox comboBox_18;

	private Label label_82;

	private TextBox textBox_35;

	private Label label_83;

	private Label label_84;

	private Label label_85;

	private Label label_86;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;

	private Label label_87;

	private TextBox textBox_36;

	private TextBox textBox_37;

	private Button button_60;

	private Button button_61;

	private Label label_88;

	private Label label_89;

	private Label label_90;

	private TextBox textBox_38;

	private CheckBox checkBox_71;

	private Label label_91;

	private TextBox textBox_39;

	private CheckBox checkBox_72;

	private Label label_92;

	private CheckBox checkBox_73;

	private CheckBox checkBox_74;

	private TextBox textBox_40;

	private TextBox textBox_41;

	private Label label_93;

	private Label label_94;

	private Label label_95;

	private Label label_96;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_68;

	private TabPage tabPage_13;

	private DateTimePicker dateTimePicker_4;

	private Label label_97;

	private ComboBox comboBox_19;

	private Label label_98;

	private Label label_99;

	private TextBox textBox_42;

	private RadioButton radioButton_25;

	private RadioButton radioButton_26;

	private CheckBox checkBox_75;

	private CheckBox checkBox_76;

	private PictureBox pictureBox_2;

	private CheckBox checkBox_77;

	private Label label_100;

	private TextBox textBox_43;

	private RadioButton radioButton_27;

	private RadioButton radioButton_28;

	private DateTimePicker dateTimePicker_5;

	private Label label_101;

	private Label label_102;

	private Label label_103;

	private ComboBox comboBox_20;

	private GroupBox groupBox_3;

	private GroupBox groupBox_4;

	private ComboBox comboBox_21;

	private Button button_62;

	private Button button_63;

	private DateTimePicker dateTimePicker_6;

	private Label label_104;

	private DateTimePicker dateTimePicker_7;

	private Label label_105;

	private DateTimePicker dateTimePicker_8;

	private Label label_106;

	private CheckBox checkBox_78;

	private CheckBox checkBox_79;

	private Label label_107;

	private TextBox textBox_44;

	private Label label_108;

	private TabPage tabPage_14;

	private Button button_64;

	private Label label_109;

	private Button button_65;

	private Label label_110;

	private CheckBox checkBox_80;

	private Button button_66;

	private Label label_111;

	private Label label_112;

	private Label label_113;

	private TextBox textBox_45;

	private ComboBox comboBox_22;

	private Label label_114;

	private TextBox textBox_46;

	private Button button_67;

	private RichTextBox richTextBox_0;

	private RichTextBox richTextBox_1;

	private Button button_68;

	private Label label_115;

	private GroupBox groupBox_5;

	private RadioButton radioButton_29;

	private RadioButton radioButton_30;

	private TextBox textBox_47;

	private TextBox textBox_48;

	private RadioButton radioButton_31;

	private Button button_69;

	private CheckBox checkBox_81;

	private CheckBox checkBox_82;

	private Label label_117;


	private Button button_70;

	private DataGridView dataGridView_28;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_69;


	private Label label_118;


	private TextBox textBox_50;

	private TabPage tabPage_15;

	private CheckBox checkBox_83;

	private Label label_119;

	private Label label_120;

	private Label label_121;

	private ComboBox comboBox_23;

	private DataGridView dataGridView_29;

	private Label label_122;

	private TextBox textBox_51;

	private TextBox textBox_52;

	private TextBox textBox_53;

	private Label label_123;

	private Label label_124;

	private Label label_125;

	private Label label_126;

	private Button button_73;

	private Button button_74;

	private Button button_75;

	private TextBox textBox_54;

	private Label label_127;

	private Label label_128;

	private Button button_76;

	private CheckBox checkBox_84;

	private Label label_129;

	private TextBox textBox_55;

	private TextBox textBox_56;

	private Label label_130;

	private Label label_131;

	private CheckBox checkBox_85;

	private Label label_132;

	private CheckBox checkBox_86;

	private CheckBox checkBox_87;

	private ComboBox comboBox_24;

	private Button button_77;

	private ComboBox comboBox_25;

	private Label label_133;

	private CheckBox checkBox_88;

	private TextBox textBox_57;

	private Button button_78;

	private TabPage tabPage_16;

	private TrackBar trackBar_2;

	private Label label_134;

	private CheckBox checkBox_89;

	private CheckBox checkBox_90;

	private CheckBox checkBox_91;

	private CheckBox checkBox_92;

	private RadioButton radioButton_32;

	private Label label_135;

	private NumericUpDown numericUpDown_0;

	private Label label_136;

	private CheckBox checkBox_93;

	private CheckBox checkBox_94;

	private CheckBox checkBox_95;

	private CheckBox checkBox_96;

	private TabPage tabPage_17;

	private DataGridView dataGridView_30;

	private Button button_79;

	private Button button_80;

	private Button button_81;

	private TextBox textBox_58;

	private TextBox textBox_59;

	private TextBox textBox_60;

	private Label label_137;

	private CheckBox checkBox_97;

	private Label label_138;

	private Label label_139;

	private Label label_140;

	private Label label_141;

	private ComboBox comboBox_26;

	private Label label_142;

	private TextBox textBox_61;

	private CheckBox checkBox_98;

	private Button button_82;


	private CheckBox checkBox_100;

	private TextBox textBox_62;

	private CheckBox checkBox_101;

	private CheckBox checkBox_102;

	private CheckBox checkBox_103;

	private CheckBox checkBox_104;

	private TextBox textBox_63;

	private Label label_143;

	private Button button_83;

	private Button button_84;

	private ComboBox comboBox_27;

	private ComboBox comboBox_28;

	private ComboBox comboBox_29;

	private ComboBox comboBox_30;

	private Panel panel_0;

	private Panel panel_1;

	private Label label_144;

	private Label label_145;

	private Panel panel_2;

	private Label label_146;

	private Label label_147;

	private Panel panel_3;

	private Label label_148;

	private Label label_149;

	private Panel panel_4;

	private Label label_150;

	private Label label_151;

	private Panel panel_5;

	private Label label_152;

	private Label label_153;

	private Panel panel_6;

	private Label label_154;

	private Label label_155;

	private Panel panel_7;

	private Label label_156;

	private Label label_157;

	private Panel panel_8;

	private Label label_158;

	private Label label_159;

	private Panel panel_9;

	private Label label_160;

	private Label label_161;

	private Panel panel_10;

	private Label label_162;

	private Label label_163;

	private Panel panel_11;

	private Label label_164;

	private Label label_165;

	private Panel panel_12;

	private Label label_166;

	private Label label_167;

	private Button button_85;

	private Button button_86;

	private Button button_87;

	private TextBox textBox_64;

	private RadioButton radioButton_33;

	private Button button_88;

	private TextBox textBox_65;

	private Button button_89;

	private Button button_90;

	private CheckBox checkBox_105;

	private Label label_168;

	private TrackBar trackBar_3;

	private Panel panel_13;

	private RadioButton radioButton_34;

	private RadioButton radioButton_35;

	private string string_0;

	private Struct137 struct137_0;

	private Struct1 struct1_0;

	private System.Windows.Forms.Timer timer_0;

	private readonly Class181 class181_0 = new Class181();

	private static readonly Color color_2 = Color.FromArgb(128, 255, 128);

	private static readonly Color color_3 = Color.FromArgb(255, 128, 128);

	private readonly Class4 class4_0 = new Class4();

	private bool bool_11;

	private float float_0;

	private float float_1;

	private int int_0;

	internal Action<string> action_1;

	internal Func<int, Task> func_1;

	private bool bool_12;

	private List<DataGridViewRow> list_0;

	private int int_1 = -1;

	private bool bool_13;

	private Form7 form7_1;

	private string string_1;

	private Form2 form2_0;

	private System.Windows.Forms.Timer timer_1;

	private int int_2;

	private Task task_3 = Task.CompletedTask;

	private int int_3;

	internal Func<Task<bool>> func_2;

	private readonly object object_1 = new object();

	private readonly HashSet<string> hashSet_1 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

	private readonly HashSet<string> hashSet_2 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

	private Form3 form3_0;

	private System.Windows.Forms.Timer timer_2;

	private Class64 class64_0;

	private readonly Class102 class102_0 = new Class102();

	private long long_5;

	private long long_6 = -1000L;

	private long long_7 = -1000L;

	private readonly Stopwatch stopwatch_0 = Stopwatch.StartNew();

	private long long_8 = -1000L;

	private long long_9 = -1000L;

	private long long_10 = -1000L;

	private int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private long long_11 = -30000L;

	private long long_12 = -1L;

	private long long_13 = -1L;

	private readonly bool[] bool_14 = new bool[11];

	private long long_14 = -1L;

	private Class119 class119_2;

	private bool bool_15;

	private int int_8;

	private string string_2 = string.Empty;

	private int int_9;

	private string string_3 = string.Empty;

	private string string_4;

	private Label[] label_169;

	private Label[] label_170;

	private string[] string_5;

	private bool bool_16;

	private bool bool_17;

	private Class119 class119_3;

	private long long_15;

	private bool bool_18;

	private bool bool_19;

	private int int_10;

	private float float_2;

	private float float_3;

	private float float_4;

	private readonly Class390 class390_0 = new Class390();

	private Class119 class119_4;

	private bool bool_20;

	private int int_11 = -1;

	private float float_5;

	private float float_6;

	private string string_7;

	private bool bool_22;

	public GForm0()
	{
		method_27();
		method_29();
		Text = Class135.smethod_4();
		button_88.Click += button_88_Click;
		button_89.Click += button_89_Click;
		button_90.Click += button_90_Click;
		checkBox_0 = new CheckBox[10] { checkBox_8, checkBox_1, checkBox_9, checkBox_31, checkBox_30, checkBox_29, checkBox_28, checkBox_27, checkBox_26, checkBox_25 };
		gclass12_0 = GClass12.smethod_0(tabControl_0, Color.FromArgb(255, 128, 128), Color.FromArgb(255, 128, 128), 86, 49, 139, 23, tabControl_0, 0);
		gclass12_1 = GClass12.smethod_0(tabControl_0, Color.LightSkyBlue, Color.LightSkyBlue, 86, 76, 139, 23, tabControl_0, 0);
		gclass12_2 = GClass12.smethod_0(tabControl_0, Color.FromArgb(128, 255, 128), Color.FromArgb(128, 255, 128), 86, 104, 139, 23, tabControl_0, 0);
		gclass12_3 = GClass12.smethod_0(tabControl_0, Color.FromArgb(255, 255, 192), Color.FromArgb(255, 255, 192), 86, 28, 117, 15, tabControl_0, 0);
		gclass12_4 = GClass12.smethod_0(tabControl_0, Color.FromArgb(255, 255, 192), Color.FromArgb(255, 255, 192), 40, 107, 237, 23, tabControl_0, 7);
		base.Size = size_0;
	}

	private static string smethod_0()
	{
		string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");
		try
		{
			Directory.CreateDirectory(text);
		}
		catch (IOException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
		return text;
	}

	private string method_0()
	{
		string text = ((class67_0 == null) ? null : class67_0.method_1());
		if (string.IsNullOrEmpty(text))
		{
			text = "FollowPath";
		}
		return text + ".FollowPath";
	}

	private bool method_1()
	{
		try
		{
			return method_127() && Class131.smethod_1() && this.smethod_6(5).GetAwaiter().GetResult();
		}
		catch (Exception ex)
		{
			method_2("toggle unavailable: " + ex.Message);
			return false;
		}
	}

	private void method_2(string string_8)
	{
		try
		{
			string text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + " " + string_8;
			File.AppendAllText(Path.Combine(Class363.smethod_0(), "auto.log"), text + Environment.NewLine);
		}
		catch (IOException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
	}

	internal bool method_3()
	{
		return bool_8;
	}

	internal bool method_4()
	{
		if (method_91() != (Enum11)1)
		{
			return bool_3;
		}
		return bool_6;
	}

	internal Class145 method_5()
	{
		Class119 @class = Volatile.Read(ref class119_0);
		if (@class != null)
		{
			return @class.method_51();
		}
		return Class145.class145_0;
	}

	internal bool method_6()
	{
		return Volatile.Read(ref class119_0)?.method_10() ?? false;
	}

	internal Class119 method_7()
	{
		return Volatile.Read(ref class119_0);
	}

	private Class119 method_8(Class119 class119_5)
	{
		lock (object_0)
		{
			long_0++;
			Class119 @class = Interlocked.Exchange(ref class119_0, class119_5);
			if (@class != null)
			{
				method_36();
			}
			string_0 = null;
			method_102();
			if (base.IsHandleCreated && !base.IsDisposed)
			{
				method_28();
			}
			return @class;
		}
	}

	private bool method_9(out Class119 class119_5, out long long_16)
	{
		lock (object_0)
		{
			class119_5 = Volatile.Read(ref class119_0);
			long_16 = long_0;
			return !bool_0;
		}
	}

	private bool method_10(Class119 class119_5, long long_16)
	{
		lock (object_0)
		{
			return !bool_0 && long_16 == long_0 && class119_5 == Volatile.Read(ref class119_0);
		}
	}

	private Task<T> method_11<T>(string string_8, Class119 class119_5, long long_16, Func<Class119, T> func_3)
	{
		Class154<T> @class = new Class154<T>();
		@class.func_0 = func_3;
		@class.class119_0 = class119_5;
		@class.string_0 = string_8;
		if (@class.func_0 == null)
		{
			throw new ArgumentNullException("operation");
		}
		Task<T> task;
		lock (object_0)
		{
			Class162<T> class2 = new Class162<T>();
			class2.class154_0 = @class;
			if (bool_0 || class2.class154_0.class119_0 == null || long_16 != long_0 || class2.class154_0.class119_0 != Volatile.Read(ref class119_0))
			{
				return null;
			}
			class2.func_0 = func_0;
			task = Task.Run((Func<T>)class2.method_0);
			hashSet_0.Add(task);
		}
		task.ContinueWith(method_12, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
		return task;
	}

	private void method_12(Task task_4)
	{
		lock (object_0)
		{
			hashSet_0.Remove(task_4);
		}
	}

	private void method_13()
	{
		lock (object_0)
		{
			if (!bool_0)
			{
				bool_0 = true;
				long_0++;
				class119_1 = Interlocked.Exchange(ref class119_0, null);
				string_0 = null;
				method_102();
				task_0 = new Task[hashSet_0.Count];
				hashSet_0.CopyTo(task_0);
			}
		}
	}

	internal Class148 method_14()
	{
		return class148_0;
	}

	internal void method_15(Class148 class148_1)
	{
		class148_1.method_7();
		bool_3 = true;
	}

	private Enum0 method_16()
	{
		if (bool_2)
		{
			return Enum0.Started;
		}
		if (bool_1)
		{
			return Enum0.Selected;
		}
		Class119 @class = Volatile.Read(ref class119_0);
		if (@class != null && @class.method_10())
		{
			return Enum0.Attached;
		}
		return Enum0.Idle;
	}

	internal static string smethod_1(string string_8)
	{
		if (string_8 == null)
		{
			return string.Empty;
		}
		if (!bool_10)
		{
			return string_8;
		}
		string text = string_8.Trim();
		if (text.Length != 0 && text[0] == '{')
		{
			JObject jObject;
			try
			{
				jObject = JObject.Parse(text);
			}
			catch (JsonException)
			{
				return string_8;
			}
			JToken jToken = jObject["t"];
			string text2 = ((jToken == null || jToken.Type != JTokenType.String) ? null : ((string?)jToken));
			if (text2 != "moved" && text2 != "pick" && text2 != "buff_cast")
			{
				return null;
			}
			return jObject.ToString(Formatting.None);
		}
		return string_8;
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		class14_0 = new Class14(this);
		class14_0.method_0();
		class190_0 = new Class190(textBox_6, button_11, comboBox_0, comboBox_27, button_84, button_83);
		class190_0.action_1 = method_137;
		class190_0.method_2();
		discordNotifier_0 = new DiscordNotifier(method_2);
		discordNotifier_0.Load();
		try
		{
			class363_0 = new Class363(Class363.smethod_0(), method_2, method_138);
			class363_0.Discord = discordNotifier_0;
			Class114 @class = new Class114
			{
				bool_0 = Class131.smethod_1(),
				double_0 = Class131.smethod_4(),
				double_1 = Class131.smethod_5(),
				double_2 = Class131.smethod_6(),
				double_3 = Class131.smethod_7()
			};
			Class136 interface5_ = new Class136(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Class131.smethod_8()), method_2);
			Class28 interface5_2 = null;
			Action<string, uint, string, double> action_ = null;
			bool flag = Class131.smethod_9();
			if (Class131.smethod_2() || flag)
			{
				if (flag)
				{
					method_2("KLX fallback predictor armed (answer-always on OneOCR below-gate)");
				}
				try
				{
					interface5_2 = new Class28(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Vision", Class131.smethod_3()), Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Class131.smethod_8()), method_2);
					action_ = method_139;
				}
				catch (Exception ex)
				{
					method_2("[Challenge] shadow predictor unavailable: " + ex.Message);
				}
			}
			Class351 class351_ = new Class351(interface5_, method_140, method_141, method_142, @class, method_2, method_1, interface5_2, action_, flag);
			class363_0.method_1(class351_);
			if (@class.bool_0)
			{
				method_2("auto-answer armed (min-confidence " + @class.double_0.ToString("0.0") + ")");
			}
		}
		catch (Exception)
		{
		}
		tabPage_9.Controls.Add(new Label
		{
			Name = "challengeDisclosure",
			Location = new Point(306, 5),
			Size = new Size(320, 68),
			Text = "ภาพยืนยันตัวตน ผลการตรวจสอบ และชื่อตัวละครเก็บไว้ในเครื่อง — ถ้าติ๊ก \"ใช้งาน Discord - แจ้งเตือน\" ภาพ captcha + ชื่อตัวละครจะถูกส่งไปที่ webhook ที่ใส่ไว้ด้วย"
		});
		Class119 class2 = new Class119();
		class2.synchronizationContext_0 = SynchronizationContext.Current;
		class2.method_1(class363_0);
		Class119 class3 = class2;
		class3.method_2(method_144);
		class3.method_62(Class151.class151_0.method_0);
		class3.method_64(Class151.class151_0.method_1);
		class3.method_52(method_109);
		class3.method_4(method_20);
		method_30(class3);
		method_8(class3);
		color_0 = button_12.BackColor;
		color_1 = button_12.ForeColor;
		bool_9 = button_12.UseVisualStyleBackColor;
		method_24();
		button_12.Enabled = true;
		button_33.Enabled = true;
		button_2.Enabled = false;
		button_1.Enabled = false;
		class11_0 = new Class11("Setting.ini");
		// checkBox53/textBox36 = Discord switch + webhook URL: kept in discord.json (DiscordNotifier), not in the per-hero ini
		class11_0.method_3().UnionWith(new string[8] { "checkBox37", "checkBox2", "checkBox42", "comboBox1", "comboBox23", "textBox3", "checkBox53", "textBox36" });
		for (int i = 1; i <= 6; i++)
		{
			string item = i.ToString(CultureInfo.InvariantCulture);
			comboBox_28.Items.Add(item);
			comboBox_30.Items.Add(item);
			comboBox_29.Items.Add(item);
		}
		textBox_2.Leave += textBox_0_Leave;
		textBox_1.Leave += textBox_0_Leave;
		textBox_0.Leave += textBox_0_Leave;
		class11_0.method_7(this);
		SetupDiscordNotify();
		checkBox_35.CheckedChanged += checkBox_35_CheckedChanged;
		checkBox_34.CheckedChanged += checkBox_34_CheckedChanged;
		method_28();
		class67_0 = new Class67();
		class67_0.method_6(dataGridView_28, "all_monster_found.json", bool_0: false);
		class67_0.method_6(dataGridView_2, "all_items_used.json", bool_0: false);
		class67_0.method_6(dataGridView_19, "all_player_found.json", bool_0: false);
		Class440.smethod_0(dataGridView_0);
		class67_0.method_7(dataGridView_0, "POS.json");
		class67_0.method_7(dataGridView_1, "Pick_Item.json");
		class67_0.method_7(dataGridView_20, "Player_Select.json");
		class67_0.method_7(dataGridView_25, "Want_Sell.json");
		class67_0.method_7(dataGridView_24, "Want_Buy.json");
		class67_0.method_7(dataGridView_21, "Buy_Item_Plan.json");
		for (int j = 51; j <= 66; j++)
		{
			DataGridView dataGridView = this.smethod_30("dataGridView" + j);
			if (dataGridView != null)
			{
				class67_0.method_7(dataGridView, "Route_" + j + ".json");
			}
		}
		method_37();
	}

	private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		TabPage selectedTab = tabControl_0.SelectedTab;
		if (selectedTab != tabPage_12 && selectedTab != tabPage_8 && selectedTab != tabPage_1 && selectedTab != tabPage_6 && selectedTab != tabPage_10 && selectedTab != tabPage_15)
		{
			base.Size = size_0;
		}
		else
		{
			base.Size = size_1;
		}
	}

	private async void GForm0_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (method_3())
		{
			return;
		}
		e.Cancel = true;
		method_13();
		try
		{
			long num = ((class148_0 == null) ? 0L : class148_0.method_0());
			await method_52(Class8.smethod_0(num));
		}
		catch (Exception)
		{
			try
			{
				await method_62();
			}
			catch (Exception)
			{
			}
		}
		finally
		{
			bool_8 = true;
			try
			{
				if (class363_0 != null)
				{
					class363_0.method_0()?.Dispose();
					await class363_0.method_12();
				}
			}
			catch (Exception)
			{
			}
			Close();
		}
	}

	private async void method_20(int int_12)
	{
		method_36();
		string_0 = null;
		method_102();
		method_28();
		try
		{
			long num = ((class148_0 == null) ? 0L : class148_0.method_0());
			await method_52(Class8.smethod_1(num, int_12));
		}
		catch (Exception)
		{
		}
	}

	private async void method_21(Class85 class85_0)
	{
		long long_ = ++long_4;
		enum3_0 = Enum3.Unknown;
		method_24();
		if (class85_0 != null && !string.IsNullOrEmpty(class85_0.string_1))
		{
			Class82 @class = await method_23(class85_0, long_);
			if (method_22(class85_0, long_))
			{
				enum3_0 = @class.enum3_0;
				method_24();
			}
		}
	}

	private bool method_22(Class85 class85_0, long long_16)
	{
		if (!base.IsDisposed && class190_0 != null)
		{
			return smethod_2(class190_0.method_0(), class85_0, long_4, long_16);
		}
		return false;
	}

	internal static bool smethod_2(Class85 class85_0, Class85 class85_1, long long_16, long long_17)
	{
		if (class85_0 == class85_1)
		{
			return long_16 == long_17;
		}
		return false;
	}

	private async Task<Class82> method_23(Class85 class85_0, long long_16)
	{
		Class165 class165_ = new Class165
		{
			class85_0 = class85_0
		};
		Class82 @class = null;
		Stopwatch stopwatch = Stopwatch.StartNew();
		for (int i = 0; i < 4; i++)
		{
			Class150 class2 = new Class150
			{
				class165_0 = class165_,
				int_0 = 15000 - (int)stopwatch.ElapsedMilliseconds
			};
			if (class2.int_0 > 0)
			{
				try
				{
					@class = await Task.Run((Func<Class82>)class2.method_0);
				}
				catch (Exception ex)
				{
					@class = new Class82(Enum3.Unknown, "runner check failed: " + ex.Message);
				}
				if (!method_22(class2.class165_0.class85_0, long_16) || @class.enum3_0 != Enum3.Unknown || i == 3)
				{
					break;
				}
				class2.int_0 = 15000 - (int)stopwatch.ElapsedMilliseconds;
				if (class2.int_0 <= 0)
				{
					break;
				}
				await Task.Delay(Math.Min(500, class2.int_0));
				continue;
			}
			return new Class82(Enum3.Unknown, "runner check deadline exceeded");
		}
		return @class;
	}

	private void method_24()
	{
		Struct31 @struct = Class392.smethod_0(enum3_0, method_16());
		button_12.Text = @struct.string_0;
		if (!@struct.bool_0)
		{
			button_12.BackColor = color_0;
			button_12.ForeColor = color_1;
			button_12.UseVisualStyleBackColor = bool_9;
			toolTip_0.SetToolTip(button_12, string.Empty);
		}
		else
		{
			button_12.BackColor = @struct.color_0;
			button_12.UseVisualStyleBackColor = false;
			toolTip_0.SetToolTip(button_12, @struct.string_1);
		}
	}

	private void dataGridView_28_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			object value = dataGridView_28.Rows[e.RowIndex].Cells[0].Value;
			if (value != null)
			{
				this.smethod_24(54, value.ToString());
			}
		}
	}

	private void dataGridView_22_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void dataGridView_29_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void dataGridView_29_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
	}

	private async void button_2_Click(object sender, EventArgs e)
	{
		try
		{
			await method_49(bool_23: true);
		}
		catch (Exception)
		{
			if (method_9(out var _, out var _))
			{
				Class429.smethod_0(this, "Start failed - see the debug log.", "Start");
			}
		}
	}

	private async void button_1_Click(object sender, EventArgs e)
	{
		try
		{
			await method_51(bool_23: false);
		}
		catch (Exception)
		{
			if (method_9(out var _, out var _))
			{
				Class429.smethod_0(this, "Stop failed - see the debug log.", "Stop");
			}
		}
	}

	private void button_4_Click(object sender, EventArgs e)
	{
		Class145 @class = ((class119_0 == null) ? null : class119_0.method_51());
		if (@class != null && @class.method_0() != null)
		{
			Class83 class2 = @class.method_0();
			string[] array = Class440.smethod_8(new Struct76
			{
				float_0 = class2.float_0,
				float_1 = class2.float_1,
				float_2 = class2.float_2,
				int_0 = Class440.smethod_1(checkBox_104.Checked, textBox_63.Text),
				bool_0 = checkBox_103.Checked
			});
			using (class67_0.method_17(dataGridView_0))
			{
				dataGridView_0.Rows.Add(array[0], array[1], array[2], Class440.smethod_7(array[3]), array[4]);
			}
		}
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		List<DataGridViewRow> list = new List<DataGridViewRow>();
		foreach (DataGridViewRow selectedRow in dataGridView_0.SelectedRows)
		{
			if (!selectedRow.IsNewRow)
			{
				list.Add(selectedRow);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			dataGridView_0.Rows.Remove(list[i]);
		}
	}

	private void button_14_Click(object sender, EventArgs e)
	{
		List<string[]> list = new List<string[]>();
		for (int i = 0; i < dataGridView_0.Rows.Count; i++)
		{
			DataGridViewRow dataGridViewRow = dataGridView_0.Rows[i];
			if (!dataGridViewRow.IsNewRow)
			{
				string[] array = new string[5];
				for (int j = 0; j < 5; j++)
				{
					array[j] = Convert.ToString(dataGridViewRow.Cells[j].Value, CultureInfo.InvariantCulture);
				}
				list.Add(array);
			}
		}
		if (list.Count == 0)
		{
			MessageBox.Show(this, "grid1 has no rows to save.", "Save FollowPath", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		string fileName;
		using (SaveFileDialog saveFileDialog = new SaveFileDialog())
		{
			saveFileDialog.Title = "Save FollowPath";
			saveFileDialog.Filter = "FollowPath (*.FollowPath)|*.FollowPath";
			saveFileDialog.DefaultExt = "FollowPath";
			saveFileDialog.InitialDirectory = smethod_0();
			saveFileDialog.FileName = method_0();
			if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}
			fileName = saveFileDialog.FileName;
		}
		string text = ((class67_0 == null) ? null : class67_0.method_1());
		string contents = Class440.smethod_12(list, text, DateTime.Now);
		try
		{
			File.WriteAllText(fileName, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		}
		catch (Exception ex)
		{
			MessageBox.Show(this, "Could not write " + fileName + ": " + ex.Message, "Save FollowPath", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void button_7_Click(object sender, EventArgs e)
	{
		Class388.smethod_0(dataGridView_2, dataGridView_1, class67_0);
	}

	private void button_13_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		string fileName;
		try
		{
			openFileDialog.Title = "Load FollowPath";
			openFileDialog.Filter = "FollowPath (*.FollowPath)|*.FollowPath";
			openFileDialog.InitialDirectory = smethod_0();
			if (openFileDialog.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}
			fileName = openFileDialog.FileName;
		}
		finally
		{
			((IDisposable)openFileDialog).Dispose();
		}
		string text;
		try
		{
			text = File.ReadAllText(fileName, Encoding.UTF8);
		}
		catch (Exception ex)
		{
			MessageBox.Show(this, "Could not read " + fileName + ": " + ex.Message, "Load FollowPath", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		int num;
		List<string[]> list = Class440.smethod_13(text, out num);
		if (list == null)
		{
			MessageBox.Show(this, "Not a valid FollowPath file: " + fileName, "Load FollowPath", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		using (class67_0.method_17(dataGridView_0))
		{
			dataGridView_0.Rows.Clear();
			for (int i = 0; i < list.Count; i++)
			{
				string[] array = list[i];
				dataGridView_0.Rows.Add(array[0], array[1], array[2], Class440.smethod_7(array[3]), array[4]);
			}
		}
		if (num > 0)
		{
			MessageBox.Show(this, "Loaded " + list.Count + " rows, skipped " + num + " rows without a usable X or Z.", "Load FollowPath", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private async void button_33_Click(object sender, EventArgs e)
	{
		if (bool_1 || !method_9(out var class119_, out var long_))
		{
			return;
		}
		button_33.Enabled = false;
		try
		{
			bool flag = await method_68(class119_, long_);
			if (!method_10(class119_, long_))
			{
				return;
			}
			bool_1 = flag;
			if (flag)
			{
				method_31();
				this.smethod_25(10, trackBar_0.Value.ToString());
				method_26();
				if (timer_2 == null)
				{
					timer_2 = new System.Windows.Forms.Timer
					{
						Interval = 100
					};
					timer_2.Tick += method_108;
				}
				this.smethod_1(51, 66);
				button_2.Enabled = true;
				button_4.Enabled = true;
				button_3.Enabled = true;
				button_14.Enabled = true;
				button_13.Enabled = true;
				button_12.Enabled = false;
				button_34.Enabled = true;
				button_15.Enabled = true;
				button_16.Enabled = true;
				button_1.Enabled = false;
			}
			else
			{
				button_33.Enabled = true;
				button_12.Enabled = class119_ == null || !class119_.method_10();
			}
			method_107(method_16());
			method_25();
			method_24();
		}
		catch (Exception)
		{
			if (method_10(class119_, long_))
			{
				button_33.Enabled = true;
				Class429.smethod_0(this, "Select failed - see the debug log.", "Select");
			}
		}
	}


	private void button_6_Click(object sender, EventArgs e)
	{
		Class388.smethod_0(dataGridView_1, dataGridView_2, class67_0);
	}

	private void button_5_Click(object sender, EventArgs e)
	{
	}

	private void button_9_Click(object sender, EventArgs e)
	{
	}

	private void button_8_Click(object sender, EventArgs e)
	{
		if (class67_0 != null)
		{
			class67_0.method_10(dataGridView_2);
		}
		Class388.smethod_1(dataGridView_2, dataGridView_1, class67_0);
	}

	private void button_10_Click(object sender, EventArgs e)
	{
		Class388.smethod_2(dataGridView_2, class67_0);
	}

	private void button_11_Click(object sender, EventArgs e)
	{
	}

	private async void button_12_Click(object sender, EventArgs e)
	{
		try
		{
			await method_67();
		}
		catch (Exception)
		{
			if (method_9(out var _, out var _))
			{
				Class429.smethod_0(this, "Run failed - see the debug log.", "Run");
			}
		}
	}

	private void button_34_Click(object sender, EventArgs e)
	{
		method_42();
	}

	private void button_36_Click(object sender, EventArgs e)
	{
		method_104(9);
	}

	private void button_35_Click(object sender, EventArgs e)
	{
		method_104(10);
	}

	private void button_87_Click(object sender, EventArgs e)
	{
		Class159 @class = new Class159();
		@class.gform0_0 = this;
		if (method_9(out @class.class119_0, out @class.long_0) && @class.class119_0 != null && @class.class119_0.method_28() && bool_1)
		{
			Form4 form = new Form4(@class.method_0);
			try
			{
				if (form.ShowDialog(this) == DialogResult.OK && method_10(@class.class119_0, @class.long_0) && @class.class119_0.method_28())
				{
					textBox_64.Text = form.method_0();
					radioButton_33.Checked = true;
				}
				return;
			}
			finally
			{
				((IDisposable)form).Dispose();
			}
		}
		Class429.smethod_0(this, "Press Select and wait for the player census.", "Follow player");
	}

	private void button_38_Click(object sender, EventArgs e)
	{
	}

	private void button_39_Click(object sender, EventArgs e)
	{
	}

	private void button_40_Click(object sender, EventArgs e)
	{
		if (class67_0 != null)
		{
			class67_0.method_10(dataGridView_19);
		}
	}

	private void button_41_Click(object sender, EventArgs e)
	{
	}

	private void button_42_Click(object sender, EventArgs e)
	{
	}

	private void button_43_Click(object sender, EventArgs e)
	{
	}

	private void button_37_Click(object sender, EventArgs e)
	{
	}

	private void button_45_Click(object sender, EventArgs e)
	{
		dataGridView_0.Rows.Clear();
	}

	private void button_16_Click(object sender, EventArgs e)
	{
		method_43();
	}

	private void button_15_Click(object sender, EventArgs e)
	{
		method_44();
	}

	private void button_51_Click(object sender, EventArgs e)
	{
	}

	private void button_59_Click(object sender, EventArgs e)
	{
	}

	private void button_61_Click(object sender, EventArgs e)
	{
	}

	private void button_52_Click(object sender, EventArgs e)
	{
	}

	private void button_53_Click(object sender, EventArgs e)
	{
	}

	private void button_54_Click(object sender, EventArgs e)
	{
	}

	private void button_56_Click(object sender, EventArgs e)
	{
	}

	private void button_58_Click(object sender, EventArgs e)
	{
	}

	private void button_57_Click(object sender, EventArgs e)
	{
	}

	private void button_55_Click(object sender, EventArgs e)
	{
	}

	private void button_60_Click(object sender, EventArgs e)
	{
	}

	private void button_62_Click(object sender, EventArgs e)
	{
	}

	private void button_63_Click(object sender, EventArgs e)
	{
	}

	private void button_64_Click(object sender, EventArgs e)
	{
	}

	private void button_65_Click(object sender, EventArgs e)
	{
	}

	private void button_66_Click(object sender, EventArgs e)
	{
	}

	private void button_67_Click(object sender, EventArgs e)
	{
	}

	private void button_68_Click(object sender, EventArgs e)
	{
	}

	private void button_69_Click(object sender, EventArgs e)
	{
	}

	private void button_70_Click(object sender, EventArgs e)
	{
		if (class67_0 != null)
		{
			class67_0.method_10(dataGridView_28);
		}
	}



	private void button_75_Click(object sender, EventArgs e)
	{
	}

	private void button_74_Click(object sender, EventArgs e)
	{
	}

	private void button_73_Click(object sender, EventArgs e)
	{
	}

	private void button_76_Click(object sender, EventArgs e)
	{
	}

	private void button_77_Click(object sender, EventArgs e)
	{
	}

	private void button_78_Click(object sender, EventArgs e)
	{
	}

	private void button_82_Click(object sender, EventArgs e)
	{
	}

	private void button_88_Click(object sender, EventArgs e)
	{
		if (form7_0 != null)
		{
			form7_0.Activate();
			return;
		}
		form7_0 = new Form7(null, null, method_145);
		form7_0.Text = "Pet Card";
		form7_0.FormClosed += form7_0_FormClosed;
		form7_0.Show(this);
		form7_0.method_0(method_5());
		long_14 = -1L;
	}

	private void form7_0_FormClosed(object sender, FormClosedEventArgs e)
	{
		form7_0.FormClosed -= form7_0_FormClosed;
		form7_0 = null;
	}

	private void button_79_Click(object sender, EventArgs e)
	{
	}

	private void button_80_Click(object sender, EventArgs e)
	{
	}

	private void button_81_Click(object sender, EventArgs e)
	{
	}

	private void checkBox_32_CheckedChanged(object sender, EventArgs e)
	{
		method_118();
	}

	private void checkBox_33_CheckedChanged(object sender, EventArgs e)
	{
		if (!checkBox_33.Checked)
		{
			return;
		}
		if (!bool_1)
		{
			checkBox_33.Checked = false;
			Class429.smethod_0(this, "กด Select ก\u0e48อนใช\u0e49งาน", "AutoClick");
			return;
		}
		try
		{
			Form1 form = new Form1();
			try
			{
				form.ShowDialog(this);
			}
			finally
			{
				((IDisposable)form).Dispose();
			}
		}
		finally
		{
			checkBox_33.Checked = false;
		}
	}

	private void checkBox_14_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox_13_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox_12_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox_11_CheckedChanged(object sender, EventArgs e)
	{
		struct67_0.bool_0 = checkBox_11.Checked;
		method_25();
	}

	private void method_25()
	{
		if (class119_0 != null)
		{
			switch (Class61.smethod_0(struct67_0, struct139_0, method_16(), class119_0.method_115()))
			{
			case (Enum12)2:
				class119_0.method_117();
				struct139_0.bool_0 = false;
				break;
			case (Enum12)1:
				class119_0.method_116();
				struct139_0.bool_0 = true;
				break;
			}
			method_32();
		}
	}

	private void checkBox_10_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox_46_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox_45_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox_53_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox_49_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox_50_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox_73_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox_90_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox_89_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void comboBox_22_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void trackBar_0_Scroll(object sender, EventArgs e)
	{
		this.smethod_25(10, trackBar_0.Value.ToString());
		method_118();
	}

	private void trackBar_1_Scroll(object sender, EventArgs e)
	{
		method_26();
	}

	private void method_26()
	{
		label_70.Text = trackBar_1.Value + " %";
	}

	private void trackBar_2_Scroll(object sender, EventArgs e)
	{
	}

	private void textBox_5_TextChanged(object sender, EventArgs e)
	{
	}

	private void textBox_12_TextChanged(object sender, EventArgs e)
	{
	}

	private void textBox_57_TextChanged(object sender, EventArgs e)
	{
	}

	private void textBox_33_TextChanged(object sender, EventArgs e)
	{
	}


	private void tabPage_3_Click(object sender, EventArgs e)
	{
	}

	private void tabPage_6_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_27()
	{
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle49 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle50 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle51 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle52 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle53 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle54 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		checkBox_1 = new CheckBox();
		checkBox_2 = new CheckBox();
		tabPage_0 = new TabPage();
		label_142 = new Label();
		textBox_61 = new TextBox();
		checkBox_98 = new CheckBox();
		checkBox_96 = new CheckBox();
		checkBox_40 = new CheckBox();
		radioButton_12 = new RadioButton();
		radioButton_10 = new RadioButton();
		radioButton_0 = new RadioButton();
		radioButton_1 = new RadioButton();
		radioButton_2 = new RadioButton();
		checkBox_3 = new CheckBox();
		checkBox_4 = new CheckBox();
		checkBox_5 = new CheckBox();
		checkBox_6 = new CheckBox();
		checkBox_7 = new CheckBox();
		label_0 = new Label();
		label_1 = new Label();
		tabPage_1 = new TabPage();
		panel_13 = new Panel();
		radioButton_34 = new RadioButton();
		radioButton_35 = new RadioButton();
		button_87 = new Button();
		textBox_64 = new TextBox();
		radioButton_33 = new RadioButton();
		label_143 = new Label();
		checkBox_103 = new CheckBox();
		checkBox_104 = new CheckBox();
		textBox_63 = new TextBox();
		checkBox_95 = new CheckBox();
		numericUpDown_0 = new NumericUpDown();
		label_136 = new Label();
		checkBox_93 = new CheckBox();
		checkBox_94 = new CheckBox();
		label_135 = new Label();
		radioButton_32 = new RadioButton();
		textBox_50 = new TextBox();
		label_118 = new Label();
		button_70 = new Button();
		dataGridView_28 = new DataGridView();
		dataGridViewTextBoxColumn_69 = new DataGridViewTextBoxColumn();
		checkBox_81 = new CheckBox();
		checkBox_82 = new CheckBox();
		label_92 = new Label();
		label_117 = new Label();
		label_108 = new Label();
		label_89 = new Label();
		label_91 = new Label();
		label_107 = new Label();
		label_90 = new Label();
		textBox_39 = new TextBox();
		textBox_44 = new TextBox();
		textBox_38 = new TextBox();
		checkBox_72 = new CheckBox();
		checkBox_71 = new CheckBox();
		checkBox_48 = new CheckBox();
		checkBox_79 = new CheckBox();
		checkBox_47 = new CheckBox();
		button_45 = new Button();
		label_2 = new Label();
		button_13 = new Button();
		button_14 = new Button();
		checkBox_32 = new CheckBox();
		dataGridView_0 = new DataGridView();
		dataGridViewTextBoxColumn_67 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_68 = new DataGridViewTextBoxColumn();
		button_3 = new Button();
		button_4 = new Button();
		trackBar_0 = new TrackBar();
		label_20 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		radioButton_11 = new RadioButton();
		radioButton_3 = new RadioButton();
		radioButton_4 = new RadioButton();
		radioButton_5 = new RadioButton();
		radioButton_6 = new RadioButton();
		checkBox_8 = new CheckBox();
		checkBox_9 = new CheckBox();
		checkBox_10 = new CheckBox();
		button_1 = new Button();
		button_2 = new Button();
		checkBox_11 = new CheckBox();
		tabPage_2 = new TabPage();
		label_168 = new Label();
		trackBar_3 = new TrackBar();
		checkBox_105 = new CheckBox();
		button_77 = new Button();
		comboBox_25 = new ComboBox();
		label_133 = new Label();
		comboBox_24 = new ComboBox();
		checkBox_87 = new CheckBox();
		checkBox_86 = new CheckBox();
		label_72 = new Label();
		checkBox_53 = new CheckBox();
		textBox_10 = new TextBox();
		label_33 = new Label();
		label_32 = new Label();
		comboBox_2 = new ComboBox();
		label_24 = new Label();
		label_132 = new Label();
		label_45 = new Label();
		label_31 = new Label();
		label_23 = new Label();
		checkBox_34 = new CheckBox();
		checkBox_35 = new CheckBox();
		label_5 = new Label();
		label_6 = new Label();
		label_7 = new Label();
		label_8 = new Label();
		label_9 = new Label();
		label_10 = new Label();
		radioButton_7 = new RadioButton();
		radioButton_8 = new RadioButton();
		radioButton_9 = new RadioButton();
		label_11 = new Label();
		label_12 = new Label();
		label_13 = new Label();
		checkBox_12 = new CheckBox();
		checkBox_13 = new CheckBox();
		checkBox_14 = new CheckBox();
		textBox_0 = new TextBox();
		textBox_1 = new TextBox();
		textBox_2 = new TextBox();
		label_14 = new Label();
		textBox_3 = new TextBox();
		textBox_4 = new TextBox();
		label_15 = new Label();
		label_16 = new Label();
		tabPage_3 = new TabPage();
		comboBox_29 = new ComboBox();
		comboBox_30 = new ComboBox();
		comboBox_28 = new ComboBox();
		checkBox_100 = new CheckBox();
		label_87 = new Label();
		textBox_13 = new TextBox();
		textBox_14 = new TextBox();
		textBox_15 = new TextBox();
		textBox_16 = new TextBox();
		textBox_17 = new TextBox();
		textBox_18 = new TextBox();
		button_35 = new Button();
		button_36 = new Button();
		label_17 = new Label();
		label_18 = new Label();
		label_29 = new Label();
		label_30 = new Label();
		label_21 = new Label();
		textBox_36 = new TextBox();
		textBox_37 = new TextBox();
		checkBox_15 = new CheckBox();
		checkBox_16 = new CheckBox();
		checkBox_17 = new CheckBox();
		checkBox_18 = new CheckBox();
		checkBox_19 = new CheckBox();
		checkBox_20 = new CheckBox();
		checkBox_21 = new CheckBox();
		checkBox_22 = new CheckBox();
		checkBox_23 = new CheckBox();
		checkBox_24 = new CheckBox();
		checkBox_25 = new CheckBox();
		checkBox_26 = new CheckBox();
		checkBox_27 = new CheckBox();
		checkBox_28 = new CheckBox();
		checkBox_29 = new CheckBox();
		checkBox_30 = new CheckBox();
		checkBox_31 = new CheckBox();
		label_28 = new Label();
		label_27 = new Label();
		tabControl_0 = new TabControl();
		tabPage_5 = new TabPage();
		checkBox_102 = new CheckBox();
		label_129 = new Label();
		textBox_55 = new TextBox();
		checkBox_73 = new CheckBox();
		label_74 = new Label();
		label_75 = new Label();
		textBox_32 = new TextBox();
		checkBox_68 = new CheckBox();
		checkBox_43 = new CheckBox();
		checkBox_38 = new CheckBox();
		label_26 = new Label();
		label_25 = new Label();
		textBox_9 = new TextBox();
		textBox_7 = new TextBox();
		checkBox_36 = new CheckBox();
		button_15 = new Button();
		button_34 = new Button();
		button_16 = new Button();
		button_18 = new Button();
		button_19 = new Button();
		button_20 = new Button();
		button_21 = new Button();
		button_22 = new Button();
		button_23 = new Button();
		button_24 = new Button();
		button_25 = new Button();
		button_26 = new Button();
		button_27 = new Button();
		button_28 = new Button();
		button_29 = new Button();
		button_30 = new Button();
		button_31 = new Button();
		button_32 = new Button();
		button_17 = new Button();
		dataGridView_15 = new DataGridView();
		dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
		dataGridView_16 = new DataGridView();
		dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
		dataGridView_3 = new DataGridView();
		dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		dataGridView_4 = new DataGridView();
		dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		dataGridView_5 = new DataGridView();
		dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
		dataGridView_17 = new DataGridView();
		dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
		dataGridView_6 = new DataGridView();
		dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
		dataGridView_7 = new DataGridView();
		dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
		dataGridView_8 = new DataGridView();
		dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
		dataGridView_18 = new DataGridView();
		dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
		dataGridView_9 = new DataGridView();
		dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
		dataGridView_10 = new DataGridView();
		dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
		dataGridView_11 = new DataGridView();
		dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
		dataGridView_12 = new DataGridView();
		dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
		dataGridView_13 = new DataGridView();
		dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
		dataGridView_14 = new DataGridView();
		dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
		tabPage_4 = new TabPage();
		button_63 = new Button();
		button_10 = new Button();
		label_19 = new Label();
		button_9 = new Button();
		button_8 = new Button();
		comboBox_1 = new ComboBox();
		button_5 = new Button();
		textBox_5 = new TextBox();
		button_6 = new Button();
		button_7 = new Button();
		dataGridView_1 = new DataGridView();
		dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		dataGridView_2 = new DataGridView();
		dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		tabPage_6 = new TabPage();
		checkBox_84 = new CheckBox();
		label_71 = new Label();
		label_40 = new Label();
		dateTimePicker_6 = new DateTimePicker();
		label_39 = new Label();
		checkBox_50 = new CheckBox();
		checkBox_49 = new CheckBox();
		dateTimePicker_2 = new DateTimePicker();
		dateTimePicker_1 = new DateTimePicker();
		dateTimePicker_3 = new DateTimePicker();
		dateTimePicker_0 = new DateTimePicker();
		checkBox_41 = new CheckBox();
		textBox_11 = new TextBox();
		label_34 = new Label();
		label_35 = new Label();
		comboBox_3 = new ComboBox();
		label_104 = new Label();
		label_36 = new Label();
		button_37 = new Button();
		button_38 = new Button();
		label_37 = new Label();
		button_39 = new Button();
		button_40 = new Button();
		comboBox_4 = new ComboBox();
		button_41 = new Button();
		textBox_12 = new TextBox();
		button_42 = new Button();
		button_43 = new Button();
		dataGridView_19 = new DataGridView();
		dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
		dataGridView_20 = new DataGridView();
		dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
		radioButton_14 = new RadioButton();
		radioButton_15 = new RadioButton();
		radioButton_16 = new RadioButton();
		groupBox_0 = new GroupBox();
		comboBox_7 = new ComboBox();
		label_41 = new Label();
		dateTimePicker_7 = new DateTimePicker();
		label_42 = new Label();
		textBox_19 = new TextBox();
		checkBox_51 = new CheckBox();
		radioButton_17 = new RadioButton();
		radioButton_18 = new RadioButton();
		radioButton_19 = new RadioButton();
		label_105 = new Label();
		checkBox_42 = new CheckBox();
		groupBox_1 = new GroupBox();
		comboBox_8 = new ComboBox();
		label_43 = new Label();
		dateTimePicker_8 = new DateTimePicker();
		label_44 = new Label();
		textBox_20 = new TextBox();
		checkBox_52 = new CheckBox();
		radioButton_20 = new RadioButton();
		radioButton_21 = new RadioButton();
		radioButton_22 = new RadioButton();
		label_106 = new Label();
		tabPage_7 = new TabPage();
		textBox_65 = new TextBox();
		button_88 = new Button();
		dataGridView_23 = new DataGridView();
		dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
		label_70 = new Label();
		trackBar_1 = new TrackBar();
		checkBox_65 = new CheckBox();
		label_38 = new Label();
		comboBox_6 = new ComboBox();
		comboBox_5 = new ComboBox();
		checkBox_45 = new CheckBox();
		checkBox_46 = new CheckBox();
		checkBox_44 = new CheckBox();
		tabPage_10 = new TabPage();
		label_88 = new Label();
		button_60 = new Button();
		button_82 = new Button();
		button_61 = new Button();
		panel_0 = new Panel();
		panel_12 = new Panel();
		label_167 = new Label();
		label_166 = new Label();
		panel_11 = new Panel();
		label_165 = new Label();
		label_164 = new Label();
		panel_10 = new Panel();
		label_163 = new Label();
		label_162 = new Label();
		panel_9 = new Panel();
		label_161 = new Label();
		label_160 = new Label();
		panel_8 = new Panel();
		label_159 = new Label();
		label_158 = new Label();
		panel_7 = new Panel();
		label_157 = new Label();
		label_156 = new Label();
		panel_6 = new Panel();
		label_155 = new Label();
		label_154 = new Label();
		panel_5 = new Panel();
		label_153 = new Label();
		label_152 = new Label();
		panel_4 = new Panel();
		label_151 = new Label();
		label_150 = new Label();
		panel_3 = new Panel();
		label_149 = new Label();
		label_148 = new Label();
		panel_2 = new Panel();
		label_147 = new Label();
		label_146 = new Label();
		panel_1 = new Panel();
		label_145 = new Label();
		label_144 = new Label();
		dataGridView_22 = new DataGridView();
		dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_66 = new DataGridViewTextBoxColumn();
		tabPage_12 = new TabPage();
		button_86 = new Button();
		button_85 = new Button();
		textBox_62 = new TextBox();
		checkBox_101 = new CheckBox();
		button_78 = new Button();
		textBox_56 = new TextBox();
		label_130 = new Label();
		label_131 = new Label();
		button_62 = new Button();
		comboBox_21 = new ComboBox();
		label_85 = new Label();
		label_86 = new Label();
		label_82 = new Label();
		textBox_35 = new TextBox();
		label_83 = new Label();
		label_84 = new Label();
		comboBox_18 = new ComboBox();
		button_59 = new Button();
		label_80 = new Label();
		textBox_57 = new TextBox();
		textBox_34 = new TextBox();
		label_77 = new Label();
		button_52 = new Button();
		button_53 = new Button();
		button_54 = new Button();
		textBox_33 = new TextBox();
		button_55 = new Button();
		button_56 = new Button();
		button_57 = new Button();
		button_58 = new Button();
		dataGridView_24 = new DataGridView();
		dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
		dataGridView_25 = new DataGridView();
		dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
		dataGridView_26 = new DataGridView();
		dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
		dataGridView_27 = new DataGridView();
		dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
		checkBox_69 = new CheckBox();
		checkBox_70 = new CheckBox();
		label_78 = new Label();
		label_79 = new Label();
		label_81 = new Label();
		label_76 = new Label();
		tabPage_8 = new TabPage();
		button_46 = new Button();
		comboBox_14 = new ComboBox();
		label_51 = new Label();
		textBox_26 = new TextBox();
		checkBox_59 = new CheckBox();
		comboBox_13 = new ComboBox();
		label_50 = new Label();
		textBox_25 = new TextBox();
		checkBox_58 = new CheckBox();
		comboBox_12 = new ComboBox();
		label_49 = new Label();
		textBox_24 = new TextBox();
		checkBox_57 = new CheckBox();
		comboBox_11 = new ComboBox();
		label_48 = new Label();
		textBox_23 = new TextBox();
		checkBox_56 = new CheckBox();
		comboBox_10 = new ComboBox();
		label_47 = new Label();
		textBox_22 = new TextBox();
		checkBox_55 = new CheckBox();
		comboBox_9 = new ComboBox();
		label_46 = new Label();
		button_48 = new Button();
		comboBox_15 = new ComboBox();
		textBox_27 = new TextBox();
		label_53 = new Label();
		label_52 = new Label();
		button_49 = new Button();
		comboBox_17 = new ComboBox();
		label_54 = new Label();
		textBox_28 = new TextBox();
		label_55 = new Label();
		label_56 = new Label();
		comboBox_16 = new ComboBox();
		textBox_29 = new TextBox();
		textBox_21 = new TextBox();
		button_47 = new Button();
		button_50 = new Button();
		dataGridView_21 = new DataGridView();
		dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
		dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
		checkBox_54 = new CheckBox();
		label_57 = new Label();
		label_58 = new Label();
		label_59 = new Label();
		label_65 = new Label();
		label_64 = new Label();
		label_63 = new Label();
		label_62 = new Label();
		label_61 = new Label();
		label_60 = new Label();
		tabPage_9 = new TabPage();
		checkBox_88 = new CheckBox();
		checkBox_85 = new CheckBox();
		checkBox_78 = new CheckBox();
		checkBox_76 = new CheckBox();
		checkBox_66 = new CheckBox();
		checkBox_67 = new CheckBox();
		checkBox_74 = new CheckBox();
		checkBox_64 = new CheckBox();
		checkBox_63 = new CheckBox();
		textBox_40 = new TextBox();
		textBox_41 = new TextBox();
		textBox_31 = new TextBox();
		checkBox_61 = new CheckBox();
		checkBox_62 = new CheckBox();
		label_93 = new Label();
		label_94 = new Label();
		label_95 = new Label();
		label_96 = new Label();
		label_68 = new Label();
		label_67 = new Label();
		label_66 = new Label();
		checkBox_60 = new CheckBox();
		textBox_30 = new TextBox();
		groupBox_2 = new GroupBox();
		radioButton_23 = new RadioButton();
		radioButton_24 = new RadioButton();
		button_51 = new Button();
		tabPage_11 = new TabPage();
		pictureBox_2 = new PictureBox();
		pictureBox_0 = new PictureBox();
		pictureBox_1 = new PictureBox();
		label_73 = new Label();
		tabPage_13 = new TabPage();
		label_102 = new Label();
		checkBox_77 = new CheckBox();
		checkBox_75 = new CheckBox();
		label_100 = new Label();
		label_99 = new Label();
		textBox_43 = new TextBox();
		textBox_42 = new TextBox();
		label_103 = new Label();
		label_98 = new Label();
		comboBox_20 = new ComboBox();
		comboBox_19 = new ComboBox();
		dateTimePicker_5 = new DateTimePicker();
		label_101 = new Label();
		label_97 = new Label();
		dateTimePicker_4 = new DateTimePicker();
		groupBox_3 = new GroupBox();
		radioButton_28 = new RadioButton();
		radioButton_27 = new RadioButton();
		groupBox_4 = new GroupBox();
		radioButton_26 = new RadioButton();
		radioButton_25 = new RadioButton();
		tabPage_14 = new TabPage();
		button_69 = new Button();
		textBox_48 = new TextBox();
		groupBox_5 = new GroupBox();
		textBox_47 = new TextBox();
		radioButton_30 = new RadioButton();
		radioButton_31 = new RadioButton();
		radioButton_29 = new RadioButton();
		button_68 = new Button();
		richTextBox_1 = new RichTextBox();
		richTextBox_0 = new RichTextBox();
		label_114 = new Label();
		textBox_46 = new TextBox();
		button_67 = new Button();
		comboBox_22 = new ComboBox();
		textBox_45 = new TextBox();
		label_115 = new Label();
		label_113 = new Label();
		label_112 = new Label();
		label_111 = new Label();
		checkBox_80 = new CheckBox();
		button_66 = new Button();
		button_65 = new Button();
		button_64 = new Button();
		label_110 = new Label();
		label_109 = new Label();
		tabPage_15 = new TabPage();
		checkBox_92 = new CheckBox();
		button_76 = new Button();
		button_73 = new Button();
		button_74 = new Button();
		button_75 = new Button();
		label_126 = new Label();
		textBox_51 = new TextBox();
		textBox_52 = new TextBox();
		textBox_54 = new TextBox();
		textBox_53 = new TextBox();
		dataGridView_29 = new DataGridView();
		label_122 = new Label();
		label_123 = new Label();
		label_124 = new Label();
		label_119 = new Label();
		label_127 = new Label();
		label_120 = new Label();
		label_125 = new Label();
		label_128 = new Label();
		label_121 = new Label();
		comboBox_23 = new ComboBox();
		checkBox_83 = new CheckBox();
		tabPage_16 = new TabPage();
		trackBar_2 = new TrackBar();
		label_134 = new Label();
		checkBox_89 = new CheckBox();
		checkBox_90 = new CheckBox();
		checkBox_91 = new CheckBox();
		tabPage_17 = new TabPage();
		dataGridView_30 = new DataGridView();
		button_79 = new Button();
		button_80 = new Button();
		button_81 = new Button();
		textBox_58 = new TextBox();
		textBox_59 = new TextBox();
		textBox_60 = new TextBox();
		label_138 = new Label();
		label_139 = new Label();
		label_140 = new Label();
		label_141 = new Label();
		comboBox_0 = new ComboBox();
		textBox_6 = new TextBox();
		button_11 = new Button();
		button_12 = new Button();
		checkBox_33 = new CheckBox();
		button_33 = new Button();
		checkBox_39 = new CheckBox();
		comboBox_26 = new ComboBox();
		label_137 = new Label();
		checkBox_97 = new CheckBox();
		button_83 = new Button();
		button_84 = new Button();
		comboBox_27 = new ComboBox();
		button_89 = new Button();
		button_90 = new Button();
		tabPage_0.SuspendLayout();
		tabPage_1.SuspendLayout();
		panel_13.SuspendLayout();
		((ISupportInitialize)numericUpDown_0).BeginInit();
		((ISupportInitialize)dataGridView_28).BeginInit();
		((ISupportInitialize)dataGridView_0).BeginInit();
		((ISupportInitialize)trackBar_0).BeginInit();
		tabPage_2.SuspendLayout();
		((ISupportInitialize)trackBar_3).BeginInit();
		tabPage_3.SuspendLayout();
		tabControl_0.SuspendLayout();
		tabPage_5.SuspendLayout();
		((ISupportInitialize)dataGridView_15).BeginInit();
		((ISupportInitialize)dataGridView_16).BeginInit();
		((ISupportInitialize)dataGridView_3).BeginInit();
		((ISupportInitialize)dataGridView_4).BeginInit();
		((ISupportInitialize)dataGridView_5).BeginInit();
		((ISupportInitialize)dataGridView_17).BeginInit();
		((ISupportInitialize)dataGridView_6).BeginInit();
		((ISupportInitialize)dataGridView_7).BeginInit();
		((ISupportInitialize)dataGridView_8).BeginInit();
		((ISupportInitialize)dataGridView_18).BeginInit();
		((ISupportInitialize)dataGridView_9).BeginInit();
		((ISupportInitialize)dataGridView_10).BeginInit();
		((ISupportInitialize)dataGridView_11).BeginInit();
		((ISupportInitialize)dataGridView_12).BeginInit();
		((ISupportInitialize)dataGridView_13).BeginInit();
		((ISupportInitialize)dataGridView_14).BeginInit();
		tabPage_4.SuspendLayout();
		((ISupportInitialize)dataGridView_1).BeginInit();
		((ISupportInitialize)dataGridView_2).BeginInit();
		tabPage_6.SuspendLayout();
		((ISupportInitialize)dataGridView_19).BeginInit();
		((ISupportInitialize)dataGridView_20).BeginInit();
		groupBox_0.SuspendLayout();
		groupBox_1.SuspendLayout();
		tabPage_7.SuspendLayout();
		((ISupportInitialize)dataGridView_23).BeginInit();
		((ISupportInitialize)trackBar_1).BeginInit();
		tabPage_10.SuspendLayout();
		panel_0.SuspendLayout();
		panel_12.SuspendLayout();
		panel_11.SuspendLayout();
		panel_10.SuspendLayout();
		panel_9.SuspendLayout();
		panel_8.SuspendLayout();
		panel_7.SuspendLayout();
		panel_6.SuspendLayout();
		panel_5.SuspendLayout();
		panel_4.SuspendLayout();
		panel_3.SuspendLayout();
		panel_2.SuspendLayout();
		panel_1.SuspendLayout();
		((ISupportInitialize)dataGridView_22).BeginInit();
		tabPage_12.SuspendLayout();
		((ISupportInitialize)dataGridView_24).BeginInit();
		((ISupportInitialize)dataGridView_25).BeginInit();
		((ISupportInitialize)dataGridView_26).BeginInit();
		((ISupportInitialize)dataGridView_27).BeginInit();
		tabPage_8.SuspendLayout();
		((ISupportInitialize)dataGridView_21).BeginInit();
		tabPage_9.SuspendLayout();
		groupBox_2.SuspendLayout();
		tabPage_11.SuspendLayout();
		((ISupportInitialize)pictureBox_2).BeginInit();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)pictureBox_1).BeginInit();
		tabPage_13.SuspendLayout();
		groupBox_3.SuspendLayout();
		groupBox_4.SuspendLayout();
		tabPage_14.SuspendLayout();
		groupBox_5.SuspendLayout();
		tabPage_15.SuspendLayout();
		((ISupportInitialize)dataGridView_29).BeginInit();
		tabPage_16.SuspendLayout();
		((ISupportInitialize)trackBar_2).BeginInit();
		tabPage_17.SuspendLayout();
		((ISupportInitialize)dataGridView_30).BeginInit();
		SuspendLayout();
		checkBox_1.AutoSize = true;
		checkBox_1.Checked = true;
		checkBox_1.CheckState = CheckState.Checked;
		checkBox_1.Location = new Point(67, 146);
		checkBox_1.Name = "checkBox7";
		checkBox_1.Size = new Size(54, 17);
		checkBox_1.TabIndex = 0;
		checkBox_1.Text = "Skill 2";
		checkBox_1.UseVisualStyleBackColor = true;
		checkBox_2.AutoSize = true;
		checkBox_2.Location = new Point(145, 52);
		checkBox_2.Name = "checkBox38";
		checkBox_2.Size = new Size(82, 17);
		checkBox_2.TabIndex = 7;
		checkBox_2.Text = "ไม\u0e48เก\u0e47บกล\u0e48อง";
		checkBox_2.UseVisualStyleBackColor = true;
		tabPage_0.BorderStyle = BorderStyle.FixedSingle;
		tabPage_0.Controls.Add(label_142);
		tabPage_0.Controls.Add(textBox_61);
		tabPage_0.Controls.Add(checkBox_98);
		tabPage_0.Controls.Add(checkBox_96);
		tabPage_0.Controls.Add(checkBox_40);
		tabPage_0.Controls.Add(checkBox_2);
		tabPage_0.Controls.Add(radioButton_12);
		tabPage_0.Controls.Add(radioButton_10);
		tabPage_0.Controls.Add(radioButton_0);
		tabPage_0.Controls.Add(radioButton_1);
		tabPage_0.Controls.Add(radioButton_2);
		tabPage_0.Controls.Add(checkBox_3);
		tabPage_0.Controls.Add(checkBox_4);
		tabPage_0.Controls.Add(checkBox_5);
		tabPage_0.Controls.Add(checkBox_6);
		tabPage_0.Controls.Add(checkBox_7);
		tabPage_0.Controls.Add(label_0);
		tabPage_0.Controls.Add(label_1);
		tabPage_0.Location = new Point(4, 49);
		tabPage_0.Name = "tabPage4";
		tabPage_0.Padding = new Padding(10, 3, 3, 3);
		tabPage_0.Size = new Size(638, 370);
		tabPage_0.TabIndex = 4;
		tabPage_0.Text = "Item Box";
		tabPage_0.UseVisualStyleBackColor = true;
		label_142.AutoSize = true;
		label_142.Location = new Point(97, 183);
		label_142.Name = "label124";
		label_142.Size = new Size(13, 13);
		label_142.TabIndex = 28;
		label_142.Text = "0";
		label_142.TextAlign = ContentAlignment.MiddleCenter;
		textBox_61.BackColor = Color.FromArgb(255, 192, 128);
		textBox_61.Location = new Point(19, 205);
		textBox_61.Name = "textBox62";
		textBox_61.Size = new Size(138, 20);
		textBox_61.TabIndex = 27;
		textBox_61.Text = "Buff Card";
		textBox_61.TextAlign = HorizontalAlignment.Center;
		checkBox_98.AutoSize = true;
		checkBox_98.Location = new Point(18, 182);
		checkBox_98.Name = "checkBox100";
		checkBox_98.Size = new Size(74, 17);
		checkBox_98.TabIndex = 26;
		checkBox_98.Text = "ใช\u0e49บ\u0e31ตรบ\u0e31พ";
		checkBox_98.UseVisualStyleBackColor = true;
		checkBox_96.AutoSize = true;
		checkBox_96.Location = new Point(188, 117);
		checkBox_96.Name = "checkBox94";
		checkBox_96.Size = new Size(76, 17);
		checkBox_96.TabIndex = 10;
		checkBox_96.Text = "ไม\u0e48เก\u0e47บเง\u0e34น";
		checkBox_96.UseVisualStyleBackColor = true;
		checkBox_40.AutoSize = true;
		checkBox_40.Location = new Point(18, 159);
		checkBox_40.Name = "checkBox43";
		checkBox_40.Size = new Size(213, 17);
		checkBox_40.TabIndex = 9;
		checkBox_40.Text = "ต\u0e35 Monster ให\u0e49หมด Zone ก\u0e48อนเก\u0e47บไอเท\u0e47ม";
		checkBox_40.UseVisualStyleBackColor = true;
		radioButton_12.AutoSize = true;
		radioButton_12.Location = new Point(201, 95);
		radioButton_12.Name = "radioButton22";
		radioButton_12.Size = new Size(98, 17);
		radioButton_12.TabIndex = 4;
		radioButton_12.Text = "ไม\u0e48เก\u0e47บอะไรเลย";
		radioButton_12.UseVisualStyleBackColor = true;
		radioButton_10.AutoSize = true;
		radioButton_10.Location = new Point(19, 136);
		radioButton_10.Name = "radioButton21";
		radioButton_10.Size = new Size(182, 17);
		radioButton_10.TabIndex = 4;
		radioButton_10.Text = "เก\u0e47บเง\u0e34นและไม\u0e48เก\u0e47บไอเท\u0e47มตาม List";
		radioButton_10.UseVisualStyleBackColor = true;
		radioButton_0.AutoSize = true;
		radioButton_0.Location = new Point(19, 116);
		radioButton_0.Name = "radioButton20";
		radioButton_0.Size = new Size(150, 17);
		radioButton_0.TabIndex = 4;
		radioButton_0.Text = "เก\u0e47บเง\u0e34นและไอเท\u0e47มตาม List";
		radioButton_0.UseVisualStyleBackColor = true;
		radioButton_1.AutoSize = true;
		radioButton_1.Location = new Point(104, 95);
		radioButton_1.Name = "radioButton19";
		radioButton_1.Size = new Size(93, 17);
		radioButton_1.TabIndex = 3;
		radioButton_1.Text = "เก\u0e47บเฉพาะเง\u0e34น";
		radioButton_1.UseVisualStyleBackColor = true;
		radioButton_2.AutoSize = true;
		radioButton_2.Checked = true;
		radioButton_2.Location = new Point(19, 95);
		radioButton_2.Name = "radioButton18";
		radioButton_2.Size = new Size(81, 17);
		radioButton_2.TabIndex = 2;
		radioButton_2.TabStop = true;
		radioButton_2.Text = "เก\u0e47บท\u0e38กอย\u0e48าง";
		radioButton_2.UseVisualStyleBackColor = true;
		checkBox_3.AutoSize = true;
		checkBox_3.Location = new Point(74, 52);
		checkBox_3.Name = "checkBox33";
		checkBox_3.Size = new Size(55, 17);
		checkBox_3.TabIndex = 1;
		checkBox_3.Text = "Lucky";
		checkBox_3.UseVisualStyleBackColor = true;
		checkBox_4.AutoSize = true;
		checkBox_4.Checked = true;
		checkBox_4.CheckState = CheckState.Checked;
		checkBox_4.Location = new Point(18, 52);
		checkBox_4.Name = "checkBox32";
		checkBox_4.Size = new Size(50, 17);
		checkBox_4.TabIndex = 1;
		checkBox_4.Text = "EXP ";
		checkBox_4.UseVisualStyleBackColor = true;
		checkBox_5.AutoSize = true;
		checkBox_5.Checked = true;
		checkBox_5.CheckState = CheckState.Checked;
		checkBox_5.Location = new Point(160, 28);
		checkBox_5.Name = "checkBox31";
		checkBox_5.Size = new Size(73, 17);
		checkBox_5.TabIndex = 1;
		checkBox_5.Text = "Power Up";
		checkBox_5.UseVisualStyleBackColor = true;
		checkBox_6.AutoSize = true;
		checkBox_6.Location = new Point(96, 29);
		checkBox_6.Name = "checkBox30";
		checkBox_6.Size = new Size(52, 17);
		checkBox_6.TabIndex = 1;
		checkBox_6.Text = "Crazy";
		checkBox_6.UseVisualStyleBackColor = true;
		checkBox_7.AutoSize = true;
		checkBox_7.Location = new Point(19, 29);
		checkBox_7.Name = "checkBox29";
		checkBox_7.Size = new Size(74, 17);
		checkBox_7.TabIndex = 1;
		checkBox_7.Text = "Speed Up";
		checkBox_7.UseVisualStyleBackColor = true;
		label_0.AutoSize = true;
		label_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_0.Location = new Point(16, 78);
		label_0.Name = "label100";
		label_0.Size = new Size(77, 13);
		label_0.TabIndex = 0;
		label_0.Text = "# เก\u0e47บไอเทม";
		label_1.AutoSize = true;
		label_1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_1.Location = new Point(15, 7);
		label_1.Name = "label13";
		label_1.Size = new Size(114, 13);
		label_1.TabIndex = 0;
		label_1.Text = "# LuckyBox (Lock)";
		tabPage_1.BorderStyle = BorderStyle.FixedSingle;
		tabPage_1.Controls.Add(panel_13);
		tabPage_1.Controls.Add(button_87);
		tabPage_1.Controls.Add(textBox_64);
		tabPage_1.Controls.Add(radioButton_33);
		tabPage_1.Controls.Add(label_143);
		tabPage_1.Controls.Add(checkBox_103);
		tabPage_1.Controls.Add(checkBox_104);
		tabPage_1.Controls.Add(textBox_63);
		tabPage_1.Controls.Add(checkBox_95);
		tabPage_1.Controls.Add(numericUpDown_0);
		tabPage_1.Controls.Add(label_136);
		tabPage_1.Controls.Add(checkBox_93);
		tabPage_1.Controls.Add(checkBox_94);
		tabPage_1.Controls.Add(label_135);
		tabPage_1.Controls.Add(radioButton_32);
		tabPage_1.Controls.Add(textBox_50);
		tabPage_1.Controls.Add(label_118);
		tabPage_1.Controls.Add(button_70);
		tabPage_1.Controls.Add(dataGridView_28);
		tabPage_1.Controls.Add(checkBox_81);
		tabPage_1.Controls.Add(checkBox_82);
		tabPage_1.Controls.Add(label_92);
		tabPage_1.Controls.Add(label_117);
		tabPage_1.Controls.Add(label_108);
		tabPage_1.Controls.Add(label_89);
		tabPage_1.Controls.Add(label_91);
		tabPage_1.Controls.Add(label_107);
		tabPage_1.Controls.Add(label_90);
		tabPage_1.Controls.Add(textBox_39);
		tabPage_1.Controls.Add(textBox_44);
		tabPage_1.Controls.Add(textBox_38);
		tabPage_1.Controls.Add(checkBox_72);
		tabPage_1.Controls.Add(checkBox_71);
		tabPage_1.Controls.Add(checkBox_48);
		tabPage_1.Controls.Add(checkBox_79);
		tabPage_1.Controls.Add(checkBox_47);
		tabPage_1.Controls.Add(button_45);
		tabPage_1.Controls.Add(label_2);
		tabPage_1.Controls.Add(button_13);
		tabPage_1.Controls.Add(button_14);
		tabPage_1.Controls.Add(checkBox_32);
		tabPage_1.Controls.Add(dataGridView_0);
		tabPage_1.Controls.Add(button_3);
		tabPage_1.Controls.Add(button_4);
		tabPage_1.Controls.Add(trackBar_0);
		tabPage_1.Controls.Add(label_20);
		tabPage_1.Controls.Add(label_3);
		tabPage_1.Controls.Add(label_4);
		tabPage_1.Controls.Add(radioButton_11);
		tabPage_1.Controls.Add(radioButton_3);
		tabPage_1.Controls.Add(radioButton_4);
		tabPage_1.Controls.Add(radioButton_5);
		tabPage_1.Controls.Add(radioButton_6);
		tabPage_1.Location = new Point(4, 49);
		tabPage_1.Name = "tabPage2";
		tabPage_1.Padding = new Padding(3);
		tabPage_1.Size = new Size(638, 370);
		tabPage_1.TabIndex = 1;
		tabPage_1.Text = "Monster";
		tabPage_1.UseVisualStyleBackColor = true;
		panel_13.Controls.Add(radioButton_34);
		panel_13.Controls.Add(radioButton_35);
		panel_13.Location = new Point(194, 131);
		panel_13.Name = "zoneModePanel";
		panel_13.Size = new Size(128, 22);
		panel_13.TabIndex = 0;
		radioButton_34.AutoSize = true;
		radioButton_34.Checked = true;
		radioButton_34.Location = new Point(0, 0);
		radioButton_34.Name = "radioButton6";
		radioButton_34.Size = new Size(58, 17);
		radioButton_34.TabIndex = 96;
		radioButton_34.TabStop = true;
		radioButton_34.Text = "Classic";
		radioButton_34.UseVisualStyleBackColor = true;
		radioButton_34.CheckedChanged += radioButton_35_CheckedChanged;
		radioButton_35.AutoSize = true;
		radioButton_35.Location = new Point(62, 1);
		radioButton_35.Name = "radioButton7";
		radioButton_35.Size = new Size(61, 17);
		radioButton_35.TabIndex = 97;
		radioButton_35.TabStop = true;
		radioButton_35.Text = "Modern";
		radioButton_35.UseVisualStyleBackColor = true;
		radioButton_35.CheckedChanged += radioButton_35_CheckedChanged;
		button_87.Location = new Point(196, 87);
		button_87.Name = "button87";
		button_87.Size = new Size(100, 23);
		button_87.TabIndex = 95;
		button_87.Text = "เล\u0e37อก";
		button_87.UseVisualStyleBackColor = true;
		button_87.Click += button_87_Click;
		textBox_64.Location = new Point(90, 88);
		textBox_64.Name = "textBox41";
		textBox_64.Size = new Size(100, 20);
		textBox_64.TabIndex = 94;
		radioButton_33.AutoSize = true;
		radioButton_33.Location = new Point(6, 88);
		radioButton_33.Name = "radioButton27";
		radioButton_33.Size = new Size(82, 17);
		radioButton_33.TabIndex = 93;
		radioButton_33.TabStop = true;
		radioButton_33.Text = "ว\u0e34\u0e48งตามเพ\u0e37\u0e48อน";
		radioButton_33.UseVisualStyleBackColor = true;
		label_143.AutoSize = true;
		label_143.BackColor = Color.Salmon;
		label_143.Location = new Point(269, 267);
		label_143.Name = "label73";
		label_143.Size = new Size(26, 13);
		label_143.TabIndex = 85;
		label_143.Text = "Sec";
		checkBox_103.AutoSize = true;
		checkBox_103.Location = new Point(180, 291);
		checkBox_103.Name = "checkBox99";
		checkBox_103.Size = new Size(76, 17);
		checkBox_103.TabIndex = 84;
		checkBox_103.Text = "ไม\u0e48ต\u0e35พ\u0e34ก\u0e31ดน\u0e35\u0e49";
		checkBox_103.UseVisualStyleBackColor = true;
		checkBox_104.AutoSize = true;
		checkBox_104.Location = new Point(180, 267);
		checkBox_104.Name = "checkBox98";
		checkBox_104.Size = new Size(51, 17);
		checkBox_104.TabIndex = 83;
		checkBox_104.Text = "ด\u0e35เลย\u0e4c";
		checkBox_104.UseVisualStyleBackColor = true;
		textBox_63.Location = new Point(232, 264);
		textBox_63.Name = "textBox40";
		textBox_63.Size = new Size(30, 20);
		textBox_63.TabIndex = 82;
		textBox_63.Text = "5";
		textBox_63.TextAlign = HorizontalAlignment.Center;
		checkBox_95.AutoSize = true;
		checkBox_95.Location = new Point(208, 68);
		checkBox_95.Name = "checkBox97";
		checkBox_95.Size = new Size(86, 17);
		checkBox_95.TabIndex = 69;
		checkBox_95.Text = "ต\u0e35ต\u0e31วเด\u0e35ยวก\u0e31น";
		checkBox_95.UseVisualStyleBackColor = true;
		numericUpDown_0.ImeMode = ImeMode.NoControl;
		numericUpDown_0.Increment = new decimal(new int[4] { 5, 0, 0, 0 });
		numericUpDown_0.Location = new Point(73, 66);
		numericUpDown_0.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		numericUpDown_0.Name = "numericUpDown2";
		numericUpDown_0.Size = new Size(51, 20);
		numericUpDown_0.TabIndex = 63;
		numericUpDown_0.TextAlign = HorizontalAlignment.Center;
		numericUpDown_0.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		label_136.AutoSize = true;
		label_136.BackColor = Color.FromArgb(255, 192, 128);
		label_136.Location = new Point(8, 70);
		label_136.Name = "label121";
		label_136.Size = new Size(60, 13);
		label_136.TabIndex = 62;
		label_136.Text = "ระยะต\u0e35 ห\u0e31วต\u0e35\u0e49";
		checkBox_93.AutoSize = true;
		checkBox_93.Location = new Point(132, 68);
		checkBox_93.Name = "checkBox92";
		checkBox_93.Size = new Size(74, 17);
		checkBox_93.TabIndex = 61;
		checkBox_93.Text = "บ\u0e31พเท\u0e48าน\u0e31\u0e49น";
		checkBox_93.UseVisualStyleBackColor = true;
		checkBox_94.AutoSize = true;
		checkBox_94.Location = new Point(212, 43);
		checkBox_94.Name = "checkBox93";
		checkBox_94.Size = new Size(87, 17);
		checkBox_94.TabIndex = 60;
		checkBox_94.Text = "Zone Leader";
		checkBox_94.UseVisualStyleBackColor = true;
		label_135.AutoSize = true;
		label_135.BackColor = Color.FromArgb(128, 255, 128);
		label_135.Location = new Point(76, 47);
		label_135.Name = "label120";
		label_135.Size = new Size(40, 13);
		label_135.TabIndex = 54;
		label_135.Text = "Leader";
		radioButton_32.AutoSize = true;
		radioButton_32.Location = new Point(5, 45);
		radioButton_32.Name = "radioButton26";
		radioButton_32.Size = new Size(64, 17);
		radioButton_32.TabIndex = 53;
		radioButton_32.TabStop = true;
		radioButton_32.Text = "ตามห\u0e31วต\u0e35\u0e49";
		radioButton_32.UseVisualStyleBackColor = true;
		textBox_50.BackColor = Color.FromArgb(255, 192, 128);
		textBox_50.Location = new Point(436, 159);
		textBox_50.Name = "textBox54";
		textBox_50.ReadOnly = true;
		textBox_50.Size = new Size(100, 20);
		textBox_50.TabIndex = 52;
		label_118.BackColor = Color.FromArgb(255, 255, 192);
		label_118.Location = new Point(587, 161);
		label_118.Name = "label106";
		label_118.Size = new Size(42, 23);
		label_118.TabIndex = 50;
		label_118.Text = "Result";
		label_118.TextAlign = ContentAlignment.MiddleCenter;
		button_70.Location = new Point(542, 162);
		button_70.Name = "button70";
		button_70.Size = new Size(41, 23);
		button_70.TabIndex = 49;
		button_70.Text = "Load";
		button_70.UseVisualStyleBackColor = true;
		button_70.Click += button_70_Click;
		dataGridView_28.AllowUserToResizeColumns = false;
		dataGridView_28.AllowUserToResizeRows = false;
		dataGridView_28.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = Color.White;
		dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		dataGridView_28.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dataGridView_28.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_28.Columns.AddRange(dataGridViewTextBoxColumn_69);
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = Color.White;
		dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
		dataGridView_28.DefaultCellStyle = dataGridViewCellStyle2;
		dataGridView_28.Location = new Point(469, 213);
		dataGridView_28.Name = "dataGridView12";
		dataGridView_28.ReadOnly = true;
		dataGridViewCellStyle3.BackColor = Color.White;
		dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
		dataGridView_28.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
		dataGridView_28.RowHeadersVisible = false;
		dataGridView_28.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_28.Size = new Size(160, 140);
		dataGridView_28.StandardTab = true;
		dataGridView_28.TabIndex = 48;
		dataGridView_28.CellDoubleClick += dataGridView_28_CellDoubleClick;
		dataGridViewTextBoxColumn_69.HeaderText = "Monster ท\u0e35\u0e48พบ";
		dataGridViewTextBoxColumn_69.Name = "dataGridViewTextBoxColumn59";
		dataGridViewTextBoxColumn_69.ReadOnly = true;
		checkBox_81.AutoSize = true;
		checkBox_81.Location = new Point(324, 198);
		checkBox_81.Name = "checkBox82";
		checkBox_81.Size = new Size(139, 17);
		checkBox_81.TabIndex = 45;
		checkBox_81.Text = "ต\u0e35เฉพาะ Monster ท\u0e35\u0e48เล\u0e37อก";
		checkBox_81.UseVisualStyleBackColor = true;
		checkBox_82.AutoSize = true;
		checkBox_82.Location = new Point(324, 179);
		checkBox_82.Name = "checkBox73";
		checkBox_82.Size = new Size(129, 17);
		checkBox_82.TabIndex = 45;
		checkBox_82.Text = "ต\u0e35 Monster ท\u0e35\u0e48เล\u0e37อกก\u0e48อน";
		checkBox_82.UseVisualStyleBackColor = true;
		label_92.AutoSize = true;
		label_92.BackColor = Color.FromArgb(255, 192, 128);
		label_92.Location = new Point(166, 203);
		label_92.Name = "label85";
		label_92.Size = new Size(135, 13);
		label_92.TabIndex = 44;
		label_92.Text = "ย\u0e31งไม\u0e48ออกว\u0e34\u0e48ง มาแล\u0e49ว 0 ว\u0e34นาท\u0e35";
		label_117.AutoSize = true;
		label_117.BackColor = Color.FromArgb(128, 255, 255);
		label_117.Location = new Point(330, 162);
		label_117.Name = "label104";
		label_117.Size = new Size(100, 13);
		label_117.TabIndex = 44;
		label_117.Text = "ระบบ Lock Monster";
		label_108.AutoSize = true;
		label_108.BackColor = Color.FromArgb(128, 255, 255);
		label_108.Location = new Point(330, 112);
		label_108.Name = "label57";
		label_108.Size = new Size(157, 13);
		label_108.TabIndex = 44;
		label_108.Text = "อ\u0e35ก .. ว\u0e34นาท\u0e35 จะว\u0e34\u0e48งกล\u0e31บกลางวงกลม";
		label_89.AutoSize = true;
		label_89.BackColor = Color.FromArgb(128, 255, 128);
		label_89.Location = new Point(171, 224);
		label_89.Name = "label82";
		label_89.Size = new Size(123, 13);
		label_89.TabIndex = 44;
		label_89.Text = "ต\u0e35ในพ\u0e34ก\u0e31ด มาแล\u0e49ว 0 ว\u0e34นาท\u0e35";
		label_91.AutoSize = true;
		label_91.Location = new Point(597, 56);
		label_91.Name = "label84";
		label_91.Size = new Size(33, 13);
		label_91.TabIndex = 43;
		label_91.Text = "ว\u0e34นาท\u0e35";
		label_107.AutoSize = true;
		label_107.Location = new Point(536, 132);
		label_107.Name = "label56";
		label_107.Size = new Size(33, 13);
		label_107.TabIndex = 43;
		label_107.Text = "ว\u0e34นาท\u0e35";
		label_90.AutoSize = true;
		label_90.Location = new Point(570, 81);
		label_90.Name = "label83";
		label_90.Size = new Size(33, 13);
		label_90.TabIndex = 43;
		label_90.Text = "ว\u0e34นาท\u0e35";
		textBox_39.Location = new Point(542, 53);
		textBox_39.Name = "textBox46";
		textBox_39.Size = new Size(51, 20);
		textBox_39.TabIndex = 42;
		textBox_39.Text = "60";
		textBox_39.TextAlign = HorizontalAlignment.Center;
		textBox_44.Location = new Point(477, 129);
		textBox_44.Name = "textBox34";
		textBox_44.Size = new Size(51, 20);
		textBox_44.TabIndex = 42;
		textBox_44.Text = "60";
		textBox_44.TextAlign = HorizontalAlignment.Center;
		textBox_38.Location = new Point(511, 78);
		textBox_38.Name = "textBox45";
		textBox_38.Size = new Size(51, 20);
		textBox_38.TabIndex = 42;
		textBox_38.Text = "60";
		textBox_38.TextAlign = HorizontalAlignment.Center;
		checkBox_72.AutoSize = true;
		checkBox_72.Location = new Point(324, 55);
		checkBox_72.Name = "checkBox76";
		checkBox_72.Size = new Size(221, 17);
		checkBox_72.TabIndex = 41;
		checkBox_72.Text = "เปล\u0e35\u0e48ยนพ\u0e34ก\u0e31ด หากไม\u0e48ว\u0e34\u0e48งไปพ\u0e34ก\u0e31ดต\u0e48อไป นาน >";
		checkBox_72.UseVisualStyleBackColor = true;
		checkBox_71.AutoSize = true;
		checkBox_71.Location = new Point(324, 80);
		checkBox_71.Name = "checkBox75";
		checkBox_71.Size = new Size(184, 17);
		checkBox_71.TabIndex = 41;
		checkBox_71.Text = "เปล\u0e35\u0e48ยนพ\u0e34ก\u0e31ด หากต\u0e35 Monster นาน >";
		checkBox_71.UseVisualStyleBackColor = true;
		checkBox_48.AutoSize = true;
		checkBox_48.Location = new Point(180, 246);
		checkBox_48.Name = "checkBox51";
		checkBox_48.Size = new Size(86, 17);
		checkBox_48.TabIndex = 31;
		checkBox_48.Text = "ส\u0e38\u0e48มลำด\u0e31บพ\u0e34ก\u0e31ด";
		checkBox_48.UseVisualStyleBackColor = true;
		checkBox_79.AutoSize = true;
		checkBox_79.Location = new Point(324, 131);
		checkBox_79.Name = "checkBox63";
		checkBox_79.Size = new Size(151, 17);
		checkBox_79.TabIndex = 31;
		checkBox_79.Text = "Reset โหมดวงกลม หาก  > ";
		checkBox_79.UseVisualStyleBackColor = true;
		checkBox_47.AutoSize = true;
		checkBox_47.Location = new Point(324, 33);
		checkBox_47.Name = "checkBox50";
		checkBox_47.Size = new Size(172, 17);
		checkBox_47.TabIndex = 31;
		checkBox_47.Text = "ต\u0e35 Monster ท\u0e35\u0e48เล\u0e37อดเยอะท\u0e35\u0e48ส\u0e38ดก\u0e48อน";
		checkBox_47.UseVisualStyleBackColor = true;
		button_45.Location = new Point(205, 342);
		button_45.Name = "button32";
		button_45.Size = new Size(75, 23);
		button_45.TabIndex = 30;
		button_45.Text = "ล\u0e49าง";
		button_45.UseVisualStyleBackColor = true;
		button_45.Click += button_45_Click;
		label_2.BackColor = Color.FromArgb(255, 255, 192);
		label_2.Location = new Point(178, 171);
		label_2.Name = "label11";
		label_2.Size = new Size(117, 23);
		label_2.TabIndex = 14;
		label_2.Text = "Current Position";
		label_2.TextAlign = ContentAlignment.MiddleCenter;
		button_13.Location = new Point(5, 341);
		button_13.Name = "button7";
		button_13.Size = new Size(75, 23);
		button_13.TabIndex = 26;
		button_13.Text = "โหลด";
		button_13.UseVisualStyleBackColor = true;
		button_13.Click += button_13_Click;
		button_14.Location = new Point(88, 341);
		button_14.Name = "button5";
		button_14.Size = new Size(75, 23);
		button_14.TabIndex = 26;
		button_14.Text = "บ\u0e31นท\u0e36ก";
		button_14.UseVisualStyleBackColor = true;
		button_14.Click += button_14_Click;
		checkBox_32.AutoSize = true;
		checkBox_32.Location = new Point(216, 114);
		checkBox_32.Name = "checkBox1";
		checkBox_32.Size = new Size(81, 17);
		checkBox_32.TabIndex = 24;
		checkBox_32.Text = "Show Zone";
		checkBox_32.UseVisualStyleBackColor = true;
		checkBox_32.CheckedChanged += checkBox_32_CheckedChanged;
		dataGridView_0.AllowUserToAddRows = false;
		dataGridView_0.AllowUserToResizeColumns = false;
		dataGridView_0.AllowUserToResizeRows = false;
		dataGridView_0.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_0.ColumnHeadersVisible = false;
		dataGridView_0.Columns.AddRange(dataGridViewTextBoxColumn_67, dataGridViewTextBoxColumn_68);
		dataGridView_0.ImeMode = ImeMode.NoControl;
		dataGridView_0.Location = new Point(13, 171);
		dataGridView_0.Name = "dataGridView1";
		dataGridView_0.RowHeadersVisible = false;
		dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_0.Size = new Size(145, 164);
		dataGridView_0.TabIndex = 23;
		dataGridViewTextBoxColumn_67.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_67.HeaderText = "X";
		dataGridViewTextBoxColumn_67.Name = "Column1";
		dataGridViewTextBoxColumn_68.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_68.HeaderText = "Y";
		dataGridViewTextBoxColumn_68.Name = "Column2";
		button_3.Location = new Point(243, 313);
		button_3.Name = "button4";
		button_3.Size = new Size(75, 23);
		button_3.TabIndex = 20;
		button_3.Text = "ลบท\u0e35\u0e48เล\u0e37อก";
		button_3.UseVisualStyleBackColor = true;
		button_3.Click += button_3_Click;
		button_4.Location = new Point(164, 313);
		button_4.Name = "button3";
		button_4.Size = new Size(75, 23);
		button_4.TabIndex = 19;
		button_4.Text = "บ\u0e31นท\u0e36กพ\u0e34ก\u0e31ด";
		button_4.UseVisualStyleBackColor = true;
		button_4.Click += button_4_Click;
		trackBar_0.Location = new Point(13, 144);
		trackBar_0.Maximum = 1000;
		trackBar_0.Minimum = 30;
		trackBar_0.Name = "trackBar1";
		trackBar_0.Size = new Size(261, 45);
		trackBar_0.TabIndex = 17;
		trackBar_0.Value = 100;
		trackBar_0.Scroll += trackBar_0_Scroll;
		label_20.BackColor = Color.FromArgb(192, 255, 192);
		label_20.Location = new Point(79, 111);
		label_20.Name = "label22";
		label_20.Size = new Size(133, 23);
		label_20.TabIndex = 14;
		label_20.Text = "Set Position";
		label_20.TextAlign = ContentAlignment.MiddleCenter;
		label_3.BackColor = Color.FromArgb(192, 255, 192);
		label_3.Location = new Point(31, 113);
		label_3.Name = "label10";
		label_3.Size = new Size(42, 20);
		label_3.TabIndex = 13;
		label_3.Text = "100";
		label_3.TextAlign = ContentAlignment.MiddleCenter;
		label_4.AutoSize = true;
		label_4.Location = new Point(2, 116);
		label_4.Name = "label3";
		label_4.Size = new Size(28, 13);
		label_4.TabIndex = 5;
		label_4.Text = "ร\u0e31ศม\u0e35";
		radioButton_11.AutoSize = true;
		radioButton_11.Location = new Point(143, 24);
		radioButton_11.Name = "radioButton5";
		radioButton_11.Size = new Size(58, 17);
		radioButton_11.TabIndex = 3;
		radioButton_11.Text = "Looper";
		radioButton_11.UseVisualStyleBackColor = true;
		radioButton_3.AutoSize = true;
		radioButton_3.Location = new Point(71, 24);
		radioButton_3.Name = "radioButton4";
		radioButton_3.Size = new Size(66, 17);
		radioButton_3.TabIndex = 3;
		radioButton_3.Text = "ตามพ\u0e34ก\u0e31ด";
		radioButton_3.UseVisualStyleBackColor = true;
		radioButton_4.AutoSize = true;
		radioButton_4.Location = new Point(5, 23);
		radioButton_4.Name = "radioButton3";
		radioButton_4.Size = new Size(60, 17);
		radioButton_4.TabIndex = 3;
		radioButton_4.Text = "แบบส\u0e38\u0e48ม";
		radioButton_4.UseVisualStyleBackColor = true;
		radioButton_5.AutoSize = true;
		radioButton_5.Location = new Point(79, 4);
		radioButton_5.Name = "radioButton2";
		radioButton_5.Size = new Size(112, 17);
		radioButton_5.TabIndex = 2;
		radioButton_5.Text = "ตามขอบเขตวงกลม";
		radioButton_5.UseVisualStyleBackColor = true;
		radioButton_6.AutoSize = true;
		radioButton_6.Checked = true;
		radioButton_6.Location = new Point(5, 3);
		radioButton_6.Name = "radioButton1";
		radioButton_6.Size = new Size(72, 17);
		radioButton_6.TabIndex = 1;
		radioButton_6.TabStop = true;
		radioButton_6.Text = "จ\u0e38ดป\u0e31จจ\u0e38บ\u0e31น";
		radioButton_6.UseVisualStyleBackColor = true;
		checkBox_8.AutoSize = true;
		checkBox_8.Checked = true;
		checkBox_8.CheckState = CheckState.Checked;
		checkBox_8.Location = new Point(16, 146);
		checkBox_8.Name = "checkBox6";
		checkBox_8.Size = new Size(54, 17);
		checkBox_8.TabIndex = 0;
		checkBox_8.Text = "Skill 1";
		checkBox_8.UseVisualStyleBackColor = true;
		checkBox_9.AutoSize = true;
		checkBox_9.Checked = true;
		checkBox_9.CheckState = CheckState.Checked;
		checkBox_9.Location = new Point(130, 146);
		checkBox_9.Name = "checkBox8";
		checkBox_9.Size = new Size(54, 17);
		checkBox_9.TabIndex = 0;
		checkBox_9.Text = "Skill 3";
		checkBox_9.UseVisualStyleBackColor = true;
		checkBox_10.Anchor = AnchorStyles.Bottom;
		checkBox_10.AutoSize = true;
		checkBox_10.Location = new Point(353, 434);
		checkBox_10.Name = "checkBox37";
		checkBox_10.Size = new Size(41, 17);
		checkBox_10.TabIndex = 20;
		checkBox_10.Text = "Pin";
		checkBox_10.UseVisualStyleBackColor = true;
		checkBox_10.CheckedChanged += checkBox_10_CheckedChanged;
		button_1.Anchor = AnchorStyles.Bottom;
		button_1.Location = new Point(409, 456);
		button_1.Name = "button2";
		button_1.Size = new Size(75, 23);
		button_1.TabIndex = 14;
		button_1.Text = "Stop";
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		button_2.Anchor = AnchorStyles.Bottom;
		button_2.Location = new Point(329, 456);
		button_2.Name = "button1";
		button_2.Size = new Size(75, 23);
		button_2.TabIndex = 15;
		button_2.Text = "Start";
		button_2.UseVisualStyleBackColor = true;
		button_2.Click += button_2_Click;
		checkBox_11.AutoSize = true;
		checkBox_11.Location = new Point(24, 30);
		checkBox_11.Name = "checkBox36";
		checkBox_11.Size = new Size(115, 17);
		checkBox_11.TabIndex = 3;
		checkBox_11.Text = "CameraZoomHack";
		checkBox_11.UseVisualStyleBackColor = true;
		checkBox_11.CheckedChanged += checkBox_11_CheckedChanged;
		tabPage_2.BorderStyle = BorderStyle.FixedSingle;
		tabPage_2.Controls.Add(label_168);
		tabPage_2.Controls.Add(trackBar_3);
		tabPage_2.Controls.Add(checkBox_105);
		tabPage_2.Controls.Add(button_77);
		tabPage_2.Controls.Add(comboBox_25);
		tabPage_2.Controls.Add(label_133);
		tabPage_2.Controls.Add(comboBox_24);
		tabPage_2.Controls.Add(checkBox_87);
		tabPage_2.Controls.Add(checkBox_86);
		tabPage_2.Controls.Add(label_72);
		tabPage_2.Controls.Add(checkBox_53);
		tabPage_2.Controls.Add(textBox_10);
		tabPage_2.Controls.Add(label_33);
		tabPage_2.Controls.Add(label_32);
		tabPage_2.Controls.Add(comboBox_2);
		tabPage_2.Controls.Add(label_24);
		tabPage_2.Controls.Add(label_132);
		tabPage_2.Controls.Add(label_45);
		tabPage_2.Controls.Add(label_31);
		tabPage_2.Controls.Add(label_23);
		tabPage_2.Controls.Add(checkBox_34);
		tabPage_2.Controls.Add(checkBox_35);
		tabPage_2.Controls.Add(checkBox_11);
		tabPage_2.Location = new Point(4, 49);
		tabPage_2.Name = "tabPage5";
		tabPage_2.Padding = new Padding(10, 0, 0, 0);
		tabPage_2.Size = new Size(638, 370);
		tabPage_2.TabIndex = 5;
		tabPage_2.Text = "Cheat";
		tabPage_2.UseVisualStyleBackColor = true;
		label_168.AutoSize = true;
		label_168.BackColor = Color.FromArgb(192, 255, 192);
		label_168.Location = new Point(189, 41);
		label_168.Name = "label33";
		label_168.Size = new Size(43, 13);
		label_168.TabIndex = 56;
		label_168.Text = "Zoom --";
		trackBar_3.Location = new Point(141, 9);
		trackBar_3.Maximum = 116;
		trackBar_3.Minimum = 6;
		trackBar_3.Name = "trackBar4";
		trackBar_3.Size = new Size(133, 45);
		trackBar_3.TabIndex = 55;
		trackBar_3.TickFrequency = 10;
		trackBar_3.Value = 10;
		trackBar_3.Scroll += trackBar_3_Scroll;
		checkBox_105.AutoSize = true;
		checkBox_105.Checked = true;
		checkBox_105.CheckState = CheckState.Checked;
		checkBox_105.Location = new Point(128, 73);
		checkBox_105.Name = "checkBox5";
		checkBox_105.Size = new Size(85, 17);
		checkBox_105.TabIndex = 54;
		checkBox_105.Text = "ตอบรห\u0e31สภาพ";
		checkBox_105.UseVisualStyleBackColor = true;
		button_77.Location = new Point(161, 313);
		button_77.Name = "button77";
		button_77.Size = new Size(75, 23);
		button_77.TabIndex = 53;
		button_77.Text = "Load";
		button_77.UseVisualStyleBackColor = true;
		button_77.Click += button_77_Click;
		comboBox_25.FormattingEnabled = true;
		comboBox_25.Location = new Point(27, 315);
		comboBox_25.Name = "comboBox18";
		comboBox_25.Size = new Size(121, 21);
		comboBox_25.TabIndex = 52;
		label_133.AutoSize = true;
		label_133.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_133.Location = new Point(24, 295);
		label_133.Name = "label118";
		label_133.Size = new Size(156, 16);
		label_133.TabIndex = 51;
		label_133.Text = "## Load All Setting ##";
		comboBox_24.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_24.FormattingEnabled = true;
		comboBox_24.Items.AddRange(new object[2] { "เด\u0e49งส\u0e49มและหย\u0e38ดการทำงาน", "หย\u0e38ดการทำงานท\u0e31นท\u0e35" });
		comboBox_24.Location = new Point(130, 273);
		comboBox_24.Name = "comboBox17";
		comboBox_24.Size = new Size(121, 21);
		comboBox_24.TabIndex = 50;
		checkBox_87.AutoSize = true;
		checkBox_87.Location = new Point(24, 73);
		checkBox_87.Name = "checkBox88";
		checkBox_87.Size = new Size(98, 17);
		checkBox_87.TabIndex = 49;
		checkBox_87.Text = "ร\u0e31บปาต\u0e35\u0e49อ\u0e31ตโนม\u0e31ต\u0e34";
		checkBox_87.UseVisualStyleBackColor = true;
		checkBox_87.Visible = false;
		checkBox_86.AutoSize = true;
		checkBox_86.Location = new Point(24, 275);
		checkBox_86.Name = "checkBox87";
		checkBox_86.Size = new Size(100, 17);
		checkBox_86.TabIndex = 48;
		checkBox_86.Text = "หาก disconnect";
		checkBox_86.UseVisualStyleBackColor = true;
		label_72.AutoSize = true;
		label_72.BackColor = Color.FromArgb(255, 255, 128);
		label_72.Location = new Point(108, 145);
		label_72.Name = "label65";
		label_72.Size = new Size(107, 13);
		label_72.TabIndex = 47;
		label_72.Text = "อ\u0e35ก ..... ว\u0e34นาท\u0e35 เด\u0e49งกล\u0e31บ";
		checkBox_53.AutoSize = true;
		checkBox_53.Location = new Point(24, 235);
		checkBox_53.Name = "checkBox52";
		checkBox_53.Size = new Size(221, 17);
		checkBox_53.TabIndex = 11;
		checkBox_53.Text = "ป\u0e34ดการแจ\u0e49งเต\u0e37อนความผ\u0e34ดพลาด (Red Alert)";
		checkBox_53.UseVisualStyleBackColor = true;
		checkBox_53.CheckedChanged += checkBox_53_CheckedChanged;
		textBox_10.Location = new Point(111, 190);
		textBox_10.Name = "textBox24";
		textBox_10.Size = new Size(48, 20);
		textBox_10.TabIndex = 10;
		textBox_10.Text = "5";
		textBox_10.TextAlign = HorizontalAlignment.Center;
		label_33.AutoSize = true;
		label_33.BackColor = Color.FromArgb(128, 255, 255);
		label_33.Location = new Point(175, 194);
		label_33.Name = "label42";
		label_33.Size = new Size(33, 13);
		label_33.TabIndex = 9;
		label_33.Text = "ว\u0e34นาท\u0e35";
		label_32.AutoSize = true;
		label_32.BackColor = Color.FromArgb(128, 255, 255);
		label_32.Location = new Point(24, 194);
		label_32.Name = "label41";
		label_32.Size = new Size(91, 13);
		label_32.TabIndex = 9;
		label_32.Text = "Delay ก\u0e48อน เด\u0e49งฟ\u0e49า";
		comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_2.FormattingEnabled = true;
		comboBox_2.Items.AddRange(new object[3] { "หย\u0e38ดการทำงานของบอท", "วาปกล\u0e31บจ\u0e38ดเด\u0e34ม และทำงานต\u0e48อ", "สร\u0e49อยค\u0e37นช\u0e35พ" });
		comboBox_2.Location = new Point(24, 163);
		comboBox_2.Name = "comboBox4";
		comboBox_2.Size = new Size(161, 21);
		comboBox_2.TabIndex = 8;
		label_24.AutoSize = true;
		label_24.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_24.Location = new Point(21, 9);
		label_24.Name = "label26";
		label_24.Size = new Size(87, 16);
		label_24.TabIndex = 7;
		label_24.Text = "## Cheat ##";
		label_132.AutoSize = true;
		label_132.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_132.Location = new Point(21, 255);
		label_132.Name = "label117";
		label_132.Size = new Size(124, 16);
		label_132.TabIndex = 7;
		label_132.Text = "## Disconnect ##";
		label_45.AutoSize = true;
		label_45.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_45.Location = new Point(21, 215);
		label_45.Name = "label60";
		label_45.Size = new Size(112, 16);
		label_45.TabIndex = 7;
		label_45.Text = "## Msg Alert ##";
		label_31.AutoSize = true;
		label_31.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_31.Location = new Point(21, 143);
		label_31.Name = "label38";
		label_31.Size = new Size(68, 16);
		label_31.TabIndex = 7;
		label_31.Text = "## ตาย ##";
		label_23.AutoSize = true;
		label_23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_23.Location = new Point(21, 52);
		label_23.Name = "label25";
		label_23.Size = new Size(102, 16);
		label_23.TabIndex = 7;
		label_23.Text = "## General ##";
		checkBox_34.AutoSize = true;
		checkBox_34.Location = new Point(24, 120);
		checkBox_34.Name = "checkBox4";
		checkBox_34.Size = new Size(129, 17);
		checkBox_34.TabIndex = 6;
		checkBox_34.Text = "Show CharName Title";
		checkBox_34.UseVisualStyleBackColor = true;
		checkBox_35.AutoSize = true;
		checkBox_35.Location = new Point(24, 96);
		checkBox_35.Name = "checkBox3";
		checkBox_35.Size = new Size(90, 17);
		checkBox_35.TabIndex = 5;
		checkBox_35.Text = "Show ID Title";
		checkBox_35.UseVisualStyleBackColor = true;
		label_5.Location = new Point(121, 248);
		label_5.Name = "label18";
		label_5.Size = new Size(40, 17);
		label_5.TabIndex = 12;
		label_5.Text = "0";
		label_5.TextAlign = ContentAlignment.MiddleCenter;
		label_6.Location = new Point(272, 248);
		label_6.Name = "label19";
		label_6.Size = new Size(40, 17);
		label_6.TabIndex = 12;
		label_6.Text = "0";
		label_6.TextAlign = ContentAlignment.MiddleCenter;
		label_7.Location = new Point(272, 227);
		label_7.Name = "label17";
		label_7.Size = new Size(40, 17);
		label_7.TabIndex = 12;
		label_7.Text = "0";
		label_7.TextAlign = ContentAlignment.MiddleCenter;
		label_8.Location = new Point(121, 227);
		label_8.Name = "label16";
		label_8.Size = new Size(40, 17);
		label_8.TabIndex = 12;
		label_8.Text = "0";
		label_8.TextAlign = ContentAlignment.MiddleCenter;
		label_9.Location = new Point(272, 204);
		label_9.Name = "label15";
		label_9.Size = new Size(40, 17);
		label_9.TabIndex = 12;
		label_9.Text = "0";
		label_9.TextAlign = ContentAlignment.MiddleCenter;
		label_10.Location = new Point(121, 204);
		label_10.Name = "label14";
		label_10.Size = new Size(40, 17);
		label_10.TabIndex = 12;
		label_10.Text = "0";
		label_10.TextAlign = ContentAlignment.MiddleCenter;
		radioButton_7.AutoSize = true;
		radioButton_7.Location = new Point(133, 128);
		radioButton_7.Name = "radioButton52";
		radioButton_7.Size = new Size(37, 17);
		radioButton_7.TabIndex = 11;
		radioButton_7.TabStop = true;
		radioButton_7.Text = "F3";
		radioButton_7.UseVisualStyleBackColor = true;
		radioButton_8.AutoSize = true;
		radioButton_8.Location = new Point(90, 128);
		radioButton_8.Name = "radioButton51";
		radioButton_8.Size = new Size(37, 17);
		radioButton_8.TabIndex = 11;
		radioButton_8.TabStop = true;
		radioButton_8.Text = "F2";
		radioButton_8.UseVisualStyleBackColor = true;
		radioButton_9.AutoSize = true;
		radioButton_9.Checked = true;
		radioButton_9.Location = new Point(53, 128);
		radioButton_9.Name = "radioButton50";
		radioButton_9.Size = new Size(37, 17);
		radioButton_9.TabIndex = 11;
		radioButton_9.TabStop = true;
		radioButton_9.Text = "F1";
		radioButton_9.UseVisualStyleBackColor = true;
		label_11.AutoSize = true;
		label_11.Location = new Point(290, 108);
		label_11.Name = "label9";
		label_11.Size = new Size(15, 13);
		label_11.TabIndex = 10;
		label_11.Text = "%";
		label_12.AutoSize = true;
		label_12.Location = new Point(290, 82);
		label_12.Name = "label8";
		label_12.Size = new Size(15, 13);
		label_12.TabIndex = 10;
		label_12.Text = "%";
		label_13.AutoSize = true;
		label_13.Location = new Point(290, 55);
		label_13.Name = "label7";
		label_13.Size = new Size(15, 13);
		label_13.TabIndex = 10;
		label_13.Text = "%";
		checkBox_12.AutoSize = true;
		checkBox_12.Checked = true;
		checkBox_12.CheckState = CheckState.Checked;
		checkBox_12.Location = new Point(5, 107);
		checkBox_12.Name = "checkBox28";
		checkBox_12.Size = new Size(40, 17);
		checkBox_12.TabIndex = 6;
		checkBox_12.Text = "SP";
		checkBox_12.UseVisualStyleBackColor = true;
		checkBox_12.CheckedChanged += checkBox_12_CheckedChanged;
		checkBox_13.AutoSize = true;
		checkBox_13.Checked = true;
		checkBox_13.CheckState = CheckState.Checked;
		checkBox_13.Location = new Point(5, 80);
		checkBox_13.Name = "checkBox27";
		checkBox_13.Size = new Size(42, 17);
		checkBox_13.TabIndex = 7;
		checkBox_13.Text = "MP";
		checkBox_13.UseVisualStyleBackColor = true;
		checkBox_13.CheckedChanged += checkBox_13_CheckedChanged;
		checkBox_14.AutoSize = true;
		checkBox_14.Checked = true;
		checkBox_14.CheckState = CheckState.Checked;
		checkBox_14.Location = new Point(5, 52);
		checkBox_14.Name = "checkBox26";
		checkBox_14.Size = new Size(41, 17);
		checkBox_14.TabIndex = 8;
		checkBox_14.Text = "HP";
		checkBox_14.UseVisualStyleBackColor = true;
		checkBox_14.CheckedChanged += checkBox_14_CheckedChanged;
		textBox_0.Location = new Point(232, 104);
		textBox_0.Name = "textBox15";
		textBox_0.Size = new Size(48, 20);
		textBox_0.TabIndex = 5;
		textBox_0.Text = "90";
		textBox_0.TextAlign = HorizontalAlignment.Center;
		textBox_1.Location = new Point(232, 77);
		textBox_1.Name = "textBox14";
		textBox_1.Size = new Size(48, 20);
		textBox_1.TabIndex = 5;
		textBox_1.Text = "90";
		textBox_1.TextAlign = HorizontalAlignment.Center;
		textBox_2.Location = new Point(232, 51);
		textBox_2.Name = "textBox13";
		textBox_2.Size = new Size(48, 20);
		textBox_2.TabIndex = 5;
		textBox_2.Text = "90";
		textBox_2.TextAlign = HorizontalAlignment.Center;
		label_14.AutoSize = true;
		label_14.BackColor = Color.FromArgb(255, 255, 192);
		label_14.Location = new Point(13, 31);
		label_14.Name = "label6";
		label_14.Size = new Size(37, 13);
		label_14.TabIndex = 4;
		label_14.Text = "Potion";
		textBox_3.Location = new Point(221, 272);
		textBox_3.Name = "textBox21";
		textBox_3.Size = new Size(45, 20);
		textBox_3.TabIndex = 2;
		textBox_3.Text = "10";
		textBox_3.TextAlign = HorizontalAlignment.Center;
		textBox_4.Location = new Point(71, 272);
		textBox_4.Name = "textBox20";
		textBox_4.Size = new Size(45, 20);
		textBox_4.TabIndex = 2;
		textBox_4.Text = "10";
		textBox_4.TextAlign = HorizontalAlignment.Center;
		label_15.AutoSize = true;
		label_15.BackColor = Color.FromArgb(192, 255, 192);
		label_15.Location = new Point(13, 187);
		label_15.Name = "label5";
		label_15.Size = new Size(62, 13);
		label_15.TabIndex = 1;
		label_15.Text = "Buff <--- F4 ";
		label_16.AutoSize = true;
		label_16.BackColor = Color.FromArgb(255, 192, 192);
		label_16.Location = new Point(13, 129);
		label_16.Name = "label4";
		label_16.Size = new Size(38, 13);
		label_16.TabIndex = 1;
		label_16.Text = "Attack";
		tabPage_3.BorderStyle = BorderStyle.FixedSingle;
		tabPage_3.Controls.Add(comboBox_29);
		tabPage_3.Controls.Add(comboBox_30);
		tabPage_3.Controls.Add(comboBox_28);
		tabPage_3.Controls.Add(checkBox_100);
		tabPage_3.Controls.Add(label_87);
		tabPage_3.Controls.Add(textBox_13);
		tabPage_3.Controls.Add(textBox_14);
		tabPage_3.Controls.Add(textBox_15);
		tabPage_3.Controls.Add(textBox_16);
		tabPage_3.Controls.Add(textBox_17);
		tabPage_3.Controls.Add(textBox_18);
		tabPage_3.Controls.Add(button_35);
		tabPage_3.Controls.Add(button_36);
		tabPage_3.Controls.Add(label_17);
		tabPage_3.Controls.Add(label_18);
		tabPage_3.Controls.Add(label_5);
		tabPage_3.Controls.Add(label_29);
		tabPage_3.Controls.Add(label_30);
		tabPage_3.Controls.Add(label_6);
		tabPage_3.Controls.Add(label_7);
		tabPage_3.Controls.Add(label_8);
		tabPage_3.Controls.Add(label_9);
		tabPage_3.Controls.Add(label_10);
		tabPage_3.Controls.Add(radioButton_7);
		tabPage_3.Controls.Add(radioButton_8);
		tabPage_3.Controls.Add(radioButton_9);
		tabPage_3.Controls.Add(label_11);
		tabPage_3.Controls.Add(label_12);
		tabPage_3.Controls.Add(label_13);
		tabPage_3.Controls.Add(checkBox_12);
		tabPage_3.Controls.Add(checkBox_13);
		tabPage_3.Controls.Add(checkBox_14);
		tabPage_3.Controls.Add(textBox_0);
		tabPage_3.Controls.Add(textBox_1);
		tabPage_3.Controls.Add(textBox_2);
		tabPage_3.Controls.Add(label_21);
		tabPage_3.Controls.Add(label_14);
		tabPage_3.Controls.Add(textBox_36);
		tabPage_3.Controls.Add(textBox_37);
		tabPage_3.Controls.Add(textBox_3);
		tabPage_3.Controls.Add(textBox_4);
		tabPage_3.Controls.Add(label_15);
		tabPage_3.Controls.Add(label_16);
		tabPage_3.Controls.Add(checkBox_15);
		tabPage_3.Controls.Add(checkBox_16);
		tabPage_3.Controls.Add(checkBox_17);
		tabPage_3.Controls.Add(checkBox_18);
		tabPage_3.Controls.Add(checkBox_19);
		tabPage_3.Controls.Add(checkBox_20);
		tabPage_3.Controls.Add(checkBox_21);
		tabPage_3.Controls.Add(checkBox_22);
		tabPage_3.Controls.Add(checkBox_23);
		tabPage_3.Controls.Add(checkBox_24);
		tabPage_3.Controls.Add(checkBox_25);
		tabPage_3.Controls.Add(checkBox_26);
		tabPage_3.Controls.Add(checkBox_27);
		tabPage_3.Controls.Add(checkBox_28);
		tabPage_3.Controls.Add(checkBox_29);
		tabPage_3.Controls.Add(checkBox_30);
		tabPage_3.Controls.Add(checkBox_31);
		tabPage_3.Controls.Add(checkBox_9);
		tabPage_3.Controls.Add(checkBox_1);
		tabPage_3.Controls.Add(checkBox_8);
		tabPage_3.Controls.Add(label_28);
		tabPage_3.Controls.Add(label_27);
		tabPage_3.Location = new Point(4, 49);
		tabPage_3.Name = "tabPage1";
		tabPage_3.Padding = new Padding(10, 3, 3, 3);
		tabPage_3.Size = new Size(638, 370);
		tabPage_3.TabIndex = 2;
		tabPage_3.Text = "Skill Potion";
		tabPage_3.UseVisualStyleBackColor = true;
		tabPage_3.Click += tabPage_3_Click;
		comboBox_29.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_29.FormattingEnabled = true;
		comboBox_29.Location = new Point(42, 103);
		comboBox_29.Name = "comboBox26";
		comboBox_29.Size = new Size(37, 21);
		comboBox_29.TabIndex = 22;
		comboBox_30.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_30.FormattingEnabled = true;
		comboBox_30.Location = new Point(42, 76);
		comboBox_30.Name = "comboBox25";
		comboBox_30.Size = new Size(37, 21);
		comboBox_30.TabIndex = 21;
		comboBox_28.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_28.FormattingEnabled = true;
		comboBox_28.Location = new Point(42, 49);
		comboBox_28.Name = "comboBox24";
		comboBox_28.Size = new Size(37, 21);
		comboBox_28.TabIndex = 20;
		checkBox_100.AutoSize = true;
		checkBox_100.Location = new Point(172, 129);
		checkBox_100.Name = "checkBox69";
		checkBox_100.Size = new Size(83, 17);
		checkBox_100.TabIndex = 19;
		checkBox_100.Text = "ไม\u0e48ต\u0e35ธรรมดา";
		checkBox_100.UseVisualStyleBackColor = true;
		label_87.AutoEllipsis = true;
		label_87.BackColor = Color.FromArgb(255, 128, 128);
		label_87.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_87.Location = new Point(187, 299);
		label_87.Name = "label59";
		label_87.Size = new Size(93, 29);
		label_87.TabIndex = 17;
		label_87.Text = "** สำหร\u0e31บสก\u0e34ล Heal    ใช\u0e49  8  เท\u0e48าน\u0e31\u0e49น";
		textBox_13.Location = new Point(221, 249);
		textBox_13.Name = "textBox31";
		textBox_13.Size = new Size(45, 20);
		textBox_13.TabIndex = 16;
		textBox_13.Text = "20";
		textBox_13.TextAlign = HorizontalAlignment.Center;
		textBox_14.Location = new Point(71, 249);
		textBox_14.Name = "textBox30";
		textBox_14.Size = new Size(45, 20);
		textBox_14.TabIndex = 16;
		textBox_14.Text = "20";
		textBox_14.TextAlign = HorizontalAlignment.Center;
		textBox_15.Location = new Point(221, 226);
		textBox_15.Name = "textBox29";
		textBox_15.Size = new Size(45, 20);
		textBox_15.TabIndex = 16;
		textBox_15.Text = "20";
		textBox_15.TextAlign = HorizontalAlignment.Center;
		textBox_16.Location = new Point(71, 226);
		textBox_16.Name = "textBox28";
		textBox_16.Size = new Size(45, 20);
		textBox_16.TabIndex = 16;
		textBox_16.Text = "20";
		textBox_16.TextAlign = HorizontalAlignment.Center;
		textBox_17.Location = new Point(221, 203);
		textBox_17.Name = "textBox27";
		textBox_17.Size = new Size(45, 20);
		textBox_17.TabIndex = 16;
		textBox_17.Text = "20";
		textBox_17.TextAlign = HorizontalAlignment.Center;
		textBox_18.Location = new Point(71, 203);
		textBox_18.Name = "textBox26";
		textBox_18.Size = new Size(45, 20);
		textBox_18.TabIndex = 16;
		textBox_18.Text = "20";
		textBox_18.TextAlign = HorizontalAlignment.Center;
		button_35.BackColor = Color.FromArgb(128, 255, 255);
		button_35.Location = new Point(116, 319);
		button_35.Name = "button21";
		button_35.Size = new Size(48, 22);
		button_35.TabIndex = 15;
		button_35.Text = "Party";
		button_35.UseVisualStyleBackColor = false;
		button_35.Click += button_35_Click;
		button_36.BackColor = Color.FromArgb(128, 255, 255);
		button_36.Location = new Point(116, 294);
		button_36.Name = "button20";
		button_36.Size = new Size(48, 22);
		button_36.TabIndex = 15;
		button_36.Text = "Party";
		button_36.UseVisualStyleBackColor = false;
		button_36.Click += button_36_Click;
		label_17.AutoSize = true;
		label_17.BackColor = Color.FromArgb(192, 255, 255);
		label_17.ForeColor = Color.Black;
		label_17.Location = new Point(76, 10);
		label_17.Name = "label20";
		label_17.Size = new Size(60, 13);
		label_17.TabIndex = 13;
		label_17.Text = "Money : 10";
		label_18.AutoSize = true;
		label_18.BackColor = Color.FromArgb(192, 255, 192);
		label_18.ForeColor = Color.Black;
		label_18.Location = new Point(16, 10);
		label_18.Name = "label12";
		label_18.Size = new Size(41, 13);
		label_18.TabIndex = 13;
		label_18.Text = "LV : 10";
		label_29.Location = new Point(271, 275);
		label_29.Name = "label30";
		label_29.Size = new Size(40, 17);
		label_29.TabIndex = 12;
		label_29.Text = "0";
		label_29.TextAlign = ContentAlignment.MiddleCenter;
		label_30.Location = new Point(120, 274);
		label_30.Name = "label29";
		label_30.Size = new Size(39, 17);
		label_30.TabIndex = 12;
		label_30.Text = "0";
		label_30.TextAlign = ContentAlignment.MiddleCenter;
		label_21.AutoSize = true;
		label_21.BackColor = Color.FromArgb(255, 255, 192);
		label_21.Location = new Point(216, 2);
		label_21.Name = "label23";
		label_21.Size = new Size(51, 13);
		label_21.TabIndex = 4;
		label_21.Text = "Version : ";
		textBox_36.Location = new Point(71, 319);
		textBox_36.Name = "textBox44";
		textBox_36.Size = new Size(45, 20);
		textBox_36.TabIndex = 2;
		textBox_36.Text = "10";
		textBox_36.TextAlign = HorizontalAlignment.Center;
		textBox_37.Location = new Point(71, 296);
		textBox_37.Name = "textBox43";
		textBox_37.Size = new Size(45, 20);
		textBox_37.TabIndex = 2;
		textBox_37.Text = "10";
		textBox_37.TextAlign = HorizontalAlignment.Center;
		checkBox_15.AutoSize = true;
		checkBox_15.Location = new Point(16, 321);
		checkBox_15.Name = "checkBox25";
		checkBox_15.Size = new Size(60, 17);
		checkBox_15.TabIndex = 0;
		checkBox_15.Text = "Buff 10";
		checkBox_15.UseVisualStyleBackColor = true;
		checkBox_16.AutoSize = true;
		checkBox_16.Location = new Point(15, 298);
		checkBox_16.Name = "checkBox24";
		checkBox_16.Size = new Size(54, 17);
		checkBox_16.TabIndex = 0;
		checkBox_16.Text = "Buff 9";
		checkBox_16.UseVisualStyleBackColor = true;
		checkBox_17.AutoSize = true;
		checkBox_17.Location = new Point(167, 274);
		checkBox_17.Name = "checkBox23";
		checkBox_17.Size = new Size(54, 17);
		checkBox_17.TabIndex = 0;
		checkBox_17.Text = "Buff 8";
		checkBox_17.UseVisualStyleBackColor = true;
		checkBox_18.AutoSize = true;
		checkBox_18.Location = new Point(16, 275);
		checkBox_18.Name = "checkBox22";
		checkBox_18.Size = new Size(54, 17);
		checkBox_18.TabIndex = 0;
		checkBox_18.Text = "Buff 7";
		checkBox_18.UseVisualStyleBackColor = true;
		checkBox_19.AutoSize = true;
		checkBox_19.Checked = true;
		checkBox_19.CheckState = CheckState.Checked;
		checkBox_19.Location = new Point(167, 248);
		checkBox_19.Name = "checkBox21";
		checkBox_19.Size = new Size(54, 17);
		checkBox_19.TabIndex = 0;
		checkBox_19.Text = "Buff 6";
		checkBox_19.UseVisualStyleBackColor = true;
		checkBox_20.AutoSize = true;
		checkBox_20.Checked = true;
		checkBox_20.CheckState = CheckState.Checked;
		checkBox_20.Location = new Point(16, 249);
		checkBox_20.Name = "checkBox20";
		checkBox_20.Size = new Size(54, 17);
		checkBox_20.TabIndex = 0;
		checkBox_20.Text = "Buff 5";
		checkBox_20.UseVisualStyleBackColor = true;
		checkBox_21.AutoSize = true;
		checkBox_21.Checked = true;
		checkBox_21.CheckState = CheckState.Checked;
		checkBox_21.Location = new Point(167, 227);
		checkBox_21.Name = "checkBox19";
		checkBox_21.Size = new Size(54, 17);
		checkBox_21.TabIndex = 0;
		checkBox_21.Text = "Buff 4";
		checkBox_21.UseVisualStyleBackColor = true;
		checkBox_22.AutoSize = true;
		checkBox_22.Checked = true;
		checkBox_22.CheckState = CheckState.Checked;
		checkBox_22.Location = new Point(16, 228);
		checkBox_22.Name = "checkBox18";
		checkBox_22.Size = new Size(54, 17);
		checkBox_22.TabIndex = 0;
		checkBox_22.Text = "Buff 3";
		checkBox_22.UseVisualStyleBackColor = true;
		checkBox_23.AutoSize = true;
		checkBox_23.Checked = true;
		checkBox_23.CheckState = CheckState.Checked;
		checkBox_23.Location = new Point(167, 204);
		checkBox_23.Name = "checkBox17";
		checkBox_23.Size = new Size(54, 17);
		checkBox_23.TabIndex = 0;
		checkBox_23.Text = "Buff 2";
		checkBox_23.UseVisualStyleBackColor = true;
		checkBox_24.AutoSize = true;
		checkBox_24.Checked = true;
		checkBox_24.CheckState = CheckState.Checked;
		checkBox_24.Location = new Point(16, 205);
		checkBox_24.Name = "checkBox16";
		checkBox_24.Size = new Size(54, 17);
		checkBox_24.TabIndex = 0;
		checkBox_24.Text = "Buff 1";
		checkBox_24.UseVisualStyleBackColor = true;
		checkBox_25.AutoSize = true;
		checkBox_25.Checked = true;
		checkBox_25.CheckState = CheckState.Checked;
		checkBox_25.Location = new Point(242, 166);
		checkBox_25.Name = "checkBox15";
		checkBox_25.Size = new Size(60, 17);
		checkBox_25.TabIndex = 0;
		checkBox_25.Text = "Skill 10";
		checkBox_25.UseVisualStyleBackColor = true;
		checkBox_26.AutoSize = true;
		checkBox_26.Checked = true;
		checkBox_26.CheckState = CheckState.Checked;
		checkBox_26.Location = new Point(190, 166);
		checkBox_26.Name = "checkBox14";
		checkBox_26.Size = new Size(54, 17);
		checkBox_26.TabIndex = 0;
		checkBox_26.Text = "Skill 9";
		checkBox_26.UseVisualStyleBackColor = true;
		checkBox_27.AutoSize = true;
		checkBox_27.Checked = true;
		checkBox_27.CheckState = CheckState.Checked;
		checkBox_27.Location = new Point(130, 166);
		checkBox_27.Name = "checkBox13";
		checkBox_27.Size = new Size(54, 17);
		checkBox_27.TabIndex = 0;
		checkBox_27.Text = "Skill 8";
		checkBox_27.UseVisualStyleBackColor = true;
		checkBox_28.AutoSize = true;
		checkBox_28.Checked = true;
		checkBox_28.CheckState = CheckState.Checked;
		checkBox_28.Location = new Point(67, 166);
		checkBox_28.Name = "checkBox12";
		checkBox_28.Size = new Size(54, 17);
		checkBox_28.TabIndex = 0;
		checkBox_28.Text = "Skill 7";
		checkBox_28.UseVisualStyleBackColor = true;
		checkBox_29.AutoSize = true;
		checkBox_29.Checked = true;
		checkBox_29.CheckState = CheckState.Checked;
		checkBox_29.Location = new Point(16, 166);
		checkBox_29.Name = "checkBox11";
		checkBox_29.Size = new Size(54, 17);
		checkBox_29.TabIndex = 0;
		checkBox_29.Text = "Skill 6";
		checkBox_29.UseVisualStyleBackColor = true;
		checkBox_30.AutoSize = true;
		checkBox_30.Checked = true;
		checkBox_30.CheckState = CheckState.Checked;
		checkBox_30.Location = new Point(242, 146);
		checkBox_30.Name = "checkBox10";
		checkBox_30.Size = new Size(54, 17);
		checkBox_30.TabIndex = 0;
		checkBox_30.Text = "Skill 5";
		checkBox_30.UseVisualStyleBackColor = true;
		checkBox_31.AutoSize = true;
		checkBox_31.Checked = true;
		checkBox_31.CheckState = CheckState.Checked;
		checkBox_31.Location = new Point(190, 146);
		checkBox_31.Name = "checkBox9";
		checkBox_31.Size = new Size(54, 17);
		checkBox_31.TabIndex = 0;
		checkBox_31.Text = "Skill 4";
		checkBox_31.UseVisualStyleBackColor = true;
		label_28.Location = new Point(153, 297);
		label_28.Name = "label31";
		label_28.Size = new Size(39, 17);
		label_28.TabIndex = 12;
		label_28.Text = "0";
		label_28.TextAlign = ContentAlignment.MiddleCenter;
		label_27.Location = new Point(153, 321);
		label_27.Name = "label32";
		label_27.Size = new Size(40, 17);
		label_27.TabIndex = 12;
		label_27.Text = "0";
		label_27.TextAlign = ContentAlignment.MiddleCenter;
		tabControl_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		tabControl_0.Appearance = TabAppearance.Buttons;
		tabControl_0.Controls.Add(tabPage_3);
		tabControl_0.Controls.Add(tabPage_1);
		tabControl_0.Controls.Add(tabPage_5);
		tabControl_0.Controls.Add(tabPage_0);
		tabControl_0.Controls.Add(tabPage_4);
		tabControl_0.Controls.Add(tabPage_2);
		tabControl_0.Controls.Add(tabPage_6);
		tabControl_0.Controls.Add(tabPage_7);
		tabControl_0.Controls.Add(tabPage_10);
		tabControl_0.Controls.Add(tabPage_12);
		tabControl_0.Controls.Add(tabPage_8);
		tabControl_0.Controls.Add(tabPage_9);
		tabControl_0.Controls.Add(tabPage_11);
		tabControl_0.Controls.Add(tabPage_13);
		tabControl_0.Controls.Add(tabPage_14);
		tabControl_0.Controls.Add(tabPage_15);
		tabControl_0.Controls.Add(tabPage_16);
		tabControl_0.Controls.Add(tabPage_17);
		tabControl_0.Location = new Point(3, 8);
		tabControl_0.Multiline = true;
		tabControl_0.Name = "tabControl1";
		tabControl_0.SelectedIndex = 0;
		tabControl_0.Size = new Size(646, 423);
		tabControl_0.TabIndex = 13;
		tabControl_0.SelectedIndexChanged += tabControl_0_SelectedIndexChanged;
		tabPage_5.BorderStyle = BorderStyle.FixedSingle;
		tabPage_5.Controls.Add(checkBox_102);
		tabPage_5.Controls.Add(label_129);
		tabPage_5.Controls.Add(textBox_55);
		tabPage_5.Controls.Add(checkBox_73);
		tabPage_5.Controls.Add(label_74);
		tabPage_5.Controls.Add(label_75);
		tabPage_5.Controls.Add(textBox_32);
		tabPage_5.Controls.Add(checkBox_68);
		tabPage_5.Controls.Add(checkBox_43);
		tabPage_5.Controls.Add(checkBox_38);
		tabPage_5.Controls.Add(label_26);
		tabPage_5.Controls.Add(label_25);
		tabPage_5.Controls.Add(textBox_9);
		tabPage_5.Controls.Add(textBox_7);
		tabPage_5.Controls.Add(checkBox_36);
		tabPage_5.Controls.Add(button_15);
		tabPage_5.Controls.Add(button_34);
		tabPage_5.Controls.Add(button_16);
		tabPage_5.Controls.Add(button_18);
		tabPage_5.Controls.Add(button_19);
		tabPage_5.Controls.Add(button_20);
		tabPage_5.Controls.Add(button_21);
		tabPage_5.Controls.Add(button_22);
		tabPage_5.Controls.Add(button_23);
		tabPage_5.Controls.Add(button_24);
		tabPage_5.Controls.Add(button_25);
		tabPage_5.Controls.Add(button_26);
		tabPage_5.Controls.Add(button_27);
		tabPage_5.Controls.Add(button_28);
		tabPage_5.Controls.Add(button_29);
		tabPage_5.Controls.Add(button_30);
		tabPage_5.Controls.Add(button_31);
		tabPage_5.Controls.Add(button_32);
		tabPage_5.Controls.Add(button_17);
		tabPage_5.Controls.Add(dataGridView_15);
		tabPage_5.Controls.Add(dataGridView_16);
		tabPage_5.Controls.Add(dataGridView_3);
		tabPage_5.Controls.Add(dataGridView_4);
		tabPage_5.Controls.Add(dataGridView_5);
		tabPage_5.Controls.Add(dataGridView_17);
		tabPage_5.Controls.Add(dataGridView_6);
		tabPage_5.Controls.Add(dataGridView_7);
		tabPage_5.Controls.Add(dataGridView_8);
		tabPage_5.Controls.Add(dataGridView_18);
		tabPage_5.Controls.Add(dataGridView_9);
		tabPage_5.Controls.Add(dataGridView_10);
		tabPage_5.Controls.Add(dataGridView_11);
		tabPage_5.Controls.Add(dataGridView_12);
		tabPage_5.Controls.Add(dataGridView_13);
		tabPage_5.Controls.Add(dataGridView_14);
		tabPage_5.Location = new Point(4, 49);
		tabPage_5.Name = "tabPage3";
		tabPage_5.Size = new Size(638, 370);
		tabPage_5.TabIndex = 7;
		tabPage_5.Text = "Looper";
		tabPage_5.UseVisualStyleBackColor = true;
		checkBox_102.AutoSize = true;
		checkBox_102.Checked = true;
		checkBox_102.CheckState = CheckState.Checked;
		checkBox_102.Location = new Point(13, 319);
		checkBox_102.Name = "checkBox96";
		checkBox_102.Size = new Size(71, 17);
		checkBox_102.TabIndex = 44;
		checkBox_102.Text = "Waypoint";
		checkBox_102.UseVisualStyleBackColor = true;
		label_129.AutoSize = true;
		label_129.Location = new Point(276, 63);
		label_129.Name = "label116";
		label_129.Size = new Size(14, 13);
		label_129.TabIndex = 43;
		label_129.Text = "S";
		textBox_55.Location = new Point(228, 58);
		textBox_55.Name = "textBox59";
		textBox_55.Size = new Size(38, 20);
		textBox_55.TabIndex = 42;
		textBox_55.Text = "10";
		textBox_55.TextAlign = HorizontalAlignment.Center;
		checkBox_73.AutoSize = true;
		checkBox_73.Location = new Point(127, 34);
		checkBox_73.Name = "checkBox77";
		checkBox_73.Size = new Size(113, 17);
		checkBox_73.TabIndex = 41;
		checkBox_73.Text = "บ\u0e31พระหว\u0e48างว\u0e34\u0e48ง Loop";
		checkBox_73.UseVisualStyleBackColor = true;
		checkBox_73.CheckedChanged += checkBox_73_CheckedChanged;
		label_74.AutoSize = true;
		label_74.BackColor = Color.FromArgb(128, 255, 128);
		label_74.Location = new Point(110, 322);
		label_74.Name = "label67";
		label_74.Size = new Size(181, 13);
		label_74.TabIndex = 40;
		label_74.Text = "อบ\u0e39\u0e48ใน Loop Monster มาแล\u0e49ว .... ว\u0e34นาท\u0e35";
		label_75.AutoSize = true;
		label_75.Location = new Point(252, 300);
		label_75.Name = "label36";
		label_75.Size = new Size(33, 13);
		label_75.TabIndex = 39;
		label_75.Text = "ว\u0e34นาท\u0e35";
		textBox_32.Location = new Point(195, 293);
		textBox_32.Name = "textBox16";
		textBox_32.Size = new Size(51, 20);
		textBox_32.TabIndex = 38;
		textBox_32.Text = "60";
		textBox_32.TextAlign = HorizontalAlignment.Center;
		checkBox_68.AutoSize = true;
		checkBox_68.Location = new Point(13, 298);
		checkBox_68.Name = "checkBox68";
		checkBox_68.Size = new Size(184, 17);
		checkBox_68.TabIndex = 37;
		checkBox_68.Text = "Reset Loop หากต\u0e35 Monster นาน >";
		checkBox_68.UseVisualStyleBackColor = true;
		checkBox_43.AutoSize = true;
		checkBox_43.Location = new Point(81, 35);
		checkBox_43.Name = "checkBox46";
		checkBox_43.Size = new Size(46, 17);
		checkBox_43.TabIndex = 36;
		checkBox_43.Text = "ไม\u0e48ต\u0e35";
		checkBox_43.UseVisualStyleBackColor = true;
		checkBox_38.AutoSize = true;
		checkBox_38.Location = new Point(243, 35);
		checkBox_38.Name = "checkBox40";
		checkBox_38.Size = new Size(56, 17);
		checkBox_38.TabIndex = 34;
		checkBox_38.Text = "เด\u0e49งส\u0e49ม";
		checkBox_38.UseVisualStyleBackColor = true;
		label_26.AutoSize = true;
		label_26.BackColor = Color.FromArgb(192, 192, 255);
		label_26.ForeColor = Color.Black;
		label_26.Location = new Point(164, 12);
		label_26.Name = "label28";
		label_26.Size = new Size(62, 13);
		label_26.TabIndex = 31;
		label_26.Text = "Delay หล\u0e31งต\u0e35";
		label_25.AutoSize = true;
		label_25.BackColor = Color.FromArgb(192, 255, 255);
		label_25.ForeColor = Color.Black;
		label_25.Location = new Point(25, 12);
		label_25.Name = "label1";
		label_25.Size = new Size(65, 13);
		label_25.TabIndex = 31;
		label_25.Text = "Delay ก\u0e48อนต\u0e35";
		textBox_9.Location = new Point(237, 9);
		textBox_9.Name = "textBox8";
		textBox_9.Size = new Size(53, 20);
		textBox_9.TabIndex = 30;
		textBox_9.Text = "10";
		textBox_9.TextAlign = HorizontalAlignment.Center;
		textBox_7.Location = new Point(98, 9);
		textBox_7.Name = "textBox4";
		textBox_7.Size = new Size(53, 20);
		textBox_7.TabIndex = 30;
		textBox_7.Text = "10";
		textBox_7.TextAlign = HorizontalAlignment.Center;
		checkBox_36.AutoSize = true;
		checkBox_36.Location = new Point(5, 34);
		checkBox_36.Name = "checkBox54";
		checkBox_36.Size = new Size(75, 17);
		checkBox_36.TabIndex = 28;
		checkBox_36.Text = "ส\u0e38\u0e48ม Looper";
		checkBox_36.UseVisualStyleBackColor = true;
		button_15.Location = new Point(6, 58);
		button_15.Name = "button34";
		button_15.Size = new Size(69, 21);
		button_15.TabIndex = 27;
		button_15.Text = "โหลด";
		button_15.UseVisualStyleBackColor = true;
		button_15.Click += button_15_Click;
		button_34.Location = new Point(152, 57);
		button_34.Name = "button18";
		button_34.Size = new Size(66, 22);
		button_34.TabIndex = 27;
		button_34.Text = "ล\u0e49าง";
		button_34.UseVisualStyleBackColor = true;
		button_34.Click += button_34_Click;
		button_16.Location = new Point(80, 57);
		button_16.Name = "button33";
		button_16.Size = new Size(66, 22);
		button_16.TabIndex = 27;
		button_16.Text = "บ\u0e31นท\u0e36ก";
		button_16.UseVisualStyleBackColor = true;
		button_16.Click += button_16_Click;
		button_18.BackColor = Color.FromArgb(255, 128, 128);
		button_18.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_18.Location = new Point(239, 243);
		button_18.Name = "button66";
		button_18.Size = new Size(59, 23);
		button_18.TabIndex = 25;
		button_18.Text = "Rec";
		button_18.UseVisualStyleBackColor = false;
		button_19.BackColor = Color.FromArgb(255, 128, 128);
		button_19.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_19.Location = new Point(87, 243);
		button_19.Name = "button64";
		button_19.Size = new Size(59, 23);
		button_19.TabIndex = 25;
		button_19.Text = "Rec";
		button_19.UseVisualStyleBackColor = false;
		button_20.BackColor = Color.FromArgb(255, 128, 128);
		button_20.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_20.Location = new Point(239, 191);
		button_20.Name = "button62";
		button_20.Size = new Size(59, 23);
		button_20.TabIndex = 25;
		button_20.Text = "Rec";
		button_20.UseVisualStyleBackColor = false;
		button_21.BackColor = Color.FromArgb(255, 128, 128);
		button_21.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_21.Location = new Point(88, 191);
		button_21.Name = "button60";
		button_21.Size = new Size(59, 23);
		button_21.TabIndex = 25;
		button_21.Text = "Rec";
		button_21.UseVisualStyleBackColor = false;
		button_22.BackColor = Color.FromArgb(255, 128, 128);
		button_22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_22.Location = new Point(239, 138);
		button_22.Name = "button58";
		button_22.Size = new Size(59, 23);
		button_22.TabIndex = 25;
		button_22.Text = "Rec";
		button_22.UseVisualStyleBackColor = false;
		button_23.BackColor = Color.FromArgb(255, 128, 128);
		button_23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_23.Location = new Point(163, 243);
		button_23.Name = "button65";
		button_23.Size = new Size(59, 23);
		button_23.TabIndex = 25;
		button_23.Text = "Rec";
		button_23.UseVisualStyleBackColor = false;
		button_24.BackColor = Color.FromArgb(255, 128, 128);
		button_24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_24.Location = new Point(88, 138);
		button_24.Name = "button56";
		button_24.Size = new Size(59, 23);
		button_24.TabIndex = 25;
		button_24.Text = "Rec";
		button_24.UseVisualStyleBackColor = false;
		button_25.BackColor = Color.FromArgb(255, 128, 128);
		button_25.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_25.Location = new Point(164, 191);
		button_25.Name = "button61";
		button_25.Size = new Size(59, 23);
		button_25.TabIndex = 25;
		button_25.Text = "Rec";
		button_25.UseVisualStyleBackColor = false;
		button_26.BackColor = Color.FromArgb(255, 128, 128);
		button_26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_26.Location = new Point(240, 85);
		button_26.Name = "button54";
		button_26.Size = new Size(59, 23);
		button_26.TabIndex = 25;
		button_26.Text = "Rec";
		button_26.UseVisualStyleBackColor = false;
		button_27.BackColor = Color.FromArgb(255, 128, 128);
		button_27.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_27.Location = new Point(13, 243);
		button_27.Name = "button63";
		button_27.Size = new Size(59, 23);
		button_27.TabIndex = 25;
		button_27.Text = "Rec";
		button_27.UseVisualStyleBackColor = false;
		button_28.BackColor = Color.FromArgb(255, 128, 128);
		button_28.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_28.Location = new Point(164, 138);
		button_28.Name = "button57";
		button_28.Size = new Size(59, 23);
		button_28.TabIndex = 25;
		button_28.Text = "Rec";
		button_28.UseVisualStyleBackColor = false;
		button_29.BackColor = Color.FromArgb(255, 128, 128);
		button_29.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_29.Location = new Point(14, 191);
		button_29.Name = "button59";
		button_29.Size = new Size(59, 23);
		button_29.TabIndex = 25;
		button_29.Text = "Rec";
		button_29.UseVisualStyleBackColor = false;
		button_30.BackColor = Color.FromArgb(255, 128, 128);
		button_30.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_30.Location = new Point(89, 85);
		button_30.Name = "button52";
		button_30.Size = new Size(59, 23);
		button_30.TabIndex = 25;
		button_30.Text = "Rec";
		button_30.UseVisualStyleBackColor = false;
		button_31.BackColor = Color.FromArgb(255, 128, 128);
		button_31.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_31.Location = new Point(14, 138);
		button_31.Name = "button55";
		button_31.Size = new Size(59, 23);
		button_31.TabIndex = 25;
		button_31.Text = "Rec";
		button_31.UseVisualStyleBackColor = false;
		button_32.BackColor = Color.FromArgb(255, 128, 128);
		button_32.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_32.Location = new Point(165, 85);
		button_32.Name = "button53";
		button_32.Size = new Size(59, 23);
		button_32.TabIndex = 25;
		button_32.Text = "Rec";
		button_32.UseVisualStyleBackColor = false;
		button_17.BackColor = Color.FromArgb(255, 128, 128);
		button_17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		button_17.Location = new Point(15, 85);
		button_17.Name = "button51";
		button_17.Size = new Size(59, 23);
		button_17.TabIndex = 25;
		button_17.Text = "Rec";
		button_17.UseVisualStyleBackColor = false;
		dataGridView_15.AllowUserToAddRows = false;
		dataGridView_15.AllowUserToResizeColumns = false;
		dataGridView_15.AllowUserToResizeRows = false;
		dataGridView_15.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_15.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_15.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_15.ColumnHeadersVisible = false;
		dataGridView_15.Columns.AddRange(dataGridViewTextBoxColumn_38, dataGridViewTextBoxColumn_39, dataGridViewTextBoxColumn_40);
		dataGridView_15.ImeMode = ImeMode.NoControl;
		dataGridView_15.Location = new Point(240, 110);
		dataGridView_15.Name = "dataGridView54";
		dataGridView_15.RowHeadersVisible = false;
		dataGridView_15.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_15.ScrollBars = ScrollBars.None;
		dataGridView_15.Size = new Size(59, 26);
		dataGridView_15.TabIndex = 24;
		dataGridViewTextBoxColumn_38.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_38.HeaderText = "X";
		dataGridViewTextBoxColumn_38.Name = "dataGridViewTextBoxColumn46";
		dataGridViewTextBoxColumn_39.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_39.HeaderText = "Y";
		dataGridViewTextBoxColumn_39.Name = "dataGridViewTextBoxColumn47";
		dataGridViewTextBoxColumn_40.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_40.HeaderText = "Delay";
		dataGridViewTextBoxColumn_40.Name = "dataGridViewTextBoxColumn48";
		dataGridView_16.AllowUserToAddRows = false;
		dataGridView_16.AllowUserToResizeColumns = false;
		dataGridView_16.AllowUserToResizeRows = false;
		dataGridView_16.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_16.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_16.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_16.ColumnHeadersVisible = false;
		dataGridView_16.Columns.AddRange(dataGridViewTextBoxColumn_41, dataGridViewTextBoxColumn_42, dataGridViewTextBoxColumn_43);
		dataGridView_16.ImeMode = ImeMode.NoControl;
		dataGridView_16.Location = new Point(164, 110);
		dataGridView_16.Name = "dataGridView53";
		dataGridView_16.RowHeadersVisible = false;
		dataGridView_16.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_16.ScrollBars = ScrollBars.None;
		dataGridView_16.Size = new Size(59, 26);
		dataGridView_16.TabIndex = 24;
		dataGridViewTextBoxColumn_41.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_41.HeaderText = "X";
		dataGridViewTextBoxColumn_41.Name = "dataGridViewTextBoxColumn43";
		dataGridViewTextBoxColumn_42.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_42.HeaderText = "Y";
		dataGridViewTextBoxColumn_42.Name = "dataGridViewTextBoxColumn44";
		dataGridViewTextBoxColumn_43.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_43.HeaderText = "Delay";
		dataGridViewTextBoxColumn_43.Name = "dataGridViewTextBoxColumn45";
		dataGridView_3.AllowUserToAddRows = false;
		dataGridView_3.AllowUserToResizeColumns = false;
		dataGridView_3.AllowUserToResizeRows = false;
		dataGridView_3.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_3.ColumnHeadersVisible = false;
		dataGridView_3.Columns.AddRange(dataGridViewTextBoxColumn_2, dataGridViewTextBoxColumn_3, dataGridViewTextBoxColumn_4);
		dataGridView_3.ImeMode = ImeMode.NoControl;
		dataGridView_3.Location = new Point(240, 164);
		dataGridView_3.Name = "dataGridView58";
		dataGridView_3.RowHeadersVisible = false;
		dataGridView_3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_3.ScrollBars = ScrollBars.None;
		dataGridView_3.Size = new Size(59, 26);
		dataGridView_3.TabIndex = 24;
		dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_2.HeaderText = "X";
		dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn34";
		dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_3.HeaderText = "Y";
		dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn35";
		dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_4.HeaderText = "Delay";
		dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn36";
		dataGridView_4.AllowUserToAddRows = false;
		dataGridView_4.AllowUserToResizeColumns = false;
		dataGridView_4.AllowUserToResizeRows = false;
		dataGridView_4.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_4.ColumnHeadersVisible = false;
		dataGridView_4.Columns.AddRange(dataGridViewTextBoxColumn_5, dataGridViewTextBoxColumn_6, dataGridViewTextBoxColumn_7);
		dataGridView_4.ImeMode = ImeMode.NoControl;
		dataGridView_4.Location = new Point(164, 164);
		dataGridView_4.Name = "dataGridView57";
		dataGridView_4.RowHeadersVisible = false;
		dataGridView_4.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_4.ScrollBars = ScrollBars.None;
		dataGridView_4.Size = new Size(59, 26);
		dataGridView_4.TabIndex = 24;
		dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_5.HeaderText = "X";
		dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn31";
		dataGridViewTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_6.HeaderText = "Y";
		dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn32";
		dataGridViewTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_7.HeaderText = "Delay";
		dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn33";
		dataGridView_5.AllowUserToAddRows = false;
		dataGridView_5.AllowUserToResizeColumns = false;
		dataGridView_5.AllowUserToResizeRows = false;
		dataGridView_5.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_5.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_5.ColumnHeadersVisible = false;
		dataGridView_5.Columns.AddRange(dataGridViewTextBoxColumn_8, dataGridViewTextBoxColumn_9, dataGridViewTextBoxColumn_10);
		dataGridView_5.ImeMode = ImeMode.NoControl;
		dataGridView_5.Location = new Point(240, 215);
		dataGridView_5.Name = "dataGridView62";
		dataGridView_5.RowHeadersVisible = false;
		dataGridView_5.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_5.ScrollBars = ScrollBars.None;
		dataGridView_5.Size = new Size(59, 26);
		dataGridView_5.TabIndex = 24;
		dataGridViewTextBoxColumn_8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_8.HeaderText = "X";
		dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn22";
		dataGridViewTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_9.HeaderText = "Y";
		dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn23";
		dataGridViewTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_10.HeaderText = "Delay";
		dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn24";
		dataGridView_17.AllowUserToAddRows = false;
		dataGridView_17.AllowUserToResizeColumns = false;
		dataGridView_17.AllowUserToResizeRows = false;
		dataGridView_17.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_17.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_17.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_17.ColumnHeadersVisible = false;
		dataGridView_17.Columns.AddRange(dataGridViewTextBoxColumn_44, dataGridViewTextBoxColumn_45, dataGridViewTextBoxColumn_46);
		dataGridView_17.ImeMode = ImeMode.NoControl;
		dataGridView_17.Location = new Point(88, 110);
		dataGridView_17.Name = "dataGridView52";
		dataGridView_17.RowHeadersVisible = false;
		dataGridView_17.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_17.ScrollBars = ScrollBars.None;
		dataGridView_17.Size = new Size(59, 26);
		dataGridView_17.TabIndex = 24;
		dataGridViewTextBoxColumn_44.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_44.HeaderText = "X";
		dataGridViewTextBoxColumn_44.Name = "dataGridViewTextBoxColumn40";
		dataGridViewTextBoxColumn_45.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_45.HeaderText = "Y";
		dataGridViewTextBoxColumn_45.Name = "dataGridViewTextBoxColumn41";
		dataGridViewTextBoxColumn_46.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_46.HeaderText = "Delay";
		dataGridViewTextBoxColumn_46.Name = "dataGridViewTextBoxColumn42";
		dataGridView_6.AllowUserToAddRows = false;
		dataGridView_6.AllowUserToResizeColumns = false;
		dataGridView_6.AllowUserToResizeRows = false;
		dataGridView_6.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_6.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_6.ColumnHeadersVisible = false;
		dataGridView_6.Columns.AddRange(dataGridViewTextBoxColumn_11, dataGridViewTextBoxColumn_12, dataGridViewTextBoxColumn_13);
		dataGridView_6.ImeMode = ImeMode.NoControl;
		dataGridView_6.Location = new Point(164, 215);
		dataGridView_6.Name = "dataGridView61";
		dataGridView_6.RowHeadersVisible = false;
		dataGridView_6.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_6.ScrollBars = ScrollBars.None;
		dataGridView_6.Size = new Size(59, 26);
		dataGridView_6.TabIndex = 24;
		dataGridViewTextBoxColumn_11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_11.HeaderText = "X";
		dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn19";
		dataGridViewTextBoxColumn_12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_12.HeaderText = "Y";
		dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn20";
		dataGridViewTextBoxColumn_13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_13.HeaderText = "Delay";
		dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn21";
		dataGridView_7.AllowUserToAddRows = false;
		dataGridView_7.AllowUserToResizeColumns = false;
		dataGridView_7.AllowUserToResizeRows = false;
		dataGridView_7.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_7.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_7.ColumnHeadersVisible = false;
		dataGridView_7.Columns.AddRange(dataGridViewTextBoxColumn_14, dataGridViewTextBoxColumn_15, dataGridViewTextBoxColumn_16);
		dataGridView_7.ImeMode = ImeMode.NoControl;
		dataGridView_7.Location = new Point(88, 164);
		dataGridView_7.Name = "dataGridView56";
		dataGridView_7.RowHeadersVisible = false;
		dataGridView_7.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_7.ScrollBars = ScrollBars.None;
		dataGridView_7.Size = new Size(59, 26);
		dataGridView_7.TabIndex = 24;
		dataGridViewTextBoxColumn_14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_14.HeaderText = "X";
		dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn28";
		dataGridViewTextBoxColumn_15.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_15.HeaderText = "Y";
		dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn29";
		dataGridViewTextBoxColumn_16.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_16.HeaderText = "Delay";
		dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn30";
		dataGridView_8.AllowUserToAddRows = false;
		dataGridView_8.AllowUserToResizeColumns = false;
		dataGridView_8.AllowUserToResizeRows = false;
		dataGridView_8.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_8.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_8.ColumnHeadersVisible = false;
		dataGridView_8.Columns.AddRange(dataGridViewTextBoxColumn_17, dataGridViewTextBoxColumn_18, dataGridViewTextBoxColumn_19);
		dataGridView_8.ImeMode = ImeMode.NoControl;
		dataGridView_8.Location = new Point(239, 266);
		dataGridView_8.Name = "dataGridView66";
		dataGridView_8.RowHeadersVisible = false;
		dataGridView_8.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_8.ScrollBars = ScrollBars.None;
		dataGridView_8.Size = new Size(59, 26);
		dataGridView_8.TabIndex = 24;
		dataGridViewTextBoxColumn_17.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_17.HeaderText = "X";
		dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn10";
		dataGridViewTextBoxColumn_18.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_18.HeaderText = "Y";
		dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn11";
		dataGridViewTextBoxColumn_19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_19.HeaderText = "Delay";
		dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn12";
		dataGridView_18.AllowUserToAddRows = false;
		dataGridView_18.AllowUserToResizeColumns = false;
		dataGridView_18.AllowUserToResizeRows = false;
		dataGridView_18.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_18.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_18.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_18.ColumnHeadersVisible = false;
		dataGridView_18.Columns.AddRange(dataGridViewTextBoxColumn_47, dataGridViewTextBoxColumn_48, dataGridViewTextBoxColumn_49);
		dataGridView_18.ImeMode = ImeMode.NoControl;
		dataGridView_18.Location = new Point(14, 110);
		dataGridView_18.Name = "dataGridView51";
		dataGridView_18.RowHeadersVisible = false;
		dataGridView_18.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_18.ScrollBars = ScrollBars.None;
		dataGridView_18.Size = new Size(59, 26);
		dataGridView_18.TabIndex = 24;
		dataGridViewTextBoxColumn_47.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_47.HeaderText = "X";
		dataGridViewTextBoxColumn_47.Name = "dataGridViewTextBoxColumn37";
		dataGridViewTextBoxColumn_48.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_48.HeaderText = "Z";
		dataGridViewTextBoxColumn_48.Name = "dataGridViewTextBoxColumn39";
		dataGridViewTextBoxColumn_49.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_49.HeaderText = "Y";
		dataGridViewTextBoxColumn_49.Name = "dataGridViewTextBoxColumn38";
		dataGridView_9.AllowUserToAddRows = false;
		dataGridView_9.AllowUserToResizeColumns = false;
		dataGridView_9.AllowUserToResizeRows = false;
		dataGridView_9.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_9.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_9.ColumnHeadersVisible = false;
		dataGridView_9.Columns.AddRange(dataGridViewTextBoxColumn_20, dataGridViewTextBoxColumn_21, dataGridViewTextBoxColumn_22);
		dataGridView_9.ImeMode = ImeMode.NoControl;
		dataGridView_9.Location = new Point(88, 215);
		dataGridView_9.Name = "dataGridView60";
		dataGridView_9.RowHeadersVisible = false;
		dataGridView_9.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_9.ScrollBars = ScrollBars.None;
		dataGridView_9.Size = new Size(59, 26);
		dataGridView_9.TabIndex = 24;
		dataGridViewTextBoxColumn_20.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_20.HeaderText = "X";
		dataGridViewTextBoxColumn_20.Name = "dataGridViewTextBoxColumn16";
		dataGridViewTextBoxColumn_21.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_21.HeaderText = "Y";
		dataGridViewTextBoxColumn_21.Name = "dataGridViewTextBoxColumn17";
		dataGridViewTextBoxColumn_22.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_22.HeaderText = "Delay";
		dataGridViewTextBoxColumn_22.Name = "dataGridViewTextBoxColumn18";
		dataGridView_10.AllowUserToAddRows = false;
		dataGridView_10.AllowUserToResizeColumns = false;
		dataGridView_10.AllowUserToResizeRows = false;
		dataGridView_10.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_10.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_10.ColumnHeadersVisible = false;
		dataGridView_10.Columns.AddRange(dataGridViewTextBoxColumn_23, dataGridViewTextBoxColumn_24, dataGridViewTextBoxColumn_25);
		dataGridView_10.ImeMode = ImeMode.NoControl;
		dataGridView_10.Location = new Point(14, 164);
		dataGridView_10.Name = "dataGridView55";
		dataGridView_10.RowHeadersVisible = false;
		dataGridView_10.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_10.ScrollBars = ScrollBars.None;
		dataGridView_10.Size = new Size(59, 26);
		dataGridView_10.TabIndex = 24;
		dataGridViewTextBoxColumn_23.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_23.HeaderText = "X";
		dataGridViewTextBoxColumn_23.Name = "dataGridViewTextBoxColumn25";
		dataGridViewTextBoxColumn_24.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_24.HeaderText = "Y";
		dataGridViewTextBoxColumn_24.Name = "dataGridViewTextBoxColumn26";
		dataGridViewTextBoxColumn_25.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_25.HeaderText = "Delay";
		dataGridViewTextBoxColumn_25.Name = "dataGridViewTextBoxColumn27";
		dataGridView_11.AllowUserToAddRows = false;
		dataGridView_11.AllowUserToResizeColumns = false;
		dataGridView_11.AllowUserToResizeRows = false;
		dataGridView_11.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_11.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_11.ColumnHeadersVisible = false;
		dataGridView_11.Columns.AddRange(dataGridViewTextBoxColumn_26, dataGridViewTextBoxColumn_27, dataGridViewTextBoxColumn_28);
		dataGridView_11.ImeMode = ImeMode.NoControl;
		dataGridView_11.Location = new Point(163, 266);
		dataGridView_11.Name = "dataGridView65";
		dataGridView_11.RowHeadersVisible = false;
		dataGridView_11.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_11.ScrollBars = ScrollBars.None;
		dataGridView_11.Size = new Size(59, 26);
		dataGridView_11.TabIndex = 24;
		dataGridViewTextBoxColumn_26.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_26.HeaderText = "X";
		dataGridViewTextBoxColumn_26.Name = "dataGridViewTextBoxColumn7";
		dataGridViewTextBoxColumn_27.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_27.HeaderText = "Y";
		dataGridViewTextBoxColumn_27.Name = "dataGridViewTextBoxColumn8";
		dataGridViewTextBoxColumn_28.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_28.HeaderText = "Delay";
		dataGridViewTextBoxColumn_28.Name = "dataGridViewTextBoxColumn9";
		dataGridView_12.AllowUserToAddRows = false;
		dataGridView_12.AllowUserToResizeColumns = false;
		dataGridView_12.AllowUserToResizeRows = false;
		dataGridView_12.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_12.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_12.ColumnHeadersVisible = false;
		dataGridView_12.Columns.AddRange(dataGridViewTextBoxColumn_29, dataGridViewTextBoxColumn_30, dataGridViewTextBoxColumn_31);
		dataGridView_12.ImeMode = ImeMode.NoControl;
		dataGridView_12.Location = new Point(14, 215);
		dataGridView_12.Name = "dataGridView59";
		dataGridView_12.RowHeadersVisible = false;
		dataGridView_12.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_12.ScrollBars = ScrollBars.None;
		dataGridView_12.Size = new Size(59, 26);
		dataGridView_12.TabIndex = 24;
		dataGridViewTextBoxColumn_29.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_29.HeaderText = "X";
		dataGridViewTextBoxColumn_29.Name = "dataGridViewTextBoxColumn13";
		dataGridViewTextBoxColumn_30.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_30.HeaderText = "Y";
		dataGridViewTextBoxColumn_30.Name = "dataGridViewTextBoxColumn14";
		dataGridViewTextBoxColumn_31.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_31.HeaderText = "Delay";
		dataGridViewTextBoxColumn_31.Name = "dataGridViewTextBoxColumn15";
		dataGridView_13.AllowUserToAddRows = false;
		dataGridView_13.AllowUserToResizeColumns = false;
		dataGridView_13.AllowUserToResizeRows = false;
		dataGridView_13.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_13.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_13.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_13.ColumnHeadersVisible = false;
		dataGridView_13.Columns.AddRange(dataGridViewTextBoxColumn_32, dataGridViewTextBoxColumn_33, dataGridViewTextBoxColumn_34);
		dataGridView_13.ImeMode = ImeMode.NoControl;
		dataGridView_13.Location = new Point(87, 266);
		dataGridView_13.Name = "dataGridView64";
		dataGridView_13.RowHeadersVisible = false;
		dataGridView_13.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_13.ScrollBars = ScrollBars.None;
		dataGridView_13.Size = new Size(59, 26);
		dataGridView_13.TabIndex = 24;
		dataGridViewTextBoxColumn_32.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_32.HeaderText = "X";
		dataGridViewTextBoxColumn_32.Name = "dataGridViewTextBoxColumn4";
		dataGridViewTextBoxColumn_33.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_33.HeaderText = "Y";
		dataGridViewTextBoxColumn_33.Name = "dataGridViewTextBoxColumn5";
		dataGridViewTextBoxColumn_34.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_34.HeaderText = "Delay";
		dataGridViewTextBoxColumn_34.Name = "dataGridViewTextBoxColumn6";
		dataGridView_14.AllowUserToAddRows = false;
		dataGridView_14.AllowUserToResizeColumns = false;
		dataGridView_14.AllowUserToResizeRows = false;
		dataGridView_14.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridView_14.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_14.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_14.ColumnHeadersVisible = false;
		dataGridView_14.Columns.AddRange(dataGridViewTextBoxColumn_35, dataGridViewTextBoxColumn_36, dataGridViewTextBoxColumn_37);
		dataGridView_14.ImeMode = ImeMode.NoControl;
		dataGridView_14.Location = new Point(13, 266);
		dataGridView_14.Name = "dataGridView63";
		dataGridView_14.RowHeadersVisible = false;
		dataGridView_14.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridView_14.ScrollBars = ScrollBars.None;
		dataGridView_14.Size = new Size(59, 26);
		dataGridView_14.TabIndex = 24;
		dataGridViewTextBoxColumn_35.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_35.HeaderText = "X";
		dataGridViewTextBoxColumn_35.Name = "dataGridViewTextBoxColumn1";
		dataGridViewTextBoxColumn_36.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_36.HeaderText = "Y";
		dataGridViewTextBoxColumn_36.Name = "dataGridViewTextBoxColumn2";
		dataGridViewTextBoxColumn_37.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_37.HeaderText = "Delay";
		dataGridViewTextBoxColumn_37.Name = "dataGridViewTextBoxColumn3";
		tabPage_4.BorderStyle = BorderStyle.FixedSingle;
		tabPage_4.Controls.Add(button_63);
		tabPage_4.Controls.Add(button_10);
		tabPage_4.Controls.Add(label_19);
		tabPage_4.Controls.Add(button_9);
		tabPage_4.Controls.Add(button_8);
		tabPage_4.Controls.Add(comboBox_1);
		tabPage_4.Controls.Add(button_5);
		tabPage_4.Controls.Add(textBox_5);
		tabPage_4.Controls.Add(button_6);
		tabPage_4.Controls.Add(button_7);
		tabPage_4.Controls.Add(dataGridView_1);
		tabPage_4.Controls.Add(dataGridView_2);
		tabPage_4.Location = new Point(4, 49);
		tabPage_4.Name = "tabPage6";
		tabPage_4.Size = new Size(638, 370);
		tabPage_4.TabIndex = 6;
		tabPage_4.Text = "Filter List";
		tabPage_4.UseVisualStyleBackColor = true;
		button_63.Location = new Point(235, 32);
		button_63.Name = "button47";
		button_63.Size = new Size(64, 23);
		button_63.TabIndex = 24;
		button_63.Text = "โหลด";
		button_63.UseVisualStyleBackColor = true;
		button_63.Click += button_63_Click;
		button_10.Location = new Point(142, 198);
		button_10.Name = "button15";
		button_10.Size = new Size(25, 23);
		button_10.TabIndex = 23;
		button_10.Text = "Del";
		button_10.UseVisualStyleBackColor = true;
		button_10.Click += button_10_Click;
		label_19.BackColor = Color.FromArgb(255, 255, 192);
		label_19.Location = new Point(127, 6);
		label_19.Name = "label21";
		label_19.Size = new Size(42, 23);
		label_19.TabIndex = 22;
		label_19.Text = "Result";
		label_19.TextAlign = ContentAlignment.MiddleCenter;
		button_9.Location = new Point(175, 7);
		button_9.Name = "button13";
		button_9.Size = new Size(59, 23);
		button_9.TabIndex = 21;
		button_9.Text = "ถ\u0e31ดไป";
		button_9.UseVisualStyleBackColor = true;
		button_9.Click += button_9_Click;
		button_8.Location = new Point(13, 31);
		button_8.Name = "button14";
		button_8.Size = new Size(98, 23);
		button_8.TabIndex = 20;
		button_8.Text = "โหลดท\u0e31\u0e49งหมด";
		button_8.UseVisualStyleBackColor = true;
		button_8.Click += button_8_Click;
		comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_1.FormattingEnabled = true;
		comboBox_1.Items.AddRange(new object[1] { "all_items_used" });
		comboBox_1.Location = new Point(118, 33);
		comboBox_1.Name = "comboBox2";
		comboBox_1.Size = new Size(109, 21);
		comboBox_1.TabIndex = 19;
		button_5.Location = new Point(240, 8);
		button_5.Name = "button12";
		button_5.Size = new Size(59, 23);
		button_5.TabIndex = 18;
		button_5.Text = "เพ\u0e34\u0e48ม";
		button_5.UseVisualStyleBackColor = true;
		button_5.Click += button_5_Click;
		textBox_5.Location = new Point(17, 7);
		textBox_5.Name = "textBox2";
		textBox_5.Size = new Size(105, 20);
		textBox_5.TabIndex = 17;
		textBox_5.TextChanged += textBox_5_TextChanged;
		button_6.Location = new Point(142, 139);
		button_6.Name = "button11";
		button_6.Size = new Size(25, 23);
		button_6.TabIndex = 15;
		button_6.Text = "<";
		button_6.UseVisualStyleBackColor = true;
		button_6.Click += button_6_Click;
		button_7.Location = new Point(142, 110);
		button_7.Name = "button6";
		button_7.Size = new Size(25, 23);
		button_7.TabIndex = 16;
		button_7.Text = ">";
		button_7.UseVisualStyleBackColor = true;
		button_7.Click += button_7_Click;
		dataGridView_1.AllowUserToResizeColumns = false;
		dataGridView_1.AllowUserToResizeRows = false;
		dataGridView_1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = Color.White;
		dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
		dataGridView_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
		dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_1.Columns.AddRange(dataGridViewTextBoxColumn_1);
		dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle5.BackColor = Color.White;
		dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
		dataGridView_1.DefaultCellStyle = dataGridViewCellStyle5;
		dataGridView_1.Location = new Point(170, 59);
		dataGridView_1.Name = "dataGridView3";
		dataGridView_1.ReadOnly = true;
		dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle6.BackColor = Color.White;
		dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
		dataGridView_1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
		dataGridView_1.RowHeadersVisible = false;
		dataGridView_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_1.Size = new Size(129, 275);
		dataGridView_1.StandardTab = true;
		dataGridView_1.TabIndex = 14;
		dataGridViewTextBoxColumn_1.HeaderText = "ไอเท\u0e47มท\u0e35\u0e48เล\u0e34อก";
		dataGridViewTextBoxColumn_1.Name = "Column5";
		dataGridViewTextBoxColumn_1.ReadOnly = true;
		dataGridView_2.AllowUserToResizeColumns = false;
		dataGridView_2.AllowUserToResizeRows = false;
		dataGridViewCellStyle7.BackColor = Color.White;
		dataGridView_2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
		dataGridView_2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle8.BackColor = Color.Gray;
		dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle8.SelectionBackColor = Color.Gray;
		dataGridViewCellStyle8.SelectionForeColor = Color.Gray;
		dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
		dataGridView_2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
		dataGridView_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_2.Columns.AddRange(dataGridViewTextBoxColumn_0);
		dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle9.BackColor = Color.White;
		dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
		dataGridView_2.DefaultCellStyle = dataGridViewCellStyle9;
		dataGridView_2.Location = new Point(11, 59);
		dataGridView_2.Name = "dataGridView2";
		dataGridView_2.ReadOnly = true;
		dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle10.BackColor = Color.White;
		dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
		dataGridView_2.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
		dataGridView_2.RowHeadersVisible = false;
		dataGridViewCellStyle11.BackColor = Color.White;
		dataGridView_2.RowsDefaultCellStyle = dataGridViewCellStyle11;
		dataGridView_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_2.Size = new Size(129, 275);
		dataGridView_2.StandardTab = true;
		dataGridView_2.TabIndex = 13;
		dataGridViewTextBoxColumn_0.HeaderText = "รายการไอเท\u0e47ม";
		dataGridViewTextBoxColumn_0.Name = "Column4";
		dataGridViewTextBoxColumn_0.ReadOnly = true;
		tabPage_6.BorderStyle = BorderStyle.FixedSingle;
		tabPage_6.Controls.Add(checkBox_84);
		tabPage_6.Controls.Add(label_71);
		tabPage_6.Controls.Add(label_40);
		tabPage_6.Controls.Add(dateTimePicker_6);
		tabPage_6.Controls.Add(label_39);
		tabPage_6.Controls.Add(checkBox_50);
		tabPage_6.Controls.Add(checkBox_49);
		tabPage_6.Controls.Add(dateTimePicker_2);
		tabPage_6.Controls.Add(dateTimePicker_1);
		tabPage_6.Controls.Add(dateTimePicker_3);
		tabPage_6.Controls.Add(dateTimePicker_0);
		tabPage_6.Controls.Add(checkBox_41);
		tabPage_6.Controls.Add(textBox_11);
		tabPage_6.Controls.Add(label_34);
		tabPage_6.Controls.Add(label_35);
		tabPage_6.Controls.Add(comboBox_3);
		tabPage_6.Controls.Add(label_104);
		tabPage_6.Controls.Add(label_36);
		tabPage_6.Controls.Add(button_37);
		tabPage_6.Controls.Add(button_38);
		tabPage_6.Controls.Add(label_37);
		tabPage_6.Controls.Add(button_39);
		tabPage_6.Controls.Add(button_40);
		tabPage_6.Controls.Add(comboBox_4);
		tabPage_6.Controls.Add(button_41);
		tabPage_6.Controls.Add(textBox_12);
		tabPage_6.Controls.Add(button_42);
		tabPage_6.Controls.Add(button_43);
		tabPage_6.Controls.Add(dataGridView_19);
		tabPage_6.Controls.Add(dataGridView_20);
		tabPage_6.Controls.Add(radioButton_14);
		tabPage_6.Controls.Add(radioButton_15);
		tabPage_6.Controls.Add(radioButton_16);
		tabPage_6.Controls.Add(groupBox_0);
		tabPage_6.Controls.Add(checkBox_42);
		tabPage_6.Controls.Add(groupBox_1);
		tabPage_6.Location = new Point(4, 49);
		tabPage_6.Name = "tabPage7";
		tabPage_6.Padding = new Padding(10, 0, 0, 0);
		tabPage_6.Size = new Size(638, 370);
		tabPage_6.TabIndex = 8;
		tabPage_6.Text = "  Alert";
		tabPage_6.UseVisualStyleBackColor = true;
		tabPage_6.Click += tabPage_6_Click;
		checkBox_84.AutoSize = true;
		checkBox_84.Location = new Point(3, 325);
		checkBox_84.Name = "checkBox84";
		checkBox_84.Size = new Size(113, 17);
		checkBox_84.TabIndex = 47;
		checkBox_84.Text = "ป\u0e34ดใช\u0e49งานส\u0e31ตว\u0e4cเล\u0e35\u0e49ยง";
		checkBox_84.UseVisualStyleBackColor = true;
		label_71.BackColor = Color.FromArgb(255, 255, 128);
		label_71.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_71.Location = new Point(382, 294);
		label_71.Name = "label64";
		label_71.Size = new Size(195, 24);
		label_71.TabIndex = 46;
		label_71.Text = "อ\u0e35ก ..... ว\u0e34นาท\u0e35 กล\u0e31บมาทำงาน";
		label_71.TextAlign = ContentAlignment.MiddleCenter;
		label_40.AutoSize = true;
		label_40.Location = new Point(519, 147);
		label_40.Name = "label52";
		label_40.Size = new Size(16, 13);
		label_40.TabIndex = 44;
		label_40.Text = "---";
		label_40.TextAlign = ContentAlignment.MiddleCenter;
		dateTimePicker_6.Format = DateTimePickerFormat.Time;
		dateTimePicker_6.Location = new Point(229, 323);
		dateTimePicker_6.Name = "dateTimePicker11";
		dateTimePicker_6.ShowUpDown = true;
		dateTimePicker_6.Size = new Size(74, 20);
		dateTimePicker_6.TabIndex = 42;
		label_39.AutoSize = true;
		label_39.Location = new Point(519, 9);
		label_39.Name = "label47";
		label_39.Size = new Size(16, 13);
		label_39.TabIndex = 44;
		label_39.Text = "---";
		label_39.TextAlign = ContentAlignment.MiddleCenter;
		checkBox_50.AutoSize = true;
		checkBox_50.Location = new Point(319, 145);
		checkBox_50.Name = "checkBox61";
		checkBox_50.Size = new Size(115, 17);
		checkBox_50.TabIndex = 43;
		checkBox_50.Text = "ใช\u0e49 ต\u0e31\u0e49งค\u0e48า Alert เวลา";
		checkBox_50.UseVisualStyleBackColor = true;
		checkBox_50.CheckedChanged += checkBox_50_CheckedChanged;
		checkBox_49.AutoSize = true;
		checkBox_49.Location = new Point(319, 7);
		checkBox_49.Name = "checkBox60";
		checkBox_49.Size = new Size(115, 17);
		checkBox_49.TabIndex = 43;
		checkBox_49.Text = "ใช\u0e49 ต\u0e31\u0e49งค\u0e48า Alert เวลา";
		checkBox_49.UseVisualStyleBackColor = true;
		checkBox_49.CheckedChanged += checkBox_49_CheckedChanged;
		dateTimePicker_2.Format = DateTimePickerFormat.Time;
		dateTimePicker_2.Location = new Point(538, 144);
		dateTimePicker_2.Name = "dateTimePicker4";
		dateTimePicker_2.ShowUpDown = true;
		dateTimePicker_2.Size = new Size(74, 20);
		dateTimePicker_2.TabIndex = 42;
		dateTimePicker_1.Format = DateTimePickerFormat.Time;
		dateTimePicker_1.Location = new Point(538, 6);
		dateTimePicker_1.Name = "dateTimePicker2";
		dateTimePicker_1.ShowUpDown = true;
		dateTimePicker_1.Size = new Size(74, 20);
		dateTimePicker_1.TabIndex = 42;
		dateTimePicker_3.Format = DateTimePickerFormat.Time;
		dateTimePicker_3.Location = new Point(441, 144);
		dateTimePicker_3.Name = "dateTimePicker3";
		dateTimePicker_3.ShowUpDown = true;
		dateTimePicker_3.Size = new Size(74, 20);
		dateTimePicker_3.TabIndex = 42;
		dateTimePicker_0.Format = DateTimePickerFormat.Time;
		dateTimePicker_0.Location = new Point(441, 6);
		dateTimePicker_0.Name = "dateTimePicker1";
		dateTimePicker_0.ShowUpDown = true;
		dateTimePicker_0.Size = new Size(74, 20);
		dateTimePicker_0.TabIndex = 42;
		checkBox_41.AutoSize = true;
		checkBox_41.Location = new Point(14, 4);
		checkBox_41.Name = "checkBox44";
		checkBox_41.Size = new Size(116, 17);
		checkBox_41.TabIndex = 40;
		checkBox_41.Text = "ใช\u0e49งานฟ\u0e31งก\u0e4cช\u0e31น Alert";
		checkBox_41.UseVisualStyleBackColor = true;
		textBox_11.Location = new Point(216, 298);
		textBox_11.Name = "textBox25";
		textBox_11.Size = new Size(48, 20);
		textBox_11.TabIndex = 39;
		textBox_11.Text = "5";
		textBox_11.TextAlign = HorizontalAlignment.Center;
		label_34.AutoSize = true;
		label_34.BackColor = Color.FromArgb(128, 255, 255);
		label_34.Location = new Point(273, 301);
		label_34.Name = "label43";
		label_34.Size = new Size(33, 13);
		label_34.TabIndex = 37;
		label_34.Text = "ว\u0e34นาท\u0e35";
		label_35.AutoSize = true;
		label_35.BackColor = Color.FromArgb(128, 255, 255);
		label_35.Location = new Point(171, 302);
		label_35.Name = "label44";
		label_35.Size = new Size(37, 13);
		label_35.TabIndex = 38;
		label_35.Text = "Delay ";
		comboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_3.DropDownWidth = 200;
		comboBox_3.FormattingEnabled = true;
		comboBox_3.Items.AddRange(new object[7] { "เด\u0e49งส\u0e49มและหย\u0e38ดการทำงาน", "เด\u0e49งส\u0e49ม ด\u0e35เลย\u0e4cตามเวลา และเด\u0e49งฟ\u0e49า ทำงานต\u0e48อ", "เปล\u0e35\u0e48ยน Loop ทำงาน", "หย\u0e38ดการทำงานท\u0e31นท\u0e35", "หย\u0e38ดและกล\u0e31บมาทำงานท\u0e31นท\u0e35", "หย\u0e38ดทำงานและกล\u0e31บมาทำงาน ตาม Delay", "หย\u0e38ดทำงานและกล\u0e31บมาทำงานตามเวลาท\u0e35\u0e48ต\u0e31\u0e49งไว\u0e49" });
		comboBox_3.Location = new Point(3, 300);
		comboBox_3.Name = "comboBox6";
		comboBox_3.Size = new Size(159, 21);
		comboBox_3.TabIndex = 36;
		label_104.AutoSize = true;
		label_104.BackColor = Color.FromArgb(255, 192, 192);
		label_104.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_104.Location = new Point(123, 325);
		label_104.Name = "label53";
		label_104.Size = new Size(99, 16);
		label_104.TabIndex = 35;
		label_104.Text = "จะทำงานต\u0e48อเม\u0e37\u0e48อเวลา";
		label_36.AutoSize = true;
		label_36.BackColor = Color.FromArgb(128, 255, 128);
		label_36.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_36.Location = new Point(5, 278);
		label_36.Name = "label39";
		label_36.Size = new Size(185, 16);
		label_36.TabIndex = 35;
		label_36.Text = "## ส\u0e34\u0e48งท\u0e35\u0e48ต\u0e49องทำเม\u0e37\u0e48อเข\u0e49าเง\u0e37\u0e48อนไข ##";
		button_37.Location = new Point(206, 91);
		button_37.Name = "button28";
		button_37.Size = new Size(92, 23);
		button_37.TabIndex = 34;
		button_37.Text = "โหลด";
		button_37.UseVisualStyleBackColor = true;
		button_37.Click += button_37_Click;
		button_38.Location = new Point(141, 221);
		button_38.Name = "button22";
		button_38.Size = new Size(25, 23);
		button_38.TabIndex = 34;
		button_38.Text = "Del";
		button_38.UseVisualStyleBackColor = true;
		button_38.Click += button_38_Click;
		label_37.BackColor = Color.FromArgb(255, 255, 192);
		label_37.Location = new Point(120, 67);
		label_37.Name = "label40";
		label_37.Size = new Size(42, 23);
		label_37.TabIndex = 33;
		label_37.Text = "Result";
		label_37.TextAlign = ContentAlignment.MiddleCenter;
		button_39.Location = new Point(168, 67);
		button_39.Name = "button23";
		button_39.Size = new Size(59, 23);
		button_39.TabIndex = 32;
		button_39.Text = "ถ\u0e31ดไป";
		button_39.UseVisualStyleBackColor = true;
		button_39.Click += button_39_Click;
		button_40.Location = new Point(10, 91);
		button_40.Name = "button24";
		button_40.Size = new Size(94, 23);
		button_40.TabIndex = 31;
		button_40.Text = "Load All Player";
		button_40.UseVisualStyleBackColor = true;
		button_40.Click += button_40_Click;
		comboBox_4.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_4.FormattingEnabled = true;
		comboBox_4.Items.AddRange(new object[1] { "all_player_found" });
		comboBox_4.Location = new Point(111, 92);
		comboBox_4.Name = "comboBox5";
		comboBox_4.Size = new Size(89, 21);
		comboBox_4.TabIndex = 30;
		button_41.Location = new Point(233, 67);
		button_41.Name = "button25";
		button_41.Size = new Size(59, 23);
		button_41.TabIndex = 29;
		button_41.Text = "เพ\u0e34\u0e48ม";
		button_41.UseVisualStyleBackColor = true;
		button_41.Click += button_41_Click;
		textBox_12.Location = new Point(10, 68);
		textBox_12.Name = "textBox5";
		textBox_12.Size = new Size(105, 20);
		textBox_12.TabIndex = 28;
		textBox_12.TextChanged += textBox_12_TextChanged;
		button_42.Location = new Point(141, 170);
		button_42.Name = "button26";
		button_42.Size = new Size(25, 23);
		button_42.TabIndex = 26;
		button_42.Text = "<";
		button_42.UseVisualStyleBackColor = true;
		button_42.Click += button_42_Click;
		button_43.Location = new Point(141, 141);
		button_43.Name = "button27";
		button_43.Size = new Size(25, 23);
		button_43.TabIndex = 27;
		button_43.Text = ">";
		button_43.UseVisualStyleBackColor = true;
		button_43.Click += button_43_Click;
		dataGridView_19.AllowUserToResizeColumns = false;
		dataGridView_19.AllowUserToResizeRows = false;
		dataGridView_19.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle12.BackColor = Color.White;
		dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
		dataGridView_19.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
		dataGridView_19.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_19.Columns.AddRange(dataGridViewTextBoxColumn_50);
		dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle13.BackColor = Color.White;
		dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
		dataGridView_19.DefaultCellStyle = dataGridViewCellStyle13;
		dataGridView_19.Location = new Point(10, 119);
		dataGridView_19.Name = "dataGridView4";
		dataGridView_19.ReadOnly = true;
		dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle14.BackColor = Color.White;
		dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
		dataGridView_19.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
		dataGridView_19.RowHeadersVisible = false;
		dataGridView_19.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_19.Size = new Size(129, 154);
		dataGridView_19.StandardTab = true;
		dataGridView_19.TabIndex = 25;
		dataGridViewTextBoxColumn_50.HeaderText = "รายช\u0e37\u0e48อผ\u0e39\u0e49เล\u0e48นท\u0e35\u0e48พบ";
		dataGridViewTextBoxColumn_50.Name = "dataGridViewTextBoxColumn49";
		dataGridViewTextBoxColumn_50.ReadOnly = true;
		dataGridView_20.AllowUserToResizeColumns = false;
		dataGridView_20.AllowUserToResizeRows = false;
		dataGridViewCellStyle15.BackColor = Color.White;
		dataGridView_20.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
		dataGridView_20.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle16.BackColor = Color.Gray;
		dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle16.SelectionBackColor = Color.Gray;
		dataGridViewCellStyle16.SelectionForeColor = Color.Gray;
		dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
		dataGridView_20.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
		dataGridView_20.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_20.Columns.AddRange(dataGridViewTextBoxColumn_51);
		dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle17.BackColor = Color.White;
		dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
		dataGridView_20.DefaultCellStyle = dataGridViewCellStyle17;
		dataGridView_20.Location = new Point(169, 119);
		dataGridView_20.Name = "dataGridView5";
		dataGridView_20.ReadOnly = true;
		dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle18.BackColor = Color.White;
		dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
		dataGridView_20.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
		dataGridView_20.RowHeadersVisible = false;
		dataGridViewCellStyle19.BackColor = Color.White;
		dataGridView_20.RowsDefaultCellStyle = dataGridViewCellStyle19;
		dataGridView_20.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_20.Size = new Size(129, 154);
		dataGridView_20.StandardTab = true;
		dataGridView_20.TabIndex = 24;
		dataGridViewTextBoxColumn_51.HeaderText = "รายช\u0e37\u0e48อผ\u0e39\u0e49เล\u0e48นท\u0e35\u0e48เล\u0e37อก";
		dataGridViewTextBoxColumn_51.Name = "dataGridViewTextBoxColumn50";
		dataGridViewTextBoxColumn_51.ReadOnly = true;
		radioButton_14.AutoSize = true;
		radioButton_14.Location = new Point(112, 45);
		radioButton_14.Name = "radioButton10";
		radioButton_14.Size = new Size(183, 17);
		radioButton_14.TabIndex = 9;
		radioButton_14.Text = "ผ\u0e39\u0e49เล\u0e48นท\u0e38กคน ยกเว\u0e49นรายช\u0e37\u0e48อใน List ";
		radioButton_14.UseVisualStyleBackColor = true;
		radioButton_15.AutoSize = true;
		radioButton_15.Location = new Point(13, 46);
		radioButton_15.Name = "radioButton11";
		radioButton_15.Size = new Size(80, 17);
		radioButton_15.TabIndex = 9;
		radioButton_15.Text = "ผ\u0e39\u0e49เล\u0e48นท\u0e38กคน";
		radioButton_15.UseVisualStyleBackColor = true;
		radioButton_16.AutoSize = true;
		radioButton_16.Checked = true;
		radioButton_16.Location = new Point(112, 25);
		radioButton_16.Name = "radioButton9";
		radioButton_16.Size = new Size(160, 17);
		radioButton_16.TabIndex = 9;
		radioButton_16.TabStop = true;
		radioButton_16.Text = "เฉพาะผ\u0e39\u0e49เล\u0e48นท\u0e35\u0e48ม\u0e35รายช\u0e37\u0e48อใน List";
		radioButton_16.UseVisualStyleBackColor = true;
		groupBox_0.Controls.Add(comboBox_7);
		groupBox_0.Controls.Add(label_41);
		groupBox_0.Controls.Add(dateTimePicker_7);
		groupBox_0.Controls.Add(label_42);
		groupBox_0.Controls.Add(textBox_19);
		groupBox_0.Controls.Add(checkBox_51);
		groupBox_0.Controls.Add(radioButton_17);
		groupBox_0.Controls.Add(radioButton_18);
		groupBox_0.Controls.Add(radioButton_19);
		groupBox_0.Controls.Add(label_105);
		groupBox_0.Location = new Point(315, 161);
		groupBox_0.Name = "groupBox2";
		groupBox_0.Size = new Size(302, 100);
		groupBox_0.TabIndex = 45;
		groupBox_0.TabStop = false;
		comboBox_7.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_7.DropDownWidth = 200;
		comboBox_7.FormattingEnabled = true;
		comboBox_7.Items.AddRange(new object[7] { "เด\u0e49งส\u0e49มและหย\u0e38ดการทำงาน", "เด\u0e49งส\u0e49ม ด\u0e35เลย\u0e4cตามเวลา และเด\u0e49งฟ\u0e49า ทำงานต\u0e48อ", "เปล\u0e35\u0e48ยน Loop ทำงาน", "หย\u0e38ดการทำงานท\u0e31นท\u0e35", "หย\u0e38ดและกล\u0e31บมาทำงานท\u0e31นท\u0e35", "หย\u0e38ดทำงานและกล\u0e31บมาทำงาน ตาม Delay", "หย\u0e38ดทำงานและกล\u0e31บมาทำงานตามเวลาท\u0e35\u0e48ต\u0e31\u0e49งไว\u0e49" });
		comboBox_7.Location = new Point(5, 45);
		comboBox_7.Name = "comboBox10";
		comboBox_7.Size = new Size(156, 21);
		comboBox_7.TabIndex = 36;
		label_41.AutoSize = true;
		label_41.BackColor = Color.FromArgb(128, 255, 255);
		label_41.Location = new Point(169, 49);
		label_41.Name = "label50";
		label_41.Size = new Size(37, 13);
		label_41.TabIndex = 38;
		label_41.Text = "Delay ";
		dateTimePicker_7.Format = DateTimePickerFormat.Time;
		dateTimePicker_7.Location = new Point(223, 71);
		dateTimePicker_7.Name = "dateTimePicker6";
		dateTimePicker_7.ShowUpDown = true;
		dateTimePicker_7.Size = new Size(74, 20);
		dateTimePicker_7.TabIndex = 42;
		label_42.AutoSize = true;
		label_42.BackColor = Color.FromArgb(128, 255, 255);
		label_42.Location = new Point(264, 48);
		label_42.Name = "label51";
		label_42.Size = new Size(33, 13);
		label_42.TabIndex = 37;
		label_42.Text = "ว\u0e34นาท\u0e35";
		textBox_19.Location = new Point(212, 45);
		textBox_19.Name = "textBox33";
		textBox_19.Size = new Size(48, 20);
		textBox_19.TabIndex = 39;
		textBox_19.Text = "5";
		textBox_19.TextAlign = HorizontalAlignment.Center;
		checkBox_51.AutoSize = true;
		checkBox_51.Checked = true;
		checkBox_51.CheckState = CheckState.Checked;
		checkBox_51.Location = new Point(20, 8);
		checkBox_51.Name = "checkBox71";
		checkBox_51.Size = new Size(78, 17);
		checkBox_51.TabIndex = 0;
		checkBox_51.Text = "GM หายต\u0e31ว";
		checkBox_51.UseVisualStyleBackColor = true;
		radioButton_17.AutoSize = true;
		radioButton_17.Checked = true;
		radioButton_17.Location = new Point(116, 8);
		radioButton_17.Name = "radioButton69";
		radioButton_17.Size = new Size(160, 17);
		radioButton_17.TabIndex = 9;
		radioButton_17.TabStop = true;
		radioButton_17.Text = "เฉพาะผ\u0e39\u0e49เล\u0e48นท\u0e35\u0e48ม\u0e35รายช\u0e37\u0e48อใน List";
		radioButton_17.UseVisualStyleBackColor = true;
		radioButton_18.AutoSize = true;
		radioButton_18.Location = new Point(20, 25);
		radioButton_18.Name = "radioButton71";
		radioButton_18.Size = new Size(80, 17);
		radioButton_18.TabIndex = 9;
		radioButton_18.Text = "ผ\u0e39\u0e49เล\u0e48นท\u0e38กคน";
		radioButton_18.UseVisualStyleBackColor = true;
		radioButton_19.AutoSize = true;
		radioButton_19.Location = new Point(116, 25);
		radioButton_19.Name = "radioButton70";
		radioButton_19.Size = new Size(183, 17);
		radioButton_19.TabIndex = 9;
		radioButton_19.Text = "ผ\u0e39\u0e49เล\u0e48นท\u0e38กคน ยกเว\u0e49นรายช\u0e37\u0e48อใน List ";
		radioButton_19.UseVisualStyleBackColor = true;
		label_105.AutoSize = true;
		label_105.BackColor = Color.FromArgb(255, 192, 192);
		label_105.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_105.Location = new Point(117, 73);
		label_105.Name = "label55";
		label_105.Size = new Size(99, 16);
		label_105.TabIndex = 35;
		label_105.Text = "จะทำงานต\u0e48อเม\u0e37\u0e48อเวลา";
		checkBox_42.AutoSize = true;
		checkBox_42.Checked = true;
		checkBox_42.CheckState = CheckState.Checked;
		checkBox_42.Location = new Point(14, 25);
		checkBox_42.Name = "checkBox41";
		checkBox_42.Size = new Size(78, 17);
		checkBox_42.TabIndex = 0;
		checkBox_42.Text = "GM หายต\u0e31ว";
		checkBox_42.UseVisualStyleBackColor = true;
		groupBox_1.Controls.Add(comboBox_8);
		groupBox_1.Controls.Add(label_43);
		groupBox_1.Controls.Add(dateTimePicker_8);
		groupBox_1.Controls.Add(label_44);
		groupBox_1.Controls.Add(textBox_20);
		groupBox_1.Controls.Add(checkBox_52);
		groupBox_1.Controls.Add(radioButton_20);
		groupBox_1.Controls.Add(radioButton_21);
		groupBox_1.Controls.Add(radioButton_22);
		groupBox_1.Controls.Add(label_106);
		groupBox_1.Location = new Point(315, 23);
		groupBox_1.Name = "groupBox1";
		groupBox_1.Size = new Size(302, 98);
		groupBox_1.TabIndex = 45;
		groupBox_1.TabStop = false;
		comboBox_8.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_8.DropDownWidth = 200;
		comboBox_8.FormattingEnabled = true;
		comboBox_8.Items.AddRange(new object[7] { "เด\u0e49งส\u0e49มและหย\u0e38ดการทำงาน", "เด\u0e49งส\u0e49ม ด\u0e35เลย\u0e4cตามเวลา และเด\u0e49งฟ\u0e49า ทำงานต\u0e48อ", "เปล\u0e35\u0e48ยน Loop ทำงาน", "หย\u0e38ดการทำงานท\u0e31นท\u0e35", "หย\u0e38ดและกล\u0e31บมาทำงานท\u0e31นท\u0e35", "หย\u0e38ดทำงานและกล\u0e31บมาทำงาน ตาม Delay", "หย\u0e38ดทำงานและกล\u0e31บมาทำงานตามเวลาท\u0e35\u0e48ต\u0e31\u0e49งไว\u0e49" });
		comboBox_8.Location = new Point(5, 44);
		comboBox_8.Name = "comboBox9";
		comboBox_8.Size = new Size(156, 21);
		comboBox_8.TabIndex = 36;
		label_43.AutoSize = true;
		label_43.BackColor = Color.FromArgb(128, 255, 255);
		label_43.Location = new Point(171, 48);
		label_43.Name = "label48";
		label_43.Size = new Size(34, 13);
		label_43.TabIndex = 38;
		label_43.Text = "Delay";
		dateTimePicker_8.Format = DateTimePickerFormat.Time;
		dateTimePicker_8.Location = new Point(222, 70);
		dateTimePicker_8.Name = "dateTimePicker5";
		dateTimePicker_8.ShowUpDown = true;
		dateTimePicker_8.Size = new Size(74, 20);
		dateTimePicker_8.TabIndex = 42;
		label_44.AutoSize = true;
		label_44.BackColor = Color.FromArgb(128, 255, 255);
		label_44.Location = new Point(264, 47);
		label_44.Name = "label49";
		label_44.Size = new Size(33, 13);
		label_44.TabIndex = 37;
		label_44.Text = "ว\u0e34นาท\u0e35";
		textBox_20.Location = new Point(212, 44);
		textBox_20.Name = "textBox32";
		textBox_20.Size = new Size(48, 20);
		textBox_20.TabIndex = 39;
		textBox_20.Text = "5";
		textBox_20.TextAlign = HorizontalAlignment.Center;
		checkBox_52.AutoSize = true;
		checkBox_52.Checked = true;
		checkBox_52.CheckState = CheckState.Checked;
		checkBox_52.Location = new Point(20, 9);
		checkBox_52.Name = "checkBox70";
		checkBox_52.Size = new Size(78, 17);
		checkBox_52.TabIndex = 0;
		checkBox_52.Text = "GM หายต\u0e31ว";
		checkBox_52.UseVisualStyleBackColor = true;
		radioButton_20.AutoSize = true;
		radioButton_20.Checked = true;
		radioButton_20.Location = new Point(116, 9);
		radioButton_20.Name = "radioButton59";
		radioButton_20.Size = new Size(160, 17);
		radioButton_20.TabIndex = 9;
		radioButton_20.TabStop = true;
		radioButton_20.Text = "เฉพาะผ\u0e39\u0e49เล\u0e48นท\u0e35\u0e48ม\u0e35รายช\u0e37\u0e48อใน List";
		radioButton_20.UseVisualStyleBackColor = true;
		radioButton_21.AutoSize = true;
		radioButton_21.Location = new Point(116, 26);
		radioButton_21.Name = "radioButton60";
		radioButton_21.Size = new Size(183, 17);
		radioButton_21.TabIndex = 9;
		radioButton_21.Text = "ผ\u0e39\u0e49เล\u0e48นท\u0e38กคน ยกเว\u0e49นรายช\u0e37\u0e48อใน List ";
		radioButton_21.UseVisualStyleBackColor = true;
		radioButton_22.AutoSize = true;
		radioButton_22.Location = new Point(20, 26);
		radioButton_22.Name = "radioButton61";
		radioButton_22.Size = new Size(80, 17);
		radioButton_22.TabIndex = 9;
		radioButton_22.Text = "ผ\u0e39\u0e49เล\u0e48นท\u0e38กคน";
		radioButton_22.UseVisualStyleBackColor = true;
		label_106.AutoSize = true;
		label_106.BackColor = Color.FromArgb(255, 192, 192);
		label_106.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_106.Location = new Point(116, 72);
		label_106.Name = "label54";
		label_106.Size = new Size(99, 16);
		label_106.TabIndex = 35;
		label_106.Text = "จะทำงานต\u0e48อเม\u0e37\u0e48อเวลา";
		tabPage_7.BorderStyle = BorderStyle.FixedSingle;
		tabPage_7.Controls.Add(textBox_65);
		tabPage_7.Controls.Add(button_88);
		tabPage_7.Controls.Add(dataGridView_23);
		tabPage_7.Controls.Add(label_70);
		tabPage_7.Controls.Add(trackBar_1);
		tabPage_7.Controls.Add(checkBox_65);
		tabPage_7.Controls.Add(label_38);
		tabPage_7.Controls.Add(comboBox_6);
		tabPage_7.Controls.Add(comboBox_5);
		tabPage_7.Controls.Add(checkBox_45);
		tabPage_7.Controls.Add(checkBox_46);
		tabPage_7.Controls.Add(checkBox_44);
		tabPage_7.Location = new Point(4, 49);
		tabPage_7.Name = "tabPage8";
		tabPage_7.Size = new Size(638, 370);
		tabPage_7.TabIndex = 9;
		tabPage_7.Text = "  Pet";
		tabPage_7.UseVisualStyleBackColor = true;
		textBox_65.BackColor = Color.FromArgb(255, 224, 192);
		textBox_65.Location = new Point(126, 7);
		textBox_65.Name = "textBox6";
		textBox_65.ReadOnly = true;
		textBox_65.Size = new Size(100, 20);
		textBox_65.TabIndex = 17;
		button_88.BackColor = Color.FromArgb(192, 255, 192);
		button_88.Location = new Point(228, 7);
		button_88.Name = "button80";
		button_88.Size = new Size(75, 23);
		button_88.TabIndex = 16;
		button_88.Text = "Pet Card";
		button_88.UseVisualStyleBackColor = false;
		dataGridView_23.AllowUserToResizeColumns = false;
		dataGridView_23.AllowUserToResizeRows = false;
		dataGridViewCellStyle20.BackColor = Color.White;
		dataGridView_23.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
		dataGridView_23.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle21.BackColor = Color.Gray;
		dataGridViewCellStyle21.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle21.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle21.SelectionBackColor = Color.Gray;
		dataGridViewCellStyle21.SelectionForeColor = Color.Gray;
		dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
		dataGridView_23.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
		dataGridView_23.ColumnHeadersHeight = 28;
		dataGridView_23.Columns.AddRange(dataGridViewTextBoxColumn_57, dataGridViewTextBoxColumn_58, dataGridViewTextBoxColumn_59);
		dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle22.BackColor = Color.White;
		dataGridViewCellStyle22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle22.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
		dataGridView_23.DefaultCellStyle = dataGridViewCellStyle22;
		dataGridView_23.GridColor = SystemColors.ActiveBorder;
		dataGridView_23.Location = new Point(10, 203);
		dataGridView_23.Name = "dataGridView7";
		dataGridView_23.ReadOnly = true;
		dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle23.BackColor = Color.White;
		dataGridViewCellStyle23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle23.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
		dataGridView_23.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
		dataGridView_23.RowHeadersVisible = false;
		dataGridView_23.RowHeadersWidth = 40;
		dataGridViewCellStyle24.BackColor = Color.White;
		dataGridView_23.RowsDefaultCellStyle = dataGridViewCellStyle24;
		dataGridView_23.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_23.Size = new Size(295, 127);
		dataGridView_23.StandardTab = true;
		dataGridView_23.TabIndex = 15;
		dataGridViewTextBoxColumn_57.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewTextBoxColumn_57.DefaultCellStyle = dataGridViewCellStyle25;
		dataGridViewTextBoxColumn_57.FillWeight = 50f;
		dataGridViewTextBoxColumn_57.Frozen = true;
		dataGridViewTextBoxColumn_57.HeaderText = "ช\u0e48องท\u0e35\u0e48";
		dataGridViewTextBoxColumn_57.Name = "dataGridViewTextBoxColumn52";
		dataGridViewTextBoxColumn_57.ReadOnly = true;
		dataGridViewTextBoxColumn_57.Width = 40;
		dataGridViewTextBoxColumn_58.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewTextBoxColumn_58.DefaultCellStyle = dataGridViewCellStyle26;
		dataGridViewTextBoxColumn_58.FillWeight = 180f;
		dataGridViewTextBoxColumn_58.Frozen = true;
		dataGridViewTextBoxColumn_58.HeaderText = "รายการไอเท\u0e47ม";
		dataGridViewTextBoxColumn_58.Name = "dataGridViewTextBoxColumn53";
		dataGridViewTextBoxColumn_58.ReadOnly = true;
		dataGridViewTextBoxColumn_58.Width = 180;
		dataGridViewTextBoxColumn_59.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewTextBoxColumn_59.DefaultCellStyle = dataGridViewCellStyle27;
		dataGridViewTextBoxColumn_59.Frozen = true;
		dataGridViewTextBoxColumn_59.HeaderText = "จำนวน";
		dataGridViewTextBoxColumn_59.Name = "dataGridViewTextBoxColumn54";
		dataGridViewTextBoxColumn_59.ReadOnly = true;
		dataGridViewTextBoxColumn_59.Width = 72;
		label_70.AutoSize = true;
		label_70.BackColor = Color.FromArgb(128, 128, 255);
		label_70.Location = new Point(271, 160);
		label_70.Name = "label37";
		label_70.Size = new Size(30, 13);
		label_70.TabIndex = 6;
		label_70.Text = "50 %";
		trackBar_1.Location = new Point(11, 160);
		trackBar_1.Maximum = 100;
		trackBar_1.Name = "trackBar2";
		trackBar_1.Size = new Size(252, 45);
		trackBar_1.SmallChange = 10;
		trackBar_1.TabIndex = 5;
		trackBar_1.Value = 50;
		trackBar_1.Scroll += trackBar_1_Scroll;
		checkBox_65.AutoSize = true;
		checkBox_65.Location = new Point(11, 138);
		checkBox_65.Name = "checkBox64";
		checkBox_65.Size = new Size(150, 17);
		checkBox_65.TabIndex = 4;
		checkBox_65.Text = "ให\u0e49อาหารส\u0e31ตว\u0e4cเล\u0e35\u0e49ยงอ\u0e31ตโนม\u0e31ต\u0e34";
		checkBox_65.UseVisualStyleBackColor = true;
		label_38.AutoSize = true;
		label_38.Location = new Point(102, 88);
		label_38.Name = "label46";
		label_38.Size = new Size(104, 13);
		label_38.TabIndex = 3;
		label_38.Text = "ความอ\u0e34\u0e48มของส\u0e31ตว\u0e4cเล\u0e35\u0e49ยง";
		comboBox_6.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_6.FormattingEnabled = true;
		comboBox_6.Items.AddRange(new object[5] { "ค\u0e31มภ\u0e35ย\u0e4cเก\u0e47บกวาด", "ค\u0e31มภ\u0e35ย\u0e4cเพร\u0e35ยกหา", "ค\u0e31มภ\u0e35ย\u0e4cเร\u0e35ยกน\u0e49ำยา", "ค\u0e31มภ\u0e35ย\u0e4cร\u0e48ำรวย", "ค\u0e31มภ\u0e35ย\u0e4cข\u0e38ดแร\u0e48\t" });
		comboBox_6.Location = new Point(81, 58);
		comboBox_6.Name = "comboBox8";
		comboBox_6.Size = new Size(121, 21);
		comboBox_6.TabIndex = 2;
		comboBox_6.Visible = false;
		comboBox_5.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_5.FormattingEnabled = true;
		comboBox_5.Items.AddRange(new object[5] { "ค\u0e31มภ\u0e35ย\u0e4cเก\u0e47บกวาด", "ค\u0e31มภ\u0e35ย\u0e4cเพร\u0e35ยกหา", "ค\u0e31มภ\u0e35ย\u0e4cเร\u0e35ยกน\u0e49ำยา", "ค\u0e31มภ\u0e35ย\u0e4cร\u0e48ำรวย", "ค\u0e31มภ\u0e35ย\u0e4cข\u0e38ดแร\u0e48\t" });
		comboBox_5.Location = new Point(81, 32);
		comboBox_5.Name = "comboBox7";
		comboBox_5.Size = new Size(121, 21);
		comboBox_5.TabIndex = 2;
		comboBox_5.Visible = false;
		checkBox_45.AutoSize = true;
		checkBox_45.Location = new Point(11, 60);
		checkBox_45.Name = "checkBox49";
		checkBox_45.Size = new Size(68, 17);
		checkBox_45.TabIndex = 1;
		checkBox_45.Text = "ใช\u0e49สก\u0e34ล B";
		checkBox_45.UseVisualStyleBackColor = true;
		checkBox_45.Visible = false;
		checkBox_45.CheckedChanged += checkBox_45_CheckedChanged;
		checkBox_46.AutoSize = true;
		checkBox_46.Location = new Point(11, 35);
		checkBox_46.Name = "checkBox48";
		checkBox_46.Size = new Size(68, 17);
		checkBox_46.TabIndex = 1;
		checkBox_46.Text = "ใช\u0e49สก\u0e34ล A";
		checkBox_46.UseVisualStyleBackColor = true;
		checkBox_46.Visible = false;
		checkBox_46.CheckedChanged += checkBox_46_CheckedChanged;
		checkBox_44.AutoSize = true;
		checkBox_44.Location = new Point(6, 10);
		checkBox_44.Name = "checkBox47";
		checkBox_44.Size = new Size(122, 17);
		checkBox_44.TabIndex = 0;
		checkBox_44.Text = "ใช\u0e49งานส\u0e31ตว\u0e4cเล\u0e35\u0e49ยง ( D )";
		checkBox_44.UseVisualStyleBackColor = true;
		tabPage_10.BorderStyle = BorderStyle.FixedSingle;
		tabPage_10.Controls.Add(label_88);
		tabPage_10.Controls.Add(button_60);
		tabPage_10.Controls.Add(button_82);
		tabPage_10.Controls.Add(button_61);
		tabPage_10.Controls.Add(panel_0);
		tabPage_10.Controls.Add(dataGridView_22);
		tabPage_10.Location = new Point(4, 49);
		tabPage_10.Name = "tabPage10";
		tabPage_10.Size = new Size(638, 370);
		tabPage_10.TabIndex = 11;
		tabPage_10.Text = " Bag";
		tabPage_10.UseVisualStyleBackColor = true;
		label_88.AutoSize = true;
		label_88.BackColor = Color.FromArgb(192, 192, 255);
		label_88.Location = new Point(262, 318);
		label_88.Name = "label79";
		label_88.Size = new Size(36, 13);
		label_88.TabIndex = 16;
		label_88.Text = "0 / 24";
		button_60.BackColor = Color.FromArgb(255, 192, 192);
		button_60.Location = new Point(168, 313);
		button_60.Name = "button45";
		button_60.Size = new Size(88, 23);
		button_60.TabIndex = 15;
		button_60.Text = "ลบออกจากรายการขาย";
		button_60.UseVisualStyleBackColor = false;
		button_60.Click += button_60_Click;
		button_82.BackColor = Color.FromArgb(255, 255, 192);
		button_82.Location = new Point(2, 313);
		button_82.Name = "button79";
		button_82.Size = new Size(83, 23);
		button_82.TabIndex = 15;
		button_82.Text = "เป\u0e34ดกระเป\u0e4bา";
		button_82.UseVisualStyleBackColor = false;
		button_82.Click += button_82_Click;
		button_61.BackColor = Color.FromArgb(192, 255, 192);
		button_61.Location = new Point(85, 313);
		button_61.Name = "button37";
		button_61.Size = new Size(83, 23);
		button_61.TabIndex = 15;
		button_61.Text = "เพ\u0e34\u0e48มเข\u0e49ารายการขาย";
		button_61.UseVisualStyleBackColor = false;
		button_61.Click += button_61_Click;
		panel_0.BackColor = SystemColors.Control;
		panel_0.BorderStyle = BorderStyle.FixedSingle;
		panel_0.Controls.Add(panel_12);
		panel_0.Controls.Add(panel_11);
		panel_0.Controls.Add(panel_10);
		panel_0.Controls.Add(panel_9);
		panel_0.Controls.Add(panel_8);
		panel_0.Controls.Add(panel_7);
		panel_0.Controls.Add(panel_6);
		panel_0.Controls.Add(panel_5);
		panel_0.Controls.Add(panel_4);
		panel_0.Controls.Add(panel_3);
		panel_0.Controls.Add(panel_2);
		panel_0.Controls.Add(panel_1);
		panel_0.Location = new Point(321, 3);
		panel_0.Name = "panelEquip";
		panel_0.Size = new Size(295, 304);
		panel_0.TabIndex = 17;
		panel_12.BackColor = Color.White;
		panel_12.BorderStyle = BorderStyle.FixedSingle;
		panel_12.Controls.Add(label_167);
		panel_12.Controls.Add(label_166);
		panel_12.Location = new Point(197, 228);
		panel_12.Name = "panEquip12";
		panel_12.Size = new Size(93, 71);
		panel_12.TabIndex = 11;
		label_167.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_167.Location = new Point(49, 54);
		label_167.Name = "lblEquipQty12";
		label_167.Size = new Size(40, 13);
		label_167.TabIndex = 1;
		label_167.TextAlign = ContentAlignment.BottomRight;
		label_166.Location = new Point(2, 2);
		label_166.Name = "lblEquipName12";
		label_166.Size = new Size(87, 50);
		label_166.TabIndex = 0;
		label_166.Text = "Vehicle";
		panel_11.BackColor = Color.White;
		panel_11.BorderStyle = BorderStyle.FixedSingle;
		panel_11.Controls.Add(label_165);
		panel_11.Controls.Add(label_164);
		panel_11.Location = new Point(100, 228);
		panel_11.Name = "panEquip11";
		panel_11.Size = new Size(93, 71);
		panel_11.TabIndex = 10;
		label_165.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_165.Location = new Point(49, 54);
		label_165.Name = "lblEquipQty11";
		label_165.Size = new Size(40, 13);
		label_165.TabIndex = 1;
		label_165.TextAlign = ContentAlignment.BottomRight;
		label_164.Location = new Point(2, 2);
		label_164.Name = "lblEquipName11";
		label_164.Size = new Size(87, 50);
		label_164.TabIndex = 0;
		label_164.Text = "Ring 2";
		panel_10.BackColor = Color.White;
		panel_10.BorderStyle = BorderStyle.FixedSingle;
		panel_10.Controls.Add(label_163);
		panel_10.Controls.Add(label_162);
		panel_10.Location = new Point(3, 228);
		panel_10.Name = "panEquip10";
		panel_10.Size = new Size(93, 71);
		panel_10.TabIndex = 9;
		label_163.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_163.Location = new Point(49, 54);
		label_163.Name = "lblEquipQty10";
		label_163.Size = new Size(40, 13);
		label_163.TabIndex = 1;
		label_163.TextAlign = ContentAlignment.BottomRight;
		label_162.Location = new Point(2, 2);
		label_162.Name = "lblEquipName10";
		label_162.Size = new Size(87, 50);
		label_162.TabIndex = 0;
		label_162.Text = "Ring";
		panel_9.BackColor = Color.White;
		panel_9.BorderStyle = BorderStyle.FixedSingle;
		panel_9.Controls.Add(label_161);
		panel_9.Controls.Add(label_160);
		panel_9.Location = new Point(197, 153);
		panel_9.Name = "panEquip9";
		panel_9.Size = new Size(93, 71);
		panel_9.TabIndex = 8;
		label_161.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_161.Location = new Point(49, 54);
		label_161.Name = "lblEquipQty9";
		label_161.Size = new Size(40, 13);
		label_161.TabIndex = 1;
		label_161.TextAlign = ContentAlignment.BottomRight;
		label_160.Location = new Point(2, 2);
		label_160.Name = "lblEquipName9";
		label_160.Size = new Size(87, 50);
		label_160.TabIndex = 0;
		label_160.Text = "Bracelet";
		panel_8.BackColor = Color.White;
		panel_8.BorderStyle = BorderStyle.FixedSingle;
		panel_8.Controls.Add(label_159);
		panel_8.Controls.Add(label_158);
		panel_8.Location = new Point(100, 153);
		panel_8.Name = "panEquip8";
		panel_8.Size = new Size(93, 71);
		panel_8.TabIndex = 7;
		label_159.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_159.Location = new Point(49, 54);
		label_159.Name = "lblEquipQty8";
		label_159.Size = new Size(40, 13);
		label_159.TabIndex = 1;
		label_159.TextAlign = ContentAlignment.BottomRight;
		label_158.Location = new Point(2, 2);
		label_158.Name = "lblEquipName8";
		label_158.Size = new Size(87, 50);
		label_158.TabIndex = 0;
		label_158.Text = "Necklace";
		panel_7.BackColor = Color.White;
		panel_7.BorderStyle = BorderStyle.FixedSingle;
		panel_7.Controls.Add(label_157);
		panel_7.Controls.Add(label_156);
		panel_7.Location = new Point(3, 153);
		panel_7.Name = "panEquip7";
		panel_7.Size = new Size(93, 71);
		panel_7.TabIndex = 6;
		label_157.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_157.Location = new Point(49, 54);
		label_157.Name = "lblEquipQty7";
		label_157.Size = new Size(40, 13);
		label_157.TabIndex = 1;
		label_157.TextAlign = ContentAlignment.BottomRight;
		label_156.Location = new Point(2, 2);
		label_156.Name = "lblEquipName7";
		label_156.Size = new Size(87, 50);
		label_156.TabIndex = 0;
		label_156.Text = "Hand";
		panel_6.BackColor = Color.White;
		panel_6.BorderStyle = BorderStyle.FixedSingle;
		panel_6.Controls.Add(label_155);
		panel_6.Controls.Add(label_154);
		panel_6.Location = new Point(197, 78);
		panel_6.Name = "panEquip6";
		panel_6.Size = new Size(93, 71);
		panel_6.TabIndex = 5;
		label_155.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_155.Location = new Point(49, 54);
		label_155.Name = "lblEquipQty6";
		label_155.Size = new Size(40, 13);
		label_155.TabIndex = 1;
		label_155.TextAlign = ContentAlignment.BottomRight;
		label_154.Location = new Point(2, 2);
		label_154.Name = "lblEquipName6";
		label_154.Size = new Size(87, 50);
		label_154.TabIndex = 0;
		label_154.Text = "Foot";
		panel_5.BackColor = Color.White;
		panel_5.BorderStyle = BorderStyle.FixedSingle;
		panel_5.Controls.Add(label_153);
		panel_5.Controls.Add(label_152);
		panel_5.Location = new Point(100, 78);
		panel_5.Name = "panEquip5";
		panel_5.Size = new Size(93, 71);
		panel_5.TabIndex = 4;
		label_153.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_153.Location = new Point(49, 54);
		label_153.Name = "lblEquipQty5";
		label_153.Size = new Size(40, 13);
		label_153.TabIndex = 1;
		label_153.TextAlign = ContentAlignment.BottomRight;
		label_152.Location = new Point(2, 2);
		label_152.Name = "lblEquipName5";
		label_152.Size = new Size(87, 50);
		label_152.TabIndex = 0;
		label_152.Text = "Lower";
		panel_4.BackColor = Color.White;
		panel_4.BorderStyle = BorderStyle.FixedSingle;
		panel_4.Controls.Add(label_151);
		panel_4.Controls.Add(label_150);
		panel_4.Location = new Point(3, 78);
		panel_4.Name = "panEquip4";
		panel_4.Size = new Size(93, 71);
		panel_4.TabIndex = 3;
		label_151.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_151.Location = new Point(49, 54);
		label_151.Name = "lblEquipQty4";
		label_151.Size = new Size(40, 13);
		label_151.TabIndex = 1;
		label_151.TextAlign = ContentAlignment.BottomRight;
		label_150.Location = new Point(2, 2);
		label_150.Name = "lblEquipName4";
		label_150.Size = new Size(87, 50);
		label_150.TabIndex = 0;
		label_150.Text = "Upper";
		panel_3.BackColor = Color.White;
		panel_3.BorderStyle = BorderStyle.FixedSingle;
		panel_3.Controls.Add(label_149);
		panel_3.Controls.Add(label_148);
		panel_3.Location = new Point(197, 3);
		panel_3.Name = "panEquip3";
		panel_3.Size = new Size(93, 71);
		panel_3.TabIndex = 2;
		label_149.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_149.Location = new Point(49, 54);
		label_149.Name = "lblEquipQty3";
		label_149.Size = new Size(40, 13);
		label_149.TabIndex = 1;
		label_149.TextAlign = ContentAlignment.BottomRight;
		label_148.Location = new Point(2, 2);
		label_148.Name = "lblEquipName3";
		label_148.Size = new Size(87, 50);
		label_148.TabIndex = 0;
		label_148.Text = "Off-hand";
		panel_2.BackColor = Color.White;
		panel_2.BorderStyle = BorderStyle.FixedSingle;
		panel_2.Controls.Add(label_147);
		panel_2.Controls.Add(label_146);
		panel_2.Location = new Point(100, 3);
		panel_2.Name = "panEquip2";
		panel_2.Size = new Size(93, 71);
		panel_2.TabIndex = 1;
		label_147.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_147.Location = new Point(49, 54);
		label_147.Name = "lblEquipQty2";
		label_147.Size = new Size(40, 13);
		label_147.TabIndex = 1;
		label_147.TextAlign = ContentAlignment.BottomRight;
		label_146.Location = new Point(2, 2);
		label_146.Name = "lblEquipName2";
		label_146.Size = new Size(87, 50);
		label_146.TabIndex = 0;
		label_146.Text = "Weapon";
		panel_1.BackColor = Color.White;
		panel_1.BorderStyle = BorderStyle.FixedSingle;
		panel_1.Controls.Add(label_145);
		panel_1.Controls.Add(label_144);
		panel_1.Location = new Point(3, 3);
		panel_1.Name = "panEquip1";
		panel_1.Size = new Size(93, 71);
		panel_1.TabIndex = 0;
		label_145.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_145.Location = new Point(49, 54);
		label_145.Name = "lblEquipQty1";
		label_145.Size = new Size(40, 13);
		label_145.TabIndex = 1;
		label_145.TextAlign = ContentAlignment.BottomRight;
		label_144.Location = new Point(2, 2);
		label_144.Name = "lblEquipName1";
		label_144.Size = new Size(87, 50);
		label_144.TabIndex = 0;
		label_144.Text = "Head";
		dataGridView_22.AllowUserToResizeColumns = false;
		dataGridView_22.AllowUserToResizeRows = false;
		dataGridViewCellStyle28.BackColor = Color.White;
		dataGridView_22.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
		dataGridView_22.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle29.BackColor = Color.Gray;
		dataGridViewCellStyle29.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle29.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle29.SelectionBackColor = Color.Gray;
		dataGridViewCellStyle29.SelectionForeColor = Color.Gray;
		dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
		dataGridView_22.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
		dataGridView_22.ColumnHeadersHeight = 28;
		dataGridView_22.Columns.AddRange(dataGridViewTextBoxColumn_64, dataGridViewTextBoxColumn_65, dataGridViewTextBoxColumn_66);
		dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle30.BackColor = Color.White;
		dataGridViewCellStyle30.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle30.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle30.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle30.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle30.WrapMode = DataGridViewTriState.False;
		dataGridView_22.DefaultCellStyle = dataGridViewCellStyle30;
		dataGridView_22.GridColor = SystemColors.ActiveBorder;
		dataGridView_22.Location = new Point(10, 3);
		dataGridView_22.Name = "dataGridView6";
		dataGridView_22.ReadOnly = true;
		dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle31.BackColor = Color.White;
		dataGridViewCellStyle31.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle31.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle31.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle31.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle31.WrapMode = DataGridViewTriState.True;
		dataGridView_22.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
		dataGridView_22.RowHeadersVisible = false;
		dataGridView_22.RowHeadersWidth = 40;
		dataGridViewCellStyle32.BackColor = Color.White;
		dataGridView_22.RowsDefaultCellStyle = dataGridViewCellStyle32;
		dataGridView_22.ScrollBars = ScrollBars.Vertical;
		dataGridView_22.SelectionMode = DataGridViewSelectionMode.CellSelect;
		dataGridView_22.Size = new Size(295, 304);
		dataGridView_22.StandardTab = true;
		dataGridView_22.TabIndex = 14;
		dataGridView_22.CellDoubleClick += dataGridView_22_CellDoubleClick;
		dataGridViewTextBoxColumn_64.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewTextBoxColumn_64.DefaultCellStyle = dataGridViewCellStyle33;
		dataGridViewTextBoxColumn_64.FillWeight = 50f;
		dataGridViewTextBoxColumn_64.Frozen = true;
		dataGridViewTextBoxColumn_64.HeaderText = "ช\u0e48องท\u0e35\u0e48";
		dataGridViewTextBoxColumn_64.Name = "Column6";
		dataGridViewTextBoxColumn_64.ReadOnly = true;
		dataGridViewTextBoxColumn_64.Width = 40;
		dataGridViewTextBoxColumn_65.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewTextBoxColumn_65.DefaultCellStyle = dataGridViewCellStyle34;
		dataGridViewTextBoxColumn_65.FillWeight = 180f;
		dataGridViewTextBoxColumn_65.Frozen = true;
		dataGridViewTextBoxColumn_65.HeaderText = "รายการไอเท\u0e47ม";
		dataGridViewTextBoxColumn_65.Name = "dataGridViewTextBoxColumn51";
		dataGridViewTextBoxColumn_65.ReadOnly = true;
		dataGridViewTextBoxColumn_65.Width = 180;
		dataGridViewTextBoxColumn_66.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewTextBoxColumn_66.DefaultCellStyle = dataGridViewCellStyle35;
		dataGridViewTextBoxColumn_66.HeaderText = "จำนวน";
		dataGridViewTextBoxColumn_66.Name = "Column7";
		dataGridViewTextBoxColumn_66.ReadOnly = true;
		dataGridViewTextBoxColumn_66.Width = 72;
		tabPage_12.BorderStyle = BorderStyle.FixedSingle;
		tabPage_12.Controls.Add(button_86);
		tabPage_12.Controls.Add(button_85);
		tabPage_12.Controls.Add(textBox_62);
		tabPage_12.Controls.Add(checkBox_101);
		tabPage_12.Controls.Add(button_78);
		tabPage_12.Controls.Add(textBox_56);
		tabPage_12.Controls.Add(label_130);
		tabPage_12.Controls.Add(label_131);
		tabPage_12.Controls.Add(button_62);
		tabPage_12.Controls.Add(comboBox_21);
		tabPage_12.Controls.Add(label_85);
		tabPage_12.Controls.Add(label_86);
		tabPage_12.Controls.Add(label_82);
		tabPage_12.Controls.Add(textBox_35);
		tabPage_12.Controls.Add(label_83);
		tabPage_12.Controls.Add(label_84);
		tabPage_12.Controls.Add(comboBox_18);
		tabPage_12.Controls.Add(button_59);
		tabPage_12.Controls.Add(label_80);
		tabPage_12.Controls.Add(textBox_57);
		tabPage_12.Controls.Add(textBox_34);
		tabPage_12.Controls.Add(label_77);
		tabPage_12.Controls.Add(button_52);
		tabPage_12.Controls.Add(button_53);
		tabPage_12.Controls.Add(button_54);
		tabPage_12.Controls.Add(textBox_33);
		tabPage_12.Controls.Add(button_55);
		tabPage_12.Controls.Add(button_56);
		tabPage_12.Controls.Add(button_57);
		tabPage_12.Controls.Add(button_58);
		tabPage_12.Controls.Add(dataGridView_24);
		tabPage_12.Controls.Add(dataGridView_25);
		tabPage_12.Controls.Add(dataGridView_26);
		tabPage_12.Controls.Add(dataGridView_27);
		tabPage_12.Controls.Add(checkBox_69);
		tabPage_12.Controls.Add(checkBox_70);
		tabPage_12.Controls.Add(label_78);
		tabPage_12.Controls.Add(label_79);
		tabPage_12.Controls.Add(label_81);
		tabPage_12.Controls.Add(label_76);
		tabPage_12.Location = new Point(4, 49);
		tabPage_12.Name = "tabPage12";
		tabPage_12.Size = new Size(638, 370);
		tabPage_12.TabIndex = 13;
		tabPage_12.Text = "  Sell";
		tabPage_12.UseVisualStyleBackColor = true;
		button_86.Location = new Point(169, 96);
		button_86.Name = "button31";
		button_86.Size = new Size(62, 23);
		button_86.TabIndex = 71;
		button_86.Text = "Friends";
		button_86.UseVisualStyleBackColor = true;
		button_85.Location = new Point(156, 239);
		button_85.Name = "button19";
		button_85.Size = new Size(60, 23);
		button_85.TabIndex = 70;
		button_85.Text = "NPC";
		button_85.UseVisualStyleBackColor = true;
		textBox_62.Location = new Point(89, 97);
		textBox_62.Name = "textBox63";
		textBox_62.ReadOnly = true;
		textBox_62.Size = new Size(74, 20);
		textBox_62.TabIndex = 69;
		checkBox_101.AutoSize = true;
		checkBox_101.Location = new Point(7, 98);
		checkBox_101.Name = "checkBox101";
		checkBox_101.Size = new Size(83, 17);
		checkBox_101.TabIndex = 68;
		checkBox_101.Text = "วาปหาเพ\u0e37\u0e48อน";
		checkBox_101.UseVisualStyleBackColor = true;
		button_78.Location = new Point(132, 266);
		button_78.Name = "button78";
		button_78.Size = new Size(99, 23);
		button_78.TabIndex = 59;
		button_78.Text = "Set ตำแหน\u0e48ง NPC";
		button_78.UseVisualStyleBackColor = true;
		button_78.Click += button_78_Click;
		textBox_56.Location = new Point(7, 240);
		textBox_56.Name = "textBox61";
		textBox_56.ReadOnly = true;
		textBox_56.Size = new Size(133, 20);
		textBox_56.TabIndex = 57;
		label_130.AutoSize = true;
		label_130.BackColor = Color.FromArgb(255, 192, 128);
		label_130.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_130.Location = new Point(156, 216);
		label_130.Name = "label123";
		label_130.Size = new Size(60, 16);
		label_130.TabIndex = 55;
		label_130.Text = "# ลำด\u0e31บ #";
		label_131.AutoSize = true;
		label_131.BackColor = Color.FromArgb(255, 192, 128);
		label_131.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_131.Location = new Point(14, 216);
		label_131.Name = "label122";
		label_131.Size = new Size(123, 16);
		label_131.TabIndex = 56;
		label_131.Text = "##  ระบ\u0e38ช\u0e37\u0e48อ NPC ##";
		button_62.Location = new Point(542, 29);
		button_62.Name = "button46";
		button_62.Size = new Size(75, 23);
		button_62.TabIndex = 52;
		button_62.Text = "โหลด";
		button_62.UseVisualStyleBackColor = true;
		button_62.Click += button_62_Click;
		comboBox_21.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_21.FormattingEnabled = true;
		comboBox_21.Location = new Point(386, 31);
		comboBox_21.Name = "comboBox15";
		comboBox_21.Size = new Size(145, 21);
		comboBox_21.TabIndex = 51;
		label_85.AutoSize = true;
		label_85.BackColor = Color.FromArgb(128, 255, 128);
		label_85.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_85.Location = new Point(99, 77);
		label_85.Name = "label81";
		label_85.Size = new Size(125, 13);
		label_85.TabIndex = 50;
		label_85.Text = "ม\u0e35ไอเท\u0e47มต\u0e49องการขาย 0 / 0";
		label_85.TextAlign = ContentAlignment.MiddleCenter;
		label_86.AutoSize = true;
		label_86.BackColor = Color.FromArgb(255, 192, 192);
		label_86.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_86.Location = new Point(8, 77);
		label_86.Name = "label80";
		label_86.Size = new Size(68, 13);
		label_86.TabIndex = 50;
		label_86.Text = "กระเป\u0e4bา 0 / 0";
		label_86.TextAlign = ContentAlignment.MiddleCenter;
		label_82.AutoSize = true;
		label_82.BackColor = Color.FromArgb(255, 255, 128);
		label_82.Location = new Point(99, 322);
		label_82.Name = "label76";
		label_82.Size = new Size(107, 13);
		label_82.TabIndex = 50;
		label_82.Text = "อ\u0e35ก ..... ว\u0e34นาท\u0e35 เด\u0e49งกล\u0e31บ";
		textBox_35.Location = new Point(116, 296);
		textBox_35.Name = "textBox42";
		textBox_35.Size = new Size(48, 20);
		textBox_35.TabIndex = 49;
		textBox_35.Text = "5";
		textBox_35.TextAlign = HorizontalAlignment.Center;
		label_83.AutoSize = true;
		label_83.BackColor = Color.FromArgb(128, 255, 255);
		label_83.Location = new Point(173, 299);
		label_83.Name = "label77";
		label_83.Size = new Size(33, 13);
		label_83.TabIndex = 47;
		label_83.Text = "ว\u0e34นาท\u0e35";
		label_84.AutoSize = true;
		label_84.BackColor = Color.FromArgb(128, 255, 255);
		label_84.Location = new Point(15, 300);
		label_84.Name = "label78";
		label_84.Size = new Size(91, 13);
		label_84.TabIndex = 48;
		label_84.Text = "Delay ก\u0e48อน เด\u0e49งฟ\u0e49า";
		comboBox_18.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_18.DropDownWidth = 200;
		comboBox_18.FormattingEnabled = true;
		comboBox_18.Items.AddRange(new object[2] { "หย\u0e38ดการทำงาน", "ด\u0e35เลย\u0e4cตามเวลา และเด\u0e49งฟ\u0e49า ทำงานต\u0e48อ" });
		comboBox_18.Location = new Point(17, 181);
		comboBox_18.Name = "comboBox3";
		comboBox_18.Size = new Size(125, 21);
		comboBox_18.TabIndex = 38;
		button_59.Location = new Point(7, 339);
		button_59.Name = "button36";
		button_59.Size = new Size(75, 23);
		button_59.TabIndex = 37;
		button_59.Text = "Test";
		button_59.UseVisualStyleBackColor = true;
		button_59.Visible = false;
		button_59.Click += button_59_Click;
		label_80.AutoSize = true;
		label_80.Location = new Point(144, 57);
		label_80.Name = "label72";
		label_80.Size = new Size(25, 13);
		label_80.TabIndex = 36;
		label_80.Text = "ช\u0e48อง";
		textBox_57.BackColor = Color.FromArgb(255, 192, 128);
		textBox_57.Enabled = false;
		textBox_57.Location = new Point(13, 266);
		textBox_57.Name = "textBox19";
		textBox_57.Size = new Size(110, 20);
		textBox_57.TabIndex = 35;
		textBox_57.TextAlign = HorizontalAlignment.Center;
		textBox_57.TextChanged += textBox_57_TextChanged;
		textBox_34.Location = new Point(94, 54);
		textBox_34.Name = "textBox39";
		textBox_34.Size = new Size(45, 20);
		textBox_34.TabIndex = 35;
		textBox_34.Text = "24";
		textBox_34.TextAlign = HorizontalAlignment.Center;
		label_77.BackColor = Color.FromArgb(255, 255, 192);
		label_77.Location = new Point(456, 5);
		label_77.Name = "label69";
		label_77.Size = new Size(42, 23);
		label_77.TabIndex = 33;
		label_77.Text = "Result";
		label_77.TextAlign = ContentAlignment.MiddleCenter;
		button_52.Location = new Point(505, 5);
		button_52.Name = "button38";
		button_52.Size = new Size(59, 23);
		button_52.TabIndex = 32;
		button_52.Text = "ถ\u0e31ดไป";
		button_52.UseVisualStyleBackColor = true;
		button_52.Click += button_52_Click;
		button_53.Location = new Point(217, 4);
		button_53.Name = "button39";
		button_53.Size = new Size(121, 23);
		button_53.TabIndex = 31;
		button_53.Text = "โหลดรายช\u0e37\u0e48อไอเท\u0e47มท\u0e35\u0e48ม\u0e35";
		button_53.UseVisualStyleBackColor = true;
		button_53.Click += button_53_Click;
		button_54.Location = new Point(569, 4);
		button_54.Name = "button40";
		button_54.Size = new Size(59, 23);
		button_54.TabIndex = 29;
		button_54.Text = "เพ\u0e34\u0e48ม";
		button_54.UseVisualStyleBackColor = true;
		button_54.Click += button_54_Click;
		textBox_33.Location = new Point(344, 6);
		textBox_33.Name = "textBox38";
		textBox_33.Size = new Size(105, 20);
		textBox_33.TabIndex = 28;
		textBox_33.TextChanged += textBox_33_TextChanged;
		button_55.Enabled = false;
		button_55.Location = new Point(882, 138);
		button_55.Name = "button44";
		button_55.Size = new Size(25, 23);
		button_55.TabIndex = 26;
		button_55.Text = "<";
		button_55.UseVisualStyleBackColor = true;
		button_55.Click += button_55_Click;
		button_56.Location = new Point(419, 138);
		button_56.Name = "button41";
		button_56.Size = new Size(25, 23);
		button_56.TabIndex = 26;
		button_56.Text = "<";
		button_56.UseVisualStyleBackColor = true;
		button_56.Click += button_56_Click;
		button_57.Enabled = false;
		button_57.Location = new Point(882, 109);
		button_57.Name = "button43";
		button_57.Size = new Size(25, 23);
		button_57.TabIndex = 27;
		button_57.Text = ">";
		button_57.UseVisualStyleBackColor = true;
		button_57.Click += button_57_Click;
		button_58.Location = new Point(419, 109);
		button_58.Name = "button42";
		button_58.Size = new Size(25, 23);
		button_58.TabIndex = 27;
		button_58.Text = ">";
		button_58.UseVisualStyleBackColor = true;
		button_58.Click += button_58_Click;
		dataGridView_24.AllowUserToResizeColumns = false;
		dataGridView_24.AllowUserToResizeRows = false;
		dataGridView_24.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle36.BackColor = Color.White;
		dataGridViewCellStyle36.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle36.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle36.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle36.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle36.WrapMode = DataGridViewTriState.True;
		dataGridView_24.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
		dataGridView_24.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_24.Columns.AddRange(dataGridViewTextBoxColumn_62);
		dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle37.BackColor = Color.White;
		dataGridViewCellStyle37.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle37.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle37.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle37.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle37.WrapMode = DataGridViewTriState.False;
		dataGridView_24.DefaultCellStyle = dataGridViewCellStyle37;
		dataGridView_24.Enabled = false;
		dataGridView_24.Location = new Point(914, 58);
		dataGridView_24.Name = "dataGridView11";
		dataGridView_24.ReadOnly = true;
		dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle38.BackColor = Color.White;
		dataGridViewCellStyle38.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle38.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle38.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle38.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle38.WrapMode = DataGridViewTriState.True;
		dataGridView_24.RowHeadersDefaultCellStyle = dataGridViewCellStyle38;
		dataGridView_24.RowHeadersVisible = false;
		dataGridView_24.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_24.Size = new Size(187, 306);
		dataGridView_24.StandardTab = true;
		dataGridView_24.TabIndex = 25;
		dataGridViewTextBoxColumn_62.HeaderText = "ไอเท\u0e47มท\u0e35\u0e48เล\u0e34อกซ\u0e37\u0e49อ";
		dataGridViewTextBoxColumn_62.Name = "dataGridViewTextBoxColumn58";
		dataGridViewTextBoxColumn_62.ReadOnly = true;
		dataGridView_25.AllowUserToResizeColumns = false;
		dataGridView_25.AllowUserToResizeRows = false;
		dataGridView_25.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle39.BackColor = Color.White;
		dataGridViewCellStyle39.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle39.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle39.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle39.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle39.WrapMode = DataGridViewTriState.True;
		dataGridView_25.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
		dataGridView_25.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_25.Columns.AddRange(dataGridViewTextBoxColumn_63);
		dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle40.BackColor = Color.White;
		dataGridViewCellStyle40.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle40.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle40.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle40.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle40.WrapMode = DataGridViewTriState.False;
		dataGridView_25.DefaultCellStyle = dataGridViewCellStyle40;
		dataGridView_25.Location = new Point(449, 58);
		dataGridView_25.Name = "dataGridView9";
		dataGridView_25.ReadOnly = true;
		dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle41.BackColor = Color.White;
		dataGridViewCellStyle41.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle41.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle41.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle41.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle41.WrapMode = DataGridViewTriState.True;
		dataGridView_25.RowHeadersDefaultCellStyle = dataGridViewCellStyle41;
		dataGridView_25.RowHeadersVisible = false;
		dataGridView_25.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_25.Size = new Size(179, 306);
		dataGridView_25.StandardTab = true;
		dataGridView_25.TabIndex = 25;
		dataGridViewTextBoxColumn_63.HeaderText = "ไอเท\u0e47มท\u0e35\u0e48เล\u0e34อกขาย";
		dataGridViewTextBoxColumn_63.Name = "dataGridViewTextBoxColumn55";
		dataGridViewTextBoxColumn_63.ReadOnly = true;
		dataGridView_26.AllowUserToResizeColumns = false;
		dataGridView_26.AllowUserToResizeRows = false;
		dataGridViewCellStyle42.BackColor = Color.White;
		dataGridView_26.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle42;
		dataGridView_26.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle43.BackColor = Color.Gray;
		dataGridViewCellStyle43.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle43.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle43.SelectionBackColor = Color.Gray;
		dataGridViewCellStyle43.SelectionForeColor = Color.Gray;
		dataGridViewCellStyle43.WrapMode = DataGridViewTriState.True;
		dataGridView_26.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
		dataGridView_26.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_26.Columns.AddRange(dataGridViewTextBoxColumn_60);
		dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle44.BackColor = Color.White;
		dataGridViewCellStyle44.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle44.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle44.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle44.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle44.WrapMode = DataGridViewTriState.False;
		dataGridView_26.DefaultCellStyle = dataGridViewCellStyle44;
		dataGridView_26.Enabled = false;
		dataGridView_26.Location = new Point(690, 58);
		dataGridView_26.Name = "dataGridView10";
		dataGridView_26.ReadOnly = true;
		dataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle45.BackColor = Color.White;
		dataGridViewCellStyle45.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle45.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle45.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle45.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle45.WrapMode = DataGridViewTriState.True;
		dataGridView_26.RowHeadersDefaultCellStyle = dataGridViewCellStyle45;
		dataGridView_26.RowHeadersVisible = false;
		dataGridViewCellStyle46.BackColor = Color.White;
		dataGridView_26.RowsDefaultCellStyle = dataGridViewCellStyle46;
		dataGridView_26.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_26.Size = new Size(187, 306);
		dataGridView_26.StandardTab = true;
		dataGridView_26.TabIndex = 24;
		dataGridViewTextBoxColumn_60.HeaderText = "รายการไอเท\u0e47ม";
		dataGridViewTextBoxColumn_60.Name = "dataGridViewTextBoxColumn57";
		dataGridViewTextBoxColumn_60.ReadOnly = true;
		dataGridView_27.AllowUserToResizeColumns = false;
		dataGridView_27.AllowUserToResizeRows = false;
		dataGridViewCellStyle47.BackColor = Color.White;
		dataGridView_27.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle47;
		dataGridView_27.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle48.BackColor = Color.Gray;
		dataGridViewCellStyle48.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle48.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle48.SelectionBackColor = Color.Gray;
		dataGridViewCellStyle48.SelectionForeColor = Color.Gray;
		dataGridViewCellStyle48.WrapMode = DataGridViewTriState.True;
		dataGridView_27.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle48;
		dataGridView_27.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_27.Columns.AddRange(dataGridViewTextBoxColumn_61);
		dataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle49.BackColor = Color.White;
		dataGridViewCellStyle49.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle49.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle49.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle49.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle49.WrapMode = DataGridViewTriState.False;
		dataGridView_27.DefaultCellStyle = dataGridViewCellStyle49;
		dataGridView_27.Location = new Point(237, 56);
		dataGridView_27.Name = "dataGridView8";
		dataGridView_27.ReadOnly = true;
		dataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle50.BackColor = Color.White;
		dataGridViewCellStyle50.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle50.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle50.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle50.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle50.WrapMode = DataGridViewTriState.True;
		dataGridView_27.RowHeadersDefaultCellStyle = dataGridViewCellStyle50;
		dataGridView_27.RowHeadersVisible = false;
		dataGridViewCellStyle51.BackColor = Color.White;
		dataGridView_27.RowsDefaultCellStyle = dataGridViewCellStyle51;
		dataGridView_27.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_27.Size = new Size(178, 306);
		dataGridView_27.StandardTab = true;
		dataGridView_27.TabIndex = 24;
		dataGridViewTextBoxColumn_61.HeaderText = "รายการไอเท\u0e47ม";
		dataGridViewTextBoxColumn_61.Name = "dataGridViewTextBoxColumn56";
		dataGridViewTextBoxColumn_61.ReadOnly = true;
		checkBox_69.AutoSize = true;
		checkBox_69.Location = new Point(7, 56);
		checkBox_69.Name = "checkBox55";
		checkBox_69.Size = new Size(84, 17);
		checkBox_69.TabIndex = 9;
		checkBox_69.Text = "เม\u0e37\u0e48อไอเท\u0e47ม >";
		checkBox_69.UseVisualStyleBackColor = true;
		checkBox_70.AutoSize = true;
		checkBox_70.Location = new Point(7, 33);
		checkBox_70.Name = "checkBox45";
		checkBox_70.Size = new Size(99, 17);
		checkBox_70.TabIndex = 9;
		checkBox_70.Text = "หล\u0e31งจากการตาย";
		checkBox_70.UseVisualStyleBackColor = true;
		label_78.AutoSize = true;
		label_78.BackColor = Color.FromArgb(255, 128, 128);
		label_78.Enabled = false;
		label_78.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_78.Location = new Point(844, 34);
		label_78.Name = "label71";
		label_78.Size = new Size(102, 16);
		label_78.TabIndex = 8;
		label_78.Text = "## รายการซ\u0e37\u0e49อ ##";
		label_79.AutoSize = true;
		label_79.BackColor = Color.FromArgb(192, 255, 192);
		label_79.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_79.Location = new Point(263, 33);
		label_79.Name = "label70";
		label_79.Size = new Size(108, 16);
		label_79.TabIndex = 8;
		label_79.Text = "## รายการขาย ##";
		label_81.AutoSize = true;
		label_81.BackColor = Color.FromArgb(255, 192, 128);
		label_81.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_81.Location = new Point(14, 158);
		label_81.Name = "label75";
		label_81.Size = new Size(167, 16);
		label_81.TabIndex = 8;
		label_81.Text = "## หล\u0e31งจากขายส\u0e34นค\u0e49าเสร\u0e47จ ##";
		label_76.AutoSize = true;
		label_76.BackColor = Color.FromArgb(255, 128, 255);
		label_76.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_76.Location = new Point(14, 9);
		label_76.Name = "label68";
		label_76.Size = new Size(159, 16);
		label_76.TabIndex = 8;
		label_76.Text = "## ใช\u0e49งานร\u0e49านค\u0e49า ##  (VIP)";
		tabPage_8.AutoScroll = true;
		tabPage_8.AutoScrollMinSize = new Size(642, 370);
		tabPage_8.BorderStyle = BorderStyle.FixedSingle;
		tabPage_8.Controls.Add(button_46);
		tabPage_8.Controls.Add(comboBox_14);
		tabPage_8.Controls.Add(label_51);
		tabPage_8.Controls.Add(textBox_26);
		tabPage_8.Controls.Add(checkBox_59);
		tabPage_8.Controls.Add(comboBox_13);
		tabPage_8.Controls.Add(label_50);
		tabPage_8.Controls.Add(textBox_25);
		tabPage_8.Controls.Add(checkBox_58);
		tabPage_8.Controls.Add(comboBox_12);
		tabPage_8.Controls.Add(label_49);
		tabPage_8.Controls.Add(textBox_24);
		tabPage_8.Controls.Add(checkBox_57);
		tabPage_8.Controls.Add(comboBox_11);
		tabPage_8.Controls.Add(label_48);
		tabPage_8.Controls.Add(textBox_23);
		tabPage_8.Controls.Add(checkBox_56);
		tabPage_8.Controls.Add(comboBox_10);
		tabPage_8.Controls.Add(label_47);
		tabPage_8.Controls.Add(textBox_22);
		tabPage_8.Controls.Add(checkBox_55);
		tabPage_8.Controls.Add(comboBox_9);
		tabPage_8.Controls.Add(label_46);
		tabPage_8.Controls.Add(button_48);
		tabPage_8.Controls.Add(comboBox_15);
		tabPage_8.Controls.Add(textBox_27);
		tabPage_8.Controls.Add(label_53);
		tabPage_8.Controls.Add(label_52);
		tabPage_8.Controls.Add(button_49);
		tabPage_8.Controls.Add(comboBox_17);
		tabPage_8.Controls.Add(label_54);
		tabPage_8.Controls.Add(textBox_28);
		tabPage_8.Controls.Add(label_55);
		tabPage_8.Controls.Add(label_56);
		tabPage_8.Controls.Add(comboBox_16);
		tabPage_8.Controls.Add(textBox_29);
		tabPage_8.Controls.Add(textBox_21);
		tabPage_8.Controls.Add(button_47);
		tabPage_8.Controls.Add(button_50);
		tabPage_8.Controls.Add(dataGridView_21);
		tabPage_8.Controls.Add(checkBox_54);
		tabPage_8.Controls.Add(label_57);
		tabPage_8.Controls.Add(label_58);
		tabPage_8.Controls.Add(label_59);
		tabPage_8.Controls.Add(label_65);
		tabPage_8.Controls.Add(label_64);
		tabPage_8.Controls.Add(label_63);
		tabPage_8.Controls.Add(label_62);
		tabPage_8.Controls.Add(label_61);
		tabPage_8.Controls.Add(label_60);
		tabPage_8.Location = new Point(4, 49);
		tabPage_8.Name = "tabPage17";
		tabPage_8.Size = new Size(638, 370);
		tabPage_8.TabIndex = 18;
		tabPage_8.Text = "  Buy";
		tabPage_8.UseVisualStyleBackColor = true;
		button_46.Location = new Point(170, 212);
		button_46.Name = "buttonBuySyncSell";
		button_46.Size = new Size(63, 23);
		button_46.TabIndex = 124;
		button_46.Text = "Sync Sell";
		button_46.UseVisualStyleBackColor = true;
		comboBox_14.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_14.FormattingEnabled = true;
		comboBox_14.Location = new Point(30, 164);
		comboBox_14.Name = "comboBox606";
		comboBox_14.Size = new Size(100, 21);
		comboBox_14.TabIndex = 123;
		label_51.AutoSize = true;
		label_51.Location = new Point(133, 168);
		label_51.Name = "labelBuyCondition6Operator";
		label_51.Size = new Size(13, 13);
		label_51.TabIndex = 122;
		label_51.Text = "<";
		textBox_26.Location = new Point(149, 165);
		textBox_26.Name = "textBox606";
		textBox_26.Size = new Size(45, 20);
		textBox_26.TabIndex = 120;
		textBox_26.Text = "10";
		textBox_26.TextAlign = HorizontalAlignment.Center;
		checkBox_59.AutoSize = true;
		checkBox_59.Location = new Point(8, 167);
		checkBox_59.Name = "checkBox606";
		checkBox_59.Size = new Size(15, 14);
		checkBox_59.TabIndex = 119;
		checkBox_59.UseVisualStyleBackColor = true;
		comboBox_13.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_13.FormattingEnabled = true;
		comboBox_13.Location = new Point(31, 138);
		comboBox_13.Name = "comboBox605";
		comboBox_13.Size = new Size(100, 21);
		comboBox_13.TabIndex = 118;
		label_50.AutoSize = true;
		label_50.Location = new Point(134, 142);
		label_50.Name = "labelBuyCondition5Operator";
		label_50.Size = new Size(13, 13);
		label_50.TabIndex = 117;
		label_50.Text = "<";
		textBox_25.Location = new Point(150, 139);
		textBox_25.Name = "textBox605";
		textBox_25.Size = new Size(45, 20);
		textBox_25.TabIndex = 115;
		textBox_25.Text = "10";
		textBox_25.TextAlign = HorizontalAlignment.Center;
		checkBox_58.AutoSize = true;
		checkBox_58.Location = new Point(9, 141);
		checkBox_58.Name = "checkBox605";
		checkBox_58.Size = new Size(15, 14);
		checkBox_58.TabIndex = 114;
		checkBox_58.UseVisualStyleBackColor = true;
		comboBox_12.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_12.FormattingEnabled = true;
		comboBox_12.Location = new Point(31, 111);
		comboBox_12.Name = "comboBox604";
		comboBox_12.Size = new Size(100, 21);
		comboBox_12.TabIndex = 113;
		label_49.AutoSize = true;
		label_49.Location = new Point(134, 115);
		label_49.Name = "labelBuyCondition4Operator";
		label_49.Size = new Size(13, 13);
		label_49.TabIndex = 112;
		label_49.Text = "<";
		textBox_24.Location = new Point(150, 112);
		textBox_24.Name = "textBox604";
		textBox_24.Size = new Size(45, 20);
		textBox_24.TabIndex = 110;
		textBox_24.Text = "10";
		textBox_24.TextAlign = HorizontalAlignment.Center;
		checkBox_57.AutoSize = true;
		checkBox_57.Location = new Point(9, 114);
		checkBox_57.Name = "checkBox604";
		checkBox_57.Size = new Size(15, 14);
		checkBox_57.TabIndex = 109;
		checkBox_57.UseVisualStyleBackColor = true;
		comboBox_11.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_11.FormattingEnabled = true;
		comboBox_11.Location = new Point(30, 84);
		comboBox_11.Name = "comboBox603";
		comboBox_11.Size = new Size(100, 21);
		comboBox_11.TabIndex = 108;
		label_48.AutoSize = true;
		label_48.Location = new Point(133, 88);
		label_48.Name = "labelBuyCondition3Operator";
		label_48.Size = new Size(13, 13);
		label_48.TabIndex = 107;
		label_48.Text = "<";
		textBox_23.Location = new Point(149, 85);
		textBox_23.Name = "textBox603";
		textBox_23.Size = new Size(45, 20);
		textBox_23.TabIndex = 105;
		textBox_23.Text = "10";
		textBox_23.TextAlign = HorizontalAlignment.Center;
		checkBox_56.AutoSize = true;
		checkBox_56.Location = new Point(8, 87);
		checkBox_56.Name = "checkBox603";
		checkBox_56.Size = new Size(15, 14);
		checkBox_56.TabIndex = 104;
		checkBox_56.UseVisualStyleBackColor = true;
		comboBox_10.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_10.FormattingEnabled = true;
		comboBox_10.Location = new Point(30, 57);
		comboBox_10.Name = "comboBox602";
		comboBox_10.Size = new Size(100, 21);
		comboBox_10.TabIndex = 103;
		label_47.AutoSize = true;
		label_47.Location = new Point(133, 61);
		label_47.Name = "labelBuyCondition2Operator";
		label_47.Size = new Size(13, 13);
		label_47.TabIndex = 102;
		label_47.Text = "<";
		textBox_22.Location = new Point(149, 58);
		textBox_22.Name = "textBox602";
		textBox_22.Size = new Size(45, 20);
		textBox_22.TabIndex = 100;
		textBox_22.Text = "10";
		textBox_22.TextAlign = HorizontalAlignment.Center;
		checkBox_55.AutoSize = true;
		checkBox_55.Location = new Point(8, 60);
		checkBox_55.Name = "checkBox602";
		checkBox_55.Size = new Size(15, 14);
		checkBox_55.TabIndex = 99;
		checkBox_55.UseVisualStyleBackColor = true;
		comboBox_9.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_9.FormattingEnabled = true;
		comboBox_9.Location = new Point(30, 30);
		comboBox_9.Name = "comboBox601";
		comboBox_9.Size = new Size(100, 21);
		comboBox_9.TabIndex = 98;
		label_46.AutoSize = true;
		label_46.Location = new Point(133, 34);
		label_46.Name = "labelBuyCondition1Operator";
		label_46.Size = new Size(13, 13);
		label_46.TabIndex = 97;
		label_46.Text = "<";
		button_48.Location = new Point(133, 292);
		button_48.Name = "buttonBuySetNpcPosition";
		button_48.Size = new Size(99, 23);
		button_48.TabIndex = 96;
		button_48.Text = "Set ตำแหน\u0e48ง NPC";
		button_48.UseVisualStyleBackColor = true;
		comboBox_15.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_15.FormattingEnabled = true;
		comboBox_15.Items.AddRange(new object[7] { "1", "2", "3", "4", "5", "6", "7" });
		comboBox_15.Location = new Point(159, 266);
		comboBox_15.Name = "comboBox19";
		comboBox_15.Size = new Size(48, 21);
		comboBox_15.TabIndex = 95;
		textBox_27.Location = new Point(8, 267);
		textBox_27.Name = "textBoxBuyNpcName";
		textBox_27.Size = new Size(133, 20);
		textBox_27.TabIndex = 94;
		label_53.AutoSize = true;
		label_53.BackColor = Color.FromArgb(255, 192, 128);
		label_53.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_53.Location = new Point(157, 243);
		label_53.Name = "labelBuyNpcIndex";
		label_53.Size = new Size(60, 16);
		label_53.TabIndex = 92;
		label_53.Text = "# ลำด\u0e31บ #";
		label_52.AutoSize = true;
		label_52.BackColor = Color.FromArgb(255, 192, 128);
		label_52.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_52.Location = new Point(15, 243);
		label_52.Name = "labelBuyNpcName";
		label_52.Size = new Size(123, 16);
		label_52.TabIndex = 93;
		label_52.Text = "##  ระบ\u0e38ช\u0e37\u0e48อ NPC ##";
		button_49.Location = new Point(433, 30);
		button_49.Name = "buttonBuyLoadProfile";
		button_49.Size = new Size(75, 23);
		button_49.TabIndex = 91;
		button_49.Text = "โหลด";
		button_49.UseVisualStyleBackColor = true;
		comboBox_17.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_17.FormattingEnabled = true;
		comboBox_17.Location = new Point(267, 30);
		comboBox_17.Name = "comboBox20";
		comboBox_17.Size = new Size(145, 21);
		comboBox_17.TabIndex = 90;
		label_54.AutoSize = true;
		label_54.BackColor = Color.FromArgb(255, 255, 128);
		label_54.Location = new Point(100, 350);
		label_54.Name = "label128";
		label_54.Size = new Size(107, 13);
		label_54.TabIndex = 89;
		label_54.Text = "อ\u0e35ก ..... ว\u0e34นาท\u0e35 เด\u0e49งกล\u0e31บ";
		textBox_28.Location = new Point(117, 324);
		textBox_28.Name = "textBoxBuyReturnDelay";
		textBox_28.Size = new Size(48, 20);
		textBox_28.TabIndex = 86;
		textBox_28.Text = "5";
		textBox_28.TextAlign = HorizontalAlignment.Center;
		label_55.AutoSize = true;
		label_55.BackColor = Color.FromArgb(128, 255, 255);
		label_55.Location = new Point(174, 327);
		label_55.Name = "label129";
		label_55.Size = new Size(33, 13);
		label_55.TabIndex = 84;
		label_55.Text = "ว\u0e34นาท\u0e35";
		label_56.AutoSize = true;
		label_56.BackColor = Color.FromArgb(128, 255, 255);
		label_56.Location = new Point(16, 328);
		label_56.Name = "label130";
		label_56.Size = new Size(91, 13);
		label_56.TabIndex = 85;
		label_56.Text = "Delay ก\u0e48อน เด\u0e49งฟ\u0e49า";
		comboBox_16.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_16.DropDownWidth = 200;
		comboBox_16.FormattingEnabled = true;
		comboBox_16.Items.AddRange(new object[2] { "หย\u0e38ดการทำงาน", "ด\u0e35เลย\u0e4cตามเวลา และเด\u0e49งฟ\u0e49า ทำงานต\u0e48อ" });
		comboBox_16.Location = new Point(8, 213);
		comboBox_16.Name = "comboBox21";
		comboBox_16.Size = new Size(157, 21);
		comboBox_16.TabIndex = 83;
		textBox_29.BackColor = Color.FromArgb(255, 192, 128);
		textBox_29.Enabled = false;
		textBox_29.Location = new Point(14, 293);
		textBox_29.Name = "textBoxBuyNpcPosition";
		textBox_29.Size = new Size(110, 20);
		textBox_29.TabIndex = 78;
		textBox_29.TextAlign = HorizontalAlignment.Center;
		textBox_21.Location = new Point(149, 31);
		textBox_21.Name = "textBox601";
		textBox_21.Size = new Size(45, 20);
		textBox_21.TabIndex = 77;
		textBox_21.Text = "10";
		textBox_21.TextAlign = HorizontalAlignment.Center;
		button_47.Location = new Point(353, 3);
		button_47.Name = "buttonBuyOpenShop";
		button_47.Size = new Size(131, 23);
		button_47.TabIndex = 73;
		button_47.Text = "เป\u0e34ดร\u0e49านค\u0e49า";
		button_47.UseVisualStyleBackColor = true;
		button_50.Location = new Point(523, 14);
		button_50.Name = "button85";
		button_50.Size = new Size(89, 33);
		button_50.TabIndex = 70;
		button_50.Text = "เอาไอเท\u0e47มออก";
		button_50.UseVisualStyleBackColor = true;
		dataGridView_21.AllowUserToAddRows = false;
		dataGridView_21.AllowUserToDeleteRows = false;
		dataGridView_21.AllowUserToResizeColumns = false;
		dataGridView_21.AllowUserToResizeRows = false;
		dataGridView_21.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridViewCellStyle52.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle52.BackColor = SystemColors.Control;
		dataGridViewCellStyle52.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle52.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle52.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle52.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle52.WrapMode = DataGridViewTriState.True;
		dataGridView_21.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
		dataGridView_21.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_21.Columns.AddRange(dataGridViewCheckBoxColumn_0, dataGridViewTextBoxColumn_52, dataGridViewTextBoxColumn_53, dataGridViewTextBoxColumn_54, dataGridViewTextBoxColumn_55, dataGridViewTextBoxColumn_56);
		dataGridViewCellStyle53.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle53.BackColor = Color.White;
		dataGridViewCellStyle53.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle53.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle53.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle53.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle53.WrapMode = DataGridViewTriState.False;
		dataGridView_21.DefaultCellStyle = dataGridViewCellStyle53;
		dataGridView_21.EditMode = DataGridViewEditMode.EditOnEnter;
		dataGridView_21.Location = new Point(240, 79);
		dataGridView_21.Name = "dataGridView14";
		dataGridViewCellStyle54.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle54.BackColor = Color.White;
		dataGridViewCellStyle54.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
		dataGridViewCellStyle54.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle54.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle54.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle54.WrapMode = DataGridViewTriState.True;
		dataGridView_21.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
		dataGridView_21.RowHeadersVisible = false;
		dataGridView_21.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_21.Size = new Size(393, 285);
		dataGridView_21.StandardTab = true;
		dataGridView_21.TabIndex = 68;
		dataGridViewCheckBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewCheckBoxColumn_0.HeaderText = "Enabled";
		dataGridViewCheckBoxColumn_0.Name = "ColumnBuyEnabled";
		dataGridViewCheckBoxColumn_0.Width = 55;
		dataGridViewTextBoxColumn_52.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_52.FillWeight = 90f;
		dataGridViewTextBoxColumn_52.HeaderText = "NPC";
		dataGridViewTextBoxColumn_52.Name = "ColumnBuyNpc";
		dataGridViewTextBoxColumn_52.ReadOnly = true;
		dataGridViewTextBoxColumn_53.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn_53.FillWeight = 120f;
		dataGridViewTextBoxColumn_53.HeaderText = "ItemName";
		dataGridViewTextBoxColumn_53.Name = "dataGridViewTextBoxColumn60";
		dataGridViewTextBoxColumn_53.ReadOnly = true;
		dataGridViewTextBoxColumn_54.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewTextBoxColumn_54.HeaderText = "Price";
		dataGridViewTextBoxColumn_54.Name = "Column8";
		dataGridViewTextBoxColumn_54.ReadOnly = true;
		dataGridViewTextBoxColumn_54.Width = 65;
		dataGridViewTextBoxColumn_55.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewTextBoxColumn_55.HeaderText = "Qty";
		dataGridViewTextBoxColumn_55.Name = "Column3";
		dataGridViewTextBoxColumn_55.Width = 45;
		dataGridViewTextBoxColumn_56.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewTextBoxColumn_56.HeaderText = "Total";
		dataGridViewTextBoxColumn_56.Name = "Column9";
		dataGridViewTextBoxColumn_56.ReadOnly = true;
		dataGridViewTextBoxColumn_56.Width = 70;
		checkBox_54.AutoSize = true;
		checkBox_54.Location = new Point(8, 33);
		checkBox_54.Name = "checkBox601";
		checkBox_54.Size = new Size(15, 14);
		checkBox_54.TabIndex = 64;
		checkBox_54.UseVisualStyleBackColor = true;
		label_57.AutoSize = true;
		label_57.BackColor = Color.FromArgb(192, 255, 192);
		label_57.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_57.Location = new Point(398, 57);
		label_57.Name = "label135";
		label_57.Size = new Size(102, 16);
		label_57.TabIndex = 62;
		label_57.Text = "## รายการซ\u0e37\u0e49อ ##";
		label_58.AutoSize = true;
		label_58.BackColor = Color.FromArgb(255, 192, 128);
		label_58.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_58.Location = new Point(15, 190);
		label_58.Name = "label136";
		label_58.Size = new Size(161, 16);
		label_58.TabIndex = 61;
		label_58.Text = "## หล\u0e31งจากซ\u0e37\u0e49อส\u0e34นค\u0e49าเสร\u0e47จ ##";
		label_59.AutoSize = true;
		label_59.BackColor = Color.FromArgb(255, 128, 255);
		label_59.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_59.Location = new Point(15, 9);
		label_59.Name = "label137";
		label_59.Size = new Size(200, 16);
		label_59.TabIndex = 60;
		label_59.Text = "## ใช\u0e49งานร\u0e49านค\u0e49า ซ\u0e37\u0e49อของ ##  (VIP)";
		label_65.AutoSize = true;
		label_65.Location = new Point(191, 169);
		label_65.Name = "label606";
		label_65.Size = new Size(21, 13);
		label_65.TabIndex = 121;
		label_65.Text = " / -";
		label_64.AutoSize = true;
		label_64.Location = new Point(192, 143);
		label_64.Name = "label605";
		label_64.Size = new Size(21, 13);
		label_64.TabIndex = 116;
		label_64.Text = " / -";
		label_63.AutoSize = true;
		label_63.Location = new Point(192, 116);
		label_63.Name = "label604";
		label_63.Size = new Size(21, 13);
		label_63.TabIndex = 111;
		label_63.Text = " / -";
		label_62.AutoSize = true;
		label_62.Location = new Point(191, 89);
		label_62.Name = "label603";
		label_62.Size = new Size(21, 13);
		label_62.TabIndex = 106;
		label_62.Text = " / -";
		label_61.AutoSize = true;
		label_61.Location = new Point(191, 62);
		label_61.Name = "label602";
		label_61.Size = new Size(21, 13);
		label_61.TabIndex = 101;
		label_61.Text = " / -";
		label_60.AutoSize = true;
		label_60.Location = new Point(191, 35);
		label_60.Name = "label601";
		label_60.Size = new Size(21, 13);
		label_60.TabIndex = 80;
		label_60.Text = " / -";
		tabPage_9.BorderStyle = BorderStyle.FixedSingle;
		tabPage_9.Controls.Add(checkBox_88);
		tabPage_9.Controls.Add(checkBox_85);
		tabPage_9.Controls.Add(checkBox_78);
		tabPage_9.Controls.Add(checkBox_76);
		tabPage_9.Controls.Add(checkBox_66);
		tabPage_9.Controls.Add(checkBox_67);
		tabPage_9.Controls.Add(checkBox_74);
		tabPage_9.Controls.Add(checkBox_64);
		tabPage_9.Controls.Add(checkBox_63);
		tabPage_9.Controls.Add(textBox_40);
		tabPage_9.Controls.Add(textBox_41);
		tabPage_9.Controls.Add(textBox_31);
		tabPage_9.Controls.Add(checkBox_61);
		tabPage_9.Controls.Add(checkBox_62);
		tabPage_9.Controls.Add(label_93);
		tabPage_9.Controls.Add(label_94);
		tabPage_9.Controls.Add(label_95);
		tabPage_9.Controls.Add(label_96);
		tabPage_9.Controls.Add(label_68);
		tabPage_9.Controls.Add(label_67);
		tabPage_9.Controls.Add(label_66);
		tabPage_9.Controls.Add(checkBox_60);
		tabPage_9.Controls.Add(textBox_30);
		tabPage_9.Controls.Add(groupBox_2);
		tabPage_9.Location = new Point(4, 49);
		tabPage_9.Name = "tabPage9";
		tabPage_9.Size = new Size(638, 370);
		tabPage_9.TabIndex = 10;
		tabPage_9.Text = "DisCord-Notify";
		tabPage_9.UseVisualStyleBackColor = true;
		checkBox_88.AutoSize = true;
		checkBox_88.Location = new Point(219, 188);
		checkBox_88.Name = "checkBox35";
		checkBox_88.Size = new Size(100, 17);
		checkBox_88.TabIndex = 11;
		checkBox_88.Text = "ขาดการเช\u0e37\u0e48อมต\u0e48อ";
		checkBox_88.UseVisualStyleBackColor = true;
		checkBox_85.AutoSize = true;
		checkBox_85.Location = new Point(160, 165);
		checkBox_85.Name = "checkBox85";
		checkBox_85.Size = new Size(110, 17);
		checkBox_85.TabIndex = 11;
		checkBox_85.Text = "แจ\u0e49งเต\u0e37อนแชทขาว";
		checkBox_85.UseVisualStyleBackColor = true;
		checkBox_78.AutoSize = true;
		checkBox_78.Location = new Point(7, 165);
		checkBox_78.Name = "checkBox62";
		checkBox_78.Size = new Size(143, 17);
		checkBox_78.TabIndex = 10;
		checkBox_78.Text = "แจ\u0e49งเต\u0e37อนเม\u0e37\u0e48อม\u0e35คนกระซ\u0e34บ";
		checkBox_78.UseVisualStyleBackColor = true;
		checkBox_76.AutoSize = true;
		checkBox_76.Location = new Point(7, 143);
		checkBox_76.Name = "checkBox80";
		checkBox_76.Size = new Size(247, 17);
		checkBox_76.TabIndex = 9;
		checkBox_76.Text = "แจ\u0e49งเต\u0e37อนเม\u0e37\u0e48อหย\u0e38ดหร\u0e37อเร\u0e34\u0e48มทำงานจากการต\u0e31\u0e49งเวลา";
		checkBox_76.UseVisualStyleBackColor = true;
		checkBox_66.AutoSize = true;
		checkBox_66.Location = new Point(7, 212);
		checkBox_66.Name = "checkBox66";
		checkBox_66.Size = new Size(244, 17);
		checkBox_66.TabIndex = 6;
		checkBox_66.Text = "แจ\u0e49งเต\u0e37อนยกเล\u0e34กใช\u0e49งานส\u0e31ตว\u0e4cเล\u0e35\u0e49ยงเม\u0e37\u0e48ออาหารหมด";
		checkBox_66.UseVisualStyleBackColor = true;
		checkBox_67.AutoSize = true;
		checkBox_67.Location = new Point(7, 189);
		checkBox_67.Name = "checkBox65";
		checkBox_67.Size = new Size(206, 17);
		checkBox_67.TabIndex = 6;
		checkBox_67.Text = "แจ\u0e49งเต\u0e37อนอาหารกระป\u0e4bองหมด ท\u0e38ก 5 นาท\u0e35";
		checkBox_67.UseVisualStyleBackColor = true;
		checkBox_74.AutoSize = true;
		checkBox_74.Location = new Point(152, 122);
		checkBox_74.Name = "checkBox78";
		checkBox_74.Size = new Size(155, 17);
		checkBox_74.TabIndex = 6;
		checkBox_74.Text = "แจ\u0e49งเต\u0e37อนเม\u0e37\u0e48อเด\u0e49งขายไอเท\u0e47ม";
		checkBox_74.UseVisualStyleBackColor = true;
		checkBox_64.AutoSize = true;
		checkBox_64.Location = new Point(7, 121);
		checkBox_64.Name = "checkBox59";
		checkBox_64.Size = new Size(145, 17);
		checkBox_64.TabIndex = 6;
		checkBox_64.Text = "แจ\u0e49งเต\u0e37อนเม\u0e37\u0e48อต\u0e31วละครตาย";
		checkBox_64.UseVisualStyleBackColor = true;
		checkBox_63.AutoSize = true;
		checkBox_63.Location = new Point(7, 98);
		checkBox_63.Name = "checkBox58";
		checkBox_63.Size = new Size(146, 17);
		checkBox_63.TabIndex = 6;
		checkBox_63.Text = "แจ\u0e49งเต\u0e37อนเม\u0e37\u0e48อ Alert ทำงาน";
		checkBox_63.UseVisualStyleBackColor = true;
		textBox_40.Location = new Point(152, 96);
		textBox_40.Name = "textBox47";
		textBox_40.Size = new Size(44, 20);
		textBox_40.TabIndex = 5;
		textBox_40.Text = "30";
		textBox_40.TextAlign = HorizontalAlignment.Center;
		textBox_41.Location = new Point(130, 72);
		textBox_41.Name = "textBox1";
		textBox_41.Size = new Size(44, 20);
		textBox_41.TabIndex = 5;
		textBox_41.Text = "30";
		textBox_41.TextAlign = HorizontalAlignment.Center;
		textBox_31.Location = new Point(107, 50);
		textBox_31.Name = "textBox37";
		textBox_31.Size = new Size(44, 20);
		textBox_31.TabIndex = 5;
		textBox_31.Text = "30";
		textBox_31.TextAlign = HorizontalAlignment.Center;
		checkBox_61.AutoSize = true;
		checkBox_61.Location = new Point(7, 75);
		checkBox_61.Name = "checkBox57";
		checkBox_61.Size = new Size(124, 17);
		checkBox_61.TabIndex = 4;
		checkBox_61.Text = "แจ\u0e49งเต\u0e37อนเม\u0e37\u0e48อพบ GM";
		checkBox_61.UseVisualStyleBackColor = true;
		checkBox_62.AutoSize = true;
		checkBox_62.Location = new Point(7, 51);
		checkBox_62.Name = "checkBox56";
		checkBox_62.Size = new Size(97, 17);
		checkBox_62.TabIndex = 3;
		checkBox_62.Text = "แจ\u0e49งเต\u0e37อนท\u0e38ก ๆ ";
		checkBox_62.UseVisualStyleBackColor = true;
		label_93.AutoSize = true;
		label_93.BackColor = Color.FromArgb(128, 255, 128);
		label_93.Location = new Point(234, 100);
		label_93.Name = "label88";
		label_93.Size = new Size(61, 13);
		label_93.TabIndex = 2;
		label_93.Text = "อ\u0e35ก .. ว\u0e34นาท\u0e35 ";
		label_93.Visible = false;
		label_94.AutoSize = true;
		label_94.Location = new Point(196, 100);
		label_94.Name = "label87";
		label_94.Size = new Size(33, 13);
		label_94.TabIndex = 2;
		label_94.Text = "ว\u0e34นาท\u0e35";
		label_95.AutoSize = true;
		label_95.BackColor = Color.FromArgb(128, 255, 128);
		label_95.Location = new Point(217, 75);
		label_95.Name = "label86";
		label_95.Size = new Size(61, 13);
		label_95.TabIndex = 2;
		label_95.Text = "อ\u0e35ก .. ว\u0e34นาท\u0e35 ";
		label_96.AutoSize = true;
		label_96.Location = new Point(180, 75);
		label_96.Name = "label2";
		label_96.Size = new Size(33, 13);
		label_96.TabIndex = 2;
		label_96.Text = "ว\u0e34นาท\u0e35";
		label_68.AutoSize = true;
		label_68.BackColor = Color.FromArgb(128, 255, 128);
		label_68.Location = new Point(194, 53);
		label_68.Name = "label63";
		label_68.Size = new Size(61, 13);
		label_68.TabIndex = 2;
		label_68.Text = "อ\u0e35ก .. ว\u0e34นาท\u0e35 ";
		label_67.AutoSize = true;
		label_67.Location = new Point(161, 53);
		label_67.Name = "label62";
		label_67.Size = new Size(27, 13);
		label_67.TabIndex = 2;
		label_67.Text = "นาท\u0e35";
		label_66.AutoSize = true;
		label_66.BackColor = Color.FromArgb(255, 192, 192);
		label_66.ForeColor = Color.Black;
		label_66.Location = new Point(161, 6);
		label_66.Name = "label61";
		label_66.Size = new Size(69, 13);
		label_66.TabIndex = 2;
		label_66.Text = "WebHookUrl";
		checkBox_60.AutoSize = true;
		checkBox_60.Location = new Point(8, 5);
		checkBox_60.Name = "checkBox53";
		checkBox_60.Size = new Size(150, 17);
		checkBox_60.TabIndex = 1;
		checkBox_60.Text = "ใช\u0e49งาน Discord - แจ\u0e49งเต\u0e37อน";
		checkBox_60.UseVisualStyleBackColor = true;
		textBox_30.Location = new Point(8, 23);
		textBox_30.Name = "textBox36";
		textBox_30.Size = new Size(283, 20);
		textBox_30.TabIndex = 0;
		textBox_30.Text = "เอา webhook server ใส\u0e48ตรงน\u0e35\u0e49";
		groupBox_2.Controls.Add(radioButton_23);
		groupBox_2.Controls.Add(radioButton_24);
		groupBox_2.Controls.Add(button_51);
		groupBox_2.Location = new Point(15, 258);
		groupBox_2.Name = "groupBox5";
		groupBox_2.Size = new Size(280, 73);
		groupBox_2.TabIndex = 8;
		groupBox_2.TabStop = false;
		groupBox_2.Text = "ร\u0e39ปแบบการแจ\u0e49งเต\u0e37อน";
		radioButton_23.AutoSize = true;
		radioButton_23.Location = new Point(7, 43);
		radioButton_23.Name = "radioButton13";
		radioButton_23.Size = new Size(137, 17);
		radioButton_23.TabIndex = 0;
		radioButton_23.Text = "ส\u0e48งท\u0e31\u0e49งร\u0e39ปภาพและข\u0e49อความ";
		radioButton_23.UseVisualStyleBackColor = true;
		radioButton_24.AutoSize = true;
		radioButton_24.Checked = true;
		radioButton_24.Location = new Point(7, 20);
		radioButton_24.Name = "radioButton12";
		radioButton_24.Size = new Size(104, 17);
		radioButton_24.TabIndex = 0;
		radioButton_24.TabStop = true;
		radioButton_24.Text = "ส\u0e48งเฉพาะข\u0e49อความ";
		radioButton_24.UseVisualStyleBackColor = true;
		button_51.Location = new Point(154, 20);
		button_51.Name = "button35";
		button_51.Size = new Size(120, 23);
		button_51.TabIndex = 7;
		button_51.Text = "กดทดสอบส\u0e48งแจ\u0e49งเต\u0e37อน";
		button_51.UseVisualStyleBackColor = true;
		button_51.Click += button_51_Click;
		tabPage_11.BorderStyle = BorderStyle.FixedSingle;
		tabPage_11.Controls.Add(pictureBox_2);
		tabPage_11.Controls.Add(pictureBox_0);
		tabPage_11.Controls.Add(pictureBox_1);
		tabPage_11.Controls.Add(label_73);
		tabPage_11.Location = new Point(4, 49);
		tabPage_11.Name = "tabPage11";
		tabPage_11.Size = new Size(638, 370);
		tabPage_11.TabIndex = 12;
		tabPage_11.Text = "AboutMe";
		tabPage_11.UseVisualStyleBackColor = true;
		pictureBox_2.BorderStyle = BorderStyle.FixedSingle;
		pictureBox_2.Location = new Point(112, 59);
		pictureBox_2.Name = "pictureBox5";
		pictureBox_2.Size = new Size(198, 231);
		pictureBox_2.TabIndex = 2;
		pictureBox_2.TabStop = false;
		pictureBox_0.BorderStyle = BorderStyle.FixedSingle;
		pictureBox_0.Location = new Point(6, 182);
		pictureBox_0.Name = "pictureBox2";
		pictureBox_0.Size = new Size(100, 100);
		pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
		pictureBox_0.TabIndex = 1;
		pictureBox_0.TabStop = false;
		pictureBox_1.BorderStyle = BorderStyle.FixedSingle;
		pictureBox_1.Location = new Point(6, 69);
		pictureBox_1.Name = "pictureBox1";
		pictureBox_1.Size = new Size(100, 100);
		pictureBox_1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox_1.TabIndex = 1;
		pictureBox_1.TabStop = false;
		label_73.AutoSize = true;
		label_73.BackColor = Color.FromArgb(128, 255, 128);
		label_73.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_73.ForeColor = Color.Black;
		label_73.Location = new Point(96, 17);
		label_73.Name = "label66";
		label_73.Size = new Size(115, 20);
		label_73.TabIndex = 0;
		label_73.Text = "ช\u0e48องทางการต\u0e34ดต\u0e48อ";
		tabPage_13.BorderStyle = BorderStyle.FixedSingle;
		tabPage_13.Controls.Add(label_102);
		tabPage_13.Controls.Add(checkBox_77);
		tabPage_13.Controls.Add(checkBox_75);
		tabPage_13.Controls.Add(label_100);
		tabPage_13.Controls.Add(label_99);
		tabPage_13.Controls.Add(textBox_43);
		tabPage_13.Controls.Add(textBox_42);
		tabPage_13.Controls.Add(label_103);
		tabPage_13.Controls.Add(label_98);
		tabPage_13.Controls.Add(comboBox_20);
		tabPage_13.Controls.Add(comboBox_19);
		tabPage_13.Controls.Add(dateTimePicker_5);
		tabPage_13.Controls.Add(label_101);
		tabPage_13.Controls.Add(label_97);
		tabPage_13.Controls.Add(dateTimePicker_4);
		tabPage_13.Controls.Add(groupBox_3);
		tabPage_13.Controls.Add(groupBox_4);
		tabPage_13.Location = new Point(4, 49);
		tabPage_13.Name = "tabPage13";
		tabPage_13.Size = new Size(638, 370);
		tabPage_13.TabIndex = 14;
		tabPage_13.Text = "หย\u0e38ด - เร\u0e34\u0e48ม";
		tabPage_13.UseVisualStyleBackColor = true;
		label_102.AutoSize = true;
		label_102.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_102.Location = new Point(-39, 160);
		label_102.Name = "label94";
		label_102.Size = new Size(667, 16);
		label_102.TabIndex = 56;
		label_102.Text = "**************************************************************************************************************";
		checkBox_77.AutoSize = true;
		checkBox_77.Location = new Point(7, 184);
		checkBox_77.Name = "checkBox81";
		checkBox_77.Size = new Size(139, 17);
		checkBox_77.TabIndex = 55;
		checkBox_77.Text = "ใช\u0e49งานต\u0e31\u0e49งเวลาเร\u0e34\u0e48มทำงาน";
		checkBox_77.UseVisualStyleBackColor = true;
		checkBox_75.AutoSize = true;
		checkBox_75.Location = new Point(7, 7);
		checkBox_75.Name = "checkBox79";
		checkBox_75.Size = new Size(142, 17);
		checkBox_75.TabIndex = 55;
		checkBox_75.Text = "ใช\u0e49งานต\u0e31\u0e49งเวลาหย\u0e38ดทำงาน";
		checkBox_75.UseVisualStyleBackColor = true;
		label_100.AutoSize = true;
		label_100.Location = new Point(162, 234);
		label_100.Name = "label92";
		label_100.Size = new Size(37, 13);
		label_100.TabIndex = 54;
		label_100.Text = "ช\u0e31\u0e48วโมง";
		label_99.AutoSize = true;
		label_99.Location = new Point(162, 57);
		label_99.Name = "label91";
		label_99.Size = new Size(37, 13);
		label_99.TabIndex = 54;
		label_99.Text = "ช\u0e31\u0e48วโมง";
		textBox_43.Location = new Point(115, 230);
		textBox_43.Name = "textBox49";
		textBox_43.Size = new Size(41, 20);
		textBox_43.TabIndex = 53;
		textBox_43.Text = "10";
		textBox_43.TextAlign = HorizontalAlignment.Center;
		textBox_42.Location = new Point(115, 53);
		textBox_42.Name = "textBox48";
		textBox_42.Size = new Size(41, 20);
		textBox_42.TabIndex = 53;
		textBox_42.Text = "10";
		textBox_42.TextAlign = HorizontalAlignment.Center;
		label_103.AutoSize = true;
		label_103.Location = new Point(5, 259);
		label_103.Name = "label95";
		label_103.Size = new Size(99, 13);
		label_103.TabIndex = 50;
		label_103.Text = "โหมดเร\u0e34\u0e48มการทำงาน";
		label_98.AutoSize = true;
		label_98.Location = new Point(5, 85);
		label_98.Name = "label90";
		label_98.Size = new Size(102, 13);
		label_98.TabIndex = 50;
		label_98.Text = "โหมดหย\u0e38ดการทำงาน";
		comboBox_20.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_20.FormattingEnabled = true;
		comboBox_20.Items.AddRange(new object[2] { "เร\u0e34\u0e48มการทำงานท\u0e31นท\u0e35", "เด\u0e49งฟ\u0e49า เร\u0e34\u0e48มการทำงาน" });
		comboBox_20.Location = new Point(111, 256);
		comboBox_20.Name = "comboBox14";
		comboBox_20.Size = new Size(121, 21);
		comboBox_20.TabIndex = 49;
		comboBox_19.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_19.FormattingEnabled = true;
		comboBox_19.Items.AddRange(new object[2] { "หย\u0e38ดการทำงานท\u0e31นท\u0e35", "เด\u0e49งส\u0e49ม หย\u0e38ดการทำงาน" });
		comboBox_19.Location = new Point(113, 82);
		comboBox_19.Name = "comboBox13";
		comboBox_19.Size = new Size(121, 21);
		comboBox_19.TabIndex = 49;
		dateTimePicker_5.Format = DateTimePickerFormat.Time;
		dateTimePicker_5.Location = new Point(184, 207);
		dateTimePicker_5.Name = "dateTimePicker9";
		dateTimePicker_5.ShowUpDown = true;
		dateTimePicker_5.Size = new Size(74, 20);
		dateTimePicker_5.TabIndex = 46;
		label_101.BackColor = Color.FromArgb(128, 255, 128);
		label_101.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_101.Location = new Point(3, 289);
		label_101.Name = "label93";
		label_101.Size = new Size(309, 23);
		label_101.TabIndex = 48;
		label_101.Text = "อ\u0e35ก .. ช\u0e31\u0e48วโมง .. นาท\u0e35 .. ว\u0e34นาท\u0e35 จะเร\u0e34\u0e48มการทำงาน";
		label_101.TextAlign = ContentAlignment.MiddleCenter;
		label_97.BackColor = Color.FromArgb(255, 128, 128);
		label_97.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 222);
		label_97.Location = new Point(4, 121);
		label_97.Name = "label89";
		label_97.Size = new Size(309, 23);
		label_97.TabIndex = 48;
		label_97.Text = "อ\u0e35ก .. ช\u0e31\u0e48วโมง .. นาท\u0e35 .. ว\u0e34นาท\u0e35 จะหย\u0e38ดการทำงาน";
		label_97.TextAlign = ContentAlignment.MiddleCenter;
		dateTimePicker_4.Format = DateTimePickerFormat.Time;
		dateTimePicker_4.Location = new Point(184, 30);
		dateTimePicker_4.Name = "dateTimePicker10";
		dateTimePicker_4.ShowUpDown = true;
		dateTimePicker_4.Size = new Size(74, 20);
		dateTimePicker_4.TabIndex = 46;
		groupBox_3.Controls.Add(radioButton_28);
		groupBox_3.Controls.Add(radioButton_27);
		groupBox_3.Location = new Point(2, 194);
		groupBox_3.Name = "groupBox7";
		groupBox_3.Size = new Size(276, 56);
		groupBox_3.TabIndex = 57;
		groupBox_3.TabStop = false;
		radioButton_28.AutoSize = true;
		radioButton_28.Location = new Point(6, 13);
		radioButton_28.Name = "radioButton16";
		radioButton_28.Size = new Size(168, 17);
		radioButton_28.TabIndex = 51;
		radioButton_28.TabStop = true;
		radioButton_28.Text = "ต\u0e31\u0e49งเวลาเร\u0e34\u0e48มการทำงาน เม\u0e37\u0e48อเวลา";
		radioButton_28.UseVisualStyleBackColor = true;
		radioButton_27.AutoSize = true;
		radioButton_27.Location = new Point(6, 36);
		radioButton_27.Name = "radioButton17";
		radioButton_27.Size = new Size(103, 17);
		radioButton_27.TabIndex = 52;
		radioButton_27.TabStop = true;
		radioButton_27.Text = "เร\u0e34\u0e48มทำงานในอ\u0e35ก ";
		radioButton_27.UseVisualStyleBackColor = true;
		groupBox_4.Controls.Add(radioButton_26);
		groupBox_4.Controls.Add(radioButton_25);
		groupBox_4.Location = new Point(3, 20);
		groupBox_4.Name = "groupBox6";
		groupBox_4.Size = new Size(276, 56);
		groupBox_4.TabIndex = 57;
		groupBox_4.TabStop = false;
		radioButton_26.AutoSize = true;
		radioButton_26.Location = new Point(4, 10);
		radioButton_26.Name = "radioButton14";
		radioButton_26.Size = new Size(171, 17);
		radioButton_26.TabIndex = 51;
		radioButton_26.TabStop = true;
		radioButton_26.Text = "ต\u0e31\u0e49งเวลาหย\u0e38ดการทำงาน เม\u0e37\u0e48อเวลา";
		radioButton_26.UseVisualStyleBackColor = true;
		radioButton_25.AutoSize = true;
		radioButton_25.Location = new Point(4, 33);
		radioButton_25.Name = "radioButton15";
		radioButton_25.Size = new Size(106, 17);
		radioButton_25.TabIndex = 52;
		radioButton_25.TabStop = true;
		radioButton_25.Text = "หย\u0e38ดทำงานในอ\u0e35ก ";
		radioButton_25.UseVisualStyleBackColor = true;
		tabPage_14.BorderStyle = BorderStyle.FixedSingle;
		tabPage_14.Controls.Add(button_69);
		tabPage_14.Controls.Add(textBox_48);
		tabPage_14.Controls.Add(groupBox_5);
		tabPage_14.Controls.Add(button_68);
		tabPage_14.Controls.Add(richTextBox_1);
		tabPage_14.Controls.Add(richTextBox_0);
		tabPage_14.Controls.Add(label_114);
		tabPage_14.Controls.Add(textBox_46);
		tabPage_14.Controls.Add(button_67);
		tabPage_14.Controls.Add(comboBox_22);
		tabPage_14.Controls.Add(textBox_45);
		tabPage_14.Controls.Add(label_115);
		tabPage_14.Controls.Add(label_113);
		tabPage_14.Controls.Add(label_112);
		tabPage_14.Controls.Add(label_111);
		tabPage_14.Controls.Add(checkBox_80);
		tabPage_14.Controls.Add(button_66);
		tabPage_14.Controls.Add(button_65);
		tabPage_14.Controls.Add(button_64);
		tabPage_14.Controls.Add(label_110);
		tabPage_14.Controls.Add(label_109);
		tabPage_14.Location = new Point(4, 49);
		tabPage_14.Name = "tabPage14";
		tabPage_14.Size = new Size(638, 370);
		tabPage_14.TabIndex = 15;
		tabPage_14.Text = "Chat-Bot";
		tabPage_14.UseVisualStyleBackColor = true;
		button_69.Location = new Point(202, 225);
		button_69.Name = "button69";
		button_69.Size = new Size(75, 23);
		button_69.TabIndex = 17;
		button_69.Text = "ลบ";
		button_69.UseVisualStyleBackColor = true;
		button_69.Click += button_69_Click;
		textBox_48.BackColor = Color.FromArgb(255, 255, 192);
		textBox_48.ForeColor = SystemColors.InactiveCaptionText;
		textBox_48.Location = new Point(113, 250);
		textBox_48.Name = "textBox50";
		textBox_48.Size = new Size(55, 20);
		textBox_48.TabIndex = 16;
		textBox_48.Text = "500";
		textBox_48.TextAlign = HorizontalAlignment.Center;
		groupBox_5.Controls.Add(textBox_47);
		groupBox_5.Controls.Add(radioButton_30);
		groupBox_5.Controls.Add(radioButton_31);
		groupBox_5.Controls.Add(radioButton_29);
		groupBox_5.Location = new Point(161, 270);
		groupBox_5.Name = "groupBox3";
		groupBox_5.Size = new Size(152, 68);
		groupBox_5.TabIndex = 15;
		groupBox_5.TabStop = false;
		textBox_47.Location = new Point(3, 47);
		textBox_47.Name = "textBox35";
		textBox_47.Size = new Size(128, 20);
		textBox_47.TabIndex = 1;
		textBox_47.Text = "แปปนะคร\u0e31บ";
		radioButton_30.AutoSize = true;
		radioButton_30.Checked = true;
		radioButton_30.Location = new Point(7, 29);
		radioButton_30.Name = "radioButton24";
		radioButton_30.Size = new Size(45, 17);
		radioButton_30.TabIndex = 0;
		radioButton_30.TabStop = true;
		radioButton_30.Text = "ตอบ";
		radioButton_30.UseVisualStyleBackColor = true;
		radioButton_31.AutoSize = true;
		radioButton_31.Location = new Point(71, 10);
		radioButton_31.Name = "radioButton25";
		radioButton_31.Size = new Size(77, 17);
		radioButton_31.TabIndex = 0;
		radioButton_31.Text = "ใช\u0e49 AI (VIP)";
		radioButton_31.UseVisualStyleBackColor = true;
		radioButton_31.Visible = false;
		radioButton_29.AutoSize = true;
		radioButton_29.Location = new Point(7, 10);
		radioButton_29.Name = "radioButton23";
		radioButton_29.Size = new Size(58, 17);
		radioButton_29.TabIndex = 0;
		radioButton_29.Text = "ไม\u0e48ตอบ";
		radioButton_29.UseVisualStyleBackColor = true;
		button_68.Location = new Point(121, 224);
		button_68.Name = "button68";
		button_68.Size = new Size(75, 23);
		button_68.TabIndex = 14;
		button_68.Text = "ล\u0e49าง";
		button_68.UseVisualStyleBackColor = true;
		button_68.Click += button_68_Click;
		richTextBox_1.Location = new Point(161, 113);
		richTextBox_1.Name = "richTextBox2";
		richTextBox_1.ScrollBars = RichTextBoxScrollBars.None;
		richTextBox_1.Size = new Size(144, 107);
		richTextBox_1.TabIndex = 13;
		richTextBox_1.Text = string.Empty;
		richTextBox_0.Location = new Point(8, 113);
		richTextBox_0.Name = "richTextBox1";
		richTextBox_0.ScrollBars = RichTextBoxScrollBars.None;
		richTextBox_0.Size = new Size(144, 107);
		richTextBox_0.TabIndex = 13;
		richTextBox_0.Text = string.Empty;
		label_114.AutoSize = true;
		label_114.BackColor = Color.FromArgb(192, 192, 255);
		label_114.Location = new Point(122, 55);
		label_114.Name = "label101";
		label_114.Size = new Size(66, 13);
		label_114.TabIndex = 12;
		label_114.Text = "ห\u0e31วข\u0e49อสนทนา";
		textBox_46.Location = new Point(95, 72);
		textBox_46.Name = "textBox52";
		textBox_46.Size = new Size(122, 20);
		textBox_46.TabIndex = 11;
		button_67.Location = new Point(189, 27);
		button_67.Name = "button67";
		button_67.Size = new Size(75, 23);
		button_67.TabIndex = 10;
		button_67.Text = "Reload";
		button_67.UseVisualStyleBackColor = true;
		button_67.Click += button_67_Click;
		comboBox_22.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_22.FormattingEnabled = true;
		comboBox_22.Location = new Point(55, 28);
		comboBox_22.Name = "comboBox11";
		comboBox_22.Size = new Size(121, 21);
		comboBox_22.TabIndex = 9;
		comboBox_22.SelectedIndexChanged += comboBox_22_SelectedIndexChanged;
		textBox_45.Location = new Point(8, 275);
		textBox_45.Name = "textBox51";
		textBox_45.Size = new Size(88, 20);
		textBox_45.TabIndex = 8;
		label_115.AutoSize = true;
		label_115.BackColor = Color.FromArgb(255, 192, 192);
		label_115.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_115.Location = new Point(176, 252);
		label_115.Name = "label102";
		label_115.Size = new Size(122, 15);
		label_115.TabIndex = 7;
		label_115.Text = "## หากตอบไม\u0e48ได\u0e49 ##";
		label_113.AutoSize = true;
		label_113.BackColor = Color.FromArgb(192, 255, 255);
		label_113.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_113.Location = new Point(11, 253);
		label_113.Name = "label99";
		label_113.Size = new Size(85, 15);
		label_113.TabIndex = 7;
		label_113.Text = "## ทดสอบ ##";
		label_112.AutoSize = true;
		label_112.BackColor = Color.FromArgb(192, 255, 192);
		label_112.Location = new Point(210, 97);
		label_112.Name = "label98";
		label_112.Size = new Size(53, 13);
		label_112.TabIndex = 6;
		label_112.Text = "ช\u0e38ดคำตอบ";
		label_111.AutoSize = true;
		label_111.BackColor = Color.FromArgb(255, 255, 192);
		label_111.Location = new Point(44, 97);
		label_111.Name = "label97";
		label_111.Size = new Size(52, 13);
		label_111.TabIndex = 6;
		label_111.Text = "ช\u0e38ดคำถาม";
		checkBox_80.AutoSize = true;
		checkBox_80.Location = new Point(16, 5);
		checkBox_80.Name = "checkBox72";
		checkBox_80.Size = new Size(99, 17);
		checkBox_80.TabIndex = 5;
		checkBox_80.Text = "ใช\u0e49งานแชทบอท";
		checkBox_80.UseVisualStyleBackColor = true;
		button_66.Location = new Point(40, 224);
		button_66.Name = "button50";
		button_66.Size = new Size(75, 23);
		button_66.TabIndex = 4;
		button_66.Text = "เพ\u0e34\u0e48ม";
		button_66.UseVisualStyleBackColor = true;
		button_66.Click += button_66_Click;
		button_65.Location = new Point(102, 272);
		button_65.Name = "button49";
		button_65.Size = new Size(57, 23);
		button_65.TabIndex = 3;
		button_65.Text = "ส\u0e48งคำถาม";
		button_65.UseVisualStyleBackColor = true;
		button_65.Click += button_65_Click;
		button_64.Location = new Point(223, 56);
		button_64.Name = "button48";
		button_64.Size = new Size(75, 23);
		button_64.TabIndex = 2;
		button_64.Text = "Test Init";
		button_64.UseVisualStyleBackColor = true;
		button_64.Visible = false;
		button_64.Click += button_64_Click;
		label_110.AutoSize = true;
		label_110.BackColor = Color.FromArgb(192, 255, 192);
		label_110.Location = new Point(11, 324);
		label_110.Name = "label96";
		label_110.Size = new Size(45, 13);
		label_110.TabIndex = 1;
		label_110.Text = "คำตอบ :";
		label_109.AutoSize = true;
		label_109.BackColor = Color.FromArgb(255, 255, 192);
		label_109.Location = new Point(11, 302);
		label_109.Name = "label58";
		label_109.Size = new Size(44, 13);
		label_109.TabIndex = 1;
		label_109.Text = "คำถาม :";
		tabPage_15.BorderStyle = BorderStyle.FixedSingle;
		tabPage_15.Controls.Add(checkBox_92);
		tabPage_15.Controls.Add(button_76);
		tabPage_15.Controls.Add(button_73);
		tabPage_15.Controls.Add(button_74);
		tabPage_15.Controls.Add(button_75);
		tabPage_15.Controls.Add(label_126);
		tabPage_15.Controls.Add(textBox_51);
		tabPage_15.Controls.Add(textBox_52);
		tabPage_15.Controls.Add(textBox_54);
		tabPage_15.Controls.Add(textBox_53);
		tabPage_15.Controls.Add(dataGridView_29);
		tabPage_15.Controls.Add(label_122);
		tabPage_15.Controls.Add(label_123);
		tabPage_15.Controls.Add(label_124);
		tabPage_15.Controls.Add(label_119);
		tabPage_15.Controls.Add(label_127);
		tabPage_15.Controls.Add(label_120);
		tabPage_15.Controls.Add(label_125);
		tabPage_15.Controls.Add(label_128);
		tabPage_15.Controls.Add(label_121);
		tabPage_15.Controls.Add(comboBox_23);
		tabPage_15.Controls.Add(checkBox_83);
		tabPage_15.Location = new Point(4, 49);
		tabPage_15.Name = "tabPage15";
		tabPage_15.Size = new Size(638, 370);
		tabPage_15.TabIndex = 16;
		tabPage_15.Text = "ProxyIP";
		tabPage_15.UseVisualStyleBackColor = true;
		checkBox_92.AutoSize = true;
		checkBox_92.Location = new Point(107, 12);
		checkBox_92.Name = "checkBox86";
		checkBox_92.Size = new Size(44, 17);
		checkBox_92.TabIndex = 12;
		checkBox_92.Text = "Log";
		checkBox_92.UseVisualStyleBackColor = true;
		checkBox_92.Visible = false;
		button_76.Location = new Point(120, 34);
		button_76.Name = "button76";
		button_76.Size = new Size(49, 23);
		button_76.TabIndex = 11;
		button_76.Text = "Refresh";
		button_76.UseVisualStyleBackColor = true;
		button_76.Click += button_76_Click;
		button_73.Location = new Point(45, 342);
		button_73.Name = "button75";
		button_73.Size = new Size(75, 23);
		button_73.TabIndex = 10;
		button_73.Text = "ลบ";
		button_73.UseVisualStyleBackColor = true;
		button_73.Click += button_73_Click;
		button_74.Location = new Point(86, 313);
		button_74.Name = "button74";
		button_74.Size = new Size(75, 23);
		button_74.TabIndex = 10;
		button_74.Text = "ล\u0e49าง";
		button_74.UseVisualStyleBackColor = true;
		button_74.Click += button_74_Click;
		button_75.Location = new Point(5, 313);
		button_75.Name = "button73";
		button_75.Size = new Size(75, 23);
		button_75.TabIndex = 10;
		button_75.Text = "เพ\u0e34\u0e48ม";
		button_75.UseVisualStyleBackColor = true;
		button_75.Click += button_75_Click;
		label_126.AutoSize = true;
		label_126.BackColor = Color.FromArgb(255, 128, 255);
		label_126.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_126.Location = new Point(10, 183);
		label_126.Name = "label113";
		label_126.Size = new Size(85, 16);
		label_126.TabIndex = 9;
		label_126.Text = "จ\u0e31ดการ Proxy";
		textBox_51.Location = new Point(45, 287);
		textBox_51.Name = "textBox57";
		textBox_51.Size = new Size(122, 20);
		textBox_51.TabIndex = 5;
		textBox_52.Location = new Point(45, 258);
		textBox_52.Name = "textBox56";
		textBox_52.Size = new Size(122, 20);
		textBox_52.TabIndex = 5;
		textBox_54.Location = new Point(45, 233);
		textBox_54.Name = "textBox58";
		textBox_54.Size = new Size(122, 20);
		textBox_54.TabIndex = 5;
		textBox_53.Location = new Point(45, 207);
		textBox_53.Name = "textBox55";
		textBox_53.Size = new Size(122, 20);
		textBox_53.TabIndex = 5;
		dataGridView_29.AllowUserToAddRows = false;
		dataGridView_29.AllowUserToDeleteRows = false;
		dataGridView_29.AllowUserToResizeColumns = false;
		dataGridView_29.AllowUserToResizeRows = false;
		dataGridView_29.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		dataGridView_29.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
		dataGridView_29.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
		dataGridView_29.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridView_29.Location = new Point(175, 3);
		dataGridView_29.Name = "dataGridView13";
		dataGridView_29.ReadOnly = true;
		dataGridView_29.RowHeadersVisible = false;
		dataGridView_29.Size = new Size(458, 364);
		dataGridView_29.TabIndex = 4;
		dataGridView_29.CellDoubleClick += dataGridView_29_CellDoubleClick;
		dataGridView_29.CellFormatting += dataGridView_29_CellFormatting;
		label_122.AutoSize = true;
		label_122.Location = new Point(12, 147);
		label_122.Name = "label109";
		label_122.Size = new Size(34, 13);
		label_122.TabIndex = 3;
		label_122.Text = "Ping :";
		label_123.AutoSize = true;
		label_123.Location = new Point(7, 292);
		label_123.Name = "label112";
		label_123.Size = new Size(39, 13);
		label_123.TabIndex = 2;
		label_123.Text = "Pass : ";
		label_124.AutoSize = true;
		label_124.Location = new Point(7, 262);
		label_124.Name = "label111";
		label_124.Size = new Size(38, 13);
		label_124.TabIndex = 2;
		label_124.Text = "User : ";
		label_119.AutoSize = true;
		label_119.Location = new Point(12, 126);
		label_119.Name = "label108";
		label_119.Size = new Size(39, 13);
		label_119.TabIndex = 2;
		label_119.Text = "Pass : ";
		label_127.AutoSize = true;
		label_127.Location = new Point(7, 236);
		label_127.Name = "label115";
		label_127.Size = new Size(32, 13);
		label_127.TabIndex = 2;
		label_127.Text = "Prot :";
		label_120.AutoSize = true;
		label_120.Location = new Point(12, 105);
		label_120.Name = "label107";
		label_120.Size = new Size(38, 13);
		label_120.TabIndex = 2;
		label_120.Text = "User : ";
		label_125.AutoSize = true;
		label_125.Location = new Point(7, 210);
		label_125.Name = "label110";
		label_125.Size = new Size(26, 13);
		label_125.TabIndex = 2;
		label_125.Text = "IP : ";
		label_128.AutoSize = true;
		label_128.Location = new Point(12, 85);
		label_128.Name = "label114";
		label_128.Size = new Size(32, 13);
		label_128.TabIndex = 2;
		label_128.Text = "Port :";
		label_121.AutoSize = true;
		label_121.Location = new Point(12, 65);
		label_121.Name = "label105";
		label_121.Size = new Size(26, 13);
		label_121.TabIndex = 2;
		label_121.Text = "IP : ";
		comboBox_23.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_23.FormattingEnabled = true;
		comboBox_23.Location = new Point(7, 35);
		comboBox_23.Name = "comboBox12";
		comboBox_23.Size = new Size(109, 21);
		comboBox_23.TabIndex = 1;
		checkBox_83.AutoSize = true;
		checkBox_83.Location = new Point(15, 12);
		checkBox_83.Name = "checkBox83";
		checkBox_83.Size = new Size(86, 17);
		checkBox_83.TabIndex = 0;
		checkBox_83.Text = "ใช\u0e49งาน Proxy";
		checkBox_83.UseVisualStyleBackColor = true;
		tabPage_16.Controls.Add(trackBar_2);
		tabPage_16.Controls.Add(label_134);
		tabPage_16.Controls.Add(checkBox_89);
		tabPage_16.Controls.Add(checkBox_90);
		tabPage_16.Controls.Add(checkBox_91);
		tabPage_16.Location = new Point(4, 49);
		tabPage_16.Name = "tabPage16";
		tabPage_16.Size = new Size(638, 370);
		tabPage_16.TabIndex = 17;
		tabPage_16.Text = " CPU";
		tabPage_16.UseVisualStyleBackColor = true;
		trackBar_2.Location = new Point(33, 95);
		trackBar_2.Maximum = 60;
		trackBar_2.Minimum = 10;
		trackBar_2.Name = "trackBar3";
		trackBar_2.Size = new Size(235, 45);
		trackBar_2.TabIndex = 2;
		trackBar_2.Value = 10;
		trackBar_2.Scroll += trackBar_2_Scroll;
		label_134.AutoSize = true;
		label_134.BackColor = Color.FromArgb(128, 255, 255);
		label_134.Location = new Point(207, 67);
		label_134.Name = "label119";
		label_134.Size = new Size(27, 13);
		label_134.TabIndex = 1;
		label_134.Text = "FPS";
		checkBox_89.AutoSize = true;
		checkBox_89.Location = new Point(33, 63);
		checkBox_89.Name = "checkBox91";
		checkBox_89.Size = new Size(177, 17);
		checkBox_89.TabIndex = 0;
		checkBox_89.Text = "เป\u0e34ดใช\u0e49งาน ลด CPU ( ล\u0e47อค FPS ) ";
		checkBox_89.UseVisualStyleBackColor = true;
		checkBox_89.CheckedChanged += checkBox_89_CheckedChanged;
		checkBox_90.AutoSize = true;
		checkBox_90.Location = new Point(33, 40);
		checkBox_90.Name = "checkBox90";
		checkBox_90.Size = new Size(168, 17);
		checkBox_90.TabIndex = 0;
		checkBox_90.Text = "เป\u0e34ดใช\u0e49งาน ลด GPU (หย\u0e38ดภาพ)";
		checkBox_90.UseVisualStyleBackColor = true;
		checkBox_90.CheckedChanged += checkBox_90_CheckedChanged;
		checkBox_91.AutoSize = true;
		checkBox_91.Enabled = false;
		checkBox_91.Location = new Point(17, 17);
		checkBox_91.Name = "checkBox89";
		checkBox_91.Size = new Size(168, 17);
		checkBox_91.TabIndex = 0;
		checkBox_91.Text = "ใช\u0e49งานท\u0e31นท\u0e35เม\u0e37\u0e48อไม\u0e48โฟก\u0e31สหน\u0e49าจอ";
		checkBox_91.UseVisualStyleBackColor = true;
		tabPage_17.BorderStyle = BorderStyle.FixedSingle;
		tabPage_17.Controls.Add(dataGridView_30);
		tabPage_17.Controls.Add(button_79);
		tabPage_17.Controls.Add(button_80);
		tabPage_17.Controls.Add(button_81);
		tabPage_17.Controls.Add(textBox_58);
		tabPage_17.Controls.Add(textBox_59);
		tabPage_17.Controls.Add(textBox_60);
		tabPage_17.Controls.Add(label_138);
		tabPage_17.Controls.Add(label_139);
		tabPage_17.Controls.Add(label_140);
		tabPage_17.Controls.Add(label_141);
		tabPage_17.Location = new Point(4, 49);
		tabPage_17.Name = "tabPage18";
		tabPage_17.Size = new Size(638, 370);
		tabPage_17.TabIndex = 19;
		tabPage_17.Text = "Login";
		tabPage_17.UseVisualStyleBackColor = true;
		dataGridView_30.AllowUserToAddRows = false;
		dataGridView_30.AllowUserToDeleteRows = false;
		dataGridView_30.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_30.Location = new Point(3, 164);
		dataGridView_30.MultiSelect = false;
		dataGridView_30.Name = "dataGridView15";
		dataGridView_30.ReadOnly = true;
		dataGridView_30.RowHeadersVisible = false;
		dataGridView_30.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_30.Size = new Size(308, 177);
		dataGridView_30.TabIndex = 27;
		button_79.Location = new Point(120, 135);
		button_79.Name = "button83";
		button_79.Size = new Size(75, 23);
		button_79.TabIndex = 26;
		button_79.Text = "Delete";
		button_79.UseVisualStyleBackColor = true;
		button_79.Click += button_79_Click;
		button_80.Location = new Point(205, 135);
		button_80.Name = "button84";
		button_80.Size = new Size(75, 23);
		button_80.TabIndex = 25;
		button_80.Text = "Clear";
		button_80.UseVisualStyleBackColor = true;
		button_80.Click += button_80_Click;
		button_81.Location = new Point(36, 135);
		button_81.Name = "button86";
		button_81.Size = new Size(75, 23);
		button_81.TabIndex = 24;
		button_81.Text = "Add";
		button_81.UseVisualStyleBackColor = true;
		button_81.Click += button_81_Click;
		textBox_58.Location = new Point(101, 43);
		textBox_58.MaxLength = 20;
		textBox_58.Name = "textBox68";
		textBox_58.Size = new Size(122, 20);
		textBox_58.TabIndex = 21;
		textBox_59.Location = new Point(101, 73);
		textBox_59.MaxLength = 20;
		textBox_59.Name = "textBox69";
		textBox_59.Size = new Size(122, 20);
		textBox_59.TabIndex = 22;
		textBox_59.UseSystemPasswordChar = true;
		textBox_60.Location = new Point(101, 103);
		textBox_60.MaxLength = 19;
		textBox_60.Name = "textBox70";
		textBox_60.Size = new Size(122, 20);
		textBox_60.TabIndex = 23;
		textBox_60.UseSystemPasswordChar = true;
		label_138.Location = new Point(39, 76);
		label_138.Name = "label133";
		label_138.Size = new Size(62, 13);
		label_138.TabIndex = 20;
		label_138.Text = "Pass :";
		label_138.TextAlign = ContentAlignment.MiddleRight;
		label_139.Location = new Point(39, 46);
		label_139.Name = "label134";
		label_139.Size = new Size(62, 13);
		label_139.TabIndex = 19;
		label_139.Text = "User :";
		label_139.TextAlign = ContentAlignment.MiddleRight;
		label_140.AutoSize = true;
		label_140.BackColor = Color.FromArgb(255, 128, 255);
		label_140.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 222);
		label_140.Location = new Point(98, 15);
		label_140.Name = "label139";
		label_140.Size = new Size(100, 16);
		label_140.TabIndex = 18;
		label_140.Text = "Manage User";
		label_141.Location = new Point(39, 106);
		label_141.Name = "label140";
		label_141.Size = new Size(62, 13);
		label_141.TabIndex = 20;
		label_141.Text = "SubPass :";
		label_141.TextAlign = ContentAlignment.MiddleRight;
		comboBox_0.Anchor = AnchorStyles.Bottom;
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Location = new Point(164, 456);
		comboBox_0.Name = "comboBox1";
		comboBox_0.Size = new Size(84, 21);
		comboBox_0.TabIndex = 12;
		textBox_6.Anchor = AnchorStyles.Bottom;
		textBox_6.Location = new Point(164, 432);
		textBox_6.Name = "textBox3";
		textBox_6.Size = new Size(76, 20);
		textBox_6.TabIndex = 21;
		button_11.Anchor = AnchorStyles.Bottom;
		button_11.Location = new Point(245, 431);
		button_11.Name = "button16";
		button_11.Size = new Size(49, 21);
		button_11.TabIndex = 22;
		button_11.Text = "Path";
		button_11.UseVisualStyleBackColor = true;
		button_11.Click += button_11_Click;
		button_12.Anchor = AnchorStyles.Bottom;
		button_12.BackColor = Color.FromArgb(192, 255, 192);
		button_12.Location = new Point(297, 431);
		button_12.Name = "button17";
		button_12.Size = new Size(49, 21);
		button_12.TabIndex = 22;
		button_12.Text = "Run";
		button_12.UseVisualStyleBackColor = false;
		button_12.Click += button_12_Click;
		checkBox_33.Anchor = AnchorStyles.Bottom;
		checkBox_33.AutoSize = true;
		checkBox_33.Location = new Point(398, 434);
		checkBox_33.Name = "checkBox2";
		checkBox_33.Size = new Size(49, 17);
		checkBox_33.TabIndex = 23;
		checkBox_33.Text = "Click";
		checkBox_33.UseVisualStyleBackColor = true;
		checkBox_33.CheckedChanged += checkBox_33_CheckedChanged;
		button_33.Anchor = AnchorStyles.Bottom;
		button_33.Location = new Point(255, 456);
		button_33.Name = "button8";
		button_33.Size = new Size(65, 23);
		button_33.TabIndex = 15;
		button_33.Text = "Select";
		button_33.UseVisualStyleBackColor = true;
		button_33.Click += button_33_Click;
		checkBox_39.Anchor = AnchorStyles.Bottom;
		checkBox_39.AutoSize = true;
		checkBox_39.Checked = true;
		checkBox_39.CheckState = CheckState.Checked;
		checkBox_39.Location = new Point(449, 434);
		checkBox_39.Name = "checkBox42";
		checkBox_39.Size = new Size(42, 17);
		checkBox_39.TabIndex = 32;
		checkBox_39.Text = "Bot";
		checkBox_39.UseVisualStyleBackColor = true;
		comboBox_26.Anchor = AnchorStyles.Bottom;
		comboBox_26.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_26.FormattingEnabled = true;
		comboBox_26.Location = new Point(243, 532);
		comboBox_26.Name = "comboBox22";
		comboBox_26.Size = new Size(103, 21);
		comboBox_26.TabIndex = 35;
		label_137.Anchor = AnchorStyles.Bottom;
		label_137.AutoSize = true;
		label_137.Location = new Point(354, 536);
		label_137.Name = "label131";
		label_137.Size = new Size(18, 13);
		label_137.TabIndex = 36;
		label_137.Text = "ID";
		checkBox_97.Anchor = AnchorStyles.Bottom;
		checkBox_97.AutoSize = true;
		checkBox_97.Location = new Point(168, 534);
		checkBox_97.Name = "checkBox74";
		checkBox_97.Size = new Size(74, 17);
		checkBox_97.TabIndex = 37;
		checkBox_97.Text = "AutoLogin";
		checkBox_97.UseVisualStyleBackColor = true;
		button_83.Anchor = AnchorStyles.Bottom;
		button_83.Location = new Point(329, 481);
		button_83.Name = "button9";
		button_83.Size = new Size(75, 23);
		button_83.TabIndex = 38;
		button_83.Text = "Kill-SV";
		button_83.UseVisualStyleBackColor = true;
		button_84.Anchor = AnchorStyles.Bottom;
		button_84.Location = new Point(255, 481);
		button_84.Name = "button30";
		button_84.Size = new Size(64, 23);
		button_84.TabIndex = 38;
		button_84.Text = "Reload";
		button_84.UseVisualStyleBackColor = true;
		comboBox_27.Anchor = AnchorStyles.Bottom;
		comboBox_27.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_27.FormattingEnabled = true;
		comboBox_27.Location = new Point(164, 481);
		comboBox_27.Name = "comboBox23";
		comboBox_27.Size = new Size(84, 21);
		comboBox_27.TabIndex = 12;
		button_89.Anchor = AnchorStyles.Bottom;
		button_89.Location = new Point(164, 506);
		button_89.Name = "button81";
		button_89.Size = new Size(84, 23);
		button_89.TabIndex = 39;
		button_89.Text = " ป\u0e34ดแจ\u0e49งเต\u0e37อน";
		button_89.UseVisualStyleBackColor = true;
		button_90.Anchor = AnchorStyles.Bottom;
		button_90.Location = new Point(255, 506);
		button_90.Name = "button82";
		button_90.Size = new Size(84, 23);
		button_90.TabIndex = 40;
		button_90.Text = "เป\u0e34ดแจ\u0e49งเต\u0e37อน";
		button_90.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(653, 558);
		base.Controls.Add(button_90);
		base.Controls.Add(button_89);
		base.Controls.Add(button_84);
		base.Controls.Add(button_83);
		base.Controls.Add(checkBox_97);
		base.Controls.Add(label_137);
		base.Controls.Add(comboBox_26);
		base.Controls.Add(checkBox_39);
		base.Controls.Add(checkBox_33);
		base.Controls.Add(button_12);
		base.Controls.Add(button_11);
		base.Controls.Add(textBox_6);
		base.Controls.Add(checkBox_10);
		base.Controls.Add(button_1);
		base.Controls.Add(button_33);
		base.Controls.Add(button_2);
		base.Controls.Add(comboBox_27);
		base.Controls.Add(comboBox_0);
		base.Controls.Add(tabControl_0);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "Form1";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Capybara-KlassX";
		base.FormClosing += GForm0_FormClosing;
		base.Load += GForm0_Load;
		tabPage_0.ResumeLayout(performLayout: false);
		tabPage_0.PerformLayout();
		tabPage_1.ResumeLayout(performLayout: false);
		tabPage_1.PerformLayout();
		panel_13.ResumeLayout(performLayout: false);
		panel_13.PerformLayout();
		((ISupportInitialize)numericUpDown_0).EndInit();
		((ISupportInitialize)dataGridView_28).EndInit();
		((ISupportInitialize)dataGridView_0).EndInit();
		((ISupportInitialize)trackBar_0).EndInit();
		tabPage_2.ResumeLayout(performLayout: false);
		tabPage_2.PerformLayout();
		((ISupportInitialize)trackBar_3).EndInit();
		tabPage_3.ResumeLayout(performLayout: false);
		tabPage_3.PerformLayout();
		tabControl_0.ResumeLayout(performLayout: false);
		tabPage_5.ResumeLayout(performLayout: false);
		tabPage_5.PerformLayout();
		((ISupportInitialize)dataGridView_15).EndInit();
		((ISupportInitialize)dataGridView_16).EndInit();
		((ISupportInitialize)dataGridView_3).EndInit();
		((ISupportInitialize)dataGridView_4).EndInit();
		((ISupportInitialize)dataGridView_5).EndInit();
		((ISupportInitialize)dataGridView_17).EndInit();
		((ISupportInitialize)dataGridView_6).EndInit();
		((ISupportInitialize)dataGridView_7).EndInit();
		((ISupportInitialize)dataGridView_8).EndInit();
		((ISupportInitialize)dataGridView_18).EndInit();
		((ISupportInitialize)dataGridView_9).EndInit();
		((ISupportInitialize)dataGridView_10).EndInit();
		((ISupportInitialize)dataGridView_11).EndInit();
		((ISupportInitialize)dataGridView_12).EndInit();
		((ISupportInitialize)dataGridView_13).EndInit();
		((ISupportInitialize)dataGridView_14).EndInit();
		tabPage_4.ResumeLayout(performLayout: false);
		tabPage_4.PerformLayout();
		((ISupportInitialize)dataGridView_1).EndInit();
		((ISupportInitialize)dataGridView_2).EndInit();
		tabPage_6.ResumeLayout(performLayout: false);
		tabPage_6.PerformLayout();
		((ISupportInitialize)dataGridView_19).EndInit();
		((ISupportInitialize)dataGridView_20).EndInit();
		groupBox_0.ResumeLayout(performLayout: false);
		groupBox_0.PerformLayout();
		groupBox_1.ResumeLayout(performLayout: false);
		groupBox_1.PerformLayout();
		tabPage_7.ResumeLayout(performLayout: false);
		tabPage_7.PerformLayout();
		((ISupportInitialize)dataGridView_23).EndInit();
		((ISupportInitialize)trackBar_1).EndInit();
		tabPage_10.ResumeLayout(performLayout: false);
		tabPage_10.PerformLayout();
		panel_0.ResumeLayout(performLayout: false);
		panel_12.ResumeLayout(performLayout: false);
		panel_11.ResumeLayout(performLayout: false);
		panel_10.ResumeLayout(performLayout: false);
		panel_9.ResumeLayout(performLayout: false);
		panel_8.ResumeLayout(performLayout: false);
		panel_7.ResumeLayout(performLayout: false);
		panel_6.ResumeLayout(performLayout: false);
		panel_5.ResumeLayout(performLayout: false);
		panel_4.ResumeLayout(performLayout: false);
		panel_3.ResumeLayout(performLayout: false);
		panel_2.ResumeLayout(performLayout: false);
		panel_1.ResumeLayout(performLayout: false);
		((ISupportInitialize)dataGridView_22).EndInit();
		tabPage_12.ResumeLayout(performLayout: false);
		tabPage_12.PerformLayout();
		((ISupportInitialize)dataGridView_24).EndInit();
		((ISupportInitialize)dataGridView_25).EndInit();
		((ISupportInitialize)dataGridView_26).EndInit();
		((ISupportInitialize)dataGridView_27).EndInit();
		tabPage_8.ResumeLayout(performLayout: false);
		tabPage_8.PerformLayout();
		((ISupportInitialize)dataGridView_21).EndInit();
		tabPage_9.ResumeLayout(performLayout: false);
		tabPage_9.PerformLayout();
		groupBox_2.ResumeLayout(performLayout: false);
		groupBox_2.PerformLayout();
		tabPage_11.ResumeLayout(performLayout: false);
		tabPage_11.PerformLayout();
		((ISupportInitialize)pictureBox_2).EndInit();
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)pictureBox_1).EndInit();
		tabPage_13.ResumeLayout(performLayout: false);
		tabPage_13.PerformLayout();
		groupBox_3.ResumeLayout(performLayout: false);
		groupBox_3.PerformLayout();
		groupBox_4.ResumeLayout(performLayout: false);
		groupBox_4.PerformLayout();
		tabPage_14.ResumeLayout(performLayout: false);
		tabPage_14.PerformLayout();
		groupBox_5.ResumeLayout(performLayout: false);
		groupBox_5.PerformLayout();
		tabPage_15.ResumeLayout(performLayout: false);
		tabPage_15.PerformLayout();
		((ISupportInitialize)dataGridView_29).EndInit();
		tabPage_16.ResumeLayout(performLayout: false);
		tabPage_16.PerformLayout();
		((ISupportInitialize)trackBar_2).EndInit();
		tabPage_17.ResumeLayout(performLayout: false);
		tabPage_17.PerformLayout();
		((ISupportInitialize)dataGridView_30).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void method_28()
	{
		string text = ((class190_0 == null || class190_0.method_0() == null) ? null : class190_0.method_0().string_0);
		Class145 @class = method_5();
		string b = Class146.smethod_1(checkBox_34.Checked, checkBox_35.Checked, string_0, @class.method_26(), text);
		if (!string.Equals(Text, b, StringComparison.Ordinal))
		{
			Text = b;
		}
	}

	private static long smethod_3()
	{
		return DateTime.UtcNow.Ticks / 10000L;
	}

	private void method_29()
	{
		Class143.smethod_12(ref struct1_0);
		label_168.Text = Class143.smethod_11(null);
		base.Disposed += GForm0_Disposed_1;
	}

	private void method_30(Class119 class119_5)
	{
		Class153 @class = new Class153();
		@class.gform0_0 = this;
		@class.class119_0 = class119_5;
		@class.class119_0.method_6(@class.method_0);
		@class.class119_0.method_8(@class.method_1);
	}

	private void trackBar_3_Scroll(object sender, EventArgs e)
	{
		struct137_0.bool_0 = true;
		struct137_0.float_0 = Class143.smethod_0(trackBar_3.Value);
		struct137_0.int_0++;
		Class143.smethod_7(ref struct1_0);
		if (timer_0 != null)
		{
			timer_0.Stop();
		}
		method_32();
	}

	private void method_31()
	{
		Class143.smethod_1(ref struct137_0, trackBar_3.Value);
		Class143.smethod_7(ref struct1_0);
		if (timer_0 != null)
		{
			timer_0.Stop();
		}
	}

	private void method_32()
	{
		Class119 @class = Volatile.Read(ref class119_0);
		if (@class != null)
		{
			Enum0 enum0_ = method_16();
			if (Class143.smethod_2(struct1_0, enum0_, @class.method_115()) && @class.method_119())
			{
				Class143.smethod_3(ref struct1_0);
			}
			bool flag = @class.method_115() && struct1_0.bool_1 && struct1_0.bool_2;
			Struct17 struct17_ = Class143.smethod_5(struct137_0, struct1_0, enum0_, flag);
			if (struct17_.bool_0 && @class.method_118(struct17_.float_0, out var uint_))
			{
				Class143.smethod_6(ref struct1_0, struct17_, uint_, smethod_3());
				method_33();
			}
		}
	}

	private void method_33()
	{
		if (timer_0 == null)
		{
			timer_0 = new System.Windows.Forms.Timer
			{
				Interval = 250
			};
			timer_0.Tick += timer_0_Tick;
		}
		timer_0.Start();
	}

	private void method_34(Class119 class119_5, Class101 class101_0)
	{
		if (class119_5 != method_7())
		{
			return;
		}
		if (class101_0.uint_0 == 0)
		{
			if (Class143.smethod_10(ref struct1_0, class101_0))
			{
				label_168.Text = Class143.smethod_11(struct1_0.nullable_0);
				method_32();
			}
		}
		else if (Class143.smethod_9(ref struct1_0, class101_0))
		{
			if (timer_0 != null)
			{
				timer_0.Stop();
			}
			label_168.Text = Class143.smethod_11(struct1_0.nullable_0);
		}
	}

	private void method_35(Class119 class119_5, Class400 class400_0)
	{
		if (class119_5 == method_7())
		{
			Class143.smethod_4(ref struct1_0, class400_0);
			label_168.Text = Class143.smethod_11(struct1_0.nullable_0);
			method_32();
		}
	}

	private void method_36()
	{
		Class143.smethod_12(ref struct1_0);
		if (timer_0 != null)
		{
			timer_0.Stop();
		}
		label_168.Text = Class143.smethod_11(null);
	}

	private void method_37()
	{
		for (int i = 51; i <= 66; i++)
		{
			Class158 @class = new Class158();
			@class.gform0_0 = this;
			@class.int_0 = i;
			Button button = method_46(@class.int_0);
			if (button != null)
			{
				button.Click += @class.method_0;
			}
		}
	}

	private void method_38(int int_12)
	{
		if (class181_0.method_2())
		{
			method_39();
		}
		else
		{
			if (bool_2)
			{
				return;
			}
			DataGridView dataGridView = method_45(int_12);
			Button button = method_46(int_12);
			if (dataGridView != null && button != null)
			{
				using (class67_0.method_17(dataGridView))
				{
					dataGridView.Rows.Clear();
				}
				class181_0.method_3(int_12);
				button.BackColor = color_2;
				button.UseVisualStyleBackColor = false;
				method_40();
			}
		}
	}

	private void method_39()
	{
		if (class181_0.method_2())
		{
			Button button = method_46(class181_0.method_0());
			if (button != null)
			{
				button.BackColor = color_3;
				button.UseVisualStyleBackColor = false;
				button.Text = "Rec";
			}
			class181_0.method_4();
			method_40();
		}
	}

	private void method_40()
	{
		for (int i = 51; i <= 66; i++)
		{
			Button button = method_46(i);
			if (button != null)
			{
				button.Enabled = !class181_0.method_2() || i == class181_0.method_0();
			}
		}
	}

	private void method_41(Class83 class83_0)
	{
		if (!class181_0.method_2() || !class181_0.method_5(class83_0.float_0, class83_0.float_2))
		{
			return;
		}
		DataGridView dataGridView = method_45(class181_0.method_0());
		if (dataGridView != null)
		{
			using (class67_0.method_17(dataGridView))
			{
				dataGridView.Rows.Add(Class440.smethod_2(class83_0.float_0), Class440.smethod_2(class83_0.float_1), Class440.smethod_2(class83_0.float_2));
			}
			Button button = method_46(class181_0.method_0());
			if (button != null)
			{
				button.Text = "Rec " + dataGridView.Rows.Count.ToString(CultureInfo.InvariantCulture);
			}
		}
	}

	private void method_42()
	{
		method_39();
		if (Class429.smethod_3(this, "ล\u0e49าง waypoint ท\u0e31\u0e49ง 16 ช\u0e48อง?", "Looper", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
		{
			return;
		}
		Class188.smethod_17();
		for (int i = 51; i <= 66; i++)
		{
			DataGridView dataGridView = method_45(i);
			if (dataGridView != null && dataGridView.Rows.Count != 0)
			{
				using (class67_0.method_17(dataGridView))
				{
					dataGridView.Rows.Clear();
				}
				Button button = method_46(i);
				if (button != null)
				{
					button.Text = "Rec";
				}
			}
		}
	}

	private void method_43()
	{
		method_39();
		List<Class455> list = new List<Class455>();
		for (int i = 51; i <= 66; i++)
		{
			DataGridView dataGridView = method_45(i);
			if (dataGridView == null)
			{
				continue;
			}
			List<Struct76> list2 = Class440.smethod_16(dataGridView);
			if (list2.Count != 0)
			{
				float[] array = new float[list2.Count];
				float[] array2 = new float[list2.Count];
				float[] array3 = new float[list2.Count];
				for (int j = 0; j < list2.Count; j++)
				{
					array[j] = list2[j].float_0;
					array2[j] = list2[j].float_1;
					array3[j] = list2[j].float_2;
				}
				list.Add(new Class455
				{
					int_0 = i,
					float_0 = array,
					float_1 = array2,
					float_2 = array3
				});
			}
		}
		if (list.Count == 0)
		{
			Class429.smethod_0(this, "ย\u0e31งไม\u0e48ม\u0e35 waypoint ให\u0e49บ\u0e31นท\u0e36ก", "Looper");
			return;
		}
		string fileName;
		using (SaveFileDialog saveFileDialog = new SaveFileDialog())
		{
			saveFileDialog.Title = "Save Record Path";
			saveFileDialog.Filter = "Record Path files (*.recPath)|*.recPath";
			saveFileDialog.DefaultExt = "recPath";
			if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}
			fileName = saveFileDialog.FileName;
		}
		try
		{
			File.WriteAllText(fileName, Class189.smethod_0(list, DateTime.Now));
		}
		catch (Exception ex)
		{
			Class429.smethod_3(this, "บ\u0e31นท\u0e36กไม\u0e48สำเร\u0e47จ: " + ex.Message, "Looper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		Class429.smethod_0(this, "บ\u0e31นท\u0e36กแล\u0e49ว " + list.Count + " ช\u0e48อง", "Looper");
	}

	private void method_44()
	{
		method_39();
		OpenFileDialog openFileDialog = new OpenFileDialog();
		string fileName;
		try
		{
			openFileDialog.Title = "Load Record Path";
			openFileDialog.Filter = "Record Path files (*.recPath)|*.recPath";
			if (openFileDialog.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}
			fileName = openFileDialog.FileName;
		}
		finally
		{
			((IDisposable)openFileDialog).Dispose();
		}
		string text;
		try
		{
			text = File.ReadAllText(fileName);
		}
		catch (Exception ex)
		{
			Class429.smethod_3(this, "เป\u0e34ดไฟล\u0e4cไม\u0e48สำเร\u0e47จ: " + ex.Message, "Looper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		List<Class455> list = Class189.smethod_1(text);
		if (list == null)
		{
			Class429.smethod_3(this, "ไฟล\u0e4cน\u0e35\u0e49ไม\u0e48ใช\u0e48ไฟล\u0e4c waypoint", "Looper", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		else
		{
			if (Class429.smethod_3(this, "โหลดท\u0e31บ waypoint ท\u0e35\u0e48อย\u0e39\u0e48บนจอท\u0e31\u0e49ง 16 ช\u0e48อง?", "Looper", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
			{
				return;
			}
			Class188.smethod_17();
			for (int i = 51; i <= 66; i++)
			{
				DataGridView dataGridView = method_45(i);
				if (dataGridView == null)
				{
					continue;
				}
				if (dataGridView.Rows.Count > 0)
				{
					using (class67_0.method_17(dataGridView))
					{
						dataGridView.Rows.Clear();
					}
				}
				Button button = method_46(i);
				if (button != null)
				{
					button.Text = "Rec";
				}
			}
			int num = 0;
			foreach (Class455 item in list)
			{
				if (item.int_0 < 51 || item.int_0 > 66)
				{
					continue;
				}
				DataGridView dataGridView2 = method_45(item.int_0);
				if (dataGridView2 == null)
				{
					continue;
				}
				using (class67_0.method_17(dataGridView2))
				{
					for (int j = 0; j < item.float_0.Length; j++)
					{
						dataGridView2.Rows.Add(Class440.smethod_2(item.float_0[j]), Class440.smethod_2(item.float_1[j]), Class440.smethod_2(item.float_2[j]));
					}
				}
				num++;
			}
			Class429.smethod_0(this, "โหลดแล\u0e49ว " + num + " ช\u0e48อง", "Looper");
		}
	}

	private DataGridView method_45(int int_12)
	{
		return Class80.smethod_0(base.Controls.Find("dataGridView" + int_12, searchAllChildren: true)) as DataGridView;
	}

	private Button method_46(int int_12)
	{
		return Class80.smethod_0(base.Controls.Find("button" + int_12, searchAllChildren: true)) as Button;
	}

	private void method_47()
	{
		if (class119_0 == null)
		{
			class4_0.method_3();
			bool_11 = false;
			return;
		}
		bool flag = bool_2 && checkBox_102.Checked && class119_0.method_96() && radioButton_11.Checked;
		List<Struct76> list = null;
		int num = 0;
		int num2 = 0;
		Class132 @class = Class188.smethod_11();
		if (flag)
		{
			int num3 = @class.int_0;
			if (num3 == 0)
			{
				flag = false;
			}
			else
			{
				list = Class440.smethod_16(this.smethod_30("dataGridView" + num3));
				num = list.Count;
				num2 = (@class.bool_0 ? num : @class.method_0());
				if (num == 0)
				{
					flag = false;
				}
			}
		}
		Struct78 @struct = class4_0.method_2(flag, num, num2);
		int[] array = @struct.int_3;
		foreach (int num4 in array)
		{
			class119_0.method_114(Class4.smethod_1(num4));
		}
		array = @struct.int_1;
		foreach (int num5 in array)
		{
			class119_0.method_114(Class4.smethod_0(num5));
		}
		if (list != null)
		{
			array = @struct.int_0;
			foreach (int num6 in array)
			{
				if (num6 >= 0 && num6 < list.Count)
				{
					Struct76 struct2 = list[num6];
					class119_0.method_110(Class4.smethod_0(num6), 2.5f, 1f, 0f, 0f, 0.78f, struct2.float_0, struct2.float_1, struct2.float_2);
				}
			}
			array = @struct.int_2;
			foreach (int num7 in array)
			{
				if (num7 >= 0 && num7 + 1 < list.Count)
				{
					Struct76 struct3 = list[num7];
					Struct76 struct4 = list[num7 + 1];
					class119_0.method_112(Class4.smethod_1(num7), 1f, 1f, 0f, 0f, 0.78f, struct3.float_0, struct3.float_1, struct3.float_2, struct4.float_0, struct4.float_1, struct4.float_2);
				}
			}
		}
		method_48(flag, list, @class);
	}

	private void method_48(bool bool_23, List<Struct76> list_1, Class132 class132_0)
	{
		if (bool_23 && list_1 != null)
		{
			int num = (class132_0.bool_0 ? list_1.Count : class132_0.method_0());
			int num2 = num - 1;
			if (num2 < 0 || num2 >= list_1.Count)
			{
				return;
			}
			Struct76 @struct = list_1[num2];
			Class83 @class = class119_0.method_51().method_0();
			if (@class != null)
			{
				if (!bool_11)
				{
					class119_0.method_111("lh", 2.5f, 1f, 0f, 0f, 0.78f);
					bool_11 = true;
					int_0 = 0;
				}
				float num3 = @class.float_0 - float_0;
				float num4 = @class.float_2 - float_1;
				if (num != int_0 || !(num3 * num3 + num4 * num4 < 16f))
				{
					float_0 = @class.float_0;
					float_1 = @class.float_2;
					int_0 = num;
					class119_0.method_112("lt", 1f, 1f, 0f, 0f, 0.78f, @class.float_0, @class.float_1, @class.float_2, @struct.float_0, @struct.float_1, @struct.float_2);
				}
			}
		}
		else
		{
			if (bool_11)
			{
				class119_0.method_114("lt");
				class119_0.method_114("lh");
			}
			bool_11 = false;
		}
	}

	private async Task method_49(bool bool_23)
	{
		if (method_16() != Enum0.Selected || !method_6() || bool_5 || bool_2 || (task_1 != null && !task_1.IsCompleted))
		{
			return;
		}
		button_2.Enabled = false;
		method_39();
		method_100();
		await smethod_5(task_3, "manual-start-transfer");
		if (method_16() == Enum0.Selected && method_6() && !bool_5)
		{
			if (method_91() switch
			{
				(Enum11)0 => method_92((Enum11)2) ? 1 : 0, 
				(Enum11)1 => method_93((Enum11)1, (Enum11)2) ? 1 : 0, 
				_ => 0, 
			} == 0)
			{
				if (!bool_7)
				{
					button_2.Enabled = true;
				}
			}
			else
			{
				await method_50(bool_23);
			}
		}
		else if (!bool_7)
		{
			button_2.Enabled = method_16() == Enum0.Selected && method_6();
		}
	}

	private Task method_50(bool bool_23)
	{
		if (method_16() == Enum0.Selected && method_6() && !bool_5)
		{
			if (method_91() != (Enum11)2)
			{
				return Task.CompletedTask;
			}
			if (task_1 != null && !task_1.IsCompleted)
			{
				return Task.CompletedTask;
			}
			Class148 @class = (class148_0 = new Class148(++long_1));
			class8_0 = Class8.class8_0;
			bool_4 = false;
			bool_6 = false;
			bool_3 = false;
			bool_2 = true;
			Task task_ = Task.Run((Func<Task>)method_146);
			@class.method_6(task_);
			task_1 = task_;
			button_2.Enabled = false;
			button_1.Enabled = true;
			method_24();
			method_25();
			this.smethod_25(10, trackBar_0.Value.ToString());
			method_55(@class, task_);
			GC.KeepAlive(bool_23);
			return Task.CompletedTask;
		}
		return Task.CompletedTask;
	}

	private Task method_51(bool bool_23)
	{
		long num = ((class148_0 == null) ? 0L : class148_0.method_0());
		return method_52(bool_23 ? Class8.smethod_5(num) : Class8.smethod_3(num));
	}

	private Task method_52(Class8 class8_1)
	{
		if (class8_1 == null)
		{
			throw new ArgumentNullException("request");
		}
		if (class8_1.method_1())
		{
			method_13();
		}
		long num = ((class148_0 == null) ? 0L : class148_0.method_0());
		if (!class8_1.method_1() && class8_1.method_0() != num)
		{
			return Task.CompletedTask;
		}
		if (class8_1.method_1() && class8_1.method_0() != num)
		{
			class8_1 = Class8.smethod_0(num);
		}
		bool flag;
		if ((flag = !bool_5 && long_3 == class8_1.method_0()) && (class8_1.method_4() || class8_1.method_5() || class8_1.method_6() || class8_1.method_3()) && !class8_1.method_1() && !class8_1.method_2())
		{
			return task_2;
		}
		if (flag && class8_1.method_2() && !bool_1)
		{
			return task_2;
		}
		if (flag && class8_1.method_1() && bool_7)
		{
			return task_2;
		}
		if (!class8_0.method_9() && class8_0.method_0() == num)
		{
			class8_0 = class8_0.method_12(class8_1);
		}
		else
		{
			class8_0 = class8_1;
		}
		if ((class8_1.method_4() || class8_1.method_6() || class8_1.method_2() || class8_1.method_1()) && class148_0 != null && class148_0.method_0() == class8_1.method_0())
		{
			class148_0.method_8();
		}
		if (class8_0.method_1())
		{
			bool_7 = true;
		}
		bool_6 = true;
		bool_3 = true;
		button_2.Enabled = false;
		button_1.Enabled = false;
		if (bool_5)
		{
			return task_2;
		}
		bool_5 = true;
		long_2 = class8_1.method_0();
		task_2 = method_53();
		return task_2;
	}

	private async Task method_53()
	{
		await Task.Yield();
		Class148 @class = class148_0;
		long num = @class?.method_0() ?? 0L;
		Task task_ = ((@class == null || @class.method_1() == null) ? (task_1 ?? Task.CompletedTask) : @class.method_1());
		Enum11 @enum = method_91();
		Task task_2 = task_3 ?? Task.CompletedTask;
		method_100();
		Class8 class2 = class8_0;
		try
		{
			Exception ex = await smethod_4(task_);
			class2 = method_58(num, class2);
			if (ex != null && @class != null)
			{
				Exception exception_ = @class.method_12(ex);
				@class.method_11((Enum5)3);
				method_57(Class8.smethod_2(num, exception_));
				class2 = class8_0;
			}
			switch (@enum)
			{
			case (Enum11)2:
			{
				Exception ex4 = await smethod_4(task_2);
				if (ex4 != null)
				{
					smethod_6("manual-pass", ex4);
				}
				class2 = method_58(num, class2);
				break;
			}
			case (Enum11)1:
			{
				Exception ex5 = await smethod_4(task_2);
				if (ex5 != null)
				{
					smethod_6("manual-pass", ex5);
				}
				class2 = method_58(num, class2);
				Exception ex6 = await smethod_4(task_);
				if (ex6 != null && @class != null)
				{
					Exception exception_3 = @class.method_12(ex6);
					method_57(Class8.smethod_2(num, exception_3));
				}
				class2 = method_58(num, class2);
				break;
			}
			default:
			{
				Exception ex2 = await smethod_4(task_2);
				if (ex2 != null)
				{
					smethod_6("manual-pass", ex2);
				}
				class2 = method_58(num, class2);
				Exception ex3 = await smethod_4(task_);
				if (ex3 != null && @class != null)
				{
					Exception exception_2 = @class.method_12(ex3);
					method_57(Class8.smethod_2(num, exception_2));
				}
				class2 = method_58(num, class2);
				break;
			}
			}
			if (@class != null && @class.method_2() == (Enum5)4)
			{
				Exception exception_4 = @class.method_13();
				method_57(Class8.smethod_2(num, exception_4));
				class2 = class8_0;
			}
			Exception ex7 = @class?.method_5();
			if (ex7 != null && @class.method_14(num, task_, ex7))
			{
				smethod_7(@class, task_, ex7);
			}
			await method_60("AttackStop", method_147);
			class2 = method_58(num, class2);
			method_59("Manage_Attack_Monster.Reset", Class412.smethod_15);
			method_59("FollowPartyMember.Reset", Class356.smethod_3);
			class2 = method_58(num, class2);
			method_59("Manage_Attack_Monster.ClearTarget", Class412.smethod_14);
			class2 = method_58(num, class2);
			method_59("Manage_Pick_Item.Reset", Class360.smethod_33);
			class2 = method_58(num, class2);
			method_59("Buff.Reset", Class342.smethod_2);
			class2 = method_58(num, class2);
			method_59("Manage_Follow_Pos.Reset", Class2.smethod_8);
			class2 = method_58(num, class2);
			method_59("Manage_Looper.Reset", Class188.smethod_17);
			class2 = method_58(num, class2);
			method_59("ReleaseSellDriver.Automatic", method_148);
			class2 = method_58(num, class2);
			method_59("ReleaseSellDriver.ManualPump", method_149);
			class2 = method_58(num, class2);
			method_59("Manage_Attack_Monster.NotFixZone", Class412.smethod_7);
			class2 = method_58(num, class2);
			await method_60("Manage_Attack_Monster.ShowZoneAsync", method_150);
			class2 = method_58(num, class2);
			bool_2 = false;
			method_59("ApplyZone", method_118);
			class2 = method_58(num, class2);
			if (!class2.method_1() && !bool_7)
			{
				if (class2.method_2())
				{
					bool_1 = false;
					if (timer_2 != null)
					{
						timer_2.Stop();
					}
					button_2.Enabled = false;
					button_1.Enabled = false;
					button_33.Enabled = true;
					button_12.Enabled = true;
					method_24();
				}
				else if (!class2.method_10())
				{
					button_2.Enabled = bool_1 && method_6() && !bool_7;
					button_1.Enabled = false;
					method_24();
					method_25();
				}
			}
			else
			{
				await method_62();
				class2 = method_58(num, class2);
			}
			if (class2.method_10())
			{
				button_2.Enabled = false;
				button_1.Enabled = false;
				for (int i = 0; i < 10; i++)
				{
					await method_61(i);
					class2 = method_58(num, class2);
					if (!class2.method_10())
					{
						break;
					}
				}
			}
		}
		catch (Exception ex8)
		{
			smethod_6("StopCoreAsync", ex8);
			if (@class != null)
			{
				Exception exception_5 = @class.method_12(ex8);
				method_57(Class8.smethod_2(num, exception_5));
			}
			class2 = method_58(num, class2);
			bool_2 = false;
			method_59("ApplyZone", method_118);
			if (!bool_7)
			{
				button_2.Enabled = bool_1 && method_6();
				button_1.Enabled = false;
			}
		}
		finally
		{
			class2 = method_58(num, class2);
			long_3 = num;
			bool_5 = false;
			if (!class2.method_1() && !class2.method_2() && !class2.method_10())
			{
				bool_6 = false;
			}
			if (!bool_7)
			{
				class8_0 = Class8.class8_0;
			}
		}
		if (class2.method_10() && !bool_7 && @class == class148_0 && @class != null && @class.method_0() == num && bool_1 && method_6())
		{
			await method_49(bool_23: false);
		}
	}

	internal void method_54(Class148 class148_1)
	{
		if (class148_1 != null && class148_1 == class148_0 && class148_1.method_0() == class148_0.method_0())
		{
			bool_4 = true;
		}
	}

	private async Task method_55(Class148 class148_1, Task task_4)
	{
		Exception ex = await smethod_4(task_4);
		if (class148_1 != class148_0 || task_4 != task_1 || task_4 != class148_1.method_1())
		{
			return;
		}
		if (ex != null)
		{
			Exception exception_ = class148_1.method_12(ex);
			class148_1.method_11((Enum5)3);
			if (!method_56(class148_1.method_0()))
			{
				await method_52(Class8.smethod_2(class148_1.method_0(), exception_));
			}
		}
		else if (class148_1.method_2() != (Enum5)2 || !class148_1.method_3() || class148_1.method_4() || method_56(class148_1.method_0()))
		{
			if (class148_1.method_2() == (Enum5)0 || class148_1.method_2() == (Enum5)4)
			{
				class148_1.method_11((Enum5)4);
				Exception exception_2 = class148_1.method_13();
				if (!method_56(class148_1.method_0()))
				{
					await method_52(Class8.smethod_2(class148_1.method_0(), exception_2));
				}
			}
		}
		else
		{
			await method_52(Class8.smethod_4(class148_1.method_0()));
		}
	}

	private bool method_56(long long_16)
	{
		if (!class8_0.method_9() && class8_0.method_0() == long_16)
		{
			return true;
		}
		if (bool_5 && long_2 == long_16)
		{
			return true;
		}
		return long_3 == long_16;
	}

	private void method_57(Class8 class8_1)
	{
		if (class8_0.method_9())
		{
			class8_0 = class8_1;
		}
		else if (class8_0.method_0() == class8_1.method_0())
		{
			class8_0 = class8_0.method_12(class8_1);
		}
	}

	private Class8 method_58(long long_16, Class8 class8_1)
	{
		if (!class8_0.method_9() && class8_0.method_0() == long_16)
		{
			return class8_0;
		}
		return class8_1;
	}

	private static async Task<Exception> smethod_4(Task task_4)
	{
		if (task_4 != null)
		{
			try
			{
				await task_4;
				return null;
			}
			catch (Exception result)
			{
				return result;
			}
		}
		return null;
	}

	private static async Task smethod_5(Task task_4, string string_8)
	{
		Exception ex = await smethod_4(task_4);
		if (ex != null)
		{
			smethod_6(string_8, ex);
		}
	}

	private void method_59(string string_8, Action action_2)
	{
		try
		{
			action_1?.Invoke(string_8);
			action_2();
		}
		catch (Exception exception_)
		{
			smethod_6(string_8, exception_);
		}
	}

	private async Task method_60(string string_8, Func<Task> func_3)
	{
		try
		{
			action_1?.Invoke(string_8);
			await func_3();
		}
		catch (Exception exception_)
		{
			smethod_6(string_8, exception_);
		}
	}

	private Task method_61(int int_12)
	{
		Func<int, Task> func = func_1;
		if (func != null)
		{
			return func(int_12);
		}
		return Task.Delay(200);
	}

	private async Task method_62()
	{
		Class160 @class = new Class160
		{
			gform0_0 = this
		};
		method_13();
		method_59("SellTimer.Dispose", @class.method_0);
		method_59("ReadoutTimer.Dispose", @class.method_1);
		Task[] array;
		lock (object_0)
		{
			@class.class119_0 = class119_1;
			array = task_0;
			class119_1 = null;
			task_0 = new Task[0];
		}
		for (int i = 0; i < array.Length; i++)
		{
			Exception ex = await smethod_4(array[i]);
			if (ex != null)
			{
				smethod_6("SessionOperation", ex);
			}
		}
		if (@class.class119_0 != null)
		{
			method_59("Session.OnSnapshot.Unsubscribe", @class.method_2);
			method_59("Session.OnDetached.Unsubscribe", @class.method_3);
			method_59("Session.StopStreaming", @class.class119_0.method_95);
			method_59("Session.Dispose", @class.method_4);
		}
	}

	private static void smethod_6(string string_8, Exception exception_0)
	{
	}

	private static void smethod_7(Class148 class148_1, Task task_4, Exception exception_0)
	{
	}

	private async Task<Class164<bool>> method_63(Class119 class119_5, long long_16, string string_8, string string_9, int int_12)
	{
		Class155 @class = new Class155();
		@class.string_0 = string_8;
		@class.string_1 = string_9;
		@class.int_0 = int_12;
		Task<bool> task = method_11("Run", class119_5, long_16, @class.method_0);
		if (task == null)
		{
			return new Class164<bool>(bool_1: false, gparam_1: false);
		}
		bool gparam_ = await task;
		return new Class164<bool>(method_10(class119_5, long_16), gparam_);
	}

	private async Task<Class164<bool>> method_64(Class119 class119_5, long long_16, string string_8, string string_9, int int_12)
	{
		Class161 @class = new Class161();
		@class.string_0 = string_8;
		@class.string_1 = string_9;
		@class.int_0 = int_12;
		Task<bool> task = method_11("Attach", class119_5, long_16, @class.method_0);
		if (task == null)
		{
			return new Class164<bool>(bool_1: false, gparam_1: false);
		}
		bool gparam_ = await task;
		return new Class164<bool>(method_10(class119_5, long_16), gparam_);
	}

	private async Task<Class164<string>> method_65(Class119 class119_5, long long_16)
	{
		Class152 @class = new Class152
		{
			gform0_0 = this,
			long_0 = long_16
		};
		Task<string> task = method_11("Census", class119_5, @class.long_0, @class.method_0);
		if (task == null)
		{
			return new Class164<string>(bool_1: false, null);
		}
		string gparam_ = await task;
		return new Class164<string>(method_10(class119_5, @class.long_0) && class119_5.method_10(), gparam_);
	}

	private string method_66(Class119 class119_5, long long_16, int int_12)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		while (stopwatch.ElapsedMilliseconds < int_12 && method_10(class119_5, long_16) && class119_5.method_10())
		{
			long val = int_12 - stopwatch.ElapsedMilliseconds;
			int int_13 = (int)Math.Min(1000L, Math.Max(1L, val));
			List<Class403> list = class119_5.method_92(int_13);
			if (!method_10(class119_5, long_16) || !class119_5.method_10())
			{
				break;
			}
			if (list != null)
			{
				foreach (Class403 item in list)
				{
					if (item.method_2() && class119_5.dictionary_2.TryGetValue(item.uint_0.ToString(), out var value) && !string.IsNullOrEmpty(value))
					{
						if (method_10(class119_5, long_16) && class119_5.method_10())
						{
							return value;
						}
						return null;
					}
				}
			}
			if (!method_10(class119_5, long_16) || !class119_5.method_10())
			{
				break;
			}
			val = int_12 - stopwatch.ElapsedMilliseconds;
			if (val <= 0L)
			{
				break;
			}
			Thread.Sleep((int)Math.Min(75L, val));
		}
		return null;
	}

	private async Task method_67()
	{
		Class157 @class = new Class157();
		if (bool_12 || !method_9(out @class.class119_0, out var long_))
		{
			return;
		}
		if (@class.class119_0 == null)
		{
			Class429.smethod_0(this, "The session is not available.", "Run");
			return;
		}
		@class.class85_0 = class190_0.method_0();
		if (@class.class85_0 == null)
		{
			Class429.smethod_0(this, "Pick an LDPlayer title first.", "Run");
			return;
		}
		bool_12 = true;
		button_12.Enabled = false;
		bool flag = false;
		try
		{
			long long_2 = ++long_4;
			enum3_0 = Enum3.Unknown;
			method_24();
			Class82 class2 = await method_23(@class.class85_0, long_2);
			if (!method_22(@class.class85_0, long_2) || !method_10(@class.class119_0, long_))
			{
				return;
			}
			enum3_0 = class2.enum3_0;
			method_24();
			if (class2.enum3_0 == Enum3.Unknown)
			{
				Class429.smethod_0(this, class2.string_0, "Runner check");
				return;
			}
			if (enum3_0 == Enum3.RunnerMissing)
			{
				Class429.smethod_0(this, Class392.smethod_0(enum3_0, method_16()).string_1, "Setup");
				return;
			}
			if (enum3_0 == Enum3.Stale)
			{
				Tuple<Class87, bool> tuple = await Task.Run((Func<Tuple<Class87, bool>>)@class.method_0);
				if (!method_22(@class.class85_0, long_2) || !method_10(@class.class119_0, long_))
				{
					return;
				}
				if (tuple.Item1.enum1_0 == Enum1.Unknown)
				{
					Class429.smethod_0(this, "Runner activity could not be verified: " + tuple.Item1.string_0, "Setup");
					return;
				}
				if (tuple.Item1.enum1_0 != Enum1.Healthy)
				{
					if (tuple.Item2)
					{
						Class429.smethod_0(this, "A runner process is still active. Stop it before setup.", "Setup");
						return;
					}
					using (Form0 form = new Form0(@class.class85_0.string_2, @class.class85_0.string_1))
					{
						form.ShowDialog(this);
						if (!form.method_0())
						{
							return;
						}
					}
					class2 = await method_23(@class.class85_0, long_2);
					if (!method_22(@class.class85_0, long_2) || !method_10(@class.class119_0, long_))
					{
						return;
					}
					enum3_0 = class2.enum3_0;
					method_24();
					if (enum3_0 != Enum3.Current)
					{
						Class429.smethod_0(this, class2.string_0, "Setup");
						return;
					}
				}
			}
			if (!Class357.smethod_0())
			{
				Class429.smethod_0(this, "Offsets not loaded - " + LocalOffsets.LastError, "Run");
				return;
			}
			button_33.Enabled = false;
			flag = true;
			bool flag2 = false;
			try
			{
				Class164<bool> class3 = await method_63(@class.class119_0, long_, @class.class85_0.string_2, @class.class85_0.string_1, @class.class85_0.int_1);
				if (method_10(@class.class119_0, long_) && class3.method_0())
				{
					flag2 = class3.method_2();
					if (!flag2)
					{
						Class429.smethod_0(this, "Run failed - see the debug log.", "Run");
					}
				}
			}
			catch (Exception)
			{
				if (method_10(@class.class119_0, long_))
				{
					Class429.smethod_0(this, "Run failed - see the debug log.", "Run");
				}
			}
			finally
			{
				if (method_10(@class.class119_0, long_))
				{
					method_24();
					button_12.Enabled = !flag2;
					button_33.Enabled = true;
					button_2.Enabled = false;
					button_1.Enabled = false;
				}
			}
		}
		finally
		{
			if (!flag && !base.IsDisposed && class190_0.method_0() == @class.class85_0 && method_10(@class.class119_0, long_))
			{
				method_24();
				button_12.Enabled = true;
			}
			bool_12 = false;
		}
	}

	private async Task<bool> method_68(Class119 class119_5, long long_16)
	{
		if (class119_5 == null)
		{
			Class429.smethod_0(this, "Press Run first.", "Select");
			return false;
		}
		if (method_10(class119_5, long_16))
		{
			try
			{
				if (!class119_5.method_10())
				{
					Class85 @class = class190_0.method_0();
					if (@class == null)
					{
						Class429.smethod_0(this, "Pick an LDPlayer title first.", "Select");
						return false;
					}
					if (!Class357.smethod_0())
					{
						Class429.smethod_0(this, "Offsets not loaded - " + LocalOffsets.LastError, "Select");
						return false;
					}
					Class164<bool> class2 = await method_64(class119_5, long_16, @class.string_2, @class.string_1, @class.int_1);
					if (!method_10(class119_5, long_16))
					{
						return false;
					}
					if (!class2.method_0())
					{
						return false;
					}
					if (!class2.method_2())
					{
						Class429.smethod_0(this, "No agent in the game - press Run first.", "Select");
						return false;
					}
				}
				Class164<string> class3 = await method_65(class119_5, long_16);
				if (!method_10(class119_5, long_16))
				{
					return false;
				}
				if (!class119_5.method_10())
				{
					return false;
				}
				if (!class3.method_0())
				{
					return false;
				}
				string value = class3.method_2();
				if (string.IsNullOrEmpty(value))
				{
					Class429.smethod_0(this, "Could not read the hero name - try again.", "Select");
					return false;
				}
				class11_0.method_8(value, this);
				class67_0.method_8(value);
				method_87();
				class119_5.method_93();
				string_0 = value;
				method_28();
				return true;
			}
			catch (Exception)
			{
				if (method_10(class119_5, long_16))
				{
					Class429.smethod_0(this, "Select failed - see the debug log.", "Select");
				}
				return false;
			}
		}
		return false;
	}

	private void method_69()
	{
		dataGridView_27.AllowUserToAddRows = false;
		button_53.Click -= button_53_Click_1;
		button_53.Click += button_53_Click_1;
		button_58.Click -= button_58_Click_1;
		button_58.Click += button_58_Click_1;
		button_56.Click -= button_56_Click_1;
		button_56.Click += button_56_Click_1;
	}

	private void button_53_Click_1(object sender, EventArgs e)
	{
		method_70();
	}

	private void button_58_Click_1(object sender, EventArgs e)
	{
		method_71();
	}

	private void button_56_Click_1(object sender, EventArgs e)
	{
		method_72();
	}

	private void method_70()
	{
		if (class67_0 != null)
		{
			class67_0.method_11(dataGridView_27, "all_items_used.json");
			Class388.smethod_1(dataGridView_27, dataGridView_25, class67_0);
		}
	}

	private void method_71()
	{
		Class388.smethod_0(dataGridView_27, dataGridView_25, class67_0);
	}

	private void method_72()
	{
		Class388.smethod_0(dataGridView_25, dataGridView_27, class67_0);
	}

	private void method_73()
	{
		button_52.Click -= button_52_Click_1;
		button_52.Click += button_52_Click_1;
		textBox_33.TextChanged -= textBox_33_TextChanged_1;
		textBox_33.TextChanged += textBox_33_TextChanged_1;
		button_54.Click -= button_54_Click_1;
		button_54.Click += button_54_Click_1;
	}

	private void button_52_Click_1(object sender, EventArgs e)
	{
		method_75();
	}

	private void textBox_33_TextChanged_1(object sender, EventArgs e)
	{
		method_74();
	}

	private void button_54_Click_1(object sender, EventArgs e)
	{
		method_76();
	}

	private void method_74()
	{
		list_0 = null;
		int_1 = -1;
		label_77.Text = "Result";
	}

	private void method_75()
	{
		if (list_0 == null)
		{
			string text = textBox_33.Text;
			if (text == null || text.Trim().Length == 0)
			{
				return;
			}
			list_0 = Class44.smethod_0(text, dataGridView_27, dataGridView_25);
			int_1 = -1;
		}
		dataGridView_27.ClearSelection();
		dataGridView_25.ClearSelection();
		int_1 = Class44.smethod_2(int_1, list_0.Count);
		if (int_1 < 0)
		{
			label_77.Text = Class44.smethod_1(0, 0);
			return;
		}
		DataGridViewRow dataGridViewRow = list_0[int_1];
		if (!Class44.smethod_3(dataGridViewRow))
		{
			method_74();
			return;
		}
		dataGridViewRow.Selected = true;
		dataGridViewRow.DataGridView.FirstDisplayedScrollingRowIndex = dataGridViewRow.Index;
		label_77.Text = Class44.smethod_1(int_1 + 1, list_0.Count);
	}

	private void method_76()
	{
		if (Class388.smethod_3(dataGridView_27, dataGridView_25, textBox_33.Text, class67_0))
		{
			method_74();
		}
	}

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		method_77();
	}

	private void method_77()
	{
		if (!bool_13)
		{
			bool_13 = true;
			dataGridView_25.AllowUserToAddRows = false;
			button_61.Click -= button_61_Click_1;
			button_61.Click += button_61_Click_1;
			button_60.Click -= button_60_Click_1;
			button_60.Click += button_60_Click_1;
			dataGridView_22.CellDoubleClick -= dataGridView_22_CellDoubleClick_1;
			dataGridView_22.CellDoubleClick += dataGridView_22_CellDoubleClick_1;
			button_82.Click -= button_82_Click_1;
			button_82.Click += button_82_Click_1;
			dataGridView_25.RowsAdded -= dataGridView_25_RowsAdded;
			dataGridView_25.RowsAdded += dataGridView_25_RowsAdded;
			dataGridView_25.RowsRemoved -= dataGridView_25_RowsRemoved;
			dataGridView_25.RowsRemoved += dataGridView_25_RowsRemoved;
			method_69();
			method_73();
			method_84();
			method_86();
			method_89();
			method_105();
			method_95();
		}
	}

	private void button_61_Click_1(object sender, EventArgs e)
	{
		method_78();
	}

	private void button_60_Click_1(object sender, EventArgs e)
	{
		method_79();
	}

	private void dataGridView_22_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
	{
		method_80(e.RowIndex);
	}

	private void button_82_Click_1(object sender, EventArgs e)
	{
		method_81();
	}

	private void dataGridView_25_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		method_82();
	}

	private void dataGridView_25_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		method_82();
	}

	private void method_78()
	{
		List<string> list = Class55.smethod_0(dataGridView_22);
		if (list.Count != 0)
		{
			Class55.smethod_1(dataGridView_25, list, class67_0);
			method_82();
		}
	}

	private void method_79()
	{
		List<string> list = Class55.smethod_0(dataGridView_22);
		if (list.Count != 0)
		{
			Class55.smethod_2(dataGridView_25, list, class67_0);
			method_82();
		}
	}

	private void method_80(int int_12)
	{
		if (int_12 >= 0 && int_12 < dataGridView_22.Rows.Count)
		{
			string text = Class96.smethod_3(dataGridView_22.Rows[int_12]);
			if (text.Length != 0)
			{
				Class55.smethod_3(dataGridView_25, text, class67_0);
				method_82();
			}
		}
	}

	private void method_81()
	{
		if (form7_1 != null)
		{
			form7_1.Activate();
			return;
		}
		form7_1 = new Form7(dataGridView_25, class67_0);
		form7_1.FormClosed += form7_1_FormClosed;
		form7_1.Show(this);
		long_14 = -1L;
	}

	private void form7_1_FormClosed(object sender, FormClosedEventArgs e)
	{
		if (sender is Form form)
		{
			form.FormClosed -= form7_1_FormClosed;
		}
		form7_1 = null;
	}

	private void method_82()
	{
		if (tabControl_0.SelectedTab == tabPage_10 || tabControl_0.SelectedTab == tabPage_12 || form7_1 != null)
		{
			int int_ = Class96.smethod_4(dataGridView_22, dataGridView_25);
			method_83(int_);
			if (form7_1 != null)
			{
				form7_1.method_1(dataGridView_25);
			}
		}
	}

	private void method_83(int int_12)
	{
		if (string_1 == null)
		{
			string text = label_85.Text;
			int num = text?.LastIndexOf("0 / 0", StringComparison.Ordinal) ?? (-1);
			string_1 = ((num > 0) ? text.Substring(0, num) : string.Empty);
		}
		int num2 = 0;
		for (int i = 0; i < dataGridView_22.Rows.Count; i++)
		{
			if (Class96.smethod_3(dataGridView_22.Rows[i]).Length != 0)
			{
				num2++;
			}
		}
		string text2 = string_1 + int_12.ToString(CultureInfo.InvariantCulture) + " / " + num2.ToString(CultureInfo.InvariantCulture);
		if (label_85.Text != text2)
		{
			label_85.Text = text2;
		}
	}

	private void method_84()
	{
		button_78.Click -= button_78_Click_1;
		button_78.Click += button_78_Click_1;
	}

	private void button_78_Click_1(object sender, EventArgs e)
	{
		method_85();
	}

	private void method_85()
	{
		Class145 @class = ((class119_0 == null) ? null : class119_0.method_51());
		bool bool_ = class119_0 != null && class119_0.method_28();
		bool bool_2 = @class != null && @class.method_0() != null;
		if (!smethod_8(method_16(), bool_, bool_2))
		{
			MessageBox.Show(this, "There is no live character position to record.\r\n\r\nPress Select and wait for the position readout to fill, then stand where the character should walk to and press this again.", "Set NPC position", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		Class83 class2 = @class.method_0();
		textBox_57.Text = Class440.smethod_5(class2.float_0, class2.float_1, class2.float_2);
	}

	internal static bool smethod_8(Enum0 enum0_0, bool bool_23, bool bool_24)
	{
		if (enum0_0 != Enum0.Selected && enum0_0 != Enum0.Started)
		{
			return false;
		}
		if (!bool_23)
		{
			return false;
		}
		return bool_24;
	}

	private void method_86()
	{
		button_62.Click -= button_62_Click_1;
		button_62.Click += button_62_Click_1;
		comboBox_21.DropDown -= comboBox_21_DropDown;
		comboBox_21.DropDown += comboBox_21_DropDown;
		method_87();
	}

	private void button_62_Click_1(object sender, EventArgs e)
	{
		method_88();
	}

	private void comboBox_21_DropDown(object sender, EventArgs e)
	{
		method_87();
	}

	private void method_87()
	{
		if (class67_0 == null)
		{
			return;
		}
		string text = comboBox_21.SelectedItem?.ToString();
		List<string> list = Class176.smethod_3(class67_0.method_2(), "Want_Sell.json", class67_0.method_1());
		comboBox_21.BeginUpdate();
		try
		{
			comboBox_21.Items.Clear();
			for (int i = 0; i < list.Count; i++)
			{
				comboBox_21.Items.Add(list[i]);
			}
			if (text != null)
			{
				int num = comboBox_21.Items.IndexOf(text);
				if (num >= 0)
				{
					comboBox_21.SelectedIndex = num;
				}
			}
		}
		finally
		{
			comboBox_21.EndUpdate();
		}
	}

	private void method_88()
	{
		if (class67_0 == null)
		{
			return;
		}
		object selectedItem = comboBox_21.SelectedItem;
		if (selectedItem == null)
		{
			return;
		}
		string text = selectedItem.ToString();
		if (text.Length != 0)
		{
			string path = text + "_Want_Sell.json";
			if (!File.Exists(Path.Combine(class67_0.method_2(), path)))
			{
				Class429.smethod_0(this, text + "'s sell list is no longer in the config folder.\r\n\r\nThe list of characters has been refreshed.", "Load sell list");
				method_87();
				return;
			}
			List<string> list = Class67.smethod_2(class67_0.method_18(path), Class67.smethod_1(dataGridView_25));
			int int_ = Class388.smethod_4(dataGridView_25, list, class67_0);
			Class388.smethod_1(dataGridView_27, dataGridView_25, class67_0);
			Class429.smethod_0(this, smethod_9(text, list.Count, int_), "Load sell list");
		}
	}

	internal static string smethod_9(string string_8, int int_12, int int_13)
	{
		if (int_12 <= 0)
		{
			return "Nothing was read from " + string_8 + "'s sell list.\r\n\r\nThe file is either empty or damaged. Nothing on this list was changed.";
		}
		if (int_13 <= 0)
		{
			return "Every item on " + string_8 + "'s sell list is already on this one.\r\n\r\nNothing was changed.";
		}
		string text = "Added " + smethod_10(int_13) + " from " + string_8 + "'s sell list.";
		int num = int_12 - int_13;
		if (num > 0)
		{
			text = text + "\r\n\r\n" + smethod_10(num) + " already on this list " + ((num == 1) ? "was" : "were") + " skipped.";
		}
		return text;
	}

	private static string smethod_10(int int_12)
	{
		string text = int_12.ToString(CultureInfo.InvariantCulture);
		if (int_12 != 1)
		{
			return text + " items";
		}
		return text + " item";
	}

	private void method_89()
	{
		button_85.Click -= button_85_Click;
		button_85.Click += button_85_Click;
	}

	private void button_85_Click(object sender, EventArgs e)
	{
		method_90();
	}

	private void method_90()
	{
		Class145 @class = ((class119_0 == null) ? null : class119_0.method_51());
		bool bool_ = class119_0 != null && class119_0.method_28();
		bool bool_2 = @class != null && @class.method_0() != null;
		if (!smethod_8(method_16(), bool_, bool_2))
		{
			MessageBox.Show(this, "There is no live view of the world to read NPCs from.\r\n\r\nPress Select and wait for the position readout to fill, then press this again.", "Pick NPC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		List<Class447.Class452> list = Class447.smethod_10(@class, @class.method_0());
		if (list.Count == 0)
		{
			MessageBox.Show(this, "No NPC is in range.\r\n\r\nStand near the shop NPC - close enough for it to be drawn - and press this again.", "Pick NPC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		if (form2_0 != null)
		{
			form2_0.method_0(list);
			form2_0.Activate();
			return;
		}
		form2_0 = new Form2(textBox_56);
		form2_0.method_0(list);
		form2_0.FormClosed += form2_0_FormClosed;
		form2_0.Show(this);
	}

	private void form2_0_FormClosed(object sender, FormClosedEventArgs e)
	{
		if (sender is Form form)
		{
			form.FormClosed -= form2_0_FormClosed;
		}
		form2_0 = null;
	}

	internal Enum11 method_91()
	{
		return (Enum11)Volatile.Read(ref int_3);
	}

	internal bool method_92(Enum11 enum11_0)
	{
		if (enum11_0 == (Enum11)0)
		{
			return false;
		}
		return Interlocked.CompareExchange(ref int_3, (int)enum11_0, 0) == 0;
	}

	private bool method_93(Enum11 enum11_0, Enum11 enum11_1)
	{
		if (enum11_0 != 0 && enum11_1 != 0)
		{
			return Interlocked.CompareExchange(ref int_3, (int)enum11_1, (int)enum11_0) == (int)enum11_0;
		}
		return false;
	}

	internal void method_94(Enum11 enum11_0)
	{
		if (enum11_0 != 0)
		{
			Interlocked.CompareExchange(ref int_3, 0, (int)enum11_0);
		}
	}

	private void method_95()
	{
		button_59.Visible = true;
		button_59.Click -= button_59_Click_1;
		button_59.Click += button_59_Click_1;
	}

	private void button_59_Click_1(object sender, EventArgs e)
	{
		method_96();
	}

	private void method_96()
	{
		Enum0 @enum = method_16();
		bool bool_ = class119_0 != null && class119_0.method_28();
		bool bool_2 = class119_0 != null && class119_0.method_51().method_0() != null;
		bool flag = class119_0 != null && class119_0.method_10();
		bool flag2 = task_1 != null && !task_1.IsCompleted;
		bool flag3 = checkBox_39.Checked;
		string text = "phase=" + @enum.ToString() + " sellAvailable=" + Class357.smethod_40() + " streaming=" + bool_ + " hasSelf=" + bool_2 + " readyRequest=" + flag + " botRunning=" + flag2 + " botEnabled=" + flag3;
		smethod_11("button-click", text);
		if (!Class357.smethod_40())
		{
			smethod_11("button-rejected", "reason=offsets-unavailable " + text);
			Class429.smethod_0(this, "NPC sale offsets are not available for this login.", "Test NPC sale");
		}
		else if (!smethod_8(method_16(), bool_, bool_2))
		{
			smethod_11("button-rejected", "reason=live-snapshot-unavailable " + text);
			Class429.smethod_0(this, "There is no live character snapshot. Press Run, then Select and Start before testing.", "Test NPC sale");
		}
		else if (!method_92((Enum11)1))
		{
			Class429.smethod_0(this, "A manual NPC sale is already running.", "Test NPC sale");
		}
		else
		{
			method_97();
		}
	}

	private static void smethod_11(string string_8, string string_9)
	{
	}

	private void method_97()
	{
		if (method_91() == (Enum11)1)
		{
			if (timer_1 == null)
			{
				timer_1 = new System.Windows.Forms.Timer();
				timer_1.Interval = 300;
				timer_1.Tick += timer_1_Tick;
			}
			int_2 = 0;
			timer_1.Start();
		}
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (method_91() == (Enum11)1 && task_3.IsCompleted)
		{
			method_99(task_3 = method_98());
		}
	}

	private async Task method_98()
	{
		if (method_7() == null)
		{
			method_101();
			return;
		}
		if (method_5().method_0() == null)
		{
			method_101();
			return;
		}
		if (method_5().method_47() == 0)
		{
			int_2++;
			if (int_2 > 10)
			{
				smethod_11("pump-aborted", "reason=bag-cap-timeout");
				method_101();
			}
			return;
		}
		int_2 = 0;
		try
		{
			if (func_2 == null)
			{
				await GClass15.smethod_0(this, 1);
			}
			else
			{
				await func_2();
			}
		}
		finally
		{
			method_100();
			method_94((Enum11)1);
		}
	}

	private async Task method_99(Task task_4)
	{
		try
		{
			await task_4;
		}
		catch (Exception)
		{
		}
	}

	private void method_100()
	{
		if (timer_1 != null)
		{
			timer_1.Stop();
		}
	}

	private void method_101()
	{
		method_100();
		method_94((Enum11)1);
	}

	private void method_102()
	{
		lock (object_1)
		{
			hashSet_1.Clear();
			hashSet_2.Clear();
		}
	}

	internal bool method_103(int int_12, out List<string> list_1)
	{
		lock (object_1)
		{
			HashSet<string> hashSet = null;
			switch (int_12)
			{
			case 9:
				hashSet = hashSet_1;
				break;
			case 10:
				hashSet = hashSet_2;
				break;
			}
			list_1 = ((hashSet == null) ? new List<string>() : new List<string>(hashSet));
		}
		return list_1.Count > 0;
	}

	private void method_104(int int_12)
	{
		Class156 @class = new Class156();
		@class.gform0_0 = this;
		@class.int_0 = int_12;
		if (method_9(out @class.class119_0, out @class.long_0) && @class.class119_0 != null && @class.class119_0.method_28() && @class.class119_0.method_10() && bool_1)
		{
			HashSet<string> hashSet = ((@class.int_0 == 9) ? hashSet_1 : hashSet_2);
			lock (object_1)
			{
				@class.hashSet_0 = new HashSet<string>(hashSet, StringComparer.OrdinalIgnoreCase);
			}
			Form9 form = new Form9(@class.int_0, @class.hashSet_0, @class.method_0);
			try
			{
				form.method_0();
				form.ShowDialog(this);
			}
			finally
			{
				((IDisposable)form).Dispose();
			}
			if (method_10(@class.class119_0, @class.long_0) && @class.class119_0.method_28())
			{
				lock (object_1)
				{
					hashSet.Clear();
					hashSet.UnionWith(@class.hashSet_0);
				}
			}
		}
		else
		{
			MessageBox.Show(this, "Press Select and wait for the player census.", "Party", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	private void method_105()
	{
		textBox_62.ReadOnly = true;
		button_86.Click -= button_86_Click;
		button_86.Click += button_86_Click;
	}

	private void button_86_Click(object sender, EventArgs e)
	{
		method_106();
	}

	private void method_106()
	{
		Class145 @class = ((class119_0 == null) ? null : class119_0.method_51());
		bool bool_ = class119_0 != null && class119_0.method_28();
		bool bool_2 = @class != null && @class.method_0() != null;
		if (!smethod_8(method_16(), bool_, bool_2))
		{
			Class429.smethod_0(this, "There is no live view of the world to read the friend list from.\r\n\r\nPress Select and wait for the position readout to fill, then press this again.", "Pick friend");
			return;
		}
		if (!Class357.smethod_66())
		{
			Class429.smethod_0(this, "This build cannot read the friend list.\r\n\r\nThe friend offsets did not reach the offset store the launcher reads, so the agent's friend tier never armed and no reply would come back. Nothing else on this tab is affected - the sell list, the NPC picker and the waypoint all still work.", "Pick friend");
			return;
		}
		Form6 form = new Form6(class119_0);
		Class81.Enum4 @enum;
		IReadOnlyList<Struct140> ireadOnlyList_;
		int num;
		string string_;
		try
		{
			form.ShowDialog(this);
			@enum = form.method_0();
			ireadOnlyList_ = form.method_2();
			num = form.method_4();
			string_ = form.method_6();
		}
		finally
		{
			((IDisposable)form).Dispose();
		}
		switch (@enum)
		{
		case (Class81.Enum4)2:
			Class429.smethod_0(this, "This character has no friends on its list.\r\n\r\nAdd someone in the game's own friend window, then press this again.", "Pick friend");
			break;
		case (Class81.Enum4)4:
			Class429.smethod_0(this, "The game did not answer with the friend list in time.\r\n\r\nThe list was asked for and the server has not sent it back. Open the game's own friend window once so the client fills its list, then press this again.", "Pick friend");
			break;
		case (Class81.Enum4)3:
			Class429.smethod_0(this, "The friend list could not be read.\r\n\r\n" + smethod_12(string_), "Pick friend");
			break;
		case (Class81.Enum4)1:
			if (form3_0 != null)
			{
				form3_0.method_0(ireadOnlyList_, num);
				form3_0.Activate();
				break;
			}
			form3_0 = new Form3(textBox_62);
			form3_0.method_0(ireadOnlyList_, num);
			form3_0.FormClosed += form3_0_FormClosed;
			form3_0.Show(this);
			break;
		}
	}

	internal static string smethod_12(string string_8)
	{
		if (string.IsNullOrEmpty(string_8))
		{
			return "the agent refused the friend list without saying why";
		}
		return string_8;
	}

	private void form3_0_FormClosed(object sender, FormClosedEventArgs e)
	{
		if (sender is Form form)
		{
			form.FormClosed -= form3_0_FormClosed;
		}
		form3_0 = null;
	}

	private void method_107(Enum0 enum0_0)
	{
		if (timer_2 == null)
		{
			return;
		}
		if ((enum0_0 == Enum0.Selected || enum0_0 == Enum0.Started) && class119_0 != null)
		{
			if (class64_0 == null)
			{
				try
				{
					class64_0 = new Class64();
				}
				catch (Exception)
				{
				}
			}
			class119_0.method_94();
			timer_2.Start();
			return;
		}
		if (class119_0 != null)
		{
			class119_0.method_95();
		}
		timer_2.Stop();
		if (class64_0 != null)
		{
			class64_0.Dispose();
			class64_0 = null;
		}
		class102_0.method_1();
		long_6 = -1000L;
		long_7 = -1000L;
		long_12 = -1L;
	}

	private void method_108(object sender, EventArgs e)
	{
		if (class119_0 == null)
		{
			return;
		}
		method_28();
		Class145 @class = class119_0.method_51();
		this.smethod_25(120, Class38.smethod_3(@class) ?? "Leader");
		Class83 class2 = @class.method_0();
		if (class2 != null)
		{
			smethod_13(gclass12_0, class2.ushort_0, class2.ushort_1);
			smethod_13(gclass12_1, class2.ushort_2, class2.ushort_3);
			smethod_13(gclass12_2, class2.ushort_4, class2.ushort_5);
			this.smethod_25(11, Class440.smethod_3(class2.float_0, class2.float_2));
			if (class119_0.method_120())
			{
				long elapsedMilliseconds = stopwatch_0.ElapsedMilliseconds;
				if (!method_111(checkBox_14, comboBox_28, textBox_2, class2.ushort_0, class2.ushort_1, ref long_8, elapsedMilliseconds) && !method_111(checkBox_13, comboBox_30, textBox_1, class2.ushort_2, class2.ushort_3, ref long_9, elapsedMilliseconds))
				{
					method_111(checkBox_12, comboBox_29, textBox_0, class2.ushort_4, class2.ushort_5, ref long_10, elapsedMilliseconds);
				}
			}
			method_41(class2);
		}
		method_112(@class);
		if (gclass12_4 != null)
		{
			gclass12_4.Visible = checkBox_44.Checked;
			if (checkBox_44.Checked)
			{
				ushort? num = @class.method_24().nullable_0;
				int num2 = (num.HasValue ? GClass7.smethod_7(num.Value) : 0);
				gclass12_4.method_1(num2, num.HasValue ? ("Pet: " + num2 + "/100") : "Pet: --");
			}
		}
		method_114(@class);
		Class91.smethod_10(this, @class, class119_0.ValueTuple_0);
		Class91.smethod_12(this, Class342.smethod_6(), Class342.smethod_10());
		long elapsedMilliseconds2 = stopwatch_0.ElapsedMilliseconds;
		if (Class91.smethod_6(long_12, elapsedMilliseconds2))
		{
			long_12 = elapsedMilliseconds2;
			class119_0.method_166(3);
		}
		(ushort, ushort)[] valueTuple_ = class119_0.ValueTuple_0;
		bool flag;
		if (!(flag = Class91.smethod_7(method_16() == Enum0.Started, checkBox_39.Checked, class119_0.method_139(), Class342.smethod_7())))
		{
			long_13 = -1L;
		}
		if (flag)
		{
			for (int i = 1; i <= 10; i++)
			{
				bool_14[i] = this.smethod_21(Class91.smethod_0(i));
			}
		}
		List<(ushort, ushort)> list = Class91.smethod_9(bool_14, valueTuple_);
		if (Class91.smethod_8(flag, valueTuple_, list.Count, long_13, elapsedMilliseconds2))
		{
			long_13 = elapsedMilliseconds2;
			class119_0.method_174(list);
		}
		method_118();
		method_119();
		method_120();
		method_47();
		if (++int_7 >= 10)
		{
			int_7 = 0;
			method_113(@class);
		}
	}

	private void method_109(Class145 class145_0)
	{
		Class64 @class = class64_0;
		if (@class == null)
		{
			return;
		}
		try
		{
			Class401 class2 = Class38.smethod_0(class145_0, string_0, DateTime.UtcNow);
			if (class2 == null)
			{
				@class.method_2();
				Interlocked.Exchange(ref long_5, 0L);
				return;
			}
			long num = class145_0.method_0().long_0;
			if (Interlocked.Read(ref long_5) != num && @class.method_0(class2))
			{
				Interlocked.Exchange(ref long_5, num);
				long elapsedMilliseconds = stopwatch_0.ElapsedMilliseconds;
				if (Class174.smethod_0(long_6, elapsedMilliseconds))
				{
					long_6 = elapsedMilliseconds;
				}
			}
		}
		catch (ObjectDisposedException)
		{
		}
		catch (Exception)
		{
		}
	}

	internal IReadOnlyList<Class401> method_110()
	{
		Class64 @class = class64_0;
		if (@class == null)
		{
			return Array.Empty<Class401>();
		}
		try
		{
			DateTime utcNow = DateTime.UtcNow;
			IReadOnlyList<Class401> result = class102_0.method_0(@class.method_1(utcNow), utcNow);
			long elapsedMilliseconds = stopwatch_0.ElapsedMilliseconds;
			if (Class174.smethod_0(long_7, elapsedMilliseconds))
			{
				long_7 = elapsedMilliseconds;
			}
			return result;
		}
		catch (ObjectDisposedException)
		{
			return Array.Empty<Class401>();
		}
		catch (Exception)
		{
			return class102_0.method_0(Array.Empty<Class401>(), DateTime.UtcNow);
		}
	}

	private static void smethod_13(GClass12 gclass12_5, int int_12, int int_13)
	{
		int num = (int)((int_13 > 0 && int_12 > 0) ? ((int_12 >= int_13) ? 100 : (int_12 * 100L / int_13)) : 0);
		gclass12_5.method_1(num, int_12.ToString(CultureInfo.InvariantCulture) + "/" + int_13.ToString(CultureInfo.InvariantCulture));
	}

	private bool method_111(CheckBox checkBox_106, ComboBox comboBox_31, TextBox textBox_66, int int_12, int int_13, ref long long_16, long long_17)
	{
		if (!checkBox_106.Checked)
		{
			return false;
		}
		if (int_13 <= 0)
		{
			return false;
		}
		if (long_17 - long_16 < 1000L)
		{
			return false;
		}
		int num = smethod_14(comboBox_31);
		if (num >= 1 && num <= 6)
		{
			if (!int.TryParse(textBox_66.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
			{
				return false;
			}
			if (result < 1)
			{
				result = 1;
			}
			else if (result > 99)
			{
				result = 99;
			}
			if (int_12 * 100L / int_13 > result)
			{
				return false;
			}
			class119_0.method_121(num);
			long_16 = long_17;
			return true;
		}
		return false;
	}

	private static int smethod_14(ComboBox comboBox_31)
	{
		if (comboBox_31.SelectedItem == null)
		{
			return 0;
		}
		if (!int.TryParse(comboBox_31.SelectedItem.ToString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
		{
			return 0;
		}
		return result;
	}

	private void method_112(Class145 class145_0)
	{
		if (class145_0.method_89() == int_4)
		{
			return;
		}
		int_4 = class145_0.method_89();
		Class95 @class = class145_0.method_10();
		using (class67_0.method_17(dataGridView_28))
		{
			foreach (Class403 item in class145_0.method_2())
			{
				if (item != null && item.byte_0 == 2)
				{
					string text = smethod_15(@class.method_0(), smethod_16(item));
					if (text != null && !smethod_19(dataGridView_28, text))
					{
						dataGridView_28.Rows.Add(text);
					}
				}
			}
		}
		using (class67_0.method_17(dataGridView_2))
		{
			foreach (Class403 item2 in class145_0.method_6())
			{
				if (item2 != null)
				{
					string text2 = smethod_15(@class.method_2(), smethod_16(item2));
					if (text2 != null && !smethod_19(dataGridView_2, text2) && !smethod_19(dataGridView_1, text2))
					{
						dataGridView_2.Rows.Add(text2);
					}
				}
			}
			List<string> list = Class16.smethod_8(class145_0);
			for (int i = 0; i < list.Count; i++)
			{
				string text3 = list[i];
				if (!smethod_19(dataGridView_2, text3) && !smethod_19(dataGridView_1, text3))
				{
					dataGridView_2.Rows.Add(text3);
				}
			}
		}
		string text4 = smethod_18(class145_0);
		if (text4 == null)
		{
			return;
		}
		using (class67_0.method_17(dataGridView_19))
		{
			foreach (Class403 item3 in class145_0.method_4())
			{
				if (item3 != null && !item3.method_2())
				{
					string text5 = smethod_15(@class.method_4(), smethod_17(item3));
					if (text5 != null && text5 != text4 && !smethod_19(dataGridView_19, text5) && !smethod_19(dataGridView_20, text5))
					{
						dataGridView_19.Rows.Add(text5);
					}
				}
			}
		}
	}

	private static string smethod_15(IReadOnlyDictionary<string, string> ireadOnlyDictionary_0, string string_8)
	{
		if (ireadOnlyDictionary_0.TryGetValue(string_8, out var value) && value != null)
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

	private static string smethod_16(Class403 class403_0)
	{
		return class403_0.ushort_0.ToString(CultureInfo.InvariantCulture) + ":" + class403_0.ushort_1.ToString(CultureInfo.InvariantCulture);
	}

	private static string smethod_17(Class403 class403_0)
	{
		return class403_0.uint_0.ToString(CultureInfo.InvariantCulture);
	}

	private static string smethod_18(Class145 class145_0)
	{
		foreach (Class403 item in class145_0.method_4())
		{
			if (item != null && item.method_2())
			{
				string text = smethod_15(class145_0.method_10().method_4(), smethod_17(item));
				if (text != null)
				{
					return text;
				}
			}
		}
		return null;
	}

	private static bool smethod_19(DataGridView dataGridView_31, string string_8)
	{
		foreach (DataGridViewRow item in (IEnumerable)dataGridView_31.Rows)
		{
			if (!item.IsNewRow)
			{
				object value = item.Cells[0].Value;
				if (value != null && string.Equals(value.ToString(), string_8, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
		}
		return false;
	}

	private static int smethod_20(DataGridView dataGridView_31)
	{
		int count = dataGridView_31.Rows.Count;
		if (dataGridView_31.AllowUserToAddRows && count > 0)
		{
			return count - 1;
		}
		return count;
	}

	private void method_113(Class145 class145_0)
	{
		if (Class172.bool_0)
		{
			return;
		}
		class145_0.method_83();
		class145_0.method_89();
		int_5 = class145_0.method_83();
		int_6 = class145_0.method_89();
		long elapsedMilliseconds = stopwatch_0.ElapsedMilliseconds;
		if (elapsedMilliseconds - long_11 >= 30000L)
		{
			long_11 = elapsedMilliseconds;
			Class83 @class = class145_0.method_0();
			if (@class != null)
			{
				_ = new string[14]
				{
					"hp ",
					@class.ushort_0.ToString(),
					"/",
					@class.ushort_1.ToString(),
					" mp ",
					@class.ushort_2.ToString(),
					"/",
					@class.ushort_3.ToString(),
					" sp ",
					@class.ushort_4.ToString(),
					"/",
					@class.ushort_5.ToString(),
					" lv ",
					@class.ushort_6.ToString()
				};
			}
		}
	}

	private void textBox_0_Leave(object sender, EventArgs e)
	{
		if (sender is TextBox textBox && int.TryParse(textBox.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
		{
			if (result < 1)
			{
				result = 1;
			}
			else if (result > 99)
			{
				result = 99;
			}
			string text = result.ToString(CultureInfo.InvariantCulture);
			if (textBox.Text != text)
			{
				textBox.Text = text;
			}
		}
	}

	private void method_114(Class145 class145_0)
	{
		if (class119_2 != class119_0)
		{
			class119_2 = class119_0;
			long_14 = -1L;
			bool_15 = false;
		}
		if (class119_0 == null || !class119_0.method_10())
		{
			return;
		}
		method_116();
		if (!Class357.smethod_54())
		{
			return;
		}
		long elapsedMilliseconds = stopwatch_0.ElapsedMilliseconds;
		if (bool_15 && (class145_0.method_43() != int_8 || class145_0.method_51() != string_2))
		{
			bool_15 = false;
		}
		if (Class16.smethod_0(long_14, elapsedMilliseconds) && (!bool_15 || elapsedMilliseconds - long_14 >= 3000L))
		{
			long_14 = elapsedMilliseconds;
			bool_15 = true;
			int_8 = class145_0.method_43();
			string_2 = class145_0.method_51();
			class119_0.method_167();
		}
		string text = class145_0.method_51();
		if (class145_0.method_43() == int_9 && text == string_3)
		{
			return;
		}
		int_9 = class145_0.method_43();
		string_3 = text;
		method_115(Class16.smethod_2(class145_0));
		if (form7_1 != null)
		{
			form7_1.method_0(class145_0);
		}
		if (form7_0 != null)
		{
			form7_0.method_0(class145_0);
		}
		string text2 = Class16.smethod_3(class145_0);
		if (label_88.Text != text2)
		{
			label_88.Text = text2;
		}
		if (string_4 == null)
		{
			string text3 = label_86.Text;
			int num = text3?.LastIndexOf("0 / 0", StringComparison.Ordinal) ?? (-1);
			string_4 = ((num > 0) ? text3.Substring(0, num) : string.Empty);
		}
		string text4 = string_4 + text2;
		if (label_86.Text != text4)
		{
			label_86.Text = text4;
		}
		for (int i = 0; i < 12; i++)
		{
			(string, string) tuple = Class16.smethod_4(class145_0, i, string_5[i]);
			Label label = label_169[i];
			Label label2 = label_170[i];
			if (label != null && label.Text != tuple.Item1)
			{
				(label.Text, _) = tuple;
			}
			if (label2 != null && label2.Text != tuple.Item2)
			{
				label2.Text = tuple.Item2;
			}
		}
	}

	private void method_115(List<string[]> list_1)
	{
		DataGridViewRowCollection rows = dataGridView_22.Rows;
		while (rows.Count > list_1.Count)
		{
			rows.RemoveAt(rows.Count - 1);
		}
		while (rows.Count < list_1.Count)
		{
			rows.Add();
		}
		for (int i = 0; i < list_1.Count; i++)
		{
			DataGridViewCellCollection cells = rows[i].Cells;
			string[] array = list_1[i];
			for (int j = 0; j < 3; j++)
			{
				object value = cells[j].Value;
				if (value == null)
				{
					if (array[j].Length == 0)
					{
						continue;
					}
				}
				else if (value.ToString() == array[j])
				{
					continue;
				}
				cells[j].Value = array[j];
			}
		}
		method_82();
	}

	private void method_116()
	{
		if (label_169 == null)
		{
			label_169 = new Label[12];
			label_170 = new Label[12];
			string_5 = new string[12];
			for (int i = 0; i < 12; i++)
			{
				string text = (i + 1).ToString(CultureInfo.InvariantCulture);
				label_169[i] = method_117("lblEquipName" + text);
				label_170[i] = method_117("lblEquipQty" + text);
				string_5[i] = ((label_169[i] == null) ? string.Empty : label_169[i].Text);
			}
			dataGridView_22.AllowUserToAddRows = false;
		}
	}

	private Label method_117(string string_8)
	{
		Control[] array = base.Controls.Find(string_8, searchAllChildren: true);
		int num = 0;
		Label label;
		while (true)
		{
			if (num < array.Length)
			{
				label = array[num] as Label;
				if (label != null)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return label;
	}

	private void radioButton_35_CheckedChanged(object sender, EventArgs e)
	{
		if (((RadioButton)sender).Checked)
		{
			method_118();
		}
	}

	private void method_118()
	{
		bool flag = radioButton_35.Checked;
		long num = ((class119_0 == null) ? 0L : class119_0.method_98());
		if (class119_3 != class119_0 || long_15 != num)
		{
			class119_3 = class119_0;
			long_15 = num;
			bool_18 = false;
			bool_17 = false;
		}
		if (bool_16 != flag)
		{
			if (bool_18 && class119_0 != null)
			{
				class119_0.method_107(bool_16);
			}
			bool_18 = false;
			bool_19 = false;
			bool_16 = flag;
			if (!flag && bool_17 && class119_0 != null)
			{
				class119_0.method_103(bool_17: false);
			}
			bool_17 = false;
		}
		if (flag && bool_2 && checkBox_32.Checked && class119_0 != null && !bool_17)
		{
			class119_0.method_103(bool_17: true);
			bool_17 = true;
		}
		if (bool_2 && checkBox_32.Checked && class119_0 != null && (flag ? class119_0.method_97() : class119_0.method_96()))
		{
			int value = trackBar_0.Value;
			Class398 @class = Class412.smethod_1();
			if (@class.bool_0)
			{
				bool flag2 = @class.float_0 != float_2 || @class.float_1 != float_3 || @class.float_2 != float_4;
				if (!bool_18 || !bool_19 || flag2)
				{
					if (bool_18 && !bool_19)
					{
						class119_0.method_107(bool_16);
					}
					class119_0.method_105(value, @class.float_0, @class.float_1, @class.float_2, flag);
					bool_18 = true;
					bool_19 = true;
					int_10 = value;
					float_2 = @class.float_0;
					float_3 = @class.float_1;
					float_4 = @class.float_2;
				}
				else if (value != int_10)
				{
					class119_0.method_106(value, flag);
					int_10 = value;
				}
			}
			else if (bool_18 && !bool_19)
			{
				if (value != int_10)
				{
					class119_0.method_106(value, flag);
					int_10 = value;
				}
			}
			else
			{
				if (bool_18)
				{
					class119_0.method_107(bool_16);
				}
				class119_0.method_104(value, flag);
				bool_18 = true;
				bool_19 = false;
				int_10 = value;
			}
		}
		else
		{
			if (bool_18 && class119_0 != null)
			{
				class119_0.method_107(bool_16);
			}
			bool_18 = false;
			bool_19 = false;
			if ((!bool_2 || !checkBox_32.Checked) && bool_17 && class119_0 != null)
			{
				class119_0.method_103(bool_17: false);
				bool_17 = false;
			}
		}
	}

	private void method_119()
	{
		if (class119_4 != class119_0)
		{
			class390_0.method_1();
			class119_4 = class119_0;
		}
		bool flag = radioButton_32.Checked;
		bool flag2 = radioButton_33.Checked;
		if (bool_2 && checkBox_94.Checked && class119_0 != null && class119_0.method_96() && (flag || flag2) && this.smethod_4())
		{
			Class31 class31_ = Class38.smethod_8(method_5(), flag2 ? textBox_64.Text : null, flag, method_110(), DateTime.UtcNow);
			if (!Class38.smethod_5(method_5(), class31_, decimal.ToInt32(numericUpDown_0.Value), out var class348_))
			{
				if (class390_0.method_1())
				{
					class119_0.method_114("party-host");
				}
			}
			else if (class390_0.method_0(class348_))
			{
				class119_0.method_110("party-host", class348_.int_0, 0f, 0f, 1f, 0.15f, class348_.float_0, class348_.float_1, class348_.float_2);
			}
		}
		else if (class390_0.method_1() && class119_0 != null)
		{
			class119_0.method_114("party-host");
		}
	}

	private void method_120()
	{
		bool flag;
		if (flag = bool_2 && checkBox_102.Checked && class119_0 != null && class119_0.method_96() && radioButton_3.Checked)
		{
			int num = Class2.smethod_6();
			List<Struct76> list = Class440.smethod_10(this.smethod_30("dataGridView1"));
			if (num >= 0 && num < list.Count)
			{
				Struct76 @struct = list[num];
				if (!bool_20)
				{
					class119_0.method_111("wph", 2.5f, 1f, 0f, 0f, 0.78f);
				}
				if (Class86.smethod_0(bool_20, num, int_11))
				{
					class119_0.method_110("wp0", 2.5f, 1f, 0f, 0f, 0.78f, @struct.float_0, @struct.float_1, @struct.float_2);
				}
				Class83 @class = class119_0.method_51().method_0();
				if (@class != null && Class86.smethod_1(bool_20, num, int_11, @class.float_0, @class.float_2, float_5, float_6))
				{
					class119_0.method_112("wpt", 1f, 1f, 0f, 0f, 0.78f, @class.float_0, @class.float_1, @class.float_2, @struct.float_0, @struct.float_1, @struct.float_2);
					float_5 = @class.float_0;
					float_6 = @class.float_2;
				}
				bool_20 = true;
				int_11 = num;
			}
			else
			{
				flag = false;
			}
		}
		if (!flag)
		{
			if (bool_20 && class119_0 != null)
			{
				class119_0.method_114("wp0");
				class119_0.method_114("wph");
				class119_0.method_114("wpt");
			}
			bool_20 = false;
			int_11 = -1;
		}
	}

	internal TrackBar method_121()
	{
		return trackBar_3;
	}

	internal Label method_122()
	{
		return label_168;
	}

	internal Struct137 method_123()
	{
		return struct137_0;
	}

	internal void method_124(System.Windows.Forms.Timer timer_4)
	{
		timer_0 = timer_4;
	}

	internal void method_125()
	{
		trackBar_3_Scroll(trackBar_3, EventArgs.Empty);
	}

	internal void method_126()
	{
		method_31();
	}

	internal bool method_127()
	{
		return true;
	}

	internal void method_128()
	{
		Version version = GetType().Assembly.GetName().Version;
		string_7 = version.Major + "." + version.Minor;
		label_21.Text = "Version : " + string_7;
	}

	private async void button_89_Click(object sender, EventArgs e)
	{
		await method_136(bool_23: false);
	}

	private async void button_90_Click(object sender, EventArgs e)
	{
		await method_136(bool_23: true);
	}

	private async Task method_136(bool bool_23)
	{
		Class149 @class = new Class149
		{
			bool_0 = bool_23
		};
		if (bool_22)
		{
			return;
		}
		@class.class85_0 = ((class190_0 == null) ? null : class190_0.method_0());
		if (@class.class85_0 == null || string.IsNullOrEmpty(@class.class85_0.string_2) || string.IsNullOrEmpty(@class.class85_0.string_1) || !string.Equals(Class444.smethod_2(textBox_6.Text), @class.class85_0.string_2, StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		bool_22 = true;
		button_89.Enabled = false;
		button_90.Enabled = false;
		try
		{
			await Task.Run((Func<bool>)@class.method_0);
			if (!base.IsDisposed && class190_0.method_0() == @class.class85_0)
			{
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			bool_22 = false;
			if (!base.IsDisposed)
			{
				button_89.Enabled = true;
				button_90.Enabled = true;
			}
		}
	}

	private void method_137(Class85 class85_0)
	{
		method_21(class85_0);
		method_28();
	}

	private string method_138()
	{
		return Volatile.Read(ref string_0);
	}

	private void SetupDiscordNotify()
	{
		checkBox_60.Checked = discordNotifier_0.Enabled;
		textBox_30.Text = discordNotifier_0.WebhookUrl;
		textBox_30.Size = new Size(222, 20);
		Button test = new Button
		{
			Name = "buttonDiscordTest",
			Location = new Point(234, 22),
			Size = new Size(66, 22),
			Text = "ทดสอบ",
			UseVisualStyleBackColor = true
		};
		tabPage_9.Controls.Add(test);
		checkBox_60.CheckedChanged += delegate
		{
			discordNotifier_0.Update(checkBox_60.Checked, textBox_30.Text);
		};
		textBox_30.TextChanged += delegate
		{
			discordNotifier_0.Update(checkBox_60.Checked, textBox_30.Text);
		};
		test.Click += async delegate
		{
			test.Enabled = false;
			try
			{
				string error = await discordNotifier_0.SendTestAsync(textBox_30.Text, method_138());
				if (error == null)
				{
					MessageBox.Show(this, "ส่งแล้ว ไปดูในห้อง Discord ได้เลย" + (checkBox_60.Checked ? string.Empty : "\n\n(ยังไม่ได้ติ๊ก \"ใช้งาน Discord - แจ้งเตือน\" — ต้องติ๊กก่อน ตอนเจอ captcha ถึงจะส่ง)"), "Discord", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show(this, "ส่งไม่ได้: " + error, "Discord", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			finally
			{
				test.Enabled = true;
			}
		};
	}

	private void method_139(string string_8, uint uint_0, string string_9, double double_0)
	{
		class363_0.method_11(string_8, uint_0, string_9, double_0);
	}

	private Class1 method_140(string string_8, uint uint_0)
	{
		return class363_0.method_9(string_8, uint_0);
	}

	private void method_141(string string_8, uint uint_0, string string_9, int int_12)
	{
		Class119 @class = method_7();
		if (@class == null)
		{
			method_2("auto-answer refused: no active session");
		}
		else
		{
			@class.method_178(Class43.smethod_0(uint_0, string_9, (uint)int_12));
		}
	}

	private void method_142(string string_8, uint uint_0, string string_9, double double_0, string string_10, int int_12)
	{
		class363_0.method_10(string_8, uint_0, string_9, double_0, string_10, int_12);
	}

	private void method_144(string string_8)
	{
		string text = smethod_1(string_8);
		if (text == null)
		{
			return;
		}
		WriteAgentLog(text);
		if (text.IndexOf("challenge", StringComparison.OrdinalIgnoreCase) >= 0)
		{
			method_2("[agent] " + text);
		}
	}

	private static readonly object object_agentLog = new object();

	// Every Run / Attach / Select / agent line used to be dropped (only "challenge" lines reached auto.log).
	// Keep them all in %LOCALAPPDATA%\Capybara_Bot\agent.log; rolls over to agent.old.log at 5 MB.
	private static void WriteAgentLog(string string_8)
	{
		try
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Capybara_Bot", "agent.log");
			lock (object_agentLog)
			{
				FileInfo fileInfo = new FileInfo(text);
				if (fileInfo.Exists && fileInfo.Length > 5242880)
				{
					File.Copy(text, Path.ChangeExtension(text, ".old.log"), overwrite: true);
					File.Delete(text);
				}
				File.AppendAllText(text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + " " + string_8 + Environment.NewLine);
			}
		}
		catch (Exception)
		{
		}
	}

	private void checkBox_35_CheckedChanged(object sender, EventArgs e)
	{
		method_28();
	}

	private void checkBox_34_CheckedChanged(object sender, EventArgs e)
	{
		method_28();
	}

	private void method_145(string string_8)
	{
		textBox_65.Text = string_8;
	}

	private void GForm0_Disposed_1(object sender, EventArgs e)
	{
		if (timer_0 != null)
		{
			timer_0.Stop();
			timer_0.Dispose();
			timer_0 = null;
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (Class143.smethod_8(ref struct1_0, smethod_3()))
		{
			timer_0.Stop();
		}
	}

	private Task method_146()
	{
		return Class58.smethod_0(this);
	}

	private async Task method_147()
	{
		Class119 @class = class119_0;
		if (@class != null)
		{
			await @class.method_130();
		}
	}

	private void method_148()
	{
		method_94((Enum11)2);
	}

	private void method_149()
	{
		method_94((Enum11)1);
	}

	private Task method_150()
	{
		return Class412.smethod_9(this);
	}
}
