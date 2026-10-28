using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using NexusUpdaterAWS;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[MessageContract(WrapperName = "GetTaggedObjectsResponse", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
public class GetTaggedObjectsResponse
{
	[MessageBodyMember(Namespace = "http://tempuri.org/", Order = 0)]
	public UpdateOutcomes GetTaggedObjectsResult;

	[MessageBodyMember(Namespace = "http://tempuri.org/", Order = 1)]
	public string[] downloadedFilePaths;

	public GetTaggedObjectsResponse()
	{
	}

	public GetTaggedObjectsResponse(UpdateOutcomes GetTaggedObjectsResult, string[] downloadedFilePaths)
	{
		this.GetTaggedObjectsResult = GetTaggedObjectsResult;
		this.downloadedFilePaths = downloadedFilePaths;
	}
}
