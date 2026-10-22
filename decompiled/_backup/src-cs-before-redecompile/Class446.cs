internal sealed class Class446
{
	internal static readonly Class446 class446_0 = new Class446();

	private bool? nullable_0;

	private int int_0;

	private int? nullable_1;

	private bool? nullable_2;

	private int? nullable_3;

	internal bool? method_0()
	{
		return nullable_0;
	}

	internal void method_1(bool? nullable_4)
	{
		nullable_0 = nullable_4;
	}

	internal int method_2()
	{
		return int_0;
	}

	internal void method_3(int int_1)
	{
		int_0 = int_1;
	}

	internal int? method_4()
	{
		return nullable_1;
	}

	internal void method_5(int? nullable_4)
	{
		nullable_1 = nullable_4;
	}

	internal bool? method_6()
	{
		return nullable_2;
	}

	internal void method_7(bool? nullable_4)
	{
		nullable_2 = nullable_4;
	}

	internal bool? method_8()
	{
		if (!method_6().HasValue)
		{
			return null;
		}
		return !method_6().Value;
	}

	internal int? method_9()
	{
		return nullable_3;
	}

	internal void method_10(int? nullable_4)
	{
		nullable_3 = nullable_4;
	}
}
