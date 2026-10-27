using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace NexusUpdaterAWS;

[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "UpdateOutcomes", Namespace = "http://schemas.datacontract.org/2004/07/NexusUpdaterAWS")]
public enum UpdateOutcomes
{
	[EnumMember]
	NoUpdate,
	[EnumMember]
	DownloadInstallFailed,
	[EnumMember]
	CompleteUpdate,
	[EnumMember]
	InitError,
	[EnumMember]
	Timeout,
	[EnumMember]
	Aborted
}
