using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NSP.UserInterface;
using ns2;
using ns4;
using ns7;

namespace ns5;

internal class Form57 : Form
{
	private bool aBe;

	private float[] aBF = new float[17]
	{
		6f, 6.5f, 7f, 7.5f, 8f, 8.5f, 9f, 9.5f, 10f, 11f,
		12f, 13f, 14f, 15f, 16f, 17f, 18f
	};

	private IContainer aBf;

	private ThemedComboBox aBG;

	private Label aBg;

	private ThemedButton aBH;

	private Label aBh;

	private ThemedComboBox aBI;

	private Class148 aBi;

	internal Form57()
	{
		aBe = true;
		method_0();
		BackColor = Form23.color_11;
		aBi.ForeColor = Form23.color_12;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		aBG.SelectedIndex = (int)Form23.form23_0.control4_0.method_0().method_0();
		int selectedIndex = -1;
		for (int i = 0; i < aBF.Length; i++)
		{
			float num = aBF[i];
			aBI.Items.Add(num.ToString());
			if (Form23.form23_0.control4_0.method_0().Font.Size > num - 0.0001f && Form23.form23_0.control4_0.method_0().Font.Size < num + 0.0001f)
			{
				selectedIndex = i;
			}
		}
		aBI.SelectedIndex = selectedIndex;
		aBi.Checked = !Form23.form23_0.control4_0.method_5();
		aBe = false;
	}

	private void aBG_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!aBe && aBG.SelectedIndex != -1)
		{
			Form23.form23_0.control4_0.method_0().method_1((Enum45)aBG.SelectedIndex);
		}
	}

	private void aBI_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!aBe && aBI.SelectedIndex != -1)
		{
			Form23.form23_0.control4_0.method_0().Font = new Font(Form23.form23_0.control4_0.method_0().Font.FontFamily, aBF[aBI.SelectedIndex]);
		}
	}

	private void aBi_CheckedChanged(object sender, EventArgs e)
	{
		if (!aBe)
		{
			Form23.form23_0.control4_0.method_6(!aBi.Checked);
			Form23.form23_0.control4_0.method_14(bool_7: true, bool_8: false, bool_9: false, bool_10: false);
			Form23.form23_0.control4_0.method_39(bool_7: false);
			if (Form23.framework_0 != null)
			{
				Form23.form23_0.control4_0.method_40(bool_7: false);
			}
		}
	}

	private void aBH_Click(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && aBf != null)
		{
			aBf.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_0()
	{
		aBG = new ThemedComboBox();
		aBg = new Label();
		aBH = new ThemedButton();
		aBh = new Label();
		aBI = new ThemedComboBox();
		aBi = new Class148();
		SuspendLayout();
		aBG.DrawMode = DrawMode.OwnerDrawFixed;
		aBG.DropDownStyle = ComboBoxStyle.DropDownList;
		aBG.FormattingEnabled = true;
		aBG.Items.AddRange(Class333.aBE(), Class333.aBe(), Class333.aBF());
		aBG.Location = new Point(176, 11);
		aBG.Name = Class333.aBf();
		aBG.Size = new Size(152, 23);
		aBG.TabIndex = 0;
		aBG.SelectedIndexChanged += aBG_SelectedIndexChanged;
		aBg.AutoSize = true;
		aBg.Location = new Point(10, 15);
		aBg.Name = Class333.smethod_618();
		aBg.Size = new Size(163, 13);
		aBg.TabIndex = 3;
		aBg.Text = Class333.aBG();
		aBH.DialogResult = DialogResult.Cancel;
		aBH.Location = new Point(126, 99);
		aBH.Name = Class333.smethod_718();
		aBH.Size = new Size(105, 34);
		aBH.TabIndex = 3;
		aBH.Text = Class333.smethod_719();
		aBH.UseVisualStyleBackColor = true;
		aBH.Click += aBH_Click;
		aBh.AutoSize = true;
		aBh.Location = new Point(10, 45);
		aBh.Name = Class333.smethod_620();
		aBh.Size = new Size(140, 13);
		aBh.TabIndex = 4;
		aBh.Text = Class333.aBg();
		aBI.DrawMode = DrawMode.OwnerDrawFixed;
		aBI.DropDownStyle = ComboBoxStyle.DropDownList;
		aBI.FormattingEnabled = true;
		aBI.Location = new Point(176, 41);
		aBI.Name = Class333.aAP();
		aBI.Size = new Size(152, 23);
		aBI.TabIndex = 1;
		aBI.SelectedIndexChanged += aBI_SelectedIndexChanged;
		aBi.AutoSize = true;
		aBi.Location = new Point(12, 74);
		aBi.Name = Class333.aBH();
		aBi.Size = new Size(235, 17);
		aBi.TabIndex = 2;
		aBi.Text = Class333.aBh();
		aBi.UseVisualStyleBackColor = true;
		aBi.CheckedChanged += aBi_CheckedChanged;
		AcceptButton = aBH;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = aBH;
		ClientSize = new Size(343, 141);
		Controls.Add(aBi);
		Controls.Add(aBh);
		Controls.Add(aBI);
		Controls.Add(aBH);
		Controls.Add(aBg);
		Controls.Add(aBG);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.aBI();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_554();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
