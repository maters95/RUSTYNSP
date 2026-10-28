using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;

namespace ns1;

internal class Class99 : MovableResizablePanel
{
	private const int Bjo = 4;

	private bool BjP;

	private int Bjp;

	private bool BjQ = true;

	private bool Bjq;

	private System.Timers.Timer BjR = new System.Timers.Timer();

	private Stopwatch Bjr = new Stopwatch();

	private int BjS;

	private bool Bjs = true;

	private bool BjT;

	private Stopwatch Bjt = new Stopwatch();

	private bool BjU = true;

	private Framework Bju;

	private Setting BjV;

	private int Bjv = -1;

	private string BjW;

	private bool Bjw = true;

	private int BjX;

	private int Bjx;

	private int BjY = int.MinValue;

	internal Class99(Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		Bju = framework_0;
		ContextMenuStrip = method_22();
		Class1.smethod_10(method_15);
		Class1.smethod_12(method_15);
		Form23.smethod_30(method_15);
		Form23.smethod_78(method_15);
		Form23.smethod_0(method_16);
		DoubleBuffered = true;
		BjR.Interval = 40.0;
		BjR.SynchronizingObject = this;
		BjR.Elapsed += BjR_Elapsed;
		BjR.AutoReset = true;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (BjV != null)
			{
				BjV.method_265(method_13);
				BjV.method_41(method_14);
			}
			Class1.smethod_11(method_15);
			Class1.smethod_13(method_15);
			Form23.smethod_31(method_15);
			Form23.smethod_79(method_15);
			Form23.smethod_1(method_16);
			foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
			{
				item.Click -= method_19;
				item.Click -= method_20;
				item.Click -= method_18;
			}
			ContextMenuStrip.Opened -= method_21;
			BjR.Elapsed -= BjR_Elapsed;
			BjR.Dispose();
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = base.ToString();
		if (BjV != null)
		{
			text = text + Class333.aMY() + BjV.ToString();
		}
		return text + Class333.BAZ() + Left + Class333.BAz() + Top;
	}

	internal void method_12()
	{
		if (BjV != null)
		{
			BjW = string.Empty;
			if (Form23.dictionary_0.ContainsKey(BjV.method_64()))
			{
				Class209 @class = Form23.dictionary_0[BjV.method_64()];
				BjX = @class.int_3;
				Bjx = @class.int_4;
			}
			else
			{
				BjX = BjV.method_224();
				Bjx = BjV.method_225();
			}
			Invalidate();
		}
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		base.OnPaint(paintEventArgs_0);
		Graphics graphics = paintEventArgs_0.Graphics;
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		bool flag;
		Color foreColor = ((!(flag = BjV != null && BjV.method_35() && PortFunction.smethod_52(BjV))) ? Color.Gray : Form23.color_12);
		int num = 0;
		int num2 = 0;
		string text = null;
		if (BjV != null)
		{
			num = BjV.method_256();
			num2 = BjV.method_231();
			text = Class233.smethod_35(BjV.method_232(), num2, bool_0: true, num);
		}
		int num3 = 0;
		Rectangle rect2;
		if (Bjw)
		{
			if (BjV != null)
			{
				string text2 = BjV.method_18();
				string text3 = (string.IsNullOrWhiteSpace(text2) ? BjV.method_60(Enum96.aYT) : (text2 + Class333.smethod_497() + BjV.method_60(Enum96.aYT) + Class333.smethod_9()));
				using Font font = new Font(Font.FontFamily, (float)Height * 0.14f, FontStyle.Regular);
				Size size = TextRenderer.MeasureText(text, font, new Size(0, 0), TextFormatFlags.NoPadding);
				int num4 = Width - 3 - size.Width;
				Rectangle rect = new Rectangle(3, 0, num4 - 10, Height);
				if (BjP)
				{
					Size size2 = TextRenderer.MeasureText(text3 + BjW, font, new Size(0, 0), TextFormatFlags.NoPadding);
					num3 = size2.Height;
					int width = size2.Width;
					if (width <= rect.Width)
					{
						Bjp = 0;
						Bjr.Reset();
					}
					else if (Bjp > rect.Width - width)
					{
						if (!BjQ)
						{
							if (!Bjr.IsRunning)
							{
								Bjr.Restart();
								Bjp = 0;
							}
							else if (Bjr.ElapsedMilliseconds < 500L)
							{
								Bjp = 0;
							}
						}
						else
						{
							Bjr.Reset();
						}
						Bjq = true;
					}
					else
					{
						Bjp = rect.Width - width;
						if (Bjq)
						{
							Bjr.Restart();
							Bjq = false;
						}
						else if (Bjr.ElapsedMilliseconds >= 800L)
						{
							Bjp = 0;
							Bjr.Reset();
						}
						BjQ = false;
					}
				}
				else
				{
					Bjp = 0;
					Bjr.Reset();
					BjW = string.Empty;
					num3 = TextRenderer.MeasureText(text3, font, new Size(0, 0), TextFormatFlags.NoPadding).Height;
				}
				graphics.SetClip(rect, CombineMode.Replace);
				if (BjP)
				{
					TextRenderer.DrawText(graphics, text3 + BjW, font, new Point(3 + Bjp, 3), foreColor, TextFormatFlags.PreserveGraphicsClipping | TextFormatFlags.NoPadding);
				}
				else
				{
					TextRenderer.DrawText(graphics, text3, font, new Point(3 + Bjp, 3), foreColor, TextFormatFlags.PreserveGraphicsClipping | TextFormatFlags.NoPadding);
				}
				graphics.ResetClip();
				TextRenderer.DrawText(graphics, text, font, new Point(num4, 3), foreColor, TextFormatFlags.NoPadding);
			}
			rect2 = new Rectangle(3, 3 + num3, Width - 6 - 1, Height - 6 - num3 - 1);
		}
		else
		{
			rect2 = new Rectangle(3, 3, Width - 6 - 1, Height - 6 - 1);
		}
		bool flag2 = flag && ((Form23.smethod_28(Bju.aXc, bool_53: true) && !Form23.smethod_80()) || Form23.smethod_84(BjV.method_64()));
		Color foreColor2 = Form23.color_19;
		if (flag)
		{
			if (flag2 && (BjX != 0 || Bjx != 0) && (num < BjX || num > Bjx))
			{
				graphics.FillRectangle(Brushes.Maroon, rect2);
				foreColor2 = Form23.color_0;
			}
			else
			{
				SolidBrush solidBrush = new SolidBrush(Form23.color_18);
				graphics.FillRectangle(solidBrush, rect2);
				solidBrush.Dispose();
			}
		}
		else
		{
			graphics.FillRectangle(Brushes.Gray, rect2);
		}
		graphics.DrawRectangle(Pens.White, rect2);
		if (flag2 & flag)
		{
			Rectangle rect3 = new Rectangle(rect2.X + 4, rect2.Y + 4, rect2.Width - 8, rect2.Height - 8);
			(string, string, bool) tuple = BjV.method_253(num);
			int num5 = BjV.method_228();
			int num6 = BjV.method_229();
			string text4 = Class233.smethod_29(num5, num2);
			string text5 = Class233.smethod_29(num6, num2);
			graphics.SetClip(rect3, CombineMode.Replace);
			if (Bjw)
			{
				Font font2;
				if (!tuple.Item3 && BjV.method_70() == 0)
				{
					float num7 = 0.85f;
					font2 = new Font(Font.FontFamily, (float)Math.Max(rect3.Height, 1) * num7);
					BjU = true;
					BjS = 0;
					Bjt.Reset();
					Bjs = true;
					int width2;
					int width3;
					do
					{
						width2 = TextRenderer.MeasureText(text4, font2, new Size(0, 0), TextFormatFlags.NoPadding).Width;
						width3 = TextRenderer.MeasureText(text5, font2, new Size(0, 0), TextFormatFlags.NoPadding).Width;
						if (width2 > rect3.Width || width3 > rect3.Width)
						{
							font2.Dispose();
							num7 *= 0.9f;
							font2 = new Font(Font.FontFamily, (float)Math.Max(rect3.Height, 1) * num7);
							if (font2.Size < 8f)
							{
								break;
							}
						}
					}
					while (width2 > rect3.Width || width3 > rect3.Width);
					int width4 = TextRenderer.MeasureText(tuple.Item1, font2, new Size(0, 0), TextFormatFlags.NoPadding).Width;
					TextRenderer.DrawText(graphics, tuple.Item1, font2, new Point(rect3.Right - width4, (rect3.Top + rect3.Bottom) / 2), foreColor2, TextFormatFlags.VerticalCenter | TextFormatFlags.PreserveGraphicsClipping | TextFormatFlags.NoPadding);
				}
				else
				{
					float num8 = 0.6f;
					font2 = new Font(Font.FontFamily, (float)Math.Max(rect3.Height, 1) * num8);
					int width5 = TextRenderer.MeasureText(tuple.Item1, font2, new Size(0, 0), TextFormatFlags.NoPadding).Width;
					if (width5 <= rect3.Width)
					{
						BjU = true;
						BjS = 0;
						Bjt.Reset();
					}
					else if (BjS > rect3.Width - width5)
					{
						if (!Bjs)
						{
							if (!Bjt.IsRunning)
							{
								Bjt.Restart();
								BjS = 0;
							}
							else if (Bjt.ElapsedMilliseconds < 500L)
							{
								BjS = 0;
							}
						}
						else
						{
							Bjt.Reset();
						}
						BjT = true;
						BjU = false;
						if (!BjR.Enabled)
						{
							BjR.Enabled = true;
						}
					}
					else
					{
						BjS = rect3.Width - width5;
						if (BjT)
						{
							Bjt.Restart();
							BjT = false;
						}
						else if (Bjt.ElapsedMilliseconds >= 800L)
						{
							BjS = 0;
							Bjt.Reset();
						}
						Bjs = false;
						BjU = false;
						if (!BjR.Enabled)
						{
							BjR.Enabled = true;
						}
					}
					TextRenderer.DrawText(graphics, tuple.Item1, font2, new Point(rect3.Left + BjS, (rect3.Top + rect3.Bottom) / 2), foreColor2, TextFormatFlags.VerticalCenter | TextFormatFlags.PreserveGraphicsClipping | TextFormatFlags.NoPadding);
				}
				font2.Dispose();
			}
			else
			{
				int num9 = 0;
				if (num2 != 0 && num2 != 82)
				{
					float emSize = Math.Min((float)Math.Max(rect3.Height, 1) * 0.2f, 16f);
					Font font3 = new Font(Font.FontFamily, emSize);
					num9 = TextRenderer.MeasureText(text, font3, new Size(0, 0), TextFormatFlags.NoPadding).Width + 4;
					TextRenderer.DrawText(graphics, text, font3, new Point(rect3.Right + 4 - num9, rect3.Top + rect3.Height / 7), foreColor2, TextFormatFlags.PreserveGraphicsClipping | TextFormatFlags.NoPadding);
					font3.Dispose();
				}
				int num10 = rect3.Width - num9;
				Font font4;
				if (!tuple.Item3 && BjV.method_70() == 0)
				{
					float num11 = 0.85f;
					font4 = new Font(Font.FontFamily, (float)Math.Max(rect3.Height, 1) * num11);
					BjU = true;
					BjS = 0;
					Bjt.Reset();
					Bjs = true;
					int width6;
					int width7;
					do
					{
						width6 = TextRenderer.MeasureText(text4, font4, new Size(0, 0), TextFormatFlags.NoPadding).Width;
						width7 = TextRenderer.MeasureText(text5, font4, new Size(0, 0), TextFormatFlags.NoPadding).Width;
						if (width6 > num10 || width7 > num10)
						{
							font4.Dispose();
							num11 *= 0.9f;
							font4 = new Font(Font.FontFamily, (float)Math.Max(rect3.Height, 1) * num11);
							if (font4.Size < 8f)
							{
								break;
							}
						}
					}
					while (width6 > num10 || width7 > num10);
					int width8 = TextRenderer.MeasureText(tuple.Item1, font4, new Size(0, 0), TextFormatFlags.NoPadding).Width;
					TextRenderer.DrawText(graphics, tuple.Item1, font4, new Point(rect2.Right - num9 - width8, (rect3.Top + rect3.Bottom) / 2), foreColor2, TextFormatFlags.VerticalCenter | TextFormatFlags.PreserveGraphicsClipping | TextFormatFlags.NoPadding);
				}
				else
				{
					float num12 = 0.6f;
					font4 = new Font(Font.FontFamily, (float)Math.Max(rect3.Height, 1) * num12);
					int width9 = TextRenderer.MeasureText(tuple.Item1, font4, new Size(0, 0), TextFormatFlags.NoPadding).Width;
					if (width9 <= num10)
					{
						BjU = true;
						BjS = 0;
						Bjt.Reset();
					}
					else if (BjS > num10 - width9)
					{
						if (!Bjs)
						{
							if (!Bjt.IsRunning)
							{
								Bjt.Restart();
								BjS = 0;
							}
							else if (Bjt.ElapsedMilliseconds < 500L)
							{
								BjS = 0;
							}
						}
						else
						{
							Bjt.Reset();
						}
						BjT = true;
						BjU = false;
						if (!BjR.Enabled)
						{
							BjR.Enabled = true;
						}
					}
					else
					{
						BjS = num10 - width9;
						if (BjT)
						{
							Bjt.Restart();
							BjT = false;
						}
						else if (Bjt.ElapsedMilliseconds >= 800L)
						{
							BjS = 0;
							Bjt.Reset();
						}
						Bjs = false;
						BjU = false;
						if (!BjR.Enabled)
						{
							BjR.Enabled = true;
						}
					}
					TextRenderer.DrawText(graphics, tuple.Item1, font4, new Point(rect3.Left + BjS, (rect3.Top + rect3.Bottom) / 2), foreColor2, TextFormatFlags.VerticalCenter | TextFormatFlags.PreserveGraphicsClipping | TextFormatFlags.NoPadding);
				}
				font4.Dispose();
			}
			graphics.ResetClip();
		}
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.BBF(), stopwatch.ElapsedMilliseconds, Left, Top), bool_1: false);
	}

	private void method_13(object sender, EventArgs e)
	{
		if (method_0())
		{
			int num = BjV.method_256();
			if (num != BjY)
			{
				Invalidate();
				BjY = num;
			}
		}
		else
		{
			BjY = int.MinValue;
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void method_15(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void method_16(object sender, EventArgs e)
	{
		method_12();
	}

	internal void method_17(object sender, EventArgs e)
	{
		Bjw = !Bjw;
		Invalidate();
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void BjR_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (BjP && method_0())
		{
			Bjp -= Math.Min(15, Width / 25);
		}
		if (method_0())
		{
			BjS -= Math.Min(15, Width / 25);
			if (BjP || !BjU)
			{
				Invalidate();
			}
		}
	}

	protected override void MouseMoveHandler(object sender, MouseEventArgs e)
	{
		if (BjV != null && e.X > 3 && e.X < Width - 3 && e.Y > 3 && e.Y < Height - 3)
		{
			BjP = true;
			if (BjV.method_6() != null)
			{
				if (PortFunction.smethod_27(BjV.method_6()))
				{
					SettingOrSpecialObject settingOrSpecialObject = BjV.method_6();
					Enum104 bSQ = settingOrSpecialObject.method_12().method_12().BSQ;
					Enum105 bSq = settingOrSpecialObject.method_12().method_12().BSq;
					byte bSR = settingOrSpecialObject.method_12().method_12().BSR;
					ushort bSr = settingOrSpecialObject.method_12().method_12().BSr;
					List<bool> list_ = new List<bool>();
					List<string> list = PortFunction.smethod_45(Bju, bSQ, bSq, bSR, bSr, bool_0: true, list_);
					if (list != null && list.Count == 1)
					{
						BjW = Class333.smethod_497() + list[0] + Class333.smethod_9();
					}
					else
					{
						BjW = string.Empty;
					}
				}
				else if (Bju.aWY.Contains(BjV.method_6()))
				{
					Class244 @class = null;
					foreach (SettingOrSpecialObject item in BjV.method_6().method_1())
					{
						if (item is Class244)
						{
							if (@class != null)
							{
								@class = null;
								break;
							}
							@class = item as Class244;
						}
					}
					if (@class != null)
					{
						int uint_ = @class.method_256();
						Enum104 enum104_ = PortFunction.smethod_12((uint)uint_);
						Enum105 enum105_ = PortFunction.smethod_13((uint)uint_);
						byte byte_ = PortFunction.smethod_14((uint)uint_);
						ushort ushort_ = PortFunction.smethod_15((uint)uint_);
						string text = PortFunction.smethod_37(PortFunction.smethod_36(Bju, enum104_, enum105_, byte_, ushort_));
						if (text != null)
						{
							BjW = Class333.smethod_497() + text + Class333.smethod_9();
						}
						else
						{
							BjW = string.Empty;
						}
					}
					else
					{
						BjW = string.Empty;
					}
				}
				else
				{
					BjW = string.Empty;
				}
			}
			else
			{
				BjW = string.Empty;
			}
			if (!BjR.Enabled)
			{
				BjR.Enabled = true;
			}
		}
		else
		{
			BjP = false;
			Bjp = 0;
			Bjr.Reset();
			BjW = string.Empty;
			BjQ = true;
		}
		base.MouseMoveHandler(sender, e);
	}

	protected override void MouseLeaveHandler(object sender, EventArgs e)
	{
		base.MouseLeaveHandler(sender, e);
		BjP = false;
		Bjp = 0;
		Bjr.Reset();
		BjW = string.Empty;
		BjQ = true;
		if (BjR.Enabled)
		{
			BjR.Enabled = false;
		}
		Invalidate();
	}

	private void method_18(object sender, EventArgs e)
	{
		Dispose();
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	internal void method_19(object sender, EventArgs e)
	{
		int num = Form44.smethod_0(Form23.form23_0, Bju, (BjV != null) ? BjV.method_64() : 0);
		if (num != 0)
		{
			if (BjV != null)
			{
				BjV.method_265(method_13);
				BjV.method_41(method_14);
			}
			BjV = Bju.method_31(num);
			if (BjV != null)
			{
				BjV.method_264(method_13);
				BjV.method_40(method_14);
				Bjv = BjV.method_64();
			}
			method_12();
		}
		BjS = 0;
		Bjt.Reset();
		Bjs = true;
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_20(object sender, EventArgs e)
	{
		Form28 form = new Form28(BjV, BjX, Bjx);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK && BjV != null)
		{
			int int_;
			int int_2;
			if (Form23.dictionary_0.ContainsKey(BjV.method_64()))
			{
				Class209 @class = Form23.dictionary_0[BjV.method_64()];
				int_ = @class.int_1;
				int_2 = @class.int_2;
			}
			else
			{
				int_ = BjV.method_226();
				int_2 = BjV.method_227();
			}
			Form23.smethod_4(BjV.method_64(), int_, int_2, form.method_0(), form.method_1());
			method_12();
			Form23.smethod_3();
		}
		form.Dispose();
	}

	private void method_21(object sender, EventArgs e)
	{
		if (ContextMenuStrip == null)
		{
			return;
		}
		foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
		{
			if (item.Text == Class333.smethod_1176())
			{
				item.Enabled = BjV != null;
			}
			else if (item.Text == Class333.BBf())
			{
				item.Enabled = !Form23.form23_0.control25_0.method_25(this);
			}
		}
	}

	private ContextMenuStrip method_22()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		contextMenuStrip.Opened += method_21;
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Text = Class333.BaC();
		toolStripMenuItem.Click += method_19;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Text = Class333.smethod_1176();
		toolStripMenuItem2.Click += method_20;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
		toolStripMenuItem3.Text = Class333.BBG();
		toolStripMenuItem3.Click += method_17;
		contextMenuStrip.Items.Add(toolStripMenuItem3);
		ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
		toolStripMenuItem4.Text = Class333.BBf();
		toolStripMenuItem4.Click += method_18;
		contextMenuStrip.Items.Add(toolStripMenuItem4);
		return contextMenuStrip;
	}

	internal void method_23(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.BBg());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.Baf() + Bjv);
		list.Add(Class333.BaN() + Bjw);
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal void method_24(StreamReader streamReader_0)
	{
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.BaN()))
			{
				Bjw = bool.Parse(text.Substring(Class333.BaN().Length));
			}
			else if (text.Contains(Class333.BaP()))
			{
				Bjw = !bool.Parse(text.Substring(text.IndexOf(Class333.BaP()) + Class333.BaP().Length));
			}
			else if (text.StartsWith(Class333.Baf()))
			{
				Bjv = int.Parse(text.Substring(Class333.Baf().Length));
				if (Bjv != -1)
				{
					BjV = Bju.method_31(Bjv);
					if (BjV != null)
					{
						BjV.method_264(method_13);
						BjV.method_40(method_14);
					}
				}
			}
			else if (text.Contains(Class333.BaI()))
			{
				string text2 = text.Substring(text.IndexOf(Class333.BaI()) + Class333.BaI().Length);
				if (int.TryParse(text2, out var result))
				{
					Bjv = result;
				}
				else
				{
					try
					{
						text2 = text2.Substring(1, text2.Length - 2);
						Bjv = (int)(Enum87)Enum.Parse(typeof(Enum87), text2);
					}
					catch
					{
						Bjv = -1;
					}
				}
				if (Bjv != -1)
				{
					BjV = Bju.method_31(Bjv);
					if (BjV != null)
					{
						BjV.method_264(method_13);
						BjV.method_40(method_14);
					}
				}
			}
			else if (!text.Contains(Class333.Bai()) && string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
	}
}
