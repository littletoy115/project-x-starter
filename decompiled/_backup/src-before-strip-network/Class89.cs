using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Threading;

internal static class Class89
{
	private static class Class90
	{
		public static ResolveEventHandler resolveEventHandler_0;
	}

	private static object object_0 = new object();

	private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	private static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	private static Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();

	private static int int_0;

	static Class89()
	{
		dictionary_1.Add("costura", "costura.costura.dll.compressed");
		dictionary_2.Add("costura", "costura.costura.pdb.compressed");
		dictionary_1.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
	}

	private static string smethod_0(CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			return string.Empty;
		}
		return cultureInfo_0.Name;
	}

	private static Assembly smethod_1(AssemblyName assemblyName_0)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		Assembly[] array = assemblies;
		int num = 0;
		Assembly assembly;
		while (true)
		{
			if (num < array.Length)
			{
				assembly = array[num];
				AssemblyName name = assembly.GetName();
				if (string.Equals(name.Name, assemblyName_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(smethod_0(name.CultureInfo), smethod_0(assemblyName_0.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return assembly;
	}

	private static string smethod_2(AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name))
		{
			text = (smethod_0(assemblyName_0.CultureInfo) + "." + text).ToLowerInvariant();
		}
		return text;
	}

	private static void smethod_3(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = stream_0.Read(array, 0, array.Length)) != 0)
		{
			stream_1.Write(array, 0, count);
		}
	}

	private static Stream smethod_4(string string_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (string_0.EndsWith(".compressed"))
		{
			using (Stream stream = executingAssembly.GetManifestResourceStream(string_0))
			{
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				try
				{
					MemoryStream memoryStream = new MemoryStream();
					smethod_3(deflateStream, memoryStream);
					memoryStream.Position = 0L;
					return memoryStream;
				}
				finally
				{
					((IDisposable)deflateStream).Dispose();
				}
			}
		}
		return executingAssembly.GetManifestResourceStream(string_0);
	}

	private static Stream smethod_5(Dictionary<string, string> dictionary_3, string string_0)
	{
		if (dictionary_3.TryGetValue(string_0, out var value))
		{
			return smethod_4(value);
		}
		return null;
	}

	private static byte[] smethod_6(Stream stream_0)
	{
		byte[] array = new byte[stream_0.Length];
		stream_0.Read(array, 0, array.Length);
		return array;
	}

	private static Assembly smethod_7(Dictionary<string, string> dictionary_3, Dictionary<string, string> dictionary_4, AssemblyName assemblyName_0)
	{
		string string_ = smethod_2(assemblyName_0);
		byte[] rawAssembly;
		using (Stream stream = smethod_5(dictionary_3, string_))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = smethod_6(stream);
		}
		using (Stream stream2 = smethod_5(dictionary_4, string_))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = smethod_6(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	public static Assembly smethod_8(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		string name = resolveEventArgs_0.Name;
		AssemblyName assemblyName = new AssemblyName(name);
		lock (object_0)
		{
			if (dictionary_0.ContainsKey(name))
			{
				return null;
			}
		}
		Assembly assembly = smethod_1(assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = smethod_7(dictionary_1, dictionary_2, assemblyName);
		if ((object)assembly == null)
		{
			lock (object_0)
			{
				dictionary_0[name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	public static void smethod_9(bool bool_0)
	{
		if (Interlocked.Exchange(ref int_0, 1) != 1 && bool_0)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += smethod_8;
		}
	}
}
