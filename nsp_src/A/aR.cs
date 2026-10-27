using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.Resources;

namespace a;

internal class aR : Control
{
	internal const int Kd = 18;

	private int KE;

	private int Ke = 10;

	private int KF = 1;

	private int Kf;

	private int KG = 100;

	private int Kg;

	private int KH;

	private int Kh;

	private int KI;

	private bool Ki;

	private bool KJ;

	private bool Kj;

	private bool KK;

	private bool Kk;

	private bool KL;

	private bool Kl;

	[CompilerGenerated]
	private EventHandler KM;

	private IContainer Km;

	[SpecialName]
	[CompilerGenerated]
	internal void A(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = KM;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref KM, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = KM;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref KM, val3, val2);
		}
		while (val != val2);
	}

	internal aR()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		D();
		((Control)this).SuspendLayout();
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ga();
		((Control)this).MouseDown += new MouseEventHandler(A);
		((Control)this).MouseMove += new MouseEventHandler(B);
		((Control)this).MouseUp += new MouseEventHandler(a);
		((Control)this).MouseLeave += new EventHandler(A);
		((Control)this).ResumeLayout(false);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)65536, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).Width = 18;
		KE = ((Control)this).Width;
		((Control)this).MinimumSize = new Size(KE, KE + KE + c());
	}

	[SpecialName]
	internal int A()
	{
		return Ke;
	}

	[SpecialName]
	internal void A(int P_0)
	{
		Ke = P_0;
		((Control)this).Invalidate();
	}

	[SpecialName]
	internal int a()
	{
		return KF;
	}

	[SpecialName]
	internal void a(int P_0)
	{
		KF = P_0;
		((Control)this).Invalidate();
	}

	[SpecialName]
	internal int B()
	{
		return Kf;
	}

	[SpecialName]
	internal void B(int P_0)
	{
		Kf = P_0;
		((Control)this).Invalidate();
	}

	[SpecialName]
	internal int b()
	{
		return KG;
	}

	[SpecialName]
	internal void b(int P_0)
	{
		KG = P_0;
		((Control)this).Invalidate();
	}

	[SpecialName]
	internal int C()
	{
		return Kg;
	}

	[SpecialName]
	internal void C(int P_0)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		Kg = P_0;
		int num = ((Control)this).Height - 2 * KE - c();
		int num2 = b() - B() - A();
		float num3 = 0f;
		if (num2 != 0)
		{
			num3 = (float)Kg / (float)num2;
		}
		float num4 = num3 * (float)num;
		KI = Math.Max((int)num4, 0);
		if (KI > num)
		{
			KI = num;
			num3 = (float)KI / (float)num;
			Kg = (int)(num3 * (float)(b() - A()));
			if (KM != null)
			{
				KM.Invoke((object)this, new EventArgs());
			}
		}
		((Control)this).Invalidate();
	}

	private int c()
	{
		int num = 10;
		if (b() == 0)
		{
			return num;
		}
		int num2 = ((Control)this).Height - 2 * KE;
		float num3 = (float)A() * (float)num2 / (float)b();
		return Convert.ToInt32(Math.Min((float)num2, Math.Max(num3, (float)num)));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		e.Graphics.SmoothingMode = (SmoothingMode)2;
		SolidBrush val = new SolidBrush(BM.tl);
		try
		{
			e.Graphics.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).Width, ((Control)this).Height);
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
		Point[] array = (Point[])(object)new Point[3]
		{
			new Point(KE / 2 - 1, KE / 4),
			new Point(KE / 5 - 1, KE * 5 / 8),
			new Point(KE * 4 / 5 - 1, KE * 5 / 8)
		};
		if (Kj)
		{
			SolidBrush val2 = new SolidBrush(BM.tN);
			try
			{
				e.Graphics.FillPolygon((Brush)(object)val2, array);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
		else if (KL)
		{
			SolidBrush val3 = new SolidBrush(BM.tm);
			try
			{
				e.Graphics.FillPolygon((Brush)(object)val3, array);
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		else
		{
			SolidBrush val4 = new SolidBrush(BM.tM);
			try
			{
				e.Graphics.FillPolygon((Brush)(object)val4, array);
			}
			finally
			{
				((System.IDisposable)val4)?.Dispose();
			}
		}
		Point[] array2 = (Point[])(object)new Point[3]
		{
			new Point(KE / 2 - 1, ((Control)this).Height - KE + KE * 3 / 4),
			new Point(KE / 5 - 1, ((Control)this).Height - KE + KE * 3 / 8),
			new Point(KE * 4 / 5 - 1, ((Control)this).Height - KE + KE * 3 / 8)
		};
		if (KK)
		{
			SolidBrush val5 = new SolidBrush(BM.tN);
			try
			{
				e.Graphics.FillPolygon((Brush)(object)val5, array2);
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
		}
		else if (Kl)
		{
			SolidBrush val6 = new SolidBrush(BM.tm);
			try
			{
				e.Graphics.FillPolygon((Brush)(object)val6, array2);
			}
			finally
			{
				((System.IDisposable)val6)?.Dispose();
			}
		}
		else
		{
			SolidBrush val7 = new SolidBrush(BM.tM);
			try
			{
				e.Graphics.FillPolygon((Brush)(object)val7, array2);
			}
			finally
			{
				((System.IDisposable)val7)?.Dispose();
			}
		}
		int num = c();
		if (KE + KI + num > ((Control)this).Height - KE)
		{
			num = ((Control)this).Height - KE - (KE + KI);
		}
		if (Ki)
		{
			SolidBrush val8 = new SolidBrush(BM.tN);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val8, 3, KE + KI, ((Control)this).Width - 8, num);
				return;
			}
			finally
			{
				((System.IDisposable)val8)?.Dispose();
			}
		}
		if (Kk)
		{
			SolidBrush val9 = new SolidBrush(BM.tm);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val9, 3, KE + KI, ((Control)this).Width - 8, num);
				return;
			}
			finally
			{
				((System.IDisposable)val9)?.Dispose();
			}
		}
		SolidBrush val10 = new SolidBrush(BM.tM);
		try
		{
			e.Graphics.FillRectangle((Brush)(object)val10, 3, KE + KI, ((Control)this).Width - 8, num);
		}
		finally
		{
			((System.IDisposable)val10)?.Dispose();
		}
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		Kk = false;
		KL = false;
		Kl = false;
		int num = c();
		int num2 = ((Control)this).Height - 2 * KE;
		Point val = ((Control)this).PointToClient(Cursor.Position);
		Rectangle val2 = default(Rectangle);
		((Rectangle)(ref val2))._002Ector(new Point(0, KE + KI), new Size(((Control)this).Width, num));
		if (((Rectangle)(ref val2)).Contains(val))
		{
			KH = ((Point)(ref val)).Y;
			Kh = KI;
			Ki = true;
			((Control)this).Invalidate();
			return;
		}
		Rectangle val3 = default(Rectangle);
		((Rectangle)(ref val3))._002Ector(new Point(0, 0), new Size(KE, KE));
		if (((Rectangle)(ref val3)).Contains(val))
		{
			Kj = true;
			int num3 = b() - B() - A();
			int num4 = num2 - num;
			if (num3 > 0 && num4 > 0)
			{
				if (KI - a() < 0)
				{
					KI = 0;
				}
				else
				{
					KI -= a();
				}
				KI = Math.Max(KI, 0);
				float num5 = (float)KI / (float)num4 * (float)(b() - A());
				Kg = (int)num5;
				if (KM != null)
				{
					KM.Invoke((object)this, new EventArgs());
				}
				((Control)this).Invalidate();
			}
			return;
		}
		Rectangle val4 = default(Rectangle);
		((Rectangle)(ref val4))._002Ector(new Point(0, KE + num2), new Size(KE, KE));
		if (((Rectangle)(ref val4)).Contains(val))
		{
			KK = true;
			int num6 = b() - B() - A();
			int num7 = num2 - num;
			if (num6 > 0 && num7 > 0)
			{
				if (KI + a() > num7)
				{
					KI = num7;
				}
				else
				{
					KI += a();
				}
				KI = Math.Max(KI, 0);
				float num8 = (float)KI / (float)num7 * (float)(b() - A());
				Kg = (int)num8;
				if (KM != null)
				{
					KM.Invoke((object)this, new EventArgs());
				}
				((Control)this).Invalidate();
			}
			return;
		}
		Rectangle val5 = default(Rectangle);
		((Rectangle)(ref val5))._002Ector(new Point(0, KE), new Size(KE, ((Rectangle)(ref val2)).Top - KE));
		if (((Rectangle)(ref val5)).Contains(val))
		{
			int num9 = b() - B() - A();
			int num10 = num2 - num;
			if (num9 > 0 && num10 > 0)
			{
				if (KI - A() < 0)
				{
					KI = 0;
				}
				else
				{
					KI -= A();
				}
				KI = Math.Max(KI, 0);
				float num11 = (float)KI / (float)num10 * (float)(b() - A());
				Kg = (int)num11;
				if (KM != null)
				{
					KM.Invoke((object)this, new EventArgs());
				}
				((Control)this).Invalidate();
			}
			return;
		}
		Rectangle val6 = default(Rectangle);
		((Rectangle)(ref val6))._002Ector(new Point(0, ((Rectangle)(ref val2)).Bottom), new Size(KE, ((Rectangle)(ref val4)).Top - ((Rectangle)(ref val2)).Bottom));
		if (!((Rectangle)(ref val6)).Contains(val))
		{
			return;
		}
		int num12 = b() - B() - A();
		int num13 = num2 - num;
		if (num12 > 0 && num13 > 0)
		{
			if (KI + A() > num13)
			{
				KI = num13;
			}
			else
			{
				KI += A();
			}
			KI = Math.Max(KI, 0);
			float num14 = (float)KI / (float)num13 * (float)(b() - A());
			Kg = (int)num14;
			if (KM != null)
			{
				KM.Invoke((object)this, new EventArgs());
			}
			((Control)this).Invalidate();
		}
	}

	private void a(object P_0, MouseEventArgs P_1)
	{
		Ki = false;
		KJ = false;
		Kj = false;
		KK = false;
		((Control)this).Invalidate();
	}

	private void A(object P_0, EventArgs P_1)
	{
		Ki = false;
		KJ = false;
		Kj = false;
		KK = false;
		Kk = false;
		KL = false;
		Kl = false;
		((Control)this).Invalidate();
	}

	private void B(object P_0, MouseEventArgs P_1)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		if (Ki)
		{
			KJ = true;
		}
		if (KJ)
		{
			int num = P_1.Y - KH;
			int num2 = c();
			int num3 = ((Control)this).Height - 2 * KE;
			int num4 = b() - B();
			int num5 = num3 - num2;
			if (Ki && num4 > 0 && num5 > 0)
			{
				int kI = KI;
				int num6 = Kh + num;
				if (num6 < 0)
				{
					KI = 0;
				}
				else if (num6 > num5)
				{
					KI = num5;
				}
				else
				{
					KI = num6;
				}
				KI = Math.Max(KI, 0);
				float num7 = (float)KI / (float)num5 * (float)(b() - A());
				Kg = (int)num7;
				if (KI != kI && KM != null)
				{
					KM.Invoke((object)this, new EventArgs());
				}
				((Control)this).Invalidate();
			}
			return;
		}
		int num8 = c();
		int num9 = ((Control)this).Height - 2 * KE;
		Point val = ((Control)this).PointToClient(Cursor.Position);
		Rectangle val2 = default(Rectangle);
		((Rectangle)(ref val2))._002Ector(new Point(0, KE + KI), new Size(((Control)this).Width, num8));
		Rectangle val3 = default(Rectangle);
		((Rectangle)(ref val3))._002Ector(new Point(0, 0), new Size(KE, KE));
		Rectangle val4 = default(Rectangle);
		((Rectangle)(ref val4))._002Ector(new Point(0, KE + num9), new Size(KE, KE));
		if (((Rectangle)(ref val2)).Contains(val))
		{
			Kk = true;
			KL = false;
			Kl = false;
		}
		else if (((Rectangle)(ref val3)).Contains(val))
		{
			Kk = false;
			KL = true;
			Kl = false;
		}
		else if (((Rectangle)(ref val4)).Contains(val))
		{
			Kk = false;
			KL = false;
			Kl = true;
		}
		else
		{
			Kk = false;
			KL = false;
			Kl = false;
		}
		((Control)this).Invalidate();
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		((Control)this).MouseDown -= new MouseEventHandler(A);
		((Control)this).MouseMove -= new MouseEventHandler(B);
		((Control)this).MouseUp -= new MouseEventHandler(a);
		((Control)this).MouseLeave -= new EventHandler(A);
		if (disposing && Km != null)
		{
			((System.IDisposable)Km).Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	private void D()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		Km = (IContainer)new Container();
	}
}
internal class ar : ToolStripButton
{
	internal enum A
	{
		Bnl,
		BnM,
		Bnm,
		BnN
	}

	private const int KN = 2000;

	private const int Kn = 15;

	private const int KO = 10;

	private const double Ko = 0.8;

	private A KP;

	private int Kp;

	private string KQ = string.Empty;

	private string Kq = string.Empty;

	private int KR = -90;

	private int Kr = 315;

	private Timer KS;

	private Image Ks;

	private Image KT;

	private Stopwatch Kt = new Stopwatch();

	internal ar()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		((ToolStripItem)this).Image = Ks;
	}

	[SpecialName]
	internal int A()
	{
		return (int)((double)(((ToolStripItem)this).Height - 15) * 0.8);
	}

	internal void a()
	{
		int kR = ((KR + 10 < 360) ? (KR + 10) : (360 - (KR + 10)));
		KR = kR;
	}

	private void B()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (KS == null)
		{
			KS = new Timer();
		}
		KS.Interval = 20;
		KS.Tick += new EventHandler(A);
		KS.Start();
	}

	private void b()
	{
		if (KS != null)
		{
			KS.Stop();
			((Component)KS).Dispose();
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		((ToolStripItem)this).Invalidate();
	}

	internal void C()
	{
		bool flag = false;
		if (((ToolStripItem)this).Image == Ks)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (Ks != null)
		{
			Ks.Dispose();
		}
		Ks = (Image)(object)O.A((Image)(object)GeneralResources.IconSWUpdate, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
		if (flag)
		{
			((ToolStripItem)this).Image = Ks;
		}
		flag = false;
		if (((ToolStripItem)this).Image == KT)
		{
			((ToolStripItem)this).Image = null;
			flag = true;
		}
		if (KT != null)
		{
			KT.Dispose();
		}
		KT = (Image)(object)O.A((Image)(object)GeneralResources.IconSWUpdate, 1f, 0f, 0f, 0f, 0f, 0f, 0.5f, 0f);
		if (flag)
		{
			((ToolStripItem)this).Image = KT;
		}
	}

	internal void c()
	{
		((ToolStripItem)this).Image = Ks;
	}

	internal void D()
	{
		if (((ToolStripItem)this).Image != Ks)
		{
			((ToolStripItem)this).Image = Ks;
		}
		Kt.Reset();
		((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gB();
		((ToolStripItem)this).ToolTipText = ((ToolStripItem)this).Text;
	}

	internal void A(A P_0, int P_1, string P_2, string P_3)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		b();
		KP = P_0;
		switch (P_0)
		{
		case ar.A.Bnl:
			Kq = P_3;
			((ToolStripItem)this).Image = Ks;
			((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gB();
			((ToolStripItem)this).BackColor = ((ToolStripItem)this).GetCurrentParent().BackColor;
			Kt.Reset();
			((ToolStripItem)this).Invalidate();
			break;
		case ar.A.BnM:
			Kq = P_3;
			((ToolStripItem)this).Image = KT;
			((ToolStripItem)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gb();
			((ToolStripItem)this).BackColor = Color.FromArgb(0, 200, 0);
			Kt.Restart();
			((ToolStripItem)this).Invalidate();
			break;
		case ar.A.Bnm:
			B();
			KQ = P_2;
			Kq = P_3;
			break;
		case ar.A.BnN:
			Kp = P_1;
			KQ = P_2;
			Kq = P_3;
			((ToolStripItem)this).Invalidate();
			break;
		}
		((ToolStripItem)this).ToolTipText = Kq;
	}

	internal void d()
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (((ToolStripItem)this).Image == KT)
		{
			if (Kt.IsRunning)
			{
				if (Kt.ElapsedMilliseconds >= 2000)
				{
					((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
					return;
				}
				float num = 1f - (float)(int)Kt.ElapsedMilliseconds / 2000f;
				Color backColor = BM.QQ.RG.BackColor;
				int r = ((Color)(ref backColor)).R;
				backColor = BM.QQ.RG.BackColor;
				int g = ((Color)(ref backColor)).G;
				backColor = BM.QQ.RG.BackColor;
				int num2 = ((Color)(ref backColor)).B;
				Color backColor2 = Color.FromArgb(r - (int)(num * (float)r), g + (int)(num * (float)(200 - g)), num2 - (int)(num * (float)num2));
				((ToolStripItem)this).BackColor = backColor2;
			}
			else
			{
				Kt.Restart();
				((ToolStripItem)this).BackColor = Color.FromArgb(0, 200, 0);
			}
		}
		else
		{
			((ToolStripItem)this).BackColor = BM.QQ.RG.BackColor;
			Kt.Reset();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		((ToolStripButton)this).OnPaint(e);
		if (KP == ar.A.Bnl || KP == ar.A.BnM)
		{
			return;
		}
		e.Graphics.SmoothingMode = (SmoothingMode)4;
		e.Graphics.Clear(((ToolStripItem)this).BackColor);
		Rectangle val = default(Rectangle);
		((Rectangle)(ref val))._002Ector(new Point(((ToolStripItem)this).Width / 2 - A() / 2, (((ToolStripItem)this).Height - 15) / 2 - A() / 2), new Size(A(), A()));
		Rectangle val2 = default(Rectangle);
		((Rectangle)(ref val2))._002Ector(new Point(0, 1), new Size(((ToolStripItem)this).Width, ((ToolStripItem)this).Height - 15));
		Rectangle val3 = default(Rectangle);
		((Rectangle)(ref val3))._002Ector(new Point(0, ((ToolStripItem)this).Height - 15), new Size(((ToolStripItem)this).Width, 15));
		StringFormat val4 = new StringFormat();
		val4.LineAlignment = (StringAlignment)1;
		val4.Alignment = (StringAlignment)1;
		if (KP == ar.A.Bnm)
		{
			a();
			Pen val5 = new Pen(Color.Gray, 4f);
			try
			{
				e.Graphics.DrawEllipse(val5, val);
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
			Brush val6 = (Brush)new SolidBrush(BM.te);
			try
			{
				Font val7 = new Font(((ToolStripItem)this).Font.FontFamily, 8f, (FontStyle)1);
				try
				{
					e.Graphics.DrawString(KQ, val7, val6, RectangleF.op_Implicit(val3), val4);
				}
				finally
				{
					((System.IDisposable)val7)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val6)?.Dispose();
			}
			Pen val8 = new Pen(Color.FromArgb(0, 200, 0), 5f);
			try
			{
				e.Graphics.DrawArc(val8, val, (float)KR, (float)Kr);
			}
			finally
			{
				((System.IDisposable)val8)?.Dispose();
			}
		}
		else if (KP == ar.A.BnN)
		{
			Pen val9 = new Pen(Color.Gray, 4f);
			try
			{
				e.Graphics.DrawEllipse(val9, val);
			}
			finally
			{
				((System.IDisposable)val9)?.Dispose();
			}
			Brush val10 = (Brush)new SolidBrush(BM.te);
			try
			{
				Font val11 = new Font(((ToolStripItem)this).Font.FontFamily, 8f, (FontStyle)1);
				try
				{
					e.Graphics.DrawString(KQ, val11, val10, RectangleF.op_Implicit(val3), val4);
				}
				finally
				{
					((System.IDisposable)val11)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val10)?.Dispose();
			}
			Pen val12 = new Pen(Color.FromArgb(0, 200, 0), 5f);
			try
			{
				float num = (float)Kp / 100f * 360f;
				e.Graphics.DrawArc(val12, val, -90f, num);
			}
			finally
			{
				((System.IDisposable)val12)?.Dispose();
			}
			Brush val13 = (Brush)new SolidBrush(BM.te);
			try
			{
				Font val14 = new Font(((ToolStripItem)this).Font.FontFamily, 8f, (FontStyle)1);
				try
				{
					e.Graphics.DrawString(Kp + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gC(), val14, val13, RectangleF.op_Implicit(val2), val4);
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
		}
		val4.Dispose();
	}
}
