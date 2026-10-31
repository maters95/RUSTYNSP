"""SIMULATION SUPPORT: the iC-7 v2.36 LED bar logic, re-implemented from the decrypted app.

Evidence (decrypted nic-7 ELF, sha256 d86bde81...; disassemble with
scripts/disassemble-nsp-app.py):

* ``Alarm_Module::process_alarms_and_shift_lights`` (0xf4324) runs, in order:
  ``LedManager::reset_leds`` (0xf290c: 14 colour bytes + 14 blink bytes cleared),
  ``draw_alarms`` (0xf2b94, which calls ``LedManager::update_leds(mask, colour, blink)``
  for alarms, 0xf31b8/0xf395c, with ALARMS_COMP_n ``_LED_ENABLED`` (+68),
  ``LED_COLOUR`` (+64) and ``LED_BLINKING == 1`` (+65)), then
  ``update_shift_lights`` (0xf2a94) and ``LedManager::update_led_io`` (0xf2b40).
* ``update_leds`` / ``update_led_for_shift_lights`` only write an LED whose colour
  byte is still 0, so the first writer wins: active alarms take priority over
  shift lights, and earlier alarms over later ones.
* ``update_shift_lights``: returns unless MRAM 0xd90 (setting 4357 "Shift Lights
  Enable") is set; for i = START-1 .. START-1+COUNT-1 (SHIFT_LIGHT_ENABLED_START /
  _COUNT at MRAM 0x9260/0x9261) it lights LED i with SHIFT_LIGHT_i_COLOUR when the
  **ECU RPM channel chan_mem[0xe68]** >= SHIFT_LIGHT_i_RPM. LED index > 13 is ignored.
  The blink byte it writes is the (zero) colour byte it just tested, so shift lights
  never flash.
* Colours are a 3-bit mask: 1 blue, 2 green, 4 red (HDEF ListItems: 3 cyan,
  5 magenta, 6 yellow, 7 white). ``ProcessDashLed::refresh_leds`` (0x40b60) packs
  bit0 -> blue word, bit1 -> green word, bit2 -> red word.
* Flashing: ``refresh_leds`` toggles one shared phase byte every 5th call and
  shows a blinking LED only in the "on" phase. The call rate of the LED refresh is
  not recoverable statically; FLASH_TOGGLE_S below is an ASSUMPTION.
* 14 LEDs: HDEF RAM channels "LED 1 Colour" .. "LED 14 Colour" (addr 1900 + 20*i),
  SHIFT_LIGHT_0..13, and update_led_for_shift_lights' ``cmp r1, #0xd``.
"""
import struct

LED_COUNT = 14
ECU_RPM = 0x1400 + 0x0E68
SETTINGS_BASE = 0x20000
SHIFT_ENABLE = 3472            # setting 4357 ENABLE ("Shift Lights Enable")
SHIFT_START = 37472            # SHIFT_LIGHT_ENABLED_START
SHIFT_COUNT = 37473            # SHIFT_LIGHT_ENABLED_COUNT
SHIFT_TABLE = 37480            # SHIFT_LIGHT_0_RPM, stride 8 (RPM int32, colour byte at +4)
ALARM_BASE = 476564
ALARM_STRIDE = 76
FLASH_TOGGLE_S = 0.25          # ASSUMPTION: phase toggles every 5 refreshes of ~50 ms
RGB = {0: None, 1: (40, 90, 255), 2: (40, 255, 70), 3: (40, 230, 255), 4: (255, 30, 20),
       5: (255, 40, 220), 6: (255, 200, 20), 7: (255, 255, 255)}


def _settings(memory, offset, size):
    return memory.read(SETTINGS_BASE + offset, size)


def shift_light_table(memory):
    enabled = _settings(memory, SHIFT_ENABLE, 1)[0]
    start, count = _settings(memory, SHIFT_START, 2)
    rows = []
    for index in range(16):
        rpm, colour = struct.unpack("<iB", _settings(memory, SHIFT_TABLE + 8 * index, 5))
        rows.append((rpm, colour))
    return enabled, start, count, rows


def led_states(memory, active_alarm_indices, time_s):
    """[(colour mask, blink)] * 14 for one process_alarms_and_shift_lights pass."""
    colours = [0] * LED_COUNT
    blinks = [False] * LED_COUNT
    for index in active_alarm_indices:
        block = _settings(memory, ALARM_BASE + ALARM_STRIDE * index, ALARM_STRIDE)
        colour, blink = block[64], block[65] == 1
        mask = struct.unpack_from("<i", block, 68)[0]
        for led in range(LED_COUNT):
            if mask & (1 << led) and colours[led] == 0:
                colours[led] = colour
                blinks[led] = blink
    enabled, start, count, rows = shift_light_table(memory)
    if enabled:
        rpm = struct.unpack("<i", memory.read(ECU_RPM, 4))[0]
        first = (start - 1) & 0xFF
        last = (first + count) & 0xFF
        for led in range(first, last):
            threshold, colour = rows[led] if led < len(rows) else (0, 0)
            if rpm >= threshold and led <= 13 and colours[led] == 0:
                colours[led] = colour
    phase_on = int(time_s / FLASH_TOGGLE_S) % 2 == 0
    out = []
    for led in range(LED_COUNT):
        shown = colours[led] if (not blinks[led] or phase_on) else 0
        out.append(RGB.get(shown & 7))
    return out
