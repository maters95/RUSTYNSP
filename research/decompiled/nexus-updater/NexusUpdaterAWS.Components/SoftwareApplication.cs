using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Win32;
using NexusUpdaterAWS.Runtime;
using NexusUpdaterAWS.Utils;
using NexusUpdaterAWS.Web;

namespace NexusUpdaterAWS.Components;

internal class SoftwareApplication
{
	public static async Task<(bool NewSoftwareAvailable, string Error)> CheckSoftwareUpdate()
	{
		string error = string.Empty;
		var (NewUpdaterAvailable, UpdaterError) = await CheckUpdaterUpdate();
		if (!string.IsNullOrEmpty(UpdaterError))
		{
			error = error + UpdaterError + Environment.NewLine;
		}
		SvcRuntime.UpdateCheckProgressPercent = 10f;
		var (NewNSPAvailable, NSPError) = await CheckNSPUpdate();
		if (!string.IsNullOrEmpty(NSPError))
		{
			error = error + NSPError + Environment.NewLine;
		}
		SvcRuntime.UpdateCheckProgressPercent = 20f;
		var (NewDLVAvailable, DLVError) = await CheckDLVUpdate();
		if (!string.IsNullOrEmpty(DLVError))
		{
			error = error + DLVError + Environment.NewLine;
		}
		SvcRuntime.UpdateCheckProgressPercent = 30f;
		return (NewSoftwareAvailable: NewUpdaterAvailable | NewNSPAvailable | NewDLVAvailable, Error: error);
	}

	private static async Task<(bool NewNSPAvailable, string Error)> CheckNSPUpdate()
	{
		Version localversion = null;
		Version latestremoteversion = null;
		string localversionstring = GetNSPVersionRegistry();
		if (localversionstring != string.Empty)
		{
			Version.TryParse(localversionstring, out localversion);
			var (latestkey, error) = await AWSOps.GetNewestNSPInstallerKey();
			if (!string.IsNullOrEmpty(error))
			{
				return (NewNSPAvailable: false, Error: error);
			}
			if (latestkey != null)
			{
				latestremoteversion = GetVersionFromKey(latestkey.Key);
			}
			Version localinstallerversion = GetLatestLocalNSPInstallerVersion(out var path, out error);
			if (localinstallerversion == null)
			{
				if (latestremoteversion == null && localversion == null)
				{
					return (NewNSPAvailable: false, Error: string.Empty);
				}
				if (latestremoteversion != null && localversion == null)
				{
					LocalS3Object l = new LocalS3Object(latestkey.Key, ComponentTypeEnum.NSP, latestkey.LastModified, latestkey.Size, string.Empty);
					SvcRuntime.KeysToGet.Add(l);
					return (NewNSPAvailable: true, Error: string.Empty);
				}
				if (latestremoteversion != null && localversion != null && latestremoteversion > localversion)
				{
					LocalS3Object l2 = new LocalS3Object(latestkey.Key, ComponentTypeEnum.NSP, latestkey.LastModified, latestkey.Size, string.Empty);
					SvcRuntime.KeysToGet.Add(l2);
					return (NewNSPAvailable: true, Error: string.Empty);
				}
			}
			else
			{
				if (latestremoteversion == localinstallerversion && localinstallerversion == localversion && File.Exists(path))
				{
					PurgeNSPInstallers();
				}
				if (latestremoteversion > localinstallerversion)
				{
					LocalS3Object l3 = new LocalS3Object(latestkey.Key, ComponentTypeEnum.NSP, latestkey.LastModified, latestkey.Size, string.Empty);
					PurgeNSPInstallers();
					SvcRuntime.KeysToGet.Add(l3);
					return (NewNSPAvailable: true, Error: string.Empty);
				}
			}
			return (NewNSPAvailable: false, Error: string.Empty);
		}
		return (NewNSPAvailable: false, Error: string.Empty);
	}

	private static string GetNSPVersionRegistry()
	{
		try
		{
			string value = string.Empty;
			using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default))
			{
				using RegistryKey key = hklm.OpenSubKey("SOFTWARE\\Haltech\\Haltech NSP");
				if (key != null)
				{
					value = (string)key.GetValue("Version");
				}
			}
			if (!string.IsNullOrEmpty(value))
			{
				return value;
			}
		}
		catch (Exception)
		{
			SvcRuntime.EventLog.WriteEntry("Version registry entry not found.", (EventLogEntryType)1);
			return string.Empty;
		}
		return string.Empty;
	}

	public static Version GetLatestLocalNSPInstallerVersion(out string path, out string error)
	{
		error = string.Empty;
		Version latestversion = null;
		string latestinstallerpath = string.Empty;
		try
		{
			string[] files = Directory.GetFiles(Directories.MyInstallerRepo, "NSPSetup_v*.msi", SearchOption.AllDirectories);
			if (files.Length != 0)
			{
				latestversion = new Version(0, 0, 0, 0);
			}
			string[] array = files;
			foreach (string s in array)
			{
				string[] ver = Path.GetFileNameWithoutExtension(s).Split(new char[1] { '_' });
				if (ver.Length >= 2 && Version.TryParse(ver[1].Remove(0, 1), out Version currentversion) && currentversion > latestversion)
				{
					latestversion = currentversion;
					latestinstallerpath = s;
				}
			}
		}
		catch (Exception ex)
		{
			error = ex.Message;
			latestversion = null;
			latestinstallerpath = string.Empty;
		}
		path = latestinstallerpath;
		return latestversion;
	}

	private static void PurgeNSPInstallers()
	{
		try
		{
			FileInfo[] files = new DirectoryInfo(Directories.MyInstallerRepo).GetFiles("NSPSetup_v*.msi");
			foreach (FileInfo s in files)
			{
				try
				{
					File.Delete(s.FullName);
				}
				catch (Exception ex)
				{
					SvcRuntime.EventLog.WriteEntry("Purge NSP installer error: " + ex.Message, (EventLogEntryType)1);
				}
			}
		}
		catch (Exception ex2)
		{
			SvcRuntime.EventLog.WriteEntry("Purge NSP installer error: " + ex2.Message, (EventLogEntryType)1);
		}
	}

	private static async Task<(bool NewUpdaterAvailable, string Error)> CheckUpdaterUpdate()
	{
		Version.TryParse(Assembly.GetExecutingAssembly().GetName().Version.ToString(), out Version myversion);
		var (latestkey, error) = await AWSOps.GetNewestUpdaterInstallerKey();
		if (!string.IsNullOrEmpty(error))
		{
			return (NewUpdaterAvailable: false, Error: error);
		}
		Version latestremoteversion = null;
		if (latestkey != null)
		{
			latestremoteversion = GetVersionFromKey(latestkey.Key);
		}
		if (latestremoteversion == null && myversion == null)
		{
			return (NewUpdaterAvailable: false, Error: string.Empty);
		}
		if (latestremoteversion != null && myversion == null)
		{
			LocalS3Object l = new LocalS3Object(latestkey.Key, ComponentTypeEnum.Updater, latestkey.LastModified, latestkey.Size, string.Empty);
			SvcRuntime.KeysToGet.Add(l);
			PurgeUpdaterInstallers();
			return (NewUpdaterAvailable: true, Error: string.Empty);
		}
		if (latestremoteversion != null && myversion != null && latestremoteversion > myversion)
		{
			LocalS3Object l2 = new LocalS3Object(latestkey.Key, ComponentTypeEnum.Updater, latestkey.LastModified, latestkey.Size, string.Empty);
			SvcRuntime.KeysToGet.Add(l2);
			PurgeUpdaterInstallers();
			return (NewUpdaterAvailable: true, Error: string.Empty);
		}
		return (NewUpdaterAvailable: false, Error: string.Empty);
	}

	public static string GetUpdaterVersionRegistry()
	{
		try
		{
			string value = string.Empty;
			using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default))
			{
				using RegistryKey key = hklm.OpenSubKey("SOFTWARE\\Haltech\\Nexus Updater");
				if (key != null)
				{
					value = (string)key.GetValue("Version");
				}
			}
			if (!string.IsNullOrEmpty(value))
			{
				return value;
			}
		}
		catch (Exception)
		{
			SvcRuntime.EventLog.WriteEntry("Version registry entry not found.", (EventLogEntryType)1);
			return string.Empty;
		}
		return string.Empty;
	}

	public static Version GetLatestLocalUpdaterInstallerVersion(out string path, out string error)
	{
		error = string.Empty;
		Version latestversion = null;
		string latestinstallerpath = string.Empty;
		try
		{
			string[] files = Directory.GetFiles(Directories.MyInstallerRepo, "NexusUpdaterSetup_v*.msi", SearchOption.AllDirectories);
			if (files.Length != 0)
			{
				latestversion = new Version(0, 0, 0, 0);
			}
			string[] array = files;
			foreach (string s in array)
			{
				string[] ver = Path.GetFileNameWithoutExtension(s).Split(new char[1] { '_' });
				if (ver.Length >= 2 && Version.TryParse(ver[1].Remove(0, 1), out Version currentversion) && currentversion > latestversion)
				{
					latestversion = currentversion;
					latestinstallerpath = s;
				}
			}
		}
		catch (Exception ex)
		{
			error = ex.Message;
			latestversion = null;
			latestinstallerpath = string.Empty;
		}
		path = latestinstallerpath;
		return latestversion;
	}

	private static void PurgeUpdaterInstallers()
	{
		try
		{
			FileInfo[] files = new DirectoryInfo(Directories.MyInstallerRepo).GetFiles("NexusUpdaterSetup_v*.msi");
			foreach (FileInfo s in files)
			{
				try
				{
					File.Delete(s.FullName);
				}
				catch (Exception ex)
				{
					SvcRuntime.EventLog.WriteEntry("Purge updater installer error: " + ex.Message, (EventLogEntryType)1);
				}
			}
		}
		catch (Exception ex2)
		{
			SvcRuntime.EventLog.WriteEntry("Purge updater installer error: " + ex2.Message, (EventLogEntryType)1);
		}
	}

	private static async Task<(bool NewDLVAvailable, string Error)> CheckDLVUpdate()
	{
		Version localversion = null;
		Version latestremoteversion = null;
		string localversionstring = GetDLVVersionRegistry();
		if (localversionstring != string.Empty)
		{
			Version.TryParse(localversionstring, out localversion);
			var (latestkey, error) = await AWSOps.GetNewestDLVInstallerKey();
			if (!string.IsNullOrEmpty(error))
			{
				return (NewDLVAvailable: false, Error: error);
			}
			if (latestkey != null)
			{
				latestremoteversion = GetVersionFromKey(latestkey.Key);
			}
			Version localinstallerversion = GetLatestLocalDLVInstallerVersion(out var path, out error);
			if (localinstallerversion == null)
			{
				if (latestremoteversion == null && localversion == null)
				{
					return (NewDLVAvailable: false, Error: string.Empty);
				}
				if (latestremoteversion != null && localversion == null)
				{
					LocalS3Object l = new LocalS3Object(latestkey.Key, ComponentTypeEnum.DLV, latestkey.LastModified, latestkey.Size, string.Empty);
					SvcRuntime.KeysToGet.Add(l);
					return (NewDLVAvailable: true, Error: string.Empty);
				}
				if (latestremoteversion != null && localversion != null && latestremoteversion > localversion)
				{
					LocalS3Object l2 = new LocalS3Object(latestkey.Key, ComponentTypeEnum.DLV, latestkey.LastModified, latestkey.Size, string.Empty);
					SvcRuntime.KeysToGet.Add(l2);
					return (NewDLVAvailable: true, Error: string.Empty);
				}
			}
			else
			{
				if (latestremoteversion == localinstallerversion && localinstallerversion == localversion && File.Exists(path))
				{
					PurgeDLVInstallers();
				}
				if (latestremoteversion > localinstallerversion)
				{
					LocalS3Object l3 = new LocalS3Object(latestkey.Key, ComponentTypeEnum.DLV, latestkey.LastModified, latestkey.Size, string.Empty);
					PurgeDLVInstallers();
					SvcRuntime.KeysToGet.Add(l3);
					return (NewDLVAvailable: true, Error: string.Empty);
				}
			}
			return (NewDLVAvailable: false, Error: string.Empty);
		}
		return (NewDLVAvailable: false, Error: string.Empty);
	}

	private static string GetDLVVersionRegistry()
	{
		try
		{
			string value = string.Empty;
			using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default))
			{
				using RegistryKey key = hklm.OpenSubKey("SOFTWARE\\Haltech\\Data Log Viewer");
				if (key != null)
				{
					value = (string)key.GetValue("Version");
				}
			}
			if (!string.IsNullOrEmpty(value))
			{
				return value;
			}
		}
		catch (Exception)
		{
			SvcRuntime.EventLog.WriteEntry("Version registry entry not found.", (EventLogEntryType)1);
			return string.Empty;
		}
		return string.Empty;
	}

	public static Version GetLatestLocalDLVInstallerVersion(out string path, out string error)
	{
		error = string.Empty;
		Version latestversion = null;
		string latestinstallerpath = string.Empty;
		try
		{
			string[] files = Directory.GetFiles(Directories.MyInstallerRepo, "DLVSetup_v*.msi", SearchOption.AllDirectories);
			if (files.Length != 0)
			{
				latestversion = new Version(0, 0, 0, 0);
			}
			string[] array = files;
			foreach (string s in array)
			{
				string[] ver = Path.GetFileNameWithoutExtension(s).Split(new char[1] { '_' });
				if (ver.Length >= 2 && Version.TryParse(ver[1].Remove(0, 1), out Version currentversion) && currentversion > latestversion)
				{
					latestversion = currentversion;
					latestinstallerpath = s;
				}
			}
		}
		catch (Exception ex)
		{
			error = ex.Message;
			latestversion = null;
			latestinstallerpath = string.Empty;
		}
		path = latestinstallerpath;
		return latestversion;
	}

	private static void PurgeDLVInstallers()
	{
		try
		{
			FileInfo[] files = new DirectoryInfo(Directories.MyInstallerRepo).GetFiles("DLVSetup_v*.msi");
			foreach (FileInfo s in files)
			{
				try
				{
					File.Delete(s.FullName);
				}
				catch (Exception ex)
				{
					SvcRuntime.EventLog.WriteEntry("Purge DLV installer error: " + ex.Message, (EventLogEntryType)1);
				}
			}
		}
		catch (Exception ex2)
		{
			SvcRuntime.EventLog.WriteEntry("Purge DLV installer error: " + ex2.Message, (EventLogEntryType)1);
		}
	}

	private static Version GetVersionFromKey(string key)
	{
		string[] ver = Path.GetFileNameWithoutExtension(key).Split(new char[1] { '_' });
		if (ver.Length < 2)
		{
			return null;
		}
		Version.TryParse(ver[1].Remove(0, 1), out Version currentversion);
		if (currentversion == null)
		{
			return null;
		}
		return currentversion;
	}

	public static List<string> LoadPurgeExceptions()
	{
		List<string> fileList = new List<string>();
		string path = Directories.MyExclusionsPath;
		if (File.Exists(path))
		{
			using StreamReader reader = File.OpenText(path);
			string s;
			while ((s = reader.ReadLine()) != null)
			{
				if (s.Length > 0)
				{
					fileList.Add(s);
				}
			}
		}
		return fileList;
	}

	public static void SavePurgeException(string taggedFilesDownloadedPath, string releaseString)
	{
		if (taggedFilesDownloadedPath != null && !string.IsNullOrEmpty(taggedFilesDownloadedPath) && !(releaseString == "0"))
		{
			string path = Directories.MyExclusionsPath;
			List<string> list = LoadPurgeExceptions();
			if (!Directory.Exists(Path.GetDirectoryName(path)))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(path));
			}
			File.Create(path).Close();
			if (!list.Contains(taggedFilesDownloadedPath))
			{
				File.AppendAllText(path, taggedFilesDownloadedPath);
			}
		}
	}
}
