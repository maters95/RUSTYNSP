using System.Runtime.Serialization;

namespace NexusUpdaterAWS;

[DataContract]
public class CheckForUpdatesResult
{
	[DataMember]
	public bool CheckSoftwareUpdatesSuccess = true;

	[DataMember]
	public bool CheckSupportFilesUpdatesSuccess = true;

	[DataMember]
	public string CheckSoftwareUpdatesErrorMessage = string.Empty;

	[DataMember]
	public string CheckSupportFilesUpdatesErrorMessage = string.Empty;

	[DataMember]
	public bool NewSoftwareAvailable;

	[DataMember]
	public bool NewSupportFilesAvailable;
}
