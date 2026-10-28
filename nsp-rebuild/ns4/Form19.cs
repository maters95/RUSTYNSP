using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns1;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;

namespace ns4;

internal class Form19 : Form
{
	private enum Enum58 : byte
	{
		BPr = 1,
		BPS = 2,
		BPs = 4,
		BPT = 8
	}

	private Framework framework_0;

	private Framework framework_1;

	private bool bool_0;

	private HashSet<DataIdAndAttrId> hashSet_0 = new HashSet<DataIdAndAttrId>();

	private HashSet<DataIdAndAttrId> hashSet_1 = new HashSet<DataIdAndAttrId>();

	private List<TreeNode> list_0 = new List<TreeNode>();

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private TreeNode treeNode_0;

	private bool bool_4;

	private string string_0 = string.Empty;

	private string string_1 = string.Empty;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_0;

	private TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_1;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private ThemedButton themedButton_2;

	private ThemedButton themedButton_3;

	private ThemedButton themedButton_4;

	internal Form19()
	{
		method_23();
	}

	internal Form19(string string_2, bool bool_5, bool bool_6, Framework framework_2, Framework framework_3)
	{
		method_23();
		framework_0 = framework_2;
		framework_1 = framework_3;
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
		bool_1 = framework_0.method_2() && framework_0.method_3();
		bool_2 = framework_1.method_2() && framework_1.method_3();
		bool_3 = (!bool_1 && !bool_2) || (bool_1 && bool_2 && framework_0.method_61(framework_1));
		bool_0 = bool_5;
		if (bool_5)
		{
			Text = Class333.smethod_551();
			if (bool_6)
			{
				label_1.Text = Class333.smethod_1179();
			}
			else
			{
				label_1.Text = Class333.smethod_1180();
			}
			treeViewWithThemedScrollBars_0.Width = treeViewWithThemedScrollBars_1.Right - treeViewWithThemedScrollBars_0.Left;
			treeViewWithThemedScrollBars_1.Visible = false;
			label_3.Visible = false;
			label_0.Visible = false;
			label_2.Visible = false;
			label_4.Visible = false;
		}
		else
		{
			Text = Class333.smethod_1181();
			if (bool_6)
			{
				label_1.Text = Class333.smethod_1179();
			}
			else
			{
				label_1.Text = Class333.smethod_1182();
			}
			treeViewWithThemedScrollBars_1.Visible = !bool_6;
			label_3.Visible = !bool_6;
			label_0.Visible = true;
			if (string.IsNullOrEmpty(string_2))
			{
				label_0.Text = string.Empty;
			}
			else
			{
				label_0.Text = Class333.smethod_1183() + string_2 + Class333.smethod_180();
			}
			label_2.Visible = true;
			label_2.Text = Class333.smethod_1184() + framework_0.ToString() + Class333.smethod_180();
			if (framework_0.method_2() && framework_0.method_3() && !bool_3)
			{
				label_2.Text += Class333.smethod_1185();
			}
			label_4.Visible = true;
			label_4.Text = Class333.smethod_1186() + framework_1.ToString() + Class333.smethod_180();
			if (framework_1.method_2() && framework_1.method_3() && !bool_3)
			{
				label_4.Text += Class333.smethod_1185();
			}
		}
		Form23.smethod_7(method_0);
		treeViewWithThemedScrollBars_0.method_43(method_2);
		method_5(bool_6);
		method_9();
		method_10();
		method_13();
		foreach (TreeNode item in list_0)
		{
			method_3(item);
		}
		method_16(treeViewWithThemedScrollBars_0.method_2());
		if (treeViewWithThemedScrollBars_0.method_2().Count == 0)
		{
			themedButton_2.Visible = false;
			themedButton_3.Visible = false;
			if (bool_0 && bool_2)
			{
				themedButton_0.Visible = false;
				treeViewWithThemedScrollBars_0.Visible = false;
				label_1.Text = Class333.smethod_1187();
			}
		}
		else
		{
			themedButton_2.Enabled = !bool_6;
			themedButton_3.Enabled = !bool_6;
		}
		if (bool_0)
		{
			themedButton_0.Text = Class333.smethod_1188();
			themedButton_4.Text = Class333.smethod_1189();
		}
		if (!bool_3 && !bool_0)
		{
			themedButton_4.Enabled = false;
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Abort;
		Close();
	}

	private void method_1(TreeNode treeNode_1, ref byte byte_0)
	{
		if (!treeNode_1.Checked)
		{
			byte_0 |= 1;
		}
		else if (treeNode_1.ForeColor == Form23.color_12)
		{
			byte_0 |= 2;
		}
		else if (treeNode_1.ForeColor == Color.Orange)
		{
			byte_0 |= 4;
		}
		else if (treeNode_1.ForeColor == Color.Gray)
		{
			byte_0 |= 8;
		}
		foreach (TreeNode node in treeNode_1.Nodes)
		{
			method_1(node, ref byte_0);
		}
	}

	private void method_2(object sender, DrawTreeNodeEventArgs e)
	{
		if (e.Bounds.Y < -10 || e.Bounds.Y > treeViewWithThemedScrollBars_0.Height)
		{
			return;
		}
		Font font = treeViewWithThemedScrollBars_0.Font;
		using (SolidBrush brush = new SolidBrush(treeViewWithThemedScrollBars_0.BackColor))
		{
			e.Graphics.FillRectangle(brush, e.Bounds.Right, e.Bounds.Top, treeViewWithThemedScrollBars_0.Width - e.Bounds.Right, e.Bounds.Height);
		}
		Rectangle bounds = new Rectangle(530, e.Bounds.Top, treeViewWithThemedScrollBars_0.Width - 530, e.Bounds.Height);
		if (e.Node.Checked)
		{
			byte byte_ = 0;
			method_1(e.Node, ref byte_);
			bool flag = byte_ != 0 && byte_ != 1 && byte_ != 2 && byte_ != 4 && byte_ != 8;
			if (e.Node.ForeColor == Form23.color_12)
			{
				if (flag)
				{
					TextRenderer.DrawText(e.Graphics, Class333.smethod_1190(), font, bounds, e.Node.ForeColor, TextFormatFlags.Default);
				}
				else
				{
					TextRenderer.DrawText(e.Graphics, Class333.smethod_1191(), font, bounds, e.Node.ForeColor, TextFormatFlags.Default);
				}
			}
			else if (e.Node.ForeColor == Color.Orange)
			{
				if (flag)
				{
					TextRenderer.DrawText(e.Graphics, Class333.smethod_1190(), font, bounds, e.Node.ForeColor, TextFormatFlags.Default);
				}
				else
				{
					TextRenderer.DrawText(e.Graphics, Class333.smethod_1192(), font, bounds, e.Node.ForeColor, TextFormatFlags.Default);
				}
			}
			else
			{
				TextRenderer.DrawText(e.Graphics, Class333.smethod_1193(), font, bounds, Color.Gray, TextFormatFlags.Default);
			}
		}
		else if (TreeViewWithThemedScrollBars.smethod_1(e.Node))
		{
			TextRenderer.DrawText(e.Graphics, Class333.smethod_1190(), font, bounds, Form23.color_12, TextFormatFlags.Default);
		}
		else if ((e.State & TreeNodeStates.Selected) != 0)
		{
			TextRenderer.DrawText(e.Graphics, Class333.smethod_1194(), font, bounds, Form23.color_12, TextFormatFlags.Default);
		}
		else
		{
			TextRenderer.DrawText(e.Graphics, Class333.smethod_1194(), font, bounds, Color.Gray, TextFormatFlags.Default);
		}
	}

	private void method_3(TreeNode treeNode_1)
	{
		TreeNode treeNode = treeNode_1;
		bool flag = false;
		do
		{
			treeNode.ForeColor = Form23.color_12;
			if (treeNode.Parent == null)
			{
				flag = true;
			}
			else
			{
				treeNode = treeNode.Parent;
			}
		}
		while (!flag);
	}

	private void method_4(TreeNode treeNode_1)
	{
		TreeNode treeNode = treeNode_1;
		bool flag = false;
		do
		{
			if (treeNode.ForeColor != Form23.color_12)
			{
				treeNode.ForeColor = Color.Orange;
			}
			if (treeNode.Parent != null)
			{
				treeNode = treeNode.Parent;
			}
			else
			{
				flag = true;
			}
		}
		while (!flag);
	}

	private void method_5(bool bool_5)
	{
		treeViewWithThemedScrollBars_0.method_5();
		HashSet<DataIdAndAttrId> hashSet_ = new HashSet<DataIdAndAttrId>();
		method_6(hashSet_, bool_5);
		foreach (MenuNode item in framework_1.awj)
		{
			method_7(item, null, hashSet_, bool_5);
		}
		treeViewWithThemedScrollBars_0.method_6();
		treeViewWithThemedScrollBars_0.method_48();
		treeViewWithThemedScrollBars_0.method_12(!bool_5);
	}

	private void method_6(HashSet<DataIdAndAttrId> hashSet_2, bool bool_5)
	{
		TreeNode treeNode = new TreeNode(Class333.smethod_1195());
		if (bool_5)
		{
			treeNode.Checked = true;
		}
		treeNode.ForeColor = Color.Gray;
		List<int> list = new List<int>();
		list.Add(1501);
		list.Add(1502);
		list.Add(3800);
		for (int i = 0; i < list.Count; i++)
		{
			int num = list[i];
			Setting setting = framework_1.method_31(num);
			if (setting == null || setting.method_72())
			{
				continue;
			}
			TreeNode treeNode2 = new TreeNode(setting.method_22(bool_0: true));
			if (bool_5)
			{
				treeNode2.Checked = true;
			}
			treeNode2.ForeColor = Color.Gray;
			treeNode2.Tag = setting;
			Setting setting2 = framework_0.method_31(num);
			if (bool_3 || ((!bool_2 || !setting.method_96()) && (!bool_1 || (setting2 != null && !setting2.method_96()))))
			{
				treeNode.Nodes.Add(treeNode2);
				hashSet_0.Add(new DataIdAndAttrId(num));
				hashSet_2.Add(new DataIdAndAttrId(num));
				if (setting2 != null && !setting.method_282(setting2))
				{
					list_0.Add(treeNode2);
				}
			}
		}
		if (treeNode.Nodes.Count != 0)
		{
			treeNode.Expand();
			treeViewWithThemedScrollBars_0.method_2().Add(treeNode);
			treeNode_0 = treeNode;
		}
	}

	private void method_7(MenuNode menuNode_0, TreeNode treeNode_1, HashSet<DataIdAndAttrId> hashSet_2, bool bool_5)
	{
		string text = menuNode_0.method_10();
		int int_ = menuNode_0.method_3();
		int int_2 = menuNode_0.method_20();
		TreeNode treeNode = new TreeNode(text);
		if (bool_5)
		{
			treeNode.Checked = true;
		}
		treeNode.Tag = menuNode_0;
		treeNode.ForeColor = Color.Gray;
		SettingOrSpecialObject settingOrSpecialObject = framework_1.method_33(int_);
		SettingOrSpecialObject settingOrSpecialObject2 = framework_1.method_33(int_2);
		if (settingOrSpecialObject != null && (settingOrSpecialObject.method_24().Count != 0 || settingOrSpecialObject.method_26().method_4().Count != 0))
		{
			return;
		}
		if (menuNode_0.method_22() != 0)
		{
			Setting setting = framework_1.method_31(menuNode_0.method_22());
			if (setting != null)
			{
				if (setting.method_219() && setting.method_256() != 1)
				{
					return;
				}
				Setting setting2 = framework_0.method_31(setting.method_64());
				if ((bool_3 || ((!bool_2 || !setting.method_96()) && (!bool_1 || (setting2 != null && !setting2.method_96())))) && !hashSet_2.Contains(setting.method_69()))
				{
					TreeNode treeNode2 = new TreeNode(setting.method_22(bool_0: true) + Class333.smethod_1196());
					if (bool_5)
					{
						treeNode2.Checked = true;
					}
					treeNode2.ForeColor = Color.Gray;
					treeNode2.Tag = setting;
					treeNode.Nodes.Add(treeNode2);
					hashSet_0.Add(setting.method_69());
					hashSet_2.Add(setting.method_69());
					if (setting2 != null && !setting.method_282(setting2))
					{
						list_0.Add(treeNode2);
					}
				}
			}
		}
		foreach (MenuNode item in menuNode_0.method_6())
		{
			method_7(item, treeNode, hashSet_2, bool_5);
		}
		if (method_8(menuNode_0, treeNode, settingOrSpecialObject, settingOrSpecialObject2))
		{
			return;
		}
		if (menuNode_0.method_5() != null && menuNode_0.method_5().method_22() == 0 && settingOrSpecialObject is SpecialObject && (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count != 0)
		{
			bool flag = true;
			foreach (UIListSettingDataIdAndIndent currentUIListSettingsIdsAndIndent in (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents)
			{
				if (!framework_1.aWZ.Contains(currentUIListSettingsIdsAndIndent.DataId))
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
		bool bool_6 = false;
		bool skipThisTreeNode = false;
		if (settingOrSpecialObject2 != null)
		{
			List<Class245> list = new List<Class245>();
			PortFunction.smethod_23(settingOrSpecialObject2, bool_0: false, bool_1: true, list);
			foreach (Class245 item2 in list)
			{
				Class245 @class = framework_0.method_31(item2.method_64()) as Class245;
				if ((bool_3 || ((!bool_2 || !item2.method_96()) && (!bool_1 || (@class != null && !@class.method_96())))) && !hashSet_2.Contains(item2.method_69()))
				{
					TreeNode treeNode3 = new TreeNode(item2.method_22(bool_0: true));
					if (bool_5)
					{
						treeNode3.Checked = true;
					}
					treeNode3.ForeColor = Color.Gray;
					treeNode3.Tag = item2;
					treeNode.Nodes.Add(treeNode3);
					bool_6 = true;
					hashSet_0.Add(item2.method_69());
					hashSet_2.Add(item2.method_69());
					if (@class != null && !item2.method_282(@class))
					{
						list_0.Add(treeNode3);
					}
				}
			}
			List<Class244> list2 = new List<Class244>();
			PortFunction.smethod_24(settingOrSpecialObject2, bool_0: false, list2, bool_0);
			foreach (Class244 item3 in list2)
			{
				if (item3.method_219())
				{
					List<Setting> list3 = new List<Setting>();
					PortFunction.smethod_30(item3.method_256(), item3.method_212(), item3.method_220(), framework_1, list3, bool_2: false);
					if (list3.Count == 0)
					{
						continue;
					}
				}
				Setting setting3 = framework_0.method_31(item3.method_64());
				if ((bool_3 || ((!bool_2 | !item3.method_96()) && (!bool_1 || (setting3 != null && !setting3.method_96())))) && !hashSet_2.Contains(item3.method_69()))
				{
					TreeNode treeNode4 = new TreeNode(item3.method_22(bool_0: true) + Class333.smethod_1134());
					if (bool_5)
					{
						treeNode4.Checked = true;
					}
					treeNode4.ForeColor = Color.Gray;
					treeNode4.Tag = item3;
					treeNode.Nodes.Add(treeNode4);
					bool_6 = true;
					hashSet_0.Add(item3.method_69());
					hashSet_2.Add(item3.method_69());
					if (setting3 != null && !item3.method_282(setting3))
					{
						list_0.Add(treeNode4);
					}
				}
			}
		}
		else if (settingOrSpecialObject != null)
		{
			Interface4 @interface = settingOrSpecialObject.method_11();
			if (@interface != null)
			{
				@interface.InitImportMapDestinationNode(treeNode, ref skipThisTreeNode, framework_0, bool_3, bool_2, bool_1, hashSet_0, list_0, hashSet_2, bool_5);
				if (!skipThisTreeNode)
				{
					bool_6 = true;
				}
			}
			else if (settingOrSpecialObject.method_1().Count != 0)
			{
				if (!(settingOrSpecialObject is SpecialObject) || !(settingOrSpecialObject as SpecialObject).method_67().EachListRowIsAnObject())
				{
					foreach (SettingOrSpecialObject item4 in settingOrSpecialObject.method_1())
					{
						if (!(item4 is Setting))
						{
							continue;
						}
						Setting setting4 = item4 as Setting;
						if (setting4.method_72() || setting4.method_219() || setting4.method_220() || framework_1.aWZ.Contains(setting4.method_64()))
						{
							continue;
						}
						Setting setting5 = framework_0.method_31(setting4.method_64());
						if ((bool_3 || ((!bool_2 || !setting4.method_96()) && (!bool_1 || (setting5 != null && !setting5.method_96())))) && !hashSet_2.Contains(setting4.method_69()))
						{
							TreeNode treeNode5 = new TreeNode(setting4.method_22(bool_0: true));
							if (bool_5)
							{
								treeNode5.Checked = true;
							}
							treeNode5.ForeColor = Color.Gray;
							treeNode5.Tag = setting4;
							treeNode.Nodes.Add(treeNode5);
							bool_6 = true;
							hashSet_0.Add(setting4.method_69());
							hashSet_2.Add(setting4.method_69());
							if (setting5 != null && !setting4.method_282(setting5))
							{
								list_0.Add(treeNode5);
							}
						}
					}
				}
				method_15(treeNode, settingOrSpecialObject, bool_5, ref bool_6);
			}
		}
		foreach (int item5 in menuNode_0.method_103())
		{
			Setting setting6 = framework_1.method_31(item5);
			if (setting6 == null || setting6.method_72() || setting6.method_219())
			{
				continue;
			}
			Setting setting7 = framework_0.method_31(item5);
			if ((bool_3 || ((!bool_2 || !setting6.method_96()) && (!bool_1 || (setting7 != null && !setting7.method_96())))) && !hashSet_2.Contains(setting6.method_69()))
			{
				TreeNode treeNode6 = new TreeNode(setting6.method_22(bool_0: true));
				if (bool_5)
				{
					treeNode6.Checked = true;
				}
				treeNode6.ForeColor = Color.Gray;
				treeNode6.Tag = setting6;
				treeNode.Nodes.Add(treeNode6);
				bool_6 = true;
				hashSet_0.Add(setting6.method_69());
				hashSet_2.Add(setting6.method_69());
				if (setting7 != null && !setting6.method_282(setting7))
				{
					list_0.Add(treeNode6);
				}
			}
		}
		if (treeNode.GetNodeCount(includeSubTrees: true) == 0 && !bool_6)
		{
			skipThisTreeNode = true;
		}
		if (!skipThisTreeNode)
		{
			if (treeNode_1 != null)
			{
				treeNode_1.Nodes.Add(treeNode);
				return;
			}
			treeNode.Expand();
			treeViewWithThemedScrollBars_0.method_2().Add(treeNode);
		}
	}

	private bool method_8(MenuNode menuNode_0, TreeNode treeNode_1, SettingOrSpecialObject settingOrSpecialObject_0, SettingOrSpecialObject settingOrSpecialObject_1)
	{
		bool flag = settingOrSpecialObject_0 != null;
		bool flag2 = settingOrSpecialObject_1 != null;
		bool flag3 = menuNode_0.method_22() != 0;
		bool flag4 = menuNode_0.method_103().Count != 0;
		if (treeNode_1.GetNodeCount(includeSubTrees: true) == 0 && !flag && !flag2 && !flag3)
		{
			return !flag4;
		}
		return false;
	}

	private void method_9()
	{
		for (int i = 0; i < framework_1.awD.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject_ = framework_1.awD[i];
			foreach (Setting item in PortFunction.smethod_29(settingOrSpecialObject_, bool_0: false))
			{
				Setting setting = framework_0.method_31(item.method_64());
				if (bool_3 || ((!bool_2 || !item.method_96()) && (!bool_1 || setting == null || !setting.method_96())))
				{
					hashSet_0.Add(item.method_69());
				}
			}
			foreach (Table item2 in PortFunction.smethod_32(settingOrSpecialObject_, bool_0: false))
			{
				Setting setting2 = framework_0.method_31(item2.method_64());
				if (bool_3 || ((!bool_2 || !item2.method_96()) && (!bool_1 || setting2 == null || !setting2.method_96())))
				{
					hashSet_0.Add(item2.method_69());
				}
			}
		}
	}

	private void method_10()
	{
		treeViewWithThemedScrollBars_1.method_5();
		HashSet<DataIdAndAttrId> hashSet_ = new HashSet<DataIdAndAttrId>();
		List<int> list = new List<int>();
		list.Add(1501);
		list.Add(1502);
		list.Add(3800);
		for (int i = 0; i < list.Count; i++)
		{
			int num = list[i];
			Setting setting = framework_0.method_31(num);
			if (setting != null && (bool_3 || !bool_1 || !setting.method_96()))
			{
				hashSet_1.Add(new DataIdAndAttrId(num));
			}
		}
		foreach (MenuNode item in framework_0.awj)
		{
			method_11(item, null, hashSet_);
		}
		treeViewWithThemedScrollBars_1.method_6();
		treeViewWithThemedScrollBars_1.method_48();
	}

	private void method_11(MenuNode menuNode_0, TreeNode treeNode_1, HashSet<DataIdAndAttrId> hashSet_2)
	{
		string text = menuNode_0.method_10();
		int int_ = menuNode_0.method_3();
		int int_2 = menuNode_0.method_20();
		TreeNode treeNode = new TreeNode(text);
		treeNode.Tag = menuNode_0;
		treeNode.ForeColor = Form23.color_12;
		SettingOrSpecialObject settingOrSpecialObject = framework_0.method_33(int_);
		SettingOrSpecialObject settingOrSpecialObject2 = framework_0.method_33(int_2);
		if (settingOrSpecialObject != null && (settingOrSpecialObject.method_24().Count != 0 || settingOrSpecialObject.method_26().method_4().Count != 0))
		{
			return;
		}
		if (menuNode_0.method_22() != 0)
		{
			Setting setting = framework_0.method_31(menuNode_0.method_22());
			if (setting != null)
			{
				if (setting.method_219() && setting.method_256() != 1)
				{
					return;
				}
				if ((bool_3 || !bool_1 || !setting.method_96()) && !hashSet_2.Contains(setting.method_69()))
				{
					hashSet_1.Add(setting.method_69());
					if (!hashSet_0.Contains(setting.method_69()))
					{
						TreeNode treeNode2 = new TreeNode(setting.method_22(bool_0: true) + Class333.smethod_1196());
						treeNode2.ForeColor = Form23.color_12;
						treeNode2.Tag = setting;
						treeNode.Nodes.Add(treeNode2);
						hashSet_2.Add(setting.method_69());
					}
				}
			}
		}
		foreach (MenuNode item in menuNode_0.method_6())
		{
			method_11(item, treeNode, hashSet_2);
		}
		if (method_12(menuNode_0, treeNode, settingOrSpecialObject, settingOrSpecialObject2))
		{
			return;
		}
		if (menuNode_0.method_5() != null && menuNode_0.method_5().method_22() == 0 && settingOrSpecialObject is SpecialObject && (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count != 0)
		{
			bool flag = true;
			foreach (UIListSettingDataIdAndIndent currentUIListSettingsIdsAndIndent in (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents)
			{
				if (!framework_0.aWZ.Contains(currentUIListSettingsIdsAndIndent.DataId))
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
		bool equivalentNodeExistsInDestMap = true;
		bool bool_ = false;
		bool skipThisTreeNode = false;
		if (settingOrSpecialObject2 != null)
		{
			if (!framework_0.aWz)
			{
				Setting setting2 = PortFunction.smethod_22(settingOrSpecialObject2);
				if (setting2 != null && (bool_3 || !bool_1 || !setting2.method_96()) && !hashSet_2.Contains(setting2.method_69()))
				{
					hashSet_1.Add(setting2.method_69());
					if (!hashSet_0.Contains(setting2.method_69()))
					{
						TreeNode treeNode3 = new TreeNode(setting2.method_22(bool_0: true));
						treeNode3.ForeColor = Form23.color_12;
						treeNode3.Tag = setting2;
						treeNode.Nodes.Add(treeNode3);
						bool_ = true;
						hashSet_2.Add(setting2.method_69());
					}
				}
			}
			List<Class245> list = new List<Class245>();
			PortFunction.smethod_23(settingOrSpecialObject2, bool_0: false, bool_1: true, list);
			foreach (Class245 item2 in list)
			{
				if ((bool_3 || !bool_1 || !item2.method_96()) && !hashSet_2.Contains(item2.method_69()))
				{
					hashSet_1.Add(item2.method_69());
					if (!hashSet_0.Contains(item2.method_69()))
					{
						TreeNode treeNode4 = new TreeNode(item2.method_22(bool_0: true));
						treeNode4.ForeColor = Form23.color_12;
						treeNode4.Tag = item2;
						treeNode.Nodes.Add(treeNode4);
						bool_ = true;
						hashSet_2.Add(item2.method_69());
					}
				}
			}
			List<Class244> list2 = new List<Class244>();
			PortFunction.smethod_24(settingOrSpecialObject2, bool_0: false, list2, bool_0);
			foreach (Class244 item3 in list2)
			{
				if (item3.method_219())
				{
					List<Setting> list3 = new List<Setting>();
					PortFunction.smethod_30(item3.method_256(), item3.method_212(), item3.method_220(), framework_0, list3, bool_2: false);
					if (list3.Count == 0)
					{
						continue;
					}
				}
				if ((bool_3 || !bool_1 || !item3.method_96()) && !hashSet_2.Contains(item3.method_69()))
				{
					hashSet_1.Add(item3.method_69());
					if (!hashSet_0.Contains(item3.method_69()))
					{
						TreeNode treeNode5 = new TreeNode(item3.method_22(bool_0: true) + Class333.smethod_1134());
						treeNode5.ForeColor = Form23.color_12;
						treeNode5.Tag = item3;
						treeNode.Nodes.Add(treeNode5);
						bool_ = true;
						hashSet_2.Add(item3.method_69());
					}
				}
			}
		}
		else if (settingOrSpecialObject != null)
		{
			Interface4 @interface = settingOrSpecialObject.method_11();
			if (@interface != null)
			{
				@interface.InitImportMapSourceNode(treeNode, ref skipThisTreeNode, bool_3, bool_1, hashSet_1, hashSet_0, hashSet_2, ref equivalentNodeExistsInDestMap);
				if (!skipThisTreeNode)
				{
					bool_ = true;
				}
			}
			else if (settingOrSpecialObject.method_1().Count != 0)
			{
				if (!(settingOrSpecialObject is SpecialObject) || !(settingOrSpecialObject as SpecialObject).method_67().EachListRowIsAnObject())
				{
					foreach (SettingOrSpecialObject item4 in settingOrSpecialObject.method_1())
					{
						if (!(item4 is Setting))
						{
							continue;
						}
						Setting setting3 = item4 as Setting;
						if (!setting3.method_72() && !setting3.method_219() && !setting3.method_220() && !framework_0.aWZ.Contains(setting3.method_64()) && (bool_3 || !bool_1 || !setting3.method_96()) && !hashSet_2.Contains(setting3.method_69()))
						{
							hashSet_1.Add(setting3.method_69());
							if (!hashSet_0.Contains(setting3.method_69()))
							{
								TreeNode treeNode6 = new TreeNode(setting3.method_22(bool_0: true));
								treeNode6.ForeColor = Form23.color_12;
								treeNode6.Tag = setting3;
								treeNode.Nodes.Add(treeNode6);
								bool_ = true;
								hashSet_2.Add(setting3.method_69());
							}
						}
					}
				}
				method_14(treeNode, settingOrSpecialObject, ref bool_);
			}
		}
		foreach (int item5 in menuNode_0.method_103())
		{
			Setting setting4 = framework_0.method_31(item5);
			if (setting4 != null && !setting4.method_72() && !setting4.method_219() && !framework_0.aWZ.Contains(setting4.method_64()) && (bool_3 || !bool_1 || !setting4.method_96()) && !hashSet_2.Contains(setting4.method_69()))
			{
				hashSet_1.Add(setting4.method_69());
				if (!hashSet_0.Contains(setting4.method_69()))
				{
					TreeNode treeNode7 = new TreeNode(setting4.method_22(bool_0: true));
					treeNode7.ForeColor = Form23.color_12;
					treeNode7.Tag = setting4;
					treeNode.Nodes.Add(treeNode7);
					bool_ = true;
					hashSet_2.Add(setting4.method_69());
				}
			}
		}
		if (treeNode.GetNodeCount(includeSubTrees: true) == 0 && !bool_)
		{
			skipThisTreeNode = true;
		}
		if (!skipThisTreeNode && (treeNode.GetNodeCount(includeSubTrees: true) != 0 || !equivalentNodeExistsInDestMap))
		{
			treeNode.Expand();
			if (treeNode_1 != null)
			{
				treeNode_1.Nodes.Add(treeNode);
			}
			else
			{
				treeViewWithThemedScrollBars_1.method_2().Add(treeNode);
			}
		}
	}

	private bool method_12(MenuNode menuNode_0, TreeNode treeNode_1, SettingOrSpecialObject settingOrSpecialObject_0, SettingOrSpecialObject settingOrSpecialObject_1)
	{
		bool flag = settingOrSpecialObject_0 != null;
		bool flag2 = settingOrSpecialObject_1 != null;
		bool flag3 = menuNode_0.method_22() != 0;
		bool flag4 = menuNode_0.method_103().Count != 0;
		if (treeNode_1.GetNodeCount(includeSubTrees: true) == 0 && !flag && !flag2 && !flag3)
		{
			return !flag4;
		}
		return false;
	}

	private void method_13()
	{
		for (int i = 0; i < framework_0.awD.Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject_ = framework_0.awD[i];
			foreach (Setting item in PortFunction.smethod_29(settingOrSpecialObject_, bool_0: false))
			{
				if (bool_3 || !bool_1 || !item.method_96())
				{
					hashSet_1.Add(item.method_69());
				}
			}
			foreach (Table item2 in PortFunction.smethod_32(settingOrSpecialObject_, bool_0: false))
			{
				if (bool_3 || !bool_1 || !item2.method_96())
				{
					hashSet_0.Add(item2.method_69());
				}
			}
		}
	}

	private void method_14(TreeNode treeNode_1, SettingOrSpecialObject settingOrSpecialObject_0, ref bool bool_5)
	{
		foreach (string item in settingOrSpecialObject_0.method_52())
		{
			if (!framework_0.aWv.ContainsKey(item))
			{
				continue;
			}
			foreach (SettingOrSpecialObject item2 in framework_0.aWv[item].method_1())
			{
				if (!(item2 is Setting))
				{
					continue;
				}
				Setting setting = item2 as Setting;
				if (setting.method_72() || !(setting.method_2() == Class333.smethod_1137()))
				{
					continue;
				}
				if (!setting.method_219() && (bool_3 || !bool_1 || !setting.method_96()))
				{
					hashSet_1.Add(setting.method_69());
					if (!hashSet_0.Contains(setting.method_69()))
					{
						TreeNode treeNode = new TreeNode(setting.method_22(bool_0: true));
						treeNode.ForeColor = Form23.color_12;
						treeNode.Tag = setting;
						treeNode_1.Nodes.Add(treeNode);
						bool_5 = true;
					}
				}
				break;
			}
		}
	}

	private void method_15(TreeNode treeNode_1, SettingOrSpecialObject settingOrSpecialObject_0, bool bool_5, ref bool bool_6)
	{
		foreach (string item in settingOrSpecialObject_0.method_52())
		{
			if (!framework_1.aWv.ContainsKey(item))
			{
				continue;
			}
			foreach (SettingOrSpecialObject item2 in framework_1.aWv[item].method_1())
			{
				if (!(item2 is Setting))
				{
					continue;
				}
				Setting setting = item2 as Setting;
				if (setting.method_72() || !(setting.method_2() == Class333.smethod_1137()))
				{
					continue;
				}
				if (setting.method_219())
				{
					break;
				}
				Setting setting2 = framework_0.method_31(setting.method_64());
				if (bool_3 || ((!bool_2 || !setting.method_96()) && (!bool_1 || (setting2 != null && !setting2.method_96()))))
				{
					TreeNode treeNode = new TreeNode(setting.method_22(bool_0: true));
					if (bool_5)
					{
						treeNode.Checked = true;
					}
					treeNode.ForeColor = Color.Gray;
					treeNode.Tag = setting;
					treeNode_1.Nodes.Add(treeNode);
					bool_6 = true;
					hashSet_0.Add(setting.method_69());
					if (setting2 != null && !setting.method_282(setting2))
					{
						list_0.Add(treeNode);
					}
				}
				break;
			}
		}
	}

	private void method_16(List<TreeNode> list_1)
	{
		for (int i = 0; i < list_1.Count; i++)
		{
			TreeNode treeNode = list_1[i];
			if (treeNode.Tag is Setting)
			{
				Setting setting = treeNode.Tag as Setting;
				if (!hashSet_1.Contains(setting.method_69()))
				{
					method_4(treeNode);
				}
			}
			else if (treeNode.Tag is MenuNode)
			{
				MenuNode obj = treeNode.Tag as MenuNode;
				int int_ = obj.method_3();
				int int_2 = obj.method_20();
				SettingOrSpecialObject settingOrSpecialObject = framework_1.method_33(int_);
				if (framework_1.method_33(int_2) == null && settingOrSpecialObject != null)
				{
					Interface4 @interface = settingOrSpecialObject.method_11();
					if (@interface != null)
					{
						if (@interface.NodeShouldBeOrange(treeNode, hashSet_1))
						{
							method_4(treeNode);
						}
					}
					else
					{
						_ = settingOrSpecialObject.method_1().Count;
					}
				}
			}
			List<TreeNode> list = new List<TreeNode>();
			foreach (TreeNode node in treeNode.Nodes)
			{
				list.Add(node);
			}
			method_16(list);
		}
	}

	private void themedButton_2_Click(object sender, EventArgs e)
	{
		method_17(treeViewWithThemedScrollBars_0.method_2(), bool_5: true);
		treeViewWithThemedScrollBars_0.Invalidate();
	}

	private void themedButton_3_Click(object sender, EventArgs e)
	{
		method_17(treeViewWithThemedScrollBars_0.method_2(), bool_5: false);
		treeViewWithThemedScrollBars_0.Invalidate();
	}

	private void method_17(List<TreeNode> list_1, bool bool_5)
	{
		for (int i = 0; i < list_1.Count; i++)
		{
			TreeNode treeNode = list_1[i];
			if (treeNode.Tag is MenuNode)
			{
				MenuNode menuNode = treeNode.Tag as MenuNode;
				SettingOrSpecialObject settingOrSpecialObject = framework_1.method_33(menuNode.method_20());
				if (settingOrSpecialObject != null)
				{
					List<Class245> list = new List<Class245>();
					PortFunction.smethod_23(settingOrSpecialObject, bool_0: false, bool_1: true, list);
					List<Class244> list2 = new List<Class244>();
					PortFunction.smethod_24(settingOrSpecialObject, bool_0: false, list2, bool_0);
					foreach (TreeNode node in treeNode.Nodes)
					{
						if (!(node.Tag is Setting))
						{
							continue;
						}
						Setting setting = node.Tag as Setting;
						if ((setting is Class245 && list.Contains(setting as Class245)) || (setting is Class244 && list2.Contains(setting as Class244)))
						{
							if (bool_5)
							{
								node.Checked = true;
							}
							else
							{
								node.Checked = false;
							}
						}
					}
				}
			}
			List<TreeNode> list3 = new List<TreeNode>();
			foreach (TreeNode node2 in treeNode.Nodes)
			{
				list3.Add(node2);
			}
			method_17(list3, bool_5);
		}
	}

	private void method_18(List<TreeNode> list_1)
	{
		for (int i = 0; i < list_1.Count; i++)
		{
			TreeNode treeNode = list_1[i];
			if (treeNode.Checked)
			{
				if (treeNode.Tag is Setting)
				{
					(treeNode.Tag as Setting).method_113(framework_0, bool_0: false, bool_1: true);
				}
				else if (treeNode.Tag is MenuNode)
				{
					MenuNode menuNode = treeNode.Tag as MenuNode;
					foreach (int item2 in menuNode.method_103())
					{
						framework_1.method_31(item2)?.method_113(framework_0, bool_0: false, bool_1: true);
					}
					if (menuNode.method_79())
					{
						framework_1.method_31(menuNode.method_73())?.method_113(framework_0, bool_0: false);
					}
					int int_ = menuNode.method_3();
					int int_2 = menuNode.method_20();
					SettingOrSpecialObject settingOrSpecialObject = framework_1.method_33(int_);
					if (framework_1.method_33(int_2) == null && settingOrSpecialObject != null)
					{
						Interface4 @interface = settingOrSpecialObject.method_11();
						if (@interface != null)
						{
							@interface.ImportFromAnotherFramework(framework_0, markForWrite: false);
						}
						else
						{
							_ = settingOrSpecialObject.method_1().Count;
						}
					}
				}
			}
			List<TreeNode> list = new List<TreeNode>();
			foreach (TreeNode node in treeNode.Nodes)
			{
				list.Add(node);
			}
			method_18(list);
		}
	}

	[SpecialName]
	internal bool method_19()
	{
		return bool_4;
	}

	[SpecialName]
	internal string method_20()
	{
		return string_0;
	}

	[SpecialName]
	internal string method_21()
	{
		return string_1;
	}

	private void method_22(bool bool_5)
	{
		bool_4 = false;
		string_0 = string.Empty;
		string_1 = string.Empty;
		if (treeNode_0 == null)
		{
			return;
		}
		foreach (TreeNode node in treeNode_0.Nodes)
		{
			if (!(node.Checked | bool_5) || !(node.Tag is Setting))
			{
				continue;
			}
			Setting setting = node.Tag as Setting;
			if (setting.method_64() != 1501)
			{
				continue;
			}
			Setting setting2 = framework_0.method_31(1501);
			if (setting2 != null)
			{
				string text = setting.method_260();
				string text2 = setting2.method_260();
				if (text2 != text && !string.IsNullOrEmpty(text2))
				{
					bool_4 = true;
					string_0 = text;
					string_1 = text2;
				}
			}
			break;
		}
	}

	private void Form19_FormClosing(object sender, FormClosingEventArgs e)
	{
		bool flag = DialogResult == DialogResult.OK;
		bool flag2 = DialogResult == DialogResult.Yes;
		bool flag3 = true;
		foreach (TreeNode item in treeViewWithThemedScrollBars_0.method_2())
		{
			if (item.Checked)
			{
				if (TreeViewWithThemedScrollBars.smethod_2(item))
				{
					flag3 = false;
					break;
				}
				continue;
			}
			flag3 = false;
			break;
		}
		if (flag | flag2)
		{
			Class326.smethod_1(this, flag2, flag3, framework_0, framework_1, out var flag4);
			if (flag4)
			{
				e.Cancel = true;
				return;
			}
		}
		treeViewWithThemedScrollBars_0.method_44(method_2);
		Form23.smethod_8(method_0);
		if (flag | flag2)
		{
			method_22(flag2);
			if (Form23.framework_1 != null)
			{
				Form23.framework_1.method_56();
				Form23.form23_0.control25_0.method_33()?.method_12().method_10();
			}
			if (treeViewWithThemedScrollBars_0.method_2().Count == 0 && !bool_0 && (bool_1 || bool_2))
			{
				Form54.smethod_6(this, Class333.smethod_1197(), Class333.smethod_1198(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			lock (framework_1.method_25())
			{
				framework_1.method_48(framework_1.aWS);
				bool flag5 = framework_1.method_53();
				framework_1.method_55();
				bool flag6 = bool_0 && bool_2 && ((treeViewWithThemedScrollBars_0.method_2().Count == 0) | flag2);
				if ((bool_3 && (flag3 | flag2)) | flag6)
				{
					if (framework_0.awZ == framework_1.awZ && framework_0.awz == framework_1.awz && framework_0.aXA == framework_1.aXA)
					{
						framework_0.method_8(framework_1.method_7());
						framework_0.aXc = framework_1.aXc;
						framework_0.aXD = framework_1.aXD;
						List<byte[]> list = new List<byte[]>();
						if (!bool_0)
						{
							for (int i = 0; i < framework_1.aWw.Count; i++)
							{
								Setting setting = framework_1.aWw[i];
								list.Add(setting.method_259());
							}
						}
						framework_1 = framework_0;
						if (!bool_0)
						{
							for (int j = 0; j < framework_1.aWw.Count; j++)
							{
								framework_1.aWw[j].method_275(list[j], bool_0: false);
							}
						}
						if (!bool_0)
						{
							foreach (Setting item2 in framework_1.awv)
							{
								Class247.smethod_4(item2, bool_0: false);
							}
						}
					}
					else
					{
						framework_1.method_69(framework_0, framework_1.aWS, bool_0: false, bool_1: false, bool_2: true);
						framework_1.method_70(framework_0, bool_0: false);
					}
				}
				else
				{
					method_18(treeViewWithThemedScrollBars_0.method_2());
				}
				framework_1.method_58();
				framework_1.method_37(framework_1.awj);
				framework_1.method_42(null);
				if (flag5)
				{
					framework_1.method_54(bool_0: true);
				}
				framework_1.method_49(framework_1.aWS);
				PortFunction.smethod_41(framework_1, bool_0: false);
			}
			Form23.framework_1 = framework_1;
		}
		framework_1.method_37(framework_1.awj);
		framework_1.method_42(null);
		framework_1.method_40(null, Form23.framework_0, Form23.hashSet_0);
		framework_1.method_38(null);
		framework_1 = null;
		framework_0 = null;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_23()
	{
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		treeViewWithThemedScrollBars_1 = new TreeViewWithThemedScrollBars();
		treeViewWithThemedScrollBars_0 = new TreeViewWithThemedScrollBars();
		label_4 = new Label();
		label_5 = new Label();
		themedButton_2 = new ThemedButton();
		themedButton_3 = new ThemedButton();
		themedButton_4 = new ThemedButton();
		SuspendLayout();
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_0.Location = new Point(912, 597);
		themedButton_0.Name = Class333.smethod_1199();
		themedButton_0.Size = new Size(145, 38);
		themedButton_0.TabIndex = 0;
		themedButton_0.Text = Class333.smethod_1200();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_1.Location = new Point(1158, 597);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(73, 38);
		themedButton_1.TabIndex = 2;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.Location = new Point(12, 4);
		label_0.Name = Class333.smethod_1201();
		label_0.Size = new Size(121, 13);
		label_0.TabIndex = 2;
		label_0.Text = Class333.smethod_1202();
		label_1.AutoSize = true;
		label_1.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_1.Location = new Point(10, 73);
		label_1.Name = Class333.smethod_1203();
		label_1.Size = new Size(252, 13);
		label_1.TabIndex = 3;
		label_1.Text = Class333.smethod_1182();
		label_2.AutoSize = true;
		label_2.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_2.Location = new Point(12, 23);
		label_2.Name = Class333.smethod_1142();
		label_2.Size = new Size(155, 13);
		label_2.TabIndex = 4;
		label_2.Text = Class333.smethod_1204();
		label_3.AutoSize = true;
		label_3.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_3.Location = new Point(857, 73);
		label_3.Name = Class333.smethod_1205();
		label_3.Size = new Size(353, 13);
		label_3.TabIndex = 10;
		label_3.Text = Class333.smethod_1206();
		treeViewWithThemedScrollBars_1.method_12(bool_3: true);
		treeViewWithThemedScrollBars_1.AutoScroll = true;
		treeViewWithThemedScrollBars_1.BorderStyle = BorderStyle.FixedSingle;
		treeViewWithThemedScrollBars_1.method_10(bool_3: false);
		treeViewWithThemedScrollBars_1.method_1(Enum45.const_0);
		treeViewWithThemedScrollBars_1.Font = new Font(Class333.smethod_145(), 9f);
		treeViewWithThemedScrollBars_1.method_14(null);
		treeViewWithThemedScrollBars_1.Location = new Point(858, 91);
		treeViewWithThemedScrollBars_1.Name = Class333.smethod_1207();
		treeViewWithThemedScrollBars_1.method_4(null);
		treeViewWithThemedScrollBars_1.Size = new Size(374, 499);
		treeViewWithThemedScrollBars_1.TabIndex = 6;
		treeViewWithThemedScrollBars_0.method_12(bool_3: true);
		treeViewWithThemedScrollBars_0.AutoScroll = true;
		treeViewWithThemedScrollBars_0.BorderStyle = BorderStyle.FixedSingle;
		treeViewWithThemedScrollBars_0.method_10(bool_3: true);
		treeViewWithThemedScrollBars_0.method_1(Enum45.const_0);
		treeViewWithThemedScrollBars_0.Font = new Font(Class333.smethod_145(), 9f);
		treeViewWithThemedScrollBars_0.method_14(null);
		treeViewWithThemedScrollBars_0.Location = new Point(8, 91);
		treeViewWithThemedScrollBars_0.Name = Class333.smethod_1208();
		treeViewWithThemedScrollBars_0.method_4(null);
		treeViewWithThemedScrollBars_0.Size = new Size(844, 499);
		treeViewWithThemedScrollBars_0.TabIndex = 5;
		label_4.AutoSize = true;
		label_4.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_4.Location = new Point(12, 41);
		label_4.Name = Class333.smethod_1209();
		label_4.Size = new Size(148, 13);
		label_4.TabIndex = 11;
		label_4.Text = Class333.smethod_1210();
		label_5.AutoSize = true;
		label_5.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_5.Location = new Point(490, 610);
		label_5.Name = Class333.smethod_1211();
		label_5.Size = new Size(283, 13);
		label_5.TabIndex = 12;
		label_5.Text = Class333.smethod_1212();
		themedButton_2.Enabled = false;
		themedButton_2.Location = new Point(8, 601);
		themedButton_2.Name = Class333.smethod_1213();
		themedButton_2.Size = new Size(157, 28);
		themedButton_2.TabIndex = 3;
		themedButton_2.Text = Class333.smethod_1214();
		themedButton_2.UseVisualStyleBackColor = true;
		themedButton_2.Click += themedButton_2_Click;
		themedButton_3.Enabled = false;
		themedButton_3.Location = new Point(171, 601);
		themedButton_3.Name = Class333.smethod_1215();
		themedButton_3.Size = new Size(182, 28);
		themedButton_3.TabIndex = 4;
		themedButton_3.Text = Class333.smethod_1216();
		themedButton_3.UseVisualStyleBackColor = true;
		themedButton_3.Click += themedButton_3_Click;
		themedButton_4.DialogResult = DialogResult.Yes;
		themedButton_4.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_4.Location = new Point(1062, 597);
		themedButton_4.Name = Class333.smethod_1217();
		themedButton_4.Size = new Size(91, 38);
		themedButton_4.TabIndex = 1;
		themedButton_4.Text = Class333.smethod_1218();
		themedButton_4.UseVisualStyleBackColor = true;
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(1240, 642);
		Controls.Add(themedButton_4);
		Controls.Add(themedButton_3);
		Controls.Add(themedButton_2);
		Controls.Add(label_5);
		Controls.Add(label_4);
		Controls.Add(label_3);
		Controls.Add(treeViewWithThemedScrollBars_1);
		Controls.Add(treeViewWithThemedScrollBars_0);
		Controls.Add(label_2);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_1219();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1181();
		FormClosing += Form19_FormClosing;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
