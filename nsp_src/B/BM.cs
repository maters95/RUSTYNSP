using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using C;
using D;
using ImageMagick;
using NSP.Internet;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using NSP.UserInterface.Forms;
using NexusUpdaterAWS;
using a;
using b;
using c;
using crc;

namespace B
{
	internal class BM : Form
	{
		private delegate void A(object P_0, ElapsedEventArgs P_1);

		private enum a
		{
			BpC,
			Bpc,
			BpD,
			Bpd,
			BpE,
			Bpe
		}

		private delegate void B(object P_0, ElapsedEventArgs P_1);

		internal enum b
		{
			BpF,
			Bpf,
			BpG
		}

		private struct C
		{
			internal string Bpg;

			internal string BpH;

			internal bW Bph;

			internal Framework BpI;

			internal bV.A Bpi;

			internal string BpJ;

			internal bool Bpj;
		}

		private struct c
		{
			internal C BpK;

			internal UpdateOutcomes Bpk;

			internal string[] BpL;
		}

		internal enum D
		{
			Bpl = 1,
			BpM = 2,
			Bpm = 4,
			BpN = 8,
			Bpn = 0x10,
			BpO = 0x20,
			Bpo = 0x40,
			BpP = 0x80,
			Bpp = 0x100,
			BpQ = 0x200,
			Bpq = 0x400,
			BpR = 0x800,
			Bpr = 0x1000
		}

		internal class d
		{
			internal global::A.F BpS;

			internal BackgroundWorker Bps;
		}

		private delegate void E(object P_0, EventArgs P_1);

		private delegate void e(object P_0, global::A.E P_1);

		private class F
		{
			internal Framework BpT;

			internal global::A.F Bpt;
		}

		private class f
		{
			internal bV.A BpU;

			internal Framework Bpu;

			internal global::A.F BpV;
		}

		private class G
		{
			internal Framework Bpv;

			internal global::A.F BpW;
		}

		private struct g
		{
			internal BE Bpw;

			internal bool BpX;

			internal bool Bpx;

			internal bool BpY;
		}

		private struct H
		{
			internal bool Bpy;

			internal string BpZ;

			internal string Bpz;

			internal BE BQA;

			internal bool BQa;

			internal bool BQB;

			internal bool BQb;

			internal bool BQC;
		}

		private struct h
		{
			internal int BQc;

			internal int BQD;
		}

		private class I
		{
			internal BE BQd;

			internal string BQE;

			internal string BQe;
		}

		private delegate void i(object P_0, ElapsedEventArgs P_1);

		private class J
		{
			internal List<CY> BQF;

			internal List<CY> BQf;

			internal Dictionary<bt, List<CY>> BQG;

			internal string BQg;
		}

		private struct j
		{
			internal string BQH;

			internal bW BQh;

			internal Framework BQI;

			internal Framework BQi;

			internal string BQJ;

			internal bool BQj;

			internal bV.A BQK;

			internal string BQk;

			internal bool BQL;
		}

		private struct K
		{
			internal j BQl;

			internal UpdateOutcomes BQM;

			internal string[] BQm;
		}

		private struct k
		{
			internal global::A.F BQN;

			internal Framework BQn;

			internal UpdateOutcomes BQO;

			internal string[] BQo;
		}

		private struct L
		{
			internal global::A.F BQP;

			internal UpdateOutcomes BQp;

			internal string[] BQQ;
		}

		private class l
		{
			internal global::A.F BQq;

			internal bV.A BQR;
		}

		private delegate void M(object P_0, ElapsedEventArgs P_1);

		private struct m
		{
			internal UpdateOutcomes BQr;

			internal string[] BQS;
		}

		private struct N
		{
			internal bool BQs;

			internal string BQT;

			internal bV.A BQt;

			internal string BQU;

			internal string BQu;

			internal bW BQV;

			internal bool BQv;

			internal string BQW;
		}

		private struct n
		{
			internal N BQw;

			internal UpdateOutcomes BQX;

			internal string[] BQx;
		}

		private delegate void O(object P_0, EventArgs P_1);

		private struct o
		{
			internal string BQY;

			internal bool BQy;
		}

		private struct P
		{
			internal bool BQZ;

			internal string BQz;

			internal bool BqA;

			internal string Bqa;
		}

		private struct p
		{
			internal N BqB;

			internal UpdateOutcomes Bqb;

			internal string[] BqC;
		}

		private struct Q
		{
			internal bool Bqc;

			internal string BqD;
		}

		private class q
		{
			internal bV.A Bqd;

			internal Framework BqE;
		}

		private struct R
		{
			internal Framework Bqe;

			internal bool BqF;

			internal bool Bqf;
		}

		internal enum r
		{
			BqG,
			Bqg,
			BqH,
			Bqh
		}

		internal enum S
		{
			BqI,
			Bqi,
			BqJ
		}

		private class s
		{
			internal bool Bqj;

			internal string BqK;
		}

		private delegate void T(object P_0, RunWorkerCompletedEventArgs P_1);

		[CompilerGenerated]
		private static class t
		{
			public static ProgressChangedEventHandler Bqk;

			public static DoWorkEventHandler BqL;

			public static EventHandler Bql;

			public static EventHandler BqM;

			public static EventHandler Bqm;

			public static EventHandler BqN;

			public static EventHandler Bqn;

			public static EventHandler BqO;

			public static EventHandler Bqo;
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class U
		{
			public static readonly U BqP = new U();

			public static Func<KeyValuePair<string, DataTableObject>, bool> Bqp;

			public static Action BqQ;

			public static Action Bqq;

			public static Action BqR;

			public static Action Bqr;

			public static Action BqS;

			public static Func<BN, bool> Bqs;

			public static Func<BN, bool> BqT;

			public static Func<BN, bool> Bqt;

			public static Func<BN, bool> BqU;

			internal bool A(KeyValuePair<string, DataTableObject> P_0)
			{
				return P_0.Value.IsErrorTable;
			}

			internal void A()
			{
				((Control)SX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OV();
			}

			internal void a()
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDz());
			}

			internal void B()
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdA());
			}

			internal void b()
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bda());
			}

			internal void C()
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdB());
			}

			internal bool A(BN P_0)
			{
				return P_0.B() == Bm.tX;
			}

			internal bool a(BN P_0)
			{
				return P_0.B() == Bm.tw;
			}

			internal bool B(BN P_0)
			{
				return P_0.B() == Bm.tX;
			}

			internal bool b(BN P_0)
			{
				return P_0.B() == Bm.tw;
			}
		}

		[CompilerGenerated]
		private sealed class u
		{
			public float Bqu;
		}

		[CompilerGenerated]
		private sealed class V
		{
			public uint BqV;

			public string Bqv;

			public u BqW;

			internal void A()
			{
				((Control)SX).Text = string.Concat(new string[7]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdb(),
					BqV.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo(),
					Bqv,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ie(),
					string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdC(), (object)BqW.Bqu),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdc()
				});
			}
		}

		internal static Dictionary<int, Bl> Qj = new Dictionary<int, Bl>();

		[CompilerGenerated]
		private static EventHandler QK;

		private static Timer Qk = new Timer();

		private static bool QL = true;

		private static Timer Ql = new Timer();

		private static a QM = BM.a.BpC;

		private static bool Qm = false;

		internal static string QN = string.Empty;

		internal static Framework Qn;

		internal static b QO = BM.b.BpF;

		[CompilerGenerated]
		private EventHandler Qo;

		internal static bool QP = false;

		internal static readonly string Qp = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qg();

		internal static BM QQ;

		internal static readonly string Qq = Environment.GetFolderPath((SpecialFolder)5);

		internal static readonly string QR = Environment.GetFolderPath((SpecialFolder)26);

		internal static readonly string Qr = Environment.GetFolderPath((SpecialFolder)35);

		internal static readonly string QS = QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tC();

		internal static readonly string Qs = QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tc();

		internal static readonly string QT = QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tD();

		internal static readonly string Qt = QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.td();

		internal static readonly string QU = QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tE();

		internal static readonly string Qu = QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.te();

		internal static readonly string QV = QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tF();

		internal static readonly string Qv = QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tf();

		internal static readonly string QW = QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tG();

		internal static readonly string Qw = Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tg();

		internal static readonly string QX = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tH();

		internal static readonly string Qx = Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.th();

		internal static readonly string QY = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tI();

		internal static readonly string Qy = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ti();

		internal static string QZ = string.Empty;

		internal static Framework Qz;

		internal static MenuNode qA;

		internal static MenuNode qa;

		internal static Dictionary<string, CO> qB = new Dictionary<string, CO>();

		internal static object qb = new object();

		internal static Cn qC = null;

		internal static MenuNode qc = null;

		internal static List<int> qD = new List<int>();

		internal StatsReporter qd = new StatsReporter();

		private static OpenFileDialog qE = new OpenFileDialog();

		internal static bool qe = false;

		internal static DataIdAndAttrId qF;

		internal static HashSet<DataIdAndAttrId> qf = new HashSet<DataIdAndAttrId>();

		internal static bi qG;

		internal static bI qg;

		private static string qH = null;

		internal static object qh = new object();

		internal static volatile int qI = 0;

		internal bool qi;

		internal string qJ;

		internal string qj;

		internal string qK;

		internal string qk;

		internal bool qL;

		internal global::A.k ql;

		internal Dictionary<int, int> qM;

		internal Dictionary<int, List<int>> qm;

		internal string qN;

		internal bool qn;

		internal string qO;

		internal bool qo;

		internal string qP;

		internal bool qp;

		internal bool qQ;

		internal bool qq = true;

		internal List<string> qR = new List<string>();

		internal bool qr;

		internal string qS;

		internal bW qs;

		internal bool qT;

		internal string qt;

		internal string qU;

		internal bool qu;

		internal string qV;

		internal string qv;

		public static volatile bool qW = false;

		private static bool qw = false;

		private static bool qX = false;

		internal static BackgroundWorker qx = null;

		internal static bool qY = false;

		[CompilerGenerated]
		private static EventHandler qy;

		private static Control qZ = null;

		internal static BX qz;

		internal static aZ RA;

		private static BZ Ra;

		private static Bk RB;

		internal static bool Rb = false;

		private IContainer RC;

		private MenuStrip Rc;

		private ToolStripMenuItem RD;

		private ToolStripMenuItem Rd;

		private ToolStripMenuItem RE;

		private ToolStripMenuItem Re;

		private ToolStripMenuItem RF;

		private ToolStripMenuItem Rf;

		internal ToolStrip RG;

		private ae Rg;

		private ae RH;

		private aF Rh;

		private aF RI;

		internal ToolStripMenuItem Ri;

		private ToolStripMenuItem RJ;

		private PictureBox Rj;

		private ToolStripSeparator RK;

		private ToolStripSeparator Rk;

		internal ToolStripMenuItem RL;

		internal ToolStripMenuItem Rl;

		internal ToolStripMenuItem RM;

		private ToolStripMenuItem Rm;

		private ToolStripMenuItem RN;

		private ToolStripMenuItem Rn;

		private ToolStripMenuItem RO;

		private ToolStripMenuItem Ro;

		private ToolStripMenuItem RP;

		private ToolStripMenuItem Rp;

		private ToolStripMenuItem RQ;

		private aF Rq;

		private ToolStripMenuItem RR;

		private ToolStripMenuItem Rr;

		private ToolStripMenuItem RS;

		private ToolStripMenuItem Rs;

		private ToolStripMenuItem RT;

		private ToolStripMenuItem Rt;

		private ToolStripMenuItem RU;

		private au Ru;

		internal aV RV;

		private ToolStripMenuItem Rv;

		private ToolStripMenuItem RW;

		private ToolStripMenuItem Rw;

		private ToolStripButton RX;

		internal ToolStripButton Rx;

		private ToolStripButton RY;

		private ToolStripButton Ry;

		internal ToolStripButton RZ;

		private ToolStripButton Rz;

		private ToolStripButton rA;

		private ToolStripMenuItem ra;

		private ToolStripMenuItem rB;

		internal ToolStripButton rb;

		private ToolStripSeparator rC;

		internal ToolStripMenuItem rc;

		private ToolStripMenuItem rD;

		private ToolStripButton rd;

		private aU rE;

		private aT re;

		private av rF;

		private @as rf;

		private ToolStripButton rG;

		private at rg;

		private ToolStripMenuItem rH;

		private ToolStripButton rh;

		private Label rI;

		private ToolStripSeparator ri;

		private ToolStripMenuItem rJ;

		private ToolStripMenuItem rj;

		private ToolStripMenuItem rK;

		private ToolStripMenuItem rk;

		internal ac rL;

		internal cR rl;

		internal ToolStripMenuItem rM;

		internal ToolStripMenuItem rm;

		internal ToolStripButton rN;

		internal aC rn;

		internal ar rO;

		private ToolStripMenuItem ro;

		internal ToolStripMenuItem rP;

		private ToolStripButton rp;

		private SplitContainer rQ;

		internal aF rq;

		internal ToolStripMenuItem rR;

		private ToolStripSeparator rr;

		private ToolStripMenuItem rS;

		private ToolStripMenuItem rs;

		private ToolStripMenuItem rT;

		internal aS rt;

		private ToolStripMenuItem rU;

		private ToolStripMenuItem ru;

		private ToolStripMenuItem rV;

		private ToolStripMenuItem rv;

		private ToolStripSeparator rW;

		internal SplitContainer rw;

		private ToolStripMenuItem rX;

		private ToolStripMenuItem rx;

		private ToolStripMenuItem rY;

		private ToolStripMenuItem ry;

		private ToolStripMenuItem rZ;

		private ToolStripMenuItem rz;

		private ToolStripMenuItem SA;

		private ToolStripMenuItem Sa;

		private StartupOptionsPanel SB;

		internal ToolStripMenuItem Sb;

		internal ToolStripDropDownButton SC;

		internal ToolStripMenuItem Sc;

		private ToolStripButton SD;

		private ToolStripButton Sd;

		internal const int SE = 40;

		private static bool Se = true;

		internal static Stopwatch SF = new Stopwatch();

		private static bool Sf = false;

		internal static bool SG = false;

		private static bool Sg = false;

		private static global::A.t SH = new global::A.t();

		[CompilerGenerated]
		private static EventHandler Sh;

		internal static List<d> SI = new List<d>();

		private static object Si = new object();

		private static System.DateTime SJ = System.DateTime.Now;

		internal static bool Sj = false;

		private static string SK = null;

		private static bool Sk = false;

		private bool SL;

		internal static bool Sl = false;

		internal static HashSet<DataIdAndAttrId> SM = new HashSet<DataIdAndAttrId>();

		internal static HashSet<DataIdAndAttrId> Sm = new HashSet<DataIdAndAttrId>();

		private static int SN = -1;

		private static int Sn = -1;

		private static ushort[] SO = new ushort[56];

		private static int So = 0;

		private static List<BN> SP = new List<BN>();

		private static int Sp = 0;

		private static Timer SQ = null;

		private static bool Sq = false;

		internal static PictureBox SR = null;

		internal static bool Sr = false;

		private static Panel SS;

		private const int Ss = 600;

		internal static List<MenuNode> ST = new List<MenuNode>();

		private static bool St = false;

		private static byte[] SU = null;

		private static global::A.k[] Su = null;

		private static string SV = null;

		private static string Sv = null;

		private static Panel SW = new Panel();

		private static ProgressBar Sw = new ProgressBar();

		private static Label SX = new Label();

		private const int Sx = 500;

		private const int SY = 90;

		private const int Sy = 20;

		private const int SZ = 15;

		private const int Sz = 50;

		private const int sA = 20;

		private const int sa = 25;

		private const int sB = 650;

		private const int sb = 30;

		private const int sC = 300;

		private static Panel sc = new Panel();

		private static Label sD = new Label();

		private static List<ProgressBar> sd = new List<ProgressBar>();

		private static List<Label> sE = new List<Label>();

		private static List<string> se = null;

		private static int sF = 0;

		private static int sf = -1;

		private static int sG = 0;

		private static Image sg;

		private static Image sH;

		private static float sh = 0.7f;

		internal static bool sI = false;

		internal static string si;

		internal static BJ sJ;

		internal static x sj;

		private const int sK = 52;

		private const int sk = 10;

		private const int sL = 10;

		private static int[] sl;

		private int[,,] sM = new int[10, 10, 52];

		private int[,,] sm = new int[10, 10, 52];

		private int[,,] sN = new int[10, 10, 52];

		private float[,] sn = new float[10, 10];

		private int[,] sO = new int[10, 10];

		private int[,] so = new int[10, 10];

		private int[,] sP = new int[10, 10];

		private float sp;

		private int[] sQ = new int[10];

		private int sq;

		private int[] sR = new int[10];

		private int[,] sr = new int[10, 10];

		private static float sS;

		internal static int ss;

		internal static int sT;

		internal static int st;

		internal static int sU;

		internal static FormWindowState su;

		private static bool sV;

		private static bool sv;

		private static bool sW;

		internal static bool sw;

		internal static bool sX;

		private static bool sx;

		private static HashSet<DataIdAndAttrId> sY;

		private static HashSet<DataIdAndAttrId> sy;

		private static HashSet<DataIdAndAttrId> sZ;

		private static Timer sz;

		private static Stopwatch TA;

		private static object Ta;

		private static bool TB;

		private static bool Tb;

		private static System.DateTime TC;

		private static bool Tc;

		[CompilerGenerated]
		private static EventHandler TD;

		private static bool Td;

		internal static CS TE;

		internal const int Te = 10;

		private static OpenFileDialog TF;

		internal static Cm Tf;

		internal static Cm TG;

		internal const string Tg = "Auto Logs";

		internal const string TH = "Logs";

		private static OpenFileDialog Th;

		internal static string TI;

		private static FileSystemWatcher Ti;

		private static int TJ;

		private static FileSystemWatcher Tj;

		private static Cs TK;

		private static SaveFileDialog Tk;

		private static bool TL;

		private static FileSystemWatcher Tl;

		private static bool TM;

		private static List<string> Tm;

		[CompilerGenerated]
		private static EventHandler TN;

		internal static r Tn;

		internal static bool TO;

		internal static bool To;

		internal const S TP = BM.S.BqI;

		internal static S Tp;

		internal const bool TQ = true;

		internal const bool Tq = true;

		internal const int TR = 90;

		internal const int Tr = 90;

		internal const int TS = 0;

		internal const int Ts = 39;

		internal const bool TT = false;

		internal static bool Tt;

		internal static bool TU;

		internal static int Tu;

		internal static int TV;

		internal static int Tv;

		internal static int TW;

		internal static bool Tw;

		internal static float TX;

		internal static float Tx;

		internal static float TY;

		internal static Color Ty;

		internal static Color TZ;

		internal static Color Tz;

		internal static Color tA;

		internal static Color ta;

		internal static Color tB;

		internal static Color tb;

		internal static Color tC;

		internal static Color tc;

		internal static Color tD;

		internal static Color td;

		internal static Color tE;

		internal static Color te;

		internal static Color tF;

		internal static Color tf;

		internal static Color tG;

		internal static Color tg;

		internal static Color tH;

		internal static Color th;

		internal static Color tI;

		internal static Color ti;

		internal static Color tJ;

		internal static Color tj;

		internal static Color tK;

		internal static Color tk;

		internal static Color tL;

		internal static Color tl;

		internal static Color tM;

		internal static Color tm;

		internal static Color tN;

		internal static Color tn;

		internal static Color tO;

		internal static Color to;

		internal static Color tP;

		internal static Color tp;

		internal static Color tQ;

		internal static Color tq;

		internal static Image tR;

		internal static Image tr;

		[CompilerGenerated]
		private static EventHandler tS;

		private static Label ts;

		private static TreeNode tT;

		private static MenuNode tt;

		private static bool tU;

		private static int tu;

		internal static bool tV;

		internal const string tv = "You must enter a unique name or identifier for the vehicle (such as the registration plate). This will be used for creating a unique folder in the directory structure, where map files, log files and resources will be saved for the vehicle.";

		[SpecialName]
		[CompilerGenerated]
		internal static void A(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = QK;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref QK, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void a(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = QK;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref QK, val3, val2);
			}
			while (val != val2);
		}

		internal static void A()
		{
			try
			{
				if (!File.Exists(Qt))
				{
					return;
				}
				StreamReader val = File.OpenText(Qt);
				try
				{
					Bl bl = null;
					int num = -1;
					string text;
					while ((text = ((TextReader)val).ReadLine()) != null)
					{
						if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mY()))
						{
							num = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mY().Length));
							bl = new Bl();
							bl.QH = num;
							Qj[num] = bl;
						}
						else if (num != -1 && Qj.ContainsKey(num))
						{
							if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.my()))
							{
								int num2 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.my().Length));
								Qj[num].Qh = num2;
							}
							else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mZ()))
							{
								int num3 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mZ().Length));
								Qj[num].QI = num3;
							}
							else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mz()))
							{
								int num4 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mz().Length));
								Qj[num].Qi = num4;
							}
							else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NA()))
							{
								int num5 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NA().Length));
								Qj[num].QJ = num5;
							}
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
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Na() + ex.Message, true);
			}
		}

		internal static void a()
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (!Directory.Exists(QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
				{
					Directory.CreateDirectory(QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
				}
				((Stream)File.Create(Qt)).Close();
				List<string> val = new List<string>();
				Enumerator<int, Bl> enumerator = Qj.Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						Bl bl = Qj[current];
						val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mY() + current);
						val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.my() + bl.Qh);
						val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mZ() + bl.QI);
						val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mz() + bl.Qi);
						val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NA() + bl.QJ);
						val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				File.AppendAllLines(Qt, (System.Collections.Generic.IEnumerable<string>)val);
			}
			catch (System.Exception ex)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NB() + ex.Message, true);
			}
		}

		internal static void A(int P_0, int P_1, int P_2, int P_3, int P_4)
		{
			Bl bl;
			if (Qj.ContainsKey(P_0))
			{
				bl = Qj[P_0];
			}
			else
			{
				bl = new Bl();
				bl.QH = P_0;
			}
			bl.Qh = P_1;
			bl.QI = P_2;
			bl.Qi = P_3;
			bl.QJ = P_4;
			if (!Qj.ContainsKey(P_0))
			{
				Qj.Add(P_0, bl);
			}
			if (QK != null)
			{
				QK.Invoke((object)null, (EventArgs)null);
			}
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			bg bg = new bg();
			((Form)bg).ShowDialog((IWin32Window)(object)this);
			((Component)bg).Dispose();
		}

		internal static void A(object P_0, ProgressChangedEventArgs P_1)
		{
			string[] array = (P_1.UserState as string).Split('_', (StringSplitOptions)0);
			string text = array[1];
			if (!bj.abK)
			{
				text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nb();
			}
			if (array[0] == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NC())
			{
				QQ.rO.A(ar.A.Bnm, P_1.ProgressPercentage, array[0], text);
			}
			else
			{
				QQ.rO.A(ar.A.BnN, P_1.ProgressPercentage, array[0], text);
			}
		}

		internal void a(object P_0, EventArgs P_1)
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Invalid comparison between Unknown and I4
			if (((ToolStripItem)rO).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gB())
			{
				bj.A(false);
			}
			else
			{
				if (bj.a(false))
				{
					return;
				}
				try
				{
					if (bj.abJ)
					{
						if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nc(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ND(), (MessageBoxButtons)4) == 6)
						{
							bj.B(false);
						}
					}
					else
					{
						bj.b(true);
					}
				}
				catch (System.Exception ex)
				{
					global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nd() + ex.Message, true);
				}
			}
			rO.D();
		}

		private void B()
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			Qk.Interval = 1800000.0;
			Qk.SynchronizingObject = (ISynchronizeInvoke)(object)this;
			Qk.Elapsed += new ElapsedEventHandler(A);
			Qk.AutoReset = true;
			Qk.Enabled = true;
			Qk.Start();
		}

		private void A(object P_0, ElapsedEventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					A a = A;
					((Control)this).Invoke((System.Delegate)a, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (QL)
			{
				QL = false;
			}
			else
			{
				bj.A(true);
			}
		}

		private void b()
		{
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Expected O, but got Unknown
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Invalid comparison between Unknown and I4
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Expected O, but got Unknown
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected O, but got Unknown
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Invalid comparison between Unknown and I4
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected O, but got Unknown
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Expected O, but got Unknown
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			if (Qz == null || !Qz.c() || !A(Qz.aXc, true))
			{
				return;
			}
			bool flag = false;
			Setting setting = Qz.A(12);
			if (setting != null && setting.ax() != 0)
			{
				flag = true;
			}
			if (flag)
			{
				if (QM == BM.a.BpC)
				{
					QM = BM.a.Bpc;
					bool flag2 = false;
					do
					{
						if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NE(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ne(), (MessageBoxButtons)4, (MessageBoxIcon)16, (MessageBoxDefaultButton)0, new string[2]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NF(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nf()
						}) == 6)
						{
							((FileDialog)TF).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NG();
							((FileDialog)TF).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ng();
							if ((int)((CommonDialog)TF).ShowDialog((IWin32Window)(object)this) != 1)
							{
								continue;
							}
							bW bW = Cq.a(((FileDialog)TF).FileName);
							if (bW != null)
							{
								if (bW.axS == Qz.awZ && bW.axs == Qz.awz)
								{
									if (bW.axT == Qz.aXA)
									{
										flag2 = true;
										A(null, ((FileDialog)TF).FileName, bW, true);
									}
									else
									{
										bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NH(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
									}
								}
								else
								{
									bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nh(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
								}
							}
							else
							{
								bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NI(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
							}
							continue;
						}
						flag2 = true;
						BackgroundWorker val = new BackgroundWorker
						{
							WorkerReportsProgress = true
						};
						val.DoWork += new DoWorkEventHandler(r);
						object obj = BM.t.Bqk;
						if (obj == null)
						{
							ProgressChangedEventHandler val2 = a;
							BM.t.Bqk = val2;
							obj = (object)val2;
						}
						val.ProgressChanged += (ProgressChangedEventHandler)obj;
						val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(S);
						C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ni());
						bool flag3 = true;
						val.RunWorkerAsync((object)flag3);
					}
					while (!flag2);
				}
				else if (QM == BM.a.Bpd)
				{
					QM = BM.a.BpE;
					BackgroundWorker val3 = new BackgroundWorker
					{
						WorkerReportsProgress = true
					};
					val3.DoWork += new DoWorkEventHandler(A);
					object obj2 = BM.t.Bqk;
					if (obj2 == null)
					{
						ProgressChangedEventHandler val4 = a;
						BM.t.Bqk = val4;
						obj2 = (object)val4;
					}
					val3.ProgressChanged += (ProgressChangedEventHandler)obj2;
					val3.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NJ());
					bool flag4 = false;
					val3.RunWorkerAsync((object)flag4);
				}
			}
			else
			{
				QM = BM.a.BpC;
			}
		}

		private void C()
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			Ql.Interval = 1000.0;
			Ql.SynchronizingObject = (ISynchronizeInvoke)(object)this;
			Ql.Elapsed += new ElapsedEventHandler(a);
			Ql.AutoReset = true;
			Ql.Enabled = true;
			Ql.Start();
		}

		private void a(object P_0, ElapsedEventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					B b = a;
					((Control)this).Invoke((System.Delegate)b, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			this.b();
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Invalid comparison between Unknown and I4
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nj(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				BackgroundWorker val = new BackgroundWorker
				{
					WorkerReportsProgress = true
				};
				val.DoWork += new DoWorkEventHandler(A);
				object obj = BM.t.Bqk;
				if (obj == null)
				{
					ProgressChangedEventHandler val2 = a;
					BM.t.Bqk = val2;
					obj = (object)val2;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj;
				val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NJ());
				bool flag = true;
				val.RunWorkerAsync((object)flag);
			}
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			global::A.A.a(Qz.aXc, 60000u);
			Qm = true;
			int num = 0;
			while (Qm)
			{
				Thread.Sleep(500);
				num++;
				int num2 = Math.Min(num, 100);
				val.ReportProgress(num2);
			}
			global::A.A.I(Qz.aXc);
			val.ReportProgress(100);
			bool flag = (bool)P_1.Argument;
			P_1.Result = flag;
		}

		private void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			P();
			if (!(bool)P_1.Result)
			{
				QM = BM.a.Bpe;
				A(null, -1, false);
			}
		}

		private bool A(global::A.F P_0, out bool P_1)
		{
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Invalid comparison between Unknown and I4
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Invalid comparison between Unknown and I4
			//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Invalid comparison between Unknown and I4
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			P_1 = false;
			if (qP != null && (CZ.A(P_0, true) || qp || qQ))
			{
				if (global::A.A.c().Count == 1)
				{
					A(qP, global::A.A.c()[0], qp, true, qq, qR);
					return true;
				}
				if (!qW)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NK(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				P_1 = true;
				return false;
			}
			if (P_0.aH == 22)
			{
				if (global::A.A.c().Count != 1)
				{
					if (!qW)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nk(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NL(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					P_1 = true;
					return false;
				}
				if (qP != null && qW)
				{
					a(P_0);
					return true;
				}
				if (!qW && (int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nl(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NM(), (MessageBoxButtons)4) == 6)
				{
					a(P_0);
					return true;
				}
				P_1 = true;
				b(true);
				return false;
			}
			if (bx.A(P_0.aH))
			{
				if (P_0.ai)
				{
					if (!qW && (int)bE.A((IWin32Window)(object)this, string.Concat(new string[9]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nm(),
						P_0.aH.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NN(),
						P_0.ah.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nn(),
						P_0.aJ.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NO(),
						P_0.ao,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.No()
					}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NP(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
					{
						Z(P_0, null);
						return true;
					}
				}
				else if (P_0.ae < 3)
				{
					if (qi)
					{
						a(CZ.Bdl + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + qK, P_0);
						return true;
					}
					if (!qW)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Np(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NQ(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					P_1 = true;
				}
			}
			else if (CZ.A(P_0, true) && !qW)
			{
				string text = ((P_0.aH != 21) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nq() : string.Empty);
				if ((int)bE.A((IWin32Window)(object)this, string.Concat(new string[10]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NR(),
					P_0.aH.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NN(),
					P_0.ah.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nn(),
					P_0.aJ.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NO(),
					P_0.ao,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq(),
					text
				}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NP(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
				{
					Z(P_0, null);
					return true;
				}
			}
			return false;
		}

		[SpecialName]
		[CompilerGenerated]
		internal void B(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Qo;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref Qo, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal void b(EventHandler P_0)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			EventHandler val = Qo;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref Qo, val3, val2);
			}
			while (val != val2);
		}

		private void b(object P_0, EventArgs P_1)
		{
			if (Qn == null)
			{
				c((object)null, (EventArgs)null);
				return;
			}
			if (QO == BM.b.BpF)
			{
				QO = BM.b.Bpf;
			}
			else if (QO == BM.b.Bpf)
			{
				QO = BM.b.BpG;
			}
			else
			{
				QO = BM.b.BpF;
			}
			((ToolStripItem)rt).Invalidate();
			QP = true;
			rL.A(false, true, true, false);
			rL.B(false);
			if (Qn != null)
			{
				rL.b(false);
			}
			if (Qo != null)
			{
				Qo.Invoke((object)null, (EventArgs)null);
			}
			rl.H();
			QP = false;
		}

		private void C(object P_0, EventArgs P_1)
		{
			w();
			d();
			Qn = null;
			QO = BM.b.BpF;
			qf.Clear();
			a(false);
			QN = string.Empty;
			A(true);
			rt.a();
			ToolStripMenuItem obj = rT;
			bool enabled = (((ToolStripItem)rV).Enabled = false);
			((ToolStripItem)obj).Enabled = enabled;
			ToolStripMenuItem obj2 = rs;
			enabled = (((ToolStripItem)ru).Enabled = false);
			((ToolStripItem)obj2).Enabled = enabled;
		}

		private void c(object P_0, EventArgs P_1)
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Invalid comparison between Unknown and I4
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			if (Qz == null)
			{
				return;
			}
			((FileDialog)TF).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nr();
			((FileDialog)TF).Filter = bx.a();
			if ((int)((CommonDialog)TF).ShowDialog((IWin32Window)(object)this) == 1)
			{
				bW bW = Cq.a(((FileDialog)TF).FileName);
				if (bW != null)
				{
					A(null, ((FileDialog)TF).FileName, bW);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NI(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
		}

		private void A(string P_0, string P_1, bW P_2)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			C c = default(C);
			c.BpH = P_1;
			c.Bpg = P_0;
			c.Bph = P_2;
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.DoWork += new DoWorkEventHandler(a);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(a);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NS());
			val.RunWorkerAsync((object)c);
		}

		private void a(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			C c = (C)P_1.Argument;
			string text = c.Bpg;
			if (text == null && c.Bph != null)
			{
				text = bT.A(c.Bph.axS, c.Bph.axs, c.Bph.axT, c.Bph.axt, true);
			}
			val.ReportProgress(20);
			if (!string.IsNullOrEmpty(text) && c.Bph != null)
			{
				Framework framework = new Framework(text, c.Bph.axS, c.Bph.axs, c.Bph.axT);
				c.Bpi = framework.a();
				if (c.Bpi == bV.A.Brc)
				{
					val.ReportProgress(60);
					string text2;
					bool flag = new Cq(c.BpH, framework).A(out text2, false, false, true) && string.IsNullOrEmpty(text2);
					val.ReportProgress(70);
					framework.N();
					framework.a(framework.awj);
					framework.a((HashSet<DataIdAndAttrId>)null);
					Qz.A(null, framework, qf);
					Qz.A((HashSet<DataIdAndAttrId>)null);
					val.ReportProgress(90);
					c.BpI = framework;
					if (flag)
					{
						c.Bpj = true;
					}
					else
					{
						c.BpJ = text2;
						c.Bpj = false;
					}
				}
				else
				{
					c.Bpj = false;
				}
			}
			else
			{
				c.Bpi = bV.A.BrD;
				c.Bpj = false;
			}
			P_1.Result = c;
			Thread.Sleep(100);
			val.ReportProgress(100);
		}

		private void a(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Invalid comparison between Unknown and I4
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Invalid comparison between Unknown and I4
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Invalid comparison between Unknown and I4
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Invalid comparison between Unknown and I4
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Invalid comparison between Unknown and I4
			P();
			C c = (C)P_1.Result;
			bool flag = true;
			if (!c.Bpj)
			{
				flag = false;
				if (c.Bpi == bV.A.BrD)
				{
					BackgroundWorker val = new BackgroundWorker();
					object obj = BM.t.BqL;
					if (obj == null)
					{
						DoWorkEventHandler val2 = bj.D;
						BM.t.BqL = val2;
						obj = (object)val2;
					}
					val.DoWork += (DoWorkEventHandler)obj;
					val.WorkerReportsProgress = true;
					object obj2 = BM.t.Bqk;
					if (obj2 == null)
					{
						ProgressChangedEventHandler val3 = a;
						BM.t.Bqk = val3;
						obj2 = (object)val3;
					}
					val.ProgressChanged += (ProgressChangedEventHandler)obj2;
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ns());
					BackgroundWorker val4 = new BackgroundWorker();
					val4.DoWork += new DoWorkEventHandler(B);
					val4.RunWorkerCompleted += new RunWorkerCompletedEventHandler(B);
					val.RunWorkerAsync();
					val4.RunWorkerAsync((object)c);
					bj.abM = true;
				}
				else
				{
					string empty = string.Empty;
					if (c.Bpi == bV.A.Brd)
					{
						empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NT();
					}
					else if (c.Bpi == bV.A.BrE)
					{
						empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nt();
					}
					else
					{
						string text = bx.C(c.Bph.axS, c.Bph.axs);
						text = ((text != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
						empty = ((c.Bpi == bV.A.Bre) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NV() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)c.Bph.axT).ToString()) : ((!string.IsNullOrEmpty(c.BpJ)) ? c.BpJ : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NW() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)c.Bph.axT).ToString())));
					}
					if (true)
					{
						if ((int)bE.A((IWin32Window)(object)this, empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
						{
							while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1)
							{
								if (A(((FileDialog)qE).FileName, c))
								{
									return;
								}
							}
						}
					}
					else if ((int)bE.A((IWin32Window)(object)this, c.BpJ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NX(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48, (MessageBoxDefaultButton)256, new string[2]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nx(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NY()
					}) == 6)
					{
						while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1)
						{
							if (A(((FileDialog)qE).FileName, c))
							{
								return;
							}
						}
					}
					else
					{
						flag = true;
					}
				}
			}
			if (!flag)
			{
				return;
			}
			if (c.BpI.B() && c.BpI.b())
			{
				if ((int)c.BpI.A(true, true) == 2)
				{
					C((object)null, (EventArgs)null);
					return;
				}
				Qz.A(null, c.BpI, qf);
			}
			w();
			d();
			Qn = c.BpI;
			a(false);
			QN = c.BpH;
			A(true);
			rt.B();
			ToolStripMenuItem obj3 = rT;
			bool enabled = (((ToolStripItem)rV).Enabled = true);
			((ToolStripItem)obj3).Enabled = enabled;
			ToolStripMenuItem obj4 = rs;
			enabled = (((ToolStripItem)ru).Enabled = true);
			((ToolStripItem)obj4).Enabled = enabled;
		}

		private void B(object P_0, DoWorkEventArgs P_1)
		{
			C bpK = (C)P_1.Argument;
			string text = CZ.A(bpK.Bph, 65535);
			int? num;
			UpdateOutcomes updateOutcomes;
			string[] bpL = bj.A(bpK.Bph.axT, bpK.Bph.axS, bpK.Bph.axs, text, out num, out updateOutcomes);
			c c = default(c);
			c.BpK = bpK;
			if (num.HasValue && updateOutcomes == UpdateOutcomes.CompleteUpdate)
			{
				c.Bpk = updateOutcomes;
				c.BpL = bpL;
			}
			P_1.Result = c;
		}

		private void B(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Invalid comparison between Unknown and I4
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Invalid comparison between Unknown and I4
			c c = (c)P_1.Result;
			P();
			if (c.BpL != null && c.BpL.Length != 0)
			{
				string[] bpL = c.BpL;
				foreach (string text in bpL)
				{
					List<string> val;
					if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()))
					{
						val = new List<string>();
						val.Add(text);
					}
					else
					{
						val = bT.b(text);
					}
					if (val.Count != 0 && A(text, c.BpK))
					{
						return;
					}
				}
			}
			string text2 = bx.C(c.BpK.Bph.axS, c.BpK.Bph.axs);
			text2 = ((text2 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NZ() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)c.BpK.Bph.axT).ToString();
			if ((int)bE.A((IWin32Window)(object)this, text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !A(((FileDialog)qE).FileName, c.BpK))
				{
				}
			}
		}

		private bool A(string P_0, C P_1)
		{
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (P_1.Bph == null)
				{
					return false;
				}
				string text = null;
				bool flag3;
				bool flag;
				bool flag2;
				global::A.k k;
				if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nz()))
				{
					flag3 = CZ.A(P_0, P_1.Bph, out flag, out flag2, out k, out text);
				}
				else
				{
					text = P_0;
					flag3 = bT.A(P_0, P_1.Bph, out flag, out flag2, out k);
				}
				if (flag3 && text != null)
				{
					A(text, P_1.BpH, P_1.Bph);
					return true;
				}
				if (k == null || text == null)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (!flag)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.na(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (!flag2)
				{
					bE.A((IWin32Window)(object)this, string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nB(),
						((object)k).ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nb(),
						((object)P_1.Bph.axT).ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
					}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			catch (System.Exception ex)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nc() + ex.Message, true);
			}
			return false;
		}

		internal BM(bool P_0, bool P_1)
		{
			//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cc: Expected O, but got Unknown
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected O, but got Unknown
			//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ba: Expected O, but got Unknown
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			qW = P_0;
			if (!Directory.Exists(Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nD()))
			{
				Directory.CreateDirectory(Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nD());
			}
			bT.a();
			Ct.A();
			CU.A();
			c();
			D();
			aG();
			ag();
			aF();
			af();
			Co.a();
			aJ();
			aj();
			if (!qW)
			{
				G();
			}
			QQ = this;
			if (!qW)
			{
				foreach (ToolStripItem item in (ArrangedElementCollection)((ToolStrip)Rc).Items)
				{
					ToolStripItem val = item;
					if (val is ToolStripMenuItem)
					{
						((val is ToolStripMenuItem) ? val : null).Paint += new PaintEventHandler(a);
					}
				}
				o();
				p();
				((FileDialog)TF).InitialDirectory = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
				((FileDialog)Th).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nd();
				((FileDialog)Th).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nE();
				((FileDialog)qE).InitialDirectory = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nD();
				((FileDialog)qE).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ne();
				((FileDialog)qE).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nF();
				Ty = Color.FromArgb(255, 199, 44);
				TZ = Color.FromArgb(43, 44, 39);
				Tz = Color.FromArgb(158, 158, 158);
				tA = Color.FromArgb(37, 37, 38);
				ta = Color.FromArgb(30, 30, 30);
				tB = Color.FromArgb(62, 62, 66);
				tb = Color.FromArgb(104, 104, 104);
				tC = Color.FromArgb(240, 40, 20);
				tc = Color.FromArgb(160, 18, 18);
				sh = (float)(((Control)rQ).Width - 258) / (float)((Control)rQ).Width;
				sS = (float)(((Control)rw).Height - ((Control)rn.gS).Height + 6) / (float)((Control)rw).Height;
				aK();
				F();
			}
			if (File.Exists(BC.Nl))
			{
				StreamReader val2 = File.OpenText(BC.Nl);
				try
				{
					string text;
					while ((text = ((TextReader)val2).ReadLine()) != null)
					{
						if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iE()))
						{
							SG = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iE().Length));
						}
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			else
			{
				SG = false;
			}
			Be.a();
			global::A.s.A();
			bS.b();
			A();
			if (!qW)
			{
				rL.A().A(new ItemDragEventHandler(A));
				al();
				qA = new MenuNode(null, null, null, false, false, string.Empty);
				qA.A(-1);
				qA.a(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LZ());
				qA.D(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nf());
				qA.a(0);
				qa = new MenuNode(null, null, null, false, true, string.Empty);
				qa.A(-1);
				qa.a(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nG());
				qa.D(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ng());
				qa.a(0);
				m();
				TE = new CS(rv, 10);
				TE.A(D);
				Tf = new Cm(Cm.A.BsO);
				TG = new Cm(Cm.A.Bso);
			}
			else if (P_1)
			{
				global::A.A.A(new EventHandler(T));
				global::A.A.A((global::A.D)A);
				global::A.A.A();
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			//IL_0826: Unknown result type (might be due to invalid IL or missing references)
			//IL_0670: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f4: Expected O, but got Unknown
			//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0437: Unknown result type (might be due to invalid IL or missing references)
			//IL_0441: Expected O, but got Unknown
			A(true);
			if (File.Exists(QS))
			{
				StreamReader val = File.OpenText(QS);
				try
				{
					string text;
					while ((text = ((TextReader)val).ReadLine()) != null)
					{
						Size clientSize;
						Point location;
						if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nH()))
						{
							if (bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nH().Length)))
							{
								((Form)this).WindowState = (FormWindowState)2;
							}
							else
							{
								((Form)this).WindowState = (FormWindowState)0;
							}
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nh()))
						{
							int num = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nh().Length));
							clientSize = ((Form)this).ClientSize;
							((Form)this).ClientSize = new Size(num, ((Size)(ref clientSize)).Height);
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nI()))
						{
							clientSize = ((Form)this).ClientSize;
							((Form)this).ClientSize = new Size(((Size)(ref clientSize)).Width, int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nI().Length)));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ni()))
						{
							int num2 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ni().Length));
							location = ((Form)this).Location;
							((Form)this).Location = new Point(num2, ((Point)(ref location)).Y);
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nJ()))
						{
							location = ((Form)this).Location;
							((Form)this).Location = new Point(((Point)(ref location)).X, int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nJ().Length)));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nj()))
						{
							((Control)Rh).Visible = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nj().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nK()))
						{
							((Control)RI).Visible = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nK().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nk()))
						{
							((Control)Rq).Visible = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nk().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nL()))
						{
							((Control)rq).Visible = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nL().Length));
							if (((Control)rq).Visible)
							{
								sI = true;
								s();
							}
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nl()))
						{
							sh = float.Parse(global::A.N.A(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nl().Length)), (IFormatProvider)(object)CultureInfo.CurrentCulture);
							if (sh < 0f || sh > 1f)
							{
								sh = 0.7f;
							}
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nM()))
						{
							sS = float.Parse(global::A.N.A(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nM().Length)), (IFormatProvider)(object)CultureInfo.CurrentCulture);
							if (sS < 0f || sS > 1f)
							{
								sS = 0.8f;
							}
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nm()))
						{
							((Control)rL).Visible = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nm().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nN()))
						{
							((Control)rL).Width = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nN().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nn()))
						{
							((Control)rL.B()).Height = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nn().Length));
							rL.d();
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nO()))
						{
							rL.A().A((aW)byte.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nO().Length)));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.no()))
						{
							float num3 = float.Parse(global::A.N.A(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.no().Length)), (IFormatProvider)(object)CultureInfo.CurrentCulture);
							if (num3 < 4f || num3 > 20f)
							{
								num3 = 9f;
							}
							((Control)rL.A()).Font = new Font(((Control)this).Font.FontFamily, num3);
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nP()))
						{
							rL.a(!bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nP().Length)));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.np()))
						{
							float num4 = float.Parse(global::A.N.A(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.np().Length)), (IFormatProvider)(object)CultureInfo.CurrentCulture);
							if (num4 < 4f || num4 > 20f)
							{
								num4 = 9f;
							}
							DC.Bvd = num4;
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nQ()))
						{
							DC.BvF = (DC.Bvf = (bc)byte.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nQ().Length)));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nq()))
						{
							DC.Bve = (bC)byte.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nq().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nR()))
						{
							DC.BvE = (bD)int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nR().Length));
						}
					}
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			else
			{
				((Control)Rh).Visible = false;
				((Control)RI).Visible = false;
				((Control)Rq).Visible = false;
				((Control)rL).Visible = true;
			}
			q();
			X();
			x();
			Y();
			Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nr();
			if (bj.b())
			{
				((ToolStripItem)rO).Enabled = true;
				bj.b(false);
			}
			else
			{
				((ToolStripItem)rO).Enabled = false;
			}
			aA();
			J();
			B();
			C();
			Cs.C();
			TG.C();
			if (qi && !File.Exists(CZ.Bdl + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + qK))
			{
				qi = false;
				bE.A((IWin32Window)(object)this, string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nS(),
					CZ.Bdl,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(),
					qK,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ns()
				}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			if (qi && !string.IsNullOrEmpty(qj) && !File.Exists(qj))
			{
				qi = false;
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nT() + qj + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ns(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			if (qi)
			{
				global::A.A.A(qJ);
			}
			if (!qi)
			{
				bj.A();
			}
			global::A.A.A(new EventHandler(T));
			global::A.A.A((global::A.D)A);
			global::A.A.A();
			if (!Directory.Exists(Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy))
			{
				Directory.CreateDirectory(Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy);
			}
			if (!string.IsNullOrEmpty(qk))
			{
				new Cr(qk, qL, ql, qM, qm).A();
			}
			if (!string.IsNullOrEmpty(qN))
			{
				new Cp(qN, qn).A();
			}
			if (!string.IsNullOrEmpty(qO))
			{
				new CQ(qO, qo).A();
			}
			if (!string.IsNullOrEmpty(qv))
			{
				try
				{
					bW bW = Cq.a(qv);
					if (!(bW != null))
					{
						throw new System.Exception();
					}
					a(null, qv, bW);
				}
				catch (System.Exception ex)
				{
					qv = null;
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nt() + qv + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy() + ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			cb.a(true);
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Invalid comparison between Unknown and I4
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected O, but got Unknown
			bool flag = (int)P_1.CloseReason == 6 || (int)P_1.CloseReason == 3;
			if ((int)A((IWin32Window)(object)this, flag) == 2)
			{
				((CancelEventArgs)P_1).Cancel = true;
				return;
			}
			qw = true;
			if (TG != null && ((uint)qI & 0x800u) != 0)
			{
				TG.a();
			}
			if (qz != null && !((Control)qz).IsDisposed)
			{
				try
				{
					((Form)qz).Close();
				}
				catch
				{
				}
			}
			if (RA != null && !((Control)RA).IsDisposed)
			{
				try
				{
					((Form)RA).Close();
				}
				catch
				{
				}
			}
			if (Ra != null && !((Control)Ra).IsDisposed)
			{
				try
				{
					((Form)Ra).Close();
				}
				catch
				{
				}
			}
			qd.StorePendingStats();
			Framework framework = Qz;
			if (framework != null && framework.awZ == 21)
			{
				VirtualDashAppPanel.C();
			}
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nU());
			Application.DoEvents();
			Stopwatch val = new Stopwatch();
			val.Start();
			if (Qz != null)
			{
				int num = 0;
				while (global::A.A.E(Qz.aXc) != global::A.g.BK && C(false))
				{
					int num2 = Math.Min(30, 30 * (int)val.ElapsedMilliseconds / 500);
					if (num2 != num || num2 == 30)
					{
						if (num != 30)
						{
							Sw.Value = num2;
							num = num2;
						}
						if (val.ElapsedMilliseconds % 50 == 0L)
						{
							Application.DoEvents();
						}
					}
				}
			}
			global::A.A.a();
			rl.a(false);
			Sw.Value = 70;
			Application.DoEvents();
			w();
			Sw.Value = 80;
			CU.a();
			bT.A();
			Sw.Value = 90;
			if (Tf != null && ((uint)qI & 0x400u) != 0)
			{
				Tf.a();
			}
			Be.B();
			Sw.Value = 100;
			Application.DoEvents();
			val.Restart();
			while (val.ElapsedMilliseconds < 500)
			{
				if (val.ElapsedMilliseconds % 50 == 0L)
				{
					Application.DoEvents();
				}
			}
			((Control)this).Visible = false;
			if (flag)
			{
				val.Restart();
				while (StatsReporter.StatsStorageInProgress)
				{
					if (val.ElapsedMilliseconds % 50 == 0L)
					{
						Application.DoEvents();
					}
				}
			}
			if (bj.abP)
			{
				bj.H();
			}
			if (bj.abo)
			{
				bj.C(false);
			}
		}

		private void A(object P_0, DragEventArgs P_1)
		{
			if (P_1.Data.GetDataPresent(DataFormats.FileDrop))
			{
				P_1.Effect = (DragDropEffects)1;
			}
			else
			{
				P_1.Effect = (DragDropEffects)0;
			}
		}

		private void a(object P_0, DragEventArgs P_1)
		{
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				string[] array = (string[])P_1.Data.GetData(DataFormats.FileDrop);
				if (array != null)
				{
					if (array.Length == 1)
					{
						if (array[0].EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu()))
						{
							d(array[0]);
							return;
						}
						if (array[0].EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
						{
							a(array[0], false);
							return;
						}
						throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nu());
					}
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nV());
				}
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nv());
			}
			catch (System.Exception ex)
			{
				bE.A((IWin32Window)(object)this, ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nW(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		internal static void A(bool P_0 = true)
		{
			if (!P_0 && (Qz == null || (Qz.aXd && qX) || (!Qz.aXd && !qX)))
			{
				return;
			}
			string text = Qp;
			if (Qz != null)
			{
				if (QZ != string.Empty)
				{
					text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nw() + QZ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
				}
				else if ((qI & 2) == 0)
				{
					string empty = string.Empty;
					if (Qz.A(ref empty))
					{
						text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh() + empty;
					}
				}
				if (Qz.aXd)
				{
					text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nX();
					qX = true;
				}
				else
				{
					qX = false;
				}
				if (TI != string.Empty)
				{
					text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nx() + Path.GetFileName(TI) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fd();
				}
				if (QN != string.Empty)
				{
					text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nY() + QN + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fd();
				}
			}
			if (((Control)QQ).Text != text)
			{
				((Control)QQ).Text = text;
			}
		}

		private void c()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			qx = new BackgroundWorker();
			qx.WorkerReportsProgress = false;
			qx.WorkerSupportsCancellation = true;
			qx.DoWork += new DoWorkEventHandler(b);
			qx.RunWorkerAsync();
		}

		private void b(object P_0, DoWorkEventArgs P_1)
		{
			CZ.A(qx, 0, 0, null, 65535, null, null, false, bt.avK, null, false);
		}

		private void D()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			BackgroundWorker val = new BackgroundWorker();
			val.DoWork += new DoWorkEventHandler(C);
			val.RunWorkerAsync();
		}

		private void C(object P_0, DoWorkEventArgs P_1)
		{
			Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ny();
			bT.C();
		}

		private void A(object P_0, PaintEventArgs P_1)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			Image haltechSmallLogo = (Image)(object)GeneralResources.HaltechSmallLogo;
			Graphics graphics = P_1.Graphics;
			Rectangle clientRectangle = ((Control)this).ClientRectangle;
			graphics.DrawImage(haltechSmallLogo, ((Rectangle)(ref clientRectangle)).Width - haltechSmallLogo.Width - 2, 2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void C(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = qy;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref qy, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void c(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = qy;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref qy, val3, val2);
			}
			while (val != val2);
		}

		internal static void d()
		{
			if (!qW)
			{
				qY = true;
				QQ.K();
				QQ.rl.c();
				QQ.rL.c();
				if (qy != null)
				{
					qy.Invoke((object)null, (EventArgs)null);
				}
				while (((ArrangedElementCollection)((Control)QQ.Rh).Controls).Count != 0)
				{
					global::A.q.A(((Control)QQ.Rh).Controls[0]);
				}
				while (((ArrangedElementCollection)((Control)QQ.RI).Controls).Count != 0)
				{
					global::A.q.A(((Control)QQ.RI).Controls[0]);
				}
				while (((ArrangedElementCollection)((Control)QQ.Rq).Controls).Count != 0)
				{
					global::A.q.A(((Control)QQ.Rq).Controls[0]);
				}
				SN = -1;
				Sn = -1;
				l();
				qY = false;
				((Control)QQ.Rj).Visible = false;
				((Control)QQ.SB).Visible = false;
			}
		}

		internal static bool a(bool P_0)
		{
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Invalid comparison between Unknown and I4
			if (qW)
			{
				return false;
			}
			if (Qz != null)
			{
				if (Qz.awZ == 21)
				{
					CD.A(Qz);
				}
				else
				{
					VirtualDashAppPanel.b();
					VirtualDashAppPanel.EG = null;
					cb.a(true);
					ch.Bhl = null;
				}
				if (Ra != null)
				{
					if (((Control)Ra).Visible)
					{
						((Control)Ra).Hide();
					}
					((Component)Ra).Dispose();
				}
				if (Qz.B() && Qz.b() && (int)Qz.A(true, false) == 2)
				{
					((Control)QQ.Rj).Visible = true;
					((Control)QQ.Rj).BringToFront();
					((Control)QQ.SB).Visible = true;
					((Control)QQ.SB).BringToFront();
					return false;
				}
				((Control)QQ.Rj).Visible = false;
				((Control)QQ.SB).Visible = false;
				((Control)QQ.rI).Visible = false;
				((Control)QQ.rl).Enabled = true;
				QQ.rl.A();
				QQ.rl.k();
			}
			QQ.rL.D();
			if (Qz != null)
			{
				n();
				QQ.rL.A(true, false, true, false);
				if ((qI & 1) == 0)
				{
					O();
				}
				if (P_0)
				{
					SN = -1;
					Sn = -1;
				}
				M();
				QQ.rL.B(true);
				QQ.rL.b(true);
				QQ.j();
				if (Qz.A(out var _, out var _))
				{
					((ToolStripItem)QQ.RM).Visible = true;
					((ToolStripItem)QQ.rb).Visible = true;
				}
				else
				{
					((ToolStripItem)QQ.RM).Visible = false;
					((ToolStripItem)QQ.rb).Visible = false;
				}
				((ToolStripItem)QQ.SC).Visible = Qz.aww.ContainsKey(global::A.A.C.BFH);
				((ToolStripItem)QQ.Sb).Visible = Qz.aww.ContainsKey(global::A.A.C.BFH);
				((ToolStripItem)QQ.Sc).Visible = Qz.aww.ContainsKey(global::A.A.C.BFh);
				((ToolStripItem)QQ.SD).Visible = Qz.aWW.IsValid;
				((ToolStripItem)QQ.Rw).Enabled = Qz.aWW.IsValid;
			}
			return true;
		}

		internal static void E()
		{
			if (Qz != null && Qz.C())
			{
				((ToolStripItem)QQ.RL).Enabled = true;
				((ToolStripItem)QQ.rP).Enabled = true;
				((ToolStripItem)QQ.Rx).Enabled = true;
				((ToolStripItem)QQ.Rl).Enabled = SI.Count == 1 && global::A.A.E(SI[0].BpS.ao) != global::A.g.Bi;
				((ToolStripItem)QQ.RV).Enabled = ((ToolStripItem)QQ.Rl).Enabled;
				((ToolStripItem)QQ.RM).Enabled = true;
				((ToolStripItem)QQ.rb).Enabled = true;
				((ToolStripItem)QQ.rc).Enabled = Qz.awm != null;
			}
			else
			{
				((ToolStripItem)QQ.RL).Enabled = false;
				((ToolStripItem)QQ.rP).Enabled = false;
				((ToolStripItem)QQ.Rx).Enabled = false;
				((ToolStripItem)QQ.Rl).Enabled = false;
				((ToolStripItem)QQ.RV).Enabled = ((ToolStripItem)QQ.Rl).Enabled;
				((ToolStripItem)QQ.RM).Enabled = false;
				((ToolStripItem)QQ.rb).Enabled = false;
				((ToolStripItem)QQ.rc).Enabled = false;
			}
		}

		private void b(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			P();
		}

		private void C(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			P();
		}

		private void d(object P_0, EventArgs P_1)
		{
			if (((Control)rL).Visible)
			{
				((Control)rL).Visible = false;
			}
			else
			{
				((Control)rL).Visible = true;
			}
			X();
		}

		internal static void A(Control P_0)
		{
			if (P_0 is DC || P_0 is DB || P_0 is Db)
			{
				qZ = P_0;
				((ToolStripItem)QQ.rd).Enabled = true;
				((ToolStripItem)QQ.rD).Enabled = true;
			}
		}

		internal static void e()
		{
			((ToolStripItem)QQ.rd).Enabled = false;
			((ToolStripItem)QQ.rD).Enabled = false;
			qZ = null;
		}

		private void E(object P_0, EventArgs P_1)
		{
			if (qZ == null)
			{
				return;
			}
			try
			{
				if (qZ is DC)
				{
					(qZ as DC).a(null, null);
				}
				else if (qZ is DB)
				{
					(qZ as DB).a(null, null);
				}
				else if (qZ is Db)
				{
					(qZ as Db).a(null, null);
				}
			}
			catch
			{
			}
		}

		private void e(object P_0, EventArgs P_1)
		{
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Invalid comparison between Unknown and I4
			if (RA != null && ((Control)RA).Visible)
			{
				if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nZ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nz(), (MessageBoxButtons)1, (MessageBoxIcon)64) == 2)
				{
					return;
				}
				((Form)RA).Close();
				((Component)RA).Dispose();
			}
			if (qz != null)
			{
				if (((Control)qz).Visible)
				{
					((Form)qz).Activate();
					return;
				}
				((Component)qz).Dispose();
			}
			qz = new BX();
			BX bX = qz;
			Point location = ((Form)this).Location;
			int num = ((Point)(ref location)).X + (((Control)this).Width - ((Control)qz).Width) / 2;
			location = ((Form)this).Location;
			((Form)bX).Location = new Point(num, ((Point)(ref location)).Y + (((Control)this).Height - ((Control)qz).Height) / 2);
			((Form)qz).Show((IWin32Window)(object)this);
		}

		private void F(object P_0, EventArgs P_1)
		{
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Invalid comparison between Unknown and I4
			if (qz != null && ((Control)qz).Visible)
			{
				if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oa(), (MessageBoxButtons)1, (MessageBoxIcon)64) == 2)
				{
					return;
				}
				((Form)qz).Close();
				((Component)qz).Dispose();
			}
			if (RA != null)
			{
				if (((Control)RA).Visible)
				{
					((Form)RA).Activate();
					return;
				}
				((Component)RA).Dispose();
			}
			RA = new aZ();
			aZ aZ = RA;
			Point location = ((Form)this).Location;
			int num = ((Point)(ref location)).X + (((Control)this).Width - ((Control)RA).Width) / 2;
			location = ((Form)this).Location;
			((Form)aZ).Location = new Point(num, ((Point)(ref location)).Y + (((Control)this).Height - ((Control)RA).Height) / 2);
			((Form)RA).Show((IWin32Window)(object)this);
		}

		private void f(object P_0, EventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			cx cx = new cx();
			((Form)cx).ShowDialog((IWin32Window)(object)this);
			((Component)cx).Dispose();
		}

		private void G(object P_0, EventArgs P_1)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			if (Qz != null && Qz.C())
			{
				w();
				Br br = new Br();
				((Form)br).ShowDialog((IWin32Window)(object)this);
				((Component)br).Dispose();
			}
		}

		private void g(object P_0, EventArgs P_1)
		{
			A(global::A.A.C.BFH);
		}

		private void H(object P_0, EventArgs P_1)
		{
			A(global::A.A.C.BFh);
		}

		private void A(global::A.A.C P_0)
		{
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			if (Qz != null && Qz.aww.Count != 0 && Qz.aww.ContainsKey(P_0))
			{
				BW bW = new BW(Qz, true, false, Qz.aww[P_0], P_0);
				((Form)bW).ShowDialog((IWin32Window)(object)this);
				((Component)bW).Dispose();
			}
		}

		private void h(object P_0, EventArgs P_1)
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			if (Qz != null)
			{
				Dictionary<string, DataTableObject> awx = Qz.awx;
				DataTableObject dataTableObject = ((awx != null) ? Enumerable.FirstOrDefault<KeyValuePair<string, DataTableObject>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, DataTableObject>>)awx, (Func<KeyValuePair<string, DataTableObject>, bool>)((KeyValuePair<string, DataTableObject> P_0) => P_0.Value.IsErrorTable)).Value : null);
				if (dataTableObject != null && Qz.aWW.IsValid)
				{
					dataTableObject.Data = global::A.N.A<string, string, string>(Qz.aWW.ErrorDefs);
					DTCManagerForm dTCManagerForm = new DTCManagerForm(Qz, dataTableObject);
					((Form)dTCManagerForm).ShowDialog();
					((Component)dTCManagerForm).Dispose();
				}
			}
		}

		private void I(object P_0, EventArgs P_1)
		{
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			if (Qz == null)
			{
				return;
			}
			if (Qz.C())
			{
				if (Ra != null)
				{
					if (((Control)Ra).Visible)
					{
						if (Ra.a() == Qz)
						{
							((Form)Ra).Activate();
							return;
						}
						((Control)Ra).Hide();
					}
					((Component)Ra).Dispose();
				}
				Ra = new BZ();
				Ra.A(Qz);
				BZ bZ = Ra;
				Point location = ((Form)this).Location;
				int num = ((Point)(ref location)).X + (((Control)this).Width - ((Control)Ra).Width) / 2;
				location = ((Form)this).Location;
				((Form)bZ).Location = new Point(num, ((Point)(ref location)).Y + (((Control)this).Height - ((Control)Ra).Height) / 2);
				((Form)Ra).Show((IWin32Window)(object)this);
			}
			else if (Ra != null)
			{
				if (((Control)Ra).Visible)
				{
					((Control)Ra).Hide();
				}
				((Component)Ra).Dispose();
			}
		}

		private void i(object P_0, EventArgs P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			w();
			bG bG = new bG();
			((Form)bG).ShowDialog((IWin32Window)(object)this);
			((Component)bG).Dispose();
		}

		private void J(object P_0, EventArgs P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			w();
			bf bf = new bf();
			((Form)bf).ShowDialog((IWin32Window)(object)this);
			((Component)bf).Dispose();
		}

		private void j(object P_0, EventArgs P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			w();
			bd bd = new bd();
			((Form)bd).ShowDialog((IWin32Window)(object)this);
			((Component)bd).Dispose();
		}

		private void K(object P_0, EventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			BC bC = new BC();
			((Form)bC).ShowDialog((IWin32Window)(object)this);
			((Component)bC).Dispose();
		}

		private void k(object P_0, EventArgs P_1)
		{
			try
			{
				SendKeys.Send(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OB());
			}
			catch
			{
			}
		}

		private void L(object P_0, EventArgs P_1)
		{
			try
			{
				SendKeys.Send(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ob());
			}
			catch
			{
			}
		}

		internal void l(object P_0, EventArgs P_1)
		{
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			if (Qz != null && Qz.c() && A(Qz.aXc, true))
			{
				flag = true;
			}
			string text = string.Empty;
			bool flag2 = true;
			if (!flag)
			{
				string inputPath = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
				FolderPicker folderPicker = new FolderPicker();
				folderPicker.InputPath = inputPath;
				if (folderPicker.ShowDialog(System.IntPtr.Zero).GetValueOrDefault())
				{
					string resultPath = folderPicker.ResultPath;
					string[] array = folderPicker.ResultPath.Split(RuntimeHelpers.CreateSpan<char>((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/));
					if (array.Length > 1 && array[array.Length - 2] == Qy)
					{
						resultPath += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JT();
						text = ((!Directory.Exists(resultPath)) ? folderPicker.ResultPath : resultPath);
					}
					else
					{
						text = folderPicker.ResultPath;
					}
				}
				else
				{
					flag2 = false;
				}
			}
			if (flag2)
			{
				Be be = new Be(text, !flag);
				((Form)be).ShowDialog((IWin32Window)(object)this);
				((Component)be).Dispose();
			}
		}

		private void M(object P_0, EventArgs P_1)
		{
			A(BE.nE, false, false, false);
		}

		private void m(object P_0, EventArgs P_1)
		{
			A(BE.ne, false, false, false);
		}

		private void N(object P_0, EventArgs P_1)
		{
			A(BE.nd, false, false, false);
		}

		private void n(object P_0, EventArgs P_1)
		{
			A((Form)(object)this, BE.nd, null, null);
		}

		private void O(object P_0, EventArgs P_1)
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			if (RB != null)
			{
				if (((Control)RB).Visible)
				{
					((Form)RB).Activate();
					return;
				}
				((Component)RB).Dispose();
			}
			RB = new Bk();
			Bk bk = RB;
			Point location = ((Form)this).Location;
			int num = ((Point)(ref location)).X + (((Control)this).Width - ((Control)RB).Width) / 2;
			location = ((Form)this).Location;
			((Form)bk).Location = new Point(num, ((Point)(ref location)).Y + (((Control)this).Height - ((Control)RB).Height) / 2);
			((Form)RB).Show((IWin32Window)(object)this);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Invalid comparison between Unknown and I4
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Invalid comparison between Unknown and I4
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Invalid comparison between Unknown and I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Invalid comparison between Unknown and I4
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Invalid comparison between Unknown and I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Invalid comparison between Unknown and I4
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Invalid comparison between Unknown and I4
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Invalid comparison between Unknown and I4
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Invalid comparison between Unknown and I4
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Invalid comparison between Unknown and I4
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Invalid comparison between Unknown and I4
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Invalid comparison between Unknown and I4
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Invalid comparison between Unknown and I4
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Invalid comparison between Unknown and I4
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Invalid comparison between Unknown and I4
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Invalid comparison between Unknown and I4
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Invalid comparison between Unknown and I4
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Invalid comparison between Unknown and I4
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Invalid comparison between Unknown and I4
			//IL_0245: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Invalid comparison between Unknown and I4
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Invalid comparison between Unknown and I4
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Invalid comparison between Unknown and I4
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Invalid comparison between Unknown and I4
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Invalid comparison between Unknown and I4
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Invalid comparison between Unknown and I4
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Invalid comparison between Unknown and I4
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Invalid comparison between Unknown and I4
			if ((int)keyData == 112)
			{
				S();
				return true;
			}
			if ((int)keyData == 115)
			{
				rL.C(true);
				return true;
			}
			if ((int)keyData == 116)
			{
				s((object)null, (EventArgs)null);
				return true;
			}
			if ((int)keyData == 117)
			{
				ae(null, null);
				return true;
			}
			if ((int)keyData == 118)
			{
				af(null, null);
				return true;
			}
			if ((int)keyData == 65654)
			{
				aG(null, null);
				return true;
			}
			if ((int)keyData == 120)
			{
				b((object)null, (EventArgs)null);
				return true;
			}
			if ((int)keyData == 122)
			{
				y();
				return true;
			}
			if ((int)keyData == 192)
			{
				d((object)null, (EventArgs)null);
				return true;
			}
			if ((int)keyData == 262211)
			{
				rL.A().B(true);
				return true;
			}
			if ((int)keyData == 131150)
			{
				ac(null, null);
				return true;
			}
			if ((int)keyData == 131151)
			{
				ad(null, null);
				return true;
			}
			if ((int)keyData == 131155)
			{
				aj(null, null);
				return true;
			}
			if ((int)keyData == 131162)
			{
				ak(null, null);
				return true;
			}
			if ((int)keyData == 131161)
			{
				aL(null, null);
				return true;
			}
			if ((int)keyData == 131195)
			{
				t((object)null, (EventArgs)null);
				return true;
			}
			if ((int)keyData == 131142)
			{
				((Control)rL.a()).Focus();
				return true;
			}
			if (((TabControl)rl).TabCount > 2)
			{
				if ((int)keyData == 131081)
				{
					if (((TabControl)rl).SelectedIndex == ((TabControl)rl).TabCount - 2)
					{
						((TabControl)rl).SelectedIndex = 0;
					}
					else
					{
						((TabControl)rl).SelectedIndex = ((TabControl)rl).SelectedIndex + 1;
					}
					return true;
				}
				if ((int)keyData == 196617)
				{
					if (((TabControl)rl).SelectedIndex == 0)
					{
						((TabControl)rl).SelectedIndex = ((TabControl)rl).TabCount - 2;
					}
					else
					{
						((TabControl)rl).SelectedIndex = ((TabControl)rl).SelectedIndex - 1;
					}
					return true;
				}
				if (((Control)rl).Focused)
				{
					if ((int)keyData == 37)
					{
						return true;
					}
					if ((int)keyData == 39)
					{
						return true;
					}
					if ((int)keyData == 38)
					{
						return true;
					}
					if ((int)keyData == 40)
					{
						return true;
					}
				}
			}
			if (((Control)rl).Enabled && (int)keyData == 196686)
			{
				((TabControl)rl).SelectedIndex = ((TabControl)rl).TabCount - 1;
				return true;
			}
			if (rL.A().a().Count != 0)
			{
				if ((int)keyData == 262181)
				{
					rL.A().A((Keys)37);
					return true;
				}
				if ((int)keyData == 262183)
				{
					rL.A().A((Keys)39);
					return true;
				}
				if ((int)keyData == 262182)
				{
					rL.A().A((Keys)38);
					return true;
				}
				if ((int)keyData == 262184)
				{
					rL.A().A((Keys)40);
					return true;
				}
				if ((keyData & 0x40000) != 0)
				{
					if (!((Control)rL).Visible)
					{
						sW = true;
						((Control)rL).Visible = true;
						X();
					}
					if (((Control)Rc).Focused)
					{
						((Control)rL.A()).Focus();
					}
					else
					{
						((Control)Rc).Focus();
						((ToolStripItem)RD).Select();
					}
					return true;
				}
			}
			return false;
		}

		private void o(object P_0, EventArgs P_1)
		{
			rl.H();
		}

		private void P(object P_0, EventArgs P_1)
		{
			Application.Exit();
		}

		private void p(object P_0, EventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			aY aY = new aY();
			((Form)aY).ShowDialog((IWin32Window)(object)this);
			((Component)aY).Dispose();
		}

		private void Q(object P_0, EventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			bH bH = new bH();
			((Form)bH).ShowDialog((IWin32Window)(object)this);
			((Component)bH).Dispose();
		}

		internal void F()
		{
			if (bg.a())
			{
				((ToolStripItem)rK).Visible = true;
				((ToolStripItem)rG).Visible = true;
			}
			else
			{
				((ToolStripItem)rK).Visible = false;
				((ToolStripItem)rG).Visible = false;
			}
		}

		private void q(object P_0, EventArgs P_1)
		{
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Invalid comparison between Unknown and I4
			if (Qz != null && Qz.c() && Qz.E())
			{
				string text = global::A.N.A(true);
				string text2 = Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OC() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK();
				try
				{
					if (!Directory.Exists(text2))
					{
						Directory.CreateDirectory(text2);
					}
				}
				catch (System.Exception ex)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oc() + ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				try
				{
					string text3 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OD();
					if (!Directory.Exists(text3))
					{
						Directory.CreateDirectory(text3);
					}
					new CR(text3 + text + bx.a(Qz.awZ, Qz.awz, Qz.aXA) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu(), Qz, true).A();
					global::A.p.A(text3 + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Od(), ImageFormat.Png, ((Control)QQ).Handle);
				}
				catch (System.Exception ex2)
				{
					global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OE() + ex2.Message, true);
				}
				ba ba = new ba(Qz, text2);
				if ((int)((Form)ba).ShowDialog((IWin32Window)(object)this) != 1)
				{
					try
					{
						if (Directory.Exists(text2))
						{
							Directory.Delete(text2, true);
						}
					}
					catch
					{
					}
				}
				((Component)ba).Dispose();
			}
			else
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oe(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OF(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		internal static string A(Framework P_0)
		{
			if (P_0 != null && P_0.c())
			{
				string empty = string.Empty;
				if (P_0.A(ref empty))
				{
					string text = A(empty, P_0.aXc);
					if (string.IsNullOrEmpty(text))
					{
						try
						{
							string text2 = empty;
							List<string> obj = new List<string>();
							obj.Add(P_0.aXc);
							return (P_0.aXD = a(text2, obj)) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Of();
						}
						catch
						{
							return Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Of();
						}
					}
					return text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Of();
				}
				return Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Of();
			}
			return Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Of();
		}

		internal static bool A(Framework P_0, global::A.j P_1, string P_2, out string P_3, out byte[] P_4)
		{
			P_3 = null;
			P_4 = null;
			try
			{
				string text = string.Concat(A(P_0) + P_2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(), P_1.a().Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG().Length));
				if (File.Exists(text))
				{
					byte[] array = File.ReadAllBytes(text);
					uint num = new global::crc.crc().crc_process(array, 0u, (uint)array.Length, 4294967295u, partial: false);
					if (P_1.Ch == num)
					{
						P_3 = text;
						P_4 = array;
						return true;
					}
					return false;
				}
				return false;
			}
			catch
			{
				return false;
			}
		}

		internal static bool A(Framework P_0, string P_1, string P_2, out string P_3)
		{
			try
			{
				string text = A(P_0) + P_2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + P_1;
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				P_3 = null;
				return true;
			}
			catch (System.Exception ex)
			{
				P_3 = ex.Message;
				return false;
			}
		}

		internal static bool A(Framework P_0, string P_1, string P_2, string P_3, out string P_4)
		{
			try
			{
				string text = A(P_0) + P_3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
				string text2 = text + P_1;
				string text3 = text + P_2;
				if (File.Exists(text3))
				{
					File.Delete(text3);
				}
				if (File.Exists(text2))
				{
					File.Move(text2, text3);
				}
				P_4 = null;
				return true;
			}
			catch (System.Exception ex)
			{
				P_4 = ex.Message;
				return false;
			}
		}

		internal static bool A(Framework P_0, string P_1, byte[] P_2, string P_3, out string P_4)
		{
			try
			{
				string text = A(P_0) + P_3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllBytes(text + P_1, P_2);
				P_4 = null;
				return true;
			}
			catch (System.Exception ex)
			{
				P_4 = ex.Message;
				return false;
			}
		}

		internal static bool A(string P_0, out string P_1)
		{
			try
			{
				if (Directory.Exists(P_0))
				{
					Directory.Delete(P_0, true);
				}
				P_1 = null;
				return true;
			}
			catch (System.Exception ex)
			{
				P_1 = ex.Message;
				return false;
			}
		}

		internal static bool A(string P_0, string P_1, byte[] P_2, string P_3, out string P_4)
		{
			try
			{
				string text = P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + P_3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllBytes(text + P_1, P_2);
				P_4 = null;
				return true;
			}
			catch (System.Exception ex)
			{
				P_4 = ex.Message;
				return false;
			}
		}

		internal static bool A(string P_0, string P_1, string P_2, out string P_3)
		{
			string text = string.Concat(new string[5]
			{
				QV,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(),
				P_2,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(),
				P_0
			});
			if (File.Exists(text))
			{
				string text2 = Qu + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + P_2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
				try
				{
					if (!Directory.Exists(text2))
					{
						Directory.CreateDirectory(text2);
					}
					string text3 = text2 + P_1;
					if (File.Exists(text3))
					{
						File.Delete(text3);
					}
					File.Copy(text, text3);
					P_3 = null;
					return true;
				}
				catch (System.Exception ex)
				{
					P_3 = ex.Message;
					return false;
				}
			}
			P_3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Og() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OH();
			return false;
		}

		internal static global::A.j[] a(global::A.A.C P_0)
		{
			if (global::A.A.A(Qz.aXc, P_0, out var b, out var num, out var flag) && b == global::A.A.b.BFC && num != 0 && global::A.A.A(Qz.aXc, P_0, 0, (ushort)(num - 1), out b, out var result, out flag) && b == global::A.A.b.BFC)
			{
				return result;
			}
			return null;
		}

		private static uint f()
		{
			if (Qz.awW != null)
			{
				Setting setting = Qz.A(Qz.awW.ab());
				if (setting != null && global::A.A.A(Qz.aXc, global::A.f.aY, (uint)setting.a(), (uint)setting.BB(), out var array, out var _))
				{
					return (uint)global::A.N.A(array, 0, setting.BB(), setting.ag(), Qz.aWR);
				}
			}
			return 0u;
		}

		internal static void A(BackgroundWorker P_0, int P_1, int P_2, string P_3, int P_4, uint P_5, out string P_6)
		{
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected O, but got Unknown
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Expected O, but got Unknown
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Expected O, but got Unknown
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Expected O, but got Unknown
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Expected O, but got Unknown
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Expected O, but got Unknown
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ff: Expected O, but got Unknown
			P_6 = null;
			if (P_0 != null)
			{
				if (P_4 != -1)
				{
					P_0.ReportProgress(P_1, (object)P_4);
				}
				else
				{
					P_0.ReportProgress(P_1);
				}
			}
			if (Qz.awW == null || string.IsNullOrEmpty(P_3))
			{
				return;
			}
			bool flag;
			string text;
			if (P_3.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG()))
			{
				flag = true;
				text = P_3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG().Length);
			}
			else
			{
				flag = false;
				text = ((!P_3.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh())) ? P_3 : P_3.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh().Length));
			}
			try
			{
				string text2 = ((!flag) ? (QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oi() + text) : (Qu + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OI() + text));
				Setting setting = Qz.A(Qz.awW.ab());
				uint num = 0u;
				if (setting != null)
				{
					byte[] array = File.ReadAllBytes(text2);
					num = new global::crc.crc().crc_process(array, 0u, (uint)array.Length, 4294967295u, partial: false);
					if (P_5 == num)
					{
						global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OJ(), true);
						if (P_0 != null)
						{
							if (P_4 != -1)
							{
								P_0.ReportProgress(P_1 + P_2, (object)P_4);
							}
							else
							{
								P_0.ReportProgress(P_1 + P_2);
							}
							Thread.Sleep(500);
						}
						return;
					}
				}
				Size val = Qz.awW.aa();
				int num2 = Qz.awW.aB();
				PixelFormat val2 = (PixelFormat)(num2 switch
				{
					24 => 137224, 
					32 => 2498570, 
					_ => throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oj() + num2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OK()), 
				});
				FileStream val3 = File.OpenRead(text2);
				try
				{
					Image val4 = Image.FromStream((Stream)(object)val3);
					try
					{
						Bitmap val5 = new Bitmap(((Size)(ref val)).Width, ((Size)(ref val)).Height, val2);
						try
						{
							Graphics val6 = Graphics.FromImage((Image)(object)val5);
							try
							{
								val6.Clear(Color.Black);
								Size val7 = global::A.O.A(val4.Size, val);
								int width = ((Size)(ref val7)).Width;
								int height = ((Size)(ref val7)).Height;
								val6.InterpolationMode = (InterpolationMode)7;
								val6.SmoothingMode = (SmoothingMode)2;
								val6.CompositingQuality = (CompositingQuality)2;
								val6.PixelOffsetMode = (PixelOffsetMode)2;
								val6.DrawImage(val4, ((Size)(ref val)).Width / 2 - width / 2, ((Size)(ref val)).Height / 2 - height / 2, width, height);
								ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
								ImageCodecInfo val8 = null;
								ImageCodecInfo[] array2 = imageEncoders;
								foreach (ImageCodecInfo val9 in array2)
								{
									if (val9.FormatID == ImageFormat.Bmp.Guid)
									{
										val8 = val9;
										break;
									}
								}
								if (val8 != null)
								{
									MemoryStream val10 = new MemoryStream();
									try
									{
										EncoderParameter val11 = new EncoderParameter(Encoder.ColorDepth, (long)num2);
										try
										{
											EncoderParameters val12 = new EncoderParameters();
											try
											{
												val12.Param = (EncoderParameter[])(object)new EncoderParameter[1] { val11 };
												((Image)val5).Save((Stream)(object)val10, val8, val12);
												byte[] array3 = val10.ToArray();
												MagickReadSettings val13 = new MagickReadSettings
												{
													Format = (MagickFormat)20
												};
												MagickImage val14 = new MagickImage(array3, (IMagickReadSettings<byte>)(object)val13);
												try
												{
													QuantizeSettings val15 = new QuantizeSettings
													{
														Colors = 224u,
														ColorSpace = (ColorSpace)23,
														DitherMethod = (DitherMethod)3
													};
													val14.Quantize((IQuantizeSettings)(object)val15);
													val14.Alpha((AlphaOption)12);
													val14.ColorType = (ColorType)6;
													val14.ColorSpace = (ColorSpace)23;
													val14.Strip();
													array3 = val14.ToByteArray((MagickFormat)22);
												}
												finally
												{
													((System.IDisposable)val14)?.Dispose();
												}
												int num3 = P_2 * 10 / 100;
												int num4 = P_2 * 30 / 100;
												int num5 = P_2 - (num3 + num4);
												if (P_0 != null)
												{
													if (P_4 != -1)
													{
														P_0.ReportProgress(P_1 + num3, (object)P_4);
													}
													else
													{
														P_0.ReportProgress(P_1 + num3);
													}
												}
												A(P_0, array3, P_1 + num3, num4, P_4);
												A(P_0, P_1 + num3 + num4, num5, P_4);
												setting?.a((int)num, true);
												if (P_0 != null)
												{
													if (P_4 != -1)
													{
														P_0.ReportProgress(P_1 + P_2, (object)P_4);
													}
													else
													{
														P_0.ReportProgress(P_1 + P_2);
													}
													Thread.Sleep(500);
												}
												return;
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
									}
									finally
									{
										((System.IDisposable)val10)?.Dispose();
									}
								}
								throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ok());
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
			catch (System.Exception ex)
			{
				P_6 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OL() + ex.Message;
			}
		}

		private static void A(BackgroundWorker P_0, byte[] P_1, int P_2, int P_3, int P_4)
		{
			uint num = global::A.A.a(Qz.aXc, global::A.f.BC);
			uint num2 = 0u;
			do
			{
				uint num3 = Math.Min(num, (uint)P_1.Length - num2);
				byte[] array = new byte[num3];
				System.Array.Copy((System.Array)P_1, (long)num2, (System.Array)array, 0L, (long)num3);
				if (global::A.A.A(Qz.aXc, global::A.f.BC, num2, array, out var flag))
				{
					global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ol() + num3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OM(), false);
					num2 += num3;
					if (P_0 != null)
					{
						if (P_0.CancellationPending)
						{
							throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Om());
						}
						int num4 = P_2 + (int)(num2 * P_3 / P_1.Length);
						if (P_4 != -1)
						{
							P_0.ReportProgress(num4, (object)P_4);
						}
						else
						{
							P_0.ReportProgress(num4);
						}
					}
				}
				else if (flag || !A(Qz.aXc, false))
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ON());
				}
				if (P_0 != null && P_0.CancellationPending)
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Om());
				}
			}
			while (num2 < P_1.Length);
		}

		private static void A(BackgroundWorker P_0, int P_1, int P_2, int P_3)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			Stopwatch val = new Stopwatch();
			val.Restart();
			while (true)
			{
				if (val.ElapsedMilliseconds >= 25000)
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.On());
				}
				bool flag = false;
				int num = 5;
				byte[] array;
				do
				{
					flag = global::A.A.A(Qz.aXc, 0, out array, out var _) && array.Length != 0;
					if (!flag)
					{
						num--;
						Thread.Sleep(500);
					}
				}
				while (num != 0 && !flag);
				if (!flag)
				{
					break;
				}
				if (array[0] != 2)
				{
					if (array[0] == 0)
					{
						return;
					}
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OO());
				}
				if (P_0 != null)
				{
					int num2 = Math.Min(P_1 + P_2, P_1 + (int)(val.ElapsedMilliseconds * P_2 / 15000));
					if (P_3 != -1)
					{
						P_0.ReportProgress(num2, (object)P_3);
					}
					else
					{
						P_0.ReportProgress(num2);
					}
				}
				Thread.Sleep(100);
			}
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oo());
		}

		private void R(object P_0, EventArgs P_1)
		{
			if (global::A.A.c().Count == 1)
			{
				global::A.A.b(global::A.A.c()[0].ao, out var _);
			}
		}

		private void r(object P_0, EventArgs P_1)
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected O, but got Unknown
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Expected O, but got Unknown
			if (global::A.A.c().Count != 1 || ((uint)qI & 0x100u) != 0 || ((uint)qI & 0x200u) != 0 || ((uint)qI & 0x1000u) != 0 || ((uint)qI & 0x20u) != 0 || ((uint)qI & 0x40u) != 0)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OP(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (Qz.A(9500).ax() != 0)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Op(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			Rb = true;
			Thread.Sleep(100);
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.DoWork += new DoWorkEventHandler(c);
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(c);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OQ());
			val.RunWorkerAsync();
		}

		private void c(object P_0, DoWorkEventArgs P_1)
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_030e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_0319: Expected O, but got Unknown
			//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bd: Expected O, but got Unknown
			//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d3: Expected O, but got Unknown
			//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e9: Expected O, but got Unknown
			//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cf: Expected O, but got Unknown
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			P_1.Result = null;
			try
			{
				int num = Qz.A(9497).ax();
				int num2 = Qz.A(9510).ax();
				Be.f();
				string text = ((qV != null) ? qV : (Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oq()));
				FileStream val2 = new FileStream(text, (FileMode)2);
				ZipArchive val3 = new ZipArchive((Stream)(object)val2, (ZipArchiveMode)1);
				Stream val4 = val3.CreateEntry(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OR()).Open();
				global::A.F f = global::A.A.c()[0];
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				float Bqu = 0f;
				Stopwatch val5 = new Stopwatch();
				while (num5 < num)
				{
					val5.Restart();
					int num6 = Math.Min((int)global::A.A.A(f.ao, global::A.f.Ba), num - num5);
					bool flag2;
					do
					{
						val5.Restart();
						flag2 = global::A.A.A(f.ao, global::A.f.Ba, (uint)num5, (uint)num6, out var array, out var _);
						if (flag2)
						{
							val4.Write(array, 0, num6);
						}
					}
					while (!flag2);
					val5.Stop();
					num3 += num6;
					num4 += (int)val5.ElapsedMilliseconds;
					if (num4 >= 2000)
					{
						float num7 = (float)num3 / 1048576f;
						float num8 = (float)num4 / 1000f;
						Bqu = num7 / num8;
						global::A.N.A(string.Concat(new string[7]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Or(),
							num3.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OS(),
							num4.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Os(),
							Bqu.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OT()
						}), true);
						num4 = 0;
						num3 = 0;
					}
					global::A.N.A(string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ot(),
						num6.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OU(),
						val5.ElapsedMilliseconds.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ou()
					}), true);
					num5 += num6;
					int num9 = Convert.ToInt32(Convert.ToSingle(num5) / (float)num * 95f);
					val.ReportProgress(num9);
					uint num10 = (uint)((float)(uint)(num - num5) / (1048576f * Bqu));
					uint BqV = num10 / 60;
					num10 %= 60;
					string Bqv = string.Empty;
					if (num10 < 10)
					{
						Bqv = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn() + num10;
					}
					else
					{
						Bqv = num10.ToString();
					}
					if (!qW)
					{
						((Control)SX).Invoke((Action)delegate
						{
							((Control)SX).Text = string.Concat(new string[7]
							{
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdb(),
								BqV.ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bo(),
								Bqv,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ie(),
								string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdC(), (object)Bqu),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdc()
							});
						});
					}
				}
				val4.Close();
				val3.Dispose();
				((Stream)val2).Close();
				if (!qW)
				{
					Label obj = SX;
					object obj2 = BM.U.BqQ;
					if (obj2 == null)
					{
						Action val6 = delegate
						{
							((Control)SX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OV();
						};
						BM.U.BqQ = val6;
						obj2 = (object)val6;
					}
					((Control)obj).Invoke((Action)obj2);
				}
				else
				{
					Console.WriteLine();
					Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OV());
				}
				string text2;
				if (qV == null)
				{
					text2 = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ov();
				}
				else
				{
					string text3 = Path.GetFileNameWithoutExtension(qV) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OW();
					string text4 = Path.GetDirectoryName(qV);
					if (!text4.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj()) && !text4.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()))
					{
						text4 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK();
					}
					text2 = text4 + text3;
				}
				StreamWriter val7 = new StreamWriter((Stream)(object)File.Open(text2, (FileMode)2, (FileAccess)2));
				((TextWriter)val7).WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ow());
				val2 = new FileStream(text, (FileMode)3);
				if (((Stream)val2).CanRead)
				{
					val3 = new ZipArchive((Stream)(object)val2, (ZipArchiveMode)0);
					val4 = val3.Entries[0].Open();
					int num11 = num / num2;
					for (int i = 0; i < num11; i++)
					{
						int num12 = 0;
						int num13 = 0;
						for (int j = 0; j < num2; j++)
						{
							int num14 = val4.ReadByte();
							if (num14 != -1)
							{
								byte b = (byte)num14;
								switch (j)
								{
								case 60:
									num12 |= b << 24;
									break;
								case 61:
									num12 |= (b << 16) & 0xFF0000;
									break;
								case 62:
									num12 |= (b << 8) & 0xFF00;
									break;
								case 63:
									num12 |= b & 0xFF;
									break;
								}
								switch (j)
								{
								case 64:
									num13 |= b << 24;
									break;
								case 65:
									num13 |= (b << 16) & 0xFF0000;
									break;
								case 66:
									num13 |= (b << 8) & 0xFF00;
									break;
								case 67:
									num13 |= b & 0xFF;
									break;
								}
								continue;
							}
							throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OX());
						}
						((TextWriter)val7).WriteLine(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ox(), (object)(i * num2), (object)num12, (object)num13));
					}
					val4.Close();
					val3.Dispose();
				}
				((Stream)val2).Close();
				((TextWriter)val7).Close();
			}
			catch (System.Exception ex)
			{
				P_1.Result = ex.Message;
			}
			Thread.Sleep(100);
			val.ReportProgress(100);
		}

		private void c(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			P();
			Be.F();
			Rb = false;
			if (P_1.Result != null)
			{
				if (!qW)
				{
					bE.A((IWin32Window)(object)this, P_1.Result as string, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				Console.WriteLine();
				Console.WriteLine(P_1.Result as string);
				Environment.Exit(1);
			}
			if (qV != null)
			{
				string text = Path.GetFileNameWithoutExtension(qV) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OY();
				string text2 = Path.GetDirectoryName(qV);
				if (!text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj()) && !text2.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()))
				{
					text2 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK();
				}
				f(text2 + text);
				qV = null;
			}
		}

		private void D(object P_0, DoWorkEventArgs P_1)
		{
			Thread.Sleep(1500);
		}

		private void D(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			if (qV == null)
			{
				return;
			}
			if (Qz.A(9500).ax() != 0)
			{
				string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oy();
				if (!qW)
				{
					bE.A((IWin32Window)(object)this, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				Console.WriteLine();
				Console.WriteLine(text);
				Environment.Exit(1);
			}
			r((object)null, (EventArgs)null);
		}

		private void S(object P_0, EventArgs P_1)
		{
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Invalid comparison between Unknown and I4
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected O, but got Unknown
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Expected O, but got Unknown
			if (Qz == null || global::A.A.c().Count != 1 || ((uint)qI & 0x100u) != 0 || ((uint)qI & 0x200u) != 0 || ((uint)qI & 0x1000u) != 0 || ((uint)qI & 0x20u) != 0 || ((uint)qI & 0x40u) != 0)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OP(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (global::A.A.a(global::A.A.c()[0].ao, global::A.f.Ba) == 0)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OZ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (Qz.A(9500).ax() != 0)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Op(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).InitialDirectory = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
			((FileDialog)val).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oz();
			((FileDialog)val).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nE();
			if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
			{
				BackgroundWorker val2 = new BackgroundWorker
				{
					WorkerReportsProgress = true
				};
				object obj = BM.t.Bqk;
				if (obj == null)
				{
					ProgressChangedEventHandler val3 = a;
					BM.t.Bqk = val3;
					obj = (object)val3;
				}
				val2.ProgressChanged += (ProgressChangedEventHandler)obj;
				val2.DoWork += new DoWorkEventHandler(d);
				val2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(d);
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oA());
				val2.RunWorkerAsync((object)((FileDialog)val).FileName);
			}
		}

		private void d(object P_0, DoWorkEventArgs P_1)
		{
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected O, but got Unknown
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Expected O, but got Unknown
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			MemoryStream val2 = null;
			ZipArchive val3 = null;
			Stream val4 = null;
			try
			{
				global::A.F f = global::A.A.c()[0];
				if (global::A.A.b(f.ao, out var flag))
				{
					Thread.Sleep(200);
					Setting setting = Qz.A(9500);
					int num = 0;
					int num2;
					do
					{
						num2 = setting.ax();
						if (num2 == 12)
						{
							Thread.Sleep(100);
							if (num < 90)
							{
								num += 5;
								val.ReportProgress(num);
							}
						}
					}
					while (num2 == 12);
					val.ReportProgress(100);
					Thread.Sleep(100);
					object obj = BM.U.Bqq;
					if (obj == null)
					{
						Action val5 = delegate
						{
							C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BDz());
						};
						BM.U.Bqq = val5;
						obj = (object)val5;
					}
					((Control)this).Invoke((Action)obj);
					Thread.Sleep(100);
					string text = P_1.Argument as string;
					val2 = global::A.S.a(text, global::A.M.B());
					if (val2 != null && ((Stream)val2).CanRead)
					{
						long num3 = 0L;
						if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
						{
							val3 = new ZipArchive((Stream)(object)val2, (ZipArchiveMode)0);
							ZipArchiveEntry val6 = null;
							System.Collections.Generic.IEnumerator<ZipArchiveEntry> enumerator = val3.Entries.GetEnumerator();
							try
							{
								while (((System.Collections.IEnumerator)enumerator).MoveNext())
								{
									ZipArchiveEntry current = enumerator.Current;
									if (current.Name.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()))
									{
										val6 = current;
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)enumerator)?.Dispose();
							}
							if (val6 != null)
							{
								val4 = val6.Open();
								num3 = val6.Length;
							}
						}
						else
						{
							val4 = (Stream)(object)val2;
							num3 = ((Stream)val2).Length;
						}
						val.ReportProgress(100);
						Thread.Sleep(500);
						int num4 = Qz.A(9497).ax();
						if (val4 != null && num3 != 0L && num3 == num4)
						{
							object obj2 = BM.U.BqR;
							if (obj2 == null)
							{
								Action val7 = delegate
								{
									C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdA());
								};
								BM.U.BqR = val7;
								obj2 = (object)val7;
							}
							((Control)this).Invoke((Action)obj2);
							int num5 = 0;
							while (num5 < num4)
							{
								int num6 = Math.Min((int)global::A.A.a(f.ao, global::A.f.Ba), num4 - num5);
								byte[] array = new byte[num6];
								if (!global::A.N.A(val4, array, 0, num6))
								{
									throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oB());
								}
								bool flag2 = false;
								int num7 = 2;
								do
								{
									if (global::A.A.A(f.ao, global::A.f.Ba, (uint)num5, array, out flag))
									{
										num5 += num6;
										val.ReportProgress((int)((long)num5 * 100L / num4));
										flag2 = true;
									}
									else
									{
										num7--;
									}
								}
								while (num7 != 0 && !flag2);
								if (!flag2)
								{
									throw new System.Exception(string.Concat(new string[5]
									{
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ob(),
										num6.ToString(),
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oC(),
										num5.ToString(),
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()
									}));
								}
							}
							return;
						}
						if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
						{
							throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oc());
						}
						throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oD());
					}
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.od());
				}
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oa());
			}
			catch (System.Exception ex)
			{
				P_1.Result = ex.Message;
			}
			finally
			{
				if (val4 != null)
				{
					val4.Dispose();
				}
				if (val3 != null)
				{
					val3.Dispose();
				}
				if (val2 != null)
				{
					((Stream)val2).Dispose();
				}
			}
		}

		private void d(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			P();
			if (P_1.Result is string)
			{
				bE.A((IWin32Window)(object)this, P_1.Result as string, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && RC != null)
			{
				((System.IDisposable)RC).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void G()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected O, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected O, but got Unknown
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected O, but got Unknown
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected O, but got Unknown
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected O, but got Unknown
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected O, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Expected O, but got Unknown
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected O, but got Unknown
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Expected O, but got Unknown
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected O, but got Unknown
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected O, but got Unknown
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Expected O, but got Unknown
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Expected O, but got Unknown
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Expected O, but got Unknown
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Expected O, but got Unknown
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected O, but got Unknown
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Expected O, but got Unknown
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected O, but got Unknown
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Expected O, but got Unknown
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Expected O, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected O, but got Unknown
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Expected O, but got Unknown
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Expected O, but got Unknown
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Expected O, but got Unknown
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Expected O, but got Unknown
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected O, but got Unknown
			//IL_0263: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Expected O, but got Unknown
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Expected O, but got Unknown
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected O, but got Unknown
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Expected O, but got Unknown
			//IL_028f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Expected O, but got Unknown
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected O, but got Unknown
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Expected O, but got Unknown
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ba: Expected O, but got Unknown
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Expected O, but got Unknown
			//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Expected O, but got Unknown
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Expected O, but got Unknown
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Expected O, but got Unknown
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Expected O, but got Unknown
			//IL_0308: Unknown result type (might be due to invalid IL or missing references)
			//IL_0312: Expected O, but got Unknown
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_031d: Expected O, but got Unknown
			//IL_031e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Expected O, but got Unknown
			//IL_0329: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Expected O, but got Unknown
			//IL_033f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Expected O, but got Unknown
			//IL_034a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0354: Expected O, but got Unknown
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_035f: Expected O, but got Unknown
			//IL_0360: Unknown result type (might be due to invalid IL or missing references)
			//IL_036a: Expected O, but got Unknown
			//IL_036b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Expected O, but got Unknown
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Expected O, but got Unknown
			//IL_0381: Unknown result type (might be due to invalid IL or missing references)
			//IL_038b: Expected O, but got Unknown
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Expected O, but got Unknown
			//IL_0397: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a1: Expected O, but got Unknown
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cd: Expected O, but got Unknown
			//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f9: Expected O, but got Unknown
			//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0404: Expected O, but got Unknown
			//IL_0405: Unknown result type (might be due to invalid IL or missing references)
			//IL_040f: Expected O, but got Unknown
			//IL_0410: Unknown result type (might be due to invalid IL or missing references)
			//IL_041a: Expected O, but got Unknown
			//IL_041b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0425: Expected O, but got Unknown
			//IL_0426: Unknown result type (might be due to invalid IL or missing references)
			//IL_0430: Expected O, but got Unknown
			//IL_0489: Unknown result type (might be due to invalid IL or missing references)
			//IL_0493: Expected O, but got Unknown
			//IL_055a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0564: Expected O, but got Unknown
			//IL_056e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0630: Unknown result type (might be due to invalid IL or missing references)
			//IL_063a: Expected O, but got Unknown
			//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0719: Unknown result type (might be due to invalid IL or missing references)
			//IL_0723: Expected O, but got Unknown
			//IL_0750: Unknown result type (might be due to invalid IL or missing references)
			//IL_0777: Unknown result type (might be due to invalid IL or missing references)
			//IL_0781: Expected O, but got Unknown
			//IL_0792: Unknown result type (might be due to invalid IL or missing references)
			//IL_079c: Expected O, but got Unknown
			//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07fa: Expected O, but got Unknown
			//IL_0816: Unknown result type (might be due to invalid IL or missing references)
			//IL_083d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0847: Expected O, but got Unknown
			//IL_0874: Unknown result type (might be due to invalid IL or missing references)
			//IL_089b: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a5: Expected O, but got Unknown
			//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ff: Expected O, but got Unknown
			//IL_091b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0942: Unknown result type (might be due to invalid IL or missing references)
			//IL_0978: Unknown result type (might be due to invalid IL or missing references)
			//IL_099f: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a9: Expected O, but got Unknown
			//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f7: Expected O, but got Unknown
			//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a51: Expected O, but got Unknown
			//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0acf: Expected O, but got Unknown
			//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b54: Expected O, but got Unknown
			//IL_0b8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bbb: Expected O, but got Unknown
			//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c15: Expected O, but got Unknown
			//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c89: Expected O, but got Unknown
			//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d27: Expected O, but got Unknown
			//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d85: Expected O, but got Unknown
			//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dac: Expected O, but got Unknown
			//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e0a: Expected O, but got Unknown
			//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e4b: Expected O, but got Unknown
			//IL_0e78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e9f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea9: Expected O, but got Unknown
			//IL_0eba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec4: Expected O, but got Unknown
			//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f18: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f22: Expected O, but got Unknown
			//IL_0f91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fd2: Expected O, but got Unknown
			//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
			//IL_1016: Unknown result type (might be due to invalid IL or missing references)
			//IL_1020: Expected O, but got Unknown
			//IL_103d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1047: Expected O, but got Unknown
			//IL_1064: Unknown result type (might be due to invalid IL or missing references)
			//IL_108b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1095: Expected O, but got Unknown
			//IL_10b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_10bc: Expected O, but got Unknown
			//IL_10d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1100: Unknown result type (might be due to invalid IL or missing references)
			//IL_110a: Expected O, but got Unknown
			//IL_1127: Unknown result type (might be due to invalid IL or missing references)
			//IL_1131: Expected O, but got Unknown
			//IL_114e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1175: Unknown result type (might be due to invalid IL or missing references)
			//IL_117f: Expected O, but got Unknown
			//IL_119c: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a6: Expected O, but got Unknown
			//IL_11c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_11f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1200: Expected O, but got Unknown
			//IL_121d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1227: Expected O, but got Unknown
			//IL_1244: Unknown result type (might be due to invalid IL or missing references)
			//IL_1277: Unknown result type (might be due to invalid IL or missing references)
			//IL_1281: Expected O, but got Unknown
			//IL_12d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_130c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1316: Expected O, but got Unknown
			//IL_1333: Unknown result type (might be due to invalid IL or missing references)
			//IL_135a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1364: Expected O, but got Unknown
			//IL_1381: Unknown result type (might be due to invalid IL or missing references)
			//IL_138b: Expected O, but got Unknown
			//IL_13a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_13cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_13d9: Expected O, but got Unknown
			//IL_13f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1400: Expected O, but got Unknown
			//IL_141d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1444: Unknown result type (might be due to invalid IL or missing references)
			//IL_144e: Expected O, but got Unknown
			//IL_146b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1475: Expected O, but got Unknown
			//IL_14a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_14d3: Expected O, but got Unknown
			//IL_150c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1533: Unknown result type (might be due to invalid IL or missing references)
			//IL_153d: Expected O, but got Unknown
			//IL_15d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_160a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1631: Unknown result type (might be due to invalid IL or missing references)
			//IL_163b: Expected O, but got Unknown
			//IL_1658: Unknown result type (might be due to invalid IL or missing references)
			//IL_168f: Unknown result type (might be due to invalid IL or missing references)
			//IL_16b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_16c0: Expected O, but got Unknown
			//IL_16dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1704: Unknown result type (might be due to invalid IL or missing references)
			//IL_170e: Expected O, but got Unknown
			//IL_172b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1752: Unknown result type (might be due to invalid IL or missing references)
			//IL_175c: Expected O, but got Unknown
			//IL_176d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1777: Expected O, but got Unknown
			//IL_1794: Unknown result type (might be due to invalid IL or missing references)
			//IL_17bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_17c5: Expected O, but got Unknown
			//IL_17e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1809: Unknown result type (might be due to invalid IL or missing references)
			//IL_1813: Expected O, but got Unknown
			//IL_1859: Unknown result type (might be due to invalid IL or missing references)
			//IL_1880: Unknown result type (might be due to invalid IL or missing references)
			//IL_188a: Expected O, but got Unknown
			//IL_18c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_18f5: Expected O, but got Unknown
			//IL_1932: Unknown result type (might be due to invalid IL or missing references)
			//IL_1959: Unknown result type (might be due to invalid IL or missing references)
			//IL_1963: Expected O, but got Unknown
			//IL_1980: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_19b1: Expected O, but got Unknown
			//IL_1a17: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a75: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a7f: Expected O, but got Unknown
			//IL_1a9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ac3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1acd: Expected O, but got Unknown
			//IL_1aea: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b11: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b1b: Expected O, but got Unknown
			//IL_1b38: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b69: Expected O, but got Unknown
			//IL_1b86: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bad: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bb7: Expected O, but got Unknown
			//IL_1bd4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bfb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c05: Expected O, but got Unknown
			//IL_1c6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c96: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ca0: Expected O, but got Unknown
			//IL_1cca: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cf1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cfb: Expected O, but got Unknown
			//IL_1d0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d16: Expected O, but got Unknown
			//IL_1d33: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d64: Expected O, but got Unknown
			//IL_1d75: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d7f: Expected O, but got Unknown
			//IL_1d9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dc3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dcd: Expected O, but got Unknown
			//IL_1dea: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e11: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e1b: Expected O, but got Unknown
			//IL_1e38: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e69: Expected O, but got Unknown
			//IL_1e86: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ead: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eb7: Expected O, but got Unknown
			//IL_1ed6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ee0: Expected O, but got Unknown
			//IL_1ef6: Unknown result type (might be due to invalid IL or missing references)
			//IL_2011: Unknown result type (might be due to invalid IL or missing references)
			//IL_2038: Unknown result type (might be due to invalid IL or missing references)
			//IL_207c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2086: Expected O, but got Unknown
			//IL_2098: Unknown result type (might be due to invalid IL or missing references)
			//IL_20a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_20cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_20f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_20fe: Expected O, but got Unknown
			//IL_2127: Unknown result type (might be due to invalid IL or missing references)
			//IL_2131: Expected O, but got Unknown
			//IL_2137: Unknown result type (might be due to invalid IL or missing references)
			//IL_2148: Unknown result type (might be due to invalid IL or missing references)
			//IL_216e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2182: Unknown result type (might be due to invalid IL or missing references)
			//IL_21b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_21c3: Expected O, but got Unknown
			//IL_21f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_2202: Expected O, but got Unknown
			//IL_2214: Unknown result type (might be due to invalid IL or missing references)
			//IL_2225: Unknown result type (might be due to invalid IL or missing references)
			//IL_2249: Unknown result type (might be due to invalid IL or missing references)
			//IL_2280: Unknown result type (might be due to invalid IL or missing references)
			//IL_228a: Expected O, but got Unknown
			//IL_22a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_22b1: Expected O, but got Unknown
			//IL_22c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_22d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_22f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_232f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2339: Expected O, but got Unknown
			//IL_2356: Unknown result type (might be due to invalid IL or missing references)
			//IL_2360: Expected O, but got Unknown
			//IL_2372: Unknown result type (might be due to invalid IL or missing references)
			//IL_2383: Unknown result type (might be due to invalid IL or missing references)
			//IL_23a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_23de: Unknown result type (might be due to invalid IL or missing references)
			//IL_23e8: Expected O, but got Unknown
			//IL_2411: Unknown result type (might be due to invalid IL or missing references)
			//IL_241b: Expected O, but got Unknown
			//IL_242d: Unknown result type (might be due to invalid IL or missing references)
			//IL_243e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2462: Unknown result type (might be due to invalid IL or missing references)
			//IL_2499: Unknown result type (might be due to invalid IL or missing references)
			//IL_24a3: Expected O, but got Unknown
			//IL_24cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_24d6: Expected O, but got Unknown
			//IL_24e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_24f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_251d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2554: Unknown result type (might be due to invalid IL or missing references)
			//IL_255e: Expected O, but got Unknown
			//IL_25b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_25c2: Expected O, but got Unknown
			//IL_25d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_25e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2615: Unknown result type (might be due to invalid IL or missing references)
			//IL_264c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2673: Unknown result type (might be due to invalid IL or missing references)
			//IL_267d: Expected O, but got Unknown
			//IL_26c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_26ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_26f4: Expected O, but got Unknown
			//IL_271d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2744: Unknown result type (might be due to invalid IL or missing references)
			//IL_274e: Expected O, but got Unknown
			//IL_2777: Unknown result type (might be due to invalid IL or missing references)
			//IL_2781: Expected O, but got Unknown
			//IL_2793: Unknown result type (might be due to invalid IL or missing references)
			//IL_27a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_27c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_27ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_27f9: Expected O, but got Unknown
			//IL_2822: Unknown result type (might be due to invalid IL or missing references)
			//IL_282c: Expected O, but got Unknown
			//IL_283e: Unknown result type (might be due to invalid IL or missing references)
			//IL_284f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2873: Unknown result type (might be due to invalid IL or missing references)
			//IL_289a: Unknown result type (might be due to invalid IL or missing references)
			//IL_28a4: Expected O, but got Unknown
			//IL_28cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_28d7: Expected O, but got Unknown
			//IL_28e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_28fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_291e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2945: Unknown result type (might be due to invalid IL or missing references)
			//IL_294f: Expected O, but got Unknown
			//IL_2978: Unknown result type (might be due to invalid IL or missing references)
			//IL_2982: Expected O, but got Unknown
			//IL_2994: Unknown result type (might be due to invalid IL or missing references)
			//IL_29a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_29c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a00: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a0a: Expected O, but got Unknown
			//IL_2a33: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a3d: Expected O, but got Unknown
			//IL_2a4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a60: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a84: Unknown result type (might be due to invalid IL or missing references)
			//IL_2aab: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ab5: Expected O, but got Unknown
			//IL_2ade: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ae8: Expected O, but got Unknown
			//IL_2afa: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b56: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b60: Expected O, but got Unknown
			//IL_2b95: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b9f: Expected O, but got Unknown
			//IL_2bb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bc2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2be6: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c27: Expected O, but got Unknown
			//IL_2c50: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c5a: Expected O, but got Unknown
			//IL_2c6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ca1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ce2: Expected O, but got Unknown
			//IL_2d0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d74: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d7e: Expected O, but got Unknown
			//IL_2da7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2db1: Expected O, but got Unknown
			//IL_2dc3: Unknown result type (might be due to invalid IL or missing references)
			//IL_2dd4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e04: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e37: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e41: Expected O, but got Unknown
			//IL_2e5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e68: Expected O, but got Unknown
			//IL_2e7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2eaf: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ef2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2efc: Expected O, but got Unknown
			//IL_2f25: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f2f: Expected O, but got Unknown
			//IL_2f41: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f52: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f76: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fad: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fb7: Expected O, but got Unknown
			//IL_2fe0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fea: Expected O, but got Unknown
			//IL_2ffc: Unknown result type (might be due to invalid IL or missing references)
			//IL_300d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3031: Unknown result type (might be due to invalid IL or missing references)
			//IL_3068: Unknown result type (might be due to invalid IL or missing references)
			//IL_3072: Expected O, but got Unknown
			//IL_309b: Unknown result type (might be due to invalid IL or missing references)
			//IL_30a5: Expected O, but got Unknown
			//IL_30b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_30c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_30ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_3123: Unknown result type (might be due to invalid IL or missing references)
			//IL_312d: Expected O, but got Unknown
			//IL_3156: Unknown result type (might be due to invalid IL or missing references)
			//IL_3160: Expected O, but got Unknown
			//IL_3166: Unknown result type (might be due to invalid IL or missing references)
			//IL_318a: Unknown result type (might be due to invalid IL or missing references)
			//IL_31b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_31bb: Expected O, but got Unknown
			//IL_31e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_31ee: Expected O, but got Unknown
			//IL_3200: Unknown result type (might be due to invalid IL or missing references)
			//IL_3211: Unknown result type (might be due to invalid IL or missing references)
			//IL_3235: Unknown result type (might be due to invalid IL or missing references)
			//IL_325c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3266: Expected O, but got Unknown
			//IL_3282: Unknown result type (might be due to invalid IL or missing references)
			//IL_328c: Expected O, but got Unknown
			//IL_3294: Unknown result type (might be due to invalid IL or missing references)
			//IL_32b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_32f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_330c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3316: Expected O, but got Unknown
			//IL_331e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3348: Unknown result type (might be due to invalid IL or missing references)
			//IL_3398: Unknown result type (might be due to invalid IL or missing references)
			//IL_33a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3477: Unknown result type (might be due to invalid IL or missing references)
			//IL_34ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_34b5: Expected O, but got Unknown
			//IL_34c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_34cc: Expected O, but got Unknown
			//IL_34ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_35c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3604: Unknown result type (might be due to invalid IL or missing references)
			//IL_360e: Expected O, but got Unknown
			//IL_361b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3625: Expected O, but got Unknown
			//IL_3644: Unknown result type (might be due to invalid IL or missing references)
			//IL_364e: Expected O, but got Unknown
			//IL_3656: Unknown result type (might be due to invalid IL or missing references)
			//IL_3680: Unknown result type (might be due to invalid IL or missing references)
			//IL_36eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_36f5: Expected O, but got Unknown
			//IL_36fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_370e: Unknown result type (might be due to invalid IL or missing references)
			//IL_373c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3762: Unknown result type (might be due to invalid IL or missing references)
			//IL_377f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3792: Unknown result type (might be due to invalid IL or missing references)
			//IL_37b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_37cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_37f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_380c: Unknown result type (might be due to invalid IL or missing references)
			//IL_382d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3847: Unknown result type (might be due to invalid IL or missing references)
			//IL_387a: Unknown result type (might be due to invalid IL or missing references)
			//IL_38a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_38d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_38f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_38fd: Expected O, but got Unknown
			//IL_3905: Unknown result type (might be due to invalid IL or missing references)
			//IL_392f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3964: Unknown result type (might be due to invalid IL or missing references)
			//IL_3981: Unknown result type (might be due to invalid IL or missing references)
			//IL_398b: Expected O, but got Unknown
			//IL_3993: Unknown result type (might be due to invalid IL or missing references)
			//IL_39bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_39f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a19: Expected O, but got Unknown
			//IL_3a21: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a80: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3aa7: Expected O, but got Unknown
			//IL_3aaf: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ad9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b19: Expected O, but got Unknown
			//IL_3b22: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b33: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ba7: Expected O, but got Unknown
			//IL_3bb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bca: Unknown result type (might be due to invalid IL or missing references)
			//IL_3bee: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c15: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c1f: Expected O, but got Unknown
			//IL_3c31: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ca9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3cb3: Expected O, but got Unknown
			//IL_3cbf: Unknown result type (might be due to invalid IL or missing references)
			//IL_3cc9: Expected O, but got Unknown
			//IL_3cf5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3cff: Expected O, but got Unknown
			//IL_3d07: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d11: Expected O, but got Unknown
			//IL_3d19: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d23: Expected O, but got Unknown
			//IL_3d2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d35: Expected O, but got Unknown
			//IL_3d3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d47: Expected O, but got Unknown
			//IL_3d4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d59: Expected O, but got Unknown
			ComponentResourceManager val = new ComponentResourceManager(typeof(BM));
			Rc = new MenuStrip();
			RD = new ToolStripMenuItem();
			RJ = new ToolStripMenuItem();
			Rd = new ToolStripMenuItem();
			RK = new ToolStripSeparator();
			rm = new ToolStripMenuItem();
			rM = new ToolStripMenuItem();
			Rk = new ToolStripSeparator();
			rv = new ToolStripMenuItem();
			rW = new ToolStripSeparator();
			RL = new ToolStripMenuItem();
			rP = new ToolStripMenuItem();
			ri = new ToolStripSeparator();
			rR = new ToolStripMenuItem();
			rS = new ToolStripMenuItem();
			rs = new ToolStripMenuItem();
			rT = new ToolStripMenuItem();
			rr = new ToolStripSeparator();
			rJ = new ToolStripMenuItem();
			RE = new ToolStripMenuItem();
			Rm = new ToolStripMenuItem();
			RN = new ToolStripMenuItem();
			rC = new ToolStripSeparator();
			ra = new ToolStripMenuItem();
			rB = new ToolStripMenuItem();
			Re = new ToolStripMenuItem();
			rc = new ToolStripMenuItem();
			rD = new ToolStripMenuItem();
			Ri = new ToolStripMenuItem();
			RM = new ToolStripMenuItem();
			Sb = new ToolStripMenuItem();
			Sc = new ToolStripMenuItem();
			RF = new ToolStripMenuItem();
			RT = new ToolStripMenuItem();
			Rt = new ToolStripMenuItem();
			Rl = new ToolStripMenuItem();
			RW = new ToolStripMenuItem();
			Rw = new ToolStripMenuItem();
			Rn = new ToolStripMenuItem();
			RQ = new ToolStripMenuItem();
			rY = new ToolStripMenuItem();
			rZ = new ToolStripMenuItem();
			rz = new ToolStripMenuItem();
			SA = new ToolStripMenuItem();
			ry = new ToolStripMenuItem();
			rX = new ToolStripMenuItem();
			RO = new ToolStripMenuItem();
			RP = new ToolStripMenuItem();
			Rp = new ToolStripMenuItem();
			Ro = new ToolStripMenuItem();
			RR = new ToolStripMenuItem();
			Rr = new ToolStripMenuItem();
			RS = new ToolStripMenuItem();
			Rs = new ToolStripMenuItem();
			Rv = new ToolStripMenuItem();
			ro = new ToolStripMenuItem();
			Sa = new ToolStripMenuItem();
			Rf = new ToolStripMenuItem();
			rH = new ToolStripMenuItem();
			rj = new ToolStripMenuItem();
			rK = new ToolStripMenuItem();
			rk = new ToolStripMenuItem();
			rx = new ToolStripMenuItem();
			RU = new ToolStripMenuItem();
			RG = new ToolStrip();
			rh = new ToolStripButton();
			rE = new aU();
			Ru = new au();
			RX = new ToolStripButton();
			rA = new ToolStripButton();
			rN = new ToolStripButton();
			Rx = new ToolStripButton();
			Sd = new ToolStripButton();
			rt = new aS();
			rU = new ToolStripMenuItem();
			ru = new ToolStripMenuItem();
			rV = new ToolStripMenuItem();
			RY = new ToolStripButton();
			Ry = new ToolStripButton();
			rd = new ToolStripButton();
			RZ = new ToolStripButton();
			Rz = new ToolStripButton();
			rb = new ToolStripButton();
			RV = new aV();
			rO = new ar();
			rg = new at();
			SC = new ToolStripDropDownButton();
			rf = new @as();
			rF = new av();
			re = new aT();
			rp = new ToolStripButton();
			rG = new ToolStripButton();
			rI = new Label();
			Rj = new PictureBox();
			rQ = new SplitContainer();
			rw = new SplitContainer();
			rl = new cR();
			Rg = new ae();
			RH = new ae();
			rn = new aC();
			rq = new aF();
			RI = new aF();
			Rh = new aF();
			Rq = new aF();
			SD = new ToolStripButton();
			rL = new ac();
			SB = new StartupOptionsPanel();
			((Control)Rc).SuspendLayout();
			((Control)RG).SuspendLayout();
			((ISupportInitialize)Rj).BeginInit();
			((ISupportInitialize)rQ).BeginInit();
			((Control)rQ.Panel1).SuspendLayout();
			((Control)rQ.Panel2).SuspendLayout();
			((Control)rQ).SuspendLayout();
			((ISupportInitialize)rw).BeginInit();
			((Control)rw.Panel1).SuspendLayout();
			((Control)rw.Panel2).SuspendLayout();
			((Control)rw).SuspendLayout();
			((Control)rl).SuspendLayout();
			((Control)this).SuspendLayout();
			((Control)Rc).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((ToolStrip)Rc).ImageScalingSize = new Size(30, 30);
			((ToolStrip)Rc).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[7]
			{
				(ToolStripItem)RD,
				(ToolStripItem)RE,
				(ToolStripItem)Re,
				(ToolStripItem)RF,
				(ToolStripItem)Rn,
				(ToolStripItem)RR,
				(ToolStripItem)Rf
			});
			((Control)Rc).Location = new Point(0, 0);
			((Control)Rc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oE();
			((Control)Rc).Size = new Size(1264, 24);
			((Control)Rc).TabIndex = 15;
			((Control)Rc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oe();
			((Control)Rc).Paint += new PaintEventHandler(A);
			((ToolStripDropDownItem)RD).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[14]
			{
				(ToolStripItem)RJ,
				(ToolStripItem)Rd,
				(ToolStripItem)RK,
				(ToolStripItem)rm,
				(ToolStripItem)rM,
				(ToolStripItem)Rk,
				(ToolStripItem)rv,
				(ToolStripItem)rW,
				(ToolStripItem)RL,
				(ToolStripItem)rP,
				(ToolStripItem)ri,
				(ToolStripItem)rR,
				(ToolStripItem)rr,
				(ToolStripItem)rJ
			});
			((ToolStripItem)RD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oF();
			((ToolStripItem)RD).Size = new Size(37, 20);
			((ToolStripItem)RD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ge();
			((ToolStripItem)RJ).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.of());
			((ToolStripItem)RJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oG();
			RJ.ShortcutKeys = (Keys)131150;
			((ToolStripItem)RJ).Size = new Size(173, 36);
			((ToolStripItem)RJ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.og();
			((ToolStripItem)RJ).Click += new EventHandler(ac);
			((ToolStripItem)Rd).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oH());
			((ToolStripItem)Rd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oh();
			Rd.ShortcutKeys = (Keys)131151;
			((ToolStripItem)Rd).Size = new Size(173, 36);
			((ToolStripItem)Rd).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oI();
			((ToolStripItem)Rd).Click += new EventHandler(ad);
			((ToolStripItem)RK).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oi();
			((ToolStripItem)RK).Size = new Size(170, 6);
			((ToolStripItem)rm).Enabled = false;
			((ToolStripItem)rm).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oJ());
			((ToolStripItem)rm).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oj();
			rm.ShortcutKeys = (Keys)131155;
			((ToolStripItem)rm).Size = new Size(173, 36);
			((ToolStripItem)rm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oK();
			((ToolStripItem)rm).Click += new EventHandler(aj);
			((ToolStripItem)rM).Enabled = false;
			((ToolStripItem)rM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ok();
			((ToolStripItem)rM).Size = new Size(173, 36);
			((ToolStripItem)rM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oL();
			((ToolStripItem)rM).Click += new EventHandler(aJ);
			((ToolStripItem)Rk).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ol();
			((ToolStripItem)Rk).Size = new Size(170, 6);
			((ToolStripItem)rv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oM();
			((ToolStripItem)rv).Size = new Size(173, 36);
			((ToolStripItem)rv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.om();
			((ToolStripItem)rW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oN();
			((ToolStripItem)rW).Size = new Size(170, 6);
			((ToolStripItem)RL).Enabled = false;
			((ToolStripItem)RL).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.on());
			((ToolStripItem)RL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oO();
			((ToolStripItem)RL).Size = new Size(173, 36);
			((ToolStripItem)RL).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oo();
			((ToolStripItem)RL).Click += new EventHandler(ab);
			((ToolStripItem)rP).Enabled = false;
			((ToolStripItem)rP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oP();
			((ToolStripItem)rP).Size = new Size(173, 36);
			((ToolStripItem)rP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FP();
			((ToolStripItem)rP).Click += new EventHandler(ai);
			((ToolStripItem)ri).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.op();
			((ToolStripItem)ri).Size = new Size(170, 6);
			((ToolStripDropDownItem)rR).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[3]
			{
				(ToolStripItem)rS,
				(ToolStripItem)rs,
				(ToolStripItem)rT
			});
			((ToolStripItem)rR).Enabled = false;
			((ToolStripItem)rR).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oQ());
			((ToolStripItem)rR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oq();
			((ToolStripItem)rR).Size = new Size(173, 36);
			((ToolStripItem)rR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ge();
			((ToolStripItem)rS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oR();
			((ToolStripItem)rS).Size = new Size(277, 22);
			((ToolStripItem)rS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.or();
			((ToolStripItem)rS).Click += new EventHandler(c);
			((ToolStripItem)rs).Enabled = false;
			((ToolStripItem)rs).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oS();
			rs.ShortcutKeys = (Keys)120;
			((ToolStripItem)rs).Size = new Size(277, 22);
			((ToolStripItem)rs).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.os();
			((ToolStripItem)rs).Click += new EventHandler(b);
			((ToolStripItem)rT).Enabled = false;
			((ToolStripItem)rT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oT();
			((ToolStripItem)rT).Size = new Size(277, 22);
			((ToolStripItem)rT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ot();
			((ToolStripItem)rT).Click += new EventHandler(C);
			((ToolStripItem)rr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oU();
			((ToolStripItem)rr).Size = new Size(170, 6);
			((ToolStripItem)rJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ou();
			((ToolStripItem)rJ).Size = new Size(173, 36);
			((ToolStripItem)rJ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oV();
			((ToolStripItem)rJ).Click += new EventHandler(P);
			((ToolStripDropDownItem)RE).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[5]
			{
				(ToolStripItem)Rm,
				(ToolStripItem)RN,
				(ToolStripItem)rC,
				(ToolStripItem)ra,
				(ToolStripItem)rB
			});
			((ToolStripItem)RE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ov();
			((ToolStripItem)RE).Size = new Size(39, 20);
			((ToolStripItem)RE).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oW();
			((ToolStripItem)Rm).Enabled = false;
			((ToolStripItem)Rm).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ow());
			((ToolStripItem)Rm).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oX();
			Rm.ShortcutKeys = (Keys)131162;
			((ToolStripItem)Rm).Size = new Size(158, 36);
			((ToolStripItem)Rm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mm();
			((ToolStripItem)Rm).Click += new EventHandler(ak);
			((ToolStripItem)RN).Enabled = false;
			((ToolStripItem)RN).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ox());
			((ToolStripItem)RN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oY();
			RN.ShortcutKeys = (Keys)131161;
			((ToolStripItem)RN).Size = new Size(158, 36);
			((ToolStripItem)RN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mn();
			((ToolStripItem)RN).Click += new EventHandler(aL);
			((ToolStripItem)rC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oy();
			((ToolStripItem)rC).Size = new Size(155, 6);
			((ToolStripItem)ra).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oZ());
			((ToolStripItem)ra).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oz();
			ra.ShortcutKeys = (Keys)131139;
			((ToolStripItem)ra).Size = new Size(158, 36);
			((ToolStripItem)ra).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mk();
			((ToolStripItem)ra).Click += new EventHandler(k);
			((ToolStripItem)rB).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PA());
			((ToolStripItem)rB).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pa();
			rB.ShortcutKeys = (Keys)131158;
			((ToolStripItem)rB).Size = new Size(158, 36);
			((ToolStripItem)rB).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ml();
			((ToolStripItem)rB).Click += new EventHandler(L);
			((ToolStripDropDownItem)Re).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[7]
			{
				(ToolStripItem)rc,
				(ToolStripItem)rD,
				(ToolStripItem)Ri,
				(ToolStripItem)RM,
				(ToolStripItem)Sb,
				(ToolStripItem)Sc,
				(ToolStripItem)Rw
			});
			((ToolStripItem)Re).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PB();
			((ToolStripItem)Re).Size = new Size(49, 20);
			((ToolStripItem)Re).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pb();
			((ToolStripItem)rc).Enabled = false;
			((ToolStripItem)rc).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PC());
			((ToolStripItem)rc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pc();
			((ToolStripItem)rc).Size = new Size(274, 36);
			((ToolStripItem)rc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PD();
			((ToolStripItem)rc).Click += new EventHandler(I);
			((ToolStripItem)rD).Enabled = false;
			((ToolStripItem)rD).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pd());
			((ToolStripItem)rD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PE();
			((ToolStripItem)rD).Size = new Size(274, 36);
			((ToolStripItem)rD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pe();
			((ToolStripItem)rD).Click += new EventHandler(E);
			((ToolStripItem)Ri).Enabled = false;
			((ToolStripItem)Ri).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PF());
			((ToolStripItem)Ri).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pf();
			((ToolStripItem)Ri).Size = new Size(274, 36);
			((ToolStripItem)Ri).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PG();
			((ToolStripItem)Ri).Click += new EventHandler(f);
			((ToolStripItem)RM).Enabled = false;
			((ToolStripItem)RM).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pg());
			((ToolStripItem)RM).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PH();
			((ToolStripItem)RM).Size = new Size(274, 36);
			((ToolStripItem)RM).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ph();
			((ToolStripItem)RM).Click += new EventHandler(G);
			((ToolStripItem)Sb).Enabled = false;
			((ToolStripItem)Sb).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PI());
			((ToolStripItem)Sb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pi();
			((ToolStripItem)Sb).Size = new Size(274, 36);
			((ToolStripItem)Sb).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PJ();
			((ToolStripItem)Sb).Visible = false;
			((ToolStripItem)Sb).Click += new EventHandler(g);
			((ToolStripItem)Sc).Enabled = false;
			((ToolStripItem)Sc).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pj());
			((ToolStripItem)Sc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PK();
			((ToolStripItem)Sc).Size = new Size(274, 36);
			((ToolStripItem)Sc).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pk();
			((ToolStripItem)Sc).Visible = false;
			((ToolStripItem)Sc).Click += new EventHandler(H);
			((ToolStripDropDownItem)RF).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[4]
			{
				(ToolStripItem)RT,
				(ToolStripItem)Rt,
				(ToolStripItem)Rl,
				(ToolStripItem)RW
			});
			((ToolStripItem)RF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PL();
			((ToolStripItem)RF).Size = new Size(46, 20);
			((ToolStripItem)RF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pl();
			((ToolStripItem)RT).Enabled = false;
			((ToolStripItem)RT).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PM());
			((ToolStripItem)RT).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pm();
			((ToolStripItem)RT).Size = new Size(216, 36);
			((ToolStripItem)RT).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PN();
			((ToolStripItem)RT).Click += new EventHandler(e);
			((ToolStripItem)Rt).Enabled = false;
			((ToolStripItem)Rt).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pn());
			((ToolStripItem)Rt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PO();
			((ToolStripItem)Rt).Size = new Size(216, 36);
			((ToolStripItem)Rt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hP();
			((ToolStripItem)Rt).Click += new EventHandler(F);
			((ToolStripItem)Rl).Enabled = false;
			((ToolStripItem)Rl).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Po());
			((ToolStripItem)Rl).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PP();
			((ToolStripItem)Rl).Size = new Size(216, 36);
			((ToolStripItem)Rl).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gn();
			((ToolStripItem)Rl).Click += new EventHandler(z);
			((ToolStripItem)RW).Enabled = false;
			((ToolStripItem)RW).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pp());
			((ToolStripItem)RW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PQ();
			RW.ShortcutKeys = (Keys)131195;
			((ToolStripItem)RW).Size = new Size(216, 36);
			((ToolStripItem)RW).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mo();
			((ToolStripItem)RW).Click += new EventHandler(t);
			((ToolStripItem)Rw).Enabled = false;
			((ToolStripItem)Rw).Image = (Image)(object)GeneralResources.IconErrorConfig;
			((ToolStripItem)Rw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pq();
			((ToolStripItem)Rw).Size = new Size(216, 36);
			((ToolStripItem)Rw).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ka();
			((ToolStripItem)Rw).Click += new EventHandler(h);
			((ToolStripDropDownItem)Rn).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[11]
			{
				(ToolStripItem)RQ,
				(ToolStripItem)rY,
				(ToolStripItem)rZ,
				(ToolStripItem)rz,
				(ToolStripItem)SA,
				(ToolStripItem)ry,
				(ToolStripItem)rX,
				(ToolStripItem)RO,
				(ToolStripItem)RP,
				(ToolStripItem)Rp,
				(ToolStripItem)Ro
			});
			((ToolStripItem)Rn).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PR();
			((ToolStripItem)Rn).Size = new Size(63, 20);
			((ToolStripItem)Rn).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jo();
			((ToolStripItem)RQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pr();
			((ToolStripItem)RQ).Size = new Size(398, 36);
			((ToolStripItem)RQ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ip();
			((ToolStripItem)RQ).Click += new EventHandler(l);
			((ToolStripItem)rY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PS();
			((ToolStripItem)rY).Size = new Size(398, 36);
			((ToolStripItem)rY).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ps();
			((ToolStripItem)rZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PT();
			((ToolStripItem)rZ).Size = new Size(398, 36);
			((ToolStripItem)rZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pt();
			((ToolStripItem)rZ).Click += new EventHandler(M);
			((ToolStripItem)rz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PU();
			((ToolStripItem)rz).Size = new Size(398, 36);
			((ToolStripItem)rz).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pu();
			((ToolStripItem)rz).Click += new EventHandler(m);
			((ToolStripItem)SA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PV();
			((ToolStripItem)SA).Size = new Size(398, 36);
			((ToolStripItem)SA).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pv();
			((ToolStripItem)SA).Click += new EventHandler(N);
			((ToolStripItem)ry).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PW());
			((ToolStripItem)ry).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pw();
			((ToolStripItem)ry).Size = new Size(398, 36);
			((ToolStripItem)ry).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jv();
			((ToolStripItem)ry).Click += new EventHandler(n);
			((ToolStripItem)rX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PX();
			((ToolStripItem)rX).Size = new Size(398, 36);
			((ToolStripItem)rX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gy();
			((ToolStripItem)rX).Click += new EventHandler(aF);
			((ToolStripItem)RO).Enabled = false;
			((ToolStripItem)RO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Px();
			RO.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lY();
			RO.ShortcutKeys = (Keys)117;
			((ToolStripItem)RO).Size = new Size(398, 36);
			((ToolStripItem)RO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PY();
			((ToolStripItem)RO).Click += new EventHandler(ae);
			((ToolStripItem)RP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Py();
			RP.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lZ();
			RP.ShortcutKeys = (Keys)118;
			((ToolStripItem)RP).Size = new Size(398, 36);
			((ToolStripItem)RP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lz();
			((ToolStripItem)RP).Click += new EventHandler(af);
			((ToolStripItem)Rp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PZ();
			Rp.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Pz();
			Rp.ShortcutKeys = (Keys)65654;
			((ToolStripItem)Rp).Size = new Size(398, 36);
			((ToolStripItem)Rp).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pA();
			((ToolStripItem)Rp).Click += new EventHandler(aG);
			((ToolStripItem)Ro).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pa();
			((ToolStripItem)Ro).Size = new Size(398, 36);
			((ToolStripItem)Ro).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pB();
			((ToolStripItem)Ro).Click += new EventHandler(ag);
			((ToolStripDropDownItem)RR).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[6]
			{
				(ToolStripItem)Rr,
				(ToolStripItem)RS,
				(ToolStripItem)Rs,
				(ToolStripItem)Rv,
				(ToolStripItem)ro,
				(ToolStripItem)Sa
			});
			((ToolStripItem)RR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pb();
			((ToolStripItem)RR).Size = new Size(80, 20);
			((ToolStripItem)RR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pC();
			((ToolStripItem)Rr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pc();
			((ToolStripItem)Rr).Size = new Size(209, 22);
			((ToolStripItem)Rr).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pD();
			((ToolStripItem)Rr).Click += new EventHandler(A);
			((ToolStripItem)RS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pd();
			((ToolStripItem)RS).Size = new Size(209, 22);
			((ToolStripItem)RS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pE();
			((ToolStripItem)RS).Click += new EventHandler(aK);
			((ToolStripItem)Rs).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pe();
			((ToolStripItem)Rs).Size = new Size(209, 22);
			((ToolStripItem)Rs).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pF();
			((ToolStripItem)Rs).Click += new EventHandler(i);
			((ToolStripItem)Rv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pf();
			((ToolStripItem)Rv).Size = new Size(209, 22);
			((ToolStripItem)Rv).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fq();
			((ToolStripItem)Rv).Click += new EventHandler(J);
			((ToolStripItem)ro).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pG();
			((ToolStripItem)ro).Size = new Size(209, 22);
			((ToolStripItem)ro).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pg();
			((ToolStripItem)ro).Click += new EventHandler(j);
			((ToolStripItem)Sa).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pH();
			((ToolStripItem)Sa).Size = new Size(209, 22);
			((ToolStripItem)Sa).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iH();
			((ToolStripItem)Sa).Click += new EventHandler(K);
			((ToolStripDropDownItem)Rf).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[6]
			{
				(ToolStripItem)rH,
				(ToolStripItem)rj,
				(ToolStripItem)rK,
				(ToolStripItem)rk,
				(ToolStripItem)rx,
				(ToolStripItem)RU
			});
			((ToolStripItem)Rf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ph();
			((ToolStripItem)Rf).Size = new Size(44, 20);
			((ToolStripItem)Rf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pI();
			((ToolStripItem)rH).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pi());
			((ToolStripItem)rH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pJ();
			rH.ShortcutKeys = (Keys)112;
			((ToolStripItem)rH).Size = new Size(193, 36);
			((ToolStripItem)rH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fm();
			((ToolStripItem)rH).Click += new EventHandler(aa);
			((ToolStripItem)rj).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pj());
			((ToolStripItem)rj).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pK();
			((ToolStripItem)rj).Size = new Size(193, 36);
			((ToolStripItem)rj).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pk();
			((ToolStripItem)rj).Click += new EventHandler(aI);
			((ToolStripItem)rK).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pL());
			((ToolStripItem)rK).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pl();
			((ToolStripItem)rK).Size = new Size(193, 36);
			((ToolStripItem)rK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pM();
			((ToolStripItem)rK).Click += new EventHandler(q);
			((ToolStripItem)rk).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pm();
			((ToolStripItem)rk).Size = new Size(193, 36);
			((ToolStripItem)rk).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ms();
			((ToolStripItem)rk).Click += new EventHandler(O);
			((ToolStripItem)rx).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pN();
			((ToolStripItem)rx).Size = new Size(193, 36);
			((ToolStripItem)rx).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pn();
			((ToolStripItem)rx).Click += new EventHandler(Q);
			((ToolStripItem)RU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pO();
			((ToolStripItem)RU).Size = new Size(193, 36);
			((ToolStripItem)RU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gY();
			((ToolStripItem)RU).Click += new EventHandler(p);
			((Control)RG).AutoSize = false;
			((Control)RG).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			RG.GripStyle = (ToolStripGripStyle)0;
			RG.ImageScalingSize = new Size(48, 48);
			RG.Items.AddRange((ToolStripItem[])(object)new ToolStripItem[25]
			{
				(ToolStripItem)rh,
				(ToolStripItem)rE,
				(ToolStripItem)Ru,
				(ToolStripItem)RX,
				(ToolStripItem)rA,
				(ToolStripItem)rN,
				(ToolStripItem)Rx,
				(ToolStripItem)rt,
				(ToolStripItem)RY,
				(ToolStripItem)Ry,
				(ToolStripItem)rd,
				(ToolStripItem)RZ,
				(ToolStripItem)Rz,
				(ToolStripItem)Sd,
				(ToolStripItem)SC,
				(ToolStripItem)rb,
				(ToolStripItem)RV,
				(ToolStripItem)rO,
				(ToolStripItem)rg,
				(ToolStripItem)SD,
				(ToolStripItem)rf,
				(ToolStripItem)rF,
				(ToolStripItem)re,
				(ToolStripItem)rp,
				(ToolStripItem)rG
			});
			((Control)RG).Location = new Point(0, 24);
			((Control)RG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.po();
			((Control)RG).Size = new Size(1264, 53);
			((Control)RG).TabIndex = 16;
			((Control)RG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pP();
			((ToolStripItem)rh).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)rh).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pp());
			((ToolStripItem)rh).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)rh).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rh).Margin = new Padding(0);
			((ToolStripItem)rh).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pQ();
			((ToolStripItem)rh).Size = new Size(52, 53);
			((ToolStripItem)rh).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pq();
			((ToolStripItem)rh).Click += new EventHandler(d);
			((ToolStripButton)rE).AutoToolTip = false;
			((ToolStripItem)rE).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)rE).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pR());
			((ToolStripItem)rE).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rE).Margin = new Padding(0);
			((ToolStripItem)rE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pr();
			((ToolStripItem)rE).Padding = new Padding(23, 0, 23, 0);
			((ToolStripItem)rE).Size = new Size(98, 53);
			((ToolStripItem)rE).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lx();
			((ToolStripItem)rE).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.lx();
			((ToolStripItem)rE).Click += new EventHandler(s);
			((ToolStripButton)Ru).AutoToolTip = false;
			((ToolStripItem)Ru).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)Ru).Enabled = false;
			((ToolStripItem)Ru).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pS());
			((ToolStripItem)Ru).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)Ru).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)Ru).Margin = new Padding(0);
			((ToolStripItem)Ru).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ps();
			((ToolStripItem)Ru).Size = new Size(52, 53);
			((ToolStripItem)Ru).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gm();
			((ToolStripItem)Ru).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gm();
			((ToolStripItem)Ru).Click += new EventHandler(t);
			((ToolStripItem)RX).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)RX).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pT());
			((ToolStripItem)RX).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)RX).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)RX).Margin = new Padding(0);
			((ToolStripItem)RX).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pt();
			((ToolStripItem)RX).Size = new Size(52, 53);
			((ToolStripItem)RX).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pU();
			((ToolStripItem)RX).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pU();
			((ToolStripItem)RX).Click += new EventHandler(ac);
			((ToolStripItem)rA).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)rA).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pu());
			((ToolStripItem)rA).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)rA).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rA).Margin = new Padding(0);
			((ToolStripItem)rA).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pV();
			((ToolStripItem)rA).Size = new Size(52, 53);
			((ToolStripItem)rA).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pv();
			((ToolStripItem)rA).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pv();
			((ToolStripItem)rA).Click += new EventHandler(ad);
			((ToolStripItem)rN).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)rN).Enabled = false;
			((ToolStripItem)rN).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pW());
			((ToolStripItem)rN).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)rN).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rN).Margin = new Padding(0);
			((ToolStripItem)rN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pw();
			((ToolStripItem)rN).Size = new Size(52, 53);
			((ToolStripItem)rN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pX();
			((ToolStripItem)rN).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pX();
			((ToolStripItem)rN).Click += new EventHandler(aj);
			((ToolStripItem)Rx).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)Rx).Enabled = false;
			((ToolStripItem)Rx).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.px());
			((ToolStripItem)Rx).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)Rx).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)Rx).Margin = new Padding(0);
			((ToolStripItem)Rx).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pY();
			((ToolStripItem)Rx).Size = new Size(52, 53);
			((ToolStripItem)Rx).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oo();
			((ToolStripItem)Rx).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.LS();
			((ToolStripItem)Rx).Click += new EventHandler(ab);
			((ToolStripItem)rt).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripDropDownItem)rt).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[3]
			{
				(ToolStripItem)rU,
				(ToolStripItem)ru,
				(ToolStripItem)rV
			});
			((ToolStripItem)rt).Enabled = false;
			((ToolStripItem)rt).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.py());
			((ToolStripItem)rt).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)rt).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rt).Margin = new Padding(0);
			((ToolStripItem)rt).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pZ();
			((ToolStripDropDownButton)rt).ShowDropDownArrow = false;
			((ToolStripItem)rt).Size = new Size(52, 53);
			((ToolStripItem)rt).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pz();
			((ToolStripItem)rU).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QA();
			((ToolStripItem)rU).Size = new Size(277, 22);
			((ToolStripItem)rU).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.or();
			((ToolStripItem)rU).Click += new EventHandler(c);
			((ToolStripItem)ru).Enabled = false;
			((ToolStripItem)ru).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qa();
			ru.ShortcutKeyDisplayString = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
			ru.ShortcutKeys = (Keys)120;
			((ToolStripItem)ru).Size = new Size(277, 22);
			((ToolStripItem)ru).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.os();
			((ToolStripItem)ru).Click += new EventHandler(b);
			((ToolStripItem)rV).Enabled = false;
			((ToolStripItem)rV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QB();
			((ToolStripItem)rV).Size = new Size(277, 22);
			((ToolStripItem)rV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ot();
			((ToolStripItem)rV).Click += new EventHandler(C);
			((ToolStripItem)RY).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)RY).Enabled = false;
			((ToolStripItem)RY).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qb());
			((ToolStripItem)RY).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)RY).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)RY).Margin = new Padding(0);
			((ToolStripItem)RY).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QC();
			((ToolStripItem)RY).Size = new Size(52, 53);
			((ToolStripItem)RY).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qc();
			((ToolStripItem)RY).Click += new EventHandler(ak);
			((ToolStripItem)Ry).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)Ry).Enabled = false;
			((ToolStripItem)Ry).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QD());
			((ToolStripItem)Ry).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)Ry).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)Ry).Margin = new Padding(0);
			((ToolStripItem)Ry).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qd();
			((ToolStripItem)Ry).Size = new Size(52, 53);
			((ToolStripItem)Ry).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QE();
			((ToolStripItem)Ry).Click += new EventHandler(aL);
			((ToolStripItem)rd).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)rd).Enabled = false;
			((ToolStripItem)rd).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qe());
			((ToolStripItem)rd).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)rd).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rd).Margin = new Padding(0);
			((ToolStripItem)rd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QF();
			((ToolStripItem)rd).Size = new Size(52, 53);
			((ToolStripItem)rd).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qf();
			((ToolStripItem)rd).Click += new EventHandler(E);
			((ToolStripItem)RZ).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)RZ).Enabled = false;
			((ToolStripItem)RZ).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QG());
			((ToolStripItem)RZ).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)RZ).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)RZ).Margin = new Padding(0);
			((ToolStripItem)RZ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qg();
			((ToolStripItem)RZ).Size = new Size(52, 53);
			((ToolStripItem)RZ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QH();
			((ToolStripItem)RZ).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PG();
			((ToolStripItem)RZ).Click += new EventHandler(f);
			((ToolStripItem)Rz).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)Rz).Enabled = false;
			((ToolStripItem)Rz).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qh());
			((ToolStripItem)Rz).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)Rz).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)Rz).Margin = new Padding(0);
			((ToolStripItem)Rz).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QI();
			((ToolStripItem)Rz).Size = new Size(52, 53);
			((ToolStripItem)Rz).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PN();
			((ToolStripItem)Rz).Click += new EventHandler(e);
			((ToolStripItem)rb).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)rb).Enabled = false;
			((ToolStripItem)rb).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qi());
			((ToolStripItem)rb).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)rb).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rb).Margin = new Padding(0);
			((ToolStripItem)rb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QJ();
			((ToolStripItem)rb).Size = new Size(52, 53);
			((ToolStripItem)rb).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ph();
			((ToolStripItem)rb).Click += new EventHandler(G);
			((ToolStripButton)RV).AutoToolTip = false;
			((ToolStripItem)RV).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)RV).Enabled = false;
			((ToolStripItem)RV).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qj());
			((ToolStripItem)RV).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)RV).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)RV).Margin = new Padding(0);
			((ToolStripItem)RV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QK();
			((ToolStripItem)RV).Size = new Size(52, 53);
			((ToolStripItem)RV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gn();
			((ToolStripItem)RV).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gn();
			((ToolStripItem)RV).Click += new EventHandler(z);
			((ToolStripButton)rO).AutoToolTip = false;
			((ToolStripItem)rO).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)rO).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qk());
			((ToolStripItem)rO).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)rO).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rO).Margin = new Padding(0);
			((ToolStripItem)rO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QL();
			((ToolStripItem)rO).Size = new Size(52, 53);
			((ToolStripItem)rO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gB();
			((ToolStripItem)rO).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gB();
			((ToolStripItem)rO).Click += new EventHandler(a);
			((ToolStripItem)rg).AutoSize = false;
			((ToolStripItem)rg).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)rg).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)rg).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rg).Margin = new Padding(0);
			((ToolStripItem)rg).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ql();
			((ToolStripDropDownButton)rg).ShowDropDownArrow = false;
			((ToolStripItem)rg).Size = new Size(52, 53);
			((ToolStripItem)rg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ip();
			((ToolStripItem)rg).Click += new EventHandler(l);
			((ToolStripItem)SC).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)SC).Enabled = false;
			((ToolStripItem)SC).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QM());
			((ToolStripItem)SC).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)SC).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)SC).Margin = new Padding(0);
			((ToolStripItem)SC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qm();
			SC.ShowDropDownArrow = false;
			((ToolStripItem)SC).Size = new Size(52, 53);
			((ToolStripItem)SC).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PJ();
			((ToolStripItem)SC).Visible = false;
			((ToolStripItem)SC).Click += new EventHandler(g);
			((ToolStripItem)SD).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)SD).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QN());
			((ToolStripItem)SD).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)SD).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)SD).Margin = new Padding(0);
			((ToolStripItem)SD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qn();
			((ToolStripItem)SD).Size = new Size(52, 53);
			((ToolStripItem)SD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ka();
			((ToolStripItem)SD).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ka();
			((ToolStripItem)SD).Visible = false;
			((ToolStripItem)SD).Click += new EventHandler(h);
			((ToolStripItem)rf).Alignment = (ToolStripItemAlignment)1;
			((ToolStripItem)rf).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)rf).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QO());
			((ToolStripItem)rf).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)rf).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rf).Margin = new Padding(0);
			((ToolStripItem)rf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qo();
			((ToolStripItem)rf).Size = new Size(52, 53);
			((ToolStripItem)rf).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QP();
			((ToolStripItem)rf).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qp();
			((ToolStripItem)rf).Click += new EventHandler(w);
			((ToolStripItem)rF).Alignment = (ToolStripItemAlignment)1;
			((ToolStripItem)rF).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)rF).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QQ());
			((ToolStripItem)rF).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)rF).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rF).Margin = new Padding(0);
			((ToolStripItem)rF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qq();
			((ToolStripItem)rF).Size = new Size(52, 53);
			((ToolStripItem)rF).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QR();
			((ToolStripItem)rF).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qr();
			((ToolStripItem)rF).Click += new EventHandler(W);
			((ToolStripItem)re).Alignment = (ToolStripItemAlignment)1;
			((ToolStripItem)re).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)re).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QS());
			((ToolStripItem)re).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)re).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)re).Margin = new Padding(0);
			((ToolStripItem)re).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qs();
			((ToolStripItem)re).Size = new Size(52, 53);
			((ToolStripItem)re).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QT();
			((ToolStripItem)re).ToolTipText = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qt();
			((ToolStripItem)re).Click += new EventHandler(v);
			((ToolStripItem)rp).Alignment = (ToolStripItemAlignment)1;
			((ToolStripItem)rp).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)rp).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QU());
			((ToolStripItem)rp).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rp).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qu();
			((ToolStripItem)rp).Size = new Size(52, 50);
			((ToolStripItem)rp).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QV();
			((ToolStripItem)rp).Click += new EventHandler(aA);
			((ToolStripItem)rG).Alignment = (ToolStripItemAlignment)1;
			((ToolStripItem)rG).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)rG).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qv());
			((ToolStripItem)rG).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)rG).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)rG).Margin = new Padding(0);
			((ToolStripItem)rG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QW();
			((ToolStripItem)rG).Size = new Size(52, 53);
			((ToolStripItem)rG).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pM();
			((ToolStripItem)rG).Click += new EventHandler(q);
			((Control)rI).AutoSize = true;
			((Control)rI).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 12f);
			((Control)rI).Location = new Point(0, 0);
			((Control)rI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qw();
			((Control)rI).Size = new Size(103, 21);
			((Control)rI).TabIndex = 30;
			((Control)rI).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QX();
			((Control)rI).Visible = false;
			((Control)Rj).BackColor = Color.Transparent;
			Rj.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qx());
			((Control)Rj).Location = new Point(0, 0);
			((Control)Rj).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QY();
			((Control)Rj).Size = new Size(800, 151);
			Rj.SizeMode = (PictureBoxSizeMode)1;
			Rj.TabIndex = 26;
			Rj.TabStop = false;
			rQ.Dock = (DockStyle)5;
			rQ.FixedPanel = (FixedPanel)1;
			((Control)rQ).Location = new Point(0, 77);
			((Control)rQ).Margin = new Padding(0);
			((Control)rQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qy();
			((Control)rQ.Panel1).Controls.Add((Control)(object)rw);
			rQ.Panel1MinSize = 10;
			((Control)rQ.Panel2).Controls.Add((Control)(object)rq);
			((Control)rQ.Panel2).Controls.Add((Control)(object)RI);
			((Control)rQ.Panel2).Controls.Add((Control)(object)Rh);
			((Control)rQ.Panel2).Controls.Add((Control)(object)Rq);
			rQ.Panel2MinSize = 200;
			((Control)rQ).Size = new Size(1264, 685);
			rQ.SplitterDistance = 1000;
			((Control)rQ).TabIndex = 31;
			rQ.SplitterMoved += new SplitterEventHandler(A);
			((Control)rQ).MouseMove += new MouseEventHandler(A);
			rw.Dock = (DockStyle)5;
			rw.FixedPanel = (FixedPanel)1;
			((Control)rw).Location = new Point(0, 0);
			((Control)rw).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.QZ();
			rw.Orientation = (Orientation)0;
			((Control)rw.Panel1).Controls.Add((Control)(object)SB);
			((Control)rw.Panel1).Controls.Add((Control)(object)rI);
			((Control)rw.Panel1).Controls.Add((Control)(object)rl);
			((Control)rw.Panel1).Controls.Add((Control)(object)Rj);
			rw.Panel1MinSize = 400;
			((Control)rw.Panel2).Controls.Add((Control)(object)rn);
			rw.Panel2MinSize = 0;
			((Control)rw).Size = new Size(1000, 685);
			rw.SplitterDistance = 400;
			rw.SplitterWidth = 1;
			((Control)rw).TabIndex = 0;
			rw.SplitterMoved += new SplitterEventHandler(a);
			((Control)rw).MouseMove += new MouseEventHandler(a);
			SB.BorderStyle = (BorderStyle)1;
			((Control)SB).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)SB).Location = new Point(0, 0);
			((Control)SB).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GM();
			((Control)SB).Size = new Size(549, 275);
			((Control)SB).TabIndex = 31;
			((Control)rl).Controls.Add((Control)(object)Rg);
			((Control)rl).Controls.Add((Control)(object)RH);
			((TabControl)rl).DrawMode = (TabDrawMode)1;
			((Control)rl).Enabled = false;
			((Control)rl).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8f);
			((Control)rl).Location = new Point(0, 0);
			((Control)rl).Margin = new Padding(0);
			((TabControl)rl).Multiline = true;
			((Control)rl).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Qz();
			((TabControl)rl).Padding = new Point(4, 3);
			((TabControl)rl).SelectedIndex = 0;
			((Control)rl).Size = new Size(741, 479);
			((Control)rl).TabIndex = 22;
			((Control)Rg).BackColor = SystemColors.Control;
			((TabPage)Rg).Location = new Point(4, 25);
			((Control)Rg).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qA();
			((Control)Rg).Padding = new Padding(3);
			((Control)Rg).Size = new Size(733, 450);
			((TabPage)Rg).TabIndex = 0;
			((Control)Rg).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qa();
			((Control)RH).BackColor = SystemColors.Control;
			((TabPage)RH).Location = new Point(4, 25);
			((Control)RH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qB();
			((Control)RH).Padding = new Padding(3);
			((Control)RH).Size = new Size(733, 450);
			((TabPage)RH).TabIndex = 1;
			((Control)RH).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qb();
			((Control)rn).Location = new Point(318, 33);
			((Control)rn).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FA();
			((Control)rn).Size = new Size(600, 63);
			((Control)rn).TabIndex = 28;
			((Control)rn).Visible = false;
			((ScrollableControl)rq).AutoScroll = true;
			((Control)rq).BackColor = SystemColors.Window;
			((Control)rq).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)rq).Location = new Point(0, 0);
			((Control)rq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qC();
			((Control)rq).Size = new Size(258, 683);
			((Control)rq).TabIndex = 24;
			((Control)rq).Visible = false;
			((ScrollableControl)RI).AutoScroll = true;
			((Control)RI).BackColor = SystemColors.Window;
			((Control)RI).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)RI).Location = new Point(0, 0);
			((Control)RI).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qc();
			((Control)RI).Size = new Size(258, 683);
			((Control)RI).TabIndex = 23;
			((Control)RI).Visible = false;
			((ScrollableControl)Rh).AutoScroll = true;
			((Control)Rh).BackColor = SystemColors.Window;
			((Control)Rh).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)Rh).Location = new Point(0, 0);
			((Control)Rh).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qD();
			((Control)Rh).Size = new Size(258, 683);
			((Control)Rh).TabIndex = 23;
			((Control)Rh).Visible = false;
			((ScrollableControl)Rq).AutoScroll = true;
			((Control)Rq).BackColor = SystemColors.Window;
			((Control)Rq).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)Rq).Location = new Point(0, 0);
			((Control)Rq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qd();
			((Control)Rq).Size = new Size(258, 683);
			((Control)Rq).TabIndex = 29;
			((Control)Rq).Visible = false;
			((Control)rL).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Control)rL).Location = new Point(6, 80);
			((Control)rL).Margin = new Padding(0);
			((Control)rL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qE();
			((Control)rL).Size = new Size(280, 678);
			((Control)rL).TabIndex = 21;
			((ToolStripItem)Sd).DisplayStyle = (ToolStripItemDisplayStyle)2;
			((ToolStripItem)Sd).Enabled = false;
			((ToolStripItem)Sd).Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qe());
			((ToolStripItem)Sd).ImageScaling = (ToolStripItemImageScaling)0;
			((ToolStripItem)Sd).ImageTransparentColor = Color.Magenta;
			((ToolStripItem)Sd).Margin = new Padding(0);
			((ToolStripItem)Sd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qF();
			((ToolStripItem)Sd).Size = new Size(52, 53);
			((ToolStripItem)Sd).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hP();
			((ToolStripItem)Sd).Click += new EventHandler(F);
			((Control)this).AllowDrop = true;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(1264, 762);
			((Control)this).Controls.Add((Control)(object)rL);
			((Control)this).Controls.Add((Control)(object)rQ);
			((Control)this).Controls.Add((Control)(object)RG);
			((Control)this).Controls.Add((Control)(object)Rc);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).Icon = (Icon)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qf());
			((Form)this).KeyPreview = true;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qG();
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qg();
			((Form)this).WindowState = (FormWindowState)2;
			((Form)this).Activated += new EventHandler(o);
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(D);
			((Control)this).Resize += new EventHandler(aC);
			((Control)this).DragDrop += new DragEventHandler(a);
			((Control)this).DragEnter += new DragEventHandler(A);
			((Control)Rc).ResumeLayout(false);
			((Control)Rc).PerformLayout();
			((Control)RG).ResumeLayout(false);
			((Control)RG).PerformLayout();
			((ISupportInitialize)Rj).EndInit();
			((Control)rQ.Panel1).ResumeLayout(false);
			((Control)rQ.Panel2).ResumeLayout(false);
			((ISupportInitialize)rQ).EndInit();
			((Control)rQ).ResumeLayout(false);
			((Control)rw.Panel1).ResumeLayout(false);
			((Control)rw.Panel1).PerformLayout();
			((Control)rw.Panel2).ResumeLayout(false);
			((ISupportInitialize)rw).EndInit();
			((Control)rw).ResumeLayout(false);
			((Control)rl).ResumeLayout(false);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}

		[SpecialName]
		internal static bool g()
		{
			return Sf;
		}

		private bool H()
		{
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Invalid comparison between Unknown and I4
			Sg = true;
			global::A.A.C();
			List<global::A.F> obj = global::A.A.c();
			string text = string.Empty;
			if (SI.Count == 1)
			{
				text = SI[0].BpS.ao;
			}
			Bf bf = new Bf(obj, text);
			DialogResult val = ((Form)bf).ShowDialog((IWin32Window)(object)this);
			string text2 = bf.a();
			BF bF = bf.B();
			((Component)bf).Dispose();
			if ((int)val == 1 && !string.IsNullOrEmpty(text2) && bF != 0)
			{
				if (!string.IsNullOrEmpty(text) && text2 == text && bF == BF.Ot)
				{
					Sg = false;
					return false;
				}
				global::A.F f = global::A.A.e(text2);
				if (f != null)
				{
					A(f, bF);
					if (!string.IsNullOrEmpty(text))
					{
						A(text);
					}
				}
				else
				{
					b(true);
				}
			}
			else
			{
				b(true);
			}
			Sg = false;
			return true;
		}

		private void h()
		{
			((Control)SH).Top = ((Control)RG).Bottom;
			if (!((Control)this).Controls.Contains((Control)(object)SH))
			{
				((Control)this).Controls.Add((Control)(object)SH);
			}
			SH.A();
		}

		internal static bool A(string P_0, bool P_1)
		{
			if (((uint)qI & (true ? 1u : 0u)) != 0 && ((qI & 2) == 0 || !P_1) && global::A.A.E(P_0) != global::A.g.BK)
			{
				return global::A.A.b(P_0);
			}
			return false;
		}

		private void s(object P_0, EventArgs P_1)
		{
			if (((uint)qI & 0x1000u) != 0)
			{
				ae();
			}
			else if (((uint)qI & (true ? 1u : 0u)) != 0)
			{
				if (((uint)qI & 2u) != 0)
				{
					A(true, false);
				}
				else if (global::A.A.c().Count > 1)
				{
					if (!Sg)
					{
						H();
					}
				}
				else
				{
					A(true, true);
				}
			}
			else if (global::A.A.B())
			{
				b(true);
			}
			else
			{
				B(true);
			}
		}

		internal static void B(bool P_0)
		{
			if (P_0)
			{
				global::A.A.A();
				return;
			}
			lock (qh)
			{
				qI |= 1;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void D(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = Sh;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref Sh, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void d(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = Sh;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref Sh, val3, val2);
			}
			while (val != val2);
		}

		internal static void b(bool P_0)
		{
			A(P_0, false);
		}

		internal static void A(bool P_0, bool P_1)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Invalid comparison between Unknown and I4
			if (P_0 && P_1 && !qW && !BH.A())
			{
				bool flag = false;
				BH bH = new BH();
				if ((int)((Form)bH).ShowDialog((IWin32Window)(object)QQ) != 1)
				{
					flag = true;
				}
				((Component)bH).Dispose();
				if (flag)
				{
					return;
				}
			}
			lock (qh)
			{
				qI &= -2;
				qI &= -3;
				qI &= -5;
				qI &= -33;
				qI &= -9;
				qI &= -65;
				qI &= -17;
				qI &= -129;
				qI &= -257;
			}
			if (TG != null && ((uint)qI & 0x800u) != 0)
			{
				TG.a();
			}
			if (Sh != null)
			{
				Sh.Invoke((object)null, (EventArgs)null);
			}
			if (P_0)
			{
				global::A.A.a();
			}
		}

		private void T(object P_0, EventArgs P_1)
		{
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Invalid comparison between Unknown and I4
			if (((Control)this).InvokeRequired)
			{
				try
				{
					E e = T;
					((Control)this).BeginInvoke((System.Delegate)e, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (!(P_0 is List<global::A.F>))
			{
				return;
			}
			List<global::A.F> val = P_0 as List<global::A.F>;
			bool flag = false;
			Enumerator<global::A.F> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					global::A.F current = enumerator.Current;
					bool flag2 = false;
					for (int i = 0; i < SI.Count; i++)
					{
						if (SI[i].BpS.ao == current.ao)
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						flag = true;
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (!flag)
			{
				return;
			}
			if (qW)
			{
				Console.WriteLine();
				Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qH());
			}
			else
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qH(), true);
			}
			List<global::A.F> val2 = global::A.A.c();
			enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					global::A.F current2 = enumerator.Current;
					bj.A(current2.aH, current2.ah);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			bool flag3 = Process.GetProcessesByName(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qh()).Length > 1;
			if (val2.Count == 1)
			{
				if (qS != null || qr)
				{
					qs = new bW
					{
						axS = val2[0].aH,
						axs = val2[0].ah,
						axT = new global::A.k(val2[0].ae, val2[0].aF, val2[0].af, val2[0].aG, val2[0].ag),
						axt = val2[0].aO
					};
					if (qS != null)
					{
						a(qS, qs);
					}
					else if (qr)
					{
						A(qs);
					}
					b(true);
				}
				else if (qT)
				{
					A(val2[0], BF.Ou);
					if (SI.Count == 2)
					{
						A(SI[1].BpS.ao);
					}
				}
				else if (((Qz == null || !Qz.c() || !Qz.E() || SG) && !flag3) || val2[0].aH == 22)
				{
					if ((int)A((IWin32Window)(object)this, true) == 2)
					{
						b(true);
						return;
					}
					A(val2[0], BF.OU);
					if (SI.Count == 2)
					{
						A(SI[1].BpS.ao);
					}
				}
				else if (!qW && !Sg)
				{
					H();
				}
			}
			else
			{
				if (qW)
				{
					return;
				}
				bool flag4 = false;
				if (Qz != null && Qz.c() && Qz.E())
				{
					enumerator = val2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							global::A.F current3 = enumerator.Current;
							if (current3.ao == Qz.aXc && A(current3.ao, true) && !val.Contains(current3))
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
				}
				if (flag4)
				{
					h();
				}
				else if ((Qz == null || (Qz.c() && Qz.E())) && !Sg)
				{
					H();
				}
			}
		}

		internal void A(global::A.F P_0, BF P_1)
		{
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			if (!qW && ((Control)rn).Visible)
			{
				ae();
			}
			bool flag;
			bool flag2 = A(P_0, out flag);
			if (flag)
			{
				return;
			}
			if (P_1 == BF.OU && !flag2)
			{
				lock (qh)
				{
					qI |= 2;
				}
			}
			A(P_0);
			if ((qI & 1) == 0)
			{
				B(false);
				if (flag2)
				{
					lock (qh)
					{
						qI &= -3;
					}
				}
			}
			if (!flag2)
			{
				if (Qz == null)
				{
					B(P_0);
				}
				else if (qH != null)
				{
					if (P_0.ao != qH)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qI(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						a(P_0, P_1);
					}
					else
					{
						lock (qh)
						{
							qI &= -3;
						}
					}
				}
				else
				{
					a(P_0, P_1);
				}
			}
			qH = null;
		}

		private void A(global::A.F P_0)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			d d = new d();
			d.BpS = P_0;
			BackgroundWorker val = new BackgroundWorker();
			val.WorkerSupportsCancellation = true;
			val.DoWork += new DoWorkEventHandler(E);
			val.RunWorkerAsync((object)P_0);
			d.Bps = val;
			if (SI.Count == 0)
			{
				SI.Add(d);
			}
			else
			{
				SI.Insert(0, d);
			}
		}

		private void A(object P_0, global::A.E P_1)
		{
			if (P_1.t != global::A.d.T)
			{
				return;
			}
			if (((Control)this).InvokeRequired)
			{
				try
				{
					e e = A;
					((Control)this).Invoke((System.Delegate)e, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (P_0 is string)
			{
				string text = P_0 as string;
				if (global::A.A.E(text) == global::A.g.BK)
				{
					A(text);
					global::A.A.C();
				}
				if (global::A.A.c().Count == 0)
				{
					b(false);
				}
			}
		}

		internal void A(string P_0)
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < SI.Count; i++)
			{
				d d = SI[i];
				if (d.BpS.ao == P_0)
				{
					d.Bps.CancelAsync();
					SI.Remove(d);
					break;
				}
			}
			QM = BM.a.BpC;
			if (!qW)
			{
				qd.StorePendingStats();
				if (((uint)qI & 0x10u) != 0)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qi(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
		}

		private void E(object P_0, DoWorkEventArgs P_1)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected O, but got Unknown
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			global::A.F f = P_1.Argument as global::A.F;
			Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qJ() + f.ao;
			Stopwatch val2 = new Stopwatch();
			val2.Start();
			new Stopwatch().Start();
			Stopwatch val3 = new Stopwatch();
			int num = 0;
			Stopwatch val4 = new Stopwatch();
			while (true)
			{
				if (!Se)
				{
					b(true);
					Thread.Sleep(500);
					continue;
				}
				if (f.aH == 22)
				{
					Thread.Sleep(500);
					continue;
				}
				if (!qW && rL.b())
				{
					Thread.Sleep(100);
					continue;
				}
				if (val.CancellationPending)
				{
					break;
				}
				val4.Restart();
				try
				{
					if (val.CancellationPending)
					{
						break;
					}
					if ((qI & 1) == 0)
					{
						val3.Reset();
					}
					if (val.CancellationPending)
					{
						break;
					}
					Framework framework = Qz;
					if (Sf)
					{
						if (((uint)qI & (true ? 1u : 0u)) != 0 && (qI & 2) == 0)
						{
							bool flag = global::A.A.C(f.ao);
							bool flag2 = CZ.A(f);
							if (flag)
							{
								global::A.A.c(f.ao);
							}
							if (flag2)
							{
								framework?.D();
								if (QM == BM.a.Bpc || QM == BM.a.Bpe)
								{
									QM = BM.a.BpD;
								}
							}
							else if (!flag)
							{
								Sf = false;
								((Control)this).BeginInvoke((Action)([CompilerGenerated] () =>
								{
									//IL_000e: Unknown result type (might be due to invalid IL or missing references)
									bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tJ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
								}));
							}
						}
						Sf = false;
					}
					else if (Qm)
					{
						if (((uint)qI & (true ? 1u : 0u)) != 0)
						{
							global::A.A.B(f.ao, out var _);
						}
						Qm = false;
					}
					else if (qH == null && !Rb && framework != null && (qI & 0x80) == 0 && QM != BM.a.BpE)
					{
						if (framework.c() && sY.Count == 0)
						{
							if ((qI & 2) == 0 && (qI & 0x100) == 0 && (qI & 0x200) == 0 && (qI & 0x20) == 0 && (qI & 0x40) == 0)
							{
								bool flag4 = !Be.G() && global::A.A.n == global::A.b.q;
								if (((uint)qI & (true ? 1u : 0u)) != 0 && global::A.A.b(f.ao))
								{
									if (!qW && ((val2.ElapsedMilliseconds > 500 && !flag4) || (val2.ElapsedMilliseconds > 1500 && flag4)))
									{
										O();
										val2.Restart();
									}
									if (val.CancellationPending)
									{
										break;
									}
									int num2 = 0;
									bool flag5;
									lock (Si)
									{
										flag5 = framework.B(ref num2);
									}
									if (val.CancellationPending)
									{
										break;
									}
									if (framework.E() && (qI & 0x20) == 0)
									{
										if (flag4)
										{
											framework.A(1500L);
										}
										else
										{
											framework.A(300L);
										}
									}
									if (val.CancellationPending)
									{
										break;
									}
									int num3 = 0;
									bool flag6;
									lock (Si)
									{
										flag6 = framework.a(ref num3);
									}
									if (val.CancellationPending)
									{
										break;
									}
									lock (qh)
									{
										if (flag6)
										{
											qI |= 4;
										}
										else
										{
											qI &= -5;
										}
										if (flag5)
										{
											qI |= 8;
										}
										else
										{
											qI &= -9;
										}
										if (C(false))
										{
											qI |= 16;
										}
										else
										{
											qI &= -17;
										}
										if (flag5)
										{
											SF.Restart();
										}
									}
									framework.S();
								}
								if (val.CancellationPending)
								{
									break;
								}
								bool flag7 = !qW && (qI & 0x1000) != 0;
								if (((uint)qI & (true ? 1u : 0u)) != 0)
								{
									if (global::A.A.b(f.ao) && !flag7)
									{
										int num4 = 0;
										framework.A(ref num4);
										if (!Qz.aWW.IsValid)
										{
											k();
										}
										if (!aE())
										{
											framework.s();
										}
										if (QM == BM.a.BpD)
										{
											QM = BM.a.Bpd;
										}
										if (val.CancellationPending)
										{
											break;
										}
										if (!qW)
										{
											string empty = string.Empty;
											bool flag8 = framework.A(ref empty);
											if (framework.E() && flag8)
											{
												Be.d(empty);
												if (Be.nv && !qw && ((uint)qI & 0x800u) != 0)
												{
													TG.B();
												}
											}
										}
										if (val.CancellationPending || val.CancellationPending)
										{
											break;
										}
									}
									else
									{
										global::A.A.A(f.ao, global::A.f.aX, 0u, 4u, out var _, out var _);
									}
								}
								if (((uint)qI & (true ? 1u : 0u)) != 0 && global::A.A.b(f.ao) && val3.ElapsedMilliseconds <= 5500 && (val3.ElapsedMilliseconds == 0L || val3.ElapsedMilliseconds - num >= 1000))
								{
									val3.Start();
									num = (int)val3.ElapsedMilliseconds;
									global::A.A.C(f.ao, out var _);
								}
							}
							if (!qW && ((uint)qI & 0x400u) != 0)
							{
								Tf.B();
							}
						}
						else
						{
							Thread.Sleep(100);
							if (((uint)qI & (true ? 1u : 0u)) != 0)
							{
								global::A.A.A(f.ao, global::A.f.aX, 0u, 4u, out var _, out var _);
							}
						}
					}
					val4.Stop();
					int num5 = (int)val4.ElapsedMilliseconds;
					int num6 = ((num5 != 0) ? (1000 / num5) : 0);
					if ((qI & 0x200) == 0)
					{
						global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qj() + f.ao + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qK(), (object)num5, (object)num6), false);
					}
					if (num5 < 40)
					{
						Thread.Sleep(40 - num5);
					}
					else
					{
						Thread.Sleep(0);
					}
					if (val.CancellationPending)
					{
						break;
					}
				}
				catch (System.Exception ex)
				{
					global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qk() + ex.Message, true);
				}
			}
		}

		internal bool I()
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			if (Qz != null)
			{
				TimeSpan val;
				if (Qz.awZ == 21)
				{
					val = System.DateTime.Now - SJ;
					return ((TimeSpan)(ref val)).TotalMilliseconds < 6000.0;
				}
				val = System.DateTime.Now - SJ;
				return ((TimeSpan)(ref val)).TotalMilliseconds < 2000.0;
			}
			return false;
		}

		internal void t(object P_0, EventArgs P_1)
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Invalid comparison between Unknown and I4
			if (I())
			{
				return;
			}
			SJ = System.DateTime.Now;
			if (SI.Count != 1 || C(false))
			{
				return;
			}
			bool flag = Qz != null && Qz.awZ != 21 && Qz.o();
			if (!flag || BU.A())
			{
				i();
				return;
			}
			BU bU = new BU();
			if ((int)((Form)bU).ShowDialog((IWin32Window)(object)this) == 1)
			{
				i();
			}
			((Component)bU).Dispose();
		}

		internal void i()
		{
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Invalid comparison between Unknown and I4
			if (Qz == null || !global::A.A.b(Qz.aXc))
			{
				return;
			}
			bool num = global::A.A.C(Qz.aXc);
			Sf = true;
			if (!num)
			{
				return;
			}
			qH = Qz.aXc;
			while (Sf)
			{
				Thread.Sleep(0);
			}
			qg = new bI();
			if ((int)((Form)qg).ShowDialog((IWin32Window)(object)this) == 1)
			{
				Qz.D();
			}
			else
			{
				global::A.A.a(Qz.aXc);
				if (global::A.A.c().Count == 0)
				{
					b(false);
				}
			}
			qH = null;
			((Component)qg).Dispose();
		}

		internal static bool C(bool P_0)
		{
			if (Qz != null && Qz.c())
			{
				Setting setting = Qz.A(23);
				if (setting != null)
				{
					if (P_0)
					{
						int num = setting.BB();
						int num2 = 10;
						bool flag2;
						do
						{
							flag2 = global::A.A.A(Qz.aXc, global::A.f.aX, (uint)setting.a(), (uint)num, out var array, out var _);
							if (flag2)
							{
								for (int i = 0; i < num; i++)
								{
									setting.A(i, array[i], false);
								}
							}
							num2--;
						}
						while (num2 != 0 && !flag2);
						if (!flag2)
						{
							return false;
						}
					}
					return setting.ax() != 0;
				}
				return false;
			}
			return false;
		}

		private void a(global::A.F P_0, BF P_1)
		{
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected O, but got Unknown
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Expected O, but got Unknown
			//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Expected O, but got Unknown
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Expected O, but got Unknown
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected O, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Expected O, but got Unknown
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected O, but got Unknown
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			if (!CZ.A(P_0, true))
			{
				if (P_1 == BF.OU)
				{
					w();
					d();
				}
				Qz.Q();
				int num = P_0.aH;
				int num2 = P_0.ah;
				byte[] aO = P_0.aO;
				global::A.k k = new global::A.k(P_0.ae, P_0.aF, P_0.af, P_0.aG, P_0.ag);
				if (!qW && a(k))
				{
					return;
				}
				switch (P_1)
				{
				case BF.OU:
				{
					string text = bT.A(num, num2, k, aO, true);
					if (!string.IsNullOrEmpty(text))
					{
						Framework framework = new Framework(text, num, num2, k);
						framework.aXc = P_0.ao;
						F f = new F
						{
							BpT = framework,
							Bpt = P_0
						};
						BackgroundWorker val = new BackgroundWorker
						{
							WorkerReportsProgress = true
						};
						val.DoWork += new DoWorkEventHandler(F);
						object obj = BM.t.Bqk;
						if (obj == null)
						{
							ProgressChangedEventHandler val2 = a;
							BM.t.Bqk = val2;
							obj = (object)val2;
						}
						val.ProgressChanged += (ProgressChangedEventHandler)obj;
						val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(e);
						C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qL());
						val.RunWorkerAsync((object)f);
						break;
					}
					if (P_0.@as[3].BF != 0)
					{
						lock (qh)
						{
							qI |= 128;
						}
						BackgroundWorker val3 = new BackgroundWorker
						{
							WorkerReportsProgress = true
						};
						val3.DoWork += new DoWorkEventHandler(R);
						object obj2 = BM.t.Bqk;
						if (obj2 == null)
						{
							ProgressChangedEventHandler val4 = a;
							BM.t.Bqk = val4;
							obj2 = (object)val4;
						}
						val3.ProgressChanged += (ProgressChangedEventHandler)obj2;
						val3.RunWorkerCompleted += new RunWorkerCompletedEventHandler(r);
						C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ql());
						val3.RunWorkerAsync((object)P_0);
						break;
					}
					BackgroundWorker val5 = new BackgroundWorker();
					object obj3 = BM.t.BqL;
					if (obj3 == null)
					{
						DoWorkEventHandler val6 = bj.D;
						BM.t.BqL = val6;
						obj3 = (object)val6;
					}
					val5.DoWork += (DoWorkEventHandler)obj3;
					val5.WorkerReportsProgress = true;
					object obj4 = BM.t.Bqk;
					if (obj4 == null)
					{
						ProgressChangedEventHandler val7 = a;
						BM.t.Bqk = val7;
						obj4 = (object)val7;
					}
					val5.ProgressChanged += (ProgressChangedEventHandler)obj4;
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ns());
					BackgroundWorker val8 = new BackgroundWorker();
					val8.DoWork += new DoWorkEventHandler(e);
					val8.RunWorkerCompleted += new RunWorkerCompletedEventHandler(E);
					val5.RunWorkerAsync();
					val8.RunWorkerAsync((object)P_0);
					bj.abM = true;
					break;
				}
				case BF.Ou:
					if (num == Qz.awZ && num2 == Qz.awz && k == Qz.aXA)
					{
						Qz.A(0L);
						Qz.aXc = P_0.ao;
						A(null, -1, false);
						break;
					}
					if (!qW)
					{
						if (num != Qz.awZ || num2 != Qz.awz)
						{
							bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qM(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						}
						else
						{
							bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qN(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qn(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						}
					}
					b(true);
					break;
				}
				return;
			}
			lock (qh)
			{
				qI &= -3;
			}
		}

		private void e(object P_0, DoWorkEventArgs P_1)
		{
			global::A.F f = (global::A.F)P_1.Argument;
			global::A.k k = new global::A.k(f.ae, f.aF, f.af, f.aG, f.ag);
			string text = CZ.A(new bW
			{
				axS = f.aH,
				axs = f.ah,
				axT = k,
				axt = f.aO
			}, f.aJ);
			int? num;
			UpdateOutcomes updateOutcomes;
			string[] bQQ = bj.A(k, f.aH, f.ah, text, out num, out updateOutcomes);
			L l = default(L);
			l.BQP = f;
			if (num.HasValue && updateOutcomes == UpdateOutcomes.CompleteUpdate)
			{
				l.BQp = updateOutcomes;
				l.BQQ = bQQ;
			}
			P_1.Result = l;
		}

		private void E(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Invalid comparison between Unknown and I4
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Invalid comparison between Unknown and I4
			L l = (L)P_1.Result;
			global::A.F bQP = l.BQP;
			P();
			if (l.BQQ != null && l.BQQ.Length != 0)
			{
				string[] bQQ = l.BQQ;
				foreach (string text in bQQ)
				{
					List<string> val;
					if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()))
					{
						val = new List<string>();
						val.Add(text);
					}
					else
					{
						val = bT.b(text);
					}
					if (val.Count != 0 && A(text, bQP))
					{
						return;
					}
				}
			}
			string text2 = bx.C(bQP.aH, bQP.ah);
			text2 = ((text2 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
			global::A.k k = new global::A.k(bQP.ae, bQP.aF, bQP.af, bQP.aG, bQP.ag);
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)k).ToString();
			if (!qW && (int)bE.A((IWin32Window)(object)this, text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !A(((FileDialog)qE).FileName, bQP))
				{
				}
			}
		}

		private bool A(string P_0, global::A.F P_1)
		{
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected O, but got Unknown
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected O, but got Unknown
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected O, but got Unknown
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				global::A.k k = new global::A.k(P_1.ae, P_1.aF, P_1.af, P_1.aG, P_1.ag);
				int num = P_1.aH;
				int num2 = P_1.ah;
				byte[] aO = P_1.aO;
				bW bW = new bW
				{
					axS = num,
					axs = num2,
					axT = k,
					axt = aO
				};
				string text = null;
				bool flag3;
				bool flag;
				bool flag2;
				global::A.k k2;
				if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nz()))
				{
					flag3 = CZ.A(P_0, bW, out flag, out flag2, out k2, out text);
				}
				else
				{
					text = P_0;
					flag3 = bT.A(P_0, bW, out flag, out flag2, out k2);
				}
				if (flag3 && text != null)
				{
					Framework framework = new Framework(text, num, num2, k);
					framework.aXc = P_1.ao;
					F f = new F
					{
						BpT = framework,
						Bpt = P_1
					};
					BackgroundWorker val = new BackgroundWorker
					{
						WorkerReportsProgress = true
					};
					val.DoWork += new DoWorkEventHandler(F);
					object obj = BM.t.Bqk;
					if (obj == null)
					{
						ProgressChangedEventHandler val2 = a;
						BM.t.Bqk = val2;
						obj = (object)val2;
					}
					val.ProgressChanged += (ProgressChangedEventHandler)obj;
					val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(e);
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qL());
					val.RunWorkerAsync((object)f);
					return true;
				}
				if (!qW)
				{
					if (k2 == null || text == null)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else if (!flag)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qo(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else if (!flag2)
					{
						bE.A((IWin32Window)(object)this, string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nB(),
							((object)k2).ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qP(),
							((object)k).ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
						}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
			}
			catch (System.Exception ex)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qp() + ex.Message, true);
			}
			return false;
		}

		private void F(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			Thread.Sleep(100);
			val.ReportProgress(30);
			F f = P_1.Argument as F;
			Framework bpT = f.BpT;
			bV.A a = bpT.a();
			val.ReportProgress(80);
			if (a == bV.A.Brc && bpT.awZ == 21)
			{
				bpT.f();
				val.ReportProgress(90);
			}
			Thread.Sleep(100);
			val.ReportProgress(100);
			P_1.Result = new f
			{
				BpU = a,
				Bpu = bpT,
				BpV = f.Bpt
			};
		}

		private void e(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Invalid comparison between Unknown and I4
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Invalid comparison between Unknown and I4
			P();
			f obj = P_1.Result as f;
			Framework bpu = obj.Bpu;
			bV.A bpU = obj.BpU;
			global::A.F bpV = obj.BpV;
			if (bpU == bV.A.Brc)
			{
				Qz = bpu;
				A((BackgroundWorker)null, -1);
				return;
			}
			string empty = string.Empty;
			switch (bpU)
			{
			case bV.A.BrD:
			{
				BackgroundWorker val = new BackgroundWorker();
				object obj2 = BM.t.BqL;
				if (obj2 == null)
				{
					DoWorkEventHandler val2 = bj.D;
					BM.t.BqL = val2;
					obj2 = (object)val2;
				}
				val.DoWork += (DoWorkEventHandler)obj2;
				val.WorkerReportsProgress = true;
				object obj3 = BM.t.Bqk;
				if (obj3 == null)
				{
					ProgressChangedEventHandler val3 = a;
					BM.t.Bqk = val3;
					obj3 = (object)val3;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj3;
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ns());
				BackgroundWorker val4 = new BackgroundWorker();
				val4.DoWork += new DoWorkEventHandler(f);
				val4.RunWorkerCompleted += new RunWorkerCompletedEventHandler(F);
				G g = new G
				{
					BpW = bpV,
					Bpv = bpu
				};
				val.RunWorkerAsync();
				val4.RunWorkerAsync((object)g);
				bj.abM = true;
				return;
			}
			case bV.A.Brd:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NT();
				break;
			case bV.A.BrE:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nt();
				break;
			case bV.A.Bre:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qQ() + ((object)bpu.aXA).ToString();
				break;
			default:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qq() + ((object)bpu.aXA).ToString();
				break;
			}
			if (!qW && (int)bE.A((IWin32Window)(object)this, empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !A(((FileDialog)qE).FileName, bpV, bpu))
				{
				}
			}
		}

		private void f(object P_0, DoWorkEventArgs P_1)
		{
			G g = P_1.Argument as G;
			Framework bpv = g.Bpv;
			string text = CZ.A(new bW
			{
				axS = bpv.awZ,
				axs = bpv.awz,
				axT = bpv.aXA,
				axt = g.BpW.aO
			}, 65535);
			int? num;
			UpdateOutcomes updateOutcomes;
			string[] bQo = bj.A(bpv.aXA, bpv.awZ, bpv.awz, text, out num, out updateOutcomes);
			k k = default(k);
			k.BQN = g.BpW;
			k.BQn = bpv;
			k k2 = k;
			if (num.HasValue && updateOutcomes == UpdateOutcomes.CompleteUpdate)
			{
				k2.BQO = updateOutcomes;
				k2.BQo = bQo;
			}
			P_1.Result = k2;
		}

		private void F(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Invalid comparison between Unknown and I4
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Invalid comparison between Unknown and I4
			k k = (k)P_1.Result;
			P();
			if (k.BQo != null && k.BQo.Length != 0)
			{
				string[] bQo = k.BQo;
				foreach (string text in bQo)
				{
					List<string> val;
					if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()))
					{
						val = new List<string>();
						val.Add(text);
					}
					else
					{
						val = bT.b(text);
					}
					if (val.Count != 0 && A(text, k.BQN, k.BQn))
					{
						return;
					}
				}
			}
			if (qW)
			{
				return;
			}
			string text2 = bx.C(k.BQn.awZ, k.BQn.awz);
			text2 = ((text2 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NZ() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)k.BQn.aXA).ToString();
			if ((int)bE.A((IWin32Window)(object)this, text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !A(((FileDialog)qE).FileName, k.BQN, k.BQn))
				{
				}
			}
		}

		private bool A(string P_0, global::A.F P_1, Framework P_2)
		{
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected O, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected O, but got Unknown
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				bW bW = new bW
				{
					axS = P_2.awZ,
					axs = P_2.awz,
					axT = P_2.aXA,
					axt = P_1.aO
				};
				string text = null;
				bool flag3;
				bool flag;
				bool flag2;
				global::A.k k;
				if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nz()))
				{
					flag3 = CZ.A(P_0, bW, out flag, out flag2, out k, out text);
				}
				else
				{
					text = P_0;
					flag3 = bT.A(P_0, bW, out flag, out flag2, out k);
				}
				if (flag3 && text != null)
				{
					P_2 = new Framework(text, P_2.awZ, P_2.awz, P_2.aXA);
					P_2.aXc = P_1.ao;
					F f = new F
					{
						BpT = P_2,
						Bpt = P_1
					};
					BackgroundWorker val = new BackgroundWorker
					{
						WorkerReportsProgress = true
					};
					object obj = BM.t.Bqk;
					if (obj == null)
					{
						ProgressChangedEventHandler val2 = a;
						BM.t.Bqk = val2;
						obj = (object)val2;
					}
					val.ProgressChanged += (ProgressChangedEventHandler)obj;
					val.DoWork += new DoWorkEventHandler(F);
					val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(e);
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qL());
					val.RunWorkerAsync((object)f);
					return true;
				}
				if (!qW)
				{
					if (k == null || text == null)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else if (!flag)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qo(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else if (!flag2)
					{
						bE.A((IWin32Window)(object)this, string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nB(),
							((object)k).ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qP(),
							((object)P_2.aXA).ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
						}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
			}
			catch (System.Exception ex)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qR() + ex.Message, true);
			}
			return false;
		}

		internal void A(BE P_0, bool P_1, bool P_2, bool P_3)
		{
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Expected O, but got Unknown
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Expected O, but got Unknown
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected O, but got Unknown
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Invalid comparison between Unknown and I4
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Invalid comparison between Unknown and I4
			if (Qz == null || !Qz.c() || Qz.A(9497).ax() == 0)
			{
				return;
			}
			if (Qz.A(9500).ax() != 0)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JG(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (Qz.A(9501).ax() < 0)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qr(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			string empty = string.Empty;
			if (Qz.A(ref empty))
			{
				try
				{
					string text = Qz.aXD;
					if (string.IsNullOrEmpty(text))
					{
						text = A(empty, Qz.aXc);
						if (string.IsNullOrEmpty(text))
						{
							string text2 = empty;
							List<string> obj = new List<string>();
							obj.Add(Qz.aXc);
							text = a(text2, obj);
						}
						Qz.aXD = text;
					}
					Directory.CreateDirectory(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jh());
				}
				catch
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qS(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				GC.Collect();
				g g = default(g);
				g.Bpw = P_0;
				g.BpX = P_1;
				g.Bpx = P_2;
				g.BpY = P_3;
				g g2 = g;
				Sj = true;
				BackgroundWorker val = new BackgroundWorker
				{
					WorkerReportsProgress = true
				};
				object obj3 = BM.t.Bqk;
				if (obj3 == null)
				{
					ProgressChangedEventHandler val2 = a;
					BM.t.Bqk = val2;
					obj3 = (object)val2;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj3;
				val.DoWork += new DoWorkEventHandler(G);
				val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(f);
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qT());
				val.RunWorkerAsync((object)g2);
				SK = null;
				Sk = false;
				SL = false;
				if (P_1)
				{
					SL = true;
					SaveFileDialog val3 = new SaveFileDialog();
					((FileDialog)val3).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qt();
					((FileDialog)val3).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qU();
					((FileDialog)val3).InitialDirectory = Qz.aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jh();
					if ((int)((CommonDialog)val3).ShowDialog((IWin32Window)(object)this) == 1)
					{
						SK = ((FileDialog)val3).FileName;
					}
					else
					{
						SK = null;
					}
					((Component)val3).Dispose();
				}
				if (P_2)
				{
					SL = true;
					if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qu(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qV(), (MessageBoxButtons)4) == 6)
					{
						Sk = true;
					}
					else
					{
						Sk = false;
					}
				}
				SL = false;
			}
			else
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qs(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private void G(object P_0, DoWorkEventArgs P_1)
		{
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			g g = (g)P_1.Argument;
			P_1.Result = null;
			string text = Qz.aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qv();
			int num = Qz.A(9497).ax();
			int num2 = Qz.A(9510).ax();
			int num3 = num / num2;
			List<int> val2 = new List<int>(num3);
			List<int> val3 = new List<int>(num3);
			bool flag = true;
			bool flag2 = false;
			A(val, ref flag, ref flag2, text, val2, val3, out var num4, out var num5, out var val4);
			string text2 = null;
			if (flag && !flag2)
			{
				A(val, text, ref text2, val2, val3, num4, num5, val4);
			}
			GC.Collect();
			string bpz = null;
			if (!g.BpY && flag && text2 != null)
			{
				object obj = BM.U.Bqr;
				if (obj == null)
				{
					Action val5 = delegate
					{
						C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bda());
					};
					BM.U.Bqr = val5;
					obj = (object)val5;
				}
				((Control)this).Invoke((Action)obj);
				try
				{
					Be.D d = default(Be.D);
					d.Boi = Qz.aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JT();
					d.BoJ = Path.GetFileNameWithoutExtension(text2);
					d.Boj = text2;
					d.BoK = null;
					d.Bok = -1;
					DoWorkEventArgs val6 = new DoWorkEventArgs((object)d);
					Be.B(val, val6);
					bpz = d.Boi + d.BoJ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iR();
				}
				catch (System.Exception ex)
				{
					global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qW() + ex.Message, true);
					bpz = null;
				}
			}
			H h = default(H);
			h.Bpy = flag;
			h.BpZ = text2;
			h.Bpz = bpz;
			h.BQA = g.Bpw;
			h.BQa = g.BpX;
			h.BQB = g.Bpx;
			h.BQb = g.BpY;
			h.BQC = flag2;
			H h2 = h;
			P_1.Result = h2;
			if (g.BpX || g.Bpx)
			{
				while (SL)
				{
					Thread.Sleep(500);
				}
			}
		}

		private void A(BackgroundWorker P_0, ref bool P_1, ref bool P_2, string P_3, List<int> P_4, List<int> P_5, out int P_6, out int P_7, out Dictionary<int, List<List<ushort>>> P_8)
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			P_8 = new Dictionary<int, List<List<ushort>>>();
			P_6 = 2147483647;
			P_7 = -2147483648;
			BinaryWriter val = null;
			try
			{
				if (File.Exists(P_3))
				{
					File.Delete(P_3);
				}
				val = new BinaryWriter((Stream)(object)File.Open(P_3, (FileMode)2, (FileAccess)2));
			}
			catch
			{
				P_1 = false;
			}
			if (!P_1)
			{
				return;
			}
			int num = Qz.A(9497).ax();
			int num2 = Qz.A(9510).ax();
			global::A.b b = global::A.A.n;
			global::A.A.n = global::A.b.q;
			int num3 = 0;
			int num4 = 0;
			while (num4 < num)
			{
				int num5 = (int)global::A.A.A(Qz.aXc, global::A.f.Ba);
				if ((num4 + num5) / num2 > num4 / num2 && (num4 + num5) % num2 != 0)
				{
					num5 -= (num4 + num5) % num2;
				}
				if (num5 > num2 && num5 % num2 != 0)
				{
					num5 = num5 / num2 * num2;
				}
				num5 = Math.Min(num5, num - num4);
				if (global::A.A.A(Qz.aXc, global::A.f.Ba, (uint)num4, (uint)num5, out var array, out var _))
				{
					val.Write(array);
					if (num5 <= num2)
					{
						if (num4 % num2 == 0 && A(0, array, ref num3, P_4, P_5, ref P_6, ref P_7, P_8))
						{
							if (P_4.Count == 0)
							{
								P_2 = true;
							}
							break;
						}
					}
					else
					{
						bool flag2 = false;
						for (int i = 0; i < num5; i += num2)
						{
							if (A(i, array, ref num3, P_4, P_5, ref P_6, ref P_7, P_8))
							{
								flag2 = true;
								if (P_4.Count == 0)
								{
									P_2 = true;
								}
								break;
							}
						}
						if (flag2)
						{
							break;
						}
					}
					num4 += num5;
					int num6 = (int)(100L * (long)num4 / num);
					P_0.ReportProgress(num6);
					continue;
				}
				P_1 = false;
				break;
			}
			try
			{
				val.Close();
			}
			catch
			{
				P_1 = false;
			}
			try
			{
				if (P_2 && File.Exists(P_3))
				{
					File.Delete(P_3);
				}
			}
			catch
			{
			}
			global::A.A.n = b;
		}

		private bool A(int P_0, byte[] P_1, ref int P_2, List<int> P_3, List<int> P_4, ref int P_5, ref int P_6, Dictionary<int, List<List<ushort>>> P_7)
		{
			if (P_1[P_0 + 3] == 255)
			{
				P_2++;
				if (P_2 == 2)
				{
					return true;
				}
				return false;
			}
			int num = 3 + ((P_1[P_0 + 3 + 1] << 24) | ((P_1[P_0 + 3 + 2] << 16) & 0xFF0000) | ((P_1[P_0 + 3 + 3] << 8) & 0xFF00) | (P_1[P_0 + 3 + 4] & 0xFF));
			int num2 = (P_1[P_0 + 3 + 57] << 24) | ((P_1[P_0 + 3 + 58] << 16) & 0xFF0000) | ((P_1[P_0 + 3 + 59] << 8) & 0xFF00) | (P_1[P_0 + 3 + 60] & 0xFF);
			int num3 = (P_1[P_0 + 3 + 61] << 24) | ((P_1[P_0 + 3 + 62] << 16) & 0xFF0000) | ((P_1[P_0 + 3 + 63] << 8) & 0xFF00) | (P_1[P_0 + 3 + 64] & 0xFF);
			P_3.Add(num2);
			P_4.Add(num3);
			P_5 = Math.Min(P_5, num2);
			P_6 = Math.Max(P_6, num2);
			if (!P_7.ContainsKey(num2))
			{
				int num4;
				bool flag;
				List<List<ushort>> val = Be.A(P_1, P_0 + num, out num4, out flag);
				P_7.Add(num2, val);
			}
			return false;
		}

		private void A(BackgroundWorker P_0, string P_1, ref string P_2, List<int> P_3, List<int> P_4, int P_5, int P_6, Dictionary<int, List<List<ushort>>> P_7)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected O, but got Unknown
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Expected O, but got Unknown
			object obj = BM.U.BqS;
			if (obj == null)
			{
				Action val = delegate
				{
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdB());
				};
				BM.U.BqS = val;
				obj = (object)val;
			}
			((Control)this).Invoke((Action)obj);
			try
			{
				FileStream val2 = new FileStream(P_1, (FileMode)3);
				if (((Stream)val2).CanRead)
				{
					P_0.ReportProgress(5);
					string text = string.Concat(new string[5]
					{
						global::A.N.A(false),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qw(),
						P_5.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qX(),
						P_6.ToString()
					});
					if (File.Exists(Qz.aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JT() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
					{
						text = string.Concat(new string[5]
						{
							global::A.N.A(true),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qw(),
							P_5.ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qX(),
							P_6.ToString()
						});
					}
					P_2 = Qz.aXD + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JT() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qx();
					MemoryStream val3 = new MemoryStream();
					ZipArchive val4 = new ZipArchive((Stream)(object)val3, (ZipArchiveMode)1);
					P_0.ReportProgress(10);
					Stream val5 = val4.CreateEntry(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qY() + bx.a(Qz.awZ, Qz.awz, Qz.aXA) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu()).Open();
					string text2 = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qy();
					new CR(text2, Qz, true).A();
					byte[] array = File.ReadAllBytes(text2);
					foreach (byte b in array)
					{
						val5.WriteByte(b);
					}
					File.Delete(text2);
					val5.Close();
					P_0.ReportProgress(15);
					Stream val6 = val4.CreateEntry(text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.eK()).Open();
					A(P_7, out var val7, out var val8);
					List<int> val9 = new List<int>();
					for (int j = P_5; j <= P_6; j++)
					{
						int num = P_3.IndexOf(j);
						int num2 = P_3.LastIndexOf(j);
						if (num != -1 && num2 != -1)
						{
							val9.Add(j);
						}
					}
					A(val6, val9);
					P_0.ReportProgress(20);
					Dictionary<ushort, byte[]> val10 = new Dictionary<ushort, byte[]>();
					uint num3 = 0u;
					uint num4 = 0u;
					uint num5 = 0u;
					for (int k = P_5; k <= P_6; k++)
					{
						int num6 = P_3.IndexOf(k);
						int num7 = P_3.LastIndexOf(k);
						if (num6 != -1 && num7 != -1)
						{
							int num8 = 20 + 60 * (k - P_5) / (1 + P_6 - P_5);
							int num9 = 20 + 60 * (1 + k - P_5) / (1 + P_6 - P_5);
							A(k, val2, val6, P_0, num8, num9, P_3, P_4, P_5, P_6, num6, num7, P_7, val7, val8, val10, ref num3, ref num4, ref num5);
						}
					}
					if (val6 != null)
					{
						val6.Close();
						val6 = null;
					}
					if (val4 != null)
					{
						val4.Dispose();
						val4 = null;
					}
					if (val3 != null)
					{
						byte[] array2 = val3.ToArray();
						((Stream)val3).Close();
						val3 = null;
						GC.Collect();
						FileStream val11 = new FileStream(P_2, (FileMode)2);
						try
						{
							global::A.S.A(array2, global::A.M.B(), (Stream)(object)val11, global::A.S.Dj);
						}
						finally
						{
							((System.IDisposable)val11)?.Dispose();
						}
					}
					P_0.ReportProgress(90);
				}
				((Stream)val2).Close();
				if (File.Exists(P_1))
				{
					File.Delete(P_1);
				}
			}
			catch
			{
				P_2 = null;
			}
			P_0.ReportProgress(100);
			Thread.Sleep(100);
		}

		private void A(Dictionary<int, List<List<ushort>>> P_0, out Dictionary<ushort, h> P_1, out List<List<ushort>> P_2)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			List<ushort> val = A(P_0);
			int num = 0;
			Enumerator<int, List<List<ushort>>> enumerator = P_0.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					List<List<ushort>> val2 = P_0[current];
					num = Math.Max(num, val2.Count);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			P_2 = new List<List<ushort>>();
			while (P_2.Count < num)
			{
				P_2.Add(new List<ushort>());
			}
			enumerator = P_0.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current2 = enumerator.Current;
					List<List<ushort>> val3 = P_0[current2];
					for (int i = 0; i < val3.Count; i++)
					{
						Enumerator<ushort> enumerator2 = val3[i].GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								ushort current3 = enumerator2.Current;
								int num2 = -1;
								for (int j = 0; j < P_2.Count; j++)
								{
									if (P_2[j].Contains(current3))
									{
										num2 = j;
										break;
									}
								}
								if (val.Contains(current3))
								{
									if (num2 == -1)
									{
										P_2.Add(new List<ushort>());
										P_2[P_2.Count - 1].Add(current3);
									}
								}
								else if (num2 == -1)
								{
									P_2[i].Add(current3);
								}
								else if (num2 != i)
								{
									P_2.Add(new List<ushort>());
									P_2[P_2.Count - 1].Add(current3);
									P_2[num2].Remove(current3);
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			for (int num3 = P_2.Count - 1; num3 >= 0; num3--)
			{
				if (P_2[num3].Count == 0)
				{
					P_2.RemoveAt(num3);
				}
			}
			P_1 = new Dictionary<ushort, h>();
			for (int k = 0; k < P_2.Count; k++)
			{
				List<ushort> val4 = P_2[k];
				for (int l = 0; l < val4.Count; l++)
				{
					h h = default(h);
					h.BQc = k;
					h.BQD = l;
					h h2 = h;
					ushort num4 = val4[l];
					P_1.Add(num4, h2);
				}
			}
		}

		private List<ushort> A(Dictionary<int, List<List<ushort>>> P_0)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			List<ushort> val = new List<ushort>();
			Enumerator<int, List<List<ushort>>> enumerator = P_0.Keys.GetEnumerator();
			Enumerator<ushort> enumerator2;
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					List<List<ushort>> val2 = P_0[current];
					for (int i = 0; i < val2.Count; i++)
					{
						enumerator2 = val2[i].GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								ushort current2 = enumerator2.Current;
								val.Add(current2);
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			List<ushort> val3 = new List<ushort>();
			enumerator2 = val.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					ushort current3 = enumerator2.Current;
					bool flag = true;
					enumerator = P_0.Keys.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current4 = enumerator.Current;
							bool flag2 = false;
							List<List<ushort>> val4 = P_0[current4];
							for (int j = 0; j < val4.Count; j++)
							{
								Enumerator<ushort> enumerator3 = val4[j].GetEnumerator();
								try
								{
									while (enumerator3.MoveNext())
									{
										if (enumerator3.Current == current3)
										{
											flag2 = true;
											break;
										}
									}
								}
								finally
								{
									((System.IDisposable)enumerator3).Dispose();
								}
								if (flag2)
								{
									break;
								}
							}
							if (!flag2)
							{
								flag = false;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					if (!flag)
					{
						val3.Add(current3);
					}
				}
				return val3;
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}

		private void A(Stream P_0, List<int> P_1)
		{
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			byte b = 14;
			P_0.WriteByte(b);
			uint num = (uint)(5 + 4 * P_1.Count);
			P_0.WriteByte((byte)((num >> 24) & 0xFFu));
			P_0.WriteByte((byte)((num >> 16) & 0xFFu));
			P_0.WriteByte((byte)((num >> 8) & 0xFFu));
			P_0.WriteByte((byte)(num & 0xFFu));
			Enumerator<int> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					P_0.WriteByte((byte)((uint)(current >> 24) & 0xFFu));
					P_0.WriteByte((byte)((uint)(current >> 16) & 0xFFu));
					P_0.WriteByte((byte)((uint)(current >> 8) & 0xFFu));
					P_0.WriteByte((byte)((uint)current & 0xFFu));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private void A(int P_0, FileStream P_1, Stream P_2, BackgroundWorker P_3, int P_4, int P_5, List<int> P_6, List<int> P_7, int P_8, int P_9, int P_10, int P_11, Dictionary<int, List<List<ushort>>> P_12, Dictionary<ushort, h> P_13, List<List<ushort>> P_14, Dictionary<ushort, byte[]> P_15, ref uint P_16, ref uint P_17, ref uint P_18)
		{
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			int num = Qz.A(9497).ax();
			int num2 = Qz.A(9510).ax();
			int num3 = P_7[P_10];
			byte[] array;
			if (P_7[P_11] < num3)
			{
				int num4 = 0;
				int num5 = P_6.Count - 1;
				while (num5 >= 0 && (num5 == P_6.Count - 1 || P_7[num5] <= P_7[num5 + 1]) && P_6[num5] == P_0)
				{
					num4++;
					num5--;
				}
				int num6 = 0;
				for (int i = 0; i < P_6.Count && (i == 0 || P_7[i] >= P_7[i - 1]) && P_6[i] == P_0; i++)
				{
					num6++;
				}
				int num7 = num - num4 * num2;
				int num8 = num4 * num2;
				int num9 = num6 * num2;
				array = new byte[num8 + num9];
				((Stream)P_1).Seek((long)num7, (SeekOrigin)0);
				global::A.N.A((Stream)(object)P_1, array, 0, num8);
				((Stream)P_1).Seek(0L, (SeekOrigin)0);
				global::A.N.A((Stream)(object)P_1, array, num8, num9);
			}
			else
			{
				int num10 = 1 + P_11 - P_10;
				int num11 = P_10 * num2;
				int num12 = num10 * num2;
				array = new byte[num12];
				((Stream)P_1).Seek((long)num11, (SeekOrigin)0);
				global::A.N.A((Stream)(object)P_1, array, 0, num12);
			}
			int num13 = P_4 + 20 * (P_5 - P_4) / 100;
			P_3.ReportProgress(num13);
			uint num14 = (uint)(3 + ((array[4] << 24) | ((array[5] << 16) & 0xFF0000) | ((array[6] << 8) & 0xFF00) | (array[7] & 0xFF)));
			array[68] = (byte)Qz.awZ;
			P_2.Write(array, 0, (int)num14);
			bool flag = P_14.Count > 16;
			for (int j = 0; j < P_14.Count; j++)
			{
				byte b = (byte)((!flag) ? ((byte)(6u | (byte)(16 * j))) : 11);
				P_2.WriteByte(b);
				uint num15 = (uint)((!flag) ? (5 + 2 * P_14[j].Count) : (7 + 2 * P_14[j].Count));
				P_2.WriteByte((byte)((num15 >> 24) & 0xFFu));
				P_2.WriteByte((byte)((num15 >> 16) & 0xFFu));
				P_2.WriteByte((byte)((num15 >> 8) & 0xFFu));
				P_2.WriteByte((byte)(num15 & 0xFFu));
				if (flag)
				{
					P_2.WriteByte((byte)((uint)(j >> 8) & 0xFFu));
					P_2.WriteByte((byte)((uint)j & 0xFFu));
				}
				Enumerator<ushort> enumerator = P_14[j].GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ushort current = enumerator.Current;
						P_2.WriteByte((byte)((uint)(current >> 8) & 0xFFu));
						P_2.WriteByte((byte)(current & 0xFFu));
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			Cm.A(P_2, P_14);
			int num16 = P_4 + 30 * (P_5 - P_4) / 100;
			P_3.ReportProgress(num16);
			A(P_0, P_2, P_3, num16, P_5, array, num14, P_12, P_13, P_14, P_15, ref P_16, ref P_17, ref P_18);
		}

		private void A(int P_0, Stream P_1, BackgroundWorker P_2, int P_3, int P_4, byte[] P_5, uint P_6, Dictionary<int, List<List<ushort>>> P_7, Dictionary<ushort, h> P_8, List<List<ushort>> P_9, Dictionary<ushort, byte[]> P_10, ref uint P_11, ref uint P_12, ref uint P_13)
		{
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Unknown result type (might be due to invalid IL or missing references)
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			uint num = 4294967295u;
			uint num2 = 0u;
			int num3 = 0;
			uint num4 = P_6;
			do
			{
				byte b = P_5[num4];
				num4++;
				if (b != 255)
				{
					uint num5 = (uint)(P_5[num4] << 24) | ((uint)(P_5[num4 + 1] << 16) & 0xFF0000u) | ((uint)(P_5[num4 + 2] << 8) & 0xFF00u) | (P_5[num4 + 3] & 0xFFu);
					num4 += 4;
					if (b == 0 || num5 == 4294967295u || num5 == 0 || num5 > 131072)
					{
						break;
					}
					if ((b & 0xF) == 7)
					{
						uint num6 = (uint)(P_5[num4] << 24) | ((uint)(P_5[num4 + 1] << 16) & 0xFF0000u) | ((uint)(P_5[num4 + 2] << 8) & 0xFF00u) | (P_5[num4 + 3] & 0xFFu);
						bool num7 = num == 4294967295u;
						if (num7)
						{
							num = num6;
						}
						if (num != 0)
						{
							num6 -= num;
						}
						num2 = num6;
						if (num7 && num6 < P_11)
						{
							P_13 = P_12;
						}
						uint num8 = num6 + P_13;
						P_11 = num6;
						num4 += 4;
						int num9 = (b >> 4) & 0xF;
						List<ushort> val = P_7[P_0][num9];
						List<int> val2 = new List<int>();
						for (int i = 0; i < val.Count; i++)
						{
							ushort num10 = val[i];
							int bQc = P_8[num10].BQc;
							if (!val2.Contains(bQc))
							{
								val2.Add(bQc);
							}
							byte[] array = new byte[4];
							for (int j = 0; j < 4; j++)
							{
								array[j] = P_5[num4 + i * 4 + j];
							}
							P_10[num10] = array;
						}
						val2.Sort();
						bool flag = P_9.Count > 16;
						int num11 = 0;
						Enumerator<int> enumerator = val2.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								int current = enumerator.Current;
								int num12 = ((!flag) ? (9 + 4 * P_9[current].Count) : (11 + 4 * P_9[current].Count));
								num11 += num12;
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
						byte[] array2 = new byte[num11];
						int num13 = 0;
						enumerator = val2.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								int current2 = enumerator.Current;
								if (flag)
								{
									array2[num13] = 12;
								}
								else
								{
									array2[num13] = (byte)(7u | (byte)(16 * current2));
								}
								num13++;
								uint num14 = (uint)((!flag) ? (9 + 4 * P_9[current2].Count) : (11 + 4 * P_9[current2].Count));
								array2[num13] = (byte)((num14 >> 24) & 0xFFu);
								array2[num13 + 1] = (byte)((num14 >> 16) & 0xFFu);
								array2[num13 + 2] = (byte)((num14 >> 8) & 0xFFu);
								array2[num13 + 3] = (byte)(num14 & 0xFFu);
								num13 += 4;
								if (flag)
								{
									array2[num13] = (byte)((uint)(current2 >> 8) & 0xFFu);
									array2[num13 + 1] = (byte)((uint)current2 & 0xFFu);
									num13 += 2;
								}
								array2[num13] = (byte)((num8 >> 24) & 0xFFu);
								array2[num13 + 1] = (byte)((num8 >> 16) & 0xFFu);
								array2[num13 + 2] = (byte)((num8 >> 8) & 0xFFu);
								array2[num13 + 3] = (byte)(num8 & 0xFFu);
								num13 += 4;
								Enumerator<ushort> enumerator2 = P_9[current2].GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										ushort current3 = enumerator2.Current;
										if (P_10.ContainsKey(current3))
										{
											byte[] array3 = P_10[current3];
											for (int k = 0; k < 4; k++)
											{
												array2[num13 + k] = array3[k];
											}
										}
										num13 += 4;
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
						P_1.Write(array2, 0, array2.Length);
						num4 += num5 - 9;
					}
					else
					{
						num4 += num5 - 5;
					}
				}
				int num15 = P_3 + (int)(num4 * (P_4 - P_3) / P_5.Length);
				if (num15 != num3)
				{
					P_2.ReportProgress(num15);
					num3 = num15;
				}
			}
			while (num4 < P_5.Length);
			P_12 += num2;
			P_2.ReportProgress(P_4);
		}

		private void f(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Invalid comparison between Unknown and I4
			P();
			Sj = false;
			string text = SK;
			bool flag = Sk;
			SK = null;
			Sk = false;
			SL = false;
			if (P_1.Result == null)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qZ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			H h = (H)P_1.Result;
			if (h.BQC)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qr(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else if (h.Bpy)
			{
				if (h.BpZ != null)
				{
					bool flag2 = false;
					if (h.BQa)
					{
						flag2 = A(text, ref h.BpZ, ref h.Bpz);
					}
					if (!flag2 && !A(ref h.BpZ, ref h.Bpz))
					{
						return;
					}
					if (a(Qz))
					{
						if (h.BQB)
						{
							if (flag)
							{
								A((Form)(object)this, h.BQA, h.BpZ, h.Bpz);
							}
							else
							{
								A(h.BQA, h.BpZ, h.Bpz);
							}
						}
						else if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qz(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RA(), (MessageBoxButtons)4) == 6)
						{
							A((Form)(object)this, h.BQA, h.BpZ, h.Bpz);
						}
						else
						{
							A(h.BQA, h.BpZ, h.Bpz);
						}
					}
					else
					{
						A(h.BQA, h.BpZ, h.Bpz);
					}
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ra(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			else
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qZ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private void A(BE P_0, string P_1, string P_2)
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			switch (P_0)
			{
			case BE.nE:
				a(P_1, false);
				break;
			case BE.ne:
				if (P_2 != null)
				{
					string text = Be.b();
					if (File.Exists(text))
					{
						if (File.Exists(P_2))
						{
							Be.A(text, P_2);
						}
					}
					else
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RB(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rb(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				break;
			}
		}

		private bool A(ref string P_0, ref string P_1)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Invalid comparison between Unknown and I4
			try
			{
				if (P_0 != null && File.Exists(P_0))
				{
					SaveFileDialog val = new SaveFileDialog();
					((FileDialog)val).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qt();
					((FileDialog)val).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qU();
					((FileDialog)val).InitialDirectory = Path.GetDirectoryName(P_0);
					((FileDialog)val).FileName = Path.GetFileName(P_0.Substring(0, P_0.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qx().Length));
					bool flag = false;
					if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
					{
						string text = ((FileDialog)val).FileName;
						if (!text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
						{
							text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
						}
						File.Move(P_0, text);
						P_0 = text;
					}
					else
					{
						string text2 = P_0.Substring(0, P_0.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qx().Length) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
						File.Move(P_0, text2);
						P_0 = text2;
						flag = true;
					}
					if (P_1 != null && File.Exists(P_1))
					{
						string text3 = Path.GetDirectoryName(P_0);
						if (!text3.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) && !text3.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj()))
						{
							text3 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
						}
						string text4 = text3 + Path.GetFileNameWithoutExtension(P_0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iR();
						File.Move(P_1, text4);
						P_1 = text4;
					}
					((Component)val).Dispose();
					if (flag)
					{
						return false;
					}
				}
			}
			catch
			{
			}
			return true;
		}

		private bool A(string P_0, ref string P_1, ref string P_2)
		{
			try
			{
				if (!string.IsNullOrEmpty(P_0) && P_1 != null && File.Exists(P_1))
				{
					if (!P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej()))
					{
						P_0 += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej();
					}
					File.Move(P_1, P_0);
					P_1 = P_0;
					if (P_2 != null && File.Exists(P_2))
					{
						string text = Path.GetDirectoryName(P_1);
						if (!text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) && !text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj()))
						{
							text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
						}
						string text2 = text + Path.GetFileNameWithoutExtension(P_1) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iR();
						File.Move(P_2, text2);
						P_2 = text2;
					}
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		internal static bool a(Framework P_0)
		{
			if (P_0 != null)
			{
				if (bx.A(P_0.awZ))
				{
					return P_0.aXA >= new global::A.k(3, 3, 0, 101, 0);
				}
				if (P_0.awZ == 20)
				{
					return P_0.aXA >= new global::A.k(1, 16, 0, 101, 0);
				}
				return true;
			}
			return false;
		}

		internal bool A(Form P_0, BE P_1, string P_2, string P_3)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			if (!a(Qz))
			{
				bE.A((IWin32Window)(object)P_0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rc(), (MessageBoxButtons)0, (MessageBoxIcon)64);
				return false;
			}
			if (Qz != null)
			{
				if (Qz.A(9500).ax() == 0)
				{
					I i = new I();
					i.BQd = P_1;
					i.BQE = P_2;
					i.BQe = P_3;
					BackgroundWorker val = new BackgroundWorker();
					val.WorkerSupportsCancellation = false;
					val.WorkerReportsProgress = P_0 is BM;
					val.DoWork += new DoWorkEventHandler(g);
					val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(G);
					if (val.WorkerReportsProgress)
					{
						object obj = BM.t.Bqk;
						if (obj == null)
						{
							ProgressChangedEventHandler val2 = a;
							BM.t.Bqk = val2;
							obj = (object)val2;
						}
						val.ProgressChanged += (ProgressChangedEventHandler)obj;
						C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RD());
					}
					val.RunWorkerAsync((object)i);
					return true;
				}
				bE.A((IWin32Window)(object)P_0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.JG(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				if (P_1 != 0)
				{
					A(P_1, P_2, P_3);
				}
				return false;
			}
			return true;
		}

		private void g(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			if (val.WorkerReportsProgress)
			{
				val.ReportProgress(0);
				Thread.Sleep(100);
			}
			global::A.A.b(Qz.aXc, out var _);
			if (val.WorkerReportsProgress)
			{
				val.ReportProgress(100);
				Thread.Sleep(500);
			}
			I result = P_1.Argument as I;
			P_1.Result = result;
		}

		private void G(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			P();
			I i = P_1.Result as I;
			if (i.BQd != 0)
			{
				A(i.BQd, i.BQE, i.BQe);
			}
		}

		private void J()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			if (SQ == null)
			{
				SQ = new Timer();
				SQ.Interval = 500.0;
				SQ.SynchronizingObject = (ISynchronizeInvoke)(object)this;
				SQ.Elapsed += new ElapsedEventHandler(B);
				SQ.AutoReset = true;
				SQ.Enabled = false;
			}
		}

		private void j()
		{
			Sq = true;
			if (SQ != null && !SQ.Enabled)
			{
				SQ.Enabled = true;
				SQ.Start();
			}
		}

		private void K()
		{
			if (SQ != null && SQ.Enabled)
			{
				SQ.Stop();
				SQ.Enabled = false;
			}
			Sq = true;
		}

		private void B(object P_0, ElapsedEventArgs P_1)
		{
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)this).InvokeRequired)
			{
				try
				{
					i i = B;
					((Control)this).Invoke((System.Delegate)i, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (((uint)qI & (true ? 1u : 0u)) != 0 && SI.Count == 1)
			{
				if (Qz != null && Qz.aWW.IsValid)
				{
					((ToolStripItem)rf).Visible = true;
					SP.Clear();
					int num = 17;
					int statusArrayDataId = Qz.aWW.StatusArrayDataId;
					Setting setting = Qz.A(statusArrayDataId);
					if (setting == null)
					{
						System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(71, 1);
						defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rd());
						defaultInterpolatedStringHandler.AppendFormatted<int>(statusArrayDataId);
						throw new ArgumentNullException(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					int modeArrayDataId = Qz.aWW.ModeArrayDataId;
					Setting setting2 = Qz.A(modeArrayDataId);
					if (setting2 == null)
					{
						System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(69, 1);
						defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RE());
						defaultInterpolatedStringHandler.AppendFormatted<int>(modeArrayDataId);
						throw new ArgumentNullException(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					byte[] array = setting.aY();
					byte[] array2 = setting2.aY();
					Sp = 0;
					for (int j = 0; j < array.Length; j++)
					{
						if (array[j] != 0)
						{
							int num2 = Qz.aWW.ErrorToSettingMap[j];
							if (array2[num2] > 0 && Qz.aWW.ErrorIndexToCodeMap.ContainsKey(j))
							{
								string text = Qz.aWW.ErrorIndexToCodeMap[j];
								string text2 = Qz.aWW.ErrorDefs[text][D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aT()];
								BN bN = new BN();
								bN.A(text);
								bN.a(text2);
								bN.A((Bm)array[j]);
								BN bN2 = bN;
								num = num * 23 + (((object)bN2)?.GetHashCode() ?? 0);
								SP.Add(bN2);
							}
							else
							{
								Sp++;
							}
						}
					}
					if (SP.Count > 0 && num != So)
					{
						So = num;
						L();
					}
					else if (SP.Count == 0 && So != 0)
					{
						So = 0;
						L();
					}
					return;
				}
				global::A.F bpS = SI[0].BpS;
				if (bpS.@as[36].BF != 0)
				{
					((ToolStripItem)rf).Visible = true;
				}
				if (Qz == null || !Qz.c() || (!Sq && ((ArrangedElementCollection)((Control)Rq).Controls).Count != 0))
				{
					return;
				}
				if (bpS.@as[36].BF != 0)
				{
					L();
				}
				else
				{
					((ToolStripItem)rf).Visible = false;
					if (((Control)Rq).Visible)
					{
						((Control)Rq).Visible = false;
						x();
						X();
					}
				}
				Sq = false;
			}
			else
			{
				So = 0;
				((ToolStripItem)rf).Visible = false;
				if (((Control)Rq).Visible)
				{
					((Control)Rq).Visible = false;
					x();
					X();
				}
			}
		}

		private void k()
		{
			if (SI.Count != 1)
			{
				return;
			}
			global::A.F bpS = SI[0].BpS;
			if (bpS.@as[36].BF == 0 || ((uint)qI & 0x100u) != 0 || ((uint)qI & 0x200u) != 0 || !global::A.A.A(bpS.ao, global::A.f.ay, 0u, (uint)(SO.Length * 2), out var array, out var _))
			{
				return;
			}
			for (int i = 0; i < array.Length; i += 2)
			{
				ushort num = (ushort)((uint)(array[i] << 8) | (array[i + 1] & 0xFFu));
				if (SO[i >> 1] != num)
				{
					SO[i >> 1] = num;
					Sq = true;
				}
			}
		}

		private static void L()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Expected O, but got Unknown
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Expected O, but got Unknown
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Expected O, but got Unknown
			//IL_0346: Unknown result type (might be due to invalid IL or missing references)
			//IL_034b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d1: Expected O, but got Unknown
			//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_054c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
			Stopwatch val = new Stopwatch();
			val.Start();
			foreach (Control item in (ArrangedElementCollection)((Control)QQ.Rq).Controls)
			{
				Control val2 = item;
				if (val2 is Button)
				{
					Control obj = ((val2 is Button) ? val2 : null);
					object obj2 = BM.t.Bql;
					if (obj2 == null)
					{
						EventHandler val3 = u;
						BM.t.Bql = val3;
						obj2 = (object)val3;
					}
					obj.Click -= (EventHandler)obj2;
					Control obj3 = ((val2 is Button) ? val2 : null);
					object obj4 = BM.t.BqM;
					if (obj4 == null)
					{
						EventHandler val4 = V;
						BM.t.BqM = val4;
						obj4 = (object)val4;
					}
					obj3.Click -= (EventHandler)obj4;
				}
			}
			Point autoScrollPosition = ((ScrollableControl)QQ.Rq).AutoScrollPosition;
			int num = ((Point)(ref autoScrollPosition)).Y;
			while (((ArrangedElementCollection)((Control)QQ.Rq).Controls).Count != 0)
			{
				global::A.q.A(((Control)QQ.Rq).Controls[0]);
			}
			((Control)QQ.Rq).SuspendLayout();
			int num2 = 0;
			int top = 0;
			ThemedButton themedButton = new ThemedButton();
			((Control)themedButton).Width = ((Control)QQ.Rq).Width - 21;
			((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Re();
			((Control)themedButton).Top = top;
			object obj5 = BM.t.Bql;
			if (obj5 == null)
			{
				EventHandler val5 = u;
				BM.t.Bql = val5;
				obj5 = (object)val5;
			}
			((Control)themedButton).Click += (EventHandler)obj5;
			((Control)QQ.Rq).Controls.Add((Control)(object)themedButton);
			top = ((Control)themedButton).Bottom + 5;
			ThemedButton themedButton2 = new ThemedButton();
			((Control)themedButton2).Width = ((Control)QQ.Rq).Width - 21;
			((Control)themedButton2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RF();
			((Control)themedButton2).Top = top;
			object obj6 = BM.t.BqM;
			if (obj6 == null)
			{
				EventHandler val6 = V;
				BM.t.BqM = val6;
				obj6 = (object)val6;
			}
			((Control)themedButton2).Click += (EventHandler)obj6;
			((Control)QQ.Rq).Controls.Add((Control)(object)themedButton2);
			top = ((Control)themedButton2).Bottom + 5;
			if (Qz != null && Qz.aWW.IsValid)
			{
				if (Sp > 0)
				{
					Label val7 = new Label();
					((Control)val7).MaximumSize = new Size(((Control)QQ.Rq).Width - 21, ((Control)QQ.Rq).Height - 2);
					((Control)val7).AutoSize = true;
					((Control)val7).Font = new Font(Control.DefaultFont.FontFamily, 8f, (FontStyle)2);
					((Control)val7).Top = top;
					if (Sp == 1)
					{
						System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(30, 1);
						defaultInterpolatedStringHandler.AppendFormatted<int>(Sp);
						defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rf());
						((Control)val7).Text = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(32, 1);
						defaultInterpolatedStringHandler.AppendFormatted<int>(Sp);
						defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RG());
						((Control)val7).Text = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					((Control)val7).ForeColor = tq;
					((Control)QQ.Rq).Controls.Add((Control)(object)val7);
					top = ((Control)val7).Bottom + 5;
				}
				List<BN> val8 = Enumerable.ToList<BN>(Enumerable.Where<BN>((System.Collections.Generic.IEnumerable<BN>)SP, (Func<BN, bool>)((BN P_0) => P_0.B() == Bm.tX)));
				Enumerator<BN> enumerator2 = val8.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						BN current = enumerator2.Current;
						A(current.A(), current.a(), current.B(), ref num2, ref top);
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				if (val8.Count > 0)
				{
					top += 10;
				}
				enumerator2 = Enumerable.ToList<BN>(Enumerable.Where<BN>((System.Collections.Generic.IEnumerable<BN>)SP, (Func<BN, bool>)((BN P_0) => P_0.B() == Bm.tw))).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						BN current2 = enumerator2.Current;
						A(current2.A(), current2.a(), current2.B(), ref num2, ref top);
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
			else
			{
				for (int i = SO.Length / 2; i < SO.Length; i++)
				{
					ushort num3 = SO[i];
					if (num3 != 65535)
					{
						A(num3, true, ref num2, ref top);
					}
				}
				top += 10;
				for (int j = 0; j < SO.Length / 2; j++)
				{
					ushort num4 = SO[j];
					if (num4 == 65535)
					{
						continue;
					}
					bool flag = false;
					for (int k = SO.Length / 2; k < SO.Length; k++)
					{
						if (SO[k] == num4)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						A(num4, false, ref num2, ref top);
					}
				}
			}
			if (num2 == 0)
			{
				Label val9 = new Label();
				((Control)val9).AutoSize = true;
				((Control)val9).Top = top;
				((Control)val9).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rg();
				((Control)val9).ForeColor = te;
				((Control)QQ.Rq).Controls.Add((Control)(object)val9);
				QQ.rf.B();
			}
			else
			{
				QQ.rf.b();
			}
			((Control)QQ.Rq).ResumeLayout(true);
			((ScrollableControl)QQ.Rq).AutoScrollPosition = new Point(0, -num);
			((ToolStripItem)QQ.rf).Tag = num2;
			val.Stop();
			global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RH(), (object)val.ElapsedMilliseconds), false);
		}

		internal static string A(ushort P_0)
		{
			string result = string.Empty;
			switch ((P_0 >> 14) & 3)
			{
			case 0:
				result = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rh(), (object)(P_0 & 0x3FFF));
				break;
			case 1:
				result = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RI(), (object)(P_0 & 0x3FFF));
				break;
			case 2:
				result = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ri(), (object)(P_0 & 0x3FFF));
				break;
			case 3:
				result = string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RJ(), (object)(P_0 & 0x3FFF));
				break;
			}
			return result;
		}

		internal static bool a(string P_0)
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			if (Qz != null && Qz.aWW.IsValid)
			{
				Enumerator<BN> enumerator = Enumerable.ToList<BN>(Enumerable.Where<BN>((System.Collections.Generic.IEnumerable<BN>)SP, (Func<BN, bool>)((BN P_0) => P_0.B() == Bm.tX))).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.A() == P_0)
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
			else
			{
				for (int i = SO.Length / 2; i < SO.Length; i++)
				{
					ushort num = SO[i];
					if (num != 65535 && A(num) == P_0)
					{
						return true;
					}
				}
			}
			return false;
		}

		internal static bool B(string P_0)
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			if (Qz != null && Qz.aWW.IsValid)
			{
				Enumerator<BN> enumerator = Enumerable.ToList<BN>(Enumerable.Where<BN>((System.Collections.Generic.IEnumerable<BN>)SP, (Func<BN, bool>)((BN P_0) => P_0.B() == Bm.tw))).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.A() == P_0)
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
			else
			{
				for (int i = 0; i < SO.Length / 2; i++)
				{
					ushort num = SO[i];
					if (num != 65535 && A(num) == P_0)
					{
						return true;
					}
				}
			}
			return false;
		}

		private static void A(ushort P_0, bool P_1, ref int P_2, ref int P_3)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected O, but got Unknown
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			string text = A(P_0);
			if (Qz.aWv.ContainsKey(text))
			{
				Dm dm = Qz.aWv[text];
				Label val = new Label();
				((Control)val).MaximumSize = new Size(((Control)QQ.Rq).Width - 21, ((Control)QQ.Rq).Height - 2);
				((Control)val).AutoSize = true;
				((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8f, (FontStyle)1);
				((Control)val).Top = P_3;
				if (P_1)
				{
					((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rj() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RK();
				}
				else
				{
					((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rj() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rk();
				}
				((Control)val).ForeColor = tC;
				((Control)QQ.Rq).Controls.Add((Control)(object)val);
				P_3 = ((Control)val).Bottom;
				Label val2 = new Label();
				((Control)val2).MaximumSize = new Size(((Control)QQ.Rq).Width - 21, ((Control)QQ.Rq).Height - 2);
				((Control)val2).AutoSize = true;
				((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 7.8f);
				((Control)val2).Top = P_3;
				((Control)val2).Text = dm.A(bz.aYU);
				((Control)val2).ForeColor = ((Control)val).ForeColor;
				((Control)QQ.Rq).Controls.Add((Control)(object)val2);
				P_3 = ((Control)val2).Bottom;
				P_2++;
			}
		}

		private static void A(string P_0, string P_1, Bm P_2, ref int P_3, ref int P_4)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected O, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			Label val = new Label();
			((Control)val).MaximumSize = new Size(((Control)QQ.Rq).Width - 21, ((Control)QQ.Rq).Height - 2);
			((Control)val).AutoSize = true;
			((Control)val).Font = new Font(Control.DefaultFont.FontFamily, 8f, (FontStyle)1);
			((Control)val).Top = P_4;
			switch (P_2)
			{
			case Bm.tX:
				((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rj() + P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RK();
				break;
			case Bm.tw:
				((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rj() + P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rk();
				break;
			}
			((Control)val).ForeColor = tC;
			((Control)QQ.Rq).Controls.Add((Control)(object)val);
			P_4 = ((Control)val).Bottom;
			Label val2 = new Label();
			((Control)val2).MaximumSize = new Size(((Control)QQ.Rq).Width - 21, ((Control)QQ.Rq).Height - 2);
			((Control)val2).AutoSize = true;
			((Control)val2).Font = new Font(Control.DefaultFont.FontFamily, 7.8f);
			((Control)val2).Top = P_4;
			((Control)val2).Text = P_1;
			((Control)val2).ForeColor = ((Control)val).ForeColor;
			((Control)QQ.Rq).Controls.Add((Control)(object)val2);
			P_4 = ((Control)val2).Bottom + 5;
			P_3++;
		}

		private static void l()
		{
			QQ.re.B();
			QQ.rF.B();
			QQ.rf.B();
			((ToolStripItem)QQ.re).Tag = 0;
			((ToolStripItem)QQ.re).Invalidate();
			((ToolStripItem)QQ.rF).Tag = 0;
			((ToolStripItem)QQ.rF).Invalidate();
			((ToolStripItem)QQ.rf).Tag = 0;
			((ToolStripItem)QQ.rf).Invalidate();
		}

		internal static void M()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected O, but got Unknown
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected O, but got Unknown
			//IL_0259: Unknown result type (might be due to invalid IL or missing references)
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected O, but got Unknown
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected O, but got Unknown
			//IL_0326: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ca: Expected O, but got Unknown
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			Stopwatch val = new Stopwatch();
			val.Start();
			SM.Clear();
			Sm.Clear();
			foreach (Control item in (ArrangedElementCollection)((Control)QQ.Rh).Controls)
			{
				Control val2 = item;
				if (val2 is Button)
				{
					Control obj = ((val2 is Button) ? val2 : null);
					object obj2 = BM.t.Bql;
					if (obj2 == null)
					{
						EventHandler val3 = u;
						BM.t.Bql = val3;
						obj2 = (object)val3;
					}
					obj.Click -= (EventHandler)obj2;
				}
				else if (val2 is LinkLabel)
				{
					Control obj3 = ((val2 is LinkLabel) ? val2 : null);
					object obj4 = BM.t.Bqm;
					if (obj4 == null)
					{
						EventHandler val4 = U;
						BM.t.Bqm = val4;
						obj4 = (object)val4;
					}
					obj3.Click -= (EventHandler)obj4;
				}
			}
			Point autoScrollPosition = ((ScrollableControl)QQ.Rh).AutoScrollPosition;
			int num = ((Point)(ref autoScrollPosition)).Y;
			while (((ArrangedElementCollection)((Control)QQ.Rh).Controls).Count != 0)
			{
				global::A.q.A(((Control)QQ.Rh).Controls[0]);
			}
			((Control)QQ.Rh).SuspendLayout();
			int num2 = 0;
			A(Qz.aWS, true, ref num2, false);
			if (num2 == 0)
			{
				Label val5 = new Label();
				((Control)val5).AutoSize = true;
				((Control)val5).Top = 30;
				((Control)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RL();
				((Control)val5).ForeColor = te;
				((Control)QQ.Rh).Controls.Add((Control)(object)val5);
			}
			((Control)QQ.Rh).ResumeLayout(true);
			((ScrollableControl)QQ.Rh).AutoScrollPosition = new Point(0, -num);
			foreach (Control item2 in (ArrangedElementCollection)((Control)QQ.RI).Controls)
			{
				Control val6 = item2;
				if (val6 is Button)
				{
					Control obj5 = ((val6 is Button) ? val6 : null);
					object obj6 = BM.t.Bql;
					if (obj6 == null)
					{
						EventHandler val7 = u;
						BM.t.Bql = val7;
						obj6 = (object)val7;
					}
					obj5.Click -= (EventHandler)obj6;
				}
				else if (val6 is LinkLabel)
				{
					Control obj7 = ((val6 is LinkLabel) ? val6 : null);
					object obj8 = BM.t.Bqm;
					if (obj8 == null)
					{
						EventHandler val8 = U;
						BM.t.Bqm = val8;
						obj8 = (object)val8;
					}
					obj7.Click -= (EventHandler)obj8;
				}
			}
			autoScrollPosition = ((ScrollableControl)QQ.RI).AutoScrollPosition;
			int num3 = ((Point)(ref autoScrollPosition)).Y;
			while (((ArrangedElementCollection)((Control)QQ.RI).Controls).Count != 0)
			{
				global::A.q.A(((Control)QQ.RI).Controls[0]);
			}
			((Control)QQ.RI).SuspendLayout();
			int num4 = 0;
			A(Qz.aWS, true, ref num4, true);
			if (num4 == 0)
			{
				Label val9 = new Label();
				((Control)val9).AutoSize = true;
				((Control)val9).Top = 30;
				((Control)val9).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rl();
				((Control)val9).ForeColor = te;
				((Control)QQ.RI).Controls.Add((Control)(object)val9);
			}
			((Control)QQ.RI).ResumeLayout(true);
			((ScrollableControl)QQ.RI).AutoScrollPosition = new Point(0, -num3);
			if (num2 == 0)
			{
				QQ.re.B();
			}
			else
			{
				QQ.re.A((num2 > SN && SN != -1) || (num2 != 0 && SN == -1));
			}
			if (num4 == 0)
			{
				QQ.rF.B();
			}
			else
			{
				QQ.rF.A((num4 > Sn && Sn != -1) || (num4 != 0 && Sn == -1));
			}
			SN = num2;
			Sn = num4;
			((ToolStripItem)QQ.re).Tag = num2;
			((ToolStripItem)QQ.re).Invalidate();
			((ToolStripItem)QQ.rF).Tag = num4;
			((ToolStripItem)QQ.rF).Invalidate();
			val.Stop();
			global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RM(), (object)val.ElapsedMilliseconds), false);
		}

		private static void A(List<SettingOrSpecialObject> P_0, bool P_1, ref int P_2, bool P_3)
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			Panel val = (Panel)(object)((!P_3) ? QQ.Rh : QQ.RI);
			int top = 0;
			if (P_1)
			{
				P_2 = 0;
				ThemedButton themedButton = new ThemedButton();
				((Control)themedButton).Width = ((Control)val).Width - 21;
				if (P_3)
				{
					((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rm();
				}
				else
				{
					((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RN();
				}
				((Control)themedButton).Top = top;
				object obj = BM.t.Bql;
				if (obj == null)
				{
					EventHandler val2 = u;
					BM.t.Bql = val2;
					obj = (object)val2;
				}
				((Control)themedButton).Click += (EventHandler)obj;
				((Control)val).Controls.Add((Control)(object)themedButton);
				top = ((Control)themedButton).Bottom + 5;
				if (P_3 && !Qz.aXA.d())
				{
					A(ref P_2, ref top);
				}
			}
			else if (((ArrangedElementCollection)((Control)val).Controls).Count != 0)
			{
				top = ((Control)val).Controls[((ArrangedElementCollection)((Control)val).Controls).Count - 1].Bottom;
			}
			for (int i = 0; i < P_0.Count; i++)
			{
				SettingOrSpecialObject settingOrSpecialObject = P_0[i];
				if (settingOrSpecialObject is Setting setting)
				{
					A(setting, val, ref P_2, ref top);
				}
				A(settingOrSpecialObject.a(), false, ref P_2, P_3);
			}
		}

		private static void A(ref int P_0, ref int P_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			Label val = new Label();
			((Control)val).AutoSize = true;
			((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8f, (FontStyle)1);
			((Control)val).Top = P_1;
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rn();
			((Control)val).ForeColor = Color.Orange;
			((Control)QQ.RI).Controls.Add((Control)(object)val);
			P_1 = ((Control)val).Bottom;
			Label val2 = new Label();
			((Control)val2).AutoSize = true;
			((Control)val2).MinimumSize = new Size(0, 0);
			((Control)val2).MaximumSize = new Size(((Control)QQ.RI).Width - 21, ((Control)QQ.RI).Height - 2);
			((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 7.8f);
			((Control)val2).Top = P_1;
			((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RO() + Qz.aXA.D() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ro();
			((Control)val2).ForeColor = Color.Orange;
			((Control)QQ.RI).Controls.Add((Control)(object)val2);
			P_1 = ((Control)val2).Bottom;
			P_0++;
		}

		private static void A(Setting P_0, Panel P_1, ref int P_2, ref int P_3)
		{
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected O, but got Unknown
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Unknown result type (might be due to invalid IL or missing references)
			//IL_0438: Unknown result type (might be due to invalid IL or missing references)
			//IL_043f: Expected O, but got Unknown
			//IL_0480: Unknown result type (might be due to invalid IL or missing references)
			//IL_049d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Unknown result type (might be due to invalid IL or missing references)
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c4: Expected O, but got Unknown
			//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0504: Unknown result type (might be due to invalid IL or missing references)
			//IL_050b: Expected O, but got Unknown
			//IL_0561: Unknown result type (might be due to invalid IL or missing references)
			//IL_0566: Unknown result type (might be due to invalid IL or missing references)
			//IL_0888: Unknown result type (might be due to invalid IL or missing references)
			//IL_088f: Expected O, but got Unknown
			//IL_0891: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0902: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d7: Expected O, but got Unknown
			//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fb: Expected O, but got Unknown
			//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0781: Unknown result type (might be due to invalid IL or missing references)
			//IL_079e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0753: Unknown result type (might be due to invalid IL or missing references)
			//IL_0769: Unknown result type (might be due to invalid IL or missing references)
			//IL_069e: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a5: Expected O, but got Unknown
			//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f6: Expected O, but got Unknown
			//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0606: Expected O, but got Unknown
			//IL_0608: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ce: Expected O, but got Unknown
			bool flag = !P_0.O();
			if (flag)
			{
				flag = false;
				for (int i = 0; i < P_0.o().Count; i++)
				{
					if (!string.IsNullOrEmpty(P_0.o()[i]))
					{
						flag = true;
						break;
					}
				}
			}
			bool flag2 = SS != null && P_1 == SS;
			if (!flag)
			{
				return;
			}
			string text = ((SettingOrSpecialObject)P_0).S();
			if (P_0.b() && ((SettingOrSpecialObject)P_0).D() is Setting)
			{
				text = ((SettingOrSpecialObject)(((SettingOrSpecialObject)P_0).D() as Setting)).S() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh() + text;
			}
			if (!flag2 && ((ArrangedElementCollection)((Control)P_1).Controls).Count != 0)
			{
				P_3 = ((Control)P_1).Controls[((ArrangedElementCollection)((Control)P_1).Controls).Count - 1].Bottom + 20;
			}
			string text2 = string.Empty;
			if (P_0.o().Count > 1)
			{
				text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RP();
			}
			Label val = new Label();
			if (flag2)
			{
				((Control)val).AutoSize = true;
				((Control)val).MinimumSize = new Size(600, 0);
				((Control)val).MaximumSize = new Size(600, 100);
			}
			else
			{
				((Control)val).AutoSize = true;
				((Control)val).MinimumSize = new Size(0, 0);
				((Control)val).MaximumSize = new Size(((Control)P_1).Width - 21, ((Control)P_1).Height - 2);
			}
			((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8f, (FontStyle)1);
			((Control)val).Top = P_3;
			switch (P_0.P())
			{
			case IllegalitySeverityLevel.Error:
				((Control)val).Text = string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rp(),
					text2,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RQ(),
					text,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rq()
				});
				((Control)val).ForeColor = tC;
				if (flag2 || P_1 == QQ.Rh)
				{
					((Control)P_1).Controls.Add((Control)(object)val);
				}
				break;
			case IllegalitySeverityLevel.Warning:
				((Control)val).Text = string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RR(),
					text2,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RQ(),
					text,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rq()
				});
				((Control)val).ForeColor = Color.Orange;
				if (flag2 || P_1 == QQ.RI)
				{
					((Control)P_1).Controls.Add((Control)(object)val);
				}
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (((uint)qI & (true ? 1u : 0u)) != 0)
				{
					((Control)val).Text = string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rp(),
						text2,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RQ(),
						text,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rq()
					});
					((Control)val).ForeColor = tC;
					if (flag2 || P_1 == QQ.Rh)
					{
						((Control)P_1).Controls.Add((Control)(object)val);
					}
				}
				else
				{
					((Control)val).Text = string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RR(),
						text2,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RQ(),
						text,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rq()
					});
					((Control)val).ForeColor = Color.Orange;
					if (flag2 || P_1 == QQ.RI)
					{
						((Control)P_1).Controls.Add((Control)(object)val);
					}
				}
				break;
			default:
				((Control)val).Text = string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rp(),
					text2,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RQ(),
					text,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rq()
				});
				((Control)val).ForeColor = tC;
				if (flag2 || P_1 == QQ.Rh)
				{
					((Control)P_1).Controls.Add((Control)(object)val);
				}
				break;
			}
			P_3 = ((Control)val).Bottom;
			if (!flag2 && (!((Control)val).Text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rp()) || P_1 != QQ.Rh) && (!((Control)val).Text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RR()) || P_1 != QQ.RI))
			{
				return;
			}
			if (P_1 == QQ.Rh)
			{
				SM.Add(P_0.C());
			}
			else if (P_1 == QQ.RI)
			{
				Sm.Add(P_0.C());
			}
			for (int j = 0; j < P_0.o().Count; j++)
			{
				string text3 = P_0.o()[j];
				if (string.IsNullOrEmpty(text3))
				{
					continue;
				}
				P_2++;
				Label val2 = new Label();
				if (flag2)
				{
					((Control)val2).AutoSize = true;
					((Control)val2).MinimumSize = new Size(600, 0);
					((Control)val2).MaximumSize = new Size(600, 600);
				}
				else
				{
					((Control)val2).AutoSize = true;
					((Control)val2).MinimumSize = new Size(0, 0);
					((Control)val2).MaximumSize = new Size(((Control)P_1).Width - 21, ((Control)P_1).Height - 2);
				}
				((Control)val2).Font = new Font(((Control)val2).Font.FontFamily, 7.8f);
				((Control)val2).Top = P_3;
				((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.cp() + text3;
				((Control)val2).ForeColor = ((Control)val).ForeColor;
				((Control)P_1).Controls.Add((Control)(object)val2);
				P_3 = ((Control)val2).Bottom;
				TreeNode val3 = new TreeNode();
				bool flag3 = false;
				if (P_0.Q().Count != 0 && j < P_0.Q().Count && P_0.Q()[j].Count != 0)
				{
					P_3++;
					List<TreeNode> val4 = new List<TreeNode>();
					Enumerator<int> enumerator = P_0.Q()[j].GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current = enumerator.Current;
							LinkLabel val5 = null;
							TreeNode val6 = QQ.rL.A(QQ.rL.A().a(), new DataIdAndAttrId(current), false);
							if (val6 == null)
							{
								Setting setting = Qz.A(current);
								if (Qz.aWZ.Contains(setting.A()))
								{
									if (!setting.am() && setting.ax() != 1)
									{
										TreeNode val7 = new TreeNode();
										val7.Tag = setting;
										val5 = new LinkLabel();
										val5.LinkColor = tF;
										((Control)val5).Tag = val7;
										string text4 = null;
										text4 = ((((SettingOrSpecialObject)setting).D() == null || string.IsNullOrEmpty(((SettingOrSpecialObject)setting).D().A(bz.aYt))) ? ((SettingOrSpecialObject)setting).A(bz.aYt) : ((SettingOrSpecialObject)setting).D().A(bz.aYt));
										((Control)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rr() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
									}
								}
								else if (!val4.Contains(val3) && QQ.rl.i() == null)
								{
									val4.Add(val3);
									val5 = new LinkLabel();
									val5.LinkColor = tF;
									((Control)val5).Tag = val3;
									((Control)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RS();
								}
							}
							else if (!val4.Contains(val6) && val6 != QQ.rL.A().B())
							{
								val4.Add(val6);
								val5 = new LinkLabel();
								val5.LinkColor = tF;
								((Control)val5).Tag = val6;
								((Control)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rs() + QQ.rL.a(val6, false, false) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
							}
							if (val5 != null)
							{
								if (flag2)
								{
									((Control)val5).AutoSize = true;
									((Control)val5).MinimumSize = new Size(600, 0);
									((Control)val5).MaximumSize = new Size(600, 600);
								}
								else
								{
									((Control)val5).AutoSize = true;
									((Control)val5).MinimumSize = new Size(0, 0);
									((Control)val5).MaximumSize = new Size(((Control)P_1).Width - 21, ((Control)P_1).Height - 2);
								}
								((Control)val5).Top = P_3;
								LinkLabel obj = val5;
								object obj2 = BM.t.Bqm;
								if (obj2 == null)
								{
									EventHandler val8 = U;
									BM.t.Bqm = val8;
									obj2 = (object)val8;
								}
								((Control)obj).Click += (EventHandler)obj2;
								((Control)P_1).Controls.Add((Control)(object)val5);
								P_3 = ((Control)val5).Bottom;
								flag3 = true;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					P_3 += 5;
				}
				if (flag3)
				{
					continue;
				}
				TreeNode val9 = QQ.rL.A(QQ.rL.A().a(), P_0.C(), false);
				if (val9 == null || (val9 == QQ.rL.A().B() && !(QQ.rL.A().B().Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RT())))
				{
					continue;
				}
				LinkLabel val10 = new LinkLabel();
				val10.LinkColor = tF;
				((Control)val10).Tag = val9;
				if (flag2)
				{
					((Control)val10).AutoSize = true;
					((Control)val10).MinimumSize = new Size(600, 0);
					((Control)val10).MaximumSize = new Size(600, 600);
				}
				else
				{
					((Control)val10).AutoSize = true;
					((Control)val10).MinimumSize = new Size(0, 0);
					((Control)val10).MaximumSize = new Size(((Control)P_1).Width - 21, ((Control)P_1).Height - 2);
				}
				if (val9.Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RT())
				{
					string text5 = string.Empty;
					if (P_0.b() && ((SettingOrSpecialObject)P_0).D() is Setting)
					{
						Setting setting2 = ((SettingOrSpecialObject)P_0).D() as Setting;
						text5 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fh() + ((SettingOrSpecialObject)setting2).S();
					}
					((Control)val10).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rs() + QQ.rL.a(val9, false, false) + text5 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
				}
				else
				{
					((Control)val10).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rs() + QQ.rL.a(val9, false, false) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl();
				}
				((Control)val10).Top = P_3;
				object obj3 = BM.t.Bqm;
				if (obj3 == null)
				{
					EventHandler val11 = U;
					BM.t.Bqm = val11;
					obj3 = (object)val11;
				}
				((Control)val10).Click += (EventHandler)obj3;
				((Control)P_1).Controls.Add((Control)(object)val10);
				P_3 = ((Control)val10).Bottom;
			}
		}

		private static void U(object P_0, EventArgs P_1)
		{
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Invalid comparison between Unknown and I4
			if (((Control)((P_0 is LinkLabel) ? P_0 : null)).Tag != null)
			{
				object tag = ((Control)((P_0 is LinkLabel) ? P_0 : null)).Tag;
				if (((TreeNode)((tag is TreeNode) ? tag : null)).Tag != null)
				{
					object tag2 = ((Control)((P_0 is LinkLabel) ? P_0 : null)).Tag;
					if (((TreeNode)((tag2 is TreeNode) ? tag2 : null)).Tag is Setting)
					{
						object tag3 = ((Control)((P_0 is LinkLabel) ? P_0 : null)).Tag;
						Setting setting = ((TreeNode)((tag3 is TreeNode) ? tag3 : null)).Tag as Setting;
						if (!((SettingOrSpecialObject)setting).A().C())
						{
							return;
						}
						Setting setting2 = null;
						MenuNode menuNode = null;
						string text = ((SettingOrSpecialObject)setting).P();
						if (text == null)
						{
							if (((SettingOrSpecialObject)setting).D() != null && ((SettingOrSpecialObject)setting).D().o() != null)
							{
								text = ((SettingOrSpecialObject)setting).D().o().t();
								if (text != null)
								{
									menuNode = ((SettingOrSpecialObject)setting).D().o();
								}
								else if (setting.t() != null)
								{
									text = setting.t().t();
									if (text != null)
									{
										menuNode = setting.t();
									}
								}
							}
						}
						else
						{
							setting2 = setting;
						}
						Ck ck = aM();
						if (text != null && !Bg.A(setting2, menuNode))
						{
							Bg bg = new Bg(text, setting2, menuNode);
							if ((int)((Form)bg).ShowDialog((IWin32Window)(object)QQ) != 1)
							{
								((Component)bg).Dispose();
								return;
							}
							((Component)bg).Dispose();
							ck?.A(setting.C());
							setting.a(1, true);
						}
						else
						{
							ck?.A(setting.C());
							setting.a(1, true);
						}
						if (((SettingOrSpecialObject)setting).D() != null)
						{
							PortFunction.A(((SettingOrSpecialObject)setting).D(), false);
						}
						ck?.B();
						A(setting.C());
						return;
					}
					object tag4 = ((Control)((P_0 is LinkLabel) ? P_0 : null)).Tag;
					TreeNode val = (TreeNode)((tag4 is TreeNode) ? tag4 : null);
					if (((Control)((P_0 is LinkLabel) ? P_0 : null)).Text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rt()))
					{
						if (val.Tag is MenuNode menuNode2)
						{
							menuNode2.B(((Control)((P_0 is LinkLabel) ? P_0 : null)).Text.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RU(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay()).Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay()));
						}
						QQ.rL.A().A((TreeNode)null);
					}
					QQ.rL.A().A(val);
				}
				else
				{
					QQ.rL.C(true);
				}
			}
			else
			{
				QQ.rL.C(true);
			}
		}

		private static void u(object P_0, EventArgs P_1)
		{
			((Control)QQ.Rh).Visible = false;
			((Control)QQ.RI).Visible = false;
			((Control)QQ.Rq).Visible = false;
			QQ.x();
			X();
		}

		internal static void V(object P_0, EventArgs P_1)
		{
			if (((uint)qI & (true ? 1u : 0u)) != 0)
			{
				if (Qz.aWW.IsValid)
				{
					int statusArrayDataId = Qz.aWW.StatusArrayDataId;
					Qz.A(statusArrayDataId)?.J(true);
				}
				global::A.A.a(Qz.aXc, out var _);
			}
		}

		private void v(object P_0, EventArgs P_1)
		{
			((Control)Rh).Visible = !((Control)Rh).Visible;
			if (((Control)rq).Visible)
			{
				sh = (float)rQ.SplitterDistance / (float)((Control)rQ).Width;
			}
			((Control)RI).Visible = false;
			((Control)Rq).Visible = false;
			((Control)rq).Visible = false;
			q();
			x();
			X();
		}

		private void W(object P_0, EventArgs P_1)
		{
			((Control)RI).Visible = !((Control)RI).Visible;
			if (((Control)rq).Visible)
			{
				sh = (float)rQ.SplitterDistance / (float)((Control)rQ).Width;
			}
			((Control)Rh).Visible = false;
			((Control)Rq).Visible = false;
			((Control)rq).Visible = false;
			q();
			x();
			X();
		}

		private void w(object P_0, EventArgs P_1)
		{
			((Control)Rq).Visible = !((Control)Rq).Visible;
			if (((Control)rq).Visible)
			{
				sh = (float)rQ.SplitterDistance / (float)((Control)rQ).Width;
			}
			((Control)Rh).Visible = false;
			((Control)RI).Visible = false;
			((Control)rq).Visible = false;
			q();
			x();
			X();
		}

		internal static void A(Setting P_0, Control P_1)
		{
			A(P_0, 0, P_1);
		}

		internal static void A(Setting P_0, int P_1, Control P_2)
		{
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected O, but got Unknown
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected O, but got Unknown
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Expected O, but got Unknown
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected O, but got Unknown
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected O, but got Unknown
			if (SS != null && !((Control)SS).Disposing && !((Control)SS).IsDisposed)
			{
				if (((Control)SS).Tag == P_0)
				{
					X(null, null);
					return;
				}
				if (((Control)SS).Parent != null && ((Control)SS).Parent.Controls.Contains((Control)(object)SS))
				{
					((Component)SS).Dispose();
				}
			}
			SS = new Panel();
			((Control)SS).BackColor = ((Control)QQ.Rh).BackColor;
			SS.BorderStyle = (BorderStyle)1;
			((Control)SS).Width = 600;
			Panel obj = SS;
			object obj2 = BM.t.BqN;
			if (obj2 == null)
			{
				EventHandler val = X;
				BM.t.BqN = val;
				obj2 = (object)val;
			}
			((Control)obj).Click -= (EventHandler)obj2;
			Panel obj3 = SS;
			object obj4 = BM.t.BqN;
			if (obj4 == null)
			{
				EventHandler val2 = X;
				BM.t.BqN = val2;
				obj4 = (object)val2;
			}
			((Control)obj3).Click += (EventHandler)obj4;
			Control topLevelControl = P_2.TopLevelControl;
			object obj5 = BM.t.BqN;
			if (obj5 == null)
			{
				EventHandler val3 = X;
				BM.t.BqN = val3;
				obj5 = (object)val3;
			}
			topLevelControl.Click -= (EventHandler)obj5;
			Control topLevelControl2 = P_2.TopLevelControl;
			object obj6 = BM.t.BqN;
			if (obj6 == null)
			{
				EventHandler val4 = X;
				BM.t.BqN = val4;
				obj6 = (object)val4;
			}
			topLevelControl2.Click += (EventHandler)obj6;
			P_2.TopLevelControl.Controls.Add((Control)(object)SS);
			((Control)SS).Tag = P_0;
			while (((ArrangedElementCollection)((Control)SS).Controls).Count != 0)
			{
				Control val5 = ((Control)SS).Controls[0];
				if (val5 is ThemedButton)
				{
					ThemedButton obj7 = val5 as ThemedButton;
					object obj8 = BM.t.Bqn;
					if (obj8 == null)
					{
						EventHandler val6 = y;
						BM.t.Bqn = val6;
						obj8 = (object)val6;
					}
					((Control)obj7).Click -= (EventHandler)obj8;
					ThemedButton obj9 = val5 as ThemedButton;
					object obj10 = BM.t.BqO;
					if (obj10 == null)
					{
						EventHandler val7 = Y;
						BM.t.BqO = val7;
						obj10 = (object)val7;
					}
					((Control)obj9).Click -= (EventHandler)obj10;
					ThemedButton obj11 = val5 as ThemedButton;
					object obj12 = BM.t.Bqo;
					if (obj12 == null)
					{
						EventHandler val8 = x;
						BM.t.Bqo = val8;
						obj12 = (object)val8;
					}
					((Control)obj11).Click -= (EventHandler)obj12;
				}
				((Component)val5).Dispose();
			}
			int num = 0;
			int num2 = 0;
			A(P_0, SS, ref num, ref num2);
			Cn cn = null;
			bool flag = false;
			MenuNode menuNode = MenuNode.A(Qz.awj, P_0.C());
			if (menuNode != null)
			{
				MenuNode menuNode2 = menuNode.A(P_0);
				if (menuNode2 != null)
				{
					cn = menuNode2.Y().BcF;
					flag = menuNode2.z();
				}
			}
			Label val9 = new Label();
			((Control)val9).ForeColor = te;
			((Control)val9).AutoSize = true;
			((Control)val9).MinimumSize = new Size(600, 0);
			((Control)val9).MaximumSize = new Size(600, 600);
			((Control)val9).Left = 0;
			((Control)val9).Top = num2 + 10;
			if (cn != null && P_0.e() && flag && !string.IsNullOrEmpty(P_0.F()) && !string.IsNullOrEmpty(P_0.f()))
			{
				string text = P_0.f();
				if (string.IsNullOrEmpty(((Control)val9).Text))
				{
					if (!string.IsNullOrEmpty(text))
					{
						((Control)val9).Text = P_0.F() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ru() + text;
					}
				}
				else if (!string.IsNullOrEmpty(text))
				{
					((Control)val9).Text = ((Control)val9).Text + P_0.F() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ru() + text;
				}
			}
			else
			{
				string text2 = ((SettingOrSpecialObject)P_0).A(bz.aYU);
				if (string.IsNullOrEmpty(((Control)val9).Text))
				{
					if (!string.IsNullOrEmpty(text2))
					{
						((Control)val9).Text = ((SettingOrSpecialObject)P_0).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ru() + text2;
					}
				}
				else if (!string.IsNullOrEmpty(text2))
				{
					((Control)val9).Text = ((Control)val9).Text + ((SettingOrSpecialObject)P_0).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ru() + text2;
				}
			}
			if (num == 0 && P_0.d(0).Count == 0 && P_0.e(0).Count == 0 && !P_0.U())
			{
				int num3;
				int num4;
				if (cn != null && P_0.e() && flag)
				{
					num3 = P_0.aO();
					num4 = P_0.ao();
				}
				else
				{
					num3 = P_0.aR();
					num4 = P_0.ar();
				}
				if (num3 != 0 || num4 != 0)
				{
					if (string.IsNullOrEmpty(((Control)val9).Text))
					{
						((Control)val9).Text = ((SettingOrSpecialObject)P_0).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RV();
					}
					else
					{
						((Control)val9).Text = ((Control)val9).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv();
					}
					int num5 = P_0.aS();
					int num6 = P_0.K();
					string text3 = bS.a(num3, num5, num6);
					string text4 = bS.a(num4, num5, num6);
					((Control)val9).Text = ((Control)val9).Text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FJ(), (object)text3, (object)text4);
					int num7 = P_0.an();
					if (num7 > 1)
					{
						string text5 = bS.a(num7, num5, num6);
						((Control)val9).Text = ((Control)val9).Text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RW(), (object)text5);
					}
				}
			}
			((Control)SS).Controls.Add((Control)(object)val9);
			int height = ((Control)val9).Bottom + 10;
			bool flag2 = string.IsNullOrEmpty(((Control)val9).Text);
			a(P_0, P_1, ref height, ref flag2);
			if (cn != null && (!P_0.e() || !flag))
			{
				A(cn, P_0, P_1, ref height, ref flag2);
			}
			A(P_0, P_1, ref height, ref flag2);
			((Control)SS).Height = height;
			int num8 = P_2.Right + 10;
			int num9 = P_2.Top - 10;
			Control val10 = P_2;
			bool flag3 = false;
			do
			{
				if (val10.Parent != null && val10.Parent != P_2.TopLevelControl)
				{
					val10 = val10.Parent;
					num8 += val10.Left;
					num9 += val10.Top;
				}
				else
				{
					flag3 = true;
				}
			}
			while (!flag3);
			if (num9 + ((Control)SS).Height > P_2.TopLevelControl.Height - 100)
			{
				num9 -= num9 + ((Control)SS).Height - (P_2.TopLevelControl.Height - 100);
			}
			num9 = Math.Max(num9, 0);
			if (num8 + ((Control)SS).Width > P_2.TopLevelControl.Width - 20)
			{
				num8 -= num8 + ((Control)SS).Width - (P_2.TopLevelControl.Width - 20);
			}
			num8 = Math.Max(num8, 0);
			((Control)SS).Left = num8;
			((Control)SS).Top = num9;
			((Control)SS).Visible = true;
			((Control)SS).BringToFront();
		}

		internal static void A(List<string> P_0, List<Color> P_1, Control P_2, object P_3, int P_4, int P_5)
		{
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected O, but got Unknown
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Expected O, but got Unknown
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Expected O, but got Unknown
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Expected O, but got Unknown
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0204: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Expected O, but got Unknown
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Expected O, but got Unknown
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Expected O, but got Unknown
			if (SS != null && !((Control)SS).Disposing && !((Control)SS).IsDisposed)
			{
				if (((Control)SS).Tag == P_3)
				{
					X(null, null);
					return;
				}
				if (((Control)SS).Parent != null && ((Control)SS).Parent.Controls.Contains((Control)(object)SS))
				{
					((Component)SS).Dispose();
				}
			}
			int num = 0;
			Enumerator<string> enumerator = P_0.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					int num2 = num;
					Size val = TextRenderer.MeasureText(current, Control.DefaultFont);
					num = Math.Max(num2, ((Size)(ref val)).Width + 10);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			SS = new Panel();
			((Control)SS).BackColor = ((Control)QQ.Rh).BackColor;
			SS.BorderStyle = (BorderStyle)1;
			((Control)SS).Width = num;
			Panel obj = SS;
			object obj2 = BM.t.BqN;
			if (obj2 == null)
			{
				EventHandler val2 = X;
				BM.t.BqN = val2;
				obj2 = (object)val2;
			}
			((Control)obj).Click -= (EventHandler)obj2;
			Panel obj3 = SS;
			object obj4 = BM.t.BqN;
			if (obj4 == null)
			{
				EventHandler val3 = X;
				BM.t.BqN = val3;
				obj4 = (object)val3;
			}
			((Control)obj3).Click += (EventHandler)obj4;
			Control topLevelControl = P_2.TopLevelControl;
			object obj5 = BM.t.BqN;
			if (obj5 == null)
			{
				EventHandler val4 = X;
				BM.t.BqN = val4;
				obj5 = (object)val4;
			}
			topLevelControl.Click -= (EventHandler)obj5;
			Control topLevelControl2 = P_2.TopLevelControl;
			object obj6 = BM.t.BqN;
			if (obj6 == null)
			{
				EventHandler val5 = X;
				BM.t.BqN = val5;
				obj6 = (object)val5;
			}
			topLevelControl2.Click += (EventHandler)obj6;
			P_2.TopLevelControl.Controls.Add((Control)(object)SS);
			((Control)SS).Tag = P_3;
			while (((ArrangedElementCollection)((Control)SS).Controls).Count != 0)
			{
				Control val6 = ((Control)SS).Controls[0];
				if (val6 is ThemedButton)
				{
					ThemedButton obj7 = val6 as ThemedButton;
					object obj8 = BM.t.Bqn;
					if (obj8 == null)
					{
						EventHandler val7 = y;
						BM.t.Bqn = val7;
						obj8 = (object)val7;
					}
					((Control)obj7).Click -= (EventHandler)obj8;
					ThemedButton obj9 = val6 as ThemedButton;
					object obj10 = BM.t.BqO;
					if (obj10 == null)
					{
						EventHandler val8 = Y;
						BM.t.BqO = val8;
						obj10 = (object)val8;
					}
					((Control)obj9).Click -= (EventHandler)obj10;
					ThemedButton obj11 = val6 as ThemedButton;
					object obj12 = BM.t.Bqo;
					if (obj12 == null)
					{
						EventHandler val9 = x;
						BM.t.Bqo = val9;
						obj12 = (object)val9;
					}
					((Control)obj11).Click -= (EventHandler)obj12;
				}
				((Component)val6).Dispose();
			}
			int num3 = 10;
			enumerator = P_0.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current2 = enumerator.Current;
					Label val10 = new Label();
					((Control)val10).ForeColor = P_1[P_0.IndexOf(current2)];
					((Control)val10).AutoSize = true;
					((Control)val10).Text = current2;
					((Control)val10).Left = 0;
					((Control)val10).Top = num3;
					((Control)SS).Controls.Add((Control)(object)val10);
					num3 = ((Control)val10).Bottom + 10;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			((Control)SS).Height = num3;
			int num4 = P_4;
			int num5 = P_5;
			Control val11 = P_2;
			bool flag = false;
			do
			{
				if (val11.Parent != null && val11.Parent != P_2.TopLevelControl)
				{
					val11 = val11.Parent;
					num4 += val11.Left;
					num5 += val11.Top;
				}
				else
				{
					flag = true;
				}
			}
			while (!flag);
			if (num5 + ((Control)SS).Height > P_2.TopLevelControl.Height - 100)
			{
				num5 -= num5 + ((Control)SS).Height - (P_2.TopLevelControl.Height - 100);
			}
			num5 = Math.Max(num5, 0);
			if (num4 + ((Control)SS).Width > P_2.TopLevelControl.Width - 20)
			{
				num4 -= num4 + ((Control)SS).Width - (P_2.TopLevelControl.Width - 20);
			}
			num4 = Math.Max(num4, 0);
			((Control)SS).Left = num4;
			((Control)SS).Top = num5;
			((Control)SS).Visible = true;
			((Control)SS).BringToFront();
		}

		internal static void X(object P_0, EventArgs P_1)
		{
			if (SS != null && !((Control)SS).Disposing && !((Control)SS).IsDisposed)
			{
				((Control)SS).Tag = null;
				((Control)SS).Visible = false;
			}
		}

		private static void A(Cn P_0, Setting P_1, int P_2, ref int P_3, ref bool P_4)
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Expected O, but got Unknown
			if (P_1.c() != 0 || (Qz.B() && Qz.b() && P_1.J()))
			{
				return;
			}
			int[] array = P_0.a(P_1);
			if (array == null || array.Length <= P_2)
			{
				return;
			}
			int num = array[P_2];
			string bsP = P_0.BcC[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fu()].BsP;
			Label val = new Label();
			((Control)val).ForeColor = te;
			((Control)val).AutoSize = true;
			((Control)val).MinimumSize = new Size(600, 0);
			((Control)val).MaximumSize = new Size(600, 100);
			((Control)val).Left = 0;
			((Control)val).Top = P_3;
			if (P_4)
			{
				((Control)val).Text = ((SettingOrSpecialObject)P_1).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RV();
				P_4 = false;
			}
			int num2 = P_1.m(P_2);
			bool num3 = num2 == num;
			if (!num3)
			{
				((Control)val).Font = new Font(((Control)val).Font.FontFamily, 8.25f, (FontStyle)2);
			}
			int num4 = P_1.K();
			ValueTuple<string, string, bool> val2 = P_1.A(num2, num4);
			ValueTuple<string, string, bool> val3 = P_1.A(num, num4);
			((Control)val).Text = ((Control)val).Text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rw(), (object)val2.Item1);
			((Control)val).Text = ((Control)val).Text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RX() + bsP + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rx(), (object)val3.Item1);
			((Control)SS).Controls.Add((Control)(object)val);
			if (num3)
			{
				P_3 += ((Control)val).Height + 10;
				return;
			}
			ThemedButton themedButton = new ThemedButton();
			((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RY() + bsP + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ry();
			((Control)themedButton).Tag = new object[3];
			(((Control)themedButton).Tag as object[])[0] = P_1;
			(((Control)themedButton).Tag as object[])[1] = P_2;
			(((Control)themedButton).Tag as object[])[2] = num;
			((Control)themedButton).AutoSize = false;
			((Control)themedButton).Width = 250;
			((Control)themedButton).Height = 47;
			((Control)themedButton).Left = 300 - ((Control)themedButton).Width / 2;
			((Control)themedButton).Top = ((Control)val).Bottom + 10;
			((Control)themedButton).Enabled = Qz.C();
			object obj = BM.t.Bqo;
			if (obj == null)
			{
				EventHandler val4 = x;
				BM.t.Bqo = val4;
				obj = (object)val4;
			}
			((Control)themedButton).Click += (EventHandler)obj;
			((Control)SS).Controls.Add((Control)(object)themedButton);
			P_3 += ((Control)val).Height + 10 + ((Control)themedButton).Height + 10;
		}

		private static void x(object P_0, EventArgs P_1)
		{
			if (((Control)(P_0 as ThemedButton)).Tag != null)
			{
				Setting setting = (((Control)(P_0 as ThemedButton)).Tag as object[])[0] as Setting;
				int num = (int)(((Control)(P_0 as ThemedButton)).Tag as object[])[1];
				int num2 = (int)(((Control)(P_0 as ThemedButton)).Tag as object[])[2];
				Ck ck = aM();
				ck?.A(setting.C());
				setting.a(num, num2, true);
				ck?.B();
				A(setting.C());
			}
			X(null, null);
		}

		private static void A(Setting P_0, int P_1, ref int P_2, ref bool P_3)
		{
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected O, but got Unknown
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Expected O, but got Unknown
			if (Qn == null)
			{
				return;
			}
			Setting setting = Qn.A(P_0.C());
			if (setting == null || (Qz.B() && Qz.b() && P_0.J()) || (Qn.B() && Qn.b() && setting.J()))
			{
				return;
			}
			Label val = new Label();
			((Control)val).AutoSize = true;
			((Control)val).MinimumSize = new Size(600, 0);
			((Control)val).MaximumSize = new Size(600, 100);
			((Control)val).Left = 0;
			((Control)val).Top = P_2;
			if (P_3)
			{
				((Control)val).Text = ((SettingOrSpecialObject)P_0).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RV();
				P_3 = false;
			}
			bool flag;
			if (P_0.c() != 0)
			{
				string text = P_0.ay();
				string text2 = setting.ay();
				flag = text == text2;
				if (flag)
				{
					((Control)val).ForeColor = te;
				}
				else
				{
					((Control)val).ForeColor = tD;
				}
				((Control)val).Text = ((Control)val).Text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rw(), (object)text);
				((Control)val).Text = ((Control)val).Text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RZ(), (object)text2);
			}
			else
			{
				int num = P_0.m(P_1);
				int num2 = setting.m(P_1);
				flag = num == num2;
				if (flag)
				{
					((Control)val).ForeColor = te;
				}
				else
				{
					((Control)val).ForeColor = tD;
				}
				int num3 = P_0.K();
				ValueTuple<string, string, bool> val2 = P_0.A(num, num3);
				ValueTuple<string, string, bool> val3 = setting.A(num2, num3);
				((Control)val).Text = ((Control)val).Text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rw(), (object)val2.Item1);
				((Control)val).Text = ((Control)val).Text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RZ(), (object)val3.Item1);
			}
			((Control)SS).Controls.Add((Control)(object)val);
			if (flag || QO == BM.b.BpG)
			{
				P_2 += ((Control)val).Height + 10;
				return;
			}
			ThemedButton themedButton = new ThemedButton();
			((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rz();
			((Control)themedButton).Tag = new object[2];
			(((Control)themedButton).Tag as object[])[0] = P_0;
			(((Control)themedButton).Tag as object[])[1] = P_1;
			((Control)themedButton).AutoSize = false;
			((Control)themedButton).Width = 120;
			((Control)themedButton).Height = 47;
			((Control)themedButton).Left = 300 - ((Control)themedButton).Width / 2;
			((Control)themedButton).Top = ((Control)val).Bottom + 10;
			((Control)themedButton).Enabled = Qz.C();
			object obj = BM.t.BqO;
			if (obj == null)
			{
				EventHandler val4 = Y;
				BM.t.BqO = val4;
				obj = (object)val4;
			}
			((Control)themedButton).Click += (EventHandler)obj;
			((Control)SS).Controls.Add((Control)(object)themedButton);
			P_2 += ((Control)val).Height + 10 + ((Control)themedButton).Height + 10;
		}

		private static void Y(object P_0, EventArgs P_1)
		{
			if (Qn != null && ((Control)(P_0 as ThemedButton)).Tag != null)
			{
				Setting setting = (((Control)(P_0 as ThemedButton)).Tag as object[])[0] as Setting;
				Setting setting2 = Qn.A(setting.C());
				if (setting2 != null)
				{
					Ck ck = aM();
					ck?.A(setting.C());
					if (setting.c() != 0)
					{
						for (int i = 0; i < Math.Min(setting.BB(), setting2.BB()); i++)
						{
							setting.A(i, setting2.l(i), true);
						}
					}
					else
					{
						int num = (int)(((Control)(P_0 as ThemedButton)).Tag as object[])[1];
						setting.a(num, setting2.m(num), true);
					}
					ck?.B();
					A(setting.C());
				}
			}
			X(null, null);
		}

		private static void a(Setting P_0, int P_1, ref int P_2, ref bool P_3)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Expected O, but got Unknown
			if (!Qz.B() || !Qz.b() || !P_0.J())
			{
				Label val = new Label();
				((Control)val).ForeColor = te;
				((Control)val).AutoSize = true;
				((Control)val).MinimumSize = new Size(600, 0);
				((Control)val).MaximumSize = new Size(600, 100);
				((Control)val).Left = 0;
				((Control)val).Top = P_2;
				if (P_3)
				{
					((Control)val).Text = ((SettingOrSpecialObject)P_0).A(true) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.RV();
					P_3 = false;
				}
				if (P_0.c() != 0)
				{
					string text = P_0.ay();
					string text2 = P_0.aw();
					((Control)val).Text = ((Control)val).Text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rw(), (object)text);
					((Control)val).Text = ((Control)val).Text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rA(), (object)text2);
				}
				else
				{
					int num = P_0.m(P_1);
					int num2 = P_0.L(P_1);
					int num3 = P_0.K();
					ValueTuple<string, string, bool> val2 = P_0.A(num, num3);
					ValueTuple<string, string, bool> val3 = P_0.A(num2, num3);
					((Control)val).Text = ((Control)val).Text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rw(), (object)val2.Item1);
					((Control)val).Text = ((Control)val).Text + string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rA(), (object)val3.Item1);
				}
				((Control)SS).Controls.Add((Control)(object)val);
				ThemedButton themedButton = new ThemedButton();
				((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fU();
				((Control)themedButton).Tag = new object[2];
				(((Control)themedButton).Tag as object[])[0] = P_0;
				(((Control)themedButton).Tag as object[])[1] = P_1;
				((Control)themedButton).AutoSize = false;
				((Control)themedButton).Width = 150;
				((Control)themedButton).Height = 47;
				((Control)themedButton).Left = 300 - ((Control)themedButton).Width / 2;
				((Control)themedButton).Top = ((Control)val).Bottom + 10;
				((Control)themedButton).Enabled = Qz.C();
				object obj = BM.t.Bqn;
				if (obj == null)
				{
					EventHandler val4 = y;
					BM.t.Bqn = val4;
					obj = (object)val4;
				}
				((Control)themedButton).Click += (EventHandler)obj;
				((Control)SS).Controls.Add((Control)(object)themedButton);
				P_2 += ((Control)val).Height + 10 + ((Control)themedButton).Height + 10;
			}
		}

		private static void y(object P_0, EventArgs P_1)
		{
			if (((Control)(P_0 as ThemedButton)).Tag != null)
			{
				Setting setting = (((Control)(P_0 as ThemedButton)).Tag as object[])[0] as Setting;
				Ck ck = aM();
				ck?.A(setting.C());
				if (setting.c() != 0)
				{
					setting.A(setting.aw(), true);
				}
				else
				{
					int num = (int)(((Control)(P_0 as ThemedButton)).Tag as object[])[1];
					setting.A(num, true);
				}
				ck?.B();
				A(setting.C());
			}
			X(null, null);
		}

		internal static void m()
		{
			foreach (bt value in System.Enum.GetValues(typeof(bt)))
			{
				bu bu = new bu(value);
				string text = bu.G();
				MenuNode menuNode = new MenuNode(null, bu, null, false, false, string.Empty);
				menuNode.A(-1);
				menuNode.a(text);
				menuNode.D(bu.f());
				menuNode.a(0);
				ST.Add(menuNode);
			}
		}

		internal static void N()
		{
			if ((qI & 1) == 0)
			{
				St = true;
			}
		}

		internal static void n()
		{
			lock (ST)
			{
				for (int i = 0; i < ST.Count; i++)
				{
					ST[i].B().A((byte)0);
					ST[i].B().A((global::A.k)null);
				}
			}
		}

		private static void O()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_0571: Unknown result type (might be due to invalid IL or missing references)
			//IL_0576: Unknown result type (might be due to invalid IL or missing references)
			if (QQ.rL.A().a().Count == 0)
			{
				return;
			}
			Stopwatch val = new Stopwatch();
			val.Start();
			lock (ST)
			{
				if (SU == null)
				{
					SU = new byte[ST.Count];
				}
				for (int i = 0; i < ST.Count; i++)
				{
					SU[i] = ST[i].B().b();
				}
				if (Su == null)
				{
					Su = new global::A.k[ST.Count];
				}
				for (int j = 0; j < ST.Count; j++)
				{
					Su[j] = ST[j].B().a();
				}
				global::A.F f = null;
				if (((uint)qI & (true ? 1u : 0u)) != 0 && SI.Count == 1)
				{
					f = SI[0].BpS;
					if (f.@as[37].BF == 0)
					{
						f = null;
					}
				}
				if (f != null)
				{
					if (!global::A.A.A(f.ao, global::A.f.aZ, 0u, f.@as[37].BF, out var array, out var _))
					{
						val.Stop();
						return;
					}
					byte b = 0;
					byte b2 = 0;
					byte b3 = 0;
					byte b4 = 0;
					byte b5 = 0;
					byte b6 = 0;
					byte[] array2 = new byte[12];
					bool flag2 = false;
					List<int> val2 = new List<int>();
					for (int k = 0; k < array.Length; k++)
					{
						byte b7 = array[k];
						switch (k % 16)
						{
						case 0:
							b = b7;
							flag2 = b == 0;
							break;
						case 1:
							b3 = b7;
							break;
						case 2:
							b4 = b7;
							break;
						case 3:
							b5 = b7;
							break;
						case 4:
							b6 = b7;
							break;
						case 5:
							b2 = b7;
							break;
						case 10:
							array2[0] = (byte)(b7 >> 4);
							array2[1] = (byte)(b7 & 0xFu);
							break;
						case 11:
							array2[2] = (byte)(b7 >> 4);
							array2[3] = (byte)(b7 & 0xFu);
							break;
						case 12:
							array2[4] = (byte)(b7 >> 4);
							array2[5] = (byte)(b7 & 0xFu);
							break;
						case 13:
							array2[6] = (byte)(b7 >> 4);
							array2[7] = (byte)(b7 & 0xFu);
							break;
						case 14:
							array2[8] = (byte)(b7 >> 4);
							array2[9] = (byte)(b7 & 0xFu);
							break;
						case 15:
						{
							array2[10] = (byte)(b7 >> 4);
							array2[11] = (byte)(b7 & 0xFu);
							if (flag2)
							{
								break;
							}
							for (int l = 0; l < ST.Count; l++)
							{
								if ((uint)ST[l].B().A() == b)
								{
									ST[l].B().A(new global::A.k(b3, b4, b5, b6, 0));
									if (!bx.A(Qz.awZ) && ((Qz.awZ == 21 && Qz.aXA >= new global::A.k(2, 33, 0, 1, 0)) || (Qz.awZ != 21 && Qz.aXA >= new global::A.k(1, 33, 0, 1, 0))))
									{
										ST[l].B().A(array2);
									}
									if (Qz.A(ST[l].B().A()) && (b2 == 0 || (b2 & 1) == 0))
									{
										ST[l].B().A((byte)(b2 | 1u));
									}
									else
									{
										ST[l].B().A(b2);
									}
									val2.Add(l);
									break;
								}
							}
							break;
						}
						}
						if (flag2)
						{
							break;
						}
					}
					for (int m = 0; m < ST.Count; m++)
					{
						if (!val2.Contains(m))
						{
							if (Qz.A(ST[m].B().A()))
							{
								ST[m].B().A(1);
							}
							else
							{
								ST[m].B().A((byte)0);
							}
						}
					}
				}
				else
				{
					for (int n = 0; n < ST.Count; n++)
					{
						if (Qz.A(ST[n].B().A()))
						{
							ST[n].B().A(1);
						}
						else
						{
							ST[n].B().A((byte)0);
						}
					}
				}
				List<int> val3 = new List<int>();
				for (int num = 0; num < ST.Count; num++)
				{
					if (SU[num] != ST[num].B().b() || Su[num] != ST[num].B().a())
					{
						val3.Add(num);
					}
				}
				if (val3.Count != 0)
				{
					string text = string.Empty;
					Enumerator<int> enumerator = val3.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current = enumerator.Current;
							text = string.Concat(new string[7]
							{
								text,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ra(),
								((object)ST[current].B().A()).ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rB(),
								SU[current].ToString(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rb(),
								ST[current].B().b().ToString()
							});
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rC() + text, true);
					QQ.rL.A(false, true, true, false);
					QQ.rL.B(false);
					if (Qn != null)
					{
						QQ.rL.b(false);
					}
				}
			}
			val.Stop();
			global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rc(), (object)val.ElapsedMilliseconds), false);
		}

		private void Z(object P_0, EventArgs P_1)
		{
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Invalid comparison between Unknown and I4
			global::A.F f = null;
			if (P_0 is global::A.F)
			{
				f = P_0 as global::A.F;
			}
			else if (SI.Count == 1)
			{
				f = SI[0].BpS;
			}
			else if (global::A.A.c().Count == 1)
			{
				f = global::A.A.c()[0];
			}
			if (f != null)
			{
				Ct.a();
				OpenFileDialog val = new OpenFileDialog();
				if (SV == null)
				{
					SV = CZ.Bdl;
				}
				else if (Sv != null)
				{
					((FileDialog)val).FileName = Sv;
				}
				((FileDialog)val).InitialDirectory = SV;
				((FileDialog)val).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ki();
				((FileDialog)val).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kJ();
				if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
				{
					a(((FileDialog)val).FileName, f);
					try
					{
						SV = Path.GetDirectoryName(((FileDialog)val).FileName);
						Sv = ((FileDialog)val).FileName;
					}
					catch
					{
						SV = null;
						Sv = null;
					}
				}
				((Component)val).Dispose();
			}
			else
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rD(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private void a(string P_0, global::A.F P_1)
		{
			A(P_0, P_1, false, false, true, null);
		}

		private void A(string P_0, global::A.F P_1, bool P_2, bool P_3, bool P_4, List<string> P_5)
		{
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0327: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Invalid comparison between Unknown and I4
			List<CW> val = CZ.a(P_0);
			if (val.Count != 0)
			{
				global::A.k k = null;
				if (P_1.aK != 255 || P_1.ak != 255 || P_1.aL != 255 || P_1.al != 255)
				{
					k = new global::A.k(P_1.aK, P_1.ak, P_1.aL, P_1.al, 0);
				}
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				Enumerator<CW> enumerator = val.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						CW current = enumerator.Current;
						bool flag4;
						bool flag5;
						if (current.BDy != null)
						{
							flag4 = current.BDy.axs == P_1.ah || (qP != null && (P_1.ah == 0 || P_1.ah == 255)) || current.BDy.axS == 22;
							flag5 = current.BDy.axS == P_1.aH || (qP != null && (P_1.aH == 0 || P_1.aH == 255));
						}
						else
						{
							flag5 = false;
							flag4 = false;
						}
						if (!(flag5 && flag4))
						{
							continue;
						}
						flag = true;
						if (!(k == null) && !(current.BDy.axT >= k))
						{
							continue;
						}
						flag2 = true;
						if (!CZ.b(P_1.ao) && !current.BDZ.Contains(P_1.aJ))
						{
							continue;
						}
						flag3 = true;
						bool flag6 = CZ.A(P_1, true) || P_3;
						global::A.k k2 = new global::A.k(P_1.ae, P_1.aF, P_1.af, P_1.aG, P_1.ag);
						global::A.k axT = current.BDy.axT;
						bool flag7 = false;
						CX cX = new CX
						{
							BdC = current.BDy,
							Bdc = current.BDZ
						};
						if (!qW)
						{
							if (Ct.A(cX, out var text, out var _))
							{
								string text2 = (string.IsNullOrEmpty(text) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.km() : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kM() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()));
								if ((int)bE.A((IWin32Window)(object)QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kN() + text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kn(), (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)256, new string[2]
								{
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kq(),
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV()
								}) == 2)
								{
									flag7 = true;
								}
							}
							if (!flag7 && !cX.BdC.axT.d() && !A(cX.BdC.axT))
							{
								flag7 = true;
							}
						}
						bool flag9 = false;
						if (!qW && !flag7)
						{
							flag9 = A(P_1, k2, axT, out flag7);
						}
						if (flag7)
						{
							qP = null;
							qq = true;
							qR.Clear();
							global::A.A.D();
							global::A.A.d();
						}
						else
						{
							CZ.A(P_1, P_0, false, P_2, flag6, null, flag9, false, bt.avK, null, null, false, null, null, null, P_4, P_5);
						}
						break;
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				if (!qW)
				{
					if (!flag)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kk(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else if (!flag2 || !flag3)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kL(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
				if (!flag || !flag2 || !flag3)
				{
					qP = null;
					qq = true;
					qR.Clear();
					global::A.A.D();
					global::A.A.d();
				}
			}
			else
			{
				if (!qW)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kK(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				qP = null;
				qq = true;
				qR.Clear();
				global::A.A.D();
				global::A.A.d();
			}
		}

		private bool A(global::A.k P_0)
		{
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Invalid comparison between Unknown and I4
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Invalid comparison between Unknown and I4
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			string text = P_0.D();
			if (bg.a())
			{
				if ((int)bE.A((IWin32Window)(object)QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kR() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kO() + text, (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)256, new string[2]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kq(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV()
				}) == 2)
				{
					return false;
				}
			}
			else
			{
				if ((int)bE.A((IWin32Window)(object)QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kO() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ko(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kP(), (MessageBoxButtons)1, (MessageBoxIcon)48) != 1)
				{
					return false;
				}
				bg bg = new bg();
				((Form)bg).ShowDialog((IWin32Window)(object)QQ);
				((Component)bg).Dispose();
				if (!bg.a())
				{
					return false;
				}
			}
			return true;
		}

		internal static bool A(global::A.F P_0, global::A.k P_1, global::A.k P_2, out bool P_3)
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Invalid comparison between Unknown and I4
			bool result = false;
			P_3 = false;
			if (P_0.aH == 20)
			{
				if (CZ.A(P_0, true))
				{
					result = true;
				}
				else if (P_0.ah == 3)
				{
					global::A.k k = new global::A.k(1, 18, 0, 102, 0);
					if (P_1 != null && P_2 != null && ((P_1 < k && P_2 >= k) || (P_1 >= k && P_2 < k)))
					{
						if ((int)bE.A((IWin32Window)(object)QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rd(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rE(), (MessageBoxButtons)1, (MessageBoxIcon)48) == 1)
						{
							result = true;
						}
						else
						{
							P_3 = true;
						}
					}
				}
			}
			return result;
		}

		internal void z(object P_0, EventArgs P_1)
		{
			b((string)null);
		}

		private void b(string P_0)
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			if (SI.Count != 1)
			{
				return;
			}
			if (Qz != null && Qz.awZ != 21 && Qz.o())
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kp(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kQ(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			Ct.a();
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.DoWork += new DoWorkEventHandler(H);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(g);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.re());
			val.RunWorkerAsync((object)P_0);
		}

		private void a(global::A.F P_0)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			if (qP != null)
			{
				CZ.A(P_0, qP, false, false, false, null, false, false, bt.avK, null, null, false, null, null, null, false, null);
				return;
			}
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.DoWork += new DoWorkEventHandler(H);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(g);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.re());
			val.RunWorkerAsync();
		}

		private void H(object P_0, DoWorkEventArgs P_1)
		{
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			if (SI.Count == 1)
			{
				global::A.F bpS = SI[0].BpS;
				global::A.k k = null;
				if (bpS.aK != 255 || bpS.ak != 255 || bpS.aL != 255 || bpS.al != 255)
				{
					k = new global::A.k(bpS.aK, bpS.ak, bpS.aL, bpS.al, 0);
				}
				global::A.k k2 = new global::A.k(bpS.ae, bpS.aF, bpS.af, bpS.aG, 0);
				bool flag = !bg.a();
				List<CY> bQF = CZ.A((BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null), bpS.aH, bpS.ah, k2, bpS.aJ, bpS.ao, k, flag, bt.avK, null, false);
				List<CY> bQf = CZ.A(null, 22, 13, null, 65535, bpS.ao, null, flag, bt.avK, null, false);
				Dictionary<bt, List<CY>> val = new Dictionary<bt, List<CY>>();
				Enumerator<MenuNode> enumerator = ST.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						bu bu = enumerator.Current.B();
						global::A.k k3 = bu.a();
						if (bu.a() != null && (k3.A() != 0 || k3.a() != 0 || k3.B() != 0 || k3.b() != 0))
						{
							List<CY> val2 = CZ.A(null, bpS.aH, bpS.ah, k2, bpS.aJ, bpS.ao, k, flag, bu.A(), k3, bu.E());
							val.Add(bu.A(), val2);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				string bQg = null;
				if (P_1.Argument != null && P_1.Argument is string)
				{
					bQg = P_1.Argument as string;
				}
				J j = new J();
				j.BQF = bQF;
				j.BQf = bQf;
				j.BQG = val;
				j.BQg = bQg;
				P_1.Result = j;
			}
			else
			{
				P_1.Result = null;
			}
		}

		private void g(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			P();
			J j = P_1.Result as J;
			if (SI.Count == 1 && j != null && j.BQF != null)
			{
				global::A.F bpS = SI[0].BpS;
				global::A.k k = new global::A.k(bpS.ae, bpS.aF, bpS.af, bpS.aG, bpS.ag);
				global::A.k k2 = null;
				if (bpS.aK != 255 || bpS.ak != 255 || bpS.aL != 255 || bpS.al != 255)
				{
					k2 = new global::A.k(bpS.aK, bpS.ak, bpS.aL, bpS.al, 0);
				}
				BI bI = new BI(j.BQF, j.BQf, bpS, k, k2, j.BQg);
				((Form)bI).ShowDialog((IWin32Window)(object)this);
				((Component)bI).Dispose();
			}
		}

		private void h(object P_0, DoWorkEventArgs P_1)
		{
			Thread.Sleep(1500);
		}

		private void H(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			if (qP != null && global::A.A.c().Count == 1)
			{
				A(qP, global::A.A.c()[0], qp, false, qq, qR);
			}
		}

		internal static bool A(Framework P_0, List<CY> P_1)
		{
			if (P_0 != null && P_1 != null && P_1.Count != 0 && P_1[0].BdF.Count != 0 && P_1[0].BdF[0].BdC.axT > P_0.aXA)
			{
				return true;
			}
			return false;
		}

		private void o()
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			if (!qW)
			{
				((Control)SW).Size = new Size(500, 90);
				SW.BorderStyle = (BorderStyle)1;
				((Control)SX).Font = new Font(((Control)SX).Font.FontFamily, 12f);
				((Control)SX).AutoSize = false;
				((Control)SX).Size = new Size(((Control)SW).Width - 40, 30);
				((Control)SX).Location = new Point(20, 15);
				((Control)SW).Controls.Add((Control)(object)SX);
				((Control)Sw).Size = new Size(((Control)SW).Width - 40, 20);
				((Control)Sw).Location = new Point(20, 50);
				Sw.Minimum = 0;
				Sw.Maximum = 100;
				((Control)SW).Controls.Add((Control)(object)Sw);
				((Control)this).Controls.Add((Control)(object)SW);
				((Control)SW).Visible = false;
			}
		}

		internal static void C(string P_0)
		{
			sF = 0;
			sG = 0;
			if (qW)
			{
				Console.Write(P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GU());
				return;
			}
			Sw.Value = 0;
			((Control)SX).Text = P_0;
			((Control)SW).Visible = true;
			((Control)SW).BringToFront();
		}

		internal static void A(int P_0)
		{
			if (qW)
			{
				if (P_0 != sF)
				{
					if (P_0 != 0 && P_0 % 10 == 0)
					{
						Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq());
						sG++;
					}
					if (P_0 == 100)
					{
						while (sG < 10)
						{
							Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq());
							sG++;
						}
						Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rF());
					}
				}
			}
			else
			{
				Sw.Value = P_0;
			}
			sF = P_0;
		}

		internal static void P()
		{
			if (!qW)
			{
				((Control)SW).Visible = false;
			}
			sF = 0;
			sG = 0;
		}

		internal static void a(object P_0, ProgressChangedEventArgs P_1)
		{
			if (qW)
			{
				if (P_1.ProgressPercentage != sF)
				{
					if (P_1.ProgressPercentage != 0 && P_1.ProgressPercentage % 10 == 0)
					{
						Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq());
						sG++;
					}
					if (P_1.ProgressPercentage == 100)
					{
						while (sG < 10)
						{
							Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq());
							sG++;
						}
						Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rF());
					}
				}
			}
			else
			{
				Sw.Value = P_1.ProgressPercentage;
				if (P_1.UserState is string)
				{
					((Control)SX).Text = P_1.UserState as string;
				}
			}
			sF = P_1.ProgressPercentage;
		}

		private void p()
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected O, but got Unknown
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			if (!qW)
			{
				((Control)sc).Width = 650;
				((Control)sc).Height = 400;
				sc.BorderStyle = (BorderStyle)1;
				((Control)sD).Font = new Font(((Control)sD).Font.FontFamily, 12f, (FontStyle)1);
				((Control)sD).AutoSize = false;
				((Control)sD).Size = new Size(((Control)sc).Width - 40, 30);
				((Control)sD).Location = new Point(20, 15);
				((Control)sc).Controls.Add((Control)(object)sD);
				for (int i = 0; i < 25; i++)
				{
					int num = 50 + 30 * i;
					Label val = new Label();
					((Control)val).Font = new Font(((Control)val).Font.FontFamily, ((Control)sD).Font.Size);
					((Control)val).AutoSize = false;
					((Control)val).Size = new Size(300, 30);
					((Control)val).Location = new Point(20, num);
					((Control)sc).Controls.Add((Control)(object)val);
					sE.Add(val);
					ProgressBar val2 = new ProgressBar();
					val2.Minimum = 0;
					val2.Maximum = 100;
					((Control)val2).Size = new Size(((Control)sc).Width - 40 - 300, 20);
					Size size = ((Control)val2).Size;
					((Control)val2).Location = new Point(320, num + (30 - ((Size)(ref size)).Height) / 2);
					((Control)sc).Controls.Add((Control)(object)val2);
					sd.Add(val2);
				}
				((Control)this).Controls.Add((Control)(object)sc);
				((Control)sc).Visible = false;
			}
		}

		internal static void A(string P_0, List<string> P_1)
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			se = P_1;
			sf = -1;
			sF = 0;
			sG = 0;
			if (qW)
			{
				Console.WriteLine(P_0);
				return;
			}
			((Control)sD).Text = P_0;
			Enumerator<ProgressBar> enumerator = sd.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ProgressBar current = enumerator.Current;
					if (sd.IndexOf(current) < P_1.Count)
					{
						current.Value = 0;
						((Control)current).Visible = true;
					}
					else
					{
						((Control)current).Visible = false;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<Label> enumerator2 = sE.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					Label current2 = enumerator2.Current;
					int num = sE.IndexOf(current2);
					if (num < P_1.Count)
					{
						((Control)current2).Text = P_1[num];
						((Control)current2).Visible = true;
					}
					else
					{
						((Control)current2).Visible = false;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			((Control)sc).Height = 50 + 30 * P_1.Count + 15;
			((Control)sc).Left = ((Control)QQ).Width / 2 - ((Control)sc).Width / 2;
			((Control)sc).Top = ((Control)QQ).Height / 2 - ((Control)sc).Height / 2;
			((Control)sc).Visible = true;
			((Control)sc).BringToFront();
		}

		internal static void Q()
		{
			if (!qW)
			{
				((Control)sc).Visible = false;
			}
			sf = -1;
			sF = 0;
			sG = 0;
		}

		internal static void B(object P_0, ProgressChangedEventArgs P_1)
		{
			if (!(P_1.UserState is int))
			{
				return;
			}
			int num = (int)P_1.UserState;
			if (qW)
			{
				if (num != sf)
				{
					Console.Write(se[num] + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.GU());
					sF = 0;
					sG = 0;
				}
				else if (P_1.ProgressPercentage != sF)
				{
					if (P_1.ProgressPercentage != 0 && P_1.ProgressPercentage % 10 == 0)
					{
						Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq());
						sG++;
					}
					if (P_1.ProgressPercentage == 100)
					{
						while (sG < 10)
						{
							Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq());
							sG++;
						}
						Console.WriteLine(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rF());
					}
				}
			}
			else
			{
				sd[num].Value = P_1.ProgressPercentage;
			}
			sf = num;
			sF = P_1.ProgressPercentage;
		}

		private void aA(object P_0, EventArgs P_1)
		{
			((Control)rq).Visible = !((Control)rq).Visible;
			sI = true;
			((Control)Rh).Visible = false;
			((Control)RI).Visible = false;
			((Control)Rq).Visible = false;
			if (!((Control)rq).Visible)
			{
				sh = (float)rQ.SplitterDistance / (float)((Control)rQ).Width;
				x();
				X();
			}
			else
			{
				s();
			}
			q();
		}

		private void q()
		{
			if (((Control)rq).Visible)
			{
				((ToolStripItem)rp).Image = sg;
			}
			else
			{
				((ToolStripItem)rp).Image = sH;
			}
		}

		internal void aa(object P_0, EventArgs P_1)
		{
			s();
		}

		private Uri R()
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			Uri val = null;
			if (!string.IsNullOrEmpty(si))
			{
				try
				{
					string text = global::A.m.A(Qw, si + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fh(), true);
					if (text != null)
					{
						val = new Uri(text);
					}
				}
				catch
				{
					val = null;
				}
				if (val == (Uri)null)
				{
					try
					{
						val = new Uri(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ER() + si);
					}
					catch
					{
						val = null;
					}
				}
			}
			return val;
		}

		internal void r()
		{
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			sI = !sI;
			Uri val = R();
			if (sj == null)
			{
				sj = new x();
			}
			if (sI)
			{
				((Control)Rh).Visible = false;
				((Control)RI).Visible = false;
				((Control)Rq).Visible = false;
				((Control)rq).Dock = (DockStyle)0;
				((ToolStripItem)rp).Image = sg;
				((Control)sJ).Controls.Remove((Control)(object)sj);
				((Control)sJ).Hide();
				((Control)rq).Controls.Add((Control)(object)sj);
				if (!((Control)rq).Visible)
				{
					((Control)rq).Visible = true;
				}
			}
			else
			{
				if (sJ == null)
				{
					sJ = new BJ();
				}
				((Control)rq).Controls.Remove((Control)(object)sj);
				((Control)rq).Visible = false;
				((Control)rq).Dock = (DockStyle)5;
				((ToolStripItem)rp).Image = sH;
				((Control)sJ).Controls.Add((Control)(object)sj);
				if (!((Control)sJ).Visible)
				{
					BJ bJ = sJ;
					Point location = ((Form)this).Location;
					int num = ((Point)(ref location)).X + (((Control)this).Width - ((Control)sJ).Width) / 2;
					location = ((Form)this).Location;
					((Form)bJ).Location = new Point(num, ((Point)(ref location)).Y + (((Control)this).Height - ((Control)sJ).Height) / 2);
					((Form)sJ).Show((IWin32Window)(object)this);
				}
				((Form)sJ).Activate();
			}
			x();
			X();
			sj.d();
			if (val != (Uri)null)
			{
				sj.A(val);
			}
		}

		internal void S()
		{
			if (sI)
			{
				aA(null, null);
			}
			else if (sJ != null)
			{
				((Control)sJ).Visible = !((Control)sJ).Visible;
				if (((Control)sJ).Visible)
				{
					Uri val = R();
					if (val != (Uri)null)
					{
						sj.A(val);
					}
				}
			}
			else
			{
				s();
			}
		}

		internal void s()
		{
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			Uri val = R();
			if (sj == null)
			{
				sj = new x();
			}
			if (sI)
			{
				((Control)rq).Controls.Add((Control)(object)sj);
				if (!((Control)rq).Visible)
				{
					((Control)rq).Visible = true;
				}
				x();
				X();
			}
			else
			{
				if (sJ == null)
				{
					sJ = new BJ();
				}
				((Control)sJ).Controls.Add((Control)(object)sj);
				if (!((Control)sJ).Visible)
				{
					BJ bJ = sJ;
					Point location = ((Form)this).Location;
					int num = ((Point)(ref location)).X + (((Control)this).Width - ((Control)sJ).Width) / 2;
					location = ((Form)this).Location;
					((Form)bJ).Location = new Point(num, ((Point)(ref location)).Y + (((Control)this).Height - ((Control)sJ).Height) / 2);
					((Form)sJ).Show((IWin32Window)(object)this);
				}
				((Form)sJ).Activate();
			}
			sj.d();
			if (val != (Uri)null)
			{
				sj.A(val);
			}
		}

		internal void T()
		{
			Uri val = R();
			if (val != (Uri)null && sj != null)
			{
				sj.A(val);
			}
		}

		private void t()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					if (sr[j, i] == 0 || sP[j, i] == 0)
					{
						sr[j, i] = 10000;
					}
				}
			}
		}

		private void U()
		{
			int num = 5;
			while (!u())
			{
				V();
				num--;
				if (num == 0)
				{
					break;
				}
			}
		}

		private bool u()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 1; j < 10; j++)
				{
					int num = sr[j - 1, i];
					if (sr[j, i] < num)
					{
						return false;
					}
				}
			}
			for (int k = 0; k < 10; k++)
			{
				for (int l = 1; l < 10; l++)
				{
					int num = sr[k, l - 1];
					if (sr[k, l] > num)
					{
						return false;
					}
				}
			}
			return true;
		}

		private void V()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 1; j < 9; j++)
				{
					int num = sr[j - 1, i];
					int num2 = sr[j, i];
					int num3 = sr[j + 1, i];
					num2 = (num2 * 4 + num + num3) / 6;
					sr[j, i] = num2;
				}
			}
			for (int k = 0; k < 10; k++)
			{
				for (int l = 1; l < 9; l++)
				{
					int num = sr[k, l - 1];
					int num2 = sr[k, l];
					int num3 = sr[k, l + 1];
					num2 = (num2 * 4 + num + num3) / 6;
					sr[k, l] = num2;
				}
			}
		}

		private void v()
		{
			int num = 1000;
			int num2 = sQ[3];
			while (num > 0)
			{
				float num3 = a(num2);
				float num4 = a(num2 + 1);
				float num5 = a(num2 - 1);
				if (num4 < num3)
				{
					num2++;
				}
				else if (num5 < num3)
				{
					num2--;
				}
				else if (num3 <= num5 && num3 <= num4)
				{
					sq = num2;
					break;
				}
				num--;
			}
			for (int i = 0; i < 10; i++)
			{
				sR[i] = (int)Math.Round((double)sq * Math.Sqrt((double)sl[i] / 304.0));
			}
			for (int j = 0; j < 10; j++)
			{
				for (int k = 0; k < 10; k++)
				{
					sr[k, j] = A(k, j, sR[k]);
				}
			}
		}

		private float a(int P_0)
		{
			float num = 0f;
			for (int i = 0; i < 10; i++)
			{
				float num2 = (float)P_0 * (float)Math.Sqrt((double)sl[i] / 304.0) - (float)sQ[i];
				num += num2 * num2;
			}
			return num;
		}

		private void A(string P_0, int P_1)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			string text = null;
			FileStream val = new FileStream(P_0, (FileMode)3);
			StreamReader val2 = new StreamReader((Stream)(object)val);
			A(val2, ref text);
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 52; j++)
				{
					a(val2, ref text);
					a(val2, ref text);
					sM[P_1, i, j] = (int)Math.Round((double)(float.Parse(text) * 1000f));
					a(val2, ref text);
					a(val2, ref text);
					sm[P_1, i, j] = (int)Math.Round((double)(float.Parse(text) * 10f));
					a(val2, ref text);
					sN[P_1, i, j] = (int)Math.Round((double)(float.Parse(text) * 10f));
					A(val2, ref text);
				}
			}
			((TextReader)val2).Close();
			((Stream)val).Close();
			B(P_1);
		}

		private bool A(string P_0, StreamReader P_1, ref string P_2)
		{
			P_2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
			while (true)
			{
				int num = ((TextReader)P_1).Read();
				if (num == -1)
				{
					break;
				}
				char c = (char)num;
				for (int i = 0; i < P_0.Length; i++)
				{
					if (c == P_0[i])
					{
						return true;
					}
				}
				if (c != '\r' && c != '"' && c != ',')
				{
					System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(P_2);
					char c2 = c;
					P_2 = string.Concat(readOnlySpan, new System.ReadOnlySpan<char>(ref c2));
				}
			}
			return false;
		}

		private bool A(StreamReader P_0, ref string P_1)
		{
			return A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy(), P_0, ref P_1);
		}

		private bool a(StreamReader P_0, ref string P_1)
		{
			return A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rf(), P_0, ref P_1);
		}

		private int A(int P_0, int P_1, int P_2)
		{
			sO[P_0, P_1] = 0;
			so[P_0, P_1] = 0;
			int num = 0;
			for (int i = 0; i < 52; i++)
			{
				if (sN[P_0, P_1, i] > num)
				{
					num = sN[P_0, P_1, i];
				}
			}
			int num2 = num * 20 / 100;
			int num3 = 0;
			for (int j = 0; j < 52 && sN[P_0, P_1, j] < num2; j++)
			{
				num3 = j;
			}
			num3++;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			float num7 = 0f;
			int num8 = 0;
			for (int k = num3; k < 52; k++)
			{
				if (sN[P_0, P_1, k] != 0)
				{
					num8++;
					float num9 = (float)sM[P_0, P_1, k] / 1000f;
					float num10 = (float)sN[P_0, P_1, k] / 10f;
					num4 += num9;
					num5 += num10;
					num7 += num9 * num9;
					num6 += num9 * num10;
				}
			}
			if (num8 == 0)
			{
				return 0;
			}
			float num11 = (float)num8 * num7 - num4 * num4;
			if (num8 > 0 && num11 > 0.0001f)
			{
				float num12 = (float)P_2 / 60f;
				float num13 = num4 / (float)num8;
				float num14 = num5 / (float)num8;
				if (sn[P_0, P_1] < 0.1f)
				{
					return 0;
				}
				return (int)Math.Round((double)((num13 - num14 / num12) * 1000f));
			}
			return 0;
		}

		private void B(int P_0)
		{
			int num = 0;
			float num2 = 0f;
			float[] array = new float[10];
			float[] array2 = new float[10];
			for (int i = 0; i < 10; i++)
			{
				sO[P_0, i] = 0;
				so[P_0, i] = 0;
				int num3 = 0;
				for (int j = 0; j < 52; j++)
				{
					if (sN[P_0, i, j] > num3)
					{
						num3 = sN[P_0, i, j];
					}
				}
				int num4 = num3 * 20 / 100;
				int num5 = 0;
				for (int k = 0; k < 52 && sN[P_0, i, k] < num4; k++)
				{
					num5 = k;
				}
				num5++;
				float num6 = 0f;
				float num7 = 0f;
				float num8 = 0f;
				float num9 = 0f;
				int num10 = 0;
				for (int l = num5; l < 52; l++)
				{
					if (sN[P_0, i, l] != 0)
					{
						num10++;
						float num11 = (float)sM[P_0, i, l] / 1000f;
						float num12 = (float)sN[P_0, i, l] / 10f;
						num6 += num11;
						num7 += num12;
						num9 += num11 * num11;
						num8 += num11 * num12;
					}
				}
				if (num10 == 0)
				{
					so[P_0, i] = 0;
					sn[P_0, i] = 0f;
					sO[P_0, i] = 0;
					array[i] = 0f;
					array2[i] = 0f;
					continue;
				}
				float num13 = (float)num10 * num9 - num6 * num6;
				if (num10 > 0 && num13 > 0.0001f)
				{
					float num14 = num6 / (float)num10;
					float num15 = num7 / (float)num10;
					float num16 = (float)num10 * num8 - num6 * num7;
					sn[P_0, i] = num16 / num13;
					sO[P_0, i] = (int)Math.Round((double)(sn[P_0, i] * 60f));
					if (i > 4)
					{
						num++;
						num2 += sn[P_0, i];
					}
					if (sn[P_0, i] < 0.1f)
					{
						so[P_0, i] = 0;
					}
					else
					{
						so[P_0, i] = (int)Math.Round((double)((num14 - num15 / sn[P_0, i]) * 1000f));
					}
					array[i] = num14;
					array2[i] = num15;
				}
				else
				{
					sn[P_0, i] = 0f;
					sO[P_0, i] = 0;
					so[P_0, i] = 0;
					array[i] = 0f;
					array2[i] = 0f;
				}
			}
			if (num > 0)
			{
				num2 /= (float)num;
				sp = num2;
				sQ[P_0] = (int)Math.Round((double)(sp * 60f));
				for (int m = 0; m < 10; m++)
				{
					if (so[P_0, m] > 0 && sp > 0.1f)
					{
						sP[P_0, m] = (int)Math.Round((double)((array[m] - array2[m] / sp) * 1000f));
					}
					else
					{
						sP[P_0, m] = 0;
					}
				}
			}
			else
			{
				sp = 0f;
				for (int n = 0; n < 10; n++)
				{
					sP[P_0, n] = 0;
				}
			}
		}

		private void W()
		{
			Table table = Qz.A(133) as Table;
			Table table2 = Qz.A(134) as Table;
			Table table3 = Qz.A(8641) as Table;
			Table table4 = Qz.A(199) as Table;
			Table table5 = Qz.A(200) as Table;
			Table table6 = Qz.A(8647) as Table;
			Setting setting = Qz.A(387);
			Setting setting2 = Qz.A(421);
			if (table != null && table.ColumnAxis != null && table.RowAxis != null && table2 != null && table2.ColumnAxis != null && table2.RowAxis != null && table4 != null && table4.ColumnAxis != null && table4.RowAxis != null && table5 != null && table5.ColumnAxis != null && table5.RowAxis != null && setting != null && setting2 != null)
			{
				A(table, sr);
				A(table4, sP);
				a(table2, sR);
				a(table5, sQ);
				if (table3 != null)
				{
					A(table3);
				}
				if (table6 != null)
				{
					A(table6);
				}
				return;
			}
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rG());
		}

		private void A(Table P_0, int[,] P_1)
		{
			P_0.ColumnAxis.F().a(1, true);
			P_0.ColumnAxis.f().a(10, true);
			P_0.ColumnAxis.g().a(387, true);
			P_0.RowAxis.F().a(1, true);
			P_0.RowAxis.f().a(10, true);
			P_0.RowAxis.g().a(421, true);
			for (int i = 0; i < 10; i++)
			{
				P_0.ColumnAxis.G().a(i, (7 + i) * 1000, true);
				for (int j = 0; j < 10; j++)
				{
					if (i == 0)
					{
						P_0.RowAxis.G().a(j, sl[j] * 10, true);
					}
					P_0.TableDataSetting.A(i, j, 0, P_1[j, i], true);
				}
			}
		}

		private void a(Table P_0, int[] P_1)
		{
			P_0.ColumnAxis.F().a(1, true);
			P_0.ColumnAxis.f().a(10, true);
			P_0.ColumnAxis.g().a(421, true);
			P_0.RowAxis.F().a(0, true);
			for (int i = 0; i < 10; i++)
			{
				P_0.ColumnAxis.G().a(i, sl[i] * 10, true);
				P_0.TableDataSetting.A(i, 0, 0, P_1[i], true);
			}
		}

		private void A(Table P_0)
		{
			int num = P_0.TableDataSetting.av()[0];
			int num2 = P_0.TableDataSetting.av()[1];
			int num3 = P_0.TableDataSetting.av()[2];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					for (int k = 0; k < num3; k++)
					{
						P_0.TableDataSetting.A(k, j, i, 0, true);
					}
				}
			}
		}

		private void aB(object P_0, EventArgs P_1)
		{
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Invalid comparison between Unknown and I4
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			if (Qz == null)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rg(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			FolderPicker folderPicker = new FolderPicker();
			if (!folderPicker.ShowDialog(System.IntPtr.Zero).GetValueOrDefault() || (int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rH(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rh(), (MessageBoxButtons)4, (MessageBoxIcon)64) == 7)
			{
				return;
			}
			Qz.C(Qz.aWS);
			try
			{
				string[] files = Directory.GetFiles(folderPicker.ResultPath, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iY(), (SearchOption)0);
				Dictionary<int, string> val = new Dictionary<int, string>();
				Dictionary<int, System.DateTime> val2 = new Dictionary<int, System.DateTime>();
				string[] array = files;
				foreach (string text in array)
				{
					System.DateTime creationTime = File.GetCreationTime(text);
					System.DateTime lastWriteTime = File.GetLastWriteTime(text);
					System.DateTime dateTime = ((lastWriteTime > creationTime) ? lastWriteTime : creationTime);
					int num = int.Parse(Path.GetFileName(text).Substring(0, 3));
					if (!val2.ContainsKey(num))
					{
						val2.Add(num, dateTime);
						val.Add(num, text);
					}
					else if (dateTime > val2[num])
					{
						val2[num] = dateTime;
						val[num] = text;
					}
				}
				List<string> val3 = new List<string>();
				Enumerator<int, string> enumerator = val.Values.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						int num2 = int.Parse(Path.GetFileName(current).Substring(0, 3));
						int j;
						for (j = 0; j < 10 && num2 != sl[j]; j++)
						{
						}
						if (j < 10)
						{
							A(current, j);
							val3.Add(current);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				v();
				t();
				U();
				W();
				string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rI();
				Enumerator<string> enumerator2 = val3.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						string current2 = enumerator2.Current;
						text2 = text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy() + current2;
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
				bE.A((IWin32Window)(object)this, text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.g(), (MessageBoxButtons)0);
			}
			catch (System.Exception ex)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ri() + ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			Qz.c(Qz.aWS);
		}

		private void ab(object P_0, EventArgs P_1)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Invalid comparison between Unknown and I4
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Invalid comparison between Unknown and I4
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			if (Qz == null || !Qz.C() || (int)A((IWin32Window)(object)this, true) == 2)
			{
				return;
			}
			((FileDialog)TF).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NG();
			((FileDialog)TF).Filter = bx.a();
			if ((int)((CommonDialog)TF).ShowDialog((IWin32Window)(object)this) == 1)
			{
				bW bW = Cq.a(((FileDialog)TF).FileName);
				if (bW != null)
				{
					A(null, ((FileDialog)TF).FileName, bW, false);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NI(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
		}

		private void A(string P_0, string P_1, bW P_2, bool P_3)
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			j j = default(j);
			j.BQi = Qz;
			j.BQJ = P_1;
			j.BQH = P_0;
			j.BQj = P_3;
			j.BQh = P_2;
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.DoWork += new DoWorkEventHandler(I);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(h);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rJ());
			val.RunWorkerAsync((object)j);
		}

		private void I(object P_0, DoWorkEventArgs P_1)
		{
			global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rj(), true);
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			j j = (j)P_1.Argument;
			string text = j.BQH;
			if (text == null && j.BQh != null)
			{
				text = bT.A(j.BQh.axS, j.BQh.axs, j.BQh.axT, j.BQh.axt, true);
			}
			val.ReportProgress(20);
			if (!string.IsNullOrEmpty(text) && j.BQh != null)
			{
				Framework framework = (j.BQI = new Framework(text, j.BQh.axS, j.BQh.axs, j.BQh.axT));
				j.BQK = framework.a();
				if (j.BQK == bV.A.Brc)
				{
					val.ReportProgress(60);
					string text2;
					bool flag = new Cq(j.BQJ, framework).A(out text2, false, true, false) && string.IsNullOrEmpty(text2);
					val.ReportProgress(70);
					framework.N();
					framework.a(framework.awj);
					framework.a((HashSet<DataIdAndAttrId>)null);
					val.ReportProgress(90);
					if (flag)
					{
						j.BQL = true;
					}
					else
					{
						j.BQk = text2;
						j.BQL = false;
					}
				}
				else
				{
					j.BQL = false;
				}
			}
			else
			{
				j.BQK = bV.A.BrD;
				j.BQL = false;
			}
			P_1.Result = j;
			Thread.Sleep(100);
			val.ReportProgress(100);
		}

		private void h(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Invalid comparison between Unknown and I4
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Invalid comparison between Unknown and I4
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Invalid comparison between Unknown and I4
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Invalid comparison between Unknown and I4
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_032f: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0351: Invalid comparison between Unknown and I4
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e6: Invalid comparison between Unknown and I4
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03eb: Invalid comparison between Unknown and I4
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Invalid comparison between Unknown and I4
			j j = (j)P_1.Result;
			global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rK() + j.BQL + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), true);
			P();
			bool flag = true;
			if (!j.BQL)
			{
				flag = false;
				if (j.BQK == bV.A.BrD)
				{
					BackgroundWorker val = new BackgroundWorker();
					object obj = BM.t.BqL;
					if (obj == null)
					{
						DoWorkEventHandler val2 = global::b.bj.D;
						BM.t.BqL = val2;
						obj = (object)val2;
					}
					val.DoWork += (DoWorkEventHandler)obj;
					val.WorkerReportsProgress = true;
					object obj2 = BM.t.Bqk;
					if (obj2 == null)
					{
						ProgressChangedEventHandler val3 = a;
						BM.t.Bqk = val3;
						obj2 = (object)val3;
					}
					val.ProgressChanged += (ProgressChangedEventHandler)obj2;
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ns());
					BackgroundWorker val4 = new BackgroundWorker();
					val4.DoWork += new DoWorkEventHandler(i);
					val4.RunWorkerCompleted += new RunWorkerCompletedEventHandler(I);
					val.RunWorkerAsync();
					val4.RunWorkerAsync((object)j);
					global::b.bj.abM = true;
				}
				else
				{
					string empty = string.Empty;
					if (j.BQK == bV.A.Brd)
					{
						empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NT();
					}
					else if (j.BQK == bV.A.BrE)
					{
						empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nt();
					}
					else
					{
						string text = bx.C(j.BQh.axS, j.BQh.axs);
						text = ((text != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
						empty = ((j.BQK == bV.A.Bre) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NV() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)j.BQh.axT).ToString()) : ((!string.IsNullOrEmpty(j.BQk)) ? j.BQk : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NW() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)j.BQh.axT).ToString())));
					}
					if (true)
					{
						if ((int)bE.A((IWin32Window)(object)this, empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
						{
							while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1)
							{
								if (A(((FileDialog)qE).FileName, j))
								{
									return;
								}
							}
						}
					}
					else if ((int)bE.A((IWin32Window)(object)this, j.BQk + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NX(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48, (MessageBoxDefaultButton)256, new string[2]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nx(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NY()
					}) == 6)
					{
						while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1)
						{
							if (A(((FileDialog)qE).FileName, j))
							{
								return;
							}
						}
					}
					else
					{
						flag = true;
					}
				}
			}
			if (!flag)
			{
				return;
			}
			w();
			d();
			if (j.BQI.B() && j.BQI.b() && (!j.BQi.B() || !j.BQi.b() || !j.BQI.A(j.BQi)) && (int)j.BQI.A(true, false) == 2)
			{
				a(false);
				return;
			}
			lock (qh)
			{
				qI |= 64;
			}
			Bj bj = new Bj(j.BQJ, false, j.BQj, j.BQI, j.BQi);
			DialogResult val5 = ((Form)bj).ShowDialog((IWin32Window)(object)this);
			bool flag2 = bj.b();
			string text2 = bj.C();
			string text3 = bj.c();
			((Component)bj).Dispose();
			if ((int)val5 == 3)
			{
				lock (qh)
				{
					qI &= -65;
					return;
				}
			}
			if (Qz.awZ == 21 && Qz.f())
			{
				cb.A(Qz, null);
				cb.a();
				if (Qz.awP.h())
				{
					cb.B();
				}
			}
			Qz.A((IWin32Window)(object)QQ);
			a(false);
			E();
			if ((int)val5 == 1 || (int)val5 == 6)
			{
				if (flag2)
				{
					A(text2, text3, Qz);
				}
				if (A(Qz.aXc, true))
				{
					A(null, -1, false);
					return;
				}
				lock (qh)
				{
					qI &= -65;
				}
				Qz.p();
			}
			else
			{
				lock (qh)
				{
					qI &= -65;
				}
				if (j.BQj)
				{
					QM = BM.a.BpC;
				}
			}
		}

		private void i(object P_0, DoWorkEventArgs P_1)
		{
			j bQl = (j)P_1.Argument;
			string text = CZ.A(bQl.BQh, 65535);
			int? num;
			UpdateOutcomes updateOutcomes;
			string[] bQm = bj.A(bQl.BQh.axT, bQl.BQh.axS, bQl.BQh.axs, text, out num, out updateOutcomes);
			K k = default(K);
			k.BQl = bQl;
			if (num.HasValue && updateOutcomes == UpdateOutcomes.CompleteUpdate)
			{
				k.BQM = updateOutcomes;
				k.BQm = bQm;
			}
			P_1.Result = k;
		}

		private void I(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Invalid comparison between Unknown and I4
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Invalid comparison between Unknown and I4
			K k = (K)P_1.Result;
			P();
			if (k.BQm != null && k.BQm.Length != 0)
			{
				string[] bQm = k.BQm;
				foreach (string text in bQm)
				{
					List<string> val;
					if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()))
					{
						val = new List<string>();
						val.Add(text);
					}
					else
					{
						val = bT.b(text);
					}
					if (val.Count != 0 && A(text, k.BQl))
					{
						return;
					}
				}
			}
			string text2 = bx.C(k.BQl.BQh.axS, k.BQl.BQh.axs);
			text2 = ((text2 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NZ() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)k.BQl.BQh.axT).ToString();
			if ((int)bE.A((IWin32Window)(object)this, text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !A(((FileDialog)qE).FileName, k.BQl))
				{
				}
			}
		}

		private bool A(string P_0, j P_1)
		{
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (P_1.BQh == null)
				{
					return false;
				}
				string text = null;
				bool flag3;
				bool flag;
				bool flag2;
				global::A.k k;
				if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nz()))
				{
					flag3 = CZ.A(P_0, P_1.BQh, out flag, out flag2, out k, out text);
				}
				else
				{
					text = P_0;
					flag3 = bT.A(P_0, P_1.BQh, out flag, out flag2, out k);
				}
				if (flag3 && text != null)
				{
					A(text, P_1.BQJ, P_1.BQh, P_1.BQj);
					return true;
				}
				if (k == null || text == null)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (!flag)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rk(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (!flag2)
				{
					bE.A((IWin32Window)(object)this, string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nB(),
						((object)k).ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rL(),
						((object)P_1.BQh.axT).ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
					}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			catch (System.Exception ex)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rl() + ex.Message, true);
			}
			return false;
		}

		internal void w()
		{
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Invalid comparison between Unknown and I4
			if (!qW)
			{
				if (!Directory.Exists(QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
				{
					Directory.CreateDirectory(QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
				}
				((Stream)File.Create(QS)).Close();
				List<string> val = new List<string>();
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nH() + ((int)su == 2));
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nh() + ss);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nI() + sT);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ni() + st);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nJ() + sU);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nj() + ((Control)Rh).Visible);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nK() + ((Control)RI).Visible);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nk() + ((Control)Rq).Visible);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nL() + ((Control)rq).Visible);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nl() + sh);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nM() + sS);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nm() + ((Control)rL).Visible);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nN() + ((Control)rL).Width);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nn() + ((Control)rL.B()).Height);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nO() + (byte)rL.A().A());
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.no() + ((Control)rL.A()).Font.Size);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nP() + !rL.C());
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.np() + DC.Bvd);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nQ() + (byte)DC.BvF);
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nq() + (byte)DC.Bve);
				string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nR();
				int bvE = (int)DC.BvE;
				val.Add(text + bvE);
				File.AppendAllLines(QS, (System.Collections.Generic.IEnumerable<string>)val);
			}
		}

		internal static void X()
		{
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			((Control)QQ.rL).Top = ((Control)QQ.RG).Bottom + 2;
			((Control)QQ.rL).Left = 1;
			((Control)QQ.Rh).Height = ((Control)QQ.rL).Height;
			aF obj = QQ.rq;
			aF obj2 = QQ.RI;
			int num = (((Control)QQ.Rq).Height = ((Control)QQ.Rh).Height);
			int height2 = (((Control)obj2).Height = num);
			((Control)obj).Height = height2;
			if (sv)
			{
				((Control)QQ.rL).Height = ((Control)QQ).Height - 2 - ((Control)QQ.rL).Top;
			}
			else
			{
				ac obj3 = QQ.rL;
				Size clientSize = ((Form)QQ).ClientSize;
				((Control)obj3).Height = ((Size)(ref clientSize)).Height - 2 - ((Control)QQ.rL).Top;
			}
			((Control)QQ.rQ).SuspendLayout();
			((Control)QQ.rQ).Height = ((Control)QQ.rL).Height;
			((Control)QQ.rQ).ResumeLayout(true);
			((Control)QQ.rw).SuspendLayout();
			((Control)QQ.rw).Height = ((Control)QQ.rL).Height;
			((Control)QQ.rw).ResumeLayout(true);
			if (((Control)QQ.rL).Visible)
			{
				((Control)QQ.rl).Left = ((Control)QQ.rL).Right + 1;
				if (((Control)QQ.Rh).Visible || ((Control)QQ.RI).Visible || ((Control)QQ.Rq).Visible || ((Control)QQ.rq).Visible)
				{
					((Control)QQ.rl).Width = ((Control)QQ.rQ.Panel2).Left - ((Control)QQ.rL).Right - QQ.rQ.SplitterWidth - 5;
				}
				else
				{
					((Control)QQ.rl).Width = ((Control)QQ.rQ).Right - ((Control)QQ.rL).Right - QQ.rQ.SplitterWidth - 5;
				}
			}
			else
			{
				((Control)QQ.rl).Left = ((Control)QQ.rL).Left;
				if (((Control)QQ.Rh).Visible || ((Control)QQ.RI).Visible || ((Control)QQ.Rq).Visible || ((Control)QQ.rq).Visible)
				{
					((Control)QQ.rl).Width = ((Control)QQ.rQ.Panel2).Left - ((Control)QQ.rL).Left - QQ.rQ.SplitterWidth - 5;
				}
				else
				{
					((Control)QQ.rl).Width = ((Control)QQ.rQ.Panel2).Right - ((Control)QQ.rL).Left - QQ.rQ.SplitterWidth - 5;
				}
			}
			if (((Control)QQ.rn).Visible)
			{
				((Control)QQ.rn).Top = ((Control)QQ.rw).Top;
				((Control)QQ.rn).Left = ((Control)QQ.rl).Left;
				((Control)QQ.rn).Width = ((Control)QQ.rl).Width;
				((Control)QQ.rn).Height = QQ.rw.Panel2.Height;
				((Control)QQ.rl).Height = QQ.rw.Panel1.Height;
			}
			else
			{
				((Control)QQ.rl).Height = ((Control)QQ.rL).Height;
			}
			if (((Control)QQ.rl).Width - 10 < 800)
			{
				((Control)QQ.Rj).Width = ((Control)QQ.rl).Width - 10;
				((Control)QQ.Rj).Height = 151 * (((Control)QQ.rl).Width - 10) / 800;
			}
			else
			{
				((Control)QQ.Rj).Width = 800;
				((Control)QQ.Rj).Height = 151;
			}
			if (((Control)QQ.rq).Visible)
			{
				((Control)QQ.rq).Width = QQ.rQ.Panel2.Width;
			}
			int num3 = ((Control)QQ.rl).Left + ((Control)QQ.rl).Width / 2;
			((Control)QQ.Rj).Left = num3 - ((Control)QQ.Rj).Width / 2;
			((Control)QQ.SB).Left = num3 - ((Control)QQ.SB).Width / 2;
			((Control)QQ.Rj).Top = ((Control)QQ.rl).Height / 2 - (((Control)QQ.Rj).Height + 80 + ((Control)QQ.SB).Height) / 2;
			((Control)QQ.SB).Top = ((Control)QQ.Rj).Top + ((Control)QQ.Rj).Height + 80;
			if (((Control)QQ.Rj).Visible)
			{
				((Control)QQ.Rj).BringToFront();
			}
			if (((Control)QQ.SB).Visible)
			{
				((Control)QQ.SB).BringToFront();
			}
			((Control)QQ.rI).Left = ((Control)QQ.rl).Left + 33;
			((Control)QQ.rI).Top = ((Control)QQ.rl).Top + 60;
			((Control)SW).Left = num3 - ((Control)SW).Width / 2;
			((Control)SW).Top = ((Control)QQ).Height / 2 - ((Control)SW).Height / 2;
			((Control)sc).Left = num3 - ((Control)sc).Width / 2;
			((Control)sc).Top = ((Control)QQ).Height / 2 - ((Control)sc).Height / 2;
		}

		private void aC(object P_0, EventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				Size clientSize = ((Form)this).ClientSize;
				if (((Size)(ref clientSize)).Width == 0)
				{
					clientSize = ((Form)this).ClientSize;
					if (((Size)(ref clientSize)).Height == 0)
					{
						return;
					}
				}
				x();
				Y();
				X();
				X(null, null);
			}
			catch
			{
			}
		}

		private void x()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			Size clientSize = ((Form)this).ClientSize;
			if (((Size)(ref clientSize)).Width == 0)
			{
				clientSize = ((Form)this).ClientSize;
				if (((Size)(ref clientSize)).Height == 0)
				{
					return;
				}
			}
			sV = true;
			rQ.SplitterWidth = 2;
			if (((Control)rq).Visible)
			{
				rQ.IsSplitterFixed = false;
				((Control)rQ).SuspendLayout();
				rQ.SplitterDistance = (int)((float)((Control)rQ).Width * sh);
				((Control)rQ).ResumeLayout(true);
			}
			else if (!((Control)rq).Visible && !((Control)Rh).Visible && !((Control)RI).Visible && !((Control)Rq).Visible)
			{
				rQ.SplitterWidth = 1;
				rQ.Panel2MinSize = 0;
				rQ.IsSplitterFixed = true;
				((Control)rQ).SuspendLayout();
				SplitContainer obj = rQ;
				clientSize = ((Form)this).ClientSize;
				obj.SplitterDistance = ((Size)(ref clientSize)).Width;
				((Control)rQ).ResumeLayout(true);
			}
			else
			{
				rQ.IsSplitterFixed = true;
				((Control)rQ).SuspendLayout();
				SplitContainer obj2 = rQ;
				clientSize = ((Form)this).ClientSize;
				obj2.SplitterDistance = ((Size)(ref clientSize)).Width - 258;
				((Control)rQ).ResumeLayout(true);
			}
			sV = false;
		}

		private void Y()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			Size clientSize = ((Form)this).ClientSize;
			if (((Size)(ref clientSize)).Width == 0)
			{
				clientSize = ((Form)this).ClientSize;
				if (((Size)(ref clientSize)).Height == 0)
				{
					return;
				}
			}
			sV = true;
			rw.SplitterWidth = 2;
			if (((Control)rn).Visible)
			{
				rw.IsSplitterFixed = false;
				rw.Panel2MinSize = ((Control)rn.gS).Height + 5;
				((Control)rw).SuspendLayout();
				rw.SplitterDistance = (int)((float)((Control)rw).Height * sS);
				((Control)rw).ResumeLayout(true);
			}
			else
			{
				rw.IsSplitterFixed = true;
				rw.Panel2MinSize = 0;
				((Control)rw).SuspendLayout();
				SplitContainer obj = rw;
				clientSize = ((Form)this).ClientSize;
				obj.SplitterDistance = ((Size)(ref clientSize)).Height;
				((Control)rw).ResumeLayout(true);
			}
			sV = false;
		}

		private void A(object P_0, SplitterEventArgs P_1)
		{
			if (!sV)
			{
				X();
			}
		}

		private void A(object P_0, MouseEventArgs P_1)
		{
			if (((Control)rq).Visible && sI)
			{
				sh = (float)((Control)rQ.Panel1).Right / (float)((Control)rQ).Width;
			}
		}

		private void a(object P_0, SplitterEventArgs P_1)
		{
			if (!sV)
			{
				X();
			}
		}

		private void a(object P_0, MouseEventArgs P_1)
		{
			if (((Control)rn).Visible)
			{
				sS = (float)((Control)rw.Panel1).Bottom / (float)((Control)rw).Height;
			}
		}

		internal void y()
		{
			int selectedIndex = ((TabControl)rl).SelectedIndex;
			QQ.w();
			d();
			((Control)this).SuspendLayout();
			if (!sv)
			{
				sv = true;
				((Form)this).WindowState = (FormWindowState)0;
				((Form)this).FormBorderStyle = (FormBorderStyle)0;
			}
			else
			{
				sv = false;
				((Form)this).FormBorderStyle = (FormBorderStyle)4;
			}
			((Form)this).WindowState = (FormWindowState)2;
			((Control)this).ResumeLayout();
			aC(null, null);
			a(false);
			if (Qz != null && selectedIndex != -1)
			{
				((TabControl)rl).SelectedIndex = selectedIndex;
			}
		}

		private void B(global::A.F P_0)
		{
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected O, but got Unknown
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Expected O, but got Unknown
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected O, but got Unknown
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Expected O, but got Unknown
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Expected O, but got Unknown
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected O, but got Unknown
			if (!CZ.A(P_0, true))
			{
				if (Qz != null)
				{
					w();
				}
				d();
				int num = P_0.aH;
				int num2 = P_0.ah;
				byte[] aO = P_0.aO;
				global::A.k k = new global::A.k(P_0.ae, P_0.aF, P_0.af, P_0.aG, P_0.ag);
				if (!qW && a(k))
				{
					return;
				}
				string text = bT.A(num, num2, k, aO, true);
				if (!string.IsNullOrEmpty(text))
				{
					Qz = new Framework(text, num, num2, k);
					Qz.aXc = P_0.ao;
					BackgroundWorker val = new BackgroundWorker
					{
						WorkerReportsProgress = true
					};
					object obj = BM.t.Bqk;
					if (obj == null)
					{
						ProgressChangedEventHandler val2 = a;
						BM.t.Bqk = val2;
						obj = (object)val2;
					}
					val.ProgressChanged += (ProgressChangedEventHandler)obj;
					val.DoWork += new DoWorkEventHandler(J);
					val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(J);
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qL());
					val.RunWorkerAsync((object)P_0);
					return;
				}
				if (P_0.@as[3].BF != 0)
				{
					lock (qh)
					{
						qI |= 128;
					}
					BackgroundWorker val3 = new BackgroundWorker
					{
						WorkerReportsProgress = true
					};
					object obj2 = BM.t.Bqk;
					if (obj2 == null)
					{
						ProgressChangedEventHandler val4 = a;
						BM.t.Bqk = val4;
						obj2 = (object)val4;
					}
					val3.ProgressChanged += (ProgressChangedEventHandler)obj2;
					val3.DoWork += new DoWorkEventHandler(R);
					val3.RunWorkerCompleted += new RunWorkerCompletedEventHandler(r);
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ql());
					val3.RunWorkerAsync((object)P_0);
					return;
				}
				BackgroundWorker val5 = new BackgroundWorker();
				object obj3 = BM.t.BqL;
				if (obj3 == null)
				{
					DoWorkEventHandler val6 = bj.D;
					BM.t.BqL = val6;
					obj3 = (object)val6;
				}
				val5.DoWork += (DoWorkEventHandler)obj3;
				val5.WorkerReportsProgress = true;
				object obj4 = BM.t.Bqk;
				if (obj4 == null)
				{
					ProgressChangedEventHandler val7 = a;
					BM.t.Bqk = val7;
					obj4 = (object)val7;
				}
				val5.ProgressChanged += (ProgressChangedEventHandler)obj4;
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ns());
				BackgroundWorker val8 = new BackgroundWorker();
				val8.DoWork += new DoWorkEventHandler(e);
				val8.RunWorkerCompleted += new RunWorkerCompletedEventHandler(i);
				val5.RunWorkerAsync();
				val8.RunWorkerAsync((object)P_0);
				bj.abM = true;
				return;
			}
			lock (qh)
			{
				qI &= -3;
			}
		}

		private bool a(global::A.k P_0)
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Invalid comparison between Unknown and I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			if (!P_0.d() && !bg.a())
			{
				bool flag = false;
				if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rM() + P_0.D() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ko(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kP(), (MessageBoxButtons)1, (MessageBoxIcon)48) == 1)
				{
					bg bg = new bg();
					((Form)bg).ShowDialog((IWin32Window)(object)this);
					((Component)bg).Dispose();
					if (bg.a())
					{
						flag = true;
					}
				}
				if (!flag)
				{
					b(true);
					return true;
				}
			}
			return false;
		}

		private void i(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Invalid comparison between Unknown and I4
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Invalid comparison between Unknown and I4
			L l = (L)P_1.Result;
			global::A.F bQP = l.BQP;
			P();
			if (l.BQQ != null && l.BQQ.Length != 0)
			{
				string[] bQQ = l.BQQ;
				foreach (string text in bQQ)
				{
					List<string> val;
					if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()))
					{
						val = new List<string>();
						val.Add(text);
					}
					else
					{
						val = bT.b(text);
					}
					if (val.Count != 0 && B(text, bQP))
					{
						return;
					}
				}
			}
			string text2 = bx.C(bQP.aH, bQP.ah);
			text2 = ((text2 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
			global::A.k k = new global::A.k(bQP.ae, bQP.aF, bQP.af, bQP.aG, bQP.ag);
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qO() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)k).ToString();
			if (!qW && (int)bE.A((IWin32Window)(object)this, text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !B(((FileDialog)qE).FileName, bQP))
				{
				}
			}
		}

		private bool B(string P_0, global::A.F P_1)
		{
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected O, but got Unknown
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				global::A.k k = new global::A.k(P_1.ae, P_1.aF, P_1.af, P_1.aG, P_1.ag);
				int num = P_1.aH;
				int num2 = P_1.ah;
				byte[] aO = P_1.aO;
				bW bW = new bW
				{
					axS = num,
					axs = num2,
					axT = k,
					axt = aO
				};
				string text = null;
				bool flag3;
				bool flag;
				bool flag2;
				global::A.k k2;
				if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nz()))
				{
					flag3 = CZ.A(P_0, bW, out flag, out flag2, out k2, out text);
				}
				else
				{
					text = P_0;
					flag3 = bT.A(P_0, bW, out flag, out flag2, out k2);
				}
				if (flag3 && text != null)
				{
					Qz = new Framework(text, num, num2, k);
					Qz.aXc = P_1.ao;
					BackgroundWorker val = new BackgroundWorker
					{
						WorkerReportsProgress = true
					};
					object obj = BM.t.Bqk;
					if (obj == null)
					{
						ProgressChangedEventHandler val2 = a;
						BM.t.Bqk = val2;
						obj = (object)val2;
					}
					val.ProgressChanged += (ProgressChangedEventHandler)obj;
					val.DoWork += new DoWorkEventHandler(J);
					val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(J);
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qL());
					val.RunWorkerAsync((object)P_1);
					return true;
				}
				if (!qW)
				{
					if (k2 == null || text == null)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else if (!flag)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qo(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else if (!flag2)
					{
						bE.A((IWin32Window)(object)this, string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nB(),
							((object)k2).ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qP(),
							((object)k).ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
						}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
			}
			catch (System.Exception ex)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rm() + ex.Message, true);
			}
			return false;
		}

		private void J(object P_0, DoWorkEventArgs P_1)
		{
			object obj = ((P_0 is BackgroundWorker) ? P_0 : null);
			((BackgroundWorker)obj).ReportProgress(0);
			Thread.Sleep(100);
			((BackgroundWorker)obj).ReportProgress(30);
			bV.A a = Qz.a();
			((BackgroundWorker)obj).ReportProgress(80);
			if (a == bV.A.Brc && Qz.awZ == 21)
			{
				Qz.f();
			}
			((BackgroundWorker)obj).ReportProgress(90);
			Thread.Sleep(100);
			((BackgroundWorker)obj).ReportProgress(100);
			P_1.Result = new l
			{
				BQq = (P_1.Argument as global::A.F),
				BQR = a
			};
		}

		private void J(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Invalid comparison between Unknown and I4
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Invalid comparison between Unknown and I4
			P();
			l obj = P_1.Result as l;
			bV.A bQR = obj.BQR;
			global::A.F bQq = obj.BQq;
			if (bQR == bV.A.Brc)
			{
				A((BackgroundWorker)null, -1);
				return;
			}
			string empty = string.Empty;
			switch (bQR)
			{
			case bV.A.BrD:
			{
				BackgroundWorker val = new BackgroundWorker();
				object obj2 = BM.t.BqL;
				if (obj2 == null)
				{
					DoWorkEventHandler val2 = bj.D;
					BM.t.BqL = val2;
					obj2 = (object)val2;
				}
				val.DoWork += (DoWorkEventHandler)obj2;
				val.WorkerReportsProgress = true;
				object obj3 = BM.t.Bqk;
				if (obj3 == null)
				{
					ProgressChangedEventHandler val3 = a;
					BM.t.Bqk = val3;
					obj3 = (object)val3;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj3;
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ns());
				BackgroundWorker val4 = new BackgroundWorker();
				val4.DoWork += new DoWorkEventHandler(f);
				val4.RunWorkerCompleted += new RunWorkerCompletedEventHandler(j);
				G g = new G
				{
					BpW = bQq,
					Bpv = Qz
				};
				val.RunWorkerAsync();
				val4.RunWorkerAsync((object)g);
				bj.abM = true;
				return;
			}
			case bV.A.Brd:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NT();
				break;
			case bV.A.BrE:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nt();
				break;
			case bV.A.Bre:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qQ() + ((object)Qz.aXA).ToString();
				break;
			default:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qq() + ((object)Qz.aXA).ToString();
				break;
			}
			if (!qW && (int)bE.A((IWin32Window)(object)this, empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !b(((FileDialog)qE).FileName, bQq))
				{
				}
			}
		}

		private void j(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Invalid comparison between Unknown and I4
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Invalid comparison between Unknown and I4
			k k = (k)P_1.Result;
			P();
			if (k.BQo != null && k.BQo.Length != 0)
			{
				string[] bQo = k.BQo;
				foreach (string text in bQo)
				{
					List<string> val;
					if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()))
					{
						val = new List<string>();
						val.Add(text);
					}
					else
					{
						val = bT.b(text);
					}
					if (val.Count != 0 && b(text, k.BQN))
					{
						return;
					}
				}
			}
			if (qW)
			{
				return;
			}
			string text2 = bx.C(k.BQn.awZ, k.BQn.awz);
			text2 = ((text2 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NZ() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)k.BQn.aXA).ToString();
			if ((int)bE.A((IWin32Window)(object)this, text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !b(((FileDialog)qE).FileName, k.BQN))
				{
				}
			}
		}

		private bool b(string P_0, global::A.F P_1)
		{
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected O, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected O, but got Unknown
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				bW bW = new bW
				{
					axS = Qz.awZ,
					axs = Qz.awz,
					axT = Qz.aXA,
					axt = P_1.aO
				};
				string text = null;
				bool flag3;
				bool flag;
				bool flag2;
				global::A.k k;
				if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nz()))
				{
					flag3 = CZ.A(P_0, bW, out flag, out flag2, out k, out text);
				}
				else
				{
					text = P_0;
					flag3 = bT.A(P_0, bW, out flag, out flag2, out k);
				}
				if (flag3 && text != null)
				{
					Qz = new Framework(text, Qz.awZ, Qz.awz, k);
					Qz.aXc = P_1.ao;
					BackgroundWorker val = new BackgroundWorker
					{
						WorkerReportsProgress = true
					};
					object obj = BM.t.Bqk;
					if (obj == null)
					{
						ProgressChangedEventHandler val2 = a;
						BM.t.Bqk = val2;
						obj = (object)val2;
					}
					val.ProgressChanged += (ProgressChangedEventHandler)obj;
					val.DoWork += new DoWorkEventHandler(J);
					val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(J);
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qL());
					val.RunWorkerAsync((object)P_1);
					return true;
				}
				if (!qW)
				{
					if (k == null || text == null)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else if (!flag)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qo(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else if (!flag2)
					{
						bE.A((IWin32Window)(object)this, string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nB(),
							((object)k).ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qP(),
							((object)Qz.aXA).ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
						}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
			}
			catch (System.Exception ex)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rN() + ex.Message, true);
			}
			return false;
		}

		internal static void b(int P_0)
		{
			A(new DataIdAndAttrId(P_0));
		}

		internal static void A(DataIdAndAttrId P_0)
		{
			if (Qz == null)
			{
				return;
			}
			Setting setting = Qz.A(P_0);
			if (setting != null)
			{
				bool flag = false;
				if (((SettingOrSpecialObject)setting).D() != null && !setting.b())
				{
					if (((SettingOrSpecialObject)setting).D() is TableAxis)
					{
						flag = true;
					}
					else if (((SettingOrSpecialObject)setting).D() is Table)
					{
						flag = true;
						if ((((SettingOrSpecialObject)setting).D() as Table).ColumnAxis != null && ((((SettingOrSpecialObject)setting).D() as Table).ColumnAxis.C() || (((SettingOrSpecialObject)setting).D() as Table).ColumnAxis.c()))
						{
							flag = false;
							qF = P_0;
						}
						else if ((((SettingOrSpecialObject)setting).D() as Table).RowAxis != null && ((((SettingOrSpecialObject)setting).D() as Table).RowAxis.C() || (((SettingOrSpecialObject)setting).D() as Table).RowAxis.c()))
						{
							flag = false;
							qF = P_0;
						}
					}
				}
				bool flag2 = !setting.b() && ((SettingOrSpecialObject)setting).D() is SensorCalibration && setting != (((SettingOrSpecialObject)setting).D() as SensorCalibration).CalibrationValueCountSetting;
				if (!flag && !flag2 && !sY.Contains(P_0))
				{
					sY.Add(P_0);
				}
			}
			if (Qn != null)
			{
				sy.Add(P_0);
			}
			else if (sy.Count != 0)
			{
				sy.Clear();
			}
			sZ.Add(P_0);
		}

		internal static void Z()
		{
			sx = true;
		}

		internal static bool z()
		{
			if (sY.Count == 0)
			{
				return sx;
			}
			return true;
		}

		private void aA()
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			if (!qW)
			{
				sz.Interval = 40.0;
				sz.SynchronizingObject = (ISynchronizeInvoke)(object)this;
				sz.Elapsed += new ElapsedEventHandler(b);
				sz.AutoReset = true;
				sz.Enabled = true;
				sz.Start();
			}
		}

		private void b(object P_0, ElapsedEventArgs P_1)
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Invalid comparison between Unknown and I4
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Expected O, but got Unknown
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)this).InvokeRequired)
			{
				try
				{
					M m = b;
					((Control)this).Invoke((System.Delegate)m, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if ((int)((Form)this).WindowState != 1)
			{
				Size clientSize = ((Form)this).ClientSize;
				ss = ((Size)(ref clientSize)).Width;
				clientSize = ((Form)this).ClientSize;
				sT = ((Size)(ref clientSize)).Height;
				Point location = ((Form)this).Location;
				st = ((Point)(ref location)).X;
				location = ((Form)this).Location;
				sU = ((Point)(ref location)).Y;
				su = ((Form)this).WindowState;
			}
			bool flag = false;
			if (rL.b())
			{
				return;
			}
			try
			{
				Monitor.TryEnter(Ta, ref flag);
				if (!flag)
				{
					return;
				}
				sz.Stop();
				sz.Enabled = false;
				if (!TA.IsRunning)
				{
					TA.Start();
				}
				else
				{
					int num = (int)TA.ElapsedMilliseconds;
					if (num != 0)
					{
						int num2 = 1000 / num;
						if ((qI & 0x200) == 0)
						{
							global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rn(), (object)num2), false);
						}
						TA.Restart();
					}
				}
				if (Qz != null && Qz.c() && (((uint)qI & (true ? 1u : 0u)) != 0 || ((uint)qI & 0x1000u) != 0))
				{
					for (int i = 0; i < Qz.aWt.Count; i++)
					{
						Qz.aWt[i].BA();
					}
					if ((qI & 0x1000) == 0)
					{
						Qz.O();
					}
				}
				ab();
				ac();
				aD();
				ad();
				aB();
				am();
				rf.C();
				re.b();
				rF.b();
				rO.d();
				rl.J();
				Stopwatch val = new Stopwatch();
				val.Start();
				((Control)this).Update();
				val.Stop();
				if ((qI & 0x200) == 0)
				{
					global::A.N.A(string.Format(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rO(), (object)val.ElapsedMilliseconds), false);
				}
				if ((Control.ModifierKeys & 0x40000) == 0 && sW)
				{
					if (((Control)rL).Visible)
					{
						((Control)rL).Visible = false;
						X();
					}
					sW = false;
				}
				else if (To)
				{
					c(false);
					To = false;
				}
				else if (sX)
				{
					a(false);
					sX = false;
				}
				else
				{
					if (Qz == null)
					{
						return;
					}
					if (Qn == null && sy.Count != 0)
					{
						sy.Clear();
					}
					if (rL.A().a().Count != 0 && St)
					{
						O();
						St = false;
						return;
					}
					if (z() || sy.Count != 0 || sZ.Count != 0)
					{
						aa();
						return;
					}
					if (rL.A().a().Count != 0)
					{
						if (Sl)
						{
							M();
							Sl = false;
							return;
						}
						if (sw)
						{
							if (Qz.awh != null && Qz.awh.f() != null)
							{
								Qz.awh.f().AddMissingRecommendedLogChannels();
							}
							sw = false;
							return;
						}
						if (qF.DataId != 0 || qe)
						{
							rl.H();
						}
						qF = new DataIdAndAttrId(0, 0);
						qe = false;
					}
					A(false);
					aL();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(Ta);
					sz.Enabled = true;
					sz.Start();
				}
			}
		}

		internal void aa()
		{
			if (Qz == null)
			{
				return;
			}
			bool flag = false;
			if (z())
			{
				flag = Qz.a(sx ? null : sY);
			}
			if (sy.Count != 0 || sx)
			{
				Qz.A(sx ? null : sy, Qn, qf);
			}
			bool flag2 = false;
			if (sZ.Count != 0 || sx)
			{
				flag2 = Qz.A(sx ? null : sZ);
			}
			if (rL != null && rL.A().a().Count != 0 && (flag || sy.Count != 0 || flag2))
			{
				if (z())
				{
					rL.A(false, true, true, false);
					M();
					Sl = false;
					rL.B(true);
				}
				else
				{
					rL.A(false, true, false, false);
					rL.B(false);
				}
				if (sy.Count != 0)
				{
					rL.b(true);
				}
				else
				{
					rL.b(false);
				}
				A(true);
			}
			sx = false;
			sY.Clear();
			sy.Clear();
			sZ.Clear();
		}

		private void aB()
		{
			bool num = ((uint)qI & 0x20u) != 0 || ((uint)qI & 8u) != 0 || ((uint)qI & 0x10u) != 0 || (SF.IsRunning && SF.ElapsedMilliseconds < 500);
			bool flag = (qI & 1) == 0 && global::A.A.B() && global::A.A.c().Count == 0;
			rE.A(flag);
			if (num || TB || flag || Tb)
			{
				((ToolStripItem)rE).Invalidate();
			}
			TB = num;
			Tb = flag;
			((ToolStripItem)rg).Invalidate();
			bool flag2 = (qI & 0x1000) != 0;
			if ((qI & 1) == 0 || SI.Count != 1)
			{
				if (flag2)
				{
					rE.B();
				}
				else
				{
					rE.a();
				}
				((ToolStripItem)Rl).Enabled = false;
				((ToolStripItem)RV).Enabled = false;
				((ToolStripItem)Ru).Enabled = false;
				Ru.a();
				((ToolStripItem)RW).Enabled = false;
				((ToolStripItem)RT).Enabled = Qz != null && Qz.awZ != 21;
				((ToolStripItem)Rz).Enabled = ((ToolStripItem)RT).Enabled;
				((ToolStripItem)Rt).Enabled = false;
				((ToolStripItem)Sd).Enabled = false;
				A(null, false, false);
				((ToolStripItem)rc).Enabled = false;
				((Control)rI).Visible = false;
				return;
			}
			global::A.F bpS = SI[0].BpS;
			global::A.g g = global::A.A.E(bpS.ao);
			switch (g)
			{
			case global::A.g.BI:
			case global::A.g.BJ:
			case global::A.g.Bj:
				if (aE())
				{
					if (flag2)
					{
						rE.C();
					}
					else
					{
						rE.b();
					}
				}
				else if (flag2)
				{
					rE.c();
				}
				else if (global::A.A.b(bpS.ao))
				{
					rE.D();
				}
				else
				{
					rE.d();
				}
				break;
			case global::A.g.Bi:
				if (flag2)
				{
					rE.E();
				}
				else if (global::A.A.b(bpS.ao))
				{
					rE.e();
				}
				else
				{
					rE.F();
				}
				break;
			}
			if (((uint)qI & 0x40u) != 0 || ((uint)qI & 0x20u) != 0)
			{
				((ToolStripItem)Rl).Enabled = false;
				((ToolStripItem)RV).Enabled = false;
				((ToolStripItem)Ru).Enabled = false;
				Ru.a();
				((ToolStripItem)RW).Enabled = false;
				((ToolStripItem)RT).Enabled = false;
				((ToolStripItem)Rz).Enabled = false;
				((ToolStripItem)Rt).Enabled = false;
				((ToolStripItem)Sd).Enabled = false;
				A(bpS, false, false);
				((ToolStripItem)rc).Enabled = false;
				return;
			}
			if (((uint)qI & 0x100u) != 0 || ((uint)qI & 0x200u) != 0)
			{
				if (((uint)qI & 0x100u) != 0)
				{
					if (!((Control)rI).Visible)
					{
						((Control)rI).Visible = true;
						((Control)rI).BringToFront();
					}
					((ToolStripItem)Rl).Enabled = (qI & 0x200) == 0 && !((Control)SW).Visible && !((Control)sc).Visible && SI.Count == 1 && g != global::A.g.Bi;
				}
				else
				{
					((ToolStripItem)Rl).Enabled = false;
				}
				((ToolStripItem)RV).Enabled = ((ToolStripItem)Rl).Enabled;
				((ToolStripItem)RT).Enabled = false;
				((ToolStripItem)Rz).Enabled = false;
				((ToolStripItem)Rt).Enabled = false;
				((ToolStripItem)Sd).Enabled = false;
				((ToolStripItem)Ru).Enabled = false;
				Ru.a();
				((ToolStripItem)RW).Enabled = false;
				A(bpS, false, false);
				((ToolStripItem)rc).Enabled = false;
				return;
			}
			if (Qz == null || Qz.C())
			{
				((ToolStripItem)Rl).Enabled = !((Control)SW).Visible && !((Control)sc).Visible && SI.Count == 1 && g != global::A.g.Bi;
				((ToolStripItem)RV).Enabled = ((ToolStripItem)Rl).Enabled;
			}
			((ToolStripItem)RT).Enabled = Qz != null && Qz.awZ != 21 && bpS.@as[34].BF != 0;
			((ToolStripItem)Rz).Enabled = ((ToolStripItem)RT).Enabled;
			((ToolStripItem)Rt).Enabled = Qz != null && Qz.A(20069) != null && Qz.A(20070) != null && bpS.@as[34].BF != 0;
			((ToolStripItem)Sd).Enabled = ((ToolStripItem)Rt).Enabled;
			A(bpS, Qz != null, (qI & 0x1000) == 0);
			if ((qI & 0x10) == 0)
			{
				((ToolStripItem)Ru).Enabled = true;
				Ru.B();
				((ToolStripItem)RW).Enabled = true;
			}
			else
			{
				((ToolStripItem)Ru).Enabled = false;
				Ru.a();
				((ToolStripItem)RW).Enabled = false;
			}
			((ToolStripItem)rc).Enabled = Qz != null && Qz.awm != null && Qz.C();
			((Control)rI).Visible = false;
		}

		private void A(global::A.F P_0, bool P_1, bool P_2)
		{
			((ToolStripItem)rY).Enabled = P_1;
			((ToolStripItem)rZ).Enabled = P_1;
			((ToolStripItem)rz).Enabled = P_1;
			((ToolStripItem)SA).Enabled = P_1;
			((ToolStripItem)ry).Enabled = P_1;
			((ToolStripItem)rX).Enabled = P_1;
			((ToolStripItem)Ro).Enabled = true;
			((ToolStripItem)RO).Enabled = P_2;
		}

		private void ab()
		{
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Invalid comparison between Unknown and I4
			if (Qz == null || qH != null || !global::A.A.C(Qz.aXc) || global::A.A.b(Qz.aXc) || (qg != null && !((Control)qg).IsDisposed && ((Control)qg).Visible))
			{
				return;
			}
			qH = Qz.aXc;
			aB();
			qG = new bi();
			if ((int)((Form)qG).ShowDialog((IWin32Window)(object)this) == 2)
			{
				global::A.A.a(Qz.aXc);
				if (global::A.A.c().Count == 0)
				{
					b(true);
				}
			}
			qH = null;
			((Component)qG).Dispose();
		}

		private void aC()
		{
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Invalid comparison between Unknown and I4
			if (Qz == null || !Qz.c() || !Qz.E() || qH != null || !A(Qz.aXc, true))
			{
				return;
			}
			lock (Qz.K())
			{
				if (Qz.K().Count == 0)
				{
					return;
				}
				aB();
				Setting setting = Qz.K()[0];
				string text2;
				if (((SettingOrSpecialObject)setting).D() is Table && setting == (((SettingOrSpecialObject)setting).D() as Table).TableDataSetting)
				{
					string text = ((SettingOrSpecialObject)setting).D().A(bz.aYt);
					text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ro() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rP();
				}
				else if (setting.Ba() > 1)
				{
					string text3 = ((SettingOrSpecialObject)setting).A(bz.aYt);
					text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rp() + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rQ();
				}
				else
				{
					string text4 = ((SettingOrSpecialObject)setting).A(bz.aYt);
					ValueTuple<string, string, bool> val = setting.aX();
					text2 = string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rq(),
						text4,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rR(),
						val.Item1,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rr()
					});
				}
				if ((int)bE.A((IWin32Window)(object)this, text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48, new string[2]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rS(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rs()
				}) == 6)
				{
					for (int i = 0; i < setting.BB(); i++)
					{
						if (Qz.i()[setting.a() + i] != by.aYk)
						{
							Qz.i()[setting.a() + i] = by.aYK;
						}
					}
				}
				else
				{
					for (int j = 0; j < setting.BB(); j++)
					{
						Qz.i()[setting.a() + j] = by.aYj;
					}
					Qz.aXd = true;
				}
				Qz.K().RemoveAt(0);
			}
		}

		private void ac()
		{
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			if (Qz == null || !Qz.c() || !Qz.E() || qH != null || !A(Qz.aXc, true))
			{
				return;
			}
			lock (Qz.k())
			{
				if (Qz.k().Count == 0)
				{
					return;
				}
				aB();
				Setting setting = Qz.k()[0];
				if (!setting.am() && setting.aN() && Qz.aWX && setting.aW() != null)
				{
					ai();
					string text2;
					if (((SettingOrSpecialObject)setting).D() is Table && setting == (((SettingOrSpecialObject)setting).D() as Table).TableDataSetting)
					{
						string text = ((SettingOrSpecialObject)setting).D().A(bz.aYt);
						text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rT() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rt();
					}
					else if (setting.Ba() > 1)
					{
						string text3 = ((SettingOrSpecialObject)setting).A(bz.aYt);
						text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rU() + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ru();
					}
					else
					{
						string text4 = ((SettingOrSpecialObject)setting).A(bz.aYt);
						text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rV() + text4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rv();
					}
					bE.A((IWin32Window)(object)this, text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					for (int i = 0; i < setting.av()[0]; i++)
					{
						for (int j = 0; j < setting.av()[1]; j++)
						{
							for (int k = 0; k < setting.av()[2]; k++)
							{
								int num = global::A.N.A(setting.aW(), setting.a(k, j, i), setting.aG(), setting.ag(), ((SettingOrSpecialObject)setting).A().aWR);
								if (setting.B(k, j, i) != num)
								{
									setting.A(k, j, i, num, true);
								}
							}
						}
					}
					A(setting.C());
				}
				Qz.k().RemoveAt(0);
			}
		}

		private void aD()
		{
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Invalid comparison between Unknown and I4
			if (CZ.BdO || Qz == null || !Qz.c())
			{
				return;
			}
			global::A.F f = global::A.A.e(Qz.aXc);
			if (f == null)
			{
				return;
			}
			bool flag = (qI & 0x100) != 0;
			if (CZ.A(f, true) && !flag)
			{
				if (!((Control)rI).Visible)
				{
					((Control)rI).Visible = true;
					((Control)rI).BringToFront();
				}
				string text = ai();
				Qz.aXd = false;
				if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rW() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NP(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
				{
					b(text);
				}
			}
		}

		private void ad()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Invalid comparison between Unknown and I4
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			TimeSpan val = System.DateTime.Now - TC;
			if (!(((TimeSpan)(ref val)).TotalMilliseconds > 2000.0))
			{
				return;
			}
			bool flag = (qI & 1) != 0;
			bool flag2 = global::A.A.B();
			if (!flag && !flag2)
			{
				Tc = false;
			}
			else if (!flag && flag2 && global::A.A.c().Count == 0)
			{
				try
				{
					bool flag3 = false;
					DriveInfo[] drives = DriveInfo.GetDrives();
					foreach (DriveInfo val2 in drives)
					{
						if ((int)val2.DriveType == 2 && Directory.Exists(val2.Name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rX()) && Directory.Exists(val2.Name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rx()))
						{
							flag3 = true;
							break;
						}
					}
					if (flag3)
					{
						if (!Tc)
						{
							bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rY(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ry(), (MessageBoxButtons)0, (MessageBoxIcon)48);
							Tc = true;
						}
					}
					else
					{
						Tc = false;
					}
				}
				catch
				{
				}
			}
			TC = System.DateTime.Now;
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void E(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = TD;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref TD, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void e(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = TD;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref TD, val3, val2);
			}
			while (val != val2);
		}

		internal static bool aE()
		{
			bool flag;
			if (SI.Count == 1 && SI[0].BpS.aH == 22)
			{
				flag = false;
			}
			else if (Qz != null && Qz.c())
			{
				Setting setting = Qz.A(10197);
				flag = setting != null && setting.ax() == 0;
			}
			else
			{
				flag = false;
			}
			if (Td != flag)
			{
				Td = flag;
				if (TD != null)
				{
					TD.Invoke((object)null, (EventArgs)null);
				}
			}
			return flag;
		}

		internal void ac(object P_0, EventArgs P_1)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			if ((int)A((IWin32Window)(object)this, true) != 2)
			{
				BackgroundWorker val = new BackgroundWorker
				{
					WorkerReportsProgress = true
				};
				val.DoWork += new DoWorkEventHandler(j);
				object obj = BM.t.Bqk;
				if (obj == null)
				{
					ProgressChangedEventHandler val2 = a;
					BM.t.Bqk = val2;
					obj = (object)val2;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj;
				val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(K);
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rZ());
				val.RunWorkerAsync();
			}
		}

		private void j(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			int num = 0;
			do
			{
				num = Math.Min(bT.avj, bj.abO);
				val.ReportProgress(num * 80 / 100);
			}
			while (num < 100);
			bT.B();
			val.ReportProgress(100);
			Thread.Sleep(200);
		}

		private void K(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Invalid comparison between Unknown and I4
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			P();
			Bo bo = new Bo();
			if ((int)((Form)bo).ShowDialog((IWin32Window)(object)this) == 1)
			{
				bv bv = bT.A(bo.A());
				bW bW = null;
				if (bv != null)
				{
					byte[] array = global::A.N.a(bo.A());
					if (array != null)
					{
						bW = new bW
						{
							axS = bv.axq,
							axs = bv.axR,
							axT = bv.axr,
							axt = array
						};
					}
				}
				if (bW != null)
				{
					A(bo.A(), bW);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rz(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			((Component)bo).Dispose();
		}

		private void aD(object P_0, EventArgs P_1)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Invalid comparison between Unknown and I4
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Invalid comparison between Unknown and I4
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Expected O, but got Unknown
			if ((int)A((IWin32Window)(object)this, true) == 2)
			{
				return;
			}
			bT.B();
			if ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) != 1)
			{
				return;
			}
			string text = ((FileDialog)qE).FileName;
			bW bW = null;
			if (((FileDialog)qE).FileName.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nz()))
			{
				List<CW> val = CZ.a(((FileDialog)qE).FileName);
				if (val.Count > 1)
				{
					Form val2 = new Form();
					((Control)val2).Font = ((Control)QQ).Font;
					((Control)val2).BackColor = td;
					((Control)val2).ForeColor = te;
					((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SA();
					val2.FormBorderStyle = (FormBorderStyle)3;
					val2.MinimizeBox = false;
					val2.MaximizeBox = false;
					val2.ShowIcon = false;
					val2.ShowInTaskbar = false;
					val2.StartPosition = (FormStartPosition)4;
					Enumerator<CW> enumerator = val.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							CW current = enumerator.Current;
							if (current.BDy != null)
							{
								RadioButton val3 = new RadioButton();
								((Control)val3).Tag = current;
								((Control)val3).ForeColor = te;
								((Control)val3).Text = bx.C(current.BDy.axS, current.BDy.axs);
								val3.Checked = false;
								((Control)val3).AutoSize = false;
								((Control)val3).Height = 20;
								((Control)val3).Width = 230;
								((Control)val3).Location = new Point(10, 10 + val.IndexOf(current) * 20);
								((Control)val2).Controls.Add((Control)(object)val3);
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					ThemedButton themedButton = new ThemedButton();
					((Button)themedButton).DialogResult = (DialogResult)2;
					((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
					((Control)themedButton).Size = new Size(80, 30);
					((Control)themedButton).Location = new Point(160, val.Count * 20 + 25);
					ThemedButton themedButton2 = new ThemedButton();
					((Button)themedButton2).DialogResult = (DialogResult)1;
					((Control)themedButton2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
					((Control)themedButton2).Size = new Size(80, 30);
					((Control)themedButton2).Location = new Point(((Control)themedButton).Left - (10 + ((Control)themedButton2).Width), val.Count * 20 + 25);
					val2.CancelButton = (IButtonControl)(object)themedButton;
					val2.ClientSize = new Size(250, val.Count * 20 + 65);
					((Control)val2).Controls.Add((Control)(object)themedButton2);
					((Control)val2).Controls.Add((Control)(object)themedButton);
					if ((int)val2.ShowDialog((IWin32Window)(object)QQ) == 1)
					{
						foreach (Control item in (ArrangedElementCollection)((Control)val2).Controls)
						{
							Control val4 = item;
							if (val4 is RadioButton && ((RadioButton)((val4 is RadioButton) ? val4 : null)).Checked)
							{
								CW cW = ((val4 is RadioButton) ? val4 : null).Tag as CW;
								bW = cW.BDy;
								int num = val.IndexOf(cW);
								text = val[num].BdA;
								break;
							}
						}
					}
					((Component)val2).Dispose();
				}
				else if (val.Count == 1)
				{
					bW = val[0].BDy;
					text = val[0].BdA;
				}
			}
			else
			{
				bv bv = bT.A(text);
				if (bv != null)
				{
					byte[] array = global::A.N.a(text);
					if (array != null)
					{
						bW = new bW
						{
							axS = bv.axq,
							axs = bv.axR,
							axT = bv.axr,
							axt = array
						};
					}
				}
			}
			if (bW != null)
			{
				A(text, bW);
			}
			else
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.rz(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private void A(string P_0, bW P_1)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected O, but got Unknown
			b(true);
			w();
			d();
			Qz = new Framework(P_0, P_1.axS, P_1.axs, P_1.axT);
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.DoWork += new DoWorkEventHandler(K);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(k);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sa());
			val.RunWorkerAsync();
		}

		private void K(object P_0, DoWorkEventArgs P_1)
		{
			global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SB(), true);
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			P_1.Result = Qz.a();
			val.ReportProgress(40);
			if ((bV.A)P_1.Result == bV.A.Brc)
			{
				Qz.A(Qz.aWS);
				val.ReportProgress(60);
				Qz.N();
				Qz.a(Qz.awj);
				Qz.a((HashSet<DataIdAndAttrId>)null);
				Qz.A(null, Qn, qf);
				Qz.A((HashSet<DataIdAndAttrId>)null);
				if (Qz.awZ == 21)
				{
					val.ReportProgress(80);
					if (Qz.f())
					{
						cb.A(Qz, null);
						cb.a();
						if (Qz.awP.h())
						{
							cb.B();
						}
					}
				}
				val.ReportProgress(90);
			}
			Thread.Sleep(100);
			val.ReportProgress(100);
		}

		private void k(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected O, but got Unknown
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Expected O, but got Unknown
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Expected O, but got Unknown
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Invalid comparison between Unknown and I4
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Invalid comparison between Unknown and I4
			global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sb(), true);
			P();
			bV.A a = (bV.A)P_1.Result;
			if (a == bV.A.Brc)
			{
				Bz.A(Qz, out var flag, out var _, out var flag3);
				if (!flag && !flag3 && BM.a(true))
				{
					((ToolStripItem)rm).Enabled = true;
					((ToolStripItem)rN).Enabled = true;
					((ToolStripItem)rM).Enabled = true;
					((ToolStripItem)RL).Enabled = true;
					((ToolStripItem)rP).Enabled = true;
					((ToolStripItem)rR).Enabled = true;
					((ToolStripItem)rt).Enabled = true;
					((ToolStripItem)Rx).Enabled = true;
					((ToolStripItem)Ri).Enabled = true;
					((ToolStripItem)RZ).Enabled = true;
					((ToolStripItem)RM).Enabled = true;
					((ToolStripItem)rb).Enabled = true;
					((ToolStripItem)Sb).Enabled = true;
					((ToolStripItem)Sc).Enabled = true;
					((ToolStripItem)SC).Enabled = true;
					((ToolStripItem)rc).Enabled = false;
					QZ = string.Empty;
					A(true);
					A(Qu, out var _);
				}
				return;
			}
			string empty = string.Empty;
			switch (a)
			{
			case bV.A.BrD:
			{
				BackgroundWorker val = new BackgroundWorker();
				object obj = BM.t.BqL;
				if (obj == null)
				{
					DoWorkEventHandler val2 = bj.D;
					BM.t.BqL = val2;
					obj = (object)val2;
				}
				val.DoWork += (DoWorkEventHandler)obj;
				val.WorkerReportsProgress = true;
				object obj2 = BM.t.Bqk;
				if (obj2 == null)
				{
					ProgressChangedEventHandler val3 = BM.a;
					BM.t.Bqk = val3;
					obj2 = (object)val3;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj2;
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ns());
				BackgroundWorker val4 = new BackgroundWorker();
				val4.DoWork += new DoWorkEventHandler(k);
				val4.RunWorkerCompleted += new RunWorkerCompletedEventHandler(L);
				val.RunWorkerAsync();
				val4.RunWorkerAsync((object)Qz);
				bj.abM = true;
				return;
			}
			case bV.A.Brd:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NT();
				break;
			case bV.A.BrE:
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nt();
				break;
			default:
			{
				string text2 = bx.C(Qz.awZ, Qz.awz);
				text2 = ((text2 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
				empty = ((a != bV.A.Bre) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NW() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)Qz.aXA).ToString()) : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NV() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)Qz.aXA).ToString()));
				break;
			}
			}
			if (!qW && (int)bE.A((IWin32Window)(object)this, empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !c(((FileDialog)qE).FileName))
				{
				}
			}
		}

		private void k(object P_0, DoWorkEventArgs P_1)
		{
			Framework framework = (Framework)P_1.Argument;
			string text = CZ.A(new bW
			{
				axS = framework.awZ,
				axs = framework.awz,
				axT = framework.aXA,
				axt = framework.F()
			}, 65535);
			int? num;
			UpdateOutcomes updateOutcomes;
			string[] bQS = bj.A(framework.aXA, framework.awZ, framework.awz, text, out num, out updateOutcomes);
			m m = default(m);
			if (num.HasValue && updateOutcomes == UpdateOutcomes.CompleteUpdate)
			{
				m.BQr = updateOutcomes;
				m.BQS = bQS;
			}
			P_1.Result = m;
		}

		private void L(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Invalid comparison between Unknown and I4
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Invalid comparison between Unknown and I4
			m m = (m)P_1.Result;
			P();
			if (m.BQS != null && m.BQS.Length != 0)
			{
				string[] bQS = m.BQS;
				foreach (string text in bQS)
				{
					List<string> val;
					if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()))
					{
						val = new List<string>();
						val.Add(text);
					}
					else
					{
						val = bT.b(text);
					}
					if (val.Count != 0 && c(text))
					{
						return;
					}
				}
			}
			string text2 = bx.C(Qz.awZ, Qz.awz);
			text2 = ((text2 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NZ() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)Qz.aXA).ToString();
			if (!qW && (int)bE.A((IWin32Window)(object)this, text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !c(((FileDialog)qE).FileName))
				{
				}
			}
		}

		private bool c(string P_0)
		{
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				bW bW = null;
				string text = null;
				if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nz()))
				{
					List<CW> val = CZ.a(P_0);
					if (val.Count != 0)
					{
						if (val.Count != 1)
						{
							if (!qW)
							{
								bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
							}
							return false;
						}
						bW = val[0].BDy;
						text = val[0].BdA;
					}
				}
				else
				{
					text = P_0;
					bv bv = bT.A(text);
					if (bv != null)
					{
						byte[] array = global::A.N.a(text);
						if (array != null)
						{
							bW = new bW
							{
								axS = bv.axq,
								axs = bv.axR,
								axT = bv.axr,
								axt = array
							};
						}
					}
				}
				if (bW != null && text != null)
				{
					A(text, bW);
					return true;
				}
				if (!qW)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			catch (System.Exception ex)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sc() + ex.Message, true);
			}
			return false;
		}

		private void D(string P_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			if ((int)A((IWin32Window)(object)this, true) == 2)
			{
				return;
			}
			try
			{
				bW bW = Cq.a(P_0);
				if (bW != null)
				{
					a(null, P_0, bW);
					TE.A(P_0);
					return;
				}
				throw new System.Exception();
			}
			catch
			{
				TE.B(P_0);
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NI(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		internal void d(string P_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			if ((int)A((IWin32Window)(object)this, true) != 2)
			{
				E(P_0);
			}
		}

		internal void ad(object P_0, EventArgs P_1)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Invalid comparison between Unknown and I4
			if ((int)A((IWin32Window)(object)this, true) != 2)
			{
				((FileDialog)TF).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mi();
				((FileDialog)TF).Filter = bx.a();
				if ((int)((CommonDialog)TF).ShowDialog((IWin32Window)(object)this) == 1)
				{
					E(((FileDialog)TF).FileName);
				}
			}
		}

		internal void E(string P_0)
		{
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Invalid comparison between Unknown and I4
			bW bW = Cq.a(P_0);
			if (bW != null)
			{
				bool flag = false;
				bool flag2 = false;
				if (bx.A(bW.axS) && bW.axT.A() < 3)
				{
					flag = true;
					if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SD(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sd(), (MessageBoxButtons)1) == 2)
					{
						flag2 = true;
					}
				}
				if (!flag2)
				{
					a(null, P_0, bW);
					if (!flag)
					{
						TE.A(P_0);
					}
				}
			}
			else
			{
				TE.B(P_0);
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NI(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private void aE(object P_0, EventArgs P_1)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Invalid comparison between Unknown and I4
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			if ((int)A((IWin32Window)(object)this, true) == 2)
			{
				return;
			}
			((FileDialog)TF).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Mi();
			((FileDialog)TF).Filter = string.Empty;
			if ((int)((CommonDialog)TF).ShowDialog((IWin32Window)(object)this) == 1)
			{
				bW bW = Cq.a(((FileDialog)TF).FileName);
				if (bW != null)
				{
					a(null, ((FileDialog)TF).FileName, bW);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NI(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
		}

		internal void a(string P_0, string P_1, bW P_2)
		{
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected O, but got Unknown
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Invalid comparison between Unknown and I4
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			b(true);
			w();
			d();
			if (!P_2.axT.d() && !bg.a())
			{
				bool flag = false;
				if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SE() + P_2.axT.D() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ko(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kP(), (MessageBoxButtons)1, (MessageBoxIcon)48) == 1)
				{
					bg bg = new bg();
					((Form)bg).ShowDialog((IWin32Window)(object)this);
					((Component)bg).Dispose();
					if (bg.a())
					{
						flag = true;
					}
				}
				if (!flag)
				{
					return;
				}
			}
			bool flag2 = false;
			if (bx.A(P_2.axS) && P_2.axT.A() < 3)
			{
				flag2 = true;
			}
			N n = default(N);
			n.BQs = false;
			n.BQU = P_1;
			n.BQu = P_0;
			n.BQV = P_2;
			n.BQv = flag2;
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.DoWork += new DoWorkEventHandler(L);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(l);
			if (flag2)
			{
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Se());
			}
			else
			{
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SF());
			}
			val.RunWorkerAsync((object)n);
		}

		private void L(object P_0, DoWorkEventArgs P_1)
		{
			global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sf(), true);
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			N n = (N)P_1.Argument;
			string text = n.BQu;
			if (text == null && n.BQV != null)
			{
				text = bT.A(n.BQV.axS, n.BQV.axs, n.BQV.axT, n.BQV.axt, true);
			}
			val.ReportProgress(10);
			if (!string.IsNullOrEmpty(text) && n.BQV != null)
			{
				if (n.BQv)
				{
					Framework framework = new Framework(text, n.BQV.axS, n.BQV.axs, n.BQV.axT);
					n.BQt = framework.a();
					if (n.BQt == bV.A.Brc)
					{
						val.ReportProgress(30);
						global::A.k k;
						string text2 = bT.A(n.BQV.axS, n.BQV.axs, out k);
						if (!string.IsNullOrEmpty(text2))
						{
							Qz = new Framework(text2, n.BQV.axS, n.BQV.axs, k);
							n.BQt = Qz.a();
							if (n.BQt == bV.A.Brc)
							{
								val.ReportProgress(50);
								string text3;
								bool num = new Cq(n.BQU, framework).A(out text3) && string.IsNullOrEmpty(text3);
								val.ReportProgress(60);
								Qz.C(Qz.aWS);
								Qz.A(framework, Qz.aWS, true, false);
								Qz.A(Qz, false);
								val.ReportProgress(70);
								Qz.c(Qz.aWS);
								Qz.N();
								Qz.a(Qz.awj);
								Qz.a((HashSet<DataIdAndAttrId>)null);
								Qz.A(null, Qn, qf);
								Qz.A((HashSet<DataIdAndAttrId>)null);
								val.ReportProgress(90);
								if (num)
								{
									n.BQs = true;
								}
								else
								{
									n.BQT = text3;
								}
							}
						}
					}
				}
				else
				{
					val.ReportProgress(20);
					Qz = new Framework(text, n.BQV.axS, n.BQV.axs, n.BQV.axT);
					val.ReportProgress(30);
					n.BQt = Qz.a();
					if (n.BQt == bV.A.Brc)
					{
						val.ReportProgress(60);
						string text4;
						bool num2 = new Cq(n.BQU, Qz).A(out text4) && string.IsNullOrEmpty(text4);
						val.ReportProgress(70);
						Qz.N();
						Qz.a(Qz.awj);
						Qz.a((HashSet<DataIdAndAttrId>)null);
						Qz.A(null, Qn, qf);
						Qz.A((HashSet<DataIdAndAttrId>)null);
						if (Qz.awZ == 21)
						{
							val.ReportProgress(80);
							if (Qz.f())
							{
								cb.A(Qz, null);
								cb.a();
								if (Qz.awP.h())
								{
									cb.B();
								}
							}
						}
						val.ReportProgress(90);
						if (num2)
						{
							n.BQs = true;
						}
						else
						{
							n.BQT = text4;
						}
					}
				}
			}
			else
			{
				n.BQt = bV.A.BrD;
			}
			P_1.Result = n;
			Thread.Sleep(100);
			val.ReportProgress(100);
		}

		private void l(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Invalid comparison between Unknown and I4
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Invalid comparison between Unknown and I4
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Invalid comparison between Unknown and I4
			//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Invalid comparison between Unknown and I4
			N n = (N)P_1.Result;
			global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SG() + n.BQs + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), true);
			P();
			qv = null;
			bool flag = true;
			if (!n.BQs)
			{
				flag = false;
				if (n.BQt == bV.A.BrD)
				{
					BackgroundWorker val = new BackgroundWorker();
					object obj = BM.t.BqL;
					if (obj == null)
					{
						DoWorkEventHandler val2 = bj.D;
						BM.t.BqL = val2;
						obj = (object)val2;
					}
					val.DoWork += (DoWorkEventHandler)obj;
					val.WorkerReportsProgress = true;
					object obj2 = BM.t.Bqk;
					if (obj2 == null)
					{
						ProgressChangedEventHandler val3 = a;
						BM.t.Bqk = val3;
						obj2 = (object)val3;
					}
					val.ProgressChanged += (ProgressChangedEventHandler)obj2;
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ns());
					BackgroundWorker val4 = new BackgroundWorker();
					val4.DoWork += new DoWorkEventHandler(l);
					val4.RunWorkerCompleted += new RunWorkerCompletedEventHandler(M);
					val.RunWorkerAsync();
					val4.RunWorkerAsync((object)n);
					bj.abM = true;
				}
				else if (!qW)
				{
					string empty = string.Empty;
					if (n.BQt == bV.A.Brd)
					{
						empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NT();
					}
					else if (n.BQt == bV.A.BrE)
					{
						empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nt();
					}
					else
					{
						string text = bx.C(n.BQV.axS, n.BQV.axs);
						text = ((text != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
						empty = ((n.BQt == bV.A.Bre) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NV() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)n.BQV.axT).ToString()) : ((!string.IsNullOrEmpty(n.BQT)) ? n.BQT : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NW() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)n.BQV.axT).ToString())));
					}
					if (true)
					{
						if ((int)bE.A((IWin32Window)(object)this, empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
						{
							while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1)
							{
								if (A(((FileDialog)qE).FileName, n))
								{
									return;
								}
							}
						}
					}
					else if ((int)bE.A((IWin32Window)(object)this, n.BQT + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NX(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48, (MessageBoxDefaultButton)256, new string[2]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nx(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NY()
					}) == 6)
					{
						while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1)
						{
							if (A(((FileDialog)qE).FileName, n))
							{
								return;
							}
						}
					}
					else
					{
						flag = true;
					}
				}
			}
			if (!flag)
			{
				return;
			}
			Bz.A(Qz, out var flag2, out var _, out var flag4);
			if (!flag2 && !flag4 && a(true))
			{
				((ToolStripItem)rm).Enabled = true;
				((ToolStripItem)rN).Enabled = true;
				((ToolStripItem)rM).Enabled = true;
				((ToolStripItem)RL).Enabled = true;
				((ToolStripItem)rP).Enabled = true;
				((ToolStripItem)rR).Enabled = true;
				((ToolStripItem)rt).Enabled = true;
				((ToolStripItem)Rx).Enabled = true;
				((ToolStripItem)Ri).Enabled = true;
				((ToolStripItem)RZ).Enabled = true;
				((ToolStripItem)RM).Enabled = true;
				((ToolStripItem)rb).Enabled = true;
				((ToolStripItem)Sb).Enabled = true;
				((ToolStripItem)Sc).Enabled = true;
				((ToolStripItem)SC).Enabled = true;
				((ToolStripItem)rc).Enabled = false;
				if (n.BQv)
				{
					QZ = string.Empty;
				}
				else
				{
					QZ = n.BQU;
				}
				A(true);
			}
		}

		private void l(object P_0, DoWorkEventArgs P_1)
		{
			N bQw = (N)P_1.Argument;
			string text = CZ.A(bQw.BQV, 65535);
			int? num;
			UpdateOutcomes updateOutcomes;
			string[] bQx = bj.A(bQw.BQV.axT, bQw.BQV.axS, bQw.BQV.axs, text, out num, out updateOutcomes);
			n n = default(n);
			n.BQw = bQw;
			if (num.HasValue && updateOutcomes == UpdateOutcomes.CompleteUpdate)
			{
				n.BQX = updateOutcomes;
				n.BQx = bQx;
			}
			P_1.Result = n;
		}

		private void M(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Invalid comparison between Unknown and I4
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Invalid comparison between Unknown and I4
			n n = (n)P_1.Result;
			P();
			if (n.BQx != null && n.BQx.Length != 0)
			{
				string[] bQx = n.BQx;
				foreach (string text in bQx)
				{
					List<string> val;
					if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()))
					{
						val = new List<string>();
						val.Add(text);
					}
					else
					{
						val = bT.b(text);
					}
					if (val.Count != 0 && A(text, n.BQw))
					{
						return;
					}
				}
			}
			string text2 = bx.C(n.BQw.BQV.axS, n.BQw.BQV.axs);
			text2 = ((text2 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NZ() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)n.BQw.BQV.axT).ToString();
			if (!qW && (int)bE.A((IWin32Window)(object)this, text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !A(((FileDialog)qE).FileName, n.BQw))
				{
				}
			}
		}

		private bool A(string P_0, N P_1)
		{
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (P_1.BQV == null)
				{
					return false;
				}
				string text = null;
				bool flag3;
				bool flag;
				bool flag2;
				global::A.k k;
				if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nz()))
				{
					flag3 = CZ.A(P_0, P_1.BQV, out flag, out flag2, out k, out text);
				}
				else
				{
					text = P_0;
					flag3 = bT.A(P_0, P_1.BQV, out flag, out flag2, out k);
				}
				if (flag3 && text != null)
				{
					a(text, P_1.BQU, P_1.BQV);
					return true;
				}
				if (!qW)
				{
					if (k == null || text == null)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else if (!flag)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qo(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else if (!flag2)
					{
						bE.A((IWin32Window)(object)this, string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nB(),
							((object)k).ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sg(),
							((object)P_1.BQV.axT).ToString(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
						}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
			}
			catch (System.Exception ex)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SH() + ex.Message, true);
			}
			return false;
		}

		internal void ae(object P_0, EventArgs P_1)
		{
			if (((Control)this).InvokeRequired)
			{
				try
				{
					O o = ae;
					((Control)this).Invoke((System.Delegate)o, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			if (Qz != null && (qI & 0x1000) == 0)
			{
				if (((uint)qI & 0x400u) != 0)
				{
					((ToolStripItem)RO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PY();
					Tf.a();
				}
				else
				{
					Tf.A();
					((ToolStripItem)RO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sh();
				}
				if (qz != null && !((Control)qz).IsDisposed && ((Control)qz).Visible)
				{
					qz.d();
				}
			}
		}

		private void aF(object P_0, EventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			ay ay = new ay();
			((Form)ay).ShowDialog((IWin32Window)(object)this);
			((Component)ay).Dispose();
		}

		private void af(object P_0, EventArgs P_1)
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			if (((uint)qI & 0x400u) != 0 && Tf.BCQ != null)
			{
				try
				{
					a(Tf.BCq, true);
					return;
				}
				catch (System.Exception ex)
				{
					global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SI() + ex.Message, true);
					return;
				}
			}
			try
			{
				string text = e(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iW());
				if (string.IsNullOrEmpty(text))
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Si(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else
				{
					a(text, false);
				}
			}
			catch (System.Exception ex2)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SI() + ex2.Message, true);
			}
		}

		private void aG(object P_0, EventArgs P_1)
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			string text;
			if (((uint)qI & 0x400u) != 0 && Tf.BCQ != null)
			{
				text = Tf.BCq;
				((ToolStripItem)RO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PY();
				Tf.a();
			}
			else
			{
				text = string.Empty;
			}
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.DoWork += new DoWorkEventHandler(M);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SJ());
			val.RunWorkerAsync((object)text);
		}

		private void M(object P_0, DoWorkEventArgs P_1)
		{
			for (int i = 0; i < 10; i++)
			{
				Thread.Sleep(100);
				((BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null)).ReportProgress((i + 1) * 10);
			}
			string result = P_1.Argument as string;
			P_1.Result = result;
		}

		private void m(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			P();
			bool flag = false;
			bool flag2 = false;
			if (File.Exists(Be.C()))
			{
				flag = true;
				flag2 = true;
			}
			else if (File.Exists(Be.b()))
			{
				flag = false;
				flag2 = true;
			}
			if (!flag2)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iU(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			string text = P_1.Result as string;
			string text2;
			if (string.IsNullOrEmpty(text))
			{
				text2 = ((!flag) ? e(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iY()) : e(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iW()));
			}
			else if (flag)
			{
				text2 = text;
			}
			else
			{
				text2 = text.Substring(0, text.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ej().Length) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.iR();
				if (!File.Exists(text2))
				{
					text2 = null;
				}
			}
			if (string.IsNullOrEmpty(text2))
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Si(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			try
			{
				if (flag)
				{
					if (!global::A.S.A(text2))
					{
						global::A.S.A(text2, global::A.M.B());
					}
					Be.A(Be.C(), text2);
				}
				else
				{
					Be.A(Be.b(), text2);
				}
			}
			catch (System.Exception ex)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sj() + ex.Message, true);
			}
		}

		private static string e(string P_0)
		{
			string result = null;
			if (Qz != null && Qz.c())
			{
				string empty = string.Empty;
				if (Qz.A(ref empty))
				{
					try
					{
						string text = A(empty, Qz.aXc);
						if (!string.IsNullOrEmpty(text))
						{
							if (!text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj()) && !text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()))
							{
								text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
							}
							string text2 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SK();
							if (Directory.Exists(text2))
							{
								string[] files = Directory.GetFiles(text2, P_0);
								if (files.Length != 0)
								{
									System.DateTime dateTime = System.DateTime.MinValue;
									string[] array = files;
									foreach (string text3 in array)
									{
										System.DateTime lastWriteTime = File.GetLastWriteTime(text3);
										if (lastWriteTime > dateTime)
										{
											Be.A(text3, out var _, out var b);
											if (b == 0)
											{
												result = text3;
												dateTime = lastWriteTime;
											}
										}
									}
								}
							}
						}
					}
					catch (System.Exception ex)
					{
						global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sk() + ex.Message, true);
						result = null;
					}
				}
			}
			return result;
		}

		private void ag(object P_0, EventArgs P_1)
		{
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Invalid comparison between Unknown and I4
			string empty = string.Empty;
			bool flag = false;
			if (Qz != null)
			{
				flag = Qz.A(ref empty);
			}
			if (flag)
			{
				string text = A(empty, Qz.aXc);
				if (!string.IsNullOrEmpty(text))
				{
					string text2 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Jh();
					if (!Directory.Exists(text2))
					{
						((FileDialog)Th).InitialDirectory = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
					}
					else
					{
						((FileDialog)Th).InitialDirectory = text2;
					}
				}
				else
				{
					((FileDialog)Th).InitialDirectory = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
				}
			}
			else
			{
				((FileDialog)Th).InitialDirectory = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
			}
			if ((int)((CommonDialog)Th).ShowDialog((IWin32Window)(object)this) == 1)
			{
				a(((FileDialog)Th).FileName, false);
			}
		}

		internal void a(string P_0, bool P_1)
		{
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Invalid comparison between Unknown and I4
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Invalid comparison between Unknown and I4
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Invalid comparison between Unknown and I4
			((ToolStripItem)RO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.PY();
			Tf.a();
			if (((Control)rn).Visible)
			{
				ae();
			}
			bool flag = false;
			if (Qz != null && Qz.c())
			{
				if (P_1)
				{
					flag = true;
				}
				else
				{
					DialogResult val = bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SL(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sl(), (MessageBoxButtons)3, (MessageBoxIcon)0, (MessageBoxDefaultButton)512, new string[3]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gE(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SM(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV()
					});
					if ((int)val == 6)
					{
						flag = true;
					}
					else if ((int)val == 7)
					{
						flag = false;
					}
					else if ((int)val == 2)
					{
						return;
					}
				}
			}
			if (!flag)
			{
				A((IWin32Window)(object)this, false);
			}
			o o = default(o);
			o.BQY = P_0;
			o.BQy = flag;
			BackgroundWorker val2 = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val2.DoWork += new DoWorkEventHandler(m);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val3 = a;
				BM.t.Bqk = val3;
				obj = (object)val3;
			}
			val2.ProgressChanged += (ProgressChangedEventHandler)obj;
			val2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(N);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sm());
			val2.RunWorkerAsync((object)o);
		}

		private void m(object P_0, DoWorkEventArgs P_1)
		{
			global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SN(), true);
			o o = (o)P_1.Argument;
			P p = default(P);
			p.BqA = o.BQy;
			p.BQz = o.BQY;
			for (int i = 0; i < 10; i++)
			{
				Thread.Sleep(100);
				((BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null)).ReportProgress(i / 2);
			}
			p.BQZ = rn.A(o.BQY, (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null), out p.Bqa);
			P_1.Result = p;
		}

		private void N(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected O, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected O, but got Unknown
			P p = (P)P_1.Result;
			global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sn() + p.BQZ + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), true);
			P();
			if (p.BQZ)
			{
				if (p.BqA && Qz != null)
				{
					F(p.BQz);
				}
				else if (File.Exists(global::a.aC.Gm))
				{
					bW bW = Cq.a(global::a.aC.Gm);
					if (bW != null)
					{
						if (((uint)qI & (true ? 1u : 0u)) != 0 && !p.BqA)
						{
							b(true);
						}
						w();
						d();
						N n = default(N);
						n.BQs = false;
						n.BQU = global::a.aC.Gm;
						n.BQu = null;
						n.BQV = bW;
						n.BQW = p.BQz;
						BackgroundWorker val = new BackgroundWorker
						{
							WorkerReportsProgress = true
						};
						val.DoWork += new DoWorkEventHandler(L);
						object obj = BM.t.Bqk;
						if (obj == null)
						{
							ProgressChangedEventHandler val2 = a;
							BM.t.Bqk = val2;
							obj = (object)val2;
						}
						val.ProgressChanged += (ProgressChangedEventHandler)obj;
						val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.n);
						C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SO());
						val.RunWorkerAsync((object)n);
					}
					else
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NI(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
				else
				{
					rn.B();
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.So(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			else
			{
				rn.B();
				if (string.IsNullOrEmpty(p.Bqa))
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SP(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sp() + p.Bqa, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
		}

		private void n(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Expected O, but got Unknown
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Expected O, but got Unknown
			//IL_0380: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Invalid comparison between Unknown and I4
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Expected O, but got Unknown
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected O, but got Unknown
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Expected O, but got Unknown
			//IL_038e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Invalid comparison between Unknown and I4
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
			N n = (N)P_1.Result;
			global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SQ() + n.BQs + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), true);
			P();
			if (n.BQs)
			{
				if (File.Exists(global::a.aC.Gm))
				{
					File.Delete(global::a.aC.Gm);
				}
				if (a(true))
				{
					((ToolStripItem)rm).Enabled = true;
					((ToolStripItem)rN).Enabled = true;
					((ToolStripItem)rM).Enabled = true;
					((ToolStripItem)RL).Enabled = false;
					((ToolStripItem)rP).Enabled = false;
					((ToolStripItem)rR).Enabled = false;
					((ToolStripItem)rt).Enabled = false;
					((ToolStripItem)Rx).Enabled = false;
					((ToolStripItem)Rl).Enabled = false;
					((ToolStripItem)RV).Enabled = false;
					((ToolStripItem)Ri).Enabled = true;
					((ToolStripItem)RZ).Enabled = true;
					((ToolStripItem)RM).Enabled = false;
					((ToolStripItem)rb).Enabled = false;
					((ToolStripItem)Sb).Enabled = false;
					((ToolStripItem)Sc).Enabled = false;
					((ToolStripItem)SC).Enabled = false;
					((ToolStripItem)rc).Enabled = false;
					QZ = string.Empty;
					F(n.BQW);
					if (RA != null && ((Control)RA).Visible)
					{
						((Form)RA).Close();
						((Component)RA).Dispose();
					}
					if (qz != null && ((Control)qz).Visible)
					{
						((Form)qz).Close();
						((Component)qz).Dispose();
					}
					if (global::a.aC.GO)
					{
						qz = new BX();
						BX bX = qz;
						Point location = ((Form)this).Location;
						int num = ((Point)(ref location)).X + (((Control)this).Width - ((Control)qz).Width) / 2;
						location = ((Form)this).Location;
						((Form)bX).Location = new Point(num, ((Point)(ref location)).Y + (((Control)this).Height - ((Control)qz).Height) / 2);
						((Form)qz).Show((IWin32Window)(object)this);
					}
				}
				return;
			}
			string empty = string.Empty;
			if (n.BQt == bV.A.BrD)
			{
				BackgroundWorker val = new BackgroundWorker();
				object obj = BM.t.BqL;
				if (obj == null)
				{
					DoWorkEventHandler val2 = bj.D;
					BM.t.BqL = val2;
					obj = (object)val2;
				}
				val.DoWork += (DoWorkEventHandler)obj;
				val.WorkerReportsProgress = true;
				object obj2 = BM.t.Bqk;
				if (obj2 == null)
				{
					ProgressChangedEventHandler val3 = a;
					BM.t.Bqk = val3;
					obj2 = (object)val3;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj2;
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ns());
				BackgroundWorker val4 = new BackgroundWorker();
				val4.DoWork += new DoWorkEventHandler(N);
				val4.RunWorkerCompleted += new RunWorkerCompletedEventHandler(O);
				val.RunWorkerAsync();
				val4.RunWorkerAsync((object)n);
				bj.abM = true;
				return;
			}
			if (n.BQt == bV.A.Brd)
			{
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NT();
			}
			else if (n.BQt == bV.A.BrE)
			{
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nt();
			}
			else
			{
				string text = bx.C(n.BQV.axS, n.BQV.axs);
				text = ((text != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
				empty = ((n.BQt != bV.A.Bre) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NW() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)n.BQV.axT).ToString()) : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NV() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)n.BQV.axT).ToString()));
			}
			if ((int)bE.A((IWin32Window)(object)this, empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !a(((FileDialog)qE).FileName, n))
				{
				}
			}
		}

		private void N(object P_0, DoWorkEventArgs P_1)
		{
			N bqB = (N)P_1.Argument;
			string text = CZ.A(bqB.BQV, 65535);
			int? num;
			UpdateOutcomes updateOutcomes;
			string[] bqC = bj.A(bqB.BQV.axT, bqB.BQV.axS, bqB.BQV.axs, text, out num, out updateOutcomes);
			p p = default(p);
			p.BqB = bqB;
			if (num.HasValue && updateOutcomes == UpdateOutcomes.CompleteUpdate)
			{
				p.Bqb = updateOutcomes;
				p.BqC = bqC;
			}
			P_1.Result = p;
		}

		private void O(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Invalid comparison between Unknown and I4
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Invalid comparison between Unknown and I4
			p p = (p)P_1.Result;
			P();
			if (p.BqC != null && p.BqC.Length != 0)
			{
				string[] bqC = p.BqC;
				foreach (string text in bqC)
				{
					List<string> val;
					if (text.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ny()))
					{
						val = new List<string>();
						val.Add(text);
					}
					else
					{
						val = bT.b(text);
					}
					if (val.Count != 0 && a(text, p.BqB))
					{
						return;
					}
				}
			}
			string text2 = bx.C(p.BqB.BQV.axS, p.BqB.BQV.axs);
			text2 = ((text2 != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NU() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu()) : string.Empty);
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NZ() + text2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nv() + ((object)p.BqB.BQV.axT).ToString();
			if ((int)bE.A((IWin32Window)(object)this, text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nw(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
			{
				while ((int)((CommonDialog)qE).ShowDialog((IWin32Window)(object)this) == 1 && !a(((FileDialog)qE).FileName, p.BqB))
				{
				}
			}
		}

		private bool a(string P_0, N P_1)
		{
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (P_1.BQV == null)
				{
					return false;
				}
				string text = null;
				bool flag3;
				bool flag;
				bool flag2;
				global::A.k k;
				if (P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nz()))
				{
					flag3 = CZ.A(P_0, P_1.BQV, out flag, out flag2, out k, out text);
				}
				else
				{
					text = P_0;
					flag3 = bT.A(P_0, P_1.BQV, out flag, out flag2, out k);
				}
				if (flag3 && text != null)
				{
					P_1.BQu = text;
					BackgroundWorker val = new BackgroundWorker
					{
						WorkerReportsProgress = true
					};
					val.DoWork += new DoWorkEventHandler(L);
					object obj = BM.t.Bqk;
					if (obj == null)
					{
						ProgressChangedEventHandler val2 = a;
						BM.t.Bqk = val2;
						obj = (object)val2;
					}
					val.ProgressChanged += (ProgressChangedEventHandler)obj;
					val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(n);
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SO());
					val.RunWorkerAsync((object)P_1);
					return true;
				}
				if (k == null || text == null)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nA(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (!flag)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.qo(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else if (!flag2)
				{
					bE.A((IWin32Window)(object)this, string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nB(),
						((object)k).ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sq(),
						((object)P_1.BQV.axT).ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
					}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.nC(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			catch (System.Exception ex)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SR() + ex.Message, true);
			}
			return false;
		}

		internal static void F(string P_0)
		{
			TI = P_0;
			A(true);
			((Control)QQ.rn).Visible = true;
			QQ.Y();
			X();
			lock (qh)
			{
				qI |= 4096;
			}
		}

		internal static void ae()
		{
			TI = string.Empty;
			A(true);
			((Control)QQ.rn).Visible = false;
			QQ.Y();
			X();
			lock (qh)
			{
				qI &= -4097;
			}
		}

		internal static bool C(int P_0)
		{
			if (((uint)qI & 0x1000u) != 0 && P_0 >= 0 && P_0 < global::a.aC.Gn.Count)
			{
				return global::a.aC.Gn[P_0];
			}
			return false;
		}

		private void aF()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Expected O, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			if (Directory.Exists(Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sr()))
			{
				try
				{
					Ti = new FileSystemWatcher(Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sr());
					Ti.IncludeSubdirectories = true;
					Ti.NotifyFilter = (NotifyFilters)83;
					Ti.Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SS();
					Ti.Changed += new FileSystemEventHandler(A);
					Ti.Created += new FileSystemEventHandler(a);
					Ti.Deleted += new FileSystemEventHandler(B);
					Ti.Renamed += new RenamedEventHandler(A);
					Ti.EnableRaisingEvents = true;
				}
				catch
				{
				}
			}
			if (Directory.Exists(Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ss()))
			{
				try
				{
					FileSystemWatcher val = new FileSystemWatcher(Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ss())
					{
						IncludeSubdirectories = true,
						NotifyFilter = (NotifyFilters)83,
						Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ST()
					};
					val.Changed += new FileSystemEventHandler(A);
					val.Created += new FileSystemEventHandler(a);
					val.Deleted += new FileSystemEventHandler(B);
					val.Renamed += new RenamedEventHandler(A);
					val.EnableRaisingEvents = true;
				}
				catch
				{
				}
			}
		}

		private void A(object P_0, FileSystemEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)P_1.ChangeType == 4)
			{
				TJ++;
			}
		}

		private void a(object P_0, FileSystemEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)P_1.ChangeType == 1)
			{
				TJ++;
			}
		}

		private void B(object P_0, FileSystemEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)P_1.ChangeType == 2)
			{
				TJ++;
			}
		}

		private void A(object P_0, RenamedEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)((FileSystemEventArgs)P_1).ChangeType == 8)
			{
				TJ++;
			}
		}

		private void af()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			BackgroundWorker val = new BackgroundWorker();
			val.DoWork += new DoWorkEventHandler(n);
			val.RunWorkerAsync();
		}

		private void n(object P_0, DoWorkEventArgs P_1)
		{
			Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.St();
			while (!qw)
			{
				if (TJ != 0)
				{
					if (TJ == 1)
					{
						if (Directory.Exists(Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sr()))
						{
							try
							{
								global::A.m.A(Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sr(), Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SU(), true, global::A.m.A.Bgt);
							}
							catch
							{
							}
						}
						if (Directory.Exists(Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ss()))
						{
							try
							{
								global::A.m.A(Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ss(), QX, true, global::A.m.A.Bgt);
							}
							catch
							{
							}
						}
					}
					else
					{
						Thread.Sleep(0);
					}
					TJ--;
				}
				else
				{
					Thread.Sleep(1000);
				}
			}
		}

		private void aG()
		{
			if (Directory.Exists(Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Su()))
			{
				try
				{
					global::A.m.A(Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Su(), cR.BlX, true, global::A.m.A.Bgs);
				}
				catch
				{
				}
				if (cR.a())
				{
					cR.B();
				}
			}
		}

		private void ag()
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected O, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			if (!Directory.Exists(Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Su()))
			{
				return;
			}
			try
			{
				Tj = new FileSystemWatcher(Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Su());
				Tj.IncludeSubdirectories = true;
				Tj.NotifyFilter = (NotifyFilters)83;
				Tj.Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SV();
				Tj.Changed += new FileSystemEventHandler(b);
				Tj.Created += new FileSystemEventHandler(C);
				Tj.Deleted += new FileSystemEventHandler(c);
				Tj.Renamed += new RenamedEventHandler(a);
				Tj.EnableRaisingEvents = true;
			}
			catch
			{
			}
		}

		private void b(object P_0, FileSystemEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)P_1.ChangeType == 4)
			{
				aG();
			}
		}

		private void C(object P_0, FileSystemEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)P_1.ChangeType == 1)
			{
				aG();
			}
		}

		private void c(object P_0, FileSystemEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)P_1.ChangeType == 2)
			{
				aG();
			}
		}

		private void a(object P_0, RenamedEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)((FileSystemEventArgs)P_1).ChangeType == 8)
			{
				aG();
			}
		}

		private void aH(object P_0, EventArgs P_1)
		{
			if (global::A.A.c().Count == 1)
			{
				if (Qz != null)
				{
					w();
					d();
				}
				A((BackgroundWorker)null, -1);
			}
		}

		internal void A(BackgroundWorker P_0, int P_1)
		{
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			if (Qz == null || !Qz.c())
			{
				return;
			}
			Qz.C(Qz.aWS);
			Qz.A(0L);
			lock (qh)
			{
				qI |= 32;
				qI |= 4;
			}
			if (P_0 == null)
			{
				BackgroundWorker val = new BackgroundWorker
				{
					WorkerReportsProgress = true
				};
				val.DoWork += new DoWorkEventHandler(O);
				object obj = BM.t.Bqk;
				if (obj == null)
				{
					ProgressChangedEventHandler val2 = a;
					BM.t.Bqk = val2;
					obj = (object)val2;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj;
				val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(o);
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sv());
				val.RunWorkerAsync((object)(-1));
			}
			else
			{
				DoWorkEventArgs val3 = new DoWorkEventArgs((object)P_1);
				O(P_0, val3);
				o((object)P_0, new RunWorkerCompletedEventArgs(val3.Result, (System.Exception)null, false));
			}
		}

		private void O(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			int num = (int)P_1.Argument;
			P_1.Result = false;
			int bF;
			try
			{
				bF = (int)SI[0].BpS.@as[35].BF;
			}
			catch
			{
				return;
			}
			int num2 = 0;
			lock (Si)
			{
				Qz.P();
				bool flag;
				do
				{
					int num3 = 0;
					flag = Qz.a(ref num3);
					num2 = Math.Min(num2 + num3, bF);
					int num4 = num2 * 100 / bF;
					if (!flag || num3 != 0)
					{
						if (num == -1)
						{
							val.ReportProgress(num4);
						}
						else
						{
							val.ReportProgress(num4, (object)num);
						}
					}
					if (!A(Qz.aXc, false))
					{
						return;
					}
					if (num4 != 100)
					{
						Thread.Sleep(0);
					}
					else
					{
						Thread.Sleep(200);
					}
				}
				while (flag || num2 < bF);
			}
			num2 = 0;
			int bF2;
			try
			{
				bF2 = (int)SI[0].BpS.@as[33].BF;
			}
			catch
			{
				return;
			}
			if (!Qz.R())
			{
				return;
			}
			do
			{
				int num5 = 0;
				if (!Qz.A(ref num5))
				{
					return;
				}
				num2 = Math.Min(num2 + num5, bF2);
				if (!A(Qz.aXc, false))
				{
					return;
				}
			}
			while (num2 < bF2);
			P_1.Result = true;
		}

		private void o(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected O, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected O, but got Unknown
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected O, but got Unknown
			P();
			if ((bool)P_1.Result)
			{
				if (Qz.awv.Count != 0)
				{
					BackgroundWorker val = new BackgroundWorker
					{
						WorkerReportsProgress = true
					};
					val.DoWork += new DoWorkEventHandler(o);
					object obj = BM.t.Bqk;
					if (obj == null)
					{
						ProgressChangedEventHandler val2 = a;
						BM.t.Bqk = val2;
						obj = (object)val2;
					}
					val.ProgressChanged += (ProgressChangedEventHandler)obj;
					val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(P);
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SW());
					val.RunWorkerAsync();
					return;
				}
				lock (qh)
				{
					qI &= -33;
					qI &= -3;
				}
				Qz.c(Qz.aWS);
				BackgroundWorker val3 = new BackgroundWorker
				{
					WorkerReportsProgress = true
				};
				val3.DoWork += new DoWorkEventHandler(P);
				object obj2 = BM.t.Bqk;
				if (obj2 == null)
				{
					ProgressChangedEventHandler val4 = a;
					BM.t.Bqk = val4;
					obj2 = (object)val4;
				}
				val3.ProgressChanged += (ProgressChangedEventHandler)obj2;
				val3.RunWorkerCompleted += new RunWorkerCompletedEventHandler(p);
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sw());
				val3.RunWorkerAsync();
			}
			else
			{
				Qz.c(Qz.aWS);
				b(true);
			}
		}

		private void o(object P_0, DoWorkEventArgs P_1)
		{
			P_1.Result = null;
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			if (!A(Qu, out var text))
			{
				global::A.N.A(text, true);
			}
			System.Array values = System.Enum.GetValues(typeof(global::A.A.C));
			int num = 100 / values.Length;
			for (int i = 0; i < values.Length; i++)
			{
				global::A.A.C c = (global::A.A.C)values.GetValue(i);
				if (c == global::A.A.C.BFI)
				{
					continue;
				}
				int num2 = i * num;
				val.ReportProgress(num2);
				global::A.j[] array = a(c);
				List<global::A.j> val2 = new List<global::A.j>();
				if (array != null)
				{
					global::A.j[] array2 = array;
					foreach (global::A.j j2 in array2)
					{
						if (j2.a().StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG()))
						{
							val2.Add(j2);
						}
					}
				}
				int num3 = num2 + num / 10;
				val.ReportProgress(num3);
				for (int k = 0; k < val2.Count; k++)
				{
					global::A.j j3 = val2[k];
					string text2 = j3.a().Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG().Length);
					if (c == global::A.A.C.BFH && CD.aZd.ContainsKey(text2) && CD.aZd[text2] == j3.CH)
					{
						global::A.A.A(Qz.aXc, j3, out var _, out var _);
					}
					else
					{
						string text3 = Di.B(j3.Cg);
						if (text3 != null)
						{
							byte[] array3 = null;
							string text4;
							bool flag2 = A(Qz, j3, text3, out text4, out array3);
							if (array3 == null || !flag2)
							{
								array3 = A(j3, out var text5);
								if (text5 != null)
								{
									if (P_1.Result == null)
									{
										P_1.Result = text5;
									}
									else
									{
										P_1.Result = (string)P_1.Result + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv() + text5;
									}
								}
							}
							if (array3 != null)
							{
								if (!A(Qu, text2, array3, text3, out text))
								{
									global::A.N.A(text, true);
								}
								if (!flag2 && !A(Qz, text2, array3, text3, out text))
								{
									global::A.N.A(text, true);
								}
							}
						}
					}
					if (!A(Qz.aXc, false))
					{
						break;
					}
					val.ReportProgress(num3 + (k + 1) * (num * 9 / 10) / val2.Count);
				}
			}
			val.ReportProgress(100);
			Thread.Sleep(500);
		}

		private byte[] A(global::A.j P_0, out string P_1)
		{
			P_1 = null;
			do
			{
				if (global::A.A.A(Qz.aXc, P_0, 0u, P_0.CH, out var b, out var result, out var flag))
				{
					if (b == global::A.A.b.BFC)
					{
						return result;
					}
					P_1 = string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SX(),
						P_0.a(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sx(),
						global::A.A.A(b),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
					});
					return null;
				}
				if (flag)
				{
					return null;
				}
			}
			while (A(Qz.aXc, false));
			return null;
		}

		private void P(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			P();
			lock (qh)
			{
				qI &= -33;
				qI &= -3;
			}
			Qz.c(Qz.aWS);
			if (!qW)
			{
				string text = P_1.Result as string;
				if (!string.IsNullOrWhiteSpace(text))
				{
					bE.A((IWin32Window)(object)this, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.DoWork += new DoWorkEventHandler(P);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(p);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sw());
			val.RunWorkerAsync();
		}

		private void P(object P_0, DoWorkEventArgs P_1)
		{
			object obj = ((P_0 is BackgroundWorker) ? P_0 : null);
			((BackgroundWorker)obj).ReportProgress(0);
			Thread.Sleep(100);
			((BackgroundWorker)obj).ReportProgress(30);
			Qz.N();
			((BackgroundWorker)obj).ReportProgress(40);
			Qz.a(Qz.awj);
			Qz.a((HashSet<DataIdAndAttrId>)null);
			((BackgroundWorker)obj).ReportProgress(80);
			Qz.A(null, Qn, qf);
			((BackgroundWorker)obj).ReportProgress(90);
			Qz.A((HashSet<DataIdAndAttrId>)null);
			Thread.Sleep(100);
			((BackgroundWorker)obj).ReportProgress(100);
		}

		private void p(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Expected O, but got Unknown
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Expected O, but got Unknown
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Expected O, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected O, but got Unknown
			if (!qW)
			{
				P();
			}
			if (qU != null)
			{
				G(qU);
			}
			else if (qu)
			{
				aH();
			}
			else if (qt != null)
			{
				f(qt);
			}
			if (!qW)
			{
				if (Qz.awZ == 21)
				{
					cb.A(Qz, null);
					cb.a();
					if (Qz.awP.h())
					{
						cb.B();
					}
				}
				Qz.A((IWin32Window)(object)QQ);
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				if (Qz.C())
				{
					if (Bz.A(Qz))
					{
						if (Qz.A(16035).ax() == 0)
						{
							BackgroundWorker val = new BackgroundWorker
							{
								WorkerReportsProgress = true
							};
							val.DoWork += new DoWorkEventHandler(p);
							object obj = BM.t.Bqk;
							if (obj == null)
							{
								ProgressChangedEventHandler val2 = a;
								BM.t.Bqk = val2;
								obj = (object)val2;
							}
							val.ProgressChanged += (ProgressChangedEventHandler)obj;
							val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Q);
							C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SY());
							val.RunWorkerAsync();
							return;
						}
						flag4 = Bz.A(Qz, out flag, out flag2, out flag3);
					}
					else
					{
						Dh.A(Qz, out flag5);
					}
				}
				if (!flag3)
				{
					A(flag5, flag4, flag, flag2);
				}
			}
			if (qP != null)
			{
				BackgroundWorker val3 = new BackgroundWorker();
				val3.DoWork += new DoWorkEventHandler(h);
				val3.RunWorkerCompleted += new RunWorkerCompletedEventHandler(H);
				val3.RunWorkerAsync();
			}
			else if (qV != null)
			{
				BackgroundWorker val4 = new BackgroundWorker();
				val4.DoWork += new DoWorkEventHandler(D);
				val4.RunWorkerCompleted += new RunWorkerCompletedEventHandler(D);
				val4.RunWorkerAsync();
			}
		}

		private void A(bool P_0, bool P_1, bool P_2, bool P_3)
		{
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Invalid comparison between Unknown and I4
			if (P_2 || P_0)
			{
				b(true);
			}
			else
			{
				if (!a(true))
				{
					return;
				}
				((ToolStripItem)rm).Enabled = true;
				((ToolStripItem)rN).Enabled = true;
				((ToolStripItem)rM).Enabled = true;
				((ToolStripItem)rR).Enabled = true;
				((ToolStripItem)rt).Enabled = true;
				((ToolStripItem)Ri).Enabled = true;
				((ToolStripItem)RZ).Enabled = true;
				((ToolStripItem)Sb).Enabled = true;
				((ToolStripItem)Sc).Enabled = true;
				((ToolStripItem)SC).Enabled = true;
				E();
				QZ = string.Empty;
				A(true);
				B(Qz);
				if (Be.nv && (qI & 0x800) == 0)
				{
					TG.A();
				}
				if (qP != null)
				{
					return;
				}
				CX cX = new CX();
				cX.BdC = new bW
				{
					axS = Qz.awZ,
					axs = Qz.awz,
					axT = Qz.aXA,
					axt = Qz.F()
				};
				cX.Bdc = new List<ushort>();
				global::A.F f = global::A.A.e(Qz.aXc);
				if (f != null)
				{
					cX.Bdc.Add(f.aJ);
				}
				if (Ct.A(cX, out var text, out var _))
				{
					string text2 = (string.IsNullOrEmpty(text) ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.km() : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kM() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy()));
					if ((int)bE.A((IWin32Window)(object)QQ, string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sy(),
						((object)Qz.aXA).ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IV(),
						text2,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.SZ()
					}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kn(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
					{
						z(null, null);
					}
				}
				else if (P_1 && ((ToolStripItem)QQ.rc).Enabled && !P_3)
				{
					((ToolStripItem)QQ.rc).PerformClick();
				}
			}
		}

		private void p(object P_0, DoWorkEventArgs P_1)
		{
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			bool flag = false;
			global::A.F f = global::A.A.e(Qz.aXc);
			if (f != null)
			{
				global::A.k k = null;
				if (f.aK != 255 || f.ak != 255 || f.aL != 255 || f.al != 255)
				{
					k = new global::A.k(f.aK, f.ak, f.aL, f.al, 0);
				}
				while (bj.e())
				{
					Thread.Sleep(1000);
				}
				int? num;
				UpdateOutcomes updateOutcomes;
				string text = bj.A(Qz.awZ, Qz.awz, out num, out updateOutcomes);
				if (num.HasValue && updateOutcomes == UpdateOutcomes.CompleteUpdate && !string.IsNullOrEmpty(text))
				{
					CY cY = CZ.A(text, Qz.awZ, Qz.awz, f.aJ, f.ao, k, bt.avK, null, false);
					if (cY != null)
					{
						Enumerator<CX> enumerator = cY.BdF.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								CX current = enumerator.Current;
								if (current.BdC.axS == Qz.awZ && current.BdC.axs == Qz.awz && current.BdC.axT > Qz.aXA && (CZ.b(f.ao) || current.Bdc.Contains(f.aJ)))
								{
									flag = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
					val.ReportProgress(100);
					Thread.Sleep(500);
				}
				else
				{
					if (qx != null && qx.IsBusy)
					{
						qx.CancelAsync();
						Thread.Sleep(200);
					}
					List<CY> val2 = CZ.A(val, Qz.awZ, Qz.awz, Qz.aXA, f.aJ, f.ao, k, true, bt.avK, null, false);
					if (A(Qz, val2))
					{
						flag = true;
					}
				}
			}
			P_1.Result = flag;
		}

		private void Q(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Invalid comparison between Unknown and I4
			P();
			if ((bool)P_1.Result && (int)bE.A((IWin32Window)(object)QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Sz(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gO(), (MessageBoxButtons)4) == 6)
			{
				QQ.z(null, null);
				return;
			}
			bool flag;
			bool flag2;
			bool flag3;
			bool flag4 = Bz.A(Qz, out flag, out flag2, out flag3);
			if (!flag3)
			{
				A(false, flag4, flag, flag2);
			}
		}

		private void f(string P_0)
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				new CR(P_0, Qz, true).A();
				string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sA() + P_0;
				if (qW)
				{
					Console.WriteLine();
					Console.WriteLine(text);
					Environment.Exit(0);
				}
				else
				{
					bE.A((IWin32Window)(object)this, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sa(), (MessageBoxButtons)0, (MessageBoxIcon)0);
				}
			}
			catch (System.Exception ex)
			{
				string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sB() + P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sb() + ex.Message;
				if (qW)
				{
					Console.WriteLine();
					Console.WriteLine(text2);
					Environment.Exit(1);
				}
				else
				{
					bE.A((IWin32Window)(object)this, text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			qt = null;
		}

		private void G(string P_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.DoWork += new DoWorkEventHandler(Q);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(q);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sC());
			val.RunWorkerAsync((object)P_0);
		}

		private void Q(object P_0, DoWorkEventArgs P_1)
		{
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Expected O, but got Unknown
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			string text = P_1.Argument as string;
			string empty = string.Empty;
			bool flag = false;
			try
			{
				bW bW = Cq.a(text);
				val.ReportProgress(10);
				Thread.Sleep(0);
				string text2 = bT.A(bW.axS, bW.axs, bW.axT, bW.axt, true);
				val.ReportProgress(20);
				Thread.Sleep(0);
				Framework framework = new Framework(text2, bW.axS, bW.axs, bW.axT);
				bV.A a = framework.a();
				val.ReportProgress(50);
				Thread.Sleep(0);
				if (a != 0)
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sD() + ((object)a).ToString());
				}
				new Cq(text, framework).A(out var _, false, false, true);
				val.ReportProgress(70);
				Thread.Sleep(0);
				StringBuilder val2 = new StringBuilder();
				A(Qz.aWS, framework, val2);
				string text4 = ((object)val2).ToString();
				flag = string.IsNullOrEmpty(text4);
				empty = (flag ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sc() + text) : text4);
			}
			catch (System.Exception ex)
			{
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sd() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sE() + ex.Message;
			}
			val.ReportProgress(100);
			Thread.Sleep(500);
			Q q = default(Q);
			q.BqD = empty;
			q.Bqc = flag;
			Q q2 = q;
			P_1.Result = q2;
		}

		private void q(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			P();
			Q q = (Q)P_1.Result;
			if (qW)
			{
				Console.WriteLine();
				Console.WriteLine(q.BqD);
				if (q.Bqc)
				{
					Environment.Exit(0);
				}
				else
				{
					Environment.Exit(1);
				}
			}
			else
			{
				bE.A((IWin32Window)(object)this, q.BqD, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.se(), (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			qU = null;
		}

		private void aH()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.DoWork += new DoWorkEventHandler(q);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(R);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sF());
			val.RunWorkerAsync();
		}

		private void q(object P_0, DoWorkEventArgs P_1)
		{
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			string empty = string.Empty;
			bool flag = false;
			try
			{
				Framework framework = new Framework(Qz.e(), Qz.awZ, Qz.awz, Qz.aXA);
				bV.A a = framework.a();
				val.ReportProgress(30);
				Thread.Sleep(0);
				if (a != 0)
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sG() + ((object)a).ToString());
				}
				framework.A(framework.aWS);
				val.ReportProgress(50);
				Thread.Sleep(0);
				StringBuilder val2 = new StringBuilder();
				A(Qz.aWS, framework, val2);
				string text = ((object)val2).ToString();
				flag = string.IsNullOrEmpty(text);
				empty = (flag ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sf() : text);
			}
			catch (System.Exception ex)
			{
				empty = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sg() + ex.Message;
			}
			val.ReportProgress(100);
			Thread.Sleep(500);
			Q q = default(Q);
			q.BqD = empty;
			q.Bqc = flag;
			Q q2 = q;
			P_1.Result = q2;
		}

		private void R(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			P();
			Q q = (Q)P_1.Result;
			if (qW)
			{
				Console.WriteLine();
				Console.WriteLine(q.BqD);
				if (q.Bqc)
				{
					Environment.Exit(0);
				}
				else
				{
					Environment.Exit(1);
				}
			}
			else
			{
				bE.A((IWin32Window)(object)this, q.BqD, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sH(), (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			qu = false;
		}

		private void A(List<SettingOrSpecialObject> P_0, Framework P_1, StringBuilder P_2)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<SettingOrSpecialObject> enumerator = P_0.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					SettingOrSpecialObject current = enumerator.Current;
					if (current is Table)
					{
						Table table = current as Table;
						Setting setting = P_1.A(((Setting)table).A());
						if (setting != null)
						{
							Table compareTable = setting as Table;
							table.CompareWithAnotherCorrespondingTable(compareTable, P_2);
						}
						continue;
					}
					if (current is Setting)
					{
						Setting setting2 = P_1.A((current as Setting).C());
						if (setting2 != null)
						{
							(current as Setting).A(setting2, P_2);
						}
					}
					A(current.a(), P_1, P_2);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private void ah(object P_0, EventArgs P_1)
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			if (global::A.A.c().Count == 1)
			{
				if (Qz != null)
				{
					w();
					d();
				}
				lock (qh)
				{
					qI |= 128;
				}
				BackgroundWorker val = new BackgroundWorker
				{
					WorkerReportsProgress = true
				};
				object obj = BM.t.Bqk;
				if (obj == null)
				{
					ProgressChangedEventHandler val2 = a;
					BM.t.Bqk = val2;
					obj = (object)val2;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj;
				val.DoWork += new DoWorkEventHandler(R);
				val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(r);
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ql());
				val.RunWorkerAsync((object)global::A.A.c()[0]);
			}
		}

		private void R(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			global::A.F f = P_1.Argument as global::A.F;
			val.ReportProgress(0);
			q q = new q();
			byte[] array = null;
			try
			{
				byte[] array2 = null;
				do
				{
					if (global::A.A.A(f.ao, global::A.f.aW, 0u, 4u, out var array3, out var flag))
					{
						array2 = array3;
					}
					else if (flag || !A(f.ao, false))
					{
						array2 = null;
						break;
					}
				}
				while (array2 == null);
				uint num = 0u;
				if (array2 == null)
				{
					throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sh());
				}
				num = (uint)(array2[0] << 24) | ((uint)(array2[1] << 16) & 0xFF0000u) | ((uint)(array2[2] << 8) & 0xFF00u) | (array2[3] & 0xFFu);
				array = new byte[num];
				uint num2 = global::A.A.A(f.ao, global::A.f.aW);
				uint num3;
				for (num3 = 0u; num3 < num / num2; num3++)
				{
					bool flag3;
					do
					{
						flag3 = global::A.A.A(f.ao, global::A.f.aW, 4 + num3 * num2, num2, out var array4, out var flag2);
						if (flag3)
						{
							System.Array.Copy((System.Array)array4, 0L, (System.Array)array, (long)(num3 * num2), (long)num2);
							int num4 = (int)(50 * num3 * num2 / num);
							val.ReportProgress(num4);
						}
						else if (flag2 || !A(f.ao, false))
						{
							throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sI());
						}
					}
					while (!flag3);
				}
				uint num5 = num % num2;
				if (num5 != 0)
				{
					bool flag5;
					do
					{
						flag5 = global::A.A.A(f.ao, global::A.f.aW, 4 + num3 * num2, num5, out var array5, out var flag4);
						if (flag5)
						{
							System.Array.Copy((System.Array)array5, 0L, (System.Array)array, (long)(num3 * num2), (long)num5);
						}
						else if (flag4 || !A(f.ao, false))
						{
							throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.si());
						}
					}
					while (!flag5);
				}
				val.ReportProgress(60);
			}
			catch (System.Exception ex)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sJ() + ex.Message, true);
				q.Bqd = bV.A.BrF;
				P_1.Result = q;
				return;
			}
			string text = null;
			bW bW = null;
			try
			{
				text = bT.A(array, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sj(), out bW);
				val.ReportProgress(70);
			}
			catch (System.Exception ex2)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sJ() + ex2.Message, true);
				q.Bqd = bV.A.BrD;
				P_1.Result = q;
				return;
			}
			Framework framework = new Framework(text, bW.axS, bW.axs, bW.axT);
			bV.A a = (q.Bqd = framework.a());
			try
			{
				if (a == bV.A.Brc)
				{
					bT.A(text, framework.awZ, framework.awz, framework.aXA);
					framework.aXc = f.ao;
					q.BqE = framework;
					if (framework.awZ == 21)
					{
						val.ReportProgress(80);
						framework.f();
					}
				}
				else
				{
					File.Delete(text);
				}
			}
			catch (System.Exception ex3)
			{
				global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sJ() + ex3.Message, true);
			}
			P_1.Result = q;
			val.ReportProgress(90);
			Thread.Sleep(100);
			val.ReportProgress(100);
		}

		private void r(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			P();
			lock (qh)
			{
				qI &= -129;
			}
			q q = P_1.Result as q;
			bV.A bqd = q.Bqd;
			if (bqd == bV.A.Brc)
			{
				Qz = q.BqE;
				A((BackgroundWorker)null, -1);
				return;
			}
			string empty = string.Empty;
			bE.A((IWin32Window)(object)this, bqd switch
			{
				bV.A.BrF => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sK(), 
				bV.A.BrD => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sk(), 
				bV.A.Brd => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.NT(), 
				bV.A.BrE => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nt(), 
				bV.A.Bre => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sL(), 
				_ => D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sl(), 
			}, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			b(true);
		}

		private void aI(object P_0, EventArgs P_1)
		{
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			bool flag = false;
			bool flag2 = Cs.b();
			((Control)this).Cursor = Cursors.WaitCursor;
			bool flag3 = Cs.a() || Cs.B();
			((Control)this).Cursor = Cursors.Default;
			if (TK == null)
			{
				if (!flag3)
				{
					return;
				}
				TK = new Cs();
			}
			else if (flag2)
			{
				flag = true;
			}
			else
			{
				if (!flag3)
				{
					return;
				}
				TK = null;
				TK = new Cs();
			}
			Bu bu = new Bu(TK, flag);
			((Form)bu).ShowDialog((IWin32Window)(object)this);
			((Component)bu).Dispose();
		}

		private void ai(object P_0, EventArgs P_1)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Invalid comparison between Unknown and I4
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			if (Qz != null && Qz.C() && (int)A((IWin32Window)(object)this, true) != 2)
			{
				BackgroundWorker val = new BackgroundWorker
				{
					WorkerReportsProgress = true
				};
				val.DoWork += new DoWorkEventHandler(r);
				object obj = BM.t.Bqk;
				if (obj == null)
				{
					ProgressChangedEventHandler val2 = a;
					BM.t.Bqk = val2;
					obj = (object)val2;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj;
				val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(S);
				C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ni());
				bool flag = false;
				val.RunWorkerAsync((object)flag);
			}
		}

		private void r(object P_0, DoWorkEventArgs P_1)
		{
			global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sM(), true);
			object obj = ((P_0 is BackgroundWorker) ? P_0 : null);
			((BackgroundWorker)obj).ReportProgress(0);
			Framework framework = new Framework(Qz.e(), Qz.awZ, Qz.awz, Qz.aXA);
			((BackgroundWorker)obj).ReportProgress(10);
			bV.A a = framework.a();
			((BackgroundWorker)obj).ReportProgress(60);
			R r = default(R);
			if (a == bV.A.Brc)
			{
				framework.A(framework.aWS);
				framework.a(framework.awj);
				r.Bqe = framework;
				bool bqf = false;
				if (P_1.Argument != null && P_1.Argument is bool)
				{
					bqf = (bool)P_1.Argument;
				}
				r.Bqf = bqf;
				r.BqF = true;
			}
			else
			{
				r.BqF = false;
			}
			P_1.Result = r;
			((BackgroundWorker)obj).ReportProgress(90);
			Thread.Sleep(100);
			((BackgroundWorker)obj).ReportProgress(100);
		}

		private void S(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Invalid comparison between Unknown and I4
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Invalid comparison between Unknown and I4
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Invalid comparison between Unknown and I4
			R r = (R)P_1.Result;
			global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sm() + r.BqF + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), true);
			P();
			if (r.BqF)
			{
				w();
				d();
				lock (qh)
				{
					qI |= 64;
				}
				Bj bj = new Bj(string.Empty, true, r.Bqf, r.Bqe, Qz);
				DialogResult val = ((Form)bj).ShowDialog((IWin32Window)(object)this);
				bool flag = bj.b();
				string text = bj.C();
				string text2 = bj.c();
				((Component)bj).Dispose();
				if ((int)val == 3)
				{
					lock (qh)
					{
						qI &= -65;
						return;
					}
				}
				if (Qz.awZ == 21 && Qz.f())
				{
					cb.A(Qz, null);
					cb.a();
					if (Qz.awP.h())
					{
						cb.B();
					}
				}
				Qz.A((IWin32Window)(object)QQ);
				E();
				if ((int)val == 1 || (int)val == 6)
				{
					if (flag)
					{
						A(text, text2, Qz);
					}
					if (A(Qz.aXc, true))
					{
						A(null, -1, true);
						return;
					}
					lock (qh)
					{
						qI &= -65;
					}
					Qz.p();
					bool flag2 = false;
					bool flag3 = false;
					if (Qz.C())
					{
						Bz.A(Qz, out flag2, out var _, out flag3);
					}
					if (!flag2 && !flag3)
					{
						a(false);
					}
				}
				else
				{
					a(false);
					lock (qh)
					{
						qI &= -65;
					}
					if (r.Bqf)
					{
						QM = BM.a.BpC;
					}
				}
			}
			else
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sN(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private static void ah()
		{
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Invalid comparison between Unknown and I4
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Invalid comparison between Unknown and I4
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Invalid comparison between Unknown and I4
			string empty = string.Empty;
			if (Qz.A(ref empty))
			{
				string text = A(empty, Qz.aXc);
				if (string.IsNullOrEmpty(text))
				{
					try
					{
						string text2 = empty;
						List<string> obj = new List<string>();
						obj.Add(Qz.aXc);
						text = a(text2, obj);
						Qz.aXD = text;
						((FileDialog)Tk).InitialDirectory = text;
					}
					catch
					{
						((FileDialog)Tk).InitialDirectory = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
					}
				}
				else
				{
					((FileDialog)Tk).InitialDirectory = text;
				}
			}
			else
			{
				((FileDialog)Tk).InitialDirectory = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
			}
			((FileDialog)Tk).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sn();
			((FileDialog)Tk).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ng();
			((FileDialog)Tk).AddExtension = true;
			Tk.OverwritePrompt = false;
			string text3 = bx.a(Qz.awZ, Qz.awz, Qz.aXA);
			string text4;
			do
			{
				text4 = null;
				((FileDialog)Tk).FileName = global::A.N.A(false) + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu();
				if ((int)((CommonDialog)Tk).ShowDialog((IWin32Window)(object)QQ) != 1)
				{
					return;
				}
				try
				{
					text4 = ((FileDialog)Tk).FileName;
				}
				catch (PathTooLongException)
				{
					bE.A((IWin32Window)(object)QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sO(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.so(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					text4 = null;
					continue;
				}
				if (!text4.EndsWith(text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu()))
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text4);
					int num = fileNameWithoutExtension.LastIndexOf('.');
					if (text4.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu()))
					{
						text4 = text4.Substring(0, text4.Length - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu().Length);
					}
					if (num != -1)
					{
						string text5 = fileNameWithoutExtension.Substring(num, fileNameWithoutExtension.Length - num);
						string[] array = bx.B();
						bool flag = false;
						string[] array2 = array;
						foreach (string text6 in array2)
						{
							if (text5.StartsWith(text6))
							{
								flag = true;
								if ((int)bE.A((IWin32Window)(object)QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sP(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ks(), (MessageBoxButtons)4, (MessageBoxIcon)48) == 6)
								{
									text4 = text4.Substring(0, text4.LastIndexOf(text5)) + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu();
									break;
								}
								text4 = null;
							}
						}
						if (text4 != null && !flag)
						{
							text4 = text4 + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu();
						}
					}
					else
					{
						text4 = text4 + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu();
					}
				}
				if (File.Exists(text4) && (int)bE.A((IWin32Window)(object)QQ, Path.GetFileName(text4) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sp(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sQ(), (MessageBoxButtons)4, (MessageBoxIcon)48, (MessageBoxDefaultButton)256) == 7)
				{
					text4 = null;
				}
				if (text4 != null)
				{
					CR cR = new CR(text4, Qz, true);
					try
					{
						cR.A();
					}
					catch (PathTooLongException)
					{
						bE.A((IWin32Window)(object)QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sO(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.so(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						text4 = null;
					}
				}
			}
			while (text4 == null);
			((ToolStripItem)QQ.rm).Enabled = true;
			((ToolStripItem)QQ.rN).Enabled = true;
			Qz.aXd = false;
			QZ = text4;
			A(true);
			TE.A(text4);
		}

		private static void aI()
		{
			if (Qz == null)
			{
				return;
			}
			if (QZ == string.Empty)
			{
				ah();
				return;
			}
			string empty = string.Empty;
			if (Qz.A(ref empty))
			{
				string text = A(empty, Qz.aXc);
				if (string.IsNullOrEmpty(text))
				{
					try
					{
						string text2 = empty;
						List<string> obj = new List<string>();
						obj.Add(Qz.aXc);
						text = a(text2, obj);
						Qz.aXD = text;
					}
					catch
					{
					}
				}
			}
			new CR(QZ, Qz, true).A();
			Qz.aXd = false;
			A(true);
		}

		private void aJ(object P_0, EventArgs P_1)
		{
			ah();
		}

		private void aj(object P_0, EventArgs P_1)
		{
			aI();
		}

		internal static DialogResult A(IWin32Window P_0, bool P_1)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Invalid comparison between Unknown and I4
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Invalid comparison between Unknown and I4
			if (Qz == null || !Qz.aXd || qW)
			{
				return (DialogResult)7;
			}
			DialogResult val;
			if (TL)
			{
				val = (DialogResult)7;
				ai();
			}
			else
			{
				MessageBoxButtons val2 = ((!P_1) ? ((MessageBoxButtons)4) : ((MessageBoxButtons)3));
				val = bE.A(P_0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sq(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sR(), val2, (MessageBoxIcon)48, (MessageBoxDefaultButton)0, new string[3]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.oK(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sr(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV()
				});
				if ((int)val == 6)
				{
					aI();
				}
				else if ((int)val == 7)
				{
					ai();
				}
			}
			return val;
		}

		private static string ai()
		{
			string empty = string.Empty;
			string text3;
			if (Qz.A(ref empty))
			{
				string text = A(empty, Qz.aXc);
				if (string.IsNullOrEmpty(text))
				{
					try
					{
						string text2 = empty;
						List<string> obj = new List<string>();
						obj.Add(Qz.aXc);
						text = a(text2, obj);
						Qz.aXD = text;
						text3 = text;
					}
					catch
					{
						text3 = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
					}
				}
				else
				{
					text3 = text;
				}
			}
			else
			{
				text3 = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
			}
			string text4 = string.Concat(new string[5]
			{
				text3,
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sS(),
				global::A.N.A(false),
				bx.a(Qz.awZ, Qz.awz, Qz.aXA),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu()
			});
			if (File.Exists(text4))
			{
				text4 = string.Concat(new string[5]
				{
					text3,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sS(),
					global::A.N.A(true),
					bx.a(Qz.awZ, Qz.awz, Qz.aXA),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bu()
				});
			}
			if (!Directory.Exists(text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ss()))
			{
				Directory.CreateDirectory(text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ss());
			}
			new CR(text4, Qz, true).A();
			return text4;
		}

		private void aJ()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Expected O, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			if (Directory.Exists(Qx))
			{
				try
				{
					Tl = new FileSystemWatcher(Qx);
					Tl.IncludeSubdirectories = true;
					Tl.NotifyFilter = (NotifyFilters)91;
					Tl.Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sT();
					Tl.Changed += new FileSystemEventHandler(D);
					Tl.Created += new FileSystemEventHandler(d);
					Tl.Deleted += new FileSystemEventHandler(E);
					Tl.Renamed += new RenamedEventHandler(B);
					Tl.EnableRaisingEvents = true;
				}
				catch (System.Exception ex)
				{
					global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.st() + ex.Message, true);
				}
			}
			if (Directory.Exists(QY))
			{
				try
				{
					FileSystemWatcher val = new FileSystemWatcher(QY)
					{
						IncludeSubdirectories = true,
						NotifyFilter = (NotifyFilters)91,
						Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sT()
					};
					val.Changed += new FileSystemEventHandler(D);
					val.Created += new FileSystemEventHandler(d);
					val.Deleted += new FileSystemEventHandler(E);
					val.Renamed += new RenamedEventHandler(B);
					val.EnableRaisingEvents = true;
				}
				catch (System.Exception ex2)
				{
					global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.st() + ex2.Message, true);
				}
			}
		}

		private void D(object P_0, FileSystemEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)P_1.ChangeType == 4)
			{
				g(P_1.FullPath);
			}
		}

		private void d(object P_0, FileSystemEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)P_1.ChangeType == 1)
			{
				g(P_1.FullPath);
			}
		}

		private void E(object P_0, FileSystemEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)P_1.ChangeType == 2)
			{
				g(P_1.FullPath);
			}
		}

		private void B(object P_0, RenamedEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)((FileSystemEventArgs)P_1).ChangeType == 8)
			{
				g(((FileSystemEventArgs)P_1).FullPath);
			}
		}

		private void g(string P_0)
		{
			if (!TM || !P_0.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sU()))
			{
				return;
			}
			string text = null;
			try
			{
				text = Path.GetFullPath(P_0);
			}
			catch
			{
				text = null;
			}
			lock (qb)
			{
				if (text != null && !Tm.Contains(text))
				{
					Tm.Add(text);
				}
			}
		}

		private void aj()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			BackgroundWorker val = new BackgroundWorker();
			val.DoWork += new DoWorkEventHandler(S);
			val.RunWorkerAsync();
		}

		private void S(object P_0, DoWorkEventArgs P_1)
		{
			Thread.CurrentThread.Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.su();
			while (!qw)
			{
				if (Tm.Count != 0 || !TM)
				{
					lock (qb)
					{
						A(Co.A(TM ? Tm : null));
						TM = true;
						Tm.Clear();
					}
				}
				else
				{
					Thread.Sleep(1000);
				}
			}
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void F(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = TN;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref TN, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void f(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = TN;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref TN, val3, val2);
			}
			while (val != val2);
		}

		internal static void A(string P_0, CO P_1)
		{
			if (!qB.ContainsKey(P_0))
			{
				qB.Add(P_0, P_1);
			}
			if (TN != null)
			{
				TN.Invoke((object)null, (EventArgs)null);
			}
		}

		internal static void A(Dictionary<string, CO> P_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			Enumerator<string, CO> enumerator = P_0.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (!qB.ContainsKey(current))
					{
						qB.Add(current, P_0[current]);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (TN != null)
			{
				TN.Invoke((object)null, (EventArgs)null);
			}
		}

		internal void aK()
		{
			if (File.Exists(Qs))
			{
				StreamReader val = File.OpenText(Qs);
				try
				{
					int num = -1;
					int num2 = -1;
					string text;
					while ((text = ((TextReader)val).ReadLine()) != null)
					{
						if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sV()))
						{
							num2 = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sV().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sv()))
						{
							num = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sv().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sW()))
						{
							TO = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sW().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sw()))
						{
							Tp = (S)int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sw().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sX()))
						{
							Tt = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sX().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sx()))
						{
							TU = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sx().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sY()))
						{
							Tu = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sY().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sy()))
						{
							TV = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sy().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sZ()))
						{
							Tv = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sZ().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sz()))
						{
							TW = int.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sz().Length));
						}
						else if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TA()))
						{
							Tw = bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TA().Length));
						}
					}
					if (num2 != -1 && System.Enum.IsDefined(typeof(r), (object)num2))
					{
						Tn = (r)num2;
					}
					else if (num != -1 && System.Enum.IsDefined(typeof(r), (object)num))
					{
						Tn = (r)num;
					}
					else
					{
						Tn = BM.r.BqH;
					}
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			else
			{
				Tn = BM.r.BqH;
				TO = false;
			}
			c(true);
		}

		internal void ak()
		{
			if (!Directory.Exists(QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
			{
				Directory.CreateDirectory(QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
			}
			((Stream)File.Create(Qs)).Close();
			List<string> val = new List<string>();
			int num;
			if (Tn > BM.r.BqH)
			{
				if (Tn == BM.r.Bqh)
				{
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sv() + 0);
				}
				else
				{
					val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sv() + 2);
				}
			}
			else
			{
				string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sv();
				num = (int)Tn;
				val.Add(text + num);
			}
			string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sV();
			num = (int)Tn;
			val.Add(text2 + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sW() + TO);
			string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sw();
			num = (int)Tp;
			val.Add(text3 + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sX() + Tt);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sx() + TU);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sY() + Tu);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sy() + TV);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sZ() + Tv);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sz() + TW);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TA() + Tw);
			File.AppendAllLines(Qs, (System.Collections.Generic.IEnumerable<string>)val);
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void G(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = tS;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Combine((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref tS, val3, val2);
			}
			while (val != val2);
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void g(EventHandler P_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			EventHandler val = tS;
			EventHandler val2;
			do
			{
				val2 = val;
				EventHandler val3 = (EventHandler)System.Delegate.Remove((System.Delegate)(object)val2, (System.Delegate)(object)P_0);
				val = Interlocked.CompareExchange<EventHandler>(ref tS, val3, val2);
			}
			while (val != val2);
		}

		private void c(bool P_0)
		{
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_030f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0314: Unknown result type (might be due to invalid IL or missing references)
			//IL_0319: Unknown result type (might be due to invalid IL or missing references)
			//IL_031e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0329: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Unknown result type (might be due to invalid IL or missing references)
			//IL_038b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0390: Unknown result type (might be due to invalid IL or missing references)
			//IL_0395: Unknown result type (might be due to invalid IL or missing references)
			//IL_039a: Unknown result type (might be due to invalid IL or missing references)
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03db: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Unknown result type (might be due to invalid IL or missing references)
			//IL_040d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0412: Unknown result type (might be due to invalid IL or missing references)
			//IL_0417: Unknown result type (might be due to invalid IL or missing references)
			//IL_041c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0421: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Unknown result type (might be due to invalid IL or missing references)
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0430: Unknown result type (might be due to invalid IL or missing references)
			//IL_0435: Unknown result type (might be due to invalid IL or missing references)
			//IL_043a: Unknown result type (might be due to invalid IL or missing references)
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0444: Unknown result type (might be due to invalid IL or missing references)
			//IL_0449: Unknown result type (might be due to invalid IL or missing references)
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Unknown result type (might be due to invalid IL or missing references)
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0462: Unknown result type (might be due to invalid IL or missing references)
			//IL_0467: Unknown result type (might be due to invalid IL or missing references)
			//IL_046c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0471: Unknown result type (might be due to invalid IL or missing references)
			//IL_0476: Unknown result type (might be due to invalid IL or missing references)
			//IL_047b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0480: Unknown result type (might be due to invalid IL or missing references)
			//IL_0485: Unknown result type (might be due to invalid IL or missing references)
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_049a: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0501: Unknown result type (might be due to invalid IL or missing references)
			//IL_0506: Unknown result type (might be due to invalid IL or missing references)
			//IL_050b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Unknown result type (might be due to invalid IL or missing references)
			//IL_051a: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0524: Unknown result type (might be due to invalid IL or missing references)
			//IL_0529: Unknown result type (might be due to invalid IL or missing references)
			//IL_052e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0533: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Unknown result type (might be due to invalid IL or missing references)
			//IL_053d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0542: Unknown result type (might be due to invalid IL or missing references)
			//IL_0547: Unknown result type (might be due to invalid IL or missing references)
			//IL_054c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0551: Unknown result type (might be due to invalid IL or missing references)
			//IL_0556: Unknown result type (might be due to invalid IL or missing references)
			//IL_055b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0560: Unknown result type (might be due to invalid IL or missing references)
			//IL_0565: Unknown result type (might be due to invalid IL or missing references)
			//IL_056a: Unknown result type (might be due to invalid IL or missing references)
			//IL_056f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0574: Unknown result type (might be due to invalid IL or missing references)
			//IL_0579: Unknown result type (might be due to invalid IL or missing references)
			//IL_057e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0583: Unknown result type (might be due to invalid IL or missing references)
			//IL_0588: Unknown result type (might be due to invalid IL or missing references)
			//IL_058d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0592: Unknown result type (might be due to invalid IL or missing references)
			//IL_0597: Unknown result type (might be due to invalid IL or missing references)
			//IL_059c: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e2c: Expected O, but got Unknown
			//IL_0e2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0efa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e84: Expected O, but got Unknown
			//IL_0f20: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f27: Expected O, but got Unknown
			//IL_0e9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f40: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ffc: Unknown result type (might be due to invalid IL or missing references)
			//IL_100b: Unknown result type (might be due to invalid IL or missing references)
			//IL_101a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1029: Unknown result type (might be due to invalid IL or missing references)
			//IL_1038: Unknown result type (might be due to invalid IL or missing references)
			//IL_1047: Unknown result type (might be due to invalid IL or missing references)
			//IL_1056: Unknown result type (might be due to invalid IL or missing references)
			//IL_105b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f76: Expected O, but got Unknown
			//IL_1066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f9b: Unknown result type (might be due to invalid IL or missing references)
			if (qW)
			{
				return;
			}
			if (TO)
			{
				rQ.BorderStyle = (BorderStyle)1;
				((Panel)rq).BorderStyle = (BorderStyle)1;
				((Panel)Rh).BorderStyle = (BorderStyle)1;
				((Panel)RI).BorderStyle = (BorderStyle)1;
				((Panel)Rq).BorderStyle = (BorderStyle)1;
			}
			else
			{
				rQ.BorderStyle = (BorderStyle)0;
				((Panel)rq).BorderStyle = (BorderStyle)0;
				((Panel)Rh).BorderStyle = (BorderStyle)0;
				((Panel)RI).BorderStyle = (BorderStyle)0;
				((Panel)Rq).BorderStyle = (BorderStyle)0;
			}
			TX = (Tx = (TY = 0f));
			switch (Tn)
			{
			case BM.r.BqG:
				TX = 0.2f;
				Tx = 0.2f;
				TY = 0.2f;
				td = SystemColors.ControlLight;
				tE = SystemColors.Control;
				te = Color.Black;
				tF = Color.Blue;
				tf = Color.Black;
				tG = Color.White;
				tg = Color.White;
				tH = Color.White;
				ti = Color.White;
				th = Color.Black;
				tI = Ty;
				tJ = Color.White;
				tj = Color.LightGray;
				tK = Color.Black;
				tk = Color.Black;
				tL = Color.Black;
				tn = Color.White;
				tO = Color.DodgerBlue;
				to = Color.White;
				tQ = Color.LightGray;
				tq = Color.Gray;
				((Control)Rh).BackColor = Color.White;
				((Control)RI).BackColor = Color.White;
				((Control)Rq).BackColor = Color.White;
				((Control)rq).BackColor = Color.White;
				break;
			case BM.r.Bqg:
				TX = 0.8f;
				Tx = 0.8f;
				TY = 0.8f;
				td = Color.Black;
				tE = Color.Black;
				te = Color.White;
				tF = Color.White;
				tf = Ty;
				tG = Color.Black;
				tg = Color.Black;
				tH = Color.Black;
				ti = Color.Black;
				th = td;
				tI = tf;
				tJ = Color.DodgerBlue;
				tj = Color.White;
				tK = Color.White;
				tk = Color.Black;
				tL = Color.Black;
				tl = Color.Black;
				tM = Color.White;
				tm = Color.LightBlue;
				tN = Color.Cyan;
				tP = Color.Black;
				tp = Color.White;
				tn = tB;
				tO = Color.DodgerBlue;
				to = Color.Black;
				tQ = Color.Black;
				tq = Color.Gray;
				((Control)Rh).BackColor = Color.Black;
				((Control)RI).BackColor = Color.Black;
				((Control)Rq).BackColor = Color.Black;
				((Control)rq).BackColor = Color.Black;
				break;
			case BM.r.BqH:
				TX = 0.7f;
				Tx = 0.7f;
				TY = 0.7f;
				td = ta;
				tE = TZ;
				te = Color.White;
				tF = Color.White;
				tf = Ty;
				tG = ta;
				tg = TZ;
				tH = TZ;
				ti = TZ;
				th = td;
				tI = tf;
				tJ = Color.White;
				tj = TZ;
				tK = Color.Black;
				tk = Color.White;
				tL = Color.White;
				tl = tB;
				tM = tb;
				tm = Tz;
				tN = Color.White;
				tP = tB;
				tp = Color.Black;
				tn = tB;
				tO = Color.DodgerBlue;
				to = ta;
				tQ = ta;
				tq = Color.Gray;
				((Control)Rh).BackColor = tA;
				((Control)RI).BackColor = tA;
				((Control)Rq).BackColor = tA;
				((Control)rq).BackColor = tA;
				break;
			case BM.r.Bqh:
				TX = 0.2f;
				Tx = 0.2f;
				TY = 0.2f;
				td = SystemColors.ControlLight;
				tE = SystemColors.Control;
				te = Color.Black;
				tF = Color.Blue;
				tf = Color.Black;
				tG = Color.White;
				tg = Color.White;
				tH = Color.White;
				th = td;
				tI = tf;
				ti = Color.White;
				tJ = Color.White;
				tj = Color.LightGray;
				tK = Color.Black;
				tk = Color.Black;
				tL = Color.Black;
				tn = Color.White;
				tO = Color.DodgerBlue;
				to = Color.White;
				tQ = Color.LightGray;
				tq = Color.Gray;
				((Control)Rh).BackColor = Color.White;
				((Control)RI).BackColor = Color.White;
				((Control)Rq).BackColor = Color.White;
				((Control)rq).BackColor = Color.White;
				break;
			}
			rE.A();
			rt.A();
			RV.A();
			rO.C();
			Ru.A();
			re.A();
			rF.A();
			rf.A();
			if (((ToolStripItem)rh).Image != null)
			{
				((ToolStripItem)rh).Image.Dispose();
			}
			((ToolStripItem)rh).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconNavigationTree, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)RX).Image != null)
			{
				((ToolStripItem)RX).Image.Dispose();
			}
			((ToolStripItem)RX).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconNewMap, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)rA).Image != null)
			{
				((ToolStripItem)rA).Image.Dispose();
			}
			((ToolStripItem)rA).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconOpenMap, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)rN).Image != null)
			{
				((ToolStripItem)rN).Image.Dispose();
			}
			((ToolStripItem)rN).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconSaveMap, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)Rx).Image != null)
			{
				((ToolStripItem)Rx).Image.Dispose();
			}
			((ToolStripItem)Rx).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconImportMap, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)RY).Image != null)
			{
				((ToolStripItem)RY).Image.Dispose();
			}
			((ToolStripItem)RY).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconUndo, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)Ry).Image != null)
			{
				((ToolStripItem)Ry).Image.Dispose();
			}
			((ToolStripItem)Ry).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconRedo, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)rd).Image != null)
			{
				((ToolStripItem)rd).Image.Dispose();
			}
			((ToolStripItem)rd).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconTableProperties, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)RZ).Image != null)
			{
				((ToolStripItem)RZ).Image.Dispose();
			}
			((ToolStripItem)RZ).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconWiring, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)Rz).Image != null)
			{
				((ToolStripItem)Rz).Image.Dispose();
			}
			((ToolStripItem)Rz).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconScope, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)Sd).Image != null)
			{
				((ToolStripItem)Sd).Image.Dispose();
			}
			((ToolStripItem)Sd).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconCANBusViewer, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)rb).Image != null)
			{
				((ToolStripItem)rb).Image.Dispose();
			}
			((ToolStripItem)rb).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconPassword, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)SC).Image != null)
			{
				((ToolStripItem)SC).Image.Dispose();
			}
			((ToolStripItem)SC).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconResourceLibrary, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)SD).Image != null)
			{
				((ToolStripItem)SD).Image.Dispose();
			}
			((ToolStripItem)SD).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconErrorConfig, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (((ToolStripItem)rG).Image != null)
			{
				((ToolStripItem)rG).Image.Dispose();
			}
			((ToolStripItem)rG).Image = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconEmail, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			bool flag = false;
			if (((ToolStripItem)rp).Image == sH)
			{
				((ToolStripItem)rp).Image = null;
				flag = true;
			}
			if (sH != null)
			{
				sH.Dispose();
			}
			sH = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconHelp, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (flag)
			{
				((ToolStripItem)rp).Image = sH;
			}
			flag = false;
			if (((ToolStripItem)rp).Image == sg)
			{
				((ToolStripItem)rp).Image = null;
				flag = true;
			}
			if (sg != null)
			{
				sg.Dispose();
			}
			sg = (Image)(object)global::A.O.A((Image)(object)GeneralResources.IconHelp, 1f, 0f, 0f, 0f, 0f, 0f, 0.66f, 1f);
			if (flag)
			{
				((ToolStripItem)rp).Image = sg;
			}
			WiringPin.A(TX, Tx, TY);
			PortFunction.A(TX, Tx, TY);
			if (tR != null)
			{
				tR.Dispose();
			}
			tR = (Image)(object)global::A.O.A((Image)(object)GeneralResources.BackArrow, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			if (tr != null)
			{
				tr.Dispose();
			}
			tr = (Image)(object)global::A.O.A((Image)(object)GeneralResources.ForwardArrow, 1f, 0f, 0f, 0f, 0f, TX, Tx, TY);
			rn.E();
			if (P_0)
			{
				re.a();
				rF.a();
				rf.a();
				((ToolStripItem)rp).Image = sH;
				rt.a();
				RV.a();
				rO.c();
			}
			((Control)this).BackColor = td;
			((Control)((TabControl)rl).TabPages[0]).BackColor = td;
			((Control)((TabControl)rl).TabPages[1]).BackColor = td;
			((ToolStrip)Rc).BackColor = tE;
			foreach (ToolStripItem item in (ArrangedElementCollection)((ToolStrip)Rc).Items)
			{
				ToolStripItem val = item;
				val.ForeColor = te;
				if (!(val is ToolStripMenuItem))
				{
					continue;
				}
				ToolStripItem obj = ((val is ToolStripMenuItem) ? val : null);
				((ToolStrip)((ToolStripDropDownItem)obj).DropDown).ForeColor = te;
				((ToolStrip)((ToolStripDropDownItem)obj).DropDown).BackColor = tG;
				foreach (ToolStripItem item2 in (ArrangedElementCollection)((ToolStripDropDownItem)obj).DropDownItems)
				{
					ToolStripItem val2 = item2;
					if (val2 is ToolStripMenuItem)
					{
						ToolStripItem obj2 = ((val2 is ToolStripMenuItem) ? val2 : null);
						((ToolStrip)((ToolStripDropDownItem)obj2).DropDown).ForeColor = te;
						((ToolStrip)((ToolStripDropDownItem)obj2).DropDown).BackColor = tG;
					}
				}
			}
			RG.BackColor = tE;
			foreach (ToolStripItem item3 in (ArrangedElementCollection)RG.Items)
			{
				ToolStripItem val3 = item3;
				if (!(val3 is ToolStripDropDownButton))
				{
					continue;
				}
				ToolStripItem obj3 = ((val3 is ToolStripDropDownButton) ? val3 : null);
				((ToolStrip)((ToolStripDropDownItem)obj3).DropDown).ForeColor = te;
				((ToolStrip)((ToolStripDropDownItem)obj3).DropDown).BackColor = tG;
				foreach (ToolStripItem item4 in (ArrangedElementCollection)((ToolStripDropDownItem)obj3).DropDownItems)
				{
					ToolStripItem val4 = item4;
					if (val4 is ToolStripMenuItem)
					{
						ToolStripItem obj4 = ((val4 is ToolStripMenuItem) ? val4 : null);
						((ToolStrip)((ToolStripDropDownItem)obj4).DropDown).ForeColor = te;
						((ToolStrip)((ToolStripDropDownItem)obj4).DropDown).BackColor = tG;
					}
				}
			}
			((Control)rI).BackColor = td;
			((Control)rI).ForeColor = te;
			((Control)ts).ForeColor = te;
			((Control)SW).BackColor = tE;
			((Control)SX).ForeColor = te;
			((Control)sc).BackColor = tE;
			((Control)sD).ForeColor = te;
			Enumerator<Label> enumerator3 = sE.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					((Control)enumerator3.Current).ForeColor = te;
				}
			}
			finally
			{
				((System.IDisposable)enumerator3).Dispose();
			}
			SB.A();
			rn.A();
			if (sj != null)
			{
				sj.F();
			}
			if (RB != null)
			{
				RB.A();
			}
			if (P_0)
			{
				rL.D();
			}
			else
			{
				a(false);
			}
			if (tS != null)
			{
				tS.Invoke((object)null, (EventArgs)null);
			}
		}

		private void a(object P_0, PaintEventArgs P_1)
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			if (Tn != 0 && Tn != BM.r.Bqh)
			{
				ToolStripMenuItem val = (ToolStripMenuItem)((P_0 is ToolStripMenuItem) ? P_0 : null);
				if (((ToolStripDropDownItem)val).DropDown.Visible)
				{
					Size val2 = TextRenderer.MeasureText((IDeviceContext)(object)P_1.Graphics, ((ToolStripItem)val).Text, ((ToolStripItem)val).Font);
					Point val3 = default(Point);
					((Point)(ref val3))._002Ector(((ToolStripItem)val).Width / 2 - ((Size)(ref val2)).Width / 2, ((ToolStripItem)val).Height / 2 - ((Size)(ref val2)).Height / 2);
					TextRenderer.DrawText((IDeviceContext)(object)P_1.Graphics, ((ToolStripItem)val).Text, ((ToolStripItem)val).Font, val3, Color.Black);
				}
			}
		}

		private void aK(object P_0, EventArgs P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			w();
			be be = new be();
			((Form)be).ShowDialog((IWin32Window)(object)this);
			((Component)be).Dispose();
		}

		private void A(object P_0, ItemDragEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			if ((int)P_1.Button != 1048576)
			{
				return;
			}
			MenuNode menuNode = (MenuNode)((TreeNode)P_1.Item).Tag;
			if (menuNode.C() == null)
			{
				return;
			}
			bool flag = false;
			if (menuNode.s() != -1 && ((TreeNode)/*isinst with value type is only supported in some contexts*/).Parent != null && ((TreeNode)/*isinst with value type is only supported in some contexts*/).Parent.Tag == qa && ((TreeNode)/*isinst with value type is only supported in some contexts*/).Parent.Nodes.Count > 1)
			{
				flag = true;
				tU = true;
			}
			if (menuNode.C().G())
			{
				flag = true;
			}
			if (!flag)
			{
				SettingOrSpecialObject settingOrSpecialObject = Qz.a(menuNode.b());
				if (settingOrSpecialObject != null)
				{
					if (settingOrSpecialObject is Table || settingOrSpecialObject is DN)
					{
						flag = true;
					}
				}
				else
				{
					Enumerator<MenuNode> enumerator = menuNode.c().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							MenuNode current = enumerator.Current;
							if (current.J() && !current.L() && !current.K())
							{
								flag = true;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
			}
			if (flag)
			{
				object item = P_1.Item;
				tT = (TreeNode)((item is TreeNode) ? item : null);
				tt = menuNode;
				((Control)ts).Text = tT.Text;
				Label obj = ts;
				Point mousePosition = Control.MousePosition;
				int num = ((Point)(ref mousePosition)).X;
				mousePosition = Control.MousePosition;
				((Control)obj).Location = ((Control)this).PointToClient(new Point(num, ((Point)(ref mousePosition)).Y));
				((Control)ts).Visible = true;
				((Control)ts).BringToFront();
			}
		}

		private void A(int P_0, int P_1)
		{
			if (tt.C().n())
			{
				Qz.awp.A(P_0, P_1);
			}
			else if (tt.C().O())
			{
				Qz.awP.A(P_0, P_1);
			}
			else if (tt.C().l())
			{
				Qz.awP.E()[tt.C().m()].A(P_0, P_1);
			}
			else if (tt.C().C() != null && tt.C().C().l())
			{
				Qz.awP.E()[tt.C().C().m()].A(P_0, P_1);
			}
		}

		private void aL()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Invalid comparison between Unknown and I4
			//IL_047e: Unknown result type (might be due to invalid IL or missing references)
			//IL_048b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0490: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_050a: Unknown result type (might be due to invalid IL or missing references)
			//IL_050f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0513: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_054e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0553: Unknown result type (might be due to invalid IL or missing references)
			//IL_0584: Unknown result type (might be due to invalid IL or missing references)
			//IL_0589: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0522: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			Point val;
			Point location;
			Rectangle clientRectangle;
			if ((int)Control.MouseButtons == 1048576)
			{
				if (tt == null)
				{
					return;
				}
				Label obj = ts;
				val = Control.MousePosition;
				int num = ((Point)(ref val)).X;
				val = Control.MousePosition;
				((Control)obj).Location = ((Control)this).PointToClient(new Point(num, ((Point)(ref val)).Y));
				((Control)ts).Visible = true;
				((Control)ts).BringToFront();
				Cursor current = Cursors.No;
				tu = -1;
				val = default(Point);
				location = ((Control)ts).Location;
				((Point)(ref val)).X = ((Point)(ref location)).X - (((Control)rl).Left + ((Control)((TabControl)rl).SelectedTab).Left);
				location = ((Control)ts).Location;
				((Point)(ref val)).Y = ((Point)(ref location)).Y - (((Control)rQ).Top + ((Control)rl).Top + ((Control)((TabControl)rl).SelectedTab).Top);
				Point val2 = val;
				clientRectangle = ((Control)((TabControl)rl).SelectedTab).ClientRectangle;
				if (((Rectangle)(ref clientRectangle)).Contains(val2))
				{
					rl.a(val2, tt);
					current = Cursors.Default;
				}
				else
				{
					tt.s();
					val = default(Point);
					location = ((Control)ts).Location;
					((Point)(ref val)).X = ((Point)(ref location)).X - (((Control)rL).Left + ((Control)rL.A()).Left);
					location = ((Control)ts).Location;
					((Point)(ref val)).Y = ((Point)(ref location)).Y - (((Control)rL).Top + ((Control)rL.A()).Top);
					Point val3 = val;
					clientRectangle = ((Control)rL.A()).ClientRectangle;
					if (((Rectangle)(ref clientRectangle)).Contains(val3))
					{
						if (tU || tt.C().G())
						{
							Rectangle val4;
							TreeNode val5 = rL.A().A(((Point)(ref val3)).X, ((Point)(ref val3)).Y, out val4);
							if (val5 != null)
							{
								if (val5 != tT)
								{
									MenuNode menuNode = (MenuNode)val5.Tag;
									bool flag = menuNode != null && menuNode.C() != null && menuNode.C().G();
									if (val5.Tag == qa)
									{
										current = Cursors.Default;
										tu = 0;
										rL.A().a(tT.Parent.Nodes[0]);
										rL.A().B((TreeNode)null);
									}
									else if ((val5.Parent != null && val5.Parent.Tag == qa) || flag)
									{
										int num2 = tT.Parent.Nodes.IndexOf(tT);
										int num3 = val5.Parent.Nodes.IndexOf(val5);
										if (num2 != -1 && num3 != -1)
										{
											current = Cursors.Default;
											if (rL.A().A() == aW.kP || rL.A().A() == aW.kQ)
											{
												if (((Point)(ref val3)).Y < ((Rectangle)(ref val4)).Y + ((Rectangle)(ref val4)).Height / 2)
												{
													tu = num3;
													rL.A().a(val5);
													rL.A().B((TreeNode)null);
												}
												else
												{
													tu = num3 + 1;
													rL.A().a((TreeNode)null);
													rL.A().B(val5);
												}
											}
											else if (((Point)(ref val3)).X < ((Rectangle)(ref val4)).X + ((Rectangle)(ref val4)).Width / 2)
											{
												tu = num3;
												rL.A().a(val5);
												rL.A().B((TreeNode)null);
											}
											else
											{
												tu = num3 + 1;
												rL.A().a((TreeNode)null);
												rL.A().B(val5);
											}
											if (tu > 0 && tu > num2)
											{
												tu--;
											}
										}
									}
								}
								else
								{
									current = Cursors.Default;
								}
							}
						}
						else
						{
							current = Cursors.Default;
						}
					}
				}
				Cursor.Current = current;
				if (tu == -1)
				{
					rL.A().a((TreeNode)null);
					rL.A().B((TreeNode)null);
				}
				return;
			}
			if (tt != null)
			{
				val = default(Point);
				location = ((Control)ts).Location;
				((Point)(ref val)).X = ((Point)(ref location)).X - (((Control)rl).Left + ((Control)((TabControl)rl).SelectedTab).Left);
				location = ((Control)ts).Location;
				((Point)(ref val)).Y = ((Point)(ref location)).Y - (((Control)rQ).Top + ((Control)rl).Top + ((Control)((TabControl)rl).SelectedTab).Top);
				Point val6 = val;
				clientRectangle = ((Control)((TabControl)rl).SelectedTab).ClientRectangle;
				if (((Rectangle)(ref clientRectangle)).Contains(val6))
				{
					rl.A(val6, tt);
				}
				else
				{
					int num4 = tt.s();
					val = default(Point);
					location = ((Control)ts).Location;
					((Point)(ref val)).X = ((Point)(ref location)).X - (((Control)rL).Left + ((Control)rL.A()).Left);
					location = ((Control)ts).Location;
					((Point)(ref val)).Y = ((Point)(ref location)).Y - (((Control)rL).Top + ((Control)rL.A()).Top);
					Point val7 = val;
					clientRectangle = ((Control)rL.A()).ClientRectangle;
					if (((Rectangle)(ref clientRectangle)).Contains(val7))
					{
						if (tU)
						{
							if (tu != -1)
							{
								rL.B(num4, tu);
							}
							tU = false;
						}
						else if (tt.C() != null && tt.C().G() && tu != -1)
						{
							MenuNode menuNode2 = tt;
							MenuNode menuNode3 = (MenuNode)tT.Parent.Nodes[tu].Tag;
							if (menuNode3 != null)
							{
								int num5 = -1;
								int num6 = -1;
								if (menuNode2.o())
								{
									num5 = menuNode2.P();
									num6 = menuNode3.P();
								}
								else if (menuNode2.l())
								{
									num5 = menuNode2.m();
									num6 = menuNode3.m();
								}
								else if (menuNode2.M())
								{
									num5 = menuNode2.N();
									num6 = menuNode3.N();
								}
								A(num5, num6);
								rL.A().A(tT.Parent.Nodes[tu]);
								rL.A(true, true, false, false);
								if (rL.A().B() != null && rL.A().B().Tag == tt.C())
								{
									rL.A(rL.A().B(), true, true);
								}
							}
						}
					}
				}
				Cursor.Current = Cursors.Default;
				rL.A().a((TreeNode)null);
				rL.A().B((TreeNode)null);
			}
			tT = null;
			tt = null;
			tU = false;
			((Control)ts).Text = string.Empty;
			((Control)ts).Visible = false;
			tu = -1;
		}

		private void al()
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			tT = null;
			tt = null;
			tU = false;
			((Control)ts).Text = string.Empty;
			((Control)ts).AutoSize = true;
			((Control)ts).Visible = false;
			((Control)ts).Font = new Font(((Control)rL).Font.FontFamily, ((Control)rL).Font.Size, (FontStyle)1);
			((Control)ts).BackColor = Color.Transparent;
			((Control)this).Controls.Add((Control)(object)ts);
		}

		internal static Ck aM()
		{
			if (Bz.A())
			{
				if (Bz.yL != null)
				{
					return Bz.yL.A();
				}
				return null;
			}
			if (BZ.A() && Ra != null && ((Control)Ra).Visible && ((Control)Ra).ContainsFocus)
			{
				if (BZ.yd != null)
				{
					return BZ.yd.A();
				}
				return null;
			}
			if (BB.NE != null)
			{
				return BB.NE.Nd;
			}
			ci ci = QQ.rl.i();
			if (ci != null)
			{
				return ci.a();
			}
			if (QQ.rL.A().B() != null && QQ.rL.A().B().Tag is MenuNode)
			{
				MenuNode menuNode = QQ.rL.A().B().Tag as MenuNode;
				if (menuNode.M() && QQ.rL.A().B().Parent != null && QQ.rL.A().B().Parent.Tag is MenuNode && (QQ.rL.A().B().Parent.Tag as MenuNode).l())
				{
					return (QQ.rL.A().B().Parent.Tag as MenuNode).A();
				}
				return menuNode?.A();
			}
			return null;
		}

		private void am()
		{
			Ck ck = aM();
			bool enabled = ck?.e() ?? false;
			bool enabled2 = ck?.F() ?? false;
			((ToolStripItem)Rm).Enabled = enabled;
			((ToolStripItem)RY).Enabled = enabled;
			((ToolStripItem)RN).Enabled = enabled2;
			((ToolStripItem)Ry).Enabled = enabled2;
		}

		internal void ak(object P_0, EventArgs P_1)
		{
			tV = true;
			Ck ck = aM();
			TreeNode val = aN();
			ck?.C();
			Application.DoEvents();
			if (val != null && QQ.rL.A().B() == null)
			{
				QQ.rL.A().A(val);
				if (ch.Bhl != null)
				{
					ch.Bhl.a(0);
				}
			}
			tV = false;
		}

		internal void aL(object P_0, EventArgs P_1)
		{
			tV = true;
			Ck ck = aM();
			TreeNode val = aN();
			ck?.c();
			Application.DoEvents();
			if (val != null && QQ.rL.A().B() == null)
			{
				QQ.rL.A().A(val);
				if (ch.Bhl != null)
				{
					ch.Bhl.a(0);
				}
			}
			tV = false;
		}

		private static TreeNode aN()
		{
			TreeNode result = null;
			if (QQ.rL.A().B() != null && QQ.rL.A().B().Tag is MenuNode && (QQ.rL.A().B().Tag as MenuNode).M() && QQ.rL.A().B().Parent != null && QQ.rL.A().B().Parent.Tag is MenuNode && (QQ.rL.A().B().Parent.Tag as MenuNode).l())
			{
				result = QQ.rL.A().B().Parent;
			}
			return result;
		}

		internal static List<string> H(string P_0)
		{
			List<string> val = new List<string>();
			if (!string.IsNullOrEmpty(P_0))
			{
				string text = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
				if (Directory.Exists(text))
				{
					string[] directories = Directory.GetDirectories(text);
					foreach (string text2 in directories)
					{
						int num = text2.IndexOf(Qy);
						int length = Qy.Length;
						string text3 = text2.Substring(num + length + 1);
						if (text3 == P_0 || text3.StartsWith(P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax()))
						{
							val.Add(text2);
						}
					}
				}
			}
			return val;
		}

		internal static string h(string P_0)
		{
			string text = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
			if (Directory.Exists(text))
			{
				string[] directories = Directory.GetDirectories(text);
				foreach (string text2 in directories)
				{
					string[] files = Directory.GetFiles(text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ta());
					for (int j = 0; j < files.Length; j++)
					{
						if (!files[j].EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TB()))
						{
							continue;
						}
						StreamReader val = File.OpenText(files[j]);
						try
						{
							string text3;
							while ((text3 = ((TextReader)val).ReadLine()) != null)
							{
								if (text3.Equals(P_0))
								{
									return text2;
								}
							}
						}
						finally
						{
							((System.IDisposable)val)?.Dispose();
						}
						break;
					}
				}
			}
			return string.Empty;
		}

		internal static string A(string P_0, string P_1)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			if (Directory.Exists(Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy))
			{
				Enumerator<string> enumerator = H(P_0).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						bool flag = false;
						string[] files = Directory.GetFiles(current, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ta());
						for (int i = 0; i < files.Length; i++)
						{
							if (!files[i].EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TB()))
							{
								continue;
							}
							StreamReader val = File.OpenText(files[i]);
							try
							{
								string text;
								while ((text = ((TextReader)val).ReadLine()) != null)
								{
									if (text.Equals(P_1))
									{
										flag = true;
										break;
									}
								}
							}
							finally
							{
								((System.IDisposable)val)?.Dispose();
							}
							break;
						}
						if (flag)
						{
							return current;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			return string.Empty;
		}

		internal static string a(string P_0, List<string> P_1)
		{
			string text = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
			string text2 = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + P_0;
			if (Directory.Exists(text2))
			{
				int num = 2;
				do
				{
					text2 = string.Concat(new string[5]
					{
						text,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(),
						P_0,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax(),
						num.ToString()
					});
					num++;
				}
				while (Directory.Exists(text2));
			}
			Directory.CreateDirectory(text2);
			B(text2, P_1);
			return text2;
		}

		internal static void B(string P_0, List<string> P_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			string text = P_0 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tb();
			Enumerator<string> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (string.IsNullOrWhiteSpace(current))
					{
						continue;
					}
					bool flag = false;
					if (File.Exists(text))
					{
						StreamReader val = File.OpenText(text);
						try
						{
							string text2;
							while ((text2 = ((TextReader)val).ReadLine()) != null)
							{
								if (text2.Equals(current))
								{
									flag = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)val)?.Dispose();
						}
					}
					if (!flag)
					{
						File.AppendAllText(text, current + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI());
					}
					string text3 = Qq + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa() + Qy;
					if (!Directory.Exists(text3))
					{
						continue;
					}
					string[] directories = Directory.GetDirectories(text3);
					foreach (string text4 in directories)
					{
						if (!(Path.GetFullPath(text4) != Path.GetFullPath(P_0)))
						{
							continue;
						}
						string[] files = Directory.GetFiles(text4, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ta());
						for (int j = 0; j < files.Length; j++)
						{
							if (!files[j].EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TB()))
							{
								continue;
							}
							List<string> val2 = new List<string>();
							bool flag2 = false;
							StreamReader val3 = File.OpenText(files[j]);
							try
							{
								string text5;
								while ((text5 = ((TextReader)val3).ReadLine()) != null)
								{
									if (!string.IsNullOrWhiteSpace(text5))
									{
										if (text5.Equals(current))
										{
											flag2 = true;
										}
										else
										{
											val2.Add(text5);
										}
									}
								}
							}
							finally
							{
								((System.IDisposable)val3)?.Dispose();
							}
							if (!flag2)
							{
								break;
							}
							File.Delete(files[j]);
							Enumerator<string> enumerator2 = val2.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									string current2 = enumerator2.Current;
									File.AppendAllText(files[j], current2 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FI());
								}
							}
							finally
							{
								((System.IDisposable)enumerator2).Dispose();
							}
							break;
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		internal static bool A(string P_0, string P_1, Framework P_2)
		{
			//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fb: Invalid comparison between Unknown and I4
			//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b1: Invalid comparison between Unknown and I4
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Invalid comparison between Unknown and I4
			//IL_0400: Unknown result type (might be due to invalid IL or missing references)
			//IL_0405: Unknown result type (might be due to invalid IL or missing references)
			//IL_041b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0428: Unknown result type (might be due to invalid IL or missing references)
			//IL_0431: Expected O, but got Unknown
			//IL_0438: Unknown result type (might be due to invalid IL or missing references)
			//IL_043e: Invalid comparison between Unknown and I4
			//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_06af: Invalid comparison between Unknown and I4
			//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05de: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e7: Expected O, but got Unknown
			//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f4: Invalid comparison between Unknown and I4
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ae: Invalid comparison between Unknown and I4
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Invalid comparison between Unknown and I4
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Invalid comparison between Unknown and I4
			//IL_045b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0694: Unknown result type (might be due to invalid IL or missing references)
			if (Framework.A(P_1))
			{
				string text = A(P_0, P_2.aXc);
				List<string> val = H(P_1);
				if (val.Count == 0)
				{
					if (string.IsNullOrEmpty(text))
					{
						try
						{
							List<string> obj = new List<string>();
							obj.Add(P_2.aXc);
							string aXD = a(P_1, obj);
							P_2.aXD = aXD;
						}
						catch
						{
						}
					}
					else if ((int)bE.A((IWin32Window)(object)QQ, string.Concat(new string[9]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TC(),
						P_0,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tc(),
						P_0,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TD(),
						P_1,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Td(),
						P_1,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TE()
					}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Te(), (MessageBoxButtons)4, (MessageBoxIcon)32, new string[2]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TF(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tf()
					}) == 6)
					{
						try
						{
							string text2 = string.Concat(new string[5]
							{
								Qq,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa(),
								Qy,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(),
								P_1
							});
							Directory.Move(text, text2);
							P_2.aXD = text2;
						}
						catch
						{
						}
					}
					else
					{
						try
						{
							List<string> obj4 = new List<string>();
							obj4.Add(P_2.aXc);
							a(text, P_2.aXD = a(P_1, obj4));
						}
						catch
						{
						}
					}
				}
				else if (val.Count == 1)
				{
					if (string.IsNullOrEmpty(text))
					{
						if ((int)bE.A((IWin32Window)(object)QQ, string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TC(),
							P_1,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TG(),
							P_1,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tg()
						}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Te(), (MessageBoxButtons)4, (MessageBoxIcon)32, new string[2]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TH(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tf()
						}) == 6)
						{
							try
							{
								string text3 = val[0];
								List<string> obj6 = new List<string>();
								obj6.Add(P_2.aXc);
								B(text3, obj6);
								P_2.aXD = val[0];
							}
							catch
							{
							}
						}
						else
						{
							try
							{
								List<string> obj8 = new List<string>();
								obj8.Add(P_2.aXc);
								string aXD2 = a(P_1, obj8);
								P_2.aXD = aXD2;
							}
							catch
							{
							}
						}
					}
					else
					{
						DialogResult val2 = bE.A((IWin32Window)(object)QQ, string.Concat(new string[13]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TC(),
							P_0,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Th(),
							P_1,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TI(),
							P_1,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ti(),
							P_0,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TD(),
							P_1,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TJ(),
							P_1,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tg()
						}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Te(), (MessageBoxButtons)3, (MessageBoxIcon)32, new string[3]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TH(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TF(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tf()
						});
						if ((int)val2 == 6)
						{
							try
							{
								string text4 = val[0];
								List<string> obj10 = new List<string>();
								obj10.Add(P_2.aXc);
								B(text4, obj10);
								P_2.aXD = val[0];
								a(text, P_2.aXD);
							}
							catch
							{
							}
						}
						else if ((int)val2 == 7)
						{
							try
							{
								string text5 = string.Concat(new string[6]
								{
									Qq,
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa(),
									Qy,
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(),
									P_1,
									D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tj()
								});
								Directory.Move(text, text5);
								P_2.aXD = text5;
							}
							catch
							{
							}
						}
						else
						{
							try
							{
								List<string> obj13 = new List<string>();
								obj13.Add(P_2.aXc);
								a(text, P_2.aXD = a(P_1, obj13));
							}
							catch
							{
							}
						}
					}
				}
				else if (val.Count > 1)
				{
					if (string.IsNullOrEmpty(text))
					{
						bool flag = false;
						do
						{
							if ((int)bE.A((IWin32Window)(object)QQ, string.Concat(new string[7]
							{
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TK(),
								P_1,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tk(),
								P_1,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TL(),
								P_1,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tl()
							}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Te(), (MessageBoxButtons)4, (MessageBoxIcon)32, new string[2]
							{
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TM(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tf()
							}) == 6)
							{
								try
								{
									FolderBrowserDialog val3 = new FolderBrowserDialog
									{
										Description = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tm() + P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TN(),
										SelectedPath = val[0],
										ShowNewFolderButton = false
									};
									if ((int)((CommonDialog)val3).ShowDialog((IWin32Window)(object)QQ) == 1 && !string.IsNullOrEmpty(val3.SelectedPath))
									{
										string name = ((FileSystemInfo)new DirectoryInfo(val3.SelectedPath)).Name;
										if (name == P_1 || name.StartsWith(P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax()))
										{
											string selectedPath = val3.SelectedPath;
											List<string> obj15 = new List<string>();
											obj15.Add(P_2.aXc);
											B(selectedPath, obj15);
											P_2.aXD = val3.SelectedPath;
											flag = true;
										}
										else
										{
											bE.A((IWin32Window)(object)QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tn() + P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TO(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
										}
									}
									((Component)val3).Dispose();
								}
								catch
								{
								}
							}
							else
							{
								try
								{
									List<string> obj17 = new List<string>();
									obj17.Add(P_2.aXc);
									string aXD3 = a(P_1, obj17);
									P_2.aXD = aXD3;
									flag = true;
								}
								catch
								{
								}
							}
						}
						while (!flag);
					}
					else
					{
						bool flag2 = false;
						do
						{
							DialogResult val4 = bE.A((IWin32Window)(object)QQ, string.Concat(new string[13]
							{
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TC(),
								P_0,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.To(),
								P_1,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tk(),
								P_1,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TP(),
								P_0,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TD(),
								P_1,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tp(),
								P_1,
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tl()
							}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Te(), (MessageBoxButtons)3, (MessageBoxIcon)32, new string[3]
							{
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TM(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TF(),
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tf()
							});
							if ((int)val4 == 6)
							{
								try
								{
									FolderBrowserDialog val5 = new FolderBrowserDialog
									{
										Description = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tm() + P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TN(),
										SelectedPath = val[0],
										ShowNewFolderButton = false
									};
									if ((int)((CommonDialog)val5).ShowDialog((IWin32Window)(object)QQ) == 1 && !string.IsNullOrEmpty(val5.SelectedPath))
									{
										string name2 = ((FileSystemInfo)new DirectoryInfo(val5.SelectedPath)).Name;
										if (name2 == P_1 || name2.StartsWith(P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax()))
										{
											string selectedPath2 = val5.SelectedPath;
											List<string> obj19 = new List<string>();
											obj19.Add(P_2.aXc);
											B(selectedPath2, obj19);
											P_2.aXD = val5.SelectedPath;
											a(text, P_2.aXD);
											flag2 = true;
										}
										else
										{
											bE.A((IWin32Window)(object)QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tn() + P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TO(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
										}
									}
									((Component)val5).Dispose();
								}
								catch
								{
								}
							}
							else if ((int)val4 == 7)
							{
								try
								{
									string text6 = string.Concat(new string[5]
									{
										Qq,
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa(),
										Qy,
										D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(),
										P_1
									});
									if (Directory.Exists(text6))
									{
										int num = 2;
										do
										{
											text6 = string.Concat(new string[7]
											{
												Qq,
												D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fa(),
												Qy,
												D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(),
												P_1,
												D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax(),
												num.ToString()
											});
											num++;
										}
										while (Directory.Exists(text6));
									}
									Directory.Move(text, text6);
									P_2.aXD = text6;
									flag2 = true;
								}
								catch
								{
								}
							}
							else
							{
								try
								{
									List<string> obj22 = new List<string>();
									obj22.Add(P_2.aXc);
									a(text, P_2.aXD = a(P_1, obj22));
									flag2 = true;
								}
								catch
								{
								}
							}
						}
						while (!flag2);
					}
				}
				A(true);
				return true;
			}
			A(true);
			return false;
		}

		private static bool a(string P_0, string P_1)
		{
			try
			{
				string text = Path.Combine(P_0, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TQ());
				if (Directory.Exists(text))
				{
					string text2 = Path.Combine(P_1, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TQ());
					global::A.m.A(text, text2, true, global::A.m.A.Bgt);
					return true;
				}
			}
			catch (System.Exception ex)
			{
				global::A.N.A(string.Concat(new string[6]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tq(),
					P_0,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TR(),
					P_1,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rq(),
					ex.Message
				}), true);
			}
			return false;
		}

		internal static void B(Framework P_0)
		{
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Invalid comparison between Unknown and I4
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected O, but got Unknown
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Invalid comparison between Unknown and I4
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Invalid comparison between Unknown and I4
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			string empty = string.Empty;
			if (!P_0.A(ref empty))
			{
				return;
			}
			string text = A(empty, P_0.aXc);
			if (string.IsNullOrEmpty(text))
			{
				List<string> val = H(empty);
				if (val.Count == 0)
				{
					try
					{
						string text2 = empty;
						List<string> obj = new List<string>();
						obj.Add(P_0.aXc);
						string aXD = a(text2, obj);
						P_0.aXD = aXD;
						return;
					}
					catch
					{
						return;
					}
				}
				if (val.Count == 1)
				{
					if ((int)bE.A((IWin32Window)(object)QQ, string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TC(),
						empty,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TG(),
						empty,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tg()
					}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Te(), (MessageBoxButtons)4, (MessageBoxIcon)32, new string[2]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TH(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tf()
					}) == 6)
					{
						try
						{
							string text3 = val[0];
							List<string> obj3 = new List<string>();
							obj3.Add(P_0.aXc);
							B(text3, obj3);
							P_0.aXD = val[0];
							return;
						}
						catch
						{
							return;
						}
					}
					try
					{
						string text4 = empty;
						List<string> obj5 = new List<string>();
						obj5.Add(P_0.aXc);
						string aXD2 = a(text4, obj5);
						P_0.aXD = aXD2;
						return;
					}
					catch
					{
						return;
					}
				}
				if (val.Count <= 1)
				{
					return;
				}
				bool flag = false;
				do
				{
					if ((int)bE.A((IWin32Window)(object)QQ, string.Concat(new string[7]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TK(),
						empty,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tk(),
						empty,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TL(),
						empty,
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tl()
					}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Te(), (MessageBoxButtons)4, (MessageBoxIcon)32, new string[2]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TM(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tf()
					}) == 6)
					{
						try
						{
							FolderBrowserDialog val2 = new FolderBrowserDialog
							{
								Description = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tm() + empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TN(),
								SelectedPath = val[0],
								ShowNewFolderButton = false
							};
							if ((int)((CommonDialog)val2).ShowDialog((IWin32Window)(object)QQ) == 1 && !string.IsNullOrEmpty(val2.SelectedPath))
							{
								string name = ((FileSystemInfo)new DirectoryInfo(val2.SelectedPath)).Name;
								if (name == empty || name.StartsWith(empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax()))
								{
									string selectedPath = val2.SelectedPath;
									List<string> obj7 = new List<string>();
									obj7.Add(P_0.aXc);
									B(selectedPath, obj7);
									P_0.aXD = val2.SelectedPath;
									flag = true;
								}
								else
								{
									bE.A((IWin32Window)(object)QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tn() + empty + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TO(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
								}
							}
							((Component)val2).Dispose();
						}
						catch
						{
						}
					}
					else
					{
						try
						{
							string text5 = empty;
							List<string> obj9 = new List<string>();
							obj9.Add(P_0.aXc);
							string aXD3 = a(text5, obj9);
							P_0.aXD = aXD3;
							flag = true;
						}
						catch
						{
						}
					}
				}
				while (!flag);
			}
			else
			{
				P_0.aXD = text;
			}
		}

		private void al(object P_0, EventArgs P_1)
		{
			if (global::A.A.c().Count == 1)
			{
				A(null, -1, false);
			}
		}

		internal void A(BackgroundWorker P_0, int P_1, bool P_2 = false)
		{
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected O, but got Unknown
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected O, but got Unknown
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected O, but got Unknown
			if (Qz == null || !Qz.c())
			{
				return;
			}
			for (int i = 0; i < Qz.aWt.Count; i++)
			{
				Qz.aWt[i].az();
			}
			lock (qh)
			{
				qI |= 64;
				qI |= 8;
				qI |= 16;
			}
			if (Qz.awZ == 21)
			{
				global::A.A.d(Qz.aXc, out var _);
			}
			if (P_0 == null)
			{
				BackgroundWorker val = new BackgroundWorker
				{
					WorkerReportsProgress = true
				};
				val.DoWork += new DoWorkEventHandler(s);
				object obj = BM.t.Bqk;
				if (obj == null)
				{
					ProgressChangedEventHandler val2 = a;
					BM.t.Bqk = val2;
					obj = (object)val2;
				}
				val.ProgressChanged += (ProgressChangedEventHandler)obj;
				val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(s);
				if (Qz.awv.Count != 0)
				{
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tr());
				}
				else
				{
					C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TS());
				}
				val.RunWorkerAsync((object)new object[2] { -1, P_2 });
			}
			else
			{
				DoWorkEventArgs val3 = new DoWorkEventArgs((object)new object[2] { P_1, P_2 });
				s(P_0, val3);
				s((object)P_0, new RunWorkerCompletedEventArgs(val3.Result, (System.Exception)null, false));
			}
		}

		private void s(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			int num = (int)((object[])P_1.Argument)[0];
			bool bqj = (bool)((object[])P_1.Argument)[1];
			s s = new s
			{
				Bqj = bqj,
				BqK = null
			};
			int bF;
			try
			{
				bF = (int)SI[0].BpS.@as[35].BF;
			}
			catch
			{
				return;
			}
			uint num2 = f();
			int num3 = ((Qz.awv.Count == 0) ? 100 : 40);
			lock (Si)
			{
				Qz.p();
				int num4 = 0;
				bool flag;
				do
				{
					int num5 = 0;
					flag = Qz.B(ref num5);
					num4 = Math.Min(num4 + num5, bF);
					int num6 = num4 * num3 / bF;
					if (!flag || num5 != 0)
					{
						if (num == -1)
						{
							val.ReportProgress(num6);
						}
						else
						{
							val.ReportProgress(num6, (object)num);
						}
					}
					if (!A(Qz.aXc, false))
					{
						return;
					}
					if (num6 != 100)
					{
						Thread.Sleep(0);
					}
					else
					{
						Thread.Sleep(200);
					}
				}
				while (flag || num4 < bF);
			}
			if (Qz.awv.Count != 0)
			{
				A(val, num3, num, num2, out var text);
				if (!string.IsNullOrWhiteSpace(text))
				{
					s.BqK = text;
				}
			}
			while (C(true))
			{
				Thread.Sleep(100);
			}
			P_1.Result = s;
		}

		private void s(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			if (((Control)this).InvokeRequired)
			{
				try
				{
					T t = this.s;
					((Control)this).Invoke((System.Delegate)t, new object[2] { P_0, P_1 });
					return;
				}
				catch
				{
					return;
				}
			}
			try
			{
				P();
			}
			catch
			{
			}
			if (qT)
			{
				if (qW)
				{
					Environment.Exit(0);
				}
				qT = false;
			}
			lock (qh)
			{
				qI &= -65;
			}
			for (int i = 0; i < Qz.aWt.Count; i++)
			{
				Qz.aWt[i].i(true);
			}
			if (QM == BM.a.Bpc || QM == BM.a.Bpe)
			{
				this.i();
			}
			else
			{
				if (!(P_1.Result is s s))
				{
					return;
				}
				if (!qW && !string.IsNullOrWhiteSpace(s.BqK))
				{
					bE.A((IWin32Window)(object)this, s.BqK, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				if (!s.Bqj)
				{
					return;
				}
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				if (Qz.C())
				{
					if (Bz.A(Qz))
					{
						flag4 = Bz.A(Qz, out flag, out flag2, out flag3);
					}
					else
					{
						Dh.A(Qz, out flag5);
					}
				}
				if (flag || flag5)
				{
					b(true);
				}
				else if (!flag3)
				{
					a(false);
					if (flag4 && ((ToolStripItem)QQ.rc).Enabled && !flag2)
					{
						((ToolStripItem)QQ.rc).PerformClick();
					}
				}
			}
		}

		private void A(BackgroundWorker P_0, int P_1, int P_2, uint P_3, out string P_4)
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			P_4 = null;
			if (Directory.Exists(Qu))
			{
				string[] array = null;
				try
				{
					array = Directory.GetDirectories(Qu);
				}
				catch (System.Exception ex)
				{
					array = null;
					global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ts() + Qu + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TT() + ex.Message, true);
				}
				if (array != null)
				{
					int num = (80 - P_1) / array.Length;
					for (int i = 0; i < array.Length; i++)
					{
						string text = array[i];
						string[] array2 = null;
						try
						{
							array2 = Directory.GetFiles(text);
						}
						catch (System.Exception ex2)
						{
							array2 = null;
							global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tt() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TT() + ex2.Message, true);
						}
						if (array2 != null)
						{
							int num2 = P_1 + i * num;
							if (P_2 != -1)
							{
								P_0.ReportProgress(num2, (object)P_2);
							}
							else
							{
								P_0.ReportProgress(num2);
							}
							global::A.A.C c = Di.A(((FileSystemInfo)new DirectoryInfo(text)).Name);
							if (Qz.aww.ContainsKey(c))
							{
								global::A.j[] array3 = a(c);
								int num3 = num2 + num / 10;
								if (P_2 != -1)
								{
									P_0.ReportProgress(num3, (object)P_2);
								}
								else
								{
									P_0.ReportProgress(num3);
								}
								for (int j = 0; j < array2.Length; j++)
								{
									string obj = array2[j];
									byte[] array4 = File.ReadAllBytes(obj);
									string fileName = Path.GetFileName(obj);
									if (c != 0 || !CD.aZd.ContainsKey(fileName) || CD.aZd[fileName] != array4.Length)
									{
										string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG() + fileName;
										uint num4 = new global::crc.crc().crc_process(array4, 0u, (uint)array4.Length, 4294967295u, partial: false);
										bool flag = false;
										if (array3 != null)
										{
											global::A.j[] array5 = array3;
											foreach (global::A.j j2 in array5)
											{
												if (j2.a() == text2)
												{
													if (num4 == j2.Ch)
													{
														flag = true;
													}
													break;
												}
											}
										}
										if (!flag)
										{
											global::A.j obj2 = new global::A.j();
											obj2.A(text2);
											obj2.CH = (uint)array4.Length;
											obj2.Cg = c;
											obj2.Ch = num4;
											global::A.j j3 = obj2;
											global::A.N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TU() + fileName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu(), false);
											A(j3, array4, out var text3);
											if (text3 != null)
											{
												if (P_4 == null)
												{
													P_4 = text3;
												}
												else
												{
													P_4 = P_4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv() + text3;
												}
											}
										}
									}
									if (!A(Qz.aXc, false))
									{
										break;
									}
									int num5 = num3 + (j + 1) * (num * 9 / 10) / array2.Length;
									if (P_2 != -1)
									{
										P_0.ReportProgress(num5, (object)P_2);
									}
									else
									{
										P_0.ReportProgress(num5);
									}
								}
							}
						}
						if (!A(Qz.aXc, false))
						{
							break;
						}
					}
				}
			}
			if (Qz.awW != null)
			{
				A(P_0, 80, 20, Qz.awW.ay(), P_2, P_3, out var text4);
				if (text4 != null)
				{
					if (P_4 == null)
					{
						P_4 = text4;
					}
					else
					{
						P_4 = P_4 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rv() + text4;
					}
				}
			}
			if (P_2 != -1)
			{
				P_0.ReportProgress(100, (object)P_2);
			}
			else
			{
				P_0.ReportProgress(100);
			}
			Thread.Sleep(500);
		}

		private void A(global::A.j P_0, byte[] P_1, out string P_2)
		{
			P_2 = null;
			bool flag;
			do
			{
				if (global::A.A.A(Qz.aXc, P_0, 0u, P_1, out var b, out flag))
				{
					if (b != 0)
					{
						P_2 = string.Concat(new string[5]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tu(),
							P_0.a(),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TV(),
							global::A.A.A(b),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
						});
					}
					break;
				}
			}
			while (!flag && A(Qz.aXc, false));
		}

		private void a(string P_0, bW P_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.DoWork += new DoWorkEventHandler(T);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(T);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tv());
			val.RunWorkerAsync((object)new object[2] { P_0, P_1 });
		}

		private void T(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			string text = (P_1.Argument as object[])[0] as string;
			bW bW = (P_1.Argument as object[])[1] as bW;
			bW bW2 = Cq.a(text);
			val.ReportProgress(10);
			string text2 = string.Empty;
			if (bW2 != null && bW != null)
			{
				string text3 = bT.A(bW2.axS, bW2.axs, bW2.axT, bW2.axt, true);
				if (!string.IsNullOrEmpty(text3))
				{
					if (bW2 == bW)
					{
						val.ReportProgress(20);
						Qz = new Framework(text3, bW2.axS, bW2.axs, bW2.axT);
						if (Qz.a() == bV.A.Brc)
						{
							val.ReportProgress(60);
							if (new Cq(text, Qz).A(out text2) && string.IsNullOrEmpty(text2))
							{
								val.ReportProgress(70);
								Qz.N();
								Qz.a(Qz.awj);
								Qz.a((HashSet<DataIdAndAttrId>)null);
								Qz.A(null, Qn, qf);
								Qz.A((HashSet<DataIdAndAttrId>)null);
								val.ReportProgress(90);
							}
						}
						else
						{
							text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TW();
						}
					}
					else
					{
						string text4 = bT.A(bW.axS, bW.axs, bW.axT, bW.axt, true);
						if (!string.IsNullOrEmpty(text4))
						{
							Qz = new Framework(text4, bW.axS, bW.axs, bW.axT);
							if (Qz.a() == bV.A.Brc)
							{
								val.ReportProgress(30);
								Framework framework = new Framework(text3, bW2.axS, bW2.axs, bW2.axT);
								if (framework.a() == bV.A.Brc)
								{
									val.ReportProgress(50);
									if (new Cq(text, framework).A(out text2) && string.IsNullOrEmpty(text2))
									{
										val.ReportProgress(60);
										Qz.C(Qz.aWS);
										Qz.A(framework, Qz.aWS, true, false);
										Qz.A(framework, false);
										Qz.c(Qz.aWS);
										val.ReportProgress(80);
										Qz.N();
										Qz.a(Qz.awj);
										Qz.a((HashSet<DataIdAndAttrId>)null);
										Qz.A(null, Qn, qf);
										Qz.A((HashSet<DataIdAndAttrId>)null);
									}
								}
								else
								{
									text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TW();
								}
							}
							else
							{
								text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tw();
							}
						}
						else
						{
							string[] obj = new string[6]
							{
								D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TX(),
								null,
								null,
								null,
								null,
								null
							};
							System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(13, 1);
							defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tx());
							defaultInterpolatedStringHandler.AppendFormatted<int>(bW.axS);
							defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy());
							obj[1] = defaultInterpolatedStringHandler.ToStringAndClear();
							defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(13, 1);
							defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TY());
							defaultInterpolatedStringHandler.AppendFormatted<int>(bW.axs);
							defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy());
							obj[2] = defaultInterpolatedStringHandler.ToStringAndClear();
							defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(11, 1);
							defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ty());
							defaultInterpolatedStringHandler.AppendFormatted<global::A.k>(bW.axT);
							defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy());
							obj[3] = defaultInterpolatedStringHandler.ToStringAndClear();
							obj[4] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TZ();
							obj[5] = BitConverter.ToString(bW.axt);
							text2 = string.Concat(obj);
						}
					}
				}
				else
				{
					text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tz();
				}
			}
			else
			{
				text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tA();
			}
			val.ReportProgress(100);
			Thread.Sleep(500);
			P_1.Result = text2;
		}

		private void T(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			P();
			string text = (string)P_1.Result;
			if (string.IsNullOrEmpty(text))
			{
				if (!qW && a(true))
				{
					((ToolStripItem)rm).Enabled = true;
					((ToolStripItem)rN).Enabled = true;
					((ToolStripItem)rM).Enabled = true;
					((ToolStripItem)RL).Enabled = true;
					((ToolStripItem)rP).Enabled = true;
					((ToolStripItem)rR).Enabled = true;
					((ToolStripItem)rt).Enabled = true;
					((ToolStripItem)Rx).Enabled = true;
					((ToolStripItem)Ri).Enabled = true;
					((ToolStripItem)RZ).Enabled = true;
					((ToolStripItem)RM).Enabled = true;
					((ToolStripItem)rb).Enabled = true;
					((ToolStripItem)Sb).Enabled = true;
					((ToolStripItem)Sc).Enabled = true;
					((ToolStripItem)SC).Enabled = true;
					((ToolStripItem)rc).Enabled = Qz != null && Qz.awm != null;
					QZ = string.Empty;
					A(true);
				}
				if (qS != null || qr)
				{
					qS = null;
					qr = false;
					qs = null;
					qT = true;
					B(true);
				}
			}
			else
			{
				qS = null;
				qr = false;
				qs = null;
				qT = false;
				if (qW)
				{
					Console.WriteLine();
					Console.WriteLine(text);
					Environment.Exit(1);
				}
				else
				{
					bE.A((IWin32Window)(object)this, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
		}

		private void A(bW P_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true
			};
			val.DoWork += new DoWorkEventHandler(t);
			object obj = BM.t.Bqk;
			if (obj == null)
			{
				ProgressChangedEventHandler val2 = a;
				BM.t.Bqk = val2;
				obj = (object)val2;
			}
			val.ProgressChanged += (ProgressChangedEventHandler)obj;
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(T);
			C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ta());
			val.RunWorkerAsync((object)P_0);
		}

		private void t(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			val.ReportProgress(0);
			bW bW = P_1.Argument as bW;
			string result = string.Empty;
			if (bW != null)
			{
				string text = bT.A(bW.axS, bW.axs, bW.axT, bW.axt, true);
				val.ReportProgress(10);
				if (!string.IsNullOrEmpty(text))
				{
					Qz = new Framework(text, bW.axS, bW.axs, bW.axT);
					if (Qz.a() == bV.A.Brc)
					{
						val.ReportProgress(50);
						Qz.A(Qz.aWS);
						val.ReportProgress(70);
						Qz.N();
						Qz.a(Qz.awj);
						Qz.a((HashSet<DataIdAndAttrId>)null);
						Qz.A(null, Qn, qf);
						Qz.A((HashSet<DataIdAndAttrId>)null);
						val.ReportProgress(80);
					}
					else
					{
						result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tB();
					}
				}
				else
				{
					string[] obj = new string[6]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tb(),
						null,
						null,
						null,
						null,
						null
					};
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Tx());
					defaultInterpolatedStringHandler.AppendFormatted<int>(bW.axS);
					defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy());
					obj[1] = defaultInterpolatedStringHandler.ToStringAndClear();
					defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TY());
					defaultInterpolatedStringHandler.AppendFormatted<int>(bW.axs);
					defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy());
					obj[2] = defaultInterpolatedStringHandler.ToStringAndClear();
					defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(11, 1);
					defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ty());
					defaultInterpolatedStringHandler.AppendFormatted<global::A.k>(bW.axT);
					defaultInterpolatedStringHandler.AppendLiteral(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy());
					obj[3] = defaultInterpolatedStringHandler.ToStringAndClear();
					obj[4] = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TZ();
					obj[5] = BitConverter.ToString(bW.axt);
					result = string.Concat(obj);
				}
			}
			else
			{
				result = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tA();
			}
			val.ReportProgress(100);
			Thread.Sleep(500);
			P_1.Result = result;
		}

		static BM()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Expected O, but got Unknown
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Expected O, but got Unknown
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Expected O, but got Unknown
			//IL_0301: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Expected O, but got Unknown
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Expected O, but got Unknown
			//IL_0315: Unknown result type (might be due to invalid IL or missing references)
			//IL_031f: Expected O, but got Unknown
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0329: Expected O, but got Unknown
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Expected O, but got Unknown
			//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e2: Expected O, but got Unknown
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0418: Expected O, but got Unknown
			//IL_0418: Unknown result type (might be due to invalid IL or missing references)
			//IL_0422: Expected O, but got Unknown
			//IL_0438: Unknown result type (might be due to invalid IL or missing references)
			//IL_0442: Expected O, but got Unknown
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c9: Expected O, but got Unknown
			int[] array = new int[10];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			sl = array;
			sS = 0.8f;
			su = (FormWindowState)2;
			sV = false;
			sv = false;
			sW = false;
			sw = false;
			sX = false;
			sx = false;
			sY = new HashSet<DataIdAndAttrId>();
			sy = new HashSet<DataIdAndAttrId>();
			sZ = new HashSet<DataIdAndAttrId>();
			sz = new Timer();
			TA = new Stopwatch();
			Ta = new object();
			TB = false;
			Tb = false;
			TC = System.DateTime.Now;
			Tc = false;
			Td = false;
			TF = new OpenFileDialog();
			Th = new OpenFileDialog();
			TI = string.Empty;
			TJ = 1;
			TK = null;
			Tk = new SaveFileDialog();
			TL = false;
			TM = false;
			Tm = new List<string>();
			TO = false;
			To = false;
			Tp = BM.S.BqI;
			Tt = true;
			TU = true;
			Tu = 90;
			TV = 90;
			Tv = 0;
			TW = 39;
			Tw = false;
			TX = 0f;
			Tx = 0f;
			TY = 0f;
			tD = Color.DarkOrchid;
			ts = new Label();
			tT = null;
			tt = null;
			tU = false;
			tu = -1;
			tV = false;
		}

		[CompilerGenerated]
		private void an()
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.tJ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}
	internal enum Bm
	{
		tW,
		tw,
		tX
	}
}
namespace b
{
	internal enum bM
	{
		aCg,
		aCH
	}
	internal enum bm
	{
		aCh,
		aCI,
		aCi,
		aCJ
	}
}
