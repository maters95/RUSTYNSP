using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using ns1;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace NSP.UserInterface;

public class GenericCANConfigControl : UserControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class67
	{
		public static readonly Class67 BkO = new Class67();

		public static Func<CANFrameModel, bool> Bko;

		public static Func<Setting.ListItems.Struct45, string> BkP;

		public static Func<Setting.ListItems.Struct45, string> Bkp;

		public static Func<Setting.ListItems.Struct45, string> BkQ;

		public static Func<Setting.ListItems.Struct45, ValueAndDisplay> Bkq;

		public static Func<Setting.ListItems.Struct45, ValueAndDisplay> BkR;

		public static Func<CANFrameModel, bool> Bkr;

		public static Func<CANFrameModel, bool> BkS;

		internal bool method_0(CANFrameModel canframeModel_0)
		{
			return canframeModel_0.Index == int_3;
		}

		internal string method_1(Setting.ListItems.Struct45 struct45_0)
		{
			return struct45_0.bBV;
		}

		internal string method_2(Setting.ListItems.Struct45 struct45_0)
		{
			return struct45_0.bBV;
		}

		internal string method_3(Setting.ListItems.Struct45 struct45_0)
		{
			return struct45_0.bBV;
		}

		internal ValueAndDisplay method_4(Setting.ListItems.Struct45 struct45_0)
		{
			return new ValueAndDisplay
			{
				Value = struct45_0.bBv,
				Display = struct45_0.bBV
			};
		}

		internal ValueAndDisplay method_5(Setting.ListItems.Struct45 struct45_0)
		{
			return new ValueAndDisplay
			{
				Value = struct45_0.bBv,
				Display = struct45_0.bBV
			};
		}

		internal bool method_6(CANFrameModel canframeModel_0)
		{
			return canframeModel_0.FrameDirection == CANFrameModel.Direction.Receive;
		}

		internal bool method_7(CANFrameModel canframeModel_0)
		{
			return canframeModel_0.FrameDirection == CANFrameModel.Direction.Transmit;
		}
	}

	[CompilerGenerated]
	private sealed class Class68
	{
		public CANFrameModel Bks;

		internal bool method_0(CANFrameModel canframeModel_0)
		{
			if (canframeModel_0 != Bks)
			{
				return canframeModel_0.Name == Bks.Name;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class Class69
	{
		public uint BkT;

		internal bool method_0(CANFrameModel canframeModel_0)
		{
			return canframeModel_0.Index == BkT;
		}
	}

	[CompilerGenerated]
	private sealed class Class70
	{
		public uint Bkt;

		internal bool method_0(CANFrameModel canframeModel_0)
		{
			return canframeModel_0.Index == Bkt;
		}
	}

	[CompilerGenerated]
	private sealed class Class71
	{
		public uint BkU;

		internal bool method_0(CANFrameModel canframeModel_0)
		{
			return canframeModel_0.Index == BkU;
		}
	}

	[CompilerGenerated]
	private sealed class Class72
	{
		public int Bku;

		internal bool method_0(CANFrameModel canframeModel_0)
		{
			return canframeModel_0.Index == Bku;
		}

		internal bool method_1(CANFrameModel canframeModel_0)
		{
			return canframeModel_0.Index == Bku;
		}
	}

	[CompilerGenerated]
	private sealed class Class73
	{
		public int BkV;

		internal bool method_0(CANFrameModel canframeModel_0)
		{
			return canframeModel_0.Index == BkV;
		}
	}

	[CompilerGenerated]
	private sealed class Class74
	{
		public List<CANSignalModel> Bkv;

		internal bool method_0(CANSignalModel cansignalModel_0)
		{
			return !Bkv.Any((CANSignalModel cANSignalModel) => cANSignalModel.Index == cansignalModel_0.Index);
		}
	}

	[CompilerGenerated]
	private sealed class Class75
	{
		public CANSignalModel BkW;

		internal bool method_0(CANSignalModel cansignalModel_0)
		{
			return cansignalModel_0.Index == BkW.Index;
		}
	}

	private const int int_0 = 12;

	private const int int_1 = 10;

	private const int int_2 = 20;

	private const string string_0 = "            ";

	private List<CANFrameModel> list_0 = new List<CANFrameModel>();

	private CANFrameModel canframeModel_0;

	private static int int_3 = -1;

	private static int int_4 = 0;

	private static int int_5 = 0;

	private Timer timer_0;

	private int int_6;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private Framework framework_0;

	private Class255 class255_0;

	private bool bool_3 = true;

	private bool bool_4;

	private int int_7;

	private int int_8;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private int int_13;

	private int int_14;

	private int int_15;

	private int int_16;

	private int int_17;

	private int int_18;

	private int int_19;

	private bool bool_5;

	private IContainer icontainer_0;

	private Class138 class138_0;

	private Class138 class138_1;

	private TableLayoutPanel tableLayoutPanel_0;

	private Label label_0;

	private ThemedButton themedButton_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private Label label_1;

	private ThemedButton themedButton_1;

	private TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_0;

	private TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_1;

	private Class148 class148_0;

	private Label label_2;

	private ThemedTextBox themedTextBox_0;

	private PictureBox pictureBox_0;

	private Label label_3;

	private ThemedComboBox themedComboBox_0;

	private Label label_4;

	private ThemedTextBox themedTextBox_1;

	private PictureBox pictureBox_1;

	private Label label_5;

	private ThemedComboBox themedComboBox_1;

	private Label label_6;

	private ThemedComboBox themedComboBox_2;

	private CANRawDataView canrawDataView_0;

	private CANSignalEditor cansignalEditor_0;

	private Label label_7;

	private ThemedBitfieldViewer themedBitfieldViewer_0;

	private Label label_8;

	internal GenericCANConfigControl(Framework framework_1, Class255 class255_1, string string_1 = null)
	{
		if (framework_1 == null)
		{
			return;
		}
		framework_0 = framework_1;
		class255_0 = class255_1;
		int_6 = Class255.smethod_4(string_1);
		method_83();
		MinimumSize = new Size(0, cansignalEditor_0.Top + 120 + 150);
		themedTextBox_0.MaxLength = class255_0.BZk.method_242()[1];
		method_7();
		method_2(bool_6: false, null, bool_7: true);
		method_29();
		timer_0 = new Timer
		{
			Interval = 100
		};
		if (int_3 != -1)
		{
			CANFrameModel canframeModel_ = list_0.FirstOrDefault((CANFrameModel cANFrameModel) => cANFrameModel.Index == int_3);
			method_16(canframeModel_);
		}
		method_8();
	}

	protected override void OnLoad(EventArgs eventArgs_0)
	{
		base.OnLoad(eventArgs_0);
		BeginInvoke(() =>
		{
			if (int_4 != 0)
			{
				class138_0.SplitterDistance = int_4;
			}
			if (int_5 != 0)
			{
				class138_1.SplitterDistance = int_5;
			}
			bool_3 = false;
			treeViewWithThemedScrollBars_0.AutoScroll = true;
			treeViewWithThemedScrollBars_1.AutoScroll = true;
			treeViewWithThemedScrollBars_0.method_37();
			treeViewWithThemedScrollBars_1.method_37();
		});
	}

	private void method_0(CANFrameModel canframeModel_1)
	{
		if (canframeModel_1 == null)
		{
			method_1();
			return;
		}
		method_2(bool_6: true, canframeModel_1);
		class148_0.CheckState = (canframeModel_1.Enabled ? CheckState.Checked : CheckState.Unchecked);
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.Text = canframeModel_1.Name;
		themedComboBox_0.SelectedIndex = ((!canframeModel_1.StdFrame) ? 1 : 0);
		string text = (canframeModel_1.StdFrame ? Class333.smethod_380() : Class333.smethod_379());
		themedTextBox_1.Text = Class333.smethod_381() + canframeModel_1.CANId.ToString(text);
		themedComboBox_1.SelectedIndex = (int)canframeModel_1.Length;
		themedComboBox_2.SelectedIndex = canframeModel_1.Rate;
		themedComboBox_0.method_0();
		themedComboBox_1.method_0();
		themedComboBox_2.method_0();
		class148_0.ForeColor = (class148_0.Enabled ? Form23.color_12 : Form23.color_36);
		label_2.ForeColor = (themedTextBox_0.Enabled ? Form23.color_12 : Form23.color_36);
		label_3.ForeColor = (themedComboBox_0.Enabled ? Form23.color_12 : Form23.color_36);
		label_4.ForeColor = (themedTextBox_1.Enabled ? Form23.color_12 : Form23.color_36);
		label_5.ForeColor = (themedComboBox_1.Enabled ? Form23.color_12 : Form23.color_36);
		label_6.ForeColor = (themedComboBox_2.Enabled ? Form23.color_12 : Form23.color_36);
	}

	private void method_1()
	{
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.Text = string.Empty;
		themedTextBox_1.Text = string.Empty;
		method_2(bool_6: false, null);
	}

	private void method_2(bool bool_6, CANFrameModel canframeModel_1, bool bool_7 = false)
	{
		class148_0.Enabled = bool_6;
		themedTextBox_0.Enabled = bool_6;
		themedComboBox_0.Enabled = bool_6;
		themedTextBox_1.Enabled = bool_6;
		themedComboBox_1.Enabled = bool_6;
		themedComboBox_2.Enabled = bool_6 && canframeModel_1.FrameDirection == CANFrameModel.Direction.Transmit;
		method_3(bool_6, canframeModel_1);
		method_4(class148_0, class148_0, class148_0.Enabled, bool_7);
		method_4(themedTextBox_0, label_2, themedTextBox_0.Enabled, bool_7);
		method_5(themedComboBox_0, label_3, themedComboBox_0.Enabled);
		method_4(themedTextBox_1, label_4, themedTextBox_1.Enabled, bool_7);
		method_5(themedComboBox_1, label_5, themedComboBox_1.Enabled);
		method_5(themedComboBox_2, label_6, themedComboBox_2.Enabled);
	}

	private void method_3(bool bool_6, CANFrameModel canframeModel_1)
	{
		if (canframeModel_1 != null)
		{
			bool enable = bool_6 && canframeModel_1.Enabled && (canframeModel_1.FrameDirection == CANFrameModel.Direction.Receive || (canframeModel_1.Signals != null && canframeModel_1.Signals.Count > 0));
			canrawDataView_0.EnableOrDisable(enable, canframeModel_1.Length);
		}
		else
		{
			canrawDataView_0.EnableOrDisable(enable: false);
		}
	}

	private void method_4(Control control_0, Control control_1, bool bool_6, bool bool_7 = false)
	{
		if (bool_7)
		{
			control_0.BackColor = Form23.color_32;
			control_0.ForeColor = Form23.color_12;
		}
		control_0.Enabled = bool_6;
		control_1.ForeColor = (bool_6 ? Form23.color_12 : Form23.color_36);
	}

	private void method_5(ComboBox comboBox_0, Control control_0, bool bool_6)
	{
		comboBox_0.ForeColor = Form23.color_12;
		comboBox_0.BackColor = Form23.color_32;
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.Enabled = bool_6;
		control_0.ForeColor = (bool_6 ? Form23.color_12 : Form23.color_36);
	}

	private void method_6(TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_2)
	{
		treeViewWithThemedScrollBars_2.ForeColor = Form23.color_12;
		treeViewWithThemedScrollBars_2.BackColor = Form23.color_16;
	}

	private void method_7()
	{
		pictureBox_0.Image = GeneralResources.RedError;
		pictureBox_0.Visible = false;
		pictureBox_1.Image = GeneralResources.RedError;
		pictureBox_1.Visible = false;
		BackColor = Form23.color_16;
		label_7.ForeColor = Form23.color_12;
		label_8.ForeColor = Form23.color_12;
		label_0.ForeColor = Form23.color_14;
		label_0.Font = new Font(label_0.Font.FontFamily, label_0.Font.Size, FontStyle.Bold);
		label_1.ForeColor = Form23.color_14;
		label_1.Font = label_0.Font;
		method_6(treeViewWithThemedScrollBars_0);
		method_6(treeViewWithThemedScrollBars_1);
		method_4(themedTextBox_0, label_2, bool_6: false);
		method_4(themedTextBox_1, label_4, bool_6: false);
		method_5(themedComboBox_0, label_3, bool_6: false);
		method_5(themedComboBox_1, label_5, bool_6: false);
		method_5(themedComboBox_2, label_6, bool_6: false);
		class148_0.ForeColor = Form23.color_36;
		class148_0.Enabled = false;
	}

	private void method_8()
	{
		method_10();
		method_11();
	}

	private void method_9()
	{
		method_12();
		method_13();
	}

	private void method_10()
	{
		class138_0.SplitterMoved += class138_0_SplitterMoved;
		class138_1.SplitterMoved += class138_1_SplitterMoved;
		treeViewWithThemedScrollBars_0.method_23(method_51);
		treeViewWithThemedScrollBars_0.KeyDown += treeViewWithThemedScrollBars_0_KeyDown;
		treeViewWithThemedScrollBars_0.method_43(method_22);
		treeViewWithThemedScrollBars_0.SizeChanged += treeViewWithThemedScrollBars_0_SizeChanged;
		treeViewWithThemedScrollBars_1.method_23(method_52);
		treeViewWithThemedScrollBars_1.KeyDown += treeViewWithThemedScrollBars_1_KeyDown;
		treeViewWithThemedScrollBars_1.method_43(method_23);
		treeViewWithThemedScrollBars_1.SizeChanged += treeViewWithThemedScrollBars_1_SizeChanged;
		themedTextBox_0.LostFocus += themedTextBox_0_LostFocus;
		themedTextBox_0.KeyDown += themedTextBox_0_KeyDown;
		themedTextBox_1.LostFocus += themedTextBox_1_LostFocus;
		themedTextBox_1.KeyDown += themedTextBox_1_KeyDown;
		themedComboBox_0.SelectionChangeCommitted += themedComboBox_0_SelectionChangeCommitted;
		themedComboBox_1.SelectionChangeCommitted += themedComboBox_1_SelectionChangeCommitted;
		themedComboBox_2.SelectionChangeCommitted += themedComboBox_2_SelectionChangeCommitted;
		class148_0.CheckStateChanged += class148_0_CheckStateChanged;
		cansignalEditor_0.SignalsChanged += method_43;
		cansignalEditor_0.SignalSelectionChanged += cansignalEditor_0_SignalSelectionChanged;
		themedBitfieldViewer_0.SelectedSignalBitsChanged += themedBitfieldViewer_0_SelectedSignalBitsChanged;
		themedBitfieldViewer_0.SignalSelectionChanged += themedBitfieldViewer_0_SignalSelectionChanged;
		pictureBox_0.Click += pictureBox_0_Click;
		pictureBox_1.Click += pictureBox_1_Click;
		timer_0.Tick += timer_0_Tick;
		class138_0.Panel2.MouseDown += label_7_MouseDown;
		themedBitfieldViewer_0.MouseDown += label_7_MouseDown;
		treeViewWithThemedScrollBars_0.MouseDown += label_7_MouseDown;
		treeViewWithThemedScrollBars_1.MouseDown += label_7_MouseDown;
		cansignalEditor_0.MouseDown += label_7_MouseDown;
		label_7.MouseDown += label_7_MouseDown;
		class138_0.Panel2.MouseMove += label_7_MouseMove;
		themedBitfieldViewer_0.MouseMove += label_7_MouseMove;
		treeViewWithThemedScrollBars_0.MouseMove += label_7_MouseMove;
		treeViewWithThemedScrollBars_1.MouseMove += label_7_MouseMove;
		cansignalEditor_0.MouseMove += label_7_MouseMove;
		label_7.MouseMove += label_7_MouseMove;
		class138_0.Panel2.MouseUp += treeViewWithThemedScrollBars_1_MouseUp;
		treeViewWithThemedScrollBars_0.MouseUp += treeViewWithThemedScrollBars_1_MouseUp;
		treeViewWithThemedScrollBars_1.MouseUp += treeViewWithThemedScrollBars_1_MouseUp;
	}

	private void method_11()
	{
		class255_0.BZk.method_40(method_77);
		class255_0.BZL.method_40(method_79);
		class255_0.BZL.method_264(method_78);
		class255_0.BZk.method_264(method_76);
		class255_0.BZl.method_264(method_75);
		class255_0.BZM.method_264(method_80);
		class255_0.BZm.method_264(method_82);
		class255_0.BZN.method_264(method_82);
		class255_0.BZn.method_264(method_82);
		class255_0.BZO.method_264(method_82);
		class255_0.BZo.method_264(method_82);
		class255_0.BZP.method_264(method_82);
		class255_0.BZp.method_264(method_82);
		class255_0.BZQ.method_264(method_82);
		class255_0.BZq.method_264(method_82);
		class255_0.BZR.method_264(method_82);
		class255_0.BZr.method_264(method_82);
		class255_0.BZr.method_40(method_81);
	}

	private void method_12()
	{
		class138_0.SplitterMoved -= class138_0_SplitterMoved;
		class138_1.SplitterMoved -= class138_1_SplitterMoved;
		treeViewWithThemedScrollBars_0.method_24(method_51);
		treeViewWithThemedScrollBars_0.KeyDown -= treeViewWithThemedScrollBars_0_KeyDown;
		treeViewWithThemedScrollBars_0.method_44(method_22);
		treeViewWithThemedScrollBars_0.SizeChanged -= treeViewWithThemedScrollBars_0_SizeChanged;
		treeViewWithThemedScrollBars_1.method_24(method_52);
		treeViewWithThemedScrollBars_1.KeyDown -= treeViewWithThemedScrollBars_1_KeyDown;
		treeViewWithThemedScrollBars_1.method_44(method_23);
		treeViewWithThemedScrollBars_1.SizeChanged -= treeViewWithThemedScrollBars_1_SizeChanged;
		themedTextBox_0.LostFocus -= themedTextBox_0_LostFocus;
		themedTextBox_0.KeyDown -= themedTextBox_0_KeyDown;
		themedTextBox_1.LostFocus -= themedTextBox_1_LostFocus;
		themedTextBox_1.KeyDown -= themedTextBox_1_KeyDown;
		themedComboBox_0.SelectionChangeCommitted -= themedComboBox_0_SelectionChangeCommitted;
		themedComboBox_1.SelectionChangeCommitted -= themedComboBox_1_SelectionChangeCommitted;
		themedComboBox_2.SelectionChangeCommitted -= themedComboBox_2_SelectionChangeCommitted;
		class148_0.CheckStateChanged -= class148_0_CheckStateChanged;
		cansignalEditor_0.SignalsChanged -= method_43;
		cansignalEditor_0.SignalSelectionChanged -= cansignalEditor_0_SignalSelectionChanged;
		themedBitfieldViewer_0.SelectedSignalBitsChanged -= themedBitfieldViewer_0_SelectedSignalBitsChanged;
		themedBitfieldViewer_0.SignalSelectionChanged -= themedBitfieldViewer_0_SignalSelectionChanged;
		pictureBox_0.Click -= pictureBox_0_Click;
		pictureBox_1.Click -= pictureBox_1_Click;
		timer_0.Stop();
		timer_0.Tick -= timer_0_Tick;
		class138_0.Panel2.MouseDown -= label_7_MouseDown;
		themedBitfieldViewer_0.MouseDown -= label_7_MouseDown;
		treeViewWithThemedScrollBars_0.MouseDown -= label_7_MouseDown;
		treeViewWithThemedScrollBars_1.MouseDown -= label_7_MouseDown;
		cansignalEditor_0.MouseDown -= label_7_MouseDown;
		label_7.MouseDown -= label_7_MouseDown;
		class138_0.Panel2.MouseMove -= label_7_MouseMove;
		themedBitfieldViewer_0.MouseMove -= label_7_MouseMove;
		treeViewWithThemedScrollBars_0.MouseMove -= label_7_MouseMove;
		treeViewWithThemedScrollBars_1.MouseMove -= label_7_MouseMove;
		cansignalEditor_0.MouseMove -= label_7_MouseMove;
		label_7.MouseMove -= label_7_MouseMove;
		class138_0.Panel2.MouseUp -= treeViewWithThemedScrollBars_1_MouseUp;
		treeViewWithThemedScrollBars_0.MouseUp -= treeViewWithThemedScrollBars_1_MouseUp;
		treeViewWithThemedScrollBars_1.MouseUp -= treeViewWithThemedScrollBars_1_MouseUp;
	}

	private void method_13()
	{
		class255_0.BZk.method_41(method_77);
		class255_0.BZL.method_41(method_79);
		class255_0.BZL.method_265(method_78);
		class255_0.BZk.method_265(method_76);
		class255_0.BZl.method_265(method_75);
		class255_0.BZM.method_265(method_80);
		class255_0.BZm.method_265(method_82);
		class255_0.BZN.method_265(method_82);
		class255_0.BZn.method_265(method_82);
		class255_0.BZO.method_265(method_82);
		class255_0.BZo.method_265(method_82);
		class255_0.BZP.method_265(method_82);
		class255_0.BZp.method_265(method_82);
		class255_0.BZQ.method_265(method_82);
		class255_0.BZq.method_265(method_82);
		class255_0.BZR.method_265(method_82);
		class255_0.BZr.method_265(method_82);
		class255_0.BZr.method_41(method_81);
	}

	private void method_14()
	{
		int width = class138_0.Panel2.Width;
		int height = class138_0.Panel2.Height;
		if (!bool_4)
		{
			int_8 = label_3.Left;
			int_9 = themedComboBox_0.Left;
			int_10 = label_4.Left;
			int_11 = themedTextBox_1.Left;
			int_12 = pictureBox_1.Left;
			int_13 = label_5.Left;
			int_14 = themedComboBox_1.Left;
			int_15 = label_6.Left;
			int_16 = themedComboBox_2.Left;
			int_7 = themedComboBox_2.Right;
			int_17 = label_8.Top;
			int_18 = canrawDataView_0.Top;
			int_19 = cansignalEditor_0.Top;
			bool_4 = true;
		}
		if (width >= int_7)
		{
			label_3.Location = new Point(int_8, label_2.Top);
			themedComboBox_0.Location = new Point(int_9, themedTextBox_0.Top);
			label_4.Location = new Point(int_10, label_2.Top);
			themedTextBox_1.Location = new Point(int_11, themedTextBox_0.Top);
			pictureBox_1.Location = new Point(int_12, pictureBox_0.Top);
			label_5.Location = new Point(int_13, label_2.Top);
			themedComboBox_1.Location = new Point(int_14, themedTextBox_0.Top);
			label_6.Location = new Point(int_15, label_2.Top);
			themedComboBox_2.Location = new Point(int_16, themedTextBox_0.Top);
			label_8.Top = int_17;
			canrawDataView_0.Top = int_18;
			cansignalEditor_0.Top = int_19;
		}
		else
		{
			int num = 4 + label_2.Top - themedTextBox_0.Top;
			int num2 = 4 + pictureBox_0.Top - themedTextBox_0.Top;
			int num3 = int_8 - class148_0.Left;
			label_3.Location = new Point(class148_0.Left, themedTextBox_0.Bottom + num);
			themedComboBox_0.Location = new Point(int_9 - num3, themedTextBox_0.Bottom + 4);
			label_4.Location = new Point(int_10 - num3, themedTextBox_0.Bottom + num);
			themedTextBox_1.Location = new Point(int_11 - num3, themedTextBox_0.Bottom + 4);
			pictureBox_1.Location = new Point(int_12 - num3, themedTextBox_0.Bottom + num2);
			label_5.Location = new Point(int_13 - num3, themedTextBox_0.Bottom + num);
			themedComboBox_1.Location = new Point(int_14 - num3, themedTextBox_0.Bottom + 4);
			label_6.Location = new Point(int_15 - num3, themedTextBox_0.Bottom + num);
			themedComboBox_2.Location = new Point(int_16 - num3, themedTextBox_0.Bottom + 4);
			label_8.Top = themedComboBox_0.Bottom;
			canrawDataView_0.Top = label_8.Top + int_18 - int_17;
			cansignalEditor_0.Top = canrawDataView_0.Top + int_19 - int_18;
		}
		int num4 = cansignalEditor_0.method_1();
		if (num4 < height - 225 - cansignalEditor_0.Top)
		{
			ThemedBitfieldViewer themedBitfieldViewer = themedBitfieldViewer_0;
			int width2 = (label_7.Width = width - 1);
			themedBitfieldViewer.Size = new Size(width2, 225);
			cansignalEditor_0.Size = new Size(Math.Min(cansignalEditor_0.method_0(), width - 1), num4);
			themedBitfieldViewer_0.Top = cansignalEditor_0.Top + cansignalEditor_0.Height;
		}
		else
		{
			int height2 = ((cansignalEditor_0.Top + 120 + 225 >= height) ? Math.Max(height - (cansignalEditor_0.Top + 120), 150) : 225);
			ThemedBitfieldViewer themedBitfieldViewer2 = themedBitfieldViewer_0;
			int width2 = (label_7.Width = width - 1);
			themedBitfieldViewer2.Size = new Size(width2, height2);
			themedBitfieldViewer_0.Top = height - themedBitfieldViewer_0.Height;
			cansignalEditor_0.Size = new Size(Math.Min(cansignalEditor_0.method_0(), width - 1), Math.Max(themedBitfieldViewer_0.Top - cansignalEditor_0.Top, 120));
		}
		label_7.Top = (canrawDataView_0.Top + canrawDataView_0.Height + themedBitfieldViewer_0.Top) / 2 - label_7.Height / 2;
		themedBitfieldViewer_0.Invalidate();
	}

	private void class138_0_SplitterMoved(object sender, SplitterEventArgs e)
	{
		method_14();
		Invalidate();
		if (!bool_3)
		{
			int_4 = class138_0.SplitterDistance;
		}
	}

	private void class138_1_SplitterMoved(object sender, SplitterEventArgs e)
	{
		method_14();
		Invalidate();
		if (!bool_3)
		{
			int_5 = class138_1.SplitterDistance;
		}
	}

	private (int x, int y) method_15(Control control_0, Class106 class106_0, int int_20, int int_21)
	{
		int num = int_20 + control_0.Left;
		int num2 = int_21 + control_0.Top;
		Control control = control_0;
		bool flag = false;
		do
		{
			if (control.Parent == null || control.Parent == class106_0)
			{
				flag = true;
				continue;
			}
			control = control.Parent;
			num += control.Left;
			num2 += control.Top;
		}
		while (!flag);
		return (x: num, y: num2);
	}

	private void label_7_MouseDown(object sender, MouseEventArgs e)
	{
		if (Parent == null || !(Parent.Parent is Class106))
		{
			return;
		}
		Class106 @class = Parent.Parent as Class106;
		@class.BringToFront();
		if (e.Button != MouseButtons.Left || (sender != class138_0.Panel2 && sender != treeViewWithThemedScrollBars_0 && sender != treeViewWithThemedScrollBars_1))
		{
			return;
		}
		if (sender == treeViewWithThemedScrollBars_0 || sender == treeViewWithThemedScrollBars_1)
		{
			TreeViewWithThemedScrollBars treeViewWithThemedScrollBars = sender as TreeViewWithThemedScrollBars;
			TreeNode treeNode = treeViewWithThemedScrollBars.method_41(e.X, e.Y, out var _);
			if (treeNode != null)
			{
				if (e.X > treeViewWithThemedScrollBars.Width - 20 - 12 && e.X < treeViewWithThemedScrollBars.Width - 20)
				{
					CANFrameModel cANFrameModel = method_64(treeNode);
					if (cANFrameModel != null)
					{
						method_16(cANFrameModel);
						method_28(treeViewWithThemedScrollBars);
					}
				}
				return;
			}
		}
		themedBitfieldViewer_0.ClearSignalSelection();
		var (num, num2) = method_15(sender as Control, @class, e.X, e.Y);
		@class.method_3(e.Button, num, num2);
	}

	private void label_7_MouseMove(object sender, MouseEventArgs e)
	{
		if (sender != themedBitfieldViewer_0)
		{
			themedBitfieldViewer_0.method_7();
		}
		if (Parent != null && Parent.Parent is Class106)
		{
			Class106 @class = Parent.Parent as Class106;
			var (num, num2) = method_15(sender as Control, @class, e.X, e.Y);
			@class.method_4(num, num2);
		}
	}

	private void treeViewWithThemedScrollBars_1_MouseUp(object sender, MouseEventArgs e)
	{
		if (Parent != null && Parent.Parent is Class106)
		{
			Class106 @class = Parent.Parent as Class106;
			var (num, num2) = method_15(sender as Control, @class, e.X, e.Y);
			@class.method_5(num, num2);
			if (e.Button == MouseButtons.Right && (sender == treeViewWithThemedScrollBars_0 || sender == treeViewWithThemedScrollBars_1))
			{
				method_18(sender as TreeViewWithThemedScrollBars, e);
			}
		}
	}

	private void method_16(CANFrameModel canframeModel_1)
	{
		if (canframeModel_1 != null)
		{
			method_49(canframeModel_1);
			if (canframeModel_1.FrameDirection == CANFrameModel.Direction.Transmit)
			{
				method_17(canframeModel_1, treeViewWithThemedScrollBars_1);
			}
			else
			{
				method_17(canframeModel_1, treeViewWithThemedScrollBars_0);
			}
		}
	}

	private void method_17(CANFrameModel canframeModel_1, TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_2)
	{
		foreach (TreeNode item in treeViewWithThemedScrollBars_2.method_2())
		{
			if (item.Tag is uint && (uint)item.Tag == canframeModel_1.Index)
			{
				treeViewWithThemedScrollBars_2.method_4(item);
				break;
			}
		}
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		if (bool_0)
		{
			Form23.smethod_53(null, null);
		}
		else
		{
			string text = Class333.smethod_382();
			List<string> list = new List<string>(1);
			CollectionsMarshal.SetCount(list, 1);
			CollectionsMarshal.AsSpan(list)[0] = text;
			List<Color> list2 = new List<Color>(1);
			CollectionsMarshal.SetCount(list2, 1);
			CollectionsMarshal.AsSpan(list2)[0] = Form23.color_7;
			Form23.smethod_52(list, list2, pictureBox_0, canframeModel_0, pictureBox_0.Right, pictureBox_0.Top);
		}
		bool_0 = !bool_0;
	}

	private void pictureBox_1_Click(object sender, EventArgs e)
	{
		if (bool_1)
		{
			Form23.smethod_53(null, null);
		}
		else
		{
			string text = Class333.smethod_383();
			List<string> list = new List<string>(1);
			CollectionsMarshal.SetCount(list, 1);
			CollectionsMarshal.AsSpan(list)[0] = text;
			List<Color> list2 = new List<Color>(1);
			CollectionsMarshal.SetCount(list2, 1);
			CollectionsMarshal.AsSpan(list2)[0] = Form23.color_7;
			Form23.smethod_52(list, list2, pictureBox_1, canframeModel_0, pictureBox_1.Right, pictureBox_1.Top);
		}
		bool_1 = !bool_1;
	}

	private void method_18(TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_2, MouseEventArgs mouseEventArgs_0)
	{
		int x = mouseEventArgs_0.X;
		int y = mouseEventArgs_0.Y;
		TreeNode treeNode = treeViewWithThemedScrollBars_2.method_41(x, y, out var _);
		if (treeNode != null && treeNode.Tag is uint)
		{
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip
			{
				BackColor = Form23.color_15,
				ForeColor = Form23.color_12
			};
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
			{
				Text = Class333.smethod_384(),
				Tag = (uint)treeNode.Tag
			};
			if (treeViewWithThemedScrollBars_2 == treeViewWithThemedScrollBars_0)
			{
				toolStripMenuItem.Click += method_20;
			}
			else
			{
				toolStripMenuItem.Click += method_21;
			}
			contextMenuStrip.Items.Add(toolStripMenuItem);
			contextMenuStrip.Show(treeViewWithThemedScrollBars_2, new Point(x, y));
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		CANFrameModel.Direction direction_ = (CANFrameModel.Direction)(sender as ToolStripMenuItem).Tag;
		method_50(direction_);
	}

	private void method_20(object sender, EventArgs e)
	{
		uint Bkt = (uint)(sender as ToolStripMenuItem).Tag;
		CANFrameModel cANFrameModel = list_0.FirstOrDefault((CANFrameModel canframeModel_0) => canframeModel_0.Index == Bkt);
		if (cANFrameModel != null && cANFrameModel.FrameDirection == CANFrameModel.Direction.Receive)
		{
			method_16(cANFrameModel);
			method_28(treeViewWithThemedScrollBars_0);
		}
	}

	private void method_21(object sender, EventArgs e)
	{
		uint BkU = (uint)(sender as ToolStripMenuItem).Tag;
		CANFrameModel cANFrameModel = list_0.FirstOrDefault((CANFrameModel canframeModel_0) => canframeModel_0.Index == BkU);
		if (cANFrameModel != null && cANFrameModel.FrameDirection == CANFrameModel.Direction.Transmit)
		{
			method_16(cANFrameModel);
			method_28(treeViewWithThemedScrollBars_1);
		}
	}

	private void treeViewWithThemedScrollBars_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Delete && treeViewWithThemedScrollBars_0.method_3() != null)
		{
			method_28(treeViewWithThemedScrollBars_0);
		}
	}

	private void treeViewWithThemedScrollBars_1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Delete && treeViewWithThemedScrollBars_1.method_3() != null)
		{
			method_28(treeViewWithThemedScrollBars_1);
		}
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		method_50(CANFrameModel.Direction.Receive);
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		method_50(CANFrameModel.Direction.Transmit);
	}

	private void method_22(object sender, DrawTreeNodeEventArgs e)
	{
		TreeNode node = e.Node;
		if (node.Tag is uint)
		{
			method_24(treeViewWithThemedScrollBars_0, node, e.Graphics, e.Bounds);
		}
	}

	private void method_23(object sender, DrawTreeNodeEventArgs e)
	{
		TreeNode node = e.Node;
		if (node.Tag is uint)
		{
			method_24(treeViewWithThemedScrollBars_1, node, e.Graphics, e.Bounds);
		}
	}

	private void method_24(TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_2, TreeNode treeNode_0, Graphics graphics_0, Rectangle rectangle_0)
	{
		if (rectangle_0.Y < -10 || rectangle_0.Y > treeViewWithThemedScrollBars_2.Height)
		{
			return;
		}
		int num = treeViewWithThemedScrollBars_2.Width - 20;
		int num2 = num - 12;
		int num3 = rectangle_0.Top + rectangle_0.Height / 2 - 6 - 1;
		int num4 = num3 + 12;
		using SolidBrush brush = new SolidBrush(treeViewWithThemedScrollBars_2.BackColor);
		using Pen pen = new Pen(Form23.color_12, 2f);
		graphics_0.FillRectangle(brush, num2 - 10, num3 - 2, 42, 18);
		graphics_0.DrawLine(pen, num2, num3, num, num4);
		graphics_0.DrawLine(pen, num2, num4, num, num3);
	}

	internal bool method_25(KeyEventArgs keyEventArgs_0)
	{
		if (cansignalEditor_0.IsFocused())
		{
			return cansignalEditor_0.method_8(keyEventArgs_0);
		}
		return false;
	}

	private void method_26()
	{
		if (canframeModel_0 == null)
		{
			label_8.Text = Class333.smethod_325();
		}
		else if (canframeModel_0.FrameDirection == CANFrameModel.Direction.Transmit)
		{
			label_8.Text = Class333.smethod_385();
		}
		else
		{
			label_8.Text = Class333.smethod_386();
		}
	}

	private void method_27()
	{
		if (treeViewWithThemedScrollBars_0.method_2().Count == 0 && treeViewWithThemedScrollBars_1.method_2().Count == 0)
		{
			label_7.Text = Class333.smethod_388();
		}
		else
		{
			label_7.Text = Class333.smethod_387();
		}
	}

	private void method_28(TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_2)
	{
		int Bku = -1;
		if (treeViewWithThemedScrollBars_2.method_3() != null && treeViewWithThemedScrollBars_2.method_3().Tag is uint)
		{
			Bku = (int)(uint)treeViewWithThemedScrollBars_2.method_3().Tag;
			int index = treeViewWithThemedScrollBars_2.method_3().Index;
			treeViewWithThemedScrollBars_2.method_2().Remove(treeViewWithThemedScrollBars_2.method_3());
			method_27();
			if (index >= 0 && treeViewWithThemedScrollBars_2.method_2().Count >= 1)
			{
				if (index >= 1)
				{
					treeViewWithThemedScrollBars_2.method_4(treeViewWithThemedScrollBars_2.method_2()[index - 1]);
				}
				else if (treeViewWithThemedScrollBars_2.method_2().Count > index)
				{
					treeViewWithThemedScrollBars_2.method_4(treeViewWithThemedScrollBars_2.method_2()[index]);
				}
				else
				{
					treeViewWithThemedScrollBars_2.method_4(null);
				}
			}
			else
			{
				treeViewWithThemedScrollBars_2.method_4(null);
			}
			treeViewWithThemedScrollBars_2.Refresh();
		}
		if (Bku < 0)
		{
			return;
		}
		CANFrameModel cANFrameModel = list_0.FirstOrDefault((CANFrameModel cANFrameModel2) => cANFrameModel2.Index == Bku);
		if (cANFrameModel == null)
		{
			return;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_1();
		framework_0.method_55();
		class255_0.BZN.method_268();
		if (cANFrameModel.Signals != null && cANFrameModel.Signals.Count > 0)
		{
			for (int num = cANFrameModel.Signals.Count - 1; num >= 0; num--)
			{
				CANSignalModel cANSignalModel = cANFrameModel.Signals[num];
				class255_0.BZN.method_274(cANSignalModel.Index, -1, bool_0: true);
				Form23.smethod_74(class255_0.BZN.method_64());
			}
		}
		class255_0.BZl.method_271((int)cANFrameModel.Index, 0, bool_0: true);
		Form23.smethod_74(class255_0.BZl.method_64());
		list_0.Remove(cANFrameModel);
		if (treeViewWithThemedScrollBars_2.method_3() != null && treeViewWithThemedScrollBars_2.method_3().Tag is uint)
		{
			Bku = (int)(uint)treeViewWithThemedScrollBars_2.method_3().Tag;
			CANFrameModel canframeModel_ = list_0.FirstOrDefault((CANFrameModel cANFrameModel2) => cANFrameModel2.Index == Bku);
			method_49(canframeModel_);
		}
		else
		{
			method_48();
		}
		method_62();
		class255_0.BZN.method_267(bool_0: true);
		framework_0.method_54(bool_0: true, class255_0.BZN);
		@class?.method_4();
	}

	private void method_29()
	{
		method_30();
		method_31();
		bool flag = true;
		string[] array = class255_0.BZL.method_102()?.Select((Setting.ListItems.Struct45 struct45_0) => struct45_0.bBV).ToArray();
		if (array != null && array.Length != 0)
		{
			ComboBox.ObjectCollection items = themedComboBox_0.Items;
			object[] items2 = array;
			items.AddRange(items2);
		}
		else
		{
			flag = false;
		}
		string[] array2 = class255_0.BZl.method_102()?.Select((Setting.ListItems.Struct45 struct45_0) => struct45_0.bBV).ToArray();
		if (array2 != null && array2.Length != 0)
		{
			ComboBox.ObjectCollection items3 = themedComboBox_1.Items;
			object[] items2 = array2;
			items3.AddRange(items2);
		}
		else
		{
			flag = false;
		}
		string[] array3 = class255_0.BZM.method_102()?.Select((Setting.ListItems.Struct45 struct45_0) => struct45_0.bBV).ToArray();
		if (array3 != null && array3.Length != 0)
		{
			ComboBox.ObjectCollection items4 = themedComboBox_2.Items;
			object[] items2 = array3;
			items4.AddRange(items2);
		}
		else
		{
			flag = false;
		}
		List<ValueAndDisplay> signDataSource = class255_0.BZQ.method_102()?.Select((Setting.ListItems.Struct45 struct45_0) => new ValueAndDisplay
		{
			Value = struct45_0.bBv,
			Display = struct45_0.bBV
		}).ToList();
		cansignalEditor_0.ApplySignComboBoxDataSource(signDataSource);
		List<ValueAndDisplay> formatDataSource = class255_0.BZp.method_102()?.Select((Setting.ListItems.Struct45 struct45_0) => new ValueAndDisplay
		{
			Value = struct45_0.bBv,
			Display = struct45_0.bBV
		}).ToList();
		cansignalEditor_0.ApplyFormatComboBoxDataSource(formatDataSource);
		if (!flag)
		{
			Form54.smethod_6(this, Class333.smethod_389(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			method_44(list_0);
		}
	}

	private void method_30()
	{
		int num = class255_0.BZL.method_242()[2];
		for (int i = 0; i < num; i++)
		{
			CANFrameModel cANFrameModel = CANFrameModel.smethod_0(class255_0, (uint)i);
			if (cANFrameModel != null)
			{
				list_0.Add(cANFrameModel);
			}
		}
	}

	private void method_31()
	{
		int num = class255_0.BZN.method_242()[2];
		for (int i = 0; i < num; i++)
		{
			int BkV = class255_0.BZN.method_258(i);
			if (BkV == -1)
			{
				continue;
			}
			CANSignalModel item = CANSignalModel.smethod_0(class255_0, framework_0, null, BkV, i, int_6);
			CANFrameModel cANFrameModel = list_0.FirstOrDefault((CANFrameModel canframeModel_0) => canframeModel_0.Index == BkV);
			if (cANFrameModel != null)
			{
				CANFrameModel cANFrameModel2 = cANFrameModel;
				if (cANFrameModel2.Signals == null)
				{
					cANFrameModel2.Signals = new List<CANSignalModel>();
				}
				cANFrameModel.Signals.Add(item);
			}
		}
		foreach (CANFrameModel item2 in list_0)
		{
			item2.method_2();
			if (item2.Signals == null)
			{
				continue;
			}
			foreach (CANSignalModel signal in item2.Signals)
			{
				method_39(item2, signal, bool_6: false);
			}
		}
	}

	private int method_32()
	{
		int num = class255_0.BZN.method_242()[2];
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				if (class255_0.BZN.method_258(num2) == -1)
				{
					break;
				}
				num2++;
				continue;
			}
			return -1;
		}
		return num2;
	}

	private string method_33(CANSignalModel cansignalModel_0)
	{
		int num = 1;
		string text = Class333.smethod_391() + num;
		bool flag = false;
		do
		{
			flag = false;
			foreach (CANSignalModel signal in canframeModel_0.Signals)
			{
				if (signal != cansignalModel_0 && signal.Name != null && signal.Name == text)
				{
					num++;
					text = Class333.smethod_391() + num;
					flag = true;
				}
			}
		}
		while (flag);
		return text;
	}

	private bool method_34(CANFrameModel canframeModel_1, CANSignalModel cansignalModel_0)
	{
		int num = method_32();
		if (num == -1)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
			defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_392());
			defaultInterpolatedStringHandler.AppendFormatted(class255_0.BZN.method_242()[2]);
			defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_393());
			Form54.smethod_6(this, defaultInterpolatedStringHandler.ToStringAndClear(), Class333.smethod_394(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return false;
		}
		cansignalModel_0.Index = num;
		if (cansignalModel_0.Name == null)
		{
			cansignalModel_0.Name = method_33(cansignalModel_0);
		}
		cansignalModel_0.Int32_0 = (int)canframeModel_1.Index;
		method_38(canframeModel_1, cansignalModel_0);
		method_14();
		cansignalEditor_0.Refresh();
		return true;
	}

	private int method_35(CANFrameModel canframeModel_1, CANSignalModel cansignalModel_0)
	{
		if (canframeModel_1.Signals != null && canframeModel_1.Signals.IndexOf(cansignalModel_0) > 0)
		{
			return canframeModel_1.Signals[canframeModel_1.Signals.IndexOf(cansignalModel_0) - 1].Format;
		}
		return class255_0.BZp.method_235();
	}

	private uint method_36(CANFrameModel canframeModel_1, CANSignalModel cansignalModel_0)
	{
		if (canframeModel_1.Length == 0)
		{
			return 0u;
		}
		uint num = 8 * canframeModel_1.Length - 1;
		switch ((CANSignalModel.SignalFormat)cansignalModel_0.Format)
		{
		case CANSignalModel.SignalFormat.LittleEndian:
		{
			for (uint num4 = 0u; num4 <= num; num4++)
			{
				if (!canframeModel_1.method_1(num4))
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
				if (!canframeModel_1.method_1(num2))
				{
					return num2;
				}
				num2 = ((num2 % 8 != 0) ? (num2 - 1) : (num2 + 15));
			}
			break;
		}
		}
		return (uint)class255_0.BZo.method_235();
	}

	private uint method_37(CANFrameModel canframeModel_1, CANSignalModel cansignalModel_0)
	{
		if (canframeModel_1.Length == 0)
		{
			return 0u;
		}
		uint num = 8 * canframeModel_1.Length - 1;
		uint num2 = 0u;
		switch ((CANSignalModel.SignalFormat)cansignalModel_0.Format)
		{
		case CANSignalModel.SignalFormat.LittleEndian:
		{
			for (uint num5 = cansignalModel_0.StartBit; num5 <= num && !canframeModel_1.method_1(num5); num5++)
			{
				num2++;
			}
			break;
		}
		case CANSignalModel.SignalFormat.BigEndian:
		{
			uint num3 = cansignalModel_0.StartBit;
			for (uint num4 = 0u; num4 <= num; num4++)
			{
				if (canframeModel_1.method_1(num3))
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
		return Math.Min(num2, (uint)class255_0.BZP.method_235());
	}

	private void method_38(CANFrameModel canframeModel_1, CANSignalModel cansignalModel_0)
	{
		if (cansignalModel_0.Format == 0)
		{
			cansignalModel_0.Format = method_35(canframeModel_1, cansignalModel_0);
		}
		if (cansignalModel_0.StartBit == 0)
		{
			cansignalModel_0.StartBit = method_36(canframeModel_1, cansignalModel_0);
		}
		if (cansignalModel_0.BitLength == 0)
		{
			cansignalModel_0.BitLength = method_37(canframeModel_1, cansignalModel_0);
		}
		if (cansignalModel_0.Sign == 0)
		{
			cansignalModel_0.Sign = class255_0.BZQ.method_235();
		}
		cansignalModel_0.Bus = int_6;
		if (cansignalModel_0.Source == null)
		{
			switch (class255_0.BZn.method_235())
			{
			case 2:
			{
				int val = class255_0.BZO.method_235();
				cansignalModel_0.Source = new FixedSource(val);
				break;
			}
			case 3:
			{
				int num = class255_0.BZO.method_235();
				Setting setting = framework_0.method_31(num);
				if (setting != null)
				{
					cansignalModel_0.Source = new ChannelSource(setting);
				}
				break;
			}
			case 4:
				cansignalModel_0.Source = new CounterSource();
				break;
			}
		}
		if (cansignalModel_0.Multiplier == 0f)
		{
			byte[] bytes = BitConverter.GetBytes(class255_0.BZq.method_235());
			cansignalModel_0.Multiplier = BitConverter.ToSingle(bytes, 0);
		}
		if (cansignalModel_0.Offset == 0f)
		{
			byte[] bytes2 = BitConverter.GetBytes(class255_0.BZR.method_235());
			cansignalModel_0.Offset = BitConverter.ToSingle(bytes2, 0);
		}
	}

	private void method_39(CANFrameModel canframeModel_1, CANSignalModel cansignalModel_0, bool bool_6)
	{
		if (cansignalModel_0 != null && canframeModel_1 != null)
		{
			cansignalModel_0.Multiplier = method_42(canframeModel_1, class255_0.BZq, cansignalModel_0.Multiplier, bool_6);
			cansignalModel_0.Offset = method_42(canframeModel_1, class255_0.BZR, cansignalModel_0.Offset, bool_6);
			cansignalModel_0.StartBit = (uint)method_42(canframeModel_1, class255_0.BZo, cansignalModel_0.StartBit, bool_6);
			cansignalModel_0.HasZeroMultiplierWarning = cansignalModel_0.Multiplier == 0f;
			method_41(canframeModel_1, cansignalModel_0);
			method_40(canframeModel_1, cansignalModel_0);
			method_62();
		}
	}

	private void method_40(CANFrameModel canframeModel_1, CANSignalModel cansignalModel_0)
	{
		if (string.IsNullOrWhiteSpace(cansignalModel_0.Name))
		{
			cansignalModel_0.HasSignalNameError = true;
			return;
		}
		bool flag = true;
		foreach (CANFrameModel item in list_0)
		{
			if (item.Signals == null)
			{
				continue;
			}
			foreach (CANSignalModel signal in item.Signals)
			{
				if (signal != cansignalModel_0 && signal.Index != -1 && signal.Name == cansignalModel_0.Name)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		cansignalModel_0.HasSignalNameError = !flag;
	}

	private void method_41(CANFrameModel canframeModel_1, CANSignalModel cansignalModel_0)
	{
		CANSignalModel.SignalFormat format = (CANSignalModel.SignalFormat)cansignalModel_0.Format;
		int num = -1;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 8 * canframeModel_1.Length;
		cansignalModel_0.method_4();
		switch (format)
		{
		case CANSignalModel.SignalFormat.LittleEndian:
		{
			num2 = cansignalModel_0.StartBit + cansignalModel_0.BitLength - 1;
			for (uint num5 = cansignalModel_0.StartBit; num5 < cansignalModel_0.StartBit + cansignalModel_0.BitLength; num5++)
			{
				if (!canframeModel_1.method_1(num5))
				{
					if (num5 < num4)
					{
						canframeModel_1.method_0(num5);
						cansignalModel_0.method_2(num5);
						num3++;
					}
					continue;
				}
				num = (int)num5;
				num3 = num5 - cansignalModel_0.StartBit;
				break;
			}
			break;
		}
		case CANSignalModel.SignalFormat.BigEndian:
		{
			num2 = cansignalModel_0.StartBit;
			for (int i = 0; i < cansignalModel_0.BitLength; i++)
			{
				if (canframeModel_1.method_1(num2) && num == -1)
				{
					num = (int)num2;
				}
				else
				{
					canframeModel_1.method_0(num2);
				}
				cansignalModel_0.method_2(num2);
				if (num == -1 && num2 < num4)
				{
					num3++;
				}
				if (i != cansignalModel_0.BitLength - 1)
				{
					num2 = ((num2 % 8 != 0) ? (num2 - 1) : (num2 + 15));
				}
			}
			break;
		}
		}
		if (cansignalModel_0.BitLength > num3)
		{
			cansignalModel_0.HasBeyondEndOfFrameError = num2 >= num4;
			if (num != -1)
			{
				cansignalModel_0.HasBitOverlapError = true;
				{
					foreach (CANSignalModel signal in canframeModel_1.Signals)
					{
						if (cansignalModel_0 != signal && (signal.method_1() & cansignalModel_0.method_1()) != 0L)
						{
							signal.HasBitOverlapError = true;
						}
					}
					return;
				}
			}
			cansignalModel_0.HasBitOverlapError = false;
		}
		else
		{
			cansignalModel_0.HasBitOverlapError = false;
			cansignalModel_0.HasBeyondEndOfFrameError = false;
		}
	}

	private float method_42(CANFrameModel canframeModel_1, Setting setting_0, float float_0, bool bool_6)
	{
		int num = setting_0.method_228();
		int num2 = setting_0.method_229();
		if ((num != num2 || num != 0 || num2 != 0) && bool_6)
		{
			if (float_0 < (float)num)
			{
				float_0 = num;
			}
			else if (float_0 > (float)num2)
			{
				float_0 = num2;
			}
		}
		return float_0;
	}

	private void method_43(object object_0, List<CANSignalModel> list_1)
	{
		if (canframeModel_0 == null)
		{
			return;
		}
		bool_2 = true;
		Class280 @class = Form23.smethod_95();
		@class?.method_1();
		framework_0.method_55();
		class255_0.BZN.method_268();
		List<CANSignalModel> list = null;
		if (canframeModel_0.Signals != null)
		{
			list = canframeModel_0.Signals.Where((CANSignalModel cansignalModel_0) => !list_1.Any((CANSignalModel cANSignalModel2) => cANSignalModel2.Index == cansignalModel_0.Index)).ToList();
		}
		foreach (CANSignalModel item in list_1)
		{
			item.FrameDirection = canframeModel_0.FrameDirection;
		}
		canframeModel_0.Signals = list_1;
		if (list != null && list.Count != 0)
		{
			method_14();
			foreach (CANSignalModel item2 in list)
			{
				class255_0.BZN.method_274(item2.Index, -1, bool_0: true);
				Form23.smethod_74(class255_0.BZN.method_64());
			}
		}
		canframeModel_0.method_2();
		for (int num = 0; num < canframeModel_0.Signals.Count; num++)
		{
			CANSignalModel cANSignalModel = canframeModel_0.Signals[num];
			if (cANSignalModel.Index == -1 && !method_34(canframeModel_0, cANSignalModel))
			{
				canframeModel_0.Signals.Remove(cANSignalModel);
				num--;
			}
			else
			{
				method_39(canframeModel_0, cANSignalModel, bool_6: true);
				method_60(cANSignalModel, canframeModel_0.Index);
			}
		}
		foreach (CANFrameModel item3 in list_0)
		{
			if (item3 == canframeModel_0)
			{
				continue;
			}
			item3.method_2();
			if (item3.Signals == null)
			{
				continue;
			}
			foreach (CANSignalModel signal in item3.Signals)
			{
				method_39(item3, signal, bool_6: false);
			}
		}
		themedBitfieldViewer_0.UpdateSignals(canframeModel_0);
		method_3(bool_6: true, canframeModel_0);
		method_72();
		method_62();
		class255_0.BZN.method_267(bool_0: true);
		framework_0.method_54(bool_0: true, class255_0.BZN);
		@class?.method_4();
		bool_2 = false;
	}

	private void cansignalEditor_0_SignalSelectionChanged(object sender, EventArgs e)
	{
		CANSignalModel selectedSignal = cansignalEditor_0.GetSelectedSignal();
		if (selectedSignal != null)
		{
			themedBitfieldViewer_0.SelectSignal(selectedSignal);
		}
		else
		{
			themedBitfieldViewer_0.ClearSignalSelection();
		}
	}

	private void themedBitfieldViewer_0_SignalSelectionChanged(object sender, EventArgs e)
	{
		CANSignalModel selectedSignal = themedBitfieldViewer_0.GetSelectedSignal();
		if (selectedSignal != null)
		{
			cansignalEditor_0.SelectSignal(selectedSignal);
		}
	}

	private void themedBitfieldViewer_0_SelectedSignalBitsChanged(object sender, EventArgs e)
	{
		CANSignalModel selectedSignal = themedBitfieldViewer_0.GetSelectedSignal();
		if (selectedSignal != null)
		{
			int num = class255_0.BZo.method_258(selectedSignal.Index);
			int num2 = class255_0.BZP.method_258(selectedSignal.Index);
			int startBit = (int)selectedSignal.StartBit;
			int bitLength = (int)selectedSignal.BitLength;
			if (num != startBit && num2 != bitLength)
			{
				framework_0.method_55();
				class255_0.BZo.method_268();
				class255_0.BZP.method_268();
			}
			if (num != startBit)
			{
				class255_0.BZo.method_274(selectedSignal.Index, startBit, bool_0: true);
				Form23.smethod_74(class255_0.BZo.method_64());
			}
			if (num2 != bitLength)
			{
				class255_0.BZP.method_274(selectedSignal.Index, bitLength, bool_0: true);
				Form23.smethod_74(class255_0.BZP.method_64());
			}
			if (num != startBit && num2 != bitLength)
			{
				class255_0.BZo.method_267(bool_0: true);
				class255_0.BZP.method_267(bool_0: true);
				framework_0.method_54(bool_0: true);
			}
		}
	}

	private void method_44(List<CANFrameModel> list_1)
	{
		if (list_1 == null)
		{
			treeViewWithThemedScrollBars_0.method_5();
			treeViewWithThemedScrollBars_0.method_2().Clear();
			treeViewWithThemedScrollBars_0.method_6();
			treeViewWithThemedScrollBars_1.method_5();
			treeViewWithThemedScrollBars_1.method_2().Clear();
			treeViewWithThemedScrollBars_1.method_6();
			method_27();
		}
		else
		{
			List<CANFrameModel> list_2 = list_1.Where((CANFrameModel canframeModel_0) => canframeModel_0.FrameDirection == CANFrameModel.Direction.Receive).ToList();
			method_45(list_2, treeViewWithThemedScrollBars_0);
			List<CANFrameModel> list_3 = list_1.Where((CANFrameModel canframeModel_0) => canframeModel_0.FrameDirection == CANFrameModel.Direction.Transmit).ToList();
			method_45(list_3, treeViewWithThemedScrollBars_1);
			method_62();
		}
	}

	private void method_45(List<CANFrameModel> list_1, TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_2)
	{
		treeViewWithThemedScrollBars_2.method_5();
		treeViewWithThemedScrollBars_2.method_2().Clear();
		foreach (CANFrameModel item2 in list_1)
		{
			TreeNode item = new TreeNode((string.IsNullOrEmpty(item2.Name) ? Class333.smethod_395() : item2.Name) + Class333.smethod_396())
			{
				Tag = item2.Index,
				ForeColor = (item2.Enabled ? Form23.color_12 : Form23.color_36)
			};
			treeViewWithThemedScrollBars_2.method_2().Add(item);
		}
		treeViewWithThemedScrollBars_2.method_6();
		method_46(treeViewWithThemedScrollBars_2);
		method_27();
	}

	private void method_46(TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_2)
	{
		if (treeViewWithThemedScrollBars_2.method_2().Count == 0)
		{
			return;
		}
		using (Font font = new Font(treeViewWithThemedScrollBars_2.Font, FontStyle.Bold))
		{
			foreach (TreeNode item in treeViewWithThemedScrollBars_2.method_2())
			{
				string text = item.Text.Substring(0, item.Text.Length - Class333.smethod_396().Length);
				if (TextRenderer.MeasureText(text, font, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.NoPrefix).Width > treeViewWithThemedScrollBars_2.Width - 20 - 12 - 10)
				{
					item.ToolTipText = text;
				}
				else
				{
					item.ToolTipText = string.Empty;
				}
			}
		}
		treeViewWithThemedScrollBars_2.Invalidate();
	}

	private void treeViewWithThemedScrollBars_0_SizeChanged(object sender, EventArgs e)
	{
		method_46(treeViewWithThemedScrollBars_0);
	}

	private void treeViewWithThemedScrollBars_1_SizeChanged(object sender, EventArgs e)
	{
		method_46(treeViewWithThemedScrollBars_1);
	}

	private void method_47(uint uint_0, bool bool_6)
	{
		if (bool_6)
		{
			class255_0.BZS.method_272((int)uint_0, bool_0: true);
		}
		else
		{
			class255_0.BZS.method_272((int)uint_0 | int.MinValue, bool_0: true);
		}
	}

	private void method_48()
	{
		cansignalEditor_0.Visible = false;
		label_7.Visible = true;
		method_1();
		canframeModel_0 = null;
		themedBitfieldViewer_0.UpdateSignals(null);
		timer_0.Stop();
		method_65();
		method_67();
		Form23.smethod_53(null, null);
		method_72();
		method_26();
	}

	private void method_49(CANFrameModel canframeModel_1)
	{
		bool_2 = true;
		Form23.smethod_53(null, null);
		method_0(canframeModel_1);
		canframeModel_0 = canframeModel_1;
		if (!method_69(canframeModel_1.StdFrame, out var uint_))
		{
			uint_ = uint.MaxValue;
			method_71();
		}
		method_66();
		method_68(canframeModel_1, uint_);
		method_47(uint_, canframeModel_1.StdFrame);
		method_72();
		method_26();
		label_7.Visible = false;
		cansignalEditor_0.Visible = true;
		themedBitfieldViewer_0.UpdateSignals(canframeModel_1);
		if (canframeModel_1.Signals == null)
		{
			cansignalEditor_0.method_4(null, canframeModel_1.FrameDirection);
		}
		else
		{
			List<CANSignalModel> list = new List<CANSignalModel>(canframeModel_1.Signals);
			canframeModel_1.method_2();
			for (int i = 0; i < list.Count; i++)
			{
				CANSignalModel cANSignalModel = list[i];
				if (cANSignalModel.Index != -1)
				{
					method_39(canframeModel_1, cANSignalModel, bool_6: false);
				}
			}
			cansignalEditor_0.method_4(list, canframeModel_1.FrameDirection);
		}
		method_14();
		timer_0.Start();
		cansignalEditor_0.method_3();
		bool_2 = false;
	}

	private void method_50(CANFrameModel.Direction direction_0)
	{
		uint num = 0u;
		byte[] array = class255_0.BZl.method_259();
		uint num2 = 0u;
		while (true)
		{
			if (num2 < array.Length)
			{
				if (CANFrameModel.IsFrameVisible(array[num2]))
				{
					if (num2 == array.Length - 1)
					{
						break;
					}
					num2++;
					continue;
				}
				num = num2;
			}
			CANFrameModel cANFrameModel = new CANFrameModel
			{
				Index = num,
				StdFrame = true,
				Name = Class333.smethod_399() + (num + 1),
				FrameDirection = direction_0,
				Signals = new List<CANSignalModel>()
			};
			list_0.Add(cANFrameModel);
			method_55(cANFrameModel);
			Class280 @class = Form23.smethod_95();
			@class?.method_1();
			method_56(cANFrameModel, bool_6: false);
			method_57(cANFrameModel, bool_6: false);
			method_58(cANFrameModel, bool_6: false);
			method_59(cANFrameModel, bool_6: false);
			method_44(list_0);
			method_16(cANFrameModel);
			@class?.method_4();
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
		defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_392());
		defaultInterpolatedStringHandler.AppendFormatted(array.Length);
		defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_397());
		Form54.smethod_6(this, defaultInterpolatedStringHandler.ToStringAndClear(), Class333.smethod_398(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	private void method_51(object sender, TreeViewEventArgs e)
	{
		method_53(sender, e, CANFrameModel.Direction.Receive);
	}

	private void method_52(object sender, TreeViewEventArgs e)
	{
		method_53(sender, e, CANFrameModel.Direction.Transmit);
	}

	private void method_53(object object_0, TreeViewEventArgs treeViewEventArgs_0, CANFrameModel.Direction direction_0)
	{
		if (treeViewEventArgs_0.Node != null && treeViewEventArgs_0.Node.Tag != null)
		{
			CANFrameModel cANFrameModel = method_64(treeViewEventArgs_0.Node);
			if (cANFrameModel != null)
			{
				method_54(direction_0);
				method_49(cANFrameModel);
			}
		}
		else
		{
			canframeModel_0 = null;
			method_48();
			method_54(direction_0);
		}
	}

	private void method_54(CANFrameModel.Direction direction_0)
	{
		if (direction_0 == CANFrameModel.Direction.Transmit)
		{
			treeViewWithThemedScrollBars_0.method_4(null);
		}
		else
		{
			treeViewWithThemedScrollBars_1.method_4(null);
		}
	}

	private void method_55(CANFrameModel canframeModel_1)
	{
		canframeModel_1.Enabled = CANFrameModel.IsFrameEnabled((byte)class255_0.BZl.method_235());
		canframeModel_1.Length = (uint)(class255_0.BZl.method_235() & 0x3F);
		int canIdByte = class255_0.BZL.method_235();
		canframeModel_1.ParseCanIdByte((uint)canIdByte);
		canframeModel_1.Rate = class255_0.BZM.method_235() & 0x3F;
	}

	private void method_56(CANFrameModel canframeModel_1, bool bool_6)
	{
		if (canframeModel_1 != null)
		{
			Class280 @class = null;
			if (bool_6)
			{
				@class = Form23.smethod_95();
				@class?.method_1();
			}
			class255_0.BZk.method_263(canframeModel_1.Name, (int)canframeModel_1.Index, bool_0: true);
			Form23.smethod_74(class255_0.BZk.method_64());
			@class?.method_4();
		}
	}

	private void method_57(CANFrameModel canframeModel_1, bool bool_6)
	{
		if (canframeModel_1 != null)
		{
			Class280 @class = null;
			if (bool_6)
			{
				@class = Form23.smethod_95();
				@class?.method_1();
			}
			class255_0.BZL.method_274((int)canframeModel_1.Index, (int)canframeModel_1.GetCanIdSettingValue(), bool_0: true);
			Form23.smethod_74(class255_0.BZL.method_64());
			@class?.method_4();
		}
	}

	private void method_58(CANFrameModel canframeModel_1, bool bool_6)
	{
		if (canframeModel_1 != null)
		{
			Class280 @class = null;
			if (bool_6)
			{
				@class = Form23.smethod_95();
				@class?.method_1();
			}
			class255_0.BZl.method_274((int)canframeModel_1.Index, canframeModel_1.GetEnableLengthValue(), bool_0: true);
			Form23.smethod_74(class255_0.BZl.method_64());
			@class?.method_4();
		}
	}

	private void method_59(CANFrameModel canframeModel_1, bool bool_6)
	{
		if (canframeModel_1 != null)
		{
			Class280 @class = null;
			if (bool_6)
			{
				@class = Form23.smethod_95();
				@class?.method_1();
			}
			class255_0.BZM.method_274((int)canframeModel_1.Index, canframeModel_1.GetTransmitRateValue(), bool_0: true);
			Form23.smethod_74(class255_0.BZM.method_64());
			@class?.method_4();
		}
	}

	private void method_60(CANSignalModel cansignalModel_0, uint uint_0)
	{
		if (class255_0.BZm.method_261(cansignalModel_0.Index) != cansignalModel_0.Name)
		{
			class255_0.BZm.method_263(cansignalModel_0.Name ?? string.Empty, cansignalModel_0.Index, bool_0: true);
			Form23.smethod_74(class255_0.BZm.method_64());
		}
		byte signalTypeFromSource = cansignalModel_0.GetSignalTypeFromSource();
		if (class255_0.BZn.method_258(cansignalModel_0.Index) != signalTypeFromSource)
		{
			class255_0.BZn.method_274(cansignalModel_0.Index, signalTypeFromSource, bool_0: true);
			Form23.smethod_74(class255_0.BZn.method_64());
		}
		int num = ((!(cansignalModel_0.Source is ChannelSource channelSource)) ? ((cansignalModel_0.Source is FixedSource fixedSource) ? fixedSource.Value : 0) : channelSource.Channel.method_64());
		if (class255_0.BZO.method_258(cansignalModel_0.Index) != num)
		{
			class255_0.BZO.method_274(cansignalModel_0.Index, num, bool_0: true);
			Form23.smethod_74(class255_0.BZO.method_64());
		}
		if (class255_0.BZo.method_258(cansignalModel_0.Index) != (int)cansignalModel_0.StartBit)
		{
			class255_0.BZo.method_274(cansignalModel_0.Index, (int)cansignalModel_0.StartBit, bool_0: true);
			Form23.smethod_74(class255_0.BZo.method_64());
		}
		if (class255_0.BZP.method_258(cansignalModel_0.Index) != (int)cansignalModel_0.BitLength)
		{
			class255_0.BZP.method_274(cansignalModel_0.Index, (int)cansignalModel_0.BitLength, bool_0: true);
			Form23.smethod_74(class255_0.BZP.method_64());
		}
		if (class255_0.BZp.method_258(cansignalModel_0.Index) != (byte)cansignalModel_0.Format)
		{
			class255_0.BZp.method_274(cansignalModel_0.Index, (byte)cansignalModel_0.Format, bool_0: true);
			Form23.smethod_74(class255_0.BZp.method_64());
		}
		if (class255_0.BZQ.method_258(cansignalModel_0.Index) != (byte)cansignalModel_0.Sign)
		{
			class255_0.BZQ.method_274(cansignalModel_0.Index, (byte)cansignalModel_0.Sign, bool_0: true);
			Form23.smethod_74(class255_0.BZQ.method_64());
		}
		byte[] bytes = BitConverter.GetBytes(cansignalModel_0.Multiplier);
		byte[] bytes2 = BitConverter.GetBytes(cansignalModel_0.Offset);
		if (!framework_0.aWR)
		{
			Array.Reverse(bytes);
			Array.Reverse(bytes2);
		}
		if (class255_0.BZq.method_258(cansignalModel_0.Index) != BitConverter.ToInt32(bytes))
		{
			class255_0.BZq.method_274(cansignalModel_0.Index, BitConverter.ToInt32(bytes), bool_0: true);
			Form23.smethod_74(class255_0.BZq.method_64());
		}
		if (class255_0.BZR.method_258(cansignalModel_0.Index) != BitConverter.ToInt32(bytes2))
		{
			class255_0.BZR.method_274(cansignalModel_0.Index, BitConverter.ToInt32(bytes2), bool_0: true);
			Form23.smethod_74(class255_0.BZR.method_64());
		}
		if (class255_0.BZr.method_258(cansignalModel_0.Index) != cansignalModel_0.Units)
		{
			class255_0.BZr.method_274(cansignalModel_0.Index, cansignalModel_0.Units, bool_0: true);
			Form23.smethod_74(class255_0.BZr.method_64());
		}
		if (class255_0.BZN.method_258(cansignalModel_0.Index) != (short)uint_0)
		{
			class255_0.BZN.method_274(cansignalModel_0.Index, (short)uint_0, bool_0: true);
			Form23.smethod_74(class255_0.BZN.method_64());
			Form23.smethod_74(class255_0.BZM.method_64());
		}
	}

	private bool method_61(CANFrameModel canframeModel_1)
	{
		if (canframeModel_1.Signals != null)
		{
			foreach (CANSignalModel signal in canframeModel_1.Signals)
			{
				if (signal.HasBitOverlapError || signal.HasBeyondEndOfFrameError || signal.HasSignalNameError || signal.InvalidUnits || (canframeModel_1.FrameDirection == CANFrameModel.Direction.Transmit && signal.Source == null))
				{
					return true;
				}
			}
		}
		return false;
	}

	private void method_62()
	{
		foreach (CANFrameModel Bks in list_0)
		{
			bool flag = !string.IsNullOrEmpty(Bks.Name) && list_0.Where((CANFrameModel canframeModel_0) => canframeModel_0 != Bks && canframeModel_0.Name == Bks.Name).ToList().Count != 0;
			bool flag2 = (Bks.StdFrame ? class255_0.BZI.Contains((ushort)Bks.CANId) : class255_0.BZJ.Contains(Bks.CANId));
			Bks.InError = (string.IsNullOrEmpty(Bks.Name) | flag | flag2) || method_61(Bks);
		}
		method_63(treeViewWithThemedScrollBars_0, CANFrameModel.Direction.Receive);
		method_63(treeViewWithThemedScrollBars_1, CANFrameModel.Direction.Transmit);
	}

	private void method_63(TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_2, CANFrameModel.Direction direction_0)
	{
		foreach (TreeNode item in treeViewWithThemedScrollBars_2.method_2())
		{
			CANFrameModel cANFrameModel = method_64(item);
			if (cANFrameModel == null)
			{
				item.ForeColor = Form23.color_12;
			}
			else if (!cANFrameModel.Enabled)
			{
				item.ForeColor = Form23.color_36;
			}
			else if (cANFrameModel.InError)
			{
				item.ForeColor = Form23.color_7;
			}
			else
			{
				item.ForeColor = Form23.color_12;
			}
		}
		treeViewWithThemedScrollBars_2.Invalidate();
	}

	private CANFrameModel method_64(TreeNode treeNode_0)
	{
		if (treeNode_0.Tag is uint)
		{
			uint BkT = (uint)treeNode_0.Tag;
			return list_0.FirstOrDefault((CANFrameModel canframeModel_0) => canframeModel_0.Index == BkT);
		}
		return null;
	}

	private void method_65()
	{
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		pictureBox_0.Visible = false;
		if (bool_0)
		{
			Form23.smethod_53(null, null);
		}
	}

	private void method_66()
	{
		if (class255_0.BZk.method_122())
		{
			method_65();
			return;
		}
		bool flag = string.IsNullOrEmpty(themedTextBox_0.Text);
		if (flag | (!flag && list_0.Where((CANFrameModel canframeModel_1) => canframeModel_1 != canframeModel_0 && canframeModel_1.Name == themedTextBox_0.Text).ToList().Count != 0))
		{
			pictureBox_0.Visible = true;
			themedTextBox_0.BackColor = Form23.color_7;
			themedTextBox_0.ForeColor = Form23.color_12;
		}
		else
		{
			method_65();
		}
	}

	private void method_67()
	{
		themedTextBox_1.BackColor = Form23.color_32;
		themedTextBox_1.ForeColor = Form23.color_12;
		pictureBox_1.Visible = false;
		if (bool_1)
		{
			Form23.smethod_53(null, null);
		}
	}

	private void method_68(CANFrameModel canframeModel_1, uint uint_0)
	{
		bool flag = (canframeModel_1.StdFrame ? class255_0.BZI.Contains((ushort)uint_0) : class255_0.BZJ.Contains(uint_0));
		if ((canframeModel_1 != null) & flag)
		{
			pictureBox_1.Visible = true;
			themedTextBox_1.BackColor = Form23.color_7;
			themedTextBox_1.ForeColor = Form23.color_12;
		}
		else
		{
			method_67();
		}
	}

	private bool method_69(bool bool_6, out uint uint_0)
	{
		string text = themedTextBox_1.Text;
		if (text.Length == 0)
		{
			uint_0 = 0u;
			return false;
		}
		string text2;
		if (text.Length > 2 && text.StartsWith(Class333.smethod_381(), StringComparison.OrdinalIgnoreCase))
		{
			text2 = text.Substring(2);
		}
		else if (text.Length > 1 && text.StartsWith(Class333.smethod_400(), StringComparison.OrdinalIgnoreCase))
		{
			text2 = text.Substring(1);
			themedTextBox_1.Text = Class333.smethod_381() + text2;
		}
		else if (text.Length > 1 && text.EndsWith(Class333.smethod_400(), StringComparison.OrdinalIgnoreCase))
		{
			text2 = text.Substring(0, text.Length - 1);
			themedTextBox_1.Text = Class333.smethod_381() + text2;
		}
		else
		{
			text2 = text;
			if (!text.StartsWith(Class333.smethod_381()))
			{
				themedTextBox_1.Text = Class333.smethod_381() + text2;
			}
		}
		if (uint.TryParse(text2, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out uint_0))
		{
			string text3 = (bool_6 ? Class333.smethod_380() : Class333.smethod_379());
			themedTextBox_1.Text = Class333.smethod_381() + uint_0.ToString(text3);
			return true;
		}
		uint_0 = 0u;
		return false;
	}

	private void method_70()
	{
		bool_5 = true;
		themedTextBox_1.BackColor = Form23.color_7;
		bool flag = themedComboBox_0.SelectedIndex == 0;
		Form54.smethod_6(this, Class333.smethod_401() + (flag ? 11 : 29) + Class333.smethod_402() + (flag ? Class333.smethod_403() : Class333.smethod_190()), Class333.smethod_404(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		bool_5 = false;
	}

	private void method_71()
	{
		bool_5 = true;
		themedTextBox_1.BackColor = Form23.color_7;
		Form54.smethod_6(this, Class333.smethod_405(), Class333.smethod_404(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		bool_5 = false;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (canframeModel_0 != null && class255_0.BZS.method_256() == -1)
		{
			int num = class255_0.BZL.method_258((int)canframeModel_0.Index);
			bool bool_;
			uint uint_ = (uint)((bool_ = CANFrameModel.IsFrameStdId((uint)num)) ? (num & 0x7FF) : (num & 0x1FFFFFFF));
			method_47(uint_, bool_);
		}
		if (class255_0.BZs != null)
		{
			byte[] array = class255_0.BZs.method_259();
			if (array.Length == 8)
			{
				long val = BitConverter.ToInt64(array);
				cansignalEditor_0.UpdateRawValue(val);
				method_72();
			}
		}
	}

	private void method_72()
	{
		if (Form23.smethod_28(framework_0.aXc, bool_53: true) && !Form23.smethod_80())
		{
			if (class255_0.BZs != null)
			{
				byte[] array = class255_0.BZs.method_259();
				if (array.Length == 8)
				{
					long val = BitConverter.ToInt64(array);
					canrawDataView_0.UpdateValue(val);
				}
			}
		}
		else
		{
			canrawDataView_0.UpdateValue(0L);
		}
	}

	public void Close()
	{
		method_9();
		timer_0?.Dispose();
		class255_0.BZS.method_272(-1, bool_0: true);
		if (canframeModel_0 == null)
		{
			int_3 = -1;
		}
		else
		{
			int_3 = (int)canframeModel_0.Index;
		}
	}

	private void method_73()
	{
		if (themedTextBox_0.Text != canframeModel_0.Name)
		{
			canframeModel_0.Name = themedTextBox_0.Text;
			method_56(canframeModel_0, bool_6: true);
		}
	}

	private void themedTextBox_0_LostFocus(object sender, EventArgs e)
	{
		method_73();
	}

	private void themedTextBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			method_73();
			e.Handled = true;
			e.SuppressKeyPress = true;
		}
	}

	private void themedTextBox_1_LostFocus(object sender, EventArgs e)
	{
		if (!bool_5)
		{
			method_74();
		}
	}

	private void themedTextBox_1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			method_74();
			e.Handled = true;
			e.SuppressKeyPress = true;
		}
	}

	private void method_74()
	{
		bool flag = themedComboBox_0.SelectedIndex == 0;
		if (method_69(flag, out var uint_))
		{
			if (flag ? (uint_ <= 2047) : (uint_ <= 536870911))
			{
				method_67();
				bool stdFrame = canframeModel_0.StdFrame;
				uint cANId = canframeModel_0.CANId;
				if (flag == stdFrame && uint_ == cANId)
				{
					method_68(canframeModel_0, canframeModel_0.CANId);
					return;
				}
				canframeModel_0.StdFrame = flag;
				canframeModel_0.CANId = uint_;
				method_57(canframeModel_0, bool_6: true);
				method_47(uint_, flag);
			}
			else if (!bool_5)
			{
				method_70();
			}
		}
		else if (!bool_5)
		{
			method_71();
		}
	}

	private void themedComboBox_0_SelectionChangeCommitted(object sender, EventArgs e)
	{
		if (canframeModel_0 != null && themedComboBox_0.SelectedIndex == 0 != canframeModel_0.StdFrame)
		{
			method_74();
		}
	}

	private void themedComboBox_1_SelectionChangeCommitted(object sender, EventArgs e)
	{
		if (canframeModel_0 != null)
		{
			int selectedIndex = themedComboBox_1.SelectedIndex;
			if (selectedIndex != canframeModel_0.Length)
			{
				canframeModel_0.Length = (uint)selectedIndex;
				method_58(canframeModel_0, bool_6: true);
			}
		}
	}

	private void themedComboBox_2_SelectionChangeCommitted(object sender, EventArgs e)
	{
		if (canframeModel_0 != null)
		{
			int selectedIndex = themedComboBox_2.SelectedIndex;
			if (selectedIndex != canframeModel_0.Rate)
			{
				canframeModel_0.Rate = selectedIndex;
				method_59(canframeModel_0, bool_6: true);
			}
		}
	}

	private void class148_0_CheckStateChanged(object sender, EventArgs e)
	{
		bool enabled;
		if (!bool_2 && (enabled = class148_0.CheckState == CheckState.Checked) != canframeModel_0.Enabled)
		{
			canframeModel_0.Enabled = enabled;
			method_44(list_0);
			method_58(canframeModel_0, bool_6: true);
		}
	}

	private void method_75(object sender, EventArgs e)
	{
		HashSet<uint> hashSet = new HashSet<uint>();
		for (int num = list_0.Count - 1; num >= 0; num--)
		{
			CANFrameModel cANFrameModel = list_0[num];
			int num2 = class255_0.BZl.method_258((int)cANFrameModel.Index);
			bool flag = CANFrameModel.IsFrameEnabled((byte)num2);
			bool flag2 = CANFrameModel.IsFrameVisible((byte)num2);
			int num3 = num2 & 0x3F;
			if (flag2)
			{
				hashSet.Add(cANFrameModel.Index);
				cANFrameModel.Length = (uint)num3;
				if (cANFrameModel.Enabled != flag)
				{
					cANFrameModel.Enabled = flag;
					method_44(list_0);
				}
				if (cANFrameModel == canframeModel_0)
				{
					themedComboBox_1.SelectedIndex = num3;
					class148_0.CheckState = (flag ? CheckState.Checked : CheckState.Unchecked);
					method_2(bool_6: true, cANFrameModel);
					themedBitfieldViewer_0.UpdateSignals(cANFrameModel);
				}
			}
			else
			{
				list_0.Remove(cANFrameModel);
				if (cANFrameModel == canframeModel_0)
				{
					((cANFrameModel.FrameDirection == CANFrameModel.Direction.Transmit) ? treeViewWithThemedScrollBars_1 : treeViewWithThemedScrollBars_0).method_4(null);
					method_48();
					method_54(cANFrameModel.FrameDirection);
				}
				treeViewWithThemedScrollBars_0.method_5();
				treeViewWithThemedScrollBars_1.method_5();
				for (int i = 0; i < treeViewWithThemedScrollBars_0.method_2().Count; i++)
				{
					TreeNode treeNode = treeViewWithThemedScrollBars_0.method_2()[i];
					if (treeNode.Tag is uint num4 && num4 == cANFrameModel.Index)
					{
						treeViewWithThemedScrollBars_0.method_2().Remove(treeNode);
						break;
					}
				}
				for (int j = 0; j < treeViewWithThemedScrollBars_1.method_2().Count; j++)
				{
					TreeNode treeNode2 = treeViewWithThemedScrollBars_1.method_2()[j];
					if (treeNode2.Tag is uint num5 && num5 == cANFrameModel.Index)
					{
						treeViewWithThemedScrollBars_1.method_2().Remove(treeNode2);
						break;
					}
				}
				method_27();
				treeViewWithThemedScrollBars_0.method_6();
				treeViewWithThemedScrollBars_1.method_6();
				treeViewWithThemedScrollBars_0.Refresh();
				treeViewWithThemedScrollBars_1.Refresh();
			}
		}
		int num6 = class255_0.BZl.method_242()[2];
		for (int k = 0; k < num6; k++)
		{
			if (CANFrameModel.IsFrameVisible((byte)class255_0.BZl.method_258(k)) && !hashSet.Contains((uint)k))
			{
				CANFrameModel cANFrameModel2 = CANFrameModel.smethod_0(class255_0, (uint)k);
				cANFrameModel2.Signals = new List<CANSignalModel>();
				list_0.Add(cANFrameModel2);
				method_44(list_0);
			}
		}
		foreach (CANFrameModel item in list_0)
		{
			item.method_2();
			if (item.Signals == null)
			{
				continue;
			}
			foreach (CANSignalModel signal in item.Signals)
			{
				method_39(item, signal, bool_6: false);
			}
		}
		method_62();
		cansignalEditor_0.method_3();
	}

	private void method_76(object sender, EventArgs e)
	{
		foreach (CANFrameModel item in list_0)
		{
			string text = (item.Name = class255_0.BZk.method_261((int)item.Index));
			if (item == canframeModel_0)
			{
				themedTextBox_0.Text = text;
			}
			TreeViewWithThemedScrollBars treeViewWithThemedScrollBars = ((item.FrameDirection == CANFrameModel.Direction.Transmit) ? treeViewWithThemedScrollBars_1 : treeViewWithThemedScrollBars_0);
			foreach (TreeNode item2 in treeViewWithThemedScrollBars.method_2())
			{
				if (item2.Tag is uint num && num == item.Index && item2.Text != text + Class333.smethod_396())
				{
					treeViewWithThemedScrollBars.method_5();
					item2.Text = text + Class333.smethod_396();
					treeViewWithThemedScrollBars.method_6();
					break;
				}
			}
		}
		method_62();
		method_46(treeViewWithThemedScrollBars_0);
		method_46(treeViewWithThemedScrollBars_1);
	}

	private void method_77(object sender, EventArgs e)
	{
		if (canframeModel_0 != null)
		{
			method_66();
		}
		method_62();
	}

	private void method_78(object sender, EventArgs e)
	{
		foreach (CANFrameModel item in list_0)
		{
			int num = class255_0.BZL.method_258((int)item.Index);
			bool flag;
			uint cANId = (uint)((flag = CANFrameModel.IsFrameStdId((uint)num)) ? (num & 0x7FF) : (num & 0x1FFFFFFF));
			if (item == canframeModel_0)
			{
				string text = (flag ? Class333.smethod_380() : Class333.smethod_379());
				themedTextBox_1.Text = Class333.smethod_381() + cANId.ToString(text);
				themedComboBox_0.SelectedIndex = ((!flag) ? 1 : 0);
			}
			item.CANId = cANId;
			item.StdFrame = flag;
		}
		method_62();
	}

	private void method_79(object sender, EventArgs e)
	{
		if (canframeModel_0 != null)
		{
			method_68(canframeModel_0, canframeModel_0.CANId);
		}
		method_62();
	}

	private void method_80(object sender, EventArgs e)
	{
		foreach (CANFrameModel item in list_0)
		{
			int num = class255_0.BZM.method_258((int)item.Index);
			CANFrameModel.Direction frameDirection = (((num & 0x80) != 0) ? CANFrameModel.Direction.Transmit : CANFrameModel.Direction.Receive);
			bool oneshot = (num & 0x40) != 0;
			int selectedIndex = (item.Rate = num & 0x3F);
			item.FrameDirection = frameDirection;
			item.Oneshot = oneshot;
			if (item == canframeModel_0)
			{
				themedComboBox_2.SelectedIndex = selectedIndex;
			}
		}
		method_62();
	}

	private void method_81(object sender, EventArgs e)
	{
		if (canframeModel_0 != null && canframeModel_0.Signals != null)
		{
			cansignalEditor_0.method_4(canframeModel_0.Signals, canframeModel_0.FrameDirection);
			cansignalEditor_0.method_3();
		}
	}

	private void method_82(object sender, EventArgs e)
	{
		if (bool_2)
		{
			return;
		}
		foreach (CANFrameModel item2 in list_0)
		{
			item2.method_2();
			if (sender == class255_0.BZN && item2.Signals != null)
			{
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				for (int num = item2.Signals.Count - 1; num >= 0; num--)
				{
					CANSignalModel cANSignalModel = item2.Signals[num];
					if (cANSignalModel.Index != -1 && cANSignalModel.Int32_0 != -1)
					{
						if (class255_0.BZN.method_258(cANSignalModel.Index) == -1)
						{
							item2.Signals.Remove(cANSignalModel);
						}
						else
						{
							dictionary[cANSignalModel.Index] = cANSignalModel.Int32_0;
						}
					}
				}
				int num2 = class255_0.BZN.method_242()[2];
				for (int i = 0; i < num2; i++)
				{
					int num3 = class255_0.BZN.method_258(i);
					if (num3 != item2.Index || (dictionary.ContainsKey(i) && dictionary[i] != -1))
					{
						continue;
					}
					CANSignalModel item = new CANSignalModel
					{
						Int32_0 = num3,
						Index = i,
						Bus = int_6
					};
					if (item2.Signals.Count == 0)
					{
						item2.Signals.Add(item);
						continue;
					}
					int index = 0;
					int num4 = item2.Signals.Count - 1;
					while (num4 >= 0)
					{
						if (i <= item2.Signals[num4].Index)
						{
							num4--;
							continue;
						}
						index = num4 + 1;
						break;
					}
					item2.Signals.Insert(index, item);
				}
			}
			if (item2.Signals == null)
			{
				continue;
			}
			foreach (CANSignalModel signal in item2.Signals)
			{
				CANSignalModel.smethod_0(class255_0, framework_0, signal);
			}
		}
		foreach (CANFrameModel item3 in list_0)
		{
			item3.method_2();
			if (item3.Signals == null)
			{
				continue;
			}
			foreach (CANSignalModel signal2 in item3.Signals)
			{
				method_39(item3, signal2, bool_6: false);
			}
		}
		if (canframeModel_0 != null && canframeModel_0.Signals != null)
		{
			cansignalEditor_0.method_4(canframeModel_0.Signals, canframeModel_0.FrameDirection);
			cansignalEditor_0.method_3();
			method_14();
			themedBitfieldViewer_0.UpdateSignals(canframeModel_0);
			method_3(bool_6: true, canframeModel_0);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		method_9();
		base.Dispose(disposing);
	}

	private void method_83()
	{
		class138_0 = new Class138();
		class138_1 = new Class138();
		tableLayoutPanel_0 = new TableLayoutPanel();
		label_0 = new Label();
		themedButton_0 = new ThemedButton();
		treeViewWithThemedScrollBars_0 = new TreeViewWithThemedScrollBars();
		tableLayoutPanel_1 = new TableLayoutPanel();
		label_1 = new Label();
		themedButton_1 = new ThemedButton();
		treeViewWithThemedScrollBars_1 = new TreeViewWithThemedScrollBars();
		class148_0 = new Class148();
		label_2 = new Label();
		themedTextBox_0 = new ThemedTextBox();
		pictureBox_0 = new PictureBox();
		label_3 = new Label();
		themedComboBox_0 = new ThemedComboBox();
		label_4 = new Label();
		themedTextBox_1 = new ThemedTextBox();
		pictureBox_1 = new PictureBox();
		label_5 = new Label();
		themedComboBox_1 = new ThemedComboBox();
		label_6 = new Label();
		themedComboBox_2 = new ThemedComboBox();
		canrawDataView_0 = new CANRawDataView();
		cansignalEditor_0 = new CANSignalEditor();
		label_7 = new Label();
		themedBitfieldViewer_0 = new ThemedBitfieldViewer();
		label_8 = new Label();
		((ISupportInitialize)class138_0).BeginInit();
		class138_0.Panel1.SuspendLayout();
		class138_0.Panel2.SuspendLayout();
		class138_0.SuspendLayout();
		((ISupportInitialize)class138_1).BeginInit();
		class138_1.Panel1.SuspendLayout();
		class138_1.Panel2.SuspendLayout();
		class138_1.SuspendLayout();
		tableLayoutPanel_0.SuspendLayout();
		tableLayoutPanel_1.SuspendLayout();
		SuspendLayout();
		class138_0.Dock = DockStyle.Fill;
		class138_0.Location = new Point(0, 0);
		class138_0.Name = Class333.smethod_406();
		class138_0.Panel1.Controls.Add(class138_1);
		class138_0.Panel2.Controls.Add(class148_0);
		class138_0.Panel2.Controls.Add(label_2);
		class138_0.Panel2.Controls.Add(themedTextBox_0);
		class138_0.Panel2.Controls.Add(pictureBox_0);
		class138_0.Panel2.Controls.Add(label_3);
		class138_0.Panel2.Controls.Add(themedComboBox_0);
		class138_0.Panel2.Controls.Add(label_4);
		class138_0.Panel2.Controls.Add(themedTextBox_1);
		class138_0.Panel2.Controls.Add(pictureBox_1);
		class138_0.Panel2.Controls.Add(label_5);
		class138_0.Panel2.Controls.Add(themedComboBox_1);
		class138_0.Panel2.Controls.Add(label_6);
		class138_0.Panel2.Controls.Add(themedComboBox_2);
		class138_0.Panel2.Controls.Add(label_8);
		class138_0.Panel2.Controls.Add(canrawDataView_0);
		class138_0.Panel2.Controls.Add(cansignalEditor_0);
		class138_0.Panel2.Controls.Add(label_7);
		class138_0.Panel2.Controls.Add(themedBitfieldViewer_0);
		class138_0.Panel1MinSize = 130;
		class138_0.Panel2MinSize = 200;
		class138_0.Size = new Size(1072, 550);
		class138_0.SplitterDistance = 136;
		class138_0.TabIndex = 0;
		class138_1.Dock = DockStyle.Fill;
		class138_1.Location = new Point(0, 0);
		class138_1.Name = Class333.smethod_407();
		class138_1.Orientation = Orientation.Horizontal;
		class138_1.Panel1.Controls.Add(tableLayoutPanel_0);
		class138_1.Panel2.Controls.Add(tableLayoutPanel_1);
		class138_1.Size = new Size(136, 550);
		class138_1.SplitterDistance = 275;
		class138_1.TabIndex = 0;
		tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136f));
		tableLayoutPanel_0.Controls.Add(label_0, 0, 0);
		tableLayoutPanel_0.Controls.Add(themedButton_0, 0, 1);
		tableLayoutPanel_0.Controls.Add(treeViewWithThemedScrollBars_0, 0, 2);
		tableLayoutPanel_0.Dock = DockStyle.Fill;
		tableLayoutPanel_0.Location = new Point(0, 0);
		tableLayoutPanel_0.Name = Class333.smethod_408();
		tableLayoutPanel_0.RowCount = 3;
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 18f));
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanel_0.Size = new Size(136, 275);
		tableLayoutPanel_0.TabIndex = 0;
		label_0.AutoSize = true;
		label_0.Dock = DockStyle.Fill;
		label_0.Location = new Point(3, 0);
		label_0.Name = Class333.smethod_409();
		label_0.Size = new Size(130, 18);
		label_0.TabIndex = 0;
		label_0.Text = Class333.smethod_410();
		label_0.TextAlign = ContentAlignment.MiddleLeft;
		themedButton_0.AutoSize = true;
		themedButton_0.Dock = DockStyle.Fill;
		themedButton_0.Location = new Point(3, 18);
		themedButton_0.Margin = new Padding(3, 0, 3, 0);
		themedButton_0.Name = Class333.smethod_411();
		themedButton_0.Size = new Size(130, 25);
		themedButton_0.TabIndex = 1;
		themedButton_0.Text = Class333.smethod_412();
		themedButton_0.Click += themedButton_0_Click;
		treeViewWithThemedScrollBars_0.Dock = DockStyle.Fill;
		treeViewWithThemedScrollBars_0.Font = new Font(Class333.smethod_145(), 9f, FontStyle.Bold);
		treeViewWithThemedScrollBars_0.Location = new Point(3, 46);
		treeViewWithThemedScrollBars_0.Name = Class333.smethod_413();
		treeViewWithThemedScrollBars_0.Size = new Size(130, 226);
		treeViewWithThemedScrollBars_0.TabIndex = 2;
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136f));
		tableLayoutPanel_1.Controls.Add(label_1, 0, 0);
		tableLayoutPanel_1.Controls.Add(themedButton_1, 0, 1);
		tableLayoutPanel_1.Controls.Add(treeViewWithThemedScrollBars_1, 0, 2);
		tableLayoutPanel_1.Dock = DockStyle.Fill;
		tableLayoutPanel_1.Location = new Point(0, 0);
		tableLayoutPanel_1.Name = Class333.smethod_414();
		tableLayoutPanel_1.RowCount = 3;
		tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 18f));
		tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanel_1.Size = new Size(136, 271);
		tableLayoutPanel_1.TabIndex = 0;
		label_1.AutoSize = true;
		label_1.Dock = DockStyle.Fill;
		label_1.Location = new Point(3, 0);
		label_1.Name = Class333.smethod_415();
		label_1.Size = new Size(130, 18);
		label_1.TabIndex = 0;
		label_1.Text = Class333.smethod_416();
		label_1.TextAlign = ContentAlignment.MiddleLeft;
		themedButton_1.AutoSize = true;
		themedButton_1.Dock = DockStyle.Fill;
		themedButton_1.Location = new Point(3, 18);
		themedButton_1.Margin = new Padding(3, 0, 3, 0);
		themedButton_1.Name = Class333.smethod_417();
		themedButton_1.Size = new Size(130, 25);
		themedButton_1.TabIndex = 1;
		themedButton_1.Text = Class333.smethod_412();
		themedButton_1.Click += themedButton_1_Click;
		treeViewWithThemedScrollBars_1.Dock = DockStyle.Fill;
		treeViewWithThemedScrollBars_1.Font = new Font(Class333.smethod_145(), 9f, FontStyle.Bold);
		treeViewWithThemedScrollBars_1.Location = new Point(3, 46);
		treeViewWithThemedScrollBars_1.Name = Class333.smethod_418();
		treeViewWithThemedScrollBars_1.Size = new Size(130, 222);
		treeViewWithThemedScrollBars_1.TabIndex = 2;
		class148_0.Location = new Point(2, 3);
		class148_0.Margin = new Padding(2);
		class148_0.Name = Class333.smethod_419();
		class148_0.Size = new Size(65, 21);
		class148_0.TabIndex = 0;
		class148_0.Text = Class333.smethod_420();
		class148_0.UseVisualStyleBackColor = true;
		label_2.Location = new Point(72, 0);
		label_2.Name = Class333.smethod_421();
		label_2.Size = new Size(45, 25);
		label_2.TabIndex = 1;
		label_2.Text = Class333.smethod_304();
		label_2.TextAlign = ContentAlignment.MiddleRight;
		themedTextBox_0.Location = new Point(121, 3);
		themedTextBox_0.MaxLength = 30;
		themedTextBox_0.Name = Class333.smethod_422();
		themedTextBox_0.Size = new Size(92, 22);
		themedTextBox_0.TabIndex = 1;
		pictureBox_0.Location = new Point(216, 2);
		pictureBox_0.Margin = new Padding(1);
		pictureBox_0.Name = Class333.smethod_423();
		pictureBox_0.Size = new Size(18, 23);
		pictureBox_0.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox_0.TabIndex = 4;
		pictureBox_0.TabStop = false;
		label_3.Location = new Point(241, 0);
		label_3.Name = Class333.smethod_424();
		label_3.Size = new Size(47, 25);
		label_3.TabIndex = 2;
		label_3.Text = Class333.smethod_425();
		label_3.TextAlign = ContentAlignment.MiddleRight;
		themedComboBox_0.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_0.FormattingEnabled = true;
		themedComboBox_0.Location = new Point(290, 3);
		themedComboBox_0.Name = Class333.smethod_426();
		themedComboBox_0.Size = new Size(117, 23);
		themedComboBox_0.TabIndex = 2;
		label_4.Location = new Point(414, 0);
		label_4.Name = Class333.smethod_427();
		label_4.Size = new Size(44, 25);
		label_4.TabIndex = 3;
		label_4.Text = Class333.smethod_428();
		label_4.TextAlign = ContentAlignment.MiddleRight;
		themedTextBox_1.Location = new Point(461, 3);
		themedTextBox_1.Name = Class333.smethod_429();
		themedTextBox_1.Size = new Size(72, 22);
		themedTextBox_1.TabIndex = 3;
		pictureBox_1.Location = new Point(536, 2);
		pictureBox_1.Margin = new Padding(1);
		pictureBox_1.Name = Class333.smethod_430();
		pictureBox_1.Size = new Size(18, 23);
		pictureBox_1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox_1.TabIndex = 4;
		pictureBox_1.TabStop = false;
		label_5.Location = new Point(560, 0);
		label_5.Name = Class333.smethod_431();
		label_5.Size = new Size(82, 25);
		label_5.TabIndex = 5;
		label_5.Text = Class333.smethod_432();
		label_5.TextAlign = ContentAlignment.MiddleRight;
		themedComboBox_1.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_1.FormattingEnabled = true;
		themedComboBox_1.Location = new Point(646, 3);
		themedComboBox_1.Name = Class333.smethod_433();
		themedComboBox_1.Size = new Size(67, 23);
		themedComboBox_1.TabIndex = 5;
		label_6.Location = new Point(719, 0);
		label_6.Name = Class333.smethod_434();
		label_6.Size = new Size(83, 25);
		label_6.TabIndex = 6;
		label_6.Text = Class333.smethod_435();
		label_6.TextAlign = ContentAlignment.MiddleRight;
		themedComboBox_2.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_2.FormattingEnabled = true;
		themedComboBox_2.Location = new Point(806, 3);
		themedComboBox_2.Name = Class333.smethod_436();
		themedComboBox_2.Size = new Size(97, 23);
		themedComboBox_2.TabIndex = 6;
		canrawDataView_0.Location = new Point(73, 28);
		canrawDataView_0.Margin = new Padding(4, 3, 4, 3);
		canrawDataView_0.Name = Class333.smethod_437();
		canrawDataView_0.Size = new Size(388, 54);
		canrawDataView_0.TabIndex = 7;
		cansignalEditor_0.Location = new Point(3, 85);
		cansignalEditor_0.Name = Class333.smethod_438();
		cansignalEditor_0.Size = new Size(928, 238);
		cansignalEditor_0.TabIndex = 8;
		cansignalEditor_0.Visible = false;
		label_7.Location = new Point(3, 187);
		label_7.Name = Class333.smethod_439();
		label_7.Size = new Size(928, 30);
		label_7.TabIndex = 1;
		label_7.Text = Class333.smethod_388();
		label_7.TextAlign = ContentAlignment.MiddleCenter;
		themedBitfieldViewer_0.AutoScroll = true;
		themedBitfieldViewer_0.Font = new Font(Class333.smethod_145(), 9f);
		themedBitfieldViewer_0.Location = new Point(3, 325);
		themedBitfieldViewer_0.Name = Class333.smethod_440();
		themedBitfieldViewer_0.Size = new Size(924, 225);
		themedBitfieldViewer_0.TabIndex = 2;
		label_8.Location = new Point(3, 25);
		label_8.Name = Class333.smethod_441();
		label_8.Size = new Size(63, 60);
		label_8.TabIndex = 11;
		label_8.Text = Class333.smethod_325();
		label_8.TextAlign = ContentAlignment.MiddleRight;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(class138_0);
		Name = Class333.smethod_442();
		Size = new Size(1072, 550);
		class138_0.Panel1.ResumeLayout(performLayout: false);
		class138_0.Panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)class138_0).EndInit();
		class138_0.ResumeLayout(performLayout: false);
		class138_1.Panel1.ResumeLayout(performLayout: false);
		class138_1.Panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)class138_1).EndInit();
		class138_1.ResumeLayout(performLayout: false);
		tableLayoutPanel_0.ResumeLayout(performLayout: false);
		tableLayoutPanel_0.PerformLayout();
		tableLayoutPanel_1.ResumeLayout(performLayout: false);
		tableLayoutPanel_1.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void method_84()
	{
		if (int_4 != 0)
		{
			class138_0.SplitterDistance = int_4;
		}
		if (int_5 != 0)
		{
			class138_1.SplitterDistance = int_5;
		}
		bool_3 = false;
		treeViewWithThemedScrollBars_0.AutoScroll = true;
		treeViewWithThemedScrollBars_1.AutoScroll = true;
		treeViewWithThemedScrollBars_0.method_37();
		treeViewWithThemedScrollBars_1.method_37();
	}

	[CompilerGenerated]
	private bool method_85(CANFrameModel canframeModel_1)
	{
		if (canframeModel_1 != canframeModel_0)
		{
			return canframeModel_1.Name == themedTextBox_0.Text;
		}
		return false;
	}
}
