using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using ns2;
using ns4;
using ns6;
using ns7;

namespace ns1;

internal class Control15 : Control11
{
	private delegate void Delegate60(object sender, EventArgs e);

	private delegate void Delegate61(object sender, EventArgs e);

	private Class148 BmR = new Class148();

	private LinkLabel Bmr = new LinkLabel();

	private Label BmS = new Label();

	private Class286 Bms;

	private bool BmT;

	private int Bmt;

	internal Control15(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3, Class286 class286_0, bool bool_2)
	{
		method_2(dataIdAndAttrId_1, framework_2, framework_3, class286_0, bool_2);
	}

	private void method_2(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3, Class286 class286_0, bool bool_2)
	{
		vmethod_0(framework_2, framework_3);
		vmethod_1(dataIdAndAttrId_1);
		Bms = class286_0;
		if (Bms != null)
		{
			BmT = bool_2;
			int[] array = Bms.method_3(setting_0);
			if (array != null && array.Length == 1)
			{
				Bmt = array[0];
			}
			else
			{
				Bms = null;
			}
		}
		vmethod_2();
		bool flag = vmethod_3();
		List<Control> list = new List<Control>();
		Form23.form23_0.method_9(method_7);
		setting_0.method_264(method_9);
		setting_0.method_40(method_8);
		method_3();
		bool flag2 = Form23.enum60_0 == Form23.Enum60.BpF && (bool_0 || bool_1) && framework_1 != null;
		if (flag | flag2)
		{
			string text = Class333.smethod_180() + setting_0.method_22(bool_0: true) + Class333.BAO();
			int width = TextRenderer.MeasureText(text, BmS.Font).Width;
			if (flag2)
			{
				BmS.Text = Class333.Bci() + setting_0.method_22(bool_0: true) + Class333.smethod_180();
			}
			else
			{
				BmS.Text = text;
			}
			BmS.ForeColor = Form23.color_12;
			BmS.Left = 0;
			BmS.Top = 2;
			BmS.AutoSize = true;
			list.Add(BmS);
			if (!Controls.Contains(BmS))
			{
				Controls.Add(BmS);
			}
			AutoSize = false;
			Height = 18;
			Width = width;
		}
		else
		{
			bool num = setting_0.method_191() != 0 || setting_0.method_193() != 0;
			BmR.Font = new Font(BmR.Font.FontFamily, 8.25f, BmR.Font.Style);
			BmR.Left = 0;
			BmR.Top = 1;
			if (num)
			{
				BmR.Width = 400;
				BmR.Height = 18;
			}
			else
			{
				BmR.AutoSize = true;
			}
			if (Form23.enum60_0 == Form23.Enum60.BpG && setting_1 != null)
			{
				BmR.bool_0 = true;
				BmR.Checked = setting_1.method_256() != 0;
			}
			else
			{
				BmR.bool_0 = false;
				BmR.Checked = setting_0.method_256() != 0;
			}
			BmR.CheckedChanged += BmR_CheckedChanged;
			BmR.GotFocus += BmR_GotFocus;
			list.Add(BmR);
			if (!Controls.Contains(BmR))
			{
				Controls.Add(BmR);
			}
			Bmr.Font = new Font(BmR.Font.FontFamily, 8.25f, BmR.Font.Style);
			Bmr.Left = 18;
			Bmr.Top = 2;
			Bmr.AutoSize = true;
			Bmr.Tag = setting_0.method_64();
			list.Add(Bmr);
			if (!Controls.Contains(Bmr))
			{
				Controls.Add(Bmr);
			}
			if (framework_0.aWZ.Contains(setting_0.method_64()))
			{
				Bmr.Visible = true;
				Bmr.BringToFront();
			}
			else
			{
				Bmr.Visible = false;
			}
			pictureBox_0.Tag = setting_0;
			pictureBox_0.Width = 18;
			pictureBox_0.Height = 18;
			pictureBox_0.Left = BmR.Width;
			pictureBox_0.Top = 0;
			pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox_0.Click += method_6;
			list.Add(pictureBox_0);
			if (!Controls.Contains(pictureBox_0))
			{
				Controls.Add(pictureBox_0);
			}
			pictureBox_0.Visible = false;
			MouseEnter += vmethod_4;
			BmR.MouseEnter += vmethod_4;
			Bmr.MouseEnter += vmethod_4;
			pictureBox_0.MouseEnter += vmethod_4;
			Bmr.MouseLeave += vmethod_5;
			BmR.MouseLeave += vmethod_5;
			MouseLeave += vmethod_5;
		}
		for (int num2 = Controls.Count - 1; num2 >= 0; num2--)
		{
			if (!list.Contains(Controls[num2]))
			{
				Controls.RemoveAt(num2);
			}
		}
		method_5();
		method_10();
		if (!flag && !flag2)
		{
			AutoSize = false;
			Height = pictureBox_0.Height;
			if (framework_1 != null && (bool_0 || bool_1))
			{
				Width = TextRenderer.MeasureText(Class333.smethod_180() + setting_0.method_22(bool_0: true) + Class333.BAO(), BmR.Font).Width;
			}
			else
			{
				Width = pictureBox_0.Right;
			}
		}
	}

	private void method_3()
	{
		string text = setting_0.method_22(bool_0: false);
		if (setting_0.method_191() != 0 || setting_0.method_193() != 0)
		{
			text = ((setting_0.method_256() != 0) ? (text + Class333.BcL()) : (text + Class333.Bck()));
		}
		BmR.Text = text;
		Bmr.Text = text;
	}

	[SpecialName]
	internal LinkLabel method_4()
	{
		return Bmr;
	}

	protected override void vmethod_4(object sender, EventArgs e)
	{
		base.vmethod_4(sender, e);
		BmR.Invalidate();
	}

	protected override void vmethod_5(object sender, EventArgs e)
	{
		base.vmethod_5(sender, e);
		BmR.Invalidate();
	}

	private void method_5()
	{
		Setting setting = setting_0;
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			BmR.Enabled = false;
			if (setting_1 != null)
			{
				setting = setting_1;
			}
		}
		else
		{
			BmR.Enabled = setting_0.method_35() && framework_0.method_4();
		}
		BmR.BackColor = Form23.color_11;
		Bmr.BackColor = Color.Transparent;
		pictureBox_0.BackColor = Form23.color_11;
		if (BmR.Checked)
		{
			Bmr.LinkBehavior = LinkBehavior.AlwaysUnderline;
		}
		else
		{
			Bmr.LinkBehavior = LinkBehavior.NeverUnderline;
		}
		if (setting.method_35() && !setting.method_122())
		{
			switch (setting.method_124())
			{
			default:
				pictureBox_0.Image = GeneralResources.RedError;
				BmR.ForeColor = Form23.color_7;
				Bmr.LinkColor = Form23.color_7;
				break;
			case IllegalitySeverityLevel.Error:
				pictureBox_0.Image = GeneralResources.RedError;
				BmR.ForeColor = Form23.color_7;
				Bmr.LinkColor = Form23.color_7;
				break;
			case IllegalitySeverityLevel.Warning:
				pictureBox_0.Image = GeneralResources.YellowWarning;
				BmR.ForeColor = Color.Orange;
				Bmr.LinkColor = Color.Orange;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (Form23.smethod_28(framework_0.aXc, bool_53: true))
				{
					pictureBox_0.Image = GeneralResources.RedError;
					BmR.ForeColor = Form23.color_7;
					Bmr.LinkColor = Form23.color_7;
				}
				else
				{
					pictureBox_0.Image = GeneralResources.YellowWarning;
					BmR.ForeColor = Color.Orange;
					Bmr.LinkColor = Color.Orange;
				}
				break;
			}
			pictureBox_0.Visible = true;
		}
		else
		{
			pictureBox_0.Visible = false;
			pictureBox_0.Image = GeneralResources.QuestionMark;
			bool flag = bool_0 || bool_1;
			if (setting_1 != null && !flag && !setting_0.method_282(setting_1))
			{
				BmR.ForeColor = Form23.color_9;
				Bmr.LinkColor = Form23.color_9;
			}
			else if (!BmR.Checked)
			{
				BmR.ForeColor = Form23.color_36;
				Bmr.LinkColor = Form23.color_36;
			}
			else
			{
				BmR.ForeColor = Form23.color_12;
				Bmr.LinkColor = Form23.color_13;
			}
		}
		TabStop = BmR.Enabled;
		BmR.TabStop = TabStop;
	}

	private void method_6(object sender, EventArgs e)
	{
		Form23.smethod_50(setting_0, this);
	}

	private void BmR_GotFocus(object sender, EventArgs e)
	{
		Form23.form23_0.control4_0.method_59(setting_0);
		if (framework_1 != null && BmR.ForeColor == Form23.color_9)
		{
			Form23.smethod_50(setting_0, this);
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		if (!bool_0 && !bool_1)
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				if (setting_1 != null)
				{
					BmR.bool_0 = true;
					if (BmR.Checked != (setting_1.method_256() != 0))
					{
						BmR.Checked = setting_1.method_256() != 0;
					}
					method_5();
				}
			}
			else
			{
				BmR.bool_0 = false;
				if (BmR.Checked != (setting_0.method_256() != 0))
				{
					BmR.Checked = setting_0.method_256() != 0;
				}
				method_5();
			}
		}
		else
		{
			vmethod_8();
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate60 method = method_8;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_5();
	}

	private void method_9(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate61 method = method_9;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_10();
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			int num = setting_0.method_256();
			if (BmR.Checked != (num != 0))
			{
				BmR.Checked = num != 0;
			}
			method_5();
			method_3();
		}
	}

	private void method_10()
	{
		FontStyle fontStyle = FontStyle.Regular;
		if (Bms != null && BmT)
		{
			Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
			if (setting.method_256() != Bmt)
			{
				fontStyle = FontStyle.Italic;
			}
		}
		if (BmR.Font.Style != fontStyle)
		{
			Font font = BmR.Font;
			BmR.Font = new Font(BmR.Font.FontFamily, BmR.Font.Size, fontStyle);
			font.Dispose();
		}
	}

	private void BmR_CheckedChanged(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		if (!Form23.bool_2)
		{
			Class148 @class = sender as Class148;
			if ((@class.Checked && setting_0.method_256() == 1) || (!@class.Checked && setting_0.method_256() == 0))
			{
				return;
			}
			if (@class.Checked)
			{
				Setting setting = null;
				MenuNode menuNode_ = null;
				string text = setting_0.method_47();
				if (text == null)
				{
					if (setting_0.method_6() != null && setting_0.method_6().method_45() != null)
					{
						text = setting_0.method_6().method_45().method_64();
						if (text != null)
						{
							menuNode_ = setting_0.method_6().method_45();
						}
						else if (setting_0.method_152() != null)
						{
							text = setting_0.method_152().method_64();
							if (text != null)
							{
								menuNode_ = setting_0.method_152();
							}
						}
					}
				}
				else
				{
					setting = setting_0;
				}
				Class280 class2 = Form23.smethod_95();
				if (text != null && !Form13.smethod_0(setting, menuNode_))
				{
					Form13 form = new Form13(text, setting, menuNode_);
					if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
					{
						class2?.method_3(setting_0.method_69());
						setting_0.method_272(1, bool_0: true);
					}
					else
					{
						@class.Checked = false;
					}
					form.Dispose();
				}
				else
				{
					class2?.method_3(setting_0.method_69());
					setting_0.method_272(1, bool_0: true);
				}
				if (@class.Checked)
				{
					if (framework_0.aWZ.Contains(setting_0.method_64()) && setting_0.method_6() != null)
					{
						PortFunction.smethod_20(setting_0.method_6(), bool_0: false);
					}
					class2?.method_4();
				}
			}
			else
			{
				Class280 class3 = Form23.smethod_95();
				class3?.method_3(setting_0.method_69());
				setting_0.method_272(0, bool_0: true);
				class3?.method_4();
			}
		}
		Form23.smethod_75(setting_0.method_69());
	}

	public override string ToString()
	{
		return BmR.Text;
	}

	protected override void vmethod_8()
	{
		method_11();
		if (Parent != null)
		{
			Parent.SuspendLayout();
		}
		method_2(dataIdAndAttrId_0, framework_0, framework_1, Bms, BmT);
		if (Parent != null)
		{
			Parent.ResumeLayout(performLayout: true);
		}
	}

	private void method_11()
	{
		try
		{
			BmR.CheckedChanged -= BmR_CheckedChanged;
			BmR.GotFocus -= BmR_GotFocus;
			MouseEnter -= vmethod_4;
			BmR.MouseEnter -= vmethod_4;
			Bmr.MouseEnter -= vmethod_4;
			pictureBox_0.MouseEnter -= vmethod_4;
			Bmr.MouseLeave -= vmethod_5;
			BmR.MouseLeave -= vmethod_5;
			MouseLeave -= vmethod_5;
			pictureBox_0.Click -= method_6;
			setting_0.method_265(method_9);
			setting_0.method_41(method_8);
			if (setting_3 != null)
			{
				setting_3.method_41(vmethod_6);
			}
			if (setting_4 != null)
			{
				setting_4.method_265(vmethod_7);
			}
			Form23.form23_0.method_10(method_7);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		method_11();
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
