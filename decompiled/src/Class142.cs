using System;

internal static class Class142
{
	internal static Class3 smethod_0(string string_0, bool bool_0, Class414 class414_0)
	{
		if (bool_0 && class414_0 != null && class414_0.func_0 != null)
		{
			Class87 @class = class414_0.func_0();
			if (!Class195.smethod_7(string_0, bool_0: true, @class.enum1_0, bool_1: false))
			{
				if (@class.enum1_0 == Enum1.Unknown && string_0 != null && string_0.IndexOf("attach failed: Connection closed", StringComparison.OrdinalIgnoreCase) >= 0)
				{
					return new Class3(bool_1: false, string_0 + "; runner health is unknown, recovery skipped: " + @class.string_0);
				}
				return new Class3(bool_1: false, string_0);
			}
			if (class414_0.action_0 != null)
			{
				class414_0.action_0();
			}
			Class9 class2 = class414_0.func_1();
			string text = ((class2 == null) ? "runner recovery did not return an endpoint" : class2.string_0);
			if (text == null)
			{
				text = class414_0.func_2(class2.int_0);
			}
			if (text == null && !class414_0.func_3())
			{
				text = "the game pid changed during runner recovery";
			}
			if (text == null)
			{
				text = class414_0.func_4();
			}
			return new Class3(bool_1: true, (text == null) ? null : ("runner recovery failed: " + text));
		}
		return new Class3(bool_1: false, string_0);
	}
}
