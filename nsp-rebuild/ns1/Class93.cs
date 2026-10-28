using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns4;
using ns5;
using ns7;

namespace ns1;

internal class Class93 : MovableResizablePanel
{
	private const int BJa = 2;

	private Framework BJB;

	private Setting BJb;

	private int BJC = -1;

	private bool BJc = true;

	private int BJD = 1;

	private bool BJd;

	private int BJE;

	private string BJe;

	private int BJF = int.MinValue;

	internal Class93(Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		BJB = framework_0;
		ContextMenuStrip = method_20();
		Class1.smethod_10(method_15);
		Class1.smethod_12(method_15);
		Form23.smethod_30(method_15);
		Form23.smethod_78(method_15);
		DoubleBuffered = true;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (BJb != null)
			{
				BJb.method_265(method_13);
				BJb.method_41(method_14);
			}
			foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
			{
				item.Click -= method_18;
				item.Click -= method_16;
				item.Click -= method_17;
			}
			ContextMenuStrip.Opened -= method_19;
			Class1.smethod_11(method_15);
			Class1.smethod_13(method_15);
			Form23.smethod_31(method_15);
			Form23.smethod_79(method_15);
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = base.ToString();
		if (BJb != null)
		{
			text = text + Class333.aMY() + BJb.ToString();
		}
		return text + Class333.BAZ() + Left + Class333.BAz() + Top;
	}

	internal void method_12()
	{
		if (BJb != null)
		{
			string text = BJb.method_18();
			if (!string.IsNullOrWhiteSpace(text))
			{
				BJe = text;
			}
			else
			{
				BJe = BJb.method_60(Enum96.aYT);
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
		Font font = new Font(Font.FontFamily, Math.Max(Height / 7, 1));
		int height = TextRenderer.MeasureText(BJe, font, new Size(Width - 6, Height - 6), TextFormatFlags.WordBreak | TextFormatFlags.NoPadding).Height;
		Rectangle bounds = new Rectangle(3, 3, Width - 6, height + 2);
		float num;
		if (BJc)
		{
			num = ((Height - height <= Width) ? ((float)(Height - (6 + height + 2) - 1)) : ((float)(Width - 6 - 1)));
		}
		else
		{
			num = ((Height <= Width) ? ((float)(Height - 6 - 1)) : ((float)(Width - 6 - 1)));
		}
		float num2 = num / 2f;
		float num3 = Width / 2;
		float num4 = ((!BJc) ? ((float)(Height / 2)) : ((float)(height + (Height - height) / 2)));
		bool flag = BJb != null && BJb.method_35() && PortFunction.smethod_52(BJb);
		if (BJc && BJb != null)
		{
			TextRenderer.DrawText(foreColor: (!flag) ? Color.Gray : Form23.color_12, dc: graphics, text: BJe, font: font, bounds: bounds, flags: TextFormatFlags.HorizontalCenter | TextFormatFlags.WordBreak | TextFormatFlags.NoPadding);
		}
		font.Dispose();
		Brush brush = null;
		if (flag)
		{
			int num5 = BJb.method_256();
			bool flag2 = false;
			List<Setting.ListItems.Struct45> list = BJb.method_102();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].bBv == BJD)
				{
					flag2 = true;
					break;
				}
			}
			bool flag3 = ((!flag2) ? (num5 >= BJD) : (num5 == BJD));
			if (BJd)
			{
				flag3 = !flag3;
			}
			if (flag3)
			{
				if (BJE == 0)
				{
					brush = Brushes.Green;
				}
				else if (BJE == 1)
				{
					brush = Brushes.Red;
				}
				else if (BJE == 2)
				{
					brush = Brushes.Orange;
				}
			}
			else
			{
				switch (Form23.enum62_0)
				{
				default:
					brush = Brushes.LightGray;
					break;
				case Form23.Enum62.Bqg:
					brush = Brushes.DarkGray;
					break;
				case Form23.Enum62.BqH:
					brush = Brushes.DarkGray;
					break;
				case Form23.Enum62.BqG:
				case Form23.Enum62.Bqh:
					brush = Brushes.LightGray;
					break;
				}
			}
		}
		Pen pen = new Pen(Color.White, num2 * 0.03f);
		float num6 = num * 0.97f;
		float num7 = num6 / 2f;
		if (BJb != null && brush != null && ((Form23.smethod_28(BJB.aXc, bool_53: true) && !Form23.smethod_80()) || Form23.smethod_84(BJb.method_64())))
		{
			graphics.FillEllipse(brush, num3 - num2, num4 - num2, num, num);
		}
		graphics.DrawEllipse(pen, num3 - num7, num4 - num7, num6, num6);
		pen.Dispose();
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.Bal(), stopwatch.ElapsedMilliseconds, Left, Top), bool_1: false);
	}

	private void method_13(object sender, EventArgs e)
	{
		if (method_0())
		{
			int num = BJb.method_256();
			if (num != BJF)
			{
				Invalidate();
				BJF = num;
			}
		}
		else
		{
			BJF = int.MinValue;
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

	internal void method_16(object sender, EventArgs e)
	{
		if (BJb == null)
		{
			return;
		}
		int int_ = BJb.method_231();
		int int_2 = BJb.method_232();
		int int_3 = BJb.method_228();
		int int_4 = BJb.method_229();
		Form20 form = new Form20(BJD, int_, int_2, int_3, int_4, BJb.method_102());
		form.method_4(BJc);
		form.method_6(BJd);
		form.method_8(BJE);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			if (form.method_1() != null)
			{
				BJD = form.method_2();
			}
			else
			{
				double double_ = form.method_0();
				BJD = Class233.smethod_26(double_, int_);
			}
			BJc = form.method_3();
			BJd = form.method_5();
			BJE = form.method_7();
			Invalidate();
		}
		form.Dispose();
	}

	private void method_17(object sender, EventArgs e)
	{
		Dispose();
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	internal void method_18(object sender, EventArgs e)
	{
		int num = Form44.smethod_0(Form23.form23_0, BJB, (BJb != null) ? BJb.method_64() : 0);
		if (num != 0)
		{
			if (BJb != null)
			{
				BJb.method_265(method_13);
				BJb.method_41(method_14);
			}
			BJb = BJB.method_31(num);
			if (BJb != null)
			{
				BJb.method_264(method_13);
				BJb.method_40(method_14);
				BJC = BJb.method_64();
			}
			method_12();
		}
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_19(object sender, EventArgs e)
	{
		if (ContextMenuStrip == null)
		{
			return;
		}
		foreach (ToolStripMenuItem item in ContextMenuStrip.Items)
		{
			if (item.Text == Class333.BaM())
			{
				item.Enabled = !Form23.form23_0.control25_0.method_25(this);
				break;
			}
		}
	}

	private ContextMenuStrip method_20()
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		contextMenuStrip.BackColor = Form23.color_15;
		contextMenuStrip.ForeColor = Form23.color_12;
		contextMenuStrip.Opened += method_19;
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Text = Class333.BaC();
		toolStripMenuItem.Click += method_18;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Text = Class333.smethod_1176();
		toolStripMenuItem2.Click += method_16;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
		toolStripMenuItem3.Text = Class333.BaM();
		toolStripMenuItem3.Click += method_17;
		contextMenuStrip.Items.Add(toolStripMenuItem3);
		return contextMenuStrip;
	}

	internal void method_21(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.Bam());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.Baf() + BJC);
		list.Add(Class333.BaN() + BJc);
		list.Add(Class333.Ban() + BJD);
		list.Add(Class333.BaO() + BJd);
		list.Add(Class333.Bao() + BJE);
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal void method_22(StreamReader streamReader_0)
	{
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.BaN()))
			{
				BJc = bool.Parse(text.Substring(Class333.BaN().Length));
			}
			else if (text.Contains(Class333.BaP()))
			{
				BJc = !bool.Parse(text.Substring(text.IndexOf(Class333.BaP()) + Class333.BaP().Length));
			}
			else if (text.StartsWith(Class333.Ban()))
			{
				BJD = int.Parse(text.Substring(Class333.Ban().Length));
			}
			else if (text.Contains(Class333.Bap()))
			{
				BJD = int.Parse(text.Substring(text.IndexOf(Class333.Bap()) + Class333.Bap().Length));
			}
			else if (text.StartsWith(Class333.BaO()))
			{
				BJd = bool.Parse(text.Substring(Class333.BaO().Length));
			}
			else if (text.Contains(Class333.BaQ()))
			{
				BJd = bool.Parse(text.Substring(text.IndexOf(Class333.BaQ()) + Class333.BaQ().Length));
			}
			else if (text.StartsWith(Class333.Bao()))
			{
				BJE = int.Parse(text.Substring(Class333.Bao().Length));
			}
			else if (text.Contains(Class333.Baq()))
			{
				int num = int.Parse(text.Substring(text.IndexOf(Class333.Baq()) + Class333.Baq().Length));
				Color[] array = new Color[6]
				{
					Color.Magenta,
					Color.DodgerBlue,
					Color.Lime,
					Color.Gold,
					Color.DarkOrange,
					Color.Red
				};
				BJE = 0;
				Color[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					Color color = array2[i];
					if (num != color.ToArgb())
					{
						continue;
					}
					if (!(color == Color.DodgerBlue) && !(color == Color.Lime))
					{
						if (!(color == Color.Magenta) && !(color == Color.Red))
						{
							if (color == Color.Gold || color == Color.DarkOrange)
							{
								BJE = 2;
							}
						}
						else
						{
							BJE = 1;
						}
					}
					else
					{
						BJE = 0;
					}
					break;
				}
			}
			else if (text.StartsWith(Class333.Baf()))
			{
				BJC = int.Parse(text.Substring(Class333.Baf().Length));
				if (BJC != -1)
				{
					BJb = BJB.method_31(BJC);
					if (BJb != null)
					{
						BJb.method_264(method_13);
						BJb.method_40(method_14);
					}
				}
			}
			else if (text.Contains(Class333.BaI()))
			{
				string text2 = text.Substring(text.IndexOf(Class333.BaI()) + Class333.BaI().Length);
				if (int.TryParse(text2, out var result))
				{
					BJC = result;
				}
				else
				{
					try
					{
						text2 = text2.Substring(1, text2.Length - 2);
						BJC = (int)(Enum87)Enum.Parse(typeof(Enum87), text2);
					}
					catch
					{
						BJC = -1;
					}
				}
				if (BJC != -1)
				{
					BJb = BJB.method_31(BJC);
					if (BJb != null)
					{
						BJb.method_264(method_13);
						BJb.method_40(method_14);
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
