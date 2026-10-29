import { expect, test } from "@playwright/test";
import { readFile } from "node:fs/promises";
import { makeArchive, readArchive, mapXml } from "../helpers.js";

test("unlocks locally, downloads a valid copy and allows a second download", async ({ page }) => {
  const requests = [];
  const errors = [];
  page.on("request", (request) => requests.push({ url: request.url(), method: request.method() }));
  page.on("pageerror", (error) => errors.push(error.message));
  await page.goto("/");
  await expect(page.getByRole("button", { name: "Unlock & download" })).toBeDisabled();
  const original = await makeArchive();
  await page.locator("#file-input").setInputFiles({
    name: "My calibration.nexmap", mimeType: "application/octet-stream", buffer: Buffer.from(original),
  });
  await expect(page.getByRole("button", { name: "Unlock & download" })).toBeDisabled();
  await page.getByLabel("I own this map").check();
  const downloadPromise = page.waitForEvent("download");
  await page.getByRole("button", { name: "Unlock & download" }).click();
  const download = await downloadPromise;
  expect(download.suggestedFilename()).toBe("My calibration (unlocked).nexmap");
  const stream = await download.createReadStream();
  const chunks = [];
  for await (const chunk of stream) chunks.push(chunk);
  const result = await readArchive(new Uint8Array(Buffer.concat(chunks)));
  expect(result.get("_map").data).toEqual(mapXml({ protectedMap: false }));
  await expect(page.getByRole("status")).toContainText("Unlocked.");
  const repeatPromise = page.waitForEvent("download");
  await page.getByRole("link", { name: /Download unlocked map again/ }).click();
  await repeatPromise;
  expect(errors).toEqual([]);
  expect(requests.every(({ url, method }) => method === "GET" && new URL(url).origin === "http://127.0.0.1:4173")).toBe(true);
});

test("reports invalid files without offering a download", async ({ page }) => {
  await page.goto("/");
  await page.locator("#file-input").setInputFiles({ name: "test.txt", mimeType: "text/plain", buffer: Buffer.from("wrong") });
  await expect(page.getByRole("status")).toContainText("choose a .nexmap");
  await page.locator("#file-input").setInputFiles({ name: "bad.nexmap", mimeType: "application/octet-stream", buffer: Buffer.from("not a zip") });
  await page.getByLabel("I own this map").check();
  await page.getByRole("button", { name: "Unlock & download" }).click();
  await expect(page.getByRole("status")).toContainText("Unable to unlock this file");
  await expect(page.locator("#download-again")).toBeHidden();
});

test("handles already-unlocked files honestly", async ({ page }) => {
  await page.goto("/");
  await page.locator("#file-input").setInputFiles({
    name: "open.nexmap", mimeType: "application/octet-stream",
    buffer: Buffer.from(await makeArchive([["_map", mapXml({ protectedMap: false })]])),
  });
  await page.getByLabel("I own this map").check();
  const download = page.waitForEvent("download");
  await page.getByRole("button", { name: "Unlock & download" }).click();
  await download;
  await expect(page.getByRole("status")).toContainText("already unlocked");
});

test("cancels work and permits retrying", async ({ page }) => {
  await page.goto("/");
  await page.locator("#file-input").setInputFiles({
    name: "map.nexmap", mimeType: "application/octet-stream", buffer: Buffer.from(await makeArchive()),
  });
  await page.getByLabel("I own this map").check();
  await page.evaluate(() => {
    document.getElementById("unlock-button").click();
    document.getElementById("cancel-button").click();
  });
  await expect(page.getByRole("status")).toContainText("cancelled");
  await expect(page.getByRole("button", { name: "Unlock & download" })).toBeEnabled();
  await expect(page.locator("#download-again")).toBeHidden();
});

test("accepts file drops and is usable at mobile and desktop widths", async ({ page }, testInfo) => {
  await page.goto("/");
  const bytes = Array.from(await makeArchive());
  await page.evaluate((data) => {
    const transfer = new DataTransfer();
    transfer.items.add(new File([new Uint8Array(data)], "dropped.nexmap"));
    document.getElementById("drop-zone").dispatchEvent(new DragEvent("drop", { bubbles: true, dataTransfer: transfer }));
  }, bytes);
  await expect(page.locator("#file-name")).toHaveText("dropped.nexmap");
  for (const width of [360, 390, 768, 1440]) {
    await page.setViewportSize({ width, height: 900 });
    expect(await page.evaluate(() => document.documentElement.scrollWidth <= innerWidth)).toBe(true);
    await expect(page.getByRole("button", { name: "Unlock & download" })).toBeVisible();
    if (width === 390 || width === 1440) {
      await page.screenshot({ path: testInfo.outputPath(`layout-${width}.png`), fullPage: true });
    }
  }
  await page.getByRole("button", { name: "Remove selected file" }).click();
  await expect(page.locator("#file-panel")).toBeHidden();
});

test("downloads the genuine map with every entry matching its unlocked reference", async ({ page }) => {
  let protectedBytes;
  let referenceBytes;
  try {
    protectedBytes = await readFile(new URL("../../../password.nexHondaEP3-1-36-2.nexmap", import.meta.url));
    referenceBytes = await readFile(new URL("../../../no password.nexHondaEP3-1-36-2.nexmap", import.meta.url));
  } catch (error) {
    if (error.code !== "ENOENT") throw error;
    test.skip(true, "Optional owner-supplied map pair is not present.");
    return;
  }
  await page.goto("/");
  await page.locator("#file-input").setInputFiles({
    name: "Honda.nexmap", mimeType: "application/octet-stream", buffer: protectedBytes,
  });
  await page.getByLabel("I own this map").check();
  const downloadPromise = page.waitForEvent("download");
  await page.getByRole("button", { name: "Unlock & download" }).click();
  const stream = await (await downloadPromise).createReadStream();
  const chunks = [];
  for await (const chunk of stream) chunks.push(chunk);
  const actual = await readArchive(new Uint8Array(Buffer.concat(chunks)));
  const reference = await readArchive(new Uint8Array(referenceBytes));
  expect([...actual.keys()].sort()).toEqual([...reference.keys()].sort());
  for (const [name, entry] of reference) expect(actual.get(name).data).toEqual(entry.data);
});
