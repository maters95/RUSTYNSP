using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using NexusUpdaterAWS;
using NexusUpdaterAWS.Components;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class NexusAWSSvcCmdClient : ClientBase<INexusAWSSvcCmd>, INexusAWSSvcCmd
{
	public NexusAWSSvcCmdClient()
	{
	}

	public NexusAWSSvcCmdClient(Binding binding, EndpointAddress remoteAddress)
		: base(binding, remoteAddress)
	{
	}

	public bool KnockKnock()
	{
		return Channel.KnockKnock();
	}

	public Task<bool> KnockKnockAsync()
	{
		return Channel.KnockKnockAsync();
	}

	public CheckForUpdatesResult CheckForUpdates()
	{
		return Channel.CheckForUpdates();
	}

	public Task<CheckForUpdatesResult> CheckForUpdatesAsync()
	{
		return Channel.CheckForUpdatesAsync();
	}

	public bool UpdateAvailable(ComponentTypeEnum type)
	{
		return Channel.UpdateAvailable(type);
	}

	public Task<bool> UpdateAvailableAsync(ComponentTypeEnum type)
	{
		return Channel.UpdateAvailableAsync(type);
	}

	public int UpdateAvailable1()
	{
		return Channel.UpdateAvailable1();
	}

	public Task<int> UpdateAvailable1Async()
	{
		return Channel.UpdateAvailable1Async();
	}

	public int? ObjectsAvailableTagged(string repoFolderName, S3MetaDataKeyValuePair[] requestList)
	{
		return Channel.ObjectsAvailableTagged(repoFolderName, requestList);
	}

	public Task<int?> ObjectsAvailableTaggedAsync(string repoFolderName, S3MetaDataKeyValuePair[] requestList)
	{
		return Channel.ObjectsAvailableTaggedAsync(repoFolderName, requestList);
	}

	public int? LatestObjectVersionAvailableTagged(string repoFolderName, S3MetaDataKeyValuePair[] requestList)
	{
		return Channel.LatestObjectVersionAvailableTagged(repoFolderName, requestList);
	}

	public Task<int?> LatestObjectVersionAvailableTaggedAsync(string repoFolderName, S3MetaDataKeyValuePair[] requestList)
	{
		return Channel.LatestObjectVersionAvailableTaggedAsync(repoFolderName, requestList);
	}

	public int? DefinitionsAvailable(S3MetaDataKeyValuePair[] requestList)
	{
		return Channel.DefinitionsAvailable(requestList);
	}

	public Task<int?> DefinitionsAvailableAsync(S3MetaDataKeyValuePair[] requestList)
	{
		return Channel.DefinitionsAvailableAsync(requestList);
	}

	public UpdateOutcomes CheckUpdateComplete()
	{
		return Channel.CheckUpdateComplete();
	}

	public Task<UpdateOutcomes> CheckUpdateCompleteAsync()
	{
		return Channel.CheckUpdateCompleteAsync();
	}

	public UpdateOutcomes UpdateManual()
	{
		return Channel.UpdateManual();
	}

	public Task<UpdateOutcomes> UpdateManualAsync()
	{
		return Channel.UpdateManualAsync();
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	GetTaggedObjectsResponse INexusAWSSvcCmd.GetTaggedObjects(GetTaggedObjectsRequest request)
	{
		return Channel.GetTaggedObjects(request);
	}

	public UpdateOutcomes GetTaggedObjects(out string[] downloadedFilePaths)
	{
		GetTaggedObjectsRequest request = new GetTaggedObjectsRequest();
		GetTaggedObjectsResponse taggedObjects = ((INexusAWSSvcCmd)this).GetTaggedObjects(request);
		downloadedFilePaths = taggedObjects.downloadedFilePaths;
		return taggedObjects.GetTaggedObjectsResult;
	}

	public Task<GetTaggedObjectsResponse> GetTaggedObjectsAsync(GetTaggedObjectsRequest request)
	{
		return Channel.GetTaggedObjectsAsync(request);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	GetDefinitionObjectsResponse INexusAWSSvcCmd.GetDefinitionObjects(GetDefinitionObjectsRequest request)
	{
		return Channel.GetDefinitionObjects(request);
	}

	public UpdateOutcomes GetDefinitionObjects(out string[] downloadedFilePaths)
	{
		GetDefinitionObjectsRequest request = new GetDefinitionObjectsRequest();
		GetDefinitionObjectsResponse definitionObjects = ((INexusAWSSvcCmd)this).GetDefinitionObjects(request);
		downloadedFilePaths = definitionObjects.downloadedFilePaths;
		return definitionObjects.GetDefinitionObjectsResult;
	}

	public Task<GetDefinitionObjectsResponse> GetDefinitionObjectsAsync(GetDefinitionObjectsRequest request)
	{
		return Channel.GetDefinitionObjectsAsync(request);
	}

	public bool AutoUpdateEnabled()
	{
		return Channel.AutoUpdateEnabled();
	}

	public Task<bool> AutoUpdateEnabledAsync()
	{
		return Channel.AutoUpdateEnabledAsync();
	}

	public bool ToggleAutoUpdate()
	{
		return Channel.ToggleAutoUpdate();
	}

	public Task<bool> ToggleAutoUpdateAsync()
	{
		return Channel.ToggleAutoUpdateAsync();
	}

	public void CreateSchedTask()
	{
		Channel.CreateSchedTask();
	}

	public Task CreateSchedTaskAsync()
	{
		return Channel.CreateSchedTaskAsync();
	}

	public void DeleteSchedTask()
	{
		Channel.DeleteSchedTask();
	}

	public Task DeleteSchedTaskAsync()
	{
		return Channel.DeleteSchedTaskAsync();
	}

	public void SetDebugMode(bool debugMode)
	{
		Channel.SetDebugMode(debugMode);
	}

	public Task SetDebugModeAsync(bool debugMode)
	{
		return Channel.SetDebugModeAsync(debugMode);
	}

	public bool GetDebugMode()
	{
		return Channel.GetDebugMode();
	}

	public Task<bool> GetDebugModeAsync()
	{
		return Channel.GetDebugModeAsync();
	}

	public void SaveLogsToFile(string path)
	{
		Channel.SaveLogsToFile(path);
	}

	public Task SaveLogsToFileAsync(string path)
	{
		return Channel.SaveLogsToFileAsync(path);
	}

	public string GetErrorLogString()
	{
		return Channel.GetErrorLogString();
	}

	public Task<string> GetErrorLogStringAsync()
	{
		return Channel.GetErrorLogStringAsync();
	}

	public void CallInstaller(ComponentTypeEnum type, bool restart)
	{
		Channel.CallInstaller(type, restart);
	}

	public Task CallInstallerAsync(ComponentTypeEnum type, bool restart)
	{
		return Channel.CallInstallerAsync(type, restart);
	}

	public float? GetCurrentDLSpeedKBps()
	{
		return Channel.GetCurrentDLSpeedKBps();
	}

	public Task<float?> GetCurrentDLSpeedKBpsAsync()
	{
		return Channel.GetCurrentDLSpeedKBpsAsync();
	}

	public float? GetCurrentPercentProgress()
	{
		return Channel.GetCurrentPercentProgress();
	}

	public Task<float?> GetCurrentPercentProgressAsync()
	{
		return Channel.GetCurrentPercentProgressAsync();
	}

	public string GetCurrentTaggedFileDownloading()
	{
		return Channel.GetCurrentTaggedFileDownloading();
	}

	public Task<string> GetCurrentTaggedFileDownloadingAsync()
	{
		return Channel.GetCurrentTaggedFileDownloadingAsync();
	}

	public int? GetCurrentTaggedFilePercentProgress()
	{
		return Channel.GetCurrentTaggedFilePercentProgress();
	}

	public Task<int?> GetCurrentTaggedFilePercentProgressAsync()
	{
		return Channel.GetCurrentTaggedFilePercentProgressAsync();
	}

	public float? GetCurrentUpdateCheckProgress()
	{
		return Channel.GetCurrentUpdateCheckProgress();
	}

	public Task<float?> GetCurrentUpdateCheckProgressAsync()
	{
		return Channel.GetCurrentUpdateCheckProgressAsync();
	}

	public string GetCurrentCategory()
	{
		return Channel.GetCurrentCategory();
	}

	public Task<string> GetCurrentCategoryAsync()
	{
		return Channel.GetCurrentCategoryAsync();
	}

	public bool IsUpdaterBusy()
	{
		return Channel.IsUpdaterBusy();
	}

	public Task<bool> IsUpdaterBusyAsync()
	{
		return Channel.IsUpdaterBusyAsync();
	}

	public void AbortCurrentOperation()
	{
		Channel.AbortCurrentOperation();
	}

	public Task AbortCurrentOperationAsync()
	{
		return Channel.AbortCurrentOperationAsync();
	}

	public UpdaterStatus GetCurrentUpdaterStatus()
	{
		return Channel.GetCurrentUpdaterStatus();
	}

	public Task<UpdaterStatus> GetCurrentUpdaterStatusAsync()
	{
		return Channel.GetCurrentUpdaterStatusAsync();
	}

	public UpdateInitiator GetCurrentUpdateInitiator()
	{
		return Channel.GetCurrentUpdateInitiator();
	}

	public Task<UpdateInitiator> GetCurrentUpdateInitiatorAsync()
	{
		return Channel.GetCurrentUpdateInitiatorAsync();
	}
}
