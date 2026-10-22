using System;
using System.Runtime.InteropServices;
using System.Text;

internal sealed class Class59 : IDisposable
{
	private IntPtr intptr_0;

	internal Class59(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException("Database path is empty", "\u000e");
		}
		if (sqlite3_open_v2(smethod_0(string_0), out intptr_0, 6, IntPtr.Zero) != 0)
		{
			string text = method_2();
			Dispose();
			throw new InvalidOperationException("SQLite open failed: " + text);
		}
	}

	internal void method_0(string string_0)
	{
		if (sqlite3_exec(intptr_0, smethod_0(string_0), IntPtr.Zero, IntPtr.Zero, out var intptr_) != 0)
		{
			string text = ((intptr_ == IntPtr.Zero) ? method_2() : Marshal.PtrToStringAnsi(intptr_));
			if (intptr_ != IntPtr.Zero)
			{
				sqlite3_free(intptr_);
			}
			throw new InvalidOperationException("SQLite execute failed: " + text);
		}
	}

	internal string method_1(string string_0)
	{
		if (sqlite3_prepare_v2(intptr_0, smethod_0(string_0), -1, out var intptr_, IntPtr.Zero) != 0)
		{
			throw new InvalidOperationException("SQLite prepare failed: " + method_2());
		}
		try
		{
			switch (sqlite3_step(intptr_))
			{
			case 101:
				return null;
			default:
				throw new InvalidOperationException("SQLite read failed: " + method_2());
			case 100:
			{
				IntPtr intPtr = sqlite3_column_text(intptr_, 0);
				return (intPtr == IntPtr.Zero) ? null : Marshal.PtrToStringAnsi(intPtr);
			}
			}
		}
		finally
		{
			sqlite3_finalize(intptr_);
		}
	}

	private string method_2()
	{
		if (!(intptr_0 == IntPtr.Zero))
		{
			return Marshal.PtrToStringAnsi(sqlite3_errmsg(intptr_0));
		}
		return "unknown error";
	}

	private static byte[] smethod_0(string string_0)
	{
		return Encoding.UTF8.GetBytes(string_0 + "\0");
	}

	public void Dispose()
	{
		if (!(intptr_0 == IntPtr.Zero))
		{
			sqlite3_close(intptr_0);
			intptr_0 = IntPtr.Zero;
		}
	}

	[DllImport("winsqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int sqlite3_open_v2(byte[] byte_0, out IntPtr intptr_1, int int_0, IntPtr intptr_2);

	[DllImport("winsqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int sqlite3_exec(IntPtr intptr_1, byte[] byte_0, IntPtr intptr_2, IntPtr intptr_3, out IntPtr intptr_4);

	[DllImport("winsqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int sqlite3_prepare_v2(IntPtr intptr_1, byte[] byte_0, int int_0, out IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("winsqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int sqlite3_step(IntPtr intptr_1);

	[DllImport("winsqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr sqlite3_column_text(IntPtr intptr_1, int int_0);

	[DllImport("winsqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int sqlite3_finalize(IntPtr intptr_1);

	[DllImport("winsqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int sqlite3_close(IntPtr intptr_1);

	[DllImport("winsqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr sqlite3_errmsg(IntPtr intptr_1);

	[DllImport("winsqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void sqlite3_free(IntPtr intptr_1);
}
