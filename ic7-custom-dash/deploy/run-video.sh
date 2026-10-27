#!/usr/bin/env sh
set -eu

HERE=$(CDPATH= cd -- "$(dirname -- "$0")" && pwd)
if [ ! -x "$HERE/ic7dash" ]; then
    echo "ic7dash is missing or not executable in $HERE" >&2
    exit 1
fi
if [ ! -r "$HERE/bg.mp4" ]; then
    echo "bg.mp4 is missing or unreadable in $HERE" >&2
    exit 1
fi

cd "$HERE"
IC7_BG=video
export IC7_BG
exec ./ic7dash "$@"