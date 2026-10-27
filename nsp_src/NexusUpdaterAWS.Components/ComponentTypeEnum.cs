using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace NexusUpdaterAWS.Components;

[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "ComponentTypeEnum", Namespace = "http://schemas.datacontract.org/2004/07/NexusUpdaterAWS.Components")]
public enum ComponentTypeEnum
{
	[EnumMember]
	Any,
	[EnumMember]
	ReleaseNotes,
	[EnumMember]
	EULA,
	[EnumMember]
	NSP,
	[EnumMember]
	Updater,
	[EnumMember]
	DLV,
	[EnumMember]
	Definition,
	[EnumMember]
	OldDefinition,
	[EnumMember]
	Firmware,
	[EnumMember]
	SupportFile,
	[EnumMember]
	Help
}
