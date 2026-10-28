using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
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

internal class Class115 : Class109, Interface3
{
	private delegate void Delegate35(object sender, EventArgs e);

	private delegate void Delegate36(object sender, EventArgs e);

	private delegate void Delegate37(object sender, EventArgs e);

	private delegate void Delegate38(object sender, EventArgs e);

	private const int BWh = 5;

	private const int BWI = 5;

	private const int BWi = 6;

	private const int BWJ = 0;

	private const int BWj = 48;

	private const int BWK = 400;

	private const int BWk = 80;

	private const int BWL = 42;

	private const int BWl = 4;

	private const int BWM = 250;

	private int BWm;

	private Framework BWN;

	private Framework BWn;

	private SettingOrSpecialObject BWO;

	private Setting BWo;

	private Setting BWP;

	private MenuNode BWp;

	private Class131 BWQ = new Class131();

	private List<Label> BWq = new List<Label>();

	private List<List<string>> BWR = new List<List<string>>();

	private List<List<int>> BWr = new List<List<int>>();

	private List<Class244> BWS = new List<Class244>();

	private Class148 BWs = new Class148();

	private PictureBox BWT = new PictureBox();

	private Label BWt = new Label();

	private Label BWU = new Label();

	private HashSet<Setting> BWu = new HashSet<Setting>();

	private Rectangle BWV;

	private static Class118 BWv;

	internal Class115(SettingOrSpecialObject settingOrSpecialObject_0, MenuNode menuNode_0, Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false)
	{
		BWO = settingOrSpecialObject_0;
		BWN = framework_0;
		BWn = framework_1;
		BWp = menuNode_0;
		BWo = null;
		if (BWp.method_22() != 0 && (Form23.class286_0 == null || Form23.list_0.Contains(BWp.method_22())))
		{
			BWo = BWN.method_31(BWp.method_22());
			if (BWn != null)
			{
				BWP = BWn.method_31(BWp.method_22());
			}
		}
		BWV = rectangle_0;
		Class1.smethod_12(method_26);
		Form23.smethod_30(method_26);
		Form23.form23_0.method_9(method_16);
		foreach (WiringPin item in BWN.awc)
		{
			if (item.method_13())
			{
				BWu.Add(BWN.method_31(item.Bbx));
			}
		}
		foreach (Setting item2 in BWu)
		{
			item2.method_264(method_43);
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (BWp.method_22() != 0)
			{
				BWs.CheckedChanged -= BWs_CheckedChanged;
				if (BWo != null)
				{
					BWo.method_265(method_19);
				}
			}
			foreach (Control control3 in method_12().Controls)
			{
				if (control3 is PictureBox && BWp.method_22() != 0)
				{
					(control3 as PictureBox).Click -= BWT_Click;
				}
			}
			foreach (Class244 bW in BWS)
			{
				bW.method_265(method_17);
				bW.method_41(method_18);
			}
			BWS.Clear();
			if (BWQ.Controls.Count != 0)
			{
				foreach (Control control4 in BWQ.Controls)
				{
					foreach (Control control5 in control4.Controls)
					{
						if (control5 is Button)
						{
							(control5 as Button).Click -= method_44;
							(control5 as Button).Click -= method_46;
							(control5 as Button).Click -= method_45;
							Class244 @class = null;
							if ((control5 as Button).Tag is int)
							{
								@class = BWN.method_31((int)(control5 as Button).Tag) as Class244;
							}
							if (@class != null)
							{
								@class.method_265(method_17);
								@class.method_41(method_18);
							}
							if (BWn != null)
							{
								@class = null;
								if ((control5 as Button).Tag is int)
								{
									@class = BWn.method_31((int)(control5 as Button).Tag) as Class244;
								}
								if (@class != null)
								{
									@class.method_265(method_17);
									@class.method_41(method_18);
								}
							}
						}
						else if (control5 is Label && control5.Name != null && control5.Name == Class333.BGw())
						{
							control5.MouseEnter -= method_36;
							control5.MouseLeave -= method_37;
						}
						else if (control5 is PictureBox && control5.Name != null && control5.Name == Class333.BGX())
						{
							control5.Click -= method_35;
							control5.MouseEnter -= method_36;
							if (Form23.pictureBox_1 == control5)
							{
								Form23.pictureBox_1 = null;
							}
						}
					}
				}
			}
			foreach (Label item in BWq)
			{
				SettingOrSpecialObject settingOrSpecialObject = (item.Tag as SettingOrSpecialObject[])[0];
				for (int i = 0; i < settingOrSpecialObject.method_12().method_1().Count; i++)
				{
					settingOrSpecialObject.method_12().method_1()[i].method_265(method_27);
				}
			}
			Class1.smethod_13(method_26);
			Form23.smethod_31(method_26);
			Form23.form23_0.method_10(method_16);
			foreach (Setting item2 in BWu)
			{
				item2.method_265(method_43);
			}
			BWu.Clear();
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public Control imethod_0(DataIdAndAttrId dataIdAndAttrId_0)
	{
		foreach (Control control in method_12().Controls)
		{
			if ((control is Control21 && (control as Control21).method_0().method_69() == dataIdAndAttrId_0) || (control is Control17 && (control as Control17).method_0().method_69() == dataIdAndAttrId_0) || (control is Control15 && (control as Control15).method_0().method_69() == dataIdAndAttrId_0))
			{
				return control;
			}
		}
		return null;
	}

	public Control imethod_1()
	{
		foreach (Control control in method_12().Controls)
		{
			if (control is Control21 || control is Control17 || control is Control15)
			{
				return control;
			}
		}
		return null;
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		if (resizingOnly)
		{
			method_23(bool_0: false);
			return;
		}
		method_12().Controls.Clear();
		method_23(bool_0: true);
	}

	[SpecialName]
	internal Setting method_15()
	{
		return BWo;
	}

	private void method_16(object sender, EventArgs e)
	{
		method_23(bool_0: false);
	}

	private void method_17(object sender, EventArgs e)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			method_23(bool_0: false);
			Form23.smethod_74((sender as Class244).method_64());
		}
	}

	private void method_18(object sender, EventArgs e)
	{
		method_23(bool_0: false);
	}

	private void BWs_CheckedChanged(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BWN.method_4() || BWO == null)
		{
			return;
		}
		Class148 @class = sender as Class148;
		Setting setting = BWN.method_31((int)@class.Tag);
		if (!Form23.bool_2)
		{
			if (@class.Checked)
			{
				Setting setting_ = null;
				MenuNode menuNode = null;
				string text = setting.method_47();
				if (text == null)
				{
					menuNode = BWp;
					if (menuNode != null)
					{
						text = menuNode.method_64();
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
						setting.method_272(1, bool_0: true);
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
					setting.method_272(1, bool_0: true);
				}
				if (@class.Checked)
				{
					PortFunction.smethod_20(BWO, bool_0: false);
					class2?.method_4();
				}
			}
			else
			{
				Class280 class3 = Form23.smethod_95();
				class3?.method_2(setting.method_64());
				setting.method_272(0, bool_0: true);
				BWT.Visible = false;
				class3?.method_4();
			}
		}
		Form23.smethod_74(setting.method_64());
	}

	private void method_19(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate35 method = method_19;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.enum60_0 != Form23.Enum60.BpG && BWs.Checked != (BWo.method_256() == 1))
		{
			BWs.Checked = BWo.method_256() == 1;
		}
	}

	private void BWT_Click(object sender, EventArgs e)
	{
		PictureBox pictureBox = sender as PictureBox;
		Form23.smethod_50(BWN.method_31((int)pictureBox.Tag), pictureBox);
	}

	private bool method_20()
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG && BWP != null)
		{
			if (BWn.method_2() && BWn.method_3())
			{
				return BWP.method_96();
			}
			return false;
		}
		if (BWN.method_2() && BWN.method_3())
		{
			return BWo.method_96();
		}
		return false;
	}

	private void method_21()
	{
		string text = ((!(Parent is Class118)) ? BWp.method_100(bool_0: false, bool_1: false) : BWp.method_10());
		if (Form23.enum60_0 == Form23.Enum60.BpG && BWP != null)
		{
			BWs.bool_0 = true;
			BWs.Enabled = false;
			if (BWs.Checked != (BWP.method_256() == 1))
			{
				BWs.Checked = !BWs.Checked;
			}
			if (method_20())
			{
				BWs.Text = Class333.BGx() + text + Class333.BGY();
			}
			else
			{
				BWs.Text = text;
			}
		}
		else if (method_20())
		{
			BWs.bool_0 = true;
			BWs.Enabled = false;
			if (BWs.Checked != (BWo.method_256() == 1))
			{
				BWs.Checked = !BWs.Checked;
			}
			BWs.Text = Class333.BGx() + text + Class333.BGY();
		}
		else
		{
			BWs.bool_0 = false;
			BWs.Enabled = BWN.method_4();
			if (BWs.Checked != (BWo.method_256() == 1))
			{
				BWs.Checked = !BWs.Checked;
			}
			BWs.Text = text;
		}
	}

	private void method_22()
	{
		if (BWo.method_35() && !BWo.method_122())
		{
			switch (BWo.method_124())
			{
			default:
				BWT.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Error:
				BWT.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Warning:
				BWT.Image = GeneralResources.YellowWarning;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (Form23.smethod_28(BWN.aXc, bool_53: true))
				{
					BWT.Image = GeneralResources.RedError;
				}
				else
				{
					BWT.Image = GeneralResources.YellowWarning;
				}
				break;
			}
			BWT.Visible = true;
		}
		else
		{
			BWT.Visible = false;
			BWT.Image = GeneralResources.QuestionMark;
		}
	}

	internal void method_23(bool bool_0)
	{
		if (BWO == null)
		{
			return;
		}
		SuspendLayout();
		method_12().SuspendLayout();
		int int_ = 5;
		int num = 5;
		string text = ((!(Parent is Class118)) ? BWp.method_100(bool_0: false, bool_1: false) : BWp.method_10());
		if (BWo != null)
		{
			if (!bool_0)
			{
				if (!BWo.method_219())
				{
					method_21();
					method_22();
					num = BWs.Bottom + 6;
				}
				else
				{
					method_22();
					num = BWT.Bottom + 6;
				}
			}
			else
			{
				if (!BWo.method_219())
				{
					BWs.Enabled = BWN.method_4();
					BWs.Font = new Font(BWs.Font.FontFamily, 10f, FontStyle.Bold);
					BWs.ForeColor = Form23.color_14;
					method_21();
					BWs.Left = int_;
					BWs.Top = num;
					BWs.AutoSize = true;
					BWs.Tag = BWo.method_64();
					BWs.CheckedChanged += BWs_CheckedChanged;
					BWo.method_264(method_19);
					method_12().Controls.Add(BWs);
				}
				else if (BWp.method_50())
				{
					Label label = new Label();
					label.Text = text;
					label.ForeColor = Form23.color_14;
					label.Font = new Font(label.Font.FontFamily, 10f, FontStyle.Bold);
					label.BackColor = Color.Transparent;
					label.AutoSize = true;
					label.Left = int_;
					label.Top = num;
					method_12().Controls.Add(label);
					int_ += label.Width + 10;
				}
				method_12().ResumeLayout(performLayout: true);
				ResumeLayout(performLayout: true);
				SuspendLayout();
				method_12().SuspendLayout();
				BWT.Tag = BWo.method_64();
				BWT.Width = 18;
				BWT.Height = 18;
				if (BWo.method_219())
				{
					BWT.Left = int_;
				}
				else
				{
					BWT.Left = int_ + BWs.Width;
				}
				BWT.Top = num + 2;
				BWT.SizeMode = PictureBoxSizeMode.StretchImage;
				BWT.Click += BWT_Click;
				method_22();
				method_12().Controls.Add(BWT);
				BWT.BringToFront();
				int_ = 5;
				num = BWT.Bottom + 6;
			}
		}
		else if (BWp.method_50())
		{
			Label label2 = new Label();
			label2.Text = text;
			label2.ForeColor = Form23.color_14;
			label2.Font = new Font(label2.Font.FontFamily, 10f, FontStyle.Bold);
			label2.BackColor = Color.Transparent;
			label2.AutoSize = true;
			label2.Left = int_;
			label2.Top = num;
			num = label2.Bottom + 6;
			if (bool_0)
			{
				method_12().Controls.Add(label2);
			}
			else
			{
				label2.Dispose();
			}
		}
		if (bool_0)
		{
			method_29();
		}
		if (!bool_0)
		{
			num = ((!BWt.Visible) ? BWt.Top : BWt.Bottom);
		}
		else
		{
			BWt.Visible = true;
			BWt.Text = Class333.BGy();
			BWt.ForeColor = Form23.color_14;
			BWt.Font = new Font(BWt.Font.FontFamily, 8.25f, FontStyle.Bold);
			if (BWo != null)
			{
				BWt.Top = num + 5;
			}
			else
			{
				BWt.Top = num;
			}
			BWt.Left = 5;
			method_12().Controls.Add(BWt);
			num = BWt.Bottom;
		}
		SettingOrSpecialObject settingOrSpecialObject = method_24();
		if (!method_28(settingOrSpecialObject, bool_0: false, ref int_, ref num, bool_0) && bool_0)
		{
			num -= BWt.Height;
			BWt.Visible = false;
		}
		if (bool_0)
		{
			BWU.Text = Class333.smethod_873();
			BWU.ForeColor = Form23.color_14;
			BWU.Font = new Font(BWU.Font.FontFamily, 8.25f, FontStyle.Bold);
			BWU.Left = 5;
		}
		if (BWU.Top != num + 5)
		{
			BWU.Top = num + 5;
		}
		if (bool_0)
		{
			method_12().Controls.Add(BWU);
		}
		num = BWU.Bottom;
		if (bool_0)
		{
			BWQ.BorderStyle = BorderStyle.FixedSingle;
			BWQ.BackColor = Form23.color_15;
			BWQ.Left = 5;
			if (BWV != Rectangle.Empty)
			{
				BWQ.Width = Width - 20;
			}
		}
		if (BWQ.Top != num)
		{
			BWQ.Top = num;
		}
		if (BWV != Rectangle.Empty)
		{
			int num2 = Math.Max(Height - BWQ.Top - 10, 160);
			if (BWQ.Height != num2)
			{
				BWQ.Height = num2;
			}
		}
		if (bool_0)
		{
			method_12().Controls.Add(BWQ);
		}
		BWm = 0;
		if (bool_0)
		{
			BWq.Clear();
		}
		if (settingOrSpecialObject.method_12().Bbd)
		{
			method_31(settingOrSpecialObject, bool_0);
			method_33(settingOrSpecialObject, bool_0);
		}
		else
		{
			method_33(settingOrSpecialObject, bool_0);
			method_31(settingOrSpecialObject, bool_0);
		}
		if (BWV == Rectangle.Empty)
		{
			int num3 = 0;
			int num4 = 0;
			foreach (Control control in method_12().Controls)
			{
				num3 = Math.Max(num3, control.Right + 10);
				num4 = Math.Max(num4, control.Bottom + 10);
			}
			Width = num3;
			Height = num4;
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			method_25();
		}
	}

	private SettingOrSpecialObject method_24()
	{
		SettingOrSpecialObject settingOrSpecialObject = BWO;
		if (Form23.enum60_0 == Form23.Enum60.BpG && BWn != null)
		{
			List<Class245> list = new List<Class245>();
			PortFunction.smethod_23(BWO, bool_0: false, bool_1: false, list);
			foreach (Class245 item in list)
			{
				Setting setting = BWn.method_31(item.method_64());
				if (setting != null && setting.method_6() != null)
				{
					settingOrSpecialObject = setting.method_6();
					break;
				}
			}
			if (settingOrSpecialObject == BWO)
			{
				List<Class244> list2 = new List<Class244>();
				PortFunction.smethod_24(BWO, bool_0: false, list2);
				foreach (Class244 item2 in list2)
				{
					Setting setting2 = BWn.method_31(item2.method_64());
					if (setting2 != null && setting2.method_6() != null)
					{
						settingOrSpecialObject = setting2.method_6();
						break;
					}
				}
			}
		}
		return settingOrSpecialObject;
	}

	private void method_25()
	{
		BWR.Clear();
		BWr.Clear();
		foreach (Label item in BWq)
		{
			List<string> list = new List<string>();
			List<int> list2 = new List<int>();
			SettingOrSpecialObject settingOrSpecialObject = (item.Tag as SettingOrSpecialObject[])[0];
			Class244 @class = (item.Tag as SettingOrSpecialObject[])[1] as Class244;
			List<int> list3 = null;
			if (@class != null)
			{
				list3 = @class.method_12().method_2();
			}
			else
			{
				Enum104 bSQ = settingOrSpecialObject.method_12().method_12().BSQ;
				Enum105 bSq = settingOrSpecialObject.method_12().method_12().BSq;
				byte bSR = settingOrSpecialObject.method_12().method_12().BSR;
				ushort bSr = settingOrSpecialObject.method_12().method_12().BSr;
				List<Class244> list4 = PortFunction.smethod_44(BWN, bSQ, bSq, bSR, bSr, bool_0: false);
				if (list4 != null && list4.Count == 1)
				{
					list3 = list4[0].method_12().method_2();
				}
			}
			for (int i = 0; i < settingOrSpecialObject.method_12().method_1().Count; i++)
			{
				Setting setting = settingOrSpecialObject.method_12().method_1()[i];
				int bBZ = setting.method_12().BBZ;
				if (bBZ == -1 || list3 == null || list3.Contains(bBZ))
				{
					setting.method_265(method_27);
					setting.method_264(method_27);
					int num = setting.method_231();
					list.Add(Class233.smethod_35(setting.method_232(), num, bool_0: false, 0));
					list2.Add(i);
				}
			}
			BWR.Add(list);
			BWr.Add(list2);
		}
	}

	private void method_26(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate36 method = method_26;
				BeginInvoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.smethod_28(BWN.aXc, bool_53: true) && !Form23.smethod_80())
		{
			return;
		}
		foreach (Label item in BWq)
		{
			item.Text = Class333.smethod_612();
		}
	}

	private void method_27(object sender, EventArgs e)
	{
		if (!method_0() || Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		if (InvokeRequired)
		{
			try
			{
				Delegate37 method = method_27;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		Setting setting = sender as Setting;
		SettingOrSpecialObject settingOrSpecialObject = ((setting.method_12().method_12().BSQ != Enum104.BAM) ? setting.method_6() : setting);
		int num = 0;
		foreach (Label item in BWq)
		{
			if ((item.Tag as SettingOrSpecialObject[])[0] == settingOrSpecialObject)
			{
				bool flag = false;
				for (int i = 0; i < settingOrSpecialObject.method_12().method_1().Count; i++)
				{
					if (Form23.smethod_84(settingOrSpecialObject.method_12().method_1()[i].method_64()))
					{
						flag = true;
						break;
					}
				}
				if ((!Form23.smethod_28(BWN.aXc, bool_53: true) || Form23.smethod_80()) && !flag)
				{
					item.Text = Class333.smethod_612();
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder();
					for (int j = 0; j < settingOrSpecialObject.method_12().method_1().Count; j++)
					{
						if (!BWr[num].Contains(j))
						{
							continue;
						}
						Setting setting2 = settingOrSpecialObject.method_12().method_1()[j];
						if (!setting2.method_35() || !PortFunction.smethod_52(setting2))
						{
							continue;
						}
						(string, string, bool) tuple = setting2.method_252();
						string text = setting2.method_60(Enum96.aYu);
						if (!string.IsNullOrEmpty(text))
						{
							stringBuilder.Append(text + Class333.smethod_571());
						}
						stringBuilder.Append(tuple.Item1);
						int num2 = BWr[num].IndexOf(j);
						if (!string.IsNullOrEmpty(tuple.Item2))
						{
							if (BWR[num][num2] == Class333.smethod_879())
							{
								stringBuilder.Append(Class333.smethod_880());
							}
							else
							{
								stringBuilder.Append(Class333.smethod_325() + BWR[num][num2]);
							}
						}
						if (num2 != BWr[num].Count - 1)
						{
							stringBuilder.Append(Class333.smethod_881());
						}
					}
					string text2 = stringBuilder.ToString();
					if (text2.EndsWith(Class333.smethod_881()))
					{
						text2 = text2.Substring(0, text2.Length - 3);
					}
					if (setting.method_186().Count > 0 && setting.method_35())
					{
						Color foreColor = Form23.color_12;
						foreach (Setting.Struct44 item2 in setting.method_186())
						{
							if (setting.method_256() == item2.BYk)
							{
								switch (item2.BYL)
								{
								case Setting.Enum95.BYi:
									foreColor = Form23.color_7;
									break;
								case Setting.Enum95.BYJ:
									break;
								case Setting.Enum95.BYj:
									foreColor = Color.DarkOrange;
									break;
								case Setting.Enum95.BYK:
									foreColor = Color.DarkGreen;
									break;
								}
								break;
							}
						}
						item.ForeColor = foreColor;
					}
					else
					{
						item.ForeColor = Form23.color_12;
					}
					item.Text = text2;
				}
			}
			num++;
		}
	}

	private bool method_28(SettingOrSpecialObject settingOrSpecialObject_0, bool bool_0, ref int int_3, ref int int_4, bool bool_1)
	{
		bool result = bool_0;
		bool flag = false;
		if (!bool_0)
		{
			SettingOrSpecialObject settingOrSpecialObject = null;
			if (settingOrSpecialObject_0.method_0().aWx.Contains(settingOrSpecialObject_0))
			{
				if (settingOrSpecialObject_0.method_6() != null)
				{
					foreach (SettingOrSpecialObject item in settingOrSpecialObject_0.method_6().method_1())
					{
						if (item is SpecialObject && item != settingOrSpecialObject_0 && item.method_2() == settingOrSpecialObject_0.method_2())
						{
							settingOrSpecialObject = item;
							break;
						}
					}
				}
				else
				{
					foreach (SettingOrSpecialObject aW in settingOrSpecialObject_0.method_0().aWS)
					{
						if (aW is SpecialObject && aW != settingOrSpecialObject_0 && aW.method_5() == settingOrSpecialObject_0.method_5() && aW.method_2() == settingOrSpecialObject_0.method_2())
						{
							settingOrSpecialObject = aW;
							break;
						}
					}
				}
			}
			if (settingOrSpecialObject != null)
			{
				foreach (SettingOrSpecialObject item2 in settingOrSpecialObject.method_1())
				{
					if (!(item2 is Setting) || (item2 as Setting).method_207() || !(item2.method_2() == Class333.aTe()))
					{
						continue;
					}
					Class245 @class = item2 as Class245;
					if (@class.method_219() || (Form23.class286_0 != null && !Form23.list_0.Contains(@class.method_64())))
					{
						continue;
					}
					string text = @class.method_64().ToString();
					Control control = null;
					if (!bool_1 && method_12().Controls.ContainsKey(text))
					{
						control = method_12().Controls[text];
					}
					if (!@class.method_212() && !@class.method_220())
					{
						if (!@class.method_154() && @class.method_103().Count != 0)
						{
							result = true;
							if (control == null)
							{
								Control17 control2 = new Control17(@class.method_69(), BWN, BWn, null, bool_2: false, bool_3: true, bool_4: false);
								control2.Name = text;
								control2.Left = int_3;
								control2.Top = int_4;
								int_4 = control2.Bottom + 4;
								method_12().Controls.Add(control2);
							}
							else
							{
								int_4 += control.Height + 4;
							}
						}
					}
					else if (control != null)
					{
						method_12().Controls.Remove(control);
					}
				}
			}
		}
		foreach (SettingOrSpecialObject item3 in settingOrSpecialObject_0.method_1())
		{
			Class245 class2 = null;
			if (item3 is SpecialObject)
			{
				foreach (SettingOrSpecialObject item4 in item3.method_1())
				{
					if (item4 is Class245 && (item4 as Class245).method_70() != 0)
					{
						class2 = item4 as Class245;
						break;
					}
				}
			}
			if (!(item3 is Class245) && class2 == null)
			{
				continue;
			}
			Class245 class3 = ((class2 == null) ? (item3 as Class245) : class2);
			if (class3.method_219() || (Form23.class286_0 != null && !Form23.list_0.Contains(class3.method_64())))
			{
				continue;
			}
			string text2 = class3.method_64().ToString();
			Control control3 = null;
			if (!bool_1 && method_12().Controls.ContainsKey(text2))
			{
				control3 = method_12().Controls[text2];
			}
			if (!class3.method_212() && !class3.method_220())
			{
				result = true;
				if (bool_0)
				{
					flag = true;
				}
				if (class3.method_154())
				{
					if (control3 == null)
					{
						Control15 control4 = new Control15(class3.method_69(), BWN, BWn, null, bool_2: false);
						control4.Name = text2;
						control4.Left = int_3;
						control4.Top = int_4;
						if (bool_0)
						{
							int_3 = control4.Right + 10;
							int_3 = Class23.smethod_13(int_3, 15);
						}
						else
						{
							int_4 = control4.Bottom;
						}
						method_12().Controls.Add(control4);
					}
					else if (bool_0)
					{
						int_3 += control3.Width + 10;
						int_3 = Class23.smethod_13(int_3, 15);
					}
					else
					{
						int_4 += control3.Height;
					}
				}
				else if (class3.method_103().Count != 0)
				{
					if (control3 == null)
					{
						Control17 control5 = new Control17(class3.method_69(), BWN, BWn, null, bool_2: false, bool_3: true, bool_4: false);
						control5.Name = text2;
						control5.Left = int_3;
						control5.Top = int_4;
						if (bool_0)
						{
							int_3 = control5.Right + 10;
							int_3 = Class23.smethod_13(int_3, 15);
						}
						else
						{
							int_4 = control5.Bottom + 4;
						}
						method_12().Controls.Add(control5);
					}
					else if (bool_0)
					{
						int_3 += control3.Width + 10;
						int_3 = Class23.smethod_13(int_3, 15);
					}
					else
					{
						int_4 += control3.Height + 4;
					}
				}
				else if (item3 is Setting && (item3 as Setting).method_159())
				{
					if (control3 == null)
					{
						Control12 control6 = new Control12(class3.method_69(), BWN, BWn);
						control6.Name = text2;
						control6.Left = int_3;
						control6.Top = int_4;
						if (bool_0)
						{
							int_3 = control6.Right + 10;
							int_3 = Class23.smethod_13(int_3, 15);
						}
						else
						{
							int_4 = control6.Bottom + 4;
						}
						method_12().Controls.Add(control6);
					}
					else if (bool_0)
					{
						int_3 += control3.Width + 10;
						int_3 = Class23.smethod_13(int_3, 15);
					}
					else
					{
						int_4 += control3.Height + 4;
					}
				}
				else if (item3 is Setting && (item3 as Setting).method_169())
				{
					if (control3 == null)
					{
						Control16 control7 = new Control16(class3.method_69(), BWN, BWn, null);
						control7.Name = text2;
						control7.Left = int_3;
						control7.Top = int_4;
						if (bool_0)
						{
							int_3 = control7.Right + 10;
							int_3 = Class23.smethod_13(int_3, 15);
						}
						else
						{
							int_4 = control7.Bottom + 4;
						}
						method_12().Controls.Add(control7);
					}
					else if (bool_0)
					{
						int_3 += control3.Width + 10;
						int_3 = Class23.smethod_13(int_3, 15);
					}
					else
					{
						int_4 += control3.Height + 4;
					}
				}
				else if (control3 == null)
				{
					Control21 control8 = new Control21(class3.method_69(), BWN, BWn, null, bool_2: false, bool_3: false, bool_4: false);
					control8.Name = text2;
					control8.Left = int_3;
					control8.Top = int_4;
					if (bool_0)
					{
						int_3 = control8.Right + 10;
						int_3 = Class23.smethod_13(int_3, 15);
					}
					else
					{
						int_4 = control8.Bottom + 4;
					}
					method_12().Controls.Add(control8);
				}
				else if (bool_0)
				{
					int_3 += control3.Width + 10;
					int_3 = Class23.smethod_13(int_3, 15);
				}
				else
				{
					int_4 += control3.Height + 4;
				}
			}
			else if (control3 != null)
			{
				method_12().Controls.Remove(control3);
			}
		}
		if (bool_0)
		{
			int_3 = 5;
			if (flag)
			{
				int_4 += 25;
			}
		}
		else if (settingOrSpecialObject_0.method_27().Count != 0)
		{
			result = true;
			foreach (int item5 in settingOrSpecialObject_0.method_27())
			{
				SettingOrSpecialObject settingOrSpecialObject_1 = settingOrSpecialObject_0.method_0().method_33(item5);
				method_28(settingOrSpecialObject_1, bool_0: true, ref int_3, ref int_4, bool_1);
			}
		}
		return result;
	}

	private void method_29()
	{
		while (BWQ.Controls.Count != 0)
		{
			Panel panel_ = BWQ.Controls[0] as Panel;
			method_30(panel_);
		}
	}

	private void method_30(Panel panel_0)
	{
		while (panel_0.Controls.Count != 0)
		{
			Control control = panel_0.Controls[0];
			if (control is Button)
			{
				(control as Button).Click -= method_44;
				(control as Button).Click -= method_46;
				(control as Button).Click -= method_45;
			}
			control.Dispose();
		}
		panel_0.Dispose();
	}

	private void method_31(SettingOrSpecialObject settingOrSpecialObject_0, bool bool_0)
	{
		foreach (PortFunction.Class272 item in settingOrSpecialObject_0.method_12().method_7())
		{
			Panel panel = null;
			if (!bool_0)
			{
				foreach (Panel control5 in BWQ.Controls)
				{
					if (control5.Tag == item)
					{
						panel = control5;
						break;
					}
				}
			}
			if (settingOrSpecialObject_0.method_12().method_8().Contains(item))
			{
				Enum104 bSl = item.BSl;
				Enum105 bSM = item.BSM;
				byte bSm = item.BSm;
				ushort bSN = item.BSN;
				SettingOrSpecialObject settingOrSpecialObject = PortFunction.smethod_36(settingOrSpecialObject_0.method_0(), bSl, bSM, bSm, bSN);
				Label label = new Label();
				List<Label> list = new List<Label>();
				list.Add(label);
				label.Name = Class333.BGw();
				if (bSl == Enum104.BAM)
				{
					label.Text = item.BSn;
				}
				else
				{
					switch (bSM)
					{
					case Enum105.Baa:
						label.Text = PortFunction.smethod_48(settingOrSpecialObject_0.method_0(), bSm + 1, item.BSn);
						break;
					case Enum105.BaB:
						label.Text = PortFunction.smethod_50(settingOrSpecialObject_0.method_0(), bSm + 1, item.BSn);
						break;
					default:
						label.Text = item.BSn;
						break;
					}
				}
				label.ForeColor = Form23.color_12;
				label.AutoSize = true;
				label.Left = 5;
				if (settingOrSpecialObject != null && settingOrSpecialObject.method_12().method_1().Count != 0)
				{
					label.Top = -10;
				}
				else
				{
					label.Top = 0;
				}
				Label label2 = null;
				if (settingOrSpecialObject != null && settingOrSpecialObject.method_12().method_1().Count != 0 && Form23.enum60_0 != Form23.Enum60.BpG)
				{
					label2 = new Label();
					label2.Text = Class333.smethod_612();
					label2.ForeColor = Form23.color_12;
					label2.Tag = new SettingOrSpecialObject[2] { settingOrSpecialObject, null };
					label2.AutoSize = false;
					label2.Left = 5;
					label2.Width = 390;
					label2.Height = (int)((float)label2.Height * 0.7f);
					label2.Top = 9;
					if (bool_0)
					{
						BWq.Add(label2);
					}
				}
				List<PictureBox> list2 = new List<PictureBox>();
				List<Label> list3 = new List<Label>();
				Label label3 = new Label();
				label3.Name = Class333.BBZ();
				label3.ForeColor = Form23.color_12;
				label3.AutoSize = true;
				string text = string.Empty;
				List<WiringPin> list4 = WiringPin.smethod_0(settingOrSpecialObject_0.method_0(), bSl, bSM, bSm, bSN);
				if (bSM != Enum105.Bal && list4.Count != 0)
				{
					bool bool_1 = list4.Count > 1;
					for (int i = 0; i < list4.Count; i++)
					{
						WiringPin wiringPin = list4[i];
						PictureBox pictureBox = new PictureBox();
						pictureBox.Tag = wiringPin;
						pictureBox.Name = Class333.BgA() + i;
						pictureBox.BackColor = Color.Transparent;
						pictureBox.Image = wiringPin.method_10();
						if (pictureBox.Image != null)
						{
							pictureBox.Height = pictureBox.Image.Height;
							pictureBox.Width = pictureBox.Image.Width;
						}
						else
						{
							pictureBox.Height = 23;
							pictureBox.Width = 100;
						}
						pictureBox.Left = 490;
						list2.Add(pictureBox);
						Label label4 = new Label();
						label4.Tag = wiringPin;
						label4.Name = Class333.Bga() + i;
						label4.Text = wiringPin.method_11(bool_1);
						label4.ForeColor = Form23.color_12;
						label4.AutoSize = true;
						label4.Left = pictureBox.Right + 3;
						label4.Top = list3.Count * label4.Height;
						list3.Add(label4);
						if (pictureBox.Height > 45)
						{
							pictureBox.Top = 2;
						}
						else
						{
							pictureBox.Top = label4.Top - 3;
						}
						if (!string.IsNullOrEmpty(wiringPin.method_12()))
						{
							text = text + wiringPin.method_12() + Class333.smethod_885();
						}
					}
				}
				else
				{
					PictureBox pictureBox2 = new PictureBox();
					pictureBox2.Name = Class333.BGZ();
					pictureBox2.BackColor = Color.Transparent;
					if (bSM == Enum105.Bal)
					{
						pictureBox2.Image = WiringPin.smethod_3(Color.Transparent, Color.Transparent, bool_0: false, bool_1: true, bool_2: false);
					}
					else
					{
						pictureBox2.Image = PortFunction.smethod_8(bSl, bSM);
					}
					if (pictureBox2.Image != null)
					{
						pictureBox2.Height = pictureBox2.Image.Height;
						pictureBox2.Width = pictureBox2.Image.Width;
					}
					else
					{
						pictureBox2.Height = 23;
						pictureBox2.Width = 100;
					}
					pictureBox2.Left = 490;
					list2.Add(pictureBox2);
					Label label5 = new Label();
					label5.Name = Class333.BGz();
					if (bSM == Enum105.Bal)
					{
						label5.Text = Class333.smethod_883();
					}
					label5.ForeColor = Form23.color_12;
					label5.AutoSize = true;
					label5.Left = pictureBox2.Right + 10;
					label5.Top = 0;
					list3.Add(label5);
					if (pictureBox2.Height > 45)
					{
						pictureBox2.Top = 2;
					}
					else
					{
						pictureBox2.Top = label5.Top - 3;
					}
				}
				if (bSM != Enum105.Bal)
				{
					string text2 = PortFunction.smethod_37(settingOrSpecialObject);
					if (text2 != null)
					{
						label3.Text = text2;
						if (list2.Count != 0)
						{
							using Graphics dc = CreateGraphics();
							Size size = TextRenderer.MeasureText(dc, label3.Text, label3.Font);
							label3.Left = list2[0].Left + list2[0].Width / 2 - size.Width / 2;
							if (label3.Left < list2[0].Left - 15)
							{
								label3.Left = list2[0].Left - 15;
							}
						}
						else
						{
							label3.Left = 490;
						}
						label3.Top = 0;
					}
				}
				Label label6 = null;
				if (!string.IsNullOrEmpty(text))
				{
					label6 = new Label();
					label6.Name = Class333.BgB();
					label6.Text = text;
					label6.ForeColor = Color.DarkOrange;
					label6.Left = 5;
					label6.Top = 5;
					label6.AutoSize = true;
				}
				List<int> list5 = method_38(bool_0: false, settingOrSpecialObject, null, item, out var _, out var list_);
				int num = 0;
				if (list5.Count > 4)
				{
					num = 84;
				}
				else if (list5.Count != 0)
				{
					num = 42;
				}
				List<Class86> list6 = new List<Class86>();
				foreach (ApplyAndExecuteProcess item2 in list_)
				{
					Class86 @class = new Class86(item2.OwnerObject, BWN, BWn, Rectangle.Empty, bool_0: false);
					@class.method_17();
					list6.Add(@class);
					if (num == 0)
					{
						num = 42;
					}
				}
				int num2 = Form6.smethod_1(list2, list3, null, list, label2, label6, 48, list2.Count != 0 && !string.IsNullOrEmpty(label3.Text)) + num;
				Panel panel3 = new Panel();
				panel3.Tag = item;
				panel3.BorderStyle = BorderStyle.FixedSingle;
				panel3.BackColor = BWQ.BackColor;
				panel3.Location = new Point(BWQ.AutoScrollPosition.X - 1, BWQ.AutoScrollPosition.Y + BWm - 1);
				panel3.Height = num2 + 1;
				if (panel == null)
				{
					foreach (Panel control6 in BWQ.Controls)
					{
						if (control6.Top >= panel3.Top)
						{
							control6.Top += num2;
						}
					}
					BWQ.Controls.Add(panel3);
				}
				else
				{
					if (panel.Height != panel3.Height)
					{
						panel.Height = panel3.Height;
					}
					if (panel.Top != panel3.Top)
					{
						panel.Top = panel3.Top;
					}
				}
				BWm += num2;
				Form6.smethod_2(list2, list3, null, list, null, label2, null, label3, label6, num2 - num, 48, list2.Count != 0 && !string.IsNullOrEmpty(label3.Text));
				method_32(panel3, panel, list2, list3, label, label3, label2, label6);
				method_39(panel3, panel, num, list5, null, list6, list3, bool_0: false, settingOrSpecialObject, null, null);
				if (panel != null)
				{
					method_41(panel, list5, null, list_, 0, bool_0: false);
				}
				int num3 = ((BWV != Rectangle.Empty) ? (BWQ.Width - 11) : 0);
				if (panel != null)
				{
					foreach (Control control7 in panel.Controls)
					{
						num3 = Math.Max(num3, control7.Right);
					}
					panel.Width = Math.Max(panel.Width, num3 + 10);
				}
				else
				{
					foreach (Control control8 in panel3.Controls)
					{
						num3 = Math.Max(num3, control8.Right);
					}
					panel3.Width = Math.Max(panel3.Width, num3 + 10);
				}
				int num4 = ((BWV != Rectangle.Empty) ? (BWQ.Width - 1) : 0);
				foreach (Control control9 in BWQ.Controls)
				{
					num4 = Math.Max(num4, control9.Width);
				}
				foreach (Control control10 in BWQ.Controls)
				{
					control10.Width = num4;
				}
				if (!(BWV == Rectangle.Empty))
				{
					continue;
				}
				BWQ.Width = num4 + 1;
				int num5 = 0;
				foreach (Control control11 in BWQ.Controls)
				{
					num5 = Math.Max(num5, control11.Bottom);
				}
				BWQ.Height = num5 + 2;
			}
			else
			{
				if (panel == null)
				{
					continue;
				}
				int num6 = panel.Height - 1;
				int top = panel.Top;
				method_30(panel);
				foreach (Panel control12 in BWQ.Controls)
				{
					if (control12.Top > top + 1)
					{
						control12.Top -= num6;
					}
				}
			}
		}
		if (settingOrSpecialObject_0.method_27().Count == 0)
		{
			return;
		}
		foreach (int item3 in settingOrSpecialObject_0.method_27())
		{
			SettingOrSpecialObject settingOrSpecialObject_1 = settingOrSpecialObject_0.method_0().method_33(item3);
			method_31(settingOrSpecialObject_1, bool_0);
		}
	}

	private void method_32(Panel panel_0, Panel panel_1, List<PictureBox> list_0, List<Label> list_1, Label label_0, Label label_1, Label label_2, Label label_3)
	{
		if (panel_1 != null)
		{
			List<int> list = new List<int>();
			bool flag = false;
			for (int i = 0; i < panel_1.Controls.Count; i++)
			{
				Control control = panel_1.Controls[i];
				if (control is Label && BWq.Contains(control as Label))
				{
					flag = true;
					if (label_2 != null)
					{
						if ((control.Tag as SettingOrSpecialObject[])[0] != (label_2.Tag as SettingOrSpecialObject[])[0])
						{
							(control.Tag as SettingOrSpecialObject[])[0] = (label_2.Tag as SettingOrSpecialObject[])[0];
						}
						if ((control.Tag as SettingOrSpecialObject[])[1] != (label_2.Tag as SettingOrSpecialObject[])[1])
						{
							(control.Tag as SettingOrSpecialObject[])[1] = (label_2.Tag as SettingOrSpecialObject[])[1];
						}
						if (control.Left != label_2.Left)
						{
							control.Left = label_2.Left;
						}
						if (control.Top != label_2.Top)
						{
							control.Top = label_2.Top;
						}
						label_2.Dispose();
					}
					else
					{
						SettingOrSpecialObject settingOrSpecialObject = ((control as Label).Tag as SettingOrSpecialObject[])[0];
						for (int j = 0; j < settingOrSpecialObject.method_12().method_1().Count; j++)
						{
							settingOrSpecialObject.method_12().method_1()[j].method_265(method_27);
						}
						BWq.Remove(control as Label);
						control.Dispose();
						i--;
					}
				}
				else if (control.Name != null && control.Name == Class333.BGw())
				{
					if (control.Left != label_0.Left)
					{
						control.Left = label_0.Left;
					}
					if (control.Top != label_0.Top)
					{
						control.Top = label_0.Top;
					}
					if (control.Text != label_0.Text)
					{
						control.Text = label_0.Text;
					}
					label_0.Dispose();
				}
				else if (control.Name != null && control.Name.StartsWith(Class333.BgA()))
				{
					list.Add(int.Parse(control.Name.Substring(Class333.BgA().Length)));
					PictureBox pictureBox = null;
					for (int k = 0; k < list_0.Count; k++)
					{
						PictureBox pictureBox2 = list_0[k];
						if (control.Name == pictureBox2.Name)
						{
							pictureBox = pictureBox2;
							break;
						}
					}
					if (pictureBox != null)
					{
						if (control.Left != pictureBox.Left)
						{
							control.Left = pictureBox.Left;
						}
						if (control.Top != pictureBox.Top)
						{
							control.Top = pictureBox.Top;
						}
						if (control.Width != pictureBox.Width)
						{
							control.Width = pictureBox.Width;
						}
						if (control.Height != pictureBox.Height)
						{
							control.Height = pictureBox.Height;
						}
						if ((control as PictureBox).Image != pictureBox.Image)
						{
							(control as PictureBox).Image = pictureBox.Image;
						}
						if (pictureBox.Tag != null)
						{
							control.Tag = pictureBox.Tag;
						}
					}
					else
					{
						control.Dispose();
						i--;
					}
				}
				else if (control.Name != null && control.Name.StartsWith(Class333.Bga()))
				{
					Label label = null;
					for (int l = 0; l < list_1.Count; l++)
					{
						Label label2 = list_1[l];
						if (control.Name == label2.Name)
						{
							label = label2;
							break;
						}
					}
					if (label != null)
					{
						if (control.Left != label.Left)
						{
							control.Left = label.Left;
						}
						if (control.Top != label.Top)
						{
							control.Top = label.Top;
						}
						if (control.Text != label.Text)
						{
							control.Text = label.Text;
						}
						if (control.ForeColor != label.ForeColor)
						{
							control.ForeColor = label.ForeColor;
						}
						if (label.Tag != null)
						{
							control.Tag = label.Tag;
						}
					}
					else
					{
						control.Dispose();
						i--;
					}
				}
				else if (control.Name != null && control.Name == Class333.BBZ())
				{
					if (control.Left != label_1.Left)
					{
						control.Left = label_1.Left;
					}
					if (control.Top != label_1.Top)
					{
						control.Top = label_1.Top;
					}
					if (control.Text != label_1.Text)
					{
						control.Text = label_1.Text;
					}
					label_1.Dispose();
				}
				else
				{
					if (control.Name == null || !(control.Name == Class333.BgB()))
					{
						continue;
					}
					if (label_3 != null)
					{
						if (control.Left != label_3.Left)
						{
							control.Left = label_3.Left;
						}
						if (control.Top != label_3.Top)
						{
							control.Top = label_3.Top;
						}
						if (control.Text != label_3.Text)
						{
							control.Text = label_3.Text;
						}
						if (control.ForeColor != label_3.ForeColor)
						{
							control.ForeColor = label_3.ForeColor;
						}
						label_3.Dispose();
					}
					else
					{
						control.Dispose();
						i--;
					}
				}
			}
			if (label_2 != null && !flag)
			{
				panel_1.Controls.Add(label_2);
				BWq.Add(label_2);
			}
			for (int m = 0; m < list_0.Count; m++)
			{
				if (!list.Contains(m))
				{
					PictureBox value = list_0[m];
					panel_1.Controls.Add(value);
					Label value2 = list_1[m];
					panel_1.Controls.Add(value2);
				}
			}
			return;
		}
		panel_0.Controls.Add(label_0);
		if (label_2 != null)
		{
			panel_0.Controls.Add(label_2);
		}
		foreach (PictureBox item in list_0)
		{
			panel_0.Controls.Add(item);
		}
		foreach (Label item2 in list_1)
		{
			panel_0.Controls.Add(item2);
		}
		panel_0.Controls.Add(label_1);
		if (label_3 != null)
		{
			panel_0.Controls.Add(label_3);
		}
	}

	private void method_33(SettingOrSpecialObject settingOrSpecialObject_0, bool bool_0)
	{
		foreach (SettingOrSpecialObject item in settingOrSpecialObject_0.method_1())
		{
			if (!(item is Class244))
			{
				continue;
			}
			Class244 @class = item as Class244;
			@class.method_265(method_17);
			@class.method_264(method_17);
			@class.method_41(method_18);
			@class.method_40(method_18);
			if (!BWS.Contains(@class))
			{
				BWS.Add(@class);
			}
			int num = @class.method_256();
			bool flag = @class.method_35() || num != 0;
			bool flag2 = @class.method_219() && !@class.method_35();
			Panel panel = null;
			if (!bool_0)
			{
				foreach (Panel control4 in BWQ.Controls)
				{
					if (control4.Tag is int && (int)control4.Tag == @class.method_64())
					{
						panel = control4;
						break;
					}
				}
			}
			if (flag && !flag2 && !@class.method_212())
			{
				bool flag3;
				if (!(flag3 = !@class.method_35()))
				{
					int bbC = @class.method_12().BbC;
					if (bbC != 0)
					{
						Setting setting = settingOrSpecialObject_0.method_0().method_31(bbC);
						if (setting != null)
						{
							flag = setting.method_256() == 1;
						}
					}
				}
				if (flag)
				{
					bool flag4 = settingOrSpecialObject_0.method_0().method_2() && settingOrSpecialObject_0.method_0().method_3() && @class.method_96();
					PictureBox pictureBox = new PictureBox();
					List<PictureBox> list = new List<PictureBox>();
					Label label = null;
					string text = @class.method_60(Enum96.aYv);
					if (string.IsNullOrEmpty(text))
					{
						text = @class.method_60(Enum96.aYu);
					}
					string text2 = (string.IsNullOrEmpty(text) ? @class.method_60(Enum96.aYt) : text);
					Enum104 enum104_ = PortFunction.smethod_12((uint)num);
					Enum105 @enum = PortFunction.smethod_13((uint)num);
					byte byte_ = PortFunction.smethod_14((uint)num);
					ushort ushort_ = PortFunction.smethod_15((uint)num);
					bool flag5 = false;
					bool bool_1 = false;
					if (@enum == Enum105.BaF)
					{
						if (text2.IndexOf(Class333.Bgb(), StringComparison.OrdinalIgnoreCase) >= 0)
						{
							flag5 = true;
						}
						else if (text2.IndexOf(Class333.BgC(), StringComparison.OrdinalIgnoreCase) >= 0)
						{
							flag5 = true;
							bool_1 = true;
						}
					}
					SettingOrSpecialObject settingOrSpecialObject = PortFunction.smethod_36(settingOrSpecialObject_0.method_0(), enum104_, @enum, byte_, ushort_);
					Label label2 = new Label();
					List<Label> list2 = new List<Label>();
					Class108 class2 = null;
					if (flag5)
					{
						class2 = new Class108(Form23.framework_1, Rectangle.Empty, bool_0: false, settingOrSpecialObject_0, bool_1);
						class2.Name = Class333.Bgc();
						class2.Left = 5;
						class2.Top = 20;
					}
					else
					{
						list2.Add(label2);
						label2.Name = Class333.BGw();
						if (flag4)
						{
							label2.Text = Class333.smethod_180() + text2 + Class333.BAO();
						}
						else
						{
							string text3 = @class.method_18();
							if (!string.IsNullOrWhiteSpace(text3))
							{
								text2 = text3 + Class333.smethod_497() + text2 + Class333.smethod_9();
							}
							label2.Text = text2;
						}
						label2.ForeColor = Form23.color_12;
						label2.AutoSize = true;
						label2.Left = 5;
						if (settingOrSpecialObject != null && settingOrSpecialObject.method_12().method_1().Count != 0)
						{
							label2.Top = -10;
						}
						else
						{
							label2.Top = 0;
						}
						label2.Enabled = !flag3;
						pictureBox.Image = GeneralResources.QuestionMark;
						list.Add(pictureBox);
						pictureBox.Name = Class333.BGX();
						pictureBox.Tag = @class;
						pictureBox.Width = 18;
						pictureBox.Height = 18;
						pictureBox.Left = label2.Left + TextRenderer.MeasureText(label2.Text, label2.Font).Width;
						pictureBox.Top = label2.Top;
						pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
						pictureBox.Click += method_35;
						pictureBox.Visible = false;
						label2.MouseEnter += method_36;
						pictureBox.MouseEnter += method_36;
						label2.MouseLeave += method_37;
						if (settingOrSpecialObject != null && settingOrSpecialObject.method_12().method_1().Count != 0 && Form23.enum60_0 != Form23.Enum60.BpG)
						{
							label = new Label();
							label.Text = Class333.smethod_612();
							label.ForeColor = Form23.color_12;
							label.Tag = new SettingOrSpecialObject[2] { settingOrSpecialObject, @class };
							label.AutoSize = false;
							label.Left = 5;
							label.Width = 390;
							label.Height = (int)((float)label.Height * 0.7f);
							label.Top = 9;
							if (bool_0)
							{
								BWq.Add(label);
							}
						}
					}
					ThemedButton themedButton = new ThemedButton();
					themedButton.Tag = @class.method_64();
					themedButton.Text = Class333.BgD();
					themedButton.Enabled = BWN.method_4() && Form23.enum60_0 != Form23.Enum60.BpG && !flag3;
					themedButton.Width = 80;
					themedButton.Height = 23;
					themedButton.Left = 400;
					if (flag5)
					{
						themedButton.Visible = false;
					}
					ThemedButton themedButton2 = new ThemedButton();
					themedButton2.Tag = @class.method_64();
					themedButton2.Text = Class333.Bgd();
					themedButton2.Width = 80;
					themedButton2.Height = themedButton.Height;
					int num2;
					if (PortFunction.smethod_39(@class) && !flag5)
					{
						themedButton2.Enabled = themedButton.Enabled;
						if (method_42(@class))
						{
							themedButton2.ForeColor = Form23.color_7;
						}
						themedButton2.Left = themedButton.Left;
						themedButton2.Visible = true;
						num2 = 48 + themedButton2.Height;
					}
					else
					{
						themedButton2.Visible = false;
						num2 = 48;
					}
					ThemedButton themedButton3 = new ThemedButton();
					themedButton3.Tag = @class.method_64();
					themedButton3.Text = Class333.Bcj();
					themedButton3.Enabled = BWN.method_4() && Form23.enum60_0 != Form23.Enum60.BpG;
					if (flag3)
					{
						themedButton3.ForeColor = Form23.color_7;
					}
					themedButton3.Width = 80;
					themedButton3.Height = themedButton.Height;
					themedButton3.Left = themedButton.Left;
					if (flag5)
					{
						themedButton3.Visible = false;
					}
					List<PictureBox> list3 = new List<PictureBox>();
					List<Label> list4 = new List<Label>();
					Label label3 = new Label();
					label3.Name = Class333.BBZ();
					label3.ForeColor = Form23.color_12;
					label3.AutoSize = true;
					Label label4 = null;
					string text4 = string.Empty;
					if (!flag5)
					{
						if (num == 0)
						{
							PictureBox pictureBox2 = new PictureBox();
							pictureBox2.Name = Class333.BGZ();
							pictureBox2.BackColor = Color.Transparent;
							pictureBox2.Image = WiringPin.smethod_3(Color.Transparent, Color.Transparent, bool_0: false, bool_1: false, bool_2: true);
							pictureBox2.Height = pictureBox2.Image.Height;
							pictureBox2.Width = pictureBox2.Image.Width;
							pictureBox2.Left = themedButton.Right + 10;
							list3.Add(pictureBox2);
							Label label5 = new Label();
							label5.Name = Class333.BGz();
							label5.Text = Class333.BgE();
							label5.ForeColor = Form23.color_7;
							label5.AutoSize = true;
							label5.Left = pictureBox2.Right + 10;
							label5.Top = 0;
							list4.Add(label5);
							if (pictureBox2.Height > num2 - 3)
							{
								pictureBox2.Top = 2;
							}
							else
							{
								pictureBox2.Top = label5.Top - 3;
							}
						}
						else
						{
							List<WiringPin> list5 = WiringPin.smethod_0(settingOrSpecialObject_0.method_0(), enum104_, @enum, byte_, ushort_);
							if (@enum != Enum105.Bal && list5.Count != 0)
							{
								bool bool_2 = list5.Count > 1;
								for (int i = 0; i < list5.Count; i++)
								{
									WiringPin wiringPin = list5[i];
									PictureBox pictureBox3 = new PictureBox();
									pictureBox3.Tag = wiringPin;
									pictureBox3.Name = Class333.BgA() + i;
									pictureBox3.BackColor = Color.Transparent;
									pictureBox3.Image = wiringPin.method_10();
									if (pictureBox3.Image != null)
									{
										pictureBox3.Height = pictureBox3.Image.Height;
										pictureBox3.Width = pictureBox3.Image.Width;
									}
									else
									{
										pictureBox3.Height = 23;
										pictureBox3.Width = 100;
									}
									pictureBox3.Left = themedButton.Right + 10;
									list3.Add(pictureBox3);
									Label label6 = new Label();
									label6.Tag = wiringPin;
									label6.Name = Class333.Bga() + i;
									label6.Text = wiringPin.method_11(bool_2);
									label6.ForeColor = Form23.color_12;
									label6.AutoSize = true;
									label6.Left = pictureBox3.Right + 3;
									label6.Top = list4.Count * label6.Height;
									label6.Enabled = !flag3;
									list4.Add(label6);
									if (pictureBox3.Height > num2 - 3)
									{
										pictureBox3.Top = 2;
									}
									else
									{
										pictureBox3.Top = label6.Top - 3;
									}
									if (!string.IsNullOrEmpty(wiringPin.method_12()))
									{
										text4 = text4 + wiringPin.method_12() + Class333.smethod_885();
									}
								}
							}
							else
							{
								PictureBox pictureBox4 = new PictureBox();
								pictureBox4.Name = Class333.BGZ();
								pictureBox4.BackColor = Color.Transparent;
								if (@enum == Enum105.Bal)
								{
									pictureBox4.Image = WiringPin.smethod_3(Color.Transparent, Color.Transparent, bool_0: false, bool_1: true, bool_2: false);
								}
								else
								{
									pictureBox4.Image = PortFunction.smethod_8(enum104_, @enum);
								}
								if (pictureBox4.Image != null)
								{
									pictureBox4.Height = pictureBox4.Image.Height;
									pictureBox4.Width = pictureBox4.Image.Width;
								}
								else
								{
									pictureBox4.Height = 23;
									pictureBox4.Width = 100;
								}
								pictureBox4.Left = themedButton.Right + 10;
								list3.Add(pictureBox4);
								Label label7 = new Label();
								label7.Name = Class333.BGz();
								if (@enum == Enum105.Bal)
								{
									label7.Text = Class333.smethod_883();
								}
								label7.ForeColor = Form23.color_12;
								label7.AutoSize = true;
								label7.Left = pictureBox4.Right + 10;
								label7.Top = 0;
								label7.Enabled = !flag3;
								list4.Add(label7);
								if (pictureBox4.Height > num2 - 3)
								{
									pictureBox4.Top = 2;
								}
								else
								{
									pictureBox4.Top = label7.Top - 3;
								}
							}
							if (@enum != Enum105.Bal)
							{
								string text5 = PortFunction.smethod_37(settingOrSpecialObject);
								if (text5 != null)
								{
									label3.Text = text5;
									if (list3.Count != 0)
									{
										using Graphics dc = CreateGraphics();
										Size size = TextRenderer.MeasureText(dc, label3.Text, label3.Font);
										label3.Left = list3[0].Left + list3[0].Width / 2 - size.Width / 2;
										if (label3.Left < list3[0].Left - 15)
										{
											label3.Left = list3[0].Left - 15;
										}
									}
									else if (list4.Count != 0 && list4[0].Text != string.Empty)
									{
										label3.Left = list4[0].Right + 10;
									}
									else if (list4.Count != 0)
									{
										label3.Left = list3[0].Right + 10;
									}
									else
									{
										label3.Left = themedButton.Right + 10;
									}
									label3.Top = 0;
									label3.Enabled = !flag3;
								}
							}
						}
						if (!string.IsNullOrEmpty(text4))
						{
							label4 = new Label();
							label4.Name = Class333.BgB();
							label4.Text = text4;
							label4.ForeColor = Color.DarkOrange;
							label4.Left = 5;
							label4.Top = 5;
							label4.AutoSize = true;
						}
					}
					string text6 = null;
					if (BWn != null)
					{
						Class244 class3;
						bool flag6;
						if (@class.method_0() == BWn)
						{
							class3 = BWN.method_31(@class.method_64()) as Class244;
							flag6 = (!BWn.method_2() || !BWn.method_3() || !@class.method_96()) && (!BWN.method_2() || !BWN.method_3() || class3 == null || !class3.method_96());
						}
						else
						{
							class3 = BWn.method_31(@class.method_64()) as Class244;
							flag6 = (!BWn.method_2() || !BWn.method_3() || class3 == null || !class3.method_96()) && (!BWN.method_2() || !BWN.method_3() || !@class.method_96());
						}
						if (flag6 && class3 != null)
						{
							int num3 = class3.method_256();
							if (num3 != num)
							{
								if (num3 == 0)
								{
									text6 = Class333.Bge();
								}
								else
								{
									Enum104 enum104_2 = PortFunction.smethod_12((uint)num3);
									Enum105 enum2 = PortFunction.smethod_13((uint)num3);
									byte byte_2 = PortFunction.smethod_14((uint)num3);
									ushort ushort_2 = PortFunction.smethod_15((uint)num3);
									if (enum2 == Enum105.Bal)
									{
										text6 = Class333.BgF();
									}
									else
									{
										string text7 = PortFunction.smethod_37(PortFunction.smethod_36(class3.method_0(), enum104_2, enum2, byte_2, ushort_2));
										if (text7 != null)
										{
											text6 = Class333.Bgf() + text7 + Class333.BgG();
										}
									}
								}
							}
						}
					}
					List<int> list6 = method_38(flag3, settingOrSpecialObject, @class, null, out var stateMachine_, out var list_);
					string text8 = null;
					if (num != 0 && @class.method_123().Count != 0)
					{
						text8 = string.Empty;
						foreach (string item2 in @class.method_123())
						{
							if (text8 != string.Empty)
							{
								text8 += Class333.smethod_1812();
							}
							text8 += item2;
						}
					}
					else if (method_42(@class))
					{
						text8 = Class333.Bgg();
					}
					int val = 0;
					if (text8 != null)
					{
						using Font font = new Font(Font.FontFamily, 8.25f);
						val = TextRenderer.MeasureText(text8, font, new Size(230, -1), TextFormatFlags.WordBreak).Height;
					}
					int num4 = 0;
					if (list6.Count > 4)
					{
						num4 = Math.Max(84, val);
					}
					else if (list6.Count != 0)
					{
						num4 = Math.Max(42, val);
					}
					else if (text6 != null || text8 != null)
					{
						num4 = Math.Max(42, val);
					}
					Class116 class4 = null;
					if (stateMachine_ != null)
					{
						class4 = new Class116(stateMachine_, BWN, BWn, Rectangle.Empty, bool_0: false);
						class4.method_17();
						num4 += class4.Height;
					}
					List<Class86> list7 = new List<Class86>();
					foreach (ApplyAndExecuteProcess item3 in list_)
					{
						Class86 class5 = new Class86(item3.OwnerObject, BWN, BWn, Rectangle.Empty, bool_0: false);
						class5.method_17();
						list7.Add(class5);
						if (num4 == 0)
						{
							num4 = 42;
						}
					}
					int num5 = Form6.smethod_1(list3, list4, null, list2, label, label4, num2, list3.Count != 0 && !string.IsNullOrEmpty(label3.Text)) + num4;
					if (flag5)
					{
						num5 += class2.Height;
					}
					Panel panel3 = new Panel();
					panel3.Tag = @class.method_64();
					panel3.BorderStyle = BorderStyle.FixedSingle;
					panel3.BackColor = BWQ.BackColor;
					panel3.Location = new Point(BWQ.AutoScrollPosition.X - 1, BWQ.AutoScrollPosition.Y + BWm - 1);
					panel3.Height = num5 + 1;
					if (panel == null)
					{
						foreach (Panel control5 in BWQ.Controls)
						{
							if (control5.Top >= panel3.Top)
							{
								control5.Top += num5;
							}
						}
						BWQ.Controls.Add(panel3);
					}
					else
					{
						if (panel.Height != panel3.Height)
						{
							panel.Height = panel3.Height;
						}
						if (panel.Top != panel3.Top)
						{
							panel.Top = panel3.Top;
						}
					}
					BWm += num5;
					Form6.smethod_2(list3, list4, null, list2, list, label, null, label3, label4, num5 - num4, num2, list3.Count != 0 && !string.IsNullOrEmpty(label3.Text));
					if (!flag5)
					{
						if (themedButton2.Visible)
						{
							if (settingOrSpecialObject != null && settingOrSpecialObject.method_12().method_1().Count != 0)
							{
								themedButton.Top = label2.Top - 18;
							}
							else
							{
								themedButton.Top = label2.Top - 28;
							}
							if (label2.Text.Contains(Class333.smethod_570()))
							{
								themedButton.Top += 10;
							}
							themedButton2.Top = themedButton.Bottom;
							themedButton3.Top = themedButton2.Bottom;
						}
						else
						{
							if (settingOrSpecialObject != null && settingOrSpecialObject.method_12().method_1().Count != 0)
							{
								themedButton.Top = label2.Top - 6;
							}
							else
							{
								themedButton.Top = label2.Top - 16;
							}
							if (label2.Text.Contains(Class333.smethod_570()))
							{
								themedButton.Top += 10;
							}
							themedButton3.Top = themedButton.Bottom;
						}
					}
					method_34(panel3, panel, class2, list3, list4, label2, pictureBox, label3, label, label4, themedButton, themedButton2, themedButton3, @class);
					method_39(panel3, panel, num4, list6, class4, list7, list4, flag3, settingOrSpecialObject, text8, text6);
					if (panel != null)
					{
						method_41(panel, list6, stateMachine_, list_, @class.method_64(), text6 != null);
					}
					Panel panel5 = ((panel == null) ? panel3 : panel);
					int num6 = ((BWV != Rectangle.Empty) ? (BWQ.Width - 11) : 0);
					foreach (Control control6 in panel5.Controls)
					{
						num6 = Math.Max(num6, control6.Right);
					}
					panel5.Width = Math.Max(panel5.Width, num6 + 10);
					int num7 = ((BWV != Rectangle.Empty) ? (BWQ.Width - 1) : 0);
					foreach (Control control7 in BWQ.Controls)
					{
						num7 = Math.Max(num7, control7.Width);
					}
					foreach (Control control8 in BWQ.Controls)
					{
						control8.Width = num7;
					}
					if (BWV == Rectangle.Empty)
					{
						BWQ.Width = num7 + 1;
						int num8 = 0;
						foreach (Control control9 in BWQ.Controls)
						{
							num8 = Math.Max(num8, control9.Bottom);
						}
						BWQ.Height = num8 + 2;
					}
				}
			}
			if (panel == null || (!(@class.method_212() | flag2) && flag))
			{
				continue;
			}
			int num9 = panel.Height - 1;
			int top = panel.Top;
			method_30(panel);
			foreach (Panel control10 in BWQ.Controls)
			{
				if (control10.Top > top + 1)
				{
					control10.Top -= num9;
				}
			}
		}
		if (settingOrSpecialObject_0.method_27().Count == 0)
		{
			return;
		}
		foreach (int item4 in settingOrSpecialObject_0.method_27())
		{
			SettingOrSpecialObject settingOrSpecialObject_1 = settingOrSpecialObject_0.method_0().method_33(item4);
			method_33(settingOrSpecialObject_1, bool_0);
		}
	}

	private void method_34(Panel panel_0, Panel panel_1, Class108 class108_0, List<PictureBox> list_0, List<Label> list_1, Label label_0, PictureBox pictureBox_0, Label label_1, Label label_2, Label label_3, ThemedButton themedButton_0, ThemedButton themedButton_1, ThemedButton themedButton_2, Class244 class244_0)
	{
		if (panel_1 != null)
		{
			List<int> list = new List<int>();
			bool flag = false;
			for (int i = 0; i < panel_1.Controls.Count; i++)
			{
				Control control = panel_1.Controls[i];
				if (control is Label && BWq.Contains(control as Label))
				{
					flag = true;
					if (label_2 != null)
					{
						if ((control.Tag as SettingOrSpecialObject[])[0] != (label_2.Tag as SettingOrSpecialObject[])[0])
						{
							(control.Tag as SettingOrSpecialObject[])[0] = (label_2.Tag as SettingOrSpecialObject[])[0];
						}
						if ((control.Tag as SettingOrSpecialObject[])[1] != (label_2.Tag as SettingOrSpecialObject[])[1])
						{
							(control.Tag as SettingOrSpecialObject[])[1] = (label_2.Tag as SettingOrSpecialObject[])[1];
						}
						if (control.Left != label_2.Left)
						{
							control.Left = label_2.Left;
						}
						if (control.Top != label_2.Top)
						{
							control.Top = label_2.Top;
						}
						label_2.Dispose();
					}
					else
					{
						SettingOrSpecialObject settingOrSpecialObject = ((control as Label).Tag as SettingOrSpecialObject[])[0];
						for (int j = 0; j < settingOrSpecialObject.method_12().method_1().Count; j++)
						{
							settingOrSpecialObject.method_12().method_1()[j].method_265(method_27);
						}
						BWq.Remove(control as Label);
						control.Dispose();
						i--;
					}
				}
				else if (control.Name != null && control.Name == Class333.BGw())
				{
					if (control.Left != label_0.Left)
					{
						control.Left = label_0.Left;
					}
					if (control.Top != label_0.Top)
					{
						control.Top = label_0.Top;
					}
					if (control.Text != label_0.Text)
					{
						control.Text = label_0.Text;
					}
					if (control.Enabled != label_0.Enabled)
					{
						control.Enabled = label_0.Enabled;
					}
					label_0.Dispose();
				}
				else if (control.Name != null && control.Name == Class333.BGX())
				{
					if (control.Left != pictureBox_0.Left)
					{
						control.Left = pictureBox_0.Left;
					}
					if (control.Top != pictureBox_0.Top)
					{
						control.Top = pictureBox_0.Top;
					}
					pictureBox_0.Dispose();
				}
				else if (control.Name != null && control.Name.StartsWith(Class333.BgA()))
				{
					list.Add(int.Parse(control.Name.Substring(Class333.BgA().Length)));
					PictureBox pictureBox = null;
					for (int k = 0; k < list_0.Count; k++)
					{
						PictureBox pictureBox2 = list_0[k];
						if (control.Name == pictureBox2.Name)
						{
							pictureBox = pictureBox2;
							break;
						}
					}
					if (pictureBox != null)
					{
						if (control.Left != pictureBox.Left)
						{
							control.Left = pictureBox.Left;
						}
						if (control.Top != pictureBox.Top)
						{
							control.Top = pictureBox.Top;
						}
						if (control.Width != pictureBox.Width)
						{
							control.Width = pictureBox.Width;
						}
						if (control.Height != pictureBox.Height)
						{
							control.Height = pictureBox.Height;
						}
						if ((control as PictureBox).Image != pictureBox.Image)
						{
							(control as PictureBox).Image = pictureBox.Image;
						}
						if (pictureBox.Tag != null)
						{
							control.Tag = pictureBox.Tag;
						}
					}
					else
					{
						control.Dispose();
						i--;
					}
				}
				else if (control.Name != null && control.Name.StartsWith(Class333.Bga()))
				{
					Label label = null;
					for (int l = 0; l < list_1.Count; l++)
					{
						Label label2 = list_1[l];
						if (control.Name == label2.Name)
						{
							label = label2;
							break;
						}
					}
					if (label != null)
					{
						if (control.Left != label.Left)
						{
							control.Left = label.Left;
						}
						if (control.Top != label.Top)
						{
							control.Top = label.Top;
						}
						if (control.Text != label.Text)
						{
							control.Text = label.Text;
						}
						if (control.ForeColor != label.ForeColor)
						{
							control.ForeColor = label.ForeColor;
						}
						if (control.Enabled != label.Enabled)
						{
							control.Enabled = label.Enabled;
						}
						if (label.Tag != null)
						{
							control.Tag = label.Tag;
						}
					}
					else
					{
						control.Dispose();
						i--;
					}
				}
				else if (control.Name != null && control.Name == Class333.BBZ())
				{
					if (control.Left != label_1.Left)
					{
						control.Left = label_1.Left;
					}
					if (control.Top != label_1.Top)
					{
						control.Top = label_1.Top;
					}
					if (control.Text != label_1.Text)
					{
						control.Text = label_1.Text;
					}
					if (control.Enabled != label_1.Enabled)
					{
						control.Enabled = label_1.Enabled;
					}
					label_1.Dispose();
				}
				else if (control.Name != null && control.Name == Class333.BgB())
				{
					if (label_3 != null)
					{
						if (control.Left != label_3.Left)
						{
							control.Left = label_3.Left;
						}
						if (control.Top != label_3.Top)
						{
							control.Top = label_3.Top;
						}
						if (control.Text != label_3.Text)
						{
							control.Text = label_3.Text;
						}
						if (control.ForeColor != label_3.ForeColor)
						{
							control.ForeColor = label_3.ForeColor;
						}
						label_3.Dispose();
					}
					else
					{
						control.Dispose();
						i--;
					}
				}
				else if (control is Button && (control.Text.StartsWith(Class333.smethod_1553()) || control.Text.StartsWith(Class333.BgD())))
				{
					if (control.Left != themedButton_0.Left)
					{
						control.Left = themedButton_0.Left;
					}
					if (control.Top != themedButton_0.Top)
					{
						control.Top = themedButton_0.Top;
					}
					if (control.Enabled != themedButton_0.Enabled)
					{
						control.Enabled = themedButton_0.Enabled;
					}
					if (control.ForeColor != themedButton_0.ForeColor)
					{
						control.ForeColor = themedButton_0.ForeColor;
					}
					themedButton_0.Dispose();
				}
				else if (control is Button && control.Text.StartsWith(Class333.Bgd()))
				{
					if (control.Visible != themedButton_1.Visible)
					{
						control.Visible = themedButton_1.Visible;
					}
					if (control.Left != themedButton_1.Left)
					{
						control.Left = themedButton_1.Left;
					}
					if (control.Top != themedButton_1.Top)
					{
						control.Top = themedButton_1.Top;
					}
					if (control.Enabled != themedButton_1.Enabled)
					{
						control.Enabled = themedButton_1.Enabled;
					}
					if (control.ForeColor != themedButton_1.ForeColor)
					{
						control.ForeColor = themedButton_1.ForeColor;
					}
					themedButton_1.Dispose();
				}
				else if (control is Button && control.Text.StartsWith(Class333.Bcj()))
				{
					if (control.Left != themedButton_2.Left)
					{
						control.Left = themedButton_2.Left;
					}
					if (control.Top != themedButton_2.Top)
					{
						control.Top = themedButton_2.Top;
					}
					if (control.Enabled != themedButton_2.Enabled)
					{
						control.Enabled = themedButton_2.Enabled;
					}
					if (control.ForeColor != themedButton_2.ForeColor)
					{
						control.ForeColor = themedButton_2.ForeColor;
					}
					themedButton_2.Dispose();
				}
				else if (control is Class108)
				{
					if (control.Left != class108_0.Left)
					{
						control.Left = class108_0.Left;
					}
					if (control.Top != class108_0.Top)
					{
						control.Top = class108_0.Top;
					}
					if (control.Enabled != class108_0.Enabled)
					{
						control.Enabled = class108_0.Enabled;
					}
					class108_0.Dispose();
				}
			}
			if (label_2 != null && !flag)
			{
				panel_1.Controls.Add(label_2);
				BWq.Add(label_2);
			}
			for (int m = 0; m < list_0.Count; m++)
			{
				if (!list.Contains(m))
				{
					PictureBox value = list_0[m];
					panel_1.Controls.Add(value);
					Label value2 = list_1[m];
					panel_1.Controls.Add(value2);
				}
			}
			return;
		}
		if (class108_0 != null)
		{
			panel_0.Controls.Add(class108_0);
		}
		if (label_0 != null)
		{
			panel_0.Controls.Add(label_0);
		}
		if (pictureBox_0 != null)
		{
			panel_0.Controls.Add(pictureBox_0);
		}
		if (label_2 != null)
		{
			panel_0.Controls.Add(label_2);
		}
		foreach (PictureBox item in list_0)
		{
			panel_0.Controls.Add(item);
		}
		foreach (Label item2 in list_1)
		{
			panel_0.Controls.Add(item2);
		}
		panel_0.Controls.Add(label_1);
		if (label_3 != null)
		{
			panel_0.Controls.Add(label_3);
		}
		if (!class244_0.method_219() && !class244_0.method_212() && !class244_0.method_220() && (!BWN.method_2() || !BWN.method_3() || !class244_0.method_96()))
		{
			themedButton_0.Click += method_44;
			panel_0.Controls.Add(themedButton_0);
			themedButton_1.Click += method_46;
			panel_0.Controls.Add(themedButton_1);
			themedButton_2.Click += method_45;
			panel_0.Controls.Add(themedButton_2);
		}
	}

	private void method_35(object sender, EventArgs e)
	{
		if (sender is PictureBox)
		{
			PictureBox pictureBox = sender as PictureBox;
			if (pictureBox.Tag is Setting)
			{
				Form23.smethod_50(pictureBox.Tag as Setting, sender as Control);
			}
		}
	}

	private void method_36(object sender, EventArgs e)
	{
		PictureBox pictureBox = null;
		if (sender is PictureBox)
		{
			pictureBox = sender as PictureBox;
		}
		else if (sender is Label)
		{
			Label label = sender as Label;
			if (label.Parent.Controls.ContainsKey(Class333.BGX()))
			{
				pictureBox = label.Parent.Controls[Class333.BGX()] as PictureBox;
			}
		}
		if (pictureBox == null)
		{
			return;
		}
		if (Form23.pictureBox_1 != pictureBox)
		{
			if (!Form23.bool_28 && Form23.pictureBox_1 != null)
			{
				Form23.pictureBox_1.Visible = false;
			}
			Form23.bool_28 = false;
			Form23.pictureBox_1 = pictureBox;
		}
		pictureBox.Visible = true;
		pictureBox.BringToFront();
	}

	private void method_37(object sender, EventArgs e)
	{
		PictureBox pictureBox = null;
		if (sender is PictureBox)
		{
			pictureBox = sender as PictureBox;
		}
		else if (sender is Label)
		{
			Label label = sender as Label;
			if (label.Parent.Controls.ContainsKey(Class333.BGX()))
			{
				pictureBox = label.Parent.Controls[Class333.BGX()] as PictureBox;
			}
		}
		if (pictureBox != null)
		{
			Point pt = pictureBox.Parent.PointToClient(Control.MousePosition);
			if (!pictureBox.Bounds.Contains(pt))
			{
				pictureBox.Visible = false;
			}
		}
	}

	private List<int> method_38(bool bool_0, SettingOrSpecialObject settingOrSpecialObject_0, Class244 class244_0, PortFunction.Class272 class272_0, out StateMachine stateMachine_0, out List<ApplyAndExecuteProcess> list_0)
	{
		List<int> list = new List<int>();
		stateMachine_0 = null;
		list_0 = new List<ApplyAndExecuteProcess>();
		if ((class272_0 == null || (!Class242.smethod_12(BWN.awZ) && (BWN.awZ != 21 || !(BWN.aXA < new Class14(2, 27, 0, 1, 0))) && (BWN.awZ == 21 || !(BWN.aXA < new Class14(1, 27, 0, 1, 0))))) && settingOrSpecialObject_0 != null && !bool_0)
		{
			foreach (SettingOrSpecialObject item in settingOrSpecialObject_0.method_1())
			{
				bool flag = item.method_2().Contains(Class333.smethod_886());
				if (!(item.method_35() | flag) || (class244_0 != null && (class244_0.method_212() || class244_0.method_220())))
				{
					continue;
				}
				Setting setting = item as Setting;
				bool num = setting != null && !setting.method_68() && !setting.method_219() && !setting.method_220() && setting.method_242()[0] == 1 && setting.method_242()[1] == 1 && setting.method_242()[2] == 1 && ((setting.method_203() && setting.method_204() && setting.method_207()) || !setting.method_207());
				bool flag2 = item is SpecialObject specialObject && (specialObject.method_68().IdleText != null || specialObject.method_68().PreApplySettingDataIds.Count != 0);
				if (!(num | (item is StateMachine) | flag2) || !PortFunction.smethod_51(item, class244_0, class272_0))
				{
					continue;
				}
				if (item is StateMachine)
				{
					if (Form23.class286_0 == null)
					{
						stateMachine_0 = item as StateMachine;
					}
				}
				else if (item is SpecialObject && ((item as SpecialObject).method_68().IdleText != null || (item as SpecialObject).method_68().PreApplySettingDataIds.Count != 0))
				{
					if (Form23.class286_0 == null)
					{
						list_0.Add((item as SpecialObject).method_68());
					}
				}
				else if (item is Setting && (Form23.class286_0 == null || Form23.list_0.Contains(setting.method_64())))
				{
					list.Add((item as Setting).method_64());
				}
			}
		}
		return list;
	}

	private void method_39(Panel panel_0, Panel panel_1, int int_3, List<int> list_0, Class116 class116_0, List<Class86> list_1, List<Label> list_2, bool bool_0, SettingOrSpecialObject settingOrSpecialObject_0, string string_0, string string_1)
	{
		int int_4 = 10;
		int int_5 = panel_0.Height - (int_3 + 3);
		if (!bool_0)
		{
			if (settingOrSpecialObject_0 != null)
			{
				int num = 0;
				Framework framework = ((Form23.enum60_0 != Form23.Enum60.BpG || BWn == null) ? BWN : BWn);
				foreach (int item in list_0)
				{
					Setting setting = framework.method_31(item);
					if (setting == null)
					{
						continue;
					}
					if (num == 4)
					{
						int_4 = 10;
						int_5 += 42;
					}
					if (setting.method_103().Count != 0)
					{
						Control17 control = new Control17(setting.method_69(), BWN, BWn, null, bool_2: false, bool_3: true, bool_4: true);
						control.Left = int_4;
						control.Top = int_5;
						bool flag = false;
						if (panel_1 != null)
						{
							foreach (Control control9 in panel_1.Controls)
							{
								if (control9 is Control17 && (control9 as Control17).method_0() == setting)
								{
									if (control9.Left != control.Left)
									{
										control9.Left = control.Left;
									}
									if (control9.Top != control.Top)
									{
										control9.Top = control.Top;
									}
									flag = true;
									break;
								}
							}
						}
						int_4 = control.Right + 10;
						if (!flag)
						{
							if (panel_1 != null)
							{
								panel_1.Controls.Add(control);
							}
							else
							{
								panel_0.Controls.Add(control);
							}
						}
						else
						{
							control.Dispose();
						}
					}
					else if (setting.method_154())
					{
						Control15 control3 = new Control15(setting.method_69(), BWN, BWn, null, bool_2: false);
						control3.Left = int_4;
						control3.Top = int_5;
						bool flag2 = false;
						if (panel_1 != null)
						{
							foreach (Control control10 in panel_1.Controls)
							{
								if (control10 is Control15 && (control10 as Control15).method_0() == setting)
								{
									if (control10.Left != control3.Left)
									{
										control10.Left = control3.Left;
									}
									if (control10.Top != control3.Top)
									{
										control10.Top = control3.Top;
									}
									flag2 = true;
									break;
								}
							}
						}
						int_4 = control3.Right + 10;
						if (!flag2)
						{
							if (panel_1 != null)
							{
								panel_1.Controls.Add(control3);
							}
							else
							{
								panel_0.Controls.Add(control3);
							}
						}
						else
						{
							control3.Dispose();
						}
					}
					else
					{
						Control21 control5 = new Control21(setting.method_69(), BWN, BWn, null, bool_2: false, bool_3: false, bool_4: true);
						control5.Left = int_4;
						control5.Top = int_5;
						bool flag3 = false;
						if (panel_1 != null)
						{
							foreach (Control control11 in panel_1.Controls)
							{
								if (control11 is Control21 && (control11 as Control21).method_0() == setting)
								{
									if (control11.Left != control5.Left)
									{
										control11.Left = control5.Left;
									}
									if (control11.Top != control5.Top)
									{
										control11.Top = control5.Top;
									}
									flag3 = true;
									break;
								}
							}
						}
						int_4 = control5.Right + 10;
						if (!flag3)
						{
							if (panel_1 != null)
							{
								panel_1.Controls.Add(control5);
							}
							else
							{
								panel_0.Controls.Add(control5);
							}
						}
						else
						{
							control5.Dispose();
						}
					}
					num++;
				}
				for (int i = 0; i < list_1.Count; i++)
				{
					bool flag4;
					if (flag4 = list_1[i].method_13().method_2().Contains(Class333.smethod_886()))
					{
						Label label = ((list_2.Count <= 0) ? null : (label = list_2[0]));
						if (label != null)
						{
							if (list_1[i].Left == 0 && i == 0)
							{
								list_1[i].Left = label.Left + 60;
							}
							else if (i > 0)
							{
								list_1[i].Left = list_1[i - 1].Left + list_1[i - 1].Width;
							}
							list_1[i].Top = -9;
						}
					}
					else
					{
						list_1[i].Left = int_4;
						list_1[i].Top = int_5 + 6;
					}
					bool flag5 = false;
					if (panel_1 != null)
					{
						foreach (Control control12 in panel_1.Controls)
						{
							if (control12 is Class86 && (control12 as Class86).method_13() == list_1[i].method_13())
							{
								if (control12.Left != list_1[i].Left)
								{
									control12.Left = list_1[i].Left;
								}
								if (control12.Top != list_1[i].Top)
								{
									control12.Top = list_1[i].Top;
								}
								if ((control12 as Class86).BHP != list_1[i].BHP)
								{
									(control12 as Class86).BHP = list_1[i].BHP;
								}
								flag5 = true;
								break;
							}
						}
					}
					if (!flag4)
					{
						int_4 = list_1[i].Right + 10;
					}
					if (!flag5)
					{
						if (panel_1 != null)
						{
							panel_1.Controls.Add(list_1[i]);
						}
						else
						{
							panel_0.Controls.Add(list_1[i]);
						}
					}
					else
					{
						list_1[i].Dispose();
					}
				}
				if (class116_0 != null)
				{
					int_4 = 10;
					if (num != 0)
					{
						int_5 += 42;
					}
					class116_0.Left = int_4;
					class116_0.Top = int_5;
					bool flag6 = false;
					if (panel_1 != null)
					{
						foreach (Control control13 in panel_1.Controls)
						{
							if (control13 is Class116)
							{
								if (control13.Left != class116_0.Left)
								{
									control13.Left = class116_0.Left;
								}
								if (control13.Top != class116_0.Top)
								{
									control13.Top = class116_0.Top;
								}
								flag6 = true;
								break;
							}
						}
					}
					if (!flag6)
					{
						if (panel_1 != null)
						{
							panel_1.Controls.Add(class116_0);
						}
						else
						{
							panel_0.Controls.Add(class116_0);
						}
					}
					else
					{
						class116_0.Dispose();
					}
				}
			}
			if (string_0 != null || string_1 != null)
			{
				method_40(panel_0, panel_1, string_0, string_1, ref int_4, ref int_5);
			}
		}
		else if (string_0 != null)
		{
			method_40(panel_0, panel_1, string_0, string_1, ref int_4, ref int_5);
		}
	}

	private void method_40(Panel panel_0, Panel panel_1, string string_0, string string_1, ref int int_3, ref int int_4)
	{
		Label label = new Label();
		label.Name = Class333.BgH();
		label.Font = new Font(label.Font.FontFamily, 8.25f);
		label.AutoSize = true;
		label.MinimumSize = new Size(250, 0);
		label.MaximumSize = new Size(250, 0);
		if (string_0 != null)
		{
			label.Text = string_0;
			label.ForeColor = Form23.color_7;
		}
		else if (string_1 != null)
		{
			label.Text = string_1;
			label.ForeColor = Form23.color_9;
		}
		label.Left = int_3;
		label.Top = int_4;
		bool flag = false;
		if (panel_1 != null)
		{
			foreach (Control control in panel_1.Controls)
			{
				if (control is Label && control.Name != null && control.Name == Class333.BgH() && (control.ForeColor == Form23.color_7 || control.ForeColor == Form23.color_9))
				{
					if (control.Left != label.Left)
					{
						control.Left = label.Left;
					}
					if (control.Top != label.Top)
					{
						control.Top = label.Top;
					}
					if (control.Text != label.Text)
					{
						control.Text = label.Text;
					}
					if (control.ForeColor != label.ForeColor)
					{
						control.ForeColor = label.ForeColor;
					}
					flag = true;
					break;
				}
			}
		}
		int_3 = label.Right + 10;
		if (!flag)
		{
			if (panel_1 != null)
			{
				panel_1.Controls.Add(label);
			}
			else
			{
				panel_0.Controls.Add(label);
			}
		}
		else
		{
			label.Dispose();
		}
	}

	private void method_41(Panel panel_0, List<int> list_0, StateMachine stateMachine_0, List<ApplyAndExecuteProcess> list_1, int int_3, bool bool_0)
	{
		Framework framework = ((Form23.enum60_0 != Form23.Enum60.BpG || BWn == null) ? BWN : BWn);
		for (int i = 0; i < panel_0.Controls.Count; i++)
		{
			Control control = panel_0.Controls[i];
			if (control is Label)
			{
				if (control.Name != null && control.Name == Class333.BgH())
				{
					if (control.ForeColor == Form23.color_7)
					{
						if (framework.method_31(int_3) is Class244 @class && (@class.method_256() == 0 || @class.method_123().Count == 0) && !method_42(@class))
						{
							control.Dispose();
							i--;
						}
					}
					else if (control.ForeColor == Form23.color_9 && !bool_0)
					{
						control.Dispose();
						i--;
					}
				}
				else if (control.Tag != null && control.Tag is int)
				{
					Setting setting = framework.method_31((int)control.Tag);
					if (PortFunction.smethod_27(setting.method_6()) && !list_0.Contains(setting.method_64()))
					{
						control.Dispose();
						i--;
					}
				}
			}
			else if (control is Control17)
			{
				if (!list_0.Contains((control as Control17).method_0().method_64()))
				{
					control.Dispose();
					i--;
				}
			}
			else if (control is Control15)
			{
				if (!list_0.Contains((control as Control15).method_0().method_64()))
				{
					control.Dispose();
					i--;
				}
			}
			else if (control is Control21)
			{
				if (!list_0.Contains((control as Control21).method_0().method_64()))
				{
					control.Dispose();
					i--;
				}
			}
			else if (control is Class116)
			{
				if (stateMachine_0 == null)
				{
					control.Dispose();
					i--;
				}
			}
			else
			{
				if (!(control is Class86))
				{
					continue;
				}
				bool flag = false;
				foreach (ApplyAndExecuteProcess item in list_1)
				{
					if ((control as Class86).method_13() == item.OwnerObject)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					control.Dispose();
					i--;
				}
			}
		}
	}

	private bool method_42(Setting setting_0)
	{
		if (PortFunction.smethod_12((uint)setting_0.method_256()) == Enum104.BAM && method_47(setting_0, out var setting_1, out var setting_2) != null && setting_1 != null && setting_2 != null && !setting_1.method_122())
		{
			return true;
		}
		return false;
	}

	private void method_43(object sender, EventArgs e)
	{
		method_23(bool_0: false);
	}

	private void method_44(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BWN.method_4())
		{
			return;
		}
		int num = (int)((Button)sender).Tag;
		Setting setting = BWN.method_31(num);
		if (setting is Class244)
		{
			Form7 form = new Form7(setting as Class244);
			if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
			{
				method_23(bool_0: false);
			}
			form.Dispose();
		}
	}

	private void method_45(object sender, EventArgs e)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG && BWN.method_4())
		{
			int num = (int)((Button)sender).Tag;
			Setting setting = BWN.method_31(num);
			if (setting is Class244)
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_2(setting.method_64());
				setting.method_272(0, bool_0: true);
				@class?.method_4();
				Form23.smethod_74(setting.method_64());
			}
		}
	}

	private void method_46(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BWN.method_4())
		{
			return;
		}
		int num = (int)((Button)sender).Tag;
		Setting setting = BWN.method_31(num);
		if (!(setting is Class244))
		{
			return;
		}
		SettingOrSpecialObject settingOrSpecialObject = method_47(setting, out var setting_, out var setting_2);
		if (settingOrSpecialObject == null || setting_ == null || setting_2 == null)
		{
			settingOrSpecialObject = method_48(out setting_, out setting_2);
		}
		if (settingOrSpecialObject != null && setting_ != null && setting_2 != null)
		{
			if (setting_.method_256() == 0)
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_2(setting_.method_64());
				setting_.method_272(1, bool_0: true);
				@class?.method_4();
				Form23.smethod_74(setting_.method_64());
			}
			Setting setting2 = BWN.method_31(settingOrSpecialObject.method_20());
			if (setting2 != null && setting2.method_70() != 0)
			{
				string text = setting.method_60(Enum96.aYv);
				if (string.IsNullOrEmpty(text))
				{
					text = setting.method_60(Enum96.aYu);
				}
				string text2 = (string.IsNullOrEmpty(text) ? setting.method_60(Enum96.aYt) : text);
				if (setting2.method_260() != text2)
				{
					Class280 class2 = Form23.smethod_95();
					class2?.method_2(setting2.method_64());
					setting2.method_262(text2, bool_0: true);
					class2?.method_4();
					Form23.smethod_74(setting2.method_64());
				}
			}
			method_49(setting_, setting, setting_2);
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, Class333.Bgh(), Class333.BgI(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private SettingOrSpecialObject method_47(Setting setting_0, out Setting setting_1, out Setting setting_2)
	{
		SettingOrSpecialObject settingOrSpecialObject = null;
		setting_1 = null;
		setting_2 = null;
		int uint_ = setting_0.method_256();
		Enum104 @enum = PortFunction.smethod_12((uint)uint_);
		ushort num = PortFunction.smethod_15((uint)uint_);
		if (@enum == Enum104.BAM)
		{
			foreach (SettingOrSpecialObject item in BWN.awD)
			{
				if (!(item is Setting) || item.method_12().method_12().BSQ != Enum104.BAM || item.method_12().method_12().BSr != num)
				{
					continue;
				}
				setting_2 = item as Setting;
				settingOrSpecialObject = setting_2.method_6();
				foreach (SettingOrSpecialObject item2 in settingOrSpecialObject.method_1())
				{
					if (item2 is Setting && (item2 as Setting).method_154())
					{
						setting_1 = item2 as Setting;
						break;
					}
				}
				break;
			}
		}
		return settingOrSpecialObject;
	}

	private SettingOrSpecialObject method_48(out Setting setting_0, out Setting setting_1)
	{
		SettingOrSpecialObject settingOrSpecialObject = null;
		setting_0 = null;
		setting_1 = null;
		foreach (SettingOrSpecialObject item in BWN.awD)
		{
			if (!(item is Setting) || item.method_12().method_12().BSQ != Enum104.BAM)
			{
				continue;
			}
			setting_1 = item as Setting;
			settingOrSpecialObject = setting_1.method_6();
			foreach (SettingOrSpecialObject item2 in settingOrSpecialObject.method_1())
			{
				if (item2 is Setting && (item2 as Setting).method_154())
				{
					setting_0 = item2 as Setting;
					break;
				}
			}
			if (setting_0 == null || setting_0.method_256() != 0)
			{
				settingOrSpecialObject = null;
				continue;
			}
			break;
		}
		return settingOrSpecialObject;
	}

	private void method_49(Setting setting_0, Setting setting_1, Setting setting_2)
	{
		Form form = new Form();
		form.BackColor = Form23.color_10;
		form.ForeColor = Form23.color_12;
		form.Text = Class333.Bgi();
		form.FormBorderStyle = FormBorderStyle.FixedDialog;
		form.MinimizeBox = false;
		form.MaximizeBox = false;
		form.ShowIcon = false;
		form.ShowInTaskbar = false;
		form.StartPosition = FormStartPosition.CenterParent;
		form.Shown += method_50;
		Class118 @class = new Class118(BWN, BWn, Rectangle.Empty, bool_0: false, bool_1: false, bool_2: false);
		@class.method_15(setting_0.method_152());
		@class.Left = 5;
		@class.Top = 5;
		@class.BorderStyle = BorderStyle.FixedSingle;
		@class.method_21(bool_0: true);
		@class.Height += 10;
		@class.BXo = false;
		ThemedButton themedButton = new ThemedButton();
		themedButton.DialogResult = DialogResult.Cancel;
		themedButton.Text = Class333.smethod_823();
		themedButton.Size = new Size(80, 30);
		themedButton.Location = new Point(@class.Width - themedButton.Width, @class.Height + 15);
		ThemedButton themedButton2 = new ThemedButton();
		themedButton2.DialogResult = DialogResult.OK;
		themedButton2.Text = Class333.smethod_821();
		themedButton2.Size = new Size(80, 30);
		themedButton2.Location = new Point(themedButton.Left - (10 + themedButton2.Width), @class.Height + 15);
		form.CancelButton = themedButton;
		Size clientSize = new Size(5 + @class.Width + 5, 5 + @class.Height + 10 + themedButton2.Height + 10);
		form.ClientSize = clientSize;
		form.Controls.Add(@class);
		form.Controls.Add(themedButton2);
		form.Controls.Add(themedButton);
		BWv = @class;
		HashSet<DataIdAndAttrId> hashSet = setting_0.method_152().method_104(bool_0: false);
		foreach (DataIdAndAttrId item in hashSet)
		{
			Setting setting = BWN.method_32(item);
			if (setting != null && !setting.method_207())
			{
				setting.method_40(method_51);
			}
		}
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			int num = (int)PortFunction.smethod_17(Enum104.BAM, Enum105.Bae, (ushort)setting_2.method_64());
			if (setting_1.method_256() != num)
			{
				Class280 class2 = Form23.smethod_95();
				class2?.method_2(setting_1.method_64());
				setting_1.method_272(num, bool_0: true);
				class2?.method_4();
				Form23.smethod_74(setting_1.method_64());
			}
		}
		else if (setting_0.method_256() != 0)
		{
			Class280 class3 = Form23.smethod_95();
			class3?.method_2(setting_0.method_64());
			setting_0.method_272(0, bool_0: true);
			class3?.method_4();
			Form23.smethod_74(setting_0.method_64());
		}
		foreach (DataIdAndAttrId item2 in hashSet)
		{
			Setting setting2 = BWN.method_32(item2);
			if (setting2 != null && !setting2.method_207())
			{
				setting2.method_41(method_51);
			}
		}
		BWv = null;
		form.Shown -= method_50;
		form.Dispose();
	}

	private void method_50(object sender, EventArgs e)
	{
		if (BWv != null)
		{
			BWv.BXo = true;
		}
	}

	private void method_51(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate38 method = method_51;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (BWv != null && !BWv.Disposing && !BWv.IsDisposed)
		{
			BWv.method_21(bool_0: false);
		}
	}
}
