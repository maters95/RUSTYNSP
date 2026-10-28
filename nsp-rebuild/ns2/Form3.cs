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
using NSP;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns4;
using ns7;

namespace ns2;

internal class Form3 : Form
{
	internal class Class174
	{
		internal uint Bnr;

		internal bool BnS;

		internal byte[] Bns;

		internal DateTime[] BnT;

		internal float Bnt;

		internal uint BnU;
	}

	private enum Enum46
	{
		Bnu,
		BnV,
		Bnv
	}

	private enum Enum47
	{
		BnW,
		Bnw,
		BnX
	}

	private enum Enum48
	{
		Bnx,
		BnY
	}

	private enum Enum49
	{
		Bny,
		BnZ,
		Bnz
	}

	private struct Struct20
	{
		internal Enum49 BOA;

		internal bool BOa;
	}

	private delegate void Delegate95(object sender, ElapsedEventArgs e);

	private delegate void Delegate96(Class148 class148_0, uint uint_0, bool bool_0);

	private delegate void Delegate97(Struct20 struct20_0, DataGridViewWithThemedScrollBars dataGridViewWithThemedScrollBars_0, DataGridViewRow dataGridViewRow_0, Class174 class174_0);

	private delegate void Delegate98(uint uint_0, bool bool_0);

	private delegate void Delegate99(uint uint_0, bool bool_0);

	private static readonly string string_0 = Form23.string_3 + Class333.smethod_812();

	private static int int_0 = 0;

	private static int int_1 = 0;

	private List<ComboBoxItemTextAndValue> list_0 = new List<ComboBoxItemTextAndValue>
	{
		new ComboBoxItemTextAndValue
		{
			Value = 0,
			DisplayText = Class333.smethod_733()
		},
		new ComboBoxItemTextAndValue
		{
			Value = 1,
			DisplayText = Class333.smethod_734()
		},
		new ComboBoxItemTextAndValue
		{
			Value = 2,
			DisplayText = Class333.smethod_735()
		}
	};

	private List<ComboBoxItemTextAndValue> list_1 = new List<ComboBoxItemTextAndValue>
	{
		new ComboBoxItemTextAndValue
		{
			Value = 0,
			DisplayText = Class333.smethod_736()
		},
		new ComboBoxItemTextAndValue
		{
			Value = 1,
			DisplayText = Class333.smethod_737()
		}
	};

	private List<ComboBoxItemTextAndValue> list_2 = new List<ComboBoxItemTextAndValue>
	{
		new ComboBoxItemTextAndValue
		{
			Value = 0,
			DisplayText = Class333.smethod_736()
		},
		new ComboBoxItemTextAndValue
		{
			Value = 1,
			DisplayText = Class333.smethod_737()
		},
		new ComboBoxItemTextAndValue
		{
			Value = 2,
			DisplayText = Class333.smethod_738()
		}
	};

	private List<ComboBoxItemTextAndValue> list_3 = new List<ComboBoxItemTextAndValue>
	{
		new ComboBoxItemTextAndValue
		{
			Value = 0,
			DisplayText = Class333.smethod_739()
		},
		new ComboBoxItemTextAndValue
		{
			Value = 1,
			DisplayText = Class333.smethod_420()
		}
	};

	private Enum46 enum46_0;

	private Enum47 enum47_0;

	private Enum47 enum47_1;

	private Struct20 struct20_0 = new Struct20
	{
		BOA = Enum49.Bny,
		BOa = true
	};

	private Struct20 struct20_1 = new Struct20
	{
		BOA = Enum49.Bny,
		BOa = true
	};

	private Enum48 enum48_0 = Enum48.BnY;

	private Dictionary<uint, Class148> dictionary_0 = new Dictionary<uint, Class148>();

	private Dictionary<uint, Class148> dictionary_1 = new Dictionary<uint, Class148>();

	private Dictionary<uint, DataGridViewRow> dictionary_2 = new Dictionary<uint, DataGridViewRow>();

	private Dictionary<uint, DataGridViewRow> dictionary_3 = new Dictionary<uint, DataGridViewRow>();

	private Dictionary<uint, DataGridViewRow> dictionary_4 = new Dictionary<uint, DataGridViewRow>();

	private Dictionary<uint, DataGridViewRow> dictionary_5 = new Dictionary<uint, DataGridViewRow>();

	private Dictionary<uint, uint> dictionary_6 = new Dictionary<uint, uint>();

	private Dictionary<uint, uint> dictionary_7 = new Dictionary<uint, uint>();

	private Dictionary<uint, uint> dictionary_8 = new Dictionary<uint, uint>();

	private Dictionary<uint, uint> dictionary_9 = new Dictionary<uint, uint>();

	private TimeSpan timeSpan_0 = TimeSpan.FromMilliseconds(2000L);

	private Color color_0 = Color.LightGreen;

	private Font font_0 = new Font(Class333.smethod_740(), 10f, FontStyle.Regular);

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private int int_10;

	private int int_11;

	private System.Timers.Timer timer_0;

	private static readonly object object_0 = new object();

	private bool bool_0;

	private IContainer icontainer_0;

	private ToolStrip toolStrip_0;

	private SplitContainer splitContainer_0;

	private SplitContainer splitContainer_1;

	private TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars_0;

	private TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars_1;

	private Label label_0;

	private Label label_1;

	private TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars_2;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private DataGridViewWithThemedScrollBars dataGridViewWithThemedScrollBars_0;

	private DataGridViewWithThemedScrollBars dataGridViewWithThemedScrollBars_1;

	private ToolStripLabel toolStripLabel_0;

	private ThemedToolStripComboBox themedToolStripComboBox_0;

	private ToolStripLabel toolStripLabel_1;

	private ThemedToolStripComboBox themedToolStripComboBox_1;

	private ToolStripLabel toolStripLabel_2;

	private ThemedToolStripComboBox themedToolStripComboBox_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

	private Class61 class61_0;

	private ToolStripLabel toolStripLabel_3;

	private ThemedToolStripComboBox themedToolStripComboBox_3;

	internal Form3()
	{
		method_20();
		method_1();
		Form23.smethod_93(method_0);
		Disposed += (object? sender, EventArgs e) =>
		{
			Form23.smethod_94(method_0);
		};
		int_0 = Width;
		int_1 = Height;
		int_2 = dataGridViewWithThemedScrollBars_0.Columns.IndexOf(dataGridViewTextBoxColumn_0);
		int_3 = dataGridViewWithThemedScrollBars_0.Columns.IndexOf(dataGridViewTextBoxColumn_1);
		int_4 = dataGridViewWithThemedScrollBars_0.Columns.IndexOf(dataGridViewTextBoxColumn_2);
		int_5 = dataGridViewWithThemedScrollBars_0.Columns.IndexOf(dataGridViewTextBoxColumn_3);
		int_6 = dataGridViewWithThemedScrollBars_0.Columns.IndexOf(dataGridViewTextBoxColumn_4);
		int_7 = dataGridViewWithThemedScrollBars_1.Columns.IndexOf(dataGridViewTextBoxColumn_5);
		int_8 = dataGridViewWithThemedScrollBars_1.Columns.IndexOf(dataGridViewTextBoxColumn_6);
		int_9 = dataGridViewWithThemedScrollBars_1.Columns.IndexOf(dataGridViewTextBoxColumn_7);
		int_10 = dataGridViewWithThemedScrollBars_1.Columns.IndexOf(dataGridViewTextBoxColumn_8);
		int_11 = dataGridViewWithThemedScrollBars_1.Columns.IndexOf(dataGridViewTextBoxColumn_9);
		typeof(DataGridViewWithThemedScrollBars).InvokeMember(Class333.smethod_741(), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, dataGridViewWithThemedScrollBars_0, new object[1] { true });
		typeof(DataGridViewWithThemedScrollBars).InvokeMember(Class333.smethod_741(), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, dataGridViewWithThemedScrollBars_1, new object[1] { true });
		method_2();
		themedToolStripComboBox_3.ComboBox.DataSource = list_3;
		themedToolStripComboBox_3.ComboBox.DisplayMember = Class333.smethod_742();
		themedToolStripComboBox_3.ComboBox.ValueMember = Class333.smethod_280();
		themedToolStripComboBox_3.SelectedIndexChanged += themedToolStripComboBox_3_SelectedIndexChanged;
		themedToolStripComboBox_3.ComboBox.SelectedValue = (int)enum48_0;
		themedToolStripComboBox_0.ComboBox.DataSource = list_0;
		themedToolStripComboBox_0.ComboBox.DisplayMember = Class333.smethod_742();
		themedToolStripComboBox_0.ComboBox.ValueMember = Class333.smethod_280();
		themedToolStripComboBox_0.SelectedIndexChanged += themedToolStripComboBox_0_SelectedIndexChanged;
		themedToolStripComboBox_0.ComboBox.SelectedValue = (int)enum46_0;
		themedToolStripComboBox_1.ComboBox.DataSource = list_1;
		themedToolStripComboBox_1.ComboBox.DisplayMember = Class333.smethod_742();
		themedToolStripComboBox_1.ComboBox.ValueMember = Class333.smethod_280();
		themedToolStripComboBox_1.SelectedIndexChanged += themedToolStripComboBox_1_SelectedIndexChanged;
		themedToolStripComboBox_1.ComboBox.SelectedValue = (int)enum47_0;
		themedToolStripComboBox_2.ComboBox.DataSource = list_2;
		themedToolStripComboBox_2.ComboBox.DisplayMember = Class333.smethod_742();
		themedToolStripComboBox_2.ComboBox.ValueMember = Class333.smethod_280();
		themedToolStripComboBox_2.SelectedIndexChanged += themedToolStripComboBox_2_SelectedIndexChanged;
		themedToolStripComboBox_2.ComboBox.SelectedValue = (int)enum47_1;
		method_5();
	}

	private void method_0(object sender, EventArgs e)
	{
		method_1();
		tableLayoutPanelWithThemedScrollBars_2.method_2();
		class61_0.method_2();
		dataGridViewWithThemedScrollBars_0.method_4();
		dataGridViewWithThemedScrollBars_1.method_4();
		tableLayoutPanelWithThemedScrollBars_0.method_2();
		tableLayoutPanelWithThemedScrollBars_1.method_2();
	}

	private void method_1()
	{
		BackColor = Form23.color_10;
		ForeColor = Form23.color_12;
		toolStrip_0.BackColor = Form23.color_11;
		toolStrip_0.ForeColor = Form23.color_12;
		foreach (ToolStripItem item in toolStrip_0.Items)
		{
			if (item is ToolStripLabel)
			{
				item.BackColor = toolStrip_0.BackColor;
			}
			else if (item is ThemedToolStripComboBox)
			{
				item.BackColor = Form23.color_32;
			}
			item.ForeColor = Form23.color_12;
		}
		splitContainer_0.BackColor = BackColor;
		splitContainer_0.ForeColor = Form23.color_12;
		splitContainer_1.BackColor = BackColor;
		splitContainer_1.ForeColor = Form23.color_12;
		tableLayoutPanelWithThemedScrollBars_0.BackColor = BackColor;
		tableLayoutPanelWithThemedScrollBars_0.ForeColor = Form23.color_12;
		tableLayoutPanelWithThemedScrollBars_1.BackColor = BackColor;
		tableLayoutPanelWithThemedScrollBars_1.ForeColor = Form23.color_12;
		tableLayoutPanelWithThemedScrollBars_2.BackColor = Form23.color_10;
		tableLayoutPanelWithThemedScrollBars_2.ForeColor = Form23.color_12;
		class61_0.BackColor = Form23.color_10;
		class61_0.ForeColor = Form23.color_12;
		label_0.BackColor = BackColor;
		label_0.ForeColor = Form23.color_12;
		label_1.BackColor = BackColor;
		label_1.ForeColor = Form23.color_12;
		dataGridViewWithThemedScrollBars_0.BackgroundColor = BackColor;
		dataGridViewWithThemedScrollBars_0.ForeColor = Color.Black;
		dataGridViewWithThemedScrollBars_0.DefaultCellStyle.BackColor = Form23.color_32;
		dataGridViewWithThemedScrollBars_0.DefaultCellStyle.ForeColor = Form23.color_12;
		dataGridViewWithThemedScrollBars_1.BackgroundColor = BackColor;
		dataGridViewWithThemedScrollBars_1.ForeColor = Color.Black;
		dataGridViewWithThemedScrollBars_1.DefaultCellStyle.BackColor = Form23.color_32;
		dataGridViewWithThemedScrollBars_1.DefaultCellStyle.ForeColor = Form23.color_12;
	}

	private void method_2()
	{
		try
		{
			if (!File.Exists(string_0))
			{
				return;
			}
			using StreamReader streamReader = File.OpenText(string_0);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (text.StartsWith(Class333.smethod_743()))
				{
					Width = int.Parse(text.Substring(Class333.smethod_743().Length));
				}
				else if (text.StartsWith(Class333.smethod_744()))
				{
					Height = int.Parse(text.Substring(Class333.smethod_744().Length));
				}
				else if (text.StartsWith(Class333.smethod_745()))
				{
					splitContainer_0.SplitterDistance = int.Parse(text.Substring(Class333.smethod_745().Length));
				}
				else if (text.StartsWith(Class333.smethod_746()))
				{
					enum48_0 = (Enum48)int.Parse(text.Substring(Class333.smethod_746().Length));
				}
				else if (text.StartsWith(Class333.smethod_747()))
				{
					timeSpan_0 = TimeSpan.FromMilliseconds(int.Parse(text.Substring(Class333.smethod_747().Length)));
				}
				else if (text.StartsWith(Class333.smethod_748()))
				{
					enum46_0 = (Enum46)int.Parse(text.Substring(Class333.smethod_748().Length));
				}
				else if (text.StartsWith(Class333.smethod_749()))
				{
					enum47_0 = (Enum47)int.Parse(text.Substring(Class333.smethod_749().Length));
				}
				else if (text.StartsWith(Class333.smethod_750()))
				{
					enum47_1 = (Enum47)int.Parse(text.Substring(Class333.smethod_750().Length));
				}
				else if (text.StartsWith(Class333.smethod_751()))
				{
					struct20_0.BOA = (Enum49)int.Parse(text.Substring(Class333.smethod_751().Length));
				}
				else if (text.StartsWith(Class333.smethod_752()))
				{
					struct20_0.BOa = bool.Parse(text.Substring(Class333.smethod_752().Length));
				}
				else if (text.StartsWith(Class333.smethod_753()))
				{
					struct20_1.BOA = (Enum49)int.Parse(text.Substring(Class333.smethod_753().Length));
				}
				else if (text.StartsWith(Class333.smethod_754()))
				{
					struct20_1.BOa = bool.Parse(text.Substring(Class333.smethod_754().Length));
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_755() + ex.Message);
		}
	}

	private void method_3()
	{
		try
		{
			if (!Directory.Exists(Form23.string_3 + Class333.smethod_557()))
			{
				Directory.CreateDirectory(Form23.string_3 + Class333.smethod_557());
			}
			File.Create(string_0).Close();
			List<string> list = new List<string>();
			list.Add(Class333.smethod_743() + int_0);
			list.Add(Class333.smethod_744() + int_1);
			list.Add(Class333.smethod_745() + splitContainer_0.SplitterDistance);
			string text = Class333.smethod_746();
			int num = (int)enum48_0;
			list.Add(text + num);
			list.Add(Class333.smethod_747() + (int)timeSpan_0.TotalMilliseconds);
			string text2 = Class333.smethod_748();
			num = (int)enum46_0;
			list.Add(text2 + num);
			string text3 = Class333.smethod_749();
			num = (int)enum47_0;
			list.Add(text3 + num);
			string text4 = Class333.smethod_750();
			num = (int)enum47_1;
			list.Add(text4 + num);
			string text5 = Class333.smethod_751();
			num = (int)struct20_0.BOA;
			list.Add(text5 + num);
			list.Add(Class333.smethod_752() + struct20_0.BOa);
			string text6 = Class333.smethod_753();
			num = (int)struct20_1.BOA;
			list.Add(text6 + num);
			list.Add(Class333.smethod_754() + struct20_1.BOa);
			File.AppendAllLines(string_0, list);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_756() + ex.Message);
		}
	}

	private void Form3_Resize(object sender, EventArgs e)
	{
		if (WindowState != FormWindowState.Minimized)
		{
			int_0 = Width;
			int_1 = Height;
		}
	}

	private void Form3_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form23.framework_1.method_31(20069)?.method_272(0, bool_0: true);
		method_3();
		try
		{
			if (timer_0 != null)
			{
				timer_0.Stop();
				timer_0.Elapsed -= timer_0_Elapsed;
				timer_0.Dispose();
				timer_0 = null;
			}
			class61_0.SuspendLayout();
			foreach (Class148 value in dictionary_0.Values)
			{
				value.CheckedChanged -= method_19;
				value.Dispose();
			}
			foreach (Class148 value2 in dictionary_1.Values)
			{
				value2.CheckedChanged -= method_19;
				value2.Dispose();
			}
			class61_0.ResumeLayout(performLayout: true);
			dictionary_0.Clear();
			dictionary_1.Clear();
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_757() + ex.Message);
		}
	}

	private void method_4(Setting setting_0, Setting setting_1)
	{
		if (enum46_0 == Enum46.BnV)
		{
			setting_1.method_272(0, bool_0: true);
		}
		else if (enum46_0 == Enum46.Bnu)
		{
			setting_1.method_272(1, bool_0: true);
		}
		else if (enum46_0 == Enum46.Bnv)
		{
			setting_1.method_272(4, bool_0: true);
		}
		setting_0.method_272(2, bool_0: true);
	}

	private void themedToolStripComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_5();
	}

	private void method_5()
	{
		if (themedToolStripComboBox_0.ComboBox.SelectedValue is ComboBoxItemTextAndValue)
		{
			enum46_0 = (Enum46)((ComboBoxItemTextAndValue)themedToolStripComboBox_0.ComboBox.SelectedValue).Value;
		}
		else
		{
			if (!(themedToolStripComboBox_0.ComboBox.SelectedValue is int))
			{
				return;
			}
			enum46_0 = (Enum46)themedToolStripComboBox_0.ComboBox.SelectedValue;
		}
		Setting setting = Form23.framework_1.method_31(20069);
		Setting setting2 = Form23.framework_1.method_31(20070);
		if (setting == null || setting2 == null)
		{
			return;
		}
		Monitor.Enter(object_0);
		if (timer_0 != null)
		{
			timer_0.Elapsed -= timer_0_Elapsed;
			timer_0.Stop();
			timer_0.Enabled = false;
		}
		setting.method_272(0, bool_0: true);
		Thread.Sleep(50);
		method_4(setting, setting2);
		Thread.Sleep(50);
		class61_0.SuspendLayout();
		foreach (Class148 value in dictionary_0.Values)
		{
			value.CheckedChanged -= method_19;
			value.Dispose();
		}
		foreach (Class148 value2 in dictionary_1.Values)
		{
			value2.CheckedChanged -= method_19;
			value2.Dispose();
		}
		class61_0.ResumeLayout(performLayout: true);
		dictionary_0.Clear();
		dictionary_1.Clear();
		dictionary_6.Clear();
		dictionary_7.Clear();
		dictionary_8.Clear();
		dictionary_9.Clear();
		dictionary_2.Clear();
		dictionary_3.Clear();
		dictionary_4.Clear();
		dictionary_5.Clear();
		dataGridViewWithThemedScrollBars_0.Rows.Clear();
		dataGridViewWithThemedScrollBars_1.Rows.Clear();
		dataGridViewWithThemedScrollBars_0.Refresh();
		dataGridViewWithThemedScrollBars_1.Refresh();
		Monitor.Exit(object_0);
		if (timer_0 == null)
		{
			timer_0 = new System.Timers.Timer(60.0);
		}
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.AutoReset = false;
		timer_0.Enabled = true;
		timer_0.Start();
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate95 method = timer_0_Elapsed;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(object_0, ref lockTaken);
			if (!lockTaken)
			{
				return;
			}
			if (timer_0 != null)
			{
				timer_0.Stop();
				timer_0.Enabled = false;
			}
			Class5 @class = Class1.smethod_26(Form23.framework_1.aXc);
			if (@class == null || Form23.smethod_27())
			{
				return;
			}
			Setting setting = Form23.framework_1.method_31(20069);
			Setting setting2 = Form23.framework_1.method_31(20070);
			if (setting != null && setting2 != null && setting.method_256() != 2)
			{
				method_4(setting, setting2);
			}
			uint uint_ = @class.struct1_0[34].uint_1;
			if (Class1.smethod_37(Form23.framework_1.aXc, Enum10.const_6, 0u, uint_, out var byte_, out var _))
			{
				class61_0.SuspendLayout();
				bool flag = false;
				for (uint num = 0u; num < uint_; num += 16)
				{
					bool flag2 = true;
					if (byte_[num] != 0 && byte_[num] != byte.MaxValue)
					{
						flag2 = false;
					}
					else
					{
						for (int i = 1; i < 16L; i++)
						{
							if (byte_[num + i] != byte_[num])
							{
								flag2 = false;
								break;
							}
						}
					}
					if (flag2)
					{
						continue;
					}
					uint num2 = (uint)((byte_[num + 3] << 24) | ((byte_[num + 2] << 16) & 0xFF0000) | ((byte_[num + 1] << 8) & 0xFF00) | (byte_[num] & 0xFF));
					byte b = byte_[num + 4];
					bool flag3 = (b & 0x80) == 0;
					bool flag4 = (b & 0x40) == 0;
					byte b2 = (byte)(b & 0xF);
					uint num3 = (uint)(((byte_[num + 7] << 16) & 0xFF0000) | ((byte_[num + 6] << 8) & 0xFF00) | (byte_[num + 5] & 0xFF));
					byte[] array = new byte[b2];
					Array.Copy(byte_, num + 8, array, 0L, b2);
					DataGridViewRow value = null;
					Class174 class2 = null;
					Dictionary<uint, DataGridViewRow> dictionary;
					if (flag4)
					{
						dictionary = (flag3 ? dictionary_2 : dictionary_3);
					}
					else
					{
						dictionary = (flag3 ? dictionary_4 : dictionary_5);
					}
					if (dictionary.TryGetValue(num2, out value))
					{
						class2 = value.Tag as Class174;
						class2.BnS = flag3;
					}
					else
					{
						value = null;
					}
					if (value == null)
					{
						class2 = new Class174();
						class2.Bnr = num2;
						class2.BnS = flag3;
						value = new DataGridViewRow();
						value.Tag = class2;
						if (flag4)
						{
							method_7(struct20_0, dataGridViewWithThemedScrollBars_0, value, class2);
							if (flag3)
							{
								dictionary_2[num2] = value;
							}
							else
							{
								dictionary_3[num2] = value;
							}
						}
						else
						{
							method_7(struct20_1, dataGridViewWithThemedScrollBars_1, value, class2);
							if (flag3)
							{
								dictionary_4[num2] = value;
							}
							else
							{
								dictionary_5[num2] = value;
							}
						}
						flag = true;
						if ((flag3 && !dictionary_0.ContainsKey(num2)) || (!flag3 && !dictionary_1.ContainsKey(num2)))
						{
							Class148 class3 = new Class148();
							class3.Tag = (flag3 ? num2 : (num2 | 0x80000000u));
							class3.Text = Class333.smethod_758() + method_8(num2, flag3);
							if (enum47_0 == Enum47.Bnw)
							{
								class3.Text += (flag3 ? Class333.smethod_760() : Class333.smethod_759());
							}
							class3.AutoSize = true;
							class3.Checked = true;
							class3.CheckedChanged += method_19;
							if (flag3)
							{
								dictionary_0[num2] = class3;
							}
							else
							{
								dictionary_1[num2] = class3;
							}
							method_6(class3, num2, flag3);
						}
					}
					Dictionary<uint, uint> dictionary2;
					if (flag4)
					{
						dictionary2 = (flag3 ? dictionary_6 : dictionary_7);
					}
					else
					{
						dictionary2 = (flag3 ? dictionary_8 : dictionary_9);
					}
					bool flag5;
					if (dictionary2.ContainsKey(num2))
					{
						uint num4 = (num3 - dictionary2[num2]) & 0xFFFFFF;
						if (flag5 = num4 != 0 && num4 < 8388608)
						{
							class2.Bnt = (float)num4 / 1000f;
						}
					}
					else
					{
						flag5 = true;
					}
					if (!flag5)
					{
						continue;
					}
					class2.BnU++;
					DateTime now = DateTime.Now;
					if (class2.BnT == null || class2.Bns == null || class2.Bns.Length != array.Length)
					{
						class2.BnT = new DateTime[array.Length];
					}
					if (class2.Bns == null)
					{
						class2.Bns = array;
					}
					else if (class2.Bns.Length != array.Length)
					{
						class2.Bns = array;
						for (int j = 0; j < array.Length; j++)
						{
							class2.BnT[j] = now;
						}
					}
					else
					{
						for (int k = 0; k < array.Length; k++)
						{
							if (class2.Bns[k] != array[k])
							{
								class2.Bns[k] = array[k];
								class2.BnT[k] = now;
							}
						}
					}
					dictionary2[num2] = num3;
				}
				class61_0.ResumeLayout(performLayout: true);
				foreach (uint key in dictionary_2.Keys)
				{
					method_12(key, bool_1: true);
				}
				foreach (uint key2 in dictionary_3.Keys)
				{
					method_12(key2, bool_1: false);
				}
				foreach (uint key3 in dictionary_4.Keys)
				{
					method_13(key3, bool_1: true);
				}
				foreach (uint key4 in dictionary_5.Keys)
				{
					method_13(key4, bool_1: false);
				}
				if (flag)
				{
					dataGridViewWithThemedScrollBars_0.method_4();
					dataGridViewWithThemedScrollBars_1.method_4();
				}
			}
			else
			{
				Class23.smethod_3(Class333.smethod_761());
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_762() + ex.Message);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(object_0);
				if (timer_0 != null)
				{
					timer_0.Enabled = true;
					timer_0.Start();
				}
			}
		}
	}

	private void method_6(Class148 class148_0, uint uint_0, bool bool_1)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate96 method = method_6;
				BeginInvoke(method, class148_0, uint_0, bool_1);
				return;
			}
			catch
			{
				return;
			}
		}
		if (class61_0.Controls.Count == 0)
		{
			class61_0.Controls.Add(class148_0);
			return;
		}
		int num = 0;
		while (true)
		{
			if (num < class61_0.Controls.Count)
			{
				uint num2 = (uint)class61_0.Controls[num].Tag & 0x7FFFFFFF;
				if (uint_0 < num2 || ((uint_0 == num2) & bool_1))
				{
					break;
				}
				if (num != class61_0.Controls.Count - 1)
				{
					num++;
					continue;
				}
				class61_0.Controls.Add(class148_0);
				return;
			}
			return;
		}
		class61_0.Controls.Add(class148_0);
		class61_0.Controls.SetChildIndex(class148_0, num);
	}

	private void method_7(Struct20 struct20_2, DataGridViewWithThemedScrollBars dataGridViewWithThemedScrollBars_2, DataGridViewRow dataGridViewRow_0, Class174 class174_0)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate97 method = method_7;
				Invoke(method, struct20_2, dataGridViewWithThemedScrollBars_2, dataGridViewRow_0, class174_0);
				return;
			}
			catch
			{
				return;
			}
		}
		if (dataGridViewWithThemedScrollBars_2.Rows.Count == 0)
		{
			dataGridViewWithThemedScrollBars_2.Rows.Add(dataGridViewRow_0);
			return;
		}
		if (struct20_2.BOa)
		{
			int num = 0;
			while (true)
			{
				if (num < dataGridViewWithThemedScrollBars_2.Rows.Count)
				{
					if (!smethod_0(struct20_2, class174_0, dataGridViewWithThemedScrollBars_2.Rows[num].Tag as Class174))
					{
						if (num == dataGridViewWithThemedScrollBars_2.Rows.Count - 1)
						{
							break;
						}
						num++;
						continue;
					}
					dataGridViewWithThemedScrollBars_2.Rows.Insert(num, dataGridViewRow_0);
					return;
				}
				return;
			}
			dataGridViewWithThemedScrollBars_2.Rows.Add(dataGridViewRow_0);
			return;
		}
		int num2 = dataGridViewWithThemedScrollBars_2.Rows.Count - 1;
		while (true)
		{
			if (num2 >= 0)
			{
				if (smethod_0(struct20_2, class174_0, dataGridViewWithThemedScrollBars_2.Rows[num2].Tag as Class174))
				{
					break;
				}
				if (num2 == 0)
				{
					dataGridViewWithThemedScrollBars_2.Rows.Insert(0, dataGridViewRow_0);
				}
				num2--;
				continue;
			}
			return;
		}
		if (num2 == dataGridViewWithThemedScrollBars_2.Rows.Count - 1)
		{
			dataGridViewWithThemedScrollBars_2.Rows.Add(dataGridViewRow_0);
		}
		else
		{
			dataGridViewWithThemedScrollBars_2.Rows.Insert(num2 + 1, dataGridViewRow_0);
		}
	}

	private string method_8(uint uint_0, bool bool_1)
	{
		if (enum47_0 == Enum47.BnW)
		{
			return Class333.smethod_381() + uint_0.ToString(bool_1 ? Class333.smethod_380() : Class333.smethod_379());
		}
		return uint_0.ToString();
	}

	private string method_9(bool bool_1)
	{
		if (!bool_1)
		{
			return Class333.smethod_763();
		}
		return Class333.smethod_764();
	}

	private string method_10(byte[] byte_0)
	{
		string text = string.Empty;
		if (byte_0 != null)
		{
			for (int i = 0; i < byte_0.Length; i++)
			{
				if (enum47_1 == Enum47.Bnw)
				{
					if (byte_0[i] < 10)
					{
						text += Class333.smethod_665();
					}
					else if (byte_0[i] < 100)
					{
						text += Class333.smethod_325();
					}
					text += byte_0[i];
				}
				else if (enum47_1 == Enum47.BnW)
				{
					text += byte_0[i].ToString(Class333.smethod_103());
				}
				else if (enum47_1 == Enum47.BnX)
				{
					text += (char)byte_0[i];
				}
				if (i != byte_0.Length - 1 && enum47_1 != Enum47.BnX)
				{
					text += Class333.smethod_325();
				}
			}
		}
		return text;
	}

	private string method_11(float float_0)
	{
		if (float_0 != 0f)
		{
			string text = Class333.smethod_765() + (1000f / float_0).ToString(Class333.smethod_766()) + Class333.smethod_767();
			return float_0.ToString((float_0 < 0.1f) ? Class333.smethod_768() : Class333.smethod_766()) + Class333.smethod_769() + text;
		}
		return string.Empty;
	}

	private void method_12(uint uint_0, bool bool_1)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate98 method = method_12;
				BeginInvoke(method, uint_0, bool_1);
				return;
			}
			catch
			{
				return;
			}
		}
		if ((!bool_1 || dictionary_2.ContainsKey(uint_0)) && (bool_1 || dictionary_3.ContainsKey(uint_0)))
		{
			DataGridViewRow dataGridViewRow = (bool_1 ? dictionary_2[uint_0] : dictionary_3[uint_0]);
			if (dataGridViewRow.Index >= 0)
			{
				Class174 @class = dataGridViewRow.Tag as Class174;
				dataGridViewRow.Cells[int_2].Value = method_8(@class.Bnr, @class.BnS);
				dataGridViewRow.Cells[int_3].Value = method_9(@class.BnS);
				dataGridViewRow.Cells[int_4].Value = method_10(@class.Bns);
				dataGridViewRow.Cells[int_4].Style.Font = font_0;
				dataGridViewRow.Cells[int_5].Value = method_11(@class.Bnt);
				dataGridViewRow.Cells[int_6].Value = @class.BnU.ToString();
				dataGridViewWithThemedScrollBars_0.InvalidateRow(dataGridViewRow.Index);
			}
		}
	}

	private void method_13(uint uint_0, bool bool_1)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate99 method = method_13;
				BeginInvoke(method, uint_0, bool_1);
				return;
			}
			catch
			{
				return;
			}
		}
		if ((!bool_1 || dictionary_4.ContainsKey(uint_0)) && (bool_1 || dictionary_5.ContainsKey(uint_0)))
		{
			DataGridViewRow dataGridViewRow = (bool_1 ? dictionary_4[uint_0] : dictionary_5[uint_0]);
			if (dataGridViewRow.Index >= 0)
			{
				Class174 @class = dataGridViewRow.Tag as Class174;
				dataGridViewRow.Cells[int_7].Value = method_8(@class.Bnr, @class.BnS);
				dataGridViewRow.Cells[int_8].Value = method_9(@class.BnS);
				dataGridViewRow.Cells[int_9].Value = method_10(@class.Bns);
				dataGridViewRow.Cells[int_9].Style.Font = font_0;
				dataGridViewRow.Cells[int_10].Value = method_11(@class.Bnt);
				dataGridViewRow.Cells[int_11].Value = @class.BnU.ToString();
				dataGridViewWithThemedScrollBars_1.InvalidateRow(dataGridViewRow.Index);
			}
		}
	}

	private void dataGridViewWithThemedScrollBars_0_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			Class174 @class = dataGridViewWithThemedScrollBars_0.Rows[e.RowIndex].Tag as Class174;
			if (e.ColumnIndex == int_2)
			{
				e.Value = method_8(@class.Bnr, @class.BnS);
			}
			else if (e.ColumnIndex == int_3)
			{
				e.Value = method_9(@class.BnS);
			}
			else if (e.ColumnIndex == int_4)
			{
				e.Value = method_10(@class.Bns);
			}
			else if (e.ColumnIndex == int_5)
			{
				e.Value = method_11(@class.Bnt);
			}
			else if (e.ColumnIndex == int_6)
			{
				e.Value = @class.BnU.ToString();
			}
		}
	}

	private void dataGridViewWithThemedScrollBars_1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			Class174 @class = dataGridViewWithThemedScrollBars_1.Rows[e.RowIndex].Tag as Class174;
			if (e.ColumnIndex == int_7)
			{
				e.Value = method_8(@class.Bnr, @class.BnS);
			}
			else if (e.ColumnIndex == int_8)
			{
				e.Value = method_9(@class.BnS);
			}
			else if (e.ColumnIndex == int_9)
			{
				e.Value = method_10(@class.Bns);
			}
			else if (e.ColumnIndex == int_10)
			{
				e.Value = method_11(@class.Bnt);
			}
			else if (e.ColumnIndex == int_11)
			{
				e.Value = @class.BnU.ToString();
			}
		}
	}

	private void dataGridViewWithThemedScrollBars_0_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		if (e.ColumnIndex == int_4 && e.RowIndex >= 0)
		{
			method_16(dataGridViewWithThemedScrollBars_0.Rows[e.RowIndex], int_4, e);
			e.Handled = true;
		}
		else if (e.RowIndex == -1 && method_14(e, struct20_0, int_2, int_6, int_5))
		{
			e.Handled = true;
		}
	}

	private void dataGridViewWithThemedScrollBars_1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		if (e.ColumnIndex == int_9 && e.RowIndex >= 0)
		{
			method_16(dataGridViewWithThemedScrollBars_1.Rows[e.RowIndex], int_9, e);
			e.Handled = true;
		}
		else if (e.RowIndex == -1 && method_14(e, struct20_1, int_7, int_11, int_10))
		{
			e.Handled = true;
		}
	}

	private bool method_14(DataGridViewCellPaintingEventArgs dataGridViewCellPaintingEventArgs_0, Struct20 struct20_2, int int_12, int int_13, int int_14)
	{
		bool result = false;
		if ((dataGridViewCellPaintingEventArgs_0.ColumnIndex == int_12 && struct20_2.BOA == Enum49.Bny) || (dataGridViewCellPaintingEventArgs_0.ColumnIndex == int_13 && struct20_2.BOA == Enum49.BnZ) || (dataGridViewCellPaintingEventArgs_0.ColumnIndex == int_14 && struct20_2.BOA == Enum49.Bnz))
		{
			bool bool_ = !struct20_2.BOa;
			method_15(dataGridViewCellPaintingEventArgs_0, bool_);
			result = true;
		}
		return result;
	}

	private void method_15(DataGridViewCellPaintingEventArgs dataGridViewCellPaintingEventArgs_0, bool bool_1)
	{
		dataGridViewCellPaintingEventArgs_0.PaintBackground(dataGridViewCellPaintingEventArgs_0.CellBounds, cellsPaintSelectionBackground: true);
		dataGridViewCellPaintingEventArgs_0.PaintContent(dataGridViewCellPaintingEventArgs_0.CellBounds);
		dataGridViewCellPaintingEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		int num = (dataGridViewCellPaintingEventArgs_0.CellBounds.Left + dataGridViewCellPaintingEventArgs_0.CellBounds.Right) / 2;
		int x = num - 5;
		int num2 = num + 5;
		int num3 = dataGridViewCellPaintingEventArgs_0.CellBounds.Top + 1;
		int num4 = dataGridViewCellPaintingEventArgs_0.CellBounds.Top + 6;
		using Pen pen = new Pen(Brushes.Black, 2f);
		if (bool_1)
		{
			dataGridViewCellPaintingEventArgs_0.Graphics.DrawLine(pen, num, num4, x, num3);
			dataGridViewCellPaintingEventArgs_0.Graphics.DrawLine(pen, num - 1, num4, num2 - 1, num3);
		}
		else
		{
			dataGridViewCellPaintingEventArgs_0.Graphics.DrawLine(pen, num, num3, x, num4);
			dataGridViewCellPaintingEventArgs_0.Graphics.DrawLine(pen, num - 1, num3, num2 - 1, num4);
		}
	}

	private void method_16(DataGridViewRow dataGridViewRow_0, int int_12, DataGridViewCellPaintingEventArgs dataGridViewCellPaintingEventArgs_0)
	{
		dataGridViewCellPaintingEventArgs_0.PaintBackground(dataGridViewCellPaintingEventArgs_0.CellBounds, cellsPaintSelectionBackground: true);
		Class174 @class = dataGridViewRow_0.Tag as Class174;
		DataGridViewCell dataGridViewCell = dataGridViewRow_0.Cells[int_12];
		if (@class.Bns == null)
		{
			return;
		}
		int width = TextRenderer.MeasureText(Class333.smethod_325(), font_0, new Size(0, 0), TextFormatFlags.NoPrefix | TextFormatFlags.NoPadding).Width;
		int num = dataGridViewCellPaintingEventArgs_0.CellBounds.Left + 6;
		for (int i = 0; i < @class.Bns.Length; i++)
		{
			byte b = @class.Bns[i];
			string text = string.Empty;
			if (enum47_1 == Enum47.Bnw)
			{
				if (b < 10)
				{
					text = Class333.smethod_665();
				}
				else if (b < 100)
				{
					text = Class333.smethod_325();
				}
				text += b;
			}
			else if (enum47_1 == Enum47.BnW)
			{
				text = b.ToString(Class333.smethod_103());
			}
			else if (enum47_1 == Enum47.BnX)
			{
				char c = (char)b;
				text = c.ToString();
			}
			Point pt = new Point(num, dataGridViewCellPaintingEventArgs_0.CellBounds.Top + dataGridViewCellPaintingEventArgs_0.CellBounds.Height / 2);
			Color transparent;
			Color foreColor;
			if (enum48_0 == Enum48.BnY && @class.BnT != null && @class.BnT.Length == @class.Bns.Length && DateTime.Now - @class.BnT[i] < timeSpan_0)
			{
				transparent = color_0;
				foreColor = Color.Black;
			}
			else
			{
				transparent = Color.Transparent;
				foreColor = (dataGridViewCell.Selected ? Color.White : Form23.color_12);
			}
			TextRenderer.DrawText(dataGridViewCellPaintingEventArgs_0.Graphics, text, font_0, pt, foreColor, transparent, TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
			num += TextRenderer.MeasureText(text, font_0, new Size(0, 0), TextFormatFlags.NoPrefix | TextFormatFlags.NoPadding).Width;
			if (i != @class.Bns.Length - 1 && enum47_1 != Enum47.BnX)
			{
				pt.X = num;
				TextRenderer.DrawText(dataGridViewCellPaintingEventArgs_0.Graphics, Class333.smethod_325(), font_0, pt, foreColor, Color.Transparent, TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
				num += width;
			}
		}
	}

	private void themedToolStripComboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (themedToolStripComboBox_1.ComboBox.SelectedValue is ComboBoxItemTextAndValue)
		{
			enum47_0 = (Enum47)((ComboBoxItemTextAndValue)themedToolStripComboBox_1.ComboBox.SelectedValue).Value;
		}
		else
		{
			if (!(themedToolStripComboBox_1.ComboBox.SelectedValue is int))
			{
				return;
			}
			enum47_0 = (Enum47)themedToolStripComboBox_1.ComboBox.SelectedValue;
		}
		dataGridViewWithThemedScrollBars_0.Refresh();
		dataGridViewWithThemedScrollBars_1.Refresh();
		foreach (Class148 value in dictionary_0.Values)
		{
			uint uint_ = (uint)value.Tag & 0x7FFFFFFF;
			value.Text = Class333.smethod_758() + method_8(uint_, bool_1: true);
			if (enum47_0 == Enum47.Bnw)
			{
				value.Text += Class333.smethod_760();
			}
		}
		foreach (Class148 value2 in dictionary_1.Values)
		{
			uint uint_2 = (uint)value2.Tag & 0x7FFFFFFF;
			value2.Text = Class333.smethod_758() + method_8(uint_2, bool_1: false);
			if (enum47_0 == Enum47.Bnw)
			{
				value2.Text += Class333.smethod_759();
			}
		}
	}

	private void themedToolStripComboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (themedToolStripComboBox_2.ComboBox.SelectedValue is ComboBoxItemTextAndValue)
		{
			enum47_1 = (Enum47)((ComboBoxItemTextAndValue)themedToolStripComboBox_2.ComboBox.SelectedValue).Value;
		}
		else
		{
			if (!(themedToolStripComboBox_2.ComboBox.SelectedValue is int))
			{
				return;
			}
			enum47_1 = (Enum47)themedToolStripComboBox_2.ComboBox.SelectedValue;
		}
		dataGridViewWithThemedScrollBars_0.Refresh();
		dataGridViewWithThemedScrollBars_1.Refresh();
		if (enum47_1 == Enum47.Bnw)
		{
			dataGridViewTextBoxColumn_2.Width = 262;
			dataGridViewTextBoxColumn_7.Width = 262;
		}
		else
		{
			dataGridViewTextBoxColumn_2.Width = 200;
			dataGridViewTextBoxColumn_7.Width = 200;
		}
	}

	private void themedToolStripComboBox_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (themedToolStripComboBox_3.ComboBox.SelectedValue is ComboBoxItemTextAndValue)
		{
			enum48_0 = (Enum48)((ComboBoxItemTextAndValue)themedToolStripComboBox_3.ComboBox.SelectedValue).Value;
		}
		else
		{
			if (!(themedToolStripComboBox_3.ComboBox.SelectedValue is int))
			{
				return;
			}
			enum48_0 = (Enum48)themedToolStripComboBox_3.ComboBox.SelectedValue;
		}
		dataGridViewWithThemedScrollBars_0.Refresh();
		dataGridViewWithThemedScrollBars_1.Refresh();
	}

	private bool method_17(Struct20 struct20_2, int int_12, int int_13, int int_14, int int_15, out Struct20 struct20_3)
	{
		struct20_3 = struct20_2;
		if (int_12 == int_13)
		{
			if (struct20_2.BOA == Enum49.Bny)
			{
				struct20_3.BOa = !struct20_2.BOa;
			}
			else
			{
				struct20_3 = new Struct20
				{
					BOA = Enum49.Bny,
					BOa = true
				};
			}
			return true;
		}
		if (int_12 == int_14)
		{
			if (struct20_2.BOA == Enum49.BnZ)
			{
				struct20_3.BOa = !struct20_2.BOa;
			}
			else
			{
				struct20_3 = new Struct20
				{
					BOA = Enum49.BnZ,
					BOa = false
				};
			}
			return true;
		}
		if (int_12 == int_15)
		{
			if (struct20_2.BOA == Enum49.Bnz)
			{
				struct20_3.BOa = !struct20_2.BOa;
			}
			else
			{
				struct20_3 = new Struct20
				{
					BOA = Enum49.Bnz,
					BOa = true
				};
			}
			return true;
		}
		return false;
	}

	private void dataGridViewWithThemedScrollBars_0_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (method_17(struct20_0, e.ColumnIndex, int_2, int_6, int_5, out var struct20_))
		{
			struct20_0 = struct20_;
			method_18(struct20_0, dataGridViewWithThemedScrollBars_0, dictionary_2, dictionary_3);
		}
	}

	private void dataGridViewWithThemedScrollBars_1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (method_17(struct20_1, e.ColumnIndex, int_7, int_11, int_10, out var struct20_))
		{
			struct20_1 = struct20_;
			method_18(struct20_1, dataGridViewWithThemedScrollBars_1, dictionary_4, dictionary_5);
		}
	}

	private void method_18(Struct20 struct20_2, DataGridViewWithThemedScrollBars dataGridViewWithThemedScrollBars_2, Dictionary<uint, DataGridViewRow> dictionary_10, Dictionary<uint, DataGridViewRow> dictionary_11)
	{
		uint num = uint.MaxValue;
		bool flag = true;
		int num2 = -1;
		if (dataGridViewWithThemedScrollBars_2.SelectedCells.Count != 0)
		{
			Class174 obj = dataGridViewWithThemedScrollBars_2.SelectedCells[0].OwningRow.Tag as Class174;
			num = obj.Bnr;
			flag = obj.BnS;
			num2 = dataGridViewWithThemedScrollBars_2.SelectedCells[0].ColumnIndex;
		}
		dataGridViewWithThemedScrollBars_2.SuspendLayout();
		dataGridViewWithThemedScrollBars_2.Rows.Clear();
		foreach (KeyValuePair<uint, DataGridViewRow> item in dictionary_10)
		{
			_ = item.Key;
			DataGridViewRow value = item.Value;
			Class174 class174_ = value.Tag as Class174;
			method_7(struct20_2, dataGridViewWithThemedScrollBars_2, value, class174_);
		}
		foreach (KeyValuePair<uint, DataGridViewRow> item2 in dictionary_11)
		{
			_ = item2.Key;
			DataGridViewRow value2 = item2.Value;
			Class174 class174_2 = value2.Tag as Class174;
			method_7(struct20_2, dataGridViewWithThemedScrollBars_2, value2, class174_2);
		}
		dataGridViewWithThemedScrollBars_2.ResumeLayout(performLayout: true);
		dataGridViewWithThemedScrollBars_2.Refresh();
		if (num == uint.MaxValue || num2 == -1)
		{
			return;
		}
		foreach (DataGridViewCell selectedCell in dataGridViewWithThemedScrollBars_2.SelectedCells)
		{
			selectedCell.Selected = false;
		}
		if (flag)
		{
			if (dictionary_10.ContainsKey(num))
			{
				dictionary_10[num].Cells[num2].Selected = true;
			}
		}
		else if (dictionary_11.ContainsKey(num))
		{
			dictionary_11[num].Cells[num2].Selected = true;
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		Class148 @class = sender as Class148;
		bool flag = ((uint)@class.Tag & 0x80000000u) == 0;
		uint key = (uint)@class.Tag & 0x7FFFFFFF;
		if (flag)
		{
			if (dictionary_2.ContainsKey(key))
			{
				int num = dataGridViewWithThemedScrollBars_0.Rows.IndexOf(dictionary_2[key]);
				if (num != -1)
				{
					dataGridViewWithThemedScrollBars_0.Rows[num].Visible = @class.Checked;
				}
			}
		}
		else if (dictionary_3.ContainsKey(key))
		{
			int num2 = dataGridViewWithThemedScrollBars_0.Rows.IndexOf(dictionary_3[key]);
			if (num2 != -1)
			{
				dataGridViewWithThemedScrollBars_0.Rows[num2].Visible = @class.Checked;
			}
		}
		if (flag)
		{
			if (dictionary_4.ContainsKey(key))
			{
				int num3 = dataGridViewWithThemedScrollBars_1.Rows.IndexOf(dictionary_4[key]);
				if (num3 != -1)
				{
					dataGridViewWithThemedScrollBars_1.Rows[num3].Visible = @class.Checked;
				}
			}
		}
		else if (dictionary_5.ContainsKey(key))
		{
			int num4 = dataGridViewWithThemedScrollBars_1.Rows.IndexOf(dictionary_5[key]);
			if (num4 != -1)
			{
				dataGridViewWithThemedScrollBars_1.Rows[num4].Visible = @class.Checked;
			}
		}
		if (!bool_0)
		{
			dataGridViewWithThemedScrollBars_0.method_4();
			dataGridViewWithThemedScrollBars_1.method_4();
			dataGridViewWithThemedScrollBars_0.Refresh();
			dataGridViewWithThemedScrollBars_1.Refresh();
		}
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		bool_0 = true;
		foreach (Class148 value in dictionary_0.Values)
		{
			value.Checked = true;
		}
		foreach (Class148 value2 in dictionary_1.Values)
		{
			value2.Checked = true;
		}
		bool_0 = false;
		dataGridViewWithThemedScrollBars_0.method_4();
		dataGridViewWithThemedScrollBars_1.method_4();
		dataGridViewWithThemedScrollBars_0.Refresh();
		dataGridViewWithThemedScrollBars_1.Refresh();
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		bool_0 = true;
		foreach (Class148 value in dictionary_0.Values)
		{
			value.Checked = false;
		}
		foreach (Class148 value2 in dictionary_1.Values)
		{
			value2.Checked = false;
		}
		bool_0 = false;
		dataGridViewWithThemedScrollBars_0.method_4();
		dataGridViewWithThemedScrollBars_1.method_4();
		dataGridViewWithThemedScrollBars_0.Refresh();
		dataGridViewWithThemedScrollBars_1.Refresh();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_20()
	{
		toolStrip_0 = new ToolStrip();
		toolStripLabel_0 = new ToolStripLabel();
		themedToolStripComboBox_0 = new ThemedToolStripComboBox();
		toolStripLabel_1 = new ToolStripLabel();
		themedToolStripComboBox_1 = new ThemedToolStripComboBox();
		toolStripLabel_2 = new ToolStripLabel();
		themedToolStripComboBox_2 = new ThemedToolStripComboBox();
		toolStripLabel_3 = new ToolStripLabel();
		themedToolStripComboBox_3 = new ThemedToolStripComboBox();
		splitContainer_0 = new SplitContainer();
		tableLayoutPanelWithThemedScrollBars_2 = new TableLayoutPanelWithThemedScrollBars();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		class61_0 = new Class61();
		splitContainer_1 = new SplitContainer();
		tableLayoutPanelWithThemedScrollBars_0 = new TableLayoutPanelWithThemedScrollBars();
		label_0 = new Label();
		dataGridViewWithThemedScrollBars_0 = new DataGridViewWithThemedScrollBars();
		dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		tableLayoutPanelWithThemedScrollBars_1 = new TableLayoutPanelWithThemedScrollBars();
		label_1 = new Label();
		dataGridViewWithThemedScrollBars_1 = new DataGridViewWithThemedScrollBars();
		dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
		toolStrip_0.SuspendLayout();
		((ISupportInitialize)splitContainer_0).BeginInit();
		splitContainer_0.Panel1.SuspendLayout();
		splitContainer_0.Panel2.SuspendLayout();
		splitContainer_0.SuspendLayout();
		tableLayoutPanelWithThemedScrollBars_2.SuspendLayout();
		((ISupportInitialize)splitContainer_1).BeginInit();
		splitContainer_1.Panel1.SuspendLayout();
		splitContainer_1.Panel2.SuspendLayout();
		splitContainer_1.SuspendLayout();
		tableLayoutPanelWithThemedScrollBars_0.SuspendLayout();
		((ISupportInitialize)dataGridViewWithThemedScrollBars_0).BeginInit();
		tableLayoutPanelWithThemedScrollBars_1.SuspendLayout();
		((ISupportInitialize)dataGridViewWithThemedScrollBars_1).BeginInit();
		SuspendLayout();
		toolStrip_0.AllowMerge = false;
		toolStrip_0.AutoSize = false;
		toolStrip_0.Items.AddRange(toolStripLabel_0, themedToolStripComboBox_0, toolStripLabel_1, themedToolStripComboBox_1, toolStripLabel_2, themedToolStripComboBox_2, toolStripLabel_3, themedToolStripComboBox_3);
		toolStrip_0.Location = new Point(0, 0);
		toolStrip_0.Name = Class333.smethod_770();
		toolStrip_0.Size = new Size(928, 33);
		toolStrip_0.TabIndex = 0;
		toolStrip_0.Text = Class333.smethod_770();
		toolStripLabel_0.Name = Class333.smethod_771();
		toolStripLabel_0.Padding = new Padding(5, 0, 0, 0);
		toolStripLabel_0.Size = new Size(37, 22);
		toolStripLabel_0.Text = Class333.smethod_772();
		toolStripLabel_0.TextAlign = ContentAlignment.MiddleRight;
		themedToolStripComboBox_0.AutoSize = false;
		themedToolStripComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		themedToolStripComboBox_0.DropDownWidth = 100;
		themedToolStripComboBox_0.MaxDropDownItems = 3;
		themedToolStripComboBox_0.Name = Class333.smethod_773();
		themedToolStripComboBox_0.SelectedIndex = -1;
		themedToolStripComboBox_0.Size = new Size(100, 23);
		toolStripLabel_1.Name = Class333.smethod_774();
		toolStripLabel_1.Padding = new Padding(20, 0, 0, 0);
		toolStripLabel_1.Size = new Size(154, 22);
		toolStripLabel_1.Text = Class333.smethod_775();
		toolStripLabel_1.TextAlign = ContentAlignment.MiddleRight;
		themedToolStripComboBox_1.AutoSize = false;
		themedToolStripComboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		themedToolStripComboBox_1.Name = Class333.smethod_776();
		themedToolStripComboBox_1.SelectedIndex = -1;
		themedToolStripComboBox_1.Size = new Size(121, 23);
		toolStripLabel_2.Name = Class333.smethod_777();
		toolStripLabel_2.Padding = new Padding(20, 0, 0, 0);
		toolStripLabel_2.Size = new Size(139, 22);
		toolStripLabel_2.Text = Class333.smethod_778();
		toolStripLabel_2.TextAlign = ContentAlignment.MiddleRight;
		themedToolStripComboBox_2.AutoSize = false;
		themedToolStripComboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
		themedToolStripComboBox_2.Name = Class333.smethod_779();
		themedToolStripComboBox_2.SelectedIndex = -1;
		themedToolStripComboBox_2.Size = new Size(121, 23);
		toolStripLabel_3.Name = Class333.smethod_780();
		toolStripLabel_3.Padding = new Padding(20, 0, 0, 0);
		toolStripLabel_3.Size = new Size(132, 22);
		toolStripLabel_3.Text = Class333.smethod_781();
		toolStripLabel_3.TextAlign = ContentAlignment.MiddleRight;
		themedToolStripComboBox_3.AutoSize = false;
		themedToolStripComboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
		themedToolStripComboBox_3.Name = Class333.smethod_782();
		themedToolStripComboBox_3.SelectedIndex = -1;
		themedToolStripComboBox_3.Size = new Size(100, 23);
		splitContainer_0.Dock = DockStyle.Fill;
		splitContainer_0.Location = new Point(0, 25);
		splitContainer_0.Name = Class333.smethod_783();
		splitContainer_0.Panel1.Controls.Add(tableLayoutPanelWithThemedScrollBars_2);
		splitContainer_0.Panel2.Controls.Add(splitContainer_1);
		splitContainer_0.Size = new Size(928, 617);
		splitContainer_0.SplitterDistance = 160;
		splitContainer_0.TabIndex = 1;
		tableLayoutPanelWithThemedScrollBars_2.ColumnCount = 1;
		tableLayoutPanelWithThemedScrollBars_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanelWithThemedScrollBars_2.Controls.Add(themedButton_0, 0, 0);
		tableLayoutPanelWithThemedScrollBars_2.Controls.Add(themedButton_1, 0, 1);
		tableLayoutPanelWithThemedScrollBars_2.Controls.Add(class61_0, 0, 2);
		tableLayoutPanelWithThemedScrollBars_2.Dock = DockStyle.Fill;
		tableLayoutPanelWithThemedScrollBars_2.Location = new Point(0, 0);
		tableLayoutPanelWithThemedScrollBars_2.Margin = new Padding(0);
		tableLayoutPanelWithThemedScrollBars_2.Name = Class333.smethod_784();
		tableLayoutPanelWithThemedScrollBars_2.RowCount = 3;
		tableLayoutPanelWithThemedScrollBars_2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		tableLayoutPanelWithThemedScrollBars_2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		tableLayoutPanelWithThemedScrollBars_2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanelWithThemedScrollBars_2.Size = new Size(160, 617);
		tableLayoutPanelWithThemedScrollBars_2.TabIndex = 0;
		themedButton_0.Location = new Point(0, 0);
		themedButton_0.Margin = new Padding(0);
		themedButton_0.Name = Class333.smethod_785();
		themedButton_0.Size = new Size(160, 25);
		themedButton_0.TabIndex = 0;
		themedButton_0.Text = Class333.smethod_786();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		themedButton_1.Location = new Point(0, 25);
		themedButton_1.Margin = new Padding(0);
		themedButton_1.Name = Class333.smethod_787();
		themedButton_1.Size = new Size(160, 25);
		themedButton_1.TabIndex = 1;
		themedButton_1.Text = Class333.smethod_788();
		themedButton_1.UseVisualStyleBackColor = true;
		themedButton_1.Click += themedButton_1_Click;
		class61_0.AutoScroll = true;
		class61_0.Dock = DockStyle.Fill;
		class61_0.FlowDirection = FlowDirection.TopDown;
		class61_0.Location = new Point(0, 50);
		class61_0.Margin = new Padding(0);
		class61_0.Name = Class333.smethod_789();
		class61_0.Size = new Size(160, 567);
		class61_0.TabIndex = 2;
		class61_0.WrapContents = false;
		splitContainer_1.Dock = DockStyle.Fill;
		splitContainer_1.Location = new Point(0, 0);
		splitContainer_1.Name = Class333.smethod_790();
		splitContainer_1.Orientation = Orientation.Horizontal;
		splitContainer_1.Panel1.Controls.Add(tableLayoutPanelWithThemedScrollBars_0);
		splitContainer_1.Panel2.Controls.Add(tableLayoutPanelWithThemedScrollBars_1);
		splitContainer_1.Size = new Size(780, 617);
		splitContainer_1.SplitterDistance = 308;
		splitContainer_1.TabIndex = 0;
		tableLayoutPanelWithThemedScrollBars_0.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
		tableLayoutPanelWithThemedScrollBars_0.ColumnCount = 1;
		tableLayoutPanelWithThemedScrollBars_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanelWithThemedScrollBars_0.Controls.Add(label_0, 0, 0);
		tableLayoutPanelWithThemedScrollBars_0.Controls.Add(dataGridViewWithThemedScrollBars_0, 0, 1);
		tableLayoutPanelWithThemedScrollBars_0.Dock = DockStyle.Fill;
		tableLayoutPanelWithThemedScrollBars_0.Location = new Point(0, 0);
		tableLayoutPanelWithThemedScrollBars_0.Name = Class333.smethod_791();
		tableLayoutPanelWithThemedScrollBars_0.RowCount = 2;
		tableLayoutPanelWithThemedScrollBars_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		tableLayoutPanelWithThemedScrollBars_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanelWithThemedScrollBars_0.Size = new Size(780, 308);
		tableLayoutPanelWithThemedScrollBars_0.TabIndex = 0;
		label_0.AutoSize = true;
		label_0.Dock = DockStyle.Fill;
		label_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_0.Location = new Point(4, 1);
		label_0.Name = Class333.smethod_792();
		label_0.Size = new Size(772, 20);
		label_0.TabIndex = 0;
		label_0.Text = Class333.smethod_410();
		label_0.TextAlign = ContentAlignment.MiddleLeft;
		dataGridViewWithThemedScrollBars_0.AllowUserToAddRows = false;
		dataGridViewWithThemedScrollBars_0.AllowUserToDeleteRows = false;
		dataGridViewWithThemedScrollBars_0.AllowUserToResizeRows = false;
		dataGridViewWithThemedScrollBars_0.ColumnHeadersHeight = 24;
		dataGridViewWithThemedScrollBars_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridViewWithThemedScrollBars_0.Columns.AddRange(dataGridViewTextBoxColumn_0, dataGridViewTextBoxColumn_1, dataGridViewTextBoxColumn_2, dataGridViewTextBoxColumn_3, dataGridViewTextBoxColumn_4);
		dataGridViewWithThemedScrollBars_0.Dock = DockStyle.Fill;
		dataGridViewWithThemedScrollBars_0.Location = new Point(4, 25);
		dataGridViewWithThemedScrollBars_0.Name = Class333.smethod_793();
		dataGridViewWithThemedScrollBars_0.RowHeadersVisible = false;
		dataGridViewWithThemedScrollBars_0.SelectionMode = DataGridViewSelectionMode.CellSelect;
		dataGridViewWithThemedScrollBars_0.ShowCellErrors = false;
		dataGridViewWithThemedScrollBars_0.ShowEditingIcon = false;
		dataGridViewWithThemedScrollBars_0.ShowRowErrors = false;
		dataGridViewWithThemedScrollBars_0.Size = new Size(772, 279);
		dataGridViewWithThemedScrollBars_0.TabIndex = 1;
		dataGridViewWithThemedScrollBars_0.VirtualMode = true;
		dataGridViewWithThemedScrollBars_0.CellPainting += dataGridViewWithThemedScrollBars_0_CellPainting;
		dataGridViewWithThemedScrollBars_0.CellValueNeeded += dataGridViewWithThemedScrollBars_0_CellValueNeeded;
		dataGridViewWithThemedScrollBars_0.ColumnHeaderMouseClick += dataGridViewWithThemedScrollBars_0_ColumnHeaderMouseClick;
		dataGridViewTextBoxColumn_0.HeaderText = Class333.smethod_428();
		dataGridViewTextBoxColumn_0.MinimumWidth = 40;
		dataGridViewTextBoxColumn_0.Name = Class333.smethod_794();
		dataGridViewTextBoxColumn_0.ReadOnly = true;
		dataGridViewTextBoxColumn_0.Width = 90;
		dataGridViewTextBoxColumn_1.HeaderText = Class333.smethod_425();
		dataGridViewTextBoxColumn_1.MinimumWidth = 80;
		dataGridViewTextBoxColumn_1.Name = Class333.smethod_795();
		dataGridViewTextBoxColumn_1.ReadOnly = true;
		dataGridViewTextBoxColumn_1.Width = 110;
		dataGridViewTextBoxColumn_2.HeaderText = Class333.smethod_796();
		dataGridViewTextBoxColumn_2.MinimumWidth = 100;
		dataGridViewTextBoxColumn_2.Name = Class333.smethod_797();
		dataGridViewTextBoxColumn_2.ReadOnly = true;
		dataGridViewTextBoxColumn_2.Width = 200;
		dataGridViewTextBoxColumn_3.HeaderText = Class333.smethod_798();
		dataGridViewTextBoxColumn_3.MinimumWidth = 60;
		dataGridViewTextBoxColumn_3.Name = Class333.smethod_799();
		dataGridViewTextBoxColumn_3.ReadOnly = true;
		dataGridViewTextBoxColumn_3.Width = 110;
		dataGridViewTextBoxColumn_4.HeaderText = Class333.smethod_800();
		dataGridViewTextBoxColumn_4.MinimumWidth = 50;
		dataGridViewTextBoxColumn_4.Name = Class333.smethod_801();
		dataGridViewTextBoxColumn_4.ReadOnly = true;
		dataGridViewTextBoxColumn_4.Width = 80;
		tableLayoutPanelWithThemedScrollBars_1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
		tableLayoutPanelWithThemedScrollBars_1.ColumnCount = 1;
		tableLayoutPanelWithThemedScrollBars_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanelWithThemedScrollBars_1.Controls.Add(label_1, 0, 0);
		tableLayoutPanelWithThemedScrollBars_1.Controls.Add(dataGridViewWithThemedScrollBars_1, 0, 1);
		tableLayoutPanelWithThemedScrollBars_1.Dock = DockStyle.Fill;
		tableLayoutPanelWithThemedScrollBars_1.Location = new Point(0, 0);
		tableLayoutPanelWithThemedScrollBars_1.Name = Class333.smethod_802();
		tableLayoutPanelWithThemedScrollBars_1.RowCount = 2;
		tableLayoutPanelWithThemedScrollBars_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		tableLayoutPanelWithThemedScrollBars_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanelWithThemedScrollBars_1.Size = new Size(780, 305);
		tableLayoutPanelWithThemedScrollBars_1.TabIndex = 0;
		label_1.AutoSize = true;
		label_1.Dock = DockStyle.Fill;
		label_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_1.Location = new Point(4, 1);
		label_1.Name = Class333.smethod_803();
		label_1.Size = new Size(772, 20);
		label_1.TabIndex = 0;
		label_1.Text = Class333.smethod_416();
		label_1.TextAlign = ContentAlignment.MiddleLeft;
		dataGridViewWithThemedScrollBars_1.AllowUserToAddRows = false;
		dataGridViewWithThemedScrollBars_1.AllowUserToDeleteRows = false;
		dataGridViewWithThemedScrollBars_1.AllowUserToResizeRows = false;
		dataGridViewWithThemedScrollBars_1.ColumnHeadersHeight = 24;
		dataGridViewWithThemedScrollBars_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		dataGridViewWithThemedScrollBars_1.Columns.AddRange(dataGridViewTextBoxColumn_5, dataGridViewTextBoxColumn_6, dataGridViewTextBoxColumn_7, dataGridViewTextBoxColumn_8, dataGridViewTextBoxColumn_9);
		dataGridViewWithThemedScrollBars_1.Dock = DockStyle.Fill;
		dataGridViewWithThemedScrollBars_1.Location = new Point(4, 25);
		dataGridViewWithThemedScrollBars_1.Name = Class333.smethod_804();
		dataGridViewWithThemedScrollBars_1.RowHeadersVisible = false;
		dataGridViewWithThemedScrollBars_1.SelectionMode = DataGridViewSelectionMode.CellSelect;
		dataGridViewWithThemedScrollBars_1.ShowCellErrors = false;
		dataGridViewWithThemedScrollBars_1.ShowEditingIcon = false;
		dataGridViewWithThemedScrollBars_1.ShowRowErrors = false;
		dataGridViewWithThemedScrollBars_1.Size = new Size(772, 276);
		dataGridViewWithThemedScrollBars_1.TabIndex = 1;
		dataGridViewWithThemedScrollBars_1.VirtualMode = true;
		dataGridViewWithThemedScrollBars_1.CellPainting += dataGridViewWithThemedScrollBars_1_CellPainting;
		dataGridViewWithThemedScrollBars_1.CellValueNeeded += dataGridViewWithThemedScrollBars_1_CellValueNeeded;
		dataGridViewWithThemedScrollBars_1.ColumnHeaderMouseClick += dataGridViewWithThemedScrollBars_1_ColumnHeaderMouseClick;
		dataGridViewTextBoxColumn_5.HeaderText = Class333.smethod_428();
		dataGridViewTextBoxColumn_5.MinimumWidth = 40;
		dataGridViewTextBoxColumn_5.Name = Class333.smethod_805();
		dataGridViewTextBoxColumn_5.ReadOnly = true;
		dataGridViewTextBoxColumn_5.Width = 90;
		dataGridViewTextBoxColumn_6.HeaderText = Class333.smethod_425();
		dataGridViewTextBoxColumn_6.MinimumWidth = 80;
		dataGridViewTextBoxColumn_6.Name = Class333.smethod_806();
		dataGridViewTextBoxColumn_6.ReadOnly = true;
		dataGridViewTextBoxColumn_6.Width = 110;
		dataGridViewTextBoxColumn_7.HeaderText = Class333.smethod_796();
		dataGridViewTextBoxColumn_7.MinimumWidth = 100;
		dataGridViewTextBoxColumn_7.Name = Class333.smethod_807();
		dataGridViewTextBoxColumn_7.ReadOnly = true;
		dataGridViewTextBoxColumn_7.Width = 200;
		dataGridViewTextBoxColumn_8.HeaderText = Class333.smethod_798();
		dataGridViewTextBoxColumn_8.MinimumWidth = 60;
		dataGridViewTextBoxColumn_8.Name = Class333.smethod_808();
		dataGridViewTextBoxColumn_8.ReadOnly = true;
		dataGridViewTextBoxColumn_8.Width = 110;
		dataGridViewTextBoxColumn_9.HeaderText = Class333.smethod_800();
		dataGridViewTextBoxColumn_9.MinimumWidth = 50;
		dataGridViewTextBoxColumn_9.Name = Class333.smethod_809();
		dataGridViewTextBoxColumn_9.ReadOnly = true;
		dataGridViewTextBoxColumn_9.Width = 80;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(928, 642);
		Controls.Add(splitContainer_0);
		Controls.Add(toolStrip_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Name = Class333.smethod_810();
		ShowIcon = false;
		StartPosition = FormStartPosition.Manual;
		Text = Class333.smethod_811();
		FormClosing += Form3_FormClosing;
		Resize += Form3_Resize;
		toolStrip_0.ResumeLayout(performLayout: false);
		toolStrip_0.PerformLayout();
		splitContainer_0.Panel1.ResumeLayout(performLayout: false);
		splitContainer_0.Panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)splitContainer_0).EndInit();
		splitContainer_0.ResumeLayout(performLayout: false);
		tableLayoutPanelWithThemedScrollBars_2.ResumeLayout(performLayout: false);
		splitContainer_1.Panel1.ResumeLayout(performLayout: false);
		splitContainer_1.Panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)splitContainer_1).EndInit();
		splitContainer_1.ResumeLayout(performLayout: false);
		tableLayoutPanelWithThemedScrollBars_0.ResumeLayout(performLayout: false);
		tableLayoutPanelWithThemedScrollBars_0.PerformLayout();
		((ISupportInitialize)dataGridViewWithThemedScrollBars_0).EndInit();
		tableLayoutPanelWithThemedScrollBars_1.ResumeLayout(performLayout: false);
		tableLayoutPanelWithThemedScrollBars_1.PerformLayout();
		((ISupportInitialize)dataGridViewWithThemedScrollBars_1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void Form3_Disposed(object? sender, EventArgs e)
	{
		Form23.smethod_94(method_0);
	}

	[CompilerGenerated]
	private static bool smethod_0(Struct20 struct20_2, Class174 class174_0, Class174 class174_1)
	{
		if (struct20_2.BOA == Enum49.Bny)
		{
			if (class174_0.Bnr >= class174_1.Bnr)
			{
				if (class174_0.Bnr == class174_1.Bnr)
				{
					return class174_0.BnS;
				}
				return false;
			}
			return true;
		}
		if (struct20_2.BOA == Enum49.BnZ)
		{
			return class174_0.BnU < class174_1.BnU;
		}
		if (struct20_2.BOA == Enum49.Bnz)
		{
			return class174_0.Bnt < class174_1.Bnt;
		}
		return false;
	}
}
