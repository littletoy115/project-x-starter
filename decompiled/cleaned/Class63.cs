using System;
using System.Runtime.InteropServices;
using System.Text;

internal static class Class63
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void Delegate15(IntPtr intptr_0, IntPtr intptr_1, int int_0, IntPtr intptr_2);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void Delegate16(int int_0, IntPtr intptr_0);

	[DllImport("klx.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr klx_frida_version();

	[DllImport("klx.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr klx_open();

	[DllImport("klx.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int klx_connect_remote(IntPtr intptr_0, byte[] byte_0, byte[] byte_1, int int_0);

	[DllImport("klx.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int klx_select_device(IntPtr intptr_0, byte[] byte_0, int int_0);

	[DllImport("klx.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int klx_attach(IntPtr intptr_0, uint uint_0, int int_0);

	[DllImport("klx.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int klx_load_script(IntPtr intptr_0, byte[] byte_0, int int_0);

	[DllImport("klx.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void klx_set_callbacks(IntPtr intptr_0, Delegate15 delegate15_0, Delegate16 delegate16_0, IntPtr intptr_1);

	[DllImport("klx.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void klx_post(IntPtr intptr_0, byte[] byte_0, byte[] byte_1, int int_0);

	[DllImport("klx.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr klx_last_error(IntPtr intptr_0);

	[DllImport("klx.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void klx_close(IntPtr intptr_0);

	internal static byte[] smethod_0(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		int byteCount = Encoding.UTF8.GetByteCount(string_0);
		byte[] array = new byte[byteCount + 1];
		Encoding.UTF8.GetBytes(string_0, 0, string_0.Length, array, 0);
		array[byteCount] = 0;
		return array;
	}

	internal static string smethod_1(IntPtr intptr_0)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			return null;
		}
		int i;
		for (i = 0; Marshal.ReadByte(intptr_0, i) != 0; i++)
		{
		}
		if (i == 0)
		{
			return string.Empty;
		}
		byte[] array = new byte[i];
		Marshal.Copy(intptr_0, array, 0, i);
		return Encoding.UTF8.GetString(array);
	}

	internal static string smethod_2(IntPtr intptr_0)
	{
		return smethod_1(klx_last_error(intptr_0)) ?? Class185.smethod_0(-1141178885);
	}
}
