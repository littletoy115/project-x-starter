using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal sealed class Class92 : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct28 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public Func<string, TimeSpan, TimeSpan, CancellationToken, Task<bool>> func_0;

		public Class92 class92_0;

		public TimeSpan timeSpan_0;

		public TimeSpan timeSpan_1;

		public CancellationToken cancellationToken_0;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class92 @class = class92_0;
			bool result2;
			try
			{
				if (num != 0)
				{
					if (func_0 == null)
					{
						throw new ArgumentNullException(Class185.smethod_0(-1141265205));
					}
					if (Volatile.Read(ref @class.int_0) != 0)
					{
						throw new InvalidOperationException(Class185.smethod_0(-1141265218));
					}
					@class.stopwatch_0.Restart();
				}
				bool result;
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = func_0(@class.string_0, timeSpan_0, timeSpan_1, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							configuredTaskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = configuredTaskAwaiter_0;
						configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
				}
				catch (OperationCanceledException) when (cancellationToken_0.IsCancellationRequested)
				{
					throw;
				}
				catch (Exception)
				{
					@class.method_2(Class185.smethod_0(-1141265285));
					result2 = false;
					goto end_IL_000e;
				}
				if (!result)
				{
					@class.method_2(Class185.smethod_0(-1141265318));
					result2 = false;
				}
				else if (Interlocked.CompareExchange(ref @class.int_0, 1, 0) != 0)
				{
					result2 = false;
				}
				else
				{
					object object_ = @class.object_0;
					bool lockTaken = false;
					try
					{
						Monitor.Enter(object_, ref lockTaken);
						if (Volatile.Read(ref @class.int_0) == 1)
						{
							@class.timer_0 = new Timer(@class.method_1, null, @class.timeSpan_2, Timeout.InfiniteTimeSpan);
						}
					}
					finally
					{
						if (num < 0 && lockTaken)
						{
							Monitor.Exit(object_);
						}
					}
					result2 = Volatile.Read(ref @class.int_0) == 1;
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result2);
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

	internal static readonly TimeSpan timeSpan_0 = TimeSpan.FromSeconds(30.0);

	internal static readonly TimeSpan timeSpan_1 = TimeSpan.FromMilliseconds(300.0);

	private readonly string string_0;

	private readonly TimeSpan timeSpan_2;

	private readonly Func<string, bool> func_0;

	private readonly Action<Action> action_0;

	private readonly Action action_1;

	private readonly Action<string> action_2;

	private readonly Stopwatch stopwatch_0 = new Stopwatch();

	private readonly object object_0 = new object();

	private Timer timer_0;

	private int int_0;

	internal Class92(string string_1, TimeSpan timeSpan_3, Func<string, bool> func_1, Action<Action> action_3, Action action_4, Action<string> action_5)
	{
		if (string.IsNullOrWhiteSpace(string_1))
		{
			throw new ArgumentException(Class185.smethod_0(-1141265160), Class185.smethod_0(-1141265332));
		}
		if (timeSpan_3 <= TimeSpan.Zero)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(-1141265351));
		}
		string_0 = string_1;
		timeSpan_2 = timeSpan_3;
		func_0 = func_1 ?? throw new ArgumentNullException(Class185.smethod_0(-1141265354));
		action_0 = action_3 ?? throw new ArgumentNullException(Class185.smethod_0(-1141265373));
		action_1 = action_4 ?? throw new ArgumentNullException(Class185.smethod_0(-1141265384));
		action_2 = action_5 ?? throw new ArgumentNullException(Class185.smethod_0(-1141265387));
	}

	internal async Task<bool> method_0(Func<string, TimeSpan, TimeSpan, CancellationToken, Task<bool>> func_1, TimeSpan timeSpan_3, TimeSpan timeSpan_4, CancellationToken cancellationToken_0)
	{
		if (func_1 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(-1141265205));
		}
		if (Volatile.Read(ref int_0) != 0)
		{
			throw new InvalidOperationException(Class185.smethod_0(-1141265218));
		}
		stopwatch_0.Restart();
		bool flag;
		try
		{
			flag = await func_1(string_0, timeSpan_3, timeSpan_4, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: true);
		}
		catch (OperationCanceledException) when (cancellationToken_0.IsCancellationRequested)
		{
			throw;
		}
		catch (Exception)
		{
			method_2(Class185.smethod_0(-1141265285));
			return false;
		}
		if (!flag)
		{
			method_2(Class185.smethod_0(-1141265318));
			return false;
		}
		if (Interlocked.CompareExchange(ref int_0, 1, 0) != 0)
		{
			return false;
		}
		lock (object_0)
		{
			if (Volatile.Read(ref int_0) == 1)
			{
				timer_0 = new Timer(method_1, null, timeSpan_2, Timeout.InfiniteTimeSpan);
			}
		}
		return Volatile.Read(ref int_0) == 1;
	}

	public void Dispose()
	{
		if (Interlocked.Exchange(ref int_0, 3) != 3)
		{
			method_3();
		}
	}

	private void method_1(object object_1)
	{
		if (Volatile.Read(ref int_0) != 1)
		{
			return;
		}
		lock (object_0)
		{
			if (timer_0 != null)
			{
				try
				{
					timer_0.Change(-1, -1);
				}
				catch (ObjectDisposedException)
				{
					return;
				}
			}
		}
		bool flag;
		try
		{
			flag = func_0(string_0);
		}
		catch (Exception)
		{
			method_2(Class185.smethod_0(-1141265285));
			return;
		}
		if (!flag)
		{
			method_2(Class185.smethod_0(-1141265406));
			return;
		}
		lock (object_0)
		{
			if (timer_0 != null && Volatile.Read(ref int_0) == 1)
			{
				try
				{
					timer_0.Change(timeSpan_2, Timeout.InfiniteTimeSpan);
					return;
				}
				catch (ObjectDisposedException)
				{
					return;
				}
			}
		}
	}

	private void method_2(string string_1)
	{
		while (true)
		{
			int num = Volatile.Read(ref int_0);
			if (num == 2 || num == 3)
			{
				break;
			}
			if (Interlocked.CompareExchange(ref int_0, 2, num) != num)
			{
				continue;
			}
			method_3();
			try
			{
				action_2(Class185.smethod_0(-1141264396) + string_1 + Class185.smethod_0(-1141264437) + string_0 + Class185.smethod_0(-1141264453) + stopwatch_0.ElapsedMilliseconds);
			}
			catch (Exception)
			{
			}
			try
			{
				action_0(method_4);
				break;
			}
			catch (Exception)
			{
				try
				{
					action_2(Class185.smethod_0(-1141264472) + string_0 + Class185.smethod_0(-1141264453) + stopwatch_0.ElapsedMilliseconds);
					break;
				}
				catch (Exception)
				{
					break;
				}
			}
		}
	}

	private void method_3()
	{
		Timer timer = null;
		lock (object_0)
		{
			timer = timer_0;
			timer_0 = null;
		}
		timer?.Dispose();
	}

	private void method_4()
	{
		if (Volatile.Read(ref int_0) == 2)
		{
			action_1();
		}
	}
}
