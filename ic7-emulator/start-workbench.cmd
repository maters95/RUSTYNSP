@echo off
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0start-emulator.ps1" -Workbench %*
if errorlevel 1 pause
