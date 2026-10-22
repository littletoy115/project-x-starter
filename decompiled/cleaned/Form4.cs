using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

internal sealed class Form4 : Form
{
	private sealed class Class134
	{
		public uint uint_0;

		internal bool method_0(Class381 class381_0)
		{
			return class381_0.uint_0 == uint_0;
		}
	}

	private readonly Func<Class145> func_0;

	private readonly TabControl tabControl_0;

	private readonly DataGridView dataGridView_0;

	private readonly DataGridView dataGridView_1;

	private readonly Timer timer_0;

	private string string_0;

	internal Form4(Func<Class145> func_1)
	{
		func_0 = func_1;
		Text = Class185.smethod_0(-1141309339);
		base.StartPosition = FormStartPosition.CenterParent;
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.TopMost = true;
		base.ShowInTaskbar = false;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.ClientSize = new Size(430, 360);
		tabControl_0 = new TabControl
		{
			Location = new Point(10, 10),
			Size = new Size(410, 300)
		};
		TabPage tabPage = new TabPage(Class185.smethod_0(-1141201110));
		TabPage tabPage2 = new TabPage(Class185.smethod_0(-1141201128));
		dataGridView_0 = method_2();
		dataGridView_1 = method_2();
		tabPage.Controls.Add(dataGridView_0);
		tabPage2.Controls.Add(dataGridView_1);
		tabControl_0.TabPages.Add(tabPage);
		tabControl_0.TabPages.Add(tabPage2);
		base.Controls.Add(tabControl_0);
		Button button = new Button
		{
			Text = Class185.smethod_0(-1141263398),
			Location = new Point(10, 320),
			Size = new Size(80, 27)
		};
		button.Click += method_6;
		base.Controls.Add(button);
		Button button2 = new Button
		{
			Text = Class185.smethod_0(-1141303145),
			Location = new Point(250, 320),
			Size = new Size(80, 27)
		};
		button2.Click += method_7;
		base.Controls.Add(button2);
		Button button3 = new Button
		{
			Text = Class185.smethod_0(-1141035021),
			Location = new Point(340, 320),
			Size = new Size(80, 27),
			DialogResult = DialogResult.Cancel
		};
		base.Controls.Add(button3);
		base.AcceptButton = button2;
		base.CancelButton = button3;
		timer_0 = new Timer
		{
			Interval = 500
		};
		timer_0.Tick += timer_0_Tick;
		base.Shown += Form4_Shown;
		base.FormClosed += Form4_FormClosed;
	}

	internal string method_0()
	{
		return string_0;
	}

	private void method_1(string string_1)
	{
		string_0 = string_1;
	}

	private DataGridView method_2()
	{
		DataGridView dataGridView = new DataGridView();
		dataGridView.Dock = DockStyle.Fill;
		dataGridView.ReadOnly = true;
		dataGridView.AllowUserToAddRows = false;
		dataGridView.AllowUserToDeleteRows = false;
		dataGridView.AllowUserToResizeRows = false;
		dataGridView.RowHeadersVisible = false;
		dataGridView.MultiSelect = false;
		dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView.BackgroundColor = SystemColors.Window;
		dataGridView.Columns.Add(new DataGridViewTextBoxColumn
		{
			Name = Class185.smethod_0(-1141298782),
			HeaderText = Class185.smethod_0(-1141036764),
			AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
		});
		dataGridView.Columns.Add(new DataGridViewTextBoxColumn
		{
			Name = Class185.smethod_0(-1141036780),
			HeaderText = Class185.smethod_0(-1141036780),
			Width = 110
		});
		dataGridView.CellDoubleClick += method_8;
		return dataGridView;
	}

	internal void method_3()
	{
		Class145 class145_ = func_0();
		smethod_0(dataGridView_0, Class46.smethod_0(class145_, bool_0: false));
		smethod_0(dataGridView_1, Class46.smethod_0(class145_, bool_0: true));
	}

	private static void smethod_0(DataGridView dataGridView_2, List<Class381> list_0)
	{
		uint? num = ((dataGridView_2.SelectedRows.Count == 0) ? ((uint?)null) : new uint?((uint)dataGridView_2.SelectedRows[0].Tag));
		dataGridView_2.Rows.Clear();
		foreach (Class381 item in list_0)
		{
			int index = dataGridView_2.Rows.Add(item.string_0, (!item.bool_2) ? Class185.smethod_0(-1141274422) : (item.bool_1 ? Class185.smethod_0(-1141306917) : (item.bool_0 ? Class185.smethod_0(-1141036814) : Class185.smethod_0(-1141036793))));
			DataGridViewRow dataGridViewRow = dataGridView_2.Rows[index];
			dataGridViewRow.Tag = item.uint_0;
			if (item.bool_0)
			{
				dataGridViewRow.DefaultCellStyle.ForeColor = SystemColors.GrayText;
			}
		}
		dataGridView_2.ClearSelection();
		if (!num.HasValue)
		{
			return;
		}
		foreach (DataGridViewRow item2 in (IEnumerable)dataGridView_2.Rows)
		{
			if ((uint)item2.Tag == num.Value)
			{
				item2.Selected = true;
				break;
			}
		}
	}

	internal bool method_4(uint uint_0, bool bool_0)
	{
		Class134 @class = new Class134();
		@class.uint_0 = uint_0;
		Class381 class2 = Class46.smethod_0(func_0(), bool_0).FirstOrDefault(@class.method_0);
		if (class2 != null && !class2.bool_0)
		{
			method_1(class2.string_0);
			return true;
		}
		return false;
	}

	private void method_5()
	{
		bool bool_;
		DataGridView dataGridView = ((bool_ = tabControl_0.SelectedIndex == 1) ? dataGridView_1 : dataGridView_0);
		if (dataGridView.SelectedRows.Count != 0 && method_4((uint)dataGridView.SelectedRows[0].Tag, bool_))
		{
			base.DialogResult = DialogResult.OK;
			Close();
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		method_3();
	}

	private void method_7(object sender, EventArgs e)
	{
		method_5();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		method_3();
	}

	private void Form4_Shown(object sender, EventArgs e)
	{
		method_3();
		timer_0.Start();
	}

	private void Form4_FormClosed(object sender, FormClosedEventArgs e)
	{
		timer_0.Dispose();
	}

	private void method_8(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			method_5();
		}
	}
}
