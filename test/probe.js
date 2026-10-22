// Read-only HP probe for Klass X Online (no hooks: the game's arm64 code runs under houdini,
// which plain x86_64 frida-server cannot intercept, but the memory itself is readable).
// Run: frida -U -n "KlassX Online" -l test/probe.js
// Offsets come from game/il2cpp-dump/dump.cs (metadata v39), see decompiled/OFFSETS.md.

const RVA = {
  PlayerHandler_TypeInfo: 0x4DF3510,
  PlayerController_TypeInfo: 0x4DF34C0,
};
const KLASS_NAME = 0x10;         // Il2CppClass.name
const KLASS_STATIC_FIELDS = 0xB8; // Il2CppClass.static_fields
const ARR_COUNT = 0x18, ARR_FIRST = 0x20; // Il2CppArray
const STR_LEN = 0x10, STR_CHARS = 0x14;   // Il2CppString

const OFF = {
  phCrows: 0x40,        // PlayerHandler.crowsArray (UnitCrow[])
  pcCharLogic: 0x38,    // PlayerController.CharLogic (CGameCharLogic)
  clName: 0x60,         // GameCharData.szName
  clLevel: 0x84,        // GameCharData.wLevel (u16)
  clHp: 0x118,          // GameCharData.sHP  (PAData: u16 now, u16 max)
  clMp: 0x11C,
  clSp: 0x120,
  crowId: 0x20,         // UnitCrow.crowID
  crowController: 0x38, // UnitCrow.enemyController (EnemyAiController)
  aiCrowLogic: 0x28,    // EnemyAiController.CrowLogic (CGameCrowLogic)
  aiIsDead: 0x78,       // EnemyAiController.isDead
  aiMobNpc: 0x88,       // EnemyAiController.mobNpcObject (MobNpcObject)
  crowNowHp: 0xD0,      // GameCrowLogic.dwNowHP (u32)
  defName: 0x20,        // MobNpcObject.Name
  defBoss: 0x3F,        // MobNpcObject.bossMob (bool)
  defHp: 0x48,          // MobNpcObject.hp (u32 max)
  defLevel: 0x5C,       // MobNpcObject.level (byte)
};

function p(x) {
  // strip a possible arm64 pointer tag (top byte)
  return x.and(ptr("0x00FFFFFFFFFFFFFF"));
}
function rp(addr) { return p(addr.readPointer()); }
function rstr(s) {
  if (s.isNull()) return "";
  const n = s.add(STR_LEN).readS32();
  return n > 0 && n < 256 ? s.add(STR_CHARS).readUtf16String(n) : "";
}
function klassName(k) {
  try { return k.add(KLASS_NAME).readPointer().readCString(); } catch (e) { return null; }
}

function findBase() {
  const cands = Process.enumerateRanges({ protection: "r--", coalesce: false })
    .filter(r => r.file && r.file.path.endsWith("/libil2cpp.so") && r.file.offset === 0)
    .map(r => r.base);
  for (const b of cands) {
    try {
      const k = rp(b.add(RVA.PlayerHandler_TypeInfo));
      if (!k.isNull() && klassName(k) === "PlayerHandler") return b;
    } catch (e) {}
  }
  throw new Error("libil2cpp base not found (candidates: " + cands.join(", ") +
    "). Is the character in game already?");
}

function staticInstance(base, rva, name) {
  const k = rp(base.add(rva));
  if (klassName(k) !== name) throw new Error(name + " TypeInfo mismatch");
  return rp(rp(k.add(KLASS_STATIC_FIELDS))); // first static field = Instance
}

function readPlayer(base) {
  const pc = staticInstance(base, RVA.PlayerController_TypeInfo, "PlayerController");
  if (pc.isNull()) return null;
  const cl = rp(pc.add(OFF.pcCharLogic));
  if (cl.isNull()) return null;
  return {
    name: rstr(rp(cl.add(OFF.clName))),
    level: cl.add(OFF.clLevel).readU16(),
    hp: [cl.add(OFF.clHp).readU16(), cl.add(OFF.clHp + 2).readU16()],
    mp: [cl.add(OFF.clMp).readU16(), cl.add(OFF.clMp + 2).readU16()],
    sp: [cl.add(OFF.clSp).readU16(), cl.add(OFF.clSp + 2).readU16()],
  };
}

function readCrows(base) {
  const ph = staticInstance(base, RVA.PlayerHandler_TypeInfo, "PlayerHandler");
  if (ph.isNull()) return [];
  const arr = rp(ph.add(OFF.phCrows));
  if (arr.isNull()) return [];
  const n = arr.add(ARR_COUNT).readU32();
  const out = [];
  for (let i = 0; i < n && i < 4096; i++) {
    const uc = rp(arr.add(ARR_FIRST + i * 8));
    if (uc.isNull()) continue;
    const ai = rp(uc.add(OFF.crowController));
    if (ai.isNull()) continue;
    const logic = rp(ai.add(OFF.aiCrowLogic));
    const def = rp(ai.add(OFF.aiMobNpc));
    out.push({
      id: uc.add(OFF.crowId).readS32(),
      dead: ai.add(OFF.aiIsDead).readU8() !== 0,
      now: logic.isNull() ? 0 : logic.add(OFF.crowNowHp).readU32(),
      max: def.isNull() ? 0 : def.add(OFF.defHp).readU32(),
      boss: !def.isNull() && def.add(OFF.defBoss).readU8() !== 0,
      level: def.isNull() ? 0 : def.add(OFF.defLevel).readU8(),
      name: def.isNull() ? "" : rstr(rp(def.add(OFF.defName))),
    });
  }
  return out;
}

const base = findBase();
console.log("libil2cpp base = " + base);

setInterval(() => {
  try {
    const me = readPlayer(base);
    const crows = readCrows(base);
    const lines = [];
    if (me) {
      lines.push(`[ME] ${me.name} Lv${me.level}  HP ${me.hp[0]}/${me.hp[1]}  MP ${me.mp[0]}/${me.mp[1]}  SP ${me.sp[0]}/${me.sp[1]}`);
    } else {
      lines.push("[ME] (not in game yet)");
    }
    crows.sort((a, b) => (b.boss - a.boss) || (a.dead - b.dead));
    lines.push(`[CROWS] ${crows.length} total, ${crows.filter(c => c.boss).length} boss`);
    for (const c of crows.slice(0, 15)) {
      lines.push(`  ${c.boss ? "BOSS" : "mob "} #${c.id} ${c.name} Lv${c.level}  HP ${c.now}/${c.max}${c.dead ? "  (dead)" : ""}`);
    }
    console.log(lines.join("\n") + "\n");
  } catch (e) {
    console.log("read error: " + e.message);
  }
}, 1000);
