using System;
using Newtonsoft.Json;

public sealed class GClass13
{
	private bool bool_0;

	private DateTime? nullable_0;

	private GClass14 gclass14_0;

	[JsonProperty("success")]
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

	[JsonProperty("expiryDate")]
	public DateTime? Nullable_0
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

	[JsonProperty("licenseData")]
	public GClass14 GClass14_0
	{
		get
		{
			return gclass14_0;
		}
		set
		{
			gclass14_0 = value;
		}
	}
}
