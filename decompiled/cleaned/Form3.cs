using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

internal sealed class Form3 : Form
{
	private TextBox textBox_0;

	private readonly DataGridView dataGridView_0;

	private readonly Label label_0;

	private readonly Button button_0;

	private readonly List<Struct140> list_0 = new List<Struct140>();

	private string string_0 = Class185.smethod_0(-1141035168);

	internal Form3(TextBox textBox_1)
	{
		textBox_0 = textBox_1;
		Text = Class185.smethod_0(-1141268020);
		base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		base.StartPosition = FormStartPosition.CenterParent;
		base.MaximizeBox = false;
		base.ShowInTaskbar = false;
		BackColor = SystemColors.Control;
		base.ClientSize = new Size(640, 300);
		dataGridView_0 = new DataGridView();
		dataGridView_0.Location = new Point(10, 10);
		dataGridView_0.Size = new Size(620, 205);
		dataGridView_0.ReadOnly = true;
		dataGridView_0.AllowUserToAddRows = false;
		dataGridView_0.AllowUserToDeleteRows = false;
		dataGridView_0.AllowUserToResizeRows = false;
		dataGridView_0.AllowUserToOrderColumns = false;
		dataGridView_0.AllowUserToResizeColumns = true;
		dataGridView_0.RowHeadersVisible = false;
		dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView_0.MultiSelect = false;
		dataGridView_0.BackgroundColor = SystemColors.Window;
		dataGridView_0.BorderStyle = BorderStyle.FixedSingle;
		string[] array = Class81.smethod_14();
		for (int i = 0; i < array.Length; i++)
		{
			dataGridView_0.Columns.Add(array[i], array[i]);
		}
		for (int j = 0; j < dataGridView_0.Columns.Count; j++)
		{
			dataGridView_0.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		}
		dataGridView_0.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		base.Controls.Add(dataGridView_0);
		label_0 = new Label();
		label_0.Location = new Point(10, 225);
		label_0.Size = new Size(620, 32);
		label_0.TextAlign = ContentAlignment.TopLeft;
		label_0.Text = Class185.smethod_0(-1141035168);
		base.Controls.Add(label_0);
		button_0 = new Button();
		button_0.Location = new Point(555, 267);
		button_0.Size = new Size(75, 23);
		button_0.Text = Class185.smethod_0(-1141035216);
		button_0.UseVisualStyleBackColor = true;
		base.Controls.Add(button_0);
		button_0.Click += button_0_Click;
		dataGridView_0.CellDoubleClick += dataGridView_0_CellDoubleClick;
		dataGridView_0.SelectionChanged += dataGridView_0_SelectionChanged;
	}

	internal void method_0(IReadOnlyList<Struct140> ireadOnlyList_0, int int_0)
	{
		if (base.IsDisposed)
		{
			return;
		}
		list_0.Clear();
		dataGridView_0.Rows.Clear();
		if (ireadOnlyList_0 != null)
		{
			for (int i = 0; i < ireadOnlyList_0.Count; i++)
			{
				Struct140 @struct = ireadOnlyList_0[i];
				list_0.Add(@struct);
				DataGridViewRowCollection rows = dataGridView_0.Rows;
				object[] values = Class81.smethod_13(@struct);
				rows.Add(values);
			}
		}
		dataGridView_0.ClearSelection();
		dataGridView_0.CurrentCell = null;
		string text = ((Class81.smethod_15(list_0) != 0 || list_0.Count == 0) ? Class185.smethod_0(-1141035168) : Class185.smethod_0(-1141035218));
		string_0 = text + Class81.smethod_16(int_0);
		label_0.Text = string_0;
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
			label_0.Text = (Class81.smethod_4(list_0[num]) ? string_0 : Class185.smethod_0(-1141035290));
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
			Struct140 struct140_ = list_0[int_0];
			if (!Class81.smethod_4(struct140_))
			{
				label_0.Text = Class185.smethod_0(-1141035290);
				return;
			}
			textBox_0.Text = struct140_.string_0;
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
