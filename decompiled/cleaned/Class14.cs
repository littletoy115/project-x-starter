using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal sealed class Class14
{
	private readonly Form form_0;

	private Point point_0;

	internal Class14(Form form_1)
	{
		if (form_1 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141036201));
		}
		form_0 = form_1;
	}

	[DllImport("user32.dll")]
	private static extern bool ReleaseCapture();

	[DllImport("user32.dll")]
	private static extern IntPtr SendMessage(IntPtr intptr_0, int int_0, int int_1, int int_2);

	internal void method_0()
	{
		foreach (Control item in smethod_1(form_0))
		{
			item.MouseDown += method_1;
			item.MouseMove += method_2;
		}
	}

	internal static bool smethod_0(Control control_0)
	{
		if (!(control_0 is TextBox) && !(control_0 is ComboBox) && !(control_0 is TrackBar))
		{
			return control_0 is RichTextBox;
		}
		return true;
	}

	internal static List<Control> smethod_1(Control control_0)
	{
		List<Control> list = new List<Control>();
		smethod_2(control_0, list);
		return list;
	}

	private static void smethod_2(Control control_0, List<Control> list_0)
	{
		list_0.Add(control_0);
		foreach (Control control in control_0.Controls)
		{
			if (!smethod_0(control))
			{
				smethod_2(control, list_0);
			}
		}
	}

	internal static bool smethod_3(Point point_1, Point point_2)
	{
		if (Math.Abs(point_2.X - point_1.X) <= 5)
		{
			return Math.Abs(point_2.Y - point_1.Y) > 5;
		}
		return true;
	}

	private void method_1(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			point_0 = e.Location;
		}
	}

	private void method_2(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && smethod_3(point_0, e.Location))
		{
			ReleaseCapture();
			SendMessage(form_0.Handle, 161, 2, 0);
		}
	}
}
