using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

internal sealed class Class11
{
	private sealed class Class12
	{
		public Class11 class11_0;

		public TextBox textBox_0;

		public CheckBox checkBox_0;

		public RadioButton radioButton_0;

		public ComboBox comboBox_0;

		public TrackBar trackBar_0;

		public NumericUpDown numericUpDown_0;

		public DateTimePicker dateTimePicker_0;

		internal void method_0(object sender, EventArgs e)
		{
			class11_0.method_14(textBox_0.Name, textBox_0.Text);
		}

		internal void method_1(object sender, EventArgs e)
		{
			class11_0.method_14(checkBox_0.Name, checkBox_0.Checked.ToString());
		}

		internal void method_2(object sender, EventArgs e)
		{
			class11_0.method_14(radioButton_0.Name, radioButton_0.Checked.ToString());
		}

		internal void method_3(object sender, EventArgs e)
		{
			class11_0.method_14(comboBox_0.Name, smethod_4(comboBox_0));
		}

		internal void method_4(object sender, EventArgs e)
		{
			class11_0.method_14(trackBar_0.Name, smethod_1(trackBar_0.Value));
		}

		internal void method_5(object sender, EventArgs e)
		{
			class11_0.method_14(numericUpDown_0.Name, smethod_2(numericUpDown_0.Value));
		}

		internal void method_6(object sender, EventArgs e)
		{
			class11_0.method_14(dateTimePicker_0.Name, smethod_3(dateTimePicker_0));
		}
	}

	[Serializable]
	private sealed class Class13
	{
		public static readonly Class13 class13_0 = new Class13();

		public static Action<string> action_0;

		internal void method_0(string string_0)
		{
		}
	}

	private readonly HashSet<Control> hashSet_0 = new HashSet<Control>();

	private bool bool_0;

	private readonly string string_0;

	private string string_1;

	private readonly HashSet<string> hashSet_1 = new HashSet<string>(StringComparer.Ordinal);

	private int int_0;

	internal Action<string> action_0 = Class13.class13_0.method_0;

	internal Class11(string string_2)
	{
		if (string.IsNullOrEmpty(string_2))
		{
			throw new ArgumentNullException("\u000e");
		}
		string_0 = string_2;
	}

	internal string method_0()
	{
		return string_1;
	}

	private void method_1(string string_2)
	{
		string_1 = string_2;
	}

	internal string method_2()
	{
		if (method_0() != null)
		{
			return Class176.smethod_1(method_0(), string_0);
		}
		return null;
	}

	internal HashSet<string> method_3()
	{
		return hashSet_1;
	}

	internal int method_4()
	{
		return hashSet_0.Count;
	}

	internal int method_5()
	{
		return int_0;
	}

	private void method_6(int int_1)
	{
		int_0 = int_1;
	}

	internal void method_7(Control control_0)
	{
		if (control_0 == null)
		{
			throw new ArgumentNullException("\u000e");
		}
		bool_0 = true;
		try
		{
			method_9(control_0, bool_1: true);
		}
		finally
		{
			bool_0 = false;
		}
		action_0("[Settings] bound " + hashSet_0.Count + " controls" + ((method_2() == null) ? ", no hero yet" : (" from " + method_2())));
	}

	internal void method_8(string string_2, Control control_0)
	{
		if (control_0 == null)
		{
			throw new ArgumentNullException("\u0003");
		}
		method_1(Class176.smethod_0(string_2));
		bool_0 = true;
		try
		{
			method_9(control_0, bool_1: false);
		}
		finally
		{
			bool_0 = false;
		}
		action_0("[Settings] loaded " + method_2());
	}

	private void method_9(Control control_0, bool bool_1)
	{
		foreach (Control control in control_0.Controls)
		{
			if (!(control is DataGridView) && !method_10(control, bool_1))
			{
				method_9(control, bool_1);
			}
		}
	}

	private bool method_10(Control control_0, bool bool_1)
	{
		if (!smethod_0(control_0))
		{
			return false;
		}
		if (string.IsNullOrEmpty(control_0.Name))
		{
			return true;
		}
		if (method_3().Contains(control_0.Name))
		{
			return true;
		}
		try
		{
			method_11(control_0);
		}
		catch (Exception ex)
		{
			action_0("[Settings] " + control_0.Name + " not restored: " + ex.Message);
		}
		if (bool_1 && hashSet_0.Add(control_0))
		{
			method_12(control_0);
		}
		return true;
	}

	private static bool smethod_0(Control control_0)
	{
		if (!(control_0 is TextBox) && !(control_0 is CheckBox) && !(control_0 is RadioButton) && !(control_0 is ComboBox) && !(control_0 is TrackBar) && !(control_0 is NumericUpDown))
		{
			return control_0 is DateTimePicker;
		}
		return true;
	}

	private void method_11(Control control_0)
	{
		string name = control_0.Name;
		TimeSpan result5;
		if (control_0 is TextBox textBox)
		{
			textBox.Text = method_13(name, textBox.Text);
		}
		else if (control_0 is CheckBox checkBox)
		{
			if (bool.TryParse(method_13(name, checkBox.Checked.ToString()), out var result))
			{
				checkBox.Checked = result;
			}
		}
		else if (control_0 is RadioButton radioButton)
		{
			if (bool.TryParse(method_13(name, radioButton.Checked.ToString()), out var result2))
			{
				radioButton.Checked = result2;
			}
		}
		else if (control_0 is ComboBox comboBox)
		{
			string text = method_13(name, smethod_4(comboBox));
			if (text.Length != 0)
			{
				int num = smethod_5(comboBox, text);
				if (num >= 0)
				{
					comboBox.SelectedIndex = num;
					return;
				}
				if (comboBox.DropDownStyle != ComboBoxStyle.DropDownList)
				{
					comboBox.Text = text;
					return;
				}
				action_0("[Settings] " + name + " has no item \"" + text + "\", left as it is");
			}
		}
		else if (control_0 is TrackBar trackBar)
		{
			if (int.TryParse(method_13(name, smethod_1(trackBar.Value)), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result3) && result3 >= trackBar.Minimum && result3 <= trackBar.Maximum)
			{
				trackBar.Value = result3;
			}
		}
		else if (control_0 is NumericUpDown numericUpDown)
		{
			if (decimal.TryParse(method_13(name, smethod_2(numericUpDown.Value)), NumberStyles.Number, CultureInfo.InvariantCulture, out var result4) && result4 >= numericUpDown.Minimum && result4 <= numericUpDown.Maximum)
			{
				numericUpDown.Value = result4;
			}
		}
		else if (control_0 is DateTimePicker dateTimePicker && TimeSpan.TryParse(method_13(name, smethod_3(dateTimePicker)), CultureInfo.InvariantCulture, out result5))
		{
			dateTimePicker.Value = DateTime.Today.Add(result5);
		}
	}

	private void method_12(Control control_0)
	{
		Class12 @class = new Class12();
		@class.class11_0 = this;
		@class.textBox_0 = control_0 as TextBox;
		if (@class.textBox_0 != null)
		{
			@class.textBox_0.TextChanged += @class.method_0;
			return;
		}
		@class.checkBox_0 = control_0 as CheckBox;
		if (@class.checkBox_0 != null)
		{
			@class.checkBox_0.CheckedChanged += @class.method_1;
			return;
		}
		@class.radioButton_0 = control_0 as RadioButton;
		if (@class.radioButton_0 != null)
		{
			@class.radioButton_0.CheckedChanged += @class.method_2;
			return;
		}
		@class.comboBox_0 = control_0 as ComboBox;
		if (@class.comboBox_0 != null)
		{
			@class.comboBox_0.SelectedIndexChanged += @class.method_3;
			return;
		}
		@class.trackBar_0 = control_0 as TrackBar;
		if (@class.trackBar_0 != null)
		{
			@class.trackBar_0.ValueChanged += @class.method_4;
			return;
		}
		@class.numericUpDown_0 = control_0 as NumericUpDown;
		if (@class.numericUpDown_0 != null)
		{
			@class.numericUpDown_0.ValueChanged += @class.method_5;
			return;
		}
		@class.dateTimePicker_0 = control_0 as DateTimePicker;
		if (@class.dateTimePicker_0 != null)
		{
			@class.dateTimePicker_0.ValueChanged += @class.method_6;
		}
	}

	private string method_13(string string_2, string string_3)
	{
		string text = method_2();
		if (text == null)
		{
			return string_3 ?? string.Empty;
		}
		return Class443.smethod_2(text, "Setting", string_2, string_3 ?? string.Empty, "config");
	}

	private void method_14(string string_2, string string_3)
	{
		if (!bool_0 && !string.IsNullOrEmpty(string_2))
		{
			string text = method_2();
			if (text != null)
			{
				int num = method_5();
				method_6(num + 1);
				Class443.smethod_1(text, "Setting", string_2, string_3, "config");
			}
		}
	}

	private static string smethod_1(int int_1)
	{
		return int_1.ToString(CultureInfo.InvariantCulture);
	}

	private static string smethod_2(decimal decimal_0)
	{
		return decimal_0.ToString(CultureInfo.InvariantCulture);
	}

	private static string smethod_3(DateTimePicker dateTimePicker_0)
	{
		return dateTimePicker_0.Value.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
	}

	private static string smethod_4(ComboBox comboBox_0)
	{
		if (comboBox_0.SelectedItem != null)
		{
			return comboBox_0.SelectedItem.ToString();
		}
		return comboBox_0.Text ?? string.Empty;
	}

	private static int smethod_5(ComboBox comboBox_0, string string_2)
	{
		int num = 0;
		while (true)
		{
			if (num < comboBox_0.Items.Count)
			{
				if (string.Equals(smethod_6(comboBox_0, num), string_2, StringComparison.Ordinal))
				{
					break;
				}
				num++;
				continue;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < comboBox_0.Items.Count)
				{
					if (string.Equals(smethod_6(comboBox_0, num2), string_2, StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					num2++;
					continue;
				}
				return -1;
			}
			return num2;
		}
		return num;
	}

	private static string smethod_6(ComboBox comboBox_0, int int_1)
	{
		object obj = comboBox_0.Items[int_1];
		if (obj != null)
		{
			return obj.ToString();
		}
		return string.Empty;
	}
}
