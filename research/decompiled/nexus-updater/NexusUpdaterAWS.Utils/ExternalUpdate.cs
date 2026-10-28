using System;
using System.Diagnostics;
using System.IO;
using NexusUpdaterAWS.Components;
using NexusUpdaterAWS.Runtime;

namespace NexusUpdaterAWS.Utils;

internal class ExternalUpdate
{
	public static void DoExternalUpdate(ComponentTypeEnum type, bool restart)
	{
		SvcRuntime.EventLog.WriteEntry("External install called: " + type.ToString() + " Restart=" + restart);
		string path = string.Empty;
		string tempfilename = string.Empty;
		if (type == ComponentTypeEnum.NSP)
		{
			SoftwareApplication.GetLatestLocalNSPInstallerVersion(out path, out var _);
			tempfilename = "latestNSPinstaller.msi";
		}
		if (type != ComponentTypeEnum.DLV)
		{
			return;
		}
		SoftwareApplication.GetLatestLocalDLVInstallerVersion(out path, out var _);
		tempfilename = "latestDLVinstaller.msi";
		if (path == string.Empty || tempfilename == string.Empty)
		{
			return;
		}
		try
		{
			File.Copy(path, Directories.MyTemp + tempfilename, overwrite: true);
		}
		catch (Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry("(EU) Copy error: " + ex.Message, (EventLogEntryType)1);
			return;
		}
		try
		{
			File.Delete(path);
		}
		catch (Exception ex2)
		{
			SvcRuntime.EventLog.WriteEntry("(EU) Delete error: " + ex2.Message, (EventLogEntryType)1);
			return;
		}
		string argumentphrase = string.Empty;
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "msiexec";
			process.StartInfo.WorkingDirectory = Directories.MyTemp;
			argumentphrase = "/i \"" + Directories.MyTemp + tempfilename + "\" /qn ALLUSERS=\"2\"";
			if (restart)
			{
				argumentphrase += " RUNAPP=\"1\"";
			}
			process.StartInfo.Arguments = argumentphrase;
			process.StartInfo.Verb = "runas";
			SvcRuntime.EventLog.WriteEntry("External install command: " + process.StartInfo.WorkingDirectory + "\\" + process.StartInfo.FileName + " " + argumentphrase);
			process.Start();
			process.WaitForExit(60000);
		}
		catch (Exception ex3)
		{
			SvcRuntime.EventLog.WriteEntry("EU error: (" + argumentphrase + ")" + ex3.Message, (EventLogEntryType)1);
		}
	}
}
