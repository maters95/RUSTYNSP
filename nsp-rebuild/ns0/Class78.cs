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

internal class Class78 : Panel
{
	private const int int_0 = 500;

	private const int int_1 = 2048;

	private const int int_2 = 2;

	private const int int_3 = 10000;

	private Framework framework_0;

	private KnockDetection knockDetection_0;

	private Setting setting_0;

	private List<Setting> list_0 = new List<Setting>();

	private Stopwatch stopwatch_0 = new Stopwatch();

	private int[,,] int_4 = new int[2, 2048, 500];

	private int[] int_5 = new int[500];

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private int int_6;

	private int int_7;

	private int int_8;

	internal Class78(KnockDetection knockDetection_1, Framework framework_1)
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

	private void method_1()
	{
		if (knockDetection_0 == null)
		{
			return;
		}
		int num = 0;
		if (stopwatch_0.IsRunning)
		{
			stopwatch_0.Stop();
			num = (int)stopwatch_0.ElapsedMilliseconds;
			num = Math.Max(num, 10);
			stopwatch_0.Reset();
		}
		stopwatch_0.Start();
		Array.Copy(int_5, 1, int_5, 0, 499);
		int_5[499] = num;
		int num2 = 0;
		if (list_0.Count != 0)
		{
			num2 = list_0.Count;
		}
		else if (knockDetection_0.FFTMagnitudesForSensorsXFrequencies != null)
		{
			num2 = knockDetection_0.FFTMagnitudesForSensorsXFrequencies.GetLength(0);
		}
		int num3 = 0;
		int num4;
		while (true)
		{
			if (num3 >= num2)
			{
				return;
			}
			num4 = 0;
			if (list_0.Count != 0)
			{
				num4 = list_0[num3].method_242()[2];
			}
			else if (knockDetection_0.FFTMagnitudesForSensorsXFrequencies != null)
			{
				num4 = knockDetection_0.FFTMagnitudesForSensorsXFrequencies.GetLength(1);
			}
			if (num4 > 2048)
			{
				break;
			}
			Setting knockSensorEnabler = knockDetection_0.GetKnockSensorEnabler(num3);
			bool flag = knockSensorEnabler != null && knockSensorEnabler.method_256() != 0;
			for (int i = 0; i < num4; i++)
			{
				int num5 = 0;
				if (list_0.Count != 0)
				{
					if (flag)
					{
						num5 = list_0[num3].method_258(i);
					}
				}
				else if (knockDetection_0.FFTMagnitudesForSensorsXFrequencies != null && flag)
				{
					num5 = knockDetection_0.FFTMagnitudesForSensorsXFrequencies[num3, i];
					num5 = KnockDetection.ConvertAudioSampleValueToDecibels(num5);
				}
				int num6 = num3 * 2048 * 500 + i * 500;
				int sourceIndex = num6 + 1;
				Array.Copy(int_4, sourceIndex, int_4, num6, 499);
				int_4[num3, i, 499] = num5;
			}
			num3++;
		}
		throw new Exception(Class333.smethod_468() + num4 + Class333.smethod_469());
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		method_1();
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
			string text = Class333.smethod_470();
			int num6 = (int)graphics.MeasureString(text, Font).Height;
			graphics.DrawString(text, Font, Brushes.White, 3f, 3f);
			int num7 = Width - 73;
			int num8 = Height - 30;
			int num9 = 3 + num6;
			int num10 = num8 - num9;
			float num11 = (float)num10 / (float)num5;
			if (Form23.smethod_28(framework_0.aXc, bool_53: true) && !Form23.smethod_80())
			{
				int num12 = 0;
				int num13 = 0;
				Setting knockSensorEnabler = knockDetection_0.GetKnockSensorEnabler(1);
				bool flag = knockSensorEnabler != null && knockSensorEnabler.method_256() != 0;
				int num14 = 499;
				while (num14 >= 0 && int_5[num14] != 0 && num12 >= 0)
				{
					int num15 = num7 - num13 * num7 / 10000;
					SizeF size = new SizeF(Math.Max(num12 - num15, 1), Math.Max(num11, 1f));
					int num16 = 0;
					int num17 = int.MinValue;
					float num18 = 0f;
					if (num14 != 499)
					{
						for (int i = num4; i <= num4 + num5; i++)
						{
							int num19 = num10 * (i - num4) / num5;
							if (num19 != num16)
							{
								if (num4 != 0 || i - 1 != num4)
								{
									Color colourForMagnitude = knockDetection_0.GetColourForMagnitude(num17);
									PointF location = new PointF(num15, (float)num8 - (float)num16 - num11);
									using SolidBrush brush = new SolidBrush(colourForMagnitude);
									graphics.FillRectangle(brush, new RectangleF(location, size));
								}
								if (num14 == 498 && num10 > num5 * 2)
								{
									float num20 = num8 - num19;
									if (num20 + 7f < num18)
									{
										graphics.DrawLine(Pens.Gray, num7, num20, num7 + 3, num20);
										float num21 = (float)(i * num3) / (1000f * (float)num);
										string text2 = string.Format(Class333.smethod_471(), num21);
										SizeF sizeF = graphics.MeasureString(text2, Font);
										graphics.DrawString(text2, Font, Brushes.White, num7 + 5, num20 - sizeF.Height / 2f);
										num18 = num20 - sizeF.Height / 2f;
									}
								}
								num16 = num19;
								num17 = int.MinValue;
								if (i == num4 + num5)
								{
									break;
								}
							}
							else if (i == num4 && num14 == 498 && num10 > num5 * 2)
							{
								float num22 = num8;
								graphics.DrawLine(Pens.Gray, num7, num22, num7 + 3, num22);
								float num23 = (float)(i * num3) / (1000f * (float)num);
								string text3 = string.Format(Class333.smethod_471(), num23);
								SizeF sizeF2 = graphics.MeasureString(text3, Font);
								graphics.DrawString(text3, Font, Brushes.White, num7 + 5, num22 - sizeF2.Height / 2f);
								num18 = num22 - sizeF2.Height / 2f;
							}
							int val = int_4[0, i, num14];
							if (flag)
							{
								val = Math.Max(val, int_4[1, i, num14]);
							}
							num17 = Math.Max(val, num17);
						}
						num13 += int_5[num14];
					}
					num12 = num15;
					num14--;
				}
			}
			graphics.DrawLine(Pens.Gray, num7, num8, num7, 0);
			graphics.DrawLine(Pens.Gray, 0, num8, num7, num8);
			string text4 = Class333.smethod_472();
			int num24 = (int)graphics.MeasureString(text4, Font).Width;
			graphics.DrawString(text4, Font, Brushes.White, num7 / 2 - num24 / 2, num8 + 15);
			int num25 = 10;
			for (int j = 0; j < num25; j++)
			{
				int num26 = num7 - j * num7 / num25;
				graphics.DrawLine(Pens.Gray, num26, num8 + 1, num26, num8 + 4);
				string text5 = j.ToString();
				int num27 = (int)graphics.MeasureString(text5, Font).Width;
				graphics.DrawString(text5, Font, Brushes.White, num26 - num27 / 2, num8 + 4);
			}
			if (num10 <= num5 * 2)
			{
				int num28 = knockDetection_0.MinDisplayFrequencyHz % 1000;
				int num29 = 0;
				if (num28 != 0)
				{
					num29 = 1000 - num28;
				}
				float num30 = 0f;
				for (int k = knockDetection_0.MinDisplayFrequencyHz + num29; k <= knockDetection_0.MaxDisplayFrequencyHz; k += 1000)
				{
					float num31 = num8 - (k - knockDetection_0.MinDisplayFrequencyHz) * num10 / (knockDetection_0.MaxDisplayFrequencyHz - knockDetection_0.MinDisplayFrequencyHz);
					if (num31 + 7f < num30 || k == knockDetection_0.MinDisplayFrequencyHz + num29)
					{
						graphics.DrawLine(Pens.Gray, num7, num31, num7 + 3, num31);
						string text6 = string.Format(Class333.smethod_473(), (float)k / 1000f);
						int num32 = (int)graphics.MeasureString(text6, Font).Height;
						graphics.DrawString(text6, Font, Brushes.White, num7 + 5, num31 - (float)(num32 / 2));
						num30 = num31 - 5f;
					}
				}
			}
			int num33 = num4 * num3 / num;
			int num34 = (num4 + num5) * num3 / num;
			float num35 = num8 - num10 * (num2 - num33) / (num34 - num33);
			using (Pen pen = new Pen(Color.Gray, 1f))
			{
				pen.DashStyle = DashStyle.Dot;
				graphics.DrawLine(pen, 0f, num35, num7, num35);
			}
			try
			{
				method_2(out var int_, out var int_2);
				graphics.FillRectangle(Brushes.White, Width - 8, int_, 6, int_2 - int_);
				graphics.DrawLine(Pens.Black, Width - 10, int_ + 10, Width, int_ + 10);
				graphics.DrawLine(Pens.Black, Width - 10, int_2 - 10, Width, int_2 - 10);
				graphics.DrawRectangle(Pens.Gray, Width - 10, 0, 9, Height - 1);
				graphics.DrawLine(Pens.Gray, Width - 10, 10, Width, 10);
				graphics.DrawLine(Pens.Gray, Width - 10, Height - 10, Width, Height - 10);
			}
			catch
			{
			}
			stopwatch.Stop();
			Class23.smethod_3(string.Format(Class333.smethod_474(), stopwatch.ElapsedMilliseconds), bool_1: false);
		}
		else
		{
			stopwatch.Stop();
		}
	}

	private void method_2(out int int_9, out int int_10)
	{
		int num = ((list_0.Count == 0) ? 20000 : (setting_0.method_256() * 2));
		int_9 = Height - 10 - knockDetection_0.MaxDisplayFrequencyHz * (Height - 20) / num;
		int_10 = Height - 10 - knockDetection_0.MinDisplayFrequencyHz * (Height - 20) / num;
	}

	protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		if (mouseEventArgs_0.Button != MouseButtons.Left)
		{
			return;
		}
		int int_ = 0;
		int int_2 = 0;
		if (knockDetection_0 != null)
		{
			method_2(out int_, out int_2);
		}
		if (mouseEventArgs_0.Location.X >= Width - 10 && mouseEventArgs_0.Location.X <= Width && knockDetection_0 != null)
		{
			int_6 = mouseEventArgs_0.Y;
			int_7 = int_;
			int_8 = int_2;
			if (int_6 >= 10 && int_6 <= Height - 10)
			{
				if (int_6 > int_ && int_6 < int_ + 10)
				{
					bool_1 = true;
				}
				else if (int_6 > int_ + 10 && int_6 < int_2 - 10)
				{
					bool_0 = true;
				}
				else if (int_6 > int_2 - 10 && int_6 < int_2)
				{
					bool_2 = true;
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
		else if (Parent != null && Parent is Class95)
		{
			(Parent as Class95).method_3(mouseEventArgs_0.Button, mouseEventArgs_0.X, mouseEventArgs_0.Y);
		}
	}

	protected override void OnMouseMove(MouseEventArgs mevent)
	{
		if (knockDetection_0 != null && (bool_0 || bool_2 || bool_1))
		{
			int num = ((list_0.Count == 0) ? 20000 : (setting_0.method_256() * 2));
			int num2 = Height - 20;
			if (bool_0)
			{
				int num3 = mevent.Y - int_6;
				int num4 = int_8 - int_7;
				int num5 = int_7 + num3;
				int num6 = int_8 + num3;
				if (num5 < 10)
				{
					num5 = 10;
					num6 = 10 + num4;
				}
				else if (num6 > Height - 10)
				{
					num6 = Height - 10;
					num5 = num6 - num4;
				}
				knockDetection_0.MaxDisplayFrequencyHz = Math.Min(num, (Height - 10 - num5) * num / num2);
				knockDetection_0.MinDisplayFrequencyHz = Math.Max(0, (Height - 10 - num6) * num / num2);
			}
			else
			{
				method_2(out var _, out var _);
				if (bool_1)
				{
					knockDetection_0.MaxDisplayFrequencyHz = Math.Min(num, Math.Max(knockDetection_0.MinDisplayFrequencyHz + 1000, (num2 - (mevent.Y - 10)) * num / num2));
				}
				else if (bool_2)
				{
					knockDetection_0.MinDisplayFrequencyHz = Math.Max(0, Math.Min(knockDetection_0.MaxDisplayFrequencyHz - 1000, (num2 - (mevent.Y - 10)) * num / num2));
				}
			}
			Invalidate();
		}
		else if (Parent != null && Parent is Class95)
		{
			(Parent as Class95).method_4(mevent.X, mevent.Y);
		}
	}

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		if (Parent != null && Parent is Class95)
		{
			(Parent as Class95).method_5(mevent.X, mevent.Y);
		}
		if (knockDetection_0 != null && (bool_0 || bool_2 || bool_1))
		{
			knockDetection_0.SaveKnockDetectionPreferences();
		}
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
	}
}
