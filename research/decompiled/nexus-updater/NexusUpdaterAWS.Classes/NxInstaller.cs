using System;
using System.Configuration.Install;
using System.Reflection;

namespace NexusUpdaterAWS.Classes;

internal class NxInstaller
{
	private static readonly string _exePath = Assembly.GetExecutingAssembly().Location;

	public static bool InstallMe()
	{
		try
		{
			ManagedInstallerClass.InstallHelper(new string[1] { _exePath });
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	public static bool UninstallMe()
	{
		try
		{
			ManagedInstallerClass.InstallHelper(new string[2] { "/u", _exePath });
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}
}
