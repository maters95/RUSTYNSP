using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns4;
using ns5;
using ns7;

namespace ns6;

internal class Class290
{
	[CompilerGenerated]
	private static class Class291
	{
		public static ProgressChangedEventHandler Bsq;
	}

	[CompilerGenerated]
	private sealed class Class292
	{
		public FileInfo BsR;

		internal void method_0()
		{
			Form23.smethod_66(Class333.BEP() + BsR.Name + Class333.smethod_525());
		}
	}

	internal string BcK;

	internal bool Bck;

	internal Class290(string string_0, bool bool_0)
	{
		BcK = string_0;
		Bck = bool_0;
	}

	internal void method_0()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(BcK);
		if (directoryInfo.Exists)
		{
			string text = directoryInfo.Parent.FullName + ((directoryInfo.Parent.FullName.EndsWith(Class333.smethod_177()) || directoryInfo.Parent.FullName.EndsWith(Class333.smethod_176())) ? string.Empty : Class333.smethod_177()) + directoryInfo.Name + Class333.awd();
			if (!Directory.Exists(text))
			{
				try
				{
					Directory.CreateDirectory(text);
				}
				catch
				{
					string text2 = Class333.awE();
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
				string text3 = Class333.awe();
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
			string text4 = Class333.awF();
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
		foreach (FileInfo BsR in files)
		{
			string text = string.Empty;
			try
			{
				if (!Form23.bool_14)
				{
					backgroundWorker_0.ReportProgress(0);
				}
				if (BsR.FullName.EndsWith(Class333.smethod_1965()))
				{
					if (!Form23.bool_14)
					{
						Form23.form23_0.Invoke(() =>
						{
							Form23.smethod_66(Class333.BEP() + BsR.Name + Class333.smethod_525());
						});
					}
					if (!Form23.bool_14)
					{
						backgroundWorker_0.ReportProgress(10);
					}
					Stream stream = File.OpenRead(BsR.FullName);
					if (!Form23.bool_14)
					{
						backgroundWorker_0.ReportProgress(20);
					}
					Thread.Sleep(0);
					List<string> list = Class31.smethod_8(stream, Class19.smethod_1());
					for (int num = 0; num < list.Count; num++)
					{
						string text2 = list[num];
						if (Class31.smethod_5(stream, text2, out var stream_, Class19.smethod_1()) && stream_ != null)
						{
							if (!Form23.bool_14)
							{
								backgroundWorker_0.ReportProgress(50 + (num + 1) * 40 / list.Count);
							}
							Thread.Sleep(0);
							string path2;
							if (text2 == Class333.aWP())
							{
								string path = Regex.Replace(Path.GetFileNameWithoutExtension(BsR.FullName), Class333.awf(), Class333.smethod_102());
								path2 = Path.Combine(string_1, path) + Class333.awG();
							}
							else
							{
								string text3 = method_2(text2, BsR, string_1);
								path2 = ((text3 == null) ? Path.Combine(string_1, text2) : text3);
							}
							byte[] array = new byte[stream_.Length];
							if (Class23.smethod_14(stream_, array, 0, (int)stream_.Length))
							{
								File.WriteAllBytes(path2, array);
								stream_?.Close();
								continue;
							}
							throw new Exception(Class333.awg() + stream_.Length + Class333.awH());
						}
						text = BsR.FullName + Class333.awh();
						break;
					}
					stream?.Close();
					if (!Form23.bool_14)
					{
						backgroundWorker_0.ReportProgress(100);
					}
					Thread.Sleep(50);
					if (string.IsNullOrEmpty(text))
					{
						text = BsR.FullName + Class333.awI();
					}
				}
			}
			catch (Exception ex)
			{
				text = BsR.FullName + Class333.smethod_571() + ex.Message;
			}
			if (!string.IsNullOrEmpty(text))
			{
				list_0.Add(text);
			}
		}
		if (Bck)
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				string string_2 = string_1 + Class333.smethod_177() + directoryInfo2.Name;
				method_1(directoryInfo2.FullName, string_2, list_0, backgroundWorker_0);
			}
		}
	}

	private string method_2(string string_0, FileInfo fileInfo_0, string string_1)
	{
		if (string_0.StartsWith(Class333.smethod_2009()) && string_0.Length > Class333.smethod_2009().Length + 1)
		{
			string text = Path.Combine(string_1, Path.GetFileNameWithoutExtension(fileInfo_0.FullName) + Class333.awi());
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			int startIndex = Class333.smethod_2009().Length + 1;
			string text2 = string_0.Substring(startIndex);
			int num = text2.IndexOfAny(new char[2] { '\\', '/' });
			if (num != -1)
			{
				string text3 = text2.Substring(0, num);
				int length = (Class333.aWz() + text3 + Class333.smethod_177()).Length;
				if (length < string_0.Length)
				{
					string text4 = Path.Combine(text, text3);
					if (!Directory.Exists(text4))
					{
						Directory.CreateDirectory(text4);
					}
					string path = string_0.Substring(length);
					return Path.Combine(text4, path);
				}
			}
		}
		return null;
	}

	private void method_3(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker_ = sender as BackgroundWorker;
		string string_ = e.Argument as string;
		List<string> list = new List<string>();
		method_1(BcK, string_, list, backgroundWorker_);
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
		string text = Class333.awj() + num + Class333.awK() + (flag ? string.Empty : Class333.awk());
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
			Form54.smethod_4(Form23.form23_0, text, Class333.awL(), MessageBoxButtons.OK);
		}
	}
}
