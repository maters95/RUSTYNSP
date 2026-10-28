using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns1;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;

namespace ns4;

internal class Form48 : Form
{
	private delegate void Delegate117(object sender, EventArgs e);

	private delegate void Delegate118(object sender, EventArgs e);

	private delegate void Delegate119(object sender, EventArgs e);

	private Framework framework_0;

	private Setting setting_0;

	private ThemedButton themedButton_0 = new ThemedButton();

	private ThemedButton themedButton_1 = new ThemedButton();

	private ProgressBar progressBar_0 = new ProgressBar();

	private ToolTip toolTip_0 = new ToolTip();

	private bool bool_0;

	private int int_0;

	private HashSet<DataIdAndAttrId> hashSet_0 = new HashSet<DataIdAndAttrId>();

	private List<Control> list_0 = new List<Control>();

	private List<ModifyOnChange> list_1 = new List<ModifyOnChange>();

	internal static MenuNode menuNode_0;

	private IContainer icontainer_0;

	internal static bool smethod_0(Framework framework_1)
	{
		if (framework_1.awl != null)
		{
			Setting setting = framework_1.method_31(16035);
			if (setting != null)
			{
				return setting.method_256() != 255;
			}
			return false;
		}
		return false;
	}

	internal static bool smethod_1(Framework framework_1, out bool bool_1, out bool bool_2, out bool bool_3)
	{
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		if (smethod_0(framework_1))
		{
			Setting setting = framework_1.method_31(16035);
			if (setting.method_256() == 0)
			{
				Setting setting2 = framework_1.method_31(14691);
				int num = 0;
				if (setting2 != null)
				{
					num = setting2.method_256();
				}
				framework_1.method_15(framework_1.aWS);
				setting2?.method_272(num, bool_0: true);
				framework_1.method_73();
			}
			if (Form23.smethod_28(framework_1.aXc, bool_53: true))
			{
				Class122.smethod_0(framework_1, out var flag);
				if (flag)
				{
					bool_1 = true;
					return false;
				}
			}
			Form48 form = new Form48(framework_1, setting);
			DialogResult dialogResult = form.ShowDialog(Form23.form23_0);
			form.Dispose();
			if (dialogResult == DialogResult.Abort)
			{
				bool_1 = true;
			}
			else
			{
				Form23.form23_0.method_44();
				switch (dialogResult)
				{
				case DialogResult.Cancel:
					bool_2 = true;
					break;
				case DialogResult.Ignore:
					bool_3 = true;
					break;
				}
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	internal static bool smethod_2()
	{
		return menuNode_0 != null;
	}

	internal Form48(Framework framework_1, Setting setting_1)
	{
		method_13();
		framework_0 = framework_1;
		setting_0 = setting_1;
		themedButton_0.Text = Class333.smethod_2551();
		themedButton_0.AutoSize = false;
		themedButton_0.Width = 100;
		themedButton_0.Height = 25;
		themedButton_0.Left = 5;
		themedButton_0.Top = ClientRectangle.Height - 5 - themedButton_0.Height;
		themedButton_0.Click += themedButton_0_Click;
		Controls.Add(themedButton_0);
		themedButton_1.AutoSize = false;
		themedButton_1.Width = 100;
		themedButton_1.Height = 25;
		themedButton_1.Left = ClientRectangle.Width - 5 - themedButton_1.Width;
		themedButton_1.Top = ClientRectangle.Height - 5 - themedButton_1.Height;
		themedButton_1.Click += themedButton_1_Click;
		Controls.Add(themedButton_1);
		progressBar_0.Minimum = 0;
		progressBar_0.Maximum = framework_0.awl.method_6().Count;
		progressBar_0.Width = themedButton_1.Left - 70 - (themedButton_0.Right + 70);
		progressBar_0.Height = 10;
		progressBar_0.Left = themedButton_0.Right + 70;
		progressBar_0.Top = ClientRectangle.Height - 22;
		Controls.Add(progressBar_0);
		Text = framework_0.awl.method_10();
		MouseMove += Form48_MouseMove;
		Form23.smethod_7(method_0);
	}

	private void Form48_Shown(object sender, EventArgs e)
	{
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		int num = setting_0.method_256();
		int_0 = num;
		method_4();
	}

	private void method_0(object sender, EventArgs e)
	{
		Close();
	}

	private void Form48_FormClosing(object sender, FormClosingEventArgs e)
	{
		bool flag;
		if (setting_0.method_256() != 255)
		{
			if (Form23.bool_17)
			{
				DialogResult = DialogResult.Ignore;
				flag = true;
			}
			else
			{
				switch (Form54.smethod_9(this, Class333.smethod_2557(), Class333.smethod_2558(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3, new string[3]
				{
					Class333.smethod_2559(),
					Class333.smethod_2560(),
					Class333.smethod_2561()
				}))
				{
				case DialogResult.Yes:
					DialogResult = DialogResult.Abort;
					flag = true;
					break;
				case DialogResult.No:
					DialogResult = DialogResult.Cancel;
					flag = true;
					setting_0.method_272(255, bool_0: true);
					Form23.smethod_74(setting_0.method_64());
					break;
				default:
					flag = false;
					break;
				}
			}
		}
		else
		{
			DialogResult = DialogResult.OK;
			flag = true;
		}
		if (flag)
		{
			method_3();
			list_0.Clear();
			menuNode_0 = null;
		}
		else
		{
			e.Cancel = true;
		}
	}

	private int method_1()
	{
		if (framework_0 != null)
		{
			int num = int_0 - 1;
			while (num >= 0)
			{
				if (framework_0.awl.method_6()[num].method_101(bool_0: true))
				{
					num--;
					continue;
				}
				return num;
			}
		}
		return int_0;
	}

	private int method_2()
	{
		if (framework_0 != null)
		{
			for (int i = int_0 + 1; i <= framework_0.awl.method_6().Count; i++)
			{
				if (i >= framework_0.awl.method_6().Count || !framework_0.awl.method_6()[i].method_101(bool_0: true))
				{
					return i;
				}
			}
		}
		return int_0;
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		int num = int_0;
		int_0 = method_1();
		if (int_0 < num)
		{
			setting_0.method_272(int_0, bool_0: true);
			Form23.smethod_74(setting_0.method_64());
			method_4();
		}
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		int num = int_0;
		int_0 = method_2();
		if (int_0 > num)
		{
			setting_0.method_272(int_0, bool_0: true);
			Form23.smethod_74(setting_0.method_64());
			method_4();
		}
		else
		{
			setting_0.method_272(255, bool_0: true);
			Form23.smethod_74(setting_0.method_64());
			Close();
		}
	}

	private void method_3()
	{
		foreach (DataIdAndAttrId item in hashSet_0)
		{
			Setting setting = framework_0.method_32(item);
			if (setting != null)
			{
				setting.method_265(method_6);
				setting.method_41(method_7);
			}
		}
		foreach (Control item2 in list_0)
		{
			if (item2 is Control6)
			{
				(item2 as Control6).method_12(method_8);
			}
			else if (item2 is Control5)
			{
				(item2 as Control5).method_9(method_8);
			}
		}
		foreach (ModifyOnChange item3 in list_1)
		{
			item3.method_1().method_265(method_6);
		}
	}

	private void method_4()
	{
		if (int_0 <= progressBar_0.Maximum)
		{
			progressBar_0.Value = int_0;
		}
		SuspendLayout();
		while (Controls.Count > 3)
		{
			foreach (Control control in Controls)
			{
				if (control != themedButton_0 && control != themedButton_1 && control != progressBar_0)
				{
					control.Dispose();
					break;
				}
			}
		}
		ResumeLayout(performLayout: true);
		method_3();
		if (framework_0.awl.method_6().Count < int_0)
		{
			return;
		}
		Rectangle rectangle_ = new Rectangle(5, 5, ClientRectangle.Width - 10, ClientRectangle.Height - 15 - themedButton_0.Height);
		MenuNode menuNode = null;
		if (int_0 < framework_0.awl.method_6().Count)
		{
			menuNode = framework_0.awl.method_6()[int_0];
			hashSet_0.Clear();
			hashSet_0.UnionWith(menuNode.method_104(bool_0: false));
			foreach (DataIdAndAttrId item in hashSet_0)
			{
				Setting setting = framework_0.method_32(item);
				if (setting != null)
				{
					setting.method_264(method_6);
					setting.method_40(method_7);
				}
			}
			list_1.Clear();
			foreach (ModifyOnChange item2 in menuNode.method_97())
			{
				if (item2.method_1() == null)
				{
					continue;
				}
				list_1.Add(item2);
				item2.method_1().method_265(method_6);
				item2.method_1().method_264(method_6);
				foreach (Setting item3 in item2.method_2(bool_0: true))
				{
					Form23.smethod_74(item3.method_64());
				}
			}
		}
		else
		{
			list_0.Clear();
			hashSet_0.Clear();
			list_1.Clear();
		}
		if (int_0 == framework_0.awl.method_6().Count)
		{
			themedButton_1.Text = Class333.smethod_2552();
			method_5(rectangle_);
		}
		else
		{
			SuspendLayout();
			themedButton_1.Text = Class333.smethod_2553();
			menuNode_0 = menuNode;
			int num = menuNode.method_3();
			SettingOrSpecialObject settingOrSpecialObject = framework_0.method_33(num);
			if (settingOrSpecialObject != null)
			{
				Interface4 @interface = settingOrSpecialObject.method_11();
				if (@interface != null)
				{
					if (@interface is UIListObject)
					{
						Class117 @class = new Class117(settingOrSpecialObject as SpecialObject, string.Empty, menuNode, framework_0, null, rectangle_, bool_0: false, bool_1: false);
						Controls.Add(@class);
						@class.method_15(bool_0: true);
					}
					else if (@interface is StateMachine)
					{
						Class116 class2 = new Class116(settingOrSpecialObject as StateMachine, framework_0, null, rectangle_, bool_0: false);
						Controls.Add(class2);
						class2.method_17();
					}
				}
				else if (settingOrSpecialObject.method_1().Count != 0)
				{
					Class117 class3 = new Class117(settingOrSpecialObject as SpecialObject, string.Empty, menuNode, framework_0, null, rectangle_, bool_0: false, bool_1: false);
					Controls.Add(class3);
					class3.method_15(bool_0: true);
				}
			}
			else
			{
				foreach (MenuNode item4 in menuNode.method_6())
				{
					if (item4.method_28())
					{
						Class118 class4 = new Class118(framework_0, null, rectangle_, bool_0: false, bool_1: false, bool_2: false);
						class4.method_15(menuNode);
						Controls.Add(class4);
						class4.method_21(bool_0: true);
						break;
					}
				}
			}
			ResumeLayout(performLayout: true);
			method_9();
			list_0 = method_11();
			foreach (Control item5 in list_0)
			{
				if (item5 is Control6)
				{
					(item5 as Control6).method_11(method_8);
				}
				else if (item5 is Control5)
				{
					(item5 as Control5).method_8(method_8);
				}
			}
		}
		method_12();
		method_10();
	}

	private void method_5(Rectangle rectangle_0)
	{
		SuspendLayout();
		Class109 @class = new Class109(rectangle_0, bool_0: false, bool_1: false);
		@class.Left = rectangle_0.Left;
		@class.Top = rectangle_0.Top;
		@class.Width = rectangle_0.Width;
		@class.Height = rectangle_0.Height;
		int num = 10;
		int num2 = 10;
		int num3 = 0;
		Label label = new Label();
		label.Text = Class333.smethod_2562();
		label.ForeColor = Form23.color_14;
		label.Font = new Font(label.Font.FontFamily, 12f, FontStyle.Bold);
		label.BackColor = Color.Transparent;
		label.AutoSize = true;
		label.Left = 10;
		label.Top = 10;
		@class.method_12().Controls.Add(label);
		num = 10 + (label.Height + 10);
		int num4 = num;
		foreach (MenuNode item in framework_0.awl.method_6())
		{
			if (item.method_101(bool_0: true))
			{
				continue;
			}
			MovableResizablePanel movableResizablePanel = new MovableResizablePanel(Rectangle.Empty, bool_0: false, bool_1: true, bool_2: true);
			int num5 = 10;
			Label label2 = new Label();
			label2.Text = item.method_10();
			label2.ForeColor = Form23.color_14;
			label2.Font = new Font(label2.Font.FontFamily, 10f, FontStyle.Bold);
			label2.BackColor = Color.Transparent;
			label2.AutoSize = true;
			label2.Left = 10;
			label2.Top = 10;
			movableResizablePanel.Controls.Add(label2);
			num5 = 10 + (label2.Height + 10);
			foreach (DataIdAndAttrId item2 in item.method_104(bool_0: false))
			{
				Setting setting = framework_0.method_32(item2);
				if (setting == null || !setting.method_35() || setting.method_219() || setting.method_220())
				{
					continue;
				}
				if (PortFunction.smethod_27(setting.method_6()))
				{
					SettingOrSpecialObject settingOrSpecialObject = setting.method_6();
					if (!settingOrSpecialObject.method_35() || setting.method_6() is Table || setting.method_6() is TableAxis)
					{
						continue;
					}
					Enum104 bSQ = settingOrSpecialObject.method_12().method_12().BSQ;
					Enum105 bSq = settingOrSpecialObject.method_12().method_12().BSq;
					byte bSR = settingOrSpecialObject.method_12().method_12().BSR;
					ushort bSr = settingOrSpecialObject.method_12().method_12().BSr;
					PortFunction.Class272 class2 = PortFunction.smethod_46(framework_0, bSQ, bSq, bSR, bSr);
					List<Class244> list = PortFunction.smethod_44(framework_0, bSQ, bSq, bSR, bSr, bool_0: false);
					if ((class2 == null && (list == null || list.Count != 1)) || !PortFunction.smethod_51(setting, list[0], class2))
					{
						continue;
					}
				}
				string text = string.Empty;
				if (framework_0.awX.ContainsKey(setting.method_64()))
				{
					MenuNode menuNode = framework_0.awX[setting.method_64()];
					if (menuNode.method_80() != null && menuNode.method_80().BcF != null)
					{
						MenuNode menuNode2 = MenuNode.smethod_2(item.method_6(), setting.method_69());
						if (menuNode2 != null)
						{
							Class286 bcF = menuNode.method_80().BcF;
							if (menuNode2.method_50() && !string.IsNullOrWhiteSpace(menuNode2.method_10()))
							{
								string text2;
								if (menuNode2.method_10().ToLower().Contains(Class333.smethod_2563()))
								{
									text2 = menuNode2.method_10().Substring(menuNode2.method_10().ToLower().IndexOf(Class333.smethod_2563()) + Class333.smethod_2563().Length);
								}
								else
								{
									text2 = ((!menuNode2.method_10().ToLower().Contains(Class333.smethod_2564())) ? menuNode2.method_10() : menuNode2.method_10().Substring(menuNode2.method_10().ToLower().IndexOf(Class333.smethod_2564()) + Class333.smethod_2564().Length));
								}
								text = text + text2 + Class333.smethod_611();
							}
							string bsP = bcF.BcC[Class333.smethod_562()].BsP;
							if (bsP.Contains(Class333.smethod_570()) && !string.IsNullOrWhiteSpace(text))
							{
								text += Class333.smethod_570();
							}
							text += bsP;
						}
					}
				}
				else
				{
					text = text + setting.method_22(bool_0: true) + Class333.smethod_611();
					if (setting.method_212())
					{
						continue;
					}
					if (setting.method_70() != 0)
					{
						string text3 = setting.method_260();
						if (text3.Contains(Class333.smethod_570()))
						{
							text += Class333.smethod_570();
						}
						text += text3;
					}
					else if (setting is Class244)
					{
						int num6 = setting.method_256();
						if (num6 == 0)
						{
							text += Class333.smethod_2565();
						}
						else
						{
							Enum105 @enum = PortFunction.smethod_13((uint)num6);
							if (@enum == Enum105.Bal)
							{
								text += Class333.smethod_883();
							}
							else
							{
								Enum104 enum104_ = PortFunction.smethod_12((uint)num6);
								byte byte_ = PortFunction.smethod_14((uint)num6);
								ushort ushort_ = PortFunction.smethod_15((uint)num6);
								SettingOrSpecialObject settingOrSpecialObject2 = PortFunction.smethod_36(framework_0, enum104_, @enum, byte_, ushort_);
								if (settingOrSpecialObject2 != null)
								{
									text += PortFunction.smethod_37(settingOrSpecialObject2);
								}
							}
						}
					}
					else
					{
						(string, string, bool) tuple = setting.method_252();
						text += tuple.Item1;
						if (!string.IsNullOrEmpty(tuple.Item2))
						{
							text = text + Class333.smethod_325() + tuple.Item2;
						}
					}
				}
				if (!string.IsNullOrWhiteSpace(text))
				{
					Label label3 = new Label();
					label3.Text = text;
					label3.ForeColor = Form23.color_12;
					label3.Font = new Font(label3.Font.FontFamily, 10f);
					label3.BackColor = Color.Transparent;
					label3.AutoSize = true;
					label3.Left = 10;
					label3.Top = num5;
					movableResizablePanel.Controls.Add(label3);
					ResumeLayout(performLayout: true);
					SuspendLayout();
					num5 += label3.Height + 5;
				}
			}
			int num7 = 0;
			int num8 = 0;
			foreach (Control control in movableResizablePanel.Controls)
			{
				num7 = Math.Max(num7, control.Left + control.Width + 10);
				num8 = Math.Max(num8, control.Top + control.Height + 10);
			}
			movableResizablePanel.Width = num7;
			movableResizablePanel.Height = num8;
			if (num + num8 + 10 > @class.Height)
			{
				num2 += num3 + 20;
				num = num4;
				num3 = num7;
			}
			else
			{
				num3 = Math.Max(num3, num7);
			}
			movableResizablePanel.Left = num2;
			movableResizablePanel.Top = num;
			@class.method_12().Controls.Add(movableResizablePanel);
			num += num8 + 10;
		}
		Controls.Add(@class);
		ResumeLayout(performLayout: true);
		@class.method_14();
	}

	private void method_6(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate117 method = method_6;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_12();
		foreach (ModifyOnChange item in list_1)
		{
			if (item.method_1() != sender as Setting)
			{
				continue;
			}
			foreach (Setting item2 in item.method_2(bool_0: true))
			{
				Form23.smethod_74(item2.method_64());
			}
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate118 method = method_7;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_12();
	}

	private void method_8(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate119 method = method_8;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_12();
	}

	private void method_9()
	{
		foreach (Control control in Controls)
		{
			if (control.Visible)
			{
				if (control is Class117)
				{
					(control as Class117).method_17();
				}
				else if (control is Class118)
				{
					(control as Class118).method_26();
				}
			}
		}
	}

	private void method_10()
	{
		if (themedButton_1.Enabled)
		{
			themedButton_1.Focus();
			return;
		}
		Control control = null;
		foreach (Control control7 in Controls)
		{
			if (!control7.Visible)
			{
				continue;
			}
			if (control7 is Class117)
			{
				Class117 @class = control7 as Class117;
				if (@class.method_12().Controls.Count == 0)
				{
					continue;
				}
				foreach (Control control8 in @class.method_12().Controls)
				{
					if (!(control8 is Label))
					{
						control = control8;
						break;
					}
				}
				break;
			}
			if (!(control7 is Class118))
			{
				continue;
			}
			Class118 class2 = control7 as Class118;
			int num = int.MaxValue;
			int num2 = int.MaxValue;
			foreach (Control control9 in class2.method_12().Controls)
			{
				if (control9.Visible && control9 is Class117 && (control9 as Class117).method_12().Controls.Count != 0)
				{
					num = Math.Min(num, control9.Left);
					num2 = Math.Min(num2, control9.Top);
				}
			}
			foreach (Control control10 in class2.method_12().Controls)
			{
				if (!control10.Visible || control10.Left != num || control10.Top != num2 || !(control10 is Class117))
				{
					continue;
				}
				Class117 class3 = control10 as Class117;
				if (class3.method_12().Controls.Count == 0)
				{
					continue;
				}
				foreach (Control control11 in class3.method_12().Controls)
				{
					if (!(control11 is Label))
					{
						control = control11;
						break;
					}
				}
				break;
			}
			break;
		}
		if (control != null)
		{
			control.Focus();
		}
		else
		{
			themedButton_1.Focus();
		}
	}

	private List<Control> method_11()
	{
		List<Control> list = new List<Control>();
		foreach (Control control5 in Controls)
		{
			if (!control5.Visible)
			{
				continue;
			}
			if (control5 is Class117)
			{
				foreach (Control control6 in (control5 as Class117).method_12().Controls)
				{
					if (control6.Visible && (control6 is Control6 || control6 is Control5))
					{
						list.Add(control6);
					}
				}
			}
			else
			{
				if (!(control5 is Class118))
				{
					continue;
				}
				foreach (Control control7 in (control5 as Class118).method_12().Controls)
				{
					if (!control7.Visible)
					{
						continue;
					}
					if (control7 is Class117)
					{
						foreach (Control control8 in (control7 as Class117).method_12().Controls)
						{
							if (control8.Visible && (control8 is Control6 || control8 is Control5))
							{
								list.Add(control8);
							}
						}
					}
					else if (control7 is Control6)
					{
						list.Add(control7);
					}
					else if (control7 is Control5)
					{
						list.Add(control7);
					}
				}
			}
		}
		return list;
	}

	private void method_12()
	{
		themedButton_0.Enabled = method_1() < int_0;
		string text = null;
		foreach (DataIdAndAttrId item in hashSet_0)
		{
			Setting setting = framework_0.method_32(item);
			if (setting == null || setting.method_122() || setting.method_124() == IllegalitySeverityLevel.Warning)
			{
				continue;
			}
			string text2 = setting.method_60(Enum96.aYt);
			foreach (string item2 in setting.method_123())
			{
				if (text == null)
				{
					text = string.Empty;
				}
				text = text + Class333.smethod_2566() + text2 + Class333.smethod_1802() + item2;
			}
		}
		bool flag = false;
		foreach (Control item3 in list_0)
		{
			if (item3 is Control6)
			{
				if (string.IsNullOrWhiteSpace((item3 as Control6).method_13()))
				{
					flag = true;
					break;
				}
			}
			else if (item3 is Control5 && string.IsNullOrWhiteSpace((item3 as Control5).method_11()))
			{
				flag = true;
				break;
			}
		}
		if ((text != null) & flag)
		{
			themedButton_1.Tag = Class333.smethod_2567() + text;
			themedButton_1.Enabled = false;
			return;
		}
		if (text != null)
		{
			themedButton_1.Tag = Class333.smethod_2568() + text;
			themedButton_1.Enabled = false;
			return;
		}
		if (flag)
		{
			themedButton_1.Tag = Class333.smethod_2569();
			themedButton_1.Enabled = false;
			return;
		}
		themedButton_1.Tag = null;
		themedButton_1.Enabled = true;
		toolTip_0.Active = false;
		toolTip_0.Hide(this);
		bool_0 = false;
	}

	private void Form48_MouseMove(object sender, MouseEventArgs e)
	{
		if (GetChildAtPoint(e.Location) == themedButton_1 && themedButton_1.Tag != null)
		{
			if (!bool_0)
			{
				bool_0 = true;
				toolTip_0.ShowAlways = true;
				toolTip_0.InitialDelay = 500;
				toolTip_0.ReshowDelay = 500;
				toolTip_0.Active = true;
				toolTip_0.Popup -= toolTip_0_Popup;
				toolTip_0.Popup += toolTip_0_Popup;
				toolTip_0.Show(themedButton_1.Tag as string, this, e.X, e.Y);
			}
		}
		else
		{
			toolTip_0.Active = false;
			toolTip_0.Hide(this);
			bool_0 = false;
		}
	}

	private void toolTip_0_Popup(object sender, PopupEventArgs e)
	{
		if (themedButton_1.Tag != null)
		{
			Size size = TextRenderer.MeasureText(themedButton_1.Tag as string, Font, new Size(250, -1), TextFormatFlags.WordBreak);
			e.ToolTipSize = new Size(size.Width, size.Height + 50);
		}
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return Class30.smethod_4(this, keyData);
	}

	protected override void Dispose(bool disposing)
	{
		themedButton_0.Click -= themedButton_0_Click;
		themedButton_1.Click -= themedButton_1_Click;
		toolTip_0.Popup -= toolTip_0_Popup;
		MouseMove -= Form48_MouseMove;
		Form23.smethod_8(method_0);
		try
		{
			toolTip_0.Dispose();
		}
		catch
		{
		}
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_13()
	{
		SuspendLayout();
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1224, 641);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2570();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2571();
		FormClosing += Form48_FormClosing;
		Shown += Form48_Shown;
		ResumeLayout(performLayout: false);
	}
}
