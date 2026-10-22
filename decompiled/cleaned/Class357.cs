using System;
using System.Collections.Generic;
using System.Globalization;

internal static class Class357
{
	internal static readonly string string_0 = Class185.smethod_0(-1141270947);

	internal static readonly string string_1 = Class185.smethod_0(-1141270988);

	internal static readonly string string_2 = Class185.smethod_0(-1141271035);

	internal static readonly string string_3 = Class185.smethod_0(-1141272104);

	internal static readonly string string_4 = Class185.smethod_0(-1141272135);

	private static bool bool_0;

	private static string string_5;

	private static int int_0;

	private static int int_1;

	private static int int_2;

	private static int int_3;

	private static string string_6;

	internal static bool bool_1 = true;

	private static readonly Dictionary<string, int> dictionary_0 = new Dictionary<string, int>(StringComparer.Ordinal);

	private static bool bool_2;

	private static bool bool_3;

	private static bool bool_4;

	private static bool bool_5;

	private static bool bool_6;

	private static bool bool_7;

	private static bool bool_8;

	private static bool bool_9;

	private static bool bool_10;

	private static bool bool_11;

	private static bool bool_12;

	private static bool bool_13;

	private static bool bool_14;

	private static bool bool_15;

	private static bool bool_16;

	private static bool bool_17;

	private static bool bool_18;

	private static bool bool_19;

	private static bool bool_20;

	private static bool bool_21;

	private static bool bool_22;

	private static bool bool_23;

	private static bool bool_24;

	private static bool bool_25;

	internal static readonly (string, string)[] valueTuple_0 = new(string, string)[20]
	{
		(Class185.smethod_0(-1141272167), Class185.smethod_0(-1141272197)),
		(Class185.smethod_0(-1141272215), Class185.smethod_0(-1141272256)),
		(Class185.smethod_0(-1141272276), Class185.smethod_0(-1141272322)),
		(Class185.smethod_0(-1141272357), Class185.smethod_0(-1141272405)),
		(Class185.smethod_0(-1141272426), Class185.smethod_0(-1141272467)),
		(Class185.smethod_0(-1141272503), Class185.smethod_0(-1141272538)),
		(Class185.smethod_0(-1141272562), Class185.smethod_0(-1141271590)),
		(Class185.smethod_0(-1141271622), Class185.smethod_0(-1141271663)),
		(Class185.smethod_0(-1141271683), Class185.smethod_0(-1141271724)),
		(Class185.smethod_0(-1141271760), Class185.smethod_0(-1141271796)),
		(Class185.smethod_0(-1141271827), Class185.smethod_0(-1141271867)),
		(Class185.smethod_0(-1141271903), Class185.smethod_0(-1141271960)),
		(Class185.smethod_0(-1141271998), Class185.smethod_0(-1141272044)),
		(Class185.smethod_0(-1141269012), Class185.smethod_0(-1141269055)),
		(Class185.smethod_0(-1141269078), Class185.smethod_0(-1141269115)),
		(Class185.smethod_0(-1141269147), Class185.smethod_0(-1141269185)),
		(Class185.smethod_0(-1141269210), Class185.smethod_0(-1141269249)),
		(Class185.smethod_0(-1141269275), Class185.smethod_0(-1141269319)),
		(Class185.smethod_0(-1141269342), Class185.smethod_0(-1141269374)),
		(Class185.smethod_0(-1141269386), Class185.smethod_0(-1141269427))
	};

	internal static readonly (string, string)[] valueTuple_1 = new(string, string)[4]
	{
		(Class185.smethod_0(-1141269449), Class185.smethod_0(-1141268488)),
		(Class185.smethod_0(-1141268498), Class185.smethod_0(-1141268543)),
		(Class185.smethod_0(-1141268556), Class185.smethod_0(-1141268594)),
		(Class185.smethod_0(-1141268624), Class185.smethod_0(-1141268652))
	};

	internal static readonly (string, string)[] valueTuple_2 = new(string, string)[4]
	{
		(Class185.smethod_0(-1141268680), Class185.smethod_0(-1141268714)),
		(Class185.smethod_0(-1141268743), Class185.smethod_0(-1141268784)),
		(Class185.smethod_0(-1141268800), Class185.smethod_0(-1141268833)),
		(Class185.smethod_0(-1141268849), Class185.smethod_0(-1141268893))
	};

	internal static readonly (string, string)[] valueTuple_3 = new(string, string)[3]
	{
		(Class185.smethod_0(-1141268917), Class185.smethod_0(-1141268949)),
		(Class185.smethod_0(-1141268961), Class185.smethod_0(-1141270027)),
		(Class185.smethod_0(-1141268849), Class185.smethod_0(-1141268893))
	};

	internal static readonly (string, string)[] valueTuple_4 = new(string, string)[7]
	{
		(Class185.smethod_0(-1141270054), Class185.smethod_0(-1141270087)),
		(Class185.smethod_0(-1141270105), Class185.smethod_0(-1141270144)),
		(Class185.smethod_0(-1141270168), Class185.smethod_0(-1141270199)),
		(Class185.smethod_0(-1141269147), Class185.smethod_0(-1141269185)),
		(Class185.smethod_0(-1141269210), Class185.smethod_0(-1141269249)),
		(Class185.smethod_0(-1141269275), Class185.smethod_0(-1141269319)),
		(Class185.smethod_0(-1141268849), Class185.smethod_0(-1141268893))
	};

	internal static readonly (string, string)[] valueTuple_5 = new(string, string)[4]
	{
		(Class185.smethod_0(-1141270221), Class185.smethod_0(-1141270277)),
		(Class185.smethod_0(-1141270289), Class185.smethod_0(-1141270347)),
		(Class185.smethod_0(-1141270370), Class185.smethod_0(-1141270419)),
		(Class185.smethod_0(-1141270441), Class185.smethod_0(-1141270501))
	};

	internal static readonly (string, string)[] valueTuple_6 = new(string, string)[7]
	{
		(Class185.smethod_0(-1141270518), Class185.smethod_0(-1141269543)),
		(Class185.smethod_0(-1141269565), Class185.smethod_0(-1141269615)),
		(Class185.smethod_0(-1141269628), Class185.smethod_0(-1141269683)),
		(Class185.smethod_0(-1141269709), Class185.smethod_0(-1141269755)),
		(Class185.smethod_0(-1141269782), Class185.smethod_0(-1141269824)),
		(Class185.smethod_0(-1141269078), Class185.smethod_0(-1141269115)),
		(Class185.smethod_0(-1141269836), Class185.smethod_0(-1141269895))
	};

	internal static readonly (string, string)[] valueTuple_7 = new(string, string)[4]
	{
		(Class185.smethod_0(-1141269906), Class185.smethod_0(-1141269960)),
		(Class185.smethod_0(-1141269984), Class185.smethod_0(-1141275149)),
		(Class185.smethod_0(-1141275161), Class185.smethod_0(-1141275203)),
		(Class185.smethod_0(-1141275230), Class185.smethod_0(-1141275267))
	};

	internal static readonly (string, string)[] valueTuple_8 = new(string, string)[2]
	{
		(Class185.smethod_0(-1141275291), Class185.smethod_0(-1141275366)),
		(Class185.smethod_0(-1141275384), Class185.smethod_0(-1141275427))
	};

	internal static readonly (string, string)[] valueTuple_9 = new(string, string)[1] { (Class185.smethod_0(-1141275455), Class185.smethod_0(-1141275518)) };

	internal static readonly (string, string)[] valueTuple_10 = new(string, string)[1] { (Class185.smethod_0(-1141275542), Class185.smethod_0(-1141275608)) };

	internal static readonly (string, string)[] valueTuple_11 = new(string, string)[1] { (Class185.smethod_0(-1141275627), Class185.smethod_0(-1141274677)) };

	internal static readonly (string, string)[] valueTuple_12 = new(string, string)[2]
	{
		(Class185.smethod_0(-1141274704), Class185.smethod_0(-1141274749)),
		(Class185.smethod_0(-1141274781), Class185.smethod_0(-1141274820))
	};

	internal static readonly (string, string)[] valueTuple_13 = new(string, string)[3]
	{
		(Class185.smethod_0(-1141274844), Class185.smethod_0(-1141274897)),
		(Class185.smethod_0(-1141274936), Class185.smethod_0(-1141274961)),
		(Class185.smethod_0(-1141274990), Class185.smethod_0(-1141275016))
	};

	internal static readonly (string, string)[] valueTuple_14 = new(string, string)[1] { (Class185.smethod_0(-1141275030), Class185.smethod_0(-1141275058)) };

	internal static readonly (string, string)[] valueTuple_15 = new(string, string)[2]
	{
		(Class185.smethod_0(-1141275082), Class185.smethod_0(-1141275130)),
		(Class185.smethod_0(-1141276183), Class185.smethod_0(-1141276211))
	};

	internal static readonly (string, string)[] valueTuple_16 = new(string, string)[2]
	{
		(Class185.smethod_0(-1141276235), Class185.smethod_0(-1141276283)),
		(Class185.smethod_0(-1141276317), Class185.smethod_0(-1141276347))
	};

	internal static readonly (string, string)[] valueTuple_17 = new(string, string)[6]
	{
		(Class185.smethod_0(-1141276381), Class185.smethod_0(-1141276433)),
		(Class185.smethod_0(-1141276462), Class185.smethod_0(-1141276520)),
		(Class185.smethod_0(-1141276531), Class185.smethod_0(-1141276598)),
		(Class185.smethod_0(-1141276610), Class185.smethod_0(-1141275664)),
		(Class185.smethod_0(-1141275693), Class185.smethod_0(-1141275753)),
		(Class185.smethod_0(-1141275384), Class185.smethod_0(-1141275427))
	};

	internal static readonly (string, string)[] valueTuple_18 = new(string, string)[4]
	{
		(Class185.smethod_0(-1141275780), Class185.smethod_0(-1141275843)),
		(Class185.smethod_0(-1141275878), Class185.smethod_0(-1141275937)),
		(Class185.smethod_0(-1141275974), Class185.smethod_0(-1141276035)),
		(Class185.smethod_0(-1141275384), Class185.smethod_0(-1141275427))
	};

	internal static readonly (string, string)[] valueTuple_19 = new(string, string)[2]
	{
		(Class185.smethod_0(-1141276060), Class185.smethod_0(-1141276097)),
		(Class185.smethod_0(-1141276122), Class185.smethod_0(-1141273092))
	};

	internal static readonly (string, string)[] valueTuple_20 = new(string, string)[8]
	{
		(Class185.smethod_0(-1141273121), Class185.smethod_0(-1141273169)),
		(Class185.smethod_0(-1141273194), Class185.smethod_0(-1141273264)),
		(Class185.smethod_0(-1141273287), Class185.smethod_0(-1141273349)),
		(Class185.smethod_0(-1141273364), Class185.smethod_0(-1141273434)),
		(Class185.smethod_0(-1141273465), Class185.smethod_0(-1141273536)),
		(Class185.smethod_0(-1141273557), Class185.smethod_0(-1141272584)),
		(Class185.smethod_0(-1141275384), Class185.smethod_0(-1141275427)),
		(Class185.smethod_0(-1141276317), Class185.smethod_0(-1141276347))
	};

	internal static readonly (string, string)[] valueTuple_21 = new(string, string)[1] { (Class185.smethod_0(-1141272608), Class185.smethod_0(-1141272627)) };

	internal static readonly (string, string)[] valueTuple_22 = new(string, string)[2]
	{
		(Class185.smethod_0(-1141272642), Class185.smethod_0(-1141272693)),
		(Class185.smethod_0(-1141272716), Class185.smethod_0(-1141272770))
	};

	internal static readonly (string, string)[] valueTuple_23 = new(string, string)[7]
	{
		(Class185.smethod_0(-1141272798), Class185.smethod_0(-1141272831)),
		(Class185.smethod_0(-1141272844), Class185.smethod_0(-1141272901)),
		(Class185.smethod_0(-1141272927), Class185.smethod_0(-1141272970)),
		(Class185.smethod_0(-1141273007), Class185.smethod_0(-1141273043)),
		(Class185.smethod_0(-1141273068), Class185.smethod_0(-1141274158)),
		(Class185.smethod_0(-1141274178), Class185.smethod_0(-1141274228)),
		(Class185.smethod_0(-1141269836), Class185.smethod_0(-1141269895))
	};

	internal static bool smethod_0()
	{
		return bool_0;
	}

	private static void smethod_1(bool bool_26)
	{
		bool_0 = bool_26;
	}

	internal static string smethod_2()
	{
		return string_5;
	}

	private static void smethod_3(string string_7)
	{
		string_5 = string_7;
	}

	internal static int smethod_4()
	{
		return int_0;
	}

	private static void smethod_5(int int_4)
	{
		int_0 = int_4;
	}

	internal static int smethod_6()
	{
		return int_1;
	}

	private static void smethod_7(int int_4)
	{
		int_1 = int_4;
	}

	internal static int smethod_8()
	{
		return int_2;
	}

	private static void smethod_9(int int_4)
	{
		int_2 = int_4;
	}

	internal static int smethod_10()
	{
		return int_3;
	}

	private static void smethod_11(int int_4)
	{
		int_3 = int_4;
	}

	internal static string smethod_12()
	{
		return string_6;
	}

	private static void smethod_13(string string_7)
	{
		string_6 = string_7;
	}

	internal static IReadOnlyDictionary<string, int> smethod_14()
	{
		return dictionary_0;
	}

	internal static bool smethod_15(GClass6 gclass6_0, out string string_7)
	{
		if (gclass6_0 != null && gclass6_0.MemoryPointers != null && gclass6_0.MemoryPointers.Count != 0)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
			foreach (GClass4 memoryPointer in gclass6_0.MemoryPointers)
			{
				if (memoryPointer != null && !string.IsNullOrEmpty(memoryPointer.Key))
				{
					if (dictionary.ContainsKey(memoryPointer.Key))
					{
						return smethod_21(out string_7, Class185.smethod_0(-1141274299) + memoryPointer.Key);
					}
					dictionary[memoryPointer.Key] = memoryPointer.Value;
				}
			}
			if (!smethod_18(dictionary, string_0, out var int_, out var string_8))
			{
				return smethod_21(out string_7, string_8);
			}
			if (!smethod_18(dictionary, string_1, out var int_2, out string_8))
			{
				return smethod_21(out string_7, string_8);
			}
			if (!smethod_18(dictionary, string_2, out var int_3, out string_8))
			{
				return smethod_21(out string_7, string_8);
			}
			if (!smethod_18(dictionary, string_3, out var int_4, out string_8))
			{
				return smethod_21(out string_7, string_8);
			}
			if (!smethod_19(dictionary, string_4, out var string_9, out string_8))
			{
				return smethod_21(out string_7, string_8);
			}
			smethod_5(int_);
			smethod_7(int_2);
			smethod_9(int_3);
			smethod_11(int_4);
			smethod_13(string_9);
			smethod_1(bool_26: true);
			smethod_3(null);
			string_7 = null;
			dictionary_0.Clear();
			if (bool_1)
			{
				smethod_70(dictionary);
			}
			else
			{
				smethod_71();
			}
			return true;
		}
		return smethod_21(out string_7, Class185.smethod_0(-1141274256));
	}

	private static bool smethod_16(Dictionary<string, string> dictionary_1, (string, string)[] valueTuple_24)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>(StringComparer.Ordinal);
		int num = 0;
		while (true)
		{
			if (num < valueTuple_24.Length)
			{
				(string, string) tuple = valueTuple_24[num];
				if (!dictionary_1.TryGetValue(tuple.Item1, out var value) || !smethod_20(value, out var int_))
				{
					break;
				}
				dictionary[tuple.Item2] = int_;
				num++;
				continue;
			}
			foreach (KeyValuePair<string, int> item in dictionary)
			{
				dictionary_0[item.Key] = item.Value;
			}
			return true;
		}
		return false;
	}

	private static bool smethod_17(Dictionary<string, string> dictionary_1, string string_7, out string string_8, out string string_9)
	{
		if (!dictionary_1.TryGetValue(string_7, out string_8))
		{
			string_9 = string_7 + Class185.smethod_0(-1141274328);
			return false;
		}
		string_9 = null;
		return true;
	}

	private static bool smethod_18(Dictionary<string, string> dictionary_1, string string_7, out int int_4, out string string_8)
	{
		int_4 = 0;
		if (!smethod_17(dictionary_1, string_7, out var string_9, out string_8))
		{
			return false;
		}
		if (!smethod_20(string_9, out int_4))
		{
			string_8 = string_7 + Class185.smethod_0(-1141274356) + string_9 + Class185.smethod_0(-1141298972);
			return false;
		}
		return true;
	}

	private static bool smethod_19(Dictionary<string, string> dictionary_1, string string_7, out string string_8, out string string_9)
	{
		string_8 = null;
		if (!smethod_17(dictionary_1, string_7, out var string_10, out string_9))
		{
			return false;
		}
		if (string.IsNullOrEmpty(string_10))
		{
			string_9 = string_7 + Class185.smethod_0(-1141274397);
			return false;
		}
		string_8 = string_10;
		return true;
	}

	private static bool smethod_20(string string_7, out int int_4)
	{
		int_4 = 0;
		if (string.IsNullOrEmpty(string_7))
		{
			return false;
		}
		if (string_7.StartsWith(Class185.smethod_0(-1141274413), StringComparison.OrdinalIgnoreCase))
		{
			return int.TryParse(string_7.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int_4);
		}
		return int.TryParse(string_7, NumberStyles.Integer, CultureInfo.InvariantCulture, out int_4);
	}

	private static bool smethod_21(out string string_7, string string_8)
	{
		smethod_1(bool_26: false);
		smethod_71();
		dictionary_0.Clear();
		smethod_3(string_8);
		string_7 = string_8;
		return false;
	}

	internal static bool smethod_22()
	{
		return bool_2;
	}

	private static void smethod_23(bool bool_26)
	{
		bool_2 = bool_26;
	}

	internal static bool smethod_24()
	{
		return bool_3;
	}

	private static void smethod_25(bool bool_26)
	{
		bool_3 = bool_26;
	}

	internal static bool smethod_26()
	{
		return bool_4;
	}

	private static void smethod_27(bool bool_26)
	{
		bool_4 = bool_26;
	}

	internal static bool smethod_28()
	{
		return bool_5;
	}

	private static void smethod_29(bool bool_26)
	{
		bool_5 = bool_26;
	}

	internal static bool smethod_30()
	{
		return bool_6;
	}

	private static void smethod_31(bool bool_26)
	{
		bool_6 = bool_26;
	}

	internal static bool smethod_32()
	{
		return bool_7;
	}

	private static void smethod_33(bool bool_26)
	{
		bool_7 = bool_26;
	}

	internal static bool smethod_34()
	{
		return bool_8;
	}

	private static void smethod_35(bool bool_26)
	{
		bool_8 = bool_26;
	}

	internal static bool smethod_36()
	{
		return bool_9;
	}

	private static void smethod_37(bool bool_26)
	{
		bool_9 = bool_26;
	}

	internal static bool smethod_38()
	{
		return bool_10;
	}

	private static void smethod_39(bool bool_26)
	{
		bool_10 = bool_26;
	}

	internal static bool smethod_40()
	{
		return bool_11;
	}

	private static void smethod_41(bool bool_26)
	{
		bool_11 = bool_26;
	}

	internal static bool smethod_42()
	{
		return bool_12;
	}

	private static void smethod_43(bool bool_26)
	{
		bool_12 = bool_26;
	}

	internal static bool smethod_44()
	{
		return bool_13;
	}

	private static void smethod_45(bool bool_26)
	{
		bool_13 = bool_26;
	}

	internal static bool smethod_46()
	{
		return bool_14;
	}

	private static void smethod_47(bool bool_26)
	{
		bool_14 = bool_26;
	}

	internal static bool smethod_48()
	{
		return bool_15;
	}

	private static void smethod_49(bool bool_26)
	{
		bool_15 = bool_26;
	}

	internal static bool smethod_50()
	{
		return bool_16;
	}

	private static void smethod_51(bool bool_26)
	{
		bool_16 = bool_26;
	}

	internal static bool smethod_52()
	{
		return bool_17;
	}

	private static void smethod_53(bool bool_26)
	{
		bool_17 = bool_26;
	}

	internal static bool smethod_54()
	{
		return bool_18;
	}

	private static void smethod_55(bool bool_26)
	{
		bool_18 = bool_26;
	}

	internal static bool smethod_56()
	{
		return bool_19;
	}

	private static void smethod_57(bool bool_26)
	{
		bool_19 = bool_26;
	}

	internal static bool smethod_58()
	{
		return bool_20;
	}

	private static void smethod_59(bool bool_26)
	{
		bool_20 = bool_26;
	}

	internal static bool smethod_60()
	{
		return bool_21;
	}

	private static void smethod_61(bool bool_26)
	{
		bool_21 = bool_26;
	}

	internal static bool smethod_62()
	{
		return bool_22;
	}

	private static void smethod_63(bool bool_26)
	{
		bool_22 = bool_26;
	}

	internal static bool smethod_64()
	{
		return bool_23;
	}

	private static void smethod_65(bool bool_26)
	{
		bool_23 = bool_26;
	}

	internal static bool smethod_66()
	{
		return bool_24;
	}

	private static void smethod_67(bool bool_26)
	{
		bool_24 = bool_26;
	}

	internal static bool smethod_68()
	{
		return bool_25;
	}

	private static void smethod_69(bool bool_26)
	{
		bool_25 = bool_26;
	}

	private static void smethod_70(Dictionary<string, string> dictionary_1)
	{
		smethod_23(smethod_16(dictionary_1, valueTuple_0));
		smethod_25(smethod_16(dictionary_1, valueTuple_1));
		smethod_27(smethod_16(dictionary_1, valueTuple_2));
		smethod_29(smethod_16(dictionary_1, valueTuple_3));
		smethod_31(smethod_22() && smethod_16(dictionary_1, valueTuple_4));
		smethod_33(smethod_16(dictionary_1, valueTuple_5));
		smethod_35(smethod_16(dictionary_1, valueTuple_6));
		smethod_37(smethod_16(dictionary_1, valueTuple_7));
		smethod_39(smethod_16(dictionary_1, valueTuple_8));
		smethod_41(smethod_16(dictionary_1, valueTuple_9));
		smethod_43(smethod_16(dictionary_1, valueTuple_10));
		smethod_45(smethod_16(dictionary_1, valueTuple_11));
		smethod_47(smethod_16(dictionary_1, valueTuple_12));
		smethod_49(smethod_16(dictionary_1, valueTuple_13));
		smethod_51(smethod_16(dictionary_1, valueTuple_14));
		smethod_53(smethod_16(dictionary_1, valueTuple_15));
		smethod_55(smethod_16(dictionary_1, valueTuple_16));
		smethod_57(smethod_16(dictionary_1, valueTuple_17));
		smethod_59(smethod_16(dictionary_1, valueTuple_18));
		smethod_61(smethod_16(dictionary_1, valueTuple_19));
		smethod_63(smethod_16(dictionary_1, valueTuple_20));
		smethod_65(smethod_16(dictionary_1, valueTuple_21));
		smethod_67(smethod_16(dictionary_1, valueTuple_22));
		smethod_69(smethod_16(dictionary_1, valueTuple_23));
	}

	private static void smethod_71()
	{
		smethod_23(bool_26: false);
		smethod_25(bool_26: false);
		smethod_27(bool_26: false);
		smethod_29(bool_26: false);
		smethod_31(bool_26: false);
		smethod_33(bool_26: false);
		smethod_35(bool_26: false);
		smethod_37(bool_26: false);
		smethod_39(bool_26: false);
		smethod_41(bool_26: false);
		smethod_43(bool_26: false);
		smethod_45(bool_26: false);
		smethod_47(bool_26: false);
		smethod_49(bool_26: false);
		smethod_51(bool_26: false);
		smethod_53(bool_26: false);
		smethod_55(bool_26: false);
		smethod_57(bool_26: false);
		smethod_59(bool_26: false);
		smethod_61(bool_26: false);
		smethod_63(bool_26: false);
		smethod_65(bool_26: false);
		smethod_67(bool_26: false);
		smethod_69(bool_26: false);
	}
}
