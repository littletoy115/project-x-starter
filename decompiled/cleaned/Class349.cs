using System.Text;

internal static class Class349
{
	internal static readonly byte[] byte_0 = Encoding.UTF8.GetBytes(Class185.smethod_0(-1141203211));

	internal static string smethod_0(byte[] byte_1)
	{
		if (byte_1 == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(byte_1.Length * 2);
		foreach (byte b in byte_1)
		{
			stringBuilder.Append(b.ToString(Class185.smethod_0(-1141346677)));
		}
		return stringBuilder.ToString();
	}

	internal static bool smethod_1(string string_0, int int_0, out byte[] byte_1)
	{
		byte_1 = null;
		if (string_0 != null && string_0.Length == int_0 * 2)
		{
			byte[] array = new byte[int_0];
			int num = 0;
			while (true)
			{
				if (num < array.Length)
				{
					int num2 = smethod_2(string_0[num * 2]);
					int num3 = smethod_2(string_0[num * 2 + 1]);
					if (num2 < 0 || num3 < 0)
					{
						break;
					}
					array[num] = (byte)((num2 << 4) | num3);
					num++;
					continue;
				}
				byte_1 = array;
				return true;
			}
			return false;
		}
		return false;
	}

	private static int smethod_2(char char_0)
	{
		if (char_0 >= '0' && char_0 <= '9')
		{
			return char_0 - 48;
		}
		if (char_0 >= 'a' && char_0 <= 'f')
		{
			return char_0 - 97 + 10;
		}
		if (char_0 >= 'A' && char_0 <= 'F')
		{
			return char_0 - 65 + 10;
		}
		return -1;
	}
}
