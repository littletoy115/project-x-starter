using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal sealed class Class139 : IDisposable
{
	private sealed class Class140<T>
	{
		public TaskCompletionSource<bool> taskCompletionSource_0;

		internal void method_0()
		{
			taskCompletionSource_0.TrySetResult(result: true);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct35<T> : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<T> asyncTaskMethodBuilder_0;

		public Task<T> task_0;

		public CancellationToken cancellationToken_0;

		private CancellationTokenRegistration cancellationTokenRegistration_0;

		private TaskAwaiter<Task> taskAwaiter_0;

		private TaskAwaiter<T> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			T result;
			try
			{
				TaskAwaiter<T> awaiter;
				Class140<T> @class = default(Class140<T>);
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<T>);
						num = -1;
						int_0 = -1;
						goto IL_0194;
					}
					@class = new Class140<T>();
					if (task_0 == null)
					{
						throw new InvalidOperationException("The operation returned no task.");
					}
					@class.taskCompletionSource_0 = new TaskCompletionSource<bool>();
					cancellationTokenRegistration_0 = cancellationToken_0.Register(@class.method_0);
				}
				try
				{
					TaskAwaiter<Task> awaiter2;
					if (num != 0)
					{
						awaiter2 = Task.WhenAny(task_0, @class.taskCompletionSource_0.Task).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<Task>);
						num = -1;
						int_0 = -1;
					}
					if (awaiter2.GetResult() != task_0)
					{
						task_0.ContinueWith(Class141<T>.class141_0.method_0, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
						throw new OperationCanceledException(cancellationToken_0);
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)cancellationTokenRegistration_0/*cast due to .constrained prefix*/).Dispose();
					}
				}
				cancellationTokenRegistration_0 = default(CancellationTokenRegistration);
				awaiter = task_0.GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					int_0 = 1;
					taskAwaiter_1 = awaiter;
					asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0194;
				IL_0194:
				result = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
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

	[Serializable]
	private sealed class Class141<T>
	{
		public static readonly Class141<T> class141_0 = new Class141<T>();

		public static Action<Task<T>> action_0;

		internal void method_0(Task<T> task_0)
		{
			_ = task_0.Exception;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct36 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public Class139 class139_0;

		public CancellationToken cancellationToken_0;

		private CancellationTokenSource cancellationTokenSource_0;

		private CancellationToken cancellationToken_1;

		private string string_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private TaskAwaiter<Class438> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			Class139 @class = class139_0;
			bool result;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0049;
				}
				if (Volatile.Read(ref @class.int_1) == 0 && !@class.func_4())
				{
					if (Interlocked.CompareExchange(ref @class.int_0, 1, 0) == 0)
					{
						goto IL_0049;
					}
					result = false;
				}
				else
				{
					result = false;
				}
				goto end_IL_000e;
				IL_0049:
				try
				{
					if ((uint)num > 1u)
					{
						cancellationTokenSource_0 = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken_0, @class.cancellationTokenSource_0.Token);
					}
					try
					{
						TaskAwaiter<string> awaiter;
						if (num == 0)
						{
							awaiter = taskAwaiter_0;
							taskAwaiter_0 = default(TaskAwaiter<string>);
							num = -1;
							int_0 = -1;
							goto IL_0144;
						}
						TaskAwaiter<Class438> awaiter2;
						if (num == 1)
						{
							awaiter2 = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter<Class438>);
							num = -1;
							int_0 = -1;
							goto IL_01d6;
						}
						cancellationTokenSource_0.CancelAfter(TimeSpan.FromMinutes(2.0));
						cancellationToken_1 = cancellationTokenSource_0.Token;
						if (!@class.func_4())
						{
							awaiter = smethod_0(@class.func_0(cancellationToken_1), cancellationToken_1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								int_0 = 0;
								taskAwaiter_0 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0144;
						}
						result = false;
						goto end_IL_006a;
						IL_01d6:
						Class438 result2 = awaiter2.GetResult();
						cancellationToken_1.ThrowIfCancellationRequested();
						if (result2 != null && result2.Boolean_0 && !@class.func_4())
						{
							string text = Volatile.Read(ref @class.string_0);
							if (!string.IsNullOrEmpty(text) && string.Equals(text, result2.String_2, StringComparison.OrdinalIgnoreCase))
							{
								result = false;
							}
							else if (@class.func_2(result2))
							{
								result = !@class.func_4() && @class.func_3(result2, string_0);
							}
							else
							{
								Volatile.Write(ref @class.string_0, result2.String_2 ?? string.Empty);
								result = false;
							}
						}
						else
						{
							result = false;
						}
						goto end_IL_006a;
						IL_0144:
						string result3 = awaiter.GetResult();
						string_0 = result3;
						cancellationToken_1.ThrowIfCancellationRequested();
						if (!string.IsNullOrWhiteSpace(string_0) && !@class.func_4())
						{
							awaiter2 = smethod_0(@class.func_1(string_0, cancellationToken_1), cancellationToken_1).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 1;
								int_0 = 1;
								taskAwaiter_1 = awaiter2;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01d6;
						}
						result = false;
						end_IL_006a:;
					}
					finally
					{
						if (num < 0 && cancellationTokenSource_0 != null)
						{
							((IDisposable)cancellationTokenSource_0).Dispose();
						}
					}
				}
				catch (OperationCanceledException)
				{
					result = false;
				}
				catch (Exception ex2)
				{
					@class.action_0("[CatalogUpdate] Check failed: " + ex2.GetType().Name);
					result = false;
				}
				finally
				{
					if (num < 0)
					{
						Volatile.Write(ref @class.int_0, 0);
					}
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

	private readonly Func<CancellationToken, Task<string>> func_0;

	private readonly Func<string, CancellationToken, Task<Class438>> func_1;

	private readonly Func<Class438, bool> func_2;

	private readonly Func<Class438, string, bool> func_3;

	private readonly Func<bool> func_4;

	private readonly Action<string> action_0;

	private readonly CancellationTokenSource cancellationTokenSource_0 = new CancellationTokenSource();

	private int int_0;

	private int int_1;

	private string string_0;

	internal Class139(Func<CancellationToken, Task<string>> func_5, Func<string, CancellationToken, Task<Class438>> func_6, Func<Class438, bool> func_7, Func<Class438, string, bool> func_8, Func<bool> func_9, Action<string> action_1)
	{
		func_0 = func_5 ?? throw new ArgumentNullException("tokenProvider");
		func_1 = func_6 ?? throw new ArgumentNullException("checker");
		func_2 = func_7 ?? throw new ArgumentNullException("confirm");
		func_3 = func_8 ?? throw new ArgumentNullException("queue");
		func_4 = func_9 ?? throw new ArgumentNullException("legacyUpdatePending");
		action_0 = action_1 ?? throw new ArgumentNullException("log");
	}

	internal async Task<bool> method_0(CancellationToken cancellationToken_0)
	{
		if (Volatile.Read(ref int_1) == 0 && !func_4())
		{
			if (Interlocked.CompareExchange(ref int_0, 1, 0) != 0)
			{
				return false;
			}
			try
			{
				using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken_0, cancellationTokenSource_0.Token);
				cancellationTokenSource.CancelAfter(TimeSpan.FromMinutes(2.0));
				CancellationToken token = cancellationTokenSource.Token;
				if (func_4())
				{
					return false;
				}
				string text = await smethod_0(func_0(token), token);
				token.ThrowIfCancellationRequested();
				if (!string.IsNullOrWhiteSpace(text) && !func_4())
				{
					Class438 @class = await smethod_0(func_1(text, token), token);
					token.ThrowIfCancellationRequested();
					if (@class != null && @class.Boolean_0 && !func_4())
					{
						string text2 = Volatile.Read(ref string_0);
						if (!string.IsNullOrEmpty(text2) && string.Equals(text2, @class.String_2, StringComparison.OrdinalIgnoreCase))
						{
							return false;
						}
						if (!func_2(@class))
						{
							Volatile.Write(ref string_0, @class.String_2 ?? string.Empty);
							return false;
						}
						if (func_4())
						{
							return false;
						}
						return func_3(@class, text);
					}
					return false;
				}
				return false;
			}
			catch (OperationCanceledException)
			{
				return false;
			}
			catch (Exception ex2)
			{
				action_0("[CatalogUpdate] Check failed: " + ex2.GetType().Name);
				return false;
			}
			finally
			{
				Volatile.Write(ref int_0, 0);
			}
		}
		return false;
	}

	public void Dispose()
	{
		if (Interlocked.Exchange(ref int_1, 1) == 0)
		{
			cancellationTokenSource_0.Cancel();
			cancellationTokenSource_0.Dispose();
		}
	}

	private static async Task<T> smethod_0<T>(Task<T> task_0, CancellationToken cancellationToken_0)
	{
		Class140<T> @class = new Class140<T>();
		if (task_0 == null)
		{
			throw new InvalidOperationException("The operation returned no task.");
		}
		@class.taskCompletionSource_0 = new TaskCompletionSource<bool>();
		using (cancellationToken_0.Register(@class.method_0))
		{
			if (await Task.WhenAny(task_0, @class.taskCompletionSource_0.Task) != task_0)
			{
				task_0.ContinueWith(Class141<T>.class141_0.method_0, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
				throw new OperationCanceledException(cancellationToken_0);
			}
		}
		return await task_0;
	}
}
