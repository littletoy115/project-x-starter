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
				string_0 = "Run",
				string_1 = "The device holds this build. Run starts straight away."
			}, 
			Enum3.Stale => new Struct31
			{
				bool_0 = true,
				color_0 = color_1,
				string_0 = ((enum0_0 == Enum0.Idle) ? "Setup" : "Run"),
				string_1 = ((enum0_0 == Enum0.Idle) ? "The device needs this build pushed first. Press to send it, then Run continues." : "A runner is in use. This build still needs setup when the runner stops.")
			}, 
			Enum3.RunnerMissing => new Struct31
			{
				bool_0 = true,
				color_0 = color_1,
				string_0 = ((enum0_0 == Enum0.Idle) ? "Setup" : "Run"),
				string_1 = "Required runner was not found: config\\klxsvc. Copy klxsvc into the config folder and try again."
			}, 
			_ => new Struct31
			{
				bool_0 = false,
				string_0 = "Run",
				string_1 = string.Empty
			}, 
		};
	}
}
