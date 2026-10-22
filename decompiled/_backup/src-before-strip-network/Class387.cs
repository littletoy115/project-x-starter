using System.Globalization;
using System.Text;

internal static class Class387
{
	internal static string smethod_0(int int_0, int int_1, int int_2)
	{
		StringBuilder stringBuilder = new StringBuilder("{\"cmd\":\"recall\",\"ord\":");
		stringBuilder.Append(int_0.ToString(CultureInfo.InvariantCulture)).Append(",\"main\":").Append(int_1.ToString(CultureInfo.InvariantCulture))
			.Append(",\"sub\":")
			.Append(int_2.ToString(CultureInfo.InvariantCulture))
			.Append('}');
		return stringBuilder.ToString();
	}
}
