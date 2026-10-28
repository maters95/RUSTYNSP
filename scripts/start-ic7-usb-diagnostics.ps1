[CmdletBinding()]
param(
    [ValidateSet("Inventory", "Capture", "Identity")]
    [string]$Mode = "Inventory",
    [string]$OutputDirectory = (Join-Path (Get-Location) ("ic7-diagnostics-" + (Get-Date -Format "yyyyMMdd-HHmmss"))),
    [string]$CaptureInterface,
    [ValidateRange(1, 3600)]
    [int]$Seconds = 120,
    [string]$Tshark = "C:\Program Files\Wireshark\tshark.exe",
    [string]$Port,
    [switch]$ConfirmNspClosed,
    [switch]$ConfirmControllerCapture,
    [string]$Python = "py"
)

$ErrorActionPreference = "Stop"
if ([Environment]::OSVersion.Platform -ne [PlatformID]::Win32NT) {
    throw "Run on the Windows PC connected to the iC-7."
}
if (Test-Path -LiteralPath $OutputDirectory) {
    throw "Output directory already exists: $OutputDirectory"
}
if ($Mode -eq "Identity") {
    if (-not $Port -or -not $ConfirmNspClosed) {
        throw "Identity requires -Port COMx -ConfirmNspClosed. Exit NSP before proceeding."
    }
    if (@(Get-Process | Where-Object { $_.ProcessName -match 'NSP|Nexus|dash_virtual' }).Count -gt 0) {
        throw "NSP/Nexus/virtual dash process detected. Close it before querying the port."
    }
}
if ($Mode -eq "Capture") {
    if (-not (Test-Path -LiteralPath $Tshark -PathType Leaf)) {
        throw "tshark not found. Install Wireshark with USBPcap, or set -Tshark."
    }
    & $Tshark -D
    if ($LASTEXITCODE -ne 0) { throw "Unable to enumerate capture interfaces." }
    if (-not $CaptureInterface -or -not $ConfirmControllerCapture) {
        throw "Select the dash's USBPcap interface above; rerun with -CaptureInterface and -ConfirmControllerCapture. The controller capture can contain other devices' private traffic."
    }
    if ($CaptureInterface -notmatch 'USBPcap[0-9]+$') {
        throw "Specify the full USBPcap interface name from tshark -D, not a COM port or network interface."
    }
}

New-Item -ItemType Directory -Path $OutputDirectory | Out-Null
$session = [ordered]@{
    StartedAtUtc = [DateTime]::UtcNow.ToString("o")
    Mode = $Mode
    Status = "incomplete"
    Errors = @()
    Scope = "Local evidence only; no settings, update, resource, reset or address-scan commands."
}
try {
    & (Join-Path $PSScriptRoot "collect-nsp-usb-evidence.ps1") -OutputDirectory (Join-Path $OutputDirectory "inventory")
    $inventory = Get-Content -LiteralPath (Join-Path $OutputDirectory "inventory/report.json") -Raw | ConvertFrom-Json
    $session.InventoryErrors = @($inventory.Errors)
    if ($Mode -eq "Capture") {
        $session.CaptureInterface = $CaptureInterface
        $session.DurationSeconds = $Seconds
        $session.Scope = "Passive USBPcap controller capture; NSP may independently write. No capture filter; snaplen 0."
        Write-Warning "Capture records other USB devices on this controller. Keep it private. Do not upload settings or start an update for this investigation."
        $capturePath = Join-Path (Resolve-Path -LiteralPath $OutputDirectory).Path "usb.pcapng"
        $captureArguments = @("-i", "`"$CaptureInterface`"", "-s", "0", "-a", "duration:$Seconds", "-w", "`"$capturePath`"")
        Write-Output "Starting a $Seconds-second capture. Observe the normal NSP connection now."
        $capture = Start-Process -FilePath $Tshark -ArgumentList $captureArguments -NoNewWindow -Wait -PassThru `
            -RedirectStandardError (Join-Path $OutputDirectory "capture-stderr.txt") `
            -RedirectStandardOutput (Join-Path $OutputDirectory "capture-stdout.txt")
        $session.CaptureExitCode = $capture.ExitCode
        if ($capture.ExitCode -ne 0) { throw "Capture failed; inspect capture-stderr.txt." }
    } elseif ($Mode -eq "Identity") {
        & $Python (Join-Path $PSScriptRoot "ic7-usb-diagnostics.py") identity --port $Port --confirm-nsp-closed --output (Join-Path $OutputDirectory "identity")
        if ($LASTEXITCODE -ne 0) { throw "Identity query failed; inspect identity/report.json if present." }
    }
    $session.Status = if ($session.InventoryErrors.Count -gt 0) { "completed_with_inventory_errors" } else { "completed" }
} catch {
    $session.Errors += $_.Exception.Message
    throw
} finally {
    $session.CompletedAtUtc = [DateTime]::UtcNow.ToString("o")
    $session | ConvertTo-Json -Depth 8 | Set-Content -LiteralPath (Join-Path $OutputDirectory "session.json") -Encoding UTF8
}
Write-Output "Diagnostics written to $OutputDirectory. No firmware or settings commands sent by this collector."
