using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using NexusUpdaterAWS;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[MessageContract(WrapperName = "GetDefinitionObjectsResponse", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
public class GetDefinitionObjectsResponse
{
	[MessageBodyMember(Namespace = "http://tempuri.org/", Order = 0)]
	public UpdateOutcomes GetDefinitionObjectsResult;

	[MessageBodyMember(Namespace = "http://tempuri.org/", Order = 1)]
	public string[] downloadedFilePaths;

	public GetDefinitionObjectsResponse()
	{
	}

	public GetDefinitionObjectsResponse(UpdateOutcomes GetDefinitionObjectsResult, string[] downloadedFilePaths)
	{
		this.GetDefinitionObjectsResult = GetDefinitionObjectsResult;
		this.downloadedFilePaths = downloadedFilePaths;
	}
}
