using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using C;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using c;

namespace B
{
	internal class BX : Form
	{
		private enum A : byte
		{
			BRh,
			BRI,
			BRi
		}

		private enum a : byte
		{
			BRJ,
			BRj
		}

		private enum B : byte
		{
			BRK,
			BRk,
			BRL,
			BRl,
			BRM,
			BRm,
			BRN,
			BRn,
			BRO,
			BRo
		}

		private delegate void b();

		private const int wl = 9119;

		private const int wM = 9120;

		private const int wm = 9121;

		private const int wN = 9122;

		private const int wn = 9123;

		private const int wO = 9124;

		private const int wo = 9125;

		private const int wP = 9126;

		private const int wp = 9127;

		private const int wQ = 9128;

		private const int wq = 9129;

		private const int wR = 9130;

		private const int wr = 9131;

		private const int wS = 9132;

		private const int ws = 9133;

		private const int wT = 9134;

		private const int wt = 9135;

		private const int wU = 9136;

		private const int wu = 9162;

		private const int wV = 10216;

		private const int wv = 500;

		private const int wW = 1000;

		private const int ww = 25;

		private string[] wX = new string[9]
		{
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XM(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xm(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XN(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xn(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XO(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xo(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XP(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xp(),
			D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XQ()
		};

		internal const int wx = 1000;

		internal const int wY = 4;

		private const int wy = 10;

		private const int wZ = 10;

		private const int wz = 10;

		private const int XA = 5;

		private const int Xa = 4;

		private Pen[] XB = (Pen[])(object)new Pen[4];

		private uint[,] Xb = new uint[4, 1000];

		private uint[,] XC = new uint[4, 1000];

		private ushort Xc;

		private ushort XD;

		private Setting[] Xd = new Setting[4];

		private Setting[] XE = new Setting[4];

		private Setting[] Xe = new Setting[4];

		private aI[] XF = new aI[4];

		private ThemedComboBox[] Xf = new ThemedComboBox[4];

		private TrackBar[] XG = (TrackBar[])(object)new TrackBar[4];

		private aP[] Xg = new aP[4];

		private Label[] XH = (Label[])(object)new Label[4];

		private Setting Xh;

		private Setting XI;

		private Setting Xi;

		private Setting XJ;

		private Setting Xj;

		private Setting XK;

		private Setting Xk;

		private Setting XL;

		private int Xl;

		private bool XM;

		private int Xm;

		private int XN;

		private bool Xn;

		private bool XO;

		private bool Xo = true;

		private bool XP;

		private Timer Xp;

		private Stopwatch XQ = new Stopwatch();

		private Stopwatch Xq = new Stopwatch();

		private bool XR;

		private int Xr = 1000;

		private int XS;

		private int Xs;

		private bool[] XT = new bool[4];

		private bool Xt;

		private bool XU;

		private bool Xu;

		private static object XV = new object();

		private IContainer Xv;

		private aP XW;

		private aP Xw;

		private aP XX;

		private aP Xx;

		private ThemedComboBox XY;

		private Label Xy;

		private Label XZ;

		private Label Xz;

		private Label xA;

		private Label xa;

		private Label xB;

		private ThemedComboBox xb;

		private ThemedComboBox xC;

		private ThemedComboBox xc;

		private ThemedComboBox xD;

		private Label xd;

		private TrackBar xE;

		private Label xe;

		private Label xF;

		private Label xf;

		private Label xG;

		private TrackBar xg;

		private TrackBar xH;

		private TrackBar xh;

		private TrackBar xI;

		private Label xi;

		private NumericUpDown xJ;

		private ThemedButton xj;

		private Panel xK;

		private Panel xk;

		private v xL;

		private aI xl;

		private aI xM;

		private aI xm;

		private aI xN;

		private aI xn;

		private Label xO;

		private Label xo;

		private Label xP;

		private Label xp;

		private Label xQ;

		private Label xq;

		private Label xR;

		private Label xr;

		private Label xS;

		private Label xs;

		private ThemedComboBox xT;

		private Label xt;

		private aP xU;

		private Panel xu;

		private aP xV;

		private Label xv;

		private Label xW;

		private Label xw;

		private ThemedButton xX;

		internal BX()
		{
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected O, but got Unknown
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected O, but got Unknown
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Expected O, but got Unknown
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Expected O, but got Unknown
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Expected O, but got Unknown
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f0: Expected O, but got Unknown
			//IL_060e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0618: Expected O, but got Unknown
			BM.Qz.A(20069)?.a(1, true);
			Xo = true;
			E();
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is Label && val != xq && val != xR && val != xr && val != xS)
				{
					val.ForeColor = BM.te;
				}
			}
			((Control)xK).BackColor = BM.td;
			foreach (Control item2 in (ArrangedElementCollection)((Control)xK).Controls)
			{
				Control val2 = item2;
				if (val2 is Label && val2 != xQ && val2 != xp && val2 != xP && val2 != xo)
				{
					val2.ForeColor = BM.te;
				}
			}
			((Control)xk).BackColor = BM.td;
			foreach (Control item3 in (ArrangedElementCollection)((Control)xk).Controls)
			{
				Control val3 = item3;
				if (val3 is Label)
				{
					val3.ForeColor = BM.te;
				}
			}
			((Control)xu).BackColor = BM.td;
			foreach (Control item4 in (ArrangedElementCollection)((Control)xu).Controls)
			{
				Control val4 = item4;
				if (val4 is Label)
				{
					val4.ForeColor = BM.te;
				}
			}
			((Control)xU).ForeColor = BM.te;
			((Control)xV).ForeColor = BM.te;
			Xm = ((Control)xL).Width / 4;
			XN = ((Control)xL).Width * 3 / 4;
			XB[0] = Pens.Gold;
			XB[1] = Pens.Aqua;
			XB[2] = Pens.Salmon;
			XB[3] = Pens.Violet;
			xM.A(BM.Qz);
			xm.A(BM.Qz);
			xN.A(BM.Qz);
			xn.A(BM.Qz);
			XF[0] = xM;
			XF[1] = xm;
			XF[2] = xN;
			XF[3] = xn;
			xl.A(BM.Qz);
			Xf[0] = xb;
			Xf[1] = xD;
			Xf[2] = xc;
			Xf[3] = xC;
			XG[0] = xg;
			XG[1] = xH;
			XG[2] = xh;
			XG[3] = xI;
			Xg[0] = XW;
			Xg[1] = Xx;
			Xg[2] = XX;
			Xg[3] = Xw;
			XH[0] = xq;
			XH[1] = xR;
			XH[2] = xr;
			XH[3] = xS;
			XK = BM.Qz.A(9119);
			Xk = BM.Qz.A(10216);
			XL = BM.Qz.A(9162);
			Xc = 0;
			XD = 0;
			for (int i = 0; i < 9; i++)
			{
				((ComboBox)XY).Items.Add((object)wX[i]);
			}
			if (BM.Qz.awZ == 20 && BM.Qz.awz == 3 && BM.Qz.aXA < new k(1, 13, 0, 101, 0))
			{
				XR = false;
				((ComboBox)XY).Items.RemoveAt(8);
				((ComboBox)XY).Items.RemoveAt(7);
				((ComboBox)XY).Items.RemoveAt(6);
			}
			else
			{
				XR = true;
			}
			Xp = new Timer(40.0);
			if (BM.Qz.A(9133) != null)
			{
				Xp.Elapsed += new ElapsedEventHandler(A);
			}
			Xp.AutoReset = false;
			Xp.Enabled = true;
			Xp.Start();
			XQ.Start();
		}

		private void A(object P_0, EventArgs P_1)
		{
			if (BM.Qz.A(9133) != null)
			{
				C();
			}
			Xo = false;
			((CheckBox)xU).Checked = true;
			d();
			if (((uint)BM.qI & 0x1000u) != 0)
			{
				((Control)xM).Enabled = false;
				((Control)xm).Enabled = false;
				((Control)xN).Enabled = false;
				((Control)xn).Enabled = false;
				a();
				((Control)xT).Enabled = false;
				((Control)xU).Enabled = false;
				((Control)xX).Enabled = false;
			}
		}

		private void A()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			foreach (Control item in (ArrangedElementCollection)((Control)xK).Controls)
			{
				Control val = item;
				if (!(val is Label))
				{
					val.Enabled = false;
				}
			}
		}

		private void a()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			foreach (Control item in (ArrangedElementCollection)((Control)xk).Controls)
			{
				Control val = item;
				if (!(val is Label))
				{
					val.Enabled = false;
				}
			}
		}

		private void B()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			foreach (Control item in (ArrangedElementCollection)((Control)xK).Controls)
			{
				item.Enabled = true;
			}
		}

		private void b()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			foreach (Control item in (ArrangedElementCollection)((Control)xk).Controls)
			{
				item.Enabled = true;
			}
		}

		private void C()
		{
			Xd[0] = BM.Qz.A(9120);
			Xd[1] = BM.Qz.A(9121);
			Xd[2] = BM.Qz.A(9122);
			Xd[3] = BM.Qz.A(9123);
			XE[0] = BM.Qz.A(9124);
			XE[1] = BM.Qz.A(9125);
			XE[2] = BM.Qz.A(9126);
			XE[3] = BM.Qz.A(9127);
			Xe[0] = BM.Qz.A(9128);
			Xe[1] = BM.Qz.A(9129);
			Xe[2] = BM.Qz.A(9130);
			Xe[3] = BM.Qz.A(9131);
			Xh = BM.Qz.A(9132);
			XI = BM.Qz.A(9133);
			Xi = BM.Qz.A(9134);
			XJ = BM.Qz.A(9135);
			Xj = BM.Qz.A(9136);
			for (int i = 0; i < 4; i++)
			{
				XF[i].A(Xd[i].ax());
				try
				{
					((ListControl)Xf[i]).SelectedIndex = XE[i].ax();
				}
				catch
				{
					((ListControl)Xf[i]).SelectedIndex = 0;
				}
				A(i);
				try
				{
					if (Xe[i].aG() == 1 && Xo)
					{
						TrackBar obj2 = XG[i];
						obj2.Maximum /= 4;
						TrackBar obj3 = XG[i];
						obj3.Minimum /= 4;
						TrackBar obj4 = XG[i];
						obj4.LargeChange /= 4;
						TrackBar obj5 = XG[i];
						obj5.TickFrequency /= 4;
					}
					XG[i].Value = Xe[i].ax();
				}
				catch
				{
					XG[i].Value = 0;
				}
			}
			xl.A(Xh.ax());
			try
			{
				((ListControl)XY).SelectedIndex = XI.ax();
			}
			catch (System.Exception)
			{
				((ListControl)XY).SelectedIndex = 0;
			}
			Xl = ((ListControl)XY).SelectedIndex;
			xJ.Value = (decimal)c();
			try
			{
				xE.Value = XJ.ax();
			}
			catch (System.Exception)
			{
				xE.Value = 500;
			}
			int num = Xj.ax();
			List<Setting.ListItems.A> val = Xj.d(0);
			if (val.Count != 0)
			{
				if (((ComboBox)xT).Items.Count == 0)
				{
					for (int j = 0; j < val.Count; j++)
					{
						((ComboBox)xT).Items.Add((object)val[j].bBV);
					}
				}
				int selectedIndex = 0;
				for (int k = 0; k < val.Count; k++)
				{
					if (val[k].bBv == num)
					{
						selectedIndex = k;
						break;
					}
				}
				((ListControl)xT).SelectedIndex = selectedIndex;
			}
			else
			{
				if (((ComboBox)xT).Items.Count == 0)
				{
					((ComboBox)xT).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xq());
					((ComboBox)xT).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XR());
					((ComboBox)xT).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xr());
					((ComboBox)xT).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XS());
					((ComboBox)xT).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xs());
					((ComboBox)xT).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XT());
					((ComboBox)xT).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xt());
					((ComboBox)xT).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XU());
					((ComboBox)xT).Items.Add((object)D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xu());
				}
				switch (num)
				{
				case 20:
					((ListControl)xT).SelectedIndex = 0;
					break;
				case 50:
					((ListControl)xT).SelectedIndex = 1;
					break;
				case 100:
					((ListControl)xT).SelectedIndex = 2;
					break;
				case 200:
					((ListControl)xT).SelectedIndex = 3;
					break;
				case 500:
					((ListControl)xT).SelectedIndex = 4;
					break;
				case 1000:
					((ListControl)xT).SelectedIndex = 5;
					break;
				case 2000:
					((ListControl)xT).SelectedIndex = 6;
					break;
				case 5000:
					((ListControl)xT).SelectedIndex = 7;
					break;
				case 10000:
					((ListControl)xT).SelectedIndex = 8;
					break;
				default:
					((ListControl)xT).SelectedIndex = 0;
					break;
				}
			}
			Xr = C(num);
		}

		private double c()
		{
			if (Xi != null && Xh != null)
			{
				int num = Xi.ax();
				Setting setting = BM.Qz.A(Xh.ax());
				if (setting != null)
				{
					return bS.A(num, setting.aS(), -1);
				}
				return 0.0;
			}
			return 0.0;
		}

		private void A(Setting P_0)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			if (!Bg.A(P_0, null))
			{
				Bg bg = new Bg(P_0.I(), P_0, null);
				((Form)bg).ShowDialog((IWin32Window)(object)this);
				((Component)bg).Dispose();
			}
		}

		private void A(int P_0)
		{
			if (P_0 >= 4)
			{
				return;
			}
			Setting setting = BM.Qz.A(XF[P_0].a());
			if (setting == null || Xf[P_0] == null)
			{
				return;
			}
			if (setting.H() == 0)
			{
				try
				{
					((ListControl)Xf[P_0]).SelectedIndex = XE[P_0].ax();
				}
				catch
				{
					((ListControl)Xf[P_0]).SelectedIndex = 0;
				}
				((Control)Xf[P_0]).Enabled = true;
			}
			else
			{
				((ListControl)Xf[P_0]).SelectedIndex = -1;
				((Control)Xf[P_0]).Enabled = false;
			}
		}

		private void a(int P_0)
		{
			if (Xo || P_0 >= 4 || Xd[P_0] == null)
			{
				return;
			}
			Xd[P_0].a(XF[P_0].a(), true);
			((Control)xL).Invalidate();
			Setting setting = BM.Qz.A(XF[P_0].a());
			if (setting != null)
			{
				A(P_0);
				if (!string.IsNullOrEmpty(setting.I()))
				{
					A(setting);
				}
			}
		}

		private void a(object P_0, EventArgs P_1)
		{
			a(0);
		}

		private void B(object P_0, EventArgs P_1)
		{
			a(1);
		}

		private void b(object P_0, EventArgs P_1)
		{
			a(2);
		}

		private void C(object P_0, EventArgs P_1)
		{
			a(3);
		}

		private void c(object P_0, EventArgs P_1)
		{
			if (!Xo && Xh != null)
			{
				Xh.a(xl.a(), true);
				j(null, null);
				((Control)xL).Invalidate();
			}
		}

		private void B(int P_0)
		{
			if (!Xo && P_0 < 4 && XE[P_0] != null && ((ListControl)Xf[P_0]).SelectedIndex != -1)
			{
				XE[P_0].a(((ListControl)Xf[P_0]).SelectedIndex, true);
				((Control)xL).Invalidate();
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			B(0);
		}

		private void d(object P_0, EventArgs P_1)
		{
			B(1);
		}

		private void E(object P_0, EventArgs P_1)
		{
			B(2);
		}

		private void e(object P_0, EventArgs P_1)
		{
			B(3);
		}

		private void b(int P_0)
		{
			if (!Xo && P_0 < 4 && Xe[P_0] != null)
			{
				Xe[P_0].a(XG[P_0].Value, true);
				((Control)xL).Invalidate();
			}
		}

		private void F(object P_0, EventArgs P_1)
		{
			b(0);
		}

		private void f(object P_0, EventArgs P_1)
		{
			b(1);
		}

		private void G(object P_0, EventArgs P_1)
		{
			b(2);
		}

		private void g(object P_0, EventArgs P_1)
		{
			b(3);
		}

		private void H(object P_0, EventArgs P_1)
		{
			((Control)xL).Invalidate();
		}

		private void h(object P_0, EventArgs P_1)
		{
			((Control)xL).Invalidate();
		}

		private void I(object P_0, EventArgs P_1)
		{
			((Control)xL).Invalidate();
		}

		private void i(object P_0, EventArgs P_1)
		{
			((Control)xL).Invalidate();
		}

		private void J(object P_0, EventArgs P_1)
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (XI == null)
			{
				return;
			}
			if (!Xo)
			{
				XI.a(((ListControl)XY).SelectedIndex, true);
			}
			if (((ListControl)XY).SelectedIndex == 2 || ((ListControl)XY).SelectedIndex == 5 || ((ListControl)XY).SelectedIndex == 8)
			{
				((Control)xJ).Invoke((Action)([CompilerGenerated] () =>
				{
					((Control)xJ).Enabled = false;
				}));
			}
			else
			{
				((Control)xJ).Invoke((Action)([CompilerGenerated] () =>
				{
					((Control)xJ).Enabled = true;
				}));
			}
			if ((Xl == 0 && ((ListControl)XY).SelectedIndex == 4) || (Xl == 1 && ((ListControl)XY).SelectedIndex == 3) || (Xl == 6 && ((ListControl)XY).SelectedIndex == 4) || (Xl == 7 && ((ListControl)XY).SelectedIndex == 3))
			{
				XM = true;
			}
			Xl = ((ListControl)XY).SelectedIndex;
			((Control)xL).Invalidate();
		}

		private void j(object P_0, EventArgs P_1)
		{
			Setting setting = BM.Qz.A(Xh.ax());
			if (!Xo && Xi != null && setting != null)
			{
				double num = (double)xJ.Value;
				Xi.a(bS.A(num, setting.aS()), true);
				((Control)xL).Invalidate();
			}
		}

		private void K(object P_0, EventArgs P_1)
		{
			if (!Xo && XJ != null)
			{
				XJ.a(xE.Value, true);
				((Control)xL).Invalidate();
			}
		}

		private void k(object P_0, EventArgs P_1)
		{
			if (Xo || Xj == null)
			{
				return;
			}
			int num = 0;
			List<Setting.ListItems.A> val = Xj.d(0);
			if (val.Count != 0)
			{
				if (((ListControl)xT).SelectedIndex != -1 && ((ListControl)xT).SelectedIndex < val.Count)
				{
					num = val[((ListControl)xT).SelectedIndex].bBv;
				}
			}
			else
			{
				switch (((ListControl)xT).SelectedIndex)
				{
				case 0:
					num = 20;
					break;
				case 1:
					num = 50;
					break;
				case 2:
					num = 100;
					break;
				case 3:
					num = 200;
					break;
				case 4:
					num = 500;
					break;
				case 5:
					num = 1000;
					break;
				case 6:
					num = 2000;
					break;
				case 7:
					num = 5000;
					break;
				case 8:
					num = 10000;
					break;
				}
			}
			if (num != 0)
			{
				Xj.a(num, true);
			}
			Xr = C(num);
			D();
			((Control)xL).Invalidate();
		}

		private int C(int P_0)
		{
			return Math.Max(1000, 25 * P_0 / 10);
		}

		private void L(object P_0, EventArgs P_1)
		{
			if (Xo || XK == null)
			{
				return;
			}
			if (((CheckBox)((P_0 is CheckBox) ? P_0 : null)).Checked)
			{
				XL.a(1, true);
				XK.a(1, true);
				return;
			}
			XP = false;
			if (XK.ax() == 1)
			{
				XK.a(0, true);
			}
		}

		private double c(int P_0)
		{
			Setting setting = BM.Qz.A(XF[P_0].a());
			if (setting != null && setting.H() != 0)
			{
				double num = setting.H();
				double num2 = setting.h();
				return num * Math.Pow(10.0, num2);
			}
			double[] array = new double[25];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			double[] array2 = array;
			if (((ListControl)Xf[P_0]).SelectedIndex == -1)
			{
				return 1.0;
			}
			return array2[((ListControl)Xf[P_0]).SelectedIndex];
		}

		private double A(int P_0, int P_1)
		{
			if (P_0 >= 4)
			{
				return 0.0;
			}
			int num = P_1 + XD;
			if (num >= 1000)
			{
				num -= 1000;
			}
			int num2 = (int)XC[P_0, num];
			Setting setting = BM.Qz.A(XF[P_0].a());
			if (setting != null)
			{
				return bS.A(num2, setting.aS(), -1);
			}
			return num2;
		}

		private string a(int P_0, int P_1)
		{
			if (P_0 >= 4)
			{
				return string.Empty;
			}
			int num = P_1 + XD;
			if (num >= 1000)
			{
				num -= 1000;
			}
			int num2 = (int)XC[P_0, num];
			Setting setting = BM.Qz.A(XF[P_0].a());
			if (setting != null)
			{
				return bS.a(num2, setting.aS(), -1);
			}
			return num2.ToString();
		}

		private void A(PaintEventArgs P_0)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			P_0.Graphics.FillRectangle(Brushes.Black, new Rectangle(0, 0, ((Control)xL).Width, ((Control)xL).Height));
			int num = ((Control)xL).Width / 2;
			int num2 = ((Control)xL).Height / 2;
			int num3 = ((Control)xL).Width / 10;
			int num4 = num3 / 10;
			int num5 = ((Control)xL).Height / 10;
			int num6 = num5 / 5;
			for (int i = 0; i < ((Control)xL).Width; i += num3)
			{
				P_0.Graphics.DrawLine(Pens.DimGray, i, 0, i, ((Control)xL).Height);
			}
			for (int j = 0; j < ((Control)xL).Height; j += num5)
			{
				P_0.Graphics.DrawLine(Pens.DimGray, 0, j, ((Control)xL).Width, j);
			}
			for (int k = 0; k < ((Control)xL).Width; k += num4)
			{
				P_0.Graphics.DrawLine(Pens.DimGray, k, num2 - 4, k, num2 + 4);
			}
			for (int l = 0; l < ((Control)xL).Height; l += num6)
			{
				P_0.Graphics.DrawLine(Pens.DimGray, num - 4, l, num + 4, l);
			}
		}

		private void A(object P_0, PaintEventArgs P_1)
		{
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Expected O, but got Unknown
			//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected O, but got Unknown
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Expected O, but got Unknown
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			A(P_1);
			int num = ((Control)xL).Height / 2;
			int num2 = ((Control)xL).Height / 10;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = ((Control)xL).Left + xE.Value - ((Control)xs).Width / 2;
			if (((Control)xs).Left != num8)
			{
				((Control)xs).Left = num8;
			}
			for (int i = 0; i < 4; i++)
			{
				bool @checked = ((CheckBox)Xg[i]).Checked;
				((Control)XH[i]).Visible = @checked;
				if (@checked)
				{
					num3 = ((Xe[i].aG() != 1) ? XG[i].Value : (XG[i].Value * 4));
					int num9 = ((Control)xL).Top + num - num3 - 7;
					if (((Control)XH[i]).Top != num9)
					{
						((Control)XH[i]).Top = num9;
					}
				}
				if (!@checked)
				{
					continue;
				}
				num4 = 0;
				double num10 = A(i, 0);
				double num11 = c(i);
				num5 = (int)(num10 * (double)(-num2) / num11) + num - num3;
				for (int j = 0; j < ((Control)xL).Width - 2; j++)
				{
					if (j != 0)
					{
						num4 = num6;
						num5 = num7;
					}
					num6 = j + 1;
					num7 = (int)(A(i, j + 1) * (double)(-num2) / num11) + num - num3;
					try
					{
						if ((num5 >= 0 && num5 <= ((Control)xL).Height) || (num7 >= 0 && num7 <= ((Control)xL).Height))
						{
							P_1.Graphics.DrawLine(XB[i], num4, num5, num6, num7);
						}
					}
					catch
					{
					}
				}
				if (!((CheckBox)xV).Checked)
				{
					continue;
				}
				try
				{
					Font val = new Font(((Control)this).Font.FontFamily, 8f);
					try
					{
						SolidBrush val2 = new SolidBrush(XB[i].Color);
						try
						{
							StringFormat val3 = new StringFormat();
							val3.Alignment = (StringAlignment)((Xm >= ((Control)xL).Width - 50) ? 2 : 0);
							int num12 = (int)(A(i, Xm) * (double)(-num2) / num11) + num - num3;
							val3.LineAlignment = (StringAlignment)((num12 >= ((Control)xL).Height - 20) ? 2 : 0);
							string text = a(i, Xm);
							SizeF val4 = P_1.Graphics.MeasureString(text, val);
							int num13 = (((int)val3.Alignment == 0) ? Xm : (Xm - (int)((SizeF)(ref val4)).Width));
							int num14 = (((int)val3.LineAlignment == 0) ? num12 : (num12 - (int)((SizeF)(ref val4)).Height)) + 1;
							P_1.Graphics.FillRectangle(Brushes.Black, (float)num13, (float)num14, ((SizeF)(ref val4)).Width, ((SizeF)(ref val4)).Height - 4f);
							P_1.Graphics.DrawString(text, val, (Brush)(object)val2, (float)Xm, (float)num12, val3);
							val3.Dispose();
							val3 = new StringFormat();
							val3.Alignment = (StringAlignment)((XN >= ((Control)xL).Width - 50) ? 2 : 0);
							num12 = (int)(A(i, XN) * (double)(-num2) / num11) + num - num3;
							val3.LineAlignment = (StringAlignment)((num12 >= ((Control)xL).Height - 20) ? 2 : 0);
							text = a(i, XN);
							val4 = P_1.Graphics.MeasureString(text, val);
							num13 = (((int)val3.Alignment == 0) ? XN : (XN - (int)((SizeF)(ref val4)).Width));
							num14 = (((int)val3.LineAlignment == 0) ? num12 : (num12 - (int)((SizeF)(ref val4)).Height)) + 1;
							P_1.Graphics.FillRectangle(Brushes.Black, (float)num13, (float)num14, ((SizeF)(ref val4)).Width, ((SizeF)(ref val4)).Height - 4f);
							P_1.Graphics.DrawString(text, val, (Brush)(object)val2, (float)XN, (float)num12, val3);
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
				}
				catch
				{
				}
			}
			if (((CheckBox)xV).Checked)
			{
				P_1.Graphics.DrawLine(Pens.White, Xm, 0, Xm, ((Control)xL).Height - 1);
				P_1.Graphics.DrawLine(Pens.White, XN, 0, XN, ((Control)xL).Height - 1);
			}
		}

		internal void A(uint[,] P_0, ushort P_1)
		{
			if (((uint)BM.qI & 0x1000u) != 0 && aC.GO)
			{
				XC = (Xb = P_0);
				XD = (Xc = P_1);
				((Control)xL).Invalidate();
			}
		}

		private void A(object P_0, ElapsedEventArgs P_1)
		{
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Expected O, but got Unknown
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Expected O, but got Unknown
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Expected O, but got Unknown
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected O, but got Unknown
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Expected O, but got Unknown
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_0478: Unknown result type (might be due to invalid IL or missing references)
			//IL_0482: Expected O, but got Unknown
			bool flag = false;
			try
			{
				Monitor.TryEnter(XV, ref flag);
				if (!flag)
				{
					return;
				}
				Xp.Stop();
				Xp.Enabled = false;
				if (((uint)BM.qI & 0x1000u) != 0 && aC.GO)
				{
					Xp.Enabled = true;
					Xp.Start();
					return;
				}
				if (XK == null || BM.g() || !BM.A(BM.Qz.aXc, true))
				{
					Xc = 0;
					XD = 0;
					Xp.Enabled = true;
					Xp.Start();
					((Control)xK).Invoke((Action)([CompilerGenerated] () =>
					{
						A();
					}));
					((Control)xk).Invoke((Action)([CompilerGenerated] () =>
					{
						a();
					}));
					((Control)xu).Invoke((Action)([CompilerGenerated] () =>
					{
						((Control)xT).Enabled = false;
					}));
					((Control)xu).Invoke((Action)([CompilerGenerated] () =>
					{
						((Control)xU).Enabled = false;
					}));
					return;
				}
				if ((byte)XK.ax() == 1 && !((CheckBox)xU).Checked)
				{
					((Control)xK).Invoke((Action)([CompilerGenerated] () =>
					{
						A();
					}));
					((Control)xk).Invoke((Action)([CompilerGenerated] () =>
					{
						a();
					}));
					((Control)xu).Invoke((Action)([CompilerGenerated] () =>
					{
						((Control)xT).Enabled = false;
					}));
					((Control)xu).Invoke((Action)([CompilerGenerated] () =>
					{
						((Control)xU).Enabled = false;
					}));
				}
				else
				{
					((Control)xK).Invoke((Action)([CompilerGenerated] () =>
					{
						B();
					}));
					((Control)xk).Invoke((Action)([CompilerGenerated] () =>
					{
						b();
					}));
					((Control)xu).Invoke((Action)([CompilerGenerated] () =>
					{
						((Control)xT).Enabled = true;
					}));
					((Control)xu).Invoke((Action)([CompilerGenerated] () =>
					{
						((Control)xU).Enabled = true;
					}));
				}
				int num = XI.ax();
				if (Xk != null && XR)
				{
					if ((num == 6 || num == 7 || num == 8) && ((CheckBox)xU).Checked && !XP && Xk.ax() != 1)
					{
						if (!Xq.IsRunning)
						{
							Xq.Start();
						}
						else if (Xq.ElapsedMilliseconds >= Xr)
						{
							Xk.a(1, true);
							Xp.Enabled = true;
							Xp.Start();
							return;
						}
					}
					else
					{
						Xq.Reset();
					}
				}
				if (((CheckBox)xU).Checked && !XP)
				{
					if ((byte)XK.ax() == 0)
					{
						XK.a(1, true);
					}
					else if ((byte)XK.ax() == 2)
					{
						XP = true;
					}
					if (XQ.ElapsedMilliseconds >= 500)
					{
						XL.a(1, true);
						XQ.Restart();
					}
				}
				if (XP)
				{
					Xq.Reset();
					if (!global::A.A.A(BM.Qz.aXc, global::A.f.ax, 0u, 16384u, out var array, out var _))
					{
						Xc = 0;
						XD = 0;
						Xp.Enabled = true;
						Xp.Start();
						return;
					}
					XP = false;
					Xc = (ushort)((array[4006] << 8) | array[4007]);
					for (uint num2 = 0u; num2 < 4; num2++)
					{
						uint num3 = num2 * 1024 * 4;
						for (uint num4 = 0u; num4 < 1000; num4++)
						{
							uint num5 = num4 * 4;
							byte[] array2 = new byte[4];
							for (uint num6 = 0u; num6 < 4; num6++)
							{
								array2[num6] = array[num3 + num5 + num6];
								if (num6 == 3)
								{
									Xb[num2, num4] = (uint)((array2[0] << 24) | (array2[1] << 16) | (array2[2] << 8) | array2[3]);
								}
							}
						}
					}
					XC = Xb;
					XD = Xc;
					if ((num != 3 && num != 4 && num != 5 && ((CheckBox)xU).Checked) || XM)
					{
						XM = false;
						XL.a(1, true);
						XK.a(1, true);
					}
					else
					{
						XK.a(0, true);
						((Control)xU).Invoke((Action)([CompilerGenerated] () =>
						{
							((CheckBox)xU).Checked = false;
						}));
					}
					((Control)xL).Invalidate();
					if (((uint)BM.qI & 0x400u) != 0)
					{
						BM.Tf.A(XC, XD);
					}
					if (((uint)BM.qI & 0x800u) != 0)
					{
						BM.TG.A(XC, XD);
					}
				}
				Xp.Enabled = true;
				Xp.Start();
			}
			catch
			{
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(XV);
					if (Xp != null)
					{
						Xp.Enabled = true;
						Xp.Start();
					}
				}
			}
		}

		private void l(object P_0, EventArgs P_1)
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			if (Xk != null)
			{
				Xk.a(1, true);
			}
			if (!((CheckBox)xU).Checked)
			{
				((Control)xU).Invoke((Action)([CompilerGenerated] () =>
				{
					((CheckBox)xU).Checked = true;
				}));
			}
		}

		private void D()
		{
			if (((CheckBox)xV).Checked)
			{
				int num = 0;
				List<Setting.ListItems.A> val = Xj.d(0);
				if (val.Count != 0)
				{
					if (((ListControl)xT).SelectedIndex != -1 && ((ListControl)xT).SelectedIndex < val.Count)
					{
						num = val[((ListControl)xT).SelectedIndex].bBv * 10 / 10;
					}
				}
				else
				{
					switch (((ListControl)xT).SelectedIndex)
					{
					case 0:
						num = 20;
						break;
					case 1:
						num = 50;
						break;
					case 2:
						num = 100;
						break;
					case 3:
						num = 200;
						break;
					case 4:
						num = 500;
						break;
					case 5:
						num = 1000;
						break;
					case 6:
						num = 2000;
						break;
					case 7:
						num = 5000;
						break;
					case 8:
						num = 10000;
						break;
					}
				}
				((Control)xv).Text = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XV(), (object)((float)(Math.Abs(Xm - XN) * num) / (float)((Control)xL).Width));
				((Control)xW).Left = ((Control)xL).Left + Xm - ((Control)xW).Width / 2;
				((Control)xw).Left = ((Control)xL).Left + XN - ((Control)xw).Width / 2;
			}
			else
			{
				((Control)xv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xv();
			}
		}

		private void M(object P_0, EventArgs P_1)
		{
			Label obj = xW;
			bool visible = (((Control)xw).Visible = ((CheckBox)xV).Checked);
			((Control)obj).Visible = visible;
			D();
			((Control)xL).Invalidate();
		}

		private void A(object P_0, MouseEventArgs P_1)
		{
			if (((CheckBox)xV).Checked)
			{
				if (P_1.X >= Xm - 3 && P_1.X <= Xm + 3)
				{
					Xn = true;
				}
				else if (P_1.X >= XN - 3 && P_1.X <= XN + 3)
				{
					XO = true;
				}
			}
		}

		private void a(object P_0, MouseEventArgs P_1)
		{
			if (((CheckBox)xV).Checked)
			{
				if (Xn)
				{
					Xm = Math.Min(Math.Max(1, P_1.X), ((Control)xL).Width - 2);
				}
				else if (XO)
				{
					XN = Math.Min(Math.Max(1, P_1.X), ((Control)xL).Width - 2);
				}
				if (Xn || XO)
				{
					D();
					((Control)xL).Invalidate();
				}
			}
		}

		private void B(object P_0, MouseEventArgs P_1)
		{
			Xn = (XO = false);
		}

		private void m(object P_0, EventArgs P_1)
		{
			if (((uint)BM.qI & 0x400u) != 0 && !((CheckBox)xU).Checked)
			{
				BM.Tf.A(XC, XD);
			}
			if (((uint)BM.qI & 0x800u) != 0 && !((CheckBox)xU).Checked)
			{
				BM.TG.A(XC, XD);
			}
			BM.QQ.ae(null, null);
			if (((uint)BM.qI & 0x400u) != 0 && !((CheckBox)xU).Checked)
			{
				BM.Tf.A(XC, XD);
			}
			if (((uint)BM.qI & 0x800u) != 0 && !((CheckBox)xU).Checked)
			{
				BM.TG.A(XC, XD);
			}
		}

		internal void d()
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					b b = d;
					((Control)this).Invoke((System.Delegate)b);
					return;
				}
				catch
				{
					return;
				}
			}
			if ((BM.qI & 0x400) == 0)
			{
				((Control)xX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XW();
			}
			else
			{
				((Control)xX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xw();
			}
		}

		private void A(object P_0, KeyEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			if ((int)P_1.KeyCode == 117)
			{
				((Button)xX).PerformClick();
			}
		}

		private void b(object P_0, MouseEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)P_1.Button == 1048576)
			{
				Label val = (Label)((P_0 is Label) ? P_0 : null);
				Xs = P_1.Y;
				XT[System.Array.IndexOf<Label>(XH, val)] = true;
			}
		}

		private void C(object P_0, MouseEventArgs P_1)
		{
			Label val = (Label)((P_0 is Label) ? P_0 : null);
			int num = System.Array.IndexOf<Label>(XH, val);
			if (XT[num])
			{
				int num2 = ((Control)xL).Height / 2;
				int num3 = ((Control)xL).Top + num2 - (((Control)val).Top + 7 + (P_1.Y - Xs));
				if (Xe[num].aG() == 1)
				{
					num3 /= 4;
				}
				XG[num].Value = Math.Max(Math.Min(num3, XG[num].Maximum), XG[num].Minimum);
			}
		}

		private void c(object P_0, MouseEventArgs P_1)
		{
			Label val = (Label)((P_0 is Label) ? P_0 : null);
			XT[System.Array.IndexOf<Label>(XH, val)] = false;
		}

		private void D(object P_0, MouseEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)P_1.Button == 1048576)
			{
				XS = P_1.X;
				Xt = true;
			}
		}

		private void d(object P_0, MouseEventArgs P_1)
		{
			if (Xt)
			{
				xE.Value = Math.Max(Math.Min(((Control)xs).Left + (P_1.X - XS) + ((Control)xs).Width / 2 - ((Control)xL).Left, xE.Maximum), xE.Minimum);
			}
		}

		private void E(object P_0, MouseEventArgs P_1)
		{
			Xt = false;
		}

		private void e(object P_0, MouseEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)P_1.Button == 1048576)
			{
				XS = P_1.X;
				XU = true;
			}
		}

		private void F(object P_0, MouseEventArgs P_1)
		{
			if (XU)
			{
				Xm = Math.Min(Math.Max(((Control)xW).Left + (P_1.X - XS) + ((Control)xW).Width / 2 - ((Control)xL).Left, 1), ((Control)xL).Width - 2);
				D();
				((Control)xL).Invalidate();
			}
		}

		private void f(object P_0, MouseEventArgs P_1)
		{
			XU = false;
		}

		private void G(object P_0, MouseEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)P_1.Button == 1048576)
			{
				XS = P_1.X;
				Xu = true;
			}
		}

		private void g(object P_0, MouseEventArgs P_1)
		{
			if (Xu)
			{
				XN = Math.Min(Math.Max(((Control)xw).Left + (P_1.X - XS) + ((Control)xw).Width / 2 - ((Control)xL).Left, 1), ((Control)xL).Width - 2);
				D();
				((Control)xL).Invalidate();
			}
		}

		private void H(object P_0, MouseEventArgs P_1)
		{
			Xu = false;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			BM.Qz.A(20069)?.a(0, true);
			try
			{
				if (Xp != null)
				{
					Xp.Stop();
					Xp.Elapsed -= new ElapsedEventHandler(A);
					((Component)Xp).Dispose();
					Xp = null;
				}
				if (XK != null && ((Control)xM).Enabled && ((Control)xm).Enabled && ((Control)xN).Enabled && ((Control)xn).Enabled)
				{
					XK.a(0, true);
				}
			}
			catch
			{
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && Xv != null)
			{
				((System.IDisposable)Xv).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void E()
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected O, but got Unknown
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Expected O, but got Unknown
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected O, but got Unknown
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected O, but got Unknown
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected O, but got Unknown
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Expected O, but got Unknown
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected O, but got Unknown
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Expected O, but got Unknown
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Expected O, but got Unknown
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Expected O, but got Unknown
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Expected O, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Expected O, but got Unknown
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected O, but got Unknown
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Expected O, but got Unknown
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Expected O, but got Unknown
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Expected O, but got Unknown
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Expected O, but got Unknown
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Expected O, but got Unknown
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Expected O, but got Unknown
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			//IL_032b: Unknown result type (might be due to invalid IL or missing references)
			//IL_036a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Expected O, but got Unknown
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_041b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0425: Expected O, but got Unknown
			//IL_044f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0469: Unknown result type (might be due to invalid IL or missing references)
			//IL_048d: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d6: Expected O, but got Unknown
			//IL_0500: Unknown result type (might be due to invalid IL or missing references)
			//IL_051a: Unknown result type (might be due to invalid IL or missing references)
			//IL_053e: Unknown result type (might be due to invalid IL or missing references)
			//IL_057d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0587: Expected O, but got Unknown
			//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05db: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0609: Expected O, but got Unknown
			//IL_061e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0642: Unknown result type (might be due to invalid IL or missing references)
			//IL_067e: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0702: Unknown result type (might be due to invalid IL or missing references)
			//IL_073f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0763: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0807: Unknown result type (might be due to invalid IL or missing references)
			//IL_082b: Unknown result type (might be due to invalid IL or missing references)
			//IL_096e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0992: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_09bf: Expected O, but got Unknown
			//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b31: Expected O, but got Unknown
			//IL_0c51: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca3: Expected O, but got Unknown
			//IL_0dc0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e11: Expected O, but got Unknown
			//IL_0e29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e90: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f13: Expected O, but got Unknown
			//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1017: Unknown result type (might be due to invalid IL or missing references)
			//IL_105a: Unknown result type (might be due to invalid IL or missing references)
			//IL_107e: Unknown result type (might be due to invalid IL or missing references)
			//IL_10bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_110f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1140: Unknown result type (might be due to invalid IL or missing references)
			//IL_114a: Expected O, but got Unknown
			//IL_1164: Unknown result type (might be due to invalid IL or missing references)
			//IL_11b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_11e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ef: Expected O, but got Unknown
			//IL_120c: Unknown result type (might be due to invalid IL or missing references)
			//IL_125c: Unknown result type (might be due to invalid IL or missing references)
			//IL_128d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1297: Expected O, but got Unknown
			//IL_12b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1304: Unknown result type (might be due to invalid IL or missing references)
			//IL_1335: Unknown result type (might be due to invalid IL or missing references)
			//IL_133f: Expected O, but got Unknown
			//IL_1358: Unknown result type (might be due to invalid IL or missing references)
			//IL_137c: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1428: Unknown result type (might be due to invalid IL or missing references)
			//IL_144c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1456: Expected O, but got Unknown
			//IL_1460: Unknown result type (might be due to invalid IL or missing references)
			//IL_1484: Unknown result type (might be due to invalid IL or missing references)
			//IL_14c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ce: Expected O, but got Unknown
			//IL_170c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1736: Unknown result type (might be due to invalid IL or missing references)
			//IL_175e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1774: Unknown result type (might be due to invalid IL or missing references)
			//IL_1798: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_17e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_180b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1844: Unknown result type (might be due to invalid IL or missing references)
			//IL_1857: Unknown result type (might be due to invalid IL or missing references)
			//IL_187b: Unknown result type (might be due to invalid IL or missing references)
			//IL_18b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_1939: Unknown result type (might be due to invalid IL or missing references)
			//IL_1943: Expected O, but got Unknown
			//IL_194c: Unknown result type (might be due to invalid IL or missing references)
			//IL_197f: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ac: Expected O, but got Unknown
			//IL_19d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_19de: Expected O, but got Unknown
			//IL_19e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a1a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a47: Expected O, but got Unknown
			//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a79: Expected O, but got Unknown
			//IL_1a85: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ab8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1adc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ae6: Expected O, but got Unknown
			//IL_1b0e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b18: Expected O, but got Unknown
			//IL_1b24: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b57: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b85: Expected O, but got Unknown
			//IL_1c67: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c91: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ce0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d39: Expected O, but got Unknown
			//IL_1d42: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d75: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d99: Unknown result type (might be due to invalid IL or missing references)
			//IL_1da3: Expected O, but got Unknown
			//IL_1da9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dbf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1de3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e17: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e21: Expected O, but got Unknown
			//IL_1e2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e38: Expected O, but got Unknown
			//IL_1e45: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e4f: Expected O, but got Unknown
			//IL_1e55: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ec3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ecd: Expected O, but got Unknown
			//IL_1eda: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ee4: Expected O, but got Unknown
			//IL_1ef1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1efb: Expected O, but got Unknown
			//IL_1f01: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f17: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f79: Expected O, but got Unknown
			//IL_1f86: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f90: Expected O, but got Unknown
			//IL_1f9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fa7: Expected O, but got Unknown
			//IL_1fad: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fc3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fe7: Unknown result type (might be due to invalid IL or missing references)
			//IL_201b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2025: Expected O, but got Unknown
			//IL_2032: Unknown result type (might be due to invalid IL or missing references)
			//IL_203c: Expected O, but got Unknown
			//IL_2049: Unknown result type (might be due to invalid IL or missing references)
			//IL_2053: Expected O, but got Unknown
			//IL_2072: Unknown result type (might be due to invalid IL or missing references)
			//IL_207c: Expected O, but got Unknown
			//IL_2089: Unknown result type (might be due to invalid IL or missing references)
			//IL_20ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_20e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_20eb: Expected O, but got Unknown
			//IL_20f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_2102: Expected O, but got Unknown
			//IL_210f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2119: Expected O, but got Unknown
			//IL_2146: Unknown result type (might be due to invalid IL or missing references)
			//IL_216a: Unknown result type (might be due to invalid IL or missing references)
			//IL_218e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2198: Expected O, but got Unknown
			//IL_21ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_21d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2216: Unknown result type (might be due to invalid IL or missing references)
			//IL_2220: Expected O, but got Unknown
			//IL_2229: Unknown result type (might be due to invalid IL or missing references)
			//IL_224d: Unknown result type (might be due to invalid IL or missing references)
			//IL_228d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2297: Expected O, but got Unknown
			//IL_22f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_231c: Unknown result type (might be due to invalid IL or missing references)
			//IL_233c: Unknown result type (might be due to invalid IL or missing references)
			//IL_234d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2377: Unknown result type (might be due to invalid IL or missing references)
			//IL_239b: Unknown result type (might be due to invalid IL or missing references)
			//IL_23a5: Expected O, but got Unknown
			//IL_23b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_23bc: Expected O, but got Unknown
			//IL_23c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_23d3: Expected O, but got Unknown
			//IL_23e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_23ea: Expected O, but got Unknown
			//IL_2406: Unknown result type (might be due to invalid IL or missing references)
			//IL_242a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2469: Unknown result type (might be due to invalid IL or missing references)
			//IL_2473: Expected O, but got Unknown
			//IL_2483: Unknown result type (might be due to invalid IL or missing references)
			//IL_24aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_24e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_24ee: Expected O, but got Unknown
			//IL_24fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_2522: Unknown result type (might be due to invalid IL or missing references)
			//IL_2562: Unknown result type (might be due to invalid IL or missing references)
			//IL_256c: Expected O, but got Unknown
			//IL_2579: Unknown result type (might be due to invalid IL or missing references)
			//IL_2583: Expected O, but got Unknown
			//IL_2590: Unknown result type (might be due to invalid IL or missing references)
			//IL_259a: Expected O, but got Unknown
			//IL_25ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_25b7: Expected O, but got Unknown
			//IL_25c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_25eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_262b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2635: Expected O, but got Unknown
			//IL_2642: Unknown result type (might be due to invalid IL or missing references)
			//IL_264c: Expected O, but got Unknown
			//IL_2659: Unknown result type (might be due to invalid IL or missing references)
			//IL_2663: Expected O, but got Unknown
			//IL_2673: Unknown result type (might be due to invalid IL or missing references)
			//IL_269a: Unknown result type (might be due to invalid IL or missing references)
			//IL_26da: Unknown result type (might be due to invalid IL or missing references)
			//IL_26e4: Expected O, but got Unknown
			//IL_26ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_270b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2855: Unknown result type (might be due to invalid IL or missing references)
			//IL_285f: Expected O, but got Unknown
			//IL_28a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_28aa: Expected O, but got Unknown
			//IL_28b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_28bc: Expected O, but got Unknown
			//IL_28c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_28ce: Expected O, but got Unknown
			XW = new aP();
			Xw = new aP();
			XX = new aP();
			Xx = new aP();
			XY = new ThemedComboBox();
			Xy = new Label();
			XZ = new Label();
			Xz = new Label();
			xA = new Label();
			xa = new Label();
			xB = new Label();
			xb = new ThemedComboBox();
			xC = new ThemedComboBox();
			xc = new ThemedComboBox();
			xD = new ThemedComboBox();
			xd = new Label();
			xE = new TrackBar();
			xe = new Label();
			xF = new Label();
			xf = new Label();
			xG = new Label();
			xg = new TrackBar();
			xH = new TrackBar();
			xh = new TrackBar();
			xI = new TrackBar();
			xi = new Label();
			xJ = new NumericUpDown();
			xj = new ThemedButton();
			xK = new Panel();
			xo = new Label();
			xP = new Label();
			xp = new Label();
			xQ = new Label();
			xM = new aI();
			xm = new aI();
			xN = new aI();
			xn = new aI();
			xk = new Panel();
			xO = new Label();
			xl = new aI();
			xq = new Label();
			xR = new Label();
			xr = new Label();
			xS = new Label();
			xs = new Label();
			xT = new ThemedComboBox();
			xt = new Label();
			xU = new aP();
			xu = new Panel();
			xL = new v();
			xV = new aP();
			xv = new Label();
			xW = new Label();
			xw = new Label();
			xX = new ThemedButton();
			((ISupportInitialize)xE).BeginInit();
			((ISupportInitialize)xg).BeginInit();
			((ISupportInitialize)xH).BeginInit();
			((ISupportInitialize)xh).BeginInit();
			((ISupportInitialize)xI).BeginInit();
			((ISupportInitialize)xJ).BeginInit();
			((Control)xK).SuspendLayout();
			((Control)xk).SuspendLayout();
			((Control)xu).SuspendLayout();
			((Control)this).SuspendLayout();
			((Control)XW).AutoSize = true;
			((CheckBox)XW).Checked = true;
			((CheckBox)XW).CheckState = (CheckState)1;
			((Control)XW).ForeColor = Color.Gold;
			((Control)XW).Location = new Point(31, 622);
			((Control)XW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XX();
			((Control)XW).Size = new Size(110, 17);
			((Control)XW).TabIndex = 0;
			((Control)XW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xx();
			((ButtonBase)XW).UseVisualStyleBackColor = true;
			((CheckBox)XW).CheckedChanged += new EventHandler(H);
			((Control)Xw).AutoSize = true;
			((CheckBox)Xw).Checked = true;
			((CheckBox)Xw).CheckState = (CheckState)1;
			((Control)Xw).ForeColor = Color.Violet;
			((Control)Xw).Location = new Point(421, 622);
			((Control)Xw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XY();
			((Control)Xw).Size = new Size(110, 17);
			((Control)Xw).TabIndex = 3;
			((Control)Xw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xy();
			((ButtonBase)Xw).UseVisualStyleBackColor = true;
			((CheckBox)Xw).CheckedChanged += new EventHandler(i);
			((Control)XX).AutoSize = true;
			((CheckBox)XX).Checked = true;
			((CheckBox)XX).CheckState = (CheckState)1;
			((Control)XX).ForeColor = Color.Salmon;
			((Control)XX).Location = new Point(291, 622);
			((Control)XX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XZ();
			((Control)XX).Size = new Size(110, 17);
			((Control)XX).TabIndex = 2;
			((Control)XX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xz();
			((ButtonBase)XX).UseVisualStyleBackColor = true;
			((CheckBox)XX).CheckedChanged += new EventHandler(I);
			((Control)Xx).AutoSize = true;
			((CheckBox)Xx).Checked = true;
			((CheckBox)Xx).CheckState = (CheckState)1;
			((Control)Xx).ForeColor = Color.Aqua;
			((Control)Xx).Location = new Point(161, 622);
			((Control)Xx).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xA();
			((Control)Xx).Size = new Size(110, 17);
			((Control)Xx).TabIndex = 1;
			((Control)Xx).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xa();
			((ButtonBase)Xx).UseVisualStyleBackColor = true;
			((CheckBox)Xx).CheckedChanged += new EventHandler(h);
			((ComboBox)XY).DrawMode = (DrawMode)1;
			((ComboBox)XY).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)XY).FormattingEnabled = true;
			((Control)XY).Location = new Point(4, 63);
			((Control)XY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xB();
			((Control)XY).Size = new Size(232, 23);
			((Control)XY).TabIndex = 19;
			((ComboBox)XY).SelectedIndexChanged += new EventHandler(J);
			((Control)Xy).AutoSize = true;
			((Control)Xy).Location = new Point(2, 47);
			((Control)Xy).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)Xy).Size = new Size(79, 13);
			((Control)Xy).TabIndex = 10;
			((Control)Xy).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xb();
			((Control)XZ).AutoSize = true;
			((Control)XZ).Location = new Point(2, 90);
			((Control)XZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
			((Control)XZ).Size = new Size(101, 13);
			((Control)XZ).TabIndex = 11;
			((Control)XZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xC();
			((Control)Xz).AutoSize = true;
			((Control)Xz).Location = new Point(71, 8);
			((Control)Xz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fY();
			((Control)Xz).Size = new Size(36, 13);
			((Control)Xz).TabIndex = 12;
			((Control)Xz).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xc();
			((Control)xA).AutoSize = true;
			((Control)xA).Location = new Point(71, 73);
			((Control)xA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fZ();
			((Control)xA).Size = new Size(36, 13);
			((Control)xA).TabIndex = 13;
			((Control)xA).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xc();
			((Control)xa).AutoSize = true;
			((Control)xa).Location = new Point(71, 138);
			((Control)xa).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Io();
			((Control)xa).Size = new Size(36, 13);
			((Control)xa).TabIndex = 14;
			((Control)xa).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xc();
			((Control)xB).AutoSize = true;
			((Control)xB).Location = new Point(71, 203);
			((Control)xB).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ip();
			((Control)xB).Size = new Size(36, 13);
			((Control)xB).TabIndex = 15;
			((Control)xB).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xc();
			((ComboBox)xb).DrawMode = (DrawMode)1;
			((ComboBox)xb).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)xb).FormattingEnabled = true;
			((ComboBox)xb).Items.AddRange(new object[25]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xD(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xd(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xE(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xe(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xF(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xf(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xG(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xg(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xH(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xh(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xI(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xi(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xJ(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xj(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xK(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xk(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xL(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xl(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xM(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xm(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xN(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xn(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xO(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xo(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xP()
			});
			((Control)xb).Location = new Point(109, 5);
			((Control)xb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xp();
			((Control)xb).Size = new Size(103, 23);
			((Control)xb).TabIndex = 5;
			((ComboBox)xb).SelectedIndexChanged += new EventHandler(D);
			((ComboBox)xC).DrawMode = (DrawMode)1;
			((ComboBox)xC).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)xC).FormattingEnabled = true;
			((ComboBox)xC).Items.AddRange(new object[25]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xD(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xd(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xE(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xe(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xF(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xf(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xG(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xg(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xH(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xh(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xI(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xi(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xJ(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xj(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xK(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xk(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xL(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xl(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xM(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xm(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xN(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xn(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xO(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xo(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xP()
			});
			((Control)xC).Location = new Point(109, 200);
			((Control)xC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xQ();
			((Control)xC).Size = new Size(103, 23);
			((Control)xC).TabIndex = 11;
			((ComboBox)xC).SelectedIndexChanged += new EventHandler(e);
			((ComboBox)xc).DrawMode = (DrawMode)1;
			((ComboBox)xc).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)xc).FormattingEnabled = true;
			((ComboBox)xc).Items.AddRange(new object[25]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xD(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xd(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xE(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xe(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xF(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xf(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xG(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xg(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xH(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xh(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xI(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xi(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xJ(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xj(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xK(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xk(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xL(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xl(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xM(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xm(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xN(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xn(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xO(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xo(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xP()
			});
			((Control)xc).Location = new Point(109, 135);
			((Control)xc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xq();
			((Control)xc).Size = new Size(103, 23);
			((Control)xc).TabIndex = 9;
			((ComboBox)xc).SelectedIndexChanged += new EventHandler(E);
			((ComboBox)xD).DrawMode = (DrawMode)1;
			((ComboBox)xD).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)xD).FormattingEnabled = true;
			((ComboBox)xD).Items.AddRange(new object[25]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xD(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xd(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xE(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xe(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xF(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xf(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xG(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xg(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xH(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xh(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xI(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xi(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xJ(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xj(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xK(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xk(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xL(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xl(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xM(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xm(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xN(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xn(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xO(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xo(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xP()
			});
			((Control)xD).Location = new Point(109, 70);
			((Control)xD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xR();
			((Control)xD).Size = new Size(103, 23);
			((Control)xD).TabIndex = 7;
			((ComboBox)xD).SelectedIndexChanged += new EventHandler(d);
			((Control)xd).AutoSize = true;
			((Control)xd).Location = new Point(2, 133);
			((Control)xd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GB();
			((Control)xd).Size = new Size(148, 13);
			((Control)xd).TabIndex = 27;
			((Control)xd).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xr();
			xE.LargeChange = 50;
			((Control)xE).Location = new Point(5, 147);
			((Control)xE).Margin = new Padding(0);
			xE.Maximum = 999;
			((Control)xE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xS();
			((Control)xE).Size = new Size(231, 45);
			((Control)xE).TabIndex = 22;
			xE.TickFrequency = 50;
			xE.ValueChanged += new EventHandler(K);
			((Control)xe).AutoSize = true;
			((Control)xe).Location = new Point(0, 275);
			((Control)xe).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GC();
			((Control)xe).Size = new Size(59, 13);
			((Control)xe).TabIndex = 29;
			((Control)xe).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xs();
			((Control)xF).AutoSize = true;
			((Control)xF).Location = new Point(60, 275);
			((Control)xF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GD();
			((Control)xF).Size = new Size(59, 13);
			((Control)xF).TabIndex = 30;
			((Control)xF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xT();
			((Control)xf).AutoSize = true;
			((Control)xf).Location = new Point(120, 275);
			((Control)xf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GE();
			((Control)xf).Size = new Size(59, 13);
			((Control)xf).TabIndex = 31;
			((Control)xf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xt();
			((Control)xG).AutoSize = true;
			((Control)xG).Location = new Point(180, 275);
			((Control)xG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GF();
			((Control)xG).Size = new Size(59, 13);
			((Control)xG).TabIndex = 32;
			((Control)xG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xU();
			xg.LargeChange = 60;
			((Control)xg).Location = new Point(16, 291);
			xg.Maximum = 300;
			xg.Minimum = -300;
			((Control)xg).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xu();
			xg.Orientation = (Orientation)1;
			((Control)xg).Size = new Size(45, 120);
			((Control)xg).TabIndex = 13;
			xg.TickFrequency = 60;
			xg.ValueChanged += new EventHandler(F);
			xH.LargeChange = 60;
			((Control)xH).Location = new Point(76, 291);
			xH.Maximum = 300;
			xH.Minimum = -300;
			((Control)xH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xV();
			xH.Orientation = (Orientation)1;
			((Control)xH).Size = new Size(45, 120);
			((Control)xH).TabIndex = 14;
			xH.TickFrequency = 60;
			xH.ValueChanged += new EventHandler(f);
			xh.LargeChange = 60;
			((Control)xh).Location = new Point(136, 291);
			xh.Maximum = 300;
			xh.Minimum = -300;
			((Control)xh).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xv();
			xh.Orientation = (Orientation)1;
			((Control)xh).Size = new Size(45, 120);
			((Control)xh).TabIndex = 15;
			xh.TickFrequency = 60;
			xh.ValueChanged += new EventHandler(G);
			xI.LargeChange = 60;
			((Control)xI).Location = new Point(196, 291);
			xI.Maximum = 300;
			xI.Minimum = -300;
			((Control)xI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xW();
			xI.Orientation = (Orientation)1;
			((Control)xI).Size = new Size(45, 120);
			((Control)xI).TabIndex = 16;
			xI.TickFrequency = 60;
			xI.ValueChanged += new EventHandler(g);
			((Control)xi).AutoSize = true;
			((Control)xi).Location = new Point(95, 257);
			((Control)xi).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gf();
			((Control)xi).Size = new Size(54, 13);
			((Control)xi).TabIndex = 37;
			((Control)xi).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xw();
			xJ.DecimalPlaces = 2;
			((Control)xJ).Location = new Point(4, 106);
			xJ.Maximum = new decimal(new int[4] { 10000000, 0, 0, 131072 });
			xJ.Minimum = new decimal(new int[4] { 10000000, 0, 0, -2147352576 });
			((Control)xJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xX();
			((Control)xJ).Size = new Size(100, 22);
			((Control)xJ).TabIndex = 20;
			xJ.ValueChanged += new EventHandler(j);
			((Control)xj).Location = new Point(120, 95);
			((Control)xj).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xx();
			((Control)xj).Size = new Size(116, 31);
			((Control)xj).TabIndex = 21;
			((Control)xj).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xY();
			((ButtonBase)xj).UseVisualStyleBackColor = true;
			((Control)xj).Click += new EventHandler(l);
			xK.BorderStyle = (BorderStyle)1;
			((Control)xK).Controls.Add((Control)(object)xo);
			((Control)xK).Controls.Add((Control)(object)xP);
			((Control)xK).Controls.Add((Control)(object)xp);
			((Control)xK).Controls.Add((Control)(object)xQ);
			((Control)xK).Controls.Add((Control)(object)xM);
			((Control)xK).Controls.Add((Control)(object)xm);
			((Control)xK).Controls.Add((Control)(object)xN);
			((Control)xK).Controls.Add((Control)(object)xn);
			((Control)xK).Controls.Add((Control)(object)xi);
			((Control)xK).Controls.Add((Control)(object)Xz);
			((Control)xK).Controls.Add((Control)(object)xI);
			((Control)xK).Controls.Add((Control)(object)xA);
			((Control)xK).Controls.Add((Control)(object)xh);
			((Control)xK).Controls.Add((Control)(object)xa);
			((Control)xK).Controls.Add((Control)(object)xH);
			((Control)xK).Controls.Add((Control)(object)xB);
			((Control)xK).Controls.Add((Control)(object)xg);
			((Control)xK).Controls.Add((Control)(object)xb);
			((Control)xK).Controls.Add((Control)(object)xG);
			((Control)xK).Controls.Add((Control)(object)xC);
			((Control)xK).Controls.Add((Control)(object)xf);
			((Control)xK).Controls.Add((Control)(object)xc);
			((Control)xK).Controls.Add((Control)(object)xF);
			((Control)xK).Controls.Add((Control)(object)xD);
			((Control)xK).Controls.Add((Control)(object)xe);
			((Control)xK).Location = new Point(1031, 1);
			((Control)xK).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xy();
			((Control)xK).Size = new Size(242, 416);
			((Control)xK).TabIndex = 4;
			((Control)xo).AutoSize = true;
			((Control)xo).ForeColor = Color.Violet;
			((Control)xo).Location = new Point(2, 203);
			((Control)xo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xZ();
			((Control)xo).Size = new Size(59, 13);
			((Control)xo).TabIndex = 49;
			((Control)xo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xU();
			((Control)xP).AutoSize = true;
			((Control)xP).ForeColor = Color.Salmon;
			((Control)xP).Location = new Point(3, 138);
			((Control)xP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xz();
			((Control)xP).Size = new Size(59, 13);
			((Control)xP).TabIndex = 48;
			((Control)xP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xt();
			((Control)xp).AutoSize = true;
			((Control)xp).ForeColor = Color.Aqua;
			((Control)xp).Location = new Point(2, 73);
			((Control)xp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gi();
			((Control)xp).Size = new Size(59, 13);
			((Control)xp).TabIndex = 47;
			((Control)xp).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xT();
			((Control)xQ).AutoSize = true;
			((Control)xQ).ForeColor = Color.Gold;
			((Control)xQ).Location = new Point(3, 8);
			((Control)xQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gh();
			((Control)xQ).Size = new Size(59, 13);
			((Control)xQ).TabIndex = 46;
			((Control)xQ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.xs();
			((Control)xM).AutoSize = true;
			((UserControl)xM).AutoSizeMode = (AutoSizeMode)0;
			((Control)xM).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
			((Control)xM).Location = new Point(5, 29);
			((Control)xM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YA();
			xM.A(0);
			((Control)xM).Size = new Size(232, 23);
			((Control)xM).TabIndex = 6;
			xM.A(new EventHandler(a));
			((Control)xm).AutoSize = true;
			((UserControl)xm).AutoSizeMode = (AutoSizeMode)0;
			((Control)xm).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
			((Control)xm).Location = new Point(5, 94);
			((Control)xm).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ya();
			xm.A(0);
			((Control)xm).Size = new Size(232, 23);
			((Control)xm).TabIndex = 8;
			xm.A(new EventHandler(B));
			((Control)xN).AutoSize = true;
			((UserControl)xN).AutoSizeMode = (AutoSizeMode)0;
			((Control)xN).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
			((Control)xN).Location = new Point(5, 159);
			((Control)xN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YB();
			xN.A(0);
			((Control)xN).Size = new Size(232, 23);
			((Control)xN).TabIndex = 10;
			xN.A(new EventHandler(b));
			((Control)xn).AutoSize = true;
			((UserControl)xn).AutoSizeMode = (AutoSizeMode)0;
			((Control)xn).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
			((Control)xn).Location = new Point(5, 224);
			((Control)xn).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yb();
			xn.A(0);
			((Control)xn).Size = new Size(232, 23);
			((Control)xn).TabIndex = 12;
			xn.A(new EventHandler(C));
			xk.BorderStyle = (BorderStyle)1;
			((Control)xk).Controls.Add((Control)(object)xO);
			((Control)xk).Controls.Add((Control)(object)xl);
			((Control)xk).Controls.Add((Control)(object)XY);
			((Control)xk).Controls.Add((Control)(object)Xy);
			((Control)xk).Controls.Add((Control)(object)xj);
			((Control)xk).Controls.Add((Control)(object)XZ);
			((Control)xk).Controls.Add((Control)(object)xJ);
			((Control)xk).Controls.Add((Control)(object)xE);
			((Control)xk).Controls.Add((Control)(object)xd);
			((Control)xk).Location = new Point(1031, 418);
			((Control)xk).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YC();
			((Control)xk).Size = new Size(242, 184);
			((Control)xk).TabIndex = 17;
			((Control)xO).AutoSize = true;
			((Control)xO).Location = new Point(2, 3);
			((Control)xO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Gg();
			((Control)xO).Size = new Size(89, 13);
			((Control)xO).TabIndex = 42;
			((Control)xO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yc();
			((Control)xl).AutoSize = true;
			((UserControl)xl).AutoSizeMode = (AutoSizeMode)0;
			((Control)xl).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
			((Control)xl).Location = new Point(4, 19);
			((Control)xl).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YD();
			xl.A(0);
			((Control)xl).Size = new Size(232, 23);
			((Control)xl).TabIndex = 18;
			xl.A(new EventHandler(c));
			((Control)xq).ForeColor = Color.Gold;
			((Control)xq).Location = new Point(0, 496);
			((Control)xq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yd();
			((Control)xq).Size = new Size(28, 13);
			((Control)xq).TabIndex = 45;
			((Control)xq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YE();
			((Control)xq).MouseDown += new MouseEventHandler(b);
			((Control)xq).MouseMove += new MouseEventHandler(C);
			((Control)xq).MouseUp += new MouseEventHandler(c);
			((Control)xR).ForeColor = Color.Aqua;
			((Control)xR).Location = new Point(0, 516);
			((Control)xR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ye();
			((Control)xR).Size = new Size(28, 13);
			((Control)xR).TabIndex = 46;
			((Control)xR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YF();
			((Control)xR).MouseDown += new MouseEventHandler(b);
			((Control)xR).MouseMove += new MouseEventHandler(C);
			((Control)xR).MouseUp += new MouseEventHandler(c);
			((Control)xr).ForeColor = Color.Salmon;
			((Control)xr).Location = new Point(0, 536);
			((Control)xr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yf();
			((Control)xr).Size = new Size(28, 13);
			((Control)xr).TabIndex = 47;
			((Control)xr).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YG();
			((Control)xr).MouseDown += new MouseEventHandler(b);
			((Control)xr).MouseMove += new MouseEventHandler(C);
			((Control)xr).MouseUp += new MouseEventHandler(c);
			((Control)xS).ForeColor = Color.Violet;
			((Control)xS).Location = new Point(0, 556);
			((Control)xS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yg();
			((Control)xS).Size = new Size(28, 13);
			((Control)xS).TabIndex = 48;
			((Control)xS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YH();
			((Control)xS).MouseDown += new MouseEventHandler(b);
			((Control)xS).MouseMove += new MouseEventHandler(C);
			((Control)xS).MouseUp += new MouseEventHandler(c);
			((Control)xs).AutoSize = true;
			((Control)xs).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)xs).Location = new Point(22, 602);
			((Control)xs).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yh();
			((Control)xs).Size = new Size(13, 13);
			((Control)xs).TabIndex = 49;
			((Control)xs).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mL();
			((Control)xs).MouseDown += new MouseEventHandler(D);
			((Control)xs).MouseMove += new MouseEventHandler(d);
			((Control)xs).MouseUp += new MouseEventHandler(E);
			((ComboBox)xT).DrawMode = (DrawMode)1;
			((ComboBox)xT).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)xT).FormattingEnabled = true;
			((Control)xT).Location = new Point(4, 12);
			((Control)xT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YI();
			((Control)xT).Size = new Size(100, 23);
			((Control)xT).TabIndex = 24;
			((ComboBox)xT).SelectedIndexChanged += new EventHandler(k);
			((Control)xt).AutoSize = true;
			((Control)xt).Location = new Point(2, -1);
			((Control)xt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Iq();
			((Control)xt).Size = new Size(60, 13);
			((Control)xt).TabIndex = 51;
			((Control)xt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yi();
			((Control)xU).AutoSize = true;
			((Control)xU).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)xU).Location = new Point(119, 6);
			((Control)xU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YJ();
			((Control)xU).Size = new Size(103, 25);
			((Control)xU).TabIndex = 23;
			((Control)xU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yj();
			((ButtonBase)xU).UseVisualStyleBackColor = true;
			((CheckBox)xU).CheckedChanged += new EventHandler(L);
			xu.BorderStyle = (BorderStyle)1;
			((Control)xu).Controls.Add((Control)(object)xT);
			((Control)xu).Controls.Add((Control)(object)xU);
			((Control)xu).Controls.Add((Control)(object)xt);
			((Control)xu).Location = new Point(1031, 603);
			((Control)xu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YK();
			((Control)xu).Size = new Size(242, 38);
			((Control)xu).TabIndex = 53;
			((Control)xL).Location = new Point(29, 1);
			((Control)xL).Margin = new Padding(0);
			((Control)xL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yk();
			((Control)xL).Size = new Size(1001, 601);
			((Control)xL).TabIndex = 43;
			((Control)xL).Paint += new PaintEventHandler(A);
			((Control)xL).MouseDown += new MouseEventHandler(A);
			((Control)xL).MouseMove += new MouseEventHandler(a);
			((Control)xL).MouseUp += new MouseEventHandler(B);
			((Control)xV).AutoSize = true;
			((Control)xV).Location = new Point(559, 622);
			((Control)xV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YL();
			((Control)xV).Size = new Size(124, 17);
			((Control)xV).TabIndex = 4;
			((Control)xV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yl();
			((ButtonBase)xV).UseVisualStyleBackColor = true;
			((CheckBox)xV).CheckedChanged += new EventHandler(M);
			((Control)xv).Location = new Point(689, 623);
			((Control)xv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YM();
			((Control)xv).Size = new Size(190, 13);
			((Control)xv).TabIndex = 54;
			((Control)xv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xv();
			((Control)xW).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)xW).Location = new Point(620, 602);
			((Control)xW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ym();
			((Control)xW).Size = new Size(13, 13);
			((Control)xW).TabIndex = 55;
			((Control)xW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mP();
			((Control)xW).Visible = false;
			((Control)xW).MouseDown += new MouseEventHandler(e);
			((Control)xW).MouseMove += new MouseEventHandler(F);
			((Control)xW).MouseUp += new MouseEventHandler(f);
			((Control)xw).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)xw).Location = new Point(650, 602);
			((Control)xw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YN();
			((Control)xw).Size = new Size(13, 13);
			((Control)xw).TabIndex = 56;
			((Control)xw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.vc();
			((Control)xw).Visible = false;
			((Control)xw).MouseDown += new MouseEventHandler(G);
			((Control)xw).MouseMove += new MouseEventHandler(g);
			((Control)xw).MouseUp += new MouseEventHandler(H);
			((Control)xX).Location = new Point(883, 616);
			((Control)xX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yn();
			((Control)xX).Size = new Size(145, 24);
			((Control)xX).TabIndex = 57;
			((Control)xX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XW();
			((ButtonBase)xX).UseVisualStyleBackColor = true;
			((Control)xX).Click += new EventHandler(m);
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(1274, 642);
			((Control)this).Controls.Add((Control)(object)xX);
			((Control)this).Controls.Add((Control)(object)xw);
			((Control)this).Controls.Add((Control)(object)xW);
			((Control)this).Controls.Add((Control)(object)xv);
			((Control)this).Controls.Add((Control)(object)xV);
			((Control)this).Controls.Add((Control)(object)xu);
			((Control)this).Controls.Add((Control)(object)xs);
			((Control)this).Controls.Add((Control)(object)xS);
			((Control)this).Controls.Add((Control)(object)xr);
			((Control)this).Controls.Add((Control)(object)xR);
			((Control)this).Controls.Add((Control)(object)xq);
			((Control)this).Controls.Add((Control)(object)xL);
			((Control)this).Controls.Add((Control)(object)xk);
			((Control)this).Controls.Add((Control)(object)xK);
			((Control)this).Controls.Add((Control)(object)Xx);
			((Control)this).Controls.Add((Control)(object)XX);
			((Control)this).Controls.Add((Control)(object)Xw);
			((Control)this).Controls.Add((Control)(object)XW);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).KeyPreview = true;
			((Form)this).MaximizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YO();
			((Form)this).ShowIcon = false;
			((Form)this).StartPosition = (FormStartPosition)0;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PN();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).KeyDown += new KeyEventHandler(A);
			((ISupportInitialize)xE).EndInit();
			((ISupportInitialize)xg).EndInit();
			((ISupportInitialize)xH).EndInit();
			((ISupportInitialize)xh).EndInit();
			((ISupportInitialize)xI).EndInit();
			((ISupportInitialize)xJ).EndInit();
			((Control)xK).ResumeLayout(false);
			((Control)xK).PerformLayout();
			((Control)xk).ResumeLayout(false);
			((Control)xk).PerformLayout();
			((Control)xu).ResumeLayout(false);
			((Control)xu).PerformLayout();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}

		[CompilerGenerated]
		private void e()
		{
			((Control)xJ).Enabled = false;
		}

		[CompilerGenerated]
		private void F()
		{
			((Control)xJ).Enabled = true;
		}

		[CompilerGenerated]
		private void f()
		{
			A();
		}

		[CompilerGenerated]
		private void G()
		{
			a();
		}

		[CompilerGenerated]
		private void g()
		{
			((Control)xT).Enabled = false;
		}

		[CompilerGenerated]
		private void H()
		{
			((Control)xU).Enabled = false;
		}

		[CompilerGenerated]
		private void h()
		{
			A();
		}

		[CompilerGenerated]
		private void I()
		{
			a();
		}

		[CompilerGenerated]
		private void i()
		{
			((Control)xT).Enabled = false;
		}

		[CompilerGenerated]
		private void J()
		{
			((Control)xU).Enabled = false;
		}

		[CompilerGenerated]
		private void j()
		{
			B();
		}

		[CompilerGenerated]
		private void K()
		{
			b();
		}

		[CompilerGenerated]
		private void k()
		{
			((Control)xT).Enabled = true;
		}

		[CompilerGenerated]
		private void L()
		{
			((Control)xU).Enabled = true;
		}

		[CompilerGenerated]
		private void l()
		{
			((CheckBox)xU).Checked = false;
		}

		[CompilerGenerated]
		private void M()
		{
			((CheckBox)xU).Checked = true;
		}
	}
	internal class Bx : Form
	{
		private static Bx xx;

		private Framework xY;

		private SortedList<string, ListViewItem> xy;

		private static int xZ;

		private IContainer xz;

		private ThemedButton YA;

		private ThemedButton Ya;

		private Timer YB;

		private ThemedTextBox Yb;

		private ab YC;

		private ColumnHeader Yc;

		private ColumnHeader YD;

		private ColumnHeader Yd;

		private ag YE;

		private ThemedButton Ye;

		private ColumnHeader YF;

		private PictureBox Yf;

		internal static int A(IWin32Window P_0, Framework P_1, int P_2)
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Invalid comparison between Unknown and I4
			if (xx == null)
			{
				xx = new Bx();
			}
			xx.xY = P_1;
			xZ = P_2;
			xx.A(P_2);
			((Control)xx).BackColor = BM.td;
			((Control)xx.Yf).BackColor = BM.td;
			if (xx.Yf.Image != null)
			{
				xx.Yf.Image.Dispose();
			}
			xx.Yf.Image = (Image)(object)O.A((Image)(object)GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, BM.TX, BM.Tx, BM.TY);
			((Control)xx.YE).BackColor = BM.tH;
			((Control)xx.YE).ForeColor = BM.te;
			((Control)xx.YC).BackColor = BM.tH;
			((Control)xx.YC).ForeColor = BM.te;
			((Control)xx.Yb).BackColor = BM.to;
			((Control)xx.Yb).ForeColor = BM.te;
			DialogResult val = ((Form)xx).ShowDialog(P_0);
			xx.xY = null;
			if ((int)val == 1)
			{
				return xx.A();
			}
			return 0;
		}

		internal Bx()
		{
			a();
			xy = new SortedList<string, ListViewItem>();
			Yb.A(A);
		}

		[SpecialName]
		internal int A()
		{
			if (((ListView)YC).SelectedItems.Count == 0)
			{
				return 0;
			}
			return (int)((ListView)YC).SelectedItems[0].Tag;
		}

		[SpecialName]
		internal void A(int P_0)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			foreach (ListViewItem item in ((ListView)YC).Items)
			{
				ListViewItem val = item;
				if (P_0 != (int)val.Tag)
				{
					val.Selected = false;
				}
			}
			((ListView)YC).SelectedItems.Clear();
			foreach (ListViewItem item2 in ((ListView)YC).Items)
			{
				ListViewItem val2 = item2;
				if (P_0 == (int)val2.Tag)
				{
					val2.Selected = true;
					((ListView)YC).FocusedItem = val2;
					break;
				}
			}
		}

		private void A(object P_0, MouseEventArgs P_1)
		{
			if (((ListView)YC).SelectedItems.Count != 0)
			{
				((Form)this).Close();
				((Form)this).DialogResult = (DialogResult)1;
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			if (xY == null)
			{
				return;
			}
			if (((ListView)YC).SelectedItems.Count != 0)
			{
				Setting setting = xY.A((int)((ListView)YC).SelectedItems[0].Tag);
				string text = ((SettingOrSpecialObject)setting).A(bz.aYt);
				if (text != null)
				{
					((Control)YE).Text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI();
				}
				else
				{
					((Control)YE).Text = ((SettingOrSpecialObject)setting).B() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI();
				}
				((TextBoxBase)YE).Select(0, ((TextBoxBase)YE).TextLength);
				((RichTextBox)YE).SelectionFont = new Font(((RichTextBox)YE).SelectionFont.FontFamily, ((RichTextBox)YE).SelectionFont.Size, (FontStyle)1);
				((TextBoxBase)YE).SelectionLength = 0;
				int textLength = ((TextBoxBase)YE).TextLength;
				string text2 = ((SettingOrSpecialObject)setting).A(bz.aYU);
				if (text2 != null)
				{
					((TextBoxBase)YE).AppendText(text2);
				}
				else if (text != null)
				{
					((TextBoxBase)YE).AppendText(text);
				}
				else
				{
					string text3 = ((SettingOrSpecialObject)setting).A(bz.aYT);
					if (text3 != null)
					{
						((TextBoxBase)YE).AppendText(text3);
					}
					else
					{
						((TextBoxBase)YE).AppendText(((SettingOrSpecialObject)setting).B());
					}
				}
				int num = ((TextBoxBase)YE).TextLength - textLength;
				((TextBoxBase)YE).Select(textLength, num);
				((TextBoxBase)YE).SelectionLength = 0;
				((Control)Ya).Enabled = true;
			}
			else
			{
				((Control)YE).Text = string.Empty;
				((Control)Ya).Enabled = false;
			}
		}

		private void A(object P_0, KeyPressEventArgs P_1)
		{
			YB.Stop();
			YB.Start();
		}

		private void A(object P_0, ThemedTextBox.B P_1)
		{
			YB.Stop();
			YB.Start();
		}

		private void a(object P_0, EventArgs P_1)
		{
			YB.Stop();
			a(-1);
		}

		private void A(object P_0, KeyEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			if ((int)P_1.KeyCode == 40 && ((ListView)YC).SelectedIndices.Count != 0)
			{
				((Control)YC).Focus();
			}
		}

		private void a(int P_0)
		{
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Expected O, but got Unknown
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			if (xY == null)
			{
				return;
			}
			string text = ((Control)Yb).Text.ToUpper();
			string[] array = text.Split(RuntimeHelpers.CreateSpan<char>((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/));
			((ListView)YC).BeginUpdate();
			((ListView)YC).Items.Clear();
			System.Collections.Generic.IEnumerator<ListViewItem> enumerator = ((System.Collections.Generic.IEnumerable<ListViewItem>)xy.Values).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ListViewItem current = enumerator.Current;
					Setting setting = xY.A((int)current.Tag);
					if (setting == null)
					{
						continue;
					}
					string text2 = ((SettingOrSpecialObject)setting).A(true);
					string text3 = string.Empty;
					if (((SettingOrSpecialObject)setting).s() != null)
					{
						text3 = ((SettingOrSpecialObject)setting).s();
					}
					string text4 = ((SettingOrSpecialObject)setting).A(bz.aYT);
					if (text4 == null)
					{
						text4 = ((SettingOrSpecialObject)setting).B();
					}
					string text5 = text4.ToUpper();
					string text6 = text2.ToUpper();
					string text7 = text3.ToUpper();
					bool flag = true;
					bool flag2 = false;
					if (text == text6 || text == text5)
					{
						flag2 = true;
					}
					else
					{
						Enumerator<string> enumerator2 = ((SettingOrSpecialObject)setting).i().GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								string current2 = enumerator2.Current;
								if (text == current2.ToUpper())
								{
									flag2 = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
					}
					if (!flag2)
					{
						string[] array2 = array;
						foreach (string text8 in array2)
						{
							if (text6.Contains(text8) || text5.Contains(text8) || text7.Contains(text8))
							{
								continue;
							}
							bool flag3 = false;
							Enumerator<string> enumerator2 = ((SettingOrSpecialObject)setting).i().GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									if (enumerator2.Current.ToUpper().Contains(text8))
									{
										flag3 = true;
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator2).Dispose();
							}
							if (!flag3)
							{
								flag = false;
								break;
							}
						}
					}
					if (flag)
					{
						if (((ListView)YC).Items.Count != 0 && flag2)
						{
							((ListView)YC).Items.Insert(0, current);
						}
						else
						{
							((ListView)YC).Items.Add(current);
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			if (P_0 != -1)
			{
				A(P_0);
				foreach (ListViewItem item in ((ListView)YC).Items)
				{
					ListViewItem val = item;
					if (P_0 == (int)val.Tag)
					{
						((ListView)YC).EnsureVisible(((ListView)YC).Items.IndexOf(val));
						break;
					}
				}
			}
			else if (((ListView)YC).Items.Count != 0)
			{
				ListViewItem val2 = ((ListView)YC).Items[0];
				val2.Selected = true;
				((ListView)YC).FocusedItem = val2;
			}
			((ListView)YC).EndUpdate();
			((Control)Ya).Enabled = ((ListView)YC).SelectedItems.Count != 0;
			YC.a();
		}

		private void B(object P_0, EventArgs P_1)
		{
			((TextBoxBase)Yb).Clear();
			A((object)null, (KeyPressEventArgs)null);
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			((Form)this).OnVisibleChanged(e);
			((Control)Yb).Focus();
		}

		protected override void OnShown(EventArgs e)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected O, but got Unknown
			((Form)this).OnShown(e);
			((TextBoxBase)Yb).Clear();
			xy.Clear();
			List<string> val = new List<string>();
			Enumerator<Setting> enumerator = xY.aWt.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					if (!((SettingOrSpecialObject)current).l() || !current.aC() || current.al() || (((Control)BM.QQ.rn).Visible && !BM.C(current.A())) || !PortFunction.A(current))
					{
						continue;
					}
					string text = ((SettingOrSpecialObject)current).A(bz.aYt);
					if (text == null)
					{
						text = ((SettingOrSpecialObject)current).B();
					}
					string text2 = ((SettingOrSpecialObject)current).H();
					if (!string.IsNullOrWhiteSpace(text2))
					{
						text = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eO() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E();
					}
					string text3 = string.Empty;
					if (((SettingOrSpecialObject)current).s() != null)
					{
						text3 = ((SettingOrSpecialObject)current).s();
					}
					string text4 = ((SettingOrSpecialObject)current).A(bz.aYT);
					if (text4 == null)
					{
						text4 = ((SettingOrSpecialObject)current).B();
					}
					int num = current.aS();
					string text5 = bS.A(current.@as(), num, false, 0);
					ListViewItem val2 = new ListViewItem(new string[4] { text, text3, text4, text5 });
					val2.Tag = current.A();
					if (xy.ContainsKey(text))
					{
						if (!val.Contains(text))
						{
							val.Add(text);
						}
					}
					else
					{
						xy.Add(text, val2);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (val.Count != 0)
			{
				string text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yo();
				Enumerator<string> enumerator2 = val.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						string current2 = enumerator2.Current;
						text6 = text6 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy() + current2;
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				bE.A((IWin32Window)(object)this, text6, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			a((A() != 0) ? A() : xZ);
			((Control)Yb).Focus();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			e.Cancel = (int)((Form)this).DialogResult == 1 && ((ListView)YC).SelectedItems.Count == 0;
		}

		private void b(object P_0, EventArgs P_1)
		{
			YC.a();
		}

		private void A(object P_0, ColumnWidthChangedEventArgs P_1)
		{
			YC.a();
		}

		private void A(object P_0, ColumnWidthChangingEventArgs P_1)
		{
			YC.a();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && xz != null)
			{
				((System.IDisposable)xz).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected O, but got Unknown
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Expected O, but got Unknown
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Expected O, but got Unknown
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected O, but got Unknown
			//IL_032b: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Expected O, but got Unknown
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Expected O, but got Unknown
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_0392: Expected O, but got Unknown
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Expected O, but got Unknown
			//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d4: Expected O, but got Unknown
			//IL_050a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0514: Expected O, but got Unknown
			xz = (IContainer)new Container();
			ComponentResourceManager val = new ComponentResourceManager(typeof(Bx));
			YA = new ThemedButton();
			Ya = new ThemedButton();
			YB = new Timer(xz);
			Yb = new ThemedTextBox();
			Ye = new ThemedButton();
			YE = new ag();
			YC = new ab();
			Yc = new ColumnHeader();
			YF = new ColumnHeader();
			Yd = new ColumnHeader();
			YD = new ColumnHeader();
			Yf = new PictureBox();
			((ISupportInitialize)Yf).BeginInit();
			((Control)this).SuspendLayout();
			val.ApplyResources((object)YA, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YP());
			((Control)YA).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Button)YA).DialogResult = (DialogResult)2;
			((Control)YA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YP();
			((ButtonBase)YA).UseVisualStyleBackColor = true;
			((Button)Ya).DialogResult = (DialogResult)1;
			val.ApplyResources((object)Ya, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yp());
			((Control)Ya).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)Ya).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yp();
			((ButtonBase)Ya).UseVisualStyleBackColor = true;
			YB.Interval = 400;
			YB.Tick += new EventHandler(a);
			val.ApplyResources((object)Yb, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YQ());
			((Control)Yb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YQ();
			((Control)Yb).KeyDown += new KeyEventHandler(A);
			((Control)Yb).KeyPress += new KeyPressEventHandler(A);
			val.ApplyResources((object)Ye, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fj());
			((Control)Ye).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
			((Control)Ye).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fj();
			((ButtonBase)Ye).UseVisualStyleBackColor = true;
			((Control)Ye).Click += new EventHandler(B);
			((Control)YE).BackColor = SystemColors.Window;
			((TextBoxBase)YE).BorderStyle = (BorderStyle)0;
			val.ApplyResources((object)YE, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KO());
			((Control)YE).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)YE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KO();
			((TextBoxBase)YE).ReadOnly = true;
			((ListView)YC).Columns.AddRange((ColumnHeader[])(object)new ColumnHeader[4] { Yc, YF, Yd, YD });
			((ListView)YC).FullRowSelect = true;
			((ListView)YC).HeaderStyle = (ColumnHeaderStyle)1;
			((ListView)YC).HideSelection = false;
			val.ApplyResources((object)YC, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yq());
			((Control)YC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yq();
			((ListView)YC).TileSize = new Size(400, 16);
			((ListView)YC).UseCompatibleStateImageBehavior = false;
			((ListView)YC).View = (View)1;
			((ListView)YC).ColumnWidthChanged += new ColumnWidthChangedEventHandler(A);
			((ListView)YC).ColumnWidthChanging += new ColumnWidthChangingEventHandler(A);
			((ListView)YC).SelectedIndexChanged += new EventHandler(A);
			((Control)YC).MouseDoubleClick += new MouseEventHandler(A);
			val.ApplyResources((object)Yc, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YR());
			val.ApplyResources((object)YF, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Yr());
			val.ApplyResources((object)Yd, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YS());
			val.ApplyResources((object)YD, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ys());
			val.ApplyResources((object)Yf, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fJ());
			((Control)Yf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fJ();
			Yf.TabStop = false;
			((Form)this).AcceptButton = (IButtonControl)(object)Ya;
			val.ApplyResources((object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fr());
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)YA;
			((Control)this).Controls.Add((Control)(object)YA);
			((Control)this).Controls.Add((Control)(object)Ya);
			((Control)this).Controls.Add((Control)(object)Yf);
			((Control)this).Controls.Add((Control)(object)Yb);
			((Control)this).Controls.Add((Control)(object)Ye);
			((Control)this).Controls.Add((Control)(object)YE);
			((Control)this).Controls.Add((Control)(object)YC);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.YT();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Control)this).Resize += new EventHandler(b);
			((ISupportInitialize)Yf).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal class bX
	{
		internal string axV;

		internal string axv;

		internal string axW;

		internal string axw;

		internal string axX;

		internal string[] axx;

		public virtual string ToString()
		{
			return string.Concat(new string[10]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amb(),
				axV,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amC(),
				axv,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amc(),
				axW,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amD(),
				axw,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amd(),
				axX
			});
		}
	}
	internal static class bx
	{
		private static Dictionary<bw, bX> axY;

		internal static void A()
		{
			Dictionary<bw, bX> val = new Dictionary<bw, bX>();
			val.Add(new bw(20, 3), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amE(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ame(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amF(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amf(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amG(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amg() }
			});
			val.Add(new bw(20, 4), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amH(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amh(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amI(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ami(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amJ(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amj() }
			});
			val.Add(new bw(20, 19), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amK(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amk(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amL(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aml(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amM(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amm() }
			});
			val.Add(new bw(20, 16), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amN(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amn(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amO(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amo(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amP(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amp() }
			});
			val.Add(new bw(20, 18), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amQ(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amq(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amR(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amr(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amS(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ams() }
			});
			val.Add(new bw(20, 33), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amT(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amt(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amU(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amu(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amV(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amv() }
			});
			val.Add(new bw(20, 32), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amW(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amw(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amX(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amx(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amY(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amy() }
			});
			val.Add(new bw(20, 6), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amZ(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amz(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNA(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNa(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNB(),
				axx = new string[3]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNb(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNC(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNc()
				}
			});
			val.Add(new bw(24, 6), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aND(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNd(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNA(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNa(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNB(),
				axx = new string[3]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNb(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNC(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNc()
				}
			});
			val.Add(new bw(24, 21), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNE(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNe(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNA(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNF(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNf(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNG() }
			});
			val.Add(new bw(24, 20), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNg(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNH(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNA(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNh(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNI(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNi() }
			});
			val.Add(new bw(24, 27), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNJ(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNj(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNA(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNK(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNk(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNL() }
			});
			val.Add(new bw(24, 25), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNl(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNM(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNA(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNm(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNN(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNn() }
			});
			val.Add(new bw(24, 31), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNO(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNo(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNA(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNP(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNp(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNQ() }
			});
			val.Add(new bw(24, 28), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNq(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNR(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNA(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNr(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNS(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNs() }
			});
			val.Add(new bw(24, 30), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNT(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNt(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNA(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNU(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNu(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNV() }
			});
			val.Add(new bw(24, 36), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNv(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNW(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNA(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNw(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNX(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNx() }
			});
			val.Add(new bw(25, 17), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNY(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNy(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNZ(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aNz(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anA(),
				axx = new string[3]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ana(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anB(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anb()
				}
			});
			val.Add(new bw(25, 23), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anC(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anc(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anD(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.and(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anE(),
				axx = new string[3]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ane(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anF(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anf()
				}
			});
			val.Add(new bw(25, 34), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anG(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ang(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anH(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anh(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anI(),
				axx = new string[3]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ani(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anJ(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anj()
				}
			});
			val.Add(new bw(21, 41), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anK(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anK(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ank(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anL(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anl(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anM() }
			});
			val.Add(new bw(21, 12), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anm(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anm(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anN(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ann(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anO(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ano() }
			});
			val.Add(new bw(21, 11), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anP(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anP(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anp(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anQ(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anq(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anR() }
			});
			val.Add(new bw(8, 2), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anr(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anS(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ans(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anT(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ant(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anU() }
			});
			val.Add(new bw(8, 11), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anu(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anV(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anv(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anW(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anw(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anX() }
			});
			val.Add(new bw(8, 3), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anx(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anY(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.any(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anZ(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.anz(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOA() }
			});
			val.Add(new bw(8, 5), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOa(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOB(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOb(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOC(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOc(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOD() }
			});
			val.Add(new bw(8, 14), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOd(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOE(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOe(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOF(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOf(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOG() }
			});
			val.Add(new bw(8, 7), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOg(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOH(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOh(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOI(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOi(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOJ() }
			});
			val.Add(new bw(8, 6), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOj(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOK(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOk(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOL(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOl(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOM() }
			});
			val.Add(new bw(8, 20), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOm(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aON(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOn(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOO(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOo(),
				axx = new string[3]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOP(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOp(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOQ()
				}
			});
			val.Add(new bw(8, 19), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOq(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOR(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOr(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOS(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOs(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOT() }
			});
			val.Add(new bw(8, 9), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOt(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOU(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ans(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOu(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOV(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOv() }
			});
			val.Add(new bw(10, 12), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOW(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOw(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOX(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOx(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOY(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOy() }
			});
			val.Add(new bw(22, 13), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOZ(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOZ(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOz(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoA(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOZ(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOZ() }
			});
			val.Add(new bw(22, 14), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOZ(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOZ(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOz(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoA(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOZ(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOZ() }
			});
			val.Add(new bw(22, 2), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOZ(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOZ(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOz(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoA(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOZ(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aOZ() }
			});
			val.Add(new bw(0, 0), new bX
			{
				axV = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoa(),
				axv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoa(),
				axW = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(),
				axw = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay(),
				axX = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoa(),
				axx = new string[1] { D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoa() }
			});
			axY = val;
		}

		private static bX A(int P_0, int P_1)
		{
			try
			{
				return axY[new bw(P_0, P_1)];
			}
			catch
			{
				return axY[new bw(0, 0)];
			}
		}

		internal static int a(int P_0, int P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			Enumerator<bw, bX> enumerator = axY.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<bw, bX> current = enumerator.Current;
					num++;
					if (current.Key == new bw(P_0, P_1))
					{
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			return num;
		}

		internal static bv A(string P_0)
		{
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			string text = P_0;
			if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agQ()))
			{
				text = P_0.Substring(0, P_0.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.agQ().Length) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny();
			}
			if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoB()))
			{
				text = P_0.Substring(0, P_0.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoB().Length) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny();
			}
			k k = null;
			int axq = -1;
			int axR = -1;
			string text2 = text.ToLower();
			try
			{
				Enumerator<bw, bX> enumerator = axY.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<bw, bX> current = enumerator.Current;
						string text3 = current.Value.axX.ToLower();
						if (text2.Contains(text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax()) || text2.Contains(text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo()) || text2.Contains(text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG()))
						{
							axq = current.Key.axU;
							axR = current.Key.axu;
							k = new k(text2.Substring(0, text2.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny().Length).Substring(text2.IndexOf(text3) + text3.Length + 1), false);
							break;
						}
						if (current.Value.axx == null)
						{
							continue;
						}
						string[] axx = current.Value.axx;
						for (int i = 0; i < axx.Length; i++)
						{
							string text4 = axx[i].ToLower();
							if (text2.Contains(text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax()) || text2.Contains(text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo()) || text2.Contains(text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG()))
							{
								axq = current.Key.axU;
								axR = current.Key.axu;
								k = new k(text2.Substring(0, text2.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny().Length).Substring(text2.IndexOf(text4) + text4.Length + 1), false);
								break;
							}
						}
						if (k != null)
						{
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			catch
			{
				k = null;
			}
			bv result = null;
			if (k != null)
			{
				result = new bv
				{
					axq = axq,
					axR = axR,
					axr = k
				};
			}
			return result;
		}

		internal static string A(int P_0, int P_1, k P_2)
		{
			string text = ((object)P_2).ToString();
			if (text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo()))
			{
				text = text.Replace(':', '-');
			}
			return A(P_0, P_1).axX + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny();
		}

		internal static string a()
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			List<bX> val = new List<bX>();
			Enumerator<bw, bX> enumerator = axY.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					bw current = enumerator.Current;
					if (A(current.axU))
					{
						val.Add(axY[current]);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aob();
			text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SS();
			Enumerator<bX> enumerator2 = val.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					bX current2 = enumerator2.Current;
					text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoC() + current2.axw + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bk();
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoc();
			int num = 0;
			enumerator2 = val.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					bX current3 = enumerator2.Current;
					text = string.Concat(new string[7]
					{
						text,
						current3.axV,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoD(),
						current3.axw,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aod(),
						current3.axw,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bk()
					});
					num++;
					if (num < val.Count)
					{
						text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bN();
					}
				}
				return text;
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}

		internal static string[] B()
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			List<string> val = new List<string>(axY.Count);
			Enumerator<bw, bX> enumerator = axY.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					bX current = enumerator.Current;
					val.Add(current.axw);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			return val.ToArray();
		}

		private static string B(int P_0, int P_1)
		{
			return A(P_0, P_1).axw;
		}

		internal static string a(int P_0, int P_1, k P_2)
		{
			string text = B(P_0, P_1);
			if (text != null)
			{
				string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aoE();
				cE<object> buffer = default(cE<object>);
				cc.a<cE<object>, object>(ref buffer, 0) = P_2.A();
				cc.a<cE<object>, object>(ref buffer, 1) = P_2.a();
				cc.a<cE<object>, object>(ref buffer, 2) = P_2.B();
				cc.a<cE<object>, object>(ref buffer, 3) = (P_2.d() ? string.Empty : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo() + P_2.c().Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(), string.Empty)));
				cc.a<cE<object>, object>(ref buffer, 4) = ((P_2.d() || P_2.C() == 0) ? string.Empty : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bo() + P_2.C()));
				string text3 = string.Format(text2, cc.A<cE<object>, object>(in buffer, 5));
				return text + text3;
			}
			return string.Empty;
		}

		internal static string b(int P_0, int P_1)
		{
			return A(P_0, P_1).axV;
		}

		internal static string C(int P_0, int P_1)
		{
			return A(P_0, P_1).axv;
		}

		internal static Image c(int P_0, int P_1)
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			return (Image)(Bitmap)Cl.bbm.GetObject(A(P_0, P_1).axW, CultureInfo.CurrentCulture);
		}

		internal static bool A(int P_0)
		{
			if (P_0 != 8 && P_0 != 10)
			{
				return P_0 == 9;
			}
			return true;
		}
	}
}
