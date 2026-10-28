[CmdletBinding()]
param(
    [string[]]$NspInstallPath = @(),
    [string]$OutputDirectory = (Join-Path (Get-Location) ("nsp-usb-evidence-" + (Get-Date -Format "yyyyMMdd-HHmmss")))
)

$ErrorActionPreference = "Stop"
if ([Environment]::OSVersion.Platform -ne [PlatformID]::Win32NT) {
    throw "Run this collector on the Windows PC running NSP. It does not connect to the dash."
}
if (Test-Path -LiteralPath $OutputDirectory) {
    throw "Output directory already exists: $OutputDirectory"
}

$report = [ordered]@{
    CollectedAtUtc = [DateTime]::UtcNow.ToString("o")
    PowerShellVersion = $PSVersionTable.PSVersion.ToString()
    SerialPorts = @()
    UsbDevices = @()
    UsbDrivers = @()
    NspProcesses = @()
    InstallRoots = @()
    Binaries = @()
    QmlFiles = @()
    FirmwareFiles = @()
    Errors = @()
}

try {
    $report.SerialPorts = @(Get-CimInstance -ClassName Win32_SerialPort |
        Select-Object DeviceID, Name, PNPDeviceID, Status)
    $report.UsbDevices = @(Get-CimInstance -ClassName Win32_PnPEntity |
        Where-Object { $_.PNPDeviceID -match 'VID_16D0|VID_0403' -or $_.Name -match 'Haltech|iC-7|Ingenuity' } |
        Select-Object Name, PNPDeviceID, Service, Status)
} catch {
    $report.Errors += "Device inventory: $($_.Exception.Message)"
}

try {
    $report.UsbDrivers = @(Get-CimInstance -ClassName Win32_PnPSignedDriver |
        Where-Object { $_.DeviceID -match 'VID_16D0|VID_0403' -or $_.DeviceName -match 'Haltech|iC-7|Ingenuity' } |
        Select-Object DeviceName, DeviceID, DriverProviderName, DriverVersion, DriverDate, InfName, IsSigned)
} catch {
    $report.Errors += "USB driver inventory: $($_.Exception.Message)"
}

$candidateRoots = @($NspInstallPath)
foreach ($programFiles in @($env:ProgramFiles, ${env:ProgramFiles(x86)})) {
    if ($programFiles) {
        $haltechRoot = Join-Path $programFiles "Haltech"
        if (Test-Path -LiteralPath $haltechRoot) {
            $candidateRoots += $haltechRoot
        }
    }
}
foreach ($process in @(Get-Process -ErrorAction SilentlyContinue |
        Where-Object { $_.ProcessName -match 'NSP|Nexus|dash_virtual' })) {
    try {
        $executable = $process.Path
        $report.NspProcesses += [ordered]@{ Name = $process.ProcessName; Id = $process.Id; Path = $executable }
        if ($executable) {
            $candidateRoots += Split-Path -Parent $executable
        }
    } catch {
        $report.Errors += "Process inventory: $($_.Exception.Message)"
    }
}

$roots = @($candidateRoots | Where-Object { $_ -and (Test-Path -LiteralPath $_ -PathType Container) } |
    ForEach-Object { (Resolve-Path -LiteralPath $_).Path } | Sort-Object -Unique)
$report.InstallRoots = $roots
$binaryNames = @("NSP.exe", "NSP.dll", "dash_virtual.exe", "Qt5Core.dll")
$qmlNames = @("HalImage.qml", "HalText.qml", "QML_TEMPLATE.qml", "main.qml", "channels.js")
$seenFiles = @{}
$qmlToCopy = @()

foreach ($root in $roots) {
    foreach ($file in @(Get-ChildItem -LiteralPath $root -File -Recurse -ErrorAction SilentlyContinue)) {
        if ($seenFiles.ContainsKey($file.FullName)) { continue }
        $seenFiles[$file.FullName] = $true
        if ($binaryNames -contains $file.Name) {
            $report.Binaries += [ordered]@{
                Path = $file.FullName
                FileVersion = $file.VersionInfo.FileVersion
                ProductVersion = $file.VersionInfo.ProductVersion
                Length = $file.Length
                SHA256 = (Get-FileHash -LiteralPath $file.FullName -Algorithm SHA256).Hash
            }
        }
        if (($qmlNames -contains $file.Name) -and $file.FullName -match 'qml_components_data|qmlroot') {
            $index = $qmlToCopy.Count
            $relativeCopy = "qml/{0:D3}-{1}" -f $index, $file.Name
            $report.QmlFiles += [ordered]@{
                Path = $file.FullName
                EvidenceCopy = $relativeCopy
                Length = $file.Length
                SHA256 = (Get-FileHash -LiteralPath $file.FullName -Algorithm SHA256).Hash
            }
            $qmlToCopy += [ordered]@{ Source = $file.FullName; Destination = $relativeCopy }
        }
    }
}

if ($env:ProgramData) {
    $firmwareRoot = Join-Path $env:ProgramData "Haltech\Nexus\Firmware"
    if (Test-Path -LiteralPath $firmwareRoot) {
        $report.FirmwareFiles = @(Get-ChildItem -LiteralPath $firmwareRoot -Filter "Dash-V2-*.nex" -File |
            Select-Object Name, Length, LastWriteTimeUtc)
    }
}

New-Item -ItemType Directory -Path $OutputDirectory | Out-Null
if ($qmlToCopy.Count -gt 0) {
    New-Item -ItemType Directory -Path (Join-Path $OutputDirectory "qml") | Out-Null
    foreach ($copy in $qmlToCopy) {
        Copy-Item -LiteralPath $copy.Source -Destination (Join-Path $OutputDirectory $copy.Destination)
    }
}
$report | ConvertTo-Json -Depth 8 | Set-Content -LiteralPath (Join-Path $OutputDirectory "report.json") -Encoding UTF8
Write-Output "Evidence written to $OutputDirectory"
Write-Output "No COM port was opened, no NSP files were modified, and no firmware was uploaded."
if ($roots.Count -eq 0) {
    Write-Warning "NSP installation not found. Rerun with -NspInstallPath pointing to the NSP folder."
}
foreach ($errorMessage in $report.Errors) {
    Write-Warning $errorMessage
}