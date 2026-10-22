# farm KlassX — โน้ตการถอด

เกมเป้าหมาย: Klass X Online (`com.klab.klassxonline`), Frida 17.17.0 Unity IL2CPP บน LDPlayer

## ไฟล์
| path | คืออะไร |
|---|---|
| `src/` | C# ที่ถอดแล้ว + **ถอดรหัส string แล้ว** (de4dot rename + decrypt ผ่าน `Class185.smethod_0`, token `0x0600083C`) |
| `exe/` | C# ถอดตรง ๆ ยังไม่ทำความสะอาด (ไว้เทียบ) + resource ที่ฝังมา (`runtime.js`, `libshare.so`, exe ย่อย) |
| `js/out/deobfuscated.js` | runtime.js หลัง webcrack |
| `js/runtime.renamed.js` | หลัง rename อัตโนมัติ (`tools/jsrename/rename.js`) — **อ่านไฟล์นี้** |
| `../cleaned/` | exe ที่ผ่าน de4dot (ใช้เปิดใน dnSpyEx/ILSpy GUI ได้) |
| `../tools/dump-game.sh` | ดึง APK จาก emulator + รัน Il2CppDumper → `game/il2cpp-dump/dump.cs` |

## สถาปัตยกรรม
1. `.exe` (WinForms, main form = `src/GForm0.cs`) เปิดแล้วเข้าหน้าหลักเลย ไม่มี login/license แล้ว (ดู "ระบบที่ตัดออก")
   **ตาราง offset** อ่านจาก `config\offsets.json` (`LocalOffsets.Load` → `Class357.smethod_15`) — เดิมได้มากับ response ของ `/login`
2. `.exe` ใช้ `klx.dll` (Frida) + push `klxsvc` (frida-server) เข้า emulator ผ่าน adb
3. inject `runtime.js` เข้าเกม, ส่ง offset ให้ → script hook ฟังก์ชันเกมแล้วส่ง state กลับเป็น binary

## ส่วนของ runtime.js (ชื่อกลุ่ม offset → ฟีเจอร์)
`KEYS_CORE` อ่าน state ผู้เล่น/มอน/ไอเทม · `KEYS_ATTACK` เลือกเป้า/ตี · `KEYS_SKILL`, `KEYS_SKILL_TAB` ใช้สกิล ·
`KEYS_QUICKSLOT` ใช้ยา · `KEYS_PICKUP` เก็บของ · `KEYS_INVENTORY` กระเป๋า · `KEYS_NPC_SALE` ขายของ ·
`KEYS_PET` ให้อาหาร/เรียกสัตว์เลี้ยง · `KEYS_REBIRTH` ตายแล้วเกิด · `KEYS_RECALL`, `KEYS_FRIEND_WARP` วาร์ป ·
`KEYS_PARTY`, `KEYS_FRIENDS` ปาร์ตี้/เพื่อน · `KEYS_ZOOM`, `KEYS_FOG`, `KEYS_MESH`, `KEYS_RADAR*`, `KEYS_WORLD_TO_SCREEN` กล้อง/เรดาร์ ·
`KEYS_BOT_CHALLENGE` ตอบภาพปริศนากันบอท

## ระบบที่ตัดออก (2026-10-23)
backup ก่อนตัด: `_backup/src-before-strip-network/` (src ทั้งชุด + `deobfuscated.js`)

| ระบบ | ที่ตัด |
|---|---|
| License server (`…nikom576.workers.dev`: `/register` `/login` `/check-login-status` `/latest-version` `/git-token`) | ลบ `GClass20` (HTTP), `GClass1`/`GClass18` (รหัสเครื่อง), DTO `GClass0/5/8/9/10/17`, `Class42/118/359`, ฟอร์ม `GForm1` (ใส่ key), `Form5` (ต่ออายุ) · `Class424.smethod_3` ไม่เช็ค license แล้ว · `GForm0`: ลบปุ่มต่ออายุ, label Vip/Expire/Pause Normal, `method_127` (เช็ค Vip) → `true` |
| License ฝั่งเกม (`libshare.so` ฉีดเข้าเกม ยิง TLS ไป worker เดียวกันพร้อม `licenseKey`/`uniqueIdentifier`/`server`; ถ้าเช็คไม่ผ่าน 3 รอบ runtime.js สั่ง `_exit(1)` ปิดเกม) | ลบ `libshare.so` resource, `Class57/442/32` (deploy), `Class103/175/393/349/66/147` (ECDH handshake), ขั้น `libshare_init`/`license_open`/`license_bootstrap` ใน `Class119` · `runtime.js`: ลบ loader + license controller (บรรทัด 4–690 เดิม) และ handler 4 ตัว |
| GitHub API (อัปเดต exe + catalog ด้วย token จาก `/git-token`) | ลบ `Class21`, `Class166`, `Class39` (เรียก updater), `Class139`, `Class438/94/345`, resource `Capybara-AutoUpdate.exe` · `Class135` เหลือแค่ชื่อ app/pipe |
| Heartbeat (`Capybara-KlassX-Hearthbeat.exe` แตกไปไว้ `%LOCALAPPDATA%\Capybara_Bot\` แล้วรัน: `CheckLicense(รหัสเครื่อง)` กับ worker ตอนเปิด, ส่ง `Heartbeat(licenseKey, รหัสเครื่อง)` ทุก 15 นาที, license ไม่ผ่านก็ปิดตัวเอง → watchdog ใน exe หลักเห็น process หายแล้วปิดบอทตาม) — string ใน exe นี้เข้ารหัส (Eazfuscator) เลยหา URL ด้วย string scan ไม่เจอ | ลบ `Class92` (watchdog), `Class17`, `Class343` (แตก/รัน exe), resource `Capybara-KlassX-Hearthbeat.exe`, `GForm0.method_17/18/19`, flag `--test-heartbeat-watchdog`/`--heartbeat-watchdog-probe-child` · ไฟล์ที่แตกไว้แล้วใน `%LOCALAPPDATA%\Capybara_Bot\` ลบทิ้งได้ |
| Discord webhook ของคนขาย (อัปโหลดภาพปริศนา + heroName + ผลตอบ) | ลบ `Class411`, `Class187`, `Class131.smethod_0`, `Class135.smethod_9`; `Class363` เหลือแค่เก็บ archive ในเครื่อง (`%LOCALAPPDATA%\Capybara_Bot\ChallengeCapture`) ให้ระบบตอบอัตโนมัติใช้ |

- self-test ใน `Class198` ที่ทดสอบระบบพวกนี้ลบไปด้วย (รวม flag `--test-agent-license*`, `--test-update`, `--test-catalog-update`, `--check-catalog-update`, `--test-renew`, `--test-sell-vip`, `--test-challenge-capture`)
- `checkBox_60`/`textBox_30` ("ใช้งาน Discord - แจ้งเตือน") ในแท็บ challenge เป็น UI ค้างที่ไม่ได้ต่อกับโค้ดอะไร — ไม่ได้แตะ
- `js/runtime.renamed.js` ยังเป็นของเดิม (มีโค้ด license) — ไว้อ่านเทียบเท่านั้น

### `config\offsets.json`
build copy ไปไว้ข้าง exe ให้อัตโนมัติ · รับได้ 2 แบบ: `{ "Addr_...": "0x..." }` (key → value ตรง ๆ) หรือรูปแบบเดิมของ server `{ "MemoryPointers": [ { "Key", "Value" } ] }` (มี `"Offsets"` ครอบหรือไม่ก็ได้)
- **ต้องมี 5 ตัว** ไม่งั้นกด Run จะขึ้น "Offsets not loaded - <เหตุผล>": `Addr_Function_PlayerHandler_Update`, `Addr_Function_PlayerController_FrameMove`, `Addr_Function_OnManualMovement`, `KlassX_Build_VersionCode` (= 33 จาก AndroidManifest), `KlassX_Build_UnityVersion` (= 6000.3.8f1 จาก `data.unity3d`) — ใส่ไว้แล้ว
- ที่เหลือเป็นกลุ่มฟีเจอร์ (ตี, สกิล, ยา, เก็บของ, ขาย, pet, ตอบปริศนา, เรดาร์, กล้อง, …) — ชื่อ key อยู่ใน `Class357.valueTuple_0..23`; ฟีเจอร์ไหนขาด key แม้ตัวเดียวจะถูกปิดทั้งกลุ่ม
- **สร้างไฟล์ทั้งหมดด้วย** `python tools/offsets/resolve.py --write` (ไม่ใส่ `--write` = แสดงผลอย่างเดียว) — อ่าน key จาก `Class357.cs`, หา RVA ใน `game/il2cpp-dump/dump.cs`, TypeInfo ใน `script.json`, overload เลือกตามจำนวน/ชนิด argument ที่ `runtime.js` ส่งให้ `NativeFunction`. เกมอัปเดต → dump ใหม่ (`tools/dump-game.sh`) แล้วรันซ้ำ (แก้ `KlassX_Build_*` ใน `FIXED` ด้วย)
  - 2026-10-23: ได้ 87/90 → เปิดได้ 23/24 กลุ่ม; ขาดแค่ fog (`Addr_Native_RenderSettings_*` อยู่ใน `libunity.so` ไม่อยู่ใน dump — ต้องแกะ ARM64 เอง)
  - 3 hook ที่ resolve ได้ตรงกับค่าที่ verify live ใน OFFSETS.md
- **field offset ฝังอยู่ใน exe** (`Class431.smethod_3`, ~190 ค่า เช่น `zoomHeights`, `phPetObject`) ไม่ได้มาจาก server — เกมอัปเดตแล้ว field เลื่อนได้
  - เช็คด้วย `python tools/offsets/check_fields.py` (แสดง field ที่อยู่ตรง offset นั้นใน dump ปัจจุบัน; ชื่อไม่ตรง/`NOTHING` = เลื่อน) → แก้เลขใน `Class431.cs` แล้ว build
  - 2026-10-23 เจอเลื่อน 6 ค่า: `Zoom.targetHeights/targetRadii` 0x80/0x88 → **0x88/0x90**, `PlayerHandler` pet 0x170–0x17E → **0x188–0x196** (`phPetObject/phPetGlobalId/phActivePetCardSlot/phInvenLine`) — แก้แล้ว
  - อาการถ้า field เลื่อน: hook รายเฟรมอ่าน memory พัง → logcat ของเกมขึ้น `E/CRASH ... frida-agent-arm64.so` (frame บนสุดเป็น `<anonymous>` = trampoline ของ hook) ซ้ำทุก ~0.15 วิ เกมค้างหน้า Loading/ค้างในแมพ (process ไม่ตาย)
- ทดสอบ agent กับเกมที่เข้าแมพอยู่แล้วได้โดยไม่ต้องผ่านบอท: ต่อ runner ที่บอทเปิดไว้ (`adb forward tcp:27042`, token ใน `/data/local/tmp/.klx.tok`) ด้วย Python frida 17.17 `realm="emulated"` แล้ว post ข้อความ offsets (ได้จาก `Class431.smethod_0` ผ่าน reflection)
- field offset (`clHp`, `crowNowHp`, …) hardcode อยู่ใน `Class431.smethod_3` ไม่ได้มาจาก server

## HP
- ผู้เล่น: `CharLogic + clHp` → u16 คู่ (ปัจจุบัน/สูงสุด) → packet byte 64–67 (MP 68, SP 72, level 76)
- ผู้เล่นคนอื่น: `SDROP_CHAR + sdHp` → u16 คู่ → record kind = 100
- มอน/บอส: `crowNowHp` (u32 ปัจจุบัน) จาก CrowLogic, `defHp` (u32 สูงสุด) + `defBoss` (u8) จาก definition
  → record มอน 32 byte, flags bit0 = ตาย, bit1 = บอส · บอสไม่มีโครงสร้าง HP แยก ต่างกันแค่ flag

### record 32 byte (census, `_0x4c8df9` ↔ `Class119.smethod_57` → `Class403`)
| byte | ทั่วไป | มอน/บอส (kind < 100) |
|---|---|---|
| 0 | kind: crowType / 100 คน / 101 ไอเทม / 102 เงิน | crowType |
| 1 | flags: bit0 ตาย, bit1 บอส, bit2 ตัวเอง, bit3 หัวปาร์ตี้ | |
| 2, 4 | dataId main/sub (u16) | |
| 6 | HP ปัจจุบัน u16 (เงิน = จำนวน) | **HP ปัจจุบัน u32 (6–9)** |
| 8 | HP สูงสุด u16 | ↑ |
| 10 | level u16 | |
| 12 | id u32 | |
| 16/20/24 | pos x/y/z float | |
| 28 | partyId u16 | **HP สูงสุด u32 (28–31)** |
| 30 / 31 | school / class | ↑ |

**แพตช์ HP u32 (2026-10-23):** ของเดิมตัด HP มอนเป็น `& 65535` → บอสเลือดเกิน 65535 จะวนรอบ (บางครั้งอ่านได้ 0)
- JS: `js/out/deobfuscated.js` (+ `runtime.renamed.js`) เขียน u32 ทับ byte 6 / 28 หลังเรียก `_0x4c8df9`; `defHp` → `readU32`, `defLevel` → `readU8`
- `src/runtime.js` ตอนนี้ **= `js/out/deobfuscated.js`** (ของเดิมเก็บไว้ที่ `src/runtime.orig.js`) — แก้ JS แล้วต้อง copy ทับทุกครั้ง
- C#: `Class403.ushort_2/3` → `uint` (ชื่อเดิม), `smethod_57` อ่าน u32 ถ้า kind < 100; ปรับ type ใน `Class447`, `Class65.smethod_6` (long), `Class412` (cast int)
- ยังเป็น u16 อยู่: จำนวนเงิน kind 102 (ถูกตัดเหมือนกัน ยังไม่แก้)

## Build (ผ่านแล้ว 2026-10-23)
```
cd decompiled/src
dotnet build Capybara-KlassX-strings.csproj -c Release
→ src/bin/Release/net472/Capybara-KlassX.exe (+ Newtonsoft.Json.dll, System.*.dll ต้องอยู่โฟลเดอร์เดียวกัน)
```
- ข้าง exe ต้องมี `config\klx.dll` + `config\klxsvc` (build copy จาก `E:\reverse-bot\config\` ให้อัตโนมัติ — ตั้งไว้ใน csproj)
  และ `OneOCR\` (`oneocr.dll`, `oneocr.onemodel`, `onnxruntime.dll`) สำหรับตอบภาพกันบอท — **ยังไม่มีในเครื่อง** (Snipping Tool เครื่องนี้เก่าเกิน) ไม่บังคับตอนเปิดโปรแกรม
- exe ต้องรันแบบ **Run as administrator** (app.manifest = requireAdministrator) — ถ้าแค่รัน self-test ให้ตั้ง `__COMPAT_LAYER=RunAsInvoker` ก่อนรันจะได้ไม่ต้อง elevate
- ทดสอบ record HP: `powershell -ExecutionPolicy Bypass -File tools\hptest\run.ps1`
  (ใช้ writer จริงจาก `src/runtime.js` → parser จริงใน exe; ต้อง PASS ทั้ง 4)
- `--selftest` ของ exe เดิมเองก็ FAIL ชุด title/loading-rebirth (ไฟล์หาซอร์สของ dev เช่น `runtime.ts`) และ crash ที่ `LiveFormFixture reflection contract missing`
  (de4dot rename ทำให้หา member ตามชื่อไม่เจอ) → ใช้เทียบกับ baseline เท่านั้น ไม่ใช่ตัวชี้ว่า build พัง
- ทดสอบแบบไม่ต่อเน็ต/emulator: `Capybara-KlassX.exe --test-grid-safety` / `--test-challenge-auto` ฯลฯ (ดู flag ใน `Class424.Main`; ชุด `--test-agent-license*` ถูกลบไปพร้อม license แล้ว)
- สิ่งที่ทำให้ build ผ่าน:
  - `lib/Newtonsoft.Json.dll` แตกจาก `costura.newtonsoft.json.dll.compressed` (raw deflate, SHA1 ตรง metadata) → HintPath ใน csproj
  - csproj: `GenerateResourceUsePreserializedResources` + PackageReference `System.Resources.Extensions` 8.0.0 (resx มีรูป)
  - **ถอด .cs ใหม่ทั้งชุด** ด้วย `ilspycmd -p -r decompiled/lib -o … cleaned/Capybara-KlassX-strings.exe` (ต้องตั้ง `DOTNET_ROLL_FORWARD=Major` เพราะเครื่องมีแค่ .NET 9)
    — ชุดเดิมถอดตอนไม่มี Newtonsoft จึงพัง ~109 จุด; ชุดเดิมเก็บไว้ที่ `_backup/src-cs-before-redecompile/` (ต่างกันแค่ผลถอด ไม่มีแก้มือ) แล้วลงแพตช์ HP u32 ซ้ำ
  - แก้ผลถอดที่ compile ไม่ผ่าน: `Class198` ldtoken 23 จุด → `typeof(X).GetMethod("name", …)` (map จาก IL ตามลำดับ),
    async MoveNext ที่ goto ข้าม declaration (`Class411` uri, `Form5` string_, `Class190` class2) → ย้าย declaration ขึ้นบน,
    `Class166` → `base.SendAsync`, `GForm0` `catch (object)` → `catch (Exception)`
- Costura module initializer หายไปตอนถอด (C# เขียนไม่ได้) → Newtonsoft โหลดจากไฟล์ข้าง exe แทน resource

## หมายเหตุ
- rename เป็น heuristic — ถ้าเจอพฤติกรรมแปลกตอนรัน ให้เทียบกับ `js/out/deobfuscated.js`
  (`runtime.renamed.js` **รันไม่ได้**: มี `let off = off;` ซึ่งเป็น TDZ error → ใช้ไว้อ่านเท่านั้น)
- de4dot โหมด Eazfuscator crash (เวอร์ชันใหม่เกิน) จึงใช้ rename + string decrypt แบบ delegate แทน; control flow ยังไม่ได้ clean
