using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns1;
using ns4;
using ns5;
using ns7;

namespace ns3;

internal class Class116 : Class109
{
	private delegate void Delegate74();

	private delegate void Delegate75(object sender, EventArgs e);

	private delegate void Delegate76(object sender, EventArgs e);

	private delegate void Delegate77(object sender, EventArgs e);

	internal enum Enum39
	{
		bBF = 255,
		bBf = 0,
		bBG = 1,
		bBg = 2,
		bBH = 3,
		bBh = 4,
		bBI = 5,
		bBi = 6,
		bBJ = 7,
		bBj = 8,
		bBK = 9,
		bBk = 10,
		bBL = 11
	}

	internal enum Enum40
	{
		bBl,
		bBM,
		bBm
	}

	private Framework Bwm;

	private Framework BwN;

	private StateMachine Bwn;

	private Setting BwO;

	private Setting Bwo;

	private Setting BwP;

	private Setting Bwp;

	private List<Setting> BwQ = new List<Setting>();

	private int Bwq;

	private List<Label> BwR = new List<Label>();

	private List<Label> Bwr = new List<Label>();

	private List<ProgressBar> BwS = new List<ProgressBar>();

	private Image Bws;

	private PictureBox BwT = new PictureBox();

	private Size Bwt;

	private Label BwU = new Label();

	private Label Bwu = new Label();

	private Label BwV = new Label();

	private ThemedButton Bwv = new ThemedButton();

	private ThemedButton BwW = new ThemedButton();

	private Rectangle Bww;

	private bool BwX;

	private bool Bwx;

	private Stopwatch BwY = new Stopwatch();

	internal Class116(StateMachine stateMachine_0, Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false)
	{
		Bwm = framework_0;
		BwN = framework_1;
		Bwn = stateMachine_0;
		Bww = rectangle_0;
		BwX = Bwm.method_2() && Bwm.method_3() && Bwn.StatusChannelDataId != 0 && Bwm.method_31(Bwn.StatusChannelDataId).method_96();
		Bwx = BwN != null && BwN.method_2() && BwN.method_3() && Bwn.StatusChannelDataId != 0 && BwN.method_31(Bwn.StatusChannelDataId).method_96();
		bool flag = ((Form23.enum60_0 != Form23.Enum60.BpG || BwN == null) ? BwX : Bwx);
		if (Bwn.StatusChannelDataId != 0)
		{
			BwO = Bwm.method_31(Bwn.StatusChannelDataId);
			if (!flag)
			{
				BwO.method_264(method_25);
			}
		}
		if (Bwn.OutcomeErrorChannelDataId != 0)
		{
			Bwo = Bwm.method_31(Bwn.OutcomeErrorChannelDataId);
			if (!flag)
			{
				Bwo.method_264(method_28);
			}
		}
		if (Bwn.CurrentStageChannelDataId != 0)
		{
			BwP = Bwm.method_31(Bwn.CurrentStageChannelDataId);
		}
		if (Bwn.RequestStageChannelDataId != 0)
		{
			Bwp = Bwm.method_31(Bwn.RequestStageChannelDataId);
		}
		for (int i = 0; i < Bwn.StagesList.Count; i++)
		{
			StateMachineStage stateMachineStage = Bwn.StagesList[i];
			if (stateMachineStage.method_79() != 0)
			{
				Setting setting = Bwm.method_31(stateMachineStage.method_79());
				setting.method_264(method_29);
				BwQ.Add(setting);
			}
		}
		Form23.form23_0.method_9(method_15);
		Class1.smethod_12(method_30);
		Form23.smethod_30(method_30);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (BwO != null)
			{
				BwO.method_265(method_25);
			}
			if (Bwo != null)
			{
				Bwo.method_265(method_28);
			}
			for (int i = 0; i < Bwn.StagesList.Count; i++)
			{
				StateMachineStage stateMachineStage = Bwn.StagesList[i];
				if (stateMachineStage.method_79() != 0)
				{
					Bwm.method_31(stateMachineStage.method_79())?.method_265(method_29);
				}
			}
			Form23.form23_0.method_10(method_15);
			Class1.smethod_13(method_30);
			Form23.smethod_31(method_30);
			foreach (Control control in method_12().Controls)
			{
				if (control is Button)
				{
					(control as Button).Click -= Bwv_Click;
					(control as Button).Click -= BwW_Click;
				}
			}
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		method_12().Controls.Clear();
		method_17();
	}

	private Size method_16()
	{
		Size result = new Size(0, 0);
		for (int i = 0; i < Bwn.StagesList.Count; i++)
		{
			byte[] array = Class24.smethod_1(Bwn.StagesList[i].method_71());
			if (array != null)
			{
				Image image = Image.FromStream(new MemoryStream(array));
				if (image != null)
				{
					result.Width = Math.Max(result.Width, image.Width);
					result.Height = Math.Max(result.Height, image.Height);
					image.Dispose();
				}
			}
		}
		return result;
	}

	internal void method_17()
	{
		if (FindForm() is Form47 && !Bwn.method_35())
		{
			Width = 0;
			Height = 0;
			Visible = false;
			return;
		}
		SuspendLayout();
		method_12().SuspendLayout();
		int int_ = 5;
		int int_2 = 5;
		if ((Form23.enum60_0 != Form23.Enum60.BpG || BwN == null) ? BwX : Bwx)
		{
			Label label = new Label();
			label.Text = Class333.smethod_180() + Bwn.method_60(Enum96.aYt) + Class333.BAO();
			label.ForeColor = Form23.color_12;
			label.BackColor = Color.Transparent;
			label.AutoSize = true;
			label.Left = int_;
			label.Top = int_2;
			method_12().Controls.Add(label);
		}
		else
		{
			Bwq = 0;
			if (BwO != null)
			{
				for (int i = 0; i < Bwn.StagesList.Count; i++)
				{
					foreach (int item in Bwn.StagesList[i].method_76())
					{
						if (BwO.method_256() == item)
						{
							Bwq = i;
							break;
						}
					}
				}
			}
			else if (BwP != null)
			{
				if (Bwm.aWR)
				{
					Bwq = BwP.method_254(3);
				}
				else
				{
					Bwq = BwP.method_254(0);
				}
			}
			Bwt = method_16();
			method_18(ref int_, ref int_2);
			method_19(ref int_, ref int_2);
			method_21(ref int_, ref int_2);
			method_20(ref int_, ref int_2);
			method_22(ref int_, ref int_2);
			method_23(ref int_, ref int_2);
			method_24(ref int_, ref int_2);
		}
		if (Bww != Rectangle.Empty)
		{
			Width = Bww.Width;
			Height = Bww.Height;
			Left = Bww.Left;
			Top = Bww.Top;
		}
		else
		{
			int num = 0;
			int num2 = 0;
			foreach (Control control in method_12().Controls)
			{
				num = Math.Max(num, control.Right + 20);
				num2 = Math.Max(num2, control.Bottom + 50);
			}
			Width = num;
			Height = num2;
		}
		foreach (Control control2 in Controls)
		{
			control2.Enabled = Bwn.method_35() && Bwm.method_4();
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
	}

	private void method_18(ref int int_3, ref int int_4)
	{
		if (Bwo != null)
		{
			Label label = new Label();
			label.Font = new Font(label.Font.FontFamily, 8.25f, FontStyle.Bold);
			label.Text = Class333.smethod_944();
			label.ForeColor = Form23.color_12;
			label.Left = int_3;
			label.Top = int_4;
			label.Width = 160;
			label.Height = 16;
			method_12().Controls.Add(label);
			int_3 = label.Right + 10;
		}
	}

	private void method_19(ref int int_3, ref int int_4)
	{
		for (int i = 0; i < Bwn.StagesList.Count; i++)
		{
			StateMachineStage stateMachineStage = Bwn.StagesList[i];
			Label label = new Label();
			label.ForeColor = Form23.color_12;
			BwR.Add(label);
			if (i == Bwq)
			{
				label.Font = new Font(label.Font.FontFamily, 8.25f, FontStyle.Bold);
				label.Enabled = true;
			}
			else
			{
				label.Font = new Font(label.Font.FontFamily, 8.25f);
				if (Form23.enum62_0 == Form23.Enum62.BqG || Form23.enum62_0 == Form23.Enum62.Bqh)
				{
					label.Enabled = false;
				}
			}
			label.Text = string.Empty;
			if (stateMachineStage.method_73() != -1)
			{
				label.Text = string.Format(Class333.BgJ(), stateMachineStage.method_73() + 1);
			}
			label.Left = int_3;
			label.Top = int_4;
			label.Width = 80;
			label.Height = 16;
			method_12().Controls.Add(label);
			int_3 = label.Right + 10;
		}
		int_3 = 5;
		int_4 += 18;
	}

	private void method_20(ref int int_3, ref int int_4)
	{
		int num = 0;
		for (int i = 0; i < Bwn.StagesList.Count; i++)
		{
			StateMachineStage stateMachineStage = Bwn.StagesList[i];
			Label label = new Label();
			label.ForeColor = Form23.color_12;
			Bwr.Add(label);
			if (i == Bwq)
			{
				label.Font = new Font(label.Font.FontFamily, 8.25f, FontStyle.Bold);
				label.Enabled = true;
			}
			else
			{
				label.Font = new Font(label.Font.FontFamily, 8.25f);
				if (Form23.enum62_0 == Form23.Enum62.BqG || Form23.enum62_0 == Form23.Enum62.Bqh)
				{
					label.Enabled = false;
				}
			}
			label.Text = stateMachineStage.method_89();
			label.Left = int_3;
			label.Top = int_4;
			label.Width = 80;
			label.Height = 16;
			method_12().Controls.Add(label);
			if (stateMachineStage.method_79() != 0)
			{
				ProgressBar progressBar = new ProgressBar();
				BwS.Add(progressBar);
				Setting setting = BwQ[num];
				progressBar.Minimum = setting.method_226();
				progressBar.Maximum = setting.method_227();
				int val = setting.method_256();
				val = Math.Min(progressBar.Maximum, val);
				val = Math.Max(progressBar.Minimum, val);
				progressBar.Value = val;
				progressBar.Left = int_3;
				progressBar.Top = label.Bottom;
				progressBar.Width = 70;
				progressBar.Height = 10;
				method_12().Controls.Add(progressBar);
				num++;
			}
			int_3 = label.Right + 10;
		}
		int_3 = 5;
		int_4 += 18;
	}

	private void method_21(ref int int_3, ref int int_4)
	{
		if (Bwo == null)
		{
			return;
		}
		BwU.Left = int_3;
		BwU.Top = int_4;
		BwU.Width = 160;
		BwU.Height = 16;
		BwU.ForeColor = Form23.color_12;
		foreach (StateMachineError errors in Bwn.ErrorsList)
		{
			if (Bwo.method_256() == errors.method_71())
			{
				method_27(errors);
				method_12().Controls.Add(BwU);
				break;
			}
		}
		int_3 = BwU.Right + 10;
	}

	private void method_22(ref int int_3, ref int int_4)
	{
		byte[] array = Class24.smethod_1(Bwn.StagesList[Bwq].method_71());
		if (array != null)
		{
			Bws = Image.FromStream(new MemoryStream(array));
		}
		else
		{
			Bws = null;
		}
		BwT.Left = int_3;
		BwT.Top = int_4;
		if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
		{
			BwT.BackColor = SystemColors.Control;
		}
		if (Bws != null)
		{
			BwT.Width = Bws.Width;
			BwT.Height = Bws.Height;
			BwT.Image = Bws;
			BwT.Visible = true;
		}
		else
		{
			BwT.Image = null;
			BwT.Visible = false;
		}
		method_12().Controls.Add(BwT);
		int_4 += Bwt.Height + 10;
	}

	private void method_23(ref int int_3, ref int int_4)
	{
		BwW.Text = Class333.Bgj();
		BwW.Width = 100;
		BwW.Height = 25;
		BwW.Left = int_3 + ((Bwt.Width != 0) ? (Bwt.Width + 40) : 0);
		if (Bws != null)
		{
			int_4 = BwT.Top + Math.Max(Bwt.Height, BwT.Height) / 2 - 15;
		}
		BwW.Top = int_4;
		BwW.Enabled = Bwm.method_4() && (Form23.enum60_0 != Form23.Enum60.BpG || BwN == null);
		BwW.Click -= BwW_Click;
		BwW.Click += BwW_Click;
		method_12().Controls.Add(BwW);
		int_3 = BwW.Right + 10;
		Bwv.Text = Bwn.StagesList[Bwq].method_93();
		Bwv.Width = 100;
		Bwv.Height = 25;
		Bwv.Left = int_3;
		Bwv.Top = int_4;
		Bwv.Enabled = Bwm.method_4() && (Form23.enum60_0 != Form23.Enum60.BpG || BwN == null);
		Bwv.Click -= Bwv_Click;
		Bwv.Click += Bwv_Click;
		method_12().Controls.Add(Bwv);
		int_3 = 5;
		int_4 = BwT.Top + Math.Max(Bwt.Height, BwT.Height) + 5;
	}

	private void method_24(ref int int_3, ref int int_4)
	{
		Bwu.Font = new Font(Bwu.Font.FontFamily, 8.25f, FontStyle.Bold);
		Bwu.Text = string.Empty;
		Bwu.ForeColor = Form23.color_12;
		if (Bwn.StagesList[Bwq].method_73() != -1)
		{
			Bwu.Text = string.Format(Class333.BgK(), Bwn.StagesList[Bwq].method_73() + 1);
		}
		Bwu.Text += Bwn.StagesList[Bwq].method_89();
		Bwu.Left = int_3;
		Bwu.Top = int_4;
		Bwu.Width = Width - Bwu.Left - 20;
		method_12().Controls.Add(Bwu);
		int_4 = Bwu.Bottom;
		int num = Bwv.Right;
		if (BwS.Count != 0)
		{
			num = Math.Max(num, BwS[BwS.Count - 1].Right);
		}
		BwV.Text = Bwn.StagesList[Bwq].method_91();
		BwV.ForeColor = Form23.color_12;
		BwV.AutoSize = true;
		BwV.MinimumSize = new Size(0, 20);
		BwV.MaximumSize = new Size(num - 10, 100);
		BwV.Left = int_3;
		BwV.Top = int_4;
		BwV.Width = num - 10;
		method_12().Controls.Add(BwV);
	}

	private void method_25(object sender, EventArgs e)
	{
		for (int i = 0; i < Bwn.StagesList.Count; i++)
		{
			foreach (int item in Bwn.StagesList[i].method_76())
			{
				if (BwO.method_256() == item)
				{
					if (Bwq != i)
					{
						Bwq = i;
						method_26();
					}
					break;
				}
			}
		}
	}

	private void method_26()
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate74 method = method_26;
				Invoke(method);
				return;
			}
			catch
			{
				return;
			}
		}
		for (int i = 0; i < BwR.Count; i++)
		{
			Label label = BwR[i];
			if (i == Bwq)
			{
				label.Font = new Font(label.Font.FontFamily, 8.25f, FontStyle.Bold);
				label.Enabled = true;
			}
			else
			{
				label.Font = new Font(label.Font.FontFamily, 8.25f);
				label.Enabled = false;
			}
		}
		for (int j = 0; j < Bwr.Count; j++)
		{
			Label label2 = Bwr[j];
			if (j == Bwq)
			{
				label2.Font = new Font(label2.Font.FontFamily, 8.25f, FontStyle.Bold);
				label2.Enabled = true;
			}
			else
			{
				label2.Font = new Font(label2.Font.FontFamily, 8.25f);
				label2.Enabled = false;
			}
		}
		byte[] array = Class24.smethod_1(Bwn.StagesList[Bwq].method_71());
		if (array != null)
		{
			Bws = Image.FromStream(new MemoryStream(array));
			BwT.Width = Bws.Width;
			BwT.Height = Bws.Height;
			BwT.Image = Bws;
			BwT.Visible = true;
		}
		else
		{
			Bws = null;
			BwT.Image = null;
			BwT.Visible = false;
		}
		Bwu.Text = string.Empty;
		if (Bwn.StagesList[Bwq].method_73() != -1)
		{
			Bwu.Text = string.Format(Class333.BgK(), Bwn.StagesList[Bwq].method_73() + 1);
		}
		Bwu.Text += Bwn.StagesList[Bwq].method_89();
		Bwu.Width = Width - Bwu.Left - 20;
		BwV.Text = Bwn.StagesList[Bwq].method_91();
		Bwv.Text = Bwn.StagesList[Bwq].method_93();
	}

	private void method_27(StateMachineError stateMachineError_0)
	{
		BwU.Font = new Font(BwU.Font.FontFamily, 8.25f, FontStyle.Bold);
		string text;
		if (BwN == null)
		{
			BwU.Text = stateMachineError_0.method_73();
			text = stateMachineError_0.method_75();
			if (!(text == Class333.Bgk()))
			{
				if (!(text == Class333.BgL()))
				{
					if (text == Class333.Bgl())
					{
						BwU.ForeColor = Form23.color_7;
					}
				}
				else
				{
					BwU.ForeColor = Color.DarkOrange;
				}
			}
			else if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
			{
				BwU.ForeColor = Color.Green;
			}
			else
			{
				BwU.ForeColor = Color.DarkGreen;
			}
			return;
		}
		if (stateMachineError_0.method_75() == Class333.Bgk())
		{
			bool flag = true;
			if (Bwn.method_45() != null)
			{
				foreach (int item in Bwn.method_45().method_103())
				{
					Setting setting = Bwm.method_31(item);
					Setting setting2 = BwN.method_31(item);
					if (setting != null && setting2 != null && !setting.method_282(setting2))
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				BwU.Text = stateMachineError_0.method_73();
				if (Form23.enum62_0 != Form23.Enum62.BqG && Form23.enum62_0 != Form23.Enum62.Bqh)
				{
					BwU.ForeColor = Color.Green;
				}
				else
				{
					BwU.ForeColor = Color.DarkGreen;
				}
			}
			else
			{
				BwU.Text = Class333.BgM();
				BwU.ForeColor = Form23.color_9;
			}
			return;
		}
		BwU.Text = stateMachineError_0.method_73();
		text = stateMachineError_0.method_75();
		if (!(text == Class333.BgL()))
		{
			if (text == Class333.Bgl())
			{
				BwU.ForeColor = Form23.color_7;
			}
		}
		else
		{
			BwU.ForeColor = Color.DarkOrange;
		}
	}

	private void method_28(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate75 method = method_28;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		bool flag = false;
		foreach (StateMachineError errors in Bwn.ErrorsList)
		{
			if (Bwo.method_256() == errors.method_71())
			{
				method_27(errors);
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			method_12().Controls.Remove(BwU);
		}
		else if (!method_12().Controls.Contains(BwU))
		{
			method_12().Controls.Add(BwU);
		}
	}

	private void method_29(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate76 method = method_29;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		int num = 0;
		Setting setting;
		while (true)
		{
			if (num < BwQ.Count)
			{
				setting = BwQ[num];
				if (sender as Setting == setting && num < BwS.Count)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		int val = setting.method_256();
		val = Math.Min(BwS[num].Maximum, val);
		val = Math.Max(BwS[num].Minimum, val);
		BwS[num].Value = val;
	}

	private void method_30(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate77 method = method_30;
				BeginInvoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (!Form23.smethod_28(Bwm.aXc, bool_53: true) || Form23.smethod_80())
		{
			for (int i = 0; i < BwS.Count; i++)
			{
				BwS[i].Value = 0;
			}
		}
	}

	private void Bwv_Click(object sender, EventArgs e)
	{
		if (!Form23.smethod_28(Bwm.aXc, bool_53: true) || BwP == null || Bwp == null || !Bwm.method_4() || Bwq < 0 || Bwq >= Bwn.StagesList.Count)
		{
			return;
		}
		string text = Bwn.StagesList[Bwq].method_95();
		if (!string.IsNullOrEmpty(text) && Form54.smethod_6(Form23.form23_0, text, Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
		{
			return;
		}
		Bwv.Enabled = false;
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.DoWork += method_31;
		backgroundWorker.RunWorkerCompleted += method_32;
		bool flag = false;
		for (int i = 0; i < Bwn.StagesList.Count; i++)
		{
			if (Bwn.StagesList[i].method_83() != 0)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			backgroundWorker.RunWorkerAsync(Bwn.StagesList[Bwq].method_83());
		}
		else if (Bwm.aWR)
		{
			backgroundWorker.RunWorkerAsync((int)BwP.method_254(3));
		}
		else
		{
			backgroundWorker.RunWorkerAsync((int)BwP.method_254(0));
		}
	}

	private void method_31(object sender, DoWorkEventArgs e)
	{
		byte byte_ = (byte)(int)e.Argument;
		if (Bwm.aWR)
		{
			Bwp.method_270(0, 0, bool_0: true);
			Bwp.method_270(1, 0, bool_0: true);
			Bwp.method_270(2, 2, bool_0: true);
			Bwp.method_270(3, byte_, bool_0: true);
		}
		else
		{
			Bwp.method_270(3, 0, bool_0: true);
			Bwp.method_270(2, 0, bool_0: true);
			Bwp.method_270(1, 2, bool_0: true);
			Bwp.method_270(0, byte_, bool_0: true);
		}
		Thread.Sleep(100);
		BwY.Restart();
		do
		{
			if (BwP.method_254((!Bwm.aWR) ? 1 : 2) == byte.MaxValue)
			{
				continue;
			}
			Thread.Sleep(100);
			if (Bwm.aWR)
			{
				Bwp.method_270(0, 0, bool_0: true);
				Bwp.method_270(1, 0, bool_0: true);
				Bwp.method_270(2, 1, bool_0: true);
				Bwp.method_270(3, byte_, bool_0: true);
			}
			else
			{
				Bwp.method_270(3, 0, bool_0: true);
				Bwp.method_270(2, 0, bool_0: true);
				Bwp.method_270(1, 1, bool_0: true);
				Bwp.method_270(0, byte_, bool_0: true);
			}
			Thread.Sleep(100);
			BwY.Restart();
			do
			{
				if (BwP.method_254((!Bwm.aWR) ? 1 : 2) == byte.MaxValue)
				{
					continue;
				}
				if (BwO == null)
				{
					Thread.Sleep(200);
					if (Bwm.aWR)
					{
						Bwq = BwP.method_254(3);
					}
					else
					{
						Bwq = BwP.method_254(0);
					}
					method_26();
				}
				return;
			}
			while (BwY.ElapsedMilliseconds <= Bwn.StagesList[Bwq].method_81());
			if (BwO == null)
			{
				Bwq = 0;
				method_26();
			}
			return;
		}
		while (BwY.ElapsedMilliseconds <= Bwn.StagesList[Bwq].method_81());
		if (BwO == null)
		{
			Bwq = 0;
			method_26();
		}
	}

	private void method_32(object sender, RunWorkerCompletedEventArgs e)
	{
		Bwv.Enabled = Bwm.method_4();
		Bwm.method_71(0L);
	}

	private void BwW_Click(object sender, EventArgs e)
	{
		if (Form23.smethod_28(Bwm.aXc, bool_53: true) && BwP != null && Bwp != null && Bwm.method_4())
		{
			BwW.Enabled = false;
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += method_33;
			backgroundWorker.RunWorkerCompleted += method_34;
			backgroundWorker.RunWorkerAsync();
		}
	}

	private void method_33(object sender, DoWorkEventArgs e)
	{
		if (Bwm.aWR)
		{
			Bwp.method_270(0, 0, bool_0: true);
			Bwp.method_270(1, 0, bool_0: true);
			Bwp.method_270(2, 2, bool_0: true);
			Bwp.method_270(3, 0, bool_0: true);
		}
		else
		{
			Bwp.method_270(3, 0, bool_0: true);
			Bwp.method_270(2, 0, bool_0: true);
			Bwp.method_270(1, 2, bool_0: true);
			Bwp.method_270(0, 0, bool_0: true);
		}
		Thread.Sleep(100);
		BwY.Restart();
		do
		{
			if (BwP.method_254((!Bwm.aWR) ? 1 : 2) == byte.MaxValue)
			{
				continue;
			}
			Thread.Sleep(100);
			if (Bwm.aWR)
			{
				Bwp.method_270(0, 0, bool_0: true);
				Bwp.method_270(1, 0, bool_0: true);
				Bwp.method_270(2, 1, bool_0: true);
				Bwp.method_270(3, 0, bool_0: true);
			}
			else
			{
				Bwp.method_270(3, 0, bool_0: true);
				Bwp.method_270(2, 0, bool_0: true);
				Bwp.method_270(1, 1, bool_0: true);
				Bwp.method_270(0, 0, bool_0: true);
			}
			Thread.Sleep(100);
			BwY.Restart();
			do
			{
				if (BwP.method_254((!Bwm.aWR) ? 1 : 2) == byte.MaxValue)
				{
					continue;
				}
				if (BwO == null)
				{
					Thread.Sleep(200);
					if (Bwm.aWR)
					{
						Bwq = BwP.method_254(3);
					}
					else
					{
						Bwq = BwP.method_254(0);
					}
					method_26();
				}
				return;
			}
			while (BwY.ElapsedMilliseconds <= Bwn.StagesList[Bwq].method_81());
			if (BwO == null)
			{
				Bwq = 0;
				method_26();
			}
			return;
		}
		while (BwY.ElapsedMilliseconds <= Bwn.StagesList[Bwq].method_81());
		if (BwO == null)
		{
			Bwq = 0;
			method_26();
		}
	}

	private void method_34(object sender, RunWorkerCompletedEventArgs e)
	{
		BwW.Enabled = Bwm.method_4();
		Bwm.method_71(0L);
	}
}
