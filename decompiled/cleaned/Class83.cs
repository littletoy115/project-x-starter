using System;
using System.Runtime.InteropServices;

internal sealed class Class83
{
	public long long_0;

	public float float_0;

	public float float_1;

	public float float_2;

	public float float_3;

	public float float_4;

	public float float_5;

	public float float_6;

	public float float_7;

	public float float_8;

	public float float_9;

	public int int_0;

	public uint uint_0;

	public byte byte_0;

	public byte byte_1;

	public byte byte_2;

	public byte byte_3;

	public byte byte_4;

	public byte byte_5;

	public ushort ushort_0;

	public ushort ushort_1;

	public ushort ushort_2;

	public ushort ushort_3;

	public ushort ushort_4;

	public ushort ushort_5;

	public ushort ushort_6;

	internal static Class83 smethod_0(IntPtr intptr_0, int int_1)
	{
		if (!(intptr_0 == IntPtr.Zero) && int_1 >= 80)
		{
			byte[] array = new byte[80];
			Marshal.Copy(intptr_0, array, 0, 80);
			return smethod_1(array);
		}
		return null;
	}

	internal static Class83 smethod_1(byte[] byte_6)
	{
		if (byte_6 != null && byte_6.Length >= 80)
		{
			return new Class83
			{
				long_0 = (long)(((ulong)BitConverter.ToUInt32(byte_6, 0) << 32) | BitConverter.ToUInt32(byte_6, 4)),
				float_0 = BitConverter.ToSingle(byte_6, 8),
				float_1 = BitConverter.ToSingle(byte_6, 12),
				float_2 = BitConverter.ToSingle(byte_6, 16),
				float_3 = BitConverter.ToSingle(byte_6, 20),
				float_4 = BitConverter.ToSingle(byte_6, 24),
				float_5 = BitConverter.ToSingle(byte_6, 28),
				float_6 = BitConverter.ToSingle(byte_6, 32),
				float_7 = BitConverter.ToSingle(byte_6, 36),
				float_8 = BitConverter.ToSingle(byte_6, 40),
				float_9 = BitConverter.ToSingle(byte_6, 44),
				int_0 = BitConverter.ToInt32(byte_6, 48),
				uint_0 = BitConverter.ToUInt32(byte_6, 52),
				byte_0 = byte_6[56],
				byte_1 = byte_6[57],
				byte_2 = byte_6[58],
				byte_3 = byte_6[59],
				byte_4 = byte_6[60],
				byte_5 = byte_6[61],
				ushort_0 = BitConverter.ToUInt16(byte_6, 64),
				ushort_1 = BitConverter.ToUInt16(byte_6, 66),
				ushort_2 = BitConverter.ToUInt16(byte_6, 68),
				ushort_3 = BitConverter.ToUInt16(byte_6, 70),
				ushort_4 = BitConverter.ToUInt16(byte_6, 72),
				ushort_5 = BitConverter.ToUInt16(byte_6, 74),
				ushort_6 = BitConverter.ToUInt16(byte_6, 76)
			};
		}
		return null;
	}
}
