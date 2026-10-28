param([string]$frames,[string]$out,[double]$fps=30,[uint32]$bitrate=12000000)
Add-Type -AssemblyName System.Runtime.WindowsRuntime
$null=[Windows.Media.Editing.MediaComposition,Windows.Media.Editing,ContentType=WindowsRuntime]
$null=[Windows.Storage.StorageFile,Windows.Storage,ContentType=WindowsRuntime]
$null=[Windows.Media.MediaProperties.MediaEncodingProfile,Windows.Media.MediaProperties,ContentType=WindowsRuntime]
$ms=[System.WindowsRuntimeSystemExtensions].GetMethods()
$asOp=($ms | ?{ $_.Name -eq 'AsTask' -and $_.GetParameters().Count -eq 1 -and $_.GetParameters()[0].ParameterType.Name -eq 'IAsyncOperation`1' })[0]
$asProg=($ms | ?{ $_.Name -eq 'AsTask' -and $_.GetParameters().Count -eq 1 -and $_.GetParameters()[0].ParameterType.Name -eq 'IAsyncOperationWithProgress`2' })[0]
function Await($op,[Type]$t){ $task=$asOp.MakeGenericMethod($t).Invoke($null,@($op)); $task.Wait(-1)|Out-Null; $task.Result }
$comp=New-Object Windows.Media.Editing.MediaComposition
$addM=[System.Collections.Generic.ICollection[Windows.Media.Editing.MediaClip]].GetMethod("Add"); $cntP=[System.Collections.Generic.ICollection[Windows.Media.Editing.MediaClip]].GetProperty("Count")
$dur=[TimeSpan]::FromTicks([long](10000000/$fps))
foreach($f in (Get-ChildItem $frames -Filter *.jpg | Sort Name)){ $sf=Await ([Windows.Storage.StorageFile]::GetFileFromPathAsync($f.FullName)) ([Windows.Storage.StorageFile]); $clip=Await ([Windows.Media.Editing.MediaClip]::CreateFromImageFileAsync($sf,$dur)) ([Windows.Media.Editing.MediaClip]); [void]$addM.Invoke($comp.Clips,@($clip)) }
$folder=Await ([Windows.Storage.StorageFolder]::GetFolderFromPathAsync((Split-Path $out))) ([Windows.Storage.StorageFolder])
$of=Await ($folder.CreateFileAsync((Split-Path $out -Leaf),[Windows.Storage.CreationCollisionOption]::ReplaceExisting)) ([Windows.Storage.StorageFile])
$prof=[Windows.Media.MediaProperties.MediaEncodingProfile]::CreateMp4([Windows.Media.MediaProperties.VideoEncodingQuality]::HD1080p)
$prof.Video.FrameRate.Numerator=[uint32]$fps; $prof.Video.FrameRate.Denominator=1; $prof.Video.Bitrate=$bitrate
$prof.Audio=$null
$op=$comp.RenderToFileAsync($of,[Windows.Media.Editing.MediaTrimmingPreference]::Precise,$prof)
$t=$asProg.MakeGenericMethod([Windows.Media.Transcoding.TranscodeFailureReason],[double]).Invoke($null,@($op)); $t.Wait(-1)|Out-Null
"render: $($t.Result) clips=$($cntP.GetValue($comp.Clips))"


