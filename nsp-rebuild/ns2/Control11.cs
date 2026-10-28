using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns4;
using ns6;
using ns7;

namespace ns2;

internal abstract class Control11 : UserControl
{
	protected delegate void Delegate66(object sender, EventArgs e);

	protected delegate void Delegate67(object sender, EventArgs e);

	internal const int int_0 = 10;

	protected Framework framework_0;

	protected Framework framework_1;

	protected DataIdAndAttrId dataIdAndAttrId_0;

	protected Setting setting_0;

	protected Setting setting_1;

	protected Setting setting_2;

	protected Setting setting_3;

	protected Setting setting_4;

	protected bool bool_0;

	protected bool bool_1;

	protected PictureBox pictureBox_0 = new PictureBox();

	protected virtual void vmethod_0(Framework framework_2, Framework framework_3)
	{
		framework_0 = framework_2;
		framework_1 = framework_3;
	}

	protected virtual void vmethod_1(DataIdAndAttrId dataIdAndAttrId_1)
	{
		dataIdAndAttrId_0 = dataIdAndAttrId_1;
		setting_2 = null;
		Setting setting = framework_0.method_32(dataIdAndAttrId_1);
		if (setting.method_187() != 0 && setting.method_189() != 0)
		{
			setting_3 = framework_0.method_31(setting.method_189());
			if (setting_3 != null)
			{
				setting_3.method_40(vmethod_6);
				Setting setting2 = null;
				if (setting_3.method_191() != 0)
				{
					setting_4 = framework_0.method_31(setting_3.method_191());
					if (setting_4 != null)
					{
						setting_4.method_264(vmethod_7);
						setting2 = framework_0.method_31(setting_4.method_256());
					}
				}
				else if (setting_3.method_193() != 0)
				{
					setting2 = framework_0.method_31(setting_3.method_193());
				}
				if (setting2 != null)
				{
					Setting setting3 = framework_0.method_32(new DataIdAndAttrId(setting2.method_64(), setting.method_187()));
					if (setting3 != null)
					{
						if (setting_3.method_256() == 0)
						{
							setting_2 = setting;
							setting = setting3;
						}
						else
						{
							setting_2 = setting3;
						}
					}
				}
			}
		}
		setting_0 = setting;
		if (framework_1 != null)
		{
			setting_1 = framework_1.method_32(setting_0.method_69());
		}
	}

	[SpecialName]
	internal Setting method_0()
	{
		return setting_0;
	}

	protected virtual void vmethod_2()
	{
		bool_0 = framework_0.method_2() && framework_0.method_3() && setting_0.method_96();
		bool_1 = framework_1 != null && framework_1.method_2() && framework_1.method_3() && setting_1 != null && setting_1.method_96();
		if (ContextMenuStrip == null)
		{
			ContextMenuStrip = vmethod_9();
		}
	}

	protected virtual bool vmethod_3()
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG && framework_1 != null)
		{
			return bool_1;
		}
		return bool_0;
	}

	protected virtual void vmethod_4(object sender, EventArgs e)
	{
		if (Form23.pictureBox_1 != pictureBox_0)
		{
			if (!Form23.bool_28 && Form23.pictureBox_1 != null)
			{
				Form23.pictureBox_1.Visible = false;
			}
			Form23.bool_28 = setting_0.method_35() && !setting_0.method_122();
			Form23.pictureBox_1 = pictureBox_0;
		}
		pictureBox_0.Visible = true;
	}

	protected virtual void vmethod_5(object sender, EventArgs e)
	{
		if (!ClientRectangle.Contains(PointToClient(System.Windows.Forms.Cursor.Position)))
		{
			pictureBox_0.Visible = pictureBox_0.Image != null && setting_0.method_35() && !setting_0.method_122();
		}
	}

	protected virtual void vmethod_6(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate66 method = vmethod_6;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		vmethod_8();
	}

	protected virtual void vmethod_7(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate67 method = vmethod_7;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		vmethod_8();
	}

	protected abstract void vmethod_8();

	protected virtual ContextMenuStrip vmethod_9()
	{
		ContextMenuStrip contextMenuStrip = null;
		if (framework_0.method_4() && !vmethod_3())
		{
			contextMenuStrip = new ContextMenuStrip();
			contextMenuStrip.BackColor = Form23.color_15;
			contextMenuStrip.ForeColor = Form23.color_12;
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem.Text = Class333.smethod_613();
			toolStripMenuItem.Click += method_1;
			contextMenuStrip.Items.Add(toolStripMenuItem);
		}
		return contextMenuStrip;
	}

	protected virtual void vmethod_10()
	{
		Class280 @class = Form23.smethod_95();
		@class?.method_3(setting_0.method_69());
		if (setting_0.method_70() != 0)
		{
			setting_0.method_262(setting_0.method_249(), bool_0: true);
		}
		else
		{
			setting_0.method_246(bool_0: true);
		}
		@class?.method_4();
		Form23.smethod_75(setting_0.method_69());
	}

	protected void method_1(object sender, EventArgs e)
	{
		vmethod_10();
	}

	protected override void Dispose(bool disposing)
	{
		if (ContextMenuStrip != null)
		{
			foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
			{
				item.Click -= method_1;
			}
			ContextMenuStrip.Dispose();
		}
		base.Dispose(disposing);
	}
}
