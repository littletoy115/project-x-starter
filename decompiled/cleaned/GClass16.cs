using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public static class GClass16
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct120 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GClass12 gclass12_0;

		public int int_1;

		public string string_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run((Action)new Class405
					{
						gclass12_0 = gclass12_0,
						int_0 = int_1,
						string_0 = string_0
					}.method_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
				}
				awaiter.GetResult();
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

	private sealed class Class405
	{
		public GClass12 gclass12_0;

		public int int_0;

		public string string_0;

		public Action action_0;

		internal void method_0()
		{
			gclass12_0.BeginInvoke(new Action(method_1));
		}

		internal void method_1()
		{
			gclass12_0.method_1(int_0, string_0 ?? string.Format(Class185.smethod_0(-1141265729), int_0));
		}
	}

	public static async Task smethod_0(GClass12 gclass12_0, int int_0, string string_0)
	{
		await Task.Run((Action)new Class405
		{
			gclass12_0 = gclass12_0,
			int_0 = int_0,
			string_0 = string_0
		}.method_0);
	}
}
