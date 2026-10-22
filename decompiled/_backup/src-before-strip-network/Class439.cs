using System;

internal sealed class Class439 : Interface2
{
	public IntPtr imethod_0()
	{
		Class384.smethod_9();
		return Class63.klx_open();
	}

	public int imethod_1(IntPtr intptr_0, string string_0, string string_1, int int_0)
	{
		return Class63.klx_connect_remote(intptr_0, Class63.smethod_0(string_0), Class63.smethod_0(string_1), int_0);
	}

	public int imethod_2(IntPtr intptr_0, uint uint_0, int int_0)
	{
		return Class63.klx_attach(intptr_0, uint_0, int_0);
	}

	public int imethod_3(IntPtr intptr_0, string string_0, int int_0)
	{
		return Class63.klx_load_script(intptr_0, Class63.smethod_0(string_0), int_0);
	}

	public void imethod_4(IntPtr intptr_0, Class63.Delegate15 delegate15_0, Class63.Delegate16 delegate16_0, IntPtr intptr_1)
	{
		Class63.klx_set_callbacks(intptr_0, delegate15_0, delegate16_0, intptr_1);
	}

	public void imethod_5(IntPtr intptr_0, string string_0, byte[] byte_0, int int_0)
	{
		Class63.klx_post(intptr_0, Class63.smethod_0(string_0), byte_0, int_0);
	}

	public string imethod_6(IntPtr intptr_0)
	{
		return Class63.smethod_2(intptr_0);
	}

	public void imethod_7(IntPtr intptr_0)
	{
		Class63.klx_close(intptr_0);
	}
}
