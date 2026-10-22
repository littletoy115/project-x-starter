"""Print one or more classes from dump.cs (fields + methods with RVA).
Usage: python tools/cls.py ClassName [ClassName ...] [--grep regex]
"""
import re
import sys

DUMP = r"E:\reverse-bot\game\il2cpp-dump\dump.cs"

args = sys.argv[1:]
pat = None
if "--grep" in args:
    i = args.index("--grep")
    pat = re.compile(args[i + 1], re.I)
    args = args[:i] + args[i + 2:]
names = set(args)

with open(DUMP, encoding="utf-8", errors="replace") as f:
    lines = f.read().splitlines()

head = re.compile(r"^(?:\[.*\]\s*)?(?:public|private|internal|protected)?.*?\b(?:class|struct|enum) ([\w.<>`]+)")
i = 0
while i < len(lines):
    m = head.match(lines[i])
    if m and m.group(1) in names:
        j = i
        out = []
        rva = None
        while j < len(lines) and lines[j] != "}":
            s = lines[j]
            r = re.search(r"RVA: (0x[0-9A-F]+)", s)
            if r:
                rva = r.group(1)
            elif s.strip() and not s.strip().startswith(("[", "//")) or j == i:
                line = s.rstrip()
                if "(" in line and rva:
                    line += f"   // RVA {rva}"
                    rva = None
                if pat is None or j == i or pat.search(line):
                    out.append(line)
            j += 1
        print("\n".join(out))
        print()
        i = j
    i += 1
