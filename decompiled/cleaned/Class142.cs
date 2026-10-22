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
				if (@class.enum1_0 == Enum1.Unknown && string_0 != null && string_0.IndexOf(Class185.smethod_0(-1141326223), StringComparison.OrdinalIgnoreCase) >= 0)
				{
					return new Class3(bool_1: false, string_0 + Class185.smethod_0(-1141191742) + @class.string_0);
				}
				return new Class3(bool_1: false, string_0);
			}
			if (class414_0.action_0 != null)
			{
				class414_0.action_0();
			}
			Class9 class2 = class414_0.func_1();
			string text = ((class2 == null) ? Class185.smethod_0(-1141191787) : class2.string_0);
			if (text == null)
			{
				text = class414_0.func_2(class2.int_0);
			}
			if (text == null && !class414_0.func_3())
			{
				text = Class185.smethod_0(-1141191836);
			}
			if (text == null)
			{
				text = class414_0.func_4();
			}
			return new Class3(bool_1: true, (text == null) ? null : (Class185.smethod_0(-1141191894) + text));
		}
		return new Class3(bool_1: false, string_0);
	}
}
