using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns1;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns2;

internal class Class144 : Panel
{
	private SpecialObject specialObject_0;

	private Framework framework_0;

	private DataGridView dataGridView_0;

	private DataGridView dataGridView_1;

	private ThemedButton themedButton_0;

	private List<Class142> list_0 = new List<Class142>();

	private List<Class143> list_1 = new List<Class143>();

	private List<SettingOrSpecialObject> list_2 = new List<SettingOrSpecialObject>();

	private SettingOrSpecialObject settingOrSpecialObject_0;

	private ContextMenuStrip contextMenuStrip_0 = new ContextMenuStrip();

	private const int int_0 = 200;

	private const int int_1 = 250;

	internal const int int_2 = 20;

	private int int_3 = -1;

	private int int_4 = -1;

	private Label label_0;

	private int int_5 = -1;

	private int int_6;

	private int int_7 = -1;

	private System.Timers.Timer timer_0 = new System.Timers.Timer();

	private static List<int> list_3 = new List<int>();

	private int int_8 = -1;

	private int int_9 = -1;

	private const string string_0 = "Duplicate";

	private const string string_1 = "Insert New Above";

	private const string string_2 = "Delete";

	internal Class144(SpecialObject specialObject_1, Framework framework_1, Rectangle rectangle_0)
	{
		Name = Class333.smethod_650();
		BorderStyle = BorderStyle.None;
		specialObject_0 = specialObject_1;
		framework_0 = framework_1;
		method_2(rectangle_0);
		method_0();
		method_9();
		dataGridView_0.CellPainting += dataGridView_0_CellPainting;
		dataGridView_0.CellMouseDown += dataGridView_0_CellMouseDown;
		dataGridView_0.MouseDown += dataGridView_0_MouseDown;
		dataGridView_0.MouseMove += dataGridView_0_MouseMove;
		dataGridView_0.MouseUp += dataGridView_0_MouseUp;
		dataGridView_0.Scroll += dataGridView_0_Scroll;
		dataGridView_0.KeyDown += dataGridView_0_KeyDown;
		dataGridView_0.ColumnWidthChanged += dataGridView_0_ColumnWidthChanged;
		dataGridView_0.RowPostPaint += dataGridView_0_RowPostPaint;
		themedButton_0.MouseClick += themedButton_0_MouseClick;
		dataGridView_1.CellPainting += dataGridView_1_CellPainting;
		dataGridView_1.SelectionChanged += dataGridView_1_SelectionChanged;
		method_11();
		method_4();
		dataGridView_0_ColumnWidthChanged(null, null);
	}

	protected override void Dispose(bool disposing)
	{
		dataGridView_0.CellPainting -= dataGridView_0_CellPainting;
		dataGridView_0.CellMouseDown -= dataGridView_0_CellMouseDown;
		dataGridView_0.MouseDown -= dataGridView_0_MouseDown;
		dataGridView_0.MouseMove -= dataGridView_0_MouseMove;
		dataGridView_0.MouseUp -= dataGridView_0_MouseUp;
		dataGridView_0.Scroll -= dataGridView_0_Scroll;
		dataGridView_0.KeyDown -= dataGridView_0_KeyDown;
		dataGridView_0.ColumnWidthChanged -= dataGridView_0_ColumnWidthChanged;
		dataGridView_0.RowPostPaint -= dataGridView_0_RowPostPaint;
		dataGridView_0.Columns.Clear();
		dataGridView_0.Rows.Clear();
		themedButton_0.MouseClick -= themedButton_0_MouseClick;
		dataGridView_1.CellPainting -= dataGridView_1_CellPainting;
		dataGridView_1.SelectionChanged -= dataGridView_1_SelectionChanged;
		timer_0.Elapsed -= timer_0_Elapsed;
		timer_0.Dispose();
		dataGridView_1.Rows.Clear();
		dataGridView_1.Columns.Clear();
		list_0.Clear();
		list_3.Clear();
		list_1.Clear();
		contextMenuStrip_0.Dispose();
		base.Dispose(disposing);
	}

	private void method_0()
	{
		foreach (Control control in Controls)
		{
			if (control is DataGridView)
			{
				DataGridView obj = control as DataGridView;
				obj.ReadOnly = true;
				obj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				obj.MultiSelect = false;
				obj.BorderStyle = BorderStyle.None;
				obj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
				obj.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
				obj.ForeColor = Form23.color_12;
				obj.BackgroundColor = Form23.color_20;
				obj.EnableHeadersVisualStyles = false;
				obj.AllowUserToOrderColumns = false;
				obj.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
				obj.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
				obj.ColumnHeadersDefaultCellStyle.BackColor = Form23.color_20;
				obj.ColumnHeadersDefaultCellStyle.ForeColor = Form23.color_12;
				obj.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				obj.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
				obj.RowHeadersVisible = false;
				obj.AllowUserToAddRows = false;
				obj.AllowUserToDeleteRows = false;
				obj.AllowUserToResizeRows = false;
				obj.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
				obj.RowHeadersDefaultCellStyle.BackColor = dataGridView_0.BackgroundColor;
				obj.RowHeadersDefaultCellStyle.ForeColor = Form23.color_12;
				obj.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				obj.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
				obj.DefaultCellStyle.BackColor = Form23.color_10;
				obj.DefaultCellStyle.ForeColor = Form23.color_12;
				obj.DefaultCellStyle.SelectionForeColor = Form23.color_23;
				obj.DefaultCellStyle.SelectionBackColor = Form23.color_21;
			}
			else if (!(control is ThemedButton))
			{
				throw new Exception(Class333.smethod_651());
			}
		}
	}

	private Image method_1(Class141 class141_0, int int_10)
	{
		int num = 20;
		Bitmap bitmap = new Bitmap(int_10 - 1, int_10 - 1, PixelFormat.Format24bppRgb);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			using SolidBrush brush = new SolidBrush(Form23.color_10);
			graphics.FillRectangle(brush, new Rectangle(0, 0, int_10 - 1, num * 2));
		}
		if (class141_0.enum41_0 == Enum41.const_4 && class141_0.enum105_0 == Enum105.BaF && class141_0.class139_0 is Class140)
		{
			class141_0.enum42_0 = ((class141_0.enum42_0 != Enum42.const_1) ? Enum42.const_1 : Enum42.const_0);
			return (class141_0.class139_0 as Class140).method_4(class141_0.enum42_0);
		}
		return bitmap;
	}

	private void method_2(Rectangle rectangle_0)
	{
		new ComponentResourceManager(typeof(Form1));
		dataGridView_0 = new DataGridView();
		dataGridView_1 = new DataGridView();
		themedButton_0 = new ThemedButton();
		SuspendLayout();
		((ISupportInitialize)dataGridView_0).BeginInit();
		((ISupportInitialize)dataGridView_1).BeginInit();
		if (specialObject_0.method_67().ExtraSummaryObjectId > 0)
		{
			dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView_1.Name = Class333.smethod_652();
			dataGridView_1.ShowCellToolTips = false;
			dataGridView_1.Size = new Size(rectangle_0.Width, 30);
			dataGridView_1.TabIndex = 11;
			dataGridView_1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		}
		dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_0.Location = new Point(0, 0);
		dataGridView_0.Name = Class333.smethod_653();
		dataGridView_0.ShowCellToolTips = false;
		dataGridView_0.TabIndex = 11;
		dataGridView_0.ColumnHeadersHeight = 50;
		dataGridView_0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dataGridView_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		dataGridView_0.GridColor = Color.LightGray;
		themedButton_0.DialogResult = DialogResult.OK;
		themedButton_0.Name = Class333.smethod_654();
		themedButton_0.Size = new Size(80, 23);
		themedButton_0.TabIndex = 3;
		themedButton_0.Text = Class333.smethod_655();
		themedButton_0.UseCompatibleTextRendering = true;
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.BringToFront();
		ClientSize = new Size(rectangle_0.Width, rectangle_0.Height);
		Controls.Add(dataGridView_0);
		Controls.Add(themedButton_0);
		if (specialObject_0.method_67().ExtraSummaryObjectId > 0)
		{
			Controls.Add(dataGridView_1);
		}
		((ISupportInitialize)dataGridView_0).EndInit();
		((ISupportInitialize)dataGridView_1).EndInit();
		method_7();
		ResumeLayout(performLayout: true);
	}

	private void method_3()
	{
		timer_0.Interval = 250.0;
		timer_0.SynchronizingObject = this;
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.AutoReset = true;
		timer_0.Enabled = true;
		timer_0.Start();
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		int num = -1;
		if (list_1.Count == 0)
		{
			return;
		}
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_1[0].list_0[i].class139_0 != null && list_1[0].list_0[i].class139_0 is Class140)
			{
				num = i;
			}
		}
		if (num == -1)
		{
			return;
		}
		for (int j = 0; j < list_1.Count; j++)
		{
			if (list_1[j].list_0[num].bool_0)
			{
				method_6(j, Enum41.const_4);
			}
		}
	}

	internal void method_4()
	{
		try
		{
			_ = list_0.Count;
			dataGridView_0.Rows.Clear();
			method_13();
			method_5();
			method_7();
		}
		catch
		{
			throw new Exception(Class333.smethod_656());
		}
		if (!timer_0.Enabled)
		{
			method_3();
		}
	}

	private void method_5()
	{
		dataGridView_0.Rows.Clear();
		int num = 1;
		for (int i = 0; i < list_1.Count; i++)
		{
			if (!list_1[i].bool_0)
			{
				continue;
			}
			DataGridViewRow dataGridViewRow = new DataGridViewRow();
			for (int j = 0; j < list_0.Count; j++)
			{
				DataGridViewCell dataGridViewCell;
				switch (list_0[j].method_4())
				{
				default:
					dataGridViewCell = new DataGridViewTextBoxCell();
					if (j == 0)
					{
						list_1[i].list_0[j].int_0 = num++;
						dataGridViewCell.Value = list_1[i].list_0[j].int_0.ToString();
						dataGridViewCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
					}
					else
					{
						dataGridViewCell.Value = list_1[i].list_0[j].string_0;
					}
					break;
				case Enum41.const_4:
					dataGridViewCell = new DataGridViewImageCell();
					dataGridViewCell.Value = method_1(list_1[i].list_0[j], list_0[j].method_2());
					break;
				case Enum41.const_1:
				case Enum41.const_2:
				case Enum41.const_3:
					dataGridViewCell = new DataGridViewTextBoxCell();
					dataGridViewCell.Value = list_1[i].list_0[j].string_0;
					break;
				}
				dataGridViewRow.Cells.Add(dataGridViewCell);
			}
			dataGridView_0.Rows.Add(dataGridViewRow);
		}
		if (settingOrSpecialObject_0 != null)
		{
			method_12();
		}
		if (int_8 >= 0 && int_8 < dataGridView_0.RowCount)
		{
			dataGridView_0.FirstDisplayedScrollingRowIndex = int_8;
		}
		dataGridView_0.ColumnWidthChanged -= dataGridView_0_ColumnWidthChanged;
		method_8();
		dataGridView_0.ColumnWidthChanged += dataGridView_0_ColumnWidthChanged;
	}

	private void method_6(int int_10, Enum41 enum41_0)
	{
		int num = -1;
		for (int i = 0; i < list_1.Count; i++)
		{
			if (!list_1[i].bool_0)
			{
				continue;
			}
			num++;
			if (i != int_10)
			{
				continue;
			}
			for (int j = 0; j < list_0.Count; j++)
			{
				if (list_0[j].method_4() == enum41_0 && list_0[j].method_4() == Enum41.const_4)
				{
					DataGridViewCell dataGridViewCell = new DataGridViewImageCell();
					dataGridViewCell.Value = method_1(list_1[i].list_0[j], list_0[j].method_2());
					dataGridView_0.Rows[num].Cells[j] = dataGridViewCell;
					dataGridView_0.InvalidateRow(num);
				}
			}
		}
	}

	private void method_7()
	{
		dataGridView_0.Height = dataGridView_0.ColumnHeadersHeight + ((dataGridView_0.RowCount > 0) ? (dataGridView_0.Rows[0].Height * dataGridView_0.RowCount) : 0);
		themedButton_0.Location = new Point(0, dataGridView_0.Bottom + 5);
		themedButton_0.BringToFront();
		Height = themedButton_0.Bottom + 5;
		if (dataGridView_1 != null)
		{
			Point location = new Point(0, Height);
			Height += dataGridView_1.Height;
			dataGridView_1.Location = location;
		}
		dataGridView_0.ClearSelection();
	}

	private void method_8()
	{
		for (int i = 0; i < dataGridView_0.ColumnCount; i++)
		{
			dataGridView_0.Columns[i].Width = list_3[i];
		}
	}

	private void dataGridView_0_ColumnWidthChanged(object sender, EventArgs e)
	{
		for (int i = 0; i < dataGridView_0.ColumnCount; i++)
		{
			if (i < list_3.Count)
			{
				list_3[i] = dataGridView_0.Columns[i].Width;
			}
			else
			{
				list_3.Add(dataGridView_0.Columns[i].Width);
			}
		}
		if (Parent != null && Parent.Parent != null && Parent.Parent.Parent != null)
		{
			Width = Math.Max(Parent.Parent.Parent.Width - 20, list_3.Sum() + 100);
		}
		else
		{
			Width = list_3.Sum() + 100;
		}
		if (Parent != null && Parent is Class131)
		{
			Parent.Width = Width;
			if (Parent.Parent != null)
			{
				Parent.Parent.Width = Parent.Width + 10;
			}
		}
		dataGridView_0.Width = Width;
		method_12();
		Refresh();
	}

	private void method_9()
	{
		contextMenuStrip_0.Dispose();
		contextMenuStrip_0 = new ContextMenuStrip();
		contextMenuStrip_0.BackColor = Form23.color_15;
		contextMenuStrip_0.ForeColor = Form23.color_12;
		ToolStripMenuItem value = new ToolStripMenuItem(Class333.smethod_657(), null, method_19);
		ToolStripMenuItem value2 = new ToolStripMenuItem(Class333.smethod_658(), null, method_19);
		ToolStripMenuItem value3 = new ToolStripMenuItem(Class333.smethod_659(), null, method_19);
		contextMenuStrip_0.Items.Add(value);
		contextMenuStrip_0.Items.Add(value2);
		contextMenuStrip_0.Items.Add(value3);
		dataGridView_0.ContextMenuStrip = contextMenuStrip_0;
	}

	private Enum41 method_10(Setting setting_0, int int_10)
	{
		if (setting_0.method_70() != 0)
		{
			return Enum41.const_1;
		}
		if (setting_0.method_159())
		{
			return Enum41.const_2;
		}
		if (setting_0 is Class244)
		{
			return Enum41.const_4;
		}
		if (int_10 != 0)
		{
			return Enum41.const_3;
		}
		return Enum41.const_0;
	}

	private void method_11()
	{
		list_0.Clear();
		if (specialObject_0.method_67().Reorderable)
		{
			Class142 item = new Class142(specialObject_0.method_67().ReorderableText, 40, Enum41.const_0);
			list_0.Add(item);
		}
		SettingOrSpecialObject settingOrSpecialObject = specialObject_0.method_1()[0];
		if (settingOrSpecialObject is SpecialObject)
		{
			SpecialObject specialObject = (SpecialObject)settingOrSpecialObject;
			int int_ = 0;
			for (int i = 0; i < specialObject.method_66().CurrentUIListSettingsIdsAndIndents.Count; i++)
			{
				Setting setting = framework_0.method_31(specialObject.method_66().CurrentUIListSettingsIdsAndIndents[i].DataId);
				if (setting != null)
				{
					string text = setting.method_60(Enum96.aYv);
					if (string.IsNullOrEmpty(text))
					{
						text = setting.method_60(Enum96.aYu);
					}
					string text2 = (string.IsNullOrEmpty(text) ? setting.method_60(Enum96.aYt) : text);
					Enum41 @enum = method_10(setting, int_);
					if (@enum == Enum41.const_2)
					{
						int_ = 1;
					}
					list_0.Add(new Class142(text2, 40, @enum));
				}
			}
		}
		int num = 0;
		bool flag = false;
		if (Enumerable.Count(list_3) == 0)
		{
			flag = true;
		}
		foreach (Class142 item2 in list_0)
		{
			if (flag)
			{
				switch (item2.method_4())
				{
				default:
					item2.method_3(40);
					break;
				case Enum41.const_1:
				case Enum41.const_2:
					item2.method_3(120);
					break;
				case Enum41.const_3:
					item2.method_3(70);
					break;
				case Enum41.const_4:
					item2.method_3(430);
					break;
				}
				list_3.Add(item2.method_2());
			}
			else
			{
				item2.method_3(list_3[num++]);
			}
		}
		for (int j = 0; j < list_0.Count; j++)
		{
			dataGridView_0.Columns.Add(list_0[j].method_0(), list_0[j].method_0());
			dataGridView_0.Columns[j].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView_0.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView_0.Columns[j].Width = list_3[j];
			dataGridView_0.Columns[j].MinimumWidth = 20;
			if (list_0[j].method_4() == Enum41.const_4)
			{
				dataGridView_0.Columns[j].Resizable = DataGridViewTriState.False;
			}
		}
	}

	private void method_12()
	{
		if (settingOrSpecialObject_0 == null)
		{
			return;
		}
		List<Class252> list = (settingOrSpecialObject_0 as Class253).method_72();
		int[] array = new int[framework_0.awq.Count];
		for (int i = 0; i < framework_0.awq.Count; i++)
		{
			if (list[i].method_72() != null)
			{
				array[i] = list[i].method_72().method_256();
			}
		}
		Class140 @class = new Class140(framework_0.awq.Count, array, int.MaxValue, Class140.BNt, 20);
		DataGridViewCell dataGridViewCell = new DataGridViewTextBoxCell();
		DataGridViewCell dataGridViewCell2 = new DataGridViewImageCell();
		dataGridViewCell.Value = Class333.smethod_660();
		dataGridViewCell2.Value = @class.method_4(Enum42.const_0);
		dataGridView_1.Rows.Clear();
		dataGridView_1.Columns.Clear();
		dataGridView_1.Columns.Add(Class333.smethod_661(), Class333.smethod_660());
		dataGridView_1.Columns.Add(Class333.smethod_662(), Class333.smethod_663());
		foreach (DataGridViewColumn column in dataGridView_1.Columns)
		{
			column.Resizable = DataGridViewTriState.False;
		}
		int num = 0;
		for (int j = 0; j < list_3.Count - 1; j++)
		{
			num += list_3[j];
		}
		dataGridView_1.Columns[0].Width = num;
		dataGridView_1.Columns[1].Width = list_0[list_0.Count - 1].method_2();
		dataGridView_1.ColumnHeadersVisible = false;
		DataGridViewRow dataGridViewRow = new DataGridViewRow();
		dataGridViewRow.Cells.Add(dataGridViewCell);
		dataGridViewRow.Cells.Add(dataGridViewCell2);
		dataGridView_1.Rows.Add(dataGridViewRow);
		dataGridView_1.Refresh();
	}

	private void method_13()
	{
		list_1.Clear();
		bool flag = false;
		if (list_2.Count == 0)
		{
			flag = true;
		}
		if (flag && specialObject_0.method_67().ExtraSummaryObjectId > 0)
		{
			settingOrSpecialObject_0 = framework_0.method_33(specialObject_0.method_67().ExtraSummaryObjectId);
		}
		foreach (SettingOrSpecialObject item3 in specialObject_0.method_1())
		{
			Class143 @class = new Class143();
			int num = 0;
			int num2 = 0;
			@class.list_0 = new List<Class141>();
			Class141 item = new Class141
			{
				int_1 = 0,
				enum41_0 = Enum41.const_0
			};
			@class.list_0.Add(item);
			SpecialObject specialObject = (SpecialObject)item3;
			if (specialObject.method_66().RowIncludeSetting != 0)
			{
				Setting setting = framework_0.method_31(specialObject.method_66().RowIncludeSetting);
				if (setting != null)
				{
					@class.bool_0 = setting.method_256() == 1;
					@class.uilistObject_0 = specialObject.method_66();
					if (flag && @class.uilistObject_0.RowObjectId != 0)
					{
						SettingOrSpecialObject item2 = framework_0.method_33(@class.uilistObject_0.RowObjectId);
						list_2.Add(item2);
					}
				}
			}
			for (int i = 1; i <= specialObject.method_66().CurrentUIListSettingsIdsAndIndents.Count; i++)
			{
				int dataId = specialObject.method_66().CurrentUIListSettingsIdsAndIndents[i - 1].DataId;
				SettingOrSpecialObject settingOrSpecialObject = framework_0.method_31(dataId);
				Class141 class2 = new Class141();
				class2.int_1 = dataId;
				class2.enum105_0 = PortFunction.smethod_13((uint)(settingOrSpecialObject as Setting).method_256());
				class2.enum41_0 = list_0[i].method_4();
				class2.bool_0 = false;
				if (class2.enum41_0 == Enum41.const_0)
				{
					Class142 class3 = list_0[i];
					Enum41 @enum = Enum41.const_3;
					class3.method_5(Enum41.const_3);
					class2.enum41_0 = Enum41.const_3;
				}
				switch (class2.enum41_0)
				{
				case Enum41.const_1:
					class2.string_0 = (settingOrSpecialObject as Setting).method_260();
					break;
				case Enum41.const_2:
				{
					int num3 = (settingOrSpecialObject as Setting).method_256();
					Setting setting3 = framework_0.method_31(num3);
					if (setting3 != null)
					{
						class2.string_0 = setting3.method_22(bool_0: false);
						num = setting3.method_231();
						num2 = setting3.method_232();
					}
					break;
				}
				case Enum41.const_0:
				case Enum41.const_3:
				{
					Setting setting2 = settingOrSpecialObject as Setting;
					if (setting2.method_35())
					{
						class2.string_0 = Class233.smethod_29(setting2.method_256(), num) + Class333.smethod_325() + Class233.smethod_35(num2, num, bool_0: true, setting2.method_256());
					}
					else
					{
						class2.string_0 = string.Empty;
					}
					break;
				}
				case Enum41.const_4:
					class2.enum105_0 = PortFunction.smethod_13((uint)(settingOrSpecialObject as Setting).method_256());
					if (class2.enum105_0 == Enum105.BaF)
					{
						Class248 class4 = settingOrSpecialObject.method_6() as Class248;
						Class140 class5 = (Class140)(class2.class139_0 = new Class140(framework_0.awq.Count, class4.method_75().method_256(), class4.method_73().method_256(), class4.method_74().method_256(), list_0[i].method_2(), 20));
						class2.enum42_0 = Enum42.const_0;
						class2.bool_0 = class5.method_5();
					}
					break;
				}
				@class.list_0.Add(class2);
			}
			list_1.Add(@class);
		}
	}

	private void method_14(int int_10)
	{
		int num = 0;
		for (int i = 0; i < list_1.Count; i++)
		{
			if (list_1[i].bool_0)
			{
				num++;
			}
		}
		if (int_10 < 0 || int_10 >= list_2.Count || int_10 >= num)
		{
			return;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_1();
		framework_0.method_55();
		for (int j = int_10; j < list_1.Count - 1; j++)
		{
			list_2[j].method_29(list_2[j + 1], bool_0: true);
		}
		list_1[num - 1].bool_0 = false;
		framework_0.method_31(list_1[num - 1].uilistObject_0.RowIncludeSetting)?.method_272(0, bool_0: true);
		foreach (UIListSettingDataIdAndIndent currentUIListSettingsIdsAndIndent in list_1[list_1.Count - 1].uilistObject_0.CurrentUIListSettingsIdsAndIndents)
		{
			framework_0.method_31(currentUIListSettingsIdsAndIndent.DataId)?.method_246(bool_0: true);
		}
		framework_0.method_54(bool_0: true);
		@class?.method_4();
		method_18(int_10, num - 1);
		method_4();
	}

	private void method_15(int int_10, int int_11)
	{
		if (int_10 >= 0 && int_10 < list_2.Count && int_11 >= 0 && int_11 < list_2.Count)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_1();
			framework_0.method_55();
			SettingOrSpecialObject settingOrSpecialObject = list_2[int_10];
			int num = method_17(bool_0: true);
			if (num != -1)
			{
				list_2[num].method_29(settingOrSpecialObject, bool_0: true);
				method_16(num, int_11, bool_0: true);
			}
			framework_0.method_54(bool_0: true);
			@class?.method_4();
			method_4();
		}
	}

	private void method_16(int int_10, int int_11, bool bool_0 = false)
	{
		SettingOrSpecialObject.smethod_0(framework_0, list_2, int_10, int_11, !bool_0);
		if (!bool_0)
		{
			method_4();
		}
	}

	private int method_17(bool bool_0 = false)
	{
		if (list_1.Count > 0 && list_1[list_1.Count - 1].bool_0)
		{
			return -1;
		}
		Cursor current = System.Windows.Forms.Cursor.Current;
		System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
		int num = -1;
		Class280 @class = Form23.smethod_95();
		if (!bool_0)
		{
			@class?.method_1();
			framework_0.method_55();
		}
		for (int i = 0; i < list_1.Count; i++)
		{
			if (list_1[i].bool_0)
			{
				continue;
			}
			Setting setting = framework_0.method_31(list_1[i].uilistObject_0.RowIncludeSetting);
			if (setting != null)
			{
				setting.method_272(1, bool_0: true);
				Form23.smethod_74(setting.method_64());
				list_1[i].bool_0 = false;
				if (list_2[i] != null)
				{
					list_2[i].method_19().method_262(Class333.smethod_664(), bool_0: true);
				}
			}
			num = i;
			break;
		}
		System.Windows.Forms.Cursor.Current = current;
		if (!bool_0)
		{
			framework_0.method_54(bool_0: true);
			@class?.method_4();
		}
		if (num != -1)
		{
			method_18(num, num);
		}
		return num;
	}

	private void method_18(int int_10, int int_11)
	{
		for (int i = Math.Min(int_10, int_11); i <= Math.Max(int_11, int_10); i++)
		{
			SettingOrSpecialObject.smethod_1(list_2[i]);
		}
	}

	private void themedButton_0_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			method_17();
		}
		dataGridView_0.ClearSelection();
		dataGridView_0.Focus();
	}

	private void dataGridView_0_Scroll(object sender, ScrollEventArgs e)
	{
		if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
		{
			int_8 = e.NewValue;
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		string text = ((ToolStripMenuItem)sender).Text;
		if (!(text == Class333.smethod_657()))
		{
			if (!(text == Class333.smethod_658()))
			{
				if (text == Class333.smethod_659() && int_9 != -1)
				{
					method_14(int_9);
					int_9 = -1;
				}
			}
			else
			{
				int num = method_17();
				if (num != -1 && int_9 != -1)
				{
					method_16(num, int_9);
					int_9 = -1;
				}
			}
		}
		else if (int_9 != -1)
		{
			method_15(int_9, int_9);
			int_9 = -1;
		}
		dataGridView_0.ClearSelection();
	}

	private void dataGridView_0_KeyDown(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Delete:
			if (int_9 != -1)
			{
				method_14(int_9);
			}
			break;
		case Keys.Insert:
		{
			int num = method_17();
			if (num != -1 && int_9 != -1)
			{
				method_16(num, int_9);
			}
			break;
		}
		case Keys.V:
		{
			int num2 = int_9;
			if ((Control.ModifierKeys & Keys.Control) == Keys.Control && int_5 != -1 && num2 != -1 && int_5 < dataGridView_0.RowCount)
			{
				method_15(int_5, num2);
				if (num2 < int_5)
				{
					int_5++;
				}
			}
			break;
		}
		case Keys.C:
			if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
			{
				int_5 = int_9;
			}
			break;
		}
	}

	private void dataGridView_0_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		if (e.RowIndex != -1 && e.ColumnIndex < list_0.Count - 1)
		{
			e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
		}
	}

	private void dataGridView_1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		if (e.RowIndex != -1)
		{
			int num = 0;
			if (sender.Equals(dataGridView_1))
			{
				num = 2;
			}
			if (e.ColumnIndex < num - 1)
			{
				e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
			}
		}
	}

	private void dataGridView_0_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
	{
		if (e.RowIndex == int_4 && int_4 != int_3)
		{
			_ = dataGridView_0.RowHeadersWidth;
			Rectangle rectangle = ((int_4 >= int_3) ? new Rectangle(e.RowBounds.Left, e.RowBounds.Bottom - 2, dataGridView_0.Columns.GetColumnsWidth(DataGridViewElementStates.Visible), 2) : new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dataGridView_0.Columns.GetColumnsWidth(DataGridViewElementStates.Visible), 2));
			using Pen pen = new Pen(Color.DodgerBlue, 3f);
			e.Graphics.DrawLine(pen, rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Top);
		}
	}

	private void dataGridView_0_MouseDown(object sender, MouseEventArgs e)
	{
		contextMenuStrip_0.Enabled = false;
		DataGridView.HitTestInfo hitTestInfo = dataGridView_0.HitTest(e.X, e.Y);
		int_9 = hitTestInfo.RowIndex;
		if (e.Button == MouseButtons.Right && hitTestInfo.Type != DataGridViewHitTestType.None)
		{
			if (int_9 >= 0 && int_9 < dataGridView_0.RowCount)
			{
				contextMenuStrip_0.Enabled = true;
				contextMenuStrip_0.Show(dataGridView_0, new Point(e.X, e.Y));
			}
		}
		else
		{
			contextMenuStrip_0.Close();
		}
	}

	private void dataGridView_0_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.Button == MouseButtons.Left && dataGridView_0.RowCount > 1)
		{
			int_3 = e.RowIndex;
		}
	}

	private void dataGridView_1_SelectionChanged(object sender, EventArgs e)
	{
		if (sender is DataGridView)
		{
			DataGridView obj = sender as DataGridView;
			obj.ClearSelection();
			obj.CurrentCell = null;
		}
	}

	private void method_20(int int_10)
	{
		if (int_10 < 0)
		{
			return;
		}
		List<TreeNode> list = Form23.form23_0.control4_0.method_0().method_2();
		TreeNode treeNode = null;
		foreach (Class141 item in list_1[int_10].list_0)
		{
			if (item.int_1 != 0)
			{
				treeNode = Form23.form23_0.control4_0.method_65(list, new DataIdAndAttrId(item.int_1), bool_7: true, bool_8: false, bool_9: false);
				if (treeNode != null)
				{
					break;
				}
			}
		}
		if (treeNode != null)
		{
			Form23.form23_0.control4_0.method_0().method_4(treeNode);
		}
	}

	private void dataGridView_0_MouseMove(object sender, MouseEventArgs e)
	{
		DataGridView.HitTestInfo hitTestInfo = dataGridView_0.HitTest(e.X, e.Y);
		if (label_0 == null && int_3 != -1)
		{
			label_0 = new Label();
			label_0.Width = 200;
			label_0.BackColor = Form23.color_12;
			label_0.ForeColor = Form23.color_10;
			label_0.Font = new Font(label_0.Font.FontFamily, 9.75f, FontStyle.Bold);
			label_0.Text = Class333.smethod_665() + dataGridView_0[1, int_3].Value.ToString();
			label_0.Parent = dataGridView_0;
			label_0.Location = e.Location;
		}
		if (e.Button != MouseButtons.Left || label_0 == null)
		{
			return;
		}
		label_0.Location = e.Location;
		if (hitTestInfo.Type != DataGridViewHitTestType.None && hitTestInfo.RowIndex != int_4)
		{
			if (int_4 != -1)
			{
				dataGridView_0.InvalidateRow(int_4);
			}
			if (hitTestInfo.RowIndex != -1)
			{
				dataGridView_0.InvalidateRow(hitTestInfo.RowIndex);
			}
			int_4 = hitTestInfo.RowIndex;
			dataGridView_0.Refresh();
		}
	}

	private void dataGridView_0_MouseUp(object sender, MouseEventArgs e)
	{
		DataGridView.HitTestInfo hitTestInfo = dataGridView_0.HitTest(e.X, e.Y);
		int tickCount = Environment.TickCount;
		if (tickCount - int_6 < 300 && hitTestInfo.RowIndex >= 0 && int_7 == hitTestInfo.RowIndex && e.Button == MouseButtons.Left)
		{
			method_20(hitTestInfo.RowIndex);
			int_6 = tickCount;
			if (label_0 != null)
			{
				label_0.Dispose();
				label_0 = null;
			}
			return;
		}
		int_6 = tickCount;
		int_7 = hitTestInfo.RowIndex;
		if (label_0 != null)
		{
			int num = hitTestInfo.RowIndex;
			if (num == -1)
			{
				if (e.Y < 0)
				{
					num = 0;
				}
				else if (e.Y > dataGridView_0.Rows.Count * 20)
				{
					num = dataGridView_0.Rows.Count - 1;
				}
			}
			if (num != -1 && int_3 >= 0)
			{
				int num2 = num;
				if (num2 != -1 && int_3 != -1 && num2 != int_3)
				{
					method_16(int_3, num2);
					dataGridView_0.ClearSelection();
				}
			}
			label_0.Dispose();
			label_0 = null;
		}
		int_3 = -1;
		int_4 = -1;
	}
}
