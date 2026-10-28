using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NSP.UserInterface;
using ns2;
using ns4;
using ns7;

namespace ns5;

internal class Form60 : Form
{
	private bool aBp;

	private IContainer aBQ;

	private Class148 aBq;

	private ThemedButton aBR;

	private PictureBox aBr;

	private LinkLabel aBS;

	private Label aBs;

	internal Form60()
	{
		method_0();
		BackColor = Form23.color_10;
		foreach (Control control in Controls)
		{
			if (control is LinkLabel)
			{
				(control as LinkLabel).LinkColor = Form23.color_12;
			}
			else if (control is Label || control is Class148)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		aBq.Checked = Form23.form23_0.statsReporter_0.UserOptInPrivacy;
	}

	private void aBR_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void aBq_CheckedChanged(object sender, EventArgs e)
	{
		aBp = aBq.Checked;
	}

	private void Form60_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form23.form23_0.statsReporter_0.UserOptInPrivacy = aBp;
		if (aBp)
		{
			Form23.form23_0.statsReporter_0.LastAgreedPrivacyDocumentVer = Form15.smethod_0();
		}
		else if (Form23.form23_0.statsReporter_0.LastAgreedPrivacyDocVerRegistryEntryExists())
		{
			Form23.form23_0.statsReporter_0.DeleteLastAgreedPrivacyDocVerRegistryEntry();
		}
		Form23.form23_0.method_24();
	}

	private void aBS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Form15 form = new Form15();
		form.ShowDialog(this);
		form.Dispose();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && aBQ != null)
		{
			aBQ.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_0()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form60));
		aBq = new Class148();
		aBR = new ThemedButton();
		aBr = new PictureBox();
		aBS = new LinkLabel();
		aBs = new Label();
		((ISupportInitialize)aBr).BeginInit();
		SuspendLayout();
		aBq.AutoSize = true;
		aBq.Location = new Point(13, 64);
		aBq.Name = Class333.aBR();
		aBq.Size = new Size(240, 17);
		aBq.TabIndex = 1;
		aBq.Text = Class333.aBr();
		aBq.UseVisualStyleBackColor = true;
		aBq.CheckedChanged += aBq_CheckedChanged;
		aBR.Location = new Point(96, 89);
		aBR.Name = Class333.smethod_718();
		aBR.Size = new Size(75, 23);
		aBR.TabIndex = 2;
		aBR.Text = Class333.smethod_719();
		aBR.UseVisualStyleBackColor = true;
		aBR.Click += aBR_Click;
		aBr.BackColor = Color.Transparent;
		aBr.Image = (Image)componentResourceManager.GetObject(Class333.smethod_720());
		aBr.Location = new Point(136, 12);
		aBr.Name = Class333.smethod_721();
		aBr.Size = new Size(107, 20);
		aBr.SizeMode = PictureBoxSizeMode.AutoSize;
		aBr.TabIndex = 11;
		aBr.TabStop = false;
		aBS.AutoSize = true;
		aBS.Location = new Point(185, 41);
		aBS.Name = Class333.aBS();
		aBS.Size = new Size(75, 13);
		aBS.TabIndex = 13;
		aBS.TabStop = true;
		aBS.Text = Class333.smethod_1103();
		aBS.LinkClicked += aBS_LinkClicked;
		aBs.AutoSize = true;
		aBs.Location = new Point(7, 41);
		aBs.Name = Class333.smethod_618();
		aBs.Size = new Size(180, 13);
		aBs.TabIndex = 14;
		aBs.Text = Class333.aBs();
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		AutoScroll = true;
		AutoSize = true;
		ClientSize = new Size(264, 118);
		Controls.Add(aBs);
		Controls.Add(aBS);
		Controls.Add(aBr);
		Controls.Add(aBR);
		Controls.Add(aBq);
		Font = new Font(Class333.smethod_145(), 8.25f);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.aBT();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1640();
		FormClosing += Form60_FormClosing;
		((ISupportInitialize)aBr).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
