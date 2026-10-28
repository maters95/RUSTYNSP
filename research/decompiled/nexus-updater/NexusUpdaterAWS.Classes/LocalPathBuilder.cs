using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using NexusUpdaterAWS.Runtime;
using NexusUpdaterAWS.Utils;

namespace NexusUpdaterAWS.Classes;

public static class LocalPathBuilder
{
	private const string SPLITPHRASE = "h-nexus-release";

	public static string BuildLocalPath(string path)
	{
		string destsub = TrimPath(path);
		string localBaseDest = GetLocalBaseDest(path);
		if (destsub.Contains("h-programfiles-x86"))
		{
			destsub = destsub.Replace("h-programfiles-x86", "");
		}
		else if (destsub.Contains("h-mydocuments"))
		{
			destsub = destsub.Replace("h-mydocuments", "");
		}
		destsub = destsub.Remove(0, 1);
		return localBaseDest + destsub;
	}

	private static string GetLocalBaseDest(string subpath)
	{
		if (subpath.Contains("h-programfiles-x86"))
		{
			return Directories.InstallLocation + "\\";
		}
		subpath.Contains("h-mydocuments");
		return string.Empty;
	}

	private static string TrimPath(string path)
	{
		string[] splits = Regex.Split(path, "h-nexus-release");
		if (splits.Length < 2)
		{
			return string.Empty;
		}
		return splits[1].Remove(0, 1).Replace("/", "\\");
	}

	public static NXReleaseInfo ReadReleaseInfoXML()
	{
		string FILENAME = Directories.MyProgramDataFolder + "h-nxreleaseinfo.xml";
		if (!File.Exists(FILENAME))
		{
			return null;
		}
		StreamReader file = new StreamReader(FILENAME);
		try
		{
			NXReleaseInfo ri = (NXReleaseInfo)new XmlSerializer(typeof(NXReleaseInfo)).Deserialize(file);
			file.Close();
			if (ri != null)
			{
				return ri;
			}
		}
		catch (Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry("Release info deserialization failed: " + ex.Message, (EventLogEntryType)1);
			file.Close();
			return null;
		}
		return null;
	}
}
