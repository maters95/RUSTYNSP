using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP;
using NSP.SettingsFramework;
using NSP.UserInterface;

namespace a;

internal class aZ : Form
{
	internal class A
	{
		internal uint Bnr;

		internal bool BnS;

		internal byte[] Bns;

		internal System.DateTime[] BnT;

		internal float Bnt;

		internal uint BnU;
	}

	private enum a
	{
		Bnu,
		BnV,
		Bnv
	}

	private enum B
	{
		BnW,
		Bnw,
		BnX
	}

	private enum b
	{
		Bnx,
		BnY
	}

	private enum C
	{
		Bny,
		BnZ,
		Bnz
	}

	private struct c
	{
		internal C BOA;

		internal bool BOa;
	}

	private delegate void D(object P_0, ElapsedEventArgs P_1);

	private delegate void d(aP P_0, uint P_1, bool P_2);

	private delegate void E(c P_0, DataGridViewWithThemedScrollBars P_1, DataGridViewRow P_2, A P_3);

	private delegate void e(uint P_0, bool P_1);

	private delegate void F(uint P_0, bool P_1);

	private static readonly string Ls = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hp();

	private static int LT = 0;

	private static int Lt = 0;

	private List<ComboBoxItemTextAndValue> LU;

	private List<ComboBoxItemTextAndValue> Lu;

	private List<ComboBoxItemTextAndValue> LV;

	private List<ComboBoxItemTextAndValue> Lv;

	private a LW;

	private B Lw;

	private B LX;

	private c Lx;

	private c LY;

	private b Ly;

	private Dictionary<uint, aP> LZ;

	private Dictionary<uint, aP> Lz;

	private Dictionary<uint, DataGridViewRow> lA;

	private Dictionary<uint, DataGridViewRow> la;

	private Dictionary<uint, DataGridViewRow> lB;

	private Dictionary<uint, DataGridViewRow> lb;

	private Dictionary<uint, uint> lC;

	private Dictionary<uint, uint> lc;

	private Dictionary<uint, uint> lD;

	private Dictionary<uint, uint> ld;

	private TimeSpan lE;

	private Color le;

	private Font lF;

	private int lf;

	private int lG;

	private int lg;

	private int lH;

	private int lh;

	private int lI;

	private int li;

	private int lJ;

	private int lj;

	private int lK;

	private Timer lk;

	private static readonly object lL = new object();

	private bool ll;

	private IContainer lM;

	private ToolStrip lm;

	private SplitContainer lN;

	private SplitContainer ln;

	private TableLayoutPanelWithThemedScrollBars lO;

	private TableLayoutPanelWithThemedScrollBars lo;

	private Label lP;

	private Label lp;

	private TableLayoutPanelWithThemedScrollBars lQ;

	private ThemedButton lq;

	private ThemedButton lR;

	private DataGridViewWithThemedScrollBars lr;

	private DataGridViewWithThemedScrollBars lS;

	private ToolStripLabel ls;

	private ThemedToolStripComboBox lT;

	private ToolStripLabel lt;

	private ThemedToolStripComboBox lU;

	private ToolStripLabel lu;

	private ThemedToolStripComboBox lV;

	private DataGridViewTextBoxColumn lv;

	private DataGridViewTextBoxColumn lW;

	private DataGridViewTextBoxColumn lw;

	private DataGridViewTextBoxColumn lX;

	private DataGridViewTextBoxColumn lx;

	private DataGridViewTextBoxColumn lY;

	private DataGridViewTextBoxColumn ly;

	private DataGridViewTextBoxColumn lZ;

	private DataGridViewTextBoxColumn lz;

	private DataGridViewTextBoxColumn MA;

	private W Ma;

	private ToolStripLabel MB;

	private ThemedToolStripComboBox Mb;

	internal aZ()
	{
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected O, but got Unknown
		List<ComboBoxItemTextAndValue> obj = new List<ComboBoxItemTextAndValue>();
		obj.Add(new ComboBoxItemTextAndValue
		{
			Value = 0,
			DisplayText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HC()
		});
		obj.Add(new ComboBoxItemTextAndValue
		{
			Value = 1,
			DisplayText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hc()
		});
		obj.Add(new ComboBoxItemTextAndValue
		{
			Value = 2,
			DisplayText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HD()
		});
		LU = obj;
		List<ComboBoxItemTextAndValue> obj2 = new List<ComboBoxItemTextAndValue>();
		obj2.Add(new ComboBoxItemTextAndValue
		{
			Value = 0,
			DisplayText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hd()
		});
		obj2.Add(new ComboBoxItemTextAndValue
		{
			Value = 1,
			DisplayText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HE()
		});
		Lu = obj2;
		List<ComboBoxItemTextAndValue> obj3 = new List<ComboBoxItemTextAndValue>();
		obj3.Add(new ComboBoxItemTextAndValue
		{
			Value = 0,
			DisplayText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hd()
		});
		obj3.Add(new ComboBoxItemTextAndValue
		{
			Value = 1,
			DisplayText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HE()
		});
		obj3.Add(new ComboBoxItemTextAndValue
		{
			Value = 2,
			DisplayText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.He()
		});
		LV = obj3;
		List<ComboBoxItemTextAndValue> obj4 = new List<ComboBoxItemTextAndValue>();
		obj4.Add(new ComboBoxItemTextAndValue
		{
			Value = 0,
			DisplayText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HF()
		});
		obj4.Add(new ComboBoxItemTextAndValue
		{
			Value = 1,
			DisplayText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Eb()
		});
		Lv = obj4;
		Lx = new c
		{
			BOA = aZ.C.Bny,
			BOa = true
		};
		LY = new c
		{
			BOA = aZ.C.Bny,
			BOa = true
		};
		Ly = aZ.b.BnY;
		LZ = new Dictionary<uint, aP>();
		Lz = new Dictionary<uint, aP>();
		lA = new Dictionary<uint, DataGridViewRow>();
		la = new Dictionary<uint, DataGridViewRow>();
		lB = new Dictionary<uint, DataGridViewRow>();
		lb = new Dictionary<uint, DataGridViewRow>();
		lC = new Dictionary<uint, uint>();
		lc = new Dictionary<uint, uint>();
		lD = new Dictionary<uint, uint>();
		ld = new Dictionary<uint, uint>();
		lE = TimeSpan.FromMilliseconds(2000L, 0L);
		le = Color.LightGreen;
		lF = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hf(), 10f, (FontStyle)0);
		((Form)this)._002Ector();
		C();
		A();
		BM.G(new EventHandler(A));
		((Component)this).Disposed += (EventHandler)([CompilerGenerated] (object? s, EventArgs P_1) =>
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			BM.g(new EventHandler(A));
		});
		LT = ((Control)this).Width;
		Lt = ((Control)this).Height;
		lf = ((DataGridView)lr).Columns.IndexOf((DataGridViewColumn)(object)lv);
		lG = ((DataGridView)lr).Columns.IndexOf((DataGridViewColumn)(object)lW);
		lg = ((DataGridView)lr).Columns.IndexOf((DataGridViewColumn)(object)lw);
		lH = ((DataGridView)lr).Columns.IndexOf((DataGridViewColumn)(object)lX);
		lh = ((DataGridView)lr).Columns.IndexOf((DataGridViewColumn)(object)lx);
		lI = ((DataGridView)lS).Columns.IndexOf((DataGridViewColumn)(object)lY);
		li = ((DataGridView)lS).Columns.IndexOf((DataGridViewColumn)(object)ly);
		lJ = ((DataGridView)lS).Columns.IndexOf((DataGridViewColumn)(object)lZ);
		lj = ((DataGridView)lS).Columns.IndexOf((DataGridViewColumn)(object)lz);
		lK = ((DataGridView)lS).Columns.IndexOf((DataGridViewColumn)(object)MA);
		typeof(DataGridViewWithThemedScrollBars).InvokeMember(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HG(), (BindingFlags)8228, (Binder)null, (object)lr, new object[1] { true });
		typeof(DataGridViewWithThemedScrollBars).InvokeMember(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HG(), (BindingFlags)8228, (Binder)null, (object)lS, new object[1] { true });
		a();
		((ComboBox)Mb.ComboBox).DataSource = Lv;
		((ListControl)Mb.ComboBox).DisplayMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hg();
		((ListControl)Mb.ComboBox).ValueMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cj();
		Mb.SelectedIndexChanged += new EventHandler(c);
		((ListControl)Mb.ComboBox).SelectedValue = (int)Ly;
		((ComboBox)lT.ComboBox).DataSource = LU;
		((ListControl)lT.ComboBox).DisplayMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hg();
		((ListControl)lT.ComboBox).ValueMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cj();
		lT.SelectedIndexChanged += new EventHandler(B);
		((ListControl)lT.ComboBox).SelectedValue = (int)LW;
		((ComboBox)lU.ComboBox).DataSource = Lu;
		((ListControl)lU.ComboBox).DisplayMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hg();
		((ListControl)lU.ComboBox).ValueMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cj();
		lU.SelectedIndexChanged += new EventHandler(b);
		((ListControl)lU.ComboBox).SelectedValue = (int)Lw;
		((ComboBox)lV.ComboBox).DataSource = LV;
		((ListControl)lV.ComboBox).DisplayMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hg();
		((ListControl)lV.ComboBox).ValueMember = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cj();
		lV.SelectedIndexChanged += new EventHandler(C);
		((ListControl)lV.ComboBox).SelectedValue = (int)LX;
		b();
	}

	private void A(object P_0, EventArgs P_1)
	{
		A();
		lQ.a();
		Ma.a();
		lr.C();
		lS.C();
		lO.a();
		lo.a();
	}

	private void A()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).BackColor = BM.td;
		((Control)this).ForeColor = BM.te;
		lm.BackColor = BM.tE;
		lm.ForeColor = BM.te;
		foreach (ToolStripItem item in (ArrangedElementCollection)lm.Items)
		{
			ToolStripItem val = item;
			if (val is ToolStripLabel)
			{
				val.BackColor = lm.BackColor;
			}
			else if (val is ThemedToolStripComboBox)
			{
				val.BackColor = BM.to;
			}
			val.ForeColor = BM.te;
		}
		((Control)lN).BackColor = ((Control)this).BackColor;
		((Control)lN).ForeColor = BM.te;
		((Control)ln).BackColor = ((Control)this).BackColor;
		((Control)ln).ForeColor = BM.te;
		((Control)lO).BackColor = ((Control)this).BackColor;
		((Control)lO).ForeColor = BM.te;
		((Control)lo).BackColor = ((Control)this).BackColor;
		((Control)lo).ForeColor = BM.te;
		((Control)lQ).BackColor = BM.td;
		((Control)lQ).ForeColor = BM.te;
		((Control)Ma).BackColor = BM.td;
		((Control)Ma).ForeColor = BM.te;
		((Control)lP).BackColor = ((Control)this).BackColor;
		((Control)lP).ForeColor = BM.te;
		((Control)lp).BackColor = ((Control)this).BackColor;
		((Control)lp).ForeColor = BM.te;
		((DataGridView)lr).BackgroundColor = ((Control)this).BackColor;
		((Control)lr).ForeColor = Color.Black;
		((DataGridView)lr).DefaultCellStyle.BackColor = BM.to;
		((DataGridView)lr).DefaultCellStyle.ForeColor = BM.te;
		((DataGridView)lS).BackgroundColor = ((Control)this).BackColor;
		((Control)lS).ForeColor = Color.Black;
		((DataGridView)lS).DefaultCellStyle.BackColor = BM.to;
		((DataGridView)lS).DefaultCellStyle.ForeColor = BM.te;
	}

	private void a()
	{
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!File.Exists(Ls))
			{
				return;
			}
			StreamReader val = File.OpenText(Ls);
			try
			{
				string text;
				while ((text = ((TextReader)val).ReadLine()) != null)
				{
					if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HH()))
					{
						((Control)this).Width = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HH().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hh()))
					{
						((Control)this).Height = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hh().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HI()))
					{
						lN.SplitterDistance = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HI().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hi()))
					{
						Ly = (b)int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hi().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HJ()))
					{
						lE = TimeSpan.FromMilliseconds((long)int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HJ().Length)), 0L);
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hj()))
					{
						LW = (a)int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hj().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HK()))
					{
						Lw = (B)int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HK().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hk()))
					{
						LX = (B)int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hk().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HL()))
					{
						Lx.BOA = (C)int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HL().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hl()))
					{
						Lx.BOa = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hl().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HM()))
					{
						LY.BOA = (C)int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HM().Length));
					}
					else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hm()))
					{
						LY.BOa = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hm().Length));
					}
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HN() + ex.Message, true);
		}
	}

	private void B()
	{
		try
		{
			if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
			{
				Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
			}
			((Stream)File.Create(Ls)).Close();
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HH() + LT);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hh() + Lt);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HI() + lN.SplitterDistance);
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hi();
			int num = (int)Ly;
			val.Add(text + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HJ() + (int)((TimeSpan)(ref lE)).TotalMilliseconds);
			string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hj();
			num = (int)LW;
			val.Add(text2 + num);
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HK();
			num = (int)Lw;
			val.Add(text3 + num);
			string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hk();
			num = (int)LX;
			val.Add(text4 + num);
			string text5 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HL();
			num = (int)Lx.BOA;
			val.Add(text5 + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hl() + Lx.BOa);
			string text6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HM();
			num = (int)LY.BOA;
			val.Add(text6 + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hm() + LY.BOa);
			File.AppendAllLines(Ls, (System.Collections.Generic.IEnumerable<string>)val);
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hn() + ex.Message, true);
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).WindowState != 1)
		{
			LT = ((Control)this).Width;
			Lt = ((Control)this).Height;
		}
	}

	private void A(object P_0, FormClosingEventArgs P_1)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		BM.Qz.A(20069)?.a(0, true);
		B();
		try
		{
			if (lk != null)
			{
				lk.Stop();
				lk.Elapsed -= new ElapsedEventHandler(A);
				((Component)lk).Dispose();
				lk = null;
			}
			((Control)Ma).SuspendLayout();
			Enumerator<uint, aP> enumerator = LZ.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					aP current = enumerator.Current;
					((CheckBox)current).CheckedChanged -= new EventHandler(D);
					((Component)current).Dispose();
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = Lz.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					aP current2 = enumerator.Current;
					((CheckBox)current2).CheckedChanged -= new EventHandler(D);
					((Component)current2).Dispose();
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			((Control)Ma).ResumeLayout(true);
			LZ.Clear();
			Lz.Clear();
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HO() + ex.Message, true);
		}
	}

	private void A(Setting P_0, Setting P_1)
	{
		if (LW == aZ.a.BnV)
		{
			P_1.a(0, true);
		}
		else if (LW == aZ.a.Bnu)
		{
			P_1.a(1, true);
		}
		else if (LW == aZ.a.Bnv)
		{
			P_1.a(4, true);
		}
		P_0.a(2, true);
	}

	private void B(object P_0, EventArgs P_1)
	{
		b();
	}

	private void b()
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		if (((ListControl)lT.ComboBox).SelectedValue is ComboBoxItemTextAndValue)
		{
			LW = (a)((ComboBoxItemTextAndValue)((ListControl)lT.ComboBox).SelectedValue).Value;
		}
		else
		{
			if (!(((ListControl)lT.ComboBox).SelectedValue is int))
			{
				return;
			}
			LW = (a)((ListControl)lT.ComboBox).SelectedValue;
		}
		Setting setting = BM.Qz.A(20069);
		Setting setting2 = BM.Qz.A(20070);
		if (setting == null || setting2 == null)
		{
			return;
		}
		Monitor.Enter(lL);
		if (lk != null)
		{
			lk.Elapsed -= new ElapsedEventHandler(A);
			lk.Stop();
			lk.Enabled = false;
		}
		setting.a(0, true);
		Thread.Sleep(50);
		A(setting, setting2);
		Thread.Sleep(50);
		((Control)Ma).SuspendLayout();
		Enumerator<uint, aP> enumerator = LZ.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				aP current = enumerator.Current;
				((CheckBox)current).CheckedChanged -= new EventHandler(D);
				((Component)current).Dispose();
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = Lz.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				aP current2 = enumerator.Current;
				((CheckBox)current2).CheckedChanged -= new EventHandler(D);
				((Component)current2).Dispose();
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		((Control)Ma).ResumeLayout(true);
		LZ.Clear();
		Lz.Clear();
		lC.Clear();
		lc.Clear();
		lD.Clear();
		ld.Clear();
		lA.Clear();
		la.Clear();
		lB.Clear();
		lb.Clear();
		((DataGridView)lr).Rows.Clear();
		((DataGridView)lS).Rows.Clear();
		((Control)lr).Refresh();
		((Control)lS).Refresh();
		Monitor.Exit(lL);
		if (lk == null)
		{
			lk = new Timer(60.0);
		}
		lk.Elapsed += new ElapsedEventHandler(A);
		lk.AutoReset = false;
		lk.Enabled = true;
		lk.Start();
	}

	private void A(object P_0, ElapsedEventArgs P_1)
	{
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		if (((Control)this).InvokeRequired)
		{
			try
			{
				D d = A;
				((Control)this).Invoke((System.Delegate)d, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		bool flag = false;
		try
		{
			Monitor.TryEnter(lL, ref flag);
			if (!flag)
			{
				return;
			}
			if (lk != null)
			{
				lk.Stop();
				lk.Enabled = false;
			}
			global::A.F f = global::A.A.e(BM.Qz.aXc);
			if (f == null || BM.g())
			{
				return;
			}
			Setting setting = BM.Qz.A(20069);
			Setting setting2 = BM.Qz.A(20070);
			if (setting != null && setting2 != null && setting.ax() != 2)
			{
				A(setting, setting2);
			}
			uint bF = f.@as[34].BF;
			if (global::A.A.A(BM.Qz.aXc, global::A.f.ax, 0u, bF, out var array, out var _))
			{
				((Control)Ma).SuspendLayout();
				bool flag3 = false;
				for (uint num = 0u; num < bF; num += 16)
				{
					bool flag4 = true;
					if (array[num] == 0 || array[num] == 255)
					{
						for (int i = 1; (long)i < 16L; i++)
						{
							if (array[num + i] != array[num])
							{
								flag4 = false;
								break;
							}
						}
					}
					else
					{
						flag4 = false;
					}
					if (flag4)
					{
						continue;
					}
					uint num2 = (uint)(array[num + 3] << 24) | ((uint)(array[num + 2] << 16) & 0xFF0000u) | ((uint)(array[num + 1] << 8) & 0xFF00u) | (array[num] & 0xFFu);
					byte num3 = array[num + 4];
					bool flag5 = (num3 & 0x80) == 0;
					bool flag6 = (num3 & 0x40) == 0;
					byte b = (byte)(num3 & 0xFu);
					uint num4 = ((uint)(array[num + 7] << 16) & 0xFF0000u) | ((uint)(array[num + 6] << 8) & 0xFF00u) | (array[num + 5] & 0xFFu);
					byte[] array2 = new byte[b];
					System.Array.Copy((System.Array)array, (long)(num + 8), (System.Array)array2, 0L, (long)b);
					DataGridViewRow val = null;
					A a = null;
					if (((!flag6) ? (flag5 ? lB : lb) : (flag5 ? lA : la)).TryGetValue(num2, ref val))
					{
						a = ((DataGridViewBand)val).Tag as A;
						a.BnS = flag5;
					}
					else
					{
						val = null;
					}
					if (val == null)
					{
						a = new A();
						a.Bnr = num2;
						a.BnS = flag5;
						val = new DataGridViewRow();
						((DataGridViewBand)val).Tag = a;
						if (flag6)
						{
							A(Lx, lr, val, a);
							if (flag5)
							{
								lA[num2] = val;
							}
							else
							{
								la[num2] = val;
							}
						}
						else
						{
							A(LY, lS, val, a);
							if (flag5)
							{
								lB[num2] = val;
							}
							else
							{
								lb[num2] = val;
							}
						}
						flag3 = true;
						if ((flag5 && !LZ.ContainsKey(num2)) || (!flag5 && !Lz.ContainsKey(num2)))
						{
							aP aP2 = new aP();
							((Control)aP2).Tag = (flag5 ? num2 : (num2 | 0x80000000u));
							((Control)aP2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ho() + A(num2, flag5);
							if (Lw == aZ.B.Bnw)
							{
								((Control)aP2).Text = ((Control)aP2).Text + (flag5 ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hp() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HP());
							}
							((Control)aP2).AutoSize = true;
							((CheckBox)aP2).Checked = true;
							((CheckBox)aP2).CheckedChanged += new EventHandler(D);
							if (flag5)
							{
								LZ[num2] = aP2;
							}
							else
							{
								Lz[num2] = aP2;
							}
							A(aP2, num2, flag5);
						}
					}
					Dictionary<uint, uint> val2 = ((!flag6) ? (flag5 ? lD : ld) : (flag5 ? lC : lc));
					bool flag7;
					if (val2.ContainsKey(num2))
					{
						uint num5 = (num4 - val2[num2]) & 0xFFFFFFu;
						flag7 = num5 != 0 && num5 < 8388608;
						if (flag7)
						{
							a.Bnt = (float)num5 / 1000f;
						}
					}
					else
					{
						flag7 = true;
					}
					if (!flag7)
					{
						continue;
					}
					a.BnU++;
					System.DateTime now = System.DateTime.Now;
					if (a.BnT == null || a.Bns == null || a.Bns.Length != array2.Length)
					{
						a.BnT = new System.DateTime[array2.Length];
					}
					if (a.Bns == null)
					{
						a.Bns = array2;
					}
					else if (a.Bns.Length != array2.Length)
					{
						a.Bns = array2;
						for (int j = 0; j < array2.Length; j++)
						{
							a.BnT[j] = now;
						}
					}
					else
					{
						for (int k = 0; k < array2.Length; k++)
						{
							if (a.Bns[k] != array2[k])
							{
								a.Bns[k] = array2[k];
								a.BnT[k] = now;
							}
						}
					}
					val2[num2] = num4;
				}
				((Control)Ma).ResumeLayout(true);
				Enumerator<uint, DataGridViewRow> enumerator = lA.Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						uint current = enumerator.Current;
						this.a(current, true);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				enumerator = la.Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						uint current2 = enumerator.Current;
						this.a(current2, false);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				enumerator = lB.Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						uint current3 = enumerator.Current;
						B(current3, true);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				enumerator = lb.Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						uint current4 = enumerator.Current;
						B(current4, false);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				if (flag3)
				{
					lr.C();
					lS.C();
				}
			}
			else
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HQ(), true);
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hq() + ex.Message, true);
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(lL);
				if (lk != null)
				{
					lk.Enabled = true;
					lk.Start();
				}
			}
		}
	}

	private void A(aP P_0, uint P_1, bool P_2)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				d d = A;
				((Control)this).BeginInvoke((System.Delegate)d, new object[3] { P_0, P_1, P_2 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (((ArrangedElementCollection)((Control)Ma).Controls).Count == 0)
		{
			((Control)Ma).Controls.Add((Control)(object)P_0);
			return;
		}
		for (int i = 0; i < ((ArrangedElementCollection)((Control)Ma).Controls).Count; i++)
		{
			uint num = (uint)((Control)Ma).Controls[i].Tag & 0x7FFFFFFFu;
			if (P_1 < num || (P_1 == num && P_2))
			{
				((Control)Ma).Controls.Add((Control)(object)P_0);
				((Control)Ma).Controls.SetChildIndex((Control)(object)P_0, i);
				break;
			}
			if (i == ((ArrangedElementCollection)((Control)Ma).Controls).Count - 1)
			{
				((Control)Ma).Controls.Add((Control)(object)P_0);
				break;
			}
		}
	}

	private void A(c P_0, DataGridViewWithThemedScrollBars P_1, DataGridViewRow P_2, A P_3)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				E e = A;
				((Control)this).Invoke((System.Delegate)e, new object[4] { P_0, P_1, P_2, P_3 });
				return;
			}
			catch
			{
				return;
			}
		}
		if (((DataGridView)P_1).Rows.Count == 0)
		{
			((DataGridView)P_1).Rows.Add(P_2);
			return;
		}
		if (P_0.BOa)
		{
			for (int i = 0; i < ((DataGridView)P_1).Rows.Count; i++)
			{
				if (A(P_0, P_3, ((DataGridViewBand)((DataGridView)P_1).Rows[i]).Tag as A))
				{
					((DataGridView)P_1).Rows.Insert(i, P_2);
					break;
				}
				if (i == ((DataGridView)P_1).Rows.Count - 1)
				{
					((DataGridView)P_1).Rows.Add(P_2);
					break;
				}
			}
			return;
		}
		for (int num = ((DataGridView)P_1).Rows.Count - 1; num >= 0; num--)
		{
			if (A(P_0, P_3, ((DataGridViewBand)((DataGridView)P_1).Rows[num]).Tag as A))
			{
				if (num == ((DataGridView)P_1).Rows.Count - 1)
				{
					((DataGridView)P_1).Rows.Add(P_2);
				}
				else
				{
					((DataGridView)P_1).Rows.Insert(num + 1, P_2);
				}
				break;
			}
			if (num == 0)
			{
				((DataGridView)P_1).Rows.Insert(0, P_2);
			}
		}
	}

	private string A(uint P_0, bool P_1)
	{
		if (Lw == aZ.B.BnW)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI() + P_0.ToString(P_1 ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dh() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dH());
		}
		return P_0.ToString();
	}

	private string A(bool P_0)
	{
		if (!P_0)
		{
			return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HR();
		}
		return D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hr();
	}

	private string A(byte[] P_0)
	{
		string text = string.Empty;
		if (P_0 != null)
		{
			for (int i = 0; i < P_0.Length; i++)
			{
				if (LX == aZ.B.Bnw)
				{
					if (P_0[i] < 10)
					{
						text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GU();
					}
					else if (P_0[i] < 100)
					{
						text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
					}
					text += P_0[i];
				}
				else if (LX == aZ.B.BnW)
				{
					text += P_0[i].ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZ());
				}
				else if (LX == aZ.B.BnX)
				{
					System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(text);
					char c = (char)P_0[i];
					text = string.Concat(readOnlySpan, new System.ReadOnlySpan<char>(ref c));
				}
				if (i != P_0.Length - 1 && LX != aZ.B.BnX)
				{
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
				}
			}
		}
		return text;
	}

	private string A(float P_0)
	{
		if (P_0 != 0f)
		{
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HS() + (1000f / P_0).ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hs()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HT();
			return P_0.ToString((P_0 < 0.1f) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ht() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hs()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HU() + text;
		}
		return string.Empty;
	}

	private void a(uint P_0, bool P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				e e = this.a;
				((Control)this).BeginInvoke((System.Delegate)e, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if ((!P_1 || lA.ContainsKey(P_0)) && (P_1 || la.ContainsKey(P_0)))
		{
			DataGridViewRow val = (P_1 ? lA[P_0] : la[P_0]);
			if (((DataGridViewBand)val).Index >= 0)
			{
				A a = ((DataGridViewBand)val).Tag as A;
				val.Cells[lf].Value = A(a.Bnr, a.BnS);
				val.Cells[lG].Value = A(a.BnS);
				val.Cells[lg].Value = A(a.Bns);
				val.Cells[lg].Style.Font = lF;
				val.Cells[lH].Value = A(a.Bnt);
				val.Cells[lh].Value = a.BnU.ToString();
				((DataGridView)lr).InvalidateRow(((DataGridViewBand)val).Index);
			}
		}
	}

	private void B(uint P_0, bool P_1)
	{
		if (((Control)this).InvokeRequired)
		{
			try
			{
				F f = B;
				((Control)this).BeginInvoke((System.Delegate)f, new object[2] { P_0, P_1 });
				return;
			}
			catch
			{
				return;
			}
		}
		if ((!P_1 || lB.ContainsKey(P_0)) && (P_1 || lb.ContainsKey(P_0)))
		{
			DataGridViewRow val = (P_1 ? lB[P_0] : lb[P_0]);
			if (((DataGridViewBand)val).Index >= 0)
			{
				A a = ((DataGridViewBand)val).Tag as A;
				val.Cells[lI].Value = A(a.Bnr, a.BnS);
				val.Cells[li].Value = A(a.BnS);
				val.Cells[lJ].Value = A(a.Bns);
				val.Cells[lJ].Style.Font = lF;
				val.Cells[lj].Value = A(a.Bnt);
				val.Cells[lK].Value = a.BnU.ToString();
				((DataGridView)lS).InvalidateRow(((DataGridViewBand)val).Index);
			}
		}
	}

	private void A(object P_0, DataGridViewCellValueEventArgs P_1)
	{
		if (P_1.RowIndex >= 0)
		{
			A a = ((DataGridViewBand)((DataGridView)lr).Rows[P_1.RowIndex]).Tag as A;
			if (P_1.ColumnIndex == lf)
			{
				P_1.Value = A(a.Bnr, a.BnS);
			}
			else if (P_1.ColumnIndex == lG)
			{
				P_1.Value = A(a.BnS);
			}
			else if (P_1.ColumnIndex == lg)
			{
				P_1.Value = A(a.Bns);
			}
			else if (P_1.ColumnIndex == lH)
			{
				P_1.Value = A(a.Bnt);
			}
			else if (P_1.ColumnIndex == lh)
			{
				P_1.Value = a.BnU.ToString();
			}
		}
	}

	private void a(object P_0, DataGridViewCellValueEventArgs P_1)
	{
		if (P_1.RowIndex >= 0)
		{
			A a = ((DataGridViewBand)((DataGridView)lS).Rows[P_1.RowIndex]).Tag as A;
			if (P_1.ColumnIndex == lI)
			{
				P_1.Value = A(a.Bnr, a.BnS);
			}
			else if (P_1.ColumnIndex == li)
			{
				P_1.Value = A(a.BnS);
			}
			else if (P_1.ColumnIndex == lJ)
			{
				P_1.Value = A(a.Bns);
			}
			else if (P_1.ColumnIndex == lj)
			{
				P_1.Value = A(a.Bnt);
			}
			else if (P_1.ColumnIndex == lK)
			{
				P_1.Value = a.BnU.ToString();
			}
		}
	}

	private void A(object P_0, DataGridViewCellPaintingEventArgs P_1)
	{
		if (P_1.ColumnIndex == lg && P_1.RowIndex >= 0)
		{
			A(((DataGridView)lr).Rows[P_1.RowIndex], lg, P_1);
			((HandledEventArgs)P_1).Handled = true;
		}
		else if (P_1.RowIndex == -1 && A(P_1, Lx, lf, lh, lH))
		{
			((HandledEventArgs)P_1).Handled = true;
		}
	}

	private void a(object P_0, DataGridViewCellPaintingEventArgs P_1)
	{
		if (P_1.ColumnIndex == lJ && P_1.RowIndex >= 0)
		{
			A(((DataGridView)lS).Rows[P_1.RowIndex], lJ, P_1);
			((HandledEventArgs)P_1).Handled = true;
		}
		else if (P_1.RowIndex == -1 && A(P_1, LY, lI, lK, lj))
		{
			((HandledEventArgs)P_1).Handled = true;
		}
	}

	private bool A(DataGridViewCellPaintingEventArgs P_0, c P_1, int P_2, int P_3, int P_4)
	{
		bool result = false;
		if ((P_0.ColumnIndex == P_2 && P_1.BOA == aZ.C.Bny) || (P_0.ColumnIndex == P_3 && P_1.BOA == aZ.C.BnZ) || (P_0.ColumnIndex == P_4 && P_1.BOA == aZ.C.Bnz))
		{
			bool flag = !P_1.BOa;
			A(P_0, flag);
			result = true;
		}
		return result;
	}

	private void A(DataGridViewCellPaintingEventArgs P_0, bool P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		P_0.PaintBackground(P_0.CellBounds, true);
		P_0.PaintContent(P_0.CellBounds);
		P_0.Graphics.SmoothingMode = (SmoothingMode)2;
		Rectangle cellBounds = P_0.CellBounds;
		int left = ((Rectangle)(ref cellBounds)).Left;
		cellBounds = P_0.CellBounds;
		int num = (left + ((Rectangle)(ref cellBounds)).Right) / 2;
		int num2 = num - 5;
		int num3 = num + 5;
		cellBounds = P_0.CellBounds;
		int num4 = ((Rectangle)(ref cellBounds)).Top + 1;
		cellBounds = P_0.CellBounds;
		int num5 = ((Rectangle)(ref cellBounds)).Top + 6;
		Pen val = new Pen(Brushes.Black, 2f);
		try
		{
			if (P_1)
			{
				P_0.Graphics.DrawLine(val, num, num5, num2, num4);
				P_0.Graphics.DrawLine(val, num - 1, num5, num3 - 1, num4);
			}
			else
			{
				P_0.Graphics.DrawLine(val, num, num4, num2, num5);
				P_0.Graphics.DrawLine(val, num - 1, num4, num3 - 1, num5);
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private void A(DataGridViewRow P_0, int P_1, DataGridViewCellPaintingEventArgs P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		P_2.PaintBackground(P_2.CellBounds, true);
		A a = ((DataGridViewBand)P_0).Tag as A;
		DataGridViewCell val = P_0.Cells[P_1];
		if (a.Bns == null)
		{
			return;
		}
		Size val2 = TextRenderer.MeasureText(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(), lF, new Size(0, 0), (TextFormatFlags)268437504);
		int width = ((Size)(ref val2)).Width;
		Rectangle cellBounds = P_2.CellBounds;
		int num = ((Rectangle)(ref cellBounds)).Left + 6;
		Point val3 = default(Point);
		for (int i = 0; i < a.Bns.Length; i++)
		{
			byte b = a.Bns[i];
			string text = string.Empty;
			if (LX == aZ.B.Bnw)
			{
				if (b < 10)
				{
					text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GU();
				}
				else if (b < 100)
				{
					text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
				}
				text += b;
			}
			else if (LX == aZ.B.BnW)
			{
				text = b.ToString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aZ());
			}
			else if (LX == aZ.B.BnX)
			{
				char c = (char)b;
				text = c.ToString();
			}
			int num2 = num;
			cellBounds = P_2.CellBounds;
			int top = ((Rectangle)(ref cellBounds)).Top;
			cellBounds = P_2.CellBounds;
			((Point)(ref val3))._002Ector(num2, top + ((Rectangle)(ref cellBounds)).Height / 2);
			Color transparent;
			Color val4;
			if (Ly == aZ.b.BnY && a.BnT != null && a.BnT.Length == a.Bns.Length && System.DateTime.Now - a.BnT[i] < lE)
			{
				transparent = le;
				val4 = Color.Black;
			}
			else
			{
				transparent = Color.Transparent;
				val4 = (val.Selected ? Color.White : BM.te);
			}
			TextRenderer.DrawText((IDeviceContext)(object)P_2.Graphics, text, lF, val3, val4, transparent, (TextFormatFlags)268437508);
			int num3 = num;
			val2 = TextRenderer.MeasureText(text, lF, new Size(0, 0), (TextFormatFlags)268437504);
			num = num3 + ((Size)(ref val2)).Width;
			if (i != a.Bns.Length - 1 && LX != aZ.B.BnX)
			{
				((Point)(ref val3)).X = num;
				TextRenderer.DrawText((IDeviceContext)(object)P_2.Graphics, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG(), lF, val3, val4, Color.Transparent, (TextFormatFlags)268437508);
				num += width;
			}
		}
	}

	private void b(object P_0, EventArgs P_1)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		if (((ListControl)lU.ComboBox).SelectedValue is ComboBoxItemTextAndValue)
		{
			Lw = (B)((ComboBoxItemTextAndValue)((ListControl)lU.ComboBox).SelectedValue).Value;
		}
		else
		{
			if (!(((ListControl)lU.ComboBox).SelectedValue is int))
			{
				return;
			}
			Lw = (B)((ListControl)lU.ComboBox).SelectedValue;
		}
		((Control)lr).Refresh();
		((Control)lS).Refresh();
		Enumerator<uint, aP> enumerator = LZ.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				aP current = enumerator.Current;
				uint num = (uint)((Control)current).Tag & 0x7FFFFFFFu;
				((Control)current).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ho() + A(num, true);
				if (Lw == aZ.B.Bnw)
				{
					((Control)current).Text = ((Control)current).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hp();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = Lz.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				aP current2 = enumerator.Current;
				uint num2 = (uint)((Control)current2).Tag & 0x7FFFFFFFu;
				((Control)current2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ho() + A(num2, false);
				if (Lw == aZ.B.Bnw)
				{
					((Control)current2).Text = ((Control)current2).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HP();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void C(object P_0, EventArgs P_1)
	{
		if (((ListControl)lV.ComboBox).SelectedValue is ComboBoxItemTextAndValue)
		{
			LX = (B)((ComboBoxItemTextAndValue)((ListControl)lV.ComboBox).SelectedValue).Value;
		}
		else
		{
			if (!(((ListControl)lV.ComboBox).SelectedValue is int))
			{
				return;
			}
			LX = (B)((ListControl)lV.ComboBox).SelectedValue;
		}
		((Control)lr).Refresh();
		((Control)lS).Refresh();
		if (LX == aZ.B.Bnw)
		{
			((DataGridViewColumn)lw).Width = 262;
			((DataGridViewColumn)lZ).Width = 262;
		}
		else
		{
			((DataGridViewColumn)lw).Width = 200;
			((DataGridViewColumn)lZ).Width = 200;
		}
	}

	private void c(object P_0, EventArgs P_1)
	{
		if (((ListControl)Mb.ComboBox).SelectedValue is ComboBoxItemTextAndValue)
		{
			Ly = (b)((ComboBoxItemTextAndValue)((ListControl)Mb.ComboBox).SelectedValue).Value;
		}
		else
		{
			if (!(((ListControl)Mb.ComboBox).SelectedValue is int))
			{
				return;
			}
			Ly = (b)((ListControl)Mb.ComboBox).SelectedValue;
		}
		((Control)lr).Refresh();
		((Control)lS).Refresh();
	}

	private bool A(c P_0, int P_1, int P_2, int P_3, int P_4, out c P_5)
	{
		P_5 = P_0;
		if (P_1 == P_2)
		{
			if (P_0.BOA == aZ.C.Bny)
			{
				P_5.BOa = !P_0.BOa;
			}
			else
			{
				P_5 = new c
				{
					BOA = aZ.C.Bny,
					BOa = true
				};
			}
			return true;
		}
		if (P_1 == P_3)
		{
			if (P_0.BOA == aZ.C.BnZ)
			{
				P_5.BOa = !P_0.BOa;
			}
			else
			{
				P_5 = new c
				{
					BOA = aZ.C.BnZ,
					BOa = false
				};
			}
			return true;
		}
		if (P_1 == P_4)
		{
			if (P_0.BOA == aZ.C.Bnz)
			{
				P_5.BOa = !P_0.BOa;
			}
			else
			{
				P_5 = new c
				{
					BOA = aZ.C.Bnz,
					BOa = true
				};
			}
			return true;
		}
		return false;
	}

	private void A(object P_0, DataGridViewCellMouseEventArgs P_1)
	{
		if (A(Lx, P_1.ColumnIndex, lf, lh, lH, out var c))
		{
			Lx = c;
			A(Lx, lr, lA, la);
		}
	}

	private void a(object P_0, DataGridViewCellMouseEventArgs P_1)
	{
		if (A(LY, P_1.ColumnIndex, lI, lK, lj, out var c))
		{
			LY = c;
			A(LY, lS, lB, lb);
		}
	}

	private void A(c P_0, DataGridViewWithThemedScrollBars P_1, Dictionary<uint, DataGridViewRow> P_2, Dictionary<uint, DataGridViewRow> P_3)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		uint num = 4294967295u;
		bool flag = true;
		int num2 = -1;
		if (((BaseCollection)((DataGridView)P_1).SelectedCells).Count != 0)
		{
			A obj = ((DataGridViewBand)((DataGridView)P_1).SelectedCells[0].OwningRow).Tag as A;
			num = obj.Bnr;
			flag = obj.BnS;
			num2 = ((DataGridView)P_1).SelectedCells[0].ColumnIndex;
		}
		((Control)P_1).SuspendLayout();
		((DataGridView)P_1).Rows.Clear();
		Enumerator<uint, DataGridViewRow> enumerator = P_2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<uint, DataGridViewRow> current = enumerator.Current;
				_ = current.Key;
				DataGridViewRow value = current.Value;
				A a = ((DataGridViewBand)value).Tag as A;
				A(P_0, P_1, value, a);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = P_3.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<uint, DataGridViewRow> current2 = enumerator.Current;
				_ = current2.Key;
				DataGridViewRow value2 = current2.Value;
				A a2 = ((DataGridViewBand)value2).Tag as A;
				A(P_0, P_1, value2, a2);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		((Control)P_1).ResumeLayout(true);
		((Control)P_1).Refresh();
		if (num == 4294967295u || num2 == -1)
		{
			return;
		}
		foreach (DataGridViewCell item in (BaseCollection)((DataGridView)P_1).SelectedCells)
		{
			item.Selected = false;
		}
		if (flag)
		{
			if (P_2.ContainsKey(num))
			{
				P_2[num].Cells[num2].Selected = true;
			}
		}
		else if (P_3.ContainsKey(num))
		{
			P_3[num].Cells[num2].Selected = true;
		}
	}

	private void D(object P_0, EventArgs P_1)
	{
		aP aP2 = P_0 as aP;
		bool num = ((uint)((Control)aP2).Tag & 0x80000000u) == 0;
		uint num2 = (uint)((Control)aP2).Tag & 0x7FFFFFFFu;
		if (num)
		{
			if (lA.ContainsKey(num2))
			{
				int num3 = ((DataGridView)lr).Rows.IndexOf(lA[num2]);
				if (num3 != -1)
				{
					((DataGridViewBand)((DataGridView)lr).Rows[num3]).Visible = ((CheckBox)aP2).Checked;
				}
			}
		}
		else if (la.ContainsKey(num2))
		{
			int num4 = ((DataGridView)lr).Rows.IndexOf(la[num2]);
			if (num4 != -1)
			{
				((DataGridViewBand)((DataGridView)lr).Rows[num4]).Visible = ((CheckBox)aP2).Checked;
			}
		}
		if (num)
		{
			if (lB.ContainsKey(num2))
			{
				int num5 = ((DataGridView)lS).Rows.IndexOf(lB[num2]);
				if (num5 != -1)
				{
					((DataGridViewBand)((DataGridView)lS).Rows[num5]).Visible = ((CheckBox)aP2).Checked;
				}
			}
		}
		else if (lb.ContainsKey(num2))
		{
			int num6 = ((DataGridView)lS).Rows.IndexOf(lb[num2]);
			if (num6 != -1)
			{
				((DataGridViewBand)((DataGridView)lS).Rows[num6]).Visible = ((CheckBox)aP2).Checked;
			}
		}
		if (!ll)
		{
			lr.C();
			lS.C();
			((Control)lr).Refresh();
			((Control)lS).Refresh();
		}
	}

	private void d(object P_0, EventArgs P_1)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		ll = true;
		Enumerator<uint, aP> enumerator = LZ.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				((CheckBox)enumerator.Current).Checked = true;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = Lz.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				((CheckBox)enumerator.Current).Checked = true;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		ll = false;
		lr.C();
		lS.C();
		((Control)lr).Refresh();
		((Control)lS).Refresh();
	}

	private void E(object P_0, EventArgs P_1)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		ll = true;
		Enumerator<uint, aP> enumerator = LZ.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				((CheckBox)enumerator.Current).Checked = false;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = Lz.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				((CheckBox)enumerator.Current).Checked = false;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		ll = false;
		lr.C();
		lS.C();
		((Control)lr).Refresh();
		((Control)lS).Refresh();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && lM != null)
		{
			((System.IDisposable)lM).Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void C()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
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
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected O, but got Unknown
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected O, but got Unknown
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected O, but got Unknown
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Expected O, but got Unknown
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Expected O, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a39: Expected O, but got Unknown
		//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Expected O, but got Unknown
		//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected O, but got Unknown
		//IL_0ab9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c47: Expected O, but got Unknown
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Expected O, but got Unknown
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c75: Expected O, but got Unknown
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e09: Expected O, but got Unknown
		//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8f: Expected O, but got Unknown
		//IL_0ea1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eab: Expected O, but got Unknown
		//IL_0ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f07: Expected O, but got Unknown
		//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1064: Unknown result type (might be due to invalid IL or missing references)
		//IL_1093: Unknown result type (might be due to invalid IL or missing references)
		//IL_109d: Expected O, but got Unknown
		//IL_10aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b4: Expected O, but got Unknown
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cb: Expected O, but got Unknown
		//IL_1237: Unknown result type (might be due to invalid IL or missing references)
		//IL_1253: Unknown result type (might be due to invalid IL or missing references)
		//IL_128d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1297: Expected O, but got Unknown
		//IL_12c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cd: Expected O, but got Unknown
		//IL_12d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12df: Expected O, but got Unknown
		lm = new ToolStrip();
		ls = new ToolStripLabel();
		lT = new ThemedToolStripComboBox();
		lt = new ToolStripLabel();
		lU = new ThemedToolStripComboBox();
		lu = new ToolStripLabel();
		lV = new ThemedToolStripComboBox();
		MB = new ToolStripLabel();
		Mb = new ThemedToolStripComboBox();
		lN = new SplitContainer();
		lQ = new TableLayoutPanelWithThemedScrollBars();
		lq = new ThemedButton();
		lR = new ThemedButton();
		Ma = new W();
		ln = new SplitContainer();
		lO = new TableLayoutPanelWithThemedScrollBars();
		lP = new Label();
		lr = new DataGridViewWithThemedScrollBars();
		lv = new DataGridViewTextBoxColumn();
		lW = new DataGridViewTextBoxColumn();
		lw = new DataGridViewTextBoxColumn();
		lX = new DataGridViewTextBoxColumn();
		lx = new DataGridViewTextBoxColumn();
		lo = new TableLayoutPanelWithThemedScrollBars();
		lp = new Label();
		lS = new DataGridViewWithThemedScrollBars();
		lY = new DataGridViewTextBoxColumn();
		ly = new DataGridViewTextBoxColumn();
		lZ = new DataGridViewTextBoxColumn();
		lz = new DataGridViewTextBoxColumn();
		MA = new DataGridViewTextBoxColumn();
		((Control)lm).SuspendLayout();
		((ISupportInitialize)lN).BeginInit();
		((Control)lN.Panel1).SuspendLayout();
		((Control)lN.Panel2).SuspendLayout();
		((Control)lN).SuspendLayout();
		((Control)lQ).SuspendLayout();
		((ISupportInitialize)ln).BeginInit();
		((Control)ln.Panel1).SuspendLayout();
		((Control)ln.Panel2).SuspendLayout();
		((Control)ln).SuspendLayout();
		((Control)lO).SuspendLayout();
		((ISupportInitialize)lr).BeginInit();
		((Control)lo).SuspendLayout();
		((ISupportInitialize)lS).BeginInit();
		((Control)this).SuspendLayout();
		lm.AllowMerge = false;
		((Control)lm).AutoSize = false;
		lm.Items.AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)ls,
			(ToolStripItem)lT,
			(ToolStripItem)lt,
			(ToolStripItem)lU,
			(ToolStripItem)lu,
			(ToolStripItem)lV,
			(ToolStripItem)MB,
			(ToolStripItem)Mb
		});
		((Control)lm).Location = new Point(0, 0);
		((Control)lm).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hu();
		((Control)lm).Size = new Size(928, 33);
		((Control)lm).TabIndex = 0;
		((Control)lm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hu();
		((ToolStripItem)ls).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HV();
		((ToolStripItem)ls).Padding = new Padding(5, 0, 0, 0);
		((ToolStripItem)ls).Size = new Size(37, 22);
		((ToolStripItem)ls).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hv();
		((ToolStripItem)ls).TextAlign = (ContentAlignment)64;
		((ToolStripItem)lT).AutoSize = false;
		lT.DropDownStyle = (ComboBoxStyle)2;
		lT.DropDownWidth = 100;
		lT.MaxDropDownItems = 3;
		((ToolStripItem)lT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HW();
		lT.SelectedIndex = -1;
		((ToolStripItem)lT).Size = new Size(100, 23);
		((ToolStripItem)lt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hw();
		((ToolStripItem)lt).Padding = new Padding(20, 0, 0, 0);
		((ToolStripItem)lt).Size = new Size(154, 22);
		((ToolStripItem)lt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HX();
		((ToolStripItem)lt).TextAlign = (ContentAlignment)64;
		((ToolStripItem)lU).AutoSize = false;
		lU.DropDownStyle = (ComboBoxStyle)2;
		((ToolStripItem)lU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hx();
		lU.SelectedIndex = -1;
		((ToolStripItem)lU).Size = new Size(121, 23);
		((ToolStripItem)lu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HY();
		((ToolStripItem)lu).Padding = new Padding(20, 0, 0, 0);
		((ToolStripItem)lu).Size = new Size(139, 22);
		((ToolStripItem)lu).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hy();
		((ToolStripItem)lu).TextAlign = (ContentAlignment)64;
		((ToolStripItem)lV).AutoSize = false;
		lV.DropDownStyle = (ComboBoxStyle)2;
		((ToolStripItem)lV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HZ();
		lV.SelectedIndex = -1;
		((ToolStripItem)lV).Size = new Size(121, 23);
		((ToolStripItem)MB).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hz();
		((ToolStripItem)MB).Padding = new Padding(20, 0, 0, 0);
		((ToolStripItem)MB).Size = new Size(132, 22);
		((ToolStripItem)MB).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hA();
		((ToolStripItem)MB).TextAlign = (ContentAlignment)64;
		((ToolStripItem)Mb).AutoSize = false;
		Mb.DropDownStyle = (ComboBoxStyle)2;
		((ToolStripItem)Mb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ha();
		Mb.SelectedIndex = -1;
		((ToolStripItem)Mb).Size = new Size(100, 23);
		lN.Dock = (DockStyle)5;
		((Control)lN).Location = new Point(0, 25);
		((Control)lN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hB();
		((Control)lN.Panel1).Controls.Add((Control)(object)lQ);
		((Control)lN.Panel2).Controls.Add((Control)(object)ln);
		((Control)lN).Size = new Size(928, 617);
		lN.SplitterDistance = 160;
		((Control)lN).TabIndex = 1;
		((TableLayoutPanel)lQ).ColumnCount = 1;
		((TableLayoutPanel)lQ).ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		((TableLayoutPanel)lQ).Controls.Add((Control)(object)lq, 0, 0);
		((TableLayoutPanel)lQ).Controls.Add((Control)(object)lR, 0, 1);
		((TableLayoutPanel)lQ).Controls.Add((Control)(object)Ma, 0, 2);
		((Control)lQ).Dock = (DockStyle)5;
		((Control)lQ).Location = new Point(0, 0);
		((Control)lQ).Margin = new Padding(0);
		((Control)lQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hb();
		((TableLayoutPanel)lQ).RowCount = 3;
		((TableLayoutPanel)lQ).RowStyles.Add(new RowStyle((SizeType)1, 25f));
		((TableLayoutPanel)lQ).RowStyles.Add(new RowStyle((SizeType)1, 25f));
		((TableLayoutPanel)lQ).RowStyles.Add(new RowStyle((SizeType)2, 100f));
		((Control)lQ).Size = new Size(160, 617);
		((Control)lQ).TabIndex = 0;
		((Control)lq).Location = new Point(0, 0);
		((Control)lq).Margin = new Padding(0);
		((Control)lq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hC();
		((Control)lq).Size = new Size(160, 25);
		((Control)lq).TabIndex = 0;
		((Control)lq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hc();
		((ButtonBase)lq).UseVisualStyleBackColor = true;
		((Control)lq).Click += new EventHandler(d);
		((Control)lR).Location = new Point(0, 25);
		((Control)lR).Margin = new Padding(0);
		((Control)lR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hD();
		((Control)lR).Size = new Size(160, 25);
		((Control)lR).TabIndex = 1;
		((Control)lR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hd();
		((ButtonBase)lR).UseVisualStyleBackColor = true;
		((Control)lR).Click += new EventHandler(E);
		((ScrollableControl)Ma).AutoScroll = true;
		((Control)Ma).Dock = (DockStyle)5;
		((FlowLayoutPanel)Ma).FlowDirection = (FlowDirection)1;
		((Control)Ma).Location = new Point(0, 50);
		((Control)Ma).Margin = new Padding(0);
		((Control)Ma).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hE();
		((Control)Ma).Size = new Size(160, 567);
		((Control)Ma).TabIndex = 2;
		((FlowLayoutPanel)Ma).WrapContents = false;
		ln.Dock = (DockStyle)5;
		((Control)ln).Location = new Point(0, 0);
		((Control)ln).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.he();
		ln.Orientation = (Orientation)0;
		((Control)ln.Panel1).Controls.Add((Control)(object)lO);
		((Control)ln.Panel2).Controls.Add((Control)(object)lo);
		((Control)ln).Size = new Size(780, 617);
		ln.SplitterDistance = 308;
		((Control)ln).TabIndex = 0;
		((TableLayoutPanel)lO).CellBorderStyle = (TableLayoutPanelCellBorderStyle)1;
		((TableLayoutPanel)lO).ColumnCount = 1;
		((TableLayoutPanel)lO).ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		((TableLayoutPanel)lO).Controls.Add((Control)(object)lP, 0, 0);
		((TableLayoutPanel)lO).Controls.Add((Control)(object)lr, 0, 1);
		((Control)lO).Dock = (DockStyle)5;
		((Control)lO).Location = new Point(0, 0);
		((Control)lO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hF();
		((TableLayoutPanel)lO).RowCount = 2;
		((TableLayoutPanel)lO).RowStyles.Add(new RowStyle((SizeType)1, 20f));
		((TableLayoutPanel)lO).RowStyles.Add(new RowStyle((SizeType)2, 100f));
		((Control)lO).Size = new Size(780, 308);
		((Control)lO).TabIndex = 0;
		((Control)lP).AutoSize = true;
		((Control)lP).Dock = (DockStyle)5;
		((Control)lP).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lP).Location = new Point(4, 1);
		((Control)lP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hf();
		((Control)lP).Size = new Size(772, 20);
		((Control)lP).TabIndex = 0;
		((Control)lP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dw();
		lP.TextAlign = (ContentAlignment)16;
		((DataGridView)lr).AllowUserToAddRows = false;
		((DataGridView)lr).AllowUserToDeleteRows = false;
		((DataGridView)lr).AllowUserToResizeRows = false;
		((DataGridView)lr).ColumnHeadersHeight = 24;
		((DataGridView)lr).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)1;
		((DataGridView)lr).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)lv,
			(DataGridViewColumn)lW,
			(DataGridViewColumn)lw,
			(DataGridViewColumn)lX,
			(DataGridViewColumn)lx
		});
		((Control)lr).Dock = (DockStyle)5;
		((Control)lr).Location = new Point(4, 25);
		((Control)lr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hG();
		((DataGridView)lr).RowHeadersVisible = false;
		((DataGridView)lr).SelectionMode = (DataGridViewSelectionMode)0;
		((DataGridView)lr).ShowCellErrors = false;
		((DataGridView)lr).ShowEditingIcon = false;
		((DataGridView)lr).ShowRowErrors = false;
		((Control)lr).Size = new Size(772, 279);
		((Control)lr).TabIndex = 1;
		((DataGridView)lr).VirtualMode = true;
		((DataGridView)lr).CellPainting += new DataGridViewCellPaintingEventHandler(A);
		((DataGridView)lr).CellValueNeeded += new DataGridViewCellValueEventHandler(A);
		((DataGridView)lr).ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(A);
		((DataGridViewColumn)lv).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ef();
		((DataGridViewColumn)lv).MinimumWidth = 40;
		((DataGridViewColumn)lv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hg();
		((DataGridViewBand)lv).ReadOnly = true;
		((DataGridViewColumn)lv).Width = 90;
		((DataGridViewColumn)lW).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EE();
		((DataGridViewColumn)lW).MinimumWidth = 80;
		((DataGridViewColumn)lW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hH();
		((DataGridViewBand)lW).ReadOnly = true;
		((DataGridViewColumn)lW).Width = 110;
		((DataGridViewColumn)lw).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hh();
		((DataGridViewColumn)lw).MinimumWidth = 100;
		((DataGridViewColumn)lw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hI();
		((DataGridViewBand)lw).ReadOnly = true;
		((DataGridViewColumn)lw).Width = 200;
		((DataGridViewColumn)lX).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hi();
		((DataGridViewColumn)lX).MinimumWidth = 60;
		((DataGridViewColumn)lX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hJ();
		((DataGridViewBand)lX).ReadOnly = true;
		((DataGridViewColumn)lX).Width = 110;
		((DataGridViewColumn)lx).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hj();
		((DataGridViewColumn)lx).MinimumWidth = 50;
		((DataGridViewColumn)lx).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hK();
		((DataGridViewBand)lx).ReadOnly = true;
		((DataGridViewColumn)lx).Width = 80;
		((TableLayoutPanel)lo).CellBorderStyle = (TableLayoutPanelCellBorderStyle)1;
		((TableLayoutPanel)lo).ColumnCount = 1;
		((TableLayoutPanel)lo).ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		((TableLayoutPanel)lo).Controls.Add((Control)(object)lp, 0, 0);
		((TableLayoutPanel)lo).Controls.Add((Control)(object)lS, 0, 1);
		((Control)lo).Dock = (DockStyle)5;
		((Control)lo).Location = new Point(0, 0);
		((Control)lo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hk();
		((TableLayoutPanel)lo).RowCount = 2;
		((TableLayoutPanel)lo).RowStyles.Add(new RowStyle((SizeType)1, 20f));
		((TableLayoutPanel)lo).RowStyles.Add(new RowStyle((SizeType)2, 100f));
		((Control)lo).Size = new Size(780, 305);
		((Control)lo).TabIndex = 0;
		((Control)lp).AutoSize = true;
		((Control)lp).Dock = (DockStyle)5;
		((Control)lp).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lp).Location = new Point(4, 1);
		((Control)lp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hL();
		((Control)lp).Size = new Size(772, 20);
		((Control)lp).TabIndex = 0;
		((Control)lp).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dz();
		lp.TextAlign = (ContentAlignment)16;
		((DataGridView)lS).AllowUserToAddRows = false;
		((DataGridView)lS).AllowUserToDeleteRows = false;
		((DataGridView)lS).AllowUserToResizeRows = false;
		((DataGridView)lS).ColumnHeadersHeight = 24;
		((DataGridView)lS).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)1;
		((DataGridView)lS).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)lY,
			(DataGridViewColumn)ly,
			(DataGridViewColumn)lZ,
			(DataGridViewColumn)lz,
			(DataGridViewColumn)MA
		});
		((Control)lS).Dock = (DockStyle)5;
		((Control)lS).Location = new Point(4, 25);
		((Control)lS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hl();
		((DataGridView)lS).RowHeadersVisible = false;
		((DataGridView)lS).SelectionMode = (DataGridViewSelectionMode)0;
		((DataGridView)lS).ShowCellErrors = false;
		((DataGridView)lS).ShowEditingIcon = false;
		((DataGridView)lS).ShowRowErrors = false;
		((Control)lS).Size = new Size(772, 276);
		((Control)lS).TabIndex = 1;
		((DataGridView)lS).VirtualMode = true;
		((DataGridView)lS).CellPainting += new DataGridViewCellPaintingEventHandler(a);
		((DataGridView)lS).CellValueNeeded += new DataGridViewCellValueEventHandler(a);
		((DataGridView)lS).ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(a);
		((DataGridViewColumn)lY).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ef();
		((DataGridViewColumn)lY).MinimumWidth = 40;
		((DataGridViewColumn)lY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hM();
		((DataGridViewBand)lY).ReadOnly = true;
		((DataGridViewColumn)lY).Width = 90;
		((DataGridViewColumn)ly).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EE();
		((DataGridViewColumn)ly).MinimumWidth = 80;
		((DataGridViewColumn)ly).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hm();
		((DataGridViewBand)ly).ReadOnly = true;
		((DataGridViewColumn)ly).Width = 110;
		((DataGridViewColumn)lZ).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hh();
		((DataGridViewColumn)lZ).MinimumWidth = 100;
		((DataGridViewColumn)lZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hN();
		((DataGridViewBand)lZ).ReadOnly = true;
		((DataGridViewColumn)lZ).Width = 200;
		((DataGridViewColumn)lz).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hi();
		((DataGridViewColumn)lz).MinimumWidth = 60;
		((DataGridViewColumn)lz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hn();
		((DataGridViewBand)lz).ReadOnly = true;
		((DataGridViewColumn)lz).Width = 110;
		((DataGridViewColumn)MA).HeaderText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hj();
		((DataGridViewColumn)MA).MinimumWidth = 50;
		((DataGridViewColumn)MA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hO();
		((DataGridViewBand)MA).ReadOnly = true;
		((DataGridViewColumn)MA).Width = 80;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(928, 642);
		((Control)this).Controls.Add((Control)(object)lN);
		((Control)this).Controls.Add((Control)(object)lm);
		((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ho();
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)0;
		((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hP();
		((Form)this).FormClosing += new FormClosingEventHandler(A);
		((Control)this).Resize += new EventHandler(a);
		((Control)lm).ResumeLayout(false);
		((Control)lm).PerformLayout();
		((Control)lN.Panel1).ResumeLayout(false);
		((Control)lN.Panel2).ResumeLayout(false);
		((ISupportInitialize)lN).EndInit();
		((Control)lN).ResumeLayout(false);
		((Control)lQ).ResumeLayout(false);
		((Control)ln.Panel1).ResumeLayout(false);
		((Control)ln.Panel2).ResumeLayout(false);
		((ISupportInitialize)ln).EndInit();
		((Control)ln).ResumeLayout(false);
		((Control)lO).ResumeLayout(false);
		((Control)lO).PerformLayout();
		((ISupportInitialize)lr).EndInit();
		((Control)lo).ResumeLayout(false);
		((Control)lo).PerformLayout();
		((ISupportInitialize)lS).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[CompilerGenerated]
	private void e(object? s, EventArgs P_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		BM.g(new EventHandler(A));
	}

	[CompilerGenerated]
	internal static bool A(c P_0, A P_1, A P_2)
	{
		if (P_0.BOA == aZ.C.Bny)
		{
			if (P_1.Bnr >= P_2.Bnr)
			{
				if (P_1.Bnr == P_2.Bnr)
				{
					return P_1.BnS;
				}
				return false;
			}
			return true;
		}
		if (P_0.BOA == aZ.C.BnZ)
		{
			return P_1.BnU < P_2.BnU;
		}
		if (P_0.BOA == aZ.C.Bnz)
		{
			return P_1.Bnt < P_2.Bnt;
		}
		return false;
	}
}
internal enum az
{
	Mj,
	MK,
	Mk
}
