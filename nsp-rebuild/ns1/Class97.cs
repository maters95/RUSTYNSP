using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
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

internal class Class97 : MovableResizablePanel
{
	private const int BJH = 10;

	private const int BJh = 70;

	private const int BJI = 70;

	private const int BJi = 20;

	private const int BJJ = 20;

	[CompilerGenerated]
	private readonly int BJj = 116;

	[CompilerGenerated]
	private readonly int BJK = 60;

	private int BJk;

	private int BJL;

	private int BJl;

	private int BJM;

	private int BJm = -1;

	private int BJN;

	private bool BJn = true;

	private bool BJO;

	private System.Timers.Timer BJo = new System.Timers.Timer();

	private Stopwatch BJP = new Stopwatch();

	private Framework BJp;

	private List<Setting> BJQ = new List<Setting>();

	private List<int> BJq = new List<int>();

	private string BJR = Class333.smethod_2310();

	private string BJr;

	private List<int> BJS = new List<int>();

	private List<int> BJs = new List<int>();

	private bool BJT;

	private bool BJt;

	private int BJU;

	private int BJu;

	private int BJV;

	protected override int MIN_WIDTH
	{
		[CompilerGenerated]
		get
		{
			return BJj;
		}
	}

	protected override int MIN_HEIGHT
	{
		[CompilerGenerated]
		get
		{
			return BJK;
		}
	}

	internal Class97(Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		BJp = framework_0;
		ContextMenuStrip = method_22();
		Class1.smethod_10(method_15);
		Class1.smethod_12(method_15);
		Form23.smethod_30(method_15);
		Form23.smethod_78(method_15);
		Form23.smethod_0(method_16);
		DoubleBuffered = true;
		BJo.Interval = 40.0;
		BJo.SynchronizingObject = this;
		BJo.Elapsed += BJo_Elapsed;
		BJo.AutoReset = true;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (BJQ != null)
			{
				foreach (Setting item in BJQ)
				{
					item.method_265(method_13);
					item.method_41(method_14);
				}
			}
			foreach (ToolStripMenuItem item2 in ContextMenuStrip.Items)
			{
				item2.Click -= method_19;
				item2.Click -= method_20;
				item2.Click -= method_17;
			}
			ContextMenuStrip.Opened -= method_21;
			Class1.smethod_11(method_15);
			Class1.smethod_13(method_15);
			Form23.smethod_31(method_15);
			Form23.smethod_79(method_15);
			Form23.smethod_1(method_16);
			BJo.Elapsed -= BJo_Elapsed;
			BJo.Dispose();
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	public override string ToString()
	{
		string text = base.ToString();
		return text + Class333.aMY() + BJQ.Count + Class333.BaU() + Left + Class333.BAz() + Top;
	}

	internal void method_12()
	{
		BJS.Clear();
		BJs.Clear();
		BJr = string.Empty;
		foreach (Setting item in BJQ)
		{
			if (Form23.dictionary_0.ContainsKey(item.method_64()))
			{
				Class209 @class = Form23.dictionary_0[item.method_64()];
				BJS.Add(@class.int_3);
				BJs.Add(@class.int_4);
			}
			else
			{
				BJS.Add(item.method_224());
				BJs.Add(item.method_225());
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
		int num = 3;
		using (Font font = new Font(Font.FontFamily, 12f))
		{
			TextRenderer.DrawText(graphics, BJR, font, new Point(3, num), Form23.color_12);
			num += TextRenderer.MeasureText(BJR, font).Height + 2;
		}
		BJM = num;
		Rectangle rect = new Rectangle(3, num, Width - 6 - 1, Height - num - 3 - 1);
		using (Pen pen = new Pen(Color.Black, 1f))
		{
			graphics.DrawRectangle(pen, rect);
		}
		if (BJQ.Count == 0)
		{
			return;
		}
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		foreach (Setting item in BJQ)
		{
			string text = item.method_18();
			if (!string.IsNullOrWhiteSpace(text))
			{
				list.Add(text + Class333.smethod_497() + item.method_60(Enum96.aYT) + Class333.smethod_9());
				list2.Add(text + Class333.smethod_497() + item.method_60(Enum96.aYt) + Class333.smethod_9());
			}
			else
			{
				list.Add(item.method_60(Enum96.aYT));
				list2.Add(item.method_60(Enum96.aYt));
			}
		}
		int num2 = 0;
		Font font2 = null;
		int num3;
		int num4;
		int num5;
		if (BJk > 0 && BJL > 0)
		{
			num3 = BJk + BJL;
			num4 = BJL;
			num5 = Math.Max(rect.Width - 2 - BJk - BJL, 70);
			bool flag = false;
			do
			{
				num2 = (flag ? (num2 * 95 / 100) : Math.Min(rect.Height / BJQ.Count, 70));
				if (num2 < 10)
				{
					num2 = 10;
				}
				font2?.Dispose();
				font2 = new Font(Font.FontFamily, (float)num2 * 0.6f);
				flag = false;
				if (num2 <= 10)
				{
					continue;
				}
				for (int i = 0; i < list.Count; i++)
				{
					if (TextRenderer.MeasureText(list[i], font2).Width > num5)
					{
						flag = true;
						break;
					}
				}
			}
			while (flag);
		}
		else
		{
			bool flag2 = false;
			do
			{
				num2 = (flag2 ? (num2 * 95 / 100) : Math.Min(rect.Height / BJQ.Count, 70));
				if (num2 < 10)
				{
					num2 = 10;
				}
				num3 = (int)((float)num2 * 5.91f);
				num4 = (int)((float)num3 * 0.54f);
				num5 = rect.Width - 2 - num3;
				num5 = Math.Max(num5, 70);
				font2?.Dispose();
				font2 = new Font(Font.FontFamily, (float)num2 * 0.6f);
				flag2 = false;
				if (num2 <= 10)
				{
					continue;
				}
				for (int j = 0; j < list.Count; j++)
				{
					if (TextRenderer.MeasureText(list[j], font2).Width > num5)
					{
						flag2 = true;
						break;
					}
				}
			}
			while (flag2);
			int num6 = Width - 6 - 2 - num5;
			BJk = (int)((float)num6 * 0.65f);
			BJL = num6 - BJk;
		}
		BJl = num2;
		for (int k = 0; k < BJQ.Count; k++)
		{
			Setting setting = BJQ[k];
			int num7 = setting.method_256();
			bool num8 = setting.method_35() && PortFunction.smethod_52(setting);
			bool flag3 = (Form23.smethod_28(BJp.aXc, bool_53: true) && !Form23.smethod_80()) || Form23.smethod_84(setting.method_64());
			Color foreColor = Form23.color_19;
			Rectangle rect2 = new Rectangle(rect.Left + 2, num + 1, num5, num2 - 2);
			if (num8)
			{
				if (flag3 && (BJS[k] != 0 || BJs[k] != 0) && (num7 < BJS[k] || num7 > BJs[k]))
				{
					graphics.FillRectangle(Brushes.Maroon, rect2);
					foreColor = Form23.color_0;
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
			Rectangle rect3 = new Rectangle(rect.Left + 2, rect.Y, num5, rect.Height);
			string text2 = ((TextRenderer.MeasureText(list2[k], font2).Width > num5) ? list[k] : list2[k]);
			if (BJm == -1)
			{
				BJN = 0;
				BJP.Reset();
				BJr = string.Empty;
			}
			else if (k == BJm)
			{
				text2 += BJr;
				int width = TextRenderer.MeasureText(text2, font2).Width;
				if (width <= rect3.Width)
				{
					BJN = 0;
					BJP.Reset();
				}
				else if (BJN > rect3.Width - width)
				{
					if (!BJn)
					{
						if (!BJP.IsRunning)
						{
							BJP.Restart();
							BJN = 0;
						}
						else if (BJP.ElapsedMilliseconds < 500L)
						{
							BJN = 0;
						}
					}
					else
					{
						BJP.Reset();
					}
					BJO = true;
				}
				else
				{
					BJN = rect3.Width - width;
					if (BJO)
					{
						BJP.Restart();
						BJO = false;
					}
					else if (BJP.ElapsedMilliseconds >= 800L)
					{
						BJN = 0;
						BJP.Reset();
					}
					BJn = false;
				}
			}
			int num9 = num2 / 2;
			graphics.SetClip(rect3, CombineMode.Replace);
			if (k == BJm)
			{
				TextRenderer.DrawText(graphics, text2, font2, new Point(rect2.Left + BJN, num + num9), foreColor, TextFormatFlags.VerticalCenter | TextFormatFlags.PreserveGraphicsClipping);
			}
			else
			{
				TextRenderer.DrawText(graphics, text2, font2, new Point(rect2.Left, num + num9), foreColor, TextFormatFlags.VerticalCenter | TextFormatFlags.PreserveGraphicsClipping);
			}
			graphics.ResetClip();
			if (num8)
			{
				int num10 = setting.method_231();
				graphics.SetClip(rect, CombineMode.Replace);
				bool flag4 = false;
				if (flag3)
				{
					(string, string, bool) tuple = setting.method_253(num7);
					flag4 = tuple.Item3;
					TextRenderer.DrawText(graphics, tuple.Item1, font2, new Point(rect.Right - num3, num + num9), Form23.color_12, TextFormatFlags.VerticalCenter | TextFormatFlags.PreserveGraphicsClipping);
				}
				if (num10 != 0 && num10 != 82 && !flag4)
				{
					TextRenderer.DrawText(graphics, Class233.smethod_35(BJQ[k].method_232(), num10, bool_0: true, num7), font2, new Point(rect.Right - num4, num + num9), Form23.color_12, TextFormatFlags.VerticalCenter | TextFormatFlags.PreserveGraphicsClipping);
				}
				graphics.ResetClip();
			}
			num += num2;
		}
		font2.Dispose();
		stopwatch.Stop();
		Class23.smethod_3(string.Format(Class333.Bau(), stopwatch.ElapsedMilliseconds, Left, Top), bool_1: false);
	}

	private void method_13(object sender, EventArgs e)
	{
		if (method_0())
		{
			Invalidate();
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

	private void BJo_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (BJm != -1 && method_0())
		{
			BJN -= Math.Min(15, Width / 50);
			Invalidate();
		}
	}

	protected override void MouseDownHandler(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left)
		{
			return;
		}
		BJU = e.X;
		BJu = BJk;
		BJV = BJL;
		if (e.Y > 23 && e.Y < Height - 3)
		{
			if (BJU > Width - 3 - BJk - BJL - 10 && BJU < Width - 3 - BJk - BJL + 10)
			{
				BJT = true;
			}
			else if (BJU > Width - 3 - BJL - 10 && BJU < Width - 3 - BJL + 10)
			{
				BJt = true;
			}
			else
			{
				base.MouseDownHandler(sender, e);
			}
		}
		else
		{
			base.MouseDownHandler(sender, e);
		}
	}

	protected override void MouseMoveHandler(object sender, MouseEventArgs e)
	{
		if (BJM != 0 && BJl != 0)
		{
			int num = -1;
			for (int i = 0; i < BJQ.Count; i++)
			{
				if (e.X <= 3 || e.X >= Width - 3 || e.Y <= BJM + i * BJl || e.Y >= BJM + (i + 1) * BJl)
				{
					continue;
				}
				num = i;
				if (BJQ[i].method_6() != null)
				{
					if (PortFunction.smethod_27(BJQ[i].method_6()))
					{
						SettingOrSpecialObject settingOrSpecialObject = BJQ[i].method_6();
						Enum104 bSQ = settingOrSpecialObject.method_12().method_12().BSQ;
						Enum105 bSq = settingOrSpecialObject.method_12().method_12().BSq;
						byte bSR = settingOrSpecialObject.method_12().method_12().BSR;
						ushort bSr = settingOrSpecialObject.method_12().method_12().BSr;
						List<bool> list_ = new List<bool>();
						List<string> list = PortFunction.smethod_45(BJp, bSQ, bSq, bSR, bSr, bool_0: true, list_);
						if (list != null && list.Count == 1)
						{
							BJr = Class333.smethod_497() + list[0] + Class333.smethod_9();
						}
						else
						{
							BJr = string.Empty;
						}
					}
					else if (BJp.aWY.Contains(BJQ[i].method_6()))
					{
						Class244 @class = null;
						foreach (SettingOrSpecialObject item in BJQ[i].method_6().method_1())
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
							string text = PortFunction.smethod_37(PortFunction.smethod_36(BJp, enum104_, enum105_, byte_, ushort_));
							if (text != null)
							{
								BJr = Class333.smethod_497() + text + Class333.smethod_9();
							}
							else
							{
								BJr = string.Empty;
							}
						}
						else
						{
							BJr = string.Empty;
						}
					}
					else
					{
						BJr = string.Empty;
					}
				}
				else
				{
					BJr = string.Empty;
				}
				break;
			}
			if (num == -1)
			{
				BJN = 0;
				BJP.Reset();
				BJr = string.Empty;
				BJn = true;
			}
			else if (!BJo.Enabled)
			{
				BJo.Enabled = true;
			}
			BJm = num;
		}
		if (e.Button == MouseButtons.Left && (BJT || BJt))
		{
			BringToFront();
			int num2 = e.X - BJU;
			if (BJT)
			{
				int val = Width - 6 - BJL - 70;
				BJk = Math.Min(val, Math.Max(BJu - num2, 20));
			}
			else if (BJt)
			{
				int val2 = Width - 6 - BJk - 70;
				BJL = Math.Min(val2, Math.Max(BJV - num2, 20));
			}
			Cursor = Cursors.SizeWE;
			Invalidate();
			return;
		}
		base.MouseMoveHandler(sender, e);
		if (e.Y > 23 && e.Y < Height - 3)
		{
			if (e.X > Width - 3 - BJk - BJL - 10 && e.X < Width - 3 - BJk - BJL + 10)
			{
				Cursor = Cursors.SizeWE;
			}
			else if (e.X > Width - 3 - BJL - 10 && e.X < Width - 3 - BJL + 10)
			{
				Cursor = Cursors.SizeWE;
			}
		}
	}

	protected override void MouseUpHandler(object sender, MouseEventArgs e)
	{
		base.MouseUpHandler(sender, e);
		BJT = false;
		BJt = false;
	}

	protected override void MouseLeaveHandler(object sender, EventArgs e)
	{
		base.MouseLeaveHandler(sender, e);
		BJm = -1;
		BJN = 0;
		BJP.Reset();
		BJr = string.Empty;
		BJn = true;
		if (BJo.Enabled)
		{
			BJo.Enabled = false;
		}
		Invalidate();
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		if (Width - 6 - BJk - BJL < 70)
		{
			BJk = (BJL = (Width - 6 - 70) / 2);
			Invalidate();
		}
	}

	private void method_17(object sender, EventArgs e)
	{
		Dispose();
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_18(object sender, EventArgs e)
	{
		Form38 form = new Form38();
		form.method_1(BJR);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			BJR = form.method_0();
		}
		form.Dispose();
		Invalidate();
	}

	internal void method_19(object sender, EventArgs e)
	{
		List<int> list = new List<int>();
		foreach (Setting item in BJQ)
		{
			list.Add(item.method_64());
		}
		List<int> list2 = Form45.smethod_0(Form23.form23_0, BJp, list, 0);
		if (list2 != null)
		{
			foreach (Setting item2 in BJQ)
			{
				item2.method_265(method_13);
				item2.method_41(method_14);
			}
			BJQ.Clear();
			BJq.Clear();
			bool flag = false;
			foreach (int item3 in list2)
			{
				Setting setting = BJp.method_31(item3);
				if (setting != null)
				{
					BJQ.Add(setting);
					BJq.Add(item3);
					if (!flag)
					{
						setting.method_264(method_13);
						flag = true;
					}
					setting.method_40(method_14);
				}
			}
			method_12();
		}
		Form23.form23_0.control25_0.method_12(bool_0: false);
	}

	private void method_20(object sender, EventArgs e)
	{
		Form22 form = new Form22(BJQ, BJS, BJs);
		if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
		{
			foreach (Setting item in BJQ)
			{
				int index = BJQ.IndexOf(item);
				int int_;
				int int_2;
				if (Form23.dictionary_0.ContainsKey(item.method_64()))
				{
					Class209 @class = Form23.dictionary_0[item.method_64()];
					int_ = @class.int_1;
					int_2 = @class.int_2;
				}
				else
				{
					int_ = item.method_226();
					int_2 = item.method_227();
				}
				Form23.smethod_4(item.method_64(), int_, int_2, form.method_1()[index], form.method_2()[index]);
			}
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
				item.Enabled = BJQ.Count != 0;
			}
			else if (item.Text == Class333.BaV())
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
		toolStripMenuItem.Text = Class333.smethod_512();
		toolStripMenuItem.Click += method_19;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Text = Class333.smethod_1176();
		toolStripMenuItem2.Click += method_20;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
		toolStripMenuItem3.Text = Class333.Bav();
		toolStripMenuItem3.Click += method_18;
		contextMenuStrip.Items.Add(toolStripMenuItem3);
		ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
		toolStripMenuItem4.Text = Class333.BaV();
		toolStripMenuItem4.Click += method_17;
		contextMenuStrip.Items.Add(toolStripMenuItem4);
		return contextMenuStrip;
	}

	internal void method_23(string string_0, int int_3, int int_4)
	{
		List<string> list = new List<string>();
		list.Add(Class333.BaW());
		int num = Left - int_3;
		int num2 = Top - int_4;
		list.Add(Class333.Bad() + num);
		list.Add(Class333.BaE() + num2);
		list.Add(Class333.Bae() + Width);
		list.Add(Class333.BaF() + Height);
		list.Add(Class333.Baw() + BJR);
		list.Add(Class333.BaX() + BJk);
		list.Add(Class333.Bax() + BJL);
		foreach (int item in BJq)
		{
			list.Add(Class333.Baf() + item);
		}
		list.Add(Class333.smethod_102());
		File.AppendAllLines(string_0, list);
	}

	internal void method_24(StreamReader streamReader_0)
	{
		bool flag = false;
		string text;
		while ((text = streamReader_0.ReadLine()) != null)
		{
			if (text.StartsWith(Class333.Baw()))
			{
				BJR = text.Substring(Class333.Baw().Length);
			}
			else if (text.Contains(Class333.BaY()))
			{
				string text2 = text.Substring(text.IndexOf(Class333.BaY()) + Class333.BaY().Length);
				BJR = text2.Substring(1, text2.Length - 2);
			}
			else if (text.StartsWith(Class333.BaX()))
			{
				BJk = int.Parse(text.Substring(Class333.BaX().Length));
			}
			else if (text.Contains(Class333.Bay()))
			{
				BJk = int.Parse(text.Substring(text.IndexOf(Class333.Bay()) + Class333.Bay().Length));
			}
			else if (text.StartsWith(Class333.Bax()))
			{
				BJL = int.Parse(text.Substring(Class333.Bax().Length));
			}
			else if (text.Contains(Class333.BaZ()))
			{
				BJL = int.Parse(text.Substring(text.IndexOf(Class333.BaZ()) + Class333.BaZ().Length));
			}
			else
			{
				if (text.Contains(Class333.Baz()))
				{
					continue;
				}
				if (text.StartsWith(Class333.Baf()))
				{
					int item = int.Parse(text.Substring(Class333.Baf().Length));
					BJq.Add(item);
					Setting setting = BJp.method_31(item);
					if (setting != null)
					{
						BJQ.Add(setting);
						if (!flag)
						{
							setting.method_264(method_13);
							flag = true;
						}
						setting.method_40(method_14);
					}
				}
				else if (text.Contains(Class333.BaI()))
				{
					string text3 = text.Substring(text.IndexOf(Class333.BaI()) + Class333.BaI().Length);
					if (string.IsNullOrEmpty(text3))
					{
						continue;
					}
					string[] array = text3.Split(',');
					for (int i = 0; i < array.Length; i++)
					{
						string text4 = array[i].Trim();
						if (!int.TryParse(text4, out var result))
						{
							string value = text4.Substring(1, text4.Length - 2);
							try
							{
								result = (int)(Enum87)Enum.Parse(typeof(Enum87), value);
							}
							catch
							{
								result = -1;
							}
						}
						if (result != -1)
						{
							BJq.Add(result);
							Setting setting2 = BJp.method_31(result);
							if (setting2 != null)
							{
								BJQ.Add(setting2);
								setting2.method_264(method_13);
								setting2.method_40(method_14);
							}
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
}
