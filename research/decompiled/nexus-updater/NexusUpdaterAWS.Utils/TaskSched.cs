using System;
using System.Diagnostics;
using Microsoft.Win32.TaskScheduler;
using NexusUpdaterAWS.Runtime;

namespace NexusUpdaterAWS.Utils;

internal class TaskSched
{
	public const string TASKDESC = "Keeps Haltech Nexus Software and support files automatically updated. Pausing/deleting this task disables this feature.";

	public const int INTERVALDAYS = 1;

	public static void CreateTask()
	{
		TimeSpan UpdateStartUTC = new TimeSpan(13, 45, 0);
		TimeSpan UpdateEndUTC = new TimeSpan(15, 15, 0);
		DateTime localTimeUTC = DateTime.Now;
		localTimeUTC = TimeZoneInfo.ConvertTimeToUtc(localTimeUTC);
		DateTime TimeToUseLocal = ((!(localTimeUTC.TimeOfDay >= UpdateStartUTC) || !(localTimeUTC.TimeOfDay <= UpdateEndUTC)) ? DateTime.Now : TimeZoneInfo.ConvertTimeFromUtc(localTimeUTC.Date.Add(UpdateEndUTC), TimeZoneInfo.Local));
		try
		{
			using TaskService ts = new TaskService();
			ts.RootFolder.DeleteTask(Directories.MyTaskName, exceptionOnNotExists: false);
			TaskDefinition td = ts.NewTask();
			td.RegistrationInfo.Description = "Keeps Haltech Nexus Software and support files automatically updated. Pausing/deleting this task disables this feature.";
			td.Principal.RunLevel = TaskRunLevel.Highest;
			td.Settings.DisallowStartIfOnBatteries = false;
			td.Settings.StopIfGoingOnBatteries = false;
			td.Settings.StartWhenAvailable = true;
			DailyTrigger dt = new DailyTrigger(1);
			dt.DaysInterval = 1;
			dt.StartBoundary = TimeToUseLocal;
			dt.Enabled = true;
			td.Triggers.Add(dt);
			ExecAction ea = new ExecAction();
			ea.Path = Directories.MyPath;
			ea.Arguments = "-au";
			td.Actions.Add(ea);
			ts.RootFolder.RegisterTaskDefinition(Directories.MyTaskName, td, TaskCreation.CreateOrUpdate, "SYSTEM", null, TaskLogonType.ServiceAccount);
		}
		catch (Exception ex)
		{
			if (SvcRuntime.EventLog != null)
			{
				SvcRuntime.EventLog.WriteEntry("(TS) Creation error: " + ex.Message, (EventLogEntryType)1);
			}
		}
	}

	public static void DeleteTask()
	{
		try
		{
			using TaskService ts = new TaskService();
			ts.RootFolder.DeleteTask(Directories.MyTaskName);
		}
		catch (Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry("(TS) Delete error: " + ex.Message, (EventLogEntryType)1);
		}
	}
}
