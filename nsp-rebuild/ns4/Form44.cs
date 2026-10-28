using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns5;
using ns7;

namespace ns4;

internal class Form44 : Form
{
	private static Form44 form44_0;

	private Framework framework_0;

	private SortedList<string, ListViewItem> sortedList_0;

	private static int int_0;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Timer timer_0;

	private ThemedTextBox themedTextBox_0;

	private Class85 class85_0;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private Class134 class134_0;

	private ThemedButton themedButton_2;

	private ColumnHeader columnHeader_3;

	private PictureBox pictureBox_0;

	internal static int smethod_0(IWin32Window iwin32Window_0, Framework framework_1, int int_1)
	{
		if (form44_0 == null)
		{
			form44_0 = new Form44();
		}
		form44_0.framework_0 = framework_1;
		int_0 = int_1;
		form44_0.method_1(int_1);
		form44_0.BackColor = Form23.color_10;
		form44_0.pictureBox_0.BackColor = Form23.color_10;
		if (form44_0.pictureBox_0.Image != null)
		{
			form44_0.pictureBox_0.Image.Dispose();
		}
		form44_0.pictureBox_0.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		form44_0.class134_0.BackColor = Form23.color_17;
		form44_0.class134_0.ForeColor = Form23.color_12;
		form44_0.class85_0.BackColor = Form23.color_17;
		form44_0.class85_0.ForeColor = Form23.color_12;
		form44_0.themedTextBox_0.BackColor = Form23.color_32;
		form44_0.themedTextBox_0.ForeColor = Form23.color_12;
		DialogResult dialogResult = form44_0.ShowDialog(iwin32Window_0);
		form44_0.framework_0 = null;
		if (dialogResult == DialogResult.OK)
		{
			return form44_0.method_0();
		}
		return 0;
	}

	internal Form44()
	{
		method_4();
		sortedList_0 = new SortedList<string, ListViewItem>();
		themedTextBox_0.method_0(method_2);
	}

	[SpecialName]
	internal int method_0()
	{
		if (class85_0.SelectedItems.Count == 0)
		{
			return 0;
		}
		return (int)class85_0.SelectedItems[0].Tag;
	}

	[SpecialName]
	internal void method_1(int int_1)
	{
		foreach (ListViewItem item in class85_0.Items)
		{
			if (int_1 != (int)item.Tag)
			{
				item.Selected = false;
			}
		}
		class85_0.SelectedItems.Clear();
		foreach (ListViewItem item2 in class85_0.Items)
		{
			if (int_1 == (int)item2.Tag)
			{
				item2.Selected = true;
				class85_0.FocusedItem = item2;
				break;
			}
		}
	}

	private void class85_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (class85_0.SelectedItems.Count != 0)
		{
			Close();
			DialogResult = DialogResult.OK;
		}
	}

	private void class85_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (framework_0 == null)
		{
			return;
		}
		if (class85_0.SelectedItems.Count != 0)
		{
			Setting setting = framework_0.method_31((int)class85_0.SelectedItems[0].Tag);
			string text = setting.method_60(Enum96.aYt);
			if (text != null)
			{
				class134_0.Text = text + Class333.smethod_537();
			}
			else
			{
				class134_0.Text = setting.method_2() + Class333.smethod_537();
			}
			class134_0.Select(0, class134_0.TextLength);
			class134_0.SelectionFont = new Font(class134_0.SelectionFont.FontFamily, class134_0.SelectionFont.Size, FontStyle.Bold);
			class134_0.SelectionLength = 0;
			int textLength = class134_0.TextLength;
			string text2 = setting.method_60(Enum96.aYU);
			if (text2 != null)
			{
				class134_0.AppendText(text2);
			}
			else if (text != null)
			{
				class134_0.AppendText(text);
			}
			else
			{
				string text3 = setting.method_60(Enum96.aYT);
				if (text3 != null)
				{
					class134_0.AppendText(text3);
				}
				else
				{
					class134_0.AppendText(setting.method_2());
				}
			}
			int length = class134_0.TextLength - textLength;
			class134_0.Select(textLength, length);
			class134_0.SelectionLength = 0;
			themedButton_1.Enabled = true;
		}
		else
		{
			class134_0.Text = string.Empty;
			themedButton_1.Enabled = false;
		}
	}

	private void themedTextBox_0_KeyPress(object sender, KeyPressEventArgs e)
	{
		timer_0.Stop();
		timer_0.Start();
	}

	private void method_2(object sender, ThemedTextBox.EventArgs4 e)
	{
		timer_0.Stop();
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		method_3(-1);
	}

	private void themedTextBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Down && class85_0.SelectedIndices.Count != 0)
		{
			class85_0.Focus();
		}
	}

	private void method_3(int int_1)
	{
		if (framework_0 == null)
		{
			return;
		}
		string text = themedTextBox_0.Text.ToUpper();
		string[] array = text.Split(' ', ',');
		class85_0.BeginUpdate();
		class85_0.Items.Clear();
		foreach (ListViewItem value2 in sortedList_0.Values)
		{
			Setting setting = framework_0.method_31((int)value2.Tag);
			if (setting == null)
			{
				continue;
			}
			string text2 = setting.method_22(bool_0: true);
			string text3 = string.Empty;
			if (setting.method_62() != null)
			{
				text3 = setting.method_62();
			}
			string text4 = setting.method_60(Enum96.aYT);
			if (text4 == null)
			{
				text4 = setting.method_2();
			}
			string text5 = text4.ToUpper();
			string text6 = text2.ToUpper();
			string text7 = text3.ToUpper();
			bool flag = true;
			bool flag2 = false;
			if (!(text == text6) && !(text == text5))
			{
				foreach (string item in setting.method_23())
				{
					if (text == item.ToUpper())
					{
						flag2 = true;
						break;
					}
				}
			}
			else
			{
				flag2 = true;
			}
			if (!flag2)
			{
				string[] array2 = array;
				foreach (string value in array2)
				{
					if (text6.Contains(value) || text5.Contains(value) || text7.Contains(value))
					{
						continue;
					}
					bool flag3 = false;
					foreach (string item2 in setting.method_23())
					{
						if (item2.ToUpper().Contains(value))
						{
							flag3 = true;
							break;
						}
					}
					if (!flag3)
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				if ((class85_0.Items.Count != 0) & flag2)
				{
					class85_0.Items.Insert(0, value2);
				}
				else
				{
					class85_0.Items.Add(value2);
				}
			}
		}
		if (int_1 != -1)
		{
			method_1(int_1);
			foreach (ListViewItem item3 in class85_0.Items)
			{
				if (int_1 == (int)item3.Tag)
				{
					class85_0.EnsureVisible(class85_0.Items.IndexOf(item3));
					break;
				}
			}
		}
		else if (class85_0.Items.Count != 0)
		{
			ListViewItem listViewItem2 = class85_0.Items[0];
			listViewItem2.Selected = true;
			class85_0.FocusedItem = listViewItem2;
		}
		class85_0.EndUpdate();
		themedButton_1.Enabled = class85_0.SelectedItems.Count != 0;
		class85_0.method_1();
	}

	private void themedButton_2_Click(object sender, EventArgs e)
	{
		themedTextBox_0.Clear();
		themedTextBox_0_KeyPress(null, null);
	}

	protected override void OnVisibleChanged(EventArgs eventArgs_0)
	{
		base.OnVisibleChanged(eventArgs_0);
		themedTextBox_0.Focus();
	}

	protected override void OnShown(EventArgs eventArgs_0)
	{
		base.OnShown(eventArgs_0);
		themedTextBox_0.Clear();
		sortedList_0.Clear();
		List<string> list = new List<string>();
		foreach (Setting item in framework_0.aWt)
		{
			if (!item.method_35() || !item.method_184() || item.method_212() || (Form23.form23_0.control3_0.Visible && !Form23.smethod_84(item.method_64())) || !PortFunction.smethod_52(item))
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
			string text3 = string.Empty;
			if (item.method_62() != null)
			{
				text3 = item.method_62();
			}
			string text4 = item.method_60(Enum96.aYT);
			if (text4 == null)
			{
				text4 = item.method_2();
			}
			int int_ = item.method_231();
			string text5 = Class233.smethod_35(item.method_232(), int_, bool_0: false, 0);
			ListViewItem listViewItem = new ListViewItem(new string[4] { text, text3, text4, text5 });
			listViewItem.Tag = item.method_64();
			if (sortedList_0.ContainsKey(text))
			{
				if (!list.Contains(text))
				{
					list.Add(text);
				}
			}
			else
			{
				sortedList_0.Add(text, listViewItem);
			}
		}
		if (list.Count != 0)
		{
			string text6 = Class333.smethod_2526();
			foreach (string item2 in list)
			{
				text6 = text6 + Class333.smethod_570() + item2;
			}
			Form54.smethod_6(this, text6, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		method_3((method_0() != 0) ? method_0() : int_0);
		themedTextBox_0.Focus();
	}

	protected override void OnClosing(CancelEventArgs cancelEventArgs_0)
	{
		cancelEventArgs_0.Cancel = DialogResult == DialogResult.OK && class85_0.SelectedItems.Count == 0;
	}

	private void Form44_Resize(object sender, EventArgs e)
	{
		class85_0.method_1();
	}

	private void class85_0_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
	{
		class85_0.method_1();
	}

	private void class85_0_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
	{
		class85_0.method_1();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_4()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form44));
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		timer_0 = new Timer(icontainer_0);
		themedTextBox_0 = new ThemedTextBox();
		themedButton_2 = new ThemedButton();
		class134_0 = new Class134();
		class85_0 = new Class85();
		columnHeader_0 = new ColumnHeader();
		columnHeader_3 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		pictureBox_0 = new PictureBox();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		componentResourceManager.ApplyResources(themedButton_0, Class333.smethod_2527());
		themedButton_0.Font = new Font(Class333.smethod_145(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_0.DialogResult = DialogResult.Cancel;
		themedButton_0.Name = Class333.smethod_2527();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.OK;
		componentResourceManager.ApplyResources(themedButton_1, Class333.smethod_2528());
		themedButton_1.Font = new Font(Class333.smethod_145(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		themedButton_1.Name = Class333.smethod_2528();
		themedButton_1.UseVisualStyleBackColor = true;
		timer_0.Interval = 400;
		timer_0.Tick += timer_0_Tick;
		componentResourceManager.ApplyResources(themedTextBox_0, Class333.smethod_2529());
		themedTextBox_0.Name = Class333.smethod_2529();
		themedTextBox_0.KeyDown += themedTextBox_0_KeyDown;
		themedTextBox_0.KeyPress += themedTextBox_0_KeyPress;
		componentResourceManager.ApplyResources(themedButton_2, Class333.smethod_592());
		themedButton_2.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		themedButton_2.Name = Class333.smethod_592();
		themedButton_2.UseVisualStyleBackColor = true;
		themedButton_2.Click += themedButton_2_Click;
		class134_0.BackColor = SystemColors.Window;
		class134_0.BorderStyle = BorderStyle.None;
		componentResourceManager.ApplyResources(class134_0, Class333.smethod_1069());
		class134_0.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		class134_0.Name = Class333.smethod_1069();
		class134_0.ReadOnly = true;
		class85_0.Columns.AddRange(columnHeader_0, columnHeader_3, columnHeader_2, columnHeader_1);
		class85_0.FullRowSelect = true;
		class85_0.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		class85_0.HideSelection = false;
		componentResourceManager.ApplyResources(class85_0, Class333.smethod_2530());
		class85_0.Name = Class333.smethod_2530();
		class85_0.TileSize = new Size(400, 16);
		class85_0.UseCompatibleStateImageBehavior = false;
		class85_0.View = View.Details;
		class85_0.ColumnWidthChanged += class85_0_ColumnWidthChanged;
		class85_0.ColumnWidthChanging += class85_0_ColumnWidthChanging;
		class85_0.SelectedIndexChanged += class85_0_SelectedIndexChanged;
		class85_0.MouseDoubleClick += class85_0_MouseDoubleClick;
		componentResourceManager.ApplyResources(columnHeader_0, Class333.smethod_2531());
		componentResourceManager.ApplyResources(columnHeader_3, Class333.smethod_2532());
		componentResourceManager.ApplyResources(columnHeader_2, Class333.smethod_2533());
		componentResourceManager.ApplyResources(columnHeader_1, Class333.smethod_2534());
		componentResourceManager.ApplyResources(pictureBox_0, Class333.smethod_591());
		pictureBox_0.Name = Class333.smethod_591();
		pictureBox_0.TabStop = false;
		AcceptButton = themedButton_1;
		componentResourceManager.ApplyResources(this, Class333.smethod_608());
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_0;
		Controls.Add(themedButton_0);
		Controls.Add(themedButton_1);
		Controls.Add(pictureBox_0);
		Controls.Add(themedTextBox_0);
		Controls.Add(themedButton_2);
		Controls.Add(class134_0);
		Controls.Add(class85_0);
		Font = new Font(Class333.smethod_145(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2535();
		ShowIcon = false;
		ShowInTaskbar = false;
		Resize += Form44_Resize;
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
