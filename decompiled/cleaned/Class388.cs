using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

internal static class Class388
{
	private sealed class Class389 : IDisposable
	{
		public void Dispose()
		{
		}
	}

	internal static int smethod_0(DataGridView dataGridView_0, DataGridView dataGridView_1, Class67 class67_0)
	{
		if (dataGridView_0 != null && dataGridView_1 != null && dataGridView_0 != dataGridView_1)
		{
			List<DataGridViewRow> list = new List<DataGridViewRow>();
			foreach (DataGridViewRow selectedRow in dataGridView_0.SelectedRows)
			{
				if (!selectedRow.IsNewRow)
				{
					list.Add(selectedRow);
				}
			}
			if (list.Count == 0)
			{
				return 0;
			}
			list.Sort(smethod_6);
			List<string> list2 = new List<string>();
			foreach (DataGridViewRow item in (IEnumerable)dataGridView_1.Rows)
			{
				if (!item.IsNewRow)
				{
					list2.Add(smethod_8(item));
				}
			}
			using (smethod_9(class67_0, dataGridView_1))
			{
				using (smethod_9(class67_0, dataGridView_0))
				{
					foreach (DataGridViewRow item2 in list)
					{
						string text = smethod_8(item2);
						if (text.Length != 0 && !smethod_7(list2, text))
						{
							list2.Add(text);
							dataGridView_1.Rows.Add(text);
						}
					}
					foreach (DataGridViewRow item3 in list)
					{
						dataGridView_0.Rows.Remove(item3);
					}
				}
			}
			return list.Count;
		}
		return 0;
	}

	internal static int smethod_1(DataGridView dataGridView_0, DataGridView dataGridView_1, Class67 class67_0)
	{
		if (dataGridView_0 != null && dataGridView_1 != null && dataGridView_0 != dataGridView_1)
		{
			List<string> list = new List<string>();
			foreach (DataGridViewRow item in (IEnumerable)dataGridView_1.Rows)
			{
				if (!item.IsNewRow)
				{
					list.Add(smethod_8(item));
				}
			}
			List<DataGridViewRow> list2 = new List<DataGridViewRow>();
			foreach (DataGridViewRow item2 in (IEnumerable)dataGridView_0.Rows)
			{
				if (!item2.IsNewRow)
				{
					string text = smethod_8(item2);
					if (text.Length > 0 && smethod_7(list, text))
					{
						list2.Add(item2);
					}
				}
			}
			if (list2.Count == 0)
			{
				return 0;
			}
			using (smethod_9(class67_0, dataGridView_0))
			{
				foreach (DataGridViewRow item3 in list2)
				{
					dataGridView_0.Rows.Remove(item3);
				}
			}
			return list2.Count;
		}
		return 0;
	}

	internal static int smethod_2(DataGridView dataGridView_0, Class67 class67_0)
	{
		if (dataGridView_0 == null)
		{
			return 0;
		}
		List<DataGridViewRow> list = new List<DataGridViewRow>();
		foreach (DataGridViewRow selectedRow in dataGridView_0.SelectedRows)
		{
			if (!selectedRow.IsNewRow)
			{
				list.Add(selectedRow);
			}
		}
		if (list.Count == 0 && dataGridView_0.CurrentCell != null)
		{
			DataGridViewRow dataGridViewRow2 = dataGridView_0.Rows[dataGridView_0.CurrentCell.RowIndex];
			if (!dataGridViewRow2.IsNewRow)
			{
				list.Add(dataGridViewRow2);
			}
		}
		if (list.Count == 0)
		{
			return 0;
		}
		using (smethod_9(class67_0, dataGridView_0))
		{
			foreach (DataGridViewRow item in list)
			{
				dataGridView_0.Rows.Remove(item);
			}
		}
		return list.Count;
	}

	internal static bool smethod_3(DataGridView dataGridView_0, DataGridView dataGridView_1, string string_0, Class67 class67_0)
	{
		if (dataGridView_0 != null && string_0 != null)
		{
			string_0 = string_0.Trim();
			if (string_0.Length == 0)
			{
				return false;
			}
			List<string> list_ = new List<string>();
			smethod_5(list_, dataGridView_0);
			smethod_5(list_, dataGridView_1);
			if (smethod_7(list_, string_0))
			{
				return false;
			}
			using (smethod_9(class67_0, dataGridView_0))
			{
				dataGridView_0.Rows.Add(string_0);
			}
			return true;
		}
		return false;
	}

	internal static int smethod_4(DataGridView dataGridView_0, List<string> list_0, Class67 class67_0)
	{
		if (dataGridView_0 != null && list_0 != null)
		{
			List<string> list = new List<string>();
			smethod_5(list, dataGridView_0);
			List<string> list2 = new List<string>();
			for (int i = 0; i < list_0.Count; i++)
			{
				string text = ((list_0[i] == null) ? string.Empty : list_0[i].Trim());
				if (text.Length != 0 && !smethod_7(list, text))
				{
					list.Add(text);
					list2.Add(text);
				}
			}
			if (list2.Count == 0)
			{
				return 0;
			}
			using (smethod_9(class67_0, dataGridView_0))
			{
				for (int j = 0; j < list2.Count; j++)
				{
					dataGridView_0.Rows.Add(list2[j]);
				}
			}
			return list2.Count;
		}
		return 0;
	}

	private static void smethod_5(List<string> list_0, DataGridView dataGridView_0)
	{
		if (dataGridView_0 == null)
		{
			return;
		}
		foreach (DataGridViewRow item in (IEnumerable)dataGridView_0.Rows)
		{
			if (!item.IsNewRow && item.Cells.Count != 0)
			{
				list_0.Add(smethod_8(item));
			}
		}
	}

	private static int smethod_6(DataGridViewRow dataGridViewRow_0, DataGridViewRow dataGridViewRow_1)
	{
		return dataGridViewRow_0.Index.CompareTo(dataGridViewRow_1.Index);
	}

	private static bool smethod_7(List<string> list_0, string string_0)
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

	internal static string smethod_8(DataGridViewRow dataGridViewRow_0)
	{
		object value = dataGridViewRow_0.Cells[0].Value;
		if (value != null)
		{
			return value.ToString().Trim();
		}
		return string.Empty;
	}

	private static IDisposable smethod_9(Class67 class67_0, DataGridView dataGridView_0)
	{
		if (class67_0 != null)
		{
			return class67_0.method_17(dataGridView_0);
		}
		return new Class389();
	}
}
