using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal class Control12 : Control11
{
	private delegate void Delegate48(object sender, EventArgs e);

	private delegate void Delegate49(object sender, EventArgs e);

	private Setting Bmd;

	private Setting BmE;

	private Control8 Bme = new Control8();

	private Label BmF = new Label();

	internal Control12(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3)
	{
		method_2(dataIdAndAttrId_1, framework_2, framework_3);
	}

	private void method_2(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3)
	{
		vmethod_0(framework_2, framework_3);
		Bme.method_0(framework_0);
		vmethod_1(dataIdAndAttrId_1);
		Bmd = framework_0.method_31(setting_0.method_256());
		if (framework_1 != null && setting_1 != null)
		{
			BmE = framework_1.method_31(setting_1.method_256());
		}
		vmethod_2();
		bool flag = vmethod_3();
		List<Control> list = new List<Control>();
		Form23.form23_0.method_9(method_5);
		SuspendLayout();
		bool flag2 = Form23.enum60_0 == Form23.Enum60.BpF && (bool_0 || bool_1);
		if (flag | flag2)
		{
			if (flag2)
			{
				BmF.Text = Class333.Bch() + setting_0.method_22(bool_0: true) + Class333.smethod_180();
			}
			else
			{
				BmF.Text = Class333.smethod_180() + setting_0.method_22(bool_0: true) + Class333.BAO();
			}
			BmF.ForeColor = Form23.color_12;
			BmF.Left = 0;
			BmF.Top = 2;
			BmF.AutoSize = true;
			list.Add(BmF);
			if (!Controls.Contains(BmF))
			{
				Controls.Add(BmF);
			}
			AutoSize = false;
			Height = 18;
			Width = BmF.Width;
		}
		else
		{
			setting_0.method_264(method_9);
			setting_0.method_40(method_10);
			Bme.method_4(method_6);
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				if (BmE == null)
				{
					Bme.method_2(0);
				}
				else
				{
					Bme.method_2(BmE.method_64());
				}
			}
			else if (Bmd == null)
			{
				Bme.method_2(0);
			}
			else
			{
				Bme.method_2(Bmd.method_64());
			}
			Bme.Left = 0;
			Bme.Top = 0;
			list.Add(Bme);
			if (!Controls.Contains(Bme))
			{
				Controls.Add(Bme);
			}
			pictureBox_0.Tag = setting_0;
			pictureBox_0.Width = 18;
			pictureBox_0.Height = 18;
			pictureBox_0.Left = Bme.Right;
			pictureBox_0.Top = 1;
			pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox_0.Click += method_4;
			list.Add(pictureBox_0);
			if (!Controls.Contains(pictureBox_0))
			{
				Controls.Add(pictureBox_0);
			}
			pictureBox_0.Visible = false;
			MouseEnter += vmethod_4;
			Bme.MouseEnter += vmethod_4;
			pictureBox_0.MouseEnter += vmethod_4;
			MouseLeave += vmethod_5;
		}
		for (int num = Controls.Count - 1; num >= 0; num--)
		{
			if (!list.Contains(Controls[num]))
			{
				Controls.RemoveAt(num);
			}
		}
		method_3();
		if (!flag && !flag2)
		{
			AutoSize = false;
			Height = Bme.Height;
			Width = pictureBox_0.Right;
		}
		ResumeLayout(performLayout: true);
	}

	private void method_3()
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG && setting_0.method_35() && !setting_0.method_122())
		{
			switch (setting_0.method_124())
			{
			default:
				pictureBox_0.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Error:
				pictureBox_0.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Warning:
				pictureBox_0.Image = GeneralResources.YellowWarning;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (Form23.smethod_28(framework_0.aXc, bool_53: true))
				{
					pictureBox_0.Image = GeneralResources.RedError;
				}
				else
				{
					pictureBox_0.Image = GeneralResources.YellowWarning;
				}
				break;
			}
			pictureBox_0.Visible = true;
		}
		else
		{
			pictureBox_0.Visible = false;
			pictureBox_0.Image = GeneralResources.QuestionMark;
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		Form23.smethod_50(setting_0, this);
	}

	private void method_5(object sender, EventArgs e)
	{
		if (!bool_0 && !bool_1)
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				if (BmE == null)
				{
					Bme.method_2(0);
				}
				else
				{
					Bme.method_2(BmE.method_64());
				}
			}
			else if (Bmd == null)
			{
				Bme.method_2(0);
			}
			else
			{
				Bme.method_2(Bmd.method_64());
			}
			method_3();
		}
		else
		{
			vmethod_8();
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_3(setting_0.method_69());
			setting_0.method_272(Bme.method_3(), bool_0: true);
			if (setting_0.method_161() != 0)
			{
				method_7(setting_0.method_161());
			}
			if (setting_0.method_6() is Class243)
			{
				method_8();
			}
			@class?.method_4();
			Bmd = framework_0.method_31(Bme.method_3());
			Form23.smethod_75(setting_0.method_69());
		}
	}

	private void method_7(int int_1)
	{
		Setting setting = framework_0.method_31(Bme.method_3());
		if (setting == null)
		{
			return;
		}
		Setting setting2 = framework_0.method_31(int_1);
		if (setting2 == null || setting2.method_70() == 0)
		{
			return;
		}
		string text = setting.method_60(Enum96.aYt);
		if (!string.IsNullOrWhiteSpace(text))
		{
			if (Encoding.GetEncoding(setting2.method_70()).GetBytes(text).Length > setting2.method_242()[2])
			{
				text = setting.method_60(Enum96.aYT);
			}
		}
		else
		{
			text = setting.method_60(Enum96.aYT);
		}
		if (!string.IsNullOrWhiteSpace(text))
		{
			setting2.method_262(text, bool_0: true);
			Form23.smethod_75(setting2.method_69());
		}
	}

	private void method_8()
	{
		Setting setting = framework_0.method_31(Bme.method_3());
		if (setting == null)
		{
			return;
		}
		Class243 @class = setting_0.method_6() as Class243;
		if (@class.method_312() != null)
		{
			Setting setting2 = framework_0.method_32(new DataIdAndAttrId(setting.method_64(), 4));
			if (setting2 != null)
			{
				@class.method_312().method_272(setting2.method_256(), bool_0: true);
			}
			else
			{
				@class.method_312().method_272((setting.method_231() << 8) | Class233.smethod_23(setting.method_231()), bool_0: true);
			}
			Form23.smethod_75(@class.method_312().method_69());
		}
		if (@class.method_311() != null)
		{
			Setting setting3 = framework_0.method_32(new DataIdAndAttrId(setting.method_64(), 5));
			if (setting3 != null)
			{
				@class.method_311().method_272(setting3.method_256(), bool_0: true);
			}
			else
			{
				@class.method_311().method_272(Class233.smethod_39(setting.method_231()), bool_0: true);
			}
			Form23.smethod_75(@class.method_311().method_69());
		}
		if (@class.method_307() != null)
		{
			Setting setting4 = framework_0.method_32(new DataIdAndAttrId(setting.method_64(), 8));
			if (setting4 != null)
			{
				@class.method_307().method_272(setting4.method_256(), bool_0: true);
			}
			else
			{
				@class.method_307().method_272(setting.method_224(), bool_0: true);
			}
			Form23.smethod_75(@class.method_307().method_69());
		}
		if (@class.method_308() != null)
		{
			Setting setting5 = framework_0.method_32(new DataIdAndAttrId(setting.method_64(), 9));
			if (setting5 != null)
			{
				@class.method_308().method_272(setting5.method_256(), bool_0: true);
			}
			else
			{
				@class.method_308().method_272(setting.method_225(), bool_0: true);
			}
			Form23.smethod_75(@class.method_308().method_69());
		}
		if (@class.method_309() != null)
		{
			Setting setting6 = framework_0.method_32(new DataIdAndAttrId(setting.method_64(), 6));
			if (setting6 != null)
			{
				@class.method_309().method_272(setting6.method_256(), bool_0: true);
			}
			else
			{
				@class.method_309().method_272(setting.method_226(), bool_0: true);
			}
			Form23.smethod_75(@class.method_309().method_69());
		}
		if (@class.method_310() != null)
		{
			Setting setting7 = framework_0.method_32(new DataIdAndAttrId(setting.method_64(), 7));
			if (setting7 != null)
			{
				@class.method_310().method_272(setting7.method_256(), bool_0: true);
			}
			else
			{
				@class.method_310().method_272(setting.method_227(), bool_0: true);
			}
			Form23.smethod_75(@class.method_310().method_69());
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate48 method = method_9;
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
			if (Bme.method_3() != num)
			{
				Bme.method_2(num);
			}
			Bmd = framework_0.method_31(num);
			method_3();
		}
	}

	private void method_10(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate49 method = method_10;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_3();
	}

	protected override void vmethod_8()
	{
		method_11();
		if (Parent != null)
		{
			Parent.SuspendLayout();
		}
		method_2(dataIdAndAttrId_0, framework_0, framework_1);
		if (Parent != null)
		{
			Parent.ResumeLayout(performLayout: true);
		}
	}

	private void method_11()
	{
		try
		{
			setting_0.method_265(method_9);
			setting_0.method_41(method_10);
			Bme.method_5(method_6);
			MouseEnter -= vmethod_4;
			Bme.MouseEnter -= vmethod_4;
			pictureBox_0.MouseEnter -= vmethod_4;
			MouseLeave -= vmethod_5;
			pictureBox_0.Click -= method_4;
			if (setting_3 != null)
			{
				setting_3.method_41(vmethod_6);
			}
			if (setting_4 != null)
			{
				setting_4.method_265(vmethod_7);
			}
			Form23.form23_0.method_10(method_5);
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
