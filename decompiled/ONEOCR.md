# วาง OneOCR (ตัวอ่านตัวเลข captcha)

ระบบตอบรหัสภาพอัตโนมัติ (`Class351`) ใช้ OneOCR อ่านตัวเลข — ไม่มีไฟล์ = ไม่ตอบ (`auto.log` ขึ้น `OneOCR engine file is missing or truncated`)

## วางที่ไหน

ต้นฉบับเก็บที่ `src\OCR\` — `dotnet build` ก๊อปไปเป็นโฟลเดอร์ `OneOCR` **ข้าง exe** ให้เอง (ตั้งไว้ใน csproj)

```
E:\reverse-bot\decompiled\src\
├── OCR\                      ← ต้นฉบับ (อยู่ใน git บน build-exe)
│   ├── oneocr.dll
│   ├── oneocr.onemodel
│   └── onnxruntime.dll
└── bin\Release\net472\
    ├── Capybara-KlassX.exe
    ├── config\
    └── OneOCR\               ← ที่โปรแกรมอ่านจริง (build สร้างให้)
        ├── oneocr.dll
        ├── oneocr.onemodel
        └── onnxruntime.dll
```

- โปรแกรมหาที่ `OneOCR\` ข้าง exe เท่านั้น (`Class131.smethod_8` = `"OneOCR"`, เช็คไฟล์ใน `Class136.method_1`) — วางไว้แค่ `src\OCR\` แล้วไม่ build = ไม่ตอบ (`OneOCR engine file is missing`)
- ถ้า exe เปิดอยู่ build จะทับ exe ไม่ได้ → ก๊อป 3 ไฟล์จาก `src\OCR\` ไป `bin\Release\net472\OneOCR\` เองได้ ไม่ต้องปิดบอท (เจอ captcha ครั้งถัดไปโหลดใหม่เอง)
- ชื่อไฟล์ต้องตรงตามนี้ แต่ละไฟล์ต้องใหญ่ ≥ 1 MB ไม่งั้นถือว่าไฟล์เสีย
- ใน `OneOCR\` ใส่ **แค่ 3 ไฟล์นี้** — ไฟล์อื่น/โฟลเดอร์ย่อยทำให้ `--test-product-layout` ไม่ผ่าน (csproj ก๊อปแค่ 3 ไฟล์นี้)
- 3 ไฟล์ต้องมาจาก Snipping Tool ชุดเดียวกัน (`onnxruntime.dll` คนละเวอร์ชันกับ `oneocr.dll` อาจโหลดไม่ขึ้น) และต้องเป็น x64
- ย้ายไปรัน exe ที่อื่น → ก๊อปโฟลเดอร์ `OneOCR` ตามไปด้วย

## ทดสอบก่อนเข้าเกม

PowerShell (ไม่ต้อง Run as administrator — `RunAsInvoker` ข้าม UAC สำหรับ self-test; ต้องมี `| Out-String` เพราะ exe เป็น GUI ไม่งั้นไม่เห็นผล):

```powershell
cd E:\reverse-bot\decompiled\src\bin\Release\net472
$env:__COMPAT_LAYER = 'RunAsInvoker'
Get-ChildItem "$env:LOCALAPPDATA\Capybara_Bot\ChallengeCapture" -Recurse -Filter image.png |
  ForEach-Object { .\Capybara-KlassX.exe --test-ocr $_.FullName | Out-String }
```

ภาพที่เก็บไว้ (2026-10-23) มี 6 ภาพ คำตอบที่ถูกคือ `58388`, `77727`, `85596`, `47357`, `99296`, `24229` — อ่านถูกหมด confidence 98–99.6 ใช้เวลาภาพละ ~1.1 วิ ผลที่ดีหน้าตาแบบนี้:

```
test-ocr: text=24229 confidence=98.1234 latency=150ms candidate=24229
```

- `candidate` = ตัวเลขที่บอทจะตอบ, `confidence` ต้อง **≥ 90** บอทถึงจะส่งเอง (ต่ำกว่านั้นปล่อยให้คนตอบ + แจ้ง Discord)

| error ที่เจอ | สาเหตุ |
|---|---|
| `OneOCR engine file is missing or truncated: …` | ชื่อ/ที่วางผิด หรือไฟล์ไม่ครบ (< 1 MB) |
| `could not load …oneocr.dll (WinError 126)` | หา dependency ไม่เจอ — `onnxruntime.dll` ไม่อยู่คู่กัน หรือคนละชุด |
| `could not load …oneocr.dll (WinError 193)` | ไฟล์ไม่ใช่ 64-bit |
| `EntryPointNotFoundException` / `OneOCR: pipeline creation failed` | `oneocr.dll` / `oneocr.onemodel` คนละเวอร์ชันกับที่โค้ดรองรับ |

เครื่องนี้เป็น Windows 10 — ไฟล์ชุดใน `src\OCR\` (Snipping Tool ของ Win11) โหลดบน Win10 ได้ ทดสอบแล้ว 2026-10-23

## ใช้งานจริง

1. ติ๊ก **ตอบรหัสภาพ** (แท็บ Cheat — `checkBox5`, ค่าเริ่มต้นติ๊กไว้)
2. เจอ captcha แล้วดู `%LOCALAPPDATA%\Capybara_Bot\ChallengeCapture\auto.log`

| บรรทัดใน log | ความหมาย |
|---|---|
| `[Challenge] OneOCR pipeline ready` | โหลด OneOCR สำเร็จ (โหลดตอนเจอ captcha ครั้งแรก ไม่ใช่ตอนเปิดโปรแกรม) |
| `auto-answer scheduled id=… digits=… confidence=… delay=…s` | อ่านได้ รอสุ่ม 10–15 วิ แล้วจะส่ง |
| `auto-answer submitting id=… digits=…` | ส่งคำตอบแล้ว → ผลตามมาใน Discord (✅ / ❌) |
| `auto-answer held: confidence … below 90.0 …` | ไม่มั่นใจพอ ไม่ส่ง — ต้องตอบเอง |
| `auto-answer held: checkbox unchecked` | ไม่ได้ติ๊กตอบรหัสภาพ |

- บอทไม่ได้กดปุ่มตัวเลขบนจอ (ที่สลับตำแหน่ง) — ส่งตัวเลขเข้าฟังก์ชันส่งคำตอบของเกมตรง ๆ (`runtime.js` `challenge_answer`)
- ค่าตั้ง (hardcode ใน `Class131`): เกณฑ์ความมั่นใจ 90 (`smethod_4`), หน่วงก่อนส่ง 10–15 วิ (`smethod_6` / `smethod_7`)

## Git

branch `build-exe`: ต้นฉบับ `decompiled/src/OCR/` (3 ไฟล์) **อยู่ใน git** เพื่อให้เครื่องอื่น clone แล้ว build ได้เลย — repo ต้องเป็น private (ไฟล์ของ Microsoft ห้ามเผยแพร่)
ส่วนสำเนาใน `bin/Release/net472/OneOCR/` ยังอยู่ใน `.gitignore` (build สร้างให้เอง)
