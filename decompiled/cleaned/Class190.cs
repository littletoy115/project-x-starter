using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

internal sealed class Class190
{
	private sealed class Class191
	{
		public string string_0;

		internal List<Class34> method_0()
		{
			return Class444.smethod_0(string_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct70 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public Class190 class190_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class190 @class = class190_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = @class.method_5(bool_2: true).GetAwaiter();
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
	private struct Struct71 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Class190 class190_0;

		public bool bool_0;

		private Class191 class191_0;

		private TaskAwaiter<List<Class34>> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class190 @class = class190_0;
			try
			{
				if (num == 0)
				{
					goto IL_0086;
				}
				class191_0 = new Class191();
				if (!@class.bool_0)
				{
					string text = @class.textBox_0.Text;
					class191_0.string_0 = Class444.smethod_2(text);
					if (class191_0.string_0 != null)
					{
						@class.method_9(bool_2: true);
						goto IL_0086;
					}
					@class.method_10(bool_0, Class185.smethod_0(-1141299031) + text + Class185.smethod_0(-1141299063));
				}
				goto end_IL_000e;
				IL_0086:
				try
				{
					List<Class34> result;
					try
					{
						TaskAwaiter<List<Class34>> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run((Func<List<Class34>>)class191_0.method_0).GetAwaiter();
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
							taskAwaiter_0 = default(TaskAwaiter<List<Class34>>);
							num = -1;
							int_0 = -1;
						}
						result = awaiter.GetResult();
					}
					catch (Exception ex)
					{
						@class.method_10(bool_0, Class185.smethod_0(-1141298357) + ex.Message);
						goto end_IL_0086;
					}
					@class.string_0 = class191_0.string_0;
					@class.method_1(null);
					@class.bool_1 = true;
					try
					{
						@class.comboBox_0.Items.Clear();
						@class.comboBox_1.Items.Clear();
						List<Class34>.Enumerator enumerator = result.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Class34 current = enumerator.Current;
								@class.comboBox_0.Items.Add(current);
								@class.action_0(string.Format(Class185.smethod_0(-1141298399), current.int_1, current.string_1, Class85.smethod_1(current.string_1), current.int_2, current.bool_0 ? Class185.smethod_0(-1141298485) : Class185.smethod_0(-1141298468), current.string_0));
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							@class.bool_1 = false;
						}
					}
					if (@class.comboBox_0.Items.Count == 0)
					{
						@class.method_10(bool_0, Class185.smethod_0(-1141298495));
					}
					else
					{
						@class.comboBox_0.SelectedIndex = 0;
					}
					end_IL_0086:;
				}
				finally
				{
					if (num < 0)
					{
						@class.method_9(bool_2: false);
					}
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class191_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class191_0 = null;
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
	private struct Struct72 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Class190 class190_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class190 @class = class190_0;
			try
			{
				if (num == 0)
				{
					goto IL_0083;
				}
				Class192 class2 = new Class192();
				if (!@class.bool_0)
				{
					class2.string_0 = @class.string_0 ?? Class444.smethod_2(@class.textBox_0.Text);
					if (class2.string_0 != null)
					{
						@class.method_9(bool_2: true);
						goto IL_0083;
					}
					@class.method_11(Class185.smethod_0(-1141299031) + @class.textBox_0.Text + Class185.smethod_0(-1141299063));
				}
				goto end_IL_000e;
				IL_0083:
				try
				{
					try
					{
						TaskAwaiter<string> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run((Func<string>)class2.method_0).GetAwaiter();
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
						awaiter.GetResult();
					}
					catch (Exception ex)
					{
						@class.method_11(Class185.smethod_0(-1141299105) + ex.Message);
						goto end_IL_0083;
					}
					@class.method_1(null);
					@class.action_0(Class185.smethod_0(-1141299144));
					end_IL_0083:;
				}
				finally
				{
					if (num < 0)
					{
						@class.method_9(bool_2: false);
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
	private struct Struct73 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public Class190 class190_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class190 @class = class190_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = @class.method_6().GetAwaiter();
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

	private sealed class Class192
	{
		public string string_0;

		internal string method_0()
		{
			return Class71.smethod_0(string_0, null, Class185.smethod_0(-1141299013), 15000);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct74 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public Class190 class190_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class190 @class = class190_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = @class.method_4().GetAwaiter();
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
	private struct Struct75 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Class190 class190_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class190 @class = class190_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_012e;
				}
				string selectedPath;
				if (!@class.bool_0)
				{
					FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
					{
						Description = Class185.smethod_0(-1141298184)
					};
					try
					{
						if (@class.textBox_0.Text.Length > 0 && Directory.Exists(@class.textBox_0.Text))
						{
							folderBrowserDialog.SelectedPath = @class.textBox_0.Text;
						}
						if (folderBrowserDialog.ShowDialog(@class.method_8()) == DialogResult.OK)
						{
							selectedPath = folderBrowserDialog.SelectedPath;
							goto IL_0098;
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)folderBrowserDialog)?.Dispose();
						}
					}
				}
				goto end_IL_000e;
				IL_0098:
				@class.textBox_0.Text = selectedPath;
				@class.action_0(Class185.smethod_0(-1141298227) + selectedPath);
				if (Class444.smethod_2(selectedPath) != null)
				{
					awaiter = @class.method_5(bool_2: true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_012e;
				}
				@class.method_11(Class185.smethod_0(-1141298261));
				goto end_IL_000e;
				IL_012e:
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

	[Serializable]
	private sealed class Class193
	{
		public static readonly Class193 class193_0 = new Class193();

		public static Action<string> action_0;

		public static Action<Class85> action_1;

		internal void method_0(string string_0)
		{
		}

		internal void method_1(Class85 class85_0)
		{
		}
	}

	private readonly TextBox textBox_0;

	private readonly Button button_0;

	private readonly ComboBox comboBox_0;

	private readonly ComboBox comboBox_1;

	private readonly Button button_1;

	private readonly Button button_2;

	private string string_0;

	private bool bool_0;

	private bool bool_1;

	internal Action<string> action_0 = Class193.class193_0.method_0;

	private Class85 class85_0;

	internal Action<Class85> action_1 = Class193.class193_0.method_1;

	internal Class190(TextBox textBox_1, Button button_3, ComboBox comboBox_2, ComboBox comboBox_3, Button button_4, Button button_5)
	{
		if (textBox_1 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141298554));
		}
		if (button_3 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141298573));
		}
		if (comboBox_2 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141298584));
		}
		if (comboBox_3 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141298587));
		}
		if (button_4 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141298606));
		}
		if (button_5 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141298609));
		}
		textBox_0 = textBox_1;
		button_0 = button_3;
		comboBox_0 = comboBox_2;
		comboBox_1 = comboBox_3;
		button_1 = button_4;
		button_2 = button_5;
	}

	internal Class85 method_0()
	{
		return class85_0;
	}

	private void method_1(Class85 class85_1)
	{
		bool num = class85_0 != class85_1;
		class85_0 = class85_1;
		if (num)
		{
			action_1(class85_1);
		}
	}

	internal void method_2()
	{
		button_0.Click += button_0_Click;
		button_1.Click += button_1_Click;
		button_2.Click += button_2_Click;
		comboBox_0.SelectedIndexChanged += comboBox_0_SelectedIndexChanged;
		method_3();
		textBox_0.TextChanged += textBox_0_TextChanged;
		method_5(bool_2: false);
	}

	private void method_3()
	{
		string text = Class340.smethod_0();
		if (text.Length > 0)
		{
			textBox_0.Text = text;
			action_0(Class185.smethod_0(-1141298620) + text);
		}
		else if (textBox_0.Text.Length == 0 && Directory.Exists(Class185.smethod_0(-1141298664)))
		{
			textBox_0.Text = Class185.smethod_0(-1141298664);
		}
	}

	internal async Task method_4()
	{
		if (bool_0)
		{
			return;
		}
		string selectedPath;
		using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
		{
			Description = Class185.smethod_0(-1141298184)
		})
		{
			if (textBox_0.Text.Length > 0 && Directory.Exists(textBox_0.Text))
			{
				folderBrowserDialog.SelectedPath = textBox_0.Text;
			}
			if (folderBrowserDialog.ShowDialog(method_8()) != DialogResult.OK)
			{
				return;
			}
			selectedPath = folderBrowserDialog.SelectedPath;
		}
		textBox_0.Text = selectedPath;
		action_0(Class185.smethod_0(-1141298227) + selectedPath);
		if (Class444.smethod_2(selectedPath) == null)
		{
			method_11(Class185.smethod_0(-1141298261));
		}
		else
		{
			await method_5(bool_2: true);
		}
	}

	internal async Task method_5(bool bool_2)
	{
		Class191 @class = new Class191();
		if (bool_0)
		{
			return;
		}
		string text = textBox_0.Text;
		@class.string_0 = Class444.smethod_2(text);
		if (@class.string_0 == null)
		{
			method_10(bool_2, Class185.smethod_0(-1141299031) + text + Class185.smethod_0(-1141299063));
			return;
		}
		method_9(bool_2: true);
		try
		{
			List<Class34> list;
			try
			{
				list = await Task.Run((Func<List<Class34>>)@class.method_0);
			}
			catch (Exception ex)
			{
				method_10(bool_2, Class185.smethod_0(-1141298357) + ex.Message);
				return;
			}
			string_0 = @class.string_0;
			method_1(null);
			bool_1 = true;
			try
			{
				comboBox_0.Items.Clear();
				comboBox_1.Items.Clear();
				foreach (Class34 item in list)
				{
					comboBox_0.Items.Add(item);
					action_0(string.Format(Class185.smethod_0(-1141298399), item.int_1, item.string_1, Class85.smethod_1(item.string_1), item.int_2, item.bool_0 ? Class185.smethod_0(-1141298485) : Class185.smethod_0(-1141298468), item.string_0));
				}
			}
			finally
			{
				bool_1 = false;
			}
			if (comboBox_0.Items.Count == 0)
			{
				method_10(bool_2, Class185.smethod_0(-1141298495));
			}
			else
			{
				comboBox_0.SelectedIndex = 0;
			}
		}
		finally
		{
			method_9(bool_2: false);
		}
	}

	internal async Task method_6()
	{
		Class192 @class = new Class192();
		if (bool_0)
		{
			return;
		}
		@class.string_0 = string_0 ?? Class444.smethod_2(textBox_0.Text);
		if (@class.string_0 == null)
		{
			method_11(Class185.smethod_0(-1141299031) + textBox_0.Text + Class185.smethod_0(-1141299063));
			return;
		}
		method_9(bool_2: true);
		try
		{
			try
			{
				await Task.Run((Func<string>)@class.method_0);
			}
			catch (Exception ex)
			{
				method_11(Class185.smethod_0(-1141299105) + ex.Message);
				return;
			}
			method_1(null);
			action_0(Class185.smethod_0(-1141299144));
		}
		finally
		{
			method_9(bool_2: false);
		}
	}

	private void method_7()
	{
		if (!bool_1)
		{
			method_1(null);
			comboBox_1.Items.Clear();
			if (comboBox_0.SelectedItem is Class34 @class)
			{
				Class85 class2 = Class85.smethod_0(@class, string_0);
				comboBox_1.Items.Add(class2);
				comboBox_1.SelectedIndex = 0;
				method_1(class2);
				action_0(Class185.smethod_0(-1141298684) + @class.string_0 + Class185.smethod_0(-1141303831) + class2.string_1 + Class185.smethod_0(-1141303842) + class2.int_0 + Class185.smethod_0(-1141303860) + class2.int_1);
			}
		}
	}

	private Form method_8()
	{
		return comboBox_0.FindForm();
	}

	private void method_9(bool bool_2)
	{
		bool_0 = bool_2;
		button_0.Enabled = !bool_2;
		button_1.Enabled = !bool_2;
		button_2.Enabled = !bool_2;
		comboBox_0.Enabled = !bool_2;
		comboBox_1.Enabled = !bool_2;
	}

	private void method_10(bool bool_2, string string_1)
	{
		if (bool_2)
		{
			method_11(string_1);
		}
		else
		{
			action_0(Class185.smethod_0(-1141303887) + string_1);
		}
	}

	private void method_11(string string_1)
	{
		action_0(Class185.smethod_0(-1141303887) + string_1);
		Class429.smethod_3(method_8(), string_1, Class185.smethod_0(-1141303897), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	private async void button_0_Click(object sender, EventArgs e)
	{
		await method_4();
	}

	private async void button_1_Click(object sender, EventArgs e)
	{
		await method_5(bool_2: true);
	}

	private async void button_2_Click(object sender, EventArgs e)
	{
		await method_6();
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_7();
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		Class340.smethod_1(textBox_0.Text);
	}
}
