using System;
using System.Drawing;
using System.Windows.Forms;

internal static class Class429
{
	private sealed class Class430
	{
		public IWin32Window iwin32Window_0;

		public string string_0;

		public string string_1;

		public MessageBoxButtons messageBoxButtons_0;

		public MessageBoxIcon messageBoxIcon_0;

		internal DialogResult method_0()
		{
			return smethod_3(iwin32Window_0, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
		}
	}

	internal static DialogResult smethod_0(IWin32Window iwin32Window_0, string string_0, string string_1)
	{
		return smethod_3(iwin32Window_0, string_0, string_1, MessageBoxButtons.OK, MessageBoxIcon.None);
	}

	internal static DialogResult smethod_1(string string_0)
	{
		return smethod_3(null, string_0, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None);
	}

	internal static DialogResult smethod_2(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return smethod_3(null, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	internal static DialogResult smethod_3(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		Class430 @class = new Class430();
		@class.iwin32Window_0 = iwin32Window_0;
		@class.string_0 = string_0;
		@class.string_1 = string_1;
		@class.messageBoxButtons_0 = messageBoxButtons_0;
		@class.messageBoxIcon_0 = messageBoxIcon_0;
		if (@class.iwin32Window_0 is Control { IsHandleCreated: not false, InvokeRequired: not false } control)
		{
			return (DialogResult)control.Invoke(new Func<DialogResult>(@class.method_0));
		}
		using Form owner = smethod_4(@class.iwin32Window_0);
		return MessageBox.Show(owner, @class.string_0, @class.string_1, @class.messageBoxButtons_0, @class.messageBoxIcon_0);
	}

	internal static Form smethod_4(IWin32Window iwin32Window_0)
	{
		Form form = iwin32Window_0 as Form;
		if (form == null && iwin32Window_0 is Control control)
		{
			form = control.FindForm();
		}
		return new Form
		{
			TopMost = true,
			ShowInTaskbar = false,
			FormBorderStyle = FormBorderStyle.None,
			StartPosition = FormStartPosition.Manual,
			Bounds = smethod_5(smethod_6(form), smethod_7(form))
		};
	}

	internal static Rectangle smethod_5(Rectangle rectangle_0, Rectangle rectangle_1)
	{
		Rectangle rectangle = ((rectangle_0.Width > 0 && rectangle_0.Height > 0 && rectangle_0.IntersectsWith(rectangle_1)) ? rectangle_0 : rectangle_1);
		return new Rectangle(rectangle.Left + rectangle.Width / 2, rectangle.Top + rectangle.Height / 2, 1, 1);
	}

	private static Rectangle smethod_6(Form form_0)
	{
		if (form_0 != null && !form_0.IsDisposed)
		{
			if (form_0.Visible && form_0.WindowState != FormWindowState.Minimized)
			{
				return form_0.Bounds;
			}
			return Rectangle.Empty;
		}
		return Rectangle.Empty;
	}

	private static Rectangle smethod_7(Form form_0)
	{
		return ((form_0 == null || form_0.IsDisposed || !form_0.IsHandleCreated) ? Screen.PrimaryScreen : Screen.FromControl(form_0)).WorkingArea;
	}
}
