using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;

namespace a;

internal class aQ : Control
{
	internal const int jp = 18;

	private int jQ;

	private int jq = 10;

	private int jR = 1;

	private int jr;

	private int jS = 100;

	private int js;

	private int jT;

	private int jt;

	private int jU;

	private bool ju;

	private bool jV;

	private bool jv;

	private bool jW;

	private bool jw;

	private bool jX;

	private bool jx;

	[CompilerGenerated]
	private EventHandler jY;

	private IContainer jy;

	[SpecialName]
	[CompilerGenerated]
	internal void A(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = jY;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref jY, val3, val2);
		}
		while (val != val2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void a(EventHandler P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		EventHandler val = jY;
		EventHandler val2;
		do
		{
			val2 = val;
			EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
			val = Interlocked.CompareExchange<EventHandler>(ref jY, val3, val2);
		}
		while (val != val2);
	}

	internal aQ()
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
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gz();
		((Control)this).MouseDown += new MouseEventHandler(A);
		((Control)this).MouseMove += new MouseEventHandler(B);
		((Control)this).MouseUp += new MouseEventHandler(a);
		((Control)this).MouseLeave += new EventHandler(A);
		((Control)this).ResumeLayout(false);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)65536, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).Height = 18;
		jQ = ((Control)this).Height;
		((Control)this).MinimumSize = new Size(jQ + jQ + c(), jQ);
	}

	[SpecialName]
	internal int A()
	{
		return jq;
	}

	[SpecialName]
	internal void A(int P_0)
	{
		jq = P_0;
		((Control)this).Invalidate();
	}

	[SpecialName]
	internal int a()
	{
		return jR;
	}

	[SpecialName]
	internal void a(int P_0)
	{
		jR = P_0;
		((Control)this).Invalidate();
	}

	[SpecialName]
	internal int B()
	{
		return jr;
	}

	[SpecialName]
	internal void B(int P_0)
	{
		jr = P_0;
		((Control)this).Invalidate();
	}

	[SpecialName]
	internal int b()
	{
		return jS;
	}

	[SpecialName]
	internal void b(int P_0)
	{
		jS = P_0;
		((Control)this).Invalidate();
	}

	[SpecialName]
	internal int C()
	{
		return js;
	}

	[SpecialName]
	internal void C(int P_0)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		js = P_0;
		int num = ((Control)this).Width - 2 * jQ - c();
		int num2 = b() - B() - A();
		float num3 = 0f;
		if (num2 != 0)
		{
			num3 = (float)js / (float)num2;
		}
		float num4 = num3 * (float)num;
		jU = Math.Max((int)num4, 0);
		if (jU > num)
		{
			jU = num;
			num3 = (float)jU / (float)num;
			js = (int)(num3 * (float)(b() - A()));
			if (jY != null)
			{
				jY.Invoke((object)this, new EventArgs());
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
		int num2 = ((Control)this).Width - 2 * jQ;
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
			new Point(jQ / 4, jQ / 2 - 1),
			new Point(jQ * 5 / 8, jQ / 5 - 1),
			new Point(jQ * 5 / 8, jQ * 4 / 5 - 1)
		};
		if (jv)
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
		else if (jX)
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
			new Point(((Control)this).Width - jQ + jQ * 3 / 4, jQ / 2 - 1),
			new Point(((Control)this).Width - jQ + jQ * 3 / 8, jQ / 5 - 1),
			new Point(((Control)this).Width - jQ + jQ * 3 / 8, jQ * 4 / 5 - 1)
		};
		if (jW)
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
		else if (jx)
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
		if (jQ + jU + num > ((Control)this).Width - jQ)
		{
			num = ((Control)this).Width - jQ - (jQ + jU);
		}
		if (ju)
		{
			SolidBrush val8 = new SolidBrush(BM.tN);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val8, jQ + jU, 3, num, ((Control)this).Height - 8);
				return;
			}
			finally
			{
				((System.IDisposable)val8)?.Dispose();
			}
		}
		if (jw)
		{
			SolidBrush val9 = new SolidBrush(BM.tm);
			try
			{
				e.Graphics.FillRectangle((Brush)(object)val9, jQ + jU, 3, num, ((Control)this).Height - 8);
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
			e.Graphics.FillRectangle((Brush)(object)val10, jQ + jU, 3, num, ((Control)this).Height - 8);
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
		jw = false;
		jX = false;
		jx = false;
		int num = c();
		int num2 = ((Control)this).Width - 2 * jQ;
		Point val = ((Control)this).PointToClient(Cursor.Position);
		Rectangle val2 = default(Rectangle);
		((Rectangle)(ref val2))._002Ector(new Point(jQ + jU, 0), new Size(num, ((Control)this).Height));
		if (((Rectangle)(ref val2)).Contains(val))
		{
			jT = ((Point)(ref val)).X;
			jt = jU;
			ju = true;
			((Control)this).Invalidate();
			return;
		}
		Rectangle val3 = default(Rectangle);
		((Rectangle)(ref val3))._002Ector(new Point(0, 0), new Size(jQ, jQ));
		if (((Rectangle)(ref val3)).Contains(val))
		{
			jv = true;
			int num3 = b() - B() - A();
			int num4 = num2 - num;
			if (num3 > 0 && num4 > 0)
			{
				if (jU - a() < 0)
				{
					jU = 0;
				}
				else
				{
					jU -= a();
				}
				jU = Math.Max(jU, 0);
				float num5 = (float)jU / (float)num4 * (float)(b() - A());
				js = (int)num5;
				if (jY != null)
				{
					jY.Invoke((object)this, new EventArgs());
				}
				((Control)this).Invalidate();
			}
			return;
		}
		Rectangle val4 = default(Rectangle);
		((Rectangle)(ref val4))._002Ector(new Point(jQ + num2, 0), new Size(jQ, jQ));
		if (((Rectangle)(ref val4)).Contains(val))
		{
			jW = true;
			int num6 = b() - B() - A();
			int num7 = num2 - num;
			if (num6 > 0 && num7 > 0)
			{
				if (jU + a() > num7)
				{
					jU = num7;
				}
				else
				{
					jU += a();
				}
				jU = Math.Max(jU, 0);
				float num8 = (float)jU / (float)num7 * (float)(b() - A());
				js = (int)num8;
				if (jY != null)
				{
					jY.Invoke((object)this, new EventArgs());
				}
				((Control)this).Invalidate();
			}
			return;
		}
		Rectangle val5 = default(Rectangle);
		((Rectangle)(ref val5))._002Ector(new Point(jQ, 0), new Size(((Rectangle)(ref val2)).Left - jQ, jQ));
		if (((Rectangle)(ref val5)).Contains(val))
		{
			int num9 = b() - B() - A();
			int num10 = num2 - num;
			if (num9 > 0 && num10 > 0)
			{
				if (jU - A() < 0)
				{
					jU = 0;
				}
				else
				{
					jU -= A();
				}
				jU = Math.Max(jU, 0);
				float num11 = (float)jU / (float)num10 * (float)(b() - A());
				js = (int)num11;
				if (jY != null)
				{
					jY.Invoke((object)this, new EventArgs());
				}
				((Control)this).Invalidate();
			}
			return;
		}
		Rectangle val6 = default(Rectangle);
		((Rectangle)(ref val6))._002Ector(new Point(((Rectangle)(ref val2)).Right, 0), new Size(((Rectangle)(ref val4)).Left - ((Rectangle)(ref val2)).Right, jQ));
		if (!((Rectangle)(ref val6)).Contains(val))
		{
			return;
		}
		int num12 = b() - B() - A();
		int num13 = num2 - num;
		if (num12 > 0 && num13 > 0)
		{
			if (jU + A() > num13)
			{
				jU = num13;
			}
			else
			{
				jU += A();
			}
			jU = Math.Max(jU, 0);
			float num14 = (float)jU / (float)num13 * (float)(b() - A());
			js = (int)num14;
			if (jY != null)
			{
				jY.Invoke((object)this, new EventArgs());
			}
			((Control)this).Invalidate();
		}
	}

	private void a(object P_0, MouseEventArgs P_1)
	{
		ju = false;
		jV = false;
		jv = false;
		jW = false;
		((Control)this).Invalidate();
	}

	private void A(object P_0, EventArgs P_1)
	{
		ju = false;
		jV = false;
		jv = false;
		jW = false;
		jw = false;
		jX = false;
		jx = false;
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
		if (ju)
		{
			jV = true;
		}
		if (jV)
		{
			int num = P_1.X - jT;
			int num2 = c();
			int num3 = ((Control)this).Width - 2 * jQ;
			int num4 = b() - B();
			int num5 = num3 - num2;
			if (ju && num4 > 0 && num5 > 0)
			{
				int num6 = jU;
				int num7 = jt + num;
				if (num7 < 0)
				{
					jU = 0;
				}
				else if (num7 > num5)
				{
					jU = num5;
				}
				else
				{
					jU = num7;
				}
				jU = Math.Max(jU, 0);
				float num8 = (float)jU / (float)num5 * (float)(b() - A());
				js = (int)num8;
				if (jU != num6 && jY != null)
				{
					jY.Invoke((object)this, new EventArgs());
				}
				((Control)this).Invalidate();
			}
			return;
		}
		int num9 = c();
		int num10 = ((Control)this).Width - 2 * jQ;
		Point val = ((Control)this).PointToClient(Cursor.Position);
		Rectangle val2 = default(Rectangle);
		((Rectangle)(ref val2))._002Ector(new Point(jQ + jU, 0), new Size(num9, ((Control)this).Height));
		Rectangle val3 = default(Rectangle);
		((Rectangle)(ref val3))._002Ector(new Point(0, 0), new Size(jQ, jQ));
		Rectangle val4 = default(Rectangle);
		((Rectangle)(ref val4))._002Ector(new Point(jQ + num10, 0), new Size(jQ, jQ));
		if (((Rectangle)(ref val2)).Contains(val))
		{
			jw = true;
			jX = false;
			jx = false;
		}
		else if (((Rectangle)(ref val3)).Contains(val))
		{
			jw = false;
			jX = true;
			jx = false;
		}
		else if (((Rectangle)(ref val4)).Contains(val))
		{
			jw = false;
			jX = false;
			jx = true;
		}
		else
		{
			jw = false;
			jX = false;
			jx = false;
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
		if (disposing && jy != null)
		{
			((System.IDisposable)jy).Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	private void D()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		jy = (IContainer)new Container();
	}
}
internal class aq : TabControl
{
	protected int Kb = -1;

	internal aq()
	{
		((Control)this).SetStyle((ControlStyles)73730, true);
		((TabControl)this).DrawMode = (TabDrawMode)1;
	}

	protected override void OnPaintBackground(PaintEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = e.Graphics;
		SolidBrush val = new SolidBrush(BM.td);
		try
		{
			graphics.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).Width, ((Control)this).Height);
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
		Point val10 = default(Point);
		for (int i = 0; i < ((TabControl)this).TabPages.Count; i++)
		{
			TabPage val2 = (TabPage)((((TabControl)this).TabPages[i] is ae) ? ((object)(((TabControl)this).TabPages[i] as ae)) : ((object)((!(((TabControl)this).TabPages[i] is aX)) ? ((aX)(object)((TabControl)this).TabPages[i]) : (((TabControl)this).TabPages[i] as aX))));
			Rectangle tabRect = ((TabControl)this).GetTabRect(i);
			if (val2 is aX && ((val2 as aX).A() || (val2 as aX).a()))
			{
				((Rectangle)(ref tabRect))._002Ector(((Rectangle)(ref tabRect)).X, ((Rectangle)(ref tabRect)).Y, ((Rectangle)(ref tabRect)).Width - 15, ((Rectangle)(ref tabRect)).Height);
			}
			if (i == ((TabControl)this).SelectedIndex)
			{
				SolidBrush val3 = new SolidBrush(BM.tJ);
				try
				{
					graphics.FillRectangle((Brush)(object)val3, ((Rectangle)(ref tabRect)).X + 1, ((Rectangle)(ref tabRect)).Y, ((Rectangle)(ref tabRect)).Width - 2, ((Rectangle)(ref tabRect)).Height);
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
				if (BM.TO)
				{
					Pen val4 = new Pen(BM.tL, 1f);
					try
					{
						graphics.DrawRectangle(val4, tabRect);
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
			}
			else
			{
				SolidBrush val5 = new SolidBrush(BM.tj);
				try
				{
					graphics.FillRectangle((Brush)(object)val5, ((Rectangle)(ref tabRect)).X + 1, ((Rectangle)(ref tabRect)).Y + 2, ((Rectangle)(ref tabRect)).Width - 2, ((Rectangle)(ref tabRect)).Height - 2);
				}
				finally
				{
					((System.IDisposable)val5)?.Dispose();
				}
				if (BM.TO)
				{
					Pen val6 = new Pen(BM.tL, 1f);
					try
					{
						graphics.DrawRectangle(val6, ((Rectangle)(ref tabRect)).X, ((Rectangle)(ref tabRect)).Y + 2, ((Rectangle)(ref tabRect)).Width, ((Rectangle)(ref tabRect)).Height - 2);
					}
					finally
					{
						((System.IDisposable)val6)?.Dispose();
					}
				}
			}
			if (val2 is aX && (val2 as aX).A() && i < ((TabControl)this).TabPages.Count - 1)
			{
				Pen val7 = new Pen(BM.tL, 1f);
				try
				{
					int num = ((Rectangle)(ref tabRect)).Top + ((Rectangle)(ref tabRect)).Height / 2 + 1;
					graphics.DrawLine(val7, ((Rectangle)(ref tabRect)).Right + 3, num, ((Rectangle)(ref tabRect)).Right + 13, num);
					graphics.DrawLine(val7, ((Rectangle)(ref tabRect)).Right + 10, num - 3, ((Rectangle)(ref tabRect)).Right + 13, num);
					graphics.DrawLine(val7, ((Rectangle)(ref tabRect)).Right + 10, num + 3, ((Rectangle)(ref tabRect)).Right + 13, num);
				}
				finally
				{
					((System.IDisposable)val7)?.Dispose();
				}
			}
			if (val2 is ae && i < ((TabControl)this).TabPages.Count - 1)
			{
				Pen val8 = ((i != ((TabControl)this).SelectedIndex) ? new Pen(BM.tk, 1f) : new Pen(BM.tK, 1f));
				graphics.DrawRectangle(val8, ((Rectangle)(ref tabRect)).Left + ((Rectangle)(ref tabRect)).Width - 4 - 7, ((Rectangle)(ref tabRect)).Top + ((Rectangle)(ref tabRect)).Height / 2, 6, 6);
				if ((val2 as ae).B())
				{
					graphics.DrawLine(val8, ((Rectangle)(ref tabRect)).Left + ((Rectangle)(ref tabRect)).Width - 4 - 6, ((Rectangle)(ref tabRect)).Top + ((Rectangle)(ref tabRect)).Height / 2, ((Rectangle)(ref tabRect)).Left + ((Rectangle)(ref tabRect)).Width - 4 - 6, ((Rectangle)(ref tabRect)).Top + ((Rectangle)(ref tabRect)).Height / 2 - 1);
					graphics.DrawLine(val8, ((Rectangle)(ref tabRect)).Left + ((Rectangle)(ref tabRect)).Width - 4 - 2, ((Rectangle)(ref tabRect)).Top + ((Rectangle)(ref tabRect)).Height / 2, ((Rectangle)(ref tabRect)).Left + ((Rectangle)(ref tabRect)).Width - 4 - 2, ((Rectangle)(ref tabRect)).Top + ((Rectangle)(ref tabRect)).Height / 2 - 1);
					graphics.DrawArc(val8, ((Rectangle)(ref tabRect)).Left + ((Rectangle)(ref tabRect)).Width - 4 - 6, ((Rectangle)(ref tabRect)).Top + ((Rectangle)(ref tabRect)).Height / 2 - 4, 4, 4, 180, 180);
				}
				else
				{
					graphics.DrawLine(val8, ((Rectangle)(ref tabRect)).Left + ((Rectangle)(ref tabRect)).Width - 4 - 6, ((Rectangle)(ref tabRect)).Top + ((Rectangle)(ref tabRect)).Height / 2, ((Rectangle)(ref tabRect)).Left + ((Rectangle)(ref tabRect)).Width - 4 - 6, ((Rectangle)(ref tabRect)).Top + ((Rectangle)(ref tabRect)).Height / 2 - 3);
					graphics.DrawArc(val8, ((Rectangle)(ref tabRect)).Left + ((Rectangle)(ref tabRect)).Width - 4 - 6, ((Rectangle)(ref tabRect)).Top + ((Rectangle)(ref tabRect)).Height / 2 - 6, 4, 4, 180, 180);
				}
				val8.Dispose();
			}
			string text = ((Control)val2).Text;
			Size val9 = TextRenderer.MeasureText(text, ((Control)this).Font);
			if (val2 is ae && i < ((TabControl)this).TabPages.Count - 1)
			{
				((Point)(ref val10))._002Ector(((Rectangle)(ref tabRect)).Left + (((Rectangle)(ref tabRect)).Width - 8) / 2 - ((Size)(ref val9)).Width / 2, 1 + ((Rectangle)(ref tabRect)).Top + ((Rectangle)(ref tabRect)).Height / 2 - ((Size)(ref val9)).Height / 2);
			}
			else
			{
				((Point)(ref val10))._002Ector(((Rectangle)(ref tabRect)).Left + ((Rectangle)(ref tabRect)).Width / 2 - ((Size)(ref val9)).Width / 2, 1 + ((Rectangle)(ref tabRect)).Top + ((Rectangle)(ref tabRect)).Height / 2 - ((Size)(ref val9)).Height / 2);
			}
			if (val2 is ae && (val2 as ae).a())
			{
				Font val11 = new Font(((Control)this).Font, (FontStyle)2);
				try
				{
					if (i == ((TabControl)this).SelectedIndex)
					{
						TextRenderer.DrawText((IDeviceContext)(object)graphics, text, val11, val10, BM.tK, (TextFormatFlags)2048);
					}
					else
					{
						TextRenderer.DrawText((IDeviceContext)(object)graphics, text, val11, val10, BM.tk, (TextFormatFlags)2048);
					}
				}
				finally
				{
					((System.IDisposable)val11)?.Dispose();
				}
			}
			else if (i == ((TabControl)this).SelectedIndex)
			{
				TextRenderer.DrawText((IDeviceContext)(object)graphics, text, ((Control)this).Font, val10, BM.tK, (TextFormatFlags)2048);
			}
			else
			{
				TextRenderer.DrawText((IDeviceContext)(object)graphics, text, ((Control)this).Font, val10, BM.tk, (TextFormatFlags)2048);
			}
			if (Kb != -1 && i == Kb)
			{
				graphics.FillRectangle(Brushes.DodgerBlue, ((Rectangle)(ref tabRect)).Left, ((Rectangle)(ref tabRect)).Top, 5, ((Rectangle)(ref tabRect)).Height);
			}
		}
		int num2 = 0;
		for (int j = 0; j < ((TabControl)this).TabPages.Count; j++)
		{
			int num3 = num2;
			Rectangle tabRect2 = ((TabControl)this).GetTabRect(j);
			num2 = Math.Max(num3, ((Rectangle)(ref tabRect2)).Bottom);
		}
		if (BM.TO)
		{
			graphics.DrawRectangle(Pens.Gray, 2, num2, ((Control)this).Width - 5, ((Control)this).Height - (num2 + 3));
		}
	}
}
