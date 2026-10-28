using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal class Class110 : Class109
{
	[CompilerGenerated]
	private static class Class40
	{
		public static ProgressChangedEventHandler bAY;
	}

	[CompilerGenerated]
	private sealed class Class41
	{
		public BackgroundWorker bAy;

		public string bAZ;

		internal void method_0()
		{
			Form23.smethod_66(Class333.BJF());
			bAy.ReportProgress(0);
		}

		internal void method_1()
		{
			Form23.smethod_66(Class333.BJf() + bAZ + Class333.BJG());
			bAy.ReportProgress(0);
		}

		internal void method_2()
		{
			Form23.smethod_66(Class333.BJg());
			bAy.ReportProgress(0);
		}

		internal void method_3()
		{
			Form23.smethod_66(Class333.BJH() + bAZ + Class333.BJh());
			bAy.ReportProgress(0);
		}
	}

	private const int Btp = 5;

	private const int BtQ = 5;

	private const int Btq = 20;

	private const int BtR = 10;

	private const int Btr = 220;

	private const int BtS = 370;

	private const int Bts = 22;

	private const int BtT = 350;

	private const int Btt = 300;

	private Framework BtU;

	private Rectangle Btu;

	private Label BtV;

	private ThemedComboBox Btv;

	private ThemedButton BtW;

	private Label Btw;

	private Label BtX;

	private Label Btx;

	private Label BtY;

	private Label Bty;

	private Dictionary<int, Label> BtZ = new Dictionary<int, Label>();

	private Label Btz;

	private Class134 BUA;

	private BackgroundWorker BUa;

	internal Class110(Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false)
	{
		BtU = framework_0;
		Btu = rectangle_0;
	}

	protected override void Dispose(bool disposing)
	{
		if (BtW != null)
		{
			BtW.Click -= BtW_Click;
		}
		BtZ.Clear();
		base.Dispose(disposing);
	}

	internal void method_15()
	{
		SuspendLayout();
		method_12().SuspendLayout();
		if (Btz == null)
		{
			Btz = new Label();
			Btz.Text = Class333.BEu() + BtU.aXA?.ToString() + Class333.smethod_134();
			Btz.ForeColor = Form23.color_12;
			Btz.AutoSize = true;
			Btz.Left = 370;
			Btz.Top = 5;
			method_12().Controls.Add(Btz);
		}
		if (BUA == null)
		{
			BUA = new Class134();
			BUA.Text = Class333.BEV();
			BUA.BackColor = Form23.color_17;
			BUA.ForeColor = Form23.color_12;
			BUA.Left = 370;
			BUA.Top = 22;
			BUA.ReadOnly = true;
			BUA.Size = new Size(350, 300);
			method_12().Controls.Add(BUA);
		}
		if (BUa == null)
		{
			BUa = new BackgroundWorker();
			BUa.DoWork += BUa_DoWork;
			BUa.RunWorkerCompleted += BUa_RunWorkerCompleted;
			BUa.RunWorkerAsync();
		}
		int top = 5;
		if (BtV == null)
		{
			BtV = new Label();
			BtV.Font = new Font(Font.FontFamily, 8f, FontStyle.Bold);
			BtV.Text = Class333.smethod_725();
			BtV.ForeColor = Form23.color_14;
			BtV.AutoSize = true;
			BtV.Left = 5;
			method_12().Controls.Add(BtV);
		}
		BtV.Top = top;
		top = BtV.Bottom + 20;
		if (BtU.aXL.Count >= 2 && Form23.smethod_28(BtU.aXc, bool_53: true) && Class320.smethod_43(BtU.aXc))
		{
			if (Btv == null)
			{
				Btv = new ThemedComboBox();
				Btv.Font = new Font(Btv.Font.FontFamily, 8.25f);
				Btv.DropDownStyle = ComboBoxStyle.DropDownList;
				Btv.Items.Clear();
				int selectedIndex = -1;
				foreach (var item in BtU.aXL)
				{
					Btv.Items.Add(Class242.smethod_9(item.pid, item.vid));
					if (item.pid == BtU.awZ && item.vid == BtU.awz)
					{
						selectedIndex = Btv.Items.Count - 1;
					}
				}
				Btv.SelectedIndex = selectedIndex;
				Btv.Width = 220;
				Btv.Left = 5;
				method_12().Controls.Add(Btv);
			}
			Btv.Top = top;
			if (BtW == null)
			{
				BtW = new ThemedButton();
				BtW.Font = new Font(BtW.Font.FontFamily, 8.25f);
				BtW.Text = Class333.BEv();
				BtW.Width = 120;
				BtW.Height = 25;
				BtW.Left = Btv.Right + 10;
				method_12().Controls.Add(BtW);
				BtW.Click += BtW_Click;
			}
			BtW.Top = top - 3;
			top = BtW.Bottom + 10;
		}
		if (Btw == null)
		{
			Btw = new Label();
			Btw.Text = Class333.agM() + BtU.awy;
			Btw.ForeColor = Form23.color_12;
			Btw.AutoSize = true;
			Btw.Left = 5;
			method_12().Controls.Add(Btw);
		}
		Btw.Top = top;
		top = Btw.Bottom + 10;
		if (!BtU.aXA.method_7())
		{
			if (BtX == null)
			{
				BtX = new Label();
				BtX.Text = Class333.BEW() + BtU.aXA.method_6() + Class333.smethod_1798();
				BtX.ForeColor = Color.Orange;
				BtX.AutoSize = true;
				BtX.Left = 5;
				method_12().Controls.Add(BtX);
			}
			BtX.Top = top;
			top = BtX.Bottom + 10;
		}
		if (Btx == null)
		{
			Btx = new Label();
			Btx.Text = Class333.BEw() + BtU.aXA;
			Btx.ForeColor = Form23.color_12;
			Btx.AutoSize = true;
			Btx.Left = 5;
			method_12().Controls.Add(Btx);
		}
		Btx.Top = top;
		top = Btx.Bottom + 10;
		if (BtY == null)
		{
			BtY = new Label();
			BtY.ForeColor = Form23.color_12;
			BtY.AutoSize = true;
			BtY.Left = 5;
			method_12().Controls.Add(BtY);
		}
		BtY.Top = top;
		if (Form23.smethod_28(BtU.aXc, bool_53: true))
		{
			BtY.Text = Class333.BEX() + BtU.aXc;
		}
		else
		{
			BtY.Text = Class333.BEX();
		}
		Setting setting = BtU.method_31(1127);
		if (setting != null && Class242.smethod_12(BtU.awZ) && (setting.method_258(2) & 0x8000) == 32768 && Form23.smethod_28(BtU.aXc, bool_53: true))
		{
			top = BtY.Bottom + 10;
			if (Bty == null)
			{
				Bty = new Label();
				Bty.Text = Class333.BEx();
				Bty.ForeColor = Form23.color_12;
				Bty.AutoSize = true;
				Bty.Left = 5;
				method_12().Controls.Add(Bty);
			}
			Bty.Top = top;
			top = Bty.Bottom + 20;
		}
		else
		{
			top = BtY.Bottom + 20;
		}
		if (BtU.awI != null)
		{
			foreach (int item2 in BtU.awI.method_71())
			{
				Setting setting2 = BtU.method_31(item2);
				if (setting2 == null)
				{
					continue;
				}
				if (!BtZ.ContainsKey(item2))
				{
					Label label = new Label();
					BtZ.Add(item2, label);
					label.AutoSize = true;
					label.Left = 5;
					method_12().Controls.Add(label);
				}
				Label label2 = BtZ[item2];
				label2.Text = setting2.method_60(Enum96.aYt) + Class333.smethod_571();
				if (Form23.smethod_28(BtU.aXc, bool_53: true))
				{
					if (setting2.method_70() != 0)
					{
						label2.Text += setting2.method_260();
					}
					else
					{
						int num = setting2.method_256();
						int int_ = (num >>> 24) & 0xFF;
						int int_2 = (num >>> 16) & 0xFF;
						int int_3 = (num >>> 8) & 0xFF;
						int int_4 = num & 0xFF;
						Class14 @class = new Class14(int_, int_2, int_3, int_4, 0);
						label2.Text += @class;
					}
				}
				label2.ForeColor = Form23.color_12;
				label2.Top = top;
				top = label2.Bottom + 10;
			}
		}
		if (Btu != Rectangle.Empty)
		{
			Width = Btu.Width;
			Height = Btu.Height;
			Left = Btu.Left;
			Top = Btu.Top;
		}
		else
		{
			int num2 = 0;
			int num3 = 0;
			foreach (Control control in method_12().Controls)
			{
				num2 = Math.Max(num2, control.Right + 10);
				num3 = Math.Max(num3, control.Bottom + 10);
			}
			Width = num2;
			Height = num3;
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
	}

	private void BUa_DoWork(object sender, DoWorkEventArgs e)
	{
		Class240 class240_ = new Class240
		{
			axS = BtU.awZ,
			axs = BtU.awz,
			axT = BtU.aXA,
			axt = BtU.method_11()
		};
		e.Result = Class320.smethod_14(class240_);
	}

	private void BUa_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		if (BUA == null || BUA.IsDisposed)
		{
			return;
		}
		if (e.Result != null)
		{
			BUA.Clear();
			string text = e.Result as string;
			if (!string.IsNullOrEmpty(text))
			{
				BUA.ScrollBars = RichTextBoxScrollBars.None;
				BUA.method_5(text);
				BUA.ScrollBars = RichTextBoxScrollBars.Vertical;
				BUA.method_0();
			}
		}
		else
		{
			BUA.Text = Class333.BEY();
		}
	}

	private void BtW_Click(object sender, EventArgs e)
	{
		if (Btv.SelectedIndex == -1 || Form23.smethod_87(Form23.form23_0, bool_53: true) == DialogResult.Cancel)
		{
			return;
		}
		byte item = BtU.aXL[Btv.SelectedIndex].pid;
		byte item2 = BtU.aXL[Btv.SelectedIndex].vid;
		string text = Class234.smethod_8(item, item2, BtU.aXA, null, bool_0: true);
		string text2 = Class242.smethod_9(item, item2);
		if (string.IsNullOrEmpty(text))
		{
			Form54.smethod_6(Form23.form23_0, Class333.BEy() + text2 + Class333.BEZ() + BtU.aXA.ToString(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		byte[] array = null;
		try
		{
			array = File.ReadAllBytes(text);
		}
		catch (Exception ex)
		{
			array = null;
			Form54.smethod_6(Form23.form23_0, Class333.BEz() + text2 + Class333.BeA() + ex.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		if (array != null)
		{
			Form23.form23_0.method_117();
			Form23.smethod_9();
			Form23.form23_0.Refresh();
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.ProgressChanged += Form23.smethod_69;
			backgroundWorker.DoWork += method_16;
			backgroundWorker.RunWorkerCompleted += method_18;
			Form23.smethod_66(Class333.Bea() + text2 + Class333.smethod_525());
			backgroundWorker.RunWorkerAsync((item, item2, array));
		}
	}

	private void method_16(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker bAy = sender as BackgroundWorker;
		bAy.ReportProgress(0);
		(byte, byte, byte[]) tuple = ((byte, byte, byte[]))e.Argument;
		byte item = tuple.Item1;
		byte item2 = tuple.Item2;
		byte[] item3 = tuple.Item3;
		byte[] byte_ = new byte[10] { 0, 24, 0, 0, 0, item, 0, 0, 0, item2 };
		e.Result = string.Empty;
		if (!Class1.smethod_39(BtU.aXc, Enum10.const_0, 0u, byte_, out var bool_) | bool_)
		{
			e.Result = Class333.BeB();
			return;
		}
		bAy.ReportProgress(100);
		Thread.Sleep(1000);
		Class5 @class = Class1.smethod_26(BtU.aXc);
		if (@class == null)
		{
			e.Result = Class333.Beb();
			return;
		}
		Form23.form23_0.Invoke(() =>
		{
			Form23.smethod_66(Class333.BJF());
			bAy.ReportProgress(0);
		});
		if (!Class320.smethod_46(@class))
		{
			e.Result = Class333.ayC();
			return;
		}
		BtU.method_6();
		bAy.ReportProgress(100);
		Thread.Sleep(500);
		string bAZ = Class242.smethod_9(item, item2);
		Form23.form23_0.Invoke(() =>
		{
			Form23.smethod_66(Class333.BJf() + bAZ + Class333.BJG());
			bAy.ReportProgress(0);
		});
		if (!method_17(bAy, e, @class, item3))
		{
			e.Result = Class333.BeC();
			return;
		}
		@class = Class1.smethod_26(BtU.aXc);
		if (@class == null)
		{
			e.Result = Class333.Beb();
			return;
		}
		Form23.form23_0.Invoke(() =>
		{
			Form23.smethod_66(Class333.BJg());
			bAy.ReportProgress(0);
		});
		if (!Class320.smethod_47(@class))
		{
			e.Result = Class333.Bec();
			return;
		}
		bAy.ReportProgress(100);
		Thread.Sleep(500);
		Form23.form23_0.Invoke(() =>
		{
			Form23.smethod_66(Class333.BJH() + bAZ + Class333.BJh());
			bAy.ReportProgress(0);
		});
		string text = Class234.smethod_8(item, item2, BtU.aXA, null, bool_0: true);
		if (string.IsNullOrEmpty(text))
		{
			e.Result = Class333.BEy() + bAZ + Class333.BEZ() + BtU.aXA.ToString();
			return;
		}
		bAy.ReportProgress(20);
		Framework framework = new Framework(text, item, item2, BtU.aXA);
		framework.aXc = @class.string_0;
		if (framework.method_1() == Class237.Enum91.Brc)
		{
			Form23.framework_1 = framework;
			bAy.ReportProgress(100);
			Thread.Sleep(500);
		}
		else
		{
			e.Result = Class333.BeD() + bAZ + Class333.Bed() + BtU.aXA.ToString();
		}
	}

	private bool method_17(BackgroundWorker backgroundWorker_0, DoWorkEventArgs doWorkEventArgs_0, Class5 class5_0, byte[] byte_0)
	{
		byte[] array = new byte[4 + byte_0.Length];
		array[0] = (byte)((byte_0.Length >>> 24) & 0xFF);
		array[1] = (byte)((byte_0.Length >>> 16) & 0xFF);
		array[2] = (byte)((byte_0.Length >>> 8) & 0xFF);
		array[3] = (byte)(byte_0.Length & 0xFF);
		Array.Copy(byte_0, 0, array, 4, byte_0.Length);
		Class1.smethod_76(BtU.aXc, 1000u);
		uint uint_ = class5_0.struct1_0[3].uint_0;
		uint num = 8192u;
		uint num2 = 0u;
		while (true)
		{
			if (num2 < array.Length / num)
			{
				byte[] array2 = new byte[num];
				Array.Copy(array, num2 * num, array2, 0L, num);
				if (!Class1.smethod_39(BtU.aXc, Enum10.const_0, uint_ + num2 * num, array2, out var bool_) | bool_)
				{
					break;
				}
				backgroundWorker_0.ReportProgress((int)(num2 * num * 90) / array.Length);
				num2++;
				continue;
			}
			uint num3 = (uint)array.Length % num;
			if (num3 != 0)
			{
				byte[] array3 = new byte[num3];
				Array.Copy(array, num2 * num, array3, 0L, num3);
				if (!Class1.smethod_39(BtU.aXc, Enum10.const_0, uint_ + num2 * num, array3, out var bool_2) | bool_2)
				{
					return false;
				}
			}
			backgroundWorker_0.ReportProgress(100);
			Thread.Sleep(200);
			return true;
		}
		return false;
	}

	private void method_18(object sender, RunWorkerCompletedEventArgs e)
	{
		Form23.smethod_68();
		Class1.smethod_77(BtU.aXc);
		BtU = null;
		if ((string)e.Result == string.Empty)
		{
			Form23.form23_0.method_181(null, -1);
			return;
		}
		Form23.smethod_32(bool_53: true);
		Form54.smethod_6(Form23.form23_0, (string)e.Result, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}
}
