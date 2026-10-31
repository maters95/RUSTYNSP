"""Stage the dash's file layout for the offline renderer (SIMULATION SUPPORT).

    <work>/opt/applications/dtn/resources/qml_components_data/...   (stock v2.36 NEX resources)
    <work>/opt/applications/dtn/user_resources/{images,fonts}/...     (the owner's map resources)

The stock resource archive is decoded from fw/Dash-V2-36-0-Release.nex with the
repository's own codec (scripts/decode-nsp-resources.py, as scripts/audit-nex.py
does). The r5 components (main.qml, HalSplash.qml, HalImage.qml,
HalAlarmPopup.qml from ic7-custom-dash/deploy/nsp) replace their stock members,
exactly as the r5 NEX does. Nothing in the repository is modified.
"""
import io
from pathlib import Path, PurePosixPath
import runpy
import shutil
import tarfile
import zipfile

ROOT = Path(__file__).resolve().parents[3]
STOCK_NEX = ROOT / "fw/Dash-V2-36-0-Release.nex"
WATCHDOG = ROOT / "fw/opt/dtn/app/dash_watchdog"
R5 = ROOT / "ic7-custom-dash/deploy/nsp"
R5_MEMBERS = {
    "qml_components_data/qml/factory_screens/main.qml": R5 / "main.qml",
    "qml_components_data/qml/user_components/HalSplash.qml": R5 / "HalSplash.qml",
    "qml_components_data/qml/user_components/HalImage.qml": R5 / "HalImage.qml",
    "qml_components_data/qml/user_components/HalAlarmPopup.qml": R5 / "HalAlarmPopup.qml",
}
DTN = PurePosixPath("opt/applications/dtn")


def stock_members():
    codec = runpy.run_path(str(ROOT / "scripts/decode-nsp-resources.py"))
    with zipfile.ZipFile(STOCK_NEX) as package:
        payload = package.read("res_ic-7.qzip")
    archive = codec["decode_resource"](WATCHDOG, payload)[0]
    with tarfile.open(fileobj=io.BytesIO(archive), mode="r:") as tar:
        return {member.name.lstrip("./"): tar.extractfile(member).read()
                for member in tar.getmembers() if member.isfile()}


def stage(work, map_entries):
    work = Path(work)
    resources = work / DTN / "resources"
    users = work / DTN / "user_resources"
    if (work / "opt").exists():
        shutil.rmtree(work / "opt")
    count = 0
    for name, payload in stock_members().items():
        if not name.startswith("qml_components_data/"):
            continue  # upgrade_files etc. are not needed by the renderer
        target = resources / name
        target.parent.mkdir(parents=True, exist_ok=True)
        target.write_bytes(payload)
        count += 1
    for name, source in R5_MEMBERS.items():
        target = resources / name
        target.parent.mkdir(parents=True, exist_ok=True)
        target.write_bytes(source.read_bytes())
    for name, payload in map_entries.items():
        if not name.startswith("user_resources/") or name.lower().endswith(".mp4"):
            continue
        relative = PurePosixPath(name).relative_to("user_resources")
        if ".." in relative.parts:
            raise ValueError("Unsafe map member " + name)
        target = users.joinpath(*relative.parts)
        target.parent.mkdir(parents=True, exist_ok=True)
        target.write_bytes(payload)
    return {"resources": resources, "user_resources": users, "stock_members": count,
            "main_qml": resources / "qml_components_data/qml/factory_screens/main.qml",
            "user_components": resources / "qml_components_data/qml/user_components"}
