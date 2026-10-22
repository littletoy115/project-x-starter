using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

internal sealed class Form1 : Form
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct15 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Form1 form1_0;

		public int int_1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Form1 form = form1_0;
			try
			{
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = configuredTaskAwaiter_0;
						configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						int_0 = -1;
						goto IL_0094;
					}
					goto IL_009b;
					IL_0073:
					awaiter = Task.Delay(10).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						configuredTaskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0094;
					IL_0094:
					awaiter.GetResult();
					goto IL_009b;
					IL_009b:
					object object_ = form.object_0;
					bool lockTaken = false;
					try
					{
						Monitor.Enter(object_, ref lockTaken);
						if (form.bool_0 && form.int_0 == int_1)
						{
							form.action_0();
							goto IL_0073;
						}
					}
					finally
					{
						if (num < 0 && lockTaken)
						{
							Monitor.Exit(object_);
						}
					}
				}
				catch (Exception)
				{
					object object_ = form.object_0;
					bool lockTaken = false;
					try
					{
						Monitor.Enter(object_, ref lockTaken);
						if (form.int_0 == int_1)
						{
							form.bool_0 = false;
						}
					}
					finally
					{
						if (num < 0 && lockTaken)
						{
							Monitor.Exit(object_);
						}
					}
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

	private delegate IntPtr Delegate14(int int_0, IntPtr intptr_0, IntPtr intptr_1);

	private sealed class Class33
	{
		public Form1 form1_0;

		public int int_0;

		internal Task method_0()
		{
			return form1_0.method_2(int_0);
		}
	}

	private readonly object object_0 = new object();

	private readonly Action action_0;

	private readonly Label label_0;

	private readonly Delegate14 delegate14_0;

	private IntPtr intptr_0;

	private bool bool_0;

	private bool bool_1;

	private int int_0;

	internal Form1(Action action_1 = null)
	{
		action_0 = action_1 ?? new Action(smethod_0);
		Text = "AutoClick";
		base.Size = new Size(298, 110);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.StartPosition = FormStartPosition.CenterParent;
		base.TopMost = true;
		base.Controls.Add(new Label
		{
			Text = "กด F2 ใช\u0e49 AutoClick",
			TextAlign = ContentAlignment.MiddleCenter,
			Bounds = new Rectangle(40, 12, 200, 22)
		});
		label_0 = new Label
		{
			Text = "STOP CLICK",
			BackColor = Color.FromArgb(255, 192, 192),
			TextAlign = ContentAlignment.MiddleCenter,
			Bounds = new Rectangle(90, 42, 110, 22)
		};
		base.Controls.Add(label_0);
		delegate14_0 = method_0;
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int int_1, Delegate14 delegate14_1, IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

	[DllImport("user32.dll")]
	private static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_1, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("user32.dll")]
	private static extern void mouse_event(uint uint_0, int int_1, int int_2, uint uint_1, IntPtr intptr_1);

	protected override void OnShown(EventArgs e)
	{
		base.OnShown(e);
		using (Process process = Process.GetCurrentProcess())
		{
			using ProcessModule processModule = process.MainModule;
			intptr_0 = SetWindowsHookEx(13, delegate14_0, GetModuleHandle(processModule.ModuleName), 0u);
		}
		_ = intptr_0 == IntPtr.Zero;
	}

	private IntPtr method_0(int int_1, IntPtr intptr_1, IntPtr intptr_2)
	{
		if (int_1 >= 0 && Marshal.ReadInt32(intptr_2) == 113)
		{
			if (intptr_1 == (IntPtr)257)
			{
				bool_1 = false;
			}
			else if (intptr_1 == (IntPtr)256 && !bool_1)
			{
				bool_1 = true;
				method_1(Keys.F2);
			}
		}
		return CallNextHookEx(intptr_0, int_1, intptr_1, intptr_2);
	}

	internal void method_1(Keys keys_0)
	{
		Class33 @class = new Class33();
		@class.form1_0 = this;
		if (keys_0 == Keys.F2 && !base.IsDisposed)
		{
			bool flag;
			lock (object_0)
			{
				bool_0 = !bool_0;
				flag = bool_0;
				@class.int_0 = ++int_0;
			}
			label_0.Text = (flag ? "START CLICK" : "STOP CLICK");
			label_0.BackColor = (flag ? Color.FromArgb(192, 255, 192) : Color.FromArgb(255, 192, 192));
			if (flag)
			{
				Task.Run((Func<Task>)@class.method_0);
			}
		}
	}

	private async Task method_2(int int_1)
	{
		try
		{
			while (true)
			{
				lock (object_0)
				{
					if (!bool_0 || int_0 != int_1)
					{
						break;
					}
					action_0();
				}
				await Task.Delay(10).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		catch (Exception)
		{
			lock (object_0)
			{
				if (int_0 == int_1)
				{
					bool_0 = false;
				}
			}
		}
	}

	private static void smethod_0()
	{
		mouse_event(2u, 0, 0, 0u, IntPtr.Zero);
		Thread.Sleep(10);
		mouse_event(4u, 0, 0, 0u, IntPtr.Zero);
	}

	protected override void OnFormClosed(FormClosedEventArgs e)
	{
		lock (object_0)
		{
			bool_0 = false;
			int_0++;
		}
		if (intptr_0 != IntPtr.Zero)
		{
			UnhookWindowsHookEx(intptr_0);
		}
		intptr_0 = IntPtr.Zero;
		base.OnFormClosed(e);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			lock (object_0)
			{
				bool_0 = false;
				int_0++;
			}
			if (intptr_0 != IntPtr.Zero)
			{
				UnhookWindowsHookEx(intptr_0);
			}
			intptr_0 = IntPtr.Zero;
		}
		base.Dispose(disposing);
	}
}
