using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns4;
using ns7;

namespace NSP.UserInterface.Forms;

public class AddComponentForm : Form
{
	internal class Class175
	{
		internal Label BOB;

		internal List<Class176> BOb;
	}

	internal class Class176 : Panel
	{
		private bool BOC;

		private bool BOc;

		internal int BOD;

		internal Class176()
		{
		}

		[SpecialName]
		internal bool method_0()
		{
			return BOC;
		}

		[SpecialName]
		internal void method_1(bool bool_0)
		{
			BOC = bool_0;
			Invalidate();
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			if (method_0())
			{
				paintEventArgs_0.Graphics.Clear(Color.DodgerBlue);
			}
			else
			{
				paintEventArgs_0.Graphics.Clear(Color.WhiteSmoke);
			}
			if (BOc)
			{
				using Pen pen = new Pen(Color.DodgerBlue, 2f);
				paintEventArgs_0.Graphics.DrawRectangle(pen, 1, 1, Width - 2, Height - 2);
			}
			base.OnPaint(paintEventArgs_0);
		}

		protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
		{
			base.OnMouseClick(mouseEventArgs_0);
		}
	}

	private const int int_0 = 10;

	private const int int_1 = 20;

	private Class176 class176_0;

	[CompilerGenerated]
	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private List<Setting.ListItems.Struct45> list_0;

	private List<Class175> list_1 = new List<Class175>();

	private const int int_7 = 0;

	private IContainer icontainer_0;

	private TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars_0;

	private Panel panel_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Class61 class61_0;

	[SpecialName]
	[CompilerGenerated]
	internal int method_0()
	{
		return int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(int int_8)
	{
		int_2 = int_8;
	}

	internal AddComponentForm(List<Setting.ListItems.Struct45> list_2)
	{
		method_14();
		BackColor = Form23.color_10;
		ForeColor = Form23.color_12;
		tableLayoutPanelWithThemedScrollBars_0.BackColor = BackColor;
		panel_0.BackColor = BackColor;
		class61_0.BackColor = Form23.color_16;
		list_0 = list_2;
		class176_0 = null;
		method_1(0);
	}

	private void method_2()
	{
		foreach (Class175 item in list_1)
		{
			item.BOB.Dispose();
			foreach (Class176 item2 in item.BOb)
			{
				method_4(item2);
			}
		}
	}

	private void method_3(List<Setting.ListItems.Struct45> list_2)
	{
		List<string> list = new List<string>();
		List<int> list2 = new List<int>();
		foreach (Setting.ListItems.Struct45 item in list_2)
		{
			if (item.bBx != Class333.smethod_836() && item.bBx != Class333.smethod_102() && item.bBX != Class333.smethod_102())
			{
				if (!list.Contains(item.bBx))
				{
					list.Add(item.bBx);
					list2.Add(0);
				}
				list2[list.IndexOf(item.bBx)]++;
			}
		}
		List<int> list3 = new List<int>();
		for (int i = 0; i < list.Count; i++)
		{
			list3.Add(0);
		}
		int_3 = 0;
		int_4 = 0;
		foreach (Setting.ListItems.Struct45 item2 in list_2)
		{
			if (item2.bBX != Class333.smethod_102() && item2.bBx != Class333.smethod_836() && item2.bBx != Class333.smethod_102() && list.Contains(item2.bBx))
			{
				Image image = Form23.framework_1.method_30(item2.bBX);
				if (image != null)
				{
					int_3 = Math.Max(int_3, image.Width);
					int_4 = Math.Max(int_4, image.Height);
				}
			}
		}
		int_4 += 20;
		int val = 0;
		for (int j = 0; j < list.Count; j++)
		{
			val = Math.Max(val, list2[j]);
		}
		Font font = new Font(Font.FontFamily, 12f, FontStyle.Bold);
		for (int k = 0; k < list.Count; k++)
		{
			if (list2[k] > 0)
			{
				Label bOB = new Label
				{
					Height = ((k == 0) ? 20 : 40),
					Text = list[k].ToString(),
					TextAlign = ContentAlignment.BottomLeft,
					AutoSize = false,
					BackColor = class61_0.BackColor,
					Width = int_3,
					Font = font,
					ForeColor = Form23.color_12
				};
				Class175 @class = new Class175();
				@class.BOB = bOB;
				@class.BOb = new List<Class176>();
				list_1.Add(@class);
			}
		}
		foreach (Setting.ListItems.Struct45 item3 in list_2)
		{
			if (item3.bBX != Class333.smethod_102() && item3.bBx != Class333.smethod_836() && item3.bBx != Class333.smethod_102() && list.Contains(item3.bBx))
			{
				Image image2 = Form23.framework_1.method_30(item3.bBX);
				if (image2 != null)
				{
					int index = list.IndexOf(item3.bBx);
					PictureBox value = new PictureBox
					{
						Size = new Size(int_3, int_4 - 20),
						SizeMode = PictureBoxSizeMode.CenterImage,
						Image = image2,
						Location = new Point(0, 0)
					};
					Label value2 = new Label
					{
						Size = new Size(int_3, 20),
						Location = new Point(0, int_4 - 20),
						Text = item3.bBV,
						TextAlign = ContentAlignment.MiddleCenter,
						BackColor = class61_0.BackColor,
						ForeColor = Form23.color_12
					};
					Class176 class2 = new Class176
					{
						Size = new Size(int_3, int_4),
						BackColor = class61_0.BackColor,
						BorderStyle = BorderStyle.FixedSingle,
						Tag = item3.bBv
					};
					class2.Controls.Add(value2);
					class2.Controls.Add(value);
					list_1[index].BOb.Add(class2);
				}
			}
		}
	}

	private void AddComponentForm_Shown(object sender, EventArgs e)
	{
		method_6();
	}

	private void method_4(Control control_0)
	{
		if (control_0 is Class176)
		{
			foreach (Control control in control_0.Controls)
			{
				control.Click -= method_7;
				control.DoubleClick -= method_9;
				control.Dispose();
			}
			control_0.Click -= method_7;
			control_0.DoubleClick -= method_9;
			control_0.Dispose();
		}
		else
		{
			control_0.Dispose();
		}
	}

	private void method_5()
	{
		class61_0.AutoSize = false;
		foreach (Class175 item in list_1)
		{
			int_6 = Math.Max(int_6, item.BOb.Count);
		}
		int num = ((int_3 <= 0) ? 1 : Math.Min(int_6, class61_0.Width / int_3));
		if (class61_0.Controls.Count > 0 && int_5 == num)
		{
			return;
		}
		int_5 = num;
		while (class61_0.Controls.Count > 0)
		{
			class61_0.Controls[0].Dispose();
		}
		foreach (Class175 item2 in list_1)
		{
			class61_0.Controls.Add(item2.BOB);
			Panel value = new Panel
			{
				Size = new Size(0, 0),
				Margin = new Padding(0, 0, 0, 0),
				BorderStyle = BorderStyle.None
			};
			class61_0.Controls.Add(value);
			class61_0.SetFlowBreak(item2.BOB, value: true);
			Class176 @class = null;
			foreach (Class176 item3 in item2.BOb)
			{
				class61_0.Controls.Add(item3);
				@class = item3;
			}
			if (@class != null)
			{
				class61_0.SetFlowBreak(@class, value: true);
			}
		}
		class61_0.AutoScroll = false;
		class61_0.HorizontalScroll.Enabled = false;
		class61_0.AutoScroll = true;
	}

	private void method_6()
	{
		class61_0.SuspendLayout();
		method_2();
		method_3(list_0);
		MinimumSize = new Size(int_3 + 18, int_4 * 2);
		method_5();
		if (class61_0.Controls.Count != 0)
		{
			for (int i = 0; i < class61_0.Controls.Count; i++)
			{
				if (!(class61_0.Controls[i] is Class176 @class))
				{
					continue;
				}
				@class.Click += method_7;
				@class.DoubleClick += method_9;
				foreach (Control control in @class.Controls)
				{
					control.Click += method_7;
					control.DoubleClick += method_9;
				}
			}
		}
		class61_0.ResumeLayout(performLayout: true);
	}

	private void method_7(object sender, EventArgs e)
	{
		Class176 @class = null;
		if (sender is PictureBox)
		{
			@class = (sender as PictureBox).Parent as Class176;
		}
		else if (sender is Label)
		{
			@class = (sender as Label).Parent as Class176;
		}
		else if (sender is Class176)
		{
			@class = sender as Class176;
		}
		foreach (Control control in class61_0.Controls)
		{
			if (control is Class176 class2 && class2 == @class)
			{
				if (class176_0 != null)
				{
					class176_0.BackColor = class61_0.BackColor;
					class176_0.BorderStyle = BorderStyle.FixedSingle;
					class176_0.method_1(bool_0: false);
				}
				class176_0 = class2;
				class2.method_1(bool_0: true);
				class176_0.BorderStyle = BorderStyle.Fixed3D;
				class176_0.BackColor = Color.DodgerBlue;
				themedButton_1.Enabled = true;
			}
		}
		class61_0.Focus();
		class61_0.ScrollControlIntoView(@class);
		class61_0.method_2();
	}

	private void method_8()
	{
		DialogResult = DialogResult.OK;
		if (class176_0 != null)
		{
			method_1((int)class176_0.Tag);
		}
		method_2();
		Close();
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		method_8();
	}

	private void method_9(object sender, EventArgs e)
	{
		method_7(sender, e);
		method_8();
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		method_2();
		Close();
	}

	private void class61_0_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
	{
		if (Controls.Count == 0)
		{
			return;
		}
		e.IsInputKey = true;
		if (e.KeyData == Keys.Escape)
		{
			themedButton_0_Click(sender, null);
		}
		else if (e.KeyData != Keys.Return && e.KeyData != Keys.Return)
		{
			if (e.KeyData != Keys.Tab && e.KeyData != Keys.Right)
			{
				if (e.KeyData != (Keys.Tab | Keys.Shift) && e.KeyData != Keys.Left)
				{
					if (e.KeyData == Keys.Down)
					{
						method_13();
					}
					else if (e.KeyData == Keys.Up)
					{
						method_12();
					}
				}
				else
				{
					method_10();
				}
			}
			else
			{
				method_11();
			}
		}
		else
		{
			themedButton_1_Click(null, null);
		}
	}

	private void method_10()
	{
		if (class176_0 != null)
		{
			int num = class61_0.Controls.IndexOf(class176_0) - 1;
			while (num >= 0 && !(class61_0.Controls[num] is Class176))
			{
				num--;
			}
			if (num >= 0 && class61_0.Controls[num] is Class176)
			{
				method_7(class61_0.Controls[num], null);
			}
		}
	}

	private void method_11()
	{
		if (class176_0 != null)
		{
			int i;
			for (i = class61_0.Controls.IndexOf(class176_0) + 1; i < class61_0.Controls.Count - 1 && !(class61_0.Controls[i] is Class176); i++)
			{
			}
			if (i < class61_0.Controls.Count && class61_0.Controls[i] is Class176)
			{
				method_7(class61_0.Controls[i], null);
			}
		}
	}

	private void method_12()
	{
		if (class176_0 != null)
		{
			int num = class61_0.Controls.IndexOf(class176_0);
			while (num > 0 && num <= class61_0.Controls.Count - 1 && class61_0.Controls[num] is Class176)
			{
				num--;
			}
			while (num > 0 && num <= class61_0.Controls.Count - 1 && !(class61_0.Controls[num] is Class176))
			{
				num--;
			}
			while (num > 0 && num <= class61_0.Controls.Count - 1 && class61_0.Controls[num] is Class176)
			{
				num--;
			}
			num++;
			if (num >= 0 && class61_0.Controls[num] is Class176)
			{
				method_7(class61_0.Controls[num], null);
			}
		}
	}

	private void method_13()
	{
		if (class176_0 != null)
		{
			int i;
			for (i = class61_0.Controls.IndexOf(class176_0); i < class61_0.Controls.Count - 1 && class61_0.Controls[i] is Class176; i++)
			{
			}
			for (; i < class61_0.Controls.Count - 1 && !(class61_0.Controls[i] is Class176); i++)
			{
			}
			if (i < class61_0.Controls.Count - 1 && class61_0.Controls[i] is Class176)
			{
				method_7(class61_0.Controls[i], null);
			}
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

	private void method_14()
	{
		tableLayoutPanelWithThemedScrollBars_0 = new TableLayoutPanelWithThemedScrollBars();
		panel_0 = new Panel();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		class61_0 = new Class61();
		tableLayoutPanelWithThemedScrollBars_0.SuspendLayout();
		panel_0.SuspendLayout();
		SuspendLayout();
		tableLayoutPanelWithThemedScrollBars_0.ColumnCount = 1;
		tableLayoutPanelWithThemedScrollBars_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanelWithThemedScrollBars_0.Controls.Add(panel_0, 0, 1);
		tableLayoutPanelWithThemedScrollBars_0.Controls.Add(class61_0, 0, 0);
		tableLayoutPanelWithThemedScrollBars_0.Dock = DockStyle.Fill;
		tableLayoutPanelWithThemedScrollBars_0.Location = new Point(0, 0);
		tableLayoutPanelWithThemedScrollBars_0.Name = Class333.smethod_837();
		tableLayoutPanelWithThemedScrollBars_0.RowCount = 2;
		tableLayoutPanelWithThemedScrollBars_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanelWithThemedScrollBars_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));
		tableLayoutPanelWithThemedScrollBars_0.Size = new Size(1084, 621);
		tableLayoutPanelWithThemedScrollBars_0.TabIndex = 8;
		panel_0.Controls.Add(themedButton_0);
		panel_0.Controls.Add(themedButton_1);
		panel_0.Dock = DockStyle.Fill;
		panel_0.Location = new Point(0, 571);
		panel_0.Margin = new Padding(0);
		panel_0.Name = Class333.smethod_838();
		panel_0.Size = new Size(1084, 50);
		panel_0.TabIndex = 0;
		themedButton_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		themedButton_0.DialogResult = DialogResult.Cancel;
		themedButton_0.Location = new Point(972, 9);
		themedButton_0.Name = Class333.smethod_830();
		themedButton_0.Size = new Size(100, 30);
		themedButton_0.TabIndex = 3;
		themedButton_0.Text = Class333.smethod_823();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		themedButton_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		themedButton_1.Enabled = false;
		themedButton_1.Location = new Point(862, 9);
		themedButton_1.Name = Class333.smethod_839();
		themedButton_1.Size = new Size(100, 30);
		themedButton_1.TabIndex = 2;
		themedButton_1.Text = Class333.smethod_821();
		themedButton_1.Visible = true;
		themedButton_1.UseVisualStyleBackColor = true;
		themedButton_1.Click += themedButton_1_Click;
		class61_0.AutoScroll = true;
		class61_0.BackColor = Color.White;
		class61_0.BorderStyle = BorderStyle.FixedSingle;
		class61_0.Dock = DockStyle.Fill;
		class61_0.Location = new Point(10, 10);
		class61_0.Margin = new Padding(0);
		class61_0.Name = Class333.smethod_840();
		class61_0.Size = new Size(1064, 621);
		class61_0.TabIndex = 4;
		class61_0.PreviewKeyDown += class61_0_PreviewKeyDown;
		class61_0.TabStop = true;
		AllowDrop = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_0;
		ClientSize = new Size(1084, 621);
		Controls.Add(tableLayoutPanelWithThemedScrollBars_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		MinimizeBox = false;
		MinimumSize = new Size(500, 500);
		Name = Class333.smethod_841();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_353();
		Shown += AddComponentForm_Shown;
		tableLayoutPanelWithThemedScrollBars_0.ResumeLayout(performLayout: false);
		panel_0.ResumeLayout(performLayout: false);
		panel_0.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
