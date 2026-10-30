using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Resources;
using NSP.Resources.TreeIcons;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns1;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns2;

internal class Control4 : UserControl
{
	private enum Enum37
	{
		BlA,
		Bla,
		BlB
	}

	private delegate void Delegate24(bool bool_0, bool bool_1, bool bool_2, bool bool_3);

	private delegate void Delegate25(bool bool_0);

	private delegate void Delegate26(bool bool_0);

	private static readonly string string_0 = Form23.string_3 + Class333.smethod_560();

	private ThemedButton themedButton_0 = new ThemedButton();

	private PictureBox pictureBox_0 = new PictureBox();

	private ThemedTextBox themedTextBox_0 = new ThemedTextBox();

	private ThemedButton themedButton_1 = new ThemedButton();

	private Timer timer_0 = new Timer();

	private TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_0 = new TreeViewWithThemedScrollBars();

	private Panel panel_0 = new Panel();

	private ThemedButton themedButton_2 = new ThemedButton();

	private ThemedButton themedButton_3 = new ThemedButton();

	private ThemedButton themedButton_4 = new ThemedButton();

	private ThemedButton themedButton_5 = new ThemedButton();

	private Stack<TreeNode> stack_0 = new Stack<TreeNode>();

	private Stack<TreeNode> stack_1 = new Stack<TreeNode>();

	private ContextMenuStrip contextMenuStrip_0 = new ContextMenuStrip();

	private ContextMenuStrip contextMenuStrip_1 = new ContextMenuStrip();

	private Class134 class134_0 = new Class134();

	private const int int_0 = 0;

	private const int int_1 = 1;

	private const int int_2 = 120;

	private const int int_3 = 5;

	private const int int_4 = 160;

	private bool bool_0;

	private bool bool_1;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private bool bool_2;

	private bool bool_3 = true;

	private List<int> list_0 = new List<int>();

	private SettingOrSpecialObject settingOrSpecialObject_0;

	private TreeNode treeNode_0;

	private TreeNode treeNode_1;

	internal Enum88 enum88_0;

	private MenuNode menuNode_0;

	internal bool bool_4;

	private bool bool_5;

	private bool bool_6;

	internal Control4()
	{
		MouseDown += Control4_MouseDown;
		MouseUp += Control4_MouseUp;
		MouseMove += Control4_MouseMove;
		MouseLeave += Control4_MouseLeave;
		treeViewWithThemedScrollBars_0.method_21(method_69);
		treeViewWithThemedScrollBars_0.method_23(method_71);
		treeViewWithThemedScrollBars_0.method_25(method_70);
		treeViewWithThemedScrollBars_0.MouseClick += treeViewWithThemedScrollBars_0_MouseClick;
		pictureBox_0.BackColor = BackColor;
		if (pictureBox_0.Image != null)
		{
			pictureBox_0.Image.Dispose();
		}
		pictureBox_0.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		pictureBox_0.Width = 24;
		pictureBox_0.Height = 24;
		themedTextBox_0.Enabled = false;
		themedTextBox_0.TextChanged += themedTextBox_0_TextChanged;
		themedTextBox_0.method_0(method_99);
		themedButton_1.Enabled = false;
		themedButton_1.Click += themedButton_1_Click;
		themedButton_1.Text = Class333.smethod_330();
		themedButton_1.Font = new Font(themedButton_1.Font.FontFamily, 8f, FontStyle.Bold);
		timer_0.Interval = 400;
		timer_0.Tick += timer_0_Tick;
		method_9();
		Controls.Add(pictureBox_0);
		Controls.Add(themedTextBox_0);
		Controls.Add(themedButton_1);
		Controls.Add(treeViewWithThemedScrollBars_0);
		themedButton_0.Click += themedButton_0_Click;
		themedButton_0.Text = Class333.smethod_524();
		themedButton_0.Enabled = false;
		Controls.Add(themedButton_0);
		class134_0.ReadOnly = true;
		class134_0.ScrollBars = RichTextBoxScrollBars.Vertical;
		class134_0.Height = 120;
		Controls.Add(class134_0);
		themedButton_2.AutoSize = false;
		themedButton_2.Height = 24;
		themedButton_2.Click += themedButton_2_Click;
		themedButton_2.Text = Class333.smethod_525();
		themedButton_2.Enabled = false;
		themedButton_3.AutoSize = false;
		themedButton_3.Height = 24;
		themedButton_3.ImageAlign = ContentAlignment.MiddleCenter;
		themedButton_3.Image = Form23.image_2;
		themedButton_3.Click += themedButton_3_Click;
		themedButton_3.Enabled = false;
		themedButton_4.AutoSize = false;
		themedButton_4.Height = 24;
		themedButton_4.ImageAlign = ContentAlignment.MiddleCenter;
		themedButton_4.Image = Form23.image_3;
		themedButton_4.Click += themedButton_4_Click;
		themedButton_4.Enabled = false;
		themedButton_5.AutoSize = false;
		themedButton_5.Height = 24;
		themedButton_5.Click += themedButton_5_Click;
		themedButton_5.Text = Class333.smethod_525();
		themedButton_5.Enabled = false;
		panel_0.Height = themedButton_3.Height + 2;
		panel_0.Controls.Add(themedButton_2);
		panel_0.Controls.Add(themedButton_3);
		panel_0.Controls.Add(themedButton_4);
		panel_0.Controls.Add(themedButton_5);
		Controls.Add(panel_0);
	}

	[SpecialName]
	internal TreeViewWithThemedScrollBars method_0()
	{
		return treeViewWithThemedScrollBars_0;
	}

	[SpecialName]
	internal ThemedTextBox method_1()
	{
		return themedTextBox_0;
	}

	[SpecialName]
	internal Class134 method_2()
	{
		return class134_0;
	}

	[SpecialName]
	internal bool method_3()
	{
		return bool_2;
	}

	[SpecialName]
	internal void method_4(bool bool_7)
	{
		bool_2 = bool_7;
	}

	[SpecialName]
	internal bool method_5()
	{
		return bool_3;
	}

	[SpecialName]
	internal void method_6(bool bool_7)
	{
		bool_3 = bool_7;
	}

	internal void method_7()
	{
		foreach (TreeNode item in treeViewWithThemedScrollBars_0.method_2())
		{
			method_8(item);
		}
		treeViewWithThemedScrollBars_0.method_2().Clear();
		treeViewWithThemedScrollBars_0.Invalidate();
		stack_0.Clear();
		stack_1.Clear();
		method_72();
		method_73();
		class134_0.Clear();
		class134_0.method_0();
	}

	private void method_8(TreeNode treeNode_2)
	{
		treeNode_2.Tag = null;
		foreach (TreeNode node in treeNode_2.Nodes)
		{
			method_8(node);
		}
	}

	internal void method_9()
	{
		treeViewWithThemedScrollBars_0.BackColor = Form23.color_16;
		treeViewWithThemedScrollBars_0.ForeColor = Form23.color_12;
		treeViewWithThemedScrollBars_0.BorderStyle = (Form23.bool_43 ? BorderStyle.FixedSingle : BorderStyle.None);
		pictureBox_0.BackColor = BackColor;
		if (pictureBox_0.Image != null)
		{
			pictureBox_0.Image.Dispose();
		}
		pictureBox_0.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		themedButton_3.Image = Form23.image_2;
		themedButton_4.Image = Form23.image_3;
		class134_0.BackColor = Form23.color_16;
	}

	internal void method_10()
	{
		themedButton_0.Width = Width - 5;
		class134_0.Width = Width - 5;
		class134_0.Top = Height - class134_0.Height;
		class134_0.method_0();
		panel_0.Width = Width - 5;
		themedButton_2.Width = 30;
		themedButton_3.Width = (panel_0.Width - 2 * themedButton_2.Width) / 2 - 1;
		themedButton_3.Left = themedButton_2.Right;
		themedButton_4.Width = themedButton_3.Width;
		themedButton_4.Left = themedButton_3.Right;
		themedButton_5.Width = themedButton_2.Width;
		themedButton_5.Left = themedButton_4.Right;
		panel_0.Top = class134_0.Top - panel_0.Height - 4;
		themedTextBox_0.Left = pictureBox_0.Right + 1;
		themedButton_1.Width = 22;
		themedTextBox_0.Top = themedButton_0.Bottom + 2;
		themedTextBox_0.Width = Width - 4 - (pictureBox_0.Width + themedButton_1.Width + 6);
		pictureBox_0.Top = themedTextBox_0.Top;
		themedButton_1.Left = themedTextBox_0.Right + 3;
		themedButton_1.Top = themedTextBox_0.Top - 2;
		themedButton_1.Height = themedTextBox_0.Height + 2;
		treeViewWithThemedScrollBars_0.Width = Width - 5;
		treeViewWithThemedScrollBars_0.Height = panel_0.Top - themedButton_0.Height - 4 - (themedButton_1.Height + 2);
		treeViewWithThemedScrollBars_0.Top = themedTextBox_0.Bottom + 2;
	}

	protected override void OnResize(EventArgs eventargs)
	{
		base.OnResize(eventargs);
		method_10();
	}

	private void method_11(ref Enum37[] enum37_0, TreeNodeCollection treeNodeCollection_0, bool bool_7)
	{
		for (int i = 0; i < treeNodeCollection_0.Count; i++)
		{
			if (!(treeNodeCollection_0[i].Tag is MenuNode))
			{
				continue;
			}
			MenuNode menuNode = (MenuNode)treeNodeCollection_0[i].Tag;
			if (menuNode.method_1() != null && (bool_7 || menuNode != Form23.menuNode_1))
			{
				int num = menuNode.method_12();
				if (treeNodeCollection_0[i].IsExpanded)
				{
					enum37_0[num] = Enum37.Bla;
				}
				else
				{
					enum37_0[num] = Enum37.BlB;
				}
				method_11(ref enum37_0, treeNodeCollection_0[i].Nodes, bool_7);
			}
		}
	}

	private void method_12(ref Enum37[] enum37_0, List<TreeNode> list_1, bool bool_7)
	{
		for (int i = 0; i < list_1.Count; i++)
		{
			if (!(list_1[i].Tag is MenuNode))
			{
				continue;
			}
			MenuNode menuNode = (MenuNode)list_1[i].Tag;
			if (menuNode.method_1() != null && (bool_7 || menuNode != Form23.menuNode_1))
			{
				int num = menuNode.method_12();
				if (list_1[i].IsExpanded)
				{
					enum37_0[num] = Enum37.Bla;
				}
				else
				{
					enum37_0[num] = Enum37.BlB;
				}
				method_11(ref enum37_0, list_1[i].Nodes, bool_7);
			}
		}
	}

	private void method_13(ref Enum37[] enum37_0)
	{
		for (int i = 0; i < treeViewWithThemedScrollBars_0.method_2().Count; i++)
		{
			MenuNode menuNode = (MenuNode)treeViewWithThemedScrollBars_0.method_2()[i].Tag;
			if (menuNode != null && menuNode.method_2() != null)
			{
				byte b = (byte)menuNode.method_2().method_0();
				enum37_0[b] = Enum37.BlB;
			}
		}
	}

	internal void method_14(bool bool_7, bool bool_8, bool bool_9, bool bool_10)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate24 method = method_14;
				Invoke(method, bool_7, bool_8, bool_9, bool_10);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.framework_1 == null)
		{
			return;
		}
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		if (treeViewWithThemedScrollBars_0.method_13() == null)
		{
			treeViewWithThemedScrollBars_0.method_14(new List<Image>());
		}
		else
		{
			treeViewWithThemedScrollBars_0.method_13().Clear();
		}
		themedButton_0.Enabled = true;
		themedTextBox_0.Enabled = true;
		themedButton_1.Enabled = true;
		Enum37[] enum37_ = null;
		Enum37[] enum37_2 = null;
		Enum37[] enum37_3 = null;
		int num = -1;
		byte b = 0;
		bool flag = false;
		if (treeViewWithThemedScrollBars_0.method_2().Count >= 2)
		{
			if (treeViewWithThemedScrollBars_0.method_3() != null && treeViewWithThemedScrollBars_0.method_3().Tag != null)
			{
				if (treeViewWithThemedScrollBars_0.method_3() == treeViewWithThemedScrollBars_0.method_2()[0])
				{
					flag = true;
				}
				else if (((MenuNode)treeViewWithThemedScrollBars_0.method_3().Tag).method_2() != null)
				{
					b = (byte)((MenuNode)treeViewWithThemedScrollBars_0.method_3().Tag).method_2().method_0();
				}
				else
				{
					num = ((MenuNode)treeViewWithThemedScrollBars_0.method_3().Tag).method_12();
				}
			}
			enum37_ = new Enum37[Form23.framework_1.method_29()];
			for (int i = 0; i < enum37_.Length; i++)
			{
				enum37_[i] = Enum37.BlA;
			}
			method_11(ref enum37_, treeViewWithThemedScrollBars_0.method_2()[1].Nodes, bool_7: true);
			if (treeViewWithThemedScrollBars_0.method_2()[1].IsExpanded)
			{
				enum37_[0] = Enum37.Bla;
			}
			else
			{
				enum37_[0] = Enum37.BlB;
			}
			enum37_2 = new Enum37[Form23.framework_1.method_29()];
			for (int j = 0; j < enum37_2.Length; j++)
			{
				enum37_2[j] = Enum37.BlA;
			}
			method_12(ref enum37_2, treeViewWithThemedScrollBars_0.method_2(), bool_7: false);
			enum37_3 = new Enum37[256];
			for (int k = 0; k < enum37_3.Length; k++)
			{
				enum37_3[k] = Enum37.BlA;
			}
			method_13(ref enum37_3);
		}
		treeViewWithThemedScrollBars_0.method_5();
		int num2 = Form23.form23_0.control25_0.method_3();
		string text = string.Empty;
		int num3 = -1;
		if (Form23.form23_0.control25_0.method_15().Count > 0 && Form23.form23_0.control25_0.method_14().Count > 0)
		{
			if (Form23.form23_0.control25_0.method_15()[num2] != -1)
			{
				num3 = Form23.form23_0.control25_0.method_15()[num2];
			}
			else if (!string.IsNullOrEmpty(Form23.form23_0.control25_0.method_14()[num2]))
			{
				text = Form23.form23_0.control25_0.method_14()[num2];
			}
		}
		if (bool_7)
		{
			treeNode_0 = null;
			treeViewWithThemedScrollBars_0.method_2().Clear();
			list_0.Clear();
			if (File.Exists(string_0))
			{
				method_94();
			}
			else
			{
				method_93();
			}
		}
		List<string> list = new List<string>();
		if (themedTextBox_0.Text != string.Empty)
		{
			string[] array = themedTextBox_0.Text.Split(' ', ',');
			for (int l = 0; l < array.Length; l++)
			{
				list.Add(array[l].ToLower());
			}
		}
		method_15(bool_7, Form23.menuNode_0, null, bool_8: false, null, bool_8, list);
		method_15(bool_7, Form23.menuNode_1, null, bool_8: false, enum37_, bool_8, list);
		foreach (MenuNode item in Form23.framework_1.awj)
		{
			method_15(bool_7, item, null, bool_8: false, enum37_2, bool_8, list);
		}
		foreach (MenuNode item2 in Form23.list_4)
		{
			method_15(bool_7, item2, null, bool_8: false, enum37_3, bool_8, list);
		}
		if (bool_7)
		{
			stack_0.Clear();
			stack_1.Clear();
			method_72();
			method_73();
		}
		if (bool_10)
		{
			method_41(treeViewWithThemedScrollBars_0.method_3());
		}
		if (Form23.form23_0.control25_0.SelectedTab != null && (Form23.form23_0.control25_0.SelectedTab as Class130).method_0() == Enum65.const_0)
		{
			if (enum88_0 != Enum88.avK)
			{
				foreach (TreeNode item3 in treeViewWithThemedScrollBars_0.method_2())
				{
					if (item3.Tag is MenuNode menuNode && menuNode.method_2() != null && menuNode.method_2().method_0() == enum88_0)
					{
						treeViewWithThemedScrollBars_0.method_4(item3);
						break;
					}
				}
				enum88_0 = Enum88.avK;
			}
			else if (bool_9)
			{
				if (!bool_7 && Form23.form23_0.control25_0.method_33() != null)
				{
					method_68(bool_7: false);
				}
				else if (flag)
				{
					treeViewWithThemedScrollBars_0.method_4(treeViewWithThemedScrollBars_0.method_2()[0]);
					method_46(treeViewWithThemedScrollBars_0.method_3(), bool_7: false);
				}
				else if (num != -1)
				{
					treeViewWithThemedScrollBars_0.method_4(method_35(num));
					if (treeViewWithThemedScrollBars_0.method_3() != null)
					{
						method_46(treeViewWithThemedScrollBars_0.method_3(), bool_7: false);
					}
				}
				else if (b != 0)
				{
					foreach (TreeNode item4 in treeViewWithThemedScrollBars_0.method_2())
					{
						if (item4.Tag is MenuNode menuNode2 && menuNode2.method_2() != null && (uint)menuNode2.method_2().method_0() == b)
						{
							treeViewWithThemedScrollBars_0.method_4(item4);
							if (treeViewWithThemedScrollBars_0.method_3() != null)
							{
								method_46(treeViewWithThemedScrollBars_0.method_3(), bool_7: false);
							}
							break;
						}
					}
				}
				else if (Form23.form23_0.control25_0.SelectedIndex == num2)
				{
					if (num3 != -1)
					{
						method_48(num3);
						if (treeViewWithThemedScrollBars_0.method_3() == null && treeNode_0 != null)
						{
							treeViewWithThemedScrollBars_0.method_4(treeNode_0);
						}
					}
					else if (text != string.Empty)
					{
						method_58(text);
						if (treeViewWithThemedScrollBars_0.method_3() == null && treeNode_0 != null)
						{
							treeViewWithThemedScrollBars_0.method_4(treeNode_0);
						}
					}
					else if (treeNode_0 != null)
					{
						treeViewWithThemedScrollBars_0.method_4(treeNode_0);
					}
				}
			}
		}
		treeViewWithThemedScrollBars_0.method_6();
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.smethod_526(), stopwatch.ElapsedMilliseconds));
	}

	private void method_15(bool bool_7, MenuNode menuNode_1, TreeNode treeNode_2, bool bool_8, Enum37[] enum37_0, bool bool_9, List<string> list_1)
	{
		string text = menuNode_1.method_10();
		int num = menuNode_1.method_3();
		int num2 = menuNode_1.method_20();
		int int_ = menuNode_1.method_12();
		bool flag = menuNode_1.method_16();
		byte byte_ = 0;
		Class235 @class = menuNode_1.method_2();
		if (@class != null)
		{
			byte_ = (byte)@class.method_0();
		}
		SettingOrSpecialObject settingOrSpecialObject = Form23.framework_1.method_33(num);
		SettingOrSpecialObject settingOrSpecialObject2 = Form23.framework_1.method_33(num2);
		if (bool_8 && settingOrSpecialObject is Table)
		{
			text = settingOrSpecialObject.method_60(Enum96.aYt);
		}
		TreeNode treeNode = method_18(bool_7, menuNode_1, treeNode_2, enum37_0, int_, @class, byte_, bool_8);
		string text2 = method_20(text, menuNode_1, settingOrSpecialObject, settingOrSpecialObject2, @class);
		string text3 = text;
		string text4 = text;
		if (!string.IsNullOrEmpty(text2))
		{
			text3 = text2;
			text4 = text2 + Class333.smethod_497() + text + Class333.smethod_9();
		}
		TreeNode treeNode2 = null;
		if (treeNode != null)
		{
			treeNode2 = treeNode;
			if (bool_4 && !string.IsNullOrEmpty(menuNode_1.method_66()))
			{
				string text5 = text3 + Class333.smethod_527() + menuNode_1.method_66() + Class333.smethod_528();
				if (treeNode.Text != text5)
				{
					treeNode.Text = text5;
				}
			}
			else if (treeNode.Text != text3)
			{
				treeNode.Text = text3;
			}
			if (treeNode.ToolTipText != text4)
			{
				treeNode.ToolTipText = text4;
			}
		}
		else
		{
			treeNode2 = ((!bool_4 || string.IsNullOrEmpty(menuNode_1.method_66())) ? new Class171(text3) : new Class171(text3 + Class333.smethod_527() + menuNode_1.method_66() + Class333.smethod_528()));
			treeNode2.ToolTipText = text4;
			(treeNode2 as Class171).bool_0 = !menuNode_1.method_38();
		}
		treeNode2.ImageIndex = method_21(menuNode_1);
		treeNode2.Tag = menuNode_1;
		if (treeNode_2 != null && treeNode_2.ForeColor == Color.Gray)
		{
			treeNode2.ForeColor = Color.Gray;
		}
		else
		{
			treeNode2.ForeColor = Form23.color_12;
		}
		if (Form23.framework_1.awZ == 21)
		{
			if (menuNode_1 == Form23.framework_1.awR)
			{
				treeNode_0 = treeNode2;
			}
		}
		else if (settingOrSpecialObject != null && treeNode_2 != null && settingOrSpecialObject.method_2() == Class333.smethod_529())
		{
			treeNode_0 = treeNode_2;
		}
		if (menuNode_1.method_5() != null)
		{
			if ((menuNode_1.method_5().method_29() || (menuNode_1.method_31() && !menuNode_1.method_5().method_37()) || ((!menuNode_1.method_31() || !menuNode_1.method_5().method_37()) && menuNode_1.method_28()) || menuNode_1.method_5().method_38()) && menuNode_1.method_5().method_20() == -1)
			{
				treeNode2.Tag = null;
				return;
			}
			if (((Form23.framework_1.awZ == 20 && Form23.framework_1.aXA < new Class14(1, 21, 0, 4, 0)) || (Class242.smethod_12(Form23.framework_1.awZ) && Form23.framework_1.aXA < new Class14(3, 8, 0, 4, 0))) && text == Class333.smethod_279())
			{
				treeNode2.Tag = null;
				return;
			}
		}
		if (method_25(menuNode_1, treeNode2, treeNode, treeNode_2, settingOrSpecialObject, settingOrSpecialObject2, @class, bool_8, list_1) || method_22(menuNode_1, treeNode2, treeNode, treeNode_2) || method_23(menuNode_1, treeNode2, treeNode, treeNode_2, settingOrSpecialObject))
		{
			return;
		}
		if (Form23.framework_1.awA || !bool_8)
		{
			if (menuNode_1 == Form23.menuNode_1)
			{
				method_16(bool_7, treeNode2, enum37_0, bool_9, list_1);
			}
			else
			{
				foreach (MenuNode item in menuNode_1.method_6())
				{
					method_15(bool_7, item, treeNode2, bool_8, enum37_0, bool_9, list_1);
				}
			}
		}
		bool flag2 = true;
		if (list_1.Count != 0)
		{
			flag2 = method_45(menuNode_1, list_1);
		}
		bool flag3 = method_31(menuNode_1, treeNode2.GetNodeCount(includeSubTrees: true), list_1);
		bool flag4 = menuNode_1.method_37() || menuNode_1.method_38() || menuNode_1.method_45();
		bool flag5 = menuNode_1 == Form23.framework_1.awU || menuNode_1 == Form23.framework_1.awu || menuNode_1 == Form23.framework_1.awV;
		if (!flag3 && menuNode_1 != Form23.menuNode_2 && ((settingOrSpecialObject == null && settingOrSpecialObject2 == null && !flag4) || !flag2) && @class == null && menuNode_1 != Form23.menuNode_0 && !flag5)
		{
			Setting setting = null;
			if (menuNode_1.method_79() && !menuNode_1.method_86())
			{
				setting = Form23.framework_1.method_31(menuNode_1.method_73());
			}
			if ((setting == null || setting.method_280() || !flag2 || (Form23.class286_0 != null && !Form23.list_0.Contains(setting.method_64()))) && method_24(treeNode2, treeNode, treeNode_2))
			{
				return;
			}
		}
		if (flag || list_1.Count != 0 || Form23.class286_0 != null)
		{
			treeNode2.Expand();
		}
		if (bool_7 || treeNode == null)
		{
			method_34(bool_7, treeNode2, treeNode_2, int_, @class, byte_, bool_8);
		}
		if (bool_9 && enum37_0 != null)
		{
			method_19(treeNode2, menuNode_1, enum37_0, settingOrSpecialObject, @class, int_);
		}
		method_17(treeNode2, menuNode_1, settingOrSpecialObject, settingOrSpecialObject2, @class);
		if ((menuNode_1.method_29() || menuNode_1.method_31()) && treeNode2.Parent != null && treeNode2.Nodes.Count != 0)
		{
			while (treeNode2.Nodes.Count != 0)
			{
				TreeNode node = treeNode2.Nodes[0];
				treeNode2.Nodes.Remove(node);
				treeNode2.Parent.Nodes.Add(node);
			}
			treeNode2.Tag = null;
			method_32(treeNode2, treeNode_2);
		}
	}

	private void method_16(bool bool_7, TreeNode treeNode_2, Enum37[] enum37_0, bool bool_8, List<string> list_1)
	{
		if (Form23.framework_1.awA)
		{
			foreach (int item in list_0)
			{
				if (Form23.framework_1.awB.ContainsKey(item))
				{
					MenuNode menuNode_ = Form23.framework_1.awB[item];
					method_15(bool_7, menuNode_, treeNode_2, bool_8: true, enum37_0, bool_8, list_1);
				}
			}
			List<TreeNode> list = new List<TreeNode>();
			foreach (TreeNode node in treeNode_2.Nodes)
			{
				if (node.Tag is MenuNode menuNode && !list_0.Contains(menuNode.method_60()))
				{
					list.Add(node);
				}
			}
			{
				foreach (TreeNode item2 in list)
				{
					MenuNode menuNode_2 = item2.Tag as MenuNode;
					method_15(bool_7, menuNode_2, treeNode_2, bool_8: true, enum37_0, bool_8, list_1);
				}
				return;
			}
		}
		foreach (Table item3 in Form23.framework_1.aWV)
		{
			MenuNode menuNode2 = MenuNode.smethod_2(Form23.framework_1.awj, item3.method_69());
			if (menuNode2 != null)
			{
				method_15(bool_7, menuNode2, treeNode_2, bool_8: true, enum37_0, bool_8, list_1);
			}
		}
	}

	private void method_17(TreeNode treeNode_2, MenuNode menuNode_1, SettingOrSpecialObject settingOrSpecialObject_1, SettingOrSpecialObject settingOrSpecialObject_2, Class235 class235_0)
	{
		if (!(treeNode_2 is Class171))
		{
			return;
		}
		bool flag = menuNode_1 == Form23.framework_1.awU || menuNode_1 == Form23.framework_1.awu || menuNode_1 == Form23.framework_1.awV;
		bool flag2 = false;
		if ((settingOrSpecialObject_1 != null || settingOrSpecialObject_2 != null || class235_0 != null || menuNode_1 == Form23.menuNode_0 || (treeNode_2.Parent == null && menuNode_1 != Form23.menuNode_1)) | flag)
		{
			flag2 = true;
		}
		else
		{
			foreach (MenuNode item in menuNode_1.method_6())
			{
				if (item.method_28())
				{
					flag2 = true;
					break;
				}
			}
		}
		(treeNode_2 as Class171).bool_1 = flag2;
	}

	private TreeNode method_18(bool bool_7, MenuNode menuNode_1, TreeNode treeNode_2, Enum37[] enum37_0, int int_9, Class235 class235_0, byte byte_0, bool bool_8)
	{
		TreeNode result = null;
		if (!bool_7 && (enum37_0 != null || menuNode_1 == Form23.menuNode_0 || menuNode_1 == Form23.menuNode_1))
		{
			if (menuNode_1 == Form23.menuNode_0)
			{
				if (treeViewWithThemedScrollBars_0.method_2().Count != 0)
				{
					result = treeViewWithThemedScrollBars_0.method_2()[0];
				}
			}
			else if (menuNode_1 == Form23.menuNode_1)
			{
				if (treeViewWithThemedScrollBars_0.method_2().Count >= 2)
				{
					result = treeViewWithThemedScrollBars_0.method_2()[1];
				}
			}
			else if (class235_0 != null)
			{
				if (enum37_0[byte_0] != Enum37.BlA)
				{
					foreach (TreeNode item in treeViewWithThemedScrollBars_0.method_2())
					{
						if (item.Tag is MenuNode menuNode && menuNode.method_2() != null && (uint)menuNode.method_2().method_0() == byte_0)
						{
							result = item;
							break;
						}
					}
				}
			}
			else if (enum37_0[int_9] != Enum37.BlA)
			{
				if (bool_8)
				{
					foreach (TreeNode node in treeNode_2.Nodes)
					{
						if (node.Tag is MenuNode menuNode2 && menuNode2.method_12() == int_9)
						{
							result = node;
							break;
						}
					}
				}
				else
				{
					result = method_35(int_9);
				}
			}
		}
		return result;
	}

	private void method_19(TreeNode treeNode_2, MenuNode menuNode_1, Enum37[] enum37_0, SettingOrSpecialObject settingOrSpecialObject_1, Class235 class235_0, int int_9)
	{
		if (menuNode_1 != Form23.menuNode_0 && class235_0 == null)
		{
			if (menuNode_1 == Form23.menuNode_1)
			{
				if (enum37_0[0] == Enum37.Bla)
				{
					treeNode_2.Expand();
				}
				else
				{
					treeNode_2.Collapse();
				}
			}
			else if (enum37_0[int_9] == Enum37.Bla)
			{
				treeNode_2.Expand();
			}
			else
			{
				treeNode_2.Collapse();
			}
		}
		else
		{
			treeNode_2.Collapse();
		}
	}

	private string method_20(string string_1, MenuNode menuNode_1, SettingOrSpecialObject settingOrSpecialObject_1, SettingOrSpecialObject settingOrSpecialObject_2, Class235 class235_0)
	{
		string text = string.Empty;
		if (settingOrSpecialObject_1 != null)
		{
			text = settingOrSpecialObject_1.method_18();
		}
		if (string.IsNullOrWhiteSpace(text))
		{
			if (class235_0 != null)
			{
				Enum88 key = class235_0.method_0();
				if (Form23.framework_1.awf.ContainsKey((byte)key))
				{
					text = Form23.framework_1.awf[(byte)key].method_18();
				}
			}
			else if (menuNode_1.method_37())
			{
				int num = menuNode_1.method_39();
				Class250 @class = Form23.framework_1.awP.method_79()[num];
				int num2 = Form23.framework_1.awP.method_73().method_256();
				text = @class.method_18();
				if (num == num2)
				{
					text = ((!string.IsNullOrWhiteSpace(text)) ? (text + Class333.smethod_530()) : (string_1 + Class333.smethod_530()));
				}
			}
			else if (menuNode_1.method_38())
			{
				int num3 = menuNode_1.method_5().method_5().method_39();
				int num4 = menuNode_1.method_41();
				try
				{
					Class243 class2 = Form23.framework_1.awP.method_79()[num3].method_72()[num4];
					text = class2.method_18();
					if (!string.IsNullOrWhiteSpace(text))
					{
						string text2 = class2.method_286();
						text = (string.IsNullOrEmpty(text2) ? (text + Class333.smethod_497() + string_1 + Class333.smethod_9()) : (text + Class333.smethod_497() + text2 + Class333.smethod_9()));
					}
				}
				catch
				{
					Class23.smethod_3(string.Format(Class333.smethod_531(), num4, num3, menuNode_1.method_10()));
				}
			}
			else if (menuNode_1.method_45())
			{
				int index = menuNode_1.method_46();
				text = Form23.framework_1.awp.method_73()[index].method_18();
			}
			else if (Form23.framework_1.aWz)
			{
				if (menuNode_1.method_22() != 0)
				{
					Setting setting = Form23.framework_1.method_31(menuNode_1.method_22());
					if (setting != null && setting.method_6() != null && setting.method_6() is SpecialObject && Form23.framework_1.aWY.Contains(setting.method_6()))
					{
						text = setting.method_6().method_18();
					}
				}
			}
			else if (settingOrSpecialObject_2 != null)
			{
				text = settingOrSpecialObject_2.method_18();
			}
		}
		return text;
	}

	private int method_21(MenuNode menuNode_1)
	{
		Image image = null;
		if (menuNode_1.method_68() != null)
		{
			image = (Bitmap)TreeIconsResources.ResourceManager.GetObject(menuNode_1.method_68(), CultureInfo.CurrentCulture);
		}
		int result = -1;
		if (image != null)
		{
			result = treeViewWithThemedScrollBars_0.method_13().Count;
			treeViewWithThemedScrollBars_0.method_13().Add(image);
		}
		return result;
	}

	private bool method_22(MenuNode menuNode_1, TreeNode treeNode_2, TreeNode treeNode_3, TreeNode treeNode_4)
	{
		if (menuNode_1.method_1() != null)
		{
			SettingOrSpecialObject settingOrSpecialObject = menuNode_1.method_1().method_33(menuNode_1.method_3());
			if (settingOrSpecialObject is Table)
			{
				Table table = settingOrSpecialObject as Table;
				MenuNode menuNode = menuNode_1.method_83(table.TableDataSetting);
				if (menuNode != null && menuNode.method_84() && menuNode != menuNode_1)
				{
					HashSet<DataIdAndAttrId> idsContained = table.GetIdsContained();
					bool flag = true;
					foreach (DataIdAndAttrId item in idsContained)
					{
						Setting setting = menuNode_1.method_1().method_32(item);
						if (setting != null && setting.method_76())
						{
							flag = false;
							break;
						}
					}
					if (flag && method_24(treeNode_2, treeNode_3, treeNode_4))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private bool method_23(MenuNode menuNode_1, TreeNode treeNode_2, TreeNode treeNode_3, TreeNode treeNode_4, SettingOrSpecialObject settingOrSpecialObject_1)
	{
		if (Form23.class286_0 != null && (!menuNode_1.method_79() || (menuNode_1 != Form23.menuNode_2 && !Form23.list_0.Contains(menuNode_1.method_73()))))
		{
			if (settingOrSpecialObject_1 is Table)
			{
				Table table = settingOrSpecialObject_1 as Table;
				if ((table.TableDataSetting == null || !Form23.list_0.Contains(table.TableDataSetting.method_64())) && method_24(treeNode_2, treeNode_3, treeNode_4))
				{
					return true;
				}
			}
			else
			{
				HashSet<DataIdAndAttrId> hashSet = MenuNode.smethod_1(menuNode_1);
				bool flag = false;
				foreach (DataIdAndAttrId item in hashSet)
				{
					if (Form23.list_0.Contains(item.DataId))
					{
						flag = true;
						break;
					}
				}
				if (!flag && method_24(treeNode_2, treeNode_3, treeNode_4))
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool method_24(TreeNode treeNode_2, TreeNode treeNode_3, TreeNode treeNode_4)
	{
		if (treeNode_3 != null)
		{
			treeNode_3.Tag = null;
			method_32(treeNode_3, treeNode_4);
			return false;
		}
		treeNode_2.Tag = null;
		return true;
	}

	private bool method_25(MenuNode menuNode_1, TreeNode treeNode_2, TreeNode treeNode_3, TreeNode treeNode_4, SettingOrSpecialObject settingOrSpecialObject_1, SettingOrSpecialObject settingOrSpecialObject_2, Class235 class235_0, bool bool_7, List<string> list_1)
	{
		bool flag = method_26(menuNode_1, out var bool_8);
		if (((bool_3 && Form23.class286_0 == null) | bool_7) & flag)
		{
			if ((list_1.Count != 0 || Form23.class286_0 != null) && !bool_7 && !bool_8)
			{
				treeNode_2.ForeColor = Color.Gray;
			}
			else if (method_24(treeNode_2, treeNode_3, treeNode_4))
			{
				return true;
			}
		}
		else if (flag)
		{
			if (!bool_8)
			{
				treeNode_2.ForeColor = Color.Gray;
			}
			else if (method_24(treeNode_2, treeNode_3, treeNode_4))
			{
				return true;
			}
		}
		else if (settingOrSpecialObject_1 != null)
		{
			bool flag2 = settingOrSpecialObject_1.method_35();
			if (settingOrSpecialObject_1 is Table && Form23.framework_0 != null && Form23.enum60_0 == Form23.Enum60.BpG)
			{
				Setting setting = Form23.framework_0.method_31((settingOrSpecialObject_1 as Table).method_64());
				if (setting is Table)
				{
					flag2 = setting.method_35();
				}
			}
			if (!flag2)
			{
				if ((bool_3 && Form23.class286_0 == null) | bool_7)
				{
					if ((list_1.Count != 0 || Form23.class286_0 != null) && !bool_7)
					{
						treeNode_2.ForeColor = Color.Gray;
					}
					else if (method_24(treeNode_2, treeNode_3, treeNode_4))
					{
						return true;
					}
				}
				else
				{
					treeNode_2.ForeColor = Color.Gray;
				}
			}
			if (bool_7)
			{
				bool flag3 = treeNode_4 != null && treeNode_4.Tag is MenuNode && (MenuNode)treeNode_4.Tag == Form23.menuNode_1;
				if (!method_30(menuNode_1, !flag3) && method_24(treeNode_2, treeNode_3, treeNode_4))
				{
					return true;
				}
			}
			if (settingOrSpecialObject_1.method_24().Count != 0 || settingOrSpecialObject_1.method_26().method_4().Count != 0)
			{
				treeNode_2.Tag = null;
				return true;
			}
			if (method_28(menuNode_1, settingOrSpecialObject_1, bool_7, list_1, treeNode_2, treeNode_3, treeNode_4))
			{
				return true;
			}
		}
		else
		{
			settingOrSpecialObject_1 = settingOrSpecialObject_2;
			if (settingOrSpecialObject_2 != null)
			{
				if (method_27(menuNode_1, settingOrSpecialObject_2, bool_7, list_1, treeNode_2, treeNode_3, treeNode_4))
				{
					return true;
				}
			}
			else if (class235_0 != null)
			{
				Setting setting2 = null;
				if (Form23.framework_1.awf.ContainsKey((byte)class235_0.method_0()))
				{
					setting2 = Form23.framework_1.awf[(byte)class235_0.method_0()];
				}
				if ((class235_0.method_7() || (setting2 != null && setting2.method_219() && setting2.method_256() == 0) || (setting2 == null && !class235_0.method_9() && !Form23.framework_1.method_27(class235_0.method_0()))) && method_24(treeNode_2, treeNode_3, treeNode_4))
				{
					return true;
				}
			}
			else
			{
				if (method_29(menuNode_1, treeNode_2, treeNode_3, treeNode_4))
				{
					return true;
				}
				if (bool_7)
				{
					bool flag4 = treeNode_4 != null && treeNode_4.Tag is MenuNode && (MenuNode)treeNode_4.Tag == Form23.menuNode_1;
					if (!method_30(menuNode_1, !flag4) && method_24(treeNode_2, treeNode_3, treeNode_4))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private bool method_26(MenuNode menuNode_1, out bool bool_7)
	{
		bool_7 = false;
		bool result;
		if (Form23.framework_0 != null && Form23.enum60_0 == Form23.Enum60.BpG)
		{
			if (menuNode_1.method_22() != 0)
			{
				Setting setting = Form23.framework_0.method_31(menuNode_1.method_22());
				result = ((menuNode_1.method_22() != 10195) ? (setting != null && setting.method_256() != 1) : (setting != null && setting.method_256() == 0));
				if (setting != null && setting.method_219())
				{
					bool_7 = true;
				}
			}
			else
			{
				result = false;
			}
		}
		else
		{
			result = menuNode_1.method_98(out var setting_);
			if (setting_ != null && setting_.method_219())
			{
				bool_7 = true;
			}
		}
		return result;
	}

	private bool method_27(MenuNode menuNode_1, SettingOrSpecialObject settingOrSpecialObject_1, bool bool_7, List<string> list_1, TreeNode treeNode_2, TreeNode treeNode_3, TreeNode treeNode_4)
	{
		if (bool_7)
		{
			bool flag = treeNode_4 != null && treeNode_4.Tag is MenuNode && (MenuNode)treeNode_4.Tag == Form23.menuNode_1;
			if (!method_30(menuNode_1, !flag) && method_24(treeNode_2, treeNode_3, treeNode_4))
			{
				return true;
			}
		}
		Setting setting = null;
		foreach (SettingOrSpecialObject item in settingOrSpecialObject_1.method_1())
		{
			if (item is Setting && (item.method_2().EndsWith(Class333.smethod_532()) || item.method_2().EndsWith(Class333.smethod_533()) || item.method_2().EndsWith(Class333.smethod_534())))
			{
				setting = item as Setting;
				break;
			}
		}
		if (setting != null && Form23.framework_0 != null && Form23.enum60_0 == Form23.Enum60.BpG)
		{
			setting = Form23.framework_0.method_31(setting.method_64());
		}
		bool flag2 = false;
		if (setting != null)
		{
			flag2 = ((setting.method_64() != 10195) ? (setting.method_256() != 1) : (setting.method_256() == 0));
		}
		bool flag3 = setting?.method_219() ?? false;
		if (!flag2 && settingOrSpecialObject_1.method_12().method_8().Count == 0)
		{
			HashSet<DataIdAndAttrId> hashSet = menuNode_1.method_104(bool_0: false);
			bool flag4 = true;
			foreach (DataIdAndAttrId item2 in hashSet)
			{
				Setting setting2 = ((Form23.framework_0 == null || Form23.enum60_0 != Form23.Enum60.BpG) ? Form23.framework_1.method_32(item2) : Form23.framework_0.method_32(item2));
				if (setting2 == null || setting2 == setting || setting2.method_0().aWZ.Contains(item2.DataId) || (!setting2.method_35() && (!(setting2 is Class244) || setting2.method_122())) || (!(setting2 is Class244) && setting2.method_219()) || setting2.method_220() || setting2.method_212())
				{
					continue;
				}
				PortFunction.Class273 @class = null;
				if (setting2.method_242()[0] == 1 && setting2.method_242()[1] == 1 && setting2.method_242()[2] == 1 && PortFunction.smethod_27(setting2.method_6()))
				{
					@class = setting2.method_6().method_12().method_12();
				}
				if (@class != null)
				{
					List<Class244> list = PortFunction.smethod_44(setting2.method_0(), @class.BSQ, @class.BSq, @class.BSR, @class.BSr, bool_0: false);
					if (list == null)
					{
						continue;
					}
					for (int i = 0; i < list.Count; i++)
					{
						if (hashSet.Contains(list[i].method_69()))
						{
							flag4 = false;
							break;
						}
					}
					if (!flag4)
					{
						break;
					}
					continue;
				}
				flag4 = false;
				break;
			}
			flag2 = flag4;
		}
		if (flag2)
		{
			if ((bool_3 && Form23.class286_0 == null) | bool_7)
			{
				if ((list_1.Count != 0 || Form23.class286_0 != null) && !flag3)
				{
					treeNode_2.ForeColor = Color.Gray;
				}
				else if (method_24(treeNode_2, treeNode_3, treeNode_4))
				{
					return true;
				}
			}
			else if (!flag3)
			{
				treeNode_2.ForeColor = Color.Gray;
			}
			else if (method_24(treeNode_2, treeNode_3, treeNode_4))
			{
				return true;
			}
		}
		return false;
	}

	private bool method_28(MenuNode menuNode_1, SettingOrSpecialObject settingOrSpecialObject_1, bool bool_7, List<string> list_1, TreeNode treeNode_2, TreeNode treeNode_3, TreeNode treeNode_4)
	{
		if (settingOrSpecialObject_1 is SpecialObject && (settingOrSpecialObject_1 as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count != 0)
		{
			bool flag = true;
			foreach (DataIdAndAttrId item in menuNode_1.method_104(bool_0: false))
			{
				Setting setting = ((Form23.framework_0 == null || Form23.enum60_0 != Form23.Enum60.BpG) ? Form23.framework_1.method_32(item) : Form23.framework_0.method_32(item));
				if (setting != null && !setting.method_0().aWZ.Contains(item.DataId) && setting.method_35() && !setting.method_219() && !setting.method_220() && !setting.method_212())
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				if ((bool_3 && Form23.class286_0 == null) | bool_7)
				{
					if (list_1.Count == 0 && Form23.class286_0 == null)
					{
						if (method_24(treeNode_2, treeNode_3, treeNode_4))
						{
							return true;
						}
					}
					else
					{
						treeNode_2.ForeColor = Color.Gray;
					}
				}
				else
				{
					treeNode_2.ForeColor = Color.Gray;
				}
			}
		}
		return false;
	}

	private bool method_29(MenuNode menuNode_1, TreeNode treeNode_2, TreeNode treeNode_3, TreeNode treeNode_4)
	{
		if (Form23.framework_1.awZ == 21)
		{
			if (menuNode_1.method_37())
			{
				if (menuNode_1.method_39() >= Form23.framework_1.awP.method_72().method_256() && method_24(treeNode_2, treeNode_3, treeNode_4))
				{
					return true;
				}
			}
			else if (menuNode_1.method_38())
			{
				int num = menuNode_1.method_41();
				int num2 = menuNode_1.method_5().method_5().method_39();
				try
				{
					if (Form23.framework_1.awP.method_79()[num2].method_72()[num].method_297().method_256() == 0 && method_24(treeNode_2, treeNode_3, treeNode_4))
					{
						return true;
					}
				}
				catch
				{
					Class23.smethod_3(string.Format(Class333.smethod_531(), num, num2, menuNode_1.method_10()));
				}
			}
			else if (menuNode_1.method_45())
			{
				int index = menuNode_1.method_46();
				Class248 @class = Form23.framework_1.awp.method_73()[index];
				if (@class.method_72() != null && @class.method_72().method_256() == 0 && method_24(treeNode_2, treeNode_3, treeNode_4))
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool method_30(MenuNode menuNode_1, bool bool_7)
	{
		MenuNode menuNode = menuNode_1;
		bool flag = false;
		do
		{
			SettingOrSpecialObject settingOrSpecialObject = Form23.framework_1.method_33(menuNode.method_3());
			int num = -1;
			if (!(settingOrSpecialObject is Table))
			{
				if (menuNode.method_60() != -1)
				{
					num = menuNode.method_60();
				}
			}
			else
			{
				num = (settingOrSpecialObject as Table).method_64();
			}
			if (num == -1 || !list_0.Contains(num))
			{
				if (bool_7)
				{
					if (menuNode.method_5() != null)
					{
						menuNode = menuNode.method_5();
					}
					else
					{
						flag = true;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		while (!flag);
		return false;
	}

	private bool method_31(MenuNode menuNode_1, int int_9, List<string> list_1)
	{
		bool flag = false;
		if (menuNode_1 != Form23.menuNode_1 && int_9 == 0)
		{
			foreach (MenuNode item2 in menuNode_1.method_6())
			{
				if (!item2.method_28())
				{
					continue;
				}
				if (list_1.Count == 0)
				{
					SpecialObject specialObject = Form23.framework_1.method_33(item2.method_3()) as SpecialObject;
					if (specialObject != null && specialObject.method_67().DataIdsOfListSettings.Count != 0)
					{
						int num;
						if (specialObject.method_67().FixedCountValue != 0)
						{
							num = specialObject.method_67().FixedCountValue;
						}
						else
						{
							Setting setting = Form23.framework_1.method_31(specialObject.method_67().DataIdOfListCountSetting);
							int num2 = setting.method_256();
							num = setting.method_229();
							if (num2 > num && num != 0)
							{
								num2 = num;
							}
							if (num == 0)
							{
								num = num2;
							}
						}
						for (int i = 0; i < specialObject.method_67().DataIdsOfListSettings.Count; i++)
						{
							int item = specialObject.method_67().DataIdsOfListSettings[i];
							Setting setting2 = Form23.framework_1.method_31(item);
							if (Form23.class286_0 == null || Form23.list_0.Contains(item))
							{
								for (int j = 0; j < num; j++)
								{
									if (setting2.method_131()[0, 0, j] || !bool_3 || Form23.class286_0 != null)
									{
										flag = true;
										break;
									}
								}
							}
							if (flag)
							{
								break;
							}
						}
					}
					else
					{
						foreach (DataIdAndAttrId item3 in item2.method_104(bool_0: false))
						{
							Setting setting3 = Form23.framework_1.method_32(item3);
							if (setting3 != null && (setting3.method_35() || !bool_3 || Form23.class286_0 != null) && (setting3 is Class244 || !setting3.method_219()) && !setting3.method_220() && !setting3.method_212() && (Form23.class286_0 == null || Form23.list_0.Contains(setting3.method_64())))
							{
								flag = true;
								break;
							}
						}
						if (!flag && specialObject != null && specialObject.method_66().CurrentUIListSettingsIdsAndIndents.Count == 0)
						{
							if (specialObject.method_55() != null)
							{
								string key = specialObject.method_55();
								if (Form23.framework_1.aWW.ErrorDefs.ContainsKey(key))
								{
									flag = true;
								}
							}
							else
							{
								foreach (string item4 in specialObject.method_52())
								{
									if (Form23.framework_1.aWv.ContainsKey(item4))
									{
										flag = true;
										break;
									}
								}
							}
						}
					}
					if (flag)
					{
						break;
					}
					SettingOrSpecialObject settingOrSpecialObject = Form23.framework_1.method_33(item2.method_3());
					if (settingOrSpecialObject != null && settingOrSpecialObject is SpecialObject && (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count != 0)
					{
						bool flag2 = true;
						foreach (UIListSettingDataIdAndIndent currentUIListSettingsIdsAndIndent in (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents)
						{
							if (!Form23.framework_1.aWZ.Contains(currentUIListSettingsIdsAndIndent.DataId) || (Form23.class286_0 != null && !Form23.list_0.Contains(currentUIListSettingsIdsAndIndent.DataId)))
							{
								flag2 = false;
								break;
							}
						}
						if (flag2)
						{
							flag = true;
							break;
						}
					}
					else if (settingOrSpecialObject is StateMachine && Form23.class286_0 == null && (settingOrSpecialObject as StateMachine).method_35())
					{
						flag = true;
						break;
					}
				}
				else if (method_45(item2, list_1))
				{
					flag = true;
					break;
				}
			}
		}
		else
		{
			flag = true;
		}
		return flag;
	}

	private void method_32(TreeNode treeNode_2, TreeNode treeNode_3)
	{
		if (treeNode_3 != null)
		{
			treeNode_3.Nodes.Remove(treeNode_2);
		}
		else
		{
			treeViewWithThemedScrollBars_0.method_2().Remove(treeNode_2);
		}
	}

	private int method_33(TreeNode treeNode_2, int int_9, Class235 class235_0, byte byte_0)
	{
		List<TreeNode> list = new List<TreeNode>();
		if (treeNode_2 != null)
		{
			for (int i = 0; i < treeNode_2.Nodes.Count; i++)
			{
				TreeNode item = treeNode_2.Nodes[i];
				list.Add(item);
			}
		}
		else
		{
			list = treeViewWithThemedScrollBars_0.method_2();
		}
		if (list.Count != 0)
		{
			if (class235_0 == null)
			{
				if (list[0].Tag is MenuNode)
				{
					if (int_9 < ((MenuNode)list[0].Tag).method_12())
					{
						return 0;
					}
					for (int j = 0; j < list.Count - 1; j++)
					{
						if (list[j].Tag is MenuNode && list[j + 1].Tag is MenuNode && int_9 > ((MenuNode)list[j].Tag).method_12() && int_9 < ((MenuNode)list[j + 1].Tag).method_12())
						{
							return j + 1;
						}
					}
				}
			}
			else
			{
				for (int k = 0; k < list.Count; k++)
				{
					if (list[k].Tag is MenuNode && ((MenuNode)list[k].Tag).method_2() != null && (int)byte_0 < (int)((MenuNode)list[k].Tag).method_2().method_0())
					{
						return k;
					}
				}
				for (int l = 0; l < list.Count - 1; l++)
				{
					if (list[l].Tag is MenuNode && list[l + 1].Tag is MenuNode && ((MenuNode)list[l].Tag).method_2() != null && ((MenuNode)list[l + 1].Tag).method_2() != null && (int)byte_0 > (int)((MenuNode)list[l].Tag).method_2().method_0() && (int)byte_0 < (int)((MenuNode)list[l + 1].Tag).method_2().method_0())
					{
						return l + 1;
					}
				}
			}
		}
		return -1;
	}

	private void method_34(bool bool_7, TreeNode treeNode_2, TreeNode treeNode_3, int int_9, Class235 class235_0, byte byte_0, bool bool_8)
	{
		if (treeNode_2.Tag == null)
		{
			return;
		}
		if (bool_7)
		{
			if (treeNode_3 != null)
			{
				treeNode_3.Nodes.Add(treeNode_2);
			}
			else
			{
				treeViewWithThemedScrollBars_0.method_2().Add(treeNode_2);
			}
			return;
		}
		if (bool_8 && treeNode_3 != null)
		{
			treeNode_3.Nodes.Add(treeNode_2);
			return;
		}
		int num = method_33(treeNode_3, int_9, class235_0, byte_0);
		if (treeNode_3 != null)
		{
			if (num != -1)
			{
				treeNode_3.Nodes.Insert(num, treeNode_2);
			}
			else
			{
				treeNode_3.Nodes.Add(treeNode_2);
			}
		}
		else if (num != -1)
		{
			treeViewWithThemedScrollBars_0.method_2().Insert(num, treeNode_2);
		}
		else
		{
			treeViewWithThemedScrollBars_0.method_2().Add(treeNode_2);
		}
	}

	internal TreeNode method_35(int int_9)
	{
		try
		{
			return method_37(treeViewWithThemedScrollBars_0.method_2(), int_9, bool_7: true);
		}
		catch
		{
			return null;
		}
	}

	private TreeNode method_36(TreeNodeCollection treeNodeCollection_0, int int_9, bool bool_7)
	{
		int num = 0;
		if (bool_7)
		{
			num = 2;
		}
		int num2 = num;
		TreeNode treeNode;
		while (true)
		{
			if (num2 < treeNodeCollection_0.Count)
			{
				if (treeNodeCollection_0[num2].Tag is MenuNode)
				{
					MenuNode menuNode = (MenuNode)treeNodeCollection_0[num2].Tag;
					if (menuNode.method_12() == int_9 && menuNode.method_2() == null)
					{
						return treeNodeCollection_0[num2];
					}
				}
				treeNode = method_36(treeNodeCollection_0[num2].Nodes, int_9, bool_7: false);
				if (treeNode != null)
				{
					break;
				}
				num2++;
				continue;
			}
			return null;
		}
		return treeNode;
	}

	private TreeNode method_37(List<TreeNode> list_1, int int_9, bool bool_7)
	{
		int num = 0;
		if (bool_7)
		{
			num = 2;
		}
		int num2 = num;
		TreeNode treeNode;
		while (true)
		{
			if (num2 < list_1.Count)
			{
				if (list_1[num2].Tag is MenuNode)
				{
					MenuNode menuNode = (MenuNode)list_1[num2].Tag;
					if (menuNode.method_12() == int_9 && menuNode.method_2() == null)
					{
						return list_1[num2];
					}
				}
				treeNode = method_36(list_1[num2].Nodes, int_9, bool_7: false);
				if (treeNode != null)
				{
					break;
				}
				num2++;
				continue;
			}
			return null;
		}
		return treeNode;
	}

	internal void method_38(int int_9)
	{
		if (Form23.framework_1.awB.ContainsKey(int_9))
		{
			MenuNode menuNode_ = Form23.framework_1.awB[int_9];
			TreeNode treeNode = method_53(method_0().method_2(), menuNode_);
			if (treeNode != null)
			{
				treeViewWithThemedScrollBars_0.method_4(treeNode);
			}
		}
	}

	internal void method_39(bool bool_7)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate25 method = method_39;
				Invoke(method, bool_7);
				return;
			}
			catch
			{
				return;
			}
		}
		treeViewWithThemedScrollBars_0.method_5();
		if (!Form23.framework_1.aXA.method_7())
		{
			foreach (TreeNode item in method_0().method_2())
			{
				if (item.Tag is MenuNode && item.Tag as MenuNode == Form23.framework_1.awj[0])
				{
					item.ForeColor = Color.Orange;
					break;
				}
			}
		}
		HashSet<DataIdAndAttrId> hashSet = new HashSet<DataIdAndAttrId>();
		hashSet.UnionWith(Form23.hashSet_1);
		hashSet.UnionWith(Form23.hashSet_2);
		foreach (DataIdAndAttrId item2 in hashSet)
		{
			bool flag2;
			bool flag = !(flag2 = Form23.hashSet_1.Contains(item2)) && Form23.hashSet_2.Contains(item2);
			bool flag3 = false;
			bool flag4 = false;
			do
			{
				TreeNode treeNode = method_65(treeViewWithThemedScrollBars_0.method_2(), item2, bool_7: true, bool_8: false, !flag3);
				if (treeNode != null)
				{
					Setting setting = Form23.framework_1.method_32(item2);
					if (setting != null && setting.method_125())
					{
						TreeNode treeNode2 = treeNode;
						bool flag5 = false;
						do
						{
							if (bool_7 && ((flag2 && treeNode2.ForeColor != Form23.color_7) || (flag && treeNode2.ForeColor != Color.Orange)) && treeNode2.Parent != null)
							{
								treeNode2.Parent.Expand();
							}
							if (flag2)
							{
								treeNode2.ForeColor = Form23.color_7;
							}
							else if (flag && treeNode2.ForeColor != Form23.color_7)
							{
								treeNode2.ForeColor = Color.Orange;
							}
							if (treeNode2.Parent != null)
							{
								treeNode2 = treeNode2.Parent;
							}
							else
							{
								flag5 = true;
							}
						}
						while (!flag5);
					}
				}
				if (!flag3)
				{
					flag3 = true;
				}
				else
				{
					flag4 = true;
				}
			}
			while (!flag3 || !flag4);
		}
		treeViewWithThemedScrollBars_0.method_6();
		treeViewWithThemedScrollBars_0.Invalidate();
	}

	internal void method_40(bool bool_7)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate26 method = method_40;
				Invoke(method, bool_7);
				return;
			}
			catch
			{
				return;
			}
		}
		treeViewWithThemedScrollBars_0.method_5();
		foreach (DataIdAndAttrId item in Form23.hashSet_0)
		{
			bool flag = false;
			bool flag2 = false;
			do
			{
				TreeNode treeNode = method_65(treeViewWithThemedScrollBars_0.method_2(), item, bool_7: true, bool_8: true, !flag);
				if (treeNode != null)
				{
					TreeNode treeNode2 = treeNode;
					bool flag3 = false;
					do
					{
						if (bool_7 && treeNode2.ForeColor != Form23.color_7 && treeNode2.ForeColor != Color.Orange && treeNode2.ForeColor != Form23.color_9 && treeNode2.Parent != null)
						{
							treeNode2.Parent.Expand();
						}
						if (treeNode2.ForeColor != Form23.color_7 && treeNode2.ForeColor != Color.Orange)
						{
							treeNode2.ForeColor = Form23.color_9;
						}
						if (treeNode2.Parent != null)
						{
							treeNode2 = treeNode2.Parent;
						}
						else
						{
							flag3 = true;
						}
					}
					while (!flag3);
				}
				if (!flag)
				{
					flag = true;
				}
				else
				{
					flag2 = true;
				}
			}
			while (!flag || !flag2);
		}
		treeViewWithThemedScrollBars_0.method_6();
		treeViewWithThemedScrollBars_0.Invalidate();
	}

	internal void method_41(TreeNode treeNode_2)
	{
		if (treeNode_2 == null)
		{
			return;
		}
		List<int> list = new List<int>();
		TreeNode treeNode = treeNode_2;
		bool flag = false;
		do
		{
			if (treeNode.Parent == null)
			{
				flag = true;
				continue;
			}
			if (treeNode.Parent.Tag is MenuNode menuNode)
			{
				list.Add(menuNode.method_12());
			}
			treeNode = treeNode.Parent;
		}
		while (!flag);
		smethod_0(treeViewWithThemedScrollBars_0.method_2(), list);
		foreach (TreeNode item in treeViewWithThemedScrollBars_0.method_2())
		{
			if (item.Tag is MenuNode menuNode2 && menuNode2.method_1() != null)
			{
				item.ExpandAll();
			}
		}
		smethod_2(treeViewWithThemedScrollBars_0.method_2(), list);
	}

	private static void smethod_0(List<TreeNode> list_1, List<int> list_2)
	{
		foreach (TreeNode item in list_1)
		{
			MenuNode menuNode = item.Tag as MenuNode;
			if (item.IsExpanded && menuNode != null)
			{
				list_2.Add(menuNode.method_12());
			}
			smethod_1(item.Nodes, list_2);
		}
	}

	private static void smethod_1(TreeNodeCollection treeNodeCollection_0, List<int> list_1)
	{
		foreach (TreeNode item in treeNodeCollection_0)
		{
			MenuNode menuNode = item.Tag as MenuNode;
			if (item.IsExpanded && menuNode != null)
			{
				list_1.Add(menuNode.method_12());
			}
			smethod_1(item.Nodes, list_1);
		}
	}

	private static void smethod_2(List<TreeNode> list_1, List<int> list_2)
	{
		foreach (TreeNode item in list_1)
		{
			if (item.Tag is MenuNode menuNode && !list_2.Contains(menuNode.method_12()))
			{
				item.Collapse();
			}
			smethod_3(item.Nodes, list_2);
		}
	}

	private static void smethod_3(TreeNodeCollection treeNodeCollection_0, List<int> list_1)
	{
		foreach (TreeNode item in treeNodeCollection_0)
		{
			if (item.Tag is MenuNode menuNode && !list_1.Contains(menuNode.method_12()))
			{
				item.Collapse();
			}
			smethod_3(item.Nodes, list_1);
		}
	}

	internal void method_42(Class286 class286_0, List<TreeNode> list_1)
	{
		foreach (TreeNode item in list_1)
		{
			method_44(item, class286_0);
			method_43(class286_0, item.Nodes);
		}
	}

	internal void method_43(Class286 class286_0, TreeNodeCollection treeNodeCollection_0)
	{
		foreach (TreeNode item in treeNodeCollection_0)
		{
			method_44(item, class286_0);
			method_43(class286_0, item.Nodes);
		}
	}

	private void method_44(TreeNode treeNode_2, Class286 class286_0)
	{
		if (!(treeNode_2.Tag is MenuNode menuNode) || menuNode.method_1() == null)
		{
			return;
		}
		SettingOrSpecialObject settingOrSpecialObject = menuNode.method_1().method_33(menuNode.method_3());
		if (settingOrSpecialObject is Table)
		{
			Table table = settingOrSpecialObject as Table;
			if (class286_0.method_3(table.TableDataSetting) != null)
			{
				method_41(treeNode_2);
			}
		}
	}

	private bool method_45(MenuNode menuNode_1, List<string> list_1)
	{
		bool flag = true;
		SettingOrSpecialObject settingOrSpecialObject = Form23.framework_1.method_33(menuNode_1.method_20());
		foreach (string item in list_1)
		{
			bool flag2;
			if (!(flag2 = menuNode_1.method_10().ToLower().Contains(item)))
			{
				foreach (string item2 in menuNode_1.method_70())
				{
					if (item2.ToLower().Contains(item))
					{
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2 && settingOrSpecialObject != null)
			{
				foreach (string item3 in settingOrSpecialObject.method_23())
				{
					if (item3.ToLower().Contains(item))
					{
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				foreach (DataIdAndAttrId item4 in menuNode_1.method_104(bool_0: false))
				{
					Setting setting = Form23.framework_1.method_32(item4);
					if (setting == null || (setting.method_154() && setting.method_219() && setting.method_256() == 0))
					{
						continue;
					}
					string text = setting.method_60(Enum96.aYt);
					if (text == null)
					{
						text = setting.method_2();
					}
					if (!text.ToLower().Contains(item))
					{
						string text2 = setting.method_60(Enum96.aYT);
						if (text2 == null)
						{
							text2 = setting.method_2();
						}
						if (!text2.ToLower().Contains(item))
						{
							string text3 = setting.method_60(Enum96.aYu);
							if (text3 == null || !text3.ToLower().Contains(item))
							{
								string text4 = setting.method_60(Enum96.aYV);
								if (text4 == null || !text4.ToLower().Contains(item))
								{
									string text5 = setting.method_60(Enum96.aYv);
									if (text5 == null || !text5.ToLower().Contains(item))
									{
										string text6 = setting.method_18();
										if (string.IsNullOrWhiteSpace(text6) || !text6.ToLower().Contains(item))
										{
											foreach (string item5 in setting.method_23())
											{
												if (item5.ToLower().Contains(item))
												{
													flag2 = true;
													break;
												}
											}
											if (flag2)
											{
												break;
											}
											continue;
										}
										flag2 = true;
										break;
									}
									flag2 = true;
									break;
								}
								flag2 = true;
								break;
							}
							flag2 = true;
							break;
						}
						flag2 = true;
						break;
					}
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				SettingOrSpecialObject settingOrSpecialObject_ = Form23.framework_1.method_33(menuNode_1.method_3());
				Class235 class235_ = menuNode_1.method_2();
				string text7 = menuNode_1.method_10();
				if (text7.ToLower().Contains(item))
				{
					flag2 = true;
				}
				else
				{
					string text8 = method_20(text7, menuNode_1, settingOrSpecialObject_, settingOrSpecialObject, class235_);
					if (!string.IsNullOrEmpty(text8) && text8.ToLower().Contains(item))
					{
						flag2 = true;
					}
				}
			}
			if (!flag2)
			{
				flag = false;
				break;
			}
		}
		if (!flag && settingOrSpecialObject != null && menuNode_1.method_5() != null && menuNode_1.method_5().method_22() != 0)
		{
			Setting setting2 = Form23.framework_1.method_31(menuNode_1.method_5().method_22());
			if (setting2 != null && setting2.method_6() != null && !string.IsNullOrWhiteSpace(setting2.method_6().method_18()) && method_45(menuNode_1.method_5(), list_1))
			{
				flag = true;
			}
		}
		return flag;
	}

	internal void method_46(TreeNode treeNode_2, bool bool_7, bool bool_8 = false)
	{
		if (treeNode_2 != null && treeNode_2.Tag is MenuNode)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			MenuNode menuNode = (MenuNode)treeNode_2.Tag;
			int num = -1;
			int num2 = -1;
			Class235 @class = menuNode.method_2();
			if (@class == null)
			{
				num = menuNode.method_3();
				num2 = menuNode.method_20();
			}
			settingOrSpecialObject_0 = Form23.framework_1.method_33(num);
			SettingOrSpecialObject settingOrSpecialObject = Form23.framework_1.method_33(num2);
			if (menuNode == Form23.menuNode_0)
			{
				Form23.form23_0.control25_0.method_28(null, Enum38.const_0, null, Form23.menuNode_0, bool_7);
			}
			else if (menuNode != Form23.menuNode_1)
			{
				if (Form23.framework_1.awr != null && Form23.framework_1.awr == Form23.framework_1.awR && menuNode == Form23.framework_1.awR)
				{
					Form23.form23_0.control25_0.method_28(null, Enum38.const_15, null, menuNode, bool_7);
				}
				else if (@class != null)
				{
					Form23.form23_0.control25_0.method_28(null, Enum38.const_1, @class, menuNode, bool_7);
				}
				else if (treeNode_2.Parent == null)
				{
					Form23.form23_0.control25_0.method_28(null, Enum38.const_2, null, menuNode, bool_7);
				}
				else if (settingOrSpecialObject != null)
				{
					settingOrSpecialObject_0 = settingOrSpecialObject;
					Form23.form23_0.control25_0.method_28(settingOrSpecialObject_0, Enum38.const_6, null, menuNode, bool_7);
				}
				else if (settingOrSpecialObject_0 != null)
				{
					Interface4 @interface = settingOrSpecialObject_0.method_11();
					if (@interface != null)
					{
						@interface.ShowUIControlForSelectedNode(menuNode, bool_7);
					}
					else if (settingOrSpecialObject_0.method_1().Count != 0)
					{
						Form23.form23_0.control25_0.method_28(settingOrSpecialObject_0, Enum38.const_7, null, menuNode, bool_7);
					}
				}
				else
				{
					if (menuNode.method_37())
					{
						if (menuNode == menuNode_0 && !Form23.bool_35 && !bool_8)
						{
							bool_7 = false;
						}
						else
						{
							menuNode_0 = menuNode;
						}
					}
					if (menuNode.method_38())
					{
						MenuNode menuNode2 = menuNode.method_5().method_5();
						if (menuNode2 == menuNode_0)
						{
							bool_7 = (Form23.bool_35 || Form23.bool_44) | bool_8;
						}
						menuNode_0 = menuNode2;
						Form23.form23_0.control25_0.method_29(menuNode2, bool_7);
						int num3 = menuNode.method_41();
						Form23.form23_0.control25_0.method_30(num3);
					}
					else if (menuNode.method_29())
					{
						Form23.form23_0.control25_0.method_29(menuNode, bool_7);
					}
					else
					{
						foreach (MenuNode item in menuNode.method_6())
						{
							if (item.method_28())
							{
								Form23.form23_0.control25_0.method_29(menuNode, bool_7);
								break;
							}
						}
					}
				}
			}
			method_60(treeNode_2);
			if (settingOrSpecialObject_0 is Setting setting && setting.method_195() != null && setting.method_195().Length > 2)
			{
				Form23.string_36 = setting.method_195();
			}
			else if (menuNode.method_80() != null && menuNode.method_80().BcF != null && menuNode.method_84() && !string.IsNullOrEmpty(menuNode.method_80().BcF.Bca))
			{
				Form23.string_36 = menuNode.method_80().BcF.Bca;
			}
			else if (string.IsNullOrEmpty(menuNode.method_66()))
			{
				MenuNode menuNode3 = menuNode;
				while (true)
				{
					MenuNode menuNode4 = menuNode3.method_5();
					if (menuNode4 == null)
					{
						break;
					}
					string text = menuNode4.method_66();
					if (string.IsNullOrEmpty(text))
					{
						menuNode3 = menuNode4;
						continue;
					}
					Form23.string_36 = text;
					break;
				}
			}
			else
			{
				Form23.string_36 = menuNode.method_66();
			}
			if ((Form23.form18_0 != null && Form23.form18_0.Visible) || (Form23.form23_0.class131_3 != null && Form23.form23_0.class131_3.Visible))
			{
				Form23.form23_0.method_93();
			}
			Form23.smethod_53(null, null);
			Form23.bool_26 = true;
			if (!menuNode.method_37() && !menuNode.method_38())
			{
				menuNode_0 = null;
			}
			stopwatch.Stop();
			Class23.smethod_3(string.Format(Class333.smethod_535(), stopwatch.ElapsedMilliseconds), bool_1: false);
		}
		else
		{
			menuNode_0 = null;
			Form23.string_36 = null;
		}
	}

	internal string method_47(TreeNode treeNode_2, bool bool_7, bool bool_8)
	{
		if (treeNode_2 == null)
		{
			return string.Empty;
		}
		if (treeNode_2.Tag is MenuNode && ((treeNode_2.Tag as MenuNode).method_2() != null || treeNode_2.Tag as MenuNode == Form23.menuNode_0))
		{
			return treeNode_2.ToolTipText;
		}
		string text = string.Empty;
		List<TreeNode> list = new List<TreeNode>();
		list.Add(treeNode_2);
		TreeNode treeNode = treeNode_2;
		bool flag = false;
		do
		{
			if (treeNode.Parent == null)
			{
				flag = true;
				continue;
			}
			list.Insert(0, treeNode.Parent);
			treeNode = treeNode.Parent;
		}
		while (!flag);
		for (int i = 0; i < list.Count; i++)
		{
			if ((i != 0) | bool_7)
			{
				TreeNode treeNode2 = list[i];
				if (text != string.Empty)
				{
					text = ((!bool_8) ? (text + Class333.smethod_536()) : (text + Class333.smethod_176()));
				}
				text += treeNode2.ToolTipText;
			}
		}
		return text;
	}

	internal void method_48(int int_9)
	{
		TreeNode treeNode = method_63(treeViewWithThemedScrollBars_0.method_2(), new DataIdAndAttrId(int_9), bool_7: false);
		if (treeViewWithThemedScrollBars_0.method_3() != treeNode)
		{
			treeViewWithThemedScrollBars_0.method_4(treeNode);
		}
	}

	internal void method_49(int int_9)
	{
		TreeNode treeNode = method_51(treeViewWithThemedScrollBars_0.method_2(), int_9);
		if (treeNode != null && treeNode != treeViewWithThemedScrollBars_0.method_3())
		{
			treeViewWithThemedScrollBars_0.method_4(treeNode);
		}
		treeNode_1 = treeViewWithThemedScrollBars_0.method_3();
	}

	internal void method_50(int int_9)
	{
		bool num = treeViewWithThemedScrollBars_0.method_3() == treeNode_1 || treeNode_1 == null;
		method_49(int_9);
		if (num)
		{
			method_46(treeViewWithThemedScrollBars_0.method_3(), bool_7: true, bool_8: true);
		}
	}

	private TreeNode method_51(List<TreeNode> list_1, int int_9)
	{
		int num = 0;
		TreeNode treeNode2;
		while (true)
		{
			if (num < list_1.Count)
			{
				TreeNode treeNode = list_1[num];
				if (treeNode.Nodes.Count > 0)
				{
					treeNode2 = method_52(treeNode.Nodes, int_9);
					if (treeNode2 != null)
					{
						break;
					}
				}
				num++;
				continue;
			}
			return null;
		}
		return treeNode2;
	}

	private TreeNode method_52(TreeNodeCollection treeNodeCollection_0, int int_9)
	{
		int num = 0;
		TreeNode treeNode2;
		while (true)
		{
			if (num < treeNodeCollection_0.Count)
			{
				TreeNode treeNode = treeNodeCollection_0[num];
				if (!(treeNode.Tag is MenuNode) || !((MenuNode)treeNode.Tag).method_37() || ((MenuNode)treeNode.Tag).method_39() != int_9)
				{
					if (treeNode.Nodes.Count > 0)
					{
						treeNode2 = method_52(treeNode.Nodes, int_9);
						if (treeNode2 != null)
						{
							break;
						}
					}
					num++;
					continue;
				}
				return treeNode;
			}
			return null;
		}
		return treeNode2;
	}

	internal TreeNode method_53(List<TreeNode> list_1, MenuNode menuNode_1)
	{
		int num = 0;
		TreeNode treeNode2;
		while (true)
		{
			if (num < list_1.Count)
			{
				TreeNode treeNode = list_1[num];
				if (!(treeNode.Tag is MenuNode) || treeNode.Tag as MenuNode != menuNode_1)
				{
					if (treeNode.Nodes.Count > 0)
					{
						treeNode2 = method_54(treeNode.Nodes, menuNode_1);
						if (treeNode2 != null)
						{
							break;
						}
					}
					num++;
					continue;
				}
				return treeNode;
			}
			return null;
		}
		return treeNode2;
	}

	internal TreeNode method_54(TreeNodeCollection treeNodeCollection_0, MenuNode menuNode_1)
	{
		int num = 0;
		TreeNode treeNode2;
		while (true)
		{
			if (num < treeNodeCollection_0.Count)
			{
				TreeNode treeNode = treeNodeCollection_0[num];
				if (!(treeNode.Tag is MenuNode) || treeNode.Tag as MenuNode != menuNode_1)
				{
					if (treeNode.Nodes.Count > 0)
					{
						treeNode2 = method_54(treeNode.Nodes, menuNode_1);
						if (treeNode2 != null)
						{
							break;
						}
					}
					num++;
					continue;
				}
				return treeNode;
			}
			return null;
		}
		return treeNode2;
	}

	internal void method_55(int int_9, int int_10)
	{
		TreeNode treeNode = method_56(treeViewWithThemedScrollBars_0.method_2(), int_9, int_10);
		if (treeViewWithThemedScrollBars_0.method_3() != treeNode)
		{
			treeViewWithThemedScrollBars_0.method_4(treeNode);
		}
	}

	private TreeNode method_56(List<TreeNode> list_1, int int_9, int int_10)
	{
		int num = 0;
		TreeNode treeNode2;
		while (true)
		{
			if (num < list_1.Count)
			{
				TreeNode treeNode = list_1[num];
				if (treeNode.Nodes.Count > 0)
				{
					treeNode2 = method_57(treeNode.Nodes, int_9, int_10);
					if (treeNode2 != null)
					{
						break;
					}
				}
				num++;
				continue;
			}
			return null;
		}
		return treeNode2;
	}

	private TreeNode method_57(TreeNodeCollection treeNodeCollection_0, int int_9, int int_10)
	{
		int num = 0;
		TreeNode treeNode2;
		while (true)
		{
			if (num < treeNodeCollection_0.Count)
			{
				TreeNode treeNode = treeNodeCollection_0[num];
				if (treeNode.Parent != null && treeNode.Tag is MenuNode && treeNode.Parent.Tag is MenuNode)
				{
					MenuNode menuNode = (MenuNode)treeNode.Parent.Tag;
					MenuNode menuNode2 = (MenuNode)treeNode.Tag;
					if (menuNode.method_37() && menuNode.method_39() == int_9 && menuNode2.method_38() && menuNode2.method_41() == int_10)
					{
						return treeNode;
					}
				}
				if (treeNode.Nodes.Count > 0)
				{
					treeNode2 = method_57(treeNode.Nodes, int_9, int_10);
					if (treeNode2 != null)
					{
						break;
					}
				}
				num++;
				continue;
			}
			return null;
		}
		return treeNode2;
	}

	internal void method_58(string string_1)
	{
		string[] array = string_1.Split('\\');
		if (treeViewWithThemedScrollBars_0.method_2().Count == 0 || array.Length == 0)
		{
			return;
		}
		TreeNode treeNode = null;
		int num = 0;
		bool flag;
		do
		{
			flag = false;
			if (treeNode != null)
			{
				for (int i = 0; i < treeNode.Nodes.Count; i++)
				{
					if (treeNode.Nodes[i].ToolTipText == array[num])
					{
						treeNode = treeNode.Nodes[i];
						num++;
						flag = true;
						break;
					}
				}
				continue;
			}
			for (int j = 0; j < treeViewWithThemedScrollBars_0.method_2().Count; j++)
			{
				if (treeViewWithThemedScrollBars_0.method_2()[j].ToolTipText == array[num])
				{
					treeNode = treeViewWithThemedScrollBars_0.method_2()[j];
					num++;
					flag = true;
					break;
				}
			}
		}
		while (flag && num < array.Length);
		if (flag && num == array.Length)
		{
			treeViewWithThemedScrollBars_0.method_4(treeNode);
		}
		else
		{
			treeViewWithThemedScrollBars_0.method_4(null);
		}
	}

	internal void method_59(Setting setting_0)
	{
		Class286 @class = null;
		bool flag = false;
		MenuNode menuNode = MenuNode.smethod_2(setting_0.method_0().awj, setting_0.method_69());
		if (menuNode != null)
		{
			MenuNode menuNode2 = menuNode.method_83(setting_0);
			if (menuNode2 != null)
			{
				@class = menuNode2.method_80().BcF;
				flag = menuNode2.method_84();
			}
		}
		if (((@class != null && setting_0.method_78()) & flag) && !string.IsNullOrEmpty(setting_0.method_80()) && !string.IsNullOrEmpty(setting_0.method_82()))
		{
			class134_0.Text = setting_0.method_80() + Class333.smethod_537();
		}
		else
		{
			class134_0.Text = setting_0.method_22(bool_0: true) + Class333.smethod_537();
		}
		if (setting_0.method_102().Count == 0 && setting_0.method_106().Count == 0 && !setting_0.method_154())
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
				int num3 = setting_0.method_231();
				int num4 = setting_0.method_100();
				string arg = Class233.smethod_29(num, num3, num4);
				string arg2 = Class233.smethod_29(num2, num3, num4);
				int num5 = setting_0.method_221();
				if (num5 > 1)
				{
					string arg3 = Class233.smethod_29(num5, num3, num4);
					class134_0.AppendText(string.Format(Class333.smethod_538(), arg, arg2, arg3) + Class333.smethod_537());
				}
				else
				{
					class134_0.AppendText(string.Format(Class333.smethod_539(), arg, arg2) + Class333.smethod_537());
				}
			}
		}
		class134_0.Select(0, class134_0.TextLength);
		class134_0.SelectionFont = new Font(class134_0.SelectionFont.FontFamily, class134_0.SelectionFont.Size, FontStyle.Bold);
		class134_0.SelectionColor = Form23.color_12;
		class134_0.SelectionLength = 0;
		int textLength = class134_0.TextLength;
		if (((@class != null && setting_0.method_78()) & flag) && !string.IsNullOrEmpty(setting_0.method_80()) && !string.IsNullOrEmpty(setting_0.method_82()))
		{
			string text = setting_0.method_82();
			class134_0.AppendText(text);
		}
		else
		{
			string text2 = setting_0.method_60(Enum96.aYU);
			if (text2 != null)
			{
				class134_0.AppendText(text2);
			}
			else
			{
				string text3 = setting_0.method_60(Enum96.aYt);
				if (text3 != null)
				{
					class134_0.AppendText(text3);
				}
				else
				{
					string text4 = setting_0.method_60(Enum96.aYT);
					if (text4 != null)
					{
						class134_0.AppendText(text4);
					}
					else
					{
						class134_0.AppendText(setting_0.method_2());
					}
				}
			}
		}
		int length = class134_0.TextLength - textLength;
		class134_0.Select(textLength, length);
		class134_0.SelectionColor = Form23.color_12;
		class134_0.SelectionLength = 0;
		class134_0.method_0();
	}

	private void method_60(TreeNode treeNode_2)
	{
		class134_0.Text = method_47(treeNode_2, bool_7: false, bool_8: false) + Class333.smethod_537();
		if (settingOrSpecialObject_0 is Table)
		{
			Table table = settingOrSpecialObject_0 as Table;
			int num = table.method_228();
			int num2 = table.method_229();
			if (num != 0 || num2 != 0)
			{
				int num3 = table.TableDataSetting.method_231();
				string arg = Class233.smethod_29(num, num3);
				string arg2 = Class233.smethod_29(num2, num3);
				class134_0.AppendText(string.Format(Class333.smethod_539(), arg, arg2) + Class333.smethod_537());
			}
		}
		class134_0.Select(0, class134_0.TextLength);
		class134_0.SelectionFont = new Font(class134_0.SelectionFont.FontFamily, class134_0.SelectionFont.Size, FontStyle.Bold);
		class134_0.SelectionColor = Form23.color_12;
		class134_0.SelectionLength = 0;
		int textLength = class134_0.TextLength;
		if (settingOrSpecialObject_0 != null)
		{
			string text = settingOrSpecialObject_0.method_60(Enum96.aYU);
			if (text != null)
			{
				class134_0.AppendText(text);
			}
			else
			{
				string text2 = settingOrSpecialObject_0.method_60(Enum96.aYt);
				if (text2 != null)
				{
					class134_0.AppendText(text2);
				}
				else
				{
					string text3 = settingOrSpecialObject_0.method_60(Enum96.aYT);
					if (text3 != null)
					{
						class134_0.AppendText(text3);
					}
					else
					{
						class134_0.AppendText(settingOrSpecialObject_0.method_2());
					}
				}
			}
		}
		int length = class134_0.TextLength - textLength;
		class134_0.Select(textLength, length);
		class134_0.SelectionColor = Form23.color_12;
		class134_0.SelectionLength = 0;
		class134_0.method_0();
	}

	private void method_61()
	{
		class134_0.Text = Class333.smethod_540();
		class134_0.Select(0, class134_0.TextLength);
		class134_0.SelectionFont = new Font(class134_0.SelectionFont.FontFamily, class134_0.SelectionFont.Size, FontStyle.Bold);
		class134_0.SelectionColor = Form23.color_12;
		class134_0.SelectionLength = 0;
		int textLength = class134_0.TextLength;
		class134_0.AppendText(Class333.smethod_541());
		int length = class134_0.TextLength - textLength;
		class134_0.Select(textLength, length);
		class134_0.SelectionColor = Form23.color_12;
		class134_0.SelectionLength = 0;
		class134_0.method_0();
	}

	internal TreeNode method_62(TreeNodeCollection treeNodeCollection_0, DataIdAndAttrId dataIdAndAttrId_0, bool bool_7)
	{
		return method_64(treeNodeCollection_0, dataIdAndAttrId_0, bool_7: true, bool_7, bool_9: false);
	}

	internal TreeNode method_63(List<TreeNode> list_1, DataIdAndAttrId dataIdAndAttrId_0, bool bool_7)
	{
		return method_65(list_1, dataIdAndAttrId_0, bool_7: true, bool_7, bool_9: false);
	}

	internal TreeNode method_64(TreeNodeCollection treeNodeCollection_0, DataIdAndAttrId dataIdAndAttrId_0, bool bool_7, bool bool_8, bool bool_9)
	{
		if (bool_7 && Form23.framework_1.aWZ.Contains(dataIdAndAttrId_0.DataId))
		{
			Setting setting = Form23.framework_1.method_31(dataIdAndAttrId_0.DataId);
			if (setting != null && setting.method_152() != null)
			{
				TreeNode treeNode = method_54(treeNodeCollection_0, setting.method_152());
				if (treeNode != null)
				{
					return treeNode;
				}
			}
		}
		int num = 0;
		TreeNode treeNode3;
		while (true)
		{
			if (num < treeNodeCollection_0.Count)
			{
				TreeNode treeNode2 = treeNodeCollection_0[num];
				bool flag = treeNode2.Tag is MenuNode && (treeNode2.Tag as MenuNode == Form23.menuNode_1 || method_66(treeNode2));
				if (bool_9 == flag)
				{
					if (treeNode2.Tag is MenuNode && ((MenuNode)treeNode2.Tag).method_104(bool_8).Contains(dataIdAndAttrId_0))
					{
						return treeNode2;
					}
					treeNode3 = method_64(treeNode2.Nodes, dataIdAndAttrId_0, bool_7: false, bool_8, bool_9);
					if (treeNode3 != null)
					{
						break;
					}
				}
				num++;
				continue;
			}
			return null;
		}
		return treeNode3;
	}

	internal TreeNode method_65(List<TreeNode> list_1, DataIdAndAttrId dataIdAndAttrId_0, bool bool_7, bool bool_8, bool bool_9)
	{
		if (bool_7 && Form23.framework_1.aWZ.Contains(dataIdAndAttrId_0.DataId))
		{
			Setting setting = Form23.framework_1.method_31(dataIdAndAttrId_0.DataId);
			if (setting != null && setting.method_152() != null)
			{
				TreeNode treeNode = method_53(list_1, setting.method_152());
				if (treeNode != null)
				{
					return treeNode;
				}
			}
		}
		int num = 0;
		TreeNode treeNode3;
		while (true)
		{
			if (num < list_1.Count)
			{
				TreeNode treeNode2 = list_1[num];
				bool flag = treeNode2.Tag is MenuNode && (treeNode2.Tag as MenuNode == Form23.menuNode_1 || method_66(treeNode2));
				if (bool_9 == flag)
				{
					if (treeNode2.Tag is MenuNode && ((MenuNode)treeNode2.Tag).method_104(bool_8).Contains(dataIdAndAttrId_0))
					{
						return treeNode2;
					}
					treeNode3 = method_64(treeNode2.Nodes, dataIdAndAttrId_0, bool_7: false, bool_8, bool_9);
					if (treeNode3 != null)
					{
						break;
					}
				}
				num++;
				continue;
			}
			return null;
		}
		return treeNode3;
	}

	private bool method_66(TreeNode treeNode_2)
	{
		if (treeNode_2.Parent == null)
		{
			return false;
		}
		TreeNode treeNode = treeNode_2;
		bool flag = false;
		do
		{
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
		if (treeNode != null && treeNode.Tag is MenuNode)
		{
			return treeNode.Tag as MenuNode == Form23.menuNode_1;
		}
		return false;
	}

	[SpecialName]
	internal SettingOrSpecialObject method_67()
	{
		return settingOrSpecialObject_0;
	}

	internal void method_68(bool bool_7)
	{
		if (Form23.framework_1 != null)
		{
			if (!bool_5)
			{
				method_74();
			}
			method_72();
			Form23.form23_0.control25_0.method_28(null, Enum38.const_3, null, null, bool_7);
			method_61();
			Form23.smethod_53(null, null);
			Form23.bool_26 = true;
			Form23.bool_3 = true;
			if (!bool_5)
			{
				stack_1.Clear();
			}
			method_73();
			bool_6 = true;
			treeViewWithThemedScrollBars_0.method_4(null);
			bool_5 = false;
		}
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		method_68(bool_7: true);
	}

	private void method_69(object sender, TreeViewCancelEventArgs e)
	{
		if (!bool_5 && !bool_6)
		{
			method_74();
		}
		method_72();
	}

	private void method_70(object sender, TreeViewEventArgs e)
	{
		if (e.Node != null && e.Node.Tag is MenuNode && (e.Node.Tag as MenuNode).method_38() && e.Action == TreeViewAction.ByMouse)
		{
			method_71(sender, e);
		}
	}

	private void method_71(object sender, TreeViewEventArgs e)
	{
		bool_2 = true;
		method_46(e.Node, bool_7: true);
		bool_2 = false;
		if (!themedTextBox_0.Focused)
		{
			Form23.bool_3 = true;
		}
		if (!bool_5 && !bool_6)
		{
			stack_1.Clear();
		}
		bool_5 = false;
		bool_6 = false;
		method_73();
	}

	private void method_72()
	{
		TreeNode treeNode = null;
		if (stack_0.Count != 0)
		{
			treeNode = stack_0.Peek();
		}
		if (treeNode == null)
		{
			themedButton_3.Enabled = false;
		}
		else
		{
			themedButton_3.Enabled = true;
		}
		themedButton_2.Enabled = themedButton_3.Enabled;
	}

	private void method_73()
	{
		TreeNode treeNode = null;
		if (stack_1.Count != 0)
		{
			treeNode = stack_1.Peek();
		}
		if (treeNode == null)
		{
			themedButton_4.Enabled = false;
		}
		else
		{
			themedButton_4.Enabled = true;
		}
		themedButton_5.Enabled = themedButton_4.Enabled;
	}

	private void method_74()
	{
		if (Form23.form23_0.control25_0.method_33() != null)
		{
			TreeNode item = new Class171();
			stack_0.Push(item);
		}
		else if (treeViewWithThemedScrollBars_0.method_3() != null && treeViewWithThemedScrollBars_0.method_3().Tag is MenuNode menuNode && (menuNode.method_3() != -1 || menuNode.method_20() != -1 || (menuNode.method_6().Count != 0 && treeViewWithThemedScrollBars_0.method_3().Nodes.Count == 0) || menuNode.method_2() != null || menuNode == Form23.menuNode_0) && (stack_0.Count == 0 || stack_0.Peek() != treeViewWithThemedScrollBars_0.method_3()))
		{
			stack_0.Push(treeViewWithThemedScrollBars_0.method_3());
		}
	}

	private void method_75()
	{
		if (Form23.form23_0.control25_0.method_33() != null)
		{
			TreeNode item = new Class171();
			stack_1.Push(item);
		}
		else if (treeViewWithThemedScrollBars_0.method_3() != null && (stack_1.Count == 0 || stack_1.Peek() != treeViewWithThemedScrollBars_0.method_3()))
		{
			stack_1.Push(treeViewWithThemedScrollBars_0.method_3());
		}
	}

	private void themedButton_3_Click(object sender, EventArgs e)
	{
		bool_5 = true;
		method_75();
		TreeNode treeNode = stack_0.Pop();
		if (treeNode.Tag != null)
		{
			treeViewWithThemedScrollBars_0.method_4(treeNode);
		}
		else
		{
			method_68(bool_7: true);
		}
		method_72();
		method_73();
	}

	private void themedButton_4_Click(object sender, EventArgs e)
	{
		bool_5 = true;
		method_74();
		TreeNode treeNode = stack_1.Pop();
		if (treeNode.Tag != null)
		{
			treeViewWithThemedScrollBars_0.method_4(treeNode);
		}
		else
		{
			method_68(bool_7: true);
		}
		method_72();
		method_73();
	}

	private void themedButton_2_Click(object sender, EventArgs e)
	{
		contextMenuStrip_0.BackColor = Form23.color_15;
		contextMenuStrip_0.ForeColor = Form23.color_12;
		contextMenuStrip_0.Items.Clear();
		int num = 0;
		foreach (TreeNode item in stack_0)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
			if (item.Tag == null)
			{
				toolStripMenuItem.Text = Class333.smethod_542();
			}
			else
			{
				toolStripMenuItem.Text = method_47(item, bool_7: false, bool_8: false);
			}
			toolStripMenuItem.Tag = num;
			toolStripMenuItem.Click += method_76;
			contextMenuStrip_0.Items.Insert(0, toolStripMenuItem);
			num++;
		}
		Point position = new Point(0, 0);
		contextMenuStrip_0.Show(themedButton_2, position, ToolStripDropDownDirection.AboveRight);
	}

	private void themedButton_5_Click(object sender, EventArgs e)
	{
		contextMenuStrip_1.BackColor = Form23.color_15;
		contextMenuStrip_1.ForeColor = Form23.color_12;
		contextMenuStrip_1.Items.Clear();
		int num = 0;
		foreach (TreeNode item in stack_1)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
			if (item.Tag == null)
			{
				toolStripMenuItem.Text = Class333.smethod_542();
			}
			else
			{
				toolStripMenuItem.Text = method_47(item, bool_7: false, bool_8: false);
			}
			toolStripMenuItem.Tag = num;
			toolStripMenuItem.Click += method_77;
			contextMenuStrip_1.Items.Add(toolStripMenuItem);
			num++;
		}
		Point position = new Point(0, 0);
		contextMenuStrip_1.Show(themedButton_5, position, ToolStripDropDownDirection.AboveRight);
	}

	private void method_76(object sender, EventArgs e)
	{
		int num = (int)(sender as ToolStripMenuItem).Tag;
		for (int i = 0; i < num; i++)
		{
			stack_1.Push(stack_0.Pop());
		}
		themedButton_3_Click(null, null);
	}

	private void method_77(object sender, EventArgs e)
	{
		int num = (int)(sender as ToolStripMenuItem).Tag;
		for (int i = 0; i < num; i++)
		{
			stack_0.Push(stack_1.Pop());
		}
		themedButton_4_Click(null, null);
	}

	private void Control4_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			int_5 = e.X;
			int_6 = e.Y;
			int_7 = Width;
			int_8 = class134_0.Height;
			if (int_5 >= Width - 5)
			{
				bool_0 = true;
			}
			else if (int_6 >= treeViewWithThemedScrollBars_0.Bottom - 2 && int_6 <= treeViewWithThemedScrollBars_0.Bottom + 2)
			{
				bool_1 = true;
			}
			else if (int_6 >= class134_0.Top - 4 && int_6 <= class134_0.Top)
			{
				bool_1 = true;
			}
		}
	}

	private void Control4_MouseUp(object sender, MouseEventArgs e)
	{
		bool_0 = false;
		bool_1 = false;
		Form23.smethod_73();
	}

	private void Control4_MouseMove(object sender, MouseEventArgs e)
	{
		int num = e.X - int_5;
		int num2 = e.Y - int_6;
		if (bool_0)
		{
			Width = Math.Max(int_7 + num, 160);
			Form23.smethod_73();
			Invalidate();
		}
		else if (bool_1)
		{
			class134_0.Height = Math.Max(int_8 - num2, 1);
			method_10();
			Invalidate();
		}
		method_78(e.X, e.Y);
	}

	private void Control4_MouseLeave(object sender, EventArgs e)
	{
		Cursor = Cursors.Default;
	}

	private void method_78(int int_9, int int_10)
	{
		if (int_9 >= Width - 5)
		{
			Cursor = Cursors.SizeWE;
		}
		else if (int_10 >= treeViewWithThemedScrollBars_0.Bottom - 2 && int_10 <= treeViewWithThemedScrollBars_0.Bottom + 2)
		{
			Cursor = Cursors.SizeNS;
		}
		else if (int_10 >= class134_0.Top - 4 && int_10 <= class134_0.Top)
		{
			Cursor = Cursors.SizeNS;
		}
		else
		{
			Cursor = Cursors.Default;
		}
	}

	private void treeViewWithThemedScrollBars_0_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Right)
		{
			return;
		}
		int x = e.X;
		int y = e.Y;
		TreeNode treeNode = treeViewWithThemedScrollBars_0.method_41(x, y, out var _);
		if (treeNode != null)
		{
			if (!(treeNode.Tag is MenuNode))
			{
				return;
			}
			MenuNode menuNode = treeNode.Tag as MenuNode;
			SettingOrSpecialObject settingOrSpecialObject = Form23.framework_1.method_33(menuNode.method_3());
			Setting setting = null;
			if (Form23.framework_1.method_4() && menuNode.method_22() != 0)
			{
				setting = Form23.framework_1.method_31(menuNode.method_22());
				if (setting != null && setting.method_0().method_2() && setting.method_0().method_3() && setting.method_96())
				{
					setting = null;
				}
			}
			bool flag = false;
			if (Form23.framework_1.awZ == 21 && Form23.framework_1.awR != null)
			{
				flag = menuNode == Form23.framework_1.awR;
			}
			bool flag2 = false;
			if (Form23.framework_1.awZ == 21 && Form23.framework_1.awS != null)
			{
				flag2 = menuNode == Form23.framework_1.awS;
			}
			HashSet<DataIdAndAttrId> hashSet = MenuNode.smethod_1(menuNode, bool_0: true);
			bool flag3;
			if (Form23.framework_1.method_4() && hashSet.Count != 0)
			{
				flag3 = true;
				if (Form23.framework_1.method_2() && Form23.framework_1.method_3())
				{
					foreach (DataIdAndAttrId item in hashSet)
					{
						Setting setting2 = Form23.framework_1.method_32(item);
						if (setting2 != null && setting2.method_96())
						{
							flag3 = false;
							break;
						}
					}
				}
			}
			else
			{
				flag3 = false;
			}
			if (flag3)
			{
				foreach (DataIdAndAttrId item2 in menuNode.method_104(bool_0: false))
				{
					Setting setting3 = Form23.framework_1.method_32(item2);
					if (setting3 != null && setting3.method_176())
					{
						flag3 = false;
						break;
					}
				}
			}
			bool flag4 = settingOrSpecialObject is Table || menuNode.method_60() != -1;
			if (!(((((flag3 | flag4) || setting != null) | flag) || menuNode.method_37()) | flag2) && !menuNode.method_45() && !menuNode.method_38())
			{
				return;
			}
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			contextMenuStrip.BackColor = Form23.color_15;
			contextMenuStrip.ForeColor = Form23.color_12;
			if (flag)
			{
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
				toolStripMenuItem.Text = Class333.smethod_543();
				toolStripMenuItem.Click += method_80;
				contextMenuStrip.Items.Add(toolStripMenuItem);
			}
			else if (menuNode.method_37())
			{
				ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
				toolStripMenuItem2.Text = Class333.smethod_544();
				toolStripMenuItem2.Tag = menuNode.method_39();
				toolStripMenuItem2.Click += method_81;
				contextMenuStrip.Items.Add(toolStripMenuItem2);
				ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
				toolStripMenuItem3.Text = Class333.smethod_545();
				toolStripMenuItem3.Tag = menuNode.method_39();
				toolStripMenuItem3.Click += method_82;
				contextMenuStrip.Items.Add(toolStripMenuItem3);
			}
			else if (menuNode.method_38())
			{
				if (menuNode.method_5() != null)
				{
					MenuNode menuNode2 = menuNode.method_5().method_5();
					if (menuNode2 != null)
					{
						ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
						toolStripMenuItem4.Text = Class333.smethod_352();
						toolStripMenuItem4.Tag = menuNode2;
						toolStripMenuItem4.Click += method_83;
						contextMenuStrip.Items.Add(toolStripMenuItem4);
						ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem();
						toolStripMenuItem5.Text = Class333.smethod_348();
						toolStripMenuItem5.Tag = menuNode2;
						toolStripMenuItem5.Click += method_84;
						contextMenuStrip.Items.Add(toolStripMenuItem5);
					}
				}
			}
			else if (flag2)
			{
				ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem();
				toolStripMenuItem6.Text = Class333.smethod_546();
				toolStripMenuItem6.Click += method_85;
				contextMenuStrip.Items.Add(toolStripMenuItem6);
			}
			else if (menuNode.method_45())
			{
				ToolStripMenuItem toolStripMenuItem7 = new ToolStripMenuItem();
				toolStripMenuItem7.Text = Class333.smethod_547();
				toolStripMenuItem7.Tag = menuNode.method_46();
				toolStripMenuItem7.Click += method_86;
				contextMenuStrip.Items.Add(toolStripMenuItem7);
				ToolStripMenuItem toolStripMenuItem8 = new ToolStripMenuItem();
				toolStripMenuItem8.Text = Class333.smethod_548();
				toolStripMenuItem8.Tag = menuNode.method_46();
				toolStripMenuItem8.Click += method_87;
				contextMenuStrip.Items.Add(toolStripMenuItem8);
				int alarmIndex = menuNode.method_46();
				ToolStripMenuItem alertBannerItem = new ToolStripMenuItem("Alarm Appearance...");
				alertBannerItem.Available = Form23.SupportsDashMedia(Form23.framework_1);
				alertBannerItem.Click += (_, _) => {
					var alarms = Form23.framework_1?.awp?.method_73();
					string message = alarms != null && alarmIndex >= 0 && alarmIndex < alarms.Count
						? NSP.UserInterface.AlertBannerEditor.AlarmText(alarms[alarmIndex]) : null;
					Form23.OpenAlertBannerEditor(message);
				};
				contextMenuStrip.Items.Add(alertBannerItem);
			}
			if (Form23.framework_1.method_4())
			{
				if (setting != null)
				{
					if ((setting.method_64() != 10195) ? (setting.method_256() == 1) : (setting.method_256() != 0))
					{
						ToolStripMenuItem toolStripMenuItem9 = new ToolStripMenuItem();
						toolStripMenuItem9.Text = Class333.smethod_549() + menuNode.method_10();
						toolStripMenuItem9.Tag = menuNode;
						toolStripMenuItem9.Click += method_97;
						contextMenuStrip.Items.Add(toolStripMenuItem9);
					}
					else
					{
						ToolStripMenuItem toolStripMenuItem10 = new ToolStripMenuItem();
						toolStripMenuItem10.Text = Class333.smethod_550() + menuNode.method_10();
						toolStripMenuItem10.Tag = menuNode;
						toolStripMenuItem10.Click += method_98;
						contextMenuStrip.Items.Add(toolStripMenuItem10);
					}
				}
				if (flag3)
				{
					ToolStripMenuItem toolStripMenuItem11 = new ToolStripMenuItem();
					toolStripMenuItem11.Text = Class333.smethod_551();
					toolStripMenuItem11.Tag = menuNode;
					toolStripMenuItem11.Click += method_95;
					contextMenuStrip.Items.Add(toolStripMenuItem11);
				}
			}
			if (flag4)
			{
				int num = -1;
				if (Form23.framework_1.awA)
				{
					num = menuNode.method_60();
				}
				else if (settingOrSpecialObject is Table)
				{
					num = (settingOrSpecialObject as Table).method_64();
				}
				if (num != -1)
				{
					if (!list_0.Contains(num))
					{
						ToolStripMenuItem toolStripMenuItem12 = new ToolStripMenuItem();
						toolStripMenuItem12.Text = Class333.smethod_552();
						toolStripMenuItem12.Tag = num;
						toolStripMenuItem12.Click += method_91;
						contextMenuStrip.Items.Add(toolStripMenuItem12);
					}
					else
					{
						ToolStripMenuItem toolStripMenuItem13 = new ToolStripMenuItem();
						toolStripMenuItem13.Text = Class333.smethod_553();
						toolStripMenuItem13.Tag = num;
						toolStripMenuItem13.Click += method_92;
						contextMenuStrip.Items.Add(toolStripMenuItem13);
					}
				}
			}
			contextMenuStrip.Show(treeViewWithThemedScrollBars_0, new Point(x, y));
		}
		else
		{
			ContextMenuStrip contextMenuStrip2 = new ContextMenuStrip
			{
				BackColor = Form23.color_15,
				ForeColor = Form23.color_12
			};
			ToolStripMenuItem toolStripMenuItem14 = new ToolStripMenuItem();
			toolStripMenuItem14.Text = Class333.smethod_554();
			toolStripMenuItem14.Click += method_79;
			contextMenuStrip2.Items.Add(toolStripMenuItem14);
			contextMenuStrip2.Show(treeViewWithThemedScrollBars_0, new Point(x, y));
		}
	}

	private void method_79(object sender, EventArgs e)
	{
		Form23.form23_0.method_117();
		Form57 form = new Form57();
		form.ShowDialog(Form23.form23_0);
		form.Dispose();
	}

	private void method_80(object sender, EventArgs e)
	{
		int num = Form23.framework_1.awP.method_72().method_256();
		if (num < Form23.framework_1.awP.method_79().Count)
		{
			if (Form23.framework_1.awP.method_82(num))
			{
				Class89.smethod_0(Form23.framework_1, num);
			}
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, Class333.smethod_555() + Form23.framework_1.awP.method_79().Count, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	private void method_81(object sender, EventArgs e)
	{
		if (Form23.framework_1.awP.method_72().method_256() < Form23.framework_1.awP.method_79().Count)
		{
			int num = (int)(sender as ToolStripMenuItem).Tag;
			Form23.framework_1.awP.method_88(num);
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, Class333.smethod_555() + Form23.framework_1.awP.method_79().Count, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	private void method_82(object sender, EventArgs e)
	{
		int num = (int)(sender as ToolStripMenuItem).Tag;
		TreeNode treeNode = method_53(treeViewWithThemedScrollBars_0.method_2(), Form23.framework_1.awR);
		if (treeNode != null)
		{
			treeViewWithThemedScrollBars_0.method_4(treeNode);
		}
		Form23.framework_1.awP.method_86(num);
	}

	private void method_83(object sender, EventArgs e)
	{
		int index = ((MenuNode)(sender as ToolStripMenuItem).Tag).method_39();
		Class250 @class = Form23.framework_1.awP.method_79()[index];
		if (@class.method_73() < @class.method_72().Count)
		{
			Form23.framework_1.awP.method_85();
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, Class333.smethod_556() + @class.method_72().Count, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	private void method_84(object sender, EventArgs e)
	{
		MenuNode menuNode_ = (MenuNode)(sender as ToolStripMenuItem).Tag;
		TreeNode treeNode = method_53(treeViewWithThemedScrollBars_0.method_2(), menuNode_);
		if (treeNode != null)
		{
			treeViewWithThemedScrollBars_0.method_4(treeNode);
		}
		Form23.framework_1.awP.method_84();
	}

	private void method_85(object sender, EventArgs e)
	{
		Form23.framework_1.awp.method_74();
	}

	private void method_86(object sender, EventArgs e)
	{
		int num = (int)(sender as ToolStripMenuItem).Tag;
		Form23.framework_1.awp.method_76(num);
	}

	private void method_87(object sender, EventArgs e)
	{
		int num = (int)(sender as ToolStripMenuItem).Tag;
		Form23.framework_1.awp.method_75(num);
	}

	internal void method_88(int int_9, int int_10)
	{
		List<int> list = new List<int>(list_0.Count);
		foreach (int item in list_0)
		{
			if (item != int_9)
			{
				list.Add(item);
			}
		}
		if (int_10 < list.Count)
		{
			list.Insert(int_10, int_9);
		}
		else
		{
			list.Add(int_9);
		}
		for (int num = list_0.Count - 1; num >= 0; num--)
		{
			int num2 = list_0[num];
			list_0.Remove(num2);
			method_90(num2);
		}
		foreach (int item2 in list)
		{
			list_0.Add(item2);
			method_89(item2);
		}
		method_14(bool_7: true, bool_8: true, bool_9: false, bool_10: false);
		method_39(bool_7: false);
		if (Form23.framework_0 != null)
		{
			method_40(bool_7: false);
		}
	}

	private void method_89(int int_9)
	{
		bool flag = false;
		foreach (Table item in Form23.framework_1.aWV)
		{
			if (item.method_64() == int_9)
			{
				flag = true;
				break;
			}
		}
		if (!Directory.Exists(Form23.string_3 + Class333.smethod_557()))
		{
			Directory.CreateDirectory(Form23.string_3 + Class333.smethod_557());
		}
		List<string> list = new List<string>();
		if (flag)
		{
			list.Add(Class333.smethod_558() + int_9);
		}
		if (Form23.framework_1.awA)
		{
			list.Add(Class333.smethod_559() + int_9);
		}
		File.AppendAllLines(string_0, list);
	}

	private void method_90(int int_9)
	{
		if (!Directory.Exists(Form23.string_3 + Class333.smethod_557()))
		{
			Directory.CreateDirectory(Form23.string_3 + Class333.smethod_557());
		}
		if (!File.Exists(string_0))
		{
			return;
		}
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		using (StreamReader streamReader = File.OpenText(string_0))
		{
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (text.StartsWith(Class333.smethod_559()))
				{
					int num = int.Parse(text.Substring(Class333.smethod_559().Length));
					if (num != int_9 && !list.Contains(num))
					{
						list.Add(num);
					}
				}
				else if (text.StartsWith(Class333.smethod_558()))
				{
					int num2 = int.Parse(text.Substring(Class333.smethod_558().Length));
					if (num2 != int_9 && !list2.Contains(num2))
					{
						list2.Add(num2);
					}
				}
			}
		}
		File.Delete(string_0);
		File.Create(string_0).Close();
		List<string> list3 = new List<string>();
		foreach (int item in list)
		{
			list3.Add(Class333.smethod_559() + item);
		}
		foreach (int item2 in list2)
		{
			list3.Add(Class333.smethod_558() + item2);
		}
		File.AppendAllLines(string_0, list3);
	}

	private void method_91(object sender, EventArgs e)
	{
		int num = (int)(sender as ToolStripMenuItem).Tag;
		list_0.Add(num);
		method_89(num);
		method_14(bool_7: false, bool_8: true, bool_9: false, bool_10: false);
		method_39(bool_7: false);
		if (Form23.framework_0 != null)
		{
			method_40(bool_7: false);
		}
	}

	private void method_92(object sender, EventArgs e)
	{
		int num = (int)(sender as ToolStripMenuItem).Tag;
		list_0.Remove(num);
		method_90(num);
		method_14(bool_7: false, bool_8: true, bool_9: false, bool_10: false);
		method_39(bool_7: false);
		if (Form23.framework_0 != null)
		{
			method_40(bool_7: false);
		}
	}

	private void method_93()
	{
		foreach (MenuNode item in Form23.framework_1.awL)
		{
			if (Form23.framework_1.awA)
			{
				if (item.method_60() != -1)
				{
					list_0.Add(item.method_60());
					method_89(item.method_60());
				}
				continue;
			}
			SettingOrSpecialObject settingOrSpecialObject = Form23.framework_1.method_33(item.method_3());
			if (settingOrSpecialObject is Table)
			{
				int num = (settingOrSpecialObject as Table).method_64();
				list_0.Add(num);
				method_89(num);
			}
		}
	}

	private void method_94()
	{
		using StreamReader streamReader = File.OpenText(string_0);
		string text;
		while ((text = streamReader.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.smethod_558()))
			{
				int item = int.Parse(text.Substring(Class333.smethod_558().Length));
				if (!list_0.Contains(item))
				{
					list_0.Add(item);
				}
			}
			else if (text.StartsWith(Class333.smethod_559()) && Form23.framework_1.awA)
			{
				int item2 = int.Parse(text.Substring(Class333.smethod_559().Length));
				if (!list_0.Contains(item2))
				{
					list_0.Add(item2);
				}
			}
		}
	}

	private void method_95(object sender, EventArgs e)
	{
		MenuNode menuNode_ = (sender as ToolStripMenuItem).Tag as MenuNode;
		bool flag = false;
		if (Form42.smethod_0())
		{
			flag = true;
		}
		else
		{
			Form42 form = new Form42(menuNode_);
			if (form.ShowDialog(this) == DialogResult.OK)
			{
				flag = true;
			}
			form.Dispose();
		}
		if (flag)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_1();
			Form23.framework_1.method_48(Form23.framework_1.aWS);
			Form23.framework_1.method_55();
			method_96(menuNode_, bool_7: false);
			Form23.form23_0.method_131();
			method_96(menuNode_, bool_7: true);
			Form23.framework_1.method_54(bool_0: true);
			Form23.framework_1.method_49(Form23.framework_1.aWS);
			@class?.method_4();
		}
	}

	private void method_96(MenuNode menuNode_1, bool bool_7)
	{
		foreach (DataIdAndAttrId item in MenuNode.smethod_1(menuNode_1, bool_0: true))
		{
			Setting setting = Form23.framework_1.method_32(item);
			if (setting != null)
			{
				bool flag = PortFunction.smethod_27(setting.method_6());
				if (((!bool_7 && !flag) || (bool_7 & flag)) && setting.method_246(bool_0: true))
				{
					Form23.smethod_75(item);
				}
			}
		}
	}

	private void method_97(object sender, EventArgs e)
	{
		MenuNode menuNode = (sender as ToolStripMenuItem).Tag as MenuNode;
		Setting setting = Form23.framework_1.method_31(menuNode.method_22());
		if (menuNode.method_22() != 0 && setting != null)
		{
			MenuNode menuNode2 = menuNode;
			menuNode2?.method_0().method_2(setting.method_64());
			setting.method_272(0, bool_0: true);
			menuNode2?.method_0().method_4();
			Form23.smethod_74(setting.method_64());
		}
	}

	private void method_98(object sender, EventArgs e)
	{
		MenuNode menuNode = (sender as ToolStripMenuItem).Tag as MenuNode;
		Setting setting = Form23.framework_1.method_31(menuNode.method_22());
		if (menuNode.method_22() == 0 || setting == null)
		{
			return;
		}
		Setting setting_ = null;
		MenuNode menuNode2 = null;
		string text = setting.method_47();
		if (text == null)
		{
			menuNode2 = menuNode;
			if (menuNode2 != null)
			{
				text = menuNode2.method_64();
			}
		}
		else
		{
			setting_ = setting;
		}
		MenuNode menuNode3 = menuNode;
		bool flag = true;
		if (text != null && !Form13.smethod_0(setting_, menuNode2))
		{
			Form13 form = new Form13(text, setting_, menuNode2);
			if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
			{
				menuNode3?.method_0().method_2(setting.method_64());
				if (setting.method_64() == 10195 && setting.method_102().Count == 3)
				{
					setting.method_272(2, bool_0: true);
				}
				else
				{
					setting.method_272(1, bool_0: true);
				}
			}
			else
			{
				flag = false;
			}
			form.Dispose();
		}
		else
		{
			menuNode3?.method_0().method_2(setting.method_64());
			if (setting.method_64() == 10195 && setting.method_102().Count == 3)
			{
				setting.method_272(2, bool_0: true);
			}
			else
			{
				setting.method_272(1, bool_0: true);
			}
		}
		if (flag)
		{
			SettingOrSpecialObject settingOrSpecialObject = null;
			if (setting.method_6() != null && setting.method_6() is SpecialObject && Form23.framework_1.aWY.Contains(setting.method_6()))
			{
				settingOrSpecialObject = setting.method_6();
				if (settingOrSpecialObject != null)
				{
					PortFunction.smethod_20(settingOrSpecialObject, bool_0: false);
				}
			}
			menuNode3?.method_0().method_4();
		}
		Form23.smethod_74(setting.method_64());
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		themedTextBox_0.Text = string.Empty;
	}

	private void themedTextBox_0_TextChanged(object sender, EventArgs e)
	{
		timer_0.Stop();
		timer_0.Start();
	}

	private void method_99(object sender, ThemedTextBox.EventArgs4 e)
	{
		timer_0.Stop();
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		bool flag = themedTextBox_0.Text == string.Empty;
		method_14(bool_7: true, bool_8: false, bool_9: true, flag);
		method_39(bool_7: false);
		if (Form23.framework_0 != null)
		{
			method_40(bool_7: false);
		}
		if (flag)
		{
			Form23.bool_3 = false;
			themedTextBox_0.Focus();
		}
	}
}
