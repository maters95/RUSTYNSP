#!/bin/sh
# Bring up the CAN interface before the overlay app starts.
# The Emtron bus the EK9 screen uses runs at 1 Mbit/s. Adjust if yours differs.
# Harmless if already up.
IFACE="${1:-can0}"
BITRATE="${2:-1000000}"
ip link set "$IFACE" type can bitrate "$BITRATE" 2>/dev/null || true
ip link set up "$IFACE" 2>/dev/null || true
exit 0
