using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NSP.SettingsFramework;
using ns1;
using ns2;
using ns4;
using ns7;

namespace ns0;

internal class Class77 : Panel
{
	private static readonly Color color_0 = Color.Red;

	private static readonly Color color_1 = Color.Blue;

	private static readonly Color color_2 = Color.Purple;

	private static readonly Color color_3 = Color.DimGray;

	private Framework framework_0;

	private KnockDetection knockDetection_0;

	private List<Setting> list_0 = new List<Setting>();

	private int int_0;

	private Setting setting_0;

	private Setting setting_1;

	private Setting setting_2;

	private Setting setting_3;

	private Setting setting_4;

	private Class148 class148_0;

	private Class148 class148_1;

	private const long long_0 = 5000L;

	private List<List<int>> list_1 = new List<List<int>>();

	private List<long> list_2 = new List<long>();

	private Stopwatch stopwatch_0 = new Stopwatch();

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private int int_1;

	private int int_2;

	private int int_3;

	internal Class77(KnockDetection knockDetection_1, Framework framework_1)
	{
		framework_0 = framework_1;
		knockDetection_0 = knockDetection_1;
		if (knockDetection_0 != null)
		{
			for (int i = 0; i < knockDetection_0.DataIdsOfAngleBucketChannels.Count; i++)
			{
				Setting setting = framework_0.method_31(knockDetection_0.DataIdsOfAngleBucketChannels[i]);
				if (setting != null)
				{
					list_0.Add(setting);
					setting.method_264(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
					setting.method_40(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
					list_1.Add(new List<int>());
					int_0 = list_0[list_0.Count - 1].method_242()[2];
					for (int j = 0; j < int_0; j++)
					{
						list_1[list_1.Count - 1].Add(0);
						list_2.Add(0L);
					}
				}
			}
			if (list_0.Count == 2)
			{
				class148_0 = new Class148();
				class148_0.AutoSize = false;
				class148_0.Height = (int)((float)class148_0.Height * 0.75f);
				class148_0.Width = 170;
				class148_0.Text = Class333.smethod_464();
				class148_0.Left = 10;
				class148_0.Top = 3;
				class148_0.Visible = false;
				class148_0.Checked = true;
				class148_0.CheckedChanged += knockDetection_0_OnDisplayedMagnitudeRangeChanged;
				Controls.Add(class148_0);
				class148_1 = new Class148();
				class148_1.AutoSize = false;
				class148_1.Height = (int)((float)class148_1.Height * 0.75f);
				class148_1.Width = 170;
				class148_1.Text = Class333.smethod_465();
				class148_1.Left = 10;
				class148_1.Top = 3 + class148_0.Height;
				class148_1.Visible = false;
				class148_1.Checked = true;
				class148_1.CheckedChanged += knockDetection_0_OnDisplayedMagnitudeRangeChanged;
				Controls.Add(class148_1);
			}
			setting_0 = framework_0.method_31(knockDetection_0.DataIdOfWindowStartAngleSetting);
			setting_1 = framework_0.method_31(knockDetection_0.DataIdOfWindowDurationSetting);
			if (setting_0 != null)
			{
				setting_0.method_264(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			if (setting_1 != null)
			{
				setting_1.method_264(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			setting_2 = framework_1.method_31(93);
			setting_3 = framework_1.method_31(94);
			setting_4 = framework_1.method_31(95);
			if (setting_2 != null)
			{
				setting_2.method_264(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
				setting_2.method_40(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			if (setting_3 != null)
			{
				setting_3.method_264(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
				setting_3.method_40(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			if (setting_4 != null)
			{
				setting_4.method_264(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
				setting_4.method_40(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			knockDetection_0.OnDisplayedMagnitudeRangeChanged += knockDetection_0_OnDisplayedMagnitudeRangeChanged;
		}
		Class1.smethod_10(method_0);
		Class1.smethod_12(method_0);
		Form23.smethod_30(method_0);
		stopwatch_0.Start();
		DoubleBuffered = true;
		SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
		SetStyle(ControlStyles.OptimizedDoubleBuffer, value: true);
		SetStyle(ControlStyles.UserPaint, value: true);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			foreach (Setting item in list_0)
			{
				item.method_265(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
				item.method_41(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			if (setting_0 != null)
			{
				setting_0.method_265(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			if (setting_1 != null)
			{
				setting_1.method_265(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			if (setting_2 != null)
			{
				setting_2.method_265(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
				setting_2.method_41(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			if (setting_3 != null)
			{
				setting_3.method_265(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
				setting_3.method_41(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			if (setting_4 != null)
			{
				setting_4.method_265(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
				setting_4.method_41(knockDetection_0_OnDisplayedMagnitudeRangeChanged);
			}
			if (class148_0 != null)
			{
				class148_0.CheckedChanged -= knockDetection_0_OnDisplayedMagnitudeRangeChanged;
			}
			if (class148_1 != null)
			{
				class148_1.CheckedChanged -= knockDetection_0_OnDisplayedMagnitudeRangeChanged;
			}
			if (knockDetection_0 != null)
			{
				knockDetection_0.OnDisplayedMagnitudeRangeChanged -= knockDetection_0_OnDisplayedMagnitudeRangeChanged;
			}
			Class1.smethod_11(method_0);
			Class1.smethod_13(method_0);
			Form23.smethod_31(method_0);
			stopwatch_0.Stop();
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
		if (Parent != null && BackColor != Parent.BackColor)
		{
			BackColor = Parent.BackColor;
		}
		Graphics graphics = paintEventArgs_0.Graphics;
		bool flag = list_0.Count != 0 && list_0[0].method_35();
		bool flag2 = list_0.Count == 2 && list_0[1].method_35();
		if (class148_0 != null && class148_1 != null)
		{
			if (flag & flag2)
			{
				if (class148_0.BackColor != BackColor)
				{
					class148_0.BackColor = BackColor;
				}
				if (class148_0.ForeColor != Form23.color_12)
				{
					class148_0.ForeColor = Form23.color_12;
				}
				if (!class148_0.Visible)
				{
					class148_0.Visible = true;
					if (!class148_0.Checked)
					{
						class148_0.Checked = true;
					}
				}
				if (class148_1.BackColor != BackColor)
				{
					class148_1.BackColor = BackColor;
				}
				if (class148_1.ForeColor != Form23.color_12)
				{
					class148_1.ForeColor = Form23.color_12;
				}
				if (!class148_1.Visible)
				{
					class148_1.Visible = true;
					if (!class148_1.Checked)
					{
						class148_1.Checked = true;
					}
				}
			}
			else
			{
				if (class148_0.Checked)
				{
					class148_0.Checked = false;
				}
				if (class148_0.Visible)
				{
					class148_0.Visible = false;
				}
				if (class148_1.Checked)
				{
					class148_1.Checked = false;
				}
				if (class148_1.Visible)
				{
					class148_1.Visible = false;
				}
			}
		}
		graphics.Clear(Color.Black);
		int num = method_8();
		if (num != 0)
		{
			using Brush brush = new SolidBrush(BackColor);
			graphics.FillRectangle(brush, 0, 0, Width, num);
		}
		if (knockDetection_0 != null && int_0 != 0 && setting_0 != null && setting_1 != null && setting_2 != null && setting_3 != null && setting_4 != null)
		{
			string text = Class333.smethod_466();
			float height = graphics.MeasureString(text, Font).Height;
			graphics.DrawString(text, Font, Brushes.White, 3f, num + 3);
			int num2 = Width - 10 - 47;
			float num3 = (float)Height - 20f;
			float num4 = (float)(num + 3) + height + 13f;
			float float_ = num3 - num4;
			graphics.DrawLine(Pens.Gray, 10f, num3, 10 + num2, num3);
			graphics.DrawLine(Pens.Gray, 10 + num2, num3, 10 + num2, num);
			try
			{
				method_9(out var int_, out var int_2);
				graphics.FillRectangle(Brushes.White, Width - 8, int_, 6, int_2 - int_);
				graphics.DrawLine(Pens.Black, Width - 10, int_ + 10, Width, int_ + 10);
				graphics.DrawLine(Pens.Black, Width - 10, int_2 - 10, Width, int_2 - 10);
				graphics.DrawRectangle(Pens.Gray, Width - 10, num, 9, Height - 1 - num);
				graphics.DrawLine(Pens.Gray, Width - 10, num + 10, Width, num + 10);
				graphics.DrawLine(Pens.Gray, Width - 10, Height - 10, Width, Height - 10);
			}
			catch
			{
			}
			string text2 = string.Format(Class333.smethod_467(), knockDetection_0.MinDisplayMagnitude / 100);
			int num5 = (int)graphics.MeasureString(text2, Font).Height;
			string text3 = string.Format(Class333.smethod_467(), knockDetection_0.MaxDisplayMagnitude / 100);
			int num6 = (int)graphics.MeasureString(text3, Font).Height;
			graphics.DrawString(text2, Font, Brushes.White, 10 + num2 + 1, (float)Height - 20f - (float)num5 / 2f);
			graphics.DrawString(text3, Font, Brushes.White, 10 + num2 + 1, num4 - (float)num6 / 2f);
			if (setting_2.method_122() && setting_3.method_122() && setting_4.method_122())
			{
				method_1(graphics, Font, 10, num2, 20f, 13f, num3, num4, float_, flag, flag2);
			}
		}
	}

	private void method_1(Graphics graphics_0, Font font_0, int int_4, int int_5, float float_0, float float_1, float float_2, float float_3, float float_4, bool bool_3, bool bool_4)
	{
		int num = setting_2.method_256();
		int int_6 = setting_3.method_256();
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		switch (num)
		{
		case 0:
			num2 = int_0;
			num3 = 720;
			num4 = 4;
			num5 = 8;
			break;
		default:
			return;
		case 1:
		case 2:
			num2 = int_0 / 2;
			num3 = 360;
			num4 = 2;
			num5 = 4;
			break;
		}
		List<int> list_ = new List<int>();
		StringFormat stringFormat = new StringFormat();
		stringFormat.Alignment = StringAlignment.Center;
		method_2(graphics_0, font_0, stringFormat, int_4, int_5, float_1, float_2, float_3, int_6, num3, list_);
		int int_7 = num3 / num2;
		method_3(graphics_0, int_4, int_5, float_4, float_0, num2, num3, int_7, list_, bool_3, bool_4);
		method_7(graphics_0, font_0, stringFormat, int_4, int_5, float_2, float_3, num2, num3, int_7, num4, num5);
		stringFormat.Dispose();
	}

	private void method_2(Graphics graphics_0, Font font_0, StringFormat stringFormat_0, int int_4, int int_5, float float_0, float float_1, float float_2, int int_6, int int_7, List<int> list_3)
	{
		for (int i = 0; i < int_6; i++)
		{
			int num = setting_4.method_258(i);
			int num2 = int_4 + i * int_5 / int_6;
			graphics_0.DrawString(num.ToString(), font_0, Brushes.White, num2, float_2 - float_0, stringFormat_0);
			float num3 = i * int_7 / int_6;
			float num4 = (float)setting_0.method_256() / 10f;
			float num5 = (float)setting_1.method_256() / 10f;
			int num6 = int_4 + (int)((num3 - num4) * (float)int_5 / (float)int_7);
			int num7 = (int)(num5 * (float)int_5 / (float)int_7);
			if (num6 < int_4 - 1)
			{
				int num8 = num7 - (int_4 - num6);
				graphics_0.FillRectangle(Brushes.White, int_4, float_2, num8, float_1 - float_2);
				list_3.Add(int_4);
				list_3.Add(int_4 + num8 - 1);
				int num9 = num6 + int_5;
				int num10 = num7 - num8;
				graphics_0.FillRectangle(Brushes.White, num9 - 1, float_2, num10, float_1 - float_2);
				list_3.Add(num9);
				list_3.Add(num9 + num10 - 1);
			}
			else
			{
				graphics_0.FillRectangle(Brushes.White, num6, float_2, num7, float_1 - float_2);
				list_3.Add(num6);
				list_3.Add(num6 + num7 - 1);
			}
		}
	}

	private void method_3(Graphics graphics_0, int int_4, int int_5, float float_0, float float_1, int int_6, int int_7, int int_8, List<int> list_3, bool bool_3, bool bool_4)
	{
		if (Form23.smethod_28(framework_0.aXc, bool_53: true) && !Form23.smethod_80())
		{
			int int_9 = Math.Min((int)(float_0 / 30f), 10);
			for (int i = 0; i < int_6; i++)
			{
				int num = i * int_8;
				int num2 = int_4 + num * int_5 / int_7;
				int num3 = int_8 * int_5 / int_7;
				bool flag = false;
				for (int j = 0; j < list_3.Count / 2; j++)
				{
					int num4 = list_3[j * 2];
					int num5 = list_3[j * 2 + 1];
					if ((num2 > num4 && num2 < num5) || (num2 + num3 > num4 && num2 + num3 < num5))
					{
						flag = true;
						break;
					}
				}
				if (list_0.Count != 1 && (list_0.Count != 2 || ((!bool_3 || bool_4) && !(!bool_3 & bool_4))))
				{
					if (bool_3 & bool_4)
					{
						if (class148_0 != null && class148_1 != null && class148_0.Visible && class148_1.Visible && (!class148_0.Checked || !class148_1.Checked))
						{
							method_5(graphics_0, float_0, float_1, int_9, i, num2, num3, flag);
						}
						else
						{
							method_6(graphics_0, float_0, float_1, int_9, i, num2, num3, flag);
						}
					}
					continue;
				}
				if (bool_3 | bool_4)
				{
					method_4(graphics_0, float_0, float_1, int_9, i, num2, num3, bool_3, bool_4, flag);
					continue;
				}
				foreach (List<int> item in list_1)
				{
					item[i] = 0;
					list_2[i] = 0L;
				}
			}
			return;
		}
		foreach (List<int> item2 in list_1)
		{
			for (int k = 0; k < item2.Count; k++)
			{
				item2[k] = 0;
				list_2[k] = 0L;
			}
		}
	}

	private void method_4(Graphics graphics_0, float float_0, float float_1, int int_4, int int_5, int int_6, int int_7, bool bool_3, bool bool_4, bool bool_5)
	{
		int val = 0;
		if (bool_4)
		{
			val = list_0[1].method_258(int_5);
		}
		else if (bool_3)
		{
			val = list_0[0].method_258(int_5);
		}
		int num = Math.Max(Math.Min(val, knockDetection_0.MaxDisplayMagnitude), knockDetection_0.MinDisplayMagnitude);
		float num2 = float_0 * ((float)(num - knockDetection_0.MinDisplayMagnitude) / (float)(knockDetection_0.MaxDisplayMagnitude - knockDetection_0.MinDisplayMagnitude));
		float y = (float)Height - (float_1 + num2);
		Color color = ((!bool_5) ? color_3 : color_0);
		using (Brush brush = new SolidBrush(color))
		{
			graphics_0.FillRectangle(brush, int_6, y, int_7, num2);
		}
		if (bool_4)
		{
			if (num > list_1[1][int_5])
			{
				list_1[1][int_5] = num;
				list_2[int_5] = stopwatch_0.ElapsedMilliseconds;
			}
		}
		else if (bool_3 && num > list_1[0][int_5])
		{
			list_1[0][int_5] = num;
			list_2[int_5] = stopwatch_0.ElapsedMilliseconds;
		}
		if (list_2[int_5] == 0L)
		{
			return;
		}
		long num3 = stopwatch_0.ElapsedMilliseconds - list_2[int_5];
		if (num3 < 10000L)
		{
			int alpha = ((num3 >= 5000L) ? (255 - (byte)((num3 - 5000L) * 255L / 5000L)) : 255);
			int num4 = 0;
			if (bool_4)
			{
				num4 = Height - (int)(float_1 + float_0 * ((float)(list_1[1][int_5] - knockDetection_0.MinDisplayMagnitude) / (float)(knockDetection_0.MaxDisplayMagnitude - knockDetection_0.MinDisplayMagnitude)));
			}
			else if (bool_3)
			{
				num4 = Height - (int)(float_1 + float_0 * ((float)(list_1[0][int_5] - knockDetection_0.MinDisplayMagnitude) / (float)(knockDetection_0.MaxDisplayMagnitude - knockDetection_0.MinDisplayMagnitude)));
			}
			int num5 = num4 + int_4 - (Height - (int)float_1);
			Rectangle rect = ((num5 <= 0) ? new Rectangle(int_6, num4, int_7, int_4) : new Rectangle(int_6, num4, int_7, int_4 - num5));
			if (rect.Width != 0 && rect.Height != 0)
			{
				using (LinearGradientBrush brush2 = new LinearGradientBrush(rect, Color.FromArgb(alpha, color), Color.Transparent, LinearGradientMode.Vertical))
				{
					graphics_0.FillRectangle(brush2, rect);
				}
			}
		}
		else
		{
			list_2[int_5] = 0L;
			if (bool_3)
			{
				list_1[0][int_5] = 0;
			}
			else if (bool_4)
			{
				list_1[1][int_5] = 0;
			}
		}
	}

	private void method_5(Graphics graphics_0, float float_0, float float_1, int int_4, int int_5, int int_6, int int_7, bool bool_3)
	{
		int num = 0;
		Color color;
		if (class148_0.Checked)
		{
			num = list_0[0].method_258(int_5);
			color = ((!bool_3) ? color_3 : color_0);
		}
		else
		{
			if (!class148_1.Checked)
			{
				list_2[int_5] = 0L;
				list_1[0][int_5] = 0;
				list_1[1][int_5] = 0;
				return;
			}
			num = list_0[1].method_258(int_5);
			color = ((!bool_3) ? color_3 : color_1);
		}
		int num2 = Math.Max(Math.Min(num, knockDetection_0.MaxDisplayMagnitude), knockDetection_0.MinDisplayMagnitude);
		float num3 = float_0 * ((float)(num2 - knockDetection_0.MinDisplayMagnitude) / (float)(knockDetection_0.MaxDisplayMagnitude - knockDetection_0.MinDisplayMagnitude));
		float y = (float)Height - (float_1 + num3);
		using (Brush brush = new SolidBrush(color))
		{
			graphics_0.FillRectangle(brush, int_6, y, int_7, num3);
		}
		if (class148_0.Checked)
		{
			if (num2 > list_1[0][int_5])
			{
				list_1[0][int_5] = num2;
				list_2[int_5] = stopwatch_0.ElapsedMilliseconds;
			}
		}
		else if (class148_1.Checked && num2 > list_1[1][int_5])
		{
			list_1[1][int_5] = num2;
			list_2[int_5] = stopwatch_0.ElapsedMilliseconds;
		}
		if (list_2[int_5] != 0L)
		{
			long num4 = stopwatch_0.ElapsedMilliseconds - list_2[int_5];
			if (num4 < 10000L)
			{
				int alpha = ((num4 >= 5000L) ? (255 - (byte)((num4 - 5000L) * 255L / 5000L)) : 255);
				int num5 = 0;
				if (class148_0.Checked)
				{
					num5 = Height - (int)(float_1 + float_0 * ((float)(list_1[0][int_5] - knockDetection_0.MinDisplayMagnitude) / (float)(knockDetection_0.MaxDisplayMagnitude - knockDetection_0.MinDisplayMagnitude)));
				}
				else if (class148_1.Checked)
				{
					num5 = Height - (int)(float_1 + float_0 * ((float)(list_1[1][int_5] - knockDetection_0.MinDisplayMagnitude) / (float)(knockDetection_0.MaxDisplayMagnitude - knockDetection_0.MinDisplayMagnitude)));
				}
				int num6 = num5 + int_4 - (Height - (int)float_1);
				Rectangle rect = ((num6 <= 0) ? new Rectangle(int_6, num5, int_7, int_4) : new Rectangle(int_6, num5, int_7, int_4 - num6));
				if (rect.Width != 0 && rect.Height != 0)
				{
					using LinearGradientBrush brush2 = new LinearGradientBrush(rect, Color.FromArgb(alpha, color), Color.Transparent, LinearGradientMode.Vertical);
					graphics_0.FillRectangle(brush2, rect);
				}
			}
			else
			{
				list_2[int_5] = 0L;
				if (class148_0.Checked)
				{
					list_1[0][int_5] = 0;
				}
				else if (class148_1.Checked)
				{
					list_1[1][int_5] = 0;
				}
			}
		}
		if (!class148_0.Checked)
		{
			list_1[0][int_5] = 0;
		}
		if (!class148_1.Checked)
		{
			list_1[1][int_5] = 0;
		}
	}

	private void method_6(Graphics graphics_0, float float_0, float float_1, int int_4, int int_5, int int_6, int int_7, bool bool_3)
	{
		int num = Math.Max(Math.Min(list_0[0].method_258(int_5), knockDetection_0.MaxDisplayMagnitude), knockDetection_0.MinDisplayMagnitude);
		int num2 = Math.Max(Math.Min(list_0[1].method_258(int_5), knockDetection_0.MaxDisplayMagnitude), knockDetection_0.MinDisplayMagnitude);
		int num3 = Math.Max(num, num2);
		if (bool_3)
		{
			int num4 = Math.Min(num, num2);
			float num5 = float_0 * ((float)(num4 - knockDetection_0.MinDisplayMagnitude) / (float)(knockDetection_0.MaxDisplayMagnitude - knockDetection_0.MinDisplayMagnitude));
			float num6 = (float)Height - (float_1 + num5);
			using (Brush brush = new SolidBrush(color_2))
			{
				graphics_0.FillRectangle(brush, int_6, num6, int_7, num5);
			}
			float num7 = (float)Height - (float_1 + float_0 * ((float)(num3 - knockDetection_0.MinDisplayMagnitude) / (float)(knockDetection_0.MaxDisplayMagnitude - knockDetection_0.MinDisplayMagnitude)));
			float height = num6 - num7 + 1f;
			Color color = ((num < num2) ? color_1 : color_0);
			using Brush brush2 = new SolidBrush(color);
			graphics_0.FillRectangle(brush2, int_6, num7, int_7, height);
		}
		else
		{
			float num8 = float_0 * ((float)(num3 - knockDetection_0.MinDisplayMagnitude) / (float)(knockDetection_0.MaxDisplayMagnitude - knockDetection_0.MinDisplayMagnitude));
			float y = (float)Height - (float_1 + num8);
			using Brush brush3 = new SolidBrush(color_3);
			graphics_0.FillRectangle(brush3, int_6, y, int_7, num8);
		}
		if (num > list_1[0][int_5])
		{
			list_1[0][int_5] = num;
			if (num >= list_1[1][int_5])
			{
				list_2[int_5] = stopwatch_0.ElapsedMilliseconds;
			}
		}
		if (num2 > list_1[1][int_5])
		{
			list_1[1][int_5] = num2;
			if (num2 > list_1[0][int_5])
			{
				list_2[int_5] = stopwatch_0.ElapsedMilliseconds;
			}
		}
		if (list_2[int_5] == 0L)
		{
			return;
		}
		long num9 = stopwatch_0.ElapsedMilliseconds - list_2[int_5];
		if (num9 < 10000L)
		{
			int alpha = ((num9 >= 5000L) ? (255 - (byte)((num9 - 5000L) * 255L / 5000L)) : 255);
			int num10;
			Color baseColor;
			if (list_1[0][int_5] >= list_1[1][int_5])
			{
				num10 = list_1[0][int_5];
				baseColor = (bool_3 ? color_0 : color_3);
			}
			else
			{
				num10 = list_1[1][int_5];
				baseColor = (bool_3 ? color_1 : color_3);
			}
			int num11 = Height - (int)(float_1 + float_0 * ((float)(num10 - knockDetection_0.MinDisplayMagnitude) / (float)(knockDetection_0.MaxDisplayMagnitude - knockDetection_0.MinDisplayMagnitude)));
			int num12 = num11 + int_4 - (Height - (int)float_1);
			Rectangle rect = ((num12 <= 0) ? new Rectangle(int_6, num11, int_7, int_4) : new Rectangle(int_6, num11, int_7, int_4 - num12));
			if (rect.Width != 0 && rect.Height != 0)
			{
				using (LinearGradientBrush brush4 = new LinearGradientBrush(rect, Color.FromArgb(alpha, baseColor), Color.Transparent, LinearGradientMode.Vertical))
				{
					graphics_0.FillRectangle(brush4, rect);
				}
			}
		}
		else
		{
			list_2[int_5] = 0L;
			list_1[0][int_5] = 0;
			list_1[1][int_5] = 0;
		}
	}

	private void method_7(Graphics graphics_0, Font font_0, StringFormat stringFormat_0, int int_4, int int_5, float float_0, float float_1, int int_6, int int_7, int int_8, int int_9, int int_10)
	{
		for (int i = 0; i <= int_6; i++)
		{
			int num = i * int_8;
			int num2 = int_4 + num * int_5 / int_7;
			if (i % int_9 == 0)
			{
				graphics_0.DrawLine(Pens.Gray, num2, float_1, num2, float_0 + 3f);
			}
			if (i % int_10 == 0)
			{
				graphics_0.DrawString(num.ToString(), font_0, Brushes.White, num2, Height - 15, stringFormat_0);
			}
		}
	}

	private int method_8()
	{
		int result = 0;
		if (list_0.Count == 2 && list_0[0].method_35() && list_0[1].method_35())
		{
			result = class148_1.Bottom + 3;
		}
		return result;
	}

	private void method_9(out int int_4, out int int_5)
	{
		int num = method_8();
		int_4 = Height - 10 - knockDetection_0.MaxDisplayMagnitude * (Height - num - 20) / 7000;
		int_5 = Height - 10 - knockDetection_0.MinDisplayMagnitude * (Height - num - 20) / 7000;
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
			method_9(out int_, out int_2);
		}
		if (mouseEventArgs_0.Location.X >= Width - 10 && mouseEventArgs_0.Location.X <= Width && knockDetection_0 != null)
		{
			int_1 = mouseEventArgs_0.Y;
			this.int_2 = int_;
			int_3 = int_2;
			int num = method_8();
			if (int_1 >= num + 10 && int_1 <= Height - 10)
			{
				if (int_1 > int_ && int_1 < int_ + 10)
				{
					bool_1 = true;
				}
				else if (int_1 > int_ + 10 && int_1 < int_2 - 10)
				{
					bool_0 = true;
				}
				else if (int_1 > int_2 - 10 && int_1 < int_2)
				{
					bool_2 = true;
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
		else if (Parent != null && Parent is Class94)
		{
			(Parent as Class94).method_3(mouseEventArgs_0.Button, mouseEventArgs_0.X, mouseEventArgs_0.Y);
		}
	}

	protected override void OnMouseMove(MouseEventArgs mevent)
	{
		if (knockDetection_0 != null && (bool_0 || bool_2 || bool_1))
		{
			int num = method_8();
			int num2 = Height - num - 20;
			if (bool_0)
			{
				int num3 = mevent.Y - int_1;
				int num4 = int_3 - this.int_2;
				int num5 = this.int_2 + num3;
				int num6 = int_3 + num3;
				if (num5 < num + 10)
				{
					num5 = num + 10;
					num6 = num5 + num4;
				}
				else if (num6 > Height - 10)
				{
					num6 = Height - 10;
					num5 = num6 - num4;
				}
				knockDetection_0.MinDisplayMagnitude = Math.Max(0, (Height - 10 - num6) * 7000 / num2);
				knockDetection_0.MaxDisplayMagnitude = Math.Min(7000, (Height - 10 - num5) * 7000 / num2);
			}
			else
			{
				method_9(out var _, out var _);
				if (bool_1)
				{
					knockDetection_0.MaxDisplayMagnitude = Math.Min(7000, Math.Max(knockDetection_0.MinDisplayMagnitude + 1000, (num2 - (mevent.Y - (10 + num))) * 7000 / num2));
				}
				else if (bool_2)
				{
					knockDetection_0.MinDisplayMagnitude = Math.Max(0, Math.Min(knockDetection_0.MaxDisplayMagnitude - 1000, (num2 - (mevent.Y - (10 + num))) * 7000 / num2));
				}
			}
			Invalidate();
		}
		else if (Parent != null && Parent is Class94)
		{
			(Parent as Class94).method_4(mevent.X, mevent.Y);
		}
	}

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		if (Parent != null && Parent is Class94)
		{
			(Parent as Class94).method_5(mevent.X, mevent.Y);
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
