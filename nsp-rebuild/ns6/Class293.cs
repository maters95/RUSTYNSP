using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns4;
using ns5;
using ns7;

namespace ns6;

internal class Class293
{
	[CompilerGenerated]
	private static class Class294
	{
		public static ProgressChangedEventHandler Bsr;
	}

	[CompilerGenerated]
	private sealed class Class295
	{
		public FileInfo BsS;

		internal void method_0()
		{
			Form23.smethod_66(Class333.BEp() + BsS.Name + Class333.smethod_525());
		}
	}

	internal string BcL;

	internal bool Bcl;

	internal Class293(string string_0, bool bool_0)
	{
		BcL = string_0;
		Bcl = bool_0;
	}

	internal void method_0()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(BcL);
		if (directoryInfo.Exists)
		{
			string text = directoryInfo.Parent.FullName + ((directoryInfo.Parent.FullName.EndsWith(Class333.smethod_177()) || directoryInfo.Parent.FullName.EndsWith(Class333.smethod_176())) ? string.Empty : Class333.smethod_177()) + directoryInfo.Name + Class333.awl();
			if (!Directory.Exists(text))
			{
				try
				{
					Directory.CreateDirectory(text);
				}
				catch
				{
					string text2 = Class333.awM();
					if (!Form23.bool_14)
					{
						Form54.smethod_6(Form23.form23_0, text2, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
					Console.WriteLine();
					Console.WriteLine(text2);
					Environment.Exit(1);
				}
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				if (!Form23.bool_14)
				{
					backgroundWorker.WorkerReportsProgress = true;
				}
				backgroundWorker.DoWork += method_3;
				backgroundWorker.ProgressChanged += Form23.smethod_69;
				backgroundWorker.RunWorkerCompleted += method_4;
				backgroundWorker.RunWorkerAsync(text);
			}
			else
			{
				string text3 = Class333.awm();
				if (Form23.bool_14)
				{
					Console.WriteLine();
					Console.WriteLine(text3);
					Environment.Exit(1);
				}
				else
				{
					Form54.smethod_6(Form23.form23_0, text3, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
		else
		{
			string text4 = Class333.awN();
			if (Form23.bool_14)
			{
				Console.WriteLine();
				Console.WriteLine(text4);
				Environment.Exit(1);
			}
			else
			{
				Form54.smethod_6(Form23.form23_0, text4, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
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
		foreach (FileInfo BsS in files)
		{
			string text = string.Empty;
			try
			{
				if (!Form23.bool_14)
				{
					backgroundWorker_0.ReportProgress(0);
				}
				if (BsS.FullName.ToLower().EndsWith(Class333.awa()))
				{
					if (!Form23.bool_14)
					{
						Form23.form23_0.Invoke(() =>
						{
							Form23.smethod_66(Class333.BEp() + BsS.Name + Class333.smethod_525());
						});
					}
					if (!Form23.bool_14)
					{
						backgroundWorker_0.ReportProgress(10);
					}
					Stream stream = File.OpenRead(BsS.FullName);
					if (!Form23.bool_14)
					{
						backgroundWorker_0.ReportProgress(20);
					}
					Thread.Sleep(0);
					bool flag;
					try
					{
						flag = Class31.smethod_7(stream);
					}
					catch (Exception)
					{
						flag = false;
					}
					if (flag)
					{
						stream?.Close();
					}
					else
					{
						byte[] array = new byte[stream.Length];
						if (!Class23.smethod_14(stream, array, 0, (int)stream.Length))
						{
							throw new Exception(Class333.awg() + stream.Length + Class333.awn());
						}
						stream?.Close();
						if (!Form23.bool_14)
						{
							backgroundWorker_0.ReportProgress(40);
						}
						Thread.Sleep(0);
						string text2 = Path.GetFileNameWithoutExtension(BsS.FullName);
						if (text2.EndsWith(Class333.awO()))
						{
							text2 = text2.Substring(0, text2.LastIndexOf(Class333.awO()));
						}
						List<KeyValuePair<string, byte[]>> list = new List<KeyValuePair<string, byte[]>>();
						list.Add(new KeyValuePair<string, byte[]>(Class333.aWP(), array));
						stream = File.OpenRead(BsS.FullName);
						Class286 @class = new Class288(stream).method_0();
						stream?.Close();
						if (!Form23.bool_14)
						{
							backgroundWorker_0.ReportProgress(50);
						}
						Thread.Sleep(0);
						string text3 = ((string_0.EndsWith(Class333.smethod_177()) || string_0.EndsWith(Class333.smethod_176())) ? string_0 : (string_0 + Class333.smethod_177()));
						if (!string.IsNullOrEmpty(@class.BcB))
						{
							byte[] array2 = null;
							if (File.Exists(text3 + @class.BcB))
							{
								array2 = File.ReadAllBytes(text3 + @class.BcB);
							}
							else if (File.Exists(text3 + text2 + Class333.smethod_100() + @class.BcB))
							{
								array2 = File.ReadAllBytes(text3 + text2 + Class333.smethod_100() + @class.BcB);
							}
							if (array2 == null)
							{
								throw new Exception(Class333.awo() + @class.BcB + Class333.smethod_1394());
							}
							list.Add(new KeyValuePair<string, byte[]>(@class.BcB, array2));
						}
						if (!Form23.bool_14)
						{
							backgroundWorker_0.ReportProgress(60);
						}
						Thread.Sleep(0);
						method_2(list, text3, text2);
						string text4 = Class333.smethod_102();
						if (@class.BCY != null)
						{
							text4 = Class333.smethod_100() + @class.BCY.ToString();
						}
						if (!Form23.bool_14)
						{
							backgroundWorker_0.ReportProgress(90);
						}
						Thread.Sleep(0);
						Class31.smethod_3(Path.Combine(string_1, text2) + text4 + Class333.smethod_1965(), Class19.smethod_1(), bool_1: true, list.ToArray());
						if (!Form23.bool_14)
						{
							backgroundWorker_0.ReportProgress(100);
						}
						Thread.Sleep(50);
						text = BsS.FullName + Class333.awI();
					}
				}
			}
			catch (Exception ex2)
			{
				text = BsS.FullName + Class333.smethod_571() + ex2.Message;
			}
			if (!string.IsNullOrEmpty(text))
			{
				list_0.Add(text);
			}
		}
		if (Bcl)
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				string string_2 = string_1 + Class333.smethod_177() + directoryInfo2.Name;
				method_1(directoryInfo2.FullName, string_2, list_0, backgroundWorker_0);
			}
		}
	}

	private void method_2(List<KeyValuePair<string, byte[]>> list_0, string string_0, string string_1)
	{
		string path = Path.Combine(string_0, string_1 + Class333.awi());
		if (!Directory.Exists(path))
		{
			return;
		}
		string[] directories = Directory.GetDirectories(path);
		foreach (string path2 in directories)
		{
			string name = new DirectoryInfo(path2).Name;
			string[] files = Directory.GetFiles(path2);
			foreach (string text in files)
			{
				byte[] array = File.ReadAllBytes(text);
				if (array != null)
				{
					string fileName = Path.GetFileName(text);
					string key = Class333.aWz() + name + Class333.smethod_177() + fileName;
					list_0.Add(new KeyValuePair<string, byte[]>(key, array));
					continue;
				}
				throw new Exception(Class333.awP() + text + Class333.smethod_1394());
			}
		}
	}

	private void method_3(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker_ = sender as BackgroundWorker;
		string string_ = e.Argument as string;
		List<string> list = new List<string>();
		method_1(BcL, string_, list, backgroundWorker_);
		e.Result = list;
	}

	private void method_4(object sender, RunWorkerCompletedEventArgs e)
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
		bool flag = num == list.Count;
		string text = Class333.awp() + num + Class333.awK() + (flag ? string.Empty : Class333.awQ());
		foreach (string item2 in list)
		{
			if (!item2.EndsWith(Class333.awJ()))
			{
				text = text + item2 + Class333.smethod_570();
			}
		}
		if (Form23.bool_14)
		{
			Console.WriteLine();
			Console.WriteLine(text);
			Environment.Exit((!flag) ? 1 : 0);
		}
		else
		{
			Form54.smethod_4(Form23.form23_0, text, Class333.awq(), MessageBoxButtons.OK);
		}
	}
}
