using System.Collections.Generic;
using Newtonsoft.Json;

internal sealed class Class410
{
	private int int_0;

	private List<Class79> list_0;

	[JsonProperty("GridIndex")]
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

	[JsonProperty("Positions")]
	public List<Class79> List_0
	{
		get
		{
			return list_0;
		}
		set
		{
			list_0 = value;
		}
	}
}
