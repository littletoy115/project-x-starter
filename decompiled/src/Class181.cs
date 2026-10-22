internal sealed class Class181
{
	internal float float_0 = 40f;

	private float float_1;

	private float float_2;

	private bool bool_0;

	private int int_0;

	internal int method_0()
	{
		return int_0;
	}

	private void method_1(int int_1)
	{
		int_0 = int_1;
	}

	internal bool method_2()
	{
		return method_0() != 0;
	}

	internal void method_3(int int_1)
	{
		method_1(int_1);
		bool_0 = false;
	}

	internal void method_4()
	{
		method_1(0);
		bool_0 = false;
	}

	internal bool method_5(float float_3, float float_4)
	{
		if (!method_2())
		{
			return false;
		}
		if (bool_0)
		{
			float num = float_3 - float_1;
			float num2 = float_4 - float_2;
			if (num * num + num2 * num2 < float_0 * float_0)
			{
				return false;
			}
		}
		float_1 = float_3;
		float_2 = float_4;
		bool_0 = true;
		return true;
	}
}
