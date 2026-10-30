using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
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

internal class Class117 : Class109, Interface3
{
	private class Class146 : ThemedButton
	{
		private delegate void Delegate80(object sender, EventArgs e);

		private List<Setting> bBN = new List<Setting>();

		private Class117 bBn;

		internal Class146(Class117 class117_0)
		{
			AutoSize = false;
			Width = 120;
			Text = Class333.BJl();
			bBn = class117_0;
			foreach (UIListSettingDataIdAndIndent currentUIListSettingsIdsAndIndent in bBn.BXD.method_66().CurrentUIListSettingsIdsAndIndents)
			{
				Setting setting = bBn.BXb.method_31(currentUIListSettingsIdsAndIndent.DataId);
				if (setting != null && setting.method_198().BYl != 0 && bBn.BXb.method_31(setting.method_198().BYl) != null)
				{
					bBN.Add(setting);
					setting.method_40(method_0);
				}
			}
			Form23.form23_0.method_9(method_0);
			method_0(null, null);
		}

		protected override void Dispose(bool disposing)
		{
			Form23.form23_0.method_10(method_0);
			foreach (Setting item in bBN)
			{
				item.method_41(method_0);
			}
			bBN.Clear();
			base.Dispose(disposing);
		}

		private void method_0(object sender, EventArgs e)
		{
			if (InvokeRequired)
			{
				Delegate80 method = method_0;
				Invoke(method, sender, e);
				return;
			}
			if (Form23.enum60_0 != Form23.Enum60.BpG && bBn.BXb.method_4())
			{
				foreach (Setting item in bBN)
				{
					if (item.method_35())
					{
						Enabled = true;
						return;
					}
				}
			}
			Enabled = false;
		}

		protected override void OnClick(EventArgs eventArgs_0)
		{
			base.OnClick(eventArgs_0);
			if (Form23.enum60_0 == Form23.Enum60.BpG || !bBn.BXb.method_4())
			{
				return;
			}
			List<Setting> list = new List<Setting>();
			foreach (Setting item in bBN)
			{
				if (item.method_35())
				{
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				return;
			}
			Class280 @class = Form23.smethod_95();
			@class?.method_1();
			foreach (Setting item2 in list)
			{
				Setting setting = bBn.BXb.method_31(item2.method_198().BYl);
				item2.method_272(setting.method_256(), bool_0: true);
				Form23.smethod_75(item2.method_69());
			}
			@class?.method_4();
		}
	}

	private class Class147 : ThemedButton
	{
		private delegate void Delegate81(object sender, EventArgs e);

		private Setting bBO;

		private Class117 bBo;

		internal Class147(Setting setting_0, Class117 class117_0)
		{
			AutoSize = false;
			bBO = setting_0;
			bBo = class117_0;
			bBO.method_265(method_1);
			bBO.method_264(method_1);
			bBO.method_41(method_1);
			bBO.method_40(method_1);
		}

		protected override void Dispose(bool disposing)
		{
			bBO.method_265(method_1);
			bBO.method_41(method_1);
			base.Dispose(disposing);
		}

		internal void method_0()
		{
			lock (Form23.object_0)
			{
				string key = Class24.smethod_0(bBO.method_259());
				if (Form23.dictionary_1.ContainsKey(key) && Form23.dictionary_1[key].BcF != null)
				{
					Class286 bcF = Form23.dictionary_1[key].BcF;
					Text = bcF.BcC[Class333.smethod_562()].Bsp;
				}
				else
				{
					MenuNode menuNode_ = bBO.method_0().awX[bBO.method_64()];
					Text = Class286.smethod_13(bBO.method_0(), menuNode_, bBO);
				}
				Width = TextRenderer.MeasureText(Text, Font).Width + 20;
			}
		}

		protected override void OnClick(EventArgs eventArgs_0)
		{
			base.OnClick(eventArgs_0);
			Setting setting = bBO.method_0().method_31((int)Tag);
			if (setting == null || !bBO.method_0().awX.ContainsKey(setting.method_64()))
			{
				return;
			}
			Form30 form = new Form30(bBO.method_0().awX[setting.method_64()]);
			if (form.ShowDialog(this) == DialogResult.OK)
			{
				bBo.method_29();
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
			form.Dispose();
		}

		private void method_1(object sender, EventArgs e)
		{
			if (InvokeRequired)
			{
				try
				{
					Delegate81 method = method_1;
					Invoke(method, sender, e);
					return;
				}
				catch
				{
					return;
				}
			}
			method_0();
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class172
	{
		public static readonly Class172 bBP = new Class172();

		public static Func<SettingOrSpecialObject, bool> bBp;

		internal bool method_0(SettingOrSpecialObject settingOrSpecialObject_0)
		{
			if (settingOrSpecialObject_0 is Setting)
			{
				return (settingOrSpecialObject_0 as Setting).method_154();
			}
			return false;
		}
	}

	private const int Bwy = 5;

	private const int BwZ = 2;

	private const int Bwz = 7;

	private const int BXA = 28;

	private const int BXa = 100;

	private const int BXB = 200;

	private Framework BXb;

	private Framework BXC;

	private MenuNode BXc;

	private SpecialObject BXD;

	private Setting BXd;

	private Rectangle BXE;

	private string BXe;

	private float BXF = 1f;

	private int BXf;

	internal Class117(SpecialObject specialObject_0, string string_0, MenuNode menuNode_0, Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0, bool bool_1, float float_0 = 1f)
		: base(rectangle_0, bool_0, bool_1)
	{
		BXD = specialObject_0;
		BXb = framework_0;
		BXC = framework_1;
		BXc = menuNode_0;
		BXe = string_0;
		BXF = float_0;
		BXE = rectangle_0;
	}

	internal Class117(Setting setting_0, string string_0, Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0, bool bool_1, float float_0 = 1f)
		: base(rectangle_0, bool_0, bool_1)
	{
		BXd = setting_0;
		BXb = framework_0;
		BXC = framework_1;
		BXe = string_0;
		BXF = float_0;
		BXE = rectangle_0;
	}

	public override string ToString()
	{
		string text = base.ToString();
		if (BXe != null)
		{
			text = text + Class333.smethod_325() + BXe;
		}
		if (BXD != null)
		{
			text = text + Class333.smethod_325() + BXD.method_22(bool_0: true);
		}
		return text + Class333.smethod_325() + method_12().Controls.Count + Class333.Bgm();
	}

	internal void method_15(bool bool_0)
	{
		SuspendLayout();
		method_12().SuspendLayout();
		int int_ = 5;
		int int_2 = 2;
		int num = 0;
		if (BXe != string.Empty)
		{
			Label label = new Label();
			label.Name = Class333.BeG();
			label.Text = BXe;
			label.ForeColor = Form23.color_14;
			label.Font = new Font(label.Font.FontFamily, 8f * BXF, FontStyle.Bold);
			label.BackColor = Color.Transparent;
			label.AutoSize = true;
			label.Left = int_;
			label.Top = int_2;
			int_2 = label.Bottom + 3;
			num = int_2;
			if (bool_0)
			{
				method_12().Controls.Add(label);
			}
			else
			{
				label.Dispose();
			}
		}
		int num2 = 0;
		if (BXd == null && BXD.method_66().CurrentUIListSettingsIdsAndIndents.Count == 0)
		{
			if (BXD != null)
			{
				if (!BXD.method_67().EachListRowIsAnObject())
				{
					method_19(ref int_, ref int_2, bool_0);
				}
				method_20(ref int_, ref int_2, bool_0);
				if (BXD.method_67().DataIdsOfListSettings.Count != 0)
				{
					num2 = method_23(ref int_, ref int_2, bool_0);
				}
				else if (BXD.method_67().EachListRowIsAnObject())
				{
					if (BXD.method_67().ShowSummary)
					{
						method_25(bool_0);
					}
					else
					{
						method_24(ref int_, ref int_2, bool_0);
					}
				}
				Interface4 @interface = BXD.method_11();
				if (@interface != null && @interface is ConditionalActivator)
				{
					method_26(ref int_, ref int_2, bool_0);
				}
			}
		}
		else
		{
			method_18(ref int_, ref int_2, bool_0);
		}
		method_16();
		AddAlertBannerButton(bool_0);
		if (BXE != Rectangle.Empty)
		{
			if (bool_0)
			{
				Width = BXE.Width;
				Height = BXE.Height;
				Left = BXE.Left;
				Top = BXE.Top;
			}
		}
		else
		{
			int num3 = 0;
			int num4 = 0;
			foreach (Control control4 in method_12().Controls)
			{
				num3 = Math.Max(num3, control4.Right + 10);
				num4 = Math.Max(num4, control4.Bottom + 10);
			}
			if (Width != num3)
			{
				Width = num3;
			}
			if (num2 != 0 && num + num2 > num4)
			{
				if (Height != num + num2)
				{
					Height = num + num2;
				}
			}
			else if (Height != num4)
			{
				Height = num4;
			}
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
		if (BXc != null && BXc.method_28())
		{
			if (BXe != string.Empty)
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
		if (bool_0)
		{
			return;
		}
		bool flag = false;
		foreach (Control control5 in method_12().Controls)
		{
			if (!control5.Visible)
			{
				continue;
			}
			foreach (Control control6 in method_12().Controls)
			{
				if (control6 != control5 && control6.Visible && control6.Bounds.IntersectsWith(control5.Bounds))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				break;
			}
		}
		if (flag)
		{
			bool_0 = true;
			method_29();
		}
	}

	private const string AlertBannerButtonName = "ic7AlertBannerButton";

	private void AddAlertBannerButton(bool create)
	{
		if (BXD == null || BXb == null || BXb != Form23.framework_1 || BXb.awZ != 21 || BXb.awz != 11)
		{
			return;
		}
		SettingOrSpecialObject alarm = BXD;
		while (alarm != null && !(alarm is Class248))
		{
			alarm = alarm.method_6();
		}
		if (alarm == null)
		{
			return;
		}
		Setting message = NSP.UserInterface.AlertBannerEditor.AlarmTextSetting(alarm);
		if (message == null || !BXD.method_66().CurrentUIListSettingsIdsAndIndents.Any(item => item.DataId == message.method_64()))
		{
			return;
		}
		ThemedButton button = method_12().Controls[AlertBannerButtonName] as ThemedButton;
		if (button == null)
		{
			if (!create)
			{
				return;
			}
			button = new ThemedButton
			{
				Name = AlertBannerButtonName,
				Text = "Appearance...",
				AutoSize = true,
				Height = 24
			};
			button.Click += (_, _) => Form23.OpenAlertBannerEditor(NSP.UserInterface.AlertBannerEditor.AlarmText(alarm));
			method_12().Controls.Add(button);
		}
		int bottom = 0;
		foreach (Control control in method_12().Controls)
		{
			if (control != button && control.Visible)
			{
				bottom = Math.Max(bottom, control.Bottom);
			}
		}
		button.Left = 5;
		button.Top = bottom + 6;
	}

	private void method_16()
	{
		int num = int.MinValue;
		int num2 = int.MaxValue;
		foreach (Control control6 in method_12().Controls)
		{
			if (control6 is Control17)
			{
				Control17 control2 = (Control17)control6;
				if (control2.method_2() > num)
				{
					num = control2.method_2();
				}
				if (control2.method_2() < num2)
				{
					num2 = control2.method_2();
				}
			}
			else if (control6 is Control21)
			{
				Control21 control3 = (Control21)control6;
				if (control3.method_8() > num)
				{
					num = control3.method_8();
				}
				if (control3.method_8() < num2)
				{
					num2 = control3.method_8();
				}
			}
			else if (control6 is Control16)
			{
				Control16 control4 = (Control16)control6;
				if (control4.method_2() > num)
				{
					num = control4.method_2();
				}
				if (control4.method_2() < num2)
				{
					num2 = control4.method_2();
				}
			}
		}
		if (num2 == num || num == int.MinValue)
		{
			return;
		}
		foreach (Control control7 in method_12().Controls)
		{
			if (control7 is Control17)
			{
				((Control17)control7).method_6(num);
			}
			else if (control7 is Control21)
			{
				((Control21)control7).method_12(num);
			}
			else if (control7 is Control16)
			{
				((Control16)control7).method_5(num);
			}
		}
	}

	internal void method_17()
	{
		Control6 control = null;
		int num = 0;
		foreach (Control control4 in method_12().Controls)
		{
			if (control4.Visible)
			{
				int num2 = method_12().Height - 30 - control4.Bottom;
				num = ((num != 0) ? Math.Min(num, num2) : num2);
				if (control4 is Control6)
				{
					control = control4 as Control6;
				}
			}
		}
		if (num <= 0 || control == null)
		{
			return;
		}
		SuspendLayout();
		foreach (Control control5 in method_12().Controls)
		{
			if (control5.Visible && control5.Top > control.Top)
			{
				control5.Top += num;
			}
		}
		control.Height += num;
		ResumeLayout(performLayout: true);
	}

	private void method_18(ref int int_3, ref int int_4, bool bool_0)
	{
		Class146 @class = null;
		List<DataIdAndAttrId> list = new List<DataIdAndAttrId>();
		if (BXD != null)
		{
			@class = method_28(ref int_3, ref int_4, bool_0);
			foreach (UIListSettingDataIdAndIndent currentUIListSettingsIdsAndIndent in BXD.method_66().CurrentUIListSettingsIdsAndIndents)
			{
				if (Form23.class286_0 == null || Form23.list_0.Contains(currentUIListSettingsIdsAndIndent.DataId))
				{
					list.Add(new DataIdAndAttrId(currentUIListSettingsIdsAndIndent.DataId));
				}
			}
		}
		else if (BXd != null)
		{
			foreach (SettingOrSpecialObject item in BXd.method_1())
			{
				if (item is Setting setting && setting.method_68())
				{
					list.Add(setting.method_69());
				}
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			Setting setting2 = null;
			if (BXD != null)
			{
				setting2 = BXb.method_31(list[i].DataId);
			}
			else if (BXd != null)
			{
				setting2 = BXb.method_32(list[i]);
			}
			if (setting2 == null || setting2.method_219())
			{
				continue;
			}
			Class286 class286_ = null;
			bool flag = false;
			MenuNode menuNode = null;
			if (BXc != null)
			{
				menuNode = BXc.method_83(setting2);
			}
			if (menuNode != null)
			{
				class286_ = menuNode.method_80().BcF;
				if (!Form48.smethod_2() && setting2.method_122() && !setting2.method_76())
				{
					flag = menuNode.method_84();
				}
			}
			if (flag)
			{
				continue;
			}
			string text = setting2.method_64() + Class333.smethod_100() + setting2.method_67();
			Control control = null;
			if (!bool_0 && method_12().Controls.ContainsKey(text))
			{
				control = method_12().Controls[text];
			}
			if ((setting2.method_212() || setting2.method_220()) && !BXb.awX.ContainsKey(setting2.method_64()))
			{
				if (control == null)
				{
					continue;
				}
				int top = control.Top;
				method_12().Controls.Remove(control);
				int num = int.MaxValue;
				foreach (Control control14 in method_12().Controls)
				{
					if (control14.Top > top)
					{
						num = Math.Min(num, control14.Top);
					}
				}
				int num2 = num - top;
				foreach (Control control15 in method_12().Controls)
				{
					if (control15.Top > top)
					{
						control15.Top -= num2;
					}
				}
				continue;
			}
			int num3 = 0;
			if (BXD != null)
			{
				num3 = 18 * BXD.method_66().CurrentUIListSettingsIdsAndIndents[i].Indent;
			}
			if (setting2.method_207() && !setting2.method_204())
			{
				setting2.method_41(method_30);
				setting2.method_40(method_30);
				if (setting2.method_35() && PortFunction.smethod_52(setting2))
				{
					if (control == null)
					{
						Control10 control4 = new Control10(setting2.method_64(), bool_1: true, BXb, BXF);
						control4.Name = text;
						control4.Left = int_3 + num3;
						control4.Top = int_4;
						int_4 = control4.Bottom;
						method_12().Controls.Add(control4);
					}
					else
					{
						int_4 += control.Height;
					}
				}
				else if (control != null)
				{
					control.Dispose();
					control = null;
				}
			}
			else if (setting2.method_154() && !Form48.smethod_2())
			{
				if (control == null)
				{
					Control15 control5 = new Control15(setting2.method_69(), BXb, BXC, class286_, menuNode?.method_88() ?? false);
					control5.Name = text;
					if (BXb.aWZ.Contains(setting2.method_64()))
					{
						control5.method_4().Click += method_27;
					}
					control5.Left = int_3 + num3;
					control5.Top = int_4;
					int_4 = control5.Bottom;
					method_12().Controls.Add(control5);
				}
				else
				{
					int_4 += control.Height;
				}
				if (setting2.method_191() != 0 || setting2.method_193() != 0)
				{
					int_4 += 7;
				}
			}
			else if (setting2.method_159())
			{
				if (control == null)
				{
					Control12 control6 = new Control12(setting2.method_69(), BXb, BXC);
					control6.Name = text;
					control6.Left = int_3 + num3;
					control6.Top = int_4;
					int_4 = control6.Bottom;
					method_12().Controls.Add(control6);
				}
				else
				{
					int_4 += control.Height;
				}
			}
			else if (setting2.method_169())
			{
				if (control == null)
				{
					Control16 control7 = new Control16(setting2.method_69(), BXb, BXC, class286_);
					control7.Name = text;
					control7.Left = int_3 + num3;
					control7.Top = int_4;
					int_4 = control7.Bottom;
					method_12().Controls.Add(control7);
				}
				else
				{
					int_4 += control.Height;
				}
			}
			else if (setting2.method_171())
			{
				if (control == null)
				{
					Control14 control8 = new Control14(setting2.method_69(), BXb, BXC, class286_, menuNode?.method_88() ?? false, menuNode?.method_84() ?? false);
					control8.Name = text;
					control8.Left = int_3 + num3;
					control8.Top = int_4;
					int_4 = control8.Bottom + 2;
					method_12().Controls.Add(control8);
				}
				else
				{
					int_4 += control.Height + 2;
				}
			}
			else if (BXb.awX.ContainsKey(setting2.method_64()))
			{
				if ((Form48.smethod_2() || Class286.smethod_7(setting2)) && !Class286.smethod_5(setting2))
				{
					MenuNode menuNode_ = BXb.awX[setting2.method_64()];
					if (BXD.method_66().CurrentUIListSettingsIdsAndIndents[i].PlacePartialMapSearchableListDirectlyOnPanel)
					{
						if (control == null)
						{
							Control6 control9 = new Control6();
							control9.Name = text;
							control9.Size = new Size(1184, 350);
							control9.Left = int_3 + num3;
							control9.Top = int_4;
							control9.method_22(bool_4: true);
							control9.method_1(menuNode_);
							int_4 = control9.Bottom + 13;
							method_12().Controls.Add(control9);
						}
						else
						{
							int_4 += control.Height + 13;
						}
					}
					else if (BXD.method_66().CurrentUIListSettingsIdsAndIndents[i].PlacePartialMapImageGalleryDirectlyOnPanel)
					{
						if (control == null)
						{
							Control5 control10 = new Control5();
							control10.Name = text;
							control10.Left = int_3 + num3;
							control10.Top = int_4;
							control10.method_1(menuNode_);
							int_4 = control10.Bottom + 13;
							method_12().Controls.Add(control10);
						}
						else
						{
							int_4 += control.Height + 13;
						}
					}
					else if (control == null)
					{
						Class147 class2 = new Class147(setting2, this);
						class2.Tag = setting2.method_64();
						class2.Name = text;
						class2.Left = int_3 + num3;
						class2.Top = int_4;
						class2.method_0();
						int_4 = class2.Bottom;
						method_12().Controls.Add(class2);
					}
					else
					{
						(control as Class147).method_0();
						int_4 += control.Height;
					}
				}
				else if (control != null)
				{
					control.Dispose();
					control = null;
				}
			}
			else if (setting2.method_103().Count != 0)
			{
				if (setting2.method_293())
				{
					if (control == null)
					{
						Control18 control11 = new Control18(setting2.method_69(), BXb, BXC, class286_);
						control11.Name = text;
						control11.Left = int_3 + num3;
						control11.Top = int_4 + 2;
						int_4 = control11.Bottom + 13;
						method_12().Controls.Add(control11);
					}
					else
					{
						int_4 += control.Height + 13;
					}
				}
				else if (control == null)
				{
					Control17 control12 = new Control17(setting2.method_69(), BXb, BXC, class286_, menuNode?.method_88() ?? false, bool_3: true, bool_4: false);
					control12.Name = text;
					control12.Left = int_3 + num3;
					control12.Top = int_4 + 2;
					int_4 = control12.Bottom + 3;
					method_12().Controls.Add(control12);
				}
				else
				{
					int_4 += control.Height + 3;
				}
			}
			else if (control == null)
			{
				Control21 control13 = new Control21(setting2.method_69(), BXb, BXC, class286_, menuNode?.method_88() ?? false, menuNode?.method_84() ?? false, bool_4: false);
				control13.Name = text;
				control13.Left = int_3 + num3;
				control13.Top = int_4 + 2;
				int_4 = control13.Bottom + 3;
				method_12().Controls.Add(control13);
				if (@class != null && control13.method_27() != null)
				{
					@class.Height = control13.method_27().Height;
					@class.Left = Math.Max(@class.Left, control13.Left + control13.method_27().Left);
				}
			}
			else
			{
				int_4 += control.Height + 3;
			}
		}
	}

	private void method_19(ref int int_3, ref int int_4, bool bool_0)
	{
		foreach (SettingOrSpecialObject item in BXD.method_1())
		{
			if (!(item is Setting setting) || setting.method_219() || (Form23.class286_0 != null && !Form23.list_0.Contains(setting.method_64())))
			{
				continue;
			}
			Class286 class286_ = null;
			bool flag = false;
			MenuNode menuNode = null;
			if (BXc != null)
			{
				menuNode = BXc.method_83(setting);
			}
			if (menuNode != null)
			{
				class286_ = menuNode.method_80().BcF;
				if (!Form48.smethod_2() && setting.method_122() && !setting.method_76())
				{
					flag = menuNode.method_84();
				}
			}
			if (flag)
			{
				continue;
			}
			string text = setting.method_64() + Class333.smethod_100() + setting.method_67();
			Control control = null;
			if (!bool_0 && method_12().Controls.ContainsKey(text))
			{
				control = method_12().Controls[text];
			}
			if ((setting.method_212() || setting.method_220()) && !BXb.awX.ContainsKey(setting.method_64()))
			{
				if (control != null)
				{
					method_12().Controls.Remove(control);
				}
			}
			else if (setting.method_154() && !Form48.smethod_2())
			{
				if (control == null)
				{
					Control15 control2 = new Control15(setting.method_69(), BXb, BXC, class286_, menuNode?.method_88() ?? false);
					control2.Name = text;
					if (BXb.aWZ.Contains(setting.method_64()))
					{
						control2.method_4().Click += method_27;
					}
					control2.Left = int_3;
					control2.Top = int_4;
					int_4 = control2.Bottom;
					method_12().Controls.Add(control2);
				}
				else
				{
					int_4 += control.Height;
				}
				if (setting.method_191() != 0 || setting.method_193() != 0)
				{
					int_4 += 7;
				}
			}
			else if (setting.method_159())
			{
				if (control == null)
				{
					Control12 control3 = new Control12(setting.method_69(), BXb, BXC);
					control3.Name = text;
					control3.Left = int_3;
					control3.Top = int_4;
					int_4 = control3.Bottom;
					method_12().Controls.Add(control3);
				}
				else
				{
					int_4 += control.Height;
				}
			}
			else if (setting.method_169())
			{
				if (control == null)
				{
					Control16 control4 = new Control16(setting.method_69(), BXb, BXC, class286_);
					control4.Name = text;
					control4.Left = int_3;
					control4.Top = int_4;
					int_4 = control4.Bottom;
					method_12().Controls.Add(control4);
				}
				else
				{
					int_4 += control.Height;
				}
			}
			else if (setting.method_171())
			{
				if (control == null)
				{
					Control14 control5 = new Control14(setting.method_69(), BXb, BXC, class286_, menuNode?.method_88() ?? false, menuNode?.method_84() ?? false);
					control5.Name = text;
					control5.Left = int_3;
					control5.Top = int_4;
					int_4 = control5.Bottom + 2;
					method_12().Controls.Add(control5);
				}
				else
				{
					int_4 += control.Height + 2;
				}
			}
			else if (BXb.awX.ContainsKey(setting.method_64()))
			{
				if (Class286.smethod_7(setting) && !Class286.smethod_5(setting))
				{
					if (control == null)
					{
						Class147 @class = new Class147(setting, this);
						@class.Tag = setting.method_64();
						@class.Name = text;
						@class.Left = int_3;
						@class.Top = int_4;
						@class.method_0();
						int_4 = @class.Bottom;
						method_12().Controls.Add(@class);
					}
					else
					{
						(control as Class147).method_0();
						int_4 += control.Height;
					}
				}
				else if (control != null)
				{
					control.Dispose();
					control = null;
				}
			}
			else if (setting.method_103().Count != 0)
			{
				if (setting.method_293())
				{
					if (control == null)
					{
						Control18 control6 = new Control18(setting.method_69(), BXb, BXC, class286_);
						control6.Name = text;
						control6.Left = int_3;
						control6.Top = int_4 + 2;
						int_4 = control6.Bottom + 13;
						method_12().Controls.Add(control6);
					}
					else
					{
						int_4 += control.Height + 13;
					}
				}
				else if (control == null)
				{
					Control17 control7 = new Control17(setting.method_69(), BXb, BXC, class286_, menuNode?.method_88() ?? false, bool_3: true, bool_4: false);
					control7.Name = text;
					control7.Left = int_3;
					control7.Top = int_4 + 2;
					int_4 = control7.Bottom + 3;
					method_12().Controls.Add(control7);
				}
				else
				{
					int_4 += control.Height + 3;
				}
			}
			else if (control == null)
			{
				Control21 control8 = new Control21(setting.method_69(), BXb, BXC, class286_, menuNode?.method_88() ?? false, menuNode?.method_84() ?? false, bool_4: false);
				control8.Name = text;
				control8.Left = int_3;
				control8.Top = int_4 + 2;
				int_4 = control8.Bottom + 3;
				method_12().Controls.Add(control8);
			}
			else
			{
				int_4 += control.Height + 3;
			}
		}
	}

	private void method_20(ref int int_3, ref int int_4, bool bool_0)
	{
		if (BXD.method_55() != null)
		{
			method_21(ref int_3, ref int_4, bool_0, BXD.method_55());
			return;
		}
		foreach (string item in BXD.method_52())
		{
			method_22(ref int_3, ref int_4, bool_0, item);
		}
	}

	private void method_21(ref int int_3, ref int int_4, bool bool_0, string string_0)
	{
		Setting setting = BXD.method_1().First((SettingOrSpecialObject settingOrSpecialObject_0) => settingOrSpecialObject_0 is Setting && (settingOrSpecialObject_0 as Setting).method_154()) as Setting;
		if (!BXb.aWW.ErrorDefs.ContainsKey(string_0))
		{
			return;
		}
		Label label_ = null;
		foreach (ErrorPanelItem item in BXb.aWW.ErrorPanel)
		{
			switch (item.Type)
			{
			case DataTableColumnType.Enum:
			{
				if (int.TryParse(BXb.aWW.ErrorDefs[string_0][Class333.smethod_1087()], out var result) && item.DataId != -1)
				{
					Control17 control = new Control17(new DataIdAndAttrId(item.DataId), int_1: BXb.aWW.ErrorToSettingMap[result], framework_2: BXb, framework_3: BXC, class286_0: null, bool_2: false, bool_3: true, bool_4: false, int_2: setting.method_64(), label_0: label_);
					control.Left = int_3;
					control.Top = int_4;
					int_4 = control.Bottom + 5;
					if (bool_0)
					{
						method_12().Controls.Add(control);
					}
					else
					{
						control.Dispose();
					}
				}
				break;
			}
			case DataTableColumnType.Text:
				if (BXb.aWW.ErrorDefs[string_0].ContainsKey(item.ErrorDefKey))
				{
					string text = BXb.aWW.ErrorDefs[string_0][item.ErrorDefKey];
					Label label = new Label();
					label.Text = item.Text + text;
					label.ForeColor = (setting.method_35() ? Form23.color_12 : Form23.color_36);
					label.Left = int_3;
					label.Top = int_4 + 3;
					label.Height = (int)((float)label.Height * 0.7f);
					label.Width = 300;
					int_4 = label.Bottom + 5;
					label_ = label;
					if (bool_0)
					{
						method_12().Controls.Add(label);
					}
					else
					{
						label.Dispose();
					}
				}
				break;
			}
		}
	}

	private void method_22(ref int int_3, ref int int_4, bool bool_0, string string_0)
	{
		Label label = new Label();
		label.Text = Class333.BgN() + string_0;
		label.ForeColor = Form23.color_12;
		label.Left = int_3;
		label.Top = int_4 + 3;
		label.Height = (int)((float)label.Height * 0.7f);
		label.Width = 300;
		int_4 = label.Bottom + 5;
		if (bool_0)
		{
			method_12().Controls.Add(label);
		}
		else
		{
			label.Dispose();
		}
		if (!BXb.aWv.ContainsKey(string_0))
		{
			return;
		}
		foreach (SettingOrSpecialObject item in BXb.aWv[string_0].method_1())
		{
			if (!(item is Setting) || !(item.method_2() == Class333.smethod_1137()))
			{
				continue;
			}
			Setting setting = item as Setting;
			Class286 class286_ = null;
			bool flag = false;
			MenuNode menuNode = null;
			if (BXc != null)
			{
				menuNode = BXc.method_83(setting);
			}
			if (menuNode != null)
			{
				class286_ = menuNode.method_80().BcF;
				if (!Form48.smethod_2() && setting.method_122() && !setting.method_76())
				{
					flag = menuNode.method_84();
				}
			}
			if (!flag)
			{
				Control17 control = new Control17(setting.method_69(), BXb, BXC, class286_, menuNode?.method_88() ?? false, bool_3: true, bool_4: false);
				control.Left = int_3;
				control.Top = int_4;
				int_4 = control.Bottom + 5;
				if (bool_0)
				{
					method_12().Controls.Add(control);
				}
				else
				{
					control.Dispose();
				}
			}
			break;
		}
	}

	private int method_23(ref int int_3, ref int int_4, bool bool_0)
	{
		int num;
		int num2;
		if (BXD.method_67().FixedCountValue != 0)
		{
			num = BXD.method_67().FixedCountValue;
			num2 = BXD.method_67().FixedCountValue;
		}
		else
		{
			Setting setting;
			if (Form23.enum60_0 == Form23.Enum60.BpG && BXC != null)
			{
				setting = BXC.method_31(BXD.method_67().DataIdOfListCountSetting);
				if (setting == null)
				{
					setting = BXb.method_31(BXD.method_67().DataIdOfListCountSetting);
				}
			}
			else
			{
				setting = BXb.method_31(BXD.method_67().DataIdOfListCountSetting);
			}
			num = setting.method_256();
			num2 = setting.method_229();
			if (num > num2 && num2 != 0)
			{
				num = num2;
			}
			if (num2 == 0)
			{
				num2 = num;
			}
		}
		if (BXf != num && !bool_0)
		{
			int num3 = method_12().Controls.Count;
			int num4 = 0;
			while (num4 < num3)
			{
				Control control = method_12().Controls[num4];
				if (control.Tag is bool && (bool)control.Tag)
				{
					control.Dispose();
					num3--;
				}
				else
				{
					num4++;
				}
			}
		}
		bool[] array = new bool[BXD.method_67().DataIdsOfListSettings.Count];
		bool[] array2 = new bool[num2];
		bool[] array3 = new bool[BXD.method_67().DataIdsOfListSettings.Count];
		bool[] array4 = new bool[num2];
		List<Label> list = new List<Label>();
		int num5 = int_4;
		for (int i = 0; i <= BXD.method_67().DataIdsOfListSettings.Count; i++)
		{
			Label label = null;
			for (int j = 0; j <= num2; j++)
			{
				Label label2 = null;
				if (i == 0)
				{
					if (j != 0)
					{
						if ((BXf != num) | bool_0)
						{
							if (j <= num)
							{
								label2 = new Label();
								label2.Name = Class333.Bgn() + j;
								label2.Tag = true;
								label2.Text = BXD.method_67().GetListLabelString(j);
								label2.ForeColor = Form23.color_12;
								label2.Left = int_3;
								label2.Top = int_4 + 3;
								label2.Height = (int)((float)label2.Height * 0.7f);
								label2.Width = 70;
								method_12().Controls.Add(label2);
							}
						}
						else if (!bool_0 && method_12().Controls.ContainsKey(Class333.Bgn() + j))
						{
							label2 = (Label)method_12().Controls[Class333.Bgn() + j];
						}
						if (label2 != null)
						{
							list.Add(label2);
						}
					}
				}
				else
				{
					int num6 = BXD.method_67().DataIdsOfListSettings[i - 1];
					Setting setting2 = BXb.method_31(num6);
					if (j == 0)
					{
						if ((BXf != num) | bool_0)
						{
							label = new Label();
							label.Name = Class333.BgO() + i;
							label.Tag = true;
							label.TextAlign = ContentAlignment.BottomLeft;
							string text = setting2.method_60(Enum96.aYv);
							if (string.IsNullOrEmpty(text))
							{
								text = setting2.method_60(Enum96.aYu);
							}
							string text2 = (string.IsNullOrEmpty(text) ? setting2.method_60(Enum96.aYt) : text);
							int num7 = setting2.method_231();
							if (num7 != 0 && num7 != 82)
							{
								text2 = text2 + Class333.smethod_497() + Class233.smethod_35(setting2.method_232(), num7, bool_0: false, 0) + Class333.smethod_9();
							}
							label.Text = text2;
							label.ForeColor = Form23.color_12;
							label.Left = int_3;
							label.Top = int_4 - 7;
							label.Height = 2 * (int)((float)label.Height * 0.7f);
							label.Width = 80;
							method_12().Controls.Add(label);
						}
						else if (!bool_0 && method_12().Controls.ContainsKey(Class333.BgO() + i))
						{
							label = (Label)method_12().Controls[Class333.BgO() + i];
						}
					}
					else
					{
						Class286 class286_ = null;
						bool flag = false;
						MenuNode menuNode = null;
						if (BXc != null)
						{
							menuNode = BXc.method_83(setting2);
						}
						if (menuNode != null)
						{
							class286_ = menuNode.method_80().BcF;
							if (!Form48.smethod_2() && setting2.method_122() && !setting2.method_76())
							{
								flag = menuNode.method_84();
							}
						}
						if (!flag && (Form23.class286_0 == null || Form23.list_0.Contains(num6)))
						{
							if (setting2.method_103().Count != 0)
							{
								Control13 control2 = null;
								string text3 = Class333.Bgo() + j + Class333.BgP() + i;
								if ((BXf != num) | bool_0)
								{
									if (j <= num && !setting2.method_212() && !setting2.method_220())
									{
										control2 = new Control13(new DataIdAndAttrId(num6), bool_2: true, j - 1, BXb, BXC, class286_, menuNode?.method_88() ?? false);
										control2.Name = text3;
										control2.Tag = true;
										control2.Left = int_3;
										control2.Top = int_4;
										method_12().Controls.Add(control2);
									}
								}
								else if (!bool_0 && method_12().Controls.ContainsKey(text3))
								{
									control2 = (Control13)method_12().Controls[text3];
								}
								if (control2 != null)
								{
									array[i - 1] = true;
									array2[j - 1] = true;
									if (control2.method_3().Enabled)
									{
										array3[i - 1] = true;
										array4[j - 1] = true;
									}
								}
							}
							else
							{
								Control20 control3 = null;
								string text4 = Class333.Bgp() + j + Class333.BgP() + i;
								if ((BXf != num) | bool_0)
								{
									if (j <= num && !setting2.method_212() && !setting2.method_220())
									{
										control3 = new Control20(new DataIdAndAttrId(num6), bool_2: true, j - 1, BXb, BXC, class286_, menuNode?.method_88() ?? false);
										control3.Name = text4;
										control3.Tag = true;
										control3.Left = int_3;
										control3.Top = int_4;
										method_12().Controls.Add(control3);
									}
								}
								else if (!bool_0 && method_12().Controls.ContainsKey(text4))
								{
									control3 = (Control20)method_12().Controls[text4];
								}
								if (control3 != null)
								{
									array[i - 1] = true;
									array2[j - 1] = true;
									if (control3.method_2().Enabled)
									{
										array3[i - 1] = true;
										array4[j - 1] = true;
									}
								}
							}
						}
					}
				}
				int_4 += 28;
			}
			if (label != null && i != 0 && method_12().Controls.Contains(label))
			{
				if (!array[i - 1])
				{
					label.Dispose();
				}
				else if (array3[i - 1])
				{
					label.ForeColor = Form23.color_12;
				}
				else
				{
					label.ForeColor = Form23.color_36;
				}
			}
			int_3 += 100;
			int_4 = num5;
		}
		for (int k = 0; k < list.Count; k++)
		{
			Label label3 = list[k];
			if (method_12().Controls.Contains(label3))
			{
				if (!array2[k])
				{
					label3.Dispose();
				}
				else if (array4[k])
				{
					label3.ForeColor = Form23.color_12;
				}
				else
				{
					label3.ForeColor = Form23.color_36;
				}
			}
		}
		BXf = num;
		return (1 + num2) * 28 + 10;
	}

	private void method_24(ref int int_3, ref int int_4, bool bool_0)
	{
		int num = 0;
		for (int i = 0; i < BXD.method_1().Count; i++)
		{
			SettingOrSpecialObject settingOrSpecialObject = BXD.method_1()[i];
			if (settingOrSpecialObject is SpecialObject)
			{
				num = Math.Max((settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count, num);
			}
		}
		bool[] array = new bool[num];
		bool[] array2 = new bool[BXD.method_1().Count];
		bool[] array3 = new bool[num];
		bool[] array4 = new bool[BXD.method_1().Count];
		bool[] array5 = new bool[num];
		int[] array6 = new int[num];
		Label[] array7 = new Label[num];
		for (int j = 0; j <= BXD.method_1().Count; j++)
		{
			Label label = null;
			if (j != 0)
			{
				SettingOrSpecialObject settingOrSpecialObject2 = BXD.method_1()[j - 1];
				if (settingOrSpecialObject2 is SpecialObject)
				{
					for (int k = 0; k <= (settingOrSpecialObject2 as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count; k++)
					{
						Label label2 = null;
						if (k == 0)
						{
							if (bool_0)
							{
								label = new Label();
								label.Name = Class333.Bgn() + j;
								label.Text = BXD.method_67().GetListLabelString(j);
								label.ForeColor = Form23.color_12;
								label.Left = int_3;
								label.Top = int_4 + 3;
								label.Height = (int)((float)label.Height * 0.7f);
								label.Width = 80;
								method_12().Controls.Add(label);
							}
							else if (method_12().Controls.ContainsKey(Class333.Bgn() + j))
							{
								label = (Label)method_12().Controls[Class333.Bgn() + j];
								label.Left = int_3;
								label.Top = int_4 + 3;
							}
							int_3 += 100;
							continue;
						}
						Setting setting = BXb.method_31((settingOrSpecialObject2 as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents[k - 1].DataId);
						if (setting == null)
						{
							continue;
						}
						if (j == 1)
						{
							if (bool_0)
							{
								label2 = new Label();
								label2.Name = Class333.BgO() + k;
								label2.TextAlign = ContentAlignment.BottomLeft;
								string text = setting.method_60(Enum96.aYv);
								if (string.IsNullOrEmpty(text))
								{
									text = setting.method_60(Enum96.aYu);
								}
								string text2 = (string.IsNullOrEmpty(text) ? setting.method_60(Enum96.aYt) : text);
								int num2 = setting.method_231();
								if (num2 != 0 && num2 != 82)
								{
									text2 = text2 + Class333.smethod_497() + Class233.smethod_35(setting.method_232(), num2, bool_0: false, 0) + Class333.smethod_9();
								}
								label2.Text = text2;
								label2.ForeColor = Form23.color_12;
								label2.Left = int_3;
								label2.Top = int_4 - 37;
								label2.Height = 2 * (int)((float)label2.Height * 0.7f);
								label2.Width = 80;
								method_12().Controls.Add(label2);
							}
							else if (method_12().Controls.ContainsKey(Class333.BgO() + k))
							{
								label2 = (Label)method_12().Controls[Class333.BgO() + k];
								label2.Left = int_3;
								label2.Top = int_4 - 37;
							}
							if (label2 != null)
							{
								array7[k - 1] = label2;
								array6[k - 1] = Math.Max(array6[k - 1], label2.Width);
							}
						}
						Class286 class286_ = null;
						bool flag = false;
						MenuNode menuNode = null;
						if (BXc != null)
						{
							menuNode = BXc.method_83(setting);
						}
						if (menuNode != null)
						{
							class286_ = menuNode.method_80().BcF;
							if (!Form48.smethod_2() && setting.method_122() && !setting.method_76())
							{
								flag = menuNode.method_84();
							}
						}
						bool flag2 = Form23.class286_0 != null && !Form23.list_0.Contains(setting.method_64());
						bool flag3 = !setting.method_219() && !flag && !flag2 && ((!setting.method_212() && !setting.method_220()) || BXb.awX.ContainsKey(setting.method_64()));
						if (BXb.awX.ContainsKey(setting.method_64()))
						{
							string text3 = Class333.BgQ() + j + Class333.BgP() + k;
							Class147 @class = null;
							if (method_12().Controls.ContainsKey(text3))
							{
								@class = (Class147)method_12().Controls[text3];
							}
							if (Class286.smethod_7(setting) && !Class286.smethod_5(setting))
							{
								if (@class == null)
								{
									@class = new Class147(setting, this);
									@class.Tag = setting.method_64();
									@class.Name = text3;
									@class.Left = int_3;
									@class.Top = int_4 - 1;
									if (flag3)
									{
										method_12().Controls.Add(@class);
									}
								}
								else
								{
									@class.Left = int_3;
									@class.Top = int_4 - 1;
								}
								@class.method_0();
								@class.Enabled = setting.method_35() && BXb.method_4() && Form23.enum60_0 != Form23.Enum60.BpG;
								int_3 += @class.Width + 30;
								array6[k - 1] = Math.Max(array6[k - 1], @class.Width + 30);
								if (flag3)
								{
									array[k - 1] = true;
									array2[j - 1] = true;
									if (@class.Enabled)
									{
										array3[k - 1] = true;
										array4[j - 1] = true;
									}
								}
								array5[k - 1] = true;
							}
							else
							{
								@class?.Dispose();
							}
							continue;
						}
						if (setting.method_103().Count != 0)
						{
							Control13 control = null;
							string text4 = Class333.Bgo() + j + Class333.BgP() + k;
							if (bool_0)
							{
								control = new Control13(setting.method_69(), bool_2: false, 0, BXb, BXC, class286_, menuNode?.method_88() ?? false);
								control.Name = text4;
								control.Left = int_3;
								control.Top = int_4;
								if (flag3)
								{
									method_12().Controls.Add(control);
								}
							}
							else if (method_12().Controls.ContainsKey(text4))
							{
								control = (Control13)method_12().Controls[text4];
								control.Left = int_3;
								control.Top = int_4;
							}
							int_3 += 200;
							array6[k - 1] = Math.Max(array6[k - 1], 200);
							if (flag3 && control != null)
							{
								array[k - 1] = true;
								array2[j - 1] = true;
								if (control.method_3().Enabled)
								{
									array3[k - 1] = true;
									array4[j - 1] = true;
								}
							}
							continue;
						}
						Control20 control2 = null;
						string text5 = Class333.Bgp() + j + Class333.BgP() + k;
						if (bool_0)
						{
							control2 = new Control20(setting.method_69(), bool_2: false, 0, BXb, BXC, class286_, menuNode?.method_88() ?? false);
							control2.Name = text5;
							control2.Left = int_3;
							control2.Top = int_4;
							if (flag3)
							{
								method_12().Controls.Add(control2);
							}
						}
						else if (method_12().Controls.ContainsKey(text5))
						{
							control2 = (Control20)method_12().Controls[text5];
							control2.Left = int_3;
							control2.Top = int_4;
						}
						int_3 += 100;
						array6[k - 1] = Math.Max(array6[k - 1], 100);
						if (flag3 && control2 != null)
						{
							array[k - 1] = true;
							array2[j - 1] = true;
							if (control2.method_2().Enabled)
							{
								array3[k - 1] = true;
								array4[j - 1] = true;
							}
						}
					}
				}
				if (label != null && j != 0)
				{
					if (array4[j - 1])
					{
						label.ForeColor = Form23.color_12;
					}
					else
					{
						label.ForeColor = Form23.color_36;
					}
					label.Visible = array2[j - 1];
				}
			}
			int_3 = 5;
			int_4 += 28;
		}
		for (int l = 0; l < array7.Length; l++)
		{
			Label label3 = array7[l];
			if (label3 != null)
			{
				if (array3[l])
				{
					label3.ForeColor = Form23.color_12;
				}
				else
				{
					label3.ForeColor = Form23.color_36;
				}
				label3.Visible = array[l];
				if (array5[l])
				{
					label3.Visible = false;
				}
			}
			for (int m = 0; m < l; m++)
			{
				if (array[m])
				{
					continue;
				}
				int num3 = array6[m];
				if (method_12().Controls.ContainsKey(Class333.BgO() + (l + 1)))
				{
					method_12().Controls[Class333.BgO() + (l + 1)].Left -= num3;
				}
				for (int n = 1; n <= BXD.method_1().Count; n++)
				{
					if (method_12().Controls.ContainsKey(Class333.BgQ() + n + Class333.BgP() + (l + 1)))
					{
						method_12().Controls[Class333.BgQ() + n + Class333.BgP() + (l + 1)].Left -= num3;
					}
					if (method_12().Controls.ContainsKey(Class333.Bgo() + n + Class333.BgP() + (l + 1)))
					{
						method_12().Controls[Class333.Bgo() + n + Class333.BgP() + (l + 1)].Left -= num3;
					}
					if (method_12().Controls.ContainsKey(Class333.Bgp() + n + Class333.BgP() + (l + 1)))
					{
						method_12().Controls[Class333.Bgp() + n + Class333.BgP() + (l + 1)].Left -= num3;
					}
				}
			}
		}
	}

	private void method_25(bool bool_0)
	{
		if (bool_0)
		{
			Class144 value = new Class144(BXD, BXb, new Rectangle(0, 0, 900, 400));
			method_12().Controls.Add(value);
			return;
		}
		foreach (Control control in method_12().Controls)
		{
			if (control is Class144)
			{
				(control as Class144).method_4();
				break;
			}
		}
	}

	private void method_26(ref int int_3, ref int int_4, bool bool_0)
	{
		Setting setting = BXb.method_31(BXD.method_69().ThresholdSettingId);
		if (setting == null)
		{
			return;
		}
		bool flag = false;
		if (!Form48.smethod_2() && setting.method_122() && !setting.method_76())
		{
			MenuNode menuNode = null;
			if (BXc != null)
			{
				menuNode = BXc.method_83(setting);
			}
			if (menuNode != null && menuNode.method_84())
			{
				flag = true;
			}
		}
		if (!flag && (Form23.class286_0 == null || Form23.list_0.Contains(setting.method_64())))
		{
			Control7 control = new Control7(BXD.method_69(), BXb, BXC);
			control.Left = int_3;
			control.Top = int_4;
			int_4 = control.Bottom + 5;
			if (bool_0)
			{
				method_12().Controls.Add(control);
			}
			else
			{
				control.Dispose();
			}
		}
	}

	private void method_27(object sender, EventArgs e)
	{
		LinkLabel linkLabel = sender as LinkLabel;
		if (linkLabel.Tag is int)
		{
			Setting setting = BXb.method_31((int)linkLabel.Tag);
			TreeNode treeNode = Form23.form23_0.control4_0.method_63(Form23.form23_0.control4_0.method_0().method_2(), setting.method_69(), bool_7: false);
			if (treeNode != null)
			{
				Form23.form23_0.control4_0.method_0().method_4(treeNode);
			}
		}
	}

	private Class146 method_28(ref int int_3, ref int int_4, bool bool_0)
	{
		Class146 @class = null;
		if (BXD.method_66().ShowCalibrateAllButton && Form23.class286_0 == null)
		{
			if (!bool_0 && method_12().Controls.ContainsKey(Class333.Bgq()))
			{
				@class = method_12().Controls[Class333.Bgq()] as Class146;
			}
			if (@class == null)
			{
				@class = new Class146(this);
				@class.Name = Class333.Bgq();
				@class.Top = 0;
				if (method_12().Controls.ContainsKey(Class333.BeG()))
				{
					@class.Left = method_12().Controls[Class333.BeG()].Right;
				}
				else
				{
					@class.Left = 5;
				}
				if (!(BXe != string.Empty))
				{
					int_4 = @class.Bottom + 3;
				}
				method_12().Controls.Add(@class);
			}
			else if (!(BXe != string.Empty))
			{
				int_4 += @class.Height + 3;
			}
		}
		return @class;
	}

	private void method_29()
	{
		method_31();
		while (method_12().Controls.Count != 0)
		{
			Class30.smethod_0(method_12().Controls[0]);
		}
		if (BXE != Rectangle.Empty)
		{
			BXE = new Rectangle(Location, Size);
		}
		method_15(bool_0: true);
	}

	private void method_30(object sender, EventArgs e)
	{
		method_29();
	}

	public Control imethod_0(DataIdAndAttrId dataIdAndAttrId_0)
	{
		foreach (Control control3 in method_12().Controls)
		{
			if (control3 is Control7)
			{
				Control7 control2 = control3 as Control7;
				if (control2.method_1().method_69() == dataIdAndAttrId_0)
				{
					return control2.method_3();
				}
				if (control2.method_2().method_69() == dataIdAndAttrId_0)
				{
					return control2.method_4();
				}
			}
			else if ((control3 is Control21 && (control3 as Control21).method_0().method_69() == dataIdAndAttrId_0) || (control3 is Control17 && (control3 as Control17).method_0().method_69() == dataIdAndAttrId_0) || (control3 is Control15 && (control3 as Control15).method_0().method_69() == dataIdAndAttrId_0) || (control3 is Control16 && (control3 as Control16).method_0().method_69() == dataIdAndAttrId_0) || (control3 is Control18 && (control3 as Control18).method_0().method_69() == dataIdAndAttrId_0) || (control3 is Control20 && (control3 as Control20).method_0().method_69() == dataIdAndAttrId_0) || (control3 is Control13 && (control3 as Control13).method_0().method_69() == dataIdAndAttrId_0))
			{
				return control3;
			}
		}
		return null;
	}

	public Control imethod_1()
	{
		foreach (Control control in method_12().Controls)
		{
			if (!(control is Label))
			{
				return control;
			}
		}
		return null;
	}

	private void method_31()
	{
		foreach (Control control3 in method_12().Controls)
		{
			if (control3 is Control15)
			{
				Control15 control2 = control3 as Control15;
				if (BXb.aWZ.Contains(control2.method_0().method_64()))
				{
					control2.method_4().Click -= method_27;
				}
			}
		}
		if (BXD != null)
		{
			for (int i = 0; i < BXD.method_66().CurrentUIListSettingsIdsAndIndents.Count; i++)
			{
				BXb.method_31(BXD.method_66().CurrentUIListSettingsIdsAndIndents[i].DataId)?.method_41(method_30);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			method_31();
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
