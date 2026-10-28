param([string]$page, [string]$outDir, [double]$seconds = 30, [int]$fps = 30, [string]$times = '', [int]$port = 9333)
# Drives headless Chrome over the DevTools protocol: calls setT(t) in the page and saves a 1920x1080 JPEG per frame.
$ErrorActionPreference = 'Stop'
New-Item -ItemType Directory -Force $outDir | Out-Null
$prof = Join-Path $env:TEMP ("cdp_" + [guid]::NewGuid().ToString('N'))
$url = "file:///" + ($page -replace '\\', '/')
$chrome = Start-Process "C:\Program Files\Google\Chrome\Application\chrome.exe" -PassThru -ArgumentList @(
  '--headless=new', '--disable-gpu', '--hide-scrollbars', '--force-device-scale-factor=1', '--allow-file-access-from-files',
  "--remote-debugging-port=$port", "--user-data-dir=$prof", '--window-size=1920,1080', $url)
try {
  $ws = $null
  for ($i = 0; $i -lt 50 -and -not $ws; $i++) {
    Start-Sleep -Milliseconds 300
    try { $list = Invoke-RestMethod "http://127.0.0.1:$port/json/list" -UseBasicParsing; $ws = ($list | Where-Object { $_.type -eq 'page' } | Select-Object -First 1).webSocketDebuggerUrl } catch {}
  }
  if (-not $ws) { throw "no devtools endpoint" }
  $sock = New-Object System.Net.WebSockets.ClientWebSocket
  $sock.ConnectAsync([uri]$ws, [Threading.CancellationToken]::None).Wait()
  $script:id = 0
  $buf = New-Object byte[] 1048576
  function Call($method, $params) {
    $script:id++
    $msg = @{ id = $script:id; method = $method; params = $params } | ConvertTo-Json -Depth 6 -Compress
    $bytes = [Text.Encoding]::UTF8.GetBytes($msg)
    $sock.SendAsync([ArraySegment[byte]]::new($bytes), 'Text', $true, [Threading.CancellationToken]::None).Wait()
    while ($true) {
      $ms = New-Object IO.MemoryStream
      do { $r = $sock.ReceiveAsync([ArraySegment[byte]]::new($buf), [Threading.CancellationToken]::None).Result; $ms.Write($buf, 0, $r.Count) } while (-not $r.EndOfMessage)
      $txt = [Text.Encoding]::UTF8.GetString($ms.ToArray())
      if ($txt -match ('^\{"id":' + $script:id + ',')) { return $txt }
    }
  }
  [void](Call 'Emulation.setDeviceMetricsOverride' @{ width = 1920; height = 1080; deviceScaleFactor = 1; mobile = $false })
  Start-Sleep -Milliseconds 1500
  [void](Call 'Runtime.evaluate' @{ expression = 'document.fonts.ready.then(()=>Promise.all([...document.images].map(i=>i.decode().catch(()=>0)))).then(()=>1)'; awaitPromise = $true })
  if ($times) { $list = $times.Split(',') | ForEach-Object { [double]$_ } } else { $n = [int]($seconds * $fps); $list = 0..($n - 1) | ForEach-Object { $_ / $fps } }
  $k = 0
  foreach ($t in $list) {
    [void](Call 'Runtime.evaluate' @{ expression = ("setT({0})" -f $t.ToString([Globalization.CultureInfo]::InvariantCulture)) })
    $res = Call 'Page.captureScreenshot' @{ format = 'jpeg'; quality = 93 }
    $b64 = [regex]::Match($res, '"data":"([^"]+)"').Groups[1].Value
    [IO.File]::WriteAllBytes((Join-Path $outDir ("f{0:D5}.jpg" -f $k)), [Convert]::FromBase64String($b64))
    $k++
  }
  "frames: $k"
} finally {
  if ($chrome -and -not $chrome.HasExited) { Stop-Process -Id $chrome.Id -Force -ErrorAction SilentlyContinue }
  Get-Process chrome -ErrorAction SilentlyContinue | Where-Object { $_.Path -and (Get-CimInstance Win32_Process -Filter "ProcessId=$($_.Id)" -ErrorAction SilentlyContinue).CommandLine -match [regex]::Escape($prof) } | Stop-Process -Force -ErrorAction SilentlyContinue
  Start-Sleep -Milliseconds 500
  Remove-Item $prof -Recurse -Force -ErrorAction SilentlyContinue
}


