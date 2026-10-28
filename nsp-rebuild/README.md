# Experimental NSP 1.48.5 Media Importer

This is a fresh ILSpy 11.2 decompilation of the supplied NSP 1.48.5 assembly,
renamed with de4dot's unknown-protector symbol pass, then rebuilt as an x86
`.NET 9` Windows Forms project. The vendor binaries are not modified.

The source changes are limited to the Image resource-picker path:

- `ns5/Class237.cs` adds `gif` and `mp4` to Image resource extensions.
- `ns4/Form40.cs` validates GIF bytes through the image decoder and preserves
  the original animated bytes; MP4 is accepted only with an ISO-BMFF `ftyp`
  signature and is uploaded unchanged. The picker uses a video placeholder.

Build on a Windows machine with the .NET 9 Windows Desktop targeting pack, or
from this Linux dev container with Windows targeting enabled:

```sh
dotnet build NSP.csproj --configuration Release \
  -p:EnableWindowsTargeting=true \
  -p:EnableDefaultEmbeddedResourceItems=false \
  -p:NoWarn=WFO1000
```

`WFO1000` is emitted by the .NET 10 WinForms designer analyzer for decompiled
controls; suppressing it here does not suppress compiler errors. The source was
built successfully with zero compiler errors. The replacement DLL retains
assembly identity `NSP, Version=1.48.5.0` and the same external assembly
reference identities as the supplied binary.

The built DLL is an experimental, unsigned test artifact, not a supported NSP
release. Test only in a copy of the NSP installation directory, retaining its
original `NSP.exe`, `.deps.json`, `.runtimeconfig.json`, and dependency DLLs.
Windows execution and import/save/transfer behavior have not yet been tested.