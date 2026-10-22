using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

internal sealed class Form6 : Form
{
	private readonly Class119 class119_0;

	private readonly Label label_0;

	private readonly Label label_1;

	private readonly ProgressBar progressBar_0;

	private readonly Timer timer_0;

	private readonly Stopwatch stopwatch_0 = new Stopwatch();

	private readonly int int_0;

	private readonly string string_0;

	private long long_0 = -1L;

	private Font[] font_0;

	private Class81.Enum4 enum4_0;

	private IReadOnlyList<Struct140> ireadOnlyList_0;

	private int int_1;

	private string string_1;

	internal Form6(Class119 class119_1)
	{
		class119_0 = class119_1;
		method_1((Class81.Enum4)0);
		method_3(new Struct140[0]);
		method_7(string.Empty);
		Class145 @class = ((class119_1 == null) ? Class145.class145_0 : class119_1.method_51());
		int_0 = @class.method_77();
		string_0 = @class.method_81();
		Text = "Reading the friend list";
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.StartPosition = FormStartPosition.CenterParent;
		base.ControlBox = false;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.ShowInTaskbar = false;
		base.ClientSize = new Size(420, 170);
		BackColor = Color.FromArgb(30, 30, 30);
		ForeColor = Color.Gainsboro;
		Font font = new Font("Tahoma", 11f);
		Font font2 = new Font("Tahoma", 9f);
		Font font3 = new Font("Tahoma", 8.5f);
		font_0 = new Font[3] { font, font2, font3 };
		label_0 = new Label();
		label_0.Text = "Reading the friend list...";
		label_0.Location = new Point(0, 26);
		label_0.Size = new Size(420, 26);
		label_0.TextAlign = ContentAlignment.MiddleCenter;
		label_0.Font = font;
		base.Controls.Add(label_0);
		label_1 = new Label();
		label_1.Text = Class81.smethod_3(0L);
		label_1.Location = new Point(0, 54);
		label_1.Size = new Size(420, 22);
		label_1.TextAlign = ContentAlignment.MiddleCenter;
		label_1.ForeColor = Color.Gray;
		label_1.Font = font2;
		base.Controls.Add(label_1);
		progressBar_0 = new ProgressBar();
		progressBar_0.Location = new Point(60, 88);
		progressBar_0.Size = new Size(300, 23);
		progressBar_0.Style = ProgressBarStyle.Marquee;
		progressBar_0.MarqueeAnimationSpeed = 30;
		base.Controls.Add(progressBar_0);
		Label value = new Label
		{
			Text = "The game is asked once; the list arrives when the server answers.",
			Location = new Point(0, 122),
			Size = new Size(420, 22),
			TextAlign = ContentAlignment.MiddleCenter,
			ForeColor = Color.Gray,
			Font = font3
		};
		base.Controls.Add(value);
		timer_0 = new Timer();
		timer_0.Interval = 250;
		timer_0.Tick += timer_0_Tick;
		base.Shown += Form6_Shown;
	}

	internal Class81.Enum4 method_0()
	{
		return enum4_0;
	}

	private void method_1(Class81.Enum4 enum4_1)
	{
		enum4_0 = enum4_1;
	}

	internal IReadOnlyList<Struct140> method_2()
	{
		return ireadOnlyList_0;
	}

	private void method_3(IReadOnlyList<Struct140> ireadOnlyList_1)
	{
		ireadOnlyList_0 = ireadOnlyList_1;
	}

	internal int method_4()
	{
		return int_1;
	}

	private void method_5(int int_2)
	{
		int_1 = int_2;
	}

	internal string method_6()
	{
		return string_1;
	}

	private void method_7(string string_2)
	{
		string_1 = string_2;
	}

	private void Form6_Shown(object sender, EventArgs e)
	{
		stopwatch_0.Start();
		timer_0.Start();
		timer_0_Tick(this, EventArgs.Empty);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (base.IsDisposed)
		{
			return;
		}
		if (class119_0 == null)
		{
			method_8((Class81.Enum4)4, Class145.class145_0);
			return;
		}
		long elapsedMilliseconds = stopwatch_0.ElapsedMilliseconds;
		Class145 @class = class119_0.method_51();
		Class81.Enum4 @enum = Class81.smethod_2(Class81.smethod_1(@class.method_77(), @class.method_81(), int_0, string_0), @class.method_75(), @class.method_81(), elapsedMilliseconds);
		if (@enum != 0)
		{
			method_8(@enum, @class);
			return;
		}
		string text = Class81.smethod_3(elapsedMilliseconds);
		if (label_1.Text != text)
		{
			label_1.Text = text;
		}
		if (Class81.smethod_0(long_0, elapsedMilliseconds))
		{
			long_0 = elapsedMilliseconds;
			class119_0.method_172();
		}
	}

	private void method_8(Class81.Enum4 enum4_1, Class145 class145_0)
	{
		timer_0.Stop();
		method_1(enum4_1);
		method_3(class145_0.method_73());
		method_5(class145_0.method_79());
		method_7(class145_0.method_81() ?? string.Empty);
		Close();
	}

	protected override void OnFormClosed(FormClosedEventArgs e)
	{
		timer_0.Stop();
		timer_0.Tick -= timer_0_Tick;
		timer_0.Dispose();
		base.Shown -= Form6_Shown;
		stopwatch_0.Stop();
		progressBar_0.MarqueeAnimationSpeed = 0;
		base.OnFormClosed(e);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (!disposing || font_0 == null)
		{
			return;
		}
		for (int i = 0; i < font_0.Length; i++)
		{
			if (font_0[i] != null)
			{
				font_0[i].Dispose();
			}
		}
		font_0 = null;
	}
}
