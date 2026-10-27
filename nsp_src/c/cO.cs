using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using C;
using D;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace c
{
	internal abstract class cO : MovableResizablePanel
	{
		protected new struct A
		{
			internal bool Bvv;

			internal int BvW;

			internal int Bvw;

			internal int[] BvX;
		}

		protected new class a : Control
		{
			internal class A
			{
				internal string bat;

				internal Color baU;
			}

			internal List<A> Bvx = new List<A>();

			private const int BvY = 14;

			private const int Bvy = 100;

			private const int BvZ = 54;

			private const int Bvz = 50;

			private cO BWA;

			private int BWa;

			internal int BWB = 10;

			internal int BWb;

			internal PictureBox BWC = new PictureBox();

			private int BWc;

			private bool BWD;

			internal a(cO P_0)
			{
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Expected O, but got Unknown
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_00db: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e5: Expected O, but got Unknown
				((Control)this).AutoSize = false;
				((Control)this).Height = 44;
				BWA = P_0;
				((Control)this).SetStyle((ControlStyles)8192, true);
				((Control)this).SetStyle((ControlStyles)131072, true);
				((Control)this).SetStyle((ControlStyles)2, true);
				((Control)BWC).Size = new Size(32, 32);
				BWC.Image = (Image)(object)GeneralResources.YellowWarning;
				((Control)BWC).Left = 100;
				((Control)BWC).Top = ((Control)this).Height - 35;
				((Control)BWC).Visible = false;
				((Control)this).Controls.Add((Control)(object)BWC);
				((Control)BWC).Visible = false;
				PictureBox bWC = BWC;
				cO bWA = BWA;
				((Control)bWC).DoubleClick += new EventHandler(bWA.a);
			}

			protected override void Dispose(bool disposing)
			{
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Expected O, but got Unknown
				try
				{
					PictureBox bWC = BWC;
					cO bWA = BWA;
					((Control)bWC).DoubleClick -= new EventHandler(bWA.a);
					((Control)this).Dispose(disposing);
				}
				catch
				{
				}
			}

			private void A(Graphics P_0)
			{
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001f: Expected O, but got Unknown
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0031: Expected O, but got Unknown
				Pen val = ((BM.Tn != 0 && BM.Tn != BM.r.Bqh) ? new Pen(Color.White, 4f) : new Pen(Color.Gray, 4f));
				P_0.DrawLine(val, 154, 7, ((Control)this).Width - 50, 7);
				val.Dispose();
			}

			private void a(Graphics P_0)
			{
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Expected O, but got Unknown
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Expected O, but got Unknown
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_009a: Expected O, but got Unknown
				Pen val = ((BM.Tn != 0 && BM.Tn != BM.r.Bqh) ? Pens.White : Pens.Gray);
				for (int i = 0; i <= BWB; i++)
				{
					int num = 154 + i * (((Control)this).Width - 205) / BWB;
					P_0.DrawLine(val, num, 9, num, 15);
					if (Bvx.Count != BWB + 1)
					{
						continue;
					}
					StringFormat val2 = new StringFormat();
					try
					{
						SolidBrush val3 = new SolidBrush(Bvx[i].baU);
						try
						{
							Font val4 = new Font(((Control)this).Font.FontFamily, 9f);
							try
							{
								val2.Alignment = (StringAlignment)1;
								val2.LineAlignment = (StringAlignment)1;
								P_0.DrawString(Bvx[i].bat, val4, (Brush)(object)val3, (float)num, 34f, val2);
							}
							finally
							{
								((System.IDisposable)val4)?.Dispose();
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
			}

			private void B(Graphics P_0)
			{
				P_0.FillEllipse(Brushes.DodgerBlue, 154 + BWb * (((Control)this).Width - 205) / BWB - 7, 0, 14, 14);
			}

			private void b(Graphics P_0)
			{
				//IL_0255: Unknown result type (might be due to invalid IL or missing references)
				//IL_025a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0268: Unknown result type (might be due to invalid IL or missing references)
				//IL_026d: Unknown result type (might be due to invalid IL or missing references)
				//IL_027b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0280: Unknown result type (might be due to invalid IL or missing references)
				AxisBehaviour axisBehaviour = BWA.BKE.SliceAxis.I();
				int num = BWA.BKE.SliceCount();
				int num2 = BWA.BKg.ax();
				int num3 = BWA.BKE.SliceAxis.G().m(0);
				int num4 = BWA.BKE.SliceAxis.G().m(num - 1);
				float num5 = ((num <= 1) ? ((float)(((Control)this).Width - 205)) : ((float)(((Control)this).Width - 205) / (float)(num - 1)));
				int num6 = 0;
				if (num2 >= num4)
				{
					num6 = ((Control)this).Width - 51;
				}
				else if (num2 <= num3)
				{
					num6 = 154;
				}
				else
				{
					switch (axisBehaviour)
					{
					case AxisBehaviour.DiscreteCentred:
					{
						for (int i = 1; i < num; i++)
						{
							int num13 = BWA.BKE.SliceAxis.G().m(i - 1);
							int num14 = BWA.BKE.SliceAxis.G().m(i);
							int num15 = num13 + num14 >> 1;
							if (num2 == num13 || num2 < num15 || i == num - 1)
							{
								int num16 = ((num2 != num13 && num2 >= num15) ? i : (i - 1));
								int num17 = (int)Math.Round((double)((float)num16 * num5));
								num6 = 154 + num17;
								break;
							}
						}
						break;
					}
					case AxisBehaviour.Continuous:
					{
						int num7 = 0;
						for (int num8 = num - 1; num8 >= 0; num8--)
						{
							int num9 = BWA.BKE.SliceAxis.G().m(num8);
							if (num2 > num9)
							{
								num7 = num8;
								break;
							}
						}
						if (num7 == num - 1)
						{
							num7--;
						}
						int num10 = BWA.BKE.SliceAxis.G().m(num7);
						int num11 = BWA.BKE.SliceAxis.G().m(num7 + 1);
						int num12 = (int)Math.Round((double)((float)num7 * num5));
						num6 = ((num11 == num10) ? 154 : (154 + num12 + (num2 - num10) * (int)Math.Round((double)num5) / (num11 - num10)));
						break;
					}
					}
				}
				Point[] array = (Point[])(object)new Point[3]
				{
					new Point(num6, 17),
					new Point(num6 - 6, 25),
					new Point(num6 + 5, 25)
				};
				P_0.FillPolygon(Brushes.DodgerBlue, array);
			}

			protected override void OnPaint(PaintEventArgs e)
			{
				if (BWB == 0)
				{
					return;
				}
				Graphics graphics = e.Graphics;
				A(graphics);
				a(graphics);
				C(graphics);
				graphics.SmoothingMode = (SmoothingMode)2;
				B(graphics);
				if (BM.QO != BM.b.BpG && ((BM.A(((SettingOrSpecialObject)BWA.BKE).A().aXc, true) && !BM.aE()) || (BWA.BKg != null && BM.C(BWA.BKg.A()))))
				{
					b(graphics);
				}
				if (BWb != BWa)
				{
					int userSliceIndex = 0;
					Table table = ((BM.QO != BM.b.BpG) ? BWA.BKE : BWA.BKe);
					if (table != null && table.SlicesEnabled())
					{
						userSliceIndex = BWb;
					}
					BWA.BKE.UserSliceIndex = userSliceIndex;
					if (BWA.BKe != null)
					{
						BWA.BKe.UserSliceIndex = userSliceIndex;
					}
					BWa = BWb;
				}
			}

			protected override void OnMouseWheel(MouseEventArgs e)
			{
				((Control)this).OnMouseWheel(e);
				if (SystemInformation.MouseWheelScrollLines == 0)
				{
					return;
				}
				BWc += e.Delta;
				int num = (int)((float)BWc / 120f);
				if (num != 0)
				{
					if (num > 0)
					{
						int num2 = num;
						BWb = Math.Min(num2 + BWb, BWB);
						BWc -= (int)((float)num * 120f);
					}
					else
					{
						int num2 = -num;
						BWb = Math.Max(BWb - num2, 0);
						BWc -= (int)((float)num * 120f);
					}
				}
			}

			protected override void OnMouseDown(MouseEventArgs e)
			{
				if (e.X <= 134 || BWB == 0)
				{
					return;
				}
				BWD = true;
				int num = (((Control)this).Width - 205) / BWB / 2;
				for (int i = 0; i <= BWB; i++)
				{
					int num2 = 154 + i * (((Control)this).Width - 205) / BWB;
					if (e.X > num2 - num && e.X < num2 + num)
					{
						if (BWb != i)
						{
							BWb = i;
							((Control)this).Invalidate();
						}
						break;
					}
				}
			}

			protected override void OnMouseMove(MouseEventArgs e)
			{
				if (!BWD)
				{
					return;
				}
				int num = (((Control)this).Width - 205) / BWB / 2;
				for (int i = 0; i <= BWB; i++)
				{
					int num2 = 154 + i * (((Control)this).Width - 205) / BWB;
					if (e.X > num2 - num && e.X < num2 + num)
					{
						if (BWb != i)
						{
							BWb = i;
							((Control)this).Invalidate();
						}
						break;
					}
				}
			}

			protected override void OnMouseUp(MouseEventArgs e)
			{
				BWD = false;
			}

			private void C(Graphics P_0)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0021: Expected O, but got Unknown
				//IL_0239: Unknown result type (might be due to invalid IL or missing references)
				//IL_023e: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fd: Expected O, but got Unknown
				//IL_0349: Unknown result type (might be due to invalid IL or missing references)
				//IL_034b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0320: Unknown result type (might be due to invalid IL or missing references)
				//IL_0325: Unknown result type (might be due to invalid IL or missing references)
				//IL_0337: Unknown result type (might be due to invalid IL or missing references)
				//IL_0339: Unknown result type (might be due to invalid IL or missing references)
				//IL_0340: Expected O, but got Unknown
				//IL_0276: Unknown result type (might be due to invalid IL or missing references)
				//IL_027b: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_0298: Unknown result type (might be due to invalid IL or missing references)
				//IL_029a: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a1: Expected O, but got Unknown
				//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02db: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e2: Expected O, but got Unknown
				//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
				SolidBrush val = new SolidBrush(BM.te);
				try
				{
					Font val2 = new Font(((Control)this).Font.FontFamily, 10f);
					try
					{
						bool flag = true;
						Setting setting;
						if (!(BWA is DC))
						{
							setting = ((BM.QO != BM.b.BpG) ? BWA.BKg : BWA.BKI);
						}
						else
						{
							Table table;
							if (BM.QO == BM.b.BpG)
							{
								table = BWA.BKe;
								setting = BWA.BKI;
							}
							else
							{
								table = BWA.BKE;
								setting = BWA.BKg;
							}
							flag = table.SlicesEnabled();
							if (BWA.BKe != null)
							{
								if (table == BWA.BKE)
								{
									flag = BWA.BKe.SlicesEnabled();
								}
								else if (table == BWA.BKe)
								{
									flag = BWA.BKE.SlicesEnabled();
								}
							}
						}
						string text = string.Empty;
						int num = setting.aS();
						if (num != 0 && num != 82)
						{
							text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + bS.A(setting.@as(), num, false, 0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
						}
						bool flag2 = true;
						bool flag3 = true;
						Font val3;
						if (BWA is DC)
						{
							flag2 = flag && (BWA.BKe == null || (BWA.BKI != null && BWA.BKI.A() == BWA.BKg.A()));
							if (BWA.BKk != null && BWA.BKK.aa())
							{
								flag3 = BWA.BKM[0].Bvv && ((BWA.BKg.A() == BWA.BKM[0].BvW) ? true : false);
							}
							val3 = (Font)(flag3 ? ((object)val2) : ((object)new Font(val2, (FontStyle)2)));
						}
						else
						{
							val3 = val2;
						}
						string text2 = ((SettingOrSpecialObject)setting).H();
						string text3 = (string.IsNullOrWhiteSpace(text2) ? ((SettingOrSpecialObject)setting).A(bz.aYT) : text2);
						text3 += text;
						SizeF val4 = P_0.MeasureString(text3, val3, 100);
						int num2 = (int)((SizeF)(ref val4)).Height;
						Rectangle val5 = default(Rectangle);
						((Rectangle)(ref val5))._002Ector(0, 0, 100, num2);
						bool flag4 = false;
						if (BWA is DC)
						{
							if (num2 > ((Control)this).Height)
							{
								FontStyle style = val3.Style;
								if (!flag3)
								{
									val3.Dispose();
								}
								val3 = new Font(((Control)this).Font.FontFamily, 8f, style);
								flag4 = true;
							}
							if (flag2 || BWA.BKi || BWA.BKJ)
							{
								P_0.DrawString(text3, val3, (Brush)(object)val, RectangleF.op_Implicit(val5));
							}
							else
							{
								SolidBrush val6 = new SolidBrush(BM.tD);
								try
								{
									P_0.DrawString(text3, val3, (Brush)(object)val6, RectangleF.op_Implicit(val5));
								}
								finally
								{
									((System.IDisposable)val6)?.Dispose();
								}
							}
							if (flag4 || !flag3)
							{
								val3.Dispose();
							}
						}
						else
						{
							if (num2 > ((Control)this).Height)
							{
								FontStyle style2 = val3.Style;
								val3 = new Font(((Control)this).Font.FontFamily, 8f, style2);
								flag4 = true;
							}
							P_0.DrawString(text3, val3, (Brush)(object)val, RectangleF.op_Implicit(val5));
							if (flag4)
							{
								val3.Dispose();
							}
						}
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
			}

			protected override void OnGotFocus(EventArgs e)
			{
				if (BWA is DC)
				{
					(BWA as DC).b();
				}
				else
				{
					((Control)BWA).Focus();
				}
			}
		}

		protected Framework BKD;

		protected Framework BKd;

		protected Table BKE;

		protected Table BKe;

		protected int BKF = -1;

		protected Setting BKf;

		protected Setting BKG;

		protected Setting BKg;

		protected Setting BKH;

		protected Setting BKh;

		protected Setting BKI;

		protected bool BKi;

		protected bool BKJ;

		protected a BKj;

		protected MenuNode BKK;

		protected Cn BKk;

		protected string BKL;

		protected double[,,] BKl;

		protected A[] BKM;

		public cO(Framework P_0, Framework P_1, Rectangle P_2, bool P_3)
			: base(P_2, P_3, false, true)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			BKD = P_0;
			BKd = P_1;
			BKj = new a(this);
			_ = ((Control)BKj).Handle;
			BM.QQ.B(new EventHandler(A));
		}

		protected virtual void A(object P_0, EventArgs P_1)
		{
			if (BKE != null)
			{
				a();
				((Control)this).Controls.Clear();
				A(((Setting)BKE).A());
				((Control)this).Invalidate();
			}
		}

		protected abstract void a();

		internal abstract void A(int P_0);

		internal abstract void a(object P_0, EventArgs P_1);
	}
	internal class co : MovableResizablePanel
	{
		internal const int BKm = 10;

		private const int BKN = 1000;

		private const int BKn = 30;

		private const int BKO = 50;

		private const int BKo = 10;

		private const int BKP = 8;

		private const int BKp = 10;

		private const int BKQ = 115;

		private const int BKq = 2;

		private const int BKR = 2;

		private const int BKr = 15;

		private const int BKS = 26;

		private const int BKs = 15;

		private const int BKT = 3;

		private const int BKt = 1000000000;

		private const int BKU = -1000000000;

		internal static Color[] BKu = (Color[])(object)new Color[10];

		private Framework BKV;

		private int BKv = 115;

		private int BKW = 2;

		private int BKw = 2;

		private int BKX = 10000;

		private bool BKx;

		private double BKY;

		private double BKy;

		private List<Setting> BKZ = new List<Setting>();

		private List<int> BKz = new List<int>();

		private Dictionary<int, int> BkA = new Dictionary<int, int>();

		private Dictionary<int, int> Bka = new Dictionary<int, int>();

		private Dictionary<int, int> BkB = new Dictionary<int, int>();

		private List<bool> Bkb = new List<bool>();

		private List<o> BkC = new List<o>();

		private int Bkc;

		private Stopwatch BkD = new Stopwatch();

		private int[,] Bkd = new int[10, 1000];

		private int[] BkE = new int[1000];

		private List<List<aC.b>> Bke = new List<List<aC.b>>();

		private List<List<int>> BkF = new List<List<int>>();

		private List<List<Color>> Bkf = new List<List<Color>>();

		private List<List<int>> BkG = new List<List<int>>();

		private List<List<int>> Bkg = new List<List<int>>();

		private Rectangle BkH;

		private long Bkh;

		private int BkI;

		private int Bki;

		private bool BkJ;

		private bool Bkj;

		private bool BkK;

		private int Bkk;

		private int BkL;

		private bool Bkl;

		private bool BkM;

		private int Bkm = 2;

		private int BkN = 2;

		private static Stopwatch Bkn = new Stopwatch();

		internal co(Framework P_0, Rectangle P_1, bool P_2)
			: base(P_1, P_2, false, true)
		{
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected O, but got Unknown
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected O, but got Unknown
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Expected O, but got Unknown
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected O, but got Unknown
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			BKV = P_0;
			((Control)this).ContextMenuStrip = C();
			global::A.A.A(new EventHandler(C));
			global::A.A.A((global::A.D)C);
			BM.D(new EventHandler(C));
			BM.E(new EventHandler(C));
			((Control)this).DoubleBuffered = true;
			BKu[0] = Color.Red;
			BKu[1] = Color.SkyBlue;
			BKu[2] = Color.LightGreen;
			BKu[3] = Color.Yellow;
			BKu[4] = Color.PeachPuff;
			BKu[5] = Color.LightCoral;
			BKu[6] = Color.PaleTurquoise;
			BKu[7] = Color.White;
			BKu[8] = Color.Orange;
			BKu[9] = Color.Pink;
			aC.A(new EventHandler(B));
			aC.A((EventHandler<aC.D>)A);
			((Control)this).PreviewKeyDown += new PreviewKeyDownEventHandler(A);
			BkH = new Rectangle(10, 18, ((Control)this).Width - 20 - 50 - 10 - 1, ((Control)this).Height - 20 - 30 - 8 - 1);
		}

		private void A(object P_0, PreviewKeyDownEventArgs P_1)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Invalid comparison between Unknown and I4
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Invalid comparison between Unknown and I4
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Invalid comparison between Unknown and I4
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Invalid comparison between Unknown and I4
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Invalid comparison between Unknown and I4
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Invalid comparison between Unknown and I4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Invalid comparison between Unknown and I4
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Invalid comparison between Unknown and I4
			P_1.IsInputKey = true;
			if (((uint)BM.qI & 0x1000u) != 0)
			{
				aC rn = BM.QQ.rn;
				if ((int)P_1.KeyCode == 38)
				{
					rn.A(true);
				}
				else if ((int)P_1.KeyCode == 40)
				{
					rn.A(false);
				}
				else if (P_1.Shift && (int)P_1.KeyCode == 37)
				{
					rn.A(aC.e.BLz, true);
				}
				else if (P_1.Shift && (int)P_1.KeyCode == 39)
				{
					rn.A(aC.e.BLz, false);
				}
				else if (P_1.Control && (int)P_1.KeyCode == 37)
				{
					rn.A(aC.e.BLy, true);
				}
				else if (P_1.Control && (int)P_1.KeyCode == 39)
				{
					rn.A(aC.e.BLy, false);
				}
				else if ((int)P_1.KeyCode == 37)
				{
					rn.A(aC.e.BLZ, true);
				}
				else if ((int)P_1.KeyCode == 39)
				{
					rn.A(aC.e.BLZ, false);
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
			try
			{
				Enumerator<Setting> enumerator = BKZ.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.a(new EventHandler(b));
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					((ToolStripItem)item).Click -= new EventHandler(d);
					((ToolStripItem)item).Click -= new EventHandler(D);
					((ToolStripItem)item).Click -= new EventHandler(c);
				}
				((ToolStripDropDown)((Control)this).ContextMenuStrip).Opened -= new EventHandler(E);
				global::A.A.a(new EventHandler(C));
				global::A.A.a((global::A.D)C);
				BM.d(new EventHandler(C));
				BM.e(new EventHandler(C));
				aC.a(new EventHandler(B));
				aC.a((EventHandler<aC.D>)A);
				((Control)this).PreviewKeyDown -= new PreviewKeyDownEventHandler(A);
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		public override string ToString()
		{
			string text = ((Panel)this).ToString();
			return string.Concat(new string[7]
			{
				text,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMY(),
				BKZ.Count.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaU(),
				((Control)this).Left.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAz(),
				((Control)this).Top.ToString()
			});
		}

		private new int A(int P_0, int P_1)
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			num = ((P_0 < 100) ? 10 : ((P_0 <= 1000 && P_0 > 100) ? 100 : ((P_0 <= 10000 && P_0 > 1000) ? 1000 : ((P_0 > 100000 || P_0 <= 10000) ? 100000 : 10000))));
			Size val = TextRenderer.MeasureText(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBk(), ((Control)this).Font);
			int num2 = P_1 / (((Size)(ref val)).Width * 2);
			while (P_0 / num < num2 && num % 2 <= 0)
			{
				num /= 2;
			}
			return num;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_0b1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b26: Expected O, but got Unknown
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected O, but got Unknown
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_070a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a29: Expected O, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected O, but got Unknown
			//IL_0bdc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e3: Expected O, but got Unknown
			//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Expected O, but got Unknown
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Expected O, but got Unknown
			//IL_0800: Unknown result type (might be due to invalid IL or missing references)
			//IL_080a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0811: Expected O, but got Unknown
			//IL_0829: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0405: Expected O, but got Unknown
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0430: Unknown result type (might be due to invalid IL or missing references)
			//IL_0437: Expected O, but got Unknown
			//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ae: Expected O, but got Unknown
			//IL_0437: Unknown result type (might be due to invalid IL or missing references)
			//IL_0441: Unknown result type (might be due to invalid IL or missing references)
			//IL_0448: Expected O, but got Unknown
			//IL_057a: Unknown result type (might be due to invalid IL or missing references)
			//IL_057f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0586: Expected O, but got Unknown
			Stopwatch val = new Stopwatch();
			val.Start();
			base.OnPaint(e);
			B();
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = (SmoothingMode)2;
			int num = 10;
			int num2 = ((Control)this).Height - 10 - 1;
			int num3 = num2 - num;
			int num4 = 10;
			int num5 = ((Control)this).Width - 10 - 1;
			int num6 = num5 - num4;
			int num7 = num + 8;
			int num8 = num2 - 30;
			int num9 = num8 - num7;
			int num10 = aC.Gt - aC.GT;
			if (num10 == 0)
			{
				num10 = 1;
			}
			graphics.FillRectangle(Brushes.Black, num4, num, num6, num3);
			Pen val2 = new Pen(Color.Gray, 1f);
			try
			{
				graphics.DrawRectangle(val2, num4, num, num6, num3);
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			if (((uint)BM.qI & 0x1000u) != 0)
			{
				int num11 = num6 - 60;
				int num12 = num4 + num11;
				int num13 = A(num10, num11);
				int num14 = num13 + (aC.GT - aC.GS) / num13 * num13;
				Font val3 = new Font(((Control)this).Font.FontFamily, 8f);
				try
				{
					StringFormat val4 = new StringFormat();
					try
					{
						SolidBrush val5 = new SolidBrush(Color.White);
						try
						{
							Pen val6 = new Pen(Color.White, 1f);
							try
							{
								val4.Alignment = (StringAlignment)1;
								graphics.DrawLine(val6, num5 - 60, num, num5 - 60, num2);
								graphics.DrawLine(val6, num5 - 10, num, num5 - 10, num2);
								int num15 = num14;
								for (int i = num4; i <= num12; i++)
								{
									float num16 = (float)(i - num4) / (float)num11;
									float num17 = (float)(i - num4 + 1) / (float)num11;
									int num18 = (int)((float)(aC.GT - aC.GS) + num16 * (float)num10);
									int num19 = (int)((float)(aC.GT - aC.GS) + num17 * (float)num10);
									if (num15 >= num18 && num15 < num19)
									{
										graphics.DrawLine(val6, i, num8, i, num8 + 4);
										string text = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBL(), (object)((float)num15 / 1000f));
										graphics.DrawString(text, val3, (Brush)(object)val5, (float)i, (float)(num8 + 5), val4);
										num15 += num13;
									}
								}
							}
							finally
							{
								((System.IDisposable)val6)?.Dispose();
							}
						}
						finally
						{
							((System.IDisposable)val5)?.Dispose();
						}
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
			}
			else
			{
				Pen val7 = new Pen(Color.White, 1f);
				try
				{
					for (int j = 1; j < 10; j++)
					{
						int num20 = num4 + j * (num6 - 60) / 10;
						graphics.DrawLine(val7, num20, num8, num20, num8 + 4);
					}
					graphics.DrawLine(val7, num5 - 60, num, num5 - 60, num2);
					graphics.DrawLine(val7, num5 - 10, num, num5 - 10, num2);
				}
				finally
				{
					((System.IDisposable)val7)?.Dispose();
				}
				Font val8 = new Font(((Control)this).Font.FontFamily, 8f);
				try
				{
					StringFormat val9 = new StringFormat();
					try
					{
						SolidBrush val10 = new SolidBrush(Color.White);
						try
						{
							val9.Alignment = (StringAlignment)1;
							_ = (float)num10 / 10f;
							for (int k = 1; k < 10; k++)
							{
								float num21 = (float)BKX * (float)k / 10f / 1000f;
								string text2 = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBl(), (object)num21);
								graphics.DrawString(text2, val8, (Brush)(object)val10, (float)(num4 + (10 - k) * (num6 - 60) / 10), (float)(num8 + 5), val9);
							}
							graphics.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eb(), val8, (Brush)(object)val10, (float)(num4 + (num6 - 60) / 2), (float)(num8 + 16), val9);
						}
						finally
						{
							((System.IDisposable)val10)?.Dispose();
						}
					}
					finally
					{
						((System.IDisposable)val9)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val8)?.Dispose();
				}
			}
			if (Bkc < BKZ.Count && BkB.ContainsKey(BKZ[Bkc].A()))
			{
				Font val11 = new Font(((Control)this).Font.FontFamily, 8f);
				try
				{
					SolidBrush val12 = new SolidBrush(BKu[BkB[BKZ[Bkc].A()]]);
					try
					{
						Pen val13 = new Pen(Color.DimGray, 1f);
						try
						{
							val13.DashStyle = (DashStyle)2;
							for (int l = 0; l < BkC[Bkc].F().Length; l++)
							{
								float num22 = BkC[Bkc].e()[l];
								int num23 = (int)BkC[Bkc].F()[l];
								if (num23 >= num + 1)
								{
									graphics.SmoothingMode = (SmoothingMode)3;
									graphics.DrawLine(val13, num4, num23, num5 - 60 + 4, num23);
									graphics.SmoothingMode = (SmoothingMode)2;
								}
								if (num23 - 6 >= num + 1)
								{
									graphics.DrawString(num22.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BAQ()), val11, (Brush)(object)val12, (float)(num5 - 60 + 7), (float)(num23 - 6));
								}
							}
						}
						finally
						{
							((System.IDisposable)val13)?.Dispose();
						}
					}
					finally
					{
						((System.IDisposable)val12)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val11)?.Dispose();
				}
				if (!BKx)
				{
					try
					{
						A(out var num24, out var num25);
						int num26 = num5 - 10 + 2;
						int num27 = num5 - 2;
						SolidBrush val14 = new SolidBrush(BKu[BkB[BKZ[Bkc].A()]]);
						try
						{
							graphics.FillRectangle((Brush)(object)val14, num26, num24, num27 - num26, num25 - num24);
						}
						finally
						{
							((System.IDisposable)val14)?.Dispose();
						}
						graphics.DrawLine(Pens.Black, num26, num24 + 10, num27, num24 + 10);
						graphics.DrawLine(Pens.Black, num26, num25 - 10, num27, num25 - 10);
						graphics.DrawLine(Pens.Gray, num5 - 10, num + 10, num5, num + 10);
						graphics.DrawLine(Pens.Gray, num5 - 10, num2 - 10, num5, num2 - 10);
					}
					catch (System.Exception ex)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBM() + ex.Message, true);
					}
				}
			}
			List<int> val15 = new List<int>();
			for (int m = 0; m < BKZ.Count; m++)
			{
				if (m != Bkc)
				{
					val15.Add(m);
				}
			}
			val15.Add(Bkc);
			bool[] array = new bool[BKZ.Count];
			bool flag = BM.aE();
			if (((uint)BM.qI & 0x1000u) != 0)
			{
				if (BKZ.Count > 0)
				{
					Rectangle val16 = default(Rectangle);
					((Rectangle)(ref val16))._002Ector(num4, num - 1, num6 - 60, num8 - num + 2);
					graphics.SetClip(val16, (CombineMode)0);
					A(e.Graphics, BKZ[Bkc].A(), BKu[BkB[BKZ[Bkc].A()]]);
					graphics.ResetClip();
				}
				for (int n = 0; n < BKZ.Count; n++)
				{
					int num28 = val15[n];
					Setting setting = BKZ[num28];
					array[n] = ((SettingOrSpecialObject)setting).l() && PortFunction.A(setting);
				}
			}
			else
			{
				Rectangle val18 = default(Rectangle);
				for (int num29 = 0; num29 < BKZ.Count; num29++)
				{
					int num30 = val15[num29];
					Setting setting2 = BKZ[num30];
					array[num29] = ((SettingOrSpecialObject)setting2).l() && PortFunction.A(setting2);
					if (!array[num29] || !Bkb[num30] || ((!BM.A(BKV.aXc, true) || flag) && !BM.C(setting2.A())))
					{
						continue;
					}
					Pen val17 = new Pen(BKu[BkB[setting2.A()]], 1f);
					try
					{
						((Rectangle)(ref val18))._002Ector(num4, num - 1, num6 - 60, num8 - num + 2);
						graphics.SetClip(val18, (CombineMode)0);
						int num31 = 0;
						int num32 = 0;
						int num33 = 0;
						long num34;
						if (BKx)
						{
							num33 = bS.A(BKY, setting2.aS());
							num34 = (long)bS.A(BKy, setting2.aS()) - (long)num33;
						}
						else
						{
							num34 = (long)Bka[setting2.A()] - (long)BkA[setting2.A()];
						}
						if (num34 == 0L)
						{
							num34 = 1L;
						}
						int num35 = 0;
						GraphicsPath val19 = new GraphicsPath();
						try
						{
							int num36 = 999;
							while (num36 >= 0 && BkE[num36] != 0 && (num31 == 0 || num31 > num4))
							{
								int num37 = Bkd[num30, num36];
								int num38 = num5 - 60 - num35 * (num6 - 60) / BKX;
								int num39 = (int)((!BKx) ? (num8 - num9 * ((long)num37 - (long)BkA[setting2.A()]) / num34) : (num8 - num9 * ((long)num37 - (long)num33) / num34));
								num39 = Math.Min(Math.Max(num39, -1000000000), 1000000000);
								if (num36 != 999)
								{
									val19.AddLine(num31, num32, num38, num39);
									num35 += BkE[num36];
								}
								num31 = num38;
								num32 = num39;
								num36--;
							}
							try
							{
								graphics.DrawPath(val17, val19);
							}
							catch (System.Exception ex2)
							{
								N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBm() + ex2.Message, true);
							}
						}
						finally
						{
							((System.IDisposable)val19)?.Dispose();
						}
						graphics.ResetClip();
					}
					finally
					{
						((System.IDisposable)val17)?.Dispose();
					}
				}
			}
			if (((uint)BM.qI & 0x1000u) != 0 && BKZ.Count > 0)
			{
				Pen val20 = new Pen(Color.White, 1f);
				try
				{
					val20.DashStyle = (DashStyle)1;
					try
					{
						int num40 = (int)((long)(aC.Gr - aC.GT) * (long)((Rectangle)(ref BkH)).Width / num10);
						if (num40 + ((Rectangle)(ref BkH)).Left < ((Rectangle)(ref BkH)).Right && num40 + ((Rectangle)(ref BkH)).Left > ((Rectangle)(ref BkH)).Left)
						{
							e.Graphics.DrawLine(val20, num40 + ((Rectangle)(ref BkH)).Left, 10, num40 + ((Rectangle)(ref BkH)).Left, ((Rectangle)(ref BkH)).Bottom);
						}
					}
					catch (System.Exception ex3)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBN() + ex3.Message, true);
					}
				}
				finally
				{
					((System.IDisposable)val20)?.Dispose();
				}
			}
			List<string> val21 = new List<string>();
			string[] array2 = new string[BKZ.Count];
			BKv = 115;
			int num41 = 25;
			int num42 = 25;
			Font val22 = new Font(((Control)this).Font.FontFamily, 8f);
			try
			{
				for (int num43 = 0; num43 < BKZ.Count; num43++)
				{
					Setting setting3 = BKZ[num43];
					array2[num43] = string.Empty;
					if (array[val15.IndexOf(num43)] && ((BM.A(BKV.aXc, true) && !flag) || BM.C(setting3.A())))
					{
						array2[num43] = setting3.aX().Item1;
					}
					string text3 = ((SettingOrSpecialObject)setting3).H();
					if (!string.IsNullOrWhiteSpace(text3))
					{
						val21.Add(text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + ((SettingOrSpecialObject)setting3).A(bz.aYT) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E());
					}
					else
					{
						val21.Add(((SettingOrSpecialObject)setting3).A(bz.aYT));
					}
					int num44 = num42;
					SizeF val23 = graphics.MeasureString(val21[num43], val22);
					num42 = Math.Max(num44, (int)((SizeF)(ref val23)).Width);
					int num45 = num41;
					val23 = graphics.MeasureString(array2[num43], val22);
					num41 = Math.Max(num45, (int)((SizeF)(ref val23)).Width);
				}
			}
			finally
			{
				((System.IDisposable)val22)?.Dispose();
			}
			BKv = 17 + num42 + 26 + num41 + 8;
			A(graphics, num4, num, num42, val21, array2);
			val.Stop();
			N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBn(), (object)val.ElapsedMilliseconds, (object)((Control)this).Left, (object)((Control)this).Top), false);
		}

		private void A(Graphics P_0, int P_1, int P_2, int P_3, List<string> P_4, string[] P_5)
		{
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			for (int i = 0; i < BKZ.Count; i++)
			{
				int num = P_2 + BKw + i * 15;
				if (i == Bkc)
				{
					SolidBrush val = new SolidBrush(Color.FromArgb(50, 50, 0));
					try
					{
						P_0.FillRectangle((Brush)(object)val, P_1 + BKW, num, BKv, 16);
					}
					finally
					{
						((System.IDisposable)val)?.Dispose();
					}
				}
				else
				{
					P_0.FillRectangle(Brushes.Black, P_1 + BKW, num, BKv, 16);
				}
				Font val2 = new Font(((Control)this).Font.FontFamily, 8f);
				try
				{
					Setting setting = BKZ[i];
					SolidBrush val3 = new SolidBrush(BKu[BkB[setting.A()]]);
					try
					{
						Pen val4 = new Pen(val3.Color);
						try
						{
							int num2 = num + 7 + 1;
							int num3 = P_1 + BKW + 7 + 1;
							P_0.DrawArc(val4, num3 - 11, num2 - 3, 24, 24, 230, 80);
							P_0.DrawArc(val4, num3 - 11, num2 + 3 - 24, 24, 24, 50, 80);
							if (Bkb[i])
							{
								P_0.DrawEllipse(val4, num3 - 2, num2 - 3, 6, 6);
								P_0.DrawEllipse(val4, num3, num2 - 1, 2, 2);
							}
							else
							{
								P_0.DrawLine(val4, num3 - 5, num2, num3 + 7, num2);
							}
						}
						finally
						{
							((System.IDisposable)val4)?.Dispose();
						}
						P_0.DrawString(P_4[i], val2, (Brush)(object)val3, (float)(P_1 + BKW + 15 + 2), (float)(num + 2));
						if (!string.IsNullOrEmpty(P_5[i]))
						{
							P_0.DrawString(P_5[i], val2, (Brush)(object)val3, (float)(P_1 + BKW + 15 + 2 + P_3 + 26), (float)(num + 2));
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
			Pen val5 = new Pen(Color.Gray, 1f);
			try
			{
				P_0.DrawRectangle(val5, P_1 + BKW, P_2 + BKw, BKv, BKZ.Count * 15);
			}
			finally
			{
				((System.IDisposable)val5)?.Dispose();
			}
		}

		private void A(Graphics P_0, int P_1, Color P_2)
		{
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected O, but got Unknown
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			List<aC.b> val = new List<aC.b>();
			for (int i = 0; i < Bke.Count; i++)
			{
				List<aC.b> val2 = Bke[i];
				if (val2.Count != 0)
				{
					bool flag = false;
					for (int j = 0; j < BKZ.Count; j++)
					{
						if (BKZ[j].A() == val2[0].BLt && !Bkb[j])
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						continue;
					}
				}
				for (int k = 0; k < val2.Count; k++)
				{
					if (val2[k].BLu == P_2 && val2[k].BLt == P_1)
					{
						val.Add(val2[k]);
						continue;
					}
					if (i == val2[k].BLT)
					{
						Pen val3 = new Pen(val2[k].BLu, 1f);
						try
						{
							aC.b b = val2[k];
							int num = Math.Min(Math.Max(((Point)(ref b.BLS)).Y, -1000000000), 1000000000);
							b = val2[k];
							int num2 = Math.Min(Math.Max(((Point)(ref b.BLs)).Y, -1000000000), 1000000000);
							try
							{
								b = val2[k];
								int x = ((Point)(ref b.BLS)).X;
								b = val2[k];
								P_0.DrawLine(val3, x, num, ((Point)(ref b.BLs)).X, num2);
							}
							catch (System.Exception ex)
							{
								N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBO() + ex.Message, true);
							}
						}
						finally
						{
							((System.IDisposable)val3)?.Dispose();
						}
						continue;
					}
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.en());
				}
			}
			Enumerator<aC.b> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					aC.b current = enumerator.Current;
					Pen val4 = new Pen(current.BLu, 1f);
					try
					{
						int num3 = Math.Min(Math.Max(((Point)(ref current.BLS)).Y, -1000000000), 1000000000);
						int num4 = Math.Min(Math.Max(((Point)(ref current.BLs)).Y, -1000000000), 1000000000);
						try
						{
							P_0.DrawLine(val4, ((Point)(ref current.BLS)).X, num3, ((Point)(ref current.BLs)).X, num4);
						}
						catch (System.Exception ex2)
						{
							N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBO() + ex2.Message, true);
						}
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private new void B()
		{
			if (((Control)BM.QQ.rn).Visible && (aC.GW || aC.Gl))
			{
				for (int i = 0; i < 1000; i++)
				{
					BkE[i] = 0;
					for (int j = 0; j < 10; j++)
					{
						Bkd[j, i] = 0;
					}
				}
				Bkh = 0L;
				return;
			}
			if (((Control)BM.QQ.rn).Visible && aC.GM)
			{
				Bkh += BkD.ElapsedMilliseconds;
				return;
			}
			int num = 0;
			if (BkD.IsRunning)
			{
				BkD.Stop();
				num = (int)(BkD.ElapsedMilliseconds - Bkh);
				int num2 = 10;
				num = Math.Max(num, num2);
				if (aC.GL != 1.0)
				{
					num = (int)((double)num * aC.GL);
				}
				BkD.Reset();
			}
			BkD.Start();
			for (int k = 0; k < 1000; k++)
			{
				if (k == 999)
				{
					BkE[k] = num;
				}
				else
				{
					BkE[k] = BkE[k + 1];
				}
			}
			for (int l = 0; l < 10; l++)
			{
				if (l < BKZ.Count)
				{
					int num3 = BKZ[l].ax();
					for (int m = 0; m < 1000; m++)
					{
						if (m == 999)
						{
							Bkd[l, m] = num3;
						}
						else
						{
							Bkd[l, m] = Bkd[l, m + 1];
						}
					}
				}
				else
				{
					for (int n = 0; n < 1000; n++)
					{
						Bkd[l, n] = 0;
					}
				}
			}
			Bkh = 0L;
		}

		private new void b()
		{
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			BkF.Clear();
			Bkf.Clear();
			BkG.Clear();
			Bkg.Clear();
			for (int i = 0; i < aC.GN.Count; i++)
			{
				BkF.Add(new List<int>());
				Bkf.Add(new List<Color>());
				BkG.Add(new List<int>());
				Bkg.Add(new List<int>());
				for (int j = 0; j < aC.GN[i].Count; j++)
				{
					ushort num2 = aC.GN[i][j];
					Setting setting = BM.Qz.A((int)num2);
					if (setting != null && BKZ.Contains(setting))
					{
						BkF[i].Add((int)num2);
						Bkf[i].Add(BKu[BkB[(int)num2]]);
						if (BKx)
						{
							int num3 = bS.A(BKY, setting.aS());
							int num4 = bS.A(BKy, setting.aS());
							BkG[i].Add(num3);
							Bkg[i].Add(num4);
						}
						else
						{
							BkG[i].Add(BkA[(int)num2]);
							Bkg[i].Add(Bka[(int)num2]);
						}
						num++;
					}
				}
			}
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			b();
			aC.A(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, aC.GT, aC.Gt);
			((Control)this).Invalidate();
		}

		private void A(object P_0, aC.D P_1)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			if (P_1.A() == aC.c.BLX)
			{
				b();
				aC.A(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, aC.GT, aC.Gt);
			}
			((Control)this).Invalidate();
		}

		private void A(out int P_0, out int P_1)
		{
			if (BKx)
			{
				P_0 = 0;
				P_1 = 0;
				return;
			}
			int num = 10;
			int num2 = ((Control)this).Height - 10 - 1;
			int num3 = num2 - num - 20;
			if (BKZ.Count == 0)
			{
				P_0 = num2 - 10 - num3;
				P_1 = num2 - 10;
				return;
			}
			Setting setting = BKZ[Bkc];
			int num4 = setting.aR();
			int num5 = setting.ar();
			if (num4 == 0 && num5 == 0)
			{
				num5 = 100;
			}
			int num6 = num5 - num4;
			if (num6 == 0)
			{
				P_0 = num2 - 10 - num3;
				P_1 = num2 - 10;
			}
			else
			{
				P_0 = (int)((long)num2 - 10L - ((long)Bka[setting.A()] - (long)num4) * num3 / num6);
				P_1 = (int)((long)num2 - 10L - ((long)BkA[setting.A()] - (long)num4) * num3 / num6);
			}
		}

		protected override void MouseDownHandler(object sender, MouseEventArgs e)
		{
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).Focus();
			if (aC.GR.IsRunning || aC.GM)
			{
				BM.QQ.rn.c(null, null);
				aC.GR.Reset();
			}
			BkI = e.X;
			Bki = e.Y;
			if (BKZ.Count != 0)
			{
				int num = 10;
				int num2 = ((Control)this).Width - 10 - 1;
				int num3 = 10;
				int num4 = ((Control)this).Height - 10 - 1;
				A(out var num5, out var num6);
				Rectangle val = default(Rectangle);
				((Rectangle)(ref val))._002Ector(num2 - 10, num3, 10, num4 - num3);
				if (((Rectangle)(ref val)).Contains(e.Location))
				{
					Bkk = num5;
					BkL = num6;
					if (!BKx && Bki > num3 && Bki < num4)
					{
						if (Bki < num3 + 10 || Bki > num4 - 10)
						{
							Setting setting = BKZ[Bkc];
							int num7 = setting.aR();
							int num8 = setting.ar();
							if (num7 == 0 && num8 == 0)
							{
								num8 = 100;
							}
							BkA[setting.A()] = num7;
							Bka[setting.A()] = num8;
							BkC[Bkc].A((float)num7);
							BkC[Bkc].a((float)num8);
							BkC[Bkc].H();
							b();
							aC.A(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, aC.GT, aC.Gt);
							((Control)this).Invalidate();
							return;
						}
						if (Bki > num5 && Bki < num5 + 10)
						{
							Bkj = true;
							return;
						}
						if (Bki > num5 + 10 && Bki < num6 - 10)
						{
							BkJ = true;
							return;
						}
						if (Bki > num6 - 10 && Bki < num6)
						{
							BkK = true;
							return;
						}
					}
				}
				else
				{
					Rectangle val2 = default(Rectangle);
					((Rectangle)(ref val2))._002Ector(num + BKW, num3 + BKw, BKv, BKZ.Count * 15);
					if (((Rectangle)(ref val2)).Contains(e.Location))
					{
						Bkm = BKW;
						BkN = BKw;
						Bkl = true;
						return;
					}
					if (((uint)BM.qI & 0x1000u) != 0 && ((Rectangle)(ref BkH)).Contains(e.Location))
					{
						aC.Gv = true;
						aC.Gr = (int)((double)(e.X - ((Rectangle)(ref BkH)).Left) / (double)((Rectangle)(ref BkH)).Width * (double)(aC.Gt - aC.GT)) + aC.GT;
						aC.GU = aC.Gr;
						BM.QQ.rn.D();
						aC.gA.Clear();
						aC.ga = -1;
						return;
					}
				}
			}
			base.MouseDownHandler(sender, e);
		}

		protected override void MouseMoveHandler(object sender, MouseEventArgs e)
		{
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			int num = 10;
			int num2 = ((Control)this).Height - 10 - 1;
			int num3 = ((Control)this).Width - 10 - 1;
			if (!BKx && (BkJ || Bkj || BkK))
			{
				Setting setting = BKZ[Bkc];
				int num4 = setting.aR();
				int num5 = setting.ar();
				if (num4 == 0 && num5 == 0)
				{
					num5 = 100;
				}
				int num6 = num5 - num4;
				int num7 = num2 - num - 20;
				if (BkJ)
				{
					int num8 = e.Y - Bki;
					int num9 = BkL - Bkk;
					int num10 = Bkk + num8;
					int num11 = BkL + num8;
					if (num10 < num + 10)
					{
						num10 = num + 10;
						num11 = num10 + num9;
					}
					else if (num11 > num2 - 10)
					{
						num11 = num2 - 10;
						num10 = num11 - num9;
					}
					BkA[setting.A()] = Math.Max(num4, num4 + (num2 - 10 - num11) * num6 / num7);
					Bka[setting.A()] = Math.Min(num5, num4 + (num2 - 10 - num10) * num6 / num7);
				}
				else if (Bkj)
				{
					A(out var _, out var num13);
					Bka[setting.A()] = Math.Min(num5, num4 + (num7 - (Math.Min(e.Y, num13 - 20) - (num + 10))) * num6 / num7);
				}
				else if (BkK)
				{
					A(out var num14, out var _);
					BkA[setting.A()] = Math.Max(num4, num4 + (num7 - (Math.Max(e.Y, num14 + 20) - (num + 10))) * num6 / num7);
				}
				BkC[Bkc].A((float)BkA[setting.A()]);
				BkC[Bkc].a((float)Bka[setting.A()]);
				BkC[Bkc].H();
				b();
				aC.A(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, aC.GT, aC.Gt);
				((Control)this).Invalidate();
			}
			else if (((Rectangle)(ref BkH)).Contains(e.Location))
			{
				if (aC.Gv)
				{
					if (!Bkn.IsRunning)
					{
						Bkn.Start();
					}
					else if (Bkn.ElapsedMilliseconds > 80)
					{
						if (e.X >= ((Rectangle)(ref BkH)).Left && e.X < ((Rectangle)(ref BkH)).Right)
						{
							aC.Gr = (int)((double)(e.X - ((Rectangle)(ref BkH)).Left) / (double)((Rectangle)(ref BkH)).Width * (double)(aC.Gt - aC.GT)) + aC.GT;
							aC.GU = aC.Gr;
							BM.QQ.rn.D();
							aC.gA.Clear();
							aC.ga = -1;
						}
						Bkn.Restart();
					}
				}
				else if (Bkl)
				{
					int num16 = e.X - BkI;
					int num17 = e.Y - Bki;
					if (BkM || num16 != 0 || num17 != 0)
					{
						BkM = true;
						int num18 = num2 - 30 - BKZ.Count * 15;
						int num19 = num3 - 60 - BKv;
						BKW = Math.Min(Math.Max(Bkm + num16, 2), num19);
						BKw = Math.Min(Math.Max(BkN + num17, 2), num18);
						((Control)this).Invalidate();
					}
				}
				else if (((uint)BM.qI & 0x1000u) != 0)
				{
					int num20 = aC.Gt - aC.GT;
					if (num20 <= 0)
					{
						num20 = 1;
					}
					int num21 = aC.Gr * ((Rectangle)(ref BkH)).Width / num20 + ((Rectangle)(ref BkH)).Left;
					if (e.X >= num21 - 3 && e.X <= num21 + 3)
					{
						((Control)this).Cursor = Cursors.VSplit;
					}
					else
					{
						((Control)this).Cursor = Cursors.Default;
					}
				}
				else
				{
					base.MouseMoveHandler(sender, e);
				}
			}
			else if (!aC.Gv)
			{
				base.MouseMoveHandler(sender, e);
			}
		}

		protected override void MouseUpHandler(object sender, MouseEventArgs e)
		{
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			base.MouseUpHandler(sender, e);
			BkJ = false;
			Bkj = false;
			BkK = false;
			Bkl = false;
			if (!BkM)
			{
				int x = e.X;
				int y = e.Y;
				int num = 10;
				int num2 = 10;
				Rectangle val = default(Rectangle);
				for (int i = 0; i < BKZ.Count; i++)
				{
					((Rectangle)(ref val))._002Ector(num2 + BKW, num + BKw + i * 15, BKv, 15);
					if (((Rectangle)(ref val)).Contains(x, y))
					{
						if (x <= num2 + BKW + 15 + 1)
						{
							Bkb[i] = !Bkb[i];
						}
						else
						{
							Bkc = i;
						}
						aC.A(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, aC.GT, aC.Gt);
						((Control)this).Invalidate();
						return;
					}
				}
			}
			else
			{
				BkM = false;
			}
			if (aC.Gv)
			{
				aC.Gv = false;
				((Control)BM.QQ).Refresh();
			}
		}

		public override void UpdateLayout(bool resizingOnly)
		{
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			if (BkA.Count != 0 && Bka.Count != 0)
			{
				int num = 10;
				int num2 = ((Control)this).Height - 10 - 1;
				int num3 = num + 8;
				int num4 = num2 - 30;
				for (int i = 0; i < BKZ.Count; i++)
				{
					BkC[i].B((float)num4);
					BkC[i].b((float)num3);
					BkC[i].H();
				}
			}
			BkH = new Rectangle(10, 18, ((Control)this).Width - 20 - 50 - 10 - 1, ((Control)this).Height - 20 - 30 - 8 - 1);
			if (((uint)BM.qI & 0x1000u) != 0)
			{
				b();
				aC.A(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, aC.GT, aC.Gt);
			}
		}

		private void b(object P_0, EventArgs P_1)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Invalid comparison between Unknown and I4
			if ((BM.qI & 0x1000) == 0)
			{
				if (!base.B() || (int)((Form)BM.QQ).WindowState == 1)
				{
					B();
				}
				else
				{
					((Control)this).Invalidate();
				}
			}
		}

		private void C(object P_0, EventArgs P_1)
		{
			((Control)this).Invalidate();
		}

		private void c(object P_0, EventArgs P_1)
		{
			((Component)this).Dispose();
			BM.QQ.rl.a(false);
		}

		private void D(object P_0, EventArgs P_1)
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Invalid comparison between Unknown and I4
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			bF bF = new bF(BKZ, BKx, BKY, BKy, BkA, Bka, BkB, BKX);
			if ((int)((Form)bF).ShowDialog((IWin32Window)(object)BM.QQ) == 1)
			{
				BkB = bF.c();
				BKX = bF.D();
				BKx = bF.A();
				if (BKx)
				{
					BKY = bF.a();
					BKy = bF.B();
				}
				else
				{
					BkA = bF.b();
					Bka = bF.C();
				}
				for (int i = 0; i < BKZ.Count; i++)
				{
					if (BKx)
					{
						int num = BKZ[i].aS();
						int num2 = bS.A(BKY, num);
						int num3 = bS.A(BKy, num);
						BkC[i].A((float)num2);
						BkC[i].a((float)num3);
						BkC[i].H();
						continue;
					}
					Setting setting = BKZ[i];
					int num4;
					int num5;
					if (BM.Qj.ContainsKey(setting.A()))
					{
						Bl bl = BM.Qj[setting.A()];
						num4 = bl.Qi;
						num5 = bl.QJ;
					}
					else
					{
						num4 = setting.aP();
						num5 = setting.ap();
					}
					BM.A(setting.A(), bF.b()[setting.A()], bF.C()[setting.A()], num4, num5);
					BkC[i].A((float)BkA[setting.A()]);
					BkC[i].a((float)Bka[setting.A()]);
					BkC[i].H();
				}
				b();
				aC.A(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, aC.GT, aC.Gt);
				((Control)this).Invalidate();
				BM.a();
			}
			((Component)bF).Dispose();
		}

		internal void d(object P_0, EventArgs P_1)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Expected O, but got Unknown
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_055e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Expected O, but got Unknown
			//IL_042a: Unknown result type (might be due to invalid IL or missing references)
			//IL_042f: Unknown result type (might be due to invalid IL or missing references)
			Dictionary<int, int> val = new Dictionary<int, int>();
			Enumerator<int, int> enumerator = BkA.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, int> current = enumerator.Current;
					val.Add(current.Key, current.Value);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Dictionary<int, int> val2 = new Dictionary<int, int>();
			enumerator = Bka.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, int> current2 = enumerator.Current;
					val2.Add(current2.Key, current2.Value);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			List<o> val3 = new List<o>();
			Enumerator<o> enumerator2 = BkC.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					o current3 = enumerator2.Current;
					val3.Add(current3);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			List<int> val4 = new List<int>();
			Enumerator<Setting> enumerator3 = BKZ.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					Setting current4 = enumerator3.Current;
					val4.Add(current4.A());
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			Dictionary<int, int> val5 = new Dictionary<int, int>();
			enumerator = BkB.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, int> current5 = enumerator.Current;
					val5.Add(current5.Key, current5.Value);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			List<bool> val6 = new List<bool>();
			Enumerator<bool> enumerator4 = Bkb.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					bool current6 = enumerator4.Current;
					val6.Add(current6);
				}
			}
			finally
			{
				((System.IDisposable)enumerator4).Dispose();
			}
			List<int> val7 = BY.A((IWin32Window)(object)BM.QQ, BKV, val4, 10);
			if (val7 != null)
			{
				enumerator3 = BKZ.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						enumerator3.Current.a(new EventHandler(b));
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
				BKZ.Clear();
				BKz.Clear();
				BkA.Clear();
				Bka.Clear();
				BkC.Clear();
				BkB.Clear();
				Bkb.Clear();
				if (val7.Count != 0)
				{
					bool flag = false;
					Enumerator<int> enumerator5 = val7.GetEnumerator();
					try
					{
						while (enumerator5.MoveNext())
						{
							int current7 = enumerator5.Current;
							Setting setting = BKV.A(current7);
							if (setting == null)
							{
								continue;
							}
							BKZ.Add(setting);
							BKz.Add(current7);
							if (!flag)
							{
								setting.A(new EventHandler(b));
								flag = true;
							}
							int num = val4.IndexOf(current7);
							if (num == -1)
							{
								int num2;
								int num3;
								if (BM.Qj.ContainsKey(setting.A()))
								{
									Bl bl = BM.Qj[setting.A()];
									num2 = bl.Qh;
									num3 = bl.QI;
								}
								else
								{
									num2 = setting.aQ();
									num3 = setting.aq();
								}
								BkA.Add(setting.A(), num2);
								Bka.Add(setting.A(), num3);
								int num4 = 10;
								int num5 = ((Control)this).Height - 10 - 1;
								int num6 = num4 + 8;
								int num7 = num5 - 30;
								o o = new o();
								o.A(setting.aS());
								if (BKx)
								{
									int num8 = setting.aS();
									int num9 = bS.A(BKY, num8);
									int num10 = bS.A(BKy, num8);
									o.A((float)num9);
									o.a((float)num10);
								}
								else
								{
									o.A((float)num2);
									o.a((float)num3);
								}
								o.B((float)num7);
								o.b((float)num6);
								o.C(15f);
								o.c(20f);
								o.H();
								BkC.Add(o);
								Bkb.Add(true);
								for (int i = 0; i < BKu.Length; i++)
								{
									bool flag2 = false;
									Enumerator<int, int> enumerator6 = BkB.Values.GetEnumerator();
									try
									{
										while (enumerator6.MoveNext())
										{
											if (enumerator6.Current == i)
											{
												flag2 = true;
												break;
											}
										}
									}
									finally
									{
										((System.IDisposable)enumerator6).Dispose();
									}
									if (!flag2)
									{
										BkB.Add(setting.A(), i);
										break;
									}
								}
							}
							else
							{
								BkB.Add(setting.A(), val5[setting.A()]);
								BkA.Add(setting.A(), val[setting.A()]);
								Bka.Add(setting.A(), val2[setting.A()]);
								BkC.Add(val3[num]);
								Bkb.Add(val6[num]);
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator5).Dispose();
					}
					Bkc = Math.Min(Bkc, BKZ.Count - 1);
				}
				else
				{
					Bkc = 0;
				}
				b();
				aC.A(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, aC.GT, aC.Gt);
				((Control)this).Invalidate();
			}
			BM.QQ.rl.a(false);
		}

		private void E(object P_0, EventArgs P_1)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			if (((Control)this).ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				ToolStripMenuItem val = item;
				if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp())
				{
					((ToolStripItem)val).Enabled = BKZ.Count != 0;
				}
				else if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBo())
				{
					((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
				}
			}
		}

		private ContextMenuStrip C()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			((ToolStripDropDown)val).Opened += new EventHandler(E);
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ev();
			((ToolStripItem)val2).Click += new EventHandler(d);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			ToolStripMenuItem val3 = new ToolStripMenuItem();
			((ToolStripItem)val3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lp();
			((ToolStripItem)val3).Click += new EventHandler(D);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
			ToolStripMenuItem val4 = new ToolStripMenuItem();
			((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBo();
			((ToolStripItem)val4).Click += new EventHandler(c);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val4);
			return val;
		}

		internal void A(string P_0, int P_1, int P_2)
		{
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBP());
			int num = ((Control)this).Left - P_1;
			int num2 = ((Control)this).Top - P_2;
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBp() + BKW);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBQ() + BKw);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBq() + BKX);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBC() + BKx);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBc() + BKY);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBD() + BKy);
			if (BKz.Count == BkA.Count && BKz.Count == Bka.Count && BKz.Count == BkB.Count)
			{
				for (int i = 0; i < BKz.Count; i++)
				{
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf() + BKz[i]);
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bag() + BkA[BKz[i]]);
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaH() + Bka[BKz[i]]);
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBe() + BkB[BKz[i]]);
				}
			}
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
		}

		internal void A(StreamReader P_0)
		{
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_070d: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0603: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			bool flag = false;
			List<int> val = new List<int>();
			List<int> val2 = new List<int>();
			string text;
			int num2 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			while ((text = ((TextReader)P_0).ReadLine()) != null)
			{
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf()))
				{
					int num = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Baf().Length));
					BKz.Add(num);
					Setting setting = BKV.A(num);
					if (setting != null)
					{
						BKZ.Add(setting);
						Bkb.Add(true);
						if (!flag)
						{
							setting.A(new EventHandler(b));
							flag = true;
						}
					}
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI()))
				{
					string text2 = text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaI().Length);
					if (string.IsNullOrEmpty(text2))
					{
						continue;
					}
					string[] array = text2.Split(',', (StringSplitOptions)0);
					for (int i = 0; i < array.Length; i++)
					{
						string text3 = array[i].Trim();
						if (!int.TryParse(text3, ref num2))
						{
							string text4 = text3.Substring(1, text3.Length - 2);
							try
							{
								num2 = (int)(bs)System.Enum.Parse(typeof(bs), text4);
							}
							catch
							{
								num2 = -1;
							}
						}
						val.Add(num2);
						if (num2 != -1)
						{
							BKz.Add(num2);
							Setting setting2 = BKV.A(num2);
							if (setting2 != null)
							{
								BKZ.Add(setting2);
								Bkb.Add(true);
								setting2.A(new EventHandler(b));
							}
						}
					}
					if (val.Count != val2.Count)
					{
						continue;
					}
					for (int j = 0; j < val2.Count; j++)
					{
						if (val[j] != -1)
						{
							BkB.Add(val[j], val2[j]);
						}
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bag()))
				{
					int num3 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bag().Length));
					BkA.Add(BKz[BKz.Count - 1], num3);
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaH()))
				{
					int num4 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaH().Length));
					Bka.Add(BKz[BKz.Count - 1], num4);
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBR()))
				{
					string[] array2 = text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBR()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBR().Length).Split(',', (StringSplitOptions)0);
					for (int k = 0; k < array2.Length; k++)
					{
						if (k < val.Count && val[k] != -1)
						{
							string[] array3 = array2[k].Trim().Split(':', (StringSplitOptions)0);
							if (!int.TryParse(array3[0], ref num5))
							{
								num5 = (int)Math.Round((double)float.Parse(array3[0]));
							}
							BkA.Add(val[k], num5);
							if (!int.TryParse(array3[1], ref num6))
							{
								num6 = (int)Math.Round((double)float.Parse(array3[1]));
							}
							Bka.Add(val[k], num6);
						}
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBe()))
				{
					int num7 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBe().Length));
					BkB.Add(BKz[BKz.Count - 1], num7);
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBr()))
				{
					string[] array = text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBr()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBr().Length).Split(',', (StringSplitOptions)0);
					foreach (string text5 in array)
					{
						val2.Add(int.Parse(text5.Trim()));
					}
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBC()))
				{
					BKx = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBC().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBc()))
				{
					BKY = double.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBc().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBD()))
				{
					BKy = double.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBD().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBp()))
				{
					BKW = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBp().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBQ()))
				{
					BKw = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBQ().Length));
				}
				else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBq()))
				{
					BKX = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBq().Length));
				}
				else if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBS()))
				{
					BKX = int.Parse(text.Substring(text.IndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBS()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBS().Length));
				}
				else if (!text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBs()) && !text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBT()) && !text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBt()) && !text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBU()) && !text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bai()) && string.IsNullOrWhiteSpace(text))
				{
					break;
				}
			}
			BkC.Clear();
			if (BkA.Count != 0 && Bka.Count != 0)
			{
				int num8 = 10;
				int num9 = ((Control)this).Height - 10 - 1;
				int num10 = num8 + 8;
				int num11 = num9 - 30;
				Enumerator<Setting> enumerator = BKZ.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Setting current = enumerator.Current;
						o o = new o();
						o.A(current.aS());
						if (BKx)
						{
							int num12 = o.A();
							int num13 = bS.A(BKY, num12);
							int num14 = bS.A(BKy, num12);
							o.A((float)num13);
							o.a((float)num14);
						}
						else
						{
							o.A((float)BkA[current.A()]);
							o.a((float)Bka[current.A()]);
						}
						o.B((float)num11);
						o.b((float)num10);
						o.C(15f);
						o.c(20f);
						o.H();
						BkC.Add(o);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			if (aC.gD != null)
			{
				b();
				aC.A(BkH, 8, 30, BkF, BkG, Bkg, Bkf, Bke, aC.GT, aC.Gt);
				((Control)this).Invalidate();
			}
		}
	}
}
namespace C
{
	internal class CO
	{
		internal Cn BcF;

		internal string Bcf;

		public virtual string ToString()
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWo() + Bcf;
		}
	}
	internal class Co
	{
		private string BcG;

		private Stream Bcg;

		internal Co(string P_0)
		{
			BcG = P_0;
		}

		internal Co(Stream P_0)
		{
			Bcg = P_0;
		}

		internal Cn A()
		{
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Invalid comparison between Unknown and I4
			XmlReader val = null;
			Stream val2 = null;
			Stream val3 = null;
			if (BcG == null && Bcg == null)
			{
				return null;
			}
			if (BcG != null)
			{
				val2 = (Stream)(object)File.OpenRead(BcG);
			}
			else if (Bcg != null)
			{
				val2 = Bcg;
			}
			bool flag;
			try
			{
				flag = R.A(val2);
			}
			catch
			{
				flag = false;
			}
			if (flag)
			{
				if (!R.A(val2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWP(), out val3, M.A()))
				{
					val2.Close();
					return null;
				}
			}
			else
			{
				val3 = val2;
			}
			val = XmlReader.Create(val3);
			Cn cn = new Cn();
			val.Read();
			while ((int)val.NodeType != 1)
			{
				val.Read();
			}
			if (!val.IsEmptyElement)
			{
				val.Read();
				while (val.IsStartElement())
				{
					bool flag2 = true;
					string name = val.Name;
					if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGX()))
					{
						if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hh()))
						{
							if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWp())
							{
								val.Read();
								cn.BCw = val.Value;
								val.Skip();
							}
							else
							{
								flag2 = false;
							}
						}
						else if (!val.IsEmptyElement)
						{
							B(val, cn);
						}
					}
					else if (!val.IsEmptyElement)
					{
						A(val, cn);
					}
					if (!flag2)
					{
						val.Skip();
					}
					else
					{
						val.Read();
					}
				}
			}
			val.Close();
			if (val3 != null)
			{
				val3.Close();
			}
			if (val2 != null)
			{
				val2.Close();
			}
			return cn;
		}

		private void A(XmlReader P_0, Cn P_1)
		{
			while (P_0.IsStartElement())
			{
				string name = P_0.Name;
				if (name != null)
				{
					switch (name.Length)
					{
					case 18:
						switch (name[11])
						{
						case 'P':
							if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWr())
							{
								P_0.Read();
								P_1.BCz = int.Parse(P_0.Value);
								P_0.Skip();
							}
							break;
						case 'V':
							if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWS())
							{
								P_0.Read();
								P_1.BcA = int.Parse(P_0.Value);
								P_0.Skip();
							}
							break;
						}
						break;
					case 7:
						switch (name[1])
						{
						case 'a':
							if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWs())
							{
								P_0.Read();
								P_1.BCx = int.Parse(P_0.Value);
								P_0.Skip();
							}
							break;
						case 'r':
							if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWT())
							{
								P_0.Read();
								P_1.BCy = P_0.Value;
								P_0.Skip();
							}
							break;
						}
						break;
					case 3:
						switch (name[1])
						{
						case 'a':
							if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGx())
							{
								string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
								P_0.Read();
								P_1.Bcb.Add(attribute, P_0.Value);
								P_0.Skip();
							}
							break;
						case 'x':
							if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWU())
							{
								a(P_0, P_1);
							}
							break;
						}
						break;
					case 4:
						if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWQ())
						{
							P_0.Read();
							P_1.BCX = P_0.Value;
							P_0.Skip();
						}
						break;
					case 11:
						if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWq())
						{
							P_0.Read();
							P_1.BCY = Version.Parse(P_0.Value);
							P_0.Skip();
						}
						break;
					case 15:
						if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWR())
						{
							P_0.Read();
							P_1.BCZ = new k(P_0.Value, false);
							P_0.Skip();
						}
						break;
					case 13:
						if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahj())
						{
							string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ());
							P_0.Read();
							if (attribute2 != null && attribute2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWu())
							{
								P_1.BcB = P_0.Value;
							}
							P_0.Skip();
						}
						break;
					case 8:
						if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWt())
						{
							P_0.Read();
							P_1.Bca = P_0.Value;
							P_0.Skip();
						}
						break;
					}
				}
				P_0.Read();
			}
		}

		private void a(XmlReader P_0, Cn P_1)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Invalid comparison between Unknown and I4
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Invalid comparison between Unknown and I4
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Invalid comparison between Unknown and I4
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Invalid comparison between Unknown and I4
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWV());
			Cn.A a = default(Cn.A);
			P_0.Read();
			while ((int)P_0.NodeType != 1)
			{
				P_0.Read();
			}
			while ((P_0.IsStartElement() || (int)P_0.NodeType == 15 || (int)P_0.NodeType == 13) && (!(P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWU()) || (int)P_0.NodeType != 15))
			{
				if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWv())
				{
					P_0.Read();
					a.BsP = P_0.Value;
					P_0.Skip();
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWW())
				{
					P_0.Read();
					a.Bsp = P_0.Value;
					P_0.Skip();
				}
				else if (P_0.Name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWw())
				{
					P_0.Read();
					a.BsQ = P_0.Value;
					P_0.Skip();
				}
				P_0.Read();
			}
			P_1.BcC.Add(attribute, a);
		}

		private void B(XmlReader P_0, Cn P_1)
		{
			while (P_0.IsStartElement())
			{
				string name = P_0.Name;
				if (!(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGi()) && !(name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWX()))
				{
					if (name == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mL())
					{
						C(P_0, P_1);
					}
				}
				else
				{
					b(P_0, P_1);
				}
				P_0.Read();
			}
		}

		private void b(XmlReader P_0, Cn P_1)
		{
			int num = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
			int attrId = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWx()));
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWY());
			if (!string.IsNullOrEmpty(attribute))
			{
				P_1.Bce[num] = attribute;
			}
			P_0.Read();
			byte[] array = n.A(P_0.Value);
			P_1.Bcc[new DataIdAndAttrId(num, attrId)] = array;
			P_0.Skip();
		}

		private void C(XmlReader P_0, Cn P_1)
		{
			int num = int.Parse(P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP()));
			string attribute = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWy());
			int num2 = ((!string.IsNullOrEmpty(attribute)) ? int.Parse(attribute) : 0);
			string attribute2 = P_0.GetAttribute(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWZ());
			int num3 = ((!string.IsNullOrEmpty(attribute2)) ? int.Parse(attribute2) : 0);
			P_0.Read();
			byte[] array = n.A(P_0.Value);
			if (num2 != 0)
			{
				if (!P_1.BcE.ContainsKey(num2))
				{
					P_1.BcE.Add(num2, new Dictionary<int, byte[]>());
				}
				P_1.BcE[num2][num] = array;
			}
			else if (num3 != 0)
			{
				if (!P_1.Bcd.ContainsKey(num3))
				{
					P_1.Bcd.Add(num3, new Dictionary<int, byte[]>());
				}
				P_1.Bcd[num3][num] = array;
			}
			else
			{
				P_1.BcD[num] = array;
			}
			P_0.Skip();
		}

		internal static void A(CO P_0, Framework P_1)
		{
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			if (P_0 == null || P_0.BcF == null || string.IsNullOrEmpty(P_0.Bcf) || !P_0.Bcf.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sU()))
			{
				return;
			}
			Stream val = null;
			try
			{
				val = (Stream)(object)File.OpenRead(P_0.Bcf);
				if (!R.A(val))
				{
					return;
				}
			}
			catch
			{
				return;
			}
			if (val == null)
			{
				return;
			}
			List<string> val2 = null;
			try
			{
				val2 = R.A(val, M.A());
			}
			catch
			{
				return;
			}
			if (val2 != null)
			{
				for (int i = 0; i < val2.Count; i++)
				{
					string text = val2[i];
					try
					{
						if (!text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TQ()) || text.Length <= D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TQ().Length + 1)
						{
							continue;
						}
						Stream val3 = null;
						if (R.A(val, text, out val3, M.A()))
						{
							byte[] array = null;
							MemoryStream val4 = new MemoryStream();
							try
							{
								val3.CopyTo((Stream)(object)val4);
								array = val4.ToArray();
							}
							finally
							{
								((System.IDisposable)val4)?.Dispose();
							}
							int num = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TQ().Length + 1;
							string text2 = text.Substring(num);
							int num2 = text2.IndexOfAny(new char[2] { '\\', '/' });
							if (num2 != -1)
							{
								string text3 = text2.Substring(0, num2);
								int length = (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWz() + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()).Length;
								if (length < text.Length)
								{
									string text4 = text.Substring(length);
									if (!BM.A(BM.Qu, text4, array, text3, out var text5))
									{
										N.A(text5, true);
									}
								}
							}
						}
						if (val3 != null)
						{
							val3.Close();
						}
					}
					catch (System.Exception ex)
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awA() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rq() + ex.Message, true);
					}
				}
			}
			try
			{
				val.Close();
			}
			catch
			{
			}
		}

		internal static Image A(CO P_0)
		{
			if (P_0 != null && P_0.BcF != null && !string.IsNullOrEmpty(P_0.Bcf) && !string.IsNullOrEmpty(P_0.BcF.BcB))
			{
				try
				{
					if (P_0.Bcf.ToLower().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sU()))
					{
						Stream val = (Stream)(object)File.OpenRead(P_0.Bcf);
						if (R.A(val))
						{
							if (R.A(val, P_0.BcF.BcB, out var val2, M.A()))
							{
								Image result = Image.FromStream(val2);
								val2.Close();
								val.Close();
								return result;
							}
							val.Close();
						}
						else
						{
							val.Close();
						}
					}
					else if (P_0.Bcf.ToLower().EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awa()))
					{
						string bcB = P_0.BcF.BcB;
						string text = Path.Combine(Path.GetDirectoryName(P_0.Bcf), bcB);
						if (File.Exists(text))
						{
							FileStream val3 = File.Open(text, (FileMode)3);
							Image result2;
							try
							{
								result2 = Image.FromStream((Stream)(object)val3);
							}
							finally
							{
								((System.IDisposable)val3)?.Dispose();
							}
							return result2;
						}
					}
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awB() + ex.Message, true);
				}
			}
			return null;
		}

		internal static void a()
		{
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			string[] array = null;
			if (Directory.Exists(BM.QY))
			{
				try
				{
					array = Directory.GetDirectories(BM.QY);
				}
				catch
				{
					array = null;
				}
			}
			if (array == null)
			{
				return;
			}
			string[] array2 = array;
			foreach (string text in array2)
			{
				string[] array3 = null;
				try
				{
					array3 = Directory.GetFiles(text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sT());
				}
				catch
				{
					array3 = null;
				}
				if (array3 != null)
				{
					string[] array4 = array3;
					foreach (string text2 in array4)
					{
						try
						{
							string name = ((FileSystemInfo)new DirectoryInfo(Path.GetDirectoryName(text2))).Name;
							string fileName = Path.GetFileName(text2);
							if (File.Exists(BM.Qx + name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + fileName))
							{
								File.Delete(text2);
							}
						}
						catch (System.Exception ex)
						{
							N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awb() + ex.Message, true);
						}
					}
				}
				try
				{
					if (Directory.GetFiles(text).Length == 0)
					{
						Directory.Delete(text);
					}
				}
				catch (System.Exception ex2)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awb() + ex2.Message, true);
				}
			}
		}

		internal static Dictionary<string, CO> A(List<string> P_0)
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			Dictionary<string, CO> val = new Dictionary<string, CO>();
			string[] array = null;
			if (Directory.Exists(BM.Qx))
			{
				try
				{
					array = Directory.GetDirectories(BM.Qx);
				}
				catch
				{
					array = null;
				}
			}
			string[] array2 = null;
			if (Directory.Exists(BM.QY))
			{
				try
				{
					array2 = Directory.GetDirectories(BM.QY);
				}
				catch
				{
					array2 = null;
				}
			}
			List<string> val2 = new List<string>();
			if (array != null)
			{
				val2.AddRange((System.Collections.Generic.IEnumerable<string>)array);
			}
			if (array2 != null)
			{
				val2.AddRange((System.Collections.Generic.IEnumerable<string>)array2);
			}
			Enumerator<string> enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					string[] array3 = null;
					try
					{
						array3 = Directory.GetFiles(current, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sT());
					}
					catch
					{
						array3 = null;
					}
					if (array3 == null)
					{
						continue;
					}
					string[] array4 = array3;
					foreach (string text in array4)
					{
						try
						{
							if (P_0 == null || P_0.Contains(Path.GetFullPath(text)))
							{
								Cn cn = new Co(text).A();
								if (cn != null && !val.ContainsKey(cn.BCw))
								{
									CO cO = new CO();
									cO.BcF = cn;
									cO.Bcf = text;
									val.Add(cn.BCw, cO);
								}
							}
						}
						catch (System.Exception ex)
						{
							N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awC() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rq() + ex.Message, true);
						}
					}
				}
				return val;
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
	}
}
