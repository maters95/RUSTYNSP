import { defineConfig } from "vite";

const codespaceHost = process.env.CODESPACE_NAME
  ? `${process.env.CODESPACE_NAME}-5173.${process.env.GITHUB_CODESPACES_PORT_FORWARDING_DOMAIN || "app.github.dev"}`
  : null;

export default defineConfig({
  base: "./",
  server: {
    allowedHosts: codespaceHost ? [codespaceHost] : [],
  },
});
