using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal sealed class Class28 : IDisposable, Interface5
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate0(out IntPtr intptr_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate1(IntPtr intptr_0, out IntPtr intptr_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate2(int int_0, int int_1, out IntPtr intptr_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate3(IntPtr intptr_0, long[] long_0, UIntPtr uintptr_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate4(uint uint_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate5(IntPtr intptr_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate6(int int_0, string string_0, out IntPtr intptr_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate7(IntPtr intptr_0, out UIntPtr uintptr_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate8(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, long[] long_0, UIntPtr uintptr_1, int int_0, out IntPtr intptr_2);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate9(IntPtr intptr_0, out IntPtr intptr_1);

	[Serializable]
	private sealed class Class29
	{
		public static readonly Class29 class29_0 = new Class29();

		public static Action<string> action_0;

		internal void method_0(string string_0)
		{
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate10(IntPtr intptr_0, IntPtr intptr_1, string[] string_0, IntPtr[] intptr_2, UIntPtr uintptr_0, string[] string_1, UIntPtr uintptr_1, out IntPtr intptr_3);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate11();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate12(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, IntPtr intptr_2, out IntPtr intptr_3);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate IntPtr Delegate13(IntPtr intptr_0);

	private readonly Action<string> action_0;

	private readonly object object_0 = new object();

	private IntPtr intptr_0;

	private IntPtr intptr_1;

	private IntPtr intptr_2;

	private IntPtr intptr_3;

	private IntPtr intptr_4;

	private readonly float[] float_0 = new float[38400];

	private readonly long[] long_0 = new long[4] { 1L, 1L, 64L, 600L };

	private readonly string[] string_0 = new string[1] { Class185.smethod_0(-1141179051) };

	private readonly string[] string_1 = new string[1] { Class185.smethod_0(-1141179072) };

	private IntPtr intptr_5;

	internal Class28(string string_2, string string_3, Action<string> action_1)
	{
		action_0 = action_1 ?? new Action<string>(Class29.class29_0.method_0);
		byte[] array = File.ReadAllBytes(string_2);
		SetDllDirectoryW(string_3);
		intptr_0 = LoadLibrary(Path.Combine(string_3, Class185.smethod_0(-1141240235)));
		if (intptr_0 == IntPtr.Zero)
		{
			throw new InvalidOperationException(Class185.smethod_0(-1141179085) + string_3 + Class185.smethod_0(-1141179128) + Marshal.GetLastWin32Error() + Class185.smethod_0(-1141308401));
		}
		IntPtr procAddress = GetProcAddress(intptr_0, Class185.smethod_0(-1141179138));
		if (procAddress == IntPtr.Zero)
		{
			throw new InvalidOperationException(Class185.smethod_0(-1141179166));
		}
		IntPtr intPtr = ((Delegate4)Marshal.GetDelegateForFunctionPointer(Marshal.ReadIntPtr(((Delegate11)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate11)))(), 0), typeof(Delegate4)))(1u);
		method_2(method_1<Delegate6>(intPtr, 4, out var gparam_) ? gparam_(3, Class185.smethod_0(-1141179201), out intptr_1) : IntPtr.Zero, Class185.smethod_0(-1141179223), intPtr);
		method_2(method_1<Delegate0>(intPtr, 11, out var gparam_2) ? gparam_2(out intptr_3) : IntPtr.Zero, Class185.smethod_0(-1141179249), intPtr);
		method_2(method_1<Delegate12>(intPtr, 9, out var gparam_3) ? method_0(gparam_3, array) : IntPtr.Zero, Class185.smethod_0(-1141179295), intPtr);
		method_2(method_1<Delegate2>(intPtr, 70, out var gparam_4) ? gparam_4(1, 0, out intptr_4) : IntPtr.Zero, Class185.smethod_0(-1141179330), intPtr);
		intptr_5 = intPtr;
		action_0(Class185.smethod_0(-1141179364) + array.Length / 1048576 + Class185.smethod_0(-1141178391));
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool SetDllDirectoryW(string string_2);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr LoadLibrary(string string_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool FreeLibrary(IntPtr intptr_6);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_6, string string_2);

	private IntPtr method_0(Delegate12 delegate12_0, byte[] byte_0)
	{
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		try
		{
			return delegate12_0(intptr_1, gCHandle.AddrOfPinnedObject(), (UIntPtr)(ulong)byte_0.LongLength, intptr_3, out intptr_2);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	private bool method_1<T>(IntPtr intptr_6, int int_0, out T gparam_0)
	{
		IntPtr intPtr = Marshal.ReadIntPtr(intptr_6, (int_0 - 1) * IntPtr.Size);
		if (intPtr == IntPtr.Zero)
		{
			gparam_0 = default(T);
			return false;
		}
		gparam_0 = (T)(object)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(T));
		return true;
	}

	private void method_2(IntPtr intptr_6, string string_2, IntPtr intptr_7)
	{
		if (intptr_6 == IntPtr.Zero)
		{
			return;
		}
		string text = string_2;
		if (method_1<Delegate13>(intptr_7, 3, out var gparam_) && gparam_ != null)
		{
			IntPtr intPtr = gparam_(intptr_6);
			if (intPtr != IntPtr.Zero)
			{
				text = string_2 + Class185.smethod_0(-1141301932) + Marshal.PtrToStringAnsi(intPtr);
			}
		}
		throw new InvalidOperationException(Class185.smethod_0(-1141178394) + text);
	}

	public Class50 imethod_0(byte[] byte_0)
	{
		Class50 @class = new Class50();
		int tickCount = Environment.TickCount;
		try
		{
			lock (object_0)
			{
				method_3(byte_0);
				float[] float_ = method_4();
				method_5(float_, @class);
			}
		}
		catch (Exception ex)
		{
			@class.method_7(ex.GetType().Name + Class185.smethod_0(-1141301932) + ex.Message);
		}
		@class.method_5(Environment.TickCount - tickCount);
		return @class;
	}

	private void method_3(byte[] byte_0)
	{
		Class167.smethod_0(byte_0, float_0);
	}

	private float[] method_4()
	{
		IntPtr intPtr = intptr_5;
		if (!method_1<Delegate8>(intPtr, 50, out var gparam_))
		{
			throw new InvalidOperationException(Class185.smethod_0(-1141178421));
		}
		IntPtr zero = IntPtr.Zero;
		GCHandle gCHandle = GCHandle.Alloc(float_0, GCHandleType.Pinned);
		try
		{
			method_2(gparam_(intptr_4, gCHandle.AddrOfPinnedObject(), (UIntPtr)(ulong)(float_0.LongLength * 4L), long_0, (UIntPtr)(ulong)long_0.LongLength, 1, out zero), Class185.smethod_0(-1141178459), intPtr);
		}
		finally
		{
			gCHandle.Free();
		}
		try
		{
			IntPtr[] array = new IntPtr[1] { zero };
			if (!method_1<Delegate10>(intPtr, 10, out var gparam_2))
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141178502));
			}
			method_2(gparam_2(this.intptr_2, IntPtr.Zero, string_0, array, (UIntPtr)1uL, string_1, (UIntPtr)1uL, out var intptr_), Class185.smethod_0(-1141178536), intPtr);
			try
			{
				if (!method_1<Delegate9>(intPtr, 66, out var gparam_3))
				{
					throw new InvalidOperationException(Class185.smethod_0(-1141178559));
				}
				method_2(gparam_3(intptr_, out var intptr_2), Class185.smethod_0(-1141178593), intPtr);
				try
				{
					method_1<Delegate7>(intPtr, 62, out var gparam_4);
					method_2(gparam_4(intptr_2, out var uintptr_), Class185.smethod_0(-1141178618), intPtr);
					long[] array2 = new long[(uint)uintptr_];
					method_1<Delegate3>(intPtr, 63, out var gparam_5);
					method_2(gparam_5(intptr_2, array2, uintptr_), Class185.smethod_0(-1141178642), intPtr);
					int num = (int)array2[1];
					int num2 = (int)array2[2];
					method_1<Delegate1>(intPtr, 52, out var gparam_6);
					method_2(gparam_6(intptr_, out var source), Class185.smethod_0(-1141178679), intPtr);
					float[] array3 = new float[num * num2];
					Marshal.Copy(source, array3, 0, array3.Length);
					return array3;
				}
				finally
				{
					method_6(intPtr, 100, intptr_2);
				}
			}
			finally
			{
				method_6(intPtr, 97, intptr_);
			}
		}
		finally
		{
			method_6(intPtr, 97, zero);
		}
	}

	private void method_5(float[] float_1, Class50 class50_0)
	{
		int num = 97;
		int num2 = float_1.Length / 97;
		StringBuilder stringBuilder = new StringBuilder();
		double num3 = 1.0;
		int num4 = 0;
		for (int i = 0; i < num2; i++)
		{
			int num5 = i * num;
			float num6 = float_1[num5];
			int num7 = 0;
			double num8 = 0.0;
			float num9 = -3.4E+38f;
			for (int j = 0; j < num; j++)
			{
				if (float_1[num5 + j] > num9)
				{
					num9 = float_1[num5 + j];
				}
			}
			for (int k = 0; k < num; k++)
			{
				double num10 = Math.Exp(float_1[num5 + k] - num9);
				num8 += num10;
				if (float_1[num5 + k] > num6)
				{
					num6 = float_1[num5 + k];
					num7 = k;
				}
			}
			num3 *= Math.Exp(num6 - num9) / num8;
			if (num7 != 0 && num7 != num4)
			{
				stringBuilder.Append(Class185.smethod_0(-1141178698)[num7 - 1]);
			}
			num4 = num7;
		}
		class50_0.method_1(stringBuilder.ToString());
		class50_0.method_3(num3 * 100.0);
	}

	private void method_6(IntPtr intptr_6, int int_0, IntPtr intptr_7)
	{
		if (!(intptr_7 == IntPtr.Zero) && method_1<Delegate5>(intptr_6, int_0, out var gparam_))
		{
			gparam_?.Invoke(intptr_7);
		}
	}

	public void Dispose()
	{
		lock (object_0)
		{
			if (intptr_5 != IntPtr.Zero)
			{
				method_6(intptr_5, 96, intptr_2);
				intptr_2 = IntPtr.Zero;
				method_6(intptr_5, 95, intptr_4);
				intptr_4 = IntPtr.Zero;
				method_6(intptr_5, 101, intptr_3);
				intptr_3 = IntPtr.Zero;
				method_6(intptr_5, 93, intptr_1);
				intptr_1 = IntPtr.Zero;
			}
			if (intptr_0 != IntPtr.Zero)
			{
				FreeLibrary(intptr_0);
				intptr_0 = IntPtr.Zero;
			}
		}
	}
}
