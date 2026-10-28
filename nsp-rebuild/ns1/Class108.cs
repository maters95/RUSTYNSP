using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns3;
using ns4;
using ns6;
using ns7;

namespace ns1;

internal class Class108 : MovableResizablePanel
{
	private delegate void Delegate20(object sender, EventArgs e);

	private Framework BLg;

	private Rectangle BLH = Rectangle.Empty;

	private const int BLh = 40;

	private const int BLI = 10;

	private const int BLi = 20;

	private const int BLJ = 20;

	private const int BLj = 250;

	private const int BLK = 100;

	private bool BLk = true;

	private double BLL = 1.0;

	private bool BLl;

	private Class81 BLM;

	private Class248 BLm;

	private PictureBox BLN;

	private System.Timers.Timer BLn = new System.Timers.Timer();

	internal Class108(Framework framework_0, Rectangle rectangle_0, bool bool_0, SettingOrSpecialObject settingOrSpecialObject_0, bool bool_1 = false)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: false)
	{
		BLg = framework_0;
		BLH = rectangle_0;
		if (BLH != Rectangle.Empty)
		{
			Width = BLH.Width;
			Height = BLH.Height;
			Left = BLH.Left;
			Top = BLH.Top;
		}
		BLl = bool_1;
		if (!bool_1 && settingOrSpecialObject_0 is Class248)
		{
			BLm = settingOrSpecialObject_0 as Class248;
			if (BLm.method_75() != null)
			{
				BLm.method_75().method_264(method_17);
			}
			int count = BLg.awq.Count;
			int int_ = 0;
			if (BLm != null && BLm.method_75() != null)
			{
				int_ = BLm.method_75().method_256();
			}
			BLM = new Class81(count, BLm.method_73().method_256(), BLm.method_74().method_256(), int_);
			method_14();
			method_12();
			Refresh();
			return;
		}
		throw new Exception(Class333.BBy());
	}

	private void method_12()
	{
		BLn.Interval = 250.0;
		BLn.SynchronizingObject = this;
		BLn.Elapsed += BLn_Elapsed;
		BLn.AutoReset = true;
		BLn.Enabled = true;
		BLn.Start();
	}

	private void BLn_Elapsed(object sender, ElapsedEventArgs e)
	{
		BLk = !BLk;
		if (!BLl)
		{
			BLM.method_3(BLm.method_74().method_256() == 1);
			for (int i = 0; i < BLM.method_0(); i++)
			{
				BLM.method_9(i, BLm.method_73().method_256());
			}
		}
		Refresh();
	}

	internal void method_13(double double_0)
	{
		if (BLL != double_0)
		{
			BLL = double_0;
			method_14();
		}
	}

	private void method_14()
	{
		while (Controls.Count != 0)
		{
			Class30.smethod_0(Controls[0]);
		}
		Width = (int)Math.Round((double)(20 + BLg.awq.Count * 60 + 20 - 20) * BLL) + 2;
		Height = 20;
		for (int i = 0; i < BLg.awq.Count; i++)
		{
			PictureBox pictureBox = new PictureBox();
			pictureBox.Width = (int)Math.Round(45.0 * BLL);
			pictureBox.Height = 10;
			pictureBox.Top = 5;
			pictureBox.Left = (int)Math.Round((double)(20 + i * 60) * BLL);
			Controls.Add(pictureBox);
			pictureBox.Name = i.ToString();
			pictureBox.Paint += method_18;
			if (!BLl)
			{
				pictureBox.MouseUp += method_16;
			}
			BLN = pictureBox;
		}
		Label label = new Label();
		label.Name = Class333.BBZ();
		label.ForeColor = Form23.color_12;
		label.AutoSize = true;
		if (BLm != null)
		{
			label.Text = Class333.BBz();
		}
		else if (BLl)
		{
			label.Text = Class333.BbA();
		}
		label.Left = BLg.awq.Count * 60 + 20;
		Controls.Add(label);
		Refresh();
	}

	private void method_15()
	{
		if (BLm != null && BLm.method_75() != null)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_1();
			BLm.method_75().method_272(BLM.method_7(), bool_0: true);
			@class?.method_4();
		}
	}

	private void method_16(object sender, MouseEventArgs e)
	{
		int index = int.Parse((sender as PictureBox).Name);
		BLM.method_6(index, !BLM.method_4()[index]);
		method_15();
		Refresh();
	}

	private void method_17(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate20 method = method_17;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		int count = BLg.awq.Count;
		int num = BLm.method_75().method_256();
		for (int i = 0; i < count; i++)
		{
			BLM.method_6(i, (num & (1 << i)) > 0);
		}
		Refresh();
	}

	private void method_18(object sender, PaintEventArgs e)
	{
		int index = int.Parse((sender as PictureBox).Name);
		Rectangle rect = new Rectangle(0, 0, 40, 10);
		using SolidBrush brush = new SolidBrush((!BLM.method_4()[index] || (BLM.method_2() && BLk)) ? Class80.smethod_0(0) : BLM.method_1()[index]);
		e.Graphics.FillRectangle(brush, rect);
	}

	internal void method_19()
	{
		for (int i = 0; i < BLg.awq.Count; i++)
		{
			BLg.awq[i].method_72().method_272(0, bool_0: false);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (BLn != null)
		{
			BLn.Elapsed -= BLn_Elapsed;
			BLn.Stop();
			BLn.Close();
			BLn = null;
		}
		if (BLN != null)
		{
			BLN.Paint -= method_18;
			if (!BLl)
			{
				BLN.MouseUp -= method_16;
			}
		}
		if (BLm != null && BLm.method_75() != null)
		{
			BLm.method_75().method_265(method_17);
		}
		base.Dispose(disposing);
	}
}
