using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NSP.UserInterface.Forms;
using ns1;
using ns4;
using ns7;

namespace ns0;

internal class Class43 : ToolStripDropDown
{
	private List<int> list_0 = new List<int>();

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	private Class88 class88_0;

	private Point point_0;

	public Class43(Class88 class88_1)
	{
		class88_0 = class88_1;
		BackColor = Form23.color_15;
		ForeColor = Form23.color_12;
		if (class88_0 != null && class88_0.Bhi != null && class88_0.Bhi.awP.method_97())
		{
			toolStripMenuItem_0 = method_15();
			toolStripMenuItem_1 = method_4();
			toolStripMenuItem_3 = method_12();
			toolStripMenuItem_2 = method_5();
			toolStripMenuItem_5 = method_6();
		}
		toolStripMenuItem_4 = method_0();
	}

	protected override void Dispose(bool disposing)
	{
		class88_0 = null;
		try
		{
			if (toolStripMenuItem_0 != null)
			{
				toolStripMenuItem_0.Dispose();
			}
			if (toolStripMenuItem_1 != null)
			{
				toolStripMenuItem_1.Dispose();
			}
			if (toolStripMenuItem_3 != null)
			{
				toolStripMenuItem_3.Dispose();
			}
			if (toolStripMenuItem_4 != null)
			{
				toolStripMenuItem_4.Dispose();
			}
			if (toolStripMenuItem_2 != null)
			{
				toolStripMenuItem_2.Dispose();
			}
			if (toolStripMenuItem_5 != null)
			{
				toolStripMenuItem_5.Dispose();
			}
		}
		catch
		{
		}
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private ToolStripMenuItem method_0()
	{
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(Class333.smethod_345());
		toolStripMenuItem.Font = Font;
		toolStripMenuItem.BackColor = Form23.color_15;
		toolStripMenuItem.ForeColor = Form23.color_12;
		ToolStripMenuItem[] array = method_1();
		foreach (ToolStripMenuItem toolStripMenuItem2 in array)
		{
			toolStripMenuItem2.Click += method_19;
			toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
		}
		return toolStripMenuItem;
	}

	private ToolStripMenuItem[] method_1()
	{
		List<ToolStripMenuItem> list = new List<ToolStripMenuItem>();
		try
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(Class333.smethod_346());
			toolStripMenuItem.Font = Font;
			toolStripMenuItem.BackColor = Form23.color_15;
			toolStripMenuItem.ForeColor = Form23.color_12;
			toolStripMenuItem.Tag = true;
			list.Add(toolStripMenuItem);
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(Class333.smethod_347());
			toolStripMenuItem2.Font = Font;
			toolStripMenuItem2.BackColor = Form23.color_15;
			toolStripMenuItem2.ForeColor = Form23.color_12;
			toolStripMenuItem2.Tag = false;
			list.Add(toolStripMenuItem2);
		}
		catch (Exception ex)
		{
			_ = ex.Message;
		}
		return list.ToArray();
	}

	private List<int> method_2(Point point_1)
	{
		list_0.Clear();
		list_0 = class88_0.method_17(point_1);
		return list_0;
	}

	internal void method_3(Point point_1, int int_0)
	{
		Items.Clear();
		point_0 = point_1;
		list_0 = method_2(point_0);
		if (toolStripMenuItem_0 != null)
		{
			Items.Add(toolStripMenuItem_0);
		}
		if (int_0 >= 0)
		{
			if (toolStripMenuItem_2 != null)
			{
				Items.Add(toolStripMenuItem_2);
			}
			if (toolStripMenuItem_1 != null)
			{
				Items.Add(toolStripMenuItem_1);
			}
			if (toolStripMenuItem_3 != null)
			{
				Items.Add(toolStripMenuItem_3);
			}
			Items.Add(method_10(list_0, method_13));
		}
		else if (list_0.Count > 0)
		{
			Items.Add(method_10(list_0, method_13));
		}
		if (class88_0 != null && class88_0.Bhi != null && class88_0.Bhi.awP != null && !class88_0.method_21() && class88_0.Bhi.awP.method_92() && toolStripMenuItem_5 != null)
		{
			Items.Add(toolStripMenuItem_5);
		}
		if (toolStripMenuItem_4 != null)
		{
			Items.Add(toolStripMenuItem_4);
		}
	}

	private ToolStripMenuItem method_4()
	{
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(Class333.smethod_348());
		toolStripMenuItem.Click += method_9;
		toolStripMenuItem.Font = Font;
		toolStripMenuItem.BackColor = Form23.color_15;
		toolStripMenuItem.ForeColor = Form23.color_12;
		return toolStripMenuItem;
	}

	private ToolStripMenuItem method_5()
	{
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(Class333.smethod_349());
		toolStripMenuItem.Click += method_7;
		toolStripMenuItem.Font = Font;
		toolStripMenuItem.BackColor = Form23.color_15;
		toolStripMenuItem.ForeColor = Form23.color_12;
		return toolStripMenuItem;
	}

	private ToolStripMenuItem method_6()
	{
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(Class333.smethod_350());
		toolStripMenuItem.Click += method_8;
		toolStripMenuItem.Font = Font;
		toolStripMenuItem.BackColor = Form23.color_15;
		toolStripMenuItem.ForeColor = Form23.color_12;
		return toolStripMenuItem;
	}

	private void method_7(object sender, EventArgs e)
	{
		if (class88_0 != null)
		{
			class88_0.method_23();
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		if (class88_0 != null)
		{
			class88_0.method_24();
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		Form23.form23_0.control25_0.method_31();
		if (class88_0 != null)
		{
			class88_0.method_41(point_0.X, point_0.Y);
		}
	}

	private ToolStripMenuItem method_10(List<int> list_1, EventHandler eventHandler_0)
	{
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(Class333.smethod_351());
		toolStripMenuItem.Font = Font;
		toolStripMenuItem.BackColor = Form23.color_15;
		toolStripMenuItem.ForeColor = Form23.color_12;
		ToolStripMenuItem[] array = method_17(list_1);
		foreach (ToolStripMenuItem toolStripMenuItem2 in array)
		{
			toolStripMenuItem2.Click += eventHandler_0;
			toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
		}
		return toolStripMenuItem;
	}

	private ToolStripMenuItem method_11(List<int> list_1, EventHandler eventHandler_0)
	{
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(Class333.smethod_352());
		toolStripMenuItem.Font = Font;
		toolStripMenuItem.BackColor = Form23.color_15;
		toolStripMenuItem.ForeColor = Form23.color_12;
		ToolStripMenuItem[] array = method_17(list_1);
		foreach (ToolStripMenuItem toolStripMenuItem2 in array)
		{
			toolStripMenuItem2.Click += eventHandler_0;
			toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
		}
		return toolStripMenuItem;
	}

	private ToolStripMenuItem method_12()
	{
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(Class333.smethod_352());
		toolStripMenuItem.Click += method_14;
		toolStripMenuItem.Font = Font;
		toolStripMenuItem.BackColor = Form23.color_15;
		toolStripMenuItem.ForeColor = Form23.color_12;
		toolStripMenuItem.Tag = -1;
		return toolStripMenuItem;
	}

	private void method_13(object sender, EventArgs e)
	{
		ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
		foreach (int item in list_0)
		{
			if (toolStripMenuItem.Tag == null || (int)toolStripMenuItem.Tag == item)
			{
				class88_0.method_15(item);
				break;
			}
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		Form23.framework_1.awP.method_85();
	}

	private ToolStripMenuItem method_15()
	{
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(Class333.smethod_353());
		toolStripMenuItem.Font = Font;
		toolStripMenuItem.BackColor = Form23.color_15;
		toolStripMenuItem.ForeColor = Form23.color_12;
		toolStripMenuItem.Click += method_18;
		return toolStripMenuItem;
	}

	private ToolStripMenuItem[] method_16(List<int> list_1)
	{
		List<ToolStripMenuItem> list = new List<ToolStripMenuItem>();
		try
		{
			foreach (int item in list_1)
			{
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(item + Class333.smethod_354());
				toolStripMenuItem.Font = Font;
				toolStripMenuItem.BackColor = Form23.color_15;
				toolStripMenuItem.ForeColor = Form23.color_12;
				toolStripMenuItem.Tag = item;
				list.Add(toolStripMenuItem);
			}
		}
		catch (Exception ex)
		{
			_ = ex.Message;
		}
		return list.ToArray();
	}

	private ToolStripMenuItem[] method_17(List<int> list_1)
	{
		List<ToolStripMenuItem> list = new List<ToolStripMenuItem>();
		List<string> list2 = class88_0.method_18(list_1);
		try
		{
			for (int i = 0; i < list2.Count; i++)
			{
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(list2[i]);
				toolStripMenuItem.Font = Font;
				toolStripMenuItem.BackColor = Form23.color_15;
				toolStripMenuItem.ForeColor = Form23.color_12;
				toolStripMenuItem.Tag = list_1[i];
				list.Add(toolStripMenuItem);
			}
		}
		catch (Exception ex)
		{
			_ = ex.Message;
		}
		return list.ToArray();
	}

	private void method_18(object sender, EventArgs e)
	{
		if (class88_0 != null)
		{
			int num = 0;
			AddComponentForm addComponentForm = new AddComponentForm(class88_0.Bhm);
			if (addComponentForm.ShowDialog() == DialogResult.OK)
			{
				num = addComponentForm.method_0();
				class88_0.method_25(num, point_0.X, point_0.Y);
			}
			addComponentForm.Dispose();
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		bool bool_ = (bool)(sender as ToolStripMenuItem).Tag;
		class88_0.method_33(bool_);
	}
}
