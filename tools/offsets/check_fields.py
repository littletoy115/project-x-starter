"""Check the field offsets hardcoded in Class431.cs (sent to runtime.js as `off.*`) against the current il2cpp dump.

Usage: python tools/offsets/check_fields.py
Prints, for every key, the field that sits at that offset in the class the key belongs to, so a moved field
(the game added/removed a field and the exe was built for an older version) stands out.
"""
import re
import sys
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]
DUMP = ROOT / "game/il2cpp-dump/dump.cs"
CLASS431 = ROOT / "decompiled/src/Class431.cs"

# key prefix -> class in dump.cs (longest prefix wins). Keys not listed are constants/strides, not fields.
PREFIX = {
    "ph": "PlayerHandler", "pc": "PlayerController", "ga": "GameActor", "cl": ["GameCharLogic", "GameCharData"],
    "crowId": "UnitCrow", "crowDataId": "UnitCrow", "crowController": "UnitCrow", "crowNowHp": "GameCrowLogic",
    "ai": "EnemyAiController", "def": "MobNpcObject", "mob": "MobNpc", "unit": "Unit", "cc": "PlayerControllerClient",
    "target": "TargetInfoEx", "sdHp": "SDROP_CHAR", "sdLevel": "SDROP_CHAR", "sdName": "SDROP_CHAR",
    "itemData": "GroundItem", "itemItem": "GroundItem", "itemObj": "ItemObject", "gold": "GroundGold",
    "zoom": "Zoom", "cam": "CinemachineFreeLook", "slot": "InventorySlot", "ec": "PlayerEnemyClicker",
    "ic": "InstanceContainer", "swo": "SkillWindowObject", "ss": "SkillSlot", "uis": "UserInterfaceSkill",
    "client": "Client", "msh": "MultiSceneHelper", "loader": "LoaderScene", "qb": "QBoxFunction", "img": "Image",
    "gdm": "GameDataManager", "cs": "CharacterSelectDataSO", "scm": "ServerConnectionManager", "io": "InventoryObject",
    "inv": "Inventory", "fm": "CharacterFriendManager", "bcr": "F2C_BotChallengeResult", "bc": "F2C_BotChallenge",
    "petFood": "F2C_PetGiveFoodResponse", "petSummon": "F2C_PetSummonResponse",
}
SKIP = re.compile(r"^(arr|str|stride|list|sf[A-Z]|sfStride|klass|obj|qf|sitem|drop|money|item(Main|Sub|Question)|sk[A-Z]|sb|sw[A-Z]|sd(ToMove)|fce|party|unitSelf|eye|cam(Delta|Was)|slotMax|crow(Mob|IdMax|Item|Money))")


def parse_dump():
    classes = {}
    cur = None
    head = re.compile(r"^(?:\[.*\]\s*)?(?:\w+ )*(?:class|struct) ([\w.`<>,]+)")
    fld = re.compile(r"^\t(?:\[.*\] )?((?:\w+ )*)(.+?) (\S+); // 0x([0-9A-F]+)$")
    with open(DUMP, encoding="utf-8", errors="replace") as f:
        for line in f:
            line = line.rstrip("\n")
            m = head.match(line)
            if m and not line.startswith("\t"):
                cur = {}
                classes.setdefault(m.group(1).split(".")[-1], []).append(cur)
                continue
            if cur is not None:
                fm = fld.match(line)
                if fm and "const" not in fm.group(1).split():
                    static = "static" in fm.group(1).split()
                    cur.setdefault((static, int(fm.group(4), 16)), []).append(f"{fm.group(2)} {fm.group(3)}")
    return classes


def main():
    text = CLASS431.read_text(encoding="utf-8-sig")
    keys = re.findall(r'smethod_1\(stringBuilder_0, "(\w+)", (\d+)\)', text)
    classes = parse_dump()
    for key, val in keys:
        off = int(val)
        if SKIP.match(key):
            continue
        prefix = max((p for p in PREFIX if key.startswith(p)), key=len, default=None)
        if prefix is None:
            print(f"{key:<22} 0x{off:<5X} ? (no class mapping)")
            continue
        names = PREFIX[prefix] if isinstance(PREFIX[prefix], list) else [PREFIX[prefix]]
        cname = "/".join(names)
        static = key.startswith("sf") or key.endswith("Instance")
        found = []
        for n in names:
            for c in classes.get(n, []):
                found += c.get((static, off), [])
        print(f"{key:<22} 0x{off:<5X} {cname}: {' | '.join(found) or '-- NOTHING AT THIS OFFSET --'}")


if __name__ == "__main__":
    main()
