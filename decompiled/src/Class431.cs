using System.Collections.Generic;
using System.Globalization;
using System.Text;

internal static class Class431
{
	internal static bool bool_0;

	internal static string smethod_0()
	{
		if (!Class357.smethod_0())
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder("{\"cmd\":\"offsets\",\"trace\":");
		stringBuilder.Append(bool_0 ? "true" : "false").Append(",\"off\":{");
		smethod_3(stringBuilder);
		if (stringBuilder[stringBuilder.Length - 1] == ',')
		{
			stringBuilder.Length--;
		}
		stringBuilder.Append("}}");
		return stringBuilder.ToString();
	}

	private static void smethod_1(StringBuilder stringBuilder_0, string string_0, int int_0)
	{
		stringBuilder_0.Append('"').Append(string_0).Append("\":")
			.Append(int_0.ToString(CultureInfo.InvariantCulture))
			.Append(',');
	}

	private static void smethod_2(StringBuilder stringBuilder_0, string string_0, string string_1)
	{
		stringBuilder_0.Append('"').Append(string_0).Append("\":\"")
			.Append((string_1 ?? string.Empty).Replace("\\", "\\\\").Replace("\"", "\\\""))
			.Append("\",");
	}

	private static void smethod_3(StringBuilder stringBuilder_0)
	{
		smethod_2(stringBuilder_0, "module", "libil2cpp.so");
		smethod_2(stringBuilder_0, "unityVersion", Class357.smethod_12());
		smethod_1(stringBuilder_0, "versionCode", Class357.smethod_10());
		smethod_1(stringBuilder_0, "rvaHandlerUpdate", Class357.smethod_4());
		smethod_1(stringBuilder_0, "rvaFrameMove", Class357.smethod_6());
		smethod_1(stringBuilder_0, "rvaOnManualMovement", Class357.smethod_8());
		smethod_1(stringBuilder_0, "arrCount", 24);
		smethod_1(stringBuilder_0, "arrFirst", 32);
		smethod_1(stringBuilder_0, "arrStride", 8);
		smethod_1(stringBuilder_0, "strLen", 16);
		smethod_1(stringBuilder_0, "strChars", 20);
		smethod_1(stringBuilder_0, "phPlayers", 40);
		smethod_1(stringBuilder_0, "phCrows", 64);
		smethod_1(stringBuilder_0, "phItems", 80);
		smethod_1(stringBuilder_0, "phMoney", 96);
		smethod_1(stringBuilder_0, "pcCharLogic", 56);
		smethod_1(stringBuilder_0, "pcActorMove", 80);
		smethod_1(stringBuilder_0, "pcTarget", 184);
		smethod_1(stringBuilder_0, "pcManualTarget", 104);
		smethod_1(stringBuilder_0, "pcManualActive", 116);
		smethod_1(stringBuilder_0, "pcAction", 120);
		smethod_1(stringBuilder_0, "pcActState", 124);
		smethod_1(stringBuilder_0, "pcJoystick", 329);
		smethod_1(stringBuilder_0, "gaPosition", 16);
		smethod_1(stringBuilder_0, "gaVelocity", 28);
		smethod_1(stringBuilder_0, "gaMaxSpeed", 60);
		smethod_1(stringBuilder_0, "gaCorner", 96);
		smethod_1(stringBuilder_0, "gaPathActive", 100);
		smethod_1(stringBuilder_0, "gaHasDirect", 116);
		smethod_1(stringBuilder_0, "gaDirectTarget", 120);
		smethod_1(stringBuilder_0, "clSkillFact", 664);
		smethod_1(stringBuilder_0, "clSystemBuff", 672);
		smethod_1(stringBuilder_0, "clQItemFact", 844);
		smethod_1(stringBuilder_0, "qfTime", 4);
		smethod_1(stringBuilder_0, "clHp", 280);
		smethod_1(stringBuilder_0, "clMp", 284);
		smethod_1(stringBuilder_0, "clSp", 288);
		smethod_1(stringBuilder_0, "clCombat", 292);
		smethod_1(stringBuilder_0, "clLevel", 132);
		smethod_1(stringBuilder_0, "clMoney", 136);
		smethod_1(stringBuilder_0, "crowId", 32);
		smethod_1(stringBuilder_0, "crowDataId", 38);
		smethod_1(stringBuilder_0, "crowController", 56);
		smethod_1(stringBuilder_0, "aiCrowLogic", 40);
		smethod_1(stringBuilder_0, "aiActor", 48);
		smethod_1(stringBuilder_0, "aiIsDead", 120);
		smethod_1(stringBuilder_0, "aiMobNpc", 136);
		smethod_1(stringBuilder_0, "crowNowHp", 208);
		smethod_1(stringBuilder_0, "defName", 32);
		smethod_1(stringBuilder_0, "defBoss", 63);
		smethod_1(stringBuilder_0, "defType", 49);
		smethod_1(stringBuilder_0, "defData", 24);
		smethod_1(stringBuilder_0, "defHp", 72);
		smethod_1(stringBuilder_0, "defLevel", 92);
		smethod_1(stringBuilder_0, "mobMain", 16);
		smethod_1(stringBuilder_0, "mobSub", 18);
		smethod_1(stringBuilder_0, "unitGaeaId", 40);
		smethod_1(stringBuilder_0, "unitClient", 128);
		smethod_1(stringBuilder_0, "unitIsSelf", 76);
		smethod_1(stringBuilder_0, "unitParty", 184);
		smethod_1(stringBuilder_0, "unitSchool", 56);
		smethod_1(stringBuilder_0, "unitClass", 58);
		smethod_1(stringBuilder_0, "unitMaster", 188);
		smethod_1(stringBuilder_0, "unitName", 48);
		smethod_1(stringBuilder_0, "ccActor", 80);
		smethod_1(stringBuilder_0, "ccTarget", 48);
		smethod_1(stringBuilder_0, "ccCharData", 144);
		smethod_1(stringBuilder_0, "ccSkillFacts", 216);
		smethod_1(stringBuilder_0, "targetCrowType", 0);
		smethod_1(stringBuilder_0, "targetId", 2);
		smethod_1(stringBuilder_0, "sdHp", 102);
		smethod_1(stringBuilder_0, "sdLevel", 52);
		smethod_1(stringBuilder_0, "sdName", 16);
		smethod_1(stringBuilder_0, "itemData", 40);
		smethod_1(stringBuilder_0, "itemItem", 48);
		smethod_1(stringBuilder_0, "dropPos", 36);
		smethod_1(stringBuilder_0, "dropId", 16);
		smethod_1(stringBuilder_0, "dropInfo", 24);
		smethod_1(stringBuilder_0, "sitemNativeId", 16);
		smethod_1(stringBuilder_0, "sitemTurn", 30);
		smethod_1(stringBuilder_0, "itemObjName", 32);
		smethod_1(stringBuilder_0, "itemObjType", 56);
		smethod_1(stringBuilder_0, "itemObjQuestion", 344);
		smethod_1(stringBuilder_0, "itemQuestionType", 16);
		smethod_1(stringBuilder_0, "goldData", 40);
		smethod_1(stringBuilder_0, "moneyPos", 36);
		smethod_1(stringBuilder_0, "moneyId", 16);
		smethod_1(stringBuilder_0, "moneyAmount", 24);
		smethod_1(stringBuilder_0, "sfStride", 56);
		smethod_1(stringBuilder_0, "sfAge", 40);
		smethod_1(stringBuilder_0, "sfLevel", 44);
		smethod_1(stringBuilder_0, "sfNativeId", 46);
		foreach (KeyValuePair<string, int> item in Class357.smethod_14())
		{
			smethod_1(stringBuilder_0, item.Key, item.Value);
		}
		if (Class357.smethod_22() || Class357.smethod_24() || Class357.smethod_48() || Class357.smethod_30() || Class357.smethod_26() || Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, "objCachedPtr", 16);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, "zoomCineCam", 32);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, "zoomHeights", 136);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, "zoomRadii", 144);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, "camBindingMode", 564);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, "camHeading", 520);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, "camRecenterTilt", 376);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, "camRecenterHeading", 532);
		}
		if (Class357.smethod_32() || Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, "slotItem", 112);
		}
		if (Class357.smethod_32() || Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, "slotAmount", 120);
		}
		if (Class357.smethod_34())
		{
			smethod_1(stringBuilder_0, "ecPfta", 136);
		}
		if (Class357.smethod_68())
		{
			smethod_1(stringBuilder_0, "partyInstance", 0);
		}
		if (Class357.smethod_68())
		{
			smethod_1(stringBuilder_0, "unitSelf", 88);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, "icSkillHotkey", 136);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, "swoContainer", 48);
		}
		if (Class357.smethod_36() || Class357.smethod_52())
		{
			smethod_1(stringBuilder_0, "swoTabIndex", 44);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, "swSlots", 16);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, "ssSkill", 72);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, "ssSkillData", 48);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, "skMainId", 16);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, "skSubId", 18);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, "sbName", 32);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, "pcSkillData", 360);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, "uisSkillWindow", 32);
		}
		if (Class357.smethod_48() || Class357.smethod_50() || Class357.smethod_52() || Class357.smethod_54() || Class357.smethod_66() || Class357.smethod_60() || Class357.smethod_62() || Class357.smethod_64() || Class357.smethod_68())
		{
			smethod_1(stringBuilder_0, "klassStaticFields", 184);
		}
		if (Class357.smethod_64())
		{
			smethod_1(stringBuilder_0, "sfClientInstance", 0);
		}
		if (Class357.smethod_64())
		{
			smethod_1(stringBuilder_0, "clientUserId", 64);
		}
		if (Class357.smethod_60())
		{
			smethod_1(stringBuilder_0, "mshInstance", 0);
		}
		if (Class357.smethod_60())
		{
			smethod_1(stringBuilder_0, "mshLoader", 32);
		}
		if (Class357.smethod_60())
		{
			smethod_1(stringBuilder_0, "mshFirstLoader", 40);
		}
		if (Class357.smethod_60())
		{
			smethod_1(stringBuilder_0, "loaderCanvas", 32);
		}
		if (Class357.smethod_48())
		{
			smethod_1(stringBuilder_0, "sfQBoxInstance", 0);
		}
		if (Class357.smethod_48())
		{
			smethod_1(stringBuilder_0, "qbIndicator", 120);
		}
		if (Class357.smethod_48())
		{
			smethod_1(stringBuilder_0, "imgFillAmount", 244);
		}
		if (Class357.smethod_50())
		{
			smethod_1(stringBuilder_0, "sfGdmInstance", 0);
		}
		if (Class357.smethod_50())
		{
			smethod_1(stringBuilder_0, "gdmCharSelect", 64);
		}
		if (Class357.smethod_50())
		{
			smethod_1(stringBuilder_0, "csId", 24);
		}
		if (Class357.smethod_52())
		{
			smethod_1(stringBuilder_0, "sfSkillTabInstance", 0);
		}
		if (Class357.smethod_52())
		{
			smethod_1(stringBuilder_0, "pcCastPending", 332);
		}
		if (Class357.smethod_52())
		{
			smethod_1(stringBuilder_0, "sdToMove", 48);
		}
		if (Class357.smethod_54() || Class357.smethod_62())
		{
			smethod_1(stringBuilder_0, "icInstance", 0);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, "icInventory", 40);
		}
		if (Class357.smethod_54() || Class357.smethod_62())
		{
			smethod_1(stringBuilder_0, "icEquipment", 48);
		}
		if (Class357.smethod_62() || Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, "scmZoneConnection", 48);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, "ioContainer", 40);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, "invSlots", 16);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, "slotItemPos", 24);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, "slotIndex", 104);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, "itemMainId", 16);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, "itemSubId", 20);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, "itemObjWearPos", 57);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, "itemObjMaxPile", 282);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, "phInvenLine", 406);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, "scmPetFullness", 570);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, "phActivePetCardSlot", 404);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, "phPetGlobalId", 400);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, "phPetObject", 392);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, "petFoodResult", 16);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, "petFoodNewFullness", 18);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, "petFoodConsumedSlot", 20);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, "petSummonResult", 16);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, "petSummonGlobalId", 20);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, "petSummonCardSlot", 32);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, "bcChallengeId", 16);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, "bcChallengeType", 20);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, "bcTimeoutSec", 21);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, "bcAttemptsLeft", 22);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, "bcImageLen", 24);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, "bcImage", 32);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, "bcrChallengeId", 16);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, "bcrResult", 20);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, "bcrAttemptsLeft", 21);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "sfFriendMgrInstance", 0);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "fmFriends", 152);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "fmListLoaded", 176);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "fceName", 8);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "fceId", 0);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "fceFlag", 16);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "fceOnline", 17);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "fceKnown", 24);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "fceChannel", 18);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "fceLevel", 20);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "fceClass", 22);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "fceSchool", 23);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "fceStride", 32);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "listItems", 16);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, "listSize", 24);
		}
		if (Class357.smethod_22())
		{
			smethod_1(stringBuilder_0, "strideV3", 12);
			smethod_1(stringBuilder_0, "strideColor", 16);
			smethod_1(stringBuilder_0, "strideInt", 4);
		}
		if (Class357.smethod_24())
		{
			smethod_1(stringBuilder_0, "eyeMono", 2);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, "camDeltaHeight0", 24);
			smethod_1(stringBuilder_0, "camDeltaRadius0", 84);
			smethod_1(stringBuilder_0, "camDeltaRadius1", 176);
			smethod_1(stringBuilder_0, "camDeltaRadius2", 240);
			smethod_1(stringBuilder_0, "camWasHeight0", 150);
			smethod_1(stringBuilder_0, "camWasRadius0", 110);
			smethod_1(stringBuilder_0, "camWasRadius1", 150);
			smethod_1(stringBuilder_0, "camWasRadius2", 150);
		}
		if (Class357.smethod_32())
		{
			smethod_1(stringBuilder_0, "slotMax", 6);
		}
		if (Class357.smethod_34())
		{
			smethod_1(stringBuilder_0, "crowMob", 2);
			smethod_1(stringBuilder_0, "crowIdMax", 2999);
		}
		if (Class357.smethod_38())
		{
			smethod_1(stringBuilder_0, "crowItem", 3);
			smethod_1(stringBuilder_0, "crowMoney", 4);
		}
	}
}
