using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class GForm2 : Form
{
	public GClass12 gclass12_0;

	private Label label_0;

	private IContainer icontainer_0;

	public GForm2()
	{
		method_2();
		base.FormBorderStyle = FormBorderStyle.None;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Size = new Size(400, 200);
		base.TopMost = true;
		label_0 = new Label
		{
			Text = Class185.smethod_0(-1141265671),
			Location = new Point(0, 50),
			Size = new Size(400, 30),
			TextAlign = ContentAlignment.MiddleCenter,
			Font = new Font(Class185.smethod_0(-1141265716), 14f)
		};
		base.Controls.Add(label_0);
		gclass12_0 = GClass12.smethod_0(this, Color.FromArgb(255, 128, 128), Color.FromArgb(128, 255, 128), 50, 100, 300, 23, null, 0);
	}

	public void method_0(string string_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new Action<string>(method_0), string_0);
		}
		else
		{
			label_0.Text = string_0;
		}
	}

	public void method_1(int int_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new Action<int>(method_1), int_0);
		}
		else
		{
			int_0 = Math.Max(0, Math.Min(100, int_0));
			gclass12_0.method_1(int_0, string.Format(Class185.smethod_0(-1141265729), int_0));
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_2()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm2));
		SuspendLayout();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(800, 450);
		base.Icon = (Icon)componentResourceManager.GetObject(Class185.smethod_0(-1141260701));
		base.Name = Class185.smethod_0(-1141265740);
		base.ShowInTaskbar = false;
		Text = Class185.smethod_0(-1141265740);
		ResumeLayout(performLayout: false);
	}
}
