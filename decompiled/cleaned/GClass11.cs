using System;
using Newtonsoft.Json;

public sealed class GClass11
{
	private int? nullable_0;

	private string string_0;

	private int int_0;

	private bool bool_0;

	private DateTime? nullable_1;

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

	[JsonProperty("name")]
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

	[JsonProperty("duration_days")]
	public int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	[JsonProperty("is_active")]
	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
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
}
