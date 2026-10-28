using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal class Class123 : MovableResizablePanel, Interface3
{
	private delegate void Delegate40(object sender, EventArgs e);

	private delegate void Delegate41(object sender, EventArgs e);

	private delegate void Delegate42();

	private const int BML = 48;

	private const int BMl = 17;

	private const int BMM = 30;

	private const int BMm = 260;

	private Framework BMN;

	private Framework BMn;

	private MenuNode BMO;

	private SensorCalibration BMo;

	private Setting BMP;

	private Setting BMp;

	private Setting BMQ;

	private Setting BMq;

	private Setting BMR;

	private Setting BMr;

	private DataGridViewWithThemedScrollBars BMS = new DataGridViewWithThemedScrollBars();

	private Class76 BMs;

	private ThemedButton BMT = new ThemedButton();

	private ThemedButton BMt = new ThemedButton();

	private ThemedButton BMU = new ThemedButton();

	private ThemedButton BMu = new ThemedButton();

	private ThemedButton BMV = new ThemedButton();

	private Label BMv = new Label();

	private Label BMW = new Label();

	private Label BMw;

	private List<string> BMX = new List<string>();

	private bool BMx;

	private bool BMY;

	private MenuNode BMy;

	private Class286 BMZ;

	private bool BMz;

	private int[] BmA;

	private int[] Bma;

	private int BmB;

	private ToolStripMenuItem Bmb = new ToolStripMenuItem();

	private ToolStripMenuItem BmC = new ToolStripMenuItem();

	private ToolStripMenuItem Bmc = new ToolStripMenuItem();

	private string BmD = string.Empty;

	internal Class123(SensorCalibration sensorCalibration_0, MenuNode menuNode_0, Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: false)
	{
		BMN = framework_0;
		BMn = framework_1;
		BMO = menuNode_0;
		BMo = sensorCalibration_0;
		BMP = sensorCalibration_0.CalibrationValuesSetting;
		BMp = sensorCalibration_0.CalibrationVoltagesSetting;
		BMQ = sensorCalibration_0.CalibrationValueCountSetting;
		if (BMn != null)
		{
			BMq = BMn.method_31(BMP.method_64());
			BMR = BMn.method_31(BMp.method_64());
			BMr = BMn.method_31(BMQ.method_64());
		}
		method_12();
		BMx = BMN.method_2() && BMN.method_3() && BMP.method_96();
		BMY = BMn != null && BMn.method_2() && BMn.method_3() && BMq != null && BMq.method_96();
		if ((Form23.enum60_0 != Form23.Enum60.BpG || BMn == null) ? BMx : BMY)
		{
			Label label = new Label
			{
				Text = Class333.BCW(),
				ForeColor = Form23.color_12,
				BackColor = Color.Transparent,
				AutoSize = true,
				Left = 10,
				Top = 10
			};
			Controls.Add(label);
			Width = label.Right + 10;
		}
		else if (BMP != null && BMp != null && BMQ != null && ((Form23.enum60_0 == Form23.Enum60.BpG && BMn != null) || (BMP.method_35() && BMp.method_35())) && (Form23.enum60_0 != Form23.Enum60.BpG || BMn == null || BMq == null || BMR == null || (BMq.method_35() && BMR.method_35())))
		{
			BMT.Visible = BMZ == null || !BMz;
			BMT.Enabled = BMN.method_4();
			BMT.AutoSize = true;
			BMT.Text = Class333.smethod_2099();
			BMT.Click += BMT_Click;
			BMT.Left = 10;
			BMT.Top = 10;
			Controls.Add(BMT);
			BMt.Visible = BMZ == null || !BMz;
			BMt.AutoSize = true;
			BMt.Text = Class333.BCX();
			BMt.Click += BMt_Click;
			BMt.Left = BMT.Right + 5;
			BMt.Top = 10;
			Controls.Add(BMt);
			BMU.Visible = BMZ == null || !BMz;
			BMU.Enabled = BMN.method_4();
			BMU.AutoSize = true;
			BMU.Text = Class333.BCx();
			BMU.Click += Bmc_Click;
			BMU.Left = BMt.Right + 5;
			BMU.Top = 10;
			Controls.Add(BMU);
			BMu.Visible = BMZ == null || !BMz;
			BMu.AutoSize = true;
			BMu.Text = Class333.BCY();
			BMu.Click += BmC_Click;
			BMu.Enabled = false;
			BMu.Left = BMU.Right + 5;
			BMu.Top = 10;
			Controls.Add(BMu);
			BMV.Visible = BMZ == null || !BMz;
			BMV.AutoSize = true;
			BMV.Text = Class333.BCy();
			BMV.Click += Bmb_Click;
			BMV.Enabled = false;
			BMV.Left = BMu.Right + 5;
			BMV.Top = 10;
			Controls.Add(BMV);
			BMS.Left = 10;
			BMS.Top = BMV.Bottom + 5;
			BMS.Height = 60;
			if (rectangle_0 == Rectangle.Empty)
			{
				Width = Math.Max(600, BMV.Right + 10);
			}
			BMS.Width = Width - 20;
			BMS.ColumnHeadersVisible = false;
			BMS.RowHeadersVisible = true;
			BMS.RowHeadersWidth = 72;
			BMS.Visible = BMZ == null || !BMz;
			BMS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
			BMS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			BMS.AllowUserToAddRows = false;
			BMS.AllowUserToDeleteRows = false;
			BMS.AllowUserToResizeRows = false;
			BMS.AllowUserToOrderColumns = false;
			BMS.AllowUserToResizeColumns = false;
			BMS.ReadOnly = true;
			BMS.EnableHeadersVisualStyles = false;
			BMS.BackgroundColor = Form23.color_20;
			BMS.ColumnHeadersDefaultCellStyle.BackColor = BMS.BackgroundColor;
			BMS.RowHeadersDefaultCellStyle.BackColor = BMS.BackgroundColor;
			BMS.ColumnHeadersDefaultCellStyle.ForeColor = Form23.color_12;
			BMS.RowHeadersDefaultCellStyle.ForeColor = Form23.color_12;
			BMS.KeyDown += BMS_KeyDown;
			BMS.SelectionChanged += BMS_SelectionChanged;
			typeof(DataGridViewWithThemedScrollBars).InvokeMember(Class333.smethod_741(), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, BMS, new object[1] { true });
			if (BMN.method_4())
			{
				BMS.ContextMenuStrip = method_21();
			}
			foreach (SettingOrSpecialObject item in sensorCalibration_0.method_6().method_1())
			{
				if (!(item is Class244))
				{
					continue;
				}
				Class244 @class = item as Class244;
				int uint_ = @class.method_256();
				Enum104 enum104_ = PortFunction.smethod_12((uint)uint_);
				Enum105 enum105_ = PortFunction.smethod_13((uint)uint_);
				byte byte_ = PortFunction.smethod_14((uint)uint_);
				ushort ushort_ = PortFunction.smethod_15((uint)uint_);
				SettingOrSpecialObject settingOrSpecialObject = PortFunction.smethod_36(BMN, enum104_, enum105_, byte_, ushort_);
				if (settingOrSpecialObject != null && settingOrSpecialObject.method_12().method_1().Count != 0)
				{
					BMw = new Label();
					BMw.Text = Class333.smethod_612();
					BMw.ForeColor = Form23.color_12;
					BMw.Tag = new SettingOrSpecialObject[2] { settingOrSpecialObject, @class };
					BMw.AutoSize = false;
					BMw.Left = 10;
					BMw.Width = Width - 20;
					BMw.Height = (int)((float)BMw.Height * 0.7f);
					if (BMS.Visible)
					{
						BMw.Top = BMS.Bottom + 8;
					}
					else
					{
						BMw.Top = 8;
					}
					BMX.Clear();
					for (int i = 0; i < settingOrSpecialObject.method_12().method_1().Count; i++)
					{
						Setting setting = settingOrSpecialObject.method_12().method_1()[i];
						setting.method_265(method_15);
						setting.method_264(method_15);
						int num = setting.method_231();
						BMX.Add(Class233.smethod_35(setting.method_232(), num, bool_0: false, 0));
					}
					break;
				}
			}
			Class1.smethod_12(method_14);
			Form23.smethod_30(method_14);
			Form23.form23_0.method_9(method_13);
			BMP.method_264(method_17);
			BMp.method_264(method_18);
			BMQ.method_264(method_19);
			BMQ.method_40(method_20);
			if (Form23.enum60_0 == Form23.Enum60.BpG && BMR != null && BMq != null && BMr != null)
			{
				BMs = new Class76(BMn, BMS, BMR, BMq, BMr);
			}
			else
			{
				BMs = new Class76(BMN, BMS, BMp, BMP, BMQ);
			}
			BMs.Left = 10;
			BMs.Top = BMS.Bottom + 30;
			BMs.Width = BMS.Width;
			if (rectangle_0 == Rectangle.Empty)
			{
				if (BMS.Visible)
				{
					BMs.Height = 260;
					Height = BMs.Bottom + 10;
				}
				else
				{
					Height = 30;
				}
			}
			else if (BMS.Visible)
			{
				BMs.Height = Height - 10 - BMs.Top;
			}
			Controls.Add(BMS);
			if (BMw != null)
			{
				Controls.Add(BMw);
			}
			Controls.Add(BMs);
			BMW.Text = Class333.BCZ();
			BMW.ForeColor = Form23.color_9;
			BMW.AutoSize = true;
			BMW.Left = BMS.Left + 10;
			BMW.Top = BMS.Top + 41;
			BMW.Visible = false;
			Controls.Add(BMW);
			BMW.BringToFront();
			BMv.ForeColor = Form23.color_7;
			BMv.AutoSize = true;
			BMv.Visible = false;
			Controls.Add(BMv);
			BMv.BringToFront();
			BMS.Enabled = BMN.method_4();
			BMs.Visible = BMS.Visible;
		}
		else
		{
			Label label2 = new Label
			{
				Text = Class333.BCw(),
				ForeColor = Form23.color_12,
				BackColor = Color.Transparent,
				AutoSize = true,
				Left = 10,
				Top = 10
			};
			Controls.Add(label2);
			Width = label2.Right + 10;
			Height = label2.Bottom + 10;
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			BMS.KeyDown -= BMS_KeyDown;
			BMS.SelectionChanged -= BMS_SelectionChanged;
			Bmb.Click -= Bmb_Click;
			BmC.Click -= BmC_Click;
			Bmc.Click -= Bmc_Click;
			if (BMP != null)
			{
				BMP.method_265(method_17);
			}
			if (BMp != null)
			{
				BMp.method_265(method_18);
			}
			if (BMQ != null)
			{
				BMQ.method_265(method_19);
				BMQ.method_41(method_20);
			}
			BMT.Click -= BMT_Click;
			BMt.Click -= BMt_Click;
			BMU.Click -= Bmc_Click;
			BMu.Click -= BmC_Click;
			BMV.Click -= Bmb_Click;
			if (BMw != null)
			{
				SettingOrSpecialObject settingOrSpecialObject = (BMw.Tag as SettingOrSpecialObject[])[0];
				for (int i = 0; i < settingOrSpecialObject.method_12().method_1().Count; i++)
				{
					settingOrSpecialObject.method_12().method_1()[i].method_265(method_15);
				}
			}
			Class1.smethod_13(method_14);
			Form23.smethod_31(method_14);
			Form23.form23_0.method_10(method_13);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public Control imethod_0(DataIdAndAttrId dataIdAndAttrId_0)
	{
		if (BMS.Visible && Controls.Contains(BMS) && ((BMP != null && dataIdAndAttrId_0.DataId == BMP.method_64()) || (BMp != null && dataIdAndAttrId_0.DataId == BMp.method_64())))
		{
			return BMS;
		}
		return null;
	}

	public Control imethod_1()
	{
		foreach (Control control in Controls)
		{
			if (!(control is Label))
			{
				return control;
			}
		}
		return null;
	}

	private void method_12()
	{
		BMy = BMO.method_83(BMP);
		if (BMy != null)
		{
			BMZ = BMy.method_80().BcF;
			BMz = BMy.method_84();
		}
		if (BMZ == null)
		{
			return;
		}
		int[] array = BMZ.method_3(BMQ);
		if (array != null && array.Length == 1)
		{
			int[] array2 = BMZ.method_3(BMP);
			int[] array3 = BMZ.method_3(BMp);
			if (array2 != null && array2.Length == BMP.method_277() && array3 != null && array3.Length == BMp.method_277())
			{
				BmA = array2;
				Bma = array3;
				BmB = array[0];
			}
			else
			{
				BMZ = null;
			}
		}
		else
		{
			BMZ = null;
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		method_16();
	}

	private void method_14(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate40 method = method_14;
				BeginInvoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if ((!Form23.smethod_28(BMN.aXc, bool_53: true) || Form23.smethod_80()) && BMw != null)
		{
			BMw.Text = Class333.smethod_612();
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		if (!method_0() || Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		if (InvokeRequired)
		{
			try
			{
				Delegate41 method = method_15;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		Setting setting = sender as Setting;
		SettingOrSpecialObject settingOrSpecialObject = ((setting.method_12().method_12().BSQ != Enum104.BAM) ? setting.method_6() : setting);
		if ((BMw.Tag as SettingOrSpecialObject[])[0] != settingOrSpecialObject)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < settingOrSpecialObject.method_12().method_1().Count; i++)
		{
			if (Form23.smethod_84(settingOrSpecialObject.method_12().method_1()[i].method_64()))
			{
				flag = true;
				break;
			}
		}
		if ((!Form23.smethod_28(BMN.aXc, bool_53: true) || Form23.smethod_80()) && !flag)
		{
			BMw.Text = Class333.smethod_612();
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int j = 0; j < settingOrSpecialObject.method_12().method_1().Count; j++)
		{
			Setting setting2 = settingOrSpecialObject.method_12().method_1()[j];
			if (!setting2.method_35() || !PortFunction.smethod_52(setting2))
			{
				continue;
			}
			(string, string, bool) tuple = setting2.method_252();
			string text = setting2.method_60(Enum96.aYu);
			if (!string.IsNullOrEmpty(text))
			{
				stringBuilder.Append(text + Class333.smethod_571());
			}
			stringBuilder.Append(tuple.Item1);
			if (!string.IsNullOrEmpty(tuple.Item2))
			{
				if (BMX[j] == Class333.smethod_879())
				{
					stringBuilder.Append(Class333.smethod_880());
				}
				else
				{
					stringBuilder.Append(Class333.smethod_325() + BMX[j]);
				}
			}
			stringBuilder.Append(Class333.smethod_881());
		}
		string text2 = BMo.method_18();
		string text3 = (string.IsNullOrWhiteSpace(text2) ? BMo.method_60(Enum96.aYt) : text2);
		if (!string.IsNullOrEmpty(text3))
		{
			(string, string, bool) tuple2 = BMo.method_252();
			stringBuilder.Append(text3 + Class333.smethod_571() + tuple2.Item1);
			if (!string.IsNullOrEmpty(tuple2.Item2))
			{
				stringBuilder.Append(Class333.smethod_325() + tuple2.Item2);
			}
		}
		BMw.Text = stringBuilder.ToString();
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		if (!((Form23.enum60_0 != Form23.Enum60.BpG || BMn == null) ? BMx : BMY))
		{
			BMS.Width = Width - 20;
			BMs.Width = BMS.Width;
			BMs.Height = Height - 10 - BMs.Top;
			method_16();
		}
	}

	internal void method_16()
	{
		BMS.Enabled = BMN.method_4();
		if ((Form23.enum60_0 != Form23.Enum60.BpG || BMn == null) ? BMx : BMY)
		{
			return;
		}
		Setting setting;
		Setting setting2;
		Setting setting3;
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			setting = BMq;
			setting2 = BMR;
			setting3 = BMr;
		}
		else
		{
			setting = BMP;
			setting2 = BMp;
			setting3 = BMQ;
		}
		if (setting == null || setting2 == null || setting3 == null || !setting.method_35() || !setting2.method_35())
		{
			return;
		}
		if (InvokeRequired)
		{
			try
			{
				Delegate42 method = method_16;
				Invoke(method);
				return;
			}
			catch
			{
				return;
			}
		}
		int num = setting3.method_256();
		if (num == 0)
		{
			BMS.Columns.Clear();
			BMS.Rows.Clear();
			BMS.Visible = BMZ == null || !BMz;
			BMS.ColumnCount = 0;
			BMS.method_4();
			if (BMs != null)
			{
				BMs.Visible = BMS.Visible;
				BMs.Invalidate();
			}
			if ((BMZ == null || !BMz) && !setting3.method_122() && setting3.method_123().Count != 0)
			{
				BMv.Left = BMS.Left + 10;
				BMv.Top = BMS.Top + 10;
				BMv.Text = setting3.method_123()[0];
				BMv.Visible = true;
			}
			else
			{
				BMv.Visible = false;
			}
			return;
		}
		SuspendLayout();
		BMW.Visible = (BMZ == null || !BMz) && !BMx && !BMY && BMq != null && BMR != null && BMr != null && (!BMP.method_282(BMq) || !BMp.method_282(BMR) || !BMQ.method_282(BMr));
		bool[,] array = new bool[2, num];
		for (int i = 0; i < num; i++)
		{
			if (BMS.Rows.Count != 0 && i < BMS.Rows[0].Cells.Count)
			{
				array[0, i] = BMS.Rows[0].Cells[i].Selected;
				array[1, i] = BMS.Rows[1].Cells[i].Selected;
			}
			else
			{
				array[0, i] = false;
				array[1, i] = false;
			}
		}
		int num2 = 0;
		int index = 0;
		if (BMS.CurrentCell != null)
		{
			num2 = BMS.CurrentCell.ColumnIndex;
			index = BMS.CurrentCell.RowIndex;
		}
		BMS.Columns.Clear();
		BMS.Rows.Clear();
		BMS.Visible = BMZ == null || !BMz;
		BMS.ColumnCount = num;
		int num3 = setting2.method_231();
		int num4 = setting.method_231();
		string[] array2 = new string[num];
		string[] array3 = new string[num];
		for (int j = 0; j < num; j++)
		{
			string text = Class233.smethod_29(setting2.method_258(j), num3);
			array2[j] = text;
			string text2 = Class233.smethod_29(setting.method_258(j), num4);
			array3[j] = text2;
		}
		DataGridViewRowCollection rows = BMS.Rows;
		object[] values = array2;
		rows.Add(values);
		DataGridViewRowCollection rows2 = BMS.Rows;
		values = array3;
		rows2.Add(values);
		for (int k = 0; k < num; k++)
		{
			BMS.Columns[k].Width = 48;
			if (BMZ != null && BMy.method_88() && Bma != null && BmA != null)
			{
				if (k >= BmB)
				{
					BMS.Columns[k].DefaultCellStyle.Font = new Font(Font.FontFamily, 8f, FontStyle.Italic);
				}
				else if (setting2.method_258(k) == Bma[k] && setting.method_258(k) == BmA[k])
				{
					BMS.Columns[k].DefaultCellStyle.Font = new Font(Font.FontFamily, 8f);
				}
				else
				{
					BMS.Columns[k].DefaultCellStyle.Font = new Font(Font.FontFamily, 8f, FontStyle.Italic);
				}
			}
			else
			{
				BMS.Columns[k].DefaultCellStyle.Font = new Font(Font.FontFamily, 8f);
			}
		}
		BMS.Rows[0].Height = 17;
		BMS.Rows[1].Height = 17;
		BMS.Rows[0].HeaderCell.Value = Class233.smethod_35(setting2.method_232(), num3, bool_0: false, 0);
		BMS.Rows[1].HeaderCell.Value = Class233.smethod_35(setting.method_232(), num4, bool_0: false, 0);
		if (num2 < BMS.Rows[index].Cells.Count)
		{
			BMS.CurrentCell = BMS.Rows[index].Cells[num2];
		}
		else
		{
			BMS.CurrentCell = BMS.Rows[index].Cells[BMS.Rows[index].Cells.Count - 1];
		}
		for (int l = 0; l < num; l++)
		{
			BMS.Rows[0].Cells[l].Selected = array[0, l];
			BMS.Rows[1].Cells[l].Selected = array[1, l];
		}
		if (BMS.SelectedCells != null && BMS.SelectedCells.Count != 0)
		{
			BmC.Enabled = BMN.method_4() && setting3.method_256() != 0;
			BMu.Enabled = BmC.Enabled;
		}
		else
		{
			BmC.Enabled = false;
			BMu.Enabled = false;
		}
		ResumeLayout(performLayout: true);
		if (BMs != null)
		{
			BMs.Visible = BMS.Visible;
			BMs.Invalidate();
		}
		BMS.method_4();
		if ((BMZ == null || !BMz) && !setting3.method_122() && setting3.method_123().Count != 0)
		{
			if (BMS.Visible)
			{
				BMv.Left = BMS.Left + BMS.RowHeadersWidth + BMS.ColumnCount * 48 + 10;
				BMv.Top = BMS.Top + 10;
			}
			else
			{
				BMv.Left = BMS.Left + 10;
				BMv.Top = BMS.Top + 10;
			}
			BMv.Text = setting3.method_123()[0];
			BMv.Visible = true;
		}
		else
		{
			BMv.Visible = false;
		}
	}

	private void method_17(object sender, EventArgs e)
	{
		method_16();
		Form23.smethod_74(BMP.method_64());
		Form23.smethod_74(BMp.method_64());
		Form23.smethod_74(BMQ.method_64());
	}

	private void method_18(object sender, EventArgs e)
	{
		method_16();
		Form23.smethod_74(BMP.method_64());
		Form23.smethod_74(BMp.method_64());
		Form23.smethod_74(BMQ.method_64());
	}

	private void method_19(object sender, EventArgs e)
	{
		method_16();
		Form23.smethod_74(BMP.method_64());
		Form23.smethod_74(BMp.method_64());
		Form23.smethod_74(BMQ.method_64());
	}

	private void method_20(object sender, EventArgs e)
	{
		method_16();
	}

	private void BMS_SelectionChanged(object sender, EventArgs e)
	{
		BMs.Invalidate();
		if (BmD != string.Empty)
		{
			BmD = string.Empty;
			method_16();
		}
		if (BMS.SelectedCells != null && BMS.SelectedCells.Count != 0)
		{
			Bmb.Enabled = BMN.method_4();
			BMV.Enabled = Bmb.Enabled;
			BmC.Enabled = BMN.method_4() && BMQ.method_256() != 0;
			BMu.Enabled = BmC.Enabled;
		}
		else
		{
			Bmb.Enabled = false;
			BMV.Enabled = false;
			BmC.Enabled = false;
			BMu.Enabled = false;
		}
	}

	private ContextMenuStrip method_21()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip
		{
			BackColor = Form23.color_15,
			ForeColor = Form23.color_12
		};
		Bmb.Text = Class333.BCy();
		Bmb.Enabled = false;
		Bmb.Click += Bmb_Click;
		contextMenuStrip.Items.Add(Bmb);
		BmC.Text = Class333.BCY();
		BmC.Enabled = false;
		BmC.Click += BmC_Click;
		contextMenuStrip.Items.Add(BmC);
		Bmc.Text = Class333.BCx();
		Bmc.Click += Bmc_Click;
		contextMenuStrip.Items.Add(Bmc);
		return contextMenuStrip;
	}

	private void Bmb_Click(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BMN.method_4())
		{
			return;
		}
		int num = BMQ.method_256();
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < num; i++)
		{
			if (BMS.Rows[0].Cells[i].Selected)
			{
				flag = true;
			}
			if (BMS.Rows[1].Cells[i].Selected)
			{
				flag2 = true;
			}
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BMP.method_64());
		if (flag)
		{
			BMp.method_268();
			method_22(BMS.SelectedCells[0].ColumnIndex, BMS.SelectedCells[BMS.SelectedCells.Count - 1].ColumnIndex);
			BMp.method_267(bool_0: true);
		}
		if (flag2)
		{
			BMP.method_268();
			method_23(BMS.SelectedCells[0].ColumnIndex, BMS.SelectedCells[BMS.SelectedCells.Count - 1].ColumnIndex);
			BMP.method_267(bool_0: true);
		}
		@class?.method_4();
	}

	private void method_22(int int_3, int int_4)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BMN.method_4())
		{
			return;
		}
		int num = Math.Max(int_3, int_4);
		int num2 = Math.Min(int_3, int_4);
		int num3 = num - num2 + 1;
		if (num3 > 1)
		{
			int num4 = BMp.method_258(num2);
			int num5 = (BMp.method_258(num) - num4) / (num3 - 1);
			for (int i = 1; i < num3 - 1; i++)
			{
				BMp.method_274(num2 + i, num4 + i * num5, bool_0: true);
			}
		}
	}

	private void method_23(int int_3, int int_4)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BMN.method_4())
		{
			return;
		}
		int num = Math.Max(int_3, int_4);
		int num2 = Math.Min(int_3, int_4);
		int num3 = num - num2 + 1;
		int num4 = BMP.method_258(num) - BMP.method_258(num2);
		int num5 = BMp.method_258(num) - BMp.method_258(num2);
		if (num5 != 0)
		{
			float num6 = (float)num4 / (float)num5;
			int num7 = BMP.method_258(num2) - (int)Math.Round(num6 * (float)BMp.method_258(num2));
			for (int i = 1; i < num3 - 1; i++)
			{
				int num8 = BMp.method_258(num2 + i);
				int num9 = (int)Math.Round(num6 * (float)num8 + (float)num7);
				BMP.method_274(num2 + i, num9, bool_0: true);
			}
		}
	}

	private List<int> method_24()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < BMS.Rows[0].Cells.Count; i++)
		{
			bool flag = false;
			for (int j = 0; j < 2; j++)
			{
				if (BMS.Rows[j].Cells[i].Selected)
				{
					flag = true;
				}
			}
			if (flag)
			{
				list.Add(i);
			}
		}
		return list;
	}

	private void method_25(int int_3)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG && BMN.method_4())
		{
			int num = BMQ.method_256();
			for (int i = int_3 + 1; i < num; i++)
			{
				BMp.method_274(i - 1, BMp.method_258(i), bool_0: true);
				BMP.method_274(i - 1, BMP.method_258(i), bool_0: true);
			}
			BMQ.method_272(num - 1, bool_0: true);
		}
	}

	private void BmC_Click(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BMN.method_4() || BMQ.method_256() == 0 || BMS.SelectedCells == null || BMS.SelectedCells.Count == 0)
		{
			return;
		}
		List<int> list = method_24();
		int num = list[0];
		int count = list.Count;
		int num2 = BMp.method_231();
		string arg = Class233.smethod_29(BMp.method_258(num), num2);
		if (count == 1)
		{
			if (Form54.smethod_6(Form23.form23_0, string.Format(Class333.BCz(), arg), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				Class280 @class = Form23.smethod_95();
				@class?.method_2(BMP.method_64());
				BMp.method_268();
				BMP.method_268();
				BMQ.method_268();
				for (int i = 0; i < count; i++)
				{
					method_25(num);
				}
				BMp.method_267(bool_0: true);
				BMP.method_267(bool_0: true);
				BMQ.method_267(bool_0: true);
				@class?.method_4();
			}
			return;
		}
		string arg2 = Class233.smethod_29(BMp.method_258(num + count - 1), num2);
		if (Form54.smethod_6(Form23.form23_0, string.Format(Class333.BcA(), arg, arg2), Class333.smethod_1130(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			Class280 class2 = Form23.smethod_95();
			class2?.method_2(BMP.method_64());
			BMp.method_268();
			BMP.method_268();
			BMQ.method_268();
			for (int j = 0; j < count; j++)
			{
				method_25(num);
			}
			BMp.method_267(bool_0: true);
			BMP.method_267(bool_0: true);
			BMQ.method_267(bool_0: true);
			class2?.method_4();
		}
	}

	private void Bmc_Click(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BMN.method_4())
		{
			return;
		}
		int num = BMQ.method_256();
		if (num == BMP.method_242()[2])
		{
			Form54.smethod_6(Form23.form23_0, string.Format(Class333.Bca(), num), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		int int_ = BMp.method_231();
		int int_2 = BMp.method_232();
		int num2 = BMp.method_228();
		int num3 = BMp.method_229();
		Form12 form = new Form12(Class333.BCx(), Keys.None, Class333.smethod_102(), int_, int_2, num2, num3, num2, num3, null);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			int num4 = Class233.smethod_26(form.method_0(), int_);
			int num5 = 0;
			int num6 = num - 1;
			while (num6 >= 0)
			{
				int num7 = BMp.method_258(num6);
				if (num4 <= num7)
				{
					num6--;
					continue;
				}
				num5 = num6 + 1;
				break;
			}
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BMP.method_64());
			BMp.method_268();
			BMP.method_268();
			BMQ.method_268();
			for (int num8 = BMQ.method_256() - 1; num8 >= num5; num8--)
			{
				BMp.method_274(num8 + 1, BMp.method_258(num8), bool_0: true);
				BMP.method_274(num8 + 1, BMP.method_258(num8), bool_0: true);
			}
			BMp.method_274(num5, num4, bool_0: true);
			if (num5 == 0)
			{
				BMP.method_274(0, BMP.method_258(1), bool_0: true);
			}
			else if (num5 == num)
			{
				BMP.method_274(num5, BMP.method_258(num5 - 1), bool_0: true);
			}
			else
			{
				method_23(num5 - 1, num5 + 1);
			}
			BMQ.method_272(BMQ.method_256() + 1, bool_0: true);
			BMp.method_267(bool_0: true);
			BMP.method_267(bool_0: true);
			BMQ.method_267(bool_0: true);
			@class?.method_4();
		}
		form.Dispose();
	}

	private void method_26()
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !(BmD != string.Empty))
		{
			return;
		}
		for (int i = 0; i < BMQ.method_256(); i++)
		{
			if (BMS.Rows[0].Cells[i].Selected)
			{
				BMS.Rows[0].Cells[i].Value = BmD;
			}
			else if (BMS.Rows[1].Cells[i].Selected)
			{
				BMS.Rows[1].Cells[i].Value = BmD;
			}
		}
	}

	private void BMS_KeyDown(object sender, KeyEventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BMN.method_4() || BMS.SelectedCells == null || BMS.SelectedCells.Count == 0)
		{
			return;
		}
		if (e.KeyData == Keys.Delete)
		{
			BmC_Click(null, null);
			return;
		}
		if (e.KeyData == Keys.Insert)
		{
			Bmc_Click(null, null);
			return;
		}
		if (e.KeyData == Keys.L)
		{
			Bmb_Click(null, null);
			return;
		}
		int num = BMQ.method_256();
		int num2 = -1;
		bool flag = false;
		bool flag2 = false;
		int num3 = 0;
		while (true)
		{
			if (num3 < num)
			{
				if (BMS.Rows[0].Cells[num3].Selected)
				{
					if (flag)
					{
						break;
					}
					num2 = num3;
					flag = true;
				}
				if (BMS.Rows[1].Cells[num3].Selected)
				{
					flag2 = true;
				}
				num3++;
				continue;
			}
			Setting setting;
			if (flag && !flag2)
			{
				setting = BMp;
			}
			else
			{
				if (!flag2 || flag)
				{
					break;
				}
				setting = BMP;
			}
			if (BmD == string.Empty)
			{
				if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
				{
					BmD = ((int)(e.KeyCode - 48)).ToString();
				}
				else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
				{
					BmD = ((int)(e.KeyCode - 96)).ToString();
				}
				else if (e.KeyCode != Keys.OemMinus && e.KeyCode != Keys.Subtract)
				{
					if (e.Control && e.KeyCode == Keys.V)
					{
						Class280 @class = Form23.smethod_95();
						@class?.method_2(BMP.method_64());
						try
						{
							if (Clipboard.ContainsText())
							{
								string text = Clipboard.GetText();
								int num4 = text.Split('\n')[0].Split('\t').Length;
								int val = setting.method_228();
								int val2 = setting.method_229();
								int num5 = 0;
								for (int i = 0; i < num; i++)
								{
									if (BMS.Rows[0].Cells[i].Selected || BMS.Rows[1].Cells[i].Selected)
									{
										num5 = i;
										break;
									}
								}
								int num6 = Math.Min(num, num5 + num4) - 1;
								setting.method_268();
								for (int j = num5; j <= num6; j++)
								{
									string text2 = text.Split('\n')[0].Split('\t')[j - num5];
									if (text2.EndsWith(Class333.smethod_2225()))
									{
										text2 = text2.Substring(0, text2.Length - 1);
									}
									int val3 = Class233.smethod_25(text2, setting.method_231());
									val3 = Math.Min(Math.Max(val3, val), val2);
									setting.method_274(j, val3, bool_0: true);
								}
								setting.method_267(bool_0: true);
							}
						}
						catch
						{
						}
						@class?.method_4();
					}
				}
				else
				{
					BmD = Class333.smethod_186();
				}
			}
			else if (e.KeyCode == Keys.Back)
			{
				if (BmD.Length == 1)
				{
					BmD = string.Empty;
					method_16();
				}
				else
				{
					BmD = BmD.Substring(0, BmD.Length - 1);
				}
			}
			else if (e.KeyCode == Keys.Escape)
			{
				BmD = string.Empty;
				method_16();
			}
			else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
			{
				BmD += (int)(e.KeyCode - 48);
			}
			else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
			{
				BmD += (int)(e.KeyCode - 96);
			}
			else if (e.KeyCode == Keys.Decimal)
			{
				BmD += CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			}
			else if (e.KeyCode == Keys.OemPeriod)
			{
				if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == Class333.smethod_190())
				{
					BmD += Class333.smethod_190();
				}
			}
			else if (e.KeyCode == Keys.Oemcomma)
			{
				if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == Class333.smethod_189())
				{
					BmD += Class333.smethod_189();
				}
			}
			else if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
			{
				Class280 class2 = Form23.smethod_95();
				class2?.method_2(BMP.method_64());
				int num7 = setting.method_228();
				int num8 = setting.method_229();
				int num9 = setting.method_231();
				bool flag3 = false;
				try
				{
					int num10 = Class233.smethod_25(BmD, num9);
					if ((num7 != 0 || num8 != 0) && (num10 < num7 || num10 > num8))
					{
						throw new Exception();
					}
					double num11 = double.Parse(BmD, NumberStyles.Any, CultureInfo.CurrentCulture);
					if (flag && num >= 2)
					{
						if (BMS.Rows[0].Cells[0].Selected)
						{
							if (num11 > double.Parse((string)BMS.Rows[0].Cells[1].Value, NumberStyles.Any, CultureInfo.CurrentCulture))
							{
								flag3 = true;
								throw new Exception();
							}
						}
						else if (BMS.Rows[0].Cells[num - 1].Selected)
						{
							if (num11 < double.Parse((string)BMS.Rows[0].Cells[num - 2].Value, NumberStyles.Any, CultureInfo.CurrentCulture))
							{
								flag3 = true;
								throw new Exception();
							}
						}
						else if (num >= 3 && (num11 > double.Parse((string)BMS.Rows[0].Cells[num2 + 1].Value, NumberStyles.Any, CultureInfo.CurrentCulture) || num11 < double.Parse((string)BMS.Rows[0].Cells[num2 - 1].Value, NumberStyles.Any, CultureInfo.CurrentCulture)))
						{
							flag3 = true;
							throw new Exception();
						}
					}
					int num12 = Class233.smethod_26(num11, num9);
					for (int k = 0; k < num; k++)
					{
						if (BMS.Rows[0].Cells[k].Selected || BMS.Rows[1].Cells[k].Selected)
						{
							setting.method_274(k, num12, bool_0: true);
						}
					}
				}
				catch (Exception)
				{
					if (flag3)
					{
						Form54.smethod_6(Form23.form23_0, Class333.BcB(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else if (num7 == 0 && num8 == 0)
					{
						Form54.smethod_6(Form23.form23_0, string.Format(Class333.Bcb(), BmD), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						string arg = Class233.smethod_29(num7, num9);
						string arg2 = Class233.smethod_29(num8, num9);
						Form54.smethod_6(Form23.form23_0, string.Format(Class333.smethod_1050(), BmD, arg, arg2), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				class2?.method_4();
				e.Handled = true;
				BmD = string.Empty;
				method_16();
				if (e.KeyCode == Keys.Tab)
				{
					e.Handled = false;
				}
			}
			method_26();
			break;
		}
	}

	private void BMT_Click(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BMN.method_4())
		{
			return;
		}
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = Class333.BcC();
		openFileDialog.InitialDirectory = Form23.string_15;
		if (openFileDialog.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			StreamReader streamReader = new StreamReader(new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read));
			string[] array = null;
			try
			{
				if (streamReader.ReadLine() != Class333.Bcc())
				{
					Form54.smethod_6(Form23.form23_0, Class333.BcD(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					streamReader.Close();
					openFileDialog.Dispose();
					return;
				}
			}
			catch
			{
				Form54.smethod_6(Form23.form23_0, Class333.BcD(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				streamReader.Close();
				openFileDialog.Dispose();
				return;
			}
			int[] array2 = new int[BMp.method_242()[2]];
			int[] array3 = new int[BMP.method_242()[2]];
			int num = 0;
			int result = 3;
			int result2 = 7;
			bool flag = true;
			while (!streamReader.EndOfStream)
			{
				string[] array4 = null;
				int num2 = 0;
				string[] array5 = streamReader.ReadLine().Trim().Split(Class333.smethod_134().ToCharArray());
				if (array5.Length == 2)
				{
					array5[0] = array5[0].Trim();
					array5[1] = array5[1].Trim();
					array = array5;
				}
				else
				{
					array = new string[0];
				}
				if (array.Length == 0)
				{
					continue;
				}
				string text = array[0];
				if (!(text == Class333.Bcd()))
				{
					if (!(text == Class333.smethod_684()))
					{
						if (!(text == Class333.BcE()))
						{
							if (text == Class333.Bce() && !int.TryParse(array[1], out result))
							{
								flag = false;
							}
						}
						else if (!int.TryParse(array[1], out result2))
						{
							flag = false;
						}
						continue;
					}
					num2 = 0;
					array4 = array[1].Split(Class333.smethod_189().ToCharArray());
					for (int i = 0; i < array4.Length && i < BMP.method_242()[2]; i++)
					{
						int result3 = 0;
						if (int.TryParse(array4[i], out result3))
						{
							array3[i] = result3;
						}
						num2++;
					}
					if (num2 != num)
					{
						flag = false;
					}
					continue;
				}
				num2 = 0;
				array4 = array[1].Split(Class333.smethod_189().ToCharArray());
				for (int j = 0; j < array4.Length && j < BMp.method_242()[2]; j++)
				{
					int result4 = 0;
					if (int.TryParse(array4[j], out result4))
					{
						array2[j] = result4;
					}
					num2++;
				}
				num = num2;
			}
			if (flag && num != 0)
			{
				if (BMP.method_231() != result)
				{
					for (int k = 0; k < array3.Length; k++)
					{
						double double_ = Class233.smethod_28(array3[k], result);
						array3[k] = Class233.smethod_26(double_, BMP.method_231());
					}
				}
				if (BMp.method_231() != result2)
				{
					for (int l = 0; l < array2.Length; l++)
					{
						double double_2 = Class233.smethod_28(array2[l], result2);
						array2[l] = Class233.smethod_26(double_2, BMp.method_231());
					}
				}
				Class280 @class = Form23.smethod_95();
				@class?.method_2(BMP.method_64());
				BMp.method_268();
				BMP.method_268();
				BMQ.method_268();
				for (int m = 0; m < BMp.method_242()[2]; m++)
				{
					if (m < num)
					{
						BMp.method_274(m, array2[m], bool_0: true);
						BMP.method_274(m, array3[m], bool_0: true);
					}
					else
					{
						BMp.method_274(m, 0, bool_0: true);
						BMP.method_274(m, 0, bool_0: true);
					}
				}
				BMQ.method_272(num, bool_0: true);
				BMp.method_267(bool_0: true);
				BMP.method_267(bool_0: true);
				BMQ.method_267(bool_0: true);
				@class?.method_4();
			}
			else
			{
				Form54.smethod_6(Form23.form23_0, Class333.BcD(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			streamReader.Close();
		}
		openFileDialog.Dispose();
	}

	private void BMt_Click(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = Class333.BcC();
		saveFileDialog.InitialDirectory = Form23.string_15;
		if (saveFileDialog.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			StreamWriter streamWriter = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write));
			streamWriter.WriteLine(Class333.Bcc());
			streamWriter.WriteLine(string.Format(Class333.smethod_988(), 0));
			streamWriter.WriteLine(string.Format(Class333.BcF(), Class333.smethod_343()));
			streamWriter.WriteLine(string.Format(Class333.Bcf(), BMp.method_231()));
			streamWriter.WriteLine(string.Format(Class333.BcG(), BMP.method_231()));
			int num = BMQ.method_256();
			string text = string.Empty;
			if (num > 0)
			{
				text = BMp.method_258(0).ToString();
			}
			for (int i = 1; i < num; i++)
			{
				text = string.Format(Class333.smethod_191(), text, BMp.method_258(i));
			}
			streamWriter.WriteLine(Class333.Bcg() + text);
			string text2 = string.Empty;
			if (num > 0)
			{
				text2 = BMP.method_258(0).ToString();
			}
			for (int j = 1; j < num; j++)
			{
				text2 = string.Format(Class333.smethod_191(), text2, BMP.method_258(j));
			}
			streamWriter.WriteLine(Class333.BcH() + text2);
			streamWriter.Close();
		}
		saveFileDialog.Dispose();
	}
}
