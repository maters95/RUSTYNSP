using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace NexusUpdaterAWS;

[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "CheckForUpdatesResult", Namespace = "http://schemas.datacontract.org/2004/07/NexusUpdaterAWS")]
public class CheckForUpdatesResult : IExtensibleDataObject
{
	private ExtensionDataObject extensionDataObject_0;

	private string string_0;

	private bool bool_0;

	private string string_1;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

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
	public string CheckSoftwareUpdatesErrorMessage
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
	public bool CheckSoftwareUpdatesSuccess
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	[DataMember]
	public string CheckSupportFilesUpdatesErrorMessage
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

	[DataMember]
	public bool CheckSupportFilesUpdatesSuccess
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	[DataMember]
	public bool NewSoftwareAvailable
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	[DataMember]
	public bool NewSupportFilesAvailable
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}
}
