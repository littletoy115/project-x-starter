using System;

internal sealed class Class17
{
	private readonly object object_0 = new object();

	private Action action_0;

	private bool bool_0;

	internal void method_0()
	{
		Action action = null;
		lock (object_0)
		{
			if (bool_0)
			{
				return;
			}
			bool_0 = true;
			action = action_0;
			action_0 = null;
		}
		action?.Invoke();
	}

	internal bool method_1(Action action_1)
	{
		if (action_1 == null)
		{
			throw new ArgumentNullException("\u000e");
		}
		bool flag;
		lock (object_0)
		{
			if (action_0 != null)
			{
				throw new InvalidOperationException("A heartbeat close target is already attached.");
			}
			if (!(flag = bool_0))
			{
				action_0 = action_1;
			}
		}
		if (flag)
		{
			action_1();
		}
		return !flag;
	}
}
