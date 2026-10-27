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
		return base.Channel.KnockKnock();
	}

	public System.Threading.Tasks.Task<bool> KnockKnockAsync()
	{
		return base.Channel.KnockKnockAsync();
	}

	public CheckForUpdatesResult CheckForUpdates()
	{
		return base.Channel.CheckForUpdates();
	}

	public System.Threading.Tasks.Task<CheckForUpdatesResult> CheckForUpdatesAsync()
	{
		return base.Channel.CheckForUpdatesAsync();
	}

	public bool UpdateAvailable(ComponentTypeEnum type)
	{
		return base.Channel.UpdateAvailable(type);
	}

	public System.Threading.Tasks.Task<bool> UpdateAvailableAsync(ComponentTypeEnum type)
	{
		return base.Channel.UpdateAvailableAsync(type);
	}

	public int UpdateAvailable1()
	{
		return base.Channel.UpdateAvailable1();
	}

	public System.Threading.Tasks.Task<int> UpdateAvailable1Async()
	{
		return base.Channel.UpdateAvailable1Async();
	}

	public int? ObjectsAvailableTagged(string repoFolderName, S3MetaDataKeyValuePair[] requestList)
	{
		return base.Channel.ObjectsAvailableTagged(repoFolderName, requestList);
	}

	public System.Threading.Tasks.Task<int?> ObjectsAvailableTaggedAsync(string repoFolderName, S3MetaDataKeyValuePair[] requestList)
	{
		return base.Channel.ObjectsAvailableTaggedAsync(repoFolderName, requestList);
	}

	public int? LatestObjectVersionAvailableTagged(string repoFolderName, S3MetaDataKeyValuePair[] requestList)
	{
		return base.Channel.LatestObjectVersionAvailableTagged(repoFolderName, requestList);
	}

	public System.Threading.Tasks.Task<int?> LatestObjectVersionAvailableTaggedAsync(string repoFolderName, S3MetaDataKeyValuePair[] requestList)
	{
		return base.Channel.LatestObjectVersionAvailableTaggedAsync(repoFolderName, requestList);
	}

	public int? DefinitionsAvailable(S3MetaDataKeyValuePair[] requestList)
	{
		return base.Channel.DefinitionsAvailable(requestList);
	}

	public System.Threading.Tasks.Task<int?> DefinitionsAvailableAsync(S3MetaDataKeyValuePair[] requestList)
	{
		return base.Channel.DefinitionsAvailableAsync(requestList);
	}

	public UpdateOutcomes CheckUpdateComplete()
	{
		return base.Channel.CheckUpdateComplete();
	}

	public System.Threading.Tasks.Task<UpdateOutcomes> CheckUpdateCompleteAsync()
	{
		return base.Channel.CheckUpdateCompleteAsync();
	}

	public UpdateOutcomes UpdateManual()
	{
		return base.Channel.UpdateManual();
	}

	public System.Threading.Tasks.Task<UpdateOutcomes> UpdateManualAsync()
	{
		return base.Channel.UpdateManualAsync();
	}

	[EditorBrowsable(/*Could not decode attribute arguments.*/)]
	private GetTaggedObjectsResponse A(GetTaggedObjectsRequest P_0)
	{
		return base.Channel.GetTaggedObjects(P_0);
	}

	GetTaggedObjectsResponse INexusAWSSvcCmd.GetTaggedObjects(GetTaggedObjectsRequest P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		return this.A(P_0);
	}

	public UpdateOutcomes GetTaggedObjects(out string[] downloadedFilePaths)
	{
		GetTaggedObjectsRequest request = new GetTaggedObjectsRequest();
		GetTaggedObjectsResponse taggedObjects = ((INexusAWSSvcCmd)this).GetTaggedObjects(request);
		downloadedFilePaths = taggedObjects.downloadedFilePaths;
		return taggedObjects.GetTaggedObjectsResult;
	}

	public System.Threading.Tasks.Task<GetTaggedObjectsResponse> GetTaggedObjectsAsync(GetTaggedObjectsRequest request)
	{
		return base.Channel.GetTaggedObjectsAsync(request);
	}

	[EditorBrowsable(/*Could not decode attribute arguments.*/)]
	private GetDefinitionObjectsResponse A(GetDefinitionObjectsRequest P_0)
	{
		return base.Channel.GetDefinitionObjects(P_0);
	}

	GetDefinitionObjectsResponse INexusAWSSvcCmd.GetDefinitionObjects(GetDefinitionObjectsRequest P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		return this.A(P_0);
	}

	public UpdateOutcomes GetDefinitionObjects(out string[] downloadedFilePaths)
	{
		GetDefinitionObjectsRequest request = new GetDefinitionObjectsRequest();
		GetDefinitionObjectsResponse definitionObjects = ((INexusAWSSvcCmd)this).GetDefinitionObjects(request);
		downloadedFilePaths = definitionObjects.downloadedFilePaths;
		return definitionObjects.GetDefinitionObjectsResult;
	}

	public System.Threading.Tasks.Task<GetDefinitionObjectsResponse> GetDefinitionObjectsAsync(GetDefinitionObjectsRequest request)
	{
		return base.Channel.GetDefinitionObjectsAsync(request);
	}

	public bool AutoUpdateEnabled()
	{
		return base.Channel.AutoUpdateEnabled();
	}

	public System.Threading.Tasks.Task<bool> AutoUpdateEnabledAsync()
	{
		return base.Channel.AutoUpdateEnabledAsync();
	}

	public bool ToggleAutoUpdate()
	{
		return base.Channel.ToggleAutoUpdate();
	}

	public System.Threading.Tasks.Task<bool> ToggleAutoUpdateAsync()
	{
		return base.Channel.ToggleAutoUpdateAsync();
	}

	public void CreateSchedTask()
	{
		base.Channel.CreateSchedTask();
	}

	public System.Threading.Tasks.Task CreateSchedTaskAsync()
	{
		return base.Channel.CreateSchedTaskAsync();
	}

	public void DeleteSchedTask()
	{
		base.Channel.DeleteSchedTask();
	}

	public System.Threading.Tasks.Task DeleteSchedTaskAsync()
	{
		return base.Channel.DeleteSchedTaskAsync();
	}

	public void SetDebugMode(bool debugMode)
	{
		base.Channel.SetDebugMode(debugMode);
	}

	public System.Threading.Tasks.Task SetDebugModeAsync(bool debugMode)
	{
		return base.Channel.SetDebugModeAsync(debugMode);
	}

	public bool GetDebugMode()
	{
		return base.Channel.GetDebugMode();
	}

	public System.Threading.Tasks.Task<bool> GetDebugModeAsync()
	{
		return base.Channel.GetDebugModeAsync();
	}

	public void SaveLogsToFile(string path)
	{
		base.Channel.SaveLogsToFile(path);
	}

	public System.Threading.Tasks.Task SaveLogsToFileAsync(string path)
	{
		return base.Channel.SaveLogsToFileAsync(path);
	}

	public string GetErrorLogString()
	{
		return base.Channel.GetErrorLogString();
	}

	public System.Threading.Tasks.Task<string> GetErrorLogStringAsync()
	{
		return base.Channel.GetErrorLogStringAsync();
	}

	public void CallInstaller(ComponentTypeEnum type, bool restart)
	{
		base.Channel.CallInstaller(type, restart);
	}

	public System.Threading.Tasks.Task CallInstallerAsync(ComponentTypeEnum type, bool restart)
	{
		return base.Channel.CallInstallerAsync(type, restart);
	}

	public float? GetCurrentDLSpeedKBps()
	{
		return base.Channel.GetCurrentDLSpeedKBps();
	}

	public System.Threading.Tasks.Task<float?> GetCurrentDLSpeedKBpsAsync()
	{
		return base.Channel.GetCurrentDLSpeedKBpsAsync();
	}

	public float? GetCurrentPercentProgress()
	{
		return base.Channel.GetCurrentPercentProgress();
	}

	public System.Threading.Tasks.Task<float?> GetCurrentPercentProgressAsync()
	{
		return base.Channel.GetCurrentPercentProgressAsync();
	}

	public string GetCurrentTaggedFileDownloading()
	{
		return base.Channel.GetCurrentTaggedFileDownloading();
	}

	public System.Threading.Tasks.Task<string> GetCurrentTaggedFileDownloadingAsync()
	{
		return base.Channel.GetCurrentTaggedFileDownloadingAsync();
	}

	public int? GetCurrentTaggedFilePercentProgress()
	{
		return base.Channel.GetCurrentTaggedFilePercentProgress();
	}

	public System.Threading.Tasks.Task<int?> GetCurrentTaggedFilePercentProgressAsync()
	{
		return base.Channel.GetCurrentTaggedFilePercentProgressAsync();
	}

	public float? GetCurrentUpdateCheckProgress()
	{
		return base.Channel.GetCurrentUpdateCheckProgress();
	}

	public System.Threading.Tasks.Task<float?> GetCurrentUpdateCheckProgressAsync()
	{
		return base.Channel.GetCurrentUpdateCheckProgressAsync();
	}

	public string GetCurrentCategory()
	{
		return base.Channel.GetCurrentCategory();
	}

	public System.Threading.Tasks.Task<string> GetCurrentCategoryAsync()
	{
		return base.Channel.GetCurrentCategoryAsync();
	}

	public bool IsUpdaterBusy()
	{
		return base.Channel.IsUpdaterBusy();
	}

	public System.Threading.Tasks.Task<bool> IsUpdaterBusyAsync()
	{
		return base.Channel.IsUpdaterBusyAsync();
	}

	public void AbortCurrentOperation()
	{
		base.Channel.AbortCurrentOperation();
	}

	public System.Threading.Tasks.Task AbortCurrentOperationAsync()
	{
		return base.Channel.AbortCurrentOperationAsync();
	}

	public UpdaterStatus GetCurrentUpdaterStatus()
	{
		return base.Channel.GetCurrentUpdaterStatus();
	}

	public System.Threading.Tasks.Task<UpdaterStatus> GetCurrentUpdaterStatusAsync()
	{
		return base.Channel.GetCurrentUpdaterStatusAsync();
	}

	public UpdateInitiator GetCurrentUpdateInitiator()
	{
		return base.Channel.GetCurrentUpdateInitiator();
	}

	public System.Threading.Tasks.Task<UpdateInitiator> GetCurrentUpdateInitiatorAsync()
	{
		return base.Channel.GetCurrentUpdateInitiatorAsync();
	}
}
