@echo off
REM Build a self-contained, single-file Windows executable (no .NET install needed).
REM Output: bin\Release\net8.0-windows\win-x64\publish\NexmapUnlock.exe (~63 MB)

dotnet publish -c Release -r win-x64 --self-contained ^
  -p:PublishSingleFile=true ^
  -p:IncludeNativeLibrariesForSelfExtract=true

echo.
echo Done. Executable:
echo   bin\Release\net8.0-windows\win-x64\publish\NexmapUnlock.exe
pause
