using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using NSP.SettingsFramework;
using a;
using b;
using c;

namespace D;

internal class DB : cO
{
	private new class A : TrackBar
	{
		private DB baD;

		private int bad;

		private const int baE = 4;

		internal A(DB P_0)
		{
			baD = P_0;
			((Control)this).SetStyle((ControlStyles)8192, true);
			((Control)this).SetStyle((ControlStyles)131072, true);
			((Control)this).SetStyle((ControlStyles)2, true);
			((TrackBar)this).Minimum = 0;
			((TrackBar)this).Maximum = 3;
			((TrackBar)this).TickFrequency = 1;
			((TrackBar)this).SmallChange = 1;
			((TrackBar)this).LargeChange = 1;
		}

		internal int A(int P_0)
		{
			int result = 1;
			switch (P_0)
			{
			case 0:
				result = 1;
				break;
			case 1:
				result = 2;
				break;
			case 2:
				result = 4;
				break;
			case 3:
				result = 8;
				break;
			}
			return result;
		}

		internal void a(int P_0)
		{
			int value = 0;
			switch (P_0)
			{
			case 1:
				value = 0;
				break;
			case 2:
				value = 1;
				break;
			case 4:
				value = 2;
				break;
			case 8:
				value = 3;
				break;
			}
			((TrackBar)this).Value = value;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = (SmoothingMode)2;
			Font val = new Font(((Control)this).Font.FontFamily, 10f);
			try
			{
				SolidBrush val2 = new SolidBrush(BM.te);
				try
				{
					StringFormat val3 = new StringFormat();
					val3.Alignment = (StringAlignment)1;
					val3.LineAlignment = (StringAlignment)1;
					if (BM.Tn == BM.r.BqG || BM.Tn == BM.r.Bqh)
					{
						Pen val4 = new Pen(Color.Gray, 4f);
						try
						{
							graphics.DrawLine(val4, 14, 10, ((Control)this).Width - 11, 10);
						}
						finally
						{
							((System.IDisposable)val4)?.Dispose();
						}
						for (int i = 0; i < 4; i++)
						{
							int num = 14 + i * (((Control)this).Width - 25) / 3;
							graphics.DrawLine(Pens.Gray, num, 12, num, 18);
							graphics.DrawString(A(i) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ei(), val, (Brush)(object)val2, (float)num, 26f, val3);
						}
					}
					else
					{
						Pen val5 = new Pen(Color.White, 4f);
						try
						{
							graphics.DrawLine(val5, 14, 10, ((Control)this).Width - 11, 10);
						}
						finally
						{
							((System.IDisposable)val5)?.Dispose();
						}
						for (int j = 0; j < 4; j++)
						{
							int num2 = 14 + j * (((Control)this).Width - 25) / 3;
							graphics.DrawLine(Pens.White, num2, 12, num2, 18);
							graphics.DrawString(A(j) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ei(), val, (Brush)(object)val2, (float)num2, 26f, val3);
						}
					}
					graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJI(), val, (Brush)(object)val2, (float)(((Control)this).Width / 2), 40f, val3);
					val3.Dispose();
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
			graphics.FillEllipse(Brushes.DodgerBlue, 14 + ((TrackBar)this).Value * (((Control)this).Width - 25) / 3 - 7, 3, 14, 14);
			if (((TrackBar)this).Value != bad)
			{
				int userZoomLevel = A(((TrackBar)this).Value);
				baD.BKE.UserZoomLevel = userZoomLevel;
				if (baD.BKe != null)
				{
					baD.BKe.UserZoomLevel = userZoomLevel;
				}
				bad = ((TrackBar)this).Value;
			}
		}

		protected override void OnGotFocus(EventArgs e)
		{
			((Control)baD).Focus();
		}
	}

	private const int Buj = 94;

	private const int BuK = 65;

	private const int Buk = 50;

	private const int BuL = 2;

	private const int Bul = 20;

	private bool BuM;

	private A Bum;

	private string BuN;

	private string Bun;

	private static Pen[] BuO = (Pen[])(object)new Pen[10]
	{
		Pens.Red,
		Pens.SkyBlue,
		Pens.LightGreen,
		Pens.Yellow,
		Pens.PeachPuff,
		Pens.LightCoral,
		Pens.PaleTurquoise,
		Pens.White,
		Pens.Orange,
		Pens.Pink
	};

	private int Buo = -1;

	private bool BuP;

	private int Bup;

	private int BuQ;

	private Rectangle Buq = Rectangle.Empty;

	private Dictionary<int, int> BuR = new Dictionary<int, int>();

	private Dictionary<int, int> Bur = new Dictionary<int, int>();

	private int BuS;

	private bool Bus;

	private Point BuT = new Point(0, 0);

	private Stopwatch But = new Stopwatch();

	private ToolStripMenuItem BuU;

	internal DB(Framework P_0, Framework P_1, Rectangle P_2, bool P_3)
		: base(P_0, P_1, P_2, P_3)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		Bum = new A(this);
		_ = ((Control)Bum).Handle;
		((Control)this).DoubleBuffered = true;
		((Control)this).GotFocus += new EventHandler(G);
		((Control)this).LostFocus += new EventHandler(g);
	}

	internal override void A(int P_0)
	{
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		Setting setting = BKD.A(P_0);
		if (setting != null)
		{
			BKE = setting as Table;
		}
		else
		{
			BKE = null;
		}
		if (BKE != null)
		{
			BKF = ((Setting)BKE).A();
			if (BKE != null && BKd != null)
			{
				BKe = BKd.A(P_0) as Table;
			}
			else
			{
				BKe = null;
			}
		}
		else
		{
			BKe = null;
		}
		if (BKE != null && BKe != null)
		{
			if (BKe.InvertRows != BKE.InvertRows)
			{
				BKe.InvertRows = BKE.InvertRows;
			}
			if (BKe.SwapColumnsAndRows != BKE.SwapColumnsAndRows)
			{
				BKe.SwapColumnsAndRows = BKE.SwapColumnsAndRows;
			}
			if (BKe.HorizVertIndexPerUserSelectedCell != BKE.HorizVertIndexPerUserSelectedCell)
			{
				BKe.HorizVertIndexPerUserSelectedCell = BKE.HorizVertIndexPerUserSelectedCell;
			}
		}
		BKi = BKD.B() && BKD.b() && BKE != null && BKE.J();
		BKJ = BKd != null && BKd.B() && BKd.b() && BKe != null && BKe.J();
		if ((BM.QO != BM.b.BpG || BKd == null) ? BKi : BKJ)
		{
			Label val = new Label();
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)BKE).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
			((Control)val).ForeColor = BM.te;
			((Control)val).BackColor = Color.Transparent;
			((Control)val).AutoSize = true;
			((Control)val).Left = 10;
			((Control)val).Top = 10;
			((Control)this).Controls.Add((Control)(object)val);
			return;
		}
		if (BKE != null)
		{
			((Setting)BKE).A(new EventHandler(d));
			BKE.TableDataSetting.A(new EventHandler(f));
			BKE.OnUserSelectionChanged += new EventHandler(b);
			BKE.OnInvertRows += new EventHandler(C);
			BKE.OnSwapColumnsAndRows += new EventHandler(c);
			BKE.OnUserSliceIndexChanged += new EventHandler(B);
			BKE.OnUserZoomLevelChanged += new EventHandler(k);
			BKE.OnShowHideBarsChanged += new EventHandler(J);
			Bum.a(BKE.UserZoomLevel);
			if (BKD.awo != null)
			{
				BKD.awo.a(((Setting)BKE).A())?.A(new EventHandler(e));
			}
		}
		((Control)this).Paint += new PaintEventHandler(A);
		global::A.A.A(new EventHandler(F));
		global::A.A.A((global::A.D)F);
		BM.D(new EventHandler(F));
		BM.E(new EventHandler(F));
		b();
		UpdateLayout(resizingOnly: false);
		((Control)this).ContextMenuStrip = c();
	}

	protected override void a()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		try
		{
			((Control)this).Paint -= new PaintEventHandler(A);
			if (BKE != null)
			{
				BKE.a(new EventHandler(d));
				BKE.TableDataSetting.a(new EventHandler(f));
				BKE.OnUserSelectionChanged -= new EventHandler(b);
				BKE.OnInvertRows -= new EventHandler(C);
				BKE.OnSwapColumnsAndRows -= new EventHandler(c);
				BKE.OnUserSliceIndexChanged -= new EventHandler(B);
				BKE.OnUserZoomLevelChanged -= new EventHandler(k);
				BKE.OnShowHideBarsChanged -= new EventHandler(J);
				if (BKD.awo != null)
				{
					BKD.awo.a(((Setting)BKE).A())?.a(new EventHandler(e));
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.F() != null)
				{
					BKE.HorizAxis.F().a(new EventHandler(f));
				}
				if (BKE.VertAxis != null && BKE.VertAxis.F() != null)
				{
					BKE.VertAxis.F().a(new EventHandler(f));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.F() != null)
				{
					BKE.SliceAxis.F().a(new EventHandler(f));
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.f() != null)
				{
					BKE.HorizAxis.f().a(new EventHandler(f));
				}
				if (BKE.VertAxis != null && BKE.VertAxis.f() != null)
				{
					BKE.VertAxis.f().a(new EventHandler(f));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.f() != null)
				{
					BKE.SliceAxis.f().a(new EventHandler(f));
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.G() != null)
				{
					BKE.HorizAxis.G().a(new EventHandler(f));
				}
				if (BKE.VertAxis != null && BKE.VertAxis.G() != null)
				{
					BKE.VertAxis.G().a(new EventHandler(f));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.G() != null)
				{
					BKE.SliceAxis.G().a(new EventHandler(f));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.H() != null)
				{
					BKE.SliceAxis.H().a(new EventHandler(f));
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.g() != null)
				{
					BKE.HorizAxis.g().a(new EventHandler(D));
				}
				if (BKE.VertAxis != null && BKE.VertAxis.g() != null)
				{
					BKE.VertAxis.g().a(new EventHandler(D));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.g() != null)
				{
					BKE.SliceAxis.g().a(new EventHandler(D));
				}
			}
			if (BKg != null)
			{
				BKg.a(new EventHandler(E));
			}
			global::A.A.a(new EventHandler(F));
			global::A.A.a((global::A.D)F);
			BM.d(new EventHandler(F));
			BM.e(new EventHandler(F));
			if (((Control)this).ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				((ToolStripItem)item).Click -= new EventHandler(a);
				((ToolStripItem)item).Click -= new EventHandler(i);
				((ToolStripItem)item).Click -= new EventHandler(j);
				((ToolStripItem)item).Click -= new EventHandler(I);
				((ToolStripItem)item).Click -= new EventHandler(H);
			}
			((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(K);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		a();
		try
		{
			((Control)this).GotFocus -= new EventHandler(G);
			((Control)this).LostFocus -= new EventHandler(g);
			BM.QQ.b(new EventHandler(((cO)this).A));
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = ((Panel)this).ToString();
		if (BKE != null)
		{
			text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY() + ((object)BKE).ToString();
		}
		return string.Concat(new string[5]
		{
			text,
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAZ(),
			((Control)this).Left.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAz(),
			((Control)this).Top.ToString()
		});
	}

	[SpecialName]
	internal new Table B()
	{
		return BKE;
	}

	private new void b()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected O, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		bool flag = ((BM.QO != BM.b.BpG || BKd == null) ? BKi : BKJ);
		if (flag || BKE == null)
		{
			return;
		}
		Table table = ((BM.QO != BM.b.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.F() != null)
		{
			BKE.HorizAxis.F().a(new EventHandler(f));
			BKE.HorizAxis.F().A(new EventHandler(f));
		}
		if (BKE.VertAxis != null && BKE.VertAxis.F() != null)
		{
			BKE.VertAxis.F().a(new EventHandler(f));
			BKE.VertAxis.F().A(new EventHandler(f));
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.F() != null)
		{
			BKE.SliceAxis.F().a(new EventHandler(f));
			BKE.SliceAxis.F().A(new EventHandler(f));
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.f() != null)
		{
			BKE.HorizAxis.f().a(new EventHandler(f));
			BKE.HorizAxis.f().A(new EventHandler(f));
		}
		if (BKE.VertAxis != null && BKE.VertAxis.f() != null)
		{
			BKE.VertAxis.f().a(new EventHandler(f));
			BKE.VertAxis.f().A(new EventHandler(f));
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.f() != null)
		{
			BKE.SliceAxis.f().a(new EventHandler(f));
			BKE.SliceAxis.f().A(new EventHandler(f));
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.G() != null)
		{
			BKE.HorizAxis.G().a(new EventHandler(f));
			BKE.HorizAxis.G().A(new EventHandler(f));
		}
		if (BKE.VertAxis != null && BKE.VertAxis.G() != null)
		{
			BKE.VertAxis.G().a(new EventHandler(f));
			BKE.VertAxis.G().A(new EventHandler(f));
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.G() != null)
		{
			BKE.SliceAxis.G().a(new EventHandler(f));
			BKE.SliceAxis.G().A(new EventHandler(f));
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.H() != null)
		{
			BKE.SliceAxis.H().a(new EventHandler(f));
			BKE.SliceAxis.H().A(new EventHandler(f));
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.g() != null)
		{
			BKE.HorizAxis.g().a(new EventHandler(D));
			BKE.HorizAxis.g().A(new EventHandler(D));
			BKf = BKE.HorizAxis.h();
			if (BKe != null && BKe.HorizAxis != null && BKe.HorizAxis.g() != null)
			{
				BKH = BKe.HorizAxis.h();
			}
		}
		if (BKE.VertAxis != null && BKE.VertAxis.g() != null)
		{
			BKE.VertAxis.g().a(new EventHandler(D));
			BKE.VertAxis.g().A(new EventHandler(D));
			BKG = BKE.VertAxis.h();
			if (BKe != null && BKe.VertAxis != null && BKe.VertAxis.g() != null)
			{
				BKh = BKe.VertAxis.h();
			}
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.g() != null)
		{
			BKE.SliceAxis.g().a(new EventHandler(D));
			BKE.SliceAxis.g().A(new EventHandler(D));
			BKg = BKE.SliceAxis.h();
			if (BKg != null)
			{
				BKg.a(new EventHandler(E));
				BKg.A(new EventHandler(E));
			}
			if (BKe != null && BKe.SliceAxis != null && BKe.SliceAxis.g() != null)
			{
				BKI = BKe.SliceAxis.h();
			}
		}
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		bool flag = ((BM.QO != BM.b.BpG || BKd == null) ? BKi : BKJ);
		if (!flag && BKE != null)
		{
			if (BM.QO == BM.b.BpG && BKe != null)
			{
				BuN = BKe.GetSelectionRangeString(BKH, BKh);
			}
			else
			{
				BuN = BKE.GetSelectionRangeString(BKf, BKG);
			}
			f(null, null);
			((Control)Bum).Width = 100;
			((Control)Bum).Height = 50;
			((Control)Bum).Left = ((Control)this).Width - 5 - ((Control)Bum).Width;
			((Control)Bum).Top = 10;
			if (!((Control)this).Controls.Contains((Control)(object)Bum))
			{
				((Control)this).Controls.Add((Control)(object)Bum);
			}
			((Control)Bum).Invalidate();
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	internal new void A(bool P_0)
	{
		if (BuM != P_0)
		{
			BuM = P_0;
			UpdateLayout(resizingOnly: false);
		}
	}

	private Color A(int P_0, Setting P_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (TableAxis.A(P_0, P_1))
		{
			return Color.Red;
		}
		return BM.te;
	}

	private void A(Graphics P_0)
	{
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		bool flag = BKE.SlicesEnabled();
		bool flag2 = flag;
		if (BKe != null)
		{
			flag2 = BKe.SlicesEnabled();
		}
		if (flag || flag2)
		{
			if (BuU != null)
			{
				((ToolStripItem)BuU).Enabled = true;
			}
			if (BuM)
			{
				Table table;
				Setting setting;
				if (BM.QO == BM.b.BpG)
				{
					table = BKe;
					setting = BKI;
				}
				else
				{
					table = BKE;
					setting = BKg;
				}
				if (table == null)
				{
					return;
				}
				if (!((Control)BKj).Visible)
				{
					((Control)BKj).Visible = true;
				}
				int num = table.SliceCount();
				int num2 = ((Control)this).Height - (((Control)BKj).Height + 2);
				if (((Control)BKj).Top != num2)
				{
					((Control)BKj).Top = num2;
				}
				if (((Control)BKj).Left != 8)
				{
					((Control)BKj).Left = 8;
				}
				int num3 = ((Control)this).Width - 10 - ((Control)BKj).Left;
				if (((Control)BKj).Width != num3)
				{
					((Control)BKj).Width = num3;
				}
				if (BKj.BWB != num - 1)
				{
					BKj.BWB = num - 1;
				}
				if (table.UserSliceIndex > BKj.BWB)
				{
					table.UserSliceIndex = BKj.BWB;
				}
				if (BKj.BWb != table.UserSliceIndex)
				{
					BKj.BWb = table.UserSliceIndex;
				}
				if (!((Control)this).Controls.Contains((Control)(object)BKj))
				{
					((Control)this).Controls.Add((Control)(object)BKj);
				}
				int num4 = 0;
				if (setting != null)
				{
					num4 = setting.aS();
				}
				BKj.Bvx.Clear();
				for (int i = 0; i < num; i++)
				{
					BKj.Bvx.Add(new a.A());
					int num5 = table.SliceAxis.G().m(i);
					string text = ((setting == null) ? string.Empty : setting.A(num5, -1).Item1);
					BKj.Bvx[i].bat = text;
					if (BKe == null)
					{
						BKj.Bvx[i].baU = A(num5, BKg);
					}
					else if (BKi || BKJ)
					{
						BKj.Bvx[i].baU = BM.te;
					}
					else if (table == BKE && BKe.SliceAxis.A(num5, text, num4) == -1)
					{
						BKj.Bvx[i].baU = BM.tD;
					}
					else if (table == BKe && BKE.SliceAxis.A(num5, text, num4) == -1)
					{
						BKj.Bvx[i].baU = BM.tD;
					}
					else
					{
						BKj.Bvx[i].baU = A(num5, BKg);
					}
				}
				if (BM.QO == BM.b.BpG)
				{
					((Control)BKj.BWC).Visible = false;
				}
				else if (flag && BKE.SliceAxis.g() != null)
				{
					if (BKg != null)
					{
						((Control)BKj.BWC).Visible = !((SettingOrSpecialObject)BKg).l() || !PortFunction.A(BKg);
					}
					else
					{
						((Control)BKj.BWC).Visible = false;
					}
				}
				else
				{
					((Control)BKj.BWC).Visible = false;
				}
				((Control)BKj).Invalidate();
			}
			else if (((Control)BKj).Visible)
			{
				((Control)BKj).Visible = false;
			}
		}
		else
		{
			if (BuU != null)
			{
				((ToolStripItem)BuU).Enabled = false;
			}
			if (((Control)BKj).Visible)
			{
				((Control)BKj).Visible = false;
			}
			if (BKE.UserSliceIndex != 0)
			{
				BKE.UserSliceIndex = 0;
			}
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		UpdateLayout(resizingOnly: false);
	}

	private void b(object P_0, EventArgs P_1)
	{
		UpdateLayout(resizingOnly: false);
	}

	private void C(object P_0, EventArgs P_1)
	{
		b();
		UpdateLayout(resizingOnly: false);
	}

	private void c(object P_0, EventArgs P_1)
	{
		b();
		UpdateLayout(resizingOnly: false);
	}

	private void D(object P_0, EventArgs P_1)
	{
		b();
		UpdateLayout(resizingOnly: false);
	}

	private void d(object P_0, EventArgs P_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (base.B())
		{
			((Control)this).Invalidate(new Rectangle(0, 0, ((Control)this).Width, 85));
		}
	}

	private void E(object P_0, EventArgs P_1)
	{
		if (base.B() && BKj != null && ((Control)BKj).Visible)
		{
			((Control)BKj).Invalidate();
		}
	}

	private void e(object P_0, EventArgs P_1)
	{
		((Control)this).Invalidate();
	}

	private void F(object P_0, EventArgs P_1)
	{
		((Control)this).Invalidate();
	}

	private void f(object P_0, EventArgs P_1)
	{
		Table table = ((BM.QO != BM.b.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		Bun = table.GetCellValueString();
		try
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				A(val);
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
		if (base.B())
		{
			((Control)this).Invalidate();
		}
	}

	private void A(Table P_0)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.UserZoomLevel != 1 && P_0.HorizVertIndexPerUserSelectedCell.Count != 0)
		{
			int num = 2147483647;
			int num2 = -2147483648;
			Enumerator<Point> enumerator = P_0.HorizVertIndexPerUserSelectedCell.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Point current = enumerator.Current;
					num = Math.Min(num, ((Point)(ref current)).X);
					num2 = Math.Max(num2, ((Point)(ref current)).X);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Buo = (num + num2) / 2;
		}
		else
		{
			Buo = -1;
		}
	}

	private void A(Table P_0, out int[] P_1, out float[] P_2, out int P_3, out int P_4)
	{
		if (Buo == -1)
		{
			A(P_0);
		}
		int num = P_0.HorizAxisCount();
		int[] array = new int[num];
		float[] array2 = new float[num];
		int num2 = 2147483647;
		float num3 = 0f;
		int num4 = P_0.HorizAxis.G().m(0);
		int num5 = P_0.HorizAxis.G().m(num - 1);
		for (int i = 0; i < num; i++)
		{
			int num6 = (array[i] = P_0.HorizAxis.G().m(i));
			if (num5 - num4 == 0)
			{
				array2[i] = 75f;
			}
			else
			{
				array2[i] = 75f + (float)((num6 - num4) * (((Control)this).Width - 105)) / (float)(num5 - num4);
			}
			if (i != 0)
			{
				num2 = Math.Min(num2, (int)array2[i] - (int)num3);
			}
			num3 = array2[i];
		}
		if (P_0.UserZoomLevel == 1 || Buo == -1 || num <= 8)
		{
			P_1 = array;
			P_2 = array2;
			P_3 = 0;
			P_4 = num2;
			return;
		}
		int num7 = (75 + (((Control)this).Width - 30)) / 2;
		float num8 = array2[Buo] - (float)num7;
		for (int j = 0; j < array2.Length; j++)
		{
			array2[j] -= num8;
		}
		num3 = 0f;
		int num9 = 2147483647;
		int num10 = (((Control)this).Width - 30 - 75) / P_0.UserZoomLevel;
		int num11 = num7 - num10 / 2;
		int num12 = num7 + num10 / 2;
		P_3 = -1;
		List<int> val = new List<int>();
		List<float> val2 = new List<float>();
		for (int k = 0; k < array2.Length; k++)
		{
			if (array2[k] > (float)num11 && array2[k] < (float)num12)
			{
				val.Add(array[k]);
				float num13 = 75f + (array2[k] - (float)num11) * (float)P_0.UserZoomLevel;
				val2.Add(num13);
				if (P_3 == -1)
				{
					P_3 = k;
				}
				if (val2.Count > 1)
				{
					num9 = Math.Min(num9, (int)num13 - (int)num3);
				}
				num3 = num13;
			}
		}
		if (P_3 != -1)
		{
			P_1 = val.ToArray();
			P_2 = val2.ToArray();
			P_4 = num9;
		}
		else
		{
			P_1 = array;
			P_2 = array2;
			P_3 = 0;
			P_4 = num2;
		}
	}

	private int C()
	{
		if (BKj != null && ((Control)BKj).Visible)
		{
			return ((Control)BKj).Height + 50;
		}
		return 50;
	}

	private void A(object P_0, PaintEventArgs P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		Stopwatch val = new Stopwatch();
		val.Start();
		try
		{
			Table table;
			Setting setting;
			if (BM.QO == BM.b.BpG)
			{
				table = BKe;
				setting = BKH;
				_ = BKI;
			}
			else
			{
				table = BKE;
				setting = BKf;
				_ = BKg;
			}
			if (table == null)
			{
				return;
			}
			Graphics graphics = P_1.Graphics;
			graphics.SmoothingMode = (SmoothingMode)2;
			int num = table.HorizAxisCount();
			int num2 = table.VertAxisCount();
			int num3 = table.SliceCount();
			A(graphics, table);
			Rectangle clipRectangle = P_1.ClipRectangle;
			if (((Rectangle)(ref clipRectangle)).Top != 0)
			{
				goto IL_009d;
			}
			clipRectangle = P_1.ClipRectangle;
			if (((Rectangle)(ref clipRectangle)).Height > 85)
			{
				goto IL_009d;
			}
			goto end_IL_000c;
			IL_009d:
			Font val2 = new Font(((Control)this).Font.FontFamily, 8f);
			StringFormat val3 = new StringFormat();
			val3.Alignment = (StringAlignment)2;
			StringFormat val4 = new StringFormat();
			val4.Alignment = (StringAlignment)1;
			if (!table.HorizAxisEnabled() && !table.VertAxisEnabled())
			{
				val2.Dispose();
				val3.Dispose();
				val4.Dispose();
				return;
			}
			int num4 = C();
			int num5 = ((Control)this).Height - num4;
			int num6 = (num5 - 94) / 15;
			if (num6 <= 1)
			{
				val2.Dispose();
				val3.Dispose();
				val4.Dispose();
				return;
			}
			float num7 = ((float)((Control)this).Height - (float)(94 + num4)) / (float)(num6 - 1);
			A(table, out var array, out var array2, out var num8, out var num9);
			int num10 = 2147483647;
			int num11 = -2147483648;
			int num12 = 2147483647;
			int num13 = -2147483648;
			for (int i = 0; i < num3; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num14 = ((!table.SwapColumnsAndRows) ? table.TableDataSetting.B(k, j, i) : table.TableDataSetting.B(j, k, i));
						if (num14 > num11)
						{
							num11 = num14;
						}
						if (num14 < num10)
						{
							num10 = num14;
						}
						if (k >= num8 && k < num8 + array.Length)
						{
							if (num14 > num13)
							{
								num13 = num14;
							}
							if (num14 < num12)
							{
								num12 = num14;
							}
						}
					}
				}
			}
			int num15 = ((num12 != num13) ? (num5 - (num5 - 94) * -num12 / (num13 - num12)) : num5);
			Brush val5 = Brushes.Black;
			switch (BM.Tn)
			{
			case BM.r.BqG:
			case BM.r.Bqh:
				val5 = Brushes.Black;
				break;
			case BM.r.Bqg:
				val5 = Brushes.White;
				break;
			case BM.r.BqH:
				val5 = Brushes.White;
				break;
			}
			Pen val6 = Pens.LightGray;
			switch (BM.Tn)
			{
			case BM.r.BqG:
			case BM.r.Bqh:
				val6 = Pens.LightGray;
				break;
			case BM.r.Bqg:
				val6 = Pens.Gray;
				break;
			case BM.r.BqH:
				val6 = Pens.Gray;
				break;
			}
			int num16 = table.TableDataSetting.aS();
			for (int l = 0; l < num6; l++)
			{
				int num17 = ((l != 0) ? ((l != num6 - 1) ? (num12 + (num13 - num12) * l / (num6 - 1)) : num13) : num12);
				string text = bS.a(num17, num16, -1);
				float num18 = (float)num5 - num7 * (float)l;
				graphics.DrawString(text, val2, val5, 60f, num18 - 7f, val3);
				graphics.DrawLine(val6, 65f, num18, (float)(((Control)this).Width - 10), num18);
			}
			val6 = Pens.Black;
			switch (BM.Tn)
			{
			case BM.r.BqG:
			case BM.r.Bqh:
				val6 = Pens.Black;
				break;
			case BM.r.Bqg:
				val6 = Pens.White;
				break;
			case BM.r.BqH:
				val6 = Pens.White;
				break;
			}
			graphics.DrawLine(val6, 65, 94, 65, num5);
			if (num15 > 94 && num15 < num5)
			{
				graphics.DrawLine(val6, 65, num15, ((Control)this).Width - 10, num15);
			}
			if (table.HorizAxisEnabled())
			{
				string text2 = string.Empty;
				if (setting.aS() != 0 && setting.aS() != 82)
				{
					text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(setting.@as(), setting.aS(), false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
				}
				string text3 = ((SettingOrSpecialObject)setting).H();
				string text4 = (string.IsNullOrWhiteSpace(text3) ? ((SettingOrSpecialObject)setting).A(bz.aYt) : text3);
				graphics.DrawString(text4 + text2, val2, val5, (float)(65 + (((Control)this).Width - 10 - 65) / 2), (float)(((Control)this).Height - num4 + 30), val4);
			}
			A(graphics, table, ref val6, val5, val2, val4, num4, num5, num15, num2, setting, num8, array, array2, num9, num12, num13, num10, num11);
			val2.Dispose();
			val3.Dispose();
			val4.Dispose();
			if (BuP && Buq != Rectangle.Empty)
			{
				graphics.DrawRectangle(Pens.DodgerBlue, Buq);
			}
			end_IL_000c:;
		}
		catch
		{
		}
		val.Stop();
		N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFS(), (object)val.ElapsedMilliseconds, (object)((Control)this).Left, (object)((Control)this).Top), false);
	}

	private void A(Graphics P_0, Table P_1)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		Color val = ((!((SettingOrSpecialObject)BKE).l()) ? Color.Gray : BM.te);
		SolidBrush val2 = new SolidBrush(val);
		try
		{
			Font val3 = new Font(((Control)this).Font.FontFamily, 10f);
			try
			{
				int num = P_1.aS();
				string text = ((SettingOrSpecialObject)P_1).H();
				string text2 = (string.IsNullOrWhiteSpace(text) ? ((SettingOrSpecialObject)P_1).A(bz.aYt) : text);
				if (((Control)this).Focused)
				{
					Font val4 = new Font(((Control)this).Font.FontFamily, 10f, (FontStyle)1);
					try
					{
						P_0.DrawString(text2, val4, (Brush)(object)val2, 8f, 8f);
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
				else
				{
					P_0.DrawString(text2, val3, (Brush)(object)val2, 8f, 8f);
				}
				P_0.DrawString(BuN, val3, (Brush)(object)val2, 8f, 27f);
				P_0.DrawString(Bun, val3, (Brush)(object)val2, 8f, 46f);
				if (BM.QO != BM.b.BpG)
				{
					string text3 = string.Empty;
					if (num != 0 && num != 82)
					{
						text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + bS.A(P_1.@as(), num, false, 0);
					}
					if ((!BM.A(BKD.aXc, true) || BM.aE()) && !BM.C(((Setting)P_1).A()))
					{
						P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFs() + text3, val3, (Brush)(object)val2, 8f, 65f);
						return;
					}
					ValueTuple<string, string, bool> val5 = BKE.aX();
					P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFT() + val5.Item1 + (val5.Item3 ? string.Empty : text3), val3, (Brush)(object)val2, 8f, 65f);
				}
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
	}

	private void A(Graphics P_0, Table P_1, ref Pen P_2, Brush P_3, Font P_4, StringFormat P_5, int P_6, int P_7, int P_8, int P_9, Setting P_10, int P_11, int[] P_12, float[] P_13, int P_14, int P_15, int P_16, int P_17, int P_18)
	{
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		if (P_1.HorizAxisEnabled() && P_10 != null)
		{
			num = P_10.aS();
		}
		int userSliceIndex = P_1.UserSliceIndex;
		int num2 = Math.Max(Math.Min(P_14 - 2, 20), 2);
		bool flag = false;
		int num3 = BM.TV * 255 / 100;
		int num4 = BM.Tu * 255 / 100;
		int num5 = BM.Tv * 255 / 100;
		int num6 = BM.TW * 255 / 100;
		Setting setting = null;
		Setting setting2 = null;
		Setting setting3 = null;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		if (BKD.awo != null && !P_1.SwapColumnsAndRows)
		{
			setting = BKD.awo.a(((Setting)P_1).A());
			setting2 = BKD.awo.B(((Setting)P_1).A());
			setting3 = BKD.awo.b(((Setting)P_1).A());
			if (setting != null && setting2 != null && setting3 != null)
			{
				num7 = setting.ax();
				num8 = setting2.ax();
				num9 = setting3.ax();
			}
		}
		for (int i = 0; i < P_9; i++)
		{
			float num10 = 0f;
			float num11 = 0f;
			float num12 = 0f;
			float num13 = 0f;
			float num14 = 0f;
			for (int j = 0; j < P_12.Length; j++)
			{
				int num15 = P_12[j];
				float num16 = P_13[j];
				if (P_1.HorizAxisEnabled() && i == 0)
				{
					switch (BM.Tn)
					{
					case BM.r.BqG:
					case BM.r.Bqh:
						P_2 = Pens.Black;
						break;
					case BM.r.Bqg:
						P_2 = Pens.White;
						break;
					case BM.r.BqH:
						P_2 = Pens.White;
						break;
					}
					P_0.DrawLine(P_2, num16, (float)(((Control)this).Height - P_6 + 7), num16, (float)(((Control)this).Height - P_6 + 13));
					List<Setting.ListItems.A> val = P_10.d(0);
					bool flag2 = false;
					for (int k = 0; k < val.Count; k++)
					{
						if (val[k].bBv == num15)
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						string text = bS.a(num15, num, -1);
						SizeF val2 = P_0.MeasureString(text, P_4);
						float num17 = ((SizeF)(ref val2)).Width / 2f;
						if (j == 0 || num16 - num17 > num12 + 5f)
						{
							P_0.DrawString(text, P_4, P_3, num16, (float)(((Control)this).Height - P_6 + 15), P_5);
							num12 = num16 + num17;
						}
					}
					if ((num7 != 0 || num8 != 0 || num9 != 0) && P_11 + j >= num8 && P_11 + j <= num9)
					{
						float num18;
						if (P_15 == P_16)
						{
							num18 = P_7;
						}
						else
						{
							int num19 = P_1.TableDataSetting.B(P_11 + j, num7, userSliceIndex);
							num18 = (float)P_7 - (float)((num19 - P_15) * (((Control)this).Height - (94 + P_6))) / (float)(P_16 - P_15);
						}
						if (P_11 + j != num8)
						{
							Pen val3 = new Pen(Color.Red, 1f);
							try
							{
								val3.DashStyle = (DashStyle)1;
								P_0.DrawLine(val3, num13, num14, num16, num18);
							}
							finally
							{
								((System.IDisposable)val3)?.Dispose();
							}
						}
						num13 = num16;
						num14 = num18;
					}
				}
				bool flag3 = false;
				Enumerator<Point> enumerator = P_1.HorizVertIndexPerUserSelectedCell.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Point current = enumerator.Current;
						if (((Point)(ref current)).X == P_11 + j)
						{
							flag3 = true;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				int num20 = 2147483647;
				int num21 = -2147483648;
				bool flag4 = false;
				enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Point current2 = enumerator.Current;
						num20 = Math.Min(num20, ((Point)(ref current2)).Y);
						num21 = Math.Max(num21, ((Point)(ref current2)).Y);
						if (((Point)(ref current2)).Y == i)
						{
							flag4 = true;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				if (!flag4)
				{
					continue;
				}
				P_1.GetColumnIndexAndRowIndex(P_11 + j, i, out var columnIndex, out var rowIndex);
				int num22 = P_1.TableDataSetting.B(columnIndex, rowIndex, userSliceIndex);
				Color val4 = Color.Black;
				if (P_1.ShowBars)
				{
					if (flag3)
					{
						val4 = Color.Blue;
					}
					else if (P_17 == P_18)
					{
						val4 = l.A(num6, num4, num3);
					}
					else
					{
						int num23 = ((!BM.Tw) ? (num5 + (num6 - num5) * (num22 - P_17) / (P_18 - P_17)) : ((num5 >= num6) ? (num5 + (255 - (num5 - num6)) * (num22 - P_17) / (P_18 - P_17)) : (num5 - (255 - (num6 - num5)) * (num22 - P_17) / (P_18 - P_17))));
						if (num23 < 0)
						{
							num23 += 255;
						}
						else if (num23 > 255)
						{
							num23 -= 255;
						}
						val4 = l.A(num23, num4, num3);
					}
				}
				float num24 = ((P_15 != P_16) ? ((float)P_7 - (float)((num22 - P_15) * (((Control)this).Height - (94 + P_6))) / (float)(P_16 - P_15)) : ((float)P_7));
				int num25 = (int)Math.Max(Math.Min((float)P_8, num24), 94f);
				int num26 = (int)Math.Min(Math.Max((float)P_8, num24), (float)P_7);
				int num27 = num26 - num25;
				int num28 = (int)num16 - num2 / 2;
				int num29 = num28 + num2;
				bool flag5 = false;
				if (BM.QO != BM.b.BpG && ((Point)(ref BuT)).X != 0 && ((Point)(ref BuT)).Y != 0 && !BuP && ((Point)(ref BuT)).X >= num28 && ((Point)(ref BuT)).X <= num29)
				{
					if (num24 < (float)P_8)
					{
						if (((Point)(ref BuT)).Y >= num25 - 5 && ((Point)(ref BuT)).Y <= num25 + num27 / 2)
						{
							flag5 = true;
						}
					}
					else if (((Point)(ref BuT)).Y >= num26 - num27 / 2 && ((Point)(ref BuT)).Y <= num26 + 5)
					{
						flag5 = true;
					}
				}
				if (P_1.ShowBars && !flag)
				{
					if (flag5 && BuR.Count == 0)
					{
						P_0.FillRectangle(Brushes.DodgerBlue, num28, num25, num2, num27);
					}
					else
					{
						SolidBrush val5 = new SolidBrush(val4);
						try
						{
							P_0.FillRectangle((Brush)(object)val5, num28, num25, num2, num27);
						}
						finally
						{
							((System.IDisposable)val5)?.Dispose();
						}
					}
					switch (BM.Tn)
					{
					case BM.r.BqG:
					case BM.r.Bqh:
						P_2 = Pens.Black;
						break;
					case BM.r.Bqg:
						P_2 = Pens.White;
						break;
					case BM.r.BqH:
						P_2 = Pens.White;
						break;
					}
					P_0.DrawRectangle(P_2, num28, num25, num2, num27);
				}
				if (!flag)
				{
					if (flag3 && BuR.Count != 0)
					{
						P_0.FillEllipse(P_3, num16 - 3f, (float)(BuR[P_11 + j] - 3), 6f, 6f);
					}
					else if (flag5)
					{
						P_0.FillEllipse(P_3, num16 - 3f, num24 - 3f, 6f, 6f);
					}
					else if (flag3)
					{
						P_0.FillEllipse(Brushes.DodgerBlue, num16 - 3f, num24 - 3f, 6f, 6f);
					}
					else if (!P_1.ShowBars)
					{
						P_0.FillEllipse(P_3, num16 - 2f, num24 - 2f, 4f, 4f);
					}
				}
				flag = j == P_12.Length - 1;
				if (j != 0)
				{
					Pen val6 = P_2;
					if (num21 - num20 + 1 > 1)
					{
						val6 = (((num7 == 0 && num8 == 0 && num9 == 0) || P_11 + j < num8 || P_11 + j > num9) ? BuO[(i - num20) % BuO.Length] : BuO[1 + (i - num20) % (BuO.Length - 1)]);
					}
					P_0.DrawLine(val6, num10, num11, num16, num24);
				}
				num10 = num16;
				num11 = num24;
			}
		}
	}

	private void A(int P_0, int P_1, bool P_2)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 == -1 || P_1 == -1)
		{
			return;
		}
		List<Point> val = new List<Point>();
		val.Add(new Point(P_0, P_1));
		if (BM.QO == BM.b.BpG)
		{
			BKe.UserCurrentCellHorizVertIndex = new Point(P_0, P_1);
			BKe.HorizVertIndexPerUserSelectedCell = val;
			BKE.UserCurrentCellHorizVertIndex = new Point(P_0, P_1);
			BKE.HorizVertIndexPerUserSelectedCell = val;
		}
		else
		{
			BKE.UserCurrentCellHorizVertIndex = new Point(P_0, P_1);
			BKE.HorizVertIndexPerUserSelectedCell = val;
			if (BKe != null)
			{
				BKe.UserCurrentCellHorizVertIndex = new Point(P_0, P_1);
				BKe.HorizVertIndexPerUserSelectedCell = val;
			}
		}
		if (P_2)
		{
			A(BKE);
		}
	}

	protected override void MouseDownHandler(object sender, MouseEventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).Focus();
		Bus = false;
		BuP = false;
		Buq = Rectangle.Empty;
		if (!BKD.C() || (int)e.Button != 1048576)
		{
			return;
		}
		int num = C();
		int num2 = ((Control)this).Height - num;
		if (e.X <= 65 || e.X >= ((Control)this).Width - 10 || e.Y <= 89 || e.Y >= num2)
		{
			base.MouseDownHandler(sender, e);
		}
		else
		{
			if (BM.QO == BM.b.BpG || BKE == null || !((SettingOrSpecialObject)BKE).l() || !BKE.HorizAxisEnabled())
			{
				return;
			}
			Point val;
			for (int i = 1; i < BKE.HorizVertIndexPerUserSelectedCell.Count; i++)
			{
				val = BKE.HorizVertIndexPerUserSelectedCell[i];
				int y = ((Point)(ref val)).Y;
				val = BKE.HorizVertIndexPerUserSelectedCell[0];
				if (y != ((Point)(ref val)).Y)
				{
					return;
				}
			}
			if (BKE.HorizVertIndexPerUserSelectedCell.Count == 0)
			{
				return;
			}
			Bup = e.X;
			BuQ = e.Y;
			BuP = true;
			Buq = new Rectangle(e.X, e.Y, 2, 2);
			BuS = e.Y;
			int num3 = BKE.VertAxisCount();
			int num4 = BKE.SliceCount();
			val = BKE.HorizVertIndexPerUserSelectedCell[0];
			int y2 = ((Point)(ref val)).Y;
			int userSliceIndex = BKE.UserSliceIndex;
			A(BKE, out var array, out var array2, out var num5, out var num6);
			int num7 = 2147483647;
			int num8 = -2147483648;
			for (int j = 0; j < num4; j++)
			{
				for (int k = 0; k < num3; k++)
				{
					for (int l = num5; l < num5 + array.Length; l++)
					{
						int num9 = ((!BKE.SwapColumnsAndRows) ? BKE.TableDataSetting.B(l, k, j) : BKE.TableDataSetting.B(k, l, j));
						if (num9 > num8)
						{
							num8 = num9;
						}
						if (num9 < num7)
						{
							num7 = num9;
						}
					}
				}
			}
			int num10 = Math.Max(Math.Min(num6 - 2, 20), 2);
			int num11 = ((num7 != num8) ? (num2 - (num2 - 94) * -num7 / (num8 - num7)) : num2);
			BuR.Clear();
			Bur.Clear();
			List<int> val2 = new List<int>();
			for (int m = 0; m < array.Length; m++)
			{
				BKE.GetColumnIndexAndRowIndex(num5 + m, y2, out var columnIndex, out var rowIndex);
				int num12 = BKE.TableDataSetting.B(columnIndex, rowIndex, userSliceIndex);
				float num13 = ((num7 != num8) ? ((float)num2 - (float)((num12 - num7) * (((Control)this).Height - (94 + num))) / (float)(num8 - num7)) : ((float)num2));
				int num14 = (int)Math.Max(Math.Min((float)num11, num13), 94f);
				int num15 = (int)Math.Min(Math.Max((float)num11, num13), (float)num2);
				if (num13 < (float)num11)
				{
					val2.Add(num14);
				}
				else
				{
					val2.Add(num15);
				}
			}
			for (int n = 0; n < array.Length; n++)
			{
				_ = array[n];
				float num16 = array2[n];
				BKE.GetColumnIndexAndRowIndex(num5 + n, y2, out var columnIndex2, out var rowIndex2);
				int num17 = BKE.TableDataSetting.B(columnIndex2, rowIndex2, userSliceIndex);
				float num18 = ((num7 != num8) ? ((float)num2 - (float)((num17 - num7) * (((Control)this).Height - (94 + num))) / (float)(num8 - num7)) : ((float)num2));
				int num19 = (int)Math.Max(Math.Min((float)num11, num18), 94f);
				int num20 = (int)Math.Min(Math.Max((float)num11, num18), (float)num2);
				int num21 = num20 - num19;
				int num22 = (int)num16 - num10 / 2;
				int num23 = num22 + num10;
				if (e.X < num22 || e.X > num23)
				{
					continue;
				}
				bool flag = false;
				bool flag2 = false;
				if (num18 < (float)num11)
				{
					if (e.Y >= num19 - 5 && e.Y <= num19 + num21 / 2)
					{
						bool flag3 = false;
						Enumerator<Point> enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Point current = enumerator.Current;
								if (((Point)(ref current)).X == num5 + n)
								{
									flag3 = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						flag2 = !flag3;
						if (flag2)
						{
							BuR.Add(num5 + n, num19);
							Bur.Add(num5 + n, num19);
						}
						else
						{
							enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									Point current2 = enumerator.Current;
									BuR.Add(((Point)(ref current2)).X, val2[((Point)(ref current2)).X - num5]);
									Bur.Add(((Point)(ref current2)).X, val2[((Point)(ref current2)).X - num5]);
								}
							}
							finally
							{
								((System.IDisposable)enumerator).Dispose();
							}
							BuP = false;
						}
						flag = true;
					}
					else if (e.Y <= num20)
					{
						flag2 = true;
					}
				}
				else if (e.Y >= num20 - num21 / 2 && e.Y <= num20 + 5)
				{
					bool flag4 = false;
					Enumerator<Point> enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Point current3 = enumerator.Current;
							if (((Point)(ref current3)).X == num5 + n)
							{
								flag4 = true;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					flag2 = !flag4;
					if (flag2)
					{
						BuR.Add(num5 + n, num20);
						Bur.Add(num5 + n, num20);
					}
					else
					{
						enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Point current4 = enumerator.Current;
								BuR.Add(((Point)(ref current4)).X, val2[((Point)(ref current4)).X - num5]);
								Bur.Add(((Point)(ref current4)).X, val2[((Point)(ref current4)).X - num5]);
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						BuP = false;
					}
					flag = true;
				}
				else if (e.Y >= num19)
				{
					flag2 = true;
				}
				if (flag2)
				{
					if (flag)
					{
						BuP = false;
						Buq = Rectangle.Empty;
					}
					int num24 = num5 + n;
					val = BKE.HorizVertIndexPerUserSelectedCell[0];
					A(num24, ((Point)(ref val)).Y, false);
				}
				if (flag)
				{
					MenuNode.A(BKD.awj, BKE.TableDataSetting.C())?.A().A(BKE.TableDataSetting.A());
				}
				((Control)this).Invalidate();
				break;
			}
			((Control)this).BringToFront();
		}
	}

	protected override void MouseMoveHandler(object sender, MouseEventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Invalid comparison between Unknown and I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		if (BuR.Count == 0 || BM.QO == BM.b.BpG)
		{
			base.MouseMoveHandler(sender, e);
		}
		if (BKE == null || !((SettingOrSpecialObject)BKE).l() || !BKE.HorizAxisEnabled())
		{
			ref Point buT = ref BuT;
			int x = (((Point)(ref BuT)).Y = 0);
			((Point)(ref buT)).X = x;
			base.MouseMoveHandler(sender, e);
			return;
		}
		Point val;
		for (int i = 1; i < BKE.HorizVertIndexPerUserSelectedCell.Count; i++)
		{
			val = BKE.HorizVertIndexPerUserSelectedCell[i];
			int y = ((Point)(ref val)).Y;
			val = BKE.HorizVertIndexPerUserSelectedCell[0];
			if (y != ((Point)(ref val)).Y)
			{
				ref Point buT2 = ref BuT;
				int x = (((Point)(ref BuT)).Y = 0);
				((Point)(ref buT2)).X = x;
				base.MouseMoveHandler(sender, e);
				return;
			}
		}
		if (!BKD.C() || BKE.HorizVertIndexPerUserSelectedCell.Count == 0)
		{
			return;
		}
		if (!But.IsRunning)
		{
			But.Start();
		}
		else
		{
			if (But.ElapsedMilliseconds <= 50)
			{
				return;
			}
			But.Restart();
			if ((int)e.Button == 1048576)
			{
				if (BuP)
				{
					Buq = new Rectangle(Math.Min(e.X, Bup), Math.Min(e.Y, BuQ), Math.Abs(e.X - Bup), Math.Abs(e.Y - BuQ));
					A(BKE, out var array, out var array2, out var num3, out var _);
					List<Point> val2 = new List<Point>();
					for (int j = 0; j < array.Length; j++)
					{
						float num5 = array2[j];
						if (num5 >= (float)((Rectangle)(ref Buq)).Left && num5 <= (float)((Rectangle)(ref Buq)).Right)
						{
							int num6 = num3 + j;
							val = BKE.HorizVertIndexPerUserSelectedCell[0];
							val2.Add(new Point(num6, ((Point)(ref val)).Y));
						}
					}
					if (val2.Count != 0)
					{
						val = val2[0];
						int x2 = ((Point)(ref val)).X;
						val = val2[0];
						Point userCurrentCellHorizVertIndex = default(Point);
						((Point)(ref userCurrentCellHorizVertIndex))._002Ector(x2, ((Point)(ref val)).Y);
						if (BM.QO == BM.b.BpG)
						{
							BKe.UserCurrentCellHorizVertIndex = userCurrentCellHorizVertIndex;
							BKe.HorizVertIndexPerUserSelectedCell = val2;
							BKE.UserCurrentCellHorizVertIndex = userCurrentCellHorizVertIndex;
							BKE.HorizVertIndexPerUserSelectedCell = val2;
						}
						else
						{
							BKE.UserCurrentCellHorizVertIndex = userCurrentCellHorizVertIndex;
							BKE.HorizVertIndexPerUserSelectedCell = val2;
							if (BKe != null)
							{
								BKe.UserCurrentCellHorizVertIndex = userCurrentCellHorizVertIndex;
								BKe.HorizVertIndexPerUserSelectedCell = val2;
							}
						}
					}
				}
				else if (BuR.Count != 0)
				{
					int num7 = e.Y - BuS;
					if (Bus || num7 != 0)
					{
						Bus = true;
						A(BKE, out var array3, out var _, out var num8, out var _);
						int num10 = BKE.VertAxisCount();
						int num11 = BKE.SliceCount();
						int num12 = 2147483647;
						int num13 = -2147483648;
						for (int k = 0; k < num11; k++)
						{
							for (int l = 0; l < num10; l++)
							{
								for (int m = num8; m < num8 + array3.Length; m++)
								{
									int num14 = ((!BKE.SwapColumnsAndRows) ? BKE.TableDataSetting.B(m, l, k) : BKE.TableDataSetting.B(l, m, k));
									if (num14 > num13)
									{
										num13 = num14;
									}
									if (num14 < num12)
									{
										num12 = num14;
									}
								}
							}
						}
						int num15 = BKE.aR();
						int num16 = BKE.ar();
						val = BKE.HorizVertIndexPerUserSelectedCell[0];
						int y2 = ((Point)(ref val)).Y;
						int userSliceIndex = BKE.UserSliceIndex;
						int num17 = C();
						BKE.TableDataSetting.az();
						Enumerator<Point> enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Point current = enumerator.Current;
								BuR[((Point)(ref current)).X] = Bur[((Point)(ref current)).X] + num7;
								int num18 = ((Control)this).Height - num17;
								int num19 = num12 + (num18 - BuR[((Point)(ref current)).X]) * (num13 - num12) / (((Control)this).Height - (94 + num17));
								if (num19 >= num15 && num19 <= num16)
								{
									BKE.GetColumnIndexAndRowIndex(((Point)(ref current)).X, y2, out var columnIndex, out var rowIndex);
									if ((!BKE.AllCellsOnFirstColumnMustBeZero || columnIndex != 0) && (!BKE.AllCellsOnFirstRowMustBeZero || rowIndex != 0))
									{
										BKE.TableDataSetting.A(columnIndex, rowIndex, userSliceIndex, num19, true);
									}
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						BKE.TableDataSetting.i(true);
					}
				}
			}
			((Point)(ref BuT)).X = e.X;
			((Point)(ref BuT)).Y = e.Y;
			((Control)this).Invalidate();
		}
	}

	protected override void MouseUpHandler(object sender, MouseEventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		base.MouseUpHandler(sender, e);
		if (!BKD.C() || BKE == null || !((SettingOrSpecialObject)BKE).l())
		{
			return;
		}
		if (But.IsRunning)
		{
			But.Reset();
		}
		BuP = false;
		Buq = Rectangle.Empty;
		if (BuR.Count != 0)
		{
			if (Bus)
			{
				int num = C();
				int num2 = ((Control)this).Height - num;
				int num3 = BKE.VertAxisCount();
				int num4 = BKE.SliceCount();
				A(BKE, out var array, out var _, out var num5, out var _);
				int num7 = 2147483647;
				int num8 = -2147483648;
				for (int i = 0; i < num4; i++)
				{
					for (int j = 0; j < num3; j++)
					{
						for (int k = num5; k < num5 + array.Length; k++)
						{
							int num9 = ((!BKE.SwapColumnsAndRows) ? BKE.TableDataSetting.B(k, j, i) : BKE.TableDataSetting.B(j, k, i));
							if (num9 > num8)
							{
								num8 = num9;
							}
							if (num9 < num7)
							{
								num7 = num9;
							}
						}
					}
				}
				int num10 = BKE.aR();
				int num11 = BKE.ar();
				Point val = BKE.HorizVertIndexPerUserSelectedCell[0];
				int y = ((Point)(ref val)).Y;
				int userSliceIndex = BKE.UserSliceIndex;
				BKE.TableDataSetting.az();
				Enumerator<Point> enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Point current = enumerator.Current;
						int num12 = num7 + (num2 - BuR[((Point)(ref current)).X]) * (num8 - num7) / (((Control)this).Height - (94 + num));
						if (num12 < num10 || num12 > num11)
						{
							continue;
						}
						BKE.GetColumnIndexAndRowIndex(((Point)(ref current)).X, y, out var columnIndex, out var rowIndex);
						if ((BKE.AllCellsOnFirstColumnMustBeZero && columnIndex == 0) || (BKE.AllCellsOnFirstRowMustBeZero && rowIndex == 0))
						{
							continue;
						}
						BKE.TableDataSetting.A(columnIndex, rowIndex, userSliceIndex, num12, true);
						if (BKD.awo != null)
						{
							Setting setting = BKD.awo.a(((Setting)BKE).A());
							if (setting != null && setting.ax() == rowIndex)
							{
								BKD.awo.A(((Setting)BKE).A());
							}
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				BKE.TableDataSetting.i(true);
				BM.b(BKE.TableDataSetting.A());
			}
			MenuNode.A(BKD.awj, BKE.TableDataSetting.C())?.A().B();
			BuR.Clear();
			Bur.Clear();
		}
		Bus = false;
		A(BKE);
		((Control)this).Invalidate();
	}

	private void G(object P_0, EventArgs P_1)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (BKE != null)
		{
			if (BKE.HorizVertIndexPerUserSelectedCell.Count == 0)
			{
				BKE.UserCurrentCellHorizVertIndex = new Point(0, 0);
				BKE.HorizVertIndexPerUserSelectedCell.Add(new Point(0, 0));
			}
			BM.A((Control)(object)this);
		}
		((Control)this).Invalidate();
	}

	private void g(object P_0, EventArgs P_1)
	{
		BM.e();
		((Control)this).Invalidate();
	}

	private void H(object P_0, EventArgs P_1)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		BP num = (((TabControl)BM.QQ.rl).SelectedTab as ae).A();
		int selectedIndex = ((TabControl)BM.QQ.rl).SelectedIndex;
		if (num == BP.ua || BM.QQ.rl.A(selectedIndex) != this)
		{
			q.A((Control)(object)this);
			BM.QQ.rl.a(false);
		}
		else
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFt(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFU(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void h(object P_0, EventArgs P_1)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		int num = By.A((IWin32Window)(object)BM.QQ, BKD);
		if (num != 0)
		{
			Setting setting = BKD.A(num);
			if (setting != null)
			{
				BM.QQ.rl.a(setting as Table, new Rectangle(((Control)this).Left, ((Control)this).Top, ((Control)this).Width, ((Control)this).Height));
				H(null, null);
			}
		}
	}

	private void I(object P_0, EventArgs P_1)
	{
		BM.QQ.rl.B((Control)(object)this);
	}

	internal override void a(object P_0, EventArgs P_1)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG || !BKD.C() || BKE == null || !((SettingOrSpecialObject)BKE).l())
		{
			return;
		}
		bB bB = new bB(BKE);
		if ((int)((Form)bB).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
		{
			HashSet<DataIdAndAttrId> idsContained = BKE.GetIdsContained();
			BKD.a(idsContained);
			BKD.A(idsContained, BKd, BM.qf);
			BKD.A(idsContained);
			BM.QQ.rL.A(false, true, false, false);
			BM.M();
			BM.QQ.rL.B(false);
			if (BM.Qn != null)
			{
				BM.QQ.rL.b(false);
			}
			b();
			UpdateLayout(resizingOnly: false);
			((Control)this).Focus();
		}
		((Component)bB).Dispose();
	}

	private void i(object P_0, EventArgs P_1)
	{
		if (BKE != null)
		{
			BKE.ShowBars = !BKE.ShowBars;
		}
	}

	private void J(object P_0, EventArgs P_1)
	{
		if (BKE != null && BKe != null)
		{
			BKe.ShowBars = BKE.ShowBars;
		}
		((Control)this).Invalidate();
	}

	private void j(object P_0, EventArgs P_1)
	{
		A(!BuM);
	}

	private void K(object P_0, EventArgs P_1)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		if (((Control)this).ContextMenuStrip == null)
		{
			return;
		}
		foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
		{
			ToolStripMenuItem val = item;
			if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFu())
			{
				((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
				break;
			}
		}
	}

	private ContextMenuStrip c()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		ContextMenuStrip val = new ContextMenuStrip();
		((ToolStrip)val).BackColor = BM.tG;
		((ToolStrip)val).ForeColor = BM.te;
		((ToolStripDropDown)val).Opened += new EventHandler(K);
		if ((((TabControl)BM.QQ.rl).SelectedTab as ae).A() == BP.ua)
		{
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFV();
			((ToolStripItem)val2).Click += new EventHandler(h);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
		}
		ToolStripMenuItem val3 = new ToolStripMenuItem();
		((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFv();
		val3.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MS();
		((ToolStripItem)val3).Click += new EventHandler(I);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
		if (BKD.C())
		{
			ToolStripMenuItem val4 = new ToolStripMenuItem();
			((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pe();
			val4.ShortcutKeys = (Keys)114;
			((ToolStripItem)val4).Click += new EventHandler(a);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
		}
		ToolStripMenuItem val5 = new ToolStripMenuItem();
		((ToolStripItem)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFW();
		((ToolStripItem)val5).Click += new EventHandler(i);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val5);
		BuU = new ToolStripMenuItem();
		((ToolStripItem)BuU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFw();
		((ToolStripItem)BuU).Click += new EventHandler(j);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)BuU);
		ToolStripMenuItem val6 = new ToolStripMenuItem();
		((ToolStripItem)val6).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFu();
		((ToolStripItem)val6).Click += new EventHandler(H);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val6);
		return val;
	}

	internal void A(string P_0, int P_1, int P_2)
	{
		List<string> val = new List<string>();
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFX());
		int num = ((Control)this).Left - P_1;
		int num2 = ((Control)this).Top - P_2;
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBi() + BKF);
		if (BKE != null)
		{
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBJ() + BKE.InvertRows);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBj() + BKE.SwapColumnsAndRows);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFx() + BKE.ShowBars);
		}
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
		File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
	}

	internal void A(StreamReader P_0)
	{
		string text;
		while ((text = ((TextReader)P_0).ReadLine()) != null)
		{
			if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBi()))
			{
				BKF = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBi().Length));
				if (BKD.A(BKF) != null)
				{
					((cO)this).A(BKF);
				}
			}
			else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBK()))
			{
				BKF = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBK()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBK().Length));
				if (BKD.A(BKF) != null)
				{
					((cO)this).A(BKF);
				}
			}
			else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBJ()))
			{
				if (BKE != null)
				{
					BKE.InvertRows = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBJ().Length));
				}
			}
			else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBj()))
			{
				if (BKE != null)
				{
					BKE.SwapColumnsAndRows = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBj().Length));
				}
			}
			else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFx()))
			{
				if (BKE != null)
				{
					BKE.ShowBars = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFx().Length));
				}
			}
			else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFY()))
			{
				if (BKE != null)
				{
					BKE.ShowBars = bool.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFY()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFY().Length));
				}
			}
			else if (!text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bai()) && string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
	}

	private void D()
	{
		int currentHoriz = 0;
		int currentVert = 0;
		int currentSlice = 0;
		BKE.GetOperatingPoint(ref currentHoriz, ref currentVert, ref currentSlice);
		A(currentHoriz, currentVert, true);
		BKE.UserSliceIndex = currentSlice;
	}

	private void d()
	{
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == bottomSelectedVert)
		{
			if (rightSelectedHoriz - leftSelectedHoriz + 1 >= 3)
			{
				BKE.TableDataSetting.az();
				BKE.LineariseLeftToRight(topSelectedVert, leftSelectedHoriz, rightSelectedHoriz, BKe, forHorizAxisInsertion: false);
				BKE.TableDataSetting.i(true);
				((Control)this).Invalidate();
			}
		}
		else if (leftSelectedHoriz == rightSelectedHoriz)
		{
			if (bottomSelectedVert - topSelectedVert + 1 >= 3)
			{
				BKE.TableDataSetting.az();
				BKE.LineariseTopToBottom(leftSelectedHoriz, topSelectedVert, bottomSelectedVert, BKe);
				BKE.TableDataSetting.i(true);
				((Control)this).Invalidate();
			}
		}
		else
		{
			BKE.TableDataSetting.az();
			BKE.LineariseRange(leftSelectedHoriz, rightSelectedHoriz, topSelectedVert, bottomSelectedVert, BKe);
			BKE.TableDataSetting.i(true);
			((Control)this).Invalidate();
		}
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
	}

	private void E()
	{
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (rightSelectedHoriz - leftSelectedHoriz + 1 >= 3)
		{
			BKE.TableDataSetting.az();
			for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
			{
				BKE.LineariseLeftToRight(i, leftSelectedHoriz, rightSelectedHoriz, BKe, forHorizAxisInsertion: false);
			}
			BKE.TableDataSetting.i(true);
			((Control)this).Invalidate();
		}
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
	}

	private void e()
	{
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (bottomSelectedVert - topSelectedVert + 1 >= 3)
		{
			BKE.TableDataSetting.az();
			for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
			{
				BKE.LineariseTopToBottom(i, topSelectedVert, bottomSelectedVert, BKe);
			}
			BKE.TableDataSetting.i(true);
			((Control)this).Invalidate();
		}
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
	}

	internal bool A(KeyEventArgs P_0)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG)
		{
			return false;
		}
		if (!BKD.C())
		{
			return false;
		}
		if ((!P_0.Control || (int)P_0.KeyCode != 33) && (int)P_0.KeyData != 33 && (!P_0.Shift || (int)P_0.KeyCode != 33) && (!P_0.Control || (int)P_0.KeyCode != 34) && (int)P_0.KeyData != 34 && (!P_0.Shift || (int)P_0.KeyCode != 34) && (int)P_0.KeyData != 219 && (int)P_0.KeyData != 221 && (int)P_0.KeyData != 186 && (int)P_0.KeyData != 222 && (int)P_0.KeyData != 188 && (int)P_0.KeyData != 190)
		{
			return false;
		}
		if (!((SettingOrSpecialObject)BKE).l())
		{
			return true;
		}
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.IncreaseOrDecreaseSelectedCellValues(P_0);
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
		return true;
	}

	protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Invalid comparison between Unknown and I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Invalid comparison between Unknown and I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Invalid comparison between Unknown and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Invalid comparison between Unknown and I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Invalid comparison between Unknown and I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Invalid comparison between Unknown and I4
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between Unknown and I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Invalid comparison between Unknown and I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Invalid comparison between Unknown and I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Invalid comparison between Unknown and I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Invalid comparison between Unknown and I4
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Invalid comparison between Unknown and I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Invalid comparison between Unknown and I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Invalid comparison between Unknown and I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Invalid comparison between Unknown and I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Invalid comparison between Unknown and I4
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Invalid comparison between Unknown and I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Invalid comparison between Unknown and I4
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Invalid comparison between Unknown and I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Invalid comparison between Unknown and I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Invalid comparison between Unknown and I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Invalid comparison between Unknown and I4
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Invalid comparison between Unknown and I4
		e.IsInputKey = (int)e.KeyData == 68 || (e.Control && (int)e.KeyCode == 33) || (e.Control && (int)e.KeyCode == 34) || (e.Shift && (int)e.KeyCode == 33) || (e.Shift && (int)e.KeyCode == 34) || (int)e.KeyData == 33 || (int)e.KeyData == 34 || (int)e.KeyData == 219 || (int)e.KeyData == 221 || (int)e.KeyData == 186 || (int)e.KeyData == 222 || (int)e.KeyData == 188 || (int)e.KeyData == 190 || (int)e.KeyData == 37 || (int)e.KeyData == 38 || (int)e.KeyData == 39 || (int)e.KeyData == 40 || (int)e.KeyData == 65573 || (int)e.KeyData == 65574 || (int)e.KeyData == 65575 || (int)e.KeyData == 65576 || (int)e.KeyData == 131109 || (int)e.KeyData == 131110 || (int)e.KeyData == 131111 || (int)e.KeyData == 131112 || (e.Control && (int)e.KeyCode == 32) || (int)e.KeyData == 27 || (int)e.KeyData == 114 || (int)e.KeyData == 131162 || (int)e.KeyData == 131161 || (int)e.KeyData == 76 || (int)e.KeyData == 72 || (int)e.KeyData == 86 || (int)e.KeyData == 32 || (int)e.KeyData == 131139 || (int)e.KeyData == 131158 || (int)e.KeyData == 196645 || (int)e.KeyData == 196646 || (int)e.KeyData == 196647 || (int)e.KeyData == 196648;
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Invalid comparison between Unknown and I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Invalid comparison between Unknown and I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Invalid comparison between Unknown and I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Invalid comparison between Unknown and I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Invalid comparison between Unknown and I4
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Invalid comparison between Unknown and I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Invalid comparison between Unknown and I4
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Invalid comparison between Unknown and I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Invalid comparison between Unknown and I4
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Invalid comparison between Unknown and I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Invalid comparison between Unknown and I4
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Invalid comparison between Unknown and I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Invalid comparison between Unknown and I4
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Invalid comparison between Unknown and I4
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Invalid comparison between Unknown and I4
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Invalid comparison between Unknown and I4
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Invalid comparison between Unknown and I4
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Invalid comparison between Unknown and I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Invalid comparison between Unknown and I4
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Invalid comparison between Unknown and I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Invalid comparison between Unknown and I4
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Invalid comparison between Unknown and I4
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Invalid comparison between Unknown and I4
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Invalid comparison between Unknown and I4
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Invalid comparison between Unknown and I4
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Invalid comparison between Unknown and I4
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Invalid comparison between Unknown and I4
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Invalid comparison between Unknown and I4
		if (BKe != null && (BKi || BKJ) && BM.QO == BM.b.BpF)
		{
			return;
		}
		if ((int)e.KeyData == 68)
		{
			I(null, null);
		}
		if ((BKE != null && BKE.HorizVertIndexPerUserSelectedCell.Count == 0) || !BKD.C() || (e.Control && (int)e.KeyCode == 33) || (e.Control && (int)e.KeyCode == 34) || (e.Shift && (int)e.KeyCode == 33) || (e.Shift && (int)e.KeyCode == 34) || (int)e.KeyData == 33 || (int)e.KeyData == 34 || (int)e.KeyData == 219 || (int)e.KeyData == 221 || (int)e.KeyData == 186 || (int)e.KeyData == 222 || (int)e.KeyData == 188 || (int)e.KeyData == 190 || BKE == null)
		{
			return;
		}
		if ((int)e.KeyData == 37)
		{
			BKE.MoveSelectionLeft(BKe);
			A(BKE);
		}
		else if ((int)e.KeyData == 38)
		{
			BKE.MoveSelectionUp(BKe);
			A(BKE);
		}
		else if ((int)e.KeyData == 39)
		{
			BKE.MoveSelectionRight(BKe);
			A(BKE);
		}
		else if ((int)e.KeyData == 40)
		{
			BKE.MoveSelectionDown(BKe);
			A(BKE);
		}
		else if ((int)e.KeyData == 65573)
		{
			BKE.IncreaseSelectionSizeOnLeft(BKe);
			A(BKE);
		}
		else if ((int)e.KeyData == 65574)
		{
			BKE.IncreaseSelectionSizeOnTop(BKe);
			A(BKE);
		}
		else if ((int)e.KeyData == 65575)
		{
			BKE.IncreaseSelectionSizeOnRight(BKe);
			A(BKE);
		}
		else if ((int)e.KeyData == 65576)
		{
			BKE.IncreaseSelectionSizeOnBottom(BKe);
			A(BKE);
		}
		else if ((int)e.KeyData == 131109)
		{
			BKE.DecreaseSelectionSizeOnRight();
			A(BKE);
		}
		else if ((int)e.KeyData == 131110)
		{
			BKE.DecreaseSelectionSizeOnBottom();
			A(BKE);
		}
		else if ((int)e.KeyData == 131111)
		{
			BKE.DecreaseSelectionSizeOnLeft();
			A(BKE);
		}
		else if ((int)e.KeyData == 131112)
		{
			BKE.DecreaseSelectionSizeOnTop();
			A(BKE);
		}
		else if ((e.Control && (int)e.KeyCode == 32) || (int)e.KeyData == 27)
		{
			Point userCurrentCellHorizVertIndex = BKE.UserCurrentCellHorizVertIndex;
			int x = ((Point)(ref userCurrentCellHorizVertIndex)).X;
			userCurrentCellHorizVertIndex = BKE.UserCurrentCellHorizVertIndex;
			A(x, ((Point)(ref userCurrentCellHorizVertIndex)).Y, true);
		}
		else
		{
			if (!((SettingOrSpecialObject)BKE).l() || BM.QO == BM.b.BpG)
			{
				return;
			}
			if ((int)e.KeyData == 114)
			{
				a(null, null);
			}
			else if ((int)e.KeyData == 131162)
			{
				BM.QQ.ak(null, null);
			}
			else if ((int)e.KeyData == 131161)
			{
				BM.QQ.aL(null, null);
			}
			else if ((int)e.KeyData == 76)
			{
				d();
			}
			else if ((int)e.KeyData == 72)
			{
				E();
			}
			else if ((int)e.KeyData == 86)
			{
				this.e();
			}
			else if ((int)e.KeyData == 32)
			{
				D();
			}
			else if ((int)e.KeyData == 131139)
			{
				BKE.CopyCellValuesToClipboard(BKe);
			}
			else if ((int)e.KeyData == 131158)
			{
				BKE.C(BKe, null);
			}
			else if (BKe != null || (!BKi && !BKJ) || BM.QO != 0)
			{
				if ((int)e.KeyData == 196645)
				{
					BKE.A(BKe, null);
					A(BKE);
				}
				else if ((int)e.KeyData == 196646)
				{
					BKE.B(BKe, null);
					A(BKE);
				}
				else if ((int)e.KeyData == 196647)
				{
					BKE.a(BKe, null);
					A(BKE);
				}
				else if ((int)e.KeyData == 196648)
				{
					BKE.b(BKe, null);
					A(BKE);
				}
			}
		}
	}

	private void k(object P_0, EventArgs P_1)
	{
		if (BKE != null)
		{
			Bum.a(BKE.UserZoomLevel);
			((Control)Bum).Invalidate();
			((Control)this).Invalidate();
		}
	}
}
internal class Db : cO
{
	private new enum A
	{
		bae,
		baF
	}

	private new struct a
	{
		internal A baf;

		internal int baG;

		internal int bag;

		internal float baH;

		public string ToString()
		{
			return string.Concat(new string[7]
			{
				((object)baf).ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJi(),
				baG.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJJ(),
				bag.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BJj(),
				baH.ToString()
			});
		}
	}

	private const float Buu = 0f;

	private const float BuV = -2f;

	private const float Buv = 1f;

	private const int BuW = 64;

	private const int Buw = 16;

	private const int BuX = 20;

	private bool Bux;

	private string BuY;

	private string Buy;

	private SolidBrush BuZ;

	private Pen Buz;

	private Pen BVA = new Pen(Color.FromArgb(200, 200, 200), 1f);

	private Pen BVa = new Pen(Color.FromArgb(100, 100, 100), 1f);

	private Pen BVB = new Pen(Color.FromArgb(0, 0, 0), 1f);

	private Pen BVb = new Pen(Color.Blue, 3f);

	private Font BVC;

	private StringFormat BVc = new StringFormat();

	private StringFormat BVD = new StringFormat();

	private int[] BVd = new int[4];

	private PointF[] BVE = (PointF[])(object)new PointF[4];

	private Color[] BVe = (Color[])(object)new Color[4];

	private GraphicsPath BVF = new GraphicsPath();

	private PathGradientBrush BVf;

	private int[] BVG = new int[64];

	private int[] BVg = new int[64];

	private AxisBehaviour BVH = AxisBehaviour.Continuous;

	private AxisBehaviour BVh = AxisBehaviour.Continuous;

	private int[,,] BVI = new int[16, 64, 64];

	private int BVi;

	private int BVJ;

	private float[,] BVj = new float[64, 64];

	private float[,] BVK = new float[64, 64];

	private float[,] BVk = new float[64, 64];

	private float[,] BVL = new float[64, 64];

	private float[,] BVl = new float[64, 64];

	private float[,] BVM = new float[64, 64];

	private float[,] BVm = new float[64, 64];

	private a[] BVN = new a[7938];

	private Label BVn = new Label();

	private bool BVO;

	private bool BVo;

	private int BVP;

	private int BVp;

	private float BVQ;

	private float BVq;

	private bool BVR;

	private ToolStripMenuItem BVr;

	internal Db(Framework P_0, Framework P_1, Rectangle P_2, bool P_3)
		: base(P_0, P_1, P_2, P_3)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).DoubleBuffered = true;
		if (BVO)
		{
			((Control)BVn).ForeColor = BM.te;
			((Control)BVn).Left = 10;
			((Control)BVn).Top = 100;
			((Control)BVn).AutoSize = true;
			((Control)BVn).MinimumSize = new Size(170, 0);
			((Control)BVn).MaximumSize = new Size(170, 600);
			((Control)this).Controls.Add((Control)(object)BVn);
		}
		((Control)this).GotFocus += new EventHandler(G);
		((Control)this).LostFocus += new EventHandler(g);
		BVC = new Font(((Control)this).Font.FontFamily, 8f);
	}

	internal override void A(int P_0)
	{
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		Setting setting = BKD.A(P_0);
		if (setting != null)
		{
			BKE = setting as Table;
		}
		else
		{
			BKE = null;
		}
		if (BKE != null)
		{
			BKF = ((Setting)BKE).A();
			if (BKE != null && BKd != null)
			{
				BKe = BKd.A(P_0) as Table;
			}
			else
			{
				BKe = null;
			}
		}
		else
		{
			BKe = null;
		}
		if (BKE != null && BKe != null)
		{
			if (BKe.InvertRows != BKE.InvertRows)
			{
				BKe.InvertRows = BKE.InvertRows;
			}
			if (BKe.SwapColumnsAndRows != BKE.SwapColumnsAndRows)
			{
				BKe.SwapColumnsAndRows = BKE.SwapColumnsAndRows;
			}
			if (BKe.HorizVertIndexPerUserSelectedCell != BKE.HorizVertIndexPerUserSelectedCell)
			{
				BKe.HorizVertIndexPerUserSelectedCell = BKE.HorizVertIndexPerUserSelectedCell;
			}
		}
		BKi = BKD.B() && BKD.b() && BKE != null && BKE.J();
		BKJ = BKd != null && BKd.B() && BKd.b() && BKe != null && BKe.J();
		if ((BM.QO != BM.b.BpG || BKd == null) ? BKi : BKJ)
		{
			Label val = new Label();
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + ((SettingOrSpecialObject)BKE).A(bz.aYt) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAO();
			((Control)val).ForeColor = BM.te;
			((Control)val).BackColor = Color.Transparent;
			((Control)val).AutoSize = true;
			((Control)val).Left = 10;
			((Control)val).Top = 10;
			((Control)this).Controls.Add((Control)(object)val);
			return;
		}
		if (BKE != null)
		{
			((Setting)BKE).A(new EventHandler(d));
			BKE.TableDataSetting.A(new EventHandler(F));
			BKE.OnUserSelectionChanged += new EventHandler(b);
			BKE.OnInvertRows += new EventHandler(C);
			BKE.OnSwapColumnsAndRows += new EventHandler(c);
			BKE.OnUserSliceIndexChanged += new EventHandler(B);
			BKE.OnViewingAngleChanged += new EventHandler(f);
		}
		((Control)this).Paint += new PaintEventHandler(A);
		global::A.A.A(new EventHandler(e));
		global::A.A.A((global::A.D)e);
		BM.D(new EventHandler(e));
		BM.E(new EventHandler(e));
		if (BuZ != null)
		{
			((Brush)BuZ).Dispose();
		}
		BuZ = new SolidBrush(BM.te);
		switch (BM.Tn)
		{
		case BM.r.BqG:
		case BM.r.Bqh:
			Buz = Pens.Black;
			break;
		case BM.r.Bqg:
			Buz = Pens.Gray;
			break;
		case BM.r.BqH:
			Buz = Pens.Gray;
			break;
		}
		BVc.Alignment = (StringAlignment)0;
		BVD.Alignment = (StringAlignment)2;
		b();
		if (BKE != null)
		{
			if (BM.QO == BM.b.BpG && BKe != null)
			{
				BuY = BKe.GetSelectionRangeString(BKH, BKh);
				Buy = BKe.GetCellValueString();
			}
			else
			{
				BuY = BKE.GetSelectionRangeString(BKf, BKG);
				Buy = BKE.GetCellValueString();
			}
		}
		F(null, null);
		((Control)this).Invalidate();
		((Control)this).ContextMenuStrip = c();
	}

	protected override void a()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		try
		{
			((Control)this).Paint -= new PaintEventHandler(A);
			if (BKE != null)
			{
				BKE.a(new EventHandler(d));
				BKE.TableDataSetting.a(new EventHandler(F));
				BKE.OnUserSelectionChanged -= new EventHandler(b);
				BKE.OnInvertRows -= new EventHandler(C);
				BKE.OnSwapColumnsAndRows -= new EventHandler(c);
				BKE.OnUserSliceIndexChanged -= new EventHandler(B);
				BKE.OnViewingAngleChanged -= new EventHandler(f);
				if (BKE.HorizAxis != null && BKE.HorizAxis.F() != null)
				{
					BKE.HorizAxis.F().a(new EventHandler(F));
				}
				if (BKE.VertAxis != null && BKE.VertAxis.F() != null)
				{
					BKE.VertAxis.F().a(new EventHandler(F));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.F() != null)
				{
					BKE.SliceAxis.F().a(new EventHandler(F));
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.f() != null)
				{
					BKE.HorizAxis.f().a(new EventHandler(F));
				}
				if (BKE.VertAxis != null && BKE.VertAxis.f() != null)
				{
					BKE.VertAxis.f().a(new EventHandler(F));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.f() != null)
				{
					BKE.SliceAxis.f().a(new EventHandler(F));
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.G() != null)
				{
					BKE.HorizAxis.G().a(new EventHandler(F));
				}
				if (BKE.VertAxis != null && BKE.VertAxis.G() != null)
				{
					BKE.VertAxis.G().a(new EventHandler(F));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.G() != null)
				{
					BKE.SliceAxis.G().a(new EventHandler(F));
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.g() != null)
				{
					BKE.HorizAxis.g().a(new EventHandler(D));
				}
				if (BKE.VertAxis != null && BKE.VertAxis.g() != null)
				{
					BKE.VertAxis.g().a(new EventHandler(D));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.g() != null)
				{
					BKE.SliceAxis.g().a(new EventHandler(D));
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.H() != null)
				{
					BKE.HorizAxis.H().a(new EventHandler(F));
				}
				if (BKE.VertAxis != null && BKE.VertAxis.H() != null)
				{
					BKE.VertAxis.H().a(new EventHandler(F));
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.H() != null)
				{
					BKE.SliceAxis.H().a(new EventHandler(F));
				}
			}
			if (BKf != null)
			{
				BKf.a(new EventHandler(d));
			}
			if (BKG != null)
			{
				BKG.a(new EventHandler(d));
			}
			if (BKg != null)
			{
				BKg.a(new EventHandler(E));
			}
			global::A.A.a(new EventHandler(e));
			global::A.A.a((global::A.D)e);
			BM.d(new EventHandler(e));
			BM.e(new EventHandler(e));
			if (((Control)this).ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				((ToolStripItem)item).Click -= new EventHandler(a);
				((ToolStripItem)item).Click -= new EventHandler(i);
				((ToolStripItem)item).Click -= new EventHandler(J);
				((ToolStripItem)item).Click -= new EventHandler(I);
				((ToolStripItem)item).Click -= new EventHandler(H);
			}
			((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(j);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		try
		{
			BVC.Dispose();
			if (BuZ != null)
			{
				((Brush)BuZ).Dispose();
			}
			BVA.Dispose();
			BVa.Dispose();
			BVB.Dispose();
			BVb.Dispose();
		}
		catch
		{
		}
		a();
		try
		{
			((Control)this).GotFocus -= new EventHandler(G);
			((Control)this).LostFocus -= new EventHandler(g);
			BM.QQ.b(new EventHandler(((cO)this).A));
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = ((Panel)this).ToString();
		if (BKE != null)
		{
			text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY() + ((object)BKE).ToString();
		}
		return string.Concat(new string[5]
		{
			text,
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAZ(),
			((Control)this).Left.ToString(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAz(),
			((Control)this).Top.ToString()
		});
	}

	[SpecialName]
	internal new Table B()
	{
		return BKE;
	}

	private new void b()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected O, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected O, but got Unknown
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected O, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected O, but got Unknown
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected O, but got Unknown
		bool flag = ((BM.QO != BM.b.BpG || BKd == null) ? BKi : BKJ);
		if (flag || BKE == null)
		{
			return;
		}
		Table table = ((BM.QO != BM.b.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.F() != null)
		{
			BKE.HorizAxis.F().a(new EventHandler(F));
			BKE.HorizAxis.F().A(new EventHandler(F));
		}
		if (BKE.VertAxis != null && BKE.VertAxis.F() != null)
		{
			BKE.VertAxis.F().a(new EventHandler(F));
			BKE.VertAxis.F().A(new EventHandler(F));
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.F() != null)
		{
			BKE.SliceAxis.F().a(new EventHandler(F));
			BKE.SliceAxis.F().A(new EventHandler(F));
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.f() != null)
		{
			BKE.HorizAxis.f().a(new EventHandler(F));
			BKE.HorizAxis.f().A(new EventHandler(F));
		}
		if (BKE.VertAxis != null && BKE.VertAxis.f() != null)
		{
			BKE.VertAxis.f().a(new EventHandler(F));
			BKE.VertAxis.f().A(new EventHandler(F));
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.f() != null)
		{
			BKE.SliceAxis.f().a(new EventHandler(F));
			BKE.SliceAxis.f().A(new EventHandler(F));
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.G() != null)
		{
			BKE.HorizAxis.G().a(new EventHandler(F));
			BKE.HorizAxis.G().A(new EventHandler(F));
		}
		if (BKE.VertAxis != null && BKE.VertAxis.G() != null)
		{
			BKE.VertAxis.G().a(new EventHandler(F));
			BKE.VertAxis.G().A(new EventHandler(F));
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.G() != null)
		{
			BKE.SliceAxis.G().a(new EventHandler(F));
			BKE.SliceAxis.G().A(new EventHandler(F));
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.H() != null)
		{
			BKE.HorizAxis.H().a(new EventHandler(F));
			BKE.HorizAxis.H().A(new EventHandler(F));
		}
		if (BKE.VertAxis != null && BKE.VertAxis.H() != null)
		{
			BKE.VertAxis.H().a(new EventHandler(F));
			BKE.VertAxis.H().A(new EventHandler(F));
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.H() != null)
		{
			BKE.SliceAxis.H().a(new EventHandler(F));
			BKE.SliceAxis.H().A(new EventHandler(F));
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.g() != null)
		{
			BKE.HorizAxis.g().a(new EventHandler(D));
			BKE.HorizAxis.g().A(new EventHandler(D));
			BKf = BKE.HorizAxis.h();
			if (BKf != null)
			{
				BKf.a(new EventHandler(d));
				BKf.A(new EventHandler(d));
			}
			if (BKe != null && BKe.HorizAxis != null && BKe.HorizAxis.g() != null)
			{
				BKH = BKe.HorizAxis.h();
			}
		}
		if (BKE.VertAxis != null && BKE.VertAxis.g() != null)
		{
			BKE.VertAxis.g().a(new EventHandler(D));
			BKE.VertAxis.g().A(new EventHandler(D));
			BKG = BKE.VertAxis.h();
			if (BKG != null)
			{
				BKG.a(new EventHandler(d));
				BKG.A(new EventHandler(d));
			}
			if (BKe != null && BKe.VertAxis != null && BKe.VertAxis.g() != null)
			{
				BKh = BKe.VertAxis.h();
			}
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.g() != null)
		{
			BKE.SliceAxis.g().a(new EventHandler(D));
			BKE.SliceAxis.g().A(new EventHandler(D));
			BKg = BKE.SliceAxis.h();
			if (BKg != null)
			{
				BKg.a(new EventHandler(E));
				BKg.A(new EventHandler(E));
			}
			if (BKe != null && BKe.SliceAxis != null && BKe.SliceAxis.g() != null)
			{
				BKI = BKe.SliceAxis.h();
			}
		}
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		if (BKE != null && !((BM.QO != BM.b.BpG || BKd == null) ? BKi : BKJ))
		{
			F(null, null);
		}
	}

	[SpecialName]
	internal new void A(bool P_0)
	{
		if (Bux != P_0)
		{
			Bux = P_0;
			UpdateLayout(resizingOnly: false);
		}
	}

	private Color A(int P_0, Setting P_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (TableAxis.A(P_0, P_1))
		{
			return Color.Red;
		}
		return BM.te;
	}

	private void A(Graphics P_0)
	{
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		bool flag = BKE.SlicesEnabled();
		bool flag2 = flag;
		if (BKe != null)
		{
			flag2 = BKe.SlicesEnabled();
		}
		if (flag || flag2)
		{
			if (BVr != null)
			{
				((ToolStripItem)BVr).Enabled = true;
			}
			if (Bux)
			{
				Table table;
				Setting setting;
				if (BM.QO == BM.b.BpG)
				{
					table = BKe;
					setting = BKI;
				}
				else
				{
					table = BKE;
					setting = BKg;
				}
				if (table == null)
				{
					return;
				}
				if (!((Control)BKj).Visible)
				{
					((Control)BKj).Visible = true;
				}
				int num = table.SliceCount();
				int num2 = ((Control)this).Height - (((Control)BKj).Height + 2);
				if (((Control)BKj).Top != num2)
				{
					((Control)BKj).Top = num2;
				}
				if (((Control)BKj).Left != 8)
				{
					((Control)BKj).Left = 8;
				}
				int num3 = ((Control)this).Width - 10 - ((Control)BKj).Left;
				if (((Control)BKj).Width != num3)
				{
					((Control)BKj).Width = num3;
				}
				if (BKj.BWB != num - 1)
				{
					BKj.BWB = num - 1;
				}
				if (table.UserSliceIndex > BKj.BWB)
				{
					table.UserSliceIndex = BKj.BWB;
				}
				if (BKj.BWb != table.UserSliceIndex)
				{
					BKj.BWb = table.UserSliceIndex;
				}
				if (!((Control)this).Controls.Contains((Control)(object)BKj))
				{
					((Control)this).Controls.Add((Control)(object)BKj);
				}
				int num4 = 0;
				if (setting != null)
				{
					num4 = setting.aS();
				}
				BKj.Bvx.Clear();
				for (int i = 0; i < num; i++)
				{
					BKj.Bvx.Add(new cO.a.A());
					int num5 = table.SliceAxis.G().m(i);
					string text = ((setting == null) ? string.Empty : setting.A(num5, -1).Item1);
					BKj.Bvx[i].bat = text;
					if (BKe == null)
					{
						BKj.Bvx[i].baU = A(num5, BKg);
					}
					else if (BKi || BKJ)
					{
						BKj.Bvx[i].baU = BM.te;
					}
					else if (table == BKE && BKe.SliceAxis.A(num5, text, num4) == -1)
					{
						BKj.Bvx[i].baU = BM.tD;
					}
					else if (table == BKe && BKE.SliceAxis.A(num5, text, num4) == -1)
					{
						BKj.Bvx[i].baU = BM.tD;
					}
					else
					{
						BKj.Bvx[i].baU = A(num5, BKg);
					}
				}
				if (BM.QO == BM.b.BpG)
				{
					((Control)BKj.BWC).Visible = false;
				}
				else if (flag && BKE.SliceAxis.g() != null)
				{
					if (BKg != null)
					{
						((Control)BKj.BWC).Visible = !((SettingOrSpecialObject)BKg).l() || !PortFunction.A(BKg);
					}
					else
					{
						((Control)BKj.BWC).Visible = false;
					}
				}
				else
				{
					((Control)BKj.BWC).Visible = false;
				}
				((Control)BKj).Invalidate();
			}
			else if (((Control)BKj).Visible)
			{
				((Control)BKj).Visible = false;
			}
		}
		else
		{
			if (BVr != null)
			{
				((ToolStripItem)BVr).Enabled = false;
			}
			if (((Control)BKj).Visible)
			{
				((Control)BKj).Visible = false;
			}
			if (BKE.UserSliceIndex != 0)
			{
				BKE.UserSliceIndex = 0;
			}
		}
	}

	private void C()
	{
		if (BKE != null && !((BM.QO != BM.b.BpG || BKd == null) ? BKi : BKJ))
		{
			if (BM.QO == BM.b.BpG && BKe != null)
			{
				BuY = BKe.GetSelectionRangeString(BKH, BKh);
				Buy = BKe.GetCellValueString();
			}
			else
			{
				BuY = BKE.GetSelectionRangeString(BKf, BKG);
				Buy = BKE.GetCellValueString();
			}
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		C();
		F(null, null);
		if (BKE != null && BKE.UserSliceIndex >= 0 && BKE.UserSliceIndex <= BKj.BWB)
		{
			BKj.BWb = BKE.UserSliceIndex;
			((Control)BKj).Invalidate();
		}
	}

	private void b(object P_0, EventArgs P_1)
	{
		C();
		if (BVO)
		{
			UpdateLayout(resizingOnly: false);
		}
		((Control)this).Invalidate();
	}

	private void C(object P_0, EventArgs P_1)
	{
		b();
		C();
		F(null, null);
	}

	private void c(object P_0, EventArgs P_1)
	{
		b();
		C();
		F(null, null);
	}

	private void D(object P_0, EventArgs P_1)
	{
		b();
		C();
		F(null, null);
	}

	private void d(object P_0, EventArgs P_1)
	{
		if (base.B())
		{
			((Control)this).Invalidate();
		}
	}

	private void E(object P_0, EventArgs P_1)
	{
		if (base.B() && BKj != null && ((Control)BKj).Visible)
		{
			((Control)BKj).Invalidate();
		}
	}

	private void e(object P_0, EventArgs P_1)
	{
		((Control)this).Invalidate();
	}

	private void F(object P_0, EventArgs P_1)
	{
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		if (BKE == null || (BKe != null && (BKi || BKJ) && BM.QO == BM.b.BpF))
		{
			return;
		}
		Table table = ((BM.QO != BM.b.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		Buy = table.GetCellValueString();
		try
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				A(val);
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
		try
		{
			bool flag = table.HorizAxisEnabled();
			bool flag2 = table.VertAxisEnabled();
			if (!flag && !flag2)
			{
				return;
			}
			bool flag3 = false;
			int num = table.HorizAxisCount();
			if (num == 1)
			{
				num = 2;
				flag3 = true;
			}
			bool flag4 = false;
			int num2 = table.VertAxisCount();
			if (num2 == 1)
			{
				num2 = 2;
				flag4 = true;
			}
			int num3 = table.SliceCount();
			if (num > 64)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFy());
			}
			if (num2 > 64)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFy());
			}
			if (num3 > 16)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFZ());
			}
			if (flag && table.HorizAxis.G() != null)
			{
				if (flag3)
				{
					BVG[0] = table.HorizAxis.G().m(0);
					BVG[1] = table.HorizAxis.G().m(0) + 1;
				}
				else
				{
					for (int i = 0; i < num; i++)
					{
						BVG[i] = table.HorizAxis.G().m(i);
					}
				}
				BVH = table.HorizAxis.I();
			}
			else
			{
				BVG[0] = 0;
				BVG[1] = 1;
			}
			if (flag2 && table.VertAxis.G() != null)
			{
				if (flag4)
				{
					BVg[0] = table.VertAxis.G().m(0);
					BVg[1] = table.VertAxis.G().m(0) + 1;
				}
				else
				{
					for (int j = 0; j < num2; j++)
					{
						if (table.InvertRows)
						{
							BVg[j] = table.VertAxis.G().m(num2 - 1 - j);
						}
						else
						{
							BVg[j] = table.VertAxis.G().m(j);
						}
					}
				}
				BVh = table.VertAxis.I();
			}
			else
			{
				BVg[0] = 0;
				BVg[1] = 1;
			}
			if (flag && flag2)
			{
				if (flag3 && flag4)
				{
					return;
				}
				if (!flag3 && !flag4)
				{
					for (int k = 0; k < num3; k++)
					{
						for (int j = 0; j < num2; j++)
						{
							for (int i = 0; i < num; i++)
							{
								if (table.SwapColumnsAndRows)
								{
									if (table.InvertRows)
									{
										BVI[k, j, i] = table.TableDataSetting.B(num2 - 1 - j, i, k);
									}
									else
									{
										BVI[k, j, i] = table.TableDataSetting.B(j, i, k);
									}
								}
								else if (table.InvertRows)
								{
									BVI[k, j, i] = table.TableDataSetting.B(i, num2 - 1 - j, k);
								}
								else
								{
									BVI[k, j, i] = table.TableDataSetting.B(i, j, k);
								}
							}
						}
					}
				}
				else if (flag3)
				{
					for (int l = 0; l < num3; l++)
					{
						for (int j = 0; j < num2; j++)
						{
							if (table.SwapColumnsAndRows)
							{
								if (table.InvertRows)
								{
									BVI[l, j, 0] = table.TableDataSetting.B(num2 - 1 - j, 0, l);
									BVI[l, j, 1] = table.TableDataSetting.B(num2 - 1 - j, 0, l);
								}
								else
								{
									BVI[l, j, 0] = table.TableDataSetting.B(j, 0, l);
									BVI[l, j, 1] = table.TableDataSetting.B(j, 0, l);
								}
							}
							else if (table.InvertRows)
							{
								BVI[l, j, 0] = table.TableDataSetting.B(0, num2 - 1 - j, l);
								BVI[l, j, 1] = table.TableDataSetting.B(0, num2 - 1 - j, l);
							}
							else
							{
								BVI[l, j, 0] = table.TableDataSetting.B(0, j, l);
								BVI[l, j, 1] = table.TableDataSetting.B(0, j, l);
							}
						}
					}
				}
				else if (flag4)
				{
					for (int m = 0; m < num3; m++)
					{
						for (int i = 0; i < num; i++)
						{
							if (table.SwapColumnsAndRows)
							{
								BVI[m, 0, i] = table.TableDataSetting.B(0, i, m);
								BVI[m, 1, i] = table.TableDataSetting.B(0, i, m);
							}
							else
							{
								BVI[m, 0, i] = table.TableDataSetting.B(i, 0, m);
								BVI[m, 1, i] = table.TableDataSetting.B(i, 0, m);
							}
						}
					}
				}
			}
			else if (flag)
			{
				if (flag3)
				{
					return;
				}
				for (int n = 0; n < num3; n++)
				{
					for (int i = 0; i < num; i++)
					{
						if (table.SwapColumnsAndRows)
						{
							BVI[n, 0, i] = table.TableDataSetting.B(0, i, n);
							BVI[n, 1, i] = table.TableDataSetting.B(0, i, n);
						}
						else
						{
							BVI[n, 0, i] = table.TableDataSetting.B(i, 0, n);
							BVI[n, 1, i] = table.TableDataSetting.B(i, 0, n);
						}
					}
				}
			}
			else if (flag2)
			{
				if (flag4)
				{
					return;
				}
				for (int num4 = 0; num4 < num3; num4++)
				{
					for (int j = 0; j < num2; j++)
					{
						if (table.SwapColumnsAndRows)
						{
							if (table.InvertRows)
							{
								BVI[num4, j, 0] = table.TableDataSetting.B(num2 - 1 - j, 0, num4);
								BVI[num4, j, 1] = table.TableDataSetting.B(num2 - 1 - j, 0, num4);
							}
							else
							{
								BVI[num4, j, 0] = table.TableDataSetting.B(j, 0, num4);
								BVI[num4, j, 1] = table.TableDataSetting.B(j, 0, num4);
							}
						}
						else if (table.InvertRows)
						{
							BVI[num4, j, 0] = table.TableDataSetting.B(0, num2 - 1 - j, num4);
							BVI[num4, j, 1] = table.TableDataSetting.B(0, num2 - 1 - j, num4);
						}
						else
						{
							BVI[num4, j, 0] = table.TableDataSetting.B(0, j, num4);
							BVI[num4, j, 1] = table.TableDataSetting.B(0, j, num4);
						}
					}
				}
			}
			BVi = 2147483647;
			BVJ = -2147483648;
			for (int num5 = 0; num5 < num3; num5++)
			{
				for (int j = 0; j < num2; j++)
				{
					for (int i = 0; i < num; i++)
					{
						if (BVi > BVI[num5, j, i])
						{
							BVi = BVI[num5, j, i];
						}
						if (BVJ < BVI[num5, j, i])
						{
							BVJ = BVI[num5, j, i];
						}
					}
				}
			}
			int userSliceIndex = table.UserSliceIndex;
			for (int j = 0; j < num2; j++)
			{
				for (int i = 0; i < num; i++)
				{
					if (BVO)
					{
						bool flag5 = false;
						if (table.HorizVertIndexPerUserSelectedCell.Count == 1)
						{
							int num6 = i;
							Point val2 = table.HorizVertIndexPerUserSelectedCell[0];
							int num8;
							if (num6 == ((Point)(ref val2)).X)
							{
								int num7 = j;
								val2 = table.HorizVertIndexPerUserSelectedCell[0];
								num8 = ((num7 == ((Point)(ref val2)).Y) ? 1 : 0);
							}
							else
							{
								num8 = 0;
							}
							flag5 = (byte)num8 != 0;
						}
						A(table, BVG[i], BVg[j], BVI[userSliceIndex, j, i], BVG[0], BVG[num - 1], BVg[0], BVg[num2 - 1], BVi, BVJ, out BVj[j, i], out BVK[j, i], out BVk[j, i], flag5);
					}
					else
					{
						A(table, BVG[i], BVg[j], BVI[userSliceIndex, j, i], BVG[0], BVG[num - 1], BVg[0], BVg[num2 - 1], BVi, BVJ, out BVj[j, i], out BVK[j, i], out BVk[j, i]);
					}
				}
			}
			int num9 = (BM.TU ? BVi : 0);
			for (int j = 0; j < num2; j++)
			{
				for (int i = 0; i < num; i++)
				{
					A(table, BVG[i], BVg[j], num9, BVG[0], BVG[num - 1], BVg[0], BVg[num2 - 1], BVi, BVJ, out BVL[j, i], out BVl[j, i], out BVM[j, i]);
				}
			}
			for (int j = 0; j < num2 - 1; j++)
			{
				for (int i = 0; i < num - 1; i++)
				{
					float num10 = BVj[j, i] - BVj[j, i + 1];
					float num11 = BVj[j + 1, i + 1] - BVj[j, i + 1];
					float num12 = BVK[j, i] - BVK[j, i + 1];
					float num13 = BVK[j + 1, i + 1] - BVK[j, i + 1];
					float num14 = BVk[j, i] - BVk[j, i + 1];
					float num15 = BVk[j + 1, i + 1] - BVk[j, i + 1];
					float num16 = num12 * num15 - num13 * num14;
					float num17 = num14 * num11 - num15 * num10;
					float num18 = num10 * num13 - num10 * num13;
					float num19 = (float)Math.Sqrt((double)(num16 * num16 + num17 * num17 + num18 * num18));
					num19 *= (float)Math.Sqrt(5.0);
					if (num19 == 0f)
					{
						num19 = 0.001f;
					}
					num16 *= 0f;
					num17 *= -2f;
					num18 *= 1f;
					BVm[j, i] = num16 + num17 + num18;
					BVm[j, i] = (0f - BVm[j, i]) / num19;
					BVm[j, i] = BVm[j, i] / 3f + 0.6666f;
					if (BVm[j, i] < 0f)
					{
						BVm[j, i] = 0f;
					}
					if (BVm[j, i] > 1f)
					{
						BVm[j, i] = 1f;
					}
				}
			}
			int num20 = 0;
			for (int j = 0; j < num2 - 1; j++)
			{
				for (int i = 0; i < num - 1; i++)
				{
					BVN[num20].baf = Db.A.bae;
					BVN[num20].baG = i;
					BVN[num20].bag = j;
					BVN[num20].baH = (BVK[j, i] + BVK[j, i + 1] + BVK[j + 1, i] + BVK[j + 1, i + 1]) / 4f;
					num20++;
				}
			}
			for (int j = 0; j < num2 - 1; j++)
			{
				for (int i = 0; i < num - 1; i++)
				{
					BVN[num20].baf = Db.A.baF;
					BVN[num20].baG = i;
					BVN[num20].bag = j;
					BVN[num20].baH = (BVl[j, i] + BVl[j, i + 1] + BVl[j + 1, i] + BVl[j + 1, i + 1]) / 4f;
					num20++;
				}
			}
			int num21 = (num - 1) * (num2 - 1) * 2;
			bool flag6;
			do
			{
				flag6 = false;
				for (int num22 = 1; num22 < num21; num22++)
				{
					if (BVN[num22 - 1].baH > BVN[num22].baH)
					{
						a a = BVN[num22 - 1];
						BVN[num22 - 1] = BVN[num22];
						BVN[num22] = a;
						flag6 = true;
					}
				}
				num21--;
			}
			while (flag6);
		}
		catch
		{
		}
		if (base.B())
		{
			((Control)this).Invalidate();
		}
	}

	private void a(Graphics P_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		Color val = ((!((SettingOrSpecialObject)BKE).l()) ? Color.Gray : BM.te);
		SolidBrush val2 = new SolidBrush(val);
		try
		{
			Font val3 = new Font(((Control)this).Font.FontFamily, 10f);
			try
			{
				int num = BKE.aS();
				string text = ((SettingOrSpecialObject)BKE).H();
				string text2 = (string.IsNullOrWhiteSpace(text) ? ((SettingOrSpecialObject)BKE).A(bz.aYt) : text);
				if (((Control)this).Focused)
				{
					Font val4 = new Font(((Control)this).Font.FontFamily, 10f, (FontStyle)1);
					try
					{
						P_0.DrawString(text2, val4, (Brush)(object)val2, 8f, 8f);
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
				else
				{
					P_0.DrawString(text2, val3, (Brush)(object)val2, 8f, 8f);
				}
				P_0.DrawString(BuY, val3, (Brush)(object)val2, 8f, 27f);
				P_0.DrawString(Buy, val3, (Brush)(object)val2, 8f, 46f);
				if (BM.QO != BM.b.BpG)
				{
					string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + bS.A(BKE.@as(), num, false, 0);
					if ((!BM.A(BKD.aXc, true) || BM.aE()) && !BM.C(((Setting)BKE).A()))
					{
						P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFs() + text3, val3, (Brush)(object)val2, 8f, 65f);
						return;
					}
					ValueTuple<string, string, bool> val5 = BKE.aX();
					P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFT() + val5.Item1 + (val5.Item3 ? string.Empty : text3), val3, (Brush)(object)val2, 8f, 65f);
				}
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
	}

	private void B(Graphics P_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		Pen val = ((!BVR) ? new Pen(BM.te, 2f) : new Pen(BM.te, 3f));
		P_0.DrawArc(val, ((Control)this).Width - 13 - 24, 13, 20, 20, 0, 336);
		P_0.DrawLine(val, ((Control)this).Width - 13 - 5, 13, ((Control)this).Width - 13 - 5, 18);
		P_0.DrawLine(val, ((Control)this).Width - 13 - 10, 18, ((Control)this).Width - 13 - 5, 18);
		val.Dispose();
		if (!BVR)
		{
			return;
		}
		SolidBrush val2 = new SolidBrush(BM.te);
		try
		{
			Font val3 = new Font(((Control)this).Font.FontFamily, 7f);
			try
			{
				Rectangle val4 = default(Rectangle);
				((Rectangle)(ref val4))._002Ector(((Control)this).Width - 50, 40, 40, 60);
				P_0.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFz(), val3, (Brush)(object)val2, RectangleF.op_Implicit(val4));
			}
			finally
			{
				((System.IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val2)?.Dispose();
		}
	}

	private void A(Graphics P_0, Table P_1, bool P_2, bool P_3, int P_4, int P_5)
	{
		int num = (BM.TU ? BVi : 0);
		if (P_3)
		{
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			float num7 = 0f;
			float num8 = 0f;
			float num9 = 0f;
			float num10 = 0f;
			float num11 = 0f;
			float num12 = 0f;
			float num13 = 0f;
			for (int i = 0; i < P_5; i++)
			{
				A(P_1, BVG[0], BVg[i], num, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num2, out num3, out num4);
				A(P_1, BVG[P_4 - 1], BVg[i], num, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num5, out num6, out num7);
				if (num3 < num6)
				{
					A(P_1, BVG[0], BVg[i], num, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num8, out num9, out num10);
					A(P_1, BVG[0], BVg[i], BVJ, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num11, out num12, out num13);
					P_0.DrawLine(Buz, num8, num10, num11, num13);
				}
				else
				{
					A(P_1, BVG[P_4 - 1], BVg[i], num, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num8, out num9, out num10);
					A(P_1, BVG[P_4 - 1], BVg[i], BVJ, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num11, out num12, out num13);
					P_0.DrawLine(Buz, num8, num10, num11, num13);
				}
			}
			if (num3 < num6)
			{
				A(P_1, BVG[0], BVg[0], BVJ, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num8, out num9, out num10);
				A(P_1, BVG[0], BVg[P_5 - 1], BVJ, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num11, out num12, out num13);
			}
			else
			{
				A(P_1, BVG[P_4 - 1], BVg[0], BVJ, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num8, out num9, out num10);
				A(P_1, BVG[P_4 - 1], BVg[P_5 - 1], BVJ, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num11, out num12, out num13);
			}
			P_0.DrawLine(Buz, num8, num10, num11, num13);
		}
		if (!P_2)
		{
			return;
		}
		float num14 = 0f;
		float num15 = 0f;
		float num16 = 0f;
		float num17 = 0f;
		float num18 = 0f;
		float num19 = 0f;
		float num20 = 0f;
		float num21 = 0f;
		float num22 = 0f;
		float num23 = 0f;
		float num24 = 0f;
		float num25 = 0f;
		for (int j = 0; j < P_4; j++)
		{
			A(P_1, BVG[j], BVg[0], num, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num14, out num15, out num16);
			A(P_1, BVG[j], BVg[P_5 - 1], num, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num17, out num18, out num19);
			if (num15 < num18)
			{
				A(P_1, BVG[j], BVg[0], num, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num20, out num21, out num22);
				A(P_1, BVG[j], BVg[0], BVJ, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num23, out num24, out num25);
			}
			else
			{
				A(P_1, BVG[j], BVg[P_5 - 1], num, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num20, out num21, out num22);
				A(P_1, BVG[j], BVg[P_5 - 1], BVJ, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num23, out num24, out num25);
			}
			P_0.DrawLine(Buz, num20, num22, num23, num25);
		}
		if (num15 < num18)
		{
			A(P_1, BVG[0], BVg[0], BVJ, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num20, out num21, out num22);
			A(P_1, BVG[P_4 - 1], BVg[0], BVJ, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num23, out num24, out num25);
		}
		else
		{
			A(P_1, BVG[0], BVg[P_5 - 1], BVJ, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num20, out num21, out num22);
			A(P_1, BVG[P_4 - 1], BVg[P_5 - 1], BVJ, BVG[0], BVG[P_4 - 1], BVg[0], BVg[P_5 - 1], BVi, BVJ, out num23, out num24, out num25);
		}
		P_0.DrawLine(Buz, num20, num22, num23, num25);
	}

	private void a(Graphics P_0, Table P_1, bool P_2, bool P_3, int P_4, int P_5)
	{
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < (P_4 - 1) * (P_5 - 1) * 2; i++)
		{
			try
			{
				int baG = BVN[i].baG;
				int bag = BVN[i].bag;
				if (BVN[i].baf == Db.A.bae)
				{
					((PointF)(ref BVE[0])).X = BVj[bag, baG];
					((PointF)(ref BVE[0])).Y = BVk[bag, baG];
					((PointF)(ref BVE[1])).X = BVj[bag, baG + 1];
					((PointF)(ref BVE[1])).Y = BVk[bag, baG + 1];
					((PointF)(ref BVE[2])).X = BVj[bag + 1, baG + 1];
					((PointF)(ref BVE[2])).Y = BVk[bag + 1, baG + 1];
					((PointF)(ref BVE[3])).X = BVj[bag + 1, baG];
					((PointF)(ref BVE[3])).Y = BVk[bag + 1, baG];
					float num = Math.Min(Math.Min(Math.Min(((PointF)(ref BVE[0])).X, ((PointF)(ref BVE[1])).X), ((PointF)(ref BVE[2])).X), ((PointF)(ref BVE[3])).X);
					float num2 = Math.Max(Math.Max(Math.Max(((PointF)(ref BVE[0])).X, ((PointF)(ref BVE[1])).X), ((PointF)(ref BVE[2])).X), ((PointF)(ref BVE[3])).X);
					float num3 = Math.Min(Math.Min(Math.Min(((PointF)(ref BVE[0])).Y, ((PointF)(ref BVE[1])).Y), ((PointF)(ref BVE[2])).Y), ((PointF)(ref BVE[3])).Y);
					float num4 = Math.Max(Math.Max(Math.Max(((PointF)(ref BVE[0])).Y, ((PointF)(ref BVE[1])).Y), ((PointF)(ref BVE[2])).Y), ((PointF)(ref BVE[3])).Y);
					for (int j = 0; j < 4; j++)
					{
						if (((PointF)(ref BVE[j])).X == num)
						{
							ref PointF reference = ref BVE[j];
							((PointF)(ref reference)).X = ((PointF)(ref reference)).X - 1f;
						}
						else if (((PointF)(ref BVE[j])).X == num2)
						{
							ref PointF reference2 = ref BVE[j];
							((PointF)(ref reference2)).X = ((PointF)(ref reference2)).X + 1f;
						}
						if (((PointF)(ref BVE[j])).Y == num3)
						{
							ref PointF reference3 = ref BVE[j];
							((PointF)(ref reference3)).Y = ((PointF)(ref reference3)).Y - 1f;
						}
						else if (((PointF)(ref BVE[j])).Y == num4)
						{
							ref PointF reference4 = ref BVE[j];
							((PointF)(ref reference4)).Y = ((PointF)(ref reference4)).Y + 1f;
						}
					}
					int userSliceIndex = BKE.UserSliceIndex;
					int num5 = (BVI[userSliceIndex, bag, baG] + BVI[userSliceIndex, bag, baG + 1] + BVI[userSliceIndex, bag + 1, baG + 1] + BVI[userSliceIndex, bag + 1, baG]) / 4;
					BVF.Reset();
					BVF.AddPolygon(BVE);
					RectangleF bounds = BVF.GetBounds();
					if (((RectangleF)(ref bounds)).Height != 0f)
					{
						bounds = BVF.GetBounds();
						if (((RectangleF)(ref bounds)).Width != 0f)
						{
							BVf = new PathGradientBrush(BVF);
							float num6 = (BM.Tt ? BVm[bag, baG] : 1f);
							int num7 = (int)((float)(BM.TV * 255 / 100) * num6);
							int num8 = BM.Tu * 255 / 100;
							int num9 = BM.Tv * 255 / 100;
							int num10 = BM.TW * 255 / 100;
							Color val2;
							if (BVi == BVJ)
							{
								Color val = l.A(num10, num8, num7);
								Color[] bVe = BVe;
								Color[] bVe2 = BVe;
								Color[] bVe3 = BVe;
								val2 = (BVe[3] = val);
								val2 = (bVe3[2] = val2);
								val2 = (bVe[0] = (bVe2[1] = val2));
								Enumerator<Point> enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										Point current = enumerator.Current;
										if (((Point)(ref current)).X == baG && ((Point)(ref current)).Y == bag)
										{
											BVe[0] = Color.DodgerBlue;
										}
										if (((Point)(ref current)).X == baG + 1 && ((Point)(ref current)).Y == bag)
										{
											BVe[1] = Color.DodgerBlue;
										}
										if (((Point)(ref current)).X == baG + 1 && ((Point)(ref current)).Y == bag + 1)
										{
											BVe[2] = Color.DodgerBlue;
										}
										if (((Point)(ref current)).X == baG && ((Point)(ref current)).Y == bag + 1)
										{
											BVe[3] = Color.DodgerBlue;
										}
									}
								}
								finally
								{
									((System.IDisposable)enumerator).Dispose();
								}
								if (BVe[0] == Color.DodgerBlue && BVe[1] == Color.DodgerBlue && BVe[2] == Color.DodgerBlue && BVe[3] == Color.DodgerBlue)
								{
									BVf.CenterColor = Color.DodgerBlue;
								}
								else if ((BVe[0] == Color.DodgerBlue && BVe[1] == Color.DodgerBlue) || (BVe[2] == Color.DodgerBlue && BVe[3] == Color.DodgerBlue) || (BVe[0] == Color.DodgerBlue && BVe[3] == Color.DodgerBlue) || (BVe[1] == Color.DodgerBlue && BVe[2] == Color.DodgerBlue))
								{
									byte r = ((Color)(ref val)).R;
									val2 = Color.DodgerBlue;
									byte b = (byte)((r + ((Color)(ref val2)).R) / 2);
									byte num11 = ((Color)(ref val)).G;
									val2 = Color.DodgerBlue;
									byte b2 = (byte)((num11 + ((Color)(ref val2)).G) / 2);
									byte num12 = ((Color)(ref val)).B;
									val2 = Color.DodgerBlue;
									byte b3 = (byte)((num12 + ((Color)(ref val2)).B) / 2);
									BVf.CenterColor = Color.FromArgb((int)b, (int)b2, (int)b3);
								}
								else
								{
									BVf.CenterColor = val;
								}
								BVf.SurroundColors = BVe;
							}
							else
							{
								BVd[0] = BVI[userSliceIndex, bag, baG];
								BVd[1] = BVI[userSliceIndex, bag, baG + 1];
								BVd[2] = BVI[userSliceIndex, bag + 1, baG + 1];
								BVd[3] = BVI[userSliceIndex, bag + 1, baG];
								int num13 = ((!BM.Tw) ? (num9 + (num10 - num9) * (num5 - BVi) / (BVJ - BVi)) : ((num9 >= num10) ? (num9 + (255 - (num9 - num10)) * (num5 - BVi) / (BVJ - BVi)) : (num9 - (255 - (num10 - num9)) * (num5 - BVi) / (BVJ - BVi))));
								if (num13 < 0)
								{
									num13 += 255;
								}
								else if (num13 > 255)
								{
									num13 -= 255;
								}
								Color centerColor = l.A(num13, num8, num7);
								BVf.CenterColor = centerColor;
								for (int k = 0; k < 4; k++)
								{
									int num14 = ((!BM.Tw) ? (num9 + (num10 - num9) * (BVd[k] - BVi) / (BVJ - BVi)) : ((num9 >= num10) ? (num9 + (255 - (num9 - num10)) * (BVd[k] - BVi) / (BVJ - BVi)) : (num9 - (255 - (num10 - num9)) * (BVd[k] - BVi) / (BVJ - BVi))));
									if (num14 < 0)
									{
										num14 += 255;
									}
									else if (num14 > 255)
									{
										num14 -= 255;
									}
									Color val3 = l.A(num14, num8, num7);
									BVe[k] = val3;
								}
								Enumerator<Point> enumerator = BKE.HorizVertIndexPerUserSelectedCell.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										Point current2 = enumerator.Current;
										if (((Point)(ref current2)).X == baG && ((Point)(ref current2)).Y == bag)
										{
											BVe[0] = Color.DodgerBlue;
										}
										if (((Point)(ref current2)).X == baG + 1 && ((Point)(ref current2)).Y == bag)
										{
											BVe[1] = Color.DodgerBlue;
										}
										if (((Point)(ref current2)).X == baG + 1 && ((Point)(ref current2)).Y == bag + 1)
										{
											BVe[2] = Color.DodgerBlue;
										}
										if (((Point)(ref current2)).X == baG && ((Point)(ref current2)).Y == bag + 1)
										{
											BVe[3] = Color.DodgerBlue;
										}
									}
								}
								finally
								{
									((System.IDisposable)enumerator).Dispose();
								}
								BVf.SurroundColors = BVe;
								if (BVe[0] == Color.DodgerBlue && BVe[1] == Color.DodgerBlue && BVe[2] == Color.DodgerBlue && BVe[3] == Color.DodgerBlue)
								{
									BVf.CenterColor = Color.DodgerBlue;
								}
								else if (BVe[0] == Color.DodgerBlue && BVe[1] == Color.DodgerBlue)
								{
									byte b4 = (byte)((((Color)(ref BVe[2])).R + ((Color)(ref BVe[3])).R) / 2);
									byte b5 = (byte)((((Color)(ref BVe[2])).G + ((Color)(ref BVe[3])).G) / 2);
									byte num15 = (byte)((((Color)(ref BVe[2])).B + ((Color)(ref BVe[3])).B) / 2);
									val2 = Color.DodgerBlue;
									byte b6 = (byte)((b4 + ((Color)(ref val2)).R) / 2);
									val2 = Color.DodgerBlue;
									byte b7 = (byte)((b5 + ((Color)(ref val2)).G) / 2);
									val2 = Color.DodgerBlue;
									byte b8 = (byte)((num15 + ((Color)(ref val2)).B) / 2);
									BVf.CenterColor = Color.FromArgb((int)b6, (int)b7, (int)b8);
								}
								else if (BVe[2] == Color.DodgerBlue && BVe[3] == Color.DodgerBlue)
								{
									byte b9 = (byte)((((Color)(ref BVe[0])).R + ((Color)(ref BVe[1])).R) / 2);
									byte b10 = (byte)((((Color)(ref BVe[0])).G + ((Color)(ref BVe[1])).G) / 2);
									byte num16 = (byte)((((Color)(ref BVe[0])).B + ((Color)(ref BVe[1])).B) / 2);
									val2 = Color.DodgerBlue;
									byte b11 = (byte)((b9 + ((Color)(ref val2)).R) / 2);
									val2 = Color.DodgerBlue;
									byte b12 = (byte)((b10 + ((Color)(ref val2)).G) / 2);
									val2 = Color.DodgerBlue;
									byte b13 = (byte)((num16 + ((Color)(ref val2)).B) / 2);
									BVf.CenterColor = Color.FromArgb((int)b11, (int)b12, (int)b13);
								}
								else if (BVe[0] == Color.DodgerBlue && BVe[3] == Color.DodgerBlue)
								{
									byte b14 = (byte)((((Color)(ref BVe[1])).R + ((Color)(ref BVe[2])).R) / 2);
									byte b15 = (byte)((((Color)(ref BVe[1])).G + ((Color)(ref BVe[2])).G) / 2);
									byte num17 = (byte)((((Color)(ref BVe[1])).B + ((Color)(ref BVe[2])).B) / 2);
									val2 = Color.DodgerBlue;
									byte b16 = (byte)((b14 + ((Color)(ref val2)).R) / 2);
									val2 = Color.DodgerBlue;
									byte b17 = (byte)((b15 + ((Color)(ref val2)).G) / 2);
									val2 = Color.DodgerBlue;
									byte b18 = (byte)((num17 + ((Color)(ref val2)).B) / 2);
									BVf.CenterColor = Color.FromArgb((int)b16, (int)b17, (int)b18);
								}
								else if (BVe[1] == Color.DodgerBlue && BVe[2] == Color.DodgerBlue)
								{
									byte b19 = (byte)((((Color)(ref BVe[0])).R + ((Color)(ref BVe[3])).R) / 2);
									byte b20 = (byte)((((Color)(ref BVe[0])).G + ((Color)(ref BVe[3])).G) / 2);
									byte num18 = (byte)((((Color)(ref BVe[0])).B + ((Color)(ref BVe[3])).B) / 2);
									val2 = Color.DodgerBlue;
									byte b21 = (byte)((b19 + ((Color)(ref val2)).R) / 2);
									val2 = Color.DodgerBlue;
									byte b22 = (byte)((b20 + ((Color)(ref val2)).G) / 2);
									val2 = Color.DodgerBlue;
									byte b23 = (byte)((num18 + ((Color)(ref val2)).B) / 2);
									BVf.CenterColor = Color.FromArgb((int)b21, (int)b22, (int)b23);
								}
							}
							P_0.FillPolygon((Brush)(object)BVf, BVE);
							((Brush)BVf).Dispose();
						}
					}
					((PointF)(ref BVE[0])).X = BVj[bag, baG];
					((PointF)(ref BVE[0])).Y = BVk[bag, baG];
					((PointF)(ref BVE[1])).X = BVj[bag, baG + 1];
					((PointF)(ref BVE[1])).Y = BVk[bag, baG + 1];
					((PointF)(ref BVE[2])).X = BVj[bag + 1, baG + 1];
					((PointF)(ref BVE[2])).Y = BVk[bag + 1, baG + 1];
					((PointF)(ref BVE[3])).X = BVj[bag + 1, baG];
					((PointF)(ref BVE[3])).Y = BVk[bag + 1, baG];
					if (BM.Tp == BM.S.BqI)
					{
						P_0.DrawPolygon(BVA, BVE);
					}
					else if (BM.Tp == BM.S.Bqi)
					{
						P_0.DrawPolygon(BVa, BVE);
					}
					else if (BM.Tp == BM.S.BqJ)
					{
						P_0.DrawPolygon(BVB, BVE);
					}
					if (BM.QO != BM.b.BpG && ((BM.A(BKD.aXc, true) && !BM.aE()) || (BKf != null && BM.C(BKf.A()) && BKG != null && BM.C(BKG.A()))))
					{
						A(P_0, P_1, P_2, P_4, P_5, baG, bag, userSliceIndex);
						a(P_0, P_1, P_3, P_4, P_5, baG, bag, userSliceIndex);
					}
				}
				else if (BVN[i].baf == Db.A.baF)
				{
					((PointF)(ref BVE[0])).X = BVL[bag, baG];
					((PointF)(ref BVE[0])).Y = BVM[bag, baG];
					((PointF)(ref BVE[1])).X = BVL[bag, baG + 1];
					((PointF)(ref BVE[1])).Y = BVM[bag, baG + 1];
					((PointF)(ref BVE[2])).X = BVL[bag + 1, baG + 1];
					((PointF)(ref BVE[2])).Y = BVM[bag + 1, baG + 1];
					((PointF)(ref BVE[3])).X = BVL[bag + 1, baG];
					((PointF)(ref BVE[3])).Y = BVM[bag + 1, baG];
					float num19 = Math.Min(Math.Min(Math.Min(((PointF)(ref BVE[0])).X, ((PointF)(ref BVE[1])).X), ((PointF)(ref BVE[2])).X), ((PointF)(ref BVE[3])).X);
					float num20 = Math.Max(Math.Max(Math.Max(((PointF)(ref BVE[0])).X, ((PointF)(ref BVE[1])).X), ((PointF)(ref BVE[2])).X), ((PointF)(ref BVE[3])).X);
					float num21 = Math.Min(Math.Min(Math.Min(((PointF)(ref BVE[0])).Y, ((PointF)(ref BVE[1])).Y), ((PointF)(ref BVE[2])).Y), ((PointF)(ref BVE[3])).Y);
					float num22 = Math.Max(Math.Max(Math.Max(((PointF)(ref BVE[0])).Y, ((PointF)(ref BVE[1])).Y), ((PointF)(ref BVE[2])).Y), ((PointF)(ref BVE[3])).Y);
					if (num19 != num20 && num21 != num22)
					{
						P_0.DrawPolygon(Buz, BVE);
					}
				}
			}
			catch
			{
			}
		}
	}

	private void A(Graphics P_0, Table P_1, bool P_2, int P_3, int P_4, int P_5, int P_6, int P_7)
	{
		if (!P_2 || BKf == null)
		{
			return;
		}
		int num = BKf.ax();
		if (num < BVG[P_5] || num > BVG[P_5 + 1])
		{
			return;
		}
		int num2 = BVG[0];
		int num3 = BVG[P_3 - 1];
		int num4 = BVg[0];
		int num5 = BVg[P_4 - 1];
		if (BVH == AxisBehaviour.DiscreteCentred)
		{
			int num6 = BVG[P_5] + BVG[P_5 + 1] >> 1;
			float num7;
			float num8;
			float num9;
			float num10;
			float num11;
			float num12;
			if (num == BVG[P_5] || num < num6)
			{
				A(P_1, BVG[P_5], BVg[P_6], BVI[P_7, P_6, P_5], num2, num3, num4, num5, BVi, BVJ, out num7, out num8, out num9);
				A(P_1, BVG[P_5], BVg[P_6 + 1], BVI[P_7, P_6 + 1, P_5], num2, num3, num4, num5, BVi, BVJ, out num10, out num11, out num12);
			}
			else
			{
				A(P_1, BVG[P_5 + 1], BVg[P_6], BVI[P_7, P_6, P_5 + 1], num2, num3, num4, num5, BVi, BVJ, out num7, out num8, out num9);
				A(P_1, BVG[P_5 + 1], BVg[P_6 + 1], BVI[P_7, P_6 + 1, P_5 + 1], num2, num3, num4, num5, BVi, BVJ, out num10, out num11, out num12);
			}
			P_0.DrawLine(BVb, num7, num9, num10, num12);
		}
		else if (BVH != AxisBehaviour.DiscreteLimits && BVH == AxisBehaviour.Continuous)
		{
			float num13 = BVI[P_7, P_6, P_5] + (BVI[P_7, P_6, P_5 + 1] - BVI[P_7, P_6, P_5]) * (num - BVG[P_5]) / (BVG[P_5 + 1] - BVG[P_5]);
			float num14 = BVI[P_7, P_6 + 1, P_5] + (BVI[P_7, P_6 + 1, P_5 + 1] - BVI[P_7, P_6 + 1, P_5]) * (num - BVG[P_5]) / (BVG[P_5 + 1] - BVG[P_5]);
			A(P_1, num, BVg[P_6], (int)Math.Round((double)num13), num2, num3, num4, num5, BVi, BVJ, out var num15, out var _, out var num17);
			A(P_1, num, BVg[P_6 + 1], (int)Math.Round((double)num14), num2, num3, num4, num5, BVi, BVJ, out var num18, out var _, out var num20);
			P_0.DrawLine(BVb, num15, num17, num18, num20);
		}
	}

	private void a(Graphics P_0, Table P_1, bool P_2, int P_3, int P_4, int P_5, int P_6, int P_7)
	{
		if (!P_2 || BKG == null)
		{
			return;
		}
		int num = BKG.ax();
		if ((BKE.InvertRows || num < BVg[P_6] || num > BVg[P_6 + 1]) && (!BKE.InvertRows || num < BVg[P_6 + 1] || num > BVg[P_6]))
		{
			return;
		}
		int num2 = BVG[0];
		int num3 = BVG[P_3 - 1];
		int num4 = BVg[0];
		int num5 = BVg[P_4 - 1];
		if (BVh == AxisBehaviour.DiscreteCentred)
		{
			int num6 = BVg[P_6] + BVg[P_6 + 1] >> 1;
			float num7;
			float num8;
			float num9;
			float num10;
			float num11;
			float num12;
			if (!BKE.InvertRows)
			{
				if (num == BVg[P_6] || num < num6)
				{
					A(P_1, BVG[P_5], BVg[P_6], BVI[P_7, P_6, P_5], num2, num3, num4, num5, BVi, BVJ, out num7, out num8, out num9);
					A(P_1, BVG[P_5 + 1], BVg[P_6], BVI[P_7, P_6, P_5 + 1], num2, num3, num4, num5, BVi, BVJ, out num10, out num11, out num12);
				}
				else
				{
					A(P_1, BVG[P_5], BVg[P_6 + 1], BVI[P_7, P_6 + 1, P_5], num2, num3, num4, num5, BVi, BVJ, out num7, out num8, out num9);
					A(P_1, BVG[P_5 + 1], BVg[P_6 + 1], BVI[P_7, P_6 + 1, P_5 + 1], num2, num3, num4, num5, BVi, BVJ, out num10, out num11, out num12);
				}
			}
			else if (num == BVg[P_6 + 1] || num < num6)
			{
				A(P_1, BVG[P_5], BVg[P_6 + 1], BVI[P_7, P_6 + 1, P_5], num2, num3, num4, num5, BVi, BVJ, out num7, out num8, out num9);
				A(P_1, BVG[P_5 + 1], BVg[P_6 + 1], BVI[P_7, P_6 + 1, P_5 + 1], num2, num3, num4, num5, BVi, BVJ, out num10, out num11, out num12);
			}
			else
			{
				A(P_1, BVG[P_5], BVg[P_6], BVI[P_7, P_6, P_5], num2, num3, num4, num5, BVi, BVJ, out num7, out num8, out num9);
				A(P_1, BVG[P_5 + 1], BVg[P_6], BVI[P_7, P_6, P_5 + 1], num2, num3, num4, num5, BVi, BVJ, out num10, out num11, out num12);
			}
			P_0.DrawLine(BVb, num7, num9, num10, num12);
		}
		else if (BVh != AxisBehaviour.DiscreteLimits && BVh == AxisBehaviour.Continuous)
		{
			float num13 = BVI[P_7, P_6, P_5] + (BVI[P_7, P_6 + 1, P_5] - BVI[P_7, P_6, P_5]) * (num - BVg[P_6]) / (BVg[P_6 + 1] - BVg[P_6]);
			float num14 = BVI[P_7, P_6, P_5 + 1] + (BVI[P_7, P_6 + 1, P_5 + 1] - BVI[P_7, P_6, P_5 + 1]) * (num - BVg[P_6]) / (BVg[P_6 + 1] - BVg[P_6]);
			A(P_1, BVG[P_5], num, (int)Math.Round((double)num13), num2, num3, num4, num5, BVi, BVJ, out var num15, out var _, out var num17);
			A(P_1, BVG[P_5 + 1], num, (int)Math.Round((double)num14), num2, num3, num4, num5, BVi, BVJ, out var num18, out var _, out var num20);
			P_0.DrawLine(BVb, num15, num17, num18, num20);
		}
	}

	private void A(Graphics P_0, Table P_1, bool P_2, int P_3, int P_4)
	{
		int num = (BM.TU ? BVi : 0);
		if (!P_2)
		{
			return;
		}
		Setting setting = ((BM.QO != BM.b.BpG) ? BKG : BKh);
		if (setting == null)
		{
			return;
		}
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		float num6 = 0f;
		float num7 = 0f;
		A(P_1, BVG[0], BVg[P_4 - 1], num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
		A(P_1, BVG[P_3 - 1], BVg[P_4 - 1], num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num5, out num6, out num7);
		if (num3 < num6)
		{
			A(P_1, (BVG[P_3 - 1] - BVG[0]) * 17 / 16 + BVG[0], (BVg[0] + BVg[P_4 - 1]) / 2, num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
			string text = ((SettingOrSpecialObject)setting).H();
			string text2;
			if (!string.IsNullOrWhiteSpace(text))
			{
				text2 = text;
			}
			else
			{
				string text3 = ((SettingOrSpecialObject)setting).A(bz.aYt);
				text2 = ((string.IsNullOrEmpty(text3) || text3.Length >= 20) ? ((SettingOrSpecialObject)setting).A(bz.aYT) : text3);
			}
			StringFormat val = ((!(num2 > (float)(((Control)this).Width / 2))) ? BVD : BVc);
			P_0.DrawString(text2, BVC, (Brush)(object)BuZ, num2, num4, val);
			int num8 = setting.aS();
			string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + bS.A(setting.@as(), num8, false, 0);
			A(P_1, (BVG[P_3 - 1] - BVG[0]) * 17 / 16 + BVG[0], BVg[0], num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
			List<Setting.ListItems.A> val2 = setting.d(0);
			bool flag = false;
			for (int i = 0; i < val2.Count; i++)
			{
				if (val2[i].bBv == BVg[0])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				string text5 = bS.a(BVg[0], num8, -1) + text4;
				P_0.DrawString(text5, BVC, (Brush)(object)BuZ, num2, num4, val);
			}
			A(P_1, (BVG[P_3 - 1] - BVG[0]) * 17 / 16 + BVG[0], BVg[P_4 - 1], num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
			flag = false;
			for (int j = 0; j < val2.Count; j++)
			{
				if (val2[j].bBv == BVg[P_4 - 1])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				string text6 = bS.a(BVg[P_4 - 1], num8, -1) + text4;
				P_0.DrawString(text6, BVC, (Brush)(object)BuZ, num2, num4, val);
			}
			return;
		}
		A(P_1, BVG[P_3 - 1] - (BVG[P_3 - 1] - BVG[0]) * 17 / 16, (BVg[0] + BVg[P_4 - 1]) / 2, num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
		string text7 = ((SettingOrSpecialObject)setting).H();
		string text8;
		if (!string.IsNullOrWhiteSpace(text7))
		{
			text8 = text7;
		}
		else
		{
			string text9 = ((SettingOrSpecialObject)setting).A(bz.aYt);
			text8 = ((string.IsNullOrEmpty(text9) || text9.Length >= 20) ? ((SettingOrSpecialObject)setting).A(bz.aYT) : text9);
		}
		StringFormat val3 = ((!(num2 > (float)(((Control)this).Width / 2))) ? BVD : BVc);
		P_0.DrawString(text8, BVC, (Brush)(object)BuZ, num2, num4, val3);
		int num9 = setting.aS();
		string text10 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + bS.A(setting.@as(), num9, false, 0);
		A(P_1, BVG[P_3 - 1] - (BVG[P_3 - 1] - BVG[0]) * 17 / 16, BVg[0], num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
		List<Setting.ListItems.A> val4 = setting.d(0);
		bool flag2 = false;
		for (int k = 0; k < val4.Count; k++)
		{
			if (val4[k].bBv == BVg[0])
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			string text11 = bS.a(BVg[0], num9, -1) + text10;
			P_0.DrawString(text11, BVC, (Brush)(object)BuZ, num2, num4, val3);
		}
		A(P_1, BVG[P_3 - 1] - (BVG[P_3 - 1] - BVG[0]) * 17 / 16, BVg[P_4 - 1], num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
		flag2 = false;
		for (int l = 0; l < val4.Count; l++)
		{
			if (val4[l].bBv == BVg[P_4 - 1])
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			string text12 = bS.a(BVg[P_4 - 1], num9, -1) + text10;
			P_0.DrawString(text12, BVC, (Brush)(object)BuZ, num2, num4, val3);
		}
	}

	private void a(Graphics P_0, Table P_1, bool P_2, int P_3, int P_4)
	{
		int num = (BM.TU ? BVi : 0);
		if (!P_2)
		{
			return;
		}
		Setting setting = ((BM.QO != BM.b.BpG) ? BKf : BKH);
		if (setting == null)
		{
			return;
		}
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		float num6 = 0f;
		float num7 = 0f;
		A(P_1, BVG[P_3 - 1], BVg[0], num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
		A(P_1, BVG[P_3 - 1], BVg[P_4 - 1], num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num5, out num6, out num7);
		if (num3 < num6)
		{
			A(P_1, (BVG[0] + BVG[P_3 - 1]) / 2, (BVg[P_4 - 1] - BVg[0]) * 17 / 16 + BVg[0], num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
			string text = ((SettingOrSpecialObject)setting).H();
			string text2;
			if (!string.IsNullOrWhiteSpace(text))
			{
				text2 = text;
			}
			else
			{
				string text3 = ((SettingOrSpecialObject)setting).A(bz.aYt);
				text2 = ((string.IsNullOrEmpty(text3) || text3.Length >= 20) ? ((SettingOrSpecialObject)setting).A(bz.aYT) : text3);
			}
			StringFormat val = ((!(num2 > (float)(((Control)this).Width / 2))) ? BVD : BVc);
			P_0.DrawString(text2, BVC, (Brush)(object)BuZ, num2, num4, val);
			int num8 = setting.aS();
			string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + bS.A(setting.@as(), num8, false, 0);
			A(P_1, BVG[0], (BVg[P_4 - 1] - BVg[0]) * 17 / 16 + BVg[0], num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
			List<Setting.ListItems.A> val2 = setting.d(0);
			bool flag = false;
			for (int i = 0; i < val2.Count; i++)
			{
				if (val2[i].bBv == BVG[0])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				string text5 = bS.a(BVG[0], num8, -1) + text4;
				P_0.DrawString(text5, BVC, (Brush)(object)BuZ, num2, num4, val);
			}
			A(P_1, BVG[P_3 - 1], (BVg[P_4 - 1] - BVg[0]) * 17 / 16 + BVg[0], num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
			flag = false;
			for (int j = 0; j < val2.Count; j++)
			{
				if (val2[j].bBv == BVG[P_3 - 1])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				string text6 = bS.a(BVG[P_3 - 1], num8, -1) + text4;
				P_0.DrawString(text6, BVC, (Brush)(object)BuZ, num2, num4, val);
			}
			return;
		}
		A(P_1, (BVG[0] + BVG[P_3 - 1]) / 2, BVg[P_4 - 1] - (BVg[P_4 - 1] - BVg[0]) * 17 / 16, num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
		string text7 = ((SettingOrSpecialObject)setting).H();
		string text8;
		if (!string.IsNullOrWhiteSpace(text7))
		{
			text8 = text7;
		}
		else
		{
			string text9 = ((SettingOrSpecialObject)setting).A(bz.aYt);
			text8 = ((string.IsNullOrEmpty(text9) || text9.Length >= 20) ? ((SettingOrSpecialObject)setting).A(bz.aYT) : text9);
		}
		StringFormat val3 = ((!(num2 > (float)(((Control)this).Width / 2))) ? BVD : BVc);
		P_0.DrawString(text8, BVC, (Brush)(object)BuZ, num2, num4, val3);
		int num9 = setting.aS();
		string text10 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + bS.A(setting.@as(), num9, false, 0);
		A(P_1, BVG[0], BVg[P_4 - 1] - (BVg[P_4 - 1] - BVg[0]) * 17 / 16, num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
		List<Setting.ListItems.A> val4 = setting.d(0);
		bool flag2 = false;
		for (int k = 0; k < val4.Count; k++)
		{
			if (val4[k].bBv == BVG[0])
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			string text11 = bS.a(BVG[0], num9, -1) + text10;
			P_0.DrawString(text11, BVC, (Brush)(object)BuZ, num2, num4, val3);
		}
		A(P_1, BVG[P_3 - 1], BVg[P_4 - 1] - (BVg[P_4 - 1] - BVg[0]) * 17 / 16, num, BVG[0], BVG[P_3 - 1], BVg[0], BVg[P_4 - 1], BVi, BVJ, out num2, out num3, out num4);
		flag2 = false;
		for (int l = 0; l < val4.Count; l++)
		{
			if (val4[l].bBv == BVG[P_3 - 1])
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			string text12 = bS.a(BVG[P_3 - 1], num9, -1) + text10;
			P_0.DrawString(text12, BVC, (Brush)(object)BuZ, num2, num4, val3);
		}
	}

	private void A(object P_0, PaintEventArgs P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Stopwatch val = new Stopwatch();
		val.Start();
		Table table;
		if (BM.QO == BM.b.BpG)
		{
			table = BKe;
			_ = BKI;
		}
		else
		{
			table = BKE;
			_ = BKg;
		}
		if (table == null)
		{
			return;
		}
		Graphics graphics = P_1.Graphics;
		graphics.SmoothingMode = (SmoothingMode)2;
		a(graphics);
		B(graphics);
		bool flag = table.HorizAxisEnabled();
		bool flag2 = table.VertAxisEnabled();
		if (flag || flag2)
		{
			int num = table.HorizAxisCount();
			if (num == 1)
			{
				num = 2;
			}
			int num2 = table.VertAxisCount();
			if (num2 == 1)
			{
				num2 = 2;
			}
			if (num > 64)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFy());
			}
			if (num2 > 64)
			{
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFy());
			}
			A(graphics, table, flag, flag2, num, num2);
			a(graphics, table, flag, flag2, num, num2);
			A(graphics, table, flag2, num, num2);
			a(graphics, table, flag, num, num2);
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfA(), (object)val.ElapsedMilliseconds, (object)((Control)this).Left, (object)((Control)this).Top), false);
		}
	}

	private void A(Table P_0, int P_1, int P_2, int P_3, int P_4, int P_5, int P_6, int P_7, int P_8, int P_9, out float P_10, out float P_11, out float P_12)
	{
		A(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8, P_9, out P_10, out P_11, out P_12, false);
	}

	private void A(Table P_0, int P_1, int P_2, int P_3, int P_4, int P_5, int P_6, int P_7, int P_8, int P_9, out float P_10, out float P_11, out float P_12, bool P_13)
	{
		int num = ((BKj == null || !((Control)BKj).Visible) ? ((Control)this).Height : (((Control)this).Height - ((Control)BKj).Height));
		float num2 = (float)num * 0.7f;
		int num3 = (BM.TU ? BVi : 0);
		float num4 = P_5 - P_4;
		float num5 = P_7 - P_6;
		float num6 = P_9 - Math.Min(P_8, num3);
		float num7 = ((num4 == 0f) ? 1f : ((float)(P_1 - P_4) * num2 / num4 - num2 / 2f));
		float num8 = ((num5 == 0f) ? 1f : ((float)(P_2 - P_6) * num2 / num5 - num2 / 2f));
		float num9 = ((num6 == 0f) ? (-1f) : ((0f - (float)(P_3 - Math.Min(P_8, num3)) * (num2 / 2f)) / num6 + num2 / 4f));
		float num10 = num7 * P_0.CosXFor3DView + num8 * P_0.SinXFor3DView;
		float num11 = num8 * P_0.CosXFor3DView - num7 * P_0.SinXFor3DView;
		float num12 = P_0.CosYFor3DView * num9 + P_0.SinYFor3DView * num11;
		num11 = P_0.CosYFor3DView * num11 - P_0.SinYFor3DView * num9;
		P_10 = num10 + (float)(((Control)this).Width / 2);
		P_11 = num11;
		P_12 = num12 + (float)(num / 2);
		if (BVO && P_13)
		{
			((Control)BVn).Text = string.Concat(new string[16]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfa(),
				P_0.RotationXAngleDegrees.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfB(),
				P_0.RotationYAngleDegrees.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfb(),
				num7.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfC(),
				num8.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfc(),
				num9.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfD(),
				P_10.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfd(),
				P_11.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfE(),
				P_12.ToString()
			});
		}
	}

	private void f(object P_0, EventArgs P_1)
	{
		if (BKE != null && BKe != null)
		{
			BKe.RotationXAngleDegrees = BKE.RotationXAngleDegrees;
			BKe.RotationYAngleDegrees = BKE.RotationYAngleDegrees;
		}
		F(null, null);
	}

	protected override void MouseDownHandler(object sender, MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).Focus();
		if ((int)e.Button != 1048576)
		{
			return;
		}
		if (e.X >= ((Control)this).Width - 13 - 24 && e.Y >= 13 && e.X <= ((Control)this).Width - 13 - 4 && e.Y <= 33)
		{
			i(null, null);
			return;
		}
		BVP = e.X;
		BVp = e.Y;
		if (BKE != null)
		{
			BVQ = BKE.RotationXAngleDegrees;
			BVq = BKE.RotationYAngleDegrees;
		}
		int num = ((BKj == null || !((Control)BKj).Visible) ? (((Control)this).Height - 30) : (((Control)this).Height - (((Control)BKj).Height + 30)));
		if (BKE != null && BVP > 50 && BVP < ((Control)this).Width - 50 && BVp > 30 && BVp < num)
		{
			BVo = true;
		}
		else
		{
			base.MouseDownHandler(sender, e);
		}
	}

	protected override void MouseMoveHandler(object sender, MouseEventArgs e)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		if (e.X >= ((Control)this).Width - 13 - 24 && e.Y >= 13 && e.X <= ((Control)this).Width - 13 - 4 && e.Y <= 33)
		{
			if (!BVR)
			{
				BVR = true;
				((Control)this).Invalidate();
			}
		}
		else if (BVR)
		{
			BVR = false;
			((Control)this).Invalidate();
		}
		if ((int)e.Button != 1048576 || !BVo)
		{
			base.MouseMoveHandler(sender, e);
			return;
		}
		((Control)this).BringToFront();
		int num = e.X - BVP;
		int num2 = e.Y - BVp;
		BKE.RotationXAngleDegrees = BVQ + (float)(num / 3);
		BKE.RotationYAngleDegrees = Math.Min(Math.Max(BVq + (float)(num2 / 3), 0f), 90f);
	}

	protected override void MouseUpHandler(object sender, MouseEventArgs e)
	{
		base.MouseUpHandler(sender, e);
		BVo = false;
	}

	private void G(object P_0, EventArgs P_1)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (BKE != null)
		{
			if (BKE.HorizVertIndexPerUserSelectedCell.Count == 0)
			{
				BKE.UserCurrentCellHorizVertIndex = new Point(0, 0);
				BKE.HorizVertIndexPerUserSelectedCell.Add(new Point(0, 0));
			}
			BM.A((Control)(object)this);
		}
		((Control)this).Invalidate();
	}

	private void g(object P_0, EventArgs P_1)
	{
		BM.e();
		((Control)this).Invalidate();
	}

	private void H(object P_0, EventArgs P_1)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		BP num = (((TabControl)BM.QQ.rl).SelectedTab as ae).A();
		int selectedIndex = ((TabControl)BM.QQ.rl).SelectedIndex;
		if (num == BP.ua || BM.QQ.rl.A(selectedIndex) != this)
		{
			q.A((Control)(object)this);
			BM.QQ.rl.a(false);
		}
		else
		{
			bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfe(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfF(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void h(object P_0, EventArgs P_1)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		int num = By.A((IWin32Window)(object)BM.QQ, BKD);
		if (num != 0)
		{
			Setting setting = BKD.A(num);
			if (setting != null)
			{
				BM.QQ.rl.B(setting as Table, new Rectangle(((Control)this).Left, ((Control)this).Top, ((Control)this).Width, ((Control)this).Height));
				H(null, null);
			}
		}
	}

	private void I(object P_0, EventArgs P_1)
	{
		BM.QQ.rl.B((Control)(object)this);
	}

	internal override void a(object P_0, EventArgs P_1)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG || !BKD.C() || BKE == null || !((SettingOrSpecialObject)BKE).l())
		{
			return;
		}
		bB bB = new bB(BKE);
		if ((int)((Form)bB).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
		{
			HashSet<DataIdAndAttrId> idsContained = BKE.GetIdsContained();
			BKD.a(idsContained);
			BKD.A(idsContained, BKd, BM.qf);
			BKD.A(idsContained);
			BM.QQ.rL.A(false, true, false, false);
			BM.M();
			BM.QQ.rL.B(false);
			if (BM.Qn != null)
			{
				BM.QQ.rL.b(false);
			}
			b();
			UpdateLayout(resizingOnly: false);
			((Control)this).Focus();
		}
		((Component)bB).Dispose();
	}

	private void i(object P_0, EventArgs P_1)
	{
		if (BKE != null)
		{
			BKE.ResetViewingAngleToDefault();
		}
	}

	private void J(object P_0, EventArgs P_1)
	{
		A(!Bux);
	}

	private void j(object P_0, EventArgs P_1)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		if (((Control)this).ContextMenuStrip == null)
		{
			return;
		}
		foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
		{
			ToolStripMenuItem val = item;
			if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bff())
			{
				((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
				break;
			}
		}
	}

	private ContextMenuStrip c()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		ContextMenuStrip val = new ContextMenuStrip();
		((ToolStrip)val).BackColor = BM.tG;
		((ToolStrip)val).ForeColor = BM.te;
		((ToolStripDropDown)val).Opened += new EventHandler(j);
		if ((((TabControl)BM.QQ.rl).SelectedTab as ae).A() == BP.ua)
		{
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFV();
			((ToolStripItem)val2).Click += new EventHandler(h);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
		}
		ToolStripMenuItem val3 = new ToolStripMenuItem();
		((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfG();
		val3.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.MS();
		((ToolStripItem)val3).Click += new EventHandler(I);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
		if (BKD.C())
		{
			ToolStripMenuItem val4 = new ToolStripMenuItem();
			((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pe();
			val4.ShortcutKeys = (Keys)114;
			((ToolStripItem)val4).Click += new EventHandler(a);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
		}
		ToolStripMenuItem val5 = new ToolStripMenuItem();
		((ToolStripItem)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFz();
		((ToolStripItem)val5).Click += new EventHandler(i);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val5);
		BVr = new ToolStripMenuItem();
		((ToolStripItem)BVr).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BFw();
		((ToolStripItem)BVr).Click += new EventHandler(J);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)BVr);
		ToolStripMenuItem val6 = new ToolStripMenuItem();
		((ToolStripItem)val6).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bff();
		((ToolStripItem)val6).Click += new EventHandler(H);
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val6);
		return val;
	}

	internal void A(string P_0, int P_1, int P_2)
	{
		List<string> val = new List<string>();
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfg());
		int num = ((Control)this).Left - P_1;
		int num2 = ((Control)this).Top - P_2;
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBi() + BKF);
		if (BKE != null)
		{
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBJ() + BKE.InvertRows);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBj() + BKE.SwapColumnsAndRows);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfH() + (int)BKE.RotationXAngleDegrees);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfh() + (int)BKE.RotationYAngleDegrees);
		}
		val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
		File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
	}

	internal void A(StreamReader P_0)
	{
		string text;
		while ((text = ((TextReader)P_0).ReadLine()) != null)
		{
			if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBi()))
			{
				BKF = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBi().Length));
				if (BKD.A(BKF) != null)
				{
					((cO)this).A(BKF);
				}
			}
			else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBK()))
			{
				BKF = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBK()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBK().Length));
				if (BKD.A(BKF) != null)
				{
					((cO)this).A(BKF);
				}
			}
			else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBJ()))
			{
				if (BKE != null)
				{
					BKE.InvertRows = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBJ().Length));
				}
			}
			else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBj()))
			{
				if (BKE != null)
				{
					BKE.SwapColumnsAndRows = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBj().Length));
				}
			}
			else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfH()))
			{
				if (BKE != null)
				{
					BKE.RotationXAngleDegrees = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BfH().Length));
				}
			}
			else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfh()))
			{
				if (BKE != null)
				{
					BKE.RotationYAngleDegrees = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bfh().Length));
				}
			}
			else if (!text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bai()) && string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
	}

	private void D()
	{
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == bottomSelectedVert)
		{
			if (rightSelectedHoriz - leftSelectedHoriz + 1 >= 3)
			{
				BKE.TableDataSetting.az();
				BKE.LineariseLeftToRight(topSelectedVert, leftSelectedHoriz, rightSelectedHoriz, BKe, forHorizAxisInsertion: false);
				BKE.TableDataSetting.i(true);
				((Control)this).Invalidate();
			}
		}
		else if (leftSelectedHoriz == rightSelectedHoriz)
		{
			if (bottomSelectedVert - topSelectedVert + 1 >= 3)
			{
				BKE.TableDataSetting.az();
				BKE.LineariseTopToBottom(leftSelectedHoriz, topSelectedVert, bottomSelectedVert, BKe);
				BKE.TableDataSetting.i(true);
				((Control)this).Invalidate();
			}
		}
		else
		{
			BKE.TableDataSetting.az();
			BKE.LineariseRange(leftSelectedHoriz, rightSelectedHoriz, topSelectedVert, bottomSelectedVert, BKe);
			BKE.TableDataSetting.i(true);
			((Control)this).Invalidate();
		}
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
	}

	private void d()
	{
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (rightSelectedHoriz - leftSelectedHoriz + 1 >= 3)
		{
			BKE.TableDataSetting.az();
			for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
			{
				BKE.LineariseLeftToRight(i, leftSelectedHoriz, rightSelectedHoriz, BKe, forHorizAxisInsertion: false);
			}
			BKE.TableDataSetting.i(true);
			((Control)this).Invalidate();
		}
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
	}

	private void E()
	{
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (bottomSelectedVert - topSelectedVert + 1 >= 3)
		{
			BKE.TableDataSetting.az();
			for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
			{
				BKE.LineariseTopToBottom(i, topSelectedVert, bottomSelectedVert, BKe);
			}
			BKE.TableDataSetting.i(true);
			((Control)this).Invalidate();
		}
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
	}

	private new void A(int P_0, int P_1)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 == -1 || P_1 == -1)
		{
			return;
		}
		List<Point> val = new List<Point>();
		val.Add(new Point(P_0, P_1));
		if (BM.QO == BM.b.BpG)
		{
			BKe.UserCurrentCellHorizVertIndex = new Point(P_0, P_1);
			BKe.HorizVertIndexPerUserSelectedCell = val;
			BKE.UserCurrentCellHorizVertIndex = new Point(P_0, P_1);
			BKE.HorizVertIndexPerUserSelectedCell = val;
			return;
		}
		BKE.UserCurrentCellHorizVertIndex = new Point(P_0, P_1);
		BKE.HorizVertIndexPerUserSelectedCell = val;
		if (BKe != null)
		{
			BKe.UserCurrentCellHorizVertIndex = new Point(P_0, P_1);
			BKe.HorizVertIndexPerUserSelectedCell = val;
		}
	}

	private void e()
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (BM.QO == BM.b.BpG)
		{
			return;
		}
		int currentHoriz = 0;
		int currentVert = 0;
		int currentSlice = 0;
		BKE.GetOperatingPoint(ref currentHoriz, ref currentVert, ref currentSlice);
		int leftSelectedHoriz = 2147483647;
		int rightSelectedHoriz = -2147483648;
		int topSelectedVert = 2147483647;
		int bottomSelectedVert = -2147483648;
		BKE.GetSelectedLeftRightTopBottomIndices(out leftSelectedHoriz, out rightSelectedHoriz, out topSelectedVert, out bottomSelectedVert);
		int num = rightSelectedHoriz - leftSelectedHoriz + 1;
		int num2 = bottomSelectedVert - topSelectedVert + 1;
		int num3 = currentHoriz - num / 2;
		int num4 = currentVert - num2 / 2;
		int num5 = BKE.HorizAxisCount();
		int num6 = BKE.VertAxisCount();
		num3 = Math.Min(Math.Max(num3, 0), num5 - num);
		num4 = Math.Min(Math.Max(num4, 0), num6 - num2);
		List<Point> val = new List<Point>();
		for (int i = 0; i < num2; i++)
		{
			for (int j = 0; j < num; j++)
			{
				int num7 = num3 + j;
				int num8 = num4 + i;
				val.Add(new Point(num7, num8));
			}
		}
		BKE.UserCurrentCellHorizVertIndex = new Point(currentHoriz, currentVert);
		BKE.HorizVertIndexPerUserSelectedCell = val;
		if (BKe != null)
		{
			BKe.UserCurrentCellHorizVertIndex = new Point(currentHoriz, currentVert);
			BKe.HorizVertIndexPerUserSelectedCell = val;
		}
		BKE.UserSliceIndex = currentSlice;
		if (BKe != null)
		{
			BKe.UserSliceIndex = currentSlice;
		}
	}

	internal bool A(KeyEventArgs P_0)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		if (BM.QO == BM.b.BpG)
		{
			return false;
		}
		if (!BKD.C())
		{
			return false;
		}
		if ((!P_0.Control || (int)P_0.KeyCode != 33) && (int)P_0.KeyData != 33 && (!P_0.Shift || (int)P_0.KeyCode != 33) && (!P_0.Control || (int)P_0.KeyCode != 34) && (int)P_0.KeyData != 34 && (!P_0.Shift || (int)P_0.KeyCode != 34) && (int)P_0.KeyData != 219 && (int)P_0.KeyData != 221 && (int)P_0.KeyData != 186 && (int)P_0.KeyData != 222 && (int)P_0.KeyData != 188 && (int)P_0.KeyData != 190)
		{
			return false;
		}
		if (!((SettingOrSpecialObject)BKE).l())
		{
			return true;
		}
		Ck ck = BM.aM();
		ck?.A(BKE.TableDataSetting.A());
		BKE.IncreaseOrDecreaseSelectedCellValues(P_0);
		ck?.B();
		BM.b(BKE.TableDataSetting.A());
		return true;
	}

	protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Invalid comparison between Unknown and I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Invalid comparison between Unknown and I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Invalid comparison between Unknown and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Invalid comparison between Unknown and I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Invalid comparison between Unknown and I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Invalid comparison between Unknown and I4
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between Unknown and I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Invalid comparison between Unknown and I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Invalid comparison between Unknown and I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Invalid comparison between Unknown and I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Invalid comparison between Unknown and I4
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Invalid comparison between Unknown and I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Invalid comparison between Unknown and I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Invalid comparison between Unknown and I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Invalid comparison between Unknown and I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Invalid comparison between Unknown and I4
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Invalid comparison between Unknown and I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Invalid comparison between Unknown and I4
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Invalid comparison between Unknown and I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Invalid comparison between Unknown and I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Invalid comparison between Unknown and I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Invalid comparison between Unknown and I4
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Invalid comparison between Unknown and I4
		e.IsInputKey = (int)e.KeyData == 68 || (e.Control && (int)e.KeyCode == 33) || (e.Control && (int)e.KeyCode == 34) || (e.Shift && (int)e.KeyCode == 33) || (e.Shift && (int)e.KeyCode == 34) || (int)e.KeyData == 33 || (int)e.KeyData == 34 || (int)e.KeyData == 219 || (int)e.KeyData == 221 || (int)e.KeyData == 186 || (int)e.KeyData == 222 || (int)e.KeyData == 188 || (int)e.KeyData == 190 || (int)e.KeyData == 37 || (int)e.KeyData == 38 || (int)e.KeyData == 39 || (int)e.KeyData == 40 || (int)e.KeyData == 65573 || (int)e.KeyData == 65574 || (int)e.KeyData == 65575 || (int)e.KeyData == 65576 || (int)e.KeyData == 131109 || (int)e.KeyData == 131110 || (int)e.KeyData == 131111 || (int)e.KeyData == 131112 || (e.Control && (int)e.KeyCode == 32) || (int)e.KeyData == 27 || (int)e.KeyData == 114 || (int)e.KeyData == 131162 || (int)e.KeyData == 131161 || (int)e.KeyData == 76 || (int)e.KeyData == 72 || (int)e.KeyData == 86 || (int)e.KeyData == 32 || (int)e.KeyData == 131139 || (int)e.KeyData == 131158 || (int)e.KeyData == 196645 || (int)e.KeyData == 196646 || (int)e.KeyData == 196647 || (int)e.KeyData == 196648;
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Invalid comparison between Unknown and I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Invalid comparison between Unknown and I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Invalid comparison between Unknown and I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Invalid comparison between Unknown and I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Invalid comparison between Unknown and I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Invalid comparison between Unknown and I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Invalid comparison between Unknown and I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Invalid comparison between Unknown and I4
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Invalid comparison between Unknown and I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Invalid comparison between Unknown and I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Invalid comparison between Unknown and I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Invalid comparison between Unknown and I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Invalid comparison between Unknown and I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Invalid comparison between Unknown and I4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Invalid comparison between Unknown and I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Invalid comparison between Unknown and I4
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Invalid comparison between Unknown and I4
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Invalid comparison between Unknown and I4
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Invalid comparison between Unknown and I4
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Invalid comparison between Unknown and I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Invalid comparison between Unknown and I4
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Invalid comparison between Unknown and I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Invalid comparison between Unknown and I4
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Invalid comparison between Unknown and I4
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Invalid comparison between Unknown and I4
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Invalid comparison between Unknown and I4
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Invalid comparison between Unknown and I4
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Invalid comparison between Unknown and I4
		if (BKe != null && (BKi || BKJ) && BM.QO == BM.b.BpF)
		{
			return;
		}
		if ((int)e.KeyData == 68)
		{
			I(null, null);
		}
		if ((BKE != null && BKE.HorizVertIndexPerUserSelectedCell.Count == 0) || !BKD.C() || (e.Control && (int)e.KeyCode == 33) || (e.Control && (int)e.KeyCode == 34) || (e.Shift && (int)e.KeyCode == 33) || (e.Shift && (int)e.KeyCode == 34) || (int)e.KeyData == 33 || (int)e.KeyData == 34 || (int)e.KeyData == 219 || (int)e.KeyData == 221 || (int)e.KeyData == 186 || (int)e.KeyData == 222 || (int)e.KeyData == 188 || (int)e.KeyData == 190 || BKE == null)
		{
			return;
		}
		if ((int)e.KeyData == 37)
		{
			BKE.MoveSelectionLeft(BKe);
		}
		else if ((int)e.KeyData == 38)
		{
			BKE.MoveSelectionUp(BKe);
		}
		else if ((int)e.KeyData == 39)
		{
			BKE.MoveSelectionRight(BKe);
		}
		else if ((int)e.KeyData == 40)
		{
			BKE.MoveSelectionDown(BKe);
		}
		else if ((int)e.KeyData == 65573)
		{
			BKE.IncreaseSelectionSizeOnLeft(BKe);
		}
		else if ((int)e.KeyData == 65574)
		{
			BKE.IncreaseSelectionSizeOnTop(BKe);
		}
		else if ((int)e.KeyData == 65575)
		{
			BKE.IncreaseSelectionSizeOnRight(BKe);
		}
		else if ((int)e.KeyData == 65576)
		{
			BKE.IncreaseSelectionSizeOnBottom(BKe);
		}
		else if ((int)e.KeyData == 131109)
		{
			BKE.DecreaseSelectionSizeOnRight();
		}
		else if ((int)e.KeyData == 131110)
		{
			BKE.DecreaseSelectionSizeOnBottom();
		}
		else if ((int)e.KeyData == 131111)
		{
			BKE.DecreaseSelectionSizeOnLeft();
		}
		else if ((int)e.KeyData == 131112)
		{
			BKE.DecreaseSelectionSizeOnTop();
		}
		else if ((e.Control && (int)e.KeyCode == 32) || (int)e.KeyData == 27)
		{
			Point userCurrentCellHorizVertIndex = BKE.UserCurrentCellHorizVertIndex;
			int x = ((Point)(ref userCurrentCellHorizVertIndex)).X;
			userCurrentCellHorizVertIndex = BKE.UserCurrentCellHorizVertIndex;
			A(x, ((Point)(ref userCurrentCellHorizVertIndex)).Y);
		}
		else
		{
			if (!((SettingOrSpecialObject)BKE).l() || BM.QO == BM.b.BpG)
			{
				return;
			}
			if ((int)e.KeyData == 114)
			{
				a(null, null);
			}
			else if ((int)e.KeyData == 131162)
			{
				BM.QQ.ak(null, null);
			}
			else if ((int)e.KeyData == 131161)
			{
				BM.QQ.aL(null, null);
			}
			else if ((int)e.KeyData == 76)
			{
				D();
			}
			else if ((int)e.KeyData == 72)
			{
				d();
			}
			else if ((int)e.KeyData == 86)
			{
				E();
			}
			else if ((int)e.KeyData == 32)
			{
				this.e();
			}
			else if ((int)e.KeyData == 131139)
			{
				BKE.CopyCellValuesToClipboard(BKe);
			}
			else if ((int)e.KeyData == 131158)
			{
				BKE.C(BKe, null);
			}
			else if (BKe != null || (!BKi && !BKJ) || BM.QO != 0)
			{
				if ((int)e.KeyData == 196645)
				{
					BKE.A(BKe, null);
				}
				else if ((int)e.KeyData == 196646)
				{
					BKE.B(BKe, null);
				}
				else if ((int)e.KeyData == 196647)
				{
					BKE.a(BKe, null);
				}
				else if ((int)e.KeyData == 196648)
				{
					BKE.b(BKe, null);
				}
			}
		}
	}
}
