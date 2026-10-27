using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace NexusUpdaterAWS;

[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "CheckForUpdatesResult", Namespace = "http://schemas.datacontract.org/2004/07/NexusUpdaterAWS")]
public class CheckForUpdatesResult : IExtensibleDataObject
{
	private ExtensionDataObject Cy;

	private string CZ;

	private bool Cz;

	private string cA;

	private bool ca;

	private bool cB;

	private bool cb;

	public ExtensionDataObject ExtensionData
	{
		get
		{
			return Cy;
		}
		set
		{
			Cy = value;
		}
	}

	[DataMember]
	public string CheckSoftwareUpdatesErrorMessage
	{
		get
		{
			return CZ;
		}
		set
		{
			CZ = value;
		}
	}

	[DataMember]
	public bool CheckSoftwareUpdatesSuccess
	{
		get
		{
			return Cz;
		}
		set
		{
			Cz = value;
		}
	}

	[DataMember]
	public string CheckSupportFilesUpdatesErrorMessage
	{
		get
		{
			return cA;
		}
		set
		{
			cA = value;
		}
	}

	[DataMember]
	public bool CheckSupportFilesUpdatesSuccess
	{
		get
		{
			return ca;
		}
		set
		{
			ca = value;
		}
	}

	[DataMember]
	public bool NewSoftwareAvailable
	{
		get
		{
			return cB;
		}
		set
		{
			cB = value;
		}
	}

	[DataMember]
	public bool NewSupportFilesAvailable
	{
		get
		{
			return cb;
		}
		set
		{
			cb = value;
		}
	}
}
