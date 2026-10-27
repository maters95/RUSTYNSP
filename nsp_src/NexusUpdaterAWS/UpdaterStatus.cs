using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace NexusUpdaterAWS;

[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "UpdaterStatus", Namespace = "http://schemas.datacontract.org/2004/07/NexusUpdaterAWS")]
public enum UpdaterStatus
{
	[EnumMember]
	Idle,
	[EnumMember]
	Checking,
	[EnumMember]
	Downloading
}
