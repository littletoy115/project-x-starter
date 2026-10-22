using System;
using System.Drawing;
using System.IO;

internal static class Class167
{
	private sealed class Class168
	{
		internal readonly int int_0;

		internal readonly int[] int_1;

		internal readonly int[] int_2;

		internal readonly int[] int_3;

		internal Class168(int int_4, int[] int_5, int[] int_6, int[] int_7)
		{
			int_0 = int_4;
			int_1 = int_5;
			int_2 = int_6;
			int_3 = int_7;
		}
	}

	internal static int smethod_0(byte[] byte_0, float[] float_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("\u000e");
		}
		if (float_0 == null)
		{
			throw new ArgumentNullException("\u0003");
		}
		if (float_0.Length != 38400)
		{
			throw new ArgumentException("KLX tensor must contain exactly " + 38400 + " floats.", "\u0003");
		}
		MemoryStream memoryStream = new MemoryStream(byte_0, writable: false);
		try
		{
			Bitmap bitmap = new Bitmap(memoryStream);
			try
			{
				smethod_1(bitmap.Width, bitmap.Height);
				byte[] byte_1 = smethod_2(bitmap);
				int num = (int)Math.Ceiling(64.0 * (double)bitmap.Width / (double)bitmap.Height);
				if (num > 600)
				{
					num = 600;
				}
				smethod_9(smethod_3(byte_1, bitmap.Width, bitmap.Height, num, 64), num, float_0);
				return num;
			}
			finally
			{
				((IDisposable)bitmap).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	private static void smethod_1(int int_0, int int_1)
	{
		long num = (long)int_0 * (long)int_1;
		if (int_0 <= 0 || int_1 <= 0 || int_0 > 8192 || int_1 > 8192 || num > 16777216L)
		{
			throw new InvalidDataException("KLX image dimensions are outside the supported range: " + int_0 + "x" + int_1 + ".");
		}
	}

	private static byte[] smethod_2(Bitmap bitmap_0)
	{
		int width = bitmap_0.Width;
		int height = bitmap_0.Height;
		byte[] array = new byte[checked(width * height)];
		for (int i = 0; i < height; i++)
		{
			int num = i * width;
			for (int j = 0; j < width; j++)
			{
				Color pixel = bitmap_0.GetPixel(j, i);
				array[num + j] = (byte)(pixel.R * 19595 + pixel.G * 38470 + pixel.B * 7471 + 32768 >> 16);
			}
		}
		return array;
	}

	private static byte[] smethod_3(byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		byte[] array = byte_0;
		if (int_0 != int_2)
		{
			array = smethod_4(byte_0, int_0, int_1, int_2);
		}
		if (int_1 == int_3)
		{
			return array;
		}
		return smethod_5(array, int_2, int_1, int_3);
	}

	private static byte[] smethod_4(byte[] byte_0, int int_0, int int_1, int int_2)
	{
		Class168 @class = smethod_6(int_0, int_2);
		byte[] array = new byte[checked(int_2 * int_1)];
		for (int i = 0; i < int_1; i++)
		{
			int num = i * int_0;
			int num2 = i * int_2;
			for (int j = 0; j < int_2; j++)
			{
				int num3 = 2097152;
				int num4 = @class.int_2[j];
				int num5 = @class.int_1[j];
				int num6 = j * @class.int_0;
				for (int k = 0; k < num4; k++)
				{
					num3 += byte_0[num + num5 + k] * @class.int_3[num6 + k];
				}
				array[num2 + j] = smethod_8(num3 >> 22);
			}
		}
		return array;
	}

	private static byte[] smethod_5(byte[] byte_0, int int_0, int int_1, int int_2)
	{
		Class168 @class = smethod_6(int_1, int_2);
		byte[] array = new byte[checked(int_0 * int_2)];
		for (int i = 0; i < int_2; i++)
		{
			int num = @class.int_2[i];
			int num2 = @class.int_1[i];
			int num3 = i * @class.int_0;
			int num4 = i * int_0;
			for (int j = 0; j < int_0; j++)
			{
				int num5 = 2097152;
				for (int k = 0; k < num; k++)
				{
					num5 += byte_0[(num2 + k) * int_0 + j] * @class.int_3[num3 + k];
				}
				array[num4 + j] = smethod_8(num5 >> 22);
			}
		}
		return array;
	}

	private static Class168 smethod_6(int int_0, int int_1)
	{
		double num = (double)int_0 / (double)int_1;
		double num2 = Math.Max(num, 1.0);
		double num3 = 2.0 * num2;
		int num4;
		int[] array;
		int[] array2;
		int[] array3;
		double num5;
		checked
		{
			num4 = (int)Math.Ceiling(num3) * 2 + 1;
			array = new int[int_1];
			array2 = new int[int_1];
			array3 = new int[int_1 * num4];
			num5 = 1.0 / num2;
		}
		for (int i = 0; i < int_1; i++)
		{
			double num6 = ((double)i + 0.5) * num;
			int num7 = (int)(num6 - num3 + 0.5);
			if (num7 < 0)
			{
				num7 = 0;
			}
			int num8 = (int)(num6 + num3 + 0.5);
			if (num8 > int_0)
			{
				num8 = int_0;
			}
			int num9 = num8 - num7;
			array[i] = num7;
			array2[i] = num9;
			double[] array4 = new double[num9];
			double num10 = 0.0;
			for (int j = 0; j < num9; j++)
			{
				num10 += (array4[j] = smethod_7(((double)(j + num7) - num6 + 0.5) * num5));
			}
			if (num10 != 0.0)
			{
				int num11 = i * num4;
				for (int k = 0; k < num9; k++)
				{
					double num12 = array4[k] / num10;
					array3[num11 + k] = ((num12 < 0.0) ? ((int)(-0.5 + num12 * 4194304.0)) : ((int)(0.5 + num12 * 4194304.0)));
				}
			}
		}
		return new Class168(num4, array, array2, array3);
	}

	private static double smethod_7(double double_0)
	{
		double num = Math.Abs(double_0);
		if (num < 1.0)
		{
			return (1.5 * num - 2.5) * num * num + 1.0;
		}
		if (num < 2.0)
		{
			return (((num - 5.0) * num + 8.0) * num - 4.0) * -0.5;
		}
		return 0.0;
	}

	private static byte smethod_8(int int_0)
	{
		if (int_0 < 0)
		{
			return 0;
		}
		if (int_0 > 255)
		{
			return byte.MaxValue;
		}
		return (byte)int_0;
	}

	private static void smethod_9(byte[] byte_0, int int_0, float[] float_0)
	{
		for (int i = 0; i < 64; i++)
		{
			int num = i * int_0;
			int num2 = i * 600;
			for (int j = 0; j < int_0; j++)
			{
				float num3 = (float)(int)byte_0[num + j] / 255f;
				float_0[num2 + j] = (num3 - 0.5f) / 0.5f;
			}
			float num4 = float_0[num2 + int_0 - 1];
			for (int k = int_0; k < 600; k++)
			{
				float_0[num2 + k] = num4;
			}
		}
	}
}
