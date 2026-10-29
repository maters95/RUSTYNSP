export const MAX_FILE_BYTES = 128 * 1024 * 1024;

export function outputName(name) {
  return `${name.replace(/\.nexmap$/i, "")} (unlocked).nexmap`;
}
