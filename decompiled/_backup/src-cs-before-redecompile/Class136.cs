using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal sealed class Class136 : IDisposable, Interface5
{
	private struct Struct33
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public long long_0;

		public IntPtr intptr_0;
	}

	[Serializable]
	private sealed class Class137
	{
		public static readonly Class137 class137_0 = new Class137();

		public static Action<string> action_0;

		internal void method_0(string string_0)
		{
		}
	}

	private readonly string string_0;

	private readonly Action<string> action_0;

	private readonly object object_0 = new object();

	private IntPtr intptr_0;

	private long long_0;

	private long long_1;

	private long long_2;

	private bool bool_0;

	internal Class136(string string_1, Action<string> action_1)
	{
		string_0 = string_1;
		action_0 = action_1 ?? new Action<string>(Class137.class137_0.method_0);
	}

	public Class50 imethod_0(byte[] byte_0)
	{
		Class50 @class = new Class50();
		int tickCount = Environment.TickCount;
		try
		{
			method_0();
			using Bitmap bitmap_ = smethod_1(byte_0);
			@class.method_1(method_2(bitmap_, out var double_));
			@class.method_3(smethod_0(double_));
		}
		catch (Exception ex)
		{
			@class.method_7(ex.GetType().Name + ": " + ex.Message);
		}
		@class.method_5(Environment.TickCount - tickCount);
		return @class;
	}

	internal static double smethod_0(double double_0)
	{
		return double_0 * 100.0;
	}

	private static Bitmap smethod_1(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream(byte_0);
		try
		{
			Bitmap bitmap = new Bitmap(memoryStream);
			try
			{
				return new Bitmap(bitmap);
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

	public void Dispose()
	{
		lock (object_0)
		{
			if (long_2 != 0L)
			{
				ReleaseOcrProcessOptions(long_2);
				long_2 = 0L;
			}
			if (long_1 != 0L)
			{
				ReleaseOcrPipeline(long_1);
				long_1 = 0L;
			}
			if (long_0 != 0L)
			{
				ReleaseOcrInitOptions(long_0);
				long_0 = 0L;
			}
			if (intptr_0 != IntPtr.Zero)
			{
				FreeLibrary(intptr_0);
				intptr_0 = IntPtr.Zero;
			}
			bool_0 = false;
		}
	}

	private void method_0()
	{
		lock (object_0)
		{
			if (!bool_0)
			{
				method_1();
				bool_0 = true;
			}
		}
	}

	private void method_1()
	{
		string text = Path.Combine(string_0, "oneocr.dll");
		string text2 = Path.Combine(string_0, "oneocr.onemodel");
		string text3 = Path.Combine(string_0, "onnxruntime.dll");
		string[] array = new string[3] { text, text2, text3 };
		int num = 0;
		string text5;
		while (true)
		{
			if (num < array.Length)
			{
				string text4 = array[num];
				FileInfo fileInfo = new FileInfo(text4);
				if (fileInfo.Exists && fileInfo.Length >= 1048576L)
				{
					num++;
					continue;
				}
				throw new InvalidOperationException("OneOCR engine file is missing or truncated: " + text4);
			}
			SetDllDirectoryW(string_0);
			intptr_0 = LoadLibrary(text);
			if (intptr_0 == IntPtr.Zero)
			{
				throw new InvalidOperationException("could not load " + text + " (WinError " + Marshal.GetLastWin32Error() + ")");
			}
			long long_ = 0L;
			smethod_6(CreateOcrInitOptions(out long_) == 0, "init options creation failed");
			long_0 = long_;
			smethod_6(OcrInitOptionsSetUseModelDelayLoad(long_0, 0) == 0, "model loading config failed");
			text5 = smethod_3(text2);
			if (text5 != text2)
			{
				action_0("[Challenge] OneOCR non-ASCII install path workaround active: " + text5);
			}
			break;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text5 + "\0");
		byte[] bytes2 = Encoding.UTF8.GetBytes("kj)TGtrK>f]b[Piow.gU+nC@s\"\"\"\"\"\"4\0");
		long long_2 = 0L;
		smethod_6(CreateOcrPipeline(bytes, bytes2, long_0, out long_2) == 0, "pipeline creation failed");
		long_1 = long_2;
		long long_3 = 0L;
		smethod_6(CreateOcrProcessOptions(out long_3) == 0, "process options creation failed");
		this.long_2 = long_3;
		smethod_6(OcrProcessOptionsSetMaxRecognitionLineCount(this.long_2, 1000L) == 0, "line count config failed");
		action_0("[Challenge] OneOCR pipeline ready");
	}

	private string method_2(Bitmap bitmap_0, out double double_0)
	{
		double_0 = 0.0;
		if (bitmap_0.Width >= 50 && bitmap_0.Width <= 10000 && bitmap_0.Height >= 50 && bitmap_0.Height <= 10000)
		{
			byte[] array = smethod_2(bitmap_0);
			Struct33 struct33_ = new Struct33
			{
				int_0 = 3,
				int_1 = bitmap_0.Width,
				int_2 = bitmap_0.Height,
				int_3 = 0,
				long_0 = bitmap_0.Width * 4L,
				intptr_0 = Marshal.UnsafeAddrOfPinnedArrayElement(array, 0)
			};
			long long_ = 0L;
			GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			try
			{
				struct33_.intptr_0 = Marshal.UnsafeAddrOfPinnedArrayElement(array, 0);
				smethod_6(RunOcrPipeline(long_1, ref struct33_, long_2, out long_) == 0, "recognition failed");
			}
			finally
			{
				gCHandle.Free();
			}
			try
			{
				return method_3(long_, out double_0);
			}
			finally
			{
				ReleaseOcrResult(long_);
			}
		}
		throw new InvalidOperationException("unsupported image size " + bitmap_0.Width + "x" + bitmap_0.Height);
	}

	private static byte[] smethod_2(Bitmap bitmap_0)
	{
		byte[] array = new byte[bitmap_0.Width * bitmap_0.Height * 4];
		Rectangle rect = new Rectangle(0, 0, bitmap_0.Width, bitmap_0.Height);
		BitmapData bitmapData = bitmap_0.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
		try
		{
			int num = bitmap_0.Width * 4;
			for (int i = 0; i < bitmap_0.Height; i++)
			{
				Marshal.Copy(new IntPtr(bitmapData.Scan0.ToInt64() + i * bitmapData.Stride), array, i * num, num);
			}
			return array;
		}
		finally
		{
			bitmap_0.UnlockBits(bitmapData);
		}
	}

	private string method_3(long long_3, out double double_0)
	{
		double_0 = 0.0;
		if (GetOcrLineCount(long_3, out var long_4) != 0)
		{
			return string.Empty;
		}
		List<string> list = new List<string>();
		bool flag = false;
		double num = double.MaxValue;
		for (int i = 0; i < long_4; i++)
		{
			if (GetOcrLine(long_3, i, out var long_5) != 0)
			{
				continue;
			}
			list.Add(method_4(long_5, bool_1: true));
			if (GetOcrLineWordCount(long_5, out var long_6) != 0)
			{
				continue;
			}
			for (int j = 0; j < long_6; j++)
			{
				if (GetOcrWord(long_5, j, out var long_7) == 0 && GetOcrWordConfidence(long_7, out var float_) == 0)
				{
					flag = true;
					if ((double)float_ < num)
					{
						num = float_;
					}
				}
			}
		}
		double_0 = (flag ? num : 0.0);
		return string.Join("\n", list);
	}

	private string method_4(long long_3, bool bool_1)
	{
		IntPtr intptr_ = IntPtr.Zero;
		if ((bool_1 ? (GetOcrLineContent(long_3, out intptr_) == 0) : (GetOcrWordContent(long_3, out intptr_) == 0)) && !(intptr_ == IntPtr.Zero))
		{
			int i;
			for (i = 0; Marshal.ReadByte(intptr_, i) != 0; i++)
			{
			}
			byte[] array = new byte[i];
			Marshal.Copy(intptr_, array, 0, i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	internal static string smethod_3(string string_1)
	{
		if (smethod_4(string_1))
		{
			return string_1;
		}
		string text = smethod_5(string_1);
		if (text != null && smethod_4(text))
		{
			return text;
		}
		string text2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Capybara", "OneOCR");
		string text3 = Path.Combine(text2, "oneocr.onemodel");
		try
		{
			Directory.CreateDirectory(text2);
			if (!File.Exists(text3) || new FileInfo(text3).Length != new FileInfo(string_1).Length)
			{
				File.Copy(string_1, text3, overwrite: true);
			}
			if (smethod_4(text3))
			{
				return text3;
			}
		}
		catch (IOException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
		return string_1;
	}

	private static bool smethod_4(string string_1)
	{
		int num = 0;
		while (true)
		{
			if (num < string_1.Length)
			{
				if (string_1[num] > '\u007f')
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static string smethod_5(string string_1)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		int shortPathName = GetShortPathName(string_1, stringBuilder, stringBuilder.Capacity);
		if (shortPathName > 0 && shortPathName < stringBuilder.Capacity)
		{
			return stringBuilder.ToString(0, shortPathName);
		}
		return null;
	}

	private static void smethod_6(bool bool_1, string string_1)
	{
		if (!bool_1)
		{
			throw new InvalidOperationException("OneOCR: " + string_1);
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool SetDllDirectoryW(string string_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int GetShortPathName(string string_1, StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr LoadLibrary(string string_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool FreeLibrary(IntPtr intptr_1);

	[DllImport("oneocr.dll")]
	private static extern int CreateOcrInitOptions(out long long_3);

	[DllImport("oneocr.dll")]
	private static extern int OcrInitOptionsSetUseModelDelayLoad(long long_3, byte byte_0);

	[DllImport("oneocr.dll")]
	private static extern int CreateOcrPipeline(byte[] byte_0, byte[] byte_1, long long_3, out long long_4);

	[DllImport("oneocr.dll")]
	private static extern int CreateOcrProcessOptions(out long long_3);

	[DllImport("oneocr.dll")]
	private static extern int OcrProcessOptionsSetMaxRecognitionLineCount(long long_3, long long_4);

	[DllImport("oneocr.dll")]
	private static extern int RunOcrPipeline(long long_3, ref Struct33 struct33_0, long long_4, out long long_5);

	[DllImport("oneocr.dll")]
	private static extern int GetImageAngle(long long_3, out float float_0);

	[DllImport("oneocr.dll")]
	private static extern int GetOcrLineCount(long long_3, out long long_4);

	[DllImport("oneocr.dll")]
	private static extern int GetOcrLine(long long_3, int int_0, out long long_4);

	[DllImport("oneocr.dll")]
	private static extern int GetOcrLineContent(long long_3, out IntPtr intptr_1);

	[DllImport("oneocr.dll")]
	private static extern int GetOcrLineWordCount(long long_3, out long long_4);

	[DllImport("oneocr.dll")]
	private static extern int GetOcrWord(long long_3, int int_0, out long long_4);

	[DllImport("oneocr.dll")]
	private static extern int GetOcrWordContent(long long_3, out IntPtr intptr_1);

	[DllImport("oneocr.dll")]
	private static extern int GetOcrWordConfidence(long long_3, out float float_0);

	[DllImport("oneocr.dll")]
	private static extern void ReleaseOcrResult(long long_3);

	[DllImport("oneocr.dll")]
	private static extern void ReleaseOcrInitOptions(long long_3);

	[DllImport("oneocr.dll")]
	private static extern void ReleaseOcrPipeline(long long_3);

	[DllImport("oneocr.dll")]
	private static extern void ReleaseOcrProcessOptions(long long_3);
}
