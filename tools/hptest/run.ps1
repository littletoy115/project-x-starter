# ทดสอบสัญญา record 32 byte ระหว่าง runtime.js (writer) กับ exe ที่ build แล้ว (Class119.smethod_57 parser)
# ใช้: powershell -ExecutionPolicy Bypass -File tools\hptest\run.ps1
$root = Split-Path -Parent (Split-Path -Parent $PSScriptRoot)
$exe  = Join-Path $root "decompiled\src\bin\Release\net472\Capybara-KlassX.exe"
$bin  = Join-Path $env:TEMP "klx_hptest_records.bin"
node (Join-Path $PSScriptRoot "make_records.js") (Join-Path $root "decompiled\src\runtime.js") $bin
if ($LASTEXITCODE -ne 0) { exit 1 }
$m = [Reflection.Assembly]::LoadFrom($exe).GetType("Class119").GetMethod("smethod_57", [Reflection.BindingFlags]"Static,NonPublic,Public")
$bytes = [IO.File]::ReadAllBytes($bin)
$ptr = [Runtime.InteropServices.Marshal]::AllocHGlobal($bytes.Length)
[Runtime.InteropServices.Marshal]::Copy($bytes, 0, $ptr, $bytes.Length)
try { $list = @($m.Invoke($null, @($ptr, $bytes.Length))) } finally { [Runtime.InteropServices.Marshal]::FreeHGlobal($ptr) }
$expect = @(@("boss", 150000, 200000), @("mob@131072", 131072, 140000), @("player", 1234, 5000), @("money(u16)", 4464, 0))
$fail = 0
for ($i = 0; $i -lt $expect.Count; $i++) {
  $r = $list[$i]; $e = $expect[$i]
  $ok = ($r.ushort_2 -eq $e[1]) -and ($r.ushort_3 -eq $e[2])
  if (-not $ok) { $fail++ }
  "{0} {1,-11} kind={2,-3} hp={3}/{4}" -f ($(if ($ok) {"PASS"} else {"FAIL"})), $e[0], $r.byte_0, $r.ushort_2, $r.ushort_3
}
exit $fail
