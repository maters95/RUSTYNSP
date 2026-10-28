using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal abstract class Class101 : MovableResizablePanel
{
	protected struct Struct11
	{
		internal bool Bvv;

		internal int BvW;

		internal int Bvw;

		internal int[] BvX;
	}

	protected class Control1 : Control
	{
		internal class Class66
		{
			internal string bat;

			internal Color baU;
		}

		internal List<Class66> Bvx = new List<Class66>();

		private const int BvY = 14;

		private const int Bvy = 100;

		private const int BvZ = 54;

		private const int Bvz = 50;

		private Class101 BWA;

		private int BWa;

		internal int BWB = 10;

		internal int BWb;

		internal PictureBox BWC = new PictureBox();

		private int BWc;

		private bool BWD;

		internal Control1(Class101 class101_0)
		{
			AutoSize = false;
			Height = 44;
			BWA = class101_0;
			SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, value: true);
			SetStyle(ControlStyles.UserPaint, value: true);
			BWC.Size = new Size(32, 32);
			BWC.Image = GeneralResources.YellowWarning;
			BWC.Left = 100;
			BWC.Top = Height - 35;
			BWC.Visible = false;
			Controls.Add(BWC);
			BWC.Visible = false;
			BWC.DoubleClick += BWA.vmethod_3;
		}

		protected override void Dispose(bool disposing)
		{
			try
			{
				BWC.DoubleClick -= BWA.vmethod_3;
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		private void method_0(Graphics graphics_0)
		{
			Pen pen = ((Form23.enum62_0 == Form23.Enum62.BqG || Form23.enum62_0 == Form23.Enum62.Bqh) ? new Pen(Color.Gray, 4f) : new Pen(Color.White, 4f));
			graphics_0.DrawLine(pen, 154, 7, Width - 50, 7);
			pen.Dispose();
		}

		private void method_1(Graphics graphics_0)
		{
			Pen pen = ((Form23.enum62_0 == Form23.Enum62.BqG || Form23.enum62_0 == Form23.Enum62.Bqh) ? Pens.Gray : Pens.White);
			for (int i = 0; i <= BWB; i++)
			{
				int num = 154 + i * (Width - 205) / BWB;
				graphics_0.DrawLine(pen, num, 9, num, 15);
				if (Bvx.Count != BWB + 1)
				{
					continue;
				}
				using StringFormat stringFormat = new StringFormat();
				using SolidBrush brush = new SolidBrush(Bvx[i].baU);
				using Font font = new Font(Font.FontFamily, 9f);
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				graphics_0.DrawString(Bvx[i].bat, font, brush, num, 34f, stringFormat);
			}
		}

		private void method_2(Graphics graphics_0)
		{
			graphics_0.FillEllipse(Brushes.DodgerBlue, 154 + BWb * (Width - 205) / BWB - 7, 0, 14, 14);
		}

		private void method_3(Graphics graphics_0)
		{
			AxisBehaviour axisBehaviour = BWA.BKE.SliceAxis.method_93();
			int num = BWA.BKE.SliceCount();
			int num2 = BWA.BKg.method_256();
			int num3 = BWA.BKE.SliceAxis.method_89().method_258(0);
			int num4 = BWA.BKE.SliceAxis.method_89().method_258(num - 1);
			float num5 = ((num <= 1) ? ((float)(Width - 205)) : ((float)(Width - 205) / (float)(num - 1)));
			int num6 = 0;
			if (num2 >= num4)
			{
				num6 = Width - 51;
			}
			else if (num2 <= num3)
			{
				num6 = 154;
			}
			else
			{
				switch (axisBehaviour)
				{
				case AxisBehaviour.DiscreteCentred:
				{
					for (int i = 1; i < num; i++)
					{
						int num13 = BWA.BKE.SliceAxis.method_89().method_258(i - 1);
						int num14 = BWA.BKE.SliceAxis.method_89().method_258(i);
						int num15 = num13 + num14 >> 1;
						if (num2 == num13 || num2 < num15 || i == num - 1)
						{
							int num16 = ((num2 == num13 || num2 < num15) ? (i - 1) : i);
							int num17 = (int)Math.Round((float)num16 * num5);
							num6 = 154 + num17;
							break;
						}
					}
					break;
				}
				case AxisBehaviour.Continuous:
				{
					int num7 = 0;
					int num8 = num - 1;
					while (num8 >= 0)
					{
						int num9 = BWA.BKE.SliceAxis.method_89().method_258(num8);
						if (num2 <= num9)
						{
							num8--;
							continue;
						}
						num7 = num8;
						break;
					}
					if (num7 == num - 1)
					{
						num7--;
					}
					int num10 = BWA.BKE.SliceAxis.method_89().method_258(num7);
					int num11 = BWA.BKE.SliceAxis.method_89().method_258(num7 + 1);
					int num12 = (int)Math.Round((float)num7 * num5);
					num6 = ((num11 == num10) ? 154 : (154 + num12 + (num2 - num10) * (int)Math.Round(num5) / (num11 - num10)));
					break;
				}
				}
			}
			graphics_0.FillPolygon(points: new Point[3]
			{
				new Point(num6, 17),
				new Point(num6 - 6, 25),
				new Point(num6 + 5, 25)
			}, brush: Brushes.DodgerBlue);
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			if (BWB == 0)
			{
				return;
			}
			Graphics graphics = paintEventArgs_0.Graphics;
			method_0(graphics);
			method_1(graphics);
			method_4(graphics);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			method_2(graphics);
			if (Form23.enum60_0 != Form23.Enum60.BpG && ((Form23.smethod_28(BWA.BKE.method_0().aXc, bool_53: true) && !Form23.smethod_80()) || (BWA.BKg != null && Form23.smethod_84(BWA.BKg.method_64()))))
			{
				method_3(graphics);
			}
			if (BWb != BWa)
			{
				int userSliceIndex = 0;
				Table table = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BWA.BKE : BWA.BKe);
				if (table != null && table.SlicesEnabled())
				{
					userSliceIndex = BWb;
				}
				BWA.BKE.UserSliceIndex = userSliceIndex;
				if (BWA.BKe != null)
				{
					BWA.BKe.UserSliceIndex = userSliceIndex;
				}
				BWa = BWb;
			}
		}

		protected override void OnMouseWheel(MouseEventArgs mouseEventArgs_0)
		{
			base.OnMouseWheel(mouseEventArgs_0);
			if (SystemInformation.MouseWheelScrollLines == 0)
			{
				return;
			}
			BWc += mouseEventArgs_0.Delta;
			int num = (int)((float)BWc / 120f);
			if (num != 0)
			{
				if (num > 0)
				{
					int num2 = num;
					BWb = Math.Min(num2 + BWb, BWB);
					BWc -= (int)((float)num * 120f);
				}
				else
				{
					int num2 = -num;
					BWb = Math.Max(BWb - num2, 0);
					BWc -= (int)((float)num * 120f);
				}
			}
		}

		protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
		{
			if (mouseEventArgs_0.X <= 134 || BWB == 0)
			{
				return;
			}
			BWD = true;
			int num = (Width - 205) / BWB / 2;
			int num2 = 0;
			while (true)
			{
				if (num2 <= BWB)
				{
					int num3 = 154 + num2 * (Width - 205) / BWB;
					if (mouseEventArgs_0.X > num3 - num && mouseEventArgs_0.X < num3 + num)
					{
						break;
					}
					num2++;
					continue;
				}
				return;
			}
			if (BWb != num2)
			{
				BWb = num2;
				Invalidate();
			}
		}

		protected override void OnMouseMove(MouseEventArgs mevent)
		{
			if (!BWD)
			{
				return;
			}
			int num = (Width - 205) / BWB / 2;
			int num2 = 0;
			while (true)
			{
				if (num2 <= BWB)
				{
					int num3 = 154 + num2 * (Width - 205) / BWB;
					if (mevent.X > num3 - num && mevent.X < num3 + num)
					{
						break;
					}
					num2++;
					continue;
				}
				return;
			}
			if (BWb != num2)
			{
				BWb = num2;
				Invalidate();
			}
		}

		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			BWD = false;
		}

		private void method_4(Graphics graphics_0)
		{
			using SolidBrush brush = new SolidBrush(Form23.color_12);
			using Font font = new Font(Font.FontFamily, 10f);
			bool flag = true;
			Setting setting;
			if (!(BWA is Class104))
			{
				setting = ((Form23.enum60_0 != Form23.Enum60.BpG) ? BWA.BKg : BWA.BKI);
			}
			else
			{
				Table table;
				if (Form23.enum60_0 == Form23.Enum60.BpG)
				{
					table = BWA.BKe;
					setting = BWA.BKI;
				}
				else
				{
					table = BWA.BKE;
					setting = BWA.BKg;
				}
				flag = table.SlicesEnabled();
				if (BWA.BKe != null)
				{
					if (table == BWA.BKE)
					{
						flag = BWA.BKe.SlicesEnabled();
					}
					else if (table == BWA.BKe)
					{
						flag = BWA.BKE.SlicesEnabled();
					}
				}
			}
			string text = string.Empty;
			int num = setting.method_231();
			if (num != 0 && num != 82)
			{
				text = Class333.smethod_497() + Class233.smethod_35(setting.method_232(), num, bool_0: false, 0) + Class333.smethod_9();
			}
			bool flag2 = true;
			bool flag3 = true;
			Font font2;
			if (BWA is Class104)
			{
				flag2 = flag && (BWA.BKe == null || (BWA.BKI != null && BWA.BKI.method_64() == BWA.BKg.method_64()));
				if (BWA.BKk != null && BWA.BKK.method_88())
				{
					flag3 = BWA.BKM[0].Bvv && ((BWA.BKg.method_64() == BWA.BKM[0].BvW) ? true : false);
				}
				font2 = (flag3 ? font : new Font(font, FontStyle.Italic));
			}
			else
			{
				font2 = font;
			}
			string text2 = setting.method_18();
			string text3 = (string.IsNullOrWhiteSpace(text2) ? setting.method_60(Enum96.aYT) : text2);
			text3 += text;
			int num2 = (int)graphics_0.MeasureString(text3, font2, 100).Height;
			Rectangle rectangle = new Rectangle(0, 0, 100, num2);
			bool flag4 = false;
			if (BWA is Class104)
			{
				if (num2 > Height)
				{
					FontStyle style = font2.Style;
					if (!flag3)
					{
						font2.Dispose();
					}
					font2 = new Font(Font.FontFamily, 8f, style);
					flag4 = true;
				}
				if (!flag2 && !BWA.BKi && !BWA.BKJ)
				{
					using SolidBrush brush2 = new SolidBrush(Form23.color_9);
					graphics_0.DrawString(text3, font2, brush2, rectangle);
				}
				else
				{
					graphics_0.DrawString(text3, font2, brush, rectangle);
				}
				if (flag4 || !flag3)
				{
					font2.Dispose();
				}
			}
			else
			{
				if (num2 > Height)
				{
					FontStyle style2 = font2.Style;
					font2 = new Font(Font.FontFamily, 8f, style2);
					flag4 = true;
				}
				graphics_0.DrawString(text3, font2, brush, rectangle);
				if (flag4)
				{
					font2.Dispose();
				}
			}
		}

		protected override void OnGotFocus(EventArgs eventArgs_0)
		{
			if (BWA is Class104)
			{
				(BWA as Class104).method_13();
			}
			else
			{
				BWA.Focus();
			}
		}
	}

	protected Framework BKD;

	protected Framework BKd;

	protected Table BKE;

	protected Table BKe;

	protected int BKF = -1;

	protected Setting BKf;

	protected Setting BKG;

	protected Setting BKg;

	protected Setting BKH;

	protected Setting BKh;

	protected Setting BKI;

	protected bool BKi;

	protected bool BKJ;

	protected Control1 BKj;

	protected MenuNode BKK;

	protected Class286 BKk;

	protected string BKL;

	protected double[,,] BKl;

	protected Struct11[] BKM;

	public Class101(Framework framework_0, Framework framework_1, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		BKD = framework_0;
		BKd = framework_1;
		BKj = new Control1(this);
		_ = BKj.Handle;
		Form23.form23_0.method_9(vmethod_0);
	}

	protected virtual void vmethod_0(object sender, EventArgs e)
	{
		if (BKE != null)
		{
			vmethod_1();
			Controls.Clear();
			vmethod_2(BKE.method_64());
			Invalidate();
		}
	}

	protected abstract void vmethod_1();

	internal abstract void vmethod_2(int int_3);

	internal abstract void vmethod_3(object sender, EventArgs e);
}
