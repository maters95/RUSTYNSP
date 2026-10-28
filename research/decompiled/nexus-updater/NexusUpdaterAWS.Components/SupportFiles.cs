using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NexusUpdaterAWS.Runtime;
using NexusUpdaterAWS.Utils;
using NexusUpdaterAWS.Web;

namespace NexusUpdaterAWS.Components;

internal class SupportFiles
{
	private const string SPLITPHRASE = "h-programdata";

	public static async Task<(bool NewSupportFilesAvailable, string Error)> CheckSupportFileUpdates()
	{
		var (objlist, error) = await AWSOps.ListSupportObjectsAsync();
		SvcRuntime.UpdateCheckProgressPercent += 30f;
		if (objlist == null)
		{
			return (NewSupportFilesAvailable: false, Error: error);
		}
		int count = SyncOps.MarkDeprecated(Directories.CompanyProgramDataFolder + "Nexus\\", objlist, ref SvcRuntime.UpdateCheckProgressPercent, 30f);
		foreach (LocalS3Object l in objlist)
		{
			if (File.Exists(l.LocalPath))
			{
				try
				{
					DateTime localmoddate = File.GetLastWriteTime(l.LocalPath);
					FileInfo fileInfo = new FileInfo(l.LocalPath);
					if (l.LastModified > localmoddate || l.FileSize != fileInfo.Length)
					{
						SvcRuntime.KeysToGet.Add(l);
						count++;
					}
				}
				catch
				{
					Logs.UpdateLog = Logs.UpdateLog + "Failed to get last write time of " + l.LocalPath + Environment.NewLine;
				}
			}
			else
			{
				SvcRuntime.KeysToGet.Add(l);
				count++;
			}
		}
		SvcRuntime.UpdateCheckProgressPercent = 100f;
		return (NewSupportFilesAvailable: count > 0, Error: string.Empty);
	}

	public static async Task<int?> CheckTaggedSupportFilesAND(string repoFolderName, List<S3MetaDataKeyValuePair> requestList)
	{
		new List<LocalS3Object>();
		List<LocalS3Object> objlist = await AWSOps.ListSupportObjectsAsyncByMetadataAND(repoFolderName, requestList, latestVersionOnly: false);
		if (objlist == null)
		{
			return 0;
		}
		int count = SyncOps.MarkDeprecated(Directories.CompanyProgramDataFolder + "Nexus\\", objlist, ref SvcRuntime.UpdateCheckProgressPercent, 90f);
		foreach (LocalS3Object l in objlist)
		{
			if (File.Exists(l.LocalPath))
			{
				try
				{
					DateTime localmoddate = File.GetLastWriteTime(l.LocalPath);
					FileInfo fileInfo = new FileInfo(l.LocalPath);
					if (l.LastModified > localmoddate || l.FileSize != fileInfo.Length)
					{
						SvcRuntime.KeysToGet.Add(l);
						count++;
					}
				}
				catch
				{
					Logs.UpdateLog = Logs.UpdateLog + "Failed to get last write time of " + l.LocalPath + Environment.NewLine;
				}
			}
			else
			{
				SvcRuntime.KeysToGet.Add(l);
				count++;
			}
		}
		SvcRuntime.UpdateCheckProgressPercent = 100f;
		return count;
	}

	public static async Task<int?> CheckTaggedSupportFileLatestVersionAvailable(string repoFolderName, List<S3MetaDataKeyValuePair> requestList)
	{
		new List<LocalS3Object>();
		List<LocalS3Object> objlist = await AWSOps.ListSupportObjectsAsyncByMetadataAND(repoFolderName, requestList, latestVersionOnly: true);
		if (objlist == null)
		{
			return 0;
		}
		foreach (LocalS3Object l in objlist)
		{
			SvcRuntime.KeysToGet.Add(l);
		}
		return 1;
	}

	public static async Task<int?> CheckDefinitions(List<S3MetaDataKeyValuePair> requestList)
	{
		new List<LocalS3Object>();
		List<LocalS3Object> objlist = await AWSOps.ListDefinitionsAsyncByMetadataAND(requestList);
		if (objlist == null)
		{
			return 0;
		}
		int count = 0;
		foreach (LocalS3Object l in objlist)
		{
			if (File.Exists(l.LocalPath))
			{
				try
				{
					DateTime localmoddate = File.GetLastWriteTime(l.LocalPath);
					FileInfo fileInfo = new FileInfo(l.LocalPath);
					if (l.LastModified > localmoddate || l.FileSize != fileInfo.Length)
					{
						SvcRuntime.KeysToGet.Add(l);
						count++;
					}
				}
				catch
				{
					Logs.UpdateLog = Logs.UpdateLog + "Failed to get last write time of " + l.LocalPath + Environment.NewLine;
				}
			}
			else
			{
				SvcRuntime.KeysToGet.Add(l);
				count++;
			}
		}
		SvcRuntime.UpdateCheckProgressPercent = 100f;
		return count;
	}

	public static string GetLocalDefinitionsFolder(string key, out string abspath)
	{
		string[] splits = Regex.Split(key, "h-olddefinitions");
		if (splits.Length < 2)
		{
			abspath = string.Empty;
			return string.Empty;
		}
		string s = splits[1].Remove(0, 1);
		return string.Concat(str2: abspath = s.Replace("/", "\\"), str0: Directories.CompanyProgramDataFolder, str1: "Nexus\\Definitions\\");
	}

	public static string GetLocalPathFromKey(string key, out string abspath)
	{
		string[] splits = Regex.Split(key, "h-programdata");
		if (splits.Length < 2)
		{
			abspath = string.Empty;
			return string.Empty;
		}
		string s = splits[1].Remove(0, 1);
		return string.Concat(str2: abspath = s.Replace("/", "\\"), str0: Directories.CompanyProgramDataFolder, str1: "Nexus\\");
	}
}
