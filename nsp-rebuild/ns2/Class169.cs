using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using NSP.Resources;
using ns0;
using ns4;
using ns7;

namespace ns2;

internal class Class169 : ToolStripButton
{
	private const int int_0 = 2000;

	private Image image_0;

	private Image image_1;

	private Stopwatch stopwatch_0 = new Stopwatch();

	internal void method_0()
	{
		bool flag = false;
		if (Image == image_0)
		{
			Image = null;
			flag = true;
		}
		if (image_0 != null)
		{
			image_0.Dispose();
		}
		image_0 = Class25.smethod_0(GeneralResources.IconFWUpdate, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
		if (flag)
		{
			Image = image_0;
		}
		flag = false;
		if (Image == image_1)
		{
			Image = null;
			flag = true;
		}
		if (image_1 != null)
		{
			image_1.Dispose();
		}
		image_1 = Class25.smethod_0(GeneralResources.IconFWUpdate, 1f, 0f, 0f, 0f, 0f, 0f, 0.5f, 0f);
		if (flag)
		{
			Image = image_1;
		}
	}

	internal void method_1()
	{
		Image = image_0;
	}

	internal void method_2()
	{
		if (Image != image_0)
		{
			Image = image_0;
			Text = Class333.smethod_704();
			ToolTipText = Text;
		}
		stopwatch_0.Reset();
		BackColor = Form23.form23_0.toolStrip_0.BackColor;
	}

	internal void method_3()
	{
		if (Image != image_1)
		{
			Image = image_1;
			Text = Class333.smethod_705();
			ToolTipText = Text;
		}
		stopwatch_0.Restart();
		BackColor = Color.FromArgb(0, 200, 0);
	}

	internal void method_4()
	{
		if (Image == image_1)
		{
			if (stopwatch_0.IsRunning)
			{
				if (stopwatch_0.ElapsedMilliseconds >= 2000L)
				{
					BackColor = Form23.form23_0.toolStrip_0.BackColor;
					return;
				}
				float num = 1f - (float)(int)stopwatch_0.ElapsedMilliseconds / 2000f;
				int r = Form23.form23_0.toolStrip_0.BackColor.R;
				int g = Form23.form23_0.toolStrip_0.BackColor.G;
				int b = Form23.form23_0.toolStrip_0.BackColor.B;
				Color backColor = Color.FromArgb(r - (int)(num * (float)r), g + (int)(num * (float)(200 - g)), b - (int)(num * (float)b));
				BackColor = backColor;
			}
			else
			{
				stopwatch_0.Restart();
				BackColor = Color.FromArgb(0, 200, 0);
			}
		}
		else
		{
			BackColor = Form23.form23_0.toolStrip_0.BackColor;
			stopwatch_0.Reset();
		}
	}
}
