using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns0;
using ns1;
using ns4;
using ns5;
using ns7;

namespace ns3;

internal class Class114 : Class109, Interface3
{
	internal class Class127 : Panel
	{
		private const int bau = 55;

		private const int baV = 30;

		private const int bav = 10;

		private const int baW = 40;

		private OnOffSwitchingPoint baw;

		private int baX;

		private int bax;

		private string baY = string.Empty;

		private string bay = string.Empty;

		private Class26 baZ = new Class26();

		private Class26 baz = new Class26();

		private bool bBA;

		private int bBa;

		private int bBB;

		private int bBb;

		private int bBC;

		private int bBc;

		private int bBD;

		private SolidBrush bBd = new SolidBrush(Form23.color_12);

		private Font bBE;

		private Font bBe;

		public Class127(OnOffSwitchingPoint onOffSwitchingPoint_0)
		{
			bBE = new Font(Font.FontFamily, 8f);
			bBe = new Font(Font.FontFamily, 8f, FontStyle.Bold);
			baw = onOffSwitchingPoint_0;
			AutoSize = false;
			Width = 450;
			Height = 200;
			method_0();
		}

		protected override void Dispose(bool disposing)
		{
			bBd.Dispose();
			bBE.Dispose();
			bBe.Dispose();
		}

		internal void method_0()
		{
			Setting setting = baw.method_0().method_31(baw.ColumnChannelDataId);
			if (setting != null)
			{
				baX = setting.method_231();
				baY = setting.method_22(bool_0: true) + Class333.smethod_497() + Class233.smethod_35(setting.method_232(), baX, bool_0: false, 0) + Class333.smethod_9();
			}
			Setting setting2 = baw.method_0().method_31(baw.RowChannelDataId);
			if (setting2 != null)
			{
				bax = setting2.method_231();
				bay = setting2.method_22(bool_0: true) + Class333.smethod_497() + Class233.smethod_35(setting2.method_232(), bax, bool_0: false, 0) + Class333.smethod_9();
			}
			bBA = baw.UpperBoundsEnablerSetting.method_256() == 0;
			bBb = baw.Point1RowUpperBoundSetting.method_256();
			bBC = baw.Point2RowUpperBoundSetting.method_256();
			bBc = baw.Point1RowLowerBoundSetting.method_256();
			bBD = baw.Point2RowLowerBoundSetting.method_256();
			int num = Math.Max(bBC, bBb);
			if (bBA)
			{
				num = Math.Max(bBD, bBc);
			}
			int num2 = Math.Min(bBc, bBD);
			if (num2 == num)
			{
				num2 -= 1000;
				num += 1000;
			}
			int num3 = (num - num2) / 5;
			baz.method_7(num2 - num3);
			baz.method_9(num + num3);
			baz.method_11(Height - 40);
			baz.method_13(30f);
			baz.method_5(bax);
			baz.method_27();
			bBa = baw.Point1ColumnValueSetting.method_256();
			bBB = baw.Point2ColumnValueSetting.method_256();
			baZ.method_5(baX);
			baZ.method_15(25f);
			int num4 = (bBB - bBa) / 5;
			baZ.method_7(bBa - num4);
			baZ.method_9(bBB + num4);
			baZ.method_11(55f);
			baZ.method_13(Width - 10);
			baZ.method_27();
			Invalidate();
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			base.OnPaint(paintEventArgs_0);
			Graphics graphics = paintEventArgs_0.Graphics;
			graphics.DrawString(Class333.BJk(), bBe, Brushes.Green, 220f, 10f);
			graphics.DrawString(Class333.smethod_177(), bBe, bBd, 246f, 10f);
			graphics.DrawString(Class333.BJL(), bBe, Brushes.DarkRed, 260f, 10f);
			float num = 55f;
			float num2 = Width - 10;
			float num3 = 30f;
			float num4 = Height - 40;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			using (SolidBrush solidBrush = new SolidBrush(Color.Green))
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddLine(num, baz.method_28(bBc), baZ.method_28(bBa), baz.method_28(bBc));
				graphicsPath.AddLine(baZ.method_28(bBa), baz.method_28(bBc), baZ.method_28(bBB), baz.method_28(bBD));
				graphicsPath.AddLine(baZ.method_28(bBB), baz.method_28(bBD), num2, baz.method_28(bBD));
				if (bBA)
				{
					graphicsPath.AddLine(num2, baz.method_28(bBD), num2, num3);
					graphicsPath.AddLine(num2, num3, num, num3);
					graphicsPath.AddLine(num, num3, num, baz.method_28(bBc));
				}
				else
				{
					graphicsPath.AddLine(num2, baz.method_28(bBD), num2, baz.method_28(bBC));
					graphicsPath.AddLine(num2, baz.method_28(bBC), baZ.method_28(bBB), baz.method_28(bBC));
					graphicsPath.AddLine(baZ.method_28(bBB), baz.method_28(bBC), baZ.method_28(bBa), baz.method_28(bBb));
					graphicsPath.AddLine(baZ.method_28(bBa), baz.method_28(bBb), num, baz.method_28(bBb));
				}
				graphics.FillRegion(solidBrush, new Region(graphicsPath));
				graphicsPath.Dispose();
				solidBrush.Color = Color.DarkRed;
				graphicsPath = new GraphicsPath();
				graphicsPath.AddLine(num, baz.method_28(bBc), baZ.method_28(bBa), baz.method_28(bBc));
				graphicsPath.AddLine(baZ.method_28(bBa), baz.method_28(bBc), baZ.method_28(bBB), baz.method_28(bBD));
				graphicsPath.AddLine(baZ.method_28(bBB), baz.method_28(bBD), num2, baz.method_28(bBD));
				graphicsPath.AddLine(num2, baz.method_28(bBD), num2, num4);
				graphicsPath.AddLine(num2, num4, num, num4);
				graphicsPath.AddLine(num, num4, num, baz.method_28(bBc));
				graphics.FillRegion(solidBrush, new Region(graphicsPath));
				graphicsPath.Dispose();
				if (!bBA)
				{
					graphicsPath = new GraphicsPath();
					graphicsPath.AddLine(num, baz.method_28(bBb), baZ.method_28(bBa), baz.method_28(bBb));
					graphicsPath.AddLine(baZ.method_28(bBa), baz.method_28(bBb), baZ.method_28(bBB), baz.method_28(bBC));
					graphicsPath.AddLine(baZ.method_28(bBB), baz.method_28(bBC), num2, baz.method_28(bBC));
					graphicsPath.AddLine(num2, baz.method_28(bBC), num2, num3);
					graphicsPath.AddLine(num2, num3, num, num3);
					graphicsPath.AddLine(num, num3, num, baz.method_28(bBb));
					graphics.FillRegion(solidBrush, new Region(graphicsPath));
					graphicsPath.Dispose();
				}
			}
			using (Pen pen = new Pen(Color.DarkGreen))
			{
				pen.Width = 2f;
				graphics.DrawLine(pen, num, baz.method_28(bBc), baZ.method_28(bBa), baz.method_28(bBc));
				graphics.DrawLine(pen, baZ.method_28(bBa), baz.method_28(bBc), baZ.method_28(bBB), baz.method_28(bBD));
				graphics.DrawLine(pen, baZ.method_28(bBB), baz.method_28(bBD), num2, baz.method_28(bBD));
				pen.Width = 1f;
				pen.Color = Color.FromArgb(120, Color.Black);
				graphics.DrawLine(pen, num2, baz.method_28(bBD), num2, num4);
				if (!bBA)
				{
					pen.Width = 2f;
					pen.Color = Color.DarkGreen;
					graphics.DrawLine(pen, num, baz.method_28(bBb), baZ.method_28(bBa), baz.method_28(bBb));
					graphics.DrawLine(pen, baZ.method_28(bBa), baz.method_28(bBb), baZ.method_28(bBB), baz.method_28(bBC));
					graphics.DrawLine(pen, baZ.method_28(bBB), baz.method_28(bBC), num2, baz.method_28(bBC));
					pen.Width = 1f;
					pen.Color = Color.FromArgb(120, Color.Black);
					graphics.DrawLine(pen, num2, baz.method_28(bBC), num2, num3);
				}
			}
			graphics.SmoothingMode = SmoothingMode.None;
			if (baz.method_18())
			{
				float[] array = baz.method_22();
				float[] array2 = baz.method_21();
				graphics.DrawLine(Pens.Black, num, num3, num, num4);
				using Pen pen2 = new Pen(Color.FromArgb(150, Color.Black));
				pen2.DashStyle = DashStyle.Dash;
				graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
				for (int i = 0; i < array2.Length; i++)
				{
					float num5 = array2[i];
					float num6 = array[i];
					SizeF sizeF = graphics.MeasureString(num5.ToString(Class333.BAp()), bBE);
					graphics.DrawString(num5.ToString(Class333.BAQ()), bBE, bBd, num - sizeF.Width - 2f, num6 - sizeF.Height / 2f);
					graphics.DrawLine(pen2, num, num6, num2, num6);
				}
			}
			if (baZ.method_18())
			{
				float[] array3 = baZ.method_21();
				float[] array4 = baZ.method_22();
				if (array4 != null && array4.Length != 0)
				{
					graphics.DrawLine(Pens.Black, baZ.method_10(), num4, baZ.method_12(), num4);
				}
				for (int j = 0; j < array3.Length; j++)
				{
					string text = array3[j].ToString();
					SizeF sizeF2 = graphics.MeasureString(text, bBE);
					graphics.DrawString(text, bBE, bBd, array4[j] - sizeF2.Width / 2f, num4 + 3f);
					graphics.DrawLine(Pens.Black, array4[j], num4, array4[j], num4 - 2f);
				}
			}
			graphics.DrawString(baY, bBe, bBd, num + (num2 - num) / 2f - graphics.MeasureString(baY, bBe).Width / 2f, ClientRectangle.Bottom - bBe.Height);
			smethod_0(graphics, bay, bBe, new PointF(0f, num3 + (num4 - num3) / 2f), bBd, -90f, ContentAlignment.TopCenter);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			using Pen pen3 = new Pen(Color.White);
			pen3.Width = 2f;
			graphics.DrawEllipse(pen3, baZ.method_28(bBa) - 3f, baz.method_28(bBc) - 3f, 6f, 6f);
			if (!bBA)
			{
				graphics.DrawEllipse(pen3, baZ.method_28(bBa) - 3f, baz.method_28(bBb) - 3f, 6f, 6f);
			}
			graphics.DrawEllipse(pen3, baZ.method_28(bBB) - 3f, baz.method_28(bBD) - 3f, 6f, 6f);
			if (!bBA)
			{
				graphics.DrawEllipse(pen3, baZ.method_28(bBB) - 3f, baz.method_28(bBC) - 3f, 6f, 6f);
			}
		}

		private static void smethod_0(Graphics graphics_0, string string_0, Font font_0, PointF pointF_0, Brush brush_0, float float_0, ContentAlignment contentAlignment_0)
		{
			Matrix transform = graphics_0.Transform;
			SizeF sizeF = graphics_0.MeasureString(string_0, font_0);
			PointF point = default;
			graphics_0.TranslateTransform(pointF_0.X, pointF_0.Y);
			graphics_0.RotateTransform(float_0, MatrixOrder.Prepend);
			switch (contentAlignment_0)
			{
			case ContentAlignment.TopCenter:
				point = new PointF((0f - sizeF.Width) / 2f, 0f);
				break;
			case ContentAlignment.TopRight:
				point = new PointF(0f - sizeF.Width, 0f);
				break;
			case ContentAlignment.MiddleLeft:
				point = new PointF(0f, (0f - sizeF.Height) / 2f);
				break;
			case ContentAlignment.MiddleCenter:
				point = new PointF((0f - sizeF.Width) / 2f, (0f - sizeF.Height) / 2f);
				break;
			case ContentAlignment.MiddleRight:
				point = new PointF(0f - sizeF.Width, (0f - sizeF.Height) / 2f);
				break;
			case ContentAlignment.BottomLeft:
				point = new PointF(0f, 0f - sizeF.Height);
				break;
			case ContentAlignment.BottomCenter:
				point = new PointF((0f - sizeF.Width) / 2f, 0f - sizeF.Height);
				break;
			case ContentAlignment.BottomRight:
				point = new PointF(0f - sizeF.Width, 0f - sizeF.Height);
				break;
			}
			graphics_0.DrawString(string_0, font_0, brush_0, point);
			graphics_0.Transform = transform;
			transform.Dispose();
		}
	}

	private Framework BWE;

	private Framework BWe;

	private OnOffSwitchingPoint BWF;

	private Rectangle BWf;

	private bool BWG;

	private bool BWg;

	private Class127 BWH;

	internal Class114(OnOffSwitchingPoint onOffSwitchingPoint_0, Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false)
	{
		BWE = framework_0;
		BWe = framework_1;
		BWF = onOffSwitchingPoint_0;
		BWH = new Class127(onOffSwitchingPoint_0);
		BWf = rectangle_0;
		Form23.form23_0.method_9(method_15);
		BWF.UpperBoundsEnablerSetting.method_264(method_16);
		BWF.Point1ColumnValueSetting.method_264(method_16);
		BWF.Point2ColumnValueSetting.method_264(method_16);
		BWF.Point1RowUpperBoundSetting.method_264(method_16);
		BWF.Point2RowUpperBoundSetting.method_264(method_16);
		BWF.Point1RowLowerBoundSetting.method_264(method_16);
		BWF.Point2RowLowerBoundSetting.method_264(method_16);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			Form23.form23_0.method_10(method_15);
			BWF.UpperBoundsEnablerSetting.method_265(method_16);
			BWF.Point1ColumnValueSetting.method_265(method_16);
			BWF.Point2ColumnValueSetting.method_265(method_16);
			BWF.Point1RowUpperBoundSetting.method_265(method_16);
			BWF.Point2RowUpperBoundSetting.method_265(method_16);
			BWF.Point1RowLowerBoundSetting.method_265(method_16);
			BWF.Point2RowLowerBoundSetting.method_265(method_16);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		bool flag = false;
		switch (Form23.enum60_0)
		{
		case Form23.Enum60.BpF:
			flag = BWG != BWg;
			break;
		case Form23.Enum60.Bpf:
			flag = false;
			break;
		case Form23.Enum60.BpG:
			flag = BWG != BWg;
			break;
		}
		if (flag)
		{
			while (method_12().Controls.Count != 0)
			{
				Class30.smethod_0(method_12().Controls[0]);
			}
			method_17();
		}
	}

	private void method_16(object sender, EventArgs e)
	{
		BWH.method_0();
	}

	internal void method_17()
	{
		SuspendLayout();
		method_12().SuspendLayout();
		int left = 5;
		int top = 5;
		BWG = BWE.method_2() && BWE.method_3() && BWE.method_31(BWF.UpperBoundsEnablerSetting.method_64()).method_96();
		BWg = BWe != null && BWe.method_2() && BWe.method_3() && BWe.method_31(BWF.UpperBoundsEnablerSetting.method_64()).method_96();
		if ((Form23.enum60_0 != Form23.Enum60.BpG || BWe == null) ? BWG : BWg)
		{
			Label label = new Label();
			label.Text = Class333.smethod_180() + BWF.method_60(Enum96.aYt) + Class333.BAO();
			label.ForeColor = Form23.color_12;
			label.BackColor = Color.Transparent;
			label.AutoSize = true;
			label.Left = 5;
			label.Top = 5;
			method_12().Controls.Add(label);
		}
		else
		{
			Control17 control = new Control17(BWF.UpperBoundsEnablerSetting.method_69(), BWE, BWe, null, bool_2: false, bool_3: true, bool_4: false);
			control.Left = left;
			control.Top = top;
			method_12().Controls.Add(control);
			top = control.Bottom + 8;
			Control21 control2 = new Control21(BWF.Point1ColumnValueSetting.method_69(), BWE, BWe, null, bool_2: false, bool_3: false, bool_4: false);
			control2.Left = left;
			control2.Top = top;
			method_12().Controls.Add(control2);
			left = control2.Right + 10;
			Control21 control3 = new Control21(BWF.Point2ColumnValueSetting.method_69(), BWE, BWe, null, bool_2: false, bool_3: false, bool_4: false);
			control3.Left = left;
			control3.Top = top;
			method_12().Controls.Add(control3);
			top = control3.Bottom + 8;
			left = 5;
			Control21 control4 = new Control21(BWF.Point1RowUpperBoundSetting.method_69(), BWE, BWe, null, bool_2: false, bool_3: false, bool_4: false);
			control4.Left = 5;
			control4.Top = top;
			method_12().Controls.Add(control4);
			left = control4.Right + 10;
			Control21 control5 = new Control21(BWF.Point2RowUpperBoundSetting.method_69(), BWE, BWe, null, bool_2: false, bool_3: false, bool_4: false);
			control5.Left = left;
			control5.Top = top;
			method_12().Controls.Add(control5);
			top = control5.Bottom + 8;
			left = 5;
			Control21 control6 = new Control21(BWF.Point1RowLowerBoundSetting.method_69(), BWE, BWe, null, bool_2: false, bool_3: false, bool_4: false);
			control6.Left = 5;
			control6.Top = top;
			method_12().Controls.Add(control6);
			left = control6.Right + 10;
			Control21 control7 = new Control21(BWF.Point2RowLowerBoundSetting.method_69(), BWE, BWe, null, bool_2: false, bool_3: false, bool_4: false);
			control7.Left = left;
			control7.Top = top;
			method_12().Controls.Add(control7);
			top = control7.Bottom + 8;
			left = 5;
			BWH.Left = 5;
			BWH.Top = top;
			method_12().Controls.Add(BWH);
			BWH.method_0();
		}
		if (BWf != Rectangle.Empty)
		{
			Width = BWf.Width;
			Height = BWf.Height;
			Left = BWf.Left;
			Top = BWf.Top;
		}
		else
		{
			int num = 0;
			int num2 = 0;
			foreach (Control control8 in method_12().Controls)
			{
				num = Math.Max(num, control8.Right + 10);
				num2 = Math.Max(num2, control8.Bottom + 10);
			}
			Width = num;
			Height = num2;
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
	}

	public Control imethod_0(DataIdAndAttrId dataIdAndAttrId_0)
	{
		foreach (Control control in method_12().Controls)
		{
			if ((control is Control21 && (control as Control21).method_0().method_69() == dataIdAndAttrId_0) || (control is Control17 && (control as Control17).method_0().method_69() == dataIdAndAttrId_0))
			{
				return control;
			}
		}
		return null;
	}

	public Control imethod_1()
	{
		foreach (Control control in method_12().Controls)
		{
			if (control is Control21 || control is Control17)
			{
				return control;
			}
		}
		return null;
	}
}
