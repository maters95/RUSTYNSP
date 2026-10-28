using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns4;
using ns7;

namespace ns6;

internal class Class301
{
	internal delegate void Delegate120(string string_0);

	private int Bcr;

	private List<FileInfo> BcS = new List<FileInfo>();

	private ToolStripMenuItem Bcs;

	private ToolStripMenuItem[] BcT;

	[CompilerGenerated]
	private Delegate120 Bct;

	[SpecialName]
	[CompilerGenerated]
	internal void method_0(Delegate120 delegate120_0)
	{
		Delegate120 @delegate = Bct;
		Delegate120 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate120 value = (Delegate120)Delegate.Combine(delegate2, delegate120_0);
			@delegate = Interlocked.CompareExchange(ref Bct, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(Delegate120 delegate120_0)
	{
		Delegate120 @delegate = Bct;
		Delegate120 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate120 value = (Delegate120)Delegate.Remove(delegate2, delegate120_0);
			@delegate = Interlocked.CompareExchange(ref Bct, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	internal Class301(ToolStripMenuItem toolStripMenuItem_0, int int_0)
	{
		Bcs = toolStripMenuItem_0;
		Bcr = int_0;
		BcT = new ToolStripMenuItem[Bcr + 1];
		for (int i = 0; i < Bcr; i++)
		{
			BcT[i] = new ToolStripMenuItem();
			BcT[i].Visible = false;
			Bcs.DropDownItems.Add(BcT[i]);
		}
		method_6();
		method_2();
	}

	private void method_2()
	{
		for (int i = 0; i < BcS.Count; i++)
		{
			BcT[i].Text = string.Format(Class333.aXc(), i + 1, BcS[i].Name);
			BcT[i].Visible = true;
			BcT[i].Tag = BcS[i];
			BcT[i].Click -= method_8;
			BcT[i].Click += method_8;
		}
		for (int j = BcS.Count; j < Bcr; j++)
		{
			BcT[j].Visible = false;
			BcT[j].Click -= method_8;
		}
	}

	internal void method_3(string string_0)
	{
		try
		{
			method_4(string_0);
			BcS.Insert(0, new FileInfo(string_0));
			if (BcS.Count > Bcr)
			{
				BcS.RemoveAt(Bcr);
			}
			method_2();
			method_7();
		}
		catch
		{
		}
	}

	private void method_4(string string_0)
	{
		for (int num = BcS.Count - 1; num >= 0; num--)
		{
			if (BcS[num].FullName == string_0)
			{
				BcS.RemoveAt(num);
			}
		}
	}

	internal void method_5(string string_0)
	{
		method_4(string_0);
		method_2();
		method_7();
	}

	private void method_6()
	{
		if (!File.Exists(Form23.string_7))
		{
			return;
		}
		using StreamReader streamReader = File.OpenText(Form23.string_7);
		string fileName;
		while ((fileName = streamReader.ReadLine()) != null)
		{
			FileInfo fileInfo = null;
			try
			{
				fileInfo = new FileInfo(fileName);
			}
			catch
			{
				fileInfo = null;
			}
			if (fileInfo != null)
			{
				BcS.Add(fileInfo);
			}
		}
	}

	internal void method_7()
	{
		if (BcS.Count == 0)
		{
			return;
		}
		if (!Directory.Exists(Form23.string_3 + Class333.smethod_557()))
		{
			Directory.CreateDirectory(Form23.string_3 + Class333.smethod_557());
		}
		File.Create(Form23.string_7).Close();
		List<string> list = new List<string>();
		foreach (FileInfo bc in BcS)
		{
			list.Add(bc.FullName);
		}
		File.AppendAllLines(Form23.string_7, list);
	}

	private void method_8(object sender, EventArgs e)
	{
		if (Bct != null)
		{
			FileInfo fileInfo = (sender as ToolStripMenuItem).Tag as FileInfo;
			Bct(fileInfo.FullName);
		}
	}
}
