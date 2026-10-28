using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns2;
using ns4;
using ns6;
using ns7;

namespace ns5;

internal class Form51 : Form
{
	private const int int_0 = 48;

	private const int int_1 = 300;

	private Table table_0;

	private Setting setting_0;

	private Setting setting_1;

	private Setting setting_2;

	private DataGridViewWithThemedScrollBars[] dataGridViewWithThemedScrollBars_0 = new DataGridViewWithThemedScrollBars[3];

	private Class148[] class148_0 = new Class148[3];

	private Control8[] control8_0 = new Control8[3];

	private Label[] label_0 = new Label[3];

	private Label[] label_1 = new Label[3];

	private Label[] label_2 = new Label[3];

	private ThemedComboBox[] themedComboBox_0 = new ThemedComboBox[3];

	private PictureBox[] pictureBox_0 = new PictureBox[3];

	private ThemedButton[] themedButton_0 = new ThemedButton[3];

	private ThemedButton[] themedButton_1 = new ThemedButton[3];

	private ThemedButton[] themedButton_2 = new ThemedButton[3];

	private ThemedButton[] themedButton_3 = new ThemedButton[3];

	private Label[] label_3 = new Label[3];

	private PictureBox[] pictureBox_1 = new PictureBox[3];

	private bool[] bool_0 = new bool[3];

	private bool[] bool_1 = new bool[3];

	private bool[] bool_2 = new bool[3];

	private List<int>[] list_0 = new List<int>[3];

	private Label label_4;

	private IContainer icontainer_0;

	private Control8 control8_1;

	private Control8 control8_2;

	private Control8 control8_3;

	private Class148 class148_1;

	private Class148 class148_2;

	private Class148 class148_3;

	private ThemedButton themedButton_4;

	private ThemedButton themedButton_5;

	private DataGridViewWithThemedScrollBars dataGridViewWithThemedScrollBars_1;

	private DataGridViewWithThemedScrollBars dataGridViewWithThemedScrollBars_2;

	private DataGridViewWithThemedScrollBars dataGridViewWithThemedScrollBars_3;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	private Label label_9;

	private Label label_10;

	private ThemedButton themedButton_6;

	private ThemedButton themedButton_7;

	private ThemedButton themedButton_8;

	private ThemedButton themedButton_9;

	private ThemedButton themedButton_10;

	private ThemedButton themedButton_11;

	private ThemedButton themedButton_12;

	private ThemedButton themedButton_13;

	private ThemedButton themedButton_14;

	private PictureBox pictureBox_2;

	private PictureBox pictureBox_3;

	private PictureBox pictureBox_4;

	private Label label_11;

	private Label label_12;

	private Label label_13;

	private ThemedComboBox themedComboBox_1;

	private ThemedComboBox themedComboBox_2;

	private ThemedComboBox themedComboBox_3;

	private Label label_14;

	private Label label_15;

	private Label label_16;

	private ThemedButton themedButton_15;

	private ThemedButton themedButton_16;

	private ThemedButton themedButton_17;

	private PictureBox pictureBox_5;

	private PictureBox pictureBox_6;

	private PictureBox pictureBox_7;

	internal Form51(Table table_1)
	{
		method_27();
		dataGridViewWithThemedScrollBars_0[2] = dataGridViewWithThemedScrollBars_1;
		dataGridViewWithThemedScrollBars_0[1] = dataGridViewWithThemedScrollBars_2;
		dataGridViewWithThemedScrollBars_0[0] = dataGridViewWithThemedScrollBars_3;
		class148_0[2] = class148_1;
		class148_0[1] = class148_2;
		class148_0[0] = class148_3;
		control8_0[2] = control8_1;
		control8_0[1] = control8_2;
		control8_0[0] = control8_3;
		label_0[2] = label_7;
		label_0[1] = label_5;
		label_0[0] = label_6;
		label_1[2] = label_8;
		label_1[1] = label_10;
		label_1[0] = label_9;
		label_2[2] = label_16;
		label_2[1] = label_14;
		label_2[0] = label_15;
		themedComboBox_0[2] = themedComboBox_1;
		themedComboBox_0[1] = themedComboBox_2;
		themedComboBox_0[0] = themedComboBox_3;
		pictureBox_0[2] = pictureBox_5;
		pictureBox_0[1] = pictureBox_6;
		pictureBox_0[0] = pictureBox_7;
		themedButton_0[2] = themedButton_6;
		themedButton_0[1] = themedButton_11;
		themedButton_0[0] = themedButton_14;
		themedButton_1[2] = themedButton_7;
		themedButton_1[1] = themedButton_10;
		themedButton_1[0] = themedButton_13;
		themedButton_2[2] = themedButton_8;
		themedButton_2[1] = themedButton_9;
		themedButton_2[0] = themedButton_12;
		themedButton_3[2] = themedButton_15;
		themedButton_3[1] = themedButton_16;
		themedButton_3[0] = themedButton_17;
		label_3[2] = label_11;
		label_3[1] = label_12;
		label_3[0] = label_13;
		pictureBox_1[2] = pictureBox_2;
		pictureBox_1[1] = pictureBox_3;
		pictureBox_1[0] = pictureBox_4;
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (!(control is Label) && !(control is CheckBox))
			{
				if (control is DataGridViewWithThemedScrollBars)
				{
					typeof(DataGridViewWithThemedScrollBars).InvokeMember(Class333.smethod_741(), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, control as DataGridViewWithThemedScrollBars, new object[1] { true });
					(control as DataGridViewWithThemedScrollBars).BackgroundColor = Form23.color_20;
				}
			}
			else
			{
				control.ForeColor = Form23.color_12;
			}
		}
		label_4 = new Label();
		label_4.BackColor = Form23.color_15;
		label_4.ForeColor = Form23.color_12;
		label_4.BorderStyle = BorderStyle.FixedSingle;
		label_4.Visible = false;
		label_4.AutoSize = true;
		label_4.MinimumSize = new Size(300, 0);
		label_4.MaximumSize = new Size(300, 0);
		Controls.Add(label_4);
		table_0 = table_1;
		for (int i = 0; i < 3; i++)
		{
			control8_0[i].method_0(Form23.framework_1);
		}
		if (table_0.HorizAxis != null && table_0.HorizAxis.method_90() != null)
		{
			setting_0 = table_0.HorizAxis.method_92();
		}
		if (table_0.VertAxis != null && table_0.VertAxis.method_90() != null)
		{
			setting_1 = table_0.VertAxis.method_92();
		}
		if (table_0.SliceAxis != null && table_0.SliceAxis.method_90() != null)
		{
			setting_2 = table_0.SliceAxis.method_92();
		}
		string text = table_0.method_22(bool_0: true);
		Text = text + Class333.smethod_2634();
		bool_0[2] = table_0.HorizAxis != null && table_0.HorizAxis.method_80() != 0;
		bool_2[2] = table_0.HorizAxis != null && table_0.HorizAxis.method_86() != 0;
		bool_1[2] = table_0.HorizAxis != null && table_0.HorizAxis.method_84() != 0;
		bool_0[1] = table_0.VertAxis != null && table_0.VertAxis.method_80() != 0;
		bool_2[1] = table_0.VertAxis != null && table_0.VertAxis.method_86() != 0;
		bool_1[1] = table_0.VertAxis != null && table_0.VertAxis.method_84() != 0;
		bool_0[0] = table_0.SliceAxis != null && table_0.SliceAxis.method_80() != 0;
		bool_2[0] = table_0.SliceAxis != null && table_0.SliceAxis.method_86() != 0;
		bool_1[0] = table_0.SliceAxis != null && table_0.SliceAxis.method_84() != 0;
		if (table_0.HorizAxis != null)
		{
			list_0[2] = new List<int>();
		}
		if (table_0.VertAxis != null)
		{
			list_0[1] = new List<int>();
		}
		if (table_0.SliceAxis != null)
		{
			list_0[0] = new List<int>();
		}
		if (!bool_2[2])
		{
			control8_1.method_4(method_9);
		}
		if (!bool_2[1])
		{
			control8_2.method_4(method_10);
		}
		if (!bool_2[0])
		{
			control8_3.method_4(method_11);
		}
		Form23.smethod_7(method_26);
	}

	private void Form51_Shown(object sender, EventArgs e)
	{
		method_3();
		method_5();
		method_7();
		method_12();
		method_14();
		method_0();
		method_16();
		dataGridViewWithThemedScrollBars_0[2].Focus();
	}

	private void method_0()
	{
		for (int i = 0; i < 3; i++)
		{
			if (dataGridViewWithThemedScrollBars_0[i].Visible)
			{
				dataGridViewWithThemedScrollBars_0[i].Columns.Clear();
				dataGridViewWithThemedScrollBars_0[i].Rows.Clear();
				switch (i)
				{
				case 0:
					dataGridViewWithThemedScrollBars_0[i].ColumnCount = table_0.SliceAxis.method_89().method_277();
					break;
				case 1:
					dataGridViewWithThemedScrollBars_0[i].ColumnCount = table_0.VertAxis.method_89().method_277();
					break;
				case 2:
					dataGridViewWithThemedScrollBars_0[i].ColumnCount = table_0.HorizAxis.method_89().method_277();
					break;
				}
				dataGridViewWithThemedScrollBars_0[i].RowCount = 0;
				string[] array = new string[dataGridViewWithThemedScrollBars_0[i].ColumnCount];
				for (int j = 0; j < dataGridViewWithThemedScrollBars_0[i].ColumnCount; j++)
				{
					array[j] = string.Empty;
					dataGridViewWithThemedScrollBars_0[i].Columns[j].Width = 48;
					dataGridViewWithThemedScrollBars_0[i].Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable;
				}
				DataGridViewRowCollection rows = dataGridViewWithThemedScrollBars_0[i].Rows;
				object[] values = array;
				rows.Add(values);
				method_1((AxisType)i, bool_3: true);
				dataGridViewWithThemedScrollBars_0[i].method_4();
				dataGridViewWithThemedScrollBars_0[i].Enabled = dataGridViewWithThemedScrollBars_0[i].Enabled && !bool_1[i];
			}
		}
	}

	private void method_1(AxisType axisType_0, bool bool_3)
	{
		if (!dataGridViewWithThemedScrollBars_0[(int)axisType_0].Visible || !dataGridViewWithThemedScrollBars_0[(int)axisType_0].Enabled)
		{
			return;
		}
		for (int i = 0; i < dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount; i++)
		{
			TableAxis tableAxis = null;
			Setting setting = null;
			switch (axisType_0)
			{
			case AxisType.Slice:
				tableAxis = table_0.SliceAxis;
				setting = setting_2;
				break;
			case AxisType.Row:
				tableAxis = table_0.VertAxis;
				setting = setting_1;
				break;
			case AxisType.Column:
				tableAxis = table_0.HorizAxis;
				setting = setting_0;
				break;
			}
			if (setting == null)
			{
				continue;
			}
			int num = 0;
			int num2 = 0;
			int int_ = 0;
			int int_2 = 0;
			setting.method_230(ref num, ref num2, ref int_, ref int_2);
			if (bool_3)
			{
				if (i < tableAxis.method_88().method_256())
				{
					int num3 = tableAxis.method_89().method_258(i);
					if (i == list_0[(int)axisType_0].Count && !list_0[(int)axisType_0].Contains(num3))
					{
						list_0[(int)axisType_0].Add(num3);
					}
					(string, string, bool) tuple = setting.method_253(num3);
					dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value = tuple.Item1;
					if (tuple.Item1.Length > 5)
					{
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[i].Width = tuple.Item1.Length * 10;
					}
					else
					{
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[i].Width = 48;
					}
					if ((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value == string.Empty)
					{
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Style.BackColor = Color.White;
					}
					else
					{
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Style.BackColor = method_2(setting, num3, int_, int_2);
					}
				}
			}
			else if ((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value != string.Empty && i < list_0[(int)axisType_0].Count)
			{
				int int_3 = list_0[(int)axisType_0][i];
				(string, string, bool) tuple2 = setting.method_253(int_3);
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value = tuple2.Item1;
				if (tuple2.Item1.Length > 5)
				{
					dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[i].Width = tuple2.Item1.Length * 10;
				}
				else
				{
					dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[i].Width = 48;
				}
				if ((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value == string.Empty)
				{
					dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Style.BackColor = Color.White;
				}
				else
				{
					dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Style.BackColor = method_2(setting, int_3, int_, int_2);
				}
			}
		}
		dataGridViewWithThemedScrollBars_0[(int)axisType_0].method_4();
	}

	private Color method_2(Setting setting_3, int int_2, int int_3, int int_4)
	{
		foreach (Setting.ListItems.Struct45 item in setting_3.method_102())
		{
			if (int_2 == item.bBv)
			{
				return Color.White;
			}
		}
		if (int_2 >= int_3 && int_2 <= int_4)
		{
			return Color.White;
		}
		return Color.Red;
	}

	private void method_3()
	{
		for (int i = 0; i < 3; i++)
		{
			method_4((AxisType)i);
		}
	}

	private void method_4(AxisType axisType_0)
	{
		TableAxis tableAxis = null;
		switch (axisType_0)
		{
		case AxisType.Slice:
			tableAxis = table_0.SliceAxis;
			break;
		case AxisType.Row:
			tableAxis = table_0.VertAxis;
			break;
		case AxisType.Column:
			tableAxis = table_0.HorizAxis;
			break;
		}
		if (tableAxis != null && tableAxis.method_72() && tableAxis.method_90() != null && tableAxis.method_88() != null && tableAxis.method_87() != null && tableAxis.method_89() != null)
		{
			class148_0[(int)axisType_0].Visible = true;
			control8_0[(int)axisType_0].Visible = true;
			label_0[(int)axisType_0].Visible = true;
			label_1[(int)axisType_0].Visible = true;
			dataGridViewWithThemedScrollBars_0[(int)axisType_0].Visible = true;
			themedButton_0[(int)axisType_0].Visible = true;
			themedButton_1[(int)axisType_0].Visible = true;
			themedButton_2[(int)axisType_0].Visible = true;
			themedButton_3[(int)axisType_0].Visible = true;
			label_2[(int)axisType_0].Visible = tableAxis.method_91() != null;
			themedComboBox_0[(int)axisType_0].Visible = tableAxis.method_91() != null;
			pictureBox_0[(int)axisType_0].Visible = tableAxis.method_91() != null;
		}
		else
		{
			class148_0[(int)axisType_0].Visible = false;
			control8_0[(int)axisType_0].Visible = false;
			label_0[(int)axisType_0].Visible = false;
			label_1[(int)axisType_0].Visible = false;
			dataGridViewWithThemedScrollBars_0[(int)axisType_0].Visible = false;
			themedButton_0[(int)axisType_0].Visible = false;
			themedButton_1[(int)axisType_0].Visible = false;
			themedButton_2[(int)axisType_0].Visible = false;
			themedButton_3[(int)axisType_0].Visible = false;
			label_2[(int)axisType_0].Visible = false;
			themedComboBox_0[(int)axisType_0].Visible = false;
			pictureBox_0[(int)axisType_0].Visible = false;
		}
	}

	private void method_5()
	{
		for (int i = 0; i < 3; i++)
		{
			method_6((AxisType)i);
		}
	}

	private void method_6(AxisType axisType_0)
	{
		if (class148_0[(int)axisType_0].Visible)
		{
			TableAxis tableAxis = null;
			switch (axisType_0)
			{
			case AxisType.Slice:
				tableAxis = table_0.SliceAxis;
				break;
			case AxisType.Row:
				tableAxis = table_0.VertAxis;
				break;
			case AxisType.Column:
				tableAxis = table_0.HorizAxis;
				break;
			}
			bool flag = tableAxis.method_87().method_256() == 1;
			class148_0[(int)axisType_0].Checked = flag;
			class148_0[(int)axisType_0].Enabled = !bool_0[(int)axisType_0];
			control8_0[(int)axisType_0].Enabled = flag && !tableAxis.method_90().method_219() && !bool_2[(int)axisType_0];
			label_0[(int)axisType_0].Enabled = flag;
			label_1[(int)axisType_0].Enabled = flag;
			dataGridViewWithThemedScrollBars_0[(int)axisType_0].Enabled = flag;
			themedButton_0[(int)axisType_0].Enabled = flag && !bool_1[(int)axisType_0];
			themedButton_1[(int)axisType_0].Enabled = flag && !bool_1[(int)axisType_0];
			themedButton_2[(int)axisType_0].Enabled = flag && !bool_1[(int)axisType_0];
			themedButton_3[(int)axisType_0].Enabled = flag && !bool_1[(int)axisType_0];
			label_2[(int)axisType_0].Enabled = flag;
		}
	}

	private void method_7()
	{
		for (int i = 0; i < 3; i++)
		{
			method_8((AxisType)i);
		}
	}

	private void method_8(AxisType axisType_0)
	{
		if (control8_0[(int)axisType_0].Visible)
		{
			Setting setting = null;
			switch (axisType_0)
			{
			case AxisType.Slice:
				setting = setting_2;
				break;
			case AxisType.Row:
				setting = setting_1;
				break;
			case AxisType.Column:
				setting = setting_0;
				break;
			}
			if (setting == null)
			{
				control8_0[(int)axisType_0].method_2(0);
				Label obj = label_3[(int)axisType_0];
				bool visible = (pictureBox_1[(int)axisType_0].Visible = class148_0[(int)axisType_0].Checked);
				obj.Visible = visible;
			}
			else
			{
				control8_0[(int)axisType_0].method_2(setting.method_64());
				Label obj2 = label_3[(int)axisType_0];
				bool visible = (pictureBox_1[(int)axisType_0].Visible = class148_0[(int)axisType_0].Checked && (!setting.method_35() || !PortFunction.smethod_52(setting)));
				obj2.Visible = visible;
			}
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		int num = -1;
		if (setting_0 != null)
		{
			num = setting_0.method_231();
		}
		setting_0 = Form23.framework_1.method_31(control8_1.method_3());
		method_12();
		method_1(AxisType.Column, num == -1);
		Label label = label_11;
		bool visible = (pictureBox_2.Visible = !setting_0.method_35() || !PortFunction.smethod_52(setting_0));
		label.Visible = visible;
		dataGridViewWithThemedScrollBars_0[2].Focus();
		method_17(AxisType.Column);
	}

	private void method_10(object sender, EventArgs e)
	{
		int num = -1;
		if (setting_1 != null)
		{
			num = setting_1.method_231();
		}
		setting_1 = Form23.framework_1.method_31(control8_2.method_3());
		method_12();
		method_1(AxisType.Row, num == -1);
		Label label = label_12;
		bool visible = (pictureBox_3.Visible = !setting_1.method_35() || !PortFunction.smethod_52(setting_1));
		label.Visible = visible;
		dataGridViewWithThemedScrollBars_0[1].Focus();
		method_17(AxisType.Row);
	}

	private void method_11(object sender, EventArgs e)
	{
		int num = -1;
		if (setting_2 != null)
		{
			num = setting_2.method_231();
		}
		setting_2 = Form23.framework_1.method_31(control8_3.method_3());
		method_12();
		method_1(AxisType.Slice, num == -1);
		Label label = label_13;
		bool visible = (pictureBox_4.Visible = !setting_2.method_35() || !PortFunction.smethod_52(setting_2));
		label.Visible = visible;
		dataGridViewWithThemedScrollBars_0[0].Focus();
		method_17(AxisType.Slice);
	}

	private void method_12()
	{
		for (int i = 0; i < 3; i++)
		{
			method_13((AxisType)i);
		}
	}

	private void method_13(AxisType axisType_0)
	{
		if (label_0[(int)axisType_0].Visible)
		{
			Setting setting = null;
			switch (axisType_0)
			{
			case AxisType.Slice:
				setting = setting_2;
				break;
			case AxisType.Row:
				setting = setting_1;
				break;
			case AxisType.Column:
				setting = setting_0;
				break;
			}
			if (setting != null)
			{
				string text = Class233.smethod_35(setting.method_232(), setting.method_231(), bool_0: false, 0);
				label_0[(int)axisType_0].Text = Class333.smethod_2635() + text;
			}
		}
	}

	private void method_14()
	{
		for (int i = 0; i < 3; i++)
		{
			method_15((AxisType)i);
		}
	}

	private void method_15(AxisType axisType_0)
	{
		if (label_1[(int)axisType_0].Visible)
		{
			TableAxis tableAxis = null;
			switch (axisType_0)
			{
			case AxisType.Slice:
				tableAxis = table_0.SliceAxis;
				break;
			case AxisType.Row:
				tableAxis = table_0.VertAxis;
				break;
			case AxisType.Column:
				tableAxis = table_0.HorizAxis;
				break;
			}
			label_1[(int)axisType_0].Text = Class333.smethod_2636() + tableAxis.method_89().method_277();
		}
	}

	private void method_16()
	{
		for (int i = 0; i < 3; i++)
		{
			method_17((AxisType)i);
		}
	}

	private void method_17(AxisType axisType_0)
	{
		if (themedComboBox_0[(int)axisType_0].Visible)
		{
			TableAxis tableAxis = null;
			Setting setting = null;
			switch (axisType_0)
			{
			case AxisType.Slice:
				tableAxis = table_0.SliceAxis;
				setting = setting_2;
				break;
			case AxisType.Row:
				tableAxis = table_0.VertAxis;
				setting = setting_1;
				break;
			case AxisType.Column:
				tableAxis = table_0.HorizAxis;
				setting = setting_0;
				break;
			}
			bool flag = themedComboBox_0[(int)axisType_0].Items.Count == 0;
			List<Setting.ListItems.Struct45> list = tableAxis.method_91().method_102();
			for (int i = 0; i < list.Count; i++)
			{
				if (flag)
				{
					themedComboBox_0[(int)axisType_0].Items.Add(list[i].bBV);
				}
				if (setting != null && setting.method_167() != -1)
				{
					if (list[i].bBv == setting.method_167())
					{
						themedComboBox_0[(int)axisType_0].SelectedIndex = i;
					}
				}
				else if (list[i].bBv == tableAxis.method_91().method_256() && flag)
				{
					themedComboBox_0[(int)axisType_0].SelectedIndex = i;
				}
			}
			if (setting != null && setting.method_167() != -1)
			{
				themedComboBox_0[(int)axisType_0].Enabled = false;
			}
			else
			{
				themedComboBox_0[(int)axisType_0].Enabled = class148_0[(int)axisType_0].Checked;
			}
			pictureBox_0[(int)axisType_0].Visible = class148_0[(int)axisType_0].Checked;
		}
		else
		{
			pictureBox_0[(int)axisType_0].Visible = false;
		}
	}

	private void method_18(AxisType axisType_0)
	{
		label_4.Visible = false;
		if (!bool_0[(int)axisType_0])
		{
			TableAxis tableAxis = null;
			Setting setting = null;
			switch (axisType_0)
			{
			case AxisType.Slice:
				tableAxis = table_0.SliceAxis;
				setting = setting_2;
				break;
			case AxisType.Row:
				tableAxis = table_0.VertAxis;
				setting = setting_1;
				break;
			case AxisType.Column:
				tableAxis = table_0.HorizAxis;
				setting = setting_0;
				break;
			}
			bool flag = class148_0[(int)axisType_0].Checked;
			control8_0[(int)axisType_0].Enabled = flag && !tableAxis.method_90().method_219() && !bool_2[(int)axisType_0];
			label_0[(int)axisType_0].Enabled = flag;
			label_1[(int)axisType_0].Enabled = flag;
			dataGridViewWithThemedScrollBars_0[(int)axisType_0].Enabled = flag && !bool_1[(int)axisType_0];
			themedButton_0[(int)axisType_0].Enabled = flag && !bool_1[(int)axisType_0];
			themedButton_1[(int)axisType_0].Enabled = flag && !bool_1[(int)axisType_0];
			themedButton_2[(int)axisType_0].Enabled = flag && !bool_1[(int)axisType_0];
			themedButton_3[(int)axisType_0].Enabled = flag && !bool_1[(int)axisType_0];
			label_2[(int)axisType_0].Enabled = flag;
			method_17(axisType_0);
			Label obj = label_3[(int)axisType_0];
			bool visible = (pictureBox_1[(int)axisType_0].Visible = flag && (setting == null || !setting.method_35() || !PortFunction.smethod_52(setting)));
			obj.Visible = visible;
		}
	}

	private void class148_1_CheckedChanged(object sender, EventArgs e)
	{
		method_18(AxisType.Column);
	}

	private void class148_2_CheckedChanged(object sender, EventArgs e)
	{
		method_18(AxisType.Row);
	}

	private void class148_3_CheckedChanged(object sender, EventArgs e)
	{
		method_18(AxisType.Slice);
	}

	private void method_19(AxisType axisType_0)
	{
		label_4.Visible = false;
		if (!class148_0[(int)axisType_0].Visible || !class148_0[(int)axisType_0].Checked)
		{
			return;
		}
		TableAxis tableAxis = null;
		Setting setting = null;
		switch (axisType_0)
		{
		case AxisType.Slice:
			tableAxis = table_0.SliceAxis;
			setting = setting_2;
			break;
		case AxisType.Row:
			tableAxis = table_0.VertAxis;
			setting = setting_1;
			break;
		case AxisType.Column:
			tableAxis = table_0.HorizAxis;
			setting = setting_0;
			break;
		}
		if (setting == null)
		{
			Form54.smethod_6(this, Class333.smethod_2637(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		int int_ = Math.Min(tableAxis.method_88().method_229(), tableAxis.method_89().method_242()[2]);
		int int_2 = setting.method_232();
		int int_3 = 0;
		int int_4 = 0;
		int int_5 = 0;
		int int_6 = 0;
		setting.method_230(ref int_3, ref int_4, ref int_5, ref int_6);
		int int_7 = setting.method_231();
		Form52 form = new Form52(int_, int_7, int_2, int_3, int_4, int_5, int_6);
		if (form.ShowDialog(this) == DialogResult.OK)
		{
			List<int> list = form.method_0();
			if (list.Count != 0)
			{
				list_0[(int)axisType_0].Clear();
				for (int i = 0; i < dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount; i++)
				{
					if (i < list.Count)
					{
						list_0[(int)axisType_0].Add(list[i]);
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value = Class233.smethod_29(list[i], int_7);
					}
					else
					{
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value = string.Empty;
					}
					string text = (string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value;
					if (text.Length > 5)
					{
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[i].Width = text.Length * 10;
					}
					else
					{
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[i].Width = 48;
					}
					if ((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value == string.Empty)
					{
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Style.BackColor = Color.White;
						continue;
					}
					int int_8 = list[i];
					dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Style.BackColor = method_2(setting, int_8, int_5, int_6);
				}
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].method_4();
			}
		}
		form.Dispose();
	}

	private void themedButton_15_Click(object sender, EventArgs e)
	{
		method_19(AxisType.Column);
	}

	private void themedButton_16_Click(object sender, EventArgs e)
	{
		method_19(AxisType.Row);
	}

	private void themedButton_17_Click(object sender, EventArgs e)
	{
		method_19(AxisType.Slice);
	}

	private void method_20(AxisType axisType_0, object object_0)
	{
		label_4.Visible = false;
		if (!class148_0[(int)axisType_0].Visible || !class148_0[(int)axisType_0].Checked)
		{
			return;
		}
		int count = list_0[(int)axisType_0].Count;
		TableAxis tableAxis = null;
		Setting setting = null;
		switch (axisType_0)
		{
		case AxisType.Slice:
			tableAxis = table_0.SliceAxis;
			setting = setting_2;
			break;
		case AxisType.Row:
			tableAxis = table_0.VertAxis;
			setting = setting_1;
			break;
		case AxisType.Column:
			tableAxis = table_0.HorizAxis;
			setting = setting_0;
			break;
		}
		if (setting == null)
		{
			Form54.smethod_6(this, Class333.smethod_2637(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (count == tableAxis.method_88().method_229())
		{
			Form54.smethod_6(this, string.Format(Class333.smethod_2638(), count), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		int int_ = setting.method_231();
		int int_2 = setting.method_232();
		int int_3 = 0;
		int int_4 = 0;
		int int_5 = 0;
		int int_6 = 0;
		setting.method_230(ref int_3, ref int_4, ref int_5, ref int_6);
		Keys keys_ = Keys.None;
		if (object_0 is Keys)
		{
			keys_ = (Keys)object_0;
		}
		Form12 form = new Form12(Class333.smethod_2639(), keys_, Class333.smethod_102(), int_, int_2, int_3, int_4, int_5, int_6, setting.method_102());
		if (form.ShowDialog(this) == DialogResult.OK)
		{
			int num = ((form.method_1() == null) ? Class233.smethod_26(form.method_0(), int_) : form.method_2());
			for (int i = 0; i < dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount; i++)
			{
				if (!((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value != string.Empty))
				{
					continue;
				}
				bool flag = false;
				if (form.method_1() != null)
				{
					if ((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value == form.method_1())
					{
						flag = true;
					}
				}
				else if (i < count && list_0[(int)axisType_0][i] == num)
				{
					flag = true;
				}
				if (flag)
				{
					Form54.smethod_6(this, string.Format(Class333.smethod_2640(), (string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					form.Dispose();
					return;
				}
			}
			int num2 = 0;
			if ((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[0].Value != string.Empty && count != 0)
			{
				int num3 = list_0[(int)axisType_0][0];
				if (num > num3)
				{
					for (int j = 0; j < dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount - 1; j++)
					{
						if (!((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[j + 1].Value == string.Empty))
						{
							if (j + 1 < count)
							{
								int num4 = list_0[(int)axisType_0][j + 1];
								if (num < num4)
								{
									num2 = j + 1;
									break;
								}
							}
							continue;
						}
						num2 = j + 1;
						break;
					}
				}
			}
			for (int num5 = count - 1; num5 >= num2; num5--)
			{
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num5 + 1].Value = dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num5].Value;
				if (num5 + 1 < list_0[(int)axisType_0].Count)
				{
					list_0[(int)axisType_0][num5 + 1] = list_0[(int)axisType_0][num5];
				}
				else
				{
					list_0[(int)axisType_0].Add(list_0[(int)axisType_0][num5]);
				}
				string text = (string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num5 + 1].Value;
				if (text.Length > 5)
				{
					dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[num5 + 1].Width = text.Length * 10;
				}
				else
				{
					dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[num5 + 1].Width = 48;
				}
			}
			if (form.method_1() != null)
			{
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num2].Value = form.method_1();
				if (num2 < list_0[(int)axisType_0].Count)
				{
					list_0[(int)axisType_0][num2] = form.method_2();
				}
				else
				{
					list_0[(int)axisType_0].Add(form.method_2());
				}
			}
			else
			{
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num2].Value = Class233.smethod_29(num, int_);
				if (num2 < list_0[(int)axisType_0].Count)
				{
					list_0[(int)axisType_0][num2] = num;
				}
				else
				{
					list_0[(int)axisType_0].Add(num);
				}
			}
			string text2 = (string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num2].Value;
			if (text2.Length > 5)
			{
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[num2].Width = text2.Length * 10;
			}
			else
			{
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[num2].Width = 48;
			}
			for (int k = 0; k < dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount && !((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[k].Value == string.Empty); k++)
			{
				if ((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[k].Value == string.Empty)
				{
					dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[k].Style.BackColor = Color.White;
				}
				else if (k < list_0[(int)axisType_0].Count)
				{
					int int_7 = list_0[(int)axisType_0][k];
					dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[k].Style.BackColor = method_2(setting, int_7, int_5, int_6);
				}
			}
			dataGridViewWithThemedScrollBars_0[(int)axisType_0].ClearSelection();
			if (num2 != dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount - 1 && !((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num2 + 1].Value != string.Empty))
			{
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num2 + 1].Selected = true;
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].CurrentCell = dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num2 + 1];
			}
			else
			{
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num2].Selected = true;
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].CurrentCell = dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num2];
			}
			dataGridViewWithThemedScrollBars_0[(int)axisType_0].method_4();
		}
		form.Dispose();
	}

	private void themedButton_6_Click(object sender, EventArgs e)
	{
		method_20(AxisType.Column, sender);
	}

	private void themedButton_11_Click(object sender, EventArgs e)
	{
		method_20(AxisType.Row, sender);
	}

	private void themedButton_14_Click(object sender, EventArgs e)
	{
		method_20(AxisType.Slice, sender);
	}

	private void method_21(AxisType axisType_0)
	{
		label_4.Visible = false;
		if (dataGridViewWithThemedScrollBars_0[(int)axisType_0].SelectedCells == null || dataGridViewWithThemedScrollBars_0[(int)axisType_0].SelectedCells.Count == 0)
		{
			return;
		}
		List<int> list = method_24(axisType_0);
		if (list.Count == 0)
		{
			return;
		}
		int num = list[0];
		int count = list.Count;
		if (count == 1 && num == dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount - 1)
		{
			dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num].Value = string.Empty;
			dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[num].Width = 48;
			if (num < list_0[(int)axisType_0].Count)
			{
				list_0[(int)axisType_0].RemoveAt(num);
			}
		}
		else
		{
			for (int i = 0; i < count; i++)
			{
				for (int j = num + 1; j < dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount; j++)
				{
					dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[j - 1].Value = dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[j].Value;
					if (j < list_0[(int)axisType_0].Count)
					{
						list_0[(int)axisType_0][j - 1] = list_0[(int)axisType_0][j];
					}
					else if (j - 1 < list_0[(int)axisType_0].Count)
					{
						list_0[(int)axisType_0].RemoveAt(j - 1);
					}
					if (j == dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount - 1)
					{
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[j].Value = string.Empty;
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[j].Width = 48;
						if (j < list_0[(int)axisType_0].Count)
						{
							list_0[(int)axisType_0].RemoveAt(j);
						}
					}
					else
					{
						string text = (string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[j - 1].Value;
						if (text.Length > 5)
						{
							dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[j - 1].Width = text.Length * 10;
						}
						else
						{
							dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[j - 1].Width = 48;
						}
					}
				}
			}
			TableAxis tableAxis = null;
			Setting setting = null;
			switch (axisType_0)
			{
			case AxisType.Slice:
				tableAxis = table_0.SliceAxis;
				setting = setting_2;
				break;
			case AxisType.Row:
				tableAxis = table_0.VertAxis;
				setting = setting_1;
				break;
			case AxisType.Column:
				tableAxis = table_0.HorizAxis;
				setting = setting_0;
				break;
			}
			if (tableAxis != null && setting != null)
			{
				int num2 = 0;
				int num3 = 0;
				int int_ = 0;
				int int_2 = 0;
				setting.method_230(ref num2, ref num3, ref int_, ref int_2);
				setting.method_231();
				for (int k = 0; k < dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount && !((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[k].Value == string.Empty); k++)
				{
					if ((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[k].Value == string.Empty)
					{
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[k].Style.BackColor = Color.White;
					}
					else if (k < list_0[(int)axisType_0].Count)
					{
						int int_3 = list_0[(int)axisType_0][k];
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[k].Style.BackColor = method_2(setting, int_3, int_, int_2);
					}
				}
			}
		}
		dataGridViewWithThemedScrollBars_0[(int)axisType_0].method_4();
	}

	private void themedButton_7_Click(object sender, EventArgs e)
	{
		method_21(AxisType.Column);
	}

	private void themedButton_10_Click(object sender, EventArgs e)
	{
		method_21(AxisType.Row);
	}

	private void themedButton_13_Click(object sender, EventArgs e)
	{
		method_21(AxisType.Slice);
	}

	private void method_22(AxisType axisType_0)
	{
		label_4.Visible = false;
		if (dataGridViewWithThemedScrollBars_0[(int)axisType_0].SelectedCells == null || dataGridViewWithThemedScrollBars_0[(int)axisType_0].SelectedCells.Count < 3)
		{
			return;
		}
		List<int> list = method_24(axisType_0);
		if (list.Count == 0)
		{
			return;
		}
		int num = list[0];
		int index = list[list.Count - 1];
		try
		{
			for (int i = 0; i < list.Count; i++)
			{
				double.Parse((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num + i].Value, NumberStyles.Any, CultureInfo.CurrentCulture);
			}
		}
		catch
		{
			Form54.smethod_6(this, Class333.smethod_2641(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Setting setting = null;
		switch (axisType_0)
		{
		case AxisType.Slice:
			setting = setting_2;
			break;
		case AxisType.Row:
			setting = setting_1;
			break;
		case AxisType.Column:
			setting = setting_0;
			break;
		}
		int num2 = setting.method_231();
		int num3 = list_0[(int)axisType_0][num];
		int num4 = (list_0[(int)axisType_0][index] - num3) / (list.Count - 1);
		for (int j = 1; j < list.Count - 1; j++)
		{
			int value = num3 + j * num4;
			dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[num + j].Value = Class233.smethod_29(value, num2);
			list_0[(int)axisType_0][num + j] = value;
		}
	}

	private void themedButton_8_Click(object sender, EventArgs e)
	{
		method_22(AxisType.Column);
	}

	private void themedButton_9_Click(object sender, EventArgs e)
	{
		method_22(AxisType.Row);
	}

	private void themedButton_12_Click(object sender, EventArgs e)
	{
		method_22(AxisType.Slice);
	}

	private void method_23(AxisType axisType_0, Keys keys_0, Keys keys_1)
	{
		switch (keys_0)
		{
		case Keys.Delete:
			method_21(axisType_0);
			return;
		case Keys.Insert:
			method_20(axisType_0, null);
			return;
		case Keys.L:
			method_22(axisType_0);
			return;
		}
		if (keys_1 >= Keys.D0 && keys_1 <= Keys.D9)
		{
			method_20(axisType_0, keys_1);
			return;
		}
		if (keys_1 >= Keys.NumPad0 && keys_1 <= Keys.NumPad9)
		{
			method_20(axisType_0, keys_1);
			return;
		}
		if (keys_1 != Keys.OemMinus && keys_1 != Keys.Subtract)
		{
			if (keys_0 != (Keys.V | Keys.Control))
			{
				return;
			}
			try
			{
				if (!Clipboard.ContainsText())
				{
					return;
				}
				string text = Clipboard.GetText();
				int num = text.Split('\n')[0].Split('\t').Length;
				if (num > dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount)
				{
					return;
				}
				Setting setting = null;
				switch (axisType_0)
				{
				case AxisType.Slice:
					setting = setting_2;
					break;
				case AxisType.Row:
					setting = setting_1;
					break;
				case AxisType.Column:
					setting = setting_0;
					break;
				}
				int num2 = setting.method_231();
				int num3 = setting.method_228();
				int num4 = setting.method_229();
				List<int> list = new List<int>();
				int num5 = int.MinValue;
				for (int i = 0; i < num; i++)
				{
					string text2 = text.Split('\n')[0].Split('\t')[i];
					if (text2 == string.Empty)
					{
						break;
					}
					if (text2.EndsWith(Class333.smethod_2225()))
					{
						text2 = text2.Substring(0, text2.Length - 1);
					}
					int num6 = Class233.smethod_25(text2, num2);
					if (num3 != 0 || num4 != 0)
					{
						num6 = Math.Min(Math.Max(num6, num3), num4);
					}
					if (i == 0 || (num6 > num5 && !list.Contains(num6)))
					{
						list.Add(num6);
						num5 = num6;
						continue;
					}
					throw new Exception();
				}
				list_0[(int)axisType_0].Clear();
				for (int j = 0; j < dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount; j++)
				{
					if (j < list.Count)
					{
						list_0[(int)axisType_0].Add(list[j]);
						(string, string, bool) tuple = setting.method_253(list[j]);
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[j].Value = tuple.Item1;
						if (tuple.Item1.Length > 5)
						{
							dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[j].Width = tuple.Item1.Length * 10;
						}
						else
						{
							dataGridViewWithThemedScrollBars_0[(int)axisType_0].Columns[j].Width = 48;
						}
					}
					else
					{
						dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[j].Value = string.Empty;
					}
				}
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].ClearSelection();
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].CurrentCell = dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[0];
				dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[0].Selected = true;
				return;
			}
			catch
			{
				return;
			}
		}
		method_20(axisType_0, keys_1);
	}

	private void dataGridViewWithThemedScrollBars_1_KeyDown(object sender, KeyEventArgs e)
	{
		method_23(AxisType.Column, e.KeyData, e.KeyCode);
	}

	private void dataGridViewWithThemedScrollBars_2_KeyDown(object sender, KeyEventArgs e)
	{
		method_23(AxisType.Row, e.KeyData, e.KeyCode);
	}

	private void dataGridViewWithThemedScrollBars_3_KeyDown(object sender, KeyEventArgs e)
	{
		method_23(AxisType.Slice, e.KeyData, e.KeyCode);
	}

	private List<int> method_24(AxisType axisType_0)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < dataGridViewWithThemedScrollBars_0[(int)axisType_0].ColumnCount && !((string)dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Value == string.Empty); i++)
		{
			if (dataGridViewWithThemedScrollBars_0[(int)axisType_0].Rows[0].Cells[i].Selected)
			{
				list.Add(i);
			}
		}
		return list;
	}

	private void method_25(int int_2, int int_3, string string_0, string string_1)
	{
		label_4.Text = string_0 + Class333.smethod_2642() + string_1 + Class333.smethod_2643();
		label_4.Left = int_2;
		label_4.Top = int_3;
		label_4.Visible = true;
		label_4.BringToFront();
	}

	private void pictureBox_5_Click(object sender, EventArgs e)
	{
		if (label_4.Visible && (int)label_4.Tag == 2)
		{
			label_4.Visible = false;
			return;
		}
		label_4.Tag = 2;
		method_25(ClientSize.Width - 10 - 300, themedComboBox_1.Bottom, table_0.HorizAxis.method_91().method_287(1), table_0.HorizAxis.method_91().method_287(3));
	}

	private void pictureBox_6_Click(object sender, EventArgs e)
	{
		if (label_4.Visible && (int)label_4.Tag == 1)
		{
			label_4.Visible = false;
			return;
		}
		label_4.Tag = 1;
		method_25(ClientSize.Width - 10 - 300, themedComboBox_2.Bottom, table_0.VertAxis.method_91().method_287(1), table_0.VertAxis.method_91().method_287(3));
	}

	private void pictureBox_7_Click(object sender, EventArgs e)
	{
		if (label_4.Visible && (int)label_4.Tag == 0)
		{
			label_4.Visible = false;
			return;
		}
		label_4.Tag = 0;
		method_25(ClientSize.Width - 10 - 300, themedComboBox_3.Bottom, table_0.SliceAxis.method_91().method_287(1), table_0.SliceAxis.method_91().method_287(3));
	}

	private void Form51_Click(object sender, EventArgs e)
	{
		label_4.Visible = false;
	}

	private void method_26(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}

	private void Form51_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult != DialogResult.OK)
		{
			Form23.smethod_8(method_26);
			return;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		bool flag = false;
		Class280 @class = Form23.smethod_95();
		try
		{
			@class?.method_2(table_0.method_64());
			List<int> list = new List<int>();
			if (class148_1.Visible)
			{
				if (class148_1.Checked)
				{
					if (themedComboBox_1.Visible)
					{
						if (themedComboBox_1.SelectedIndex == -1)
						{
							throw new Exception();
						}
						table_0.HorizAxis.method_91().method_272(table_0.HorizAxis.method_91().method_102()[themedComboBox_1.SelectedIndex].bBv, bool_0: true);
					}
					for (int i = 0; i < dataGridViewWithThemedScrollBars_1.ColumnCount; i++)
					{
						if ((string)dataGridViewWithThemedScrollBars_1.Rows[0].Cells[i].Value != string.Empty)
						{
							int item = list_0[2][i];
							if (list.Contains(item))
							{
								flag = true;
								throw new Exception();
							}
							list.Add(item);
							num++;
						}
					}
					if (num == 0)
					{
						throw new Exception();
					}
					table_0.HorizAxis.method_90().method_272(setting_0.method_64(), bool_0: true);
					table_0.HorizAxis.method_87().method_272(1, bool_0: true);
				}
				else
				{
					table_0.HorizAxis.method_87().method_272(0, bool_0: true);
					list.Add(0);
					num = 1;
				}
			}
			else
			{
				list.Add(0);
				num = 1;
			}
			List<int> list2 = new List<int>();
			if (class148_2.Visible)
			{
				if (class148_2.Checked)
				{
					if (themedComboBox_2.Visible)
					{
						if (themedComboBox_2.SelectedIndex == -1)
						{
							throw new Exception();
						}
						table_0.VertAxis.method_91().method_272(table_0.VertAxis.method_91().method_102()[themedComboBox_2.SelectedIndex].bBv, bool_0: true);
					}
					for (int j = 0; j < dataGridViewWithThemedScrollBars_2.ColumnCount; j++)
					{
						if ((string)dataGridViewWithThemedScrollBars_2.Rows[0].Cells[j].Value != string.Empty)
						{
							int item2 = list_0[1][j];
							if (list2.Contains(item2))
							{
								flag = true;
								throw new Exception();
							}
							list2.Add(item2);
							num2++;
						}
					}
					if (num2 == 0)
					{
						throw new Exception();
					}
					table_0.VertAxis.method_90().method_272(setting_1.method_64(), bool_0: true);
					table_0.VertAxis.method_87().method_272(1, bool_0: true);
				}
				else
				{
					table_0.VertAxis.method_87().method_272(0, bool_0: true);
					list2.Add(0);
					num2 = 1;
				}
			}
			else
			{
				list2.Add(0);
				num2 = 1;
			}
			List<int> list3 = new List<int>();
			if (class148_3.Visible)
			{
				if (class148_3.Checked)
				{
					if (themedComboBox_3.Visible)
					{
						if (themedComboBox_3.SelectedIndex == -1)
						{
							throw new Exception();
						}
						table_0.SliceAxis.method_91().method_272(table_0.SliceAxis.method_91().method_102()[themedComboBox_3.SelectedIndex].bBv, bool_0: true);
					}
					for (int k = 0; k < dataGridViewWithThemedScrollBars_3.ColumnCount; k++)
					{
						if ((string)dataGridViewWithThemedScrollBars_3.Rows[0].Cells[k].Value != string.Empty)
						{
							int item3 = list_0[0][k];
							if (list3.Contains(item3))
							{
								flag = true;
								throw new Exception();
							}
							list3.Add(item3);
							num3++;
						}
					}
					if (num3 == 0)
					{
						throw new Exception();
					}
					table_0.SliceAxis.method_90().method_272(setting_2.method_64(), bool_0: true);
					table_0.SliceAxis.method_87().method_272(1, bool_0: true);
				}
				else
				{
					table_0.SliceAxis.method_87().method_272(0, bool_0: true);
					list3.Add(0);
					num3 = 1;
				}
			}
			else
			{
				list3.Add(0);
				num3 = 1;
			}
			int[,,] array = new int[num3, num2, num];
			for (int l = 0; l < num3; l++)
			{
				for (int m = 0; m < num2; m++)
				{
					for (int n = 0; n < num; n++)
					{
						array[l, m, n] = table_0.GetInterpolatedTableDataRawValue(list[n], list2[m], list3[l]);
					}
				}
			}
			if (class148_3.Visible)
			{
				table_0.SliceAxis.method_88().method_272(num3, bool_0: true);
				table_0.SliceAxis.method_89().method_268();
				for (int num4 = 0; num4 < num3; num4++)
				{
					table_0.SliceAxis.method_89().method_274(num4, list3[num4], bool_0: true);
				}
				table_0.SliceAxis.method_89().method_267(bool_0: true);
			}
			if (class148_2.Visible)
			{
				table_0.VertAxis.method_88().method_272(num2, bool_0: true);
				table_0.VertAxis.method_89().method_268();
				for (int num5 = 0; num5 < num2; num5++)
				{
					table_0.VertAxis.method_89().method_274(num5, list2[num5], bool_0: true);
				}
				table_0.VertAxis.method_89().method_267(bool_0: true);
			}
			if (class148_1.Visible)
			{
				table_0.HorizAxis.method_88().method_272(num, bool_0: true);
				table_0.HorizAxis.method_89().method_268();
				for (int num6 = 0; num6 < num; num6++)
				{
					table_0.HorizAxis.method_89().method_274(num6, list[num6], bool_0: true);
				}
				table_0.HorizAxis.method_89().method_267(bool_0: true);
			}
			table_0.TableDataSetting.method_268();
			for (int num7 = 0; num7 < num3; num7++)
			{
				for (int num8 = 0; num8 < num2; num8++)
				{
					for (int num9 = 0; num9 < num; num9++)
					{
						if (table_0.SwapColumnsAndRows)
						{
							table_0.TableDataSetting.method_273(num8, num9, num7, array[num7, num8, num9], bool_0: true);
						}
						else
						{
							table_0.TableDataSetting.method_273(num9, num8, num7, array[num7, num8, num9], bool_0: true);
						}
					}
				}
			}
			table_0.TableDataSetting.method_267(bool_0: true);
			if (table_0.method_0().awo != null)
			{
				table_0.method_0().awo.method_1(table_0.method_64());
			}
			@class?.method_4();
			if (!bool_2[2])
			{
				control8_1.method_5(method_9);
			}
			if (!bool_2[1])
			{
				control8_2.method_5(method_10);
			}
			if (!bool_2[0])
			{
				control8_3.method_5(method_11);
			}
			Form23.smethod_8(method_26);
		}
		catch
		{
			@class?.method_4();
			string text = Class333.smethod_2644();
			if ((themedComboBox_1.Visible && themedComboBox_1.SelectedIndex == -1) || (themedComboBox_2.Visible && themedComboBox_2.SelectedIndex == -1) || (themedComboBox_3.Visible && themedComboBox_3.SelectedIndex == -1))
			{
				text += Class333.smethod_2645();
			}
			else if (flag)
			{
				text += Class333.smethod_2646();
			}
			else if ((class148_1.Visible && class148_1.Checked && num == 0) || (class148_2.Visible && class148_2.Checked && num2 == 0) || (class148_3.Visible && class148_3.Checked && num3 == 0))
			{
				text += Class333.smethod_2647();
			}
			Form54.smethod_6(this, text, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			e.Cancel = true;
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

	private void method_27()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form51));
		class148_1 = new Class148();
		class148_2 = new Class148();
		class148_3 = new Class148();
		themedButton_4 = new ThemedButton();
		themedButton_5 = new ThemedButton();
		dataGridViewWithThemedScrollBars_1 = new DataGridViewWithThemedScrollBars();
		dataGridViewWithThemedScrollBars_2 = new DataGridViewWithThemedScrollBars();
		dataGridViewWithThemedScrollBars_3 = new DataGridViewWithThemedScrollBars();
		label_5 = new Label();
		label_6 = new Label();
		label_7 = new Label();
		label_8 = new Label();
		label_9 = new Label();
		label_10 = new Label();
		themedButton_6 = new ThemedButton();
		themedButton_7 = new ThemedButton();
		themedButton_8 = new ThemedButton();
		themedButton_9 = new ThemedButton();
		themedButton_10 = new ThemedButton();
		themedButton_11 = new ThemedButton();
		themedButton_12 = new ThemedButton();
		themedButton_13 = new ThemedButton();
		themedButton_14 = new ThemedButton();
		pictureBox_2 = new PictureBox();
		pictureBox_3 = new PictureBox();
		pictureBox_4 = new PictureBox();
		label_11 = new Label();
		label_12 = new Label();
		label_13 = new Label();
		control8_3 = new Control8();
		control8_2 = new Control8();
		control8_1 = new Control8();
		themedComboBox_1 = new ThemedComboBox();
		themedComboBox_2 = new ThemedComboBox();
		themedComboBox_3 = new ThemedComboBox();
		label_14 = new Label();
		label_15 = new Label();
		label_16 = new Label();
		themedButton_15 = new ThemedButton();
		themedButton_16 = new ThemedButton();
		themedButton_17 = new ThemedButton();
		pictureBox_5 = new PictureBox();
		pictureBox_6 = new PictureBox();
		pictureBox_7 = new PictureBox();
		((ISupportInitialize)dataGridViewWithThemedScrollBars_1).BeginInit();
		((ISupportInitialize)dataGridViewWithThemedScrollBars_2).BeginInit();
		((ISupportInitialize)dataGridViewWithThemedScrollBars_3).BeginInit();
		((ISupportInitialize)pictureBox_2).BeginInit();
		((ISupportInitialize)pictureBox_3).BeginInit();
		((ISupportInitialize)pictureBox_4).BeginInit();
		((ISupportInitialize)pictureBox_5).BeginInit();
		((ISupportInitialize)pictureBox_6).BeginInit();
		((ISupportInitialize)pictureBox_7).BeginInit();
		SuspendLayout();
		class148_1.AutoSize = true;
		class148_1.Location = new Point(11, 27);
		class148_1.Name = Class333.smethod_2648();
		class148_1.Size = new Size(84, 17);
		class148_1.TabIndex = 0;
		class148_1.Text = Class333.smethod_2649();
		class148_1.UseVisualStyleBackColor = true;
		class148_1.CheckedChanged += class148_1_CheckedChanged;
		class148_2.AutoSize = true;
		class148_2.Location = new Point(11, 177);
		class148_2.Name = Class333.smethod_2650();
		class148_2.Size = new Size(84, 17);
		class148_2.TabIndex = 8;
		class148_2.Text = Class333.smethod_2649();
		class148_2.UseVisualStyleBackColor = true;
		class148_2.CheckedChanged += class148_2_CheckedChanged;
		class148_3.AutoSize = true;
		class148_3.Location = new Point(11, 327);
		class148_3.Name = Class333.smethod_2651();
		class148_3.Size = new Size(84, 17);
		class148_3.TabIndex = 16;
		class148_3.Text = Class333.smethod_2649();
		class148_3.UseVisualStyleBackColor = true;
		class148_3.CheckedChanged += class148_3_CheckedChanged;
		themedButton_4.DialogResult = DialogResult.OK;
		themedButton_4.Location = new Point(581, 464);
		themedButton_4.Name = Class333.smethod_829();
		themedButton_4.Size = new Size(93, 30);
		themedButton_4.TabIndex = 24;
		themedButton_4.Text = Class333.smethod_821();
		themedButton_4.UseVisualStyleBackColor = true;
		themedButton_5.DialogResult = DialogResult.Cancel;
		themedButton_5.Location = new Point(680, 464);
		themedButton_5.Name = Class333.smethod_830();
		themedButton_5.Size = new Size(92, 30);
		themedButton_5.TabIndex = 25;
		themedButton_5.Text = Class333.smethod_823();
		themedButton_5.UseVisualStyleBackColor = true;
		dataGridViewWithThemedScrollBars_1.AllowUserToAddRows = false;
		dataGridViewWithThemedScrollBars_1.AllowUserToDeleteRows = false;
		dataGridViewWithThemedScrollBars_1.AllowUserToResizeColumns = false;
		dataGridViewWithThemedScrollBars_1.AllowUserToResizeRows = false;
		dataGridViewWithThemedScrollBars_1.BackgroundColor = Color.White;
		dataGridViewWithThemedScrollBars_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewWithThemedScrollBars_1.ColumnHeadersVisible = false;
		dataGridViewWithThemedScrollBars_1.Location = new Point(14, 68);
		dataGridViewWithThemedScrollBars_1.Name = Class333.smethod_2652();
		dataGridViewWithThemedScrollBars_1.ReadOnly = true;
		dataGridViewWithThemedScrollBars_1.RowHeadersVisible = false;
		dataGridViewWithThemedScrollBars_1.ScrollBars = ScrollBars.Horizontal;
		dataGridViewWithThemedScrollBars_1.ShowCellToolTips = false;
		dataGridViewWithThemedScrollBars_1.Size = new Size(758, 65);
		dataGridViewWithThemedScrollBars_1.TabIndex = 7;
		dataGridViewWithThemedScrollBars_1.Click += Form51_Click;
		dataGridViewWithThemedScrollBars_1.KeyDown += dataGridViewWithThemedScrollBars_1_KeyDown;
		dataGridViewWithThemedScrollBars_2.AllowUserToAddRows = false;
		dataGridViewWithThemedScrollBars_2.AllowUserToDeleteRows = false;
		dataGridViewWithThemedScrollBars_2.AllowUserToResizeColumns = false;
		dataGridViewWithThemedScrollBars_2.AllowUserToResizeRows = false;
		dataGridViewWithThemedScrollBars_2.BackgroundColor = Color.White;
		dataGridViewWithThemedScrollBars_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewWithThemedScrollBars_2.ColumnHeadersVisible = false;
		dataGridViewWithThemedScrollBars_2.Location = new Point(14, 218);
		dataGridViewWithThemedScrollBars_2.Name = Class333.smethod_2653();
		dataGridViewWithThemedScrollBars_2.ReadOnly = true;
		dataGridViewWithThemedScrollBars_2.RowHeadersVisible = false;
		dataGridViewWithThemedScrollBars_2.ScrollBars = ScrollBars.Horizontal;
		dataGridViewWithThemedScrollBars_2.ShowCellToolTips = false;
		dataGridViewWithThemedScrollBars_2.Size = new Size(758, 65);
		dataGridViewWithThemedScrollBars_2.TabIndex = 15;
		dataGridViewWithThemedScrollBars_2.Click += Form51_Click;
		dataGridViewWithThemedScrollBars_2.KeyDown += dataGridViewWithThemedScrollBars_2_KeyDown;
		dataGridViewWithThemedScrollBars_3.AllowUserToAddRows = false;
		dataGridViewWithThemedScrollBars_3.AllowUserToDeleteRows = false;
		dataGridViewWithThemedScrollBars_3.AllowUserToResizeColumns = false;
		dataGridViewWithThemedScrollBars_3.AllowUserToResizeRows = false;
		dataGridViewWithThemedScrollBars_3.BackgroundColor = Color.White;
		dataGridViewWithThemedScrollBars_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewWithThemedScrollBars_3.ColumnHeadersVisible = false;
		dataGridViewWithThemedScrollBars_3.Location = new Point(14, 368);
		dataGridViewWithThemedScrollBars_3.Name = Class333.smethod_2654();
		dataGridViewWithThemedScrollBars_3.ReadOnly = true;
		dataGridViewWithThemedScrollBars_3.RowHeadersVisible = false;
		dataGridViewWithThemedScrollBars_3.ScrollBars = ScrollBars.Horizontal;
		dataGridViewWithThemedScrollBars_3.ShowCellToolTips = false;
		dataGridViewWithThemedScrollBars_3.Size = new Size(758, 65);
		dataGridViewWithThemedScrollBars_3.TabIndex = 23;
		dataGridViewWithThemedScrollBars_3.Click += Form51_Click;
		dataGridViewWithThemedScrollBars_3.KeyDown += dataGridViewWithThemedScrollBars_3_KeyDown;
		label_5.AutoSize = true;
		label_5.Location = new Point(18, 202);
		label_5.Name = Class333.smethod_2655();
		label_5.Size = new Size(43, 13);
		label_5.TabIndex = 11;
		label_5.Text = Class333.smethod_2656();
		label_6.AutoSize = true;
		label_6.Location = new Point(18, 352);
		label_6.Name = Class333.smethod_2657();
		label_6.Size = new Size(43, 13);
		label_6.TabIndex = 12;
		label_6.Text = Class333.smethod_2656();
		label_7.AutoSize = true;
		label_7.Location = new Point(18, 52);
		label_7.Name = Class333.smethod_2658();
		label_7.Size = new Size(43, 13);
		label_7.TabIndex = 13;
		label_7.Text = Class333.smethod_2656();
		label_8.AutoSize = true;
		label_8.Location = new Point(655, 52);
		label_8.Name = Class333.smethod_2659();
		label_8.Size = new Size(98, 13);
		label_8.TabIndex = 14;
		label_8.Text = Class333.smethod_2660();
		label_9.AutoSize = true;
		label_9.Location = new Point(655, 352);
		label_9.Name = Class333.smethod_2661();
		label_9.Size = new Size(98, 13);
		label_9.TabIndex = 15;
		label_9.Text = Class333.smethod_2660();
		label_10.AutoSize = true;
		label_10.Location = new Point(655, 202);
		label_10.Name = Class333.smethod_2662();
		label_10.Size = new Size(98, 13);
		label_10.TabIndex = 16;
		label_10.Text = Class333.smethod_2660();
		themedButton_6.Location = new Point(425, 23);
		themedButton_6.Name = Class333.smethod_2663();
		themedButton_6.Size = new Size(75, 23);
		themedButton_6.TabIndex = 3;
		themedButton_6.Text = Class333.smethod_2639();
		themedButton_6.UseVisualStyleBackColor = true;
		themedButton_6.Click += themedButton_6_Click;
		themedButton_7.Location = new Point(502, 23);
		themedButton_7.Name = Class333.smethod_2664();
		themedButton_7.Size = new Size(85, 23);
		themedButton_7.TabIndex = 4;
		themedButton_7.Text = Class333.smethod_2665();
		themedButton_7.UseVisualStyleBackColor = true;
		themedButton_7.Click += themedButton_7_Click;
		themedButton_8.Location = new Point(589, 23);
		themedButton_8.Name = Class333.smethod_2666();
		themedButton_8.Size = new Size(65, 23);
		themedButton_8.TabIndex = 5;
		themedButton_8.Text = Class333.smethod_2667();
		themedButton_8.UseVisualStyleBackColor = true;
		themedButton_8.Click += themedButton_8_Click;
		themedButton_9.Location = new Point(589, 173);
		themedButton_9.Name = Class333.smethod_2668();
		themedButton_9.Size = new Size(65, 23);
		themedButton_9.TabIndex = 13;
		themedButton_9.Text = Class333.smethod_2667();
		themedButton_9.UseVisualStyleBackColor = true;
		themedButton_9.Click += themedButton_9_Click;
		themedButton_10.Location = new Point(502, 173);
		themedButton_10.Name = Class333.smethod_2669();
		themedButton_10.Size = new Size(85, 23);
		themedButton_10.TabIndex = 12;
		themedButton_10.Text = Class333.smethod_2665();
		themedButton_10.UseVisualStyleBackColor = true;
		themedButton_10.Click += themedButton_10_Click;
		themedButton_11.Location = new Point(425, 173);
		themedButton_11.Name = Class333.smethod_2670();
		themedButton_11.Size = new Size(75, 23);
		themedButton_11.TabIndex = 11;
		themedButton_11.Text = Class333.smethod_2639();
		themedButton_11.UseVisualStyleBackColor = true;
		themedButton_11.Click += themedButton_11_Click;
		themedButton_12.Location = new Point(589, 323);
		themedButton_12.Name = Class333.smethod_2671();
		themedButton_12.Size = new Size(65, 23);
		themedButton_12.TabIndex = 21;
		themedButton_12.Text = Class333.smethod_2667();
		themedButton_12.UseVisualStyleBackColor = true;
		themedButton_12.Click += themedButton_12_Click;
		themedButton_13.Location = new Point(502, 323);
		themedButton_13.Name = Class333.smethod_2672();
		themedButton_13.Size = new Size(85, 23);
		themedButton_13.TabIndex = 20;
		themedButton_13.Text = Class333.smethod_2665();
		themedButton_13.UseVisualStyleBackColor = true;
		themedButton_13.Click += themedButton_13_Click;
		themedButton_14.Location = new Point(425, 323);
		themedButton_14.Name = Class333.smethod_2673();
		themedButton_14.Size = new Size(75, 23);
		themedButton_14.TabIndex = 19;
		themedButton_14.Text = Class333.smethod_2639();
		themedButton_14.UseVisualStyleBackColor = true;
		themedButton_14.Click += themedButton_14_Click;
		pictureBox_2.Image = (Image)componentResourceManager.GetObject(Class333.smethod_2674());
		pictureBox_2.Location = new Point(337, 19);
		pictureBox_2.Margin = new Padding(0);
		pictureBox_2.Name = Class333.smethod_2675();
		pictureBox_2.Size = new Size(32, 32);
		pictureBox_2.TabIndex = 26;
		pictureBox_2.TabStop = false;
		pictureBox_2.Visible = false;
		pictureBox_3.Image = (Image)componentResourceManager.GetObject(Class333.smethod_2676());
		pictureBox_3.Location = new Point(337, 169);
		pictureBox_3.Margin = new Padding(0);
		pictureBox_3.Name = Class333.smethod_2677();
		pictureBox_3.Size = new Size(32, 32);
		pictureBox_3.TabIndex = 27;
		pictureBox_3.TabStop = false;
		pictureBox_3.Visible = false;
		pictureBox_4.Image = (Image)componentResourceManager.GetObject(Class333.smethod_2678());
		pictureBox_4.Location = new Point(337, 319);
		pictureBox_4.Margin = new Padding(0);
		pictureBox_4.Name = Class333.smethod_2679();
		pictureBox_4.Size = new Size(32, 32);
		pictureBox_4.TabIndex = 28;
		pictureBox_4.TabStop = false;
		pictureBox_4.Visible = false;
		label_11.AutoSize = true;
		label_11.ForeColor = Color.Black;
		label_11.Location = new Point(103, 47);
		label_11.Name = Class333.smethod_2680();
		label_11.Size = new Size(224, 13);
		label_11.TabIndex = 29;
		label_11.Text = Class333.smethod_2681();
		label_11.Visible = false;
		label_12.AutoSize = true;
		label_12.ForeColor = Color.Black;
		label_12.Location = new Point(103, 197);
		label_12.Name = Class333.smethod_2682();
		label_12.Size = new Size(224, 13);
		label_12.TabIndex = 30;
		label_12.Text = Class333.smethod_2681();
		label_12.Visible = false;
		label_13.AutoSize = true;
		label_13.ForeColor = Color.Black;
		label_13.Location = new Point(103, 347);
		label_13.Name = Class333.smethod_2683();
		label_13.Size = new Size(224, 13);
		label_13.TabIndex = 31;
		label_13.Text = Class333.smethod_2681();
		label_13.Visible = false;
		control8_3.AutoSize = true;
		control8_3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		control8_3.Font = new Font(Class333.smethod_145(), 8f);
		control8_3.Location = new Point(98, 323);
		control8_3.Name = Class333.smethod_2684();
		control8_3.Size = new Size(232, 23);
		control8_3.TabIndex = 17;
		control8_2.AutoSize = true;
		control8_2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		control8_2.Font = new Font(Class333.smethod_145(), 8f);
		control8_2.Location = new Point(98, 173);
		control8_2.Name = Class333.smethod_2685();
		control8_2.Size = new Size(232, 23);
		control8_2.TabIndex = 9;
		control8_1.AutoSize = true;
		control8_1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		control8_1.Font = new Font(Class333.smethod_145(), 8f);
		control8_1.Location = new Point(98, 23);
		control8_1.Name = Class333.smethod_2686();
		control8_1.Size = new Size(232, 23);
		control8_1.TabIndex = 1;
		themedComboBox_1.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_1.FormattingEnabled = true;
		themedComboBox_1.Location = new Point(658, 24);
		themedComboBox_1.Name = Class333.smethod_2687();
		themedComboBox_1.Size = new Size(116, 23);
		themedComboBox_1.TabIndex = 6;
		themedComboBox_1.Click += Form51_Click;
		themedComboBox_2.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_2.FormattingEnabled = true;
		themedComboBox_2.Location = new Point(658, 174);
		themedComboBox_2.Name = Class333.smethod_2688();
		themedComboBox_2.Size = new Size(116, 23);
		themedComboBox_2.TabIndex = 14;
		themedComboBox_2.Click += Form51_Click;
		themedComboBox_3.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_3.FormattingEnabled = true;
		themedComboBox_3.Location = new Point(658, 324);
		themedComboBox_3.Name = Class333.smethod_2689();
		themedComboBox_3.Size = new Size(116, 23);
		themedComboBox_3.TabIndex = 22;
		themedComboBox_3.Click += Form51_Click;
		label_14.AutoSize = true;
		label_14.Location = new Point(666, 159);
		label_14.Name = Class333.smethod_2690();
		label_14.Size = new Size(84, 13);
		label_14.TabIndex = 35;
		label_14.Text = Class333.smethod_2691();
		label_15.AutoSize = true;
		label_15.Location = new Point(666, 309);
		label_15.Name = Class333.smethod_2692();
		label_15.Size = new Size(84, 13);
		label_15.TabIndex = 36;
		label_15.Text = Class333.smethod_2691();
		label_16.AutoSize = true;
		label_16.Location = new Point(666, 9);
		label_16.Name = Class333.smethod_2693();
		label_16.Size = new Size(84, 13);
		label_16.TabIndex = 37;
		label_16.Text = Class333.smethod_2691();
		themedButton_15.Location = new Point(368, 23);
		themedButton_15.Name = Class333.smethod_2694();
		themedButton_15.Size = new Size(55, 23);
		themedButton_15.TabIndex = 2;
		themedButton_15.Text = Class333.smethod_2695();
		themedButton_15.UseVisualStyleBackColor = true;
		themedButton_15.Click += themedButton_15_Click;
		themedButton_16.Location = new Point(368, 173);
		themedButton_16.Name = Class333.smethod_2696();
		themedButton_16.Size = new Size(55, 23);
		themedButton_16.TabIndex = 10;
		themedButton_16.Text = Class333.smethod_2695();
		themedButton_16.UseVisualStyleBackColor = true;
		themedButton_16.Click += themedButton_16_Click;
		themedButton_17.Location = new Point(368, 323);
		themedButton_17.Name = Class333.smethod_2697();
		themedButton_17.Size = new Size(55, 23);
		themedButton_17.TabIndex = 18;
		themedButton_17.Text = Class333.smethod_2695();
		themedButton_17.UseVisualStyleBackColor = true;
		themedButton_17.Click += themedButton_17_Click;
		pictureBox_5.BackColor = Color.Transparent;
		pictureBox_5.Image = (Image)componentResourceManager.GetObject(Class333.smethod_2698());
		pictureBox_5.Location = new Point(753, 4);
		pictureBox_5.Margin = new Padding(0);
		pictureBox_5.Name = Class333.smethod_2699();
		pictureBox_5.Size = new Size(18, 18);
		pictureBox_5.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox_5.TabIndex = 41;
		pictureBox_5.TabStop = false;
		pictureBox_5.Click += pictureBox_5_Click;
		pictureBox_6.BackColor = Color.Transparent;
		pictureBox_6.Image = (Image)componentResourceManager.GetObject(Class333.smethod_2700());
		pictureBox_6.Location = new Point(753, 154);
		pictureBox_6.Margin = new Padding(0);
		pictureBox_6.Name = Class333.smethod_2701();
		pictureBox_6.Size = new Size(18, 18);
		pictureBox_6.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox_6.TabIndex = 42;
		pictureBox_6.TabStop = false;
		pictureBox_6.Click += pictureBox_6_Click;
		pictureBox_7.BackColor = Color.Transparent;
		pictureBox_7.Image = (Image)componentResourceManager.GetObject(Class333.smethod_2702());
		pictureBox_7.Location = new Point(753, 304);
		pictureBox_7.Margin = new Padding(0);
		pictureBox_7.Name = Class333.smethod_2703();
		pictureBox_7.Size = new Size(18, 18);
		pictureBox_7.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox_7.TabIndex = 43;
		pictureBox_7.TabStop = false;
		pictureBox_7.Click += pictureBox_7_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_5;
		ClientSize = new Size(784, 502);
		Controls.Add(pictureBox_7);
		Controls.Add(pictureBox_6);
		Controls.Add(pictureBox_5);
		Controls.Add(themedButton_17);
		Controls.Add(themedButton_16);
		Controls.Add(themedButton_15);
		Controls.Add(label_16);
		Controls.Add(label_15);
		Controls.Add(label_14);
		Controls.Add(themedComboBox_3);
		Controls.Add(themedComboBox_2);
		Controls.Add(themedComboBox_1);
		Controls.Add(label_13);
		Controls.Add(label_12);
		Controls.Add(label_11);
		Controls.Add(pictureBox_4);
		Controls.Add(pictureBox_3);
		Controls.Add(pictureBox_2);
		Controls.Add(themedButton_12);
		Controls.Add(themedButton_13);
		Controls.Add(themedButton_14);
		Controls.Add(themedButton_9);
		Controls.Add(themedButton_10);
		Controls.Add(themedButton_11);
		Controls.Add(themedButton_8);
		Controls.Add(themedButton_7);
		Controls.Add(themedButton_6);
		Controls.Add(label_10);
		Controls.Add(label_9);
		Controls.Add(label_8);
		Controls.Add(label_7);
		Controls.Add(label_6);
		Controls.Add(label_5);
		Controls.Add(dataGridViewWithThemedScrollBars_3);
		Controls.Add(dataGridViewWithThemedScrollBars_2);
		Controls.Add(dataGridViewWithThemedScrollBars_1);
		Controls.Add(themedButton_5);
		Controls.Add(themedButton_4);
		Controls.Add(class148_3);
		Controls.Add(class148_2);
		Controls.Add(class148_1);
		Controls.Add(control8_3);
		Controls.Add(control8_2);
		Controls.Add(control8_1);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2704();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1570();
		FormClosing += Form51_FormClosing;
		Shown += Form51_Shown;
		Click += Form51_Click;
		((ISupportInitialize)dataGridViewWithThemedScrollBars_1).EndInit();
		((ISupportInitialize)dataGridViewWithThemedScrollBars_2).EndInit();
		((ISupportInitialize)dataGridViewWithThemedScrollBars_3).EndInit();
		((ISupportInitialize)pictureBox_2).EndInit();
		((ISupportInitialize)pictureBox_3).EndInit();
		((ISupportInitialize)pictureBox_4).EndInit();
		((ISupportInitialize)pictureBox_5).EndInit();
		((ISupportInitialize)pictureBox_6).EndInit();
		((ISupportInitialize)pictureBox_7).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
