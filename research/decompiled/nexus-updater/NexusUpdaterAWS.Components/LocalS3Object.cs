using System;
using System.IO;
using NexusUpdaterAWS.Utils;

namespace NexusUpdaterAWS.Components;

public class LocalS3Object
{
	public string ReleaseString = string.Empty;

	public string LocalPath = string.Empty;

	public string AbsolutePath = string.Empty;

	public long FileSize;

	public string Key { get; set; }

	public DateTime LastModified { get; set; }

	public ComponentTypeEnum ComponentType { get; set; }

	public LocalS3Object(string key, ComponentTypeEnum type, DateTime lastmod, long fileSize, string releaseString)
	{
		Key = key;
		LastModified = lastmod;
		FileSize = fileSize;
		ComponentType = type;
		ReleaseString = releaseString;
		switch (type)
		{
		case ComponentTypeEnum.ReleaseNotes:
		case ComponentTypeEnum.EULA:
		case ComponentTypeEnum.Definition:
		case ComponentTypeEnum.Firmware:
		case ComponentTypeEnum.SupportFile:
		case ComponentTypeEnum.Help:
		{
			LocalPath = SupportFiles.GetLocalPathFromKey(Key, out var abspath2);
			AbsolutePath = abspath2;
			break;
		}
		case ComponentTypeEnum.NSP:
		case ComponentTypeEnum.Updater:
		case ComponentTypeEnum.DLV:
			LocalPath = Directories.MyInstallerRepo + Path.GetFileName(Key);
			break;
		case ComponentTypeEnum.OldDefinition:
		{
			LocalPath = SupportFiles.GetLocalDefinitionsFolder(Key, out var abspath);
			AbsolutePath = abspath;
			break;
		}
		}
	}

	public override string ToString()
	{
		return "LocalS3Object for '" + Key + "'";
	}
}
