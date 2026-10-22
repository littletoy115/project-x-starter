using System;
using System.IO;

internal static class Class396
{
	internal static bool smethod_0(string string_0, bool bool_0)
	{
		if (!File.Exists(string_0))
		{
			throw new FileNotFoundException(Class185.smethod_0(-1141303936), string_0);
		}
		Class59 @class = new Class59(string_0);
		bool result;
		try
		{
			if (@class.method_1(Class185.smethod_0(-1141303964)) != Class185.smethod_0(-1141303993))
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141304002));
			}
			string text = @class.method_1(Class185.smethod_0(-1141304050));
			string text2 = @class.method_1(Class185.smethod_0(-1141304114));
			if (!(result = (bool_0 ? (text2 != null) : (text2 != Class185.smethod_0(-1141296459)))))
			{
				return false;
			}
			@class.method_0(Class185.smethod_0(-1141304172));
			try
			{
				if (bool_0)
				{
					@class.method_0(Class185.smethod_0(-1141304194));
				}
				else
				{
					@class.method_0(Class185.smethod_0(-1141304254));
				}
				@class.method_0(Class185.smethod_0(-1141303336));
			}
			catch
			{
				try
				{
					@class.method_0(Class185.smethod_0(-1141303349));
				}
				catch (InvalidOperationException)
				{
				}
				throw;
			}
			@class.method_0(Class185.smethod_0(-1141303356));
			if (@class.method_1(Class185.smethod_0(-1141303964)) != Class185.smethod_0(-1141303993) || @class.method_1(Class185.smethod_0(-1141304050)) != text)
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141303394));
			}
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		if (!File.Exists(string_0 + Class185.smethod_0(-1141303447)) && !File.Exists(string_0 + Class185.smethod_0(-1141303450)))
		{
			return result;
		}
		throw new InvalidOperationException(Class185.smethod_0(-1141303469));
	}

	internal static bool smethod_1(string string_0, string string_1, bool bool_0)
	{
		if (!string.IsNullOrEmpty(string_0) && File.Exists(string_0))
		{
			if (!Class71.smethod_2(string_1))
			{
				throw new ArgumentException(Class185.smethod_0(-1141303566), Class185.smethod_0(-1141303608));
			}
			if (smethod_3(string_0, string_1, Class185.smethod_0(-1141303611), 8000) != Class185.smethod_0(-1141303627))
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141303648));
			}
			if (smethod_2(string_0, string_1, Class185.smethod_0(-1141303685), 8000) != Class185.smethod_0(-1141296459))
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141303689));
			}
			string text = smethod_2(string_0, string_1, Class185.smethod_0(-1141303739), 8000);
			if (text == Class185.smethod_0(-1141304945))
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141304967));
			}
			if (text != Class185.smethod_0(-1141305020))
			{
				throw new InvalidOperationException(Class185.smethod_0(-1141305040) + text);
			}
			string text2 = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141305101) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
			Directory.CreateDirectory(text2);
			try
			{
				string text3 = Path.Combine(text2, Class185.smethod_0(-1141305115));
				string text4 = Path.Combine(text2, Class185.smethod_0(-1141305138));
				smethod_2(string_0, string_1, Class185.smethod_0(-1141305168), 8000);
				smethod_3(string_0, string_1, Class185.smethod_0(-1141305334) + text3 + Class185.smethod_0(-1141304355), 20000);
				if (!smethod_0(text3, bool_0))
				{
					return false;
				}
				Class59 @class = new Class59(text3);
				string text5;
				try
				{
					text5 = @class.method_1(Class185.smethod_0(-1141304050));
				}
				finally
				{
					((IDisposable)@class).Dispose();
				}
				smethod_3(string_0, string_1, Class185.smethod_0(-1141304363) + text3 + Class185.smethod_0(-1141304384), 20000);
				smethod_2(string_0, string_1, Class185.smethod_0(-1141304431), 15000);
				smethod_2(string_0, string_1, Class185.smethod_0(-1141305168), 8000);
				smethod_3(string_0, string_1, Class185.smethod_0(-1141305334) + text4 + Class185.smethod_0(-1141304355), 20000);
				Class59 class2 = new Class59(text4);
				try
				{
					string text6 = class2.method_1(Class185.smethod_0(-1141304114));
					string text7 = class2.method_1(Class185.smethod_0(-1141304050));
					if (class2.method_1(Class185.smethod_0(-1141303964)) != Class185.smethod_0(-1141303993) || text6 != (bool_0 ? null : Class185.smethod_0(-1141296459)) || text7 != text5)
					{
						throw new InvalidOperationException(Class185.smethod_0(-1141304725));
					}
				}
				finally
				{
					((IDisposable)class2).Dispose();
				}
				return true;
			}
			finally
			{
				try
				{
					smethod_2(string_0, string_1, Class185.smethod_0(-1141301795), 8000);
				}
				catch (Exception)
				{
				}
				try
				{
					Directory.Delete(text2, recursive: true);
				}
				catch (IOException)
				{
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		throw new FileNotFoundException(Class185.smethod_0(-1141303520), string_0);
	}

	private static string smethod_2(string string_0, string string_1, string string_2, int int_0)
	{
		return smethod_3(string_0, string_1, Class185.smethod_0(-1141301894) + string_2 + Class185.smethod_0(-1141301920), int_0);
	}

	private static string smethod_3(string string_0, string string_1, string string_2, int int_0)
	{
		Class71.Class72 @class = Class71.smethod_1(string_0, string_1, string_2, int_0);
		if (!@class.method_0())
		{
			throw new InvalidOperationException(Class185.smethod_0(-1141301921) + string_2 + Class185.smethod_0(-1141301932) + @class.string_0);
		}
		return @class.string_1.Trim();
	}
}
