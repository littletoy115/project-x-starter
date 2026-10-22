using System;
using System.Collections.Generic;
using System.Globalization;

internal static class Class357
{
	internal static readonly string string_0 = "Addr_Function_PlayerHandler_Update";

	internal static readonly string string_1 = "Addr_Function_PlayerController_FrameMove";

	internal static readonly string string_2 = "Addr_Function_OnManualMovement";

	internal static readonly string string_3 = "KlassX_Build_VersionCode";

	internal static readonly string string_4 = "KlassX_Build_UnityVersion";

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
		("Addr_Function_Mesh_ctor", "rvaMeshCtor"),
		("Addr_Function_Mesh_get_vertexCount", "rvaMeshGetVertexCount"),
		("Addr_Function_MeshFilter_set_sharedMesh", "rvaMeshFilterSetMesh"),
		("Addr_Function_Renderer_set_sharedMaterial", "rvaRendererSetMaterial"),
		("Addr_Function_Renderer_set_enabled", "rvaRendererSetEnabled"),
		("Addr_Function_GameObject_ctor_string", "rvaGameObjectCtor"),
		("Addr_Function_GameObject_AddComponent", "rvaGameObjectAddComponent"),
		("Addr_Function_GameObject_get_layer", "rvaGameObjectGetLayer"),
		("Addr_Function_GameObject_set_layer", "rvaGameObjectSetLayer"),
		("Addr_Function_Component_get_transform", "rvaComponentGetTransform"),
		("Addr_Function_Transform_SetParent", "rvaTransformSetParent"),
		("Addr_Function_Transform_set_localPosition_Injected", "rvaTransformSetLocalPosInjected"),
		("Addr_Function_Transform_get_lossyScale_Injected", "rvaTransformGetLossyScaleInjected"),
		("Addr_Function_Object_Destroy", "rvaObjectDestroy"),
		("Addr_Function_Component_get_gameObject", "rvaComponentGetGameObject"),
		("Addr_Function_Mesh_set_vertices", "rvaMeshSetVertices"),
		("Addr_Function_Mesh_set_triangles", "rvaMeshSetTriangles"),
		("Addr_Function_Mesh_set_colors", "rvaMeshSetColors"),
		("Addr_Function_Shader_Find", "rvaShaderFind"),
		("Addr_Function_Material_ctor_Shader", "rvaMaterialCtor")
	};

	internal static readonly (string, string)[] valueTuple_1 = new(string, string)[4]
	{
		("Addr_Function_Camera_WorldToScreenPoint_Injected", "rvaW2sPoint"),
		("Addr_Function_Screen_get_width", "rvaScreenWidth"),
		("Addr_Function_Screen_get_height", "rvaScreenHeight"),
		("Addr_Function_Camera_get_main", "rvaCameraMain")
	};

	internal static readonly (string, string)[] valueTuple_2 = new(string, string)[4]
	{
		("Addr_Native_RenderSettings_Accessor", "rvaFogSettings"),
		("Addr_Native_RenderSettings_get_fog", "rvaFogGet"),
		("Addr_Native_RenderSettings_set_fog", "rvaFogSet"),
		("Addr_Function_Zoom_LateUpdate", "rvaZoomLateUpdate")
	};

	internal static readonly (string, string)[] valueTuple_3 = new(string, string)[3]
	{
		("Addr_Function_Zoom_Update", "rvaZoomUpdate"),
		("Addr_Function_Zoom_UpdateTargetZoom", "rvaZoomClamp"),
		("Addr_Function_Zoom_LateUpdate", "rvaZoomLateUpdate")
	};

	internal static readonly (string, string)[] valueTuple_4 = new(string, string)[7]
	{
		("Addr_TypeInfo_Vector3Array", "tiRadarVector3Array"),
		("Addr_TypeInfo_ColorArray", "tiRadarColorArray"),
		("Addr_TypeInfo_Int32Array", "tiRadarIntArray"),
		("Addr_Function_Mesh_set_vertices", "rvaMeshSetVertices"),
		("Addr_Function_Mesh_set_triangles", "rvaMeshSetTriangles"),
		("Addr_Function_Mesh_set_colors", "rvaMeshSetColors"),
		("Addr_Function_Zoom_LateUpdate", "rvaZoomLateUpdate")
	};

	internal static readonly (string, string)[] valueTuple_5 = new(string, string)[4]
	{
		("Addr_Function_ConsumableQuickSlotData_FixedUpdate", "rvaSlotAnchor"),
		("Addr_Function_ConsumableQuickSlotData_get_Container", "rvaSlotContainer"),
		("Addr_Function_InventoryObject_get_GetSlots", "rvaSlotGetSlots"),
		("Addr_Function_ConsumableQuickSlotData_UseSlot", "rvaSlotUse")
	};

	internal static readonly (string, string)[] valueTuple_6 = new(string, string)[7]
	{
		("Addr_Function_PlayerEnemyClicker_SetTarget", "rvaAtkSetTarget"),
		("Addr_Function_PlayerFollowToAttack_SetEnemy", "rvaAtkSetEnemy"),
		("Addr_Function_PlayerFollowToAttack_OnButtonPress", "rvaAtkPress"),
		("Addr_Function_PlayerFollowToAttack_CancelAttack", "rvaAtkCancel"),
		("Addr_Function_PlayerHandler_GetCrow", "rvaAtkGetCrow"),
		("Addr_Function_Component_get_gameObject", "rvaComponentGetGameObject"),
		("Addr_Function_PlayerEnemyClicker_FixedUpdate", "rvaAtkAnchor")
	};

	internal static readonly (string, string)[] valueTuple_7 = new(string, string)[4]
	{
		("Addr_Function_UserInterfaceSkill_Update", "rvaSkillBarAnchor"),
		("Addr_Function_GameCharLogic_CHECKSKILL", "rvaSkillCheck"),
		("Addr_Function_SkillData_DoCastSkill", "rvaSkillCast"),
		("Addr_Function_SkillSlot_GetSkillObject", "rvaSkillGetObject")
	};

	internal static readonly (string, string)[] valueTuple_8 = new(string, string)[2]
	{
		("Addr_Function_ServerConnectionManager_SendFieldPickupRequest", "rvaPickSend"),
		("Addr_Function_ServerConnectionManager_Update", "rvaPickAnchor")
	};

	internal static readonly (string, string)[] valueTuple_9 = new(string, string)[1] { ("Addr_Function_ServerConnectionManager_SendNpcSaleRequest", "rvaNpcSaleRequest") };

	internal static readonly (string, string)[] valueTuple_10 = new(string, string)[1] { ("Addr_Function_ServerConnectionManager_SendRecallCardRequest", "rvaRecallCardRequest") };

	internal static readonly (string, string)[] valueTuple_11 = new(string, string)[1] { ("Addr_Function_ServerConnectionManager_SendFriendMoveRequest", "rvaFriendMoveRequest") };

	internal static readonly (string, string)[] valueTuple_12 = new(string, string)[2]
	{
		("Addr_Function_Material_set_renderQueue", "rvaMaterialSetRenderQueue"),
		("Addr_Function_Material_SetInt_string_int", "rvaMaterialSetInt")
	};

	internal static readonly (string, string)[] valueTuple_13 = new(string, string)[3]
	{
		("Addr_Function_GameObject_GetComponentsInternal", "rvaGetComponentsInternal"),
		("Addr_TypeInfo_QBoxFunction", "tiQBoxFunction"),
		("Addr_TypeInfo_Image", "tiImage")
	};

	internal static readonly (string, string)[] valueTuple_14 = new(string, string)[1] { ("Addr_TypeInfo_GameDataManager", "tiGameDataManager") };

	internal static readonly (string, string)[] valueTuple_15 = new(string, string)[2]
	{
		("Addr_Function_SkillTabManager_SwitchToTab", "rvaSwitchToTab"),
		("Addr_TypeInfo_SkillTabManager", "tiSkillTabManager")
	};

	internal static readonly (string, string)[] valueTuple_16 = new(string, string)[2]
	{
		("Addr_Function_InventorySlot_GetItemObject", "rvaBagGetItemObject"),
		("Addr_TypeInfo_InstanceContainer", "tiInstanceContainer")
	};

	internal static readonly (string, string)[] valueTuple_17 = new(string, string)[6]
	{
		("Addr_Function_ServerConnectionManager_SendPetGiveFood", "rvaPetGiveFood"),
		("Addr_Function_ServerConnectionManager_SendPetSummon", "rvaPetSummon"),
		("Addr_Function_ServerConnectionManager_SendPetDismiss", "rvaPetDismiss"),
		("Addr_Function_ServerConnectionManager_HandlePetGiveFoodResponse", "rvaPetGiveFoodResponse"),
		("Addr_Function_ServerConnectionManager_HandlePetSummonResponse", "rvaPetSummonResponse"),
		("Addr_Function_ServerConnectionManager_Update", "rvaPickAnchor")
	};

	internal static readonly (string, string)[] valueTuple_18 = new(string, string)[4]
	{
		("Addr_Function_ServerConnectionManager_HandleBotChallenge", "rvaChallengeIncoming"),
		("Addr_Function_ServerConnectionManager_SendBotChallengeAnswer", "rvaChallengeSubmission"),
		("Addr_Function_ServerConnectionManager_HandleBotChallengeResult", "rvaChallengeResult"),
		("Addr_Function_ServerConnectionManager_Update", "rvaPickAnchor")
	};

	internal static readonly (string, string)[] valueTuple_19 = new(string, string)[2]
	{
		("Addr_TypeInfo_MultiSceneHelper", "tiMultiSceneHelper"),
		("Addr_Function_Behaviour_get_enabled", "rvaBehaviourGetEnabled")
	};

	internal static readonly (string, string)[] valueTuple_20 = new(string, string)[8]
	{
		("Addr_Function_PlayerModal_IsGenuinelyDead", "rvaIsGenuinelyDead"),
		("Addr_Function_ServerConnectionManager_get_LandIsTyranny", "rvaLandIsTyranny"),
		("Addr_Function_ServerConnectionManager_get_IsConfronting", "rvaIsConfronting"),
		("Addr_Function_ServerConnectionManager_get_IsInPostConfrontGrace", "rvaIsInPostConfrontGrace"),
		("Addr_Function_ServerConnectionManager_SendRebirthRequest", "rvaSendRebirth"),
		("Addr_Function_InventoryObject_HasValidRosary", "rvaHasValidRosary"),
		("Addr_Function_ServerConnectionManager_Update", "rvaPickAnchor"),
		("Addr_TypeInfo_InstanceContainer", "tiInstanceContainer")
	};

	internal static readonly (string, string)[] valueTuple_21 = new(string, string)[1] { ("Addr_TypeInfo_Client", "tiClient") };

	internal static readonly (string, string)[] valueTuple_22 = new(string, string)[2]
	{
		("Addr_TypeInfo_CharacterFriendManager", "tiCharacterFriendManager"),
		("Addr_Function_CharacterFriendManager_GetFriends", "rvaGetFriends")
	};

	internal static readonly (string, string)[] valueTuple_23 = new(string, string)[7]
	{
		("Addr_TypeInfo_PartyManager", "tiPartyManager"),
		("Addr_Function_PartyManager_get_MemberCount", "rvaPartyMemberCount"),
		("Addr_Function_PartyManager_GetMemberPlayerId", "rvaPartyMemberPlayerId"),
		("Addr_Function_PlayerHandler_GetPlayer", "rvaPlayerGetPlayer"),
		("Addr_Function_PlayerEnemyClicker_SelectRemotePlayer", "rvaSelectRemotePlayer"),
		("Addr_Function_PlayerEnemyClicker_SelectSelf", "rvaSelectSelf"),
		("Addr_Function_PlayerEnemyClicker_FixedUpdate", "rvaAtkAnchor")
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
						return smethod_21(out string_7, "duplicate row " + memoryPointer.Key);
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
		return smethod_21(out string_7, "the login response carried no memoryPointers");
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
			string_9 = string_7 + " is not in the login response";
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
			string_8 = string_7 + " has an unreadable value '" + string_9 + "'";
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
			string_9 = string_7 + " is empty";
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
		if (string_7.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
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
