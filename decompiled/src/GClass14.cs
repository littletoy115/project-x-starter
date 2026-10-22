using System;
using Newtonsoft.Json;

public sealed class GClass14
{
	private int? nullable_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private DateTime? nullable_1;

	private int int_0;

	private DateTime? nullable_2;

	private DateTime? nullable_3;

	private DateTime? nullable_4;

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

	[JsonProperty("unique_identifier")]
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

	[JsonProperty("version_login")]
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

	[JsonProperty("last_login")]
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

	[JsonProperty("login_status")]
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

	[JsonProperty("start_date")]
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

	[JsonProperty("expiry_date")]
	public DateTime? Nullable_3
	{
		get
		{
			return nullable_3;
		}
		set
		{
			nullable_3 = value;
		}
	}

	[JsonProperty("created_at")]
	public DateTime? Nullable_4
	{
		get
		{
			return nullable_4;
		}
		set
		{
			nullable_4 = value;
		}
	}
}
