[CmdletBinding()]
param(
    [int]$ViewerPort = 8765,
    [string]$Runtime = (Join-Path $env:APPDATA 'Haltech\Nexus'),
    [switch]$PatchedImages,
    [string]$Component
)
$ErrorActionPreference = 'Stop'
$python = Join-Path $PSScriptRoot '.venv\Scripts\python.exe'
if (-not (Test-Path -LiteralPath $python)) { throw 'Start the emulator once first to create its Python environment.' }
$arguments = @((Join-Path $PSScriptRoot 'stock_renderer.py'), '--url', "http://127.0.0.1:$ViewerPort", '--runtime', $Runtime)
if ($PatchedImages) { $arguments += '--patched-images' }
if ($Component) {
    if (-not (Test-Path -LiteralPath $Component -PathType Leaf)) { throw "Component not found: $Component" }
    $arguments += @('--component', (Resolve-Path -LiteralPath $Component).Path)
}
& $python @arguments
exit $LASTEXITCODE