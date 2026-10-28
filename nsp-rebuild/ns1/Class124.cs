using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns3;
using ns4;
using ns7;

namespace ns1;

internal class Class124 : MovableResizablePanel, Interface3
{
	private delegate void Delegate83(object sender, EventArgs e);

	private const int Bnn = 5;

	private Control24 BnO = new Control24();

	private Dictionary<MenuNode, Class173> Bno = new Dictionary<MenuNode, Class173>();

	private Framework BnP;

	private Framework Bnp;

	private MenuNode BnQ;

	private Rectangle Bnq;

	private int BnR = -1;

	internal Class124(Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0, bool bool_1)
		: base(rectangle_0, bool_0, bool_1, bool_2: false)
	{
		BnP = framework_0;
		Bnp = framework_1;
		Bnq = rectangle_0;
		_ = BnO.Handle;
		BnO.SelectedIndex = -1;
		BnO.Left = 5;
		BnO.Top = 5;
		BnO.SelectedIndexChanged += BnO_SelectedIndexChanged;
		Controls.Add(BnO);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			BnO.SelectedIndexChanged -= BnO_SelectedIndexChanged;
			foreach (Class173 value in Bno.Values)
			{
				Class30.smethod_0(value);
			}
			Bno.Clear();
			if (BnP.awZ == 21)
			{
				for (int i = 0; i < BnP.awP.method_79().Count; i++)
				{
					Class250 @class = BnP.awP.method_79()[i];
					for (int j = 0; j < @class.method_72().Count; j++)
					{
						@class.method_72()[j].method_19()?.method_265(method_22);
					}
				}
			}
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	[SpecialName]
	internal void method_12(MenuNode menuNode_0)
	{
		BnQ = menuNode_0;
	}

	public override string ToString()
	{
		string text = base.ToString();
		if (BnQ != null)
		{
			text = text + Class333.smethod_325() + BnQ.method_10();
		}
		return text + Class333.BcU() + BnO.TabPages.Count + Class333.Bcu();
	}

	private void method_13(List<MenuNode> list_0, List<bool> list_1, List<bool> list_2, MenuNode menuNode_0)
	{
		int num = 0;
		foreach (MenuNode item in menuNode_0.method_6())
		{
			if (!item.method_28())
			{
				if (num == 0 && list_1.Count != 0)
				{
					list_1[list_1.Count - 1] = true;
				}
				if (menuNode_0 == BnQ && num != 0)
				{
					list_2[list_2.Count - 1] = true;
				}
				list_0.Add(item);
				list_1.Add(item: false);
				list_2.Add(item: false);
				num++;
				method_13(list_0, list_1, list_2, item);
			}
		}
	}

	internal int method_14()
	{
		int int_ = 1;
		method_15(ref int_, BnQ.method_6()[0]);
		return int_;
	}

	private void method_15(ref int int_3, MenuNode menuNode_0)
	{
		foreach (MenuNode item in menuNode_0.method_6())
		{
			if (!item.method_28())
			{
				int_3++;
				method_15(ref int_3, item);
			}
		}
	}

	internal void method_16(int int_3)
	{
		if (BnQ.method_31())
		{
			method_18(bool_0: true, int_3);
			if (BnO.TabPages.Count != 0)
			{
				int num = method_14();
				if (BnQ.method_33())
				{
					if (int_3 == 0)
					{
						if (BnO.SelectedIndex != 0)
						{
							BnO.SelectedIndex = 0;
						}
					}
					else if (BnO.TabPages.Count > 1 && BnO.SelectedIndex != 1 + (int_3 - 1) % num)
					{
						BnO.SelectedIndex = 1 + (int_3 - 1) % num;
					}
				}
				else if (BnO.SelectedIndex != int_3 % num)
				{
					BnO.SelectedIndex = int_3 % num;
				}
			}
		}
		else if (BnO.TabPages.Count > int_3 && BnO.SelectedIndex != int_3)
		{
			BnO.SelectedIndex = int_3;
		}
		BnO.Visible = true;
	}

	internal void method_17(int int_3)
	{
		if (BnQ.method_31())
		{
			string text = null;
			if (BnO.SelectedIndex != -1)
			{
				text = BnO.TabPages[BnO.SelectedIndex].Text;
			}
			int num = method_14();
			bool flag = BnQ.method_33();
			if (BnR == int_3 && (!flag || BnO.SelectedIndex != 0))
			{
				return;
			}
			BnR = int_3;
			if (flag)
			{
				method_18(bool_0: true, 1 + int_3 * num);
			}
			else
			{
				method_18(bool_0: true, int_3 * num);
			}
			if (BnO.TabPages.Count != 0)
			{
				int num2 = -1;
				if (!string.IsNullOrEmpty(text))
				{
					for (int i = (flag ? 1 : 0); i < BnO.TabPages.Count; i++)
					{
						if (BnO.TabPages[i].Text == text)
						{
							num2 = i;
							break;
						}
					}
				}
				if (num2 != -1)
				{
					if (BnO.SelectedIndex != num2)
					{
						BnO.SelectedIndex = num2;
					}
				}
				else if (flag && BnO.TabPages.Count > 1)
				{
					if (BnO.SelectedIndex != 1)
					{
						BnO.SelectedIndex = 1;
					}
				}
				else if (BnO.SelectedIndex != 0)
				{
					BnO.SelectedIndex = 0;
				}
			}
		}
		BnO.Visible = true;
	}

	internal void method_18(bool bool_0, int int_3 = 0)
	{
		if (bool_0)
		{
			BnO.Visible = false;
		}
		SuspendLayout();
		BnO.SuspendLayout();
		bool flag = BnQ.method_31();
		if (!bool_0)
		{
			method_20();
		}
		else
		{
			BnO.SelectedIndex = -1;
			List<MenuNode> list = new List<MenuNode>();
			List<bool> list2 = new List<bool>();
			List<bool> list3 = new List<bool>();
			if (flag)
			{
				if (BnQ.method_33())
				{
					list.Add(BnQ.method_5());
					list2.Add(item: true);
					list3.Add(item: false);
				}
				method_13(list, list2, list3, BnQ);
				list2[list2.Count - 1] = false;
				list3[list3.Count - 1] = false;
			}
			else
			{
				foreach (MenuNode item in BnQ.method_6())
				{
					list.Add(item);
				}
			}
			bool flag2 = false;
			int num = 0;
			if (flag)
			{
				flag2 = BnQ.method_33();
				int i = int_3;
				if (i != 0 || !flag2)
				{
					for (; i != list3.Count && !list3[i]; i++)
					{
						num++;
					}
				}
			}
			foreach (MenuNode item2 in list)
			{
				bool flag3 = false;
				if (flag)
				{
					int num2 = list.IndexOf(item2);
					if (flag2)
					{
						if (int_3 == 0)
						{
							if (num2 != 0)
							{
								flag3 = true;
							}
						}
						else if (num2 != 0 && (num2 < int_3 || num2 > int_3 + num))
						{
							flag3 = true;
						}
					}
					else if (num2 < int_3 || num2 > int_3 + num)
					{
						flag3 = true;
					}
				}
				if (!flag3)
				{
					flag3 = item2.method_101(bool_0: false);
				}
				if (flag3)
				{
					for (int j = 0; j < BnO.TabPages.Count; j++)
					{
						Class173 @class = (Class173)BnO.TabPages[j];
						if (((Struct19)@class.Tag).menuNode_0 == item2)
						{
							BnO.SelectedIndexChanged -= BnO_SelectedIndexChanged;
							if (BnO.SelectedIndex == j)
							{
								BnO.SelectedIndex = -1;
							}
							bool flag4 = BnO.SelectedIndex == -1;
							BnO.TabPages.Remove(@class);
							if (flag4 && BnO.SelectedIndex != -1)
							{
								BnO.SelectedIndex = -1;
							}
							BnO.SelectedIndexChanged += BnO_SelectedIndexChanged;
							break;
						}
					}
					continue;
				}
				Class173 class2;
				if (!Bno.ContainsKey(item2))
				{
					class2 = new Class173(method_21(item2, out var setting_));
					class2.Tag = new Struct19(item2, setting_);
					class2.SuspendLayout();
					class2.method_1(list2.Count == list.Count && list2[list.IndexOf(item2)]);
					class2.method_3(list3.Count == list.Count && list3[list.IndexOf(item2)]);
					class2.AutoScroll = false;
					class2.BorderStyle = BorderStyle.None;
					class2.BackColor = Form23.color_11;
					Class131 value = new Class131();
					class2.Controls.Add(value);
					class2.ResumeLayout(performLayout: true);
					Bno.Add(item2, class2);
				}
				else
				{
					class2 = Bno[item2];
				}
				if (!BnO.TabPages.Contains(class2))
				{
					bool flag5 = BnO.SelectedIndex == -1;
					BnO.SelectedIndexChanged -= BnO_SelectedIndexChanged;
					BnO.TabPages.Add(class2);
					if (flag5 && BnO.SelectedIndex != -1)
					{
						BnO.SelectedIndex = -1;
					}
					BnO.SelectedIndexChanged += BnO_SelectedIndexChanged;
				}
			}
			if (Bnq != Rectangle.Empty)
			{
				Width = Bnq.Width;
				Height = Bnq.Height;
				Left = Bnq.Left;
				Top = Bnq.Top;
			}
		}
		BnO.ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
		if (bool_0)
		{
			if (!flag)
			{
				BnO.Visible = true;
			}
			if (BnO.SelectedIndex == -1 && BnO.TabPages.Count != 0 && int_3 == 0)
			{
				BnO.SelectedIndex = 0;
			}
			BnO.SizeMode = TabSizeMode.Fixed;
			BnO.SizeMode = TabSizeMode.Normal;
		}
	}

	private void method_19(bool bool_0, MenuNode menuNode_0, Class131 class131_0, SettingOrSpecialObject settingOrSpecialObject_0, SettingOrSpecialObject settingOrSpecialObject_1)
	{
		if (settingOrSpecialObject_0 is Table)
		{
			return;
		}
		if (settingOrSpecialObject_0 is SpecialObject && (settingOrSpecialObject_0 as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count != 0)
		{
			if (!bool_0)
			{
				foreach (Control control4 in class131_0.Controls)
				{
					if (control4 is Class117 && control4.Tag == menuNode_0)
					{
						(control4 as Class117).method_15(bool_0: false);
						break;
					}
				}
				return;
			}
			string string_ = string.Empty;
			if (menuNode_0.method_50())
			{
				string_ = menuNode_0.method_10();
			}
			Class117 @class = new Class117(settingOrSpecialObject_0 as SpecialObject, string_, menuNode_0, BnP, Bnp, Rectangle.Empty, bool_0: false, bool_1: true);
			@class.Tag = menuNode_0;
			@class.Left = 5;
			@class.Top = 5;
			class131_0.Controls.Add(@class);
			@class.method_15(bool_0: true);
		}
		else
		{
			if (settingOrSpecialObject_1 != null)
			{
				return;
			}
			if (settingOrSpecialObject_0 == null)
			{
				foreach (MenuNode item in menuNode_0.method_6())
				{
					if (item.method_28())
					{
						if (bool_0)
						{
							Class118 class2 = new Class118(BnP, Bnp, Rectangle.Empty, bool_0: false, bool_1: true, bool_2: true);
							class2.method_15(menuNode_0);
							class2.Tag = menuNode_0;
							class2.Left = 5;
							class2.Top = 0;
							class131_0.Controls.Add(class2);
							class2.method_21(bool_0: true);
							break;
						}
						{
							foreach (Control control5 in class131_0.Controls)
							{
								if (control5 is Class118 && control5.Tag == menuNode_0)
								{
									(control5 as Class118).method_21(bool_0: false);
									break;
								}
							}
							break;
						}
					}
				}
				return;
			}
			if (settingOrSpecialObject_0 is SpecialObject)
			{
				if (settingOrSpecialObject_0 is OnOffSwitchingPoint || settingOrSpecialObject_0 is StateMachine || settingOrSpecialObject_0 is WiFiSetup || settingOrSpecialObject_0 is BezierCurve || (settingOrSpecialObject_0 as SpecialObject).method_68().IdleText != null || (settingOrSpecialObject_0 as SpecialObject).method_68().PreApplySettingDataIds.Count != 0 || settingOrSpecialObject_0 is KnockDetection || settingOrSpecialObject_0.method_13().DataIdOfChannelListSetting != 0)
				{
					return;
				}
				if (!bool_0)
				{
					foreach (Control control6 in class131_0.Controls)
					{
						if (control6 is Class117 && control6.Tag == menuNode_0)
						{
							(control6 as Class117).method_15(bool_0: false);
							break;
						}
					}
					return;
				}
				string string_2 = string.Empty;
				if (menuNode_0.method_50())
				{
					string_2 = menuNode_0.method_10();
				}
				Class117 class3 = new Class117(settingOrSpecialObject_0 as SpecialObject, string_2, menuNode_0, BnP, Bnp, Rectangle.Empty, bool_0: false, bool_1: true);
				class3.Tag = menuNode_0;
				class3.Left = 5;
				class3.Top = 5;
				class131_0.Controls.Add(class3);
				class3.method_15(bool_0: true);
			}
			else if (settingOrSpecialObject_0 is SensorCalibration)
			{
				_ = (settingOrSpecialObject_0 as SensorCalibration).CalibrationValuesSetting;
			}
		}
	}

	private void BnO_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_20();
	}

	private void method_20()
	{
		if (BnO.SelectedIndex == -1 || Form23.bool_17)
		{
			return;
		}
		if (BnO.SelectedIndex == 0 && BnQ.method_31() && BnQ.method_33())
		{
			BnO.SelectedIndexChanged -= BnO_SelectedIndexChanged;
			while (BnO.TabPages.Count > 1)
			{
				BnO.TabPages.RemoveAt(1);
			}
			BnO.SelectedIndex = 0;
			BnO.SelectedIndexChanged += BnO_SelectedIndexChanged;
		}
		Class173 @class = BnO.TabPages[BnO.SelectedIndex] as Class173;
		MenuNode menuNode_ = ((Struct19)@class.Tag).menuNode_0;
		int num = menuNode_.method_3();
		int num2 = menuNode_.method_20();
		SettingOrSpecialObject settingOrSpecialObject_ = BnP.method_33(num);
		SettingOrSpecialObject settingOrSpecialObject_2 = BnP.method_33(num2);
		Class131 class2 = null;
		foreach (Control control5 in @class.Controls)
		{
			if (control5 is Class131)
			{
				class2 = control5 as Class131;
				break;
			}
		}
		if (class2 == null)
		{
			return;
		}
		bool flag;
		if (flag = class2.Controls.Count == 0)
		{
			BnO.Visible = false;
		}
		SuspendLayout();
		BnO.SuspendLayout();
		@class.SuspendLayout();
		method_19(flag, menuNode_, class2, settingOrSpecialObject_, settingOrSpecialObject_2);
		if (flag)
		{
			if (Bnq == Rectangle.Empty)
			{
				int num3 = 0;
				int num4 = 0;
				foreach (Class173 tabPage in BnO.TabPages)
				{
					foreach (Control control6 in tabPage.Controls)
					{
						if (!(control6 is Class131))
						{
							continue;
						}
						foreach (Control control7 in (control6 as Class131).Controls)
						{
							num3 = Math.Max(num3, control7.Right + 10);
							num4 = Math.Max(num4, control7.Bottom + 10);
						}
						break;
					}
				}
				Width = 5 + num3 + 5;
				Height = 35 + num4 + 5;
			}
			BnO.Width = Width - 10;
			BnO.Height = Height - 10;
			foreach (Class173 tabPage2 in BnO.TabPages)
			{
				tabPage2.SuspendLayout();
				tabPage2.Width = BnO.Width;
				tabPage2.Height = BnO.Height;
				foreach (Control control8 in tabPage2.Controls)
				{
					if (control8 is Class131)
					{
						Class131 obj = control8 as Class131;
						obj.SuspendLayout();
						obj.Width = tabPage2.Width;
						obj.Height = tabPage2.Height;
						obj.ResumeLayout(performLayout: true);
						break;
					}
				}
				tabPage2.ResumeLayout(performLayout: true);
			}
		}
		@class.ResumeLayout(performLayout: true);
		BnO.ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
		if (flag)
		{
			BnO.Visible = true;
		}
	}

	private string method_21(MenuNode menuNode_0, out Setting setting_0)
	{
		string result = menuNode_0.method_10();
		setting_0 = null;
		if (menuNode_0.method_38())
		{
			int index = menuNode_0.method_5().method_5().method_39();
			int index2 = menuNode_0.method_41();
			Class243 @class = BnP.awP.method_79()[index].method_72()[index2];
			string text = @class.method_18();
			if (!string.IsNullOrWhiteSpace(text))
			{
				string text2 = @class.method_286();
				result = (string.IsNullOrEmpty(text2) ? text : (text + Class333.smethod_497() + text2 + Class333.smethod_9()));
			}
			setting_0 = @class.method_19();
			if (setting_0 != null)
			{
				setting_0.method_265(method_22);
				setting_0.method_264(method_22);
			}
		}
		return result;
	}

	private void method_22(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate83 method = method_22;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (!(sender is Setting setting))
		{
			return;
		}
		foreach (Class173 value in Bno.Values)
		{
			Struct19 @struct = (Struct19)value.Tag;
			Setting setting_ = @struct.setting_0;
			if (setting_ == setting)
			{
				MenuNode menuNode_ = @struct.menuNode_0;
				string text = method_21(menuNode_, out var setting_2);
				if (setting_2 == setting_)
				{
					value.Text = text;
					break;
				}
			}
		}
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		SuspendLayout();
		BnO.SuspendLayout();
		BnO.Width = Width - 10;
		BnO.Height = Height - 10;
		foreach (Class173 tabPage in BnO.TabPages)
		{
			tabPage.SuspendLayout();
			tabPage.Width = BnO.Width;
			tabPage.Height = BnO.Height;
			foreach (Control control in tabPage.Controls)
			{
				if (control is Class131)
				{
					Class131 obj = control as Class131;
					obj.SuspendLayout();
					obj.Width = tabPage.Width;
					obj.Height = tabPage.Height;
					obj.ResumeLayout(performLayout: true);
					break;
				}
			}
			tabPage.ResumeLayout(performLayout: true);
		}
		BnO.ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
	}

	public Control imethod_0(DataIdAndAttrId dataIdAndAttrId_0)
	{
		if (BnO.SelectedIndex != -1 && BnO.SelectedIndex < BnO.TabPages.Count && BnO.TabPages[BnO.SelectedIndex] is Class173 @class)
		{
			foreach (Control control4 in @class.Controls)
			{
				if (!(control4 is Class131))
				{
					continue;
				}
				foreach (Control control5 in (control4 as Class131).Controls)
				{
					if (control5 is Interface3)
					{
						Control control3 = (control5 as Interface3).imethod_0(dataIdAndAttrId_0);
						if (control3 != null)
						{
							return control3;
						}
					}
				}
				break;
			}
		}
		return null;
	}

	public Control imethod_1()
	{
		if (BnO.SelectedIndex != -1 && BnO.SelectedIndex < BnO.TabPages.Count && BnO.TabPages[BnO.SelectedIndex] is Class173 @class)
		{
			foreach (Control control4 in @class.Controls)
			{
				if (!(control4 is Class131))
				{
					continue;
				}
				foreach (Control control5 in (control4 as Class131).Controls)
				{
					if (control5 is Interface3)
					{
						Control control3 = (control5 as Interface3).imethod_1();
						if (control3 != null)
						{
							return control3;
						}
					}
				}
				break;
			}
		}
		return null;
	}
}
