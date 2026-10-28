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
using ns5;
using ns6;
using ns7;

namespace ns1;

internal class Control17 : Control11
{
	private delegate void Delegate64(object sender, EventArgs e);

	private delegate void Delegate65(object sender, EventArgs e);

	internal const int BNa = 100;

	internal const int BNB = 160;

	internal const int BNb = 220;

	internal const int BNC = 320;

	internal const int BNc = 60;

	internal const int BND = 130;

	internal const int BNd = 200;

	internal const int BNE = 260;

	private const int BNe = 350;

	private const int BNF = 200;

	private bool BNf;

	private Label BNG = new Label();

	private ThemedComboBox BNg = new ThemedComboBox();

	private Class134 BNH;

	private int BNh;

	private bool BNI;

	private bool BNi;

	private Class286 BNJ;

	private bool BNj;

	private int BNK;

	private int BNk;

	private int BNL;

	private Label BNl;

	private bool BNM;

	[SpecialName]
	internal int method_2()
	{
		return BNG.Width;
	}

	internal Control17(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3, Class286 class286_0, bool bool_2, bool bool_3, bool bool_4, int int_1 = -1, int int_2 = -1, Label label_0 = null)
	{
		BNk = int_1;
		BNL = int_2;
		BNl = label_0;
		method_3(dataIdAndAttrId_1, framework_2, framework_3, class286_0, bool_2, bool_3, bool_4);
	}

	private void method_3(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3, Class286 class286_0, bool bool_2, bool bool_3, bool bool_4)
	{
		vmethod_0(framework_2, framework_3);
		vmethod_1(dataIdAndAttrId_1);
		BNJ = class286_0;
		if (BNJ != null)
		{
			BNj = bool_2;
			int[] array = BNJ.method_3(setting_0);
			if (array != null && array.Length == 1)
			{
				BNK = array[0];
			}
			else
			{
				BNJ = null;
			}
		}
		vmethod_2();
		bool flag = vmethod_3();
		List<Control> list = new List<Control>();
		Form23.form23_0.method_9(method_9);
		BNf = setting_0.method_238();
		setting_0.method_264(method_16);
		setting_0.method_40(method_14);
		if (BNL != -1)
		{
			framework_0.method_31(BNL)?.method_264(method_14);
		}
		foreach (Setting item in setting_0.method_285())
		{
			item.method_264(method_14);
		}
		BNG.Font = new Font(BNG.Font.FontFamily, 8.25f, BNG.Font.Style);
		BNg.Font = new Font(BNg.Font.FontFamily, 8.25f, BNg.Font.Style);
		BNg.DropDownStyle = ComboBoxStyle.DropDownList;
		SuspendLayout();
		bool flag2;
		if (flag2 = Form23.enum60_0 == Form23.Enum60.BpF && (bool_0 || bool_1) && framework_1 != null)
		{
			BNI = true;
			BNG.Text = Class333.Bci() + setting_0.method_22(bool_0: true) + Class333.smethod_180();
		}
		else if (flag)
		{
			BNI = true;
			BNG.Text = Class333.smethod_180() + setting_0.method_22(bool_0: true) + Class333.BAO();
		}
		else if (bool_3)
		{
			BNI = true;
			BNG.Text = setting_0.method_22(bool_0: false);
		}
		else
		{
			BNI = false;
		}
		Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
		method_15(setting);
		BNi = bool_4;
		BNg.Width = method_5();
		if (BNI)
		{
			BNG.Left = 0;
			BNG.Top = 3;
			if (BNi)
			{
				BNG.AutoSize = true;
				BNG.MinimumSize = new Size(130, 0);
				BNG.MaximumSize = new Size(0, 0);
				BNg.Left = 0;
				BNg.Top = BNG.Top + 14;
			}
			else
			{
				BNG.Height = 16;
				BNG.Width = method_4();
				BNg.Left = BNG.Right + 10;
				BNg.Top = 0;
			}
			list.Add(BNG);
			if (!Controls.Contains(BNG))
			{
				Controls.Add(BNG);
			}
		}
		else
		{
			BNg.Left = 0;
			BNg.Top = 0;
		}
		if (!flag && !flag2)
		{
			BNg.SelectedIndexChanged += BNg_SelectedIndexChanged;
			BNg.GotFocus += BNg_GotFocus;
			pictureBox_0.Tag = setting_0;
			pictureBox_0.Width = 18;
			pictureBox_0.Height = 18;
			if (BNI && BNi)
			{
				pictureBox_0.Left = Math.Max(BNg.Right, BNG.Right);
			}
			else
			{
				pictureBox_0.Left = BNg.Right;
			}
			pictureBox_0.Top = 1;
			pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox_0.Click += method_8;
			list.Add(pictureBox_0);
			if (!Controls.Contains(pictureBox_0))
			{
				Controls.Add(pictureBox_0);
			}
			pictureBox_0.Visible = false;
			MouseEnter += vmethod_4;
			BNG.MouseEnter += vmethod_4;
			BNg.MouseEnter += vmethod_4;
			pictureBox_0.MouseEnter += vmethod_4;
			BNg.MouseLeave += vmethod_5;
			MouseLeave += vmethod_5;
		}
		method_7();
		if (!flag && !flag2)
		{
			list.Add(BNg);
			if (!Controls.Contains(BNg))
			{
				Controls.Add(BNg);
			}
		}
		int num = method_20(setting);
		int num2 = 0;
		if (!flag && !flag2)
		{
			string text = null;
			List<Setting.ValDescs.Struct46> list2 = setting.method_104((BNk != -1) ? BNk : 0);
			for (int i = 0; i < list2.Count; i++)
			{
				string bBy = list2[i].bBy;
				if (!string.IsNullOrEmpty(bBy))
				{
					num2 = Math.Max(num2, (int)Math.Ceiling(((SizeF)TextRenderer.MeasureText(bBy, Font, new Size(330, -1))).Height) + 25);
					if (list2[i].bBZ == num)
					{
						text = bBy;
					}
				}
			}
			if (num2 != 0)
			{
				if (BNH == null)
				{
					BNH = new Class134();
					BNH.Font = new Font(BNH.Font.FontFamily, 8.25f, BNH.Font.Style);
					BNH.BackColor = Form23.color_17;
					BNH.ForeColor = Form23.color_12;
					BNH.ReadOnly = true;
				}
				else
				{
					BNH.Clear();
				}
				BNH.ScrollBars = RichTextBoxScrollBars.None;
				if (!string.IsNullOrEmpty(text))
				{
					BNH.Text = text;
				}
				BNH.Left = pictureBox_0.Right + 5;
				BNH.Top = 3;
				BNH.AutoSize = false;
				BNH.Width = 350;
				BNH.Height = ((num2 > 200) ? 200 : num2);
				list.Add(BNH);
				if (!Controls.Contains(BNH))
				{
					Controls.Add(BNH);
				}
				BNH.ScrollBars = RichTextBoxScrollBars.Vertical;
				BNH.method_0();
			}
		}
		for (int num3 = Controls.Count - 1; num3 >= 0; num3--)
		{
			if (!list.Contains(Controls[num3]))
			{
				Controls.RemoveAt(num3);
			}
		}
		AutoSize = false;
		bool flag3;
		if (flag3 = framework_1 != null && (bool_0 || bool_1))
		{
			if (BNi)
			{
				Width = TextRenderer.MeasureText(Class333.smethod_180() + setting_0.method_22(bool_0: true) + Class333.BAO(), BNG.Font).Width;
			}
			else
			{
				Width = method_4() + 10 + method_5();
			}
		}
		if (flag | flag2)
		{
			if (BNi)
			{
				if (flag3)
				{
					Height = 17 + BNg.Height;
				}
				else
				{
					Width = BNG.Width;
					Height = BNG.Height * 2;
				}
			}
			else if (flag3)
			{
				Height = BNg.Height;
			}
			else
			{
				Width = BNG.Width;
				Height = BNG.Height;
			}
		}
		else if (BNI)
		{
			if (BNi)
			{
				if (flag3)
				{
					Height = 17 + BNg.Height;
				}
				else
				{
					Width = Math.Max(BNG.Width, pictureBox_0.Right);
					Height = BNg.Bottom;
				}
			}
			else if (flag3)
			{
				if (num2 != 0)
				{
					Height = BNH.Bottom;
					Width = Math.Max(BNH.Right, Width);
				}
				else
				{
					Height = BNg.Height;
				}
			}
			else if (num2 != 0)
			{
				Height = BNH.Bottom;
				Width = BNH.Right;
			}
			else
			{
				Width = pictureBox_0.Right;
				Height = BNg.Height;
			}
		}
		else
		{
			Width = pictureBox_0.Right;
			Height = BNg.Height;
		}
		method_17();
		ResumeLayout(performLayout: true);
	}

	private int method_4()
	{
		if (string.IsNullOrWhiteSpace(BNG.Text))
		{
			return 2;
		}
		int width = TextRenderer.MeasureText(BNG.Text, BNG.Font).Width;
		if (width < 100)
		{
			return 100;
		}
		if (width < 160)
		{
			return 160;
		}
		if (width < 220)
		{
			return 220;
		}
		return 320;
	}

	private int method_5()
	{
		bool flag = BNh <= 35;
		bool flag2 = BNh <= 105 && !flag;
		bool flag3 = BNh <= 175 && !flag && !flag2;
		if (BNI)
		{
			if (BNi)
			{
				return 130;
			}
			if (flag)
			{
				return 60;
			}
			if (flag2)
			{
				return 130;
			}
			if (flag3)
			{
				return 200;
			}
			return 260;
		}
		if (flag)
		{
			return 60;
		}
		if (flag2)
		{
			return 130;
		}
		if (flag3)
		{
			return 200;
		}
		return 260;
	}

	internal void method_6(int int_1)
	{
		if (BNi)
		{
			return;
		}
		int num = int_1 - BNG.Width;
		if (num > 0)
		{
			BNG.Width += num;
			BNg.Left += num;
			pictureBox_0.Left += num;
			if (BNH != null)
			{
				BNH.Left += num;
				BNH.method_0();
			}
			Width += num;
		}
	}

	private void method_7()
	{
		if (setting_0.method_35() && framework_0.method_4())
		{
			BNG.ForeColor = Form23.color_12;
		}
		else
		{
			BNG.ForeColor = Form23.color_36;
		}
		bool flag;
		if (Form23.enum60_0 == Form23.Enum60.BpG && setting_1 != null)
		{
			flag = false;
		}
		else if (BNL != -1)
		{
			Setting setting = framework_0.method_31(BNL);
			if (setting != null)
			{
				flag = setting.method_256() != 0 && setting.method_35();
				if (BNl != null)
				{
					BNl.ForeColor = (flag ? Form23.color_12 : Form23.color_36);
				}
			}
			else
			{
				flag = true;
			}
			BNG.ForeColor = (flag ? Form23.color_12 : Form23.color_36);
		}
		else
		{
			flag = setting_0.method_35() && framework_0.method_4();
		}
		if (flag && !setting_0.method_122())
		{
			BNg.Enabled = true;
			switch (setting_0.method_124())
			{
			default:
				BNg.BackColor = Color.Red;
				pictureBox_0.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Error:
				BNg.BackColor = Color.Red;
				pictureBox_0.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Warning:
				BNg.BackColor = Color.Orange;
				pictureBox_0.Image = GeneralResources.YellowWarning;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (Form23.smethod_28(framework_0.aXc, bool_53: true))
				{
					BNg.BackColor = Color.Red;
					pictureBox_0.Image = GeneralResources.RedError;
				}
				else
				{
					BNg.BackColor = Color.Orange;
					pictureBox_0.Image = GeneralResources.YellowWarning;
				}
				break;
			}
			pictureBox_0.Visible = true;
		}
		else
		{
			BNg.Enabled = flag;
			bool flag2 = bool_0 || bool_1;
			if (setting_1 != null && !flag2 && !setting_0.method_282(setting_1))
			{
				BNg.BackColor = Form23.color_9;
			}
			else if (BNg.Enabled)
			{
				BNg.BackColor = Form23.color_32;
			}
			else
			{
				BNg.BackColor = Form23.color_35;
			}
			pictureBox_0.Visible = false;
			pictureBox_0.Image = GeneralResources.QuestionMark;
		}
		TabStop = BNg.Enabled;
		BNg.TabStop = TabStop;
		BNg.Invalidate();
	}

	private void method_8(object sender, EventArgs e)
	{
		Form23.smethod_50(setting_0, this);
	}

	private void BNg_GotFocus(object sender, EventArgs e)
	{
		Form23.form23_0.control4_0.method_59(setting_0);
		if (framework_1 != null && BNg.BackColor == Form23.color_9)
		{
			Form23.smethod_50(setting_0, this);
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		if (!bool_0 && !bool_1)
		{
			method_10();
			method_11();
			method_7();
		}
		else
		{
			vmethod_8();
		}
	}

	private void method_10()
	{
		if (BNg.DroppedDown)
		{
			return;
		}
		Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
		List<Setting.ListItems.Struct45> list = setting.method_102((BNk != -1) ? BNk : 0);
		int num = method_20(setting);
		int num2 = -1;
		if (BNf)
		{
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = 0; j < BNg.Items.Count; j++)
				{
					if (list[i].bBV == (string)BNg.Items[j] && list[i].bBv == num)
					{
						num2 = j;
						break;
					}
				}
				if (num2 != -1)
				{
					break;
				}
			}
		}
		else
		{
			for (int k = 0; k < list.Count; k++)
			{
				if (list[k].bBv == num)
				{
					num2 = k;
					break;
				}
			}
		}
		if (BNg.SelectedIndex != num2 && num2 < BNg.Items.Count)
		{
			BNg.SelectedIndex = num2;
		}
	}

	private void method_11()
	{
		if (BNH == null)
		{
			return;
		}
		Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
		int num = method_20(setting);
		BNH.Clear();
		BNH.ScrollBars = RichTextBoxScrollBars.None;
		List<Setting.ValDescs.Struct46> list = setting.method_104((BNk != -1) ? BNk : 0);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].bBZ == num)
			{
				string bBy = list[i].bBy;
				if (bBy != null && bBy.Length != 0)
				{
					BNH.Text = bBy;
				}
				break;
			}
		}
		BNH.ScrollBars = RichTextBoxScrollBars.Vertical;
		BNH.method_0();
	}

	private List<string> method_12(Setting setting_5, int int_1, out int int_2)
	{
		int int_3 = ((BNk != -1) ? BNk : 0);
		List<Setting.ListItems.Struct45> list = setting_5.method_102(int_3);
		List<string> list2 = new List<string>(list.Count);
		int_2 = -1;
		for (int i = 0; i < list.Count; i++)
		{
			if (BNf)
			{
				string bBV = list[i].bBV;
				string text = bBV.ToLower();
				bool flag = false;
				for (int j = 0; j < list2.Count; j++)
				{
					string text2 = list2[j].ToLower();
					for (int k = 0; k < Math.Min(text.Length, text2.Length); k++)
					{
						if (text[k] != text2[k])
						{
							if (text[k] > text2[k])
							{
								break;
							}
							if (text[k] < text2[k])
							{
								list2.Insert(j, bBV);
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
				if (!flag)
				{
					list2.Add(bBV);
				}
			}
			else
			{
				list2.Add(setting_5.method_287(list[i].bBv, int_3));
				if (list[i].bBv == int_1)
				{
					int_2 = i;
				}
			}
		}
		method_13(setting_5);
		if (setting_2 != null)
		{
			method_13(setting_2);
		}
		return list2;
	}

	private void method_13(Setting setting_5)
	{
		if (setting_5 != setting_2)
		{
			BNh = 0;
		}
		List<Setting.ListItems.Struct45> list = setting_5.method_103();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].bBW != 0)
			{
				Setting setting = framework_0.method_31(list[i].bBW);
				if (setting != null)
				{
					string text = string.Empty;
					int num = setting.method_277();
					for (int j = 0; j < num; j++)
					{
						text += Class333.smethod_330();
					}
					BNh = Math.Max(BNh, TextRenderer.MeasureText(text, BNg.Font).Width);
				}
			}
			BNh = Math.Max(BNh, TextRenderer.MeasureText(list[i].bBV, BNg.Font).Width);
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate64 method = method_14;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		int int_ = method_20(setting_0);
		List<string> list = method_12(setting_0, int_, out var _);
		bool flag = false;
		if (list.Count != BNg.Items.Count)
		{
			flag = true;
		}
		else
		{
			for (int i = 0; i < BNg.Items.Count; i++)
			{
				if (list[i] != (string)BNg.Items[i])
				{
					flag = true;
					break;
				}
			}
		}
		if (flag)
		{
			Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
			if (setting.method_105().Count != 0)
			{
				vmethod_8();
				return;
			}
			method_15(setting);
			method_7();
			method_17();
		}
		else
		{
			method_7();
		}
	}

	private void method_15(Setting setting_5)
	{
		int num = method_20(setting_5);
		BNg.Items.Clear();
		List<string> list = method_12(setting_5, num, out var int_);
		ComboBox.ObjectCollection items = BNg.Items;
		object[] items2 = list.ToArray();
		items.AddRange(items2);
		if (BNf)
		{
			List<Setting.ListItems.Struct45> list2 = setting_5.method_102((BNk != -1) ? BNk : 0);
			for (int i = 0; i < list2.Count; i++)
			{
				for (int j = 0; j < BNg.Items.Count; j++)
				{
					if (list2[i].bBV == (string)BNg.Items[j] && list2[i].bBv == num)
					{
						int_ = j;
						break;
					}
				}
				if (int_ != -1)
				{
					break;
				}
			}
		}
		BNg.SelectedIndex = ((int_ < BNg.Items.Count) ? int_ : (-1));
	}

	private void method_16(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate65 method = method_16;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_17();
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			method_10();
			method_11();
			if (setting_1 != null)
			{
				method_7();
			}
		}
	}

	private void method_17()
	{
		FontStyle fontStyle = FontStyle.Regular;
		if (BNJ != null && BNj)
		{
			Setting setting_ = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
			if (method_20(setting_) != BNK)
			{
				fontStyle = FontStyle.Italic;
			}
		}
		if (BNg.Font.Style != fontStyle)
		{
			Font font = BNg.Font;
			BNg.Font = new Font(BNg.Font.FontFamily, BNg.Font.Size, fontStyle);
			font.Dispose();
		}
		if (BNG.Font.Style != fontStyle)
		{
			Font font2 = BNG.Font;
			BNG.Font = new Font(BNG.Font.FontFamily, BNG.Font.Size, fontStyle);
			font2.Dispose();
		}
	}

	private void BNg_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		if (Form23.bool_2)
		{
			Form23.smethod_75(setting_0.method_69());
			method_11();
		}
		else if (BNM)
		{
			BNM = false;
		}
		else
		{
			if (BNg.SelectedIndex == -1)
			{
				return;
			}
			List<Setting.ListItems.Struct45> list = setting_0.method_102((BNk != -1) ? BNk : 0);
			int index = -1;
			if (BNf)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].bBV == (string)BNg.Items[BNg.SelectedIndex])
					{
						index = i;
						break;
					}
				}
			}
			else
			{
				index = BNg.SelectedIndex;
			}
			int num = method_20(setting_0);
			int bBv = list[index].bBv;
			if (bBv == num)
			{
				return;
			}
			bool bool_;
			if (!(bool_ = !setting_0.method_25()))
			{
				string text = setting_0.method_47();
				if (text != null && bBv != 0 && !Form13.smethod_0(setting_0, null))
				{
					Form13 form = new Form13(text, setting_0, null);
					if (form.ShowDialog(Form23.form23_0) != DialogResult.OK)
					{
						bool_ = true;
					}
					form.Dispose();
				}
			}
			List<Table> list2 = null;
			if (!bool_)
			{
				List<Table> list3 = new List<Table>();
				if (setting_0.method_64() == 9364)
				{
					if (framework_0.method_31(9365) is Table item)
					{
						list3.Add(item);
					}
				}
				else if (setting_0.method_64() == 9465)
				{
					if (framework_0.method_31(9466) is Table item2)
					{
						list3.Add(item2);
					}
					if (framework_0.method_31(9476) is Table item3)
					{
						list3.Add(item3);
					}
				}
				if (list3.Count != 0 && method_18(list3, ref bool_, num, bBv))
				{
					list2 = list3;
				}
			}
			List<Table> list4 = null;
			if (!bool_ && setting_0.method_64() == 2083)
			{
				list4 = method_19(ref bool_, num, bBv);
			}
			if (bool_)
			{
				if (BNf)
				{
					for (int j = 0; j < list.Count; j++)
					{
						for (int k = 0; k < BNg.Items.Count; k++)
						{
							if (list[j].bBV == (string)BNg.Items[k] && list[j].bBv == num)
							{
								BNM = true;
								BNg.SelectedIndex = k;
								break;
							}
						}
						if (BNM)
						{
							break;
						}
					}
					return;
				}
				int num2 = 0;
				while (true)
				{
					if (num2 < list.Count)
					{
						if (list[num2].bBv == num)
						{
							break;
						}
						num2++;
						continue;
					}
					return;
				}
				BNM = true;
				BNg.SelectedIndex = ((num2 < BNg.Items.Count) ? num2 : (-1));
				return;
			}
			Class280 @class = Form23.smethod_95();
			@class?.method_3(setting_0.method_69());
			method_21(setting_0, bBv);
			if (list2 != null)
			{
				foreach (Table item4 in list2)
				{
					item4.method_304(num, bBv);
				}
			}
			else if (list4 != null)
			{
				foreach (Table item5 in list4)
				{
					item5.method_305();
				}
			}
			@class?.method_4();
			Form23.smethod_75(setting_0.method_69());
			method_11();
		}
	}

	private bool method_18(List<Table> list_0, ref bool bool_2, int int_1, int int_2)
	{
		Setting setting = framework_0.method_31(714);
		Setting setting2 = framework_0.method_31(720);
		Setting setting3 = framework_0.method_31(464);
		Setting setting4 = framework_0.method_31(6481);
		if (setting != null && setting2 != null && setting3 != null && setting4 != null)
		{
			string text = string.Empty;
			foreach (Table item in list_0)
			{
				string text2 = item.method_60(Enum96.aYt);
				if (!text2.ToLower().EndsWith(Class333.Bcl()))
				{
					text2 += Class333.BcM();
				}
				text = text + Class333.Bcm() + text2 + Class333.smethod_1394();
			}
			string text3 = null;
			if (setting.method_256() == 1)
			{
				if (setting2.method_256() == 1)
				{
					if (setting3.method_256() > 0 && setting3.method_122())
					{
						if (setting4.method_256() > 0 && setting4.method_122())
						{
							if ((int_1 == 6469 && int_2 == 6750) || (int_1 == 6469 && int_2 == 463) || (int_1 == 463 && int_2 == 6469) || (int_1 == 6750 && int_2 == 6469))
							{
								if (Form54.smethod_8(Form23.form23_0, Class333.BcN() + setting_0.method_287(int_1) + Class333.Bcn() + setting_0.method_287(int_2) + Class333.BcO() + text + Class333.Bco(), Class333.smethod_1130(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
								{
									return true;
								}
								bool_2 = true;
							}
							else if ((int_1 != 6750 || int_2 != 463) && (int_1 != 463 || int_2 != 6750))
							{
								text3 = Class333.BcP() + setting_0.method_287(int_1) + Class333.Bcn() + setting_0.method_287(int_2) + Class333.BcO() + text;
							}
						}
						else
						{
							text3 = Class333.Bcp() + text;
						}
					}
					else
					{
						text3 = Class333.BcQ() + text;
					}
				}
				else
				{
					text3 = Class333.Bcq() + text;
				}
			}
			else
			{
				text3 = Class333.BcR() + text;
			}
			if (!string.IsNullOrWhiteSpace(text3) && Form54.smethod_9(Form23.form23_0, text3, Class333.smethod_1130(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, new string[2]
			{
				Class333.smethod_1401(),
				Class333.smethod_823()
			}) == DialogResult.Cancel)
			{
				bool_2 = true;
			}
		}
		return false;
	}

	private List<Table> method_19(ref bool bool_2, int int_1, int int_2)
	{
		List<Table> list = null;
		List<Table> list2 = new List<Table>();
		foreach (Table item in framework_0.aWV)
		{
			if (item.GetAxisUsingChannel(407) != null && item.method_35())
			{
				list2.Add(item);
			}
		}
		if (list2.Count != 0)
		{
			string text = string.Empty;
			foreach (Table item2 in list2)
			{
				text = text + Class333.smethod_2155() + item2.method_60(Enum96.aYt);
			}
			Setting setting = framework_0.method_31(15995);
			Setting setting2 = framework_0.method_31(17);
			Table table = framework_0.method_31(128) as Table;
			bool flag = false;
			if (int_1 == 4 && int_2 == 0 && setting != null && setting2 != null && table != null && setting2.method_256() == 0)
			{
				List<int> dataIdsOfChannelsPerEnabledAxis = table.GetDataIdsOfChannelsPerEnabledAxis();
				if (!dataIdsOfChannelsPerEnabledAxis.Contains(15985) && !dataIdsOfChannelsPerEnabledAxis.Contains(224))
				{
					if (dataIdsOfChannelsPerEnabledAxis.Contains(385))
					{
						Setting setting3 = framework_0.method_31(2082);
						flag = setting3 != null && setting3.method_256() == 0;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (Form54.smethod_6(Form23.form23_0, Class333.Bcr() + text, Class333.smethod_1130(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
				{
					list = new List<Table>();
					foreach (Table item3 in list2)
					{
						list.Add(item3);
					}
				}
				else
				{
					bool_2 = true;
				}
			}
			else if (Form54.smethod_6(Form23.form23_0, Class333.BcS() + text + Class333.Bcs(), Class333.smethod_1130(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
			{
				bool_2 = true;
			}
		}
		return list;
	}

	public override string ToString()
	{
		return setting_0.method_22(bool_0: true);
	}

	protected override void vmethod_8()
	{
		method_22();
		int width = BNG.Width;
		if (Parent != null)
		{
			Parent.SuspendLayout();
		}
		method_3(dataIdAndAttrId_0, framework_0, framework_1, BNJ, BNj, BNI, BNi);
		method_6(Math.Max(width, BNG.Width));
		if (Parent != null)
		{
			Parent.ResumeLayout(performLayout: true);
		}
	}

	private int method_20(Setting setting_5)
	{
		if (BNk != -1)
		{
			return setting_5.method_258(BNk);
		}
		return setting_5.method_256();
	}

	private void method_21(Setting setting_5, int int_1)
	{
		if (BNk != -1)
		{
			setting_5.method_274(BNk, int_1, bool_0: true);
		}
		else
		{
			setting_5.method_272(int_1, bool_0: true);
		}
	}

	private void method_22()
	{
		try
		{
			BNg.SelectedIndexChanged -= BNg_SelectedIndexChanged;
			BNg.GotFocus -= BNg_GotFocus;
			MouseEnter -= vmethod_4;
			BNG.MouseEnter -= vmethod_4;
			BNg.MouseEnter -= vmethod_4;
			pictureBox_0.MouseEnter -= vmethod_4;
			BNg.MouseLeave -= vmethod_5;
			MouseLeave -= vmethod_5;
			pictureBox_0.Click -= method_8;
			setting_0.method_265(method_16);
			foreach (Setting item in setting_0.method_285())
			{
				item.method_265(method_14);
			}
			setting_0.method_41(method_14);
			if (setting_3 != null)
			{
				setting_3.method_41(vmethod_6);
			}
			if (setting_4 != null)
			{
				setting_4.method_265(vmethod_7);
			}
			Form23.form23_0.method_10(method_9);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		method_22();
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
