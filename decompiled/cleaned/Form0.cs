using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

internal sealed class Form0 : Form
{
	private sealed class Class19
	{
		public Form0 form0_0;

		public bool bool_0;

		public string string_0;

		internal void method_0()
		{
			form0_0.method_1(bool_0);
			if (bool_0)
			{
				form0_0.Close();
				return;
			}
			form0_0.label_2.Visible = false;
			form0_0.label_1.Visible = false;
			form0_0.label_0.Text = Class185.smethod_0(-1141035854);
			form0_0.label_0.ForeColor = Color.FromArgb(255, 140, 130);
			form0_0.textBox_0.Height = form0_0.textBox_0.Font.Height * 3 + 10;
			form0_0.textBox_0.Text = (string.IsNullOrEmpty(string_0) ? Class185.smethod_0(-1141035893) : string_0);
			form0_0.textBox_0.Visible = true;
			form0_0.button_0.Location = new Point(165, form0_0.textBox_0.Bottom + 12);
			form0_0.Size = new Size(420, form0_0.button_0.Bottom + form0_0.Height - form0_0.ClientSize.Height + 14);
			form0_0.button_0.Visible = true;
		}
	}

	private sealed class Class20
	{
		public Form0 form0_0;

		public int int_0;

		internal void method_0()
		{
			form0_0.gclass12_0.method_1(int_0, int_0 + Class185.smethod_0(-1141277546));
		}
	}

	private readonly Label label_0;

	private readonly Label label_1;

	private readonly TextBox textBox_0;

	private readonly Label label_2;

	private readonly GClass12 gclass12_0;

	private readonly Button button_0;

	private readonly string string_0;

	private readonly string string_1;

	private bool bool_0;

	internal Form0(string string_2, string string_3)
	{
		string_0 = string_2;
		string_1 = string_3;
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.StartPosition = FormStartPosition.CenterParent;
		base.ControlBox = false;
		base.ShowInTaskbar = false;
		base.Size = new Size(420, 210);
		Text = Class185.smethod_0(-1141035907);
		BackColor = Color.FromArgb(30, 30, 30);
		ForeColor = Color.Gainsboro;
		label_0 = new Label
		{
			Text = Class185.smethod_0(-1141035942),
			Location = new Point(0, 26),
			Size = new Size(420, 26),
			TextAlign = ContentAlignment.MiddleCenter,
			Font = new Font(Class185.smethod_0(-1141265716), 11f)
		};
		label_1 = new Label
		{
			Text = Class185.smethod_0(-1141358114),
			Location = new Point(0, 54),
			Size = new Size(420, 22),
			TextAlign = ContentAlignment.MiddleCenter,
			ForeColor = Color.Gray,
			Font = new Font(Class185.smethod_0(-1141265716), 9f)
		};
		textBox_0 = new TextBox
		{
			Location = new Point(15, 115),
			Size = new Size(390, 58),
			Multiline = true,
			ReadOnly = true,
			WordWrap = true,
			ScrollBars = ScrollBars.Vertical,
			BorderStyle = BorderStyle.None,
			BackColor = Color.FromArgb(30, 30, 30),
			ForeColor = Color.Gainsboro,
			Font = new Font(Class185.smethod_0(-1141265716), 9f),
			Visible = false
		};
		label_2 = new Label
		{
			Text = Class185.smethod_0(-1141035964),
			Location = new Point(0, 116),
			Size = new Size(420, 22),
			TextAlign = ContentAlignment.MiddleCenter,
			ForeColor = Color.Gray,
			Font = new Font(Class185.smethod_0(-1141265716), 8.5f)
		};
		button_0 = new Button
		{
			Text = Class185.smethod_0(-1141035021),
			Location = new Point(165, 142),
			Size = new Size(90, 26),
			Visible = false
		};
		button_0.Click += button_0_Click;
		base.Controls.Add(label_0);
		base.Controls.Add(label_1);
		base.Controls.Add(textBox_0);
		base.Controls.Add(label_2);
		base.Controls.Add(button_0);
		gclass12_0 = GClass12.smethod_0(this, Color.FromArgb(255, 200, 120), Color.FromArgb(120, 200, 255), 60, 86, 300, 23, null, 0);
		base.Shown += Form0_Shown;
	}

	internal bool method_0()
	{
		return bool_0;
	}

	private void method_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	private void method_2()
	{
		Thread thread = new Thread(method_5);
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_3(long long_0, long long_1)
	{
		Class20 @class = new Class20();
		@class.form0_0 = this;
		if (!base.IsDisposed && base.IsHandleCreated)
		{
			@class.int_0 = (int)((long_1 > 0L) ? (long_0 * 100L / long_1) : 0);
			if (@class.int_0 < 0)
			{
				@class.int_0 = 0;
			}
			if (@class.int_0 > 100)
			{
				@class.int_0 = 100;
			}
			try
			{
				BeginInvoke(new Action(@class.method_0));
			}
			catch (InvalidOperationException)
			{
			}
		}
	}

	private void method_4(bool bool_1, string string_2)
	{
		Class19 @class = new Class19();
		@class.form0_0 = this;
		@class.bool_0 = bool_1;
		@class.string_0 = string_2;
		if (!base.IsDisposed && base.IsHandleCreated)
		{
			try
			{
				BeginInvoke(new Action(@class.method_0));
			}
			catch (InvalidOperationException)
			{
			}
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Form0_Shown(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_5()
	{
		string string_;
		bool bool_ = Class421.smethod_15(string_0, string_1, method_3, out string_);
		method_4(bool_, string_);
	}
}
