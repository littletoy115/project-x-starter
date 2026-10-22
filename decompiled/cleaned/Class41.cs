internal static class Class41
{
	internal static Struct100 smethod_0(Enum0 enum0_0)
	{
		return enum0_0 switch
		{
			Enum0.Attached => new Struct100
			{
				bool_0 = false,
				bool_1 = true,
				bool_2 = false,
				bool_3 = false
			}, 
			Enum0.Selected => new Struct100
			{
				bool_0 = false,
				bool_1 = false,
				bool_2 = true,
				bool_3 = false
			}, 
			Enum0.Started => new Struct100
			{
				bool_0 = false,
				bool_1 = false,
				bool_2 = false,
				bool_3 = true
			}, 
			_ => new Struct100
			{
				bool_0 = true,
				bool_1 = true,
				bool_2 = false,
				bool_3 = false
			}, 
		};
	}
}
