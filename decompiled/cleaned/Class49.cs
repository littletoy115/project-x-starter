using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal static class Class49
{
	private static readonly byte[] byte_0 = Encoding.ASCII.GetBytes(Class185.smethod_0(-1141300358));

	internal static string smethod_0(string string_0)
	{
		if (!string.IsNullOrWhiteSpace(string_0) && string_0.Length <= 4096 && string_0.IndexOfAny(new char[3] { '\r', '\n', '\0' }) < 0)
		{
			string text = smethod_2();
			smethod_4(text, bool_0: true);
			Directory.CreateDirectory(text);
			smethod_4(text, bool_0: false);
			string text2 = Path.Combine(text, Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)) + Class185.smethod_0(-1141300415));
			byte[] array = ProtectedData.Protect(Encoding.UTF8.GetBytes(string_0), byte_0, DataProtectionScope.CurrentUser);
			FileStream fileStream = new FileStream(text2, FileMode.CreateNew, FileAccess.Write, FileShare.None);
			try
			{
				fileStream.Write(array, 0, array.Length);
				fileStream.Flush(flushToDisk: true);
				return text2;
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
		}
		throw new ArgumentException(Class185.smethod_0(-1141294222), Class185.smethod_0(-1141300388));
	}

	internal static string smethod_1(string string_0)
	{
		string text = smethod_3(string_0);
		try
		{
			FileInfo fileInfo = new FileInfo(text);
			if (fileInfo.Exists && (fileInfo.Attributes & FileAttributes.ReparsePoint) == 0 && fileInfo.Length > 0L && fileInfo.Length <= 16384L)
			{
				byte[] bytes = ProtectedData.Unprotect(File.ReadAllBytes(text), byte_0, DataProtectionScope.CurrentUser);
				string text2 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true).GetString(bytes);
				if (string.IsNullOrWhiteSpace(text2) || text2.Length > 4096 || text2.IndexOfAny(new char[3] { '\r', '\n', '\0' }) >= 0)
				{
					throw new InvalidDataException(Class185.smethod_0(-1141300469));
				}
				return text2;
			}
			throw new InvalidDataException(Class185.smethod_0(-1141300420));
		}
		finally
		{
			try
			{
				if (File.Exists(text))
				{
					File.Delete(text);
				}
			}
			catch
			{
			}
		}
	}

	private static string smethod_2()
	{
		return Path.GetFullPath(Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141300506)));
	}

	private static string smethod_3(string string_0)
	{
		if (!string.IsNullOrWhiteSpace(string_0) && Path.IsPathRooted(string_0))
		{
			string fullPath = Path.GetFullPath(string_0);
			string text = smethod_2();
			smethod_4(text, bool_0: false);
			if (!string.Equals(Path.GetDirectoryName(fullPath), text, StringComparison.OrdinalIgnoreCase) || !Guid.TryParseExact(Path.GetFileNameWithoutExtension(fullPath), Class185.smethod_0(-1141300407), out var _) || !string.Equals(Path.GetExtension(fullPath), Class185.smethod_0(-1141300415), StringComparison.OrdinalIgnoreCase))
			{
				throw new InvalidDataException(Class185.smethod_0(-1141300590));
			}
			return fullPath;
		}
		throw new ArgumentException(Class185.smethod_0(-1141300550));
	}

	private static void smethod_4(string string_0, bool bool_0)
	{
		string pathRoot = Path.GetPathRoot(string_0);
		string text = pathRoot;
		string[] array = string_0.Substring(pathRoot.Length).Split(new char[2] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries);
		int num = 0;
		while (true)
		{
			if (num >= array.Length)
			{
				return;
			}
			text = Path.Combine(text, array[num]);
			if (Directory.Exists(text))
			{
				if ((File.GetAttributes(text) & FileAttributes.ReparsePoint) != 0)
				{
					break;
				}
				num++;
				continue;
			}
			if (bool_0 && num == array.Length - 1)
			{
				return;
			}
			throw new DirectoryNotFoundException(Class185.smethod_0(-1141300655));
		}
		throw new InvalidDataException(Class185.smethod_0(-1141300701));
	}
}
