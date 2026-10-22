using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

internal static class Class421
{
	private sealed class Class422
	{
		public int int_0;

		public Stopwatch stopwatch_0;

		public Func<string, string, string, int, Class71.Class72> func_0;

		internal Class71.Class72 method_0(string string_0, string string_1, string string_2, int int_1)
		{
			int num = int_0 - (int)stopwatch_0.ElapsedMilliseconds - 2100;
			if (num <= 0)
			{
				return smethod_7();
			}
			Class71.Class72 result = func_0(string_0, string_1, string_2, Math.Min(int_1, num));
			if (stopwatch_0.ElapsedMilliseconds < int_0)
			{
				return result;
			}
			return smethod_7();
		}
	}

	private sealed class Class423
	{
		public Func<string, string, string, int, Class71.Class72> func_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public string string_3;

		public Class71.Class72 class72_0;

		public ManualResetEventSlim manualResetEventSlim_0;

		internal void method_0()
		{
			try
			{
				class72_0 = func_0(string_0, string_1, "push \"" + string_2 + "\" " + string_3, 600000);
			}
			catch (Exception ex)
			{
				class72_0 = Class71.Class72.smethod_1("push threw: " + ex.Message);
			}
			finally
			{
				manualResetEventSlim_0.Set();
			}
		}
	}

	private static string string_0;

	private static string string_1;

	internal static string smethod_0()
	{
		return Class180.smethod_1();
	}

	internal static bool smethod_1()
	{
		return File.Exists(smethod_0());
	}

	internal static Enum3 smethod_2(string string_2, string string_3)
	{
		return smethod_3(string_2, string_3).enum3_0;
	}

	internal static Class82 smethod_3(string string_2, string string_3)
	{
		return smethod_4(string_2, string_3, 15000);
	}

	internal static Class82 smethod_4(string string_2, string string_3, int int_0)
	{
		return smethod_6(smethod_0(), string_2, string_3, Class71.smethod_1, int_0);
	}

	internal static Class82 smethod_5(string string_2, string string_3, string string_4, Func<string, string, string, int, Class71.Class72> func_0)
	{
		return smethod_6(string_2, string_3, string_4, func_0, 15000);
	}

	internal static Class82 smethod_6(string string_2, string string_3, string string_4, Func<string, string, string, int, Class71.Class72> func_0, int int_0)
	{
		Class422 @class = new Class422();
		@class.int_0 = int_0;
		@class.func_0 = func_0;
		if (@class.int_0 <= 0)
		{
			return new Class82(Enum3.Unknown, "runner check deadline exceeded");
		}
		@class.stopwatch_0 = Stopwatch.StartNew();
		Func<string, string, string, int, Class71.Class72> func_1 = @class.method_0;
		return smethod_8(string_2, string_3, string_4, func_1);
	}

	private static Class71.Class72 smethod_7()
	{
		return new Class71.Class72(string.Empty, "runner check deadline exceeded", bool_2: true, bool_3: true, -1);
	}

	private static Class82 smethod_8(string string_2, string string_3, string string_4, Func<string, string, string, int, Class71.Class72> func_0)
	{
		if (!File.Exists(string_2))
		{
			return new Class82(Enum3.RunnerMissing, "required runner was not found: " + string_2);
		}
		Class71.Class72 @class = func_0(string_3, string_4, "get-state", 3000);
		if (smethod_13(@class) && !(@class.string_1.Trim() != "device"))
		{
			@class = func_0(string_3, string_4, "shell \"su 0 id -u\"", 3000);
			if (smethod_13(@class) && !(@class.string_1.Trim() != "0"))
			{
				if (!smethod_9(func_0, string_3, string_4, "/data/local/tmp/.klxsvc", out var bool_, out var class82_))
				{
					return class82_;
				}
				if (!bool_)
				{
					return new Class82(Enum3.Stale, "runner executable is missing");
				}
				if (!smethod_9(func_0, string_3, string_4, "/data/local/tmp/.klxsvc.id", out bool_, out class82_))
				{
					return class82_;
				}
				if (!bool_)
				{
					return new Class82(Enum3.Stale, "runner hash marker is missing");
				}
				@class = func_0(string_3, string_4, "shell \"su 0 cat /data/local/tmp/.klxsvc.id\"", 8000);
				if (!smethod_13(@class))
				{
					return smethod_14("cannot read runner hash marker", @class);
				}
				string text = @class.string_1.Trim();
				if (!smethod_12(text))
				{
					return new Class82(Enum3.Stale, "runner hash marker is malformed");
				}
				if (!smethod_10(func_0, string_3, string_4, "/data/local/tmp/.klxsvc", out var long_, out class82_))
				{
					return class82_;
				}
				if (long_ != new FileInfo(string_2).Length)
				{
					return new Class82(Enum3.Stale, "runner executable size differs from package");
				}
				string b;
				try
				{
					b = smethod_21(string_2);
				}
				catch (Exception ex)
				{
					return new Class82(Enum3.Unknown, "cannot hash packaged runner: " + ex.Message);
				}
				if (!string.Equals(text, b, StringComparison.OrdinalIgnoreCase))
				{
					return new Class82(Enum3.Stale, "runner hash marker differs from package");
				}
				if (!smethod_11(func_0, string_3, string_4, "/data/local/tmp/.klxsvc", out var string_5, out class82_))
				{
					return class82_;
				}
				if (!string.Equals(string_5, b, StringComparison.OrdinalIgnoreCase))
				{
					return new Class82(Enum3.Stale, "runner executable hash differs from package");
				}
				return new Class82(Enum3.Current, "runner executable and marker match package");
			}
			return smethod_14("root is not ready", @class);
		}
		return smethod_14("device is not ready", @class);
	}

	private static bool smethod_9(Func<string, string, string, int, Class71.Class72> func_0, string string_2, string string_3, string string_4, out bool bool_0, out Class82 class82_0)
	{
		bool_0 = false;
		class82_0 = null;
		string arg = "shell \"su 0 sh -c 'if test -f " + string_4 + "; then echo PRESENT; else echo MISSING; fi'\"";
		Class71.Class72 @class = func_0(string_2, string_3, arg, 8000);
		if (smethod_13(@class) && (!(@class.string_1.Trim() != "PRESENT") || !(@class.string_1.Trim() != "MISSING")))
		{
			bool_0 = @class.string_1.Trim() == "PRESENT";
			return true;
		}
		class82_0 = smethod_14("cannot inspect " + string_4, @class);
		return false;
	}

	private static bool smethod_10(Func<string, string, string, int, Class71.Class72> func_0, string string_2, string string_3, string string_4, out long long_0, out Class82 class82_0)
	{
		long_0 = 0L;
		class82_0 = null;
		Class71.Class72 @class = func_0(string_2, string_3, "shell \"su 0 stat -c %s " + string_4 + "\"", 8000);
		if (!smethod_13(@class) || !long.TryParse(@class.string_1.Trim(), NumberStyles.None, CultureInfo.InvariantCulture, out long_0))
		{
			@class = func_0(string_2, string_3, "shell \"su 0 sh -c 'wc -c < " + string_4 + "'\"", 8000);
			if (!smethod_13(@class) || !long.TryParse(@class.string_1.Trim(), NumberStyles.None, CultureInfo.InvariantCulture, out long_0))
			{
				class82_0 = smethod_14("cannot measure " + string_4, @class);
				return false;
			}
		}
		return true;
	}

	private static bool smethod_11(Func<string, string, string, int, Class71.Class72> func_0, string string_2, string string_3, string string_4, out string string_5, out Class82 class82_0)
	{
		string_5 = null;
		class82_0 = null;
		Class71.Class72 @class = func_0(string_2, string_3, "shell \"su 0 sha256sum " + string_4 + "\"", 30000);
		if (!smethod_13(@class) || @class.string_1.Length < 64 || !smethod_12(@class.string_1.Substring(0, 64)))
		{
			@class = func_0(string_2, string_3, "shell \"su 0 toybox sha256sum " + string_4 + "\"", 30000);
			if (!smethod_13(@class) || @class.string_1.Length < 64 || !smethod_12(@class.string_1.Substring(0, 64)))
			{
				class82_0 = smethod_14("cannot hash " + string_4, @class);
				return false;
			}
		}
		string_5 = @class.string_1.Substring(0, 64);
		return true;
	}

	private static bool smethod_12(string string_2)
	{
		if (string_2 != null && string_2.Length == 64)
		{
			int num = 0;
			while (true)
			{
				if (num < string_2.Length)
				{
					char c = string_2[num];
					if ((c < '0' || c > '9') && (c < 'a' || c > 'f') && (c < 'A' || c > 'F'))
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
		return false;
	}

	private static bool smethod_13(Class71.Class72 class72_0)
	{
		if (class72_0 != null && class72_0.method_0())
		{
			return string.IsNullOrWhiteSpace(class72_0.string_2);
		}
		return false;
	}

	private static Class82 smethod_14(string string_2, Class71.Class72 class72_0)
	{
		string text = ((class72_0 == null) ? "no ADB result" : (class72_0.bool_1 ? "ADB timed out" : ("ADB exit " + class72_0.int_0 + ": " + class72_0.string_0)));
		return new Class82(Enum3.Unknown, string_2 + " - " + text);
	}

	internal static bool smethod_15(string string_2, string string_3, Action<long, long> action_0, out string string_4)
	{
		return smethod_16(smethod_0(), string_2, string_3, action_0, Class71.smethod_1, out string_4);
	}

	internal static bool smethod_16(string string_2, string string_3, string string_4, Action<long, long> action_0, Func<string, string, string, int, Class71.Class72> func_0, out string string_5)
	{
		Class423 @class = new Class423();
		@class.func_0 = func_0;
		@class.string_0 = string_3;
		@class.string_1 = string_4;
		@class.string_2 = string_2;
		string_5 = null;
		if (!File.Exists(@class.string_2))
		{
			string_5 = "required runner was not found: " + @class.string_2;
			return false;
		}
		long length = new FileInfo(@class.string_2).Length;
		string text;
		try
		{
			text = smethod_21(@class.string_2);
		}
		catch (Exception ex)
		{
			string_5 = "cannot hash packaged runner: " + ex.Message;
			return false;
		}
		action_0?.Invoke(0L, length);
		if (!smethod_18(@class.func_0, @class.string_0, @class.string_1, out string_5))
		{
			return false;
		}
		string text2 = Guid.NewGuid().ToString("N");
		@class.string_3 = "/data/local/tmp/.klxsvc.upload." + text2;
		string text3 = "/data/local/tmp/.klxsvc.id.upload." + text2;
		string text4 = "/data/local/tmp/.klxsvc.backup." + text2;
		string text5 = "/data/local/tmp/.klxsvc.id.backup." + text2;
		bool bool_ = false;
		bool bool_2 = false;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		try
		{
			@class.class72_0 = null;
			@class.manualResetEventSlim_0 = new ManualResetEventSlim(initialState: false);
			Thread thread = new Thread(@class.method_0);
			thread.IsBackground = true;
			thread.Start();
			while (!@class.manualResetEventSlim_0.Wait(300))
			{
				if (action_0 != null && smethod_10(@class.func_0, @class.string_0, @class.string_1, @class.string_3, out var long_, out var _))
				{
					action_0(long_, length);
				}
			}
			if (!smethod_13(@class.class72_0))
			{
				string_5 = "runner push failed: " + smethod_20(@class.class72_0);
				return false;
			}
			if (!smethod_10(@class.func_0, @class.string_0, @class.string_1, @class.string_3, out var long_2, out var class82_2))
			{
				string_5 = class82_2.string_0;
				return false;
			}
			if (long_2 != length)
			{
				string_5 = "runner push left " + long_2 + " of " + length + " bytes on the device: " + smethod_20(@class.class72_0);
				return false;
			}
			if (!smethod_11(@class.func_0, @class.string_0, @class.string_1, @class.string_3, out var string_6, out class82_2))
			{
				string_5 = class82_2.string_0;
				return false;
			}
			if (!string.Equals(string_6, text, StringComparison.OrdinalIgnoreCase))
			{
				string_5 = "staged runner hash differs from package";
				return false;
			}
			if (!smethod_19(@class.func_0, @class.string_0, @class.string_1, "chmod 755 " + @class.string_3, out string_5))
			{
				return false;
			}
			if (!smethod_19(@class.func_0, @class.string_0, @class.string_1, "sh -c 'echo " + text + " > " + text3 + "'", out string_5))
			{
				return false;
			}
			Class71.Class72 class2 = @class.func_0(@class.string_0, @class.string_1, "shell \"su 0 cat " + text3 + "\"", 8000);
			if (!smethod_13(class2) || class2.string_1.Trim() != text)
			{
				string_5 = "staged runner marker did not verify: " + smethod_20(class2);
				return false;
			}
			if (!smethod_18(@class.func_0, @class.string_0, @class.string_1, out string_5))
			{
				return false;
			}
			if (!smethod_9(@class.func_0, @class.string_0, @class.string_1, "/data/local/tmp/.klxsvc", out bool_, out class82_2))
			{
				string_5 = class82_2.string_0;
				return false;
			}
			if (!smethod_9(@class.func_0, @class.string_0, @class.string_1, "/data/local/tmp/.klxsvc.id", out bool_2, out class82_2))
			{
				string_5 = class82_2.string_0;
				return false;
			}
			if (bool_ && !smethod_19(@class.func_0, @class.string_0, @class.string_1, "ln /data/local/tmp/.klxsvc " + text4, out string_5))
			{
				return false;
			}
			flag = bool_;
			if (bool_2 && !smethod_19(@class.func_0, @class.string_0, @class.string_1, "ln /data/local/tmp/.klxsvc.id " + text5, out string_5))
			{
				return false;
			}
			if (!smethod_18(@class.func_0, @class.string_0, @class.string_1, out string_5))
			{
				return false;
			}
			flag2 = true;
			if (!smethod_19(@class.func_0, @class.string_0, @class.string_1, "mv " + @class.string_3 + " /data/local/tmp/.klxsvc", out string_5))
			{
				return false;
			}
			if (!smethod_19(@class.func_0, @class.string_0, @class.string_1, "mv " + text3 + " /data/local/tmp/.klxsvc.id", out string_5))
			{
				return false;
			}
			Class82 class3 = smethod_5(@class.string_2, @class.string_0, @class.string_1, @class.func_0);
			if (class3.enum3_0 != Enum3.Current)
			{
				string_5 = "promoted runner did not verify: " + class3.string_0;
				return false;
			}
			flag2 = false;
			action_0?.Invoke(length, length);
			flag3 = true;
		}
		finally
		{
			if (flag2)
			{
				if (!(bool_ ? smethod_19(@class.func_0, @class.string_0, @class.string_1, "mv " + text4 + " /data/local/tmp/.klxsvc", out var string_7) : smethod_19(@class.func_0, @class.string_0, @class.string_1, "rm -f /data/local/tmp/.klxsvc", out string_7)))
				{
					string_5 = string_5 + "; rollback failed: " + string_7 + " (backup " + text4 + ")";
				}
				if (!(bool_2 ? smethod_19(@class.func_0, @class.string_0, @class.string_1, "mv " + text5 + " /data/local/tmp/.klxsvc.id", out string_7) : smethod_19(@class.func_0, @class.string_0, @class.string_1, "rm -f /data/local/tmp/.klxsvc.id", out string_7)))
				{
					string_5 = string_5 + "; marker rollback failed: " + string_7 + " (backup " + text5 + ")";
				}
			}
			if (!smethod_19(@class.func_0, @class.string_0, @class.string_1, "rm -f " + @class.string_3 + " " + text3, out var string_8))
			{
				string_5 = smethod_17(string_5, "staging cleanup failed for " + @class.string_3 + " and " + text3 + ": " + string_8);
			}
			if (!flag2 && flag && !smethod_19(@class.func_0, @class.string_0, @class.string_1, "rm -f " + text4, out string_8))
			{
				string_5 = smethod_17(string_5, "backup cleanup failed for " + text4 + ": " + string_8);
			}
			if (!flag2 && bool_2 && !smethod_19(@class.func_0, @class.string_0, @class.string_1, "rm -f " + text5, out string_8))
			{
				string_5 = smethod_17(string_5, "marker backup cleanup failed for " + text5 + ": " + string_8);
			}
		}
		if (flag3)
		{
			return string_5 == null;
		}
		return false;
	}

	private static string smethod_17(string string_2, string string_3)
	{
		if (!string.IsNullOrEmpty(string_2))
		{
			return string_2 + "; " + string_3;
		}
		return string_3;
	}

	private static bool smethod_18(Func<string, string, string, int, Class71.Class72> func_0, string string_2, string string_3, out string string_4)
	{
		Class71.Class72 @class = func_0(string_2, string_3, "shell \"su 0 sh -c 'pidof .klxsvc || true'\"", 8000);
		if (!smethod_13(@class))
		{
			string_4 = "cannot verify runner activity: " + smethod_20(@class);
			return false;
		}
		if (!string.IsNullOrWhiteSpace(@class.string_1))
		{
			string_4 = "runner is active; setup is deferred until it stops";
			return false;
		}
		string_4 = null;
		return true;
	}

	private static bool smethod_19(Func<string, string, string, int, Class71.Class72> func_0, string string_2, string string_3, string string_4, out string string_5)
	{
		Class71.Class72 class72_ = func_0(string_2, string_3, "shell \"su 0 " + string_4 + "\"", 15000);
		string_5 = (smethod_13(class72_) ? null : (string_4 + " failed: " + smethod_20(class72_)));
		return string_5 == null;
	}

	private static string smethod_20(Class71.Class72 class72_0)
	{
		if (class72_0 == null)
		{
			return "no ADB result";
		}
		if (class72_0.bool_1)
		{
			return "ADB timed out: " + class72_0.string_0;
		}
		return "ADB exit " + class72_0.int_0 + ": " + class72_0.string_0;
	}

	internal static string smethod_21(string string_2)
	{
		FileInfo fileInfo = new FileInfo(string_2);
		string text = string_2 + "|" + fileInfo.Length + "|" + fileInfo.LastWriteTimeUtc.Ticks;
		if (text == string_1)
		{
			return string_0;
		}
		using (SHA256 sHA = SHA256.Create())
		{
			using FileStream inputStream = File.OpenRead(string_2);
			string_0 = BitConverter.ToString(sHA.ComputeHash(inputStream)).Replace("-", string.Empty).ToLowerInvariant();
		}
		string_1 = text;
		return string_0;
	}
}
