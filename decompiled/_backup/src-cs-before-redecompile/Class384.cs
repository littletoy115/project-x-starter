using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal static class Class384
{
	private static readonly object object_0 = new object();

	private static IntPtr intptr_0;

	private static string string_0;

	private static Func<string, IntPtr> func_0;

	private static Action action_0;

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr LoadLibraryExW(string string_1, IntPtr intptr_1, uint uint_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_1, string string_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr GetModuleHandleW(string string_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern uint GetModuleFileNameW(IntPtr intptr_1, StringBuilder stringBuilder_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool FreeLibrary(IntPtr intptr_1);

	internal static bool smethod_0(out string string_1)
	{
		return smethod_3(Class18.smethod_2(), out string_1);
	}

	internal static void smethod_1(Func<string, IntPtr> func_1)
	{
		lock (object_0)
		{
			func_0 = func_1;
		}
	}

	internal static void smethod_2(Action action_1)
	{
		lock (object_0)
		{
			action_0 = action_1;
		}
	}

	internal static bool smethod_3(string string_1, out string string_2)
	{
		string_2 = null;
		if (!string.IsNullOrWhiteSpace(string_1) && Path.IsPathRooted(string_1))
		{
			string fullPath = Path.GetFullPath(string_1);
			lock (object_0)
			{
				if (intptr_0 != IntPtr.Zero)
				{
					if (string.Equals(string_0, fullPath, StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
					string_2 = "The native bridge is already loaded from: " + string_0;
					return false;
				}
				IntPtr intPtr = smethod_4("klx.dll");
				if (intPtr != IntPtr.Zero)
				{
					string string_3 = smethod_6(intPtr);
					if (!smethod_7(fullPath, string_3))
					{
						string_2 = smethod_8(fullPath, string_3);
						return false;
					}
				}
				if (!File.Exists(fullPath))
				{
					string_2 = "Required native bridge was not found:\r\n" + fullPath;
					return false;
				}
				IntPtr intPtr2 = LoadLibraryExW(fullPath, IntPtr.Zero, 2304u);
				if (intPtr2 == IntPtr.Zero)
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					if (lastWin32Error == 193)
					{
						string_2 = "The native bridge must be a 64-bit Windows DLL:\r\n" + fullPath;
					}
					else
					{
						string_2 = "Could not load native bridge:\r\n" + fullPath + "\r\nWin32 error " + lastWin32Error + ": " + new Win32Exception(lastWin32Error).Message;
					}
					return false;
				}
				try
				{
					string string_4 = smethod_6(intPtr2);
					if (!smethod_7(fullPath, string_4))
					{
						string_2 = smethod_8(fullPath, string_4);
						FreeLibrary(intPtr2);
						return false;
					}
					if (!smethod_5(intPtr2, fullPath, out string_2))
					{
						FreeLibrary(intPtr2);
						return false;
					}
					action_0?.Invoke();
					IntPtr intPtr3 = smethod_4("klx.dll");
					string string_5 = ((intPtr3 == IntPtr.Zero) ? null : smethod_6(intPtr3));
					if (!(intPtr3 != intPtr2) && smethod_7(fullPath, string_5))
					{
						intptr_0 = intPtr2;
						string_0 = fullPath;
						return true;
					}
					string_2 = smethod_8(fullPath, string_5);
					FreeLibrary(intPtr2);
					return false;
				}
				catch
				{
					FreeLibrary(intPtr2);
					throw;
				}
			}
		}
		string_2 = "Required native bridge path is invalid: " + (string_1 ?? "(none)");
		return false;
	}

	private static IntPtr smethod_4(string string_1)
	{
		return func_0?.Invoke(string_1) ?? GetModuleHandleW(string_1);
	}

	private static bool smethod_5(IntPtr intptr_1, string string_1, out string string_2)
	{
		string_2 = null;
		if (GetProcAddress(intptr_1, "klx_frida_version") != IntPtr.Zero)
		{
			return true;
		}
		int lastWin32Error = Marshal.GetLastWin32Error();
		string_2 = "The native bridge is not a compatible klx build:\r\n" + string_1 + "\r\nMissing export klx_frida_version" + ((lastWin32Error == 0) ? string.Empty : (" (Win32 error " + lastWin32Error + ")."));
		return false;
	}

	private static string smethod_6(IntPtr intptr_1)
	{
		StringBuilder stringBuilder = new StringBuilder(32768);
		uint moduleFileNameW = GetModuleFileNameW(intptr_1, stringBuilder, (uint)stringBuilder.Capacity);
		if (moduleFileNameW != 0 && moduleFileNameW < stringBuilder.Capacity)
		{
			try
			{
				return Path.GetFullPath(stringBuilder.ToString(0, (int)moduleFileNameW));
			}
			catch (Exception)
			{
				return null;
			}
		}
		return null;
	}

	private static bool smethod_7(string string_1, string string_2)
	{
		if (string_2 != null)
		{
			return string.Equals(Path.GetFullPath(string_1), Path.GetFullPath(string_2), StringComparison.OrdinalIgnoreCase);
		}
		return false;
	}

	private static string smethod_8(string string_1, string string_2)
	{
		return "A different klx.dll is already loaded.\r\nExpected: " + string_1 + "\r\nAlready loaded: " + (string_2 ?? "(module path unavailable)");
	}

	internal static void smethod_9()
	{
		if (!smethod_0(out var string_))
		{
			throw new InvalidOperationException(string_);
		}
	}
}
