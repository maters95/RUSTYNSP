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
    [switch]$Workbench,
    [string]$EngineSim
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
    $pairConfig = Join-Path $PSScriptRoot 'port-pair.json'
    if (Test-Path -LiteralPath $pairConfig) {
        try { $Port = [string](Get-Content -LiteralPath $pairConfig -Raw | ConvertFrom-Json).emulator_port } catch { $Port = $null }
        if ($Port) { Write-Host "Using emulator port $Port from port-pair.json (written by setup-virtual-pair)." }
    }
    if (-not $Port) { $Port = Read-Host 'Emulator end of the virtual serial pair (for example COM11)' }
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
# Install requirements only when they changed or an import fails, so later runs work offline.
$requirements = Join-Path $PSScriptRoot 'requirements.txt'
$stamp = Join-Path $PSScriptRoot '.venv\requirements.sha256'
$wanted = (Get-FileHash -LiteralPath $requirements -Algorithm SHA256).Hash
$installed = ''
if (Test-Path -LiteralPath $stamp) { $installed = (Get-Content -LiteralPath $stamp -Raw).Trim() }
$importsWork = $false
if ($installed -eq $wanted) {
    & $python -c 'import serial, PIL, PyQt5.QtWidgets, cryptography' 2>$null
    $importsWork = $LASTEXITCODE -eq 0
}
if (-not $importsWork) {
    $wheels = Join-Path $PSScriptRoot 'wheels'
    if (Test-Path -LiteralPath $wheels -PathType Container) {
        Write-Host 'Installing dependencies offline from the wheels folder.'
        & $python -m pip --disable-pip-version-check install --no-index --find-links $wheels -r $requirements
    } else {
        Write-Host 'Installing dependencies (first run needs internet access).'
        & $python -m pip --disable-pip-version-check install -r $requirements
    }
    if ($LASTEXITCODE -ne 0) {
        throw ('Dependency installation failed. The first run needs internet access, or a "wheels" folder next to ' +
               'this script made on a connected PC with: py -3 -m pip download -r requirements.txt -d wheels. ' +
               'Later runs reuse .venv and work offline.')
    }
    Set-Content -LiteralPath $stamp -Value $wanted -Encoding ascii
}
if ($Workbench) {
    $arguments = @((Join-Path $PSScriptRoot 'workbench.py'))
    if ($SandboxPackage) { $arguments += @('--package', $SandboxPackage) }
    if ($EngineSim) { $arguments += @('--engine-sim', $EngineSim) }
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
if ($EngineSim) { $arguments += @('--engine-sim', $EngineSim) }
& $python @arguments
exit $LASTEXITCODE