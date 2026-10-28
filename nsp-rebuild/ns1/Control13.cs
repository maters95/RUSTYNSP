using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns2;
using ns4;
using ns6;
using ns7;

namespace ns1;

internal class Control13 : Control11
{
	private delegate void Delegate50(object sender, EventArgs e);

	private delegate void Delegate51(object sender, EventArgs e);

	private bool Bmf;

	private int BmG;

	private ThemedComboBox Bmg = new ThemedComboBox();

	private Label BmH = new Label();

	private Class286 Bmh;

	private bool BmI;

	private int Bmi;

	private bool BmJ;

	internal Control13(DataIdAndAttrId dataIdAndAttrId_1, bool bool_2, int int_1, Framework framework_2, Framework framework_3, Class286 class286_0, bool bool_3)
	{
		method_2(dataIdAndAttrId_1, bool_2, int_1, framework_2, framework_3, class286_0, bool_3);
	}

	private void method_2(DataIdAndAttrId dataIdAndAttrId_1, bool bool_2, int int_1, Framework framework_2, Framework framework_3, Class286 class286_0, bool bool_3)
	{
		Bmf = bool_2;
		BmG = int_1;
		vmethod_0(framework_2, framework_3);
		vmethod_1(dataIdAndAttrId_1);
		Bmh = class286_0;
		if (Bmh != null)
		{
			BmI = bool_3;
			int[] array = Bmh.method_3(setting_0);
			int num = (Bmf ? BmG : 0);
			if (array != null && array.Length > num)
			{
				Bmi = array[num];
			}
			else
			{
				Bmh = null;
			}
		}
		vmethod_2();
		bool flag = vmethod_3();
		List<Control> list = new List<Control>();
		Form23.form23_0.method_9(method_6);
		setting_0.method_264(method_9);
		setting_0.method_40(method_8);
		foreach (Setting item in setting_0.method_285())
		{
			item.method_264(method_8);
		}
		SuspendLayout();
		bool flag2 = Form23.enum60_0 == Form23.Enum60.BpF && (bool_0 || bool_1) && framework_1 != null;
		if (flag | flag2)
		{
			BmH.Text = Class333.BcI();
			BmH.ForeColor = Form23.color_12;
			BmH.Left = 0;
			BmH.Top = 2;
			BmH.AutoSize = true;
			list.Add(BmH);
			if (!Controls.Contains(BmH))
			{
				Controls.Add(BmH);
			}
			AutoSize = false;
			Height = Bmg.Height;
			Width = 170;
		}
		else
		{
			int selectedIndex = -1;
			int num2 = 0;
			Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
			int int_2 = (Bmf ? BmG : 0);
			List<Setting.ListItems.Struct45> list2 = setting.method_102(int_2);
			Bmg.Items.Clear();
			for (int i = 0; i < list2.Count; i++)
			{
				string text = setting.method_287(list2[i].bBv, int_2);
				Bmg.Items.Add(text);
				if (Bmf)
				{
					if (list2[i].bBv == setting.method_258(BmG))
					{
						selectedIndex = i;
					}
				}
				else if (list2[i].bBv == setting.method_256())
				{
					selectedIndex = i;
				}
				if (text.Length > num2)
				{
					num2 = text.Length;
				}
			}
			Bmg.Font = new Font(Bmg.Font.FontFamily, 8.25f, Bmg.Font.Style);
			Bmg.SelectedIndex = selectedIndex;
			Bmg.DropDownStyle = ComboBoxStyle.DropDownList;
			Bmg.Left = 0;
			Bmg.Top = 0;
			if (num2 >= 7)
			{
				Bmg.Width = 170;
			}
			else
			{
				Bmg.Width = 70;
			}
			Bmg.GotFocus += Bmg_GotFocus;
			Bmg.SelectedIndexChanged += Bmg_SelectedIndexChanged;
			list.Add(Bmg);
			if (!Controls.Contains(Bmg))
			{
				Controls.Add(Bmg);
			}
			pictureBox_0.Tag = setting_0;
			pictureBox_0.Width = 18;
			pictureBox_0.Height = 18;
			pictureBox_0.Left = Bmg.Right + 5;
			pictureBox_0.Top = 1;
			pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox_0.Click += method_5;
			list.Add(pictureBox_0);
			if (!Controls.Contains(pictureBox_0))
			{
				Controls.Add(pictureBox_0);
			}
			pictureBox_0.Visible = false;
			MouseEnter += vmethod_4;
			Bmg.MouseEnter += vmethod_4;
			pictureBox_0.MouseEnter += vmethod_4;
			Bmg.MouseLeave += vmethod_5;
			MouseLeave += vmethod_5;
			AutoSize = false;
			Height = Bmg.Height;
			Width = pictureBox_0.Right;
		}
		for (int num3 = Controls.Count - 1; num3 >= 0; num3--)
		{
			if (!list.Contains(Controls[num3]))
			{
				Controls.RemoveAt(num3);
			}
		}
		method_4();
		method_10();
		ResumeLayout(performLayout: true);
	}

	[SpecialName]
	internal ThemedComboBox method_3()
	{
		return Bmg;
	}

	protected override void vmethod_4(object sender, EventArgs e)
	{
		if (Form23.pictureBox_1 != pictureBox_0)
		{
			if (!Form23.bool_28 && Form23.pictureBox_1 != null)
			{
				Form23.pictureBox_1.Visible = false;
			}
			bool flag = ((!Bmf) ? setting_0.method_35() : setting_0.method_131()[0, 0, BmG]);
			Form23.bool_28 = flag && !setting_0.method_122();
			Form23.pictureBox_1 = pictureBox_0;
		}
		pictureBox_0.Visible = true;
	}

	protected override void vmethod_5(object sender, EventArgs e)
	{
		if (!ClientRectangle.Contains(PointToClient(System.Windows.Forms.Cursor.Position)))
		{
			bool flag = ((!Bmf) ? setting_0.method_35() : setting_0.method_131()[0, 0, BmG]);
			pictureBox_0.Visible = ((pictureBox_0.Image != null) & flag) && !setting_0.method_122();
		}
	}

	private void method_4()
	{
		bool enabled = framework_0.method_4() && (Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) && ((!Bmf) ? setting_0.method_35() : setting_0.method_131()[0, 0, BmG]);
		Bmg.Enabled = enabled;
		if (Bmg.Enabled && !setting_0.method_122())
		{
			switch (setting_0.method_124())
			{
			default:
				Bmg.BackColor = Color.Red;
				pictureBox_0.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Error:
				Bmg.BackColor = Color.Red;
				pictureBox_0.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Warning:
				Bmg.BackColor = Color.Orange;
				pictureBox_0.Image = GeneralResources.YellowWarning;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (Form23.smethod_28(framework_0.aXc, bool_53: true))
				{
					Bmg.BackColor = Color.Red;
					pictureBox_0.Image = GeneralResources.RedError;
				}
				else
				{
					Bmg.BackColor = Color.Orange;
					pictureBox_0.Image = GeneralResources.YellowWarning;
				}
				break;
			}
			pictureBox_0.Visible = true;
		}
		else
		{
			bool flag = bool_0 || bool_1;
			if (setting_1 != null && !flag && !setting_0.method_281(setting_1, BmG))
			{
				Bmg.BackColor = Form23.color_9;
			}
			else if (Bmg.Enabled)
			{
				Bmg.BackColor = Form23.color_32;
			}
			else
			{
				Bmg.BackColor = Form23.color_35;
			}
			pictureBox_0.Visible = false;
			pictureBox_0.Image = GeneralResources.QuestionMark;
		}
		TabStop = Bmg.Enabled;
		Bmg.TabStop = TabStop;
		Bmg.Invalidate();
	}

	private void method_5(object sender, EventArgs e)
	{
		Form23.smethod_51(setting_0, BmG, this);
	}

	private void Bmg_GotFocus(object sender, EventArgs e)
	{
		Form23.form23_0.control4_0.method_59(setting_0);
		if (framework_1 != null && Bmg.BackColor == Form23.color_9)
		{
			Form23.smethod_51(setting_0, BmG, this);
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		if (!bool_0 && !bool_1)
		{
			method_7();
			method_4();
		}
		else
		{
			vmethod_8();
		}
	}

	private void method_7()
	{
		Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
		List<Setting.ListItems.Struct45> list = setting.method_102(Bmf ? BmG : 0);
		int num = -1;
		for (int i = 0; i < list.Count; i++)
		{
			if (Bmf)
			{
				if (list[i].bBv == setting.method_258(BmG))
				{
					num = i;
				}
			}
			else if (list[i].bBv == setting.method_256())
			{
				num = i;
			}
		}
		if (Bmg.SelectedIndex != num)
		{
			Bmg.SelectedIndex = num;
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate50 method = method_8;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_4();
	}

	private void method_9(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate51 method = method_9;
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
			method_7();
			if (setting_1 != null)
			{
				method_4();
			}
		}
	}

	private void method_10()
	{
		FontStyle fontStyle = FontStyle.Regular;
		if (Bmh != null && BmI)
		{
			Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
			if (Bmf)
			{
				if (setting.method_258(BmG) != Bmi)
				{
					fontStyle = FontStyle.Italic;
				}
			}
			else if (setting.method_256() != Bmi)
			{
				fontStyle = FontStyle.Italic;
			}
		}
		if (Bmg.Font.Style != fontStyle)
		{
			Font font = Bmg.Font;
			Bmg.Font = new Font(Bmg.Font.FontFamily, Bmg.Font.Size, fontStyle);
			font.Dispose();
		}
	}

	private void Bmg_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		if (Form23.bool_2)
		{
			Form23.smethod_75(setting_0.method_69());
			return;
		}
		if (BmJ)
		{
			BmJ = false;
			return;
		}
		List<Setting.ListItems.Struct45> list = setting_0.method_102(Bmf ? BmG : 0);
		int selectedIndex = Bmg.SelectedIndex;
		if (selectedIndex != -1 && setting_0.method_25())
		{
			if (Bmf)
			{
				if (setting_0.method_258(BmG) == list[selectedIndex].bBv)
				{
					return;
				}
			}
			else if (setting_0.method_256() == list[selectedIndex].bBv)
			{
				return;
			}
			Class280 @class = Form23.smethod_95();
			@class?.method_3(setting_0.method_69());
			if (Bmf)
			{
				setting_0.method_274(BmG, list[selectedIndex].bBv, bool_0: true);
			}
			else
			{
				setting_0.method_272(list[selectedIndex].bBv, bool_0: true);
			}
			@class?.method_4();
			Form23.smethod_75(setting_0.method_69());
			return;
		}
		int num = 0;
		while (true)
		{
			if (num >= list.Count)
			{
				return;
			}
			if (Bmf)
			{
				if (list[num].bBv == setting_0.method_258(BmG))
				{
					BmJ = true;
					Bmg.SelectedIndex = num;
					return;
				}
			}
			else if (list[num].bBv == setting_0.method_256())
			{
				break;
			}
			num++;
		}
		BmJ = true;
		Bmg.SelectedIndex = num;
	}

	protected override void vmethod_8()
	{
		method_11();
		if (Parent != null)
		{
			Parent.SuspendLayout();
		}
		method_2(dataIdAndAttrId_0, Bmf, BmG, framework_0, framework_1, Bmh, BmI);
		if (Parent != null)
		{
			Parent.ResumeLayout(performLayout: true);
		}
	}

	protected override void vmethod_10()
	{
		Class280 @class = Form23.smethod_95();
		@class?.method_3(setting_0.method_69());
		if (Bmf)
		{
			setting_0.method_247(BmG, bool_0: true);
		}
		else
		{
			setting_0.method_246(bool_0: true);
		}
		@class?.method_4();
		Form23.smethod_75(setting_0.method_69());
	}

	private void method_11()
	{
		try
		{
			Bmg.SelectedIndexChanged -= Bmg_SelectedIndexChanged;
			Bmg.GotFocus -= Bmg_GotFocus;
			MouseEnter -= vmethod_4;
			Bmg.MouseEnter -= vmethod_4;
			pictureBox_0.MouseEnter -= vmethod_4;
			Bmg.MouseLeave -= vmethod_5;
			MouseLeave -= vmethod_5;
			pictureBox_0.Click -= method_5;
			setting_0.method_265(method_9);
			foreach (Setting item in setting_0.method_285())
			{
				item.method_265(method_8);
			}
			setting_0.method_41(method_8);
			if (setting_3 != null)
			{
				setting_3.method_41(vmethod_6);
			}
			if (setting_4 != null)
			{
				setting_4.method_265(vmethod_7);
			}
			Form23.form23_0.method_10(method_6);
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
