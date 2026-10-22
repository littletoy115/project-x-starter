using System.Collections.Generic;
using Newtonsoft.Json;

internal sealed class Class438
{
	private string string_0;

	private string string_1;

	private long long_0;

	private long long_1;

	private long long_2;

	private string string_2;

	private string string_3;

	private IReadOnlyList<Class94> ireadOnlyList_0;

	private IReadOnlyList<Class94> ireadOnlyList_1;

	private bool bool_0;

	private long long_3;

	private string string_4;

	[JsonProperty("profileId", Order = 1)]
	public string String_0
	{
		get
		{
			return string_0;
		}
		internal set
		{
			string_0 = value;
		}
	}

	[JsonProperty("contentRevision", Order = 2)]
	public string String_1
	{
		get
		{
			return string_1;
		}
		internal set
		{
			string_1 = value;
		}
	}

	[JsonProperty("catalogReleaseId", Order = 3)]
	public long Int64_0
	{
		get
		{
			return long_0;
		}
		internal set
		{
			long_0 = value;
		}
	}

	[JsonProperty("catalogAssetId", Order = 4)]
	public long Int64_1
	{
		get
		{
			return long_1;
		}
		internal set
		{
			long_1 = value;
		}
	}

	[JsonProperty("catalogSize", Order = 5)]
	public long Int64_2
	{
		get
		{
			return long_2;
		}
		internal set
		{
			long_2 = value;
		}
	}

	[JsonProperty("catalogSha256", Order = 6)]
	public string String_2
	{
		get
		{
			return string_2;
		}
		internal set
		{
			string_2 = value;
		}
	}

	[JsonProperty("catalogJson", Order = 7)]
	public string String_3
	{
		get
		{
			return string_3;
		}
		internal set
		{
			string_3 = value;
		}
	}

	[JsonProperty("files", Order = 8)]
	public IReadOnlyList<Class94> IReadOnlyList_0
	{
		get
		{
			return ireadOnlyList_0;
		}
		internal set
		{
			ireadOnlyList_0 = value;
		}
	}

	[JsonProperty("changes", Order = 9)]
	public IReadOnlyList<Class94> IReadOnlyList_1
	{
		get
		{
			return ireadOnlyList_1;
		}
		internal set
		{
			ireadOnlyList_1 = value;
		}
	}

	[JsonProperty("hasUpdates", Order = 10)]
	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		internal set
		{
			bool_0 = value;
		}
	}

	[JsonProperty("totalDownloadBytes", Order = 11)]
	public long Int64_3
	{
		get
		{
			return long_3;
		}
		internal set
		{
			long_3 = value;
		}
	}

	[JsonProperty("releaseNotes", Order = 12)]
	public string String_4
	{
		get
		{
			return string_4;
		}
		internal set
		{
			string_4 = value;
		}
	}
}
