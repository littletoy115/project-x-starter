using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

internal sealed class Form9 : Form
{
	private sealed class Class415
	{
		public string string_0;

		internal bool method_0(Class53 class53_0)
		{
			return string.Equals(class53_0.string_0, string_0, StringComparison.OrdinalIgnoreCase);
		}
	}

	private readonly HashSet<string> hashSet_0;

	private readonly Func<List<Class53>> func_0;

	private readonly DataGridView dataGridView_0;

	private readonly Timer timer_0;

	internal Form9(int int_0, HashSet<string> hashSet_1, Func<List<Class53>> func_1)
	{
		hashSet_0 = hashSet_1;
		func_0 = func_1;
		Text = Class185.smethod_0(-1141036824) + int_0;
		base.StartPosition = FormStartPosition.CenterParent;
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.TopMost = true;
		base.ShowInTaskbar = false;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.ClientSize = new Size(390, 330);
		dataGridView_0 = new DataGridView
		{
			Location = new Point(10, 10),
			Size = new Size(370, 270),
			AllowUserToAddRows = false,
			AllowUserToDeleteRows = false,
			AllowUserToResizeRows = false,
			RowHeadersVisible = false,
			MultiSelect = false,
			BackgroundColor = SystemColors.Window
		};
		dataGridView_0.Columns.Add(new DataGridViewCheckBoxColumn
		{
			Name = Class185.smethod_0(-1141036836),
			HeaderText = Class185.smethod_0(-1141362411),
			Width = 50
		});
		dataGridView_0.Columns.Add(new DataGridViewTextBoxColumn
		{
			Name = Class185.smethod_0(-1141298782),
			HeaderText = Class185.smethod_0(-1141036764),
			ReadOnly = true,
			AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
		});
		dataGridView_0.Columns.Add(new DataGridViewTextBoxColumn
		{
			Name = Class185.smethod_0(-1141225465),
			HeaderText = Class185.smethod_0(-1141036850),
			ReadOnly = true,
			Width = 105
		});
		dataGridView_0.CurrentCellDirtyStateChanged += dataGridView_0_CurrentCellDirtyStateChanged;
		dataGridView_0.CellValueChanged += dataGridView_0_CellValueChanged;
		base.Controls.Add(dataGridView_0);
		Button button = new Button
		{
			Text = Class185.smethod_0(-1141263398),
			Location = new Point(10, 290),
			Size = new Size(80, 25)
		};
		button.Click += method_2;
		base.Controls.Add(button);
		Button button2 = new Button
		{
			Text = Class185.smethod_0(-1141035021),
			Location = new Point(300, 290),
			Size = new Size(80, 25),
			DialogResult = DialogResult.OK
		};
		base.Controls.Add(button2);
		base.AcceptButton = button2;
		timer_0 = new Timer
		{
			Interval = 1000
		};
		timer_0.Tick += timer_0_Tick;
		timer_0.Start();
		base.FormClosed += Form9_FormClosed;
	}

	internal void method_0()
	{
		dataGridView_0.EndEdit();
		List<Class53> list = func_0();
		dataGridView_0.Rows.Clear();
		foreach (Class53 item in list)
		{
			dataGridView_0.Rows.Add(hashSet_0.Contains(item.string_0), item.string_0, item.string_1);
		}
		dataGridView_0.ClearSelection();
	}

	private void method_1()
	{
		List<Class53> list = func_0();
		foreach (DataGridViewRow item in (IEnumerable)dataGridView_0.Rows)
		{
			Class415 @class = new Class415();
			@class.string_0 = item.Cells[1].Value as string;
			Class53 class2 = list.Find(@class.method_0);
			item.Cells[2].Value = ((class2 == null) ? Class185.smethod_0(-1141274422) : class2.string_1);
		}
	}

	private void dataGridView_0_CurrentCellDirtyStateChanged(object sender, EventArgs e)
	{
		if (dataGridView_0.IsCurrentCellDirty)
		{
			dataGridView_0.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}
	}

	private void dataGridView_0_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex < 0 || e.ColumnIndex != 0)
		{
			return;
		}
		DataGridViewRow dataGridViewRow = dataGridView_0.Rows[e.RowIndex];
		if (dataGridViewRow.Cells[1].Value is string item)
		{
			if (dataGridViewRow.Cells[0].Value is bool && (bool)dataGridViewRow.Cells[0].Value)
			{
				hashSet_0.Add(item);
			}
			else
			{
				hashSet_0.Remove(item);
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		method_0();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		method_1();
	}

	private void Form9_FormClosed(object sender, FormClosedEventArgs e)
	{
		timer_0.Dispose();
	}
}
