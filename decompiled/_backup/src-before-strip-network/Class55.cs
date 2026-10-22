using System;
using System.Collections.Generic;
using System.Windows.Forms;

internal static class Class55
{
	private sealed class Class56 : IDisposable
	{
		public void Dispose()
		{
		}
	}

	internal static List<string> smethod_0(DataGridView dataGridView_0)
	{
		List<string> list = new List<string>();
		if (dataGridView_0 == null)
		{
			return list;
		}
		List<int> list2 = new List<int>();
		foreach (DataGridViewCell selectedCell in dataGridView_0.SelectedCells)
		{
			int rowIndex = selectedCell.RowIndex;
			if (rowIndex >= 0 && !list2.Contains(rowIndex))
			{
				list2.Add(rowIndex);
			}
		}
		if (list2.Count == 0 && dataGridView_0.CurrentCell != null)
		{
			int rowIndex2 = dataGridView_0.CurrentCell.RowIndex;
			if (rowIndex2 >= 0)
			{
				list2.Add(rowIndex2);
			}
		}
		if (list2.Count == 0)
		{
			return list;
		}
		list2.Sort();
		DataGridViewRowCollection rows = dataGridView_0.Rows;
		for (int i = 0; i < list2.Count; i++)
		{
			int num = list2[i];
			if (num < rows.Count)
			{
				string text = Class96.smethod_3(rows[num]);
				if (text.Length != 0 && !smethod_4(list, text))
				{
					list.Add(text);
				}
			}
		}
		return list;
	}

	internal static int smethod_1(DataGridView dataGridView_0, List<string> list_0, Class67 class67_0)
	{
		if (dataGridView_0 != null && list_0 != null && list_0.Count != 0)
		{
			int num = 0;
			using (smethod_5(class67_0, dataGridView_0))
			{
				for (int i = 0; i < list_0.Count; i++)
				{
					string text = list_0[i];
					if (text != null)
					{
						text = text.Trim();
						if (text.Length != 0 && !Class96.smethod_2(dataGridView_0, text))
						{
							dataGridView_0.Rows.Add(text);
							num++;
						}
					}
				}
				return num;
			}
		}
		return 0;
	}

	internal static int smethod_2(DataGridView dataGridView_0, List<string> list_0, Class67 class67_0)
	{
		if (dataGridView_0 != null && list_0 != null && list_0.Count != 0)
		{
			int num = 0;
			using (smethod_5(class67_0, dataGridView_0))
			{
				for (int i = 0; i < list_0.Count; i++)
				{
					for (int num2 = Class96.smethod_1(dataGridView_0, list_0[i]); num2 >= 0; num2 = Class96.smethod_1(dataGridView_0, list_0[i]))
					{
						dataGridView_0.Rows.RemoveAt(num2);
						num++;
					}
				}
				return num;
			}
		}
		return 0;
	}

	internal static bool smethod_3(DataGridView dataGridView_0, string string_0, Class67 class67_0)
	{
		if (dataGridView_0 != null && string_0 != null)
		{
			string_0 = string_0.Trim();
			if (string_0.Length == 0)
			{
				return false;
			}
			using (smethod_5(class67_0, dataGridView_0))
			{
				int num = Class96.smethod_1(dataGridView_0, string_0);
				if (num >= 0)
				{
					dataGridView_0.Rows.RemoveAt(num);
					return false;
				}
				dataGridView_0.Rows.Add(string_0);
				return true;
			}
		}
		return false;
	}

	private static bool smethod_4(List<string> list_0, string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (Class96.smethod_0(list_0[num], string_0))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static IDisposable smethod_5(Class67 class67_0, DataGridView dataGridView_0)
	{
		if (class67_0 != null)
		{
			return class67_0.method_17(dataGridView_0);
		}
		return new Class56();
	}
}
