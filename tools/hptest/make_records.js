// ดึง record writer + บรรทัดแพตช์ u32 จาก runtime.js ตัวที่ฝังใน exe จริง แล้วเขียน record ทดสอบ
const fs = require("fs");
const src = fs.readFileSync(process.argv[2], "utf8");
const fn = src.match(/function _0x4c8df9\([^)]*\) \{[\s\S]*?\n  \}/)[0];
const write = new Function(fn + "; return _0x4c8df9;")();
// บรรทัดแพตช์ที่อยู่หลัง call ของมอนในไฟล์จริง
const patch = src.match(/\/\/ mob HP เป็น u32[^\n]*\n(\s*_0x14d5ae\.setUint32\(_0x5cc447 \+ 6[^\n]*\n\s*_0x14d5ae\.setUint32\(_0x5cc447 \+ 28[^\n]*)/)[1];
const applyMobPatch = new Function("_0x14d5ae", "_0x5cc447", "_0x1781d5", "_0x4dbb8b", patch);
const buf = new ArrayBuffer(32 * 4), dv = new DataView(buf);
// boss: kind 2, flags bit1, now 150000, max 200000, lv 55
write(dv, 0, 2, 2, 11, 22, 150000, 200000, 55, 1001, 1, 2, 3, 0, 0, 0); applyMobPatch(dv, 0, 150000, 200000);
// mob: now 131072 (ของเดิมจะอ่านได้ 0), max 140000
write(dv, 32, 2, 0, 33, 44, 131072, 140000, 40, 1002, 4, 5, 6, 0, 0, 0); applyMobPatch(dv, 32, 131072, 140000);
// player: kind 100, flags self, hp 1234/5000, partyId 7, school 1, class 3
write(dv, 64, 100, 4, 0, 0, 1234, 5000, 80, 77, 7, 8, 9, 7, 1, 3);
// money: kind 102, amount 70000 (ยังเป็น u16)
write(dv, 96, 102, 0, 0, 0, 70000, 0, 0, 555, 1, 1, 1, 0, 0, 0);
fs.writeFileSync(process.argv[3], Buffer.from(buf));
console.log("wrote", buf.byteLength, "bytes");
