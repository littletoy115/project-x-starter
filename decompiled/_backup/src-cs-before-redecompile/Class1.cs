using Newtonsoft.Json;

internal sealed class Class1
{
	private int int_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private uint uint_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private long long_0;

	private long? nullable_0;

	private long? nullable_1;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private double? nullable_2;

	private string string_10;

	private int? nullable_3;

	private string string_11;

	private double? nullable_4;

	[JsonProperty("schemaVersion")]
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

	[JsonProperty("sampleId")]
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

	[JsonProperty("sessionKey")]
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

	[JsonProperty("heroName")]
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

	[JsonProperty("challengeId")]
	public uint UInt32_0
	{
		get
		{
			return uint_0;
		}
		set
		{
			uint_0 = value;
		}
	}

	[JsonProperty("gameVersionCode")]
	public int Int32_1
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
		}
	}

	[JsonProperty("challengeType")]
	public int Int32_2
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	[JsonProperty("timeoutSec")]
	public int Int32_3
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
		}
	}

	[JsonProperty("attemptsAtCapture")]
	public int Int32_4
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
		}
	}

	[JsonProperty("attemptsLeft")]
	public int Int32_5
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
		}
	}

	[JsonProperty("capturedUnixMs")]
	public long Int64_0
	{
		get
		{
			return long_0;
		}
		set
		{
			long_0 = value;
		}
	}

	[JsonProperty("submittedUnixMs")]
	public long? Nullable_0
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

	[JsonProperty("resultUnixMs")]
	public long? Nullable_1
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

	[JsonProperty("imageSha256")]
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

	[JsonProperty("submittedAnswer")]
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

	[JsonProperty("verifiedAnswer")]
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

	[JsonProperty("result")]
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

	[JsonProperty("status")]
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

	[JsonProperty("discordMessageId")]
	public string String_8
	{
		get
		{
			return string_8;
		}
		set
		{
			string_8 = value;
		}
	}

	[JsonProperty("prediction")]
	public string String_9
	{
		get
		{
			return string_9;
		}
		set
		{
			string_9 = value;
		}
	}

	[JsonProperty("predictionConfidence")]
	public double? Nullable_2
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

	[JsonProperty("predictionEngine")]
	public string String_10
	{
		get
		{
			return string_10;
		}
		set
		{
			string_10 = value;
		}
	}

	[JsonProperty("predictionLatencyMs")]
	public int? Nullable_3
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

	[JsonProperty("shadowPrediction")]
	public string String_11
	{
		get
		{
			return string_11;
		}
		set
		{
			string_11 = value;
		}
	}

	[JsonProperty("shadowConfidence")]
	public double? Nullable_4
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
