# แผนทดสอบ — แก้แท็บ Monster / Skill / Item Box (2026-10-27)

ไฟล์นี้เขียนให้ทั้งคนและ Claude Code ที่รันบนเครื่อง Windows (มี LDPlayer + เกม) ใช้ทดสอบและ monitor บอท
การแก้ทั้งหมดอยู่บน branch `build-exe` — ทุก commit build ผ่าน แต่ **ยังไม่เคยรันกับเกมจริง**

## 1. สิ่งที่แก้ (เรียงตาม commit)

| commit | เรื่อง | ไฟล์ |
|---|---|---|
| `aebef82` | ลบ UI ที่ไม่มีโค้ดรองรับในแท็บ Monster: "โหมดลากจะไม่สนใจหาก Monster <" + ช่องเลข, "กล้องบอท", ปุ่ม Get / ถัดไป / เพิ่ม, ช่องค้นหามอน, โหมด "Heal" | `GForm0.cs` |
| `f2b47c8` | **D1** log ผลเช็คสกิลทุกช่อง (เดิมถูกตัดทิ้ง) · **D2** มอนที่ตีอยู่เดินออกนอกวง → สั่งเกมหยุดตี (เดิมแค่ลืมเป้า ตัวละครเลยไล่ออกนอกวง) | `Class119.cs`, `Class412.cs`, `Class65.cs` |
| `96aed71` | **D3** ชื่อมอนเทียบแบบตรงตัว (ไม่สนตัวพิมพ์, คั่นหลายชื่อด้วย `,` หรือ `\|`) ใช้กฎเดียวกันทั้ง "ตีก่อน" และ "ตีเฉพาะ" · blacklist ลบมอนที่ตาย/หายออก (ตัวเกิดใหม่ id ซ้ำไม่ติด) · blacklist ตอนตีด้วยสกิลก็สั่งหยุดตี · log เหตุผลที่ข้ามมอน · โหมดตามพิกัดหามอนระหว่างนับ "รอ" · ออกจากโหมดจุดปัจจุบัน/วงกลมแล้วกลับมา = ใช้จุดศูนย์กลางใหม่ | `Class2.cs`, `Class65.cs`, `Class394.cs`, `Class412.cs`, `Class447.cs` |
| `096dceb` | **D4** log ว่าลูปบอทอยู่ขั้นไหน + ค้างนานเท่าไร · เตือนเมื่อข้อมูลจากเกมหยุดเข้ามา 5 วิ · ตัวนับ "จะวิ่งกลับกลางวงกลม" นับต่อแม้กำลังทำขั้นอื่น · log error ที่ทำให้ลูปหยุด | `Class58.cs`, `Class65.cs` |
| `8f5301a` | ลบ F1/F2/F3 (แท็บ Skill Potion) และป้าย "Result" · ดับเบิลคลิกรายชื่อมอน = เพิ่ม/ถอดชื่อ (เลือกหลายตัว, ล้างได้) | `GForm0.cs` |
| `4991d7b` | Item Box: กล่องระดับ MAX (Speed Up MAX 9, Madness 10, Power Up MAX 11) นับรวมกับช่องที่ติ๊ก · log การตัดสินใจเก็บกล่อง | `Class360.cs` |
| `bb53a3a` | Item Box: ช่องที่ติ๊กใน "LuckyBox (Lock)" = **ผลที่ต้องการ** — เก็บกล่องทุกใบจนกว่าจะติดผลที่ติ๊ก แล้วหยุด, ผลหมดก็เก็บต่อ | `Class360.cs` |

## 2. เตรียมเครื่อง

```powershell
git pull                      # branch build-exe
cd decompiled\src
dotnet build Capybara-KlassX-strings.csproj -c Release
# รัน bin\Release\net472\Capybara-KlassX.exe แบบ Run as administrator
```

- log อยู่ที่ `%LOCALAPPDATA%\Capybara_Bot\agent.log` (ทุกบรรทัดขึ้นต้นด้วยเวลา `yyyy-MM-dd HH:mm:ss.fff`, เกิน 5 MB ย้ายไป `agent.old.log`)
- ค่าตั้งในหน้าบอท (ติ๊ก/เลือกโหมด) **คนต้องตั้งเอง** — Claude Code บนเครื่องคลิก WinForms ไม่ได้ (เว้นแต่มี computer-use) หน้าที่ของ AI คือ build, เฝ้า log, เช็ค adb, ถ่ายจอเกม แล้วตัดสิน PASS/FAIL
- ทดสอบทีละ test case, จดเวลาเริ่ม/จบ เพื่อตัด log ช่วงนั้นมาดู

### คำสั่งสำหรับ monitor

```powershell
$log = "$env:LOCALAPPDATA\Capybara_Bot\agent.log"
# ดูสด เฉพาะบรรทัดที่เพิ่มในรอบนี้
Get-Content $log -Wait -Tail 0 | Select-String 'skill check|monster skip|monster blacklist|bot step|no game data|game data resumed|bot loop stopped|active box effect|^.{24}box '
# ตัดช่วงเวลา (เช่น 14:00–14:15)
Select-String -Path $log -Pattern '^2026-10-27 14:(0\d|1[0-5])' | Select-Object -ExpandProperty Line
```

```powershell
# adb (จอแรก = emulator-5554, จอที่ n = 5554+2n)
adb devices
adb -s emulator-5554 shell pidof com.klab.klassxonline          # มีเลข = เกมยังรัน
adb -s emulator-5554 shell "ps -A | grep klxsvc"                # มี = frida-server ยังรัน
adb -s emulator-5554 exec-out screencap -p > shot.png           # ถ่ายจอเกมไว้เทียบกับ log
```

### รูปแบบบรรทัด log ที่เพิ่มใหม่

| บรรทัด | ความหมาย |
|---|---|
| `skill check: S1=OK S2=cooldown S3=empty …` | ผลเช็คสกิลแต่ละช่อง (log เมื่อเปลี่ยน) — `OK` ใช้ได้, `empty` ช่องว่าง/อ่านไม่ได้, `cooldown`, `no-MP`, `no-SP`, `no-HP`, `wrong-item`, `prohibited`, `not-learned` |
| `skill check FAILED: (no slots)` | agent เช็คสกิลไม่ได้ (offset/ระบบสกิลไม่พร้อม) |
| `monster skip: <reason> id=… name=… hp=a/b` | มอนตัวนี้ถูกข้าม: `blacklisted`, `name-unknown`, `name-not-selected`, `hp-too-low` (log เมื่อเหตุผลเปลี่ยน) |
| `monster blacklist 60s (hp not dropping): id=… name=… hp=… pos=X:…, Z:…` | ตี 5 ครั้ง/5 วิแล้ว HP ไม่ลด → ข้าม 60 วิ |
| `bot step: <step> (after <prev> N.Ns)` | ลูปเปลี่ยนขั้น: `attack`, `pickup`, `buff`, `pet`, `follow-party`, `buff-only`, `rebirth`, `GClass15` (หยุด/แจ้งเตือน), `GClass19` (แจ้งเตือนผู้เล่น), `no-game-data` |
| `bot step: still <step> for Ns` | ค้างขั้นเดิม (ทุก 20 วิ) |
| `no game data update for 5s (agent/frida/adb/emulator?) - last step: …` | ข้อมูลตัวละครจากเกมหยุดเข้ามา |
| `game data resumed after Ns` | กลับมาแล้ว |
| `bot loop stopped by error in step '…': …` | ลูปบอทหยุดเพราะ exception |
| `active box effect: <type>` | ผลกล่องที่ตัวละครติดอยู่เปลี่ยน (`None`, `SpeedUp`, `Crazy`, `PowerUp`, `EXP`, `Bomb`, `Madness`, `PowerUpMAX`, `SpeedUpMAX`, …) |
| `box <type> id=…: may pick up` / `box <type> id=…: skip, <reason>` | การตัดสินใจเก็บกล่อง: `no-box option`, `wanted effect <X> is running` |

## 3. Test cases

แต่ละข้อ: **ตั้งค่า** (คนทำ) → **ทำ/รอ** → **ดู** (AI เฝ้า log + adb) → **ผ่านเมื่อ**

### TC-01 เปิดโปรแกรม / UI ที่ลบไป (regression)
- ตั้งค่า: ใช้ `<hero>_Setting.ini` เดิมที่เคยบันทึกค่าของ control ที่ถูกลบ
- ทำ: เปิดโปรแกรม, คลิกครบทุกแท็บ, กด Select + Run
- ผ่านเมื่อ: ไม่ crash, แท็บ Monster ไม่มี กล่องบอท / Get / Heal / ถัดไป / เพิ่ม / ช่องค้นหา / Result / "โหมดลาก…", แท็บ Skill Potion ไม่มี F1/F2/F3, ค่าอื่นโหลดครบ

### TC-02 D1 — สกิลไม่ถูกใช้
- ตั้งค่า: ติ๊ก Skill 1–10 ตามที่มีสกิลจริง, ในเกมเปิดหน้าแถบสกิลที่มีสกิลอยู่, โหมดตีอะไรก็ได้
- ทำ: ตีมอน 3–5 นาที
- ดู: บรรทัด `skill check:` + จอเกมว่าใช้สกิลไหม
- ผ่านเมื่อ: ช่องที่ `OK` ถูกใช้จริงในเกม
- ถ้าตีธรรมดาตลอด: จดว่าแต่ละช่องได้ code อะไร
  - `empty` ทุกช่อง → หน้าแถบสกิลในเกมไม่ใช่หน้าที่มีสกิล (ลองสลับหน้าในเกม)
  - `no-MP`/`no-SP` → ทรัพยากรไม่พอจริงตามเกม
  - `skill check FAILED` → ระบบสกิลของ agent ไม่พร้อม (ดู offset)
  - `OK` แต่ไม่ใช้ → บัคฝั่งสั่งใช้สกิล ส่ง log ช่วงนั้นกลับมา

### TC-03 D2 — ตีแล้วหลุดวงกลม
- ตั้งค่า: โหมด "ตามขอบเขตวงกลม", รัศมีเล็ก (เช่น 30–50), Show Zone, ยืนในที่มีมอนเดินไปมา/หนี
- ทำ: ตี 5–10 นาที
- ดู: ตำแหน่งตัวละครเทียบวง (จอเกม / Current Position), log `bot step`
- ผ่านเมื่อ: ตัวละครไม่ไล่มอนออกไปไกลนอกวง — เมื่อมอนเดินออกนอกวง ตัวละครหยุดตี (อาจขยับเล็กน้อย 2 หน่วย) แล้วไปหาตัวอื่นในวง

### TC-04 D3 — เลือกมอน (UI)
- ทำ: แท็บ Monster → Load → ดับเบิลคลิกชื่อ A → ดับเบิลคลิกชื่อ B → ดับเบิลคลิก A อีกครั้ง → ดับเบิลคลิก B
- ผ่านเมื่อ: ช่องสีส้มเป็น `A` → `A, B` → `B` → ว่าง

### TC-05 D3 — ตีเฉพาะมอนที่เลือก (ชื่อตรงตัว)
- ตั้งค่า: แมพที่มีมอนชื่อคล้ายกัน (เช่น "Hooligan" กับ "Little Hooligan"), เลือกแค่ "Hooligan", ติ๊ก "ตีเฉพาะ Monster ที่เลือก"
- ทำ: ตี 5 นาที
- ดู: `monster skip: name-not-selected … name=Little Hooligan`
- ผ่านเมื่อ: ไม่ตี "Little Hooligan" เลย, ตี "Hooligan" ได้ปกติ
- เพิ่ม: เลือกหลายตัว (`A, B`) → ตีทั้งสองชนิด, ไม่ตีชนิดอื่น
- เพิ่ม: ติ๊ก "ตี Monster ที่เลือกก่อน" (ไม่ติ๊กตีเฉพาะ) → ตีชนิดที่เลือกก่อนเมื่อมีหลายตัวในวง
- ถ้าเจอ `name-unknown` นานกว่า ~10 วิหลังเข้าแมพ → ชื่อมอนยังไม่มาจาก agent, ส่ง log

### TC-06 D3 — blacklist และมอนเกิดใหม่
- ตั้งค่า: หามอนที่ตีไม่ถึง (ติดกำแพง/บนที่สูง) หรือจุดที่มอนเกิดซ้ำตำแหน่งเดิม
- ดู: `monster blacklist 60s …` และ `monster skip: blacklisted …`
- ผ่านเมื่อ:
  - มอนที่ตีไม่เข้าถูก blacklist แล้วบอทไปตีตัวอื่น (ไม่ยืนตีค้าง)
  - มอนที่เกิดใหม่หลังตัวเก่าตาย (แม้ id ซ้ำ) ไม่ติด `blacklisted` — ถ้าเห็น id เดียวกันถูก skip ทั้งที่ HP เต็มและเพิ่งเกิด = FAIL

### TC-07 โหมดตามพิกัด — ตีมอนที่เกิดระหว่างรอ
- ตั้งค่า: โหมด "ตามพิกัด", จุด 2–3 จุด, ติ๊ก "ดีเลย์" 30 วิ ตอนบันทึกพิกัด
- ทำ: ไปจุดที่มอนเกิดเป็นรอบ ๆ
- ผ่านเมื่อ: ระหว่างนับ "รอ" ถ้ามอนเกิด บอทตีทันที และนับรอใหม่หลังตีหมด (เดิมยืนเฉยจนครบเวลา)

### TC-08 สลับโหมดระหว่างรัน
- ทำ: โหมด "ตามขอบเขตวงกลม" ที่จุด P1 → เปลี่ยนเป็น "ตามพิกัด" ให้บอทเดินไปที่อื่น (P2) → เปลี่ยนกลับเป็น "ตามขอบเขตวงกลม"
- ผ่านเมื่อ: วงใหม่อยู่ที่ตำแหน่งปัจจุบัน (P2) ไม่วิ่งกลับ P1

### TC-09 D4 — ตัวนับ "จะวิ่งกลับกลางวงกลม" / ขั้นของลูป
- ตั้งค่า: โหมด "ตามขอบเขตวงกลม", ติ๊ก "Reset โหมดวงกลม หาก >" 30, เปิดเก็บของ + บัพตามปกติ
- ทำ: รัน 10–15 นาที
- ดู: label บนแท็บ Monster + `bot step:` ใน log
- ผ่านเมื่อ: ตัวเลขไม่ค้าง — ตอนกำลังเก็บของ/บัพ จะขึ้น `… (พัก: เก็บของ)` และเลขยังลด, ครบเวลาแล้ววิ่งกลับกลางวง
- ถ้าเลขค้างอีก: ดู log ช่วงนั้น
  - มี `no game data update` → ปัญหาฝั่ง adb/frida/emulator (ดู TC-10)
  - มี `bot step: still <X> for Ns` → บอทติดที่ขั้น X — ส่ง log + จอเกมช่วงนั้นกลับมา
  - มี `bot loop stopped by error` → ส่ง error กลับมา

### TC-10 D4 — แยกค้างที่บอท vs adb/เกม
- ทำ (เลือกอย่างใดอย่างหนึ่ง ระหว่างบอทรัน): หยุดเกมชั่วคราว `adb -s emulator-5554 shell am force-stop com.klab.klassxonline` (หรือ pause emulator)
- ผ่านเมื่อ: ภายใน ~5 วิ log ขึ้น `no game data update for 5s …` / `bot step: no-game-data` และบอทไม่ crash; เปิดเกม + Run ใหม่แล้วข้อมูลกลับมา
- ห้ามใช้ `adb kill-server` ถ้ามีบอทตัวอื่นรันอยู่ (ตัด adb ทุกตัว)

### TC-11 Item Box — เก็บกล่องจนได้ผลที่ต้องการ
- ตั้งค่า: แท็บ Item Box → "LuckyBox (Lock)" ติ๊ก **Power Up + Crazy**, ไม่ติ๊ก "ไม่เก็บกล่อง", โหมดเก็บ = เก็บทุกอย่าง (หรือ "เก็บเงินและไอเท็มตาม List")
- ทำ: ฟาร์มในแมพที่มีกล่องดรอป 15–30 นาที
- ดู: `active box effect:` และ `box … :` ใน log + ไอคอนผลในเกม
- ผ่านเมื่อ:
  1. ตอน `active box effect: None` / `SpeedUp` / `EXP` / `Bomb` → กล่องที่เห็น `may pick up` และถูกเก็บจริง
  2. พอขึ้น `active box effect: Crazy` / `PowerUp` / `Madness` / `PowerUpMAX` → กล่องทุกใบ `skip, wanted effect … is running` และไม่ถูกเก็บ
  3. ผลหมด → ต้องเห็น `active box effect: None` แล้วกลับมา `may pick up`
- ถ้าข้อ 3 ไม่ขึ้น `None` ตอนผลหมด (บอทหยุดเก็บกล่องค้างไปเลย) = FAIL, ส่ง log + จอเกมตอนผลหมด

### TC-12 Item Box — ไม่เก็บกล่อง
- ตั้งค่า: ติ๊ก "ไม่เก็บกล่อง"
- ผ่านเมื่อ: ทุกกล่อง `skip, no-box option` และไม่ถูกเก็บ, ไอเท็ม/เงินอื่นยังเก็บตามโหมด

## 4. ส่งผลกลับ

ต่อ test case: PASS/FAIL, เวลาเริ่ม–จบ, บรรทัด log ที่เกี่ยวข้อง (ตัดช่วงเวลา), ภาพจอเกมถ้า FAIL
รวมทั้งไฟล์ `agent.log` ทั้งไฟล์ถ้าไม่แน่ใจว่าต้องตัดตรงไหน
