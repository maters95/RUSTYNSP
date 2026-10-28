using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns5;
using ns7;

namespace ns4;

internal class Form43 : Form
{
	private enum Enum66 : byte
	{
		BRh,
		BRI,
		BRi
	}

	private enum Enum67 : byte
	{
		BRJ,
		BRj
	}

	private enum Enum68 : byte
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

	private delegate void Delegate114();

	private const int int_0 = 9119;

	private const int int_1 = 9120;

	private const int int_2 = 9121;

	private const int int_3 = 9122;

	private const int int_4 = 9123;

	private const int int_5 = 9124;

	private const int int_6 = 9125;

	private const int int_7 = 9126;

	private const int int_8 = 9127;

	private const int int_9 = 9128;

	private const int int_10 = 9129;

	private const int int_11 = 9130;

	private const int int_12 = 9131;

	private const int int_13 = 9132;

	private const int int_14 = 9133;

	private const int int_15 = 9134;

	private const int int_16 = 9135;

	private const int int_17 = 9136;

	private const int int_18 = 9162;

	private const int int_19 = 10216;

	private const int int_20 = 500;

	private const int int_21 = 1000;

	private const int int_22 = 25;

	private string[] string_0 = new string[9]
	{
		Class333.smethod_2417(),
		Class333.smethod_2418(),
		Class333.smethod_2419(),
		Class333.smethod_2420(),
		Class333.smethod_2421(),
		Class333.smethod_2422(),
		Class333.smethod_2423(),
		Class333.smethod_2424(),
		Class333.smethod_2425()
	};

	internal const int int_23 = 1000;

	internal const int int_24 = 4;

	private const int int_25 = 10;

	private const int int_26 = 10;

	private const int int_27 = 10;

	private const int int_28 = 5;

	private const int int_29 = 4;

	private Pen[] pen_0 = new Pen[4];

	private uint[,] uint_0 = new uint[4, 1000];

	private uint[,] uint_1 = new uint[4, 1000];

	private ushort ushort_0;

	private ushort ushort_1;

	private Setting[] setting_0 = new Setting[4];

	private Setting[] setting_1 = new Setting[4];

	private Setting[] setting_2 = new Setting[4];

	private Control8[] control8_0 = new Control8[4];

	private ThemedComboBox[] themedComboBox_0 = new ThemedComboBox[4];

	private TrackBar[] trackBar_0 = new TrackBar[4];

	private Class148[] class148_0 = new Class148[4];

	private Label[] label_0 = new Label[4];

	private Setting setting_3;

	private Setting setting_4;

	private Setting setting_5;

	private Setting setting_6;

	private Setting setting_7;

	private Setting setting_8;

	private Setting setting_9;

	private Setting setting_10;

	private int int_30;

	private bool bool_0;

	private int int_31;

	private int int_32;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3 = true;

	private bool bool_4;

	private System.Timers.Timer timer_0;

	private Stopwatch stopwatch_0 = new Stopwatch();

	private Stopwatch stopwatch_1 = new Stopwatch();

	private bool bool_5;

	private int int_33 = 1000;

	private int int_34;

	private int int_35;

	private bool[] bool_6 = new bool[4];

	private bool bool_7;

	private bool bool_8;

	private bool bool_9;

	private static object object_0 = new object();

	private IContainer icontainer_0;

	private Class148 class148_1;

	private Class148 class148_2;

	private Class148 class148_3;

	private Class148 class148_4;

	private ThemedComboBox themedComboBox_1;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	private ThemedComboBox themedComboBox_2;

	private ThemedComboBox themedComboBox_3;

	private ThemedComboBox themedComboBox_4;

	private ThemedComboBox themedComboBox_5;

	private Label label_7;

	private TrackBar trackBar_1;

	private Label label_8;

	private Label label_9;

	private Label label_10;

	private Label label_11;

	private TrackBar trackBar_2;

	private TrackBar trackBar_3;

	private TrackBar trackBar_4;

	private TrackBar trackBar_5;

	private Label label_12;

	private NumericUpDown numericUpDown_0;

	private ThemedButton themedButton_0;

	private Panel panel_0;

	private Panel panel_1;

	private Class60 class60_0;

	private Control8 control8_1;

	private Control8 control8_2;

	private Control8 control8_3;

	private Control8 control8_4;

	private Control8 control8_5;

	private Label label_13;

	private Label label_14;

	private Label label_15;

	private Label label_16;

	private Label label_17;

	private Label label_18;

	private Label label_19;

	private Label label_20;

	private Label label_21;

	private Label label_22;

	private ThemedComboBox themedComboBox_6;

	private Label label_23;

	private Class148 class148_5;

	private Panel panel_2;

	private Class148 class148_6;

	private Label label_24;

	private Label label_25;

	private Label label_26;

	private ThemedButton themedButton_1;

	internal Form43()
	{
		Form23.framework_1.method_31(20069)?.method_272(1, bool_0: true);
		bool_3 = true;
		method_24();
		BackColor = Form23.color_10;
		foreach (Control control5 in Controls)
		{
			if (control5 is Label && control5 != label_18 && control5 != label_19 && control5 != label_20 && control5 != label_21)
			{
				control5.ForeColor = Form23.color_12;
			}
		}
		panel_0.BackColor = Form23.color_10;
		foreach (Control control6 in panel_0.Controls)
		{
			if (control6 is Label && control6 != label_17 && control6 != label_16 && control6 != label_15 && control6 != label_14)
			{
				control6.ForeColor = Form23.color_12;
			}
		}
		panel_1.BackColor = Form23.color_10;
		foreach (Control control7 in panel_1.Controls)
		{
			if (control7 is Label)
			{
				control7.ForeColor = Form23.color_12;
			}
		}
		panel_2.BackColor = Form23.color_10;
		foreach (Control control8 in panel_2.Controls)
		{
			if (control8 is Label)
			{
				control8.ForeColor = Form23.color_12;
			}
		}
		class148_5.ForeColor = Form23.color_12;
		class148_6.ForeColor = Form23.color_12;
		int_31 = class60_0.Width / 4;
		int_32 = class60_0.Width * 3 / 4;
		pen_0[0] = Pens.Gold;
		pen_0[1] = Pens.Aqua;
		pen_0[2] = Pens.Salmon;
		pen_0[3] = Pens.Violet;
		control8_2.method_0(Form23.framework_1);
		control8_3.method_0(Form23.framework_1);
		control8_4.method_0(Form23.framework_1);
		control8_5.method_0(Form23.framework_1);
		control8_0[0] = control8_2;
		control8_0[1] = control8_3;
		control8_0[2] = control8_4;
		control8_0[3] = control8_5;
		control8_1.method_0(Form23.framework_1);
		themedComboBox_0[0] = themedComboBox_2;
		themedComboBox_0[1] = themedComboBox_5;
		themedComboBox_0[2] = themedComboBox_4;
		themedComboBox_0[3] = themedComboBox_3;
		trackBar_0[0] = trackBar_2;
		trackBar_0[1] = trackBar_3;
		trackBar_0[2] = trackBar_4;
		trackBar_0[3] = trackBar_5;
		class148_0[0] = class148_1;
		class148_0[1] = class148_4;
		class148_0[2] = class148_3;
		class148_0[3] = class148_2;
		label_0[0] = label_18;
		label_0[1] = label_19;
		label_0[2] = label_20;
		label_0[3] = label_21;
		setting_8 = Form23.framework_1.method_31(9119);
		setting_9 = Form23.framework_1.method_31(10216);
		setting_10 = Form23.framework_1.method_31(9162);
		ushort_0 = 0;
		ushort_1 = 0;
		for (int i = 0; i < 9; i++)
		{
			themedComboBox_1.Items.Add(string_0[i]);
		}
		if (Form23.framework_1.awZ == 20 && Form23.framework_1.awz == 3 && Form23.framework_1.aXA < new Class14(1, 13, 0, 101, 0))
		{
			bool_5 = false;
			themedComboBox_1.Items.RemoveAt(8);
			themedComboBox_1.Items.RemoveAt(7);
			themedComboBox_1.Items.RemoveAt(6);
		}
		else
		{
			bool_5 = true;
		}
		timer_0 = new System.Timers.Timer(40.0);
		if (Form23.framework_1.method_31(9133) != null)
		{
			timer_0.Elapsed += timer_0_Elapsed;
		}
		timer_0.AutoReset = false;
		timer_0.Enabled = true;
		timer_0.Start();
		stopwatch_0.Start();
	}

	private void Form43_Shown(object sender, EventArgs e)
	{
		if (Form23.framework_1.method_31(9133) != null)
		{
			method_4();
		}
		bool_3 = false;
		class148_5.Checked = true;
		method_23();
		if ((Form23.int_0 & 0x1000) != 0)
		{
			control8_2.Enabled = false;
			control8_3.Enabled = false;
			control8_4.Enabled = false;
			control8_5.Enabled = false;
			method_1();
			themedComboBox_6.Enabled = false;
			class148_5.Enabled = false;
			themedButton_1.Enabled = false;
		}
	}

	private void method_0()
	{
		foreach (Control control in panel_0.Controls)
		{
			if (!(control is Label))
			{
				control.Enabled = false;
			}
		}
	}

	private void method_1()
	{
		foreach (Control control in panel_1.Controls)
		{
			if (!(control is Label))
			{
				control.Enabled = false;
			}
		}
	}

	private void method_2()
	{
		foreach (Control control in panel_0.Controls)
		{
			control.Enabled = true;
		}
	}

	private void method_3()
	{
		foreach (Control control in panel_1.Controls)
		{
			control.Enabled = true;
		}
	}

	private void method_4()
	{
		setting_0[0] = Form23.framework_1.method_31(9120);
		setting_0[1] = Form23.framework_1.method_31(9121);
		setting_0[2] = Form23.framework_1.method_31(9122);
		setting_0[3] = Form23.framework_1.method_31(9123);
		setting_1[0] = Form23.framework_1.method_31(9124);
		setting_1[1] = Form23.framework_1.method_31(9125);
		setting_1[2] = Form23.framework_1.method_31(9126);
		setting_1[3] = Form23.framework_1.method_31(9127);
		setting_2[0] = Form23.framework_1.method_31(9128);
		setting_2[1] = Form23.framework_1.method_31(9129);
		setting_2[2] = Form23.framework_1.method_31(9130);
		setting_2[3] = Form23.framework_1.method_31(9131);
		setting_3 = Form23.framework_1.method_31(9132);
		setting_4 = Form23.framework_1.method_31(9133);
		setting_5 = Form23.framework_1.method_31(9134);
		setting_6 = Form23.framework_1.method_31(9135);
		setting_7 = Form23.framework_1.method_31(9136);
		for (int i = 0; i < 4; i++)
		{
			control8_0[i].method_2(setting_0[i].method_256());
			try
			{
				themedComboBox_0[i].SelectedIndex = setting_1[i].method_256();
			}
			catch
			{
				themedComboBox_0[i].SelectedIndex = 0;
			}
			method_7(i);
			try
			{
				if (setting_2[i].method_199() == 1 && bool_3)
				{
					trackBar_0[i].Maximum /= 4;
					trackBar_0[i].Minimum /= 4;
					trackBar_0[i].LargeChange /= 4;
					trackBar_0[i].TickFrequency /= 4;
				}
				trackBar_0[i].Value = setting_2[i].method_256();
			}
			catch
			{
				trackBar_0[i].Value = 0;
			}
		}
		control8_1.method_2(setting_3.method_256());
		try
		{
			themedComboBox_1.SelectedIndex = setting_4.method_256();
		}
		catch (Exception)
		{
			themedComboBox_1.SelectedIndex = 0;
		}
		int_30 = themedComboBox_1.SelectedIndex;
		numericUpDown_0.Value = (decimal)method_5();
		try
		{
			trackBar_1.Value = setting_6.method_256();
		}
		catch (Exception)
		{
			trackBar_1.Value = 500;
		}
		int num = setting_7.method_256();
		List<Setting.ListItems.Struct45> list = setting_7.method_102();
		if (list.Count != 0)
		{
			if (themedComboBox_6.Items.Count == 0)
			{
				for (int j = 0; j < list.Count; j++)
				{
					themedComboBox_6.Items.Add(list[j].bBV);
				}
			}
			int selectedIndex = 0;
			for (int k = 0; k < list.Count; k++)
			{
				if (list[k].bBv == num)
				{
					selectedIndex = k;
					break;
				}
			}
			themedComboBox_6.SelectedIndex = selectedIndex;
		}
		else
		{
			if (themedComboBox_6.Items.Count == 0)
			{
				themedComboBox_6.Items.Add(Class333.smethod_2426());
				themedComboBox_6.Items.Add(Class333.smethod_2427());
				themedComboBox_6.Items.Add(Class333.smethod_2428());
				themedComboBox_6.Items.Add(Class333.smethod_2429());
				themedComboBox_6.Items.Add(Class333.smethod_2430());
				themedComboBox_6.Items.Add(Class333.smethod_2431());
				themedComboBox_6.Items.Add(Class333.smethod_2432());
				themedComboBox_6.Items.Add(Class333.smethod_2433());
				themedComboBox_6.Items.Add(Class333.smethod_2434());
			}
			switch (num)
			{
			case 50:
				themedComboBox_6.SelectedIndex = 1;
				break;
			case 20:
				themedComboBox_6.SelectedIndex = 0;
				break;
			case 200:
				themedComboBox_6.SelectedIndex = 3;
				break;
			case 100:
				themedComboBox_6.SelectedIndex = 2;
				break;
			case 1000:
				themedComboBox_6.SelectedIndex = 5;
				break;
			case 500:
				themedComboBox_6.SelectedIndex = 4;
				break;
			default:
				themedComboBox_6.SelectedIndex = 0;
				break;
			case 10000:
				themedComboBox_6.SelectedIndex = 8;
				break;
			case 5000:
				themedComboBox_6.SelectedIndex = 7;
				break;
			case 2000:
				themedComboBox_6.SelectedIndex = 6;
				break;
			}
		}
		int_33 = method_16(num);
	}

	private double method_5()
	{
		if (setting_5 != null && setting_3 != null)
		{
			int num = setting_5.method_256();
			Setting setting = Form23.framework_1.method_31(setting_3.method_256());
			if (setting != null)
			{
				return Class233.smethod_28(num, setting.method_231());
			}
			return 0.0;
		}
		return 0.0;
	}

	private void method_6(Setting setting_11)
	{
		if (!Form13.smethod_0(setting_11, null))
		{
			Form13 form = new Form13(setting_11.method_92(), setting_11, null);
			form.ShowDialog(this);
			form.Dispose();
		}
	}

	private void method_7(int int_36)
	{
		if (int_36 >= 4)
		{
			return;
		}
		Setting setting = Form23.framework_1.method_31(control8_0[int_36].method_3());
		if (setting == null || themedComboBox_0[int_36] == null)
		{
			return;
		}
		if (setting.method_88() == 0)
		{
			try
			{
				themedComboBox_0[int_36].SelectedIndex = setting_1[int_36].method_256();
			}
			catch
			{
				themedComboBox_0[int_36].SelectedIndex = 0;
			}
			themedComboBox_0[int_36].Enabled = true;
		}
		else
		{
			themedComboBox_0[int_36].SelectedIndex = -1;
			themedComboBox_0[int_36].Enabled = false;
		}
	}

	private void method_8(int int_36)
	{
		if (bool_3 || int_36 >= 4 || setting_0[int_36] == null)
		{
			return;
		}
		setting_0[int_36].method_272(control8_0[int_36].method_3(), bool_0: true);
		class60_0.Invalidate();
		Setting setting = Form23.framework_1.method_31(control8_0[int_36].method_3());
		if (setting != null)
		{
			method_7(int_36);
			if (!string.IsNullOrEmpty(setting.method_92()))
			{
				method_6(setting);
			}
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		method_8(0);
	}

	private void method_10(object sender, EventArgs e)
	{
		method_8(1);
	}

	private void method_11(object sender, EventArgs e)
	{
		method_8(2);
	}

	private void method_12(object sender, EventArgs e)
	{
		method_8(3);
	}

	private void method_13(object sender, EventArgs e)
	{
		if (!bool_3 && setting_3 != null)
		{
			setting_3.method_272(control8_1.method_3(), bool_0: true);
			numericUpDown_0_ValueChanged(null, null);
			class60_0.Invalidate();
		}
	}

	private void method_14(int int_36)
	{
		if (!bool_3 && int_36 < 4 && setting_1[int_36] != null && themedComboBox_0[int_36].SelectedIndex != -1)
		{
			setting_1[int_36].method_272(themedComboBox_0[int_36].SelectedIndex, bool_0: true);
			class60_0.Invalidate();
		}
	}

	private void themedComboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_14(0);
	}

	private void themedComboBox_5_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_14(1);
	}

	private void themedComboBox_4_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_14(2);
	}

	private void themedComboBox_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_14(3);
	}

	private void method_15(int int_36)
	{
		if (!bool_3 && int_36 < 4 && setting_2[int_36] != null)
		{
			setting_2[int_36].method_272(trackBar_0[int_36].Value, bool_0: true);
			class60_0.Invalidate();
		}
	}

	private void trackBar_2_ValueChanged(object sender, EventArgs e)
	{
		method_15(0);
	}

	private void trackBar_3_ValueChanged(object sender, EventArgs e)
	{
		method_15(1);
	}

	private void trackBar_4_ValueChanged(object sender, EventArgs e)
	{
		method_15(2);
	}

	private void trackBar_5_ValueChanged(object sender, EventArgs e)
	{
		method_15(3);
	}

	private void class148_1_CheckedChanged(object sender, EventArgs e)
	{
		class60_0.Invalidate();
	}

	private void class148_4_CheckedChanged(object sender, EventArgs e)
	{
		class60_0.Invalidate();
	}

	private void class148_3_CheckedChanged(object sender, EventArgs e)
	{
		class60_0.Invalidate();
	}

	private void class148_2_CheckedChanged(object sender, EventArgs e)
	{
		class60_0.Invalidate();
	}

	private void themedComboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (setting_4 == null)
		{
			return;
		}
		if (!bool_3)
		{
			setting_4.method_272(themedComboBox_1.SelectedIndex, bool_0: true);
		}
		if (themedComboBox_1.SelectedIndex != 2 && themedComboBox_1.SelectedIndex != 5 && themedComboBox_1.SelectedIndex != 8)
		{
			numericUpDown_0.Invoke(() =>
			{
				numericUpDown_0.Enabled = true;
			});
		}
		else
		{
			numericUpDown_0.Invoke(() =>
			{
				numericUpDown_0.Enabled = false;
			});
		}
		if ((int_30 == 0 && themedComboBox_1.SelectedIndex == 4) || (int_30 == 1 && themedComboBox_1.SelectedIndex == 3) || (int_30 == 6 && themedComboBox_1.SelectedIndex == 4) || (int_30 == 7 && themedComboBox_1.SelectedIndex == 3))
		{
			bool_0 = true;
		}
		int_30 = themedComboBox_1.SelectedIndex;
		class60_0.Invalidate();
	}

	private void numericUpDown_0_ValueChanged(object sender, EventArgs e)
	{
		Setting setting = Form23.framework_1.method_31(setting_3.method_256());
		if (!bool_3 && setting_5 != null && setting != null)
		{
			double double_ = (double)numericUpDown_0.Value;
			setting_5.method_272(Class233.smethod_26(double_, setting.method_231()), bool_0: true);
			class60_0.Invalidate();
		}
	}

	private void trackBar_1_ValueChanged(object sender, EventArgs e)
	{
		if (!bool_3 && setting_6 != null)
		{
			setting_6.method_272(trackBar_1.Value, bool_0: true);
			class60_0.Invalidate();
		}
	}

	private void themedComboBox_6_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_3 || setting_7 == null)
		{
			return;
		}
		int num = 0;
		List<Setting.ListItems.Struct45> list = setting_7.method_102();
		if (list.Count != 0)
		{
			if (themedComboBox_6.SelectedIndex != -1 && themedComboBox_6.SelectedIndex < list.Count)
			{
				num = list[themedComboBox_6.SelectedIndex].bBv;
			}
		}
		else
		{
			switch (themedComboBox_6.SelectedIndex)
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
			setting_7.method_272(num, bool_0: true);
		}
		int_33 = method_16(num);
		method_22();
		class60_0.Invalidate();
	}

	private int method_16(int int_36)
	{
		return Math.Max(1000, 25 * int_36 / 10);
	}

	private void class148_5_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_3 || setting_8 == null)
		{
			return;
		}
		if ((sender as CheckBox).Checked)
		{
			setting_10.method_272(1, bool_0: true);
			setting_8.method_272(1, bool_0: true);
			return;
		}
		bool_4 = false;
		if (setting_8.method_256() == 1)
		{
			setting_8.method_272(0, bool_0: true);
		}
	}

	private double method_17(int int_36)
	{
		Setting setting = Form23.framework_1.method_31(control8_0[int_36].method_3());
		if (setting != null && setting.method_88() != 0)
		{
			double num = setting.method_88();
			double y = setting.method_90();
			return num * Math.Pow(10.0, y);
		}
		double[] array = new double[25]
		{
			0.001, 0.002, 0.005, 0.01, 0.02, 0.05, 0.1, 0.2, 0.5, 1.0,
			2.0, 5.0, 10.0, 20.0, 50.0, 100.0, 200.0, 500.0, 1000.0, 2000.0,
			5000.0, 10000.0, 20000.0, 50000.0, 100000.0
		};
		if (themedComboBox_0[int_36].SelectedIndex == -1)
		{
			return 1.0;
		}
		return array[themedComboBox_0[int_36].SelectedIndex];
	}

	private double method_18(int int_36, int int_37)
	{
		if (int_36 >= 4)
		{
			return 0.0;
		}
		int num = int_37 + ushort_1;
		if (num >= 1000)
		{
			num -= 1000;
		}
		int num2 = (int)uint_1[int_36, num];
		Setting setting = Form23.framework_1.method_31(control8_0[int_36].method_3());
		if (setting != null)
		{
			return Class233.smethod_28(num2, setting.method_231());
		}
		return num2;
	}

	private string method_19(int int_36, int int_37)
	{
		if (int_36 >= 4)
		{
			return string.Empty;
		}
		int num = int_37 + ushort_1;
		if (num >= 1000)
		{
			num -= 1000;
		}
		int num2 = (int)uint_1[int_36, num];
		Setting setting = Form23.framework_1.method_31(control8_0[int_36].method_3());
		if (setting != null)
		{
			return Class233.smethod_29(num2, setting.method_231());
		}
		return num2.ToString();
	}

	private void method_20(PaintEventArgs paintEventArgs_0)
	{
		paintEventArgs_0.Graphics.FillRectangle(Brushes.Black, new Rectangle(0, 0, class60_0.Width, class60_0.Height));
		int num = class60_0.Width / 2;
		int num2 = class60_0.Height / 2;
		int num3 = class60_0.Width / 10;
		int num4 = num3 / 10;
		int num5 = class60_0.Height / 10;
		int num6 = num5 / 5;
		for (int i = 0; i < class60_0.Width; i += num3)
		{
			paintEventArgs_0.Graphics.DrawLine(Pens.DimGray, i, 0, i, class60_0.Height);
		}
		for (int j = 0; j < class60_0.Height; j += num5)
		{
			paintEventArgs_0.Graphics.DrawLine(Pens.DimGray, 0, j, class60_0.Width, j);
		}
		for (int k = 0; k < class60_0.Width; k += num4)
		{
			paintEventArgs_0.Graphics.DrawLine(Pens.DimGray, k, num2 - 4, k, num2 + 4);
		}
		for (int l = 0; l < class60_0.Height; l += num6)
		{
			paintEventArgs_0.Graphics.DrawLine(Pens.DimGray, num - 4, l, num + 4, l);
		}
	}

	private void class60_0_Paint(object sender, PaintEventArgs e)
	{
		method_20(e);
		int num = class60_0.Height / 2;
		int num2 = class60_0.Height / 10;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = class60_0.Left + trackBar_1.Value - label_22.Width / 2;
		if (label_22.Left != num8)
		{
			label_22.Left = num8;
		}
		for (int i = 0; i < 4; i++)
		{
			bool flag = class148_0[i].Checked;
			label_0[i].Visible = flag;
			if (flag)
			{
				num3 = ((setting_2[i].method_199() != 1) ? trackBar_0[i].Value : (trackBar_0[i].Value * 4));
				int num9 = class60_0.Top + num - num3 - 7;
				if (label_0[i].Top != num9)
				{
					label_0[i].Top = num9;
				}
			}
			if (!flag)
			{
				continue;
			}
			num4 = 0;
			double num10 = method_18(i, 0);
			double num11 = method_17(i);
			num5 = (int)(num10 * (double)(-num2) / num11) + num - num3;
			for (int j = 0; j < class60_0.Width - 2; j++)
			{
				if (j != 0)
				{
					num4 = num6;
					num5 = num7;
				}
				num6 = j + 1;
				num7 = (int)(method_18(i, j + 1) * (double)(-num2) / num11) + num - num3;
				try
				{
					if ((num5 >= 0 && num5 <= class60_0.Height) || (num7 >= 0 && num7 <= class60_0.Height))
					{
						e.Graphics.DrawLine(pen_0[i], num4, num5, num6, num7);
					}
				}
				catch
				{
				}
			}
			if (!class148_6.Checked)
			{
				continue;
			}
			try
			{
				using Font font = new Font(Font.FontFamily, 8f);
				using SolidBrush brush = new SolidBrush(pen_0[i].Color);
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = ((int_31 >= class60_0.Width - 50) ? StringAlignment.Far : StringAlignment.Near);
				int num12 = (int)(method_18(i, int_31) * (double)(-num2) / num11) + num - num3;
				stringFormat.LineAlignment = ((num12 >= class60_0.Height - 20) ? StringAlignment.Far : StringAlignment.Near);
				string text = method_19(i, int_31);
				SizeF sizeF = e.Graphics.MeasureString(text, font);
				int num13 = ((stringFormat.Alignment == StringAlignment.Near) ? int_31 : (int_31 - (int)sizeF.Width));
				int num14 = ((stringFormat.LineAlignment == StringAlignment.Near) ? num12 : (num12 - (int)sizeF.Height)) + 1;
				e.Graphics.FillRectangle(Brushes.Black, num13, num14, sizeF.Width, sizeF.Height - 4f);
				e.Graphics.DrawString(text, font, brush, int_31, num12, stringFormat);
				stringFormat.Dispose();
				stringFormat = new StringFormat();
				stringFormat.Alignment = ((int_32 >= class60_0.Width - 50) ? StringAlignment.Far : StringAlignment.Near);
				num12 = (int)(method_18(i, int_32) * (double)(-num2) / num11) + num - num3;
				stringFormat.LineAlignment = ((num12 >= class60_0.Height - 20) ? StringAlignment.Far : StringAlignment.Near);
				text = method_19(i, int_32);
				sizeF = e.Graphics.MeasureString(text, font);
				num13 = ((stringFormat.Alignment == StringAlignment.Near) ? int_32 : (int_32 - (int)sizeF.Width));
				num14 = ((stringFormat.LineAlignment == StringAlignment.Near) ? num12 : (num12 - (int)sizeF.Height)) + 1;
				e.Graphics.FillRectangle(Brushes.Black, num13, num14, sizeF.Width, sizeF.Height - 4f);
				e.Graphics.DrawString(text, font, brush, int_32, num12, stringFormat);
				stringFormat.Dispose();
			}
			catch
			{
			}
		}
		if (class148_6.Checked)
		{
			e.Graphics.DrawLine(Pens.White, int_31, 0, int_31, class60_0.Height - 1);
			e.Graphics.DrawLine(Pens.White, int_32, 0, int_32, class60_0.Height - 1);
		}
	}

	internal void method_21(uint[,] uint_2, ushort ushort_2)
	{
		if ((Form23.int_0 & 0x1000) != 0 && Control3.bool_2)
		{
			uint_1 = (uint_0 = uint_2);
			ushort_1 = (ushort_0 = ushort_2);
			class60_0.Invalidate();
		}
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(object_0, ref lockTaken);
			if (!lockTaken)
			{
				return;
			}
			timer_0.Stop();
			timer_0.Enabled = false;
			if ((Form23.int_0 & 0x1000) != 0 && Control3.bool_2)
			{
				timer_0.Enabled = true;
				timer_0.Start();
			}
			else if (setting_8 != null && !Form23.smethod_27() && Form23.smethod_28(Form23.framework_1.aXc, bool_53: true))
			{
				if ((byte)setting_8.method_256() == 1 && !class148_5.Checked)
				{
					panel_0.Invoke(() =>
					{
						method_0();
					});
					panel_1.Invoke(() =>
					{
						method_1();
					});
					panel_2.Invoke(() =>
					{
						themedComboBox_6.Enabled = false;
					});
					panel_2.Invoke(() =>
					{
						class148_5.Enabled = false;
					});
				}
				else
				{
					panel_0.Invoke(() =>
					{
						method_2();
					});
					panel_1.Invoke(() =>
					{
						method_3();
					});
					panel_2.Invoke(() =>
					{
						themedComboBox_6.Enabled = true;
					});
					panel_2.Invoke(() =>
					{
						class148_5.Enabled = true;
					});
				}
				int num = setting_4.method_256();
				if (setting_9 != null && bool_5)
				{
					if ((num == 6 || num == 7 || num == 8) && class148_5.Checked && !bool_4 && setting_9.method_256() != 1)
					{
						if (!stopwatch_1.IsRunning)
						{
							stopwatch_1.Start();
						}
						else if (stopwatch_1.ElapsedMilliseconds >= int_33)
						{
							setting_9.method_272(1, bool_0: true);
							timer_0.Enabled = true;
							timer_0.Start();
							return;
						}
					}
					else
					{
						stopwatch_1.Reset();
					}
				}
				if (class148_5.Checked && !bool_4)
				{
					if ((byte)setting_8.method_256() == 0)
					{
						setting_8.method_272(1, bool_0: true);
					}
					else if ((byte)setting_8.method_256() == 2)
					{
						bool_4 = true;
					}
					if (stopwatch_0.ElapsedMilliseconds >= 500L)
					{
						setting_10.method_272(1, bool_0: true);
						stopwatch_0.Restart();
					}
				}
				if (bool_4)
				{
					stopwatch_1.Reset();
					if (!Class1.smethod_37(Form23.framework_1.aXc, Enum10.const_6, 0u, 16384u, out var byte_, out var _))
					{
						ushort_0 = 0;
						ushort_1 = 0;
						timer_0.Enabled = true;
						timer_0.Start();
						return;
					}
					bool_4 = false;
					ushort_0 = (ushort)((byte_[4006] << 8) | byte_[4007]);
					for (uint num2 = 0u; num2 < 4; num2++)
					{
						uint num3 = num2 * 1024 * 4;
						for (uint num4 = 0u; num4 < 1000; num4++)
						{
							uint num5 = num4 * 4;
							byte[] array = new byte[4];
							for (uint num6 = 0u; num6 < 4; num6++)
							{
								array[num6] = byte_[num3 + num5 + num6];
								if (num6 == 3)
								{
									uint_0[num2, num4] = (uint)((array[0] << 24) | (array[1] << 16) | (array[2] << 8) | array[3]);
								}
							}
						}
					}
					uint_1 = uint_0;
					ushort_1 = ushort_0;
					if ((num != 3 && num != 4 && num != 5 && class148_5.Checked) || bool_0)
					{
						bool_0 = false;
						setting_10.method_272(1, bool_0: true);
						setting_8.method_272(1, bool_0: true);
					}
					else
					{
						setting_8.method_272(0, bool_0: true);
						class148_5.Invoke(() =>
						{
							class148_5.Checked = false;
						});
					}
					class60_0.Invalidate();
					if ((Form23.int_0 & 0x400) != 0)
					{
						Form23.class284_0.method_4(uint_1, ushort_1);
					}
					if ((Form23.int_0 & 0x800) != 0)
					{
						Form23.class284_1.method_4(uint_1, ushort_1);
					}
				}
				timer_0.Enabled = true;
				timer_0.Start();
			}
			else
			{
				ushort_0 = 0;
				ushort_1 = 0;
				timer_0.Enabled = true;
				timer_0.Start();
				panel_0.Invoke(() =>
				{
					method_0();
				});
				panel_1.Invoke(() =>
				{
					method_1();
				});
				panel_2.Invoke(() =>
				{
					themedComboBox_6.Enabled = false;
				});
				panel_2.Invoke(() =>
				{
					class148_5.Enabled = false;
				});
			}
		}
		catch
		{
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

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		if (setting_9 != null)
		{
			setting_9.method_272(1, bool_0: true);
		}
		if (!class148_5.Checked)
		{
			class148_5.Invoke(() =>
			{
				class148_5.Checked = true;
			});
		}
	}

	private void method_22()
	{
		if (class148_6.Checked)
		{
			int num = 0;
			List<Setting.ListItems.Struct45> list = setting_7.method_102();
			if (list.Count != 0)
			{
				if (themedComboBox_6.SelectedIndex != -1 && themedComboBox_6.SelectedIndex < list.Count)
				{
					num = list[themedComboBox_6.SelectedIndex].bBv * 10 / 10;
				}
			}
			else
			{
				switch (themedComboBox_6.SelectedIndex)
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
			label_24.Text = string.Format(Class333.smethod_2435(), (float)(Math.Abs(int_31 - int_32) * num) / (float)class60_0.Width);
			label_25.Left = class60_0.Left + int_31 - label_25.Width / 2;
			label_26.Left = class60_0.Left + int_32 - label_26.Width / 2;
		}
		else
		{
			label_24.Text = Class333.smethod_2436();
		}
	}

	private void class148_6_CheckedChanged(object sender, EventArgs e)
	{
		Label label = label_25;
		bool visible = (label_26.Visible = class148_6.Checked);
		label.Visible = visible;
		method_22();
		class60_0.Invalidate();
	}

	private void class60_0_MouseDown(object sender, MouseEventArgs e)
	{
		if (class148_6.Checked)
		{
			if (e.X >= int_31 - 3 && e.X <= int_31 + 3)
			{
				bool_1 = true;
			}
			else if (e.X >= int_32 - 3 && e.X <= int_32 + 3)
			{
				bool_2 = true;
			}
		}
	}

	private void class60_0_MouseMove(object sender, MouseEventArgs e)
	{
		if (class148_6.Checked)
		{
			if (bool_1)
			{
				int_31 = Math.Min(Math.Max(1, e.X), class60_0.Width - 2);
			}
			else if (bool_2)
			{
				int_32 = Math.Min(Math.Max(1, e.X), class60_0.Width - 2);
			}
			if (bool_1 || bool_2)
			{
				method_22();
				class60_0.Invalidate();
			}
		}
	}

	private void class60_0_MouseUp(object sender, MouseEventArgs e)
	{
		bool_2 = false;
		bool_1 = false;
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		if ((Form23.int_0 & 0x400) != 0 && !class148_5.Checked)
		{
			Form23.class284_0.method_4(uint_1, ushort_1);
		}
		if ((Form23.int_0 & 0x800) != 0 && !class148_5.Checked)
		{
			Form23.class284_1.method_4(uint_1, ushort_1);
		}
		Form23.form23_0.toolStripMenuItem_14_Click(null, null);
		if ((Form23.int_0 & 0x400) != 0 && !class148_5.Checked)
		{
			Form23.class284_0.method_4(uint_1, ushort_1);
		}
		if ((Form23.int_0 & 0x800) != 0 && !class148_5.Checked)
		{
			Form23.class284_1.method_4(uint_1, ushort_1);
		}
	}

	internal void method_23()
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate114 method = method_23;
				Invoke(method);
				return;
			}
			catch
			{
				return;
			}
		}
		if ((Form23.int_0 & 0x400) == 0)
		{
			themedButton_1.Text = Class333.smethod_2437();
		}
		else
		{
			themedButton_1.Text = Class333.smethod_2438();
		}
	}

	private void Form43_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.F6)
		{
			themedButton_1.PerformClick();
		}
	}

	private void label_21_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Label value = sender as Label;
			int_35 = e.Y;
			bool_6[Array.IndexOf(label_0, value)] = true;
		}
	}

	private void label_21_MouseMove(object sender, MouseEventArgs e)
	{
		Label label = sender as Label;
		int num = Array.IndexOf(label_0, label);
		if (bool_6[num])
		{
			int num2 = class60_0.Height / 2;
			int num3 = class60_0.Top + num2 - (label.Top + 7 + (e.Y - int_35));
			if (setting_2[num].method_199() == 1)
			{
				num3 /= 4;
			}
			trackBar_0[num].Value = Math.Max(Math.Min(num3, trackBar_0[num].Maximum), trackBar_0[num].Minimum);
		}
	}

	private void label_21_MouseUp(object sender, MouseEventArgs e)
	{
		Label value = sender as Label;
		bool_6[Array.IndexOf(label_0, value)] = false;
	}

	private void label_22_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			int_34 = e.X;
			bool_7 = true;
		}
	}

	private void label_22_MouseMove(object sender, MouseEventArgs e)
	{
		if (bool_7)
		{
			trackBar_1.Value = Math.Max(Math.Min(label_22.Left + (e.X - int_34) + label_22.Width / 2 - class60_0.Left, trackBar_1.Maximum), trackBar_1.Minimum);
		}
	}

	private void label_22_MouseUp(object sender, MouseEventArgs e)
	{
		bool_7 = false;
	}

	private void label_25_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			int_34 = e.X;
			bool_8 = true;
		}
	}

	private void label_25_MouseMove(object sender, MouseEventArgs e)
	{
		if (bool_8)
		{
			int_31 = Math.Min(Math.Max(label_25.Left + (e.X - int_34) + label_25.Width / 2 - class60_0.Left, 1), class60_0.Width - 2);
			method_22();
			class60_0.Invalidate();
		}
	}

	private void label_25_MouseUp(object sender, MouseEventArgs e)
	{
		bool_8 = false;
	}

	private void label_26_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			int_34 = e.X;
			bool_9 = true;
		}
	}

	private void label_26_MouseMove(object sender, MouseEventArgs e)
	{
		if (bool_9)
		{
			int_32 = Math.Min(Math.Max(label_26.Left + (e.X - int_34) + label_26.Width / 2 - class60_0.Left, 1), class60_0.Width - 2);
			method_22();
			class60_0.Invalidate();
		}
	}

	private void label_26_MouseUp(object sender, MouseEventArgs e)
	{
		bool_9 = false;
	}

	private void Form43_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form23.framework_1.method_31(20069)?.method_272(0, bool_0: true);
		try
		{
			if (timer_0 != null)
			{
				timer_0.Stop();
				timer_0.Elapsed -= timer_0_Elapsed;
				timer_0.Dispose();
				timer_0 = null;
			}
			if (setting_8 != null && control8_2.Enabled && control8_3.Enabled && control8_4.Enabled && control8_5.Enabled)
			{
				setting_8.method_272(0, bool_0: true);
			}
		}
		catch
		{
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

	private void method_24()
	{
		class148_1 = new Class148();
		class148_2 = new Class148();
		class148_3 = new Class148();
		class148_4 = new Class148();
		themedComboBox_1 = new ThemedComboBox();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		label_6 = new Label();
		themedComboBox_2 = new ThemedComboBox();
		themedComboBox_3 = new ThemedComboBox();
		themedComboBox_4 = new ThemedComboBox();
		themedComboBox_5 = new ThemedComboBox();
		label_7 = new Label();
		trackBar_1 = new TrackBar();
		label_8 = new Label();
		label_9 = new Label();
		label_10 = new Label();
		label_11 = new Label();
		trackBar_2 = new TrackBar();
		trackBar_3 = new TrackBar();
		trackBar_4 = new TrackBar();
		trackBar_5 = new TrackBar();
		label_12 = new Label();
		numericUpDown_0 = new NumericUpDown();
		themedButton_0 = new ThemedButton();
		panel_0 = new Panel();
		label_14 = new Label();
		label_15 = new Label();
		label_16 = new Label();
		label_17 = new Label();
		control8_2 = new Control8();
		control8_3 = new Control8();
		control8_4 = new Control8();
		control8_5 = new Control8();
		panel_1 = new Panel();
		label_13 = new Label();
		control8_1 = new Control8();
		label_18 = new Label();
		label_19 = new Label();
		label_20 = new Label();
		label_21 = new Label();
		label_22 = new Label();
		themedComboBox_6 = new ThemedComboBox();
		label_23 = new Label();
		class148_5 = new Class148();
		panel_2 = new Panel();
		class60_0 = new Class60();
		class148_6 = new Class148();
		label_24 = new Label();
		label_25 = new Label();
		label_26 = new Label();
		themedButton_1 = new ThemedButton();
		((ISupportInitialize)trackBar_1).BeginInit();
		((ISupportInitialize)trackBar_2).BeginInit();
		((ISupportInitialize)trackBar_3).BeginInit();
		((ISupportInitialize)trackBar_4).BeginInit();
		((ISupportInitialize)trackBar_5).BeginInit();
		((ISupportInitialize)numericUpDown_0).BeginInit();
		panel_0.SuspendLayout();
		panel_1.SuspendLayout();
		panel_2.SuspendLayout();
		SuspendLayout();
		class148_1.AutoSize = true;
		class148_1.Checked = true;
		class148_1.CheckState = CheckState.Checked;
		class148_1.ForeColor = Color.Gold;
		class148_1.Location = new Point(31, 622);
		class148_1.Name = Class333.smethod_2439();
		class148_1.Size = new Size(110, 17);
		class148_1.TabIndex = 0;
		class148_1.Text = Class333.smethod_2440();
		class148_1.UseVisualStyleBackColor = true;
		class148_1.CheckedChanged += class148_1_CheckedChanged;
		class148_2.AutoSize = true;
		class148_2.Checked = true;
		class148_2.CheckState = CheckState.Checked;
		class148_2.ForeColor = Color.Violet;
		class148_2.Location = new Point(421, 622);
		class148_2.Name = Class333.smethod_2441();
		class148_2.Size = new Size(110, 17);
		class148_2.TabIndex = 3;
		class148_2.Text = Class333.smethod_2442();
		class148_2.UseVisualStyleBackColor = true;
		class148_2.CheckedChanged += class148_2_CheckedChanged;
		class148_3.AutoSize = true;
		class148_3.Checked = true;
		class148_3.CheckState = CheckState.Checked;
		class148_3.ForeColor = Color.Salmon;
		class148_3.Location = new Point(291, 622);
		class148_3.Name = Class333.smethod_2443();
		class148_3.Size = new Size(110, 17);
		class148_3.TabIndex = 2;
		class148_3.Text = Class333.smethod_2444();
		class148_3.UseVisualStyleBackColor = true;
		class148_3.CheckedChanged += class148_3_CheckedChanged;
		class148_4.AutoSize = true;
		class148_4.Checked = true;
		class148_4.CheckState = CheckState.Checked;
		class148_4.ForeColor = Color.Aqua;
		class148_4.Location = new Point(161, 622);
		class148_4.Name = Class333.smethod_2445();
		class148_4.Size = new Size(110, 17);
		class148_4.TabIndex = 1;
		class148_4.Text = Class333.smethod_2446();
		class148_4.UseVisualStyleBackColor = true;
		class148_4.CheckedChanged += class148_4_CheckedChanged;
		themedComboBox_1.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_1.FormattingEnabled = true;
		themedComboBox_1.Location = new Point(4, 63);
		themedComboBox_1.Name = Class333.smethod_2447();
		themedComboBox_1.Size = new Size(232, 23);
		themedComboBox_1.TabIndex = 19;
		themedComboBox_1.SelectedIndexChanged += themedComboBox_1_SelectedIndexChanged;
		label_1.AutoSize = true;
		label_1.Location = new Point(2, 47);
		label_1.Name = Class333.smethod_618();
		label_1.Size = new Size(79, 13);
		label_1.TabIndex = 10;
		label_1.Text = Class333.smethod_2448();
		label_2.AutoSize = true;
		label_2.Location = new Point(2, 90);
		label_2.Name = Class333.smethod_620();
		label_2.Size = new Size(101, 13);
		label_2.TabIndex = 11;
		label_2.Text = Class333.smethod_2449();
		label_3.AutoSize = true;
		label_3.Location = new Point(71, 8);
		label_3.Name = Class333.smethod_621();
		label_3.Size = new Size(36, 13);
		label_3.TabIndex = 12;
		label_3.Text = Class333.smethod_2450();
		label_4.AutoSize = true;
		label_4.Location = new Point(71, 73);
		label_4.Name = Class333.smethod_623();
		label_4.Size = new Size(36, 13);
		label_4.TabIndex = 13;
		label_4.Text = Class333.smethod_2450();
		label_5.AutoSize = true;
		label_5.Location = new Point(71, 138);
		label_5.Name = Class333.smethod_862();
		label_5.Size = new Size(36, 13);
		label_5.TabIndex = 14;
		label_5.Text = Class333.smethod_2450();
		label_6.AutoSize = true;
		label_6.Location = new Point(71, 203);
		label_6.Name = Class333.smethod_864();
		label_6.Size = new Size(36, 13);
		label_6.TabIndex = 15;
		label_6.Text = Class333.smethod_2450();
		themedComboBox_2.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_2.FormattingEnabled = true;
		themedComboBox_2.Items.AddRange(Class333.smethod_2451(), Class333.smethod_2452(), Class333.smethod_2453(), Class333.smethod_2454(), Class333.smethod_2455(), Class333.smethod_2456(), Class333.smethod_2457(), Class333.smethod_2458(), Class333.smethod_2459(), Class333.smethod_2460(), Class333.smethod_2461(), Class333.smethod_2462(), Class333.smethod_2463(), Class333.smethod_2464(), Class333.smethod_2465(), Class333.smethod_2466(), Class333.smethod_2467(), Class333.smethod_2468(), Class333.smethod_2469(), Class333.smethod_2470(), Class333.smethod_2471(), Class333.smethod_2472(), Class333.smethod_2473(), Class333.smethod_2474(), Class333.smethod_2475());
		themedComboBox_2.Location = new Point(109, 5);
		themedComboBox_2.Name = Class333.smethod_2476();
		themedComboBox_2.Size = new Size(103, 23);
		themedComboBox_2.TabIndex = 5;
		themedComboBox_2.SelectedIndexChanged += themedComboBox_2_SelectedIndexChanged;
		themedComboBox_3.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_3.FormattingEnabled = true;
		themedComboBox_3.Items.AddRange(Class333.smethod_2451(), Class333.smethod_2452(), Class333.smethod_2453(), Class333.smethod_2454(), Class333.smethod_2455(), Class333.smethod_2456(), Class333.smethod_2457(), Class333.smethod_2458(), Class333.smethod_2459(), Class333.smethod_2460(), Class333.smethod_2461(), Class333.smethod_2462(), Class333.smethod_2463(), Class333.smethod_2464(), Class333.smethod_2465(), Class333.smethod_2466(), Class333.smethod_2467(), Class333.smethod_2468(), Class333.smethod_2469(), Class333.smethod_2470(), Class333.smethod_2471(), Class333.smethod_2472(), Class333.smethod_2473(), Class333.smethod_2474(), Class333.smethod_2475());
		themedComboBox_3.Location = new Point(109, 200);
		themedComboBox_3.Name = Class333.smethod_2477();
		themedComboBox_3.Size = new Size(103, 23);
		themedComboBox_3.TabIndex = 11;
		themedComboBox_3.SelectedIndexChanged += themedComboBox_3_SelectedIndexChanged;
		themedComboBox_4.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_4.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_4.FormattingEnabled = true;
		themedComboBox_4.Items.AddRange(Class333.smethod_2451(), Class333.smethod_2452(), Class333.smethod_2453(), Class333.smethod_2454(), Class333.smethod_2455(), Class333.smethod_2456(), Class333.smethod_2457(), Class333.smethod_2458(), Class333.smethod_2459(), Class333.smethod_2460(), Class333.smethod_2461(), Class333.smethod_2462(), Class333.smethod_2463(), Class333.smethod_2464(), Class333.smethod_2465(), Class333.smethod_2466(), Class333.smethod_2467(), Class333.smethod_2468(), Class333.smethod_2469(), Class333.smethod_2470(), Class333.smethod_2471(), Class333.smethod_2472(), Class333.smethod_2473(), Class333.smethod_2474(), Class333.smethod_2475());
		themedComboBox_4.Location = new Point(109, 135);
		themedComboBox_4.Name = Class333.smethod_2478();
		themedComboBox_4.Size = new Size(103, 23);
		themedComboBox_4.TabIndex = 9;
		themedComboBox_4.SelectedIndexChanged += themedComboBox_4_SelectedIndexChanged;
		themedComboBox_5.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_5.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_5.FormattingEnabled = true;
		themedComboBox_5.Items.AddRange(Class333.smethod_2451(), Class333.smethod_2452(), Class333.smethod_2453(), Class333.smethod_2454(), Class333.smethod_2455(), Class333.smethod_2456(), Class333.smethod_2457(), Class333.smethod_2458(), Class333.smethod_2459(), Class333.smethod_2460(), Class333.smethod_2461(), Class333.smethod_2462(), Class333.smethod_2463(), Class333.smethod_2464(), Class333.smethod_2465(), Class333.smethod_2466(), Class333.smethod_2467(), Class333.smethod_2468(), Class333.smethod_2469(), Class333.smethod_2470(), Class333.smethod_2471(), Class333.smethod_2472(), Class333.smethod_2473(), Class333.smethod_2474(), Class333.smethod_2475());
		themedComboBox_5.Location = new Point(109, 70);
		themedComboBox_5.Name = Class333.smethod_2479();
		themedComboBox_5.Size = new Size(103, 23);
		themedComboBox_5.TabIndex = 7;
		themedComboBox_5.SelectedIndexChanged += themedComboBox_5_SelectedIndexChanged;
		label_7.AutoSize = true;
		label_7.Location = new Point(2, 133);
		label_7.Name = Class333.smethod_627();
		label_7.Size = new Size(148, 13);
		label_7.TabIndex = 27;
		label_7.Text = Class333.smethod_2480();
		trackBar_1.LargeChange = 50;
		trackBar_1.Location = new Point(5, 147);
		trackBar_1.Margin = new Padding(0);
		trackBar_1.Maximum = 999;
		trackBar_1.Name = Class333.smethod_2481();
		trackBar_1.Size = new Size(231, 45);
		trackBar_1.TabIndex = 22;
		trackBar_1.TickFrequency = 50;
		trackBar_1.ValueChanged += trackBar_1_ValueChanged;
		label_8.AutoSize = true;
		label_8.Location = new Point(0, 275);
		label_8.Name = Class333.smethod_629();
		label_8.Size = new Size(59, 13);
		label_8.TabIndex = 29;
		label_8.Text = Class333.smethod_2482();
		label_9.AutoSize = true;
		label_9.Location = new Point(60, 275);
		label_9.Name = Class333.smethod_631();
		label_9.Size = new Size(59, 13);
		label_9.TabIndex = 30;
		label_9.Text = Class333.smethod_2483();
		label_10.AutoSize = true;
		label_10.Location = new Point(120, 275);
		label_10.Name = Class333.smethod_633();
		label_10.Size = new Size(59, 13);
		label_10.TabIndex = 31;
		label_10.Text = Class333.smethod_2484();
		label_11.AutoSize = true;
		label_11.Location = new Point(180, 275);
		label_11.Name = Class333.smethod_635();
		label_11.Size = new Size(59, 13);
		label_11.TabIndex = 32;
		label_11.Text = Class333.smethod_2485();
		trackBar_2.LargeChange = 60;
		trackBar_2.Location = new Point(16, 291);
		trackBar_2.Maximum = 300;
		trackBar_2.Minimum = -300;
		trackBar_2.Name = Class333.smethod_2486();
		trackBar_2.Orientation = Orientation.Vertical;
		trackBar_2.Size = new Size(45, 120);
		trackBar_2.TabIndex = 13;
		trackBar_2.TickFrequency = 60;
		trackBar_2.ValueChanged += trackBar_2_ValueChanged;
		trackBar_3.LargeChange = 60;
		trackBar_3.Location = new Point(76, 291);
		trackBar_3.Maximum = 300;
		trackBar_3.Minimum = -300;
		trackBar_3.Name = Class333.smethod_2487();
		trackBar_3.Orientation = Orientation.Vertical;
		trackBar_3.Size = new Size(45, 120);
		trackBar_3.TabIndex = 14;
		trackBar_3.TickFrequency = 60;
		trackBar_3.ValueChanged += trackBar_3_ValueChanged;
		trackBar_4.LargeChange = 60;
		trackBar_4.Location = new Point(136, 291);
		trackBar_4.Maximum = 300;
		trackBar_4.Minimum = -300;
		trackBar_4.Name = Class333.smethod_2488();
		trackBar_4.Orientation = Orientation.Vertical;
		trackBar_4.Size = new Size(45, 120);
		trackBar_4.TabIndex = 15;
		trackBar_4.TickFrequency = 60;
		trackBar_4.ValueChanged += trackBar_4_ValueChanged;
		trackBar_5.LargeChange = 60;
		trackBar_5.Location = new Point(196, 291);
		trackBar_5.Maximum = 300;
		trackBar_5.Minimum = -300;
		trackBar_5.Name = Class333.smethod_2489();
		trackBar_5.Orientation = Orientation.Vertical;
		trackBar_5.Size = new Size(45, 120);
		trackBar_5.TabIndex = 16;
		trackBar_5.TickFrequency = 60;
		trackBar_5.ValueChanged += trackBar_5_ValueChanged;
		label_12.AutoSize = true;
		label_12.Location = new Point(95, 257);
		label_12.Name = Class333.smethod_636();
		label_12.Size = new Size(54, 13);
		label_12.TabIndex = 37;
		label_12.Text = Class333.smethod_2490();
		numericUpDown_0.DecimalPlaces = 2;
		numericUpDown_0.Location = new Point(4, 106);
		numericUpDown_0.Maximum = new decimal(new int[4] { 10000000, 0, 0, 131072 });
		numericUpDown_0.Minimum = new decimal(new int[4] { 10000000, 0, 0, -2147352576 });
		numericUpDown_0.Name = Class333.smethod_2491();
		numericUpDown_0.Size = new Size(100, 22);
		numericUpDown_0.TabIndex = 20;
		numericUpDown_0.ValueChanged += numericUpDown_0_ValueChanged;
		themedButton_0.Location = new Point(120, 95);
		themedButton_0.Name = Class333.smethod_2492();
		themedButton_0.Size = new Size(116, 31);
		themedButton_0.TabIndex = 21;
		themedButton_0.Text = Class333.smethod_2493();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		panel_0.BorderStyle = BorderStyle.FixedSingle;
		panel_0.Controls.Add(label_14);
		panel_0.Controls.Add(label_15);
		panel_0.Controls.Add(label_16);
		panel_0.Controls.Add(label_17);
		panel_0.Controls.Add(control8_2);
		panel_0.Controls.Add(control8_3);
		panel_0.Controls.Add(control8_4);
		panel_0.Controls.Add(control8_5);
		panel_0.Controls.Add(label_12);
		panel_0.Controls.Add(label_3);
		panel_0.Controls.Add(trackBar_5);
		panel_0.Controls.Add(label_4);
		panel_0.Controls.Add(trackBar_4);
		panel_0.Controls.Add(label_5);
		panel_0.Controls.Add(trackBar_3);
		panel_0.Controls.Add(label_6);
		panel_0.Controls.Add(trackBar_2);
		panel_0.Controls.Add(themedComboBox_2);
		panel_0.Controls.Add(label_11);
		panel_0.Controls.Add(themedComboBox_3);
		panel_0.Controls.Add(label_10);
		panel_0.Controls.Add(themedComboBox_4);
		panel_0.Controls.Add(label_9);
		panel_0.Controls.Add(themedComboBox_5);
		panel_0.Controls.Add(label_8);
		panel_0.Location = new Point(1031, 1);
		panel_0.Name = Class333.smethod_2494();
		panel_0.Size = new Size(242, 416);
		panel_0.TabIndex = 4;
		label_14.AutoSize = true;
		label_14.ForeColor = Color.Violet;
		label_14.Location = new Point(2, 203);
		label_14.Name = Class333.smethod_2495();
		label_14.Size = new Size(59, 13);
		label_14.TabIndex = 49;
		label_14.Text = Class333.smethod_2485();
		label_15.AutoSize = true;
		label_15.ForeColor = Color.Salmon;
		label_15.Location = new Point(3, 138);
		label_15.Name = Class333.smethod_2496();
		label_15.Size = new Size(59, 13);
		label_15.TabIndex = 48;
		label_15.Text = Class333.smethod_2484();
		label_16.AutoSize = true;
		label_16.ForeColor = Color.Aqua;
		label_16.Location = new Point(2, 73);
		label_16.Name = Class333.smethod_642();
		label_16.Size = new Size(59, 13);
		label_16.TabIndex = 47;
		label_16.Text = Class333.smethod_2483();
		label_17.AutoSize = true;
		label_17.ForeColor = Color.Gold;
		label_17.Location = new Point(3, 8);
		label_17.Name = Class333.smethod_640();
		label_17.Size = new Size(59, 13);
		label_17.TabIndex = 46;
		label_17.Text = Class333.smethod_2482();
		control8_2.AutoSize = true;
		control8_2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		control8_2.Font = new Font(Class333.smethod_145(), 8f);
		control8_2.Location = new Point(5, 29);
		control8_2.Name = Class333.smethod_2497();
		control8_2.method_2(0);
		control8_2.Size = new Size(232, 23);
		control8_2.TabIndex = 6;
		control8_2.method_4(method_9);
		control8_3.AutoSize = true;
		control8_3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		control8_3.Font = new Font(Class333.smethod_145(), 8f);
		control8_3.Location = new Point(5, 94);
		control8_3.Name = Class333.smethod_2498();
		control8_3.method_2(0);
		control8_3.Size = new Size(232, 23);
		control8_3.TabIndex = 8;
		control8_3.method_4(method_10);
		control8_4.AutoSize = true;
		control8_4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		control8_4.Font = new Font(Class333.smethod_145(), 8f);
		control8_4.Location = new Point(5, 159);
		control8_4.Name = Class333.smethod_2499();
		control8_4.method_2(0);
		control8_4.Size = new Size(232, 23);
		control8_4.TabIndex = 10;
		control8_4.method_4(method_11);
		control8_5.AutoSize = true;
		control8_5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		control8_5.Font = new Font(Class333.smethod_145(), 8f);
		control8_5.Location = new Point(5, 224);
		control8_5.Name = Class333.smethod_2500();
		control8_5.method_2(0);
		control8_5.Size = new Size(232, 23);
		control8_5.TabIndex = 12;
		control8_5.method_4(method_12);
		panel_1.BorderStyle = BorderStyle.FixedSingle;
		panel_1.Controls.Add(label_13);
		panel_1.Controls.Add(control8_1);
		panel_1.Controls.Add(themedComboBox_1);
		panel_1.Controls.Add(label_1);
		panel_1.Controls.Add(themedButton_0);
		panel_1.Controls.Add(label_2);
		panel_1.Controls.Add(numericUpDown_0);
		panel_1.Controls.Add(trackBar_1);
		panel_1.Controls.Add(label_7);
		panel_1.Location = new Point(1031, 418);
		panel_1.Name = Class333.smethod_2501();
		panel_1.Size = new Size(242, 184);
		panel_1.TabIndex = 17;
		label_13.AutoSize = true;
		label_13.Location = new Point(2, 3);
		label_13.Name = Class333.smethod_638();
		label_13.Size = new Size(89, 13);
		label_13.TabIndex = 42;
		label_13.Text = Class333.smethod_2502();
		control8_1.AutoSize = true;
		control8_1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		control8_1.Font = new Font(Class333.smethod_145(), 8f);
		control8_1.Location = new Point(4, 19);
		control8_1.Name = Class333.smethod_2503();
		control8_1.method_2(0);
		control8_1.Size = new Size(232, 23);
		control8_1.TabIndex = 18;
		control8_1.method_4(method_13);
		label_18.ForeColor = Color.Gold;
		label_18.Location = new Point(0, 496);
		label_18.Name = Class333.smethod_2504();
		label_18.Size = new Size(28, 13);
		label_18.TabIndex = 45;
		label_18.Text = Class333.smethod_2505();
		label_18.MouseDown += label_21_MouseDown;
		label_18.MouseMove += label_21_MouseMove;
		label_18.MouseUp += label_21_MouseUp;
		label_19.ForeColor = Color.Aqua;
		label_19.Location = new Point(0, 516);
		label_19.Name = Class333.smethod_2506();
		label_19.Size = new Size(28, 13);
		label_19.TabIndex = 46;
		label_19.Text = Class333.smethod_2507();
		label_19.MouseDown += label_21_MouseDown;
		label_19.MouseMove += label_21_MouseMove;
		label_19.MouseUp += label_21_MouseUp;
		label_20.ForeColor = Color.Salmon;
		label_20.Location = new Point(0, 536);
		label_20.Name = Class333.smethod_2508();
		label_20.Size = new Size(28, 13);
		label_20.TabIndex = 47;
		label_20.Text = Class333.smethod_2509();
		label_20.MouseDown += label_21_MouseDown;
		label_20.MouseMove += label_21_MouseMove;
		label_20.MouseUp += label_21_MouseUp;
		label_21.ForeColor = Color.Violet;
		label_21.Location = new Point(0, 556);
		label_21.Name = Class333.smethod_2510();
		label_21.Size = new Size(28, 13);
		label_21.TabIndex = 48;
		label_21.Text = Class333.smethod_2511();
		label_21.MouseDown += label_21_MouseDown;
		label_21.MouseMove += label_21_MouseMove;
		label_21.MouseUp += label_21_MouseUp;
		label_22.AutoSize = true;
		label_22.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_22.Location = new Point(22, 602);
		label_22.Name = Class333.smethod_2512();
		label_22.Size = new Size(13, 13);
		label_22.TabIndex = 49;
		label_22.Text = Class333.smethod_1323();
		label_22.MouseDown += label_22_MouseDown;
		label_22.MouseMove += label_22_MouseMove;
		label_22.MouseUp += label_22_MouseUp;
		themedComboBox_6.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_6.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_6.FormattingEnabled = true;
		themedComboBox_6.Location = new Point(4, 12);
		themedComboBox_6.Name = Class333.smethod_2513();
		themedComboBox_6.Size = new Size(100, 23);
		themedComboBox_6.TabIndex = 24;
		themedComboBox_6.SelectedIndexChanged += themedComboBox_6_SelectedIndexChanged;
		label_23.AutoSize = true;
		label_23.Location = new Point(2, -1);
		label_23.Name = Class333.smethod_866();
		label_23.Size = new Size(60, 13);
		label_23.TabIndex = 51;
		label_23.Text = Class333.smethod_2514();
		class148_5.AutoSize = true;
		class148_5.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		class148_5.Location = new Point(119, 6);
		class148_5.Name = Class333.smethod_2515();
		class148_5.Size = new Size(103, 25);
		class148_5.TabIndex = 23;
		class148_5.Text = Class333.smethod_2516();
		class148_5.UseVisualStyleBackColor = true;
		class148_5.CheckedChanged += class148_5_CheckedChanged;
		panel_2.BorderStyle = BorderStyle.FixedSingle;
		panel_2.Controls.Add(themedComboBox_6);
		panel_2.Controls.Add(class148_5);
		panel_2.Controls.Add(label_23);
		panel_2.Location = new Point(1031, 603);
		panel_2.Name = Class333.smethod_2517();
		panel_2.Size = new Size(242, 38);
		panel_2.TabIndex = 53;
		class60_0.Location = new Point(29, 1);
		class60_0.Margin = new Padding(0);
		class60_0.Name = Class333.smethod_2518();
		class60_0.Size = new Size(1001, 601);
		class60_0.TabIndex = 43;
		class60_0.Paint += class60_0_Paint;
		class60_0.MouseDown += class60_0_MouseDown;
		class60_0.MouseMove += class60_0_MouseMove;
		class60_0.MouseUp += class60_0_MouseUp;
		class148_6.AutoSize = true;
		class148_6.Location = new Point(559, 622);
		class148_6.Name = Class333.smethod_2519();
		class148_6.Size = new Size(124, 17);
		class148_6.TabIndex = 4;
		class148_6.Text = Class333.smethod_2520();
		class148_6.UseVisualStyleBackColor = true;
		class148_6.CheckedChanged += class148_6_CheckedChanged;
		label_24.Location = new Point(689, 623);
		label_24.Name = Class333.smethod_2521();
		label_24.Size = new Size(190, 13);
		label_24.TabIndex = 54;
		label_24.Text = Class333.smethod_2436();
		label_25.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_25.Location = new Point(620, 602);
		label_25.Name = Class333.smethod_2522();
		label_25.Size = new Size(13, 13);
		label_25.TabIndex = 55;
		label_25.Text = Class333.smethod_1331();
		label_25.Visible = false;
		label_25.MouseDown += label_25_MouseDown;
		label_25.MouseMove += label_25_MouseMove;
		label_25.MouseUp += label_25_MouseUp;
		label_26.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_26.Location = new Point(650, 602);
		label_26.Name = Class333.smethod_2523();
		label_26.Size = new Size(13, 13);
		label_26.TabIndex = 56;
		label_26.Text = Class333.smethod_2242();
		label_26.Visible = false;
		label_26.MouseDown += label_26_MouseDown;
		label_26.MouseMove += label_26_MouseMove;
		label_26.MouseUp += label_26_MouseUp;
		themedButton_1.Location = new Point(883, 616);
		themedButton_1.Name = Class333.smethod_2524();
		themedButton_1.Size = new Size(145, 24);
		themedButton_1.TabIndex = 57;
		themedButton_1.Text = Class333.smethod_2437();
		themedButton_1.UseVisualStyleBackColor = true;
		themedButton_1.Click += themedButton_1_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1274, 642);
		Controls.Add(themedButton_1);
		Controls.Add(label_26);
		Controls.Add(label_25);
		Controls.Add(label_24);
		Controls.Add(class148_6);
		Controls.Add(panel_2);
		Controls.Add(label_22);
		Controls.Add(label_21);
		Controls.Add(label_20);
		Controls.Add(label_19);
		Controls.Add(label_18);
		Controls.Add(class60_0);
		Controls.Add(panel_1);
		Controls.Add(panel_0);
		Controls.Add(class148_4);
		Controls.Add(class148_3);
		Controls.Add(class148_2);
		Controls.Add(class148_1);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		KeyPreview = true;
		MaximizeBox = false;
		Name = Class333.smethod_2525();
		ShowIcon = false;
		StartPosition = FormStartPosition.Manual;
		Text = Class333.smethod_1587();
		FormClosing += Form43_FormClosing;
		Shown += Form43_Shown;
		KeyDown += Form43_KeyDown;
		((ISupportInitialize)trackBar_1).EndInit();
		((ISupportInitialize)trackBar_2).EndInit();
		((ISupportInitialize)trackBar_3).EndInit();
		((ISupportInitialize)trackBar_4).EndInit();
		((ISupportInitialize)trackBar_5).EndInit();
		((ISupportInitialize)numericUpDown_0).EndInit();
		panel_0.ResumeLayout(performLayout: false);
		panel_0.PerformLayout();
		panel_1.ResumeLayout(performLayout: false);
		panel_1.PerformLayout();
		panel_2.ResumeLayout(performLayout: false);
		panel_2.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void method_25()
	{
		numericUpDown_0.Enabled = false;
	}

	[CompilerGenerated]
	private void method_26()
	{
		numericUpDown_0.Enabled = true;
	}

	[CompilerGenerated]
	private void method_27()
	{
		method_0();
	}

	[CompilerGenerated]
	private void method_28()
	{
		method_1();
	}

	[CompilerGenerated]
	private void method_29()
	{
		themedComboBox_6.Enabled = false;
	}

	[CompilerGenerated]
	private void method_30()
	{
		class148_5.Enabled = false;
	}

	[CompilerGenerated]
	private void method_31()
	{
		method_0();
	}

	[CompilerGenerated]
	private void method_32()
	{
		method_1();
	}

	[CompilerGenerated]
	private void method_33()
	{
		themedComboBox_6.Enabled = false;
	}

	[CompilerGenerated]
	private void method_34()
	{
		class148_5.Enabled = false;
	}

	[CompilerGenerated]
	private void method_35()
	{
		method_2();
	}

	[CompilerGenerated]
	private void method_36()
	{
		method_3();
	}

	[CompilerGenerated]
	private void method_37()
	{
		themedComboBox_6.Enabled = true;
	}

	[CompilerGenerated]
	private void method_38()
	{
		class148_5.Enabled = true;
	}

	[CompilerGenerated]
	private void method_39()
	{
		class148_5.Checked = false;
	}

	[CompilerGenerated]
	private void method_40()
	{
		class148_5.Checked = true;
	}
}
