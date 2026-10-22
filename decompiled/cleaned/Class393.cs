using System;

internal sealed class Class393
{
	internal readonly int int_0;

	internal readonly int int_1;

	internal readonly uint uint_0;

	internal readonly byte[] byte_0;

	internal readonly byte[] byte_1;

	internal readonly byte[] byte_2;

	internal Class393(int int_2, int int_3, uint uint_1, byte[] byte_3, byte[] byte_4, byte[] byte_5)
	{
		if (int_2 <= 0)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(-1141209679));
		}
		if (int_3 != 1)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(-1141209682));
		}
		smethod_1(byte_3, 16, Class185.smethod_0(-1141253472));
		smethod_1(byte_4, 32, Class185.smethod_0(-1141264978));
		smethod_0(byte_5, Class185.smethod_0(-1141204683));
		int_0 = int_2;
		int_1 = int_3;
		uint_0 = uint_1;
		byte_0 = (byte[])byte_3.Clone();
		byte_1 = (byte[])byte_4.Clone();
		byte_2 = (byte[])byte_5.Clone();
	}

	internal string method_0()
	{
		return Class349.smethod_0(byte_0);
	}

	internal static void smethod_0(byte[] byte_3, string string_0)
	{
		smethod_1(byte_3, 65, string_0);
		if (byte_3[0] != 4)
		{
			throw new ArgumentException(Class185.smethod_0(-1141209701), string_0);
		}
	}

	private static void smethod_1(byte[] byte_3, int int_2, string string_0)
	{
		if (byte_3 == null || byte_3.Length != int_2)
		{
			throw new ArgumentException(Class185.smethod_0(-1141209601), string_0);
		}
	}
}
