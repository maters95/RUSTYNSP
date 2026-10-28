using System.Runtime.Serialization;

namespace NexusUpdaterAWS;

[DataContract]
public class S3MetaDataKeyValuePair
{
	[DataMember]
	public string Key = string.Empty;

	[DataMember]
	public string Value = string.Empty;
}
