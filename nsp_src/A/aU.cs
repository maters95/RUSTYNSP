using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.Resources;
using NSP.SettingsFramework;

namespace a;

internal class aU : ToolStripButton
{
	private Image ka;

	private Image kB;

	private Image kb;

	private Image kC;

	private Image kc;

	private Image kD;

	private Image kd;

	private Image kE;

	private Image ke;

	private Image kF;

	private bool kf;

	private int kG;

	private Stopwatch kg = new Stopwatch();

	private bool kH;

	internal void A()
	{
		bool flag = false;
		if (((ToolStripItem)this).Image == ka)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (ka != null)
		{
			ka.Dispose();
		}
		ka = (Image)(object)O.A((Image)(object)GeneralResources.IconOffline, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f);
		if (flag)
		{
			((ToolStripItem)this).Image = ka;
		}
		flag = false;
		if (((ToolStripItem)this).Image == ke)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (ke != null)
		{
			ke.Dispose();
		}
		ke = (Image)(object)O.A((Image)(object)GeneralResources.IconOnlineUSB, 1f, 0f, 0f, 0f, 0f, 1f, 0.8f, 0f);
		if (flag)
		{
			((ToolStripItem)this).Image = ke;
		}
		flag = false;
		if (((ToolStripItem)this).Image == kF)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kF != null)
		{
			kF.Dispose();
		}
		kF = (Image)(object)O.A((Image)(object)GeneralResources.IconOnlineWiFi, 1f, 0f, 0f, 0f, 0f, 1f, 0.8f, 0f);
		if (flag)
		{
			((ToolStripItem)this).Image = kF;
		}
		flag = false;
		if (((ToolStripItem)this).Image == kB)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kB != null)
		{
			kB.Dispose();
		}
		kB = (Image)(object)O.A((Image)(object)GeneralResources.IconOffline, 1f, 0f, 0f, 0f, 0f, 0.376f, 0.376f, 1f);
		if (flag)
		{
			((ToolStripItem)this).Image = kB;
		}
		flag = false;
		if (((ToolStripItem)this).Image == kb)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kb != null)
		{
			kb.Dispose();
		}
		kb = (Image)(object)O.A((Image)(object)GeneralResources.IconOnlineUSB, 1f, 0f, 0f, 0f, 0f, 0f, 0.5f, 0f);
		if (flag)
		{
			((ToolStripItem)this).Image = kb;
		}
		flag = false;
		if (((ToolStripItem)this).Image == kD)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kD != null)
		{
			kD.Dispose();
		}
		kD = (Image)(object)O.A((Image)(object)GeneralResources.IconOnlineUSB, 1f, 0f, 0f, 0f, 0f, 0.376f, 0.376f, 1f);
		if (flag)
		{
			((ToolStripItem)this).Image = kD;
		}
		flag = false;
		if (((ToolStripItem)this).Image == kC)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kC != null)
		{
			kC.Dispose();
		}
		kC = (Image)(object)O.A((Image)(object)GeneralResources.IconOnlineUSBPower, 1f, 0f, 0f, 0f, 0f, 1f, 0.8f, 0f);
		if (flag)
		{
			((ToolStripItem)this).Image = kC;
		}
		flag = false;
		if (((ToolStripItem)this).Image == kd)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kd != null)
		{
			kd.Dispose();
		}
		kd = (Image)(object)O.A((Image)(object)GeneralResources.IconOnlineUSBPower, 1f, 0f, 0f, 0f, 0f, 0.376f, 0.376f, 1f);
		if (flag)
		{
			((ToolStripItem)this).Image = kd;
		}
		flag = false;
		if (((ToolStripItem)this).Image == kc)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kc != null)
		{
			kc.Dispose();
		}
		kc = (Image)(object)O.A((Image)(object)GeneralResources.IconOnlineWiFi, 1f, 0f, 0f, 0f, 0f, 0f, 0.5f, 0f);
		if (flag)
		{
			((ToolStripItem)this).Image = kc;
		}
		flag = false;
		if (((ToolStripItem)this).Image == kE)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kE != null)
		{
			kE.Dispose();
		}
		kE = (Image)(object)O.A((Image)(object)GeneralResources.IconOnlineWiFi, 1f, 0f, 0f, 0f, 0f, 0.376f, 0.376f, 1f);
		if (flag)
		{
			((ToolStripItem)this).Image = kE;
		}
	}

	internal void a()
	{
		if (((ToolStripItem)this).Image != ka)
		{
			((ToolStripItem)this).Image = ka;
		}
		((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gG();
		((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
	}

	internal void B()
	{
		if (((ToolStripItem)this).Image != kB)
		{
			((ToolStripItem)this).Image = kB;
		}
		((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gg();
		((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
	}

	internal void b()
	{
		if (((ToolStripItem)this).Image != kC)
		{
			((ToolStripItem)this).Image = kC;
		}
		((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gH();
		((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
	}

	internal void C()
	{
		if (((ToolStripItem)this).Image != kd)
		{
			((ToolStripItem)this).Image = kd;
		}
		((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gh();
		((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
	}

	internal void c()
	{
		if (((ToolStripItem)this).Image != kD)
		{
			((ToolStripItem)this).Image = kD;
		}
		((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gI();
		((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
	}

	internal void D()
	{
		if (((ToolStripItem)this).Image != kb)
		{
			((ToolStripItem)this).Image = kb;
		}
		((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gi();
		((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
	}

	internal void d()
	{
		if (((ToolStripItem)this).Image != ke)
		{
			((ToolStripItem)this).Image = ke;
		}
		((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gJ();
		((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
	}

	internal void E()
	{
		if (((ToolStripItem)this).Image != kE)
		{
			((ToolStripItem)this).Image = kE;
		}
		((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gj();
		((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
	}

	internal void e()
	{
		if (((ToolStripItem)this).Image != kc)
		{
			((ToolStripItem)this).Image = kc;
		}
		((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gK();
		((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
	}

	internal void F()
	{
		if (((ToolStripItem)this).Image != kF)
		{
			((ToolStripItem)this).Image = kF;
		}
		((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gk();
		((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
	}

	[SpecialName]
	internal void A(bool P_0)
	{
		bool flag = P_0;
		if (flag && !kH)
		{
			kg.Restart();
		}
		kH = flag;
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((ToolStripItem)this).OnMouseEnter(e);
		kf = true;
		((ToolStripItem)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((ToolStripItem)this).OnMouseLeave(e);
		kf = false;
		((ToolStripItem)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected O, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		((ToolStripButton)this).OnPaint(e);
		Color val2;
		if (kf)
		{
			Rectangle val = default(Rectangle);
			((Rectangle)(ref val))._002Ector(0, 0, ((ToolStripItem)this).Width, ((ToolStripItem)this).Height);
			val2 = Color.FromArgb(194, 224, 255);
			SolidBrush val3 = new SolidBrush(val2);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val3, val);
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
			Pen val4 = new Pen(Color.FromArgb(51, 153, 255), 2f);
			try
			{
				e.Graphics.DrawRectangle(val4, val);
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
		}
		else
		{
			val2 = ((ToolStripItem)this).BackColor;
			SolidBrush val5 = new SolidBrush(((ToolStripItem)this).BackColor);
			try
			{
				Rectangle val6 = default(Rectangle);
				((Rectangle)(ref val6))._002Ector(0, 0, ((ToolStripItem)this).Width, ((ToolStripItem)this).Height);
				e.Graphics.FillRectangle((Brush)(object)val5, val6);
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
		}
		if (((ToolStripItem)this).Image != null)
		{
			e.Graphics.SmoothingMode = (SmoothingMode)2;
			GraphicsUnit val7 = (GraphicsUnit)2;
			Rectangle val8 = default(Rectangle);
			((Rectangle)(ref val8))._002Ector(0, 0, ((ToolStripItem)this).Width, ((ToolStripItem)this).Height);
			e.Graphics.DrawImage(((ToolStripItem)this).Image, RectangleF.op_Implicit(val8), ((ToolStripItem)this).Image.GetBounds(ref val7), (GraphicsUnit)2);
		}
		int num = 17;
		int num2 = 22;
		Rectangle val9 = default(Rectangle);
		((Rectangle)(ref val9))._002Ector(14, 18, 70, num);
		bool flag = ((uint)BM.qI & 8u) != 0 || ((uint)BM.qI & 0x10u) != 0 || (BM.SF.IsRunning && BM.SF.ElapsedMilliseconds < 500);
		if ((BM.qI & 4) == 0 && !flag)
		{
			kG = 0;
		}
		else if (kG >= ((Rectangle)(ref val9)).Width - num2)
		{
			kG = 0;
		}
		else
		{
			kG += 8;
		}
		if (flag)
		{
			int num3 = ((Rectangle)(ref val9)).Left + kG;
			Point[] array = (Point[])(object)new Point[7]
			{
				new Point(num3 + 10, ((Rectangle)(ref val9)).Top),
				new Point(num3 + num2, ((Rectangle)(ref val9)).Top + num / 2),
				new Point(num3 + 10, ((Rectangle)(ref val9)).Bottom),
				new Point(num3 + 10, ((Rectangle)(ref val9)).Bottom - 4),
				new Point(num3, ((Rectangle)(ref val9)).Bottom - 4),
				new Point(num3, ((Rectangle)(ref val9)).Top + 4),
				new Point(num3 + 10, ((Rectangle)(ref val9)).Top + 4)
			};
			e.Graphics.FillPolygon(Brushes.DodgerBlue, array);
			e.Graphics.DrawPolygon(Pens.LightGray, array);
		}
		else if (((uint)BM.qI & 0x20u) != 0)
		{
			int num4 = ((Rectangle)(ref val9)).Right - kG;
			Point[] array2 = (Point[])(object)new Point[7]
			{
				new Point(num4 - 10, ((Rectangle)(ref val9)).Top),
				new Point(num4 - num2, ((Rectangle)(ref val9)).Top + num / 2),
				new Point(num4 - 10, ((Rectangle)(ref val9)).Bottom),
				new Point(num4 - 10, ((Rectangle)(ref val9)).Bottom - 4),
				new Point(num4, ((Rectangle)(ref val9)).Bottom - 4),
				new Point(num4, ((Rectangle)(ref val9)).Top + 4),
				new Point(num4 - 10, ((Rectangle)(ref val9)).Top + 4)
			};
			e.Graphics.FillPolygon(Brushes.DodgerBlue, array2);
			e.Graphics.DrawPolygon(Pens.LightGray, array2);
		}
		else if (kH)
		{
			Rectangle val10 = default(Rectangle);
			((Rectangle)(ref val10))._002Ector(((ToolStripItem)this).Width / 2 - 14, ((ToolStripItem)this).Height / 2 - 16, 30, 31);
			SolidBrush val11 = new SolidBrush(val2);
			try
			{
				e.Graphics.FillEllipse((Brush)(object)val11, val10);
			}
			finally
			{
				((System.IDisposable)val11)?.Dispose();
			}
			if (kg.IsRunning && kg.ElapsedMilliseconds < 4000)
			{
				Pen val12 = new Pen(Color.DodgerBlue, 3f);
				try
				{
					e.Graphics.DrawArc(val12, val10, (float)(kg.ElapsedMilliseconds * 360 / 1000), 315f);
					return;
				}
				finally
				{
					((System.IDisposable)val12)?.Dispose();
				}
			}
			Font val13 = new Font(((ToolStripItem)this).Font.FontFamily, 7f, (FontStyle)0);
			try
			{
				SolidBrush val14 = new SolidBrush(BM.te);
				try
				{
					StringFormat val15 = new StringFormat();
					try
					{
						val15.Alignment = (StringAlignment)1;
						val15.LineAlignment = (StringAlignment)1;
						int num5 = ((ToolStripItem)this).Width / 2 + 2;
						e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gL(), val13, (Brush)(object)val14, (float)num5, (float)(((ToolStripItem)this).Height / 2 - 8), val15);
						e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gl(), val13, (Brush)(object)val14, (float)num5, (float)(((ToolStripItem)this).Height / 2), val15);
						e.Graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gM(), val13, (Brush)(object)val14, (float)num5, (float)(((ToolStripItem)this).Height / 2 + 8), val15);
					}
					finally
					{
						((System.IDisposable)val15)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val14)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val13)?.Dispose();
			}
			if (kg.IsRunning)
			{
				kg.Stop();
			}
		}
		else if (kg.IsRunning)
		{
			kg.Stop();
		}
	}
}
internal class au : ToolStripButton
{
	private Image kh;

	private Image kI;

	private Stopwatch ki = new Stopwatch();

	private Timer kJ;

	private const int kj = 2000;

	private const int kK = 500;

	internal void A()
	{
		bool flag = false;
		if (((ToolStripItem)this).Image == kh)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kh != null)
		{
			kh.Dispose();
		}
		kh = (Image)(object)O.A((Image)(object)GeneralResources.IconRebootECU, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (flag)
		{
			((ToolStripItem)this).Image = kh;
		}
		flag = false;
		if (((ToolStripItem)this).Image == kI)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (kI != null)
		{
			kI.Dispose();
		}
		kI = (Image)(object)O.A((Image)(object)GeneralResources.IconRebootECU, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f);
		if (flag)
		{
			((ToolStripItem)this).Image = kI;
		}
	}

	internal void a()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		ki.Reset();
		if (kJ != null)
		{
			kJ.Tick -= new EventHandler(A);
			kJ.Stop();
			((Component)kJ).Dispose();
			kJ = null;
		}
		((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
		if (((ToolStripItem)this).Image != kh)
		{
			((ToolStripItem)this).Image = kh;
		}
		((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gm();
		((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
	}

	internal void B()
	{
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (BM.Qz != null)
		{
			Setting setting = BM.Qz.A(13);
			if (setting != null && setting.ax() == 1)
			{
				flag = true;
			}
		}
		if (flag)
		{
			if (ki.IsRunning)
			{
				if (ki.ElapsedMilliseconds >= 2000)
				{
					if (kJ == null || !kJ.Enabled)
					{
						ki.Restart();
						((ToolStripItem)this).BackColor = Color.FromArgb(200, 0, 0);
					}
					else
					{
						((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
					}
				}
				else
				{
					float num = 1f - (float)(int)ki.ElapsedMilliseconds / 2000f;
					Color backColor = BM.QQ.RG.BackColor;
					int r = ((Color)(ref backColor)).R;
					backColor = BM.QQ.RG.BackColor;
					int g = ((Color)(ref backColor)).G;
					backColor = BM.QQ.RG.BackColor;
					int b = ((Color)(ref backColor)).B;
					Color backColor2 = Color.FromArgb(r + (int)(num * (float)(200 - r)), g - (int)(num * (float)g), b - (int)(num * (float)b));
					((ToolStripItem)this).BackColor = backColor2;
				}
				if (kJ == null)
				{
					kJ = new Timer();
					kJ.Interval = 500;
					kJ.Tick += new EventHandler(A);
					kJ.Start();
				}
			}
			else
			{
				ki.Restart();
				((ToolStripItem)this).BackColor = Color.FromArgb(200, 0, 0);
			}
			((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gN();
			((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
		}
		else
		{
			a();
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		if (((ToolStripItem)this).Image != kh)
		{
			((ToolStripItem)this).Image = kh;
		}
		else
		{
			((ToolStripItem)this).Image = kI;
		}
	}
}
