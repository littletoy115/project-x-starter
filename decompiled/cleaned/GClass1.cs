using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

public sealed class GClass1
{
	private sealed class Class5
	{
		public HashSet<NetworkInterfaceType> hashSet_0;

		internal bool method_0(NetworkInterface networkInterface_0)
		{
			if (networkInterface_0.OperationalStatus == OperationalStatus.Up)
			{
				return hashSet_0.Contains(networkInterface_0.NetworkInterfaceType);
			}
			return false;
		}
	}

	[Serializable]
	private sealed class Class6
	{
		public static readonly Class6 class6_0 = new Class6();

		public static Func<DriveInfo, bool> func_0;

		public static Func<NetworkInterface, NetworkInterfaceType> func_1;

		public static Func<NetworkInterface, string> func_2;

		public static Func<string, bool> func_3;

		internal bool method_0(DriveInfo driveInfo_0)
		{
			if (driveInfo_0.IsReady)
			{
				return driveInfo_0.Name.StartsWith(Class185.smethod_0(-1141297596));
			}
			return false;
		}

		internal NetworkInterfaceType method_1(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.NetworkInterfaceType;
		}

		internal string method_2(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.GetPhysicalAddress().ToString();
		}

		internal bool method_3(string string_0)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				return string_0 != Class185.smethod_0(-1141297604);
			}
			return false;
		}
	}

	private readonly string string_0;

	private readonly GClass18 gclass18_0;

	private static string string_1;

	private static string string_2;

	private static string string_3;

	public GClass1()
	{
		string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Class185.smethod_0(-1141297631));
		Directory.CreateDirectory(string_0);
		gclass18_0 = new GClass18(string_0);
	}

	public string method_0()
	{
		string text = gclass18_0.method_1(Class185.smethod_0(-1141297642));
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		try
		{
			string[] array = text.Split('|');
			if (array.Length == 2)
			{
				string result = array[0];
				byte[] byte_ = Convert.FromBase64String(array[1]);
				string string_ = method_3();
				method_12(byte_, string_);
				return result;
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	public string method_1()
	{
		string text = gclass18_0.method_1(Class185.smethod_0(-1141297642));
		string text2 = method_3();
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				string[] array = text.Split('|');
				if (array.Length == 2)
				{
					string result = array[0];
					byte[] byte_ = Convert.FromBase64String(array[1]);
					if (!string.IsNullOrEmpty(method_12(byte_, text2)))
					{
						return result;
					}
				}
			}
			catch (Exception)
			{
			}
		}
		string text3 = method_9();
		string text4 = method_7();
		string text5 = method_10();
		string string_ = text3 + Class185.smethod_0(-1141297658) + text4 + Class185.smethod_0(-1141297658) + text5 + Class185.smethod_0(-1141297658) + Environment.MachineName;
		string text6 = method_11(string_);
		string string_2 = DateTime.UtcNow.ToString(Class185.smethod_0(-1141298690));
		string string_3 = string.Concat(str2: Convert.ToBase64String(method_13(string_2, text2)), str0: text6, str1: Class185.smethod_0(-1141297658));
		gclass18_0.method_0(Class185.smethod_0(-1141297642), string_3);
		return text6;
	}

	public string method_2()
	{
		Version version = Assembly.GetExecutingAssembly().GetName().Version;
		return string.Format(Class185.smethod_0(-1141298698), version.Major, version.Minor);
	}

	private string method_3()
	{
		string text = method_4();
		string text2 = method_6();
		string text3 = method_5();
		string text4 = method_7();
		if (string.IsNullOrEmpty(text) && string.IsNullOrEmpty(text2) && string.IsNullOrEmpty(text3) && string.IsNullOrEmpty(text4))
		{
			return method_11(string.Format(Class185.smethod_0(-1141298720), Environment.MachineName, Environment.UserName, Environment.OSVersion, Environment.ProcessorCount));
		}
		return method_11(text + Class185.smethod_0(-1141297658) + text2 + Class185.smethod_0(-1141297658) + text3 + Class185.smethod_0(-1141297658) + text4);
	}

	private string method_4()
	{
		if (string_1 != null)
		{
			return string_1;
		}
		try
		{
			ManagementClass managementClass = new ManagementClass(Class185.smethod_0(-1141298742));
			try
			{
				using ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();
				foreach (ManagementBaseObject item in managementObjectCollection)
				{
					object value = item.Properties[Class185.smethod_0(-1141298756)].Value;
					object obj;
					if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
					{
						object value2 = item.Properties[Class185.smethod_0(-1141298782)].Value;
						if (value2 == null)
						{
							obj = null;
						}
						else
						{
							string text = value2.ToString();
							if (text == null)
							{
								obj = null;
							}
							else
							{
								obj = text.Trim();
								if (obj != null)
								{
									goto IL_00a4;
								}
							}
						}
						obj = string.Empty;
						goto IL_00a4;
					}
					string_1 = value.ToString().Trim();
					return string_1;
					IL_00e1:
					object obj2;
					string text2 = (string)obj2;
					object value3 = item.Properties[Class185.smethod_0(-1141298808)].Value;
					object obj3;
					if (value3 == null)
					{
						obj3 = null;
					}
					else
					{
						obj3 = value3.ToString();
						if (obj3 != null)
						{
							goto IL_0112;
						}
					}
					obj3 = string.Empty;
					goto IL_0112;
					IL_00a4:
					string text3 = (string)obj;
					object value4 = item.Properties[Class185.smethod_0(-1141298785)].Value;
					if (value4 == null)
					{
						obj2 = null;
					}
					else
					{
						string text4 = value4.ToString();
						if (text4 == null)
						{
							obj2 = null;
						}
						else
						{
							obj2 = text4.Trim();
							if (obj2 != null)
							{
								goto IL_00e1;
							}
						}
					}
					obj2 = string.Empty;
					goto IL_00e1;
					IL_0112:
					string text5 = (string)obj3;
					if (!string.IsNullOrEmpty(text3))
					{
						string_1 = method_11(text3 + Class185.smethod_0(-1141297658) + text2 + Class185.smethod_0(-1141297658) + text5);
						return string_1;
					}
				}
			}
			finally
			{
				((IDisposable)managementClass).Dispose();
			}
		}
		catch
		{
		}
		string_1 = string.Empty;
		return string.Empty;
	}

	private string method_5()
	{
		if (string_2 != null)
		{
			return string_2;
		}
		try
		{
			ManagementClass managementClass = new ManagementClass(Class185.smethod_0(-1141298820));
			try
			{
				using ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();
				foreach (ManagementBaseObject item in managementObjectCollection)
				{
					object value = item.Properties[Class185.smethod_0(-1141298842)].Value;
					object obj;
					if (value == null)
					{
						obj = null;
					}
					else
					{
						string text = value.ToString();
						if (text == null)
						{
							obj = null;
						}
						else
						{
							obj = text.Trim();
							if (obj != null)
							{
								goto IL_006f;
							}
						}
					}
					obj = string.Empty;
					goto IL_006f;
					IL_006f:
					string text2 = (string)obj;
					if (!string.IsNullOrEmpty(text2) && !text2.Equals(Class185.smethod_0(-1141298869), StringComparison.OrdinalIgnoreCase) && !text2.Equals(Class185.smethod_0(-1141298882), StringComparison.OrdinalIgnoreCase))
					{
						string_2 = text2;
						return string_2;
					}
				}
			}
			finally
			{
				((IDisposable)managementClass).Dispose();
			}
		}
		catch
		{
		}
		string_2 = string.Empty;
		return string.Empty;
	}

	private string method_6()
	{
		if (string_3 != null)
		{
			return string_3;
		}
		try
		{
			ManagementClass managementClass = new ManagementClass(Class185.smethod_0(-1141298919));
			try
			{
				using ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();
				foreach (ManagementBaseObject item in managementObjectCollection)
				{
					object value = item.Properties[Class185.smethod_0(-1141298842)].Value;
					object obj;
					if (value == null)
					{
						obj = null;
					}
					else
					{
						string text = value.ToString();
						if (text == null)
						{
							obj = null;
						}
						else
						{
							obj = text.Trim();
							if (obj != null)
							{
								goto IL_006f;
							}
						}
					}
					obj = string.Empty;
					goto IL_006f;
					IL_006f:
					string text2 = (string)obj;
					if (!string.IsNullOrEmpty(text2) && !text2.Equals(Class185.smethod_0(-1141298869), StringComparison.OrdinalIgnoreCase) && !text2.Equals(Class185.smethod_0(-1141298882), StringComparison.OrdinalIgnoreCase))
					{
						string_3 = text2;
						return string_3;
					}
				}
			}
			finally
			{
				((IDisposable)managementClass).Dispose();
			}
		}
		catch
		{
		}
		string_3 = string.Empty;
		return string.Empty;
	}

	private string method_7()
	{
		try
		{
			if (DriveInfo.GetDrives().FirstOrDefault(Class6.class6_0.method_0) != null)
			{
				return method_8(Class185.smethod_0(-1141298936));
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	private string method_8(string string_4)
	{
		try
		{
			ManagementObject managementObject = new ManagementObject(Class185.smethod_0(-1141298937) + string_4 + Class185.smethod_0(-1141298972));
			try
			{
				object value = managementObject.Properties[Class185.smethod_0(-1141298980)].Value;
				if (value != null)
				{
					return value.ToString();
				}
			}
			finally
			{
				((IDisposable)managementObject).Dispose();
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	private string method_9()
	{
		try
		{
			string text = method_4();
			string text2 = method_5();
			string text3 = method_6();
			string string_ = text + Class185.smethod_0(-1141297658) + text2 + Class185.smethod_0(-1141297658) + text3;
			return method_11(string_);
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	private string method_10()
	{
		try
		{
			Class5 @class = new Class5();
			@class.hashSet_0 = new HashSet<NetworkInterfaceType>
			{
				NetworkInterfaceType.Ethernet,
				NetworkInterfaceType.Wireless80211,
				NetworkInterfaceType.GigabitEthernet,
				NetworkInterfaceType.FastEthernetT,
				NetworkInterfaceType.FastEthernetFx
			};
			return NetworkInterface.GetAllNetworkInterfaces().Where(@class.method_0).OrderBy(Class6.class6_0.method_1)
				.Select(Class6.class6_0.method_2)
				.FirstOrDefault(Class6.class6_0.method_3) ?? string.Empty;
		}
		catch
		{
			return string.Empty;
		}
	}

	private string method_11(string string_4)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_4);
		return BitConverter.ToString(mD.ComputeHash(bytes)).Replace(Class185.smethod_0(-1141293701), string.Empty);
	}

	private string method_12(byte[] byte_0, string string_4)
	{
		try
		{
			if (byte_0 != null && byte_0.Length >= 16)
			{
				byte[] array = Encoding.UTF8.GetBytes(string_4);
				Array.Resize(ref array, 32);
				byte[] array2 = new byte[16];
				Array.Copy(byte_0, 0, array2, 0, array2.Length);
				using Aes aes = Aes.Create();
				aes.Key = array;
				aes.IV = array2;
				aes.Mode = CipherMode.CBC;
				using ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
				MemoryStream memoryStream = new MemoryStream(byte_0, 16, byte_0.Length - 16);
				try
				{
					CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
					try
					{
						StreamReader streamReader = new StreamReader(cryptoStream);
						try
						{
							return streamReader.ReadToEnd();
						}
						finally
						{
							((IDisposable)streamReader).Dispose();
						}
					}
					finally
					{
						((IDisposable)cryptoStream).Dispose();
					}
				}
				finally
				{
					((IDisposable)memoryStream).Dispose();
				}
			}
			return string.Empty;
		}
		catch
		{
			return string.Empty;
		}
	}

	private byte[] method_13(string string_4, string string_5)
	{
		try
		{
			byte[] array = Encoding.UTF8.GetBytes(string_5);
			Array.Resize(ref array, 32);
			byte[] array2 = new byte[16];
			RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			try
			{
				rNGCryptoServiceProvider.GetBytes(array2);
			}
			finally
			{
				((IDisposable)rNGCryptoServiceProvider).Dispose();
			}
			byte[] result;
			using (Aes aes = Aes.Create())
			{
				aes.Key = array;
				aes.IV = array2;
				aes.Mode = CipherMode.CBC;
				using ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
				MemoryStream memoryStream = new MemoryStream();
				try
				{
					memoryStream.Write(array2, 0, array2.Length);
					CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					try
					{
						StreamWriter streamWriter = new StreamWriter(cryptoStream);
						try
						{
							streamWriter.Write(string_4);
						}
						finally
						{
							((IDisposable)streamWriter).Dispose();
						}
					}
					finally
					{
						((IDisposable)cryptoStream).Dispose();
					}
					result = memoryStream.ToArray();
				}
				finally
				{
					((IDisposable)memoryStream).Dispose();
				}
			}
			return result;
		}
		catch
		{
			return new byte[0];
		}
	}
}
