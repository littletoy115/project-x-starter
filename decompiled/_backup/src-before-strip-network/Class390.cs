internal sealed class Class390
{
	private bool bool_0;

	private uint uint_0;

	private float float_0;

	private float float_1;

	private float float_2;

	private int int_0;

	internal bool method_0(Class348 class348_0)
	{
		if (class348_0 == null)
		{
			return false;
		}
		if (bool_0 && uint_0 == class348_0.uint_0 && float_0 == class348_0.float_0 && float_1 == class348_0.float_1 && float_2 == class348_0.float_2 && int_0 == class348_0.int_0)
		{
			return false;
		}
		bool_0 = true;
		uint_0 = class348_0.uint_0;
		float_0 = class348_0.float_0;
		float_1 = class348_0.float_1;
		float_2 = class348_0.float_2;
		int_0 = class348_0.int_0;
		return true;
	}

	internal bool method_1()
	{
		if (!bool_0)
		{
			return false;
		}
		bool_0 = false;
		uint_0 = 0u;
		return true;
	}
}
