using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

internal static class Class185
{
	private sealed class Class186
	{
		private Stream stream_0;

		private byte[] byte_0;

		public Class186(Stream stream_1)
		{
			stream_0 = stream_1;
			byte_0 = new byte[4];
		}

		public Stream method_0()
		{
			return stream_0;
		}

		public short method_1()
		{
			method_3(2);
			return (short)(byte_0[0] | (byte_0[1] << 8));
		}

		public int method_2()
		{
			method_3(4);
			return byte_0[0] | (byte_0[1] << 8) | (byte_0[2] << 16) | (byte_0[3] << 24);
		}

		private static void smethod_0()
		{
			throw new EndOfStreamException();
		}

		private void method_3(int int_0)
		{
			int num = 0;
			int num2 = 0;
			if (int_0 == 1)
			{
				num2 = stream_0.ReadByte();
				if (num2 == -1)
				{
					smethod_0();
				}
				byte_0[0] = (byte)num2;
				return;
			}
			do
			{
				num2 = stream_0.Read(byte_0, num, int_0 - num);
				if (num2 == 0)
				{
					smethod_0();
				}
				num += num2;
			}
			while (num < int_0);
		}

		public void method_4()
		{
			Stream stream = stream_0;
			stream_0 = null;
			stream?.Close();
			byte_0 = null;
		}

		public byte[] method_5(int int_0)
		{
			if (int_0 < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[int_0];
			int num = 0;
			do
			{
				int num2 = stream_0.Read(array, num, int_0);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				int_0 -= num2;
			}
			while (int_0 > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}
	}

	private enum Enum8
	{

	}

	private static int int_0;

	private static Class186 class186_0;

	private static ConcurrentDictionary<int, string> concurrentDictionary_0;

	private static byte[] byte_0;

	private static byte[] byte_1;

	private static short short_0;

	private static Enum8 enum8_0;

	private static int int_1;

	private static int int_2;

	static Class185()
	{
		int num = 920246534;
		int num2 = 845870546;
		concurrentDictionary_0 = new ConcurrentDictionary<int, string>();
		int num3 = 2;
		StackTrace stackTrace = new StackTrace(2, fNeedFileInfo: false);
		num3 = 0;
		StackFrame frame = stackTrace.GetFrame(0);
		int int_ = 0;
		if (frame == null)
		{
			stackTrace = new StackTrace();
			int_ = 1;
			frame = stackTrace.GetFrame(1);
		}
		int num4 = -(~(~(-(-(~(-(~(~((-1019345426 ^ num) - num2))))))))) ^ ~(-(-(~(~(-(-(~(~(-(~((369701070 - num) ^ num2)))))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num4 ^= -(~(~(-(-(~(-(~(~((num ^ 0x29692CD5) - num2)))))))));
		}
		Type type = methodBase?.DeclaringType;
		if (type == typeof(RuntimeMethodHandle))
		{
			num4 ^= num + -1766116273 + num2 + num3;
			enum8_0 |= (Enum8)4;
		}
		else if (type == null)
		{
			if (smethod_4(stackTrace, int_))
			{
				num4 ^= -(~(~(-(~(-(~(-(~(-78868787 ^ num ^ num2))))))))) - num3;
				enum8_0 = (Enum8)16 | enum8_0;
			}
			else
			{
				enum8_0 |= (Enum8)1;
				num4 ^= -(~(-(~(~(-(-(~(~(1766080035 - num - num2)))))))));
			}
		}
		else
		{
			num4 ^= ~(-(~(-(-(~(~(-(~(num ^ -78868787 ^ num2))))))))) - num3;
			enum8_0 = (Enum8)16 | enum8_0;
		}
		int_2 = num4 + int_2;
	}

	internal static string smethod_0(int int_3)
	{
		if (concurrentDictionary_0.TryGetValue(int_3, out var value))
		{
			return value;
		}
		return smethod_1(int_3, bool_0: true);
	}

	private static string smethod_1(int int_3, bool bool_0)
	{
		int num = 539390694;
		int num2 = -1838787998;
		string value = null;
		do
		{
			byte[] array;
			int num18;
			int num19;
			int num20;
			int num22;
			byte[] array4;
			byte[] array3;
			int num21;
			lock (concurrentDictionary_0)
			{
				int num6;
				if (class186_0 == null)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					Assembly callingAssembly;
					try
					{
						callingAssembly = Assembly.GetCallingAssembly();
					}
					catch (PlatformNotSupportedException)
					{
						callingAssembly = executingAssembly;
					}
					int_0 |= (num + 1918389754) ^ num2;
					StringBuilder stringBuilder = new StringBuilder();
					int num3 = (num ^ -1383612603) + num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (-762583732 - num) ^ num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (-1840316278 ^ num) - num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = (-762780342 - num) ^ num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (-1383612603 ^ num) + num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (-762452655 - num) ^ num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = (-1840709502 ^ num) - num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
					int num4 = 2;
					StackTrace stackTrace = new StackTrace(2, fNeedFileInfo: false);
					int_0 ^= (-1916782134 - num + num2) | 2;
					num4 = 0;
					StackFrame frame = stackTrace.GetFrame(0);
					int int_4 = 0;
					if (frame == null)
					{
						stackTrace = new StackTrace();
						int_4 = 1;
						frame = stackTrace.GetFrame(1);
					}
					MethodBase methodBase = frame?.GetMethod();
					int_0 ^= num4 + (1916788732 + num - num2);
					Type type = methodBase?.DeclaringType;
					if (frame == null)
					{
						int_0 ^= -1916569289 - num + num2;
					}
					bool flag = type == typeof(RuntimeMethodHandle);
					int_0 ^= (num ^ -1304419868) - num2;
					if (!flag && (flag = type == null))
					{
						if (smethod_4(stackTrace, int_4))
						{
							flag = false;
						}
						else
						{
							int_0 ^= 1299616587 + num + num2;
						}
					}
					if (flag == (stackTrace != null))
					{
						int_0 ^= 32;
					}
					int_0 ^= ((num ^ -1304422098) - num2) | (num4 + 1);
					class186_0 = new Class186(manifestResourceStream);
					short num5 = (short)(class186_0.method_1() ^ (short)(-(~(-(~(~(-(-(~(~(1299380580 + num + num2)))))))))));
					if (num5 == 0)
					{
						short_0 = (short)(class186_0.method_1() ^ (short)(-(~(~(-(-(~(~(-(-(~(~(num ^ 0x4DBFC7BC ^ num2)))))))))))));
					}
					else
					{
						byte_1 = class186_0.method_5(num5);
					}
					callingAssembly = executingAssembly;
					AssemblyName assemblyName_ = smethod_2(callingAssembly);
					byte_0 = smethod_3(assemblyName_);
					num6 = int_2;
					int_2 = 0;
					num6 ^= num + 1633904493 + num2;
					long num7 = Class105.smethod_0();
					num6 ^= (int)num7;
					num6 ^= (-1722188970 ^ num) - num2;
					num6 ^= (-625719944 + num) ^ num2;
					int num8 = 0;
					int num9 = 0;
					int num10 = num6;
					int num11 = 0;
					int num12 = 0;
					Interface4<int> @interface = null;
					int num13 = 0;
					num11 = num10;
					int num14 = 0;
					num12 = num11 ^ ((0x4E519F8D ^ num) - num2);
					num9 = 0;
					num8 = num12 * ((-1299400267 - num) ^ num2) % (1327138981 + num + num2);
					@interface = null;
					num9 = num ^ -1304420111 ^ num2;
					num14 = 0;
					num13 = num8;
					@interface = ((Interface3<int>)new Class97.Class99((-1916788606 - num) | num2)
					{
						int_4 = num13
					}).GetEnumerator();
					try
					{
						while (@interface.imethod_1())
						{
							num14 = @interface.imethod_3();
							num8 ^= num14 - num9;
							num9 -= num8 + 3 >> 8;
						}
					}
					finally
					{
						((Interface0)@interface)?.imethod_0();
					}
					int num15 = num8;
					num6 ^= 1300112362 + num + num2 + -(~(~(-(~(-(~(-(~(-(~(-1299397614 - num - num2)))))))))));
					num6 ^= -(~(-(~(-(~(~(-(-(~(~((num ^ 0x528C5C2F) + num2)))))))))));
					num6 += num15;
					int_0 = (int_0 & ((-1111482378 - num) ^ num2)) ^ (1916795392 + num - num2);
					int_1 = num6;
					if (((uint)enum8_0 & (uint)(~(-(-(~(~(-(~(-(-(~(~((-1916788622 - num) | num2))))))))))))) == 0)
					{
						int_0 = (1916831474 + num) ^ num2;
					}
				}
				else
				{
					num6 = int_1;
				}
				if (int_0 == (num ^ 0x4DBC2BBE) + num2)
				{
					value = new string(new char[3]
					{
						(char)((-1299397344 - num) ^ num2),
						'0',
						(char)(num + 1299397392 + num2)
					});
					return value;
				}
				int num16 = int_3 ^ (386230417 - num - num2) ^ num6;
				num16 ^= (num + -1679286138) ^ num2;
				class186_0.method_0().Position = num16;
				if (byte_1 != null)
				{
					array = byte_1;
				}
				else
				{
					short num17 = ((short_0 != -1) ? short_0 : ((short)(class186_0.method_1() ^ (-1916765170 - num + num2) ^ num16)));
					if (num17 == 0)
					{
						array = null;
					}
					else
					{
						array = class186_0.method_5(num17);
						for (int i = 0; i != array.Length; i++)
						{
							array[i] ^= (byte)(int_1 >> ((3 & i) << 3));
						}
					}
				}
				num18 = class186_0.method_2() ^ num16 ^ -(~(~(-(~(-(~(-(-(~(~(0x4A08AE28 ^ num ^ num2))))))))))) ^ num6;
				if (num18 == ((1299397302 + num) | num2))
				{
					byte[] array2 = class186_0.method_5(4);
					int_3 = ((num ^ -1170493102) - num2) ^ num6;
					int_3 = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -int_3;
					continue;
				}
				num19 = int_0;
				num20 = (-1297789494 - num) ^ num2;
				num21 = num19 - 12;
				num22 = num18;
				num18 &= num + 1567832759 + num2;
				array3 = class186_0.method_5(num18);
				array4 = byte_0;
			}
			bool flag2 = (num22 & (num ^ -1841291132 ^ num2)) != 0;
			bool flag3 = (num22 & (-225655480 - num - num2)) != 0;
			bool flag4 = (num22 & (-848086344 + num + num2)) != 0;
			byte[] array5 = array;
			byte[] array6 = array3;
			byte[] array7 = array5;
			ushort num23 = 0;
			byte b = 0;
			byte b2 = 0;
			int num24 = 0;
			byte b3 = 0;
			uint num25 = 0u;
			byte b4 = 0;
			int num26 = 0;
			b = array7[1];
			num24 = array6.Length;
			b2 = (byte)((11 + num24) ^ (7 + b));
			num25 = (uint)((array7[0] | (array7[2] << 8)) + (b2 << 3));
			num26 = 0;
			num23 = 0;
			while (num26 < num24)
			{
				if ((1 & num26) == 0)
				{
					num25 = (uint)((int)num25 * (-1299183291 - num - num2) + ((num ^ 0x4DE63E87) + num2));
					num23 = (ushort)(num25 >> 16);
				}
				b3 = (byte)num23;
				num23 >>= 8;
				b4 = array6[num26];
				array6[num26] = (byte)(b4 ^ b ^ (3 + b2) ^ b3);
				b2 = b4;
				num26 = 1 + num26;
			}
			array3 = array6;
			if (array4 != null != (num19 != num20))
			{
				for (int j = 0; j < num18; j++)
				{
					byte b5 = array4[7 & j];
					b5 = (byte)((b5 << 3) | (b5 >> 5));
					array3[j] ^= b5;
				}
			}
			byte[] array8;
			int num27;
			if (!flag3)
			{
				array8 = array3;
				num27 = num18;
			}
			else
			{
				num27 = array3[2] | (array3[0] << 16) | (array3[3] << 8) | (array3[1] << 24);
				array8 = new byte[num27];
				smethod_5(array3, 4, array8);
			}
			if (flag2 && num21 == num20 - 12)
			{
				char[] array9 = new char[num27];
				for (int num28 = 0; num28 < num27; num28 = 1 + num28)
				{
					array9[num28] = (char)array8[num28];
				}
				value = new string(array9);
			}
			else
			{
				char[] array10 = new char[num27 / 2];
				int num29 = 0;
				for (int k = 0; k < num27; k += 2)
				{
					array10[num29++] = (char)(array8[k] | (array8[1 + k] << 8));
				}
				value = new string(array10);
			}
			num21 += ((-1299397373 - num) ^ num2) + (3 & num21) << 5;
			if (num21 != num20 - 12 + (1299397431 + num + num2 + ((num20 - 12) & 3) << 5))
			{
				int num30 = (num18 + int_3) ^ (-1298460736 - num - num2) ^ (num21 & ((num + 1916789897) ^ num2));
				StringBuilder stringBuilder = new StringBuilder();
				int num3 = -1299397216 - num - num2;
				stringBuilder.Append((char)(byte)num3);
				value = num30.ToString(stringBuilder.ToString());
			}
			if (!flag4 && bool_0)
			{
				value = string.Intern(value);
				concurrentDictionary_0[int_3] = value;
				if (concurrentDictionary_0.Count == (-1304412389 ^ num ^ num2))
				{
					bool lockTaken = false;
					ConcurrentDictionary<int, string> obj = concurrentDictionary_0;
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						if (class186_0 != null)
						{
							class186_0.method_4();
							class186_0 = null;
							byte_1 = null;
							byte_0 = null;
						}
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(obj);
						}
					}
				}
			}
			return value;
		}
		while (!concurrentDictionary_0.TryGetValue(int_3, out value));
		return value;
	}

	private static AssemblyName smethod_2(Assembly assembly_0)
	{
		try
		{
			return assembly_0.GetName();
		}
		catch
		{
			return new AssemblyName(assembly_0.FullName);
		}
	}

	private static byte[] smethod_3(AssemblyName assemblyName_0)
	{
		byte[] array = assemblyName_0.GetPublicKeyToken();
		if (array != null && array.Length == 0)
		{
			array = null;
		}
		return array;
	}

	private static bool smethod_4(StackTrace stackTrace_0, int int_3)
	{
		Assembly assembly = stackTrace_0.GetFrame(++int_3)?.GetMethod()?.DeclaringType?.Assembly;
		if (assembly != null)
		{
			AssemblyName assemblyName_ = smethod_2(assembly);
			byte[] array = smethod_3(assemblyName_);
			if (array != null && array.Length == 8 && array[0] == 183 && array[7] == 137)
			{
				return true;
			}
		}
		while (true)
		{
			StackFrame frame = stackTrace_0.GetFrame(++int_3);
			if (frame == null)
			{
				break;
			}
			assembly = frame.GetMethod()?.DeclaringType?.Assembly;
			if (assembly != null && assembly == typeof(Class185).Assembly)
			{
				return true;
			}
		}
		return false;
	}

	private static void smethod_5(byte[] byte_2, int int_3, byte[] byte_3)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 128;
		int num4 = byte_3.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = byte_2[int_3++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (byte_2[int_3] >> 2) + 3;
				int num6 = ((byte_2[int_3] << 8) | byte_2[int_3 + 1]) & 0x3FF;
				int_3 += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					byte_3[num++] = byte_3[num7++];
				}
			}
			else
			{
				byte_3[num++] = byte_2[int_3++];
			}
		}
	}
}
