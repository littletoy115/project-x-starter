using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

internal static class Class433
{
	private sealed class Class434
	{
		public GForm0 gform0_0;

		public int int_0;

		public int int_1;

		internal void method_0()
		{
			gform0_0.smethod_1(int_0, int_1);
		}
	}

	private sealed class Class435
	{
		public string string_0;

		public Button button_0;

		public string string_1;

		public bool? nullable_0;

		public string string_2;

		public TaskCompletionSource<object> taskCompletionSource_0;

		internal void method_0()
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				button_0.Text = string_0;
			}
			if (!string.IsNullOrEmpty(string_1))
			{
				button_0.ForeColor = Color.FromName(string_1);
			}
			if (nullable_0.HasValue)
			{
				button_0.Enabled = nullable_0.Value;
			}
			if (!string.IsNullOrEmpty(string_2))
			{
				string text = string_2;
				if (!(text == Class185.smethod_0(-1141265009)))
				{
					if (!(text == Class185.smethod_0(-1141265029)))
					{
						if (!(text == Class185.smethod_0(-1141265039)))
						{
							if (!(text == Class185.smethod_0(-1141265044)))
							{
								button_0.BackColor = Color.FromName(string_2);
							}
							else
							{
								button_0.BackColor = Color.FromArgb(128, 255, 255);
							}
						}
						else
						{
							button_0.BackColor = Color.FromArgb(255, 255, 128);
						}
					}
					else
					{
						button_0.BackColor = Color.FromArgb(255, 128, 128);
					}
				}
				else
				{
					button_0.BackColor = Color.FromArgb(128, 255, 128);
				}
			}
			taskCompletionSource_0.SetResult(null);
		}
	}

	public static Task smethod_0(this GForm0 gform0_0, int int_0, bool? nullable_0, string string_0, string string_1, string string_2)
	{
		Class435 @class = new Class435();
		@class.string_0 = string_0;
		@class.string_1 = string_2;
		@class.nullable_0 = nullable_0;
		@class.string_2 = string_1;
		@class.button_0 = Class80.smethod_0(gform0_0.Controls.Find(Class185.smethod_0(-1141262286) + int_0, searchAllChildren: true)) as Button;
		if (@class.button_0 == null)
		{
			return Task.CompletedTask;
		}
		@class.taskCompletionSource_0 = new TaskCompletionSource<object>();
		Action action = @class.method_0;
		if (@class.button_0.InvokeRequired)
		{
			@class.button_0.BeginInvoke(action);
		}
		else
		{
			action();
		}
		return @class.taskCompletionSource_0.Task;
	}

	public static void smethod_1(this GForm0 gform0_0, int int_0, int int_1)
	{
		Class434 @class = new Class434();
		@class.gform0_0 = gform0_0;
		@class.int_0 = int_0;
		@class.int_1 = int_1;
		if (@class.gform0_0.InvokeRequired)
		{
			@class.gform0_0.BeginInvoke(new Action(@class.method_0));
			return;
		}
		for (int i = @class.int_0; i <= @class.int_1; i++)
		{
			if (Class80.smethod_0(@class.gform0_0.Controls.Find(Class185.smethod_0(-1141262286) + i, searchAllChildren: true)) is Button button)
			{
				button.Enabled = true;
			}
		}
	}
}
