using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "18.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Class10
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Class10()
	{
	}

	internal static ResourceManager smethod_0()
	{
		if (resourceManager_0 == null)
		{
			resourceManager_0 = new ResourceManager("Capybara_UI_Winform.Properties.Resources", typeof(Class10).Assembly);
		}
		return resourceManager_0;
	}

	internal static CultureInfo smethod_1()
	{
		return cultureInfo_0;
	}

	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		cultureInfo_0 = cultureInfo_1;
	}
}
