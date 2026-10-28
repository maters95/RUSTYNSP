using System;
using System.Collections.Generic;
using System.Drawing;
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

internal class Class119 : Class109, Interface3
{
	private delegate void Delegate84(object sender, EventArgs e);

	private delegate void Delegate85(object sender, EventArgs e);

	private Framework BXP;

	private Framework BXp;

	private UserLog BXQ;

	private bool BXq;

	private Rectangle BXR;

	private bool BXr;

	private bool BXS;

	private int BXs;

	private Setting BXT;

	private Setting BXt;

	private Setting BXU;

	private Setting BXu;

	private ThemedButton BXV = new ThemedButton();

	private Label BXv = new Label();

	private Label BXW = new Label();

	private Label BXw = new Label();

	private List<ThemedComboBox> BXX = new List<ThemedComboBox>();

	private List<Label> BXx = new List<Label>();

	private Class85 BXY = new Class85();

	private bool BXy;

	internal Class119(UserLog userLog_0, Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false)
	{
		BXP = framework_0;
		BXp = framework_1;
		BXQ = userLog_0;
		BXq = BXP.method_31(BXQ.DataIdOfChannelRateSetting).method_277() == 1;
		Form23.form23_0.method_9(method_17);
		BXR = rectangle_0;
	}

	protected override void Dispose(bool disposing)
	{
		method_15();
		try
		{
			Form23.form23_0.method_10(method_17);
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
			BXV.Click -= BXV_Click;
			foreach (ThemedComboBox item in BXX)
			{
				item.SelectedIndexChanged -= method_22;
			}
			if (BXT != null)
			{
				BXT.method_265(method_19);
			}
			if (BXt != null)
			{
				BXt.method_265(method_20);
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
		BXr = BXP.method_2() && BXP.method_3() && BXP.method_31(BXQ.DataIdOfChannelListSetting).method_96();
		BXS = BXp != null && BXp.method_2() && BXp.method_3() && BXp.method_31(BXQ.DataIdOfChannelListSetting).method_96();
		if ((Form23.enum60_0 != Form23.Enum60.BpG || BXp == null) ? BXr : BXS)
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
			BXT = BXP.method_31(BXQ.DataIdOfChannelListSetting);
			BXt = BXP.method_31(BXQ.DataIdOfChannelRateSetting);
			if (BXp != null)
			{
				BXU = BXp.method_31(BXQ.DataIdOfChannelListSetting);
				BXu = BXp.method_31(BXQ.DataIdOfChannelRateSetting);
			}
			BXw.Text = Class333.BHm();
			BXw.ForeColor = Form23.color_12;
			BXw.Height = 16;
			BXw.Width = 200;
			int left = 5;
			int num = 5;
			if (BXq)
			{
				BXY.BackColor = Form23.color_17;
				BXY.ForeColor = Form23.color_12;
				BXY.FullRowSelect = false;
				BXY.HeaderStyle = ColumnHeaderStyle.Nonclickable;
				BXY.UseCompatibleStateImageBehavior = false;
				BXY.View = View.Details;
				ColumnHeader columnHeader = new ColumnHeader();
				columnHeader.Text = Class333.smethod_2310();
				BXY.Columns.Add(columnHeader);
				method_12().Controls.Add(BXY);
				BXw.Left = left;
				BXw.Top = num + 3;
				method_12().Controls.Add(BXw);
				num = BXw.Bottom;
				ThemedComboBox themedComboBox = new ThemedComboBox();
				themedComboBox.Enabled = BXP.method_4();
				Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || BXu == null) ? BXt : BXu);
				int selectedIndex = 0;
				int num2 = setting.method_256();
				List<Setting.ListItems.Struct45> list = setting.method_102();
				for (int i = 0; i < list.Count; i++)
				{
					themedComboBox.Items.Add(list[i].bBV);
					if (list[i].bBv == num2)
					{
						selectedIndex = i;
					}
				}
				themedComboBox.SelectedIndex = selectedIndex;
				themedComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
				themedComboBox.Tag = 0;
				themedComboBox.Left = left;
				themedComboBox.Top = num;
				themedComboBox.Width = 200;
				themedComboBox.SelectedIndexChanged += method_22;
				method_12().Controls.Add(themedComboBox);
				num = themedComboBox.Bottom + 10;
				BXX.Add(themedComboBox);
			}
			BXV.Enabled = BXP.method_4();
			BXV.Text = Class333.BHN();
			BXV.Left = left;
			BXV.Top = num;
			BXV.Width = 180;
			BXV.Height = 25;
			BXV.Click += BXV_Click;
			method_12().Controls.Add(BXV);
			num = BXV.Bottom;
			BXv.Text = Class333.BHn();
			BXv.ForeColor = Form23.color_12;
			BXv.Left = left;
			BXv.Top = num + 3;
			BXv.Width = 500;
			BXv.Height = 16;
			method_12().Controls.Add(BXv);
			num = BXv.Bottom + 10;
			BXW.ForeColor = Form23.color_12;
			BXW.Left = left;
			BXW.Top = num + 3;
			BXW.Height = 16;
			BXW.Width = 400;
			method_12().Controls.Add(BXW);
			if (BXq)
			{
				num = BXW.Bottom + 10;
			}
			else
			{
				left = BXW.Right;
				BXw.Left = left;
				BXw.Top = num + 3;
				method_12().Controls.Add(BXw);
				left = 5;
				num = BXw.Bottom + 10;
			}
			BXs = num;
			if (Form23.enum60_0 == Form23.Enum60.BpG && BXp != null)
			{
				smethod_0(BXp, this, BXQ);
			}
			else
			{
				smethod_0(BXP, this, BXQ);
			}
			BXT.method_264(method_19);
			BXt.method_264(method_20);
			method_18();
		}
		if (BXR != Rectangle.Empty)
		{
			Width = BXR.Width;
			Height = BXR.Height;
			Left = BXR.Left;
			Top = BXR.Top;
		}
		else
		{
			int num3 = 0;
			int num4 = 0;
			foreach (Control control in method_12().Controls)
			{
				num3 = Math.Max(num3, control.Right + 10);
				num4 = Math.Max(num4, control.Bottom + 30);
			}
			Width = num3;
			Height = num4;
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
	}

	private void method_17(object sender, EventArgs e)
	{
		bool flag = false;
		switch (Form23.enum60_0)
		{
		case Form23.Enum60.BpF:
			flag = BXr != BXS;
			break;
		case Form23.Enum60.Bpf:
			flag = false;
			break;
		case Form23.Enum60.BpG:
			flag = BXr != BXS;
			break;
		}
		if (flag)
		{
			method_15();
			method_12().Controls.Clear();
			method_16();
		}
		else if ((Form23.enum60_0 != Form23.Enum60.BpG && !BXr) || (Form23.enum60_0 == Form23.Enum60.BpG && !BXS))
		{
			method_21();
			if (Form23.enum60_0 == Form23.Enum60.BpG && BXp != null)
			{
				smethod_0(BXp, this, BXQ);
			}
			else
			{
				smethod_0(BXP, this, BXQ);
			}
			method_18();
		}
	}

	private void method_18()
	{
		if (!BXq)
		{
			return;
		}
		string text = Class333.BHO();
		string text2 = BXW.Text;
		if ((Form23.enum60_0 != Form23.Enum60.BpG && !BXr) || (Form23.enum60_0 == Form23.Enum60.BpG && !BXS))
		{
			if (BXU != null && !BXT.method_282(BXU))
			{
				BXW.ForeColor = Form23.color_9;
				if (!text2.EndsWith(text))
				{
					BXW.Text += text;
				}
			}
			else
			{
				BXW.ForeColor = Form23.color_12;
				if (text2.EndsWith(text))
				{
					BXW.Text = text2.Substring(0, text2.IndexOf(text));
				}
			}
			if (BXu != null && !BXt.method_282(BXu))
			{
				BXX[0].BackColor = Form23.color_9;
			}
			else
			{
				BXX[0].BackColor = Form23.color_32;
			}
		}
		else
		{
			BXW.ForeColor = Form23.color_12;
			if (text2.EndsWith(text))
			{
				BXW.Text = text2.Substring(0, text2.IndexOf(text));
			}
			BXX[0].BackColor = Form23.color_32;
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate84 method = method_19;
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
		bool flag = method_12().Controls.Contains(BXY);
		for (int i = 0; i < BXT.method_242()[2]; i++)
		{
			if (BXT.method_258(i) != 0 && BXT.method_258(i) != BXT.method_236())
			{
				if (flag && i < BXY.Items.Count)
				{
					Setting setting = BXP.method_31(BXT.method_258(i));
					if (BXY.Items[i].Tag != setting)
					{
						smethod_0(BXP, this, BXQ);
						break;
					}
					continue;
				}
				if (!flag && i < BXx.Count)
				{
					Setting setting2 = BXP.method_31(BXT.method_258(i));
					if (BXx[i].Tag != setting2)
					{
						smethod_0(BXP, this, BXQ);
						break;
					}
					continue;
				}
				smethod_0(BXP, this, BXQ);
				break;
			}
			if (!flag)
			{
				if (!flag)
				{
					if (BXx.Count != i)
					{
						smethod_0(BXP, this, BXQ);
					}
					break;
				}
				continue;
			}
			if (BXY.Items.Count != i)
			{
				smethod_0(BXP, this, BXQ);
			}
			break;
		}
		method_18();
	}

	private void method_20(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate85 method = method_20;
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
			method_21();
			method_18();
		}
	}

	private void method_21()
	{
		Setting setting;
		Setting setting2;
		if (Form23.enum60_0 == Form23.Enum60.BpG && BXU != null && BXu != null)
		{
			setting = BXU;
			setting2 = BXu;
		}
		else
		{
			setting = BXT;
			setting2 = BXt;
		}
		if (BXq)
		{
			if (BXX[0].DroppedDown)
			{
				return;
			}
			int num = -1;
			int num2 = setting2.method_256();
			List<Setting.ListItems.Struct45> list = setting2.method_102();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].bBv == num2)
				{
					num = i;
					break;
				}
			}
			if (BXX[0].SelectedIndex != num && num != -1)
			{
				BXX[0].SelectedIndex = num;
			}
			return;
		}
		for (int j = 0; j < setting.method_242()[2] && setting.method_258(j) != 0 && setting.method_258(j) != setting.method_236(); j++)
		{
			if (j >= BXX.Count || BXX[j].DroppedDown)
			{
				continue;
			}
			int num3 = -1;
			int num4 = setting2.method_258(j);
			List<Setting.ListItems.Struct45> list2 = setting2.method_102();
			for (int k = 0; k < list2.Count; k++)
			{
				if (list2[k].bBv == num4)
				{
					num3 = k;
					break;
				}
			}
			if (BXX[j].SelectedIndex != num3 && num3 != -1)
			{
				BXX[j].SelectedIndex = num3;
			}
		}
	}

	private static void smethod_0(Framework framework_0, Class119 class119_0, UserLog userLog_0)
	{
		if (class119_0 == null || (Form23.enum60_0 != Form23.Enum60.BpG && class119_0.BXr) || (Form23.enum60_0 == Form23.Enum60.BpG && class119_0.BXS))
		{
			return;
		}
		int left = 5;
		int num = class119_0.BXs;
		bool flag = framework_0.method_31(userLog_0.DataIdOfChannelRateSetting).method_277() == 1;
		class119_0.SuspendLayout();
		class119_0.method_12().SuspendLayout();
		Setting setting;
		Setting setting2;
		if (Form23.enum60_0 == Form23.Enum60.BpG && class119_0.BXU != null && class119_0.BXu != null)
		{
			setting = class119_0.BXU;
			setting2 = class119_0.BXu;
			class119_0.BXV.Enabled = false;
			if (flag && class119_0.BXX.Count == 1)
			{
				class119_0.BXX[0].Enabled = false;
			}
		}
		else
		{
			setting = class119_0.BXT;
			setting2 = class119_0.BXt;
			class119_0.BXV.Enabled = framework_0.method_4();
			if (flag && class119_0.BXX.Count == 1)
			{
				class119_0.BXX[0].Enabled = framework_0.method_4();
			}
		}
		int num2 = 0;
		for (int i = 0; i < setting.method_242()[2] && setting.method_258(i) != 0 && setting.method_258(i) != setting.method_236(); i++)
		{
			num2++;
		}
		class119_0.BXW.Text = num2 + Class333.BHo();
		if (!flag)
		{
			foreach (Label item in class119_0.BXx)
			{
				class119_0.method_12().Controls.Remove(item);
			}
		}
		else
		{
			class119_0.BXY.BeginUpdate();
			class119_0.BXY.Items.Clear();
		}
		class119_0.BXx.Clear();
		if (!flag)
		{
			foreach (ThemedComboBox item2 in class119_0.BXX)
			{
				item2.SelectedIndexChanged -= class119_0.method_22;
				class119_0.method_12().Controls.Remove(item2);
			}
			class119_0.BXX.Clear();
		}
		List<ListViewItem> list = new List<ListViewItem>();
		for (int j = 0; j < setting.method_242()[2] && setting.method_258(j) != 0 && setting.method_258(j) != setting.method_236(); j++)
		{
			Setting setting3 = framework_0.method_31(setting.method_258(j));
			if (flag)
			{
				if (class119_0.BXY.Left == 0 || class119_0.BXY.Top == 0)
				{
					class119_0.BXY.Left = left;
					class119_0.BXY.Top = num;
					class119_0.BXY.Width = 300;
					class119_0.BXY.Height = 200;
					class119_0.BXY.Columns[0].Width = class119_0.BXY.Width - 25;
				}
				string text = ((setting3 == null) ? Class333.BHP() : setting3.method_60(Enum96.aYt));
				ListViewItem listViewItem = new ListViewItem(new string[1] { text });
				listViewItem.Tag = setting3;
				list.Add(listViewItem);
				continue;
			}
			Label label = new Label();
			label.Tag = setting3;
			if (setting3 != null)
			{
				label.Text = setting3.method_60(Enum96.aYt);
			}
			else
			{
				label.Text = Class333.BHP();
			}
			label.ForeColor = Form23.color_12;
			label.Left = left;
			label.Top = num + 3;
			label.Height = 16;
			label.Width = 400;
			class119_0.method_12().Controls.Add(label);
			class119_0.BXx.Add(label);
			left = label.Right;
			ThemedComboBox themedComboBox = new ThemedComboBox();
			int selectedIndex = 0;
			int num3 = setting2.method_258(j);
			List<Setting.ListItems.Struct45> list2 = setting2.method_102();
			for (int k = 0; k < list2.Count; k++)
			{
				themedComboBox.Items.Add(list2[k].bBV);
				if (list2[k].bBv == num3)
				{
					selectedIndex = k;
				}
			}
			themedComboBox.SelectedIndex = selectedIndex;
			themedComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			themedComboBox.Tag = j;
			themedComboBox.Left = left;
			themedComboBox.Top = num;
			themedComboBox.Width = 200;
			themedComboBox.SelectedIndexChanged += class119_0.method_22;
			class119_0.method_12().Controls.Add(themedComboBox);
			class119_0.BXX.Add(themedComboBox);
			num = themedComboBox.Bottom;
			left = 5;
		}
		if (flag)
		{
			class119_0.BXY.Items.AddRange(list.ToArray());
			class119_0.BXY.EndUpdate();
			class119_0.BXY.method_1();
		}
		if (class119_0.BXR == Rectangle.Empty)
		{
			int num4 = 0;
			int num5 = 0;
			foreach (Control control in class119_0.method_12().Controls)
			{
				num4 = Math.Max(num4, control.Right + 10);
				num5 = Math.Max(num5, control.Bottom + 30);
			}
			class119_0.Width = num4;
			class119_0.Height = num5;
		}
		class119_0.method_12().ResumeLayout(performLayout: true);
		class119_0.ResumeLayout(performLayout: true);
	}

	private void method_22(object sender, EventArgs e)
	{
		if (BXy)
		{
			BXy = false;
		}
		else
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				return;
			}
			ThemedComboBox themedComboBox = sender as ThemedComboBox;
			int selectedIndex = themedComboBox.SelectedIndex;
			Setting setting = BXP.method_31(BXQ.DataIdOfChannelRateSetting);
			if (setting.method_25())
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_2(setting.method_64());
				setting.method_274((int)themedComboBox.Tag, setting.method_102()[selectedIndex].bBv, bool_0: true);
				@class?.method_4();
				Form23.smethod_74(setting.method_64());
				return;
			}
			int num = setting.method_258((int)themedComboBox.Tag);
			List<Setting.ListItems.Struct45> list = setting.method_102();
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
			BXy = true;
			themedComboBox.SelectedIndex = num2;
		}
	}

	private void BXV_Click(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		List<int> list = new List<int>();
		for (int i = 0; i < BXT.method_242()[2] && BXT.method_258(i) != 0 && BXT.method_258(i) != BXT.method_236(); i++)
		{
			list.Add(BXT.method_258(i));
		}
		List<int> list2 = Form45.smethod_0(Form23.form23_0, BXP, list, BXT.method_242()[2]);
		if (list2 == null || !BXT.method_25())
		{
			return;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BXT.method_64());
		BXT.method_268();
		for (int j = 0; j < list2.Count; j++)
		{
			BXT.method_274(j, list2[j], bool_0: true);
			if (BXq)
			{
				continue;
			}
			bool flag = false;
			for (int k = 0; k < list.Count; k++)
			{
				if (list[k] == list2[j])
				{
					int num = BXt.method_258(k);
					BXt.method_274(j, num, bool_0: true);
					flag = true;
					break;
				}
			}
			if (!flag && BXt.method_258(j) == 0)
			{
				BXt.method_274(j, 50, bool_0: true);
			}
		}
		int num2 = BXT.method_236();
		for (int l = list2.Count; l < BXT.method_242()[2]; l++)
		{
			BXT.method_274(l, num2, bool_0: true);
		}
		BXT.method_267(bool_0: true);
		if (!BXq)
		{
			int num3 = BXt.method_236();
			for (int m = list2.Count; m < BXt.method_242()[2]; m++)
			{
				BXt.method_274(m, num3, bool_0: true);
			}
		}
		@class?.method_4();
		Form23.smethod_74(BXT.method_64());
		smethod_0(BXP, this, BXQ);
	}

	public Control imethod_0(DataIdAndAttrId dataIdAndAttrId_0)
	{
		if (BXY.Visible && method_12().Controls.Contains(BXY) && BXT != null && dataIdAndAttrId_0.DataId == BXT.method_64())
		{
			return BXY;
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
