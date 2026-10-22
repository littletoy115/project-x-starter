using System;
using Newtonsoft.Json;

public sealed class GClass10 : JsonConverter
{
	public override bool CanConvert(Type type_0)
	{
		return type_0 == typeof(TimeSpan?);
	}

	public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)jsonReader_0.TokenType == 7)
		{
			return TimeSpan.FromMilliseconds((long)jsonReader_0.Value);
		}
		return null;
	}

	public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
	{
		if (object_0 is TimeSpan timeSpan)
		{
			jsonWriter_0.WriteValue(timeSpan.TotalMilliseconds);
		}
	}
}
