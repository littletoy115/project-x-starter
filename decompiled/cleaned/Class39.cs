using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.Win32;

internal static class Class39
{
	internal sealed class Class40
	{
		private Class438 class438_0;

		private string string_0;

		internal Class438 method_0()
		{
			return class438_0;
		}

		internal void method_1(Class438 class438_1)
		{
			class438_0 = class438_1;
		}

		internal string method_2()
		{
			return string_0;
		}

		internal void method_3(string string_1)
		{
			string_0 = string_1;
		}
	}

	private static readonly object object_0 = new object();

	private static string string_0;

	private static Class40 class40_0;

	internal static bool smethod_0(int int_0)
	{
		return int_0 >= 528040;
	}

	internal static bool smethod_1()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(Class185.smethod_0(-1141265767));
			object obj = registryKey2?.GetValue(Class185.smethod_0(-1141265824));
			return obj is int && smethod_0((int)obj);
		}
		catch (Exception)
		{
			return false;
		}
	}

	internal static void smethod_2(string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_1))
		{
			throw new ArgumentException(Class185.smethod_0(-1141265838), Class185.smethod_0(-1141265865));
		}
		lock (object_0)
		{
			string_0 = string_1;
			class40_0 = null;
		}
	}

	internal static bool smethod_3(out string string_1)
	{
		lock (object_0)
		{
			string_1 = string_0;
			string_0 = null;
			return !string.IsNullOrWhiteSpace(string_1);
		}
	}

	internal static bool smethod_4()
	{
		lock (object_0)
		{
			return !string.IsNullOrWhiteSpace(string_0);
		}
	}

	internal static bool smethod_5(Class438 class438_0, string string_1)
	{
		if (class438_0 != null && class438_0.Boolean_0)
		{
			if (string.IsNullOrWhiteSpace(string_1))
			{
				throw new ArgumentException(Class185.smethod_0(-1141271043), Class185.smethod_0(-1141271083));
			}
			lock (object_0)
			{
				if (string.IsNullOrWhiteSpace(string_0) && class40_0 == null)
				{
					Class40 @class = new Class40();
					@class.method_1(class438_0);
					@class.method_3(string_1);
					class40_0 = @class;
					return true;
				}
				return false;
			}
		}
		throw new ArgumentException(Class185.smethod_0(-1141265876), Class185.smethod_0(-1141265920));
	}

	internal static bool smethod_6(out Class40 class40_1)
	{
		lock (object_0)
		{
			class40_1 = class40_0;
			class40_0 = null;
			return class40_1 != null;
		}
	}

	internal static bool smethod_7(string string_1, string string_2)
	{
		if (smethod_9(string_1, out var version_) && smethod_9(string_2, out var version_2))
		{
			return version_2 > version_;
		}
		return false;
	}

	internal static string smethod_8(GClass5 gclass5_0)
	{
		string text = ((gclass5_0 == null) ? Class185.smethod_0(-1141293701) : gclass5_0.String_0);
		string text2 = gclass5_0?.String_5;
		string text3 = (string.IsNullOrWhiteSpace(text2) ? string.Empty : (Class185.smethod_0(-1141271102) + text2.Trim()));
		return Class185.smethod_0(-1141271153) + text + Class185.smethod_0(-1141271198) + text3 + Class185.smethod_0(-1141271229);
	}

	private static bool smethod_9(string string_1, out Version version_0)
	{
		version_0 = null;
		if (string.IsNullOrWhiteSpace(string_1))
		{
			return false;
		}
		if (!Version.TryParse(string_1.Trim().TrimStart('v', 'V'), out var result))
		{
			return false;
		}
		version_0 = new Version(result.Major, result.Minor, Math.Max(result.Build, 0), Math.Max(result.Revision, 0));
		return true;
	}

	internal static string smethod_10(string string_1, string string_2)
	{
		return string.Join(Class185.smethod_0(-1141299597), smethod_13(Class135.smethod_5()), smethod_13(string_1), smethod_13(Class135.smethod_6()), smethod_13(Class135.smethod_7()), smethod_13(Class135.smethod_4()), smethod_13(string_2));
	}

	internal static string smethod_11(Class438 class438_0, string string_1, string string_2, int int_0, long long_0)
	{
		if (class438_0 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141271276));
		}
		return string.Join(Class185.smethod_0(-1141299597), Class185.smethod_0(-1141271295), Class185.smethod_0(-1141271317), Class185.smethod_0(-1141271328), smethod_13(Class135.smethod_6()), Class185.smethod_0(-1141271342), smethod_13(Class135.smethod_7()), Class185.smethod_0(-1141271353), smethod_13(Class135.smethod_2()), Class185.smethod_0(-1141271369), smethod_13(string_1), Class185.smethod_0(-1141271390), smethod_13(class438_0.Int64_0.ToString(CultureInfo.InvariantCulture)), Class185.smethod_0(-1141271409), smethod_13(class438_0.Int64_1.ToString(CultureInfo.InvariantCulture)), Class185.smethod_0(-1141271434), smethod_13(class438_0.Int64_2.ToString(CultureInfo.InvariantCulture)), Class185.smethod_0(-1141271463), smethod_13(class438_0.String_2), Class185.smethod_0(-1141271486), smethod_13(string_2), Class185.smethod_0(-1141271497), smethod_13(int_0.ToString(CultureInfo.InvariantCulture)), Class185.smethod_0(-1141271516), smethod_13(long_0.ToString(CultureInfo.InvariantCulture)), Class185.smethod_0(-1141270536), smethod_13(Class135.smethod_4() + Class185.smethod_0(-1141265149)));
	}

	internal static string smethod_12(Class438 class438_0)
	{
		if (class438_0 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141270540));
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = ((class438_0.IReadOnlyList_1 != null) ? class438_0.IReadOnlyList_1.Count : 0);
		stringBuilder.Append(Class185.smethod_0(-1141270559)).Append(num).Append((num == 1) ? Class185.smethod_0(-1141270605) : Class185.smethod_0(-1141270592));
		if (class438_0.IReadOnlyList_1 != null)
		{
			int num2 = Math.Min(class438_0.IReadOnlyList_1.Count, 10);
			for (int i = 0; i < num2; i++)
			{
				Class94 @class = class438_0.IReadOnlyList_1[i];
				stringBuilder.Append(Class185.smethod_0(-1141270609)).Append(@class.String_0).Append(Class185.smethod_0(-1141270620))
					.Append(@class.String_1);
			}
			if (class438_0.IReadOnlyList_1.Count > num2)
			{
				stringBuilder.Append(Class185.smethod_0(-1141270637)).Append(class438_0.IReadOnlyList_1.Count - num2).Append(Class185.smethod_0(-1141270644));
			}
		}
		string text = class438_0.String_4 ?? string.Empty;
		if (text.Length > 8192)
		{
			int num3 = 8192;
			if (char.IsHighSurrogate(text[8191]) && char.IsLowSurrogate(text[num3]))
			{
				num3--;
			}
			text = text.Substring(0, num3);
		}
		if (!string.IsNullOrWhiteSpace(text))
		{
			stringBuilder.Append(Class185.smethod_0(-1141271102)).Append(text);
		}
		stringBuilder.Append(Class185.smethod_0(-1141271229));
		return stringBuilder.ToString();
	}

	private static string smethod_13(string string_1)
	{
		if (string_1 == null)
		{
			string_1 = string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(Class185.smethod_0(-1141304355));
		int num = 0;
		string text = string_1;
		foreach (char c in text)
		{
			switch (c)
			{
			case '\\':
				num++;
				break;
			case '"':
				stringBuilder.Append('\\', num * 2 + 1);
				stringBuilder.Append('"');
				num = 0;
				break;
			default:
				stringBuilder.Append('\\', num);
				num = 0;
				stringBuilder.Append(c);
				break;
			}
		}
		stringBuilder.Append('\\', num * 2);
		stringBuilder.Append('"');
		return stringBuilder.ToString();
	}

	internal static void smethod_14(string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_1))
		{
			throw new InvalidOperationException(Class185.smethod_0(-1141270664));
		}
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string text = Path.Combine(Path.GetTempPath(), Class135.smethod_5(), Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
		Directory.CreateDirectory(text);
		string text2 = Path.Combine(text, Class185.smethod_0(-1141270703));
		using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class185.smethod_0(-1141270703)))
		{
			if (stream == null)
			{
				throw new FileNotFoundException(Class185.smethod_0(-1141270733), Class185.smethod_0(-1141270703));
			}
			using FileStream destination = File.Create(text2);
			stream.CopyTo(destination);
		}
		if (Process.Start(new ProcessStartInfo
		{
			FileName = text2,
			Arguments = smethod_10(baseDirectory, string_1),
			WorkingDirectory = baseDirectory,
			UseShellExecute = true
		}) == null)
		{
			throw new InvalidOperationException(Class185.smethod_0(-1141270763));
		}
	}

	internal static void smethod_15(Class40 class40_1)
	{
		if (class40_1 != null && class40_1.method_0() != null)
		{
			if (string.IsNullOrWhiteSpace(class40_1.method_2()))
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141270853));
			}
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string text = Path.Combine(Path.GetTempPath(), Class135.smethod_5(), Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
			Directory.CreateDirectory(text);
			string text2 = Path.Combine(text, Class185.smethod_0(-1141270703));
			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class185.smethod_0(-1141270703)))
			{
				if (stream == null)
				{
					throw new FileNotFoundException(Class185.smethod_0(-1141270733), Class185.smethod_0(-1141270703));
				}
				using FileStream destination = File.Create(text2);
				stream.CopyTo(destination);
			}
			string text3 = Class49.smethod_0(class40_1.method_2());
			try
			{
				using Process process = Process.GetCurrentProcess();
				if (Process.Start(new ProcessStartInfo
				{
					FileName = text2,
					Arguments = smethod_11(class40_1.method_0(), baseDirectory, text3, process.Id, process.StartTime.ToUniversalTime().Ticks),
					WorkingDirectory = baseDirectory,
					UseShellExecute = true
				}) == null)
				{
					throw new InvalidOperationException(Class185.smethod_0(-1141270763));
				}
				return;
			}
			catch
			{
				try
				{
					File.Delete(text3);
				}
				catch (IOException)
				{
				}
				catch (UnauthorizedAccessException)
				{
				}
				throw;
			}
		}
		throw new InvalidOperationException(Class185.smethod_0(-1141270796));
	}

	internal static void smethod_16()
	{
		string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Class185.smethod_0(-1141270890) + Class135.smethod_4() + Class185.smethod_0(-1141265149));
		if (!File.Exists(text))
		{
			return;
		}
		try
		{
			string text2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Class185.smethod_0(-1141297631), Class185.smethod_0(-1141270912));
			Directory.CreateDirectory(text2);
			string destFileName = Path.Combine(text2, Class135.smethod_4() + Class185.smethod_0(-1141293701) + DateTime.UtcNow.ToString(Class185.smethod_0(-1141270923)) + Class185.smethod_0(-1141265149));
			File.Copy(text, destFileName);
			File.Delete(text);
		}
		catch (Exception)
		{
		}
	}
}
