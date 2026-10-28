using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns1;
using ns4;
using ns7;

namespace ns0;

internal class Class79 : Panel
{
	private Framework framework_0;

	private KnockDetection knockDetection_0;

	private Setting setting_0;

	private List<Setting> list_0 = new List<Setting>();

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	internal Class79(KnockDetection knockDetection_1, Framework framework_1)
	{
		framework_0 = framework_1;
		knockDetection_0 = knockDetection_1;
		if (knockDetection_0 != null)
		{
			setting_0 = framework_0.method_31(knockDetection_0.DataIdOfCentreFrequencySetting);
			setting_0.method_264(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			for (int i = 0; i < knockDetection_0.DataIdsOfFFTChannels.Count; i++)
			{
				Setting setting = framework_0.method_31(knockDetection_0.DataIdsOfFFTChannels[i]);
				list_0.Add(setting);
				setting.method_264(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			knockDetection_0.OnNewFFTResult += knockDetection_0_OnDisplayedMagnitudeRangeChanged;
			knockDetection_0.OnDisplayedFrequencyRangeChanged += knockDetection_0_OnDisplayedMagnitudeRangeChanged;
			knockDetection_0.OnDisplayedMagnitudeRangeChanged += knockDetection_0_OnDisplayedMagnitudeRangeChanged;
		}
		Class1.smethod_10(method_0);
		Class1.smethod_12(method_0);
		Form23.smethod_30(method_0);
		DoubleBuffered = true;
		SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
		SetStyle(ControlStyles.OptimizedDoubleBuffer, value: true);
		SetStyle(ControlStyles.UserPaint, value: true);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (setting_0 != null)
			{
				setting_0.method_265(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			foreach (Setting item in list_0)
			{
				item.method_265(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			if (knockDetection_0 != null)
			{
				knockDetection_0.OnNewFFTResult -= knockDetection_0_OnDisplayedMagnitudeRangeChanged;
				knockDetection_0.OnDisplayedFrequencyRangeChanged -= knockDetection_0_OnDisplayedMagnitudeRangeChanged;
				knockDetection_0.OnDisplayedMagnitudeRangeChanged -= knockDetection_0_OnDisplayedMagnitudeRangeChanged;
			}
			Class1.smethod_11(method_0);
			Class1.smethod_13(method_0);
			Form23.smethod_31(method_0);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void knockDetection_0_OnDisplayedMagnitudeRangeChanged(object sender, EventArgs e)
	{
		Invalidate();
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		Graphics graphics = paintEventArgs_0.Graphics;
		graphics.Clear(Color.Black);
		if (knockDetection_0 == null)
		{
			return;
		}
		int num = 0;
		if (list_0.Count != 0)
		{
			num = list_0[0].method_242()[2];
		}
		else if (knockDetection_0.FFTMagnitudesForSensorsXFrequencies != null)
		{
			num = knockDetection_0.FFTMagnitudesForSensorsXFrequencies.GetLength(1);
		}
		int num2 = setting_0.method_256();
		int num3 = ((list_0.Count == 0) ? 20000 : (num2 * 2));
		if (num != 0 && num3 != 0)
		{
			int num4 = Math.Min(knockDetection_0.MinDisplayFrequencyHz * num / num3, num - 2);
			int num5 = Math.Max(knockDetection_0.MaxDisplayFrequencyHz * num / num3 - num4, 2);
			string text = Class333.smethod_475();
			float height = graphics.MeasureString(text, Font).Height;
			graphics.DrawString(text, Font, Brushes.White, 3f, 3f);
			int num6 = Width - 47;
			float num7 = (float)Height - 30f;
			float num8 = 3f + height;
			float num9 = num7 - num8;
			graphics.DrawLine(Pens.Gray, 0f, num7, num6, num7);
			graphics.DrawLine(Pens.Gray, num6, num7, num6, 0f);
			float num10 = (float)num6 / (float)num5;
			if (Form23.smethod_28(framework_0.aXc, bool_53: true) && !Form23.smethod_80())
			{
				Setting knockSensorEnabler = knockDetection_0.GetKnockSensorEnabler(0);
				bool flag = knockSensorEnabler != null && knockSensorEnabler.method_256() != 0;
				Setting knockSensorEnabler2 = knockDetection_0.GetKnockSensorEnabler(1);
				bool flag2 = knockSensorEnabler2 != null && knockSensorEnabler2.method_256() != 0;
				int num11 = 0;
				int num12 = int.MinValue;
				float num13 = 0f;
				for (int i = num4; i <= num4 + num5; i++)
				{
					int num14 = num6 * (i - num4) / num5;
					if (num14 != num11)
					{
						if ((num4 != 0 || i - 1 != num4) && num12 >= knockDetection_0.MinDisplayMagnitude)
						{
							Color colourForMagnitude = knockDetection_0.GetColourForMagnitude(num12);
							int num15 = Math.Max(Math.Min(num12, knockDetection_0.MaxDisplayMagnitude), knockDetection_0.MinDisplayMagnitude);
							float num16 = num9 * ((float)(num15 - knockDetection_0.MinDisplayMagnitude) / (float)(knockDetection_0.MaxDisplayMagnitude - knockDetection_0.MinDisplayMagnitude));
							float y = (float)Height - (30f + num16);
							PointF location;
							SizeF size;
							if (num6 <= num5 * 4)
							{
								location = new PointF(num11, y);
								size = new SizeF(Math.Max(num10, 1f), num16);
							}
							else
							{
								location = new PointF((float)num11 + num10 / 16f, y);
								size = new SizeF(Math.Max(num10 * 7f / 8f, 1f), num16);
							}
							using SolidBrush brush = new SolidBrush(colourForMagnitude);
							graphics.FillRectangle(brush, new RectangleF(location, size));
						}
						if (num6 > num5 * 4)
						{
							float num17 = num14;
							if (num17 - 25f > num13)
							{
								graphics.DrawLine(Pens.Gray, num17, num7, num17, num7 + 3f);
								float num18 = (float)(i * num3) / (1000f * (float)num);
								string text2 = string.Format(Class333.smethod_471(), num18);
								SizeF sizeF = graphics.MeasureString(text2, Font);
								graphics.DrawString(text2, Font, Brushes.White, num17 - sizeF.Width / 2f, num7 + 4f);
								num13 = num17 + sizeF.Width / 2f;
							}
						}
						num11 = num14;
						num12 = int.MinValue;
						if (i == num4 + num5)
						{
							break;
						}
					}
					else if (i == num4 && num6 > num5 * 4)
					{
						float num19 = 0f;
						graphics.DrawLine(Pens.Gray, num19, num7, num19, num7 + 3f);
						float num20 = (float)(i * num3) / (1000f * (float)num);
						string text3 = string.Format(Class333.smethod_471(), num20);
						SizeF sizeF2 = graphics.MeasureString(text3, Font);
						graphics.DrawString(text3, Font, Brushes.White, num19 - sizeF2.Width / 2f, num7 + 4f);
						num13 = num19 + sizeF2.Width / 2f;
					}
					int num21 = 0;
					if (list_0.Count != 0)
					{
						if (flag)
						{
							num21 = list_0[0].method_258(i);
						}
						if (flag2)
						{
							num21 = Math.Max(num21, list_0[1].method_258(i));
						}
					}
					else
					{
						if (flag)
						{
							num21 = knockDetection_0.FFTMagnitudesForSensorsXFrequencies[0, i];
						}
						if (flag2)
						{
							num21 = Math.Max(num21, knockDetection_0.FFTMagnitudesForSensorsXFrequencies[1, i]);
						}
						num21 = KnockDetection.ConvertAudioSampleValueToDecibels(num21);
					}
					num12 = Math.Max(num21, num12);
				}
			}
			if (num6 <= num5 * 4)
			{
				int num22 = knockDetection_0.MinDisplayFrequencyHz % 1000;
				int num23 = 0;
				if (num22 != 0)
				{
					num23 = 1000 - num22;
				}
				float num24 = 0f;
				for (int j = knockDetection_0.MinDisplayFrequencyHz + num23; j <= knockDetection_0.MaxDisplayFrequencyHz; j += 1000)
				{
					float num25 = (j - knockDetection_0.MinDisplayFrequencyHz) * num6 / (knockDetection_0.MaxDisplayFrequencyHz - knockDetection_0.MinDisplayFrequencyHz);
					if (num25 - 25f > num24 || j == knockDetection_0.MinDisplayFrequencyHz + num23)
					{
						graphics.DrawLine(Pens.Gray, num25, num7, num25, num7 + 3f);
						string text4 = string.Format(Class333.smethod_473(), (float)j / 1000f);
						int num26 = (int)graphics.MeasureString(text4, Font).Width;
						graphics.DrawString(text4, Font, Brushes.White, num25 - (float)(num26 / 2), num7 + 4f);
						num24 = num25 + 22f;
					}
				}
			}
			int num27 = num4 * num3 / num;
			int num28 = (num4 + num5) * num3 / num;
			float num29 = num6 * (num2 - num27) / (num28 - num27);
			using (Pen pen = new Pen(Color.Gray, 1f))
			{
				pen.DashStyle = DashStyle.Dot;
				graphics.DrawLine(pen, num29, num7, num29, num8);
			}
			try
			{
				method_1(out var int_, out var int_2);
				graphics.FillRectangle(Brushes.White, int_, Height - 8, int_2 - int_, 6);
				graphics.DrawLine(Pens.Black, int_ + 10, Height - 10, int_ + 10, Height);
				graphics.DrawLine(Pens.Black, int_2 - 10, Height - 10, int_2 - 10, Height);
				graphics.DrawRectangle(Pens.Gray, 0, Height - 10, Width - 11, 9);
				graphics.DrawLine(Pens.Gray, 10, Height - 10, 10, Height);
				graphics.DrawLine(Pens.Gray, Width - 20, Height - 10, Width - 20, Height);
			}
			catch
			{
			}
			try
			{
				method_2(out var int_3, out var int_4);
				graphics.FillRectangle(Brushes.White, Width - 8, int_3, 6, int_4 - int_3);
				graphics.DrawLine(Pens.Black, Width - 10, int_3 + 10, Width, int_3 + 10);
				graphics.DrawLine(Pens.Black, Width - 10, int_4 - 10, Width, int_4 - 10);
				graphics.DrawRectangle(Pens.Gray, Width - 10, 0, 9, Height - 11);
				graphics.DrawLine(Pens.Gray, Width - 10, 10, Width, 10);
				graphics.DrawLine(Pens.Gray, Width - 10, Height - 20, Width, Height - 20);
			}
			catch
			{
			}
			string text5 = string.Format(Class333.smethod_467(), knockDetection_0.MinDisplayMagnitude / 100);
			int num30 = (int)graphics.MeasureString(text5, Font).Height;
			string text6 = string.Format(Class333.smethod_467(), knockDetection_0.MaxDisplayMagnitude / 100);
			int num31 = (int)graphics.MeasureString(text6, Font).Height;
			graphics.DrawString(text5, Font, Brushes.White, num6 + 1, (float)Height - 30f - (float)num30 / 2f);
			graphics.DrawString(text6, Font, Brushes.White, num6 + 1, num8 - (float)num31 / 2f);
			stopwatch.Stop();
			Class23.smethod_3(string.Format(Class333.smethod_476(), stopwatch.ElapsedMilliseconds), bool_1: false);
		}
		else
		{
			stopwatch.Stop();
		}
	}

	private void method_1(out int int_6, out int int_7)
	{
		int num = ((list_0.Count == 0) ? 20000 : (setting_0.method_256() * 2));
		int_6 = 10 + knockDetection_0.MinDisplayFrequencyHz * (Width - 30) / num;
		int_7 = 10 + knockDetection_0.MaxDisplayFrequencyHz * (Width - 30) / num;
	}

	private void method_2(out int int_6, out int int_7)
	{
		int_6 = Height - 20 - knockDetection_0.MaxDisplayMagnitude * (Height - 30) / 7000;
		int_7 = Height - 20 - knockDetection_0.MinDisplayMagnitude * (Height - 30) / 7000;
	}

	protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		if (mouseEventArgs_0.Button != MouseButtons.Left)
		{
			return;
		}
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int int_4 = 0;
		if (knockDetection_0 != null)
		{
			method_1(out int_, out int_2);
			method_2(out int_3, out int_4);
		}
		if (mouseEventArgs_0.Location.Y >= Height - 10 && mouseEventArgs_0.Location.Y <= Height && knockDetection_0 != null)
		{
			int_0 = mouseEventArgs_0.X;
			this.int_2 = int_;
			this.int_3 = int_2;
			if (int_0 >= 10 && (int_0 <= Width - 20 || int_0 >= Width - 10))
			{
				if (int_0 > int_ && int_0 < int_ + 10)
				{
					bool_2 = true;
				}
				else if (int_0 > int_ + 10 && int_0 < int_2 - 10)
				{
					bool_0 = true;
				}
				else if (int_0 > int_2 - 10 && int_0 < int_2)
				{
					bool_1 = true;
				}
			}
			else
			{
				knockDetection_0.MinDisplayFrequencyHz = 0;
				if (list_0.Count != 0)
				{
					int num = setting_0.method_256();
					knockDetection_0.MaxDisplayFrequencyHz = num * 2;
				}
				else
				{
					knockDetection_0.MaxDisplayFrequencyHz = 20000;
				}
				knockDetection_0.SaveKnockDetectionPreferences();
				Invalidate();
			}
		}
		else if (mouseEventArgs_0.Location.X >= Width - 10 && mouseEventArgs_0.Location.X <= Width && knockDetection_0 != null)
		{
			int_1 = mouseEventArgs_0.Y;
			this.int_4 = int_3;
			int_5 = int_4;
			if (int_1 >= 10 && (int_1 <= Height - 20 || int_1 >= Height - 10))
			{
				if (int_1 > int_3 && int_1 < int_3 + 10)
				{
					bool_4 = true;
				}
				else if (int_1 > int_3 + 10 && int_1 < int_4 - 10)
				{
					bool_3 = true;
				}
				else if (int_1 > int_4 - 10 && int_1 < int_4)
				{
					bool_5 = true;
				}
			}
			else
			{
				knockDetection_0.MinDisplayMagnitude = 0;
				knockDetection_0.MaxDisplayMagnitude = 7000;
				knockDetection_0.SaveKnockDetectionPreferences();
				Invalidate();
			}
		}
		else if (Parent != null && Parent is Class96)
		{
			(Parent as Class96).method_3(mouseEventArgs_0.Button, mouseEventArgs_0.X, mouseEventArgs_0.Y);
		}
	}

	protected override void OnMouseMove(MouseEventArgs mevent)
	{
		if (knockDetection_0 != null && (bool_0 || bool_2 || bool_1))
		{
			int num = ((list_0.Count == 0) ? 20000 : (setting_0.method_256() * 2));
			int num2 = Width - 30;
			if (bool_0)
			{
				int num3 = mevent.X - int_0;
				int num4 = this.int_3 - this.int_2;
				int num5 = this.int_2 + num3;
				int num6 = this.int_3 + num3;
				if (num5 < 10)
				{
					num5 = 10;
					num6 = 10 + num4;
				}
				else if (num6 > Width - 20)
				{
					num6 = Width - 20;
					num5 = num6 - num4;
				}
				knockDetection_0.MaxDisplayFrequencyHz = Math.Min(num, (num6 - 10) * num / num2);
				knockDetection_0.MinDisplayFrequencyHz = Math.Max(0, (num5 - 10) * num / num2);
			}
			else
			{
				method_1(out var _, out var _);
				if (bool_1)
				{
					knockDetection_0.MaxDisplayFrequencyHz = Math.Min(num, Math.Max(knockDetection_0.MinDisplayFrequencyHz + 1000, (mevent.X - 10) * num / num2));
				}
				else if (bool_2)
				{
					knockDetection_0.MinDisplayFrequencyHz = Math.Max(0, Math.Min(knockDetection_0.MaxDisplayFrequencyHz - 1000, (mevent.X - 10) * num / num2));
				}
			}
			Invalidate();
		}
		else if (knockDetection_0 != null && (bool_3 || bool_5 || bool_4))
		{
			int num7 = Height - 30;
			if (bool_3)
			{
				int num8 = mevent.Y - int_1;
				int num9 = int_5 - this.int_4;
				int num10 = this.int_4 + num8;
				int num11 = int_5 + num8;
				if (num10 < 10)
				{
					num10 = 10;
					num11 = 10 + num9;
				}
				else if (num11 > Height - 20)
				{
					num11 = Height - 20;
					num10 = num11 - num9;
				}
				knockDetection_0.MinDisplayMagnitude = Math.Max(0, (Height - 20 - num11) * 7000 / num7);
				knockDetection_0.MaxDisplayMagnitude = Math.Min(7000, (Height - 20 - num10) * 7000 / num7);
			}
			else
			{
				method_2(out var _, out var _);
				if (bool_4)
				{
					knockDetection_0.MaxDisplayMagnitude = Math.Min(7000, Math.Max(knockDetection_0.MinDisplayMagnitude + 1000, (num7 - (mevent.Y - 10)) * 7000 / num7));
				}
				else if (bool_5)
				{
					knockDetection_0.MinDisplayMagnitude = Math.Max(0, Math.Min(knockDetection_0.MaxDisplayMagnitude - 1000, (num7 - (mevent.Y - 10)) * 7000 / num7));
				}
			}
			Invalidate();
		}
		else if (Parent != null && Parent is Class96)
		{
			(Parent as Class96).method_4(mevent.X, mevent.Y);
		}
	}

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		if (Parent != null && Parent is Class96)
		{
			(Parent as Class96).method_5(mevent.X, mevent.Y);
		}
		if (knockDetection_0 != null && (bool_0 || bool_2 || bool_1 || bool_3 || bool_5 || bool_4))
		{
			knockDetection_0.SaveKnockDetectionPreferences();
		}
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		bool_4 = false;
		bool_5 = false;
	}
}
