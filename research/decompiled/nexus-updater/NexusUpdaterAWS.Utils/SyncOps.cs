using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using NexusUpdaterAWS.Components;
using NexusUpdaterAWS.Runtime;

namespace NexusUpdaterAWS.Utils;

internal class SyncOps
{
	public static int MarkDeprecated(string pathtoclean, List<LocalS3Object> objlist, ref float? progress, float progressRange)
	{
		Stopwatch watch = new Stopwatch();
		watch.Start();
		int numMarked = 0;
		Logs.UpdateLog = Logs.UpdateLog + "Marking deprecated files." + Environment.NewLine;
		string[] files = null;
		try
		{
			if (!Directory.Exists(pathtoclean))
			{
				return 0;
			}
			files = Directory.GetFiles(pathtoclean, "*.*", SearchOption.AllDirectories);
			files = RemoveExclusions(files);
		}
		catch
		{
			files = null;
		}
		if (files != null)
		{
			float? initialProgress = progress;
			for (int i = 0; i < files.Length; i++)
			{
				string s = files[i];
				bool found = false;
				for (int j = 0; j < objlist.Count; j++)
				{
					if (objlist[j].AbsolutePath == GetLocalPathAbsolute(s))
					{
						found = true;
						break;
					}
				}
				if (!found)
				{
					SvcRuntime.PathsForDeletion.Add(s);
					numMarked++;
					Logs.UpdateLog = Logs.UpdateLog + s + " marked for deletion" + Environment.NewLine;
				}
				if (progress.HasValue)
				{
					progress = initialProgress + progressRange * (float)(i + 1) / (float)files.Length;
				}
			}
		}
		watch.Stop();
		Logs.UpdateLog = Logs.UpdateLog + "Files for deletion marked, took " + watch.Elapsed.TotalSeconds + "s" + Environment.NewLine;
		return numMarked;
	}

	public static void PurgeDir(string path)
	{
		if (!Directory.Exists(path))
		{
			return;
		}
		try
		{
			Directory.Delete(path, recursive: true);
		}
		catch (Exception ex)
		{
			Logs.UpdateLog = Logs.UpdateLog + "Failed to delete directory " + path + ": " + ex.Message + Environment.NewLine;
		}
	}

	private static void CleanEmptyFolders(string startLocation)
	{
		if (!Directory.Exists(startLocation))
		{
			return;
		}
		string[] directories = Directory.GetDirectories(startLocation);
		foreach (string directory in directories)
		{
			CleanEmptyFolders(directory);
			if (Directory.GetFiles(directory).Length == 0 && Directory.GetDirectories(directory).Length == 0)
			{
				try
				{
					Directory.Delete(directory, recursive: false);
				}
				catch (Exception ex)
				{
					Logs.UpdateLog = Logs.UpdateLog + "Failed to delete directory " + directory + ": " + ex.Message + Environment.NewLine;
				}
			}
		}
	}

	private static string GetLocalPathAbsolute(string path)
	{
		string[] splits = Regex.Split(path, "Haltech\\\\Nexus\\\\");
		if (splits.Length < 2)
		{
			return string.Empty;
		}
		return splits[1];
	}

	private static string[] RemoveExclusions(string[] paths)
	{
		List<string> pathlist = paths.ToList();
		List<string> fileExceptions = SoftwareApplication.LoadPurgeExceptions();
		foreach (string s in pathlist.ToList())
		{
			Path.GetDirectoryName(s);
			if (Path.GetDirectoryName(s).Contains("\\Haltech\\Nexus\\Firmware"))
			{
				pathlist.Remove(s);
			}
			if (Path.GetDirectoryName(s).Contains("\\Haltech\\Nexus\\Definitions"))
			{
				pathlist.Remove(s);
			}
			if (fileExceptions.Contains(s))
			{
				pathlist.Remove(s);
			}
		}
		return pathlist.ToArray();
	}

	public static void DeleteDeprecated(string pathtoclean, List<string> paths)
	{
		if (!Directory.Exists(pathtoclean))
		{
			return;
		}
		foreach (string path in paths)
		{
			try
			{
				File.Delete(path);
			}
			catch (Exception ex)
			{
				Logs.UpdateLog = Logs.UpdateLog + "Failed to delete file " + path + ": " + ex.Message + Environment.NewLine;
			}
		}
		CleanEmptyFolders(pathtoclean + "\\Help\\");
	}
}
