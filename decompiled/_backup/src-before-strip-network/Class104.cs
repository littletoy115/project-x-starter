using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

internal static class Class104
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct30 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<List<int>> asyncTaskMethodBuilder_0;

		public int int_1;

		public GForm0 gform0_0;

		public int int_2;

		private List<int> list_0;

		private int int_3;

		private TaskAwaiter<bool> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			List<int> result;
			try
			{
				if (num != 0)
				{
					list_0 = new List<int>();
					int_3 = int_1;
					goto IL_0051;
				}
				TaskAwaiter<bool> awaiter = taskAwaiter_0;
				taskAwaiter_0 = default(TaskAwaiter<bool>);
				num = -1;
				int_0 = -1;
				goto IL_0094;
				IL_0094:
				if (awaiter.GetResult())
				{
					list_0.Add(int_3);
				}
				int_3++;
				goto IL_0051;
				IL_0051:
				if (int_3 <= int_2)
				{
					awaiter = gform0_0.smethod_6(int_3).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0094;
				}
				result = list_0;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				list_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			list_0 = null;
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

	internal static async Task<List<int>> smethod_0(GForm0 gform0_0, int int_0, int int_1)
	{
		List<int> list = new List<int>();
		for (int i = int_0; i <= int_1; i++)
		{
			if (await gform0_0.smethod_6(i))
			{
				list.Add(i);
			}
		}
		return list;
	}
}
