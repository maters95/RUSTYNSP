param($name)
Add-Type -AssemblyName System.Drawing
$sig='[DllImport("user32.dll")] public static extern bool SetProcessDPIAware();'; try{ Add-Type -MemberDefinition $sig -Name D3 -Namespace U3 }catch{}; [U3.D3]::SetProcessDPIAware()|Out-Null
$b=New-Object System.Drawing.Bitmap 856,476; $g=[System.Drawing.Graphics]::FromImage($b); $g.CopyFromScreen(304,135,0,0,$b.Size)
$o=New-Object System.Drawing.Bitmap 860,480; $g2=[System.Drawing.Graphics]::FromImage($o); $g2.InterpolationMode='HighQualityBicubic'; $g2.DrawImage($b,0,0,860,480)
$o.Save("C:\Users\ZakMasters\Documents\Haltech\Icons\video\ref_$name.png")
