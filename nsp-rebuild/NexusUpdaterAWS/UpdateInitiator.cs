using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace NexusUpdaterAWS;

[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "UpdateInitiator", Namespace = "http://schemas.datacontract.org/2004/07/NexusUpdaterAWS")]
public enum UpdateInitiator
{
	[EnumMember]
	OnCustomCommand,
	[EnumMember]
	NSP,
	[EnumMember]
	Other
}
