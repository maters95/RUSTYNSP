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

internal class Class92 : MovableResizablePanel
{
	private Framework Bit;

	private Setting BiU;

	private int Biu = -1;

	private string BiV;

	private long Biv;

	private long BiW;

	private long Biw;

	private long BiX;

	private long Bix;

	private long BiY;

	private int Biy;

	private int BiZ = 1;

	private bool Biz = true;

	private int BJA = int.MinValue;

	internal Class92(Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		Bit = framework_0;
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
		if (BiU != null)
		{
			text = text + Class333.aMY() + BiU.ToString();
		}
		return text + Class333.BAZ() + Left + Class333.BAz() + Top;
	}

	[SpecialName]
	internal int method_12()
	{
		return Biu;
	}

	internal void method_13()
	{
		method_14(bool_0: false);
	}

	internal void method_14(bool bool_0)
	{
		if (BiU == null)
		{
			return;
		}
		string text = BiU.method_18();
		if (!string.IsNullOrWhiteSpace(text))
		{
			BiV = text + Class333.smethod_497() + BiU.method_60(Enum96.aYT) + Class333.smethod_9();
		}
		else
		{
			BiV = BiU.method_60(Enum96.aYT);
		}
		if (Form23.dictionary_0.ContainsKey(BiU.method_64()))
		{
			Class209 @class = Form23.dictionary_0[BiU.method_64()];
			Bix = @class.int_3;
			BiY = @class.int_4;
		}
		else
		{
			Bix = BiU.method_224();
			BiY = BiU.method_225();
		}
		if (bool_0 || (Biv == 0L && BiW == 0L))
		{
			int num;
			int num2;
			if (Form23.dictionary_0.ContainsKey(BiU.method_64()))
			{
				Class209 class2 = Form23.dictionary_0[BiU.method_64()];
				num = class2.int_1;
				num2 = class2.int_2;
			}
			else
			{
				num = BiU.method_226();
				num2 = BiU.method_227();
			}
			Biv = num;
			BiW = num2;
		}
		if (bool_0 || (Biw == 0L && BiX == 0L) || Biy == 0)
		{
			int num3 = BiU.method_231();
			double num4 = Class233.smethod_28((int)Biv, num3);
			double num5 = Class233.smethod_28((int)BiW, num3);
			if (Class233.smethod_26(0.0, num3) == 0 && (num4 >= 1000.0 || num5 >= 1000.0))
			{
				BiZ = 1000;
			}
			else
			{
				BiZ = 1;
			}
			if (num4 >= -0.01 && num4 <= 0.01 && num5 <= 1.01)
			{
				Biw = Class233.smethod_26(0.0, num3);
				BiX = Class233.smethod_26(1.0, num3);
				Biy = 11;
			}
			else if (num4 >= -0.01 && num4 <= 0.01 && num5 <= 1.41)
			{
				Biw = Class233.smethod_26(0.0, num3);
				BiX = Class233.smethod_26(1.4, num3);
				Biy = 8;
			}
			else if (num4 >= -0.01 && num4 <= 0.01 && num5 <= 2.01)
			{
				Biw = Class233.smethod_26(0.0, num3);
				BiX = Class233.smethod_26(2.0, num3);
				Biy = 11;
			}
			else if (num5 - num4 <= 10.01)
			{
				int num6 = (int)Math.Round(num4);
				int num7 = (int)Math.Round(num5);
				Biw = Class233.smethod_26(num6, num3);
				BiX = Class233.smethod_26(num7, num3);
				Biy = num7 - num6 + 1;
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
					Biy = (int)((num9 - num8) / num11 + 1L);
					if (Biy > 11)
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
				while (Biy > 11 && num11 <= num10);
				Biw = Class233.smethod_26(num8, num3);
				BiX = Class233.smethod_26(num9, num3);
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
		float num = ((Height <= Width) ? ((float)(Height - 3)) : ((float)(Width - 3)));
		float num2 = num / 2f;
		float num3 = (float)(Width / 2) - 1.5f;
		float num4 = (float)(Height / 2) - 1.5f;
		int num5 = 0;
		if (BiU != null)
		{
			num5 = BiU.method_256();
		}
		bool flag2;
		bool flag = (flag2 = BiU != null && BiU.method_35() && PortFunction.smethod_52(BiU)) && ((Form23.smethod_28(Bit.aXc, bool_53: true) && !Form23.smethod_80()) || Form23.smethod_84(BiU.method_64()));
		Brush brush;
		if (flag2)
		{
			brush = ((!flag || (Bix == 0L && BiY == 0L) || (num5 >= Bix && num5 <= BiY)) ? Brushes.Black : Brushes.Maroon);
		}
		else
		{
			brush = Brushes.Gray;
		}
		float num6 = num * 0.97f;
		float num7 = num6 / 2f;
		using (Pen pen = new Pen(Color.White, num2 * 0.03f))
		{
			graphics.FillEllipse(brush, num3 - num2, num4 - num2, num, num);
			graphics.DrawEllipse(pen, num3 - num7, num4 - num7, num6, num6);
		}
		using (SolidBrush brush2 = new SolidBrush(Color.Gray))
		{
			float num8 = num / 7.5f;
			float num9 = num8 / 2f;
			graphics.FillEllipse(brush2, num3 - num9, num4 - num9, num8, num8);
		}
		if (BiU == null)
		{
			return;
		}
		try
		{
			if (Bix != 0L || BiY != 0L)
			{
				float num10 = num * 0.85f;
				if (Bix >= Biw)
				{
					using Pen pen2 = new Pen(Color.Red, num2 * 0.03f);
					float num11 = -210f + (float)(Bix - Biw) / (float)(BiX - Biw) * 240f;
					graphics.DrawArc(pen2, num3 - num10 / 2f, num4 - num10 / 2f, num10, num10, -210f, num11 - -210f);
				}
				if (BiY <= BiX)
				{
					using Pen pen3 = new Pen(Color.Red, num2 * 0.03f);
					float num12 = -210f + (float)(BiY - Biw) / (float)(BiX - Biw) * 240f;
					graphics.DrawArc(pen3, num3 - num10 / 2f, num4 - num10 / 2f, num10, num10, num12, 30f - num12);
				}
			}
			Font font = new Font(Font.FontFamily, num2 * 0.1f, FontStyle.Bold | FontStyle.Italic);
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			Pen pen4 = new Pen(Form23.color_0, num2 * 0.01f);
			Pen pen5 = new Pen(Form23.color_0, num2 * 0.03f);
			float num13 = num2 * 0.08f;
			float num14 = num2 * 0.12f;
			float num15 = num7 * 0.99f;
			int num16 = BiU.method_231();
			for (long num17 = 0L; num17 < Biy * 2 - 1; num17++)
			{
				float num18 = (-210f + (float)num17 * (240f / (float)((Biy - 1) * 2))) * ((float)Math.PI * 2f) / 360f;
				if ((num17 & 1L) == 0L)
				{
					graphics.DrawLine(pen5, num3 + (num15 - num14) * (float)Math.Cos(num18), num4 + (num15 - num14) * (float)Math.Sin(num18), num3 + num15 * (float)Math.Cos(num18), num4 + num15 * (float)Math.Sin(num18));
					long num19 = Biw + num17 / 2L * (BiX - Biw) / (Biy - 1L);
					string text;
					if (BiZ != 1)
					{
						double num20 = Class233.smethod_28((int)num19, num16) / (double)BiZ;
						text = string.Format(Class333.smethod_483(), num20);
						while (text.EndsWith(Class333.smethod_184()))
						{
							text = text.Substring(0, text.Length - 1);
						}
						if (text.EndsWith(Class333.smethod_190()) || text.EndsWith(Class333.smethod_189()))
						{
							text = text.Substring(0, text.Length - 1);
						}
					}
					else
					{
						text = Class233.smethod_29((int)num19, num16);
						if (text.EndsWith(Class333.BaA()) || text.EndsWith(Class333.Baa()))
						{
							text = text.Substring(0, text.Length - 2);
						}
					}
					float num21 = graphics.MeasureString(text, font).Height / 2f;
					using SolidBrush brush3 = new SolidBrush(Form23.color_0);
					float num22 = 2.1f;
					if (text.Contains(Class333.smethod_190()) || text.Contains(Class333.smethod_189()))
					{
						num22 = 2.5f;
					}
					graphics.DrawString(text, font, brush3, num3 + (num15 - num22 * num14) * (float)Math.Cos(num18), num4 + (num15 - num22 * num14) * (float)Math.Sin(num18) - num21, stringFormat);
				}
				else
				{
					graphics.DrawLine(pen4, num3 + (num15 - num13) * (float)Math.Cos(num18), num4 + (num15 - num13) * (float)Math.Sin(num18), num3 + num15 * (float)Math.Cos(num18), num4 + num15 * (float)Math.Sin(num18));
				}
			}
			pen5.Dispose();
			pen4.Dispose();
			stringFormat.Dispose();
			font.Dispose();
			using (Font font2 = new Font(Font.FontFamily, num2 * 0.1f))
			{
				float num23 = graphics.MeasureString(BiV, font2).Width / 2f;
				using SolidBrush brush4 = new SolidBrush(Form23.color_0);
				graphics.DrawString(BiV, font2, brush4, num3 - num23, num4 - num2 + num * 0.75f);
				if (BiZ != 1)
				{
					string text2 = string.Format(Class333.BaJ(), BiZ);
					num23 = graphics.MeasureString(text2, font2).Width / 2f;
					graphics.DrawString(text2, font2, brush4, num3 - num23, num4 - num2 + num * 0.3f);
				}
			}
			if (flag2 && flag)
			{
				if (Biz)
				{
					(string, string, bool) tuple = BiU.method_253(num5);
					using Font font3 = new Font(Font.FontFamily, num2 * 0.1f, FontStyle.Bold);
					float num24 = graphics.MeasureString(tuple.Item1, font3).Width / 2f;
					graphics.DrawString(tuple.Item1, font3, Brushes.White, num3 - num24, num4 - num2 + num * 0.62f);
				}
				float num25 = -210f + (float)(num5 - Biw) / (float)(BiX - Biw) * 240f;
				if (num25 < -240f)
				{
					num25 = -240f;
				}
				if (num25 > 60f)
				{
					num25 = 60f;
				}
				using Pen pen6 = new Pen(Color.Red, num2 * 0.04f);
				float num26 = num2 * 0.9f;
				float num27 = num25 * ((float)Math.PI * 2f) / 360f;
				graphics.DrawLine(pen6, num3, num4, num3 + num26 * (float)Math.Cos(num27), num4 + num26 * (float)Math.Sin(num27));
			}
		}
		catch
		{
		}
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.Baj(), stopwatch.ElapsedMilliseconds, Left, Top), bool_1: false);
	}

	private void method_15(object sender, EventArgs e)
	{
		if (method_0())
		{
			int num = BiU.method_256();
			if (num != BJA)
			{
				Invalidate();
				BJA = num;
			}
		}
		else
		{
			BJA = int.MinValue;
		}
	}

	private void method_16(object sender, EventArgs e)
	{
		bool bool_ = !Form23.dictionary_0.ContainsKey(BiU.method_64());
		method_14(bool_);
	}

	private void method_17(object sender, EventArgs e)
	{
		bool bool_ = !Form23.dictionary_0.ContainsKey(BiU.method_64());
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
		Biz = !Biz;
		Invalidate();
	}

	private void method_22()
	{
		if (BiU == null)
		{
			return;
		}
		BiU.method_264(method_15);
		BiU.method_40(method_16);
		int num = BiU.method_216(Enum94.aYm);
		if (num != -1)
		{
			Setting setting = Bit.method_31(num);
			if (setting != null)
			{
				setting.method_264(method_17);
				setting.method_40(method_17);
			}
		}
		int num2 = BiU.method_216(Enum94.aYN);
		if (num2 != -1)
		{
			Setting setting2 = Bit.method_31(num2);
			if (setting2 != null)
			{
				setting2.method_264(method_17);
				setting2.method_40(method_17);
			}
		}
		int num3 = BiU.method_216(Enum94.aYl);
		if (num3 != -1)
		{
			Setting setting3 = Bit.method_31(num3);
			if (setting3 != null)
			{
				setting3.method_264(method_17);
				setting3.method_40(method_17);
			}
		}
		int num4 = BiU.method_216(Enum94.aYM);
		if (num4 != -1)
		{
			Setting setting4 = Bit.method_31(num4);
			if (setting4 != null)
			{
				setting4.method_264(method_17);
				setting4.method_40(method_17);
			}
		}
		int num5 = BiU.method_216(Enum94.aYn);
		if (num5 != -1)
		{
			Setting setting5 = Bit.method_31(num5);
			if (setting5 != null)
			{
				setting5.method_264(method_17);
				setting5.method_40(method_17);
			}
		}
		int num6 = BiU.method_216(Enum94.aYO);
		if (num6 != -1)
		{
			Setting setting6 = Bit.method_31(num6);
			if (setting6 != null)
			{
				setting6.method_264(method_17);
				setting6.method_40(method_17);
			}
		}
	}

	private void method_23()
	{
		if (BiU == null)
		{
			return;
		}
		BiU.method_265(method_15);
		BiU.method_41(method_16);
		int num = BiU.method_216(Enum94.aYm);
		if (num != -1)
		{
			Setting setting = Bit.method_31(num);
			if (setting != null)
			{
				setting.method_265(method_17);
				setting.method_41(method_17);
			}
		}
		int num2 = BiU.method_216(Enum94.aYN);
		if (num2 != -1)
		{
			Setting setting2 = Bit.method_31(num2);
			if (setting2 != null)
			{
				setting2.method_265(method_17);
				setting2.method_41(method_17);
			}
		}
		int num3 = BiU.method_216(Enum94.aYl);
		if (num3 != -1)
		{
			Setting setting3 = Bit.method_31(num3);
			if (setting3 != null)
			{
				setting3.method_265(method_17);
				setting3.method_41(method_17);
			}
		}
		int num4 = BiU.method_216(Enum94.aYM);
		if (num4 != -1)
		{
			Setting setting4 = Bit.method_31(num4);
			if (setting4 != null)
			{
				setting4.method_265(method_17);
				setting4.method_41(method_17);
			}
		}
		int num5 = BiU.method_216(Enum94.aYn);
		if (num5 != -1)
		{
			Setting setting5 = Bit.method_31(num5);
			if (setting5 != null)
			{
				setting5.method_265(method_17);
				setting5.method_41(method_17);
			}
		}
		int num6 = BiU.method_216(Enum94.aYO);
		if (num6 != -1)
		{
			Setting setting6 = Bit.method_31(num6);
			if (setting6 != null)
			{
				setting6.method_265(method_17);
				setting6.method_41(method_17);
			}
		}
	}

	internal void method_24(object sender, EventArgs e)
	{
		int num = Form44.smethod_0(Form23.form23_0, Bit, (BiU != null) ? BiU.method_64() : 0);
		if (num != 0)
		{
			method_23();
			BiU = Bit.method_31(num);
			if (BiU != null)
			{
				Biu = BiU.method_64();
			}
			method_22();
			method_14(bool_0: true);
		}
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_25(object sender, EventArgs e)
	{
		Form17 form = new Form17(BiU, (int)Biv, (int)BiW, (int)Bix, (int)BiY);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK && BiU != null)
		{
			Form23.smethod_4(BiU.method_64(), form.method_1(), form.method_2(), form.method_3(), form.method_4());
			method_14(bool_0: true);
			if (form.method_0())
			{
				Form23.form23_0.control25_0.method_17(BiU.method_64());
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
				item.Enabled = BiU != null;
			}
			else if (item.Text == Class333.BaK())
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
		toolStripMenuItem4.Text = Class333.BaK();
		toolStripMenuItem4.Click += method_20;
		contextMenuStrip.Items.Add(toolStripMenuItem4);
		return contextMenuStrip;
	}

	internal void method_28(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.Bak());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.Baf() + Biu);
		list.Add(Class333.BaG() + Biz);
		list.Add(Class333.Bag() + Biv);
		list.Add(Class333.BaH() + BiW);
		list.Add(Class333.Bah() + Biy);
		list.Add(Class333.BaL() + BiZ);
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
				Biu = int.Parse(text.Substring(Class333.Baf().Length));
				if (Biu != -1)
				{
					BiU = Bit.method_31(Biu);
					if (BiU != null)
					{
						method_22();
					}
				}
			}
			else if (text.StartsWith(Class333.Bag()))
			{
				if (BiU != null)
				{
					int num = int.Parse(text.Substring(Class333.Bag().Length));
					Biv = num;
				}
			}
			else if (text.StartsWith(Class333.BaH()))
			{
				if (BiU != null)
				{
					int num2 = int.Parse(text.Substring(Class333.BaH().Length));
					BiW = num2;
				}
			}
			else if (text.StartsWith(Class333.Bah()))
			{
				if (BiU != null)
				{
					int biy = int.Parse(text.Substring(Class333.Bah().Length));
					Biy = biy;
				}
			}
			else if (text.StartsWith(Class333.BaL()))
			{
				if (BiU != null)
				{
					int biZ = int.Parse(text.Substring(Class333.BaL().Length));
					BiZ = biZ;
				}
			}
			else if (text.Contains(Class333.BaI()))
			{
				string text2 = text.Substring(text.IndexOf(Class333.BaI()) + Class333.BaI().Length);
				if (int.TryParse(text2, out var result))
				{
					Biu = result;
				}
				else
				{
					try
					{
						text2 = text2.Substring(1, text2.Length - 2);
						Biu = (int)(Enum87)Enum.Parse(typeof(Enum87), text2);
					}
					catch
					{
						Biu = -1;
					}
				}
				if (Biu != -1)
				{
					BiU = Bit.method_31(Biu);
					if (BiU != null)
					{
						method_22();
					}
				}
			}
			else if (text.StartsWith(Class333.BaG()))
			{
				Biz = bool.Parse(text.Substring(Class333.BaG().Length));
			}
			else if (!text.Contains(Class333.Bai()) && string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
	}
}
