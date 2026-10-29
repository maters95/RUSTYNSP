import { unlockArchive } from "./unlock.js";

self.onmessage = async ({ data: bytes }) => {
  try {
    const result = await unlockArchive(new Uint8Array(bytes), (progress) => {
      self.postMessage({ type: "progress", ...progress });
    });
    self.postMessage({ type: "complete", ...result }, [result.data.buffer]);
  } catch (error) {
    self.postMessage({
      type: "error",
      message: error instanceof Error ? error.message : "The file could not be processed.",
    });
  }
};
