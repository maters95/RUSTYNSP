using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Timers;
using NexusUpdaterAWS.Components;
using NexusUpdaterAWS.Runtime;
using NexusUpdaterAWS.Utils;
using NexusUpdaterAWS.Web;

namespace NexusUpdaterAWS;

public class NexusAWSSvc : ServiceBase
{
	public enum ServiceState
	{
		SERVICE_STOPPED = 1,
		SERVICE_START_PENDING,
		SERVICE_STOP_PENDING,
		SERVICE_RUNNING,
		SERVICE_CONTINUE_PENDING,
		SERVICE_PAUSE_PENDING,
		SERVICE_PAUSED
	}

	public struct ServiceStatus
	{
		public int dwServiceType;

		public ServiceState dwCurrentState;

		public int dwControlsAccepted;

		public int dwWin32ExitCode;

		public int dwServiceSpecificExitCode;

		public int dwCheckPoint;

		public int dwWaitHint;
	}

	public const int MAXTRIES = 20;

	private int tries;

	public const int EXECAUTOUPDATE = 128;

	private Timer Timer;

	public ServiceHost serviceHost;

	private IContainer components;

	private EventLog eventLog1;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetServiceStatus(IntPtr handle, ref ServiceStatus serviceStatus);

	public NexusAWSSvc()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		InitializeComponent();
		eventLog1 = new EventLog();
		if (!EventLog.SourceExists("NexusAWSSvcSrc"))
		{
			EventLog.CreateEventSource("NexusAWSSvcSrc", "NexusAWSUpdaterLog");
		}
		eventLog1.Source = "NexusAWSSvcSrc";
		eventLog1.Log = "NexusAWSUpdaterLog";
		SvcRuntime.MySvc = this;
		SvcRuntime.EventLog = eventLog1;
	}

	protected override void OnStart(string[] args)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		if (serviceHost != null)
		{
			((CommunicationObject)serviceHost).Close();
		}
		NetNamedPipeBinding binding = new NetNamedPipeBinding();
		((Binding)binding).ReceiveTimeout = new TimeSpan(0, 60, 0);
		((Binding)binding).SendTimeout = new TimeSpan(0, 60, 0);
		((Binding)binding).OpenTimeout = new TimeSpan(0, 10, 0);
		((Binding)binding).CloseTimeout = new TimeSpan(0, 10, 0);
		new NetNamedPipeBinding();
		Uri baseAddress = new Uri("net.pipe://localhost/NexusUpdaterAWS");
		serviceHost = new ServiceHost(typeof(NexusAWSSvcWCF), new Uri[1] { baseAddress });
		ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
		smb.HttpGetEnabled = false;
		smb.MetadataExporter.PolicyVersion = PolicyVersion.Default;
		((Collection<IServiceBehavior>)(object)((ServiceHostBase)serviceHost).Description.Behaviors).Add((IServiceBehavior)(object)smb);
		serviceHost.AddServiceEndpoint(typeof(INexusAWSSvcCmd), (Binding)(object)binding, "Service");
		serviceHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexNamedPipeBinding(), "mex");
		((CommunicationObject)serviceHost).Open();
		eventLog1.WriteEntry("Servicehost " + baseAddress?.ToString() + " started.");
		ServiceStatus serviceStatus = new ServiceStatus
		{
			dwCurrentState = ServiceState.SERVICE_START_PENDING,
			dwWaitHint = 100000
		};
		SetServiceStatus(((ServiceBase)this).ServiceHandle, ref serviceStatus);
		if (!Directories.CheckDirs())
		{
			((ServiceBase)this).Stop();
		}
		serviceStatus.dwCurrentState = ServiceState.SERVICE_RUNNING;
		SetServiceStatus(((ServiceBase)this).ServiceHandle, ref serviceStatus);
		eventLog1.WriteEntry("Service started.");
	}

	protected override void OnStop()
	{
		ServiceStatus serviceStatus = new ServiceStatus
		{
			dwCurrentState = ServiceState.SERVICE_STOP_PENDING,
			dwWaitHint = 100000
		};
		SetServiceStatus(((ServiceBase)this).ServiceHandle, ref serviceStatus);
		serviceStatus.dwCurrentState = ServiceState.SERVICE_STOPPED;
		SetServiceStatus(((ServiceBase)this).ServiceHandle, ref serviceStatus);
		string stopphrase = ((!SvcRuntime.HasSelfUpdate) ? "Manual/Error." : "Self update exists.");
		SvcRuntime.EventLog.WriteEntry("Service stopped: " + stopphrase);
		if (serviceHost != null)
		{
			((CommunicationObject)serviceHost).Close();
		}
	}

	protected override async void OnCustomCommand(int command)
	{
		if (command == 128)
		{
			if (SvcRuntime.CurrentUpdaterStatus == UpdaterStatus.Idle)
			{
				await Do_UpdateProc();
			}
			else
			{
				SvcRuntime.EventLog.WriteEntry("(Installer/Scheduler Call) Updater is busy.", (EventLogEntryType)1);
			}
		}
	}

	private bool IsInternetConnected()
	{
		try
		{
			using WebClient client = new WebClient();
			using (client.OpenRead("http://google.com/generate_204"))
			{
				return true;
			}
		}
		catch
		{
			Logs.OpsLog = Logs.OpsLog + "Update check result: No internet connection." + Environment.NewLine;
			SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
			SvcRuntime.UpdateCheckProgressPercent = null;
			return false;
		}
	}

	public async Task<UpdateOutcomes> Do_UpdateProc()
	{
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Checking;
		tries = 0;
		Logs.OpsLog = string.Empty;
		Logs.UpdateLog = string.Empty;
		if (!Directories.CheckDirs())
		{
			SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
			WriteLogs();
			return UpdateOutcomes.InitError;
		}
		Logs.OpsLog = Logs.OpsLog + "Update initiated." + Environment.NewLine;
		SvcRuntime.EventLog.WriteEntry("Update initiated.");
		bool flag = await Do_CheckUpdate(ComponentTypeEnum.Any);
		SyncOps.DeleteDeprecated(Directories.CompanyProgramDataFolder + "Nexus\\", SvcRuntime.PathsForDeletion);
		if (!flag)
		{
			Logs.OpsLog = Logs.OpsLog + "Update process complete: " + UpdateOutcomes.NoUpdate.ToString() + Environment.NewLine;
			SvcRuntime.EventLog.WriteEntry(Logs.OpsLog);
			SvcRuntime.EventLog.WriteEntry(Logs.UpdateLog);
			SvcRuntime.ClearRuntimeLists();
			SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
			WriteLogs();
			if (SvcRuntime.Aborted)
			{
				SvcRuntime.Aborted = false;
				return UpdateOutcomes.Aborted;
			}
			return UpdateOutcomes.NoUpdate;
		}
		SvcRuntime.EventLog.WriteEntry("Updates found, attempting to download...");
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Downloading;
		bool DLInstallDone = false;
		try
		{
			DLInstallDone = await Do_DownloadAndSync();
		}
		catch (Exception ex)
		{
			Logs.OpsLog = Logs.OpsLog + ex.Message + Environment.NewLine;
		}
		if (!DLInstallDone)
		{
			Logs.OpsLog = Logs.OpsLog + "Update process complete: " + UpdateOutcomes.DownloadInstallFailed.ToString() + Environment.NewLine;
			SvcRuntime.EventLog.WriteEntry(Logs.OpsLog);
			SvcRuntime.EventLog.WriteEntry(Logs.UpdateLog);
			SvcRuntime.ClearRuntimeLists();
			SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
			WriteLogs();
			if (SvcRuntime.Aborted)
			{
				SvcRuntime.Aborted = false;
				return UpdateOutcomes.Aborted;
			}
			return UpdateOutcomes.DownloadInstallFailed;
		}
		SvcRuntime.EventLog.WriteEntry("Downloads complete!");
		Timer = new Timer();
		Timer.Interval = 10000.0;
		Timer.Elapsed += OnTimer;
		Timer.Start();
		Logs.OpsLog = Logs.OpsLog + "Update process complete: " + UpdateOutcomes.CompleteUpdate.ToString() + Environment.NewLine;
		SvcRuntime.ClearRuntimeLists();
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
		return UpdateOutcomes.CompleteUpdate;
	}

	public async Task<UpdateOutcomes> Do_UpdateProcInteractive()
	{
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Checking;
		tries = 0;
		Logs.OpsLog = string.Empty;
		Logs.UpdateLog = string.Empty;
		if (!Directories.CheckDirs())
		{
			SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
			WriteLogs();
			return UpdateOutcomes.InitError;
		}
		Logs.OpsLog = Logs.OpsLog + "Update initiated." + Environment.NewLine;
		SvcRuntime.EventLog.WriteEntry("(Interactive) Updates found, downloads started.");
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Downloading;
		SyncOps.DeleteDeprecated(Directories.CompanyProgramDataFolder + "Nexus\\", SvcRuntime.PathsForDeletion);
		bool DLInstallDone = false;
		try
		{
			DLInstallDone = await Do_DownloadAndSync();
		}
		catch (Exception ex)
		{
			Logs.OpsLog = Logs.OpsLog + ex.Message + Environment.NewLine;
		}
		if (!DLInstallDone)
		{
			Logs.OpsLog = Logs.OpsLog + "Update process complete: " + UpdateOutcomes.DownloadInstallFailed.ToString() + Environment.NewLine;
			SvcRuntime.EventLog.WriteEntry(Logs.OpsLog);
			SvcRuntime.EventLog.WriteEntry(Logs.UpdateLog);
			SvcRuntime.ClearRuntimeLists();
			SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
			WriteLogs();
			if (SvcRuntime.Aborted)
			{
				SvcRuntime.Aborted = false;
				return UpdateOutcomes.Aborted;
			}
			return UpdateOutcomes.DownloadInstallFailed;
		}
		SvcRuntime.EventLog.WriteEntry("(Interactive) Downloads complete!");
		Timer = new Timer();
		Timer.Interval = 10000.0;
		Timer.Elapsed += OnTimer;
		Timer.Start();
		Logs.OpsLog = Logs.OpsLog + "Update process complete: " + UpdateOutcomes.CompleteUpdate.ToString() + Environment.NewLine;
		SvcRuntime.ClearRuntimeLists();
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
		return UpdateOutcomes.CompleteUpdate;
	}

	public UpdateOutcomes Do_GetDefinitionObjects(out List<string> DownloadedFilePaths)
	{
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Checking;
		tries = 0;
		Logs.OpsLog = string.Empty;
		Logs.UpdateLog = string.Empty;
		if (!Directories.CheckDirs())
		{
			SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
			WriteLogs();
			DownloadedFilePaths = null;
			return UpdateOutcomes.InitError;
		}
		Logs.OpsLog = Logs.OpsLog + "Definition acquisition initiated." + Environment.NewLine;
		SvcRuntime.EventLog.WriteEntry("(UserMetaData) Updates found, downloads started.");
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Downloading;
		List<string> downloadedFiles = new List<string>();
		try
		{
			downloadedFiles = Do_DownloadDefinitions();
		}
		catch (Exception ex)
		{
			Logs.OpsLog = Logs.OpsLog + ex.Message + Environment.NewLine;
		}
		if (downloadedFiles.Count == 0 || downloadedFiles == null)
		{
			Logs.OpsLog = Logs.OpsLog + "File acquisition process failed/aborted: " + UpdateOutcomes.DownloadInstallFailed.ToString() + Environment.NewLine;
			SvcRuntime.EventLog.WriteEntry(Logs.OpsLog);
			SvcRuntime.EventLog.WriteEntry(Logs.UpdateLog);
			SvcRuntime.ClearRuntimeLists();
			SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
			WriteLogs();
			if (SvcRuntime.Aborted)
			{
				SvcRuntime.Aborted = false;
				DownloadedFilePaths = null;
				return UpdateOutcomes.Aborted;
			}
			DownloadedFilePaths = null;
			return UpdateOutcomes.DownloadInstallFailed;
		}
		SvcRuntime.EventLog.WriteEntry("(Tagged) Downloads complete!");
		Timer = new Timer();
		Timer.Interval = 10000.0;
		Timer.Elapsed += OnTimer;
		Timer.Start();
		Logs.OpsLog = Logs.OpsLog + "File acquisition process complete: " + UpdateOutcomes.CompleteUpdate.ToString() + Environment.NewLine;
		SvcRuntime.ClearRuntimeLists();
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
		DownloadedFilePaths = downloadedFiles;
		return UpdateOutcomes.CompleteUpdate;
	}

	public UpdateOutcomes Do_GetTaggedObjects(out List<string> DownloadedFilePaths)
	{
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Checking;
		tries = 0;
		Logs.OpsLog = string.Empty;
		Logs.UpdateLog = string.Empty;
		if (!Directories.CheckDirs())
		{
			SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
			WriteLogs();
			DownloadedFilePaths = null;
			return UpdateOutcomes.InitError;
		}
		Logs.OpsLog = Logs.OpsLog + "File acquisition initiated." + Environment.NewLine;
		SvcRuntime.EventLog.WriteEntry("(UserMetaData) Updates found, downloads started.");
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Downloading;
		List<string> downloadedFiles = new List<string>();
		try
		{
			downloadedFiles = Do_DownloadTagged();
		}
		catch (Exception ex)
		{
			Logs.OpsLog = Logs.OpsLog + ex.Message + Environment.NewLine;
		}
		if (downloadedFiles.Count == 0 || downloadedFiles == null)
		{
			Logs.OpsLog = Logs.OpsLog + "File acquisition process failed/aborted: " + UpdateOutcomes.DownloadInstallFailed.ToString() + Environment.NewLine;
			SvcRuntime.EventLog.WriteEntry(Logs.OpsLog);
			SvcRuntime.EventLog.WriteEntry(Logs.UpdateLog);
			SvcRuntime.ClearRuntimeLists();
			SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
			WriteLogs();
			if (SvcRuntime.Aborted)
			{
				SvcRuntime.Aborted = false;
				DownloadedFilePaths = null;
				return UpdateOutcomes.Aborted;
			}
			DownloadedFilePaths = null;
			return UpdateOutcomes.DownloadInstallFailed;
		}
		SvcRuntime.EventLog.WriteEntry("(Tagged) Downloads complete!");
		Timer = new Timer();
		Timer.Interval = 10000.0;
		Timer.Elapsed += OnTimer;
		Timer.Start();
		Logs.OpsLog = Logs.OpsLog + "File acquisition process complete: " + UpdateOutcomes.CompleteUpdate.ToString() + Environment.NewLine;
		SvcRuntime.ClearRuntimeLists();
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
		DownloadedFilePaths = downloadedFiles;
		return UpdateOutcomes.CompleteUpdate;
	}

	public async Task<bool> Do_CheckUpdate(ComponentTypeEnum type)
	{
		AWSOps.InitializeAWS();
		SvcRuntime.UpdateCheckProgressPercent = 0f;
		if (!IsInternetConnected())
		{
			return false;
		}
		SvcRuntime.ClearRuntimeLists();
		SvcRuntime.PendingCopyList.Clear();
		bool NewSoftwareAvailable = (await SoftwareApplication.CheckSoftwareUpdate()).Item1;
		bool NewSupportFilesAvailable = (await SupportFiles.CheckSupportFileUpdates()).Item1;
		string summary = string.Empty;
		foreach (LocalS3Object s in SvcRuntime.KeysToGet)
		{
			summary = summary + s.Key + Environment.NewLine;
		}
		if (summary != string.Empty)
		{
			Logs.UpdateLog = Logs.UpdateLog + summary + Environment.NewLine;
		}
		if (type == ComponentTypeEnum.Any)
		{
			SvcRuntime.UpdateCheckProgressPercent = null;
			return NewSoftwareAvailable | NewSupportFilesAvailable;
		}
		string fileschecked = "Manual update check: ";
		int ctr = 0;
		foreach (LocalS3Object item in SvcRuntime.KeysToGet)
		{
			if (item.ComponentType == type)
			{
				ctr++;
			}
		}
		Logs.OpsLog = Logs.OpsLog + fileschecked + type.ToString() + Environment.NewLine;
		SvcRuntime.UpdateCheckProgressPercent = null;
		return ctr > 0;
	}

	public async Task<int> Do_CheckUpdate1()
	{
		CheckForUpdatesResult result = await Do_CheckForUpdates();
		int returnint = 0;
		if (result.CheckSoftwareUpdatesSuccess && result.CheckSupportFilesUpdatesSuccess)
		{
			returnint = 1;
			if (result.NewSoftwareAvailable)
			{
				returnint |= 2;
			}
			if (result.NewSupportFilesAvailable)
			{
				returnint |= 4;
			}
		}
		return returnint;
	}

	public async Task<CheckForUpdatesResult> Do_CheckForUpdates()
	{
		CheckForUpdatesResult result = new CheckForUpdatesResult
		{
			CheckSoftwareUpdatesSuccess = false,
			CheckSupportFilesUpdatesSuccess = false,
			CheckSoftwareUpdatesErrorMessage = string.Empty,
			CheckSupportFilesUpdatesErrorMessage = string.Empty,
			NewSoftwareAvailable = false,
			NewSupportFilesAvailable = false
		};
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Checking;
		AWSOps.InitializeAWS();
		SvcRuntime.UpdateCheckProgressPercent = 0f;
		SvcRuntime.ClearRuntimeLists();
		SvcRuntime.PendingCopyList.Clear();
		try
		{
			var (NewSoftwareAvailable, Error) = await SoftwareApplication.CheckSoftwareUpdate();
			if (string.IsNullOrEmpty(Error))
			{
				result.CheckSoftwareUpdatesSuccess = true;
			}
			else
			{
				result.CheckSoftwareUpdatesErrorMessage = Error;
				if (!IsInternetConnected())
				{
					result.CheckSoftwareUpdatesErrorMessage = result.CheckSoftwareUpdatesErrorMessage + Environment.NewLine + "Please check your internet connection.";
				}
			}
			if (NewSoftwareAvailable)
			{
				result.NewSoftwareAvailable = true;
			}
		}
		catch (Exception ex)
		{
			Logs.OpsLog = Logs.OpsLog + "Manual update check: " + ex.Message + Environment.NewLine;
			result.CheckSoftwareUpdatesErrorMessage = ex.Message;
		}
		try
		{
			var (NewSupportFilesAvailable, Error2) = await SupportFiles.CheckSupportFileUpdates();
			if (string.IsNullOrEmpty(Error2))
			{
				result.CheckSupportFilesUpdatesSuccess = true;
			}
			else
			{
				result.CheckSupportFilesUpdatesErrorMessage = Error2;
				if (!IsInternetConnected())
				{
					result.CheckSupportFilesUpdatesErrorMessage = result.CheckSupportFilesUpdatesErrorMessage + Environment.NewLine + "Please check your internet connection.";
				}
			}
			if (NewSupportFilesAvailable)
			{
				result.NewSupportFilesAvailable = true;
			}
		}
		catch (Exception ex2)
		{
			Logs.OpsLog = Logs.OpsLog + "Manual update check: " + ex2.Message + Environment.NewLine;
			result.CheckSupportFilesUpdatesErrorMessage = ex2.Message;
		}
		Logs.OpsLog = Logs.OpsLog + "Manual update check - CheckSoftwareUpdatesSuccess: " + result.CheckSoftwareUpdatesSuccess + Environment.NewLine;
		Logs.OpsLog = Logs.OpsLog + "Manual update check - CheckSupportFilesUpdatesSuccess: " + result.CheckSupportFilesUpdatesSuccess + Environment.NewLine;
		Logs.OpsLog = Logs.OpsLog + "Manual update check - NewSoftwareAvailable: " + result.NewSoftwareAvailable + Environment.NewLine;
		Logs.OpsLog = Logs.OpsLog + "Manual update check - NewSupportFilesAvailable: " + result.NewSupportFilesAvailable + Environment.NewLine;
		Logs.OpsLog = Logs.OpsLog + "Manual update check - CheckSoftwareUpdatesErrorMessage: " + result.CheckSoftwareUpdatesErrorMessage + Environment.NewLine;
		Logs.OpsLog = Logs.OpsLog + "Manual update check - CheckSupportFilesUpdatesErrorMessage: " + result.CheckSupportFilesUpdatesErrorMessage + Environment.NewLine;
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
		SvcRuntime.UpdateCheckProgressPercent = null;
		return result;
	}

	public async Task<int?> Do_CheckTaggedObjects_AND(string repoFolderName, List<S3MetaDataKeyValuePair> requestList)
	{
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Checking;
		AWSOps.InitializeAWS();
		SvcRuntime.UpdateCheckProgressPercent = 0f;
		int? returnint = null;
		if (!IsInternetConnected())
		{
			return null;
		}
		SvcRuntime.ClearRuntimeLists();
		SvcRuntime.PendingCopyList.Clear();
		try
		{
			returnint = await SupportFiles.CheckTaggedSupportFilesAND(repoFolderName, requestList);
		}
		catch (Exception ex)
		{
			Logs.OpsLog = Logs.OpsLog + "Manual update check: " + ex.Message + Environment.NewLine;
		}
		Logs.OpsLog = Logs.OpsLog + "Manual update check result: " + returnint + Environment.NewLine;
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
		SvcRuntime.UpdateCheckProgressPercent = null;
		return returnint;
	}

	public async Task<int?> Do_CheckTaggedLatestObjectVersionAvailable(string repoFolderName, List<S3MetaDataKeyValuePair> requestList)
	{
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Checking;
		AWSOps.InitializeAWS();
		SvcRuntime.UpdateCheckProgressPercent = 0f;
		int? returnint = null;
		if (!IsInternetConnected())
		{
			return null;
		}
		SvcRuntime.ClearRuntimeLists();
		SvcRuntime.PendingCopyList.Clear();
		try
		{
			returnint = await SupportFiles.CheckTaggedSupportFileLatestVersionAvailable(repoFolderName, requestList);
		}
		catch (Exception ex)
		{
			Logs.OpsLog = Logs.OpsLog + "Manual update check: " + ex.Message + Environment.NewLine;
		}
		Logs.OpsLog = Logs.OpsLog + "Manual update check result: " + returnint + Environment.NewLine;
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
		SvcRuntime.UpdateCheckProgressPercent = null;
		return returnint;
	}

	public async Task<int?> Do_CheckDefinitions(List<S3MetaDataKeyValuePair> requestList)
	{
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Checking;
		AWSOps.InitializeAWS();
		SvcRuntime.UpdateCheckProgressPercent = 0f;
		int? returnint = null;
		if (!IsInternetConnected())
		{
			return null;
		}
		SvcRuntime.ClearRuntimeLists();
		SvcRuntime.PendingCopyList.Clear();
		try
		{
			returnint = await SupportFiles.CheckDefinitions(requestList);
		}
		catch (Exception ex)
		{
			Logs.OpsLog = Logs.OpsLog + "Manual update check: " + ex.Message + Environment.NewLine;
		}
		Logs.OpsLog = Logs.OpsLog + "Manual update check result: " + returnint + Environment.NewLine;
		SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
		SvcRuntime.UpdateCheckProgressPercent = null;
		return returnint;
	}

	private async Task<bool> Do_DownloadAndSync()
	{
		int dlfailct = 0;
		int copyfailct = 0;
		SvcRuntime.KeysToGet = SvcRuntime.KeysToGet.OrderBy((LocalS3Object x) => (int)x.ComponentType).ToList();
		List<float> speeds = new List<float>();
		int i;
		for (i = 0; i < SvcRuntime.KeysToGet.Count; i++)
		{
			if (SvcRuntime.PendingAbort)
			{
				SvcRuntime.PendingAbort = false;
				SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
				SvcRuntime.Aborted = true;
				return false;
			}
			Stopwatch stopwatch = Stopwatch.StartNew();
			string dlpath = await NxDownload.DownloadFileAWS(SvcRuntime.KeysToGet[i].Key);
			stopwatch.Stop();
			SvcRuntime.DLProgressPercent = (float)(i + 1) / (float)SvcRuntime.KeysToGet.Count * 100f;
			if (!string.IsNullOrEmpty(dlpath))
			{
				float speed = new FileInfo(dlpath).Length / stopwatch.ElapsedMilliseconds;
				speeds.Add(speed);
				SvcRuntime.SpeedKB = speed;
				switch (SvcRuntime.KeysToGet[i].ComponentType)
				{
				case ComponentTypeEnum.ReleaseNotes:
					SvcRuntime.CurrentComponentDownloaded = "Release Notes";
					break;
				case ComponentTypeEnum.EULA:
					SvcRuntime.CurrentComponentDownloaded = "EULA";
					break;
				case ComponentTypeEnum.NSP:
					SvcRuntime.CurrentComponentDownloaded = "NSP Update";
					break;
				case ComponentTypeEnum.Updater:
					SvcRuntime.CurrentComponentDownloaded = "Nexus Updater";
					break;
				case ComponentTypeEnum.DLV:
					SvcRuntime.CurrentComponentDownloaded = "DLV Update";
					break;
				case ComponentTypeEnum.SupportFile:
					SvcRuntime.CurrentComponentDownloaded = "Support Files";
					break;
				case ComponentTypeEnum.Help:
					SvcRuntime.CurrentComponentDownloaded = "Help Files";
					break;
				default:
					SvcRuntime.CurrentComponentDownloaded = "Misc. Files";
					break;
				}
				if (!NxDownload.CopyFile(dlpath, SvcRuntime.KeysToGet[i].LocalPath, SvcRuntime.KeysToGet[i].LastModified))
				{
					copyfailct++;
					if (!SvcRuntime.PendingCopyList.Any((LocalS3Object x) => Path.GetFileName(x.LocalPath) == Path.GetFileName(SvcRuntime.KeysToGet[i].LocalPath)))
					{
						SvcRuntime.PendingCopyList.Add(SvcRuntime.KeysToGet[i]);
					}
				}
				else
				{
					File.Delete(dlpath);
				}
			}
			else
			{
				SvcRuntime.SpeedKB = null;
				SvcRuntime.DLProgressPercent = null;
				dlfailct++;
			}
		}
		SvcRuntime.SpeedKB = null;
		SvcRuntime.DLProgressPercent = null;
		Logs.OpsLog = Logs.OpsLog + "Average DL speed: " + speeds.Average() + " kbps." + Environment.NewLine;
		return dlfailct != SvcRuntime.KeysToGet.Count && copyfailct != SvcRuntime.KeysToGet.Count;
	}

	private List<string> Do_DownloadDefinitions()
	{
		int dlfailct = 0;
		int copyfailct = 0;
		List<string> filesDownloadedPaths = new List<string>();
		List<float> speeds = new List<float>();
		int i;
		for (i = 0; i < SvcRuntime.KeysToGet.Count; i++)
		{
			if (SvcRuntime.PendingAbort)
			{
				SvcRuntime.PendingAbort = false;
				SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
				SvcRuntime.Aborted = true;
				return null;
			}
			Stopwatch stopwatch = Stopwatch.StartNew();
			string dlpath = NxDownload.DownloadFileAWSParallel(SvcRuntime.KeysToGet[i].Key);
			stopwatch.Stop();
			if (!string.IsNullOrEmpty(dlpath))
			{
				float speed = new FileInfo(dlpath).Length / stopwatch.ElapsedMilliseconds;
				SvcRuntime.SpeedKB = speed;
				if (SvcRuntime.KeysToGet[i].ComponentType == ComponentTypeEnum.OldDefinition)
				{
					SvcRuntime.CurrentComponentDownloaded = "OldDefinition";
				}
				if (!NxDownload.CopyFile(dlpath, SvcRuntime.KeysToGet[i].LocalPath, SvcRuntime.KeysToGet[i].LastModified))
				{
					copyfailct++;
					if (!SvcRuntime.PendingCopyList.Any((LocalS3Object x) => Path.GetFileName(x.LocalPath) == Path.GetFileName(SvcRuntime.KeysToGet[i].LocalPath)))
					{
						SvcRuntime.PendingCopyList.Add(SvcRuntime.KeysToGet[i]);
					}
				}
				else
				{
					filesDownloadedPaths.Add(SvcRuntime.KeysToGet[i].LocalPath);
					SoftwareApplication.SavePurgeException(SvcRuntime.KeysToGet[i].LocalPath, SvcRuntime.KeysToGet[i].ReleaseString);
					File.Delete(dlpath);
				}
			}
			else
			{
				SvcRuntime.SpeedKB = null;
				SvcRuntime.CurrentFileDownloaded = string.Empty;
				SvcRuntime.CurrentFileProgressPercent = null;
				dlfailct++;
			}
		}
		SvcRuntime.SpeedKB = null;
		SvcRuntime.CurrentFileDownloaded = string.Empty;
		SvcRuntime.CurrentFileProgressPercent = null;
		if (speeds.Count > 1)
		{
			Logs.OpsLog = Logs.OpsLog + "Average DL speed: " + speeds.Average() + " kbps." + Environment.NewLine;
		}
		return filesDownloadedPaths;
	}

	private List<string> Do_DownloadTagged()
	{
		int dlfailct = 0;
		int copyfailct = 0;
		List<string> filesDownloadedPaths = new List<string>();
		List<float> speeds = new List<float>();
		int i;
		for (i = 0; i < SvcRuntime.KeysToGet.Count; i++)
		{
			if (SvcRuntime.PendingAbort)
			{
				SvcRuntime.PendingAbort = false;
				SvcRuntime.CurrentUpdaterStatus = UpdaterStatus.Idle;
				SvcRuntime.Aborted = true;
				return null;
			}
			Stopwatch stopwatch = Stopwatch.StartNew();
			string dlpath = NxDownload.DownloadFileAWSParallel(SvcRuntime.KeysToGet[i].Key);
			stopwatch.Stop();
			if (!string.IsNullOrEmpty(dlpath))
			{
				float speed = new FileInfo(dlpath).Length / stopwatch.ElapsedMilliseconds;
				SvcRuntime.SpeedKB = speed;
				switch (SvcRuntime.KeysToGet[i].ComponentType)
				{
				case ComponentTypeEnum.ReleaseNotes:
					SvcRuntime.CurrentComponentDownloaded = "Release Notes";
					break;
				case ComponentTypeEnum.EULA:
					SvcRuntime.CurrentComponentDownloaded = "EULA";
					break;
				case ComponentTypeEnum.NSP:
					SvcRuntime.CurrentComponentDownloaded = "NSP Update";
					break;
				case ComponentTypeEnum.Updater:
					SvcRuntime.CurrentComponentDownloaded = "Nexus Updater";
					break;
				case ComponentTypeEnum.DLV:
					SvcRuntime.CurrentComponentDownloaded = "DLV Update";
					break;
				case ComponentTypeEnum.SupportFile:
					SvcRuntime.CurrentComponentDownloaded = "Support Files";
					break;
				case ComponentTypeEnum.Help:
					SvcRuntime.CurrentComponentDownloaded = "Help Files";
					break;
				default:
					SvcRuntime.CurrentComponentDownloaded = "Misc. Files";
					break;
				}
				if (!NxDownload.CopyFile(dlpath, SvcRuntime.KeysToGet[i].LocalPath, SvcRuntime.KeysToGet[i].LastModified))
				{
					copyfailct++;
					if (!SvcRuntime.PendingCopyList.Any((LocalS3Object x) => Path.GetFileName(x.LocalPath) == Path.GetFileName(SvcRuntime.KeysToGet[i].LocalPath)))
					{
						SvcRuntime.PendingCopyList.Add(SvcRuntime.KeysToGet[i]);
					}
				}
				else
				{
					filesDownloadedPaths.Add(SvcRuntime.KeysToGet[i].LocalPath);
					SoftwareApplication.SavePurgeException(SvcRuntime.KeysToGet[i].LocalPath, SvcRuntime.KeysToGet[i].ReleaseString);
					File.Delete(dlpath);
				}
			}
			else
			{
				SvcRuntime.SpeedKB = null;
				SvcRuntime.CurrentFileDownloaded = string.Empty;
				SvcRuntime.CurrentFileProgressPercent = null;
				dlfailct++;
			}
		}
		SvcRuntime.SpeedKB = null;
		SvcRuntime.CurrentFileDownloaded = string.Empty;
		SvcRuntime.CurrentFileProgressPercent = null;
		if (speeds.Count > 1)
		{
			Logs.OpsLog = Logs.OpsLog + "Average DL speed: " + speeds.Average() + " kbps." + Environment.NewLine;
		}
		return filesDownloadedPaths;
	}

	private void WriteLogs()
	{
		try
		{
			SvcRuntime.EventLog.WriteEntry(Logs.OpsLog);
		}
		catch (Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry("Failed to write ops log entry: " + ex.Message, (EventLogEntryType)1);
		}
		int num = Logs.UpdateLog.Length / 31839;
		if (num > 0)
		{
			for (int i = 0; i < num; i++)
			{
				string sub = Logs.UpdateLog.Substring(i * 31839, 31839);
				if (!string.IsNullOrEmpty(sub))
				{
					try
					{
						SvcRuntime.EventLog.WriteEntry(sub);
					}
					catch (Exception ex2)
					{
						SvcRuntime.EventLog.WriteEntry("Failed to write update log entry " + i + ": " + ex2.Message, (EventLogEntryType)1);
					}
				}
			}
		}
		else
		{
			SvcRuntime.EventLog.WriteEntry(Logs.UpdateLog);
		}
	}

	private void FinalizeUpdate()
	{
		Timer.Stop();
		Timer.Dispose();
		WriteLogs();
	}

	private void OnTimer(object sender, EventArgs e)
	{
		if (tries == 20)
		{
			FinalizeUpdate();
		}
		if (SvcRuntime.PendingCopyList.Count > 0)
		{
			if (NxDownload.HandlePendingList())
			{
				FinalizeUpdate();
			}
		}
		else
		{
			FinalizeUpdate();
		}
		tries++;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ServiceBase)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		eventLog1 = new EventLog();
		((ISupportInitialize)eventLog1).BeginInit();
		((ServiceBase)this).AutoLog = false;
		((ServiceBase)this).CanPauseAndContinue = true;
		((ServiceBase)this).ServiceName = "NexusAWSSvc";
		((ISupportInitialize)eventLog1).EndInit();
	}
}
