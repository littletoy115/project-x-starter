using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal sealed class Class103 : IDisposable
{
	private struct Struct29
	{
		internal uint uint_0;

		internal uint uint_1;

		internal IntPtr intptr_0;

		internal uint uint_2;

		internal IntPtr intptr_1;

		internal uint uint_3;

		internal IntPtr intptr_2;

		internal uint uint_4;

		internal IntPtr intptr_3;

		internal uint uint_5;

		internal uint uint_6;

		internal ulong ulong_0;

		internal uint uint_7;
	}

	internal readonly byte[] byte_0;

	internal readonly byte[] byte_1;

	internal readonly byte[] byte_2;

	internal readonly byte[] byte_3;

	internal readonly byte[] byte_4;

	private bool bool_0;

	private Class103(byte[] byte_5, byte[] byte_6, byte[] byte_7, byte[] byte_8)
	{
		byte_0 = byte_5;
		byte_1 = byte_6;
		byte_2 = byte_7;
		byte_3 = byte_8;
		byte_4 = smethod_15(new byte[4][] { byte_5, byte_6, byte_7, byte_8 });
	}

	[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
	private static extern int BCryptOpenAlgorithmProvider(out IntPtr intptr_0, string string_0, string string_1, uint uint_0);

	[DllImport("bcrypt.dll")]
	private static extern int BCryptCloseAlgorithmProvider(IntPtr intptr_0, uint uint_0);

	[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
	private static extern int BCryptSetProperty(IntPtr intptr_0, string string_0, byte[] byte_5, int int_0, uint uint_0);

	[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
	private static extern int BCryptGetProperty(IntPtr intptr_0, string string_0, byte[] byte_5, int int_0, out int int_1, uint uint_0);

	[DllImport("bcrypt.dll")]
	private static extern int BCryptGenerateSymmetricKey(IntPtr intptr_0, out IntPtr intptr_1, IntPtr intptr_2, int int_0, byte[] byte_5, int int_1, uint uint_0);

	[DllImport("bcrypt.dll")]
	private static extern int BCryptDestroyKey(IntPtr intptr_0);

	[DllImport("bcrypt.dll")]
	private static extern int BCryptEncrypt(IntPtr intptr_0, byte[] byte_5, int int_0, ref Struct29 struct29_0, byte[] byte_6, int int_1, byte[] byte_7, int int_2, out int int_3, uint uint_0);

	[DllImport("bcrypt.dll")]
	private static extern int BCryptDecrypt(IntPtr intptr_0, byte[] byte_5, int int_0, ref Struct29 struct29_0, byte[] byte_6, int int_1, byte[] byte_7, int int_2, out int int_3, uint uint_0);

	[DllImport("bcrypt.dll")]
	private static extern int BCryptGenerateKeyPair(IntPtr intptr_0, out IntPtr intptr_1, int int_0, uint uint_0);

	[DllImport("bcrypt.dll")]
	private static extern int BCryptFinalizeKeyPair(IntPtr intptr_0, uint uint_0);

	[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
	private static extern int BCryptExportKey(IntPtr intptr_0, IntPtr intptr_1, string string_0, byte[] byte_5, int int_0, out int int_1, uint uint_0);

	[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
	private static extern int BCryptImportKeyPair(IntPtr intptr_0, IntPtr intptr_1, string string_0, out IntPtr intptr_2, byte[] byte_5, int int_0, uint uint_0);

	[DllImport("bcrypt.dll")]
	private static extern int BCryptSecretAgreement(IntPtr intptr_0, IntPtr intptr_1, out IntPtr intptr_2, uint uint_0);

	[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
	private static extern int BCryptDeriveKey(IntPtr intptr_0, string string_0, IntPtr intptr_1, byte[] byte_5, int int_0, out int int_1, uint uint_0);

	[DllImport("bcrypt.dll")]
	private static extern int BCryptDestroySecret(IntPtr intptr_0);

	internal static Class103 smethod_0(Class393 class393_0, Class175 class175_0)
	{
		if (class393_0 == null)
		{
			throw new ArgumentNullException("hello");
		}
		byte[] array = smethod_2(class175_0);
		byte[] byte_ = null;
		byte[] byte_2 = null;
		byte[] array2 = null;
		byte[] array3 = null;
		byte[] array4 = new byte[12];
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr intptr_2 = IntPtr.Zero;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			smethod_18(BCryptOpenAlgorithmProvider(out intptr_, "ECDH_P256", null, 0u), "BCryptOpenAlgorithmProvider ECDH_P256");
			smethod_18(BCryptGenerateKeyPair(intptr_, out intptr_2, 256, 0u), "BCryptGenerateKeyPair");
			smethod_18(BCryptFinalizeKeyPair(intptr_2, 0u), "BCryptFinalizeKeyPair");
			byte[] array5 = smethod_9(intptr_2);
			intPtr = smethod_10(intptr_, class393_0.byte_2);
			byte_ = smethod_11(intptr_2, intPtr);
			array2 = smethod_15(new byte[4][]
			{
				Class349.byte_0,
				class393_0.byte_0,
				class393_0.byte_2,
				array5
			});
			array3 = smethod_15(new byte[5][]
			{
				Class349.byte_0,
				class393_0.byte_0,
				class393_0.byte_1,
				class393_0.byte_2,
				array5
			});
			byte_2 = smethod_5(byte_, class393_0.byte_1, array2, 32);
			using (RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create())
			{
				randomNumberGenerator.GetBytes(array4);
			}
			Class66 @class = smethod_6(byte_2, array4, array3, array);
			return new Class103(array5, array4, @class.byte_1, @class.byte_0);
		}
		finally
		{
			smethod_19(array);
			smethod_19(byte_);
			smethod_19(byte_2);
			smethod_19(array2);
			smethod_19(array3);
			if (intPtr != IntPtr.Zero)
			{
				BCryptDestroyKey(intPtr);
			}
			if (intptr_2 != IntPtr.Zero)
			{
				BCryptDestroyKey(intptr_2);
			}
			if (intptr_ != IntPtr.Zero)
			{
				BCryptCloseAlgorithmProvider(intptr_, 0u);
			}
		}
	}

	internal static Class103 smethod_1(Class393 class393_0, Class175 class175_0, byte[] byte_5, byte[] byte_6, byte[] byte_7)
	{
		if (class393_0 == null)
		{
			throw new ArgumentNullException("hello");
		}
		Class393.smethod_0(byte_6, "clientPublicKey");
		smethod_17(byte_5, 32, "privateScalar");
		smethod_17(byte_7, 12, "nonce");
		byte[] array = smethod_2(class175_0);
		byte[] byte_8 = null;
		byte[] byte_9 = null;
		byte[] array2 = null;
		byte[] array3 = null;
		try
		{
			byte_8 = smethod_4(byte_5, byte_6, class393_0.byte_2);
			array2 = smethod_15(new byte[4][]
			{
				Class349.byte_0,
				class393_0.byte_0,
				class393_0.byte_2,
				byte_6
			});
			array3 = smethod_15(new byte[5][]
			{
				Class349.byte_0,
				class393_0.byte_0,
				class393_0.byte_1,
				class393_0.byte_2,
				byte_6
			});
			byte_9 = smethod_5(byte_8, class393_0.byte_1, array2, 32);
			Class66 @class = smethod_6(byte_9, byte_7, array3, array);
			return new Class103((byte[])byte_6.Clone(), (byte[])byte_7.Clone(), @class.byte_1, @class.byte_0);
		}
		finally
		{
			smethod_19(array);
			smethod_19(byte_8);
			smethod_19(byte_9);
			smethod_19(array2);
			smethod_19(array3);
		}
	}

	internal static byte[] smethod_2(Class175 class175_0)
	{
		if (class175_0 == null)
		{
			throw new ArgumentNullException("credentials");
		}
		string[] array = new string[4] { class175_0.string_0, class175_0.string_1, class175_0.string_2, class175_0.string_3 };
		if (array[0] == null)
		{
			array[0] = string.Empty;
		}
		int num = 1;
		while (true)
		{
			if (num < array.Length)
			{
				if (string.IsNullOrEmpty(array[num]))
				{
					break;
				}
				num++;
				continue;
			}
			UTF8Encoding uTF8Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
			byte[][] array2 = new byte[array.Length][];
			int num2 = 0;
			try
			{
				int num3 = 0;
				byte[] array3;
				while (true)
				{
					if (num3 < array.Length)
					{
						string text = array[num3];
						for (int i = 0; i < text.Length; i++)
						{
							if (char.IsControl(text[i]))
							{
								throw new ArgumentException("Credential fields cannot contain control characters.", "credentials");
							}
						}
						array2[num3] = uTF8Encoding.GetBytes(array[num3]);
						if (array2[num3].Length <= 1024)
						{
							num2 = checked(num2 + 2 + array2[num3].Length);
							num3++;
							continue;
						}
						throw new ArgumentException("Credential field exceeds 1024 bytes.", "credentials");
					}
					if (num2 > 4096)
					{
						throw new ArgumentException("Credential plaintext exceeds 4096 bytes.", "credentials");
					}
					array3 = new byte[num2];
					int num4 = 0;
					byte[][] array4 = array2;
					foreach (byte[] array5 in array4)
					{
						array3[num4++] = (byte)array5.Length;
						array3[num4++] = (byte)(array5.Length >> 8);
						Buffer.BlockCopy(array5, 0, array3, num4, array5.Length);
						num4 += array5.Length;
					}
					break;
				}
				return array3;
			}
			finally
			{
				byte[][] array4 = array2;
				for (int i = 0; i < array4.Length; i++)
				{
					smethod_19(array4[i]);
				}
			}
		}
		throw new ArgumentException("Authenticated identity fields are required.", "credentials");
	}

	internal static void smethod_3(Class175 class175_0)
	{
		smethod_19(smethod_2(class175_0));
	}

	internal static byte[] smethod_4(byte[] byte_5, byte[] byte_6, byte[] byte_7)
	{
		smethod_17(byte_5, 32, "privateScalar");
		Class393.smethod_0(byte_6, "clientPublicKey");
		Class393.smethod_0(byte_7, "serverPublicKey");
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr intptr_2 = IntPtr.Zero;
		IntPtr intPtr = IntPtr.Zero;
		byte[] array = null;
		try
		{
			smethod_18(BCryptOpenAlgorithmProvider(out intptr_, "ECDH_P256", null, 0u), "BCryptOpenAlgorithmProvider ECDH_P256");
			array = smethod_13(byte_6, byte_5);
			smethod_18(BCryptImportKeyPair(intptr_, IntPtr.Zero, "ECCPRIVATEBLOB", out intptr_2, array, array.Length, 0u), "BCryptImportKeyPair private");
			intPtr = smethod_10(intptr_, byte_7);
			return smethod_11(intptr_2, intPtr);
		}
		finally
		{
			smethod_19(array);
			if (intPtr != IntPtr.Zero)
			{
				BCryptDestroyKey(intPtr);
			}
			if (intptr_2 != IntPtr.Zero)
			{
				BCryptDestroyKey(intptr_2);
			}
			if (intptr_ != IntPtr.Zero)
			{
				BCryptCloseAlgorithmProvider(intptr_, 0u);
			}
		}
	}

	internal static byte[] smethod_5(byte[] byte_5, byte[] byte_6, byte[] byte_7, int int_0)
	{
		if (byte_5 == null)
		{
			throw new ArgumentNullException("\u000e");
		}
		if (byte_6 == null)
		{
			throw new ArgumentNullException("\u0003");
		}
		if (byte_7 == null)
		{
			throw new ArgumentNullException("\u0006");
		}
		if (int_0 >= 0 && int_0 <= 8160)
		{
			byte[] array = null;
			byte[] array2 = new byte[0];
			byte[] array3 = new byte[int_0];
			bool flag = false;
			try
			{
				HMACSHA256 hMACSHA = new HMACSHA256(byte_6);
				try
				{
					array = hMACSHA.ComputeHash(byte_5);
				}
				finally
				{
					((IDisposable)hMACSHA).Dispose();
				}
				int num = 0;
				byte b = 1;
				while (num < int_0)
				{
					byte[] array4 = smethod_15(new byte[3][]
					{
						array2,
						byte_7,
						new byte[1] { b }
					});
					smethod_19(array2);
					HMACSHA256 hMACSHA2 = new HMACSHA256(array);
					try
					{
						array2 = hMACSHA2.ComputeHash(array4);
					}
					finally
					{
						((IDisposable)hMACSHA2).Dispose();
					}
					smethod_19(array4);
					int num2 = Math.Min(array2.Length, int_0 - num);
					Buffer.BlockCopy(array2, 0, array3, num, num2);
					num += num2;
					b++;
				}
				flag = true;
				return array3;
			}
			finally
			{
				if (!flag)
				{
					smethod_19(array3);
				}
				smethod_19(array);
				smethod_19(array2);
			}
		}
		throw new ArgumentOutOfRangeException("\u000f");
	}

	internal static Class66 smethod_6(byte[] byte_5, byte[] byte_6, byte[] byte_7, byte[] byte_8)
	{
		smethod_17(byte_5, 32, "keyBytes");
		smethod_17(byte_6, 12, "nonceBytes");
		if (byte_7 == null)
		{
			throw new ArgumentNullException("aad");
		}
		if (byte_8 == null)
		{
			throw new ArgumentNullException("plaintext");
		}
		byte[] byte_9 = new byte[16];
		return new Class66(smethod_8(bool_1: true, byte_5, byte_6, byte_7, byte_8, byte_9), byte_9);
	}

	internal static byte[] smethod_7(byte[] byte_5, byte[] byte_6, byte[] byte_7, byte[] byte_8, byte[] byte_9)
	{
		smethod_17(byte_5, 32, "keyBytes");
		smethod_17(byte_6, 12, "nonceBytes");
		smethod_17(byte_9, 16, "tag");
		if (byte_7 == null)
		{
			throw new ArgumentNullException("\u0006");
		}
		if (byte_8 == null)
		{
			throw new ArgumentNullException("\u000f");
		}
		byte[] array = (byte[])byte_9.Clone();
		try
		{
			return smethod_8(bool_1: false, byte_5, byte_6, byte_7, byte_8, array);
		}
		finally
		{
			smethod_19(array);
		}
	}

	private static byte[] smethod_8(bool bool_1, byte[] byte_5, byte[] byte_6, byte[] byte_7, byte[] byte_8, byte[] byte_9)
	{
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr intptr_2 = IntPtr.Zero;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		IntPtr intPtr4 = IntPtr.Zero;
		int num = 0;
		byte[] array = null;
		bool flag = false;
		try
		{
			smethod_18(BCryptOpenAlgorithmProvider(out intptr_, "AES", null, 0u), "BCryptOpenAlgorithmProvider AES");
			byte[] bytes = Encoding.Unicode.GetBytes("ChainingModeGCM\0");
			smethod_18(BCryptSetProperty(intptr_, "ChainingMode", bytes, bytes.Length, 0u), "BCryptSetProperty GCM");
			byte[] array2 = new byte[4];
			smethod_18(BCryptGetProperty(intptr_, "ObjectLength", array2, array2.Length, out var _, 0u), "BCryptGetProperty ObjectLength");
			num = BitConverter.ToInt32(array2, 0);
			intPtr = Marshal.AllocHGlobal(num);
			smethod_20(intPtr, num);
			smethod_18(BCryptGenerateSymmetricKey(intptr_, out intptr_2, intPtr, num, byte_5, byte_5.Length, 0u), "BCryptGenerateSymmetricKey");
			intPtr2 = smethod_16(byte_6);
			if (byte_7.Length != 0)
			{
				intPtr3 = smethod_16(byte_7);
			}
			intPtr4 = Marshal.AllocHGlobal(byte_9.Length);
			Marshal.Copy(byte_9, 0, intPtr4, byte_9.Length);
			Struct29 struct29_ = new Struct29
			{
				uint_0 = (uint)Marshal.SizeOf(typeof(Struct29)),
				uint_1 = 1u,
				intptr_0 = intPtr2,
				uint_2 = (uint)byte_6.Length,
				intptr_1 = intPtr3,
				uint_3 = (uint)byte_7.Length,
				intptr_2 = intPtr4,
				uint_4 = (uint)byte_9.Length
			};
			array = new byte[byte_8.Length];
			smethod_18(bool_1 ? BCryptEncrypt(intptr_2, byte_8, byte_8.Length, ref struct29_, null, 0, array, array.Length, out var int_2, 0u) : BCryptDecrypt(intptr_2, byte_8, byte_8.Length, ref struct29_, null, 0, array, array.Length, out int_2, 0u), bool_1 ? "BCryptEncrypt GCM" : "BCryptDecrypt GCM");
			if (int_2 != array.Length)
			{
				throw new CryptographicException("AES-GCM returned an unexpected length.");
			}
			if (bool_1)
			{
				Marshal.Copy(intPtr4, byte_9, 0, byte_9.Length);
			}
			flag = true;
			return array;
		}
		finally
		{
			if (!flag)
			{
				smethod_19(array);
			}
			if (intPtr4 != IntPtr.Zero)
			{
				smethod_20(intPtr4, byte_9.Length);
				Marshal.FreeHGlobal(intPtr4);
			}
			if (intPtr3 != IntPtr.Zero)
			{
				smethod_20(intPtr3, byte_7.Length);
				Marshal.FreeHGlobal(intPtr3);
			}
			if (intPtr2 != IntPtr.Zero)
			{
				smethod_20(intPtr2, byte_6.Length);
				Marshal.FreeHGlobal(intPtr2);
			}
			if (intptr_2 != IntPtr.Zero)
			{
				BCryptDestroyKey(intptr_2);
			}
			if (intPtr != IntPtr.Zero)
			{
				if (num > 0)
				{
					smethod_20(intPtr, num);
				}
				Marshal.FreeHGlobal(intPtr);
			}
			if (intptr_ != IntPtr.Zero)
			{
				BCryptCloseAlgorithmProvider(intptr_, 0u);
			}
		}
	}

	private static byte[] smethod_9(IntPtr intptr_0)
	{
		smethod_18(BCryptExportKey(intptr_0, IntPtr.Zero, "ECCPUBLICBLOB", null, 0, out var int_, 0u), "BCryptExportKey length");
		byte[] array = new byte[int_];
		smethod_18(BCryptExportKey(intptr_0, IntPtr.Zero, "ECCPUBLICBLOB", array, array.Length, out int_, 0u), "BCryptExportKey");
		if (int_ != 72 || BitConverter.ToUInt32(array, 0) != 827016005 || BitConverter.ToUInt32(array, 4) != 32)
		{
			throw new CryptographicException("CNG returned an unexpected P-256 public blob.");
		}
		byte[] array2 = new byte[65];
		array2[0] = 4;
		Buffer.BlockCopy(array, 8, array2, 1, 64);
		smethod_19(array);
		return array2;
	}

	private static IntPtr smethod_10(IntPtr intptr_0, byte[] byte_5)
	{
		Class393.smethod_0(byte_5, "sec1");
		byte[] array = smethod_12(byte_5);
		try
		{
			smethod_18(BCryptImportKeyPair(intptr_0, IntPtr.Zero, "ECCPUBLICBLOB", out var intptr_1, array, array.Length, 0u), "BCryptImportKeyPair public");
			return intptr_1;
		}
		finally
		{
			smethod_19(array);
		}
	}

	private static byte[] smethod_11(IntPtr intptr_0, IntPtr intptr_1)
	{
		IntPtr intptr_2 = IntPtr.Zero;
		byte[] array = null;
		bool flag = false;
		try
		{
			smethod_18(BCryptSecretAgreement(intptr_0, intptr_1, out intptr_2, 0u), "BCryptSecretAgreement");
			smethod_18(BCryptDeriveKey(intptr_2, "TRUNCATE", IntPtr.Zero, null, 0, out var int_, 0u), "BCryptDeriveKey length");
			if (int_ != 32)
			{
				throw new CryptographicException("CNG returned an unexpected ECDH secret length.");
			}
			array = new byte[int_];
			smethod_18(BCryptDeriveKey(intptr_2, "TRUNCATE", IntPtr.Zero, array, array.Length, out int_, 0u), "BCryptDeriveKey");
			Array.Reverse(array);
			flag = true;
			return array;
		}
		finally
		{
			if (!flag)
			{
				smethod_19(array);
			}
			if (intptr_2 != IntPtr.Zero)
			{
				BCryptDestroySecret(intptr_2);
			}
		}
	}

	private static byte[] smethod_12(byte[] byte_5)
	{
		byte[] array = new byte[72];
		smethod_14(array, 0, 827016005u);
		smethod_14(array, 4, 32u);
		Buffer.BlockCopy(byte_5, 1, array, 8, 64);
		return array;
	}

	private static byte[] smethod_13(byte[] byte_5, byte[] byte_6)
	{
		byte[] array = new byte[104];
		smethod_14(array, 0, 843793221u);
		smethod_14(array, 4, 32u);
		Buffer.BlockCopy(byte_5, 1, array, 8, 64);
		Buffer.BlockCopy(byte_6, 0, array, 72, 32);
		return array;
	}

	private static void smethod_14(byte[] byte_5, int int_0, uint uint_0)
	{
		byte_5[int_0] = (byte)uint_0;
		byte_5[int_0 + 1] = (byte)(uint_0 >> 8);
		byte_5[int_0 + 2] = (byte)(uint_0 >> 16);
		byte_5[int_0 + 3] = (byte)(uint_0 >> 24);
	}

	private static byte[] smethod_15(byte[][] byte_5)
	{
		int num = 0;
		byte[][] array = byte_5;
		int num2 = 0;
		byte[] array3;
		while (true)
		{
			if (num2 < array.Length)
			{
				byte[] array2 = array[num2];
				if (array2 != null)
				{
					num = checked(num + array2.Length);
					num2++;
					continue;
				}
				throw new ArgumentNullException("\u000e");
			}
			array3 = new byte[num];
			int num3 = 0;
			array = byte_5;
			foreach (byte[] array4 in array)
			{
				Buffer.BlockCopy(array4, 0, array3, num3, array4.Length);
				num3 += array4.Length;
			}
			break;
		}
		return array3;
	}

	private static IntPtr smethod_16(byte[] byte_5)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(byte_5.Length);
		Marshal.Copy(byte_5, 0, intPtr, byte_5.Length);
		return intPtr;
	}

	private static void smethod_17(byte[] byte_5, int int_0, string string_0)
	{
		if (byte_5 == null || byte_5.Length != int_0)
		{
			throw new ArgumentException("Unexpected byte length.", string_0);
		}
	}

	private static void smethod_18(int int_0, string string_0)
	{
		if (int_0 != 0)
		{
			throw new CryptographicException(string_0 + " failed with NTSTATUS 0x" + int_0.ToString("X8"));
		}
	}

	private static void smethod_19(byte[] byte_5)
	{
		if (byte_5 != null)
		{
			Array.Clear(byte_5, 0, byte_5.Length);
		}
	}

	private static void smethod_20(IntPtr intptr_0, int int_0)
	{
		for (int i = 0; i < int_0; i++)
		{
			Marshal.WriteByte(intptr_0, i, 0);
		}
	}

	public void Dispose()
	{
		if (!bool_0)
		{
			bool_0 = true;
			smethod_19(byte_0);
			smethod_19(byte_1);
			smethod_19(byte_2);
			smethod_19(byte_3);
			smethod_19(byte_4);
		}
	}
}
