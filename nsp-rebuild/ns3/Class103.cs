using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns1;
using ns2;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns3;

internal class Class103 : Class101
{
	private enum Enum31
	{
		bae,
		baF
	}

	private struct Struct9
	{
		internal Enum31 baf;

		internal int baG;

		internal int bag;

		internal float baH;

		public override string ToString()
		{
			return baf.ToString() + Class333.BJi() + baG + Class333.BJJ() + bag + Class333.BJj() + baH;
		}
	}

	private const float Buu = 0f;

	private const float BuV = -2f;

	private const float Buv = 1f;

	private const int BuW = 64;

	private const int Buw = 16;

	private const int BuX = 20;

	private bool Bux;

	private string BuY;

	private string Buy;

	private SolidBrush BuZ;

	private Pen Buz;

	private Pen BVA = new Pen(Color.FromArgb(200, 200, 200), 1f);

	private Pen BVa = new Pen(Color.FromArgb(100, 100, 100), 1f);

	private Pen BVB = new Pen(Color.FromArgb(0, 0, 0), 1f);

	private Pen BVb = new Pen(Color.Blue, 3f);

	private Font BVC;

	private StringFormat BVc = new StringFormat();

	private StringFormat BVD = new StringFormat();

	private int[] BVd = new int[4];

	private PointF[] BVE = new PointF[4];

	private Color[] BVe = new Color[4];

	private GraphicsPath BVF = new GraphicsPath();

	private PathGradientBrush BVf;

	private int[] BVG = new int[64];

	private int[] BVg = new int[64];

	private AxisBehaviour BVH = AxisBehaviour.Continuous;

	private AxisBehaviour BVh = AxisBehaviour.Continuous;

	private int[,,] BVI = new int[16, 64, 64];

	private int BVi;

	private int BVJ;

	private float[,] BVj = new float[64, 64];

	private float[,] BVK = new float[64, 64];

	private float[,] BVk = new float[64, 64];

	private float[,] BVL = new float[64, 64];

	private float[,] BVl = new float[64, 64];

	private float[,] BVM = new float[64, 64];

	private float[,] BVm = new float[64, 64];

	private Struct9[] BVN = new Struct9[7938];

	private Label BVn = new Label();

	private bool BVO;

	private bool BVo;

	private int BVP;

	private int BVp;

	private float BVQ;

	private float BVq;

	private bool BVR;

	private ToolStripMenuItem BVr;

	internal Class103(Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(framework_0, framework_1, rectangle_0, bool_0)
	{
		DoubleBuffered = true;
		if (BVO)
		{
			BVn.ForeColor = Form23.color_12;
			BVn.Left = 10;
			BVn.Top = 100;
			BVn.AutoSize = true;
			BVn.MinimumSize = new Size(170, 0);
			BVn.MaximumSize = new Size(170, 600);
			Controls.Add(BVn);
		}
		GotFocus += Class103_GotFocus;
		LostFocus += Class103_LostFocus;
		BVC = new Font(Font.FontFamily, 8f);
	}

	internal override void vmethod_2(int int_3)
	{
		Setting setting = BKD.method_31(int_3);
		if (setting != null)
		{
			BKE = setting as Table;
		}
		else
		{
			BKE = null;
		}
		if (BKE != null)
		{
			BKF = BKE.method_64();
			if (BKE != null && BKd != null)
			{
				BKe = BKd.method_31(int_3) as Table;
			}
			else
			{
				BKe = null;
			}
		}
		else
		{
			BKe = null;
		}
		if (BKE != null && BKe != null)
		{
			if (BKe.InvertRows != BKE.InvertRows)
			{
				BKe.InvertRows = BKE.InvertRows;
			}
			if (BKe.SwapColumnsAndRows != BKE.SwapColumnsAndRows)
			{
				BKe.SwapColumnsAndRows = BKE.SwapColumnsAndRows;
			}
			if (BKe.HorizVertIndexPerUserSelectedCell != BKE.HorizVertIndexPerUserSelectedCell)
			{
				BKe.HorizVertIndexPerUserSelectedCell = BKE.HorizVertIndexPerUserSelectedCell;
			}
		}
		BKi = BKD.method_2() && BKD.method_3() && BKE != null && BKE.method_96();
		BKJ = BKd != null && BKd.method_2() && BKd.method_3() && BKe != null && BKe.method_96();
		if ((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BKi : BKJ)
		{
			Label label = new Label();
			label.Text = Class333.smethod_180() + BKE.method_60(Enum96.aYt) + Class333.BAO();
			label.ForeColor = Form23.color_12;
			label.BackColor = Color.Transparent;
			label.AutoSize = true;
			label.Left = 10;
			label.Top = 10;
			Controls.Add(label);
			return;
		}
		if (BKE != null)
		{
			BKE.method_264(method_23);
			BKE.TableDataSetting.method_264(method_26);
			BKE.OnUserSelectionChanged += method_19;
			BKE.OnInvertRows += method_20;
			BKE.OnSwapColumnsAndRows += method_21;
			BKE.OnUserSliceIndexChanged += method_18;
			BKE.OnViewingAngleChanged += method_37;
		}
		Paint += Class103_Paint;
		Class1.smethod_10(method_25);
		Class1.smethod_12(method_25);
		Form23.smethod_30(method_25);
		Form23.smethod_78(method_25);
		if (BuZ != null)
		{
			BuZ.Dispose();
		}
		BuZ = new SolidBrush(Form23.color_12);
		switch (Form23.enum62_0)
		{
		case Form23.Enum62.Bqg:
			Buz = Pens.Gray;
			break;
		case Form23.Enum62.BqH:
			Buz = Pens.Gray;
			break;
		case Form23.Enum62.BqG:
		case Form23.Enum62.Bqh:
			Buz = Pens.Black;
			break;
		}
		BVc.Alignment = StringAlignment.Near;
		BVD.Alignment = StringAlignment.Far;
		method_13();
		if (BKE != null)
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG && BKe != null)
			{
				BuY = BKe.GetSelectionRangeString(BKH, BKh);
				Buy = BKe.GetCellValueString();
			}
			else
			{
				BuY = BKE.GetSelectionRangeString(BKf, BKG);
				Buy = BKE.GetCellValueString();
			}
		}
		method_26(null, null);
		Invalidate();
		ContextMenuStrip = method_43();
	}

	protected override void vmethod_1()
	{
		try
		{
			Paint -= Class103_Paint;
			if (BKE != null)
			{
				BKE.method_265(method_23);
				BKE.TableDataSetting.method_265(method_26);
				BKE.OnUserSelectionChanged -= method_19;
				BKE.OnInvertRows -= method_20;
				BKE.OnSwapColumnsAndRows -= method_21;
				BKE.OnUserSliceIndexChanged -= method_18;
				BKE.OnViewingAngleChanged -= method_37;
				if (BKE.HorizAxis != null && BKE.HorizAxis.method_87() != null)
				{
					BKE.HorizAxis.method_87().method_265(method_26);
				}
				if (BKE.VertAxis != null && BKE.VertAxis.method_87() != null)
				{
					BKE.VertAxis.method_87().method_265(method_26);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_87() != null)
				{
					BKE.SliceAxis.method_87().method_265(method_26);
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.method_88() != null)
				{
					BKE.HorizAxis.method_88().method_265(method_26);
				}
				if (BKE.VertAxis != null && BKE.VertAxis.method_88() != null)
				{
					BKE.VertAxis.method_88().method_265(method_26);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_88() != null)
				{
					BKE.SliceAxis.method_88().method_265(method_26);
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.method_89() != null)
				{
					BKE.HorizAxis.method_89().method_265(method_26);
				}
				if (BKE.VertAxis != null && BKE.VertAxis.method_89() != null)
				{
					BKE.VertAxis.method_89().method_265(method_26);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_89() != null)
				{
					BKE.SliceAxis.method_89().method_265(method_26);
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.method_90() != null)
				{
					BKE.HorizAxis.method_90().method_265(method_22);
				}
				if (BKE.VertAxis != null && BKE.VertAxis.method_90() != null)
				{
					BKE.VertAxis.method_90().method_265(method_22);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_90() != null)
				{
					BKE.SliceAxis.method_90().method_265(method_22);
				}
				if (BKE.HorizAxis != null && BKE.HorizAxis.method_91() != null)
				{
					BKE.HorizAxis.method_91().method_265(method_26);
				}
				if (BKE.VertAxis != null && BKE.VertAxis.method_91() != null)
				{
					BKE.VertAxis.method_91().method_265(method_26);
				}
				if (BKE.SliceAxis != null && BKE.SliceAxis.method_91() != null)
				{
					BKE.SliceAxis.method_91().method_265(method_26);
				}
			}
			if (BKf != null)
			{
				BKf.method_265(method_23);
			}
			if (BKG != null)
			{
				BKG.method_265(method_23);
			}
			if (BKg != null)
			{
				BKg.method_265(method_24);
			}
			Class1.smethod_11(method_25);
			Class1.smethod_13(method_25);
			Form23.smethod_31(method_25);
			Form23.smethod_79(method_25);
			if (ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
			{
				item.Click -= vmethod_3;
				item.Click -= method_41;
				item.Click -= BVr_Click;
				item.Click -= method_40;
				item.Click -= method_38;
			}
			ContextMenuStrip.Opened -= method_42;
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			BVC.Dispose();
			if (BuZ != null)
			{
				BuZ.Dispose();
			}
			BVA.Dispose();
			BVa.Dispose();
			BVB.Dispose();
			BVb.Dispose();
		}
		catch
		{
		}
		vmethod_1();
		try
		{
			GotFocus -= Class103_GotFocus;
			LostFocus -= Class103_LostFocus;
			Form23.form23_0.method_10(vmethod_0);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = base.ToString();
		if (BKE != null)
		{
			text = text + Class333.aMY() + BKE.ToString();
		}
		return text + Class333.BAZ() + Left + Class333.BAz() + Top;
	}

	[SpecialName]
	internal Table method_12()
	{
		return BKE;
	}

	private void method_13()
	{
		bool flag = ((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BKi : BKJ);
		if (flag || BKE == null)
		{
			return;
		}
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.method_87() != null)
		{
			BKE.HorizAxis.method_87().method_265(method_26);
			BKE.HorizAxis.method_87().method_264(method_26);
		}
		if (BKE.VertAxis != null && BKE.VertAxis.method_87() != null)
		{
			BKE.VertAxis.method_87().method_265(method_26);
			BKE.VertAxis.method_87().method_264(method_26);
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_87() != null)
		{
			BKE.SliceAxis.method_87().method_265(method_26);
			BKE.SliceAxis.method_87().method_264(method_26);
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.method_88() != null)
		{
			BKE.HorizAxis.method_88().method_265(method_26);
			BKE.HorizAxis.method_88().method_264(method_26);
		}
		if (BKE.VertAxis != null && BKE.VertAxis.method_88() != null)
		{
			BKE.VertAxis.method_88().method_265(method_26);
			BKE.VertAxis.method_88().method_264(method_26);
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_88() != null)
		{
			BKE.SliceAxis.method_88().method_265(method_26);
			BKE.SliceAxis.method_88().method_264(method_26);
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.method_89() != null)
		{
			BKE.HorizAxis.method_89().method_265(method_26);
			BKE.HorizAxis.method_89().method_264(method_26);
		}
		if (BKE.VertAxis != null && BKE.VertAxis.method_89() != null)
		{
			BKE.VertAxis.method_89().method_265(method_26);
			BKE.VertAxis.method_89().method_264(method_26);
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_89() != null)
		{
			BKE.SliceAxis.method_89().method_265(method_26);
			BKE.SliceAxis.method_89().method_264(method_26);
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.method_91() != null)
		{
			BKE.HorizAxis.method_91().method_265(method_26);
			BKE.HorizAxis.method_91().method_264(method_26);
		}
		if (BKE.VertAxis != null && BKE.VertAxis.method_91() != null)
		{
			BKE.VertAxis.method_91().method_265(method_26);
			BKE.VertAxis.method_91().method_264(method_26);
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_91() != null)
		{
			BKE.SliceAxis.method_91().method_265(method_26);
			BKE.SliceAxis.method_91().method_264(method_26);
		}
		if (BKE.HorizAxis != null && BKE.HorizAxis.method_90() != null)
		{
			BKE.HorizAxis.method_90().method_265(method_22);
			BKE.HorizAxis.method_90().method_264(method_22);
			BKf = BKE.HorizAxis.method_92();
			if (BKf != null)
			{
				BKf.method_265(method_23);
				BKf.method_264(method_23);
			}
			if (BKe != null && BKe.HorizAxis != null && BKe.HorizAxis.method_90() != null)
			{
				BKH = BKe.HorizAxis.method_92();
			}
		}
		if (BKE.VertAxis != null && BKE.VertAxis.method_90() != null)
		{
			BKE.VertAxis.method_90().method_265(method_22);
			BKE.VertAxis.method_90().method_264(method_22);
			BKG = BKE.VertAxis.method_92();
			if (BKG != null)
			{
				BKG.method_265(method_23);
				BKG.method_264(method_23);
			}
			if (BKe != null && BKe.VertAxis != null && BKe.VertAxis.method_90() != null)
			{
				BKh = BKe.VertAxis.method_92();
			}
		}
		if (BKE.SliceAxis != null && BKE.SliceAxis.method_90() != null)
		{
			BKE.SliceAxis.method_90().method_265(method_22);
			BKE.SliceAxis.method_90().method_264(method_22);
			BKg = BKE.SliceAxis.method_92();
			if (BKg != null)
			{
				BKg.method_265(method_24);
				BKg.method_264(method_24);
			}
			if (BKe != null && BKe.SliceAxis != null && BKe.SliceAxis.method_90() != null)
			{
				BKI = BKe.SliceAxis.method_92();
			}
		}
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		if (BKE != null && !((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BKi : BKJ))
		{
			method_26(null, null);
		}
	}

	[SpecialName]
	internal void method_14(bool bool_0)
	{
		if (Bux != bool_0)
		{
			Bux = bool_0;
			UpdateLayout(resizingOnly: false);
		}
	}

	private Color method_15(int int_3, Setting setting_0)
	{
		if (TableAxis.smethod_4(int_3, setting_0))
		{
			return Color.Red;
		}
		return Form23.color_12;
	}

	private void method_16(Graphics graphics_0)
	{
		bool flag2;
		bool flag = (flag2 = BKE.SlicesEnabled());
		if (BKe != null)
		{
			flag = BKe.SlicesEnabled();
		}
		if (flag2 | flag)
		{
			if (BVr != null)
			{
				BVr.Enabled = true;
			}
			if (Bux)
			{
				Table table;
				Setting setting;
				if (Form23.enum60_0 == Form23.Enum60.BpG)
				{
					table = BKe;
					setting = BKI;
				}
				else
				{
					table = BKE;
					setting = BKg;
				}
				if (table == null)
				{
					return;
				}
				if (!BKj.Visible)
				{
					BKj.Visible = true;
				}
				int num = table.SliceCount();
				int num2 = Height - (BKj.Height + 2);
				if (BKj.Top != num2)
				{
					BKj.Top = num2;
				}
				if (BKj.Left != 8)
				{
					BKj.Left = 8;
				}
				int num3 = Width - 10 - BKj.Left;
				if (BKj.Width != num3)
				{
					BKj.Width = num3;
				}
				if (BKj.BWB != num - 1)
				{
					BKj.BWB = num - 1;
				}
				if (table.UserSliceIndex > BKj.BWB)
				{
					table.UserSliceIndex = BKj.BWB;
				}
				if (BKj.BWb != table.UserSliceIndex)
				{
					BKj.BWb = table.UserSliceIndex;
				}
				if (!Controls.Contains(BKj))
				{
					Controls.Add(BKj);
				}
				int num4 = 0;
				if (setting != null)
				{
					num4 = setting.method_231();
				}
				BKj.Bvx.Clear();
				for (int i = 0; i < num; i++)
				{
					BKj.Bvx.Add(new Control1.Class66());
					int int_ = table.SliceAxis.method_89().method_258(i);
					string text = ((setting == null) ? string.Empty : setting.method_253(int_).DisplayValueString);
					BKj.Bvx[i].bat = text;
					if (BKe == null)
					{
						BKj.Bvx[i].baU = method_15(int_, BKg);
					}
					else if (!BKi && !BKJ)
					{
						if (table == BKE && BKe.SliceAxis.method_96(int_, text, num4) == -1)
						{
							BKj.Bvx[i].baU = Form23.color_9;
						}
						else if (table == BKe && BKE.SliceAxis.method_96(int_, text, num4) == -1)
						{
							BKj.Bvx[i].baU = Form23.color_9;
						}
						else
						{
							BKj.Bvx[i].baU = method_15(int_, BKg);
						}
					}
					else
					{
						BKj.Bvx[i].baU = Form23.color_12;
					}
				}
				if (Form23.enum60_0 == Form23.Enum60.BpG)
				{
					BKj.BWC.Visible = false;
				}
				else if (flag2 && BKE.SliceAxis.method_90() != null)
				{
					if (BKg != null)
					{
						BKj.BWC.Visible = !BKg.method_35() || !PortFunction.smethod_52(BKg);
					}
					else
					{
						BKj.BWC.Visible = false;
					}
				}
				else
				{
					BKj.BWC.Visible = false;
				}
				BKj.Invalidate();
			}
			else if (BKj.Visible)
			{
				BKj.Visible = false;
			}
		}
		else
		{
			if (BVr != null)
			{
				BVr.Enabled = false;
			}
			if (BKj.Visible)
			{
				BKj.Visible = false;
			}
			if (BKE.UserSliceIndex != 0)
			{
				BKE.UserSliceIndex = 0;
			}
		}
	}

	private void method_17()
	{
		if (BKE != null && !((Form23.enum60_0 != Form23.Enum60.BpG || BKd == null) ? BKi : BKJ))
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG && BKe != null)
			{
				BuY = BKe.GetSelectionRangeString(BKH, BKh);
				Buy = BKe.GetCellValueString();
			}
			else
			{
				BuY = BKE.GetSelectionRangeString(BKf, BKG);
				Buy = BKE.GetCellValueString();
			}
		}
	}

	private void method_18(object sender, EventArgs e)
	{
		method_17();
		method_26(null, null);
		if (BKE != null && BKE.UserSliceIndex >= 0 && BKE.UserSliceIndex <= BKj.BWB)
		{
			BKj.BWb = BKE.UserSliceIndex;
			BKj.Invalidate();
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		method_17();
		if (BVO)
		{
			UpdateLayout(resizingOnly: false);
		}
		Invalidate();
	}

	private void method_20(object sender, EventArgs e)
	{
		method_13();
		method_17();
		method_26(null, null);
	}

	private void method_21(object sender, EventArgs e)
	{
		method_13();
		method_17();
		method_26(null, null);
	}

	private void method_22(object sender, EventArgs e)
	{
		method_13();
		method_17();
		method_26(null, null);
	}

	private void method_23(object sender, EventArgs e)
	{
		if (method_0())
		{
			Invalidate();
		}
	}

	private void method_24(object sender, EventArgs e)
	{
		if (method_0() && BKj != null && BKj.Visible)
		{
			BKj.Invalidate();
		}
	}

	private void method_25(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void method_26(object sender, EventArgs e)
	{
		if (BKE == null || (BKe != null && (BKi || BKJ) && Form23.enum60_0 == Form23.Enum60.BpF))
		{
			return;
		}
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		Buy = table.GetCellValueString();
		try
		{
			using Graphics graphics_ = CreateGraphics();
			method_16(graphics_);
		}
		catch
		{
		}
		try
		{
			bool flag = table.HorizAxisEnabled();
			bool flag2 = table.VertAxisEnabled();
			if (!flag && !flag2)
			{
				return;
			}
			bool flag3 = false;
			int num = table.HorizAxisCount();
			if (num == 1)
			{
				num = 2;
				flag3 = true;
			}
			bool flag4 = false;
			int num2 = table.VertAxisCount();
			if (num2 == 1)
			{
				num2 = 2;
				flag4 = true;
			}
			int num3 = table.SliceCount();
			if (num > 64)
			{
				throw new Exception(Class333.BFy());
			}
			if (num2 > 64)
			{
				throw new Exception(Class333.BFy());
			}
			if (num3 > 16)
			{
				throw new Exception(Class333.BFZ());
			}
			if (flag && table.HorizAxis.method_89() != null)
			{
				if (flag3)
				{
					BVG[0] = table.HorizAxis.method_89().method_258(0);
					BVG[1] = table.HorizAxis.method_89().method_258(0) + 1;
				}
				else
				{
					for (int i = 0; i < num; i++)
					{
						BVG[i] = table.HorizAxis.method_89().method_258(i);
					}
				}
				BVH = table.HorizAxis.method_93();
			}
			else
			{
				BVG[0] = 0;
				BVG[1] = 1;
			}
			if (flag2 && table.VertAxis.method_89() != null)
			{
				if (flag4)
				{
					BVg[0] = table.VertAxis.method_89().method_258(0);
					BVg[1] = table.VertAxis.method_89().method_258(0) + 1;
				}
				else
				{
					for (int j = 0; j < num2; j++)
					{
						if (table.InvertRows)
						{
							BVg[j] = table.VertAxis.method_89().method_258(num2 - 1 - j);
						}
						else
						{
							BVg[j] = table.VertAxis.method_89().method_258(j);
						}
					}
				}
				BVh = table.VertAxis.method_93();
			}
			else
			{
				BVg[0] = 0;
				BVg[1] = 1;
			}
			if (flag & flag2)
			{
				if (flag3 & flag4)
				{
					return;
				}
				if (!flag3 && !flag4)
				{
					for (int k = 0; k < num3; k++)
					{
						for (int j = 0; j < num2; j++)
						{
							for (int i = 0; i < num; i++)
							{
								if (table.SwapColumnsAndRows)
								{
									if (table.InvertRows)
									{
										BVI[k, j, i] = table.TableDataSetting.method_257(num2 - 1 - j, i, k);
									}
									else
									{
										BVI[k, j, i] = table.TableDataSetting.method_257(j, i, k);
									}
								}
								else if (table.InvertRows)
								{
									BVI[k, j, i] = table.TableDataSetting.method_257(i, num2 - 1 - j, k);
								}
								else
								{
									BVI[k, j, i] = table.TableDataSetting.method_257(i, j, k);
								}
							}
						}
					}
				}
				else if (flag3)
				{
					for (int l = 0; l < num3; l++)
					{
						for (int j = 0; j < num2; j++)
						{
							if (table.SwapColumnsAndRows)
							{
								if (table.InvertRows)
								{
									BVI[l, j, 0] = table.TableDataSetting.method_257(num2 - 1 - j, 0, l);
									BVI[l, j, 1] = table.TableDataSetting.method_257(num2 - 1 - j, 0, l);
								}
								else
								{
									BVI[l, j, 0] = table.TableDataSetting.method_257(j, 0, l);
									BVI[l, j, 1] = table.TableDataSetting.method_257(j, 0, l);
								}
							}
							else if (table.InvertRows)
							{
								BVI[l, j, 0] = table.TableDataSetting.method_257(0, num2 - 1 - j, l);
								BVI[l, j, 1] = table.TableDataSetting.method_257(0, num2 - 1 - j, l);
							}
							else
							{
								BVI[l, j, 0] = table.TableDataSetting.method_257(0, j, l);
								BVI[l, j, 1] = table.TableDataSetting.method_257(0, j, l);
							}
						}
					}
				}
				else if (flag4)
				{
					for (int m = 0; m < num3; m++)
					{
						for (int i = 0; i < num; i++)
						{
							if (table.SwapColumnsAndRows)
							{
								BVI[m, 0, i] = table.TableDataSetting.method_257(0, i, m);
								BVI[m, 1, i] = table.TableDataSetting.method_257(0, i, m);
							}
							else
							{
								BVI[m, 0, i] = table.TableDataSetting.method_257(i, 0, m);
								BVI[m, 1, i] = table.TableDataSetting.method_257(i, 0, m);
							}
						}
					}
				}
			}
			else if (flag)
			{
				if (flag3)
				{
					return;
				}
				for (int n = 0; n < num3; n++)
				{
					for (int i = 0; i < num; i++)
					{
						if (table.SwapColumnsAndRows)
						{
							BVI[n, 0, i] = table.TableDataSetting.method_257(0, i, n);
							BVI[n, 1, i] = table.TableDataSetting.method_257(0, i, n);
						}
						else
						{
							BVI[n, 0, i] = table.TableDataSetting.method_257(i, 0, n);
							BVI[n, 1, i] = table.TableDataSetting.method_257(i, 0, n);
						}
					}
				}
			}
			else if (flag2)
			{
				if (flag4)
				{
					return;
				}
				for (int num4 = 0; num4 < num3; num4++)
				{
					for (int j = 0; j < num2; j++)
					{
						if (table.SwapColumnsAndRows)
						{
							if (table.InvertRows)
							{
								BVI[num4, j, 0] = table.TableDataSetting.method_257(num2 - 1 - j, 0, num4);
								BVI[num4, j, 1] = table.TableDataSetting.method_257(num2 - 1 - j, 0, num4);
							}
							else
							{
								BVI[num4, j, 0] = table.TableDataSetting.method_257(j, 0, num4);
								BVI[num4, j, 1] = table.TableDataSetting.method_257(j, 0, num4);
							}
						}
						else if (table.InvertRows)
						{
							BVI[num4, j, 0] = table.TableDataSetting.method_257(0, num2 - 1 - j, num4);
							BVI[num4, j, 1] = table.TableDataSetting.method_257(0, num2 - 1 - j, num4);
						}
						else
						{
							BVI[num4, j, 0] = table.TableDataSetting.method_257(0, j, num4);
							BVI[num4, j, 1] = table.TableDataSetting.method_257(0, j, num4);
						}
					}
				}
			}
			BVi = int.MaxValue;
			BVJ = int.MinValue;
			for (int num5 = 0; num5 < num3; num5++)
			{
				for (int j = 0; j < num2; j++)
				{
					for (int i = 0; i < num; i++)
					{
						if (BVi > BVI[num5, j, i])
						{
							BVi = BVI[num5, j, i];
						}
						if (BVJ < BVI[num5, j, i])
						{
							BVJ = BVI[num5, j, i];
						}
					}
				}
			}
			int userSliceIndex = table.UserSliceIndex;
			for (int j = 0; j < num2; j++)
			{
				for (int i = 0; i < num; i++)
				{
					if (BVO)
					{
						bool bool_ = false;
						if (table.HorizVertIndexPerUserSelectedCell.Count == 1)
						{
							bool_ = i == table.HorizVertIndexPerUserSelectedCell[0].X && j == table.HorizVertIndexPerUserSelectedCell[0].Y;
						}
						method_36(table, BVG[i], BVg[j], BVI[userSliceIndex, j, i], BVG[0], BVG[num - 1], BVg[0], BVg[num2 - 1], BVi, BVJ, out BVj[j, i], out BVK[j, i], out BVk[j, i], bool_);
					}
					else
					{
						method_35(table, BVG[i], BVg[j], BVI[userSliceIndex, j, i], BVG[0], BVG[num - 1], BVg[0], BVg[num2 - 1], BVi, BVJ, out BVj[j, i], out BVK[j, i], out BVk[j, i]);
					}
				}
			}
			int int_ = (Form23.bool_49 ? BVi : 0);
			for (int j = 0; j < num2; j++)
			{
				for (int i = 0; i < num; i++)
				{
					method_35(table, BVG[i], BVg[j], int_, BVG[0], BVG[num - 1], BVg[0], BVg[num2 - 1], BVi, BVJ, out BVL[j, i], out BVl[j, i], out BVM[j, i]);
				}
			}
			for (int j = 0; j < num2 - 1; j++)
			{
				for (int i = 0; i < num - 1; i++)
				{
					float num6 = BVj[j, i] - BVj[j, i + 1];
					float num7 = BVj[j + 1, i + 1] - BVj[j, i + 1];
					float num8 = BVK[j, i] - BVK[j, i + 1];
					float num9 = BVK[j + 1, i + 1] - BVK[j, i + 1];
					float num10 = BVk[j, i] - BVk[j, i + 1];
					float num11 = BVk[j + 1, i + 1] - BVk[j, i + 1];
					float num12 = num8 * num11 - num9 * num10;
					float num13 = num10 * num7 - num11 * num6;
					float num14 = num6 * num9 - num6 * num9;
					float num15 = (float)Math.Sqrt(num12 * num12 + num13 * num13 + num14 * num14);
					num15 *= (float)Math.Sqrt(5.0);
					if (num15 == 0f)
					{
						num15 = 0.001f;
					}
					num12 *= 0f;
					num13 *= -2f;
					num14 *= 1f;
					BVm[j, i] = num12 + num13 + num14;
					BVm[j, i] = (0f - BVm[j, i]) / num15;
					BVm[j, i] = BVm[j, i] / 3f + 0.6666f;
					if (BVm[j, i] < 0f)
					{
						BVm[j, i] = 0f;
					}
					if (BVm[j, i] > 1f)
					{
						BVm[j, i] = 1f;
					}
				}
			}
			int num16 = 0;
			for (int j = 0; j < num2 - 1; j++)
			{
				for (int i = 0; i < num - 1; i++)
				{
					BVN[num16].baf = Enum31.bae;
					BVN[num16].baG = i;
					BVN[num16].bag = j;
					BVN[num16].baH = (BVK[j, i] + BVK[j, i + 1] + BVK[j + 1, i] + BVK[j + 1, i + 1]) / 4f;
					num16++;
				}
			}
			for (int j = 0; j < num2 - 1; j++)
			{
				for (int i = 0; i < num - 1; i++)
				{
					BVN[num16].baf = Enum31.baF;
					BVN[num16].baG = i;
					BVN[num16].bag = j;
					BVN[num16].baH = (BVl[j, i] + BVl[j, i + 1] + BVl[j + 1, i] + BVl[j + 1, i + 1]) / 4f;
					num16++;
				}
			}
			int num17 = (num - 1) * (num2 - 1) * 2;
			bool flag5;
			do
			{
				flag5 = false;
				for (int num18 = 1; num18 < num17; num18++)
				{
					if (BVN[num18 - 1].baH > BVN[num18].baH)
					{
						Struct9 @struct = BVN[num18 - 1];
						BVN[num18 - 1] = BVN[num18];
						BVN[num18] = @struct;
						flag5 = true;
					}
				}
				num17--;
			}
			while (flag5);
		}
		catch
		{
		}
		if (method_0())
		{
			Invalidate();
		}
	}

	private void method_27(Graphics graphics_0)
	{
		Color color = ((!BKE.method_35()) ? Color.Gray : Form23.color_12);
		using SolidBrush brush = new SolidBrush(color);
		using Font font = new Font(Font.FontFamily, 10f);
		int num = BKE.method_231();
		string text = BKE.method_18();
		string s = (string.IsNullOrWhiteSpace(text) ? BKE.method_60(Enum96.aYt) : text);
		if (Focused)
		{
			using Font font2 = new Font(Font.FontFamily, 10f, FontStyle.Bold);
			graphics_0.DrawString(s, font2, brush, 8f, 8f);
		}
		else
		{
			graphics_0.DrawString(s, font, brush, 8f, 8f);
		}
		graphics_0.DrawString(BuY, font, brush, 8f, 27f);
		graphics_0.DrawString(Buy, font, brush, 8f, 46f);
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			string text2 = Class333.smethod_325() + Class233.smethod_35(BKE.method_232(), num, bool_0: false, 0);
			if ((!Form23.smethod_28(BKD.aXc, bool_53: true) || Form23.smethod_80()) && !Form23.smethod_84(BKE.method_64()))
			{
				graphics_0.DrawString(Class333.BFs() + text2, font, brush, 8f, 65f);
				return;
			}
			(string, string, bool) tuple = BKE.method_252();
			graphics_0.DrawString(Class333.BFT() + tuple.Item1 + (tuple.Item3 ? string.Empty : text2), font, brush, 8f, 65f);
		}
	}

	private void method_28(Graphics graphics_0)
	{
		Pen pen = ((!BVR) ? new Pen(Form23.color_12, 2f) : new Pen(Form23.color_12, 3f));
		graphics_0.DrawArc(pen, Width - 13 - 24, 13, 20, 20, 0, 336);
		graphics_0.DrawLine(pen, Width - 13 - 5, 13, Width - 13 - 5, 18);
		graphics_0.DrawLine(pen, Width - 13 - 10, 18, Width - 13 - 5, 18);
		pen.Dispose();
		if (!BVR)
		{
			return;
		}
		using SolidBrush brush = new SolidBrush(Form23.color_12);
		using Font font = new Font(Font.FontFamily, 7f);
		graphics_0.DrawString(layoutRectangle: new Rectangle(Width - 50, 40, 40, 60), s: Class333.BFz(), font: font, brush: brush);
	}

	private void method_29(Graphics graphics_0, Table table_0, bool bool_0, bool bool_1, int int_3, int int_4)
	{
		int int_5 = (Form23.bool_49 ? BVi : 0);
		if (bool_1)
		{
			float float_ = 0f;
			float float_2 = 0f;
			float float_3 = 0f;
			float float_4 = 0f;
			float float_5 = 0f;
			float float_6 = 0f;
			float float_7 = 0f;
			float float_8 = 0f;
			float float_9 = 0f;
			float float_10 = 0f;
			float float_11 = 0f;
			float float_12 = 0f;
			for (int i = 0; i < int_4; i++)
			{
				method_35(table_0, BVG[0], BVg[i], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
				method_35(table_0, BVG[int_3 - 1], BVg[i], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_4, out float_5, out float_6);
				if (float_2 < float_5)
				{
					method_35(table_0, BVG[0], BVg[i], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_7, out float_8, out float_9);
					method_35(table_0, BVG[0], BVg[i], BVJ, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_10, out float_11, out float_12);
					graphics_0.DrawLine(Buz, float_7, float_9, float_10, float_12);
				}
				else
				{
					method_35(table_0, BVG[int_3 - 1], BVg[i], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_7, out float_8, out float_9);
					method_35(table_0, BVG[int_3 - 1], BVg[i], BVJ, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_10, out float_11, out float_12);
					graphics_0.DrawLine(Buz, float_7, float_9, float_10, float_12);
				}
			}
			if (float_2 < float_5)
			{
				method_35(table_0, BVG[0], BVg[0], BVJ, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_7, out float_8, out float_9);
				method_35(table_0, BVG[0], BVg[int_4 - 1], BVJ, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_10, out float_11, out float_12);
			}
			else
			{
				method_35(table_0, BVG[int_3 - 1], BVg[0], BVJ, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_7, out float_8, out float_9);
				method_35(table_0, BVG[int_3 - 1], BVg[int_4 - 1], BVJ, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_10, out float_11, out float_12);
			}
			graphics_0.DrawLine(Buz, float_7, float_9, float_10, float_12);
		}
		if (!bool_0)
		{
			return;
		}
		float float_13 = 0f;
		float float_14 = 0f;
		float float_15 = 0f;
		float float_16 = 0f;
		float float_17 = 0f;
		float float_18 = 0f;
		float float_19 = 0f;
		float float_20 = 0f;
		float float_21 = 0f;
		float float_22 = 0f;
		float float_23 = 0f;
		float float_24 = 0f;
		for (int j = 0; j < int_3; j++)
		{
			method_35(table_0, BVG[j], BVg[0], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_13, out float_14, out float_15);
			method_35(table_0, BVG[j], BVg[int_4 - 1], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_16, out float_17, out float_18);
			if (float_14 < float_17)
			{
				method_35(table_0, BVG[j], BVg[0], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_19, out float_20, out float_21);
				method_35(table_0, BVG[j], BVg[0], BVJ, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_22, out float_23, out float_24);
			}
			else
			{
				method_35(table_0, BVG[j], BVg[int_4 - 1], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_19, out float_20, out float_21);
				method_35(table_0, BVG[j], BVg[int_4 - 1], BVJ, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_22, out float_23, out float_24);
			}
			graphics_0.DrawLine(Buz, float_19, float_21, float_22, float_24);
		}
		if (float_14 < float_17)
		{
			method_35(table_0, BVG[0], BVg[0], BVJ, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_19, out float_20, out float_21);
			method_35(table_0, BVG[int_3 - 1], BVg[0], BVJ, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_22, out float_23, out float_24);
		}
		else
		{
			method_35(table_0, BVG[0], BVg[int_4 - 1], BVJ, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_19, out float_20, out float_21);
			method_35(table_0, BVG[int_3 - 1], BVg[int_4 - 1], BVJ, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_22, out float_23, out float_24);
		}
		graphics_0.DrawLine(Buz, float_19, float_21, float_22, float_24);
	}

	private void method_30(Graphics graphics_0, Table table_0, bool bool_0, bool bool_1, int int_3, int int_4)
	{
		for (int i = 0; i < (int_3 - 1) * (int_4 - 1) * 2; i++)
		{
			try
			{
				int baG = BVN[i].baG;
				int bag = BVN[i].bag;
				if (BVN[i].baf == Enum31.bae)
				{
					BVE[0].X = BVj[bag, baG];
					BVE[0].Y = BVk[bag, baG];
					BVE[1].X = BVj[bag, baG + 1];
					BVE[1].Y = BVk[bag, baG + 1];
					BVE[2].X = BVj[bag + 1, baG + 1];
					BVE[2].Y = BVk[bag + 1, baG + 1];
					BVE[3].X = BVj[bag + 1, baG];
					BVE[3].Y = BVk[bag + 1, baG];
					float num = Math.Min(Math.Min(Math.Min(BVE[0].X, BVE[1].X), BVE[2].X), BVE[3].X);
					float num2 = Math.Max(Math.Max(Math.Max(BVE[0].X, BVE[1].X), BVE[2].X), BVE[3].X);
					float num3 = Math.Min(Math.Min(Math.Min(BVE[0].Y, BVE[1].Y), BVE[2].Y), BVE[3].Y);
					float num4 = Math.Max(Math.Max(Math.Max(BVE[0].Y, BVE[1].Y), BVE[2].Y), BVE[3].Y);
					for (int j = 0; j < 4; j++)
					{
						if (BVE[j].X == num)
						{
							BVE[j].X--;
						}
						else if (BVE[j].X == num2)
						{
							BVE[j].X++;
						}
						if (BVE[j].Y == num3)
						{
							BVE[j].Y--;
						}
						else if (BVE[j].Y == num4)
						{
							BVE[j].Y++;
						}
					}
					int userSliceIndex = BKE.UserSliceIndex;
					int num5 = (BVI[userSliceIndex, bag, baG] + BVI[userSliceIndex, bag, baG + 1] + BVI[userSliceIndex, bag + 1, baG + 1] + BVI[userSliceIndex, bag + 1, baG]) / 4;
					BVF.Reset();
					BVF.AddPolygon(BVE);
					if (BVF.GetBounds().Height != 0f && BVF.GetBounds().Width != 0f)
					{
						BVf = new PathGradientBrush(BVF);
						float num6 = (Form23.bool_48 ? BVm[bag, baG] : 1f);
						int num7 = (int)((float)(Form23.int_45 * 255 / 100) * num6);
						int num8 = Form23.int_44 * 255 / 100;
						int num9 = Form23.int_46 * 255 / 100;
						int num10 = Form23.int_47 * 255 / 100;
						if (BVi == BVJ)
						{
							Color color = Class18.smethod_0(num10, num8, num7);
							BVe[0] = (BVe[1] = (BVe[2] = (BVe[3] = color)));
							foreach (Point item in BKE.HorizVertIndexPerUserSelectedCell)
							{
								if (item.X == baG && item.Y == bag)
								{
									BVe[0] = Color.DodgerBlue;
								}
								if (item.X == baG + 1 && item.Y == bag)
								{
									BVe[1] = Color.DodgerBlue;
								}
								if (item.X == baG + 1 && item.Y == bag + 1)
								{
									BVe[2] = Color.DodgerBlue;
								}
								if (item.X == baG && item.Y == bag + 1)
								{
									BVe[3] = Color.DodgerBlue;
								}
							}
							if (BVe[0] == Color.DodgerBlue && BVe[1] == Color.DodgerBlue && BVe[2] == Color.DodgerBlue && BVe[3] == Color.DodgerBlue)
							{
								BVf.CenterColor = Color.DodgerBlue;
							}
							else if ((BVe[0] == Color.DodgerBlue && BVe[1] == Color.DodgerBlue) || (BVe[2] == Color.DodgerBlue && BVe[3] == Color.DodgerBlue) || (BVe[0] == Color.DodgerBlue && BVe[3] == Color.DodgerBlue) || (BVe[1] == Color.DodgerBlue && BVe[2] == Color.DodgerBlue))
							{
								byte red = (byte)((color.R + Color.DodgerBlue.R) / 2);
								byte green = (byte)((color.G + Color.DodgerBlue.G) / 2);
								byte blue = (byte)((color.B + Color.DodgerBlue.B) / 2);
								BVf.CenterColor = Color.FromArgb(red, green, blue);
							}
							else
							{
								BVf.CenterColor = color;
							}
							BVf.SurroundColors = BVe;
						}
						else
						{
							BVd[0] = BVI[userSliceIndex, bag, baG];
							BVd[1] = BVI[userSliceIndex, bag, baG + 1];
							BVd[2] = BVI[userSliceIndex, bag + 1, baG + 1];
							BVd[3] = BVI[userSliceIndex, bag + 1, baG];
							int num11;
							if (Form23.bool_50)
							{
								num11 = ((num9 >= num10) ? (num9 + (255 - (num9 - num10)) * (num5 - BVi) / (BVJ - BVi)) : (num9 - (255 - (num10 - num9)) * (num5 - BVi) / (BVJ - BVi)));
							}
							else
							{
								num11 = num9 + (num10 - num9) * (num5 - BVi) / (BVJ - BVi);
							}
							if (num11 < 0)
							{
								num11 += 255;
							}
							else if (num11 > 255)
							{
								num11 -= 255;
							}
							Color centerColor = Class18.smethod_0(num11, num8, num7);
							BVf.CenterColor = centerColor;
							for (int k = 0; k < 4; k++)
							{
								int num12;
								if (Form23.bool_50)
								{
									num12 = ((num9 >= num10) ? (num9 + (255 - (num9 - num10)) * (BVd[k] - BVi) / (BVJ - BVi)) : (num9 - (255 - (num10 - num9)) * (BVd[k] - BVi) / (BVJ - BVi)));
								}
								else
								{
									num12 = num9 + (num10 - num9) * (BVd[k] - BVi) / (BVJ - BVi);
								}
								if (num12 < 0)
								{
									num12 += 255;
								}
								else if (num12 > 255)
								{
									num12 -= 255;
								}
								Color color2 = Class18.smethod_0(num12, num8, num7);
								BVe[k] = color2;
							}
							foreach (Point item2 in BKE.HorizVertIndexPerUserSelectedCell)
							{
								if (item2.X == baG && item2.Y == bag)
								{
									BVe[0] = Color.DodgerBlue;
								}
								if (item2.X == baG + 1 && item2.Y == bag)
								{
									BVe[1] = Color.DodgerBlue;
								}
								if (item2.X == baG + 1 && item2.Y == bag + 1)
								{
									BVe[2] = Color.DodgerBlue;
								}
								if (item2.X == baG && item2.Y == bag + 1)
								{
									BVe[3] = Color.DodgerBlue;
								}
							}
							BVf.SurroundColors = BVe;
							if (BVe[0] == Color.DodgerBlue && BVe[1] == Color.DodgerBlue && BVe[2] == Color.DodgerBlue && BVe[3] == Color.DodgerBlue)
							{
								BVf.CenterColor = Color.DodgerBlue;
							}
							else if (BVe[0] == Color.DodgerBlue && BVe[1] == Color.DodgerBlue)
							{
								byte b = (byte)((BVe[2].R + BVe[3].R) / 2);
								byte b2 = (byte)((BVe[2].G + BVe[3].G) / 2);
								byte b3 = (byte)((BVe[2].B + BVe[3].B) / 2);
								byte red2 = (byte)((b + Color.DodgerBlue.R) / 2);
								byte green2 = (byte)((b2 + Color.DodgerBlue.G) / 2);
								byte blue2 = (byte)((b3 + Color.DodgerBlue.B) / 2);
								BVf.CenterColor = Color.FromArgb(red2, green2, blue2);
							}
							else if (BVe[2] == Color.DodgerBlue && BVe[3] == Color.DodgerBlue)
							{
								byte b4 = (byte)((BVe[0].R + BVe[1].R) / 2);
								byte b5 = (byte)((BVe[0].G + BVe[1].G) / 2);
								byte b6 = (byte)((BVe[0].B + BVe[1].B) / 2);
								byte red3 = (byte)((b4 + Color.DodgerBlue.R) / 2);
								byte green3 = (byte)((b5 + Color.DodgerBlue.G) / 2);
								byte blue3 = (byte)((b6 + Color.DodgerBlue.B) / 2);
								BVf.CenterColor = Color.FromArgb(red3, green3, blue3);
							}
							else if (BVe[0] == Color.DodgerBlue && BVe[3] == Color.DodgerBlue)
							{
								byte b7 = (byte)((BVe[1].R + BVe[2].R) / 2);
								byte b8 = (byte)((BVe[1].G + BVe[2].G) / 2);
								byte b9 = (byte)((BVe[1].B + BVe[2].B) / 2);
								byte red4 = (byte)((b7 + Color.DodgerBlue.R) / 2);
								byte green4 = (byte)((b8 + Color.DodgerBlue.G) / 2);
								byte blue4 = (byte)((b9 + Color.DodgerBlue.B) / 2);
								BVf.CenterColor = Color.FromArgb(red4, green4, blue4);
							}
							else if (BVe[1] == Color.DodgerBlue && BVe[2] == Color.DodgerBlue)
							{
								byte b10 = (byte)((BVe[0].R + BVe[3].R) / 2);
								byte b11 = (byte)((BVe[0].G + BVe[3].G) / 2);
								byte b12 = (byte)((BVe[0].B + BVe[3].B) / 2);
								byte red5 = (byte)((b10 + Color.DodgerBlue.R) / 2);
								byte green5 = (byte)((b11 + Color.DodgerBlue.G) / 2);
								byte blue5 = (byte)((b12 + Color.DodgerBlue.B) / 2);
								BVf.CenterColor = Color.FromArgb(red5, green5, blue5);
							}
						}
						graphics_0.FillPolygon(BVf, BVE);
						BVf.Dispose();
					}
					BVE[0].X = BVj[bag, baG];
					BVE[0].Y = BVk[bag, baG];
					BVE[1].X = BVj[bag, baG + 1];
					BVE[1].Y = BVk[bag, baG + 1];
					BVE[2].X = BVj[bag + 1, baG + 1];
					BVE[2].Y = BVk[bag + 1, baG + 1];
					BVE[3].X = BVj[bag + 1, baG];
					BVE[3].Y = BVk[bag + 1, baG];
					if (Form23.enum63_1 == Form23.Enum63.BqI)
					{
						graphics_0.DrawPolygon(BVA, BVE);
					}
					else if (Form23.enum63_1 == Form23.Enum63.Bqi)
					{
						graphics_0.DrawPolygon(BVa, BVE);
					}
					else if (Form23.enum63_1 == Form23.Enum63.BqJ)
					{
						graphics_0.DrawPolygon(BVB, BVE);
					}
					if (Form23.enum60_0 != Form23.Enum60.BpG && ((Form23.smethod_28(BKD.aXc, bool_53: true) && !Form23.smethod_80()) || (BKf != null && Form23.smethod_84(BKf.method_64()) && BKG != null && Form23.smethod_84(BKG.method_64()))))
					{
						method_31(graphics_0, table_0, bool_0, int_3, int_4, baG, bag, userSliceIndex);
						method_32(graphics_0, table_0, bool_1, int_3, int_4, baG, bag, userSliceIndex);
					}
				}
				else if (BVN[i].baf == Enum31.baF)
				{
					BVE[0].X = BVL[bag, baG];
					BVE[0].Y = BVM[bag, baG];
					BVE[1].X = BVL[bag, baG + 1];
					BVE[1].Y = BVM[bag, baG + 1];
					BVE[2].X = BVL[bag + 1, baG + 1];
					BVE[2].Y = BVM[bag + 1, baG + 1];
					BVE[3].X = BVL[bag + 1, baG];
					BVE[3].Y = BVM[bag + 1, baG];
					float num13 = Math.Min(Math.Min(Math.Min(BVE[0].X, BVE[1].X), BVE[2].X), BVE[3].X);
					float num14 = Math.Max(Math.Max(Math.Max(BVE[0].X, BVE[1].X), BVE[2].X), BVE[3].X);
					float num15 = Math.Min(Math.Min(Math.Min(BVE[0].Y, BVE[1].Y), BVE[2].Y), BVE[3].Y);
					float num16 = Math.Max(Math.Max(Math.Max(BVE[0].Y, BVE[1].Y), BVE[2].Y), BVE[3].Y);
					if (num13 != num14 && num15 != num16)
					{
						graphics_0.DrawPolygon(Buz, BVE);
					}
				}
			}
			catch
			{
			}
		}
	}

	private void method_31(Graphics graphics_0, Table table_0, bool bool_0, int int_3, int int_4, int int_5, int int_6, int int_7)
	{
		if (!bool_0 || BKf == null)
		{
			return;
		}
		int num = BKf.method_256();
		if (num < BVG[int_5] || num > BVG[int_5 + 1])
		{
			return;
		}
		int int_8 = BVG[0];
		int int_9 = BVG[int_3 - 1];
		int int_10 = BVg[0];
		int int_11 = BVg[int_4 - 1];
		if (BVH == AxisBehaviour.DiscreteCentred)
		{
			int num2 = BVG[int_5] + BVG[int_5 + 1] >> 1;
			float float_;
			float float_2;
			float float_3;
			float float_4;
			float float_5;
			float float_6;
			if (num != BVG[int_5] && num >= num2)
			{
				method_35(table_0, BVG[int_5 + 1], BVg[int_6], BVI[int_7, int_6, int_5 + 1], int_8, int_9, int_10, int_11, BVi, BVJ, out float_, out float_2, out float_3);
				method_35(table_0, BVG[int_5 + 1], BVg[int_6 + 1], BVI[int_7, int_6 + 1, int_5 + 1], int_8, int_9, int_10, int_11, BVi, BVJ, out float_4, out float_5, out float_6);
			}
			else
			{
				method_35(table_0, BVG[int_5], BVg[int_6], BVI[int_7, int_6, int_5], int_8, int_9, int_10, int_11, BVi, BVJ, out float_, out float_2, out float_3);
				method_35(table_0, BVG[int_5], BVg[int_6 + 1], BVI[int_7, int_6 + 1, int_5], int_8, int_9, int_10, int_11, BVi, BVJ, out float_4, out float_5, out float_6);
			}
			graphics_0.DrawLine(BVb, float_, float_3, float_4, float_6);
		}
		else if (BVH != AxisBehaviour.DiscreteLimits && BVH == AxisBehaviour.Continuous)
		{
			float num3 = BVI[int_7, int_6, int_5] + (BVI[int_7, int_6, int_5 + 1] - BVI[int_7, int_6, int_5]) * (num - BVG[int_5]) / (BVG[int_5 + 1] - BVG[int_5]);
			float num4 = BVI[int_7, int_6 + 1, int_5] + (BVI[int_7, int_6 + 1, int_5 + 1] - BVI[int_7, int_6 + 1, int_5]) * (num - BVG[int_5]) / (BVG[int_5 + 1] - BVG[int_5]);
			method_35(table_0, num, BVg[int_6], (int)Math.Round(num3), int_8, int_9, int_10, int_11, BVi, BVJ, out var float_7, out var _, out var float_9);
			method_35(table_0, num, BVg[int_6 + 1], (int)Math.Round(num4), int_8, int_9, int_10, int_11, BVi, BVJ, out var float_10, out var _, out var float_12);
			graphics_0.DrawLine(BVb, float_7, float_9, float_10, float_12);
		}
	}

	private void method_32(Graphics graphics_0, Table table_0, bool bool_0, int int_3, int int_4, int int_5, int int_6, int int_7)
	{
		if (!bool_0 || BKG == null)
		{
			return;
		}
		int num = BKG.method_256();
		if ((BKE.InvertRows || num < BVg[int_6] || num > BVg[int_6 + 1]) && (!BKE.InvertRows || num < BVg[int_6 + 1] || num > BVg[int_6]))
		{
			return;
		}
		int int_8 = BVG[0];
		int int_9 = BVG[int_3 - 1];
		int int_10 = BVg[0];
		int int_11 = BVg[int_4 - 1];
		if (BVh == AxisBehaviour.DiscreteCentred)
		{
			int num2 = BVg[int_6] + BVg[int_6 + 1] >> 1;
			float float_;
			float float_2;
			float float_3;
			float float_4;
			float float_5;
			float float_6;
			if (!BKE.InvertRows)
			{
				if (num != BVg[int_6] && num >= num2)
				{
					method_35(table_0, BVG[int_5], BVg[int_6 + 1], BVI[int_7, int_6 + 1, int_5], int_8, int_9, int_10, int_11, BVi, BVJ, out float_, out float_2, out float_3);
					method_35(table_0, BVG[int_5 + 1], BVg[int_6 + 1], BVI[int_7, int_6 + 1, int_5 + 1], int_8, int_9, int_10, int_11, BVi, BVJ, out float_4, out float_5, out float_6);
				}
				else
				{
					method_35(table_0, BVG[int_5], BVg[int_6], BVI[int_7, int_6, int_5], int_8, int_9, int_10, int_11, BVi, BVJ, out float_, out float_2, out float_3);
					method_35(table_0, BVG[int_5 + 1], BVg[int_6], BVI[int_7, int_6, int_5 + 1], int_8, int_9, int_10, int_11, BVi, BVJ, out float_4, out float_5, out float_6);
				}
			}
			else if (num != BVg[int_6 + 1] && num >= num2)
			{
				method_35(table_0, BVG[int_5], BVg[int_6], BVI[int_7, int_6, int_5], int_8, int_9, int_10, int_11, BVi, BVJ, out float_, out float_2, out float_3);
				method_35(table_0, BVG[int_5 + 1], BVg[int_6], BVI[int_7, int_6, int_5 + 1], int_8, int_9, int_10, int_11, BVi, BVJ, out float_4, out float_5, out float_6);
			}
			else
			{
				method_35(table_0, BVG[int_5], BVg[int_6 + 1], BVI[int_7, int_6 + 1, int_5], int_8, int_9, int_10, int_11, BVi, BVJ, out float_, out float_2, out float_3);
				method_35(table_0, BVG[int_5 + 1], BVg[int_6 + 1], BVI[int_7, int_6 + 1, int_5 + 1], int_8, int_9, int_10, int_11, BVi, BVJ, out float_4, out float_5, out float_6);
			}
			graphics_0.DrawLine(BVb, float_, float_3, float_4, float_6);
		}
		else if (BVh != AxisBehaviour.DiscreteLimits && BVh == AxisBehaviour.Continuous)
		{
			float num3 = BVI[int_7, int_6, int_5] + (BVI[int_7, int_6 + 1, int_5] - BVI[int_7, int_6, int_5]) * (num - BVg[int_6]) / (BVg[int_6 + 1] - BVg[int_6]);
			float num4 = BVI[int_7, int_6, int_5 + 1] + (BVI[int_7, int_6 + 1, int_5 + 1] - BVI[int_7, int_6, int_5 + 1]) * (num - BVg[int_6]) / (BVg[int_6 + 1] - BVg[int_6]);
			method_35(table_0, BVG[int_5], num, (int)Math.Round(num3), int_8, int_9, int_10, int_11, BVi, BVJ, out var float_7, out var _, out var float_9);
			method_35(table_0, BVG[int_5 + 1], num, (int)Math.Round(num4), int_8, int_9, int_10, int_11, BVi, BVJ, out var float_10, out var _, out var float_12);
			graphics_0.DrawLine(BVb, float_7, float_9, float_10, float_12);
		}
	}

	private void method_33(Graphics graphics_0, Table table_0, bool bool_0, int int_3, int int_4)
	{
		int int_5 = (Form23.bool_49 ? BVi : 0);
		if (!bool_0)
		{
			return;
		}
		Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKG : BKh);
		if (setting == null)
		{
			return;
		}
		float float_ = 0f;
		float float_2 = 0f;
		float float_3 = 0f;
		float float_4 = 0f;
		float float_5 = 0f;
		float float_6 = 0f;
		method_35(table_0, BVG[0], BVg[int_4 - 1], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
		method_35(table_0, BVG[int_3 - 1], BVg[int_4 - 1], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_4, out float_5, out float_6);
		if (float_2 < float_5)
		{
			method_35(table_0, (BVG[int_3 - 1] - BVG[0]) * 17 / 16 + BVG[0], (BVg[0] + BVg[int_4 - 1]) / 2, int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
			string text = setting.method_18();
			string s;
			if (!string.IsNullOrWhiteSpace(text))
			{
				s = text;
			}
			else
			{
				string text2 = setting.method_60(Enum96.aYt);
				s = ((string.IsNullOrEmpty(text2) || text2.Length >= 20) ? setting.method_60(Enum96.aYT) : text2);
			}
			StringFormat format = ((!(float_ > (float)(Width / 2))) ? BVD : BVc);
			graphics_0.DrawString(s, BVC, BuZ, float_, float_3, format);
			int num = setting.method_231();
			string text3 = Class333.smethod_325() + Class233.smethod_35(setting.method_232(), num, bool_0: false, 0);
			method_35(table_0, (BVG[int_3 - 1] - BVG[0]) * 17 / 16 + BVG[0], BVg[0], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
			List<Setting.ListItems.Struct45> list = setting.method_102();
			bool flag = false;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].bBv == BVg[0])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				string s2 = Class233.smethod_29(BVg[0], num) + text3;
				graphics_0.DrawString(s2, BVC, BuZ, float_, float_3, format);
			}
			method_35(table_0, (BVG[int_3 - 1] - BVG[0]) * 17 / 16 + BVG[0], BVg[int_4 - 1], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
			flag = false;
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].bBv == BVg[int_4 - 1])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				string s3 = Class233.smethod_29(BVg[int_4 - 1], num) + text3;
				graphics_0.DrawString(s3, BVC, BuZ, float_, float_3, format);
			}
			return;
		}
		method_35(table_0, BVG[int_3 - 1] - (BVG[int_3 - 1] - BVG[0]) * 17 / 16, (BVg[0] + BVg[int_4 - 1]) / 2, int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
		string text4 = setting.method_18();
		string s4;
		if (!string.IsNullOrWhiteSpace(text4))
		{
			s4 = text4;
		}
		else
		{
			string text5 = setting.method_60(Enum96.aYt);
			s4 = ((string.IsNullOrEmpty(text5) || text5.Length >= 20) ? setting.method_60(Enum96.aYT) : text5);
		}
		StringFormat format2 = ((!(float_ > (float)(Width / 2))) ? BVD : BVc);
		graphics_0.DrawString(s4, BVC, BuZ, float_, float_3, format2);
		int num2 = setting.method_231();
		string text6 = Class333.smethod_325() + Class233.smethod_35(setting.method_232(), num2, bool_0: false, 0);
		method_35(table_0, BVG[int_3 - 1] - (BVG[int_3 - 1] - BVG[0]) * 17 / 16, BVg[0], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
		List<Setting.ListItems.Struct45> list2 = setting.method_102();
		bool flag2 = false;
		for (int k = 0; k < list2.Count; k++)
		{
			if (list2[k].bBv == BVg[0])
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			string s5 = Class233.smethod_29(BVg[0], num2) + text6;
			graphics_0.DrawString(s5, BVC, BuZ, float_, float_3, format2);
		}
		method_35(table_0, BVG[int_3 - 1] - (BVG[int_3 - 1] - BVG[0]) * 17 / 16, BVg[int_4 - 1], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
		flag2 = false;
		for (int l = 0; l < list2.Count; l++)
		{
			if (list2[l].bBv == BVg[int_4 - 1])
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			string s6 = Class233.smethod_29(BVg[int_4 - 1], num2) + text6;
			graphics_0.DrawString(s6, BVC, BuZ, float_, float_3, format2);
		}
	}

	private void method_34(Graphics graphics_0, Table table_0, bool bool_0, int int_3, int int_4)
	{
		int int_5 = (Form23.bool_49 ? BVi : 0);
		if (!bool_0)
		{
			return;
		}
		Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKf : BKH);
		if (setting == null)
		{
			return;
		}
		float float_ = 0f;
		float float_2 = 0f;
		float float_3 = 0f;
		float float_4 = 0f;
		float float_5 = 0f;
		float float_6 = 0f;
		method_35(table_0, BVG[int_3 - 1], BVg[0], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
		method_35(table_0, BVG[int_3 - 1], BVg[int_4 - 1], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_4, out float_5, out float_6);
		if (float_2 < float_5)
		{
			method_35(table_0, (BVG[0] + BVG[int_3 - 1]) / 2, (BVg[int_4 - 1] - BVg[0]) * 17 / 16 + BVg[0], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
			string text = setting.method_18();
			string s;
			if (!string.IsNullOrWhiteSpace(text))
			{
				s = text;
			}
			else
			{
				string text2 = setting.method_60(Enum96.aYt);
				s = ((string.IsNullOrEmpty(text2) || text2.Length >= 20) ? setting.method_60(Enum96.aYT) : text2);
			}
			StringFormat format = ((!(float_ > (float)(Width / 2))) ? BVD : BVc);
			graphics_0.DrawString(s, BVC, BuZ, float_, float_3, format);
			int num = setting.method_231();
			string text3 = Class333.smethod_325() + Class233.smethod_35(setting.method_232(), num, bool_0: false, 0);
			method_35(table_0, BVG[0], (BVg[int_4 - 1] - BVg[0]) * 17 / 16 + BVg[0], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
			List<Setting.ListItems.Struct45> list = setting.method_102();
			bool flag = false;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].bBv == BVG[0])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				string s2 = Class233.smethod_29(BVG[0], num) + text3;
				graphics_0.DrawString(s2, BVC, BuZ, float_, float_3, format);
			}
			method_35(table_0, BVG[int_3 - 1], (BVg[int_4 - 1] - BVg[0]) * 17 / 16 + BVg[0], int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
			flag = false;
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].bBv == BVG[int_3 - 1])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				string s3 = Class233.smethod_29(BVG[int_3 - 1], num) + text3;
				graphics_0.DrawString(s3, BVC, BuZ, float_, float_3, format);
			}
			return;
		}
		method_35(table_0, (BVG[0] + BVG[int_3 - 1]) / 2, BVg[int_4 - 1] - (BVg[int_4 - 1] - BVg[0]) * 17 / 16, int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
		string text4 = setting.method_18();
		string s4;
		if (!string.IsNullOrWhiteSpace(text4))
		{
			s4 = text4;
		}
		else
		{
			string text5 = setting.method_60(Enum96.aYt);
			s4 = ((string.IsNullOrEmpty(text5) || text5.Length >= 20) ? setting.method_60(Enum96.aYT) : text5);
		}
		StringFormat format2 = ((!(float_ > (float)(Width / 2))) ? BVD : BVc);
		graphics_0.DrawString(s4, BVC, BuZ, float_, float_3, format2);
		int num2 = setting.method_231();
		string text6 = Class333.smethod_325() + Class233.smethod_35(setting.method_232(), num2, bool_0: false, 0);
		method_35(table_0, BVG[0], BVg[int_4 - 1] - (BVg[int_4 - 1] - BVg[0]) * 17 / 16, int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
		List<Setting.ListItems.Struct45> list2 = setting.method_102();
		bool flag2 = false;
		for (int k = 0; k < list2.Count; k++)
		{
			if (list2[k].bBv == BVG[0])
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			string s5 = Class233.smethod_29(BVG[0], num2) + text6;
			graphics_0.DrawString(s5, BVC, BuZ, float_, float_3, format2);
		}
		method_35(table_0, BVG[int_3 - 1], BVg[int_4 - 1] - (BVg[int_4 - 1] - BVg[0]) * 17 / 16, int_5, BVG[0], BVG[int_3 - 1], BVg[0], BVg[int_4 - 1], BVi, BVJ, out float_, out float_2, out float_3);
		flag2 = false;
		for (int l = 0; l < list2.Count; l++)
		{
			if (list2[l].bBv == BVG[int_3 - 1])
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			string s6 = Class233.smethod_29(BVG[int_3 - 1], num2) + text6;
			graphics_0.DrawString(s6, BVC, BuZ, float_, float_3, format2);
		}
	}

	private void Class103_Paint(object sender, PaintEventArgs e)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BKE : BKe);
		if (table == null)
		{
			return;
		}
		Graphics graphics = e.Graphics;
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		method_27(graphics);
		method_28(graphics);
		bool flag = table.HorizAxisEnabled();
		bool flag2 = table.VertAxisEnabled();
		if (flag || flag2)
		{
			int num = table.HorizAxisCount();
			if (num == 1)
			{
				num = 2;
			}
			int num2 = table.VertAxisCount();
			if (num2 == 1)
			{
				num2 = 2;
			}
			if (num > 64)
			{
				throw new Exception(Class333.BFy());
			}
			if (num2 > 64)
			{
				throw new Exception(Class333.BFy());
			}
			method_29(graphics, table, flag, flag2, num, num2);
			method_30(graphics, table, flag, flag2, num, num2);
			method_33(graphics, table, flag2, num, num2);
			method_34(graphics, table, flag, num, num2);
			stopwatch.Stop();
			Class23.smethod_3(string.Format(Class333.BfA(), stopwatch.ElapsedMilliseconds, Left, Top), bool_1: false);
		}
	}

	private void method_35(Table table_0, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, int int_9, int int_10, int int_11, out float float_0, out float float_1, out float float_2)
	{
		method_36(table_0, int_3, int_4, int_5, int_6, int_7, int_8, int_9, int_10, int_11, out float_0, out float_1, out float_2, bool_0: false);
	}

	private void method_36(Table table_0, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, int int_9, int int_10, int int_11, out float float_0, out float float_1, out float float_2, bool bool_0)
	{
		int num = ((BKj == null || !BKj.Visible) ? Height : (Height - BKj.Height));
		float num2 = (float)num * 0.7f;
		int val = (Form23.bool_49 ? BVi : 0);
		float num3 = int_7 - int_6;
		float num4 = int_9 - int_8;
		float num5 = int_11 - Math.Min(int_10, val);
		float num6 = ((num3 == 0f) ? 1f : ((float)(int_3 - int_6) * num2 / num3 - num2 / 2f));
		float num7 = ((num4 == 0f) ? 1f : ((float)(int_4 - int_8) * num2 / num4 - num2 / 2f));
		float num8 = ((num5 == 0f) ? (-1f) : ((0f - (float)(int_5 - Math.Min(int_10, val)) * (num2 / 2f)) / num5 + num2 / 4f));
		float num9 = num6 * table_0.CosXFor3DView + num7 * table_0.SinXFor3DView;
		float num10 = num7 * table_0.CosXFor3DView - num6 * table_0.SinXFor3DView;
		float num11 = table_0.CosYFor3DView * num8 + table_0.SinYFor3DView * num10;
		num10 = table_0.CosYFor3DView * num10 - table_0.SinYFor3DView * num8;
		float_0 = num9 + (float)(Width / 2);
		float_1 = num10;
		float_2 = num11 + (float)(num / 2);
		if (BVO & bool_0)
		{
			BVn.Text = Class333.Bfa() + table_0.RotationXAngleDegrees + Class333.BfB() + table_0.RotationYAngleDegrees + Class333.Bfb() + num6 + Class333.BfC() + num7 + Class333.Bfc() + num8 + Class333.BfD() + float_0 + Class333.Bfd() + float_1 + Class333.BfE() + float_2;
		}
	}

	private void method_37(object sender, EventArgs e)
	{
		if (BKE != null && BKe != null)
		{
			BKe.RotationXAngleDegrees = BKE.RotationXAngleDegrees;
			BKe.RotationYAngleDegrees = BKE.RotationYAngleDegrees;
		}
		method_26(null, null);
	}

	protected override void MouseDownHandler(object sender, MouseEventArgs e)
	{
		Focus();
		if (e.Button != MouseButtons.Left)
		{
			return;
		}
		if (e.X >= Width - 13 - 24 && e.Y >= 13 && e.X <= Width - 13 - 4 && e.Y <= 33)
		{
			method_41(null, null);
			return;
		}
		BVP = e.X;
		BVp = e.Y;
		if (BKE != null)
		{
			BVQ = BKE.RotationXAngleDegrees;
			BVq = BKE.RotationYAngleDegrees;
		}
		int num = ((BKj == null || !BKj.Visible) ? (Height - 30) : (Height - (BKj.Height + 30)));
		if (BKE != null && BVP > 50 && BVP < Width - 50 && BVp > 30 && BVp < num)
		{
			BVo = true;
		}
		else
		{
			base.MouseDownHandler(sender, e);
		}
	}

	protected override void MouseMoveHandler(object sender, MouseEventArgs e)
	{
		if (e.X >= Width - 13 - 24 && e.Y >= 13 && e.X <= Width - 13 - 4 && e.Y <= 33)
		{
			if (!BVR)
			{
				BVR = true;
				Invalidate();
			}
		}
		else if (BVR)
		{
			BVR = false;
			Invalidate();
		}
		if (e.Button == MouseButtons.Left && BVo)
		{
			BringToFront();
			int num = e.X - BVP;
			int num2 = e.Y - BVp;
			BKE.RotationXAngleDegrees = BVQ + (float)(num / 3);
			BKE.RotationYAngleDegrees = Math.Min(Math.Max(BVq + (float)(num2 / 3), 0f), 90f);
		}
		else
		{
			base.MouseMoveHandler(sender, e);
		}
	}

	protected override void MouseUpHandler(object sender, MouseEventArgs e)
	{
		base.MouseUpHandler(sender, e);
		BVo = false;
	}

	private void Class103_GotFocus(object sender, EventArgs e)
	{
		if (BKE != null)
		{
			if (BKE.HorizVertIndexPerUserSelectedCell.Count == 0)
			{
				BKE.UserCurrentCellHorizVertIndex = new Point(0, 0);
				BKE.HorizVertIndexPerUserSelectedCell.Add(new Point(0, 0));
			}
			Form23.smethod_12(this);
		}
		Invalidate();
	}

	private void Class103_LostFocus(object sender, EventArgs e)
	{
		Form23.smethod_13();
		Invalidate();
	}

	private void method_38(object sender, EventArgs e)
	{
		Enum65 @enum = (Form23.form23_0.control25_0.SelectedTab as Class130).method_0();
		int selectedIndex = Form23.form23_0.control25_0.SelectedIndex;
		if (@enum != Enum65.const_1 && Form23.form23_0.control25_0.method_5(selectedIndex) == this)
		{
			Form54.smethod_6(Form23.form23_0, Class333.Bfe(), Class333.BfF(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Class30.smethod_0(this);
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_39(object sender, EventArgs e)
	{
		int num = Form46.smethod_0(Form23.form23_0, BKD);
		if (num != 0)
		{
			Setting setting = BKD.method_31(num);
			if (setting != null)
			{
				Form23.form23_0.control25_0.method_43(setting as Table, new Rectangle(Left, Top, Width, Height));
				method_38(null, null);
			}
		}
	}

	private void method_40(object sender, EventArgs e)
	{
		Form23.form23_0.control25_0.method_37(this);
	}

	internal override void vmethod_3(object sender, EventArgs e)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BKD.method_4() || BKE == null || !BKE.method_35())
		{
			return;
		}
		Form51 form = new Form51(BKE);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			HashSet<DataIdAndAttrId> idsContained = BKE.GetIdsContained();
			BKD.method_42(idsContained);
			BKD.method_40(idsContained, BKd, Form23.hashSet_0);
			BKD.method_38(idsContained);
			Form23.form23_0.control4_0.method_14(bool_7: false, bool_8: true, bool_9: false, bool_10: false);
			Form23.smethod_43();
			Form23.form23_0.control4_0.method_39(bool_7: false);
			if (Form23.framework_0 != null)
			{
				Form23.form23_0.control4_0.method_40(bool_7: false);
			}
			method_13();
			UpdateLayout(resizingOnly: false);
			Focus();
		}
		form.Dispose();
	}

	private void method_41(object sender, EventArgs e)
	{
		if (BKE != null)
		{
			BKE.ResetViewingAngleToDefault();
		}
	}

	private void BVr_Click(object sender, EventArgs e)
	{
		method_14(!Bux);
	}

	private void method_42(object sender, EventArgs e)
	{
		if (ContextMenuStrip == null)
		{
			return;
		}
		foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
		{
			if (item.Text == Class333.Bff())
			{
				item.Enabled = !Form23.form23_0.control25_0.method_25(this);
				break;
			}
		}
	}

	private ContextMenuStrip method_43()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		contextMenuStrip.Opened += method_42;
		if ((Form23.form23_0.control25_0.SelectedTab as Class130).method_0() == Enum65.const_1)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem.Text = Class333.BFV();
			toolStripMenuItem.Click += method_39;
			contextMenuStrip.Items.Add(toolStripMenuItem);
		}
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Text = Class333.BfG();
		toolStripMenuItem2.ShortcutKeyDisplayString = Class333.smethod_1285();
		toolStripMenuItem2.Click += method_40;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		if (BKD.method_4())
		{
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
			toolStripMenuItem3.Text = Class333.smethod_1570();
			toolStripMenuItem3.ShortcutKeys = Keys.F3;
			toolStripMenuItem3.Click += vmethod_3;
			contextMenuStrip.Items.Add(toolStripMenuItem3);
		}
		ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
		toolStripMenuItem4.Text = Class333.BFz();
		toolStripMenuItem4.Click += method_41;
		contextMenuStrip.Items.Add(toolStripMenuItem4);
		BVr = new ToolStripMenuItem();
		BVr.Text = Class333.BFw();
		BVr.Click += BVr_Click;
		contextMenuStrip.Items.Add(BVr);
		ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem();
		toolStripMenuItem5.Text = Class333.Bff();
		toolStripMenuItem5.Click += method_38;
		contextMenuStrip.Items.Add(toolStripMenuItem5);
		return contextMenuStrip;
	}

	internal void method_44(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.Bfg());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.BBi() + BKF);
		if (BKE != null)
		{
			list.Add(Class333.BBJ() + BKE.InvertRows);
			list.Add(Class333.BBj() + BKE.SwapColumnsAndRows);
			list.Add(Class333.BfH() + (int)BKE.RotationXAngleDegrees);
			list.Add(Class333.Bfh() + (int)BKE.RotationYAngleDegrees);
		}
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal void method_45(StreamReader streamReader_0)
	{
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.BBi()))
			{
				BKF = int.Parse(text.Substring(Class333.BBi().Length));
				if (BKD.method_31(BKF) != null)
				{
					vmethod_2(BKF);
				}
			}
			else if (text.Contains(Class333.BBK()))
			{
				BKF = int.Parse(text.Substring(text.IndexOf(Class333.BBK()) + Class333.BBK().Length));
				if (BKD.method_31(BKF) != null)
				{
					vmethod_2(BKF);
				}
			}
			else if (text.StartsWith(Class333.BBJ()))
			{
				if (BKE != null)
				{
					BKE.InvertRows = bool.Parse(text.Substring(Class333.BBJ().Length));
				}
			}
			else if (text.StartsWith(Class333.BBj()))
			{
				if (BKE != null)
				{
					BKE.SwapColumnsAndRows = bool.Parse(text.Substring(Class333.BBj().Length));
				}
			}
			else if (text.StartsWith(Class333.BfH()))
			{
				if (BKE != null)
				{
					BKE.RotationXAngleDegrees = int.Parse(text.Substring(Class333.BfH().Length));
				}
			}
			else if (text.StartsWith(Class333.Bfh()))
			{
				if (BKE != null)
				{
					BKE.RotationYAngleDegrees = int.Parse(text.Substring(Class333.Bfh().Length));
				}
			}
			else if (!text.Contains(Class333.Bai()) && string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
	}

	private void method_46()
	{
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (topSelectedVert == bottomSelectedVert)
		{
			if (rightSelectedHoriz - leftSelectedHoriz + 1 >= 3)
			{
				BKE.TableDataSetting.method_268();
				BKE.LineariseLeftToRight(topSelectedVert, leftSelectedHoriz, rightSelectedHoriz, BKe, forHorizAxisInsertion: false);
				BKE.TableDataSetting.method_267(bool_0: true);
				Invalidate();
			}
		}
		else if (leftSelectedHoriz == rightSelectedHoriz)
		{
			if (bottomSelectedVert - topSelectedVert + 1 >= 3)
			{
				BKE.TableDataSetting.method_268();
				BKE.LineariseTopToBottom(leftSelectedHoriz, topSelectedVert, bottomSelectedVert, BKe);
				BKE.TableDataSetting.method_267(bool_0: true);
				Invalidate();
			}
		}
		else
		{
			BKE.TableDataSetting.method_268();
			BKE.LineariseRange(leftSelectedHoriz, rightSelectedHoriz, topSelectedVert, bottomSelectedVert, BKe);
			BKE.TableDataSetting.method_267(bool_0: true);
			Invalidate();
		}
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
	}

	private void method_47()
	{
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (rightSelectedHoriz - leftSelectedHoriz + 1 >= 3)
		{
			BKE.TableDataSetting.method_268();
			for (int i = topSelectedVert; i <= bottomSelectedVert; i++)
			{
				BKE.LineariseLeftToRight(i, leftSelectedHoriz, rightSelectedHoriz, BKe, forHorizAxisInsertion: false);
			}
			BKE.TableDataSetting.method_267(bool_0: true);
			Invalidate();
		}
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
	}

	private void method_48()
	{
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.GetSelectedLeftRightTopBottomIndices(out var leftSelectedHoriz, out var rightSelectedHoriz, out var topSelectedVert, out var bottomSelectedVert);
		if (bottomSelectedVert - topSelectedVert + 1 >= 3)
		{
			BKE.TableDataSetting.method_268();
			for (int i = leftSelectedHoriz; i <= rightSelectedHoriz; i++)
			{
				BKE.LineariseTopToBottom(i, topSelectedVert, bottomSelectedVert, BKe);
			}
			BKE.TableDataSetting.method_267(bool_0: true);
			Invalidate();
		}
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
	}

	private void method_49(int int_3, int int_4)
	{
		if (int_3 == -1 || int_4 == -1)
		{
			return;
		}
		List<Point> list = new List<Point>();
		list.Add(new Point(int_3, int_4));
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			BKe.UserCurrentCellHorizVertIndex = new Point(int_3, int_4);
			BKe.HorizVertIndexPerUserSelectedCell = list;
			BKE.UserCurrentCellHorizVertIndex = new Point(int_3, int_4);
			BKE.HorizVertIndexPerUserSelectedCell = list;
			return;
		}
		BKE.UserCurrentCellHorizVertIndex = new Point(int_3, int_4);
		BKE.HorizVertIndexPerUserSelectedCell = list;
		if (BKe != null)
		{
			BKe.UserCurrentCellHorizVertIndex = new Point(int_3, int_4);
			BKe.HorizVertIndexPerUserSelectedCell = list;
		}
	}

	private void method_50()
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		int currentHoriz = 0;
		int currentVert = 0;
		int currentSlice = 0;
		BKE.GetOperatingPoint(ref currentHoriz, ref currentVert, ref currentSlice);
		int leftSelectedHoriz = int.MaxValue;
		int rightSelectedHoriz = int.MinValue;
		int topSelectedVert = int.MaxValue;
		int bottomSelectedVert = int.MinValue;
		BKE.GetSelectedLeftRightTopBottomIndices(out leftSelectedHoriz, out rightSelectedHoriz, out topSelectedVert, out bottomSelectedVert);
		int num = rightSelectedHoriz - leftSelectedHoriz + 1;
		int num2 = bottomSelectedVert - topSelectedVert + 1;
		int val = currentHoriz - num / 2;
		int val2 = currentVert - num2 / 2;
		int num3 = BKE.HorizAxisCount();
		int num4 = BKE.VertAxisCount();
		val = Math.Min(Math.Max(val, 0), num3 - num);
		val2 = Math.Min(Math.Max(val2, 0), num4 - num2);
		List<Point> list = new List<Point>();
		for (int i = 0; i < num2; i++)
		{
			for (int j = 0; j < num; j++)
			{
				int x = val + j;
				int y = val2 + i;
				list.Add(new Point(x, y));
			}
		}
		BKE.UserCurrentCellHorizVertIndex = new Point(currentHoriz, currentVert);
		BKE.HorizVertIndexPerUserSelectedCell = list;
		if (BKe != null)
		{
			BKe.UserCurrentCellHorizVertIndex = new Point(currentHoriz, currentVert);
			BKe.HorizVertIndexPerUserSelectedCell = list;
		}
		BKE.UserSliceIndex = currentSlice;
		if (BKe != null)
		{
			BKe.UserSliceIndex = currentSlice;
		}
	}

	internal bool method_51(KeyEventArgs keyEventArgs_0)
	{
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return false;
		}
		if (!BKD.method_4())
		{
			return false;
		}
		if ((!keyEventArgs_0.Control || keyEventArgs_0.KeyCode != Keys.Prior) && keyEventArgs_0.KeyData != Keys.Prior && (!keyEventArgs_0.Shift || keyEventArgs_0.KeyCode != Keys.Prior) && (!keyEventArgs_0.Control || keyEventArgs_0.KeyCode != Keys.Next) && keyEventArgs_0.KeyData != Keys.Next && (!keyEventArgs_0.Shift || keyEventArgs_0.KeyCode != Keys.Next) && keyEventArgs_0.KeyData != Keys.OemOpenBrackets && keyEventArgs_0.KeyData != Keys.OemCloseBrackets && keyEventArgs_0.KeyData != Keys.OemSemicolon && keyEventArgs_0.KeyData != Keys.Oem7 && keyEventArgs_0.KeyData != Keys.Oemcomma && keyEventArgs_0.KeyData != Keys.OemPeriod)
		{
			return false;
		}
		if (!BKE.method_35())
		{
			return true;
		}
		Class280 @class = Form23.smethod_95();
		@class?.method_2(BKE.TableDataSetting.method_64());
		BKE.IncreaseOrDecreaseSelectedCellValues(keyEventArgs_0);
		@class?.method_4();
		Form23.smethod_74(BKE.TableDataSetting.method_64());
		return true;
	}

	protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs previewKeyDownEventArgs_0)
	{
		previewKeyDownEventArgs_0.IsInputKey = previewKeyDownEventArgs_0.KeyData == Keys.D || (previewKeyDownEventArgs_0.Control && previewKeyDownEventArgs_0.KeyCode == Keys.Prior) || (previewKeyDownEventArgs_0.Control && previewKeyDownEventArgs_0.KeyCode == Keys.Next) || (previewKeyDownEventArgs_0.Shift && previewKeyDownEventArgs_0.KeyCode == Keys.Prior) || (previewKeyDownEventArgs_0.Shift && previewKeyDownEventArgs_0.KeyCode == Keys.Next) || previewKeyDownEventArgs_0.KeyData == Keys.Prior || previewKeyDownEventArgs_0.KeyData == Keys.Next || previewKeyDownEventArgs_0.KeyData == Keys.OemOpenBrackets || previewKeyDownEventArgs_0.KeyData == Keys.OemCloseBrackets || previewKeyDownEventArgs_0.KeyData == Keys.OemSemicolon || previewKeyDownEventArgs_0.KeyData == Keys.Oem7 || previewKeyDownEventArgs_0.KeyData == Keys.Oemcomma || previewKeyDownEventArgs_0.KeyData == Keys.OemPeriod || previewKeyDownEventArgs_0.KeyData == Keys.Left || previewKeyDownEventArgs_0.KeyData == Keys.Up || previewKeyDownEventArgs_0.KeyData == Keys.Right || previewKeyDownEventArgs_0.KeyData == Keys.Down || previewKeyDownEventArgs_0.KeyData == (Keys.Left | Keys.Shift) || previewKeyDownEventArgs_0.KeyData == (Keys.Up | Keys.Shift) || previewKeyDownEventArgs_0.KeyData == (Keys.Right | Keys.Shift) || previewKeyDownEventArgs_0.KeyData == (Keys.Down | Keys.Shift) || previewKeyDownEventArgs_0.KeyData == (Keys.Left | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Up | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Right | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Down | Keys.Control) || (previewKeyDownEventArgs_0.Control && previewKeyDownEventArgs_0.KeyCode == Keys.Space) || previewKeyDownEventArgs_0.KeyData == Keys.Escape || previewKeyDownEventArgs_0.KeyData == Keys.F3 || previewKeyDownEventArgs_0.KeyData == (Keys.Z | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Y | Keys.Control) || previewKeyDownEventArgs_0.KeyData == Keys.L || previewKeyDownEventArgs_0.KeyData == Keys.H || previewKeyDownEventArgs_0.KeyData == Keys.V || previewKeyDownEventArgs_0.KeyData == Keys.Space || previewKeyDownEventArgs_0.KeyData == (Keys.C | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.V | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Left | Keys.Shift | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Up | Keys.Shift | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Right | Keys.Shift | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Down | Keys.Shift | Keys.Control);
	}

	protected override void OnKeyDown(KeyEventArgs keyEventArgs_0)
	{
		if (BKe != null && (BKi || BKJ) && Form23.enum60_0 == Form23.Enum60.BpF)
		{
			return;
		}
		if (keyEventArgs_0.KeyData == Keys.D)
		{
			method_40(null, null);
		}
		if ((BKE != null && BKE.HorizVertIndexPerUserSelectedCell.Count == 0) || !BKD.method_4() || (keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Prior) || (keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Next) || (keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Prior) || (keyEventArgs_0.Shift && keyEventArgs_0.KeyCode == Keys.Next) || keyEventArgs_0.KeyData == Keys.Prior || keyEventArgs_0.KeyData == Keys.Next || keyEventArgs_0.KeyData == Keys.OemOpenBrackets || keyEventArgs_0.KeyData == Keys.OemCloseBrackets || keyEventArgs_0.KeyData == Keys.OemSemicolon || keyEventArgs_0.KeyData == Keys.Oem7 || keyEventArgs_0.KeyData == Keys.Oemcomma || keyEventArgs_0.KeyData == Keys.OemPeriod || BKE == null)
		{
			return;
		}
		if (keyEventArgs_0.KeyData == Keys.Left)
		{
			BKE.MoveSelectionLeft(BKe);
		}
		else if (keyEventArgs_0.KeyData == Keys.Up)
		{
			BKE.MoveSelectionUp(BKe);
		}
		else if (keyEventArgs_0.KeyData == Keys.Right)
		{
			BKE.MoveSelectionRight(BKe);
		}
		else if (keyEventArgs_0.KeyData == Keys.Down)
		{
			BKE.MoveSelectionDown(BKe);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Left | Keys.Shift))
		{
			BKE.IncreaseSelectionSizeOnLeft(BKe);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Up | Keys.Shift))
		{
			BKE.IncreaseSelectionSizeOnTop(BKe);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Right | Keys.Shift))
		{
			BKE.IncreaseSelectionSizeOnRight(BKe);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Down | Keys.Shift))
		{
			BKE.IncreaseSelectionSizeOnBottom(BKe);
		}
		else if (keyEventArgs_0.KeyData == (Keys.Left | Keys.Control))
		{
			BKE.DecreaseSelectionSizeOnRight();
		}
		else if (keyEventArgs_0.KeyData == (Keys.Up | Keys.Control))
		{
			BKE.DecreaseSelectionSizeOnBottom();
		}
		else if (keyEventArgs_0.KeyData == (Keys.Right | Keys.Control))
		{
			BKE.DecreaseSelectionSizeOnLeft();
		}
		else if (keyEventArgs_0.KeyData == (Keys.Down | Keys.Control))
		{
			BKE.DecreaseSelectionSizeOnTop();
		}
		else if ((keyEventArgs_0.Control && keyEventArgs_0.KeyCode == Keys.Space) || keyEventArgs_0.KeyData == Keys.Escape)
		{
			method_49(BKE.UserCurrentCellHorizVertIndex.X, BKE.UserCurrentCellHorizVertIndex.Y);
		}
		else
		{
			if (!BKE.method_35() || Form23.enum60_0 == Form23.Enum60.BpG)
			{
				return;
			}
			if (keyEventArgs_0.KeyData == Keys.F3)
			{
				vmethod_3(null, null);
			}
			else if (keyEventArgs_0.KeyData == (Keys.Z | Keys.Control))
			{
				Form23.form23_0.toolStripButton_2_Click(null, null);
			}
			else if (keyEventArgs_0.KeyData == (Keys.Y | Keys.Control))
			{
				Form23.form23_0.toolStripButton_3_Click(null, null);
			}
			else if (keyEventArgs_0.KeyData == Keys.L)
			{
				method_46();
			}
			else if (keyEventArgs_0.KeyData == Keys.H)
			{
				method_47();
			}
			else if (keyEventArgs_0.KeyData == Keys.V)
			{
				method_48();
			}
			else if (keyEventArgs_0.KeyData == Keys.Space)
			{
				method_50();
			}
			else if (keyEventArgs_0.KeyData == (Keys.C | Keys.Control))
			{
				BKE.CopyCellValuesToClipboard(BKe);
			}
			else if (keyEventArgs_0.KeyData == (Keys.V | Keys.Control))
			{
				BKE.method_298(BKe, null);
			}
			else if (BKe != null || (!BKi && !BKJ) || Form23.enum60_0 != Form23.Enum60.BpF)
			{
				if (keyEventArgs_0.KeyData == (Keys.Left | Keys.Shift | Keys.Control))
				{
					BKE.method_294(BKe, null);
				}
				else if (keyEventArgs_0.KeyData == (Keys.Up | Keys.Shift | Keys.Control))
				{
					BKE.method_296(BKe, null);
				}
				else if (keyEventArgs_0.KeyData == (Keys.Right | Keys.Shift | Keys.Control))
				{
					BKE.method_295(BKe, null);
				}
				else if (keyEventArgs_0.KeyData == (Keys.Down | Keys.Shift | Keys.Control))
				{
					BKE.method_297(BKe, null);
				}
			}
		}
	}
}
