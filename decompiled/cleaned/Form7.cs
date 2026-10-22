using System;
using System.Drawing;
using System.Windows.Forms;

internal sealed class Form7 : Form
{
	private DataGridView dataGridView_0;

	private Class67 class67_0;

	private Action<string> action_0;

	private readonly Panel[] panel_0 = new Panel[60];

	private readonly Label[] label_0 = new Label[60];

	private readonly Label[] label_1 = new Label[60];

	private readonly Label label_2;

	private readonly string[] string_0 = new string[60];

	private readonly string[] string_1 = new string[60];

	private readonly bool[] bool_0 = new bool[60];

	private int int_0 = -1;

	private Font font_0;

	internal Form7(DataGridView dataGridView_1, Class67 class67_1, Action<string> action_1 = null)
	{
		dataGridView_0 = dataGridView_1;
		class67_0 = class67_1;
		action_0 = action_1;
		Text = Class185.smethod_0(-1141032294);
		base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		base.StartPosition = FormStartPosition.CenterParent;
		base.MaximizeBox = false;
		base.ShowInTaskbar = false;
		BackColor = SystemColors.Control;
		base.ClientSize = new Size(584, 582);
		Font font = (font_0 = new Font(Class185.smethod_0(-1141306171), 7f));
		for (int i = 0; i < 60; i++)
		{
			Panel panel = new Panel();
			panel.Location = new Point(Class432.smethod_0(i), Class432.smethod_1(i));
			panel.Size = new Size(93, 52);
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.BackColor = Class432.color_0;
			panel.Tag = i;
			Label label = new Label
			{
				Location = new Point(2, 2),
				Size = new Size(87, 32),
				Font = font,
				BackColor = Color.Transparent,
				Text = string.Empty,
				Tag = i
			};
			Label label2 = new Label
			{
				Location = new Point(49, 35),
				Size = new Size(40, 13),
				Font = font,
				TextAlign = ContentAlignment.BottomRight,
				BackColor = Color.Transparent,
				Text = string.Empty,
				Tag = i
			};
			panel.DoubleClick += method_2;
			label.DoubleClick += method_2;
			label2.DoubleClick += method_2;
			panel.Click += method_3;
			label.Click += method_3;
			label2.Click += method_3;
			panel.Controls.Add(label);
			panel.Controls.Add(label2);
			base.Controls.Add(panel);
			panel_0[i] = panel;
			label_0[i] = label;
			label_1[i] = label2;
			string_0[i] = string.Empty;
			string_1[i] = string.Empty;
		}
		label_2 = new Label();
		label_2.Location = new Point(3, 562);
		label_2.Size = new Size(578, 20);
		label_2.TextAlign = ContentAlignment.MiddleLeft;
		label_2.Text = Class432.smethod_6(null);
		base.Controls.Add(label_2);
		base.Shown += Form7_Shown;
	}

	internal void method_0(Class145 class145_0)
	{
		if (base.IsDisposed)
		{
			return;
		}
		Class432.smethod_5(class145_0, string_0, string_1);
		int int_ = class145_0?.method_47() ?? 0;
		for (int i = 0; i < 60; i++)
		{
			bool_0[i] = Class432.smethod_2(i, int_);
			string text = (bool_0[i] ? string.Empty : string_0[i]);
			string text2 = (bool_0[i] ? string.Empty : string_1[i]);
			if (label_0[i].Text != text)
			{
				label_0[i].Text = text;
			}
			if (label_1[i].Text != text2)
			{
				label_1[i].Text = text2;
			}
		}
		if (int_0 >= 0 && bool_0[int_0])
		{
			int_0 = -1;
		}
		string text3 = Class432.smethod_6(class145_0);
		if (label_2.Text != text3)
		{
			label_2.Text = text3;
		}
		method_1(dataGridView_0);
	}

	internal void method_1(DataGridView dataGridView_1)
	{
		if (base.IsDisposed)
		{
			return;
		}
		for (int i = 0; i < 60; i++)
		{
			string text = string_0[i];
			Color color = Class432.smethod_4(!bool_0[i] && text != null && text.Length != 0 && Class96.smethod_2(dataGridView_1, text), bool_0[i], i == int_0);
			if (panel_0[i].BackColor != color)
			{
				panel_0[i].BackColor = color;
			}
		}
	}

	private void Form7_Shown(object sender, EventArgs e)
	{
		method_1(dataGridView_0);
	}

	private void method_2(object sender, EventArgs e)
	{
		if (sender is Control control && control.Tag is int)
		{
			method_5((int)control.Tag);
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		if (sender is Control control && control.Tag is int)
		{
			method_4((int)control.Tag);
		}
	}

	private void method_4(int int_1)
	{
		if (int_1 >= 0 && int_1 < 60 && !bool_0[int_1])
		{
			int_0 = int_1;
			method_1(dataGridView_0);
		}
	}

	internal void method_5(int int_1)
	{
		if (int_1 < 0 || int_1 >= 60 || bool_0[int_1])
		{
			return;
		}
		string text = string_0[int_1];
		if (text != null && text.Length != 0)
		{
			if (action_0 != null)
			{
				action_0(text);
				Close();
			}
			else
			{
				Class55.smethod_3(dataGridView_0, text, class67_0);
			}
		}
	}

	protected override void OnFormClosed(FormClosedEventArgs e)
	{
		base.Shown -= Form7_Shown;
		for (int i = 0; i < 60; i++)
		{
			if (panel_0[i] != null)
			{
				panel_0[i].DoubleClick -= method_2;
			}
			if (label_0[i] != null)
			{
				label_0[i].DoubleClick -= method_2;
			}
			if (label_1[i] != null)
			{
				label_1[i].DoubleClick -= method_2;
			}
			if (panel_0[i] != null)
			{
				panel_0[i].Click -= method_3;
			}
			if (label_0[i] != null)
			{
				label_0[i].Click -= method_3;
			}
			if (label_1[i] != null)
			{
				label_1[i].Click -= method_3;
			}
		}
		dataGridView_0 = null;
		class67_0 = null;
		action_0 = null;
		base.OnFormClosed(e);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing && font_0 != null)
		{
			font_0.Dispose();
			font_0 = null;
		}
	}
}
