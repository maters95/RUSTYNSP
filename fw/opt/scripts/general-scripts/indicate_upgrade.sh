#!/bin/bash
#
# Blink the leds to indicate upgrade.
# indicate_upgrade [how]
# if how=0, then the upgrade is in progress. The Leds are flashed green in sequence at 10 Hz in an endless loop.
# if how=1, then the upgrade was a success. The Leds are flashed green together at 1 Hz for 5 times.
# if how=2, then the upgrade was a failure. The Leds are flashed red together at 10 Hz for 50 times.
#
