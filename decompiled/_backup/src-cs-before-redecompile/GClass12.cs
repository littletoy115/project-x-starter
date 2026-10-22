using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public sealed class GClass12 : ProgressBar
{
	public Color color_0 = Color.Yellow;

	public Color color_1 = Color.Green;

	public int int_0 = 100;

	public int int_1;

	private readonly Label label_0;

	public GClass12()
	{
		DoubleBuffered = true;
		SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
		label_0 = new Label
		{
			AutoSize = false,
			TextAlign = ContentAlignment.MiddleCenter,
			Dock = DockStyle.Fill,
			BackColor = Color.Transparent
		};
		base.Controls.Add(label_0);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		method_0(e.Graphics);
	}

	internal void method_0(Graphics graphics_0)
	{
		_ = base.ClientRectangle;
		int num = ((int_0 <= 0) ? 1 : int_0);
		int num2 = (int)((float)int_1 / (float)num * (float)base.Width);
		if (num2 < 0)
		{
			num2 = 0;
		}
		if (num2 > base.Width)
		{
			num2 = base.Width;
		}
		if (num2 > 0)
		{
			if (color_0 == color_1)
			{
				SolidBrush solidBrush = new SolidBrush(color_0);
				try
				{
					graphics_0.FillRectangle(solidBrush, 0, 0, num2, base.Height);
				}
				finally
				{
					((IDisposable)solidBrush).Dispose();
				}
			}
			else
			{
				LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(num2, 0), color_0, color_1);
				try
				{
					graphics_0.FillRectangle(linearGradientBrush, 0, 0, num2, base.Height);
				}
				finally
				{
					((IDisposable)linearGradientBrush).Dispose();
				}
			}
		}
		Pen pen = new Pen(Color.Black);
		try
		{
			graphics_0.DrawRectangle(pen, 0, 0, base.Width - 1, base.Height - 1);
		}
		finally
		{
			((IDisposable)pen).Dispose();
		}
	}

	public void method_1(int int_2, string string_0)
	{
		int_1 = Math.Max(0, Math.Min(int_2, int_0));
		if (string_0 != null)
		{
			label_0.Text = string_0;
		}
		Invalidate();
	}

	public static GClass12 smethod_0(Control control_0, Color color_2, Color color_3, int int_2, int int_3, int int_4, int int_5, TabControl tabControl_0, int int_6)
	{
		GClass12 result = new GClass12
		{
			Location = new Point(int_2, int_3),
			Size = new Size(int_4, int_5),
			int_0 = 100,
			color_0 = color_2,
			color_1 = color_3
		};
		if (tabControl_0 != null && int_6 >= 0 && int_6 < tabControl_0.TabPages.Count)
		{
			tabControl_0.TabPages[int_6].Controls.Add(result);
		}
		else
		{
			control_0.Controls.Add(result);
		}
		return result;
	}
}
