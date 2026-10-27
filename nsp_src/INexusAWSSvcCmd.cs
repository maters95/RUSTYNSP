using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;
using NexusUpdaterAWS;
using NexusUpdaterAWS.Components;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[ServiceContract(ConfigurationName = "INexusAWSSvcCmd")]
public interface INexusAWSSvcCmd
{
	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/KnockKnock", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/KnockKnockResponse")]
	bool KnockKnock();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/KnockKnock", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/KnockKnockResponse")]
	System.Threading.Tasks.Task<bool> KnockKnockAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/CheckForUpdates", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/CheckForUpdatesResponse")]
	CheckForUpdatesResult CheckForUpdates();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/CheckForUpdates", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/CheckForUpdatesResponse")]
	System.Threading.Tasks.Task<CheckForUpdatesResult> CheckForUpdatesAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/UpdateAvailable", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/UpdateAvailableResponse")]
	bool UpdateAvailable(ComponentTypeEnum type);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/UpdateAvailable", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/UpdateAvailableResponse")]
	System.Threading.Tasks.Task<bool> UpdateAvailableAsync(ComponentTypeEnum type);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/UpdateAvailable1", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/UpdateAvailable1Response")]
	int UpdateAvailable1();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/UpdateAvailable1", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/UpdateAvailable1Response")]
	System.Threading.Tasks.Task<int> UpdateAvailable1Async();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/ObjectsAvailableTagged", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/ObjectsAvailableTaggedResponse")]
	int? ObjectsAvailableTagged(string repoFolderName, S3MetaDataKeyValuePair[] requestList);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/ObjectsAvailableTagged", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/ObjectsAvailableTaggedResponse")]
	System.Threading.Tasks.Task<int?> ObjectsAvailableTaggedAsync(string repoFolderName, S3MetaDataKeyValuePair[] requestList);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/LatestObjectVersionAvailableTagged", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/LatestObjectVersionAvailableTaggedResponse")]
	int? LatestObjectVersionAvailableTagged(string repoFolderName, S3MetaDataKeyValuePair[] requestList);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/LatestObjectVersionAvailableTagged", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/LatestObjectVersionAvailableTaggedResponse")]
	System.Threading.Tasks.Task<int?> LatestObjectVersionAvailableTaggedAsync(string repoFolderName, S3MetaDataKeyValuePair[] requestList);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/DefinitionsAvailable", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/DefinitionsAvailableResponse")]
	int? DefinitionsAvailable(S3MetaDataKeyValuePair[] requestList);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/DefinitionsAvailable", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/DefinitionsAvailableResponse")]
	System.Threading.Tasks.Task<int?> DefinitionsAvailableAsync(S3MetaDataKeyValuePair[] requestList);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/CheckUpdateComplete", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/CheckUpdateCompleteResponse")]
	UpdateOutcomes CheckUpdateComplete();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/CheckUpdateComplete", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/CheckUpdateCompleteResponse")]
	System.Threading.Tasks.Task<UpdateOutcomes> CheckUpdateCompleteAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/UpdateManual", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/UpdateManualResponse")]
	UpdateOutcomes UpdateManual();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/UpdateManual", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/UpdateManualResponse")]
	System.Threading.Tasks.Task<UpdateOutcomes> UpdateManualAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetTaggedObjects", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetTaggedObjectsResponse")]
	GetTaggedObjectsResponse GetTaggedObjects(GetTaggedObjectsRequest request);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetTaggedObjects", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetTaggedObjectsResponse")]
	System.Threading.Tasks.Task<GetTaggedObjectsResponse> GetTaggedObjectsAsync(GetTaggedObjectsRequest request);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetDefinitionObjects", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetDefinitionObjectsResponse")]
	GetDefinitionObjectsResponse GetDefinitionObjects(GetDefinitionObjectsRequest request);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetDefinitionObjects", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetDefinitionObjectsResponse")]
	System.Threading.Tasks.Task<GetDefinitionObjectsResponse> GetDefinitionObjectsAsync(GetDefinitionObjectsRequest request);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/AutoUpdateEnabled", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/AutoUpdateEnabledResponse")]
	bool AutoUpdateEnabled();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/AutoUpdateEnabled", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/AutoUpdateEnabledResponse")]
	System.Threading.Tasks.Task<bool> AutoUpdateEnabledAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/ToggleAutoUpdate", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/ToggleAutoUpdateResponse")]
	bool ToggleAutoUpdate();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/ToggleAutoUpdate", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/ToggleAutoUpdateResponse")]
	System.Threading.Tasks.Task<bool> ToggleAutoUpdateAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/CreateSchedTask", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/CreateSchedTaskResponse")]
	void CreateSchedTask();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/CreateSchedTask", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/CreateSchedTaskResponse")]
	System.Threading.Tasks.Task CreateSchedTaskAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/DeleteSchedTask", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/DeleteSchedTaskResponse")]
	void DeleteSchedTask();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/DeleteSchedTask", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/DeleteSchedTaskResponse")]
	System.Threading.Tasks.Task DeleteSchedTaskAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/SetDebugMode", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/SetDebugModeResponse")]
	void SetDebugMode(bool debugMode);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/SetDebugMode", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/SetDebugModeResponse")]
	System.Threading.Tasks.Task SetDebugModeAsync(bool debugMode);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetDebugMode", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetDebugModeResponse")]
	bool GetDebugMode();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetDebugMode", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetDebugModeResponse")]
	System.Threading.Tasks.Task<bool> GetDebugModeAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/SaveLogsToFile", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/SaveLogsToFileResponse")]
	void SaveLogsToFile(string path);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/SaveLogsToFile", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/SaveLogsToFileResponse")]
	System.Threading.Tasks.Task SaveLogsToFileAsync(string path);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetErrorLogString", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetErrorLogStringResponse")]
	string GetErrorLogString();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetErrorLogString", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetErrorLogStringResponse")]
	System.Threading.Tasks.Task<string> GetErrorLogStringAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/CallInstaller", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/CallInstallerResponse")]
	void CallInstaller(ComponentTypeEnum type, bool restart);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/CallInstaller", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/CallInstallerResponse")]
	System.Threading.Tasks.Task CallInstallerAsync(ComponentTypeEnum type, bool restart);

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentDLSpeedKBps", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentDLSpeedKBpsResponse")]
	float? GetCurrentDLSpeedKBps();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentDLSpeedKBps", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentDLSpeedKBpsResponse")]
	System.Threading.Tasks.Task<float?> GetCurrentDLSpeedKBpsAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentPercentProgress", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentPercentProgressResponse")]
	float? GetCurrentPercentProgress();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentPercentProgress", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentPercentProgressResponse")]
	System.Threading.Tasks.Task<float?> GetCurrentPercentProgressAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentTaggedFileDownloading", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentTaggedFileDownloadingResponse")]
	string GetCurrentTaggedFileDownloading();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentTaggedFileDownloading", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentTaggedFileDownloadingResponse")]
	System.Threading.Tasks.Task<string> GetCurrentTaggedFileDownloadingAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentTaggedFilePercentProgress", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentTaggedFilePercentProgressResponse")]
	int? GetCurrentTaggedFilePercentProgress();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentTaggedFilePercentProgress", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentTaggedFilePercentProgressResponse")]
	System.Threading.Tasks.Task<int?> GetCurrentTaggedFilePercentProgressAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentUpdateCheckProgress", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentUpdateCheckProgressResponse")]
	float? GetCurrentUpdateCheckProgress();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentUpdateCheckProgress", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentUpdateCheckProgressResponse")]
	System.Threading.Tasks.Task<float?> GetCurrentUpdateCheckProgressAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentCategory", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentCategoryResponse")]
	string GetCurrentCategory();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentCategory", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentCategoryResponse")]
	System.Threading.Tasks.Task<string> GetCurrentCategoryAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/IsUpdaterBusy", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/IsUpdaterBusyResponse")]
	bool IsUpdaterBusy();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/IsUpdaterBusy", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/IsUpdaterBusyResponse")]
	System.Threading.Tasks.Task<bool> IsUpdaterBusyAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/AbortCurrentOperation", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/AbortCurrentOperationResponse")]
	void AbortCurrentOperation();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/AbortCurrentOperation", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/AbortCurrentOperationResponse")]
	System.Threading.Tasks.Task AbortCurrentOperationAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentUpdaterStatus", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentUpdaterStatusResponse")]
	UpdaterStatus GetCurrentUpdaterStatus();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentUpdaterStatus", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentUpdaterStatusResponse")]
	System.Threading.Tasks.Task<UpdaterStatus> GetCurrentUpdaterStatusAsync();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentUpdateInitiator", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentUpdateInitiatorResponse")]
	UpdateInitiator GetCurrentUpdateInitiator();

	[OperationContract(Action = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentUpdateInitiator", ReplyAction = "http://tempuri.org/INexusAWSSvcCmd/GetCurrentUpdateInitiatorResponse")]
	System.Threading.Tasks.Task<UpdateInitiator> GetCurrentUpdateInitiatorAsync();
}
