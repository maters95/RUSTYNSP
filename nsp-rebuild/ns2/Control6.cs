using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns3;
using ns4;
using ns6;
using ns7;

namespace ns2;

internal class Control6 : UserControl
{
	private class Class132 : ListViewItem
	{
		internal bool BMH;

		internal bool BMh;

		internal bool BMI;

		internal Class132(string[] string_0, bool bool_0, bool bool_1, bool bool_2)
			: base(string_0)
		{
			BMH = bool_0;
			BMh = bool_1;
			BMI = bool_2;
		}
	}

	private delegate void Delegate32(object sender, EventArgs e);

	private delegate void Delegate33(object sender, EventArgs e);

	private delegate void Delegate34(object sender, EventArgs e);

	private class Class133 : IComparer
	{
		private int BMi;

		private bool BMJ;

		internal Class133(int int_0, bool bool_0)
		{
			BMi = int_0;
			BMJ = bool_0;
		}

		public int Compare(object listViewItem1, object listViewItem2)
		{
			Class132 @class = (Class132)listViewItem1;
			Class132 class2 = (Class132)listViewItem2;
			if ((@class.Tag == null && !@class.BMh && !@class.BMI) || (class2.Tag == null && !class2.BMh && !class2.BMI))
			{
				if (@class.Tag == null && !@class.BMh && !@class.BMI)
				{
					return -1;
				}
				return 1;
			}
			if (@class.BMh)
			{
				if (class2.BMH)
				{
					if (class2.BMI)
					{
						return -1;
					}
					return 1;
				}
				return -1;
			}
			if (class2.BMh)
			{
				if (@class.BMH)
				{
					if (@class.BMI)
					{
						return 1;
					}
					return -1;
				}
				return 1;
			}
			if (@class.BMI)
			{
				if (class2.BMH)
				{
					return 1;
				}
				return -1;
			}
			if (class2.BMI)
			{
				if (@class.BMH)
				{
					return -1;
				}
				return 1;
			}
			if ((@class.BMH && class2.BMH) || (!@class.BMH && !class2.BMH))
			{
				if (!string.IsNullOrWhiteSpace(@class.SubItems[BMi].Text) && !string.IsNullOrWhiteSpace(class2.SubItems[BMi].Text) && char.IsDigit(@class.SubItems[BMi].Text.Trim()[0]) && char.IsDigit(class2.SubItems[BMi].Text.Trim()[0]))
				{
					int num = int.Parse(Regex.Match(@class.SubItems[BMi].Text.Trim(), Class333.BCv()).ToString());
					int num2 = int.Parse(Regex.Match(class2.SubItems[BMi].Text.Trim(), Class333.BCv()).ToString());
					if (BMJ)
					{
						return num2 - num;
					}
					return num - num2;
				}
				if (BMJ)
				{
					return string.Compare(class2.SubItems[BMi].Text, @class.SubItems[BMi].Text);
				}
				return string.Compare(@class.SubItems[BMi].Text, class2.SubItems[BMi].Text);
			}
			if (@class.BMH && !class2.BMH)
			{
				return -1;
			}
			return 1;
		}
	}

	private MenuNode menuNode_0;

	private Setting setting_0;

	private string string_0;

	private List<(Class287, string)> list_0;

	private System.Windows.Forms.Timer timer_0 = new System.Windows.Forms.Timer();

	private bool bool_0;

	private int int_0 = -1;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	private IContainer icontainer_0;

	private ThemedTextBox themedTextBox_0;

	private PictureBox pictureBox_0;

	private ThemedButton themedButton_0;

	private Class85 class85_0;

	private Label label_0;

	private Class134 class134_0;

	private Label label_1;

	private Class148 class148_0;

	private ThemedButton themedButton_1;

	private PictureBox pictureBox_1;

	internal Control6()
	{
		method_24();
	}

	[SpecialName]
	internal MenuNode method_0()
	{
		return menuNode_0;
	}

	internal void method_1(MenuNode menuNode_1)
	{
		timer_0.Interval = 400;
		timer_0.Tick += timer_0_Tick;
		BackColor = Form23.color_10;
		class85_0.BackColor = Form23.color_17;
		class85_0.ForeColor = Form23.color_12;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				(control as Label).ForeColor = Form23.color_12;
			}
		}
		class148_0.ForeColor = Form23.color_12;
		pictureBox_0.BackColor = BackColor;
		if (pictureBox_0.Image != null)
		{
			pictureBox_0.Image.Dispose();
		}
		pictureBox_0.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		class134_0.BackColor = Form23.color_17;
		class134_0.ForeColor = Form23.color_12;
		menuNode_0 = menuNode_1;
		setting_0 = menuNode_0.method_1().method_31(menuNode_0.method_73());
		list_0 = Class286.smethod_9(menuNode_0, setting_0, bool_0: false);
		if (!method_10())
		{
			method_3();
		}
		method_18();
		Visible = setting_0.method_35() || (Parent != null && Parent is Form30);
		setting_0.method_265(method_5);
		setting_0.method_264(method_5);
		setting_0.method_41(method_6);
		setting_0.method_40(method_6);
		Form23.smethod_90(method_2);
		Form23.smethod_89(method_2);
	}

	private void method_2(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			Delegate32 method = method_2;
			BeginInvoke(method, sender, e);
		}
		else
		{
			list_0 = Class286.smethod_9(menuNode_0, setting_0, bool_0: false);
			string string_ = string_0;
			bool_3 = true;
			method_3();
			method_8(string_);
			bool_3 = false;
		}
	}

	private void method_3()
	{
		if (class85_0.Columns.Count != 0)
		{
			string_0 = null;
			method_16();
			class85_0.Items.Clear();
		}
		if (list_0.Count == 0)
		{
			class85_0.method_1();
			return;
		}
		bool flag = false;
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		Class287 @class = null;
		foreach (var item4 in list_0)
		{
			Class287 item = item4.Item1;
			if (list.Count == 0 && menuNode_0.method_1().awF.ContainsKey(item.BcF.BCx))
			{
				list.AddRange(menuNode_0.method_1().awF[item.BcF.BCx].method_78());
			}
			if (list2.Count == 0 && menuNode_0.method_1().awF.ContainsKey(item.BcF.BCx))
			{
				list2.AddRange(menuNode_0.method_1().awF[item.BcF.BCx].method_79());
			}
			if (@class == null || item.BcF.Bcb.Count > @class.BcF.Bcb.Count)
			{
				@class = item;
			}
			if (!flag && menuNode_0.method_1().awF.ContainsKey(item.BcF.BCx) && menuNode_0.method_1().awF[item.BcF.BCx].method_83())
			{
				flag = true;
			}
		}
		List<string> list3 = new List<string>();
		foreach (string key in @class.BcF.Bcb.Keys)
		{
			if (!list.Contains(key) && !list2.Contains(key))
			{
				list3.Add(key);
			}
		}
		foreach (var item5 in list_0)
		{
			Class287 item2 = item5.Item1;
			if (item2 == @class)
			{
				continue;
			}
			foreach (string key2 in item2.BcF.Bcb.Keys)
			{
				if (!list3.Contains(key2) && !list.Contains(key2) && !list2.Contains(key2))
				{
					list3.Add(key2);
				}
			}
		}
		int num = 1;
		if (flag)
		{
			num++;
		}
		if (class85_0.Columns.Count == 0)
		{
			ColumnHeader columnHeader = new ColumnHeader();
			columnHeader.Text = Class333.smethod_304();
			class85_0.Columns.Add(columnHeader);
			if (flag)
			{
				ColumnHeader columnHeader2 = new ColumnHeader();
				columnHeader2.Text = Class333.smethod_91();
				class85_0.Columns.Add(columnHeader2);
			}
			foreach (string item6 in list3)
			{
				ColumnHeader columnHeader3 = new ColumnHeader();
				columnHeader3.Text = Class286.smethod_12(item6, Class333.smethod_562());
				class85_0.Columns.Add(columnHeader3);
			}
		}
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		for (int i = 0; i < list3.Count; i++)
		{
			dictionary.Add(list3[i], num + i);
		}
		string[] array = new string[num + list3.Count];
		if (!menuNode_0.method_37())
		{
			array[0] = Class333.smethod_561();
			Class132 value = new Class132(array, bool_0: true, bool_1: false, bool_2: false)
			{
				Tag = null,
				ToolTipText = Class333.smethod_564() + menuNode_0.method_10() + Class333.smethod_565()
			};
			class85_0.Items.Add(value);
		}
		else if (menuNode_0.method_1().awP.method_97())
		{
			array[0] = Class333.smethod_566();
			Class132 value2 = new Class132(array, bool_0: true, bool_1: false, bool_2: false)
			{
				Tag = null,
				ToolTipText = Class333.smethod_567() + menuNode_0.method_10() + Class333.smethod_568()
			};
			class85_0.Items.Add(value2);
		}
		bool flag2 = false;
		foreach (var item7 in list_0)
		{
			Class287 item3 = item7.Item1;
			if (!class148_0.Checked && !item3.BcF.method_20())
			{
				continue;
			}
			string[] array2 = new string[num + list3.Count];
			array2[0] = item3.BcF.BcC[Class333.smethod_562()].Bsp;
			if (flag)
			{
				array2[1] = item3.BcF.BcC[Class333.smethod_562()].BsQ;
			}
			string text = item3.BcF.BcC[Class333.smethod_562()].BsP + Class333.smethod_569() + item3.BcF.BCY.ToString() + Class333.smethod_570() + item3.BcF.BcC[Class333.smethod_562()].BsQ;
			foreach (string item8 in list3)
			{
				if (item3.BcF.Bcb.ContainsKey(item8))
				{
					array2[dictionary[item8]] = item3.BcF.Bcb[item8];
					text = text + Class333.smethod_570() + Class286.smethod_12(item8, Class333.smethod_562()) + Class333.smethod_571() + item3.BcF.Bcb[item8];
				}
				else
				{
					array2[dictionary[item8]] = string.Empty;
				}
			}
			bool flag3;
			if (!(flag3 = method_9(item3.BcF)))
			{
				flag2 = true;
			}
			Class132 value3 = new Class132(array2, flag3, bool_1: false, bool_2: false)
			{
				Tag = item3,
				ToolTipText = text
			};
			class85_0.Items.Add(value3);
		}
		if (flag2)
		{
			Class132 value4 = new Class132(new string[num + list3.Count], bool_0: true, bool_1: true, bool_2: false)
			{
				Tag = null,
				ToolTipText = Class333.smethod_572()
			};
			class85_0.Items.Add(value4);
			Class132 value5 = new Class132(new string[num + list3.Count], bool_0: true, bool_1: false, bool_2: true)
			{
				Tag = null,
				ToolTipText = Class333.smethod_572()
			};
			class85_0.Items.Add(value5);
		}
		method_4();
		if (class85_0.Columns.Count != 0)
		{
			method_20(bool_4: false, method_19());
		}
		class85_0.method_1();
		if (bool_3)
		{
			return;
		}
		method_7();
		if (class85_0.SelectedIndices.Count != 0)
		{
			return;
		}
		int num2 = 0;
		foreach (Class132 item9 in class85_0.Items)
		{
			if (item9.Tag != null && item9.BMH)
			{
				num2++;
			}
		}
		if (num2 != 1)
		{
			return;
		}
		foreach (Class132 item10 in class85_0.Items)
		{
			if (item10.Tag != null && item10.BMH)
			{
				item10.Selected = true;
				class85_0.FocusedItem = item10;
				break;
			}
		}
	}

	private void method_4()
	{
		if (class85_0.Columns.Count == 0)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < class85_0.Columns.Count; i++)
		{
			int val = TextRenderer.MeasureText(class85_0.Columns[i].Text, class85_0.Font).Width + 5;
			foreach (Class132 item in class85_0.Items)
			{
				val = Math.Max(val, TextRenderer.MeasureText(item.SubItems[i].Text, item.Font).Width + 5);
			}
			val = Math.Min(val, 300);
			class85_0.Columns[i].Width = val;
			num += val;
		}
		int num2 = class85_0.Width - 18;
		if (num > num2)
		{
			int width = num2 / class85_0.Columns.Count;
			for (int j = 0; j < class85_0.Columns.Count; j++)
			{
				class85_0.Columns[j].Width = width;
			}
		}
		else if (num < num2)
		{
			int num3 = (num2 - num) / class85_0.Columns.Count;
			for (int k = 0; k < class85_0.Columns.Count; k++)
			{
				class85_0.Columns[k].Width += num3;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate33 method = method_5;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_7();
	}

	private void method_6(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate34 method = method_6;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		Visible = setting_0.method_35() || (Parent != null && Parent is Form30);
	}

	private void method_7()
	{
		if (setting_0 != null)
		{
			string text = Class24.smethod_0(setting_0.method_259());
			if (text != Class333.smethod_563())
			{
				bool_2 = true;
				method_8(text);
				bool_2 = false;
			}
		}
	}

	private void method_8(string string_1)
	{
		bool flag = string_1 == null || string_1 == Class333.smethod_563();
		foreach (Class132 item in class85_0.Items)
		{
			Class287 class2 = item.Tag as Class287;
			if ((!flag && class2 != null && string_1 == class2.BcF.BCw) || (flag && class2 == null))
			{
				if (!item.Selected)
				{
					item.Selected = true;
				}
				class85_0.FocusedItem = item;
				item.EnsureVisible();
				break;
			}
		}
	}

	private bool method_9(Class286 class286_0)
	{
		bool result = true;
		if (!string.IsNullOrEmpty(themedTextBox_0.Text))
		{
			string[] array = themedTextBox_0.Text.ToLower().Split(' ', ',', '-', '+', '#', '&', '(', ')', '<', '>', '/', ':', ';', '|');
			foreach (string value in array)
			{
				Class286.Struct48 @struct = class286_0.BcC[Class333.smethod_562()];
				if ((!string.IsNullOrEmpty(@struct.BsP) && @struct.BsP.ToLower().Contains(value)) || (!string.IsNullOrEmpty(@struct.Bsp) && @struct.Bsp.ToLower().Contains(value)) || (!string.IsNullOrEmpty(@struct.BsQ) && @struct.BsQ.ToLower().Contains(value)))
				{
					continue;
				}
				bool flag = false;
				foreach (string value2 in class286_0.Bcb.Values)
				{
					if (value2.ToLower().Contains(value))
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

	private bool method_10()
	{
		bool result = false;
		if (setting_0 != null && menuNode_0.method_1().awF.ContainsKey(setting_0.method_8()))
		{
			Class256 @class = menuNode_0.method_1().awF[setting_0.method_8()];
			if (@class.method_87().Keys.Count != 0)
			{
				foreach (int key in @class.method_87().Keys)
				{
					Setting setting = menuNode_0.method_1().method_31(key);
					if (setting == null)
					{
						continue;
					}
					string text = Class24.smethod_0(setting.method_259());
					if (!(text != Class333.smethod_563()))
					{
						continue;
					}
					Class286 class2 = null;
					lock (Form23.object_0)
					{
						if (Form23.dictionary_1.ContainsKey(text))
						{
							class2 = Form23.dictionary_1[text].BcF;
						}
					}
					if (class2 == null)
					{
						continue;
					}
					string[] array = @class.method_87()[key];
					foreach (string text2 in array)
					{
						string text3 = null;
						if (text2.StartsWith(Class333.smethod_573()))
						{
							string text4 = text2.Substring(Class333.smethod_573().Length);
							if (!string.IsNullOrEmpty(text4) && class2.Bcb.ContainsKey(text4))
							{
								text3 = class2.Bcb[text4];
							}
						}
						else if (text2 == Class333.smethod_574())
						{
							text3 = class2.BcC[Class333.smethod_562()].BsP;
						}
						else if (text2 == Class333.smethod_575())
						{
							text3 = class2.BcC[Class333.smethod_562()].Bsp;
						}
						if (!string.IsNullOrEmpty(text3))
						{
							if (string.IsNullOrEmpty(themedTextBox_0.Text))
							{
								themedTextBox_0.Text = text3;
							}
							else
							{
								ThemedTextBox themedTextBox = themedTextBox_0;
								themedTextBox.Text = themedTextBox.Text + Class333.smethod_325() + text3;
							}
							result = true;
						}
					}
				}
			}
		}
		return result;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_11(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_12(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void class85_0_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
	{
		if (class85_0.SelectedIndices.Count == 0)
		{
			string_0 = null;
			method_16();
		}
		else if (e.Item.Selected)
		{
			if (!(e.Item as Class132).BMh && !(e.Item as Class132).BMI)
			{
				if (e.Item.Tag == null)
				{
					method_16();
					if (menuNode_0.method_1().awZ != 21)
					{
						label_0.Text = Class333.smethod_577();
						class134_0.Text = Class333.smethod_578() + menuNode_0.method_10() + Class333.smethod_565();
					}
					else
					{
						label_0.Text = Class333.smethod_579();
						class134_0.Text = Class333.smethod_580() + menuNode_0.method_10() + Class333.smethod_568();
					}
					method_18();
					string_0 = Class333.smethod_563();
					if ((Form48.smethod_2() || !bool_2) && !bool_3 && bool_1)
					{
						method_23();
					}
				}
				else
				{
					Class287 @class = e.Item.Tag as Class287;
					method_17(@class);
					string_0 = @class.BcF.BCw;
					if ((Form48.smethod_2() || !bool_2) && !bool_3 && bool_1)
					{
						method_23();
					}
				}
			}
			else
			{
				method_16();
				label_0.Text = string.Empty;
				class134_0.Text = Class333.smethod_576();
				method_18();
				string_0 = null;
			}
		}
		if (eventHandler_0 != null)
		{
			eventHandler_0(null, null);
		}
	}

	[SpecialName]
	internal string method_13()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_14(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_15(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void class85_0_DoubleClick(object sender, EventArgs e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(sender, e);
		}
	}

	private void method_16()
	{
		label_0.Text = Class333.smethod_581();
		label_1.Text = Class333.smethod_582();
		class134_0.Text = Class333.smethod_583();
		themedButton_1.Enabled = false;
		themedButton_1.Tag = null;
		pictureBox_1.Visible = false;
		pictureBox_1.Image = null;
		method_18();
	}

	private void method_17(Class287 class287_0)
	{
		label_0.Text = Class333.smethod_581() + class287_0.BcF.BcC[Class333.smethod_562()].BsP;
		label_1.Text = Class333.smethod_582() + class287_0.BcF.BCY.ToString();
		class134_0.Text = Class333.smethod_584() + class287_0.BcF.BcC[Class333.smethod_562()].BsQ;
		if (!string.IsNullOrEmpty(class287_0.BcF.Bca))
		{
			themedButton_1.Enabled = true;
			themedButton_1.Tag = class287_0.BcF;
		}
		else
		{
			themedButton_1.Enabled = false;
			themedButton_1.Tag = null;
		}
		Image image = Class288.smethod_1(class287_0);
		if (image != null)
		{
			pictureBox_1.Image = image;
			pictureBox_1.Visible = true;
		}
		else
		{
			pictureBox_1.Visible = false;
			pictureBox_1.Image = null;
		}
		method_18();
	}

	private void method_18()
	{
		int num = ((!bool_1) ? (Size.Height - 55) : (Size.Height - 4));
		class134_0.ScrollBars = RichTextBoxScrollBars.None;
		if (pictureBox_1.Visible)
		{
			int num2 = TextRenderer.MeasureText(class134_0.Text, class134_0.Font, new Size(class134_0.Width - 20, -1), TextFormatFlags.WordBreak).Height + 20;
			int num3;
			int num4;
			int height;
			if (num - (class134_0.Top + num2 + 9) >= 150)
			{
				num3 = num2;
				num4 = class134_0.Top + num3 + 9;
				height = num - num4;
			}
			else
			{
				height = 150;
				num4 = num - 150;
				num3 = num4 - 9 - class134_0.Top;
				if (num3 < 60)
				{
					num3 = 60;
					num4 = class134_0.Top + 60 + 9;
					height = num - num4;
				}
			}
			class134_0.Height = num3;
			pictureBox_1.Top = num4;
			pictureBox_1.Height = height;
		}
		else
		{
			class134_0.Height = num - class134_0.Top;
		}
		class134_0.ScrollBars = RichTextBoxScrollBars.Vertical;
		class134_0.method_0();
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		if ((sender as Button).Tag == null)
		{
			return;
		}
		Class286 @class = (sender as Button).Tag as Class286;
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
			Class23.smethod_3(Class333.smethod_587() + ex.Message);
		}
	}

	private int method_19()
	{
		if (setting_0 != null && menuNode_0.method_1().awF.ContainsKey(setting_0.method_8()))
		{
			Class256 @class = menuNode_0.method_1().awF[setting_0.method_8()];
			if (@class != null && !string.IsNullOrEmpty(@class.method_85()))
			{
				string text = Class286.smethod_12(@class.method_85(), Class333.smethod_562());
				foreach (ColumnHeader column in class85_0.Columns)
				{
					if (column.Text == text)
					{
						return class85_0.Columns.IndexOf(column);
					}
				}
			}
		}
		return 0;
	}

	private void class85_0_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		method_20(bool_4: true, e.Column);
	}

	private void method_20(bool bool_4, int int_1)
	{
		if (bool_4)
		{
			if (int_1 != int_0)
			{
				bool_0 = false;
			}
			else
			{
				bool_0 = !bool_0;
			}
		}
		class85_0.ListViewItemSorter = new Class133(int_1, bool_0);
		int_0 = int_1;
		class85_0.Refresh();
	}

	private void class85_0_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
	{
		e.DrawBackground();
		TextFormatFlags textFormatFlags = TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter;
		switch (e.Header.TextAlign)
		{
		case HorizontalAlignment.Left:
			textFormatFlags |= TextFormatFlags.Default;
			break;
		case HorizontalAlignment.Right:
			textFormatFlags |= TextFormatFlags.Right;
			break;
		case HorizontalAlignment.Center:
			textFormatFlags |= TextFormatFlags.HorizontalCenter;
			break;
		}
		TextRenderer.DrawText(e.Graphics, e.Header.Text, class85_0.Font, e.Bounds, Color.Black, textFormatFlags);
		if (e.ColumnIndex != int_0)
		{
			return;
		}
		e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		int num = (e.Bounds.Left + e.Bounds.Right) / 2;
		int x = num - 5;
		int num2 = num + 5;
		int num3 = e.Bounds.Top + 1;
		int num4 = e.Bounds.Top + 6;
		using Pen pen = new Pen(Brushes.Black, 2f);
		if (bool_0)
		{
			e.Graphics.DrawLine(pen, num, num4, x, num3);
			e.Graphics.DrawLine(pen, num - 1, num4, num2 - 1, num3);
		}
		else
		{
			e.Graphics.DrawLine(pen, num, num3, x, num4);
			e.Graphics.DrawLine(pen, num - 1, num3, num2 - 1, num4);
		}
	}

	private void class85_0_DrawItem(object sender, DrawListViewItemEventArgs e)
	{
		Class132 @class = e.Item as Class132;
		if (@class.BMh)
		{
			e.DrawDefault = false;
			e.DrawBackground();
			e.DrawFocusRectangle();
			using SolidBrush brush = new SolidBrush(class85_0.ForeColor);
			e.Graphics.FillRectangle(brush, @class.Bounds.Left, @class.Bounds.Top + 7, class85_0.Width - 20, 3);
			return;
		}
		if (@class.BMI)
		{
			e.DrawDefault = false;
			e.DrawBackground();
			e.DrawFocusRectangle();
			using SolidBrush brush2 = new SolidBrush(class85_0.ForeColor);
			e.Graphics.DrawString(Class333.smethod_589(), class85_0.Font, brush2, @class.Bounds.Left + 3, @class.Bounds.Top);
			return;
		}
		e.DrawDefault = true;
	}

	private void class85_0_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
	{
		Class132 @class = e.Item as Class132;
		if (!@class.BMh && !@class.BMI)
		{
			e.DrawDefault = true;
		}
		else
		{
			e.DrawDefault = false;
		}
	}

	private void class148_0_CheckedChanged(object sender, EventArgs e)
	{
		string string_ = string_0;
		bool_3 = true;
		method_3();
		method_8(string_);
		bool_3 = false;
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		themedTextBox_0.Text = string.Empty;
	}

	private void themedTextBox_0_TextChanged(object sender, EventArgs e)
	{
		timer_0.Stop();
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		bool flag = themedTextBox_0.Text == string.Empty;
		method_3();
		if (flag)
		{
			themedTextBox_0.Focus();
		}
	}

	internal void method_21()
	{
		themedTextBox_0.Focus();
	}

	private void Control6_Resize(object sender, EventArgs e)
	{
		int num = Size.Width - 6;
		label_0.Left = num - label_0.Width;
		themedButton_1.Left = num - themedButton_1.Width;
		label_1.Left = num - label_1.Width;
		class134_0.Left = num - class134_0.Width;
		pictureBox_1.Left = num - pictureBox_1.Width;
		class85_0.Width = label_0.Left - 6 - class85_0.Left;
		class85_0.Height = Size.Height - class85_0.Top - 4;
		class85_0.method_1();
		method_4();
		method_18();
	}

	[SpecialName]
	internal void method_22(bool bool_4)
	{
		bool_1 = bool_4;
		Control6_Resize(null, null);
	}

	internal void method_23()
	{
		bool flag = string_0 == Class333.smethod_563();
		menuNode_0.method_1().method_48(menuNode_0.method_1().aWS);
		menuNode_0.method_1().method_55();
		menuNode_0.method_0().method_1();
		if (flag)
		{
			if (setting_0 != null)
			{
				if (Form48.smethod_2() && menuNode_0.method_1().awF.ContainsKey(setting_0.method_8()))
				{
					Class256 @class = menuNode_0.method_1().awF[setting_0.method_8()];
					System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
					foreach (Setting item in @class.method_88(menuNode_0, bool_0: true))
					{
						if (!item.method_219() && (item.method_246(bool_0: true) || item.method_134().Count != 0))
						{
							Form23.smethod_75(item.method_69());
						}
					}
				}
				setting_0.method_279(bool_0: true);
				menuNode_0.method_81();
				menuNode_0.method_95(bool_0: false);
				menuNode_0.method_85(bool_0: false);
				Form23.smethod_74(setting_0.method_64());
			}
		}
		else
		{
			Class286 class2 = null;
			lock (Form23.object_0)
			{
				if (Form23.dictionary_1.ContainsKey(string_0))
				{
					class2 = Form23.dictionary_1[string_0].BcF;
				}
			}
			if (class2 != null && setting_0 != null)
			{
				System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
				if (menuNode_0.method_1().awv.Count != 0)
				{
					Class288.smethod_0(new Class287
					{
						BcF = class2,
						Bcf = Form23.dictionary_1[string_0].Bcf
					}, menuNode_0.method_1());
				}
				byte[] byte_ = Class24.smethod_1(string_0);
				setting_0.method_275(byte_, bool_0: true);
				class2.method_5(menuNode_0);
				Form23.smethod_74(setting_0.method_64());
				System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
			}
		}
		menuNode_0.method_1().method_54(bool_0: true);
		menuNode_0.method_1().method_49(menuNode_0.method_1().aWS);
		menuNode_0.method_0().method_4();
	}

	protected override void Dispose(bool disposing)
	{
		if (setting_0 != null)
		{
			setting_0.method_265(method_5);
			setting_0.method_41(method_6);
		}
		Form23.smethod_90(method_2);
		timer_0.Tick -= timer_0_Tick;
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_24()
	{
		themedTextBox_0 = new ThemedTextBox();
		pictureBox_0 = new PictureBox();
		themedButton_0 = new ThemedButton();
		class85_0 = new Class85();
		label_0 = new Label();
		class134_0 = new Class134();
		label_1 = new Label();
		class148_0 = new Class148();
		themedButton_1 = new ThemedButton();
		pictureBox_1 = new PictureBox();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)pictureBox_1).BeginInit();
		SuspendLayout();
		themedTextBox_0.Location = new Point(29, 5);
		themedTextBox_0.Name = Class333.smethod_590();
		themedTextBox_0.Size = new Size(300, 22);
		themedTextBox_0.TabIndex = 0;
		themedTextBox_0.TextChanged += themedTextBox_0_TextChanged;
		pictureBox_0.Location = new Point(4, 4);
		pictureBox_0.Name = Class333.smethod_591();
		pictureBox_0.Size = new Size(24, 24);
		pictureBox_0.TabIndex = 3;
		pictureBox_0.TabStop = false;
		themedButton_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		themedButton_0.Location = new Point(332, 3);
		themedButton_0.Name = Class333.smethod_592();
		themedButton_0.Size = new Size(24, 25);
		themedButton_0.TabIndex = 1;
		themedButton_0.Text = Class333.smethod_330();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		class148_0.AutoSize = true;
		class148_0.Font = new Font(Class333.smethod_145(), 9.5f);
		class148_0.Location = new Point(530, 5);
		class148_0.Name = Class333.smethod_593();
		class148_0.Size = new Size(136, 21);
		class148_0.TabIndex = 2;
		class148_0.Text = Class333.smethod_594();
		class148_0.UseVisualStyleBackColor = true;
		class148_0.CheckedChanged += class148_0_CheckedChanged;
		class85_0.BorderStyle = BorderStyle.FixedSingle;
		class85_0.FullRowSelect = true;
		class85_0.HideSelection = false;
		class85_0.Location = new Point(4, 31);
		class85_0.MultiSelect = false;
		class85_0.Name = Class333.smethod_595();
		class85_0.OwnerDraw = true;
		class85_0.ShowItemToolTips = true;
		class85_0.Size = new Size(878, 586);
		class85_0.TabIndex = 3;
		class85_0.UseCompatibleStateImageBehavior = false;
		class85_0.View = View.Details;
		class85_0.ColumnClick += class85_0_ColumnClick;
		class85_0.DrawColumnHeader += class85_0_DrawColumnHeader;
		class85_0.DrawItem += class85_0_DrawItem;
		class85_0.DrawSubItem += class85_0_DrawSubItem;
		class85_0.ItemSelectionChanged += class85_0_ItemSelectionChanged;
		class85_0.DoubleClick += class85_0_DoubleClick;
		label_0.Font = new Font(Class333.smethod_145(), 8f);
		label_0.Location = new Point(889, 7);
		label_0.Name = Class333.smethod_596();
		label_0.Size = new Size(290, 20);
		label_0.TabIndex = 5;
		label_0.Text = Class333.smethod_581();
		themedButton_1.Enabled = false;
		themedButton_1.Font = new Font(Class333.smethod_145(), 9.5f);
		themedButton_1.Location = new Point(889, 28);
		themedButton_1.Name = Class333.smethod_597();
		themedButton_1.Size = new Size(290, 28);
		themedButton_1.TabIndex = 4;
		themedButton_1.Text = Class333.smethod_598();
		themedButton_1.UseVisualStyleBackColor = true;
		themedButton_1.Click += themedButton_1_Click;
		label_1.Font = new Font(Class333.smethod_145(), 8f);
		label_1.Location = new Point(889, 62);
		label_1.Name = Class333.smethod_599();
		label_1.Size = new Size(290, 20);
		label_1.TabIndex = 6;
		label_1.Text = Class333.smethod_582();
		class134_0.BorderStyle = BorderStyle.None;
		class134_0.ReadOnly = true;
		class134_0.Font = new Font(Class333.smethod_145(), 8f);
		class134_0.Location = new Point(889, 87);
		class134_0.Name = Class333.smethod_600();
		class134_0.Size = new Size(290, 100);
		class134_0.TabIndex = 7;
		class134_0.Text = Class333.smethod_583();
		class134_0.ScrollBars = RichTextBoxScrollBars.Vertical;
		pictureBox_1.Location = new Point(889, 196);
		pictureBox_1.Name = Class333.smethod_601();
		pictureBox_1.Size = new Size(290, 370);
		pictureBox_1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox_1.TabIndex = 8;
		pictureBox_1.TabStop = false;
		pictureBox_1.Visible = false;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(pictureBox_1);
		Controls.Add(themedButton_1);
		Controls.Add(class148_0);
		Controls.Add(label_1);
		Controls.Add(class134_0);
		Controls.Add(label_0);
		Controls.Add(class85_0);
		Controls.Add(themedButton_0);
		Controls.Add(pictureBox_0);
		Controls.Add(themedTextBox_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Name = Class333.smethod_602();
		Size = new Size(1184, 621);
		Resize += Control6_Resize;
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)pictureBox_1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
