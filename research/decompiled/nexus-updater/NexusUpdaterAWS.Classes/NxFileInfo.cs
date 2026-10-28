namespace NexusUpdaterAWS.Classes;

public class NxFileInfo
{
	public string RemotePath { get; set; }

	public string LocalPath => LocalPathBuilder.BuildLocalPath(RemotePath);

	public string FileSize { get; set; }

	public string LastModifyDate { get; set; }
}
