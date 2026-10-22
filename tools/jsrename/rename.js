// Heuristic renamer for the webcrack output of runtime.js.
// Usage: node rename.js <in.js> <out.js>
const fs = require("fs");
const parser = require("@babel/parser");
const traverse = require("@babel/traverse").default;
const generate = require("@babel/generator").default;
const t = require("@babel/types");

const [, , inFile, outFile] = process.argv;
const ast = parser.parse(fs.readFileSync(inFile, "utf8"), { sourceType: "script" });

// Offset-key arrays: name them after the feature they configure (keyed by a distinctive entry).
const KEY_GROUPS = {
  module: "KEYS_CORE", rvaMeshCtor: "KEYS_MESH", rvaW2sPoint: "KEYS_WORLD_TO_SCREEN",
  rvaFogSettings: "KEYS_FOG", rvaZoomUpdate: "KEYS_ZOOM", tiRadarVector3Array: "KEYS_RADAR",
  rvaSlotAnchor: "KEYS_QUICKSLOT", rvaAtkSetTarget: "KEYS_ATTACK", rvaSkillBarAnchor: "KEYS_SKILL",
  rvaPickSend: "KEYS_PICKUP", rvaNpcSaleRequest: "KEYS_NPC_SALE", rvaRecallCardRequest: "KEYS_RECALL",
  rvaFriendMoveRequest: "KEYS_FRIEND_WARP", rvaMaterialSetRenderQueue: "KEYS_MATERIAL",
  rvaGetComponentsInternal: "KEYS_QBOX", tiGameDataManager: "KEYS_CHAR_SELECT",
  rvaSwitchToTab: "KEYS_SKILL_TAB", rvaBagGetItemObject: "KEYS_INVENTORY",
  rvaChallengeIncoming: "KEYS_BOT_CHALLENGE", tiMultiSceneHelper: "KEYS_SCENE_LOADER",
  rvaIsGenuinelyDead: "KEYS_REBIRTH", tiClient: "KEYS_CLIENT", tiCharacterFriendManager: "KEYS_FRIENDS",
  tiPartyManager: "KEYS_PARTY", targetCrowType: "KEYS_OPTIONAL", rvaPetGiveFood: "KEYS_PET",
};
const READS = /^read(U8|S8|U16|S16|U32|S32|U64|S64|Float|Double|Pointer|Utf8String|Utf16String|CString|ByteArray)$/;
const isMangled = n => /^_0x[0-9a-f]+$/.test(n);

const offsetKeys = new Set();
const proposals = new Map(); // binding -> name

function propose(binding, name) {
  if (!binding || !isMangled(binding.identifier.name) || proposals.has(binding)) return;
  proposals.set(binding, name);
}

// Pass 1: key arrays
traverse(ast, {
  VariableDeclarator(p) {
    const init = p.node.init;
    if (!t.isIdentifier(p.node.id) || !t.isArrayExpression(init) || init.elements.length === 0) return;
    if (!init.elements.every(e => t.isStringLiteral(e) && /^[a-z][A-Za-z0-9]+$/.test(e.value))) return;
    const vals = init.elements.map(e => e.value);
    const hit = vals.find(v => KEY_GROUPS[v]);
    if (!hit && !vals.some(v => /^(rva|ti)[A-Z]/.test(v))) return;
    vals.forEach(v => offsetKeys.add(v));
    propose(p.scope.getBinding(p.node.id.name), hit ? KEY_GROUPS[hit] : "KEYS_" + vals[0]);
  },
});

// Returns the offset key in `X.key` or `X.key + n`, recording X as an offsets object.
function offsetKeyOf(node, scope) {
  let m = node;
  let suffix = "";
  if (t.isBinaryExpression(m, { operator: "+" }) && t.isNumericLiteral(m.right)) {
    suffix = "_" + m.right.value;
    m = m.left;
  }
  if (t.isMemberExpression(m) && !m.computed && t.isIdentifier(m.object) && t.isIdentifier(m.property) && offsetKeys.has(m.property.name)) {
    propose(scope.getBinding(m.object.name), "off");
    return m.property.name + suffix;
  }
  return null;
}

// Name for an expression like base.add(off.key).readX() or base.add(off.key)
function nameFromRead(expr, scope) {
  if (!t.isCallExpression(expr) || !t.isMemberExpression(expr.callee)) return null;
  const prop = expr.callee.property;
  if (t.isIdentifier(prop) && READS.test(prop.name)) {
    const inner = expr.callee.object;
    if (t.isCallExpression(inner) && t.isMemberExpression(inner.callee) && t.isIdentifier(inner.callee.property, { name: "add" }) && inner.arguments.length === 1) {
      const k = offsetKeyOf(inner.arguments[0], scope);
      if (k) return prop.name === "readPointer" ? k + "Ptr" : k;
    }
    return null;
  }
  if (t.isIdentifier(prop, { name: "add" }) && expr.arguments.length === 1) {
    const k = offsetKeyOf(expr.arguments[0], scope);
    if (k) return k + "Addr";
  }
  return null;
}

// Pass 2: values read from game memory, Interceptor hook args, offsets objects
traverse(ast, {
  VariableDeclarator(p) {
    if (!t.isIdentifier(p.node.id) || !p.node.init) return;
    const n = nameFromRead(p.node.init, p.scope);
    if (n) propose(p.scope.getBinding(p.node.id.name), n);
  },
  AssignmentExpression(p) {
    if (p.node.operator !== "=" || !t.isIdentifier(p.node.left)) return;
    const n = nameFromRead(p.node.right, p.scope);
    if (n) propose(p.scope.getBinding(p.node.left.name), n);
  },
  MemberExpression(p) {
    // anything indexed with an offset key is an offsets object
    if (!p.node.computed && t.isIdentifier(p.node.object) && t.isIdentifier(p.node.property) && offsetKeys.has(p.node.property.name) && !t.isObjectProperty(p.parent)) {
      propose(p.scope.getBinding(p.node.object.name), "off");
    }
  },
  ObjectMethod(p) {
    // Interceptor.attach(..., { onEnter(args) / onLeave(retval) })
    const k = p.node.key && p.node.key.name;
    const param = p.node.params[0];
    if (!t.isIdentifier(param)) return;
    if (k === "onEnter") propose(p.scope.getBinding(param.name), "args");
    if (k === "onLeave") propose(p.scope.getBinding(param.name), "retval");
  },
});

// Pass 3: apply, keeping names unique within each scope chain
let count = 0;
for (const [binding, base] of proposals) {
  const scope = binding.scope;
  let name = base;
  for (let i = 2; scope.hasBinding(name) || scope.hasGlobal(name) || scope.hasReference(name) || t.isReservedWord?.(name); i++) name = base + i;
  scope.rename(binding.identifier.name, name);
  count++;
}

fs.writeFileSync(outFile, generate(ast, { retainLines: false, comments: true }).code);
console.log(`offset keys: ${offsetKeys.size}, renamed bindings: ${count}`);
