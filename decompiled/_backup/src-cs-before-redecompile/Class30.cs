using System.Globalization;
using System.Text;

internal static class Class30
{
	internal static string smethod_0(string string_0, int int_0, int int_1, int int_2)
	{
		StringBuilder stringBuilder = new StringBuilder("{\"cmd\":\"friend_warp\",\"name\":\"");
		stringBuilder.Append(smethod_1(string_0)).Append("\",\"ord\":").Append(int_0.ToString(CultureInfo.InvariantCulture))
			.Append(",\"main\":")
			.Append(int_1.ToString(CultureInfo.InvariantCulture))
			.Append(",\"sub\":")
			.Append(int_2.ToString(CultureInfo.InvariantCulture))
			.Append('}');
		return stringBuilder.ToString();
	}

	private static string smethod_1(string string_0)
	{
		return (string_0 ?? string.Empty).Replace("\\", "\\\\").Replace("\"", "\\\"");
	}
}
