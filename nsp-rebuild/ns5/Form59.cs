using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSP.UserInterface;
using ns2;
using ns4;
using ns7;

namespace ns5;

internal class Form59 : Form
{
	private bool aBM;

	private IContainer aBm;

	private Class148 aBN;

	private Label aBn;

	private ThemedButton aBO;

	private ThemedButton aBo;

	private Class148 aBP;

	internal Form59()
	{
		aBM = true;
		method_0();
		BackColor = Form23.color_11;
		foreach (Control control in Controls)
		{
			if (control is Label || control is Class148)
			{
				control.ForeColor = Form23.color_12;
			}
		}
		try
		{
			if (Class229.smethod_3())
			{
				aBP.Enabled = true;
				if (Class229.smethod_7())
				{
					aBP.Checked = true;
				}
				else
				{
					aBP.Checked = false;
				}
			}
			else
			{
				aBP.Checked = false;
				aBP.Enabled = false;
			}
		}
		catch
		{
			aBP.Checked = false;
			aBP.Enabled = false;
		}
		aBN.Checked = smethod_2();
		aBM = false;
	}

	private void Form59_Shown(object sender, EventArgs e)
	{
		aBO.Focus();
	}

	private void aBO_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void aBo_Click(object sender, EventArgs e)
	{
		Form23.form23_0.class162_0_Click(null, null);
	}

	private void aBP_CheckedChanged(object sender, EventArgs e)
	{
		if (!aBM)
		{
			try
			{
				Class229.smethod_6();
			}
			catch
			{
				aBP.Checked = false;
				aBP.Enabled = false;
			}
		}
	}

	private void aBN_CheckedChanged(object sender, EventArgs e)
	{
		if (aBN.Checked)
		{
			if (Form23.form23_0.statsReporter_0.UserOptInPrivacy)
			{
				smethod_1(bool_0: true, out var bool_);
				if (!bool_)
				{
					aBN.Checked = false;
				}
			}
			else if (Form54.smethod_4(this, Class333.aBK(), Class333.aBk(), MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Form60 form = new Form60();
				form.ShowDialog(this);
				form.Dispose();
				if (Form23.form23_0.statsReporter_0.UserOptInPrivacy)
				{
					smethod_1(bool_0: true, out var bool_2);
					if (!bool_2)
					{
						aBN.Checked = false;
					}
				}
				else
				{
					aBN.Checked = false;
				}
			}
			else
			{
				aBN.Checked = false;
			}
		}
		else
		{
			smethod_1(bool_0: false, out var _);
		}
	}

	internal static bool smethod_0()
	{
		try
		{
			string path = string.Concat(Form23.string_4 + Class333.aBL(), Class333.aBl());
			if (File.Exists(path))
			{
				return File.ReadAllText(path).Trim() == Class333.aBM();
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	internal static void smethod_1(bool bool_0, out bool bool_1)
	{
		try
		{
			string text = Form23.string_4 + Class333.aBL();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			File.WriteAllText(text + Class333.aBl(), Class333.aBm() + bool_0);
			bool_1 = true;
		}
		catch
		{
			bool_1 = false;
		}
		Form23.form23_0.method_24();
	}

	internal static bool smethod_2()
	{
		if (Form23.form23_0.statsReporter_0.UserOptInPrivacy)
		{
			return smethod_0();
		}
		return false;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && aBm != null)
		{
			aBm.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_0()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form59));
		aBN = new Class148();
		aBn = new Label();
		aBO = new ThemedButton();
		aBo = new ThemedButton();
		aBP = new Class148();
		SuspendLayout();
		aBN.AutoSize = true;
		aBN.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aBN.Location = new Point(11, 116);
		aBN.Name = Class333.aBN();
		aBN.Size = new Size(195, 17);
		aBN.TabIndex = 2;
		aBN.Text = Class333.aBn();
		aBN.UseVisualStyleBackColor = true;
		aBN.CheckedChanged += aBN_CheckedChanged;
		aBn.AutoSize = true;
		aBn.Location = new Point(11, 137);
		aBn.MaximumSize = new Size(300, 0);
		aBn.Name = Class333.smethod_618();
		aBn.Size = new Size(298, 169);
		aBn.TabIndex = 1;
		aBn.Text = componentResourceManager.GetString(Class333.smethod_2199());
		aBO.DialogResult = DialogResult.Cancel;
		aBO.Location = new Point(123, 332);
		aBO.Name = Class333.smethod_718();
		aBO.Size = new Size(75, 35);
		aBO.TabIndex = 3;
		aBO.Text = Class333.smethod_719();
		aBO.UseVisualStyleBackColor = true;
		aBO.Click += aBO_Click;
		aBo.Location = new Point(85, 49);
		aBo.Name = Class333.aBO();
		aBo.Size = new Size(150, 35);
		aBo.TabIndex = 1;
		aBo.Text = Class333.aBo();
		aBo.TextImageRelation = TextImageRelation.ImageBeforeText;
		aBo.UseVisualStyleBackColor = true;
		aBo.Click += aBo_Click;
		aBP.AutoSize = true;
		aBP.Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aBP.Location = new Point(11, 14);
		aBP.Name = Class333.aBP();
		aBP.Size = new Size(247, 17);
		aBP.TabIndex = 0;
		aBP.Text = Class333.aBp();
		aBP.UseVisualStyleBackColor = true;
		aBP.CheckedChanged += aBP_CheckedChanged;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = aBO;
		ClientSize = new Size(320, 381);
		Controls.Add(aBP);
		Controls.Add(aBo);
		Controls.Add(aBO);
		Controls.Add(aBn);
		Controls.Add(aBN);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.aBQ();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.aBq();
		Shown += Form59_Shown;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
