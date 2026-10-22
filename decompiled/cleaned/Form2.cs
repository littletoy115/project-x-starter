using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

internal sealed class Form2 : Form
{
	private TextBox textBox_0;

	private readonly DataGridView dataGridView_0;

	private readonly Label label_0;

	private readonly Button button_0;

	private readonly List<Class447.Class452> list_0 = new List<Class447.Class452>();

	internal Form2(TextBox textBox_1)
	{
		textBox_0 = textBox_1;
		Text = Class185.smethod_0(-1141267293);
		base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		base.StartPosition = FormStartPosition.CenterParent;
		base.MaximizeBox = false;
		base.ShowInTaskbar = false;
		BackColor = SystemColors.Control;
		base.ClientSize = new Size(440, 255);
		dataGridView_0 = new DataGridView();
		dataGridView_0.Location = new Point(10, 10);
		dataGridView_0.Size = new Size(420, 170);
		dataGridView_0.ReadOnly = true;
		dataGridView_0.AllowUserToAddRows = false;
		dataGridView_0.AllowUserToDeleteRows = false;
		dataGridView_0.AllowUserToResizeRows = false;
		dataGridView_0.AllowUserToResizeColumns = false;
		dataGridView_0.AllowUserToOrderColumns = false;
		dataGridView_0.RowHeadersVisible = false;
		dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_0.MultiSelect = false;
		dataGridView_0.BackgroundColor = SystemColors.Window;
		dataGridView_0.BorderStyle = BorderStyle.FixedSingle;
		dataGridView_0.Columns.Add(Class185.smethod_0(-1141285330), Class185.smethod_0(-1141285330));
		dataGridView_0.Columns.Add(Class185.smethod_0(-1141035464), Class185.smethod_0(-1141035464));
		dataGridView_0.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridView_0.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		base.Controls.Add(dataGridView_0);
		label_0 = new Label();
		label_0.Location = new Point(10, 190);
		label_0.Size = new Size(420, 30);
		label_0.TextAlign = ContentAlignment.TopLeft;
		label_0.Text = Class185.smethod_0(-1141035479);
		base.Controls.Add(label_0);
		button_0 = new Button();
		button_0.Location = new Point(355, 222);
		button_0.Size = new Size(75, 23);
		button_0.Text = Class185.smethod_0(-1141035216);
		button_0.UseVisualStyleBackColor = true;
		base.Controls.Add(button_0);
		button_0.Click += button_0_Click;
		dataGridView_0.CellDoubleClick += dataGridView_0_CellDoubleClick;
		dataGridView_0.SelectionChanged += dataGridView_0_SelectionChanged;
	}

	internal void method_0(List<Class447.Class452> list_1)
	{
		if (base.IsDisposed)
		{
			return;
		}
		list_0.Clear();
		dataGridView_0.Rows.Clear();
		if (list_1 != null)
		{
			for (int i = 0; i < list_1.Count; i++)
			{
				Class447.Class452 @class = list_1[i];
				if (@class != null)
				{
					list_0.Add(@class);
					dataGridView_0.Rows.Add(Class447.smethod_12(@class), Class447.smethod_13(@class));
				}
			}
		}
		dataGridView_0.ClearSelection();
		dataGridView_0.CurrentCell = null;
		label_0.Text = ((Class447.smethod_14(list_0) == 0) ? Class185.smethod_0(-1141036550) : Class185.smethod_0(-1141035479));
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		method_2(method_1());
	}

	private void dataGridView_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		method_2(method_1());
	}

	private void dataGridView_0_SelectionChanged(object sender, EventArgs e)
	{
		int num = method_1();
		if (num >= 0 && num < list_0.Count)
		{
			label_0.Text = (Class447.smethod_11(list_0[num]) ? Class185.smethod_0(-1141035479) : Class185.smethod_0(-1141036632));
		}
	}

	private int method_1()
	{
		if (dataGridView_0.SelectedRows.Count == 0)
		{
			return -1;
		}
		return dataGridView_0.SelectedRows[0].Index;
	}

	private void method_2(int int_0)
	{
		if (int_0 >= 0 && int_0 < list_0.Count && textBox_0 != null)
		{
			Class447.Class452 @class = list_0[int_0];
			if (!Class447.smethod_11(@class))
			{
				label_0.Text = Class185.smethod_0(-1141036632);
				return;
			}
			textBox_0.Text = @class.string_0;
			Close();
		}
	}

	protected override void OnFormClosed(FormClosedEventArgs e)
	{
		button_0.Click -= button_0_Click;
		dataGridView_0.CellDoubleClick -= dataGridView_0_CellDoubleClick;
		dataGridView_0.SelectionChanged -= dataGridView_0_SelectionChanged;
		list_0.Clear();
		textBox_0 = null;
		base.OnFormClosed(e);
	}
}
