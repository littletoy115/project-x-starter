using System;
using Newtonsoft.Json;

public sealed class GClass5
{
	private int? nullable_0;

	private string string_0;

	private string string_1;

	private DateTime? nullable_1;

	private DateTime? nullable_2;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	[JsonProperty("id")]
	public int? Nullable_0
	{
		get
		{
			return nullable_0;
		}
		set
		{
			nullable_0 = value;
		}
	}

	[JsonProperty("version")]
	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	[JsonProperty("download_url")]
	public string String_1
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	[JsonProperty("created_at")]
	public DateTime? Nullable_1
	{
		get
		{
			return nullable_1;
		}
		set
		{
			nullable_1 = value;
		}
	}

	[JsonProperty("updated_at")]
	public DateTime? Nullable_2
	{
		get
		{
			return nullable_2;
		}
		set
		{
			nullable_2 = value;
		}
	}

	[JsonProperty("created_by")]
	public string String_2
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	[JsonProperty("release_tag")]
	public string String_3
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
		}
	}

	[JsonProperty("release_title")]
	public string String_4
	{
		get
		{
			return string_4;
		}
		set
		{
			string_4 = value;
		}
	}

	[JsonProperty("release_notes")]
	public string String_5
	{
		get
		{
			return string_5;
		}
		set
		{
			string_5 = value;
		}
	}

	[JsonProperty("release_published_at")]
	public string String_6
	{
		get
		{
			return string_6;
		}
		set
		{
			string_6 = value;
		}
	}

	[JsonProperty("release_url")]
	public string String_7
	{
		get
		{
			return string_7;
		}
		set
		{
			string_7 = value;
		}
	}
}
