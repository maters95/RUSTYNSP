using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns0;
using ns7;

namespace ns4;

internal class Form24 : Form
{
	private IContainer icontainer_0;

	private Label label_0;

	private Label label_1;

	private NumericUpDown numericUpDown_0;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	internal Form24()
	{
		method_0();
	}

	private void numericUpDown_0_ValueChanged(object sender, EventArgs e)
	{
		if (Form23.list_2.Count == 1)
		{
			Class1.smethod_75(Form23.list_2[0].BpS.string_0, (uint)numericUpDown_0.Value);
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
		label_0 = new Label();
		label_1 = new Label();
		numericUpDown_0 = new NumericUpDown();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		((ISupportInitialize)numericUpDown_0).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Location = new Point(12, 9);
		label_0.Name = Class333.smethod_618();
		label_0.Size = new Size(565, 13);
		label_0.TabIndex = 0;
		label_0.Text = Class333.smethod_2048();
		label_1.AutoSize = true;
		label_1.Location = new Point(12, 27);
		label_1.Name = Class333.smethod_620();
		label_1.Size = new Size(551, 13);
		label_1.TabIndex = 1;
		label_1.Text = Class333.smethod_2049();
		numericUpDown_0.Increment = new decimal(new int[4] { 1024, 0, 0, 0 });
		numericUpDown_0.Location = new Point(286, 49);
		numericUpDown_0.Maximum = new decimal(new int[4] { 1048576, 0, 0, 0 });
		numericUpDown_0.Name = Class333.smethod_2050();
		numericUpDown_0.Size = new Size(102, 20);
		numericUpDown_0.TabIndex = 0;
		numericUpDown_0.ValueChanged += numericUpDown_0_ValueChanged;
		label_2.AutoSize = true;
		label_2.Location = new Point(158, 52);
		label_2.Name = Class333.smethod_621();
		label_2.Size = new Size(123, 13);
		label_2.TabIndex = 3;
		label_2.Text = Class333.smethod_2051();
		label_3.AutoSize = true;
		label_3.Location = new Point(395, 52);
		label_3.Name = Class333.smethod_623();
		label_3.Size = new Size(33, 13);
		label_3.TabIndex = 4;
		label_3.Text = Class333.smethod_2052();
		label_4.AutoSize = true;
		label_4.Location = new Point(177, 76);
		label_4.Name = Class333.smethod_862();
		label_4.Size = new Size(232, 13);
		label_4.TabIndex = 5;
		label_4.Text = Class333.smethod_2053();
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(587, 104);
		Controls.Add(label_4);
		Controls.Add(label_3);
		Controls.Add(label_2);
		Controls.Add(numericUpDown_0);
		Controls.Add(label_1);
		Controls.Add(label_0);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class333.smethod_2054();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2055();
		((ISupportInitialize)numericUpDown_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
