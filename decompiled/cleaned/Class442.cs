using System;
using System.IO;
using System.Text.RegularExpressions;

internal static class Class442
{
	private static readonly Regex regex_0 = new Regex(Class185.smethod_0(-1141202005), RegexOptions.CultureInvariant);

	private static readonly Regex regex_1 = new Regex(Class185.smethod_0(-1141202063), RegexOptions.CultureInvariant);

	internal static Class32 smethod_0(string string_0, string string_1)
	{
		Class57.smethod_0(out var byte_, out var string_2);
		return smethod_1(byte_, string_2, Class185.smethod_0(-1141202086), string_0, string_1, Class71.smethod_1);
	}

	internal static Class32 smethod_1(byte[] byte_0, string string_0, string string_1, string string_2, string string_3, Func<string, string, string, int, Class71.Class72> func_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			string text = Class57.smethod_1(byte_0);
			if (regex_1.IsMatch(string_0 ?? string.Empty) && string.Equals(text, string_0, StringComparison.Ordinal))
			{
				if (!regex_0.IsMatch(string_1 ?? string.Empty))
				{
					throw new InvalidOperationException(Class185.smethod_0(-1141202219));
				}
				if (!Class71.smethod_2(string_3))
				{
					throw new InvalidOperationException(Class185.smethod_0(-1141202269));
				}
				if (string.IsNullOrWhiteSpace(string_2))
				{
					throw new InvalidOperationException(Class185.smethod_0(-1141202311));
				}
				if (func_0 == null)
				{
					throw new ArgumentNullException(Class185.smethod_0(-1141202347));
				}
				smethod_6(func_0, string_2, string_3);
				int num = smethod_7(func_0, string_2, string_3, string_1);
				smethod_8(func_0, string_2, string_3, string_1, out var int_, out var string_4);
				if (int_ != num)
				{
					throw new InvalidOperationException(Class185.smethod_0(-1141202366));
				}
				smethod_9(func_0, string_2, string_3);
				string text2 = Class185.smethod_0(-1141199362) + string_1;
				string string_5 = Class185.smethod_0(-1141199390) + string_1;
				string string_6 = text2 + Class185.smethod_0(-1141199408) + text + Class185.smethod_0(-1141345452);
				string text3 = smethod_2(func_0, string_2, string_3, int_, text2, string_5, text, byte_0.Length);
				if (text3 == Class185.smethod_0(-1141253960))
				{
					return new Class32(string_1, int_, string_4, string_6, text, bool_1: true);
				}
				smethod_4(text3, Class185.smethod_0(-1141199436));
				string text4 = Guid.NewGuid().ToString(Class185.smethod_0(-1141300407));
				string text5 = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141199461) + text4 + Class185.smethod_0(-1141199485));
				string text6 = Class185.smethod_0(-1141199495) + text4 + Class185.smethod_0(-1141199485);
				bool flag = false;
				Exception ex = null;
				try
				{
					File.WriteAllBytes(text5, byte_0);
					smethod_11(func_0, string_2, string_3, Class185.smethod_0(-1141304363) + text5 + Class185.smethod_0(-1141199536) + text6, 120000, Class185.smethod_0(-1141199537), text5);
					flag = true;
					string text7 = smethod_3(func_0, string_2, string_3, int_, text2, string_5, text, byte_0.Length, text6, text4);
					if (text7 != Class185.smethod_0(-1141199556) && text7 != Class185.smethod_0(-1141199570))
					{
						smethod_4(text7, Class185.smethod_0(-1141199591));
					}
					return new Class32(string_1, int_, string_4, string_6, text, text7 == Class185.smethod_0(-1141199570));
				}
				catch (Exception ex2)
				{
					ex = ex2;
					throw;
				}
				finally
				{
					string text8 = null;
					try
					{
						if (File.Exists(text5))
						{
							File.Delete(text5);
						}
					}
					catch
					{
						if (ex == null)
						{
							text8 = Class185.smethod_0(-1141199601);
						}
					}
					if (flag)
					{
						Class71.Class72 class72_ = func_0(string_2, string_3, smethod_10(Class185.smethod_0(-1141258454) + text6), 15000);
						if (ex == null && !smethod_12(class72_))
						{
							text8 = Class185.smethod_0(-1141199636);
						}
					}
					if (text8 != null)
					{
						throw new InvalidOperationException(Class185.smethod_0(-1141199673) + text8);
					}
				}
			}
			throw new InvalidDataException(Class185.smethod_0(-1141202167));
		}
		throw new InvalidDataException(Class185.smethod_0(-1141202106));
	}

	private static string smethod_2(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, int int_1)
	{
		string text = string_2 + Class185.smethod_0(-1141199727);
		string text2 = string_3 + Class185.smethod_0(-1141199727);
		string text3 = text + Class185.smethod_0(-1141199737);
		string text4 = text2 + Class185.smethod_0(-1141199737);
		string text5 = text3 + Class185.smethod_0(-1141300031) + string_4;
		string text6 = text4 + Class185.smethod_0(-1141300031) + string_4;
		string text7 = text5 + Class185.smethod_0(-1141345452);
		string text8 = text6 + Class185.smethod_0(-1141345452);
		string string_5 = Class185.smethod_0(-1141199761) + text + Class185.smethod_0(-1141199790) + text + Class185.smethod_0(-1141297658) + text2 + Class185.smethod_0(-1141198865) + int_0 + Class185.smethod_0(-1141198989) + text3 + Class185.smethod_0(-1141297658) + text4 + Class185.smethod_0(-1141199169) + string_4 + Class185.smethod_0(-1141199354) + text5 + Class185.smethod_0(-1141297658) + text6 + Class185.smethod_0(-1141200554) + text7 + Class185.smethod_0(-1141297658) + text8 + Class185.smethod_0(-1141200823) + int_1 + Class185.smethod_0(-1141199944) + string_4 + Class185.smethod_0(-1141200051);
		return smethod_5(smethod_11(func_0, string_0, string_1, smethod_10(string_5), 15000, Class185.smethod_0(-1141200245), null).string_1, Class185.smethod_0(-1141199436));
	}

	private static string smethod_3(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, int int_1, string string_5, string string_6)
	{
		string text = string_2 + Class185.smethod_0(-1141199727);
		string text2 = string_3 + Class185.smethod_0(-1141199727);
		string text3 = Class185.smethod_0(-1141254766) + string_6;
		string string_7 = Class185.smethod_0(-1141200273) + text + Class185.smethod_0(-1141200300) + text2 + Class185.smethod_0(-1141200318) + string_4 + Class185.smethod_0(-1141200328) + int_0 + Class185.smethod_0(-1141205697) + text3 + Class185.smethod_0(-1141205093) + string_5 + Class185.smethod_0(-1141205180) + int_1 + Class185.smethod_0(-1141205423) + int_1 + Class185.smethod_0(-1141206555) + int_1 + Class185.smethod_0(-1141206856);
		return smethod_5(smethod_11(func_0, string_0, string_1, smethod_10(string_7), 15000, Class185.smethod_0(-1141343914), null).string_1, Class185.smethod_0(-1141199591));
	}

	private static void smethod_4(string string_0, string string_1)
	{
		if (!(string_0 == Class185.smethod_0(-1141294339)) || !(string_1 == Class185.smethod_0(-1141199436)))
		{
			if (string_0 == Class185.smethod_0(-1141253944))
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141206064));
			}
			if (string_0 == Class185.smethod_0(-1141206129))
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141206145));
			}
			if (string_0 == Class185.smethod_0(-1141206226))
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141206244));
			}
			throw new InvalidOperationException(Class185.smethod_0(-1141206307));
		}
	}

	private static string smethod_5(string string_0, string string_1)
	{
		Match match = Regex.Match(string_0 ?? string.Empty, Class185.smethod_0(-1141206370) + Regex.Escape(string_1) + Class185.smethod_0(-1141206397), RegexOptions.CultureInvariant);
		if (!match.Success)
		{
			throw new InvalidOperationException(Class185.smethod_0(-1141206425));
		}
		return match.Groups[Class185.smethod_0(-1141206475)].Value;
	}

	private static void smethod_6(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1)
	{
		if (!string.Equals(smethod_11(func_0, string_0, string_1, Class185.smethod_0(-1141303611), 8000, Class185.smethod_0(-1141206495), null).string_1.Trim(), Class185.smethod_0(-1141303627), StringComparison.Ordinal))
		{
			throw new InvalidOperationException(Class185.smethod_0(-1141206515));
		}
	}

	private static int smethod_7(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1, string string_2)
	{
		Match match = Regex.Match(smethod_11(func_0, string_0, string_1, Class185.smethod_0(-1141253683) + string_2, 15000, Class185.smethod_0(-1141203495), null).string_1, Class185.smethod_0(-1141203525), RegexOptions.CultureInvariant);
		if (!match.Success || !string.Equals(match.Groups[Class185.smethod_0(-1141342523)].Value, string_2, StringComparison.Ordinal) || !int.TryParse(match.Groups[Class185.smethod_0(-1141203603)].Value, out var result) || result < 10000)
		{
			throw new InvalidOperationException(Class185.smethod_0(-1141203621));
		}
		return result;
	}

	private static void smethod_8(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1, string string_2, out int int_0, out string string_3)
	{
		Class71.Class72 @class = smethod_11(func_0, string_0, string_1, Class185.smethod_0(-1141253765) + string_2, 15000, Class185.smethod_0(-1141203696), null);
		Match match = Regex.Match(@class.string_1, Class185.smethod_0(-1141203727), RegexOptions.CultureInvariant);
		Match match2 = Regex.Match(@class.string_1, Class185.smethod_0(-1141203787), RegexOptions.CultureInvariant);
		Match match3 = Regex.Match(@class.string_1, Class185.smethod_0(-1141203827), RegexOptions.CultureInvariant);
		if (match.Success && string.Equals(match.Groups[Class185.smethod_0(-1141342523)].Value, string_2, StringComparison.Ordinal) && match2.Success && int.TryParse(match2.Groups[Class185.smethod_0(-1141203603)].Value, out int_0) && int_0 >= 10000 && match3.Success)
		{
			string_3 = match3.Groups[Class185.smethod_0(-1141299812)].Value;
			string b = Class185.smethod_0(-1141199362) + string_2;
			string b2 = Class185.smethod_0(-1141199390) + string_2;
			if (!string.Equals(string_3, b, StringComparison.Ordinal) && !string.Equals(string_3, b2, StringComparison.Ordinal))
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141203924));
			}
			return;
		}
		throw new InvalidOperationException(Class185.smethod_0(-1141203866));
	}

	private static void smethod_9(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1)
	{
		if (!string.Equals(smethod_11(func_0, string_0, string_1, Class185.smethod_0(-1141202991), 8000, Class185.smethod_0(-1141203016), null).string_1.Trim(), Class185.smethod_0(-1141296459), StringComparison.Ordinal))
		{
			throw new InvalidOperationException(Class185.smethod_0(-1141203040));
		}
	}

	private static string smethod_10(string string_0)
	{
		return Class185.smethod_0(-1141301894) + string_0 + Class185.smethod_0(-1141301920);
	}

	private static Class71.Class72 smethod_11(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1, string string_2, int int_0, string string_3, string string_4)
	{
		Class71.Class72 @class = func_0(string_0, string_1, string_2, int_0);
		if (!smethod_12(@class))
		{
			string text = ((@class == null) ? Class185.smethod_0(-1141203103) : @class.string_0);
			if (!string.IsNullOrEmpty(string_0) && text != null)
			{
				text = text.Replace(string_0, Class185.smethod_0(-1141203115));
			}
			if (!string.IsNullOrEmpty(string_4) && text != null)
			{
				text = text.Replace(string_4, Class185.smethod_0(-1141203135));
			}
			if (string.IsNullOrWhiteSpace(text))
			{
				text = ((@class == null || !@class.bool_1) ? Class185.smethod_0(-1141203158) : Class185.smethod_0(-1141203183));
			}
			if (text.Length > 240)
			{
				text = text.Substring(0, 240);
			}
			throw new InvalidOperationException(string_3 + Class185.smethod_0(-1141203195) + text.Trim());
		}
		return @class;
	}

	private static bool smethod_12(Class71.Class72 class72_0)
	{
		if (class72_0 != null && class72_0.method_0())
		{
			return string.IsNullOrWhiteSpace(class72_0.string_2);
		}
		return false;
	}
}
