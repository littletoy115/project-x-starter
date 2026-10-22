using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal static class Class343
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct95 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public TimeSpan timeSpan_0;

		public TimeSpan timeSpan_1;

		public CancellationToken cancellationToken_0;

		public string string_0;

		private Stopwatch stopwatch_0;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			bool result;
			try
			{
				if (num != 0)
				{
					if (timeSpan_0 < TimeSpan.Zero)
					{
						throw new ArgumentOutOfRangeException("grace");
					}
					if (timeSpan_1 <= TimeSpan.Zero)
					{
						throw new ArgumentOutOfRangeException("poll");
					}
					stopwatch_0 = Stopwatch.StartNew();
					goto IL_006f;
				}
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = configuredTaskAwaiter_0;
				configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				int_0 = -1;
				goto IL_00e9;
				IL_006f:
				cancellationToken_0.ThrowIfCancellationRequested();
				if (!smethod_3(string_0))
				{
					TimeSpan timeSpan = timeSpan_0 - stopwatch_0.Elapsed;
					if (!(timeSpan <= TimeSpan.Zero))
					{
						awaiter = Task.Delay((timeSpan < timeSpan_1) ? timeSpan : timeSpan_1, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							configuredTaskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00e9;
					}
					result = false;
				}
				else
				{
					result = true;
				}
				goto end_IL_0007;
				IL_00e9:
				awaiter.GetResult();
				goto IL_006f;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				stopwatch_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			stopwatch_0 = null;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private static string smethod_0()
	{
		return Class135.smethod_3() + ".exe";
	}

	private static string smethod_1()
	{
		return Class135.smethod_3();
	}

	internal static bool smethod_2()
	{
		return smethod_3(smethod_1());
	}

	internal static bool smethod_3(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			throw new ArgumentException("A process name is required.", "\u000e");
		}
		Process[] processesByName = Process.GetProcessesByName(string_0);
		try
		{
			int num = 0;
			while (true)
			{
				if (num < processesByName.Length)
				{
					if (!processesByName[num].HasExited)
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			return true;
		}
		finally
		{
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Dispose();
			}
		}
	}

	internal static async Task<bool> smethod_4(string string_0, TimeSpan timeSpan_0, TimeSpan timeSpan_1, CancellationToken cancellationToken_0)
	{
		if (timeSpan_0 < TimeSpan.Zero)
		{
			throw new ArgumentOutOfRangeException("grace");
		}
		if (timeSpan_1 <= TimeSpan.Zero)
		{
			throw new ArgumentOutOfRangeException("poll");
		}
		Stopwatch stopwatch = Stopwatch.StartNew();
		while (true)
		{
			cancellationToken_0.ThrowIfCancellationRequested();
			if (smethod_3(string_0))
			{
				break;
			}
			TimeSpan timeSpan = timeSpan_0 - stopwatch.Elapsed;
			if (timeSpan <= TimeSpan.Zero)
			{
				return false;
			}
			await Task.Delay((timeSpan < timeSpan_1) ? timeSpan : timeSpan_1, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false);
		}
		return true;
	}

	internal static void smethod_5()
	{
		if (!smethod_2())
		{
			string text = smethod_6();
			if (text != null)
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = text,
					WorkingDirectory = Path.GetDirectoryName(text),
					UseShellExecute = true
				});
			}
		}
	}

	private static string smethod_6()
	{
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(smethod_0());
		if (stream == null)
		{
			return null;
		}
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Capybara_Bot");
		Directory.CreateDirectory(text);
		string text2 = Path.Combine(text, smethod_1() + ".exe");
		try
		{
			FileStream fileStream = new FileStream(text2, FileMode.Create, FileAccess.Write, FileShare.None);
			try
			{
				stream.CopyTo(fileStream);
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
		}
		catch (IOException)
		{
			if (!File.Exists(text2))
			{
				return null;
			}
		}
		return text2;
	}
}
