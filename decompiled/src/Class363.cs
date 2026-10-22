using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal sealed class Class363 : IDisposable
{

	[Serializable]
	private sealed class Class364
	{
		public static readonly Class364 class364_0 = new Class364();

		public static Action<string> action_0;

		internal void method_0(string string_0)
		{
		}
	}

	private sealed class Class365
	{
		internal string string_0;

		internal string string_1;

		internal uint uint_0;

		internal int int_0;

		internal int int_1;

		internal int int_2;

		internal int int_3;

		internal byte[] byte_0;

		internal string string_2;

		internal string string_3;

		internal long long_0;

		internal int int_4;
	}

	private readonly Class35 class35_0;

	private readonly BlockingCollection<Class365> blockingCollection_0 = new BlockingCollection<Class365>(128);

	private readonly Task task_0;

	private readonly Action<string> action_0;

	private readonly Func<string> func_0;

	private int int_0;

	private Class351 class351_0;

	internal Class363(string string_0, Action<string> action_1 = null, Func<string> func_1 = null)
	{
		action_0 = action_1 ?? new Action<string>(Class364.class364_0.method_0);
		class35_0 = new Class35(string_0);
		func_0 = func_1;
		task_0 = Task.Run((Action)method_7);
	}

	internal Class351 method_0()
	{
		return class351_0;
	}

	internal void method_1(Class351 class351_1)
	{
		class351_0 = class351_1;
	}

	internal static string smethod_0()
	{
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Capybara_Bot", "ChallengeCapture");
	}

	internal bool method_2(string string_0, uint uint_0, int int_1, int int_2, int int_3, byte[] byte_0, long long_0, int int_4)
	{
		return method_6(new Class365
		{
			string_0 = "capture",
			string_1 = string_0,
			uint_0 = uint_0,
			int_0 = int_1,
			int_1 = int_2,
			int_2 = int_3,
			byte_0 = byte_0,
			string_3 = method_3(),
			long_0 = long_0,
			int_4 = int_4
		});
	}

	private string method_3()
	{
		if (func_0 == null)
		{
			return null;
		}
		try
		{
			return func_0();
		}
		catch (Exception ex)
		{
			action_0("[Challenge] hero name unavailable: " + ex.Message);
			return null;
		}
	}

	internal bool method_4(string string_0, uint uint_0, string string_1, long long_0)
	{
		return method_6(new Class365
		{
			string_0 = "submission",
			string_1 = string_0,
			uint_0 = uint_0,
			string_2 = string_1,
			long_0 = long_0
		});
	}

	internal bool method_5(string string_0, uint uint_0, int int_1, int int_2, long long_0)
	{
		return method_6(new Class365
		{
			string_0 = "result",
			string_1 = string_0,
			uint_0 = uint_0,
			int_3 = int_1,
			int_2 = int_2,
			long_0 = long_0
		});
	}

	private bool method_6(Class365 class365_0)
	{
		if (Volatile.Read(ref int_0) != 0)
		{
			return false;
		}
		try
		{
			return blockingCollection_0.TryAdd(class365_0);
		}
		catch (InvalidOperationException)
		{
			return false;
		}
	}

	private void method_7()
	{
		foreach (Class365 item in blockingCollection_0.GetConsumingEnumerable())
		{
			for (int i = 0; i < 3; i++)
			{
				try
				{
					if (item.string_0 == "capture")
					{
						if (class35_0.method_0(item.string_1, item.uint_0, item.int_0, item.int_1, item.int_2, item.byte_0, item.long_0, item.int_4, item.string_3))
						{
							method_0()?.method_0(item.string_1, item.uint_0, item.int_1, item.long_0, item.byte_0);
						}
						else
						{
							action_0("[Challenge] rejected invalid or duplicate image");
						}
					}
					else if (item.string_0 == "submission")
					{
						class35_0.method_3(item.string_1, item.uint_0, item.string_2, item.long_0);
					}
					else if (item.string_0 == "result")
					{
						class35_0.method_4(item.string_1, item.uint_0, item.int_3, item.int_2, item.long_0);
					}
				}
				catch (IOException ex)
				{
					action_0("[Challenge] archive IO error: " + ex.Message);
					if (i < 2)
					{
						Thread.Sleep(100 * (i + 1));
					}
					continue;
				}
				catch (Exception ex2)
				{
					action_0("[Challenge] archive error: " + ex2.Message);
				}
				break;
			}
		}
	}

	internal Class1 method_9(string string_0, uint uint_0)
	{
		return class35_0.method_5(string_0, uint_0);
	}

	internal void method_10(string string_0, uint uint_0, string string_1, double double_0, string string_2, int int_1)
	{
		class35_0.method_1(string_0, uint_0, string_1, double_0, string_2, int_1);
	}

	internal void method_11(string string_0, uint uint_0, string string_1, double double_0)
	{
		class35_0.method_2(string_0, uint_0, string_1, double_0);
	}

	internal async Task method_12()
	{
		if (Interlocked.Exchange(ref int_0, 1) == 0)
		{
			blockingCollection_0.CompleteAdding();
			await task_0.ConfigureAwait(continueOnCapturedContext: false);
			blockingCollection_0.Dispose();
		}
	}

	public void Dispose()
	{
		method_12().GetAwaiter().GetResult();
	}
}
