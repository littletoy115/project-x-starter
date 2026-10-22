using System.Drawing;

internal static class Class392
{
	internal static readonly Color color_0 = Color.FromArgb(192, 255, 192);

	internal static readonly Color color_1 = Color.FromArgb(255, 192, 192);

	internal static Struct31 smethod_0(Enum3 enum3_0, Enum0 enum0_0)
	{
		return enum3_0 switch
		{
			Enum3.Current => new Struct31
			{
				bool_0 = true,
				color_0 = color_0,
				string_0 = Class185.smethod_0(-1141302830),
				string_1 = Class185.smethod_0(-1141036896)
			}, 
			Enum3.Stale => new Struct31
			{
				bool_0 = true,
				color_0 = color_1,
				string_0 = ((enum0_0 == Enum0.Idle) ? Class185.smethod_0(-1141302923) : Class185.smethod_0(-1141302830)),
				string_1 = ((enum0_0 == Enum0.Idle) ? Class185.smethod_0(-1141037027) : Class185.smethod_0(-1141036957))
			}, 
			Enum3.RunnerMissing => new Struct31
			{
				bool_0 = true,
				color_0 = color_1,
				string_0 = ((enum0_0 == Enum0.Idle) ? Class185.smethod_0(-1141302923) : Class185.smethod_0(-1141302830)),
				string_1 = Class185.smethod_0(-1141036089)
			}, 
			_ => new Struct31
			{
				bool_0 = false,
				string_0 = Class185.smethod_0(-1141302830),
				string_1 = string.Empty
			}, 
		};
	}
}
