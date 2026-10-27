using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace NexusUpdaterAWS;

[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "S3MetaDataKeyValuePair", Namespace = "http://schemas.datacontract.org/2004/07/NexusUpdaterAWS")]
public class S3MetaDataKeyValuePair : IExtensibleDataObject
{
	private ExtensionDataObject cC;

	private string cc;

	private string cD;

	public ExtensionDataObject ExtensionData
	{
		get
		{
			return cC;
		}
		set
		{
			cC = value;
		}
	}

	[DataMember]
	public string Key
	{
		get
		{
			return cc;
		}
		set
		{
			cc = value;
		}
	}

	[DataMember]
	public string Value
	{
		get
		{
			return cD;
		}
		set
		{
			cD = value;
		}
	}
}
