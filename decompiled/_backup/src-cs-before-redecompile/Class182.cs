using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

internal static class Class182
{
	private sealed class Class183
	{
		public ThreadStart threadStart_0;

		public Exception exception_0;

		internal void method_0()
		{
			try
			{
				threadStart_0();
			}
			catch (Exception ex)
			{
				exception_0 = ex;
			}
		}
	}

	private sealed class Class184
	{
		public bool? nullable_0;

		internal void method_0()
		{
			Form8 form = new Form8("This application has been built with an evaluation version of Eazfuscator.NET, and therefore cannot be distributed.\n\nPress Yes if you want to run this application now.\n\nPress No if you aren't sure. If you don't trust the publisher, don't know what it is or how it landed on your machine then ALWAYS press No.", "Program Cannot Be Distributed", MessageBoxButtons.YesNo)
			{
				BackColor = Color.White
			};
			nullable_0 = form.ShowDialog() == DialogResult.Yes;
		}

		internal void method_1()
		{
			Form8 form = new Form8("This application has been built with an evaluation version of Eazfuscator.NET.\n\nThe application will now run but please note that it cannot be distributed.", "Program Cannot Be Distributed")
			{
				BackColor = Color.White
			};
			nullable_0 = form.ShowDialog() == DialogResult.OK;
		}
	}

	private static bool smethod_0(bool bool_0)
	{
		return true;
	}

	private static bool smethod_1(bool bool_0)
	{
		return true;
	}

	private static void smethod_2(ThreadStart threadStart_0)
	{
		Class183 @class = new Class183();
		@class.threadStart_0 = threadStart_0;
		@class.exception_0 = null;
		Thread thread = new Thread(@class.method_0);
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = true;
		thread.Start();
		thread.Join();
		if (@class.exception_0 != null)
		{
			throw @class.exception_0;
		}
	}

	private static void smethod_3()
	{
		try
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
		}
		catch
		{
		}
	}

	public static bool smethod_4()
	{
		return smethod_0(bool_0: false);
	}

	public static void smethod_5()
	{
		smethod_0(bool_0: true);
	}

	public static void smethod_6()
	{
		bool flag = true;
		DateTime dateTime = default(DateTime);
		DateTime dateTime2 = default(DateTime);
		string text = null;
		string text2 = null;
		dateTime = DateTime.Parse("2026-10-20T00:26:04.9101588Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
		dateTime2 = DateTime.UtcNow;
		int num;
		if (!(dateTime2 > dateTime) && !(dateTime2 < dateTime.AddDays(-21.0)))
		{
			if (!Class0.smethod_1())
			{
				num = (smethod_1(flag) ? 1 : 0);
			}
			else if (!Class0.smethod_3("09105f9a-eaff-42c4-a114-ecfb6ac6f796"))
			{
				try
				{
					smethod_3();
					Form8 form = new Form8("This application has been built with an evaluation version of Eazfuscator.NET, and therefore cannot be distributed.\n\nYou can install Eazfuscator.NET on this computer to be able to run this application.\n\nThis application will now quit.", "Program Cannot Be Distributed");
					form.BackColor = Color.White;
					form.ShowDialog();
				}
				catch
				{
				}
				if (flag)
				{
					throw new Exception("This application has been built with an evaluation version of Eazfuscator.NET, and therefore cannot be distributed. You can install Eazfuscator.NET on this computer to be able to run this application.");
				}
				num = 0;
			}
			else
			{
				num = 1;
			}
		}
		else
		{
			text = typeof(Class182).Assembly.GetName().Name;
			text2 = string.Format("This copy of '{0}' has expired and will no longer run.\n\nThis happened because it was created using an evaluation version of Gapotchenko's Eazfuscator.NET which is only licensed for testing purposes. \n\nYou should report this problem to the vendor of '{0}'.", text);
			if (flag)
			{
				throw new Exception(text2);
			}
			smethod_3();
			Application.Run(new Form8(text2, "Program Has Expired"));
			num = 0;
		}
	}
}
