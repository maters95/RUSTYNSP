using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using B;
using C;
using D;
using NSP.Resources;
using NSP.SettingsFramework;
using a;
using b;
using c;

namespace NSP.UserInterface;

public class GenericCANConfigControl : UserControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A BkO = new A();

		public static Func<CANFrameModel, bool> Bko;

		public static Func<Setting.ListItems.A, string> BkP;

		public static Func<Setting.ListItems.A, string> Bkp;

		public static Func<Setting.ListItems.A, string> BkQ;

		public static Func<Setting.ListItems.A, ValueAndDisplay> Bkq;

		public static Func<Setting.ListItems.A, ValueAndDisplay> BkR;

		public static Func<CANFrameModel, bool> Bkr;

		public static Func<CANFrameModel, bool> BkS;

		internal bool A(CANFrameModel P_0)
		{
			return P_0.Index == ee;
		}

		internal string A(Setting.ListItems.A P_0)
		{
			return P_0.bBV;
		}

		internal string a(Setting.ListItems.A P_0)
		{
			return P_0.bBV;
		}

		internal string B(Setting.ListItems.A P_0)
		{
			return P_0.bBV;
		}

		internal ValueAndDisplay b(Setting.ListItems.A P_0)
		{
			return new ValueAndDisplay
			{
				Value = P_0.bBv,
				Display = P_0.bBV
			};
		}

		internal ValueAndDisplay C(Setting.ListItems.A P_0)
		{
			return new ValueAndDisplay
			{
				Value = P_0.bBv,
				Display = P_0.bBV
			};
		}

		internal bool a(CANFrameModel P_0)
		{
			return P_0.FrameDirection == CANFrameModel.Direction.Receive;
		}

		internal bool B(CANFrameModel P_0)
		{
			return P_0.FrameDirection == CANFrameModel.Direction.Transmit;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public CANFrameModel Bks;

		internal bool A(CANFrameModel P_0)
		{
			if (P_0 != Bks)
			{
				return P_0.Name == Bks.Name;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public uint BkT;

		internal bool A(CANFrameModel P_0)
		{
			return P_0.Index == BkT;
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public uint Bkt;

		internal bool A(CANFrameModel P_0)
		{
			return P_0.Index == Bkt;
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public uint BkU;

		internal bool A(CANFrameModel P_0)
		{
			return P_0.Index == BkU;
		}
	}

	[CompilerGenerated]
	private sealed class c
	{
		public int Bku;

		internal bool A(CANFrameModel P_0)
		{
			return P_0.Index == Bku;
		}

		internal bool a(CANFrameModel P_0)
		{
			return P_0.Index == Bku;
		}
	}

	[CompilerGenerated]
	private sealed class D
	{
		public int BkV;

		internal bool A(CANFrameModel P_0)
		{
			return P_0.Index == BkV;
		}
	}

	[CompilerGenerated]
	private sealed class d
	{
		public List<CANSignalModel> Bkv;

		internal bool A(CANSignalModel P_0)
		{
			E CS_0024_003C_003E8__locals0 = new E
			{
				BkW = P_0
			};
			return !Enumerable.Any<CANSignalModel>((System.Collections.Generic.IEnumerable<CANSignalModel>)Bkv, (Func<CANSignalModel, bool>)((CANSignalModel P_0) => P_0.Index == CS_0024_003C_003E8__locals0.BkW.Index));
		}
	}

	[CompilerGenerated]
	private sealed class E
	{
		public CANSignalModel BkW;

		internal bool A(CANSignalModel P_0)
		{
			return P_0.Index == BkW.Index;
		}
	}

	private const int eb = 12;

	private const int eC = 10;

	private const int ec = 20;

	private const string eD = "            ";

	private List<CANFrameModel> ed = new List<CANFrameModel>();

	private CANFrameModel eE;

	private static int ee = -1;

	private static int eF = 0;

	private static int ef = 0;

	private Timer eG;

	private int eg;

	private bool eH;

	private bool eh;

	private bool eI;

	private Framework ei;

	private DN eJ;

	private bool ej = true;

	private bool eK;

	private int ek;

	private int eL;

	private int el;

	private int eM;

	private int em;

	private int eN;

	private int en;

	private int eO;

	private int eo;

	private int eP;

	private int ep;

	private int eQ;

	private int eq;

	private bool eR;

	private IContainer er;

	private ak eS;

	private ak es;

	private TableLayoutPanel eT;

	private Label et;

	private ThemedButton eU;

	private TableLayoutPanel eu;

	private Label eV;

	private ThemedButton ev;

	private TreeViewWithThemedScrollBars eW;

	private TreeViewWithThemedScrollBars ew;

	private aP eX;

	private Label ex;

	private ThemedTextBox eY;

	private PictureBox ey;

	private Label eZ;

	private ThemedComboBox ez;

	private Label FA;

	private ThemedTextBox Fa;

	private PictureBox FB;

	private Label Fb;

	private ThemedComboBox FC;

	private Label Fc;

	private ThemedComboBox FD;

	private CANRawDataView Fd;

	private CANSignalEditor FE;

	private Label Fe;

	private ThemedBitfieldViewer FF;

	private Label Ff;

	internal GenericCANConfigControl(Framework P_0, DN P_1, string P_2 = null)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		if (P_0 == null)
		{
			return;
		}
		ei = P_0;
		eJ = P_1;
		eg = DN.A(P_2);
		m();
		((Control)this).MinimumSize = new Size(0, ((Control)FE).Top + 120 + 150);
		((TextBoxBase)eY).MaxLength = eJ.BZk.av()[1];
		a();
		A(false, null, true);
		f();
		eG = new Timer
		{
			Interval = 100
		};
		if (ee != -1)
		{
			CANFrameModel cANFrameModel = Enumerable.FirstOrDefault<CANFrameModel>((System.Collections.Generic.IEnumerable<CANFrameModel>)ed, (Func<CANFrameModel, bool>)((CANFrameModel P_0) => P_0.Index == ee));
			a(cANFrameModel);
		}
		B();
	}

	protected override void OnLoad(EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((UserControl)this).OnLoad(e);
		((Control)this).BeginInvoke((Action)([CompilerGenerated] () =>
		{
			if (eF != 0)
			{
				((SplitContainer)eS).SplitterDistance = eF;
			}
			if (ef != 0)
			{
				((SplitContainer)es).SplitterDistance = ef;
			}
			ej = false;
			((ScrollableControl)eW).AutoScroll = true;
			((ScrollableControl)ew).AutoScroll = true;
			eW.H();
			ew.H();
		}));
	}

	private void A(CANFrameModel P_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 == null)
		{
			A();
			return;
		}
		A(true, P_0, false);
		((CheckBox)eX).CheckState = (CheckState)(P_0.Enabled ? 1 : 0);
		((Control)eY).BackColor = BM.to;
		((Control)eY).Text = P_0.Name;
		((ListControl)ez).SelectedIndex = ((!P_0.StdFrame) ? 1 : 0);
		string text = (P_0.StdFrame ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dh() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dH());
		((Control)Fa).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI() + P_0.CANId.ToString(text);
		((ListControl)FC).SelectedIndex = (int)P_0.Length;
		((ListControl)FD).SelectedIndex = P_0.Rate;
		ez.A();
		FC.A();
		FD.A();
		((Control)eX).ForeColor = (((Control)eX).Enabled ? BM.te : BM.tq);
		((Control)ex).ForeColor = (((Control)eY).Enabled ? BM.te : BM.tq);
		((Control)eZ).ForeColor = (((Control)ez).Enabled ? BM.te : BM.tq);
		((Control)FA).ForeColor = (((Control)Fa).Enabled ? BM.te : BM.tq);
		((Control)Fb).ForeColor = (((Control)FC).Enabled ? BM.te : BM.tq);
		((Control)Fc).ForeColor = (((Control)FD).Enabled ? BM.te : BM.tq);
	}

	private void A()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Control)eY).BackColor = BM.to;
		((Control)eY).Text = string.Empty;
		((Control)Fa).Text = string.Empty;
		A(false, null, false);
	}

	private void A(bool P_0, CANFrameModel P_1, bool P_2 = false)
	{
		((Control)eX).Enabled = P_0;
		((Control)eY).Enabled = P_0;
		((Control)ez).Enabled = P_0;
		((Control)Fa).Enabled = P_0;
		((Control)FC).Enabled = P_0;
		((Control)FD).Enabled = P_0 && P_1.FrameDirection == CANFrameModel.Direction.Transmit;
		A(P_0, P_1);
		A((Control)(object)eX, (Control)(object)eX, ((Control)eX).Enabled, P_2);
		A((Control)(object)eY, (Control)(object)ex, ((Control)eY).Enabled, P_2);
		A((ComboBox)(object)ez, (Control)(object)eZ, ((Control)ez).Enabled);
		A((Control)(object)Fa, (Control)(object)FA, ((Control)Fa).Enabled, P_2);
		A((ComboBox)(object)FC, (Control)(object)Fb, ((Control)FC).Enabled);
		A((ComboBox)(object)FD, (Control)(object)Fc, ((Control)FD).Enabled);
	}

	private void A(bool P_0, CANFrameModel P_1)
	{
		if (P_1 != null)
		{
			bool enable = P_0 && P_1.Enabled && (P_1.FrameDirection == CANFrameModel.Direction.Receive || (P_1.Signals != null && P_1.Signals.Count > 0));
			Fd.EnableOrDisable(enable, P_1.Length);
		}
		else
		{
			Fd.EnableOrDisable(enable: false);
		}
	}

	private void A(Control P_0, Control P_1, bool P_2, bool P_3 = false)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (P_3)
		{
			P_0.BackColor = BM.to;
			P_0.ForeColor = BM.te;
		}
		P_0.Enabled = P_2;
		P_1.ForeColor = (P_2 ? BM.te : BM.tq);
	}

	private void A(ComboBox P_0, Control P_1, bool P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		((Control)P_0).ForeColor = BM.te;
		((Control)P_0).BackColor = BM.to;
		P_0.DropDownStyle = (ComboBoxStyle)2;
		((Control)P_0).Enabled = P_2;
		P_1.ForeColor = (P_2 ? BM.te : BM.tq);
	}

	private void A(TreeViewWithThemedScrollBars P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((Control)P_0).ForeColor = BM.te;
		((Control)P_0).BackColor = BM.tg;
	}

	private void a()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		ey.Image = (Image)(object)GeneralResources.RedError;
		((Control)ey).Visible = false;
		FB.Image = (Image)(object)GeneralResources.RedError;
		((Control)FB).Visible = false;
		((Control)this).BackColor = BM.tg;
		((Control)Fe).ForeColor = BM.te;
		((Control)Ff).ForeColor = BM.te;
		((Control)et).ForeColor = BM.tf;
		((Control)et).Font = new Font(((Control)et).Font.FontFamily, ((Control)et).Font.Size, (FontStyle)1);
		((Control)eV).ForeColor = BM.tf;
		((Control)eV).Font = ((Control)et).Font;
		A(eW);
		A(ew);
		A((Control)(object)eY, (Control)(object)ex, false);
		A((Control)(object)Fa, (Control)(object)FA, false);
		A((ComboBox)(object)ez, (Control)(object)eZ, false);
		A((ComboBox)(object)FC, (Control)(object)Fb, false);
		A((ComboBox)(object)FD, (Control)(object)Fc, false);
		((Control)eX).ForeColor = BM.tq;
		((Control)eX).Enabled = false;
	}

	private void B()
	{
		C();
		c();
	}

	private void b()
	{
		D();
		d();
	}

	private void C()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		((SplitContainer)eS).SplitterMoved += new SplitterEventHandler(A);
		((SplitContainer)es).SplitterMoved += new SplitterEventHandler(a);
		eW.A(new TreeViewEventHandler(A));
		((Control)eW).KeyDown += new KeyEventHandler(A);
		eW.A(new DrawTreeNodeEventHandler(A));
		((Control)eW).SizeChanged += new EventHandler(F);
		ew.A(new TreeViewEventHandler(a));
		((Control)ew).KeyDown += new KeyEventHandler(a);
		ew.A(new DrawTreeNodeEventHandler(a));
		((Control)ew).SizeChanged += new EventHandler(f);
		((Control)eY).LostFocus += new EventHandler(g);
		((Control)eY).KeyDown += new KeyEventHandler(B);
		((Control)Fa).LostFocus += new EventHandler(H);
		((Control)Fa).KeyDown += new KeyEventHandler(b);
		((ComboBox)ez).SelectionChangeCommitted += new EventHandler(h);
		((ComboBox)FC).SelectionChangeCommitted += new EventHandler(I);
		((ComboBox)FD).SelectionChangeCommitted += new EventHandler(i);
		((CheckBox)eX).CheckStateChanged += new EventHandler(J);
		FE.SignalsChanged += A;
		FE.SignalSelectionChanged += new EventHandler(d);
		FF.SelectedSignalBitsChanged += new EventHandler(e);
		FF.SignalSelectionChanged += new EventHandler(E);
		((Control)ey).Click += new EventHandler(A);
		((Control)FB).Click += new EventHandler(a);
		eG.Tick += new EventHandler(G);
		((Control)((SplitContainer)eS).Panel2).MouseDown += new MouseEventHandler(A);
		((Control)FF).MouseDown += new MouseEventHandler(A);
		((Control)eW).MouseDown += new MouseEventHandler(A);
		((Control)ew).MouseDown += new MouseEventHandler(A);
		((Control)FE).MouseDown += new MouseEventHandler(A);
		((Control)Fe).MouseDown += new MouseEventHandler(A);
		((Control)((SplitContainer)eS).Panel2).MouseMove += new MouseEventHandler(a);
		((Control)FF).MouseMove += new MouseEventHandler(a);
		((Control)eW).MouseMove += new MouseEventHandler(a);
		((Control)ew).MouseMove += new MouseEventHandler(a);
		((Control)FE).MouseMove += new MouseEventHandler(a);
		((Control)Fe).MouseMove += new MouseEventHandler(a);
		((Control)((SplitContainer)eS).Panel2).MouseUp += new MouseEventHandler(B);
		((Control)eW).MouseUp += new MouseEventHandler(B);
		((Control)ew).MouseUp += new MouseEventHandler(B);
	}

	private void c()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		((SettingOrSpecialObject)eJ.BZk).A(new EventHandler(k));
		((SettingOrSpecialObject)eJ.BZL).A(new EventHandler(l));
		eJ.BZL.A(new EventHandler(L));
		eJ.BZk.A(new EventHandler(K));
		eJ.BZl.A(new EventHandler(j));
		eJ.BZM.A(new EventHandler(M));
		eJ.BZm.A(new EventHandler(N));
		eJ.BZN.A(new EventHandler(N));
		eJ.BZn.A(new EventHandler(N));
		eJ.BZO.A(new EventHandler(N));
		eJ.BZo.A(new EventHandler(N));
		eJ.BZP.A(new EventHandler(N));
		eJ.BZp.A(new EventHandler(N));
		eJ.BZQ.A(new EventHandler(N));
		eJ.BZq.A(new EventHandler(N));
		eJ.BZR.A(new EventHandler(N));
		eJ.BZr.A(new EventHandler(N));
		((SettingOrSpecialObject)eJ.BZr).A(new EventHandler(m));
	}

	private void D()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		((SplitContainer)eS).SplitterMoved -= new SplitterEventHandler(A);
		((SplitContainer)es).SplitterMoved -= new SplitterEventHandler(a);
		eW.a(new TreeViewEventHandler(A));
		((Control)eW).KeyDown -= new KeyEventHandler(A);
		eW.a(new DrawTreeNodeEventHandler(A));
		((Control)eW).SizeChanged -= new EventHandler(F);
		ew.a(new TreeViewEventHandler(a));
		((Control)ew).KeyDown -= new KeyEventHandler(a);
		ew.a(new DrawTreeNodeEventHandler(a));
		((Control)ew).SizeChanged -= new EventHandler(f);
		((Control)eY).LostFocus -= new EventHandler(g);
		((Control)eY).KeyDown -= new KeyEventHandler(B);
		((Control)Fa).LostFocus -= new EventHandler(H);
		((Control)Fa).KeyDown -= new KeyEventHandler(b);
		((ComboBox)ez).SelectionChangeCommitted -= new EventHandler(h);
		((ComboBox)FC).SelectionChangeCommitted -= new EventHandler(I);
		((ComboBox)FD).SelectionChangeCommitted -= new EventHandler(i);
		((CheckBox)eX).CheckStateChanged -= new EventHandler(J);
		FE.SignalsChanged -= A;
		FE.SignalSelectionChanged -= new EventHandler(d);
		FF.SelectedSignalBitsChanged -= new EventHandler(e);
		FF.SignalSelectionChanged -= new EventHandler(E);
		((Control)ey).Click -= new EventHandler(A);
		((Control)FB).Click -= new EventHandler(a);
		eG.Stop();
		eG.Tick -= new EventHandler(G);
		((Control)((SplitContainer)eS).Panel2).MouseDown -= new MouseEventHandler(A);
		((Control)FF).MouseDown -= new MouseEventHandler(A);
		((Control)eW).MouseDown -= new MouseEventHandler(A);
		((Control)ew).MouseDown -= new MouseEventHandler(A);
		((Control)FE).MouseDown -= new MouseEventHandler(A);
		((Control)Fe).MouseDown -= new MouseEventHandler(A);
		((Control)((SplitContainer)eS).Panel2).MouseMove -= new MouseEventHandler(a);
		((Control)FF).MouseMove -= new MouseEventHandler(a);
		((Control)eW).MouseMove -= new MouseEventHandler(a);
		((Control)ew).MouseMove -= new MouseEventHandler(a);
		((Control)FE).MouseMove -= new MouseEventHandler(a);
		((Control)Fe).MouseMove -= new MouseEventHandler(a);
		((Control)((SplitContainer)eS).Panel2).MouseUp -= new MouseEventHandler(B);
		((Control)eW).MouseUp -= new MouseEventHandler(B);
		((Control)ew).MouseUp -= new MouseEventHandler(B);
	}

	private void d()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		((SettingOrSpecialObject)eJ.BZk).a(new EventHandler(k));
		((SettingOrSpecialObject)eJ.BZL).a(new EventHandler(l));
		eJ.BZL.a(new EventHandler(L));
		eJ.BZk.a(new EventHandler(K));
		eJ.BZl.a(new EventHandler(j));
		eJ.BZM.a(new EventHandler(M));
		eJ.BZm.a(new EventHandler(N));
		eJ.BZN.a(new EventHandler(N));
		eJ.BZn.a(new EventHandler(N));
		eJ.BZO.a(new EventHandler(N));
		eJ.BZo.a(new EventHandler(N));
		eJ.BZP.a(new EventHandler(N));
		eJ.BZp.a(new EventHandler(N));
		eJ.BZQ.a(new EventHandler(N));
		eJ.BZq.a(new EventHandler(N));
		eJ.BZR.a(new EventHandler(N));
		eJ.BZr.a(new EventHandler(N));
		((SettingOrSpecialObject)eJ.BZr).a(new EventHandler(m));
	}

	private void E()
	{
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		int width = ((SplitContainer)eS).Panel2.Width;
		int height = ((SplitContainer)eS).Panel2.Height;
		if (!eK)
		{
			eL = ((Control)eZ).Left;
			el = ((Control)ez).Left;
			eM = ((Control)FA).Left;
			em = ((Control)Fa).Left;
			eN = ((Control)FB).Left;
			en = ((Control)Fb).Left;
			eO = ((Control)FC).Left;
			eo = ((Control)Fc).Left;
			eP = ((Control)FD).Left;
			ek = ((Control)FD).Right;
			ep = ((Control)Ff).Top;
			eQ = ((Control)Fd).Top;
			eq = ((Control)FE).Top;
			eK = true;
		}
		if (width >= ek)
		{
			((Control)eZ).Location = new Point(eL, ((Control)ex).Top);
			((Control)ez).Location = new Point(el, ((Control)eY).Top);
			((Control)FA).Location = new Point(eM, ((Control)ex).Top);
			((Control)Fa).Location = new Point(em, ((Control)eY).Top);
			((Control)FB).Location = new Point(eN, ((Control)ey).Top);
			((Control)Fb).Location = new Point(en, ((Control)ex).Top);
			((Control)FC).Location = new Point(eO, ((Control)eY).Top);
			((Control)Fc).Location = new Point(eo, ((Control)ex).Top);
			((Control)FD).Location = new Point(eP, ((Control)eY).Top);
			((Control)Ff).Top = ep;
			((Control)Fd).Top = eQ;
			((Control)FE).Top = eq;
		}
		else
		{
			int num = 4 + ((Control)ex).Top - ((Control)eY).Top;
			int num2 = 4 + ((Control)ey).Top - ((Control)eY).Top;
			int num3 = eL - ((Control)eX).Left;
			((Control)eZ).Location = new Point(((Control)eX).Left, ((Control)eY).Bottom + num);
			((Control)ez).Location = new Point(el - num3, ((Control)eY).Bottom + 4);
			((Control)FA).Location = new Point(eM - num3, ((Control)eY).Bottom + num);
			((Control)Fa).Location = new Point(em - num3, ((Control)eY).Bottom + 4);
			((Control)FB).Location = new Point(eN - num3, ((Control)eY).Bottom + num2);
			((Control)Fb).Location = new Point(en - num3, ((Control)eY).Bottom + num);
			((Control)FC).Location = new Point(eO - num3, ((Control)eY).Bottom + 4);
			((Control)Fc).Location = new Point(eo - num3, ((Control)eY).Bottom + num);
			((Control)FD).Location = new Point(eP - num3, ((Control)eY).Bottom + 4);
			((Control)Ff).Top = ((Control)ez).Bottom;
			((Control)Fd).Top = ((Control)Ff).Top + eQ - ep;
			((Control)FE).Top = ((Control)Fd).Top + eq - eQ;
		}
		int num4 = FE.a();
		if (num4 < height - 225 - ((Control)FE).Top)
		{
			ThemedBitfieldViewer fF = FF;
			int num6 = (((Control)Fe).Width = width - 1);
			((Control)fF).Size = new Size(num6, 225);
			((Control)FE).Size = new Size(Math.Min(FE.A(), width - 1), num4);
			((Control)FF).Top = ((Control)FE).Top + ((Control)FE).Height;
		}
		else
		{
			int num7 = ((((Control)FE).Top + 120 + 225 >= height) ? Math.Max(height - (((Control)FE).Top + 120), 150) : 225);
			ThemedBitfieldViewer fF2 = FF;
			int num6 = (((Control)Fe).Width = width - 1);
			((Control)fF2).Size = new Size(num6, num7);
			((Control)FF).Top = height - ((Control)FF).Height;
			((Control)FE).Size = new Size(Math.Min(FE.A(), width - 1), Math.Max(((Control)FF).Top - ((Control)FE).Top, 120));
		}
		((Control)Fe).Top = (((Control)Fd).Top + ((Control)Fd).Height + ((Control)FF).Top) / 2 - ((Control)Fe).Height / 2;
		((Control)FF).Invalidate();
	}

	private void A(object P_0, SplitterEventArgs P_1)
	{
		E();
		((Control)this).Invalidate();
		if (!ej)
		{
			eF = ((SplitContainer)eS).SplitterDistance;
		}
	}

	private void a(object P_0, SplitterEventArgs P_1)
	{
		E();
		((Control)this).Invalidate();
		if (!ej)
		{
			ef = ((SplitContainer)es).SplitterDistance;
		}
	}

	private ValueTuple<int, int> A(Control P_0, cP P_1, int P_2, int P_3)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		int num = P_2 + P_0.Left;
		int num2 = P_3 + P_0.Top;
		Control val = P_0;
		bool flag = false;
		do
		{
			if (val.Parent != null && val.Parent != P_1)
			{
				val = val.Parent;
				num += val.Left;
				num2 += val.Top;
			}
			else
			{
				flag = true;
			}
		}
		while (!flag);
		return new ValueTuple<int, int>(num, num2);
	}

	private void A(object P_0, MouseEventArgs P_1)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).Parent == null || !(((Control)this).Parent.Parent is cP))
		{
			return;
		}
		cP cP = ((Control)this).Parent.Parent as cP;
		((Control)cP).BringToFront();
		if ((int)P_1.Button != 1048576 || (P_0 != ((SplitContainer)eS).Panel2 && P_0 != eW && P_0 != ew))
		{
			return;
		}
		if (P_0 == eW || P_0 == ew)
		{
			TreeViewWithThemedScrollBars treeViewWithThemedScrollBars = P_0 as TreeViewWithThemedScrollBars;
			Rectangle val;
			TreeNode val2 = treeViewWithThemedScrollBars.A(P_1.X, P_1.Y, out val);
			if (val2 != null)
			{
				if (P_1.X > ((Control)treeViewWithThemedScrollBars).Width - 20 - 12 && P_1.X < ((Control)treeViewWithThemedScrollBars).Width - 20)
				{
					CANFrameModel cANFrameModel = A(val2);
					if (cANFrameModel != null)
					{
						a(cANFrameModel);
						a(treeViewWithThemedScrollBars);
					}
				}
				return;
			}
		}
		FF.ClearSignalSelection();
		ValueTuple<int, int> val3 = A((Control)((P_0 is Control) ? P_0 : null), cP, P_1.X, P_1.Y);
		int item = val3.Item1;
		int item2 = val3.Item2;
		cP.A(P_1.Button, item, item2);
	}

	private void a(object P_0, MouseEventArgs P_1)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 != FF)
		{
			FF.A();
		}
		if (((Control)this).Parent != null && ((Control)this).Parent.Parent is cP)
		{
			cP cP = ((Control)this).Parent.Parent as cP;
			ValueTuple<int, int> val = A((Control)((P_0 is Control) ? P_0 : null), cP, P_1.X, P_1.Y);
			int item = val.Item1;
			int item2 = val.Item2;
			cP.A(item, item2);
		}
	}

	private void B(object P_0, MouseEventArgs P_1)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		if (((Control)this).Parent != null && ((Control)this).Parent.Parent is cP)
		{
			cP cP = ((Control)this).Parent.Parent as cP;
			ValueTuple<int, int> val = A((Control)((P_0 is Control) ? P_0 : null), cP, P_1.X, P_1.Y);
			int item = val.Item1;
			int item2 = val.Item2;
			cP.a(item, item2);
			if ((int)P_1.Button == 2097152 && (P_0 == eW || P_0 == ew))
			{
				A(P_0 as TreeViewWithThemedScrollBars, P_1);
			}
		}
	}

	private void a(CANFrameModel P_0)
	{
		if (P_0 != null)
		{
			B(P_0);
			if (P_0.FrameDirection == CANFrameModel.Direction.Transmit)
			{
				A(P_0, ew);
			}
			else
			{
				A(P_0, eW);
			}
		}
	}

	private void A(CANFrameModel P_0, TreeViewWithThemedScrollBars P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<TreeNode> enumerator = P_1.a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				if (current.Tag is uint && (uint)current.Tag == P_0.Index)
				{
					P_1.A(current);
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if (eH)
		{
			BM.X(null, null);
		}
		else
		{
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.di();
			int num = 1;
			List<string> obj = new List<string>(num);
			CollectionsMarshal.SetCount<string>(obj, num);
			System.Span<string> span = CollectionsMarshal.AsSpan<string>(obj);
			int num2 = 0;
			span[num2] = text;
			num2 = 1;
			List<Color> obj2 = new List<Color>(num2);
			CollectionsMarshal.SetCount<Color>(obj2, num2);
			System.Span<Color> span2 = CollectionsMarshal.AsSpan<Color>(obj2);
			num = 0;
			span2[num] = BM.tC;
			BM.A(obj, obj2, (Control)(object)ey, eE, ((Control)ey).Right, ((Control)ey).Top);
		}
		eH = !eH;
	}

	private void a(object P_0, EventArgs P_1)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if (eh)
		{
			BM.X(null, null);
		}
		else
		{
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dJ();
			int num = 1;
			List<string> obj = new List<string>(num);
			CollectionsMarshal.SetCount<string>(obj, num);
			System.Span<string> span = CollectionsMarshal.AsSpan<string>(obj);
			int num2 = 0;
			span[num2] = text;
			num2 = 1;
			List<Color> obj2 = new List<Color>(num2);
			CollectionsMarshal.SetCount<Color>(obj2, num2);
			System.Span<Color> span2 = CollectionsMarshal.AsSpan<Color>(obj2);
			num = 0;
			span2[num] = BM.tC;
			BM.A(obj, obj2, (Control)(object)FB, eE, ((Control)FB).Right, ((Control)FB).Top);
		}
		eh = !eh;
	}

	private void A(TreeViewWithThemedScrollBars P_0, MouseEventArgs P_1)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		int x = P_1.X;
		int y = P_1.Y;
		Rectangle val;
		TreeNode val2 = P_0.A(x, y, out val);
		if (val2 != null && val2.Tag is uint)
		{
			ContextMenuStrip val3 = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			ToolStripMenuItem val4 = new ToolStripMenuItem();
			((ToolStripItem)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dj();
			((ToolStripItem)val4).Tag = (uint)val2.Tag;
			if (P_0 == eW)
			{
				((ToolStripItem)val4).Click += new EventHandler(b);
			}
			else
			{
				((ToolStripItem)val4).Click += new EventHandler(C);
			}
			((ToolStrip)val3).Items.Add((ToolStripItem)(object)val4);
			((ToolStripDropDown)val3).Show((Control)(object)P_0, new Point(x, y));
		}
	}

	private void B(object P_0, EventArgs P_1)
	{
		CANFrameModel.Direction direction = (CANFrameModel.Direction)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		A(direction);
	}

	private void b(object P_0, EventArgs P_1)
	{
		uint Bkt = (uint)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		CANFrameModel cANFrameModel = Enumerable.FirstOrDefault<CANFrameModel>((System.Collections.Generic.IEnumerable<CANFrameModel>)ed, (Func<CANFrameModel, bool>)((CANFrameModel P_0) => P_0.Index == Bkt));
		if (cANFrameModel != null && cANFrameModel.FrameDirection == CANFrameModel.Direction.Receive)
		{
			a(cANFrameModel);
			a(eW);
		}
	}

	private void C(object P_0, EventArgs P_1)
	{
		uint BkU = (uint)((ToolStripItem)((P_0 is ToolStripMenuItem) ? P_0 : null)).Tag;
		CANFrameModel cANFrameModel = Enumerable.FirstOrDefault<CANFrameModel>((System.Collections.Generic.IEnumerable<CANFrameModel>)ed, (Func<CANFrameModel, bool>)((CANFrameModel P_0) => P_0.Index == BkU));
		if (cANFrameModel != null && cANFrameModel.FrameDirection == CANFrameModel.Direction.Transmit)
		{
			a(cANFrameModel);
			a(ew);
		}
	}

	private void A(object P_0, KeyEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)P_1.KeyCode == 46 && eW.B() != null)
		{
			a(eW);
		}
	}

	private void a(object P_0, KeyEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)P_1.KeyCode == 46 && ew.B() != null)
		{
			a(ew);
		}
	}

	private void c(object P_0, EventArgs P_1)
	{
		A(CANFrameModel.Direction.Receive);
	}

	private void D(object P_0, EventArgs P_1)
	{
		A(CANFrameModel.Direction.Transmit);
	}

	private void A(object P_0, DrawTreeNodeEventArgs P_1)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		TreeNode node = P_1.Node;
		if (node.Tag is uint)
		{
			A(eW, node, P_1.Graphics, P_1.Bounds);
		}
	}

	private void a(object P_0, DrawTreeNodeEventArgs P_1)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		TreeNode node = P_1.Node;
		if (node.Tag is uint)
		{
			A(ew, node, P_1.Graphics, P_1.Bounds);
		}
	}

	private void A(TreeViewWithThemedScrollBars P_0, TreeNode P_1, Graphics P_2, Rectangle P_3)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		if (((Rectangle)(ref P_3)).Y < -10 || ((Rectangle)(ref P_3)).Y > ((Control)P_0).Height)
		{
			return;
		}
		int num = ((Control)P_0).Width - 20;
		int num2 = num - 12;
		int num3 = ((Rectangle)(ref P_3)).Top + ((Rectangle)(ref P_3)).Height / 2 - 6 - 1;
		int num4 = num3 + 12;
		SolidBrush val = new SolidBrush(((Control)P_0).BackColor);
		try
		{
			Pen val2 = new Pen(BM.te, 2f);
			try
			{
				P_2.FillRectangle((Brush)(object)val, num2 - 10, num3 - 2, 42, 18);
				P_2.DrawLine(val2, num2, num3, num, num4);
				P_2.DrawLine(val2, num2, num4, num, num3);
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

	internal bool A(KeyEventArgs P_0)
	{
		if (FE.IsFocused())
		{
			return FE.A(P_0);
		}
		return false;
	}

	private void e()
	{
		if (eE == null)
		{
			((Control)Ff).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
		}
		else if (eE.FrameDirection == CANFrameModel.Direction.Transmit)
		{
			((Control)Ff).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dK();
		}
		else
		{
			((Control)Ff).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dk();
		}
	}

	private void F()
	{
		if (eW.a().Count != 0 || ew.a().Count != 0)
		{
			((Control)Fe).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dL();
		}
		else
		{
			((Control)Fe).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dl();
		}
	}

	private void a(TreeViewWithThemedScrollBars P_0)
	{
		int Bku = -1;
		if (P_0.B() != null && P_0.B().Tag is uint)
		{
			Bku = (int)(uint)P_0.B().Tag;
			int index = P_0.B().Index;
			P_0.a().Remove(P_0.B());
			F();
			if (index >= 0 && P_0.a().Count >= 1)
			{
				if (index >= 1)
				{
					P_0.A(P_0.a()[index - 1]);
				}
				else if (P_0.a().Count > index)
				{
					P_0.A(P_0.a()[index]);
				}
				else
				{
					P_0.A((TreeNode)null);
				}
			}
			else
			{
				P_0.A((TreeNode)null);
			}
			((Control)P_0).Refresh();
		}
		if (Bku < 0)
		{
			return;
		}
		CANFrameModel cANFrameModel = Enumerable.FirstOrDefault<CANFrameModel>((System.Collections.Generic.IEnumerable<CANFrameModel>)ed, (Func<CANFrameModel, bool>)((CANFrameModel P_0) => P_0.Index == Bku));
		if (cANFrameModel == null)
		{
			return;
		}
		Ck ck = BM.aM();
		ck?.a();
		ei.M();
		eJ.BZN.az();
		if (cANFrameModel.Signals != null && cANFrameModel.Signals.Count > 0)
		{
			for (int num = cANFrameModel.Signals.Count - 1; num >= 0; num--)
			{
				CANSignalModel cANSignalModel = cANFrameModel.Signals[num];
				eJ.BZN.a(cANSignalModel.Index, -1, true);
				BM.b(eJ.BZN.A());
			}
		}
		eJ.BZl.A((int)cANFrameModel.Index, 0, true);
		BM.b(eJ.BZl.A());
		ed.Remove(cANFrameModel);
		if (P_0.B() != null && P_0.B().Tag is uint)
		{
			Bku = (int)(uint)P_0.B().Tag;
			CANFrameModel cANFrameModel2 = Enumerable.FirstOrDefault<CANFrameModel>((System.Collections.Generic.IEnumerable<CANFrameModel>)ed, (Func<CANFrameModel, bool>)((CANFrameModel P_0) => P_0.Index == Bku));
			B(cANFrameModel2);
		}
		else
		{
			h();
		}
		I();
		eJ.BZN.i(true);
		ei.A(true, eJ.BZN);
		ck?.B();
	}

	private void f()
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		G();
		g();
		bool flag = true;
		List<Setting.ListItems.A> obj = eJ.BZL.d(0);
		string[] array = ((obj != null) ? Enumerable.ToArray<string>(Enumerable.Select<Setting.ListItems.A, string>((System.Collections.Generic.IEnumerable<Setting.ListItems.A>)obj, (Func<Setting.ListItems.A, string>)((Setting.ListItems.A P_0) => P_0.bBV))) : null);
		if (array != null && array.Length != 0)
		{
			ObjectCollection items = ((ComboBox)ez).Items;
			object[] array2 = array;
			items.AddRange(array2);
		}
		else
		{
			flag = false;
		}
		List<Setting.ListItems.A> obj2 = eJ.BZl.d(0);
		string[] array3 = ((obj2 != null) ? Enumerable.ToArray<string>(Enumerable.Select<Setting.ListItems.A, string>((System.Collections.Generic.IEnumerable<Setting.ListItems.A>)obj2, (Func<Setting.ListItems.A, string>)((Setting.ListItems.A P_0) => P_0.bBV))) : null);
		if (array3 != null && array3.Length != 0)
		{
			ObjectCollection items2 = ((ComboBox)FC).Items;
			object[] array2 = array3;
			items2.AddRange(array2);
		}
		else
		{
			flag = false;
		}
		List<Setting.ListItems.A> obj3 = eJ.BZM.d(0);
		string[] array4 = ((obj3 != null) ? Enumerable.ToArray<string>(Enumerable.Select<Setting.ListItems.A, string>((System.Collections.Generic.IEnumerable<Setting.ListItems.A>)obj3, (Func<Setting.ListItems.A, string>)((Setting.ListItems.A P_0) => P_0.bBV))) : null);
		if (array4 != null && array4.Length != 0)
		{
			ObjectCollection items3 = ((ComboBox)FD).Items;
			object[] array2 = array4;
			items3.AddRange(array2);
		}
		else
		{
			flag = false;
		}
		List<Setting.ListItems.A> obj4 = eJ.BZQ.d(0);
		List<ValueAndDisplay> signDataSource = ((obj4 != null) ? Enumerable.ToList<ValueAndDisplay>(Enumerable.Select<Setting.ListItems.A, ValueAndDisplay>((System.Collections.Generic.IEnumerable<Setting.ListItems.A>)obj4, (Func<Setting.ListItems.A, ValueAndDisplay>)((Setting.ListItems.A P_0) => new ValueAndDisplay
		{
			Value = P_0.bBv,
			Display = P_0.bBV
		}))) : null);
		FE.ApplySignComboBoxDataSource(signDataSource);
		List<Setting.ListItems.A> obj5 = eJ.BZp.d(0);
		List<ValueAndDisplay> formatDataSource = ((obj5 != null) ? Enumerable.ToList<ValueAndDisplay>(Enumerable.Select<Setting.ListItems.A, ValueAndDisplay>((System.Collections.Generic.IEnumerable<Setting.ListItems.A>)obj5, (Func<Setting.ListItems.A, ValueAndDisplay>)((Setting.ListItems.A P_0) => new ValueAndDisplay
		{
			Value = P_0.bBv,
			Display = P_0.bBV
		}))) : null);
		FE.ApplyFormatComboBoxDataSource(formatDataSource);
		if (!flag)
		{
			bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dM(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		else
		{
			A(ed);
		}
	}

	private void G()
	{
		int num = eJ.BZL.av()[2];
		for (int i = 0; i < num; i++)
		{
			CANFrameModel cANFrameModel = CANFrameModel.A(eJ, (uint)i);
			if (cANFrameModel != null)
			{
				ed.Add(cANFrameModel);
			}
		}
	}

	private void g()
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		int num = eJ.BZN.av()[2];
		for (int i = 0; i < num; i++)
		{
			int BkV = eJ.BZN.m(i);
			if (BkV == -1)
			{
				continue;
			}
			CANSignalModel cANSignalModel = CANSignalModel.A(eJ, ei, null, BkV, i, eg);
			CANFrameModel cANFrameModel = Enumerable.FirstOrDefault<CANFrameModel>((System.Collections.Generic.IEnumerable<CANFrameModel>)ed, (Func<CANFrameModel, bool>)((CANFrameModel P_0) => P_0.Index == BkV));
			if (cANFrameModel != null)
			{
				CANFrameModel cANFrameModel2 = cANFrameModel;
				if (cANFrameModel2.Signals == null)
				{
					List<CANSignalModel> val2 = (cANFrameModel2.Signals = new List<CANSignalModel>());
				}
				cANFrameModel.Signals.Add(cANSignalModel);
			}
		}
		Enumerator<CANFrameModel> enumerator = ed.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANFrameModel current = enumerator.Current;
				current.A();
				if (current.Signals == null)
				{
					continue;
				}
				Enumerator<CANSignalModel> enumerator2 = current.Signals.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						CANSignalModel current2 = enumerator2.Current;
						A(current, current2, false);
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private int H()
	{
		int num = eJ.BZN.av()[2];
		for (int i = 0; i < num; i++)
		{
			if (eJ.BZN.m(i) == -1)
			{
				return i;
			}
		}
		return -1;
	}

	private string A(CANSignalModel P_0)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dN() + num;
		bool flag = false;
		do
		{
			flag = false;
			Enumerator<CANSignalModel> enumerator = eE.Signals.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					CANSignalModel current = enumerator.Current;
					if (current != P_0 && current.Name != null && current.Name == text)
					{
						num++;
						text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dN() + num;
						flag = true;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		while (flag);
		return text;
	}

	private bool A(CANFrameModel P_0, CANSignalModel P_1)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		int num = H();
		if (num == -1)
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(25, 1);
			defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dn());
			defaultInterpolatedStringHandler.AppendFormatted<int>(eJ.BZN.av()[2]);
			defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dO());
			bE.A((IWin32Window)(object)this, defaultInterpolatedStringHandler.ToStringAndClear(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.@do(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			return false;
		}
		P_1.Index = num;
		if (P_1.Name == null)
		{
			string text2 = (P_1.Name = A(P_1));
		}
		P_1.Id = (int)P_0.Index;
		C(P_0, P_1);
		E();
		((Control)FE).Refresh();
		return true;
	}

	private int a(CANFrameModel P_0, CANSignalModel P_1)
	{
		if (P_0.Signals != null && P_0.Signals.IndexOf(P_1) > 0)
		{
			return P_0.Signals[P_0.Signals.IndexOf(P_1) - 1].Format;
		}
		return eJ.BZp.at();
	}

	private uint B(CANFrameModel P_0, CANSignalModel P_1)
	{
		if (P_0.Length == 0)
		{
			return 0u;
		}
		uint num = 8 * P_0.Length - 1;
		switch ((CANSignalModel.SignalFormat)P_1.Format)
		{
		case CANSignalModel.SignalFormat.LittleEndian:
		{
			for (uint num4 = 0u; num4 <= num; num4++)
			{
				if (!P_0.a(num4))
				{
					return num4;
				}
			}
			break;
		}
		case CANSignalModel.SignalFormat.BigEndian:
		{
			uint num2 = 7u;
			for (uint num3 = 0u; num3 <= num; num3++)
			{
				if (!P_0.a(num2))
				{
					return num2;
				}
				num2 = ((num2 % 8 != 0) ? (num2 - 1) : (num2 + 15));
			}
			break;
		}
		}
		return (uint)eJ.BZo.at();
	}

	private uint b(CANFrameModel P_0, CANSignalModel P_1)
	{
		if (P_0.Length == 0)
		{
			return 0u;
		}
		uint num = 8 * P_0.Length - 1;
		uint num2 = 0u;
		switch ((CANSignalModel.SignalFormat)P_1.Format)
		{
		case CANSignalModel.SignalFormat.LittleEndian:
		{
			for (uint num5 = P_1.StartBit; num5 <= num && !P_0.a(num5); num5++)
			{
				num2++;
			}
			break;
		}
		case CANSignalModel.SignalFormat.BigEndian:
		{
			uint num3 = P_1.StartBit;
			for (uint num4 = 0u; num4 <= num; num4++)
			{
				if (P_0.a(num3))
				{
					break;
				}
				num2++;
				if (num3 == num - 7)
				{
					break;
				}
				num3 = ((num3 % 8 != 0) ? (num3 - 1) : (num3 + 15));
			}
			break;
		}
		}
		return Math.Min(num2, (uint)eJ.BZP.at());
	}

	private void C(CANFrameModel P_0, CANSignalModel P_1)
	{
		if (P_1.Format == 0)
		{
			P_1.Format = a(P_0, P_1);
		}
		if (P_1.StartBit == 0)
		{
			P_1.StartBit = B(P_0, P_1);
		}
		if (P_1.BitLength == 0)
		{
			P_1.BitLength = b(P_0, P_1);
		}
		if (P_1.Sign == 0)
		{
			P_1.Sign = eJ.BZQ.at();
		}
		P_1.Bus = eg;
		if (P_1.Source == null)
		{
			switch (eJ.BZn.at())
			{
			case 3:
			{
				int num = eJ.BZO.at();
				Setting setting = ei.A(num);
				if (setting != null)
				{
					P_1.Source = new ChannelSource(setting);
				}
				break;
			}
			case 2:
			{
				int val = eJ.BZO.at();
				P_1.Source = new FixedSource(val);
				break;
			}
			case 4:
				P_1.Source = new CounterSource();
				break;
			}
		}
		if (P_1.Multiplier == 0f)
		{
			byte[] bytes = BitConverter.GetBytes(eJ.BZq.at());
			P_1.Multiplier = BitConverter.ToSingle(bytes, 0);
		}
		if (P_1.Offset == 0f)
		{
			byte[] bytes2 = BitConverter.GetBytes(eJ.BZR.at());
			P_1.Offset = BitConverter.ToSingle(bytes2, 0);
		}
	}

	private void A(CANFrameModel P_0, CANSignalModel P_1, bool P_2)
	{
		if (P_1 != null && P_0 != null)
		{
			P_1.Multiplier = A(P_0, eJ.BZq, P_1.Multiplier, P_2);
			P_1.Offset = A(P_0, eJ.BZR, P_1.Offset, P_2);
			P_1.StartBit = (uint)A(P_0, eJ.BZo, P_1.StartBit, P_2);
			P_1.HasZeroMultiplierWarning = P_1.Multiplier == 0f;
			D(P_0, P_1);
			c(P_0, P_1);
			I();
		}
	}

	private void c(CANFrameModel P_0, CANSignalModel P_1)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(P_1.Name))
		{
			P_1.HasSignalNameError = true;
			return;
		}
		bool flag = true;
		Enumerator<CANFrameModel> enumerator = ed.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANFrameModel current = enumerator.Current;
				if (current.Signals == null)
				{
					continue;
				}
				Enumerator<CANSignalModel> enumerator2 = current.Signals.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						CANSignalModel current2 = enumerator2.Current;
						if (current2 != P_1 && current2.Index != -1 && current2.Name == P_1.Name)
						{
							flag = false;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				if (!flag)
				{
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		P_1.HasSignalNameError = !flag;
	}

	private void D(CANFrameModel P_0, CANSignalModel P_1)
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		CANSignalModel.SignalFormat format = (CANSignalModel.SignalFormat)P_1.Format;
		int num = -1;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 8 * P_0.Length;
		P_1.B();
		switch (format)
		{
		case CANSignalModel.SignalFormat.LittleEndian:
		{
			num2 = P_1.StartBit + P_1.BitLength - 1;
			for (uint num5 = P_1.StartBit; num5 < P_1.StartBit + P_1.BitLength; num5++)
			{
				if (P_0.a(num5))
				{
					num = (int)num5;
					num3 = num5 - P_1.StartBit;
					break;
				}
				if (num5 < num4)
				{
					P_0.A(num5);
					P_1.A(num5);
					num3++;
				}
			}
			break;
		}
		case CANSignalModel.SignalFormat.BigEndian:
		{
			num2 = P_1.StartBit;
			for (int i = 0; i < P_1.BitLength; i++)
			{
				if (P_0.a(num2) && num == -1)
				{
					num = (int)num2;
				}
				else
				{
					P_0.A(num2);
				}
				P_1.A(num2);
				if (num == -1 && num2 < num4)
				{
					num3++;
				}
				if (i != P_1.BitLength - 1)
				{
					num2 = ((num2 % 8 != 0) ? (num2 - 1) : (num2 + 15));
				}
			}
			break;
		}
		}
		if (P_1.BitLength > num3)
		{
			P_1.HasBeyondEndOfFrameError = num2 >= num4;
			if (num != -1)
			{
				P_1.HasBitOverlapError = true;
				Enumerator<CANSignalModel> enumerator = P_0.Signals.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						CANSignalModel current = enumerator.Current;
						if (P_1 != current && (current.a() & P_1.a()) != 0L)
						{
							current.HasBitOverlapError = true;
						}
					}
					return;
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			P_1.HasBitOverlapError = false;
		}
		else
		{
			P_1.HasBitOverlapError = false;
			P_1.HasBeyondEndOfFrameError = false;
		}
	}

	private float A(CANFrameModel P_0, Setting P_1, float P_2, bool P_3)
	{
		int num = P_1.aR();
		int num2 = P_1.ar();
		if ((num != num2 || num != 0 || num2 != 0) && P_3)
		{
			if (P_2 < (float)num)
			{
				P_2 = num;
			}
			else if (P_2 > (float)num2)
			{
				P_2 = num2;
			}
		}
		return P_2;
	}

	private void A(object P_0, List<CANSignalModel> P_1)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		if (eE == null)
		{
			return;
		}
		eI = true;
		Ck ck = BM.aM();
		ck?.a();
		ei.M();
		eJ.BZN.az();
		List<CANSignalModel> val = null;
		if (eE.Signals != null)
		{
			val = Enumerable.ToList<CANSignalModel>(Enumerable.Where<CANSignalModel>((System.Collections.Generic.IEnumerable<CANSignalModel>)eE.Signals, (Func<CANSignalModel, bool>)((CANSignalModel P_0) => !Enumerable.Any<CANSignalModel>((System.Collections.Generic.IEnumerable<CANSignalModel>)P_1, (Func<CANSignalModel, bool>)((CANSignalModel P_0) => P_0.Index == P_0.Index)))));
		}
		Enumerator<CANSignalModel> enumerator = P_1.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.FrameDirection = eE.FrameDirection;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		eE.Signals = P_1;
		if (val != null && val.Count != 0)
		{
			E();
			enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					CANSignalModel current = enumerator.Current;
					eJ.BZN.a(current.Index, -1, true);
					BM.b(eJ.BZN.A());
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		eE.A();
		for (int i = 0; i < eE.Signals.Count; i++)
		{
			CANSignalModel cANSignalModel = eE.Signals[i];
			if (cANSignalModel.Index == -1 && !A(eE, cANSignalModel))
			{
				eE.Signals.Remove(cANSignalModel);
				i--;
			}
			else
			{
				A(eE, cANSignalModel, true);
				A(cANSignalModel, eE.Index);
			}
		}
		Enumerator<CANFrameModel> enumerator2 = ed.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				CANFrameModel current2 = enumerator2.Current;
				if (current2 == eE)
				{
					continue;
				}
				current2.A();
				if (current2.Signals == null)
				{
					continue;
				}
				enumerator = current2.Signals.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						CANSignalModel current3 = enumerator.Current;
						A(current2, current3, false);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		FF.UpdateSignals(eE);
		A(true, eE);
		L();
		I();
		eJ.BZN.i(true);
		ei.A(true, eJ.BZN);
		ck?.B();
		eI = false;
	}

	private void d(object P_0, EventArgs P_1)
	{
		CANSignalModel selectedSignal = FE.GetSelectedSignal();
		if (selectedSignal != null)
		{
			FF.SelectSignal(selectedSignal);
		}
		else
		{
			FF.ClearSignalSelection();
		}
	}

	private void E(object P_0, EventArgs P_1)
	{
		CANSignalModel selectedSignal = FF.GetSelectedSignal();
		if (selectedSignal != null)
		{
			FE.SelectSignal(selectedSignal);
		}
	}

	private void e(object P_0, EventArgs P_1)
	{
		CANSignalModel selectedSignal = FF.GetSelectedSignal();
		if (selectedSignal != null)
		{
			int num = eJ.BZo.m(selectedSignal.Index);
			int num2 = eJ.BZP.m(selectedSignal.Index);
			int startBit = (int)selectedSignal.StartBit;
			int bitLength = (int)selectedSignal.BitLength;
			if (num != startBit && num2 != bitLength)
			{
				ei.M();
				eJ.BZo.az();
				eJ.BZP.az();
			}
			if (num != startBit)
			{
				eJ.BZo.a(selectedSignal.Index, startBit, true);
				BM.b(eJ.BZo.A());
			}
			if (num2 != bitLength)
			{
				eJ.BZP.a(selectedSignal.Index, bitLength, true);
				BM.b(eJ.BZP.A());
			}
			if (num != startBit && num2 != bitLength)
			{
				eJ.BZo.i(true);
				eJ.BZP.i(true);
				ei.A(true);
			}
		}
	}

	private void A(List<CANFrameModel> P_0)
	{
		if (P_0 == null)
		{
			eW.b();
			eW.a().Clear();
			eW.C();
			ew.b();
			ew.a().Clear();
			ew.C();
			F();
		}
		else
		{
			List<CANFrameModel> val = Enumerable.ToList<CANFrameModel>(Enumerable.Where<CANFrameModel>((System.Collections.Generic.IEnumerable<CANFrameModel>)P_0, (Func<CANFrameModel, bool>)((CANFrameModel P_0) => P_0.FrameDirection == CANFrameModel.Direction.Receive)));
			A(val, eW);
			List<CANFrameModel> val2 = Enumerable.ToList<CANFrameModel>(Enumerable.Where<CANFrameModel>((System.Collections.Generic.IEnumerable<CANFrameModel>)P_0, (Func<CANFrameModel, bool>)((CANFrameModel P_0) => P_0.FrameDirection == CANFrameModel.Direction.Transmit)));
			A(val2, ew);
			I();
		}
	}

	private void A(List<CANFrameModel> P_0, TreeViewWithThemedScrollBars P_1)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		P_1.b();
		P_1.a().Clear();
		Enumerator<CANFrameModel> enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANFrameModel current = enumerator.Current;
				TreeNode val = new TreeNode((string.IsNullOrEmpty(current.Name) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dP() : current.Name) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dp())
				{
					Tag = current.Index,
					ForeColor = (current.Enabled ? BM.te : BM.tq)
				};
				P_1.a().Add(val);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		P_1.C();
		B(P_1);
		F();
	}

	private void B(TreeViewWithThemedScrollBars P_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.a().Count == 0)
		{
			return;
		}
		Font val = new Font(((Control)P_0).Font, (FontStyle)1);
		try
		{
			Enumerator<TreeNode> enumerator = P_0.a().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TreeNode current = enumerator.Current;
					string text = current.Text.Substring(0, current.Text.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dp().Length);
					Size val2 = TextRenderer.MeasureText(text, val, new Size(2147483647, 2147483647), (TextFormatFlags)2048);
					if (((Size)(ref val2)).Width > ((Control)P_0).Width - 20 - 12 - 10)
					{
						current.ToolTipText = text;
					}
					else
					{
						current.ToolTipText = string.Empty;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
		((Control)P_0).Invalidate();
	}

	private void F(object P_0, EventArgs P_1)
	{
		B(eW);
	}

	private void f(object P_0, EventArgs P_1)
	{
		B(ew);
	}

	private void A(uint P_0, bool P_1)
	{
		if (P_1)
		{
			eJ.BZS.a((int)P_0, true);
		}
		else
		{
			eJ.BZS.a((int)P_0 | -2147483648, true);
		}
	}

	private void h()
	{
		((Control)FE).Visible = false;
		((Control)Fe).Visible = true;
		A();
		eE = null;
		FF.UpdateSignals(null);
		eG.Stop();
		i();
		j();
		BM.X(null, null);
		L();
		e();
	}

	private void B(CANFrameModel P_0)
	{
		eI = true;
		BM.X(null, null);
		A(P_0);
		eE = P_0;
		if (!A(P_0.StdFrame, out var num))
		{
			num = 4294967295u;
			k();
		}
		J();
		A(P_0, num);
		A(num, P_0.StdFrame);
		L();
		e();
		((Control)Fe).Visible = false;
		((Control)FE).Visible = true;
		FF.UpdateSignals(P_0);
		if (P_0.Signals == null)
		{
			FE.A(null, P_0.FrameDirection);
		}
		else
		{
			List<CANSignalModel> val = new List<CANSignalModel>((System.Collections.Generic.IEnumerable<CANSignalModel>)P_0.Signals);
			P_0.A();
			for (int i = 0; i < val.Count; i++)
			{
				CANSignalModel cANSignalModel = val[i];
				if (cANSignalModel.Index != -1)
				{
					A(P_0, cANSignalModel, false);
				}
			}
			FE.A(val, P_0.FrameDirection);
		}
		E();
		eG.Start();
		FE.A(true);
		eI = false;
	}

	private void A(CANFrameModel.Direction P_0)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		uint num = 0u;
		byte[] array = eJ.BZl.aY();
		for (uint num2 = 0u; num2 < array.Length; num2++)
		{
			if (!CANFrameModel.IsFrameVisible(array[num2]))
			{
				num = num2;
				break;
			}
			if (num2 == array.Length - 1)
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(24, 1);
				defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dn());
				defaultInterpolatedStringHandler.AppendFormatted<int>(array.Length);
				defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dQ());
				bE.A((IWin32Window)(object)this, defaultInterpolatedStringHandler.ToStringAndClear(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dq(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
		}
		CANFrameModel cANFrameModel = new CANFrameModel
		{
			Index = num,
			StdFrame = true,
			Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dR() + (num + 1),
			FrameDirection = P_0,
			Signals = new List<CANSignalModel>()
		};
		ed.Add(cANFrameModel);
		b(cANFrameModel);
		Ck ck = BM.aM();
		ck?.a();
		A(cANFrameModel, false);
		a(cANFrameModel, false);
		B(cANFrameModel, false);
		b(cANFrameModel, false);
		A(ed);
		a(cANFrameModel);
		ck?.B();
	}

	private void A(object P_0, TreeViewEventArgs P_1)
	{
		A(P_0, P_1, CANFrameModel.Direction.Receive);
	}

	private void a(object P_0, TreeViewEventArgs P_1)
	{
		A(P_0, P_1, CANFrameModel.Direction.Transmit);
	}

	private void A(object P_0, TreeViewEventArgs P_1, CANFrameModel.Direction P_2)
	{
		if (P_1.Node == null || P_1.Node.Tag == null)
		{
			eE = null;
			h();
			a(P_2);
			return;
		}
		CANFrameModel cANFrameModel = A(P_1.Node);
		if (cANFrameModel != null)
		{
			a(P_2);
			B(cANFrameModel);
		}
	}

	private void a(CANFrameModel.Direction P_0)
	{
		if (P_0 == CANFrameModel.Direction.Transmit)
		{
			eW.A((TreeNode)null);
		}
		else
		{
			ew.A((TreeNode)null);
		}
	}

	private void b(CANFrameModel P_0)
	{
		P_0.Enabled = CANFrameModel.IsFrameEnabled((byte)eJ.BZl.at());
		P_0.Length = (uint)eJ.BZl.at() & 0x3Fu;
		int canIdByte = eJ.BZL.at();
		P_0.ParseCanIdByte((uint)canIdByte);
		P_0.Rate = eJ.BZM.at() & 0x3F;
	}

	private void A(CANFrameModel P_0, bool P_1)
	{
		if (P_0 != null)
		{
			Ck ck = null;
			if (P_1)
			{
				ck = BM.aM();
				ck?.a();
			}
			eJ.BZk.A(P_0.Name, (int)P_0.Index, true);
			BM.b(eJ.BZk.A());
			ck?.B();
		}
	}

	private void a(CANFrameModel P_0, bool P_1)
	{
		if (P_0 != null)
		{
			Ck ck = null;
			if (P_1)
			{
				ck = BM.aM();
				ck?.a();
			}
			eJ.BZL.a((int)P_0.Index, (int)P_0.GetCanIdSettingValue(), true);
			BM.b(eJ.BZL.A());
			ck?.B();
		}
	}

	private void B(CANFrameModel P_0, bool P_1)
	{
		if (P_0 != null)
		{
			Ck ck = null;
			if (P_1)
			{
				ck = BM.aM();
				ck?.a();
			}
			eJ.BZl.a((int)P_0.Index, P_0.GetEnableLengthValue(), true);
			BM.b(eJ.BZl.A());
			ck?.B();
		}
	}

	private void b(CANFrameModel P_0, bool P_1)
	{
		if (P_0 != null)
		{
			Ck ck = null;
			if (P_1)
			{
				ck = BM.aM();
				ck?.a();
			}
			eJ.BZM.a((int)P_0.Index, P_0.GetTransmitRateValue(), true);
			BM.b(eJ.BZM.A());
			ck?.B();
		}
	}

	private void A(CANSignalModel P_0, uint P_1)
	{
		if (eJ.BZm.N(P_0.Index) != P_0.Name)
		{
			eJ.BZm.A(P_0.Name ?? string.Empty, P_0.Index, true);
			BM.b(eJ.BZm.A());
		}
		byte signalTypeFromSource = P_0.GetSignalTypeFromSource();
		if (eJ.BZn.m(P_0.Index) != signalTypeFromSource)
		{
			eJ.BZn.a(P_0.Index, signalTypeFromSource, true);
			BM.b(eJ.BZn.A());
		}
		int num = ((!(P_0.Source is ChannelSource channelSource)) ? ((P_0.Source is FixedSource fixedSource) ? fixedSource.Value : 0) : channelSource.Channel.A());
		if (eJ.BZO.m(P_0.Index) != num)
		{
			eJ.BZO.a(P_0.Index, num, true);
			BM.b(eJ.BZO.A());
		}
		if (eJ.BZo.m(P_0.Index) != (int)P_0.StartBit)
		{
			eJ.BZo.a(P_0.Index, (int)P_0.StartBit, true);
			BM.b(eJ.BZo.A());
		}
		if (eJ.BZP.m(P_0.Index) != (int)P_0.BitLength)
		{
			eJ.BZP.a(P_0.Index, (int)P_0.BitLength, true);
			BM.b(eJ.BZP.A());
		}
		if (eJ.BZp.m(P_0.Index) != (byte)P_0.Format)
		{
			eJ.BZp.a(P_0.Index, (byte)P_0.Format, true);
			BM.b(eJ.BZp.A());
		}
		if (eJ.BZQ.m(P_0.Index) != (byte)P_0.Sign)
		{
			eJ.BZQ.a(P_0.Index, (byte)P_0.Sign, true);
			BM.b(eJ.BZQ.A());
		}
		byte[] bytes = BitConverter.GetBytes(P_0.Multiplier);
		byte[] bytes2 = BitConverter.GetBytes(P_0.Offset);
		if (!ei.aWR)
		{
			System.Array.Reverse<byte>(bytes);
			System.Array.Reverse<byte>(bytes2);
		}
		if (eJ.BZq.m(P_0.Index) != BitConverter.ToInt32(System.ReadOnlySpan<byte>.op_Implicit(bytes)))
		{
			eJ.BZq.a(P_0.Index, BitConverter.ToInt32(System.ReadOnlySpan<byte>.op_Implicit(bytes)), true);
			BM.b(eJ.BZq.A());
		}
		if (eJ.BZR.m(P_0.Index) != BitConverter.ToInt32(System.ReadOnlySpan<byte>.op_Implicit(bytes2)))
		{
			eJ.BZR.a(P_0.Index, BitConverter.ToInt32(System.ReadOnlySpan<byte>.op_Implicit(bytes2)), true);
			BM.b(eJ.BZR.A());
		}
		if (eJ.BZr.m(P_0.Index) != P_0.Units)
		{
			eJ.BZr.a(P_0.Index, P_0.Units, true);
			BM.b(eJ.BZr.A());
		}
		if (eJ.BZN.m(P_0.Index) != (short)P_1)
		{
			eJ.BZN.a(P_0.Index, (short)P_1, true);
			BM.b(eJ.BZN.A());
			BM.b(eJ.BZM.A());
		}
	}

	private bool C(CANFrameModel P_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.Signals != null)
		{
			Enumerator<CANSignalModel> enumerator = P_0.Signals.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					CANSignalModel current = enumerator.Current;
					if (current.HasBitOverlapError || current.HasBeyondEndOfFrameError || current.HasSignalNameError || current.InvalidUnits || (P_0.FrameDirection == CANFrameModel.Direction.Transmit && current.Source == null))
					{
						return true;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		return false;
	}

	private void I()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<CANFrameModel> enumerator = ed.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANFrameModel Bks = enumerator.Current;
				bool flag = !string.IsNullOrEmpty(Bks.Name) && Enumerable.ToList<CANFrameModel>(Enumerable.Where<CANFrameModel>((System.Collections.Generic.IEnumerable<CANFrameModel>)ed, (Func<CANFrameModel, bool>)((CANFrameModel P_0) => P_0 != Bks && P_0.Name == Bks.Name))).Count != 0;
				bool flag2 = (Bks.StdFrame ? eJ.BZI.Contains((ushort)Bks.CANId) : eJ.BZJ.Contains(Bks.CANId));
				Bks.InError = string.IsNullOrEmpty(Bks.Name) || flag || flag2 || C(Bks);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		A(eW, CANFrameModel.Direction.Receive);
		A(ew, CANFrameModel.Direction.Transmit);
	}

	private void A(TreeViewWithThemedScrollBars P_0, CANFrameModel.Direction P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<TreeNode> enumerator = P_0.a().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TreeNode current = enumerator.Current;
				CANFrameModel cANFrameModel = A(current);
				if (cANFrameModel == null)
				{
					current.ForeColor = BM.te;
				}
				else if (!cANFrameModel.Enabled)
				{
					current.ForeColor = BM.tq;
				}
				else if (cANFrameModel.InError)
				{
					current.ForeColor = BM.tC;
				}
				else
				{
					current.ForeColor = BM.te;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		((Control)P_0).Invalidate();
	}

	private CANFrameModel A(TreeNode P_0)
	{
		if (P_0.Tag is uint)
		{
			uint BkT = (uint)P_0.Tag;
			if (BkT >= 0)
			{
				return Enumerable.FirstOrDefault<CANFrameModel>((System.Collections.Generic.IEnumerable<CANFrameModel>)ed, (Func<CANFrameModel, bool>)((CANFrameModel P_0) => P_0.Index == BkT));
			}
		}
		return null;
	}

	private void i()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		((Control)eY).BackColor = BM.to;
		((Control)eY).ForeColor = BM.te;
		((Control)ey).Visible = false;
		if (eH)
		{
			BM.X(null, null);
		}
	}

	private void J()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (eJ.BZk.O())
		{
			i();
			return;
		}
		bool num = string.IsNullOrEmpty(((Control)eY).Text);
		bool flag = !num && Enumerable.ToList<CANFrameModel>(Enumerable.Where<CANFrameModel>((System.Collections.Generic.IEnumerable<CANFrameModel>)ed, (Func<CANFrameModel, bool>)([CompilerGenerated] (CANFrameModel P_0) => P_0 != eE && P_0.Name == ((Control)eY).Text))).Count != 0;
		if (num || flag)
		{
			((Control)ey).Visible = true;
			((Control)eY).BackColor = BM.tC;
			((Control)eY).ForeColor = BM.te;
		}
		else
		{
			i();
		}
	}

	private void j()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		((Control)Fa).BackColor = BM.to;
		((Control)Fa).ForeColor = BM.te;
		((Control)FB).Visible = false;
		if (eh)
		{
			BM.X(null, null);
		}
	}

	private void A(CANFrameModel P_0, uint P_1)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (P_0.StdFrame ? eJ.BZI.Contains((ushort)P_1) : eJ.BZJ.Contains(P_1));
		if (P_0 != null && flag)
		{
			((Control)FB).Visible = true;
			((Control)Fa).BackColor = BM.tC;
			((Control)Fa).ForeColor = BM.te;
		}
		else
		{
			j();
		}
	}

	private bool A(bool P_0, out uint P_1)
	{
		string text = ((Control)Fa).Text;
		if (text.Length == 0)
		{
			P_1 = 0u;
			return false;
		}
		string text2;
		if (text.Length > 2 && text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI(), (StringComparison)5))
		{
			text2 = text.Substring(2);
		}
		else if (text.Length > 1 && text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dr(), (StringComparison)5))
		{
			text2 = text.Substring(1);
			((Control)Fa).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI() + text2;
		}
		else if (text.Length > 1 && text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dr(), (StringComparison)5))
		{
			text2 = text.Substring(0, text.Length - 1);
			((Control)Fa).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI() + text2;
		}
		else
		{
			text2 = text;
			if (!text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI()))
			{
				((Control)Fa).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI() + text2;
			}
		}
		if (uint.TryParse(text2, (NumberStyles)515, (IFormatProvider)(object)CultureInfo.InvariantCulture, ref P_1))
		{
			string text3 = (P_0 ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dh() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dH());
			((Control)Fa).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI() + P_1.ToString(text3);
			return true;
		}
		P_1 = 0u;
		return false;
	}

	private void K()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		eR = true;
		((Control)Fa).BackColor = BM.tC;
		bool flag = ((ListControl)ez).SelectedIndex == 0;
		bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dS() + (flag ? 11 : 29) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ds() + (flag ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dT() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dt(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		eR = false;
	}

	private void k()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		eR = true;
		((Control)Fa).BackColor = BM.tC;
		bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dU(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dt(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		eR = false;
	}

	private void G(object P_0, EventArgs P_1)
	{
		if (eE != null && eJ.BZS.ax() == -1)
		{
			int num = eJ.BZL.m((int)eE.Index);
			bool flag = CANFrameModel.IsFrameStdId((uint)num);
			uint num2 = (flag ? ((uint)num & 0x7FFu) : ((uint)num & 0x1FFFFFFFu));
			A(num2, flag);
		}
		if (eJ.BZs != null)
		{
			byte[] array = eJ.BZs.aY();
			if (array.Length == 8)
			{
				long val = BitConverter.ToInt64(System.ReadOnlySpan<byte>.op_Implicit(array));
				FE.UpdateRawValue(val);
				L();
			}
		}
	}

	private void L()
	{
		if (BM.A(ei.aXc, true) && !BM.aE())
		{
			if (eJ.BZs != null)
			{
				byte[] array = eJ.BZs.aY();
				if (array.Length == 8)
				{
					long val = BitConverter.ToInt64(System.ReadOnlySpan<byte>.op_Implicit(array));
					Fd.UpdateValue(val);
				}
			}
		}
		else
		{
			Fd.UpdateValue(0L);
		}
	}

	public void Close()
	{
		b();
		Timer obj = eG;
		if (obj != null)
		{
			((Component)obj).Dispose();
		}
		eJ.BZS.a(-1, true);
		if (eE == null)
		{
			ee = -1;
		}
		else
		{
			ee = (int)eE.Index;
		}
	}

	private void l()
	{
		if (((Control)eY).Text != eE.Name)
		{
			eE.Name = ((Control)eY).Text;
			A(eE, true);
		}
	}

	private void g(object P_0, EventArgs P_1)
	{
		l();
	}

	private void B(object P_0, KeyEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)P_1.KeyCode == 13)
		{
			l();
			P_1.Handled = true;
			P_1.SuppressKeyPress = true;
		}
	}

	private void H(object P_0, EventArgs P_1)
	{
		if (!eR)
		{
			M();
		}
	}

	private void b(object P_0, KeyEventArgs P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)P_1.KeyCode == 13)
		{
			M();
			P_1.Handled = true;
			P_1.SuppressKeyPress = true;
		}
	}

	private void M()
	{
		bool flag = ((ListControl)ez).SelectedIndex == 0;
		if (A(flag, out var num))
		{
			if (flag ? (num <= 2047) : (num <= 536870911))
			{
				j();
				bool stdFrame = eE.StdFrame;
				uint cANId = eE.CANId;
				if (flag != stdFrame || num != cANId)
				{
					eE.StdFrame = flag;
					eE.CANId = num;
					a(eE, true);
					A(num, flag);
				}
				else
				{
					A(eE, eE.CANId);
				}
			}
			else if (!eR)
			{
				K();
			}
		}
		else if (!eR)
		{
			k();
		}
	}

	private void h(object P_0, EventArgs P_1)
	{
		if (eE != null && ((ListControl)ez).SelectedIndex == 0 != eE.StdFrame)
		{
			M();
		}
	}

	private void I(object P_0, EventArgs P_1)
	{
		if (eE != null)
		{
			int selectedIndex = ((ListControl)FC).SelectedIndex;
			if (selectedIndex != eE.Length)
			{
				eE.Length = (uint)selectedIndex;
				B(eE, true);
			}
		}
	}

	private void i(object P_0, EventArgs P_1)
	{
		if (eE != null)
		{
			int selectedIndex = ((ListControl)FD).SelectedIndex;
			if (selectedIndex != eE.Rate)
			{
				eE.Rate = selectedIndex;
				b(eE, true);
			}
		}
	}

	private void J(object P_0, EventArgs P_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		if (!eI)
		{
			bool flag = (int)((CheckBox)eX).CheckState == 1;
			if (flag != eE.Enabled)
			{
				eE.Enabled = flag;
				A(ed);
				B(eE, true);
			}
		}
	}

	private void j(object P_0, EventArgs P_1)
	{
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		HashSet<uint> val = new HashSet<uint>();
		for (int num = ed.Count - 1; num >= 0; num--)
		{
			CANFrameModel cANFrameModel = ed[num];
			int num2 = eJ.BZl.m((int)cANFrameModel.Index);
			bool flag = CANFrameModel.IsFrameEnabled((byte)num2);
			bool flag2 = CANFrameModel.IsFrameVisible((byte)num2);
			int num3 = num2 & 0x3F;
			if (flag2)
			{
				val.Add(cANFrameModel.Index);
				cANFrameModel.Length = (uint)num3;
				if (cANFrameModel.Enabled != flag)
				{
					cANFrameModel.Enabled = flag;
					A(ed);
				}
				if (cANFrameModel == eE)
				{
					((ListControl)FC).SelectedIndex = num3;
					((CheckBox)eX).CheckState = (CheckState)(flag ? 1 : 0);
					A(true, cANFrameModel, false);
					FF.UpdateSignals(cANFrameModel);
				}
			}
			else
			{
				ed.Remove(cANFrameModel);
				if (cANFrameModel == eE)
				{
					((cANFrameModel.FrameDirection == CANFrameModel.Direction.Transmit) ? ew : eW).A((TreeNode)null);
					h();
					a(cANFrameModel.FrameDirection);
				}
				eW.b();
				ew.b();
				for (int i = 0; i < eW.a().Count; i++)
				{
					TreeNode val2 = eW.a()[i];
					if (val2.Tag is uint num4 && num4 == cANFrameModel.Index)
					{
						eW.a().Remove(val2);
						break;
					}
				}
				for (int j = 0; j < ew.a().Count; j++)
				{
					TreeNode val3 = ew.a()[j];
					if (val3.Tag is uint num5 && num5 == cANFrameModel.Index)
					{
						ew.a().Remove(val3);
						break;
					}
				}
				F();
				eW.C();
				ew.C();
				((Control)eW).Refresh();
				((Control)ew).Refresh();
			}
		}
		int num6 = eJ.BZl.av()[2];
		for (int k = 0; k < num6; k++)
		{
			if (CANFrameModel.IsFrameVisible((byte)eJ.BZl.m(k)) && !val.Contains((uint)k))
			{
				CANFrameModel cANFrameModel2 = CANFrameModel.A(eJ, (uint)k);
				cANFrameModel2.Signals = new List<CANSignalModel>();
				ed.Add(cANFrameModel2);
				A(ed);
			}
		}
		Enumerator<CANFrameModel> enumerator = ed.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANFrameModel current = enumerator.Current;
				current.A();
				if (current.Signals == null)
				{
					continue;
				}
				Enumerator<CANSignalModel> enumerator2 = current.Signals.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						CANSignalModel current2 = enumerator2.Current;
						A(current, current2, false);
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		I();
		FE.A(true);
	}

	private void K(object P_0, EventArgs P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<CANFrameModel> enumerator = ed.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANFrameModel current = enumerator.Current;
				string text2 = (current.Name = eJ.BZk.N((int)current.Index));
				if (current == eE)
				{
					((Control)eY).Text = text2;
				}
				TreeViewWithThemedScrollBars treeViewWithThemedScrollBars = ((current.FrameDirection == CANFrameModel.Direction.Transmit) ? ew : eW);
				Enumerator<TreeNode> enumerator2 = treeViewWithThemedScrollBars.a().GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						TreeNode current2 = enumerator2.Current;
						if (current2.Tag is uint num && num == current.Index && current2.Text != text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dp())
						{
							treeViewWithThemedScrollBars.b();
							current2.Text = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dp();
							treeViewWithThemedScrollBars.C();
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		I();
		B(eW);
		B(ew);
	}

	private void k(object P_0, EventArgs P_1)
	{
		if (eE != null)
		{
			J();
		}
		I();
	}

	private void L(object P_0, EventArgs P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<CANFrameModel> enumerator = ed.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANFrameModel current = enumerator.Current;
				int num = eJ.BZL.m((int)current.Index);
				bool flag = CANFrameModel.IsFrameStdId((uint)num);
				uint cANId = (flag ? ((uint)num & 0x7FFu) : ((uint)num & 0x1FFFFFFFu));
				if (current == eE)
				{
					string text = (flag ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dh() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dH());
					((Control)Fa).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dI() + cANId.ToString(text);
					((ListControl)ez).SelectedIndex = ((!flag) ? 1 : 0);
				}
				current.CANId = cANId;
				current.StdFrame = flag;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		I();
	}

	private void l(object P_0, EventArgs P_1)
	{
		if (eE != null)
		{
			A(eE, eE.CANId);
		}
		I();
	}

	private void M(object P_0, EventArgs P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<CANFrameModel> enumerator = ed.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANFrameModel current = enumerator.Current;
				int num = eJ.BZM.m((int)current.Index);
				CANFrameModel.Direction frameDirection = ((((uint)num & 0x80u) != 0) ? CANFrameModel.Direction.Transmit : CANFrameModel.Direction.Receive);
				bool oneshot = (num & 0x40) != 0;
				int selectedIndex = (current.Rate = num & 0x3F);
				current.FrameDirection = frameDirection;
				current.Oneshot = oneshot;
				if (current == eE)
				{
					((ListControl)FD).SelectedIndex = selectedIndex;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		I();
	}

	private void m(object P_0, EventArgs P_1)
	{
		if (eE != null && eE.Signals != null)
		{
			FE.A(eE.Signals, eE.FrameDirection);
			FE.A(true);
		}
	}

	private void N(object P_0, EventArgs P_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		if (eI)
		{
			return;
		}
		Enumerator<CANFrameModel> enumerator = ed.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANFrameModel current = enumerator.Current;
				current.A();
				if (P_0 == eJ.BZN && current.Signals != null)
				{
					Dictionary<int, int> val = new Dictionary<int, int>();
					for (int num = current.Signals.Count - 1; num >= 0; num--)
					{
						CANSignalModel cANSignalModel = current.Signals[num];
						if (cANSignalModel.Index != -1 && cANSignalModel.Id != -1)
						{
							if (eJ.BZN.m(cANSignalModel.Index) == -1)
							{
								current.Signals.Remove(cANSignalModel);
							}
							else
							{
								val[cANSignalModel.Index] = cANSignalModel.Id;
							}
						}
					}
					int num2 = eJ.BZN.av()[2];
					for (int i = 0; i < num2; i++)
					{
						int num3 = eJ.BZN.m(i);
						if (num3 != current.Index || (val.ContainsKey(i) && val[i] != -1))
						{
							continue;
						}
						CANSignalModel cANSignalModel2 = new CANSignalModel
						{
							Id = num3,
							Index = i,
							Bus = eg
						};
						if (current.Signals.Count == 0)
						{
							current.Signals.Add(cANSignalModel2);
							continue;
						}
						int num4 = 0;
						for (int num5 = current.Signals.Count - 1; num5 >= 0; num5--)
						{
							if (i > current.Signals[num5].Index)
							{
								num4 = num5 + 1;
								break;
							}
						}
						current.Signals.Insert(num4, cANSignalModel2);
					}
				}
				if (current.Signals == null)
				{
					continue;
				}
				Enumerator<CANSignalModel> enumerator2 = current.Signals.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						CANSignalModel current2 = enumerator2.Current;
						CANSignalModel.A(eJ, ei, current2);
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = ed.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CANFrameModel current3 = enumerator.Current;
				current3.A();
				if (current3.Signals == null)
				{
					continue;
				}
				Enumerator<CANSignalModel> enumerator2 = current3.Signals.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						CANSignalModel current4 = enumerator2.Current;
						A(current3, current4, false);
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (eE != null && eE.Signals != null)
		{
			FE.A(eE.Signals, eE.FrameDirection);
			FE.A(true);
			E();
			FF.UpdateSignals(eE);
			A(true, eE);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && er != null)
		{
			((System.IDisposable)er).Dispose();
		}
		b();
		((ContainerControl)this).Dispose(disposing);
	}

	private void m()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Expected O, but got Unknown
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Expected O, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected O, but got Unknown
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected O, but got Unknown
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected O, but got Unknown
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1038: Unknown result type (might be due to invalid IL or missing references)
		//IL_1042: Expected O, but got Unknown
		//IL_104e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1078: Unknown result type (might be due to invalid IL or missing references)
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1132: Unknown result type (might be due to invalid IL or missing references)
		eS = new ak();
		es = new ak();
		eT = new TableLayoutPanel();
		et = new Label();
		eU = new ThemedButton();
		eW = new TreeViewWithThemedScrollBars();
		eu = new TableLayoutPanel();
		eV = new Label();
		ev = new ThemedButton();
		ew = new TreeViewWithThemedScrollBars();
		eX = new aP();
		ex = new Label();
		eY = new ThemedTextBox();
		ey = new PictureBox();
		eZ = new Label();
		ez = new ThemedComboBox();
		FA = new Label();
		Fa = new ThemedTextBox();
		FB = new PictureBox();
		Fb = new Label();
		FC = new ThemedComboBox();
		Fc = new Label();
		FD = new ThemedComboBox();
		Fd = new CANRawDataView();
		FE = new CANSignalEditor();
		Fe = new Label();
		FF = new ThemedBitfieldViewer();
		Ff = new Label();
		((ISupportInitialize)eS).BeginInit();
		((Control)((SplitContainer)eS).Panel1).SuspendLayout();
		((Control)((SplitContainer)eS).Panel2).SuspendLayout();
		((Control)eS).SuspendLayout();
		((ISupportInitialize)es).BeginInit();
		((Control)((SplitContainer)es).Panel1).SuspendLayout();
		((Control)((SplitContainer)es).Panel2).SuspendLayout();
		((Control)es).SuspendLayout();
		((Control)eT).SuspendLayout();
		((Control)eu).SuspendLayout();
		((Control)this).SuspendLayout();
		((SplitContainer)eS).Dock = (DockStyle)5;
		((Control)eS).Location = new Point(0, 0);
		((Control)eS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.du();
		((Control)((SplitContainer)eS).Panel1).Controls.Add((Control)(object)es);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)eX);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)ex);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)eY);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)ey);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)eZ);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)ez);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)FA);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)Fa);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)FB);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)Fb);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)FC);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)Fc);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)FD);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)Ff);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)Fd);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)FE);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)Fe);
		((Control)((SplitContainer)eS).Panel2).Controls.Add((Control)(object)FF);
		((SplitContainer)eS).Panel1MinSize = 130;
		((SplitContainer)eS).Panel2MinSize = 200;
		((Control)eS).Size = new Size(1072, 550);
		((SplitContainer)eS).SplitterDistance = 136;
		((Control)eS).TabIndex = 0;
		((SplitContainer)es).Dock = (DockStyle)5;
		((Control)es).Location = new Point(0, 0);
		((Control)es).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dV();
		((SplitContainer)es).Orientation = (Orientation)0;
		((Control)((SplitContainer)es).Panel1).Controls.Add((Control)(object)eT);
		((Control)((SplitContainer)es).Panel2).Controls.Add((Control)(object)eu);
		((Control)es).Size = new Size(136, 550);
		((SplitContainer)es).SplitterDistance = 275;
		((Control)es).TabIndex = 0;
		eT.ColumnStyles.Add(new ColumnStyle((SizeType)1, 136f));
		eT.Controls.Add((Control)(object)et, 0, 0);
		eT.Controls.Add((Control)(object)eU, 0, 1);
		eT.Controls.Add((Control)(object)eW, 0, 2);
		((Control)eT).Dock = (DockStyle)5;
		((Control)eT).Location = new Point(0, 0);
		((Control)eT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dv();
		eT.RowCount = 3;
		eT.RowStyles.Add(new RowStyle((SizeType)1, 18f));
		eT.RowStyles.Add(new RowStyle((SizeType)1, 25f));
		eT.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		((Control)eT).Size = new Size(136, 275);
		((Control)eT).TabIndex = 0;
		((Control)et).AutoSize = true;
		((Control)et).Dock = (DockStyle)5;
		((Control)et).Location = new Point(3, 0);
		((Control)et).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dW();
		((Control)et).Size = new Size(130, 18);
		((Control)et).TabIndex = 0;
		((Control)et).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dw();
		et.TextAlign = (ContentAlignment)16;
		((Control)eU).AutoSize = true;
		((Control)eU).Dock = (DockStyle)5;
		((Control)eU).Location = new Point(3, 18);
		((Control)eU).Margin = new Padding(3, 0, 3, 0);
		((Control)eU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dX();
		((Control)eU).Size = new Size(130, 25);
		((Control)eU).TabIndex = 1;
		((Control)eU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dx();
		((Control)eU).Click += new EventHandler(c);
		((Control)eW).Dock = (DockStyle)5;
		((Control)eW).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)1);
		((Control)eW).Location = new Point(3, 46);
		((Control)eW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dY();
		((Control)eW).Size = new Size(130, 226);
		((Control)eW).TabIndex = 2;
		eu.ColumnStyles.Add(new ColumnStyle((SizeType)1, 136f));
		eu.Controls.Add((Control)(object)eV, 0, 0);
		eu.Controls.Add((Control)(object)ev, 0, 1);
		eu.Controls.Add((Control)(object)ew, 0, 2);
		((Control)eu).Dock = (DockStyle)5;
		((Control)eu).Location = new Point(0, 0);
		((Control)eu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dy();
		eu.RowCount = 3;
		eu.RowStyles.Add(new RowStyle((SizeType)1, 18f));
		eu.RowStyles.Add(new RowStyle((SizeType)1, 25f));
		eu.RowStyles.Add(new RowStyle((SizeType)2, 100f));
		((Control)eu).Size = new Size(136, 271);
		((Control)eu).TabIndex = 0;
		((Control)eV).AutoSize = true;
		((Control)eV).Dock = (DockStyle)5;
		((Control)eV).Location = new Point(3, 0);
		((Control)eV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dZ();
		((Control)eV).Size = new Size(130, 18);
		((Control)eV).TabIndex = 0;
		((Control)eV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dz();
		eV.TextAlign = (ContentAlignment)16;
		((Control)ev).AutoSize = true;
		((Control)ev).Dock = (DockStyle)5;
		((Control)ev).Location = new Point(3, 18);
		((Control)ev).Margin = new Padding(3, 0, 3, 0);
		((Control)ev).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EA();
		((Control)ev).Size = new Size(130, 25);
		((Control)ev).TabIndex = 1;
		((Control)ev).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dx();
		((Control)ev).Click += new EventHandler(D);
		((Control)ew).Dock = (DockStyle)5;
		((Control)ew).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)1);
		((Control)ew).Location = new Point(3, 46);
		((Control)ew).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ea();
		((Control)ew).Size = new Size(130, 222);
		((Control)ew).TabIndex = 2;
		((Control)eX).Location = new Point(2, 3);
		((Control)eX).Margin = new Padding(2);
		((Control)eX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EB();
		((Control)eX).Size = new Size(65, 21);
		((Control)eX).TabIndex = 0;
		((Control)eX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Eb();
		((ButtonBase)eX).UseVisualStyleBackColor = true;
		((Control)ex).Location = new Point(72, 0);
		((Control)ex).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EC();
		((Control)ex).Size = new Size(45, 25);
		((Control)ex).TabIndex = 1;
		((Control)ex).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cv();
		ex.TextAlign = (ContentAlignment)64;
		((Control)eY).Location = new Point(121, 3);
		((TextBoxBase)eY).MaxLength = 30;
		((Control)eY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ec();
		((Control)eY).Size = new Size(92, 22);
		((Control)eY).TabIndex = 1;
		((Control)ey).Location = new Point(216, 2);
		((Control)ey).Margin = new Padding(1);
		((Control)ey).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ED();
		((Control)ey).Size = new Size(18, 23);
		ey.SizeMode = (PictureBoxSizeMode)4;
		ey.TabIndex = 4;
		ey.TabStop = false;
		((Control)eZ).Location = new Point(241, 0);
		((Control)eZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ed();
		((Control)eZ).Size = new Size(47, 25);
		((Control)eZ).TabIndex = 2;
		((Control)eZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EE();
		eZ.TextAlign = (ContentAlignment)64;
		((ComboBox)ez).DrawMode = (DrawMode)1;
		((ListControl)ez).FormattingEnabled = true;
		((Control)ez).Location = new Point(290, 3);
		((Control)ez).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ee();
		((Control)ez).Size = new Size(117, 23);
		((Control)ez).TabIndex = 2;
		((Control)FA).Location = new Point(414, 0);
		((Control)FA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EF();
		((Control)FA).Size = new Size(44, 25);
		((Control)FA).TabIndex = 3;
		((Control)FA).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ef();
		FA.TextAlign = (ContentAlignment)64;
		((Control)Fa).Location = new Point(461, 3);
		((Control)Fa).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EG();
		((Control)Fa).Size = new Size(72, 22);
		((Control)Fa).TabIndex = 3;
		((Control)FB).Location = new Point(536, 2);
		((Control)FB).Margin = new Padding(1);
		((Control)FB).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Eg();
		((Control)FB).Size = new Size(18, 23);
		FB.SizeMode = (PictureBoxSizeMode)4;
		FB.TabIndex = 4;
		FB.TabStop = false;
		((Control)Fb).Location = new Point(560, 0);
		((Control)Fb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EH();
		((Control)Fb).Size = new Size(82, 25);
		((Control)Fb).TabIndex = 5;
		((Control)Fb).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Eh();
		Fb.TextAlign = (ContentAlignment)64;
		((ComboBox)FC).DrawMode = (DrawMode)1;
		((ListControl)FC).FormattingEnabled = true;
		((Control)FC).Location = new Point(646, 3);
		((Control)FC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EI();
		((Control)FC).Size = new Size(67, 23);
		((Control)FC).TabIndex = 5;
		((Control)Fc).Location = new Point(719, 0);
		((Control)Fc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ei();
		((Control)Fc).Size = new Size(83, 25);
		((Control)Fc).TabIndex = 6;
		((Control)Fc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EJ();
		Fc.TextAlign = (ContentAlignment)64;
		((ComboBox)FD).DrawMode = (DrawMode)1;
		((ListControl)FD).FormattingEnabled = true;
		((Control)FD).Location = new Point(806, 3);
		((Control)FD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ej();
		((Control)FD).Size = new Size(97, 23);
		((Control)FD).TabIndex = 6;
		((Control)Fd).Location = new Point(73, 28);
		((Control)Fd).Margin = new Padding(4, 3, 4, 3);
		((Control)Fd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EK();
		((Control)Fd).Size = new Size(388, 54);
		((Control)Fd).TabIndex = 7;
		((Control)FE).Location = new Point(3, 85);
		((Control)FE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ek();
		((Control)FE).Size = new Size(928, 238);
		((Control)FE).TabIndex = 8;
		((Control)FE).Visible = false;
		((Control)Fe).Location = new Point(3, 187);
		((Control)Fe).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EL();
		((Control)Fe).Size = new Size(928, 30);
		((Control)Fe).TabIndex = 1;
		((Control)Fe).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dl();
		Fe.TextAlign = (ContentAlignment)32;
		((ScrollableControl)FF).AutoScroll = true;
		((Control)FF).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f);
		((Control)FF).Location = new Point(3, 325);
		((Control)FF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.El();
		((Control)FF).Size = new Size(924, 225);
		((Control)FF).TabIndex = 2;
		((Control)Ff).Location = new Point(3, 25);
		((Control)Ff).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.EM();
		((Control)Ff).Size = new Size(63, 60);
		((Control)Ff).TabIndex = 11;
		((Control)Ff).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG();
		Ff.TextAlign = (ContentAlignment)64;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)eS);
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Em();
		((Control)this).Size = new Size(1072, 550);
		((Control)((SplitContainer)eS).Panel1).ResumeLayout(false);
		((Control)((SplitContainer)eS).Panel2).ResumeLayout(false);
		((ISupportInitialize)eS).EndInit();
		((Control)eS).ResumeLayout(false);
		((Control)((SplitContainer)es).Panel1).ResumeLayout(false);
		((Control)((SplitContainer)es).Panel2).ResumeLayout(false);
		((ISupportInitialize)es).EndInit();
		((Control)es).ResumeLayout(false);
		((Control)eT).ResumeLayout(false);
		((Control)eT).PerformLayout();
		((Control)eu).ResumeLayout(false);
		((Control)eu).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[CompilerGenerated]
	private void N()
	{
		if (eF != 0)
		{
			((SplitContainer)eS).SplitterDistance = eF;
		}
		if (ef != 0)
		{
			((SplitContainer)es).SplitterDistance = ef;
		}
		ej = false;
		((ScrollableControl)eW).AutoScroll = true;
		((ScrollableControl)ew).AutoScroll = true;
		eW.H();
		ew.H();
	}

	[CompilerGenerated]
	private bool c(CANFrameModel P_0)
	{
		if (P_0 != eE)
		{
			return P_0.Name == ((Control)eY).Text;
		}
		return false;
	}
}
