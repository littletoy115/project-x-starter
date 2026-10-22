using System;
using System.Drawing;
using System.Windows.Forms;

internal static class Class96
{
	internal static readonly Color color_0 = Color.LightGreen;

	internal static bool smethod_0(string string_0, string string_1)
	{
		if (string_0 != null && string_1 != null)
		{
			string_0 = string_0.Trim();
			string_1 = string_1.Trim();
			if (string_0.Length != 0 && string_1.Length != 0)
			{
				return string.Equals(string_0, string_1, StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}
		return false;
	}

	internal static int smethod_1(DataGridView dataGridView_0, string string_0)
	{
		if (dataGridView_0 != null && string_0 != null)
		{
			string text = string_0.Trim();
			if (text.Length == 0)
			{
				return -1;
			}
			DataGridViewRowCollection rows = dataGridView_0.Rows;
			int num = 0;
			while (true)
			{
				if (num < rows.Count)
				{
					DataGridViewRow dataGridViewRow = rows[num];
					if (!dataGridViewRow.IsNewRow && dataGridViewRow.Cells.Count > 0)
					{
						object value = dataGridViewRow.Cells[0].Value;
						if (value != null && smethod_0(value.ToString(), text))
						{
							break;
						}
					}
					num++;
					continue;
				}
				return -1;
			}
			return num;
		}
		return -1;
	}

	internal static bool smethod_2(DataGridView dataGridView_0, string string_0)
	{
		return smethod_1(dataGridView_0, string_0) >= 0;
	}

	internal static string smethod_3(DataGridViewRow dataGridViewRow_0)
	{
		if (dataGridViewRow_0 == null)
		{
			return string.Empty;
		}
		if (dataGridViewRow_0.IsNewRow)
		{
			return string.Empty;
		}
		DataGridViewCellCollection cells = dataGridViewRow_0.Cells;
		if (cells.Count <= 1)
		{
			return string.Empty;
		}
		object value = cells[0].Value;
		if (value == null)
		{
			return string.Empty;
		}
		if (value.ToString().Trim().Length == 0)
		{
			return string.Empty;
		}
		object value2 = cells[1].Value;
		if (value2 == null)
		{
			return string.Empty;
		}
		return value2.ToString().Trim();
	}

	internal static int smethod_4(DataGridView dataGridView_0, DataGridView dataGridView_1)
	{
		if (dataGridView_0 == null)
		{
			return 0;
		}
		int num = 0;
		DataGridViewRowCollection rows = dataGridView_0.Rows;
		for (int i = 0; i < rows.Count; i++)
		{
			DataGridViewRow dataGridViewRow = rows[i];
			if (dataGridViewRow.IsNewRow)
			{
				continue;
			}
			string text = smethod_3(dataGridViewRow);
			int num2;
			Color empty;
			if (text.Length != 0)
			{
				num2 = (smethod_2(dataGridView_1, text) ? 1 : 0);
				if (num2 != 0)
				{
					empty = color_0;
					goto IL_004b;
				}
			}
			else
			{
				num2 = 0;
			}
			empty = Color.Empty;
			goto IL_004b;
			IL_004b:
			Color color = empty;
			if (dataGridViewRow.DefaultCellStyle.BackColor != color)
			{
				dataGridViewRow.DefaultCellStyle.BackColor = color;
			}
			if (num2 != 0)
			{
				num++;
			}
		}
		return num;
	}
}
