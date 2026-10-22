using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

internal static class Class440
{
	public static readonly string[] string_0 = new string[5] { "X", "Z", "Delay", "NoHit", "Y" };

	public static void smethod_0(DataGridView dataGridView_0)
	{
		if (dataGridView_0 != null)
		{
			while (dataGridView_0.Columns.Count < 5)
			{
				dataGridView_0.Columns.Add((dataGridView_0.Columns.Count == 3) ? ((DataGridViewColumn)new DataGridViewCheckBoxColumn()) : ((DataGridViewColumn)new DataGridViewTextBoxColumn()));
			}
			for (int i = 0; i < 5; i++)
			{
				DataGridViewColumn dataGridViewColumn = dataGridView_0.Columns[i];
				dataGridViewColumn.Name = string_0[i];
				dataGridViewColumn.HeaderText = string_0[i];
				dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
			dataGridView_0.Columns[4].Visible = false;
			dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}
	}

	public static int smethod_1(bool bool_0, string string_1)
	{
		if (!bool_0)
		{
			return 0;
		}
		if (!int.TryParse(string_1?.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
		{
			return 0;
		}
		return Math.Max(0, result);
	}

	public static string smethod_2(float float_0)
	{
		return float_0.ToString("0.##", CultureInfo.InvariantCulture);
	}

	public static string smethod_3(float float_0, float float_1)
	{
		return "X:" + float_0.ToString("F2", CultureInfo.InvariantCulture) + " , Z:" + float_1.ToString("F2", CultureInfo.InvariantCulture);
	}

	public static bool smethod_4(string string_1, out float float_0)
	{
		return float.TryParse(string_1?.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out float_0);
	}

	public static string smethod_5(float float_0, float float_1, float float_2)
	{
		return smethod_2(float_0) + "," + smethod_2(float_1) + "," + smethod_2(float_2);
	}

	public static bool smethod_6(string string_1, out float float_0, out float float_1, out float float_2)
	{
		float_0 = 0f;
		float_1 = 0f;
		float_2 = 0f;
		if (string_1 == null)
		{
			return false;
		}
		string[] array = string_1.Split(',');
		if (array.Length != 3)
		{
			return false;
		}
		if (!smethod_4(array[0], out var float_3))
		{
			return false;
		}
		if (!smethod_4(array[1], out var float_4))
		{
			return false;
		}
		if (!smethod_4(array[2], out var float_5))
		{
			return false;
		}
		float_0 = float_3;
		float_1 = float_4;
		float_2 = float_5;
		return true;
	}

	public static bool smethod_7(string string_1)
	{
		bool result;
		return bool.TryParse(string_1?.Trim(), out result) && result;
	}

	public static string[] smethod_8(Struct76 struct76_0)
	{
		return new string[5]
		{
			smethod_2(struct76_0.float_0),
			smethod_2(struct76_0.float_2),
			struct76_0.int_0.ToString(CultureInfo.InvariantCulture),
			struct76_0.bool_0.ToString(),
			smethod_2(struct76_0.float_1)
		};
	}

	public static bool smethod_9(string[] string_1, out Struct76 struct76_0)
	{
		struct76_0 = new Struct76
		{
			int_1 = -1
		};
		if (string_1 != null && string_1.Length >= 5)
		{
			if (!smethod_4(string_1[0], out var float_))
			{
				return false;
			}
			if (!smethod_4(string_1[1], out var float_2))
			{
				return false;
			}
			if (!smethod_4(string_1[4], out var float_3))
			{
				float_3 = 0f;
			}
			if (!int.TryParse(string_1[2], NumberStyles.Integer, CultureInfo.InvariantCulture, out var result) || result < 0)
			{
				result = 0;
			}
			struct76_0 = new Struct76
			{
				float_0 = float_,
				float_1 = float_3,
				float_2 = float_2,
				int_0 = result,
				bool_0 = smethod_7(string_1[3]),
				int_1 = -1
			};
			return true;
		}
		return false;
	}

	public static List<Struct76> smethod_10(DataGridView dataGridView_0)
	{
		List<Struct76> list = new List<Struct76>();
		if (dataGridView_0 == null)
		{
			return list;
		}
		for (int i = 0; i < dataGridView_0.Rows.Count; i++)
		{
			DataGridViewRow dataGridViewRow = dataGridView_0.Rows[i];
			if (!dataGridViewRow.IsNewRow)
			{
				string[] array = new string[5];
				for (int j = 0; j < 5; j++)
				{
					array[j] = dataGridViewRow.Cells[j].Value?.ToString();
				}
				if (smethod_9(array, out var struct76_))
				{
					struct76_.int_1 = i;
					list.Add(struct76_);
				}
			}
		}
		return list;
	}

	public static void smethod_11(DataGridView dataGridView_0, int int_0)
	{
		if (dataGridView_0 != null && int_0 >= 0 && int_0 < dataGridView_0.Rows.Count && (dataGridView_0.CurrentRow == null || dataGridView_0.CurrentRow.Index != int_0 || !dataGridView_0.Rows[int_0].Selected))
		{
			dataGridView_0.ClearSelection();
			dataGridView_0.Rows[int_0].Selected = true;
			dataGridView_0.FirstDisplayedScrollingRowIndex = int_0;
		}
	}

	public static string smethod_12(List<string[]> list_0, string string_1, DateTime dateTime_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		JArray val = new JArray();
		if (list_0 != null)
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				string[] array = list_0[i];
				JArray val2 = new JArray();
				for (int j = 0; j < 5; j++)
				{
					string text = ((array == null || j >= array.Length || array[j] == null) ? string.Empty : array[j]);
					val2.Add(JToken.op_Implicit(text));
				}
				val.Add((JToken)(object)val2);
			}
		}
		return ((JToken)new JObject
		{
			["SaveDate"] = JToken.op_Implicit(dateTime_0.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)),
			["GridName"] = JToken.op_Implicit("grid1"),
			["HeroName"] = JToken.op_Implicit((string_1 == null) ? string.Empty : string_1),
			["RowData"] = (JToken)(object)val
		}).ToString((Formatting)1, Array.Empty<JsonConverter>());
	}

	public static List<string[]> smethod_13(string string_1, out int int_0)
	{
		int_0 = 0;
		if (string.IsNullOrWhiteSpace(string_1))
		{
			return null;
		}
		JObject val;
		try
		{
			val = JObject.Parse(string_1);
		}
		catch (JsonException)
		{
			return null;
		}
		JToken obj = val["RowData"];
		JArray val2 = (JArray)(object)((obj is JArray) ? obj : null);
		if (val2 == null)
		{
			return null;
		}
		List<string[]> list = new List<string[]>();
		for (int i = 0; i < ((JContainer)val2).Count; i++)
		{
			JToken obj2 = val2[i];
			JArray val3 = (JArray)(object)((obj2 is JArray) ? obj2 : null);
			string[] array = null;
			if (val3 != null)
			{
				array = new string[((JContainer)val3).Count];
				for (int j = 0; j < ((JContainer)val3).Count; j++)
				{
					array[j] = smethod_14(val3[j]);
				}
			}
			string[] array2 = smethod_15(array);
			if (array2 == null)
			{
				int_0++;
			}
			else
			{
				list.Add(array2);
			}
		}
		if (list.Count != 0)
		{
			return list;
		}
		return null;
	}

	private static string smethod_14(JToken jtoken_0)
	{
		JValue val = (JValue)(object)((jtoken_0 is JValue) ? jtoken_0 : null);
		if (val != null && val.Value != null)
		{
			return Convert.ToString(val.Value, CultureInfo.InvariantCulture);
		}
		return null;
	}

	public static string[] smethod_15(string[] string_1)
	{
		if (string_1 != null && string_1.Length > 1)
		{
			if (!smethod_4(string_1[0], out var _))
			{
				return null;
			}
			if (!smethod_4(string_1[1], out var _))
			{
				return null;
			}
			string[] array = new string[5]
			{
				string_1[0].Trim(),
				string_1[1].Trim(),
				null,
				null,
				null
			};
			if (string_1.Length > 2 && string_1[2] != null && int.TryParse(string_1[2].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
			{
				array[2] = Math.Max(0, result).ToString(CultureInfo.InvariantCulture);
			}
			else
			{
				array[2] = "0";
			}
			if (string_1.Length > 3 && string_1[3] != null && bool.TryParse(string_1[3].Trim(), out var result2))
			{
				array[3] = result2.ToString();
			}
			else
			{
				array[3] = bool.FalseString;
			}
			if (string_1.Length > 4 && smethod_4(string_1[4], out var _))
			{
				array[4] = string_1[4].Trim();
			}
			else
			{
				array[4] = "0";
			}
			return array;
		}
		return null;
	}

	public static List<Struct76> smethod_16(DataGridView dataGridView_0)
	{
		List<Struct76> list = new List<Struct76>();
		if (dataGridView_0 != null && dataGridView_0.Columns.Count >= 3)
		{
			for (int i = 0; i < dataGridView_0.Rows.Count; i++)
			{
				DataGridViewRow dataGridViewRow = dataGridView_0.Rows[i];
				if (!dataGridViewRow.IsNewRow)
				{
					object value = dataGridViewRow.Cells[0].Value;
					object value2 = dataGridViewRow.Cells[1].Value;
					object value3 = dataGridViewRow.Cells[2].Value;
					if (smethod_4(value?.ToString(), out var float_) && smethod_4(value2?.ToString(), out var float_2) && smethod_4(value3?.ToString(), out var float_3))
					{
						list.Add(new Struct76
						{
							float_0 = float_,
							float_1 = float_2,
							float_2 = float_3,
							int_0 = 0,
							bool_0 = false,
							int_1 = -1
						});
					}
				}
			}
			return list;
		}
		return list;
	}

	public static int smethod_17(List<Struct76> list_0, float float_0, float float_1)
	{
		if (list_0 != null && list_0.Count != 0)
		{
			int result = 0;
			float num = smethod_19(float_0, float_1, list_0[0].float_0, list_0[0].float_2);
			for (int i = 1; i < list_0.Count; i++)
			{
				float num2 = smethod_19(float_0, float_1, list_0[i].float_0, list_0[i].float_2);
				if (num2 < num)
				{
					num = num2;
					result = i;
				}
			}
			return result;
		}
		return -1;
	}

	public static int smethod_18(int int_0, int int_1)
	{
		if (int_1 > 0)
		{
			return (int_0 + 1) % int_1;
		}
		return -1;
	}

	public static float smethod_19(float float_0, float float_1, float float_2, float float_3)
	{
		float num = float_0 - float_2;
		float num2 = float_1 - float_3;
		return (float)Math.Sqrt(num * num + num2 * num2);
	}

	public static bool smethod_20(float float_0)
	{
		return float_0 <= 5f;
	}

	public static float smethod_21(int int_0, int int_1)
	{
		if (int_0 != 0 && int_0 < int_1 - 1)
		{
			return 35f;
		}
		return 5f;
	}
}
