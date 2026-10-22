"""Build config/offsets.json from the il2cpp dump (replaces the table the license server used to send).

Usage: python tools/offsets/resolve.py [--write]

Keys come from Class357.cs (the server key -> runtime key tables). Values:
  Addr_Function_<Class>_<Method>[_<argtypes>]  -> method RVA from game/il2cpp-dump/dump.cs
  Addr_TypeInfo_<Class>                        -> <Class>_TypeInfo address from script.json
  Addr_Native_*                                -> code in libunity.so, not in the dump (left out)
Overloads are picked by the argument count runtime.js passes to NativeFunction
(IL2CPP adds `this` for instance methods and a trailing MethodInfo*).
"""
import json
import re
import sys
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]
DUMP = ROOT / "game/il2cpp-dump/dump.cs"
SCRIPT = ROOT / "game/il2cpp-dump/script.json"
CLASS357 = ROOT / "decompiled/src/Class357.cs"
RUNTIME = ROOT / "decompiled/js/out/deobfuscated.js"
OUT = ROOT / "config/offsets.json"

# required keys that are not RVAs (from the APK; see NOTES.md)
FIXED = {
    "KlassX_Build_VersionCode": "33",
    "KlassX_Build_UnityVersion": "6000.3.8f1",
}
# the three hook RVAs verified live (OFFSETS.md) — still re-resolved below as a cross-check
REQUIRED_HOOKS = {
    "Addr_Function_PlayerHandler_Update": ("PlayerHandler", "Update"),
    "Addr_Function_PlayerController_FrameMove": ("PlayerController", "FrameMove"),
    "Addr_Function_OnManualMovement": ("PlayerController", "OnManualMovement"),
}
# TypeInfo names that are not "<Class>_TypeInfo" in the global namespace
TYPEINFO_NAMES = {
    "Vector3Array": "UnityEngine.Vector3[]",
    "ColorArray": "UnityEngine.Color[]",
    "Int32Array": "int[]",
    "Image": "UnityEngine.UI.Image",
}
TYPE_ALIASES = {"string": "string", "int": "int", "shader": "Shader"}


def server_keys():
    text = CLASS357.read_text(encoding="utf-8-sig")
    pairs = re.findall(r'\("((?:Addr)_[A-Za-z0-9_]+)", "([A-Za-z0-9]+)"\)', text)
    return dict(pairs)  # server key -> runtime key


def js_signatures():
    """runtime key -> argument type list runtime.js passes to NativeFunction."""
    text = RUNTIME.read_text(encoding="utf-8")
    out = {}
    for m in re.finditer(r'NativeFunction\(\w+\.add\(\w+\.(\w+)\), "[^"]+", \[([^\]]*)\]', text):
        out[m.group(1)] = [a.strip().strip('"') for a in m.group(2).split(",") if a.strip()]
    return out


# NativeFunction scalar types -> C# parameter types they can carry
JS_SCALAR = {"uint8": {"byte", "bool"}, "int8": {"sbyte"}, "uint16": {"ushort"}, "int16": {"short"},
             "int": {"int"}, "int32": {"int"}, "uint32": {"uint"}, "uint": {"uint"}, "float": {"float"},
             "double": {"double"}, "bool": {"bool"}}


def sig_matches(method, js_args):
    name, plist, static, rva = method
    if len(plist) + (0 if static else 1) + 1 != len(js_args):
        return False
    params_js = js_args[(0 if static else 1):-1]
    for p, j in zip(plist, params_js):
        if j in JS_SCALAR and param_type(p) not in JS_SCALAR[j]:
            return False
    return True


def parse_dump():
    classes = {}  # simple name -> list of (namespace, [(name, params, static, rva)])
    ns = ""
    cur = None
    rva = None
    head = re.compile(r"^(?:\w+ )*(?:class|struct|interface) ([\w.`<>,]+)")
    meth = re.compile(r"^\t(?:\[.*\] )?((?:\w+ )*)([\w<>\[\],.`?]+(?:<[^>]*>)?) ([\w.<>`|]+)\((.*)\)(?: \{ \})?$")
    with open(DUMP, encoding="utf-8", errors="replace") as f:
        for line in f:
            line = line.rstrip("\n")
            if line.startswith("// Namespace: "):
                ns = line[len("// Namespace: "):].strip()
                continue
            m = head.match(line)
            if m and not line.startswith("\t"):
                cur = []
                classes.setdefault(m.group(1), []).append((ns, cur))
                rva = None
                continue
            r = re.match(r"^\t// RVA: (0x[0-9A-F]+)", line)
            if r:
                rva = r.group(1)
                continue
            if cur is not None and rva:
                mm = meth.match(line)
                if mm:
                    mods, _ret, name, params = mm.groups()
                    plist = [p.strip() for p in params.split(",") if p.strip()] if params.strip() else []
                    cur.append((name, plist, "static" in mods.split(), rva))
                    rva = None
    return classes


def param_type(p):
    toks = [t for t in p.split() if t not in ("ref", "out", "in", "params")]
    return toks[0] if toks else ""


def pick_class(classes, cname, want_method):
    cands = classes.get(cname, [])
    with_m = [(ns, ms) for ns, ms in cands if any(n == want_method or n.startswith(want_method) for n, *_ in ms)]
    pool = with_m or cands
    for pref in ("", "UnityEngine"):
        hit = [c for c in pool if c[0] == pref]
        if len(hit) == 1:
            return hit[0]
    return pool[0] if len(pool) == 1 else None


def resolve_function(classes, rest, js_args):
    parts = rest.split("_")
    tried = []
    for i in range(1, len(parts)):
        cname, mpart = "_".join(parts[:i]), "_".join(parts[i:])
        if cname not in classes:
            continue
        # method name + optional trailing argument types
        mparts = mpart.split("_")
        for j in range(len(mparts), 0, -1):
            mname = "_".join(mparts[:j])
            types = [t.lower() for t in mparts[j:]]
            real = ".ctor" if mname == "ctor" else mname
            picked = pick_class(classes, cname, real)
            if picked is None:
                tried.append(f"{cname}: ambiguous class")
                continue
            ns, methods = picked
            hits = [m for m in methods if m[0] == real]
            if not hits:
                continue
            if types:
                hits = [m for m in hits if [param_type(p).lower() for p in m[1]] == types]
            if len(hits) > 1 and js_args is not None:
                hits = [m for m in hits if sig_matches(m, js_args)]
            if len(hits) == 1:
                name, plist, static, rva = hits[0]
                return rva, f"{ns + '.' if ns else ''}{cname}.{name}({', '.join(plist)}){' static' if static else ''}"
            tried.append(f"{cname}.{real}: {len(hits)} matches")
    return None, "; ".join(tried) or "class not found"


def main():
    keys = server_keys()
    sigs = js_signatures()
    classes = parse_dump()
    meta = json.load(open(SCRIPT, encoding="utf-8"))["ScriptMetadata"]
    typeinfo = {x["Name"]: x["Address"] for x in meta}

    result = dict(FIXED)
    report = []
    for skey in list(REQUIRED_HOOKS) + sorted(keys):
        rkey = keys.get(skey, "")
        if skey in result:
            continue
        if skey in REQUIRED_HOOKS:
            cname, mname = REQUIRED_HOOKS[skey]
            rva, info = resolve_function(classes, f"{cname}_{mname}", None)
        elif skey.startswith("Addr_Function_"):
            rva, info = resolve_function(classes, skey[len("Addr_Function_"):], sigs.get(rkey))
        elif skey.startswith("Addr_TypeInfo_"):
            short = skey[len("Addr_TypeInfo_"):]
            name = TYPEINFO_NAMES.get(short, short) + "_TypeInfo"
            addr = typeinfo.get(name)
            rva, info = (hex(addr).upper().replace("0X", "0x"), name) if addr else (None, f"{name} not in script.json")
        else:
            rva, info = None, "native (libunity.so) - not in the il2cpp dump"
        if rva:
            result[skey] = rva
        report.append((skey, rkey, rva or "-", info))

    w = max(len(r[0]) for r in report)
    for skey, rkey, rva, info in report:
        print(f"{skey:<{w}}  {rva:>10}  {info}")
    missing = [r[0] for r in report if r[2] == "-"]
    print(f"\nresolved {len(result) - len(FIXED)} / {len(report)}; missing: {', '.join(missing) or 'none'}")

    if "--write" in sys.argv:
        OUT.write_text(json.dumps(result, indent=2) + "\n", encoding="utf-8")
        print("wrote", OUT)


if __name__ == "__main__":
    main()
