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
				class72_0 = func_0(string_0, string_1, Class185.smethod_0(-1141304363) + string_2 + Class185.smethod_0(-1141199536) + string_3, 600000);
			}
			catch (Exception ex)
			{
				class72_0 = Class71.Class72.smethod_1(Class185.smethod_0(-1141191925) + ex.Message);
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
			return new Class82(Enum3.Unknown, Class185.smethod_0(-1141301693));
		}
		@class.stopwatch_0 = Stopwatch.StartNew();
		Func<string, string, string, int, Class71.Class72> func_1 = @class.method_0;
		return smethod_8(string_2, string_3, string_4, func_1);
	}

	private static Class71.Class72 smethod_7()
	{
		return new Class71.Class72(string.Empty, Class185.smethod_0(-1141301693), bool_2: true, bool_3: true, -1);
	}

	private static Class82 smethod_8(string string_2, string string_3, string string_4, Func<string, string, string, int, Class71.Class72> func_0)
	{
		if (!File.Exists(string_2))
		{
			return new Class82(Enum3.RunnerMissing, Class185.smethod_0(-1141191944) + string_2);
		}
		Class71.Class72 @class = func_0(string_3, string_4, Class185.smethod_0(-1141303611), 3000);
		if (smethod_13(@class) && !(@class.string_1.Trim() != Class185.smethod_0(-1141303627)))
		{
			@class = func_0(string_3, string_4, Class185.smethod_0(-1141202991), 3000);
			if (smethod_13(@class) && !(@class.string_1.Trim() != Class185.smethod_0(-1141296459)))
			{
				if (!smethod_9(func_0, string_3, string_4, Class185.smethod_0(-1141192032), out var bool_, out var class82_))
				{
					return class82_;
				}
				if (!bool_)
				{
					return new Class82(Enum3.Stale, Class185.smethod_0(-1141192062));
				}
				if (!smethod_9(func_0, string_3, string_4, Class185.smethod_0(-1141192089), out bool_, out class82_))
				{
					return class82_;
				}
				if (!bool_)
				{
					return new Class82(Enum3.Stale, Class185.smethod_0(-1141192122));
				}
				@class = func_0(string_3, string_4, Class185.smethod_0(-1141192166), 8000);
				if (!smethod_13(@class))
				{
					return smethod_14(Class185.smethod_0(-1141033496), @class);
				}
				string text = @class.string_1.Trim();
				if (!smethod_12(text))
				{
					return new Class82(Enum3.Stale, Class185.smethod_0(-1141033533));
				}
				if (!smethod_10(func_0, string_3, string_4, Class185.smethod_0(-1141192032), out var long_, out class82_))
				{
					return class82_;
				}
				if (long_ != new FileInfo(string_2).Length)
				{
					return new Class82(Enum3.Stale, Class185.smethod_0(-1141033563));
				}
				string b;
				try
				{
					b = smethod_21(string_2);
				}
				catch (Exception ex)
				{
					return new Class82(Enum3.Unknown, Class185.smethod_0(-1141033621) + ex.Message);
				}
				if (!string.Equals(text, b, StringComparison.OrdinalIgnoreCase))
				{
					return new Class82(Enum3.Stale, Class185.smethod_0(-1141033649));
				}
				if (!smethod_11(func_0, string_3, string_4, Class185.smethod_0(-1141192032), out var string_5, out class82_))
				{
					return class82_;
				}
				if (!string.Equals(string_5, b, StringComparison.OrdinalIgnoreCase))
				{
					return new Class82(Enum3.Stale, Class185.smethod_0(-1141033703));
				}
				return new Class82(Enum3.Current, Class185.smethod_0(-1141033745));
			}
			return smethod_14(Class185.smethod_0(-1141192008), @class);
		}
		return smethod_14(Class185.smethod_0(-1141191982), @class);
	}

	private static bool smethod_9(Func<string, string, string, int, Class71.Class72> func_0, string string_2, string string_3, string string_4, out bool bool_0, out Class82 class82_0)
	{
		bool_0 = false;
		class82_0 = null;
		string arg = Class185.smethod_0(-1141033794) + string_4 + Class185.smethod_0(-1141033839);
		Class71.Class72 @class = func_0(string_2, string_3, arg, 8000);
		if (smethod_13(@class) && (!(@class.string_1.Trim() != Class185.smethod_0(-1141255374)) || !(@class.string_1.Trim() != Class185.smethod_0(-1141294339))))
		{
			bool_0 = @class.string_1.Trim() == Class185.smethod_0(-1141255374);
			return true;
		}
		class82_0 = smethod_14(Class185.smethod_0(-1141033882) + string_4, @class);
		return false;
	}

	private static bool smethod_10(Func<string, string, string, int, Class71.Class72> func_0, string string_2, string string_3, string string_4, out long long_0, out Class82 class82_0)
	{
		long_0 = 0L;
		class82_0 = null;
		Class71.Class72 @class = func_0(string_2, string_3, Class185.smethod_0(-1141033912) + string_4 + Class185.smethod_0(-1141304355), 8000);
		if (!smethod_13(@class) || !long.TryParse(@class.string_1.Trim(), NumberStyles.None, CultureInfo.InvariantCulture, out long_0))
		{
			@class = func_0(string_2, string_3, Class185.smethod_0(-1141033942) + string_4 + Class185.smethod_0(-1141301920), 8000);
			if (!smethod_13(@class) || !long.TryParse(@class.string_1.Trim(), NumberStyles.None, CultureInfo.InvariantCulture, out long_0))
			{
				class82_0 = smethod_14(Class185.smethod_0(-1141033976) + string_4, @class);
				return false;
			}
		}
		return true;
	}

	private static bool smethod_11(Func<string, string, string, int, Class71.Class72> func_0, string string_2, string string_3, string string_4, out string string_5, out Class82 class82_0)
	{
		string_5 = null;
		class82_0 = null;
		Class71.Class72 @class = func_0(string_2, string_3, Class185.smethod_0(-1141032974) + string_4 + Class185.smethod_0(-1141304355), 30000);
		if (!smethod_13(@class) || @class.string_1.Length < 64 || !smethod_12(@class.string_1.Substring(0, 64)))
		{
			@class = func_0(string_2, string_3, Class185.smethod_0(-1141032995) + string_4 + Class185.smethod_0(-1141304355), 30000);
			if (!smethod_13(@class) || @class.string_1.Length < 64 || !smethod_12(@class.string_1.Substring(0, 64)))
			{
				class82_0 = smethod_14(Class185.smethod_0(-1141033039) + string_4, @class);
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
		string text = ((class72_0 == null) ? Class185.smethod_0(-1141203103) : (class72_0.bool_1 ? Class185.smethod_0(-1141203183) : (Class185.smethod_0(-1141033050) + class72_0.int_0 + Class185.smethod_0(-1141301932) + class72_0.string_0)));
		return new Class82(Enum3.Unknown, string_2 + Class185.smethod_0(-1141033066) + text);
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
			string_5 = Class185.smethod_0(-1141191944) + @class.string_2;
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
			string_5 = Class185.smethod_0(-1141033621) + ex.Message;
			return false;
		}
		action_0?.Invoke(0L, length);
		if (!smethod_18(@class.func_0, @class.string_0, @class.string_1, out string_5))
		{
			return false;
		}
		string text2 = Guid.NewGuid().ToString(Class185.smethod_0(-1141300407));
		@class.string_3 = Class185.smethod_0(-1141033076) + text2;
		string text3 = Class185.smethod_0(-1141033114) + text2;
		string text4 = Class185.smethod_0(-1141033155) + text2;
		string text5 = Class185.smethod_0(-1141033193) + text2;
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
				string_5 = Class185.smethod_0(-1141033234) + smethod_20(@class.class72_0);
				return false;
			}
			if (!smethod_10(@class.func_0, @class.string_0, @class.string_1, @class.string_3, out var long_2, out var class82_2))
			{
				string_5 = class82_2.string_0;
				return false;
			}
			if (long_2 != length)
			{
				string_5 = Class185.smethod_0(-1141033269) + long_2 + Class185.smethod_0(-1141033293) + length + Class185.smethod_0(-1141033304) + smethod_20(@class.class72_0);
				return false;
			}
			if (!smethod_11(@class.func_0, @class.string_0, @class.string_1, @class.string_3, out var string_6, out class82_2))
			{
				string_5 = class82_2.string_0;
				return false;
			}
			if (!string.Equals(string_6, text, StringComparison.OrdinalIgnoreCase))
			{
				string_5 = Class185.smethod_0(-1141033333);
				return false;
			}
			if (!smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141033371) + @class.string_3, out string_5))
			{
				return false;
			}
			if (!smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141033388) + text + Class185.smethod_0(-1141033415) + text3 + Class185.smethod_0(-1141298972), out string_5))
			{
				return false;
			}
			Class71.Class72 class2 = @class.func_0(@class.string_0, @class.string_1, Class185.smethod_0(-1141033417) + text3 + Class185.smethod_0(-1141304355), 8000);
			if (!smethod_13(class2) || class2.string_1.Trim() != text)
			{
				string_5 = Class185.smethod_0(-1141033448) + smethod_20(class2);
				return false;
			}
			if (!smethod_18(@class.func_0, @class.string_0, @class.string_1, out string_5))
			{
				return false;
			}
			if (!smethod_9(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141192032), out bool_, out class82_2))
			{
				string_5 = class82_2.string_0;
				return false;
			}
			if (!smethod_9(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141192089), out bool_2, out class82_2))
			{
				string_5 = class82_2.string_0;
				return false;
			}
			if (bool_ && !smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141034508) + text4, out string_5))
			{
				return false;
			}
			flag = bool_;
			if (bool_2 && !smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141034550) + text5, out string_5))
			{
				return false;
			}
			if (!smethod_18(@class.func_0, @class.string_0, @class.string_1, out string_5))
			{
				return false;
			}
			flag2 = true;
			if (!smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141034579) + @class.string_3 + Class185.smethod_0(-1141034597), out string_5))
			{
				return false;
			}
			if (!smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141034579) + text3 + Class185.smethod_0(-1141034620), out string_5))
			{
				return false;
			}
			Class82 class3 = smethod_5(@class.string_2, @class.string_0, @class.string_1, @class.func_0);
			if (class3.enum3_0 != Enum3.Current)
			{
				string_5 = Class185.smethod_0(-1141034662) + class3.string_0;
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
				if (!(bool_ ? smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141034579) + text4 + Class185.smethod_0(-1141034597), out var string_7) : smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141034701), out string_7)))
				{
					string_5 = string_5 + Class185.smethod_0(-1141034729) + string_7 + Class185.smethod_0(-1141034755) + text4 + Class185.smethod_0(-1141308401);
				}
				if (!(bool_2 ? smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141034579) + text5 + Class185.smethod_0(-1141034620), out string_7) : smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141034771), out string_7)))
				{
					string_5 = string_5 + Class185.smethod_0(-1141034810) + string_7 + Class185.smethod_0(-1141034755) + text5 + Class185.smethod_0(-1141308401);
				}
			}
			if (!smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141258454) + @class.string_3 + Class185.smethod_0(-1141299597) + text3, out var string_8))
			{
				string_5 = smethod_17(string_5, Class185.smethod_0(-1141034843) + @class.string_3 + Class185.smethod_0(-1141034885) + text3 + Class185.smethod_0(-1141301932) + string_8);
			}
			if (!flag2 && flag && !smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141258454) + text4, out string_8))
			{
				string_5 = smethod_17(string_5, Class185.smethod_0(-1141034889) + text4 + Class185.smethod_0(-1141301932) + string_8);
			}
			if (!flag2 && bool_2 && !smethod_19(@class.func_0, @class.string_0, @class.string_1, Class185.smethod_0(-1141258454) + text5, out string_8))
			{
				string_5 = smethod_17(string_5, Class185.smethod_0(-1141034922) + text5 + Class185.smethod_0(-1141301932) + string_8);
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
			return string_2 + Class185.smethod_0(-1141184055) + string_3;
		}
		return string_3;
	}

	private static bool smethod_18(Func<string, string, string, int, Class71.Class72> func_0, string string_2, string string_3, out string string_4)
	{
		Class71.Class72 @class = func_0(string_2, string_3, Class185.smethod_0(-1141034962), 8000);
		if (!smethod_13(@class))
		{
			string_4 = Class185.smethod_0(-1141033987) + smethod_20(@class);
			return false;
		}
		if (!string.IsNullOrWhiteSpace(@class.string_1))
		{
			string_4 = Class185.smethod_0(-1141034025);
			return false;
		}
		string_4 = null;
		return true;
	}

	private static bool smethod_19(Func<string, string, string, int, Class71.Class72> func_0, string string_2, string string_3, string string_4, out string string_5)
	{
		Class71.Class72 class72_ = func_0(string_2, string_3, Class185.smethod_0(-1141034082) + string_4 + Class185.smethod_0(-1141304355), 15000);
		string_5 = (smethod_13(class72_) ? null : (string_4 + Class185.smethod_0(-1141203195) + smethod_20(class72_)));
		return string_5 == null;
	}

	private static string smethod_20(Class71.Class72 class72_0)
	{
		if (class72_0 == null)
		{
			return Class185.smethod_0(-1141203103);
		}
		if (class72_0.bool_1)
		{
			return Class185.smethod_0(-1141034109) + class72_0.string_0;
		}
		return Class185.smethod_0(-1141033050) + class72_0.int_0 + Class185.smethod_0(-1141301932) + class72_0.string_0;
	}

	internal static string smethod_21(string string_2)
	{
		FileInfo fileInfo = new FileInfo(string_2);
		string text = string_2 + Class185.smethod_0(-1141297658) + fileInfo.Length + Class185.smethod_0(-1141297658) + fileInfo.LastWriteTimeUtc.Ticks;
		if (text == string_1)
		{
			return string_0;
		}
		using (SHA256 sHA = SHA256.Create())
		{
			using FileStream inputStream = File.OpenRead(string_2);
			string_0 = BitConverter.ToString(sHA.ComputeHash(inputStream)).Replace(Class185.smethod_0(-1141293701), string.Empty).ToLowerInvariant();
		}
		string_1 = text;
		return string_0;
	}
}
