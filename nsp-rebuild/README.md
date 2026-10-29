# Experimental NSP 1.48.5 Media Importer

This is a fresh ILSpy 11.2 decompilation of the supplied NSP 1.48.5 assembly,
renamed with de4dot's unknown-protector symbol pass, then rebuilt as an x86
`.NET 9` Windows Forms project. The vendor binaries are not modified.

The media changes cover import, persistence and the native dash renderer:

The experimental startup-splash extension additionally embeds the root QML and
`HalSplash.qml`, preserves selected GIF/MP4 splash bytes via ordinary resource
uploads, and saves `ic7_splash.json` with the map. The overlay lasts at most
three seconds at the Qt/application stage; it does not animate the earlier
kernel logo. See the [splash test guide](../ic7-custom-dash/deploy/nsp/SPLASH-TEST.md).

The combined alert candidate additionally embeds `HalAlarmPopup.qml` and adds
**Alert GIF banners and placement...** to the main menu. It stores exact
alert-text-to-image/rectangle overrides in `u/ic7_alerts.json`, offers drag/resize
and numeric placement, and keeps warning text and the application's alarm
logic intact. Ordinary screen media reuses the existing per-screen image
editor. See the [alert test guide](../ic7-custom-dash/deploy/nsp/ALERTS-TEST.md).

- `ns5/Class237.cs` adds `gif` and `mp4` to Image resource extensions.
- `ns4/Form40.cs` validates GIF bytes through the image decoder and preserves
  the original animated bytes; MP4 is accepted only with an ISO-BMFF `ftyp`
  signature and is uploaded unchanged. The picker uses a video placeholder.
- `NSP/MediaResource.cs` recognizes reserved MP4 aliases without consuming the
  original resource stream.
- `NSP/NativeMediaRenderer.cs` stages the matching Qt 5.11.3 x86 add-ons and
  installs the embedded shared media component before the actual iC-7 renderer
  launches in `NSP.UserInterface/VirtualDashAppPanel.cs`. The original verified
  v2.36 component is replaced after each HDEF extraction, not just in the picker.
- `ns2.Control3.resx` preserves the original serialized image-list resource
  contract so the rebuilt application can start.
- Text-valued enums, sizes, points and padding in six form/control resource
  sets use string conversion rather than byte-array conversion. This fixes
  the channel selector's `EnumConverter cannot convert from System.Byte[]`
  exception without changing map data or the dash firmware. Binary image and
  image-list serialization is preserved.

Use the [native media setup and test guide](../ic7-custom-dash/deploy/nsp/NATIVE-MEDIA-TEST.md)
with the matching bundle. Replacing the DLL alone is not sufficient: the native
renderer also needs the pinned multimedia QML module and Windows
DirectShow player plugin and its Qt Widgets dependency. Official Qt archives
are downloaded locally, not bundled.

Build on a Windows machine with the .NET 9 Windows Desktop targeting pack, or
from this Linux dev container with Windows targeting enabled:

```sh
dotnet build NSP.csproj --configuration Release \
  -p:EnableWindowsTargeting=true \
  -p:NoWarn=WFO1000
```

Do not disable default embedded resources: doing so removes the forms' resource
sets and causes a startup `MissingManifestResourceException`. The project
rejects that build option, and regression tests check every original resource
set alongside the added media component.

`WFO1000` is emitted by the .NET 10 WinForms designer analyzer for decompiled
controls; suppressing it here does not suppress compiler errors. The source was
built successfully with zero compiler errors. The replacement DLL retains
assembly identity `NSP, Version=1.48.5.0` and the same external assembly
reference identities as the supplied binary.

The built DLL is an experimental, unsigned test artifact, not a supported NSP
release. Test only in a copy of the NSP installation directory, retaining its
original `NSP.exe`, `.deps.json`, `.runtimeconfig.json`, and dependency DLLs.
Native runtime staging and component behavior have automated tests; Windows
Qt plugin loading, GUI playback and real modified-NEX installation remain
unverified. Earlier owner logs established import/save behavior for the older
picker-only DLL, not native dash playback in this build.