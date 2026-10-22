using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading;

internal sealed class Class64 : IDisposable
{
	private readonly MemoryMappedFile memoryMappedFile_0;

	private readonly MemoryMappedViewAccessor memoryMappedViewAccessor_0;

	private readonly Mutex mutex_0;

	private readonly int int_0 = Process.GetCurrentProcess().Id;

	private int int_1 = -1;

	private bool bool_0;

	internal Class64()
		: this(smethod_0())
	{
	}

	internal Class64(string string_0)
	{
		memoryMappedFile_0 = MemoryMappedFile.CreateOrOpen(string_0, 4096L, MemoryMappedFileAccess.ReadWrite);
		memoryMappedViewAccessor_0 = memoryMappedFile_0.CreateViewAccessor(0L, 4096L, MemoryMappedFileAccess.ReadWrite);
		mutex_0 = new Mutex(initiallyOwned: false, string_0 + Class185.smethod_0(-1141035550));
	}

	internal static string smethod_0()
	{
		return Class185.smethod_0(-1141035554) + Class135.smethod_4().Replace(Class185.smethod_0(-1141293701), string.Empty) + Class185.smethod_0(-1141035575);
	}

	internal bool method_0(Class401 class401_0)
	{
		if (!bool_0 && class401_0 != null && class401_0.uint_0 != 0 && !string.IsNullOrWhiteSpace(class401_0.string_0))
		{
			if (!method_4())
			{
				return false;
			}
			try
			{
				if (int_1 < 0 || memoryMappedViewAccessor_0.ReadInt32(int_1 * 128) != int_0)
				{
					int_1 = method_3(DateTime.UtcNow.Ticks);
				}
				if (int_1 < 0)
				{
					return false;
				}
				int num = int_1 * 128;
				byte[] bytes = Encoding.UTF8.GetBytes(class401_0.string_0);
				int num2 = Math.Min(bytes.Length, 80);
				while (num2 > 0 && num2 < bytes.Length && (bytes[num2] & 0xC0) == 128)
				{
					num2--;
				}
				memoryMappedViewAccessor_0.Write(num + 4, class401_0.uint_0);
				memoryMappedViewAccessor_0.Write(num + 8, class401_0.bool_0 ? 1 : 0);
				memoryMappedViewAccessor_0.Write(num + 12, class401_0.float_0);
				memoryMappedViewAccessor_0.Write(num + 16, class401_0.float_1);
				memoryMappedViewAccessor_0.Write(num + 20, class401_0.float_2);
				memoryMappedViewAccessor_0.Write(num + 24, class401_0.long_0);
				memoryMappedViewAccessor_0.Write(num + 32, num2);
				memoryMappedViewAccessor_0.WriteArray(num + 36, bytes, 0, num2);
				memoryMappedViewAccessor_0.Write(num + 116, class401_0.byte_0);
				memoryMappedViewAccessor_0.Write(num + 117, class401_0.bool_1 ? ((byte)1) : ((byte)0));
				memoryMappedViewAccessor_0.Write(num + 118, class401_0.byte_1);
				memoryMappedViewAccessor_0.Write(num + 119, class401_0.bool_2 ? ((byte)1) : ((byte)0));
				memoryMappedViewAccessor_0.Write(num + 120, class401_0.ushort_0);
				memoryMappedViewAccessor_0.Write(num, int_0);
				return true;
			}
			finally
			{
				mutex_0.ReleaseMutex();
			}
		}
		return false;
	}

	internal IReadOnlyList<Class401> method_1(DateTime dateTime_0)
	{
		List<Class401> list = new List<Class401>();
		if (!bool_0 && method_4())
		{
			try
			{
				for (int i = 0; i < 32; i++)
				{
					int num = i * 128;
					if (memoryMappedViewAccessor_0.ReadInt32(num) != 0)
					{
						long num2 = memoryMappedViewAccessor_0.ReadInt64(num + 24);
						long num3 = dateTime_0.Ticks - num2;
						if (num2 > 0L && num3 >= 0L && num3 <= TimeSpan.FromSeconds(2.0).Ticks)
						{
							int num4 = memoryMappedViewAccessor_0.ReadInt32(num + 32);
							if (num4 > 0 && num4 <= 80)
							{
								byte[] array = new byte[num4];
								memoryMappedViewAccessor_0.ReadArray(num + 36, array, 0, num4);
								list.Add(new Class401
								{
									uint_0 = memoryMappedViewAccessor_0.ReadUInt32(num + 4),
									bool_0 = (memoryMappedViewAccessor_0.ReadInt32(num + 8) != 0),
									float_0 = memoryMappedViewAccessor_0.ReadSingle(num + 12),
									float_1 = memoryMappedViewAccessor_0.ReadSingle(num + 16),
									float_2 = memoryMappedViewAccessor_0.ReadSingle(num + 20),
									long_0 = num2,
									byte_0 = memoryMappedViewAccessor_0.ReadByte(num + 116),
									bool_1 = (memoryMappedViewAccessor_0.ReadByte(num + 117) != 0),
									byte_1 = memoryMappedViewAccessor_0.ReadByte(num + 118),
									bool_2 = (memoryMappedViewAccessor_0.ReadByte(num + 119) != 0),
									ushort_0 = memoryMappedViewAccessor_0.ReadUInt16(num + 120),
									string_0 = Encoding.UTF8.GetString(array)
								});
							}
						}
					}
				}
				return list;
			}
			finally
			{
				mutex_0.ReleaseMutex();
			}
		}
		return list;
	}

	internal void method_2()
	{
		if (bool_0 || int_1 < 0 || !method_4())
		{
			return;
		}
		try
		{
			if (memoryMappedViewAccessor_0.ReadInt32(int_1 * 128) == int_0)
			{
				memoryMappedViewAccessor_0.Write(int_1 * 128, 0);
				memoryMappedViewAccessor_0.Write(int_1 * 128 + 24, 0L);
			}
			int_1 = -1;
		}
		finally
		{
			mutex_0.ReleaseMutex();
		}
	}

	private int method_3(long long_0)
	{
		int num = -1;
		int num2 = 0;
		while (true)
		{
			if (num2 < 32)
			{
				int num3 = num2 * 128;
				int num4 = memoryMappedViewAccessor_0.ReadInt32(num3);
				if (num4 == int_0)
				{
					break;
				}
				long num5 = memoryMappedViewAccessor_0.ReadInt64(num3 + 24);
				if (num < 0 && (num4 == 0 || num5 <= 0L || long_0 - num5 > TimeSpan.FromSeconds(5.0).Ticks))
				{
					num = num2;
				}
				num2++;
				continue;
			}
			return num;
		}
		return num2;
	}

	private bool method_4()
	{
		try
		{
			return mutex_0.WaitOne(0);
		}
		catch (AbandonedMutexException)
		{
			return true;
		}
	}

	public void Dispose()
	{
		if (!bool_0)
		{
			method_2();
			bool_0 = true;
			memoryMappedViewAccessor_0.Dispose();
			memoryMappedFile_0.Dispose();
			mutex_0.Dispose();
		}
	}
}
