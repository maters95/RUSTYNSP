using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns4;
using ns5;
using ns7;

namespace ns6;

internal class Class298
{
	[CompilerGenerated]
	private static class Class299
	{
		public static ProgressChangedEventHandler Bss;
	}

	[CompilerGenerated]
	private sealed class Class300
	{
		public FileInfo BsT;

		internal void method_0()
		{
			Form23.smethod_66(Class333.BEQ() + BsT.Name + Class333.smethod_525());
		}
	}

	internal string BcP;

	internal bool Bcp;

	internal Class14 BcQ;

	private Dictionary<int, int> Bcq;

	private Dictionary<int, List<int>> BcR;

	internal Class298(string string_0, bool bool_0, Class14 class14_0, Dictionary<int, int> dictionary_0, Dictionary<int, List<int>> dictionary_1)
	{
		BcP = string_0;
		Bcp = bool_0;
		BcQ = class14_0;
		Bcq = dictionary_0;
		BcR = dictionary_1;
	}

	internal void method_0()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(BcP);
		if (directoryInfo.Exists)
		{
			string text = directoryInfo.Parent.FullName + ((directoryInfo.Parent.FullName.EndsWith(Class333.smethod_177()) || directoryInfo.Parent.FullName.EndsWith(Class333.smethod_176())) ? string.Empty : Class333.smethod_177()) + directoryInfo.Name + Class333.awW();
			if (!Directory.Exists(text))
			{
				try
				{
					Directory.CreateDirectory(text);
				}
				catch
				{
					Form54.smethod_6(Form23.form23_0, Class333.aww(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.DoWork += method_2;
				backgroundWorker.ProgressChanged += Form23.smethod_69;
				backgroundWorker.RunWorkerCompleted += method_3;
				backgroundWorker.RunWorkerAsync(text);
			}
			else
			{
				Form54.smethod_6(Form23.form23_0, Class333.awX(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, Class333.awx(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_1(string string_0, string string_1, List<string> list_0, BackgroundWorker backgroundWorker_0)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
		if (!Directory.Exists(string_1))
		{
			Directory.CreateDirectory(string_1);
		}
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo BsT in files)
		{
			string text = string.Empty;
			try
			{
				backgroundWorker_0.ReportProgress(0);
				Class240 @class = Class296.smethod_0(BsT.FullName);
				if (@class != null && @class.axS != 1 && @class.axS != 2 && @class.axS != 3 && @class.axS != 4 && @class.axS != 5 && @class.axS != 6)
				{
					Form23.form23_0.Invoke(() =>
					{
						Form23.smethod_66(Class333.BEQ() + BsT.Name + Class333.smethod_525());
					});
					backgroundWorker_0.ReportProgress(10);
					string text2 = Class234.smethod_8(@class.axS, @class.axs, @class.axT, @class.axt, bool_0: true);
					string text3 = Class234.smethod_8(@class.axS, @class.axs, BcQ, null, bool_0: true);
					backgroundWorker_0.ReportProgress(20);
					if (!string.IsNullOrEmpty(text2))
					{
						if (!string.IsNullOrEmpty(text3))
						{
							Framework framework = new Framework(text2, @class.axS, @class.axs, @class.axT);
							if (framework.method_1() == Class237.Enum91.Brc)
							{
								backgroundWorker_0.ReportProgress(50);
								Thread.Sleep(0);
								Framework framework2 = new Framework(text3, @class.axS, @class.axs, BcQ);
								if (framework2.method_1() == Class237.Enum91.Brc)
								{
									backgroundWorker_0.ReportProgress(80);
									Thread.Sleep(0);
									new Class296(BsT.FullName, framework).method_0(out var _);
									framework2.method_48(framework2.aWS);
									framework2.method_69(framework, framework2.aWS, bool_0: true, bool_1: false);
									framework2.method_70(framework, bool_0: false);
									framework2.method_49(framework2.aWS);
									backgroundWorker_0.ReportProgress(90);
									Thread.Sleep(0);
									if (Bcq != null)
									{
										foreach (KeyValuePair<int, int> item in Bcq)
										{
											int key = item.Key;
											int value = item.Value;
											framework2.method_31(key)?.method_272(value, bool_0: false);
										}
									}
									if (BcR != null)
									{
										foreach (KeyValuePair<int, List<int>> item2 in BcR)
										{
											int key2 = item2.Key;
											List<int> value2 = item2.Value;
											Setting setting = framework2.method_31(key2);
											if (setting != null)
											{
												int val = setting.method_277();
												int num = Math.Min(value2.Count, val);
												for (int num2 = 0; num2 < num; num2++)
												{
													setting.method_274(num2, value2[num2], bool_0: false);
												}
											}
										}
									}
									new Class297(Path.Combine(string_1, Path.GetFileNameWithoutExtension(BsT.FullName) + Class242.smethod_8(framework2.awZ, framework2.awz, framework2.aXA)) + Class333.smethod_146(), framework2, bool_0: true).method_0();
									backgroundWorker_0.ReportProgress(100);
									Thread.Sleep(50);
									text = BsT.FullName + Class333.awI();
								}
								else
								{
									text = BsT.FullName + Class333.awY();
								}
							}
							else
							{
								text = BsT.FullName + Class333.awy();
							}
						}
						else
						{
							text = BsT.FullName + Class333.awZ() + BcQ?.ToString() + Class333.awz();
						}
					}
					else
					{
						text = BsT.FullName + Class333.awZ() + @class.axT?.ToString() + Class333.aXA();
					}
				}
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.aXa() + ex.Message);
			}
			if (!string.IsNullOrEmpty(text))
			{
				list_0.Add(text);
			}
		}
		if (Bcp)
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				string string_3 = string_1 + Class333.smethod_177() + directoryInfo2.Name;
				method_1(directoryInfo2.FullName, string_3, list_0, backgroundWorker_0);
			}
		}
	}

	private void method_2(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker_ = sender as BackgroundWorker;
		string string_ = e.Argument as string;
		List<string> list = new List<string>();
		method_1(BcP, string_, list, backgroundWorker_);
		e.Result = list;
	}

	private void method_3(object sender, RunWorkerCompletedEventArgs e)
	{
		Form23.smethod_68();
		List<string> list = e.Result as List<string>;
		int num = 0;
		foreach (string item in list)
		{
			if (item.EndsWith(Class333.awJ()))
			{
				num++;
			}
		}
		string text = Class333.aXB() + num + Class333.aXb();
		foreach (string item2 in list)
		{
			if (!item2.EndsWith(Class333.awJ()))
			{
				text = text + item2 + Class333.smethod_570();
			}
		}
		Form54.smethod_4(Form23.form23_0, text, Class333.aXC(), MessageBoxButtons.OK);
	}
}
