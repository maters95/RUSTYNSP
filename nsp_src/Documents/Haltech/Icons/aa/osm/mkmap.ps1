param($route='')
$d="C:\Users\ZakMasters\Documents\Haltech\Icons\aa\osm"
$latS=-29.6990; $latN=-29.6825; $lonW=152.9235; $lonE=152.9425; $MW=472; $MH=464
$j=Get-Content -Raw "$d\grafton.json" | ConvertFrom-Json
$inv=[Globalization.CultureInfo]::InvariantCulture
function P($g){ ($g | %{ [string]::Format($inv,"{0:0.#},{1:0.#}",(($_.lon-$lonW)/($lonE-$lonW)*$MW),(($latN-$_.lat)/($latN-$latS)*$MH)) }) -join ' ' }
$layers=@{water='';park='';bld='';rail='';res='';ter='';pri='';lbl=''}
foreach($el in $j.elements){
  $t=$el.tags
  if($el.type -eq 'way'){
    $pts=P $el.geometry
    if($t.natural -eq 'water' -or $t.waterway -eq 'riverbank'){ $layers.water+="<polygon points='$pts'/>" }
    elseif($t.leisure -or $t.landuse){ $layers.park+="<polygon points='$pts'/>" }
    elseif($t.building){ $layers.bld+="<polygon points='$pts'/>" }
    elseif($t.railway){ $layers.rail+="<polyline points='$pts'/>" }
    elseif($t.highway -match '^(primary|trunk|motorway)'){ $layers.pri+="<polyline points='$pts'/>" }
    elseif($t.highway -match '^(secondary|tertiary)'){ $layers.ter+="<polyline points='$pts'/>" }
    elseif($t.highway){ $layers.res+="<polyline points='$pts'/>" }
  } elseif($el.type -eq 'relation'){
    foreach($role in @('outer','inner')){
      $segs=New-Object System.Collections.ArrayList
      foreach($m in $el.members){ if($m.geometry -and (($m.role -eq $role) -or ($role -eq 'outer' -and $m.role -eq ''))){ [void]$segs.Add([System.Collections.ArrayList]@($m.geometry)) } }
      while($segs.Count -gt 0){
        $ring=$segs[0]; $segs.RemoveAt(0); $changed=$true
        while($changed){ $changed=$false; $end=$ring[$ring.Count-1]
          for($i=0;$i -lt $segs.Count;$i++){ $sg=$segs[$i]; $a=$sg[0]; $b=$sg[$sg.Count-1]
            if([math]::Abs($a.lat-$end.lat) -lt 1e-7 -and [math]::Abs($a.lon-$end.lon) -lt 1e-7){ $ring.AddRange($sg[1..($sg.Count-1)]); $segs.RemoveAt($i); $changed=$true; break }
            if([math]::Abs($b.lat-$end.lat) -lt 1e-7 -and [math]::Abs($b.lon-$end.lon) -lt 1e-7){ $r=@($sg); [array]::Reverse($r); $ring.AddRange($r[1..($r.Count-1)]); $segs.RemoveAt($i); $changed=$true; break } } }
        $fill= if($role -eq 'outer'){'#17263c'}else{'#242f3e'}
        $layers.water+="<polygon fill='$fill' points='$(P $ring)'/>"
      }
    }
  }
}
$svg=@"
<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 $MW $MH' width='$MW' height='$MH'>
<rect width='$MW' height='$MH' fill='#242f3e'/>
<g fill='#263c3f'>$($layers.park)</g>
<g fill='#17263c'>$($layers.water)</g>
<g fill='#2b3544'>$($layers.bld)</g>
<g fill='none' stroke='#4a5568' stroke-width='1.5' stroke-dasharray='4 3'>$($layers.rail)</g>
<g fill='none' stroke='#38414e' stroke-width='6' stroke-linecap='round' stroke-linejoin='round'>$($layers.res)</g>
<g fill='none' stroke='#3f4a5a' stroke-width='9' stroke-linecap='round' stroke-linejoin='round'>$($layers.ter)</g>
<g fill='none' stroke='#746855' stroke-width='11' stroke-linecap='round' stroke-linejoin='round'>$($layers.pri)</g>
$route
</svg>
"@
Set-Content "$d\map.svg" $svg -Encoding UTF8


