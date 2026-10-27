[CmdletBinding()]
param(
    [string]$Port,
    [switch]$ViewerOnly,
    [int]$ViewerPort = 8765,
    [switch]$NoBrowser,
    [string]$CaptureLog,
    [switch]$MetadataOnly,
    [string]$SandboxPackage,
    [string]$State,
    [switch]$FreshSandbox,
    [switch]$ChooseSandbox,
    [switch]$Workbench
)
$ErrorActionPreference = 'Stop'

if ($ChooseSandbox) {
    if ($SandboxPackage) { throw 'Use either -ChooseSandbox or -SandboxPackage.' }
    Add-Type -AssemblyName System.Windows.Forms
    $picker = New-Object System.Windows.Forms.OpenFileDialog
    $picker.Title = 'Select the extracted resource-only NEX package'
    $picker.Filter = 'NEX package (*.nex)|*.nex'
    $picker.CheckFileExists = $true
    try {
        if ($picker.ShowDialog() -ne [System.Windows.Forms.DialogResult]::OK) { exit 0 }
        $SandboxPackage = $picker.FileName
    } finally {
        $picker.Dispose()
    }
}
if ($SandboxPackage) {
    if (-not (Test-Path -LiteralPath $SandboxPackage -PathType Leaf)) {
        throw 'NEX package not found. Use -ChooseSandbox to select the file from its actual extracted folder.'
    }
    $SandboxPackage = (Resolve-Path -LiteralPath $SandboxPackage).Path
}

function Test-PythonRuntime {
    param([string]$Executable, [string[]]$Arguments = @())
    if (-not $Executable -or $Executable -match '[\\/]Microsoft[\\/]WindowsApps[\\/]') { return $false }
    try {
        & $Executable @Arguments -c 'import sys; sys.exit(0 if sys.version_info >= (3, 11) else 1)' 2>$null
        return $LASTEXITCODE -eq 0
    } catch {
        return $false
    }
}

Set-Location -LiteralPath $PSScriptRoot
if (-not $Workbench -and -not $ViewerOnly -and -not $Port) {
    $Port = Read-Host 'Emulator end of the virtual serial pair (for example COM11)'
}
if (-not $Workbench -and -not $ViewerOnly -and $Port -notmatch '^COM\d+$') {
    throw 'Specify a virtual COM port, for example -Port COM11. Do not select the real dash port.'
}
$python = Join-Path $PSScriptRoot '.venv\Scripts\python.exe'
if (-not (Test-Path -LiteralPath $python)) {
    $candidates = @()
    foreach ($name in @('py', 'python')) {
        $command = Get-Command $name -CommandType Application -ErrorAction SilentlyContinue
        if ($command) {
            $prefix = @()
            if ($name -eq 'py') { $prefix = @('-3') }
            $candidates += @{Executable=$command.Source; Arguments=$prefix}
        }
    }
    if ($env:LOCALAPPDATA) {
        $installations = Join-Path $env:LOCALAPPDATA 'Programs\Python'
        if (Test-Path -LiteralPath $installations) {
            foreach ($installation in @(Get-ChildItem -LiteralPath $installations -Directory | Sort-Object Name -Descending)) {
                $candidates += @{Executable=(Join-Path $installation.FullName 'python.exe'); Arguments=@()}
            }
        }
    }
    $selected = $null
    foreach ($candidate in $candidates) {
        if (Test-PythonRuntime -Executable $candidate.Executable -Arguments $candidate.Arguments) {
            $selected = $candidate
            break
        }
    }
    if (-not $selected) {
        throw 'No working Python 3.11+ was found. Install it with: winget install --exact --id Python.Python.3.13 --scope user. Then reopen PowerShell and rerun this launcher.'
    }
    $executable = $selected.Executable
    $prefix = $selected.Arguments
    & $executable @prefix -m venv (Join-Path $PSScriptRoot '.venv')
    if ($LASTEXITCODE -ne 0 -or -not (Test-Path -LiteralPath $python)) { throw 'Python environment creation failed.' }
}
& $python -m pip --disable-pip-version-check install -r (Join-Path $PSScriptRoot 'requirements.txt')
if ($LASTEXITCODE -ne 0) { throw 'Dependency installation failed.' }
if ($Workbench) {
    $arguments = @((Join-Path $PSScriptRoot 'workbench.py'))
    if ($SandboxPackage) { $arguments += @('--package', $SandboxPackage) }
    & $python @arguments
    exit $LASTEXITCODE
}
$arguments = @((Join-Path $PSScriptRoot 'ic7_emulator.py'), '--viewer-port', "$ViewerPort")
if ($ViewerOnly) { $arguments += '--viewer-only' } else { $arguments += @('--port', $Port) }
if ($NoBrowser) { $arguments += '--no-browser' }
if ($CaptureLog) { $arguments += @('--capture-log', $CaptureLog) }
if ($MetadataOnly) { $arguments += '--metadata-only' }
if ($SandboxPackage) { $arguments += @('--sandbox-package', $SandboxPackage) }
if ($State) { $arguments += @('--state', $State) }
if ($FreshSandbox) { $arguments += '--fresh-sandbox' }
& $python @arguments
exit $LASTEXITCODE