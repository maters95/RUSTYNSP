using System;
using System.Diagnostics;
using System.ServiceProcess;
using NexusUpdaterAWS.Runtime;

namespace NexusUpdaterAWS.Utils;

internal class TaskControl
{
	private const int TIMEOUT = 10000;

	public static void StartService(string serviceName)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		ServiceController service = new ServiceController(serviceName);
		try
		{
			TimeSpan timeout = TimeSpan.FromMilliseconds(10000.0);
			service.Start();
			service.WaitForStatus((ServiceControllerStatus)4, timeout);
		}
		catch (Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry(serviceName + ": " + ex.Message, (EventLogEntryType)1);
		}
	}

	public static void ServiceExecCommand(string serviceName, int cmd)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		ServiceController service = new ServiceController(serviceName);
		try
		{
			TimeSpan.FromMilliseconds(10000.0);
			if ((int)service.Status == 4)
			{
				service.ExecuteCommand(cmd);
			}
		}
		catch (Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry(serviceName + "(Exec): " + ex.Message, (EventLogEntryType)1);
		}
	}

	public static void StopService(string serviceName)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		ServiceController service = new ServiceController(serviceName);
		try
		{
			TimeSpan timeout = TimeSpan.FromMilliseconds(10000.0);
			service.Stop();
			service.WaitForStatus((ServiceControllerStatus)1, timeout);
		}
		catch (Exception ex)
		{
			SvcRuntime.EventLog.WriteEntry(serviceName + ": " + ex.Message, (EventLogEntryType)1);
		}
	}
}
