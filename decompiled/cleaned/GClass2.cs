using System;
using Newtonsoft.Json;

public sealed class GClass2
{
	private int? nullable_0;

	private string string_0;

	private int int_0;

	private bool bool_0;

	private string string_1;

	private DateTime? nullable_1;

	private DateTime? nullable_2;

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

	[JsonProperty("license_key")]
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

	[JsonProperty("license_type_id")]
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

	[JsonProperty("is_used")]
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

	[JsonProperty("used_by_unique_identifier")]
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

	[JsonProperty("generated_at")]
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

	[JsonProperty("used_at")]
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
}
