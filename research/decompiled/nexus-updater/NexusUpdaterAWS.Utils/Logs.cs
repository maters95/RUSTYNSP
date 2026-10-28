using System;
using System.Diagnostics;
using System.IO;

namespace NexusUpdaterAWS.Utils;

public class Logs
{
	public static string OpsLog = string.Empty;

	public static string UpdateLog = string.Empty;

	public static void GetAllEntries(string path)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		EventLog myLog = new EventLog();
		myLog.Log = "NexusAWSUpdaterLog";
		try
		{
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			using StreamWriter writer = new StreamWriter(path);
			writer.WriteLine("Nexus Updater Event Logs (ALL)" + Environment.NewLine);
			foreach (EventLogEntry entry in myLog.Entries)
			{
				EventLogEntry e = entry;
				string phrase = e.TimeGenerated.ToString();
				phrase += ": ";
				phrase = phrase + e.Message + Environment.NewLine;
				writer.WriteLine(phrase);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string GetErrorEntries()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		EventLog myLog = new EventLog();
		myLog.Log = "NexusAWSUpdaterLog";
		string errorlog = "Nexus Updater Event Logs (Errors):" + Environment.NewLine;
		try
		{
			foreach (EventLogEntry entry in myLog.Entries)
			{
				EventLogEntry e = entry;
				if ((int)e.EntryType == 1)
				{
					string phrase = e.TimeGenerated.ToString();
					phrase += ": ";
					phrase = phrase + e.Message + Environment.NewLine;
					errorlog += phrase;
				}
			}
			return errorlog;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}
}
