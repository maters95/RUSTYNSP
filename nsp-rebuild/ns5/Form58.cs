using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NSP.UserInterface;
using ns4;
using ns7;

namespace ns5;

internal class Form58 : Form
{
	internal static readonly string aBJ = Form23.string_3 + Class333.aBj();

	private List<ThemedComboBox> aBj = new List<ThemedComboBox>();

	private IContainer aBK;

	private ThemedButton aBk;

	private ThemedButton aBL;

	private Panel aBl;

	internal Form58()
	{
		method_0();
		BackColor = Form23.color_10;
		aBl.BackColor = Form23.color_17;
		int num = 10;
		for (int i = 0; i < Class233.aCw.Length; i++)
		{
			Label label = new Label
			{
				ForeColor = Form23.color_12,
				Text = Class233.aCw[i],
				Width = (aBl.Width - 20) / 2,
				Left = 10,
				Top = num + 3
			};
			aBl.Controls.Add(label);
			ThemedComboBox themedComboBox = new ThemedComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList
			};
			string[] array = Class233.aCX[i];
			for (int j = 0; j < array.Length; j++)
			{
				themedComboBox.Items.Add(array[j]);
			}
			if (File.Exists(aBJ))
			{
				using StreamReader streamReader = File.OpenText(aBJ);
				bool flag = false;
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					if (text.StartsWith(Class333.aBi() + i + Class333.smethod_571()))
					{
						themedComboBox.SelectedIndex = int.Parse(text.Substring((Class333.aBi() + i + Class333.smethod_571()).Length));
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					themedComboBox.SelectedIndex = Class233.aCx[i + 1];
				}
			}
			else
			{
				themedComboBox.SelectedIndex = Class233.aCx[i + 1];
			}
			themedComboBox.Width = (aBl.Width - 20) / 2;
			themedComboBox.Left = label.Right;
			themedComboBox.Top = num;
			aBj.Add(themedComboBox);
			aBl.Controls.Add(themedComboBox);
			num += themedComboBox.Height + 2;
		}
	}

	private void Form58_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DialogResult == DialogResult.OK)
		{
			for (int i = 0; i < aBj.Count; i++)
			{
				Class233.aCx[i + 1] = aBj[i].SelectedIndex;
			}
			if (!Directory.Exists(Form23.string_3 + Class333.smethod_557()))
			{
				Directory.CreateDirectory(Form23.string_3 + Class333.smethod_557());
			}
			File.Create(aBJ).Close();
			List<string> list = new List<string>();
			for (int j = 0; j < aBj.Count; j++)
			{
				list.Add(Class333.aBi() + j + Class333.smethod_571() + Class233.aCx[j + 1]);
			}
			File.AppendAllLines(aBJ, list);
			Form23.bool_35 = true;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && aBK != null)
		{
			aBK.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_0()
	{
		aBk = new ThemedButton();
		aBL = new ThemedButton();
		aBl = new Panel();
		SuspendLayout();
		aBk.DialogResult = DialogResult.Cancel;
		aBk.Location = new Point(289, 364);
		aBk.Name = Class333.smethod_830();
		aBk.Size = new Size(96, 35);
		aBk.TabIndex = 1;
		aBk.Text = Class333.smethod_823();
		aBk.UseVisualStyleBackColor = true;
		aBL.DialogResult = DialogResult.OK;
		aBL.Location = new Point(187, 364);
		aBL.Name = Class333.smethod_829();
		aBL.Size = new Size(96, 35);
		aBL.TabIndex = 2;
		aBL.Text = Class333.smethod_821();
		aBL.UseVisualStyleBackColor = true;
		aBl.BorderStyle = BorderStyle.FixedSingle;
		aBl.Location = new Point(12, 12);
		aBl.Name = Class333.smethod_2494();
		aBl.Size = new Size(373, 341);
		aBl.TabIndex = 3;
		AcceptButton = aBL;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = aBk;
		ClientSize = new Size(397, 407);
		Controls.Add(aBl);
		Controls.Add(aBL);
		Controls.Add(aBk);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.aBJ();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_1623();
		FormClosing += Form58_FormClosing;
		ResumeLayout(performLayout: false);
	}
}
