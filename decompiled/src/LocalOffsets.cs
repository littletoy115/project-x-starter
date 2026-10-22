using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

// Offset table that the license server used to return in its /login reply.
// It now comes from config\offsets.json next to the exe. Accepted shapes:
//   { "MemoryPointers": [ { "Key": "...", "Value": "0x..." }, ... ] }   (old server format, "Offsets" wrapper optional)
//   { "Addr_Function_PlayerHandler_Update": "0x221FA34", ... }           (flat key -> value)
internal static class LocalOffsets
{
	internal static string FilePath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config", "offsets.json");

	internal static string LastError { get; private set; }

	internal static bool Load(out string error)
	{
		GClass6 table;
		try
		{
			table = Read(FilePath);
		}
		catch (Exception ex)
		{
			table = null;
			error = FilePath + ": " + ex.Message;
			LastError = error;
			return false;
		}
		bool ok = Class357.smethod_15(table, out error);
		if (!ok)
		{
			error = FilePath + ": " + error;
		}
		LastError = error;
		return ok;
	}

	private static GClass6 Read(string path)
	{
		if (!File.Exists(path))
		{
			throw new FileNotFoundException("file not found");
		}
		JObject root = JObject.Parse(File.ReadAllText(path));
		JObject node = (root.GetValue("Offsets", StringComparison.OrdinalIgnoreCase) as JObject) ?? root;
		if (node.GetValue("MemoryPointers", StringComparison.OrdinalIgnoreCase) != null)
		{
			return node.ToObject<GClass6>();
		}
		List<GClass4> rows = new List<GClass4>();
		foreach (JProperty property in node.Properties())
		{
			if (property.Value.Type == JTokenType.String || property.Value.Type == JTokenType.Integer)
			{
				rows.Add(new GClass4
				{
					Key = property.Name,
					Value = property.Value.ToString()
				});
			}
		}
		return new GClass6
		{
			MemoryPointers = rows,
			ByteArrays = new List<GClass4>()
		};
	}
}
