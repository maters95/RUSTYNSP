@echo off
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0start-stock-renderer.ps1" %*
if errorlevel 1 pause