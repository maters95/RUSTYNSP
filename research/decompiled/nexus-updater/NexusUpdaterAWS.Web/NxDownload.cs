using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using NexusUpdaterAWS.Classes;
using NexusUpdaterAWS.Components;
using NexusUpdaterAWS.Runtime;
using NexusUpdaterAWS.Utils;

namespace NexusUpdaterAWS.Web;

internal class NxDownload
{
	private static string Domain
	{
		get
		{
			if (SvcRuntime.DebugMode)
			{
				return "https://d2mu6gj0qc1zai.cloudfront.net/";
			}
			return "https://d1emdrnpilley9.cloudfront.net/";
		}
	}

	public static async Task<string> DownloadFileAWS(NxFileInfo fileinfo)
	{
		try
		{
			using WebClient webClient = new WebClient();
			await webClient.DownloadFileTaskAsync(fileinfo.RemotePath, Directories.MyProgramDataFolder + "dl\\" + Path.GetFileName(fileinfo.LocalPath));
		}
		catch (Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry(Path.GetFileName(fileinfo.LocalPath) + " download failed: " + ex.Message, (EventLogEntryType)1);
			return string.Empty;
		}
		return Directories.MyProgramDataFolder + "dl\\" + Path.GetFileName(fileinfo.LocalPath);
	}

	public static async Task<string> DownloadFileAWS(string key)
	{
		try
		{
			using WebClient webClient = new WebClient();
			await webClient.DownloadFileTaskAsync(Domain + key, Directories.MyProgramDataFolder + "dl\\" + Path.GetFileName(key));
		}
		catch (Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry(Path.GetFileName(key) + " download failed: " + ex.Message, (EventLogEntryType)1);
			return string.Empty;
		}
		return Directories.MyProgramDataFolder + "dl\\" + Path.GetFileName(key);
	}

	public static string DownloadFileAWSParallel(string key)
	{
		bool hasError = false;
		bool hasFinishedDownloading = false;
		SvcRuntime.CurrentFileDownloaded = Path.GetFileName(key);
		try
		{
			using WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += (object s, DownloadProgressChangedEventArgs e) =>
			{
				SvcRuntime.CurrentFileProgressPercent = e.ProgressPercentage;
			};
			webClient.DownloadFileCompleted += (object s, AsyncCompletedEventArgs e) =>
			{
				if (e.Error != null)
				{
					hasError = true;
				}
				hasFinishedDownloading = true;
			};
			webClient.DownloadFileAsync(new Uri(Domain + key), Directories.MyProgramDataFolder + "dl\\" + Path.GetFileName(key));
		}
		catch (Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry(Path.GetFileName(key) + " download failed: " + ex.Message, (EventLogEntryType)1);
			return string.Empty;
		}
		while (!hasFinishedDownloading)
		{
			Thread.Sleep(50);
		}
		if (hasError)
		{
			return string.Empty;
		}
		return Directories.MyProgramDataFolder + "dl\\" + Path.GetFileName(key);
	}

	public static bool CopyFile(string src, string dest, DateTime lastmod)
	{
		try
		{
			if (!Directory.Exists(Path.GetDirectoryName(dest)))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(dest));
			}
		}
		catch (Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry("CopyFile " + ex.Message, (EventLogEntryType)1);
			return false;
		}
		if (Enumerable.Contains(SvcRuntime.UserOptInFiles, Path.GetFileName(src)))
		{
			dest = Path.ChangeExtension(dest, ".htemp");
		}
		try
		{
			File.Copy(src, dest, overwrite: true);
		}
		catch (Exception ex2)
		{
			SvcRuntime.EventLog.WriteEntry(Path.GetFileName(src) + " copy failed: " + ex2.Message, (EventLogEntryType)1);
			return false;
		}
		File.SetLastWriteTime(dest, lastmod);
		return true;
	}

	public static bool HandlePendingList()
	{
		foreach (LocalS3Object n in SvcRuntime.PendingCopyList.ToList())
		{
			string dlpath = Directories.MyProgramDataFolder + "dl\\" + Path.GetFileName(n.LocalPath);
			if (File.Exists(dlpath))
			{
				if (CopyFile(dlpath, n.LocalPath, n.LastModified))
				{
					File.Delete(dlpath);
					File.SetLastWriteTime(n.LocalPath, n.LastModified);
					SvcRuntime.PendingCopyList.Remove(n);
					continue;
				}
				SvcRuntime.EventLog.WriteEntry("Pending file " + Path.GetFileName(n.LocalPath) + " failed to copy to " + Path.GetDirectoryName(n.LocalPath) + ".", (EventLogEntryType)1);
			}
			else
			{
				SvcRuntime.PendingCopyList.Remove(n);
			}
		}
		return SvcRuntime.PendingCopyList.Count == 0;
	}
}
