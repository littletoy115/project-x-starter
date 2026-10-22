using System;
using System.Collections.Generic;
using Newtonsoft.Json;

internal sealed class Class84
{
	private DateTime dateTime_0;

	private List<Class410> list_0;

	[JsonProperty("SaveDate")]
	public DateTime DateTime_0
	{
		get
		{
			return dateTime_0;
		}
		set
		{
			dateTime_0 = value;
		}
	}

	[JsonProperty("GridData")]
	public List<Class410> List_0
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
