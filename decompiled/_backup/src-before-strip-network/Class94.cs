using Newtonsoft.Json;

internal sealed class Class94
{
	private string string_0;

	private string string_1;

	private long long_0;

	private string string_2;

	private long long_1;

	private long long_2;

	private string string_3;

	private long? nullable_0;

	private string string_4;

	[JsonProperty("path", Order = 1)]
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

	[JsonProperty("version", Order = 2)]
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

	[JsonProperty("size", Order = 3)]
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

	[JsonProperty("sha256", Order = 4)]
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

	[JsonProperty("releaseId", Order = 5)]
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

	[JsonProperty("assetId", Order = 6)]
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

	[JsonProperty("status", Order = 7)]
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

	[JsonProperty("actualSize", Order = 8)]
	public long? Nullable_0
	{
		get
		{
			return nullable_0;
		}
		internal set
		{
			nullable_0 = value;
		}
	}

	[JsonProperty("actualSha256", Order = 9)]
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
