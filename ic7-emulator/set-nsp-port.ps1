[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)][ValidatePattern('^COM\d+$')][string]$Port,
    [switch]$Restore,
    [switch]$ListOnly
)
$ErrorActionPreference = 'Stop'
if ([Environment]::OSVersion.Platform -ne [PlatformID]::Win32NT) { throw 'Run this helper on Windows.' }
Add-Type -TypeDefinition @'
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

public static class Ic7VirtualPort {
    [StructLayout(LayoutKind.Sequential)]
    struct DeviceInfo { public uint Size; public Guid ClassGuid; public uint DevInst; public UIntPtr Reserved; }
    [DllImport("setupapi.dll", CharSet=CharSet.Unicode, SetLastError=true)]
    static extern IntPtr SetupDiGetClassDevs(ref Guid guid, string enumerator, IntPtr parent, uint flags);
    [DllImport("setupapi.dll", SetLastError=true)]
    static extern bool SetupDiEnumDeviceInfo(IntPtr set, uint index, ref DeviceInfo info);
    [DllImport("setupapi.dll", SetLastError=true)]
    static extern IntPtr SetupDiOpenDevRegKey(IntPtr set, ref DeviceInfo info, uint scope, uint profile, uint type, uint access);
    [DllImport("advapi32.dll", CharSet=CharSet.Unicode, SetLastError=true)]
    static extern int RegQueryValueEx(IntPtr key, string name, IntPtr reserved, out uint type, byte[] data, ref uint length);
    [DllImport("advapi32.dll")] static extern int RegCloseKey(IntPtr key);
    [DllImport("setupapi.dll", CharSet=CharSet.Unicode, SetLastError=true)]
    static extern bool SetupDiGetDeviceRegistryProperty(IntPtr set, ref DeviceInfo info, uint property, out uint type, byte[] data, uint length, out uint required);
    [DllImport("setupapi.dll", CharSet=CharSet.Unicode, SetLastError=true)]
    static extern bool SetupDiSetDeviceRegistryProperty(IntPtr set, ref DeviceInfo info, uint property, byte[] data, uint length);
    [DllImport("setupapi.dll")] static extern bool SetupDiDestroyDeviceInfoList(IntPtr set);

    public static string Description(string port, string replacement) {
        Guid guid = new Guid("4d36e978-e325-11ce-bfc1-08002be10318");
        IntPtr devices = SetupDiGetClassDevs(ref guid, null, IntPtr.Zero, 2);
        if(devices == new IntPtr(-1)) throw new Win32Exception(Marshal.GetLastWin32Error());
        try {
            for(uint index=0;;index++) {
                DeviceInfo info = new DeviceInfo(); info.Size=(uint)Marshal.SizeOf(typeof(DeviceInfo));
                if(!SetupDiEnumDeviceInfo(devices,index,ref info)) break;
                IntPtr key=SetupDiOpenDevRegKey(devices,ref info,1,0,1,0x20019);
                if(key == new IntPtr(-1)) continue;
                string name;
                try {
                    byte[] data=new byte[1024];uint length=(uint)data.Length;uint type;
                    if(RegQueryValueEx(key,"PortName",IntPtr.Zero,out type,data,ref length)!=0) continue;
                    name=Encoding.Unicode.GetString(data,0,(int)length).TrimEnd('\0');
                } finally { RegCloseKey(key); }
                if(!String.Equals(name,port,StringComparison.OrdinalIgnoreCase)) continue;
                byte[] description=new byte[2048];uint actual;uint registryType;
                if(!SetupDiGetDeviceRegistryProperty(devices,ref info,0,out registryType,description,(uint)description.Length,out actual))
                    throw new Win32Exception(Marshal.GetLastWin32Error());
                string previous=Encoding.Unicode.GetString(description,0,(int)actual).TrimEnd('\0');
                if(replacement!=null) {
                    byte[] value=Encoding.Unicode.GetBytes(replacement+"\0");
                    if(!SetupDiSetDeviceRegistryProperty(devices,ref info,0,value,(uint)value.Length))
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                return previous;
            }
            throw new InvalidOperationException("Port not found in Windows Ports class: "+port);
        } finally { SetupDiDestroyDeviceInfoList(devices); }
    }
}
'@
$previous = [Ic7VirtualPort]::Description($Port, $null)
Write-Output "$Port description: $previous"
if ($ListOnly) { return }
$identity = [Security.Principal.WindowsIdentity]::GetCurrent()
$principal = New-Object Security.Principal.WindowsPrincipal($identity)
if (-not $principal.IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)) {
    throw 'Run this helper in an administrator PowerShell to change the virtual port description.'
}
$matching = @(Get-CimInstance -ClassName Win32_PnPEntity |
    Where-Object { $_.PNPClass -eq 'Ports' -and $_.Name -match ("\(" + [regex]::Escape($Port) + "\)$") })
if ($matching.Count -ne 1) { throw 'Cannot uniquely identify this virtual port in Windows device inventory.' }
if ($matching[0].PNPDeviceID -match '^USB\\|VID_16D0') {
    throw 'This is a physical USB port. Select the NSP-facing port of a virtual serial pair instead.'
}
$backup = Join-Path $PSScriptRoot ("port-" + $Port.ToUpperInvariant() + '.json')
if ($Restore) {
    if (-not (Test-Path -LiteralPath $backup)) { throw "No description backup exists for $Port" }
    $saved = Get-Content -LiteralPath $backup -Raw | ConvertFrom-Json
    if ($previous -ne 'Haltech iC-7 Simulator') { throw 'Port description has changed since setup; inspect before restoring.' }
    [Ic7VirtualPort]::Description($Port, $saved.Description) | Out-Null
    Write-Output "Restored $Port description."
} else {
    if ($previous -match 'Haltech' -and $previous -ne 'Haltech iC-7 Simulator') {
        throw 'This appears to be an actual Haltech port. Disconnect real hardware and select the virtual port.'
    }
    if (-not (Test-Path -LiteralPath $backup)) {
        @{Port=$Port.ToUpperInvariant();Description=$previous} | ConvertTo-Json | Set-Content -LiteralPath $backup -Encoding UTF8
    }
    [Ic7VirtualPort]::Description($Port, 'Haltech iC-7 Simulator') | Out-Null
    Write-Output "Labelled $Port for NSP discovery. Restart NSP after starting the emulator on the other port."
}