param([string]$In, [string]$Out, [int]$Min = 5)
# ASCII + UTF-16LE strings, like `strings -a` + `strings -el`
$b = [IO.File]::ReadAllBytes($In)
$a = [Text.Encoding]::GetEncoding(28591).GetString($b)
$res = New-Object System.Collections.Generic.List[string]
foreach ($m in [regex]::Matches($a, "[\x20-\x7E]{$Min,}")) { $res.Add($m.Value) }
$u = [Text.Encoding]::Unicode.GetString($b)
foreach ($m in [regex]::Matches($u, "[\x20-\x7E]{$Min,}")) { $res.Add("U:" + $m.Value) }
if ($b.Length -gt 1) {
  $u2 = [Text.Encoding]::Unicode.GetString($b, 1, $b.Length - 1)
  foreach ($m in [regex]::Matches($u2, "[\x20-\x7E]{$Min,}")) { $res.Add("U:" + $m.Value) }
}
[IO.File]::WriteAllLines($Out, $res)
"$($res.Count) strings -> $Out"
