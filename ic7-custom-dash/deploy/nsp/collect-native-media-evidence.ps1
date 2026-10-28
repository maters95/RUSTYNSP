[CmdletBinding()]
param(
    [string]$OutputDirectory = (Join-Path (Get-Location) ("nsp-media-evidence-" + (Get-Date -Format "yyyyMMdd-HHmmss")))
)

$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
if ([Environment]::OSVersion.Platform -ne [PlatformID]::Win32NT) {
    throw 'Run this collector on Windows while the black video is visible in NSP.'
}
if (Test-Path -LiteralPath $OutputDirectory) {
    throw "Output directory already exists: $OutputDirectory"
}
New-Item -ItemType Directory -Path $OutputDirectory | Out-Null
$report = [ordered]@{
    CollectedUtc = [DateTime]::UtcNow.ToString('o')
    Scope = 'Read-only host evidence. No COM port, device commands, runtime changes or process termination.'
    Windows = $null
    CollectorArchitecture = if ([Environment]::Is64BitProcess) { '64-bit' } else { '32-bit' }
    Processes = @()
    Files = @()
    Environment = @()
    Errors = @()
}
$seen = @{}
$roots = @()

function Get-NativeModulePaths([int]$ProcessId) {
    if (-not ('NspMediaDiagnostics.ModuleReader' -as [type])) {
        Add-Type -TypeDefinition @'
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
namespace NspMediaDiagnostics {
    public static class ModuleReader {
        private static InvalidOperationException NativeError(string operation) {
            return new InvalidOperationException(operation + " failed; Win32 error " +
                Marshal.GetLastWin32Error().ToString() + ".");
        }
        [DllImport("kernel32.dll", SetLastError=true)]
        private static extern IntPtr OpenProcess(uint access, bool inherit, int id);
        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(IntPtr handle);
        [DllImport("psapi.dll", SetLastError=true)]
        private static extern bool EnumProcessModulesEx(IntPtr process,
            [Out] IntPtr[] modules, uint size, out uint needed, uint filter);
        [DllImport("psapi.dll", CharSet=CharSet.Unicode, SetLastError=true)]
        private static extern uint GetModuleFileNameEx(IntPtr process,
            IntPtr module, StringBuilder path, uint size);
        public static string[] Read(int id) {
            IntPtr process = OpenProcess(0x410, false, id);
            if (process == IntPtr.Zero) throw NativeError("OpenProcess");
            try {
                IntPtr[] modules = new IntPtr[256];
                uint needed;
                while (true) {
                    if (!EnumProcessModulesEx(process, modules,
                        checked((uint)(modules.Length * IntPtr.Size)), out needed, 3))
                        throw NativeError("EnumProcessModulesEx");
                    if (needed <= modules.Length * IntPtr.Size) break;
                    modules = new IntPtr[checked((int)(needed / IntPtr.Size + 16))];
                }
                var result = new List<string>();
                for (int i = 0; i < needed / IntPtr.Size; i++) {
                    var path = new StringBuilder(32768);
                    uint length = GetModuleFileNameEx(process, modules[i], path, (uint)path.Capacity);
                    if (length == 0) throw NativeError("GetModuleFileNameEx");
                    if (length >= path.Capacity) throw new InvalidOperationException("Module path truncated.");
                    result.Add(path.ToString());
                }
                return result.ToArray();
            } finally { CloseHandle(process); }
        }
    }
}
'@
    }
    [NspMediaDiagnostics.ModuleReader]::Read($ProcessId)
}

function Add-EvidenceFile([string]$Path, [switch]$Copy) {
    if (-not (Test-Path -LiteralPath $Path -PathType Leaf)) { return }
    $resolved = (Resolve-Path -LiteralPath $Path).Path
    if ($seen.ContainsKey($resolved)) { return }
    $seen[$resolved] = $true
    try {
        $file = Get-Item -LiteralPath $resolved
        $entry = [ordered]@{
            Path = $resolved
            Length = $file.Length
            LastWriteUtc = $file.LastWriteTimeUtc.ToString('o')
            SHA256 = (Get-FileHash -LiteralPath $resolved -Algorithm SHA256).Hash
            Version = $file.VersionInfo.FileVersion
            Copy = $null
        }
        if ($Copy) {
            if ($file.Length -gt 20MB) {
                $report.Errors += "Not copied (over 20 MiB): $resolved"
            } else {
                $entry.Copy = '{0:D3}-{1}' -f $report.Files.Count, $file.Name
                Copy-Item -LiteralPath $resolved -Destination (Join-Path $OutputDirectory $entry.Copy)
            }
        }
        $report.Files += $entry
    } catch {
        $report.Errors += "File ${resolved}: $($_.Exception.Message)"
    }
}

try {
    try {
        $report.Windows = Get-CimInstance Win32_OperatingSystem |
            Select-Object Caption, Version, BuildNumber, OSArchitecture
    } catch {
        $report.Errors += "Windows version: $($_.Exception.Message)"
    }
    foreach ($name in @('QT_QUICK_BACKEND', 'QT_OPENGL', 'QT_ANGLE_PLATFORM',
            'QT_PLUGIN_PATH', 'QML2_IMPORT_PATH', 'QT_MULTIMEDIA_PREFERRED_PLUGINS',
            'QT_DEBUG_PLUGINS', 'QT_LOGGING_RULES')) {
        $report.Environment += [ordered]@{
            Name = $name
            CollectorProcess = [Environment]::GetEnvironmentVariable($name, 'Process')
            User = [Environment]::GetEnvironmentVariable($name, 'User')
            Machine = [Environment]::GetEnvironmentVariable($name, 'Machine')
        }
    }
    foreach ($process in @(Get-Process | Where-Object { $_.ProcessName -in @('NSP', 'dash_virtual') })) {
        $entry = [ordered]@{
            Name = $process.ProcessName
            Id = $process.Id
            Path = $null
            StartTime = $null
            ModuleEnumeration = 'System.Diagnostics.Process.Modules'
            ModuleEvidenceComplete = $false
            Modules = @()
        }
        try {
            $entry.Path = $process.Path
            $entry.StartTime = $process.StartTime.ToUniversalTime().ToString('o')
            if ($entry.Path) {
                $roots += Split-Path -Parent $entry.Path
                Add-EvidenceFile $entry.Path
                if ($process.ProcessName -eq 'NSP') {
                    Add-EvidenceFile (Join-Path (Split-Path -Parent $entry.Path) 'NSP.dll')
                    Add-EvidenceFile (Join-Path (Split-Path -Parent $entry.Path) 'ic7-media-runtime/manifest.json') -Copy
                }
            }
            foreach ($module in $process.Modules) {
                $entry.Modules += [ordered]@{
                    Name = $module.ModuleName
                    Path = $module.FileName
                    Version = $module.FileVersionInfo.FileVersion
                }
            }
            if (-not @($entry.Modules | Where-Object { $_.Name -ieq 'Qt5Core.dll' }).Count -and
                    $process.ProcessName -eq 'dash_virtual') {
                $entry.ModuleEnumeration = 'PSAPI EnumProcessModulesEx LIST_MODULES_ALL'
                $nativeModules = @()
                foreach ($path in @(Get-NativeModulePaths $process.Id)) {
                    $nativeModules += [ordered]@{
                        Name = [IO.Path]::GetFileName($path)
                        Path = $path
                        Version = [Diagnostics.FileVersionInfo]::GetVersionInfo($path).FileVersion
                    }
                }
                $entry.Modules = $nativeModules
            }
            $entry.ModuleEvidenceComplete = @($entry.Modules |
                Where-Object { $_.Name -ieq 'Qt5Core.dll' }).Count -gt 0
            if ($process.ProcessName -eq 'dash_virtual' -and -not $entry.ModuleEvidenceComplete) {
                $report.Errors += "Renderer $($process.Id): no Qt5Core.dll enumerated; module evidence is incomplete, not proof Qt/media DLLs are unloaded."
            }
        } catch {
            $report.Errors += "Process $($process.Id): $($_.Exception.Message). Try 64-bit PowerShell with matching permissions."
        }
        $report.Processes += $entry
    }
    if ($report.Processes.Count -eq 0) {
        $report.Errors += 'No NSP or dash_virtual process found. Reproduce the black canvas and collect while NSP stays open.'
    }
    if ($env:APPDATA) {
        $roots += Join-Path $env:APPDATA 'Haltech/Nexus'
    }
    if ($env:LOCALAPPDATA) {
        $roots += Join-Path $env:LOCALAPPDATA 'Haltech/Nexus'
    }
    foreach ($root in @($roots | Sort-Object -Unique)) {
        if (-not (Test-Path -LiteralPath $root -PathType Container)) { continue }
        try {
            foreach ($file in @(Get-ChildItem -LiteralPath $root -Recurse -File -Force |
                    Where-Object { $_.Extension -eq '.log' -or
                        $_.Name -in @('HalImage.qml', 'HalImage.qmlc', 'Qt5Core.dll',
                            'Qt5Multimedia.dll', 'Qt5MultimediaQuick.dll', 'Qt5Widgets.dll',
                            'dsengine.dll', 'wmfengine.dll', 'declarative_multimedia.dll') })) {
                Add-EvidenceFile $file.FullName -Copy:($file.Extension -in @('.log', '.qml'))
            }
        } catch {
            $report.Errors += "Runtime inventory ${root}: $($_.Exception.Message)"
        }
    }
    if (-not @($report.Files | Where-Object { [IO.Path]::GetExtension($_.Path) -eq '.log' }).Count) {
        $report.Errors += 'No renderer/application logs found. dash_virtual uses dash_app.log; absence of a log is not proof of successful playback.'
    }
} finally {
    $report | ConvertTo-Json -Depth 10 |
        Set-Content -LiteralPath (Join-Path $OutputDirectory 'report.json') -Encoding UTF8
}
foreach ($message in $report.Errors) { Write-Warning $message }
Write-Output "Evidence saved to $OutputDirectory"
Write-Output 'Review before sharing: logs contain paths, map names and possibly private settings. DLLs and media were not copied.'
