using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns2;

internal class Control7 : UserControl
{
	private delegate void Delegate43(object sender, EventArgs e);

	private delegate void Delegate44(object sender, EventArgs e);

	private delegate void Delegate45(object sender, EventArgs e);

	private delegate void Delegate46(object sender, EventArgs e);

	private delegate void Delegate47(object sender, EventArgs e);

	private Framework framework_0;

	private Framework framework_1;

	private ConditionalActivator conditionalActivator_0;

	private Setting setting_0;

	private Setting setting_1;

	private Setting setting_2;

	private string string_0;

	private Setting setting_3;

	private Setting setting_4;

	private Setting setting_5;

	private Setting setting_6;

	private Setting setting_7;

	private Setting setting_8;

	private Setting setting_9;

	private bool bool_0;

	private Class148 class148_0 = new Class148();

	private Control8 control8_0 = new Control8();

	private Label label_0 = new Label();

	private ThemedComboBox themedComboBox_0 = new ThemedComboBox();

	private ThemedTextBox themedTextBox_0 = new ThemedTextBox();

	private ThemedComboBox themedComboBox_1 = new ThemedComboBox();

	private Label label_1 = new Label();

	private PictureBox pictureBox_0 = new PictureBox();

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	internal Control7(ConditionalActivator conditionalActivator_1, Framework framework_2, Framework framework_3)
	{
		method_0(conditionalActivator_1, framework_2, framework_3);
	}

	private void method_0(ConditionalActivator conditionalActivator_1, Framework framework_2, Framework framework_3)
	{
		framework_0 = framework_2;
		framework_1 = framework_3;
		conditionalActivator_0 = conditionalActivator_1;
		control8_0.method_0(framework_0);
		if (conditionalActivator_0.EnablerSettingId != 0)
		{
			setting_0 = framework_0.method_31(conditionalActivator_0.EnablerSettingId);
		}
		setting_1 = framework_0.method_31(conditionalActivator_0.ChannelSettingId);
		setting_2 = framework_0.method_31(setting_1.method_256());
		string_0 = conditionalActivator_0.JoinText;
		setting_3 = framework_0.method_31(conditionalActivator_0.OperatorSettingId);
		setting_4 = framework_0.method_31(conditionalActivator_0.ThresholdSettingId);
		if (framework_1 != null)
		{
			if (setting_0 != null)
			{
				setting_5 = framework_1.method_31(setting_0.method_64());
			}
			if (setting_1 != null)
			{
				setting_6 = framework_1.method_31(setting_1.method_64());
			}
			if (setting_6 != null)
			{
				setting_7 = framework_1.method_31(setting_6.method_256());
			}
			if (setting_3 != null)
			{
				setting_8 = framework_1.method_31(setting_3.method_64());
			}
			if (setting_4 != null)
			{
				setting_9 = framework_1.method_31(setting_4.method_64());
			}
		}
		bool_1 = framework_0.method_2() && framework_0.method_3() && ((setting_0 != null && setting_0.method_96()) || (setting_1 != null && setting_1.method_96()) || (setting_3 != null && setting_3.method_96()) || (setting_4 != null && setting_4.method_96()));
		bool_2 = framework_1 != null && framework_1.method_2() && framework_1.method_3() && ((setting_5 != null && setting_5.method_96()) || (setting_6 != null && setting_6.method_96()) || (setting_8 != null && setting_8.method_96()) || (setting_9 != null && setting_9.method_96()));
		bool flag = ((Form23.enum60_0 != Form23.Enum60.BpG || framework_1 == null) ? bool_1 : bool_2);
		Form23.form23_0.method_9(method_7);
		bool_0 = false;
		if (setting_0 != null)
		{
			setting_0.method_264(method_16);
			setting_0.method_40(method_9);
		}
		if (setting_1 != null)
		{
			setting_1.method_264(method_17);
			setting_1.method_40(method_9);
		}
		if (setting_3 != null)
		{
			setting_3.method_264(method_18);
		}
		if (setting_4 != null)
		{
			setting_4.method_264(method_14);
			setting_4.method_40(method_9);
		}
		SuspendLayout();
		bool flag2 = Form23.enum60_0 == Form23.Enum60.BpF && (bool_1 || bool_2) && framework_1 != null;
		if (flag | flag2)
		{
			Label label = new Label();
			if (flag2)
			{
				label.Text = Class333.smethod_603();
			}
			else
			{
				label.Text = Class333.smethod_604();
			}
			label.ForeColor = Form23.color_12;
			label.Left = 0;
			label.Top = 2;
			label.AutoSize = true;
			Controls.Add(label);
			AutoSize = false;
			Height = control8_0.Height;
			Width = 800;
		}
		else
		{
			if (setting_0 != null)
			{
				class148_0.Text = Class333.smethod_420();
				if (Form23.enum60_0 == Form23.Enum60.BpG && setting_5 != null)
				{
					class148_0.bool_0 = true;
					class148_0.Checked = setting_5.method_256() != 0;
				}
				else
				{
					class148_0.bool_0 = false;
					class148_0.Checked = setting_0.method_256() != 0;
				}
				class148_0.Left = 0;
				class148_0.Top = 1;
				class148_0.Width = 70;
				class148_0.CheckedChanged += class148_0_CheckedChanged;
				Controls.Add(class148_0);
			}
			control8_0.method_4(method_10);
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				if (setting_7 == null)
				{
					control8_0.method_2(0);
				}
				else
				{
					control8_0.method_2(setting_7.method_64());
				}
			}
			else if (setting_2 == null)
			{
				control8_0.method_2(0);
			}
			else
			{
				control8_0.method_2(setting_2.method_64());
			}
			if (setting_0 == null)
			{
				control8_0.Left = 0;
			}
			else
			{
				control8_0.Left = class148_0.Right + 5;
			}
			control8_0.Top = 0;
			Controls.Add(control8_0);
			label_0.Text = string_0;
			label_0.ForeColor = Form23.color_12;
			label_0.Left = control8_0.Right + 5;
			label_0.Top = 3;
			label_0.Height = 16;
			label_0.Width = 15;
			Controls.Add(label_0);
			method_8();
			themedComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			themedComboBox_0.Left = label_0.Right + 5;
			themedComboBox_0.Top = 0;
			themedComboBox_0.Width = 180;
			themedComboBox_0.SelectedIndexChanged += themedComboBox_0_SelectedIndexChanged;
			Controls.Add(themedComboBox_0);
			themedTextBox_0.Left = themedComboBox_0.Right + 5;
			themedTextBox_0.Top = 0;
			themedTextBox_0.Width = 180;
			themedTextBox_0.GotFocus += themedTextBox_0_GotFocus;
			themedTextBox_0.KeyDown += themedComboBox_1_KeyDown;
			themedTextBox_0.KeyPress += themedComboBox_1_KeyPress;
			themedTextBox_0.Leave += themedComboBox_1_Leave;
			Controls.Add(themedTextBox_0);
			themedComboBox_1.DropDownStyle = ComboBoxStyle.DropDown;
			themedComboBox_1.GotFocus += themedComboBox_1_GotFocus;
			themedComboBox_1.SelectedIndexChanged += themedComboBox_1_SelectedIndexChanged;
			themedComboBox_1.Left = themedComboBox_0.Right + 5;
			themedComboBox_1.Top = 0;
			themedComboBox_1.Width = 180;
			themedComboBox_1.KeyDown += themedComboBox_1_KeyDown;
			themedComboBox_1.KeyPress += themedComboBox_1_KeyPress;
			themedComboBox_1.Leave += themedComboBox_1_Leave;
			Controls.Add(themedComboBox_1);
			themedComboBox_1.Items.Clear();
			Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG) ? setting_2 : setting_7);
			themedComboBox_1.Items.Clear();
			if (setting != null && setting.method_102().Count != 0)
			{
				List<Setting.ListItems.Struct45> list = setting.method_102();
				int num = 0;
				string[] array = new string[list.Count];
				using (Graphics dc = CreateGraphics())
				{
					for (int i = 0; i < list.Count; i++)
					{
						array[i] = list[i].bBV;
						num = Math.Max(TextRenderer.MeasureText(dc, array[i], themedComboBox_1.Font).Width, num);
					}
				}
				ComboBox.ObjectCollection items = themedComboBox_1.Items;
				object[] items2 = array;
				items.AddRange(items2);
				if (num > themedComboBox_1.DropDownWidth - 130)
				{
					themedComboBox_1.DropDownWidth = num + 130;
				}
				if (themedComboBox_1.Items.Count > 20)
				{
					themedComboBox_1.DropDownHeight = 360;
				}
				themedComboBox_1.Visible = true;
				themedTextBox_0.Visible = false;
			}
			else
			{
				themedTextBox_0.Visible = true;
				themedComboBox_1.Visible = false;
			}
			label_1.ForeColor = Form23.color_12;
			label_1.Left = themedTextBox_0.Right + 5;
			label_1.Top = 3;
			label_1.Height = 16;
			label_1.Width = 120;
			Controls.Add(label_1);
			pictureBox_0.Tag = setting_4;
			pictureBox_0.Width = 18;
			pictureBox_0.Height = 18;
			pictureBox_0.Left = label_1.Right;
			pictureBox_0.Top = 1;
			pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox_0.Click += pictureBox_0_Click;
			Controls.Add(pictureBox_0);
			pictureBox_0.Visible = false;
			themedTextBox_0.MouseEnter += pictureBox_0_MouseEnter;
			themedComboBox_1.MouseEnter += pictureBox_0_MouseEnter;
			label_1.MouseEnter += pictureBox_0_MouseEnter;
			pictureBox_0.MouseEnter += pictureBox_0_MouseEnter;
			MouseLeave += Control7_MouseLeave;
		}
		method_6();
		if (!flag && !flag2)
		{
			AutoSize = false;
			Height = control8_0.Height;
			Width = pictureBox_0.Right;
		}
		ResumeLayout(performLayout: true);
	}

	[SpecialName]
	internal Setting method_1()
	{
		return setting_3;
	}

	[SpecialName]
	internal Setting method_2()
	{
		return setting_4;
	}

	[SpecialName]
	internal ThemedComboBox method_3()
	{
		return themedComboBox_0;
	}

	[SpecialName]
	internal ThemedTextBox method_4()
	{
		return themedTextBox_0;
	}

	[SpecialName]
	internal ThemedComboBox method_5()
	{
		return themedComboBox_1;
	}

	private void pictureBox_0_MouseEnter(object sender, EventArgs e)
	{
		if (Form23.pictureBox_1 != pictureBox_0)
		{
			if (!Form23.bool_28 && Form23.pictureBox_1 != null)
			{
				Form23.pictureBox_1.Visible = false;
			}
			Form23.bool_28 = (setting_4.method_35() && !setting_4.method_122()) || (setting_1.method_35() && !setting_1.method_122());
			Form23.pictureBox_1 = pictureBox_0;
		}
		pictureBox_0.Visible = true;
	}

	private void Control7_MouseLeave(object sender, EventArgs e)
	{
		pictureBox_0.Visible = pictureBox_0.Image != null && ((setting_4.method_35() && !setting_4.method_122()) || (setting_1.method_35() && !setting_1.method_122()));
	}

	private void method_6()
	{
		bool flag = bool_1 || bool_2;
		if (setting_0 != null)
		{
			if (!flag && setting_5 != null && !setting_0.method_282(setting_5))
			{
				class148_0.ForeColor = Form23.color_9;
			}
			else
			{
				class148_0.ForeColor = Form23.color_12;
			}
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				class148_0.Enabled = false;
			}
			else
			{
				class148_0.Enabled = setting_0.method_35() && framework_0.method_4();
			}
		}
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			if (setting_7 != null)
			{
				if (themedTextBox_0.Visible)
				{
					themedTextBox_0.Text = method_12();
				}
				else if (themedComboBox_1.Visible)
				{
					themedComboBox_1.Text = method_12();
					List<Setting.ListItems.Struct45> list = setting_7.method_102();
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].bBV == themedComboBox_1.Text)
						{
							themedComboBox_1.SelectedIndex = i;
							break;
						}
					}
				}
			}
		}
		else if (setting_2 != null)
		{
			if (themedTextBox_0.Visible)
			{
				themedTextBox_0.Text = method_11();
			}
			else if (themedComboBox_1.Visible)
			{
				themedComboBox_1.Text = method_11();
				List<Setting.ListItems.Struct45> list2 = setting_2.method_102();
				for (int j = 0; j < list2.Count; j++)
				{
					if (list2[j].bBV == themedComboBox_1.Text)
					{
						themedComboBox_1.SelectedIndex = j;
						break;
					}
				}
			}
		}
		if (Form23.enum60_0 != Form23.Enum60.BpG && setting_4.method_35() && framework_0.method_4() && !setting_4.method_122())
		{
			themedTextBox_0.Enabled = true;
			themedComboBox_1.Enabled = true;
			switch (setting_4.method_124())
			{
			default:
				themedComboBox_1.BackColor = Color.Red;
				themedTextBox_0.BackColor = Color.Red;
				pictureBox_0.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Error:
				themedComboBox_1.BackColor = Color.Red;
				themedTextBox_0.BackColor = Color.Red;
				pictureBox_0.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Warning:
				themedComboBox_1.BackColor = Color.Orange;
				themedTextBox_0.BackColor = Color.Orange;
				pictureBox_0.Image = GeneralResources.YellowWarning;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (Form23.smethod_28(framework_0.aXc, bool_53: true))
				{
					themedComboBox_1.BackColor = Color.Red;
					themedTextBox_0.BackColor = Color.Red;
					pictureBox_0.Image = GeneralResources.RedError;
				}
				else
				{
					themedComboBox_1.BackColor = Color.Orange;
					themedTextBox_0.BackColor = Color.Orange;
					pictureBox_0.Image = GeneralResources.YellowWarning;
				}
				break;
			}
			pictureBox_0.Visible = true;
		}
		else
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				themedTextBox_0.Enabled = false;
				themedComboBox_1.Enabled = false;
			}
			else
			{
				themedTextBox_0.Enabled = setting_4.method_35() && framework_0.method_4();
				themedComboBox_1.Enabled = themedTextBox_0.Enabled;
			}
			if (setting_9 != null && !flag && !setting_4.method_282(setting_9))
			{
				themedComboBox_1.BackColor = Form23.color_9;
				themedTextBox_0.BackColor = Form23.color_9;
			}
			else if (themedTextBox_0.Enabled)
			{
				themedComboBox_1.BackColor = Form23.color_32;
				themedTextBox_0.BackColor = Form23.color_32;
			}
			else
			{
				themedComboBox_1.BackColor = Form23.color_35;
				themedTextBox_0.BackColor = Form23.color_35;
			}
			pictureBox_0.Visible = false;
			pictureBox_0.Image = GeneralResources.QuestionMark;
		}
		if (!themedTextBox_0.Enabled && !(themedTextBox_0.BackColor == Form23.color_9))
		{
			themedTextBox_0.ForeColor = Form23.color_36;
			themedComboBox_1.ForeColor = Form23.color_36;
		}
		else
		{
			themedTextBox_0.ForeColor = Form23.color_12;
			themedComboBox_1.ForeColor = Form23.color_12;
		}
		Control8 control = control8_0;
		Label label = label_0;
		ThemedComboBox themedComboBox = themedComboBox_0;
		bool flag2 = (label_1.Enabled = setting_3.method_35() && themedTextBox_0.Enabled && framework_0.method_4());
		bool flag4 = (themedComboBox.Enabled = flag2);
		bool enabled = (label.Enabled = flag4);
		control.Enabled = enabled;
		control8_0.method_1();
		if (Form23.enum60_0 != Form23.Enum60.BpG && control8_0.Enabled && framework_0.method_4() && !setting_1.method_122())
		{
			pictureBox_0.Image = GeneralResources.RedError;
			pictureBox_0.Visible = true;
		}
		if (themedComboBox_0.Enabled && !setting_3.method_122())
		{
			switch (setting_3.method_124())
			{
			default:
				themedComboBox_0.BackColor = Color.Red;
				break;
			case IllegalitySeverityLevel.Error:
				themedComboBox_0.BackColor = Color.Red;
				break;
			case IllegalitySeverityLevel.Warning:
				themedComboBox_0.BackColor = Color.Orange;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (Form23.smethod_28(framework_0.aXc, bool_53: true))
				{
					themedComboBox_0.BackColor = Color.Red;
				}
				else
				{
					themedComboBox_0.BackColor = Color.Orange;
				}
				break;
			}
		}
		else if (setting_8 != null && !flag && !setting_3.method_282(setting_8))
		{
			themedComboBox_0.BackColor = Form23.color_9;
		}
		else if (themedComboBox_0.Enabled)
		{
			themedComboBox_0.BackColor = Form23.color_32;
		}
		else
		{
			themedComboBox_0.BackColor = Form23.color_35;
		}
		if (!themedComboBox_0.Enabled && !(themedComboBox_0.BackColor == Form23.color_9))
		{
			themedComboBox_0.ForeColor = Form23.color_36;
		}
		else
		{
			themedComboBox_0.ForeColor = Form23.color_12;
		}
		themedComboBox_0.Invalidate();
		themedTextBox_0.Invalidate();
		themedComboBox_1.Invalidate();
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			if (setting_7 != null)
			{
				int int_ = setting_7.method_231();
				label_1.Text = Class233.smethod_35(setting_7.method_232(), int_, bool_0: false, 0);
			}
		}
		else if (setting_2 != null)
		{
			int int_2 = setting_2.method_231();
			label_1.Text = Class233.smethod_35(setting_2.method_232(), int_2, bool_0: false, 0);
		}
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		if (control8_0.Enabled && !setting_1.method_122())
		{
			Form23.smethod_50(setting_1, this);
		}
		else
		{
			Form23.smethod_50(setting_4, this);
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		if (!bool_1 && !bool_2)
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				if (setting_5 != null)
				{
					class148_0.bool_0 = true;
					if (class148_0.Checked != (setting_5.method_256() != 0))
					{
						class148_0.Checked = setting_5.method_256() != 0;
					}
				}
				if (setting_7 == null)
				{
					control8_0.method_2(0);
				}
				else
				{
					control8_0.method_2(setting_7.method_64());
				}
			}
			else
			{
				if (setting_0 != null)
				{
					class148_0.bool_0 = false;
					if (class148_0.Checked != (setting_0.method_256() != 0))
					{
						class148_0.Checked = setting_0.method_256() != 0;
					}
				}
				if (setting_2 == null)
				{
					control8_0.method_2(0);
				}
				else
				{
					control8_0.method_2(setting_2.method_64());
				}
			}
			method_8();
			method_6();
		}
		else
		{
			method_19();
			int width = Width;
			int height = Height;
			Parent.SuspendLayout();
			SuspendLayout();
			Controls.Clear();
			ResumeLayout(performLayout: true);
			method_0(conditionalActivator_0, framework_0, framework_1);
			if (!AutoSize)
			{
				Width = width;
				Height = height;
			}
			Parent.ResumeLayout(performLayout: true);
		}
	}

	private void method_8()
	{
		themedComboBox_0.Items.Clear();
		Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG) ? setting_3 : setting_8);
		int selectedIndex = -1;
		int num = setting.method_256();
		List<Setting.ListItems.Struct45> list = setting.method_102();
		for (int i = 0; i < list.Count; i++)
		{
			themedComboBox_0.Items.Add(list[i].bBV);
			if (list[i].bBv == num)
			{
				selectedIndex = i;
			}
		}
		themedComboBox_0.SelectedIndex = selectedIndex;
	}

	private void method_9(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate43 method = method_9;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_6();
	}

	private void method_10(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		if (setting_1.method_256() != control8_0.method_3())
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_3(setting_1.method_69());
			setting_1.method_272(control8_0.method_3(), bool_0: true);
			@class?.method_4();
		}
		themedComboBox_1.Items.Clear();
		if (setting_2 != null && setting_2.method_102().Count != 0)
		{
			List<Setting.ListItems.Struct45> list = setting_2.method_102();
			int num = 0;
			string[] array = new string[list.Count];
			using (Graphics dc = CreateGraphics())
			{
				for (int i = 0; i < list.Count; i++)
				{
					array[i] = list[i].bBV;
					num = Math.Max(TextRenderer.MeasureText(dc, array[i], themedComboBox_1.Font).Width, num);
				}
			}
			ComboBox.ObjectCollection items = themedComboBox_1.Items;
			object[] items2 = array;
			items.AddRange(items2);
			if (num > themedComboBox_1.DropDownWidth - 130)
			{
				themedComboBox_1.DropDownWidth = num + 130;
			}
			else
			{
				themedComboBox_1.DropDownWidth = themedComboBox_1.Width;
			}
			if (themedComboBox_1.Items.Count > 20)
			{
				themedComboBox_1.DropDownHeight = 360;
			}
			themedComboBox_1.Visible = true;
			themedTextBox_0.Visible = false;
		}
		else
		{
			themedTextBox_0.Visible = true;
			themedComboBox_1.Visible = false;
		}
		Form23.smethod_75(setting_1.method_69());
		method_6();
	}

	private void class148_0_CheckedChanged(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		CheckBox checkBox = sender as CheckBox;
		if ((!checkBox.Checked || setting_0.method_256() != 1) && (checkBox.Checked || setting_0.method_256() != 0))
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_3(setting_0.method_69());
			if (checkBox.Checked)
			{
				setting_0.method_272(1, bool_0: true);
			}
			else
			{
				setting_0.method_272(0, bool_0: true);
			}
			@class?.method_4();
			Form23.smethod_75(setting_0.method_69());
		}
	}

	private void themedComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			int selectedIndex = themedComboBox_0.SelectedIndex;
			if (selectedIndex != -1 && setting_3.method_256() != setting_3.method_102()[selectedIndex].bBv)
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_3(setting_3.method_69());
				setting_3.method_272(setting_3.method_102()[selectedIndex].bBv, bool_0: true);
				@class?.method_4();
				Form23.smethod_75(setting_3.method_69());
			}
		}
	}

	private string method_11()
	{
		if (setting_2 == null)
		{
			return string.Empty;
		}
		int int_ = setting_4.method_256();
		return setting_2.method_253(int_).DisplayValueString;
	}

	private string method_12()
	{
		if (setting_7 == null)
		{
			return string.Empty;
		}
		int int_ = setting_9.method_256();
		return setting_7.method_253(int_).DisplayValueString;
	}

	private void themedComboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG && setting_2 != null && themedComboBox_1.SelectedIndex != -1 && setting_4.method_256() != setting_2.method_102()[themedComboBox_1.SelectedIndex].bBv)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_3(setting_4.method_69());
			setting_4.method_272(setting_2.method_102()[themedComboBox_1.SelectedIndex].bBv, bool_0: true);
			@class?.method_4();
			Form23.smethod_75(setting_4.method_69());
		}
	}

	internal void method_13()
	{
		if (themedTextBox_0.Disposing || themedComboBox_1.Disposing || Form23.bool_2 || Form23.bool_35 || Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		string text = string.Empty;
		if (themedTextBox_0.Visible)
		{
			text = themedTextBox_0.Text;
		}
		else if (themedComboBox_1.Visible)
		{
			text = themedComboBox_1.Text;
		}
		bool_0 = false;
		string text2 = method_11();
		if (text2 == text)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(text))
		{
			if (themedTextBox_0.Visible)
			{
				themedTextBox_0.Text = text2;
			}
			else if (themedComboBox_1.Visible)
			{
				themedComboBox_1.Text = text2;
			}
			return;
		}
		try
		{
			int num = Class233.smethod_25(text, setting_2.method_231());
			if (setting_4.method_199() == 2)
			{
				if (setting_4.method_201())
				{
					if (num < -32768)
					{
						num = -32768;
					}
					else if (num > 32767)
					{
						num = 32767;
					}
				}
				else if (num < 0)
				{
					num = 0;
				}
				else if (num > 65535)
				{
					num = 65535;
				}
			}
			else if (setting_4.method_199() == 1)
			{
				if (setting_4.method_201())
				{
					if (num < -128)
					{
						num = -128;
					}
					else if (num > 127)
					{
						num = 127;
					}
				}
				else if (num < 0)
				{
					num = 0;
				}
				else if (num > 255)
				{
					num = 255;
				}
			}
			int num2 = setting_2.method_228();
			int num3 = setting_2.method_229();
			if (num2 != 0 || num3 != 0)
			{
				num = Math.Min(Math.Max(num, num2), num3);
			}
			Class280 @class = Form23.smethod_95();
			@class?.method_3(setting_4.method_69());
			setting_4.method_272(num, bool_0: true);
			@class?.method_4();
			Form23.smethod_75(setting_4.method_69());
		}
		catch
		{
			Form54.smethod_6(Form23.form23_0, Class333.smethod_605(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void themedTextBox_0_GotFocus(object sender, EventArgs e)
	{
		Form23.form23_0.control4_0.method_59(setting_4);
		if (framework_1 != null && themedTextBox_0.BackColor == Form23.color_9)
		{
			Form23.smethod_50(setting_4, this);
		}
	}

	private void themedComboBox_1_GotFocus(object sender, EventArgs e)
	{
		Form23.form23_0.control4_0.method_59(setting_4);
		themedComboBox_1.SelectAll();
		if (framework_1 != null && themedComboBox_1.BackColor == Form23.color_9)
		{
			Form23.smethod_50(setting_4, this);
		}
	}

	private void themedComboBox_1_KeyDown(object sender, KeyEventArgs e)
	{
		if ((!e.Control || e.KeyCode != Keys.Prior) && e.KeyData != Keys.Prior && (!e.Shift || e.KeyCode != Keys.Prior) && (!e.Control || e.KeyCode != Keys.Next) && e.KeyData != Keys.Next && (!e.Shift || e.KeyCode != Keys.Next))
		{
			if (e.KeyCode != Keys.Return && e.KeyCode != Keys.Return)
			{
				if ((e.KeyData & Keys.Control) == 0)
				{
					bool_0 = true;
				}
			}
			else
			{
				method_13();
			}
		}
		else
		{
			bool_3 = true;
			e.Handled = true;
		}
	}

	private void themedComboBox_1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (bool_3)
		{
			e.Handled = true;
			bool_3 = false;
			bool_0 = false;
		}
	}

	private void themedComboBox_1_Leave(object sender, EventArgs e)
	{
		method_13();
	}

	private void method_14(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate44 method = method_14;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.enum60_0 == Form23.Enum60.BpG || bool_0)
		{
			return;
		}
		if (themedTextBox_0.Visible)
		{
			string text = method_11();
			if (themedTextBox_0.Text != text)
			{
				int selectionStart = themedTextBox_0.SelectionStart;
				int selectionLength = themedTextBox_0.SelectionLength;
				themedTextBox_0.Text = text;
				themedTextBox_0.SelectionStart = selectionStart;
				themedTextBox_0.SelectionLength = selectionLength;
			}
			if (setting_9 != null)
			{
				method_6();
			}
		}
		else
		{
			if (!themedComboBox_1.Visible)
			{
				return;
			}
			bool flag = false;
			if (setting_2 != null)
			{
				int num = setting_4.method_256();
				List<Setting.ListItems.Struct45> list = setting_2.method_102();
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].bBv == num)
					{
						themedComboBox_1.SelectedIndex = i;
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				string text2 = method_11();
				if (themedComboBox_1.Text != text2)
				{
					int selectionStart2 = themedComboBox_1.SelectionStart;
					int selectionLength2 = themedComboBox_1.SelectionLength;
					themedComboBox_1.Text = text2;
					themedComboBox_1.SelectionStart = selectionStart2;
					themedComboBox_1.SelectionLength = selectionLength2;
				}
				if (setting_9 != null)
				{
					method_6();
				}
			}
		}
	}

	internal bool method_15(KeyEventArgs keyEventArgs_0)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return false;
		}
		if ((!keyEventArgs_0.Control || keyEventArgs_0.KeyCode != Keys.Prior) && keyEventArgs_0.KeyData != Keys.Prior && (!keyEventArgs_0.Shift || keyEventArgs_0.KeyCode != Keys.Prior) && (!keyEventArgs_0.Control || keyEventArgs_0.KeyCode != Keys.Next) && keyEventArgs_0.KeyData != Keys.Next && (!keyEventArgs_0.Shift || keyEventArgs_0.KeyCode != Keys.Next))
		{
			return false;
		}
		bool_0 = false;
		int num = setting_2.method_231();
		int num2 = setting_2.method_228();
		int num3 = setting_2.method_229();
		int num4 = setting_4.method_256();
		int num5 = num4;
		if (keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Prior)
		{
			num5 += Class233.smethod_36(num);
		}
		else if (keyEventArgs_0.KeyData == Keys.Prior)
		{
			num5 += Class233.smethod_37(num);
		}
		else if (keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Prior)
		{
			num5 += Class233.smethod_38(num);
		}
		else if (keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Next)
		{
			num5 -= Class233.smethod_36(num);
		}
		else if (keyEventArgs_0.KeyData == Keys.Next)
		{
			num5 -= Class233.smethod_37(num);
		}
		else if (keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Next)
		{
			num5 -= Class233.smethod_38(num);
		}
		if (num5 != num4)
		{
			if (num2 != 0 || num3 != 0)
			{
				num5 = Math.Min(num3, Math.Max(num2, num5));
			}
			if (num5 != num4)
			{
				if (themedTextBox_0.Visible)
				{
					themedTextBox_0.Text = Class233.smethod_29(num5, num);
				}
				else if (themedComboBox_1.Visible)
				{
					themedComboBox_1.Text = Class233.smethod_29(num5, num);
				}
				method_13();
			}
		}
		return true;
	}

	private void method_16(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate45 method = method_16;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			int num = setting_0.method_256();
			if (class148_0.Checked != (num != 0))
			{
				class148_0.Checked = num != 0;
			}
		}
	}

	private void method_17(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate46 method = method_17;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			int num = setting_1.method_256();
			if (control8_0.method_3() != num)
			{
				control8_0.method_2(num);
			}
			setting_2 = framework_0.method_31(num);
			method_6();
		}
	}

	private void method_18(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate47 method = method_18;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.enum60_0 == Form23.Enum60.BpG || themedComboBox_0.DroppedDown)
		{
			return;
		}
		int num = -1;
		int num2 = setting_3.method_256();
		List<Setting.ListItems.Struct45> list = setting_3.method_102();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].bBv == num2)
			{
				num = i;
				break;
			}
		}
		if (themedComboBox_0.SelectedIndex != num && num != -1)
		{
			themedComboBox_0.SelectedIndex = num;
		}
		if (setting_8 != null)
		{
			method_6();
		}
	}

	private void method_19()
	{
		try
		{
			class148_0.CheckedChanged -= class148_0_CheckedChanged;
			control8_0.method_5(method_10);
			themedComboBox_0.SelectedIndexChanged -= themedComboBox_0_SelectedIndexChanged;
			themedTextBox_0.MouseEnter -= pictureBox_0_MouseEnter;
			themedTextBox_0.GotFocus -= themedTextBox_0_GotFocus;
			themedTextBox_0.KeyDown -= themedComboBox_1_KeyDown;
			themedTextBox_0.KeyPress -= themedComboBox_1_KeyPress;
			themedTextBox_0.Leave -= themedComboBox_1_Leave;
			themedComboBox_1.MouseEnter -= pictureBox_0_MouseEnter;
			themedComboBox_1.GotFocus -= themedComboBox_1_GotFocus;
			themedComboBox_1.SelectedIndexChanged -= themedComboBox_1_SelectedIndexChanged;
			themedComboBox_1.KeyDown -= themedComboBox_1_KeyDown;
			themedComboBox_1.KeyPress -= themedComboBox_1_KeyPress;
			themedComboBox_1.Leave -= themedComboBox_1_Leave;
			label_1.MouseEnter -= pictureBox_0_MouseEnter;
			pictureBox_0.MouseEnter -= pictureBox_0_MouseEnter;
			MouseLeave -= Control7_MouseLeave;
			pictureBox_0.Click -= pictureBox_0_Click;
			if (setting_0 != null)
			{
				setting_0.method_265(method_16);
				setting_0.method_41(method_9);
			}
			if (setting_1 != null)
			{
				setting_1.method_265(method_17);
				setting_1.method_41(method_9);
			}
			if (setting_3 != null)
			{
				setting_3.method_265(method_18);
			}
			if (setting_4 != null)
			{
				setting_4.method_265(method_14);
				setting_4.method_41(method_9);
			}
			Form23.form23_0.method_10(method_7);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		method_19();
		if (Form23.pictureBox_1 == pictureBox_0)
		{
			Form23.pictureBox_1 = null;
		}
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
