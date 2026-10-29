import "./theme.css";
import { MAX_FILE_BYTES, outputName } from "./shared.js";

const $ = (id) => document.getElementById(id);
const fileInput = $("file-input");
const dropZone = $("drop-zone");
const unlockButton = $("unlock-button");
const consent = $("authorization");
const status = $("status");
const downloadLink = $("download-again");
let selectedFile = null;
let worker = null;
let downloadUrl = null;
let busy = false;
let jobId = 0;

function revokeDownload() {
  if (downloadUrl) URL.revokeObjectURL(downloadUrl);
  downloadUrl = null;
  downloadLink.hidden = true;
  downloadLink.removeAttribute("href");
}

function updateControls() {
  unlockButton.disabled = busy || !selectedFile || !consent.checked;
  dropZone.disabled = busy;
  consent.disabled = busy;
  $("clear-file").disabled = busy;
  $("cancel-button").hidden = !busy;
  $("unlock-label").textContent = busy ? "Unlocking your map…" : "Unlock & download";
  $("progress-area").hidden = !busy;
  $("file-panel").hidden = !selectedFile;
  $("file-panel").setAttribute("aria-busy", String(busy));
}

function showStatus(message, isError = false) {
  status.hidden = false;
  status.textContent = message;
  status.classList.toggle("error", isError);
  if (isError) status.focus();
}

function selectFiles(files) {
  if (busy) return;
  selectedFile = null;
  fileInput.value = "";
  revokeDownload();
  status.hidden = true;
  if (files.length !== 1) {
    showStatus("Please choose one .nexmap file at a time.", true);
  } else {
    const file = files[0];
    if (!/\.nexmap$/i.test(file.name)) {
      showStatus("Please choose a .nexmap calibration file.", true);
    } else if (file.size === 0) {
      showStatus("This file is empty. Choose a valid .nexmap file.", true);
    } else if (file.size > MAX_FILE_BYTES) {
      showStatus("This file exceeds the 128 MB limit. Use the desktop tool for larger maps.", true);
    } else {
      selectedFile = file;
      $("file-name").textContent = file.name;
      $("file-size").textContent = `${(file.size / (1024 * 1024)).toFixed(2)} MB · Original kept unchanged`;
    }
  }
  updateControls();
}

function stopWorker() {
  worker?.terminate();
  worker = null;
  busy = false;
  updateControls();
}

dropZone.addEventListener("click", () => fileInput.click());
fileInput.addEventListener("change", () => {
  if (fileInput.files.length) selectFiles([...fileInput.files]);
});
consent.addEventListener("change", updateControls);
$("clear-file").addEventListener("click", () => {
  selectedFile = null;
  fileInput.value = "";
  revokeDownload();
  status.hidden = true;
  updateControls();
  dropZone.focus();
});

for (const type of ["dragenter", "dragover"]) {
  dropZone.addEventListener(type, (event) => {
    event.preventDefault();
    if (!busy) dropZone.classList.add("drag-over");
  });
}
for (const type of ["dragleave", "drop"]) {
  dropZone.addEventListener(type, (event) => {
    event.preventDefault();
    dropZone.classList.remove("drag-over");
    if (type === "drop" && !busy) selectFiles([...event.dataTransfer.files]);
  });
}
// Prevent a misplaced file drop from navigating away from the page.
window.addEventListener("dragover", (event) => event.preventDefault());
window.addEventListener("drop", (event) => event.preventDefault());

$("cancel-button").addEventListener("click", () => {
  jobId++;
  stopWorker();
  showStatus("Processing cancelled. Your original file is unchanged.");
});

unlockButton.addEventListener("click", async () => {
  if (busy || !selectedFile || !consent.checked) return;
  const file = selectedFile;
  const currentJob = ++jobId;
  busy = true;
  revokeDownload();
  updateControls();
  $("progress-bar").style.width = "0%";
  showStatus("Reading your file locally…");
  try {
    const bytes = await file.arrayBuffer();
    if (currentJob !== jobId) return;
    worker = new Worker(new URL("./unlock.worker.js", import.meta.url), { type: "module" });
    worker.onmessage = ({ data: result }) => {
      if (currentJob !== jobId) return;
      if (result.type === "progress") {
        $("progress-bar").style.width = `${result.percent}%`;
        showStatus(result.message);
      } else if (result.type === "error") {
        stopWorker();
        showStatus(`Unable to unlock this file: ${result.message} Your original is unchanged.`, true);
      } else if (result.type === "complete") {
        stopWorker();
        downloadUrl = URL.createObjectURL(new Blob([result.data], { type: "application/octet-stream" }));
        downloadLink.href = downloadUrl;
        downloadLink.download = outputName(file.name);
        downloadLink.hidden = false;
        showStatus(result.wasProtected
          ? "Unlocked. Your download is ready, and your original is untouched."
          : "This map was already unlocked. A fresh copy is ready to download.");
        downloadLink.click();
      }
    };
    worker.onerror = (event) => {
      event.preventDefault();
      if (currentJob !== jobId) return;
      stopWorker();
      showStatus("Processing could not finish. Your browser may have run out of memory or blocked the worker. Try a current browser or the desktop tool.", true);
    };
    worker.postMessage(bytes, [bytes]);
  } catch (error) {
    if (currentJob !== jobId) return;
    stopWorker();
    showStatus(`Unable to read or process this file: ${error instanceof Error ? error.message : String(error)}`, true);
  }
});

window.addEventListener("pagehide", () => {
  jobId++;
  stopWorker();
  revokeDownload();
});
updateControls();
