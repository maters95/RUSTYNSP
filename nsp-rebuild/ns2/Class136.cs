using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using NSP.UserInterface;
using ns4;

namespace ns2;

internal class Class136 : Panel
{
	internal class Class137 : PictureBox
	{
		private Class136 BMk;

		internal Class137(Class136 class136_0)
		{
			BMk = class136_0;
			SetStyle(ControlStyles.Selectable, value: true);
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			base.OnPaint(paintEventArgs_0);
			if (!(Tag is int) || (int)Tag != BMk.method_5())
			{
				return;
			}
			paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			using GraphicsPath path = ThemedButton.smethod_0(new Rectangle(2, 2, Width - 5, Height - 5), 6);
			using Pen pen = new Pen(Color.DodgerBlue, 4f);
			paintEventArgs_0.Graphics.DrawPath(pen, path);
		}
	}

	private const int int_0 = 3;

	private const int int_1 = 140;

	private const int int_2 = 10;

	private const int int_3 = 25;

	private List<Image> list_0 = new List<Image>();

	private List<string> list_1 = new List<string>();

	private List<object> list_2 = new List<object>();

	private Class131 class131_0 = new Class131();

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	private int int_4 = -1;

	[SpecialName]
	[CompilerGenerated]
	internal void method_0(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal Class136()
	{
		SetStyle(ControlStyles.Selectable, value: true);
		SetStyle(ControlStyles.OptimizedDoubleBuffer, value: true);
		DoubleBuffered = true;
		AutoSize = false;
		class131_0.AutoSize = false;
		class131_0.Height = 180;
		class131_0.Width = 252;
		Height = 3 + class131_0.Height + 20;
		Width = 25 + class131_0.Width + 25;
		class131_0.Top = 3;
		class131_0.Left = 25;
		Controls.Add(class131_0);
	}

	internal void method_2()
	{
		class131_0.method_2();
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		base.OnPaint(paintEventArgs_0);
		if (method_5() > 0)
		{
			paintEventArgs_0.Graphics.DrawImage(Form23.image_2, 1, 80);
		}
		if (method_5() < method_14() - 1)
		{
			paintEventArgs_0.Graphics.DrawImage(Form23.image_3, Width - 1 - Form23.image_3.Width, 80);
		}
		paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		int num = method_14();
		if (num <= 1)
		{
			return;
		}
		using SolidBrush brush = new SolidBrush(Form23.color_12);
		using Pen pen = new Pen(Form23.color_12);
		int num2 = method_3(num);
		int y = Height - 15;
		int num3 = method_4(num, num2);
		for (int i = 0; i < num; i++)
		{
			int x = num3 + i * num2;
			if (method_5() == i)
			{
				paintEventArgs_0.Graphics.FillEllipse(brush, x, y, 10, 10);
			}
			else
			{
				paintEventArgs_0.Graphics.DrawEllipse(pen, x, y, 10, 10);
			}
		}
	}

	protected override void OnMouseClick(MouseEventArgs mouseEventArgs_0)
	{
		if (mouseEventArgs_0.Y < Height - 20)
		{
			if (mouseEventArgs_0.X < 25)
			{
				if (method_5() > 0)
				{
					int num = method_5();
					method_6(num - 1);
				}
				return;
			}
			if (mouseEventArgs_0.X > Width - 25)
			{
				if (method_5() < method_14() - 1)
				{
					int num = method_5();
					method_6(num + 1);
				}
				return;
			}
		}
		else if (method_14() > 1)
		{
			int num2 = method_14();
			int num3 = method_3(num2);
			int num4 = method_4(num2, num3);
			int num5 = 0;
			while (true)
			{
				if (num5 < num2)
				{
					int num6 = num4 + num5 * num3;
					if (mouseEventArgs_0.X >= num6 - 2 && mouseEventArgs_0.X <= num6 + 10 + 2)
					{
						break;
					}
					num5++;
					continue;
				}
				return;
			}
			method_6(num5);
			return;
		}
		base.OnMouseClick(mouseEventArgs_0);
	}

	private int method_3(int int_5)
	{
		return Math.Min(Math.Max((Width - 30) / (int_5 - 1), 15), 30);
	}

	private int method_4(int int_5, int int_6)
	{
		return (Width - (int_5 - 1) * int_6) / 2 - 5;
	}

	protected override void OnGotFocus(EventArgs eventArgs_0)
	{
		base.OnGotFocus(eventArgs_0);
		foreach (Control control in class131_0.Controls)
		{
			if (control is Class137 && control.Tag is int && ((int)control.Tag == method_5() || (method_5() == -1 && (int)control.Tag == 0)))
			{
				control.Select();
				control.Focus();
				class131_0.ScrollControlIntoView(control);
			}
			control.Invalidate();
		}
		method_2();
		Invalidate();
	}

	[SpecialName]
	internal int method_5()
	{
		return int_4;
	}

	[SpecialName]
	internal void method_6(int int_5)
	{
		foreach (Control control in class131_0.Controls)
		{
			if (control is Label)
			{
				if (int_5 == -1)
				{
					control.ForeColor = Form23.color_12;
				}
				else if (control.Tag is int && (int)control.Tag == int_5)
				{
					control.ForeColor = Color.DodgerBlue;
				}
				else
				{
					control.ForeColor = Form23.color_12;
				}
			}
			else if (control is Class137 && control.Tag is int && (int)control.Tag == int_5)
			{
				control.Select();
				control.Focus();
				class131_0.ScrollControlIntoView(control);
			}
			control.Invalidate();
		}
		method_2();
		if (int_5 != int_4)
		{
			int_4 = int_5;
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, null);
			}
		}
		Invalidate();
	}

	internal void method_7(Image image_0, string string_0, object object_0)
	{
		int count = list_0.Count;
		list_0.Add(image_0);
		list_1.Add(string_0);
		list_2.Add(object_0);
		Class137 @class = new Class137(this);
		@class.Tag = count;
		@class.SizeMode = PictureBoxSizeMode.Zoom;
		@class.Size = new Size(140, 140);
		@class.Image = image_0;
		@class.Left = count * 150;
		@class.Top = 0;
		class131_0.Controls.Add(@class);
		@class.Click += method_9;
		@class.PreviewKeyDown += method_10;
		Label label = new Label();
		label.Tag = count;
		label.ForeColor = Form23.color_12;
		label.AutoSize = false;
		label.TextAlign = ContentAlignment.MiddleCenter;
		label.Width = @class.Width;
		label.Height = 20;
		label.Text = string_0;
		label.Left = @class.Left;
		label.Top = @class.Height;
		class131_0.Controls.Add(label);
		label.Click += method_9;
		label.PreviewKeyDown += method_10;
	}

	internal void method_8()
	{
		int_4 = -1;
		for (int num = method_14() - 1; num >= 0; num--)
		{
			Image image = list_0[num];
			list_0.RemoveAt(num);
			list_1.RemoveAt(num);
			list_2.RemoveAt(num);
			for (int num2 = class131_0.Controls.Count - 1; num2 >= 0; num2--)
			{
				Control control = class131_0.Controls[num2];
				if ((control is Class137 || control is Label) && control.Tag is int && (int)control.Tag == num)
				{
					control.Click -= method_9;
					control.PreviewKeyDown -= method_10;
					class131_0.Controls.RemoveAt(num2);
					if (control is Class137)
					{
						(control as Class137).Image = null;
					}
					control.Dispose();
				}
			}
			image?.Dispose();
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		Control control = sender as Control;
		if (control.Tag != null)
		{
			int int_ = (int)control.Tag;
			method_6(int_);
		}
	}

	private void method_10(object sender, PreviewKeyDownEventArgs e)
	{
		base.OnPreviewKeyDown(e);
		if (e.KeyData == Keys.Left)
		{
			e.IsInputKey = true;
			if (method_5() > 0)
			{
				int num = method_5();
				method_6(num - 1);
			}
		}
		if (e.KeyData == Keys.Right)
		{
			e.IsInputKey = true;
			if (method_5() < method_14() - 1)
			{
				int num = method_5();
				method_6(num + 1);
			}
		}
	}

	internal Image method_11(int int_5)
	{
		if (int_5 >= 0 && int_5 < list_0.Count)
		{
			return list_0[int_5];
		}
		return null;
	}

	internal string method_12(int int_5)
	{
		if (int_5 >= 0 && int_5 < list_1.Count)
		{
			return list_1[int_5];
		}
		return null;
	}

	internal object method_13(int int_5)
	{
		if (int_5 >= 0 && int_5 < list_2.Count)
		{
			return list_2[int_5];
		}
		return null;
	}

	[SpecialName]
	internal int method_14()
	{
		return list_0.Count;
	}
}
