using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns7;

namespace ns4;

internal class Form18 : Form
{
	private IContainer icontainer_0;

	private Timer timer_0;

	internal Form18()
	{
		method_0();
	}

	private void Form18_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (e.CloseReason == CloseReason.UserClosing)
		{
			e.Cancel = true;
			Hide();
		}
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		if (keyData == Keys.F1 && Visible)
		{
			Hide();
		}
		return false;
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
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		SuspendLayout();
		timer_0.Interval = 400;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(984, 562);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		MinimumSize = new Size(200, 200);
		Name = Class333.smethod_1177();
		ShowIcon = false;
		StartPosition = FormStartPosition.Manual;
		Text = Class333.smethod_1178();
		FormClosing += Form18_FormClosing;
		ResumeLayout(performLayout: false);
	}
}
