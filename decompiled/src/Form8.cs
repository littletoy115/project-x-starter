using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

internal sealed class Form8 : Form
{
	public Form8(string string_0, string string_1)
		: this(string_0, string_1, MessageBoxButtons.OK)
	{
	}

	public Form8(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0)
		: this(string_0, string_1, "Error", messageBoxButtons_0)
	{
	}

	public Form8(string string_0, string string_1, string string_2, MessageBoxButtons messageBoxButtons_0)
	{
		Label label = new Label();
		PictureBox pictureBox = new PictureBox();
		SuspendLayout();
		pictureBox.Image = smethod_0(string_2);
		pictureBox.Location = new Point(8, 8);
		pictureBox.Size = new Size(48, 48);
		pictureBox.TabStop = false;
		label.Location = new Point(64, 24);
		label.Size = new Size(310, 114);
		label.Text = string_0;
		switch (messageBoxButtons_0)
		{
		case MessageBoxButtons.YesNo:
			method_2();
			break;
		case MessageBoxButtons.OK:
			method_0();
			break;
		}
		AutoScaleBaseSize = new Size(5, 13);
		base.ClientSize = new Size(388, 197);
		base.Controls.AddRange(new Control[2] { label, pictureBox });
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		Text = string_1;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.TopMost = true;
		ResumeLayout(performLayout: false);
	}

	private void method_0()
	{
		Button button = new Button
		{
			FlatStyle = FlatStyle.System,
			Location = new Point(169, 162),
			TabIndex = 0,
			Text = "OK",
			DialogResult = DialogResult.OK
		};
		button.Click += method_1;
		base.Controls.Add(button);
		base.AcceptButton = button;
		base.CancelButton = button;
	}

	private void method_1(object sender, EventArgs e)
	{
		Close();
	}

	private void method_2()
	{
		Button button = new Button
		{
			FlatStyle = FlatStyle.System,
			Location = new Point(124, 162),
			TabIndex = 1,
			Text = "Yes",
			DialogResult = DialogResult.Yes
		};
		Button button2 = new Button
		{
			FlatStyle = FlatStyle.System,
			Location = new Point(214, 162),
			TabIndex = 0,
			Text = "No",
			DialogResult = DialogResult.No
		};
		base.Controls.AddRange(new Control[2] { button, button2 });
		base.AcceptButton = button;
		base.CancelButton = button2;
	}

	private static Bitmap smethod_0(string string_0)
	{
		Stream manifestResourceStream = typeof(Form8).Assembly.GetManifestResourceStream("Eazfuscator.NET.Runtime.Licensing.WindowsForms." + string_0 + ".png");
		if (manifestResourceStream != null)
		{
			return new Bitmap(manifestResourceStream);
		}
		return null;
	}
}
