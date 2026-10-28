using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NSP.Resources;
using ns0;
using ns4;
using ns7;

namespace NSP.UserInterface;

public class StartupOptionsPanel : UserControl
{
	private IContainer icontainer_0;

	private LinkLabel linkLabel_0;

	private LinkLabel linkLabel_1;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	private Label label_9;

	private Label label_10;

	private Label label_11;

	private Label label_12;

	private Label label_13;

	private PictureBox pictureBox_0;

	private PictureBox pictureBox_1;

	private PictureBox pictureBox_2;

	public new BorderStyle BorderStyle
	{
		get
		{
			return BorderStyle.None;
		}
		set
		{
		}
	}

	public StartupOptionsPanel()
	{
		method_1();
	}

	internal void method_0()
	{
		BackColor = Form23.color_17;
		ForeColor = Form23.color_12;
		foreach (Control control in Controls)
		{
			if (control is LinkLabel)
			{
				(control as LinkLabel).LinkColor = Form23.color_12;
			}
			else if (control is Label)
			{
				(control as Label).ForeColor = Form23.color_12;
			}
		}
		label_4.ForeColor = Form23.color_14;
		Image image = pictureBox_2.Image;
		pictureBox_2.Image = Class25.smethod_0(GeneralResources.IconBasicUSB, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		image?.Dispose();
		Image image2 = pictureBox_0.Image;
		pictureBox_0.Image = Class25.smethod_0(GeneralResources.IconNewMap, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		image2?.Dispose();
		Image image3 = pictureBox_1.Image;
		pictureBox_1.Image = Class25.smethod_0(GeneralResources.IconOpenMap, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		image3?.Dispose();
	}

	protected override void OnPaintBackground(PaintEventArgs paintEventArgs_0)
	{
		paintEventArgs_0.Graphics.Clear(Form23.color_10);
		paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		using GraphicsPath path = ThemedButton.smethod_0(new Rectangle(0, 0, Width - 1, Height - 1), 7);
		using Brush brush = new SolidBrush(Form23.color_17);
		paintEventArgs_0.Graphics.FillPath(brush, path);
	}

	private void StartupOptionsPanel_VisibleChanged(object sender, EventArgs e)
	{
		if (Visible)
		{
			method_0();
		}
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Form23.form23_0.toolStripButton_0_Click(null, null);
	}

	private void linkLabel_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Form23.form23_0.toolStripButton_6_Click(null, null);
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Form23.form23_0.toolStripButton_0_Click(null, null);
	}

	private void pictureBox_1_Click(object sender, EventArgs e)
	{
		Form23.form23_0.toolStripButton_6_Click(null, null);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_1()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(StartupOptionsPanel));
		linkLabel_0 = new LinkLabel();
		linkLabel_1 = new LinkLabel();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		label_6 = new Label();
		label_7 = new Label();
		label_8 = new Label();
		label_9 = new Label();
		label_10 = new Label();
		label_11 = new Label();
		label_12 = new Label();
		label_13 = new Label();
		pictureBox_0 = new PictureBox();
		pictureBox_1 = new PictureBox();
		pictureBox_2 = new PictureBox();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)pictureBox_1).BeginInit();
		((ISupportInitialize)pictureBox_2).BeginInit();
		SuspendLayout();
		linkLabel_0.AutoSize = true;
		linkLabel_0.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		linkLabel_0.Location = new Point(162, 134);
		linkLabel_0.Name = Class333.smethod_614();
		linkLabel_0.Size = new Size(222, 21);
		linkLabel_0.TabIndex = 0;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class333.smethod_615();
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		linkLabel_1.AutoSize = true;
		linkLabel_1.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		linkLabel_1.Location = new Point(162, 209);
		linkLabel_1.Name = Class333.smethod_616();
		linkLabel_1.Size = new Size(273, 21);
		linkLabel_1.TabIndex = 1;
		linkLabel_1.TabStop = true;
		linkLabel_1.Text = Class333.smethod_617();
		linkLabel_1.LinkClicked += linkLabel_1_LinkClicked;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.Location = new Point(79, 156);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(272, 21);
		label_0.TabIndex = 2;
		label_0.Text = Class333.smethod_619();
		label_1.AutoSize = true;
		label_1.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_1.Location = new Point(79, 231);
		label_1.Name = Class333.smethod_620();
		label_1.Size = new Size(272, 21);
		label_1.TabIndex = 3;
		label_1.Text = Class333.smethod_619();
		label_2.AutoSize = true;
		label_2.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_2.Location = new Point(79, 209);
		label_2.Name = Class333.smethod_621();
		label_2.Size = new Size(80, 21);
		label_2.TabIndex = 4;
		label_2.Text = Class333.smethod_622();
		label_3.AutoSize = true;
		label_3.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_3.Location = new Point(79, 81);
		label_3.Name = Class333.smethod_623();
		label_3.Size = new Size(452, 21);
		label_3.TabIndex = 5;
		label_3.Text = Class333.smethod_624();
		label_4.AutoSize = true;
		label_4.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_4.Location = new Point(16, 14);
		label_4.Name = Class333.smethod_625();
		label_4.Size = new Size(219, 21);
		label_4.TabIndex = 8;
		label_4.Text = Class333.smethod_626();
		label_5.AutoSize = true;
		label_5.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_5.Location = new Point(79, 59);
		label_5.Name = Class333.smethod_627();
		label_5.Size = new Size(80, 21);
		label_5.TabIndex = 9;
		label_5.Text = Class333.smethod_628();
		label_6.AutoSize = true;
		label_6.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_6.Location = new Point(79, 134);
		label_6.Name = Class333.smethod_629();
		label_6.Size = new Size(80, 21);
		label_6.TabIndex = 10;
		label_6.Text = Class333.smethod_630();
		label_7.AutoSize = true;
		label_7.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_7.Location = new Point(162, 59);
		label_7.Name = Class333.smethod_631();
		label_7.Size = new Size(210, 21);
		label_7.TabIndex = 11;
		label_7.Text = Class333.smethod_632();
		label_8.AutoSize = true;
		label_8.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Italic, GraphicsUnit.Point, 0);
		label_8.Location = new Point(347, 156);
		label_8.Name = Class333.smethod_633();
		label_8.Size = new Size(34, 21);
		label_8.TabIndex = 12;
		label_8.Text = Class333.smethod_634();
		label_9.AutoSize = true;
		label_9.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Italic, GraphicsUnit.Point, 0);
		label_9.Location = new Point(347, 231);
		label_9.Name = Class333.smethod_635();
		label_9.Size = new Size(34, 21);
		label_9.TabIndex = 13;
		label_9.Text = Class333.smethod_634();
		label_10.AutoSize = true;
		label_10.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Italic, GraphicsUnit.Point, 0);
		label_10.Location = new Point(488, 156);
		label_10.Name = Class333.smethod_636();
		label_10.Size = new Size(45, 21);
		label_10.TabIndex = 14;
		label_10.Text = Class333.smethod_637();
		label_11.AutoSize = true;
		label_11.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Italic, GraphicsUnit.Point, 0);
		label_11.Location = new Point(488, 231);
		label_11.Name = Class333.smethod_638();
		label_11.Size = new Size(51, 21);
		label_11.TabIndex = 15;
		label_11.Text = Class333.smethod_639();
		label_12.AutoSize = true;
		label_12.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_12.Location = new Point(377, 156);
		label_12.Name = Class333.smethod_640();
		label_12.Size = new Size(115, 21);
		label_12.TabIndex = 16;
		label_12.Text = Class333.smethod_641();
		label_13.AutoSize = true;
		label_13.Font = new Font(Class333.smethod_145(), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_13.Location = new Point(377, 231);
		label_13.Name = Class333.smethod_642();
		label_13.Size = new Size(115, 21);
		label_13.TabIndex = 17;
		label_13.Text = Class333.smethod_641();
		pictureBox_0.BackColor = Color.Transparent;
		pictureBox_0.Cursor = Cursors.Hand;
		pictureBox_0.Image = (Image)componentResourceManager.GetObject(Class333.smethod_643());
		pictureBox_0.Location = new Point(20, 134);
		pictureBox_0.Name = Class333.smethod_644();
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox_0.TabIndex = 18;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		pictureBox_1.BackColor = Color.Transparent;
		pictureBox_1.Cursor = Cursors.Hand;
		pictureBox_1.Image = (Image)componentResourceManager.GetObject(Class333.smethod_645());
		pictureBox_1.Location = new Point(20, 209);
		pictureBox_1.Name = Class333.smethod_646();
		pictureBox_1.Size = new Size(48, 48);
		pictureBox_1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox_1.TabIndex = 19;
		pictureBox_1.TabStop = false;
		pictureBox_1.Click += pictureBox_1_Click;
		pictureBox_2.BackColor = Color.Transparent;
		pictureBox_2.Image = (Image)componentResourceManager.GetObject(Class333.smethod_647());
		pictureBox_2.Location = new Point(20, 59);
		pictureBox_2.Name = Class333.smethod_648();
		pictureBox_2.Size = new Size(48, 48);
		pictureBox_2.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox_2.TabIndex = 20;
		pictureBox_2.TabStop = false;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(pictureBox_2);
		Controls.Add(pictureBox_1);
		Controls.Add(pictureBox_0);
		Controls.Add(label_13);
		Controls.Add(label_12);
		Controls.Add(label_11);
		Controls.Add(label_10);
		Controls.Add(label_9);
		Controls.Add(label_8);
		Controls.Add(label_7);
		Controls.Add(label_6);
		Controls.Add(label_5);
		Controls.Add(label_4);
		Controls.Add(label_3);
		Controls.Add(label_2);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Controls.Add(linkLabel_1);
		Controls.Add(linkLabel_0);
		DoubleBuffered = true;
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Name = Class333.smethod_649();
		Size = new Size(549, 275);
		VisibleChanged += StartupOptionsPanel_VisibleChanged;
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)pictureBox_1).EndInit();
		((ISupportInitialize)pictureBox_2).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
