# แพ็ก Capybara-KlassX ไปรันเครื่องอื่น: build ลงโฟลเดอร์ใหม่ (ไม่ใช่ bin) แล้ว zip
# - build ใหม่ทั้งโฟลเดอร์ -> ไม่ติดค่าตั้งส่วนตัว (<hero>_Setting.ini, _Path_Setting.ini, *_found.json) ไปด้วย
# - ไม่ทับ exe ใน bin -> รันได้แม้บอทเปิดอยู่
# ใช้: powershell -ExecutionPolicy Bypass -File tools\package\make-dist.ps1
param(
    [string]$OutDir = (Join-Path $PSScriptRoot '..\..\dist')
)
$ErrorActionPreference = 'Stop'

$root = Resolve-Path (Join-Path $PSScriptRoot '..\..')
$proj = Join-Path $root 'decompiled\src\Capybara-KlassX-strings.csproj'
New-Item -ItemType Directory -Force $OutDir | Out-Null
$OutDir = (Resolve-Path $OutDir).Path
$stage = Join-Path $OutDir 'Capybara-KlassX'

if (Test-Path $stage) { Remove-Item -Recurse -Force $stage }
& dotnet build $proj -c Release "-p:OutDir=$stage\" -nologo -v q
if ($LASTEXITCODE -ne 0) { throw "dotnet build failed ($LASTEXITCODE)" }

$required = @(
    'Capybara-KlassX.exe', 'Capybara-KlassX.exe.config', 'Newtonsoft.Json.dll',
    'config\klx.dll', 'config\klxsvc', 'config\offsets.json',
    'OneOCR\oneocr.dll', 'OneOCR\oneocr.onemodel', 'OneOCR\onnxruntime.dll'
)
$missing = $required | Where-Object { -not (Test-Path (Join-Path $stage $_)) }
if ($missing) { throw "missing from build output: $($missing -join ', ') (OneOCR files go in decompiled\src\OCR)" }

Get-ChildItem $stage -Filter *.pdb | Remove-Item -Force

$zip = Join-Path $OutDir ('Capybara-KlassX-' + (Get-Date -Format 'yyyyMMdd-HHmm') + '.zip')
Compress-Archive -Path $stage -DestinationPath $zip -CompressionLevel Optimal
$mb = [math]::Round((Get-Item $zip).Length / 1MB)
Write-Host "folder: $stage"
Write-Host "zip:    $zip ($mb MB)"
