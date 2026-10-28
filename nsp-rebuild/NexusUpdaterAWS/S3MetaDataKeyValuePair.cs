using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace NexusUpdaterAWS;

[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "S3MetaDataKeyValuePair", Namespace = "http://schemas.datacontract.org/2004/07/NexusUpdaterAWS")]
public class S3MetaDataKeyValuePair : IExtensibleDataObject
{
	private ExtensionDataObject extensionDataObject_0;

	private string string_0;

	private string string_1;

	public ExtensionDataObject ExtensionData
	{
		get
		{
			return extensionDataObject_0;
		}
		set
		{
			extensionDataObject_0 = value;
		}
	}

	[DataMember]
	public string Key
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	[DataMember]
	public string Value
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}
}
