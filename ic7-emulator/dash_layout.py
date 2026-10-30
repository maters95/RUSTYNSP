"""Dash-faithful resource layout: decode a NEX the watchdog way and audit lookups.

The real iC-7 keeps its QML under /opt/applications/dtn/resources and user
uploads under /opt/applications/dtn/user_resources. Its watchdog applies a
resource update (``do_resource_upgrade``) by removing the resources folder,
recreating it, decrypting the staged payload and running ``tar -xf ... -C``,
which keeps every member's archived mtime.

NSP's Windows renderer (dash_virtual.exe) instead resolves user files from its
working directory: ``./user_resources`` and, for image components,
``../../../user_resources/images/`` (three levels up from user_components).
The emulator therefore runs it with its working directory at the mirrored
``dtn/resources`` and keeps a compatibility copy of user files there, which
never contains the ``ic7_*.json`` manifests. A component that relies on the
three-level Windows shortcut finds no manifest, exactly as on the dash.
"""
import hashlib
import io
import json
import os
from pathlib import Path, PurePosixPath
import re
import shutil
import struct
import tarfile
import time


RESOURCE_STAGE_ADDRESS = 0x25000000
DASH_ROOT = PurePosixPath("/opt/applications/dtn")
RESOURCES = "dtn/resources"
USER_RESOURCES = "dtn/user_resources"
# dash_virtual.exe's own user folder, relative to its working directory.
RENDERER_USER_RESOURCES = RESOURCES + "/user_resources"
QML_ROOT = "qml_components_data/qml/"
MANIFEST_NAME = re.compile(r"ic7_[A-Za-z0-9_]+\.json")
USER_IMAGE_PATH = re.compile(r"""["']((?:\.\./)+)user_resources/images/""")
DASH_PATH_TEST = "/resources/qml_components_data/"
MAX_MEMBERS = 4096
MAX_DECODED = 96 * 1024 * 1024


def is_manifest(name):
    """True for the reserved user manifests that NSP's 3-level layout must not see."""
    return MANIFEST_NAME.fullmatch(PurePosixPath(name).name) is not None


def _elf_symbol(data, wanted):
    """Return one symbol's bytes from a 32-bit little-endian ELF (the dash watchdog)."""
    if data[:4] != b"\x7fELF" or data[4] != 1 or data[5] != 1:
        raise ValueError("The watchdog reference is not a 32-bit little-endian ELF")
    shoff, = struct.unpack_from("<I", data, 0x20)
    shentsize, shnum = struct.unpack_from("<HH", data, 0x2E)
    sections = [struct.unpack_from("<IIIIIIIIII", data, shoff + index * shentsize) for index in range(shnum)]
    symtab = next((section for section in sections if section[1] == 2), None)
    if symtab is None:
        raise ValueError("The watchdog reference has no symbol table")
    strings = sections[symtab[6]][4]
    matches = []
    for offset in range(symtab[4], symtab[4] + symtab[5], 16):
        name_offset, value, size, _, _, index = struct.unpack_from("<IIIBBH", data, offset)
        end = data.index(b"\0", strings + name_offset)
        if data[strings + name_offset:end].decode("ascii", "replace") in wanted:
            section = sections[index]
            start = section[4] + value - section[3]
            matches.append(data[start:start + size])
    if len(matches) != 1:
        raise ValueError(f"Expected one {sorted(wanted)[0]} table in the watchdog reference")
    return matches[0]


def watchdog_parameters(reference, index=1):
    """Read the resource AES key and IV the watchdog uses (table entry 1)."""
    data = Path(reference).read_bytes()
    keys = _elf_symbol(data, {"encryption_keys", "_ZL15encryption_keys"})
    vectors = _elf_symbol(data, {"initial_vectors", "_ZL15initial_vectors"})
    if len(keys) < 16 * (index + 1) or len(vectors) < 16 * (index + 1):
        raise ValueError("The watchdog key table is truncated")
    return keys[16 * index:16 * index + 16], vectors[16 * index:16 * index + 16]


def find_watchdog():
    """Locate the dash watchdog used to decrypt resource updates."""
    here = Path(__file__).resolve().parent
    candidates = [os.environ.get("IC7_DASH_WATCHDOG"),
                  here / "dash-reference" / "dash_watchdog",
                  here.parent / "fw/opt/dtn/app/dash_watchdog"]
    for candidate in candidates:
        if candidate and Path(candidate).is_file():
            return Path(candidate)
    return None


def decrypt_stage(body, reference):
    """Decrypt a staged resource body exactly as the dash receives it."""
    if not body or len(body) % 16:
        raise ValueError("Staged resource is not AES-block aligned")
    try:
        from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes
    except ImportError as error:
        raise ValueError("Install the emulator requirements (cryptography) to decode NEX resources") from error
    key, vector = watchdog_parameters(reference)
    decryptor = Cipher(algorithms.AES(key), modes.CBC(vector)).decryptor()
    return decryptor.update(bytes(body)) + decryptor.finalize()


def parse_members(archive):
    """Read every tar member (name, type, mode, mtime, data), rejecting unsafe paths."""
    if len(archive) > MAX_DECODED:
        raise ValueError("Decoded resource archive is too large")
    members = []
    try:
        with tarfile.open(fileobj=io.BytesIO(archive), mode="r:") as tar:
            for member in tar:
                name = member.name
                while name.startswith("./"):
                    name = name[2:]
                path = PurePosixPath(name)
                if (not name or path.is_absolute() or ".." in path.parts or "\\" in name or ":" in name):
                    raise ValueError(f"Unsafe resource member path: {member.name!r}")
                if member.isdir():
                    kind, data = "dir", b""
                elif member.isfile():
                    kind = "file"
                    source = tar.extractfile(member)
                    data = source.read() if source is not None else b""
                    if len(data) != member.size:
                        raise ValueError(f"Resource member truncated: {name}")
                else:
                    raise ValueError(f"Unsupported resource member type: {name}")
                members.append({"name": path.as_posix(), "type": kind, "mode": member.mode,
                                "mtime": int(member.mtime), "data": data})
                if len(members) > MAX_MEMBERS:
                    raise ValueError("Resource archive has too many members")
    except tarfile.TarError as error:
        raise ValueError(f"Decoded resource is not a tar archive: {error}") from error
    if not any(member["type"] == "file" for member in members):
        raise ValueError("Decoded resource archive is empty")
    return members


def decode_stage(body, reference):
    archive = decrypt_stage(body, reference)
    return archive, parse_members(archive)


def member_summary(members):
    return [{"name": member["name"], "type": member["type"], "mtime": member["mtime"],
             "bytes": len(member["data"]),
             "sha256": hashlib.sha256(member["data"]).hexdigest() if member["type"] == "file" else None}
            for member in members]


def install_members(members, destination):
    """Apply an update like do_resource_upgrade: wipe, recreate, extract, keep mtimes."""
    destination = Path(destination)
    if destination.exists():
        shutil.rmtree(destination)
    destination.mkdir(parents=True)
    for member in members:
        target = destination.joinpath(*PurePosixPath(member["name"]).parts)
        if member["type"] == "dir":
            target.mkdir(parents=True, exist_ok=True)
        else:
            target.parent.mkdir(parents=True, exist_ok=True)
            target.write_bytes(member["data"])
    # Directory mtimes last, deepest first, as tar restores them after their contents.
    for member in sorted(members, key=lambda item: item["type"] != "file"):
        target = destination.joinpath(*PurePosixPath(member["name"]).parts)
        if member["type"] == "file":
            os.utime(target, (member["mtime"], member["mtime"]))
    for member in sorted((item for item in members if item["type"] == "dir"),
                         key=lambda item: -len(PurePosixPath(item["name"]).parts)):
        target = destination.joinpath(*PurePosixPath(member["name"]).parts)
        os.utime(target, (member["mtime"], member["mtime"]))
    return destination


def resolve_user_folder(member_name, prefix):
    """Where a component's relative user-image prefix lands on the real dash."""
    folder = PurePosixPath("resources") / PurePosixPath(member_name).parent
    parts = list(folder.parts)
    levels = prefix.count("../")
    if levels > len(parts):
        return None
    base = PurePosixPath(*parts[:len(parts) - levels]) if levels < len(parts) else PurePosixPath(".")
    return (DASH_ROOT / base / "user_resources/images").as_posix()


def component_user_folder(member_name, text):
    """The user-image folder a component resolves when it runs from the dash tree."""
    prefixes = USER_IMAGE_PATH.findall(text)
    if not prefixes:
        return None, None
    if DASH_PATH_TEST in text and "../../../../" in prefixes:
        prefix, rule = "../../../../", "dash path test"
    else:
        prefix, rule = prefixes[0], "fixed relative path"
    return resolve_user_folder(member_name, prefix), rule


def _referenced_sources(value):
    if isinstance(value, str):
        if value.startswith(("u/", "h/")):
            yield value
    elif isinstance(value, dict):
        for item in value.values():
            yield from _referenced_sources(item)
    elif isinstance(value, list):
        for item in value:
            yield from _referenced_sources(item)


def audit_user_lookups(members, user_images, stock_images=()):
    """Statically resolve every manifest a component reads, as the dash would.

    ``members`` are the installed resource members, ``user_images`` the uploaded
    kind-0 user names (``u/...``), ``stock_images`` the ``h/`` names available.
    """
    real_folder = (DASH_ROOT / "user_resources/images").as_posix()
    uploaded = set(user_images)
    findings = []
    for member in members:
        if member["type"] != "file" or not member["name"].startswith(QML_ROOT):
            continue
        if not member["name"].endswith((".qml", ".js")):
            continue
        text = member["data"].decode("utf-8", "replace")
        manifests = sorted(set(MANIFEST_NAME.findall(text)))
        if not manifests:
            continue
        folder, rule = component_user_folder(member["name"], text)
        if folder is None:
            # It names a manifest but delegates the file lookup to another component.
            continue
        for manifest in manifests:
            entry = {"component": member["name"], "manifest": manifest, "folder": folder, "rule": rule,
                     "missing_media": []}
            if folder != real_folder:
                entry["status"] = "wrong-folder"
                entry["reason"] = (f"looks for {manifest} in {folder}, which does not exist on the dash "
                                   f"(user files are in {real_folder})")
            elif "u/" + manifest not in uploaded:
                entry["status"] = "manifest-not-uploaded"
                entry["reason"] = f"{manifest} has not been uploaded to the dash"
            else:
                payload = user_images["u/" + manifest]
                try:
                    config = json.loads(payload)
                except (ValueError, UnicodeError) as error:
                    entry["status"] = "invalid-manifest"
                    entry["reason"] = f"{manifest} is not valid JSON: {error}"
                else:
                    missing = sorted({source for source in _referenced_sources(config)
                                      if (source not in uploaded if source.startswith("u/")
                                          else source not in stock_images)})
                    entry["missing_media"] = missing
                    entry["status"] = "media-missing" if missing else "ok"
                    entry["reason"] = ("manifest references media that is not on the dash: " + ", ".join(missing)
                                       if missing else f"{manifest} found at {folder}")
            findings.append(entry)
    return findings


def factory_differences(members, factory):
    """Members that differ from, or are absent in, the factory QML tree."""
    changed, added = [], []
    for member in members:
        if member["type"] != "file" or not member["name"].startswith("qml_components_data/"):
            continue
        stock = factory.get(member["name"])
        if stock is None:
            added.append(member["name"])
        elif stock != member["data"]:
            changed.append(member["name"])
    return sorted(changed), sorted(added)


RENDERER_ERROR = re.compile(r"HalSplash:|HalAlarmPopup|Ic7\w+:|alert-media|manifest|\.qml:\d+", re.I)


def renderer_errors(log_path):
    """QML lookup and load errors the renderer printed (renderer.log)."""
    try:
        lines = Path(log_path).read_text(encoding="utf-8", errors="replace").splitlines()
    except OSError:
        return []
    return [line.strip() for line in lines if RENDERER_ERROR.search(line)][-50:]


def refresh_report(state):
    """Fold the final renderer.log into a saved fidelity report before export."""
    state = Path(state)
    try:
        report = json.loads((state / "fidelity-report.json").read_text(encoding="utf-8"))
    except (OSError, ValueError, UnicodeError):
        return None
    report["renderer_errors"] = renderer_errors(state / "renderer.log")
    (state / "fidelity-report.json").write_text(json.dumps(report, indent=1) + "\n", encoding="utf-8")
    (state / "fidelity-report.txt").write_text(render_report_text(report), encoding="utf-8")
    return report


def render_report_text(report):
    """Plain-text dash fidelity report for the workbench and log export."""
    lines = ["iC-7 emulator - Dash fidelity report",
             "Generated: " + time.strftime("%Y-%m-%d %H:%M:%S", time.localtime(report.get("generated", time.time()))),
             ""]
    install = report.get("install") or {}
    if install.get("source") == "nex":
        lines += [f"Installed NEX payload: {install.get('payload_sha256')}",
                  f"Selected NEX file: {install.get('package') or 'none selected'}"
                  + (f" (sha256 {install['package_sha256']})" if install.get("package_sha256") else ""),
                  f"Members installed: {install.get('member_count')} into {DASH_ROOT}/resources "
                  "(wiped first; archived mtimes kept)"]
        for name in install.get("changed", []):
            lines.append(f"  changed vs factory: {name}  mtime {install['mtimes'].get(name)}")
        for name in install.get("added", []):
            lines.append(f"  added:              {name}  mtime {install['mtimes'].get(name)}")
        for check in install.get("crosscheck", []):
            lines.append(f"  kit sidecar {check['name']}: {'matches the NEX member' if check['matches'] else 'DIFFERS from the NEX member'}")
    else:
        lines.append("Installed resources: factory v2.36 QML (no NEX installed in this session)")
    if install.get("error"):
        lines.append("Install error: " + install["error"])
    lines.append("")
    lookups = report.get("lookups", [])
    lines.append("Manifest lookups (resolved as on the dash):")
    if not lookups:
        lines.append("  no installed component reads an ic7_*.json manifest")
    for entry in lookups:
        lines.append(f"  [{entry['status']}] {PurePosixPath(entry['component']).name} -> {entry['manifest']}: {entry['reason']}")
    runtime = report.get("renderer_errors", [])
    if runtime:
        lines += ["", "Renderer QML errors (from renderer.log):"] + ["  " + line for line in runtime]
    events = report.get("protocol_events", [])
    if events:
        lines += ["", "Dash reboots modelled:"] + [
            f"  {event['reason']}: silent {event['seconds']:.1f} s" for event in events]
    lines += ["", "Remaining differences from a real dash:"] + ["  - " + item for item in report.get("limits", [])]
    return "\n".join(lines) + "\n"
