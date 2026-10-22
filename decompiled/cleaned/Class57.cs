using System;
using System.IO;
using System.Security.Cryptography;

internal static class Class57
{
	internal static void smethod_0(out byte[] byte_0, out string string_0)
	{
		using (Stream stream = typeof(Class57).Assembly.GetManifestResourceStream(Class185.smethod_0(-1141209753)))
		{
			if (stream == null)
			{
				throw new InvalidDataException(Class185.smethod_0(-1141202106));
			}
			using MemoryStream memoryStream = new MemoryStream();
			stream.CopyTo(memoryStream);
			byte_0 = memoryStream.ToArray();
		}
		string_0 = smethod_1(byte_0);
	}

	internal static string smethod_1(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141209771));
		}
		if (byte_0.Length >= 20 && byte_0[0] == 127 && byte_0[1] == 69 && byte_0[2] == 76 && byte_0[3] == 70)
		{
			if (byte_0[4] != 2)
			{
				throw new InvalidDataException(Class185.smethod_0(-1141209843));
			}
			if (byte_0[5] != 1)
			{
				throw new InvalidDataException(Class185.smethod_0(-1141209898));
			}
			if ((byte_0[18] | (byte_0[19] << 8)) != 183)
			{
				throw new InvalidDataException(Class185.smethod_0(-1141209961));
			}
			using SHA256 sHA = SHA256.Create();
			return BitConverter.ToString(sHA.ComputeHash(byte_0)).Replace(Class185.smethod_0(-1141293701), string.Empty).ToLowerInvariant();
		}
		throw new InvalidDataException(Class185.smethod_0(-1141209790));
	}
}
