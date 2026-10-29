using System;
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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using ImageMagick;
using NSP.Internet;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using NSP.UserInterface.Forms;
using NexusUpdaterAWS;
using crc;
using ns0;
using ns1;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;

namespace ns4;

internal class Form23 : Form
{
	private delegate void Delegate106(object sender, ElapsedEventArgs e);

	private enum Enum59
	{
		BpC,
		Bpc,
		BpD,
		Bpd,
		BpE,
		Bpe
	}

	private delegate void Delegate107(object sender, ElapsedEventArgs e);

	internal enum Enum60
	{
		BpF,
		Bpf,
		BpG
	}

	private struct Struct24
	{
		internal string Bpg;

		internal string BpH;

		internal Class240 Bph;

		internal Framework BpI;

		internal Class237.Enum91 Bpi;

		internal string BpJ;

		internal bool Bpj;
	}

	private struct Struct25
	{
		internal Struct24 BpK;

		internal UpdateOutcomes Bpk;

		internal string[] BpL;
	}

	internal enum Enum61
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

	internal class Class210
	{
		internal Class5 BpS;

		internal BackgroundWorker Bps;
	}

	private delegate void Delegate108(object sender, EventArgs e);

	private delegate void Delegate109(object sender, EventArgs2 e);

	private class Class211
	{
		internal Framework BpT;

		internal Class5 Bpt;
	}

	private class Class212
	{
		internal Class237.Enum91 BpU;

		internal Framework Bpu;

		internal Class5 BpV;
	}

	private class Class213
	{
		internal Framework Bpv;

		internal Class5 BpW;
	}

	private struct Struct26
	{
		internal Enum55 Bpw;

		internal bool BpX;

		internal bool Bpx;

		internal bool BpY;
	}

	private struct Struct27
	{
		internal bool Bpy;

		internal string BpZ;

		internal string Bpz;

		internal Enum55 BQA;

		internal bool BQa;

		internal bool BQB;

		internal bool BQb;

		internal bool BQC;
	}

	private struct Struct28
	{
		internal int BQc;

		internal int BQD;
	}

	private class Class214
	{
		internal Enum55 BQd;

		internal string BQE;

		internal string BQe;
	}

	private delegate void Delegate110(object sender, ElapsedEventArgs e);

	private class Class215
	{
		internal List<Class318> BQF;

		internal List<Class318> BQf;

		internal Dictionary<Enum88, List<Class318>> BQG;

		internal string BQg;
	}

	private struct Struct29
	{
		internal string BQH;

		internal Class240 BQh;

		internal Framework BQI;

		internal Framework BQi;

		internal string BQJ;

		internal bool BQj;

		internal Class237.Enum91 BQK;

		internal string BQk;

		internal bool BQL;
	}

	private struct Struct30
	{
		internal Struct29 BQl;

		internal UpdateOutcomes BQM;

		internal string[] BQm;
	}

	private struct Struct31
	{
		internal Class5 BQN;

		internal Framework BQn;

		internal UpdateOutcomes BQO;

		internal string[] BQo;
	}

	private struct Struct32
	{
		internal Class5 BQP;

		internal UpdateOutcomes BQp;

		internal string[] BQQ;
	}

	private class Class216
	{
		internal Class5 BQq;

		internal Class237.Enum91 BQR;
	}

	private delegate void Delegate111(object sender, ElapsedEventArgs e);

	private struct Struct33
	{
		internal UpdateOutcomes BQr;

		internal string[] BQS;
	}

	private struct Struct34
	{
		internal bool BQs;

		internal string BQT;

		internal Class237.Enum91 BQt;

		internal string BQU;

		internal string BQu;

		internal Class240 BQV;

		internal bool BQv;

		internal string BQW;
	}

	private struct Struct35
	{
		internal Struct34 BQw;

		internal UpdateOutcomes BQX;

		internal string[] BQx;
	}

	private delegate void Delegate112(object sender, EventArgs e);

	private struct Struct36
	{
		internal string BQY;

		internal bool BQy;
	}

	private struct Struct37
	{
		internal bool BQZ;

		internal string BQz;

		internal bool BqA;

		internal string Bqa;
	}

	private struct Struct38
	{
		internal Struct34 BqB;

		internal UpdateOutcomes Bqb;

		internal string[] BqC;
	}

	private struct Struct39
	{
		internal bool Bqc;

		internal string BqD;
	}

	private class Class217
	{
		internal Class237.Enum91 Bqd;

		internal Framework BqE;
	}

	private struct Struct40
	{
		internal Framework Bqe;

		internal bool BqF;

		internal bool Bqf;
	}

	internal enum Enum62
	{
		BqG,
		Bqg,
		BqH,
		Bqh
	}

	internal enum Enum63
	{
		BqI,
		Bqi,
		BqJ
	}

	private class Class218
	{
		internal bool Bqj;

		internal string BqK;
	}

	private delegate void Delegate113(object sender, RunWorkerCompletedEventArgs e);

	[CompilerGenerated]
	private static class Class219
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
	private sealed class Class220
	{
		public static readonly Class220 BqP = new Class220();

		public static Func<KeyValuePair<string, DataTableObject>, bool> Bqp;

		public static Action BqQ;

		public static Action Bqq;

		public static Action BqR;

		public static Action Bqr;

		public static Action BqS;

		public static Func<Class223, bool> Bqs;

		public static Func<Class223, bool> BqT;

		public static Func<Class223, bool> Bqt;

		public static Func<Class223, bool> BqU;

		internal bool method_0(KeyValuePair<string, DataTableObject> keyValuePair_0)
		{
			return keyValuePair_0.Value.IsErrorTable;
		}

		internal void method_1()
		{
			label_1.Text = Class333.smethod_1499();
		}

		internal void method_2()
		{
			smethod_66(Class333.BDz());
		}

		internal void method_3()
		{
			smethod_66(Class333.BdA());
		}

		internal void method_4()
		{
			smethod_66(Class333.Bda());
		}

		internal void method_5()
		{
			smethod_66(Class333.BdB());
		}

		internal bool method_6(Class223 class223_0)
		{
			return class223_0.method_4() == Enum64.const_2;
		}

		internal bool method_7(Class223 class223_0)
		{
			return class223_0.method_4() == Enum64.const_1;
		}

		internal bool method_8(Class223 class223_0)
		{
			return class223_0.method_4() == Enum64.const_2;
		}

		internal bool method_9(Class223 class223_0)
		{
			return class223_0.method_4() == Enum64.const_1;
		}
	}

	[CompilerGenerated]
	private sealed class Class221
	{
		public float Bqu;
	}

	[CompilerGenerated]
	private sealed class Class222
	{
		public uint BqV;

		public string Bqv;

		public Class221 BqW;

		internal void method_0()
		{
			label_1.Text = Class333.Bdb() + BqV + Class333.smethod_134() + Bqv + Class333.smethod_842() + string.Format(Class333.BdC(), BqW.Bqu) + Class333.Bdc();
		}
	}

	internal static Dictionary<int, Class209> dictionary_0 = new Dictionary<int, Class209>();

	[CompilerGenerated]
	private static EventHandler eventHandler_0;

	private static System.Timers.Timer timer_0 = new System.Timers.Timer();

	private static bool bool_0 = true;

	private static System.Timers.Timer timer_1 = new System.Timers.Timer();

	private static Enum59 enum59_0 = Enum59.BpC;

	private static bool bool_1 = false;

	internal static string string_0 = string.Empty;

	internal static Framework framework_0;

	internal static Enum60 enum60_0 = Enum60.BpF;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	internal static bool bool_2 = false;

	internal static readonly string string_1 = Class333.smethod_1730();

	internal static Form23 form23_0;

	internal static readonly string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	internal static readonly string string_3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	internal static readonly string string_4 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

	internal static readonly string string_5 = string_3 + Class333.smethod_2033();

	internal static readonly string string_6 = string_3 + Class333.smethod_2034();

	internal static readonly string string_7 = string_3 + Class333.smethod_2035();

	internal static readonly string string_8 = string_3 + Class333.smethod_2036();

	internal static readonly string string_9 = string_3 + Class333.smethod_2037();

	internal static readonly string string_10 = string_3 + Class333.smethod_2038();

	internal static readonly string string_11 = string_3 + Class333.smethod_2039();

	internal static readonly string string_12 = string_3 + Class333.smethod_2040();

	internal static readonly string string_13 = string_3 + Class333.smethod_2041();

	internal static readonly string string_14 = string_4 + Class333.smethod_2042();

	internal static readonly string string_15 = string_2 + Class333.smethod_2043();

	internal static readonly string string_16 = string_4 + Class333.smethod_2044();

	internal static readonly string string_17 = string_2 + Class333.smethod_2045();

	internal static readonly string string_18 = Class333.smethod_2046();

	internal static string string_19 = string.Empty;

	internal static Framework framework_1;

	internal static MenuNode menuNode_0;

	internal static MenuNode menuNode_1;

	internal static Dictionary<string, Class287> dictionary_1 = new Dictionary<string, Class287>();

	internal static object object_0 = new object();

	internal static Class286 class286_0 = null;

	internal static MenuNode menuNode_2 = null;

	internal static List<int> list_0 = new List<int>();

	internal StatsReporter statsReporter_0 = new StatsReporter();

	private static OpenFileDialog openFileDialog_0 = new OpenFileDialog();

	internal static bool bool_3 = false;

	internal static DataIdAndAttrId dataIdAndAttrId_0;

	internal static HashSet<DataIdAndAttrId> hashSet_0 = new HashSet<DataIdAndAttrId>();

	internal static Form63 form63_0;

	internal static Form62 form62_0;

	private static string string_20 = null;

	internal static object object_1 = new object();

	internal static volatile int int_0 = 0;

	internal bool bool_4;

	internal string string_21;

	internal string string_22;

	internal string string_23;

	internal string string_24;

	internal bool bool_5;

	internal Class14 class14_0;

	internal Dictionary<int, int> dictionary_2;

	internal Dictionary<int, List<int>> dictionary_3;

	internal string string_25;

	internal bool bool_6;

	internal string string_26;

	internal bool bool_7;

	internal string string_27;

	internal bool bool_8;

	internal bool bool_9;

	internal bool bool_10 = true;

	internal List<string> list_1 = new List<string>();

	internal bool bool_11;

	internal string string_28;

	internal Class240 class240_0;

	internal bool bool_12;

	internal string string_29;

	internal string string_30;

	internal bool bool_13;

	internal string string_31;

	internal string string_32;

	public static volatile bool bool_14 = false;

	private static bool bool_15 = false;

	private static bool bool_16 = false;

	internal static BackgroundWorker backgroundWorker_0 = null;

	internal static bool bool_17 = false;

	[CompilerGenerated]
	private static EventHandler eventHandler_2;

	private static Control control_0 = null;

	internal static Form43 form43_0;

	internal static Form3 form3_0;

	private static Form47 form47_0;

	private static Form21 form21_0;

	internal static bool bool_18 = false;

	private IContainer icontainer_0;

	private MenuStrip menuStrip_0;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	internal ToolStrip toolStrip_0;

	private Class130 class130_0;

	private Class130 class130_1;

	private Class131 class131_0;

	private Class131 class131_1;

	internal ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem toolStripMenuItem_7;

	private PictureBox pictureBox_0;

	private ToolStripSeparator toolStripSeparator_0;

	private ToolStripSeparator toolStripSeparator_1;

	internal ToolStripMenuItem toolStripMenuItem_8;

	internal ToolStripMenuItem toolStripMenuItem_9;

	internal ToolStripMenuItem toolStripMenuItem_10;

	private ToolStripMenuItem toolStripMenuItem_11;

	private ToolStripMenuItem toolStripMenuItem_12;

	private ToolStripMenuItem toolStripMenuItem_13;

	private ToolStripMenuItem toolStripMenuItem_14;

	private ToolStripMenuItem toolStripMenuItem_15;

	private ToolStripMenuItem toolStripMenuItem_16;

	private ToolStripMenuItem toolStripMenuItem_17;

	private ToolStripMenuItem toolStripMenuItem_18;

	private Class131 class131_2;

	private ToolStripMenuItem toolStripMenuItem_19;

	private ToolStripMenuItem toolStripMenuItem_20;

	private ToolStripMenuItem toolStripMenuItem_21;

	private ToolStripMenuItem toolStripMenuItem_22;

	private ToolStripMenuItem toolStripMenuItem_23;

	private ToolStripMenuItem toolStripMenuItem_24;

	private ToolStripMenuItem toolStripMenuItem_25;

	private Class168 class168_0;

	internal Class169 class169_0;

	private ToolStripMenuItem toolStripMenuItem_26;

	private ToolStripMenuItem toolStripMenuItem_27;

	private ToolStripMenuItem toolStripMenuItem_28;

	private ToolStripButton toolStripButton_0;

	internal ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private ToolStripButton toolStripButton_3;

	internal ToolStripButton toolStripButton_4;

	private ToolStripButton toolStripButton_5;

	private ToolStripButton toolStripButton_6;

	private ToolStripMenuItem toolStripMenuItem_29;

	private ToolStripMenuItem toolStripMenuItem_30;

	internal ToolStripButton toolStripButton_7;

	private ToolStripSeparator toolStripSeparator_2;

	internal ToolStripMenuItem toolStripMenuItem_31;

	private ToolStripMenuItem toolStripMenuItem_32;

	private ToolStripButton toolStripButton_8;

	private Class167 class167_0;

	private Class165 class165_0;

	private Class170 class170_0;

	private Class164 class164_0;

	private ToolStripButton toolStripButton_9;

	private Class166 class166_0;

	private ToolStripMenuItem toolStripMenuItem_33;

	private ToolStripButton toolStripButton_10;

	private Label label_0;

	private ToolStripSeparator toolStripSeparator_3;

	private ToolStripMenuItem toolStripMenuItem_34;

	private ToolStripMenuItem toolStripMenuItem_35;

	private ToolStripMenuItem toolStripMenuItem_36;

	private ToolStripMenuItem toolStripMenuItem_37;

	internal Control4 control4_0;

	internal Control25 control25_0;

	internal ToolStripMenuItem toolStripMenuItem_38;

	internal ToolStripMenuItem toolStripMenuItem_39;

	internal ToolStripButton toolStripButton_11;

	internal Control3 control3_0;

	internal Class162 class162_0;

	private ToolStripMenuItem toolStripMenuItem_40;

	internal ToolStripMenuItem toolStripMenuItem_41;

	private ToolStripButton toolStripButton_12;

	private SplitContainer splitContainer_0;

	internal Class131 class131_3;

	internal ToolStripMenuItem toolStripMenuItem_42;

	private ToolStripSeparator toolStripSeparator_4;

	private ToolStripMenuItem toolStripMenuItem_43;

	private ToolStripMenuItem toolStripMenuItem_44;

	private ToolStripMenuItem toolStripMenuItem_45;

	internal Class163 class163_0;

	private ToolStripMenuItem toolStripMenuItem_46;

	private ToolStripMenuItem toolStripMenuItem_47;

	private ToolStripMenuItem toolStripMenuItem_48;

	private ToolStripMenuItem toolStripMenuItem_49;

	private ToolStripSeparator toolStripSeparator_5;

	internal SplitContainer splitContainer_1;

	private ToolStripMenuItem toolStripMenuItem_50;

	private ToolStripMenuItem toolStripMenuItem_51;

	private ToolStripMenuItem toolStripMenuItem_52;

	private ToolStripMenuItem toolStripMenuItem_53;

	private ToolStripMenuItem toolStripMenuItem_54;

	private ToolStripMenuItem toolStripMenuItem_55;

	private ToolStripMenuItem toolStripMenuItem_56;

	private ToolStripMenuItem toolStripMenuItem_57;

	private StartupOptionsPanel startupOptionsPanel_0;

	internal ToolStripMenuItem toolStripMenuItem_58;

	internal ToolStripDropDownButton toolStripDropDownButton_0;

	internal ToolStripMenuItem toolStripMenuItem_59;

	private ToolStripButton toolStripButton_13;

	private ToolStripButton toolStripButton_14;

	internal const int int_1 = 40;

	private static bool bool_19 = true;

	internal static Stopwatch stopwatch_0 = new Stopwatch();

	private static bool bool_20 = false;

	internal static bool bool_21 = false;

	private static bool bool_22 = false;

	private static Class42 class42_0 = new Class42();

	[CompilerGenerated]
	private static EventHandler eventHandler_3;

	internal static List<Class210> list_2 = new List<Class210>();

	private static object object_2 = new object();

	private static DateTime dateTime_0 = DateTime.Now;

	internal static bool bool_23 = false;

	private static string string_33 = null;

	private static bool bool_24 = false;

	private bool bool_25;

	internal static bool bool_26 = false;

	internal static HashSet<DataIdAndAttrId> hashSet_1 = new HashSet<DataIdAndAttrId>();

	internal static HashSet<DataIdAndAttrId> hashSet_2 = new HashSet<DataIdAndAttrId>();

	private static int int_2 = -1;

	private static int int_3 = -1;

	private static ushort[] ushort_0 = new ushort[56];

	private static int int_4 = 0;

	private static List<Class223> list_3 = new List<Class223>();

	private static int int_5 = 0;

	private static System.Timers.Timer timer_2 = null;

	private static bool bool_27 = false;

	internal static PictureBox pictureBox_1 = null;

	internal static bool bool_28 = false;

	private static Panel panel_0;

	private const int int_6 = 600;

	internal static List<MenuNode> list_4 = new List<MenuNode>();

	private static bool bool_29 = false;

	private static byte[] byte_0 = null;

	private static Class14[] class14_1 = null;

	private static string string_34 = null;

	private static string string_35 = null;

	private static Panel panel_1 = new Panel();

	private static ProgressBar progressBar_0 = new ProgressBar();

	private static Label label_1 = new Label();

	private const int int_7 = 500;

	private const int int_8 = 90;

	private const int int_9 = 20;

	private const int int_10 = 15;

	private const int int_11 = 50;

	private const int int_12 = 20;

	private const int int_13 = 25;

	private const int int_14 = 650;

	private const int int_15 = 30;

	private const int int_16 = 300;

	private static Panel panel_2 = new Panel();

	private static Label label_2 = new Label();

	private static List<ProgressBar> list_5 = new List<ProgressBar>();

	private static List<Label> list_6 = new List<Label>();

	private static List<string> list_7 = null;

	private static int int_17 = 0;

	private static int int_18 = -1;

	private static int int_19 = 0;

	private static Image image_0;

	private static Image image_1;

	private static float float_0 = 0.7f;

	internal static bool bool_30 = false;

	internal static string string_36;

	internal static Form18 form18_0;

	internal static Control2 control2_0;

	private const int int_20 = 52;

	private const int int_21 = 10;

	private const int int_22 = 10;

	private static int[] int_23 = new int[10] { 208, 240, 272, 304, 336, 368, 400, 432, 464, 496 };

	private int[,,] int_24 = new int[10, 10, 52];

	private int[,,] int_25 = new int[10, 10, 52];

	private int[,,] int_26 = new int[10, 10, 52];

	private float[,] float_1 = new float[10, 10];

	private int[,] int_27 = new int[10, 10];

	private int[,] int_28 = new int[10, 10];

	private int[,] int_29 = new int[10, 10];

	private float float_2;

	private int[] int_30 = new int[10];

	private int int_31;

	private int[] int_32 = new int[10];

	private int[,] int_33 = new int[10, 10];

	private static float float_3 = 0.8f;

	internal static int int_34;

	internal static int int_35;

	internal static int int_36;

	internal static int int_37;

	internal static FormWindowState formWindowState_0 = FormWindowState.Maximized;

	private static bool bool_31 = false;

	private static bool bool_32 = false;

	private static bool bool_33 = false;

	internal static bool bool_34 = false;

	internal static bool bool_35 = false;

	private static bool bool_36 = false;

	private static HashSet<DataIdAndAttrId> hashSet_3 = new HashSet<DataIdAndAttrId>();

	private static HashSet<DataIdAndAttrId> hashSet_4 = new HashSet<DataIdAndAttrId>();

	private static HashSet<DataIdAndAttrId> hashSet_5 = new HashSet<DataIdAndAttrId>();

	private static System.Timers.Timer timer_3 = new System.Timers.Timer();

	private static Stopwatch stopwatch_1 = new Stopwatch();

	private static object object_3 = new object();

	private static bool bool_37 = false;

	private static bool bool_38 = false;

	private static DateTime dateTime_1 = DateTime.Now;

	private static bool bool_39 = false;

	[CompilerGenerated]
	private static EventHandler eventHandler_4;

	private static bool bool_40 = false;

	internal static Class301 class301_0;

	internal const int int_38 = 10;

	private static OpenFileDialog openFileDialog_1 = new OpenFileDialog();

	internal static Class284 class284_0;

	internal static Class284 class284_1;

	internal const string string_37 = "Auto Logs";

	internal const string string_38 = "Logs";

	private static OpenFileDialog openFileDialog_2 = new OpenFileDialog();

	internal static string string_39 = string.Empty;

	private static FileSystemWatcher fileSystemWatcher_0;

	private static int int_39 = 1;

	private static FileSystemWatcher fileSystemWatcher_1;

	private static Class302 class302_0 = null;

	private static SaveFileDialog saveFileDialog_0 = new SaveFileDialog();

	private static bool bool_41 = false;

	private static FileSystemWatcher fileSystemWatcher_2;

	private static bool bool_42 = false;

	private static List<string> list_8 = new List<string>();

	[CompilerGenerated]
	private static EventHandler eventHandler_5;

	internal static Enum62 enum62_0;

	internal static bool bool_43 = false;

	internal static bool bool_44 = false;

	internal const Enum63 enum63_0 = Enum63.BqI;

	internal static Enum63 enum63_1 = Enum63.BqI;

	internal const bool bool_45 = true;

	internal const bool bool_46 = true;

	internal const int int_40 = 90;

	internal const int int_41 = 90;

	internal const int int_42 = 0;

	internal const int int_43 = 39;

	internal const bool bool_47 = false;

	internal static bool bool_48 = true;

	internal static bool bool_49 = true;

	internal static int int_44 = 90;

	internal static int int_45 = 90;

	internal static int int_46 = 0;

	internal static int int_47 = 39;

	internal static bool bool_50 = false;

	internal static float float_4 = 0f;

	internal static float float_5 = 0f;

	internal static float float_6 = 0f;

	internal static Color color_0;

	internal static Color color_1;

	internal static Color color_2;

	internal static Color color_3;

	internal static Color color_4;

	internal static Color color_5;

	internal static Color color_6;

	internal static Color color_7;

	internal static Color color_8;

	internal static Color color_9 = Color.DarkOrchid;

	internal static Color color_10;

	internal static Color color_11;

	internal static Color color_12;

	internal static Color color_13;

	internal static Color color_14;

	internal static Color color_15;

	internal static Color color_16;

	internal static Color color_17;

	internal static Color color_18;

	internal static Color color_19;

	internal static Color color_20;

	internal static Color color_21;

	internal static Color color_22;

	internal static Color color_23;

	internal static Color color_24;

	internal static Color color_25;

	internal static Color color_26;

	internal static Color color_27;

	internal static Color color_28;

	internal static Color color_29;

	internal static Color color_30;

	internal static Color color_31;

	internal static Color color_32;

	internal static Color color_33;

	internal static Color color_34;

	internal static Color color_35;

	internal static Color color_36;

	internal static Image image_2;

	internal static Image image_3;

	[CompilerGenerated]
	private static EventHandler eventHandler_6;

	private static Label label_3 = new Label();

	private static TreeNode treeNode_0 = null;

	private static MenuNode menuNode_3 = null;

	private static bool bool_51 = false;

	private static int int_48 = -1;

	internal static bool bool_52 = false;

	internal const string string_40 = "You must enter a unique name or identifier for the vehicle (such as the registration plate). This will be used for creating a unique folder in the directory structure, where map files, log files and resources will be saved for the vehicle.";

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_0(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_1(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal static void smethod_2()
	{
		try
		{
			if (!File.Exists(string_8))
			{
				return;
			}
			using StreamReader streamReader = File.OpenText(string_8);
			Class209 @class = null;
			int num = -1;
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (text.StartsWith(Class333.smethod_1349()))
				{
					num = int.Parse(text.Substring(Class333.smethod_1349().Length));
					@class = new Class209();
					@class.int_0 = num;
					dictionary_0[num] = @class;
				}
				else if (num != -1 && dictionary_0.ContainsKey(num))
				{
					if (text.StartsWith(Class333.smethod_1350()))
					{
						int num2 = int.Parse(text.Substring(Class333.smethod_1350().Length));
						dictionary_0[num].int_1 = num2;
					}
					else if (text.StartsWith(Class333.smethod_1351()))
					{
						int num3 = int.Parse(text.Substring(Class333.smethod_1351().Length));
						dictionary_0[num].int_2 = num3;
					}
					else if (text.StartsWith(Class333.smethod_1352()))
					{
						int num4 = int.Parse(text.Substring(Class333.smethod_1352().Length));
						dictionary_0[num].int_3 = num4;
					}
					else if (text.StartsWith(Class333.smethod_1353()))
					{
						int num5 = int.Parse(text.Substring(Class333.smethod_1353().Length));
						dictionary_0[num].int_4 = num5;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1354() + ex.Message);
		}
	}

	internal static void smethod_3()
	{
		try
		{
			if (!Directory.Exists(string_3 + Class333.smethod_557()))
			{
				Directory.CreateDirectory(string_3 + Class333.smethod_557());
			}
			File.Create(string_8).Close();
			List<string> list = new List<string>();
			foreach (int key in dictionary_0.Keys)
			{
				Class209 @class = dictionary_0[key];
				list.Add(Class333.smethod_1349() + key);
				list.Add(Class333.smethod_1350() + @class.int_1);
				list.Add(Class333.smethod_1351() + @class.int_2);
				list.Add(Class333.smethod_1352() + @class.int_3);
				list.Add(Class333.smethod_1353() + @class.int_4);
				list.Add(Class333.smethod_102());
			}
			File.AppendAllLines(string_8, list);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1355() + ex.Message);
		}
	}

	internal static void smethod_4(int int_49, int int_50, int int_51, int int_52, int int_53)
	{
		Class209 @class;
		if (dictionary_0.ContainsKey(int_49))
		{
			@class = dictionary_0[int_49];
		}
		else
		{
			@class = new Class209();
			@class.int_0 = int_49;
		}
		@class.int_1 = int_50;
		@class.int_2 = int_51;
		@class.int_3 = int_52;
		@class.int_4 = int_53;
		if (!dictionary_0.ContainsKey(int_49))
		{
			dictionary_0.Add(int_49, @class);
		}
		if (eventHandler_0 != null)
		{
			eventHandler_0(null, null);
		}
	}

	private void toolStripMenuItem_20_Click(object sender, EventArgs e)
	{
		Form59 form = new Form59();
		form.ShowDialog(this);
		form.Dispose();
	}

	internal static void smethod_5(object sender, ProgressChangedEventArgs e)
	{
		string[] array = (e.UserState as string).Split('_');
		string text = array[1];
		if (!Class229.abK)
		{
			text += Class333.smethod_1356();
		}
		if (array[0] == Class333.smethod_1357())
		{
			form23_0.class162_0.method_7(Class162.Enum44.Bnm, e.ProgressPercentage, array[0], text);
		}
		else
		{
			form23_0.class162_0.method_7(Class162.Enum44.BnN, e.ProgressPercentage, array[0], text);
		}
	}

	internal void class162_0_Click(object sender, EventArgs e)
	{
		if (class162_0.Text == Class333.smethod_679())
		{
			Class229.smethod_9(bool_0: false);
		}
		else
		{
			if (Class229.smethod_10(bool_0: false))
			{
				return;
			}
			try
			{
				if (Class229.abJ)
				{
					if (Form54.smethod_4(this, Class333.smethod_1358(), Class333.smethod_1359(), MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						Class229.smethod_18(bool_0: false);
					}
				}
				else
				{
					Class229.smethod_30(bool_0: true);
				}
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.smethod_1360() + ex.Message);
			}
		}
		class162_0.method_6();
	}

	private void method_0()
	{
		timer_0.Interval = 1800000.0;
		timer_0.SynchronizingObject = this;
		timer_0.Elapsed += method_1;
		timer_0.AutoReset = true;
		timer_0.Enabled = true;
		timer_0.Start();
	}

	private void method_1(object sender, ElapsedEventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate106 method = method_1;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (bool_0)
		{
			bool_0 = false;
		}
		else
		{
			Class229.smethod_9(bool_0: true);
		}
	}

	private void method_2()
	{
		if (framework_1 == null || !framework_1.method_5() || !smethod_28(framework_1.aXc, bool_53: true))
		{
			return;
		}
		bool flag = false;
		Setting setting = framework_1.method_31(12);
		if (setting != null && setting.method_256() != 0)
		{
			flag = true;
		}
		if (flag)
		{
			if (enum59_0 == Enum59.BpC)
			{
				enum59_0 = Enum59.Bpc;
				bool flag2 = false;
				do
				{
					if (Form54.smethod_9(this, Class333.smethod_1361(), Class333.smethod_1362(), MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, new string[2]
					{
						Class333.smethod_1363(),
						Class333.smethod_1364()
					}) != DialogResult.Yes)
					{
						flag2 = true;
						BackgroundWorker backgroundWorker = new BackgroundWorker();
						backgroundWorker.WorkerReportsProgress = true;
						backgroundWorker.DoWork += method_203;
						backgroundWorker.ProgressChanged += smethod_69;
						backgroundWorker.RunWorkerCompleted += method_204;
						smethod_66(Class333.smethod_1370());
						backgroundWorker.RunWorkerAsync(true);
						continue;
					}
					openFileDialog_1.Title = Class333.smethod_1365();
					openFileDialog_1.Filter = Class333.smethod_1366();
					if (openFileDialog_1.ShowDialog(this) != DialogResult.OK)
					{
						continue;
					}
					Class240 @class = Class296.smethod_0(openFileDialog_1.FileName);
					if (@class != null)
					{
						if (@class.axS == framework_1.awZ && @class.axs == framework_1.awz)
						{
							if (@class.axT == framework_1.aXA)
							{
								flag2 = true;
								method_111(null, openFileDialog_1.FileName, @class, bool_53: true);
							}
							else
							{
								Form54.smethod_6(this, Class333.smethod_1367(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							}
						}
						else
						{
							Form54.smethod_6(this, Class333.smethod_1368(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
					else
					{
						Form54.smethod_6(this, Class333.smethod_1369(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				while (!flag2);
			}
			else if (enum59_0 == Enum59.Bpd)
			{
				enum59_0 = Enum59.BpE;
				BackgroundWorker backgroundWorker2 = new BackgroundWorker();
				backgroundWorker2.WorkerReportsProgress = true;
				backgroundWorker2.DoWork += method_6;
				backgroundWorker2.ProgressChanged += smethod_69;
				backgroundWorker2.RunWorkerCompleted += method_7;
				smethod_66(Class333.smethod_1371());
				backgroundWorker2.RunWorkerAsync(false);
			}
		}
		else
		{
			enum59_0 = Enum59.BpC;
		}
	}

	private void method_3()
	{
		timer_1.Interval = 1000.0;
		timer_1.SynchronizingObject = this;
		timer_1.Elapsed += method_4;
		timer_1.AutoReset = true;
		timer_1.Enabled = true;
		timer_1.Start();
	}

	private void method_4(object sender, ElapsedEventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate107 method = method_4;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_2();
	}

	private void method_5(object sender, EventArgs e)
	{
		if (Form54.smethod_6(this, Class333.smethod_1372(), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.DoWork += method_6;
			backgroundWorker.ProgressChanged += smethod_69;
			backgroundWorker.RunWorkerCompleted += method_7;
			smethod_66(Class333.smethod_1371());
			backgroundWorker.RunWorkerAsync(true);
		}
	}

	private void method_6(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		Class1.smethod_76(framework_1.aXc, 60000u);
		bool_1 = true;
		int num = 0;
		while (bool_1)
		{
			Thread.Sleep(500);
			num++;
			int percentProgress = Math.Min(num, 100);
			backgroundWorker.ReportProgress(percentProgress);
		}
		Class1.smethod_77(framework_1.aXc);
		backgroundWorker.ReportProgress(100);
		bool flag = (bool)e.Argument;
		e.Result = flag;
	}

	private void method_7(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		if (!(bool)e.Result)
		{
			enum59_0 = Enum59.Bpe;
			method_223(null, -1);
		}
	}

	private bool method_8(Class5 class5_0, out bool bool_53)
	{
		bool_53 = false;
		if (string_27 != null && (Class320.smethod_48(class5_0) || bool_8 || bool_9))
		{
			if (Class1.smethod_27().Count == 1)
			{
				method_78(string_27, Class1.smethod_27()[0], bool_8, bool_54: true, bool_10, list_1);
				return true;
			}
			if (!bool_14)
			{
				Form54.smethod_6(this, Class333.smethod_1373(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			bool_53 = true;
			return false;
		}
		if (class5_0.byte_4 == 22)
		{
			if (Class1.smethod_27().Count != 1)
			{
				if (!bool_14)
				{
					Form54.smethod_6(this, Class333.smethod_1374(), Class333.smethod_1375(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				bool_53 = true;
				return false;
			}
			if (string_27 != null && bool_14)
			{
				method_81(class5_0);
				return true;
			}
			if (!bool_14 && Form54.smethod_4(this, Class333.smethod_1376(), Class333.smethod_1377(), MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				method_81(class5_0);
				return true;
			}
			bool_53 = true;
			smethod_32(bool_53: true);
			return false;
		}
		if (Class242.smethod_12(class5_0.byte_4))
		{
			if (class5_0.bool_0)
			{
				if (!bool_14 && Form54.smethod_6(this, Class333.smethod_1378() + class5_0.byte_4 + Class333.smethod_1379() + class5_0.byte_5 + Class333.smethod_1380() + class5_0.ushort_0 + Class333.smethod_1381() + class5_0.string_0 + Class333.smethod_1382(), Class333.smethod_1383(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					method_76(class5_0, null);
					return true;
				}
			}
			else if (class5_0.byte_0 < 3)
			{
				if (bool_4)
				{
					method_77(Class320.Bdl + Class333.smethod_176() + string_23, class5_0);
					return true;
				}
				if (!bool_14)
				{
					Form54.smethod_6(this, Class333.smethod_1384(), Class333.smethod_1385(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				bool_53 = true;
			}
		}
		else if (Class320.smethod_48(class5_0) && !bool_14)
		{
			string text = ((class5_0.byte_4 != 21) ? Class333.smethod_1386() : string.Empty);
			if (Form54.smethod_6(this, Class333.smethod_1387() + class5_0.byte_4 + Class333.smethod_1379() + class5_0.byte_5 + Class333.smethod_1380() + class5_0.ushort_0 + Class333.smethod_1381() + class5_0.string_0 + Class333.smethod_190() + text, Class333.smethod_1383(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				method_76(class5_0, null);
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_9(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_10(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void toolStripMenuItem_47_Click(object sender, EventArgs e)
	{
		if (framework_0 == null)
		{
			toolStripMenuItem_46_Click(null, null);
			return;
		}
		if (enum60_0 == Enum60.BpF)
		{
			enum60_0 = Enum60.Bpf;
		}
		else if (enum60_0 == Enum60.Bpf)
		{
			enum60_0 = Enum60.BpG;
		}
		else
		{
			enum60_0 = Enum60.BpF;
		}
		class163_0.Invalidate();
		bool_2 = true;
		control4_0.method_14(bool_7: false, bool_8: true, bool_9: true, bool_10: false);
		control4_0.method_39(bool_7: false);
		if (framework_0 != null)
		{
			control4_0.method_40(bool_7: false);
		}
		if (eventHandler_1 != null)
		{
			eventHandler_1(null, null);
		}
		control25_0.method_27();
		bool_2 = false;
	}

	private void toolStripMenuItem_48_Click(object sender, EventArgs e)
	{
		method_117();
		smethod_9();
		framework_0 = null;
		enum60_0 = Enum60.BpF;
		hashSet_0.Clear();
		smethod_10(bool_53: false);
		string_0 = string.Empty;
		smethod_6();
		class163_0.method_1();
		ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_45;
		toolStripMenuItem_48.Enabled = false;
		toolStripMenuItem.Enabled = false;
		ToolStripMenuItem toolStripMenuItem2 = toolStripMenuItem_44;
		toolStripMenuItem_47.Enabled = false;
		toolStripMenuItem2.Enabled = false;
	}

	private void toolStripMenuItem_46_Click(object sender, EventArgs e)
	{
		if (framework_1 == null)
		{
			return;
		}
		openFileDialog_1.Title = Class333.smethod_1388();
		openFileDialog_1.Filter = Class242.smethod_5();
		if (openFileDialog_1.ShowDialog(this) == DialogResult.OK)
		{
			Class240 @class = Class296.smethod_0(openFileDialog_1.FileName);
			if (@class != null)
			{
				method_11(null, openFileDialog_1.FileName, @class);
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1369(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}

	private void method_11(string string_41, string string_42, Class240 class240_1)
	{
		Struct24 @struct = new Struct24
		{
			BpH = string_42,
			Bpg = string_41,
			Bph = class240_1
		};
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.DoWork += method_12;
		backgroundWorker.ProgressChanged += smethod_69;
		backgroundWorker.RunWorkerCompleted += method_13;
		smethod_66(Class333.smethod_1389());
		backgroundWorker.RunWorkerAsync(@struct);
	}

	private void method_12(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		Struct24 @struct = (Struct24)e.Argument;
		string text = @struct.Bpg;
		if (text == null && @struct.Bph != null)
		{
			text = Class234.smethod_8(@struct.Bph.axS, @struct.Bph.axs, @struct.Bph.axT, @struct.Bph.axt, bool_0: true);
		}
		backgroundWorker.ReportProgress(20);
		if (!string.IsNullOrEmpty(text) && @struct.Bph != null)
		{
			Framework framework = new Framework(text, @struct.Bph.axS, @struct.Bph.axs, @struct.Bph.axT);
			@struct.Bpi = framework.method_1();
			if (@struct.Bpi == Class237.Enum91.Brc)
			{
				backgroundWorker.ReportProgress(60);
				bool flag = new Class296(@struct.BpH, framework).method_1(out var text2, bool_0: false, bool_1: false, bool_2: true) && string.IsNullOrEmpty(text2);
				backgroundWorker.ReportProgress(70);
				framework.method_58();
				framework.method_37(framework.awj);
				framework.method_42(null);
				framework_1.method_40(null, framework, hashSet_0);
				framework_1.method_38(null);
				backgroundWorker.ReportProgress(90);
				@struct.BpI = framework;
				if (flag)
				{
					@struct.Bpj = true;
				}
				else
				{
					@struct.BpJ = text2;
					@struct.Bpj = false;
				}
			}
			else
			{
				@struct.Bpj = false;
			}
		}
		else
		{
			@struct.Bpi = Class237.Enum91.BrD;
			@struct.Bpj = false;
		}
		e.Result = @struct;
		Thread.Sleep(100);
		backgroundWorker.ReportProgress(100);
	}

	private void method_13(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		Struct24 @struct = (Struct24)e.Result;
		bool flag = true;
		if (!@struct.Bpj)
		{
			flag = false;
			if (@struct.Bpi == Class237.Enum91.BrD)
			{
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += Class229.smethod_44;
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.ProgressChanged += smethod_69;
				smethod_66(Class333.smethod_1390());
				BackgroundWorker backgroundWorker2 = new BackgroundWorker();
				backgroundWorker2.DoWork += method_14;
				backgroundWorker2.RunWorkerCompleted += method_15;
				backgroundWorker.RunWorkerAsync();
				backgroundWorker2.RunWorkerAsync(@struct);
				Class229.abM = true;
			}
			else
			{
				string empty = string.Empty;
				if (@struct.Bpi == Class237.Enum91.Brd)
				{
					empty = Class333.smethod_1391();
				}
				else if (@struct.Bpi == Class237.Enum91.BrE)
				{
					empty = Class333.smethod_1392();
				}
				else
				{
					string text = Class242.smethod_10(@struct.Bph.axS, @struct.Bph.axs);
					text = ((text != null) ? (Class333.smethod_1393() + text + Class333.smethod_1394()) : string.Empty);
					if (@struct.Bpi == Class237.Enum91.Bre)
					{
						empty = Class333.smethod_1395() + text + Class333.smethod_1396() + @struct.Bph.axT.ToString();
					}
					else
					{
						empty = ((!string.IsNullOrEmpty(@struct.BpJ)) ? @struct.BpJ : (Class333.smethod_1397() + text + Class333.smethod_1396() + @struct.Bph.axT.ToString()));
					}
				}
				if (1 != 0)
				{
					if (Form54.smethod_6(this, empty + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
					{
						while (openFileDialog_0.ShowDialog(this) == DialogResult.OK)
						{
							if (method_16(openFileDialog_0.FileName, @struct))
							{
								return;
							}
						}
					}
				}
				else if (Form54.smethod_9(this, @struct.BpJ + Class333.smethod_1399(), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, new string[2]
				{
					Class333.smethod_1400(),
					Class333.smethod_1401()
				}) == DialogResult.Yes)
				{
					while (openFileDialog_0.ShowDialog(this) == DialogResult.OK)
					{
						if (method_16(openFileDialog_0.FileName, @struct))
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
		if (@struct.BpI.method_2() && @struct.BpI.method_3())
		{
			if (@struct.BpI.method_60(bool_0: true, bool_1: true) == DialogResult.Cancel)
			{
				toolStripMenuItem_48_Click(null, null);
				return;
			}
			framework_1.method_40(null, @struct.BpI, hashSet_0);
		}
		method_117();
		smethod_9();
		framework_0 = @struct.BpI;
		smethod_10(bool_53: false);
		string_0 = @struct.BpH;
		smethod_6();
		class163_0.method_2();
		ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_45;
		toolStripMenuItem_48.Enabled = true;
		toolStripMenuItem.Enabled = true;
		ToolStripMenuItem toolStripMenuItem2 = toolStripMenuItem_44;
		toolStripMenuItem_47.Enabled = true;
		toolStripMenuItem2.Enabled = true;
	}

	private void method_14(object sender, DoWorkEventArgs e)
	{
		Struct24 bpK = (Struct24)e.Argument;
		string text = Class320.smethod_13(bpK.Bph, ushort.MaxValue);
		string[] bpL = Class229.smethod_46(bpK.Bph.axT, bpK.Bph.axS, bpK.Bph.axs, text, out var nullable_, out var updateOutcomes_);
		Struct25 @struct = new Struct25
		{
			BpK = bpK
		};
		if (nullable_.HasValue && updateOutcomes_ == UpdateOutcomes.CompleteUpdate)
		{
			@struct.Bpk = updateOutcomes_;
			@struct.BpL = bpL;
		}
		e.Result = @struct;
	}

	private void method_15(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct25 @struct = (Struct25)e.Result;
		smethod_68();
		if (@struct.BpL != null && @struct.BpL.Length != 0)
		{
			string[] bpL = @struct.BpL;
			foreach (string text in bpL)
			{
				List<string> list;
				if (text.EndsWith(Class333.smethod_1402()))
				{
					list = new List<string>();
					list.Add(text);
				}
				else
				{
					list = Class234.smethod_13(text);
				}
				if (list.Count != 0 && method_16(text, @struct.BpK))
				{
					return;
				}
			}
		}
		string text2 = Class242.smethod_10(@struct.BpK.Bph.axS, @struct.BpK.Bph.axs);
		string text3 = string.Concat(str1: (text2 != null) ? (Class333.smethod_1393() + text2 + Class333.smethod_1394()) : string.Empty, str0: Class333.smethod_1403(), str2: Class333.smethod_1396(), str3: @struct.BpK.Bph.axT.ToString());
		if (Form54.smethod_6(this, text3 + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_16(openFileDialog_0.FileName, @struct.BpK))
			{
			}
		}
	}

	private bool method_16(string string_41, Struct24 struct24_0)
	{
		try
		{
			if (struct24_0.Bph == null)
			{
				return false;
			}
			string text = null;
			bool flag;
			bool flag2;
			bool flag3;
			Class14 @class;
			if (string_41.EndsWith(Class333.smethod_1404()))
			{
				flag = Class320.smethod_12(string_41, struct24_0.Bph, out flag2, out flag3, out @class, out text);
			}
			else
			{
				text = string_41;
				flag = Class234.smethod_5(string_41, struct24_0.Bph, out flag2, out flag3, out @class);
			}
			if (flag && text != null)
			{
				method_11(text, struct24_0.BpH, struct24_0.Bph);
				return true;
			}
			if (!(@class == null) && text != null)
			{
				if (!flag2)
				{
					Form54.smethod_6(this, Class333.smethod_1406(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (!flag3)
				{
					Form54.smethod_6(this, Class333.smethod_1407() + @class.ToString() + Class333.smethod_1408() + struct24_0.Bph.axT.ToString() + Class333.smethod_9(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					Form54.smethod_6(this, Class333.smethod_1409(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1405(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1410() + ex.Message);
		}
		return false;
	}

	internal Form23(bool bool_53, bool bool_54)
	{
		bool_14 = bool_53;
		if (!Directory.Exists(string_2 + Class333.smethod_1411()))
		{
			Directory.CreateDirectory(string_2 + Class333.smethod_1411());
		}
		Class234.smethod_3();
		Class305.smethod_0();
		Class307.smethod_3();
		method_17();
		method_19();
		method_174();
		method_175();
		method_167();
		method_172();
		Class288.smethod_2();
		method_205();
		method_211();
		if (!bool_14)
		{
			method_34();
		}
		form23_0 = this;
		if (!bool_14)
		{
			foreach (ToolStripItem item in menuStrip_0.Items)
			{
				if (item is ToolStripMenuItem)
				{
					(item as ToolStripMenuItem).Paint += method_216;
				}
			}
			method_86();
			method_87();
			openFileDialog_1.InitialDirectory = string_2 + Class333.smethod_522() + string_18;
			openFileDialog_2.Title = Class333.smethod_1412();
			openFileDialog_2.Filter = Class333.smethod_1413();
			openFileDialog_0.InitialDirectory = string_2 + Class333.smethod_1411();
			openFileDialog_0.Title = Class333.smethod_1414();
			openFileDialog_0.Filter = Class333.smethod_1415();
			color_0 = Color.FromArgb(255, 199, 44);
			color_1 = Color.FromArgb(43, 44, 39);
			color_2 = Color.FromArgb(158, 158, 158);
			color_3 = Color.FromArgb(37, 37, 38);
			color_4 = Color.FromArgb(30, 30, 30);
			color_5 = Color.FromArgb(62, 62, 66);
			color_6 = Color.FromArgb(104, 104, 104);
			color_7 = Color.FromArgb(240, 40, 20);
			color_8 = Color.FromArgb(160, 18, 18);
			float_0 = (float)(splitContainer_0.Width - 258) / (float)splitContainer_0.Width;
			float_3 = (float)(splitContainer_1.Height - control3_0.panel_0.Height + 6) / (float)splitContainer_1.Height;
			method_213();
			method_24();
		}
		if (File.Exists(Form9.string_0))
		{
			using StreamReader streamReader = File.OpenText(Form9.string_0);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (text.StartsWith(Class333.smethod_893()))
				{
					bool_21 = bool.Parse(text.Substring(Class333.smethod_893().Length));
				}
			}
		}
		else
		{
			bool_21 = false;
		}
		Form10.smethod_0();
		Class36.smethod_0();
		Class233.smethod_7();
		smethod_2();
		if (!bool_14)
		{
			control4_0.method_0().method_39(method_217);
			method_220();
			menuNode_0 = new MenuNode(null, null, null, bool_0: false, bool_1: false, string.Empty);
			menuNode_0.method_4(-1);
			menuNode_0.method_11(Class333.smethod_1195());
			menuNode_0.method_69(Class333.smethod_1416());
			menuNode_0.method_13(0);
			menuNode_1 = new MenuNode(null, null, null, bool_0: false, bool_1: true, string.Empty);
			menuNode_1.method_4(-1);
			menuNode_1.method_11(Class333.smethod_1417());
			menuNode_1.method_69(Class333.smethod_1418());
			menuNode_1.method_13(0);
			smethod_60();
			class301_0 = new Class301(toolStripMenuItem_49, 10);
			class301_0.method_0(method_148);
			class284_0 = new Class284(Class284.Enum109.BsO);
			class284_1 = new Class284(Class284.Enum109.Bso);
		}
		else if (bool_54)
		{
			Class1.smethod_10(method_37);
			Class1.smethod_12(method_40);
			Class1.smethod_0();
		}
	}

	private void Form23_Shown(object sender, EventArgs e)
	{
		smethod_6();
		if (File.Exists(string_5))
		{
			using StreamReader streamReader = File.OpenText(string_5);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (text.StartsWith(Class333.smethod_1419()))
				{
					if (bool.Parse(text.Substring(Class333.smethod_1419().Length)))
					{
						WindowState = FormWindowState.Maximized;
					}
					else
					{
						WindowState = FormWindowState.Normal;
					}
				}
				else if (text.StartsWith(Class333.smethod_1420()))
				{
					ClientSize = new Size(int.Parse(text.Substring(Class333.smethod_1420().Length)), ClientSize.Height);
				}
				else if (text.StartsWith(Class333.smethod_1421()))
				{
					ClientSize = new Size(ClientSize.Width, int.Parse(text.Substring(Class333.smethod_1421().Length)));
				}
				else if (text.StartsWith(Class333.smethod_1422()))
				{
					Location = new Point(int.Parse(text.Substring(Class333.smethod_1422().Length)), Location.Y);
				}
				else if (text.StartsWith(Class333.smethod_1423()))
				{
					Location = new Point(Location.X, int.Parse(text.Substring(Class333.smethod_1423().Length)));
				}
				else if (text.StartsWith(Class333.smethod_1424()))
				{
					class131_0.Visible = bool.Parse(text.Substring(Class333.smethod_1424().Length));
				}
				else if (text.StartsWith(Class333.smethod_1425()))
				{
					class131_1.Visible = bool.Parse(text.Substring(Class333.smethod_1425().Length));
				}
				else if (text.StartsWith(Class333.smethod_1426()))
				{
					class131_2.Visible = bool.Parse(text.Substring(Class333.smethod_1426().Length));
				}
				else if (text.StartsWith(Class333.smethod_1427()))
				{
					class131_3.Visible = bool.Parse(text.Substring(Class333.smethod_1427().Length));
					if (class131_3.Visible)
					{
						bool_30 = true;
						method_92();
					}
				}
				else if (text.StartsWith(Class333.smethod_1428()))
				{
					float_0 = float.Parse(Class23.smethod_11(text.Substring(Class333.smethod_1428().Length)), CultureInfo.CurrentCulture);
					if (float_0 < 0f || float_0 > 1f)
					{
						float_0 = 0.7f;
					}
				}
				else if (text.StartsWith(Class333.smethod_1429()))
				{
					float_3 = float.Parse(Class23.smethod_11(text.Substring(Class333.smethod_1429().Length)), CultureInfo.CurrentCulture);
					if (float_3 < 0f || float_3 > 1f)
					{
						float_3 = 0.8f;
					}
				}
				else if (text.StartsWith(Class333.smethod_1430()))
				{
					control4_0.Visible = bool.Parse(text.Substring(Class333.smethod_1430().Length));
				}
				else if (text.StartsWith(Class333.smethod_1431()))
				{
					control4_0.Width = int.Parse(text.Substring(Class333.smethod_1431().Length));
				}
				else if (text.StartsWith(Class333.smethod_1432()))
				{
					control4_0.method_2().Height = int.Parse(text.Substring(Class333.smethod_1432().Length));
					control4_0.method_10();
				}
				else if (text.StartsWith(Class333.smethod_1433()))
				{
					control4_0.method_0().method_1((Enum45)byte.Parse(text.Substring(Class333.smethod_1433().Length)));
				}
				else if (text.StartsWith(Class333.smethod_1434()))
				{
					float num = float.Parse(Class23.smethod_11(text.Substring(Class333.smethod_1434().Length)), CultureInfo.CurrentCulture);
					if (num < 4f || num > 20f)
					{
						num = 9f;
					}
					control4_0.method_0().Font = new Font(Font.FontFamily, num);
				}
				else if (text.StartsWith(Class333.smethod_1435()))
				{
					control4_0.method_6(!bool.Parse(text.Substring(Class333.smethod_1435().Length)));
				}
				else if (text.StartsWith(Class333.smethod_1436()))
				{
					float num2 = float.Parse(Class23.smethod_11(text.Substring(Class333.smethod_1436().Length)), CultureInfo.CurrentCulture);
					if (num2 < 4f || num2 > 20f)
					{
						num2 = 9f;
					}
					Class104.Bvd = num2;
				}
				else if (text.StartsWith(Class333.smethod_1437()))
				{
					Class104.BvF = (Class104.Bvf = (Enum70)byte.Parse(text.Substring(Class333.smethod_1437().Length)));
				}
				else if (text.StartsWith(Class333.smethod_1438()))
				{
					Class104.Bve = (Enum69)byte.Parse(text.Substring(Class333.smethod_1438().Length));
				}
				else if (text.StartsWith(Class333.smethod_1439()))
				{
					Class104.BvE = (Enum71)int.Parse(text.Substring(Class333.smethod_1439().Length));
				}
			}
		}
		else
		{
			class131_0.Visible = false;
			class131_1.Visible = false;
			class131_2.Visible = false;
			control4_0.Visible = true;
		}
		method_88();
		smethod_73();
		method_118();
		method_119();
		Thread.CurrentThread.Name = Class333.smethod_1440();
		if (Class229.smethod_3())
		{
			class162_0.Enabled = true;
			Class229.smethod_30(bool_0: false);
		}
		else
		{
			class162_0.Enabled = false;
		}
		method_129();
		method_71();
		method_0();
		method_3();
		Class302.smethod_3();
		class284_1.method_6();
		if (bool_4 && !File.Exists(Class320.Bdl + Class333.smethod_176() + string_23))
		{
			bool_4 = false;
			Form54.smethod_6(this, Class333.smethod_1441() + Class320.Bdl + Class333.smethod_176() + string_23 + Class333.smethod_1442(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		if (bool_4 && !string.IsNullOrEmpty(string_22) && !File.Exists(string_22))
		{
			bool_4 = false;
			Form54.smethod_6(this, Class333.smethod_1443() + string_22 + Class333.smethod_1442(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		if (bool_4)
		{
			Class1.smethod_5(string_21);
		}
		if (!bool_4)
		{
			Class229.smethod_0();
		}
		Class1.smethod_10(method_37);
		Class1.smethod_12(method_40);
		Class1.smethod_0();
		if (!Directory.Exists(string_2 + Class333.smethod_522() + string_18))
		{
			Directory.CreateDirectory(string_2 + Class333.smethod_522() + string_18);
		}
		if (!string.IsNullOrEmpty(string_24))
		{
			new Class298(string_24, bool_5, class14_0, dictionary_2, dictionary_3).method_0();
		}
		if (!string.IsNullOrEmpty(string_25))
		{
			new Class290(string_25, bool_6).method_0();
		}
		if (!string.IsNullOrEmpty(string_26))
		{
			new Class293(string_26, bool_7).method_0();
		}
		if (!string.IsNullOrEmpty(string_32))
		{
			try
			{
				Class240 @class = Class296.smethod_0(string_32);
				if (!(@class != null))
				{
					throw new Exception();
				}
				method_152(null, string_32, @class);
			}
			catch (Exception ex)
			{
				string_32 = null;
				Form54.smethod_6(this, Class333.smethod_1444() + string_32 + Class333.smethod_570() + ex.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		Class329.smethod_11();
	}

	private void Form23_FormClosing(object sender, FormClosingEventArgs e)
	{
		bool flag = e.CloseReason == CloseReason.ApplicationExitCall || e.CloseReason == CloseReason.UserClosing;
		if (smethod_87(this, flag) == DialogResult.Cancel)
		{
			e.Cancel = true;
			return;
		}
		bool_15 = true;
		if (class284_1 != null && (int_0 & 0x800) != 0)
		{
			class284_1.method_1();
		}
		if (form43_0 != null && !form43_0.IsDisposed)
		{
			try
			{
				form43_0.Close();
			}
			catch
			{
			}
		}
		if (form3_0 != null && !form3_0.IsDisposed)
		{
			try
			{
				form3_0.Close();
			}
			catch
			{
			}
		}
		if (form47_0 != null && !form47_0.IsDisposed)
		{
			try
			{
				form47_0.Close();
			}
			catch
			{
			}
		}
		statsReporter_0.StorePendingStats();
		Framework framework = framework_1;
		if (framework != null && framework.awZ == 21)
		{
			VirtualDashAppPanel.smethod_5();
		}
		smethod_66(Class333.smethod_1445());
		Application.DoEvents();
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		if (framework_1 != null)
		{
			int num = 0;
			while (Class1.smethod_25(framework_1.aXc) != Enum11.const_4 && smethod_34(bool_53: false))
			{
				int num2 = Math.Min(30, 30 * (int)stopwatch.ElapsedMilliseconds / 500);
				if (num2 != num || num2 == 30)
				{
					if (num != 30)
					{
						progressBar_0.Value = num2;
						num = num2;
					}
					if (stopwatch.ElapsedMilliseconds % 50L == 0L)
					{
						Application.DoEvents();
					}
				}
			}
		}
		Class1.smethod_2();
		control25_0.method_12(bool_0: false);
		progressBar_0.Value = 70;
		Application.DoEvents();
		method_117();
		progressBar_0.Value = 80;
		Class307.smethod_7();
		Class234.smethod_2();
		progressBar_0.Value = 90;
		if (class284_0 != null && (int_0 & 0x400) != 0)
		{
			class284_0.method_1();
		}
		Form10.smethod_1();
		progressBar_0.Value = 100;
		Application.DoEvents();
		stopwatch.Restart();
		while (stopwatch.ElapsedMilliseconds < 500L)
		{
			if (stopwatch.ElapsedMilliseconds % 50L == 0L)
			{
				Application.DoEvents();
			}
		}
		Visible = false;
		if (flag)
		{
			stopwatch.Restart();
			while (StatsReporter.StatsStorageInProgress)
			{
				if (stopwatch.ElapsedMilliseconds % 50L == 0L)
				{
					Application.DoEvents();
				}
			}
		}
		if (Class229.abP)
		{
			Class229.smethod_33();
		}
		if (Class229.abo)
		{
			Class229.smethod_32(bool_0: false);
		}
	}

	private void Form23_DragEnter(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			e.Effect = DragDropEffects.Copy;
		}
		else
		{
			e.Effect = DragDropEffects.None;
		}
	}

	private void Form23_DragDrop(object sender, DragEventArgs e)
	{
		try
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (array != null)
			{
				if (array.Length == 1)
				{
					if (array[0].EndsWith(Class333.smethod_146()))
					{
						method_149(array[0]);
						return;
					}
					if (array[0].EndsWith(Class333.smethod_488()))
					{
						method_160(array[0], bool_53: false);
						return;
					}
					throw new Exception(Class333.smethod_1446());
				}
				throw new Exception(Class333.smethod_1447());
			}
			throw new Exception(Class333.smethod_1448());
		}
		catch (Exception ex)
		{
			Form54.smethod_6(this, ex.Message, Class333.smethod_1449(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal static void smethod_6(bool bool_53 = true)
	{
		if (!bool_53 && (framework_1 == null || (framework_1.aXd && bool_16) || (!framework_1.aXd && !bool_16)))
		{
			return;
		}
		string text = string_1;
		if (framework_1 != null)
		{
			if (string_19 != string.Empty)
			{
				text = text + Class333.smethod_1450() + string_19 + Class333.smethod_180();
			}
			else if ((int_0 & 2) == 0)
			{
				string empty = string.Empty;
				if (framework_1.method_28(ref empty))
				{
					text = text + Class333.smethod_536() + empty;
				}
			}
			if (framework_1.aXd)
			{
				text += Class333.smethod_1451();
				bool_16 = true;
			}
			else
			{
				bool_16 = false;
			}
			if (string_39 != string.Empty)
			{
				text = text + Class333.smethod_1452() + Path.GetFileName(string_39) + Class333.smethod_528();
			}
			if (string_0 != string.Empty)
			{
				text = text + Class333.smethod_1453() + string_0 + Class333.smethod_528();
			}
		}
		if (form23_0.Text != text)
		{
			form23_0.Text = text;
		}
	}

	private void method_17()
	{
		backgroundWorker_0 = new BackgroundWorker();
		backgroundWorker_0.WorkerReportsProgress = false;
		backgroundWorker_0.WorkerSupportsCancellation = true;
		backgroundWorker_0.DoWork += method_18;
		backgroundWorker_0.RunWorkerAsync();
	}

	private void method_18(object sender, DoWorkEventArgs e)
	{
		Class320.smethod_38(backgroundWorker_0, 0, 0, null, ushort.MaxValue, null, null, bool_0: false, Enum88.avK, null, bool_1: false);
	}

	private void method_19()
	{
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.DoWork += method_20;
		backgroundWorker.RunWorkerAsync();
	}

	private void method_20(object sender, DoWorkEventArgs e)
	{
		Thread.CurrentThread.Name = Class333.smethod_1454();
		Class234.smethod_15();
	}

	private void menuStrip_0_Paint(object sender, PaintEventArgs e)
	{
		Image haltechSmallLogo = GeneralResources.HaltechSmallLogo;
		e.Graphics.DrawImage(haltechSmallLogo, ClientRectangle.Width - haltechSmallLogo.Width - 2, 2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_7(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_2;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_8(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_2;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal static void smethod_9()
	{
		if (!bool_14)
		{
			bool_17 = true;
			form23_0.method_73();
			form23_0.control25_0.method_6();
			form23_0.control4_0.method_7();
			if (eventHandler_2 != null)
			{
				eventHandler_2(null, null);
			}
			while (form23_0.class131_0.Controls.Count != 0)
			{
				Class30.smethod_0(form23_0.class131_0.Controls[0]);
			}
			while (form23_0.class131_1.Controls.Count != 0)
			{
				Class30.smethod_0(form23_0.class131_1.Controls[0]);
			}
			while (form23_0.class131_2.Controls.Count != 0)
			{
				Class30.smethod_0(form23_0.class131_2.Controls[0]);
			}
			int_2 = -1;
			int_3 = -1;
			smethod_42();
			bool_17 = false;
			form23_0.pictureBox_0.Visible = false;
			form23_0.startupOptionsPanel_0.Visible = false;
		}
	}

	internal static bool smethod_10(bool bool_53)
	{
		if (bool_14)
		{
			return false;
		}
		if (framework_1 != null)
		{
			if (framework_1.awZ == 21)
			{
				Class263.smethod_1(framework_1);
			}
			else
			{
				VirtualDashAppPanel.smethod_4();
				VirtualDashAppPanel.framework_0 = null;
				Class329.smethod_11();
				Class88.Bhl = null;
			}
			if (form47_0 != null)
			{
				if (form47_0.Visible)
				{
					form47_0.Hide();
				}
				form47_0.Dispose();
			}
			if (framework_1.method_2() && framework_1.method_3() && framework_1.method_60(bool_0: true, bool_1: false) == DialogResult.Cancel)
			{
				form23_0.pictureBox_0.Visible = true;
				form23_0.pictureBox_0.BringToFront();
				form23_0.startupOptionsPanel_0.Visible = true;
				form23_0.startupOptionsPanel_0.BringToFront();
				return false;
			}
			form23_0.pictureBox_0.Visible = false;
			form23_0.startupOptionsPanel_0.Visible = false;
			form23_0.label_0.Visible = false;
			form23_0.control25_0.Enabled = true;
			form23_0.control25_0.method_2();
			form23_0.control25_0.method_64();
		}
		form23_0.control4_0.method_9();
		if (framework_1 != null)
		{
			smethod_62();
			form23_0.control4_0.method_14(bool_7: true, bool_8: false, bool_9: true, bool_10: false);
			if ((int_0 & 1) == 0)
			{
				smethod_63();
			}
			if (bool_53)
			{
				int_2 = -1;
				int_3 = -1;
			}
			smethod_43();
			form23_0.control4_0.method_39(bool_7: true);
			form23_0.control4_0.method_40(bool_7: true);
			form23_0.method_72();
			if (framework_1.method_57(out var _, out var _))
			{
				form23_0.toolStripMenuItem_10.Visible = true;
				form23_0.toolStripButton_7.Visible = true;
			}
			else
			{
				form23_0.toolStripMenuItem_10.Visible = false;
				form23_0.toolStripButton_7.Visible = false;
			}
			form23_0.toolStripDropDownButton_0.Visible = framework_1.aww.ContainsKey(Class1.Enum5.BFH);
			form23_0.toolStripMenuItem_58.Visible = framework_1.aww.ContainsKey(Class1.Enum5.BFH);
			form23_0.toolStripMenuItem_59.Visible = framework_1.aww.ContainsKey(Class1.Enum5.BFh);
			form23_0.toolStripButton_13.Visible = framework_1.aWW.IsValid;
			form23_0.toolStripMenuItem_28.Enabled = framework_1.aWW.IsValid;
		}
		return true;
	}

	internal static void smethod_11()
	{
		if (framework_1 != null && framework_1.method_4())
		{
			form23_0.toolStripMenuItem_8.Enabled = true;
			form23_0.toolStripMenuItem_41.Enabled = true;
			form23_0.toolStripButton_1.Enabled = true;
			form23_0.toolStripMenuItem_9.Enabled = list_2.Count == 1 && Class1.smethod_25(list_2[0].BpS.string_0) != Enum11.const_1;
			form23_0.class169_0.Enabled = form23_0.toolStripMenuItem_9.Enabled;
			form23_0.toolStripMenuItem_10.Enabled = true;
			form23_0.toolStripButton_7.Enabled = true;
			form23_0.toolStripMenuItem_31.Enabled = framework_1.awm != null;
		}
		else
		{
			form23_0.toolStripMenuItem_8.Enabled = false;
			form23_0.toolStripMenuItem_41.Enabled = false;
			form23_0.toolStripButton_1.Enabled = false;
			form23_0.toolStripMenuItem_9.Enabled = false;
			form23_0.class169_0.Enabled = form23_0.toolStripMenuItem_9.Enabled;
			form23_0.toolStripMenuItem_10.Enabled = false;
			form23_0.toolStripButton_7.Enabled = false;
			form23_0.toolStripMenuItem_31.Enabled = false;
		}
	}

	private void method_21(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
	}

	private void method_22(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
	}

	private void toolStripButton_10_Click(object sender, EventArgs e)
	{
		if (control4_0.Visible)
		{
			control4_0.Visible = false;
		}
		else
		{
			control4_0.Visible = true;
		}
		smethod_73();
	}

	internal static void smethod_12(Control control_1)
	{
		if (control_1 is Class104 || control_1 is Class102 || control_1 is Class103)
		{
			control_0 = control_1;
			form23_0.toolStripButton_8.Enabled = true;
			form23_0.toolStripMenuItem_32.Enabled = true;
		}
	}

	internal static void smethod_13()
	{
		form23_0.toolStripButton_8.Enabled = false;
		form23_0.toolStripMenuItem_32.Enabled = false;
		control_0 = null;
	}

	private void toolStripButton_8_Click(object sender, EventArgs e)
	{
		if (control_0 == null)
		{
			return;
		}
		try
		{
			if (control_0 is Class104)
			{
				(control_0 as Class104).vmethod_3(null, null);
			}
			else if (control_0 is Class102)
			{
				(control_0 as Class102).vmethod_3(null, null);
			}
			else if (control_0 is Class103)
			{
				(control_0 as Class103).vmethod_3(null, null);
			}
		}
		catch
		{
		}
	}

	private void toolStripButton_5_Click(object sender, EventArgs e)
	{
		if (form3_0 != null && form3_0.Visible)
		{
			if (Form54.smethod_6(this, Class333.smethod_1455(), Class333.smethod_1456(), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
			{
				return;
			}
			form3_0.Close();
			form3_0.Dispose();
		}
		if (form43_0 != null)
		{
			if (form43_0.Visible)
			{
				form43_0.Activate();
				return;
			}
			form43_0.Dispose();
		}
		form43_0 = new Form43();
		form43_0.Location = new Point(Location.X + (Width - form43_0.Width) / 2, Location.Y + (Height - form43_0.Height) / 2);
		form43_0.Show(this);
	}

	private void toolStripButton_14_Click(object sender, EventArgs e)
	{
		if (form43_0 != null && form43_0.Visible)
		{
			if (Form54.smethod_6(this, Class333.smethod_1457(), Class333.smethod_1458(), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
			{
				return;
			}
			form43_0.Close();
			form43_0.Dispose();
		}
		if (form3_0 != null)
		{
			if (form3_0.Visible)
			{
				form3_0.Activate();
				return;
			}
			form3_0.Dispose();
		}
		form3_0 = new Form3();
		form3_0.Location = new Point(Location.X + (Width - form3_0.Width) / 2, Location.Y + (Height - form3_0.Height) / 2);
		form3_0.Show(this);
	}

	private void toolStripButton_4_Click(object sender, EventArgs e)
	{
		Form8 form = new Form8();
		form.ShowDialog(this);
		form.Dispose();
	}

	private void toolStripButton_7_Click(object sender, EventArgs e)
	{
		if (framework_1 != null && framework_1.method_4())
		{
			method_117();
			Form31 form = new Form31();
			form.ShowDialog(this);
			form.Dispose();
		}
	}

	private void toolStripDropDownButton_0_Click(object sender, EventArgs e)
	{
		method_23(Class1.Enum5.BFH);
	}

	private void toolStripMenuItem_59_Click(object sender, EventArgs e)
	{
		method_23(Class1.Enum5.BFh);
	}

	private void method_23(Class1.Enum5 enum5_0)
	{
		if (framework_1 != null && framework_1.aww.Count != 0 && framework_1.aww.ContainsKey(enum5_0))
		{
			Form40 form = new Form40(framework_1, bool_4: true, bool_5: false, framework_1.aww[enum5_0], enum5_0);
			form.ShowDialog(this);
			form.Dispose();
		}
	}

	private void toolStripButton_13_Click(object sender, EventArgs e)
	{
		if (framework_1 != null)
		{
			DataTableObject dataTableObject = framework_1.awx?.FirstOrDefault((KeyValuePair<string, DataTableObject> keyValuePair_0) => keyValuePair_0.Value.IsErrorTable).Value;
			if (dataTableObject != null && framework_1.aWW.IsValid)
			{
				dataTableObject.Data = Class23.smethod_15(framework_1.aWW.ErrorDefs);
				DTCManagerForm dTCManagerForm = new DTCManagerForm(framework_1, dataTableObject);
				dTCManagerForm.ShowDialog();
				dTCManagerForm.Dispose();
			}
		}
	}

	private void toolStripMenuItem_31_Click(object sender, EventArgs e)
	{
		if (framework_1 == null)
		{
			return;
		}
		if (framework_1.method_4())
		{
			if (form47_0 != null)
			{
				if (form47_0.Visible)
				{
					if (form47_0.method_1() == framework_1)
					{
						form47_0.Activate();
						return;
					}
					form47_0.Hide();
				}
				form47_0.Dispose();
			}
			form47_0 = new Form47();
			form47_0.method_2(framework_1);
			form47_0.Location = new Point(Location.X + (Width - form47_0.Width) / 2, Location.Y + (Height - form47_0.Height) / 2);
			form47_0.Show(this);
		}
		else if (form47_0 != null)
		{
			if (form47_0.Visible)
			{
				form47_0.Hide();
			}
			form47_0.Dispose();
		}
	}

	private void toolStripMenuItem_22_Click(object sender, EventArgs e)
	{
		method_117();
		Form58 form = new Form58();
		form.ShowDialog(this);
		form.Dispose();
	}

	private void toolStripMenuItem_26_Click(object sender, EventArgs e)
	{
		method_117();
		Form57 form = new Form57();
		form.ShowDialog(this);
		form.Dispose();
	}

	private void toolStripMenuItem_40_Click(object sender, EventArgs e)
	{
		method_117();
		Form53 form = new Form53();
		form.ShowDialog(this);
		form.Dispose();
	}

	private void toolStripMenuItem_57_Click(object sender, EventArgs e)
	{
		Form9 form = new Form9();
		form.ShowDialog(this);
		form.Dispose();
	}

	private void toolStripMenuItem_29_Click(object sender, EventArgs e)
	{
		try
		{
			SendKeys.Send(Class333.smethod_1459());
		}
		catch
		{
		}
	}

	private void toolStripMenuItem_30_Click(object sender, EventArgs e)
	{
		try
		{
			SendKeys.Send(Class333.smethod_1460());
		}
		catch
		{
		}
	}

	internal void class166_0_Click(object sender, EventArgs e)
	{
		bool flag = false;
		if (framework_1 != null && framework_1.method_5() && smethod_28(framework_1.aXc, bool_53: true))
		{
			flag = true;
		}
		string text = string.Empty;
		bool flag2 = true;
		if (!flag)
		{
			string inputPath = string_2 + Class333.smethod_522() + string_18;
			FolderPicker folderPicker = new FolderPicker();
			folderPicker.InputPath = inputPath;
			if (folderPicker.ShowDialog(IntPtr.Zero) == true)
			{
				string resultPath = folderPicker.ResultPath;
				string[] array = folderPicker.ResultPath.Split('\\', '/');
				if (array.Length > 1 && array[^2] == string_18)
				{
					resultPath += Class333.smethod_975();
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
			Form10 form = new Form10(text, !flag);
			form.ShowDialog(this);
			form.Dispose();
		}
	}

	private void toolStripMenuItem_54_Click(object sender, EventArgs e)
	{
		method_54(Enum55.const_1, bool_53: false, bool_54: false, bool_55: false);
	}

	private void toolStripMenuItem_55_Click(object sender, EventArgs e)
	{
		method_54(Enum55.const_2, bool_53: false, bool_54: false, bool_55: false);
	}

	private void toolStripMenuItem_56_Click(object sender, EventArgs e)
	{
		method_54(Enum55.const_0, bool_53: false, bool_54: false, bool_55: false);
	}

	private void toolStripMenuItem_53_Click(object sender, EventArgs e)
	{
		method_68(this, Enum55.const_0, null, null);
	}

	private void toolStripMenuItem_37_Click(object sender, EventArgs e)
	{
		if (form21_0 != null)
		{
			if (form21_0.Visible)
			{
				form21_0.Activate();
				return;
			}
			form21_0.Dispose();
		}
		form21_0 = new Form21();
		form21_0.Location = new Point(Location.X + (Width - form21_0.Width) / 2, Location.Y + (Height - form21_0.Height) / 2);
		form21_0.Show(this);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		switch (keyData)
		{
		case Keys.F1:
			method_91();
			return true;
		case Keys.F4:
			control4_0.method_68(bool_7: true);
			return true;
		case Keys.F5:
			class167_0_Click(null, null);
			return true;
		case Keys.F6:
			toolStripMenuItem_14_Click(null, null);
			return true;
		case Keys.F7:
			toolStripMenuItem_16_Click(null, null);
			return true;
		case Keys.F7 | Keys.Shift:
			toolStripMenuItem_17_Click(null, null);
			return true;
		case Keys.F9:
			toolStripMenuItem_47_Click(null, null);
			return true;
		case Keys.F11:
			method_120();
			return true;
		case Keys.Oem3:
			toolStripButton_10_Click(null, null);
			return true;
		case Keys.C | Keys.Alt:
			control4_0.method_0().method_34(bool_3: true);
			return true;
		case Keys.N | Keys.Control:
			toolStripButton_0_Click(null, null);
			return true;
		case Keys.O | Keys.Control:
			toolStripButton_6_Click(null, null);
			return true;
		case Keys.S | Keys.Control:
			toolStripButton_11_Click(null, null);
			return true;
		case Keys.Z | Keys.Control:
			toolStripButton_2_Click(null, null);
			return true;
		case Keys.Y | Keys.Control:
			toolStripButton_3_Click(null, null);
			return true;
		case Keys.F12 | Keys.Control:
			class168_0_Click(null, null);
			return true;
		case Keys.F | Keys.Control:
			control4_0.method_1().Focus();
			return true;
		default:
			if (control25_0.TabCount > 2)
			{
				switch (keyData)
				{
				case Keys.Tab | Keys.Control:
					if (control25_0.SelectedIndex == control25_0.TabCount - 2)
					{
						control25_0.SelectedIndex = 0;
					}
					else
					{
						control25_0.SelectedIndex += 1;
					}
					return true;
				case Keys.Tab | Keys.Shift | Keys.Control:
					if (control25_0.SelectedIndex == 0)
					{
						control25_0.SelectedIndex = control25_0.TabCount - 2;
					}
					else
					{
						control25_0.SelectedIndex -= 1;
					}
					return true;
				}
				if (control25_0.Focused)
				{
					switch (keyData)
					{
					case Keys.Left:
						return true;
					case Keys.Right:
						return true;
					case Keys.Up:
						return true;
					case Keys.Down:
						return true;
					}
				}
			}
			if (control25_0.Enabled && keyData == (Keys.N | Keys.Shift | Keys.Control))
			{
				control25_0.SelectedIndex = control25_0.TabCount - 1;
				return true;
			}
			if (control4_0.method_0().method_2().Count != 0)
			{
				switch (keyData)
				{
				case Keys.Left | Keys.Alt:
					control4_0.method_0().method_17(Keys.Left);
					return true;
				case Keys.Right | Keys.Alt:
					control4_0.method_0().method_17(Keys.Right);
					return true;
				case Keys.Up | Keys.Alt:
					control4_0.method_0().method_17(Keys.Up);
					return true;
				case Keys.Down | Keys.Alt:
					control4_0.method_0().method_17(Keys.Down);
					return true;
				}
				if ((keyData & Keys.Alt) != 0)
				{
					if (!control4_0.Visible)
					{
						bool_33 = true;
						control4_0.Visible = true;
						smethod_73();
					}
					if (menuStrip_0.Focused)
					{
						control4_0.method_0().Focus();
					}
					else
					{
						menuStrip_0.Focus();
						toolStripMenuItem_0.Select();
					}
					return true;
				}
			}
			return false;
		}
	}

	private void Form23_Activated(object sender, EventArgs e)
	{
		control25_0.method_27();
	}

	private void toolStripMenuItem_34_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void toolStripMenuItem_25_Click(object sender, EventArgs e)
	{
		Form1 form = new Form1();
		form.ShowDialog(this);
		form.Dispose();
	}

	private void toolStripMenuItem_51_Click(object sender, EventArgs e)
	{
		Form60 form = new Form60();
		form.ShowDialog(this);
		form.Dispose();
	}

	internal void method_24()
	{
		if (Form59.smethod_2())
		{
			toolStripMenuItem_36.Visible = true;
			toolStripButton_9.Visible = true;
		}
		else
		{
			toolStripMenuItem_36.Visible = false;
			toolStripButton_9.Visible = false;
		}
	}

	private void toolStripButton_9_Click(object sender, EventArgs e)
	{
		if (framework_1 != null && framework_1.method_5() && framework_1.method_9())
		{
			string text = Class23.smethod_10(bool_1: true);
			string text2 = string_4 + Class333.smethod_1461() + text + Class333.smethod_177();
			try
			{
				if (!Directory.Exists(text2))
				{
					Directory.CreateDirectory(text2);
				}
			}
			catch (Exception ex)
			{
				Form54.smethod_6(this, Class333.smethod_1462() + ex.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			try
			{
				string text3 = text2 + Class333.smethod_1463();
				if (!Directory.Exists(text3))
				{
					Directory.CreateDirectory(text3);
				}
				new Class297(text3 + text + Class242.smethod_8(framework_1.awZ, framework_1.awz, framework_1.aXA) + Class333.smethod_146(), framework_1, bool_0: true).method_0();
				Class28.smethod_0(text3 + text + Class333.smethod_1464(), ImageFormat.Png, form23_0.Handle);
			}
			catch (Exception ex2)
			{
				Class23.smethod_3(Class333.smethod_1465() + ex2.Message);
			}
			Form50 form = new Form50(framework_1, text2);
			if (form.ShowDialog(this) != DialogResult.OK)
			{
				try
				{
					if (Directory.Exists(text2))
					{
						Directory.Delete(text2, recursive: true);
					}
				}
				catch
				{
				}
			}
			form.Dispose();
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_1466(), Class333.smethod_1467(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal static string smethod_14(Framework framework_2)
	{
		if (framework_2 != null && framework_2.method_5())
		{
			string empty = string.Empty;
			if (framework_2.method_28(ref empty))
			{
				string text = smethod_99(empty, framework_2.aXc);
				if (string.IsNullOrEmpty(text))
				{
					try
					{
						return (framework_2.aXD = smethod_100(empty, new List<string> { framework_2.aXc })) + Class333.smethod_1468();
					}
					catch
					{
						return string_2 + Class333.smethod_522() + string_18 + Class333.smethod_1468();
					}
				}
				return text + Class333.smethod_1468();
			}
			return string_2 + Class333.smethod_522() + string_18 + Class333.smethod_1468();
		}
		return string_2 + Class333.smethod_522() + string_18 + Class333.smethod_1468();
	}

	internal static bool smethod_15(Framework framework_2, Class10 class10_0, string string_41, out string string_42, out byte[] byte_1)
	{
		string_42 = null;
		byte_1 = null;
		try
		{
			string text = string.Concat(smethod_14(framework_2) + string_41 + Class333.smethod_176(), class10_0.method_2().Substring(Class333.smethod_1469().Length));
			if (File.Exists(text))
			{
				byte[] array = File.ReadAllBytes(text);
				uint num = new global::crc.crc().crc_process(array, 0u, (uint)array.Length, uint.MaxValue, partial: false);
				if (class10_0.uint_1 == num)
				{
					string_42 = text;
					byte_1 = array;
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

	internal static bool smethod_16(Framework framework_2, string string_41, string string_42, out string string_43)
	{
		try
		{
			string path = smethod_14(framework_2) + string_42 + Class333.smethod_176() + string_41;
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			string_43 = null;
			return true;
		}
		catch (Exception ex)
		{
			string_43 = ex.Message;
			return false;
		}
	}

	internal static bool smethod_17(Framework framework_2, string string_41, string string_42, string string_43, out string string_44)
	{
		try
		{
			string text = smethod_14(framework_2) + string_43 + Class333.smethod_176();
			string text2 = text + string_41;
			string text3 = text + string_42;
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			if (File.Exists(text2))
			{
				File.Move(text2, text3);
			}
			string_44 = null;
			return true;
		}
		catch (Exception ex)
		{
			string_44 = ex.Message;
			return false;
		}
	}

	internal static bool smethod_18(Framework framework_2, string string_41, byte[] byte_1, string string_42, out string string_43)
	{
		try
		{
			string text = smethod_14(framework_2) + string_42 + Class333.smethod_176();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			File.WriteAllBytes(text + string_41, byte_1);
			string_43 = null;
			return true;
		}
		catch (Exception ex)
		{
			string_43 = ex.Message;
			return false;
		}
	}

	internal static bool smethod_19(string string_41, out string string_42)
	{
		try
		{
			if (Directory.Exists(string_41))
			{
				Directory.Delete(string_41, recursive: true);
			}
			string_42 = null;
			return true;
		}
		catch (Exception ex)
		{
			string_42 = ex.Message;
			return false;
		}
	}

	internal static bool smethod_20(string string_41, string string_42, byte[] byte_1, string string_43, out string string_44)
	{
		try
		{
			string text = string_41 + Class333.smethod_176() + string_43 + Class333.smethod_176();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			File.WriteAllBytes(text + string_42, byte_1);
			string_44 = null;
			return true;
		}
		catch (Exception ex)
		{
			string_44 = ex.Message;
			return false;
		}
	}

	internal static bool smethod_21(string string_41, string string_42, string string_43, out string string_44)
	{
		string text = string_11 + Class333.smethod_176() + string_43 + Class333.smethod_176() + string_41;
		if (File.Exists(text))
		{
			string text2 = string_10 + Class333.smethod_176() + string_43 + Class333.smethod_176();
			try
			{
				if (!Directory.Exists(text2))
				{
					Directory.CreateDirectory(text2);
				}
				string text3 = text2 + string_42;
				if (File.Exists(text3))
				{
					File.Delete(text3);
				}
				File.Copy(text, text3);
				string_44 = null;
				return true;
			}
			catch (Exception ex)
			{
				string_44 = ex.Message;
				return false;
			}
		}
		string_44 = Class333.smethod_1470() + text + Class333.smethod_1471();
		return false;
	}

	internal static Class10[] smethod_22(Class1.Enum5 enum5_0)
	{
		if (Class1.smethod_51(framework_1.aXc, enum5_0, out var enum4_, out var num, out var flag) && enum4_ == Class1.Enum4.BFC && num != 0 && Class1.smethod_52(framework_1.aXc, enum5_0, 0, (ushort)(num - 1), out enum4_, out var class10_, out flag) && enum4_ == Class1.Enum4.BFC)
		{
			return class10_;
		}
		return null;
	}

	private static uint smethod_23()
	{
		if (framework_1.awW != null)
		{
			Setting setting = framework_1.method_31(framework_1.awW.method_182());
			if (setting != null && Class1.smethod_37(framework_1.aXc, Enum10.const_7, (uint)setting.method_65(), (uint)setting.method_278(), out var byte_, out var _))
			{
				return (uint)Class23.smethod_5(byte_, 0, setting.method_278(), setting.method_201(), framework_1.aWR);
			}
		}
		return 0u;
	}

	internal static void smethod_24(BackgroundWorker backgroundWorker_1, int int_49, int int_50, string string_41, int int_51, uint uint_0, out string string_42)
	{
		string_42 = null;
		if (backgroundWorker_1 != null)
		{
			if (int_51 != -1)
			{
				backgroundWorker_1.ReportProgress(int_49, int_51);
			}
			else
			{
				backgroundWorker_1.ReportProgress(int_49);
			}
		}
		if (framework_1.awW == null || string.IsNullOrEmpty(string_41))
		{
			return;
		}
		bool flag;
		string text;
		if (string_41.StartsWith(Class333.smethod_1469()))
		{
			flag = true;
			text = string_41.Substring(Class333.smethod_1469().Length);
		}
		else
		{
			flag = false;
			text = ((!string_41.StartsWith(Class333.smethod_1472())) ? string_41 : string_41.Substring(Class333.smethod_1472().Length));
		}
		try
		{
			string path = ((!flag) ? (string_3 + Class333.smethod_1474() + text) : (string_10 + Class333.smethod_1473() + text));
			if (framework_1.awZ == 21 && framework_1.awz == 11)
			{
				byte[] splashBytes = File.ReadAllBytes(path);
				bool animated = NSP.SplashMedia.IsAnimated(path, splashBytes);
				byte[] manifest = NSP.SplashMedia.CreateManifest((flag ? "u/" : "h/") + text, animated);
				if (animated && flag)
				{
					UploadImageResource("u/" + text, splashBytes, backgroundWorker_1, int_49, int_50 * 9 / 10, int_51);
				}
				if (animated)
				{
					UploadImageResource("u/" + NSP.SplashMedia.ManifestName, manifest);
				}
				else
				{
					// Only disables an earlier animated splash; never block the stock boot-logo update.
					try
					{
						UploadImageResource("u/" + NSP.SplashMedia.ManifestName, manifest);
					}
					catch (Exception manifestError)
					{
						Class23.smethod_3("Could not disable the animated startup splash: " + manifestError.Message);
					}
				}
				NSP.SplashMedia.SaveManifest(Path.Combine(string_10, "images"), manifest);
				if (animated)
				{
					Class23.smethod_3("Animated startup splash uploaded; the early kernel logo is unchanged.");
					if (backgroundWorker_1 != null)
					{
						if (int_51 == -1)
							backgroundWorker_1.ReportProgress(int_49 + int_50);
						else
							backgroundWorker_1.ReportProgress(int_49 + int_50, int_51);
					}
					return;
				}
			}
			Setting setting = framework_1.method_31(framework_1.awW.method_182());
			uint num = 0u;
			if (setting != null)
			{
				byte[] array = File.ReadAllBytes(path);
				num = new global::crc.crc().crc_process(array, 0u, (uint)array.Length, uint.MaxValue, partial: false);
				if (uint_0 == num)
				{
					Class23.smethod_3(Class333.smethod_1475());
					if (backgroundWorker_1 != null)
					{
						if (int_51 != -1)
						{
							backgroundWorker_1.ReportProgress(int_49 + int_50, int_51);
						}
						else
						{
							backgroundWorker_1.ReportProgress(int_49 + int_50);
						}
						Thread.Sleep(500);
					}
					return;
				}
			}
			Size size_ = framework_1.awW.method_178();
			int num2 = framework_1.awW.method_180();
			PixelFormat format = num2 switch
			{
				32 => PixelFormat.Format32bppArgb, 
				24 => PixelFormat.Format24bppRgb, 
				_ => throw new Exception(Class333.smethod_1476() + num2 + Class333.smethod_1477()), 
			};
			using FileStream stream = File.OpenRead(path);
			using Image image = Image.FromStream(stream);
			using Bitmap bitmap = new Bitmap(size_.Width, size_.Height, format);
			using Graphics graphics = Graphics.FromImage(bitmap);
			graphics.Clear(Color.Black);
			Size size = Class25.smethod_1(image.Size, size_);
			int width = size.Width;
			int height = size.Height;
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.CompositingQuality = CompositingQuality.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.DrawImage(image, size_.Width / 2 - width / 2, size_.Height / 2 - height / 2, width, height);
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			ImageCodecInfo imageCodecInfo = null;
			ImageCodecInfo[] array2 = imageEncoders;
			foreach (ImageCodecInfo imageCodecInfo2 in array2)
			{
				if (imageCodecInfo2.FormatID == ImageFormat.Bmp.Guid)
				{
					imageCodecInfo = imageCodecInfo2;
					break;
				}
			}
			if (imageCodecInfo != null)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using EncoderParameter encoderParameter = new EncoderParameter(System.Drawing.Imaging.Encoder.ColorDepth, num2);
					using EncoderParameters encoderParameters = new EncoderParameters();
					encoderParameters.Param = new EncoderParameter[1] { encoderParameter };
					bitmap.Save(memoryStream, imageCodecInfo, encoderParameters);
					byte[] array3 = memoryStream.ToArray();
					MagickReadSettings readSettings = new MagickReadSettings
					{
						Format = MagickFormat.Bmp
					};
					using (MagickImage magickImage = new MagickImage(array3, readSettings))
					{
						QuantizeSettings settings = new QuantizeSettings
						{
							Colors = 224u,
							ColorSpace = ColorSpace.sRGB,
							DitherMethod = DitherMethod.FloydSteinberg
						};
						magickImage.Quantize(settings);
						magickImage.Alpha(AlphaOption.Remove);
						magickImage.ColorType = ColorType.TrueColor;
						magickImage.ColorSpace = ColorSpace.sRGB;
						magickImage.Strip();
						array3 = magickImage.ToByteArray(MagickFormat.Bmp3);
					}
					int num3 = int_50 * 10 / 100;
					int num4 = int_50 * 30 / 100;
					int int_52 = int_50 - (num3 + num4);
					if (backgroundWorker_1 != null)
					{
						if (int_51 != -1)
						{
							backgroundWorker_1.ReportProgress(int_49 + num3, int_51);
						}
						else
						{
							backgroundWorker_1.ReportProgress(int_49 + num3);
						}
					}
					smethod_25(backgroundWorker_1, array3, int_49 + num3, num4, int_51);
					smethod_26(backgroundWorker_1, int_49 + num3 + num4, int_52, int_51);
					setting?.method_272((int)num, bool_0: true);
					if (backgroundWorker_1 != null)
					{
						if (int_51 != -1)
						{
							backgroundWorker_1.ReportProgress(int_49 + int_50, int_51);
						}
						else
						{
							backgroundWorker_1.ReportProgress(int_49 + int_50);
						}
						Thread.Sleep(500);
					}
					return;
				}
			}
			throw new Exception(Class333.smethod_1478());
		}
		catch (Exception ex)
		{
			string_42 = Class333.smethod_1479() + ex.Message;
		}
	}

	internal static void OpenAlertBannerEditor(string focusText, IWin32Window owner = null)
	{
		owner ??= form23_0;
		if (framework_1 == null || framework_1.awZ != 21 || framework_1.awz != 11)
		{
			MessageBox.Show(owner, "Open an iC-7 v2.36 map first.", "Alert banners",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}
		try
		{
			using var editor = new NSP.UserInterface.AlertBannerEditor(framework_1, focusText);
			editor.ShowDialog(owner);
		}
		catch (Exception error)
		{
			Class23.smethod_3("Cannot open alert banner editor: " + error.Message);
			MessageBox.Show(owner, error.Message, "Alert banners", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal static void UploadImageResource(string name, byte[] payload, BackgroundWorker worker = null,
		int progressStart = 0, int progressSpan = 100, int progressPage = -1)
	{
		Class10 descriptor = new Class10();
		descriptor.method_3(name);
		descriptor.uint_0 = (uint)payload.Length;
		descriptor.enum5_0 = Class1.Enum5.BFH;
		descriptor.uint_1 = new global::crc.crc().crc_process(payload, 0u, (uint)payload.Length, uint.MaxValue, partial: false);
		Class10[] existing = smethod_22(Class1.Enum5.BFH);
		if (existing != null && existing.Any(item => item.method_2() == name
			&& item.uint_0 == descriptor.uint_0 && item.uint_1 == descriptor.uint_1))
		{
			Class23.smethod_3("Resource already matches device: " + name, bool_1: false);
			return;
		}
		SendResource(descriptor, payload, worker, progressStart, progressSpan, progressPage);
	}

	private static void SendResource(Class10 descriptor, byte[] payload, BackgroundWorker worker,
		int progressStart, int progressSpan, int progressPage)
	{
		string name = descriptor.method_2();
		uint limit = Class1.smethod_74(framework_1.aXc, Enum10.const_14);
		int chunkSize = limit > 68 ? checked((int)(limit - 68)) : 0;
		int lastPercent = -1;
		Class23.smethod_3("Uploading resource " + name + " (" + payload.Length + " bytes).", bool_1: false);
		NSP.ResourceUpload.Send(payload, chunkSize, (offset, fragment) => {
			// Stock NSP retried nonterminal transport failures while connected; keep that, but bounded.
			bool sent = false;
			Class1.Enum4 result = default;
			for (int attempt = 1; attempt <= 5; attempt++)
			{
				sent = Class1.smethod_54(framework_1.aXc, descriptor, offset, fragment, out result, out bool terminal);
				if (sent || terminal || !smethod_28(framework_1.aXc, bool_53: false))
					break;
				Class23.smethod_3("Retrying resource " + name + " at " + offset + " (attempt " + (attempt + 1) + " of 5).", bool_1: false);
			}
			if (!sent)
				throw new IOException("Resource transfer failed: " + name + " at " + offset + "/" + payload.Length
					+ " bytes (no valid device acknowledgement). Check the emulator log and virtual COM connection.");
			if (result != Class1.Enum4.BFC)
				throw new IOException("Resource rejected: " + name + " at " + offset + "/" + payload.Length
					+ " bytes: " + Class1.smethod_50(result));
		}, (written, total) => {
			if (worker != null)
			{
				int percent = progressStart + (int)(written * progressSpan / Math.Max(1L, total));
				if (percent == lastPercent)
					return;
				lastPercent = percent;
				if (progressPage == -1)
					worker.ReportProgress(percent);
				else
					worker.ReportProgress(percent, progressPage);
			}
		}, () => worker != null && worker.CancellationPending);
	}

	private static void smethod_25(BackgroundWorker backgroundWorker_1, byte[] byte_1, int int_49, int int_50, int int_51)
	{
		uint val = Class1.smethod_74(framework_1.aXc, Enum10.const_15);
		uint num = 0u;
		while (true)
		{
			uint num2 = Math.Min(val, (uint)byte_1.Length - num);
			byte[] array = new byte[num2];
			Array.Copy(byte_1, num, array, 0L, num2);
			if (!Class1.smethod_39(framework_1.aXc, Enum10.const_15, num, array, out var flag))
			{
				if (flag || !smethod_28(framework_1.aXc, bool_53: false))
				{
					break;
				}
			}
			else
			{
				Class23.smethod_3(Class333.smethod_1480() + num2 + Class333.smethod_1481(), bool_1: false);
				num += num2;
				if (backgroundWorker_1 != null)
				{
					if (backgroundWorker_1.CancellationPending)
					{
						throw new Exception(Class333.smethod_1482());
					}
					int percentProgress = int_49 + (int)(num * int_50 / byte_1.Length);
					if (int_51 != -1)
					{
						backgroundWorker_1.ReportProgress(percentProgress, int_51);
					}
					else
					{
						backgroundWorker_1.ReportProgress(percentProgress);
					}
				}
			}
			if (backgroundWorker_1 == null || !backgroundWorker_1.CancellationPending)
			{
				if (num >= byte_1.Length)
				{
					return;
				}
				continue;
			}
			throw new Exception(Class333.smethod_1482());
		}
		throw new Exception(Class333.smethod_1483());
	}

	private static void smethod_26(BackgroundWorker backgroundWorker_1, int int_49, int int_50, int int_51)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Restart();
		while (true)
		{
			if (stopwatch.ElapsedMilliseconds < 25000L)
			{
				bool flag = false;
				int num = 5;
				byte[] byte_;
				do
				{
					if (!(flag = Class1.smethod_49(framework_1.aXc, 0, out byte_, out var _) && byte_.Length != 0))
					{
						num--;
						Thread.Sleep(500);
					}
				}
				while (num != 0 && !flag);
				if (flag)
				{
					if (byte_[0] == 2)
					{
						if (backgroundWorker_1 != null)
						{
							int percentProgress = Math.Min(int_49 + int_50, int_49 + (int)(stopwatch.ElapsedMilliseconds * int_50 / 15000L));
							if (int_51 != -1)
							{
								backgroundWorker_1.ReportProgress(percentProgress, int_51);
							}
							else
							{
								backgroundWorker_1.ReportProgress(percentProgress);
							}
						}
						Thread.Sleep(100);
						continue;
					}
					if (byte_[0] != 0)
					{
						throw new Exception(Class333.smethod_1485());
					}
					break;
				}
				throw new Exception(Class333.smethod_1486());
			}
			throw new Exception(Class333.smethod_1484());
		}
	}

	private void method_25(object sender, EventArgs e)
	{
		if (Class1.smethod_27().Count == 1)
		{
			Class1.smethod_59(Class1.smethod_27()[0].string_0, out var _);
		}
	}

	private void method_26(object sender, EventArgs e)
	{
		if (Class1.smethod_27().Count == 1 && (int_0 & 0x100) == 0 && (int_0 & 0x200) == 0 && (int_0 & 0x1000) == 0 && (int_0 & 0x20) == 0 && (int_0 & 0x40) == 0)
		{
			if (framework_1.method_31(9500).method_256() != 0)
			{
				Form54.smethod_6(this, Class333.smethod_1488(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			bool_18 = true;
			Thread.Sleep(100);
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.ProgressChanged += smethod_69;
			backgroundWorker.DoWork += method_27;
			backgroundWorker.RunWorkerCompleted += method_28;
			smethod_66(Class333.smethod_1489());
			backgroundWorker.RunWorkerAsync();
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_1487(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_27(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		e.Result = null;
		try
		{
			int num = framework_1.method_31(9497).method_256();
			int num2 = framework_1.method_31(9510).method_256();
			Form10.smethod_25();
			string path = ((string_31 != null) ? string_31 : (string_2 + Class333.smethod_522() + string_18 + Class333.smethod_1490()));
			FileStream fileStream = new FileStream(path, FileMode.Create);
			ZipArchive zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Create);
			Stream stream = zipArchive.CreateEntry(Class333.smethod_1491()).Open();
			Class5 @class = Class1.smethod_27()[0];
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			float Bqu = 0f;
			Stopwatch stopwatch = new Stopwatch();
			while (num5 < num)
			{
				stopwatch.Restart();
				int num6 = Math.Min((int)Class1.smethod_73(@class.string_0, Enum10.const_12), num - num5);
				bool flag;
				do
				{
					stopwatch.Restart();
					if (flag = Class1.smethod_37(@class.string_0, Enum10.const_12, (uint)num5, (uint)num6, out var byte_, out var _))
					{
						stream.Write(byte_, 0, num6);
					}
				}
				while (!flag);
				stopwatch.Stop();
				num3 += num6;
				num4 += (int)stopwatch.ElapsedMilliseconds;
				if (num4 >= 2000)
				{
					float num7 = (float)num3 / 1048576f;
					float num8 = (float)num4 / 1000f;
					Bqu = num7 / num8;
					Class23.smethod_3(Class333.smethod_1492() + num3 + Class333.smethod_1493() + num4 + Class333.smethod_1494() + Bqu + Class333.smethod_1495());
					num4 = 0;
					num3 = 0;
				}
				Class23.smethod_3(Class333.smethod_1496() + num6 + Class333.smethod_1497() + stopwatch.ElapsedMilliseconds + Class333.smethod_1498());
				num5 += num6;
				int percentProgress = Convert.ToInt32(Convert.ToSingle(num5) / (float)num * 95f);
				backgroundWorker.ReportProgress(percentProgress);
				uint num9 = (uint)((float)(uint)(num - num5) / (1048576f * Bqu));
				uint BqV = num9 / 60;
				num9 %= 60;
				string Bqv = string.Empty;
				if (num9 < 10)
				{
					Bqv = Class333.smethod_184() + num9;
				}
				else
				{
					Bqv = num9.ToString();
				}
				if (!bool_14)
				{
					label_1.Invoke(() =>
					{
						label_1.Text = Class333.Bdb() + BqV + Class333.smethod_134() + Bqv + Class333.smethod_842() + string.Format(Class333.BdC(), Bqu) + Class333.Bdc();
					});
				}
			}
			stream.Close();
			zipArchive.Dispose();
			fileStream.Close();
			if (!bool_14)
			{
				label_1.Invoke(() =>
				{
					label_1.Text = Class333.smethod_1499();
				});
			}
			else
			{
				Console.WriteLine();
				Console.WriteLine(Class333.smethod_1499());
			}
			string path2;
			if (string_31 == null)
			{
				path2 = string_2 + Class333.smethod_522() + string_18 + Class333.smethod_1500();
			}
			else
			{
				string text = Path.GetFileNameWithoutExtension(string_31) + Class333.smethod_1501();
				string text2 = Path.GetDirectoryName(string_31);
				if (!text2.EndsWith(Class333.smethod_176()) && !text2.EndsWith(Class333.smethod_177()))
				{
					text2 += Class333.smethod_177();
				}
				path2 = text2 + text;
			}
			StreamWriter streamWriter = new StreamWriter(File.Open(path2, FileMode.Create, FileAccess.Write));
			streamWriter.WriteLine(Class333.smethod_1502());
			fileStream = new FileStream(path, FileMode.Open);
			if (fileStream.CanRead)
			{
				zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Read);
				stream = zipArchive.Entries[0].Open();
				int num10 = num / num2;
				for (int num11 = 0; num11 < num10; num11++)
				{
					int num12 = 0;
					int num13 = 0;
					for (int num14 = 0; num14 < num2; num14++)
					{
						int num15 = stream.ReadByte();
						if (num15 != -1)
						{
							byte b = (byte)num15;
							switch (num14)
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
							switch (num14)
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
						throw new Exception(Class333.smethod_1503());
					}
					streamWriter.WriteLine(string.Format(Class333.smethod_1504(), num11 * num2, num12, num13));
				}
				stream.Close();
				zipArchive.Dispose();
			}
			fileStream.Close();
			streamWriter.Close();
		}
		catch (Exception ex)
		{
			e.Result = ex.Message;
		}
		Thread.Sleep(100);
		backgroundWorker.ReportProgress(100);
	}

	private void method_28(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		Form10.smethod_21();
		bool_18 = false;
		if (e.Result != null)
		{
			if (!bool_14)
			{
				Form54.smethod_6(this, e.Result as string, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Console.WriteLine();
			Console.WriteLine(e.Result as string);
			Environment.Exit(1);
		}
		if (string_31 != null)
		{
			string text = Path.GetFileNameWithoutExtension(string_31) + Class333.smethod_1505();
			string text2 = Path.GetDirectoryName(string_31);
			if (!text2.EndsWith(Class333.smethod_176()) && !text2.EndsWith(Class333.smethod_177()))
			{
				text2 += Class333.smethod_177();
			}
			method_192(text2 + text);
			string_31 = null;
		}
	}

	private void method_29(object sender, DoWorkEventArgs e)
	{
		Thread.Sleep(1500);
	}

	private void method_30(object sender, RunWorkerCompletedEventArgs e)
	{
		if (string_31 == null)
		{
			return;
		}
		if (framework_1.method_31(9500).method_256() != 0)
		{
			string value = Class333.smethod_1506();
			if (!bool_14)
			{
				Form54.smethod_6(this, value, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Console.WriteLine();
			Console.WriteLine(value);
			Environment.Exit(1);
		}
		method_26(null, null);
	}

	private void method_31(object sender, EventArgs e)
	{
		if (framework_1 != null && Class1.smethod_27().Count == 1 && (int_0 & 0x100) == 0 && (int_0 & 0x200) == 0 && (int_0 & 0x1000) == 0 && (int_0 & 0x20) == 0 && (int_0 & 0x40) == 0)
		{
			if (Class1.smethod_74(Class1.smethod_27()[0].string_0, Enum10.const_12) == 0)
			{
				Form54.smethod_6(this, Class333.smethod_1507(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (framework_1.method_31(9500).method_256() != 0)
			{
				Form54.smethod_6(this, Class333.smethod_1488(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = string_2 + Class333.smethod_522() + string_18;
			openFileDialog.Title = Class333.smethod_1508();
			openFileDialog.Filter = Class333.smethod_1413();
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.ProgressChanged += smethod_69;
				backgroundWorker.DoWork += method_32;
				backgroundWorker.RunWorkerCompleted += method_33;
				smethod_66(Class333.smethod_1509());
				backgroundWorker.RunWorkerAsync(openFileDialog.FileName);
			}
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_1487(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_32(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		MemoryStream memoryStream = null;
		ZipArchive zipArchive = null;
		Stream stream = null;
		try
		{
			Class5 @class = Class1.smethod_27()[0];
			if (Class1.smethod_59(@class.string_0, out var flag))
			{
				Thread.Sleep(200);
				Setting setting = framework_1.method_31(9500);
				int num = 0;
				int num2;
				do
				{
					num2 = setting.method_256();
					if (num2 == 12)
					{
						Thread.Sleep(100);
						if (num < 90)
						{
							num += 5;
							backgroundWorker.ReportProgress(num);
						}
					}
				}
				while (num2 == 12);
				backgroundWorker.ReportProgress(100);
				Thread.Sleep(100);
				Invoke(() =>
				{
					smethod_66(Class333.BDz());
				});
				Thread.Sleep(100);
				string text = e.Argument as string;
				memoryStream = Class35.smethod_7(text, Class19.smethod_3());
				if (memoryStream != null && memoryStream.CanRead)
				{
					long num3 = 0L;
					if (text.EndsWith(Class333.smethod_488()))
					{
						zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Read);
						ZipArchiveEntry zipArchiveEntry = null;
						foreach (ZipArchiveEntry entry in zipArchive.Entries)
						{
							if (entry.Name.EndsWith(Class333.smethod_489()))
							{
								zipArchiveEntry = entry;
								break;
							}
						}
						if (zipArchiveEntry != null)
						{
							stream = zipArchiveEntry.Open();
							num3 = zipArchiveEntry.Length;
						}
					}
					else
					{
						stream = memoryStream;
						num3 = memoryStream.Length;
					}
					backgroundWorker.ReportProgress(100);
					Thread.Sleep(500);
					int num4 = framework_1.method_31(9497).method_256();
					if (stream != null && num3 != 0L && num3 == num4)
					{
						Invoke(() =>
						{
							smethod_66(Class333.BdA());
						});
						int num5 = 0;
						int num6;
						bool flag2;
						do
						{
							if (num5 >= num4)
							{
								return;
							}
							num6 = Math.Min((int)Class1.smethod_74(@class.string_0, Enum10.const_12), num4 - num5);
							byte[] byte_ = new byte[num6];
							if (Class23.smethod_14(stream, byte_, 0, num6))
							{
								flag2 = false;
								int num7 = 2;
								do
								{
									if (!Class1.smethod_39(@class.string_0, Enum10.const_12, (uint)num5, byte_, out flag))
									{
										num7--;
										continue;
									}
									num5 += num6;
									backgroundWorker.ReportProgress((int)(num5 * 100L / num4));
									flag2 = true;
								}
								while (num7 != 0 && !flag2);
								continue;
							}
							throw new Exception(Class333.smethod_1511());
						}
						while (flag2);
						throw new Exception(Class333.smethod_1512() + num6 + Class333.smethod_1513() + num5 + Class333.smethod_190());
					}
					if (text.EndsWith(Class333.smethod_488()))
					{
						throw new Exception(Class333.smethod_1514());
					}
					throw new Exception(Class333.smethod_1515());
				}
				throw new Exception(Class333.smethod_1516());
			}
			throw new Exception(Class333.smethod_1510());
		}
		catch (Exception ex)
		{
			e.Result = ex.Message;
		}
		finally
		{
			stream?.Dispose();
			zipArchive?.Dispose();
			memoryStream?.Dispose();
		}
	}

	private void method_33(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		if (e.Result is string)
		{
			Form54.smethod_6(this, e.Result as string, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_34()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form23));
		menuStrip_0 = new MenuStrip();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_7 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		toolStripSeparator_0 = new ToolStripSeparator();
		toolStripMenuItem_39 = new ToolStripMenuItem();
		toolStripMenuItem_38 = new ToolStripMenuItem();
		toolStripSeparator_1 = new ToolStripSeparator();
		toolStripMenuItem_49 = new ToolStripMenuItem();
		toolStripSeparator_5 = new ToolStripSeparator();
		toolStripMenuItem_8 = new ToolStripMenuItem();
		toolStripMenuItem_41 = new ToolStripMenuItem();
		toolStripSeparator_3 = new ToolStripSeparator();
		toolStripMenuItem_42 = new ToolStripMenuItem();
		toolStripMenuItem_43 = new ToolStripMenuItem();
		toolStripMenuItem_44 = new ToolStripMenuItem();
		toolStripMenuItem_45 = new ToolStripMenuItem();
		toolStripSeparator_4 = new ToolStripSeparator();
		toolStripMenuItem_34 = new ToolStripMenuItem();
		toolStripMenuItem_2 = new ToolStripMenuItem();
		toolStripMenuItem_11 = new ToolStripMenuItem();
		toolStripMenuItem_12 = new ToolStripMenuItem();
		toolStripSeparator_2 = new ToolStripSeparator();
		toolStripMenuItem_29 = new ToolStripMenuItem();
		toolStripMenuItem_30 = new ToolStripMenuItem();
		toolStripMenuItem_3 = new ToolStripMenuItem();
		toolStripMenuItem_31 = new ToolStripMenuItem();
		toolStripMenuItem_32 = new ToolStripMenuItem();
		toolStripMenuItem_6 = new ToolStripMenuItem();
		toolStripMenuItem_10 = new ToolStripMenuItem();
		toolStripMenuItem_58 = new ToolStripMenuItem();
		toolStripMenuItem_59 = new ToolStripMenuItem();
		toolStripMenuItem_4 = new ToolStripMenuItem();
		toolStripMenuItem_23 = new ToolStripMenuItem();
		toolStripMenuItem_24 = new ToolStripMenuItem();
		toolStripMenuItem_9 = new ToolStripMenuItem();
		toolStripMenuItem_27 = new ToolStripMenuItem();
		toolStripMenuItem_28 = new ToolStripMenuItem();
		toolStripMenuItem_13 = new ToolStripMenuItem();
		toolStripMenuItem_18 = new ToolStripMenuItem();
		toolStripMenuItem_52 = new ToolStripMenuItem();
		toolStripMenuItem_54 = new ToolStripMenuItem();
		toolStripMenuItem_55 = new ToolStripMenuItem();
		toolStripMenuItem_56 = new ToolStripMenuItem();
		toolStripMenuItem_53 = new ToolStripMenuItem();
		toolStripMenuItem_50 = new ToolStripMenuItem();
		toolStripMenuItem_14 = new ToolStripMenuItem();
		toolStripMenuItem_16 = new ToolStripMenuItem();
		toolStripMenuItem_17 = new ToolStripMenuItem();
		toolStripMenuItem_15 = new ToolStripMenuItem();
		toolStripMenuItem_19 = new ToolStripMenuItem();
		toolStripMenuItem_20 = new ToolStripMenuItem();
		toolStripMenuItem_21 = new ToolStripMenuItem();
		toolStripMenuItem_22 = new ToolStripMenuItem();
		toolStripMenuItem_26 = new ToolStripMenuItem();
		toolStripMenuItem_40 = new ToolStripMenuItem();
		toolStripMenuItem_57 = new ToolStripMenuItem();
		toolStripMenuItem_5 = new ToolStripMenuItem();
		toolStripMenuItem_33 = new ToolStripMenuItem();
		toolStripMenuItem_35 = new ToolStripMenuItem();
		toolStripMenuItem_36 = new ToolStripMenuItem();
		toolStripMenuItem_37 = new ToolStripMenuItem();
		toolStripMenuItem_51 = new ToolStripMenuItem();
		toolStripMenuItem_25 = new ToolStripMenuItem();
		toolStrip_0 = new ToolStrip();
		toolStripButton_10 = new ToolStripButton();
		class167_0 = new Class167();
		class168_0 = new Class168();
		toolStripButton_0 = new ToolStripButton();
		toolStripButton_6 = new ToolStripButton();
		toolStripButton_11 = new ToolStripButton();
		toolStripButton_1 = new ToolStripButton();
		toolStripButton_14 = new ToolStripButton();
		class163_0 = new Class163();
		toolStripMenuItem_46 = new ToolStripMenuItem();
		toolStripMenuItem_47 = new ToolStripMenuItem();
		toolStripMenuItem_48 = new ToolStripMenuItem();
		toolStripButton_2 = new ToolStripButton();
		toolStripButton_3 = new ToolStripButton();
		toolStripButton_8 = new ToolStripButton();
		toolStripButton_4 = new ToolStripButton();
		toolStripButton_5 = new ToolStripButton();
		toolStripButton_7 = new ToolStripButton();
		class169_0 = new Class169();
		class162_0 = new Class162();
		class166_0 = new Class166();
		toolStripDropDownButton_0 = new ToolStripDropDownButton();
		class164_0 = new Class164();
		class170_0 = new Class170();
		class165_0 = new Class165();
		toolStripButton_12 = new ToolStripButton();
		toolStripButton_9 = new ToolStripButton();
		label_0 = new Label();
		pictureBox_0 = new PictureBox();
		splitContainer_0 = new SplitContainer();
		splitContainer_1 = new SplitContainer();
		control25_0 = new Control25();
		class130_0 = new Class130();
		class130_1 = new Class130();
		control3_0 = new Control3();
		class131_3 = new Class131();
		class131_1 = new Class131();
		class131_0 = new Class131();
		class131_2 = new Class131();
		toolStripButton_13 = new ToolStripButton();
		control4_0 = new Control4();
		startupOptionsPanel_0 = new StartupOptionsPanel();
		menuStrip_0.SuspendLayout();
		toolStrip_0.SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)splitContainer_0).BeginInit();
		splitContainer_0.Panel1.SuspendLayout();
		splitContainer_0.Panel2.SuspendLayout();
		splitContainer_0.SuspendLayout();
		((ISupportInitialize)splitContainer_1).BeginInit();
		splitContainer_1.Panel1.SuspendLayout();
		splitContainer_1.Panel2.SuspendLayout();
		splitContainer_1.SuspendLayout();
		control25_0.SuspendLayout();
		SuspendLayout();
		menuStrip_0.Font = new Font(Class333.smethod_145(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		menuStrip_0.ImageScalingSize = new Size(30, 30);
		menuStrip_0.Items.AddRange(toolStripMenuItem_0, toolStripMenuItem_2, toolStripMenuItem_3, toolStripMenuItem_4, toolStripMenuItem_13, toolStripMenuItem_19, toolStripMenuItem_5);
		menuStrip_0.Location = new Point(0, 0);
		menuStrip_0.Name = Class333.smethod_1517();
		menuStrip_0.Size = new Size(1264, 24);
		menuStrip_0.TabIndex = 15;
		menuStrip_0.Text = Class333.smethod_1518();
		menuStrip_0.Paint += menuStrip_0_Paint;
		toolStripMenuItem_0.DropDownItems.AddRange(toolStripMenuItem_7, toolStripMenuItem_1, toolStripSeparator_0, toolStripMenuItem_39, toolStripMenuItem_38, toolStripSeparator_1, toolStripMenuItem_49, toolStripSeparator_5, toolStripMenuItem_8, toolStripMenuItem_41, toolStripSeparator_3, toolStripMenuItem_42, toolStripSeparator_4, toolStripMenuItem_34);
		toolStripMenuItem_0.Name = Class333.smethod_1519();
		toolStripMenuItem_0.Size = new Size(37, 20);
		toolStripMenuItem_0.Text = Class333.smethod_634();
		toolStripMenuItem_7.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1520());
		toolStripMenuItem_7.Name = Class333.smethod_1521();
		toolStripMenuItem_7.ShortcutKeys = Keys.N | Keys.Control;
		toolStripMenuItem_7.Size = new Size(173, 36);
		toolStripMenuItem_7.Text = Class333.smethod_1522();
		toolStripMenuItem_7.Click += toolStripButton_0_Click;
		toolStripMenuItem_1.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1523());
		toolStripMenuItem_1.Name = Class333.smethod_1524();
		toolStripMenuItem_1.ShortcutKeys = Keys.O | Keys.Control;
		toolStripMenuItem_1.Size = new Size(173, 36);
		toolStripMenuItem_1.Text = Class333.smethod_1525();
		toolStripMenuItem_1.Click += toolStripButton_6_Click;
		toolStripSeparator_0.Name = Class333.smethod_1526();
		toolStripSeparator_0.Size = new Size(170, 6);
		toolStripMenuItem_39.Enabled = false;
		toolStripMenuItem_39.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1527());
		toolStripMenuItem_39.Name = Class333.smethod_1528();
		toolStripMenuItem_39.ShortcutKeys = Keys.S | Keys.Control;
		toolStripMenuItem_39.Size = new Size(173, 36);
		toolStripMenuItem_39.Text = Class333.smethod_1529();
		toolStripMenuItem_39.Click += toolStripButton_11_Click;
		toolStripMenuItem_38.Enabled = false;
		toolStripMenuItem_38.Name = Class333.smethod_1530();
		toolStripMenuItem_38.Size = new Size(173, 36);
		toolStripMenuItem_38.Text = Class333.smethod_1531();
		toolStripMenuItem_38.Click += toolStripMenuItem_38_Click;
		toolStripSeparator_1.Name = Class333.smethod_1532();
		toolStripSeparator_1.Size = new Size(170, 6);
		toolStripMenuItem_49.Name = Class333.smethod_1533();
		toolStripMenuItem_49.Size = new Size(173, 36);
		toolStripMenuItem_49.Text = Class333.smethod_1534();
		toolStripSeparator_5.Name = Class333.smethod_1535();
		toolStripSeparator_5.Size = new Size(170, 6);
		toolStripMenuItem_8.Enabled = false;
		toolStripMenuItem_8.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1536());
		toolStripMenuItem_8.Name = Class333.smethod_1537();
		toolStripMenuItem_8.Size = new Size(173, 36);
		toolStripMenuItem_8.Text = Class333.smethod_1538();
		toolStripMenuItem_8.Click += toolStripButton_1_Click;
		toolStripMenuItem_41.Enabled = false;
		toolStripMenuItem_41.Name = Class333.smethod_1539();
		toolStripMenuItem_41.Size = new Size(173, 36);
		toolStripMenuItem_41.Text = Class333.smethod_551();
		toolStripMenuItem_41.Click += toolStripMenuItem_41_Click;
		toolStripSeparator_3.Name = Class333.smethod_1540();
		toolStripSeparator_3.Size = new Size(170, 6);
		toolStripMenuItem_42.DropDownItems.AddRange(toolStripMenuItem_43, toolStripMenuItem_44, toolStripMenuItem_45);
		toolStripMenuItem_42.Enabled = false;
		toolStripMenuItem_42.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1541());
		toolStripMenuItem_42.Name = Class333.smethod_1542();
		toolStripMenuItem_42.Size = new Size(173, 36);
		toolStripMenuItem_42.Text = Class333.smethod_686();
		toolStripMenuItem_43.Name = Class333.smethod_1543();
		toolStripMenuItem_43.Size = new Size(277, 22);
		toolStripMenuItem_43.Text = Class333.smethod_1544();
		toolStripMenuItem_43.Click += toolStripMenuItem_46_Click;
		toolStripMenuItem_44.Enabled = false;
		toolStripMenuItem_44.Name = Class333.smethod_1545();
		toolStripMenuItem_44.ShortcutKeys = Keys.F9;
		toolStripMenuItem_44.Size = new Size(277, 22);
		toolStripMenuItem_44.Text = Class333.smethod_1546();
		toolStripMenuItem_44.Click += toolStripMenuItem_47_Click;
		toolStripMenuItem_45.Enabled = false;
		toolStripMenuItem_45.Name = Class333.smethod_1547();
		toolStripMenuItem_45.Size = new Size(277, 22);
		toolStripMenuItem_45.Text = Class333.smethod_1548();
		toolStripMenuItem_45.Click += toolStripMenuItem_48_Click;
		toolStripSeparator_4.Name = Class333.smethod_1549();
		toolStripSeparator_4.Size = new Size(170, 6);
		toolStripMenuItem_34.Name = Class333.smethod_1550();
		toolStripMenuItem_34.Size = new Size(173, 36);
		toolStripMenuItem_34.Text = Class333.smethod_1551();
		toolStripMenuItem_34.Click += toolStripMenuItem_34_Click;
		toolStripMenuItem_2.DropDownItems.AddRange(toolStripMenuItem_11, toolStripMenuItem_12, toolStripSeparator_2, toolStripMenuItem_29, toolStripMenuItem_30);
		toolStripMenuItem_2.Name = Class333.smethod_1552();
		toolStripMenuItem_2.Size = new Size(39, 20);
		toolStripMenuItem_2.Text = Class333.smethod_1553();
		toolStripMenuItem_11.Enabled = false;
		toolStripMenuItem_11.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1554());
		toolStripMenuItem_11.Name = Class333.smethod_1555();
		toolStripMenuItem_11.ShortcutKeys = Keys.Z | Keys.Control;
		toolStripMenuItem_11.Size = new Size(158, 36);
		toolStripMenuItem_11.Text = Class333.smethod_1274();
		toolStripMenuItem_11.Click += toolStripButton_2_Click;
		toolStripMenuItem_12.Enabled = false;
		toolStripMenuItem_12.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1556());
		toolStripMenuItem_12.Name = Class333.smethod_1557();
		toolStripMenuItem_12.ShortcutKeys = Keys.Y | Keys.Control;
		toolStripMenuItem_12.Size = new Size(158, 36);
		toolStripMenuItem_12.Text = Class333.smethod_1276();
		toolStripMenuItem_12.Click += toolStripButton_3_Click;
		toolStripSeparator_2.Name = Class333.smethod_1558();
		toolStripSeparator_2.Size = new Size(155, 6);
		toolStripMenuItem_29.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1559());
		toolStripMenuItem_29.Name = Class333.smethod_1560();
		toolStripMenuItem_29.ShortcutKeys = Keys.C | Keys.Control;
		toolStripMenuItem_29.Size = new Size(158, 36);
		toolStripMenuItem_29.Text = Class333.smethod_1270();
		toolStripMenuItem_29.Click += toolStripMenuItem_29_Click;
		toolStripMenuItem_30.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1561());
		toolStripMenuItem_30.Name = Class333.smethod_1562();
		toolStripMenuItem_30.ShortcutKeys = Keys.V | Keys.Control;
		toolStripMenuItem_30.Size = new Size(158, 36);
		toolStripMenuItem_30.Text = Class333.smethod_1272();
		toolStripMenuItem_30.Click += toolStripMenuItem_30_Click;
		toolStripMenuItem_3.DropDownItems.AddRange(toolStripMenuItem_31, toolStripMenuItem_32, toolStripMenuItem_6, toolStripMenuItem_10, toolStripMenuItem_58, toolStripMenuItem_59, toolStripMenuItem_28);
		var alertMediaMenu = new ToolStripMenuItem("Alert GIF banners and placement...");
		alertMediaMenu.Click += (_, _) => OpenAlertBannerEditor(null);
		toolStripMenuItem_3.DropDownItems.Add(alertMediaMenu);
		toolStripMenuItem_3.Name = Class333.smethod_1563();
		toolStripMenuItem_3.Size = new Size(49, 20);
		toolStripMenuItem_3.Text = Class333.smethod_1564();
		toolStripMenuItem_31.Enabled = false;
		toolStripMenuItem_31.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1565());
		toolStripMenuItem_31.Name = Class333.smethod_1566();
		toolStripMenuItem_31.Size = new Size(274, 36);
		toolStripMenuItem_31.Text = Class333.smethod_1567();
		toolStripMenuItem_31.Click += toolStripMenuItem_31_Click;
		toolStripMenuItem_32.Enabled = false;
		toolStripMenuItem_32.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1568());
		toolStripMenuItem_32.Name = Class333.smethod_1569();
		toolStripMenuItem_32.Size = new Size(274, 36);
		toolStripMenuItem_32.Text = Class333.smethod_1570();
		toolStripMenuItem_32.Click += toolStripButton_8_Click;
		toolStripMenuItem_6.Enabled = false;
		toolStripMenuItem_6.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1571());
		toolStripMenuItem_6.Name = Class333.smethod_1572();
		toolStripMenuItem_6.Size = new Size(274, 36);
		toolStripMenuItem_6.Text = Class333.smethod_1573();
		toolStripMenuItem_6.Click += toolStripButton_4_Click;
		toolStripMenuItem_10.Enabled = false;
		toolStripMenuItem_10.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1574());
		toolStripMenuItem_10.Name = Class333.smethod_1575();
		toolStripMenuItem_10.Size = new Size(274, 36);
		toolStripMenuItem_10.Text = Class333.smethod_1576();
		toolStripMenuItem_10.Click += toolStripButton_7_Click;
		toolStripMenuItem_58.Enabled = false;
		toolStripMenuItem_58.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1577());
		toolStripMenuItem_58.Name = Class333.smethod_1578();
		toolStripMenuItem_58.Size = new Size(274, 36);
		toolStripMenuItem_58.Text = Class333.smethod_1579();
		toolStripMenuItem_58.Visible = false;
		toolStripMenuItem_58.Click += toolStripDropDownButton_0_Click;
		toolStripMenuItem_59.Enabled = false;
		toolStripMenuItem_59.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1580());
		toolStripMenuItem_59.Name = Class333.smethod_1581();
		toolStripMenuItem_59.Size = new Size(274, 36);
		toolStripMenuItem_59.Text = Class333.smethod_1582();
		toolStripMenuItem_59.Visible = false;
		toolStripMenuItem_59.Click += toolStripMenuItem_59_Click;
		toolStripMenuItem_4.DropDownItems.AddRange(toolStripMenuItem_23, toolStripMenuItem_24, toolStripMenuItem_9, toolStripMenuItem_27);
		toolStripMenuItem_4.Name = Class333.smethod_1583();
		toolStripMenuItem_4.Size = new Size(46, 20);
		toolStripMenuItem_4.Text = Class333.smethod_1584();
		toolStripMenuItem_23.Enabled = false;
		toolStripMenuItem_23.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1585());
		toolStripMenuItem_23.Name = Class333.smethod_1586();
		toolStripMenuItem_23.Size = new Size(216, 36);
		toolStripMenuItem_23.Text = Class333.smethod_1587();
		toolStripMenuItem_23.Click += toolStripButton_5_Click;
		toolStripMenuItem_24.Enabled = false;
		toolStripMenuItem_24.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1588());
		toolStripMenuItem_24.Name = Class333.smethod_1589();
		toolStripMenuItem_24.Size = new Size(216, 36);
		toolStripMenuItem_24.Text = Class333.smethod_811();
		toolStripMenuItem_24.Click += toolStripButton_14_Click;
		toolStripMenuItem_9.Enabled = false;
		toolStripMenuItem_9.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1590());
		toolStripMenuItem_9.Name = Class333.smethod_1591();
		toolStripMenuItem_9.Size = new Size(216, 36);
		toolStripMenuItem_9.Text = Class333.smethod_704();
		toolStripMenuItem_9.Click += class169_0_Click;
		toolStripMenuItem_27.Enabled = false;
		toolStripMenuItem_27.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1592());
		toolStripMenuItem_27.Name = Class333.smethod_1593();
		toolStripMenuItem_27.ShortcutKeys = Keys.F12 | Keys.Control;
		toolStripMenuItem_27.Size = new Size(216, 36);
		toolStripMenuItem_27.Text = Class333.smethod_1278();
		toolStripMenuItem_27.Click += class168_0_Click;
		toolStripMenuItem_28.Enabled = false;
		toolStripMenuItem_28.Image = GeneralResources.IconErrorConfig;
		toolStripMenuItem_28.Name = Class333.smethod_1594();
		toolStripMenuItem_28.Size = new Size(216, 36);
		toolStripMenuItem_28.Text = Class333.smethod_1094();
		toolStripMenuItem_28.Click += toolStripButton_13_Click;
		toolStripMenuItem_13.DropDownItems.AddRange(toolStripMenuItem_18, toolStripMenuItem_52, toolStripMenuItem_54, toolStripMenuItem_55, toolStripMenuItem_56, toolStripMenuItem_53, toolStripMenuItem_50, toolStripMenuItem_14, toolStripMenuItem_16, toolStripMenuItem_17, toolStripMenuItem_15);
		toolStripMenuItem_13.Name = Class333.smethod_1595();
		toolStripMenuItem_13.Size = new Size(63, 20);
		toolStripMenuItem_13.Text = Class333.smethod_966();
		toolStripMenuItem_18.Name = Class333.smethod_1596();
		toolStripMenuItem_18.Size = new Size(398, 36);
		toolStripMenuItem_18.Text = Class333.smethod_916();
		toolStripMenuItem_18.Click += class166_0_Click;
		toolStripMenuItem_52.Name = Class333.smethod_1597();
		toolStripMenuItem_52.Size = new Size(398, 36);
		toolStripMenuItem_52.Text = Class333.smethod_1598();
		toolStripMenuItem_54.Name = Class333.smethod_1599();
		toolStripMenuItem_54.Size = new Size(398, 36);
		toolStripMenuItem_54.Text = Class333.smethod_1600();
		toolStripMenuItem_54.Click += toolStripMenuItem_54_Click;
		toolStripMenuItem_55.Name = Class333.smethod_1601();
		toolStripMenuItem_55.Size = new Size(398, 36);
		toolStripMenuItem_55.Text = Class333.smethod_1602();
		toolStripMenuItem_55.Click += toolStripMenuItem_55_Click;
		toolStripMenuItem_56.Name = Class333.smethod_1603();
		toolStripMenuItem_56.Size = new Size(398, 36);
		toolStripMenuItem_56.Text = Class333.smethod_1604();
		toolStripMenuItem_56.Click += toolStripMenuItem_56_Click;
		toolStripMenuItem_53.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1605());
		toolStripMenuItem_53.Name = Class333.smethod_1606();
		toolStripMenuItem_53.Size = new Size(398, 36);
		toolStripMenuItem_53.Text = Class333.smethod_1032();
		toolStripMenuItem_53.Click += toolStripMenuItem_53_Click;
		toolStripMenuItem_50.Name = Class333.smethod_1607();
		toolStripMenuItem_50.Size = new Size(398, 36);
		toolStripMenuItem_50.Text = Class333.smethod_726();
		toolStripMenuItem_50.Click += toolStripMenuItem_50_Click;
		toolStripMenuItem_14.Enabled = false;
		toolStripMenuItem_14.Name = Class333.smethod_1608();
		toolStripMenuItem_14.ShortcutKeyDisplayString = Class333.smethod_1245();
		toolStripMenuItem_14.ShortcutKeys = Keys.F6;
		toolStripMenuItem_14.Size = new Size(398, 36);
		toolStripMenuItem_14.Text = Class333.smethod_1609();
		toolStripMenuItem_14.Click += toolStripMenuItem_14_Click;
		toolStripMenuItem_16.Name = Class333.smethod_1610();
		toolStripMenuItem_16.ShortcutKeyDisplayString = Class333.smethod_1247();
		toolStripMenuItem_16.ShortcutKeys = Keys.F7;
		toolStripMenuItem_16.Size = new Size(398, 36);
		toolStripMenuItem_16.Text = Class333.smethod_1248();
		toolStripMenuItem_16.Click += toolStripMenuItem_16_Click;
		toolStripMenuItem_17.Name = Class333.smethod_1611();
		toolStripMenuItem_17.ShortcutKeyDisplayString = Class333.smethod_1612();
		toolStripMenuItem_17.ShortcutKeys = Keys.F7 | Keys.Shift;
		toolStripMenuItem_17.Size = new Size(398, 36);
		toolStripMenuItem_17.Text = Class333.smethod_1613();
		toolStripMenuItem_17.Click += toolStripMenuItem_17_Click;
		toolStripMenuItem_15.Name = Class333.smethod_1614();
		toolStripMenuItem_15.Size = new Size(398, 36);
		toolStripMenuItem_15.Text = Class333.smethod_1615();
		toolStripMenuItem_15.Click += toolStripMenuItem_15_Click;
		toolStripMenuItem_19.DropDownItems.AddRange(toolStripMenuItem_20, toolStripMenuItem_21, toolStripMenuItem_22, toolStripMenuItem_26, toolStripMenuItem_40, toolStripMenuItem_57);
		toolStripMenuItem_19.Name = Class333.smethod_1616();
		toolStripMenuItem_19.Size = new Size(80, 20);
		toolStripMenuItem_19.Text = Class333.smethod_1617();
		toolStripMenuItem_20.Name = Class333.smethod_1618();
		toolStripMenuItem_20.Size = new Size(209, 22);
		toolStripMenuItem_20.Text = Class333.smethod_1619();
		toolStripMenuItem_20.Click += toolStripMenuItem_20_Click;
		toolStripMenuItem_21.Name = Class333.smethod_1620();
		toolStripMenuItem_21.Size = new Size(209, 22);
		toolStripMenuItem_21.Text = Class333.smethod_1621();
		toolStripMenuItem_21.Click += toolStripMenuItem_21_Click;
		toolStripMenuItem_22.Name = Class333.smethod_1622();
		toolStripMenuItem_22.Size = new Size(209, 22);
		toolStripMenuItem_22.Text = Class333.smethod_1623();
		toolStripMenuItem_22.Click += toolStripMenuItem_22_Click;
		toolStripMenuItem_26.Name = Class333.smethod_1624();
		toolStripMenuItem_26.Size = new Size(209, 22);
		toolStripMenuItem_26.Text = Class333.smethod_554();
		toolStripMenuItem_26.Click += toolStripMenuItem_26_Click;
		toolStripMenuItem_40.Name = Class333.smethod_1625();
		toolStripMenuItem_40.Size = new Size(209, 22);
		toolStripMenuItem_40.Text = Class333.smethod_1626();
		toolStripMenuItem_40.Click += toolStripMenuItem_40_Click;
		toolStripMenuItem_57.Name = Class333.smethod_1627();
		toolStripMenuItem_57.Size = new Size(209, 22);
		toolStripMenuItem_57.Text = Class333.smethod_899();
		toolStripMenuItem_57.Click += toolStripMenuItem_57_Click;
		toolStripMenuItem_5.DropDownItems.AddRange(toolStripMenuItem_33, toolStripMenuItem_35, toolStripMenuItem_36, toolStripMenuItem_37, toolStripMenuItem_51, toolStripMenuItem_25);
		toolStripMenuItem_5.Name = Class333.smethod_1628();
		toolStripMenuItem_5.Size = new Size(44, 20);
		toolStripMenuItem_5.Text = Class333.smethod_1629();
		toolStripMenuItem_33.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1630());
		toolStripMenuItem_33.Name = Class333.smethod_1631();
		toolStripMenuItem_33.ShortcutKeys = Keys.F1;
		toolStripMenuItem_33.Size = new Size(193, 36);
		toolStripMenuItem_33.Text = Class333.smethod_598();
		toolStripMenuItem_33.Click += toolStripMenuItem_33_Click;
		toolStripMenuItem_35.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1632());
		toolStripMenuItem_35.Name = Class333.smethod_1633();
		toolStripMenuItem_35.Size = new Size(193, 36);
		toolStripMenuItem_35.Text = Class333.smethod_1634();
		toolStripMenuItem_35.Click += toolStripMenuItem_35_Click;
		toolStripMenuItem_36.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1635());
		toolStripMenuItem_36.Name = Class333.smethod_1636();
		toolStripMenuItem_36.Size = new Size(193, 36);
		toolStripMenuItem_36.Text = Class333.smethod_1637();
		toolStripMenuItem_36.Click += toolStripButton_9_Click;
		toolStripMenuItem_37.Name = Class333.smethod_1638();
		toolStripMenuItem_37.Size = new Size(193, 36);
		toolStripMenuItem_37.Text = Class333.smethod_1338();
		toolStripMenuItem_37.Click += toolStripMenuItem_37_Click;
		toolStripMenuItem_51.Name = Class333.smethod_1639();
		toolStripMenuItem_51.Size = new Size(193, 36);
		toolStripMenuItem_51.Text = Class333.smethod_1640();
		toolStripMenuItem_51.Click += toolStripMenuItem_51_Click;
		toolStripMenuItem_25.Name = Class333.smethod_1641();
		toolStripMenuItem_25.Size = new Size(193, 36);
		toolStripMenuItem_25.Text = Class333.smethod_725();
		toolStripMenuItem_25.Click += toolStripMenuItem_25_Click;
		toolStrip_0.AutoSize = false;
		toolStrip_0.Font = new Font(Class333.smethod_145(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
		toolStrip_0.ImageScalingSize = new Size(48, 48);
		toolStrip_0.Items.AddRange(toolStripButton_10, class167_0, class168_0, toolStripButton_0, toolStripButton_6, toolStripButton_11, toolStripButton_1, class163_0, toolStripButton_2, toolStripButton_3, toolStripButton_8, toolStripButton_4, toolStripButton_5, toolStripButton_14, toolStripDropDownButton_0, toolStripButton_7, class169_0, class162_0, class166_0, toolStripButton_13, class164_0, class170_0, class165_0, toolStripButton_12, toolStripButton_9);
		toolStrip_0.Location = new Point(0, 24);
		toolStrip_0.Name = Class333.smethod_1642();
		toolStrip_0.Size = new Size(1264, 53);
		toolStrip_0.TabIndex = 16;
		toolStrip_0.Text = Class333.smethod_1643();
		toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_10.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1644());
		toolStripButton_10.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_10.ImageTransparentColor = Color.Magenta;
		toolStripButton_10.Margin = new Padding(0);
		toolStripButton_10.Name = Class333.smethod_1645();
		toolStripButton_10.Size = new Size(52, 53);
		toolStripButton_10.Text = Class333.smethod_1646();
		toolStripButton_10.Click += toolStripButton_10_Click;
		class167_0.AutoToolTip = false;
		class167_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		class167_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1647());
		class167_0.ImageTransparentColor = Color.Magenta;
		class167_0.Margin = new Padding(0);
		class167_0.Name = Class333.smethod_1648();
		class167_0.Padding = new Padding(23, 0, 23, 0);
		class167_0.Size = new Size(98, 53);
		class167_0.Text = Class333.smethod_1244();
		class167_0.ToolTipText = Class333.smethod_1244();
		class167_0.Click += class167_0_Click;
		class168_0.AutoToolTip = false;
		class168_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		class168_0.Enabled = false;
		class168_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1649());
		class168_0.ImageScaling = ToolStripItemImageScaling.None;
		class168_0.ImageTransparentColor = Color.Magenta;
		class168_0.Margin = new Padding(0);
		class168_0.Name = Class333.smethod_1650();
		class168_0.Size = new Size(52, 53);
		class168_0.Text = Class333.smethod_702();
		class168_0.ToolTipText = Class333.smethod_702();
		class168_0.Click += class168_0_Click;
		toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1651());
		toolStripButton_0.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_0.ImageTransparentColor = Color.Magenta;
		toolStripButton_0.Margin = new Padding(0);
		toolStripButton_0.Name = Class333.smethod_1652();
		toolStripButton_0.Size = new Size(52, 53);
		toolStripButton_0.Text = Class333.smethod_1653();
		toolStripButton_0.ToolTipText = Class333.smethod_1653();
		toolStripButton_0.Click += toolStripButton_0_Click;
		toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_6.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1654());
		toolStripButton_6.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_6.ImageTransparentColor = Color.Magenta;
		toolStripButton_6.Margin = new Padding(0);
		toolStripButton_6.Name = Class333.smethod_1655();
		toolStripButton_6.Size = new Size(52, 53);
		toolStripButton_6.Text = Class333.smethod_1656();
		toolStripButton_6.ToolTipText = Class333.smethod_1656();
		toolStripButton_6.Click += toolStripButton_6_Click;
		toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_11.Enabled = false;
		toolStripButton_11.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1657());
		toolStripButton_11.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_11.ImageTransparentColor = Color.Magenta;
		toolStripButton_11.Margin = new Padding(0);
		toolStripButton_11.Name = Class333.smethod_1658();
		toolStripButton_11.Size = new Size(52, 53);
		toolStripButton_11.Text = Class333.smethod_1659();
		toolStripButton_11.ToolTipText = Class333.smethod_1659();
		toolStripButton_11.Click += toolStripButton_11_Click;
		toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_1.Enabled = false;
		toolStripButton_1.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1660());
		toolStripButton_1.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_1.ImageTransparentColor = Color.Magenta;
		toolStripButton_1.Margin = new Padding(0);
		toolStripButton_1.Name = Class333.smethod_1661();
		toolStripButton_1.Size = new Size(52, 53);
		toolStripButton_1.Text = Class333.smethod_1538();
		toolStripButton_1.ToolTipText = Class333.smethod_1181();
		toolStripButton_1.Click += toolStripButton_1_Click;
		class163_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		class163_0.DropDownItems.AddRange(toolStripMenuItem_46, toolStripMenuItem_47, toolStripMenuItem_48);
		class163_0.Enabled = false;
		class163_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1662());
		class163_0.ImageScaling = ToolStripItemImageScaling.None;
		class163_0.ImageTransparentColor = Color.Magenta;
		class163_0.Margin = new Padding(0);
		class163_0.Name = Class333.smethod_1663();
		class163_0.ShowDropDownArrow = false;
		class163_0.Size = new Size(52, 53);
		class163_0.Text = Class333.smethod_1664();
		toolStripMenuItem_46.Name = Class333.smethod_1665();
		toolStripMenuItem_46.Size = new Size(277, 22);
		toolStripMenuItem_46.Text = Class333.smethod_1544();
		toolStripMenuItem_46.Click += toolStripMenuItem_46_Click;
		toolStripMenuItem_47.Enabled = false;
		toolStripMenuItem_47.Name = Class333.smethod_1666();
		toolStripMenuItem_47.ShortcutKeyDisplayString = Class333.smethod_102();
		toolStripMenuItem_47.ShortcutKeys = Keys.F9;
		toolStripMenuItem_47.Size = new Size(277, 22);
		toolStripMenuItem_47.Text = Class333.smethod_1546();
		toolStripMenuItem_47.Click += toolStripMenuItem_47_Click;
		toolStripMenuItem_48.Enabled = false;
		toolStripMenuItem_48.Name = Class333.smethod_1667();
		toolStripMenuItem_48.Size = new Size(277, 22);
		toolStripMenuItem_48.Text = Class333.smethod_1548();
		toolStripMenuItem_48.Click += toolStripMenuItem_48_Click;
		toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_2.Enabled = false;
		toolStripButton_2.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1668());
		toolStripButton_2.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_2.ImageTransparentColor = Color.Magenta;
		toolStripButton_2.Margin = new Padding(0);
		toolStripButton_2.Name = Class333.smethod_1669();
		toolStripButton_2.Size = new Size(52, 53);
		toolStripButton_2.Text = Class333.smethod_1670();
		toolStripButton_2.Click += toolStripButton_2_Click;
		toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_3.Enabled = false;
		toolStripButton_3.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1671());
		toolStripButton_3.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_3.ImageTransparentColor = Color.Magenta;
		toolStripButton_3.Margin = new Padding(0);
		toolStripButton_3.Name = Class333.smethod_1672();
		toolStripButton_3.Size = new Size(52, 53);
		toolStripButton_3.Text = Class333.smethod_1673();
		toolStripButton_3.Click += toolStripButton_3_Click;
		toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_8.Enabled = false;
		toolStripButton_8.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1674());
		toolStripButton_8.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_8.ImageTransparentColor = Color.Magenta;
		toolStripButton_8.Margin = new Padding(0);
		toolStripButton_8.Name = Class333.smethod_1675();
		toolStripButton_8.Size = new Size(52, 53);
		toolStripButton_8.Text = Class333.smethod_1676();
		toolStripButton_8.Click += toolStripButton_8_Click;
		toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_4.Enabled = false;
		toolStripButton_4.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1677());
		toolStripButton_4.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_4.ImageTransparentColor = Color.Magenta;
		toolStripButton_4.Margin = new Padding(0);
		toolStripButton_4.Name = Class333.smethod_1678();
		toolStripButton_4.Size = new Size(52, 53);
		toolStripButton_4.Text = Class333.smethod_1679();
		toolStripButton_4.ToolTipText = Class333.smethod_1573();
		toolStripButton_4.Click += toolStripButton_4_Click;
		toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_5.Enabled = false;
		toolStripButton_5.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1680());
		toolStripButton_5.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_5.ImageTransparentColor = Color.Magenta;
		toolStripButton_5.Margin = new Padding(0);
		toolStripButton_5.Name = Class333.smethod_1681();
		toolStripButton_5.Size = new Size(52, 53);
		toolStripButton_5.Text = Class333.smethod_1587();
		toolStripButton_5.Click += toolStripButton_5_Click;
		toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_7.Enabled = false;
		toolStripButton_7.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1682());
		toolStripButton_7.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_7.ImageTransparentColor = Color.Magenta;
		toolStripButton_7.Margin = new Padding(0);
		toolStripButton_7.Name = Class333.smethod_1683();
		toolStripButton_7.Size = new Size(52, 53);
		toolStripButton_7.Text = Class333.smethod_1576();
		toolStripButton_7.Click += toolStripButton_7_Click;
		class169_0.AutoToolTip = false;
		class169_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		class169_0.Enabled = false;
		class169_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1684());
		class169_0.ImageScaling = ToolStripItemImageScaling.None;
		class169_0.ImageTransparentColor = Color.Magenta;
		class169_0.Margin = new Padding(0);
		class169_0.Name = Class333.smethod_1685();
		class169_0.Size = new Size(52, 53);
		class169_0.Text = Class333.smethod_704();
		class169_0.ToolTipText = Class333.smethod_704();
		class169_0.Click += class169_0_Click;
		class162_0.AutoToolTip = false;
		class162_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		class162_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1686());
		class162_0.ImageScaling = ToolStripItemImageScaling.None;
		class162_0.ImageTransparentColor = Color.Magenta;
		class162_0.Margin = new Padding(0);
		class162_0.Name = Class333.smethod_1687();
		class162_0.Size = new Size(52, 53);
		class162_0.Text = Class333.smethod_679();
		class162_0.ToolTipText = Class333.smethod_679();
		class162_0.Click += class162_0_Click;
		class166_0.AutoSize = false;
		class166_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		class166_0.ImageScaling = ToolStripItemImageScaling.None;
		class166_0.ImageTransparentColor = Color.Magenta;
		class166_0.Margin = new Padding(0);
		class166_0.Name = Class333.smethod_1688();
		class166_0.ShowDropDownArrow = false;
		class166_0.Size = new Size(52, 53);
		class166_0.Text = Class333.smethod_916();
		class166_0.Click += class166_0_Click;
		toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripDropDownButton_0.Enabled = false;
		toolStripDropDownButton_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1689());
		toolStripDropDownButton_0.ImageScaling = ToolStripItemImageScaling.None;
		toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
		toolStripDropDownButton_0.Margin = new Padding(0);
		toolStripDropDownButton_0.Name = Class333.smethod_1690();
		toolStripDropDownButton_0.ShowDropDownArrow = false;
		toolStripDropDownButton_0.Size = new Size(52, 53);
		toolStripDropDownButton_0.Text = Class333.smethod_1579();
		toolStripDropDownButton_0.Visible = false;
		toolStripDropDownButton_0.Click += toolStripDropDownButton_0_Click;
		toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_13.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1691());
		toolStripButton_13.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_13.ImageTransparentColor = Color.Magenta;
		toolStripButton_13.Margin = new Padding(0);
		toolStripButton_13.Name = Class333.smethod_1692();
		toolStripButton_13.Size = new Size(52, 53);
		toolStripButton_13.Text = Class333.smethod_1094();
		toolStripButton_13.ToolTipText = Class333.smethod_1094();
		toolStripButton_13.Visible = false;
		toolStripButton_13.Click += toolStripButton_13_Click;
		class164_0.Alignment = ToolStripItemAlignment.Right;
		class164_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		class164_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1693());
		class164_0.ImageScaling = ToolStripItemImageScaling.None;
		class164_0.ImageTransparentColor = Color.Magenta;
		class164_0.Margin = new Padding(0);
		class164_0.Name = Class333.smethod_1694();
		class164_0.Size = new Size(52, 53);
		class164_0.Text = Class333.smethod_1695();
		class164_0.ToolTipText = Class333.smethod_1696();
		class164_0.Click += class164_0_Click;
		class170_0.Alignment = ToolStripItemAlignment.Right;
		class170_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		class170_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1697());
		class170_0.ImageScaling = ToolStripItemImageScaling.None;
		class170_0.ImageTransparentColor = Color.Magenta;
		class170_0.Margin = new Padding(0);
		class170_0.Name = Class333.smethod_1698();
		class170_0.Size = new Size(52, 53);
		class170_0.Text = Class333.smethod_1699();
		class170_0.ToolTipText = Class333.smethod_1700();
		class170_0.Click += class170_0_Click;
		class165_0.Alignment = ToolStripItemAlignment.Right;
		class165_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		class165_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1701());
		class165_0.ImageScaling = ToolStripItemImageScaling.None;
		class165_0.ImageTransparentColor = Color.Magenta;
		class165_0.Margin = new Padding(0);
		class165_0.Name = Class333.smethod_1702();
		class165_0.Size = new Size(52, 53);
		class165_0.Text = Class333.smethod_1703();
		class165_0.ToolTipText = Class333.smethod_1704();
		class165_0.Click += class165_0_Click;
		toolStripButton_12.Alignment = ToolStripItemAlignment.Right;
		toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_12.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1705());
		toolStripButton_12.ImageTransparentColor = Color.Magenta;
		toolStripButton_12.Name = Class333.smethod_1706();
		toolStripButton_12.Size = new Size(52, 50);
		toolStripButton_12.Text = Class333.smethod_1707();
		toolStripButton_12.Click += toolStripButton_12_Click;
		toolStripButton_9.Alignment = ToolStripItemAlignment.Right;
		toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_9.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1708());
		toolStripButton_9.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_9.ImageTransparentColor = Color.Magenta;
		toolStripButton_9.Margin = new Padding(0);
		toolStripButton_9.Name = Class333.smethod_1709();
		toolStripButton_9.Size = new Size(52, 53);
		toolStripButton_9.Text = Class333.smethod_1637();
		toolStripButton_9.Click += toolStripButton_9_Click;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class333.smethod_145(), 12f);
		label_0.Location = new Point(0, 0);
		label_0.Name = Class333.smethod_1710();
		label_0.Size = new Size(103, 21);
		label_0.TabIndex = 30;
		label_0.Text = Class333.smethod_1711();
		label_0.Visible = false;
		pictureBox_0.BackColor = Color.Transparent;
		pictureBox_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1712());
		pictureBox_0.Location = new Point(0, 0);
		pictureBox_0.Name = Class333.smethod_1713();
		pictureBox_0.Size = new Size(800, 151);
		pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
		pictureBox_0.TabIndex = 26;
		pictureBox_0.TabStop = false;
		splitContainer_0.Dock = DockStyle.Fill;
		splitContainer_0.FixedPanel = FixedPanel.Panel1;
		splitContainer_0.Location = new Point(0, 77);
		splitContainer_0.Margin = new Padding(0);
		splitContainer_0.Name = Class333.smethod_1714();
		splitContainer_0.Panel1.Controls.Add(splitContainer_1);
		splitContainer_0.Panel1MinSize = 10;
		splitContainer_0.Panel2.Controls.Add(class131_3);
		splitContainer_0.Panel2.Controls.Add(class131_1);
		splitContainer_0.Panel2.Controls.Add(class131_0);
		splitContainer_0.Panel2.Controls.Add(class131_2);
		splitContainer_0.Panel2MinSize = 200;
		splitContainer_0.Size = new Size(1264, 685);
		splitContainer_0.SplitterDistance = 1000;
		splitContainer_0.TabIndex = 31;
		splitContainer_0.SplitterMoved += splitContainer_0_SplitterMoved;
		splitContainer_0.MouseMove += splitContainer_0_MouseMove;
		splitContainer_1.Dock = DockStyle.Fill;
		splitContainer_1.FixedPanel = FixedPanel.Panel1;
		splitContainer_1.Location = new Point(0, 0);
		splitContainer_1.Name = Class333.smethod_1715();
		splitContainer_1.Orientation = Orientation.Horizontal;
		splitContainer_1.Panel1.Controls.Add(startupOptionsPanel_0);
		splitContainer_1.Panel1.Controls.Add(label_0);
		splitContainer_1.Panel1.Controls.Add(control25_0);
		splitContainer_1.Panel1.Controls.Add(pictureBox_0);
		splitContainer_1.Panel1MinSize = 400;
		splitContainer_1.Panel2.Controls.Add(control3_0);
		splitContainer_1.Panel2MinSize = 0;
		splitContainer_1.Size = new Size(1000, 685);
		splitContainer_1.SplitterDistance = 400;
		splitContainer_1.SplitterWidth = 1;
		splitContainer_1.TabIndex = 0;
		splitContainer_1.SplitterMoved += splitContainer_1_SplitterMoved;
		splitContainer_1.MouseMove += splitContainer_1_MouseMove;
		startupOptionsPanel_0.BorderStyle = BorderStyle.FixedSingle;
		startupOptionsPanel_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		startupOptionsPanel_0.Location = new Point(0, 0);
		startupOptionsPanel_0.Name = Class333.smethod_649();
		startupOptionsPanel_0.Size = new Size(549, 275);
		startupOptionsPanel_0.TabIndex = 31;
		control25_0.Controls.Add(class130_0);
		control25_0.Controls.Add(class130_1);
		control25_0.DrawMode = TabDrawMode.OwnerDrawFixed;
		control25_0.Enabled = false;
		control25_0.Font = new Font(Class333.smethod_145(), 8f);
		control25_0.Location = new Point(0, 0);
		control25_0.Margin = new Padding(0);
		control25_0.Multiline = true;
		control25_0.Name = Class333.smethod_1716();
		control25_0.Padding = new Point(4, 3);
		control25_0.SelectedIndex = 0;
		control25_0.Size = new Size(741, 479);
		control25_0.TabIndex = 22;
		class130_0.BackColor = SystemColors.Control;
		class130_0.Location = new Point(4, 25);
		class130_0.Name = Class333.smethod_1717();
		class130_0.Padding = new Padding(3);
		class130_0.Size = new Size(733, 450);
		class130_0.TabIndex = 0;
		class130_0.Text = Class333.smethod_1718();
		class130_1.BackColor = SystemColors.Control;
		class130_1.Location = new Point(4, 25);
		class130_1.Name = Class333.smethod_1719();
		class130_1.Padding = new Padding(3);
		class130_1.Size = new Size(733, 450);
		class130_1.TabIndex = 1;
		class130_1.Text = Class333.smethod_1720();
		control3_0.Location = new Point(318, 33);
		control3_0.Name = Class333.smethod_521();
		control3_0.Size = new Size(600, 63);
		control3_0.TabIndex = 28;
		control3_0.Visible = false;
		class131_3.AutoScroll = true;
		class131_3.BackColor = SystemColors.Window;
		class131_3.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		class131_3.Location = new Point(0, 0);
		class131_3.Name = Class333.smethod_1721();
		class131_3.Size = new Size(258, 683);
		class131_3.TabIndex = 24;
		class131_3.Visible = false;
		class131_1.AutoScroll = true;
		class131_1.BackColor = SystemColors.Window;
		class131_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		class131_1.Location = new Point(0, 0);
		class131_1.Name = Class333.smethod_1722();
		class131_1.Size = new Size(258, 683);
		class131_1.TabIndex = 23;
		class131_1.Visible = false;
		class131_0.AutoScroll = true;
		class131_0.BackColor = SystemColors.Window;
		class131_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		class131_0.Location = new Point(0, 0);
		class131_0.Name = Class333.smethod_1723();
		class131_0.Size = new Size(258, 683);
		class131_0.TabIndex = 23;
		class131_0.Visible = false;
		class131_2.AutoScroll = true;
		class131_2.BackColor = SystemColors.Window;
		class131_2.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		class131_2.Location = new Point(0, 0);
		class131_2.Name = Class333.smethod_1724();
		class131_2.Size = new Size(258, 683);
		class131_2.TabIndex = 29;
		class131_2.Visible = false;
		control4_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		control4_0.Location = new Point(6, 80);
		control4_0.Margin = new Padding(0);
		control4_0.Name = Class333.smethod_1725();
		control4_0.Size = new Size(280, 678);
		control4_0.TabIndex = 21;
		toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_14.Enabled = false;
		toolStripButton_14.Image = (Image)componentResourceManager.GetObject(Class333.smethod_1726());
		toolStripButton_14.ImageScaling = ToolStripItemImageScaling.None;
		toolStripButton_14.ImageTransparentColor = Color.Magenta;
		toolStripButton_14.Margin = new Padding(0);
		toolStripButton_14.Name = Class333.smethod_1727();
		toolStripButton_14.Size = new Size(52, 53);
		toolStripButton_14.Text = Class333.smethod_811();
		toolStripButton_14.Click += toolStripButton_14_Click;
		AllowDrop = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1264, 762);
		Controls.Add(control4_0);
		Controls.Add(splitContainer_0);
		Controls.Add(toolStrip_0);
		Controls.Add(menuStrip_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Icon = (Icon)componentResourceManager.GetObject(Class333.smethod_1728());
		KeyPreview = true;
		Name = Class333.smethod_1729();
		Text = Class333.smethod_1730();
		WindowState = FormWindowState.Maximized;
		Activated += Form23_Activated;
		FormClosing += Form23_FormClosing;
		Shown += Form23_Shown;
		Resize += Form23_Resize;
		DragDrop += Form23_DragDrop;
		DragEnter += Form23_DragEnter;
		menuStrip_0.ResumeLayout(performLayout: false);
		menuStrip_0.PerformLayout();
		toolStrip_0.ResumeLayout(performLayout: false);
		toolStrip_0.PerformLayout();
		((ISupportInitialize)pictureBox_0).EndInit();
		splitContainer_0.Panel1.ResumeLayout(performLayout: false);
		splitContainer_0.Panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)splitContainer_0).EndInit();
		splitContainer_0.ResumeLayout(performLayout: false);
		splitContainer_1.Panel1.ResumeLayout(performLayout: false);
		splitContainer_1.Panel1.PerformLayout();
		splitContainer_1.Panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)splitContainer_1).EndInit();
		splitContainer_1.ResumeLayout(performLayout: false);
		control25_0.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	internal static bool smethod_27()
	{
		return bool_20;
	}

	private bool method_35()
	{
		bool_22 = true;
		Class1.smethod_18();
		List<Class5> list = Class1.smethod_27();
		string empty = string.Empty;
		if (list_2.Count == 1)
		{
			empty = list_2[0].BpS.string_0;
		}
		Form11 form = new Form11(list, empty);
		DialogResult dialogResult = form.ShowDialog(this);
		string text = form.method_5();
		Enum57 @enum = form.method_6();
		form.Dispose();
		if (dialogResult == DialogResult.OK && !string.IsNullOrEmpty(text) && @enum != Enum57.const_0)
		{
			if (!string.IsNullOrEmpty(empty) && text == empty && @enum == Enum57.const_1)
			{
				bool_22 = false;
				return false;
			}
			Class5 @class = Class1.smethod_26(text);
			if (@class != null)
			{
				method_38(@class, @enum);
				if (!string.IsNullOrEmpty(empty))
				{
					method_41(empty);
				}
			}
			else
			{
				smethod_32(bool_53: true);
			}
		}
		else
		{
			smethod_32(bool_53: true);
		}
		bool_22 = false;
		return true;
	}

	private void method_36()
	{
		class42_0.Top = toolStrip_0.Bottom;
		if (!Controls.Contains(class42_0))
		{
			Controls.Add(class42_0);
		}
		class42_0.method_0();
	}

	internal static bool smethod_28(string string_41, bool bool_53)
	{
		if ((int_0 & 1) != 0 && ((int_0 & 2) == 0 || !bool_53) && Class1.smethod_25(string_41) != Enum11.const_4)
		{
			return Class1.smethod_20(string_41);
		}
		return false;
	}

	private void class167_0_Click(object sender, EventArgs e)
	{
		if ((int_0 & 0x1000) != 0)
		{
			smethod_83();
		}
		else if ((int_0 & 1) != 0)
		{
			if ((int_0 & 2) != 0)
			{
				smethod_33(bool_53: true, bool_54: false);
			}
			else if (Class1.smethod_27().Count > 1)
			{
				if (!bool_22)
				{
					method_35();
				}
			}
			else
			{
				smethod_33(bool_53: true, bool_54: true);
			}
		}
		else if (Class1.smethod_3())
		{
			smethod_32(bool_53: true);
		}
		else
		{
			smethod_29(bool_53: true);
		}
	}

	internal static void smethod_29(bool bool_53)
	{
		if (bool_53)
		{
			Class1.smethod_0();
			return;
		}
		lock (object_1)
		{
			int_0 |= 1;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_30(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_3;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_31(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_3;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal static void smethod_32(bool bool_53)
	{
		smethod_33(bool_53, bool_54: false);
	}

	internal static void smethod_33(bool bool_53, bool bool_54)
	{
		if ((bool_53 & bool_54) && !bool_14 && !Form14.smethod_0())
		{
			bool flag = false;
			Form14 form = new Form14();
			if (form.ShowDialog(form23_0) != DialogResult.OK)
			{
				flag = true;
			}
			form.Dispose();
			if (flag)
			{
				return;
			}
		}
		lock (object_1)
		{
			int_0 &= -2;
			int_0 &= -3;
			int_0 &= -5;
			int_0 &= -33;
			int_0 &= -9;
			int_0 &= -65;
			int_0 &= -17;
			int_0 &= -129;
			int_0 &= -257;
		}
		if (class284_1 != null && (int_0 & 0x800) != 0)
		{
			class284_1.method_1();
		}
		if (eventHandler_3 != null)
		{
			eventHandler_3(null, null);
		}
		if (bool_53)
		{
			Class1.smethod_2();
		}
	}

	private void method_37(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate108 method = method_37;
				BeginInvoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (!(sender is List<Class5>))
		{
			return;
		}
		List<Class5> list = sender as List<Class5>;
		bool flag = false;
		foreach (Class5 item in list)
		{
			bool flag2 = false;
			for (int i = 0; i < list_2.Count; i++)
			{
				if (list_2[i].BpS.string_0 == item.string_0)
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
		if (!flag)
		{
			return;
		}
		if (bool_14)
		{
			Console.WriteLine();
			Console.WriteLine(Class333.smethod_1731());
		}
		else
		{
			Class23.smethod_3(Class333.smethod_1731());
		}
		List<Class5> list2 = Class1.smethod_27();
		foreach (Class5 item2 in list2)
		{
			Class229.smethod_39(item2.byte_4, item2.byte_5);
		}
		bool flag3 = Process.GetProcessesByName(Class333.smethod_1732()).Length > 1;
		if (list2.Count == 1)
		{
			if (string_28 == null && !bool_11)
			{
				if (bool_12)
				{
					method_38(list2[0], Enum57.const_3);
					if (list_2.Count == 2)
					{
						method_41(list_2[1].BpS.string_0);
					}
				}
				else if (((framework_1 != null && framework_1.method_5() && framework_1.method_9() && !bool_21) || flag3) && list2[0].byte_4 != 22)
				{
					if (!bool_14 && !bool_22)
					{
						method_35();
					}
				}
				else if (smethod_87(this, bool_53: true) == DialogResult.Cancel)
				{
					smethod_32(bool_53: true);
				}
				else
				{
					method_38(list2[0], Enum57.const_2);
					if (list_2.Count == 2)
					{
						method_41(list_2[1].BpS.string_0);
					}
				}
			}
			else
			{
				class240_0 = new Class240
				{
					axS = list2[0].byte_4,
					axs = list2[0].byte_5,
					axT = new Class14(list2[0].byte_0, list2[0].byte_1, list2[0].byte_2, list2[0].byte_3, list2[0].int_0),
					axt = list2[0].byte_16
				};
				if (string_28 != null)
				{
					method_228(string_28, class240_0);
				}
				else if (bool_11)
				{
					method_231(class240_0);
				}
				smethod_32(bool_53: true);
			}
		}
		else
		{
			if (bool_14)
			{
				return;
			}
			bool flag4 = false;
			if (framework_1 != null && framework_1.method_5() && framework_1.method_9())
			{
				foreach (Class5 item3 in list2)
				{
					if (item3.string_0 == framework_1.aXc && smethod_28(item3.string_0, bool_53: true) && !list.Contains(item3))
					{
						flag4 = true;
						break;
					}
				}
			}
			if (flag4)
			{
				method_36();
			}
			else if ((framework_1 == null || (framework_1.method_5() && framework_1.method_9())) && !bool_22)
			{
				method_35();
			}
		}
	}

	internal void method_38(Class5 class5_0, Enum57 enum57_0)
	{
		if (!bool_14 && control3_0.Visible)
		{
			smethod_83();
		}
		bool flag = method_8(class5_0, out var bool_);
		if (bool_)
		{
			return;
		}
		if (enum57_0 == Enum57.const_2 && !flag)
		{
			lock (object_1)
			{
				int_0 |= 2;
			}
		}
		method_39(class5_0);
		if ((int_0 & 1) == 0)
		{
			smethod_29(bool_53: false);
			if (flag)
			{
				lock (object_1)
				{
					int_0 &= -3;
				}
			}
		}
		if (!flag)
		{
			if (framework_1 == null)
			{
				method_121(class5_0);
			}
			else if (string_20 != null)
			{
				if (class5_0.string_0 != string_20)
				{
					Form54.smethod_6(this, Class333.smethod_1733(), Class333.smethod_1130(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					method_45(class5_0, enum57_0);
				}
				else
				{
					lock (object_1)
					{
						int_0 &= -3;
					}
				}
			}
			else
			{
				method_45(class5_0, enum57_0);
			}
		}
		string_20 = null;
	}

	private void method_39(Class5 class5_0)
	{
		Class210 @class = new Class210();
		@class.BpS = class5_0;
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerSupportsCancellation = true;
		backgroundWorker.DoWork += method_42;
		backgroundWorker.RunWorkerAsync(class5_0);
		@class.Bps = backgroundWorker;
		if (list_2.Count == 0)
		{
			list_2.Add(@class);
		}
		else
		{
			list_2.Insert(0, @class);
		}
	}

	private void method_40(object sender, EventArgs2 e)
	{
		if (e.enum7_0 != Enum7.const_2)
		{
			return;
		}
		if (InvokeRequired)
		{
			try
			{
				Delegate109 method = method_40;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (sender is string)
		{
			string string_ = sender as string;
			if (Class1.smethod_25(string_) == Enum11.const_4)
			{
				method_41(string_);
				Class1.smethod_18();
			}
			if (Class1.smethod_27().Count == 0)
			{
				smethod_32(bool_53: false);
			}
		}
	}

	internal void method_41(string string_41)
	{
		for (int i = 0; i < list_2.Count; i++)
		{
			Class210 @class = list_2[i];
			if (@class.BpS.string_0 == string_41)
			{
				@class.Bps.CancelAsync();
				list_2.Remove(@class);
				break;
			}
		}
		enum59_0 = Enum59.BpC;
		if (!bool_14)
		{
			statsReporter_0.StorePendingStats();
			if ((int_0 & 0x10) != 0)
			{
				Form54.smethod_6(this, Class333.smethod_1734(), Class333.smethod_1130(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}

	private void method_42(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		Class5 @class = e.Argument as Class5;
		Thread.CurrentThread.Name = Class333.smethod_1735() + @class.string_0;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		new Stopwatch().Start();
		Stopwatch stopwatch2 = new Stopwatch();
		int num = 0;
		Stopwatch stopwatch3 = new Stopwatch();
		while (true)
		{
			if (bool_19)
			{
				if (@class.byte_4 == 22)
				{
					Thread.Sleep(500);
					continue;
				}
				if (!bool_14 && control4_0.method_3())
				{
					Thread.Sleep(100);
					continue;
				}
				if (backgroundWorker.CancellationPending)
				{
					break;
				}
				stopwatch3.Restart();
				try
				{
					if (backgroundWorker.CancellationPending)
					{
						break;
					}
					if ((int_0 & 1) == 0)
					{
						stopwatch2.Reset();
					}
					if (backgroundWorker.CancellationPending)
					{
						break;
					}
					Framework framework = framework_1;
					if (bool_20)
					{
						if ((int_0 & 1) != 0 && (int_0 & 2) == 0)
						{
							bool flag = Class1.smethod_21(@class.string_0);
							bool flag2 = Class320.smethod_47(@class);
							if (flag)
							{
								Class1.smethod_22(@class.string_0);
							}
							if (flag2)
							{
								framework?.method_6();
								if (enum59_0 == Enum59.Bpc || enum59_0 == Enum59.Bpe)
								{
									enum59_0 = Enum59.BpD;
								}
							}
							else if (!flag)
							{
								bool_20 = false;
								BeginInvoke(() =>
								{
									Form54.smethod_6(this, Class333.smethod_2047(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								});
							}
						}
						bool_20 = false;
					}
					else if (bool_1)
					{
						if ((int_0 & 1) != 0)
						{
							Class1.smethod_58(@class.string_0, out var _);
						}
						bool_1 = false;
					}
					else if (string_20 == null && !bool_18 && framework != null && (int_0 & 0x80) == 0 && enum59_0 != Enum59.BpE)
					{
						if (framework.method_5() && hashSet_3.Count == 0)
						{
							if ((int_0 & 2) == 0 && (int_0 & 0x100) == 0 && (int_0 & 0x200) == 0 && (int_0 & 0x20) == 0 && (int_0 & 0x40) == 0)
							{
								bool flag4 = !Form10.smethod_26() && Class1.enum6_0 == Enum6.const_3;
								if ((int_0 & 1) != 0 && Class1.smethod_20(@class.string_0))
								{
									if (!bool_14 && ((stopwatch.ElapsedMilliseconds > 500L && !flag4) || ((stopwatch.ElapsedMilliseconds > 1500L) & flag4)))
									{
										smethod_63();
										stopwatch.Restart();
									}
									if (backgroundWorker.CancellationPending)
									{
										break;
									}
									int num2 = 0;
									bool flag5;
									lock (object_2)
									{
										flag5 = framework.method_81(ref num2);
									}
									if (backgroundWorker.CancellationPending)
									{
										break;
									}
									if (framework.method_9() && (int_0 & 0x20) == 0)
									{
										if (flag4)
										{
											framework.method_71(1500L);
										}
										else
										{
											framework.method_71(300L);
										}
									}
									if (backgroundWorker.CancellationPending)
									{
										break;
									}
									int num3 = 0;
									bool flag6;
									lock (object_2)
									{
										flag6 = framework.method_79(ref num3);
									}
									if (backgroundWorker.CancellationPending)
									{
										break;
									}
									lock (object_1)
									{
										if (flag6)
										{
											int_0 |= 4;
										}
										else
										{
											int_0 &= -5;
										}
										if (flag5)
										{
											int_0 |= 8;
										}
										else
										{
											int_0 &= -9;
										}
										if (smethod_34(bool_53: false))
										{
											int_0 |= 16;
										}
										else
										{
											int_0 &= -17;
										}
										if (flag5)
										{
											stopwatch_0.Restart();
										}
									}
									framework.method_80();
								}
								if (backgroundWorker.CancellationPending)
								{
									break;
								}
								bool flag7 = !bool_14 && (int_0 & 0x1000) != 0;
								if ((int_0 & 1) != 0)
								{
									if (Class1.smethod_20(@class.string_0) && !flag7)
									{
										int num4 = 0;
										framework.method_78(ref num4);
										if (!framework_1.aWW.IsValid)
										{
											method_75();
										}
										if (!smethod_80())
										{
											framework.method_82();
										}
										if (enum59_0 == Enum59.BpD)
										{
											enum59_0 = Enum59.Bpd;
										}
										if (backgroundWorker.CancellationPending)
										{
											break;
										}
										if (!bool_14)
										{
											string empty = string.Empty;
											bool flag8 = framework.method_28(ref empty);
											if (framework.method_9() & flag8)
											{
												Form10.smethod_33(empty);
												if (Form10.bool_2 && !bool_15 && (int_0 & 0x800) != 0)
												{
													class284_1.method_3();
												}
											}
										}
										if (backgroundWorker.CancellationPending || backgroundWorker.CancellationPending)
										{
											break;
										}
									}
									else
									{
										Class1.smethod_37(@class.string_0, Enum10.const_5, 0u, 4u, out var _, out var _);
									}
								}
								if ((int_0 & 1) != 0 && Class1.smethod_20(@class.string_0) && stopwatch2.ElapsedMilliseconds <= 5500L && (stopwatch2.ElapsedMilliseconds == 0L || stopwatch2.ElapsedMilliseconds - num >= 1000L))
								{
									stopwatch2.Start();
									num = (int)stopwatch2.ElapsedMilliseconds;
									Class1.smethod_60(@class.string_0, out var _);
								}
							}
							if (!bool_14 && (int_0 & 0x400) != 0)
							{
								class284_0.method_3();
							}
						}
						else
						{
							Thread.Sleep(100);
							if ((int_0 & 1) != 0)
							{
								Class1.smethod_37(@class.string_0, Enum10.const_5, 0u, 4u, out var _, out var _);
							}
						}
					}
					stopwatch3.Stop();
					int num5 = (int)stopwatch3.ElapsedMilliseconds;
					int num6 = ((num5 != 0) ? (1000 / num5) : 0);
					if ((int_0 & 0x200) == 0)
					{
						Class23.smethod_3(string.Format(Class333.smethod_1736() + @class.string_0 + Class333.smethod_1737(), num5, num6), bool_1: false);
					}
					if (num5 < 40)
					{
						Thread.Sleep(40 - num5);
					}
					else
					{
						Thread.Sleep(0);
					}
					if (backgroundWorker.CancellationPending)
					{
						break;
					}
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.smethod_1738() + ex.Message);
				}
			}
			else
			{
				smethod_32(bool_53: true);
				Thread.Sleep(500);
			}
		}
	}

	internal bool method_43()
	{
		if (framework_1 != null)
		{
			if (framework_1.awZ == 21)
			{
				return (DateTime.Now - dateTime_0).TotalMilliseconds < 6000.0;
			}
			return (DateTime.Now - dateTime_0).TotalMilliseconds < 2000.0;
		}
		return false;
	}

	internal void class168_0_Click(object sender, EventArgs e)
	{
		if (method_43())
		{
			return;
		}
		dateTime_0 = DateTime.Now;
		if (list_2.Count != 1 || smethod_34(bool_53: false))
		{
			return;
		}
		bool flag = framework_1 != null && framework_1.awZ != 21 && framework_1.method_68();
		if (flag && !Form36.smethod_0())
		{
			Form36 form = new Form36();
			if (form.ShowDialog(this) == DialogResult.OK)
			{
				method_44();
			}
			form.Dispose();
		}
		else
		{
			method_44();
		}
	}

	internal void method_44()
	{
		if (framework_1 == null || !Class1.smethod_20(framework_1.aXc))
		{
			return;
		}
		bool flag = Class1.smethod_21(framework_1.aXc);
		bool_20 = true;
		if (!flag)
		{
			return;
		}
		string_20 = framework_1.aXc;
		while (bool_20)
		{
			Thread.Sleep(0);
		}
		form62_0 = new Form62();
		if (form62_0.ShowDialog(this) == DialogResult.OK)
		{
			framework_1.method_6();
		}
		else
		{
			Class1.smethod_17(framework_1.aXc);
			if (Class1.smethod_27().Count == 0)
			{
				smethod_32(bool_53: false);
			}
		}
		string_20 = null;
		form62_0.Dispose();
	}

	internal static bool smethod_34(bool bool_53)
	{
		if (framework_1 != null && framework_1.method_5())
		{
			Setting setting = framework_1.method_31(23);
			if (setting != null)
			{
				if (bool_53)
				{
					int num = setting.method_278();
					int num2 = 10;
					bool flag;
					do
					{
						if (flag = Class1.smethod_37(framework_1.aXc, Enum10.const_5, (uint)setting.method_65(), (uint)num, out var byte_, out var _))
						{
							for (int i = 0; i < num; i++)
							{
								setting.method_270(i, byte_[i], bool_0: false);
							}
						}
						num2--;
					}
					while (num2 != 0 && !flag);
					if (!flag)
					{
						return false;
					}
				}
				return setting.method_256() != 0;
			}
			return false;
		}
		return false;
	}

	private void method_45(Class5 class5_0, Enum57 enum57_0)
	{
		if (!Class320.smethod_48(class5_0))
		{
			if (enum57_0 == Enum57.const_2)
			{
				method_117();
				smethod_9();
			}
			framework_1.method_74();
			int byte_ = class5_0.byte_4;
			int byte_2 = class5_0.byte_5;
			byte[] byte_3 = class5_0.byte_16;
			Class14 @class = new Class14(class5_0.byte_0, class5_0.byte_1, class5_0.byte_2, class5_0.byte_3, class5_0.int_0);
			if (!bool_14 && method_122(@class))
			{
				return;
			}
			switch (enum57_0)
			{
			case Enum57.const_2:
			{
				string value = Class234.smethod_8(byte_, byte_2, @class, byte_3, bool_0: true);
				if (!string.IsNullOrEmpty(value))
				{
					Framework framework = new Framework(value, byte_, byte_2, @class);
					framework.aXc = class5_0.string_0;
					Class211 argument = new Class211
					{
						BpT = framework,
						Bpt = class5_0
					};
					BackgroundWorker backgroundWorker = new BackgroundWorker();
					backgroundWorker.WorkerReportsProgress = true;
					backgroundWorker.DoWork += method_49;
					backgroundWorker.ProgressChanged += smethod_69;
					backgroundWorker.RunWorkerCompleted += method_50;
					smethod_66(Class333.smethod_1739());
					backgroundWorker.RunWorkerAsync(argument);
				}
				else if (class5_0.struct1_0[3].uint_1 != 0)
				{
					lock (object_1)
					{
						int_0 |= 128;
					}
					BackgroundWorker backgroundWorker2 = new BackgroundWorker();
					backgroundWorker2.WorkerReportsProgress = true;
					backgroundWorker2.DoWork += method_201;
					backgroundWorker2.ProgressChanged += smethod_69;
					backgroundWorker2.RunWorkerCompleted += method_202;
					smethod_66(Class333.smethod_1740());
					backgroundWorker2.RunWorkerAsync(class5_0);
				}
				else
				{
					BackgroundWorker backgroundWorker3 = new BackgroundWorker();
					backgroundWorker3.DoWork += Class229.smethod_44;
					backgroundWorker3.WorkerReportsProgress = true;
					backgroundWorker3.ProgressChanged += smethod_69;
					smethod_66(Class333.smethod_1390());
					BackgroundWorker backgroundWorker4 = new BackgroundWorker();
					backgroundWorker4.DoWork += method_46;
					backgroundWorker4.RunWorkerCompleted += method_47;
					backgroundWorker3.RunWorkerAsync();
					backgroundWorker4.RunWorkerAsync(class5_0);
					Class229.abM = true;
				}
				break;
			}
			case Enum57.const_3:
				if (byte_ == framework_1.awZ && byte_2 == framework_1.awz && @class == framework_1.aXA)
				{
					framework_1.method_71(0L);
					framework_1.aXc = class5_0.string_0;
					method_223(null, -1);
					break;
				}
				if (!bool_14)
				{
					if (byte_ == framework_1.awZ && byte_2 == framework_1.awz)
					{
						Form54.smethod_6(this, Class333.smethod_1743(), Class333.smethod_1744(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						Form54.smethod_6(this, Class333.smethod_1741(), Class333.smethod_1742(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				smethod_32(bool_53: true);
				break;
			}
			return;
		}
		lock (object_1)
		{
			int_0 &= -3;
		}
	}

	private void method_46(object sender, DoWorkEventArgs e)
	{
		Class5 @class = (Class5)e.Argument;
		Class14 axT = new Class14(@class.byte_0, @class.byte_1, @class.byte_2, @class.byte_3, @class.int_0);
		string text = Class320.smethod_13(new Class240
		{
			axS = @class.byte_4,
			axs = @class.byte_5,
			axT = axT,
			axt = @class.byte_16
		}, @class.ushort_0);
		string[] bQQ = Class229.smethod_46(axT, @class.byte_4, @class.byte_5, text, out var nullable_, out var updateOutcomes_);
		Struct32 @struct = new Struct32
		{
			BQP = @class
		};
		if (nullable_.HasValue && updateOutcomes_ == UpdateOutcomes.CompleteUpdate)
		{
			@struct.BQp = updateOutcomes_;
			@struct.BQQ = bQQ;
		}
		e.Result = @struct;
	}

	private void method_47(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct32 @struct = (Struct32)e.Result;
		Class5 bQP = @struct.BQP;
		smethod_68();
		if (@struct.BQQ != null && @struct.BQQ.Length != 0)
		{
			string[] bQQ = @struct.BQQ;
			foreach (string text in bQQ)
			{
				List<string> list;
				if (text.EndsWith(Class333.smethod_1402()))
				{
					list = new List<string>();
					list.Add(text);
				}
				else
				{
					list = Class234.smethod_13(text);
				}
				if (list.Count != 0 && method_48(text, bQP))
				{
					return;
				}
			}
		}
		string text2 = Class242.smethod_10(bQP.byte_4, bQP.byte_5);
		text2 = ((text2 != null) ? (Class333.smethod_1393() + text2 + Class333.smethod_1394()) : string.Empty);
		Class14 @class = new Class14(bQP.byte_0, bQP.byte_1, bQP.byte_2, bQP.byte_3, bQP.int_0);
		string text3 = Class333.smethod_1745() + text2 + Class333.smethod_1396() + @class.ToString();
		if (!bool_14 && Form54.smethod_6(this, text3 + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_48(openFileDialog_0.FileName, bQP))
			{
			}
		}
	}

	private bool method_48(string string_41, Class5 class5_0)
	{
		try
		{
			Class14 @class = new Class14(class5_0.byte_0, class5_0.byte_1, class5_0.byte_2, class5_0.byte_3, class5_0.int_0);
			int byte_ = class5_0.byte_4;
			int byte_2 = class5_0.byte_5;
			byte[] byte_3 = class5_0.byte_16;
			Class240 class2 = new Class240
			{
				axS = byte_,
				axs = byte_2,
				axT = @class,
				axt = byte_3
			};
			string text = null;
			bool flag;
			bool flag2;
			bool flag3;
			Class14 class3;
			if (string_41.EndsWith(Class333.smethod_1404()))
			{
				flag = Class320.smethod_12(string_41, class2, out flag2, out flag3, out class3, out text);
			}
			else
			{
				text = string_41;
				flag = Class234.smethod_5(string_41, class2, out flag2, out flag3, out class3);
			}
			if (flag && text != null)
			{
				Framework framework = new Framework(text, byte_, byte_2, @class);
				framework.aXc = class5_0.string_0;
				Class211 argument = new Class211
				{
					BpT = framework,
					Bpt = class5_0
				};
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.DoWork += method_49;
				backgroundWorker.ProgressChanged += smethod_69;
				backgroundWorker.RunWorkerCompleted += method_50;
				smethod_66(Class333.smethod_1739());
				backgroundWorker.RunWorkerAsync(argument);
				return true;
			}
			if (!bool_14)
			{
				if (!(class3 == null) && text != null)
				{
					if (!flag2)
					{
						Form54.smethod_6(this, Class333.smethod_1746(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else if (!flag3)
					{
						Form54.smethod_6(this, Class333.smethod_1407() + class3.ToString() + Class333.smethod_1747() + @class.ToString() + Class333.smethod_9(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						Form54.smethod_6(this, Class333.smethod_1409(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				else
				{
					Form54.smethod_6(this, Class333.smethod_1405(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1748() + ex.Message);
		}
		return false;
	}

	private void method_49(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		Thread.Sleep(100);
		backgroundWorker.ReportProgress(30);
		Class211 @class = e.Argument as Class211;
		Framework bpT = @class.BpT;
		Class237.Enum91 @enum = bpT.method_1();
		backgroundWorker.ReportProgress(80);
		if (@enum == Class237.Enum91.Brc && bpT.awZ == 21)
		{
			bpT.method_12();
			backgroundWorker.ReportProgress(90);
		}
		Thread.Sleep(100);
		backgroundWorker.ReportProgress(100);
		e.Result = new Class212
		{
			BpU = @enum,
			Bpu = bpT,
			BpV = @class.Bpt
		};
	}

	private void method_50(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		Class212 obj = e.Result as Class212;
		Framework bpu = obj.Bpu;
		Class237.Enum91 bpU = obj.BpU;
		Class5 bpV = obj.BpV;
		if (bpU == Class237.Enum91.Brc)
		{
			framework_1 = bpu;
			method_181(null, -1);
			return;
		}
		string empty = string.Empty;
		switch (bpU)
		{
		case Class237.Enum91.BrD:
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += Class229.smethod_44;
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.ProgressChanged += smethod_69;
			smethod_66(Class333.smethod_1390());
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += method_51;
			backgroundWorker2.RunWorkerCompleted += method_52;
			Class213 argument = new Class213
			{
				BpW = bpV,
				Bpv = bpu
			};
			backgroundWorker.RunWorkerAsync();
			backgroundWorker2.RunWorkerAsync(argument);
			Class229.abM = true;
			return;
		}
		case Class237.Enum91.Brd:
			empty = Class333.smethod_1391();
			break;
		case Class237.Enum91.BrE:
			empty = Class333.smethod_1392();
			break;
		case Class237.Enum91.Bre:
			empty = Class333.smethod_1749() + bpu.aXA.ToString();
			break;
		default:
			empty = Class333.smethod_1750() + bpu.aXA.ToString();
			break;
		}
		if (!bool_14 && Form54.smethod_6(this, empty + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_53(openFileDialog_0.FileName, bpV, bpu))
			{
			}
		}
	}

	private void method_51(object sender, DoWorkEventArgs e)
	{
		Class213 @class = e.Argument as Class213;
		Framework bpv = @class.Bpv;
		string text = Class320.smethod_13(new Class240
		{
			axS = bpv.awZ,
			axs = bpv.awz,
			axT = bpv.aXA,
			axt = @class.BpW.byte_16
		}, ushort.MaxValue);
		string[] bQo = Class229.smethod_46(bpv.aXA, bpv.awZ, bpv.awz, text, out var nullable_, out var updateOutcomes_);
		Struct31 @struct = new Struct31
		{
			BQN = @class.BpW,
			BQn = bpv
		};
		if (nullable_.HasValue && updateOutcomes_ == UpdateOutcomes.CompleteUpdate)
		{
			@struct.BQO = updateOutcomes_;
			@struct.BQo = bQo;
		}
		e.Result = @struct;
	}

	private void method_52(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct31 @struct = (Struct31)e.Result;
		smethod_68();
		if (@struct.BQo != null && @struct.BQo.Length != 0)
		{
			string[] bQo = @struct.BQo;
			foreach (string text in bQo)
			{
				List<string> list;
				if (text.EndsWith(Class333.smethod_1402()))
				{
					list = new List<string>();
					list.Add(text);
				}
				else
				{
					list = Class234.smethod_13(text);
				}
				if (list.Count != 0 && method_53(text, @struct.BQN, @struct.BQn))
				{
					return;
				}
			}
		}
		if (bool_14)
		{
			return;
		}
		string text2 = Class242.smethod_10(@struct.BQn.awZ, @struct.BQn.awz);
		string text3 = string.Concat(str1: (text2 != null) ? (Class333.smethod_1393() + text2 + Class333.smethod_1394()) : string.Empty, str0: Class333.smethod_1403(), str2: Class333.smethod_1396(), str3: @struct.BQn.aXA.ToString());
		if (Form54.smethod_6(this, text3 + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_53(openFileDialog_0.FileName, @struct.BQN, @struct.BQn))
			{
			}
		}
	}

	private bool method_53(string string_41, Class5 class5_0, Framework framework_2)
	{
		try
		{
			Class240 @class = new Class240
			{
				axS = framework_2.awZ,
				axs = framework_2.awz,
				axT = framework_2.aXA,
				axt = class5_0.byte_16
			};
			string text = null;
			bool flag;
			bool flag2;
			bool flag3;
			Class14 class2;
			if (string_41.EndsWith(Class333.smethod_1404()))
			{
				flag = Class320.smethod_12(string_41, @class, out flag2, out flag3, out class2, out text);
			}
			else
			{
				text = string_41;
				flag = Class234.smethod_5(string_41, @class, out flag2, out flag3, out class2);
			}
			if (flag && text != null)
			{
				framework_2 = new Framework(text, framework_2.awZ, framework_2.awz, framework_2.aXA);
				framework_2.aXc = class5_0.string_0;
				Class211 argument = new Class211
				{
					BpT = framework_2,
					Bpt = class5_0
				};
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.ProgressChanged += smethod_69;
				backgroundWorker.DoWork += method_49;
				backgroundWorker.RunWorkerCompleted += method_50;
				smethod_66(Class333.smethod_1739());
				backgroundWorker.RunWorkerAsync(argument);
				return true;
			}
			if (!bool_14)
			{
				if (!(class2 == null) && text != null)
				{
					if (!flag2)
					{
						Form54.smethod_6(this, Class333.smethod_1746(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else if (!flag3)
					{
						Form54.smethod_6(this, Class333.smethod_1407() + class2.ToString() + Class333.smethod_1747() + framework_2.aXA.ToString() + Class333.smethod_9(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						Form54.smethod_6(this, Class333.smethod_1409(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				else
				{
					Form54.smethod_6(this, Class333.smethod_1405(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1751() + ex.Message);
		}
		return false;
	}

	internal void method_54(Enum55 enum55_0, bool bool_53, bool bool_54, bool bool_55)
	{
		if (framework_1 == null || !framework_1.method_5() || framework_1.method_31(9497).method_256() == 0)
		{
			return;
		}
		if (framework_1.method_31(9500).method_256() != 0)
		{
			Form54.smethod_6(this, Class333.smethod_949(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (framework_1.method_31(9501).method_256() < 0)
		{
			Form54.smethod_6(this, Class333.smethod_1752(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		string empty = string.Empty;
		if (framework_1.method_28(ref empty))
		{
			try
			{
				string text = framework_1.aXD;
				if (string.IsNullOrEmpty(text))
				{
					text = smethod_99(empty, framework_1.aXc);
					if (string.IsNullOrEmpty(text))
					{
						text = smethod_100(empty, new List<string> { framework_1.aXc });
					}
					framework_1.aXD = text;
				}
				Directory.CreateDirectory(text + Class333.smethod_952());
			}
			catch
			{
				Form54.smethod_6(this, Class333.smethod_1753(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			GC.Collect();
			Struct26 @struct = new Struct26
			{
				Bpw = enum55_0,
				BpX = bool_53,
				Bpx = bool_54,
				BpY = bool_55
			};
			bool_23 = true;
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.ProgressChanged += smethod_69;
			backgroundWorker.DoWork += method_55;
			backgroundWorker.RunWorkerCompleted += method_64;
			smethod_66(Class333.smethod_1755());
			backgroundWorker.RunWorkerAsync(@struct);
			string_33 = null;
			bool_24 = false;
			bool_25 = false;
			if (bool_53)
			{
				bool_25 = true;
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Title = Class333.smethod_1756();
				saveFileDialog.Filter = Class333.smethod_1757();
				saveFileDialog.InitialDirectory = framework_1.aXD + Class333.smethod_952();
				if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
				{
					string_33 = saveFileDialog.FileName;
				}
				else
				{
					string_33 = null;
				}
				saveFileDialog.Dispose();
			}
			if (bool_54)
			{
				bool_25 = true;
				if (Form54.smethod_4(this, Class333.smethod_1758(), Class333.smethod_1759(), MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					bool_24 = true;
				}
				else
				{
					bool_24 = false;
				}
			}
			bool_25 = false;
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_1754(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_55(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		Struct26 @struct = (Struct26)e.Argument;
		e.Result = null;
		string string_ = framework_1.aXD + Class333.smethod_1760();
		int num = framework_1.method_31(9497).method_256();
		int num2 = framework_1.method_31(9510).method_256();
		int capacity = num / num2;
		List<int> list_ = new List<int>(capacity);
		List<int> list_2 = new List<int>(capacity);
		bool bool_ = true;
		bool bool_2 = false;
		method_56(backgroundWorker, ref bool_, ref bool_2, string_, list_, list_2, out var int_, out var int_2, out var dictionary_);
		string string_2 = null;
		if (bool_ && !bool_2)
		{
			method_58(backgroundWorker, string_, ref string_2, list_, list_2, int_, int_2, dictionary_);
		}
		GC.Collect();
		string bpz = null;
		if ((!@struct.BpY & bool_) && string_2 != null)
		{
			Invoke(() =>
			{
				smethod_66(Class333.Bda());
			});
			try
			{
				Form10.Struct22 struct2 = new Form10.Struct22
				{
					Boi = framework_1.aXD + Class333.smethod_975(),
					BoJ = Path.GetFileNameWithoutExtension(string_2),
					Boj = string_2,
					BoK = null,
					Bok = -1
				};
				DoWorkEventArgs e2 = new DoWorkEventArgs(struct2);
				Form10.smethod_37(backgroundWorker, e2);
				bpz = struct2.Boi + struct2.BoJ + Class333.smethod_919();
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.smethod_1761() + ex.Message);
				bpz = null;
			}
		}
		Struct27 struct3 = new Struct27
		{
			Bpy = bool_,
			BpZ = string_2,
			Bpz = bpz,
			BQA = @struct.Bpw,
			BQa = @struct.BpX,
			BQB = @struct.Bpx,
			BQb = @struct.BpY,
			BQC = bool_2
		};
		e.Result = struct3;
		if (@struct.BpX || @struct.Bpx)
		{
			while (bool_25)
			{
				Thread.Sleep(500);
			}
		}
	}

	private void method_56(BackgroundWorker backgroundWorker_1, ref bool bool_53, ref bool bool_54, string string_41, List<int> list_9, List<int> list_10, out int int_49, out int int_50, out Dictionary<int, List<List<ushort>>> dictionary_4)
	{
		dictionary_4 = new Dictionary<int, List<List<ushort>>>();
		int_49 = int.MaxValue;
		int_50 = int.MinValue;
		BinaryWriter binaryWriter = null;
		try
		{
			if (File.Exists(string_41))
			{
				File.Delete(string_41);
			}
			binaryWriter = new BinaryWriter(File.Open(string_41, FileMode.Create, FileAccess.Write));
		}
		catch
		{
			bool_53 = false;
		}
		if (!bool_53)
		{
			return;
		}
		int num = framework_1.method_31(9497).method_256();
		int num2 = framework_1.method_31(9510).method_256();
		Enum6 enum6_ = Class1.enum6_0;
		Class1.enum6_0 = Enum6.const_3;
		int int_51 = 0;
		int num3 = 0;
		while (num3 < num)
		{
			int num4 = (int)Class1.smethod_73(framework_1.aXc, Enum10.const_12);
			if ((num3 + num4) / num2 > num3 / num2 && (num3 + num4) % num2 != 0)
			{
				num4 -= (num3 + num4) % num2;
			}
			if (num4 > num2 && num4 % num2 != 0)
			{
				num4 = num4 / num2 * num2;
			}
			num4 = Math.Min(num4, num - num3);
			if (Class1.smethod_37(framework_1.aXc, Enum10.const_12, (uint)num3, (uint)num4, out var byte_, out var _))
			{
				binaryWriter.Write(byte_);
				if (num4 <= num2)
				{
					if (num3 % num2 == 0 && method_57(0, byte_, ref int_51, list_9, list_10, ref int_49, ref int_50, dictionary_4))
					{
						if (list_9.Count == 0)
						{
							bool_54 = true;
						}
						break;
					}
				}
				else
				{
					bool flag2 = false;
					for (int i = 0; i < num4; i += num2)
					{
						if (method_57(i, byte_, ref int_51, list_9, list_10, ref int_49, ref int_50, dictionary_4))
						{
							flag2 = true;
							if (list_9.Count == 0)
							{
								bool_54 = true;
							}
							break;
						}
					}
					if (flag2)
					{
						break;
					}
				}
				num3 += num4;
				int percentProgress = (int)(100L * num3 / num);
				backgroundWorker_1.ReportProgress(percentProgress);
				continue;
			}
			bool_53 = false;
			break;
		}
		try
		{
			binaryWriter.Close();
		}
		catch
		{
			bool_53 = false;
		}
		try
		{
			if (bool_54 && File.Exists(string_41))
			{
				File.Delete(string_41);
			}
		}
		catch
		{
		}
		Class1.enum6_0 = enum6_;
	}

	private bool method_57(int int_49, byte[] byte_1, ref int int_50, List<int> list_9, List<int> list_10, ref int int_51, ref int int_52, Dictionary<int, List<List<ushort>>> dictionary_4)
	{
		if (byte_1[int_49 + 3] == byte.MaxValue)
		{
			int_50++;
			if (int_50 == 2)
			{
				return true;
			}
			return false;
		}
		int num = 3 + ((byte_1[int_49 + 3 + 1] << 24) | ((byte_1[int_49 + 3 + 2] << 16) & 0xFF0000) | ((byte_1[int_49 + 3 + 3] << 8) & 0xFF00) | (byte_1[int_49 + 3 + 4] & 0xFF));
		int num2 = (byte_1[int_49 + 3 + 57] << 24) | ((byte_1[int_49 + 3 + 58] << 16) & 0xFF0000) | ((byte_1[int_49 + 3 + 59] << 8) & 0xFF00) | (byte_1[int_49 + 3 + 60] & 0xFF);
		int item = (byte_1[int_49 + 3 + 61] << 24) | ((byte_1[int_49 + 3 + 62] << 16) & 0xFF0000) | ((byte_1[int_49 + 3 + 63] << 8) & 0xFF00) | (byte_1[int_49 + 3 + 64] & 0xFF);
		list_9.Add(num2);
		list_10.Add(item);
		int_51 = Math.Min(int_51, num2);
		int_52 = Math.Max(int_52, num2);
		if (!dictionary_4.ContainsKey(num2))
		{
			List<List<ushort>> value = Form10.smethod_34(byte_1, int_49 + num, out var _, out var _);
			dictionary_4.Add(num2, value);
		}
		return false;
	}

	private void method_58(BackgroundWorker backgroundWorker_1, string string_41, ref string string_42, List<int> list_9, List<int> list_10, int int_49, int int_50, Dictionary<int, List<List<ushort>>> dictionary_4)
	{
		Invoke(() =>
		{
			smethod_66(Class333.BdB());
		});
		try
		{
			FileStream fileStream = new FileStream(string_41, FileMode.Open);
			if (fileStream.CanRead)
			{
				backgroundWorker_1.ReportProgress(5);
				string text = Class23.smethod_10(bool_1: false) + Class333.smethod_1762() + int_49 + Class333.smethod_1763() + int_50;
				if (File.Exists(framework_1.aXD + Class333.smethod_975() + text + Class333.smethod_488()))
				{
					text = Class23.smethod_10(bool_1: true) + Class333.smethod_1762() + int_49 + Class333.smethod_1763() + int_50;
				}
				string_42 = framework_1.aXD + Class333.smethod_975() + text + Class333.smethod_1764();
				MemoryStream memoryStream = new MemoryStream();
				ZipArchive zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create);
				backgroundWorker_1.ReportProgress(10);
				Stream stream = zipArchive.CreateEntry(Class333.smethod_1765() + Class242.smethod_8(framework_1.awZ, framework_1.awz, framework_1.aXA) + Class333.smethod_146()).Open();
				string path = string_2 + Class333.smethod_522() + string_18 + Class333.smethod_1766();
				new Class297(path, framework_1, bool_0: true).method_0();
				byte[] array = File.ReadAllBytes(path);
				foreach (byte value in array)
				{
					stream.WriteByte(value);
				}
				File.Delete(path);
				stream.Close();
				backgroundWorker_1.ReportProgress(15);
				Stream stream2 = zipArchive.CreateEntry(text + Class333.smethod_489()).Open();
				method_59(dictionary_4, out var dictionary_5, out var list_11);
				List<int> list = new List<int>();
				for (int num2 = int_49; num2 <= int_50; num2++)
				{
					int num3 = list_9.IndexOf(num2);
					int num4 = list_9.LastIndexOf(num2);
					if (num3 != -1 && num4 != -1)
					{
						list.Add(num2);
					}
				}
				method_61(stream2, list);
				backgroundWorker_1.ReportProgress(20);
				Dictionary<ushort, byte[]> dictionary_6 = new Dictionary<ushort, byte[]>();
				uint uint_ = 0u;
				uint uint_2 = 0u;
				uint uint_3 = 0u;
				for (int num5 = int_49; num5 <= int_50; num5++)
				{
					int num6 = list_9.IndexOf(num5);
					int num7 = list_9.LastIndexOf(num5);
					if (num6 != -1 && num7 != -1)
					{
						int int_51 = 20 + 60 * (num5 - int_49) / (1 + int_50 - int_49);
						int int_52 = 20 + 60 * (1 + num5 - int_49) / (1 + int_50 - int_49);
						method_62(num5, fileStream, stream2, backgroundWorker_1, int_51, int_52, list_9, list_10, int_49, int_50, num6, num7, dictionary_4, dictionary_5, list_11, dictionary_6, ref uint_, ref uint_2, ref uint_3);
					}
				}
				if (stream2 != null)
				{
					stream2.Close();
					stream2 = null;
				}
				if (zipArchive != null)
				{
					zipArchive.Dispose();
					zipArchive = null;
				}
				if (memoryStream != null)
				{
					byte[] byte_ = memoryStream.ToArray();
					memoryStream.Close();
					memoryStream = null;
					GC.Collect();
					using FileStream stream_ = new FileStream(string_42, FileMode.Create);
					Class35.smethod_0(byte_, Class19.smethod_3(), stream_, Class35.byte_1);
				}
				backgroundWorker_1.ReportProgress(90);
			}
			fileStream.Close();
			if (File.Exists(string_41))
			{
				File.Delete(string_41);
			}
		}
		catch
		{
			string_42 = null;
		}
		backgroundWorker_1.ReportProgress(100);
		Thread.Sleep(100);
	}

	private void method_59(Dictionary<int, List<List<ushort>>> dictionary_4, out Dictionary<ushort, Struct28> dictionary_5, out List<List<ushort>> list_9)
	{
		List<ushort> list = method_60(dictionary_4);
		int num = 0;
		foreach (int key2 in dictionary_4.Keys)
		{
			List<List<ushort>> list2 = dictionary_4[key2];
			num = Math.Max(num, list2.Count);
		}
		list_9 = new List<List<ushort>>();
		while (list_9.Count < num)
		{
			list_9.Add(new List<ushort>());
		}
		foreach (int key3 in dictionary_4.Keys)
		{
			List<List<ushort>> list3 = dictionary_4[key3];
			for (int i = 0; i < list3.Count; i++)
			{
				foreach (ushort item in list3[i])
				{
					int num2 = -1;
					for (int j = 0; j < list_9.Count; j++)
					{
						if (list_9[j].Contains(item))
						{
							num2 = j;
							break;
						}
					}
					if (list.Contains(item))
					{
						if (num2 == -1)
						{
							list_9.Add(new List<ushort>());
							list_9[list_9.Count - 1].Add(item);
						}
					}
					else if (num2 == -1)
					{
						list_9[i].Add(item);
					}
					else if (num2 != i)
					{
						list_9.Add(new List<ushort>());
						list_9[list_9.Count - 1].Add(item);
						list_9[num2].Remove(item);
					}
				}
			}
		}
		for (int num3 = list_9.Count - 1; num3 >= 0; num3--)
		{
			if (list_9[num3].Count == 0)
			{
				list_9.RemoveAt(num3);
			}
		}
		dictionary_5 = new Dictionary<ushort, Struct28>();
		for (int k = 0; k < list_9.Count; k++)
		{
			List<ushort> list4 = list_9[k];
			for (int l = 0; l < list4.Count; l++)
			{
				Struct28 value = new Struct28
				{
					BQc = k,
					BQD = l
				};
				ushort key = list4[l];
				dictionary_5.Add(key, value);
			}
		}
	}

	private List<ushort> method_60(Dictionary<int, List<List<ushort>>> dictionary_4)
	{
		List<ushort> list = new List<ushort>();
		foreach (int key in dictionary_4.Keys)
		{
			List<List<ushort>> list2 = dictionary_4[key];
			for (int i = 0; i < list2.Count; i++)
			{
				foreach (ushort item in list2[i])
				{
					list.Add(item);
				}
			}
		}
		List<ushort> list3 = new List<ushort>();
		foreach (ushort item2 in list)
		{
			bool flag = true;
			foreach (int key2 in dictionary_4.Keys)
			{
				bool flag2 = false;
				List<List<ushort>> list4 = dictionary_4[key2];
				for (int j = 0; j < list4.Count; j++)
				{
					foreach (ushort item3 in list4[j])
					{
						if (item3 == item2)
						{
							flag2 = true;
							break;
						}
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
			if (!flag)
			{
				list3.Add(item2);
			}
		}
		return list3;
	}

	private void method_61(Stream stream_0, List<int> list_9)
	{
		stream_0.WriteByte(14);
		uint num = (uint)(5 + 4 * list_9.Count);
		stream_0.WriteByte((byte)((num >> 24) & 0xFF));
		stream_0.WriteByte((byte)((num >> 16) & 0xFF));
		stream_0.WriteByte((byte)((num >> 8) & 0xFF));
		stream_0.WriteByte((byte)(num & 0xFF));
		foreach (int item in list_9)
		{
			stream_0.WriteByte((byte)((item >> 24) & 0xFF));
			stream_0.WriteByte((byte)((item >> 16) & 0xFF));
			stream_0.WriteByte((byte)((item >> 8) & 0xFF));
			stream_0.WriteByte((byte)(item & 0xFF));
		}
	}

	private void method_62(int int_49, FileStream fileStream_0, Stream stream_0, BackgroundWorker backgroundWorker_1, int int_50, int int_51, List<int> list_9, List<int> list_10, int int_52, int int_53, int int_54, int int_55, Dictionary<int, List<List<ushort>>> dictionary_4, Dictionary<ushort, Struct28> dictionary_5, List<List<ushort>> list_11, Dictionary<ushort, byte[]> dictionary_6, ref uint uint_0, ref uint uint_1, ref uint uint_2)
	{
		int num = framework_1.method_31(9497).method_256();
		int num2 = framework_1.method_31(9510).method_256();
		int num3 = list_10[int_54];
		byte[] array;
		if (list_10[int_55] < num3)
		{
			int num4 = 0;
			int num5 = list_9.Count - 1;
			while (num5 >= 0 && (num5 == list_9.Count - 1 || list_10[num5] <= list_10[num5 + 1]) && list_9[num5] == int_49)
			{
				num4++;
				num5--;
			}
			int num6 = 0;
			for (int i = 0; i < list_9.Count && (i == 0 || list_10[i] >= list_10[i - 1]) && list_9[i] == int_49; i++)
			{
				num6++;
			}
			int num7 = num - num4 * num2;
			int num8 = num4 * num2;
			int num9 = num6 * num2;
			array = new byte[num8 + num9];
			fileStream_0.Seek(num7, SeekOrigin.Begin);
			Class23.smethod_14(fileStream_0, array, 0, num8);
			fileStream_0.Seek(0L, SeekOrigin.Begin);
			Class23.smethod_14(fileStream_0, array, num8, num9);
		}
		else
		{
			int num10 = 1 + int_55 - int_54;
			int num11 = int_54 * num2;
			int num12 = num10 * num2;
			array = new byte[num12];
			fileStream_0.Seek(num11, SeekOrigin.Begin);
			Class23.smethod_14(fileStream_0, array, 0, num12);
		}
		int percentProgress = int_50 + 20 * (int_51 - int_50) / 100;
		backgroundWorker_1.ReportProgress(percentProgress);
		uint num13 = (uint)(3 + ((array[4] << 24) | ((array[5] << 16) & 0xFF0000) | ((array[6] << 8) & 0xFF00) | (array[7] & 0xFF)));
		array[68] = (byte)framework_1.awZ;
		stream_0.Write(array, 0, (int)num13);
		bool flag = list_11.Count > 16;
		for (int j = 0; j < list_11.Count; j++)
		{
			byte value = (byte)((!flag) ? ((byte)(6 | (byte)(16 * j))) : 11);
			stream_0.WriteByte(value);
			uint num14 = (uint)((!flag) ? (5 + 2 * list_11[j].Count) : (7 + 2 * list_11[j].Count));
			stream_0.WriteByte((byte)((num14 >> 24) & 0xFF));
			stream_0.WriteByte((byte)((num14 >> 16) & 0xFF));
			stream_0.WriteByte((byte)((num14 >> 8) & 0xFF));
			stream_0.WriteByte((byte)(num14 & 0xFF));
			if (flag)
			{
				stream_0.WriteByte((byte)((j >> 8) & 0xFF));
				stream_0.WriteByte((byte)(j & 0xFF));
			}
			foreach (ushort item in list_11[j])
			{
				stream_0.WriteByte((byte)((item >> 8) & 0xFF));
				stream_0.WriteByte((byte)(item & 0xFF));
			}
		}
		Class284.smethod_0(stream_0, list_11);
		int num15 = int_50 + 30 * (int_51 - int_50) / 100;
		backgroundWorker_1.ReportProgress(num15);
		method_63(int_49, stream_0, backgroundWorker_1, num15, int_51, array, num13, dictionary_4, dictionary_5, list_11, dictionary_6, ref uint_0, ref uint_1, ref uint_2);
	}

	private void method_63(int int_49, Stream stream_0, BackgroundWorker backgroundWorker_1, int int_50, int int_51, byte[] byte_1, uint uint_0, Dictionary<int, List<List<ushort>>> dictionary_4, Dictionary<ushort, Struct28> dictionary_5, List<List<ushort>> list_9, Dictionary<ushort, byte[]> dictionary_6, ref uint uint_1, ref uint uint_2, ref uint uint_3)
	{
		uint num = uint.MaxValue;
		uint num2 = 0u;
		int num3 = 0;
		uint num4 = uint_0;
		do
		{
			byte b = byte_1[num4];
			num4++;
			if (b != byte.MaxValue)
			{
				uint num5 = (uint)((byte_1[num4] << 24) | ((byte_1[num4 + 1] << 16) & 0xFF0000) | ((byte_1[num4 + 2] << 8) & 0xFF00) | (byte_1[num4 + 3] & 0xFF));
				num4 += 4;
				if (b == 0 || num5 == uint.MaxValue || num5 == 0 || num5 > 131072)
				{
					break;
				}
				if ((b & 0xF) == 7)
				{
					uint num6 = (uint)((byte_1[num4] << 24) | ((byte_1[num4 + 1] << 16) & 0xFF0000) | ((byte_1[num4 + 2] << 8) & 0xFF00) | (byte_1[num4 + 3] & 0xFF));
					bool flag = num == uint.MaxValue;
					if (flag)
					{
						num = num6;
					}
					if (num != 0)
					{
						num6 -= num;
					}
					num2 = num6;
					if (flag && num6 < uint_1)
					{
						uint_3 = uint_2;
					}
					uint num7 = num6 + uint_3;
					uint_1 = num6;
					num4 += 4;
					int index = (b >> 4) & 0xF;
					List<ushort> list = dictionary_4[int_49][index];
					List<int> list2 = new List<int>();
					for (int i = 0; i < list.Count; i++)
					{
						ushort key = list[i];
						int bQc = dictionary_5[key].BQc;
						if (!list2.Contains(bQc))
						{
							list2.Add(bQc);
						}
						byte[] array = new byte[4];
						for (int j = 0; j < 4; j++)
						{
							array[j] = byte_1[num4 + i * 4 + j];
						}
						dictionary_6[key] = array;
					}
					list2.Sort();
					bool flag2 = list_9.Count > 16;
					int num8 = 0;
					foreach (int item in list2)
					{
						int num9 = ((!flag2) ? (9 + 4 * list_9[item].Count) : (11 + 4 * list_9[item].Count));
						num8 += num9;
					}
					byte[] array2 = new byte[num8];
					int num10 = 0;
					foreach (int item2 in list2)
					{
						if (flag2)
						{
							array2[num10] = 12;
						}
						else
						{
							array2[num10] = (byte)(7 | (byte)(16 * item2));
						}
						num10++;
						uint num11 = (uint)((!flag2) ? (9 + 4 * list_9[item2].Count) : (11 + 4 * list_9[item2].Count));
						array2[num10] = (byte)((num11 >> 24) & 0xFF);
						array2[num10 + 1] = (byte)((num11 >> 16) & 0xFF);
						array2[num10 + 2] = (byte)((num11 >> 8) & 0xFF);
						array2[num10 + 3] = (byte)(num11 & 0xFF);
						num10 += 4;
						if (flag2)
						{
							array2[num10] = (byte)((item2 >> 8) & 0xFF);
							array2[num10 + 1] = (byte)(item2 & 0xFF);
							num10 += 2;
						}
						array2[num10] = (byte)((num7 >> 24) & 0xFF);
						array2[num10 + 1] = (byte)((num7 >> 16) & 0xFF);
						array2[num10 + 2] = (byte)((num7 >> 8) & 0xFF);
						array2[num10 + 3] = (byte)(num7 & 0xFF);
						num10 += 4;
						foreach (ushort item3 in list_9[item2])
						{
							if (dictionary_6.ContainsKey(item3))
							{
								byte[] array3 = dictionary_6[item3];
								for (int k = 0; k < 4; k++)
								{
									array2[num10 + k] = array3[k];
								}
							}
							num10 += 4;
						}
					}
					stream_0.Write(array2, 0, array2.Length);
					num4 += num5 - 9;
				}
				else
				{
					num4 += num5 - 5;
				}
			}
			int num12 = int_50 + (int)(num4 * (int_51 - int_50) / byte_1.Length);
			if (num12 != num3)
			{
				backgroundWorker_1.ReportProgress(num12);
				num3 = num12;
			}
		}
		while (num4 < byte_1.Length);
		uint_2 += num2;
		backgroundWorker_1.ReportProgress(int_51);
	}

	private void method_64(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		bool_23 = false;
		string string_ = string_33;
		bool flag = bool_24;
		string_33 = null;
		bool_24 = false;
		bool_25 = false;
		if (e.Result == null)
		{
			Form54.smethod_6(this, Class333.smethod_1767(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Struct27 @struct = (Struct27)e.Result;
		if (@struct.BQC)
		{
			Form54.smethod_6(this, Class333.smethod_1752(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (@struct.Bpy)
		{
			if (@struct.BpZ != null)
			{
				bool flag2 = false;
				if (@struct.BQa)
				{
					flag2 = method_67(string_, ref @struct.BpZ, ref @struct.Bpz);
				}
				if (!flag2 && !method_66(ref @struct.BpZ, ref @struct.Bpz))
				{
					return;
				}
				if (smethod_35(framework_1))
				{
					if (@struct.BQB)
					{
						if (flag)
						{
							method_68(this, @struct.BQA, @struct.BpZ, @struct.Bpz);
						}
						else
						{
							method_65(@struct.BQA, @struct.BpZ, @struct.Bpz);
						}
					}
					else if (Form54.smethod_4(this, Class333.smethod_1768(), Class333.smethod_1769(), MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						method_68(this, @struct.BQA, @struct.BpZ, @struct.Bpz);
					}
					else
					{
						method_65(@struct.BQA, @struct.BpZ, @struct.Bpz);
					}
				}
				else
				{
					method_65(@struct.BQA, @struct.BpZ, @struct.Bpz);
				}
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1770(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_1767(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_65(Enum55 enum55_0, string string_41, string string_42)
	{
		switch (enum55_0)
		{
		case Enum55.const_1:
			method_160(string_41, bool_53: false);
			break;
		case Enum55.const_2:
			if (string_42 != null)
			{
				string path = Form10.smethod_2();
				if (File.Exists(path))
				{
					if (File.Exists(string_42))
					{
						Form10.smethod_7(path, string_42);
					}
				}
				else
				{
					Form54.smethod_6(this, Class333.smethod_1771(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1772(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			break;
		}
	}

	private bool method_66(ref string string_41, ref string string_42)
	{
		try
		{
			if (string_41 != null && File.Exists(string_41))
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Title = Class333.smethod_1756();
				saveFileDialog.Filter = Class333.smethod_1757();
				saveFileDialog.InitialDirectory = Path.GetDirectoryName(string_41);
				saveFileDialog.FileName = Path.GetFileName(string_41.Substring(0, string_41.Length - Class333.smethod_1764().Length));
				bool flag = false;
				if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
				{
					string text = saveFileDialog.FileName;
					if (!text.EndsWith(Class333.smethod_488()))
					{
						text += Class333.smethod_488();
					}
					File.Move(string_41, text);
					string_41 = text;
				}
				else
				{
					string text2 = string_41.Substring(0, string_41.Length - Class333.smethod_1764().Length) + Class333.smethod_488();
					File.Move(string_41, text2);
					string_41 = text2;
					flag = true;
				}
				if (string_42 != null && File.Exists(string_42))
				{
					string text3 = Path.GetDirectoryName(string_41);
					if (!text3.EndsWith(Class333.smethod_177()) && !text3.EndsWith(Class333.smethod_176()))
					{
						text3 += Class333.smethod_176();
					}
					string text4 = text3 + Path.GetFileNameWithoutExtension(string_41) + Class333.smethod_919();
					File.Move(string_42, text4);
					string_42 = text4;
				}
				saveFileDialog.Dispose();
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

	private bool method_67(string string_41, ref string string_42, ref string string_43)
	{
		try
		{
			if (!string.IsNullOrEmpty(string_41) && string_42 != null && File.Exists(string_42))
			{
				if (!string_41.EndsWith(Class333.smethod_488()))
				{
					string_41 += Class333.smethod_488();
				}
				File.Move(string_42, string_41);
				string_42 = string_41;
				if (string_43 != null && File.Exists(string_43))
				{
					string text = Path.GetDirectoryName(string_42);
					if (!text.EndsWith(Class333.smethod_177()) && !text.EndsWith(Class333.smethod_176()))
					{
						text += Class333.smethod_176();
					}
					string text2 = text + Path.GetFileNameWithoutExtension(string_42) + Class333.smethod_919();
					File.Move(string_43, text2);
					string_43 = text2;
				}
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	internal static bool smethod_35(Framework framework_2)
	{
		if (framework_2 != null)
		{
			if (Class242.smethod_12(framework_2.awZ))
			{
				return framework_2.aXA >= new Class14(3, 3, 0, 101, 0);
			}
			if (framework_2.awZ == 20)
			{
				return framework_2.aXA >= new Class14(1, 16, 0, 101, 0);
			}
			return true;
		}
		return false;
	}

	internal bool method_68(Form form_0, Enum55 enum55_0, string string_41, string string_42)
	{
		if (!smethod_35(framework_1))
		{
			Form54.smethod_6(form_0, Class333.smethod_1773(), Class333.smethod_1774(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return false;
		}
		if (framework_1 != null)
		{
			if (framework_1.method_31(9500).method_256() == 0)
			{
				Class214 @class = new Class214();
				@class.BQd = enum55_0;
				@class.BQE = string_41;
				@class.BQe = string_42;
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.WorkerSupportsCancellation = false;
				backgroundWorker.WorkerReportsProgress = form_0 is Form23;
				backgroundWorker.DoWork += method_69;
				backgroundWorker.RunWorkerCompleted += method_70;
				if (backgroundWorker.WorkerReportsProgress)
				{
					backgroundWorker.ProgressChanged += smethod_69;
					smethod_66(Class333.smethod_1775());
				}
				backgroundWorker.RunWorkerAsync(@class);
				return true;
			}
			Form54.smethod_6(form_0, Class333.smethod_949(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			if (enum55_0 != Enum55.const_0)
			{
				method_65(enum55_0, string_41, string_42);
			}
			return false;
		}
		return true;
	}

	private void method_69(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		if (backgroundWorker.WorkerReportsProgress)
		{
			backgroundWorker.ReportProgress(0);
			Thread.Sleep(100);
		}
		Class1.smethod_59(framework_1.aXc, out var _);
		if (backgroundWorker.WorkerReportsProgress)
		{
			backgroundWorker.ReportProgress(100);
			Thread.Sleep(500);
		}
		Class214 result = e.Argument as Class214;
		e.Result = result;
	}

	private void method_70(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		Class214 @class = e.Result as Class214;
		if (@class.BQd != Enum55.const_0)
		{
			method_65(@class.BQd, @class.BQE, @class.BQe);
		}
	}

	private void method_71()
	{
		if (timer_2 == null)
		{
			timer_2 = new System.Timers.Timer();
			timer_2.Interval = 500.0;
			timer_2.SynchronizingObject = this;
			timer_2.Elapsed += method_74;
			timer_2.AutoReset = true;
			timer_2.Enabled = false;
		}
	}

	private void method_72()
	{
		bool_27 = true;
		if (timer_2 != null && !timer_2.Enabled)
		{
			timer_2.Enabled = true;
			timer_2.Start();
		}
	}

	private void method_73()
	{
		if (timer_2 != null && timer_2.Enabled)
		{
			timer_2.Stop();
			timer_2.Enabled = false;
		}
		bool_27 = true;
	}

	private void method_74(object sender, ElapsedEventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate110 method = method_74;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if ((int_0 & 1) != 0 && list_2.Count == 1)
		{
			if (framework_1 != null && framework_1.aWW.IsValid)
			{
				class164_0.Visible = true;
				list_3.Clear();
				int num = 17;
				int statusArrayDataId = framework_1.aWW.StatusArrayDataId;
				Setting setting = framework_1.method_31(statusArrayDataId);
				if (setting == null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(71, 1);
					defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_1776());
					defaultInterpolatedStringHandler.AppendFormatted(statusArrayDataId);
					throw new ArgumentNullException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				int modeArrayDataId = framework_1.aWW.ModeArrayDataId;
				Setting setting2 = framework_1.method_31(modeArrayDataId);
				if (setting2 == null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(69, 1);
					defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_1777());
					defaultInterpolatedStringHandler.AppendFormatted(modeArrayDataId);
					throw new ArgumentNullException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				byte[] array = setting.method_259();
				byte[] array2 = setting2.method_259();
				int_5 = 0;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != 0)
					{
						int num2 = framework_1.aWW.ErrorToSettingMap[i];
						if (array2[num2] > 0 && framework_1.aWW.ErrorIndexToCodeMap.ContainsKey(i))
						{
							string key = framework_1.aWW.ErrorIndexToCodeMap[i];
							string text = framework_1.aWW.ErrorDefs[key][Class333.smethod_91()];
							Class223 @class = new Class223();
							@class.method_1(key);
							@class.method_3(text);
							@class.method_5((Enum64)array[i]);
							Class223 class2 = @class;
							num = num * 23 + (class2?.GetHashCode() ?? 0);
							list_3.Add(class2);
						}
						else
						{
							int_5++;
						}
					}
				}
				if (list_3.Count > 0 && num != int_4)
				{
					int_4 = num;
					smethod_36();
				}
				else if (list_3.Count == 0 && int_4 != 0)
				{
					int_4 = 0;
					smethod_36();
				}
				return;
			}
			Class5 bpS = list_2[0].BpS;
			if (bpS.struct1_0[36].uint_1 != 0)
			{
				class164_0.Visible = true;
			}
			if (framework_1 == null || !framework_1.method_5() || (!bool_27 && class131_2.Controls.Count != 0))
			{
				return;
			}
			if (bpS.struct1_0[36].uint_1 != 0)
			{
				smethod_36();
			}
			else
			{
				class164_0.Visible = false;
				if (class131_2.Visible)
				{
					class131_2.Visible = false;
					method_118();
					smethod_73();
				}
			}
			bool_27 = false;
		}
		else
		{
			int_4 = 0;
			class164_0.Visible = false;
			if (class131_2.Visible)
			{
				class131_2.Visible = false;
				method_118();
				smethod_73();
			}
		}
	}

	private void method_75()
	{
		if (list_2.Count != 1)
		{
			return;
		}
		Class5 bpS = list_2[0].BpS;
		if (bpS.struct1_0[36].uint_1 == 0 || (int_0 & 0x100) != 0 || (int_0 & 0x200) != 0 || !Class1.smethod_37(bpS.string_0, Enum10.const_8, 0u, (uint)(ushort_0.Length * 2), out var byte_, out var _))
		{
			return;
		}
		for (int i = 0; i < byte_.Length; i += 2)
		{
			ushort num = (ushort)((byte_[i] << 8) | (byte_[i + 1] & 0xFF));
			if (ushort_0[i >> 1] != num)
			{
				ushort_0[i >> 1] = num;
				bool_27 = true;
			}
		}
	}

	private static void smethod_36()
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		foreach (Control control in form23_0.class131_2.Controls)
		{
			if (control is Button)
			{
				(control as Button).Click -= smethod_48;
				(control as Button).Click -= smethod_49;
			}
		}
		int y = form23_0.class131_2.AutoScrollPosition.Y;
		while (form23_0.class131_2.Controls.Count != 0)
		{
			Class30.smethod_0(form23_0.class131_2.Controls[0]);
		}
		form23_0.class131_2.SuspendLayout();
		int int_ = 0;
		int num = 0;
		ThemedButton themedButton = new ThemedButton();
		themedButton.Width = form23_0.class131_2.Width - 21;
		themedButton.Text = Class333.smethod_1778();
		themedButton.Top = 0;
		themedButton.Click += smethod_48;
		form23_0.class131_2.Controls.Add(themedButton);
		num = themedButton.Bottom + 5;
		ThemedButton themedButton2 = new ThemedButton();
		themedButton2.Width = form23_0.class131_2.Width - 21;
		themedButton2.Text = Class333.smethod_1779();
		themedButton2.Top = num;
		themedButton2.Click += smethod_49;
		form23_0.class131_2.Controls.Add(themedButton2);
		num = themedButton2.Bottom + 5;
		if (framework_1 != null && framework_1.aWW.IsValid)
		{
			if (int_5 > 0)
			{
				Label label = new Label();
				label.MaximumSize = new Size(form23_0.class131_2.Width - 21, form23_0.class131_2.Height - 2);
				label.AutoSize = true;
				label.Font = new Font(Control.DefaultFont.FontFamily, 8f, FontStyle.Italic);
				label.Top = num;
				if (int_5 == 1)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
					defaultInterpolatedStringHandler.AppendFormatted(int_5);
					defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_1780());
					label.Text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
					defaultInterpolatedStringHandler.AppendFormatted(int_5);
					defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_1781());
					label.Text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				label.ForeColor = color_36;
				form23_0.class131_2.Controls.Add(label);
				num = label.Bottom + 5;
			}
			List<Class223> list = list_3.Where((Class223 class223_0) => class223_0.method_4() == Enum64.const_2).ToList();
			foreach (Class223 item in list)
			{
				smethod_41(item.method_0(), item.method_2(), item.method_4(), ref int_, ref num);
			}
			if (list.Count > 0)
			{
				num += 10;
			}
			foreach (Class223 item2 in list_3.Where((Class223 class223_0) => class223_0.method_4() == Enum64.const_1).ToList())
			{
				smethod_41(item2.method_0(), item2.method_2(), item2.method_4(), ref int_, ref num);
			}
		}
		else
		{
			for (int num2 = ushort_0.Length / 2; num2 < ushort_0.Length; num2++)
			{
				ushort num3 = ushort_0[num2];
				if (num3 != ushort.MaxValue)
				{
					smethod_40(num3, bool_53: true, ref int_, ref num);
				}
			}
			num += 10;
			for (int num4 = 0; num4 < ushort_0.Length / 2; num4++)
			{
				ushort num5 = ushort_0[num4];
				if (num5 == ushort.MaxValue)
				{
					continue;
				}
				bool flag = false;
				for (int num6 = ushort_0.Length / 2; num6 < ushort_0.Length; num6++)
				{
					if (ushort_0[num6] == num5)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					smethod_40(num5, bool_53: false, ref int_, ref num);
				}
			}
		}
		if (int_ == 0)
		{
			Label label2 = new Label();
			label2.AutoSize = true;
			label2.Top = num;
			label2.Text = Class333.smethod_1782();
			label2.ForeColor = color_12;
			form23_0.class131_2.Controls.Add(label2);
			form23_0.class164_0.method_2();
		}
		else
		{
			form23_0.class164_0.method_3();
		}
		form23_0.class131_2.ResumeLayout(performLayout: true);
		form23_0.class131_2.AutoScrollPosition = new Point(0, -y);
		form23_0.class164_0.Tag = int_;
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.smethod_1783(), stopwatch.ElapsedMilliseconds), bool_1: false);
	}

	internal static string smethod_37(ushort ushort_1)
	{
		string result = string.Empty;
		switch ((ushort_1 >> 14) & 3)
		{
		case 0:
			result = string.Format(Class333.smethod_1784(), ushort_1 & 0x3FFF);
			break;
		case 1:
			result = string.Format(Class333.smethod_1785(), ushort_1 & 0x3FFF);
			break;
		case 2:
			result = string.Format(Class333.smethod_1786(), ushort_1 & 0x3FFF);
			break;
		case 3:
			result = string.Format(Class333.smethod_1787(), ushort_1 & 0x3FFF);
			break;
		}
		return result;
	}

	internal static bool smethod_38(string string_41)
	{
		if (framework_1 != null && framework_1.aWW.IsValid)
		{
			foreach (Class223 item in list_3.Where((Class223 class223_0) => class223_0.method_4() == Enum64.const_2).ToList())
			{
				if (item.method_0() == string_41)
				{
					return true;
				}
			}
		}
		else
		{
			for (int num = ushort_0.Length / 2; num < ushort_0.Length; num++)
			{
				ushort num2 = ushort_0[num];
				if (num2 != ushort.MaxValue && smethod_37(num2) == string_41)
				{
					return true;
				}
			}
		}
		return false;
	}

	internal static bool smethod_39(string string_41)
	{
		if (framework_1 != null && framework_1.aWW.IsValid)
		{
			foreach (Class223 item in list_3.Where((Class223 class223_0) => class223_0.method_4() == Enum64.const_1).ToList())
			{
				if (item.method_0() == string_41)
				{
					return true;
				}
			}
		}
		else
		{
			for (int num = 0; num < ushort_0.Length / 2; num++)
			{
				ushort num2 = ushort_0[num];
				if (num2 != ushort.MaxValue && smethod_37(num2) == string_41)
				{
					return true;
				}
			}
		}
		return false;
	}

	private static void smethod_40(ushort ushort_1, bool bool_53, ref int int_49, ref int int_50)
	{
		string text = smethod_37(ushort_1);
		if (framework_1.aWv.ContainsKey(text))
		{
			Class254 @class = framework_1.aWv[text];
			Label label = new Label();
			label.MaximumSize = new Size(form23_0.class131_2.Width - 21, form23_0.class131_2.Height - 2);
			label.AutoSize = true;
			label.Font = new Font(label.Font.FontFamily, 8f, FontStyle.Bold);
			label.Top = int_50;
			if (bool_53)
			{
				label.Text = Class333.smethod_1788() + text + Class333.smethod_1789();
			}
			else
			{
				label.Text = Class333.smethod_1788() + text + Class333.smethod_1790();
			}
			label.ForeColor = color_7;
			form23_0.class131_2.Controls.Add(label);
			int_50 = label.Bottom;
			Label label2 = new Label();
			label2.MaximumSize = new Size(form23_0.class131_2.Width - 21, form23_0.class131_2.Height - 2);
			label2.AutoSize = true;
			label2.Font = new Font(label2.Font.FontFamily, 7.8f);
			label2.Top = int_50;
			label2.Text = @class.method_60(Enum96.aYU);
			label2.ForeColor = label.ForeColor;
			form23_0.class131_2.Controls.Add(label2);
			int_50 = label2.Bottom;
			int_49++;
		}
	}

	private static void smethod_41(string string_41, string string_42, Enum64 enum64_0, ref int int_49, ref int int_50)
	{
		Label label = new Label();
		label.MaximumSize = new Size(form23_0.class131_2.Width - 21, form23_0.class131_2.Height - 2);
		label.AutoSize = true;
		label.Font = new Font(Control.DefaultFont.FontFamily, 8f, FontStyle.Bold);
		label.Top = int_50;
		switch (enum64_0)
		{
		case Enum64.const_2:
			label.Text = Class333.smethod_1788() + string_41 + Class333.smethod_1789();
			break;
		case Enum64.const_1:
			label.Text = Class333.smethod_1788() + string_41 + Class333.smethod_1790();
			break;
		}
		label.ForeColor = color_7;
		form23_0.class131_2.Controls.Add(label);
		int_50 = label.Bottom;
		Label label2 = new Label();
		label2.MaximumSize = new Size(form23_0.class131_2.Width - 21, form23_0.class131_2.Height - 2);
		label2.AutoSize = true;
		label2.Font = new Font(Control.DefaultFont.FontFamily, 7.8f);
		label2.Top = int_50;
		label2.Text = string_42;
		label2.ForeColor = label.ForeColor;
		form23_0.class131_2.Controls.Add(label2);
		int_50 = label2.Bottom + 5;
		int_49++;
	}

	private static void smethod_42()
	{
		form23_0.class165_0.method_2();
		form23_0.class170_0.method_2();
		form23_0.class164_0.method_2();
		form23_0.class165_0.Tag = 0;
		form23_0.class165_0.Invalidate();
		form23_0.class170_0.Tag = 0;
		form23_0.class170_0.Invalidate();
		form23_0.class164_0.Tag = 0;
		form23_0.class164_0.Invalidate();
	}

	internal static void smethod_43()
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		hashSet_1.Clear();
		hashSet_2.Clear();
		foreach (Control control3 in form23_0.class131_0.Controls)
		{
			if (control3 is Button)
			{
				(control3 as Button).Click -= smethod_48;
			}
			else if (control3 is LinkLabel)
			{
				(control3 as LinkLabel).Click -= smethod_47;
			}
		}
		int y = form23_0.class131_0.AutoScrollPosition.Y;
		while (form23_0.class131_0.Controls.Count != 0)
		{
			Class30.smethod_0(form23_0.class131_0.Controls[0]);
		}
		form23_0.class131_0.SuspendLayout();
		int int_ = 0;
		smethod_44(framework_1.aWS, bool_53: true, ref int_, bool_54: false);
		if (int_ == 0)
		{
			Label label = new Label();
			label.AutoSize = true;
			label.Top = 30;
			label.Text = Class333.smethod_1791();
			label.ForeColor = color_12;
			form23_0.class131_0.Controls.Add(label);
		}
		form23_0.class131_0.ResumeLayout(performLayout: true);
		form23_0.class131_0.AutoScrollPosition = new Point(0, -y);
		foreach (Control control4 in form23_0.class131_1.Controls)
		{
			if (control4 is Button)
			{
				(control4 as Button).Click -= smethod_48;
			}
			else if (control4 is LinkLabel)
			{
				(control4 as LinkLabel).Click -= smethod_47;
			}
		}
		int y2 = form23_0.class131_1.AutoScrollPosition.Y;
		while (form23_0.class131_1.Controls.Count != 0)
		{
			Class30.smethod_0(form23_0.class131_1.Controls[0]);
		}
		form23_0.class131_1.SuspendLayout();
		int int_2 = 0;
		smethod_44(framework_1.aWS, bool_53: true, ref int_2, bool_54: true);
		if (int_2 == 0)
		{
			Label label2 = new Label();
			label2.AutoSize = true;
			label2.Top = 30;
			label2.Text = Class333.smethod_1792();
			label2.ForeColor = color_12;
			form23_0.class131_1.Controls.Add(label2);
		}
		form23_0.class131_1.ResumeLayout(performLayout: true);
		form23_0.class131_1.AutoScrollPosition = new Point(0, -y2);
		if (int_ == 0)
		{
			form23_0.class165_0.method_2();
		}
		else
		{
			form23_0.class165_0.method_3((int_ > Form23.int_2 && Form23.int_2 != -1) || (int_ != 0 && Form23.int_2 == -1));
		}
		if (int_2 == 0)
		{
			form23_0.class170_0.method_2();
		}
		else
		{
			form23_0.class170_0.method_3((int_2 > int_3 && int_3 != -1) || (int_2 != 0 && int_3 == -1));
		}
		Form23.int_2 = int_;
		int_3 = int_2;
		form23_0.class165_0.Tag = int_;
		form23_0.class165_0.Invalidate();
		form23_0.class170_0.Tag = int_2;
		form23_0.class170_0.Invalidate();
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.smethod_1793(), stopwatch.ElapsedMilliseconds), bool_1: false);
	}

	private static void smethod_44(List<SettingOrSpecialObject> list_9, bool bool_53, ref int int_49, bool bool_54)
	{
		Panel panel = ((!bool_54) ? form23_0.class131_0 : form23_0.class131_1);
		int int_50 = 0;
		if (bool_53)
		{
			int_49 = 0;
			ThemedButton themedButton = new ThemedButton();
			themedButton.Width = panel.Width - 21;
			if (bool_54)
			{
				themedButton.Text = Class333.smethod_1794();
			}
			else
			{
				themedButton.Text = Class333.smethod_1795();
			}
			themedButton.Top = int_50;
			themedButton.Click += smethod_48;
			panel.Controls.Add(themedButton);
			int_50 = themedButton.Bottom + 5;
			if (bool_54 && !framework_1.aXA.method_7())
			{
				smethod_45(ref int_49, ref int_50);
			}
		}
		else if (panel.Controls.Count != 0)
		{
			int_50 = panel.Controls[panel.Controls.Count - 1].Bottom;
		}
		for (int i = 0; i < list_9.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = list_9[i];
			if (settingOrSpecialObject is Setting setting_)
			{
				smethod_46(setting_, panel, ref int_49, ref int_50);
			}
			smethod_44(settingOrSpecialObject.method_1(), bool_53: false, ref int_49, bool_54);
		}
	}

	private static void smethod_45(ref int int_49, ref int int_50)
	{
		Label label = new Label();
		label.AutoSize = true;
		label.Font = new Font(label.Font.FontFamily, 8f, FontStyle.Bold);
		label.Top = int_50;
		label.Text = Class333.smethod_1796();
		label.ForeColor = Color.Orange;
		form23_0.class131_1.Controls.Add(label);
		int_50 = label.Bottom;
		Label label2 = new Label();
		label2.AutoSize = true;
		label2.MinimumSize = new Size(0, 0);
		label2.MaximumSize = new Size(form23_0.class131_1.Width - 21, form23_0.class131_1.Height - 2);
		label2.Font = new Font(label2.Font.FontFamily, 7.8f);
		label2.Top = int_50;
		label2.Text = Class333.smethod_1797() + framework_1.aXA.method_6() + Class333.smethod_1798();
		label2.ForeColor = Color.Orange;
		form23_0.class131_1.Controls.Add(label2);
		int_50 = label2.Bottom;
		int_49++;
	}

	private static void smethod_46(Setting setting_0, Panel panel_3, ref int int_49, ref int int_50)
	{
		bool flag;
		if (flag = !setting_0.method_122())
		{
			flag = false;
			for (int i = 0; i < setting_0.method_123().Count; i++)
			{
				if (!string.IsNullOrEmpty(setting_0.method_123()[i]))
				{
					flag = true;
					break;
				}
			}
		}
		bool flag2 = panel_0 != null && panel_3 == panel_0;
		if (!flag)
		{
			return;
		}
		string text = setting_0.method_61();
		if (setting_0.method_68() && setting_0.method_6() is Setting)
		{
			text = (setting_0.method_6() as Setting).method_61() + Class333.smethod_536() + text;
		}
		if (!flag2 && panel_3.Controls.Count != 0)
		{
			int_50 = panel_3.Controls[panel_3.Controls.Count - 1].Bottom + 20;
		}
		string text2 = string.Empty;
		if (setting_0.method_123().Count > 1)
		{
			text2 = Class333.smethod_1799();
		}
		Label label = new Label();
		if (flag2)
		{
			label.AutoSize = true;
			label.MinimumSize = new Size(600, 0);
			label.MaximumSize = new Size(600, 100);
		}
		else
		{
			label.AutoSize = true;
			label.MinimumSize = new Size(0, 0);
			label.MaximumSize = new Size(panel_3.Width - 21, panel_3.Height - 2);
		}
		label.Font = new Font(label.Font.FontFamily, 8f, FontStyle.Bold);
		label.Top = int_50;
		switch (setting_0.method_124())
		{
		default:
			label.Text = Class333.smethod_1800() + text2 + Class333.smethod_1801() + text + Class333.smethod_1802();
			label.ForeColor = color_7;
			if (flag2 || panel_3 == form23_0.class131_0)
			{
				panel_3.Controls.Add(label);
			}
			break;
		case IllegalitySeverityLevel.Error:
			label.Text = Class333.smethod_1800() + text2 + Class333.smethod_1801() + text + Class333.smethod_1802();
			label.ForeColor = color_7;
			if (flag2 || panel_3 == form23_0.class131_0)
			{
				panel_3.Controls.Add(label);
			}
			break;
		case IllegalitySeverityLevel.Warning:
			label.Text = Class333.smethod_1803() + text2 + Class333.smethod_1801() + text + Class333.smethod_1802();
			label.ForeColor = Color.Orange;
			if (flag2 || panel_3 == form23_0.class131_1)
			{
				panel_3.Controls.Add(label);
			}
			break;
		case IllegalitySeverityLevel.ErrorIfOnline:
			if ((int_0 & 1) != 0)
			{
				label.Text = Class333.smethod_1800() + text2 + Class333.smethod_1801() + text + Class333.smethod_1802();
				label.ForeColor = color_7;
				if (flag2 || panel_3 == form23_0.class131_0)
				{
					panel_3.Controls.Add(label);
				}
			}
			else
			{
				label.Text = Class333.smethod_1803() + text2 + Class333.smethod_1801() + text + Class333.smethod_1802();
				label.ForeColor = Color.Orange;
				if (flag2 || panel_3 == form23_0.class131_1)
				{
					panel_3.Controls.Add(label);
				}
			}
			break;
		}
		int_50 = label.Bottom;
		if (!flag2 && (!label.Text.StartsWith(Class333.smethod_1800()) || panel_3 != form23_0.class131_0) && (!label.Text.StartsWith(Class333.smethod_1803()) || panel_3 != form23_0.class131_1))
		{
			return;
		}
		if (panel_3 == form23_0.class131_0)
		{
			hashSet_1.Add(setting_0.method_69());
		}
		else if (panel_3 == form23_0.class131_1)
		{
			hashSet_2.Add(setting_0.method_69());
		}
		for (int j = 0; j < setting_0.method_123().Count; j++)
		{
			string text3 = setting_0.method_123()[j];
			if (string.IsNullOrEmpty(text3))
			{
				continue;
			}
			int_49++;
			Label label2 = new Label();
			if (flag2)
			{
				label2.AutoSize = true;
				label2.MinimumSize = new Size(600, 0);
				label2.MaximumSize = new Size(600, 600);
			}
			else
			{
				label2.AutoSize = true;
				label2.MinimumSize = new Size(0, 0);
				label2.MaximumSize = new Size(panel_3.Width - 21, panel_3.Height - 2);
			}
			label2.Font = new Font(label2.Font.FontFamily, 7.8f);
			label2.Top = int_50;
			label2.Text = Class333.smethod_292() + text3;
			label2.ForeColor = label.ForeColor;
			panel_3.Controls.Add(label2);
			int_50 = label2.Bottom;
			TreeNode treeNode = new TreeNode();
			bool flag3 = false;
			if (setting_0.method_126().Count != 0 && j < setting_0.method_126().Count && setting_0.method_126()[j].Count != 0)
			{
				int_50++;
				List<TreeNode> list = new List<TreeNode>();
				foreach (int item in setting_0.method_126()[j])
				{
					LinkLabel linkLabel = null;
					TreeNode treeNode2 = form23_0.control4_0.method_63(form23_0.control4_0.method_0().method_2(), new DataIdAndAttrId(item), bool_7: false);
					if (treeNode2 == null)
					{
						Setting setting = framework_1.method_31(item);
						if (framework_1.aWZ.Contains(setting.method_64()))
						{
							if (!setting.method_219() && setting.method_256() != 1)
							{
								TreeNode treeNode3 = new TreeNode();
								treeNode3.Tag = setting;
								linkLabel = new LinkLabel();
								linkLabel.LinkColor = color_13;
								linkLabel.Tag = treeNode3;
								string text4 = null;
								linkLabel.Text = string.Concat(str1: (setting.method_6() == null || string.IsNullOrEmpty(setting.method_6().method_60(Enum96.aYt))) ? setting.method_60(Enum96.aYt) : setting.method_6().method_60(Enum96.aYt), str0: Class333.smethod_1804(), str2: Class333.smethod_180());
							}
						}
						else if (!list.Contains(treeNode) && form23_0.control25_0.method_33() == null)
						{
							list.Add(treeNode);
							linkLabel = new LinkLabel();
							linkLabel.LinkColor = color_13;
							linkLabel.Tag = treeNode;
							linkLabel.Text = Class333.smethod_1805();
						}
					}
					else if (!list.Contains(treeNode2) && treeNode2 != form23_0.control4_0.method_0().method_3())
					{
						list.Add(treeNode2);
						linkLabel = new LinkLabel();
						linkLabel.LinkColor = color_13;
						linkLabel.Tag = treeNode2;
						linkLabel.Text = Class333.smethod_1806() + form23_0.control4_0.method_47(treeNode2, bool_7: false, bool_8: false) + Class333.smethod_180();
					}
					if (linkLabel != null)
					{
						if (flag2)
						{
							linkLabel.AutoSize = true;
							linkLabel.MinimumSize = new Size(600, 0);
							linkLabel.MaximumSize = new Size(600, 600);
						}
						else
						{
							linkLabel.AutoSize = true;
							linkLabel.MinimumSize = new Size(0, 0);
							linkLabel.MaximumSize = new Size(panel_3.Width - 21, panel_3.Height - 2);
						}
						linkLabel.Top = int_50;
						linkLabel.Click += smethod_47;
						panel_3.Controls.Add(linkLabel);
						int_50 = linkLabel.Bottom;
						flag3 = true;
					}
				}
				int_50 += 5;
			}
			if (flag3)
			{
				continue;
			}
			TreeNode treeNode4 = form23_0.control4_0.method_63(form23_0.control4_0.method_0().method_2(), setting_0.method_69(), bool_7: false);
			if (treeNode4 == null || (treeNode4 == form23_0.control4_0.method_0().method_3() && !(form23_0.control4_0.method_0().method_3().Text == Class333.smethod_1807())))
			{
				continue;
			}
			LinkLabel linkLabel2 = new LinkLabel();
			linkLabel2.LinkColor = color_13;
			linkLabel2.Tag = treeNode4;
			if (flag2)
			{
				linkLabel2.AutoSize = true;
				linkLabel2.MinimumSize = new Size(600, 0);
				linkLabel2.MaximumSize = new Size(600, 600);
			}
			else
			{
				linkLabel2.AutoSize = true;
				linkLabel2.MinimumSize = new Size(0, 0);
				linkLabel2.MaximumSize = new Size(panel_3.Width - 21, panel_3.Height - 2);
			}
			if (treeNode4.Text == Class333.smethod_1807())
			{
				string text5 = string.Empty;
				if (setting_0.method_68() && setting_0.method_6() is Setting)
				{
					Setting setting2 = setting_0.method_6() as Setting;
					text5 = Class333.smethod_536() + setting2.method_61();
				}
				linkLabel2.Text = Class333.smethod_1806() + form23_0.control4_0.method_47(treeNode4, bool_7: false, bool_8: false) + text5 + Class333.smethod_180();
			}
			else
			{
				linkLabel2.Text = Class333.smethod_1806() + form23_0.control4_0.method_47(treeNode4, bool_7: false, bool_8: false) + Class333.smethod_180();
			}
			linkLabel2.Top = int_50;
			linkLabel2.Click += smethod_47;
			panel_3.Controls.Add(linkLabel2);
			int_50 = linkLabel2.Bottom;
		}
	}

	private static void smethod_47(object sender, EventArgs e)
	{
		if ((sender as LinkLabel).Tag != null)
		{
			if (((sender as LinkLabel).Tag as TreeNode).Tag != null)
			{
				if (((sender as LinkLabel).Tag as TreeNode).Tag is Setting)
				{
					Setting setting = ((sender as LinkLabel).Tag as TreeNode).Tag as Setting;
					if (!setting.method_0().method_4())
					{
						return;
					}
					Setting setting_ = null;
					MenuNode menuNode = null;
					string text = setting.method_47();
					if (text == null)
					{
						if (setting.method_6() != null && setting.method_6().method_45() != null)
						{
							text = setting.method_6().method_45().method_64();
							if (text != null)
							{
								menuNode = setting.method_6().method_45();
							}
							else if (setting.method_152() != null)
							{
								text = setting.method_152().method_64();
								if (text != null)
								{
									menuNode = setting.method_152();
								}
							}
						}
					}
					else
					{
						setting_ = setting;
					}
					Class280 @class = smethod_95();
					if (text != null && !Form13.smethod_0(setting_, menuNode))
					{
						Form13 form = new Form13(text, setting_, menuNode);
						if (form.ShowDialog(form23_0) != DialogResult.OK)
						{
							form.Dispose();
							return;
						}
						form.Dispose();
						@class?.method_3(setting.method_69());
						setting.method_272(1, bool_0: true);
					}
					else
					{
						@class?.method_3(setting.method_69());
						setting.method_272(1, bool_0: true);
					}
					if (setting.method_6() != null)
					{
						PortFunction.smethod_20(setting.method_6(), bool_0: false);
					}
					@class?.method_4();
					smethod_75(setting.method_69());
					return;
				}
				TreeNode treeNode = (sender as LinkLabel).Tag as TreeNode;
				if ((sender as LinkLabel).Text.Contains(Class333.smethod_1808()))
				{
					if (treeNode.Tag is MenuNode menuNode2)
					{
						menuNode2.method_49((sender as LinkLabel).Text.Replace(Class333.smethod_1809(), Class333.smethod_102()).Replace(Class333.smethod_180(), Class333.smethod_102()));
					}
					form23_0.control4_0.method_0().method_4(null);
				}
				form23_0.control4_0.method_0().method_4(treeNode);
			}
			else
			{
				form23_0.control4_0.method_68(bool_7: true);
			}
		}
		else
		{
			form23_0.control4_0.method_68(bool_7: true);
		}
	}

	private static void smethod_48(object sender, EventArgs e)
	{
		form23_0.class131_0.Visible = false;
		form23_0.class131_1.Visible = false;
		form23_0.class131_2.Visible = false;
		form23_0.method_118();
		smethod_73();
	}

	internal static void smethod_49(object sender, EventArgs e)
	{
		if ((int_0 & 1) != 0)
		{
			if (framework_1.aWW.IsValid)
			{
				int statusArrayDataId = framework_1.aWW.StatusArrayDataId;
				framework_1.method_31(statusArrayDataId)?.method_279(bool_0: true);
			}
			Class1.smethod_57(framework_1.aXc, out var _);
		}
	}

	private void class165_0_Click(object sender, EventArgs e)
	{
		class131_0.Visible = !class131_0.Visible;
		if (class131_3.Visible)
		{
			float_0 = (float)splitContainer_0.SplitterDistance / (float)splitContainer_0.Width;
		}
		class131_1.Visible = false;
		class131_2.Visible = false;
		class131_3.Visible = false;
		method_88();
		method_118();
		smethod_73();
	}

	private void class170_0_Click(object sender, EventArgs e)
	{
		class131_1.Visible = !class131_1.Visible;
		if (class131_3.Visible)
		{
			float_0 = (float)splitContainer_0.SplitterDistance / (float)splitContainer_0.Width;
		}
		class131_0.Visible = false;
		class131_2.Visible = false;
		class131_3.Visible = false;
		method_88();
		method_118();
		smethod_73();
	}

	private void class164_0_Click(object sender, EventArgs e)
	{
		class131_2.Visible = !class131_2.Visible;
		if (class131_3.Visible)
		{
			float_0 = (float)splitContainer_0.SplitterDistance / (float)splitContainer_0.Width;
		}
		class131_0.Visible = false;
		class131_1.Visible = false;
		class131_3.Visible = false;
		method_88();
		method_118();
		smethod_73();
	}

	internal static void smethod_50(Setting setting_0, Control control_1)
	{
		smethod_51(setting_0, 0, control_1);
	}

	internal static void smethod_51(Setting setting_0, int int_49, Control control_1)
	{
		if (panel_0 != null && !panel_0.Disposing && !panel_0.IsDisposed)
		{
			if (panel_0.Tag == setting_0)
			{
				smethod_53(null, null);
				return;
			}
			if (panel_0.Parent != null && panel_0.Parent.Controls.Contains(panel_0))
			{
				panel_0.Dispose();
			}
		}
		panel_0 = new Panel();
		panel_0.BackColor = form23_0.class131_0.BackColor;
		panel_0.BorderStyle = BorderStyle.FixedSingle;
		panel_0.Width = 600;
		panel_0.Click -= smethod_53;
		panel_0.Click += smethod_53;
		control_1.TopLevelControl.Click -= smethod_53;
		control_1.TopLevelControl.Click += smethod_53;
		control_1.TopLevelControl.Controls.Add(panel_0);
		panel_0.Tag = setting_0;
		while (panel_0.Controls.Count != 0)
		{
			Control control = panel_0.Controls[0];
			if (control is ThemedButton)
			{
				(control as ThemedButton).Click -= smethod_59;
				(control as ThemedButton).Click -= smethod_57;
				(control as ThemedButton).Click -= smethod_55;
			}
			control.Dispose();
		}
		int int_50 = 0;
		int int_51 = 0;
		smethod_46(setting_0, panel_0, ref int_50, ref int_51);
		Class286 @class = null;
		bool flag = false;
		MenuNode menuNode = MenuNode.smethod_2(framework_1.awj, setting_0.method_69());
		if (menuNode != null)
		{
			MenuNode menuNode2 = menuNode.method_83(setting_0);
			if (menuNode2 != null)
			{
				@class = menuNode2.method_80().BcF;
				flag = menuNode2.method_84();
			}
		}
		Label label = new Label();
		label.ForeColor = color_12;
		label.AutoSize = true;
		label.MinimumSize = new Size(600, 0);
		label.MaximumSize = new Size(600, 600);
		label.Left = 0;
		label.Top = int_51 + 10;
		if (((@class != null && setting_0.method_78()) & flag) && !string.IsNullOrEmpty(setting_0.method_80()) && !string.IsNullOrEmpty(setting_0.method_82()))
		{
			string text = setting_0.method_82();
			if (string.IsNullOrEmpty(label.Text))
			{
				if (!string.IsNullOrEmpty(text))
				{
					label.Text = setting_0.method_80() + Class333.smethod_1810() + text;
				}
			}
			else if (!string.IsNullOrEmpty(text))
			{
				label.Text = label.Text + setting_0.method_80() + Class333.smethod_1810() + text;
			}
		}
		else
		{
			string text2 = setting_0.method_60(Enum96.aYU);
			if (string.IsNullOrEmpty(label.Text))
			{
				if (!string.IsNullOrEmpty(text2))
				{
					label.Text = setting_0.method_22(bool_0: true) + Class333.smethod_1810() + text2;
				}
			}
			else if (!string.IsNullOrEmpty(text2))
			{
				label.Text = label.Text + setting_0.method_22(bool_0: true) + Class333.smethod_1810() + text2;
			}
		}
		if (int_50 == 0 && setting_0.method_102().Count == 0 && setting_0.method_106().Count == 0 && !setting_0.method_154())
		{
			int num;
			int num2;
			if ((@class != null && setting_0.method_78()) & flag)
			{
				num = setting_0.method_222();
				num2 = setting_0.method_223();
			}
			else
			{
				num = setting_0.method_228();
				num2 = setting_0.method_229();
			}
			if (num != 0 || num2 != 0)
			{
				if (string.IsNullOrEmpty(label.Text))
				{
					label.Text = setting_0.method_22(bool_0: true) + Class333.smethod_1811();
				}
				else
				{
					label.Text += Class333.smethod_1812();
				}
				int num3 = setting_0.method_231();
				int num4 = setting_0.method_100();
				string arg = Class233.smethod_29(num, num3, num4);
				string arg2 = Class233.smethod_29(num2, num3, num4);
				label.Text += string.Format(Class333.smethod_539(), arg, arg2);
				int num5 = setting_0.method_221();
				if (num5 > 1)
				{
					string arg3 = Class233.smethod_29(num5, num3, num4);
					label.Text += string.Format(Class333.smethod_1813(), arg3);
				}
			}
		}
		panel_0.Controls.Add(label);
		int int_52 = label.Bottom + 10;
		bool bool_ = string.IsNullOrEmpty(label.Text);
		smethod_58(setting_0, int_49, ref int_52, ref bool_);
		if (@class != null && (!setting_0.method_78() || !flag))
		{
			smethod_54(@class, setting_0, int_49, ref int_52, ref bool_);
		}
		smethod_56(setting_0, int_49, ref int_52, ref bool_);
		panel_0.Height = int_52;
		int num6 = control_1.Right + 10;
		int num7 = control_1.Top - 10;
		Control control2 = control_1;
		bool flag2 = false;
		do
		{
			if (control2.Parent == null || control2.Parent == control_1.TopLevelControl)
			{
				flag2 = true;
				continue;
			}
			control2 = control2.Parent;
			num6 += control2.Left;
			num7 += control2.Top;
		}
		while (!flag2);
		if (num7 + panel_0.Height > control_1.TopLevelControl.Height - 100)
		{
			num7 -= num7 + panel_0.Height - (control_1.TopLevelControl.Height - 100);
		}
		num7 = Math.Max(num7, 0);
		if (num6 + panel_0.Width > control_1.TopLevelControl.Width - 20)
		{
			num6 -= num6 + panel_0.Width - (control_1.TopLevelControl.Width - 20);
		}
		num6 = Math.Max(num6, 0);
		panel_0.Left = num6;
		panel_0.Top = num7;
		panel_0.Visible = true;
		panel_0.BringToFront();
	}

	internal static void smethod_52(List<string> list_9, List<Color> list_10, Control control_1, object object_4, int int_49, int int_50)
	{
		if (panel_0 != null && !panel_0.Disposing && !panel_0.IsDisposed)
		{
			if (panel_0.Tag == object_4)
			{
				smethod_53(null, null);
				return;
			}
			if (panel_0.Parent != null && panel_0.Parent.Controls.Contains(panel_0))
			{
				panel_0.Dispose();
			}
		}
		int num = 0;
		foreach (string item in list_9)
		{
			num = Math.Max(num, TextRenderer.MeasureText(item, Control.DefaultFont).Width + 10);
		}
		panel_0 = new Panel();
		panel_0.BackColor = form23_0.class131_0.BackColor;
		panel_0.BorderStyle = BorderStyle.FixedSingle;
		panel_0.Width = num;
		panel_0.Click -= smethod_53;
		panel_0.Click += smethod_53;
		control_1.TopLevelControl.Click -= smethod_53;
		control_1.TopLevelControl.Click += smethod_53;
		control_1.TopLevelControl.Controls.Add(panel_0);
		panel_0.Tag = object_4;
		while (panel_0.Controls.Count != 0)
		{
			Control control = panel_0.Controls[0];
			if (control is ThemedButton)
			{
				(control as ThemedButton).Click -= smethod_59;
				(control as ThemedButton).Click -= smethod_57;
				(control as ThemedButton).Click -= smethod_55;
			}
			control.Dispose();
		}
		int num2 = 10;
		foreach (string item2 in list_9)
		{
			Label label = new Label();
			label.ForeColor = list_10[list_9.IndexOf(item2)];
			label.AutoSize = true;
			label.Text = item2;
			label.Left = 0;
			label.Top = num2;
			panel_0.Controls.Add(label);
			num2 = label.Bottom + 10;
		}
		panel_0.Height = num2;
		int num3 = int_49;
		int num4 = int_50;
		Control control2 = control_1;
		bool flag = false;
		do
		{
			if (control2.Parent == null || control2.Parent == control_1.TopLevelControl)
			{
				flag = true;
				continue;
			}
			control2 = control2.Parent;
			num3 += control2.Left;
			num4 += control2.Top;
		}
		while (!flag);
		if (num4 + panel_0.Height > control_1.TopLevelControl.Height - 100)
		{
			num4 -= num4 + panel_0.Height - (control_1.TopLevelControl.Height - 100);
		}
		num4 = Math.Max(num4, 0);
		if (num3 + panel_0.Width > control_1.TopLevelControl.Width - 20)
		{
			num3 -= num3 + panel_0.Width - (control_1.TopLevelControl.Width - 20);
		}
		num3 = Math.Max(num3, 0);
		panel_0.Left = num3;
		panel_0.Top = num4;
		panel_0.Visible = true;
		panel_0.BringToFront();
	}

	internal static void smethod_53(object sender, EventArgs e)
	{
		if (panel_0 != null && !panel_0.Disposing && !panel_0.IsDisposed)
		{
			panel_0.Tag = null;
			panel_0.Visible = false;
		}
	}

	private static void smethod_54(Class286 class286_1, Setting setting_0, int int_49, ref int int_50, ref bool bool_53)
	{
		if (setting_0.method_70() != 0 || (framework_1.method_2() && framework_1.method_3() && setting_0.method_96()))
		{
			return;
		}
		int[] array = class286_1.method_3(setting_0);
		if (array != null && array.Length > int_49)
		{
			int num = array[int_49];
			string bsP = class286_1.BcC[Class333.smethod_562()].BsP;
			Label label = new Label();
			label.ForeColor = color_12;
			label.AutoSize = true;
			label.MinimumSize = new Size(600, 0);
			label.MaximumSize = new Size(600, 100);
			label.Left = 0;
			label.Top = int_50;
			if (bool_53)
			{
				label.Text = setting_0.method_22(bool_0: true) + Class333.smethod_1811();
				bool_53 = false;
			}
			int num2 = setting_0.method_258(int_49);
			bool flag = num2 == num;
			if (!flag)
			{
				label.Font = new Font(label.Font.FontFamily, 8.25f, FontStyle.Italic);
			}
			int num3 = setting_0.method_100();
			(string, string, bool) tuple = setting_0.method_253(num2, num3);
			(string, string, bool) tuple2 = setting_0.method_253(num, num3);
			label.Text += string.Format(Class333.smethod_1814(), tuple.Item1);
			label.Text += string.Format(Class333.smethod_1815() + bsP + Class333.smethod_1816(), tuple2.Item1);
			panel_0.Controls.Add(label);
			if (flag)
			{
				int_50 += label.Height + 10;
				return;
			}
			ThemedButton themedButton = new ThemedButton();
			themedButton.Text = Class333.smethod_1817() + bsP + Class333.smethod_1818();
			themedButton.Tag = new object[3];
			(themedButton.Tag as object[])[0] = setting_0;
			(themedButton.Tag as object[])[1] = int_49;
			(themedButton.Tag as object[])[2] = num;
			themedButton.AutoSize = false;
			themedButton.Width = 250;
			themedButton.Height = 47;
			themedButton.Left = 300 - themedButton.Width / 2;
			themedButton.Top = label.Bottom + 10;
			themedButton.Enabled = framework_1.method_4();
			themedButton.Click += smethod_55;
			panel_0.Controls.Add(themedButton);
			int_50 += label.Height + 10 + themedButton.Height + 10;
		}
	}

	private static void smethod_55(object sender, EventArgs e)
	{
		if ((sender as ThemedButton).Tag != null)
		{
			Setting setting = ((sender as ThemedButton).Tag as object[])[0] as Setting;
			int num = (int)((sender as ThemedButton).Tag as object[])[1];
			int num2 = (int)((sender as ThemedButton).Tag as object[])[2];
			Class280 @class = smethod_95();
			@class?.method_3(setting.method_69());
			setting.method_274(num, num2, bool_0: true);
			@class?.method_4();
			smethod_75(setting.method_69());
		}
		smethod_53(null, null);
	}

	private static void smethod_56(Setting setting_0, int int_49, ref int int_50, ref bool bool_53)
	{
		if (framework_0 == null)
		{
			return;
		}
		Setting setting = framework_0.method_32(setting_0.method_69());
		if (setting == null || (framework_1.method_2() && framework_1.method_3() && setting_0.method_96()) || (framework_0.method_2() && framework_0.method_3() && setting.method_96()))
		{
			return;
		}
		Label label = new Label();
		label.AutoSize = true;
		label.MinimumSize = new Size(600, 0);
		label.MaximumSize = new Size(600, 100);
		label.Left = 0;
		label.Top = int_50;
		if (bool_53)
		{
			label.Text = setting_0.method_22(bool_0: true) + Class333.smethod_1811();
			bool_53 = false;
		}
		bool flag;
		if (setting_0.method_70() != 0)
		{
			string text = setting_0.method_260();
			string text2 = setting.method_260();
			if (flag = text == text2)
			{
				label.ForeColor = color_12;
			}
			else
			{
				label.ForeColor = color_9;
			}
			label.Text += string.Format(Class333.smethod_1814(), text);
			label.Text += string.Format(Class333.smethod_1819(), text2);
		}
		else
		{
			int num = setting_0.method_258(int_49);
			int num2 = setting.method_258(int_49);
			if (flag = num == num2)
			{
				label.ForeColor = color_12;
			}
			else
			{
				label.ForeColor = color_9;
			}
			int num3 = setting_0.method_100();
			(string, string, bool) tuple = setting_0.method_253(num, num3);
			(string, string, bool) tuple2 = setting.method_253(num2, num3);
			label.Text += string.Format(Class333.smethod_1814(), tuple.Item1);
			label.Text += string.Format(Class333.smethod_1819(), tuple2.Item1);
		}
		panel_0.Controls.Add(label);
		if (!flag && enum60_0 != Enum60.BpG)
		{
			ThemedButton themedButton = new ThemedButton();
			themedButton.Text = Class333.smethod_1820();
			themedButton.Tag = new object[2];
			(themedButton.Tag as object[])[0] = setting_0;
			(themedButton.Tag as object[])[1] = int_49;
			themedButton.AutoSize = false;
			themedButton.Width = 120;
			themedButton.Height = 47;
			themedButton.Left = 300 - themedButton.Width / 2;
			themedButton.Top = label.Bottom + 10;
			themedButton.Enabled = framework_1.method_4();
			themedButton.Click += smethod_57;
			panel_0.Controls.Add(themedButton);
			int_50 += label.Height + 10 + themedButton.Height + 10;
		}
		else
		{
			int_50 += label.Height + 10;
		}
	}

	private static void smethod_57(object sender, EventArgs e)
	{
		if (framework_0 != null && (sender as ThemedButton).Tag != null)
		{
			Setting setting = ((sender as ThemedButton).Tag as object[])[0] as Setting;
			Setting setting2 = framework_0.method_32(setting.method_69());
			if (setting2 != null)
			{
				Class280 @class = smethod_95();
				@class?.method_3(setting.method_69());
				if (setting.method_70() != 0)
				{
					for (int i = 0; i < Math.Min(setting.method_278(), setting2.method_278()); i++)
					{
						setting.method_270(i, setting2.method_254(i), bool_0: true);
					}
				}
				else
				{
					int num = (int)((sender as ThemedButton).Tag as object[])[1];
					setting.method_274(num, setting2.method_258(num), bool_0: true);
				}
				@class?.method_4();
				smethod_75(setting.method_69());
			}
		}
		smethod_53(null, null);
	}

	private static void smethod_58(Setting setting_0, int int_49, ref int int_50, ref bool bool_53)
	{
		if (!framework_1.method_2() || !framework_1.method_3() || !setting_0.method_96())
		{
			Label label = new Label();
			label.ForeColor = color_12;
			label.AutoSize = true;
			label.MinimumSize = new Size(600, 0);
			label.MaximumSize = new Size(600, 100);
			label.Left = 0;
			label.Top = int_50;
			if (bool_53)
			{
				label.Text = setting_0.method_22(bool_0: true) + Class333.smethod_1811();
				bool_53 = false;
			}
			if (setting_0.method_70() != 0)
			{
				string arg = setting_0.method_260();
				string arg2 = setting_0.method_249();
				label.Text += string.Format(Class333.smethod_1814(), arg);
				label.Text += string.Format(Class333.smethod_1821(), arg2);
			}
			else
			{
				int num = setting_0.method_258(int_49);
				int num2 = setting_0.method_248(int_49);
				int num3 = setting_0.method_100();
				(string, string, bool) tuple = setting_0.method_253(num, num3);
				(string, string, bool) tuple2 = setting_0.method_253(num2, num3);
				label.Text += string.Format(Class333.smethod_1814(), tuple.Item1);
				label.Text += string.Format(Class333.smethod_1821(), tuple2.Item1);
			}
			panel_0.Controls.Add(label);
			ThemedButton themedButton = new ThemedButton();
			themedButton.Text = Class333.smethod_613();
			themedButton.Tag = new object[2];
			(themedButton.Tag as object[])[0] = setting_0;
			(themedButton.Tag as object[])[1] = int_49;
			themedButton.AutoSize = false;
			themedButton.Width = 150;
			themedButton.Height = 47;
			themedButton.Left = 300 - themedButton.Width / 2;
			themedButton.Top = label.Bottom + 10;
			themedButton.Enabled = framework_1.method_4();
			themedButton.Click += smethod_59;
			panel_0.Controls.Add(themedButton);
			int_50 += label.Height + 10 + themedButton.Height + 10;
		}
	}

	private static void smethod_59(object sender, EventArgs e)
	{
		if ((sender as ThemedButton).Tag != null)
		{
			Setting setting = ((sender as ThemedButton).Tag as object[])[0] as Setting;
			Class280 @class = smethod_95();
			@class?.method_3(setting.method_69());
			if (setting.method_70() != 0)
			{
				setting.method_262(setting.method_249(), bool_0: true);
			}
			else
			{
				int num = (int)((sender as ThemedButton).Tag as object[])[1];
				setting.method_247(num, bool_0: true);
			}
			@class?.method_4();
			smethod_75(setting.method_69());
		}
		smethod_53(null, null);
	}

	internal static void smethod_60()
	{
		foreach (Enum88 value in Enum.GetValues(typeof(Enum88)))
		{
			Class235 @class = new Class235(value);
			string text = @class.method_15();
			MenuNode menuNode = new MenuNode(null, @class, null, bool_0: false, bool_1: false, string.Empty);
			menuNode.method_4(-1);
			menuNode.method_11(text);
			menuNode.method_69(@class.method_14());
			menuNode.method_13(0);
			list_4.Add(menuNode);
		}
	}

	internal static void smethod_61()
	{
		if ((int_0 & 1) == 0)
		{
			bool_29 = true;
		}
	}

	internal static void smethod_62()
	{
		lock (list_4)
		{
			for (int i = 0; i < list_4.Count; i++)
			{
				list_4[i].method_2().method_6(0);
				list_4[i].method_2().method_2(null);
			}
		}
	}

	private static void smethod_63()
	{
		if (form23_0.control4_0.method_0().method_2().Count == 0)
		{
			return;
		}
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		lock (list_4)
		{
			if (byte_0 == null)
			{
				byte_0 = new byte[list_4.Count];
			}
			for (int i = 0; i < list_4.Count; i++)
			{
				byte_0[i] = list_4[i].method_2().method_5();
			}
			if (class14_1 == null)
			{
				class14_1 = new Class14[list_4.Count];
			}
			for (int j = 0; j < list_4.Count; j++)
			{
				class14_1[j] = list_4[j].method_2().method_1();
			}
			Class5 @class = null;
			if ((int_0 & 1) != 0 && list_2.Count == 1)
			{
				@class = list_2[0].BpS;
				if (@class.struct1_0[37].uint_1 == 0)
				{
					@class = null;
				}
			}
			if (@class != null)
			{
				if (!Class1.smethod_37(@class.string_0, Enum10.const_9, 0u, @class.struct1_0[37].uint_1, out var byte_, out var _))
				{
					stopwatch.Stop();
					return;
				}
				byte b = 0;
				byte b2 = 0;
				byte b3 = 0;
				byte b4 = 0;
				byte b5 = 0;
				byte b6 = 0;
				byte[] array = new byte[12];
				bool flag2 = false;
				List<int> list = new List<int>();
				for (int k = 0; k < byte_.Length; k++)
				{
					byte b7 = byte_[k];
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
						array[0] = (byte)(b7 >> 4);
						array[1] = (byte)(b7 & 0xF);
						break;
					case 11:
						array[2] = (byte)(b7 >> 4);
						array[3] = (byte)(b7 & 0xF);
						break;
					case 12:
						array[4] = (byte)(b7 >> 4);
						array[5] = (byte)(b7 & 0xF);
						break;
					case 13:
						array[6] = (byte)(b7 >> 4);
						array[7] = (byte)(b7 & 0xF);
						break;
					case 14:
						array[8] = (byte)(b7 >> 4);
						array[9] = (byte)(b7 & 0xF);
						break;
					case 15:
					{
						array[10] = (byte)(b7 >> 4);
						array[11] = (byte)(b7 & 0xF);
						if (flag2)
						{
							break;
						}
						for (int l = 0; l < list_4.Count; l++)
						{
							if ((uint)list_4[l].method_2().method_0() == b)
							{
								list_4[l].method_2().method_2(new Class14(b3, b4, b5, b6, 0));
								if (!Class242.smethod_12(framework_1.awZ) && ((framework_1.awZ == 21 && framework_1.aXA >= new Class14(2, 33, 0, 1, 0)) || (framework_1.awZ != 21 && framework_1.aXA >= new Class14(1, 33, 0, 1, 0))))
								{
									list_4[l].method_2().method_4(array);
								}
								if (framework_1.method_27(list_4[l].method_2().method_0()) && (b2 == 0 || (b2 & 1) == 0))
								{
									list_4[l].method_2().method_6((byte)(b2 | 1));
								}
								else
								{
									list_4[l].method_2().method_6(b2);
								}
								list.Add(l);
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
				for (int m = 0; m < list_4.Count; m++)
				{
					if (!list.Contains(m))
					{
						if (framework_1.method_27(list_4[m].method_2().method_0()))
						{
							list_4[m].method_2().method_6(1);
						}
						else
						{
							list_4[m].method_2().method_6(0);
						}
					}
				}
			}
			else
			{
				for (int n = 0; n < list_4.Count; n++)
				{
					if (framework_1.method_27(list_4[n].method_2().method_0()))
					{
						list_4[n].method_2().method_6(1);
					}
					else
					{
						list_4[n].method_2().method_6(0);
					}
				}
			}
			List<int> list2 = new List<int>();
			for (int num = 0; num < list_4.Count; num++)
			{
				if (byte_0[num] != list_4[num].method_2().method_5() || class14_1[num] != list_4[num].method_2().method_1())
				{
					list2.Add(num);
				}
			}
			if (list2.Count != 0)
			{
				string text = string.Empty;
				foreach (int item in list2)
				{
					text = text + Class333.smethod_1822() + list_4[item].method_2().method_0().ToString() + Class333.smethod_1823() + byte_0[item] + Class333.smethod_1824() + list_4[item].method_2().method_5();
				}
				Class23.smethod_3(Class333.smethod_1825() + text);
				form23_0.control4_0.method_14(bool_7: false, bool_8: true, bool_9: true, bool_10: false);
				form23_0.control4_0.method_39(bool_7: false);
				if (framework_0 != null)
				{
					form23_0.control4_0.method_40(bool_7: false);
				}
			}
		}
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.smethod_1826(), stopwatch.ElapsedMilliseconds), bool_1: false);
	}

	private void method_76(object sender, EventArgs e)
	{
		Class5 @class = null;
		if (sender is Class5)
		{
			@class = sender as Class5;
		}
		else if (list_2.Count == 1)
		{
			@class = list_2[0].BpS;
		}
		else if (Class1.smethod_27().Count == 1)
		{
			@class = Class1.smethod_27()[0];
		}
		if (@class != null)
		{
			Class305.smethod_5();
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (string_34 == null)
			{
				string_34 = Class320.Bdl;
			}
			else if (string_35 != null)
			{
				openFileDialog.FileName = string_35;
			}
			openFileDialog.InitialDirectory = string_34;
			openFileDialog.Title = Class333.smethod_1110();
			openFileDialog.Filter = Class333.smethod_1111();
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				method_77(openFileDialog.FileName, @class);
				try
				{
					string_34 = Path.GetDirectoryName(openFileDialog.FileName);
					string_35 = openFileDialog.FileName;
				}
				catch
				{
					string_34 = null;
					string_35 = null;
				}
			}
			openFileDialog.Dispose();
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_1827(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_77(string string_41, Class5 class5_0)
	{
		method_78(string_41, class5_0, bool_53: false, bool_54: false, bool_55: true, null);
	}

	private void method_78(string string_41, Class5 class5_0, bool bool_53, bool bool_54, bool bool_55, List<string> list_9)
	{
		List<Class314> list = Class320.smethod_8(string_41);
		if (list.Count != 0)
		{
			Class14 @class = null;
			if (class5_0.byte_8 != byte.MaxValue || class5_0.byte_9 != byte.MaxValue || class5_0.byte_10 != byte.MaxValue || class5_0.byte_11 != byte.MaxValue)
			{
				@class = new Class14(class5_0.byte_8, class5_0.byte_9, class5_0.byte_10, class5_0.byte_11, 0);
			}
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			foreach (Class314 item in list)
			{
				bool flag4;
				bool flag5;
				if (item.BDy != null)
				{
					flag4 = item.BDy.axs == class5_0.byte_5 || (string_27 != null && (class5_0.byte_5 == 0 || class5_0.byte_5 == byte.MaxValue)) || item.BDy.axS == 22;
					flag5 = item.BDy.axS == class5_0.byte_4 || (string_27 != null && (class5_0.byte_4 == 0 || class5_0.byte_4 == byte.MaxValue));
				}
				else
				{
					flag5 = false;
					flag4 = false;
				}
				if (!(flag5 & flag4))
				{
					continue;
				}
				flag = true;
				if (!(@class == null) && !(item.BDy.axT >= @class))
				{
					continue;
				}
				flag2 = true;
				if (!Class320.smethod_43(class5_0.string_0) && !item.BDZ.Contains(class5_0.ushort_0))
				{
					continue;
				}
				flag3 = true;
				bool flag6 = Class320.smethod_48(class5_0) | bool_54;
				Class14 class14_ = new Class14(class5_0.byte_0, class5_0.byte_1, class5_0.byte_2, class5_0.byte_3, class5_0.int_0);
				Class14 axT = item.BDy.axT;
				bool bool_56 = false;
				Class316 class2 = new Class316
				{
					BdC = item.BDy,
					Bdc = item.BDZ
				};
				if (!bool_14)
				{
					if (Class305.smethod_4(class2, out var text, out var _))
					{
						string text2 = (string.IsNullOrEmpty(text) ? Class333.smethod_1118() : (Class333.smethod_1117() + text + Class333.smethod_570()));
						if (Form54.smethod_9(form23_0, Class333.smethod_1119() + text2, Class333.smethod_1120(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, new string[2]
						{
							Class333.smethod_1126(),
							Class333.smethod_823()
						}) == DialogResult.Cancel)
						{
							bool_56 = true;
						}
					}
					if (!bool_56 && !class2.BdC.axT.method_7() && !method_79(class2.BdC.axT))
					{
						bool_56 = true;
					}
				}
				bool flag8 = false;
				if (!bool_14 && !bool_56)
				{
					flag8 = smethod_64(class5_0, class14_, axT, out bool_56);
				}
				if (bool_56)
				{
					string_27 = null;
					bool_10 = true;
					list_1.Clear();
					Class1.smethod_30();
					Class1.smethod_32();
				}
				else
				{
					Class320.smethod_17(class5_0, string_41, bool_0: false, bool_53, flag6, null, flag8, bool_4: false, Enum88.avK, null, null, bool_5: false, null, null, null, bool_55, list_9);
				}
				break;
			}
			if (!bool_14)
			{
				if (!flag)
				{
					Form54.smethod_6(this, Class333.smethod_1114(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (!flag2 || !flag3)
				{
					Form54.smethod_6(this, Class333.smethod_1115(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			if (!flag || !flag2 || !flag3)
			{
				string_27 = null;
				bool_10 = true;
				list_1.Clear();
				Class1.smethod_30();
				Class1.smethod_32();
			}
		}
		else
		{
			if (!bool_14)
			{
				Form54.smethod_6(this, Class333.smethod_1113(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			string_27 = null;
			bool_10 = true;
			list_1.Clear();
			Class1.smethod_30();
			Class1.smethod_32();
		}
	}

	private bool method_79(Class14 class14_2)
	{
		string text = class14_2.method_6();
		if (Form59.smethod_2())
		{
			if (Form54.smethod_9(form23_0, Class333.smethod_1127() + text + Class333.smethod_190(), Class333.smethod_1121() + text, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, new string[2]
			{
				Class333.smethod_1126(),
				Class333.smethod_823()
			}) == DialogResult.Cancel)
			{
				return false;
			}
		}
		else
		{
			if (Form54.smethod_6(form23_0, Class333.smethod_1121() + text + Class333.smethod_1122(), Class333.smethod_1123(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
			{
				return false;
			}
			Form59 form = new Form59();
			form.ShowDialog(form23_0);
			form.Dispose();
			if (!Form59.smethod_2())
			{
				return false;
			}
		}
		return true;
	}

	internal static bool smethod_64(Class5 class5_0, Class14 class14_2, Class14 class14_3, out bool bool_53)
	{
		bool result = false;
		bool_53 = false;
		if (class5_0.byte_4 == 20)
		{
			if (Class320.smethod_48(class5_0))
			{
				result = true;
			}
			else if (class5_0.byte_5 == 3)
			{
				Class14 @class = new Class14(1, 18, 0, 102, 0);
				if (class14_2 != null && class14_3 != null && ((class14_2 < @class && class14_3 >= @class) || (class14_2 >= @class && class14_3 < @class)))
				{
					if (Form54.smethod_6(form23_0, Class333.smethod_1828(), Class333.smethod_1829(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
					{
						result = true;
					}
					else
					{
						bool_53 = true;
					}
				}
			}
		}
		return result;
	}

	internal void class169_0_Click(object sender, EventArgs e)
	{
		method_80(null);
	}

	private void method_80(string string_41)
	{
		if (list_2.Count == 1)
		{
			if (framework_1 != null && framework_1.awZ != 21 && framework_1.method_68())
			{
				Form54.smethod_6(this, Class333.smethod_1124(), Class333.smethod_1125(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Class305.smethod_5();
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.DoWork += method_82;
			backgroundWorker.ProgressChanged += smethod_69;
			backgroundWorker.RunWorkerCompleted += method_83;
			smethod_66(Class333.smethod_1830());
			backgroundWorker.RunWorkerAsync(string_41);
		}
	}

	private void method_81(Class5 class5_0)
	{
		if (string_27 != null)
		{
			Class320.smethod_17(class5_0, string_27, bool_0: false, bool_1: false, bool_2: false, null, bool_3: false, bool_4: false, Enum88.avK, null, null, bool_5: false, null, null, null, bool_6: false, null);
			return;
		}
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.DoWork += method_82;
		backgroundWorker.ProgressChanged += smethod_69;
		backgroundWorker.RunWorkerCompleted += method_83;
		smethod_66(Class333.smethod_1830());
		backgroundWorker.RunWorkerAsync();
	}

	private void method_82(object sender, DoWorkEventArgs e)
	{
		if (list_2.Count == 1)
		{
			Class5 bpS = list_2[0].BpS;
			Class14 @class = null;
			if (bpS.byte_8 != byte.MaxValue || bpS.byte_9 != byte.MaxValue || bpS.byte_10 != byte.MaxValue || bpS.byte_11 != byte.MaxValue)
			{
				@class = new Class14(bpS.byte_8, bpS.byte_9, bpS.byte_10, bpS.byte_11, 0);
			}
			Class14 class2 = new Class14(bpS.byte_0, bpS.byte_1, bpS.byte_2, bpS.byte_3, 0);
			bool flag = !Form59.smethod_2();
			List<Class318> bQF = Class320.smethod_38(sender as BackgroundWorker, bpS.byte_4, bpS.byte_5, class2, bpS.ushort_0, bpS.string_0, @class, flag, Enum88.avK, null, bool_1: false);
			List<Class318> bQf = Class320.smethod_38(null, 22, 13, null, ushort.MaxValue, bpS.string_0, null, flag, Enum88.avK, null, bool_1: false);
			Dictionary<Enum88, List<Class318>> dictionary = new Dictionary<Enum88, List<Class318>>();
			foreach (MenuNode item in list_4)
			{
				Class235 class3 = item.method_2();
				Class14 class4 = class3.method_1();
				if (class3.method_1() != null && (class4.method_0() != 0 || class4.method_1() != 0 || class4.method_2() != 0 || class4.method_3() != 0))
				{
					List<Class318> value = Class320.smethod_38(null, bpS.byte_4, bpS.byte_5, class2, bpS.ushort_0, bpS.string_0, @class, flag, class3.method_0(), class4, class3.method_11());
					dictionary.Add(class3.method_0(), value);
				}
			}
			string bQg = null;
			if (e.Argument != null && e.Argument is string)
			{
				bQg = e.Argument as string;
			}
			Class215 class5 = new Class215();
			class5.BQF = bQF;
			class5.BQf = bQf;
			class5.BQG = dictionary;
			class5.BQg = bQg;
			e.Result = class5;
		}
		else
		{
			e.Result = null;
		}
	}

	private void method_83(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		Class215 @class = e.Result as Class215;
		if (list_2.Count == 1 && @class != null && @class.BQF != null)
		{
			Class5 bpS = list_2[0].BpS;
			Class14 class14_ = new Class14(bpS.byte_0, bpS.byte_1, bpS.byte_2, bpS.byte_3, bpS.int_0);
			Class14 class14_2 = null;
			if (bpS.byte_8 != byte.MaxValue || bpS.byte_9 != byte.MaxValue || bpS.byte_10 != byte.MaxValue || bpS.byte_11 != byte.MaxValue)
			{
				class14_2 = new Class14(bpS.byte_8, bpS.byte_9, bpS.byte_10, bpS.byte_11, 0);
			}
			Form16 form = new Form16(@class.BQF, @class.BQf, bpS, class14_, class14_2, @class.BQg);
			form.ShowDialog(this);
			form.Dispose();
		}
	}

	private void method_84(object sender, DoWorkEventArgs e)
	{
		Thread.Sleep(1500);
	}

	private void method_85(object sender, RunWorkerCompletedEventArgs e)
	{
		if (string_27 != null && Class1.smethod_27().Count == 1)
		{
			method_78(string_27, Class1.smethod_27()[0], bool_8, bool_54: false, bool_10, list_1);
		}
	}

	internal static bool smethod_65(Framework framework_2, List<Class318> list_9)
	{
		if (framework_2 != null && list_9 != null && list_9.Count != 0 && list_9[0].BdF.Count != 0 && list_9[0].BdF[0].BdC.axT > framework_2.aXA)
		{
			return true;
		}
		return false;
	}

	private void method_86()
	{
		if (!bool_14)
		{
			panel_1.Size = new Size(500, 90);
			panel_1.BorderStyle = BorderStyle.FixedSingle;
			label_1.Font = new Font(label_1.Font.FontFamily, 12f);
			label_1.AutoSize = false;
			label_1.Size = new Size(panel_1.Width - 40, 30);
			label_1.Location = new Point(20, 15);
			panel_1.Controls.Add(label_1);
			progressBar_0.Size = new Size(panel_1.Width - 40, 20);
			progressBar_0.Location = new Point(20, 50);
			progressBar_0.Minimum = 0;
			progressBar_0.Maximum = 100;
			panel_1.Controls.Add(progressBar_0);
			Controls.Add(panel_1);
			panel_1.Visible = false;
		}
	}

	internal static void smethod_66(string string_41)
	{
		int_17 = 0;
		int_19 = 0;
		if (bool_14)
		{
			Console.Write(string_41 + Class333.smethod_665());
			return;
		}
		progressBar_0.Value = 0;
		label_1.Text = string_41;
		panel_1.Visible = true;
		panel_1.BringToFront();
	}

	internal static void smethod_67(int int_49)
	{
		if (bool_14)
		{
			if (int_49 != int_17)
			{
				if (int_49 != 0 && int_49 % 10 == 0)
				{
					Console.WriteLine(Class333.smethod_190());
					int_19++;
				}
				if (int_49 == 100)
				{
					while (int_19 < 10)
					{
						Console.WriteLine(Class333.smethod_190());
						int_19++;
					}
					Console.WriteLine(Class333.smethod_1831());
				}
			}
		}
		else
		{
			progressBar_0.Value = int_49;
		}
		int_17 = int_49;
	}

	internal static void smethod_68()
	{
		if (!bool_14)
		{
			panel_1.Visible = false;
		}
		int_17 = 0;
		int_19 = 0;
	}

	internal static void smethod_69(object sender, ProgressChangedEventArgs e)
	{
		if (bool_14)
		{
			if (e.ProgressPercentage != int_17)
			{
				if (e.ProgressPercentage != 0 && e.ProgressPercentage % 10 == 0)
				{
					Console.WriteLine(Class333.smethod_190());
					int_19++;
				}
				if (e.ProgressPercentage == 100)
				{
					while (int_19 < 10)
					{
						Console.WriteLine(Class333.smethod_190());
						int_19++;
					}
					Console.WriteLine(Class333.smethod_1831());
				}
			}
		}
		else
		{
			progressBar_0.Value = e.ProgressPercentage;
			if (e.UserState is string)
			{
				label_1.Text = e.UserState as string;
			}
		}
		int_17 = e.ProgressPercentage;
	}

	private void method_87()
	{
		if (!bool_14)
		{
			panel_2.Width = 650;
			panel_2.Height = 400;
			panel_2.BorderStyle = BorderStyle.FixedSingle;
			label_2.Font = new Font(label_2.Font.FontFamily, 12f, FontStyle.Bold);
			label_2.AutoSize = false;
			label_2.Size = new Size(panel_2.Width - 40, 30);
			label_2.Location = new Point(20, 15);
			panel_2.Controls.Add(label_2);
			for (int i = 0; i < 25; i++)
			{
				int num = 50 + 30 * i;
				Label label = new Label();
				label.Font = new Font(label.Font.FontFamily, label_2.Font.Size);
				label.AutoSize = false;
				label.Size = new Size(300, 30);
				label.Location = new Point(20, num);
				panel_2.Controls.Add(label);
				list_6.Add(label);
				ProgressBar progressBar = new ProgressBar();
				progressBar.Minimum = 0;
				progressBar.Maximum = 100;
				progressBar.Size = new Size(panel_2.Width - 40 - 300, 20);
				progressBar.Location = new Point(320, num + (30 - progressBar.Size.Height) / 2);
				panel_2.Controls.Add(progressBar);
				list_5.Add(progressBar);
			}
			Controls.Add(panel_2);
			panel_2.Visible = false;
		}
	}

	internal static void smethod_70(string string_41, List<string> list_9)
	{
		list_7 = list_9;
		int_18 = -1;
		int_17 = 0;
		int_19 = 0;
		if (bool_14)
		{
			Console.WriteLine(string_41);
			return;
		}
		label_2.Text = string_41;
		foreach (ProgressBar item in list_5)
		{
			if (list_5.IndexOf(item) < list_9.Count)
			{
				item.Value = 0;
				item.Visible = true;
			}
			else
			{
				item.Visible = false;
			}
		}
		foreach (Label item2 in list_6)
		{
			int num = list_6.IndexOf(item2);
			if (num < list_9.Count)
			{
				item2.Text = list_9[num];
				item2.Visible = true;
			}
			else
			{
				item2.Visible = false;
			}
		}
		panel_2.Height = 50 + 30 * list_9.Count + 15;
		panel_2.Left = form23_0.Width / 2 - panel_2.Width / 2;
		panel_2.Top = form23_0.Height / 2 - panel_2.Height / 2;
		panel_2.Visible = true;
		panel_2.BringToFront();
	}

	internal static void smethod_71()
	{
		if (!bool_14)
		{
			panel_2.Visible = false;
		}
		int_18 = -1;
		int_17 = 0;
		int_19 = 0;
	}

	internal static void smethod_72(object sender, ProgressChangedEventArgs e)
	{
		if (!(e.UserState is int))
		{
			return;
		}
		int num = (int)e.UserState;
		if (bool_14)
		{
			if (num != int_18)
			{
				Console.Write(list_7[num] + Class333.smethod_665());
				int_17 = 0;
				int_19 = 0;
			}
			else if (e.ProgressPercentage != int_17)
			{
				if (e.ProgressPercentage != 0 && e.ProgressPercentage % 10 == 0)
				{
					Console.WriteLine(Class333.smethod_190());
					int_19++;
				}
				if (e.ProgressPercentage == 100)
				{
					while (int_19 < 10)
					{
						Console.WriteLine(Class333.smethod_190());
						int_19++;
					}
					Console.WriteLine(Class333.smethod_1831());
				}
			}
		}
		else
		{
			list_5[num].Value = e.ProgressPercentage;
		}
		int_18 = num;
		int_17 = e.ProgressPercentage;
	}

	private void toolStripButton_12_Click(object sender, EventArgs e)
	{
		class131_3.Visible = !class131_3.Visible;
		bool_30 = true;
		class131_0.Visible = false;
		class131_1.Visible = false;
		class131_2.Visible = false;
		if (!class131_3.Visible)
		{
			float_0 = (float)splitContainer_0.SplitterDistance / (float)splitContainer_0.Width;
			method_118();
			smethod_73();
		}
		else
		{
			method_92();
		}
		method_88();
	}

	private void method_88()
	{
		if (class131_3.Visible)
		{
			toolStripButton_12.Image = image_0;
		}
		else
		{
			toolStripButton_12.Image = image_1;
		}
	}

	internal void toolStripMenuItem_33_Click(object sender, EventArgs e)
	{
		method_92();
	}

	private Uri method_89()
	{
		Uri uri = null;
		if (!string.IsNullOrEmpty(string_36))
		{
			try
			{
				string text = Class22.smethod_1(string_14, string_36 + Class333.smethod_588(), bool_0: true);
				if (text != null)
				{
					uri = new Uri(text);
				}
			}
			catch
			{
				uri = null;
			}
			if (uri == null)
			{
				try
				{
					uri = new Uri(Class333.smethod_451() + string_36);
				}
				catch
				{
					uri = null;
				}
			}
		}
		return uri;
	}

	internal void method_90()
	{
		bool_30 = !bool_30;
		Uri uri = method_89();
		if (control2_0 == null)
		{
			control2_0 = new Control2();
		}
		if (bool_30)
		{
			class131_0.Visible = false;
			class131_1.Visible = false;
			class131_2.Visible = false;
			class131_3.Dock = DockStyle.None;
			toolStripButton_12.Image = image_0;
			form18_0.Controls.Remove(control2_0);
			form18_0.Hide();
			class131_3.Controls.Add(control2_0);
			if (!class131_3.Visible)
			{
				class131_3.Visible = true;
			}
		}
		else
		{
			if (form18_0 == null)
			{
				form18_0 = new Form18();
			}
			class131_3.Controls.Remove(control2_0);
			class131_3.Visible = false;
			class131_3.Dock = DockStyle.Fill;
			toolStripButton_12.Image = image_1;
			form18_0.Controls.Add(control2_0);
			if (!form18_0.Visible)
			{
				form18_0.Location = new Point(Location.X + (Width - form18_0.Width) / 2, Location.Y + (Height - form18_0.Height) / 2);
				form18_0.Show(this);
			}
			form18_0.Activate();
		}
		method_118();
		smethod_73();
		control2_0.method_18();
		if (uri != null)
		{
			control2_0.method_3(uri);
		}
	}

	internal void method_91()
	{
		if (bool_30)
		{
			toolStripButton_12_Click(null, null);
		}
		else if (form18_0 != null)
		{
			form18_0.Visible = !form18_0.Visible;
			if (form18_0.Visible)
			{
				Uri uri = method_89();
				if (uri != null)
				{
					control2_0.method_3(uri);
				}
			}
		}
		else
		{
			method_92();
		}
	}

	internal void method_92()
	{
		Uri uri = method_89();
		if (control2_0 == null)
		{
			control2_0 = new Control2();
		}
		if (bool_30)
		{
			class131_3.Controls.Add(control2_0);
			if (!class131_3.Visible)
			{
				class131_3.Visible = true;
			}
			method_118();
			smethod_73();
		}
		else
		{
			if (form18_0 == null)
			{
				form18_0 = new Form18();
			}
			form18_0.Controls.Add(control2_0);
			if (!form18_0.Visible)
			{
				form18_0.Location = new Point(Location.X + (Width - form18_0.Width) / 2, Location.Y + (Height - form18_0.Height) / 2);
				form18_0.Show(this);
			}
			form18_0.Activate();
		}
		control2_0.method_18();
		if (uri != null)
		{
			control2_0.method_3(uri);
		}
	}

	internal void method_93()
	{
		Uri uri = method_89();
		if (uri != null && control2_0 != null)
		{
			control2_0.method_3(uri);
		}
	}

	private void method_94()
	{
		for (int i = 0; i < 10; i++)
		{
			for (int j = 0; j < 10; j++)
			{
				if (int_33[j, i] == 0 || int_29[j, i] == 0)
				{
					int_33[j, i] = 10000;
				}
			}
		}
	}

	private void method_95()
	{
		int num = 5;
		while (!method_96())
		{
			method_97();
			num--;
			if (num == 0)
			{
				break;
			}
		}
	}

	private bool method_96()
	{
		for (int i = 0; i < 10; i++)
		{
			for (int j = 1; j < 10; j++)
			{
				int num = int_33[j - 1, i];
				if (int_33[j, i] < num)
				{
					return false;
				}
			}
		}
		for (int k = 0; k < 10; k++)
		{
			for (int l = 1; l < 10; l++)
			{
				int num = int_33[k, l - 1];
				if (int_33[k, l] > num)
				{
					return false;
				}
			}
		}
		return true;
	}

	private void method_97()
	{
		for (int i = 0; i < 10; i++)
		{
			for (int j = 1; j < 9; j++)
			{
				int num = int_33[j - 1, i];
				int num2 = int_33[j, i];
				int num3 = int_33[j + 1, i];
				num2 = (num2 * 4 + num + num3) / 6;
				int_33[j, i] = num2;
			}
		}
		for (int k = 0; k < 10; k++)
		{
			for (int l = 1; l < 9; l++)
			{
				int num = int_33[k, l - 1];
				int num2 = int_33[k, l];
				int num3 = int_33[k, l + 1];
				num2 = (num2 * 4 + num + num3) / 6;
				int_33[k, l] = num2;
			}
		}
	}

	private void method_98()
	{
		int num = 1000;
		int num2 = int_30[3];
		while (num > 0)
		{
			float num3 = method_99(num2);
			float num4 = method_99(num2 + 1);
			float num5 = method_99(num2 - 1);
			if (num4 < num3)
			{
				num2++;
			}
			else if (num5 < num3)
			{
				num2--;
			}
			else if (num3 <= num5 && !(num3 > num4))
			{
				int_31 = num2;
				break;
			}
			num--;
		}
		for (int i = 0; i < 10; i++)
		{
			int_32[i] = (int)Math.Round((double)int_31 * Math.Sqrt((double)int_23[i] / 304.0));
		}
		for (int j = 0; j < 10; j++)
		{
			for (int k = 0; k < 10; k++)
			{
				int_33[k, j] = method_104(k, j, int_32[k]);
			}
		}
	}

	private float method_99(int int_49)
	{
		float num = 0f;
		for (int i = 0; i < 10; i++)
		{
			float num2 = (float)int_49 * (float)Math.Sqrt((double)int_23[i] / 304.0) - (float)int_30[i];
			num += num2 * num2;
		}
		return num;
	}

	private void method_100(string string_41, int int_49)
	{
		string string_42 = null;
		FileStream fileStream = new FileStream(string_41, FileMode.Open);
		StreamReader streamReader = new StreamReader(fileStream);
		method_102(streamReader, ref string_42);
		for (int i = 0; i < 10; i++)
		{
			for (int j = 0; j < 52; j++)
			{
				method_103(streamReader, ref string_42);
				method_103(streamReader, ref string_42);
				int_24[int_49, i, j] = (int)Math.Round(float.Parse(string_42) * 1000f);
				method_103(streamReader, ref string_42);
				method_103(streamReader, ref string_42);
				int_25[int_49, i, j] = (int)Math.Round(float.Parse(string_42) * 10f);
				method_103(streamReader, ref string_42);
				int_26[int_49, i, j] = (int)Math.Round(float.Parse(string_42) * 10f);
				method_102(streamReader, ref string_42);
			}
		}
		streamReader.Close();
		fileStream.Close();
		method_105(int_49);
	}

	private bool method_101(string string_41, StreamReader streamReader_0, ref string string_42)
	{
		string_42 = Class333.smethod_102();
		while (true)
		{
			int num = streamReader_0.Read();
			if (num == -1)
			{
				break;
			}
			char c = (char)num;
			for (int i = 0; i < string_41.Length; i++)
			{
				if (c == string_41[i])
				{
					return true;
				}
			}
			if (c != '\r' && c != '"' && c != ',')
			{
				string_42 += c;
			}
		}
		return false;
	}

	private bool method_102(StreamReader streamReader_0, ref string string_41)
	{
		return method_101(Class333.smethod_570(), streamReader_0, ref string_41);
	}

	private bool method_103(StreamReader streamReader_0, ref string string_41)
	{
		return method_101(Class333.smethod_1832(), streamReader_0, ref string_41);
	}

	private int method_104(int int_49, int int_50, int int_51)
	{
		int_27[int_49, int_50] = 0;
		int_28[int_49, int_50] = 0;
		int num = 0;
		for (int i = 0; i < 52; i++)
		{
			if (int_26[int_49, int_50, i] > num)
			{
				num = int_26[int_49, int_50, i];
			}
		}
		int num2 = num * 20 / 100;
		int num3 = 0;
		for (int j = 0; j < 52 && int_26[int_49, int_50, j] < num2; j++)
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
			if (int_26[int_49, int_50, k] != 0)
			{
				num8++;
				float num9 = (float)int_24[int_49, int_50, k] / 1000f;
				float num10 = (float)int_26[int_49, int_50, k] / 10f;
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
			float num12 = (float)int_51 / 60f;
			float num13 = num4 / (float)num8;
			float num14 = num5 / (float)num8;
			if (float_1[int_49, int_50] < 0.1f)
			{
				return 0;
			}
			return (int)Math.Round((num13 - num14 / num12) * 1000f);
		}
		return 0;
	}

	private void method_105(int int_49)
	{
		int num = 0;
		float num2 = 0f;
		float[] array = new float[10];
		float[] array2 = new float[10];
		for (int i = 0; i < 10; i++)
		{
			int_27[int_49, i] = 0;
			int_28[int_49, i] = 0;
			int num3 = 0;
			for (int j = 0; j < 52; j++)
			{
				if (int_26[int_49, i, j] > num3)
				{
					num3 = int_26[int_49, i, j];
				}
			}
			int num4 = num3 * 20 / 100;
			int num5 = 0;
			for (int k = 0; k < 52 && int_26[int_49, i, k] < num4; k++)
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
				if (int_26[int_49, i, l] != 0)
				{
					num10++;
					float num11 = (float)int_24[int_49, i, l] / 1000f;
					float num12 = (float)int_26[int_49, i, l] / 10f;
					num6 += num11;
					num7 += num12;
					num9 += num11 * num11;
					num8 += num11 * num12;
				}
			}
			if (num10 == 0)
			{
				int_28[int_49, i] = 0;
				float_1[int_49, i] = 0f;
				int_27[int_49, i] = 0;
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
				float_1[int_49, i] = num16 / num13;
				int_27[int_49, i] = (int)Math.Round(float_1[int_49, i] * 60f);
				if (i > 4)
				{
					num++;
					num2 += float_1[int_49, i];
				}
				if (float_1[int_49, i] < 0.1f)
				{
					int_28[int_49, i] = 0;
				}
				else
				{
					int_28[int_49, i] = (int)Math.Round((num14 - num15 / float_1[int_49, i]) * 1000f);
				}
				array[i] = num14;
				array2[i] = num15;
			}
			else
			{
				float_1[int_49, i] = 0f;
				int_27[int_49, i] = 0;
				int_28[int_49, i] = 0;
				array[i] = 0f;
				array2[i] = 0f;
			}
		}
		if (num > 0)
		{
			num2 /= (float)num;
			float_2 = num2;
			int_30[int_49] = (int)Math.Round(float_2 * 60f);
			for (int m = 0; m < 10; m++)
			{
				if (int_28[int_49, m] > 0 && float_2 > 0.1f)
				{
					int_29[int_49, m] = (int)Math.Round((array[m] - array2[m] / float_2) * 1000f);
				}
				else
				{
					int_29[int_49, m] = 0;
				}
			}
		}
		else
		{
			float_2 = 0f;
			for (int n = 0; n < 10; n++)
			{
				int_29[int_49, n] = 0;
			}
		}
	}

	private void method_106()
	{
		Table table = framework_1.method_31(133) as Table;
		Table table2 = framework_1.method_31(134) as Table;
		Table table3 = framework_1.method_31(8641) as Table;
		Table table4 = framework_1.method_31(199) as Table;
		Table table5 = framework_1.method_31(200) as Table;
		Table table6 = framework_1.method_31(8647) as Table;
		Setting setting = framework_1.method_31(387);
		Setting setting2 = framework_1.method_31(421);
		if (table != null && table.ColumnAxis != null && table.RowAxis != null && table2 != null && table2.ColumnAxis != null && table2.RowAxis != null && table4 != null && table4.ColumnAxis != null && table4.RowAxis != null && table5 != null && table5.ColumnAxis != null && table5.RowAxis != null && setting != null && setting2 != null)
		{
			method_107(table, int_33);
			method_107(table4, int_29);
			method_108(table2, int_32);
			method_108(table5, int_30);
			if (table3 != null)
			{
				method_109(table3);
			}
			if (table6 != null)
			{
				method_109(table6);
			}
			return;
		}
		throw new Exception(Class333.smethod_1833());
	}

	private void method_107(Table table_0, int[,] int_49)
	{
		table_0.ColumnAxis.method_87().method_272(1, bool_0: true);
		table_0.ColumnAxis.method_88().method_272(10, bool_0: true);
		table_0.ColumnAxis.method_90().method_272(387, bool_0: true);
		table_0.RowAxis.method_87().method_272(1, bool_0: true);
		table_0.RowAxis.method_88().method_272(10, bool_0: true);
		table_0.RowAxis.method_90().method_272(421, bool_0: true);
		for (int i = 0; i < 10; i++)
		{
			table_0.ColumnAxis.method_89().method_274(i, (7 + i) * 1000, bool_0: true);
			for (int j = 0; j < 10; j++)
			{
				if (i == 0)
				{
					table_0.RowAxis.method_89().method_274(j, int_23[j] * 10, bool_0: true);
				}
				table_0.TableDataSetting.method_273(i, j, 0, int_49[j, i], bool_0: true);
			}
		}
	}

	private void method_108(Table table_0, int[] int_49)
	{
		table_0.ColumnAxis.method_87().method_272(1, bool_0: true);
		table_0.ColumnAxis.method_88().method_272(10, bool_0: true);
		table_0.ColumnAxis.method_90().method_272(421, bool_0: true);
		table_0.RowAxis.method_87().method_272(0, bool_0: true);
		for (int i = 0; i < 10; i++)
		{
			table_0.ColumnAxis.method_89().method_274(i, int_23[i] * 10, bool_0: true);
			table_0.TableDataSetting.method_273(i, 0, 0, int_49[i], bool_0: true);
		}
	}

	private void method_109(Table table_0)
	{
		int num = table_0.TableDataSetting.method_242()[0];
		int num2 = table_0.TableDataSetting.method_242()[1];
		int num3 = table_0.TableDataSetting.method_242()[2];
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				for (int k = 0; k < num3; k++)
				{
					table_0.TableDataSetting.method_273(k, j, i, 0, bool_0: true);
				}
			}
		}
	}

	private void method_110(object sender, EventArgs e)
	{
		if (framework_1 == null)
		{
			Form54.smethod_6(this, Class333.smethod_1834(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		FolderPicker folderPicker = new FolderPicker();
		if (folderPicker.ShowDialog(IntPtr.Zero) != true || Form54.smethod_6(this, Class333.smethod_1835(), Class333.smethod_1836(), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
		{
			return;
		}
		framework_1.method_48(framework_1.aWS);
		try
		{
			string[] files = Directory.GetFiles(folderPicker.ResultPath, Class333.smethod_933(), SearchOption.TopDirectoryOnly);
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			Dictionary<int, DateTime> dictionary2 = new Dictionary<int, DateTime>();
			string[] array = files;
			foreach (string text in array)
			{
				DateTime creationTime = File.GetCreationTime(text);
				DateTime lastWriteTime = File.GetLastWriteTime(text);
				DateTime dateTime = ((lastWriteTime > creationTime) ? lastWriteTime : creationTime);
				int key = int.Parse(Path.GetFileName(text).Substring(0, 3));
				if (!dictionary2.ContainsKey(key))
				{
					dictionary2.Add(key, dateTime);
					dictionary.Add(key, text);
				}
				else if (dateTime > dictionary2[key])
				{
					dictionary2[key] = dateTime;
					dictionary[key] = text;
				}
			}
			List<string> list = new List<string>();
			foreach (string value in dictionary.Values)
			{
				int num = int.Parse(Path.GetFileName(value).Substring(0, 3));
				int j;
				for (j = 0; j < 10 && num != int_23[j]; j++)
				{
				}
				if (j < 10)
				{
					method_100(value, j);
					list.Add(value);
				}
			}
			method_98();
			method_94();
			method_95();
			method_106();
			string text2 = Class333.smethod_1837();
			foreach (string item in list)
			{
				text2 = text2 + Class333.smethod_570() + item;
			}
			Form54.smethod_4(this, text2, Class333.smethod_14(), MessageBoxButtons.OK);
		}
		catch (Exception ex)
		{
			Form54.smethod_6(this, Class333.smethod_1838() + ex.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		framework_1.method_49(framework_1.aWS);
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		if (framework_1 == null || !framework_1.method_4() || smethod_87(this, bool_53: true) == DialogResult.Cancel)
		{
			return;
		}
		openFileDialog_1.Title = Class333.smethod_1365();
		openFileDialog_1.Filter = Class242.smethod_5();
		if (openFileDialog_1.ShowDialog(this) == DialogResult.OK)
		{
			Class240 @class = Class296.smethod_0(openFileDialog_1.FileName);
			if (@class != null)
			{
				method_111(null, openFileDialog_1.FileName, @class, bool_53: false);
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1369(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}

	private void method_111(string string_41, string string_42, Class240 class240_1, bool bool_53)
	{
		Struct29 @struct = new Struct29
		{
			BQi = framework_1,
			BQJ = string_42,
			BQH = string_41,
			BQj = bool_53,
			BQh = class240_1
		};
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.DoWork += method_112;
		backgroundWorker.ProgressChanged += smethod_69;
		backgroundWorker.RunWorkerCompleted += method_113;
		smethod_66(Class333.smethod_1839());
		backgroundWorker.RunWorkerAsync(@struct);
	}

	private void method_112(object sender, DoWorkEventArgs e)
	{
		Class23.smethod_3(Class333.smethod_1840());
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		Struct29 @struct = (Struct29)e.Argument;
		string text = @struct.BQH;
		if (text == null && @struct.BQh != null)
		{
			text = Class234.smethod_8(@struct.BQh.axS, @struct.BQh.axs, @struct.BQh.axT, @struct.BQh.axt, bool_0: true);
		}
		backgroundWorker.ReportProgress(20);
		if (!string.IsNullOrEmpty(text) && @struct.BQh != null)
		{
			Framework framework = (@struct.BQI = new Framework(text, @struct.BQh.axS, @struct.BQh.axs, @struct.BQh.axT));
			@struct.BQK = framework.method_1();
			if (@struct.BQK == Class237.Enum91.Brc)
			{
				backgroundWorker.ReportProgress(60);
				bool flag = new Class296(@struct.BQJ, framework).method_1(out var text2, bool_0: false, bool_1: true, bool_2: false) && string.IsNullOrEmpty(text2);
				backgroundWorker.ReportProgress(70);
				framework.method_58();
				framework.method_37(framework.awj);
				framework.method_42(null);
				backgroundWorker.ReportProgress(90);
				if (flag)
				{
					@struct.BQL = true;
				}
				else
				{
					@struct.BQk = text2;
					@struct.BQL = false;
				}
			}
			else
			{
				@struct.BQL = false;
			}
		}
		else
		{
			@struct.BQK = Class237.Enum91.BrD;
			@struct.BQL = false;
		}
		e.Result = @struct;
		Thread.Sleep(100);
		backgroundWorker.ReportProgress(100);
	}

	private void method_113(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct29 @struct = (Struct29)e.Result;
		Class23.smethod_3(Class333.smethod_1841() + @struct.BQL + Class333.smethod_9());
		smethod_68();
		bool flag = true;
		if (!@struct.BQL)
		{
			flag = false;
			if (@struct.BQK == Class237.Enum91.BrD)
			{
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += Class229.smethod_44;
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.ProgressChanged += smethod_69;
				smethod_66(Class333.smethod_1390());
				BackgroundWorker backgroundWorker2 = new BackgroundWorker();
				backgroundWorker2.DoWork += method_114;
				backgroundWorker2.RunWorkerCompleted += method_115;
				backgroundWorker.RunWorkerAsync();
				backgroundWorker2.RunWorkerAsync(@struct);
				Class229.abM = true;
			}
			else
			{
				string empty = string.Empty;
				if (@struct.BQK == Class237.Enum91.Brd)
				{
					empty = Class333.smethod_1391();
				}
				else if (@struct.BQK == Class237.Enum91.BrE)
				{
					empty = Class333.smethod_1392();
				}
				else
				{
					string text = Class242.smethod_10(@struct.BQh.axS, @struct.BQh.axs);
					text = ((text != null) ? (Class333.smethod_1393() + text + Class333.smethod_1394()) : string.Empty);
					if (@struct.BQK == Class237.Enum91.Bre)
					{
						empty = Class333.smethod_1395() + text + Class333.smethod_1396() + @struct.BQh.axT.ToString();
					}
					else
					{
						empty = ((!string.IsNullOrEmpty(@struct.BQk)) ? @struct.BQk : (Class333.smethod_1397() + text + Class333.smethod_1396() + @struct.BQh.axT.ToString()));
					}
				}
				if (1 != 0)
				{
					if (Form54.smethod_6(this, empty + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
					{
						while (openFileDialog_0.ShowDialog(this) == DialogResult.OK)
						{
							if (method_116(openFileDialog_0.FileName, @struct))
							{
								return;
							}
						}
					}
				}
				else if (Form54.smethod_9(this, @struct.BQk + Class333.smethod_1399(), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, new string[2]
				{
					Class333.smethod_1400(),
					Class333.smethod_1401()
				}) == DialogResult.Yes)
				{
					while (openFileDialog_0.ShowDialog(this) == DialogResult.OK)
					{
						if (method_116(openFileDialog_0.FileName, @struct))
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
		method_117();
		smethod_9();
		if (@struct.BQI.method_2() && @struct.BQI.method_3() && (!@struct.BQi.method_2() || !@struct.BQi.method_3() || !@struct.BQI.method_61(@struct.BQi)) && @struct.BQI.method_60(bool_0: true, bool_1: false) == DialogResult.Cancel)
		{
			smethod_10(bool_53: false);
			return;
		}
		lock (object_1)
		{
			int_0 |= 64;
		}
		Form19 form = new Form19(@struct.BQJ, bool_5: false, @struct.BQj, @struct.BQI, @struct.BQi);
		DialogResult dialogResult = form.ShowDialog(this);
		bool flag2 = form.method_19();
		string string_ = form.method_20();
		string string_2 = form.method_21();
		form.Dispose();
		if (dialogResult == DialogResult.Abort)
		{
			lock (object_1)
			{
				int_0 &= -65;
				return;
			}
		}
		if (framework_1.awZ == 21 && framework_1.method_12())
		{
			Class329.smethod_0(framework_1, null);
			Class329.smethod_5();
			if (framework_1.awP.method_98())
			{
				Class329.smethod_10();
			}
		}
		framework_1.method_65(form23_0);
		smethod_10(bool_53: false);
		smethod_11();
		if (dialogResult != DialogResult.OK && dialogResult != DialogResult.Yes)
		{
			lock (object_1)
			{
				int_0 &= -65;
			}
			if (@struct.BQj)
			{
				enum59_0 = Enum59.BpC;
			}
			return;
		}
		if (flag2)
		{
			smethod_102(string_, string_2, framework_1);
		}
		if (smethod_28(framework_1.aXc, bool_53: true))
		{
			method_223(null, -1);
			return;
		}
		lock (object_1)
		{
			int_0 &= -65;
		}
		framework_1.method_73();
	}

	private void method_114(object sender, DoWorkEventArgs e)
	{
		Struct29 bQl = (Struct29)e.Argument;
		string text = Class320.smethod_13(bQl.BQh, ushort.MaxValue);
		string[] bQm = Class229.smethod_46(bQl.BQh.axT, bQl.BQh.axS, bQl.BQh.axs, text, out var nullable_, out var updateOutcomes_);
		Struct30 @struct = new Struct30
		{
			BQl = bQl
		};
		if (nullable_.HasValue && updateOutcomes_ == UpdateOutcomes.CompleteUpdate)
		{
			@struct.BQM = updateOutcomes_;
			@struct.BQm = bQm;
		}
		e.Result = @struct;
	}

	private void method_115(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct30 @struct = (Struct30)e.Result;
		smethod_68();
		if (@struct.BQm != null && @struct.BQm.Length != 0)
		{
			string[] bQm = @struct.BQm;
			foreach (string text in bQm)
			{
				List<string> list;
				if (text.EndsWith(Class333.smethod_1402()))
				{
					list = new List<string>();
					list.Add(text);
				}
				else
				{
					list = Class234.smethod_13(text);
				}
				if (list.Count != 0 && method_116(text, @struct.BQl))
				{
					return;
				}
			}
		}
		string text2 = Class242.smethod_10(@struct.BQl.BQh.axS, @struct.BQl.BQh.axs);
		string text3 = string.Concat(str1: (text2 != null) ? (Class333.smethod_1393() + text2 + Class333.smethod_1394()) : string.Empty, str0: Class333.smethod_1403(), str2: Class333.smethod_1396(), str3: @struct.BQl.BQh.axT.ToString());
		if (Form54.smethod_6(this, text3 + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_116(openFileDialog_0.FileName, @struct.BQl))
			{
			}
		}
	}

	private bool method_116(string string_41, Struct29 struct29_0)
	{
		try
		{
			if (struct29_0.BQh == null)
			{
				return false;
			}
			string text = null;
			bool flag;
			bool flag2;
			bool flag3;
			Class14 @class;
			if (string_41.EndsWith(Class333.smethod_1404()))
			{
				flag = Class320.smethod_12(string_41, struct29_0.BQh, out flag2, out flag3, out @class, out text);
			}
			else
			{
				text = string_41;
				flag = Class234.smethod_5(string_41, struct29_0.BQh, out flag2, out flag3, out @class);
			}
			if (flag && text != null)
			{
				method_111(text, struct29_0.BQJ, struct29_0.BQh, struct29_0.BQj);
				return true;
			}
			if (!(@class == null) && text != null)
			{
				if (!flag2)
				{
					Form54.smethod_6(this, Class333.smethod_1842(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (!flag3)
				{
					Form54.smethod_6(this, Class333.smethod_1407() + @class.ToString() + Class333.smethod_1843() + struct29_0.BQh.axT.ToString() + Class333.smethod_9(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					Form54.smethod_6(this, Class333.smethod_1409(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1405(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1844() + ex.Message);
		}
		return false;
	}

	internal void method_117()
	{
		if (!bool_14)
		{
			if (!Directory.Exists(string_3 + Class333.smethod_557()))
			{
				Directory.CreateDirectory(string_3 + Class333.smethod_557());
			}
			File.Create(string_5).Close();
			List<string> list = new List<string>();
			list.Add(Class333.smethod_1419() + (formWindowState_0 == FormWindowState.Maximized));
			list.Add(Class333.smethod_1420() + int_34);
			list.Add(Class333.smethod_1421() + int_35);
			list.Add(Class333.smethod_1422() + int_36);
			list.Add(Class333.smethod_1423() + int_37);
			list.Add(Class333.smethod_1424() + class131_0.Visible);
			list.Add(Class333.smethod_1425() + class131_1.Visible);
			list.Add(Class333.smethod_1426() + class131_2.Visible);
			list.Add(Class333.smethod_1427() + class131_3.Visible);
			list.Add(Class333.smethod_1428() + float_0);
			list.Add(Class333.smethod_1429() + float_3);
			list.Add(Class333.smethod_1430() + control4_0.Visible);
			list.Add(Class333.smethod_1431() + control4_0.Width);
			list.Add(Class333.smethod_1432() + control4_0.method_2().Height);
			list.Add(Class333.smethod_1433() + (byte)control4_0.method_0().method_0());
			list.Add(Class333.smethod_1434() + control4_0.method_0().Font.Size);
			list.Add(Class333.smethod_1435() + !control4_0.method_5());
			list.Add(Class333.smethod_1436() + Class104.Bvd);
			list.Add(Class333.smethod_1437() + (byte)Class104.BvF);
			list.Add(Class333.smethod_1438() + (byte)Class104.Bve);
			string text = Class333.smethod_1439();
			int bvE = (int)Class104.BvE;
			list.Add(text + bvE);
			File.AppendAllLines(string_5, list);
		}
	}

	internal static void smethod_73()
	{
		form23_0.control4_0.Top = form23_0.toolStrip_0.Bottom + 2;
		form23_0.control4_0.Left = 1;
		form23_0.class131_0.Height = form23_0.control4_0.Height;
		Class131 @class = form23_0.class131_3;
		Class131 class2 = form23_0.class131_1;
		int num = (form23_0.class131_2.Height = form23_0.class131_0.Height);
		int height2 = (class2.Height = num);
		@class.Height = height2;
		if (bool_32)
		{
			form23_0.control4_0.Height = form23_0.Height - 2 - form23_0.control4_0.Top;
		}
		else
		{
			form23_0.control4_0.Height = form23_0.ClientSize.Height - 2 - form23_0.control4_0.Top;
		}
		form23_0.splitContainer_0.SuspendLayout();
		form23_0.splitContainer_0.Height = form23_0.control4_0.Height;
		form23_0.splitContainer_0.ResumeLayout(performLayout: true);
		form23_0.splitContainer_1.SuspendLayout();
		form23_0.splitContainer_1.Height = form23_0.control4_0.Height;
		form23_0.splitContainer_1.ResumeLayout(performLayout: true);
		if (form23_0.control4_0.Visible)
		{
			form23_0.control25_0.Left = form23_0.control4_0.Right + 1;
			if (!form23_0.class131_0.Visible && !form23_0.class131_1.Visible && !form23_0.class131_2.Visible && !form23_0.class131_3.Visible)
			{
				form23_0.control25_0.Width = form23_0.splitContainer_0.Right - form23_0.control4_0.Right - form23_0.splitContainer_0.SplitterWidth - 5;
			}
			else
			{
				form23_0.control25_0.Width = form23_0.splitContainer_0.Panel2.Left - form23_0.control4_0.Right - form23_0.splitContainer_0.SplitterWidth - 5;
			}
		}
		else
		{
			form23_0.control25_0.Left = form23_0.control4_0.Left;
			if (!form23_0.class131_0.Visible && !form23_0.class131_1.Visible && !form23_0.class131_2.Visible && !form23_0.class131_3.Visible)
			{
				form23_0.control25_0.Width = form23_0.splitContainer_0.Panel2.Right - form23_0.control4_0.Left - form23_0.splitContainer_0.SplitterWidth - 5;
			}
			else
			{
				form23_0.control25_0.Width = form23_0.splitContainer_0.Panel2.Left - form23_0.control4_0.Left - form23_0.splitContainer_0.SplitterWidth - 5;
			}
		}
		if (form23_0.control3_0.Visible)
		{
			form23_0.control3_0.Top = form23_0.splitContainer_1.Top;
			form23_0.control3_0.Left = form23_0.control25_0.Left;
			form23_0.control3_0.Width = form23_0.control25_0.Width;
			form23_0.control3_0.Height = form23_0.splitContainer_1.Panel2.Height;
			form23_0.control25_0.Height = form23_0.splitContainer_1.Panel1.Height;
		}
		else
		{
			form23_0.control25_0.Height = form23_0.control4_0.Height;
		}
		if (form23_0.control25_0.Width - 10 < 800)
		{
			form23_0.pictureBox_0.Width = form23_0.control25_0.Width - 10;
			form23_0.pictureBox_0.Height = 151 * (form23_0.control25_0.Width - 10) / 800;
		}
		else
		{
			form23_0.pictureBox_0.Width = 800;
			form23_0.pictureBox_0.Height = 151;
		}
		if (form23_0.class131_3.Visible)
		{
			form23_0.class131_3.Width = form23_0.splitContainer_0.Panel2.Width;
		}
		int num3 = form23_0.control25_0.Left + form23_0.control25_0.Width / 2;
		form23_0.pictureBox_0.Left = num3 - form23_0.pictureBox_0.Width / 2;
		form23_0.startupOptionsPanel_0.Left = num3 - form23_0.startupOptionsPanel_0.Width / 2;
		form23_0.pictureBox_0.Top = form23_0.control25_0.Height / 2 - (form23_0.pictureBox_0.Height + 80 + form23_0.startupOptionsPanel_0.Height) / 2;
		form23_0.startupOptionsPanel_0.Top = form23_0.pictureBox_0.Top + form23_0.pictureBox_0.Height + 80;
		if (form23_0.pictureBox_0.Visible)
		{
			form23_0.pictureBox_0.BringToFront();
		}
		if (form23_0.startupOptionsPanel_0.Visible)
		{
			form23_0.startupOptionsPanel_0.BringToFront();
		}
		form23_0.label_0.Left = form23_0.control25_0.Left + 33;
		form23_0.label_0.Top = form23_0.control25_0.Top + 60;
		panel_1.Left = num3 - panel_1.Width / 2;
		panel_1.Top = form23_0.Height / 2 - panel_1.Height / 2;
		panel_2.Left = num3 - panel_2.Width / 2;
		panel_2.Top = form23_0.Height / 2 - panel_2.Height / 2;
	}

	private void Form23_Resize(object sender, EventArgs e)
	{
		try
		{
			if (ClientSize.Width != 0 || ClientSize.Height != 0)
			{
				method_118();
				method_119();
				smethod_73();
				smethod_53(null, null);
			}
		}
		catch
		{
		}
	}

	private void method_118()
	{
		if (ClientSize.Width != 0 || ClientSize.Height != 0)
		{
			bool_31 = true;
			splitContainer_0.SplitterWidth = 2;
			if (class131_3.Visible)
			{
				splitContainer_0.IsSplitterFixed = false;
				splitContainer_0.SuspendLayout();
				splitContainer_0.SplitterDistance = (int)((float)splitContainer_0.Width * float_0);
				splitContainer_0.ResumeLayout(performLayout: true);
			}
			else if (!class131_3.Visible && !class131_0.Visible && !class131_1.Visible && !class131_2.Visible)
			{
				splitContainer_0.SplitterWidth = 1;
				splitContainer_0.Panel2MinSize = 0;
				splitContainer_0.IsSplitterFixed = true;
				splitContainer_0.SuspendLayout();
				splitContainer_0.SplitterDistance = ClientSize.Width;
				splitContainer_0.ResumeLayout(performLayout: true);
			}
			else
			{
				splitContainer_0.IsSplitterFixed = true;
				splitContainer_0.SuspendLayout();
				splitContainer_0.SplitterDistance = ClientSize.Width - 258;
				splitContainer_0.ResumeLayout(performLayout: true);
			}
			bool_31 = false;
		}
	}

	private void method_119()
	{
		if (ClientSize.Width != 0 || ClientSize.Height != 0)
		{
			bool_31 = true;
			splitContainer_1.SplitterWidth = 2;
			if (control3_0.Visible)
			{
				splitContainer_1.IsSplitterFixed = false;
				splitContainer_1.Panel2MinSize = control3_0.panel_0.Height + 5;
				splitContainer_1.SuspendLayout();
				splitContainer_1.SplitterDistance = (int)((float)splitContainer_1.Height * float_3);
				splitContainer_1.ResumeLayout(performLayout: true);
			}
			else
			{
				splitContainer_1.IsSplitterFixed = true;
				splitContainer_1.Panel2MinSize = 0;
				splitContainer_1.SuspendLayout();
				splitContainer_1.SplitterDistance = ClientSize.Height;
				splitContainer_1.ResumeLayout(performLayout: true);
			}
			bool_31 = false;
		}
	}

	private void splitContainer_0_SplitterMoved(object sender, SplitterEventArgs e)
	{
		if (!bool_31)
		{
			smethod_73();
		}
	}

	private void splitContainer_0_MouseMove(object sender, MouseEventArgs e)
	{
		if (class131_3.Visible && bool_30)
		{
			float_0 = (float)splitContainer_0.Panel1.Right / (float)splitContainer_0.Width;
		}
	}

	private void splitContainer_1_SplitterMoved(object sender, SplitterEventArgs e)
	{
		if (!bool_31)
		{
			smethod_73();
		}
	}

	private void splitContainer_1_MouseMove(object sender, MouseEventArgs e)
	{
		if (control3_0.Visible)
		{
			float_3 = (float)splitContainer_1.Panel1.Bottom / (float)splitContainer_1.Height;
		}
	}

	internal void method_120()
	{
		int selectedIndex = control25_0.SelectedIndex;
		form23_0.method_117();
		smethod_9();
		SuspendLayout();
		if (!bool_32)
		{
			bool_32 = true;
			WindowState = FormWindowState.Normal;
			FormBorderStyle = FormBorderStyle.None;
		}
		else
		{
			bool_32 = false;
			FormBorderStyle = FormBorderStyle.Sizable;
		}
		WindowState = FormWindowState.Maximized;
		ResumeLayout();
		Form23_Resize(null, null);
		smethod_10(bool_53: false);
		if (framework_1 != null && selectedIndex != -1)
		{
			control25_0.SelectedIndex = selectedIndex;
		}
	}

	private void method_121(Class5 class5_0)
	{
		if (!Class320.smethod_48(class5_0))
		{
			if (framework_1 != null)
			{
				method_117();
			}
			smethod_9();
			int byte_ = class5_0.byte_4;
			int byte_2 = class5_0.byte_5;
			byte[] byte_3 = class5_0.byte_16;
			Class14 class14_ = new Class14(class5_0.byte_0, class5_0.byte_1, class5_0.byte_2, class5_0.byte_3, class5_0.int_0);
			if (!bool_14 && method_122(class14_))
			{
				return;
			}
			string value = Class234.smethod_8(byte_, byte_2, class14_, byte_3, bool_0: true);
			if (!string.IsNullOrEmpty(value))
			{
				framework_1 = new Framework(value, byte_, byte_2, class14_);
				framework_1.aXc = class5_0.string_0;
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.ProgressChanged += smethod_69;
				backgroundWorker.DoWork += method_125;
				backgroundWorker.RunWorkerCompleted += method_126;
				smethod_66(Class333.smethod_1739());
				backgroundWorker.RunWorkerAsync(class5_0);
			}
			else if (class5_0.struct1_0[3].uint_1 != 0)
			{
				lock (object_1)
				{
					int_0 |= 128;
				}
				BackgroundWorker backgroundWorker2 = new BackgroundWorker();
				backgroundWorker2.WorkerReportsProgress = true;
				backgroundWorker2.ProgressChanged += smethod_69;
				backgroundWorker2.DoWork += method_201;
				backgroundWorker2.RunWorkerCompleted += method_202;
				smethod_66(Class333.smethod_1740());
				backgroundWorker2.RunWorkerAsync(class5_0);
			}
			else
			{
				BackgroundWorker backgroundWorker3 = new BackgroundWorker();
				backgroundWorker3.DoWork += Class229.smethod_44;
				backgroundWorker3.WorkerReportsProgress = true;
				backgroundWorker3.ProgressChanged += smethod_69;
				smethod_66(Class333.smethod_1390());
				BackgroundWorker backgroundWorker4 = new BackgroundWorker();
				backgroundWorker4.DoWork += method_46;
				backgroundWorker4.RunWorkerCompleted += method_123;
				backgroundWorker3.RunWorkerAsync();
				backgroundWorker4.RunWorkerAsync(class5_0);
				Class229.abM = true;
			}
			return;
		}
		lock (object_1)
		{
			int_0 &= -3;
		}
	}

	private bool method_122(Class14 class14_2)
	{
		if (!class14_2.method_7() && !Form59.smethod_2())
		{
			bool flag = false;
			if (Form54.smethod_6(this, Class333.smethod_1845() + class14_2.method_6() + Class333.smethod_1122(), Class333.smethod_1123(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
			{
				Form59 form = new Form59();
				form.ShowDialog(this);
				form.Dispose();
				if (Form59.smethod_2())
				{
					flag = true;
				}
			}
			if (!flag)
			{
				smethod_32(bool_53: true);
				return true;
			}
		}
		return false;
	}

	private void method_123(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct32 @struct = (Struct32)e.Result;
		Class5 bQP = @struct.BQP;
		smethod_68();
		if (@struct.BQQ != null && @struct.BQQ.Length != 0)
		{
			string[] bQQ = @struct.BQQ;
			foreach (string text in bQQ)
			{
				List<string> list;
				if (text.EndsWith(Class333.smethod_1402()))
				{
					list = new List<string>();
					list.Add(text);
				}
				else
				{
					list = Class234.smethod_13(text);
				}
				if (list.Count != 0 && method_124(text, bQP))
				{
					return;
				}
			}
		}
		string text2 = Class242.smethod_10(bQP.byte_4, bQP.byte_5);
		text2 = ((text2 != null) ? (Class333.smethod_1393() + text2 + Class333.smethod_1394()) : string.Empty);
		Class14 @class = new Class14(bQP.byte_0, bQP.byte_1, bQP.byte_2, bQP.byte_3, bQP.int_0);
		string text3 = Class333.smethod_1745() + text2 + Class333.smethod_1396() + @class.ToString();
		if (!bool_14 && Form54.smethod_6(this, text3 + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_124(openFileDialog_0.FileName, bQP))
			{
			}
		}
	}

	private bool method_124(string string_41, Class5 class5_0)
	{
		try
		{
			Class14 @class = new Class14(class5_0.byte_0, class5_0.byte_1, class5_0.byte_2, class5_0.byte_3, class5_0.int_0);
			int byte_ = class5_0.byte_4;
			int byte_2 = class5_0.byte_5;
			byte[] byte_3 = class5_0.byte_16;
			Class240 class2 = new Class240
			{
				axS = byte_,
				axs = byte_2,
				axT = @class,
				axt = byte_3
			};
			string text = null;
			bool flag;
			bool flag2;
			bool flag3;
			Class14 class3;
			if (string_41.EndsWith(Class333.smethod_1404()))
			{
				flag = Class320.smethod_12(string_41, class2, out flag2, out flag3, out class3, out text);
			}
			else
			{
				text = string_41;
				flag = Class234.smethod_5(string_41, class2, out flag2, out flag3, out class3);
			}
			if (flag && text != null)
			{
				framework_1 = new Framework(text, byte_, byte_2, @class);
				framework_1.aXc = class5_0.string_0;
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.ProgressChanged += smethod_69;
				backgroundWorker.DoWork += method_125;
				backgroundWorker.RunWorkerCompleted += method_126;
				smethod_66(Class333.smethod_1739());
				backgroundWorker.RunWorkerAsync(class5_0);
				return true;
			}
			if (!bool_14)
			{
				if (!(class3 == null) && text != null)
				{
					if (!flag2)
					{
						Form54.smethod_6(this, Class333.smethod_1746(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else if (!flag3)
					{
						Form54.smethod_6(this, Class333.smethod_1407() + class3.ToString() + Class333.smethod_1747() + @class.ToString() + Class333.smethod_9(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						Form54.smethod_6(this, Class333.smethod_1409(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				else
				{
					Form54.smethod_6(this, Class333.smethod_1405(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1846() + ex.Message);
		}
		return false;
	}

	private void method_125(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker obj = sender as BackgroundWorker;
		obj.ReportProgress(0);
		Thread.Sleep(100);
		obj.ReportProgress(30);
		Class237.Enum91 @enum = framework_1.method_1();
		obj.ReportProgress(80);
		if (@enum == Class237.Enum91.Brc && framework_1.awZ == 21)
		{
			framework_1.method_12();
		}
		obj.ReportProgress(90);
		Thread.Sleep(100);
		obj.ReportProgress(100);
		e.Result = new Class216
		{
			BQq = (e.Argument as Class5),
			BQR = @enum
		};
	}

	private void method_126(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		Class216 obj = e.Result as Class216;
		Class237.Enum91 bQR = obj.BQR;
		Class5 bQq = obj.BQq;
		if (bQR == Class237.Enum91.Brc)
		{
			method_181(null, -1);
			return;
		}
		string empty = string.Empty;
		switch (bQR)
		{
		case Class237.Enum91.BrD:
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += Class229.smethod_44;
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.ProgressChanged += smethod_69;
			smethod_66(Class333.smethod_1390());
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += method_51;
			backgroundWorker2.RunWorkerCompleted += method_127;
			Class213 argument = new Class213
			{
				BpW = bQq,
				Bpv = framework_1
			};
			backgroundWorker.RunWorkerAsync();
			backgroundWorker2.RunWorkerAsync(argument);
			Class229.abM = true;
			return;
		}
		case Class237.Enum91.Brd:
			empty = Class333.smethod_1391();
			break;
		case Class237.Enum91.BrE:
			empty = Class333.smethod_1392();
			break;
		case Class237.Enum91.Bre:
			empty = Class333.smethod_1749() + framework_1.aXA.ToString();
			break;
		default:
			empty = Class333.smethod_1750() + framework_1.aXA.ToString();
			break;
		}
		if (!bool_14 && Form54.smethod_6(this, empty + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_128(openFileDialog_0.FileName, bQq))
			{
			}
		}
	}

	private void method_127(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct31 @struct = (Struct31)e.Result;
		smethod_68();
		if (@struct.BQo != null && @struct.BQo.Length != 0)
		{
			string[] bQo = @struct.BQo;
			foreach (string text in bQo)
			{
				List<string> list;
				if (text.EndsWith(Class333.smethod_1402()))
				{
					list = new List<string>();
					list.Add(text);
				}
				else
				{
					list = Class234.smethod_13(text);
				}
				if (list.Count != 0 && method_128(text, @struct.BQN))
				{
					return;
				}
			}
		}
		if (bool_14)
		{
			return;
		}
		string text2 = Class242.smethod_10(@struct.BQn.awZ, @struct.BQn.awz);
		string text3 = string.Concat(str1: (text2 != null) ? (Class333.smethod_1393() + text2 + Class333.smethod_1394()) : string.Empty, str0: Class333.smethod_1403(), str2: Class333.smethod_1396(), str3: @struct.BQn.aXA.ToString());
		if (Form54.smethod_6(this, text3 + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_128(openFileDialog_0.FileName, @struct.BQN))
			{
			}
		}
	}

	private bool method_128(string string_41, Class5 class5_0)
	{
		try
		{
			Class240 @class = new Class240
			{
				axS = framework_1.awZ,
				axs = framework_1.awz,
				axT = framework_1.aXA,
				axt = class5_0.byte_16
			};
			string text = null;
			bool flag;
			bool flag2;
			bool flag3;
			Class14 class2;
			if (string_41.EndsWith(Class333.smethod_1404()))
			{
				flag = Class320.smethod_12(string_41, @class, out flag2, out flag3, out class2, out text);
			}
			else
			{
				text = string_41;
				flag = Class234.smethod_5(string_41, @class, out flag2, out flag3, out class2);
			}
			if (flag && text != null)
			{
				framework_1 = new Framework(text, framework_1.awZ, framework_1.awz, class2);
				framework_1.aXc = class5_0.string_0;
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.ProgressChanged += smethod_69;
				backgroundWorker.DoWork += method_125;
				backgroundWorker.RunWorkerCompleted += method_126;
				smethod_66(Class333.smethod_1739());
				backgroundWorker.RunWorkerAsync(class5_0);
				return true;
			}
			if (!bool_14)
			{
				if (!(class2 == null) && text != null)
				{
					if (!flag2)
					{
						Form54.smethod_6(this, Class333.smethod_1746(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else if (!flag3)
					{
						Form54.smethod_6(this, Class333.smethod_1407() + class2.ToString() + Class333.smethod_1747() + framework_1.aXA.ToString() + Class333.smethod_9(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						Form54.smethod_6(this, Class333.smethod_1409(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				else
				{
					Form54.smethod_6(this, Class333.smethod_1405(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1847() + ex.Message);
		}
		return false;
	}

	internal static void smethod_74(int int_49)
	{
		smethod_75(new DataIdAndAttrId(int_49));
	}

	internal static void smethod_75(DataIdAndAttrId dataIdAndAttrId_1)
	{
		if (framework_1 == null)
		{
			return;
		}
		Setting setting = framework_1.method_32(dataIdAndAttrId_1);
		if (setting != null)
		{
			bool flag = false;
			if (setting.method_6() != null && !setting.method_68())
			{
				if (setting.method_6() is TableAxis)
				{
					flag = true;
				}
				else if (setting.method_6() is Table)
				{
					flag = true;
					if ((setting.method_6() as Table).ColumnAxis != null && ((setting.method_6() as Table).ColumnAxis.method_76() || (setting.method_6() as Table).ColumnAxis.method_78()))
					{
						flag = false;
						dataIdAndAttrId_0 = dataIdAndAttrId_1;
					}
					else if ((setting.method_6() as Table).RowAxis != null && ((setting.method_6() as Table).RowAxis.method_76() || (setting.method_6() as Table).RowAxis.method_78()))
					{
						flag = false;
						dataIdAndAttrId_0 = dataIdAndAttrId_1;
					}
				}
			}
			bool flag2 = !setting.method_68() && setting.method_6() is SensorCalibration && setting != (setting.method_6() as SensorCalibration).CalibrationValueCountSetting;
			if (!flag && !flag2 && !hashSet_3.Contains(dataIdAndAttrId_1))
			{
				hashSet_3.Add(dataIdAndAttrId_1);
			}
		}
		if (framework_0 != null)
		{
			hashSet_4.Add(dataIdAndAttrId_1);
		}
		else if (hashSet_4.Count != 0)
		{
			hashSet_4.Clear();
		}
		hashSet_5.Add(dataIdAndAttrId_1);
	}

	internal static void smethod_76()
	{
		bool_36 = true;
	}

	internal static bool smethod_77()
	{
		if (hashSet_3.Count == 0)
		{
			return bool_36;
		}
		return true;
	}

	private void method_129()
	{
		if (!bool_14)
		{
			timer_3.Interval = 40.0;
			timer_3.SynchronizingObject = this;
			timer_3.Elapsed += method_130;
			timer_3.AutoReset = true;
			timer_3.Enabled = true;
			timer_3.Start();
		}
	}

	private void method_130(object sender, ElapsedEventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate111 method = method_130;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (WindowState != FormWindowState.Minimized)
		{
			int_34 = ClientSize.Width;
			int_35 = ClientSize.Height;
			int_36 = Location.X;
			int_37 = Location.Y;
			formWindowState_0 = WindowState;
		}
		bool lockTaken = false;
		if (control4_0.method_3())
		{
			return;
		}
		try
		{
			Monitor.TryEnter(object_3, ref lockTaken);
			if (!lockTaken)
			{
				return;
			}
			timer_3.Stop();
			timer_3.Enabled = false;
			if (!stopwatch_1.IsRunning)
			{
				stopwatch_1.Start();
			}
			else
			{
				int num = (int)stopwatch_1.ElapsedMilliseconds;
				if (num != 0)
				{
					int num2 = 1000 / num;
					if ((int_0 & 0x200) == 0)
					{
						Class23.smethod_3(string.Format(Class333.smethod_1848(), num2), bool_1: false);
					}
					stopwatch_1.Restart();
				}
			}
			if (framework_1 != null && framework_1.method_5() && ((int_0 & 1) != 0 || (int_0 & 0x1000) != 0))
			{
				for (int i = 0; i < framework_1.aWt.Count; i++)
				{
					framework_1.aWt[i].method_269();
				}
				if ((int_0 & 0x1000) == 0)
				{
					framework_1.method_67();
				}
			}
			method_134();
			method_136();
			method_137();
			method_138();
			method_132();
			method_221();
			class164_0.method_4();
			class165_0.method_4();
			class170_0.method_4();
			class162_0.method_8();
			control25_0.method_34();
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			Update();
			stopwatch.Stop();
			if ((int_0 & 0x200) == 0)
			{
				Class23.smethod_3(string.Format(Class333.smethod_1849(), stopwatch.ElapsedMilliseconds), bool_1: false);
			}
			if ((Control.ModifierKeys & Keys.Alt) == 0 && bool_33)
			{
				if (control4_0.Visible)
				{
					control4_0.Visible = false;
					smethod_73();
				}
				bool_33 = false;
			}
			else if (bool_44)
			{
				method_215(bool_53: false);
				bool_44 = false;
			}
			else if (bool_35)
			{
				smethod_10(bool_53: false);
				bool_35 = false;
			}
			else
			{
				if (framework_1 == null)
				{
					return;
				}
				if (framework_0 == null && hashSet_4.Count != 0)
				{
					hashSet_4.Clear();
				}
				if (control4_0.method_0().method_2().Count != 0 && bool_29)
				{
					smethod_63();
					bool_29 = false;
				}
				else if (!smethod_77() && hashSet_4.Count == 0 && hashSet_5.Count == 0)
				{
					if (control4_0.method_0().method_2().Count != 0)
					{
						if (bool_26)
						{
							smethod_43();
							bool_26 = false;
							return;
						}
						if (bool_34)
						{
							if (framework_1.awh != null && framework_1.awh.method_13() != null)
							{
								framework_1.awh.method_13().AddMissingRecommendedLogChannels();
							}
							bool_34 = false;
							return;
						}
						if (dataIdAndAttrId_0.DataId != 0 || bool_3)
						{
							control25_0.method_27();
						}
						dataIdAndAttrId_0 = new DataIdAndAttrId(0, 0);
						bool_3 = false;
					}
					smethod_6(bool_53: false);
					method_219();
				}
				else
				{
					method_131();
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(object_3);
				timer_3.Enabled = true;
				timer_3.Start();
			}
		}
	}

	internal void method_131()
	{
		if (framework_1 == null)
		{
			return;
		}
		bool flag = false;
		if (smethod_77())
		{
			flag = framework_1.method_42(bool_36 ? null : hashSet_3);
		}
		if (hashSet_4.Count != 0 || bool_36)
		{
			framework_1.method_40(bool_36 ? null : hashSet_4, framework_0, hashSet_0);
		}
		bool flag2 = false;
		if (hashSet_5.Count != 0 || bool_36)
		{
			flag2 = framework_1.method_38(bool_36 ? null : hashSet_5);
		}
		if (control4_0 != null && control4_0.method_0().method_2().Count != 0 && ((flag || hashSet_4.Count != 0) | flag2))
		{
			if (smethod_77())
			{
				control4_0.method_14(bool_7: false, bool_8: true, bool_9: true, bool_10: false);
				smethod_43();
				bool_26 = false;
				control4_0.method_39(bool_7: true);
			}
			else
			{
				control4_0.method_14(bool_7: false, bool_8: true, bool_9: false, bool_10: false);
				control4_0.method_39(bool_7: false);
			}
			if (hashSet_4.Count != 0)
			{
				control4_0.method_40(bool_7: true);
			}
			else
			{
				control4_0.method_40(bool_7: false);
			}
			smethod_6();
		}
		bool_36 = false;
		hashSet_3.Clear();
		hashSet_4.Clear();
		hashSet_5.Clear();
	}

	private void method_132()
	{
		bool num = (int_0 & 0x20) != 0 || (int_0 & 8) != 0 || (int_0 & 0x10) != 0 || (stopwatch_0.IsRunning && stopwatch_0.ElapsedMilliseconds < 500L);
		bool flag = (int_0 & 1) == 0 && Class1.smethod_3() && Class1.smethod_27().Count == 0;
		class167_0.method_11(flag);
		if (((num || bool_37) | flag) || bool_38)
		{
			class167_0.Invalidate();
		}
		bool_37 = num;
		bool_38 = flag;
		class166_0.Invalidate();
		bool flag2 = (int_0 & 0x1000) != 0;
		if ((int_0 & 1) != 0 && list_2.Count == 1)
		{
			Class5 bpS = list_2[0].BpS;
			Enum11 @enum = Class1.smethod_25(bpS.string_0);
			switch (@enum)
			{
			case Enum11.const_1:
				if (flag2)
				{
					class167_0.method_8();
				}
				else if (Class1.smethod_20(bpS.string_0))
				{
					class167_0.method_9();
				}
				else
				{
					class167_0.method_10();
				}
				break;
			case Enum11.const_0:
			case Enum11.const_2:
			case Enum11.const_3:
				if (smethod_80())
				{
					if (flag2)
					{
						class167_0.method_4();
					}
					else
					{
						class167_0.method_3();
					}
				}
				else if (flag2)
				{
					class167_0.method_5();
				}
				else if (Class1.smethod_20(bpS.string_0))
				{
					class167_0.method_6();
				}
				else
				{
					class167_0.method_7();
				}
				break;
			}
			if ((int_0 & 0x40) == 0 && (int_0 & 0x20) == 0)
			{
				if ((int_0 & 0x100) == 0 && (int_0 & 0x200) == 0)
				{
					if (framework_1 == null || framework_1.method_4())
					{
						toolStripMenuItem_9.Enabled = !panel_1.Visible && !panel_2.Visible && list_2.Count == 1 && @enum != Enum11.const_1;
						class169_0.Enabled = toolStripMenuItem_9.Enabled;
					}
					toolStripMenuItem_23.Enabled = framework_1 != null && framework_1.awZ != 21 && bpS.struct1_0[34].uint_1 != 0;
					toolStripButton_5.Enabled = toolStripMenuItem_23.Enabled;
					toolStripMenuItem_24.Enabled = framework_1 != null && framework_1.method_31(20069) != null && framework_1.method_31(20070) != null && bpS.struct1_0[34].uint_1 != 0;
					toolStripButton_14.Enabled = toolStripMenuItem_24.Enabled;
					method_133(bpS, framework_1 != null, (int_0 & 0x1000) == 0);
					if ((int_0 & 0x10) == 0)
					{
						class168_0.Enabled = true;
						class168_0.method_2();
						toolStripMenuItem_27.Enabled = true;
					}
					else
					{
						class168_0.Enabled = false;
						class168_0.method_1();
						toolStripMenuItem_27.Enabled = false;
					}
					toolStripMenuItem_31.Enabled = framework_1 != null && framework_1.awm != null && framework_1.method_4();
					label_0.Visible = false;
					return;
				}
				if ((int_0 & 0x100) != 0)
				{
					if (!label_0.Visible)
					{
						label_0.Visible = true;
						label_0.BringToFront();
					}
					toolStripMenuItem_9.Enabled = (int_0 & 0x200) == 0 && !panel_1.Visible && !panel_2.Visible && list_2.Count == 1 && @enum != Enum11.const_1;
				}
				else
				{
					toolStripMenuItem_9.Enabled = false;
				}
				class169_0.Enabled = toolStripMenuItem_9.Enabled;
				toolStripMenuItem_23.Enabled = false;
				toolStripButton_5.Enabled = false;
				toolStripMenuItem_24.Enabled = false;
				toolStripButton_14.Enabled = false;
				class168_0.Enabled = false;
				class168_0.method_1();
				toolStripMenuItem_27.Enabled = false;
				method_133(bpS, bool_53: false, bool_54: false);
				toolStripMenuItem_31.Enabled = false;
			}
			else
			{
				toolStripMenuItem_9.Enabled = false;
				class169_0.Enabled = false;
				class168_0.Enabled = false;
				class168_0.method_1();
				toolStripMenuItem_27.Enabled = false;
				toolStripMenuItem_23.Enabled = false;
				toolStripButton_5.Enabled = false;
				toolStripMenuItem_24.Enabled = false;
				toolStripButton_14.Enabled = false;
				method_133(bpS, bool_53: false, bool_54: false);
				toolStripMenuItem_31.Enabled = false;
			}
		}
		else
		{
			if (flag2)
			{
				class167_0.method_2();
			}
			else
			{
				class167_0.method_1();
			}
			toolStripMenuItem_9.Enabled = false;
			class169_0.Enabled = false;
			class168_0.Enabled = false;
			class168_0.method_1();
			toolStripMenuItem_27.Enabled = false;
			toolStripMenuItem_23.Enabled = framework_1 != null && framework_1.awZ != 21;
			toolStripButton_5.Enabled = toolStripMenuItem_23.Enabled;
			toolStripMenuItem_24.Enabled = false;
			toolStripButton_14.Enabled = false;
			method_133(null, bool_53: false, bool_54: false);
			toolStripMenuItem_31.Enabled = false;
			label_0.Visible = false;
		}
	}

	private void method_133(Class5 class5_0, bool bool_53, bool bool_54)
	{
		toolStripMenuItem_52.Enabled = bool_53;
		toolStripMenuItem_54.Enabled = bool_53;
		toolStripMenuItem_55.Enabled = bool_53;
		toolStripMenuItem_56.Enabled = bool_53;
		toolStripMenuItem_53.Enabled = bool_53;
		toolStripMenuItem_50.Enabled = bool_53;
		toolStripMenuItem_15.Enabled = true;
		toolStripMenuItem_14.Enabled = bool_54;
	}

	private void method_134()
	{
		if (framework_1 == null || string_20 != null || !Class1.smethod_21(framework_1.aXc) || Class1.smethod_20(framework_1.aXc) || (form62_0 != null && !form62_0.IsDisposed && form62_0.Visible))
		{
			return;
		}
		string_20 = framework_1.aXc;
		method_132();
		form63_0 = new Form63();
		if (form63_0.ShowDialog(this) == DialogResult.Cancel)
		{
			Class1.smethod_17(framework_1.aXc);
			if (Class1.smethod_27().Count == 0)
			{
				smethod_32(bool_53: true);
			}
		}
		string_20 = null;
		form63_0.Dispose();
	}

	private void method_135()
	{
		if (framework_1 == null || !framework_1.method_5() || !framework_1.method_9() || string_20 != null || !smethod_28(framework_1.aXc, bool_53: true))
		{
			return;
		}
		lock (framework_1.method_25())
		{
			if (framework_1.method_25().Count == 0)
			{
				return;
			}
			method_132();
			Setting setting = framework_1.method_25()[0];
			string text2;
			if (setting.method_6() is Table && setting == (setting.method_6() as Table).TableDataSetting)
			{
				string text = setting.method_6().method_60(Enum96.aYt);
				text2 = Class333.smethod_1850() + text + Class333.smethod_1851();
			}
			else if (setting.method_277() > 1)
			{
				string text3 = setting.method_60(Enum96.aYt);
				text2 = Class333.smethod_1852() + text3 + Class333.smethod_1853();
			}
			else
			{
				string text4 = setting.method_60(Enum96.aYt);
				(string, string, bool) tuple = setting.method_252();
				text2 = Class333.smethod_1854() + text4 + Class333.smethod_1855() + tuple.Item1 + Class333.smethod_1856();
			}
			if (Form54.smethod_7(this, text2, Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, new string[2]
			{
				Class333.smethod_1857(),
				Class333.smethod_1858()
			}) == DialogResult.Yes)
			{
				for (int i = 0; i < setting.method_278(); i++)
				{
					if (framework_1.method_22()[setting.method_65() + i] != Enum93.aYk)
					{
						framework_1.method_22()[setting.method_65() + i] = Enum93.aYK;
					}
				}
			}
			else
			{
				for (int j = 0; j < setting.method_278(); j++)
				{
					framework_1.method_22()[setting.method_65() + j] = Enum93.aYj;
				}
				framework_1.aXd = true;
			}
			framework_1.method_25().RemoveAt(0);
		}
	}

	private void method_136()
	{
		if (framework_1 == null || !framework_1.method_5() || !framework_1.method_9() || string_20 != null || !smethod_28(framework_1.aXc, bool_53: true))
		{
			return;
		}
		lock (framework_1.method_26())
		{
			if (framework_1.method_26().Count == 0)
			{
				return;
			}
			method_132();
			Setting setting = framework_1.method_26()[0];
			if (!setting.method_219() && setting.method_220() && framework_1.aWX && setting.method_244() != null)
			{
				smethod_88();
				string text2;
				if (setting.method_6() is Table && setting == (setting.method_6() as Table).TableDataSetting)
				{
					string text = setting.method_6().method_60(Enum96.aYt);
					text2 = Class333.smethod_1859() + text + Class333.smethod_1860();
				}
				else if (setting.method_277() > 1)
				{
					string text3 = setting.method_60(Enum96.aYt);
					text2 = Class333.smethod_1861() + text3 + Class333.smethod_1862();
				}
				else
				{
					string text4 = setting.method_60(Enum96.aYt);
					text2 = Class333.smethod_1863() + text4 + Class333.smethod_1864();
				}
				Form54.smethod_6(this, text2, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				for (int i = 0; i < setting.method_242()[0]; i++)
				{
					for (int j = 0; j < setting.method_242()[1]; j++)
					{
						for (int k = 0; k < setting.method_242()[2]; k++)
						{
							int num = Class23.smethod_5(setting.method_244(), setting.method_251(k, j, i), setting.method_199(), setting.method_201(), setting.method_0().aWR);
							if (setting.method_257(k, j, i) != num)
							{
								setting.method_273(k, j, i, num, bool_0: true);
							}
						}
					}
				}
				smethod_75(setting.method_69());
			}
			framework_1.method_26().RemoveAt(0);
		}
	}

	private void method_137()
	{
		if (Class320.BdO || framework_1 == null || !framework_1.method_5())
		{
			return;
		}
		Class5 @class = Class1.smethod_26(framework_1.aXc);
		if (@class == null)
		{
			return;
		}
		bool flag = (int_0 & 0x100) != 0;
		if (Class320.smethod_48(@class) && !flag)
		{
			if (!label_0.Visible)
			{
				label_0.Visible = true;
				label_0.BringToFront();
			}
			string text = smethod_88();
			framework_1.aXd = false;
			if (Form54.smethod_6(this, Class333.smethod_1865() + text + Class333.smethod_1866(), Class333.smethod_1383(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				method_80(text);
			}
		}
	}

	private void method_138()
	{
		if (!((DateTime.Now - dateTime_1).TotalMilliseconds > 2000.0))
		{
			return;
		}
		bool flag = (int_0 & 1) != 0;
		bool flag2 = Class1.smethod_3();
		if (!flag && !flag2)
		{
			bool_39 = false;
		}
		else if ((!flag & flag2) && Class1.smethod_27().Count == 0)
		{
			try
			{
				bool flag3 = false;
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					if (driveInfo.DriveType == DriveType.Removable && Directory.Exists(driveInfo.Name + Class333.smethod_1867()) && Directory.Exists(driveInfo.Name + Class333.smethod_1868()))
					{
						flag3 = true;
						break;
					}
				}
				if (flag3)
				{
					if (!bool_39)
					{
						Form54.smethod_6(this, Class333.smethod_1869(), Class333.smethod_1870(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						bool_39 = true;
					}
				}
				else
				{
					bool_39 = false;
				}
			}
			catch
			{
			}
		}
		dateTime_1 = DateTime.Now;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_78(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_4;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_79(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_4;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal static bool smethod_80()
	{
		bool flag;
		if (list_2.Count == 1 && list_2[0].BpS.byte_4 == 22)
		{
			flag = false;
		}
		else if (framework_1 != null && framework_1.method_5())
		{
			Setting setting = framework_1.method_31(10197);
			flag = setting != null && setting.method_256() == 0;
		}
		else
		{
			flag = false;
		}
		if (bool_40 != flag)
		{
			bool_40 = flag;
			if (eventHandler_4 != null)
			{
				eventHandler_4(null, null);
			}
		}
		return flag;
	}

	internal void toolStripButton_0_Click(object sender, EventArgs e)
	{
		if (smethod_87(this, bool_53: true) != DialogResult.Cancel)
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.DoWork += method_139;
			backgroundWorker.ProgressChanged += smethod_69;
			backgroundWorker.RunWorkerCompleted += method_140;
			smethod_66(Class333.smethod_1871());
			backgroundWorker.RunWorkerAsync();
		}
	}

	private void method_139(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		int num = 0;
		do
		{
			num = Math.Min(Class234.avj, Class229.abO);
			backgroundWorker.ReportProgress(num * 80 / 100);
		}
		while (num < 100);
		Class234.smethod_6();
		backgroundWorker.ReportProgress(100);
		Thread.Sleep(200);
	}

	private void method_140(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		Form26 form = new Form26();
		if (form.ShowDialog(this) == DialogResult.OK)
		{
			Class239 @class = Class234.smethod_0(form.method_0());
			Class240 class2 = null;
			if (@class != null)
			{
				byte[] array = Class23.smethod_16(form.method_0());
				if (array != null)
				{
					class2 = new Class240
					{
						axS = @class.axq,
						axs = @class.axR,
						axT = @class.axr,
						axt = array
					};
				}
			}
			if (class2 != null)
			{
				method_142(form.method_0(), class2);
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1872(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		form.Dispose();
	}

	private void method_141(object sender, EventArgs e)
	{
		if (smethod_87(this, bool_53: true) == DialogResult.Cancel)
		{
			return;
		}
		Class234.smethod_6();
		if (openFileDialog_0.ShowDialog(this) != DialogResult.OK)
		{
			return;
		}
		string string_ = openFileDialog_0.FileName;
		Class240 @class = null;
		if (openFileDialog_0.FileName.EndsWith(Class333.smethod_1404()))
		{
			List<Class314> list = Class320.smethod_8(openFileDialog_0.FileName);
			if (list.Count > 1)
			{
				Form form = new Form();
				form.Font = form23_0.Font;
				form.BackColor = color_10;
				form.ForeColor = color_12;
				form.Text = Class333.smethod_1873();
				form.FormBorderStyle = FormBorderStyle.FixedDialog;
				form.MinimizeBox = false;
				form.MaximizeBox = false;
				form.ShowIcon = false;
				form.ShowInTaskbar = false;
				form.StartPosition = FormStartPosition.CenterParent;
				foreach (Class314 item in list)
				{
					if (item.BDy != null)
					{
						RadioButton radioButton = new RadioButton();
						radioButton.Tag = item;
						radioButton.ForeColor = color_12;
						radioButton.Text = Class242.smethod_10(item.BDy.axS, item.BDy.axs);
						radioButton.Checked = false;
						radioButton.AutoSize = false;
						radioButton.Height = 20;
						radioButton.Width = 230;
						radioButton.Location = new Point(10, 10 + list.IndexOf(item) * 20);
						form.Controls.Add(radioButton);
					}
				}
				ThemedButton themedButton = new ThemedButton();
				themedButton.DialogResult = DialogResult.Cancel;
				themedButton.Text = Class333.smethod_823();
				themedButton.Size = new Size(80, 30);
				themedButton.Location = new Point(160, list.Count * 20 + 25);
				ThemedButton themedButton2 = new ThemedButton();
				themedButton2.DialogResult = DialogResult.OK;
				themedButton2.Text = Class333.smethod_821();
				themedButton2.Size = new Size(80, 30);
				themedButton2.Location = new Point(themedButton.Left - (10 + themedButton2.Width), list.Count * 20 + 25);
				form.CancelButton = themedButton;
				form.ClientSize = new Size(250, list.Count * 20 + 65);
				form.Controls.Add(themedButton2);
				form.Controls.Add(themedButton);
				if (form.ShowDialog(form23_0) == DialogResult.OK)
				{
					foreach (Control control in form.Controls)
					{
						if (control is RadioButton && (control as RadioButton).Checked)
						{
							Class314 class2 = (control as RadioButton).Tag as Class314;
							@class = class2.BDy;
							int index = list.IndexOf(class2);
							string_ = list[index].BdA;
							break;
						}
					}
				}
				form.Dispose();
			}
			else if (list.Count == 1)
			{
				@class = list[0].BDy;
				string_ = list[0].BdA;
			}
		}
		else
		{
			Class239 class3 = Class234.smethod_0(string_);
			if (class3 != null)
			{
				byte[] array = Class23.smethod_16(string_);
				if (array != null)
				{
					@class = new Class240
					{
						axS = class3.axq,
						axs = class3.axR,
						axT = class3.axr,
						axt = array
					};
				}
			}
		}
		if (@class != null)
		{
			method_142(string_, @class);
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_1872(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_142(string string_41, Class240 class240_1)
	{
		smethod_32(bool_53: true);
		method_117();
		smethod_9();
		framework_1 = new Framework(string_41, class240_1.axS, class240_1.axs, class240_1.axT);
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.DoWork += method_143;
		backgroundWorker.ProgressChanged += smethod_69;
		backgroundWorker.RunWorkerCompleted += method_144;
		smethod_66(Class333.smethod_1874());
		backgroundWorker.RunWorkerAsync();
	}

	private void method_143(object sender, DoWorkEventArgs e)
	{
		Class23.smethod_3(Class333.smethod_1875());
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		e.Result = framework_1.method_1();
		backgroundWorker.ReportProgress(40);
		if ((Class237.Enum91)e.Result == Class237.Enum91.Brc)
		{
			framework_1.method_15(framework_1.aWS);
			backgroundWorker.ReportProgress(60);
			framework_1.method_58();
			framework_1.method_37(framework_1.awj);
			framework_1.method_42(null);
			framework_1.method_40(null, framework_0, hashSet_0);
			framework_1.method_38(null);
			if (framework_1.awZ == 21)
			{
				backgroundWorker.ReportProgress(80);
				if (framework_1.method_12())
				{
					Class329.smethod_0(framework_1, null);
					Class329.smethod_5();
					if (framework_1.awP.method_98())
					{
						Class329.smethod_10();
					}
				}
			}
			backgroundWorker.ReportProgress(90);
		}
		Thread.Sleep(100);
		backgroundWorker.ReportProgress(100);
	}

	private void method_144(object sender, RunWorkerCompletedEventArgs e)
	{
		Class23.smethod_3(Class333.smethod_1876());
		smethod_68();
		Class237.Enum91 @enum = (Class237.Enum91)e.Result;
		if (@enum == Class237.Enum91.Brc)
		{
			Form48.smethod_1(framework_1, out var flag, out var _, out var flag3);
			if (!flag && !flag3 && smethod_10(bool_53: true))
			{
				toolStripMenuItem_39.Enabled = true;
				toolStripButton_11.Enabled = true;
				toolStripMenuItem_38.Enabled = true;
				toolStripMenuItem_8.Enabled = true;
				toolStripMenuItem_41.Enabled = true;
				toolStripMenuItem_42.Enabled = true;
				class163_0.Enabled = true;
				toolStripButton_1.Enabled = true;
				toolStripMenuItem_6.Enabled = true;
				toolStripButton_4.Enabled = true;
				toolStripMenuItem_10.Enabled = true;
				toolStripButton_7.Enabled = true;
				toolStripMenuItem_58.Enabled = true;
				toolStripMenuItem_59.Enabled = true;
				toolStripDropDownButton_0.Enabled = true;
				toolStripMenuItem_31.Enabled = false;
				string_19 = string.Empty;
				smethod_6();
				smethod_19(string_10, out var _);
			}
			return;
		}
		string empty = string.Empty;
		switch (@enum)
		{
		case Class237.Enum91.BrD:
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += Class229.smethod_44;
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.ProgressChanged += smethod_69;
			smethod_66(Class333.smethod_1390());
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += method_145;
			backgroundWorker2.RunWorkerCompleted += method_146;
			backgroundWorker.RunWorkerAsync();
			backgroundWorker2.RunWorkerAsync(framework_1);
			Class229.abM = true;
			return;
		}
		case Class237.Enum91.Brd:
			empty = Class333.smethod_1391();
			break;
		case Class237.Enum91.BrE:
			empty = Class333.smethod_1392();
			break;
		default:
		{
			string text = Class242.smethod_10(framework_1.awZ, framework_1.awz);
			text = ((text != null) ? (Class333.smethod_1393() + text + Class333.smethod_1394()) : string.Empty);
			empty = ((@enum != Class237.Enum91.Bre) ? (Class333.smethod_1397() + text + Class333.smethod_1396() + framework_1.aXA.ToString()) : (Class333.smethod_1395() + text + Class333.smethod_1396() + framework_1.aXA.ToString()));
			break;
		}
		}
		if (!bool_14 && Form54.smethod_6(this, empty + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_147(openFileDialog_0.FileName))
			{
			}
		}
	}

	private void method_145(object sender, DoWorkEventArgs e)
	{
		Framework framework = (Framework)e.Argument;
		string text = Class320.smethod_13(new Class240
		{
			axS = framework.awZ,
			axs = framework.awz,
			axT = framework.aXA,
			axt = framework.method_11()
		}, ushort.MaxValue);
		string[] bQS = Class229.smethod_46(framework.aXA, framework.awZ, framework.awz, text, out var nullable_, out var updateOutcomes_);
		Struct33 @struct = default;
		if (nullable_.HasValue && updateOutcomes_ == UpdateOutcomes.CompleteUpdate)
		{
			@struct.BQr = updateOutcomes_;
			@struct.BQS = bQS;
		}
		e.Result = @struct;
	}

	private void method_146(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct33 @struct = (Struct33)e.Result;
		smethod_68();
		if (@struct.BQS != null && @struct.BQS.Length != 0)
		{
			string[] bQS = @struct.BQS;
			foreach (string text in bQS)
			{
				List<string> list;
				if (text.EndsWith(Class333.smethod_1402()))
				{
					list = new List<string>();
					list.Add(text);
				}
				else
				{
					list = Class234.smethod_13(text);
				}
				if (list.Count != 0 && method_147(text))
				{
					return;
				}
			}
		}
		string text2 = Class242.smethod_10(framework_1.awZ, framework_1.awz);
		string text3 = string.Concat(str1: (text2 != null) ? (Class333.smethod_1393() + text2 + Class333.smethod_1394()) : string.Empty, str0: Class333.smethod_1403(), str2: Class333.smethod_1396(), str3: framework_1.aXA.ToString());
		if (!bool_14 && Form54.smethod_6(this, text3 + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_147(openFileDialog_0.FileName))
			{
			}
		}
	}

	private bool method_147(string string_41)
	{
		try
		{
			Class240 @class = null;
			string text = null;
			if (string_41.EndsWith(Class333.smethod_1404()))
			{
				List<Class314> list = Class320.smethod_8(string_41);
				if (list.Count != 0)
				{
					if (list.Count != 1)
					{
						if (!bool_14)
						{
							Form54.smethod_6(this, Class333.smethod_1877(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
						return false;
					}
					@class = list[0].BDy;
					text = list[0].BdA;
				}
			}
			else
			{
				text = string_41;
				Class239 class2 = Class234.smethod_0(text);
				if (class2 != null)
				{
					byte[] array = Class23.smethod_16(text);
					if (array != null)
					{
						@class = new Class240
						{
							axS = class2.axq,
							axs = class2.axR,
							axT = class2.axr,
							axt = array
						};
					}
				}
			}
			if (@class != null && text != null)
			{
				method_142(text, @class);
				return true;
			}
			if (!bool_14)
			{
				Form54.smethod_6(this, Class333.smethod_1405(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1878() + ex.Message);
		}
		return false;
	}

	private void method_148(string string_41)
	{
		if (smethod_87(this, bool_53: true) == DialogResult.Cancel)
		{
			return;
		}
		try
		{
			Class240 @class = Class296.smethod_0(string_41);
			if (!(@class != null))
			{
				throw new Exception();
			}
			method_152(null, string_41, @class);
			class301_0.method_3(string_41);
		}
		catch
		{
			class301_0.method_5(string_41);
			Form54.smethod_6(this, Class333.smethod_1369(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal void method_149(string string_41)
	{
		if (smethod_87(this, bool_53: true) != DialogResult.Cancel)
		{
			method_150(string_41);
		}
	}

	internal void toolStripButton_6_Click(object sender, EventArgs e)
	{
		if (smethod_87(this, bool_53: true) != DialogResult.Cancel)
		{
			openFileDialog_1.Title = Class333.smethod_1266();
			openFileDialog_1.Filter = Class242.smethod_5();
			if (openFileDialog_1.ShowDialog(this) == DialogResult.OK)
			{
				method_150(openFileDialog_1.FileName);
			}
		}
	}

	internal void method_150(string string_41)
	{
		Class240 @class = Class296.smethod_0(string_41);
		if (@class != null)
		{
			bool flag = false;
			bool flag2 = false;
			if (Class242.smethod_12(@class.axS) && @class.axT.method_0() < 3)
			{
				flag = true;
				if (Form54.smethod_4(this, Class333.smethod_1879(), Class333.smethod_1880(), MessageBoxButtons.OKCancel) == DialogResult.Cancel)
				{
					flag2 = true;
				}
			}
			if (!flag2)
			{
				method_152(null, string_41, @class);
				if (!flag)
				{
					class301_0.method_3(string_41);
				}
			}
		}
		else
		{
			class301_0.method_5(string_41);
			Form54.smethod_6(this, Class333.smethod_1369(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_151(object sender, EventArgs e)
	{
		if (smethod_87(this, bool_53: true) == DialogResult.Cancel)
		{
			return;
		}
		openFileDialog_1.Title = Class333.smethod_1266();
		openFileDialog_1.Filter = string.Empty;
		if (openFileDialog_1.ShowDialog(this) == DialogResult.OK)
		{
			Class240 @class = Class296.smethod_0(openFileDialog_1.FileName);
			if (@class != null)
			{
				method_152(null, openFileDialog_1.FileName, @class);
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1369(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}

	internal void method_152(string string_41, string string_42, Class240 class240_1)
	{
		smethod_32(bool_53: true);
		method_117();
		smethod_9();
		if (!class240_1.axT.method_7() && !Form59.smethod_2())
		{
			bool flag = false;
			if (Form54.smethod_6(this, Class333.smethod_1881() + class240_1.axT.method_6() + Class333.smethod_1122(), Class333.smethod_1123(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
			{
				Form59 form = new Form59();
				form.ShowDialog(this);
				form.Dispose();
				if (Form59.smethod_2())
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
		if (Class242.smethod_12(class240_1.axS) && class240_1.axT.method_0() < 3)
		{
			flag2 = true;
		}
		Struct34 @struct = new Struct34
		{
			BQs = false,
			BQU = string_42,
			BQu = string_41,
			BQV = class240_1,
			BQv = flag2
		};
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.DoWork += method_153;
		backgroundWorker.ProgressChanged += smethod_69;
		backgroundWorker.RunWorkerCompleted += method_154;
		if (flag2)
		{
			smethod_66(Class333.smethod_1882());
		}
		else
		{
			smethod_66(Class333.smethod_1883());
		}
		backgroundWorker.RunWorkerAsync(@struct);
	}

	private void method_153(object sender, DoWorkEventArgs e)
	{
		Class23.smethod_3(Class333.smethod_1884());
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		Struct34 @struct = (Struct34)e.Argument;
		string text = @struct.BQu;
		if (text == null && @struct.BQV != null)
		{
			text = Class234.smethod_8(@struct.BQV.axS, @struct.BQV.axs, @struct.BQV.axT, @struct.BQV.axt, bool_0: true);
		}
		backgroundWorker.ReportProgress(10);
		if (!string.IsNullOrEmpty(text) && @struct.BQV != null)
		{
			if (@struct.BQv)
			{
				Framework framework = new Framework(text, @struct.BQV.axS, @struct.BQV.axs, @struct.BQV.axT);
				@struct.BQt = framework.method_1();
				if (@struct.BQt == Class237.Enum91.Brc)
				{
					backgroundWorker.ReportProgress(30);
					string value = Class234.smethod_10(@struct.BQV.axS, @struct.BQV.axs, out var @class);
					if (!string.IsNullOrEmpty(value))
					{
						framework_1 = new Framework(value, @struct.BQV.axS, @struct.BQV.axs, @class);
						@struct.BQt = framework_1.method_1();
						if (@struct.BQt == Class237.Enum91.Brc)
						{
							backgroundWorker.ReportProgress(50);
							bool num = new Class296(@struct.BQU, framework).method_0(out var text2) && string.IsNullOrEmpty(text2);
							backgroundWorker.ReportProgress(60);
							framework_1.method_48(framework_1.aWS);
							framework_1.method_69(framework, framework_1.aWS, bool_0: true, bool_1: false);
							framework_1.method_70(framework_1, bool_0: false);
							backgroundWorker.ReportProgress(70);
							framework_1.method_49(framework_1.aWS);
							framework_1.method_58();
							framework_1.method_37(framework_1.awj);
							framework_1.method_42(null);
							framework_1.method_40(null, framework_0, hashSet_0);
							framework_1.method_38(null);
							backgroundWorker.ReportProgress(90);
							if (num)
							{
								@struct.BQs = true;
							}
							else
							{
								@struct.BQT = text2;
							}
						}
					}
				}
			}
			else
			{
				backgroundWorker.ReportProgress(20);
				framework_1 = new Framework(text, @struct.BQV.axS, @struct.BQV.axs, @struct.BQV.axT);
				backgroundWorker.ReportProgress(30);
				@struct.BQt = framework_1.method_1();
				if (@struct.BQt == Class237.Enum91.Brc)
				{
					backgroundWorker.ReportProgress(60);
					bool num2 = new Class296(@struct.BQU, framework_1).method_0(out var text3) && string.IsNullOrEmpty(text3);
					backgroundWorker.ReportProgress(70);
					framework_1.method_58();
					framework_1.method_37(framework_1.awj);
					framework_1.method_42(null);
					framework_1.method_40(null, framework_0, hashSet_0);
					framework_1.method_38(null);
					if (framework_1.awZ == 21)
					{
						backgroundWorker.ReportProgress(80);
						if (framework_1.method_12())
						{
							Class329.smethod_0(framework_1, null);
							Class329.smethod_5();
							if (framework_1.awP.method_98())
							{
								Class329.smethod_10();
							}
						}
					}
					backgroundWorker.ReportProgress(90);
					if (num2)
					{
						@struct.BQs = true;
					}
					else
					{
						@struct.BQT = text3;
					}
				}
			}
		}
		else
		{
			@struct.BQt = Class237.Enum91.BrD;
		}
		e.Result = @struct;
		Thread.Sleep(100);
		backgroundWorker.ReportProgress(100);
	}

	private void method_154(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct34 @struct = (Struct34)e.Result;
		Class23.smethod_3(Class333.smethod_1885() + @struct.BQs + Class333.smethod_9());
		smethod_68();
		string_32 = null;
		bool flag = true;
		if (!@struct.BQs)
		{
			flag = false;
			if (@struct.BQt == Class237.Enum91.BrD)
			{
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += Class229.smethod_44;
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.ProgressChanged += smethod_69;
				smethod_66(Class333.smethod_1390());
				BackgroundWorker backgroundWorker2 = new BackgroundWorker();
				backgroundWorker2.DoWork += method_155;
				backgroundWorker2.RunWorkerCompleted += method_156;
				backgroundWorker.RunWorkerAsync();
				backgroundWorker2.RunWorkerAsync(@struct);
				Class229.abM = true;
			}
			else if (!bool_14)
			{
				string empty = string.Empty;
				if (@struct.BQt == Class237.Enum91.Brd)
				{
					empty = Class333.smethod_1391();
				}
				else if (@struct.BQt == Class237.Enum91.BrE)
				{
					empty = Class333.smethod_1392();
				}
				else
				{
					string text = Class242.smethod_10(@struct.BQV.axS, @struct.BQV.axs);
					text = ((text != null) ? (Class333.smethod_1393() + text + Class333.smethod_1394()) : string.Empty);
					if (@struct.BQt == Class237.Enum91.Bre)
					{
						empty = Class333.smethod_1395() + text + Class333.smethod_1396() + @struct.BQV.axT.ToString();
					}
					else
					{
						empty = ((!string.IsNullOrEmpty(@struct.BQT)) ? @struct.BQT : (Class333.smethod_1397() + text + Class333.smethod_1396() + @struct.BQV.axT.ToString()));
					}
				}
				if (1 != 0)
				{
					if (Form54.smethod_6(this, empty + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
					{
						while (openFileDialog_0.ShowDialog(this) == DialogResult.OK)
						{
							if (method_157(openFileDialog_0.FileName, @struct))
							{
								return;
							}
						}
					}
				}
				else if (Form54.smethod_9(this, @struct.BQT + Class333.smethod_1399(), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, new string[2]
				{
					Class333.smethod_1400(),
					Class333.smethod_1401()
				}) == DialogResult.Yes)
				{
					while (openFileDialog_0.ShowDialog(this) == DialogResult.OK)
					{
						if (method_157(openFileDialog_0.FileName, @struct))
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
		Form48.smethod_1(framework_1, out var flag2, out var _, out var flag4);
		if (!flag2 && !flag4 && smethod_10(bool_53: true))
		{
			toolStripMenuItem_39.Enabled = true;
			toolStripButton_11.Enabled = true;
			toolStripMenuItem_38.Enabled = true;
			toolStripMenuItem_8.Enabled = true;
			toolStripMenuItem_41.Enabled = true;
			toolStripMenuItem_42.Enabled = true;
			class163_0.Enabled = true;
			toolStripButton_1.Enabled = true;
			toolStripMenuItem_6.Enabled = true;
			toolStripButton_4.Enabled = true;
			toolStripMenuItem_10.Enabled = true;
			toolStripButton_7.Enabled = true;
			toolStripMenuItem_58.Enabled = true;
			toolStripMenuItem_59.Enabled = true;
			toolStripDropDownButton_0.Enabled = true;
			toolStripMenuItem_31.Enabled = false;
			if (@struct.BQv)
			{
				string_19 = string.Empty;
			}
			else
			{
				string_19 = @struct.BQU;
			}
			smethod_6();
		}
	}

	private void method_155(object sender, DoWorkEventArgs e)
	{
		Struct34 bQw = (Struct34)e.Argument;
		string text = Class320.smethod_13(bQw.BQV, ushort.MaxValue);
		string[] bQx = Class229.smethod_46(bQw.BQV.axT, bQw.BQV.axS, bQw.BQV.axs, text, out var nullable_, out var updateOutcomes_);
		Struct35 @struct = new Struct35
		{
			BQw = bQw
		};
		if (nullable_.HasValue && updateOutcomes_ == UpdateOutcomes.CompleteUpdate)
		{
			@struct.BQX = updateOutcomes_;
			@struct.BQx = bQx;
		}
		e.Result = @struct;
	}

	private void method_156(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct35 @struct = (Struct35)e.Result;
		smethod_68();
		if (@struct.BQx != null && @struct.BQx.Length != 0)
		{
			string[] bQx = @struct.BQx;
			foreach (string text in bQx)
			{
				List<string> list;
				if (text.EndsWith(Class333.smethod_1402()))
				{
					list = new List<string>();
					list.Add(text);
				}
				else
				{
					list = Class234.smethod_13(text);
				}
				if (list.Count != 0 && method_157(text, @struct.BQw))
				{
					return;
				}
			}
		}
		string text2 = Class242.smethod_10(@struct.BQw.BQV.axS, @struct.BQw.BQV.axs);
		string text3 = string.Concat(str1: (text2 != null) ? (Class333.smethod_1393() + text2 + Class333.smethod_1394()) : string.Empty, str0: Class333.smethod_1403(), str2: Class333.smethod_1396(), str3: @struct.BQw.BQV.axT.ToString());
		if (!bool_14 && Form54.smethod_6(this, text3 + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_157(openFileDialog_0.FileName, @struct.BQw))
			{
			}
		}
	}

	private bool method_157(string string_41, Struct34 struct34_0)
	{
		try
		{
			if (struct34_0.BQV == null)
			{
				return false;
			}
			string text = null;
			bool flag;
			bool flag2;
			bool flag3;
			Class14 @class;
			if (string_41.EndsWith(Class333.smethod_1404()))
			{
				flag = Class320.smethod_12(string_41, struct34_0.BQV, out flag2, out flag3, out @class, out text);
			}
			else
			{
				text = string_41;
				flag = Class234.smethod_5(string_41, struct34_0.BQV, out flag2, out flag3, out @class);
			}
			if (flag && text != null)
			{
				method_152(text, struct34_0.BQU, struct34_0.BQV);
				return true;
			}
			if (!bool_14)
			{
				if (!(@class == null) && text != null)
				{
					if (!flag2)
					{
						Form54.smethod_6(this, Class333.smethod_1746(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else if (!flag3)
					{
						Form54.smethod_6(this, Class333.smethod_1407() + @class.ToString() + Class333.smethod_1886() + struct34_0.BQV.axT.ToString() + Class333.smethod_9(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						Form54.smethod_6(this, Class333.smethod_1409(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				else
				{
					Form54.smethod_6(this, Class333.smethod_1405(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1887() + ex.Message);
		}
		return false;
	}

	internal void toolStripMenuItem_14_Click(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate112 method = toolStripMenuItem_14_Click;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (framework_1 != null && (int_0 & 0x1000) == 0)
		{
			if ((int_0 & 0x400) != 0)
			{
				toolStripMenuItem_14.Text = Class333.smethod_1609();
				class284_0.method_1();
			}
			else
			{
				class284_0.method_0();
				toolStripMenuItem_14.Text = Class333.smethod_1888();
			}
			if (form43_0 != null && !form43_0.IsDisposed && form43_0.Visible)
			{
				form43_0.method_23();
			}
		}
	}

	private void toolStripMenuItem_50_Click(object sender, EventArgs e)
	{
		Form2 form = new Form2();
		form.ShowDialog(this);
		form.Dispose();
	}

	private void toolStripMenuItem_16_Click(object sender, EventArgs e)
	{
		if ((int_0 & 0x400) != 0 && class284_0.BCQ != null)
		{
			try
			{
				method_160(class284_0.BCq, bool_53: true);
				return;
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.smethod_1889() + ex.Message);
				return;
			}
		}
		try
		{
			string text = smethod_81(Class333.smethod_929());
			if (string.IsNullOrEmpty(text))
			{
				Form54.smethod_6(this, Class333.smethod_1890(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				method_160(text, bool_53: false);
			}
		}
		catch (Exception ex2)
		{
			Class23.smethod_3(Class333.smethod_1889() + ex2.Message);
		}
	}

	private void toolStripMenuItem_17_Click(object sender, EventArgs e)
	{
		string argument;
		if ((int_0 & 0x400) != 0 && class284_0.BCQ != null)
		{
			argument = class284_0.BCq;
			toolStripMenuItem_14.Text = Class333.smethod_1609();
			class284_0.method_1();
		}
		else
		{
			argument = string.Empty;
		}
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.DoWork += method_158;
		backgroundWorker.ProgressChanged += smethod_69;
		backgroundWorker.RunWorkerCompleted += method_159;
		smethod_66(Class333.smethod_1891());
		backgroundWorker.RunWorkerAsync(argument);
	}

	private void method_158(object sender, DoWorkEventArgs e)
	{
		for (int i = 0; i < 10; i++)
		{
			Thread.Sleep(100);
			(sender as BackgroundWorker).ReportProgress((i + 1) * 10);
		}
		string result = e.Argument as string;
		e.Result = result;
	}

	private void method_159(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		bool flag = false;
		bool flag2 = false;
		if (File.Exists(Form10.smethod_3()))
		{
			flag = true;
			flag2 = true;
		}
		else if (File.Exists(Form10.smethod_2()))
		{
			flag = false;
			flag2 = true;
		}
		if (!flag2)
		{
			Form54.smethod_6(this, Class333.smethod_925(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		string text = e.Result as string;
		string text2;
		if (string.IsNullOrEmpty(text))
		{
			text2 = ((!flag) ? smethod_81(Class333.smethod_933()) : smethod_81(Class333.smethod_929()));
		}
		else if (flag)
		{
			text2 = text;
		}
		else
		{
			text2 = text.Substring(0, text.Length - Class333.smethod_488().Length) + Class333.smethod_919();
			if (!File.Exists(text2))
			{
				text2 = null;
			}
		}
		if (string.IsNullOrEmpty(text2))
		{
			Form54.smethod_6(this, Class333.smethod_1890(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		try
		{
			if (flag)
			{
				if (!Class35.smethod_2(text2))
				{
					Class35.smethod_1(text2, Class19.smethod_3());
				}
				Form10.smethod_7(Form10.smethod_3(), text2);
			}
			else
			{
				Form10.smethod_7(Form10.smethod_2(), text2);
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1892() + ex.Message);
		}
	}

	private static string smethod_81(string string_41)
	{
		string result = null;
		if (framework_1 != null && framework_1.method_5())
		{
			string empty = string.Empty;
			if (framework_1.method_28(ref empty))
			{
				try
				{
					string text = smethod_99(empty, framework_1.aXc);
					if (!string.IsNullOrEmpty(text))
					{
						if (!text.EndsWith(Class333.smethod_176()) && !text.EndsWith(Class333.smethod_177()))
						{
							text += Class333.smethod_176();
						}
						string path = text + Class333.smethod_1893();
						if (Directory.Exists(path))
						{
							string[] files = Directory.GetFiles(path, string_41);
							if (files.Length != 0)
							{
								DateTime dateTime = DateTime.MinValue;
								string[] array = files;
								foreach (string text2 in array)
								{
									DateTime lastWriteTime = File.GetLastWriteTime(text2);
									if (lastWriteTime > dateTime)
									{
										Form10.smethod_14(text2, out var _, out var b);
										if (b == 0)
										{
											result = text2;
											dateTime = lastWriteTime;
										}
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					Class23.smethod_3(Class333.smethod_1894() + ex.Message);
					result = null;
				}
			}
		}
		return result;
	}

	private void toolStripMenuItem_15_Click(object sender, EventArgs e)
	{
		string empty = string.Empty;
		bool flag = false;
		if (framework_1 != null)
		{
			flag = framework_1.method_28(ref empty);
		}
		if (flag)
		{
			string text = smethod_99(empty, framework_1.aXc);
			if (!string.IsNullOrEmpty(text))
			{
				string text2 = text + Class333.smethod_952();
				if (!Directory.Exists(text2))
				{
					openFileDialog_2.InitialDirectory = string_2 + Class333.smethod_522() + string_18;
				}
				else
				{
					openFileDialog_2.InitialDirectory = text2;
				}
			}
			else
			{
				openFileDialog_2.InitialDirectory = string_2 + Class333.smethod_522() + string_18;
			}
		}
		else
		{
			openFileDialog_2.InitialDirectory = string_2 + Class333.smethod_522() + string_18;
		}
		if (openFileDialog_2.ShowDialog(this) == DialogResult.OK)
		{
			method_160(openFileDialog_2.FileName, bool_53: false);
		}
	}

	internal void method_160(string string_41, bool bool_53)
	{
		toolStripMenuItem_14.Text = Class333.smethod_1609();
		class284_0.method_1();
		if (control3_0.Visible)
		{
			smethod_83();
		}
		bool flag = false;
		if (framework_1 != null && framework_1.method_5())
		{
			if (bool_53)
			{
				flag = true;
			}
			else
			{
				switch (Form54.smethod_9(this, Class333.smethod_1895(), Class333.smethod_1896(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button3, new string[3]
				{
					Class333.smethod_685(),
					Class333.smethod_1897(),
					Class333.smethod_823()
				}))
				{
				case DialogResult.Yes:
					flag = true;
					break;
				case DialogResult.No:
					flag = false;
					break;
				case DialogResult.Cancel:
					return;
				}
			}
		}
		if (!flag)
		{
			smethod_87(this, bool_53: false);
		}
		Struct36 @struct = new Struct36
		{
			BQY = string_41,
			BQy = flag
		};
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.DoWork += method_161;
		backgroundWorker.ProgressChanged += smethod_69;
		backgroundWorker.RunWorkerCompleted += method_162;
		smethod_66(Class333.smethod_1898());
		backgroundWorker.RunWorkerAsync(@struct);
	}

	private void method_161(object sender, DoWorkEventArgs e)
	{
		Class23.smethod_3(Class333.smethod_1899());
		Struct36 @struct = (Struct36)e.Argument;
		Struct37 struct2 = new Struct37
		{
			BqA = @struct.BQy,
			BQz = @struct.BQY
		};
		for (int i = 0; i < 10; i++)
		{
			Thread.Sleep(100);
			(sender as BackgroundWorker).ReportProgress(i / 2);
		}
		struct2.BQZ = control3_0.method_8(@struct.BQY, sender as BackgroundWorker, out struct2.Bqa);
		e.Result = struct2;
	}

	private void method_162(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct37 @struct = (Struct37)e.Result;
		Class23.smethod_3(Class333.smethod_1900() + @struct.BQZ + Class333.smethod_9());
		smethod_68();
		if (@struct.BQZ)
		{
			if (@struct.BqA && framework_1 != null)
			{
				smethod_82(@struct.BQz);
			}
			else if (File.Exists(Control3.string_0))
			{
				Class240 @class = Class296.smethod_0(Control3.string_0);
				if (@class != null)
				{
					if ((int_0 & 1) != 0 && !@struct.BqA)
					{
						smethod_32(bool_53: true);
					}
					method_117();
					smethod_9();
					Struct34 struct2 = new Struct34
					{
						BQs = false,
						BQU = Control3.string_0,
						BQu = null,
						BQV = @class,
						BQW = @struct.BQz
					};
					BackgroundWorker backgroundWorker = new BackgroundWorker();
					backgroundWorker.WorkerReportsProgress = true;
					backgroundWorker.DoWork += method_153;
					backgroundWorker.ProgressChanged += smethod_69;
					backgroundWorker.RunWorkerCompleted += method_163;
					smethod_66(Class333.smethod_1901());
					backgroundWorker.RunWorkerAsync(struct2);
				}
				else
				{
					Form54.smethod_6(this, Class333.smethod_1369(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				control3_0.method_2();
				Form54.smethod_6(this, Class333.smethod_1902(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		else
		{
			control3_0.method_2();
			if (string.IsNullOrEmpty(@struct.Bqa))
			{
				Form54.smethod_6(this, Class333.smethod_1903(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1904() + @struct.Bqa, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}

	private void method_163(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct34 @struct = (Struct34)e.Result;
		Class23.smethod_3(Class333.smethod_1905() + @struct.BQs + Class333.smethod_9());
		smethod_68();
		if (@struct.BQs)
		{
			if (File.Exists(Control3.string_0))
			{
				File.Delete(Control3.string_0);
			}
			if (smethod_10(bool_53: true))
			{
				toolStripMenuItem_39.Enabled = true;
				toolStripButton_11.Enabled = true;
				toolStripMenuItem_38.Enabled = true;
				toolStripMenuItem_8.Enabled = false;
				toolStripMenuItem_41.Enabled = false;
				toolStripMenuItem_42.Enabled = false;
				class163_0.Enabled = false;
				toolStripButton_1.Enabled = false;
				toolStripMenuItem_9.Enabled = false;
				class169_0.Enabled = false;
				toolStripMenuItem_6.Enabled = true;
				toolStripButton_4.Enabled = true;
				toolStripMenuItem_10.Enabled = false;
				toolStripButton_7.Enabled = false;
				toolStripMenuItem_58.Enabled = false;
				toolStripMenuItem_59.Enabled = false;
				toolStripDropDownButton_0.Enabled = false;
				toolStripMenuItem_31.Enabled = false;
				string_19 = string.Empty;
				smethod_82(@struct.BQW);
				if (form3_0 != null && form3_0.Visible)
				{
					form3_0.Close();
					form3_0.Dispose();
				}
				if (form43_0 != null && form43_0.Visible)
				{
					form43_0.Close();
					form43_0.Dispose();
				}
				if (Control3.bool_2)
				{
					form43_0 = new Form43();
					form43_0.Location = new Point(Location.X + (Width - form43_0.Width) / 2, Location.Y + (Height - form43_0.Height) / 2);
					form43_0.Show(this);
				}
			}
			return;
		}
		string empty = string.Empty;
		if (@struct.BQt == Class237.Enum91.BrD)
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += Class229.smethod_44;
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.ProgressChanged += smethod_69;
			smethod_66(Class333.smethod_1390());
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += method_164;
			backgroundWorker2.RunWorkerCompleted += method_165;
			backgroundWorker.RunWorkerAsync();
			backgroundWorker2.RunWorkerAsync(@struct);
			Class229.abM = true;
			return;
		}
		if (@struct.BQt == Class237.Enum91.Brd)
		{
			empty = Class333.smethod_1391();
		}
		else if (@struct.BQt == Class237.Enum91.BrE)
		{
			empty = Class333.smethod_1392();
		}
		else
		{
			string text = Class242.smethod_10(@struct.BQV.axS, @struct.BQV.axs);
			text = ((text != null) ? (Class333.smethod_1393() + text + Class333.smethod_1394()) : string.Empty);
			empty = ((@struct.BQt != Class237.Enum91.Bre) ? (Class333.smethod_1397() + text + Class333.smethod_1396() + @struct.BQV.axT.ToString()) : (Class333.smethod_1395() + text + Class333.smethod_1396() + @struct.BQV.axT.ToString()));
		}
		if (Form54.smethod_6(this, empty + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_166(openFileDialog_0.FileName, @struct))
			{
			}
		}
	}

	private void method_164(object sender, DoWorkEventArgs e)
	{
		Struct34 bqB = (Struct34)e.Argument;
		string text = Class320.smethod_13(bqB.BQV, ushort.MaxValue);
		string[] bqC = Class229.smethod_46(bqB.BQV.axT, bqB.BQV.axS, bqB.BQV.axs, text, out var nullable_, out var updateOutcomes_);
		Struct38 @struct = new Struct38
		{
			BqB = bqB
		};
		if (nullable_.HasValue && updateOutcomes_ == UpdateOutcomes.CompleteUpdate)
		{
			@struct.Bqb = updateOutcomes_;
			@struct.BqC = bqC;
		}
		e.Result = @struct;
	}

	private void method_165(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct38 @struct = (Struct38)e.Result;
		smethod_68();
		if (@struct.BqC != null && @struct.BqC.Length != 0)
		{
			string[] bqC = @struct.BqC;
			foreach (string text in bqC)
			{
				List<string> list;
				if (text.EndsWith(Class333.smethod_1402()))
				{
					list = new List<string>();
					list.Add(text);
				}
				else
				{
					list = Class234.smethod_13(text);
				}
				if (list.Count != 0 && method_166(text, @struct.BqB))
				{
					return;
				}
			}
		}
		string text2 = Class242.smethod_10(@struct.BqB.BQV.axS, @struct.BqB.BQV.axs);
		string text3 = string.Concat(str1: (text2 != null) ? (Class333.smethod_1393() + text2 + Class333.smethod_1394()) : string.Empty, str0: Class333.smethod_1403(), str2: Class333.smethod_1396(), str3: @struct.BqB.BQV.axT.ToString());
		if (Form54.smethod_6(this, text3 + Class333.smethod_1398(), Class333.smethod_390(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			while (openFileDialog_0.ShowDialog(this) == DialogResult.OK && !method_166(openFileDialog_0.FileName, @struct.BqB))
			{
			}
		}
	}

	private bool method_166(string string_41, Struct34 struct34_0)
	{
		try
		{
			if (struct34_0.BQV == null)
			{
				return false;
			}
			string text = null;
			bool flag;
			bool flag2;
			bool flag3;
			Class14 @class;
			if (string_41.EndsWith(Class333.smethod_1404()))
			{
				flag = Class320.smethod_12(string_41, struct34_0.BQV, out flag2, out flag3, out @class, out text);
			}
			else
			{
				text = string_41;
				flag = Class234.smethod_5(string_41, struct34_0.BQV, out flag2, out flag3, out @class);
			}
			if (flag && text != null)
			{
				struct34_0.BQu = text;
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.DoWork += method_153;
				backgroundWorker.ProgressChanged += smethod_69;
				backgroundWorker.RunWorkerCompleted += method_163;
				smethod_66(Class333.smethod_1901());
				backgroundWorker.RunWorkerAsync(struct34_0);
				return true;
			}
			if (!(@class == null) && text != null)
			{
				if (!flag2)
				{
					Form54.smethod_6(this, Class333.smethod_1746(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (!flag3)
				{
					Form54.smethod_6(this, Class333.smethod_1407() + @class.ToString() + Class333.smethod_1906() + struct34_0.BQV.axT.ToString() + Class333.smethod_9(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					Form54.smethod_6(this, Class333.smethod_1409(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1405(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1907() + ex.Message);
		}
		return false;
	}

	internal static void smethod_82(string string_41)
	{
		string_39 = string_41;
		smethod_6();
		form23_0.control3_0.Visible = true;
		form23_0.method_119();
		smethod_73();
		lock (object_1)
		{
			int_0 |= 4096;
		}
	}

	internal static void smethod_83()
	{
		string_39 = string.Empty;
		smethod_6();
		form23_0.control3_0.Visible = false;
		form23_0.method_119();
		smethod_73();
		lock (object_1)
		{
			int_0 &= -4097;
		}
	}

	internal static bool smethod_84(int int_49)
	{
		if ((int_0 & 0x1000) != 0 && int_49 >= 0 && int_49 < Control3.list_1.Count)
		{
			return Control3.list_1[int_49];
		}
		return false;
	}

	private void method_167()
	{
		if (Directory.Exists(string_4 + Class333.smethod_1908()))
		{
			try
			{
				fileSystemWatcher_0 = new FileSystemWatcher(string_4 + Class333.smethod_1908());
				fileSystemWatcher_0.IncludeSubdirectories = true;
				fileSystemWatcher_0.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.CreationTime;
				fileSystemWatcher_0.Filter = Class333.smethod_1909();
				fileSystemWatcher_0.Changed += method_168;
				fileSystemWatcher_0.Created += method_169;
				fileSystemWatcher_0.Deleted += method_170;
				fileSystemWatcher_0.Renamed += method_171;
				fileSystemWatcher_0.EnableRaisingEvents = true;
			}
			catch
			{
			}
		}
		if (Directory.Exists(string_4 + Class333.smethod_1910()))
		{
			try
			{
				FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(string_4 + Class333.smethod_1910());
				fileSystemWatcher.IncludeSubdirectories = true;
				fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.CreationTime;
				fileSystemWatcher.Filter = Class333.smethod_1911();
				fileSystemWatcher.Changed += method_168;
				fileSystemWatcher.Created += method_169;
				fileSystemWatcher.Deleted += method_170;
				fileSystemWatcher.Renamed += method_171;
				fileSystemWatcher.EnableRaisingEvents = true;
			}
			catch
			{
			}
		}
	}

	private void method_168(object sender, FileSystemEventArgs e)
	{
		if (e.ChangeType == WatcherChangeTypes.Changed)
		{
			int_39++;
		}
	}

	private void method_169(object sender, FileSystemEventArgs e)
	{
		if (e.ChangeType == WatcherChangeTypes.Created)
		{
			int_39++;
		}
	}

	private void method_170(object sender, FileSystemEventArgs e)
	{
		if (e.ChangeType == WatcherChangeTypes.Deleted)
		{
			int_39++;
		}
	}

	private void method_171(object sender, RenamedEventArgs e)
	{
		if (e.ChangeType == WatcherChangeTypes.Renamed)
		{
			int_39++;
		}
	}

	private void method_172()
	{
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.DoWork += method_173;
		backgroundWorker.RunWorkerAsync();
	}

	private void method_173(object sender, DoWorkEventArgs e)
	{
		Thread.CurrentThread.Name = Class333.smethod_1912();
		while (!bool_15)
		{
			if (int_39 != 0)
			{
				if (int_39 == 1)
				{
					if (Directory.Exists(string_4 + Class333.smethod_1908()))
					{
						try
						{
							Class22.smethod_0(string_4 + Class333.smethod_1908(), string_2 + Class333.smethod_522() + string_18 + Class333.smethod_1913(), bool_0: true, Class22.Enum18.Bgt);
						}
						catch
						{
						}
					}
					if (Directory.Exists(string_4 + Class333.smethod_1910()))
					{
						try
						{
							Class22.smethod_0(string_4 + Class333.smethod_1910(), string_15, bool_0: true, Class22.Enum18.Bgt);
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
				int_39--;
			}
			else
			{
				Thread.Sleep(1000);
			}
		}
	}

	private void method_174()
	{
		if (Directory.Exists(string_4 + Class333.smethod_1914()))
		{
			try
			{
				Class22.smethod_0(string_4 + Class333.smethod_1914(), Control25.BlX, bool_0: true, Class22.Enum18.Bgs);
			}
			catch
			{
			}
			if (Control25.smethod_0())
			{
				Control25.smethod_1();
			}
		}
	}

	private void method_175()
	{
		if (!Directory.Exists(string_4 + Class333.smethod_1914()))
		{
			return;
		}
		try
		{
			fileSystemWatcher_1 = new FileSystemWatcher(string_4 + Class333.smethod_1914());
			fileSystemWatcher_1.IncludeSubdirectories = true;
			fileSystemWatcher_1.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.CreationTime;
			fileSystemWatcher_1.Filter = Class333.smethod_1915();
			fileSystemWatcher_1.Changed += method_176;
			fileSystemWatcher_1.Created += method_177;
			fileSystemWatcher_1.Deleted += method_178;
			fileSystemWatcher_1.Renamed += method_179;
			fileSystemWatcher_1.EnableRaisingEvents = true;
		}
		catch
		{
		}
	}

	private void method_176(object sender, FileSystemEventArgs e)
	{
		if (e.ChangeType == WatcherChangeTypes.Changed)
		{
			method_174();
		}
	}

	private void method_177(object sender, FileSystemEventArgs e)
	{
		if (e.ChangeType == WatcherChangeTypes.Created)
		{
			method_174();
		}
	}

	private void method_178(object sender, FileSystemEventArgs e)
	{
		if (e.ChangeType == WatcherChangeTypes.Deleted)
		{
			method_174();
		}
	}

	private void method_179(object sender, RenamedEventArgs e)
	{
		if (e.ChangeType == WatcherChangeTypes.Renamed)
		{
			method_174();
		}
	}

	private void method_180(object sender, EventArgs e)
	{
		if (Class1.smethod_27().Count == 1)
		{
			if (framework_1 != null)
			{
				method_117();
				smethod_9();
			}
			method_181(null, -1);
		}
	}

	internal void method_181(BackgroundWorker backgroundWorker_1, int int_49)
	{
		if (framework_1 != null && framework_1.method_5())
		{
			framework_1.method_48(framework_1.aWS);
			framework_1.method_71(0L);
			lock (object_1)
			{
				int_0 |= 32;
				int_0 |= 4;
			}
			if (backgroundWorker_1 == null)
			{
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.DoWork += method_182;
				backgroundWorker.ProgressChanged += smethod_69;
				backgroundWorker.RunWorkerCompleted += method_183;
				smethod_66(Class333.smethod_1916());
				backgroundWorker.RunWorkerAsync(-1);
			}
			else
			{
				DoWorkEventArgs e = new DoWorkEventArgs(int_49);
				method_182(backgroundWorker_1, e);
				method_183(backgroundWorker_1, new RunWorkerCompletedEventArgs(e.Result, null, cancelled: false));
			}
		}
	}

	private void method_182(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		int num = (int)e.Argument;
		e.Result = false;
		int uint_;
		try
		{
			uint_ = (int)list_2[0].BpS.struct1_0[35].uint_1;
		}
		catch
		{
			return;
		}
		int num2 = 0;
		lock (object_2)
		{
			framework_1.method_72();
			bool flag;
			do
			{
				int num3 = 0;
				flag = framework_1.method_79(ref num3);
				num2 = Math.Min(num2 + num3, uint_);
				int num4 = num2 * 100 / uint_;
				if (!flag || num3 != 0)
				{
					if (num == -1)
					{
						backgroundWorker.ReportProgress(num4);
					}
					else
					{
						backgroundWorker.ReportProgress(num4, num);
					}
				}
				if (smethod_28(framework_1.aXc, bool_53: false))
				{
					if (num4 != 100)
					{
						Thread.Sleep(0);
					}
					else
					{
						Thread.Sleep(200);
					}
					continue;
				}
				return;
			}
			while (flag || num2 < uint_);
		}
		num2 = 0;
		int uint_2;
		try
		{
			uint_2 = (int)list_2[0].BpS.struct1_0[33].uint_1;
		}
		catch
		{
			return;
		}
		if (!framework_1.method_76())
		{
			return;
		}
		do
		{
			int num5 = 0;
			if (framework_1.method_78(ref num5))
			{
				num2 = Math.Min(num2 + num5, uint_2);
				if (!smethod_28(framework_1.aXc, bool_53: false))
				{
					return;
				}
				continue;
			}
			return;
		}
		while (num2 < uint_2);
		e.Result = true;
	}

	private void method_183(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		if ((bool)e.Result)
		{
			if (framework_1.awv.Count != 0)
			{
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.WorkerReportsProgress = true;
				backgroundWorker.DoWork += method_184;
				backgroundWorker.ProgressChanged += smethod_69;
				backgroundWorker.RunWorkerCompleted += method_186;
				smethod_66(Class333.smethod_1917());
				backgroundWorker.RunWorkerAsync();
				return;
			}
			lock (object_1)
			{
				int_0 &= -33;
				int_0 &= -3;
			}
			framework_1.method_49(framework_1.aWS);
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.WorkerReportsProgress = true;
			backgroundWorker2.DoWork += method_187;
			backgroundWorker2.ProgressChanged += smethod_69;
			backgroundWorker2.RunWorkerCompleted += method_188;
			smethod_66(Class333.smethod_1918());
			backgroundWorker2.RunWorkerAsync();
		}
		else
		{
			framework_1.method_49(framework_1.aWS);
			smethod_32(bool_53: true);
		}
	}

	private void method_184(object sender, DoWorkEventArgs e)
	{
		e.Result = null;
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		if (!smethod_19(string_10, out var string_))
		{
			Class23.smethod_3(string_);
		}
		Array values = Enum.GetValues(typeof(Class1.Enum5));
		int num = 100 / values.Length;
		for (int i = 0; i < values.Length; i++)
		{
			Class1.Enum5 @enum = (Class1.Enum5)values.GetValue(i);
			if (@enum == Class1.Enum5.BFI)
			{
				continue;
			}
			int num2 = i * num;
			backgroundWorker.ReportProgress(num2);
			Class10[] array = smethod_22(@enum);
			List<Class10> list = new List<Class10>();
			if (array != null)
			{
				Class10[] array2 = array;
				foreach (Class10 @class in array2)
				{
					if (@class.method_2().StartsWith(Class333.smethod_1469()))
					{
						list.Add(@class);
					}
				}
			}
			int num3 = num2 + num / 10;
			backgroundWorker.ReportProgress(num3);
			for (int k = 0; k < list.Count; k++)
			{
				Class10 class2 = list[k];
				string text = class2.method_2().Substring(Class333.smethod_1469().Length);
				if (@enum == Class1.Enum5.BFH && Class263.aZd.ContainsKey(text) && Class263.aZd[text] == class2.uint_0)
				{
					Class1.smethod_56(framework_1.aXc, class2, out var _, out var _);
				}
				else
				{
					string text2 = Class247.smethod_7(class2.enum5_0);
					if (text2 != null)
					{
						byte[] byte_ = null;
						bool flag2 = smethod_15(framework_1, class2, text2, out var _, out byte_);
						if (byte_ == null || !flag2)
						{
							byte_ = method_185(class2, out var string_3);
							if (string_3 != null)
							{
								if (e.Result == null)
								{
									e.Result = string_3;
								}
								else
								{
									e.Result = (string)e.Result + Class333.smethod_1812() + string_3;
								}
							}
						}
						if (byte_ != null)
						{
							if (!smethod_20(string_10, text, byte_, text2, out string_))
							{
								Class23.smethod_3(string_);
							}
							if (!flag2 && !smethod_18(framework_1, text, byte_, text2, out string_))
							{
								Class23.smethod_3(string_);
							}
						}
					}
				}
				if (!smethod_28(framework_1.aXc, bool_53: false))
				{
					break;
				}
				backgroundWorker.ReportProgress(num3 + (k + 1) * (num * 9 / 10) / list.Count);
			}
		}
		backgroundWorker.ReportProgress(100);
		Thread.Sleep(500);
	}

	private byte[] method_185(Class10 class10_0, out string string_41)
	{
		string_41 = null;
		do
		{
			if (!Class1.smethod_53(framework_1.aXc, class10_0, 0u, class10_0.uint_0, out var enum4_, out var byte_, out var flag))
			{
				if (flag)
				{
					return null;
				}
				continue;
			}
			if (enum4_ == Class1.Enum4.BFC)
			{
				return byte_;
			}
			string_41 = Class333.smethod_1919() + class10_0.method_2() + Class333.smethod_1920() + Class1.smethod_50(enum4_) + Class333.smethod_9();
			return null;
		}
		while (smethod_28(framework_1.aXc, bool_53: false));
		return null;
	}

	private void method_186(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		lock (object_1)
		{
			int_0 &= -33;
			int_0 &= -3;
		}
		framework_1.method_49(framework_1.aWS);
		if (!bool_14)
		{
			string value = e.Result as string;
			if (!string.IsNullOrWhiteSpace(value))
			{
				Form54.smethod_6(this, value, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.DoWork += method_187;
		backgroundWorker.ProgressChanged += smethod_69;
		backgroundWorker.RunWorkerCompleted += method_188;
		smethod_66(Class333.smethod_1918());
		backgroundWorker.RunWorkerAsync();
	}

	private void method_187(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker obj = sender as BackgroundWorker;
		obj.ReportProgress(0);
		Thread.Sleep(100);
		obj.ReportProgress(30);
		framework_1.method_58();
		obj.ReportProgress(40);
		framework_1.method_37(framework_1.awj);
		framework_1.method_42(null);
		obj.ReportProgress(80);
		framework_1.method_40(null, framework_0, hashSet_0);
		obj.ReportProgress(90);
		framework_1.method_38(null);
		Thread.Sleep(100);
		obj.ReportProgress(100);
	}

	private void method_188(object sender, RunWorkerCompletedEventArgs e)
	{
		if (!bool_14)
		{
			smethod_68();
		}
		if (string_30 != null)
		{
			method_193(string_30);
		}
		else if (bool_13)
		{
			method_196();
		}
		else if (string_29 != null)
		{
			method_192(string_29);
		}
		if (!bool_14)
		{
			if (framework_1.awZ == 21)
			{
				Class329.smethod_0(framework_1, null);
				Class329.smethod_5();
				if (framework_1.awP.method_98())
				{
					Class329.smethod_10();
				}
			}
			framework_1.method_65(form23_0);
			bool bool_ = false;
			bool bool_2 = false;
			bool flag = false;
			bool bool_3 = false;
			bool bool_4 = false;
			if (framework_1.method_4())
			{
				if (Form48.smethod_0(framework_1))
				{
					if (framework_1.method_31(16035).method_256() == 0)
					{
						BackgroundWorker backgroundWorker = new BackgroundWorker();
						backgroundWorker.WorkerReportsProgress = true;
						backgroundWorker.DoWork += method_190;
						backgroundWorker.ProgressChanged += smethod_69;
						backgroundWorker.RunWorkerCompleted += method_191;
						smethod_66(Class333.smethod_1921());
						backgroundWorker.RunWorkerAsync();
						return;
					}
					bool_3 = Form48.smethod_1(framework_1, out bool_, out bool_2, out flag);
				}
				else
				{
					Class122.smethod_0(framework_1, out bool_4);
				}
			}
			if (!flag)
			{
				method_189(bool_4, bool_3, bool_, bool_2);
			}
		}
		if (string_27 != null)
		{
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += method_84;
			backgroundWorker2.RunWorkerCompleted += method_85;
			backgroundWorker2.RunWorkerAsync();
		}
		else if (string_31 != null)
		{
			BackgroundWorker backgroundWorker3 = new BackgroundWorker();
			backgroundWorker3.DoWork += method_29;
			backgroundWorker3.RunWorkerCompleted += method_30;
			backgroundWorker3.RunWorkerAsync();
		}
	}

	private void method_189(bool bool_53, bool bool_54, bool bool_55, bool bool_56)
	{
		if (bool_55 | bool_53)
		{
			smethod_32(bool_53: true);
		}
		else
		{
			if (!smethod_10(bool_53: true))
			{
				return;
			}
			toolStripMenuItem_39.Enabled = true;
			toolStripButton_11.Enabled = true;
			toolStripMenuItem_38.Enabled = true;
			toolStripMenuItem_42.Enabled = true;
			class163_0.Enabled = true;
			toolStripMenuItem_6.Enabled = true;
			toolStripButton_4.Enabled = true;
			toolStripMenuItem_58.Enabled = true;
			toolStripMenuItem_59.Enabled = true;
			toolStripDropDownButton_0.Enabled = true;
			smethod_11();
			string_19 = string.Empty;
			smethod_6();
			smethod_104(framework_1);
			if (Form10.bool_2 && (int_0 & 0x800) == 0)
			{
				class284_1.method_0();
			}
			if (string_27 != null)
			{
				return;
			}
			Class316 @class = new Class316();
			@class.BdC = new Class240
			{
				axS = framework_1.awZ,
				axs = framework_1.awz,
				axT = framework_1.aXA,
				axt = framework_1.method_11()
			};
			@class.Bdc = new List<ushort>();
			Class5 class2 = Class1.smethod_26(framework_1.aXc);
			if (class2 != null)
			{
				@class.Bdc.Add(class2.ushort_0);
			}
			if (Class305.smethod_4(@class, out var text, out var _))
			{
				string text2 = (string.IsNullOrEmpty(text) ? Class333.smethod_1118() : (Class333.smethod_1117() + text + Class333.smethod_570()));
				if (Form54.smethod_6(form23_0, Class333.smethod_1922() + framework_1.aXA.ToString() + Class333.smethod_875() + text2 + Class333.smethod_1923(), Class333.smethod_1120(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					class169_0_Click(null, null);
				}
			}
			else if (bool_54 && form23_0.toolStripMenuItem_31.Enabled && !bool_56)
			{
				form23_0.toolStripMenuItem_31.PerformClick();
			}
		}
	}

	private void method_190(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		bool flag = false;
		Class5 @class = Class1.smethod_26(framework_1.aXc);
		if (@class != null)
		{
			Class14 class2 = null;
			if (@class.byte_8 != byte.MaxValue || @class.byte_9 != byte.MaxValue || @class.byte_10 != byte.MaxValue || @class.byte_11 != byte.MaxValue)
			{
				class2 = new Class14(@class.byte_8, @class.byte_9, @class.byte_10, @class.byte_11, 0);
			}
			while (Class229.smethod_12())
			{
				Thread.Sleep(1000);
			}
			string value = Class229.smethod_45(framework_1.awZ, framework_1.awz, out var nullable_, out var updateOutcomes_);
			if (nullable_.HasValue && updateOutcomes_ == UpdateOutcomes.CompleteUpdate && !string.IsNullOrEmpty(value))
			{
				Class318 class3 = Class320.smethod_39(value, framework_1.awZ, framework_1.awz, @class.ushort_0, @class.string_0, class2, Enum88.avK, null, bool_0: false);
				if (class3 != null)
				{
					foreach (Class316 item in class3.BdF)
					{
						if (item.BdC.axS == framework_1.awZ && item.BdC.axs == framework_1.awz && item.BdC.axT > framework_1.aXA && (Class320.smethod_43(@class.string_0) || item.Bdc.Contains(@class.ushort_0)))
						{
							flag = true;
							break;
						}
					}
				}
				backgroundWorker.ReportProgress(100);
				Thread.Sleep(500);
			}
			else
			{
				if (backgroundWorker_0 != null && backgroundWorker_0.IsBusy)
				{
					backgroundWorker_0.CancelAsync();
					Thread.Sleep(200);
				}
				List<Class318> list_ = Class320.smethod_38(backgroundWorker, framework_1.awZ, framework_1.awz, framework_1.aXA, @class.ushort_0, @class.string_0, class2, bool_0: true, Enum88.avK, null, bool_1: false);
				if (smethod_65(framework_1, list_))
				{
					flag = true;
				}
			}
		}
		e.Result = flag;
	}

	private void method_191(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		if ((bool)e.Result && Form54.smethod_4(form23_0, Class333.smethod_1924(), Class333.smethod_705(), MessageBoxButtons.YesNo) == DialogResult.Yes)
		{
			form23_0.class169_0_Click(null, null);
			return;
		}
		bool bool_ = Form48.smethod_1(framework_1, out var bool_2, out var bool_3, out var flag);
		if (!flag)
		{
			method_189(bool_53: false, bool_, bool_2, bool_3);
		}
	}

	private void method_192(string string_41)
	{
		try
		{
			new Class297(string_41, framework_1, bool_0: true).method_0();
			string value = Class333.smethod_1925() + string_41;
			if (bool_14)
			{
				Console.WriteLine();
				Console.WriteLine(value);
				Environment.Exit(0);
			}
			else
			{
				Form54.smethod_6(this, value, Class333.smethod_1926(), MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}
		catch (Exception ex)
		{
			string value2 = Class333.smethod_1927() + string_41 + Class333.smethod_1928() + ex.Message;
			if (bool_14)
			{
				Console.WriteLine();
				Console.WriteLine(value2);
				Environment.Exit(1);
			}
			else
			{
				Form54.smethod_6(this, value2, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		string_29 = null;
	}

	private void method_193(string string_41)
	{
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.DoWork += method_194;
		backgroundWorker.ProgressChanged += smethod_69;
		backgroundWorker.RunWorkerCompleted += method_195;
		smethod_66(Class333.smethod_1929());
		backgroundWorker.RunWorkerAsync(string_41);
	}

	private void method_194(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		string text = e.Argument as string;
		string empty = string.Empty;
		bool bqc = false;
		try
		{
			Class240 @class = Class296.smethod_0(text);
			backgroundWorker.ReportProgress(10);
			Thread.Sleep(0);
			string text2 = Class234.smethod_8(@class.axS, @class.axs, @class.axT, @class.axt, bool_0: true);
			backgroundWorker.ReportProgress(20);
			Thread.Sleep(0);
			Framework framework = new Framework(text2, @class.axS, @class.axs, @class.axT);
			Class237.Enum91 @enum = framework.method_1();
			backgroundWorker.ReportProgress(50);
			Thread.Sleep(0);
			if (@enum != Class237.Enum91.Brc)
			{
				throw new Exception(Class333.smethod_1931() + @enum);
			}
			new Class296(text, framework).method_1(out var _, bool_0: false, bool_1: false, bool_2: true);
			backgroundWorker.ReportProgress(70);
			Thread.Sleep(0);
			StringBuilder stringBuilder = new StringBuilder();
			method_199(framework_1.aWS, framework, stringBuilder);
			string text4 = stringBuilder.ToString();
			empty = ((bqc = string.IsNullOrEmpty(text4)) ? (Class333.smethod_1930() + text) : text4);
		}
		catch (Exception ex)
		{
			empty = Class333.smethod_1932() + text + Class333.smethod_1933() + ex.Message;
		}
		backgroundWorker.ReportProgress(100);
		Thread.Sleep(500);
		Struct39 @struct = new Struct39
		{
			BqD = empty,
			Bqc = bqc
		};
		e.Result = @struct;
	}

	private void method_195(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		Struct39 @struct = (Struct39)e.Result;
		if (bool_14)
		{
			Console.WriteLine();
			Console.WriteLine(@struct.BqD);
			if (@struct.Bqc)
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
			Form54.smethod_6(this, @struct.BqD, Class333.smethod_1934(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		string_30 = null;
	}

	private void method_196()
	{
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.DoWork += method_197;
		backgroundWorker.ProgressChanged += smethod_69;
		backgroundWorker.RunWorkerCompleted += method_198;
		smethod_66(Class333.smethod_1935());
		backgroundWorker.RunWorkerAsync();
	}

	private void method_197(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		string empty = string.Empty;
		bool bqc = false;
		try
		{
			Framework framework = new Framework(framework_1.method_10(), framework_1.awZ, framework_1.awz, framework_1.aXA);
			Class237.Enum91 @enum = framework.method_1();
			backgroundWorker.ReportProgress(30);
			Thread.Sleep(0);
			if (@enum != Class237.Enum91.Brc)
			{
				throw new Exception(Class333.smethod_1937() + @enum);
			}
			framework.method_15(framework.aWS);
			backgroundWorker.ReportProgress(50);
			Thread.Sleep(0);
			StringBuilder stringBuilder = new StringBuilder();
			method_199(framework_1.aWS, framework, stringBuilder);
			string text = stringBuilder.ToString();
			empty = ((bqc = string.IsNullOrEmpty(text)) ? Class333.smethod_1936() : text);
		}
		catch (Exception ex)
		{
			empty = Class333.smethod_1938() + ex.Message;
		}
		backgroundWorker.ReportProgress(100);
		Thread.Sleep(500);
		Struct39 @struct = new Struct39
		{
			BqD = empty,
			Bqc = bqc
		};
		e.Result = @struct;
	}

	private void method_198(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		Struct39 @struct = (Struct39)e.Result;
		if (bool_14)
		{
			Console.WriteLine();
			Console.WriteLine(@struct.BqD);
			if (@struct.Bqc)
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
			Form54.smethod_6(this, @struct.BqD, Class333.smethod_1939(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		bool_13 = false;
	}

	private void method_199(List<SettingOrSpecialObject> list_9, Framework framework_2, StringBuilder stringBuilder_0)
	{
		foreach (SettingOrSpecialObject item in list_9)
		{
			if (item is Table)
			{
				Table table = item as Table;
				Setting setting = framework_2.method_31(table.method_64());
				if (setting != null)
				{
					Table compareTable = setting as Table;
					table.CompareWithAnotherCorrespondingTable(compareTable, stringBuilder_0);
				}
				continue;
			}
			if (item is Setting)
			{
				Setting setting2 = framework_2.method_32((item as Setting).method_69());
				if (setting2 != null)
				{
					(item as Setting).method_117(setting2, stringBuilder_0);
				}
			}
			method_199(item.method_1(), framework_2, stringBuilder_0);
		}
	}

	private void method_200(object sender, EventArgs e)
	{
		if (Class1.smethod_27().Count == 1)
		{
			if (framework_1 != null)
			{
				method_117();
				smethod_9();
			}
			lock (object_1)
			{
				int_0 |= 128;
			}
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.ProgressChanged += smethod_69;
			backgroundWorker.DoWork += method_201;
			backgroundWorker.RunWorkerCompleted += method_202;
			smethod_66(Class333.smethod_1740());
			backgroundWorker.RunWorkerAsync(Class1.smethod_27()[0]);
		}
	}

	private void method_201(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		Class5 @class = e.Argument as Class5;
		backgroundWorker.ReportProgress(0);
		Class217 class2 = new Class217();
		byte[] array = null;
		try
		{
			byte[] array2 = null;
			do
			{
				if (!Class1.smethod_37(@class.string_0, Enum10.const_3, 0u, 4u, out var byte_, out var flag))
				{
					if (flag || !smethod_28(@class.string_0, bool_53: false))
					{
						array2 = null;
						break;
					}
				}
				else
				{
					array2 = byte_;
				}
			}
			while (array2 == null);
			uint num = 0u;
			if (array2 == null)
			{
				throw new Exception(Class333.smethod_1940());
			}
			num = (uint)((array2[0] << 24) | ((array2[1] << 16) & 0xFF0000) | ((array2[2] << 8) & 0xFF00) | (array2[3] & 0xFF));
			array = new byte[num];
			uint num2 = Class1.smethod_73(@class.string_0, Enum10.const_3);
			uint num3;
			for (num3 = 0u; num3 < num / num2; num3++)
			{
				bool flag2;
				do
				{
					if (!(flag2 = Class1.smethod_37(@class.string_0, Enum10.const_3, 4 + num3 * num2, num2, out var byte_2, out var flag3)))
					{
						if (flag3 || !smethod_28(@class.string_0, bool_53: false))
						{
							throw new Exception(Class333.smethod_1941());
						}
					}
					else
					{
						Array.Copy(byte_2, 0L, array, num3 * num2, num2);
						int percentProgress = (int)(50 * num3 * num2 / num);
						backgroundWorker.ReportProgress(percentProgress);
					}
				}
				while (!flag2);
			}
			uint num4 = num % num2;
			if (num4 != 0)
			{
				bool flag4;
				do
				{
					if (!(flag4 = Class1.smethod_37(@class.string_0, Enum10.const_3, 4 + num3 * num2, num4, out var byte_3, out var flag5)))
					{
						if (flag5 || !smethod_28(@class.string_0, bool_53: false))
						{
							throw new Exception(Class333.smethod_1942());
						}
					}
					else
					{
						Array.Copy(byte_3, 0L, array, num3 * num2, num4);
					}
				}
				while (!flag4);
			}
			backgroundWorker.ReportProgress(60);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_1943() + ex.Message);
			class2.Bqd = Class237.Enum91.BrF;
			e.Result = class2;
			return;
		}
		string text = null;
		Class240 class3 = null;
		try
		{
			text = Class234.smethod_12(array, Class333.smethod_1944(), out class3);
			backgroundWorker.ReportProgress(70);
		}
		catch (Exception ex2)
		{
			Class23.smethod_3(Class333.smethod_1943() + ex2.Message);
			class2.Bqd = Class237.Enum91.BrD;
			e.Result = class2;
			return;
		}
		Framework framework = new Framework(text, class3.axS, class3.axs, class3.axT);
		Class237.Enum91 @enum = (class2.Bqd = framework.method_1());
		try
		{
			if (@enum == Class237.Enum91.Brc)
			{
				Class234.smethod_7(text, framework.awZ, framework.awz, framework.aXA);
				framework.aXc = @class.string_0;
				class2.BqE = framework;
				if (framework.awZ == 21)
				{
					backgroundWorker.ReportProgress(80);
					framework.method_12();
				}
			}
			else
			{
				File.Delete(text);
			}
		}
		catch (Exception ex3)
		{
			Class23.smethod_3(Class333.smethod_1943() + ex3.Message);
		}
		e.Result = class2;
		backgroundWorker.ReportProgress(90);
		Thread.Sleep(100);
		backgroundWorker.ReportProgress(100);
	}

	private void method_202(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		lock (object_1)
		{
			int_0 &= -129;
		}
		Class217 @class = e.Result as Class217;
		Class237.Enum91 bqd = @class.Bqd;
		if (bqd == Class237.Enum91.Brc)
		{
			framework_1 = @class.BqE;
			method_181(null, -1);
			return;
		}
		string empty = string.Empty;
		Form54.smethod_6(this, bqd switch
		{
			Class237.Enum91.BrF => Class333.smethod_1945(), 
			Class237.Enum91.BrD => Class333.smethod_1946(), 
			Class237.Enum91.Brd => Class333.smethod_1391(), 
			Class237.Enum91.BrE => Class333.smethod_1392(), 
			Class237.Enum91.Bre => Class333.smethod_1947(), 
			_ => Class333.smethod_1948(), 
		}, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		smethod_32(bool_53: true);
	}

	private void toolStripMenuItem_35_Click(object sender, EventArgs e)
	{
		bool flag = false;
		bool flag2 = Class302.smethod_2();
		Cursor = Cursors.WaitCursor;
		bool flag3 = Class302.smethod_0() || Class302.smethod_1();
		Cursor = Cursors.Default;
		if (class302_0 == null)
		{
			if (!flag3)
			{
				return;
			}
			class302_0 = new Class302();
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
			class302_0 = null;
			class302_0 = new Class302();
		}
		Form37 form = new Form37(class302_0, flag);
		form.ShowDialog(this);
		form.Dispose();
	}

	private void toolStripMenuItem_41_Click(object sender, EventArgs e)
	{
		if (framework_1 != null && framework_1.method_4() && smethod_87(this, bool_53: true) != DialogResult.Cancel)
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.DoWork += method_203;
			backgroundWorker.ProgressChanged += smethod_69;
			backgroundWorker.RunWorkerCompleted += method_204;
			smethod_66(Class333.smethod_1370());
			backgroundWorker.RunWorkerAsync(false);
		}
	}

	private void method_203(object sender, DoWorkEventArgs e)
	{
		Class23.smethod_3(Class333.smethod_1949());
		BackgroundWorker obj = sender as BackgroundWorker;
		obj.ReportProgress(0);
		Framework framework = new Framework(framework_1.method_10(), framework_1.awZ, framework_1.awz, framework_1.aXA);
		obj.ReportProgress(10);
		Class237.Enum91 @enum = framework.method_1();
		obj.ReportProgress(60);
		Struct40 @struct = default;
		if (@enum == Class237.Enum91.Brc)
		{
			framework.method_15(framework.aWS);
			framework.method_37(framework.awj);
			@struct.Bqe = framework;
			bool bqf = false;
			if (e.Argument != null && e.Argument is bool)
			{
				bqf = (bool)e.Argument;
			}
			@struct.Bqf = bqf;
			@struct.BqF = true;
		}
		else
		{
			@struct.BqF = false;
		}
		e.Result = @struct;
		obj.ReportProgress(90);
		Thread.Sleep(100);
		obj.ReportProgress(100);
	}

	private void method_204(object sender, RunWorkerCompletedEventArgs e)
	{
		Struct40 @struct = (Struct40)e.Result;
		Class23.smethod_3(Class333.smethod_1950() + @struct.BqF + Class333.smethod_9());
		smethod_68();
		if (@struct.BqF)
		{
			method_117();
			smethod_9();
			lock (object_1)
			{
				int_0 |= 64;
			}
			Form19 form = new Form19(string.Empty, bool_5: true, @struct.Bqf, @struct.Bqe, framework_1);
			DialogResult dialogResult = form.ShowDialog(this);
			bool flag = form.method_19();
			string string_ = form.method_20();
			string string_2 = form.method_21();
			form.Dispose();
			if (dialogResult == DialogResult.Abort)
			{
				lock (object_1)
				{
					int_0 &= -65;
					return;
				}
			}
			if (framework_1.awZ == 21 && framework_1.method_12())
			{
				Class329.smethod_0(framework_1, null);
				Class329.smethod_5();
				if (framework_1.awP.method_98())
				{
					Class329.smethod_10();
				}
			}
			framework_1.method_65(form23_0);
			smethod_11();
			if (dialogResult != DialogResult.OK && dialogResult != DialogResult.Yes)
			{
				smethod_10(bool_53: false);
				lock (object_1)
				{
					int_0 &= -65;
				}
				if (@struct.Bqf)
				{
					enum59_0 = Enum59.BpC;
				}
				return;
			}
			if (flag)
			{
				smethod_102(string_, string_2, framework_1);
			}
			if (smethod_28(framework_1.aXc, bool_53: true))
			{
				method_223(null, -1, bool_53: true);
				return;
			}
			lock (object_1)
			{
				int_0 &= -65;
			}
			framework_1.method_73();
			bool flag2 = false;
			bool flag3 = false;
			if (framework_1.method_4())
			{
				Form48.smethod_1(framework_1, out flag2, out var _, out flag3);
			}
			if (!flag2 && !flag3)
			{
				smethod_10(bool_53: false);
			}
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_1951(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private static void smethod_85()
	{
		string empty = string.Empty;
		if (framework_1.method_28(ref empty))
		{
			string text = smethod_99(empty, framework_1.aXc);
			if (string.IsNullOrEmpty(text))
			{
				try
				{
					text = smethod_100(empty, new List<string> { framework_1.aXc });
					framework_1.aXD = text;
					saveFileDialog_0.InitialDirectory = text;
				}
				catch
				{
					saveFileDialog_0.InitialDirectory = string_2 + Class333.smethod_522() + string_18;
				}
			}
			else
			{
				saveFileDialog_0.InitialDirectory = text;
			}
		}
		else
		{
			saveFileDialog_0.InitialDirectory = string_2 + Class333.smethod_522() + string_18;
		}
		saveFileDialog_0.Title = Class333.smethod_1952();
		saveFileDialog_0.Filter = Class333.smethod_1366();
		saveFileDialog_0.AddExtension = true;
		saveFileDialog_0.OverwritePrompt = false;
		string text2 = Class242.smethod_8(framework_1.awZ, framework_1.awz, framework_1.aXA);
		while (true)
		{
			string text3 = null;
			saveFileDialog_0.FileName = Class23.smethod_10(bool_1: false) + text2 + Class333.smethod_146();
			if (saveFileDialog_0.ShowDialog(form23_0) != DialogResult.OK)
			{
				break;
			}
			try
			{
				text3 = saveFileDialog_0.FileName;
			}
			catch (PathTooLongException)
			{
				Form54.smethod_6(form23_0, Class333.smethod_1953(), Class333.smethod_1954(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				text3 = null;
				goto IL_02cb;
			}
			if (!text3.EndsWith(text2 + Class333.smethod_146()))
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text3);
				int num = fileNameWithoutExtension.LastIndexOf('.');
				if (text3.EndsWith(Class333.smethod_146()))
				{
					text3 = text3.Substring(0, text3.Length - Class333.smethod_146().Length);
				}
				if (num != -1)
				{
					string text4 = fileNameWithoutExtension.Substring(num, fileNameWithoutExtension.Length - num);
					string[] array = Class242.smethod_6();
					bool flag = false;
					string[] array2 = array;
					foreach (string value in array2)
					{
						if (text4.StartsWith(value))
						{
							flag = true;
							if (Form54.smethod_6(form23_0, Class333.smethod_1955(), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
							{
								text3 = text3.Substring(0, text3.LastIndexOf(text4)) + text2 + Class333.smethod_146();
								break;
							}
							text3 = null;
						}
					}
					if (text3 != null && !flag)
					{
						text3 = text3 + text2 + Class333.smethod_146();
					}
				}
				else
				{
					text3 = text3 + text2 + Class333.smethod_146();
				}
			}
			if (File.Exists(text3) && Form54.smethod_8(form23_0, Path.GetFileName(text3) + Class333.smethod_1956(), Class333.smethod_1957(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				text3 = null;
			}
			if (text3 != null)
			{
				Class297 @class = new Class297(text3, framework_1, bool_0: true);
				try
				{
					@class.method_0();
				}
				catch (PathTooLongException)
				{
					Form54.smethod_6(form23_0, Class333.smethod_1953(), Class333.smethod_1954(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					text3 = null;
				}
			}
			goto IL_02cb;
			IL_02cb:
			if (text3 != null)
			{
				form23_0.toolStripMenuItem_39.Enabled = true;
				form23_0.toolStripButton_11.Enabled = true;
				framework_1.aXd = false;
				string_19 = text3;
				smethod_6();
				class301_0.method_3(text3);
				break;
			}
		}
	}

	private static void smethod_86()
	{
		if (framework_1 == null)
		{
			return;
		}
		if (string_19 == string.Empty)
		{
			smethod_85();
			return;
		}
		string empty = string.Empty;
		if (framework_1.method_28(ref empty))
		{
			string value = smethod_99(empty, framework_1.aXc);
			if (string.IsNullOrEmpty(value))
			{
				try
				{
					value = smethod_100(empty, new List<string> { framework_1.aXc });
					framework_1.aXD = value;
				}
				catch
				{
				}
			}
		}
		new Class297(string_19, framework_1, bool_0: true).method_0();
		framework_1.aXd = false;
		smethod_6();
	}

	private void toolStripMenuItem_38_Click(object sender, EventArgs e)
	{
		smethod_85();
	}

	private void toolStripButton_11_Click(object sender, EventArgs e)
	{
		smethod_86();
	}

	internal static DialogResult smethod_87(IWin32Window iwin32Window_0, bool bool_53)
	{
		if (framework_1 != null && framework_1.aXd && !bool_14)
		{
			DialogResult dialogResult;
			if (bool_41)
			{
				dialogResult = DialogResult.No;
				smethod_88();
			}
			else
			{
				MessageBoxButtons messageBoxButtons_ = ((!bool_53) ? MessageBoxButtons.YesNo : MessageBoxButtons.YesNoCancel);
				dialogResult = Form54.smethod_9(iwin32Window_0, Class333.smethod_1958(), Class333.smethod_1959(), messageBoxButtons_, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, new string[3]
				{
					Class333.smethod_1529(),
					Class333.smethod_1960(),
					Class333.smethod_823()
				});
				switch (dialogResult)
				{
				case DialogResult.Yes:
					smethod_86();
					break;
				case DialogResult.No:
					smethod_88();
					break;
				}
			}
			return dialogResult;
		}
		return DialogResult.No;
	}

	private static string smethod_88()
	{
		string empty = string.Empty;
		string text2;
		if (framework_1.method_28(ref empty))
		{
			string text = smethod_99(empty, framework_1.aXc);
			if (string.IsNullOrEmpty(text))
			{
				try
				{
					text = smethod_100(empty, new List<string> { framework_1.aXc });
					framework_1.aXD = text;
					text2 = text;
				}
				catch
				{
					text2 = string_2 + Class333.smethod_522() + string_18;
				}
			}
			else
			{
				text2 = text;
			}
		}
		else
		{
			text2 = string_2 + Class333.smethod_522() + string_18;
		}
		string text3 = text2 + Class333.smethod_1961() + Class23.smethod_10(bool_1: false) + Class242.smethod_8(framework_1.awZ, framework_1.awz, framework_1.aXA) + Class333.smethod_146();
		if (File.Exists(text3))
		{
			text3 = text2 + Class333.smethod_1961() + Class23.smethod_10(bool_1: true) + Class242.smethod_8(framework_1.awZ, framework_1.awz, framework_1.aXA) + Class333.smethod_146();
		}
		if (!Directory.Exists(text2 + Class333.smethod_1962()))
		{
			Directory.CreateDirectory(text2 + Class333.smethod_1962());
		}
		new Class297(text3, framework_1, bool_0: true).method_0();
		return text3;
	}

	private void method_205()
	{
		if (Directory.Exists(string_16))
		{
			try
			{
				fileSystemWatcher_2 = new FileSystemWatcher(string_16);
				fileSystemWatcher_2.IncludeSubdirectories = true;
				fileSystemWatcher_2.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size | NotifyFilters.LastWrite | NotifyFilters.CreationTime;
				fileSystemWatcher_2.Filter = Class333.smethod_1963();
				fileSystemWatcher_2.Changed += method_206;
				fileSystemWatcher_2.Created += method_207;
				fileSystemWatcher_2.Deleted += method_208;
				fileSystemWatcher_2.Renamed += method_209;
				fileSystemWatcher_2.EnableRaisingEvents = true;
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.smethod_1964() + ex.Message);
			}
		}
		if (Directory.Exists(string_17))
		{
			try
			{
				FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(string_17);
				fileSystemWatcher.IncludeSubdirectories = true;
				fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size | NotifyFilters.LastWrite | NotifyFilters.CreationTime;
				fileSystemWatcher.Filter = Class333.smethod_1963();
				fileSystemWatcher.Changed += method_206;
				fileSystemWatcher.Created += method_207;
				fileSystemWatcher.Deleted += method_208;
				fileSystemWatcher.Renamed += method_209;
				fileSystemWatcher.EnableRaisingEvents = true;
			}
			catch (Exception ex2)
			{
				Class23.smethod_3(Class333.smethod_1964() + ex2.Message);
			}
		}
	}

	private void method_206(object sender, FileSystemEventArgs e)
	{
		if (e.ChangeType == WatcherChangeTypes.Changed)
		{
			method_210(e.FullPath);
		}
	}

	private void method_207(object sender, FileSystemEventArgs e)
	{
		if (e.ChangeType == WatcherChangeTypes.Created)
		{
			method_210(e.FullPath);
		}
	}

	private void method_208(object sender, FileSystemEventArgs e)
	{
		if (e.ChangeType == WatcherChangeTypes.Deleted)
		{
			method_210(e.FullPath);
		}
	}

	private void method_209(object sender, RenamedEventArgs e)
	{
		if (e.ChangeType == WatcherChangeTypes.Renamed)
		{
			method_210(e.FullPath);
		}
	}

	private void method_210(string string_41)
	{
		if (!bool_42 || !string_41.EndsWith(Class333.smethod_1965()))
		{
			return;
		}
		string text = null;
		try
		{
			text = Path.GetFullPath(string_41);
		}
		catch
		{
			text = null;
		}
		lock (object_0)
		{
			if (text != null && !list_8.Contains(text))
			{
				list_8.Add(text);
			}
		}
	}

	private void method_211()
	{
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.DoWork += method_212;
		backgroundWorker.RunWorkerAsync();
	}

	private void method_212(object sender, DoWorkEventArgs e)
	{
		Thread.CurrentThread.Name = Class333.smethod_1966();
		while (!bool_15)
		{
			if (list_8.Count == 0 && bool_42)
			{
				Thread.Sleep(1000);
				continue;
			}
			lock (object_0)
			{
				smethod_92(Class288.smethod_3(bool_42 ? list_8 : null));
				bool_42 = true;
				list_8.Clear();
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_89(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_5;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_90(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_5;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal static void smethod_91(string string_41, Class287 class287_0)
	{
		if (!dictionary_1.ContainsKey(string_41))
		{
			dictionary_1.Add(string_41, class287_0);
		}
		if (eventHandler_5 != null)
		{
			eventHandler_5(null, null);
		}
	}

	internal static void smethod_92(Dictionary<string, Class287> dictionary_4)
	{
		foreach (string key in dictionary_4.Keys)
		{
			if (!dictionary_1.ContainsKey(key))
			{
				dictionary_1.Add(key, dictionary_4[key]);
			}
		}
		if (eventHandler_5 != null)
		{
			eventHandler_5(null, null);
		}
	}

	internal void method_213()
	{
		if (File.Exists(string_6))
		{
			using StreamReader streamReader = File.OpenText(string_6);
			int num = -1;
			int num2 = -1;
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (text.StartsWith(Class333.smethod_1967()))
				{
					num2 = int.Parse(text.Substring(Class333.smethod_1967().Length));
				}
				else if (text.StartsWith(Class333.smethod_1968()))
				{
					num = int.Parse(text.Substring(Class333.smethod_1968().Length));
				}
				else if (text.StartsWith(Class333.smethod_1969()))
				{
					bool_43 = bool.Parse(text.Substring(Class333.smethod_1969().Length));
				}
				else if (text.StartsWith(Class333.smethod_1970()))
				{
					enum63_1 = (Enum63)int.Parse(text.Substring(Class333.smethod_1970().Length));
				}
				else if (text.StartsWith(Class333.smethod_1971()))
				{
					bool_48 = bool.Parse(text.Substring(Class333.smethod_1971().Length));
				}
				else if (text.StartsWith(Class333.smethod_1972()))
				{
					bool_49 = bool.Parse(text.Substring(Class333.smethod_1972().Length));
				}
				else if (text.StartsWith(Class333.smethod_1973()))
				{
					int_44 = int.Parse(text.Substring(Class333.smethod_1973().Length));
				}
				else if (text.StartsWith(Class333.smethod_1974()))
				{
					int_45 = int.Parse(text.Substring(Class333.smethod_1974().Length));
				}
				else if (text.StartsWith(Class333.smethod_1975()))
				{
					int_46 = int.Parse(text.Substring(Class333.smethod_1975().Length));
				}
				else if (text.StartsWith(Class333.smethod_1976()))
				{
					int_47 = int.Parse(text.Substring(Class333.smethod_1976().Length));
				}
				else if (text.StartsWith(Class333.smethod_1977()))
				{
					bool_50 = bool.Parse(text.Substring(Class333.smethod_1977().Length));
				}
			}
			if (num2 != -1 && Enum.IsDefined(typeof(Enum62), num2))
			{
				enum62_0 = (Enum62)num2;
			}
			else if (num != -1 && Enum.IsDefined(typeof(Enum62), num))
			{
				enum62_0 = (Enum62)num;
			}
			else
			{
				enum62_0 = Enum62.BqH;
			}
		}
		else
		{
			enum62_0 = Enum62.BqH;
			bool_43 = false;
		}
		method_215(bool_53: true);
	}

	internal void method_214()
	{
		if (!Directory.Exists(string_3 + Class333.smethod_557()))
		{
			Directory.CreateDirectory(string_3 + Class333.smethod_557());
		}
		File.Create(string_6).Close();
		List<string> list = new List<string>();
		int num;
		if (enum62_0 > Enum62.BqH)
		{
			if (enum62_0 == Enum62.Bqh)
			{
				list.Add(Class333.smethod_1968() + 0);
			}
			else
			{
				list.Add(Class333.smethod_1968() + 2);
			}
		}
		else
		{
			string text = Class333.smethod_1968();
			num = (int)enum62_0;
			list.Add(text + num);
		}
		string text2 = Class333.smethod_1967();
		num = (int)enum62_0;
		list.Add(text2 + num);
		list.Add(Class333.smethod_1969() + bool_43);
		string text3 = Class333.smethod_1970();
		num = (int)enum63_1;
		list.Add(text3 + num);
		list.Add(Class333.smethod_1971() + bool_48);
		list.Add(Class333.smethod_1972() + bool_49);
		list.Add(Class333.smethod_1973() + int_44);
		list.Add(Class333.smethod_1974() + int_45);
		list.Add(Class333.smethod_1975() + int_46);
		list.Add(Class333.smethod_1976() + int_47);
		list.Add(Class333.smethod_1977() + bool_50);
		File.AppendAllLines(string_6, list);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_93(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_6;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_6, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_94(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_6;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_6, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void method_215(bool bool_53)
	{
		if (bool_14)
		{
			return;
		}
		if (bool_43)
		{
			splitContainer_0.BorderStyle = BorderStyle.FixedSingle;
			class131_3.BorderStyle = BorderStyle.FixedSingle;
			class131_0.BorderStyle = BorderStyle.FixedSingle;
			class131_1.BorderStyle = BorderStyle.FixedSingle;
			class131_2.BorderStyle = BorderStyle.FixedSingle;
		}
		else
		{
			splitContainer_0.BorderStyle = BorderStyle.None;
			class131_3.BorderStyle = BorderStyle.None;
			class131_0.BorderStyle = BorderStyle.None;
			class131_1.BorderStyle = BorderStyle.None;
			class131_2.BorderStyle = BorderStyle.None;
		}
		float_6 = 0f;
		float_5 = 0f;
		float_4 = 0f;
		switch (enum62_0)
		{
		case Enum62.BqG:
			float_4 = 0.2f;
			float_5 = 0.2f;
			float_6 = 0.2f;
			color_10 = SystemColors.ControlLight;
			color_11 = SystemColors.Control;
			color_12 = Color.Black;
			color_13 = Color.Blue;
			color_14 = Color.Black;
			color_15 = Color.White;
			color_16 = Color.White;
			color_17 = Color.White;
			color_20 = Color.White;
			color_18 = Color.Black;
			color_19 = color_0;
			color_21 = Color.White;
			color_22 = Color.LightGray;
			color_23 = Color.Black;
			color_24 = Color.Black;
			color_25 = Color.Black;
			color_30 = Color.White;
			color_31 = Color.DodgerBlue;
			color_32 = Color.White;
			color_35 = Color.LightGray;
			color_36 = Color.Gray;
			class131_0.BackColor = Color.White;
			class131_1.BackColor = Color.White;
			class131_2.BackColor = Color.White;
			class131_3.BackColor = Color.White;
			break;
		case Enum62.Bqg:
			float_4 = 0.8f;
			float_5 = 0.8f;
			float_6 = 0.8f;
			color_10 = Color.Black;
			color_11 = Color.Black;
			color_12 = Color.White;
			color_13 = Color.White;
			color_14 = color_0;
			color_15 = Color.Black;
			color_16 = Color.Black;
			color_17 = Color.Black;
			color_20 = Color.Black;
			color_18 = color_10;
			color_19 = color_14;
			color_21 = Color.DodgerBlue;
			color_22 = Color.White;
			color_23 = Color.White;
			color_24 = Color.Black;
			color_25 = Color.Black;
			color_26 = Color.Black;
			color_27 = Color.White;
			color_28 = Color.LightBlue;
			color_29 = Color.Cyan;
			color_33 = Color.Black;
			color_34 = Color.White;
			color_30 = color_5;
			color_31 = Color.DodgerBlue;
			color_32 = Color.Black;
			color_35 = Color.Black;
			color_36 = Color.Gray;
			class131_0.BackColor = Color.Black;
			class131_1.BackColor = Color.Black;
			class131_2.BackColor = Color.Black;
			class131_3.BackColor = Color.Black;
			break;
		case Enum62.BqH:
			float_4 = 0.7f;
			float_5 = 0.7f;
			float_6 = 0.7f;
			color_10 = color_4;
			color_11 = color_1;
			color_12 = Color.White;
			color_13 = Color.White;
			color_14 = color_0;
			color_15 = color_4;
			color_16 = color_1;
			color_17 = color_1;
			color_20 = color_1;
			color_18 = color_10;
			color_19 = color_14;
			color_21 = Color.White;
			color_22 = color_1;
			color_23 = Color.Black;
			color_24 = Color.White;
			color_25 = Color.White;
			color_26 = color_5;
			color_27 = color_6;
			color_28 = color_2;
			color_29 = Color.White;
			color_33 = color_5;
			color_34 = Color.Black;
			color_30 = color_5;
			color_31 = Color.DodgerBlue;
			color_32 = color_4;
			color_35 = color_4;
			color_36 = Color.Gray;
			class131_0.BackColor = color_3;
			class131_1.BackColor = color_3;
			class131_2.BackColor = color_3;
			class131_3.BackColor = color_3;
			break;
		case Enum62.Bqh:
			float_4 = 0.2f;
			float_5 = 0.2f;
			float_6 = 0.2f;
			color_10 = SystemColors.ControlLight;
			color_11 = SystemColors.Control;
			color_12 = Color.Black;
			color_13 = Color.Blue;
			color_14 = Color.Black;
			color_15 = Color.White;
			color_16 = Color.White;
			color_17 = Color.White;
			color_18 = color_10;
			color_19 = color_14;
			color_20 = Color.White;
			color_21 = Color.White;
			color_22 = Color.LightGray;
			color_23 = Color.Black;
			color_24 = Color.Black;
			color_25 = Color.Black;
			color_30 = Color.White;
			color_31 = Color.DodgerBlue;
			color_32 = Color.White;
			color_35 = Color.LightGray;
			color_36 = Color.Gray;
			class131_0.BackColor = Color.White;
			class131_1.BackColor = Color.White;
			class131_2.BackColor = Color.White;
			class131_3.BackColor = Color.White;
			break;
		}
		class167_0.method_0();
		class163_0.method_0();
		class169_0.method_0();
		class162_0.method_4();
		class168_0.method_0();
		class165_0.method_0();
		class170_0.method_0();
		class164_0.method_0();
		if (toolStripButton_10.Image != null)
		{
			toolStripButton_10.Image.Dispose();
		}
		toolStripButton_10.Image = Class25.smethod_0(GeneralResources.IconNavigationTree, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_0.Image != null)
		{
			toolStripButton_0.Image.Dispose();
		}
		toolStripButton_0.Image = Class25.smethod_0(GeneralResources.IconNewMap, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_6.Image != null)
		{
			toolStripButton_6.Image.Dispose();
		}
		toolStripButton_6.Image = Class25.smethod_0(GeneralResources.IconOpenMap, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_11.Image != null)
		{
			toolStripButton_11.Image.Dispose();
		}
		toolStripButton_11.Image = Class25.smethod_0(GeneralResources.IconSaveMap, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_1.Image != null)
		{
			toolStripButton_1.Image.Dispose();
		}
		toolStripButton_1.Image = Class25.smethod_0(GeneralResources.IconImportMap, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_2.Image != null)
		{
			toolStripButton_2.Image.Dispose();
		}
		toolStripButton_2.Image = Class25.smethod_0(GeneralResources.IconUndo, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_3.Image != null)
		{
			toolStripButton_3.Image.Dispose();
		}
		toolStripButton_3.Image = Class25.smethod_0(GeneralResources.IconRedo, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_8.Image != null)
		{
			toolStripButton_8.Image.Dispose();
		}
		toolStripButton_8.Image = Class25.smethod_0(GeneralResources.IconTableProperties, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_4.Image != null)
		{
			toolStripButton_4.Image.Dispose();
		}
		toolStripButton_4.Image = Class25.smethod_0(GeneralResources.IconWiring, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_5.Image != null)
		{
			toolStripButton_5.Image.Dispose();
		}
		toolStripButton_5.Image = Class25.smethod_0(GeneralResources.IconScope, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_14.Image != null)
		{
			toolStripButton_14.Image.Dispose();
		}
		toolStripButton_14.Image = Class25.smethod_0(GeneralResources.IconCANBusViewer, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_7.Image != null)
		{
			toolStripButton_7.Image.Dispose();
		}
		toolStripButton_7.Image = Class25.smethod_0(GeneralResources.IconPassword, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripDropDownButton_0.Image != null)
		{
			toolStripDropDownButton_0.Image.Dispose();
		}
		toolStripDropDownButton_0.Image = Class25.smethod_0(GeneralResources.IconResourceLibrary, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_13.Image != null)
		{
			toolStripButton_13.Image.Dispose();
		}
		toolStripButton_13.Image = Class25.smethod_0(GeneralResources.IconErrorConfig, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (toolStripButton_9.Image != null)
		{
			toolStripButton_9.Image.Dispose();
		}
		toolStripButton_9.Image = Class25.smethod_0(GeneralResources.IconEmail, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		bool flag = false;
		if (toolStripButton_12.Image == image_1)
		{
			toolStripButton_12.Image = null;
			flag = true;
		}
		if (image_1 != null)
		{
			image_1.Dispose();
		}
		image_1 = Class25.smethod_0(GeneralResources.IconHelp, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (flag)
		{
			toolStripButton_12.Image = image_1;
		}
		flag = false;
		if (toolStripButton_12.Image == image_0)
		{
			toolStripButton_12.Image = null;
			flag = true;
		}
		if (image_0 != null)
		{
			image_0.Dispose();
		}
		image_0 = Class25.smethod_0(GeneralResources.IconHelp, 1f, 0f, 0f, 0f, 0f, 0f, 0.66f, 1f);
		if (flag)
		{
			toolStripButton_12.Image = image_0;
		}
		WiringPin.smethod_1(float_4, float_5, float_6);
		PortFunction.smethod_7(float_4, float_5, float_6);
		if (image_2 != null)
		{
			image_2.Dispose();
		}
		image_2 = Class25.smethod_0(GeneralResources.BackArrow, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		if (image_3 != null)
		{
			image_3.Dispose();
		}
		image_3 = Class25.smethod_0(GeneralResources.ForwardArrow, 1f, 0f, 0f, 0f, 0f, float_4, float_5, float_6);
		control3_0.method_13();
		if (bool_53)
		{
			class165_0.method_1();
			class170_0.method_1();
			class164_0.method_1();
			toolStripButton_12.Image = image_1;
			class163_0.method_1();
			class169_0.method_1();
			class162_0.method_5();
		}
		BackColor = color_10;
		control25_0.TabPages[0].BackColor = color_10;
		control25_0.TabPages[1].BackColor = color_10;
		menuStrip_0.BackColor = color_11;
		foreach (ToolStripItem item in menuStrip_0.Items)
		{
			item.ForeColor = color_12;
			if (!(item is ToolStripMenuItem))
			{
				continue;
			}
			ToolStripMenuItem obj = item as ToolStripMenuItem;
			obj.DropDown.ForeColor = color_12;
			obj.DropDown.BackColor = color_15;
			foreach (ToolStripItem dropDownItem in obj.DropDownItems)
			{
				if (dropDownItem is ToolStripMenuItem)
				{
					ToolStripMenuItem obj2 = dropDownItem as ToolStripMenuItem;
					obj2.DropDown.ForeColor = color_12;
					obj2.DropDown.BackColor = color_15;
				}
			}
		}
		toolStrip_0.BackColor = color_11;
		foreach (ToolStripItem item2 in toolStrip_0.Items)
		{
			if (!(item2 is ToolStripDropDownButton))
			{
				continue;
			}
			ToolStripDropDownButton obj3 = item2 as ToolStripDropDownButton;
			obj3.DropDown.ForeColor = color_12;
			obj3.DropDown.BackColor = color_15;
			foreach (ToolStripItem dropDownItem2 in obj3.DropDownItems)
			{
				if (dropDownItem2 is ToolStripMenuItem)
				{
					ToolStripMenuItem obj4 = dropDownItem2 as ToolStripMenuItem;
					obj4.DropDown.ForeColor = color_12;
					obj4.DropDown.BackColor = color_15;
				}
			}
		}
		label_0.BackColor = color_10;
		label_0.ForeColor = color_12;
		label_3.ForeColor = color_12;
		panel_1.BackColor = color_11;
		label_1.ForeColor = color_12;
		panel_2.BackColor = color_11;
		label_2.ForeColor = color_12;
		foreach (Label item3 in list_6)
		{
			item3.ForeColor = color_12;
		}
		startupOptionsPanel_0.method_0();
		control3_0.method_0();
		if (control2_0 != null)
		{
			control2_0.method_22();
		}
		if (form21_0 != null)
		{
			form21_0.method_0();
		}
		if (bool_53)
		{
			control4_0.method_9();
		}
		else
		{
			smethod_10(bool_53: false);
		}
		if (eventHandler_6 != null)
		{
			eventHandler_6(null, null);
		}
	}

	private void method_216(object sender, PaintEventArgs e)
	{
		if (enum62_0 != Enum62.BqG && enum62_0 != Enum62.Bqh)
		{
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			if (toolStripMenuItem.DropDown.Visible)
			{
				Size size = TextRenderer.MeasureText(e.Graphics, toolStripMenuItem.Text, toolStripMenuItem.Font);
				TextRenderer.DrawText(pt: new Point(toolStripMenuItem.Width / 2 - size.Width / 2, toolStripMenuItem.Height / 2 - size.Height / 2), dc: e.Graphics, text: toolStripMenuItem.Text, font: toolStripMenuItem.Font, foreColor: Color.Black);
			}
		}
	}

	private void toolStripMenuItem_21_Click(object sender, EventArgs e)
	{
		method_117();
		Form55 form = new Form55();
		form.ShowDialog(this);
		form.Dispose();
	}

	private void method_217(object sender, ItemDragEventArgs e)
	{
		if (e.Button != MouseButtons.Left)
		{
			return;
		}
		MenuNode menuNode = (MenuNode)((TreeNode)e.Item).Tag;
		if (menuNode.method_5() == null)
		{
			return;
		}
		bool flag = false;
		if (menuNode.method_60() != -1 && (e.Item as TreeNode).Parent != null && (e.Item as TreeNode).Parent.Tag == menuNode_1 && (e.Item as TreeNode).Parent.Nodes.Count > 1)
		{
			flag = true;
			bool_51 = true;
		}
		if (menuNode.method_5().method_17())
		{
			flag = true;
		}
		if (!flag)
		{
			SettingOrSpecialObject settingOrSpecialObject = framework_1.method_33(menuNode.method_3());
			if (settingOrSpecialObject != null)
			{
				if (settingOrSpecialObject is Table || settingOrSpecialObject is Class255)
				{
					flag = true;
				}
			}
			else
			{
				foreach (MenuNode item in menuNode.method_6())
				{
					if (item.method_28() && !item.method_35() && !item.method_31())
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (flag)
		{
			treeNode_0 = e.Item as TreeNode;
			menuNode_3 = menuNode;
			label_3.Text = treeNode_0.Text;
			label_3.Location = PointToClient(new Point(Control.MousePosition.X, Control.MousePosition.Y));
			label_3.Visible = true;
			label_3.BringToFront();
		}
	}

	private void method_218(int int_49, int int_50)
	{
		if (menuNode_3.method_5().method_43())
		{
			framework_1.awp.method_78(int_49, int_50);
		}
		else if (menuNode_3.method_5().method_44())
		{
			framework_1.awP.method_87(int_49, int_50);
		}
		else if (menuNode_3.method_5().method_37())
		{
			framework_1.awP.method_79()[menuNode_3.method_5().method_39()].method_77(int_49, int_50);
		}
		else if (menuNode_3.method_5().method_5() != null && menuNode_3.method_5().method_5().method_37())
		{
			framework_1.awP.method_79()[menuNode_3.method_5().method_5().method_39()].method_77(int_49, int_50);
		}
	}

	private void method_219()
	{
		if (Control.MouseButtons == MouseButtons.Left)
		{
			if (menuNode_3 == null)
			{
				return;
			}
			label_3.Location = PointToClient(new Point(Control.MousePosition.X, Control.MousePosition.Y));
			label_3.Visible = true;
			label_3.BringToFront();
			Cursor current = Cursors.No;
			int_48 = -1;
			Point point = new Point
			{
				X = label_3.Location.X - (control25_0.Left + control25_0.SelectedTab.Left),
				Y = label_3.Location.Y - (splitContainer_0.Top + control25_0.Top + control25_0.SelectedTab.Top)
			};
			if (control25_0.SelectedTab.ClientRectangle.Contains(point))
			{
				control25_0.method_36(point, menuNode_3);
				current = Cursors.Default;
			}
			else
			{
				menuNode_3.method_60();
				Point pt = new Point
				{
					X = label_3.Location.X - (control4_0.Left + control4_0.method_0().Left),
					Y = label_3.Location.Y - (control4_0.Top + control4_0.method_0().Top)
				};
				if (control4_0.method_0().ClientRectangle.Contains(pt))
				{
					if (!bool_51 && !menuNode_3.method_5().method_17())
					{
						current = Cursors.Default;
					}
					else
					{
						TreeNode treeNode = control4_0.method_0().method_41(pt.X, pt.Y, out var rectangle_);
						if (treeNode != null)
						{
							if (treeNode != treeNode_0)
							{
								MenuNode menuNode = (MenuNode)treeNode.Tag;
								bool flag = menuNode != null && menuNode.method_5() != null && menuNode.method_5().method_17();
								if (treeNode.Tag == menuNode_1)
								{
									current = Cursors.Default;
									int_48 = 0;
									control4_0.method_0().method_7(treeNode_0.Parent.Nodes[0]);
									control4_0.method_0().method_8(null);
								}
								else if ((treeNode.Parent != null && treeNode.Parent.Tag == menuNode_1) | flag)
								{
									int num = treeNode_0.Parent.Nodes.IndexOf(treeNode_0);
									int num2 = treeNode.Parent.Nodes.IndexOf(treeNode);
									if (num != -1 && num2 != -1)
									{
										current = Cursors.Default;
										if (control4_0.method_0().method_0() != Enum45.const_0 && control4_0.method_0().method_0() != Enum45.const_2)
										{
											if (pt.X < rectangle_.X + rectangle_.Width / 2)
											{
												int_48 = num2;
												control4_0.method_0().method_7(treeNode);
												control4_0.method_0().method_8(null);
											}
											else
											{
												int_48 = num2 + 1;
												control4_0.method_0().method_7(null);
												control4_0.method_0().method_8(treeNode);
											}
										}
										else if (pt.Y < rectangle_.Y + rectangle_.Height / 2)
										{
											int_48 = num2;
											control4_0.method_0().method_7(treeNode);
											control4_0.method_0().method_8(null);
										}
										else
										{
											int_48 = num2 + 1;
											control4_0.method_0().method_7(null);
											control4_0.method_0().method_8(treeNode);
										}
										if (int_48 > 0 && int_48 > num)
										{
											int_48--;
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
				}
			}
			System.Windows.Forms.Cursor.Current = current;
			if (int_48 == -1)
			{
				control4_0.method_0().method_7(null);
				control4_0.method_0().method_8(null);
			}
			return;
		}
		if (menuNode_3 != null)
		{
			Point point2 = new Point
			{
				X = label_3.Location.X - (control25_0.Left + control25_0.SelectedTab.Left),
				Y = label_3.Location.Y - (splitContainer_0.Top + control25_0.Top + control25_0.SelectedTab.Top)
			};
			if (control25_0.SelectedTab.ClientRectangle.Contains(point2))
			{
				control25_0.method_35(point2, menuNode_3);
			}
			else
			{
				int num3 = menuNode_3.method_60();
				Point pt2 = new Point
				{
					X = label_3.Location.X - (control4_0.Left + control4_0.method_0().Left),
					Y = label_3.Location.Y - (control4_0.Top + control4_0.method_0().Top)
				};
				if (control4_0.method_0().ClientRectangle.Contains(pt2))
				{
					if (bool_51)
					{
						if (int_48 != -1)
						{
							control4_0.method_88(num3, int_48);
						}
						bool_51 = false;
					}
					else if (menuNode_3.method_5() != null && menuNode_3.method_5().method_17() && int_48 != -1)
					{
						MenuNode menuNode2 = menuNode_3;
						MenuNode menuNode3 = (MenuNode)treeNode_0.Parent.Nodes[int_48].Tag;
						if (menuNode3 != null)
						{
							int int_ = -1;
							int int_2 = -1;
							if (menuNode2.method_45())
							{
								int_ = menuNode2.method_46();
								int_2 = menuNode3.method_46();
							}
							else if (menuNode2.method_37())
							{
								int_ = menuNode2.method_39();
								int_2 = menuNode3.method_39();
							}
							else if (menuNode2.method_38())
							{
								int_ = menuNode2.method_41();
								int_2 = menuNode3.method_41();
							}
							method_218(int_, int_2);
							control4_0.method_0().method_4(treeNode_0.Parent.Nodes[int_48]);
							control4_0.method_14(bool_7: true, bool_8: true, bool_9: false, bool_10: false);
							if (control4_0.method_0().method_3() != null && control4_0.method_0().method_3().Tag == menuNode_3.method_5())
							{
								control4_0.method_46(control4_0.method_0().method_3(), bool_7: true, bool_8: true);
							}
						}
					}
				}
			}
			System.Windows.Forms.Cursor.Current = Cursors.Default;
			control4_0.method_0().method_7(null);
			control4_0.method_0().method_8(null);
		}
		treeNode_0 = null;
		menuNode_3 = null;
		bool_51 = false;
		label_3.Text = string.Empty;
		label_3.Visible = false;
		int_48 = -1;
	}

	private void method_220()
	{
		treeNode_0 = null;
		menuNode_3 = null;
		bool_51 = false;
		label_3.Text = string.Empty;
		label_3.AutoSize = true;
		label_3.Visible = false;
		label_3.Font = new Font(control4_0.Font.FontFamily, control4_0.Font.Size, FontStyle.Bold);
		label_3.BackColor = Color.Transparent;
		Controls.Add(label_3);
	}

	internal static Class280 smethod_95()
	{
		if (Form48.smethod_2())
		{
			if (Form48.menuNode_0 != null)
			{
				return Form48.menuNode_0.method_0();
			}
			return null;
		}
		if (Form47.smethod_0() && form47_0 != null && form47_0.Visible && form47_0.ContainsFocus)
		{
			if (Form47.menuNode_0 != null)
			{
				return Form47.menuNode_0.method_0();
			}
			return null;
		}
		if (Form6.form6_0 != null)
		{
			return Form6.form6_0.class280_0;
		}
		Class90 @class = form23_0.control25_0.method_33();
		if (@class != null)
		{
			return @class.method_12();
		}
		if (form23_0.control4_0.method_0().method_3() != null && form23_0.control4_0.method_0().method_3().Tag is MenuNode)
		{
			MenuNode menuNode = form23_0.control4_0.method_0().method_3().Tag as MenuNode;
			if (menuNode.method_38() && form23_0.control4_0.method_0().method_3().Parent != null && form23_0.control4_0.method_0().method_3().Parent.Tag is MenuNode && (form23_0.control4_0.method_0().method_3().Parent.Tag as MenuNode).method_37())
			{
				return (form23_0.control4_0.method_0().method_3().Parent.Tag as MenuNode).method_0();
			}
			return menuNode?.method_0();
		}
		return null;
	}

	private void method_221()
	{
		Class280 @class = smethod_95();
		bool enabled = @class?.method_11() ?? false;
		bool enabled2 = @class?.method_12() ?? false;
		toolStripMenuItem_11.Enabled = enabled;
		toolStripButton_2.Enabled = enabled;
		toolStripMenuItem_12.Enabled = enabled2;
		toolStripButton_3.Enabled = enabled2;
	}

	internal void toolStripButton_2_Click(object sender, EventArgs e)
	{
		bool_52 = true;
		Class280 @class = smethod_95();
		TreeNode treeNode = smethod_96();
		@class?.method_6();
		Application.DoEvents();
		if (treeNode != null && form23_0.control4_0.method_0().method_3() == null)
		{
			form23_0.control4_0.method_0().method_4(treeNode);
			if (Class88.Bhl != null)
			{
				Class88.Bhl.method_16(0);
			}
		}
		bool_52 = false;
	}

	internal void toolStripButton_3_Click(object sender, EventArgs e)
	{
		bool_52 = true;
		Class280 @class = smethod_95();
		TreeNode treeNode = smethod_96();
		@class?.method_7();
		Application.DoEvents();
		if (treeNode != null && form23_0.control4_0.method_0().method_3() == null)
		{
			form23_0.control4_0.method_0().method_4(treeNode);
			if (Class88.Bhl != null)
			{
				Class88.Bhl.method_16(0);
			}
		}
		bool_52 = false;
	}

	private static TreeNode smethod_96()
	{
		TreeNode result = null;
		if (form23_0.control4_0.method_0().method_3() != null && form23_0.control4_0.method_0().method_3().Tag is MenuNode && (form23_0.control4_0.method_0().method_3().Tag as MenuNode).method_38() && form23_0.control4_0.method_0().method_3().Parent != null && form23_0.control4_0.method_0().method_3().Parent.Tag is MenuNode && (form23_0.control4_0.method_0().method_3().Parent.Tag as MenuNode).method_37())
		{
			result = form23_0.control4_0.method_0().method_3().Parent;
		}
		return result;
	}

	internal static List<string> smethod_97(string string_41)
	{
		List<string> list = new List<string>();
		if (!string.IsNullOrEmpty(string_41))
		{
			string path = string_2 + Class333.smethod_522() + string_18;
			if (Directory.Exists(path))
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					int num = text.IndexOf(string_18);
					int length = string_18.Length;
					string text2 = text.Substring(num + length + 1);
					if (text2 == string_41 || text2.StartsWith(string_41 + Class333.smethod_100()))
					{
						list.Add(text);
					}
				}
			}
		}
		return list;
	}

	internal static string smethod_98(string string_41)
	{
		string path = string_2 + Class333.smethod_522() + string_18;
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text in directories)
			{
				string[] files = Directory.GetFiles(text, Class333.smethod_1978());
				for (int j = 0; j < files.Length; j++)
				{
					if (!files[j].EndsWith(Class333.smethod_1979()))
					{
						continue;
					}
					using (StreamReader streamReader = File.OpenText(files[j]))
					{
						string text2;
						while ((text2 = streamReader.ReadLine()) != null)
						{
							if (text2.Equals(string_41))
							{
								return text;
							}
						}
					}
					break;
				}
			}
		}
		return string.Empty;
	}

	internal static string smethod_99(string string_41, string string_42)
	{
		if (Directory.Exists(string_2 + Class333.smethod_522() + string_18))
		{
			foreach (string item in smethod_97(string_41))
			{
				bool flag = false;
				string[] files = Directory.GetFiles(item, Class333.smethod_1978());
				for (int i = 0; i < files.Length; i++)
				{
					if (!files[i].EndsWith(Class333.smethod_1979()))
					{
						continue;
					}
					using (StreamReader streamReader = File.OpenText(files[i]))
					{
						string text;
						while ((text = streamReader.ReadLine()) != null)
						{
							if (text.Equals(string_42))
							{
								flag = true;
								break;
							}
						}
					}
					break;
				}
				if (flag)
				{
					return item;
				}
			}
		}
		return string.Empty;
	}

	internal static string smethod_100(string string_41, List<string> list_9)
	{
		string text = string_2 + Class333.smethod_522() + string_18;
		string text2 = text + Class333.smethod_176() + string_41;
		if (Directory.Exists(text2))
		{
			int num = 2;
			do
			{
				text2 = text + Class333.smethod_176() + string_41 + Class333.smethod_100() + num;
				num++;
			}
			while (Directory.Exists(text2));
		}
		Directory.CreateDirectory(text2);
		smethod_101(text2, list_9);
		return text2;
	}

	internal static void smethod_101(string string_41, List<string> list_9)
	{
		string path = string_41 + Class333.smethod_1980();
		foreach (string item in list_9)
		{
			if (string.IsNullOrWhiteSpace(item))
			{
				continue;
			}
			bool flag = false;
			if (File.Exists(path))
			{
				using StreamReader streamReader = File.OpenText(path);
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					if (text.Equals(item))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				File.AppendAllText(path, item + Class333.smethod_537());
			}
			string path2 = string_2 + Class333.smethod_522() + string_18;
			if (!Directory.Exists(path2))
			{
				continue;
			}
			string[] directories = Directory.GetDirectories(path2);
			foreach (string path3 in directories)
			{
				if (!(Path.GetFullPath(path3) != Path.GetFullPath(string_41)))
				{
					continue;
				}
				string[] files = Directory.GetFiles(path3, Class333.smethod_1978());
				for (int j = 0; j < files.Length; j++)
				{
					if (!files[j].EndsWith(Class333.smethod_1979()))
					{
						continue;
					}
					List<string> list = new List<string>();
					bool flag2 = false;
					using (StreamReader streamReader2 = File.OpenText(files[j]))
					{
						string text2;
						while ((text2 = streamReader2.ReadLine()) != null)
						{
							if (!string.IsNullOrWhiteSpace(text2))
							{
								if (text2.Equals(item))
								{
									flag2 = true;
								}
								else
								{
									list.Add(text2);
								}
							}
						}
					}
					if (!flag2)
					{
						break;
					}
					File.Delete(files[j]);
					foreach (string item2 in list)
					{
						File.AppendAllText(files[j], item2 + Class333.smethod_537());
					}
					break;
				}
			}
		}
	}

	internal static bool smethod_102(string string_41, string string_42, Framework framework_2)
	{
		if (Framework.smethod_0(string_42))
		{
			string text = smethod_99(string_41, framework_2.aXc);
			List<string> list = smethod_97(string_42);
			if (list.Count == 0)
			{
				if (string.IsNullOrEmpty(text))
				{
					try
					{
						string aXD = smethod_100(string_42, new List<string> { framework_2.aXc });
						framework_2.aXD = aXD;
					}
					catch
					{
					}
				}
				else if (Form54.smethod_7(form23_0, Class333.smethod_1981() + string_41 + Class333.smethod_1982() + string_41 + Class333.smethod_1983() + string_42 + Class333.smethod_1984() + string_42 + Class333.smethod_1985(), Class333.smethod_1986(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, new string[2]
				{
					Class333.smethod_1987(),
					Class333.smethod_1988()
				}) == DialogResult.Yes)
				{
					try
					{
						string text2 = string_2 + Class333.smethod_522() + string_18 + Class333.smethod_176() + string_42;
						Directory.Move(text, text2);
						framework_2.aXD = text2;
					}
					catch
					{
					}
				}
				else
				{
					try
					{
						smethod_103(text, framework_2.aXD = smethod_100(string_42, new List<string> { framework_2.aXc }));
					}
					catch
					{
					}
				}
			}
			else if (list.Count == 1)
			{
				if (string.IsNullOrEmpty(text))
				{
					if (Form54.smethod_7(form23_0, Class333.smethod_1981() + string_42 + Class333.smethod_1989() + string_42 + Class333.smethod_1990(), Class333.smethod_1986(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, new string[2]
					{
						Class333.smethod_1991(),
						Class333.smethod_1988()
					}) == DialogResult.Yes)
					{
						try
						{
							smethod_101(list[0], new List<string> { framework_2.aXc });
							framework_2.aXD = list[0];
						}
						catch
						{
						}
					}
					else
					{
						try
						{
							string aXD2 = smethod_100(string_42, new List<string> { framework_2.aXc });
							framework_2.aXD = aXD2;
						}
						catch
						{
						}
					}
				}
				else
				{
					switch (Form54.smethod_7(form23_0, Class333.smethod_1981() + string_41 + Class333.smethod_1992() + string_42 + Class333.smethod_1993() + string_42 + Class333.smethod_1994() + string_41 + Class333.smethod_1983() + string_42 + Class333.smethod_1995() + string_42 + Class333.smethod_1990(), Class333.smethod_1986(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, new string[3]
					{
						Class333.smethod_1991(),
						Class333.smethod_1987(),
						Class333.smethod_1988()
					}))
					{
					case DialogResult.Yes:
						try
						{
							smethod_101(list[0], new List<string> { framework_2.aXc });
							framework_2.aXD = list[0];
							smethod_103(text, framework_2.aXD);
						}
						catch
						{
						}
						break;
					case DialogResult.No:
						try
						{
							string text3 = string_2 + Class333.smethod_522() + string_18 + Class333.smethod_176() + string_42 + Class333.smethod_1996();
							Directory.Move(text, text3);
							framework_2.aXD = text3;
						}
						catch
						{
						}
						break;
					default:
						try
						{
							smethod_103(text, framework_2.aXD = smethod_100(string_42, new List<string> { framework_2.aXc }));
						}
						catch
						{
						}
						break;
					}
				}
			}
			else if (list.Count > 1)
			{
				if (string.IsNullOrEmpty(text))
				{
					bool flag = false;
					do
					{
						if (Form54.smethod_7(form23_0, Class333.smethod_1997() + string_42 + Class333.smethod_1998() + string_42 + Class333.smethod_1999() + string_42 + Class333.smethod_2000(), Class333.smethod_1986(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, new string[2]
						{
							Class333.smethod_2001(),
							Class333.smethod_1988()
						}) != DialogResult.Yes)
						{
							try
							{
								string aXD3 = smethod_100(string_42, new List<string> { framework_2.aXc });
								framework_2.aXD = aXD3;
								flag = true;
							}
							catch
							{
							}
							continue;
						}
						try
						{
							FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
							{
								Description = Class333.smethod_2002() + string_42 + Class333.smethod_2003(),
								SelectedPath = list[0],
								ShowNewFolderButton = false
							};
							if (folderBrowserDialog.ShowDialog(form23_0) == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
							{
								string name = new DirectoryInfo(folderBrowserDialog.SelectedPath).Name;
								if (!(name == string_42) && !name.StartsWith(string_42 + Class333.smethod_100()))
								{
									Form54.smethod_6(form23_0, Class333.smethod_2004() + string_42 + Class333.smethod_2005(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								}
								else
								{
									smethod_101(folderBrowserDialog.SelectedPath, new List<string> { framework_2.aXc });
									framework_2.aXD = folderBrowserDialog.SelectedPath;
									flag = true;
								}
							}
							folderBrowserDialog.Dispose();
						}
						catch
						{
						}
					}
					while (!flag);
				}
				else
				{
					bool flag2 = false;
					do
					{
						switch (Form54.smethod_7(form23_0, Class333.smethod_1981() + string_41 + Class333.smethod_2006() + string_42 + Class333.smethod_1998() + string_42 + Class333.smethod_2007() + string_41 + Class333.smethod_1983() + string_42 + Class333.smethod_2008() + string_42 + Class333.smethod_2000(), Class333.smethod_1986(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, new string[3]
						{
							Class333.smethod_2001(),
							Class333.smethod_1987(),
							Class333.smethod_1988()
						}))
						{
						case DialogResult.No:
							try
							{
								string text4 = string_2 + Class333.smethod_522() + string_18 + Class333.smethod_176() + string_42;
								if (Directory.Exists(text4))
								{
									int num = 2;
									do
									{
										text4 = string_2 + Class333.smethod_522() + string_18 + Class333.smethod_176() + string_42 + Class333.smethod_100() + num;
										num++;
									}
									while (Directory.Exists(text4));
								}
								Directory.Move(text, text4);
								framework_2.aXD = text4;
								flag2 = true;
							}
							catch
							{
							}
							break;
						default:
							try
							{
								smethod_103(text, framework_2.aXD = smethod_100(string_42, new List<string> { framework_2.aXc }));
								flag2 = true;
							}
							catch
							{
							}
							break;
						case DialogResult.Yes:
							try
							{
								FolderBrowserDialog folderBrowserDialog2 = new FolderBrowserDialog
								{
									Description = Class333.smethod_2002() + string_42 + Class333.smethod_2003(),
									SelectedPath = list[0],
									ShowNewFolderButton = false
								};
								if (folderBrowserDialog2.ShowDialog(form23_0) == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog2.SelectedPath))
								{
									string name2 = new DirectoryInfo(folderBrowserDialog2.SelectedPath).Name;
									if (!(name2 == string_42) && !name2.StartsWith(string_42 + Class333.smethod_100()))
									{
										Form54.smethod_6(form23_0, Class333.smethod_2004() + string_42 + Class333.smethod_2005(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
									}
									else
									{
										smethod_101(folderBrowserDialog2.SelectedPath, new List<string> { framework_2.aXc });
										framework_2.aXD = folderBrowserDialog2.SelectedPath;
										smethod_103(text, framework_2.aXD);
										flag2 = true;
									}
								}
								folderBrowserDialog2.Dispose();
							}
							catch
							{
							}
							break;
						}
					}
					while (!flag2);
				}
			}
			smethod_6();
			return true;
		}
		smethod_6();
		return false;
	}

	private static bool smethod_103(string string_41, string string_42)
	{
		try
		{
			string path = Path.Combine(string_41, Class333.smethod_2009());
			if (Directory.Exists(path))
			{
				string text = Path.Combine(string_42, Class333.smethod_2009());
				Class22.smethod_0(path, text, bool_0: true, Class22.Enum18.Bgt);
				return true;
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_2010() + string_41 + Class333.smethod_2011() + string_42 + Class333.smethod_1802() + ex.Message);
		}
		return false;
	}

	internal static void smethod_104(Framework framework_2)
	{
		string empty = string.Empty;
		if (!framework_2.method_28(ref empty))
		{
			return;
		}
		string text = smethod_99(empty, framework_2.aXc);
		if (string.IsNullOrEmpty(text))
		{
			List<string> list = smethod_97(empty);
			if (list.Count == 0)
			{
				try
				{
					string aXD = smethod_100(empty, new List<string> { framework_2.aXc });
					framework_2.aXD = aXD;
					return;
				}
				catch
				{
					return;
				}
			}
			if (list.Count == 1)
			{
				if (Form54.smethod_7(form23_0, Class333.smethod_1981() + empty + Class333.smethod_1989() + empty + Class333.smethod_1990(), Class333.smethod_1986(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, new string[2]
				{
					Class333.smethod_1991(),
					Class333.smethod_1988()
				}) == DialogResult.Yes)
				{
					try
					{
						smethod_101(list[0], new List<string> { framework_2.aXc });
						framework_2.aXD = list[0];
						return;
					}
					catch
					{
						return;
					}
				}
				try
				{
					string aXD2 = smethod_100(empty, new List<string> { framework_2.aXc });
					framework_2.aXD = aXD2;
					return;
				}
				catch
				{
					return;
				}
			}
			if (list.Count <= 1)
			{
				return;
			}
			bool flag = false;
			do
			{
				if (Form54.smethod_7(form23_0, Class333.smethod_1997() + empty + Class333.smethod_1998() + empty + Class333.smethod_1999() + empty + Class333.smethod_2000(), Class333.smethod_1986(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, new string[2]
				{
					Class333.smethod_2001(),
					Class333.smethod_1988()
				}) != DialogResult.Yes)
				{
					try
					{
						string aXD3 = smethod_100(empty, new List<string> { framework_2.aXc });
						framework_2.aXD = aXD3;
						flag = true;
					}
					catch
					{
					}
					continue;
				}
				try
				{
					FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
					{
						Description = Class333.smethod_2002() + empty + Class333.smethod_2003(),
						SelectedPath = list[0],
						ShowNewFolderButton = false
					};
					if (folderBrowserDialog.ShowDialog(form23_0) == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
					{
						string name = new DirectoryInfo(folderBrowserDialog.SelectedPath).Name;
						if (!(name == empty) && !name.StartsWith(empty + Class333.smethod_100()))
						{
							Form54.smethod_6(form23_0, Class333.smethod_2004() + empty + Class333.smethod_2005(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
						else
						{
							smethod_101(folderBrowserDialog.SelectedPath, new List<string> { framework_2.aXc });
							framework_2.aXD = folderBrowserDialog.SelectedPath;
							flag = true;
						}
					}
					folderBrowserDialog.Dispose();
				}
				catch
				{
				}
			}
			while (!flag);
		}
		else
		{
			framework_2.aXD = text;
		}
	}

	private void method_222(object sender, EventArgs e)
	{
		if (Class1.smethod_27().Count == 1)
		{
			method_223(null, -1);
		}
	}

	internal void method_223(BackgroundWorker backgroundWorker_1, int int_49, bool bool_53 = false)
	{
		if (framework_1 == null || !framework_1.method_5())
		{
			return;
		}
		for (int i = 0; i < framework_1.aWt.Count; i++)
		{
			framework_1.aWt[i].method_268();
		}
		lock (object_1)
		{
			int_0 |= 64;
			int_0 |= 8;
			int_0 |= 16;
		}
		if (framework_1.awZ == 21)
		{
			Class1.smethod_66(framework_1.aXc, out var _);
		}
		if (backgroundWorker_1 == null)
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.DoWork += method_224;
			backgroundWorker.ProgressChanged += smethod_69;
			backgroundWorker.RunWorkerCompleted += method_225;
			if (framework_1.awv.Count != 0)
			{
				smethod_66(Class333.smethod_2012());
			}
			else
			{
				smethod_66(Class333.smethod_2013());
			}
			backgroundWorker.RunWorkerAsync(new object[2] { -1, bool_53 });
		}
		else
		{
			DoWorkEventArgs e = new DoWorkEventArgs(new object[2] { int_49, bool_53 });
			method_224(backgroundWorker_1, e);
			method_225(backgroundWorker_1, new RunWorkerCompletedEventArgs(e.Result, null, cancelled: false));
		}
	}

	private void method_224(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		int num = (int)((object[])e.Argument)[0];
		bool bqj = (bool)((object[])e.Argument)[1];
		Class218 @class = new Class218
		{
			Bqj = bqj,
			BqK = null
		};
		int uint_;
		try
		{
			uint_ = (int)list_2[0].BpS.struct1_0[35].uint_1;
		}
		catch
		{
			return;
		}
		uint uint_2 = smethod_23();
		int num2 = ((framework_1.awv.Count == 0) ? 100 : 40);
		lock (object_2)
		{
			framework_1.method_73();
			int num3 = 0;
			bool flag;
			do
			{
				int num4 = 0;
				flag = framework_1.method_81(ref num4);
				num3 = Math.Min(num3 + num4, uint_);
				int num5 = num3 * num2 / uint_;
				if (!flag || num4 != 0)
				{
					if (num == -1)
					{
						backgroundWorker.ReportProgress(num5);
					}
					else
					{
						backgroundWorker.ReportProgress(num5, num);
					}
				}
				if (smethod_28(framework_1.aXc, bool_53: false))
				{
					if (num5 != 100)
					{
						Thread.Sleep(0);
					}
					else
					{
						Thread.Sleep(200);
					}
					continue;
				}
				return;
			}
			while (flag || num3 < uint_);
		}
		if (framework_1.awv.Count != 0)
		{
			method_226(backgroundWorker, num2, num, uint_2, out var string_);
			if (!string.IsNullOrWhiteSpace(string_))
			{
				@class.BqK = string_;
			}
		}
		while (smethod_34(bool_53: true))
		{
			Thread.Sleep(100);
		}
		e.Result = @class;
	}

	private void method_225(object sender, RunWorkerCompletedEventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate113 method = method_225;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		try
		{
			smethod_68();
		}
		catch
		{
		}
		if (bool_12)
		{
			if (bool_14)
			{
				Environment.Exit(0);
			}
			bool_12 = false;
		}
		lock (object_1)
		{
			int_0 &= -65;
		}
		for (int i = 0; i < framework_1.aWt.Count; i++)
		{
			framework_1.aWt[i].method_267(bool_0: true);
		}
		if (enum59_0 != Enum59.Bpc && enum59_0 != Enum59.Bpe)
		{
			if (!(e.Result is Class218 @class))
			{
				return;
			}
			if (!bool_14 && !string.IsNullOrWhiteSpace(@class.BqK))
			{
				Form54.smethod_6(this, @class.BqK, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			if (!@class.Bqj)
			{
				return;
			}
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			if (framework_1.method_4())
			{
				if (Form48.smethod_0(framework_1))
				{
					flag4 = Form48.smethod_1(framework_1, out flag, out flag2, out flag3);
				}
				else
				{
					Class122.smethod_0(framework_1, out flag5);
				}
			}
			if (flag | flag5)
			{
				smethod_32(bool_53: true);
			}
			else if (!flag3)
			{
				smethod_10(bool_53: false);
				if (flag4 && form23_0.toolStripMenuItem_31.Enabled && !flag2)
				{
					form23_0.toolStripMenuItem_31.PerformClick();
				}
			}
		}
		else
		{
			method_44();
		}
	}

	private void method_226(BackgroundWorker backgroundWorker_1, int int_49, int int_50, uint uint_0, out string string_41)
	{
		string_41 = null;
		if (Directory.Exists(string_10))
		{
			string[] array = null;
			try
			{
				array = Directory.GetDirectories(string_10);
			}
			catch (Exception ex)
			{
				array = null;
				Class23.smethod_3(Class333.smethod_2014() + string_10 + Class333.smethod_2015() + ex.Message);
			}
			if (array != null)
			{
				int num = (80 - int_49) / array.Length;
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					string[] array2 = null;
					try
					{
						array2 = Directory.GetFiles(text);
					}
					catch (Exception ex2)
					{
						array2 = null;
						Class23.smethod_3(Class333.smethod_2016() + text + Class333.smethod_2015() + ex2.Message);
					}
					if (array2 != null)
					{
						int num2 = int_49 + i * num;
						if (int_50 != -1)
						{
							backgroundWorker_1.ReportProgress(num2, int_50);
						}
						else
						{
							backgroundWorker_1.ReportProgress(num2);
						}
						Class1.Enum5 @enum = Class247.smethod_8(new DirectoryInfo(text).Name);
						if (framework_1.aww.ContainsKey(@enum))
						{
							Class10[] array3 = smethod_22(@enum);
							int num3 = num2 + num / 10;
							if (int_50 != -1)
							{
								backgroundWorker_1.ReportProgress(num3, int_50);
							}
							else
							{
								backgroundWorker_1.ReportProgress(num3);
							}
							long totalResourceBytes = Math.Max(1L, array2.Sum(file => new FileInfo(file).Length));
							long completedResourceBytes = 0;
							for (int j = 0; j < array2.Length; j++)
							{
								string path = array2[j];
								byte[] array4 = File.ReadAllBytes(path);
								string fileName = Path.GetFileName(path);
								if (@enum != Class1.Enum5.BFH || !Class263.aZd.ContainsKey(fileName) || Class263.aZd[fileName] != array4.Length)
								{
									string text2 = Class333.smethod_1469() + fileName;
									uint num4 = new global::crc.crc().crc_process(array4, 0u, (uint)array4.Length, uint.MaxValue, partial: false);
									bool flag = false;
									if (array3 != null)
									{
										Class10[] array5 = array3;
										foreach (Class10 @class in array5)
										{
											if (@class.method_2() == text2)
											{
												if (num4 == @class.uint_1)
												{
													flag = true;
												}
												break;
											}
										}
									}
									if (!flag)
									{
										Class10 class2 = new Class10();
										class2.method_3(text2);
										class2.uint_0 = (uint)array4.Length;
										class2.enum5_0 = @enum;
										class2.uint_1 = num4;
										Class10 class10_ = class2;
										Class23.smethod_3(Class333.smethod_2017() + fileName + Class333.smethod_1394(), bool_1: false);
										int resourceStart = (int)(completedResourceBytes * (num * 9 / 10) / totalResourceBytes);
										int resourceEnd = (int)((completedResourceBytes + array4.LongLength) * (num * 9 / 10) / totalResourceBytes);
										method_227(class10_, array4, out var string_42, backgroundWorker_1,
											num3 + resourceStart, resourceEnd - resourceStart, int_50);
										if (string_42 != null)
										{
											string_41 = string_42;
											return;
										}
									}
								}
								if (!smethod_28(framework_1.aXc, bool_53: false))
								{
									break;
								}
								completedResourceBytes += array4.LongLength;
								int percentProgress = num3 + (int)(completedResourceBytes * (num * 9 / 10) / totalResourceBytes);
								if (int_50 != -1)
								{
									backgroundWorker_1.ReportProgress(percentProgress, int_50);
								}
								else
								{
									backgroundWorker_1.ReportProgress(percentProgress);
								}
							}
						}
					}
					if (!smethod_28(framework_1.aXc, bool_53: false))
					{
						break;
					}
				}
			}
		}
		if (framework_1.awW != null)
		{
			smethod_24(backgroundWorker_1, 80, 20, framework_1.awW.method_260(), int_50, uint_0, out var string_43);
			if (string_43 != null)
			{
				if (string_41 == null)
				{
					string_41 = string_43;
				}
				else
				{
					string_41 = string_41 + Class333.smethod_1812() + string_43;
				}
			}
		}
		if (int_50 != -1)
		{
			backgroundWorker_1.ReportProgress(100, int_50);
		}
		else
		{
			backgroundWorker_1.ReportProgress(100);
		}
		Thread.Sleep(500);
	}

	private void method_227(Class10 class10_0, byte[] byte_1, out string string_41,
		BackgroundWorker worker = null, int progressStart = 0, int progressSpan = 100, int progressPage = -1)
	{
		string_41 = null;
		try
		{
			SendResource(class10_0, byte_1, worker, progressStart, progressSpan, progressPage);
		}
		catch (Exception error) when (error is IOException || error is OperationCanceledException)
		{
			string_41 = error.Message;
			Class23.smethod_3(error.Message);
		}
	}

	private void method_228(string string_41, Class240 class240_1)
	{
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.DoWork += method_229;
		backgroundWorker.ProgressChanged += smethod_69;
		backgroundWorker.RunWorkerCompleted += method_230;
		smethod_66(Class333.smethod_2020());
		backgroundWorker.RunWorkerAsync(new object[2] { string_41, class240_1 });
	}

	private void method_229(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		string text = (e.Argument as object[])[0] as string;
		Class240 @class = (e.Argument as object[])[1] as Class240;
		Class240 class2 = Class296.smethod_0(text);
		backgroundWorker.ReportProgress(10);
		string text2 = string.Empty;
		if (class2 != null && @class != null)
		{
			string value = Class234.smethod_8(class2.axS, class2.axs, class2.axT, class2.axt, bool_0: true);
			if (!string.IsNullOrEmpty(value))
			{
				if (class2 == @class)
				{
					backgroundWorker.ReportProgress(20);
					framework_1 = new Framework(value, class2.axS, class2.axs, class2.axT);
					if (framework_1.method_1() == Class237.Enum91.Brc)
					{
						backgroundWorker.ReportProgress(60);
						if (new Class296(text, framework_1).method_0(out text2) && string.IsNullOrEmpty(text2))
						{
							backgroundWorker.ReportProgress(70);
							framework_1.method_58();
							framework_1.method_37(framework_1.awj);
							framework_1.method_42(null);
							framework_1.method_40(null, framework_0, hashSet_0);
							framework_1.method_38(null);
							backgroundWorker.ReportProgress(90);
						}
					}
					else
					{
						text2 = Class333.smethod_2021();
					}
				}
				else
				{
					string value2 = Class234.smethod_8(@class.axS, @class.axs, @class.axT, @class.axt, bool_0: true);
					if (!string.IsNullOrEmpty(value2))
					{
						framework_1 = new Framework(value2, @class.axS, @class.axs, @class.axT);
						if (framework_1.method_1() == Class237.Enum91.Brc)
						{
							backgroundWorker.ReportProgress(30);
							Framework framework = new Framework(value, class2.axS, class2.axs, class2.axT);
							if (framework.method_1() == Class237.Enum91.Brc)
							{
								backgroundWorker.ReportProgress(50);
								if (new Class296(text, framework).method_0(out text2) && string.IsNullOrEmpty(text2))
								{
									backgroundWorker.ReportProgress(60);
									framework_1.method_48(framework_1.aWS);
									framework_1.method_69(framework, framework_1.aWS, bool_0: true, bool_1: false);
									framework_1.method_70(framework, bool_0: false);
									framework_1.method_49(framework_1.aWS);
									backgroundWorker.ReportProgress(80);
									framework_1.method_58();
									framework_1.method_37(framework_1.awj);
									framework_1.method_42(null);
									framework_1.method_40(null, framework_0, hashSet_0);
									framework_1.method_38(null);
								}
							}
							else
							{
								text2 = Class333.smethod_2021();
							}
						}
						else
						{
							text2 = Class333.smethod_2022();
						}
					}
					else
					{
						string[] array = new string[6]
						{
							Class333.smethod_2023(),
							null,
							null,
							null,
							null,
							null
						};
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
						defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_2024());
						defaultInterpolatedStringHandler.AppendFormatted(@class.axS);
						defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_570());
						array[1] = defaultInterpolatedStringHandler.ToStringAndClear();
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
						defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_2025());
						defaultInterpolatedStringHandler.AppendFormatted(@class.axs);
						defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_570());
						array[2] = defaultInterpolatedStringHandler.ToStringAndClear();
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
						defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_2026());
						defaultInterpolatedStringHandler.AppendFormatted(@class.axT);
						defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_570());
						array[3] = defaultInterpolatedStringHandler.ToStringAndClear();
						array[4] = Class333.smethod_2027();
						array[5] = BitConverter.ToString(@class.axt);
						text2 = string.Concat(array);
					}
				}
			}
			else
			{
				text2 = Class333.smethod_2028();
			}
		}
		else
		{
			text2 = Class333.smethod_2029();
		}
		backgroundWorker.ReportProgress(100);
		Thread.Sleep(500);
		e.Result = text2;
	}

	private void method_230(object sender, RunWorkerCompletedEventArgs e)
	{
		smethod_68();
		string value = (string)e.Result;
		if (string.IsNullOrEmpty(value))
		{
			if (!bool_14 && smethod_10(bool_53: true))
			{
				toolStripMenuItem_39.Enabled = true;
				toolStripButton_11.Enabled = true;
				toolStripMenuItem_38.Enabled = true;
				toolStripMenuItem_8.Enabled = true;
				toolStripMenuItem_41.Enabled = true;
				toolStripMenuItem_42.Enabled = true;
				class163_0.Enabled = true;
				toolStripButton_1.Enabled = true;
				toolStripMenuItem_6.Enabled = true;
				toolStripButton_4.Enabled = true;
				toolStripMenuItem_10.Enabled = true;
				toolStripButton_7.Enabled = true;
				toolStripMenuItem_58.Enabled = true;
				toolStripMenuItem_59.Enabled = true;
				toolStripDropDownButton_0.Enabled = true;
				toolStripMenuItem_31.Enabled = framework_1 != null && framework_1.awm != null;
				string_19 = string.Empty;
				smethod_6();
			}
			if (string_28 != null || bool_11)
			{
				string_28 = null;
				bool_11 = false;
				class240_0 = null;
				bool_12 = true;
				smethod_29(bool_53: true);
			}
		}
		else
		{
			string_28 = null;
			bool_11 = false;
			class240_0 = null;
			bool_12 = false;
			if (bool_14)
			{
				Console.WriteLine();
				Console.WriteLine(value);
				Environment.Exit(1);
			}
			else
			{
				Form54.smethod_6(this, value, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}

	private void method_231(Class240 class240_1)
	{
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.DoWork += method_232;
		backgroundWorker.ProgressChanged += smethod_69;
		backgroundWorker.RunWorkerCompleted += method_230;
		smethod_66(Class333.smethod_2030());
		backgroundWorker.RunWorkerAsync(class240_1);
	}

	private void method_232(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		Class240 @class = e.Argument as Class240;
		string result = string.Empty;
		if (@class != null)
		{
			string value = Class234.smethod_8(@class.axS, @class.axs, @class.axT, @class.axt, bool_0: true);
			backgroundWorker.ReportProgress(10);
			if (!string.IsNullOrEmpty(value))
			{
				framework_1 = new Framework(value, @class.axS, @class.axs, @class.axT);
				if (framework_1.method_1() == Class237.Enum91.Brc)
				{
					backgroundWorker.ReportProgress(50);
					framework_1.method_15(framework_1.aWS);
					backgroundWorker.ReportProgress(70);
					framework_1.method_58();
					framework_1.method_37(framework_1.awj);
					framework_1.method_42(null);
					framework_1.method_40(null, framework_0, hashSet_0);
					framework_1.method_38(null);
					backgroundWorker.ReportProgress(80);
				}
				else
				{
					result = Class333.smethod_2031();
				}
			}
			else
			{
				string[] array = new string[6]
				{
					Class333.smethod_2032(),
					null,
					null,
					null,
					null,
					null
				};
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_2024());
				defaultInterpolatedStringHandler.AppendFormatted(@class.axS);
				defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_570());
				array[1] = defaultInterpolatedStringHandler.ToStringAndClear();
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_2025());
				defaultInterpolatedStringHandler.AppendFormatted(@class.axs);
				defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_570());
				array[2] = defaultInterpolatedStringHandler.ToStringAndClear();
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_2026());
				defaultInterpolatedStringHandler.AppendFormatted(@class.axT);
				defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_570());
				array[3] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[4] = Class333.smethod_2027();
				array[5] = BitConverter.ToString(@class.axt);
				result = string.Concat(array);
			}
		}
		else
		{
			result = Class333.smethod_2029();
		}
		backgroundWorker.ReportProgress(100);
		Thread.Sleep(500);
		e.Result = result;
	}

	[CompilerGenerated]
	private void method_233()
	{
		Form54.smethod_6(this, Class333.smethod_2047(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}
}
