using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns4;
using ns7;

namespace NSP.UserInterface;

public class CANRawDataView : UserControl
{
	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private Label label_0;

	private Label label_1;

	private TableLayoutPanel tableLayoutPanel_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	private Label label_9;

	private ThemedTextBox themedTextBox_0;

	private ThemedTextBox themedTextBox_1;

	private ThemedTextBox themedTextBox_2;

	private ThemedTextBox themedTextBox_3;

	private ThemedTextBox themedTextBox_4;

	private ThemedTextBox themedTextBox_5;

	private ThemedTextBox themedTextBox_6;

	private ThemedTextBox themedTextBox_7;

	public CANRawDataView()
	{
		method_0();
		label_0.ForeColor = Form23.color_36;
		label_1.ForeColor = Form23.color_36;
		label_9.ForeColor = Form23.color_36;
		label_8.ForeColor = Form23.color_36;
		label_7.ForeColor = Form23.color_36;
		label_6.ForeColor = Form23.color_36;
		label_5.ForeColor = Form23.color_36;
		label_4.ForeColor = Form23.color_36;
		label_3.ForeColor = Form23.color_36;
		label_2.ForeColor = Form23.color_36;
		themedTextBox_0.ForeColor = Form23.color_12;
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_1.ForeColor = Form23.color_12;
		themedTextBox_1.BackColor = Form23.color_32;
		themedTextBox_2.ForeColor = Form23.color_12;
		themedTextBox_2.BackColor = Form23.color_32;
		themedTextBox_3.ForeColor = Form23.color_12;
		themedTextBox_3.BackColor = Form23.color_32;
		themedTextBox_4.ForeColor = Form23.color_12;
		themedTextBox_4.BackColor = Form23.color_32;
		themedTextBox_5.ForeColor = Form23.color_12;
		themedTextBox_5.BackColor = Form23.color_32;
		themedTextBox_6.ForeColor = Form23.color_12;
		themedTextBox_6.BackColor = Form23.color_32;
		themedTextBox_7.ForeColor = Form23.color_12;
		themedTextBox_7.BackColor = Form23.color_32;
	}

	public void EnableOrDisable(bool enable, uint length = 8u)
	{
		Color color_ = Form23.color_12;
		Color color_2 = Form23.color_36;
		if (enable)
		{
			label_0.ForeColor = color_;
			label_1.ForeColor = color_;
			label_9.ForeColor = ((length >= 1) ? color_ : color_2);
			label_8.ForeColor = ((length >= 2) ? color_ : color_2);
			label_7.ForeColor = ((length >= 3) ? color_ : color_2);
			label_6.ForeColor = ((length >= 4) ? color_ : color_2);
			label_5.ForeColor = ((length >= 5) ? color_ : color_2);
			label_4.ForeColor = ((length >= 6) ? color_ : color_2);
			label_3.ForeColor = ((length >= 7) ? color_ : color_2);
			label_2.ForeColor = ((length >= 8) ? color_ : color_2);
		}
		else
		{
			label_0.ForeColor = color_2;
			label_1.ForeColor = color_2;
			label_9.ForeColor = color_2;
			label_8.ForeColor = color_2;
			label_7.ForeColor = color_2;
			label_6.ForeColor = color_2;
			label_5.ForeColor = color_2;
			label_4.ForeColor = color_2;
			label_3.ForeColor = color_2;
			label_2.ForeColor = color_2;
		}
		themedTextBox_0.Enabled = length >= 1 && enable;
		themedTextBox_1.Enabled = length >= 2 && enable;
		themedTextBox_2.Enabled = length >= 3 && enable;
		themedTextBox_3.Enabled = length >= 4 && enable;
		themedTextBox_4.Enabled = length >= 5 && enable;
		themedTextBox_5.Enabled = length >= 6 && enable;
		themedTextBox_6.Enabled = length >= 7 && enable;
		themedTextBox_7.Enabled = length >= 8 && enable;
	}

	public void UpdateValue(long val)
	{
		byte[] bytes = BitConverter.GetBytes(val);
		if (bytes.Length == 8)
		{
			themedTextBox_0.Text = bytes[0].ToString(Class333.smethod_103());
			themedTextBox_1.Text = bytes[1].ToString(Class333.smethod_103());
			themedTextBox_2.Text = bytes[2].ToString(Class333.smethod_103());
			themedTextBox_3.Text = bytes[3].ToString(Class333.smethod_103());
			themedTextBox_4.Text = bytes[4].ToString(Class333.smethod_103());
			themedTextBox_5.Text = bytes[5].ToString(Class333.smethod_103());
			themedTextBox_6.Text = bytes[6].ToString(Class333.smethod_103());
			themedTextBox_7.Text = bytes[7].ToString(Class333.smethod_103());
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

	private void method_0()
	{
		tableLayoutPanel_0 = new TableLayoutPanel();
		label_1 = new Label();
		tableLayoutPanel_1 = new TableLayoutPanel();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		label_6 = new Label();
		label_7 = new Label();
		label_8 = new Label();
		label_9 = new Label();
		themedTextBox_0 = new ThemedTextBox();
		themedTextBox_1 = new ThemedTextBox();
		themedTextBox_2 = new ThemedTextBox();
		themedTextBox_3 = new ThemedTextBox();
		themedTextBox_4 = new ThemedTextBox();
		themedTextBox_5 = new ThemedTextBox();
		themedTextBox_6 = new ThemedTextBox();
		themedTextBox_7 = new ThemedTextBox();
		label_0 = new Label();
		tableLayoutPanel_0.SuspendLayout();
		tableLayoutPanel_1.SuspendLayout();
		SuspendLayout();
		tableLayoutPanel_0.ColumnCount = 2;
		tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116f));
		tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanel_0.Controls.Add(label_1, 0, 0);
		tableLayoutPanel_0.Controls.Add(tableLayoutPanel_1, 1, 0);
		tableLayoutPanel_0.Controls.Add(label_0, 0, 1);
		tableLayoutPanel_0.Dock = DockStyle.Fill;
		tableLayoutPanel_0.Location = new Point(0, 0);
		tableLayoutPanel_0.Margin = new Padding(0);
		tableLayoutPanel_0.Name = Class333.smethod_249();
		tableLayoutPanel_0.RowCount = 2;
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 44f));
		tableLayoutPanel_0.Size = new Size(472, 96);
		tableLayoutPanel_0.TabIndex = 0;
		label_1.Dock = DockStyle.Fill;
		label_1.Location = new Point(4, 0);
		label_1.Margin = new Padding(0);
		label_1.Name = Class333.smethod_250();
		label_1.Size = new Size(86, 52);
		label_1.TabIndex = 2;
		label_1.Text = Class333.smethod_251();
		label_1.TextAlign = ContentAlignment.MiddleCenter;
		tableLayoutPanel_1.ColumnCount = 8;
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55f));
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55f));
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55f));
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55f));
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55f));
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55f));
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55f));
		tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55f));
		tableLayoutPanel_1.Controls.Add(label_2, 7, 0);
		tableLayoutPanel_1.Controls.Add(label_3, 6, 0);
		tableLayoutPanel_1.Controls.Add(label_4, 5, 0);
		tableLayoutPanel_1.Controls.Add(label_5, 4, 0);
		tableLayoutPanel_1.Controls.Add(label_6, 3, 0);
		tableLayoutPanel_1.Controls.Add(label_7, 2, 0);
		tableLayoutPanel_1.Controls.Add(label_8, 1, 0);
		tableLayoutPanel_1.Controls.Add(label_9, 0, 0);
		tableLayoutPanel_1.Controls.Add(themedTextBox_0, 0, 1);
		tableLayoutPanel_1.Controls.Add(themedTextBox_1, 1, 1);
		tableLayoutPanel_1.Controls.Add(themedTextBox_2, 2, 1);
		tableLayoutPanel_1.Controls.Add(themedTextBox_3, 3, 1);
		tableLayoutPanel_1.Controls.Add(themedTextBox_4, 4, 1);
		tableLayoutPanel_1.Controls.Add(themedTextBox_5, 5, 1);
		tableLayoutPanel_1.Controls.Add(themedTextBox_6, 6, 1);
		tableLayoutPanel_1.Controls.Add(themedTextBox_7, 7, 1);
		tableLayoutPanel_1.Dock = DockStyle.Fill;
		tableLayoutPanel_1.Location = new Point(94, 0);
		tableLayoutPanel_1.Margin = new Padding(0);
		tableLayoutPanel_1.Name = Class333.smethod_252();
		tableLayoutPanel_1.RowCount = 2;
		tableLayoutPanel_0.SetRowSpan(tableLayoutPanel_1, 2);
		tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44f));
		tableLayoutPanel_1.Size = new Size(378, 96);
		tableLayoutPanel_1.TabIndex = 1;
		label_2.AutoSize = false;
		label_2.Location = new Point(332, 0);
		label_2.Margin = new Padding(0);
		label_2.Name = Class333.smethod_253();
		label_2.Size = new Size(39, 52);
		label_2.TabIndex = 15;
		label_2.Text = Class333.smethod_254();
		label_2.TextAlign = ContentAlignment.MiddleCenter;
		label_3.AutoSize = false;
		label_3.Location = new Point(285, 0);
		label_3.Margin = new Padding(0);
		label_3.Name = Class333.smethod_255();
		label_3.Size = new Size(39, 52);
		label_3.TabIndex = 14;
		label_3.Text = Class333.smethod_256();
		label_3.TextAlign = ContentAlignment.MiddleCenter;
		label_4.AutoSize = false;
		label_4.Location = new Point(238, 0);
		label_4.Margin = new Padding(0);
		label_4.Name = Class333.smethod_257();
		label_4.Size = new Size(39, 52);
		label_4.TabIndex = 13;
		label_4.Text = Class333.smethod_258();
		label_4.TextAlign = ContentAlignment.MiddleCenter;
		label_5.AutoSize = false;
		label_5.Location = new Point(191, 0);
		label_5.Margin = new Padding(0);
		label_5.Name = Class333.smethod_259();
		label_5.Size = new Size(39, 52);
		label_5.TabIndex = 12;
		label_5.Text = Class333.smethod_260();
		label_5.TextAlign = ContentAlignment.MiddleCenter;
		label_6.AutoSize = false;
		label_6.Location = new Point(144, 0);
		label_6.Margin = new Padding(0);
		label_6.Name = Class333.smethod_261();
		label_6.Size = new Size(39, 52);
		label_6.TabIndex = 11;
		label_6.Text = Class333.smethod_262();
		label_6.TextAlign = ContentAlignment.MiddleCenter;
		label_7.AutoSize = false;
		label_7.Location = new Point(97, 0);
		label_7.Margin = new Padding(0);
		label_7.Name = Class333.smethod_263();
		label_7.Size = new Size(39, 52);
		label_7.TabIndex = 10;
		label_7.Text = Class333.smethod_264();
		label_7.TextAlign = ContentAlignment.MiddleCenter;
		label_8.AutoSize = false;
		label_8.Location = new Point(50, 0);
		label_8.Margin = new Padding(0);
		label_8.Name = Class333.smethod_265();
		label_8.Size = new Size(39, 52);
		label_8.TabIndex = 9;
		label_8.Text = Class333.smethod_227();
		label_8.TextAlign = ContentAlignment.MiddleCenter;
		label_9.AutoSize = false;
		label_9.Location = new Point(3, 0);
		label_9.Margin = new Padding(0);
		label_9.Name = Class333.smethod_266();
		label_9.Size = new Size(39, 52);
		label_9.TabIndex = 8;
		label_9.Text = Class333.smethod_184();
		label_9.TextAlign = ContentAlignment.MiddleCenter;
		themedTextBox_0.Location = new Point(4, 57);
		themedTextBox_0.Margin = new Padding(0);
		themedTextBox_0.Name = Class333.smethod_267();
		themedTextBox_0.ReadOnly = true;
		themedTextBox_0.Size = new Size(38, 29);
		themedTextBox_0.TabIndex = 0;
		themedTextBox_0.Text = Class333.smethod_186();
		themedTextBox_0.TextAlign = HorizontalAlignment.Center;
		themedTextBox_1.Location = new Point(51, 57);
		themedTextBox_1.Margin = new Padding(0);
		themedTextBox_1.Name = Class333.smethod_268();
		themedTextBox_1.ReadOnly = true;
		themedTextBox_1.Size = new Size(38, 29);
		themedTextBox_1.TabIndex = 1;
		themedTextBox_1.Text = Class333.smethod_186();
		themedTextBox_1.TextAlign = HorizontalAlignment.Center;
		themedTextBox_2.Location = new Point(98, 57);
		themedTextBox_2.Margin = new Padding(0);
		themedTextBox_2.Name = Class333.smethod_269();
		themedTextBox_2.ReadOnly = true;
		themedTextBox_2.Size = new Size(38, 29);
		themedTextBox_2.TabIndex = 2;
		themedTextBox_2.Text = Class333.smethod_186();
		themedTextBox_2.TextAlign = HorizontalAlignment.Center;
		themedTextBox_3.Location = new Point(145, 57);
		themedTextBox_3.Margin = new Padding(0);
		themedTextBox_3.Name = Class333.smethod_270();
		themedTextBox_3.ReadOnly = true;
		themedTextBox_3.Size = new Size(38, 29);
		themedTextBox_3.TabIndex = 3;
		themedTextBox_3.Text = Class333.smethod_186();
		themedTextBox_3.TextAlign = HorizontalAlignment.Center;
		themedTextBox_4.Location = new Point(192, 57);
		themedTextBox_4.Margin = new Padding(0);
		themedTextBox_4.Name = Class333.smethod_271();
		themedTextBox_4.ReadOnly = true;
		themedTextBox_4.Size = new Size(38, 29);
		themedTextBox_4.TabIndex = 4;
		themedTextBox_4.Text = Class333.smethod_186();
		themedTextBox_4.TextAlign = HorizontalAlignment.Center;
		themedTextBox_5.Location = new Point(239, 57);
		themedTextBox_5.Margin = new Padding(0);
		themedTextBox_5.Name = Class333.smethod_272();
		themedTextBox_5.ReadOnly = true;
		themedTextBox_5.Size = new Size(38, 29);
		themedTextBox_5.TabIndex = 5;
		themedTextBox_5.Text = Class333.smethod_186();
		themedTextBox_5.TextAlign = HorizontalAlignment.Center;
		themedTextBox_6.Location = new Point(286, 57);
		themedTextBox_6.Margin = new Padding(0);
		themedTextBox_6.Name = Class333.smethod_273();
		themedTextBox_6.ReadOnly = true;
		themedTextBox_6.Size = new Size(38, 29);
		themedTextBox_6.TabIndex = 6;
		themedTextBox_6.Text = Class333.smethod_186();
		themedTextBox_6.TextAlign = HorizontalAlignment.Center;
		themedTextBox_7.Location = new Point(333, 57);
		themedTextBox_7.Margin = new Padding(0);
		themedTextBox_7.Name = Class333.smethod_274();
		themedTextBox_7.ReadOnly = true;
		themedTextBox_7.Size = new Size(38, 29);
		themedTextBox_7.TabIndex = 7;
		themedTextBox_7.Text = Class333.smethod_186();
		themedTextBox_7.TextAlign = HorizontalAlignment.Center;
		label_0.Dock = DockStyle.Fill;
		label_0.Location = new Point(4, 52);
		label_0.Margin = new Padding(0);
		label_0.Name = Class333.smethod_275();
		label_0.Size = new Size(86, 44);
		label_0.TabIndex = 0;
		label_0.Text = Class333.smethod_276();
		label_0.TextAlign = ContentAlignment.MiddleCenter;
		AutoScaleDimensions = new SizeF(9f, 23f);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(tableLayoutPanel_0);
		Margin = new Padding(0);
		Name = Class333.smethod_277();
		Size = new Size(472, 96);
		tableLayoutPanel_0.ResumeLayout(performLayout: false);
		tableLayoutPanel_1.ResumeLayout(performLayout: false);
		tableLayoutPanel_1.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
