using System;
using System.Collections.Generic;
using System.Drawing;
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

internal class Class120 : Class109, Interface3
{
	private delegate void Delegate86(object sender, EventArgs e);

	private delegate void Delegate87(object sender, EventArgs e);

	private delegate void Delegate88(object sender, EventArgs e);

	private const int BXZ = 140;

	private const int BXz = 260;

	private const int BxA = 210;

	private Framework Bxa;

	private Framework BxB;

	private UserLog Bxb;

	private Rectangle BxC;

	private bool Bxc;

	private bool BxD;

	private Setting Bxd;

	private Setting BxE;

	private Setting Bxe;

	private Setting BxF;

	private Control15 Bxf;

	private Label BxG = new Label();

	private Label Bxg = new Label();

	private PictureBox BxH = new PictureBox();

	private ThemedTextBox Bxh = new ThemedTextBox();

	private ThemedButton BxI = new ThemedButton();

	private Timer Bxi = new Timer();

	private List<ThemedComboBox> BxJ = new List<ThemedComboBox>();

	private List<Class85> Bxj = new List<Class85>();

	private List<Label> BxK = new List<Label>();

	private List<ThemedButton> Bxk = new List<ThemedButton>();

	private List<ThemedButton> BxL = new List<ThemedButton>();

	private Class85 Bxl = new Class85();

	private Label BxM = new Label();

	private SortedList<string, Setting> Bxm = new SortedList<string, Setting>();

	private List<int> BxN = new List<int>();

	private int Bxn;

	internal Class120(UserLog userLog_0, Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false)
	{
		Bxa = framework_0;
		BxB = framework_1;
		Bxb = userLog_0;
		Form23.form23_0.method_9(method_24);
		BxC = rectangle_0;
		BxH.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		BxH.Width = 24;
		BxH.Height = 24;
		Bxh.TextChanged += Bxh_TextChanged;
		Bxh.BackColor = Form23.color_32;
		Bxh.ForeColor = Form23.color_12;
		BxI.Click += BxI_Click;
		BxI.Text = Class333.smethod_330();
		BxI.Font = new Font(BxI.Font.FontFamily, 8f, FontStyle.Bold);
		BxI.Width = 22;
		Bxi.Interval = 400;
		Bxi.Tick += Bxi_Tick;
	}

	protected override void Dispose(bool disposing)
	{
		method_15();
		try
		{
			Form23.form23_0.method_10(method_24);
			Bxh.TextChanged -= Bxh_TextChanged;
			BxI.Click -= BxI_Click;
			Bxi.Tick -= Bxi_Tick;
			Bxi.Dispose();
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void method_15()
	{
		try
		{
			if (Bxf != null)
			{
				Bxf.method_0().method_265(method_34);
			}
			foreach (ThemedButton item in Bxk)
			{
				item.Click -= method_19;
			}
			foreach (ThemedButton item2 in BxL)
			{
				item2.Click -= method_23;
			}
			foreach (ThemedComboBox item3 in BxJ)
			{
				item3.SelectedIndexChanged -= method_33;
			}
			if (Bxd != null)
			{
				Bxd.method_265(method_26);
			}
			if (BxE != null)
			{
				BxE.method_265(method_27);
				BxE.method_41(method_28);
			}
			Bxl.ItemSelectionChanged -= Bxl_ItemSelectionChanged;
			foreach (Class85 item4 in Bxj)
			{
				item4.ItemSelectionChanged -= Bxl_ItemSelectionChanged;
			}
			if (Parent != null && Parent is Class131)
			{
				Parent.Layout -= method_18;
			}
		}
		catch
		{
		}
	}

	internal void method_16()
	{
		SuspendLayout();
		method_12().SuspendLayout();
		Bxc = Bxa.method_2() && Bxa.method_3() && Bxa.method_31(Bxb.DataIdOfChannelListSetting).method_96();
		BxD = BxB != null && BxB.method_2() && BxB.method_3() && BxB.method_31(Bxb.DataIdOfChannelListSetting).method_96();
		if ((Form23.enum60_0 != Form23.Enum60.BpG || BxB == null) ? Bxc : BxD)
		{
			Label label = new Label();
			label.Text = Class333.BHM();
			label.ForeColor = Form23.color_12;
			label.BackColor = Color.Transparent;
			label.AutoSize = true;
			label.Left = 5;
			label.Top = 5;
			method_12().Controls.Add(label);
		}
		else
		{
			Bxd = Bxa.method_31(Bxb.DataIdOfChannelListSetting);
			BxE = Bxa.method_31(Bxb.DataIdOfChannelRateSetting);
			if (BxB != null)
			{
				Bxe = BxB.method_31(Bxb.DataIdOfChannelListSetting);
				BxF = BxB.method_31(Bxb.DataIdOfChannelRateSetting);
			}
			Framework framework = ((Form23.enum60_0 != Form23.Enum60.BpG || Bxe == null) ? Bxa : BxB);
			Bxm.Clear();
			List<string> list = new List<string>();
			foreach (Setting item in framework.aWt)
			{
				if (!item.method_35() || !item.method_184() || item.method_212() || !PortFunction.smethod_52(item))
				{
					continue;
				}
				string text = item.method_22(bool_0: true);
				if (Bxm.ContainsKey(text))
				{
					if (!list.Contains(text))
					{
						list.Add(text);
					}
				}
				else
				{
					Bxm.Add(text, item);
				}
			}
			if (list.Count != 0)
			{
				string text2 = Class333.smethod_2526();
				foreach (string item2 in list)
				{
					text2 = text2 + Class333.smethod_570() + item2;
				}
				Form54.smethod_6(Form23.form23_0, text2, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			int num = 5;
			int top = 5;
			Setting setting = Bxa.method_31(12201);
			if (setting != null)
			{
				Control15 bxf = Bxf;
				Bxf = new Control15(setting.method_69(), Bxa, BxB, null, bool_2: false);
				Bxf.Enabled = Bxa.method_4();
				setting.method_265(method_34);
				setting.method_264(method_34);
				Bxf.Left = num;
				Bxf.Top = top;
				method_12().Controls.Add(Bxf);
				top = Bxf.Bottom + 5;
				bxf?.Dispose();
			}
			BxM.ForeColor = Form23.color_9;
			BxM.AutoSize = true;
			BxM.Visible = false;
			BxM.Text = Class333.BHp();
			if (setting != null)
			{
				BxM.Left = Bxf.Right + 10;
				BxM.Top = Bxf.Top;
			}
			else
			{
				BxM.Left = num;
				BxM.Top = top;
			}
			method_12().Controls.Add(BxM);
			BxG.Text = Class333.BHn();
			BxG.ForeColor = Form23.color_12;
			BxG.Left = num;
			BxG.Top = top;
			BxG.Width = 500;
			BxG.Height = 16;
			method_12().Controls.Add(BxG);
			top = BxG.Bottom + 5;
			Bxn = Bxd.method_242()[1];
			Bxg.Text = method_35();
			Bxg.ForeColor = Form23.color_12;
			Bxg.Left = num;
			Bxg.Top = top;
			Bxg.Width = 500;
			Bxg.Height = 16;
			method_12().Controls.Add(Bxg);
			top = Bxg.Bottom + 5;
			int num2 = ((Parent == null || !(Parent is Class131)) ? 140 : Math.Max(140, (Parent.Width - 20) / (1 + Bxn)));
			BxH.Left = num;
			BxH.Top = top;
			method_12().Controls.Add(BxH);
			Bxh.Left = BxH.Right + 1;
			Bxh.Top = top;
			Bxh.Width = num2 - (BxH.Width + BxI.Width + 7);
			method_12().Controls.Add(Bxh);
			BxI.Left = Bxh.Left + Bxh.Width + 3;
			BxI.Top = Bxh.Top - 1;
			BxI.Height = Bxh.Height + 2;
			method_12().Controls.Add(BxI);
			Bxl.ItemSelectionChanged -= Bxl_ItemSelectionChanged;
			Bxl.ItemSelectionChanged += Bxl_ItemSelectionChanged;
			Bxl.ShowItemToolTips = true;
			Bxl.BackColor = Form23.color_17;
			Bxl.ForeColor = Form23.color_12;
			Bxl.FullRowSelect = false;
			Bxl.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			Bxl.UseCompatibleStateImageBehavior = false;
			Bxl.View = View.Details;
			ColumnHeader columnHeader = new ColumnHeader();
			columnHeader.Text = Class333.BHQ();
			Bxl.Columns.Add(columnHeader);
			Bxl.Width = num2 - 5;
			Bxl.Left = num;
			Bxl.Top = top + 25;
			if (Parent != null && Parent is Class131)
			{
				Bxl.Height = Math.Max(260, Parent.Height - 30 - Top - Bxl.Top);
			}
			else
			{
				Bxl.Height = 260;
			}
			Bxl.Columns[0].Width = Bxl.Width - 22;
			method_12().Controls.Add(Bxl);
			num += num2;
			BxN.Clear();
			for (int i = 0; i < Bxn; i++)
			{
				method_17(i, num2, num, top);
				num += num2;
			}
			method_32(bool_0: false);
			Bxd.method_264(method_26);
			BxE.method_264(method_27);
			BxE.method_40(method_28);
			method_25();
		}
		if (BxC != Rectangle.Empty)
		{
			Width = BxC.Width;
			Height = BxC.Height;
			Left = BxC.Left;
			Top = BxC.Top;
		}
		else
		{
			int num3 = 0;
			int num4 = 0;
			foreach (Control control in method_12().Controls)
			{
				num3 = Math.Max(num3, control.Right + 15);
				num4 = Math.Max(num4, control.Bottom + 15);
			}
			Width = num3;
			Height = num4;
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
		if (Parent != null && Parent is Class131)
		{
			Parent.Layout += method_18;
		}
	}

	private void method_17(int int_3, int int_4, int int_5, int int_6)
	{
		ThemedComboBox themedComboBox = new ThemedComboBox();
		themedComboBox.Enabled = Form23.enum60_0 != Form23.Enum60.BpG && Bxa.method_4();
		themedComboBox.Tag = int_3;
		themedComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox.Width = 110;
		themedComboBox.Left = int_5 + (int_4 - 5 - themedComboBox.Width) / 2;
		themedComboBox.Top = int_6;
		Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || BxF == null) ? BxE : BxF);
		int selectedIndex = 0;
		int num = setting.method_258(int_3);
		List<Setting.ListItems.Struct45> list = setting.method_102();
		for (int i = 0; i < list.Count; i++)
		{
			themedComboBox.Items.Add(list[i].bBV);
			if (list[i].bBv == num)
			{
				selectedIndex = i;
			}
		}
		themedComboBox.SelectedIndex = selectedIndex;
		themedComboBox.SelectedIndexChanged += method_33;
		if (BxJ.Count > int_3)
		{
			ThemedComboBox themedComboBox2 = BxJ[int_3];
			BxJ[int_3] = themedComboBox;
			themedComboBox2.SelectedIndexChanged -= method_33;
			themedComboBox2.Dispose();
		}
		else
		{
			BxJ.Add(themedComboBox);
		}
		method_12().Controls.Add(themedComboBox);
		Class85 @class = new Class85();
		@class.ItemSelectionChanged += Bxl_ItemSelectionChanged;
		@class.ShowItemToolTips = true;
		@class.BackColor = Form23.color_17;
		@class.ForeColor = Form23.color_12;
		@class.FullRowSelect = false;
		@class.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		@class.UseCompatibleStateImageBehavior = false;
		@class.View = View.Details;
		ColumnHeader columnHeader = new ColumnHeader();
		columnHeader.Text = Class333.BHq();
		@class.Columns.Add(columnHeader);
		@class.Width = int_4 - 5;
		@class.Height = Bxl.Height - 66;
		@class.Left = int_5;
		@class.Top = int_6 + 25;
		@class.Columns[0].Width = @class.Width - 22;
		if (Bxj.Count > int_3)
		{
			Class85 class2 = Bxj[int_3];
			Bxj[int_3] = @class;
			class2.ItemSelectionChanged -= Bxl_ItemSelectionChanged;
			class2.Dispose();
		}
		else
		{
			Bxj.Add(@class);
		}
		method_12().Controls.Add(@class);
		Label label = new Label();
		label.ForeColor = Form23.color_12;
		label.TextAlign = ContentAlignment.MiddleCenter;
		label.AutoSize = false;
		label.Width = int_4 - 5;
		label.Height = 16;
		label.Left = int_5;
		label.Top = @class.Bottom;
		if (BxK.Count > int_3)
		{
			Label label2 = BxK[int_3];
			BxK[int_3] = label;
			label2.Dispose();
		}
		else
		{
			BxK.Add(label);
		}
		method_12().Controls.Add(label);
		method_31(int_3, bool_0: false);
		ThemedButton themedButton = new ThemedButton();
		themedButton.Click += method_19;
		themedButton.Text = Class333.BHR();
		themedButton.Font = new Font(themedButton.Font.FontFamily, 8f);
		themedButton.Width = int_4 - 5;
		themedButton.Left = int_5;
		themedButton.Top = @class.Bottom + 18;
		themedButton.Enabled = false;
		if (Bxk.Count > int_3)
		{
			ThemedButton themedButton2 = Bxk[int_3];
			Bxk[int_3] = themedButton;
			themedButton2.Click -= method_19;
			themedButton2.Dispose();
		}
		else
		{
			Bxk.Add(themedButton);
		}
		method_12().Controls.Add(themedButton);
		ThemedButton themedButton3 = new ThemedButton();
		themedButton3.Click += method_23;
		themedButton3.Text = Class333.BHr();
		themedButton3.Font = new Font(themedButton3.Font.FontFamily, 8f);
		themedButton3.Width = int_4 - 5;
		themedButton3.Left = int_5;
		themedButton3.Top = themedButton.Bottom + 1;
		themedButton3.Enabled = false;
		if (BxL.Count > int_3)
		{
			ThemedButton themedButton4 = BxL[int_3];
			BxL[int_3] = themedButton3;
			themedButton4.Click -= method_23;
			themedButton4.Dispose();
		}
		else
		{
			BxL.Add(themedButton3);
		}
		method_12().Controls.Add(themedButton3);
	}

	private void method_18(object sender, LayoutEventArgs e)
	{
		SuspendLayout();
		method_12().SuspendLayout();
		Bxc = Bxa.method_2() && Bxa.method_3() && Bxa.method_31(Bxb.DataIdOfChannelListSetting).method_96();
		BxD = BxB != null && BxB.method_2() && BxB.method_3() && BxB.method_31(Bxb.DataIdOfChannelListSetting).method_96();
		if (!((Form23.enum60_0 != Form23.Enum60.BpG || BxB == null) ? Bxc : BxD))
		{
			int num = 5;
			if (Bxf != null)
			{
				_ = Bxf.Bottom;
			}
			int num2 = Bxl.Width + 5;
			int num3 = ((Parent == null || !(Parent is Class131)) ? 140 : Math.Max(140, (Parent.Width - 20) / (1 + Bxn)));
			Bxh.Width = num3 - (BxH.Width + BxI.Width + 7);
			BxI.Left = Bxh.Left + Bxh.Width + 3;
			Bxl.Width = num3 - 5;
			if (Parent != null && Parent is Class131)
			{
				Bxl.Height = Math.Max(260, Parent.Height - 30 - Top - Bxl.Top);
			}
			else
			{
				Bxl.Height = 260;
			}
			Bxl.Columns[0].Width = Bxl.Width - 22;
			Bxl.method_1();
			num += num3;
			for (int i = 0; i < Bxn; i++)
			{
				ThemedComboBox themedComboBox = BxJ[i];
				themedComboBox.Left = num + (num3 - 5 - themedComboBox.Width) / 2;
				Class85 @class = Bxj[i];
				@class.Width = num3 - 5;
				@class.Height = Bxl.Height - 66;
				@class.Left = num;
				@class.Columns[0].Width = @class.Width - 22;
				@class.method_1();
				Label label = BxK[i];
				label.Width = num3 - 5;
				label.Left = num;
				label.Top = @class.Bottom;
				ThemedButton themedButton = Bxk[i];
				themedButton.Width = num3 - 5;
				themedButton.Left = num;
				themedButton.Top = @class.Bottom + 18;
				ThemedButton themedButton2 = BxL[i];
				themedButton2.Width = num3 - 5;
				themedButton2.Left = num;
				themedButton2.Top = themedButton.Bottom + 1;
				num += num3;
			}
			if (num2 >= 210 != num3 >= 210)
			{
				for (int j = 0; j < Bxn; j++)
				{
					method_31(j, bool_0: true);
				}
				method_32(bool_0: true);
			}
		}
		if (BxC == Rectangle.Empty)
		{
			int num4 = 0;
			int num5 = 0;
			foreach (Control control in method_12().Controls)
			{
				num4 = Math.Max(num4, control.Right + 15);
				num5 = Math.Max(num5, control.Bottom + 15);
			}
			Width = num4;
			Height = num5;
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
	}

	private void Bxl_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		for (int i = 0; i < Bxn; i++)
		{
			if (Bxl.Focused && Bxl.SelectedItems.Count != 0)
			{
				Bxk[i].Enabled = Bxa.method_4();
			}
			else if (Bxj[i].Focused && Bxj[i].SelectedItems.Count != 0)
			{
				Bxk[i].Enabled = false;
			}
			else
			{
				bool flag = false;
				for (int j = 0; j < Bxn; j++)
				{
					if (j != i && Bxj[j].Focused && Bxj[j].SelectedItems.Count != 0)
					{
						flag = true;
						break;
					}
				}
				Bxk[i].Enabled = flag && Bxa.method_4();
			}
			BxL[i].Enabled = Bxj[i].Focused && Bxj[i].SelectedItems.Count != 0 && Bxa.method_4();
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !Bxa.method_4())
		{
			return;
		}
		int num = Bxk.IndexOf(sender as ThemedButton);
		int num2 = -1;
		List<int> list = new List<int>();
		if (Bxl.SelectedItems.Count == 0)
		{
			for (int i = 0; i < Bxj.Count; i++)
			{
				if (Bxj[i].SelectedItems.Count != 0)
				{
					num2 = i;
					break;
				}
			}
			if (num2 == -1 || num2 == num)
			{
				return;
			}
			foreach (ListViewItem selectedItem in Bxj[num2].SelectedItems)
			{
				if (selectedItem.Tag != null)
				{
					list.Add((int)selectedItem.Tag);
				}
			}
		}
		else
		{
			foreach (ListViewItem selectedItem2 in Bxl.SelectedItems)
			{
				if (selectedItem2.Tag != null)
				{
					list.Add((int)selectedItem2.Tag);
				}
			}
		}
		List<int> list2 = new List<int>();
		foreach (int item in list)
		{
			Setting setting = Bxa.method_31(item);
			if (setting is Table)
			{
				Table table = setting as Table;
				list2.AddRange(table.GetDataIdsOfChannelsPerEnabledAxis());
			}
		}
		int num3 = BxE.method_258(num);
		for (int j = 0; j < Bxn; j++)
		{
			int num4 = BxE.method_258(j);
			for (int k = 0; k < Bxd.method_242()[2]; k++)
			{
				int num5 = Bxd.method_257(k, j, 0);
				if (num5 == 0 || num5 == Bxd.method_236())
				{
					break;
				}
				if (list2.Contains(num5) && num4 <= num3)
				{
					list2.Remove(num5);
				}
			}
		}
		list.AddRange(list2);
		int num6 = 0;
		for (int l = 0; l < Bxd.method_242()[2]; l++)
		{
			int num7 = Bxd.method_257(l, num, 0);
			if (num7 == 0 || num7 == Bxd.method_236())
			{
				break;
			}
			num6++;
		}
		if (num6 + list.Count > Bxd.method_242()[2])
		{
			string string_ = Class333.BHS();
			if (list2.Count == 0)
			{
				Form54.smethod_6(Form23.form23_0, Class333.BHs(), string_, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (num6 + list.Count - list2.Count > Bxd.method_242()[2])
			{
				Form54.smethod_6(Form23.form23_0, Class333.BHs(), string_, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (Form54.smethod_7(Form23.form23_0, Class333.BHT(), string_, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, new string[2]
			{
				Class333.smethod_821(),
				Class333.BHt()
			}) == DialogResult.OK)
			{
				return;
			}
			foreach (int item2 in list2)
			{
				list.Remove(item2);
			}
			list2.Clear();
		}
		Bxk[num].Enabled = false;
		Class280 @class = Form23.smethod_95();
		@class?.method_2(Bxd.method_64());
		Bxd.method_268();
		bool flag = Bxa.method_53();
		Bxa.method_55();
		method_20(list, num);
		method_21(list, num2);
		method_22(list2, num);
		if (flag)
		{
			Bxa.method_54(bool_0: true, Bxd);
		}
		Bxd.method_267(bool_0: true);
		@class?.method_4();
		Form23.smethod_74(Bxd.method_64());
	}

	private void method_20(List<int> list_0, int int_3)
	{
		List<int> list = new List<int>();
		list.AddRange(list_0);
		for (int i = 0; i < Bxd.method_242()[2]; i++)
		{
			int num = Bxd.method_257(i, int_3, 0);
			if (num == 0 || num == Bxd.method_236())
			{
				break;
			}
			if (!list.Contains(num))
			{
				list.Add(num);
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			Bxd.method_273(j, int_3, 0, list[j], bool_0: true);
		}
		for (int k = list.Count; k < Bxd.method_242()[2]; k++)
		{
			Bxd.method_273(k, int_3, 0, Bxd.method_236(), bool_0: true);
		}
	}

	private void method_21(List<int> list_0, int int_3)
	{
		if (int_3 == -1)
		{
			return;
		}
		List<int> list = new List<int>();
		for (int i = 0; i < Bxd.method_242()[2]; i++)
		{
			int num = Bxd.method_257(i, int_3, 0);
			if (num == 0 || num == Bxd.method_236())
			{
				break;
			}
			if (!list_0.Contains(num))
			{
				list.Add(num);
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			Bxd.method_273(j, int_3, 0, list[j], bool_0: true);
		}
		for (int k = list.Count; k < Bxd.method_242()[2]; k++)
		{
			Bxd.method_273(k, int_3, 0, Bxd.method_236(), bool_0: true);
		}
	}

	private void method_22(List<int> list_0, int int_3)
	{
		for (int i = 0; i < Bxn; i++)
		{
			if (i == int_3)
			{
				continue;
			}
			List<int> list = new List<int>();
			for (int j = 0; j < Bxd.method_242()[2]; j++)
			{
				int num = Bxd.method_257(j, i, 0);
				if (num == 0 || num == Bxd.method_236())
				{
					break;
				}
				if (!list_0.Contains(num) && !list.Contains(num))
				{
					list.Add(num);
				}
			}
			for (int k = 0; k < list.Count; k++)
			{
				Bxd.method_273(k, i, 0, list[k], bool_0: true);
			}
			for (int l = list.Count; l < Bxd.method_242()[2]; l++)
			{
				Bxd.method_273(l, i, 0, Bxd.method_236(), bool_0: true);
			}
		}
	}

	private void method_23(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !Bxa.method_4())
		{
			return;
		}
		int index = BxL.IndexOf(sender as ThemedButton);
		if (Bxj[index].SelectedItems.Count == 0)
		{
			return;
		}
		for (int i = 0; i < BxL.Count; i++)
		{
			BxL[i].Enabled = false;
		}
		List<int> list = new List<int>();
		foreach (ListViewItem selectedItem in Bxj[index].SelectedItems)
		{
			if (selectedItem.Tag != null)
			{
				list.Add((int)selectedItem.Tag);
			}
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(Bxd.method_64());
		Bxd.method_268();
		bool flag = Bxa.method_53();
		Bxa.method_55();
		List<int> list2 = new List<int>();
		for (int j = 0; j < Bxd.method_242()[2]; j++)
		{
			int num = Bxd.method_257(j, index, 0);
			if (num == 0 || num == Bxd.method_236())
			{
				break;
			}
			if (!list.Contains(num))
			{
				list2.Add(num);
			}
		}
		for (int k = 0; k < list2.Count; k++)
		{
			Bxd.method_273(k, index, 0, list2[k], bool_0: true);
		}
		for (int l = list2.Count; l < Bxd.method_242()[2]; l++)
		{
			Bxd.method_273(l, index, 0, Bxd.method_236(), bool_0: true);
		}
		if (flag)
		{
			Bxa.method_54(bool_0: true, Bxd);
		}
		Bxd.method_267(bool_0: true);
		@class?.method_4();
		Form23.smethod_74(Bxd.method_64());
	}

	private void BxI_Click(object sender, EventArgs e)
	{
		Bxh.Text = string.Empty;
	}

	private void Bxh_TextChanged(object sender, EventArgs e)
	{
		Bxi.Stop();
		Bxi.Start();
	}

	private void Bxi_Tick(object sender, EventArgs e)
	{
		Bxi.Stop();
		for (int i = 0; i < Bxn; i++)
		{
			method_31(i, bool_0: false);
		}
		method_32(bool_0: false);
	}

	private void method_24(object sender, EventArgs e)
	{
		method_15();
		method_12().Controls.Clear();
		method_16();
	}

	private void method_25()
	{
		bool visible = false;
		if (!Bxc && !BxD && Bxe != null && !Bxd.method_282(Bxe))
		{
			visible = true;
		}
		BxM.Visible = visible;
		for (int i = 0; i < Bxn; i++)
		{
			method_29(i);
		}
	}

	private void method_26(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate86 method = method_26;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		bool flag = false;
		if (!string.IsNullOrEmpty(Bxh.Text))
		{
			flag = true;
		}
		else
		{
			for (int i = 0; i < Bxn; i++)
			{
				for (int j = 0; j < Bxd.method_242()[2]; j++)
				{
					int num = Bxd.method_257(j, i, 0);
					if (num != 0 && num != Bxd.method_236())
					{
						if (j < Bxj[i].Items.Count)
						{
							Bxa.method_31(num);
							if (Bxj[i].Items[j].Tag != null && (int)Bxj[i].Items[j].Tag != num)
							{
								flag = true;
								break;
							}
							continue;
						}
						flag = true;
						break;
					}
					if (Bxj[i].Items.Count != j)
					{
						flag = true;
					}
					break;
				}
				if (flag)
				{
					break;
				}
			}
		}
		if (flag)
		{
			BxN.Clear();
			for (int k = 0; k < Bxn; k++)
			{
				method_31(k, bool_0: false);
			}
		}
		method_32(bool_0: true);
		method_25();
		Bxg.Text = method_35();
	}

	private void method_27(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate87 method = method_27;
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
			for (int i = 0; i < Bxn; i++)
			{
				method_30(i);
			}
			method_25();
			Bxg.Text = method_35();
		}
	}

	private void method_28(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate88 method = method_28;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		for (int i = 0; i < Bxn; i++)
		{
			method_29(i);
		}
	}

	private void method_29(int int_3)
	{
		ThemedComboBox themedComboBox = BxJ[int_3];
		if ((Form23.enum60_0 != Form23.Enum60.BpG && !Bxc) || (Form23.enum60_0 == Form23.Enum60.BpG && !BxD))
		{
			if (!BxE.method_122())
			{
				if (BxE.method_258(int_3) == 0 && Bxd.method_257(0, int_3, 0) != Bxd.method_236())
				{
					themedComboBox.BackColor = Color.Orange;
				}
				else
				{
					themedComboBox.BackColor = Form23.color_32;
				}
			}
			else if (BxF != null && !BxE.method_281(BxF, int_3))
			{
				themedComboBox.BackColor = Form23.color_9;
			}
			else
			{
				themedComboBox.BackColor = Form23.color_32;
			}
		}
		else
		{
			themedComboBox.BackColor = Form23.color_32;
		}
	}

	private void method_30(int int_3)
	{
		ThemedComboBox themedComboBox = BxJ[int_3];
		if (themedComboBox.DroppedDown)
		{
			return;
		}
		int num = -1;
		int num2 = BxE.method_258(int_3);
		List<Setting.ListItems.Struct45> list = BxE.method_102();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].bBv == num2)
			{
				num = i;
				break;
			}
		}
		if (themedComboBox.SelectedIndex != num && num != -1)
		{
			themedComboBox.SelectedIndex = num;
		}
	}

	private void method_31(int int_3, bool bool_0)
	{
		Framework framework;
		Setting setting;
		if (Form23.enum60_0 == Form23.Enum60.BpG && Bxe != null)
		{
			framework = BxB;
			setting = Bxe;
		}
		else
		{
			framework = Bxa;
			setting = Bxd;
		}
		Class85 @class = Bxj[int_3];
		int num = 0;
		if (bool_0 && @class.TopItem != null)
		{
			num = @class.TopItem.Index;
		}
		@class.BeginUpdate();
		@class.Items.Clear();
		List<ListViewItem> list = new List<ListViewItem>();
		int num2 = 0;
		string[] array = Bxh.Text.ToUpper().Split(' ', ',');
		for (int i = 0; i < setting.method_242()[2]; i++)
		{
			int num3 = setting.method_257(i, int_3, 0);
			if (num3 == 0 || num3 == setting.method_236())
			{
				break;
			}
			Setting setting2 = framework.method_31(num3);
			bool flag = true;
			string text;
			if (setting2 != null)
			{
				BxN.Add(setting2.method_64());
				text = setting2.method_22(bool_0: true);
				if (!string.IsNullOrEmpty(Bxh.Text))
				{
					string text2 = text;
					string text3 = setting2.method_60(Enum96.aYT);
					if (text3 == null)
					{
						text3 = setting2.method_2();
					}
					string text4 = text3.ToUpper();
					string text5 = text2.ToUpper();
					string[] array2 = array;
					foreach (string value in array2)
					{
						if (text5.Contains(value) || text4.Contains(value))
						{
							continue;
						}
						bool flag2 = false;
						foreach (string item in setting2.method_23())
						{
							if (item.ToUpper().Contains(value))
							{
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							flag = false;
							break;
						}
					}
				}
			}
			else
			{
				text = Class333.BHP();
				flag = string.IsNullOrEmpty(Bxh.Text);
			}
			if (flag)
			{
				string[] items;
				if (@class.Width + 5 >= 210)
				{
					items = new string[1] { text };
				}
				else
				{
					items = ((setting2 == null) ? new string[1] { Class333.aoa() } : new string[1] { setting2.method_60(Enum96.aYT) });
				}
				ListViewItem listViewItem = new ListViewItem(items);
				listViewItem.ToolTipText = text;
				listViewItem.Tag = num3;
				list.Add(listViewItem);
			}
			num2++;
		}
		@class.Items.AddRange(list.ToArray());
		@class.EndUpdate();
		if (bool_0 && @class.Items.Count != 0 && num < @class.Items.Count)
		{
			@class.TopItem = @class.Items[num];
		}
		@class.method_1();
		BxK[int_3].Text = num2 + Class333.smethod_487() + setting.method_242()[2] + Class333.BHU();
	}

	private void method_32(bool bool_0)
	{
		int num = 0;
		if (bool_0 && Bxl.TopItem != null)
		{
			num = Bxl.TopItem.Index;
		}
		Bxl.BeginUpdate();
		Bxl.Items.Clear();
		string[] array = Bxh.Text.ToUpper().Split(' ', ',');
		List<ListViewItem> list = new List<ListViewItem>();
		foreach (Setting value2 in Bxm.Values)
		{
			if (BxN.Contains(value2.method_64()))
			{
				continue;
			}
			bool flag = true;
			if (!string.IsNullOrEmpty(Bxh.Text))
			{
				string text = value2.method_22(bool_0: true);
				string text2 = value2.method_60(Enum96.aYT);
				if (text2 == null)
				{
					text2 = value2.method_2();
				}
				string text3 = text2.ToUpper();
				string text4 = text.ToUpper();
				string[] array2 = array;
				foreach (string value in array2)
				{
					if (text4.Contains(value) || text3.Contains(value))
					{
						continue;
					}
					bool flag2 = false;
					foreach (string item in value2.method_23())
					{
						if (item.ToUpper().Contains(value))
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				string text5 = Bxm.Keys[Bxm.IndexOfValue(value2)];
				string[] items = ((Bxl.Width + 5 < 210) ? new string[1] { value2.method_60(Enum96.aYT) } : new string[1] { text5 });
				ListViewItem listViewItem = new ListViewItem(items);
				listViewItem.ToolTipText = text5;
				listViewItem.Tag = value2.method_64();
				list.Add(listViewItem);
			}
		}
		Bxl.Items.AddRange(list.ToArray());
		Bxl.EndUpdate();
		if (bool_0 && Bxl.Items.Count != 0 && num < Bxl.Items.Count)
		{
			Bxl.TopItem = Bxl.Items[num];
		}
		Bxl.method_1();
	}

	private void method_33(object sender, EventArgs e)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG && BxE != null && Bxa.method_4())
		{
			ThemedComboBox themedComboBox = sender as ThemedComboBox;
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BxE.method_64());
			BxE.method_274((int)themedComboBox.Tag, BxE.method_102()[themedComboBox.SelectedIndex].bBv, bool_0: true);
			@class?.method_4();
			Form23.smethod_74(BxE.method_64());
		}
	}

	private void method_34(object sender, EventArgs e)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG && (sender as Setting).method_256() != 0)
		{
			Form23.bool_34 = true;
		}
	}

	private string method_35()
	{
		if (Bxn != 0 && Bxd != null && BxE != null)
		{
			int num = 0;
			for (int i = 0; i < Bxn; i++)
			{
				int num2 = 0;
				for (int j = 0; j < Bxd.method_242()[2]; j++)
				{
					int num3 = Bxd.method_257(j, i, 0);
					if (num3 != 0 && num3 != Bxd.method_236())
					{
						num2++;
					}
				}
				int num4 = 9 + num2 * 4;
				int num5 = BxE.method_258(i);
				if (num5 != 0)
				{
					num += num4 * 1000 / num5;
				}
			}
			if (num == 0)
			{
				return string.Empty;
			}
			int num6 = Bxa.method_31(9497).method_256();
			if (num6 == 0)
			{
				return string.Empty;
			}
			int num7 = 1000 * (int)(num6 * 80L / num / 100L);
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(num7);
			return string.Concat(str1: (num7 < 60000) ? (timeSpan.Seconds + Class333.BHu()) : ((num7 < 120000) ? (Class333.BHV() + timeSpan.Seconds + Class333.BHv() + ((timeSpan.Seconds == 1) ? string.Empty : Class333.smethod_960())) : ((num7 >= 3600000) ? (timeSpan.Hours + Class333.BHw() + ((timeSpan.Hours == 1) ? string.Empty : Class333.smethod_960()) + Class333.smethod_325() + timeSpan.Minutes + Class333.BHX() + ((timeSpan.Minutes == 1) ? string.Empty : Class333.smethod_960())) : (timeSpan.Minutes + Class333.BHW()))), str0: Class333.smethod_1259(), str2: Class333.BHx());
		}
		return string.Empty;
	}

	public Control imethod_0(DataIdAndAttrId dataIdAndAttrId_0)
	{
		if (Bxl.Visible && method_12().Controls.Contains(Bxl) && ((Bxd != null && dataIdAndAttrId_0.DataId == Bxd.method_64()) || (BxE != null && dataIdAndAttrId_0.DataId == BxE.method_64())))
		{
			return Bxl;
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
}
