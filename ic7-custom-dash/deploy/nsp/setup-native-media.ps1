[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)][string]$NspInstall,
    [Parameter(Mandatory = $true)][string]$Destination,
    [string]$ArchiveDirectory
)

$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest

function Assert-Hash([string]$Path, [string]$Expected) {
    if ((Get-FileHash -LiteralPath $Path -Algorithm SHA256).Hash -ne $Expected) {
        throw "SHA-256 mismatch: $Path"
    }
}

$source = (Resolve-Path -LiteralPath $NspInstall).Path
$target = [System.IO.Path]::GetFullPath($Destination)
if (-not (Test-Path -LiteralPath (Join-Path $source 'NSP.exe'))) {
    throw 'NspInstall must be the complete NSP 1.48.5 installation directory.'
}
if ((Test-Path -LiteralPath $target) -or $target.StartsWith($source + [System.IO.Path]::DirectorySeparatorChar, [StringComparison]::OrdinalIgnoreCase)) {
    throw 'Destination must be a NEW directory outside the official NSP installation.'
}
if ([Diagnostics.FileVersionInfo]::GetVersionInfo((Join-Path $source 'NSP.dll')).FileVersion -notmatch '^1\.48\.5(?:\.|$)') {
    throw 'Only NSP 1.48.5 is supported.'
}
if (Get-Process -Name NSP,dash_virtual -ErrorAction SilentlyContinue) {
    throw 'Close all NSP and dash_virtual windows before setup. No process was stopped.'
}

$bundle = Join-Path $PSScriptRoot 'NSP-test/NSP.dll'
$bundleManifest = Get-Content -LiteralPath (Join-Path $PSScriptRoot 'test-manifest.json') -Raw | ConvertFrom-Json
$dllEntry = @($bundleManifest.artifacts | Where-Object { $_.path -eq 'NSP-test/NSP.dll' })
if ($dllEntry.Count -ne 1) { throw 'Bundle manifest must contain exactly one NSP.dll.' }
Assert-Hash $bundle $dllEntry[0].sha256
$runtimeManifest = Join-Path $PSScriptRoot 'qt5113-runtime.json'
$runtimeEntry = @($bundleManifest.artifacts | Where-Object { $_.path -eq 'qt5113-runtime.json' })
if ($runtimeEntry.Count -ne 1) { throw 'Bundle manifest is missing the runtime description.' }
Assert-Hash $runtimeManifest $runtimeEntry[0].sha256
$manifest = Get-Content -LiteralPath $runtimeManifest -Raw | ConvertFrom-Json
$sevenZipCommand = Get-Command 7z.exe -ErrorAction SilentlyContinue
$sevenZip = if ($sevenZipCommand) { $sevenZipCommand.Source } else { $null }
if (-not $sevenZip -and (Test-Path -LiteralPath "$env:ProgramFiles/7-Zip/7z.exe")) {
    $sevenZip = "$env:ProgramFiles/7-Zip/7z.exe"
}
$tar = Get-Command tar.exe -ErrorAction SilentlyContinue
if (-not $sevenZip -and -not $tar) {
    throw 'Install 7-Zip or enable Windows tar.exe to extract the verified Qt SDK archives.'
}
$temporary = Join-Path ([System.IO.Path]::GetTempPath()) ('rustynsp-native-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $temporary | Out-Null
try {
    $extract = Join-Path $temporary 'sdk'
    New-Item -ItemType Directory -Path $extract | Out-Null
    foreach ($archive in $manifest.archives) {
        if ($ArchiveDirectory) {
            $download = Join-Path $ArchiveDirectory $archive.name
        } else {
            $download = Join-Path $temporary $archive.name
            [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
            Invoke-WebRequest -UseBasicParsing -Uri $archive.url -OutFile $download
        }
        Assert-Hash $download $archive.sha256
        if ($sevenZip) {
            & $sevenZip x '-y' "-o$extract" $download | Out-Null
        } else {
            & $tar.Source -xf $download -C $extract
        }
        if ($LASTEXITCODE -ne 0) { throw 'Qt SDK extraction failed. Install 7-Zip if Windows tar cannot read 7z archives.' }
    }
    $sdk = Join-Path $extract $manifest.sdk_prefix
    foreach ($file in $manifest.files) {
        Assert-Hash (Join-Path $sdk $file.path) $file.sha256
    }
    # Create the runnable copy only after all downloads and hashes have passed.
    New-Item -ItemType Directory -Path $target | Out-Null
    Get-ChildItem -LiteralPath $source -Force | Copy-Item -Destination $target -Recurse -Force
    Copy-Item -LiteralPath $bundle -Destination (Join-Path $target 'NSP.dll') -Force
    foreach ($file in $manifest.files) {
        $destinationFile = Join-Path (Join-Path $target 'ic7-media-runtime') $file.path
        New-Item -ItemType Directory -Path (Split-Path -Parent $destinationFile) -Force | Out-Null
        Copy-Item -LiteralPath (Join-Path $sdk $file.path) -Destination $destinationFile
    }
    Copy-Item -LiteralPath $runtimeManifest -Destination (Join-Path $target 'ic7-media-runtime/manifest.json')
    Write-Host "Prepared: $target"
    Write-Host 'Keep the dash DISCONNECTED for the first run. Launch NSP.exe from this new directory.'
    Write-Host 'This changes the shared NSP renderer cache when a v2.36 iC-7 map opens. Close this copy before using official NSP.'
} finally {
    if (Test-Path -LiteralPath $temporary) {
        Remove-Item -LiteralPath $temporary -Recurse -Force
    }
}
