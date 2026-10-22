using System;
using System.Collections.Generic;
using System.Windows.Forms;

internal static class Class44
{
	internal static List<DataGridViewRow> smethod_0(string string_0, DataGridView dataGridView_0, DataGridView dataGridView_1)
	{
		List<DataGridViewRow> list = new List<DataGridViewRow>();
		if (string_0 == null)
		{
			return list;
		}
		string text = string_0.Trim();
		if (text.Length == 0)
		{
			return list;
		}
		smethod_4(list, dataGridView_0, text);
		smethod_4(list, dataGridView_1, text);
		return list;
	}

	internal static string smethod_1(int int_0, int int_1)
	{
		if (int_1 <= 0)
		{
			return Class185.smethod_0(-1141262328);
		}
		return int_0 + Class185.smethod_0(-1141262332) + int_1;
	}

	internal static int smethod_2(int int_0, int int_1)
	{
		if (int_1 <= 0)
		{
			return -1;
		}
		int num = int_0 + 1;
		if (num < 0 || num >= int_1)
		{
			num = 0;
		}
		return num;
	}

	internal static bool smethod_3(DataGridViewRow dataGridViewRow_0)
	{
		if (dataGridViewRow_0 == null)
		{
			return false;
		}
		if (dataGridViewRow_0.DataGridView == null)
		{
			return false;
		}
		return dataGridViewRow_0.Index >= 0;
	}

	private static void smethod_4(List<DataGridViewRow> list_0, DataGridView dataGridView_0, string string_0)
	{
		if (dataGridView_0 == null)
		{
			return;
		}
		DataGridViewRowCollection rows = dataGridView_0.Rows;
		for (int i = 0; i < rows.Count; i++)
		{
			DataGridViewRow dataGridViewRow = rows[i];
			if (!dataGridViewRow.IsNewRow && dataGridViewRow.Cells.Count > 0)
			{
				object value = dataGridViewRow.Cells[0].Value;
				if (value != null && value.ToString().IndexOf(string_0, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					list_0.Add(dataGridViewRow);
				}
			}
		}
	}
}
