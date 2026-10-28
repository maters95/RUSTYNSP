using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns1;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;

namespace ns4;

internal class Form16 : Form
{
	private List<Class318> list_0;

	private List<Class318> list_1;

	private Class5 class5_0;

	private Class14 class14_0;

	private Class14 class14_1;

	private Class14 class14_2;

	private Framework framework_0;

	private byte[] byte_0;

	private Dictionary<Enum88, string> dictionary_0 = new Dictionary<Enum88, string>();

	private string string_0;

	private string string_1;

	private Enum88 enum88_0;

	private bool bool_0;

	private Dictionary<Enum88, Class14> dictionary_1 = new Dictionary<Enum88, Class14>();

	private Dictionary<Enum88, Class14> dictionary_2 = new Dictionary<Enum88, Class14>();

	private Dictionary<Enum88, bool> dictionary_3 = new Dictionary<Enum88, bool>();

	private List<Class148> list_2 = new List<Class148>();

	private int int_0;

	private int int_1;

	private IContainer icontainer_0;

	private TreeViewWithThemedScrollBars treeViewWithThemedScrollBars_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private ThemedButton themedButton_2;

	private ProgressBar progressBar_0;

	private ThemedComboBox themedComboBox_0;

	private Control24 control24_0;

	private Label label_4;

	internal Form16(List<Class318> list_3, List<Class318> list_4, Class5 class5_1, Class14 class14_3, Class14 class14_4, string string_2)
	{
		method_19();
		method_0();
		list_0 = list_3;
		list_1 = list_4;
		class5_0 = class5_1;
		class14_0 = class14_3;
		class14_1 = class14_4;
		string_1 = string_2;
		if (Class320.smethod_48(class5_0))
		{
			label_1.Text = Class333.smethod_1104();
		}
		else
		{
			label_1.Text = Class333.smethod_1105() + class14_0;
		}
		treeViewWithThemedScrollBars_0.method_43(method_14);
		int_0 = treeViewWithThemedScrollBars_0.Bottom;
		int_1 = treeViewWithThemedScrollBars_0.Height;
		method_6();
		foreach (MenuNode item in Form23.list_4)
		{
			Class235 @class = item.method_2();
			if (Class320.smethod_4(@class.method_0()))
			{
				method_2(@class);
			}
		}
		label_4.Visible = class5_0.byte_4 != 21;
	}

	internal Form16(List<Class318> list_3, Class5 class5_1, Enum88 enum88_1, Class14 class14_3, bool bool_1)
	{
		method_19();
		method_0();
		list_0 = list_3;
		enum88_0 = enum88_1;
		bool_0 = bool_1;
		dictionary_1.Add(enum88_1, class14_3);
		dictionary_3.Add(enum88_1, bool_1);
		class5_0 = class5_1;
		class14_0 = class14_3;
		label_1.Text = Class333.smethod_1105() + class14_0;
		treeViewWithThemedScrollBars_0.method_43(method_14);
		method_6();
		label_4.Visible = class5_0.byte_4 != 21;
	}

	private void Form16_Shown(object sender, EventArgs e)
	{
		if (enum88_0 == Enum88.avK && class5_0.byte_4 != 22)
		{
			method_4();
		}
		method_1();
		Form23.smethod_7(method_13);
	}

	private void method_0()
	{
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				(control as Label).ForeColor = Form23.color_12;
			}
		}
		treeViewWithThemedScrollBars_0.BackColor = Form23.color_16;
		treeViewWithThemedScrollBars_0.ForeColor = Form23.color_12;
		control24_0.BackColor = Form23.color_17;
		control24_0.ForeColor = Form23.color_12;
	}

	private void method_1()
	{
		while (control24_0.TabCount != 0)
		{
			Class30.smethod_0(control24_0.TabPages[0]);
		}
		control24_0.Top = treeViewWithThemedScrollBars_0.Top;
		control24_0.Height = treeViewWithThemedScrollBars_0.Height;
		string text = ((enum88_0 != Enum88.avK) ? (Class235.smethod_2(enum88_0) + Class333.smethod_1106()) : (Class242.smethod_9(class5_0.byte_4, class5_0.byte_5) + Class333.smethod_1106()));
		TabPage tabPage = new TabPage(text);
		tabPage.BorderStyle = BorderStyle.None;
		tabPage.BackColor = Form23.color_17;
		Class134 @class = new Class134();
		@class.BorderStyle = BorderStyle.None;
		@class.BackColor = Form23.color_17;
		@class.ForeColor = Form23.color_12;
		tabPage.Controls.Add(@class);
		control24_0.TabPages.Add(tabPage);
		@class.Width = tabPage.Width;
		@class.Height = tabPage.Height;
		@class.method_0();
		@class.Invalidate();
		tabPage.Invalidate();
		if (enum88_0 == Enum88.avK)
		{
			foreach (Class148 item in list_2)
			{
				if (item.Visible)
				{
					Class235 class2 = (Class235)(item.Tag as List<object>)[0];
					TabPage tabPage2 = new TabPage(class2.method_16() + Class333.smethod_1106());
					tabPage2.Tag = class2;
					tabPage2.BorderStyle = BorderStyle.None;
					tabPage2.BackColor = Form23.color_17;
					Class134 class3 = new Class134();
					class3.BorderStyle = BorderStyle.None;
					class3.BackColor = Form23.color_17;
					class3.ForeColor = Form23.color_12;
					tabPage2.Controls.Add(class3);
					control24_0.TabPages.Add(tabPage2);
					class3.Width = tabPage2.Width;
					class3.Height = tabPage2.Height;
					class3.method_0();
					class3.Invalidate();
					tabPage2.Invalidate();
				}
			}
		}
		control24_0.SelectedIndex = 0;
		control24_0.Invalidate();
	}

	private void method_2(Class235 class235_0)
	{
		Class148 @class = new Class148();
		@class.BackColor = BackColor;
		@class.ForeColor = Form23.color_12;
		@class.Tag = new List<object> { class235_0, null };
		@class.AutoSize = false;
		@class.Width = Width - 50;
		@class.Height = (int)((float)@class.Height * 0.75f);
		@class.Left = label_2.Left;
		@class.Visible = false;
		@class.CheckedChanged += method_3;
		list_2.Add(@class);
		Controls.Add(@class);
	}

	private void method_3(object sender, EventArgs e)
	{
		Class148 obj = sender as Class148;
		Class235 @class = (Class235)(obj.Tag as List<object>)[0];
		Class14 value = @class.method_1();
		Class14 value2 = (Class14)(obj.Tag as List<object>)[1];
		if (obj.Checked)
		{
			if (!dictionary_1.ContainsKey(@class.method_0()))
			{
				dictionary_1.Add(@class.method_0(), value);
			}
			if (!dictionary_3.ContainsKey(@class.method_0()))
			{
				dictionary_3.Add(@class.method_0(), @class.method_11());
			}
			dictionary_2[@class.method_0()] = value2;
			return;
		}
		if (dictionary_1.ContainsKey(@class.method_0()))
		{
			dictionary_1.Remove(@class.method_0());
		}
		if (dictionary_3.ContainsKey(@class.method_0()))
		{
			dictionary_3.Remove(@class.method_0());
		}
		if (dictionary_2.ContainsKey(@class.method_0()))
		{
			dictionary_2.Remove(@class.method_0());
		}
	}

	private void method_4()
	{
		if (enum88_0 != Enum88.avK || class5_0.byte_4 == 22)
		{
			return;
		}
		dictionary_1.Clear();
		dictionary_3.Clear();
		dictionary_2.Clear();
		if (Class320.smethod_48(class5_0))
		{
			foreach (Class148 item in list_2)
			{
				item.Checked = false;
				item.Visible = false;
			}
		}
		else if (themedComboBox_0.Items.Count != 0 && themedComboBox_0.SelectedIndex >= 0 && string_0 != null)
		{
			List<Class315> list = Class320.smethod_7(string_0);
			foreach (MenuNode item2 in Form23.list_4)
			{
				Class235 @class = item2.method_2();
				Class148 class2 = null;
				foreach (Class148 item3 in list_2)
				{
					if (((Class235)(item3.Tag as List<object>)[0]).method_0() == @class.method_0())
					{
						class2 = item3;
						break;
					}
				}
				if ((!Class320.smethod_3(class5_0.byte_4, class5_0.byte_5, class14_2) || !Class320.smethod_4(@class.method_0())) && @class.method_0() != Enum88.avU && @class.method_0() != Enum88.avu && @class.method_0() != Enum88.avV && @class.method_0() != Enum88.avv)
				{
					if (class2 != null)
					{
						class2.Checked = false;
						class2.Visible = false;
					}
					continue;
				}
				bool flag = false;
				foreach (Class315 item4 in list)
				{
					Class14 bdB = item4.BdB;
					if (item4.Bda != @class.method_0() || !Class320.smethod_5(@class.method_0(), @class.method_1(), bdB, @class.method_11()))
					{
						continue;
					}
					flag = true;
					if (class2 == null)
					{
						break;
					}
					if (@class.method_8() && @class.method_9())
					{
						if (@class.method_1() != bdB)
						{
							class2.Text = Class333.smethod_1107() + @class.method_16() + Class333.smethod_1108() + @class.method_1()?.ToString() + Class333.smethod_1109() + bdB?.ToString() + Class333.smethod_9();
							(class2.Tag as List<object>)[1] = bdB;
							class2.Visible = true;
							class2.Checked = true;
						}
						else
						{
							class2.Checked = false;
							class2.Visible = false;
						}
					}
					else
					{
						class2.Checked = false;
						class2.Visible = false;
					}
					break;
				}
				if (!flag && (@class.method_0() == Enum88.avU || @class.method_0() == Enum88.avu || @class.method_0() == Enum88.avV || @class.method_0() == Enum88.avv) && list_1 != null && list_1.Count != 0)
				{
					flag = true;
					if (class2 != null)
					{
						if (@class.method_9())
						{
							Class14 axT = list_1[0].BdF[0].BdC.axT;
							if (@class.method_1() != axT)
							{
								Class14 class3 = Class320.smethod_6(bool_0: true);
								Class14 class4 = Class320.smethod_6(bool_0: false);
								bool flag2 = false;
								if (@class.method_11())
								{
									if (@class.method_1() >= class3 && axT < class4)
									{
										flag2 = true;
									}
								}
								else if (@class.method_1() >= class4 && axT < class4)
								{
									flag2 = true;
								}
								if (flag2)
								{
									class2.Checked = false;
									class2.Visible = false;
								}
								else
								{
									class2.Text = Class333.smethod_1107() + @class.method_16() + Class333.smethod_1108() + @class.method_1()?.ToString() + Class333.smethod_1109() + axT?.ToString() + Class333.smethod_9();
									(class2.Tag as List<object>)[1] = axT;
									class2.Visible = true;
									class2.Checked = true;
								}
							}
							else
							{
								class2.Checked = false;
								class2.Visible = false;
							}
						}
						else
						{
							class2.Checked = false;
							class2.Visible = false;
						}
					}
				}
				if (!flag && class2 != null)
				{
					class2.Checked = false;
					class2.Visible = false;
				}
			}
		}
		else
		{
			foreach (Class148 item5 in list_2)
			{
				item5.Checked = false;
				item5.Visible = false;
			}
		}
		int num = 0;
		foreach (Class148 item6 in list_2)
		{
			if (item6.Visible)
			{
				num++;
			}
		}
		method_5(num);
	}

	private void method_5(int int_2)
	{
		if (int_2 == 0)
		{
			treeViewWithThemedScrollBars_0.Height = int_1;
		}
		else
		{
			int num = int_2 * list_2[0].Height;
			num -= themedButton_1.Height;
			if (num < 0)
			{
				num = 0;
			}
			treeViewWithThemedScrollBars_0.Height = int_1 - (10 + num);
			int num2 = 0;
			foreach (Class148 item in list_2)
			{
				if (item.Visible)
				{
					item.Top = treeViewWithThemedScrollBars_0.Top + treeViewWithThemedScrollBars_0.Height + 10 + num2 * item.Height;
					num2++;
				}
			}
		}
		treeViewWithThemedScrollBars_0.Invalidate();
		treeViewWithThemedScrollBars_0.method_48();
	}

	private void method_6()
	{
		themedComboBox_0.Items.Clear();
		themedComboBox_0.SelectedIndex = -1;
		if (list_0.Count == 0)
		{
			return;
		}
		foreach (Class318 item in list_0)
		{
			if (enum88_0 == Enum88.avK)
			{
				Class14 @class = item.method_0(class5_0.byte_4, class5_0.byte_5);
				if (@class != null)
				{
					themedComboBox_0.Items.Add(@class.ToString());
				}
				else
				{
					themedComboBox_0.Items.Add(item.BdF[0].BdC.axT.ToString());
				}
			}
			else
			{
				Class317 class2 = Class320.smethod_41(item.Bdf, enum88_0, class14_0, bool_0);
				if (class2 != null)
				{
					themedComboBox_0.Items.Add(class2.Bdd.ToString());
				}
			}
		}
		Class14 class3 = null;
		if (enum88_0 == Enum88.avK)
		{
			Class14 class4 = list_0[0].method_0(class5_0.byte_4, class5_0.byte_5);
			class3 = ((!(class4 != null)) ? list_0[0].BdF[0].BdC.axT : class4);
		}
		else
		{
			Class317 class5 = Class320.smethod_41(list_0[0].Bdf, enum88_0, class14_0, bool_0);
			if (class5 != null)
			{
				class3 = class5.Bdd;
			}
		}
		if (class3 != null && class3 > class14_0)
		{
			themedComboBox_0.SelectedIndex = 0;
		}
	}

	private void themedComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (themedComboBox_0.Items.Count == 0 || themedComboBox_0.SelectedIndex < 0)
		{
			return;
		}
		Class318 @class = list_0[themedComboBox_0.SelectedIndex];
		string_0 = @class.BdE;
		List<Class314> list = null;
		if (enum88_0 == Enum88.avK)
		{
			list = Class320.smethod_8(string_0);
		}
		List<Class315> list2 = Class320.smethod_7(string_0);
		dictionary_0.Clear();
		if (enum88_0 == Enum88.avK)
		{
			int byte_ = class5_0.byte_4;
			int num = class5_0.byte_5;
			if (byte_ == 22 && num == 14)
			{
				num = 13;
			}
			else if (byte_ == 22 && num == 14)
			{
				num = 20;
			}
			class14_2 = @class.BdF[0].BdC.axT;
			dictionary_0.Add(Enum88.avK, list[0].BDz);
			byte_0 = null;
			for (int i = 0; i < @class.BdF.Count; i++)
			{
				Class316 class2 = @class.BdF[i];
				if (class2.BdC.axS == byte_ && class2.BdC.axs == num)
				{
					class14_2 = class2.BdC.axT;
					byte_0 = class2.BdC.axt;
					if (i < list.Count && !string.IsNullOrEmpty(list[i].BDz))
					{
						dictionary_0[Enum88.avK] = list[i].BDz;
					}
					break;
				}
			}
			foreach (MenuNode item in Form23.list_4)
			{
				Class235 class3 = item.method_2();
				bool flag = false;
				foreach (Class315 item2 in list2)
				{
					if (item2.Bda == class3.method_0() && Class320.smethod_5(class3.method_0(), class3.method_1(), item2.BdB, class3.method_11()))
					{
						dictionary_0.Add(class3.method_0(), item2.Bdb);
						flag = true;
						break;
					}
				}
				if (!flag && (class3.method_0() == Enum88.avU || class3.method_0() == Enum88.avu || class3.method_0() == Enum88.avV || class3.method_0() == Enum88.avv) && list_1 != null && list_1.Count != 0)
				{
					List<Class314> list3 = Class320.smethod_8(list_1[0].BdE);
					if (list3 != null && list3.Count != 0)
					{
						dictionary_0.Add(class3.method_0(), list3[0].BDz);
					}
				}
			}
		}
		else
		{
			foreach (Class315 item3 in list2)
			{
				if (item3.Bda == enum88_0 && Class320.smethod_5(enum88_0, class14_0, item3.BdB, bool_0))
				{
					class14_2 = item3.BdB;
					dictionary_0.Add(enum88_0, item3.Bdb);
					break;
				}
			}
		}
		themedButton_1.Enabled = true;
		method_9();
		if (enum88_0 == Enum88.avK && class5_0.byte_4 != 22)
		{
			method_4();
		}
		method_1();
	}

	private void themedButton_2_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = Class320.Bdl;
		openFileDialog.Title = Class333.smethod_1110();
		openFileDialog.Filter = Class333.smethod_1111();
		if (Directory.Exists(openFileDialog.InitialDirectory))
		{
			string[] files = Directory.GetFiles(openFileDialog.InitialDirectory);
			foreach (string text in files)
			{
				if (Path.GetFileName(text) == Class333.smethod_1112())
				{
					openFileDialog.FileName = text;
					break;
				}
			}
		}
		if (openFileDialog.ShowDialog(this) == DialogResult.OK)
		{
			string fileName = openFileDialog.FileName;
			openFileDialog.Dispose();
			List<Class314> list = Class320.smethod_8(fileName);
			List<Class315> list2 = Class320.smethod_7(fileName);
			Class318 @class = Class320.smethod_40(fileName, list, list2);
			if (@class.BdF.Count == 0 && @class.Bdf.Count == 0)
			{
				Form54.smethod_6(this, Class333.smethod_1113(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			Class316 class2 = null;
			if (@class.BdF.Count == 0 && enum88_0 != Enum88.avK && @class.Bdf.Count != 0)
			{
				if (Class320.smethod_41(@class.Bdf, enum88_0, class14_0, bool_0) != null)
				{
					flag4 = true;
				}
				flag = true;
				flag2 = true;
				flag3 = true;
			}
			else
			{
				foreach (Class316 item in @class.BdF)
				{
					bool flag5 = false;
					flag5 = item.BdC != null && (item.BdC.axs == class5_0.byte_5 || item.BdC.axS == 22);
					if (!((item.BdC != null && item.BdC.axS == class5_0.byte_4) & flag5))
					{
						continue;
					}
					flag = true;
					if (class14_1 == null || item.BdC.axT >= class14_1)
					{
						flag2 = true;
						if (Class320.smethod_43(class5_0.string_0) || item.Bdc.Contains(class5_0.ushort_0))
						{
							flag3 = true;
							class2 = item;
							break;
						}
					}
				}
				if (enum88_0 != Enum88.avK && (flag & flag2 & flag3) && Class320.smethod_41(@class.Bdf, enum88_0, class14_0, bool_0) != null)
				{
					flag4 = true;
				}
			}
			if (!flag)
			{
				Form54.smethod_6(this, Class333.smethod_1114(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (flag2 && flag3)
			{
				string text2;
				bool flag6;
				if (enum88_0 != Enum88.avK && !flag4)
				{
					Form54.smethod_6(this, Class333.smethod_1116(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (class2 != null && Class305.smethod_4(class2, out text2, out flag6))
				{
					string text3 = (string.IsNullOrEmpty(text2) ? Class333.smethod_1118() : (Class333.smethod_1117() + text2 + Class333.smethod_570()));
					Form54.smethod_6(this, Class333.smethod_1119() + text3, Class333.smethod_1120(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (class2 != null && !Form59.smethod_2() && !class2.BdC.axT.method_7())
				{
					string text4 = class2.BdC.axT.method_6();
					if (Form54.smethod_6(this, Class333.smethod_1121() + text4 + Class333.smethod_1122(), Class333.smethod_1123(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
					{
						Form59 form = new Form59();
						form.ShowDialog(this);
						form.Dispose();
						if (Form59.smethod_2())
						{
							method_7(fileName, @class);
						}
					}
				}
				else
				{
					method_7(fileName, @class);
				}
			}
			else
			{
				Form54.smethod_6(this, Class333.smethod_1115(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		else
		{
			openFileDialog.Dispose();
		}
	}

	private void method_7(string string_2, Class318 class318_0)
	{
		if (list_0.Count == themedComboBox_0.Items.Count)
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				if (enum88_0 == Enum88.avK)
				{
					if (list_0[i].BdF[0].BdC.axT == class318_0.BdF[0].BdC.axT)
					{
						themedComboBox_0.SelectedIndex = i;
						string_0 = string_2;
						Class320.smethod_15(string_2);
						return;
					}
					continue;
				}
				Class317 @class = Class320.smethod_41(list_0[i].Bdf, enum88_0, class14_0, bool_0);
				Class317 class2 = Class320.smethod_41(class318_0.Bdf, enum88_0, class14_0, bool_0);
				if (@class != null && class2 != null && @class.Bdd == class2.Bdd)
				{
					themedComboBox_0.SelectedIndex = i;
					string_0 = string_2;
					Class320.smethod_15(string_2);
					return;
				}
			}
		}
		method_8(string_2, class318_0);
	}

	private void method_8(string string_2, Class318 class318_0)
	{
		themedComboBox_0.SelectedIndex = -1;
		if (list_0.Count != themedComboBox_0.Items.Count)
		{
			return;
		}
		Class14 @class = null;
		if (enum88_0 == Enum88.avK)
		{
			Class14 class2 = class318_0.method_0(class5_0.byte_4, class5_0.byte_5);
			@class = ((!(class2 != null)) ? class318_0.BdF[0].BdC.axT : class2);
		}
		else
		{
			Class317 class3 = Class320.smethod_41(class318_0.Bdf, enum88_0, class14_0, bool_0);
			if (class3 != null)
			{
				@class = class3.Bdd;
			}
		}
		if (!(@class != null))
		{
			return;
		}
		if (list_0.Count == 0)
		{
			list_0.Add(class318_0);
			themedComboBox_0.Items.Add(@class.ToString());
			themedComboBox_0.SelectedIndex = 0;
			string_0 = string_2;
			return;
		}
		int num = 0;
		while (true)
		{
			if (num >= list_0.Count)
			{
				return;
			}
			Class14 class4 = null;
			if (enum88_0 == Enum88.avK)
			{
				Class14 class5 = list_0[num].method_0(class5_0.byte_4, class5_0.byte_5);
				class4 = ((!(class5 != null)) ? list_0[num].BdF[0].BdC.axT : class5);
			}
			else
			{
				Class317 class6 = Class320.smethod_41(list_0[num].Bdf, enum88_0, class14_0, bool_0);
				if (class6 != null)
				{
					class4 = class6.Bdd;
				}
			}
			if (class4 != null)
			{
				if (@class > class4)
				{
					list_0.Insert(num, class318_0);
					themedComboBox_0.Items.Insert(num, @class.ToString());
					themedComboBox_0.SelectedIndex = num;
					string_0 = string_2;
					return;
				}
				if (num == list_0.Count - 1)
				{
					break;
				}
			}
			num++;
		}
		list_0.Add(class318_0);
		themedComboBox_0.Items.Add(@class.ToString());
		themedComboBox_0.SelectedIndex = themedComboBox_0.Items.Count - 1;
		string_0 = string_2;
	}

	private void method_9()
	{
		progressBar_0.Value = 0;
		progressBar_0.Visible = true;
		progressBar_0.BringToFront();
		treeViewWithThemedScrollBars_0.method_2().Clear();
		treeViewWithThemedScrollBars_0.Invalidate();
		treeViewWithThemedScrollBars_0.method_48();
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.ProgressChanged += method_11;
		backgroundWorker.DoWork += method_10;
		backgroundWorker.RunWorkerCompleted += method_12;
		backgroundWorker.RunWorkerAsync();
	}

	private void method_10(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		backgroundWorker.ReportProgress(0);
		if (class14_2 != null && byte_0 != null && enum88_0 == Enum88.avK && !Class320.smethod_48(class5_0))
		{
			if (class5_0.byte_4 == 22)
			{
				e.Result = null;
			}
			else
			{
				string value = Class234.smethod_8(class5_0.byte_4, class5_0.byte_5, class14_2, byte_0, bool_0: true);
				backgroundWorker.ReportProgress(30);
				if (!string.IsNullOrEmpty(value))
				{
					Framework framework = new Framework(value, class5_0.byte_4, class5_0.byte_5, class14_2);
					backgroundWorker.ReportProgress(50);
					if (framework.method_1() == Class237.Enum91.Brc)
					{
						e.Result = framework;
					}
					else
					{
						e.Result = null;
					}
					backgroundWorker.ReportProgress(90);
					Thread.Sleep(100);
				}
				else
				{
					e.Result = null;
				}
			}
		}
		else
		{
			backgroundWorker.ReportProgress(50);
			Thread.Sleep(100);
			backgroundWorker.ReportProgress(100);
			Thread.Sleep(500);
			e.Result = null;
		}
		backgroundWorker.ReportProgress(100);
	}

	private void method_11(object sender, ProgressChangedEventArgs e)
	{
		progressBar_0.Value = e.ProgressPercentage;
	}

	private void method_12(object sender, RunWorkerCompletedEventArgs e)
	{
		try
		{
			progressBar_0.Visible = false;
		}
		catch
		{
		}
		if (e.Result != null)
		{
			framework_0 = (Framework)e.Result;
		}
		else
		{
			framework_0 = null;
		}
		if (e.Result == null && enum88_0 == Enum88.avK && class5_0.byte_4 != 22)
		{
			return;
		}
		try
		{
			method_18();
			if (framework_0 != null)
			{
				method_15();
			}
		}
		catch
		{
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}

	private void Form16_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult != DialogResult.OK)
		{
			Form23.smethod_8(method_13);
			foreach (Class148 item in list_2)
			{
				item.CheckedChanged -= method_3;
			}
			treeViewWithThemedScrollBars_0.method_44(method_14);
			framework_0 = null;
		}
		else if (!string.IsNullOrEmpty(string_0))
		{
			if (!(class14_1 == null) && framework_0 != null && !(framework_0.aXA >= class14_1))
			{
				Form54.smethod_6(this, Class333.smethod_1115(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Cancel = true;
				return;
			}
			if (dictionary_1.Count != 0 && Form23.framework_1 != null && Form23.framework_1.method_68())
			{
				Form54.smethod_6(this, Class333.smethod_1124(), Class333.smethod_1125(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Cancel = true;
				return;
			}
			if (enum88_0 == Enum88.avK)
			{
				List<Class314> list = Class320.smethod_8(string_0);
				if (list.Count != 0 && list[0].BDy != null)
				{
					Class316 @class = new Class316();
					@class.BdC = new Class240
					{
						axS = class5_0.byte_4,
						axs = class5_0.byte_5,
						axT = list[0].BDy.axT
					};
					@class.Bdc = new List<ushort>();
					@class.Bdc.Add(class5_0.ushort_0);
					if (Class305.smethod_4(@class, out var text, out var _))
					{
						string text2 = (string.IsNullOrEmpty(text) ? Class333.smethod_1118() : (Class333.smethod_1117() + text + Class333.smethod_570()));
						if (Form54.smethod_9(this, Class333.smethod_1119() + text2, Class333.smethod_1120(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, new string[2]
						{
							Class333.smethod_1126(),
							Class333.smethod_823()
						}) == DialogResult.Cancel)
						{
							e.Cancel = true;
							return;
						}
					}
					if (!@class.BdC.axT.method_7())
					{
						string text3 = @class.BdC.axT.method_6();
						if (Form54.smethod_9(this, Class333.smethod_1127() + text3 + Class333.smethod_190(), Class333.smethod_1121() + text3, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, new string[2]
						{
							Class333.smethod_1126(),
							Class333.smethod_823()
						}) == DialogResult.Cancel)
						{
							e.Cancel = true;
							return;
						}
					}
				}
			}
			bool flag2 = framework_0 != null && Form23.framework_1 != null && framework_0.aXA < Form23.framework_1.aXA;
			bool bool_ = false;
			bool bool_2 = false;
			bool bool_3 = false;
			if (enum88_0 == Enum88.avK)
			{
				bool flag3 = Class320.smethod_48(class5_0);
				if (class14_0 != null && class14_2 != null && class5_0.byte_4 == 22)
				{
					Class14 class2 = Class320.smethod_6(bool_0: true);
					Class14 class3 = Class320.smethod_6(bool_0: false);
					if ((flag3 && class14_0 < class2 && class14_2 >= class3) || (!flag3 && class14_0 < class3 && class14_2 >= class3))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
						defaultInterpolatedStringHandler.AppendFormatted(class3.method_0());
						defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_190());
						defaultInterpolatedStringHandler.AppendFormatted(class3.method_1());
						defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_190());
						defaultInterpolatedStringHandler.AppendFormatted(class3.method_2());
						string text4 = defaultInterpolatedStringHandler.ToStringAndClear();
						if (Form54.smethod_6(this, Class333.smethod_1128() + text4 + Class333.smethod_1129(), Class333.smethod_1130(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
						{
							e.Cancel = true;
							return;
						}
					}
				}
				bool_ = flag3;
				Class14 class14_ = ((framework_0 != null) ? framework_0.aXA : null);
				bool_2 = Form23.smethod_64(class5_0, class14_0, class14_, out bool_3);
				if (bool_3)
				{
					e.Cancel = true;
					return;
				}
				Class326.smethod_0(this, class5_0, class14_0, class14_2, out bool_3);
				if (bool_3)
				{
					e.Cancel = true;
					return;
				}
			}
			Form23.smethod_8(method_13);
			foreach (Class148 item2 in list_2)
			{
				item2.CheckedChanged -= method_3;
			}
			treeViewWithThemedScrollBars_0.method_44(method_14);
			framework_0 = null;
			Class320.smethod_17(class5_0, string_0, flag2, bool_1: false, bool_, string_1, bool_2, bool_4: false, enum88_0, (enum88_0 != Enum88.avK) ? class14_0 : null, (enum88_0 != Enum88.avK) ? class14_2 : null, enum88_0 != Enum88.avK && bool_0, dictionary_1, dictionary_2, dictionary_3, bool_6: true, null);
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_1131(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			e.Cancel = true;
		}
	}

	private void method_14(object sender, DrawTreeNodeEventArgs e)
	{
		if (e.Bounds.Y >= -10 && e.Bounds.Y <= treeViewWithThemedScrollBars_0.Height)
		{
			Font font = treeViewWithThemedScrollBars_0.Font;
			using (SolidBrush brush = new SolidBrush(treeViewWithThemedScrollBars_0.BackColor))
			{
				e.Graphics.FillRectangle(brush, e.Bounds.Right, e.Bounds.Top, treeViewWithThemedScrollBars_0.Width - e.Bounds.Right - 1, e.Bounds.Height);
			}
			Rectangle bounds = new Rectangle(450, e.Bounds.Top, treeViewWithThemedScrollBars_0.Width - 450 - 1, e.Bounds.Height);
			if (e.Node.Tag != null && e.Node.Tag is string)
			{
				TextRenderer.DrawText(e.Graphics, e.Node.Tag as string, font, bounds, e.Node.ForeColor, TextFormatFlags.NoPrefix);
			}
		}
	}

	private void method_15()
	{
		treeViewWithThemedScrollBars_0.method_2().Clear();
		treeViewWithThemedScrollBars_0.Invalidate();
		if (Form23.framework_1 == null || framework_0 == null)
		{
			return;
		}
		treeViewWithThemedScrollBars_0.method_5();
		if (framework_0.aXA > Form23.framework_1.aXA)
		{
			new List<int>();
			foreach (MenuNode item in framework_0.awj)
			{
				method_16(item, null);
			}
		}
		else if (framework_0.aXA < Form23.framework_1.aXA)
		{
			TreeNode treeNode = new TreeNode(Class333.smethod_1132());
			treeNode.ForeColor = Form23.color_12;
			treeViewWithThemedScrollBars_0.method_2().Add(treeNode);
		}
		else
		{
			TreeNode treeNode2 = new TreeNode(Class333.smethod_1133());
			treeNode2.ForeColor = Form23.color_12;
			treeViewWithThemedScrollBars_0.method_2().Add(treeNode2);
		}
		treeViewWithThemedScrollBars_0.method_6();
		treeViewWithThemedScrollBars_0.method_48();
	}

	private void method_16(MenuNode menuNode_0, TreeNode treeNode_0)
	{
		string text = menuNode_0.method_10();
		int num = menuNode_0.method_3();
		int num2 = menuNode_0.method_20();
		TreeNode treeNode = new TreeNode(text);
		if (treeNode_0 != null && treeNode_0.ForeColor == Color.Gray)
		{
			treeNode.ForeColor = Color.Gray;
		}
		else
		{
			treeNode.ForeColor = Form23.color_12;
		}
		SettingOrSpecialObject settingOrSpecialObject = framework_0.method_33(num);
		SettingOrSpecialObject settingOrSpecialObject2 = framework_0.method_33(num2);
		if (menuNode_0.method_98(out var setting_))
		{
			if (setting_.method_219())
			{
				return;
			}
			treeNode.ForeColor = Color.Gray;
		}
		else if (settingOrSpecialObject != null)
		{
			if (settingOrSpecialObject.method_24().Count != 0 || settingOrSpecialObject.method_26().method_4().Count != 0)
			{
				return;
			}
		}
		else if (treeNode.ForeColor != Color.Gray && settingOrSpecialObject2 != null)
		{
			int num3 = 0;
			foreach (SettingOrSpecialObject item in settingOrSpecialObject2.method_1())
			{
				if ((item is Setting && item.method_2().EndsWith(Class333.smethod_532())) || item.method_2().EndsWith(Class333.smethod_533()) || item.method_2().EndsWith(Class333.smethod_534()))
				{
					num3 = (item as Setting).method_64();
					break;
				}
			}
			if (num3 != 0)
			{
				Setting setting = Form23.framework_1.method_31(num3);
				if (setting != null)
				{
					bool flag;
					if (flag = setting.method_256() != 1)
					{
						if (setting.method_219())
						{
							return;
						}
					}
					else
					{
						HashSet<DataIdAndAttrId> hashSet = menuNode_0.method_104(bool_0: false);
						bool flag2 = true;
						foreach (DataIdAndAttrId item2 in hashSet)
						{
							Setting setting2 = Form23.framework_1.method_32(item2);
							if (setting2 != null && setting2 != setting && setting2.method_35() && !setting2.method_219() && !setting2.method_220() && !setting2.method_212())
							{
								flag2 = false;
								break;
							}
						}
						flag = flag2;
					}
					if (flag)
					{
						treeNode.ForeColor = Color.Gray;
					}
				}
			}
		}
		foreach (MenuNode item3 in menuNode_0.method_6())
		{
			method_16(item3, treeNode);
		}
		if (treeNode.GetNodeCount(includeSubTrees: true) == 0 && settingOrSpecialObject == null && settingOrSpecialObject2 == null && menuNode_0.method_22() == 0)
		{
			return;
		}
		if (menuNode_0.method_5() != null && menuNode_0.method_5().method_22() == 0 && settingOrSpecialObject is SpecialObject && (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents.Count != 0)
		{
			bool flag3 = true;
			foreach (UIListSettingDataIdAndIndent currentUIListSettingsIdsAndIndent in (settingOrSpecialObject as SpecialObject).method_66().CurrentUIListSettingsIdsAndIndents)
			{
				if (!framework_0.aWZ.Contains(currentUIListSettingsIdsAndIndent.DataId))
				{
					flag3 = false;
					break;
				}
			}
			if (flag3)
			{
				return;
			}
		}
		bool skipThisTreeNode = false;
		if (settingOrSpecialObject2 != null)
		{
			List<Class245> list = new List<Class245>();
			PortFunction.smethod_23(settingOrSpecialObject2, bool_0: false, bool_1: true, list);
			foreach (Class245 item4 in list)
			{
				if (Form23.framework_1.method_31(item4.method_64()) == null)
				{
					method_17(item4, treeNode, null);
				}
			}
			List<Class244> list2 = new List<Class244>();
			PortFunction.smethod_24(settingOrSpecialObject2, bool_0: false, list2, bool_1: true);
			foreach (Class244 item5 in list2)
			{
				if (Form23.framework_1.method_31(item5.method_64()) == null && !item5.method_219())
				{
					method_17(item5, treeNode, Class333.smethod_1134());
				}
				List<Setting> list3 = new List<Setting>();
				PortFunction.smethod_31(item5, list3, bool_0: false);
				foreach (Setting item6 in list3)
				{
					if (Form23.framework_1.method_31(item6.method_64()) == null)
					{
						method_17(item6, treeNode, null);
					}
				}
			}
		}
		else if (settingOrSpecialObject != null)
		{
			Interface4 @interface = settingOrSpecialObject.method_11();
			if (@interface != null)
			{
				@interface.InitReleaseNotesNode(treeNode, Form23.framework_1, ref skipThisTreeNode);
			}
			else if (settingOrSpecialObject.method_1().Count != 0)
			{
				if (!(settingOrSpecialObject is SpecialObject) || !(settingOrSpecialObject as SpecialObject).method_67().EachListRowIsAnObject())
				{
					foreach (SettingOrSpecialObject item7 in settingOrSpecialObject.method_1())
					{
						if (!(item7 is Setting))
						{
							continue;
						}
						Setting setting3 = item7 as Setting;
						if (setting3.method_219() || setting3.method_212() || setting3.method_220() || framework_0.aWZ.Contains(setting3.method_64()))
						{
							continue;
						}
						Setting setting4 = Form23.framework_1.method_31(setting3.method_64());
						if (setting4 == null)
						{
							method_17(setting3, treeNode, null);
						}
						else
						{
							if (setting3.method_207() || setting3.method_154())
							{
								continue;
							}
							List<Setting.ListItems.Struct45> list4 = setting3.method_102();
							for (int i = 0; i < list4.Count; i++)
							{
								bool flag4 = false;
								List<Setting.ListItems.Struct45> list5 = setting4.method_102();
								for (int j = 0; j < list5.Count; j++)
								{
									if (list5[j].bBv == list4[i].bBv || list5[j].bBV.Equals(list4[i].bBV))
									{
										flag4 = true;
										break;
									}
								}
								if (!flag4)
								{
									TreeNode treeNode2 = new TreeNode(setting3.method_22(bool_0: true));
									treeNode2.ForeColor = treeNode.ForeColor;
									treeNode2.Tag = Class333.smethod_1135() + list4[i].bBV + Class333.smethod_1136();
									treeNode.Nodes.Add(treeNode2);
								}
							}
						}
					}
				}
				if (settingOrSpecialObject.method_55() != null)
				{
					string key = settingOrSpecialObject.method_55();
					if (framework_0.aWW.ErrorDefs.ContainsKey(key))
					{
						foreach (ErrorPanelItem item8 in framework_0.aWW.ErrorPanel)
						{
							if (item8.Type != DataTableColumnType.Enum || !int.TryParse(framework_0.aWW.ErrorDefs[key][Class333.smethod_1087()], out var result) || item8.DataId == -1)
							{
								continue;
							}
							Setting setting5 = framework_0.method_31(item8.DataId);
							if (setting5 != null && !setting5.method_219())
							{
								bool flag5 = false;
								Setting setting6 = Form23.framework_1.method_31(setting5.method_64());
								if (setting6 == null || !Form23.framework_1.aWW.IsValid || framework_0.aWW.ErrorToSettingMap[result] >= setting6.method_277())
								{
									method_17(setting5, treeNode, null);
								}
							}
						}
					}
				}
				else
				{
					foreach (string item9 in settingOrSpecialObject.method_52())
					{
						if (!framework_0.aWv.ContainsKey(item9))
						{
							continue;
						}
						foreach (SettingOrSpecialObject item10 in framework_0.aWv[item9].method_1())
						{
							if (!(item10 is Setting))
							{
								continue;
							}
							Setting setting7 = item10 as Setting;
							if (setting7.method_2() == Class333.smethod_1137())
							{
								if (!setting7.method_219() && Form23.framework_1.method_31(setting7.method_64()) == null)
								{
									method_17(setting7, treeNode, null);
								}
								break;
							}
						}
					}
				}
			}
		}
		if (!skipThisTreeNode && (treeNode.GetNodeCount(includeSubTrees: true) != 0 || (treeNode.Tag != null && treeNode.Tag is string)))
		{
			if (treeNode_0 != null)
			{
				treeNode_0.Nodes.Add(treeNode);
				return;
			}
			treeNode.Expand();
			treeViewWithThemedScrollBars_0.method_2().Add(treeNode);
		}
	}

	private void method_17(Setting setting_0, TreeNode treeNode_0, string string_2)
	{
		string text = ((!string.IsNullOrEmpty(string_2)) ? (setting_0.method_22(bool_0: true) + string_2) : setting_0.method_22(bool_0: true));
		TreeNode treeNode = new TreeNode(text);
		treeNode.ForeColor = treeNode_0.ForeColor;
		treeNode.Tag = Class333.smethod_1138();
		treeNode_0.Nodes.Add(treeNode);
	}

	private void method_18()
	{
		foreach (TabPage tabPage in control24_0.TabPages)
		{
			if (tabPage.Controls.Count == 0 || !(tabPage.Controls[0] is Class134))
			{
				continue;
			}
			Class134 @class = tabPage.Controls[0] as Class134;
			@class.Clear();
			@class.method_0();
			if (tabPage.Tag == null)
			{
				if (dictionary_0.ContainsKey(enum88_0))
				{
					if (enum88_0 == Enum88.avK)
					{
						if (class5_0.byte_4 == 22)
						{
							if (string.IsNullOrEmpty(dictionary_0[enum88_0]))
							{
								break;
							}
						}
						else if (Form23.framework_1 == null || framework_0 == null || framework_0.aXA <= Form23.framework_1.aXA || string.IsNullOrEmpty(dictionary_0[enum88_0]))
						{
							break;
						}
					}
					else if (class14_2 <= class14_0 || string.IsNullOrEmpty(dictionary_0[enum88_0]))
					{
						break;
					}
					@class.method_5(dictionary_0[enum88_0]);
				}
			}
			else if (tabPage.Tag is Class235)
			{
				Enum88 key = (tabPage.Tag as Class235).method_0();
				if (dictionary_0.ContainsKey(key))
				{
					if (enum88_0 != Enum88.avK || class14_2 <= class14_0 || string.IsNullOrEmpty(dictionary_0[key]))
					{
						break;
					}
					@class.method_5(dictionary_0[key]);
				}
			}
			@class.method_0();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_19()
	{
		treeViewWithThemedScrollBars_0 = new TreeViewWithThemedScrollBars();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		themedButton_2 = new ThemedButton();
		progressBar_0 = new ProgressBar();
		themedComboBox_0 = new ThemedComboBox();
		control24_0 = new Control24();
		label_4 = new Label();
		SuspendLayout();
		treeViewWithThemedScrollBars_0.method_12(bool_3: true);
		treeViewWithThemedScrollBars_0.AutoScroll = true;
		treeViewWithThemedScrollBars_0.method_10(bool_3: false);
		treeViewWithThemedScrollBars_0.method_1(Enum45.const_0);
		treeViewWithThemedScrollBars_0.Font = new Font(Class333.smethod_145(), 9f);
		treeViewWithThemedScrollBars_0.method_14(null);
		treeViewWithThemedScrollBars_0.Location = new Point(12, 79);
		treeViewWithThemedScrollBars_0.Name = Class333.smethod_1139();
		treeViewWithThemedScrollBars_0.method_4(null);
		treeViewWithThemedScrollBars_0.Size = new Size(856, 500);
		treeViewWithThemedScrollBars_0.TabIndex = 4;
		label_0.AutoSize = true;
		label_0.Location = new Point(12, 32);
		label_0.Name = Class333.smethod_1140();
		label_0.Size = new Size(68, 13);
		label_0.TabIndex = 13;
		label_0.Text = Class333.smethod_1141();
		label_1.AutoSize = true;
		label_1.Location = new Point(12, 8);
		label_1.Name = Class333.smethod_1142();
		label_1.Size = new Size(86, 13);
		label_1.TabIndex = 12;
		label_1.Text = Class333.smethod_1105();
		label_2.AutoSize = true;
		label_2.Location = new Point(12, 63);
		label_2.Name = Class333.smethod_618();
		label_2.Size = new Size(155, 13);
		label_2.TabIndex = 14;
		label_2.Text = Class333.smethod_1143();
		label_3.AutoSize = true;
		label_3.Location = new Point(883, 63);
		label_3.Name = Class333.smethod_620();
		label_3.Size = new Size(156, 13);
		label_3.TabIndex = 15;
		label_3.Text = Class333.smethod_1144();
		themedButton_0.DialogResult = DialogResult.Cancel;
		themedButton_0.Location = new Point(1128, 584);
		themedButton_0.Name = Class333.smethod_830();
		themedButton_0.Size = new Size(100, 38);
		themedButton_0.TabIndex = 1;
		themedButton_0.Text = Class333.smethod_823();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.OK;
		themedButton_1.Enabled = false;
		themedButton_1.Location = new Point(950, 584);
		themedButton_1.Name = Class333.smethod_829();
		themedButton_1.Size = new Size(171, 38);
		themedButton_1.TabIndex = 0;
		themedButton_1.Text = Class333.smethod_1145();
		themedButton_1.UseVisualStyleBackColor = true;
		themedButton_2.Location = new Point(290, 25);
		themedButton_2.Name = Class333.smethod_1146();
		themedButton_2.Size = new Size(120, 26);
		themedButton_2.TabIndex = 3;
		themedButton_2.Text = Class333.smethod_1147();
		themedButton_2.UseVisualStyleBackColor = true;
		themedButton_2.Click += themedButton_2_Click;
		progressBar_0.Location = new Point(520, 302);
		progressBar_0.Name = Class333.smethod_1148();
		progressBar_0.Size = new Size(200, 22);
		progressBar_0.Step = 1;
		progressBar_0.Style = ProgressBarStyle.Continuous;
		progressBar_0.TabIndex = 6;
		progressBar_0.Visible = false;
		themedComboBox_0.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_0.FormattingEnabled = true;
		themedComboBox_0.Location = new Point(81, 28);
		themedComboBox_0.Name = Class333.smethod_1149();
		themedComboBox_0.Size = new Size(200, 23);
		themedComboBox_0.TabIndex = 2;
		themedComboBox_0.SelectedIndexChanged += themedComboBox_0_SelectedIndexChanged;
		control24_0.DrawMode = TabDrawMode.OwnerDrawFixed;
		control24_0.Location = new Point(882, 79);
		control24_0.Margin = new Padding(0);
		control24_0.Multiline = true;
		control24_0.Name = Class333.smethod_1150();
		control24_0.SelectedIndex = 0;
		control24_0.Size = new Size(346, 500);
		control24_0.TabIndex = 5;
		label_4.AutoSize = true;
		label_4.Location = new Point(440, 8);
		label_4.Name = Class333.smethod_1151();
		label_4.Size = new Size(486, 13);
		label_4.TabIndex = 17;
		label_4.Text = Class333.smethod_1152();
		AcceptButton = themedButton_1;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_0;
		ClientSize = new Size(1240, 630);
		Controls.Add(label_4);
		Controls.Add(control24_0);
		Controls.Add(themedComboBox_0);
		Controls.Add(progressBar_0);
		Controls.Add(themedButton_2);
		Controls.Add(themedButton_0);
		Controls.Add(themedButton_1);
		Controls.Add(label_3);
		Controls.Add(label_2);
		Controls.Add(label_0);
		Controls.Add(label_1);
		Controls.Add(treeViewWithThemedScrollBars_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_1153();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_704();
		FormClosing += Form16_FormClosing;
		Shown += Form16_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
