# Offset mapping (KEYS_CORE → Klass X Online)

Source: `game/il2cpp-dump/dump.cs` (metadata v39, dumped 2026-10-22). Find a class with `python tools/cls.py <Class> [--grep regex]`.
Verified live with `test/probe.js` (HP of the player and mobs/bosses read correctly).

## Environment
- The game runs **arm64** `libil2cpp.so` under houdini (`libnb.so`) on LDPlayer x86_64.
  Plain frida-server (x64) **cannot hook** game code and does not list libil2cpp as a module, but it can read memory.
  The bot uses `klxsvc`, which injects `frida-agent-arm64.so` through NativeBridge.
- Without hooks, objects are reached through `<Class>_TypeInfo` (script.json) → `Il2CppClass+0xB8` static_fields → `Instance`.

## Hooks / TypeInfo (RVA)
| key | game | RVA |
|---|---|---|
| rvaHandlerUpdate | PlayerHandler.Update | 0x221FA34 |
| rvaFrameMove | PlayerController.FrameMove | 0x23DEE2C |
| rvaOnManualMovement | PlayerController.OnManualMovement | 0x23E2794 |
| — | PlayerHandler_TypeInfo | 0x4DF3510 |
| — | PlayerController_TypeInfo | 0x4DF34C0 |

## Fields
| key | game field | off | type |
|---|---|---|---|
| arrCount / arrFirst / arrStride | Il2CppArray | 0x18 / 0x20 / 8 | |
| strLen / strChars | Il2CppString | 0x10 / 0x14 | |
| klassStaticFields | Il2CppClass.static_fields | 0xB8 | |
| phPlayers | PlayerHandler.playerClientArray | 0x28 | Unit[] |
| phCrows | PlayerHandler.crowsArray | 0x40 | UnitCrow[] |
| phItems | PlayerHandler.itemsDropArray | 0x50 | GroundItem[] |
| phMoney | PlayerHandler.moneyDropArray | 0x60 | GroundGold[] |
| pcCharLogic | PlayerController.CharLogic | 0x38 | CGameCharLogic |
| pcActorMove | PlayerController.actorMove | 0x50 | GameActor |
| pcManualTarget | PlayerController._manualMoveTarget | 0x68 | Vector3 |
| pcManualActive | PlayerController._manualMoveActive | 0x74 | bool |
| pcAction | PlayerController.actionEnum | 0x78 | u8 |
| pcActState | PlayerController.dwActState | 0x7C | u32 |
| pcTarget | PlayerController.TargetInfo | 0xB8 | TargetInfoEx |
| pcJoystick | PlayerController.IsJoyStick | 0x149 | bool |
| targetCrowType / targetId | TargetInfoEx.CrowType / Id | 0x0 / 0x2 | u8 / u16 |
| gaPosition / gaVelocity | GameActor.PositionLocal / VelocityLocal | 0x10 / 0x1C | Vector3 |
| gaMaxSpeed | GameActor.MaxSpeed | 0x3C | float |
| gaCorner / gaPathActive | GameActor._cornerIndex / _pathActive | 0x60 / 0x64 | |
| gaHasDirect / gaDirectTarget | GameActor._hasDirectTarget / _directTargetLocal | 0x74 / 0x78 | |
| clLevel | GameCharData.wLevel | 0x84 | u16 |
| clMoney | GameCharData.lMoney | 0x88 | s64 |
| **clHp** | GameCharData.sHP | **0x118** | PAData (u16 now, u16 max) |
| clMp / clSp / clCombat | sMP / sSP / sCombatPoint | 0x11C / 0x120 / 0x124 | PAData |
| clSkillFact / clSystemBuff | GameCharLogic.sSKILLFACT / sSYSTEMBUFF | 0x298 / 0x2A0 | SkillFact[] |
| clQItemFact | GameCharLogic.sQITEMFACT | 0x34C | |
| crowId | UnitCrow.crowID | 0x20 | |
| crowDataId | UnitCrow.crowDataId | 0x26 | SNativeID |
| crowController | UnitCrow.enemyController | 0x38 | EnemyAiController |
| aiCrowLogic / aiActor | EnemyAiController.CrowLogic / Actor | 0x28 / 0x30 | |
| aiIsDead | EnemyAiController.isDead | 0x78 | bool |
| aiMobNpc | EnemyAiController.mobNpcObject | 0x88 | MobNpcObject |
| **crowNowHp** | GameCrowLogic.dwNowHP | **0xD0** | u32 |
| defData | MobNpcObject.data | 0x18 | MobNpc (mainId 0x10, subId 0x12) |
| defName | MobNpcObject.Name | 0x20 | string |
| defType | MobNpcObject.crowType | 0x31 | u8 |
| **defBoss** | MobNpcObject.bossMob | **0x3F** | bool |
| **defHp** | MobNpcObject.hp | **0x48** | u32 (max) |
| defLevel | MobNpcObject.level | 0x5C | byte |
| unitGaeaId / unitName | Unit.gaeaId / charName | 0x28 / 0x30 | |
| unitIsSelf | Unit.isPlayersUnit | 0x4C | bool |
| unitSchool / unitClass | Unit.school / charClass | 0x38 / 0x3A | |
| unitClient | Unit.controllerClient | 0x80 | PlayerControllerClient |
| unitParty / unitMaster | Unit.PartyId / IsPartyMaster | 0xB8 / 0xBC | |
| ccTarget / ccActor / ccCharData | PlayerControllerClient.TargetID / Actor / CharData | 0x30 / 0x50 / 0x90 | |
| sdLevel / sdHp | SDROP_CHAR.wLevel / sHP | 0x34 / 0x66 | |

Not mapped yet: item and money fields (itemData, dropPos, goldData, …), ccSkillFacts, sf*, and the other KEYS_* groups.

## Player HP vs boss HP
- **Player** (own character and other players): `PAData` = two **u16** values (current, max) stored side by side in the character data. Own character: `PlayerController.Instance → CharLogic + 0x118`. Other players: `SDROP_CHAR + 0x66`.
- **Mob/boss**: split across two objects. Current HP is **u32** `GameCrowLogic.dwNowHP` (+0xD0) and changes during combat. Max HP is **u32** `MobNpcObject.hp` (+0x48), a fixed value from the mob definition. A boss is distinguished only by the `bossMob` flag (+0x3F) in the same definition; it does not have a separate HP structure.
- NPCs are also in crowsArray (dwNowHP = 0); filter them out with `crowType` (+0x31).
