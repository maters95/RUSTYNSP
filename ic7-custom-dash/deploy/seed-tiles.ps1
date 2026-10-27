# Seed offline map tiles for ic7dash into tiles/<z>/<x>/<y>.png.
# These are served by the app's built-in loopback tile server, so the map
# works with no internet in the car. Run once per region you care about.
#
#   pwsh deploy/seed-tiles.ps1 -Lat -33.8356 -Lon 151.0820 -SpanLat 0.03 -SpanLon 0.04 -Z1 13 -Z2 16
#
# Default source is ESRI World Street Map (tolerant of light personal use).
# Respect each provider's usage policy; keep areas and zoom ranges modest.
param(
  [double]$Lat = -33.8356,
  [double]$Lon = 151.0820,
  [double]$SpanLat = 0.03,
  [double]$SpanLon = 0.04,
  [int]$Z1 = 13,
  [int]$Z2 = 16,
  [string]$OutDir = "$PSScriptRoot/../tiles",
  [string]$UrlTemplate = "https://server.arcgisonline.com/ArcGIS/rest/services/World_Street_Map/MapServer/tile/{z}/{y}/{x}"
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
         if((Get-Item $f).Length -lt 500){ $bad++ } else { $ok++ } }catch{ $bad++ }
  }}
}
Write-Host "seeded $ok tiles ($bad failed) into $OutDir"
Write-Host "Deploy these to /opt/applications/ic7overlay/tiles/ on the dash."
