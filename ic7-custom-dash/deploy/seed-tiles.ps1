# Seed offline map tiles for ic7dash into tiles/<z>/<x>/<y>.png.
# These are served by the app's built-in loopback tile server, so the map
# works with no internet in the car. Run once per region you care about.
#
#   pwsh deploy/seed-tiles.ps1 -UrlTemplate 'https://authorized-source/{z}/{x}/{y}.png' `
#     -Attribution 'Provider-required map credit'
#
# The caller must provide a source URL template and required attribution.
# Use only a source/license that explicitly allows offline extraction and caching.
param(
  [double]$Lat = -29.6903,
  [double]$Lon = 152.9333,
  [double]$SpanLat = 0.06,
  [double]$SpanLon = 0.08,
  [int]$Z1 = 13,
  [int]$Z2 = 15,
  [string]$OutDir = "$PSScriptRoot/../tiles",
  [Parameter(Mandatory=$true)]
  [string]$UrlTemplate,
  [Parameter(Mandatory=$true)]
  [string]$Attribution
)
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
function L2X($lon,$z){ [math]::Floor((($lon+180)/360)*[math]::Pow(2,$z)) }
function L2Y($lat,$z){ $r=$lat*[math]::PI/180; [math]::Floor((1-[math]::Log([math]::Tan($r)+1/[math]::Cos($r))/[math]::PI)/2*[math]::Pow(2,$z)) }
$ok=0; $bad=0
foreach($z in $Z1..$Z2){
  $x1=L2X ($Lon-$SpanLon) $z; $x2=L2X ($Lon+$SpanLon) $z
  $y1=L2Y ($Lat+$SpanLat) $z; $y2=L2Y ($Lat-$SpanLat) $z
  foreach($x in $x1..$x2){ foreach($y in $y1..$y2){
    $d="$OutDir/$z/$x"; New-Item -ItemType Directory -Force $d | Out-Null
    $f="$d/$y.png"
    $u=$UrlTemplate.Replace('{z}',$z).Replace('{x}',$x).Replace('{y}',$y)
    try{ Invoke-WebRequest -UseBasicParsing -Headers @{'User-Agent'='ic7dash-dev/1.0'} $u -OutFile $f
         if((Get-Item $f).Length -lt 500){ $bad++; Remove-Item $f -ErrorAction SilentlyContinue }
         else{ $ok++ } }catch{ $bad++; Remove-Item $f -ErrorAction SilentlyContinue }
    Start-Sleep -Milliseconds 200
  }}
}
if($bad -gt 0){ throw "Tile seeding incomplete: $ok succeeded, $bad failed; fix the source/area and retry." }
Set-Content -Path "$OutDir/ATTRIBUTION.txt" -Value $Attribution -Encoding UTF8
Write-Host "seeded $ok tiles into $OutDir"
Write-Host "Deploy these to /opt/applications/ic7overlay/tiles/ on the dash."
