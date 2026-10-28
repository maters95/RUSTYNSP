using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns2;
using ns4;
using ns5;
using ns7;

namespace NSP.UserInterface.Forms;

public class CANSourceSelectionForm : Form
{
	[CompilerGenerated]
	private ISignalSource isignalSource_0;

	private IContainer icontainer_0;

	private RadioButton radioButton_0;

	private RadioButton radioButton_1;

	private RadioButton radioButton_2;

	private ThemedTextBox themedTextBox_0;

	private ThemedTextBox themedTextBox_1;

	private ThemedTextBox themedTextBox_2;

	private ThemedTextBox themedTextBox_3;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private Control8 control8_0;

	public ISignalSource Source
	{
		[CompilerGenerated]
		get
		{
			return isignalSource_0;
		}
		[CompilerGenerated]
		set
		{
			isignalSource_0 = value;
		}
	}

	public CANSourceSelectionForm()
	{
		method_1();
		BackColor = Form23.color_16;
		radioButton_0.ForeColor = Form23.color_12;
		radioButton_1.ForeColor = Form23.color_12;
		radioButton_2.ForeColor = Form23.color_12;
		themedTextBox_0.BackColor = Form23.color_32;
		themedTextBox_0.ForeColor = Form23.color_12;
		control8_0.method_0(Form23.framework_1);
		control8_0.Enabled = true;
		themedTextBox_0.Enabled = false;
		Shown += CANSourceSelectionForm_Shown;
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		if (radioButton_0.Checked)
		{
			if (control8_0.method_3() != 0)
			{
				Setting setting = Form23.framework_1.method_31(control8_0.method_3());
				if (setting != null)
				{
					Source = new ChannelSource(setting);
					DialogResult = DialogResult.OK;
				}
			}
		}
		else if (radioButton_2.Checked)
		{
			Source = new CounterSource();
			DialogResult = DialogResult.OK;
		}
		else
		{
			string text = themedTextBox_0.Text;
			int result;
			if (text.StartsWith(Class333.smethod_381(), StringComparison.OrdinalIgnoreCase))
			{
				int val = Class233.smethod_25(text, 102);
				Source = new FixedSource(val);
				DialogResult = DialogResult.OK;
			}
			else if (int.TryParse(text, out result))
			{
				Source = new FixedSource(result);
				DialogResult = DialogResult.OK;
			}
		}
		Close();
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}

	private void method_0(object sender, EventArgs e)
	{
		themedButton_0_Click(null, null);
	}

	private void radioButton_0_CheckedChanged(object sender, EventArgs e)
	{
		control8_0.Enabled = true;
		themedTextBox_0.Enabled = false;
	}

	private void radioButton_1_CheckedChanged(object sender, EventArgs e)
	{
		control8_0.Enabled = false;
		themedTextBox_0.Enabled = true;
	}

	private void radioButton_2_CheckedChanged(object sender, EventArgs e)
	{
		control8_0.Enabled = false;
		themedTextBox_0.Enabled = false;
	}

	private void CANSourceSelectionForm_Shown(object sender, EventArgs e)
	{
		if (Source != null)
		{
			if (Source is ChannelSource channelSource)
			{
				radioButton_0.Checked = true;
				control8_0.method_2(channelSource.Channel.method_64());
			}
			else if (Source is FixedSource fixedSource)
			{
				radioButton_1.Checked = true;
				themedTextBox_0.Text = fixedSource.Value.ToString();
			}
			else if (Source is CounterSource)
			{
				radioButton_2.Checked = true;
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

	private void method_1()
	{
		radioButton_0 = new RadioButton();
		radioButton_1 = new RadioButton();
		radioButton_2 = new RadioButton();
		themedTextBox_0 = new ThemedTextBox();
		themedButton_0 = new ThemedButton();
		themedButton_1 = new ThemedButton();
		control8_0 = new Control8();
		SuspendLayout();
		radioButton_0.AutoSize = true;
		radioButton_0.Location = new Point(17, 18);
		radioButton_0.Name = Class333.smethod_813();
		radioButton_0.Size = new Size(80, 23);
		radioButton_0.TabIndex = 0;
		radioButton_0.TabStop = true;
		radioButton_0.Text = Class333.smethod_814();
		radioButton_0.UseVisualStyleBackColor = true;
		radioButton_0.CheckedChanged += radioButton_0_CheckedChanged;
		radioButton_1.AutoSize = true;
		radioButton_1.Location = new Point(17, 69);
		radioButton_1.Name = Class333.smethod_815();
		radioButton_1.Size = new Size(98, 23);
		radioButton_1.TabIndex = 1;
		radioButton_1.TabStop = true;
		radioButton_1.Text = Class333.smethod_816();
		radioButton_1.UseVisualStyleBackColor = true;
		radioButton_1.CheckedChanged += radioButton_1_CheckedChanged;
		radioButton_2.AutoSize = true;
		radioButton_2.Location = new Point(17, 120);
		radioButton_2.Name = Class333.smethod_817();
		radioButton_2.Size = new Size(80, 23);
		radioButton_2.TabIndex = 2;
		radioButton_2.TabStop = true;
		radioButton_2.Text = Class333.smethod_818();
		radioButton_2.UseVisualStyleBackColor = true;
		radioButton_2.CheckedChanged += radioButton_2_CheckedChanged;
		themedTextBox_0.Location = new Point(134, 69);
		themedTextBox_0.Name = Class333.smethod_819();
		themedTextBox_0.Size = new Size(104, 26);
		themedTextBox_0.TabIndex = 4;
		themedButton_0.Location = new Point(232, 160);
		themedButton_0.MinimumSize = new Size(104, 40);
		themedButton_0.Name = Class333.smethod_820();
		themedButton_0.Size = new Size(104, 40);
		themedButton_0.TabIndex = 5;
		themedButton_0.Text = Class333.smethod_821();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		themedButton_1.Location = new Point(342, 160);
		themedButton_1.MinimumSize = new Size(104, 40);
		themedButton_1.Name = Class333.smethod_822();
		themedButton_1.Size = new Size(104, 40);
		themedButton_1.TabIndex = 6;
		themedButton_1.Text = Class333.smethod_823();
		themedButton_1.UseVisualStyleBackColor = true;
		themedButton_1.Click += themedButton_1_Click;
		control8_0.AutoSize = true;
		control8_0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		control8_0.Font = new Font(Class333.smethod_145(), 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		control8_0.Location = new Point(120, 18);
		control8_0.Margin = new Padding(4, 4, 4, 4);
		control8_0.Name = Class333.smethod_824();
		control8_0.Size = new Size(285, 30);
		control8_0.TabIndex = 7;
		control8_0.method_4(method_0);
		AcceptButton = themedButton_0;
		AutoScaleDimensions = new SizeF(8f, 19f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_1;
		ClientSize = new Size(450, 210);
		Controls.Add(control8_0);
		Controls.Add(themedButton_1);
		Controls.Add(themedButton_0);
		Controls.Add(themedTextBox_0);
		Controls.Add(radioButton_2);
		Controls.Add(radioButton_1);
		Controls.Add(radioButton_0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_825();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class333.smethod_826();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
