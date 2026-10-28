using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Win32.TaskScheduler;
using NexusUpdaterAWS.Components;
using NexusUpdaterAWS.Runtime;
using NexusUpdaterAWS.Utils;

namespace NexusUpdaterAWS;

public class NexusAWSSvcWCF : INexusAWSSvcCmd
{
	public bool KnockKnock()
	{
		return true;
	}

	public async Task<CheckForUpdatesResult> CheckForUpdates()
	{
		return await SvcRuntime.MySvc.Do_CheckForUpdates();
	}

	public async Task<bool> UpdateAvailable(ComponentTypeEnum type)
	{
		return await SvcRuntime.MySvc.Do_CheckUpdate(type);
	}

	public async Task<int> UpdateAvailable1()
	{
		return await SvcRuntime.MySvc.Do_CheckUpdate1();
	}

	public async Task<int?> ObjectsAvailableTagged(string repoFolderName, List<S3MetaDataKeyValuePair> requestList)
	{
		return await SvcRuntime.MySvc.Do_CheckTaggedObjects_AND(repoFolderName, requestList);
	}

	public async Task<int?> LatestObjectVersionAvailableTagged(string repoFolderName, List<S3MetaDataKeyValuePair> requestList)
	{
		return await SvcRuntime.MySvc.Do_CheckTaggedLatestObjectVersionAvailable(repoFolderName, requestList);
	}

	public async Task<int?> DefinitionsAvailable(List<S3MetaDataKeyValuePair> requestList)
	{
		return await SvcRuntime.MySvc.Do_CheckDefinitions(requestList);
	}

	public async Task<UpdateOutcomes> CheckUpdateComplete()
	{
		if (SvcRuntime.CurrentUpdaterStatus == UpdaterStatus.Idle)
		{
			return await SvcRuntime.MySvc.Do_UpdateProc();
		}
		SvcRuntime.EventLog.WriteEntry("(WCF Call) Updater is busy.", (EventLogEntryType)1);
		return UpdateOutcomes.InitError;
	}

	public async Task<UpdateOutcomes> UpdateManual()
	{
		if (SvcRuntime.CurrentUpdaterStatus == UpdaterStatus.Idle)
		{
			return await SvcRuntime.MySvc.Do_UpdateProcInteractive();
		}
		SvcRuntime.EventLog.WriteEntry("(WCF Call) Updater is busy.", (EventLogEntryType)1);
		return UpdateOutcomes.InitError;
	}

	public UpdateOutcomes GetTaggedObjects(out List<string> downloadedFilePaths)
	{
		if (SvcRuntime.CurrentUpdaterStatus == UpdaterStatus.Idle)
		{
			return SvcRuntime.MySvc.Do_GetTaggedObjects(out downloadedFilePaths);
		}
		SvcRuntime.EventLog.WriteEntry("(WCF Call) Updater is busy.", (EventLogEntryType)1);
		downloadedFilePaths = null;
		return UpdateOutcomes.InitError;
	}

	public UpdateOutcomes GetDefinitionObjects(out List<string> downloadedFilePaths)
	{
		if (SvcRuntime.CurrentUpdaterStatus == UpdaterStatus.Idle)
		{
			return SvcRuntime.MySvc.Do_GetDefinitionObjects(out downloadedFilePaths);
		}
		SvcRuntime.EventLog.WriteEntry("(WCF Call) Updater is busy.", (EventLogEntryType)1);
		downloadedFilePaths = null;
		return UpdateOutcomes.InitError;
	}

	public bool AutoUpdateEnabled()
	{
		bool enabled = false;
		using (TaskService ts = new TaskService())
		{
			if (ts.RootFolder.Tasks.Exists(Directories.MyTaskName))
			{
				enabled = true;
			}
		}
		return enabled;
	}

	public void CreateSchedTask()
	{
		TaskSched.CreateTask();
	}

	public void DeleteSchedTask()
	{
		TaskSched.DeleteTask();
	}

	public void SetDebugMode(bool debugMode)
	{
		SvcRuntime.DebugMode = debugMode;
	}

	public bool GetDebugMode()
	{
		return SvcRuntime.DebugMode;
	}

	public bool ToggleAutoUpdate()
	{
		bool enabled = false;
		bool finalautoupdatestatus = false;
		using (TaskService ts = new TaskService())
		{
			if (ts.RootFolder.Tasks.Exists(Directories.MyTaskName))
			{
				enabled = true;
			}
			if (!enabled)
			{
				TaskSched.CreateTask();
			}
			else
			{
				TaskSched.DeleteTask();
			}
			if (ts.RootFolder.Tasks.Exists(Directories.MyTaskName))
			{
				finalautoupdatestatus = true;
			}
		}
		return finalautoupdatestatus;
	}

	public void SaveLogsToFile(string path)
	{
		Logs.GetAllEntries(path);
	}

	public string GetErrorLogString()
	{
		return Logs.GetErrorEntries();
	}

	public void CallInstaller(ComponentTypeEnum type, bool restart)
	{
		ExternalUpdate.DoExternalUpdate(type, restart);
	}

	public float? GetCurrentDLSpeedKBps()
	{
		return SvcRuntime.SpeedKB;
	}

	public float? GetCurrentPercentProgress()
	{
		return SvcRuntime.DLProgressPercent;
	}

	public string GetCurrentTaggedFileDownloading()
	{
		return SvcRuntime.CurrentFileDownloaded;
	}

	public int? GetCurrentTaggedFilePercentProgress()
	{
		return SvcRuntime.CurrentFileProgressPercent;
	}

	public float? GetCurrentUpdateCheckProgress()
	{
		return SvcRuntime.UpdateCheckProgressPercent;
	}

	public string GetCurrentCategory()
	{
		return SvcRuntime.CurrentComponentDownloaded;
	}

	public UpdaterStatus GetCurrentUpdaterStatus()
	{
		return SvcRuntime.CurrentUpdaterStatus;
	}

	public UpdateInitiator GetCurrentUpdateInitiator()
	{
		return SvcRuntime.CurrentUpdateInitiator;
	}

	public bool IsUpdaterBusy()
	{
		return SvcRuntime.CurrentUpdaterStatus != UpdaterStatus.Idle;
	}

	public void AbortCurrentOperation()
	{
		SvcRuntime.PendingAbort = true;
	}
}
