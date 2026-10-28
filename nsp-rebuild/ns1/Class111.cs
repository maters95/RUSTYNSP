using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal class Class111 : Class109
{
	private const int BUB = 5;

	private const int BUb = 2;

	private const int BUC = 300;

	private const int BUc = 300;

	private const int BUD = 5;

	private const int BUd = 10;

	private const int BUE = 30;

	private Framework BUe;

	private Framework BUF;

	private PictureBox BUf = new PictureBox();

	private ThemedTextBox BUG = new ThemedTextBox();

	private ThemedButton BUg = new ThemedButton();

	private Timer BUH = new Timer();

	private Class85 BUh = new Class85();

	private Class117 BUI;

	private ThemedButton BUi = new ThemedButton();

	private SortedList<string, ListViewItem> BUJ = new SortedList<string, ListViewItem>();

	internal Class111(Rectangle rectangle_0, Framework framework_0, Framework framework_1, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false)
	{
		BUe = framework_0;
		BUF = framework_1;
		BUf.BackColor = BackColor;
		if (BUf.Image != null)
		{
			BUf.Image.Dispose();
		}
		BUf.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		BUf.Width = 24;
		BUf.Height = 24;
		BUf.Left = 5;
		BUf.Top = 2;
		BUg.Width = 22;
		BUG.BackColor = Form23.color_32;
		BUG.ForeColor = Form23.color_12;
		BUG.TextChanged += BUG_TextChanged;
		BUG.method_0(method_19);
		BUG.Left = BUf.Left + BUf.Width + 1;
		BUG.Top = 2;
		BUG.Width = 296 - (BUf.Width + BUg.Width + 6);
		BUg.Click += BUg_Click;
		BUg.Text = Class333.smethod_330();
		BUg.Font = new Font(BUg.Font.FontFamily, 8f, FontStyle.Bold);
		BUg.Left = BUG.Left + BUG.Width + 3;
		BUg.Top = BUG.Top - 2;
		BUg.Height = BUG.Height + 2;
		BUH.Interval = 400;
		BUH.Tick += BUH_Tick;
		BUh.Columns.Add(Class333.smethod_2310(), 278);
		BUh.Left = 5;
		BUh.Top = BUG.Top + BUG.Height + 5;
		BUh.Width = 300;
		BUh.Height = 300;
		BUh.BackColor = Form23.color_17;
		BUh.ForeColor = Form23.color_12;
		BUh.Font = new Font(Font.FontFamily, 8.5f);
		BUh.MultiSelect = false;
		BUh.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		BUh.View = View.Details;
		BUh.FullRowSelect = true;
		BUh.HideSelection = false;
		BUi.Text = Class333.BeE();
		BUi.Left = 5;
		BUi.Top = BUh.Bottom + 10;
		BUi.Width = 300;
		BUi.Height = 25;
		BUi.Click += BUi_Click;
		method_12().Controls.Add(BUf);
		method_12().Controls.Add(BUG);
		method_12().Controls.Add(BUg);
		method_12().Controls.Add(BUh);
		method_12().Controls.Add(BUi);
		method_15();
		method_16();
		BUh.SelectedIndexChanged += BUh_SelectedIndexChanged;
		BUG.Focus();
		if (rectangle_0 != Rectangle.Empty)
		{
			Width = rectangle_0.Width;
			Height = rectangle_0.Height;
			Left = rectangle_0.Left;
			Top = rectangle_0.Top;
			return;
		}
		int num = 0;
		int num2 = 0;
		foreach (Control control in method_12().Controls)
		{
			num = Math.Max(num, control.Right + 10);
			num2 = Math.Max(num2, control.Bottom + 10);
		}
		Width = num;
		Height = num2;
	}

	private void method_15()
	{
		BUJ.Clear();
		List<string> list = new List<string>();
		foreach (Setting item in BUe.aWt)
		{
			if (!item.method_35() || !item.method_184() || item.method_212() || !PortFunction.smethod_52(item))
			{
				continue;
			}
			string text = item.method_60(Enum96.aYt);
			if (text == null)
			{
				text = item.method_2();
			}
			string text2 = item.method_18();
			if (!string.IsNullOrWhiteSpace(text2))
			{
				text = text2 + Class333.smethod_497() + text + Class333.smethod_9();
			}
			ListViewItem listViewItem = new ListViewItem(new string[1] { text });
			listViewItem.Tag = item.method_64();
			if (BUJ.ContainsKey(text))
			{
				if (!list.Contains(text))
				{
					list.Add(text);
				}
			}
			else
			{
				BUJ.Add(text, listViewItem);
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		string text3 = Class333.smethod_2526();
		foreach (string item2 in list)
		{
			text3 = text3 + Class333.smethod_570() + item2;
		}
		Form54.smethod_6(this, text3, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	private void method_16()
	{
		string text = BUG.Text.ToUpper();
		string[] string_ = text.Split(' ', ',');
		BUh.BeginUpdate();
		BUh.Items.Clear();
		foreach (ListViewItem value in BUJ.Values)
		{
			int num = (int)value.Tag;
			Setting setting = BUe.method_31(num);
			if (setting != null && method_17(setting, out var bool_, text, string_))
			{
				if ((BUh.Items.Count != 0) & bool_)
				{
					BUh.Items.Insert(0, value);
				}
				else
				{
					BUh.Items.Add(value);
				}
			}
		}
		BUh.EndUpdate();
		BUh.method_1();
	}

	private bool method_17(Setting setting_0, out bool bool_0, string string_0, string[] string_1)
	{
		string text = setting_0.method_22(bool_0: true);
		string text2 = string.Empty;
		if (setting_0.method_62() != null)
		{
			text2 = setting_0.method_62();
		}
		string text3 = setting_0.method_60(Enum96.aYT);
		if (text3 == null)
		{
			text3 = setting_0.method_2();
		}
		string text4 = text3.ToUpper();
		string text5 = text.ToUpper();
		string text6 = text2.ToUpper();
		bool result = true;
		bool_0 = false;
		if (!(string_0 == text5) && !(string_0 == text4))
		{
			foreach (string item in setting_0.method_23())
			{
				if (string_0 == item.ToUpper())
				{
					bool_0 = true;
					break;
				}
			}
		}
		else
		{
			bool_0 = true;
		}
		if (!bool_0)
		{
			foreach (string value in string_1)
			{
				if (text5.Contains(value) || text4.Contains(value) || text6.Contains(value))
				{
					continue;
				}
				bool flag = false;
				foreach (string item2 in setting_0.method_23())
				{
					if (item2.ToUpper().Contains(value))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					result = false;
					break;
				}
			}
		}
		return result;
	}

	private void BUh_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (BUh.SelectedItems.Count == 0)
		{
			return;
		}
		int num = (int)BUh.SelectedItems[0].Tag;
		Setting setting = BUe.method_31(num);
		if (setting != null)
		{
			if (BUI != null)
			{
				BUI.Dispose();
			}
			BUI = new Class117(setting, setting.method_22(bool_0: true), BUe, BUF, Rectangle.Empty, bool_0: false, bool_1: true);
			BUI.Left = BUh.Left + BUh.Width + 30;
			BUI.Top = BUh.Top;
			method_12().Controls.Add(BUI);
			BUI.method_15(bool_0: true);
		}
	}

	[SpecialName]
	internal ThemedTextBox method_18()
	{
		return BUG;
	}

	private void BUg_Click(object sender, EventArgs e)
	{
		BUG.Text = string.Empty;
	}

	private void BUG_TextChanged(object sender, EventArgs e)
	{
		BUH.Stop();
		BUH.Start();
	}

	private void method_19(object sender, ThemedTextBox.EventArgs4 e)
	{
		BUH.Stop();
		BUH.Start();
	}

	private void BUH_Tick(object sender, EventArgs e)
	{
		BUH.Stop();
		method_16();
	}

	internal void method_20(string string_0)
	{
		ListViewItem listViewItem = BUh.FindItemWithText(string_0);
		if (listViewItem != null)
		{
			BUh.SelectedItems.Clear();
			listViewItem.Selected = true;
			listViewItem.Focused = true;
			listViewItem.EnsureVisible();
		}
	}

	private void BUi_Click(object sender, EventArgs e)
	{
		if (Form54.smethod_6(this, Class333.Bee(), Class333.BeF(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
		{
			return;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_1();
		BUe.method_55();
		foreach (Setting item in BUe.aWt)
		{
			BUe.method_32(new DataIdAndAttrId(item.method_64(), 4))?.method_272((item.method_231() << 8) | Class233.smethod_23(item.method_231()), bool_0: true);
			BUe.method_32(new DataIdAndAttrId(item.method_64(), 5))?.method_272(Class233.smethod_39(item.method_231()), bool_0: true);
		}
		Form23.smethod_76();
		BUe.method_54(bool_0: true);
		@class?.method_4();
	}

	protected override void Dispose(bool disposing)
	{
		BUG.TextChanged -= BUG_TextChanged;
		BUG.method_1(method_19);
		BUg.Click -= BUg_Click;
		BUH.Tick -= BUH_Tick;
		BUh.SelectedIndexChanged -= BUh_SelectedIndexChanged;
		BUi.Click -= BUi_Click;
		try
		{
			BUf.Dispose();
			BUG.Dispose();
			BUg.Dispose();
			BUH.Dispose();
			BUh.Dispose();
			BUi.Dispose();
			if (BUI != null)
			{
				BUI.Dispose();
			}
		}
		catch
		{
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
