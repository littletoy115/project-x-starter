using Newtonsoft.Json;

internal sealed class Class79
{
	private float float_0;

	private float float_1;

	private float? nullable_0;

	[JsonProperty("X")]
	public float Single_0
	{
		get
		{
			return float_0;
		}
		set
		{
			float_0 = value;
		}
	}

	[JsonProperty("Y")]
	public float Single_1
	{
		get
		{
			return float_1;
		}
		set
		{
			float_1 = value;
		}
	}

	[JsonProperty("Z")]
	public float? Nullable_0
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
}
