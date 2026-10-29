import { createHash } from "node:crypto";
import { Uint8ArrayReader, Uint8ArrayWriter, ZipReader, ZipWriter } from "@zip.js/zip.js";
import { archivePassword } from "../src/unlock.js";

export const encode = (text) => new TextEncoder().encode(text);

export function mapXml({ protectedMap = true, bom = false } = {}) {
  const flag = protectedMap ? "01" : "00";
  const password = (protectedMap ? "F" : "0").repeat(32);
  const bitmap = (protectedMap ? "A" : "0").repeat(8192);
  const settings = `<IsProtected id="8" attrId="0">${flag}</IsProtected>\r\n` +
    `<Password id="1503" attrId="0">${password}</Password>\r\n` +
    `<G id="9496" attrId="0">${bitmap}</G>\r\n` +
    '<Fuel id="99" attrId="0">1234ABCD</Fuel>';
  const digest = createHash("md5").update(Buffer.from(flag + password + bitmap + "1234ABCD", "hex"))
    .digest("hex").toUpperCase();
  const integrity = Buffer.from(digest).toString("hex").toUpperCase();
  return encode(`${bom ? "\ufeff" : ""}<?xml version="1.0" encoding="utf-8"?>\r\n<Template>\r\n<MD5>${integrity}</MD5>\r\n<Data>\r\n${settings}\r\n</Data>\r\n</Template>`);
}

export async function makeArchive(entries = [["_map", mapXml()], ["resources/test.bin", new Uint8Array([0, 1, 255, 7])]]) {
  const writer = new ZipWriter(new Uint8ArrayWriter(), {
    password: archivePassword, encryptionStrength: 3, useWebWorkers: false,
  });
  for (const [name, data] of entries) await writer.add(name, new Uint8ArrayReader(data));
  return writer.close();
}

export async function readArchive(bytes) {
  const reader = new ZipReader(new Uint8ArrayReader(bytes));
  try {
    const result = new Map();
    for (const entry of await reader.getEntries()) {
      result.set(entry.filename, {
        data: entry.directory ? new Uint8Array() : await entry.getData(new Uint8ArrayWriter(), {
          password: archivePassword, checkSignature: true,
        }),
        encrypted: entry.encrypted,
      });
    }
    return result;
  } finally {
    await reader.close();
  }
}
