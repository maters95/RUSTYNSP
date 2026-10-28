using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using ns0;
using ns4;
using ns7;

namespace ns2;

internal class Class168 : ToolStripButton
{
	private Image image_0;

	private Image image_1;

	private Stopwatch stopwatch_0 = new Stopwatch();

	private Timer timer_0;

	private const int int_0 = 2000;

	private const int int_1 = 500;

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
		image_0 = Class25.smethod_0(GeneralResources.IconRebootECU, 1f, 0f, 0f, 0f, 0f, Form23.float_4, Form23.float_5, Form23.float_6);
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
		image_1 = Class25.smethod_0(GeneralResources.IconRebootECU, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f);
		if (flag)
		{
			Image = image_1;
		}
	}

	internal void method_1()
	{
		stopwatch_0.Reset();
		if (timer_0 != null)
		{
			timer_0.Tick -= timer_0_Tick;
			timer_0.Stop();
			timer_0.Dispose();
			timer_0 = null;
		}
		BackColor = Form23.form23_0.toolStrip_0.BackColor;
		if (Image != image_0)
		{
			Image = image_0;
		}
		Text = Class333.smethod_702();
		ToolTipText = Text;
	}

	internal void method_2()
	{
		bool flag = false;
		if (Form23.framework_1 != null)
		{
			Setting setting = Form23.framework_1.method_31(13);
			if (setting != null && setting.method_256() == 1)
			{
				flag = true;
			}
		}
		if (flag)
		{
			if (stopwatch_0.IsRunning)
			{
				if (stopwatch_0.ElapsedMilliseconds >= 2000L)
				{
					if (timer_0 != null && timer_0.Enabled)
					{
						BackColor = Form23.form23_0.toolStrip_0.BackColor;
					}
					else
					{
						stopwatch_0.Restart();
						BackColor = Color.FromArgb(200, 0, 0);
					}
				}
				else
				{
					float num = 1f - (float)(int)stopwatch_0.ElapsedMilliseconds / 2000f;
					int r = Form23.form23_0.toolStrip_0.BackColor.R;
					int g = Form23.form23_0.toolStrip_0.BackColor.G;
					int b = Form23.form23_0.toolStrip_0.BackColor.B;
					Color backColor = Color.FromArgb(r + (int)(num * (float)(200 - r)), g - (int)(num * (float)g), b - (int)(num * (float)b));
					BackColor = backColor;
				}
				if (timer_0 == null)
				{
					timer_0 = new Timer();
					timer_0.Interval = 500;
					timer_0.Tick += timer_0_Tick;
					timer_0.Start();
				}
			}
			else
			{
				stopwatch_0.Restart();
				BackColor = Color.FromArgb(200, 0, 0);
			}
			Text = Class333.smethod_703();
			ToolTipText = Text;
		}
		else
		{
			method_1();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (Image != image_0)
		{
			Image = image_0;
		}
		else
		{
			Image = image_1;
		}
	}
}
