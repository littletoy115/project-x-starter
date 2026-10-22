#!/usr/bin/env bash
# Pull Klass X Online from the running LDPlayer and dump IL2CPP metadata (class/field offsets).
# Usage: open LDPlayer with the game installed, then: bash tools/dump-game.sh
set -euo pipefail

ADB=/e/LDPlayer/LDPlayer9/adb.exe
PKG=com.klab.klassxonline
ROOT=/e/reverse-bot
APK_DIR=$ROOT/game/apk
EXTRACT=$ROOT/game/extract
OUT=$ROOT/game/il2cpp-dump

"$ADB" start-server >/dev/null
"$ADB" wait-for-device
mkdir -p "$APK_DIR" "$EXTRACT" "$OUT"

# Pull base APK and all split APKs
"$ADB" shell pm path "$PKG" | tr -d '\r' | sed 's/^package://' | while read -r p; do
  echo "pull $p"
  # Git Bash rewrites /data/... into a Windows path; disable that and pass the local path in Windows form
  MSYS_NO_PATHCONV=1 "$ADB" pull "$p" "$(cygpath -w "$APK_DIR/$(basename "$p")")" >/dev/null </dev/null
done

# Extract libil2cpp.so (prefer arm64) and global-metadata.dat from whichever APK has them
for apk in "$APK_DIR"/*.apk; do
  unzip -oq "$apk" 'lib/arm64-v8a/libil2cpp.so' 'lib/x86_64/libil2cpp.so' \
    'assets/bin/Data/Managed/Metadata/global-metadata.dat' -d "$EXTRACT" 2>/dev/null || true
done

SO=$EXTRACT/lib/arm64-v8a/libil2cpp.so
[ -f "$SO" ] || SO=$EXTRACT/lib/x86_64/libil2cpp.so
META=$EXTRACT/assets/bin/Data/Managed/Metadata/global-metadata.dat
[ -f "$SO" ] && [ -f "$META" ] || { echo "libil2cpp.so or global-metadata.dat not found (metadata may be encrypted)"; exit 1; }

DOTNET_ROLL_FORWARD=LatestMajor "$ROOT/tools/il2cppdumper-v39/Il2CppDumper.exe" "$SO" "$META" "$OUT" <<<""
echo "done -> $OUT/dump.cs"
