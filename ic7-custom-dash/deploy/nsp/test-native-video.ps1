[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)][string]$VideoPath,
    [string]$OutputPath = (Join-Path (Get-Location) ("nsp-video-probe-" + (Get-Date -Format "yyyyMMdd-HHmmss") + ".json"))
)

$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
if ([Environment]::OSVersion.Platform -ne [PlatformID]::Win32NT) {
    throw 'Run this diagnostic on Windows.'
}
if ([Environment]::Is64BitProcess) {
    throw 'The NSP renderer is 32-bit. Run this probe with C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe.'
}
if (Test-Path -LiteralPath $OutputPath) { throw "Output already exists: $OutputPath" }
$video = (Resolve-Path -LiteralPath $VideoPath).Path
if (-not (Test-Path -LiteralPath $video -PathType Leaf)) { throw 'VideoPath must be a video file.' }

Add-Type -TypeDefinition @'
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace NspVideoProbe {
    [ComImport, Guid("56A868A9-0AD4-11CE-B03A-0020AF0BA770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IGraphBuilder {
        [PreserveSig] int AddFilter(IntPtr filter, [MarshalAs(UnmanagedType.LPWStr)] string name);
        [PreserveSig] int RemoveFilter(IntPtr filter);
        [PreserveSig] int EnumFilters(out IEnumFilters filters);
        [PreserveSig] int FindFilterByName([MarshalAs(UnmanagedType.LPWStr)] string name, out IntPtr filter);
        [PreserveSig] int ConnectDirect(IntPtr output, IntPtr input, IntPtr mediaType);
        [PreserveSig] int Reconnect(IntPtr pin);
        [PreserveSig] int Disconnect(IntPtr pin);
        [PreserveSig] int SetDefaultSyncSource();
        [PreserveSig] int Connect(IntPtr output, IntPtr input);
        [PreserveSig] int Render(IntPtr output);
        [PreserveSig] int RenderFile([MarshalAs(UnmanagedType.LPWStr)] string file,
            [MarshalAs(UnmanagedType.LPWStr)] string playlist);
    }
    [ComImport, Guid("56A86893-0AD4-11CE-B03A-0020AF0BA770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IEnumFilters {
        [PreserveSig] int Next(int count, out IBaseFilter filter, out int fetched);
        [PreserveSig] int Skip(int count);
        [PreserveSig] int Reset();
        [PreserveSig] int Clone(out IEnumFilters copy);
    }
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
    struct FilterInfo {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=128)] public string Name;
        public IntPtr Graph;
    }
    [ComImport, Guid("56A86895-0AD4-11CE-B03A-0020AF0BA770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IBaseFilter {
        [PreserveSig] int GetClassID(out Guid id);
        [PreserveSig] int Stop();
        [PreserveSig] int Pause();
        [PreserveSig] int Run(long start);
        [PreserveSig] int GetState(int timeout, out int state);
        [PreserveSig] int SetSyncSource(IntPtr clock);
        [PreserveSig] int GetSyncSource(out IntPtr clock);
        [PreserveSig] int EnumPins(out IntPtr pins);
        [PreserveSig] int FindPin([MarshalAs(UnmanagedType.LPWStr)] string id, out IntPtr pin);
        [PreserveSig] int QueryFilterInfo(out FilterInfo info);
    }
    public sealed class ProbeResult {
        public string HResult;
        public string Status;
        public string Message;
        public string[] Filters;
    }
    public static class Probe {
        public static string DescribeResult(int hr) {
            if (unchecked((uint)hr) == 0x80040265)
                return "VFW_E_UNSUPPORTED_STREAM: Cannot play back the file: the format is not supported. " +
                    "This does not identify a particular missing splitter or decoder.";
            return hr < 0 ? Marshal.GetExceptionForHR(hr).Message :
                "Graph construction only; decoded frames and Qt presentation are not verified.";
        }
        public static ProbeResult Build(string file) {
            object graphObject = Activator.CreateInstance(Type.GetTypeFromCLSID(
                new Guid("E436EBB3-524F-11CE-9F53-0020AF0BA770"), true));
            IEnumFilters filters = null;
            try {
                var graph = (IGraphBuilder)graphObject;
                int hr = graph.RenderFile(file, null);
                var names = new List<string>();
                int enumeration = graph.EnumFilters(out filters);
                if (enumeration < 0) Marshal.ThrowExceptionForHR(enumeration);
                while (true) {
                    IBaseFilter filter;
                    int fetched;
                    int next = filters.Next(1, out filter, out fetched);
                    if (next < 0) Marshal.ThrowExceptionForHR(next);
                    if (fetched == 0) break;
                    try {
                        FilterInfo info;
                        int query = filter.QueryFilterInfo(out info);
                        if (query < 0) Marshal.ThrowExceptionForHR(query);
                        try { names.Add(info.Name); }
                        finally { if (info.Graph != IntPtr.Zero) Marshal.Release(info.Graph); }
                    } finally { Marshal.ReleaseComObject(filter); }
                }
                return new ProbeResult {
                    HResult = "0x" + unchecked((uint)hr).ToString("X8"),
                    Status = hr < 0 ? "failed" : (hr == 0 ? "graph-built" : "partial-or-warning"),
                    Message = DescribeResult(hr),
                    Filters = names.ToArray()
                };
            } finally {
                if (filters != null) Marshal.ReleaseComObject(filters);
                Marshal.ReleaseComObject(graphObject);
            }
        }
    }
}
'@

$report = [ordered]@{
    CollectedUtc = [DateTime]::UtcNow.ToString('o')
    Architecture = '32-bit'
    VideoPath = $video
    Length = (Get-Item -LiteralPath $video).Length
    SHA256 = (Get-FileHash -LiteralPath $video -Algorithm SHA256).Hash
    Scope = 'Construct a separate DirectShow graph; never call Run/Pause, modify NSP, or contact the dash. Registered filters execute while constructing the graph.'
    Result = $null
    Error = $null
}
try {
    $report.Result = [NspVideoProbe.Probe]::Build($video)
} catch {
    $report.Error = $_.Exception.Message
    throw
} finally {
    $report | ConvertTo-Json -Depth 6 | Set-Content -LiteralPath $OutputPath -Encoding UTF8
}
Write-Output "DirectShow result: $($report.Result.HResult) / $($report.Result.Status)"
Write-Output "Filters: $($report.Result.Filters -join ', ')"
Write-Output "Evidence saved to $OutputPath"
