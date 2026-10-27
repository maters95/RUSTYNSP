param([string[]]$Files)
# Shannon entropy (whole file) + count of common container magics
$magics = @{
  'gzip' = [byte[]](0x1F,0x8B,0x08); 'xz' = [byte[]](0xFD,0x37,0x7A,0x58,0x5A); 'ELF' = [byte[]](0x7F,0x45,0x4C,0x46)
  'squashfs' = [byte[]](0x68,0x73,0x71,0x73); 'qres' = [byte[]](0x71,0x72,0x65,0x73); 'PK' = [byte[]](0x50,0x4B,0x03,0x04)
  'zlib9C' = [byte[]](0x78,0x9C); 'uImage' = [byte[]](0x27,0x05,0x19,0x56); 'PNG' = [byte[]](0x89,0x50,0x4E,0x47)
}
foreach ($f in $Files) {
  $b = [IO.File]::ReadAllBytes($f)
  $h = New-Object long[] 256
  foreach ($x in $b) { $h[$x]++ }
  $e = 0.0
  foreach ($c in $h) { if ($c) { $p = $c / $b.Length; $e -= $p * [Math]::Log($p, 2) } }
  $hex = [BitConverter]::ToString($b)
  $hits = foreach ($k in $magics.Keys) {
    $pat = [BitConverter]::ToString($magics[$k])
    $n = ([regex]::Matches($hex, [regex]::Escape($pat))).Count
    "$k=$n"
  }
  "{0}: {1} bytes, entropy {2:N4} bits/byte; {3}" -f (Split-Path $f -Leaf), $b.Length, $e, ($hits -join ' ')
}
