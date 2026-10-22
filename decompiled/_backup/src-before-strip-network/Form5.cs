using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

internal sealed class Form5 : Form
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct77 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public Form5 form5_0;

		private TaskAwaiter<GClass17> taskAwaiter_0;

		private TaskAwaiter<GClass0> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			Form5 form = form5_0;
			string string_ = null;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0062;
				}
				if (!form.bool_0)
				{
					string_ = form.textBox_0.Text.Trim();
					if (smethod_0(string_))
					{
						form.bool_0 = true;
						form.button_0.Enabled = false;
						goto IL_0062;
					}
					Class429.smethod_0(form, "กร\u0e38ณากรอก Key ร\u0e39ปแบบ XXXX-XXXX-XXXX-XXXX", "ต\u0e48ออาย\u0e38");
				}
				goto end_IL_000e;
				IL_0062:
				try
				{
					TaskAwaiter<GClass0> awaiter;
					TaskAwaiter<GClass17> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter<GClass0>);
							num = -1;
							int_0 = -1;
							goto IL_014f;
						}
						awaiter2 = form.gclass20_0.method_0(string_, form.string_0, form.string_1).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<GClass17>);
						num = -1;
						int_0 = -1;
					}
					GClass17 result = awaiter2.GetResult();
					if (result != null && result.Success)
					{
						awaiter = form.gclass20_0.method_2(form.string_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_014f;
					}
					Class429.smethod_0(form, "Key ไม\u0e48ถ\u0e39กต\u0e49อง กร\u0e38ณาตรวจสอบแล\u0e49วลองใหม\u0e48", "ต\u0e48ออาย\u0e38");
					goto end_IL_0062;
					IL_014f:
					GClass0 result2 = awaiter.GetResult();
					if (result2 != null && result2.IsValid)
					{
						Class429.smethod_0(form, "ต\u0e48ออาย\u0e38เร\u0e35ยบร\u0e49อย กร\u0e38ณาเป\u0e34ดโปรแกรมใหม\u0e48เพ\u0e37\u0e48ออ\u0e31ปเดตว\u0e31นใช\u0e49งาน", "ต\u0e48ออาย\u0e38");
						form.DialogResult = DialogResult.OK;
						form.Close();
					}
					else
					{
						Class429.smethod_0(form, "ย\u0e31งตรวจสอบว\u0e31นใช\u0e49งานใหม\u0e48ไม\u0e48ได\u0e49 กร\u0e38ณาลองใหม\u0e48", "ต\u0e48ออาย\u0e38");
					}
					end_IL_0062:;
				}
				catch (Exception ex)
				{
					Class429.smethod_0(form, "ต\u0e48ออาย\u0e38ไม\u0e48สำเร\u0e47จ: " + ex.Message, "ต\u0e48ออาย\u0e38");
				}
				finally
				{
					if (num < 0)
					{
						form.bool_0 = false;
						if (!form.IsDisposed)
						{
							form.button_0.Enabled = true;
						}
					}
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

	private readonly string string_0;

	private readonly string string_1;

	private readonly GClass20 gclass20_0;

	private readonly TextBox textBox_0;

	private readonly Button button_0;

	private bool bool_0;

	internal Form5(string string_2, string string_3, GClass20 gclass20_1)
	{
		if (gclass20_1 == null)
		{
			throw new ArgumentNullException("service");
		}
		string_0 = string_2 ?? string.Empty;
		string_1 = string_3 ?? string.Empty;
		gclass20_0 = gclass20_1;
		Text = "ต\u0e48ออาย\u0e38การใช\u0e49งาน";
		base.ClientSize = new Size(520, 165);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.StartPosition = FormStartPosition.CenterParent;
		base.ShowInTaskbar = false;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		Label label = new Label
		{
			Text = "HWID",
			Location = new Point(20, 35),
			AutoSize = true
		};
		TextBox textBox = new TextBox
		{
			Name = "textBoxHwid",
			Text = string_0,
			Location = new Point(90, 28),
			Size = new Size(405, 26),
			Font = new Font("Microsoft Sans Serif", 12f),
			ReadOnly = true,
			TextAlign = HorizontalAlignment.Center
		};
		Label label2 = new Label
		{
			Text = "KEY",
			Location = new Point(20, 85),
			AutoSize = true
		};
		textBox_0 = new TextBox
		{
			Name = "textBoxKey",
			Location = new Point(90, 78),
			Size = new Size(405, 26),
			Font = new Font("Microsoft Sans Serif", 12f),
			MaxLength = 19,
			TextAlign = HorizontalAlignment.Center
		};
		button_0 = new Button
		{
			Name = "buttonRenew",
			Text = "ต\u0e48ออาย\u0e38",
			Location = new Point(220, 118),
			Size = new Size(80, 30)
		};
		button_0.Click += button_0_Click;
		base.AcceptButton = button_0;
		base.Controls.AddRange(new Control[5] { label, textBox, label2, textBox_0, button_0 });
	}

	internal static bool smethod_0(string string_2)
	{
		if (!string.IsNullOrEmpty(string_2))
		{
			return Regex.IsMatch(string_2, "^[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}$");
		}
		return false;
	}

	private async void button_0_Click(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		string string_ = textBox_0.Text.Trim();
		if (!smethod_0(string_))
		{
			Class429.smethod_0(this, "กร\u0e38ณากรอก Key ร\u0e39ปแบบ XXXX-XXXX-XXXX-XXXX", "ต\u0e48ออาย\u0e38");
			return;
		}
		bool_0 = true;
		button_0.Enabled = false;
		try
		{
			GClass17 gClass = await gclass20_0.method_0(string_, string_0, string_1);
			if (gClass != null && gClass.Success)
			{
				GClass0 gClass2 = await gclass20_0.method_2(string_0);
				if (gClass2 != null && gClass2.IsValid)
				{
					Class429.smethod_0(this, "ต\u0e48ออาย\u0e38เร\u0e35ยบร\u0e49อย กร\u0e38ณาเป\u0e34ดโปรแกรมใหม\u0e48เพ\u0e37\u0e48ออ\u0e31ปเดตว\u0e31นใช\u0e49งาน", "ต\u0e48ออาย\u0e38");
					base.DialogResult = DialogResult.OK;
					Close();
				}
				else
				{
					Class429.smethod_0(this, "ย\u0e31งตรวจสอบว\u0e31นใช\u0e49งานใหม\u0e48ไม\u0e48ได\u0e49 กร\u0e38ณาลองใหม\u0e48", "ต\u0e48ออาย\u0e38");
				}
			}
			else
			{
				Class429.smethod_0(this, "Key ไม\u0e48ถ\u0e39กต\u0e49อง กร\u0e38ณาตรวจสอบแล\u0e49วลองใหม\u0e48", "ต\u0e48ออาย\u0e38");
			}
		}
		catch (Exception ex)
		{
			Class429.smethod_0(this, "ต\u0e48ออาย\u0e38ไม\u0e48สำเร\u0e47จ: " + ex.Message, "ต\u0e48ออาย\u0e38");
		}
		finally
		{
			bool_0 = false;
			if (!base.IsDisposed)
			{
				button_0.Enabled = true;
			}
		}
	}
}
