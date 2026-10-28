using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NSP.UserInterface;
using ns2;
using ns4;
using ns7;

namespace ns5;

internal class Form55 : Form
{
	private bool aAM;

	private Timer aAm = new Timer();

	private IContainer aAN;

	private ThemedComboBox aAn;

	private Label aAO;

	private ThemedButton aAo;

	private Class148 aAP;

	private NumericUpDown aAp;

	private NumericUpDown aAQ;

	private Label aAq;

	private Label aAR;

	private Class148 aAr;

	private Label aAS;

	private ThemedComboBox aAs;

	private Label aAT;

	private ThemedButton aAt;

	private NumericUpDown aAU;

	private NumericUpDown aAu;

	private Label aAV;

	private Label aAv;

	private Class148 aAW;

	private Label aAw;

	private Class148 aAX;

	internal Form55()
	{
		aAM = true;
		method_1();
		BackColor = Form23.color_11;
		foreach (Control control in Controls)
		{
			if (control is Label || control is Class148)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		if ((int)Form23.enum62_0 < aAn.Items.Count)
		{
			aAn.SelectedIndex = (int)Form23.enum62_0;
		}
		aAP.Checked = Form23.bool_43;
		aAs.SelectedIndex = (int)Form23.enum63_1;
		aAr.Checked = Form23.bool_48;
		aAX.Checked = Form23.bool_49;
		aAQ.Value = Form23.int_44;
		aAp.Value = Form23.int_45;
		aAu.Value = Form23.int_46;
		aAU.Value = Form23.int_47;
		aAW.Checked = Form23.bool_50;
		aAm.Interval = 100;
		aAm.Tick += aAm_Tick;
		aAM = false;
	}

	private void Form55_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form23.form23_0.method_214();
	}

	private void aAn_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!aAM)
		{
			Form23.enum62_0 = (Form23.Enum62)aAn.SelectedIndex;
			Form23.bool_44 = true;
			aAm.Stop();
			aAm.Start();
		}
	}

	private void aAP_CheckedChanged(object sender, EventArgs e)
	{
		if (!aAM)
		{
			Form23.bool_43 = aAP.Checked;
			Form23.bool_44 = true;
			aAm.Stop();
			aAm.Start();
		}
	}

	private void aAm_Tick(object sender, EventArgs e)
	{
		switch (Form23.enum62_0)
		{
		case Form23.Enum62.Bqg:
			BackColor = Color.Black;
			foreach (Control control3 in Controls)
			{
				if (!(control3 is Label) && !(control3 is Class148))
				{
					if (control3 is ThemedComboBox)
					{
						control3.BackColor = Color.Black;
						control3.ForeColor = Color.White;
					}
				}
				else
				{
					control3.ForeColor = Color.White;
				}
				control3.Invalidate();
			}
			break;
		case Form23.Enum62.BqH:
			BackColor = Form23.color_1;
			foreach (Control control4 in Controls)
			{
				if (!(control4 is Label) && !(control4 is Class148))
				{
					if (control4 is ThemedComboBox)
					{
						control4.BackColor = Form23.color_4;
						control4.ForeColor = Color.White;
					}
				}
				else
				{
					control4.ForeColor = Color.White;
				}
				control4.Invalidate();
			}
			break;
		case Form23.Enum62.BqG:
		case Form23.Enum62.Bqh:
			BackColor = SystemColors.Control;
			foreach (Control control5 in Controls)
			{
				if (!(control5 is Label) && !(control5 is Class148))
				{
					if (control5 is ThemedComboBox)
					{
						control5.BackColor = Color.White;
						control5.ForeColor = Color.Black;
					}
				}
				else
				{
					control5.ForeColor = Color.Black;
				}
				control5.Invalidate();
			}
			break;
		}
		aAm.Stop();
	}

	private void aAs_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!aAM && aAs.SelectedIndex != -1)
		{
			Form23.enum63_1 = (Form23.Enum63)aAs.SelectedIndex;
			method_0();
		}
	}

	private void aAr_CheckedChanged(object sender, EventArgs e)
	{
		if (!aAM)
		{
			Form23.bool_48 = aAr.Checked;
			method_0();
		}
	}

	private void aAX_CheckedChanged(object sender, EventArgs e)
	{
		if (!aAM)
		{
			Form23.bool_49 = aAX.Checked;
			method_0();
		}
	}

	private void aAQ_ValueChanged(object sender, EventArgs e)
	{
		if (!aAM)
		{
			Form23.int_44 = (int)aAQ.Value;
			method_0();
		}
	}

	private void aAp_ValueChanged(object sender, EventArgs e)
	{
		if (!aAM)
		{
			Form23.int_45 = (int)aAp.Value;
			method_0();
		}
	}

	private void aAu_ValueChanged(object sender, EventArgs e)
	{
		if (!aAM)
		{
			Form23.int_46 = (int)aAu.Value;
			method_0();
		}
	}

	private void aAU_ValueChanged(object sender, EventArgs e)
	{
		if (!aAM)
		{
			Form23.int_47 = (int)aAU.Value;
			method_0();
		}
	}

	private void aAW_CheckedChanged(object sender, EventArgs e)
	{
		if (!aAM)
		{
			Form23.bool_50 = aAW.Checked;
			method_0();
		}
	}

	private void method_0()
	{
		Form23.form23_0.control25_0.method_20();
		Form23.form23_0.control25_0.method_22();
		Form23.form23_0.control25_0.method_21();
	}

	private void aAt_Click(object sender, EventArgs e)
	{
		if (!aAM)
		{
			aAs.SelectedIndex = 0;
			aAr.Checked = true;
			aAX.Checked = true;
			aAQ.Value = 90m;
			aAp.Value = 90m;
			aAu.Value = 0m;
			aAU.Value = 39m;
			aAW.Checked = false;
		}
	}

	private void aAo_Click(object sender, EventArgs e)
	{
		aAm.Tick -= aAm_Tick;
		aAm.Dispose();
		Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && aAN != null)
		{
			aAN.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_1()
	{
		aAn = new ThemedComboBox();
		aAO = new Label();
		aAo = new ThemedButton();
		aAP = new Class148();
		aAp = new NumericUpDown();
		aAQ = new NumericUpDown();
		aAq = new Label();
		aAR = new Label();
		aAr = new Class148();
		aAS = new Label();
		aAs = new ThemedComboBox();
		aAT = new Label();
		aAt = new ThemedButton();
		aAU = new NumericUpDown();
		aAu = new NumericUpDown();
		aAV = new Label();
		aAv = new Label();
		aAW = new Class148();
		aAw = new Label();
		aAX = new Class148();
		((ISupportInitialize)aAp).BeginInit();
		((ISupportInitialize)aAQ).BeginInit();
		((ISupportInitialize)aAU).BeginInit();
		((ISupportInitialize)aAu).BeginInit();
		SuspendLayout();
		aAn.DrawMode = DrawMode.OwnerDrawFixed;
		aAn.DropDownStyle = ComboBoxStyle.DropDownList;
		aAn.FormattingEnabled = true;
		aAn.Items.AddRange(Class333.aAW(), Class333.aAw(), Class333.aAX(), Class333.aAx());
		aAn.Location = new Point(106, 34);
		aAn.Name = Class333.aAY();
		aAn.Size = new Size(176, 23);
		aAn.TabIndex = 0;
		aAn.SelectedIndexChanged += aAn_SelectedIndexChanged;
		aAO.AutoSize = true;
		aAO.Location = new Point(12, 38);
		aAO.Name = Class333.smethod_618();
		aAO.Size = new Size(78, 13);
		aAO.TabIndex = 9;
		aAO.Text = Class333.aAy();
		aAo.DialogResult = DialogResult.Cancel;
		aAo.Location = new Point(101, 406);
		aAo.Name = Class333.smethod_718();
		aAo.Size = new Size(105, 34);
		aAo.TabIndex = 11;
		aAo.Text = Class333.smethod_719();
		aAo.UseVisualStyleBackColor = true;
		aAo.Click += aAo_Click;
		aAP.AutoSize = true;
		aAP.Location = new Point(14, 65);
		aAP.Name = Class333.aAZ();
		aAP.Size = new Size(147, 17);
		aAP.TabIndex = 1;
		aAP.Text = Class333.aAz();
		aAP.UseVisualStyleBackColor = true;
		aAP.CheckedChanged += aAP_CheckedChanged;
		aAp.BorderStyle = BorderStyle.FixedSingle;
		aAp.Font = new Font(Class333.smethod_145(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aAp.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
		aAp.Location = new Point(192, 284);
		aAp.Name = Class333.aaA();
		aAp.Size = new Size(90, 23);
		aAp.TabIndex = 7;
		aAp.Value = new decimal(new int[4] { 90, 0, 0, 0 });
		aAp.ValueChanged += aAp_ValueChanged;
		aAQ.BorderStyle = BorderStyle.FixedSingle;
		aAQ.Font = new Font(Class333.smethod_145(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aAQ.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
		aAQ.Location = new Point(192, 254);
		aAQ.Name = Class333.aaa();
		aAQ.Size = new Size(90, 23);
		aAQ.TabIndex = 6;
		aAQ.Value = new decimal(new int[4] { 90, 0, 0, 0 });
		aAQ.ValueChanged += aAQ_ValueChanged;
		aAq.AutoSize = true;
		aAq.Location = new Point(11, 287);
		aAq.Name = Class333.smethod_621();
		aAq.Size = new Size(147, 13);
		aAq.TabIndex = 26;
		aAq.Text = Class333.aaB();
		aAR.AutoSize = true;
		aAR.Location = new Point(11, 257);
		aAR.Name = Class333.smethod_620();
		aAR.Size = new Size(147, 13);
		aAR.TabIndex = 25;
		aAR.Text = Class333.aab();
		aAr.AutoSize = true;
		aAr.Checked = true;
		aAr.CheckState = CheckState.Checked;
		aAr.Location = new Point(15, 194);
		aAr.Name = Class333.aaC();
		aAr.Size = new Size(262, 17);
		aAr.TabIndex = 4;
		aAr.Text = Class333.aac();
		aAr.UseVisualStyleBackColor = true;
		aAr.CheckedChanged += aAr_CheckedChanged;
		aAS.AutoSize = true;
		aAS.Location = new Point(11, 165);
		aAS.Name = Class333.smethod_623();
		aAS.Size = new Size(143, 13);
		aAS.TabIndex = 24;
		aAS.Text = Class333.aaD();
		aAs.DrawMode = DrawMode.OwnerDrawFixed;
		aAs.DropDownStyle = ComboBoxStyle.DropDownList;
		aAs.FormattingEnabled = true;
		aAs.Items.AddRange(Class333.aAx(), Class333.smethod_1018(), Class333.aad());
		aAs.Location = new Point(172, 161);
		aAs.Name = Class333.aaE();
		aAs.Size = new Size(110, 23);
		aAs.TabIndex = 3;
		aAs.SelectedIndexChanged += aAs_SelectedIndexChanged;
		aAT.AutoSize = true;
		aAT.Font = new Font(Class333.smethod_145(), 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aAT.Location = new Point(11, 103);
		aAT.Name = Class333.smethod_862();
		aAT.Size = new Size(165, 17);
		aAT.TabIndex = 28;
		aAT.Text = Class333.aae();
		aAt.Location = new Point(13, 126);
		aAt.Name = Class333.aaF();
		aAt.Size = new Size(282, 27);
		aAt.TabIndex = 2;
		aAt.Text = Class333.aaf();
		aAt.UseVisualStyleBackColor = true;
		aAt.Click += aAt_Click;
		aAU.BorderStyle = BorderStyle.FixedSingle;
		aAU.Font = new Font(Class333.smethod_145(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aAU.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
		aAU.Location = new Point(192, 344);
		aAU.Name = Class333.aaG();
		aAU.Size = new Size(90, 23);
		aAU.TabIndex = 9;
		aAU.Value = new decimal(new int[4] { 39, 0, 0, 0 });
		aAU.ValueChanged += aAU_ValueChanged;
		aAu.BorderStyle = BorderStyle.FixedSingle;
		aAu.Font = new Font(Class333.smethod_145(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aAu.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
		aAu.Location = new Point(192, 314);
		aAu.Name = Class333.aag();
		aAu.Size = new Size(90, 23);
		aAu.TabIndex = 8;
		aAu.ValueChanged += aAu_ValueChanged;
		aAV.AutoSize = true;
		aAV.Location = new Point(11, 347);
		aAV.Name = Class333.smethod_864();
		aAV.Size = new Size(158, 13);
		aAV.TabIndex = 34;
		aAV.Text = Class333.aaH();
		aAv.AutoSize = true;
		aAv.Location = new Point(11, 317);
		aAv.Name = Class333.smethod_866();
		aAv.Size = new Size(154, 13);
		aAv.TabIndex = 33;
		aAv.Text = Class333.aah();
		aAW.AutoSize = true;
		aAW.Location = new Point(15, 376);
		aAW.Name = Class333.aaI();
		aAW.Size = new Size(139, 17);
		aAW.TabIndex = 10;
		aAW.Text = Class333.aai();
		aAW.UseVisualStyleBackColor = true;
		aAW.CheckedChanged += aAW_CheckedChanged;
		aAw.AutoSize = true;
		aAw.Font = new Font(Class333.smethod_145(), 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aAw.Location = new Point(11, 9);
		aAw.Name = Class333.smethod_627();
		aAw.Size = new Size(158, 17);
		aAw.TabIndex = 37;
		aAw.Text = Class333.aaJ();
		aAX.AutoSize = true;
		aAX.Checked = true;
		aAX.CheckState = CheckState.Checked;
		aAX.Location = new Point(15, 224);
		aAX.Name = Class333.aaj();
		aAX.Size = new Size(283, 17);
		aAX.TabIndex = 5;
		aAX.Text = Class333.aaK();
		aAX.UseVisualStyleBackColor = true;
		aAX.CheckedChanged += aAX_CheckedChanged;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = aAo;
		ClientSize = new Size(308, 449);
		Controls.Add(aAX);
		Controls.Add(aAw);
		Controls.Add(aAW);
		Controls.Add(aAU);
		Controls.Add(aAu);
		Controls.Add(aAV);
		Controls.Add(aAv);
		Controls.Add(aAt);
		Controls.Add(aAT);
		Controls.Add(aAp);
		Controls.Add(aAQ);
		Controls.Add(aAq);
		Controls.Add(aAR);
		Controls.Add(aAr);
		Controls.Add(aAS);
		Controls.Add(aAs);
		Controls.Add(aAP);
		Controls.Add(aAo);
		Controls.Add(aAO);
		Controls.Add(aAn);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.aak();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.aaL();
		FormClosing += Form55_FormClosing;
		((ISupportInitialize)aAp).EndInit();
		((ISupportInitialize)aAQ).EndInit();
		((ISupportInitialize)aAU).EndInit();
		((ISupportInitialize)aAu).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
