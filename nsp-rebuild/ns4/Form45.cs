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

internal class Form45 : Form
{
	private static Form45 form45_0;

	private Framework framework_0;

	private SortedList<string, ListViewItem> sortedList_0;

	private List<int> list_0;

	private int int_0;

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Timer timer_0;

	private Class134 class134_0;

	private ThemedTextBox themedTextBox_0;

	private ThemedButton themedButton_2;

	private Class85 class85_0;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private ThemedButton themedButton_3;

	private ThemedButton themedButton_4;

	private Class85 class85_1;

	private ColumnHeader columnHeader_4;

	private ColumnHeader columnHeader_5;

	private ColumnHeader columnHeader_6;

	private ColumnHeader columnHeader_7;

	private Label label_0;

	private PictureBox pictureBox_0;

	internal static List<int> smethod_0(IWin32Window iwin32Window_0, Framework framework_1, List<int> list_1, int int_1)
	{
		if (form45_0 == null)
		{
			form45_0 = new Form45();
		}
		form45_0.framework_0 = framework_1;
		form45_0.method_1(list_1);
		form45_0.int_0 = int_1;
		form45_0.BackColor = Form23.color_10;
		form45_0.pictureBox_0.BackColor = Form23.color_10;
		if (form45_0.pictureBox_0.Image != null)
		{
			form45_0.pictureBox_0.Image.Dispose();
		}
		form45_0.pictureBox_0.Image = Class25.smethod_0(GeneralResources.Search, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		form45_0.class134_0.BackColor = Form23.color_17;
		form45_0.class134_0.ForeColor = Form23.color_12;
		form45_0.class85_0.BackColor = Form23.color_17;
		form45_0.class85_0.ForeColor = Form23.color_12;
		form45_0.class85_1.BackColor = Form23.color_17;
		form45_0.class85_1.ForeColor = Form23.color_12;
		form45_0.label_0.ForeColor = Form23.color_12;
		form45_0.themedTextBox_0.BackColor = Form23.color_32;
		form45_0.themedTextBox_0.ForeColor = Form23.color_12;
		DialogResult dialogResult = form45_0.ShowDialog(iwin32Window_0);
		form45_0.framework_0 = null;
		if (dialogResult == DialogResult.OK)
		{
			return form45_0.method_0();
		}
		return null;
	}

	internal Form45()
	{
		method_7();
		list_0 = new List<int>();
		sortedList_0 = new SortedList<string, ListViewItem>();
		themedTextBox_0.method_0(method_3);
	}

	[SpecialName]
	internal List<int> method_0()
	{
		return list_0;
	}

	[SpecialName]
	internal void method_1(List<int> list_1)
	{
		list_0.Clear();
		if (list_1 == null || framework_0 == null)
		{
			return;
		}
		foreach (int item in list_1)
		{
			if (framework_0.method_31(item) != null)
			{
				list_0.Add(item);
			}
		}
	}

	private void method_2(int int_1)
	{
		if (framework_0 == null)
		{
			return;
		}
		Setting setting = framework_0.method_31(int_1);
		if (setting == null)
		{
			class134_0.Text = string.Empty;
			return;
		}
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
	}

	private void class85_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		themedButton_4.Enabled = class85_0.SelectedItems.Count != 0;
		if (class85_0.SelectedItems.Count == 1)
		{
			method_2((int)class85_0.SelectedItems[0].Tag);
		}
		else
		{
			class134_0.Text = string.Empty;
		}
	}

	private void class85_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		themedButton_3.Enabled = class85_1.SelectedItems.Count != 0;
		if (class85_1.SelectedItems.Count == 1)
		{
			method_2((int)class85_1.SelectedItems[0].Tag);
		}
		else
		{
			class134_0.Text = string.Empty;
		}
	}

	private void class85_1_DragDrop(object sender, DragEventArgs e)
	{
		list_0.Clear();
		foreach (ListViewItem item in class85_1.Items)
		{
			list_0.Add((int)item.Tag);
		}
	}

	private void themedTextBox_0_KeyPress(object sender, KeyPressEventArgs e)
	{
		timer_0.Stop();
		timer_0.Start();
	}

	private void method_3(object sender, ThemedTextBox.EventArgs4 e)
	{
		timer_0.Stop();
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		method_4();
	}

	private void themedTextBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Down)
		{
			if (class85_0.SelectedIndices.Count != 0)
			{
				class85_0.Focus();
			}
		}
		else if (e.KeyCode == Keys.Return)
		{
			themedButton_4_Click(this, EventArgs.Empty);
			themedTextBox_0.SelectAll();
		}
	}

	private void method_4()
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
			if (class85_1.Items.Contains(value2))
			{
				continue;
			}
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
				value2.Selected = false;
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
		if (class85_0.Items.Count != 0)
		{
			ListViewItem listViewItem = class85_0.Items[0];
			listViewItem.Selected = true;
			class85_0.FocusedItem = listViewItem;
		}
		class85_0.EndUpdate();
		class85_0.method_1();
		class85_1.method_1();
	}

	private void themedButton_2_Click(object sender, EventArgs e)
	{
		themedTextBox_0.Clear();
		themedTextBox_0_KeyPress(null, null);
	}

	protected override void OnVisibleChanged(EventArgs eventArgs_0)
	{
		if (Visible && framework_0 != null)
		{
			themedTextBox_0.Clear();
			sortedList_0.Clear();
			class85_0.Items.Clear();
			class85_1.Items.Clear();
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
				listViewItem.Name = text;
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
			method_4();
			foreach (int item3 in list_0)
			{
				Setting setting = framework_0.method_31(item3);
				if (setting != null)
				{
					string text7 = setting.method_60(Enum96.aYt);
					if (text7 == null)
					{
						text7 = setting.method_2();
					}
					string text8 = setting.method_18();
					if (!string.IsNullOrWhiteSpace(text8))
					{
						text7 = text8 + Class333.smethod_497() + text7 + Class333.smethod_9();
					}
					string text9 = string.Empty;
					if (setting.method_62() != null)
					{
						text9 = setting.method_62();
					}
					string text10 = setting.method_60(Enum96.aYT);
					if (text10 == null)
					{
						text10 = setting.method_2();
					}
					ListViewItem listViewItem2 = class85_0.Items[text7];
					if (listViewItem2 != null)
					{
						class85_0.Items.Remove(listViewItem2);
						class85_1.Items.Add(listViewItem2);
						continue;
					}
					int int_2 = setting.method_231();
					string text11 = Class233.smethod_35(setting.method_232(), int_2, bool_0: false, 0);
					listViewItem2 = new ListViewItem(new string[4] { text7, text9, text10, text11 });
					listViewItem2.Name = text7;
					listViewItem2.Tag = item3;
					class85_1.Items.Add(listViewItem2);
				}
			}
			label_0.Text = class85_1.Items.Count + Class333.smethod_2536();
			if (int_0 != 0)
			{
				Label label = label_0;
				label.Text = label.Text + Class333.smethod_2537() + int_0 + Class333.smethod_9();
			}
		}
		base.OnVisibleChanged(eventArgs_0);
		themedTextBox_0.Focus();
	}

	private void themedButton_4_Click(object sender, EventArgs e)
	{
		if (class85_0.SelectedItems.Count == 1)
		{
			ListViewItem listViewItem = class85_0.SelectedItems[0];
			method_5(listViewItem);
		}
		else if (class85_0.SelectedItems.Count > 1)
		{
			ListView.SelectedListViewItemCollection selectedItems = class85_0.SelectedItems;
			ListViewItem[] array = new ListViewItem[selectedItems.Count];
			selectedItems.CopyTo(array, 0);
			method_5(array);
		}
	}

	private void class85_1_DoubleClick(object sender, EventArgs e)
	{
		if (class85_1.SelectedItems.Count == 1)
		{
			method_6(class85_1.SelectedItems[0]);
		}
		else if (class85_1.SelectedItems.Count > 1)
		{
			ListView.SelectedListViewItemCollection selectedItems = class85_1.SelectedItems;
			ListViewItem[] array = new ListViewItem[selectedItems.Count];
			selectedItems.CopyTo(array, 0);
			method_6(array);
		}
	}

	private void method_5(params ListViewItem[] items)
	{
		foreach (ListViewItem listViewItem in items)
		{
			list_0.Add((int)listViewItem.Tag);
			class85_0.Items.Remove(listViewItem);
			listViewItem.Selected = false;
			class85_1.Items.Add(listViewItem);
		}
		class85_0.method_1();
		class85_1.method_1();
		label_0.Text = class85_1.Items.Count + Class333.smethod_2536();
		if (int_0 != 0)
		{
			Label label = label_0;
			label.Text = label.Text + Class333.smethod_2537() + int_0 + Class333.smethod_9();
		}
	}

	private void method_6(params ListViewItem[] items)
	{
		class85_1.BeginUpdate();
		foreach (ListViewItem listViewItem in items)
		{
			list_0.Remove((int)listViewItem.Tag);
			class85_1.Items.Remove(listViewItem);
		}
		class85_1.EndUpdate();
		method_4();
		label_0.Text = class85_1.Items.Count + Class333.smethod_2536();
		if (int_0 != 0)
		{
			Label label = label_0;
			label.Text = label.Text + Class333.smethod_2537() + int_0 + Class333.smethod_9();
		}
	}

	private void Form45_Resize(object sender, EventArgs e)
	{
		class134_0.Width = ClientRectangle.Width - class134_0.Left - 11;
		class134_0.method_0();
		class85_0.Height = ClientRectangle.Height - 44 - class85_0.Top;
		class85_1.Top = class85_0.Top;
		class85_1.Height = class85_0.Height;
		class85_0.Width = ClientRectangle.Width / 2 - 29 - 10;
		class85_1.Width = class85_0.Width;
		class85_1.Left = 10 + class85_0.Width + 58;
		themedButton_4.Top = class85_0.Top + class85_0.Height * 115 / 375;
		themedButton_3.Top = class85_0.Top + class85_0.Height * 173 / 375;
		themedButton_4.Left = ClientRectangle.Width / 2 - themedButton_4.Width / 2;
		themedButton_3.Left = themedButton_4.Left;
		label_0.Top = class85_1.Bottom + 13;
		label_0.Left = class85_1.Left + 4;
		themedButton_1.Left = ClientRectangle.Width - 193;
		themedButton_1.Top = ClientRectangle.Height - 36;
		themedButton_0.Left = ClientRectangle.Width - 100;
		themedButton_0.Top = themedButton_1.Top;
		class85_0.method_1();
		class85_1.method_1();
	}

	private void class85_0_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
	{
		class85_0.method_1();
	}

	private void class85_1_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
	{
		class85_1.method_1();
	}

	private void class85_0_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
	{
		class85_0.method_1();
	}

	private void class85_1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
	{
		class85_1.method_1();
	}

	private void class85_1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Delete)
		{
			themedButton_3.PerformClick();
		}
	}

	private void Form45_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult == DialogResult.OK && int_0 != 0 && method_0().Count > int_0)
		{
			Form54.smethod_6(this, Class333.smethod_2538() + int_0 + Class333.smethod_9(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			e.Cancel = true;
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

	private void method_7()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form45));
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		timer_0 = new Timer(icontainer_0);
		themedTextBox_0 = new ThemedTextBox();
		themedButton_2 = new ThemedButton();
		class134_0 = new Class134();
		class85_0 = new Class85();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		columnHeader_3 = new ColumnHeader();
		themedButton_3 = new ThemedButton();
		themedButton_4 = new ThemedButton();
		class85_1 = new Class85();
		columnHeader_4 = new ColumnHeader();
		columnHeader_5 = new ColumnHeader();
		columnHeader_6 = new ColumnHeader();
		columnHeader_7 = new ColumnHeader();
		label_0 = new Label();
		pictureBox_0 = new PictureBox();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		componentResourceManager.ApplyResources(themedButton_0, Class333.smethod_2527());
		themedButton_0.DialogResult = DialogResult.Cancel;
		themedButton_0.Name = Class333.smethod_2527();
		themedButton_0.UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(themedButton_1, Class333.smethod_2528());
		themedButton_1.DialogResult = DialogResult.OK;
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
		class85_0.Columns.AddRange(columnHeader_0, columnHeader_1, columnHeader_2, columnHeader_3);
		class85_0.FullRowSelect = true;
		class85_0.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		class85_0.HideSelection = false;
		componentResourceManager.ApplyResources(class85_0, Class333.smethod_2539());
		class85_0.Name = Class333.smethod_2539();
		class85_0.TileSize = new Size(400, 16);
		class85_0.UseCompatibleStateImageBehavior = false;
		class85_0.View = View.Details;
		class85_0.ColumnWidthChanged += class85_0_ColumnWidthChanged;
		class85_0.ColumnWidthChanging += class85_0_ColumnWidthChanging;
		class85_0.ItemActivate += themedButton_4_Click;
		class85_0.SelectedIndexChanged += class85_0_SelectedIndexChanged;
		class85_0.DoubleClick += themedButton_4_Click;
		componentResourceManager.ApplyResources(columnHeader_0, Class333.smethod_2540());
		componentResourceManager.ApplyResources(columnHeader_1, Class333.smethod_2532());
		componentResourceManager.ApplyResources(columnHeader_2, Class333.smethod_2533());
		componentResourceManager.ApplyResources(columnHeader_3, Class333.smethod_2534());
		componentResourceManager.ApplyResources(themedButton_3, Class333.smethod_2541());
		themedButton_3.Name = Class333.smethod_2541();
		themedButton_3.TabStop = false;
		themedButton_3.UseVisualStyleBackColor = true;
		themedButton_3.Click += class85_1_DoubleClick;
		componentResourceManager.ApplyResources(themedButton_4, Class333.smethod_607());
		themedButton_4.Name = Class333.smethod_607();
		themedButton_4.TabStop = false;
		themedButton_4.UseVisualStyleBackColor = true;
		themedButton_4.Click += themedButton_4_Click;
		class85_1.AllowDrop = true;
		class85_1.Columns.AddRange(columnHeader_4, columnHeader_5, columnHeader_6, columnHeader_7);
		class85_1.FullRowSelect = true;
		class85_1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		class85_1.HideSelection = false;
		componentResourceManager.ApplyResources(class85_1, Class333.smethod_2542());
		class85_1.Name = Class333.smethod_2542();
		class85_1.TileSize = new Size(400, 16);
		class85_1.UseCompatibleStateImageBehavior = false;
		class85_1.View = View.Details;
		class85_1.ColumnWidthChanged += class85_1_ColumnWidthChanged;
		class85_1.ColumnWidthChanging += class85_1_ColumnWidthChanging;
		class85_1.ItemActivate += class85_1_DoubleClick;
		class85_1.SelectedIndexChanged += class85_1_SelectedIndexChanged;
		class85_1.DragDrop += class85_1_DragDrop;
		class85_1.DoubleClick += class85_1_DoubleClick;
		class85_1.KeyDown += class85_1_KeyDown;
		componentResourceManager.ApplyResources(columnHeader_4, Class333.smethod_2543());
		componentResourceManager.ApplyResources(columnHeader_5, Class333.smethod_2544());
		componentResourceManager.ApplyResources(columnHeader_6, Class333.smethod_2545());
		componentResourceManager.ApplyResources(columnHeader_7, Class333.smethod_2546());
		componentResourceManager.ApplyResources(label_0, Class333.smethod_2547());
		label_0.Font = new Font(Class333.smethod_145(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.Name = Class333.smethod_2547();
		componentResourceManager.ApplyResources(pictureBox_0, Class333.smethod_591());
		pictureBox_0.Name = Class333.smethod_591();
		pictureBox_0.TabStop = false;
		componentResourceManager.ApplyResources(this, Class333.smethod_608());
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_0;
		Controls.Add(class85_1);
		Controls.Add(class85_0);
		Controls.Add(label_0);
		Controls.Add(themedButton_3);
		Controls.Add(themedButton_4);
		Controls.Add(themedButton_0);
		Controls.Add(themedButton_1);
		Controls.Add(class134_0);
		Controls.Add(pictureBox_0);
		Controls.Add(themedTextBox_0);
		Controls.Add(themedButton_2);
		Font = new Font(Class333.smethod_145(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		MinimizeBox = false;
		Name = Class333.smethod_2548();
		ShowIcon = false;
		ShowInTaskbar = false;
		FormClosing += Form45_FormClosing;
		Resize += Form45_Resize;
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
