[CmdletBinding()]
param(
    [ValidatePattern('^COM\d+$')][string]$NspPort = 'COM10',
    [ValidatePattern('^COM\d+$')][string]$EmulatorPort = 'COM11',
    [string]$Setupc,
    [int]$RenamePair = -1,
    [switch]$AllowReserved,
    [switch]$Manual,
    [switch]$Apply,
    [switch]$Yes
)
# Dry run by default: prints the detected driver state and the exact setupc commands.
# Only -Apply changes anything, after a typed confirmation (skip with -Yes) and a UAC prompt.
$ErrorActionPreference = 'Stop'
if ([Environment]::OSVersion.Platform -ne [PlatformID]::Win32NT) { throw 'Run this helper on Windows.' }
$python = Join-Path $PSScriptRoot '.venv\Scripts\python.exe'
$prefix = @()
if (-not (Test-Path -LiteralPath $python)) {
    $python = $null
    foreach ($name in @('py', 'python')) {
        $command = @(Get-Command $name -CommandType Application -All -ErrorAction SilentlyContinue |
            Where-Object { $_.Source -notmatch '[\\/]Microsoft[\\/]WindowsApps[\\/]' }) | Select-Object -First 1
        if ($command) {
            $python = $command.Source
            if ($name -eq 'py') { $prefix = @('-3') }
            break
        }
    }
    if (-not $python) { throw 'No Python found. Run .\start-emulator.cmd -ViewerOnly once to create the private environment.' }
}
$arguments = @((Join-Path $PSScriptRoot 'virtual_pair.py'), '--nsp-port', $NspPort, '--emulator-port', $EmulatorPort)
if ($Setupc) { $arguments += @('--setupc', $Setupc) }
if ($RenamePair -ge 0) { $arguments += @('--rename-pair', "$RenamePair") }
if ($AllowReserved) { $arguments += '--allow-reserved' }
if ($Manual) { $arguments += '--manual' }
if ($Apply) { $arguments += '--apply' }
if ($Yes) { $arguments += '--yes' }
& $python @prefix @arguments
exit $LASTEXITCODE
