using System.Globalization;
using System.Text;

internal static class Class30
{
	internal static string smethod_0(string string_0, int int_0, int int_1, int int_2)
	{
		StringBuilder stringBuilder = new StringBuilder(Class185.smethod_0(-1141181877));
		stringBuilder.Append(smethod_1(string_0)).Append(Class185.smethod_0(-1141181905)).Append(int_0.ToString(CultureInfo.InvariantCulture))
			.Append(Class185.smethod_0(-1141181928))
			.Append(int_1.ToString(CultureInfo.InvariantCulture))
			.Append(Class185.smethod_0(-1141181943))
			.Append(int_2.ToString(CultureInfo.InvariantCulture))
			.Append('}');
		return stringBuilder.ToString();
	}

	private static string smethod_1(string string_0)
	{
		return (string_0 ?? string.Empty).Replace(Class185.smethod_0(-1141300999), Class185.smethod_0(-1141300327)).Replace(Class185.smethod_0(-1141304355), Class185.smethod_0(-1141209113));
	}
}
