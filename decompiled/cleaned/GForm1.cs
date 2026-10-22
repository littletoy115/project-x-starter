using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public sealed class GForm1 : Form
{
	private sealed class Class407
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Struct121 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

			public Class407 class407_0;

			private TaskAwaiter<(GClass17, GClass0)> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class407 @class = class407_0;
				bool result2;
				try
				{
					TaskAwaiter<(GClass17, GClass0)> awaiter;
					if (num != 0)
					{
						awaiter = @class.gclass20_0.method_1(@class.gclass0_0.LicenseKey, @class.gform1_0.string_1, @class.gform1_0.string_0).GetAwaiter();
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
						taskAwaiter_0 = default(TaskAwaiter<(GClass17, GClass0)>);
						num = -1;
						int_0 = -1;
					}
					(GClass17, GClass0) result = awaiter.GetResult();
					result2 = result.Item1 != null && result.Item1.Success;
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
		private struct Struct122 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

			public Class407 class407_0;

			private TaskAwaiter<bool> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class407 @class = class407_0;
				bool result;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						if (@class.synchronizationContext_0 == null)
						{
							throw new InvalidOperationException(Class185.smethod_0(-1141265455));
						}
						@class.class92_0 = new Class92(Class135.smethod_3(), Class92.timeSpan_1, Class343.smethod_3, @class.method_1, @class.class17_0.method_0, Class408.class408_0.method_3);
						Class343.smethod_5();
						awaiter = @class.class92_0.method_0(Class343.smethod_4, Class92.timeSpan_0, Class92.timeSpan_1, CancellationToken.None).GetAwaiter();
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
					result = awaiter.GetResult();
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

		public GClass20 gclass20_0;

		public GForm1 gform1_0;

		public SynchronizationContext synchronizationContext_0;

		public Class92 class92_0;

		public Class17 class17_0;

		public GClass0 gclass0_0;

		public bool bool_0;

		public Action<Action> action_0;

		internal async Task<bool> method_0()
		{
			if (synchronizationContext_0 == null)
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141265455));
			}
			class92_0 = new Class92(Class135.smethod_3(), Class92.timeSpan_1, Class343.smethod_3, method_1, class17_0.method_0, Class408.class408_0.method_3);
			Class343.smethod_5();
			return await class92_0.method_0(Class343.smethod_4, Class92.timeSpan_0, Class92.timeSpan_1, CancellationToken.None);
		}

		internal void method_1(Action action_1)
		{
			synchronizationContext_0.Post(Class408.class408_0.method_2, action_1);
		}

		internal async Task<bool> method_2()
		{
			(GClass17, GClass0) tuple = await gclass20_0.method_1(gclass0_0.LicenseKey, gform1_0.string_1, gform1_0.string_0);
			return tuple.Item1 != null && tuple.Item1.Success;
		}

		internal void method_3()
		{
			GForm0 gForm = new GForm0();
			gForm.method_128(gclass0_0, gclass20_0, gform1_0.method_0(), gform1_0.string_1);
			gForm.FormClosed += Class408.class408_0.method_4;
			gForm.method_17(class92_0);
			bool_0 = true;
			gform1_0.Hide();
			if (class17_0.method_1(gForm.method_19))
			{
				gForm.Show();
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct123 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public GClass0 gclass0_0;

		public Action action_0;

		public Action action_1;

		public Func<Task<bool>> func_0;

		public Action action_2;

		public Func<Task<bool>> func_1;

		public Action action_3;

		private TaskAwaiter<bool> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num == 0)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_00ba;
				}
				if (num == 1)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<bool>);
					num = -1;
					int_0 = -1;
					goto IL_0117;
				}
				if (gclass0_0 != null && gclass0_0.IsValid)
				{
					awaiter = func_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00ba;
				}
				action_0();
				action_1();
				result = false;
				goto end_IL_0007;
				IL_00ba:
				if (awaiter.GetResult())
				{
					awaiter = func_1().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0117;
				}
				action_0();
				action_2();
				result = false;
				goto end_IL_0007;
				IL_0117:
				if (!awaiter.GetResult())
				{
					action_0();
					result = false;
				}
				else
				{
					action_3();
					result = true;
				}
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

	[Serializable]
	private sealed class Class408
	{
		public static readonly Class408 class408_0 = new Class408();

		public static Action action_0;

		public static Action action_1;

		public static SendOrPostCallback sendOrPostCallback_0;

		public static Action<string> action_2;

		public static FormClosedEventHandler formClosedEventHandler_0;

		internal void method_0()
		{
			smethod_2(bool_1: false);
		}

		internal void method_1()
		{
			Class429.smethod_1(Class185.smethod_0(-1141266426));
		}

		internal void method_2(object object_0)
		{
			((Action)object_0)();
		}

		internal void method_3(string string_0)
		{
		}

		internal void method_4(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct124 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm1 gform1_0;

		private Class407 class407_0;

		private TaskAwaiter<GClass17> taskAwaiter_0;

		private TaskAwaiter<GClass0> taskAwaiter_1;

		private TaskAwaiter<bool> taskAwaiter_2;

		private void MoveNext()
		{
			int num = int_0;
			GForm1 gForm = gform1_0;
			try
			{
				TaskAwaiter<GClass17> awaiter2;
				TaskAwaiter<GClass0> awaiter;
				GClass0 result;
				GClass17 result2;
				switch (num)
				{
				default:
					class407_0 = new Class407();
					class407_0.gform1_0 = gform1_0;
					if (!smethod_1())
					{
						smethod_2(bool_1: true);
						class407_0.gclass20_0 = new GClass20();
						awaiter2 = class407_0.gclass20_0.method_0(gForm.textBox_0.Text, gForm.string_1, gForm.string_0).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_00e3;
					}
					Class429.smethod_1(Class185.smethod_0(-1141265500));
					goto end_IL_000e;
				case 0:
					awaiter2 = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<GClass17>);
					num = -1;
					int_0 = -1;
					goto IL_00e3;
				case 1:
					awaiter = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<GClass0>);
					num = -1;
					int_0 = -1;
					goto IL_01b6;
				case 2:
					break;
					IL_01b6:
					result = awaiter.GetResult();
					class407_0.gclass0_0 = result;
					break;
					IL_00e3:
					result2 = awaiter2.GetResult();
					if (result2 != null && result2.Success)
					{
						class407_0.class92_0 = null;
						class407_0.bool_0 = false;
						class407_0.class17_0 = new Class17();
						class407_0.synchronizationContext_0 = SynchronizationContext.Current;
						awaiter = class407_0.gclass20_0.method_2(gForm.string_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01b6;
					}
					smethod_2(bool_1: false);
					Class429.smethod_1(Class185.smethod_0(-1141265561));
					goto end_IL_000e;
				}
				try
				{
					TaskAwaiter<bool> awaiter3;
					if (num != 2)
					{
						awaiter3 = smethod_0(class407_0.gclass0_0, Class408.class408_0.method_0, Class408.class408_0.method_1, gForm.Close, class407_0.method_0, class407_0.method_2, class407_0.method_3).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							taskAwaiter_2 = awaiter3;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
					}
					else
					{
						awaiter3 = taskAwaiter_2;
						taskAwaiter_2 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
					}
					awaiter3.GetResult();
				}
				finally
				{
					if (num < 0 && !class407_0.bool_0 && class407_0.class92_0 != null)
					{
						class407_0.class92_0.Dispose();
					}
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class407_0 = null;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class407_0 = null;
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

	private GClass1 gclass1_0;

	private string string_0 = string.Empty;

	private string string_1 = string.Empty;

	private static bool bool_0;

	private IContainer icontainer_0;

	private TextBox textBox_0;

	private Button button_0;

	private TextBox textBox_1;

	public GForm1()
	{
		method_2();
		method_1(new GClass1());
		string_1 = method_0().method_1();
		textBox_1.Text = string_1;
		string_0 = method_0().method_2();
	}

	internal static async Task<bool> smethod_0(GClass0 gclass0_0, Action action_0, Action action_1, Action action_2, Func<Task<bool>> func_0, Func<Task<bool>> func_1, Action action_3)
	{
		if (gclass0_0 == null || !gclass0_0.IsValid)
		{
			action_0();
			action_1();
			return false;
		}
		if (!(await func_0()))
		{
			action_0();
			action_2();
			return false;
		}
		if (!(await func_1()))
		{
			action_0();
			return false;
		}
		action_3();
		return true;
	}

	private GClass1 method_0()
	{
		return gclass1_0;
	}

	private void method_1(GClass1 gclass1_1)
	{
		gclass1_0 = gclass1_1;
	}

	public static bool smethod_1()
	{
		return bool_0;
	}

	public static void smethod_2(bool bool_1)
	{
		bool_0 = bool_1;
	}

	private void GForm1_Load(object sender, EventArgs e)
	{
	}

	private async void button_0_Click(object sender, EventArgs e)
	{
		Class407 @class = new Class407
		{
			gform1_0 = this
		};
		if (smethod_1())
		{
			Class429.smethod_1(Class185.smethod_0(-1141265500));
			return;
		}
		smethod_2(bool_1: true);
		@class.gclass20_0 = new GClass20();
		GClass17 gClass = await @class.gclass20_0.method_0(textBox_0.Text, string_1, string_0);
		if (gClass != null && gClass.Success)
		{
			@class.class92_0 = null;
			@class.bool_0 = false;
			@class.class17_0 = new Class17();
			@class.synchronizationContext_0 = SynchronizationContext.Current;
			@class.gclass0_0 = await @class.gclass20_0.method_2(string_1);
			try
			{
				await smethod_0(@class.gclass0_0, Class408.class408_0.method_0, Class408.class408_0.method_1, base.Close, @class.method_0, @class.method_2, @class.method_3);
				return;
			}
			finally
			{
				if (!@class.bool_0 && @class.class92_0 != null)
				{
					@class.class92_0.Dispose();
				}
			}
		}
		smethod_2(bool_1: false);
		Class429.smethod_1(Class185.smethod_0(-1141265561));
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_2()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm1));
		textBox_0 = new TextBox();
		button_0 = new Button();
		textBox_1 = new TextBox();
		SuspendLayout();
		textBox_0.Font = new Font(Class185.smethod_0(-1141306171), 12f, FontStyle.Regular, GraphicsUnit.Point, 222);
		textBox_0.Location = new Point(11, 49);
		textBox_0.Name = Class185.smethod_0(-1141289103);
		textBox_0.Size = new Size(412, 26);
		textBox_0.TabIndex = 0;
		textBox_0.Text = Class185.smethod_0(-1141265630);
		button_0.Location = new Point(183, 84);
		button_0.Name = Class185.smethod_0(-1141280343);
		button_0.Size = new Size(75, 23);
		button_0.TabIndex = 1;
		button_0.Text = Class185.smethod_0(-1141295834);
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		textBox_1.Font = new Font(Class185.smethod_0(-1141306171), 12f, FontStyle.Regular, GraphicsUnit.Point, 222);
		textBox_1.Location = new Point(13, 13);
		textBox_1.Name = Class185.smethod_0(-1141281066);
		textBox_1.ReadOnly = true;
		textBox_1.Size = new Size(408, 26);
		textBox_1.TabIndex = 2;
		textBox_1.TextAlign = HorizontalAlignment.Center;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(433, 114);
		base.Controls.Add(textBox_1);
		base.Controls.Add(button_0);
		base.Controls.Add(textBox_0);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.Icon = (Icon)componentResourceManager.GetObject(Class185.smethod_0(-1141260701));
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = Class185.smethod_0(-1141261127);
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = Class185.smethod_0(-1141261127);
		base.TopMost = true;
		base.Load += GForm1_Load;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
