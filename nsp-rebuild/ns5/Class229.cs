using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;
using NexusUpdaterAWS;
using ns0;
using ns2;
using ns4;
using ns6;
using ns7;

namespace ns5;

internal static class Class229
{
	[CompilerGenerated]
	private static class Class230
	{
		public static DoWorkEventHandler BRR;

		public static RunWorkerCompletedEventHandler BRr;

		public static RunWorkerCompletedEventHandler BRS;

		public static DoWorkEventHandler BRs;

		public static ProgressChangedEventHandler BRT;

		public static DoWorkEventHandler BRt;

		public static RunWorkerCompletedEventHandler BRU;

		public static RunWorkerCompletedEventHandler BRu;

		public static DoWorkEventHandler BRV;

		public static DoWorkEventHandler BRv;

		public static DoWorkEventHandler BRW;

		public static RunWorkerCompletedEventHandler BRw;
	}

	private static Version abh = new Version(Class333.acv());

	private static readonly EndpointAddress abI = new EndpointAddress(Class333.acW());

	private static readonly NetNamedPipeBinding abi = new NetNamedPipeBinding();

	internal static bool abJ = false;

	private static bool abj = false;

	internal static bool abK = false;

	internal static bool abk = false;

	internal static string abL = string.Empty;

	internal static string abl = string.Empty;

	internal static bool abM = false;

	private static HashSet<string> abm = null;

	private static HashSet<string> abN = null;

	[CompilerGenerated]
	private static EventHandler abn;

	internal static int abO = 100;

	internal static bool abo = false;

	internal static bool abP = false;

	private const string abp = "Firmware";

	private const string abQ = "Definitions";

	internal static void smethod_0()
	{
		if (!smethod_1())
		{
			Form54.smethod_6(Form23.form23_0, Class333.abD(), Class333.abd(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private static bool smethod_1()
	{
		if (Version.TryParse(Form1.smethod_1(), out Version result))
		{
			return result >= abh;
		}
		return false;
	}

	private static NexusAWSSvcCmdClient smethod_2()
	{
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = new NexusAWSSvcCmdClient(abi, abI);
		try
		{
			nexusAWSSvcCmdClient.SetDebugMode(debugMode: false);
		}
		catch
		{
		}
		return nexusAWSSvcCmdClient;
	}

	internal static bool smethod_3()
	{
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		try
		{
			if (nexusAWSSvcCmdClient.KnockKnock())
			{
				return true;
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.abE() + ex.Message);
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.abe());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.abF());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex4)
			{
				Class23.smethod_3(Class333.abf() + ex4.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
		return false;
	}

	internal static void smethod_4()
	{
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		try
		{
			nexusAWSSvcCmdClient.SetDebugMode(debugMode: false);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.abG() + ex.Message);
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.abg());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.abH());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex4)
			{
				Class23.smethod_3(Class333.abh() + ex4.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
	}

	internal static bool smethod_5(out bool bool_0)
	{
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		try
		{
			bool_0 = nexusAWSSvcCmdClient.GetDebugMode();
			return true;
		}
		catch (Exception ex)
		{
			bool_0 = false;
			Class23.smethod_3(Class333.abI() + ex.Message);
			return false;
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.abi());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.abJ());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex4)
			{
				Class23.smethod_3(Class333.abj() + ex4.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
	}

	internal static void smethod_6()
	{
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		try
		{
			nexusAWSSvcCmdClient.ToggleAutoUpdate();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.abK() + ex.Message);
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.abk());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.abL());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex4)
			{
				Class23.smethod_3(Class333.abl() + ex4.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
	}

	internal static bool smethod_7()
	{
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		try
		{
			return nexusAWSSvcCmdClient.AutoUpdateEnabled();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.abM() + ex.Message);
			return false;
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.abm());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.abN());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex4)
			{
				Class23.smethod_3(Class333.abn() + ex4.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
	}

	private static void smethod_8()
	{
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		try
		{
			nexusAWSSvcCmdClient.AbortCurrentOperation();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.abO() + ex.Message);
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.abo());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.abP());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex4)
			{
				Class23.smethod_3(Class333.abp() + ex4.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
	}

	internal static void smethod_9(bool bool_0)
	{
		if (Form23.bool_14 || smethod_11())
		{
			return;
		}
		Form23.form23_0.class162_0.method_7(Class162.Enum44.Bnm, 0, Class333.smethod_1357(), Class333.abQ());
		try
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += smethod_14;
			if (bool_0)
			{
				backgroundWorker.RunWorkerCompleted += smethod_16;
			}
			else
			{
				backgroundWorker.RunWorkerCompleted += smethod_15;
			}
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.WorkerReportsProgress = true;
			backgroundWorker2.DoWork += smethod_21;
			backgroundWorker2.ProgressChanged += Form23.smethod_5;
			backgroundWorker2.RunWorkerAsync();
			backgroundWorker.RunWorkerAsync();
		}
		catch
		{
			if (!bool_0)
			{
				Form54.smethod_6(Form23.form23_0, Class333.abq(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}

	internal static bool smethod_10(bool bool_0)
	{
		if (!Form23.bool_14 && smethod_12())
		{
			if (!abK)
			{
				smethod_31();
				return true;
			}
			if (!bool_0)
			{
				if (Form54.smethod_6(Form23.form23_0, Class333.abR(), Class333.abr(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					abj = true;
					smethod_8();
					Form23.form23_0.class162_0.method_7(Class162.Enum44.Bnl, 0, string.Empty, Class333.abS());
				}
			}
			else
			{
				abj = true;
				smethod_8();
				Form23.form23_0.class162_0.method_7(Class162.Enum44.Bnl, 0, string.Empty, Class333.abS());
			}
			return true;
		}
		return false;
	}

	internal static bool smethod_11()
	{
		if (!Form23.bool_14 && smethod_12())
		{
			if (abK)
			{
				Form54.smethod_6(Form23.form23_0, Class333.abs(), Class333.abr(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				smethod_31();
			}
			return true;
		}
		return false;
	}

	internal static bool smethod_12()
	{
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		try
		{
			return nexusAWSSvcCmdClient.IsUpdaterBusy();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.abT() + ex.Message);
			return false;
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.abt());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.abU());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex4)
			{
				Class23.smethod_3(Class333.abu() + ex4.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
	}

	internal static UpdaterStatus smethod_13()
	{
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		try
		{
			return nexusAWSSvcCmdClient.GetCurrentUpdaterStatus();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.abV() + ex.Message);
			return UpdaterStatus.Idle;
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.abv());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.abW());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex4)
			{
				Class23.smethod_3(Class333.abw() + ex4.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
	}

	private static void smethod_14(object sender, DoWorkEventArgs e)
	{
		Thread.CurrentThread.Name = Class333.abX();
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		nexusAWSSvcCmdClient.InnerChannel.OperationTimeout = new TimeSpan(0, 3, 0);
		abK = true;
		bool flag = smethod_1();
		try
		{
			if (flag)
			{
				e.Result = nexusAWSSvcCmdClient.CheckForUpdates();
			}
			else
			{
				e.Result = nexusAWSSvcCmdClient.UpdateAvailable1();
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.abx() + ex.Message);
			if (flag)
			{
				e.Result = new CheckForUpdatesResult
				{
					CheckSoftwareUpdatesSuccess = false,
					NewSoftwareAvailable = false,
					CheckSupportFilesUpdatesSuccess = false,
					NewSupportFilesAvailable = false,
					CheckSoftwareUpdatesErrorMessage = ex.Message,
					CheckSupportFilesUpdatesErrorMessage = ex.Message
				};
			}
			else
			{
				e.Result = 0;
			}
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.abY());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.aby());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex4)
			{
				Class23.smethod_3(Class333.abZ() + ex4.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
	}

	private static void smethod_15(object sender, RunWorkerCompletedEventArgs e)
	{
		if (Form23.bool_14)
		{
			return;
		}
		if (smethod_1())
		{
			CheckForUpdatesResult checkForUpdatesResult = (CheckForUpdatesResult)e.Result;
			abJ = (checkForUpdatesResult.CheckSoftwareUpdatesSuccess && checkForUpdatesResult.NewSoftwareAvailable) || (checkForUpdatesResult.CheckSupportFilesUpdatesSuccess && checkForUpdatesResult.NewSupportFilesAvailable);
			if (abJ)
			{
				Form23.form23_0.class162_0.method_7(Class162.Enum44.BnM, 0, string.Empty, Class333.smethod_1359());
			}
			else
			{
				Form23.form23_0.class162_0.method_7(Class162.Enum44.Bnl, 0, string.Empty, Class333.abS());
			}
			if (checkForUpdatesResult.CheckSoftwareUpdatesSuccess && checkForUpdatesResult.CheckSupportFilesUpdatesSuccess && (checkForUpdatesResult.NewSoftwareAvailable || checkForUpdatesResult.NewSupportFilesAvailable) && smethod_7())
			{
				smethod_18(bool_0: false);
			}
			else
			{
				string empty = string.Empty;
				if (checkForUpdatesResult.CheckSoftwareUpdatesSuccess)
				{
					empty = ((!checkForUpdatesResult.NewSoftwareAvailable) ? (empty + Class333.aCA()) : (empty + Class333.abz()));
				}
				else
				{
					empty = empty + Class333.aCa() + checkForUpdatesResult.CheckSoftwareUpdatesErrorMessage;
				}
				empty += Class333.smethod_1812();
				if (checkForUpdatesResult.CheckSupportFilesUpdatesSuccess)
				{
					empty = ((!checkForUpdatesResult.NewSupportFilesAvailable) ? (empty + Class333.aCb()) : (empty + Class333.aCB()));
				}
				else
				{
					empty = empty + Class333.aCC() + checkForUpdatesResult.CheckSupportFilesUpdatesErrorMessage;
				}
				if (abJ)
				{
					if (smethod_7())
					{
						Form54.smethod_4(Form23.form23_0, empty, Class333.aCc(), MessageBoxButtons.OK);
						smethod_18(bool_0: false);
					}
					else
					{
						empty += Class333.aCD();
						if (Form54.smethod_4(Form23.form23_0, empty, Class333.smethod_1359(), MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							smethod_18(bool_0: false);
						}
					}
				}
				else
				{
					Form54.smethod_4(Form23.form23_0, empty, Class333.aCc(), MessageBoxButtons.OK);
				}
			}
		}
		else
		{
			int num = (int)e.Result;
			abJ = num > 1;
			if (abJ)
			{
				Form23.form23_0.class162_0.method_7(Class162.Enum44.BnM, 0, string.Empty, Class333.smethod_1359());
				if (smethod_7())
				{
					smethod_18(bool_0: false);
				}
				else if (Form54.smethod_4(Form23.form23_0, Class333.smethod_1358(), Class333.smethod_1359(), MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					smethod_18(bool_0: false);
				}
			}
			else
			{
				Form23.form23_0.class162_0.method_7(Class162.Enum44.Bnl, 0, string.Empty, Class333.abS());
				if (num == 0)
				{
					Form54.smethod_6(Form23.form23_0, Class333.aCd(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					Form54.smethod_4(Form23.form23_0, Class333.aCE(), Class333.aCE(), MessageBoxButtons.OK);
				}
			}
		}
		abj = false;
		abK = false;
	}

	private static void smethod_16(object sender, RunWorkerCompletedEventArgs e)
	{
		if (!Form23.bool_14)
		{
			if (smethod_1())
			{
				CheckForUpdatesResult checkForUpdatesResult = (CheckForUpdatesResult)e.Result;
				abJ = (checkForUpdatesResult.CheckSoftwareUpdatesSuccess && checkForUpdatesResult.NewSoftwareAvailable) || (checkForUpdatesResult.CheckSupportFilesUpdatesSuccess && checkForUpdatesResult.NewSupportFilesAvailable);
			}
			else
			{
				abJ = (int)e.Result > 1;
			}
			if (abJ && smethod_7())
			{
				Form23.form23_0.class162_0.method_7(Class162.Enum44.BnM, 0, string.Empty, Class333.smethod_1359());
				smethod_18(bool_0: true);
			}
			else
			{
				Form23.form23_0.class162_0.method_7(Class162.Enum44.Bnl, 0, string.Empty, Class333.abS());
			}
			abj = false;
			abK = false;
		}
	}

	private static HashSet<string> smethod_17()
	{
		HashSet<string> hashSet = new HashSet<string>();
		try
		{
			if (Directory.Exists(Class320.Bdl))
			{
				string[] files = Directory.GetFiles(Class320.Bdl, Class333.aCe());
				foreach (string item in files)
				{
					hashSet.Add(item);
				}
			}
		}
		catch
		{
			hashSet = null;
		}
		return hashSet;
	}

	internal static void smethod_18(bool bool_0)
	{
		if (!Form23.bool_14 && !smethod_10(bool_0))
		{
			Form23.form23_0.class162_0.method_7(Class162.Enum44.Bnm, 0, Class333.aCF(), Class333.aCf());
			abN = null;
			abm = smethod_17();
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += smethod_19;
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.ProgressChanged += Form23.smethod_5;
			if (bool_0)
			{
				backgroundWorker.RunWorkerCompleted += smethod_26;
			}
			else
			{
				backgroundWorker.RunWorkerCompleted += smethod_25;
				BackgroundWorker backgroundWorker2 = new BackgroundWorker();
				backgroundWorker2.WorkerReportsProgress = true;
				backgroundWorker2.DoWork += smethod_20;
				backgroundWorker2.ProgressChanged += Form23.smethod_5;
				backgroundWorker2.RunWorkerAsync();
			}
			backgroundWorker.RunWorkerAsync();
		}
	}

	private static void smethod_19(object sender, DoWorkEventArgs e)
	{
		Thread.CurrentThread.Name = Class333.aCG();
		UpdateOutcomes updateOutcomes = UpdateOutcomes.Timeout;
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		nexusAWSSvcCmdClient.InnerChannel.OperationTimeout = new TimeSpan(0, 90, 0);
		abK = true;
		try
		{
			try
			{
				updateOutcomes = nexusAWSSvcCmdClient.UpdateManual();
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.aCg() + ex.Message);
			}
			e.Result = updateOutcomes;
		}
		catch (Exception ex2)
		{
			Class23.smethod_3(Class333.aCg() + ex2.Message);
			e.Result = 0;
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.aCH());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.aCh());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex5)
			{
				Class23.smethod_3(Class333.aCI() + ex5.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
	}

	private static void smethod_20(object sender, DoWorkEventArgs e)
	{
		if (Form23.bool_14)
		{
			return;
		}
		Thread.CurrentThread.Name = Class333.aCi();
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		while (!abj)
		{
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
			try
			{
				float? currentPercentProgress = nexusAWSSvcCmdClient.GetCurrentPercentProgress();
				if (currentPercentProgress.HasValue)
				{
					int percentProgress = Math.Max(Math.Min((int)currentPercentProgress.Value, 100), 0);
					int num = (int)nexusAWSSvcCmdClient.GetCurrentDLSpeedKBps().Value;
					string userState = Class333.aCJ() + nexusAWSSvcCmdClient.GetCurrentCategory() + Class333.smethod_497() + num + Class333.aCj();
					backgroundWorker.ReportProgress(percentProgress, userState);
					Thread.Sleep(100);
				}
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.aCK() + ex.Message);
				break;
			}
			finally
			{
				try
				{
					nexusAWSSvcCmdClient.Close();
				}
				catch (CommunicationException)
				{
					Class23.smethod_3(Class333.aCk());
					nexusAWSSvcCmdClient.Abort();
				}
				catch (TimeoutException)
				{
					Class23.smethod_3(Class333.aCL());
					nexusAWSSvcCmdClient.Abort();
				}
				catch (Exception ex4)
				{
					Class23.smethod_3(Class333.aCl() + ex4.Message);
					nexusAWSSvcCmdClient.Abort();
				}
			}
			if (!smethod_12())
			{
				break;
			}
		}
	}

	private static void smethod_21(object sender, DoWorkEventArgs e)
	{
		if (Form23.bool_14)
		{
			return;
		}
		Thread.CurrentThread.Name = Class333.aCM();
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		while (!abj)
		{
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
			try
			{
				float? currentUpdateCheckProgress = nexusAWSSvcCmdClient.GetCurrentUpdateCheckProgress();
				if (currentUpdateCheckProgress.HasValue)
				{
					int percentProgress = Math.Max(Math.Min((int)currentUpdateCheckProgress.Value, 100), 0);
					string userState = Class333.aCm() + percentProgress + Class333.aCN();
					backgroundWorker.ReportProgress(percentProgress, userState);
					Thread.Sleep(100);
				}
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.aCn() + ex.Message);
				break;
			}
			finally
			{
				try
				{
					nexusAWSSvcCmdClient.Close();
				}
				catch (CommunicationException)
				{
					Class23.smethod_3(Class333.aCO());
					nexusAWSSvcCmdClient.Abort();
				}
				catch (TimeoutException)
				{
					Class23.smethod_3(Class333.aCo());
					nexusAWSSvcCmdClient.Abort();
				}
				catch (Exception ex4)
				{
					Class23.smethod_3(Class333.aCP() + ex4.Message);
					nexusAWSSvcCmdClient.Abort();
				}
			}
			if (!smethod_12())
			{
				break;
			}
		}
	}

	private static void smethod_22(object sender, DoWorkEventArgs e)
	{
		if (Form23.bool_14)
		{
			return;
		}
		Thread.CurrentThread.Name = Class333.aCp();
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		abk = true;
		while (true)
		{
			switch (smethod_13())
			{
			case UpdaterStatus.Downloading:
			{
				NexusAWSSvcCmdClient nexusAWSSvcCmdClient2 = smethod_2();
				try
				{
					float? currentPercentProgress = nexusAWSSvcCmdClient2.GetCurrentPercentProgress();
					if (currentPercentProgress.HasValue)
					{
						int percentProgress2 = Math.Max(Math.Min((int)currentPercentProgress.Value, 100), 0);
						int num = (int)nexusAWSSvcCmdClient2.GetCurrentDLSpeedKBps().Value;
						string userState2 = Class333.aCJ() + nexusAWSSvcCmdClient2.GetCurrentCategory() + Class333.smethod_497() + num + Class333.aCj();
						backgroundWorker.ReportProgress(percentProgress2, userState2);
						Thread.Sleep(100);
					}
				}
				catch (Exception ex5)
				{
					Class23.smethod_3(Class333.aCQ() + ex5.Message);
					return;
				}
				finally
				{
					try
					{
						nexusAWSSvcCmdClient2.Close();
					}
					catch (CommunicationException)
					{
						Class23.smethod_3(Class333.aCq());
						nexusAWSSvcCmdClient2.Abort();
					}
					catch (TimeoutException)
					{
						Class23.smethod_3(Class333.aCR());
						nexusAWSSvcCmdClient2.Abort();
					}
					catch (Exception ex8)
					{
						Class23.smethod_3(Class333.aCr() + ex8.Message);
						nexusAWSSvcCmdClient2.Abort();
					}
				}
				break;
			}
			case UpdaterStatus.Checking:
			{
				NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
				try
				{
					float? currentUpdateCheckProgress = nexusAWSSvcCmdClient.GetCurrentUpdateCheckProgress();
					if (currentUpdateCheckProgress.HasValue)
					{
						int percentProgress = Math.Max(Math.Min((int)currentUpdateCheckProgress.Value, 100), 0);
						string userState = Class333.aCm() + percentProgress + Class333.aCN();
						backgroundWorker.ReportProgress(percentProgress, userState);
						Thread.Sleep(100);
					}
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.aCQ() + ex.Message);
					return;
				}
				finally
				{
					try
					{
						nexusAWSSvcCmdClient.Close();
					}
					catch (CommunicationException)
					{
						Class23.smethod_3(Class333.aCq());
						nexusAWSSvcCmdClient.Abort();
					}
					catch (TimeoutException)
					{
						Class23.smethod_3(Class333.aCR());
						nexusAWSSvcCmdClient.Abort();
					}
					catch (Exception ex4)
					{
						Class23.smethod_3(Class333.aCr() + ex4.Message);
						nexusAWSSvcCmdClient.Abort();
					}
				}
				break;
			}
			default:
				return;
			}
			Thread.Sleep(1000);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_23(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = abn;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref abn, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_24(EventHandler eventHandler_0)
	{
		EventHandler eventHandler = abn;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref abn, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private static void smethod_25(object sender, RunWorkerCompletedEventArgs e)
	{
		if (!Form23.bool_14)
		{
			UpdateOutcomes updateOutcomes = (UpdateOutcomes)e.Result;
			bool flag = false;
			switch (updateOutcomes)
			{
			case UpdateOutcomes.CompleteUpdate:
				abJ = false;
				Class305.smethod_0();
				abN = smethod_17();
				smethod_27();
				smethod_30(bool_0: true);
				flag = true;
				break;
			case UpdateOutcomes.DownloadInstallFailed:
				Form54.smethod_6(Form23.form23_0, Class333.aCS(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				break;
			case UpdateOutcomes.InitError:
				Form54.smethod_6(Form23.form23_0, Class333.aCs(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				break;
			case UpdateOutcomes.NoUpdate:
				Form54.smethod_4(Form23.form23_0, Class333.aCT(), Class333.aCt(), MessageBoxButtons.OK);
				break;
			case UpdateOutcomes.Timeout:
				Form54.smethod_6(Form23.form23_0, Class333.aCU(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				break;
			case UpdateOutcomes.Aborted:
				Form54.smethod_6(Form23.form23_0, Class333.aCu(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				break;
			}
			Form23.form23_0.class162_0.method_7(Class162.Enum44.Bnl, 0, string.Empty, Class333.abS());
			abj = false;
			abK = false;
			if (abn != null)
			{
				abn(flag, null);
			}
		}
	}

	private static void smethod_26(object sender, RunWorkerCompletedEventArgs e)
	{
		if (!Form23.bool_14)
		{
			UpdateOutcomes updateOutcomes = (UpdateOutcomes)e.Result;
			bool flag = false;
			Form23.form23_0.class162_0.method_7(Class162.Enum44.Bnl, 0, string.Empty, Class333.abS());
			if (updateOutcomes == UpdateOutcomes.CompleteUpdate)
			{
				abJ = false;
				Class305.smethod_0();
				abN = smethod_17();
				smethod_27();
				flag = true;
			}
			abj = false;
			abK = false;
			if (abn != null)
			{
				abn(flag, null);
			}
		}
	}

	private static void smethod_27()
	{
		if (abN != null && abN.Count != 0)
		{
			HashSet<string> hashSet = new HashSet<string>();
			if (abm != null && abm.Count != 0)
			{
				foreach (string item in abN)
				{
					if (!abm.Contains(item))
					{
						hashSet.Add(item);
					}
				}
			}
			else
			{
				hashSet.UnionWith(abN);
			}
			if (hashSet.Count != 0)
			{
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += smethod_28;
				backgroundWorker.RunWorkerAsync(hashSet);
			}
		}
		abm = null;
		abN = null;
	}

	private static void smethod_28(object sender, DoWorkEventArgs e)
	{
		Thread.CurrentThread.Name = Class333.aCV();
		HashSet<string> hashSet = e.Argument as HashSet<string>;
		abO = 0;
		int num = 0;
		foreach (string item in hashSet)
		{
			Class234.smethod_14(item);
			num++;
			abO = num * 100 / hashSet.Count;
		}
		abO = 100;
		Class234.smethod_6();
	}

	private static void smethod_29(object sender, RunWorkerCompletedEventArgs e)
	{
		if (!Form23.bool_14)
		{
			Form23.form23_0.class162_0.method_7(Class162.Enum44.Bnl, 0, string.Empty, Class333.abS());
			abk = false;
		}
	}

	internal static void smethod_30(bool bool_0)
	{
		if (Form23.bool_14)
		{
			return;
		}
		smethod_36();
		string text = Form23.string_4 + Class333.aCv();
		try
		{
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
		}
		catch
		{
		}
		bool flag = false;
		bool flag2 = false;
		Version version = null;
		try
		{
			string[] files = Directory.GetFiles(Form23.string_4 + Class333.aCW(), Class333.aCw(), SearchOption.AllDirectories);
			foreach (string path in files)
			{
				string[] array = Path.GetFileNameWithoutExtension(path).Split('_');
				if (array.Length >= 2 && Version.TryParse(array[1].Remove(0, 1), out Version result) && (version == null || result > version))
				{
					version = result;
					abL = path;
				}
			}
			if (File.Exists(abL))
			{
				File.Copy(abL, text + Class333.aCX(), overwrite: true);
			}
		}
		catch
		{
		}
		if (File.Exists(text + Class333.aCX()))
		{
			flag = true;
		}
		smethod_34();
		Version version2 = null;
		try
		{
			string[] files = Directory.GetFiles(Form23.string_4 + Class333.aCW(), Class333.aCx(), SearchOption.AllDirectories);
			foreach (string path2 in files)
			{
				string[] array2 = Path.GetFileNameWithoutExtension(path2).Split('_');
				if (array2.Length >= 2 && Version.TryParse(array2[1].Remove(0, 1), out Version result2) && (version2 == null || result2 > version2))
				{
					version2 = result2;
					abl = path2;
				}
			}
			if (File.Exists(abl))
			{
				File.Copy(abl, text + Class333.aCY(), overwrite: true);
			}
		}
		catch
		{
		}
		if (File.Exists(text + Class333.aCY()))
		{
			flag2 = true;
		}
		smethod_37();
		if (flag | flag2)
		{
			Form49 form = new Form49(version, version2);
			switch (form.ShowDialog(Form23.form23_0))
			{
			case DialogResult.Yes:
				Form23.form23_0.statsReporter_0.UserOptInPrivacy = true;
				Form23.form23_0.statsReporter_0.LastAgreedPrivacyDocumentVer = Form15.smethod_0();
				if (flag2)
				{
					abP = false;
					smethod_33();
				}
				if (flag)
				{
					abo = false;
					smethod_32(bool_0: true);
				}
				break;
			case DialogResult.No:
				if (flag)
				{
					abo = true;
				}
				if (flag2)
				{
					abP = true;
				}
				Form23.form23_0.class162_0.method_7(Class162.Enum44.BnM, 0, string.Empty, Class333.aCy());
				Form23.form23_0.statsReporter_0.UserOptInPrivacy = true;
				Form23.form23_0.statsReporter_0.LastAgreedPrivacyDocumentVer = Form15.smethod_0();
				break;
			default:
				Form23.form23_0.class162_0.method_7(Class162.Enum44.BnM, 0, string.Empty, Class333.aCZ());
				break;
			}
			form.Dispose();
		}
		else if (bool_0)
		{
			Version version3 = Assembly.GetEntryAssembly().GetName().Version;
			Form54.smethod_4(Form23.form23_0, Class333.aCz() + version3.ToString() + Class333.smethod_9(), Class333.acA(), MessageBoxButtons.OK);
		}
		else
		{
			smethod_31();
		}
	}

	private static void smethod_31()
	{
		if (!Form23.bool_14 && smethod_12() && !abk)
		{
			if (smethod_13() == UpdaterStatus.Downloading)
			{
				Form23.form23_0.class162_0.method_7(Class162.Enum44.Bnm, 0, Class333.aCF(), Class333.aCf());
			}
			else
			{
				Form23.form23_0.class162_0.method_7(Class162.Enum44.Bnm, 0, Class333.smethod_1357(), Class333.abQ());
			}
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += smethod_22;
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.ProgressChanged += Form23.smethod_5;
			backgroundWorker.RunWorkerCompleted += smethod_29;
			backgroundWorker.RunWorkerAsync();
		}
	}

	internal static void smethod_32(bool bool_0)
	{
		if (Form23.bool_14)
		{
			return;
		}
		Form23.smethod_87(Form23.form23_0, bool_53: false);
		try
		{
			smethod_35(bool_0);
		}
		catch
		{
			Form54.smethod_6(Form23.form23_0, Class333.aca(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal static void smethod_33()
	{
		if (Form23.bool_14)
		{
			return;
		}
		try
		{
			smethod_38();
		}
		catch
		{
			Form54.smethod_6(Form23.form23_0, Class333.acB(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private static void smethod_34()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Form23.string_4 + Class333.aCW());
		if (!directoryInfo.Exists)
		{
			return;
		}
		FileInfo[] files = directoryInfo.GetFiles(Class333.aCw());
		foreach (FileInfo fileInfo in files)
		{
			try
			{
				File.Delete(fileInfo.FullName);
			}
			catch
			{
			}
		}
	}

	private static void smethod_35(bool bool_0)
	{
		if (Form23.bool_14)
		{
			return;
		}
		string text = Form23.string_4 + Class333.aCv();
		_ = Form23.string_4 + Class333.acb();
		string empty = string.Empty;
		try
		{
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process process = new Process
			{
				StartInfo = 
				{
					FileName = Class333.acC(),
					WorkingDirectory = text
				}
			};
			empty = Class333.acc() + text + Class333.acD();
			if (bool_0)
			{
				empty += Class333.acd();
			}
			process.StartInfo.Arguments = empty;
			process.StartInfo.Verb = Class333.acE();
			process.Start();
			process.WaitForExit(60000);
			if (process.ExitCode == 0)
			{
				File.Delete(text + Class333.aCX());
			}
			else if (File.Exists(text + Class333.aCX()))
			{
				File.Copy(text + Class333.aCX(), abL, overwrite: true);
				File.Delete(text + Class333.aCX());
			}
		}
		catch
		{
		}
	}

	private static void smethod_36()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Form23.string_4 + Class333.aCv());
		if (directoryInfo.Exists)
		{
			FileInfo[] files = directoryInfo.GetFiles();
			for (int i = 0; i < files.Length; i++)
			{
				files[i].Delete();
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			for (int i = 0; i < directories.Length; i++)
			{
				directories[i].Delete(recursive: true);
			}
		}
	}

	private static void smethod_37()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Form23.string_4 + Class333.aCW());
		if (!directoryInfo.Exists)
		{
			return;
		}
		FileInfo[] files = directoryInfo.GetFiles(Class333.aCx());
		foreach (FileInfo fileInfo in files)
		{
			try
			{
				File.Delete(fileInfo.FullName);
			}
			catch
			{
			}
		}
	}

	private static void smethod_38()
	{
		if (Form23.bool_14)
		{
			return;
		}
		string text = Form23.string_4 + Class333.aCv();
		_ = Form23.string_4 + Class333.acb();
		string empty = string.Empty;
		try
		{
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process process = new Process();
			process.StartInfo.FileName = Class333.acC();
			process.StartInfo.WorkingDirectory = text;
			empty = Class333.acc() + text + Class333.ace();
			process.StartInfo.Arguments = empty;
			process.StartInfo.Verb = Class333.acE();
			process.Start();
			process.WaitForExit(60000);
			if (process.ExitCode == 0)
			{
				File.Delete(text + Class333.aCY());
			}
			else if (File.Exists(text + Class333.aCY()))
			{
				File.Copy(text + Class333.aCY(), abl, overwrite: true);
				File.Delete(text + Class333.aCY());
			}
		}
		catch
		{
		}
	}

	internal static bool smethod_39(int int_0, int int_1)
	{
		try
		{
			string text = Form23.string_4 + Class333.aBL();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string path = text + Class333.acF();
			List<string> list = new List<string>();
			if (File.Exists(path))
			{
				string[] array = File.ReadAllLines(path);
				if (array != null)
				{
					list.AddRange(array);
				}
				File.Delete(path);
			}
			string item = Class333.acf() + int_0 + Class333.acG() + int_1;
			if (!list.Contains(item))
			{
				list.Add(item);
			}
			File.WriteAllLines(path, list);
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static int? smethod_40(string string_0, bool bool_0, List<S3MetaDataKeyValuePair> list_0)
	{
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		nexusAWSSvcCmdClient.InnerChannel.OperationTimeout = new TimeSpan(0, 3, 0);
		abK = true;
		try
		{
			if (bool_0)
			{
				return nexusAWSSvcCmdClient.DefinitionsAvailable(list_0.ToArray());
			}
			return nexusAWSSvcCmdClient.ObjectsAvailableTagged(string_0, list_0.ToArray());
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.acg() + ex.Message);
			return null;
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.acH());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.ach());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex4)
			{
				Class23.smethod_3(Class333.acI() + ex4.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
	}

	private static int? smethod_41(string string_0, List<S3MetaDataKeyValuePair> list_0)
	{
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		nexusAWSSvcCmdClient.InnerChannel.OperationTimeout = new TimeSpan(0, 3, 0);
		abK = true;
		try
		{
			return nexusAWSSvcCmdClient.LatestObjectVersionAvailableTagged(string_0, list_0.ToArray());
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.aci() + ex.Message);
			return null;
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.acJ());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.acj());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex4)
			{
				Class23.smethod_3(Class333.acK() + ex4.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
	}

	private static List<S3MetaDataKeyValuePair> smethod_42(int int_0, int int_1, Class14 class14_0)
	{
		List<S3MetaDataKeyValuePair> list = new List<S3MetaDataKeyValuePair>();
		S3MetaDataKeyValuePair s3MetaDataKeyValuePair = new S3MetaDataKeyValuePair();
		s3MetaDataKeyValuePair.Key = Class333.ack();
		s3MetaDataKeyValuePair.Value = int_0.ToString();
		list.Add(s3MetaDataKeyValuePair);
		S3MetaDataKeyValuePair s3MetaDataKeyValuePair2 = new S3MetaDataKeyValuePair();
		s3MetaDataKeyValuePair2.Key = Class333.acL();
		s3MetaDataKeyValuePair2.Value = int_1.ToString();
		list.Add(s3MetaDataKeyValuePair2);
		if (Version.TryParse(Form1.smethod_1(), out Version result) && result >= new Version(Class333.acl()))
		{
			S3MetaDataKeyValuePair s3MetaDataKeyValuePair3 = new S3MetaDataKeyValuePair();
			s3MetaDataKeyValuePair3.Key = Class333.acM();
			s3MetaDataKeyValuePair3.Value = Class333.acm() + int_0 + Class333.acN() + int_1;
			list.Add(s3MetaDataKeyValuePair3);
		}
		if (class14_0 != null)
		{
			S3MetaDataKeyValuePair s3MetaDataKeyValuePair4 = new S3MetaDataKeyValuePair();
			s3MetaDataKeyValuePair4.Key = Class333.acn();
			s3MetaDataKeyValuePair4.Value = class14_0.method_0().ToString();
			list.Add(s3MetaDataKeyValuePair4);
			S3MetaDataKeyValuePair s3MetaDataKeyValuePair5 = new S3MetaDataKeyValuePair();
			s3MetaDataKeyValuePair5.Key = Class333.acO();
			s3MetaDataKeyValuePair5.Value = class14_0.method_1().ToString();
			list.Add(s3MetaDataKeyValuePair5);
			S3MetaDataKeyValuePair s3MetaDataKeyValuePair6 = new S3MetaDataKeyValuePair();
			s3MetaDataKeyValuePair6.Key = Class333.aco();
			s3MetaDataKeyValuePair6.Value = class14_0.method_2().ToString();
			list.Add(s3MetaDataKeyValuePair6);
			S3MetaDataKeyValuePair s3MetaDataKeyValuePair7 = new S3MetaDataKeyValuePair();
			s3MetaDataKeyValuePair7.Key = Class333.smethod_126();
			s3MetaDataKeyValuePair7.Value = class14_0.method_3().ToString();
			list.Add(s3MetaDataKeyValuePair7);
			S3MetaDataKeyValuePair s3MetaDataKeyValuePair8 = new S3MetaDataKeyValuePair();
			s3MetaDataKeyValuePair8.Key = Class333.acP();
			s3MetaDataKeyValuePair8.Value = class14_0.method_4().ToString();
			list.Add(s3MetaDataKeyValuePair8);
		}
		return list;
	}

	private static UpdateOutcomes smethod_43(bool bool_0, out string[] string_0)
	{
		UpdateOutcomes result = UpdateOutcomes.Timeout;
		string[] downloadedFilePaths = null;
		NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
		nexusAWSSvcCmdClient.InnerChannel.OperationTimeout = new TimeSpan(0, 10, 0);
		abK = true;
		try
		{
			try
			{
				result = ((!bool_0) ? nexusAWSSvcCmdClient.GetTaggedObjects(out downloadedFilePaths) : nexusAWSSvcCmdClient.GetDefinitionObjects(out downloadedFilePaths));
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.acp() + ex.Message);
			}
			string_0 = downloadedFilePaths;
			return result;
		}
		catch (Exception ex2)
		{
			Class23.smethod_3(Class333.acp() + ex2.Message);
			string_0 = downloadedFilePaths;
			return UpdateOutcomes.NoUpdate;
		}
		finally
		{
			try
			{
				nexusAWSSvcCmdClient.Close();
			}
			catch (CommunicationException)
			{
				Class23.smethod_3(Class333.acQ());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (TimeoutException)
			{
				Class23.smethod_3(Class333.acq());
				nexusAWSSvcCmdClient.Abort();
			}
			catch (Exception ex5)
			{
				Class23.smethod_3(Class333.acR() + ex5.Message);
				nexusAWSSvcCmdClient.Abort();
			}
		}
	}

	internal static void smethod_44(object sender, DoWorkEventArgs e)
	{
		Thread.CurrentThread.Name = Class333.acr();
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		while (abM)
		{
			NexusAWSSvcCmdClient nexusAWSSvcCmdClient = smethod_2();
			try
			{
				int? currentTaggedFilePercentProgress = nexusAWSSvcCmdClient.GetCurrentTaggedFilePercentProgress();
				if (currentTaggedFilePercentProgress.HasValue)
				{
					int percentProgress = Math.Max(Math.Min(currentTaggedFilePercentProgress.Value, 100), 0);
					string userState = Class333.acS() + nexusAWSSvcCmdClient.GetCurrentTaggedFileDownloading();
					backgroundWorker.ReportProgress(percentProgress, userState);
					Thread.Sleep(100);
				}
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.acs() + ex.Message);
				break;
			}
			finally
			{
				try
				{
					nexusAWSSvcCmdClient.Close();
				}
				catch (CommunicationException)
				{
					Class23.smethod_3(Class333.acT());
					nexusAWSSvcCmdClient.Abort();
				}
				catch (TimeoutException)
				{
					Class23.smethod_3(Class333.act());
					nexusAWSSvcCmdClient.Abort();
				}
				catch (Exception ex4)
				{
					Class23.smethod_3(Class333.acU() + ex4.Message);
					nexusAWSSvcCmdClient.Abort();
				}
			}
		}
	}

	internal static string smethod_45(int int_0, int int_1, out int? nullable_0, out UpdateOutcomes updateOutcomes_0)
	{
		nullable_0 = null;
		updateOutcomes_0 = UpdateOutcomes.NoUpdate;
		if (smethod_12())
		{
			return null;
		}
		string result = null;
		List<S3MetaDataKeyValuePair> list_ = smethod_42(int_0, int_1, null);
		nullable_0 = smethod_41(Class333.acu(), list_);
		updateOutcomes_0 = smethod_43(bool_0: false, out var string_);
		if (string_ != null && string_.Length == 1)
		{
			result = string_[0];
		}
		abM = false;
		return result;
	}

	internal static string[] smethod_46(Class14 class14_0, int int_0, int int_1, string string_0, out int? nullable_0, out UpdateOutcomes updateOutcomes_0)
	{
		string[] string_1 = null;
		nullable_0 = null;
		updateOutcomes_0 = UpdateOutcomes.NoUpdate;
		if (File.Exists(string_0))
		{
			string_1 = new string[1] { string_0 };
			nullable_0 = 1;
			updateOutcomes_0 = UpdateOutcomes.CompleteUpdate;
		}
		else
		{
			if (smethod_11())
			{
				return null;
			}
			List<S3MetaDataKeyValuePair> list_ = smethod_42(int_0, int_1, class14_0);
			bool flag = false;
			if (Class242.smethod_12(int_0) && class14_0.method_0() < 3)
			{
				flag = true;
			}
			if (flag)
			{
				nullable_0 = smethod_40(string.Empty, bool_0: true, list_);
				updateOutcomes_0 = smethod_43(bool_0: true, out string_1);
			}
			else
			{
				nullable_0 = smethod_40(Class333.acu(), bool_0: false, list_);
				updateOutcomes_0 = smethod_43(bool_0: false, out string_1);
			}
			if (!nullable_0.HasValue || updateOutcomes_0 != UpdateOutcomes.CompleteUpdate)
			{
				nullable_0 = smethod_40(Class333.acV(), bool_0: false, list_);
				updateOutcomes_0 = smethod_43(bool_0: false, out string_1);
			}
		}
		abM = false;
		return string_1;
	}
}
