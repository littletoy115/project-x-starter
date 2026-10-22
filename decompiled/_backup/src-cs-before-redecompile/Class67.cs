using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

internal sealed class Class67
{
	private sealed class Class68
	{
		public Class67 class67_0;

		public DataGridView dataGridView_0;

		internal void method_0(object sender, DataGridViewCellEventArgs e)
		{
			class67_0.method_16(dataGridView_0);
		}

		internal void method_1(object sender, DataGridViewRowsAddedEventArgs e)
		{
			class67_0.method_16(dataGridView_0);
		}

		internal void method_2(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			class67_0.method_16(dataGridView_0);
		}
	}

	private sealed class Class69 : IDisposable
	{
		private readonly Class67 class67_0;

		private readonly DataGridView dataGridView_0;

		private readonly bool bool_0;

		internal Class69(Class67 class67_1, DataGridView dataGridView_1)
		{
			class67_0 = class67_1;
			dataGridView_0 = dataGridView_1;
			bool_0 = !class67_1.hashSet_2.Add(dataGridView_1);
			if (!bool_0)
			{
				class67_1.hashSet_3.Add(dataGridView_1);
			}
		}

		public void Dispose()
		{
			if (!bool_0)
			{
				class67_0.hashSet_2.Remove(dataGridView_0);
				class67_0.hashSet_3.Remove(dataGridView_0);
				if (class67_0.hashSet_4.Remove(dataGridView_0) || class67_0.hashSet_5.Contains(dataGridView_0))
				{
					class67_0.method_16(dataGridView_0);
				}
			}
		}
	}

	[Serializable]
	private sealed class Class70
	{
		public static readonly Class70 class70_0 = new Class70();

		public static Action<string> action_0;

		internal void method_0(string string_0)
		{
		}
	}

	private readonly string string_0;

	private readonly Dictionary<DataGridView, string> dictionary_0 = new Dictionary<DataGridView, string>();

	private readonly Dictionary<DataGridView, string> dictionary_1 = new Dictionary<DataGridView, string>();

	private readonly HashSet<DataGridView> hashSet_0 = new HashSet<DataGridView>();

	private readonly HashSet<DataGridView> hashSet_1 = new HashSet<DataGridView>();

	private string string_1;

	private readonly HashSet<DataGridView> hashSet_2 = new HashSet<DataGridView>();

	private readonly HashSet<DataGridView> hashSet_3 = new HashSet<DataGridView>();

	private readonly HashSet<DataGridView> hashSet_4 = new HashSet<DataGridView>();

	private readonly HashSet<DataGridView> hashSet_5 = new HashSet<DataGridView>();

	internal Action<string> action_0 = Class70.class70_0.method_0;

	private int int_0;

	internal Class67(string string_2 = "config")
	{
		string_0 = string_2 ?? "config";
	}

	internal int method_0()
	{
		return hashSet_1.Count;
	}

	internal string method_1()
	{
		return string_1;
	}

	internal string method_2()
	{
		return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string_0);
	}

	internal int method_3()
	{
		return int_0;
	}

	private void method_4(int int_1)
	{
		int_0 = int_1;
	}

	internal void method_5(DataGridView dataGridView_0, string string_2, bool bool_0)
	{
		if (dataGridView_0 == null)
		{
			throw new ArgumentNullException("\u000e");
		}
		if (string.IsNullOrEmpty(string_2))
		{
			throw new ArgumentNullException("\u0003");
		}
		if (dictionary_0.ContainsKey(dataGridView_0))
		{
			if (bool_0)
			{
				method_19(dataGridView_0, string_2);
			}
			dictionary_0[dataGridView_0] = string_2;
		}
		else if (!method_14(dataGridView_0, string_2))
		{
			dictionary_0[dataGridView_0] = string_2;
			if (bool_0)
			{
				method_19(dataGridView_0, string_2);
			}
			method_15(dataGridView_0);
		}
	}

	internal void method_6(DataGridView dataGridView_0, string string_2, bool bool_0)
	{
		if (dataGridView_0 == null)
		{
			throw new ArgumentNullException("\u000e");
		}
		hashSet_0.Add(dataGridView_0);
		method_5(dataGridView_0, string_2, bool_0);
	}

	internal void method_7(DataGridView dataGridView_0, string string_2)
	{
		if (dataGridView_0 == null)
		{
			throw new ArgumentNullException("\u000e");
		}
		if (string.IsNullOrEmpty(string_2))
		{
			throw new ArgumentNullException("\u0003");
		}
		if (dictionary_1.ContainsKey(dataGridView_0))
		{
			dictionary_1[dataGridView_0] = string_2;
			if (string_1 != null)
			{
				method_12(dataGridView_0, string_2);
			}
			return;
		}
		foreach (KeyValuePair<DataGridView, string> item in dictionary_1)
		{
			if (string.Equals(item.Value, string_2, StringComparison.OrdinalIgnoreCase))
			{
				action_0("[Grids] " + string_2 + " is already " + item.Key.Name + ", refusing " + dataGridView_0.Name);
				return;
			}
		}
		dictionary_1[dataGridView_0] = string_2;
		method_15(dataGridView_0);
		if (string_1 != null)
		{
			method_12(dataGridView_0, string_2);
		}
	}

	internal int method_8(string string_2)
	{
		string_1 = Class176.smethod_0(string_2);
		List<DataGridView> list = new List<DataGridView>(dictionary_1.Keys);
		foreach (DataGridView item in list)
		{
			method_12(item, dictionary_1[item]);
		}
		action_0("[Grids] " + string_1 + " loaded " + list.Count + " personal grids");
		return list.Count;
	}

	internal bool method_9(DataGridView dataGridView_0)
	{
		if (dataGridView_0 != null && dictionary_0.TryGetValue(dataGridView_0, out var value))
		{
			return method_19(dataGridView_0, value);
		}
		return false;
	}

	internal int method_10(DataGridView dataGridView_0)
	{
		if (dataGridView_0 != null && dictionary_0.TryGetValue(dataGridView_0, out var value))
		{
			string path = method_22(value);
			if (!File.Exists(path))
			{
				return 0;
			}
			Class404 @class;
			try
			{
				@class = JsonConvert.DeserializeObject<Class404>(File.ReadAllText(path, Encoding.UTF8));
			}
			catch (Exception ex)
			{
				action_0("[Grids] " + value + " could not be read, load-all skipped: " + ex.Message);
				return 0;
			}
			if (@class != null && @class.List_1 != null)
			{
				string text = smethod_1(dataGridView_0);
				if (text == null)
				{
					return 0;
				}
				HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
				foreach (DataGridViewRow item in (IEnumerable)dataGridView_0.Rows)
				{
					if (!item.IsNewRow)
					{
						object value2 = item.Cells[text].Value;
						if (value2 != null)
						{
							hashSet.Add(value2.ToString());
						}
					}
				}
				int num = 0;
				using (method_17(dataGridView_0))
				{
					foreach (Dictionary<string, string> item2 in @class.List_1)
					{
						if (item2 == null || !item2.TryGetValue(text, out var value3) || string.IsNullOrEmpty(value3) || !hashSet.Add(value3))
						{
							continue;
						}
						int index = dataGridView_0.Rows.Add();
						DataGridViewRow dataGridViewRow2 = dataGridView_0.Rows[index];
						foreach (DataGridViewColumn column in dataGridView_0.Columns)
						{
							if (!string.IsNullOrEmpty(column.Name) && item2.TryGetValue(column.Name, out var value4))
							{
								dataGridViewRow2.Cells[column.Index].Value = smethod_3(column, value4);
							}
						}
						num++;
					}
				}
				action_0("[Grids] " + dataGridView_0.Name + " load-all added " + num + " from " + value);
				return num;
			}
			return 0;
		}
		return 0;
	}

	internal int method_11(DataGridView dataGridView_0, string string_2)
	{
		if (dataGridView_0 != null && !string.IsNullOrEmpty(string_2))
		{
			string path = method_22(string_2);
			if (!File.Exists(path))
			{
				return 0;
			}
			Class404 @class;
			try
			{
				@class = JsonConvert.DeserializeObject<Class404>(File.ReadAllText(path, Encoding.UTF8));
			}
			catch (Exception ex)
			{
				action_0("[Grids] " + string_2 + " could not be read, catalogue load skipped: " + ex.Message);
				return 0;
			}
			if (@class != null && @class.List_1 != null)
			{
				List<DataGridViewColumn> list = new List<DataGridViewColumn>();
				foreach (DataGridViewColumn column in dataGridView_0.Columns)
				{
					if (!string.IsNullOrEmpty(column.Name))
					{
						list.Add(column);
					}
				}
				if (list.Count == 0)
				{
					return 0;
				}
				List<string> list2 = smethod_0(@class);
				if (list2.Count == 0)
				{
					return 0;
				}
				string key = list2[0];
				int index = list[0].Index;
				HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
				foreach (DataGridViewRow item in (IEnumerable)dataGridView_0.Rows)
				{
					if (!item.IsNewRow)
					{
						object value = item.Cells[index].Value;
						if (value != null)
						{
							hashSet.Add(value.ToString());
						}
					}
				}
				int num = ((list2.Count < list.Count) ? list2.Count : list.Count);
				int num2 = 0;
				using (method_17(dataGridView_0))
				{
					foreach (Dictionary<string, string> item2 in @class.List_1)
					{
						if (item2 == null || !item2.TryGetValue(key, out var value2) || string.IsNullOrEmpty(value2) || !hashSet.Add(value2))
						{
							continue;
						}
						int index2 = dataGridView_0.Rows.Add();
						DataGridViewRow dataGridViewRow2 = dataGridView_0.Rows[index2];
						for (int i = 0; i < num; i++)
						{
							if (item2.TryGetValue(list2[i], out var value3))
							{
								dataGridViewRow2.Cells[list[i].Index].Value = smethod_3(list[i], value3);
							}
						}
						num2++;
					}
				}
				action_0("[Grids] " + dataGridView_0.Name + " catalogue load added " + num2 + " from " + string_2);
				return num2;
			}
			return 0;
		}
		return 0;
	}

	private static List<string> smethod_0(Class404 class404_0)
	{
		List<string> list = new List<string>();
		if (class404_0.List_0 != null)
		{
			foreach (Class88 item in class404_0.List_0)
			{
				if (item != null && !string.IsNullOrEmpty(item.String_0))
				{
					list.Add(item.String_0);
				}
			}
		}
		if (list.Count > 0)
		{
			return list;
		}
		foreach (Dictionary<string, string> item2 in class404_0.List_1)
		{
			if (item2 == null || item2.Count == 0)
			{
				continue;
			}
			foreach (string key in item2.Keys)
			{
				list.Add(key);
			}
			break;
		}
		return list;
	}

	private void method_12(DataGridView dataGridView_0, string string_2)
	{
		string text = Class176.smethod_1(string_1, string_2);
		dictionary_0[dataGridView_0] = text;
		method_13(dataGridView_0);
		method_19(dataGridView_0, text);
	}

	private void method_13(DataGridView dataGridView_0)
	{
		if (dataGridView_0.Rows.Count == 0)
		{
			return;
		}
		hashSet_2.Add(dataGridView_0);
		try
		{
			dataGridView_0.Rows.Clear();
		}
		finally
		{
			hashSet_2.Remove(dataGridView_0);
		}
	}

	private bool method_14(DataGridView dataGridView_0, string string_2)
	{
		foreach (KeyValuePair<DataGridView, string> item in dictionary_0)
		{
			if (item.Key != dataGridView_0 && string.Equals(item.Value, string_2, StringComparison.OrdinalIgnoreCase))
			{
				action_0("[Grids] " + string_2 + " is already " + item.Key.Name + ", refusing " + dataGridView_0.Name);
				return true;
			}
		}
		return false;
	}

	private void method_15(DataGridView dataGridView_0)
	{
		Class68 @class = new Class68();
		@class.class67_0 = this;
		@class.dataGridView_0 = dataGridView_0;
		if (hashSet_1.Add(@class.dataGridView_0))
		{
			@class.dataGridView_0.CellValueChanged += @class.method_0;
			@class.dataGridView_0.RowsAdded += @class.method_1;
			@class.dataGridView_0.RowsRemoved += @class.method_2;
		}
	}

	private void method_16(DataGridView dataGridView_0)
	{
		string value;
		if (hashSet_2.Contains(dataGridView_0))
		{
			if (hashSet_3.Contains(dataGridView_0))
			{
				hashSet_4.Add(dataGridView_0);
			}
		}
		else if (dictionary_0.TryGetValue(dataGridView_0, out value))
		{
			if (method_20(dataGridView_0, value))
			{
				hashSet_5.Remove(dataGridView_0);
			}
			else
			{
				hashSet_5.Add(dataGridView_0);
			}
		}
	}

	internal IDisposable method_17(DataGridView dataGridView_0)
	{
		if (dataGridView_0 == null)
		{
			throw new ArgumentNullException("\u000e");
		}
		return new Class69(this, dataGridView_0);
	}

	internal static string smethod_1(DataGridView dataGridView_0)
	{
		if (dataGridView_0 == null)
		{
			return null;
		}
		foreach (DataGridViewColumn column in dataGridView_0.Columns)
		{
			if (!string.IsNullOrEmpty(column.Name))
			{
				return column.Name;
			}
		}
		return null;
	}

	internal List<Dictionary<string, string>> method_18(string string_2)
	{
		List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
		if (string.IsNullOrEmpty(string_2))
		{
			return list;
		}
		string path = method_22(string_2);
		if (!File.Exists(path))
		{
			action_0("[Grids] " + string_2 + " is not there, nothing read");
			return list;
		}
		Class404 @class;
		try
		{
			@class = JsonConvert.DeserializeObject<Class404>(File.ReadAllText(path, Encoding.UTF8));
		}
		catch (Exception ex)
		{
			action_0("[Grids] " + string_2 + " could not be read, nothing read: " + ex.Message);
			return list;
		}
		if (@class != null && @class.List_1 != null)
		{
			foreach (Dictionary<string, string> item in @class.List_1)
			{
				if (item != null)
				{
					list.Add(item);
				}
			}
			action_0("[Grids] " + string_2 + " read " + list.Count + " rows");
			return list;
		}
		action_0("[Grids] " + string_2 + " has no rows");
		return list;
	}

	internal static List<string> smethod_2(List<Dictionary<string, string>> list_0, string string_2)
	{
		List<string> list = new List<string>();
		if (list_0 != null && !string.IsNullOrEmpty(string_2))
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i] != null && list_0[i].TryGetValue(string_2, out var value) && value != null && value.Trim().Length != 0)
				{
					list.Add(value);
				}
			}
			return list;
		}
		return list;
	}

	internal bool method_19(DataGridView dataGridView_0, string string_2)
	{
		if (dataGridView_0 != null && !string.IsNullOrEmpty(string_2))
		{
			string path = method_22(string_2);
			if (!File.Exists(path))
			{
				return false;
			}
			Class404 @class;
			try
			{
				@class = JsonConvert.DeserializeObject<Class404>(File.ReadAllText(path, Encoding.UTF8));
			}
			catch (Exception ex)
			{
				action_0("[Grids] " + string_2 + " could not be read, " + dataGridView_0.Name + " left as it is: " + ex.Message);
				return false;
			}
			if (@class != null && @class.List_1 != null)
			{
				hashSet_2.Add(dataGridView_0);
				dataGridView_0.SuspendLayout();
				try
				{
					dataGridView_0.Rows.Clear();
					HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
					foreach (Dictionary<string, string> item in @class.List_1)
					{
						if (item == null)
						{
							continue;
						}
						int index = dataGridView_0.Rows.Add();
						DataGridViewRow dataGridViewRow = dataGridView_0.Rows[index];
						foreach (DataGridViewColumn column in dataGridView_0.Columns)
						{
							if (!string.IsNullOrEmpty(column.Name) && item.TryGetValue(column.Name, out var value))
							{
								dataGridViewRow.Cells[column.Index].Value = smethod_3(column, value);
							}
						}
						foreach (string key in item.Keys)
						{
							if (dataGridView_0.Columns[key] == null)
							{
								hashSet.Add(key);
							}
						}
					}
					if (hashSet.Count > 0)
					{
						action_0("[Grids] " + string_2 + " has values for columns " + dataGridView_0.Name + " does not have: " + string.Join(", ", smethod_5(hashSet)));
					}
					action_0("[Grids] " + dataGridView_0.Name + " loaded " + dataGridView_0.Rows.Count + " rows from " + string_2);
				}
				finally
				{
					dataGridView_0.ResumeLayout();
					hashSet_2.Remove(dataGridView_0);
				}
				return true;
			}
			action_0("[Grids] " + string_2 + " has no rows, " + dataGridView_0.Name + " left as it is");
			return false;
		}
		return false;
	}

	private static object smethod_3(DataGridViewColumn dataGridViewColumn_0, string string_2)
	{
		if (!(dataGridViewColumn_0 is DataGridViewCheckBoxColumn))
		{
			return string_2;
		}
		bool result;
		return bool.TryParse(string_2, out result) && result;
	}

	internal bool method_20(DataGridView dataGridView_0, string string_2)
	{
		if (dataGridView_0 != null && !string.IsNullOrEmpty(string_2))
		{
			List<Class88> list = new List<Class88>();
			List<DataGridViewColumn> list2 = new List<DataGridViewColumn>();
			foreach (DataGridViewColumn column in dataGridView_0.Columns)
			{
				if (!string.IsNullOrEmpty(column.Name))
				{
					list.Add(new Class88
					{
						String_0 = column.Name,
						String_1 = column.HeaderText
					});
					list2.Add(column);
				}
			}
			List<Dictionary<string, string>> list3 = new List<Dictionary<string, string>>();
			foreach (DataGridViewRow item in (IEnumerable)dataGridView_0.Rows)
			{
				if (item.IsNewRow)
				{
					continue;
				}
				Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
				bool flag = true;
				foreach (DataGridViewColumn item2 in list2)
				{
					object value = item.Cells[item2.Index].Value;
					string text = ((value == null) ? string.Empty : value.ToString());
					if (text.Length != 0)
					{
						dictionary[item2.Name] = text;
						continue;
					}
					flag = false;
					break;
				}
				if (flag && dictionary.Count > 0)
				{
					list3.Add(dictionary);
				}
			}
			string text2 = method_22(string_2);
			string text3 = null;
			try
			{
				Directory.CreateDirectory(Path.GetDirectoryName(text2));
				Mutex mutex = new Mutex(initiallyOwned: false, smethod_4(text2));
				try
				{
					bool flag2 = false;
					try
					{
						try
						{
							flag2 = mutex.WaitOne(250);
						}
						catch (AbandonedMutexException)
						{
							flag2 = true;
						}
						if (!flag2)
						{
							throw new IOException("catalogue write lock is busy");
						}
						if (hashSet_0.Contains(dataGridView_0) && list2.Count > 0)
						{
							list3 = method_21(text2, list3, list2[0].Name);
						}
						Class404 @class = new Class404
						{
							String_0 = dataGridView_0.Name,
							DateTime_0 = DateTime.UtcNow,
							List_0 = list,
							List_1 = list3
						};
						text3 = text2 + "." + Guid.NewGuid().ToString("N") + ".tmp";
						File.WriteAllText(text3, JsonConvert.SerializeObject((object)@class, (Formatting)1), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
						if (File.Exists(text2))
						{
							File.Replace(text3, text2, null);
						}
						else
						{
							File.Move(text3, text2);
						}
						text3 = null;
					}
					finally
					{
						if (flag2)
						{
							mutex.ReleaseMutex();
						}
					}
				}
				finally
				{
					((IDisposable)mutex).Dispose();
				}
			}
			catch (Exception ex2)
			{
				action_0("[Grids] " + string_2 + " not written: " + ex2.Message);
				return false;
			}
			finally
			{
				if (text3 != null)
				{
					try
					{
						File.Delete(text3);
					}
					catch (IOException)
					{
					}
					catch (UnauthorizedAccessException)
					{
					}
				}
			}
			int num = method_3();
			method_4(num + 1);
			return true;
		}
		return false;
	}

	private List<Dictionary<string, string>> method_21(string string_2, List<Dictionary<string, string>> list_0, string string_3)
	{
		if (!File.Exists(string_2))
		{
			return list_0;
		}
		Class404 @class = JsonConvert.DeserializeObject<Class404>(File.ReadAllText(string_2, Encoding.UTF8));
		if (@class != null && @class.List_1 != null)
		{
			List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			foreach (Dictionary<string, string> item in @class.List_1)
			{
				if (item != null)
				{
					list.Add(item);
					if (item.TryGetValue(string_3, out var value) && !string.IsNullOrEmpty(value))
					{
						hashSet.Add(value);
					}
				}
			}
			{
				foreach (Dictionary<string, string> item2 in list_0)
				{
					if (item2.TryGetValue(string_3, out var value2) && !string.IsNullOrEmpty(value2) && hashSet.Add(value2))
					{
						list.Add(item2);
					}
				}
				return list;
			}
		}
		throw new InvalidDataException("catalogue has no rows");
	}

	private string method_22(string string_2)
	{
		return Path.Combine(method_2(), string_2);
	}

	private static string smethod_4(string string_2)
	{
		string s = Path.GetFullPath(string_2).ToUpperInvariant();
		using SHA256 sHA = SHA256.Create();
		byte[] array = sHA.ComputeHash(Encoding.UTF8.GetBytes(s));
		return "Local\\CapybaraGrid." + BitConverter.ToString(array).Replace("-", string.Empty);
	}

	private static string[] smethod_5(HashSet<string> hashSet_6)
	{
		string[] array = new string[hashSet_6.Count];
		hashSet_6.CopyTo(array);
		return array;
	}
}
