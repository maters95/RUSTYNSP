using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns1;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns3;

internal class Class113 : Class109
{
	private class Class57
	{
		internal byte bAz;

		internal byte baA;
	}

	private class Class58
	{
		internal byte[] baa;

		internal byte baB;

		internal byte bab;

		internal bool baC;
	}

	[CompilerGenerated]
	private static class Class59
	{
		public static ProgressChangedEventHandler bac;
	}

	private const int BuE = 200;

	private const int Bue = 25;

	private Class235 BuF;

	private Rectangle Buf;

	private Setting BuG;

	private List<byte> Bug;

	private ContextMenuStrip BuH = new ContextMenuStrip();

	internal Class113(Class235 class235_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false)
	{
		BuF = class235_0;
		Buf = rectangle_0;
		if (Form23.framework_1.awf.ContainsKey((byte)BuF.method_0()))
		{
			BuG = Form23.framework_1.awf[(byte)BuF.method_0()];
			Bug = BuG.method_158();
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			foreach (Control control in method_12().Controls)
			{
				if (control is ThemedButton)
				{
					(control as ThemedButton).Click -= method_15;
					(control as ThemedButton).Click -= method_16;
					(control as ThemedButton).Click -= method_23;
					(control as ThemedButton).Click -= method_26;
					(control as ThemedButton).Click -= method_29;
					(control as ThemedButton).Click -= method_32;
				}
			}
			foreach (ToolStripMenuItem item in BuH.Items)
			{
				item.Click -= method_17;
			}
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		if (BuG != null && Form23.framework_1.method_4())
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BuG.method_64());
			if (BuG.method_256() == 0)
			{
				BuG.method_272(1, bool_0: true);
			}
			else
			{
				BuG.method_272(0, bool_0: true);
			}
			@class?.method_4();
			Form23.smethod_74(BuG.method_64());
		}
	}

	private void method_16(object sender, EventArgs e)
	{
		if (!Form23.framework_1.method_4())
		{
			return;
		}
		BuH.BackColor = Form23.color_15;
		BuH.ForeColor = Form23.color_12;
		BuH.Items.Clear();
		foreach (byte item in Bug)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem.Text = Class333.Bel() + Class235.smethod_1((Enum88)item);
			toolStripMenuItem.Tag = item;
			toolStripMenuItem.Click += method_17;
			BuH.Items.Add(toolStripMenuItem);
		}
		Point position = new Point(0, 0);
		BuH.Show(sender as ThemedButton, position, ToolStripDropDownDirection.BelowRight);
	}

	private void method_17(object sender, EventArgs e)
	{
		if (Form23.framework_1.method_4())
		{
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			Class57 argument = new Class57
			{
				bAz = (byte)BuF.method_0(),
				baA = (byte)toolStripMenuItem.Tag
			};
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.ProgressChanged += Form23.smethod_69;
			backgroundWorker.DoWork += method_18;
			backgroundWorker.RunWorkerCompleted += method_19;
			Form23.smethod_66(Class333.BeM());
			backgroundWorker.RunWorkerAsync(argument);
		}
	}

	private void method_18(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		Class57 @class = e.Argument as Class57;
		byte bAz = @class.bAz;
		byte baA = @class.baA;
		bool bool_ = false;
		byte[] byte_ = null;
		bool baC = false;
		if (Class1.smethod_48(Form23.framework_1.aXc, bAz, baA, out bool_))
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Restart();
			Form23.form23_0.control4_0.enum88_0 = (Enum88)baA;
			while (true)
			{
				if (stopwatch.ElapsedMilliseconds < 3000L)
				{
					if (!Class1.smethod_49(Form23.framework_1.aXc, bAz, out byte_, out bool_) || byte_.Length == 0)
					{
						break;
					}
					if (byte_[0] == 2)
					{
						backgroundWorker.ReportProgress(Math.Min(100, (int)(stopwatch.ElapsedMilliseconds * 80L / 1000L)));
						Thread.Sleep(10);
						continue;
					}
					if (byte_[0] != 0)
					{
						break;
					}
					if (Form23.framework_1.awf.ContainsKey(baA))
					{
						Setting setting = Form23.framework_1.awf[baA];
						if (setting.method_256() == 0)
						{
							setting.method_272(1, bool_0: true);
							baC = true;
						}
					}
					backgroundWorker.ReportProgress(90);
					Thread.Sleep(500);
					backgroundWorker.ReportProgress(100);
					Thread.Sleep(500);
					break;
				}
				byte_ = null;
				break;
			}
		}
		Class58 result = new Class58
		{
			baa = byte_,
			baB = @class.bAz,
			bab = @class.baA,
			baC = baC
		};
		e.Result = result;
	}

	private void method_19(object sender, RunWorkerCompletedEventArgs e)
	{
		Form23.smethod_68();
		Class58 @class = e.Result as Class58;
		byte[] baa = @class.baa;
		byte baB = @class.baB;
		byte bab = @class.bab;
		string text = Class235.smethod_1((Enum88)baB);
		string text2 = Class235.smethod_1((Enum88)bab);
		Class5 class2 = Class1.smethod_26(Form23.framework_1.aXc);
		string text3 = Class333.aSF();
		if (class2 != null && class2.byte_4 == 21)
		{
			text3 = Class333.aHl();
		}
		if (baa != null && baa.Length != 0)
		{
			string empty = string.Empty;
			byte b = baa[0];
			switch (b)
			{
			case 1:
				if (b != 1)
				{
					goto default;
				}
				empty = Class333.Ben() + text3 + Class333.BeO();
				break;
			case 0:
				empty = Class333.Bem() + text + Class333.BeN() + text2 + Class333.smethod_190();
				break;
			default:
				empty = Class333.BeS();
				break;
			case 144:
				empty = Class333.Beq();
				break;
			case 145:
				empty = text + Class333.BeR();
				break;
			case 146:
				empty = text2 + Class333.Ber();
				break;
			case 129:
				empty = Class333.Beo();
				break;
			case 130:
				empty = Class333.BeP() + text + Class333.Bep();
				break;
			case 131:
				empty = Class333.BeQ();
				break;
			case 132:
				empty = Class333.Ben() + text3 + Class333.BeO();
				break;
			}
			if (baa[0] == 0)
			{
				method_20(empty, baB, bab, @class.baC);
				return;
			}
			Form23.form23_0.control4_0.enum88_0 = Enum88.avK;
			Form54.smethod_6(Form23.form23_0, empty, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			Form23.form23_0.control4_0.enum88_0 = Enum88.avK;
			Form54.smethod_6(Form23.form23_0, Class333.Bes(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_20(string string_0, byte byte_0, byte byte_1, bool bool_0)
	{
		bool flag = false;
		if (bool_0 && Form23.framework_1.awf.ContainsKey(byte_1))
		{
			Form23.smethod_74(Form23.framework_1.awf[byte_1].method_64());
			flag = true;
		}
		bool flag2 = false;
		foreach (SettingOrSpecialObject item in Form23.framework_1.awD)
		{
			PortFunction.Class273 @class = item.method_12().method_12();
			if (@class.BSQ == Class235.smethod_0((Enum88)byte_0))
			{
				List<Class244> list = PortFunction.smethod_44(Form23.framework_1, @class.BSQ, @class.BSq, @class.BSR, @class.BSr, bool_0: false);
				if (list != null && list.Count != 0)
				{
					flag2 = true;
					break;
				}
			}
		}
		if (flag2)
		{
			string text = Class235.smethod_1((Enum88)byte_0);
			string text2 = Class235.smethod_1((Enum88)byte_1);
			DialogResult dialogResult = ((!flag) ? Form54.smethod_8(Form23.form23_0, string_0 + Class333.BeU() + text + Class333.Bet() + text2 + Class333.Beu(), Class333.smethod_14(), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) : Form54.smethod_8(Form23.form23_0, string_0 + Class333.BeT() + text + Class333.Bet() + text2 + Class333.smethod_179(), Class333.smethod_14(), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2));
			if (dialogResult == DialogResult.Yes)
			{
				Enum104 enum104_ = Class235.smethod_0((Enum88)byte_0);
				Enum104 enum104_2 = Class235.smethod_0((Enum88)byte_1);
				PortFunction.smethod_42(Form23.framework_1, enum104_, enum104_2);
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += method_21;
				backgroundWorker.RunWorkerCompleted += method_22;
				backgroundWorker.RunWorkerAsync();
			}
			else
			{
				Form23.form23_0.class168_0_Click(null, null);
			}
		}
		else if (flag)
		{
			Form54.smethod_6(Form23.form23_0, string_0 + Class333.BeV(), Class333.smethod_14(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Form23.form23_0.class168_0_Click(null, null);
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, string_0, Class333.smethod_14(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		Form23.form23_0.control4_0.enum88_0 = (Enum88)byte_1;
		Form23.form23_0.control4_0.method_14(bool_7: false, bool_8: true, bool_9: false, bool_10: false);
	}

	private void method_21(object sender, DoWorkEventArgs e)
	{
		while (Form23.framework_1.method_75())
		{
			Thread.Sleep(100);
		}
	}

	private void method_22(object sender, RunWorkerCompletedEventArgs e)
	{
		Form23.form23_0.class168_0_Click(null, null);
	}

	private void method_23(object sender, EventArgs e)
	{
		if (Form23.list_2.Count == 1)
		{
			Class5 bpS = Form23.list_2[0].BpS;
			if ((BuF.method_0() == Enum88.avU || BuF.method_0() == Enum88.avu || BuF.method_0() == Enum88.avV || BuF.method_0() == Enum88.avv) && BuF.method_1() < Class320.smethod_6(BuF.method_11()))
			{
				string text = ((bpS.byte_4 == 21) ? Class333.aHl() : Class333.aSF());
				Form54.smethod_4(Form23.form23_0, Class333.Bev() + text + Class333.BeW(), Class333.Bew(), MessageBoxButtons.OK);
				return;
			}
			if (Class320.smethod_48(bpS))
			{
				Form54.smethod_6(Form23.form23_0, Class333.BeX(), Class333.Bex(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (Form23.framework_1.method_68())
			{
				Form54.smethod_6(Form23.form23_0, Class333.smethod_1124(), Class333.smethod_1125(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.DoWork += method_24;
			backgroundWorker.ProgressChanged += Form23.smethod_69;
			backgroundWorker.RunWorkerCompleted += method_25;
			Form23.smethod_66(Class333.smethod_1830());
			backgroundWorker.RunWorkerAsync();
		}
	}

	private void method_24(object sender, DoWorkEventArgs e)
	{
		if (Form23.list_2.Count == 1)
		{
			Class5 bpS = Form23.list_2[0].BpS;
			Class14 class14_ = null;
			if (bpS.byte_8 != byte.MaxValue || bpS.byte_9 != byte.MaxValue || bpS.byte_10 != byte.MaxValue || bpS.byte_11 != byte.MaxValue)
			{
				class14_ = new Class14(bpS.byte_8, bpS.byte_9, bpS.byte_10, bpS.byte_11, 0);
			}
			Class14 class14_2 = new Class14(bpS.byte_0, bpS.byte_1, bpS.byte_2, bpS.byte_3, 0);
			bool bool_ = !Form59.smethod_2();
			List<Class318> result = Class320.smethod_38(sender as BackgroundWorker, bpS.byte_4, bpS.byte_5, class14_2, bpS.ushort_0, bpS.string_0, class14_, bool_, BuF.method_0(), BuF.method_1(), BuF.method_11());
			e.Result = result;
		}
		else
		{
			e.Result = null;
		}
	}

	private void method_25(object sender, RunWorkerCompletedEventArgs e)
	{
		Form23.smethod_68();
		if (e.Result != null && Form23.list_2.Count == 1)
		{
			List<Class318> list_ = (List<Class318>)e.Result;
			Class5 bpS = Form23.list_2[0].BpS;
			Form16 form = new Form16(list_, bpS, BuF.method_0(), BuF.method_1(), BuF.method_11());
			form.ShowDialog(this);
			form.Dispose();
		}
	}

	private void method_26(object sender, EventArgs e)
	{
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.ProgressChanged += Form23.smethod_69;
		backgroundWorker.DoWork += method_27;
		backgroundWorker.RunWorkerCompleted += method_28;
		Form23.smethod_66(Class333.BeY());
		backgroundWorker.RunWorkerAsync();
	}

	private void method_27(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		MemoryStream memoryStream = new MemoryStream();
		byte[] byte_ = new byte[2] { 0, 26 };
		Class1.smethod_76(Form23.framework_1.aXc, 30000u);
		if (Class1.smethod_40(Form23.framework_1.aXc, (byte)BuF.method_0(), Enum10.const_0, 0u, byte_, 256u, out var byte_2, out var bool_))
		{
			try
			{
				backgroundWorker.ReportProgress(5);
				string text = string.Empty;
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					uint num = Class1.smethod_73(Form23.framework_1.aXc, Enum10.const_18);
					uint num2 = 0u;
					while (true)
					{
						if (Class1.smethod_36(Form23.framework_1.aXc, (byte)BuF.method_0(), Enum10.const_18, num2, num, out var byte_3, out bool_))
						{
							if (byte_3.Length != 0)
							{
								memoryStream2.Write(byte_3, 0, byte_3.Length);
							}
							if (byte_3.Length < num)
							{
								break;
							}
							num2 += num;
							backgroundWorker.ReportProgress(Math.Min(100, 5 + (int)(num2 * 95) / 1000000));
							continue;
						}
						text = Class333.Bey();
						break;
					}
					if (text == string.Empty)
					{
						Version version = Assembly.GetEntryAssembly().GetName().Version;
						byte_2[104] = (byte)version.Major;
						byte_2[105] = (byte)version.Minor;
						byte_2[106] = (byte)version.Build;
						byte_2[107] = (byte)version.Revision;
						byte_2[108] = 0;
						byte_2[109] = 0;
						byte_2[110] = 0;
						byte_2[111] = 0;
						DateTime now = DateTime.Now;
						byte_2[112] = smethod_0((byte)(now.Year / 100));
						byte_2[113] = smethod_0((byte)(now.Year % 100));
						byte_2[114] = smethod_0((byte)now.Month);
						byte_2[115] = smethod_0((byte)now.Day);
						byte_2[116] = smethod_0((byte)now.Hour);
						byte_2[117] = smethod_0((byte)now.Minute);
						byte_2[118] = smethod_0((byte)now.Second);
						byte_2[119] = 0;
						byte[] array = memoryStream2.ToArray();
						using (MD5 mD = MD5.Create())
						{
							byte[] array2 = mD.ComputeHash(array);
							for (int i = 0; i < 16; i++)
							{
								byte_2[120 + i] = array2[i];
							}
						}
						memoryStream.Write(byte_2, 0, byte_2.Length);
						memoryStream.Write(array, 0, array.Length);
					}
				}
				backgroundWorker.ReportProgress(100);
				Thread.Sleep(500);
				e.Result = (text, memoryStream);
			}
			catch (Exception ex)
			{
				string item = Class333.BeZ() + ex.Message;
				e.Result = (item, memoryStream);
			}
		}
		else
		{
			string item2 = Class333.Bez();
			e.Result = (item2, memoryStream);
		}
		Class1.smethod_77(Form23.framework_1.aXc);
	}

	private void method_28(object sender, RunWorkerCompletedEventArgs e)
	{
		Form23.smethod_68();
		(string, MemoryStream) tuple = ((string, MemoryStream))e.Result;
		if (string.IsNullOrEmpty(tuple.Item1))
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = Class333.smethod_2372();
			saveFileDialog.FileName = Class333.BFA() + Class23.smethod_10(bool_1: false);
			if (saveFileDialog.ShowDialog(Form23.form23_0) == DialogResult.OK)
			{
				try
				{
					File.WriteAllBytes(saveFileDialog.FileName, tuple.Item2.ToArray());
				}
				catch (Exception ex)
				{
					Form54.smethod_6(Form23.form23_0, Class333.BFa() + ex.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			saveFileDialog.Dispose();
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, tuple.Item1, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		tuple.Item2.Dispose();
	}

	private void method_29(object sender, EventArgs e)
	{
		if (Form23.list_2.Count == 1 && Form54.smethod_6(Form23.form23_0, Class333.BFB(), Class333.BFb(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			Class5 bpS = Form23.list_2[0].BpS;
			if (Class320.smethod_48(bpS))
			{
				Form54.smethod_6(Form23.form23_0, Class333.BFC(), Class333.Bex(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (Form23.framework_1.method_68())
			{
				Form54.smethod_6(Form23.form23_0, Class333.BFc(), Class333.smethod_1125(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.DoWork += method_30;
			backgroundWorker.ProgressChanged += Form23.smethod_69;
			backgroundWorker.RunWorkerCompleted += method_31;
			Form23.smethod_66(Class333.BFD());
			backgroundWorker.RunWorkerAsync(bpS);
		}
	}

	private void method_30(object sender, DoWorkEventArgs e)
	{
		int num = Form23.framework_1.method_31(19236).method_256();
		(string Path, string Error) tuple = Class320.smethod_42(sender as BackgroundWorker, BuF.method_0(), num);
		string item = tuple.Path;
		string item2 = tuple.Error;
		Class5 item3 = e.Argument as Class5;
		e.Result = (item2, item, item3);
	}

	private void method_31(object sender, RunWorkerCompletedEventArgs e)
	{
		Form23.smethod_68();
		(string, string, Class5) tuple = ((string, string, Class5))e.Result;
		if (tuple.Item2 == null)
		{
			Form23 form23_ = Form23.form23_0;
			string string_;
			if (!string.IsNullOrEmpty(tuple.Item1))
			{
				(string_, _, _) = tuple;
			}
			else
			{
				string_ = Class333.BFd();
			}
			Form54.smethod_6(form23_, string_, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			Class320.smethod_18(tuple.Item3, tuple.Item2, BuF.method_0());
		}
	}

	private void method_32(object sender, EventArgs e)
	{
		if (Form54.smethod_6(Form23.form23_0, Class333.BFE(), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.ProgressChanged += Form23.smethod_69;
			backgroundWorker.DoWork += method_33;
			backgroundWorker.RunWorkerCompleted += method_34;
			Form23.smethod_66(Class333.BFe());
			backgroundWorker.RunWorkerAsync();
		}
	}

	private void method_33(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		bool bool_ = false;
		byte[] byte_ = null;
		byte[] byte_2 = new byte[2] { 0, 25 };
		if (Class1.smethod_38(Form23.framework_1.aXc, (byte)BuF.method_0(), Enum10.const_0, 0u, byte_2, out bool_))
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Restart();
			while (true)
			{
				if (stopwatch.ElapsedMilliseconds < 2000L)
				{
					if (!Class1.smethod_49(Form23.framework_1.aXc, (byte)BuF.method_0(), out byte_, out bool_) || byte_.Length == 0)
					{
						break;
					}
					if (byte_[0] == 2)
					{
						backgroundWorker.ReportProgress(Math.Min(100, (int)stopwatch.ElapsedMilliseconds));
						Thread.Sleep(10);
						continue;
					}
					backgroundWorker.ReportProgress(100);
					Thread.Sleep(600);
					break;
				}
				byte_ = null;
				break;
			}
		}
		e.Result = byte_;
	}

	private void method_34(object sender, RunWorkerCompletedEventArgs e)
	{
		Form23.smethod_68();
		if (e.Result is byte[] array && array.Length != 0)
		{
			if (array[0] == 0)
			{
				Form54.smethod_6(Form23.form23_0, Class333.BFF(), Class333.smethod_14(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				Form54.smethod_6(Form23.form23_0, Class333.BFf(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, Class333.Bes(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal void method_35(bool bool_0)
	{
		SuspendLayout();
		method_12().SuspendLayout();
		int left = 5;
		int num = 5;
		Label label = new Label();
		label.ForeColor = Form23.color_14;
		label.Font = new Font(label.Font.FontFamily, 10f, FontStyle.Bold);
		label.AutoSize = true;
		label.Text = BuF.method_15();
		label.Left = 5;
		label.Top = 5;
		num = label.Bottom + 10;
		if (bool_0)
		{
			method_12().Controls.Add(label);
		}
		else
		{
			label.Dispose();
		}
		ThemedButton themedButton = null;
		if (BuG != null && !BuG.method_219() && (!Form23.framework_1.method_2() || !Form23.framework_1.method_3() || !BuG.method_96()))
		{
			if (!bool_0)
			{
				if (method_12().Controls.ContainsKey(Class333.BFG()))
				{
					themedButton = method_12().Controls[Class333.BFG()] as ThemedButton;
				}
			}
			else
			{
				themedButton = new ThemedButton();
				themedButton.Enabled = Form23.framework_1.method_4();
				themedButton.Click += method_15;
				themedButton.Name = Class333.BFG();
				themedButton.Width = 200;
				themedButton.Height = 25;
				themedButton.Left = left;
				themedButton.Top = num;
				num = themedButton.Bottom + 10;
				method_12().Controls.Add(themedButton);
			}
		}
		Label label2 = null;
		if (!bool_0)
		{
			if (method_12().Controls.ContainsKey(Class333.BFg()))
			{
				label2 = method_12().Controls[Class333.BFg()] as Label;
			}
		}
		else
		{
			label2 = new Label();
			label2.Name = Class333.BFg();
			label2.ForeColor = Form23.color_12;
			label2.Font = new Font(label2.Font.FontFamily, 8f, FontStyle.Bold);
			label2.AutoSize = true;
			label2.Left = left;
			label2.Top = num;
			num = label2.Bottom + 10;
			method_12().Controls.Add(label2);
		}
		Label label3 = null;
		if (!bool_0)
		{
			if (method_12().Controls.ContainsKey(Class333.BFH()))
			{
				label3 = method_12().Controls[Class333.BFH()] as Label;
			}
		}
		else
		{
			label3 = new Label();
			label3.Name = Class333.BFH();
			label3.ForeColor = Form23.color_12;
			label3.Font = new Font(label3.Font.FontFamily, 8f, FontStyle.Bold);
			label3.AutoSize = true;
			label3.Left = left;
			label3.Top = num;
			num = label3.Bottom + 10;
			method_12().Controls.Add(label3);
		}
		Label label4 = null;
		if (!bool_0)
		{
			if (method_12().Controls.ContainsKey(Class333.BFh()))
			{
				label4 = method_12().Controls[Class333.BFh()] as Label;
			}
		}
		else
		{
			label4 = new Label();
			label4.Name = Class333.BFh();
			label4.ForeColor = Form23.color_12;
			label4.Font = new Font(label4.Font.FontFamily, 8f, FontStyle.Bold);
			label4.AutoSize = true;
			label4.Left = left;
			label4.Top = num;
			num = label4.Bottom + 10;
			method_12().Controls.Add(label4);
		}
		ThemedButton themedButton2 = null;
		if (Form23.list_2.Count == 1)
		{
			Class5 bpS = Form23.list_2[0].BpS;
			if ((Class320.smethod_3(bpS.byte_4, bpS.byte_5, new Class14(bpS.byte_0, bpS.byte_1, bpS.byte_2, bpS.byte_3, bpS.int_0)) && Class320.smethod_4(BuF.method_0())) || BuF.method_0() == Enum88.avU || BuF.method_0() == Enum88.avu || BuF.method_0() == Enum88.avV || BuF.method_0() == Enum88.avv)
			{
				if (!bool_0)
				{
					foreach (Control control3 in method_12().Controls)
					{
						if ((string)control3.Tag == Class333.BFI())
						{
							themedButton2 = control3 as ThemedButton;
							break;
						}
					}
				}
				else
				{
					themedButton2 = new ThemedButton();
					themedButton2.Text = Class333.BFi();
					themedButton2.Click += method_23;
					themedButton2.Tag = Class333.BFI();
					themedButton2.Width = 200;
					themedButton2.Height = 25;
					themedButton2.Left = left;
					themedButton2.Top = num;
					num = themedButton2.Bottom + 10;
					method_12().Controls.Add(themedButton2);
				}
			}
		}
		ThemedButton themedButton3 = null;
		if (BuG != null && Bug != null && Bug.Count != 0)
		{
			if (!bool_0)
			{
				if (method_12().Controls.ContainsKey(Class333.BFJ()))
				{
					themedButton3 = method_12().Controls[Class333.BFJ()] as ThemedButton;
				}
			}
			else
			{
				themedButton3 = new ThemedButton();
				themedButton3.Enabled = Form23.framework_1.method_4();
				themedButton3.Text = Class333.BFj();
				themedButton3.Click += method_16;
				themedButton3.Name = Class333.BFJ();
				themedButton3.Width = 200;
				themedButton3.Height = 25;
				themedButton3.Left = left;
				themedButton3.Top = num;
				num = themedButton3.Bottom + 10;
				method_12().Controls.Add(themedButton3);
			}
		}
		ThemedButton themedButton4 = null;
		ThemedButton themedButton5 = null;
		ThemedButton themedButton6 = null;
		if (BuF.method_0() == Enum88.avx && Form23.framework_1.method_31(19236) != null && !BuF.method_12())
		{
			if (!bool_0)
			{
				if (method_12().Controls.ContainsKey(Class333.BFK()))
				{
					themedButton4 = method_12().Controls[Class333.BFK()] as ThemedButton;
				}
				if (method_12().Controls.ContainsKey(Class333.BFk()))
				{
					themedButton5 = method_12().Controls[Class333.BFk()] as ThemedButton;
				}
				if (method_12().Controls.ContainsKey(Class333.BFL()))
				{
					themedButton6 = method_12().Controls[Class333.BFL()] as ThemedButton;
				}
			}
			else
			{
				themedButton4 = new ThemedButton();
				themedButton4.Text = Class333.BFl();
				themedButton4.Click += method_26;
				themedButton4.Name = Class333.BFK();
				themedButton4.Width = 200;
				themedButton4.Height = 25;
				themedButton4.Left = left;
				themedButton4.Top = num;
				num = themedButton4.Bottom + 10;
				method_12().Controls.Add(themedButton4);
				themedButton5 = new ThemedButton();
				themedButton5.Text = Class333.BFM();
				themedButton5.Click += method_29;
				themedButton5.Name = Class333.BFk();
				themedButton5.Width = 200;
				themedButton5.Height = 25;
				themedButton5.Left = left;
				themedButton5.Top = num;
				num = themedButton5.Bottom + 10;
				method_12().Controls.Add(themedButton5);
				themedButton6 = new ThemedButton();
				themedButton6.Text = Class333.BFm();
				themedButton6.Click += method_32;
				themedButton6.Name = Class333.BFL();
				themedButton6.Width = 200;
				themedButton6.Height = 25;
				themedButton6.Left = left;
				themedButton6.Top = num;
				num = themedButton6.Bottom + 10;
				method_12().Controls.Add(themedButton6);
			}
		}
		bool flag = false;
		bool flag2 = false;
		if (Form23.smethod_28(Form23.framework_1.aXc, bool_53: true))
		{
			label2.Visible = true;
			if (!BuF.method_7() && BuF.method_8())
			{
				if (BuF.method_9())
				{
					if (BuF.method_13())
					{
						label2.Text = Class333.BFO();
					}
					else if (BuF.method_12())
					{
						label2.Text = Class333.BFo();
					}
					else if (BuF.method_10())
					{
						label2.Text = Class333.BFP();
					}
					else if (BuF.method_11())
					{
						label2.Text = Class333.BFp();
					}
					else
					{
						flag2 = true;
						label2.Text = Class333.BFQ();
					}
					flag = true;
					label3.Text = Class333.BFq() + BuF.method_1().ToString();
					label4.Text = Class333.BEX() + BuF.method_3();
				}
				else
				{
					label2.Text = Class333.BFR();
				}
				if (themedButton != null)
				{
					if (BuG.method_256() == 0)
					{
						themedButton.Text = Class333.BFn();
					}
					else
					{
						themedButton.Text = Class333.BFr();
					}
				}
			}
			else
			{
				label2.Text = Class333.BFN();
				if (themedButton != null)
				{
					themedButton.Text = Class333.BFn();
				}
			}
		}
		else
		{
			label2.Visible = false;
			if (themedButton != null)
			{
				if (BuG.method_256() == 0)
				{
					themedButton.Text = Class333.BFn();
				}
				else
				{
					themedButton.Text = Class333.BFr();
				}
			}
		}
		if (label3 != null)
		{
			label3.Visible = flag && BuF.method_1() != new Class14(0, 0, 0, 0, 0);
		}
		if (label4 != null)
		{
			label4.Visible = flag && BuF.method_3() != string.Empty && BuF.method_3() != Class333.smethod_59();
		}
		if (themedButton2 != null)
		{
			themedButton2.Visible = flag || BuF.method_0() == Enum88.avU || BuF.method_0() == Enum88.avu || BuF.method_0() == Enum88.avV || BuF.method_0() == Enum88.avv;
		}
		bool visible = flag & flag2;
		if (themedButton3 != null)
		{
			themedButton3.Visible = visible;
		}
		if (themedButton4 != null)
		{
			themedButton4.Visible = visible;
		}
		if (themedButton5 != null)
		{
			themedButton5.Visible = visible;
		}
		if (themedButton6 != null)
		{
			themedButton6.Visible = visible;
		}
		if (Buf != Rectangle.Empty)
		{
			Width = Buf.Width;
			Height = Buf.Height;
			Left = Buf.Left;
			Top = Buf.Top;
		}
		else
		{
			int num2 = 0;
			int num3 = 0;
			foreach (Control control4 in method_12().Controls)
			{
				num2 = Math.Max(num2, control4.Right + 10);
				num3 = Math.Max(num3, control4.Bottom + 10);
			}
			Width = num2;
			Height = num3;
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
	}

	[CompilerGenerated]
	internal static byte smethod_0(byte byte_0)
	{
		return (byte)((byte_0 / 10 << 4) | (byte_0 % 10));
	}
}
