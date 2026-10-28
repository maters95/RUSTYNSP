using System.Collections.Generic;
using System.Diagnostics;
using NexusUpdaterAWS.Components;

namespace NexusUpdaterAWS.Runtime;

internal class SvcRuntime
{
	public static NexusAWSSvc MySvc;

	public static UpdaterStatus CurrentUpdaterStatus = UpdaterStatus.Idle;

	public static UpdateInitiator CurrentUpdateInitiator = UpdateInitiator.Other;

	public static bool PendingAbort = false;

	public static bool Aborted = false;

	public static bool DebugMode = false;

	public static List<LocalS3Object> PendingCopyList = new List<LocalS3Object>();

	public static string[] UserOptInFiles = new string[1] { "NSP.exe" };

	public static EventLog EventLog;

	public static List<LocalS3Object> KeysToGet = new List<LocalS3Object>();

	public static List<string> PathsForDeletion = new List<string>();

	public static float? SpeedKB = null;

	public static float? DLProgressPercent = null;

	public static int? CurrentFileProgressPercent = null;

	public static string CurrentFileDownloaded = null;

	public static float? UpdateCheckProgressPercent = null;

	public static string CurrentComponentDownloaded = string.Empty;

	public static bool HasSelfUpdate { get; set; } = false;

	public static bool HasDLVUpdate { get; set; } = false;

	public static void ClearRuntimeLists()
	{
		KeysToGet.Clear();
		PathsForDeletion.Clear();
	}
}
