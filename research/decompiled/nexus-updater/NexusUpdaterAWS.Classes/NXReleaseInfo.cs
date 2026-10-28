using System.Collections.Generic;

namespace NexusUpdaterAWS.Classes;

public class NXReleaseInfo
{
	public string ReleaseVersion { get; set; }

	public List<NxFileInfo> ReleaseFiles { get; set; }
}
