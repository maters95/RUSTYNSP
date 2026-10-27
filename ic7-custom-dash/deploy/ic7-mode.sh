#!/bin/sh
# Switch the screen owner between Haltech's stock dash and the custom overlay.
# eglfs allows only one GPU client at a time, so exactly one runs.
#
#   ic7-mode.sh stock    -> Haltech dash (NSP works normally: config, screens, FW)
#   ic7-mode.sh overlay  -> custom maps/laps/clock app
#   ic7-mode.sh status
#
# NSP management is done in STOCK mode. Nothing here touches NSP or the stock
# firmware files; it only starts/stops systemd services already on the dash.

set -e

case "$1" in
  stock)
    systemctl stop  ic7-overlay.service  2>/dev/null || true
    systemctl start gui-launcher.service
    echo "stock dash active (NSP-native)"
    ;;
  overlay)
    systemctl stop  gui-launcher.service 2>/dev/null || true
    systemctl start ic7-overlay.service
    echo "custom overlay active"
    ;;
  status)
    systemctl is-active gui-launcher.service >/dev/null 2>&1 && echo "mode: stock"   || true
    systemctl is-active ic7-overlay.service  >/dev/null 2>&1 && echo "mode: overlay" || true
    ;;
  *)
    echo "usage: $0 {stock|overlay|status}"; exit 1 ;;
esac
