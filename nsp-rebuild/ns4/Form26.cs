using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.UserInterface;
using ns0;
using ns2;
using ns5;
using ns6;
using ns7;

namespace ns4;

internal class Form26 : Form
{
	private struct Struct41
	{
		internal string Bqw;

		internal string BqX;

		internal Struct41(string string_0, string string_1)
		{
			Bqw = string_0;
			BqX = string_1;
		}
	}

	private string string_0;

	private List<List<Struct41>> list_0 = new List<List<Struct41>>();

	private IContainer icontainer_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private ThemedComboBox themedComboBox_0;

	private Class85 class85_0;

	private ColumnHeader columnHeader_0;

	private Label label_0;

	private PictureBox pictureBox_0;

	internal Form26()
	{
		method_2();
	}

	[SpecialName]
	internal string method_0()
	{
		return string_0;
	}

	private void Form26_Shown(object sender, EventArgs e)
	{
		BackColor = Form23.color_10;
		class85_0.BackColor = Form23.color_17;
		class85_0.ForeColor = Form23.color_12;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		List<string> list = Class234.smethod_11();
		if (list == null)
		{
			Form54.smethod_6(this, Class333.smethod_2079(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		foreach (string item in list)
		{
			method_1(item);
		}
		class85_0.method_1();
		if (class85_0.Items.Count == 1)
		{
			class85_0.Items[0].Selected = true;
		}
	}

	private void method_1(string string_1)
	{
		Class239 @class = Class234.smethod_0(string_1);
		if (@class == null || (Class242.smethod_12(@class.axq) && @class.axr.method_0() < 3))
		{
			return;
		}
		Class240 bdC = new Class240
		{
			axS = @class.axq,
			axs = @class.axR,
			axT = @class.axr,
			axt = null
		};
		Class316 class2 = new Class316
		{
			BdC = bdC,
			Bdc = new List<ushort>()
		};
		if (Class305.smethod_4(class2, out var _, out var _) || (!class2.BdC.axT.method_7() && !Form59.smethod_2()))
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < class85_0.Items.Count; i++)
		{
			Class239 class3 = (Class239)class85_0.Items[i].Tag;
			if (class3.axq == @class.axq && class3.axR == @class.axR)
			{
				num = i;
				break;
			}
		}
		Struct41 item = new Struct41(string_1, @class.axr.ToString());
		if (num == -1)
		{
			ListViewItem listViewItem = new ListViewItem(new string[1] { Class242.smethod_10(@class.axq, @class.axR) });
			Class239 class4 = new Class239();
			class4.axq = @class.axq;
			class4.axR = @class.axR;
			class4.axr = @class.axr;
			listViewItem.Tag = class4;
			List<Struct41> list = new List<Struct41>();
			list.Add(item);
			if (class85_0.Items.Count == 0)
			{
				class85_0.Items.Add(listViewItem);
				list_0.Add(list);
				return;
			}
			int num2 = Class242.smethod_2(class4.axq, class4.axR);
			bool flag = false;
			for (int j = 0; j < class85_0.Items.Count; j++)
			{
				int axq = ((Class239)class85_0.Items[j].Tag).axq;
				int axR = ((Class239)class85_0.Items[j].Tag).axR;
				int num3 = Class242.smethod_2(axq, axR);
				if (num2 < num3)
				{
					class85_0.Items.Insert(j, listViewItem);
					list_0.Insert(j, list);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				class85_0.Items.Add(listViewItem);
				list_0.Add(list);
			}
			return;
		}
		List<Struct41> list2 = list_0[num];
		Class14 class5 = new Class14(item.BqX, bool_0: false);
		if (list2.Count == 0)
		{
			list2.Add(item);
			return;
		}
		int num4 = list2.Count - 1;
		while (true)
		{
			if (num4 >= 0)
			{
				Class14 class6 = new Class14(list2[num4].BqX, bool_0: false);
				if (class5 < class6 || (class5 == class6 && File.GetLastWriteTime(string_1) < File.GetLastWriteTime(list2[num4].Bqw)))
				{
					break;
				}
				if (num4 == 0)
				{
					list2.Insert(0, item);
				}
				num4--;
				continue;
			}
			return;
		}
		if (num4 == list2.Count - 1)
		{
			list2.Add(item);
		}
		else
		{
			list2.Insert(num4 + 1, item);
		}
	}

	private void class85_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (class85_0.SelectedIndices.Count != 1)
			{
				return;
			}
			Class239 @class = (Class239)class85_0.Items[class85_0.SelectedIndices[0]].Tag;
			int axq = @class.axq;
			int axR = @class.axR;
			pictureBox_0.Image = Class242.smethod_11(axq, axR);
			themedComboBox_0.Items.Clear();
			foreach (Struct41 item in list_0[class85_0.SelectedIndices[0]])
			{
				themedComboBox_0.Items.Add(item.BqX);
			}
			themedComboBox_0.SelectedIndex = 0;
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.smethod_2080() + ex.Message);
		}
	}

	private void class85_0_DoubleClick(object sender, EventArgs e)
	{
		DialogResult = DialogResult.OK;
		Close();
	}

	private void Form26_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult != DialogResult.OK)
		{
			return;
		}
		try
		{
			int num = class85_0.SelectedIndices[0];
			int selectedIndex = themedComboBox_0.SelectedIndex;
			if (num != -1 && selectedIndex != -1)
			{
				string_0 = list_0[num][selectedIndex].Bqw;
			}
			else
			{
				e.Cancel = true;
			}
		}
		catch
		{
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

	private void method_2()
	{
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		themedComboBox_0 = new ThemedComboBox();
		class85_0 = new Class85();
		columnHeader_0 = new ColumnHeader();
		label_0 = new Label();
		pictureBox_0 = new PictureBox();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Location = new Point(300, 320);
		themedButton_0.Name = Class333.smethod_829();
		themedButton_0.Size = new Size(100, 30);
		themedButton_0.TabIndex = 2;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_1.DialogResult = DialogResult.Cancel;
		themedButton_1.Location = new Point(418, 320);
		themedButton_1.Name = Class333.smethod_830();
		themedButton_1.Size = new Size(100, 30);
		themedButton_1.TabIndex = 3;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		themedComboBox_0.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_0.FormattingEnabled = true;
		themedComboBox_0.Location = new Point(326, 39);
		themedComboBox_0.MaxDropDownItems = 40;
		themedComboBox_0.Name = Class333.smethod_2081();
		themedComboBox_0.Size = new Size(190, 23);
		themedComboBox_0.TabIndex = 1;
		class85_0.BorderStyle = BorderStyle.FixedSingle;
		class85_0.Columns.AddRange(columnHeader_0);
		class85_0.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		class85_0.HideSelection = false;
		class85_0.Location = new Point(12, 12);
		class85_0.MultiSelect = false;
		class85_0.Name = Class333.smethod_2082();
		class85_0.ShowGroups = false;
		class85_0.Size = new Size(300, 289);
		class85_0.TabIndex = 0;
		class85_0.UseCompatibleStateImageBehavior = false;
		class85_0.View = View.Details;
		class85_0.SelectedIndexChanged += class85_0_SelectedIndexChanged;
		class85_0.DoubleClick += class85_0_DoubleClick;
		columnHeader_0.Text = Class333.smethod_2083();
		columnHeader_0.Width = 280;
		label_0.AutoSize = true;
		label_0.Location = new Point(323, 23);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(48, 13);
		label_0.TabIndex = 15;
		label_0.Text = Class333.smethod_2084();
		pictureBox_0.Location = new Point(326, 81);
		pictureBox_0.Margin = new Padding(0);
		pictureBox_0.Name = Class333.smethod_601();
		pictureBox_0.Size = new Size(190, 200);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 16;
		pictureBox_0.TabStop = false;
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(529, 362);
		Controls.Add(pictureBox_0);
		Controls.Add(label_0);
		Controls.Add(class85_0);
		Controls.Add(themedComboBox_0);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2085();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1264();
		FormClosing += Form26_FormClosing;
		Shown += Form26_Shown;
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
