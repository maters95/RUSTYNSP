using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using NexusUpdaterAWS.Components;

namespace NexusUpdaterAWS;

[ServiceContract]
public interface INexusAWSSvcCmd
{
	[OperationContract]
	bool KnockKnock();

	[OperationContract]
	Task<CheckForUpdatesResult> CheckForUpdates();

	[OperationContract]
	Task<bool> UpdateAvailable(ComponentTypeEnum type);

	[OperationContract]
	Task<int> UpdateAvailable1();

	[OperationContract]
	Task<int?> ObjectsAvailableTagged(string repoFolderName, List<S3MetaDataKeyValuePair> requestList);

	[OperationContract]
	Task<int?> LatestObjectVersionAvailableTagged(string repoFolderName, List<S3MetaDataKeyValuePair> requestList);

	[OperationContract]
	Task<int?> DefinitionsAvailable(List<S3MetaDataKeyValuePair> requestList);

	[OperationContract]
	Task<UpdateOutcomes> CheckUpdateComplete();

	[OperationContract]
	Task<UpdateOutcomes> UpdateManual();

	[OperationContract]
	UpdateOutcomes GetTaggedObjects(out List<string> downloadedFilePaths);

	[OperationContract]
	UpdateOutcomes GetDefinitionObjects(out List<string> downloadedFilePaths);

	[OperationContract]
	bool AutoUpdateEnabled();

	[OperationContract]
	bool ToggleAutoUpdate();

	[OperationContract]
	void CreateSchedTask();

	[OperationContract]
	void DeleteSchedTask();

	[OperationContract]
	void SetDebugMode(bool debugMode);

	[OperationContract]
	bool GetDebugMode();

	[OperationContract]
	void SaveLogsToFile(string path);

	[OperationContract]
	string GetErrorLogString();

	[OperationContract]
	void CallInstaller(ComponentTypeEnum type, bool restart);

	[OperationContract]
	float? GetCurrentDLSpeedKBps();

	[OperationContract]
	float? GetCurrentPercentProgress();

	[OperationContract]
	string GetCurrentTaggedFileDownloading();

	[OperationContract]
	int? GetCurrentTaggedFilePercentProgress();

	[OperationContract]
	float? GetCurrentUpdateCheckProgress();

	[OperationContract]
	string GetCurrentCategory();

	[OperationContract]
	bool IsUpdaterBusy();

	[OperationContract]
	void AbortCurrentOperation();

	[OperationContract]
	UpdaterStatus GetCurrentUpdaterStatus();

	[OperationContract]
	UpdateInitiator GetCurrentUpdateInitiator();
}
