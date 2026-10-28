using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using NSP.UserInterface;
using ns4;
using ns5;
using ns7;

namespace ns0;

internal class Class42 : Panel
{
	private delegate void Delegate7(object sender, ElapsedEventArgs e);

	private const int int_0 = 250;

	private const int int_1 = 8;

	private const int int_2 = 23;

	private const int int_3 = 3;

	private const int int_4 = 300;

	private const int int_5 = 5000;

	private Stopwatch stopwatch_0 = new Stopwatch();

	private System.Timers.Timer timer_0 = new System.Timers.Timer();

	private bool bool_0;

	private static readonly object object_0 = new object();

	internal Class42()
	{
		Visible = false;
		Width = 250;
		Left = -Width;
		DoubleBuffered = true;
		Paint += Class42_Paint;
		MouseDown += Class42_MouseDown;
		Class1.smethod_10(method_3);
		Class1.smethod_12(method_4);
	}

	internal void method_0()
	{
		if (!bool_0)
		{
			bool_0 = true;
			timer_0.Interval = 20.0;
			timer_0.Elapsed -= timer_0_Elapsed;
			timer_0.Elapsed += timer_0_Elapsed;
			if (!timer_0.Enabled)
			{
				timer_0.Start();
			}
			Width = method_1();
			Height = method_2();
			Visible = true;
			BringToFront();
			Invalidate();
		}
	}

	private int method_1()
	{
		List<Class5> list = Class1.smethod_27();
		int num = 0;
		for (int i = 0; i < list.Count; i++)
		{
			string text = Class242.smethod_10(list[i].byte_4, list[i].byte_5);
			using Font font = new Font(Font.FontFamily, 10f, FontStyle.Bold);
			num = Math.Max(num, TextRenderer.MeasureText(Class333.smethod_246() + text, font).Width);
		}
		return Math.Max(250, num + 16 + 6);
	}

	private int method_2()
	{
		return 6 + 23 * Class1.smethod_27().Count;
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate7 method = timer_0_Elapsed;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		bool lockTaken = false;
		bool flag = false;
		try
		{
			Monitor.TryEnter(object_0, ref lockTaken);
			if (!lockTaken)
			{
				return;
			}
			timer_0.Stop();
			timer_0.Enabled = false;
			if (bool_0)
			{
				if (Left < 0)
				{
					Left += Width / (300 / (int)timer_0.Interval);
				}
				if (Left > 0)
				{
					Left = 0;
				}
				if (Left == 0)
				{
					bool_0 = false;
					stopwatch_0.Restart();
				}
				Invalidate();
				return;
			}
			if (stopwatch_0.ElapsedMilliseconds <= 5000L)
			{
				Invalidate();
				return;
			}
			if (Left > -Width)
			{
				Left -= Width / (300 / (int)timer_0.Interval);
				Invalidate();
			}
			if (Left < -Width)
			{
				Left = -Width;
			}
			if (Left == -Width && stopwatch_0.IsRunning)
			{
				Visible = false;
				stopwatch_0.Stop();
				flag = true;
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(object_0);
				if (!flag)
				{
					timer_0.Enabled = true;
					timer_0.Start();
				}
			}
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		method_5();
	}

	private void method_4(object sender, EventArgs2 e)
	{
		method_5();
	}

	private void method_5()
	{
		if (InvokeRequired)
		{
			BeginInvoke(() =>
			{
				Width = method_1();
			});
			BeginInvoke(() =>
			{
				Height = method_2();
			});
		}
		else
		{
			Width = method_1();
			Height = method_2();
		}
		Invalidate();
	}

	private void Class42_Paint(object sender, PaintEventArgs e)
	{
		using (SolidBrush brush = new SolidBrush(Form23.color_10))
		{
			e.Graphics.FillRectangle(brush, 0, 0, Width, Height);
		}
		e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		using (GraphicsPath path = ThemedButton.smethod_0(new Rectangle(1, 1, Width - 3, Height - 3), 6))
		{
			using Pen pen = new Pen(Color.DodgerBlue, 3f);
			e.Graphics.DrawPath(pen, path);
		}
		e.Graphics.SmoothingMode = SmoothingMode.Default;
		List<Class5> list = Class1.smethod_27();
		string text = string.Empty;
		if (Form23.list_2.Count == 1)
		{
			text = Form23.list_2[0].BpS.string_0;
		}
		List<Class5> list2 = new List<Class5>(list.Count);
		foreach (Class5 item in list)
		{
			if (!string.IsNullOrEmpty(text) && item.string_0 == text)
			{
				list2.Insert(0, item);
			}
			else
			{
				list2.Add(item);
			}
		}
		for (int i = 0; i < list2.Count; i++)
		{
			Class5 @class = list2[i];
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			using (GraphicsPath path2 = ThemedButton.smethod_0(new Rectangle(5, 3 + 23 * i + 1, Width - 10, 20), 3))
			{
				e.Graphics.DrawPath(Pens.Gray, path2);
			}
			e.Graphics.SmoothingMode = SmoothingMode.Default;
			using SolidBrush brush2 = new SolidBrush(Form23.color_12);
			using StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			if (!string.IsNullOrEmpty(text) && @class.string_0 == text)
			{
				using Font font = new Font(Font.FontFamily, 10f, FontStyle.Bold);
				int num = (int)Math.Round((float)(5000 - (int)stopwatch_0.ElapsedMilliseconds) / 1000f, 0);
				e.Graphics.DrawString(Class333.smethod_247() + num + Class333.smethod_248(), font, brush2, Width / 2, 3 + 23 * i + 11 + 2, stringFormat);
			}
			else
			{
				using Font font2 = new Font(Font.FontFamily, 10f, FontStyle.Bold);
				e.Graphics.DrawString(Class333.smethod_246() + Class242.smethod_10(@class.byte_4, @class.byte_5), font2, brush2, Width / 2, 3 + 23 * i + 11 + 2, stringFormat);
			}
		}
	}

	private void Class42_MouseDown(object sender, MouseEventArgs e)
	{
		List<Class5> list = Class1.smethod_27();
		string text = string.Empty;
		if (Form23.list_2.Count == 1)
		{
			text = Form23.list_2[0].BpS.string_0;
		}
		List<Class5> list2 = new List<Class5>(list.Count);
		foreach (Class5 item in list)
		{
			if (!string.IsNullOrEmpty(text) && item.string_0 == text)
			{
				list2.Insert(0, item);
			}
			else
			{
				list2.Add(item);
			}
		}
		string text2 = null;
		for (int i = 1; i <= list2.Count; i++)
		{
			if (e.Y > 3 && e.Y < 3 + i * 23)
			{
				text2 = list2[i - 1].string_0;
				break;
			}
		}
		if (text2 == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(text) || !(text2 == text))
		{
			Class5 @class = Class1.smethod_26(text2);
			if (@class != null)
			{
				Form23.form23_0.method_38(@class, Enum57.const_2);
				if (!string.IsNullOrEmpty(text))
				{
					Form23.form23_0.method_41(text);
				}
			}
			else
			{
				Form23.smethod_32(bool_53: true);
			}
		}
		Visible = false;
	}

	[CompilerGenerated]
	private void method_6()
	{
		Width = method_1();
	}

	[CompilerGenerated]
	private void method_7()
	{
		Height = method_2();
	}
}
