# Nexmap Unlock Web

A free, account-free website for recovering access to `.nexmap` calibrations you
own or are authorised to modify. The interface uses the desktop tool's yellow
unlock/N branding and works on mobile and desktop.

**Files are processed locally, not uploaded.** This is a static website: no
backend, database, API keys, account system, payment service, analytics, CDN
scripts, or external fonts. All runtime dependencies are bundled with the site.
The host serves the page and application assets only.

## Run locally

Requires Node.js 22.12+ (or a supported newer LTS) and npm.

```sh
cd nexmap-web
npm ci
npm run dev
```

Open the address printed by Vite (normally `http://localhost:5173`). In
Codespaces, forward port 5173 and open it in your browser.

1. Choose or drop one `.nexmap` file.
2. Confirm you own it or have permission to modify it.
3. Click **Unlock & download**.
4. The browser downloads `<name> (unlocked).nexmap`. A repeat-download link is
   also available if automatic downloading is blocked.

The original is never overwritten. Already-unlocked maps produce a fresh copy
with an explicit explanation. Invalid or unsupported maps display an error and
do not produce a download. Processing runs in a dedicated web worker so the UI
stays responsive and cancellation can immediately terminate work.

## Build and host

```sh
npm run build
npm run preview
```

Deploy **only the contents of `dist/`** to any static host, such as GitHub Pages,
Cloudflare Pages, or your own web server. Configure hosted builds with
`nexmap-web` as the root directory, `npm ci && npm run build` as the build command,
and `dist` as the output directory. Visitors need no account, including on free
static hosting plans.

Relative asset URLs support hosting under a subdirectory. Do not copy the whole
repository to a public web root: it contains unrelated materials and map
fixtures. The production build does not include those files.

Serve over HTTPS (or localhost during development); opening `index.html` via
`file://` is not supported. There is no application server to run or pay for.
The site must be loaded from its host; it is not an installable offline PWA.
The file picker does not upload anything, and no server processes the selected
file. Hosting providers can still log ordinary page/asset requests.

## Format and safeguards

The transformation follows
[`NexmapUnlocker.cs`](../nexmap-unlock/NexmapUnlocker.cs):

- Derive the NSP format's fixed WinZip AES password.
- Authenticate/decrypt archive contents in memory.
- Require the supported protection fields and verify the existing integrity
  hash before editing.
- Reset `IsProtected`, `Password`, and the protection bitmap; recompute the
  integrity MD5 from setting payloads in document order.
- Preserve the XML formatting and UTF-8 BOM, non-map entry contents, and entry
  names, then write an AES-256-encrypted archive with NSP's fixed timestamps.

Encrypted ZIP bytes differ between runs because encryption uses fresh random
salts. Compare decrypted entries, not the encrypted archive bytes.

Limits: **128 MiB input**, **512 MiB expanded total**, **64 MiB `_map` XML**, and
**2,048 archive entries**. Decompression also checks actual emitted sizes, not
just ZIP metadata. Duplicate names, missing fields, invalid UTF-8, failed
authentication, and broken integrity hashes are rejected. Only the canonical
XML serialization used by the desktop tool is supported; this is intentionally
not a general-purpose XML rewriter.

Memory use can exceed file size, especially for resource-heavy archives. Use a
current browser with web-worker, Web Crypto, and Streams support. Low-memory
devices may need smaller maps or the [Windows tool](../nexmap-unlock/README.md).

Keep a backup and inspect the output in NSP before use. This tool recovers map
access; it does not assess calibration safety, connect to a vehicle, or alter
ECU security. It is not affiliated with Haltech.

## Tests

```sh
npm test
npx playwright install --with-deps chromium
npm run test:browser
```

Unit tests cover an independent integrity-hash reference, exact XML/BOM
preservation, authenticated archive round trips, unchanged resources, already
open files, corruption, input limits, and forged decompression sizes. If the
owner-supplied protected/unprotected Honda map pair is present at the repository
root, it also checks **every decrypted output entry byte-for-byte** against the
genuine unlocked reference. This optional fixture test is explicitly skipped
when the pair is unavailable.

Browser tests run against the production build and cover actual downloads,
repeat downloads, no file-upload requests or third-party requests, authorization,
invalid input, already-open maps, cancellation, drag-and-drop, and layouts from
360 to 1440 pixels. These checks do not replace opening the result in NSP or
testing on physical devices.
