using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns4;
using ns5;
using ns7;

namespace ns1;

internal class Class91 : MovableResizablePanel
{
	private Framework BiN;

	private Setting Bin;

	private int BiO = -1;

	private string Bio;

	private long BiP;

	private long Bip;

	private long BiQ;

	private long Biq;

	private long BiR;

	private long Bir;

	private int BiS;

	private bool Bis = true;

	private int BiT = int.MinValue;

	internal Class91(Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		BiN = framework_0;
		ContextMenuStrip = method_27();
		Class1.smethod_10(method_19);
		Class1.smethod_12(method_19);
		Form23.smethod_30(method_19);
		Form23.smethod_78(method_19);
		Form23.smethod_0(method_18);
		DoubleBuffered = true;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			method_23();
			foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
			{
				item.Click -= method_24;
				item.Click -= method_25;
				item.Click -= method_20;
			}
			ContextMenuStrip.Opened -= method_26;
			Class1.smethod_11(method_19);
			Class1.smethod_13(method_19);
			Form23.smethod_31(method_19);
			Form23.smethod_79(method_19);
			Form23.smethod_1(method_18);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = base.ToString();
		if (Bin != null)
		{
			text = text + Class333.aMY() + Bin.ToString();
		}
		return text + Class333.BAZ() + Left + Class333.BAz() + Top;
	}

	[SpecialName]
	internal int method_12()
	{
		return BiO;
	}

	internal void method_13()
	{
		method_14(bool_0: false);
	}

	internal void method_14(bool bool_0)
	{
		if (Bin == null)
		{
			return;
		}
		string text = Bin.method_18();
		if (!string.IsNullOrWhiteSpace(text))
		{
			Bio = text + Class333.smethod_497() + Bin.method_60(Enum96.aYT) + Class333.smethod_9();
		}
		else
		{
			Bio = Bin.method_60(Enum96.aYT);
		}
		if (Form23.dictionary_0.ContainsKey(Bin.method_64()))
		{
			Class209 @class = Form23.dictionary_0[Bin.method_64()];
			BiR = @class.int_3;
			Bir = @class.int_4;
		}
		else
		{
			BiR = Bin.method_224();
			Bir = Bin.method_225();
		}
		if (bool_0 || (BiP == 0L && Bip == 0L))
		{
			int num;
			int num2;
			if (Form23.dictionary_0.ContainsKey(Bin.method_64()))
			{
				Class209 class2 = Form23.dictionary_0[Bin.method_64()];
				num = class2.int_1;
				num2 = class2.int_2;
			}
			else
			{
				num = Bin.method_226();
				num2 = Bin.method_227();
			}
			BiP = num;
			Bip = num2;
		}
		if (bool_0 || (BiQ == 0L && Biq == 0L) || BiS == 0)
		{
			int num3 = Bin.method_231();
			double num4 = Class233.smethod_28((int)BiP, num3);
			double num5 = Class233.smethod_28((int)Bip, num3);
			if (num4 >= -0.01 && num4 <= 0.01 && num5 <= 1.01)
			{
				BiQ = Class233.smethod_26(0.0, num3);
				Biq = Class233.smethod_26(1.0, num3);
				BiS = 11;
			}
			else if (num4 >= -0.01 && num4 <= 0.01 && num5 <= 1.41)
			{
				BiQ = Class233.smethod_26(0.0, num3);
				Biq = Class233.smethod_26(1.4, num3);
				BiS = 15;
			}
			else if (num4 >= -0.01 && num4 <= 0.01 && num5 <= 2.01)
			{
				BiQ = Class233.smethod_26(0.0, num3);
				Biq = Class233.smethod_26(2.0, num3);
				BiS = 11;
			}
			else if (num5 - num4 <= 10.01)
			{
				int num6 = (int)Math.Round(num4);
				int num7 = (int)Math.Round(num5);
				BiQ = Class233.smethod_26(num6, num3);
				Biq = Class233.smethod_26(num7, num3);
				BiS = num7 - num6 + 1;
			}
			else
			{
				long num8 = (long)Math.Ceiling(num4);
				long num9 = (long)Math.Floor(num5);
				long num10 = num9 - num8;
				long num11 = 5L;
				do
				{
					if (num9 >= 0L)
					{
						if (num9 > 0L)
						{
							num9 = (num9 + (num11 - 1L)) / num11 * num11;
						}
					}
					else
					{
						num9 = -((-num9 - (num11 - 1L)) / num11) * num11;
					}
					if (num8 < 0L)
					{
						num8 = -((-num8 + (num11 - 1L)) / num11) * num11;
					}
					else if (num8 > 0L)
					{
						num8 = (num8 - (num11 - 1L)) / num11 * num11;
					}
					if (num9 == num8)
					{
						num8 = num9 - num11;
					}
					BiS = (int)((num9 - num8) / num11 + 1L);
					if (BiS > 11)
					{
						num11 = num11 switch
						{
							5L => 10L, 
							10L => 25L, 
							25L => 50L, 
							50L => 100L, 
							100L => 200L, 
							200L => 500L, 
							500L => 1000L, 
							1000L => 2000L, 
							2000L => 5000L, 
							5000L => 10000L, 
							10000L => 50000L, 
							50000L => 100000L, 
							100000L => 500000L, 
							_ => num11 * 2L, 
						};
					}
				}
				while (BiS > 11 && num11 <= num10);
				BiQ = Class233.smethod_26(num8, num3);
				Biq = Class233.smethod_26(num9, num3);
			}
		}
		Invalidate();
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		base.OnPaint(paintEventArgs_0);
		Graphics graphics = paintEventArgs_0.Graphics;
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		using (Pen pen = new Pen(Color.Black, 1.5f))
		{
			graphics.DrawRectangle(pen, 3, 3, Width - 6 - 1, Height - 6 - 1);
		}
		bool flag2;
		bool flag = (flag2 = Bin != null && Bin.method_35() && PortFunction.smethod_52(Bin)) && ((Form23.smethod_28(BiN.aXc, bool_53: true) && !Form23.smethod_80()) || Form23.smethod_84(Bin.method_64()));
		if (Bin != null)
		{
			int num = Bin.method_256();
			Font font = new Font(Font.FontFamily, (float)Width * 0.1f);
			SolidBrush solidBrush = ((!flag2) ? new SolidBrush(Color.Gray) : new SolidBrush(Form23.color_12));
			SizeF sizeF = graphics.MeasureString(Bio, font);
			if (Bis)
			{
				graphics.TranslateTransform(6f, Height - 6);
			}
			else
			{
				graphics.TranslateTransform(6f, 6f + sizeF.Width);
			}
			graphics.RotateTransform(-90f);
			graphics.DrawString(Bio, font, solidBrush, 0f, 0f);
			graphics.ResetTransform();
			if ((Bis & flag2) && ((Form23.smethod_28(BiN.aXc, bool_53: true) && !Form23.smethod_80()) || Form23.smethod_84(Bin.method_64())))
			{
				(string, string, bool) tuple = Bin.method_253(num);
				graphics.TranslateTransform(6f, 6f + graphics.MeasureString(tuple.Item1, font).Width);
				graphics.RotateTransform(-90f);
				graphics.DrawString(tuple.Item1, font, solidBrush, 0f, 0f);
				graphics.ResetTransform();
			}
			solidBrush.Dispose();
			font.Dispose();
			int num2 = 3 + (int)sizeF.Height + 8;
			Rectangle rect = new Rectangle(num2, 5, Width - (num2 + 3 + 2 + 1), Height - 11);
			if (flag2)
			{
				if (flag && (BiR != 0L || Bir != 0L) && (num < BiR || num > Bir))
				{
					graphics.FillRectangle(Brushes.Maroon, rect);
				}
				else
				{
					graphics.FillRectangle(Brushes.Black, rect);
				}
			}
			else
			{
				graphics.FillRectangle(Brushes.Gray, rect);
			}
			try
			{
				int num3 = rect.Top + 10;
				int num4 = rect.Bottom - 10;
				int num5 = num4 - num3;
				Font font2 = new Font(Font.FontFamily, (float)Width * 0.08f);
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Center;
				float[] array = new float[BiS];
				string[] array2 = new string[BiS];
				float num6 = 0f;
				int num7 = Bin.method_231();
				for (long num8 = 0L; num8 < BiS; num8++)
				{
					long num9 = BiQ + num8 * (Biq - BiQ) / (BiS - 1L);
					array[num8] = num4 - num5 * (num9 - BiQ) / (Biq - BiQ);
					string text = Class233.smethod_29((int)num9, num7);
					if (text.EndsWith(Class333.BaA()) || text.EndsWith(Class333.Baa()))
					{
						text = text.Substring(0, text.Length - 2);
					}
					array2[num8] = text;
					float width = graphics.MeasureString(text, font2).Width;
					if (width > num6)
					{
						num6 = width;
					}
				}
				int num10 = (int)num6 + 10;
				for (int i = 0; i < BiS; i++)
				{
					SizeF sizeF2 = graphics.MeasureString(array2[i], font2);
					using SolidBrush brush = new SolidBrush(Form23.color_0);
					graphics.DrawString(array2[i], font2, brush, (float)(rect.Right - num10 + 5) + sizeF2.Width / 2f, array[i] - sizeF2.Height / 2f, stringFormat);
				}
				stringFormat.Dispose();
				font2.Dispose();
				if (BiR != 0L || Bir != 0L)
				{
					if (BiR >= BiQ)
					{
						long num11 = num4 - num5 * (BiR - BiQ) / (Biq - BiQ);
						Rectangle rect2 = new Rectangle(rect.Left, (int)num11, rect.Width - num10, rect.Bottom - (int)num11);
						using LinearGradientBrush brush2 = new LinearGradientBrush(rect2, Color.Red, Color.Black, 90f);
						graphics.FillRectangle(brush2, rect2);
					}
					if (Bir <= Biq)
					{
						long num12 = num3 + num5 * (Biq - Bir) / (Biq - BiQ);
						Rectangle rect3 = new Rectangle(rect.Left, rect.Top, rect.Width - num10, (int)num12 - rect.Top);
						using LinearGradientBrush brush3 = new LinearGradientBrush(rect3, Color.Red, Color.Black, 270f);
						graphics.FillRectangle(brush3, rect3);
					}
				}
				for (int j = 0; j < BiS; j++)
				{
					using Pen pen2 = new Pen(Color.White, 1f);
					pen2.DashStyle = DashStyle.Dash;
					graphics.DrawLine(pen2, rect.Left, array[j], rect.Right - num10, array[j]);
				}
				if (flag2 && flag)
				{
					long num13 = num4 - num5 * (num - BiQ) / (Biq - BiQ);
					int num14 = (int)((float)(rect.Width - num10) * 0.6f);
					int x = rect.Left + (rect.Width - num10 - num14) / 2;
					Rectangle rect4 = new Rectangle(x, (int)num13, num14, num4 - (int)num13);
					if (rect4.Height > 0)
					{
						LinearGradientBrush linearGradientBrush = (((BiR != 0L || Bir != 0L) && (num < BiR || num > Bir)) ? new LinearGradientBrush(rect4, Color.Red, Color.Pink, 180f) : new LinearGradientBrush(rect4, Color.Gray, Color.LightGray, 180f));
						graphics.FillRectangle(linearGradientBrush, rect4);
						linearGradientBrush.Dispose();
					}
				}
			}
			catch
			{
			}
			stopwatch.Stop();
			Class23.smethod_3(string.Format(Class333.BaB(), stopwatch.ElapsedMilliseconds, Left, Top), bool_1: false);
		}
		else
		{
			graphics.FillRectangle(rect: new Rectangle(26, 5, Width - 32, Height - 11), brush: Brushes.Black);
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		if (method_0())
		{
			int num = Bin.method_256();
			if (num != BiT)
			{
				Invalidate();
				BiT = num;
			}
		}
		else
		{
			BiT = int.MinValue;
		}
	}

	private void method_16(object sender, EventArgs e)
	{
		bool bool_ = !Form23.dictionary_0.ContainsKey(Bin.method_64());
		method_14(bool_);
	}

	private void method_17(object sender, EventArgs e)
	{
		bool bool_ = !Form23.dictionary_0.ContainsKey(Bin.method_64());
		method_14(bool_);
	}

	private void method_18(object sender, EventArgs e)
	{
		method_14(bool_0: false);
	}

	private void method_19(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void method_20(object sender, EventArgs e)
	{
		Dispose();
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_21(object sender, EventArgs e)
	{
		Bis = !Bis;
		Invalidate();
	}

	private void method_22()
	{
		if (Bin == null)
		{
			return;
		}
		Bin.method_264(method_15);
		Bin.method_40(method_16);
		int num = Bin.method_216(Enum94.aYm);
		if (num != -1)
		{
			Setting setting = BiN.method_31(num);
			if (setting != null)
			{
				setting.method_264(method_17);
				setting.method_40(method_17);
			}
		}
		int num2 = Bin.method_216(Enum94.aYN);
		if (num2 != -1)
		{
			Setting setting2 = BiN.method_31(num2);
			if (setting2 != null)
			{
				setting2.method_264(method_17);
				setting2.method_40(method_17);
			}
		}
		int num3 = Bin.method_216(Enum94.aYl);
		if (num3 != -1)
		{
			Setting setting3 = BiN.method_31(num3);
			if (setting3 != null)
			{
				setting3.method_264(method_17);
				setting3.method_40(method_17);
			}
		}
		int num4 = Bin.method_216(Enum94.aYM);
		if (num4 != -1)
		{
			Setting setting4 = BiN.method_31(num4);
			if (setting4 != null)
			{
				setting4.method_264(method_17);
				setting4.method_40(method_17);
			}
		}
		int num5 = Bin.method_216(Enum94.aYn);
		if (num5 != -1)
		{
			Setting setting5 = BiN.method_31(num5);
			if (setting5 != null)
			{
				setting5.method_264(method_17);
				setting5.method_40(method_17);
			}
		}
		int num6 = Bin.method_216(Enum94.aYO);
		if (num6 != -1)
		{
			Setting setting6 = BiN.method_31(num6);
			if (setting6 != null)
			{
				setting6.method_264(method_17);
				setting6.method_40(method_17);
			}
		}
	}

	private void method_23()
	{
		if (Bin == null)
		{
			return;
		}
		Bin.method_265(method_15);
		Bin.method_41(method_16);
		int num = Bin.method_216(Enum94.aYm);
		if (num != -1)
		{
			Setting setting = BiN.method_31(num);
			if (setting != null)
			{
				setting.method_265(method_17);
				setting.method_41(method_17);
			}
		}
		int num2 = Bin.method_216(Enum94.aYN);
		if (num2 != -1)
		{
			Setting setting2 = BiN.method_31(num2);
			if (setting2 != null)
			{
				setting2.method_265(method_17);
				setting2.method_41(method_17);
			}
		}
		int num3 = Bin.method_216(Enum94.aYl);
		if (num3 != -1)
		{
			Setting setting3 = BiN.method_31(num3);
			if (setting3 != null)
			{
				setting3.method_265(method_17);
				setting3.method_41(method_17);
			}
		}
		int num4 = Bin.method_216(Enum94.aYM);
		if (num4 != -1)
		{
			Setting setting4 = BiN.method_31(num4);
			if (setting4 != null)
			{
				setting4.method_265(method_17);
				setting4.method_41(method_17);
			}
		}
		int num5 = Bin.method_216(Enum94.aYn);
		if (num5 != -1)
		{
			Setting setting5 = BiN.method_31(num5);
			if (setting5 != null)
			{
				setting5.method_265(method_17);
				setting5.method_41(method_17);
			}
		}
		int num6 = Bin.method_216(Enum94.aYO);
		if (num6 != -1)
		{
			Setting setting6 = BiN.method_31(num6);
			if (setting6 != null)
			{
				setting6.method_265(method_17);
				setting6.method_41(method_17);
			}
		}
	}

	internal void method_24(object sender, EventArgs e)
	{
		int num = Form44.smethod_0(Form23.form23_0, BiN, (Bin != null) ? Bin.method_64() : 0);
		if (num != 0)
		{
			method_23();
			Bin = BiN.method_31(num);
			if (Bin != null)
			{
				BiO = Bin.method_64();
			}
			method_22();
			method_14(bool_0: true);
		}
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_25(object sender, EventArgs e)
	{
		Form17 form = new Form17(Bin, (int)BiP, (int)Bip, (int)BiR, (int)Bir);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK && Bin != null)
		{
			Form23.smethod_4(Bin.method_64(), form.method_1(), form.method_2(), form.method_3(), form.method_4());
			method_14(bool_0: true);
			if (form.method_0())
			{
				Form23.form23_0.control25_0.method_17(Bin.method_64());
			}
			Form23.smethod_3();
		}
		form.Dispose();
	}

	private void method_26(object sender, EventArgs e)
	{
		if (ContextMenuStrip == null)
		{
			return;
		}
		foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
		{
			if (item.Text == Class333.smethod_1176())
			{
				item.Enabled = Bin != null;
			}
			else if (item.Text == Class333.Bab())
			{
				item.Enabled = !Form23.form23_0.control25_0.method_25(this);
			}
		}
	}

	private ContextMenuStrip method_27()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		contextMenuStrip.Opened += method_26;
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Text = Class333.BaC();
		toolStripMenuItem.Click += method_24;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Text = Class333.smethod_1176();
		toolStripMenuItem2.Click += method_25;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
		toolStripMenuItem3.Text = Class333.Bac();
		toolStripMenuItem3.Click += method_21;
		contextMenuStrip.Items.Add(toolStripMenuItem3);
		ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
		toolStripMenuItem4.Text = Class333.Bab();
		toolStripMenuItem4.Click += method_20;
		contextMenuStrip.Items.Add(toolStripMenuItem4);
		return contextMenuStrip;
	}

	internal void method_28(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.BaD());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.Baf() + BiO);
		list.Add(Class333.BaG() + Bis);
		list.Add(Class333.Bag() + BiP);
		list.Add(Class333.BaH() + Bip);
		list.Add(Class333.Bah() + BiS);
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal void method_29(StreamReader streamReader_0)
	{
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.Baf()))
			{
				BiO = int.Parse(text.Substring(Class333.Baf().Length));
				if (BiO != -1)
				{
					Bin = BiN.method_31(BiO);
					if (Bin != null)
					{
						method_22();
					}
				}
			}
			else if (text.StartsWith(Class333.Bag()))
			{
				if (Bin != null)
				{
					int num = int.Parse(text.Substring(Class333.Bag().Length));
					BiP = num;
				}
			}
			else if (text.StartsWith(Class333.BaH()))
			{
				if (Bin != null)
				{
					int num2 = int.Parse(text.Substring(Class333.BaH().Length));
					Bip = num2;
				}
			}
			else if (text.StartsWith(Class333.Bah()))
			{
				if (Bin != null)
				{
					int biS = int.Parse(text.Substring(Class333.Bah().Length));
					BiS = biS;
				}
			}
			else if (text.Contains(Class333.BaI()))
			{
				string text2 = text.Substring(text.IndexOf(Class333.BaI()) + Class333.BaI().Length);
				if (int.TryParse(text2, out var result))
				{
					BiO = result;
				}
				else
				{
					try
					{
						text2 = text2.Substring(1, text2.Length - 2);
						BiO = (int)(Enum87)Enum.Parse(typeof(Enum87), text2);
					}
					catch
					{
						BiO = -1;
					}
				}
				if (BiO != -1)
				{
					Bin = BiN.method_31(BiO);
					if (Bin != null)
					{
						method_22();
					}
				}
			}
			else if (text.StartsWith(Class333.BaG()))
			{
				Bis = bool.Parse(text.Substring(Class333.BaG().Length));
			}
			else if (!text.Contains(Class333.Bai()) && string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
	}
}
