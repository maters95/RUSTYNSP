using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal class Class87 : MovableResizablePanel
{
	private const int BHp = 45;

	private const int BHQ = 357;

	private const int BHq = 20;

	private const int BHR = 266;

	private const int BHr = 312;

	private const int BHS = 246;

	private int BHs = 10;

	private int BHT = 2;

	private string BHt = Class333.BAo();

	private string BHU = Class333.smethod_681();

	private string BHu = Class333.BAP();

	private string BHV = Class333.smethod_681();

	private Framework BHv;

	private Framework BHW;

	private Setting BHw;

	private Setting BHX;

	private Setting BHx;

	private Setting BHY;

	private PointF BHy = new PointF(0f, 0f);

	private PointF BHZ = new PointF(100f, 100f);

	private PointF BHz = new PointF(0f, 0f);

	private PointF BhA = new PointF(100f, 100f);

	private PointF Bha = new PointF(0f, 0f);

	private PointF BhB = new PointF(100f, 100f);

	private Matrix Bhb = new Matrix();

	private Matrix BhC = new Matrix();

	private Matrix Bhc = new Matrix();

	private Matrix BhD = new Matrix();

	private int Bhd = -1;

	private bool BhE;

	private bool Bhe;

	internal Class87(BezierCurve bezierCurve_0, Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		BHv = framework_0;
		BHW = framework_1;
		DoubleBuffered = true;
		BHw = bezierCurve_0.method_1()[0] as Setting;
		BHX = bezierCurve_0.method_1()[1] as Setting;
		BHw.method_264(method_26);
		BHX.method_264(method_27);
		if (BHW != null)
		{
			BHx = BHW.method_31(BHw.method_64());
			BHY = BHW.method_31(BHX.method_64());
		}
		method_18(new PointF(BHw.method_258(0) / 10, BHX.method_258(0) / 10));
		method_20(new PointF(BHw.method_258(1) / 10, BHX.method_258(1) / 10));
		if (BHx != null && BHY != null)
		{
			method_22(new PointF(BHx.method_258(0) / 10, BHY.method_258(0) / 10));
			method_24(new PointF(BHx.method_258(1) / 10, BHY.method_258(1) / 10));
		}
		method_12();
		Form23.form23_0.method_9(method_25);
		BhE = BHv.method_2() && BHv.method_3() && (BHw.method_96() || BHX.method_96());
		Bhe = BHW != null && BHW.method_2() && BHW.method_3() && (BHx.method_96() || BHY.method_96());
		if (rectangle_0 != Rectangle.Empty)
		{
			Width = rectangle_0.Width;
			Height = rectangle_0.Height;
			Left = rectangle_0.Left;
			Top = rectangle_0.Top;
		}
		else
		{
			Width = 377;
			Height = 306;
		}
	}

	private void method_12()
	{
		SizeF sizeF = new SizeF(312f / (BHZ.X - BHy.X), -246f / (BHZ.Y - BHy.Y));
		SizeF sizeF2 = new SizeF(45f, 266f);
		Bhb = new Matrix();
		Bhb.Translate(sizeF2.Width, sizeF2.Height);
		Bhb.Scale(sizeF.Width, sizeF.Height);
		BhC = Bhb.Clone();
		BhC.Invert();
		Bhc = new Matrix();
		Bhc.Translate(sizeF2.Width, sizeF2.Height);
		Bhc.Scale(sizeF.Width, sizeF.Height);
		BhD = Bhc.Clone();
		BhD.Invert();
	}

	[SpecialName]
	internal PointF method_13()
	{
		return BHy;
	}

	[SpecialName]
	internal void method_14(PointF pointF_0)
	{
		if (BHy != pointF_0)
		{
			BHy = pointF_0;
			method_12();
			Invalidate();
		}
	}

	[SpecialName]
	internal PointF method_15()
	{
		return BHZ;
	}

	[SpecialName]
	internal void method_16(PointF pointF_0)
	{
		if (BHZ != pointF_0)
		{
			BHZ = pointF_0;
			method_12();
			Invalidate();
		}
	}

	[SpecialName]
	internal PointF method_17()
	{
		return BHz;
	}

	[SpecialName]
	internal void method_18(PointF pointF_0)
	{
		if (BHz != pointF_0)
		{
			BHz = pointF_0;
			if (BHz.X < BHy.X)
			{
				BHz.X = BHy.X;
			}
			if (BHz.Y < BHy.Y)
			{
				BHz.Y = BHy.Y;
			}
			if (BHz.X > BHZ.X)
			{
				BHz.X = BHZ.X;
			}
			if (BHz.Y > BHZ.Y)
			{
				BHz.Y = BHZ.Y;
			}
			Invalidate();
		}
	}

	[SpecialName]
	internal PointF method_19()
	{
		return BhA;
	}

	[SpecialName]
	internal void method_20(PointF pointF_0)
	{
		if (BhA != pointF_0)
		{
			BhA = pointF_0;
			if (BhA.X < BHy.X)
			{
				BhA.X = BHy.X;
			}
			if (BhA.Y < BHy.Y)
			{
				BhA.Y = BHy.Y;
			}
			if (BhA.X > BHZ.X)
			{
				BhA.X = BHZ.X;
			}
			if (BhA.Y > BHZ.Y)
			{
				BhA.Y = BHZ.Y;
			}
			Invalidate();
		}
	}

	[SpecialName]
	private PointF method_21()
	{
		return Bha;
	}

	[SpecialName]
	private void method_22(PointF pointF_0)
	{
		if (Bha != pointF_0)
		{
			Bha = pointF_0;
			if (Bha.X < BHy.X)
			{
				Bha.X = BHy.X;
			}
			if (Bha.Y < BHy.Y)
			{
				Bha.Y = BHy.Y;
			}
			if (Bha.X > BHZ.X)
			{
				Bha.X = BHZ.X;
			}
			if (Bha.Y > BHZ.Y)
			{
				Bha.Y = BHZ.Y;
			}
			Invalidate();
		}
	}

	[SpecialName]
	private PointF method_23()
	{
		return BhB;
	}

	[SpecialName]
	private void method_24(PointF pointF_0)
	{
		if (BhB != pointF_0)
		{
			BhB = pointF_0;
			if (BhB.X < BHy.X)
			{
				BhB.X = BHy.X;
			}
			if (BhB.Y < BHy.Y)
			{
				BhB.Y = BHy.Y;
			}
			if (BhB.X > BHZ.X)
			{
				BhB.X = BHZ.X;
			}
			if (BhB.Y > BHZ.Y)
			{
				BhB.Y = BHZ.Y;
			}
			Invalidate();
		}
	}

	protected override void MouseDownHandler(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && (e.X < 35 || e.X > 367 || e.Y < 10 || e.Y > 276))
		{
			base.MouseDownHandler(sender, e);
		}
	}

	protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		base.OnMouseDown(mouseEventArgs_0);
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BHv.method_4())
		{
			return;
		}
		if (!BhE)
		{
			PointF[] array = new PointF[2] { BHz, BhA };
			Bhb.TransformPoints(array);
			float num = (float)BHs / 2f;
			for (int i = 0; i < array.Length; i++)
			{
				if ((float)mouseEventArgs_0.X >= array[i].X - num && (float)mouseEventArgs_0.X <= array[i].X + num && (float)mouseEventArgs_0.Y >= array[i].Y - num && !((float)mouseEventArgs_0.Y > array[i].Y + num))
				{
					Bhd = i;
					return;
				}
			}
		}
		Bhd = -1;
	}

	protected override void OnMouseMove(MouseEventArgs mevent)
	{
		base.OnMouseMove(mevent);
		if (Form23.enum60_0 != Form23.Enum60.BpG && BHv.method_4() && !BhE && Bhd != -1)
		{
			Point[] array = new Point[1] { mevent.Location };
			BhC.TransformPoints(array);
			switch (Bhd)
			{
			case 1:
				method_20(array[0]);
				break;
			case 0:
				method_18(array[0]);
				break;
			}
			Invalidate();
		}
	}

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		base.OnMouseUp(mevent);
		if (Form23.enum60_0 == Form23.Enum60.BpG || !BHv.method_4())
		{
			return;
		}
		if (!BhE)
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_2(BHw.method_64());
			if (Bhd == 0)
			{
				BHw.method_274(0, (int)(method_17().X * 10f), bool_0: true);
				BHX.method_274(0, (int)(method_17().Y * 10f), bool_0: true);
			}
			else if (Bhd == 1)
			{
				BHw.method_274(1, (int)(method_19().X * 10f), bool_0: true);
				BHX.method_274(1, (int)(method_19().Y * 10f), bool_0: true);
			}
			@class?.method_4();
		}
		Bhd = -1;
	}

	protected override void OnResize(EventArgs eventargs)
	{
		method_12();
		base.OnResize(eventargs);
	}

	protected override void OnPaddingChanged(EventArgs eventArgs_0)
	{
		method_12();
		Invalidate();
		base.OnPaddingChanged(eventArgs_0);
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		if ((Form23.enum60_0 != Form23.Enum60.BpG || BHW == null) ? BhE : Bhe)
		{
			using (SolidBrush brush = new SolidBrush(Form23.color_12))
			{
				using Font font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
				paintEventArgs_0.Graphics.DrawString(Class333.smethod_180() + BHw.method_6().method_60(Enum96.aYt) + Class333.BAO(), font, brush, 10f, 10f);
				return;
			}
		}
		PointF[] array = new PointF[4] { BHy, BHz, BhA, BHZ };
		Bhb.TransformPoints(array);
		PointF[] array2 = new PointF[4] { BHy, Bha, BhB, BHZ };
		Bhc.TransformPoints(array2);
		using SolidBrush brush2 = new SolidBrush(Form23.color_12);
		using Pen pen = new Pen(Color.Gray, 1f);
		using Pen pen2 = new Pen(Form23.color_12);
		using Pen pen3 = new Pen(Form23.color_12, BHT);
		using Brush brush3 = new SolidBrush(Form23.color_12);
		using Pen pen4 = new Pen(Form23.color_12);
		using Pen pen5 = new Pen(Color.FromArgb(100, Color.Gray), BHT);
		using Font font2 = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
		paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.None;
		pen.DashStyle = DashStyle.Dash;
		paintEventArgs_0.Graphics.DrawLine(pen2, 45, 266, 357, 266);
		PointF pointF = new PointF(0f, 266f);
		paintEventArgs_0.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		SizeF sizeF;
		for (int i = 0; i < 11; i++)
		{
			float num = i * 10;
			pointF.X = 45f + 31.2f * (float)i;
			sizeF = paintEventArgs_0.Graphics.MeasureString(num.ToString(Class333.BAp()), Font);
			paintEventArgs_0.Graphics.DrawString(num.ToString(Class333.BAQ()), Font, brush2, pointF.X - sizeF.Width / 2f, 268f);
			paintEventArgs_0.Graphics.DrawLine(pen2, pointF.X, pointF.Y, pointF.X, pointF.Y - 4f);
			paintEventArgs_0.Graphics.DrawLine(pen, pointF.X, pointF.Y, pointF.X, 20f);
		}
		sizeF = paintEventArgs_0.Graphics.MeasureString(string.Format(Class333.BAq(), BHt, BHU), font2);
		paintEventArgs_0.Graphics.DrawString(string.Format(Class333.BAq(), BHt, BHU), font2, brush2, 201f - sizeF.Width / 2f, 286f);
		paintEventArgs_0.Graphics.DrawLine(pen2, 45, 266, 45, 20);
		pointF = new PointF(45f, 0f);
		paintEventArgs_0.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		for (int j = 0; j < 11; j++)
		{
			float num2 = 100 - j * 10;
			pointF.Y = 20f + 24.6f * (float)j;
			sizeF = paintEventArgs_0.Graphics.MeasureString(num2.ToString(Class333.BAp()), Font);
			paintEventArgs_0.Graphics.DrawString(num2.ToString(Class333.BAQ()), Font, brush2, 45f - sizeF.Width - 2f, pointF.Y - sizeF.Height / 2f);
			paintEventArgs_0.Graphics.DrawLine(pen2, pointF.X, pointF.Y, pointF.X + 4f, pointF.Y);
			paintEventArgs_0.Graphics.DrawLine(pen, pointF.X, pointF.Y, 357f, pointF.Y);
		}
		sizeF = paintEventArgs_0.Graphics.MeasureString(string.Format(Class333.BAq(), BHu, BHV), font2);
		paintEventArgs_0.Graphics.TranslateTransform(25f - sizeF.Height, 143f + sizeF.Width / 2f);
		paintEventArgs_0.Graphics.RotateTransform(-90f);
		paintEventArgs_0.Graphics.DrawString(string.Format(Class333.BAq(), BHu, BHV), font2, brush2, 0f, 0f);
		paintEventArgs_0.Graphics.ResetTransform();
		paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		pen5.DashStyle = DashStyle.Dash;
		paintEventArgs_0.Graphics.DrawLine(pen5, array[0], array[3]);
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			if (!BhE)
			{
				using Pen pen6 = new Pen(Form23.color_9, BHT);
				paintEventArgs_0.Graphics.DrawBezier(pen6, array[0], array[1], array[2], array[3]);
			}
		}
		else
		{
			paintEventArgs_0.Graphics.DrawBezier(pen3, array[0], array[1], array[2], array[3]);
		}
		if (BHx != null && BHY != null)
		{
			if (Form23.enum60_0 == Form23.Enum60.BpG)
			{
				paintEventArgs_0.Graphics.DrawBezier(pen3, array2[0], array2[1], array2[2], array2[3]);
			}
			else if (!Bhe)
			{
				using Pen pen7 = new Pen(Form23.color_9, BHT);
				paintEventArgs_0.Graphics.DrawBezier(pen7, array2[0], array2[1], array2[2], array2[3]);
			}
		}
		pen4.DashStyle = DashStyle.Dash;
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			paintEventArgs_0.Graphics.DrawLine(pen4, array[1], array[0]);
			paintEventArgs_0.Graphics.DrawLine(pen4, array[2], array[3]);
		}
		RectangleF rect = new RectangleF(array[1].X - (float)BHs / 2f, array[1].Y - (float)BHs / 2f, BHs, BHs);
		RectangleF rect2 = new RectangleF(array[2].X - (float)BHs / 2f, array[2].Y - (float)BHs / 2f, BHs, BHs);
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			if (!BhE)
			{
				using Brush brush4 = new SolidBrush(Form23.color_9);
				paintEventArgs_0.Graphics.FillEllipse(brush4, rect);
				paintEventArgs_0.Graphics.FillEllipse(brush4, rect2);
			}
		}
		else
		{
			paintEventArgs_0.Graphics.FillEllipse(brush3, rect);
			paintEventArgs_0.Graphics.FillEllipse(brush3, rect2);
		}
		if (BHx == null || BHY == null)
		{
			return;
		}
		RectangleF rect3 = new RectangleF(array2[1].X - (float)BHs / 2f, array2[1].Y - (float)BHs / 2f, BHs, BHs);
		RectangleF rect4 = new RectangleF(array2[2].X - (float)BHs / 2f, array2[2].Y - (float)BHs / 2f, BHs, BHs);
		if (Form23.enum60_0 == Form23.Enum60.BpG)
		{
			paintEventArgs_0.Graphics.FillEllipse(brush3, rect3);
			paintEventArgs_0.Graphics.FillEllipse(brush3, rect4);
		}
		else if (!Bhe)
		{
			using (Brush brush5 = new SolidBrush(Form23.color_9))
			{
				paintEventArgs_0.Graphics.FillEllipse(brush5, rect3);
				paintEventArgs_0.Graphics.FillEllipse(brush5, rect4);
				return;
			}
		}
	}

	private void method_25(object sender, EventArgs e)
	{
		Invalidate();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			BHw.method_265(method_26);
			BHX.method_265(method_27);
			Form23.form23_0.method_10(method_25);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void method_26(object sender, EventArgs e)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			Invalidate();
		}
	}

	private void method_27(object sender, EventArgs e)
	{
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			method_12();
			method_18(new PointF(BHw.method_258(0) / 10, BHX.method_258(0) / 10));
			method_20(new PointF(BHw.method_258(1) / 10, BHX.method_258(1) / 10));
			Invalidate();
		}
	}
}
