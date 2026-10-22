using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal sealed class Class363 : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct103 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Class363 class363_0;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class363 @class = class363_0;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_00b1;
				}
				if (num == 1)
				{
					awaiter = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0101;
				}
				if (Interlocked.Exchange(ref @class.int_0, 1) == 0)
				{
					@class.blockingCollection_0.CompleteAdding();
					awaiter = @class.task_0.ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						configuredTaskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00b1;
				}
				goto end_IL_000e;
				IL_0101:
				awaiter.GetResult();
				if (@class.bool_0)
				{
					((HttpMessageInvoker)@class.httpClient_0).Dispose();
				}
				@class.blockingCollection_0.Dispose();
				@class.semaphoreSlim_0.Dispose();
				@class.cancellationTokenSource_0.Dispose();
				goto end_IL_000e;
				IL_00b1:
				awaiter.GetResult();
				@class.cancellationTokenSource_0.Cancel();
				awaiter = @class.task_1.ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					int_0 = 1;
					configuredTaskAwaiter_0 = awaiter;
					asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0101;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult();
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct104 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Class363 class363_0;

		private Dictionary<string, int> dictionary_0;

		private Dictionary<string, DateTime> dictionary_1;

		private Random random_0;

		private object object_0;

		private int int_1;

		private IEnumerator<Class1> ienumerator_0;

		private Class1 class1_0;

		private ConfiguredTaskAwaitable<Class187>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter configuredTaskAwaiter_1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_2;

		private void MoveNext()
		{
			int num = int_0;
			Class363 @class = class363_0;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_004a;
				}
				if (num == 2)
				{
					goto IL_03cb;
				}
				dictionary_0 = new Dictionary<string, int>(StringComparer.Ordinal);
				dictionary_1 = new Dictionary<string, DateTime>(StringComparer.Ordinal);
				random_0 = new Random();
				goto IL_0452;
				IL_004a:
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = configuredTaskAwaiter_1;
							configuredTaskAwaiter_1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
							num = -1;
							int_0 = -1;
							goto IL_0373;
						}
						ienumerator_0 = @class.class35_0.method_6().GetEnumerator();
					}
					try
					{
						if (num != 0)
						{
							goto IL_01e1;
						}
						ConfiguredTaskAwaitable<Class187>.ConfiguredTaskAwaiter awaiter2 = configuredTaskAwaiter_0;
						configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<Class187>.ConfiguredTaskAwaiter);
						num = -1;
						int_0 = -1;
						goto IL_02b4;
						IL_01e1:
						while (ienumerator_0.MoveNext())
						{
							class1_0 = ienumerator_0.Current;
							if (dictionary_1.TryGetValue(class1_0.String_0, out var value) && DateTime.UtcNow < value)
							{
								continue;
							}
							awaiter2 = @class.class411_0.method_0(class1_0, @class.class35_0.method_7(class1_0), @class.cancellationTokenSource_0.Token).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 0;
								int_0 = 0;
								configuredTaskAwaiter_0 = awaiter2;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_02b4;
						}
						goto end_IL_008c;
						IL_02b4:
						Class187 result = awaiter2.GetResult();
						if (result.string_0 != null)
						{
							@class.class35_0.method_8(class1_0.String_0, result.string_0);
							dictionary_0.Remove(class1_0.String_0);
							dictionary_1.Remove(class1_0.String_0);
							@class.action_0(Class185.smethod_0(-1141181374) + class1_0.String_0);
							goto IL_01e1;
						}
						dictionary_0.TryGetValue(class1_0.String_0, out var value2);
						value2 = (dictionary_0[class1_0.String_0] = value2 + 1);
						double num3 = (result.bool_0 ? 900.0 : Math.Min(300.0, 5.0 * Math.Pow(2.0, Math.Min(value2, 6))));
						TimeSpan timeSpan = ((result.timeSpan_0 > TimeSpan.FromSeconds(num3)) ? result.timeSpan_0 : TimeSpan.FromSeconds(num3 + (double)random_0.Next(0, 4)));
						dictionary_1[class1_0.String_0] = DateTime.UtcNow + timeSpan;
						if (!(result.timeSpan_0 > TimeSpan.FromSeconds(5.0)))
						{
							class1_0 = null;
							goto IL_01e1;
						}
						end_IL_008c:;
					}
					finally
					{
						if (num < 0 && ienumerator_0 != null)
						{
							ienumerator_0.Dispose();
						}
					}
					ienumerator_0 = null;
					awaiter = @class.semaphoreSlim_0.WaitAsync(TimeSpan.FromSeconds(5.0), @class.cancellationTokenSource_0.Token).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						configuredTaskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0373;
					IL_0373:
					awaiter.GetResult();
				}
				catch (OperationCanceledException)
				{
					goto end_IL_000e;
				}
				catch (Exception ex2)
				{
					object_0 = ex2;
					int_1 = 1;
				}
				int num4 = int_1;
				if (num4 == 1)
				{
					Exception ex3 = (Exception)object_0;
					@class.action_0(Class185.smethod_0(-1141181401) + ex3.Message);
					goto IL_03cb;
				}
				goto IL_044b;
				IL_03cb:
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter3;
					if (num != 2)
					{
						awaiter3 = Task.Delay(5000, @class.cancellationTokenSource_0.Token).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							configuredTaskAwaiter_2 = awaiter3;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
					}
					else
					{
						awaiter3 = configuredTaskAwaiter_2;
						configuredTaskAwaiter_2 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						int_0 = -1;
					}
					awaiter3.GetResult();
				}
				catch (OperationCanceledException)
				{
					goto end_IL_000e;
				}
				goto IL_044b;
				IL_0452:
				if (!@class.cancellationTokenSource_0.IsCancellationRequested)
				{
					int_1 = 0;
					goto IL_004a;
				}
				goto end_IL_000e;
				IL_044b:
				object_0 = null;
				goto IL_0452;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				dictionary_0 = null;
				dictionary_1 = null;
				random_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			dictionary_0 = null;
			dictionary_1 = null;
			random_0 = null;
			asyncTaskMethodBuilder_0.SetResult();
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

	private readonly Class411 class411_0;

	private readonly HttpClient httpClient_0;

	private readonly bool bool_0;

	private readonly BlockingCollection<Class365> blockingCollection_0 = new BlockingCollection<Class365>(128);

	private readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(0);

	private readonly CancellationTokenSource cancellationTokenSource_0 = new CancellationTokenSource();

	private readonly Task task_0;

	private readonly Task task_1;

	private readonly Action<string> action_0;

	private readonly Func<string> func_0;

	private int int_0;

	private Class351 class351_0;

	internal Class363(string string_0, string string_1, Action<string> action_1 = null, HttpClient httpClient_1 = null, Func<string> func_1 = null)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		action_0 = action_1 ?? new Action<string>(Class364.class364_0.method_0);
		class35_0 = new Class35(string_0);
		bool_0 = httpClient_1 == null;
		httpClient_0 = (HttpClient)(((object)httpClient_1) ?? ((object)new HttpClient
		{
			Timeout = TimeSpan.FromSeconds(15.0)
		}));
		class411_0 = new Class411(httpClient_0, string_1);
		func_0 = func_1;
		task_0 = Task.Run((Action)method_7);
		task_1 = Task.Run((Func<Task>)method_8);
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
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Class185.smethod_0(-1141297631), Class185.smethod_0(-1141181434));
	}

	internal bool method_2(string string_0, uint uint_0, int int_1, int int_2, int int_3, byte[] byte_0, long long_0, int int_4)
	{
		return method_6(new Class365
		{
			string_0 = Class185.smethod_0(-1141180433),
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
			action_0(Class185.smethod_0(-1141180455) + ex.Message);
			return null;
		}
	}

	internal bool method_4(string string_0, uint uint_0, string string_1, long long_0)
	{
		return method_6(new Class365
		{
			string_0 = Class185.smethod_0(-1141180489),
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
			string_0 = Class185.smethod_0(-1141180506),
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
					if (item.string_0 == Class185.smethod_0(-1141180433))
					{
						if (class35_0.method_0(item.string_1, item.uint_0, item.int_0, item.int_1, item.int_2, item.byte_0, item.long_0, item.int_4, item.string_3))
						{
							method_0()?.method_0(item.string_1, item.uint_0, item.int_1, item.long_0, item.byte_0);
						}
						else
						{
							action_0(Class185.smethod_0(-1141180527));
						}
					}
					else if (item.string_0 == Class185.smethod_0(-1141180489))
					{
						class35_0.method_3(item.string_1, item.uint_0, item.string_2, item.long_0);
					}
					else if (item.string_0 == Class185.smethod_0(-1141180506))
					{
						class35_0.method_4(item.string_1, item.uint_0, item.int_3, item.int_2, item.long_0);
						semaphoreSlim_0.Release();
					}
				}
				catch (IOException ex)
				{
					action_0(Class185.smethod_0(-1141180581) + ex.Message);
					if (i < 2)
					{
						Thread.Sleep(100 * (i + 1));
					}
					continue;
				}
				catch (Exception ex2)
				{
					action_0(Class185.smethod_0(-1141180610) + ex2.Message);
				}
				break;
			}
		}
	}

	private async Task method_8()
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>(StringComparer.Ordinal);
		Dictionary<string, DateTime> dictionary2 = new Dictionary<string, DateTime>(StringComparer.Ordinal);
		Random random = new Random();
		while (!cancellationTokenSource_0.IsCancellationRequested)
		{
			try
			{
				foreach (Class1 item in class35_0.method_6())
				{
					if (dictionary2.TryGetValue(item.String_0, out var value) && DateTime.UtcNow < value)
					{
						continue;
					}
					Class187 @class = await class411_0.method_0(item, class35_0.method_7(item), cancellationTokenSource_0.Token).ConfigureAwait(continueOnCapturedContext: false);
					if (@class.string_0 == null)
					{
						dictionary.TryGetValue(item.String_0, out var value2);
						value2 = (dictionary[item.String_0] = value2 + 1);
						double num2 = (@class.bool_0 ? 900.0 : Math.Min(300.0, 5.0 * Math.Pow(2.0, Math.Min(value2, 6))));
						TimeSpan timeSpan = ((@class.timeSpan_0 > TimeSpan.FromSeconds(num2)) ? @class.timeSpan_0 : TimeSpan.FromSeconds(num2 + (double)random.Next(0, 4)));
						dictionary2[item.String_0] = DateTime.UtcNow + timeSpan;
						if (@class.timeSpan_0 > TimeSpan.FromSeconds(5.0))
						{
							break;
						}
					}
					else
					{
						class35_0.method_8(item.String_0, @class.string_0);
						dictionary.Remove(item.String_0);
						dictionary2.Remove(item.String_0);
						action_0(Class185.smethod_0(-1141181374) + item.String_0);
					}
				}
				await semaphoreSlim_0.WaitAsync(TimeSpan.FromSeconds(5.0), cancellationTokenSource_0.Token).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (OperationCanceledException)
			{
				break;
			}
			catch (Exception ex2)
			{
				action_0(Class185.smethod_0(-1141181401) + ex2.Message);
				try
				{
					await Task.Delay(5000, cancellationTokenSource_0.Token).ConfigureAwait(continueOnCapturedContext: false);
				}
				catch (OperationCanceledException)
				{
					break;
				}
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
			cancellationTokenSource_0.Cancel();
			await task_1.ConfigureAwait(continueOnCapturedContext: false);
			if (bool_0)
			{
				((HttpMessageInvoker)httpClient_0).Dispose();
			}
			blockingCollection_0.Dispose();
			semaphoreSlim_0.Dispose();
			cancellationTokenSource_0.Dispose();
		}
	}

	public void Dispose()
	{
		method_12().GetAwaiter().GetResult();
	}
}
