import assert from "node:assert/strict";
import { readFile } from "node:fs/promises";
import test from "node:test";
import { MAX_ENTRIES, MAX_MAP_BYTES, unlockArchive, unlockMapXml } from "../src/unlock.js";
import { MAX_FILE_BYTES, outputName } from "../src/shared.js";
import { encode, makeArchive, mapXml, readArchive } from "./helpers.js";

for (const bom of [false, true]) {
  test(`matches independent unprotected XML exactly (BOM=${bom})`, () => {
    const result = unlockMapXml(mapXml({ bom }));
    assert.equal(result.wasProtected, true);
    assert.deepEqual(result.data, mapXml({ bom, protectedMap: false }));
    assert.deepEqual(unlockMapXml(result.data), { data: result.data, wasProtected: false });
  });
}

test("rebuilds authenticated AES archives and preserves non-map contents", async () => {
  const original = await makeArchive();
  const progress = [];
  const result = await unlockArchive(original, (value) => progress.push(value.percent));
  assert.equal(result.wasProtected, true);
  const before = await readArchive(original);
  const after = await readArchive(result.data);
  assert.deepEqual([...after.keys()], [...before.keys()]);
  assert.deepEqual(after.get("_map").data, mapXml({ protectedMap: false }));
  assert.deepEqual(after.get("resources/test.bin").data, before.get("resources/test.bin").data);
  assert.ok([...after.values()].every((entry) => entry.encrypted));
  assert.equal(progress.at(-1), 100);
  assert.ok(progress.every((value, i) => i === 0 || value >= progress[i - 1]));
});

test("preserves directory entries", async () => {
  const source = await makeArchive([["_map", mapXml()], ["resources/", new Uint8Array()]]);
  const result = await readArchive((await unlockArchive(source)).data);
  assert.ok(result.has("resources/"));
});

test("rejects empty, non-ZIP, missing-map and truncated archives", async () => {
  await assert.rejects(unlockArchive(new Uint8Array()), /non-empty/);
  await assert.rejects(unlockArchive(encode("not a zip")));
  await assert.rejects(unlockArchive(await makeArchive([["other", encode("hello")]])), /_map.*missing/);
  const archive = await makeArchive();
  await assert.rejects(unlockArchive(archive.slice(0, 50)));
});

test("rejects missing or duplicated protection fields and damaged integrity", () => {
  const xml = new TextDecoder().decode(mapXml());
  assert.throws(() => unlockMapXml(encode(xml.replace(/<Password.*?<\/Password>/, ""))), /password field/);
  assert.throws(() => unlockMapXml(encode(xml.replace("</Data>", '<IsProtected id="8" attrId="0">01</IsProtected></Data>'))), /protection field/);
  assert.throws(() => unlockMapXml(encode(xml.replace("1234ABCD", "1234ABCE"))), /integrity check failed/);
  assert.throws(() => unlockMapXml(encode(xml.replace("1234ABCD", "123"))), /invalid setting/);
  assert.throws(() => unlockMapXml(new Uint8Array([0xff])), /encoded data/);
});

test("enforces input, XML, entry-count and expanded-size limits", async () => {
  await assert.rejects(unlockArchive(new Uint8Array(MAX_FILE_BYTES + 1)), /128 MB/);
  assert.throws(() => unlockMapXml(new Uint8Array(MAX_MAP_BYTES + 1)), /64 MB/);
  const archive = await makeArchive();
  const patched = archive.slice();
  const view = new DataView(patched.buffer);
  for (let i = 0; i < patched.length - 46; i++) {
    if (view.getUint32(i, true) === 0x02014b50) {
      view.setUint32(i + 24, 513 * 1024 * 1024, true);
      break;
    }
  }
  await assert.rejects(unlockArchive(patched), /512 MB/);
  const manyEntries = Array.from({ length: MAX_ENTRIES + 1 }, (_, i) => [`file${i}`, new Uint8Array()]);
  await assert.rejects(unlockArchive(await makeArchive(manyEntries)), /too many entries/);
});

test("rejects forged sizes during extraction, not just metadata checks", async () => {
  const patched = (await makeArchive()).slice();
  const view = new DataView(patched.buffer);
  for (let i = 0; i < patched.length - 46; i++) {
    if (view.getUint32(i, true) === 0x02014b50) {
      view.setUint32(i + 24, 1, true);
      break;
    }
  }
  await assert.rejects(unlockArchive(patched), /size|limit/i);
});

test("rejects duplicate names and tampered encrypted content", async () => {
  const duplicate = (await makeArchive([["_map", mapXml()], ["blob", encode("hello")]])).slice();
  const view = new DataView(duplicate.buffer);
  for (let i = 0; i < duplicate.length - 50; i++) {
    if (view.getUint32(i, true) === 0x02014b50 &&
        new TextDecoder().decode(duplicate.subarray(i + 46, i + 50)) === "blob") {
      duplicate.set(encode("_map"), i + 46);
      break;
    }
  }
  await assert.rejects(unlockArchive(duplicate), /duplicate entry names/);
  const tampered = (await makeArchive()).slice();
  const localHeader = new DataView(tampered.buffer);
  const dataOffset = 30 + localHeader.getUint16(26, true) + localHeader.getUint16(28, true);
  tampered[dataOffset + 18] ^= 0xff;
  await assert.rejects(unlockArchive(tampered));
});

test("creates copy filenames without changing the original extension casing rules", () => {
  assert.equal(outputName("My map.NEXMAP"), "My map (unlocked).nexmap");
  assert.equal(outputName("fuel.v2.nexmap"), "fuel.v2 (unlocked).nexmap");
});

test("matches the genuine unprotected map pair byte-for-byte after decryption", async (t) => {
  let protectedBytes;
  let referenceBytes;
  try {
    protectedBytes = new Uint8Array(await readFile(new URL("../../password.nexHondaEP3-1-36-2.nexmap", import.meta.url)));
    referenceBytes = new Uint8Array(await readFile(new URL("../../no password.nexHondaEP3-1-36-2.nexmap", import.meta.url)));
  } catch (error) {
    if (error.code !== "ENOENT") throw error;
    t.skip("Optional owner-supplied map pair is not present in this checkout.");
    return;
  }
  const result = await unlockArchive(protectedBytes);
  assert.equal(result.wasProtected, true);
  const actual = await readArchive(result.data);
  const expected = await readArchive(referenceBytes);
  assert.deepEqual([...actual.keys()].sort(), [...expected.keys()].sort());
  for (const [name, entry] of expected) assert.deepEqual(actual.get(name).data, entry.data, name);
});
