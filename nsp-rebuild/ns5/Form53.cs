using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns3;
using ns4;
using ns7;

namespace ns5;

internal class Form53 : Form
{
	private bool aAA;

	private float[] aAa = new float[17]
	{
		6f, 6.5f, 7f, 7.5f, 8f, 8.5f, 9f, 9.5f, 10f, 11f,
		12f, 13f, 14f, 15f, 16f, 17f, 18f
	};

	private IContainer aAB;

	private ThemedComboBox aAb;

	private Label aAC;

	private ThemedButton aAc;

	private Label aAD;

	private ThemedComboBox aAd;

	private Label aAE;

	private ThemedComboBox aAe;

	private Label aAF;

	private ThemedComboBox aAf;

	internal Form53()
	{
		aAA = true;
		method_0();
		BackColor = Form23.color_11;
		foreach (Control control in Controls)
		{
			if (control is Label)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		aAb.SelectedIndex = (int)Class104.Bve;
		int selectedIndex = -1;
		for (int i = 0; i < aAa.Length; i++)
		{
			float num = aAa[i];
			aAd.Items.Add(num.ToString());
			if (Class104.Bvd > num - 0.0001f && Class104.Bvd < num + 0.0001f)
			{
				selectedIndex = i;
			}
		}
		aAd.SelectedIndex = selectedIndex;
		aAe.SelectedIndex = (int)Class104.BvF;
		aAf.SelectedIndex = (int)Class104.BvE;
		aAA = false;
	}

	private void aAb_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!aAA && aAb.SelectedIndex != -1)
		{
			Class104.Bve = (Enum69)aAb.SelectedIndex;
			Form23.form23_0.control25_0.method_19();
		}
	}

	private void aAd_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!aAA && aAd.SelectedIndex != -1)
		{
			Form23.form23_0.control25_0.method_18(aAa[aAd.SelectedIndex]);
		}
	}

	private void aAe_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!aAA && aAe.SelectedIndex != -1)
		{
			Class104.BvF = (Class104.Bvf = (Enum70)aAe.SelectedIndex);
			Form23.form23_0.control25_0.method_20();
		}
	}

	private void aAf_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (aAA || aAf.SelectedIndex == -1)
		{
			return;
		}
		Class104.BvE = (Enum71)aAf.SelectedIndex;
		if (Form23.framework_1 == null || !Form23.framework_1.method_5())
		{
			return;
		}
		foreach (Table item in Form23.framework_1.aWV)
		{
			switch (Class104.BvE)
			{
			case Enum71.const_1:
				if (item.InvertRows)
				{
					item.InvertRows = false;
				}
				break;
			case Enum71.const_0:
				if (!item.InvertRows)
				{
					item.InvertRows = true;
				}
				break;
			}
		}
	}

	private void aAc_Click(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && aAB != null)
		{
			aAB.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_0()
	{
		aAb = new ThemedComboBox();
		aAC = new Label();
		aAc = new ThemedButton();
		aAD = new Label();
		aAd = new ThemedComboBox();
		aAE = new Label();
		aAe = new ThemedComboBox();
		aAF = new Label();
		aAf = new ThemedComboBox();
		SuspendLayout();
		aAb.DrawMode = DrawMode.OwnerDrawFixed;
		aAb.DropDownStyle = ComboBoxStyle.DropDownList;
		aAb.FormattingEnabled = true;
		aAb.Items.AddRange(Class333.smethod_836(), Class333.aAM(), Class333.aAm(), Class333.aAN());
		aAb.Location = new Point(183, 12);
		aAb.Name = Class333.aAn();
		aAb.Size = new Size(240, 23);
		aAb.TabIndex = 0;
		aAb.SelectedIndexChanged += aAb_SelectedIndexChanged;
		aAC.AutoSize = true;
		aAC.Location = new Point(7, 16);
		aAC.Name = Class333.smethod_618();
		aAC.Size = new Size(102, 13);
		aAC.TabIndex = 3;
		aAC.Text = Class333.aAO();
		aAc.DialogResult = DialogResult.Cancel;
		aAc.Location = new Point(165, 138);
		aAc.Name = Class333.smethod_718();
		aAc.Size = new Size(105, 34);
		aAc.TabIndex = 4;
		aAc.Text = Class333.smethod_719();
		aAc.UseVisualStyleBackColor = true;
		aAc.Click += aAc_Click;
		aAD.AutoSize = true;
		aAD.Location = new Point(7, 47);
		aAD.Name = Class333.smethod_620();
		aAD.Size = new Size(143, 13);
		aAD.TabIndex = 4;
		aAD.Text = Class333.aAo();
		aAd.DrawMode = DrawMode.OwnerDrawFixed;
		aAd.DropDownStyle = ComboBoxStyle.DropDownList;
		aAd.FormattingEnabled = true;
		aAd.Location = new Point(183, 43);
		aAd.Name = Class333.aAP();
		aAd.Size = new Size(240, 23);
		aAd.TabIndex = 1;
		aAd.SelectedIndexChanged += aAd_SelectedIndexChanged;
		aAE.AutoSize = true;
		aAE.Location = new Point(7, 78);
		aAE.Name = Class333.smethod_621();
		aAE.Size = new Size(172, 13);
		aAE.TabIndex = 8;
		aAE.Text = Class333.aAp();
		aAe.DrawMode = DrawMode.OwnerDrawFixed;
		aAe.DropDownStyle = ComboBoxStyle.DropDownList;
		aAe.FormattingEnabled = true;
		aAe.Items.AddRange(Class333.aAQ(), Class333.aAq());
		aAe.Location = new Point(183, 74);
		aAe.Name = Class333.aAR();
		aAe.Size = new Size(240, 23);
		aAe.TabIndex = 2;
		aAe.SelectedIndexChanged += aAe_SelectedIndexChanged;
		aAF.AutoSize = true;
		aAF.Location = new Point(7, 109);
		aAF.Name = Class333.smethod_623();
		aAF.Size = new Size(107, 13);
		aAF.TabIndex = 12;
		aAF.Text = Class333.aAr();
		aAf.DrawMode = DrawMode.OwnerDrawFixed;
		aAf.DropDownStyle = ComboBoxStyle.DropDownList;
		aAf.FormattingEnabled = true;
		aAf.Items.AddRange(Class333.aAS(), Class333.aAs());
		aAf.Location = new Point(182, 105);
		aAf.Name = Class333.aAT();
		aAf.Size = new Size(240, 23);
		aAf.TabIndex = 3;
		aAf.SelectedIndexChanged += aAf_SelectedIndexChanged;
		AcceptButton = aAc;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = aAc;
		ClientSize = new Size(434, 183);
		Controls.Add(aAf);
		Controls.Add(aAF);
		Controls.Add(aAE);
		Controls.Add(aAe);
		Controls.Add(aAD);
		Controls.Add(aAd);
		Controls.Add(aAc);
		Controls.Add(aAC);
		Controls.Add(aAb);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.aAt();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1626();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
