using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns1;
using ns2;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns3;

internal class Class118 : Class109, Interface3
{
	private delegate void Delegate82(object sender, EventArgs e);

	private const int BXG = 5;

	private const int BXg = 2;

	private const int BXH = 5;

	private Framework BXh;

	private Framework BXI;

	private MenuNode BXi;

	private Setting BXJ;

	private Setting BXj;

	private Class148 BXK;

	private PictureBox BXk;

	private ThemedButton BXL;

	private ThemedButton BXl;

	private Label BXM;

	private ThemedButton BXm;

	private bool BXN;

	private float BXn = 1f;

	private Rectangle BXO;

	internal bool BXo = true;

	internal Class118(Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0, bool bool_1, bool bool_2, float float_0 = 1f)
		: base(rectangle_0, bool_0, bool_1)
	{
		BXh = framework_0;
		BXI = framework_1;
		BXO = rectangle_0;
		BXN = bool_2;
		BXn = float_0;
		ContextMenuStrip = method_44();
		Form23.form23_0.method_9(method_17);
	}

	[SpecialName]
	internal void method_15(MenuNode menuNode_0)
	{
		BXi = menuNode_0;
		if (BXi != null && BXi.method_22() != 0 && (Form23.class286_0 == null || Form23.list_0.Contains(BXi.method_22())))
		{
			BXJ = BXh.method_31(BXi.method_22());
			if (BXI != null)
			{
				BXj = BXI.method_31(BXi.method_22());
			}
		}
	}

	public override string ToString()
	{
		string text = base.ToString();
		if (BXi != null)
		{
			text = text + Class333.smethod_325() + BXi.method_10();
		}
		return text + Class333.smethod_325() + method_12().Controls.Count + Class333.Bgm();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			method_16();
			if (BXL != null)
			{
				BXL.Click -= BXL_Click;
			}
			if (BXl != null)
			{
				BXl.Click -= BXl_Click;
			}
			if (BXm != null)
			{
				BXm.Click -= BXm_Click;
			}
			if (BXi != null)
			{
				BXh.method_31(BXi.method_73())?.method_41(method_23);
			}
			foreach (Control control in method_12().Controls)
			{
				if (control is Class112 || control is Class117)
				{
					control.VisibleChanged -= method_24;
					control.Layout -= method_25;
				}
				if (control is LinkLabel)
				{
					control.Click -= method_29;
				}
			}
			if (ContextMenuStrip != null)
			{
				ContextMenuStrip.Opening -= method_43;
				foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
				{
					item.Click -= method_42;
				}
			}
			Form23.form23_0.method_10(method_17);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void method_16()
	{
		if (BXJ != null)
		{
			if (BXK != null)
			{
				BXK.CheckedChanged -= BXK_CheckedChanged;
			}
			BXJ.method_265(method_18);
		}
		if (BXk != null)
		{
			BXk.Click -= BXk_Click;
		}
	}

	private void method_17(object sender, EventArgs e)
	{
		method_19();
	}

	private void BXK_CheckedChanged(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BXh.method_4())
		{
			return;
		}
		Class148 @class = sender as Class148;
		Setting setting = BXh.method_31((int)@class.Tag);
		if (!Form23.bool_2)
		{
			SettingOrSpecialObject settingOrSpecialObject = setting.method_6();
			if (@class.Checked)
			{
				Setting setting_ = null;
				MenuNode menuNode = null;
				string text = setting.method_47();
				if (text == null)
				{
					if (BXi.method_64() != null)
					{
						menuNode = BXi;
						text = menuNode.method_64();
					}
					else if (settingOrSpecialObject.method_45() != null)
					{
						text = settingOrSpecialObject.method_45().method_64();
						if (text != null)
						{
							menuNode = settingOrSpecialObject.method_45();
						}
					}
				}
				else
				{
					setting_ = setting;
				}
				Class280 class2 = Form23.smethod_95();
				if (text != null && !Form13.smethod_0(setting_, menuNode))
				{
					Form13 form = new Form13(text, setting_, menuNode);
					if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
					{
						class2?.method_2(setting.method_64());
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
						@class.Checked = false;
					}
					form.Dispose();
				}
				else
				{
					class2?.method_2(setting.method_64());
					if (setting.method_64() == 10195 && setting.method_102().Count == 3)
					{
						setting.method_272(2, bool_0: true);
					}
					else
					{
						setting.method_272(1, bool_0: true);
					}
				}
				if (@class.Checked)
				{
					PortFunction.smethod_20(settingOrSpecialObject, bool_0: false);
					class2?.method_4();
				}
			}
			else
			{
				Class280 class3 = Form23.smethod_95();
				class3?.method_2(setting.method_64());
				setting.method_272(0, bool_0: true);
				if (BXk != null)
				{
					BXk.Visible = false;
				}
				class3?.method_4();
			}
		}
		Form23.smethod_74(setting.method_64());
	}

	private void method_18(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate82 method = method_18;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.enum60_0 == Form23.Enum60.BpG || BXJ.method_219())
		{
			return;
		}
		if (BXJ.method_64() == 10195)
		{
			if (BXK.Checked != (BXJ.method_256() != 0))
			{
				BXK.Checked = BXJ.method_256() != 0;
			}
		}
		else if (BXK.Checked != (BXJ.method_256() == 1))
		{
			BXK.Checked = BXJ.method_256() == 1;
		}
	}

	private void BXk_Click(object sender, EventArgs e)
	{
		PictureBox pictureBox = sender as PictureBox;
		Form23.smethod_50(BXh.method_31((int)pictureBox.Tag), pictureBox);
	}

	private void method_19()
	{
		if (BXJ == null || BXK == null)
		{
			return;
		}
		string text = ((!(Parent is Class118)) ? BXi.method_100(bool_0: false, bool_1: false) : BXi.method_10());
		if (Form23.enum60_0 == Form23.Enum60.BpG && BXj != null)
		{
			BXK.bool_0 = true;
			BXK.Enabled = false;
			if (BXj.method_64() == 10195)
			{
				if (BXK.Checked != (BXj.method_256() != 0))
				{
					BXK.Checked = !BXK.Checked;
				}
			}
			else if (BXK.Checked != (BXj.method_256() == 1))
			{
				BXK.Checked = !BXK.Checked;
			}
			if (method_27())
			{
				BXK.Text = Class333.BGx() + text + Class333.BGY();
			}
			else
			{
				BXK.Text = text;
			}
			return;
		}
		if (method_27())
		{
			BXK.bool_0 = true;
			BXK.Enabled = false;
			if (BXJ.method_64() == 10195)
			{
				if (BXK.Checked != (BXJ.method_256() != 0))
				{
					BXK.Checked = !BXK.Checked;
				}
			}
			else if (BXK.Checked != (BXJ.method_256() == 1))
			{
				BXK.Checked = !BXK.Checked;
			}
			BXK.Text = Class333.BGx() + text + Class333.BGY();
			return;
		}
		BXK.bool_0 = false;
		BXK.Enabled = BXh.method_4();
		if (BXJ.method_64() == 10195)
		{
			if (BXK.Checked != (BXJ.method_256() != 0))
			{
				BXK.Checked = !BXK.Checked;
			}
		}
		else if (BXK.Checked != (BXJ.method_256() == 1))
		{
			BXK.Checked = !BXK.Checked;
		}
		BXK.Text = text;
	}

	private void method_20()
	{
		if (BXk == null)
		{
			return;
		}
		if (BXJ.method_35() && !BXJ.method_122())
		{
			switch (BXJ.method_124())
			{
			default:
				BXk.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Error:
				BXk.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Warning:
				BXk.Image = GeneralResources.YellowWarning;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (Form23.smethod_28(BXh.aXc, bool_53: true))
				{
					BXk.Image = GeneralResources.RedError;
				}
				else
				{
					BXk.Image = GeneralResources.YellowWarning;
				}
				break;
			}
			BXk.Visible = true;
		}
		else
		{
			BXk.Visible = false;
			BXk.Image = GeneralResources.QuestionMark;
		}
	}

	internal void method_21(bool bool_0)
	{
		SuspendLayout();
		method_12().SuspendLayout();
		int int_ = 2;
		if (!BXN || !BXi.method_37())
		{
			method_30(bool_0, ref int_);
			if (Form23.class286_0 == null || Form23.menuNode_2 == BXi || Form23.list_0.Contains(BXi.method_73()))
			{
				if (BXi.method_79() && !BXi.method_86())
				{
					Setting setting = BXh.method_31(BXi.method_73());
					if (setting != null)
					{
						if (Class286.smethod_7(setting) && !Class286.smethod_5(setting))
						{
							if (BXi.method_75())
							{
								method_31(bool_0, ref int_);
							}
							else if (BXi.method_77())
							{
								method_32(bool_0, ref int_);
							}
							else
							{
								method_33(bool_0, ref int_, setting);
							}
						}
						setting.method_40(method_23);
					}
				}
				if (BXi.method_80() != null && BXi.method_92() && !BXi.method_75() && !BXi.method_77())
				{
					method_28(bool_0, ref int_);
				}
			}
		}
		int num = -1;
		int num2 = -1;
		Rectangle rectangle_ = Rectangle.Empty;
		List<List<Rectangle>> list = new List<List<Rectangle>>();
		List<int> list2 = new List<int>();
		foreach (MenuNode item in method_36())
		{
			if (!item.method_28() || method_22(item))
			{
				continue;
			}
			int num3 = item.method_24();
			int num4 = item.method_26();
			bool flag = method_37();
			if (item.method_35() != flag)
			{
				continue;
			}
			int num5 = item.method_3();
			int num6 = item.method_20();
			SettingOrSpecialObject settingOrSpecialObject = BXh.method_33(num5);
			SettingOrSpecialObject settingOrSpecialObject2 = BXh.method_33(num6);
			if (settingOrSpecialObject is Table)
			{
				continue;
			}
			int int_2 = 5;
			int int_3 = int_;
			method_38(num3, num4, num, num2, rectangle_, list, list2, ref int_2, ref int_3);
			if (BXh.awR != null && BXh.awr != null && BXh.awr != BXh.awR && item == BXh.awr)
			{
				string text = Class333.BgR() + item.method_12();
				Class89 @class = null;
				if (bool_0)
				{
					@class = new Class89(BXh, Rectangle.Empty, bool_0: false);
					@class.Name = text;
				}
				else if (method_12().Controls.ContainsKey(text))
				{
					@class = method_12().Controls[text] as Class89;
				}
				if (@class != null)
				{
					@class.Left = int_2 + method_12().AutoScrollPosition.X;
					@class.Top = int_3 + method_12().AutoScrollPosition.Y;
					if (bool_0)
					{
						method_12().Controls.Add(@class);
					}
					@class.method_14(bool_0);
					rectangle_ = new Rectangle(int_2, int_3, @class.Size.Width, @class.Size.Height);
				}
				method_12().method_1(bool_1: false);
			}
			else if (BXi.method_37() && item.method_10() == Class333.Bgr())
			{
				Class108 class2 = null;
				Class88 class3 = null;
				if (bool_0)
				{
					class3 = new Class88(Form23.framework_1.awP.method_79()[BXi.method_39()], Form23.framework_1, Rectangle.Empty, bool_0: false, class2);
					class3.Name = Class333.BgS();
					class3.Left = int_2;
					class3.Top = int_3;
					method_12().method_1(bool_1: false);
					method_12().Controls.Add(class3);
				}
				else
				{
					if (method_12().Controls.ContainsKey(Class333.Bgc()))
					{
						class2 = method_12().Controls[Class333.Bgc()] as Class108;
					}
					if (method_12().Controls.ContainsKey(Class333.BgS()))
					{
						class3 = method_12().Controls[Class333.BgS()] as Class88;
					}
					if (class2 != null)
					{
						class2.Left = int_2 + method_12().AutoScrollPosition.X;
						class2.Top = int_3 + method_12().AutoScrollPosition.Y;
						int_3 += class2.Height + 5;
					}
					if (class3 != null)
					{
						class3.Left = int_2 + method_12().AutoScrollPosition.X;
						class3.Top = int_3 + method_12().AutoScrollPosition.Y;
					}
				}
				if (class3 != null)
				{
					rectangle_ = ((class2 == null) ? new Rectangle(int_2, int_3, class3.Width, class3.Height) : new Rectangle(int_2, int_3 - (class2.Height + 5), Math.Max(class3.Width, class2.Width), class2.Height + 5 + class3.Height));
				}
			}
			else if (!string.IsNullOrEmpty(item.method_8()))
			{
				if (BXh.awn.ContainsKey(item.method_8()))
				{
					string text2 = Class333.Bgs() + item.method_12();
					Class112 class4 = null;
					if (bool_0)
					{
						class4 = new Class112(BXh.awn[item.method_8()], BXh, Rectangle.Empty, bool_0: false, bool_1: true, BXn);
						class4.Name = text2;
					}
					else if (method_12().Controls.ContainsKey(text2))
					{
						class4 = method_12().Controls[text2] as Class112;
					}
					if (class4 != null)
					{
						class4.VisibleChanged -= method_24;
						class4.Layout -= method_25;
						class4.Left = int_2 + method_12().AutoScrollPosition.X;
						class4.Top = int_3 + method_12().AutoScrollPosition.Y;
						if (bool_0)
						{
							method_12().Controls.Add(class4);
						}
						class4.method_16(bool_0);
						class4.VisibleChanged += method_24;
						class4.Layout += method_25;
						rectangle_ = new Rectangle(int_2, int_3, class4.Size.Width, class4.Size.Height);
					}
				}
			}
			else if (settingOrSpecialObject is SpecialObject && (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count != 0)
			{
				string text3 = Class333.BgT() + item.method_12();
				Class117 class5 = null;
				if (bool_0)
				{
					string string_ = string.Empty;
					if (item.method_50())
					{
						string_ = item.method_10();
					}
					class5 = new Class117(settingOrSpecialObject as SpecialObject, string_, item, BXh, BXI, Rectangle.Empty, bool_0: false, bool_1: true, BXn);
					class5.Name = text3;
				}
				else if (method_12().Controls.ContainsKey(text3))
				{
					class5 = method_12().Controls[text3] as Class117;
				}
				if (class5 != null)
				{
					class5.VisibleChanged -= method_24;
					class5.Layout -= method_25;
					class5.Left = int_2 + method_12().AutoScrollPosition.X;
					class5.Top = int_3 + method_12().AutoScrollPosition.Y;
					if (bool_0)
					{
						method_12().Controls.Add(class5);
					}
					class5.method_15(bool_0);
					class5.VisibleChanged += method_24;
					class5.Layout += method_25;
					rectangle_ = new Rectangle(int_2, int_3, class5.Size.Width, class5.Size.Height);
				}
			}
			else if (settingOrSpecialObject2 != null)
			{
				string text4 = Class333.Bgt() + item.method_12();
				Class115 class6 = null;
				if (bool_0)
				{
					class6 = new Class115(settingOrSpecialObject2, item, BXh, BXI, Rectangle.Empty, bool_0: false);
					class6.Name = text4;
				}
				else if (method_12().Controls.ContainsKey(text4))
				{
					class6 = method_12().Controls[text4] as Class115;
				}
				if (class6 != null)
				{
					class6.Left = int_2 + method_12().AutoScrollPosition.X;
					class6.Top = int_3 + method_12().AutoScrollPosition.Y;
					if (bool_0)
					{
						method_12().Controls.Add(class6);
					}
					class6.method_23(bool_0);
					rectangle_ = new Rectangle(int_2, int_3, class6.Size.Width, class6.Size.Height);
				}
			}
			else if (settingOrSpecialObject != null)
			{
				if (settingOrSpecialObject is SpecialObject)
				{
					if (settingOrSpecialObject is OnOffSwitchingPoint)
					{
						string text5 = Class333.BgU() + item.method_12();
						Class114 class7 = null;
						if (bool_0)
						{
							class7 = new Class114(settingOrSpecialObject as OnOffSwitchingPoint, BXh, BXI, Rectangle.Empty, bool_0: false);
							class7.Name = text5;
						}
						else if (method_12().Controls.ContainsKey(text5))
						{
							class7 = method_12().Controls[text5] as Class114;
						}
						if (class7 != null)
						{
							class7.Left = int_2 + method_12().AutoScrollPosition.X;
							class7.Top = int_3 + method_12().AutoScrollPosition.Y;
							if (bool_0)
							{
								method_12().Controls.Add(class7);
								class7.method_17();
							}
							rectangle_ = new Rectangle(int_2, int_3, class7.Size.Width, class7.Size.Height);
						}
					}
					else if (settingOrSpecialObject is StateMachine)
					{
						string text6 = Class333.Bgu() + item.method_12();
						Class116 class8 = null;
						if (bool_0)
						{
							class8 = new Class116(settingOrSpecialObject as StateMachine, BXh, BXI, Rectangle.Empty, bool_0: false);
							class8.Name = text6;
						}
						else if (method_12().Controls.ContainsKey(text6))
						{
							class8 = method_12().Controls[text6] as Class116;
						}
						if (class8 != null)
						{
							class8.Left = int_2 + method_12().AutoScrollPosition.X;
							class8.Top = int_3 + method_12().AutoScrollPosition.Y;
							if (bool_0)
							{
								method_12().Controls.Add(class8);
								class8.method_17();
							}
							rectangle_ = new Rectangle(int_2, int_3, class8.Size.Width, class8.Size.Height);
						}
					}
					else if (settingOrSpecialObject is WiFiSetup)
					{
						string text7 = Class333.BgV() + item.method_12();
						Class122 class9 = null;
						if (bool_0)
						{
							class9 = new Class122(BXh, Rectangle.Empty, bool_0: false);
							class9.Name = text7;
						}
						else if (method_12().Controls.ContainsKey(text7))
						{
							class9 = method_12().Controls[text7] as Class122;
						}
						if (class9 != null)
						{
							class9.Left = int_2 + method_12().AutoScrollPosition.X;
							class9.Top = int_3 + method_12().AutoScrollPosition.Y;
							if (bool_0)
							{
								method_12().Controls.Add(class9);
								class9.method_20();
							}
							rectangle_ = new Rectangle(int_2, int_3, class9.Size.Width, class9.Size.Height);
						}
					}
					else if (settingOrSpecialObject is BezierCurve)
					{
						string text8 = Class333.Bgv() + item.method_12();
						Class87 class10 = null;
						if (bool_0)
						{
							class10 = new Class87(settingOrSpecialObject as BezierCurve, BXh, BXI, Rectangle.Empty, bool_0: false);
							class10.Name = text8;
						}
						else if (method_12().Controls.ContainsKey(text8))
						{
							class10 = method_12().Controls[text8] as Class87;
						}
						if (class10 != null)
						{
							class10.Left = int_2 + method_12().AutoScrollPosition.X;
							class10.Top = int_3 + method_12().AutoScrollPosition.Y;
							if (bool_0)
							{
								method_12().Controls.Add(class10);
								class10.Invalidate();
							}
							rectangle_ = new Rectangle(int_2, int_3, class10.Size.Width, class10.Size.Height);
						}
					}
					else if ((settingOrSpecialObject as SpecialObject).method_68().IdleText == null && (settingOrSpecialObject as SpecialObject).method_68().PreApplySettingDataIds.Count == 0)
					{
						if (settingOrSpecialObject is KnockDetection)
						{
							string text9 = Class333.Bgw() + item.method_12();
							Class107 class11 = null;
							if (bool_0)
							{
								class11 = new Class107(settingOrSpecialObject as KnockDetection, BXh, Rectangle.Empty, bool_0: false);
								class11.Name = text9;
							}
							else if (method_12().Controls.ContainsKey(text9))
							{
								class11 = method_12().Controls[text9] as Class107;
							}
							if (class11 != null)
							{
								class11.Left = int_2 + method_12().AutoScrollPosition.X;
								class11.Top = int_3 + method_12().AutoScrollPosition.Y;
								if (bool_0)
								{
									method_12().Controls.Add(class11);
									class11.Invalidate();
								}
								rectangle_ = new Rectangle(int_2, int_3, class11.Size.Width, class11.Size.Height);
							}
						}
						else if (settingOrSpecialObject.method_13().DataIdOfChannelListSetting != 0)
						{
							if (settingOrSpecialObject.method_13().HasGroups())
							{
								string text10 = Class333.BgX() + item.method_12();
								Class120 class12 = null;
								if (bool_0)
								{
									class12 = new Class120(settingOrSpecialObject.method_13(), BXh, BXI, Rectangle.Empty, bool_0: false);
									class12.Name = text10;
								}
								else if (method_12().Controls.ContainsKey(text10))
								{
									class12 = method_12().Controls[text10] as Class120;
								}
								if (class12 != null)
								{
									class12.Left = int_2 + method_12().AutoScrollPosition.X;
									class12.Top = int_3 + method_12().AutoScrollPosition.Y;
									if (bool_0)
									{
										method_12().Controls.Add(class12);
										class12.method_16();
									}
									rectangle_ = new Rectangle(int_2, int_3, class12.Size.Width, class12.Size.Height);
								}
							}
							else
							{
								string text11 = Class333.Bgx() + item.method_12();
								Class119 class13 = null;
								if (bool_0)
								{
									class13 = new Class119(settingOrSpecialObject.method_13(), BXh, BXI, Rectangle.Empty, bool_0: false);
									class13.Name = text11;
								}
								else if (method_12().Controls.ContainsKey(text11))
								{
									class13 = method_12().Controls[text11] as Class119;
								}
								if (class13 != null)
								{
									class13.Left = int_2 + method_12().AutoScrollPosition.X;
									class13.Top = int_3 + method_12().AutoScrollPosition.Y;
									if (bool_0)
									{
										method_12().Controls.Add(class13);
										class13.method_16();
									}
									rectangle_ = new Rectangle(int_2, int_3, class13.Size.Width, class13.Size.Height);
								}
							}
						}
						else if (settingOrSpecialObject.method_26().method_4().Count != 0)
						{
							if (Form23.class286_0 == null && !settingOrSpecialObject.method_26().method_5())
							{
								string text12 = Class333.BgY() + item.method_12();
								Control22 control = null;
								if (bool_0)
								{
									control = new Control22(settingOrSpecialObject, settingOrSpecialObject.method_26(), BXh);
									control.Name = text12;
								}
								else if (method_12().Controls.ContainsKey(text12))
								{
									control = method_12().Controls[text12] as Control22;
								}
								if (control != null)
								{
									control.Left = int_2 + method_12().AutoScrollPosition.X;
									control.Top = int_3 + method_12().AutoScrollPosition.Y;
									if (bool_0)
									{
										method_12().Controls.Add(control);
									}
									rectangle_ = new Rectangle(int_2, int_3, control.Size.Width, control.Size.Height);
								}
							}
						}
						else
						{
							bool flag2 = false;
							foreach (InitialTaskObject item2 in settingOrSpecialObject.method_24())
							{
								if (item2.method_6() == Enum100.azQ)
								{
									flag2 = true;
									break;
								}
							}
							if (flag2)
							{
								bool flag3 = false;
								foreach (InitialTaskObject item3 in settingOrSpecialObject.method_24())
								{
									if (item3.method_14())
									{
										flag3 = true;
										break;
									}
								}
								if (Form23.class286_0 == null && !flag3)
								{
									string text13 = Class333.Bgy() + item.method_12();
									Control9 control2 = null;
									if (bool_0)
									{
										control2 = new Control9(settingOrSpecialObject, BXh);
										control2.Name = text13;
									}
									else if (method_12().Controls.ContainsKey(text13))
									{
										control2 = method_12().Controls[text13] as Control9;
									}
									if (control2 != null)
									{
										control2.Left = int_2 + method_12().AutoScrollPosition.X;
										control2.Top = int_3 + method_12().AutoScrollPosition.Y;
										if (bool_0)
										{
											method_12().Controls.Add(control2);
										}
										rectangle_ = new Rectangle(int_2, int_3, control2.Size.Width, control2.Size.Height);
									}
								}
							}
							else
							{
								string text14 = Class333.BgT() + item.method_12();
								Class117 class14 = null;
								if (bool_0)
								{
									string string_2 = string.Empty;
									if (item.method_50())
									{
										string_2 = item.method_10();
									}
									class14 = new Class117(settingOrSpecialObject as SpecialObject, string_2, item, BXh, BXI, Rectangle.Empty, bool_0: false, bool_1: true, BXn);
									class14.Name = text14;
								}
								else if (method_12().Controls.ContainsKey(text14))
								{
									class14 = method_12().Controls[text14] as Class117;
								}
								if (class14 != null)
								{
									class14.Left = int_2 + method_12().AutoScrollPosition.X;
									class14.Top = int_3 + method_12().AutoScrollPosition.Y;
									if (bool_0)
									{
										method_12().Controls.Add(class14);
									}
									class14.method_15(bool_0);
									rectangle_ = new Rectangle(int_2, int_3, class14.Size.Width, class14.Size.Height);
								}
							}
						}
					}
					else if (settingOrSpecialObject.method_35() || (settingOrSpecialObject as SpecialObject).method_68().InjectorStageIndex == -1)
					{
						string text15 = Class333.BgW() + item.method_12();
						Class86 class15 = null;
						if (bool_0)
						{
							class15 = new Class86(settingOrSpecialObject as SpecialObject, BXh, BXI, Rectangle.Empty, bool_0: false);
							class15.Name = text15;
						}
						else if (method_12().Controls.ContainsKey(text15))
						{
							class15 = method_12().Controls[text15] as Class86;
						}
						if (class15 != null)
						{
							class15.Left = int_2 + method_12().AutoScrollPosition.X;
							class15.Top = int_3 + method_12().AutoScrollPosition.Y;
							if (bool_0)
							{
								method_12().Controls.Add(class15);
								class15.method_17();
							}
							rectangle_ = new Rectangle(int_2, int_3, class15.Size.Width, class15.Size.Height);
						}
					}
				}
				else if (settingOrSpecialObject is SensorCalibration && (settingOrSpecialObject as SensorCalibration).CalibrationValuesSetting != null)
				{
					string text16 = Class333.BgZ() + item.method_12();
					Class123 class16 = null;
					if (bool_0)
					{
						class16 = new Class123(settingOrSpecialObject as SensorCalibration, item, BXh, BXI, Rectangle.Empty, bool_0: false);
						class16.Name = text16;
					}
					else if (method_12().Controls.ContainsKey(text16))
					{
						class16 = method_12().Controls[text16] as Class123;
					}
					if (class16 != null)
					{
						class16.Left = int_2 + method_12().AutoScrollPosition.X;
						class16.Top = int_3 + method_12().AutoScrollPosition.Y;
						if (bool_0)
						{
							method_12().Controls.Add(class16);
							class16.method_16();
						}
						rectangle_ = new Rectangle(int_2, int_3, class16.Size.Width, class16.Size.Height);
					}
				}
			}
			else if (item.method_56() != 0)
			{
				string text17 = Class333.Bgz() + item.method_12();
				Control0 control3 = null;
				if (bool_0)
				{
					control3 = new Control0(BXi, item.method_56(), BXh, item.method_58());
					control3.Name = text17;
				}
				else if (method_12().Controls.ContainsKey(text17))
				{
					control3 = method_12().Controls[text17] as Control0;
				}
				if (control3 != null)
				{
					control3.Left = int_2 + method_12().AutoScrollPosition.X;
					control3.Top = int_3 + method_12().AutoScrollPosition.Y;
					if (bool_0)
					{
						method_12().Controls.Add(control3);
					}
					control3.method_3(bool_0);
					rectangle_ = new Rectangle(int_2, int_3, control3.Size.Width, control3.Size.Height);
				}
			}
			else if (!item.method_29() && !item.method_31())
			{
				foreach (MenuNode item4 in item.method_6())
				{
					if (item4.method_28())
					{
						method_39(bool_0, item, int_2, int_3, ref rectangle_);
						break;
					}
				}
			}
			else
			{
				method_40(bool_0, item, int_2, int_3, ref rectangle_);
			}
			if (num3 == num && num4 == num2)
			{
				num++;
				num3 = num;
			}
			else
			{
				num = num3;
			}
			num2 = num4;
			if (item.method_54() || item.method_52())
			{
				list2.Add(num3);
			}
			while (num3 >= list.Count)
			{
				list.Add(new List<Rectangle>());
			}
			if (num4 >= list[num3].Count)
			{
				list[num3].Add(rectangle_);
			}
		}
		if (BXO != Rectangle.Empty)
		{
			if (bool_0)
			{
				Width = BXO.Width;
				Height = BXO.Height;
				Left = BXO.Left;
				Top = BXO.Top;
			}
		}
		else
		{
			int num7 = 0;
			int num8 = 0;
			foreach (Control control4 in method_12().Controls)
			{
				num7 = Math.Max(num7, control4.Right + 10);
				num8 = Math.Max(num8, control4.Bottom + 10);
			}
			if (Width != num7 || Height != num8)
			{
				Width = num7;
				Height = num8;
			}
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
		if (BXi.method_28())
		{
			string value = ((!(Parent is Class118)) ? BXi.method_100(bool_0: false, bool_1: false) : BXi.method_10());
			if (BXi.method_50() && !string.IsNullOrEmpty(value))
			{
				if (method_12().Controls.Count > 1)
				{
					Visible = true;
					method_14();
				}
				else
				{
					Width = 0;
					Height = 0;
					Visible = false;
				}
			}
			else if (method_12().Controls.Count > 0)
			{
				Visible = true;
				method_14();
			}
			else
			{
				Width = 0;
				Height = 0;
				Visible = false;
			}
		}
		else
		{
			Visible = true;
			method_14();
		}
	}

	private bool method_22(MenuNode menuNode_0)
	{
		if (Form23.class286_0 != null && (!menuNode_0.method_79() || (menuNode_0 != Form23.menuNode_2 && !Form23.list_0.Contains(menuNode_0.method_73()))))
		{
			if (BXi.method_37() && menuNode_0.method_10() == Class333.Bgr())
			{
				return false;
			}
			HashSet<DataIdAndAttrId> hashSet = MenuNode.smethod_1(menuNode_0);
			bool flag = false;
			foreach (DataIdAndAttrId item in hashSet)
			{
				if (Form23.list_0.Contains(item.DataId))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return true;
			}
		}
		return false;
	}

	private void method_23(object sender, EventArgs e)
	{
		method_21(bool_0: false);
	}

	private void method_24(object sender, EventArgs e)
	{
		if (BXo && sender is Control { Disposing: false, IsDisposed: false })
		{
			method_21(bool_0: false);
		}
	}

	private void method_25(object sender, LayoutEventArgs e)
	{
		if (BXo)
		{
			method_21(bool_0: false);
		}
	}

	internal void method_26()
	{
		Control6 control = null;
		int num = 0;
		foreach (Control control8 in method_12().Controls)
		{
			if (control8.Visible)
			{
				int num2 = method_12().Height - 30 - control8.Bottom;
				num = ((num != 0) ? Math.Min(num, num2) : num2);
				if (control8 is Control6)
				{
					control = control8 as Control6;
				}
			}
		}
		if (control != null)
		{
			if (num <= 0)
			{
				return;
			}
			SuspendLayout();
			foreach (Control control9 in method_12().Controls)
			{
				if (control9.Visible && control9.Top > control.Top)
				{
					control9.Top += num;
				}
			}
			control.Height += num;
			ResumeLayout(performLayout: true);
		}
		else
		{
			if (num <= 0)
			{
				return;
			}
			foreach (Control control10 in method_12().Controls)
			{
				if (!control10.Visible || !(control10 is Class117))
				{
					continue;
				}
				Class117 @class = control10 as Class117;
				foreach (Control control11 in @class.method_12().Controls)
				{
					if (!control11.Visible || !(control11 is Control6))
					{
						continue;
					}
					control = control11 as Control6;
					SuspendLayout();
					@class.SuspendLayout();
					foreach (Control control12 in method_12().Controls)
					{
						if (control12.Visible && control12.Top > @class.Top)
						{
							control12.Top += num;
						}
					}
					@class.Height += num;
					foreach (Control control13 in @class.method_12().Controls)
					{
						if (control13.Visible && control13.Top > control.Top)
						{
							control13.Top += num;
						}
					}
					control.Height += num;
					@class.ResumeLayout(performLayout: true);
					ResumeLayout(performLayout: true);
					return;
				}
			}
		}
	}

	private bool method_27()
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG && BXj != null)
		{
			if (BXI.method_2() && BXI.method_3())
			{
				return BXj.method_96();
			}
			return false;
		}
		if (BXh.method_2() && BXh.method_3())
		{
			return BXJ.method_96();
		}
		return false;
	}

	private void method_28(bool bool_0, ref int int_3)
	{
		int_3 += 5;
		int num = int_3;
		int num2 = 0;
		string bsP = BXi.method_80().BcF.BcC[Class333.smethod_562()].BsP;
		if (string.IsNullOrEmpty(BXi.method_80().BcF.Bca))
		{
			if (bool_0)
			{
				Label label = new Label();
				label.Name = Class333.BHA();
				label.BackColor = Color.Transparent;
				label.ForeColor = Form23.color_12;
				label.Font = new Font(label.Font.FontFamily, 9f);
				label.AutoSize = true;
				label.Text = bsP;
				label.Left = 5;
				label.Top = int_3;
				method_12().Controls.Add(label);
			}
			else if (method_12().Controls.ContainsKey(Class333.BHA()))
			{
				Label obj = method_12().Controls[Class333.BHA()] as Label;
				obj.Left = 5 + method_12().AutoScrollPosition.X;
				obj.Top = int_3 + method_12().AutoScrollPosition.Y;
			}
			using Font font = new Font(Font.FontFamily, 9f);
			num2 = Math.Max(5 + TextRenderer.MeasureText(bsP, font).Width + 20, num2);
		}
		else
		{
			if (bool_0)
			{
				LinkLabel linkLabel = new LinkLabel();
				linkLabel.Name = Class333.BHa();
				linkLabel.Tag = BXi.method_80().BcF;
				linkLabel.Font = new Font(linkLabel.Font.FontFamily, 9f);
				linkLabel.LinkBehavior = LinkBehavior.AlwaysUnderline;
				linkLabel.LinkColor = Form23.color_13;
				linkLabel.AutoSize = true;
				linkLabel.Text = Class333.BHB() + bsP;
				linkLabel.Left = 5;
				linkLabel.Top = int_3;
				linkLabel.Click += method_29;
				method_12().Controls.Add(linkLabel);
			}
			else if (method_12().Controls.ContainsKey(Class333.BHa()))
			{
				LinkLabel obj2 = method_12().Controls[Class333.BHa()] as LinkLabel;
				obj2.Left = 5 + method_12().AutoScrollPosition.X;
				obj2.Top = int_3 + method_12().AutoScrollPosition.Y;
			}
			using Font font2 = new Font(Font.FontFamily, 9f);
			num2 = Math.Max(5 + TextRenderer.MeasureText(Class333.BHB() + bsP, font2).Width + 20, num2);
		}
		int_3 += 23;
		string bsQ = BXi.method_80().BcF.BcC[Class333.smethod_562()].BsQ;
		if (bool_0)
		{
			Label label2 = new Label();
			label2.Name = Class333.BHb();
			label2.BackColor = Color.Transparent;
			label2.ForeColor = Form23.color_12;
			label2.Font = new Font(label2.Font.FontFamily, 9f);
			label2.AutoSize = true;
			label2.Text = Class333.smethod_583();
			label2.Left = 5;
			label2.Top = int_3;
			method_12().Controls.Add(label2);
			Label label3 = new Label();
			label3.Name = Class333.BHC();
			label3.BackColor = Color.Transparent;
			label3.ForeColor = Form23.color_12;
			label3.Font = new Font(label3.Font.FontFamily, 9f);
			label3.AutoSize = true;
			label3.Text = bsQ;
			label3.Left = 150;
			label3.Top = int_3;
			method_12().Controls.Add(label3);
		}
		else if (method_12().Controls.ContainsKey(Class333.BHb()) && method_12().Controls.ContainsKey(Class333.BHC()))
		{
			Label obj3 = method_12().Controls[Class333.BHb()] as Label;
			obj3.Left = 5 + method_12().AutoScrollPosition.X;
			obj3.Top = int_3 + method_12().AutoScrollPosition.Y;
			Label obj4 = method_12().Controls[Class333.BHC()] as Label;
			obj4.Left = 150 + method_12().AutoScrollPosition.X;
			obj4.Top = int_3 + method_12().AutoScrollPosition.Y;
		}
		using (Font font3 = new Font(Font.FontFamily, 9f))
		{
			num2 = Math.Max(150 + TextRenderer.MeasureText(bsQ, font3).Width + 20, num2);
		}
		for (int i = 0; i < bsQ.Length; i++)
		{
			if (bsQ[i] == '\n')
			{
				int_3 += 15;
			}
		}
		int_3 += 20;
		string text = BXi.method_80().BcF.BCY.ToString();
		if (bool_0)
		{
			Label label4 = new Label();
			label4.Name = Class333.BHc();
			label4.BackColor = Color.Transparent;
			label4.ForeColor = Form23.color_12;
			label4.Font = new Font(label4.Font.FontFamily, 9f);
			label4.AutoSize = true;
			label4.Text = Class333.BHD();
			label4.Left = 5;
			label4.Top = int_3;
			method_12().Controls.Add(label4);
			Label label5 = new Label();
			label5.Name = Class333.BHd();
			label5.BackColor = Color.Transparent;
			label5.ForeColor = Form23.color_12;
			label5.Font = new Font(label5.Font.FontFamily, 9f);
			label5.AutoSize = true;
			label5.Text = text;
			label5.Left = 150;
			label5.Top = int_3;
			method_12().Controls.Add(label5);
		}
		else if (method_12().Controls.ContainsKey(Class333.BHc()) && method_12().Controls.ContainsKey(Class333.BHd()))
		{
			Label obj5 = method_12().Controls[Class333.BHc()] as Label;
			obj5.Left = 5 + method_12().AutoScrollPosition.X;
			obj5.Top = int_3 + method_12().AutoScrollPosition.Y;
			Label obj6 = method_12().Controls[Class333.BHd()] as Label;
			obj6.Left = 150 + method_12().AutoScrollPosition.X;
			obj6.Top = int_3 + method_12().AutoScrollPosition.Y;
		}
		using (Font font4 = new Font(Font.FontFamily, 9f))
		{
			num2 = Math.Max(150 + TextRenderer.MeasureText(text, font4).Width + 20, num2);
		}
		int_3 += 20;
		int num3 = 0;
		foreach (string key in BXi.method_80().BcF.Bcb.Keys)
		{
			if (BXi.method_1().awF.ContainsKey(BXi.method_80().BcF.BCx) && BXi.method_1().awF[BXi.method_80().BcF.BCx].method_79().Contains(key))
			{
				continue;
			}
			string text2 = BXi.method_80().BcF.Bcb[key];
			if (bool_0)
			{
				Label label6 = new Label();
				label6.Name = Class333.BHE() + num3;
				label6.BackColor = Color.Transparent;
				label6.ForeColor = Form23.color_12;
				label6.Font = new Font(label6.Font.FontFamily, 9f);
				label6.AutoSize = true;
				label6.Text = Class286.smethod_12(key, Class333.smethod_562()) + Class333.smethod_134();
				label6.Left = 5;
				label6.Top = int_3;
				method_12().Controls.Add(label6);
				Label label7 = new Label();
				label7.Name = Class333.BHe() + num3;
				label7.BackColor = Color.Transparent;
				label7.ForeColor = Form23.color_12;
				label7.Font = new Font(label7.Font.FontFamily, 9f);
				label7.AutoSize = true;
				label7.Text = text2;
				label7.Left = 150;
				label7.Top = int_3;
				method_12().Controls.Add(label7);
			}
			else if (method_12().Controls.ContainsKey(Class333.BHE() + num3) && method_12().Controls.ContainsKey(Class333.BHe() + num3))
			{
				Label obj7 = method_12().Controls[Class333.BHE() + num3] as Label;
				obj7.Left = 5 + method_12().AutoScrollPosition.X;
				obj7.Top = int_3 + method_12().AutoScrollPosition.Y;
				Label obj8 = method_12().Controls[Class333.BHe() + num3] as Label;
				obj8.Left = 150 + method_12().AutoScrollPosition.X;
				obj8.Top = int_3 + method_12().AutoScrollPosition.Y;
			}
			num3++;
			using (Font font5 = new Font(Font.FontFamily, 9f))
			{
				num2 = Math.Max(150 + TextRenderer.MeasureText(text2, font5).Width + 20, num2);
			}
			for (int j = 0; j < text2.Length; j++)
			{
				if (text2[j] == '\n')
				{
					int_3 += 15;
				}
			}
			int_3 += 20;
		}
		if (bool_0)
		{
			Image image = Class288.smethod_1(BXi.method_80());
			if (image != null)
			{
				PictureBox pictureBox = new PictureBox();
				pictureBox.Name = Class333.BHF();
				pictureBox.Left = num2;
				pictureBox.Top = num;
				pictureBox.Height = Math.Min(Math.Max(280, int_3 - num), image.Height);
				if (num + pictureBox.Height > int_3)
				{
					int_3 += num + pictureBox.Height - int_3;
				}
				pictureBox.Width = image.Width * pictureBox.Height / image.Height;
				pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
				pictureBox.Image = image;
				method_12().Controls.Add(pictureBox);
			}
		}
		else if (method_12().Controls.ContainsKey(Class333.BHF()))
		{
			PictureBox pictureBox2 = method_12().Controls[Class333.BHF()] as PictureBox;
			pictureBox2.Left = num2 + method_12().AutoScrollPosition.X;
			pictureBox2.Top = num + method_12().AutoScrollPosition.Y;
			if (num + pictureBox2.Height > int_3)
			{
				int_3 += num + pictureBox2.Height - int_3;
			}
		}
		int_3 += 5;
	}

	private void method_29(object sender, EventArgs e)
	{
		LinkLabel linkLabel = sender as LinkLabel;
		if (linkLabel.Tag == null)
		{
			return;
		}
		Class286 @class = linkLabel.Tag as Class286;
		if (string.IsNullOrEmpty(@class.Bca))
		{
			return;
		}
		if (!@class.Bca.StartsWith(Class333.smethod_585()) && !@class.Bca.StartsWith(Class333.smethod_586()))
		{
			Uri uri = null;
			try
			{
				uri = new Uri(Class22.smethod_1(Form23.string_14, @class.Bca + Class333.smethod_588(), bool_0: true));
			}
			catch
			{
				uri = null;
			}
			if (uri != null)
			{
				if (Form23.bool_30)
				{
					Form23.form23_0.method_90();
				}
				else
				{
					Form23.form23_0.method_92();
				}
				Form23.control2_0.method_3(uri);
			}
			return;
		}
		try
		{
			Process.Start(Control2.smethod_0(), @class.Bca);
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.BHf() + ex.Message);
		}
	}

	private void method_30(bool bool_0, ref int int_3)
	{
		string text = ((!(Parent is Class118)) ? BXi.method_100(bool_0: false, bool_1: false) : BXi.method_10());
		if (BXJ != null)
		{
			if (!bool_0)
			{
				if (BXK != null)
				{
					method_19();
				}
				if (BXk != null)
				{
					method_20();
					if (!BXJ.method_219())
					{
						BXk.Left = 5 + BXK.Width + method_12().AutoScrollPosition.X;
						BXk.Top = int_3 + 2 + method_12().AutoScrollPosition.Y;
					}
					else if (BXi.method_50())
					{
						int_3 += 27;
						BXk.Left = 5 + method_12().AutoScrollPosition.X;
						BXk.Top = int_3 + 2 + method_12().AutoScrollPosition.Y;
					}
					else
					{
						BXk.Left = 5 + method_12().AutoScrollPosition.X;
						BXk.Top = int_3 + 2 + method_12().AutoScrollPosition.Y;
					}
					int_3 += 25;
				}
			}
			else if (BXJ.method_6() != null)
			{
				if (!BXJ.method_219())
				{
					BXK = new Class148();
					BXK.Enabled = BXh.method_4();
					BXK.Font = new Font(BXK.Font.FontFamily, 10f, FontStyle.Bold);
					BXK.ForeColor = Form23.color_14;
					method_19();
					BXK.Left = 5;
					BXK.Top = int_3;
					BXK.AutoSize = true;
					BXK.Tag = BXJ.method_64();
					BXK.CheckedChanged += BXK_CheckedChanged;
					BXJ.method_264(method_18);
					method_12().Controls.Add(BXK);
				}
				else if (BXi.method_50())
				{
					Label label = new Label();
					label.Text = text;
					label.ForeColor = Form23.color_14;
					label.Font = new Font(label.Font.FontFamily, 10f, FontStyle.Bold);
					label.BackColor = Color.Transparent;
					label.AutoSize = true;
					label.Left = 5;
					label.Top = int_3;
					int_3 += 27;
					method_12().Controls.Add(label);
				}
				method_12().ResumeLayout(performLayout: true);
				ResumeLayout(performLayout: true);
				SuspendLayout();
				method_12().SuspendLayout();
				BXk = new PictureBox();
				BXk.Tag = BXJ.method_64();
				BXk.Width = 18;
				BXk.Height = 18;
				if (BXJ.method_219())
				{
					BXk.Left = 5;
				}
				else
				{
					BXk.Left = 5 + BXK.Width;
				}
				BXk.Top = int_3 + 2;
				BXk.SizeMode = PictureBoxSizeMode.StretchImage;
				BXk.Click += BXk_Click;
				method_20();
				method_12().Controls.Add(BXk);
				BXk.BringToFront();
				int_3 += 25;
			}
		}
		else if (BXi.method_50())
		{
			if (bool_0)
			{
				Label label2 = new Label();
				label2.Name = Class333.BeG();
				label2.Text = text;
				label2.ForeColor = Form23.color_14;
				label2.Font = new Font(label2.Font.FontFamily, 10f * BXn, FontStyle.Bold);
				label2.BackColor = Color.Transparent;
				label2.AutoSize = true;
				label2.Left = 5;
				label2.Top = int_3;
				method_12().Controls.Add(label2);
			}
			else if (method_12().Controls.ContainsKey(Class333.BeG()))
			{
				Label obj = method_12().Controls[Class333.BeG()] as Label;
				obj.Left = 5 + method_12().AutoScrollPosition.X;
				obj.Top = int_3 + method_12().AutoScrollPosition.Y;
			}
			int_3 += (int)(22f * BXn);
			method_12().ResumeLayout(performLayout: true);
			ResumeLayout(performLayout: true);
			SuspendLayout();
			method_12().SuspendLayout();
		}
	}

	private void method_31(bool bool_0, ref int int_3)
	{
		if (int_3 != 2)
		{
			int_3 += 5;
		}
		Control6 control = null;
		if (bool_0)
		{
			control = new Control6();
			control.Size = new Size(1184, 350);
			control.Left = 5;
			control.Top = int_3;
			control.method_22(bool_4: true);
			control.method_1(BXi);
			method_12().Controls.Add(control);
		}
		else
		{
			foreach (Control control2 in method_12().Controls)
			{
				control = control2 as Control6;
				if (control != null)
				{
					if (control.method_0() == BXi)
					{
						control.Left = 5 + method_12().AutoScrollPosition.X;
						control.Top = int_3 + method_12().AutoScrollPosition.Y;
						break;
					}
					control = null;
				}
			}
		}
		if (control != null)
		{
			int_3 += control.Height + 5 + 5;
		}
	}

	private void method_32(bool bool_0, ref int int_3)
	{
		if (int_3 != 2)
		{
			int_3 += 5;
		}
		Control5 control = null;
		if (bool_0)
		{
			control = new Control5();
			control.Left = 5;
			control.Top = int_3;
			control.method_1(BXi);
			method_12().Controls.Add(control);
		}
		else
		{
			foreach (Control control2 in method_12().Controls)
			{
				control = control2 as Control5;
				if (control != null)
				{
					if (control.method_0() == BXi)
					{
						control.Left = 5 + method_12().AutoScrollPosition.X;
						control.Top = int_3 + method_12().AutoScrollPosition.Y;
						break;
					}
					control = null;
				}
			}
		}
		if (control != null)
		{
			int_3 += control.Height + 5;
		}
	}

	private void method_33(bool bool_0, ref int int_3, Setting setting_0)
	{
		if (int_3 != 2)
		{
			int_3 += 5;
		}
		if (bool_0)
		{
			BXL = new ThemedButton();
			BXL.Font = new Font(BXL.Font.FontFamily, 10f);
			BXL.Height = 30;
			BXL.AutoSize = true;
			method_34(setting_0);
			BXL.Left = 5;
			BXL.Top = int_3;
			BXL.Click += BXL_Click;
			method_12().Controls.Add(BXL);
			BXl = new ThemedButton();
			BXl.Font = new Font(BXl.Font.FontFamily, 10f);
			BXl.Height = 30;
			BXl.AutoSize = true;
			BXl.Text = Class333.BHG();
			method_12().ResumeLayout(performLayout: true);
			ResumeLayout(performLayout: true);
			SuspendLayout();
			method_12().SuspendLayout();
			BXl.Left = BXL.Right + 10;
			BXl.Top = int_3;
			BXl.Click += BXl_Click;
			method_12().Controls.Add(BXl);
			BXM = new Label();
			BXM.BackColor = Color.Transparent;
			BXM.ForeColor = Form23.color_12;
			BXM.Font = new Font(BXM.Font.FontFamily, 10f);
			BXM.AutoSize = true;
			method_12().ResumeLayout(performLayout: true);
			ResumeLayout(performLayout: true);
			SuspendLayout();
			method_12().SuspendLayout();
			BXM.Left = BXl.Right + 10;
			BXM.Top = int_3 + 5;
			method_12().Controls.Add(BXM);
			if (!BXi.method_90())
			{
				BXm = new ThemedButton();
				BXm.Font = new Font(BXm.Font.FontFamily, 10f);
				BXm.Height = 30;
				BXm.AutoSize = true;
				BXm.Left = 5;
				BXm.Top = int_3 + 40;
				BXm.Click += BXm_Click;
				method_12().Controls.Add(BXm);
			}
		}
		else if (BXL != null)
		{
			method_34(setting_0);
		}
		if (BXi.method_80() != null && BXi.method_80().BcF != null)
		{
			string text = string.Empty;
			if (BXi.method_94())
			{
				BXi.method_85(bool_0: false);
				if (BXi.method_88())
				{
					text = Class333.BHH();
				}
			}
			string text2 = string.Empty;
			if (!BXi.method_80().BcF.method_20())
			{
				text2 = Class333.BHh();
			}
			BXM.Text = BXi.method_80().BcF.BcC[Class333.smethod_562()].BsP + text + text2;
			BXM.Visible = true;
			BXl.Visible = true;
			if (BXm != null)
			{
				if (BXi.method_84())
				{
					BXm.Text = Class333.smethod_2260();
				}
				else
				{
					BXm.Text = Class333.BHI();
				}
				BXm.Visible = true;
				int_3 += 75;
			}
			else
			{
				int_3 += 40;
			}
		}
		else
		{
			if (setting_0.method_280())
			{
				BXM.Text = string.Empty;
				BXM.Visible = false;
				BXl.Visible = false;
			}
			else
			{
				BXM.Text = Class333.BHg();
				BXM.Visible = true;
				BXl.Visible = true;
			}
			if (BXm != null)
			{
				BXm.Visible = false;
			}
			int_3 += 40;
		}
	}

	private void method_34(Setting setting_0)
	{
		if (setting_0 != null && BXi != null)
		{
			BXL.Text = Class286.smethod_13(setting_0.method_0(), BXi, setting_0);
		}
	}

	private void BXm_Click(object sender, EventArgs e)
	{
		bool flag = false;
		if (BXi.method_94() && !BXi.method_84())
		{
			string text = ((!(Parent is Class118)) ? BXi.method_100(bool_0: false, bool_1: false) : BXi.method_10());
			string bsP = BXi.method_80().BcF.BcC[Class333.smethod_562()].BsP;
			if (Form54.smethod_6(Form23.form23_0, Class333.BHi() + text + Class333.BHJ() + bsP + Class333.smethod_2378(), Class333.BHj(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
			{
				return;
			}
			BXh.method_48(BXh.aWS);
			BXh.method_55();
			System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
			BXi.method_80().BcF.method_5(BXi);
			System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
			BXh.method_54(bool_0: true);
			BXh.method_49(BXh.aWS);
		}
		else
		{
			BXi.method_85(!BXi.method_84());
			flag = !BXi.method_84();
		}
		method_35();
		if (flag && Form23.form23_0.control4_0.method_0().method_2().Count != 0 && Form23.form23_0.control4_0.method_35(BXi.method_12()) != null)
		{
			Form23.form23_0.control4_0.method_42(BXi.method_80().BcF, Form23.form23_0.control4_0.method_0().method_2());
		}
	}

	private void BXL_Click(object sender, EventArgs e)
	{
		Form30 form = new Form30(BXi);
		if (form.ShowDialog(this) == DialogResult.OK)
		{
			method_35();
		}
		form.Dispose();
	}

	private void BXl_Click(object sender, EventArgs e)
	{
		BXi.method_0().method_1();
		Setting setting = BXh.method_31(BXi.method_73());
		setting.method_279(bool_0: true);
		BXi.method_81();
		BXi.method_95(bool_0: false);
		BXi.method_85(bool_0: false);
		Form23.smethod_74(setting.method_64());
		BXi.method_0().method_4();
		method_35();
	}

	private void method_35()
	{
		method_16();
		if (BXL != null)
		{
			BXL.Click -= BXL_Click;
		}
		if (BXl != null)
		{
			BXl.Click -= BXl_Click;
		}
		if (BXm != null)
		{
			BXm.Click -= BXm_Click;
		}
		foreach (Control control in method_12().Controls)
		{
			if (control is Class112 || control is Class117)
			{
				control.VisibleChanged -= method_24;
				control.Layout -= method_25;
			}
			if (control is LinkLabel)
			{
				control.Click -= method_29;
			}
		}
		while (method_12().Controls.Count != 0)
		{
			Class30.smethod_0(method_12().Controls[0]);
		}
		if (BXO != Rectangle.Empty)
		{
			BXO = new Rectangle(Location, Size);
		}
		method_21(bool_0: true);
		if (Form23.form23_0.control4_0.method_0().method_2().Count != 0)
		{
			Form23.form23_0.control4_0.method_14(bool_7: false, bool_8: true, bool_9: true, bool_10: true);
			Form23.form23_0.control4_0.method_39(bool_7: false);
			if (Form23.framework_0 != null)
			{
				Form23.form23_0.control4_0.method_40(bool_7: false);
			}
		}
	}

	private List<MenuNode> method_36()
	{
		List<MenuNode> list = new List<MenuNode>();
		bool flag = true;
		foreach (MenuNode item in BXi.method_6())
		{
			if (item.method_26() != 0)
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			foreach (MenuNode item2 in BXi.method_6())
			{
				if (!item2.method_28())
				{
					if (list.Count == 0)
					{
						list.Add(item2);
					}
					else
					{
						list.Insert(0, item2);
					}
					continue;
				}
				for (int i = 0; i <= list.Count; i++)
				{
					if (i < list.Count)
					{
						MenuNode menuNode = list[i];
						if (item2.method_24() < menuNode.method_24())
						{
							list.Insert(i, item2);
							break;
						}
						continue;
					}
					list.Add(item2);
					break;
				}
			}
		}
		else
		{
			foreach (MenuNode item3 in BXi.method_6())
			{
				list.Add(item3);
			}
		}
		return list;
	}

	private bool method_37()
	{
		bool flag = false;
		if (BXi.method_5() != null)
		{
			MenuNode menuNode = BXi.method_5();
			bool flag2 = false;
			do
			{
				if (!menuNode.method_31())
				{
					if (menuNode.method_5() != null)
					{
						menuNode = menuNode.method_5();
					}
					else
					{
						flag2 = true;
					}
					continue;
				}
				flag = true;
				break;
			}
			while (!flag2);
		}
		if (!flag)
		{
			foreach (MenuNode item in BXi.method_6())
			{
				if (item.method_33())
				{
					if (BXN)
					{
						flag = true;
					}
					break;
				}
			}
		}
		return flag;
	}

	private void method_38(int int_3, int int_4, int int_5, int int_6, Rectangle rectangle_0, List<List<Rectangle>> list_0, List<int> list_1, ref int int_7, ref int int_8)
	{
		if (int_5 == -1 || int_6 == -1 || !(rectangle_0 != Rectangle.Empty))
		{
			return;
		}
		if (int_4 == int_6)
		{
			int_7 = rectangle_0.Left;
			int num = ((rectangle_0.Width != 0 && rectangle_0.Height != 0) ? 5 : 0);
			int_8 = rectangle_0.Bottom + num;
		}
		else if (int_4 != 0)
		{
			int num2 = 0;
			for (int i = int_3; i < list_0.Count; i++)
			{
				List<Rectangle> list = list_0[i];
				int count = list.Count;
				if (count != 0 && !list_1.Contains(i))
				{
					int index = Math.Min(int_4 - 1, count - 1);
					num2 = Math.Max(num2, list[index].Right);
				}
			}
			int num3 = ((num2 > 5) ? 5 : 0);
			int_7 = num2 + num3;
			if (int_3 == 0 || int_3 >= list_0.Count)
			{
				return;
			}
			int num4 = 0;
			for (int j = 0; j < int_3; j++)
			{
				foreach (Rectangle item in list_0[j])
				{
					num4 = Math.Max(num4, item.Bottom);
				}
			}
			int_8 = num4 + 5;
		}
		else if (int_3 == 0)
		{
			int_8 = list_0[list_0.Count - 1][0].Bottom + 5;
		}
		else
		{
			if (int_5 >= list_0.Count)
			{
				return;
			}
			List<Rectangle> list2 = list_0[list_0.Count - 1];
			int num5 = 0;
			foreach (Rectangle item2 in list2)
			{
				num5 = Math.Max(num5, item2.Bottom);
			}
			int_8 = num5 + 5;
		}
	}

	private void method_39(bool bool_0, MenuNode menuNode_0, int int_3, int int_4, ref Rectangle rectangle_0)
	{
		string text = Class333.BHK() + menuNode_0.method_12();
		Class118 @class = null;
		if (bool_0)
		{
			@class = new Class118(BXh, BXI, Rectangle.Empty, bool_0: false, bool_1: true, bool_2: false);
			@class.method_15(menuNode_0);
			@class.Name = text;
		}
		else if (method_12().Controls.ContainsKey(text))
		{
			@class = method_12().Controls[text] as Class118;
		}
		if (@class != null)
		{
			@class.Left = int_3 + method_12().AutoScrollPosition.X;
			@class.Top = int_4 + method_12().AutoScrollPosition.Y;
			if (bool_0)
			{
				method_12().Controls.Add(@class);
			}
			@class.method_21(bool_0);
			rectangle_0 = new Rectangle(int_3, int_4, @class.Size.Width, @class.Size.Height);
		}
	}

	private void method_40(bool bool_0, MenuNode menuNode_0, int int_3, int int_4, ref Rectangle rectangle_0)
	{
		string text = Class333.BHk() + menuNode_0.method_12();
		Class124 @class = null;
		if (bool_0)
		{
			@class = new Class124(BXh, BXI, Rectangle.Empty, bool_0: false, bool_1: false);
			@class.method_12(menuNode_0);
			@class.Name = text;
		}
		else if (method_12().Controls.ContainsKey(text))
		{
			@class = method_12().Controls[text] as Class124;
		}
		if (@class != null)
		{
			@class.Left = int_3 + method_12().AutoScrollPosition.X;
			@class.Top = int_4 + method_12().AutoScrollPosition.Y;
			if (bool_0)
			{
				method_12().Controls.Add(@class);
				Class88.Bhl = @class;
			}
			@class.method_18(bool_0);
			rectangle_0 = new Rectangle(int_3, int_4, @class.Size.Width, @class.Size.Height);
		}
	}

	public Control imethod_0(DataIdAndAttrId dataIdAndAttrId_0)
	{
		foreach (Control control3 in method_12().Controls)
		{
			if (control3 is Interface3)
			{
				Control control2 = (control3 as Interface3).imethod_0(dataIdAndAttrId_0);
				if (control2 != null)
				{
					return control2;
				}
			}
		}
		return null;
	}

	public Control imethod_1()
	{
		int num = int.MaxValue;
		int num2 = int.MaxValue;
		foreach (Control control4 in method_12().Controls)
		{
			if (control4 is Interface3)
			{
				num = Math.Min(num, control4.Left);
				num2 = Math.Min(num2, control4.Top);
			}
		}
		foreach (Control control5 in method_12().Controls)
		{
			if (control5 is Class88)
			{
				Class88 @class = control5 as Class88;
				if (@class.Focused)
				{
					return @class;
				}
			}
			else if (control5.Left == num && control5.Top == num2 && control5 is Interface3)
			{
				Control control3 = (control5 as Interface3).imethod_1();
				if (control3 != null)
				{
					return control3;
				}
			}
		}
		return null;
	}

	[SpecialName]
	internal Class88 method_41()
	{
		if (method_12().Controls.ContainsKey(Class333.BgS()))
		{
			return method_12().Controls[Class333.BgS()] as Class88;
		}
		return null;
	}

	private void method_42(object sender, EventArgs e)
	{
		Enum65 @enum = (Form23.form23_0.control25_0.SelectedTab as Class130).method_0();
		int selectedIndex = Form23.form23_0.control25_0.SelectedIndex;
		if (@enum != Enum65.const_1 && Form23.form23_0.control25_0.method_5(selectedIndex) == this)
		{
			Form54.smethod_6(Form23.form23_0, Class333.Bfk(), Class333.BfL(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Class30.smethod_0(this);
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_43(object sender, CancelEventArgs e)
	{
		if (Class88.Bhk != null && Class88.Bhk.CanFocus)
		{
			e.Cancel = true;
		}
		else
		{
			if (ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
			{
				if (item.Text == Class333.Bfn())
				{
					item.Enabled = !Form23.form23_0.control25_0.method_25(this);
					break;
				}
			}
		}
	}

	private ContextMenuStrip method_44()
	{
		if (Form48.smethod_2())
		{
			return null;
		}
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		contextMenuStrip.Opening += method_43;
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Text = Class333.Bfn();
		toolStripMenuItem.Click += method_42;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		return contextMenuStrip;
	}

	internal void method_45(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.BHL());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		if (BXi != null && BXi.method_104(bool_0: false).Count != 0)
		{
			list.Add(Class333.BHl() + BXi.method_104(bool_0: false).First().DataId);
		}
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal int method_46(StreamReader streamReader_0)
	{
		string text;
		if ((text = streamReader_0.ReadLine()) != null && text.StartsWith(Class333.BHl()))
		{
			return int.Parse(text.Substring(Class333.BHl().Length));
		}
		return 0;
	}
}
