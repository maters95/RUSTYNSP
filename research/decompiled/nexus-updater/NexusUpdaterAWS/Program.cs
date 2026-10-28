using System.ServiceProcess;
using System.Threading;
using HaltechZohoDesk;
using NexusUpdaterAWS.Classes;
using NexusUpdaterAWS.Reporter;
using NexusUpdaterAWS.Utils;

namespace NexusUpdaterAWS;

internal static class Program
{
	private static void Main(string[] args)
	{
		new UsageStatsReporting().StartTimer();
		new TechSupportTickets().StartTimer();
		if (args.Length != 0)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i] != null && args[0].Length > 0 && (args[i][0] == '-' || args[i][0] == '/'))
				{
					switch (args[i].Substring(1).ToLower())
					{
					case "install":
					case "i":
						NxInstaller.InstallMe();
						break;
					case "u":
					case "uninstall":
						NxInstaller.UninstallMe();
						break;
					case "c":
					case "createsched":
						TaskSched.CreateTask();
						break;
					case "d":
					case "deletesched":
						TaskSched.DeleteTask();
						break;
					case "start":
						TaskControl.StartService(Directories.MyName);
						break;
					case "stop":
						TaskControl.StopService(Directories.MyName);
						break;
					case "autoupdateexec":
					case "au":
						Thread.Sleep(5000);
						TaskControl.ServiceExecCommand(Directories.MyName, 128);
						break;
					case "geterrors":
						Logs.GetErrorEntries();
						break;
					}
				}
			}
		}
		else
		{
			ServiceBase.Run(new ServiceBase[1]
			{
				new NexusAWSSvc()
			});
		}
	}
}
