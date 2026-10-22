using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

internal static class Class71
{
	internal sealed class Class72
	{
		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		internal readonly bool bool_0;

		internal readonly bool bool_1;

		internal readonly int int_0;

		internal Class72(string string_3, string string_4, bool bool_2, bool bool_3, int int_1)
		{
			string_1 = string_3 ?? string.Empty;
			string_2 = string_4 ?? string.Empty;
			string_0 = smethod_2(string_1, string_2);
			bool_0 = bool_2;
			bool_1 = bool_3;
			int_0 = int_1;
		}

		internal bool method_0()
		{
			if (bool_0 && !bool_1)
			{
				return int_0 == 0;
			}
			return false;
		}

		internal static Class72 smethod_0(string string_3)
		{
			return new Class72(string_3, string.Empty, bool_2: true, bool_3: false, 0);
		}

		internal static Class72 smethod_1(string string_3)
		{
			return new Class72(string.Empty, string_3, bool_2: true, bool_3: false, 1);
		}

		private static string smethod_2(string string_3, string string_4)
		{
			if (string.IsNullOrEmpty(string_3))
			{
				return string_4;
			}
			if (string.IsNullOrEmpty(string_4))
			{
				return string_3;
			}
			return string_3 + Environment.NewLine + string_4;
		}
	}

	private sealed class Class73
	{
		public StringBuilder stringBuilder_0;

		public StringBuilder stringBuilder_1;

		internal void method_0(object sender, DataReceivedEventArgs e)
		{
			if (e.Data == null)
			{
				return;
			}
			lock (stringBuilder_0)
			{
				stringBuilder_0.AppendLine(e.Data);
			}
		}

		internal void method_1(object sender, DataReceivedEventArgs e)
		{
			if (e.Data == null)
			{
				return;
			}
			lock (stringBuilder_1)
			{
				stringBuilder_1.AppendLine(e.Data);
			}
		}
	}

	private static readonly Regex regex_0 = new Regex("\\A[A-Za-z0-9._:-]+\\z", RegexOptions.CultureInvariant);

	internal static string smethod_0(string string_0, string string_1, string string_2, int int_0)
	{
		return smethod_1(string_0, string_1, string_2, int_0).string_0;
	}

	internal static Class72 smethod_1(string string_0, string string_1, string string_2, int int_0)
	{
		Class73 @class = new Class73();
		if (string_1 != null && !smethod_2(string_1))
		{
			return new Class72(string.Empty, "adb serial contains unsafe characters", bool_2: false, bool_3: false, -1);
		}
		string arguments = ((string_1 == null) ? string.Empty : ("-s " + string_1 + " ")) + string_2;
		ProcessStartInfo startInfo = new ProcessStartInfo(string_0, arguments)
		{
			RedirectStandardOutput = true,
			RedirectStandardError = true,
			UseShellExecute = false,
			CreateNoWindow = true,
			StandardOutputEncoding = Encoding.UTF8,
			StandardErrorEncoding = Encoding.UTF8
		};
		@class.stringBuilder_0 = new StringBuilder();
		@class.stringBuilder_1 = new StringBuilder();
		try
		{
			using Process process = new Process
			{
				StartInfo = startInfo
			};
			DataReceivedEventHandler value = @class.method_0;
			DataReceivedEventHandler value2 = @class.method_1;
			process.OutputDataReceived += value;
			process.ErrorDataReceived += value2;
			process.Start();
			process.BeginOutputReadLine();
			process.BeginErrorReadLine();
			if (!process.WaitForExit(int_0))
			{
				try
				{
					process.Kill();
				}
				catch
				{
				}
				try
				{
					process.WaitForExit(2000);
				}
				catch
				{
				}
				lock (@class.stringBuilder_1)
				{
					@class.stringBuilder_1.AppendLine("adb did not finish within " + int_0 + " ms");
				}
				string string_3;
				lock (@class.stringBuilder_0)
				{
					string_3 = @class.stringBuilder_0.ToString().Trim();
				}
				string string_4;
				lock (@class.stringBuilder_1)
				{
					string_4 = @class.stringBuilder_1.ToString().Trim();
				}
				return new Class72(string_3, string_4, bool_2: true, bool_3: true, -1);
			}
			process.WaitForExit();
			int exitCode = process.ExitCode;
			string string_5;
			lock (@class.stringBuilder_0)
			{
				string_5 = @class.stringBuilder_0.ToString().Trim();
			}
			string string_6;
			lock (@class.stringBuilder_1)
			{
				string_6 = @class.stringBuilder_1.ToString().Trim();
			}
			return new Class72(string_5, string_6, bool_2: true, bool_3: false, exitCode);
		}
		catch (Exception ex)
		{
			lock (@class.stringBuilder_1)
			{
				@class.stringBuilder_1.AppendLine(ex.Message);
			}
			string string_7;
			lock (@class.stringBuilder_0)
			{
				string_7 = @class.stringBuilder_0.ToString().Trim();
			}
			string string_8;
			lock (@class.stringBuilder_1)
			{
				string_8 = @class.stringBuilder_1.ToString().Trim();
			}
			return new Class72(string_7, string_8, bool_2: false, bool_3: false, -1);
		}
	}

	internal static bool smethod_2(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0) && string_0[0] != '-')
		{
			return regex_0.IsMatch(string_0);
		}
		return false;
	}
}
