import { md5 } from "@noble/hashes/legacy.js";
import { bytesToHex, hexToBytes } from "@noble/hashes/utils.js";
import { configure, Uint8ArrayReader, Uint8ArrayWriter, ZipReader, ZipWriter } from "@zip.js/zip.js";
import { MAX_FILE_BYTES } from "./shared.js";

configure({ useWebWorkers: false });

export const MAX_EXPANDED_BYTES = 512 * 1024 * 1024;
export const MAX_MAP_BYTES = 64 * 1024 * 1024;
export const MAX_ENTRIES = 2048;
const encoder = new TextEncoder();
const fixedDate = new Date(1982, 0, 24, 10, 23, 0);

function hash(bytes) {
  return bytesToHex(md5(bytes)).toUpperCase();
}

// Same derivation as the desktop tool; this is the format key, not a user's password.
export const archivePassword = hash(encoder.encode(
  "MaybeNissianIncorrect-Off byIncorrect-ToyotaIncorrect",
));

function integrityHash(text) {
  const digest = md5.create();
  const settings = /<([A-Za-z_][A-Za-z0-9_]*)\s+id="\d+"[^>]*>([0-9A-Fa-f]*)<\/\1>/g;
  let count = 0;
  for (const match of text.matchAll(settings)) {
    if (match[2].length % 2 !== 0) {
      throw new Error("The map contains an invalid setting. No download was created.");
    }
    digest.update(hexToBytes(match[2]));
    count++;
  }
  if (count === 0) throw new Error("No supported map settings were found.");
  return bytesToHex(digest.digest()).toUpperCase();
}

function requiredField(text, pattern, label) {
  const matches = [...text.matchAll(pattern)];
  if (matches.length !== 1) {
    throw new Error(`Unsupported map: expected one ${label} field. No download was created.`);
  }
  return matches[0][2];
}

export function unlockMapXml(bytes) {
  if (bytes.length > MAX_MAP_BYTES) throw new Error("The map XML exceeds the 64 MB processing limit.");
  const hadBom = bytes[0] === 0xef && bytes[1] === 0xbb && bytes[2] === 0xbf;
  let text = new TextDecoder("utf-8", { fatal: true }).decode(bytes);
  const protectedPattern = /(<IsProtected id="8" attrId="0">)([0-9A-Fa-f]{2})(<\/IsProtected>)/g;
  const passwordPattern = /(<Password id="1503" attrId="0">)([0-9A-Fa-f]{32})(<\/Password>)/g;
  const bitmapPattern = /(<G id="9496" attrId="0">)([0-9A-Fa-f]{8192})(<\/G>)/g;
  const md5Pattern = /(<MD5>)([0-9A-Fa-f]{64})(<\/MD5>)/g;
  const protectedValue = requiredField(text, protectedPattern, "protection");
  requiredField(text, passwordPattern, "password");
  requiredField(text, bitmapPattern, "protection bitmap");
  const originalHash = requiredField(text, md5Pattern, "integrity");
  const expectedHash = bytesToHex(encoder.encode(integrityHash(text))).toUpperCase();
  if (originalHash.toUpperCase() !== expectedHash) {
    throw new Error("The map integrity check failed. The file may be damaged or unsupported.");
  }

  text = text.replace(protectedPattern, (_, start, _value, end) => `${start}00${end}`);
  text = text.replace(passwordPattern, (_, start, _value, end) => `${start}${"0".repeat(32)}${end}`);
  text = text.replace(bitmapPattern, (_, start, value, end) => `${start}${"0".repeat(value.length)}${end}`);
  const integrity = bytesToHex(encoder.encode(integrityHash(text))).toUpperCase();
  text = text.replace(md5Pattern, (_, start, _value, end) => `${start}${integrity}${end}`);
  const body = encoder.encode(text);
  if (!hadBom) return { data: body, wasProtected: protectedValue !== "00" };
  const data = new Uint8Array(body.length + 3);
  data.set([0xef, 0xbb, 0xbf]);
  data.set(body, 3);
  return { data, wasProtected: protectedValue !== "00" };
}

async function extractEntry(entry, limit, onprogress) {
  const chunks = [];
  let size = 0;
  await entry.getData(new WritableStream({
    write(chunk) {
      size += chunk.length;
      if (size > limit || size > entry.uncompressedSize) {
        throw new Error("The archive exceeded its declared size or the processing limit.");
      }
      chunks.push(chunk);
    },
  }), { password: archivePassword, checkSignature: true, onprogress });
  if (size !== entry.uncompressedSize) throw new Error("The archive contains an incomplete entry.");
  const data = new Uint8Array(size);
  let offset = 0;
  for (const chunk of chunks) {
    data.set(chunk, offset);
    offset += chunk.length;
  }
  return data;
}

export async function unlockArchive(bytes, onProgress = () => {}) {
  if (!(bytes instanceof Uint8Array) || bytes.length === 0) throw new Error("Choose a non-empty .nexmap file.");
  if (bytes.length > MAX_FILE_BYTES) throw new Error("The file exceeds the 128 MB limit.");
  const reader = new ZipReader(new Uint8ArrayReader(bytes));
  try {
    const entries = [];
    const names = new Set();
    let expanded = 0;
    for await (const entry of reader.getEntriesGenerator()) {
      if (entries.length >= MAX_ENTRIES) throw new Error("The archive has too many entries (maximum 2,048).");
      if (names.has(entry.filename)) throw new Error("The archive contains duplicate entry names.");
      names.add(entry.filename);
      if (!Number.isSafeInteger(entry.uncompressedSize) || entry.uncompressedSize < 0) {
        throw new Error("The archive has an invalid entry size.");
      }
      expanded += entry.uncompressedSize;
      if (expanded > MAX_EXPANDED_BYTES) throw new Error("The expanded archive exceeds the 512 MB limit.");
      entries.push(entry);
    }
    const map = entries.find((entry) => entry.filename === "_map" && !entry.directory);
    if (!map) throw new Error("This is not a supported .nexmap file: the _map entry is missing.");
    if (map.uncompressedSize > MAX_MAP_BYTES) throw new Error("The map XML exceeds the 64 MB processing limit.");

    onProgress({ percent: 5, message: "Checking map integrity…" });
    const result = unlockMapXml(await extractEntry(map, MAX_MAP_BYTES));
    const writer = new ZipWriter(new Uint8ArrayWriter(), {
      password: archivePassword,
      encryptionStrength: 3,
      lastModDate: fixedDate,
      creationDate: fixedDate,
      lastAccessDate: fixedDate,
      extendedTimestamp: true,
      level: 6,
    });
    let processed = 0;
    for (const entry of entries) {
      const progress = (current = 0) => onProgress({
        percent: Math.min(94, 10 + Math.round(84 * (processed + current) / Math.max(expanded, 1))),
        message: "Rebuilding your unlocked map…",
      });
      if (entry.directory) {
        await writer.add(entry.filename, undefined, { directory: true });
      } else {
        const data = entry === map ? result.data : await extractEntry(entry, MAX_EXPANDED_BYTES, progress);
        await writer.add(entry.filename, new Uint8ArrayReader(data));
      }
      processed += entry.uncompressedSize;
      progress();
    }
    onProgress({ percent: 96, message: "Preparing your download…" });
    const data = await writer.close();
    onProgress({ percent: 100, message: "Your map is ready." });
    return { data, wasProtected: result.wasProtected };
  } finally {
    await reader.close();
  }
}
