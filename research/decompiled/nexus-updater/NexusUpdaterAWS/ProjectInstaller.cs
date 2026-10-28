using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace NexusUpdaterAWS;

[RunInstaller(true)]
public class ProjectInstaller : Installer
{
	private IContainer components;

	private ServiceProcessInstaller serviceProcessInstaller1;

	public ServiceInstaller serviceInstaller1;

	public ProjectInstaller()
	{
		InitializeComponent();
	}

	private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Component)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		serviceProcessInstaller1 = new ServiceProcessInstaller();
		serviceInstaller1 = new ServiceInstaller();
		serviceProcessInstaller1.Account = (ServiceAccount)2;
		serviceProcessInstaller1.Password = null;
		serviceProcessInstaller1.Username = null;
		serviceInstaller1.Description = "Haltech Nexus software update service.";
		serviceInstaller1.DisplayName = "Haltech Nexus Updater";
		serviceInstaller1.ServiceName = "NexusUpdaterAWS";
		serviceInstaller1.StartType = (ServiceStartMode)2;
		((Installer)serviceInstaller1).AfterInstall += serviceInstaller1_AfterInstall;
		((Installer)this).Installers.AddRange(new Installer[2]
		{
			(Installer)serviceProcessInstaller1,
			(Installer)serviceInstaller1
		});
	}
}
