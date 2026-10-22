using System;
using System.Collections.Generic;
using Newtonsoft.Json;

internal sealed class Class404
{
	private string string_0;

	private DateTime dateTime_0;

	private List<Class88> list_0;

	private List<Dictionary<string, string>> list_1;

	[JsonProperty("grid")]
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

	[JsonProperty("savedUtc")]
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

	[JsonProperty("columns")]
	public List<Class88> List_0
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

	[JsonProperty("rows")]
	public List<Dictionary<string, string>> List_1
	{
		get
		{
			return list_1;
		}
		set
		{
			list_1 = value;
		}
	}
}
