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
			Form8 form = new Form8(Class185.smethod_0(-1141295111), Class185.smethod_0(-1141295418), MessageBoxButtons.YesNo)
			{
				BackColor = Color.White
			};
			nullable_0 = form.ShowDialog() == DialogResult.Yes;
		}

		internal void method_1()
		{
			Form8 form = new Form8(Class185.smethod_0(-1141295462), Class185.smethod_0(-1141295418))
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
		dateTime = DateTime.Parse(Class185.smethod_0(-1141296648), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
		dateTime2 = DateTime.UtcNow;
		int num;
		if (!(dateTime2 > dateTime) && !(dateTime2 < dateTime.AddDays(-21.0)))
		{
			if (!Class0.smethod_1())
			{
				num = (smethod_1(flag) ? 1 : 0);
			}
			else if (!Class0.smethod_3(Class185.smethod_0(-1141296963)))
			{
				try
				{
					smethod_3();
					Form8 form = new Form8(Class185.smethod_0(-1141297014), Class185.smethod_0(-1141295418));
					form.BackColor = Color.White;
					form.ShowDialog();
				}
				catch
				{
				}
				if (flag)
				{
					throw new Exception(Class185.smethod_0(-1141296231));
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
			text2 = string.Format(Class185.smethod_0(-1141296675), text);
			if (flag)
			{
				throw new Exception(text2);
			}
			smethod_3();
			Application.Run(new Form8(text2, Class185.smethod_0(-1141296937)));
			num = 0;
		}
	}
}
