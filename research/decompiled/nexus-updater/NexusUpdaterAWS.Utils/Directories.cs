using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using NexusUpdaterAWS.Runtime;

namespace NexusUpdaterAWS.Utils;

internal class Directories
{
	public const string RELEASEINFO = "h-nxreleaseinfo.xml";

	public const string MYDIRNAME = "Nexus Updater";

	public const string COMPANYNAME = "Haltech";

	public const string OFFLINEHELP = "OfflineHelp.zip";

	public const string ERRORLOG = "errors.txt";

	public const string ALLLOG = "logs.txt";

	public const string EXCLUSIONSFILENAME = "UpdaterExceptions.txt";

	private const string userRoot = "HKEY_CURRENT_USER\\Software\\";

	private const string subkey = "Haltech\\Nexus Software";

	public const string keyName = "HKEY_CURRENT_USER\\Software\\Haltech\\Nexus Software\\";

	public static string MyProgramDataFolder = ProgramDataFolder + "\\Haltech\\Nexus Updater\\";

	public static string CompanyProgramDataFolder = ProgramDataFolder + "\\Haltech\\";

	public static string MyPath = Assembly.GetExecutingAssembly().Location;

	public static string MyDir = Path.GetDirectoryName(MyPath);

	public static string MyName = "NexusUpdaterAWS";

	public static string MyTaskName = "HaltechNexusUpdaterAWS";

	public static string MyHelpRepo = MyProgramDataFolder + "repo\\help\\";

	public static string MyInstallerRepo = MyProgramDataFolder + "repo\\installers\\";

	public static string MyTemp = MyProgramDataFolder + ".temp\\";

	public static string MyExclusionsPath = MyProgramDataFolder + "UpdaterExceptions.txt";

	public static string InstallLocation { get; set; } = ProgramFilesFolderX86 + "\\Haltech";

	private static string ProgramFilesFolderX86 => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);

	private static string ProgramDataFolder => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

	public static bool CheckDirs()
	{
		try
		{
			if (!Directory.Exists(MyProgramDataFolder + "dl\\"))
			{
				Directory.CreateDirectory(MyProgramDataFolder + "dl\\").Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			}
			else
			{
				string[] files = Directory.GetFiles(MyProgramDataFolder + "dl\\");
				for (int i = 0; i < files.Length; i++)
				{
					File.Delete(files[i]);
				}
			}
		}
		catch (Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry("Failed to create directory: " + MyProgramDataFolder + ", " + ex.Message, (EventLogEntryType)1);
			return false;
		}
		try
		{
			if (!Directory.Exists(MyProgramDataFolder + "repo\\"))
			{
				Directory.CreateDirectory(MyProgramDataFolder + "repo\\").Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			}
		}
		catch (Exception)
		{
			SvcRuntime.EventLog.WriteEntry("Failed to create directory: " + MyProgramDataFolder + "repo\\", (EventLogEntryType)1);
			return false;
		}
		try
		{
			if (!Directory.Exists(MyHelpRepo))
			{
				Directory.CreateDirectory(MyHelpRepo).Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			}
		}
		catch (Exception)
		{
			SvcRuntime.EventLog.WriteEntry("Failed to create directory: " + MyHelpRepo, (EventLogEntryType)1);
			return false;
		}
		try
		{
			if (!Directory.Exists(MyInstallerRepo))
			{
				Directory.CreateDirectory(MyInstallerRepo).Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			}
		}
		catch (Exception)
		{
			SvcRuntime.EventLog.WriteEntry("Failed to create directory: " + MyInstallerRepo, (EventLogEntryType)1);
			return false;
		}
		try
		{
			if (!Directory.Exists(MyTemp))
			{
				Directory.CreateDirectory(MyTemp).Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			}
		}
		catch (Exception)
		{
			SvcRuntime.EventLog.WriteEntry("Failed to create/purge directory: " + MyTemp, (EventLogEntryType)1);
			return false;
		}
		return true;
	}
}
