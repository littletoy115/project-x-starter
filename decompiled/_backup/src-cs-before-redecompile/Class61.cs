internal static class Class61
{
	internal static Enum12 smethod_0(Struct67 struct67_0, Struct139 struct139_0, Enum0 enum0_0, bool bool_0)
	{
		if (!bool_0)
		{
			return (Enum12)0;
		}
		if (enum0_0 != Enum0.Selected && enum0_0 != Enum0.Started)
		{
			if (!struct139_0.bool_0)
			{
				return (Enum12)0;
			}
			return (Enum12)2;
		}
		if (!struct67_0.bool_0)
		{
			if (!struct139_0.bool_0)
			{
				return (Enum12)0;
			}
			return (Enum12)2;
		}
		if (!struct139_0.bool_0)
		{
			return (Enum12)1;
		}
		return (Enum12)0;
	}
}
