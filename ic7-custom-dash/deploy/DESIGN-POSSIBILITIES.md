# iC-7 media baseline, Emtron SL4 motion data, and design possibilities

## Working baseline: owner report, 2026-10-28

The owner confirms GIF and MP4 playback on the physical iC-7 using:

- Windows NSP copy: `NSP-native-media-videofix`.
- Bundle: `ic7-nsp-native-media-test-2.36-videofix`.
- Flash: the resource-only NEX supplied in that bundle.

The real-flash USB capture's 17,377,280-byte resource write matches the native
media candidate's encrypted resource body, excluding its 44-byte wrapper.
The owner's clarification identifies the distribution bundle; identical
payload bytes alone do not identify which ZIP was used.

The matching local candidate is
[`ic7-2.36-native-media-experimental.nex`](../build-cfw-native-media-236/ic7-2.36-native-media-experimental.nex).
Its SHA-256 is
`000f6b3c250240f8fc5c9f37194806627aa31e9c096c67d26feb30ab916f72e2`.
Its [build report](../build-cfw-native-media-236/build-report.json) records
one changed resource member, `HalImage.qml`, and 338 preserved members.
This is not a custom OS or a replacement for the stock application.
Playback success is owner-reported; recovery, sustained performance, and every
codec/resolution combination are not established by that report.

Retain the successful package, working map, media, and capture as the baseline.
The [native-media guide](nsp/NATIVE-MEDIA-TEST.md) describes setup and testing.

## Emtron SL4: motion without buying another sensor

The owner's ECU is an SL4. The [official SL4 datasheet][sl4] specifies:

- Internal three-axis accelerometer, 16-bit resolution.
- Selectable +/-2g, +/-4g, +/-8g range.
- Sensor output data rate of 500 Hz.
- One CAN interface, six configurable channels.

These specifications do not establish an internal gyroscope or GPS receiver.
An earlier KV-only list was incomplete; the SL4 datasheet explicitly includes
the accelerometer.

Emtron's [accelerometer guide][accel] describes vehicle-axis assignment under
Tuning View > Vehicle Setup > Accelerometer Setup. Check the installed
Emtune version's labels and verify actual SL4 live channels and orientation.
Do not assume ECU enclosure axes match vehicle lateral/longitudinal axes.

### Custom CAN transmit

[Custom TX Data Sets][custom-tx] send selected runtimes and are selected under
Config > Communications > CAN Bus 1/2 > Data Set in the generic help.
Use the SL4's available CAN interface; the generic two-node wording does not
give the SL4 a second CAN port.

The [scaling tables][scaling] and [additional runtime table][scaling2] document
unsigned 16-bit, low-byte-first values:

| Runtime type | Decode | Important detail |
|---|---|---|
| ECU G / G-force | raw * 0.01 - 10 | Negative values use an offset, not signed two's complement |
| Speed | raw * 0.1 | Confirm configured units and actual selected runtime |

For example, G-force raw 1000 means 0 G, 1100 means +1 G, and 900 means -1 G.
Scaling must match the selected runtime, ECU settings, and receiver definition.

[Predefined Dataset 1][dataset1] includes ethanol plus lateral, longitudinal,
and vertical G-force in message base ID + 8. This confirms broadcast support,
not the layout of an arbitrary Custom TX set. The current project's
[receive layout](../resources/emtron_can.json) does not yet include G-force.
Do not replace an existing dataset or assume a CAN ID is unused.

[Transmit-rate choices][rates] span 10 to 1000 Hz. Sensor output rate, ECU
processing rate, CAN transmit rate, and displayed update rate are different.
An initial 20-50 Hz visualisation is a design target, not a measured capability
or a mandatory ECU setting. Check total bus load before adding traffic.

Before defining new frames, record live runtime names, validity, orientation,
units, CAN IDs, byte placement, scaling, and actual rates. Back up the ECU
configuration and dash map. No transmit configuration was changed for this
investigation.

### What the measurements enable

- G-ball, lateral/longitudinal bars, braking/acceleration peaks.
- Speed versus G-force history or a handling-oriented page.
- Potential experimental relative track sketch using speed and lateral G.

For the last item, lateral acceleration divided by speed approximates turn
rate only under restrictive conditions: approximately flat road, small
sideslip, and suitable steady-cornering assumptions. Convert G to m/s^2 and
speed to m/s first. Banking, body roll, sensor bias, wheelspin, and transients
produce errors; near-zero speed makes division unusable. This is not a measured
yaw-rate signal, GPS positioning, or a reliable automatic lap detector.

## Design upgrades outside maps

The media patch makes image components play animations. It does not by itself
add arbitrary data-driven shader effects, new editor controls, touch gestures,
or a telemetry-to-video binding. The matching
[media component](../build-cfw-native-media-236/HalImage.qml) has an empty
`repaintValue()` implementation: live channel properties do not currently
drive a new animation effect there.

| Design | Inputs / capability | Implementation boundary |
|---|---|---|
| Layered instrument theme | GIF/MP4 background plus stock numeric, bar, dial and indicator components | Best immediate option; retain readable, high-contrast live information |
| Bespoke gauge faces and needles | Custom static assets, fonts, needle images, peak indicators | Stock features documented in v2.30-v2.35 notes; configure and verify the actual editor options |
| Day/night visual identity | Existing day/night image opacity and needle-image settings | Use stock settings where exposed; ambient-driven behavior must be checked, not assumed |
| G-force / handling page | SL4 lateral and longitudinal G over CAN | Requires verified TX/RX mapping and UI access to those channels; a new G-ball component needs implementation |
| Peak/history styling | Existing peak displays; proposed trend strip for speed, boost or temperature | Stock peaks can be configured; sampled history/trails need new logic and bounded storage |
| RPM-reactive visuals | Existing RPM channel and warning thresholds | Stock gauges/indicators now; channel-driven glow, animation speed or media switching requires new component work |
| VTEC/engine-state theme | Existing mapped VTEC, temperatures, RPM or other valid channels | Static indicators may use stock configuration; dynamic theme switching is not supplied by the media patch |
| Shift-light coordination | Stock programmable LED bar and RPM/gear configuration | Keep stock configuration; no arbitrary RGB API or media synchronisation has been established |
| Diagnostics page | Existing voltage, pressures, temperatures, DTC count and CAN status where available | Use verified channels; disconnected/stale values must be distinguishable from healthy zero |
| Animated parked/show page | Short GIF or muted MP4 with static branding | Working playback foundation; this does not establish animated boot-splash support |

Stock feature references: [v2.30 notes](../../research/scratchpad/rn/30-0/releasenotes),
[v2.33 notes](../../research/scratchpad/rn/33-0/releasenotes), and the
[feature summary](FEATURE-PARITY.md). The summary contains older deployment
assumptions; it is not evidence that the standalone app preserves simultaneous
OEM warnings or already runs on the physical unit.

### Recommended visual direction

1. Build a restrained motorsport theme: one subtle media background, custom
   dial face/needle, large RPM and gear, and clear pressure/temperature warnings.
2. Add a handling page once SL4 G-force is mapped: G-ball, peak G, speed, and
   acceleration/braking bars.
3. Implement channel-reactive accents only after proving how live data reaches
   the stock resource component. Preserve the existing editor property contract.
4. Add short bounded trend displays before considering expensive full-screen
   effects or multiple simultaneous videos.

The supplied firmware contains Qt Quick and media support, but physical GPU,
decoder, memory, and sustained frame-rate budgets have not been measured here.
Do not promise a shader-heavy layout, transparent MP4, 60 FPS, or several
concurrent video layers. Standard H.264 MP4 should be treated as opaque; use
static transparent PNG overlays where appropriate and test GIF transparency
on the actual runtime.

Validate one change at a time on the bench: loop playback, page transitions,
cold boot, NSP reconnection, media errors, gauge responsiveness, and warning
visibility. Keep critical information static and legible over moving artwork.
Animation must not obscure or delay alarms; avoid flashing backgrounds and
use visually busy show pages only while parked. No new firmware flash is
needed merely to document these options.

## Hardware evidence limits

### Animated alarms: current v2.36 findings

Offline decoding of the stock v2.36 resources confirms that
`HalAlarmPopup.qml` accepts an alarm model with text, foreground/background
colours, height, and an optional `img` source. The popup stacks active alarms
and currently uses a static QML `Image` for that source.

The GIF/MP4 patch changes `HalImage.qml`, not `HalAlarmPopup.qml`; consequently
it does not automatically animate alarm images. An animated alarm icon is a
feasible separate QML change, but must be implemented and tested in both NSP
preview and the device resources. The alarm image picker and asset transfer
also need verification; an image field does not prove GIF selection is supported.

Replacing an entire alarm bar with artwork is a larger design change. Preserve
active-alarm ordering, simultaneous-alarm stacking, text, contrast, visibility,
and existing acknowledgement/clear behavior. Retain the normal text/colour
alarm if media fails to load, and stop animation when inactive. Alarm state
must remain controlled by the original alarm system, never by animation timing.
No animated-alarm patch or new firmware candidate was created for this finding.

The inspectable reference application is DTN v2.26.9, not the owner's v2.36.
Its zero-return internal-IMU enumeration does not prove that the current
firmware disables a fitted gyro. Likewise, generic radio/device-tree entries
and code shared with uC-10 do not prove BLE, Wi-Fi, camera, extra CAN
transceivers, or spare serial connectors are usable on this iC-7.
None of the above designs depends on assuming those unverified interfaces.

[sl4]: https://docs.emtronaustralia.com.au/engine-management/datasheets/sl4-datasheet/
[accel]: https://docs.emtronaustralia.com.au/engine-management/functions/accelerometer/index.html
[custom-tx]: https://help.emtronaustralia.com.au/emtune/Newtopic347.html
[scaling]: https://help.emtronaustralia.com.au/emtune/ParameterScaling1.html
[scaling2]: https://help.emtronaustralia.com.au/emtune/Newtopic162.html
[dataset1]: https://help.emtronaustralia.com.au/emtune/PredefinedCANTransmitPacket2.html
[rates]: https://help.emtronaustralia.com.au/emtune/TransmitRate1.html
