using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;

namespace ns4;

internal class Form31 : Form
{
	private IContainer icontainer_0;

	private TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_0;

	private ThemedTextBox themedTextBox_0;

	private ThemedTextBox themedTextBox_1;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Label label_3;

	private ThemedButton themedButton_2;

	internal Form31()
	{
		method_5();
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				(control as Label).ForeColor = Form23.color_12;
			}
			if (control is TreeViewWithThemedScrollBars)
			{
				(control as TreeViewWithThemedScrollBars).BackColor = Form23.color_16;
				(control as TreeViewWithThemedScrollBars).ForeColor = Form23.color_12;
			}
		}
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		themedTextBox_1.BackColor = Form23.color_32;
		themedTextBox_1.ForeColor = Form23.color_12;
		if (Form23.framework_1.method_2())
		{
			themedButton_1.Enabled = true;
			label_2.Text = Class333.smethod_2162();
		}
		else
		{
			themedButton_1.Enabled = false;
			label_2.Text = Class333.smethod_2163();
		}
		if (Form23.framework_1.method_31(9496) != null)
		{
			method_0();
		}
		Form23.smethod_7(method_4);
	}

	private void method_0()
	{
		treeViewWithThemedScrollBars_0.method_5();
		foreach (MenuNode item in Form23.framework_1.awj)
		{
			method_1(item, null);
		}
		treeViewWithThemedScrollBars_0.method_6();
		treeViewWithThemedScrollBars_0.method_48();
	}

	private void method_1(MenuNode menuNode_0, TreeNode treeNode_0)
	{
		string text = menuNode_0.method_10();
		int int_ = menuNode_0.method_3();
		int int_2 = menuNode_0.method_20();
		TreeNode treeNode = new TreeNode(text);
		treeNode.Tag = menuNode_0;
		treeNode.ForeColor = Form23.color_12;
		SettingOrSpecialObject settingOrSpecialObject = Form23.framework_1.method_33(int_);
		SettingOrSpecialObject settingOrSpecialObject2 = Form23.framework_1.method_33(int_2);
		if (settingOrSpecialObject != null && (settingOrSpecialObject.method_24().Count != 0 || settingOrSpecialObject.method_26().method_4().Count != 0))
		{
			return;
		}
		bool bool_ = false;
		if (menuNode_0.method_22() != 0)
		{
			Setting setting = Form23.framework_1.method_31(menuNode_0.method_22());
			if (setting != null)
			{
				if (setting.method_219() && setting.method_256() == 0)
				{
					return;
				}
				method_2(setting, treeNode, Class333.smethod_1196(), ref bool_);
			}
		}
		foreach (MenuNode item in menuNode_0.method_6())
		{
			method_1(item, treeNode);
		}
		if (treeNode.GetNodeCount(includeSubTrees: true) == 0 && settingOrSpecialObject == null && settingOrSpecialObject2 == null && menuNode_0.method_22() == 0 && menuNode_0.method_103().Count == 0)
		{
			return;
		}
		if (menuNode_0.method_5() != null && menuNode_0.method_5().method_22() == 0 && settingOrSpecialObject is SpecialObject && (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count != 0)
		{
			bool flag = true;
			foreach (UIListSettingDataIdAndIndent currentUIListSettingsIdsAndIndent in (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents)
			{
				if (!Form23.framework_1.aWZ.Contains(currentUIListSettingsIdsAndIndent.DataId))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return;
			}
		}
		bool skipThisTreeNode = false;
		if (settingOrSpecialObject2 != null)
		{
			List<Class245> list = new List<Class245>();
			PortFunction.smethod_23(settingOrSpecialObject2, bool_0: false, bool_1: true, list);
			foreach (Class245 item2 in list)
			{
				method_2(item2, treeNode, null, ref bool_);
			}
			List<Class244> list2 = new List<Class244>();
			PortFunction.smethod_24(settingOrSpecialObject2, bool_0: false, list2, bool_1: true);
			foreach (Class244 item3 in list2)
			{
				if (!item3.method_219())
				{
					method_2(item3, treeNode, Class333.smethod_1134(), ref bool_);
				}
				List<Setting> list3 = new List<Setting>();
				PortFunction.smethod_31(item3, list3, bool_0: false);
				foreach (Setting item4 in list3)
				{
					method_2(item4, treeNode, null, ref bool_);
				}
			}
		}
		else if (settingOrSpecialObject != null)
		{
			Interface4 @interface = settingOrSpecialObject.method_11();
			if (@interface != null)
			{
				@interface.InitPasswordProtectionNode(treeNode, ref skipThisTreeNode);
				if (!skipThisTreeNode)
				{
					bool_ = true;
				}
			}
			else if (settingOrSpecialObject.method_1().Count != 0)
			{
				if (settingOrSpecialObject is SpecialObject && !(settingOrSpecialObject as SpecialObject).method_67().EachListRowIsAnObject())
				{
					foreach (SettingOrSpecialObject item5 in settingOrSpecialObject.method_1())
					{
						if (item5 is Setting)
						{
							Setting setting2 = item5 as Setting;
							if (!setting2.method_219() && !setting2.method_212() && !setting2.method_220() && !Form23.framework_1.aWZ.Contains(setting2.method_64()))
							{
								method_2(setting2, treeNode, null, ref bool_);
							}
						}
					}
				}
				foreach (string item6 in settingOrSpecialObject.method_52())
				{
					if (!Form23.framework_1.aWv.ContainsKey(item6))
					{
						continue;
					}
					foreach (SettingOrSpecialObject item7 in Form23.framework_1.aWv[item6].method_1())
					{
						if (!(item7 is Setting))
						{
							continue;
						}
						Setting setting3 = item7 as Setting;
						if (setting3.method_2() == Class333.smethod_1137())
						{
							if (!setting3.method_219())
							{
								method_2(setting3, treeNode, null, ref bool_);
							}
							break;
						}
					}
				}
			}
		}
		foreach (int item8 in menuNode_0.method_103())
		{
			Setting setting4 = Form23.framework_1.method_31(item8);
			if (setting4 != null)
			{
				method_2(setting4, treeNode, null, ref bool_);
			}
		}
		if (treeNode.GetNodeCount(includeSubTrees: true) == 0 && !bool_)
		{
			skipThisTreeNode = true;
		}
		if (!skipThisTreeNode)
		{
			if (treeNode_0 != null)
			{
				treeNode_0.Nodes.Add(treeNode);
				return;
			}
			treeNode.Expand();
			treeViewWithThemedScrollBars_0.method_2().Add(treeNode);
		}
	}

	private void method_2(Setting setting_0, TreeNode treeNode_0, string string_0, ref bool bool_0)
	{
		string text = ((!string.IsNullOrEmpty(string_0)) ? (setting_0.method_22(bool_0: true) + string_0) : setting_0.method_22(bool_0: true));
		TreeNode treeNode = new TreeNode(text);
		treeNode.Checked = setting_0.method_96();
		treeNode.ForeColor = Form23.color_12;
		treeNode.Tag = setting_0;
		treeNode_0.Nodes.Add(treeNode);
		bool_0 = true;
	}

	private void themedButton_2_Click(object sender, EventArgs e)
	{
		if (Form23.framework_1.method_2())
		{
			if (themedTextBox_0.Text == null || themedTextBox_0.Text.Length == 0)
			{
				Form54.smethod_6(this, Class333.smethod_2164(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (themedTextBox_0.Text != themedTextBox_1.Text)
			{
				Form54.smethod_6(this, Class333.smethod_2165(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (!Form23.framework_1.method_62(themedTextBox_0.Text))
			{
				Form54.smethod_6(this, Class333.smethod_2166(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
		}
		else
		{
			if (themedTextBox_0.Text == null || themedTextBox_0.Text.Length == 0)
			{
				Form54.smethod_6(this, Class333.smethod_2167(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (themedTextBox_0.Text != themedTextBox_1.Text)
			{
				Form54.smethod_6(this, Class333.smethod_2165(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
		}
		Form23.smethod_9();
		if (Form23.framework_1.method_31(9496) != null)
		{
			method_3(treeViewWithThemedScrollBars_0.method_2());
		}
		Form23.framework_1.method_63(themedTextBox_0.Text);
		Form23.smethod_10(bool_53: false);
		Close();
	}

	private void method_3(List<TreeNode> list_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			TreeNode treeNode = list_0[i];
			if (treeNode.Tag is Setting)
			{
				(treeNode.Tag as Setting).method_97(treeNode.Checked);
			}
			else if (treeNode.Tag is MenuNode)
			{
				MenuNode menuNode = treeNode.Tag as MenuNode;
				int int_ = menuNode.method_3();
				SettingOrSpecialObject settingOrSpecialObject = Form23.framework_1.method_33(int_);
				if (Form23.framework_1.method_33(menuNode.method_20()) == null)
				{
					settingOrSpecialObject?.method_11()?.UpdateSettingsIncludedInPasswordProtection(treeNode);
				}
				if (menuNode.method_79())
				{
					Form23.framework_1.method_31(menuNode.method_73())?.method_97(treeNode.Checked);
				}
			}
			List<TreeNode> list = new List<TreeNode>();
			foreach (TreeNode node in treeNode.Nodes)
			{
				list.Add(node);
			}
			method_3(list);
		}
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		if (themedTextBox_0.Text != null && themedTextBox_0.Text.Length != 0)
		{
			if (themedTextBox_0.Text != themedTextBox_1.Text)
			{
				Form54.smethod_6(this, Class333.smethod_2169(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (!Form23.framework_1.method_62(themedTextBox_0.Text))
			{
				Form54.smethod_6(this, Class333.smethod_2170(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Form23.smethod_9();
			Form23.framework_1.method_64();
			Form23.smethod_10(bool_53: false);
			Close();
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_2168(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void Form31_Shown(object sender, EventArgs e)
	{
		bool visible = Form23.framework_1.method_31(9496) != null;
		label_3.Visible = visible;
		themedTextBox_0.Focus();
	}

	private void Form31_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form23.smethod_8(method_4);
	}

	private void method_4(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_5()
	{
		themedTextBox_0 = new ThemedTextBox();
		themedTextBox_1 = new ThemedTextBox();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		label_3 = new Label();
		themedButton_2 = new ThemedButton();
		treeViewWithThemedScrollBars_0 = new TreeViewWithThemedScrollBars();
		SuspendLayout();
		themedTextBox_0.Location = new Point(120, 33);
		themedTextBox_0.MaxLength = 100;
		themedTextBox_0.Name = Class333.smethod_2171();
		themedTextBox_0.PasswordChar = '*';
		themedTextBox_0.Size = new Size(452, 22);
		themedTextBox_0.TabIndex = 1;
		themedTextBox_1.Location = new Point(120, 59);
		themedTextBox_1.MaxLength = 100;
		themedTextBox_1.Name = Class333.smethod_2172();
		themedTextBox_1.PasswordChar = '*';
		themedTextBox_1.Size = new Size(452, 22);
		themedTextBox_1.TabIndex = 2;
		label_0.AutoSize = true;
		label_0.Location = new Point(12, 36);
		label_0.Name = Class333.smethod_2173();
		label_0.Size = new Size(90, 13);
		label_0.TabIndex = 3;
		label_0.Text = Class333.smethod_2174();
		label_1.AutoSize = true;
		label_1.Location = new Point(12, 62);
		label_1.Name = Class333.smethod_2175();
		label_1.Size = new Size(107, 13);
		label_1.TabIndex = 4;
		label_1.Text = Class333.smethod_2176();
		label_2.AutoSize = true;
		label_2.Location = new Point(12, 9);
		label_2.Name = Class333.smethod_2177();
		label_2.Size = new Size(115, 13);
		label_2.TabIndex = 5;
		label_2.Text = Class333.smethod_2178();
		themedButton_0.DialogResult = DialogResult.Cancel;
		themedButton_0.Location = new Point(472, 594);
		themedButton_0.Name = Class333.smethod_830();
		themedButton_0.Size = new Size(100, 38);
		themedButton_0.TabIndex = 7;
		themedButton_0.Text = Class333.smethod_823();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.Enabled = false;
		themedButton_1.Location = new Point(316, 594);
		themedButton_1.Name = Class333.smethod_2179();
		themedButton_1.Size = new Size(139, 38);
		themedButton_1.TabIndex = 6;
		themedButton_1.Text = Class333.smethod_2180();
		themedButton_1.UseVisualStyleBackColor = true;
		themedButton_1.Click += themedButton_1_Click;
		label_3.AutoSize = true;
		label_3.Location = new Point(12, 101);
		label_3.Name = Class333.smethod_618();
		label_3.Size = new Size(291, 13);
		label_3.TabIndex = 8;
		label_3.Text = Class333.smethod_2181();
		themedButton_2.Location = new Point(151, 594);
		themedButton_2.Name = Class333.smethod_2182();
		themedButton_2.Size = new Size(159, 38);
		themedButton_2.TabIndex = 9;
		themedButton_2.Text = Class333.smethod_2183();
		themedButton_2.UseVisualStyleBackColor = true;
		themedButton_2.Click += themedButton_2_Click;
		treeViewWithThemedScrollBars_0.AutoScroll = true;
		treeViewWithThemedScrollBars_0.method_10(bool_3: true);
		treeViewWithThemedScrollBars_0.method_1(Enum45.const_0);
		treeViewWithThemedScrollBars_0.method_14(null);
		treeViewWithThemedScrollBars_0.Location = new Point(12, 117);
		treeViewWithThemedScrollBars_0.Name = Class333.smethod_2184();
		treeViewWithThemedScrollBars_0.method_4(null);
		treeViewWithThemedScrollBars_0.Size = new Size(560, 468);
		treeViewWithThemedScrollBars_0.TabIndex = 0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_0;
		ClientSize = new Size(584, 642);
		Controls.Add(themedButton_2);
		Controls.Add(label_3);
		Controls.Add(themedButton_0);
		Controls.Add(themedButton_1);
		Controls.Add(label_2);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Controls.Add(themedTextBox_1);
		Controls.Add(themedTextBox_0);
		Controls.Add(treeViewWithThemedScrollBars_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2185();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1576();
		Shown += Form31_Shown;
		FormClosing += Form31_FormClosing;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
