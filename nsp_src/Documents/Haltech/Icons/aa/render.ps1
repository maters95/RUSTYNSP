param($mode,$vals,$name)
$d="C:\Users\ZakMasters\Documents\Haltech\Icons\aa"
$icons=@{
 temp='<path fill="#fff" d="M15 13V5a3 3 0 0 0-6 0v8a5 5 0 1 0 6 0zm-3-9a1 1 0 0 1 1 1v3h-2V5a1 1 0 0 1 1-1z"/>';
 oil='<path fill="#fff" d="M3 9h3l2-2h4l1 1 6-2 2 1-6 6H6L3 11zM20 13s-1.5 2-1.5 3a1.5 1.5 0 0 0 3 0c0-1-1.5-3-1.5-3z"/>';
 fuel='<path fill="#fff" d="M19.77 7.23l.01-.01-3.72-3.72L15 4.56l2.11 2.11A2.5 2.5 0 0 0 17.5 11.5c.36 0 .69-.08 1-.21v7.21a1 1 0 0 1-2 0V14a2 2 0 0 0-2-2h-1V5a2 2 0 0 0-2-2H6a2 2 0 0 0-2 2v16h10v-7.5h1.5v5a2.5 2.5 0 0 0 5 0V9c0-.69-.28-1.32-.73-1.77zM12 10H6V5h6v5z"/>';
 air='<path fill="#fff" d="M14.5 17c0 1.65-1.35 3-3 3s-3-1.35-3-3h2a1 1 0 1 0 1-1H2v-2h9.5c1.65 0 3 1.35 3 3zM19 6.5a3.5 3.5 0 0 0-7 0h2a1.5 1.5 0 1 1 1.5 1.5H2v2h13.5A3.5 3.5 0 0 0 19 6.5zM18.5 11H2v2h16.5a1.5 1.5 0 1 1-1.5 1.5h-2a3.5 3.5 0 1 0 3.5-3.5z"/>';
 batt='<path fill="#fff" d="M15.67 4H14V2h-4v2H8.33C7.6 4 7 4.6 7 5.33v15.33C7 21.4 7.6 22 8.33 22h7.33c.74 0 1.34-.6 1.34-1.33V5.33C17 4.6 16.4 4 15.67 4z"/>'}
$chips=@(@('Coolant','temp','#e37400','88','°C'),@('Oil temp','temp','#d93025','96','°C'),@('Oil press','oil','#c5221f','60','psi'),@('Fuel press','fuel','#1a73e8','45','psi'),@('Intake air','air','#12b5cb','32','°C'),@('Battery','batt','#1e8e3e','13.9','V'))
$h=Get-Content -Raw -Encoding UTF8 "$d\aa2.html"; $ch=""
foreach($c in $chips){ $v=if($vals -eq '1'){"<div class=""v"" style=""position:absolute;left:48px;top:24px;font-size:22px;font-weight:500"">$($c[3])</div>"}else{""}; $ch+="<div class=""chip""><div class=""ic"" style=""background:$($c[2])""><svg viewBox=""0 0 24 24"">$($icons[$c[1]])</svg></div><div class=""t"">$($c[0])</div>$v<div class=""uu"">$($c[4])</div></div>" }
$h=$h.Replace('__CHIPS__',$ch).Replace('__MODE__',$mode).Replace('__TIME__','4:20')
if($vals -eq '1'){
  $h=$h.Replace('<div class="lbl">RPM</div>','<div class="v" style="position:absolute;left:108px;top:14px;font-size:54px;font-weight:500">3,450</div><div class="lbl">RPM</div>')
  $h=$h.Replace('<div class="track"></div>','<div class="track"><i style="position:absolute;left:0;top:0;bottom:0;width:38%;background:#fff;border-radius:3px"></i></div>')
  $h=$h.Replace('<div class="speed">','<div class="speed"><div style="position:absolute;left:0;right:0;top:18px;text-align:center;font-size:44px;font-weight:500;color:#202124">62</div>')
  $h=$h.Replace('<div class="g">AFR</div>','<div class="g">AFR</div><div style="position:absolute;left:70px;top:12px;font-size:28px;font-weight:500;color:#e3e3e3">14.7</div>')
  $h=$h.Replace('<div class="mt">','<div class="v" style="position:absolute;left:114px;top:36px;font-size:44px;font-weight:500">14</div><div class="mt">')
  $h=$h.Replace('<div class="prog"></div>','<div class="prog"><i style="position:absolute;left:0;top:0;bottom:0;width:56%;border-radius:2px;background:#fff"></i></div>')
}
Set-Content "$d\$name.html" $h -Encoding UTF8
Start-Process "C:\Program Files\Google\Chrome\Application\chrome.exe" -ArgumentList @('--headless=new','--disable-gpu','--hide-scrollbars','--force-device-scale-factor=1','--allow-file-access-from-files','--window-size=860,480','--virtual-time-budget=6000',"--screenshot=$d\$name.png","file:///C:/Users/ZakMasters/Documents/Haltech/Icons/aa/$name.html") -Wait


