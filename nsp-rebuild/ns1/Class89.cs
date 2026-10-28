using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns3;
using ns4;
using ns6;
using ns7;

namespace ns1;

internal class Class89 : MovableResizablePanel
{
	internal class Class49 : Panel
	{
		private Class89 Bua;

		internal Class49(Class89 class89_0)
		{
			Bua = class89_0;
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			paintEventArgs_0.Graphics.Clear(BackColor);
			int num = (int)Tag;
			try
			{
				if (Bua.BIq.Count > num && Bua.BIq[num] != null)
				{
					paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
					paintEventArgs_0.Graphics.DrawImage(Bua.BIq[num], 2, 2, Width - 4, Height - 4);
					return;
				}
				paintEventArgs_0.Graphics.FillRectangle(Brushes.Black, 2, 2, Width - 4, Height - 4);
				if (!Bua.BIm.awP.method_98())
				{
					return;
				}
				using Font font = new Font(Font.FontFamily, Width / 12);
				using SolidBrush brush = new SolidBrush(Form23.color_12);
				using StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				paintEventArgs_0.Graphics.DrawString(Class333.Bek(), font, brush, new Point(Width / 2, Height / 2), stringFormat);
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.BeL() + ex.Message);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class50
	{
		public Class89 BuB;

		public int Bub;

		internal void method_0()
		{
			BuB.method_28(Bub);
		}
	}

	private const int BIK = 10;

	private const int BIk = 90;

	private const int BIL = 15;

	private const int BIl = 30;

	private const int BIM = 1000;

	private Framework BIm;

	private Class247 BIN;

	private int BIn = -1;

	private bool BIO;

	private int BIo;

	private int BIP;

	private int BIp = -1;

	private Panel BIQ = new Panel();

	private List<Image> BIq = new List<Image>();

	private FileSystemWatcher BIR;

	private bool BIr;

	private System.Timers.Timer BIS;

	private int BIs;

	internal Class89(Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false, bool_2: true)
	{
		BIm = framework_0;
		BIN = BIm.awP;
		BIR = new FileSystemWatcher();
		BIR.Path = Form23.string_13;
		BIR.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.CreationTime;
		BIR.Filter = Class333.aVY();
		BIR.IncludeSubdirectories = false;
		BIR.EnableRaisingEvents = true;
		BIR.Changed += BIR_Created;
		BIR.Created += BIR_Created;
		method_16();
		if (rectangle_0 == Rectangle.Empty)
		{
			int num = Class88.smethod_0(BIm) * 90 / Class88.smethod_1(BIm);
			Width = 15 + 6 * (num + 15) + 15;
			if (BIN.method_79().Count <= 5)
			{
				Height = 130;
			}
			else
			{
				Height = 250;
			}
		}
		else
		{
			Width = rectangle_0.Width;
			Height = rectangle_0.Height;
			Left = rectangle_0.Left;
			Top = rectangle_0.Top;
		}
		BIN.method_80(method_22);
		MouseDown += Class89_MouseDown;
		BIQ.Tag = -1;
		BIQ.BackColor = Color.DodgerBlue;
		BIQ.BorderStyle = BorderStyle.None;
		BIQ.Width = 5;
		BIQ.Height = 90;
		Controls.Add(BIQ);
		BIQ.Visible = false;
		if (BIm.awP.method_98() && Class329.smethod_3())
		{
			Class329.smethod_5();
			Application.DoEvents();
			Class329.smethod_10();
			method_12();
		}
	}

	private void method_12()
	{
		if (BIS != null)
		{
			BIS.Close();
			BIS = null;
		}
		BIs = 0;
		BIS = new System.Timers.Timer();
		BIS.Interval = 1000.0;
		BIS.SynchronizingObject = this;
		BIS.Elapsed += BIS_Elapsed;
		BIS.AutoReset = true;
		BIS.Enabled = true;
		BIS.Start();
	}

	private void BIS_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (BIs < 3)
		{
			if (BIm.awP.method_98())
			{
				Class329.smethod_10();
			}
			BIs++;
		}
		if (BIr)
		{
			try
			{
				method_14(bool_0: true);
			}
			catch
			{
			}
			BIr = false;
		}
	}

	private bool method_13(string string_0)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				return false;
			}
			using FileStream fileStream = new FileInfo(string_0).Open(FileMode.Open, FileAccess.Read, FileShare.None);
			fileStream.Close();
		}
		catch (IOException)
		{
			return true;
		}
		return false;
	}

	private void BIR_Created(object sender, FileSystemEventArgs e)
	{
		if (int.TryParse(Path.GetFileNameWithoutExtension(e.FullPath).Substring(Class333.BAt().Length), out var _) && !method_13(e.FullPath))
		{
			BIr = true;
		}
	}

	internal void method_14(bool bool_0)
	{
		method_46();
		List<Control> list = null;
		if (bool_0)
		{
			while (Controls.Count > 1)
			{
				foreach (Control control4 in Controls)
				{
					if (control4 != BIQ)
					{
						control4.Dispose();
						break;
					}
				}
			}
			for (int num = BIq.Count - 1; num >= 0; num--)
			{
				BIq[num]?.Dispose();
				BIq.RemoveAt(num);
			}
		}
		else if (BIN.method_79().Count != 0)
		{
			list = new List<Control>();
			foreach (Control control5 in Controls)
			{
				if (control5 != BIQ && control5.Tag is int)
				{
					list.Add(control5);
				}
			}
		}
		if (BIN.method_79().Count == 0)
		{
			if (bool_0)
			{
				return;
			}
			while (Controls.Count > 3)
			{
				foreach (Control control6 in Controls)
				{
					if (control6 != BIQ && control6.Tag is int)
					{
						control6.Dispose();
						break;
					}
				}
			}
			for (int num2 = BIq.Count - 1; num2 >= 0; num2--)
			{
				BIq[num2]?.Dispose();
				BIq.RemoveAt(num2);
			}
			return;
		}
		int num3 = 15;
		int num4 = 10;
		int num5 = BIN.method_72().method_256();
		if (num5 == 0 || BIn >= num5)
		{
			BIn = -1;
		}
		int int_ = Class88.smethod_0(BIm) * 90 / Class88.smethod_1(BIm);
		for (int i = 0; i < num5; i++)
		{
			Class49 @class = method_15(i, num3, num4, int_);
			if (num3 + 2 * @class.Width + 15 < Width - 15)
			{
				num3 += @class.Width + 15;
				continue;
			}
			num3 = 15;
			num4 += 120;
		}
		method_21(bool_0, num5, num3, num4, int_);
		if (!bool_0)
		{
			for (int num6 = list.Count - 1; num6 >= 0; num6--)
			{
				list[num6].Dispose();
				list.RemoveAt(num6);
			}
		}
		for (int num7 = BIq.Count - 1; num7 >= num5; num7--)
		{
			BIq[num7]?.Dispose();
			BIq.RemoveAt(num7);
		}
	}

	private Class49 method_15(int int_3, int int_4, int int_5, int int_6)
	{
		method_20(int_3);
		Class49 @class = new Class49(this);
		@class.Tag = int_3;
		@class.BorderStyle = BorderStyle.None;
		if (int_3 == BIn)
		{
			@class.BackColor = Color.DodgerBlue;
		}
		else
		{
			@class.BackColor = Color.White;
		}
		@class.Left = int_4;
		@class.Top = int_5;
		@class.Width = int_6;
		@class.Height = 90;
		@class.DoubleClick += method_29;
		@class.MouseDown += method_33;
		@class.MouseMove += method_34;
		@class.MouseUp += method_35;
		@class.ContextMenuStrip = method_24(int_3);
		Controls.Add(@class);
		@class.BringToFront();
		@class.Refresh();
		string text = BIN.method_79()[int_3].method_18();
		int num = BIN.method_73().method_256();
		string text2 = ((int_3 == num) ? Class333.smethod_530() : Class333.smethod_102());
		Label label = new Label();
		label.AutoSize = false;
		label.Width = @class.Width + 15 - 2;
		label.TextAlign = ContentAlignment.TopCenter;
		label.Tag = int_3;
		label.ForeColor = Form23.color_14;
		if (string.IsNullOrWhiteSpace(text))
		{
			label.Text = Class333.aof() + (int_3 + 1) + text2;
		}
		else
		{
			label.Text = text + text2;
		}
		label.Left = int_4 + 1 - 7;
		label.Top = int_5 + 90 + 5;
		Controls.Add(label);
		label.BringToFront();
		label.Refresh();
		return @class;
	}

	private void method_16()
	{
		Application.DoEvents();
		string[] files = Directory.GetFiles(Form23.string_13);
		BIN.method_72().method_256();
		string[] array = files;
		foreach (string text in array)
		{
			if (!method_13(text) && int.TryParse(Path.GetFileNameWithoutExtension(text).Substring(Class333.BAt().Length), out var result))
			{
				method_18(result, text);
			}
		}
	}

	private Image method_17(Image image_0, Color color_0)
	{
		Bitmap bitmap = new Bitmap(image_0.Width, image_0.Height, PixelFormat.Format32bppArgb);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.Clear(color_0);
		graphics.DrawImage(image_0, new Rectangle(default, image_0.Size), new Rectangle(default, image_0.Size), GraphicsUnit.Pixel);
		return bitmap;
	}

	private void method_18(int int_3, string string_0)
	{
		if (!File.Exists(string_0) || int_3 < 0 || int_3 >= BIN.method_79().Count)
		{
			return;
		}
		try
		{
			FileStream fileStream = File.Open(string_0, FileMode.Open, FileAccess.Read);
			Image image_ = Image.FromStream(fileStream);
			image_ = method_17(image_, Color.Black);
			fileStream.Dispose();
			if (BIq.Count > int_3)
			{
				BIq[int_3].Dispose();
				BIq[int_3] = image_;
			}
			else
			{
				BIq.Add(image_);
			}
			if (InvokeRequired)
			{
				Invoke(() =>
				{
					method_28(int_3);
				});
			}
			else
			{
				method_28(int_3);
			}
		}
		catch (IOException)
		{
		}
		catch (Exception ex2)
		{
			Class23.smethod_3(Class333.BAU() + ex2.Message);
		}
	}

	private MenuNode method_19(int int_3)
	{
		MenuNode result = null;
		for (int i = 0; i < BIm.awR.method_6().Count; i++)
		{
			MenuNode menuNode = BIm.awR.method_6()[i];
			if (menuNode.method_39() == int_3)
			{
				result = menuNode;
				break;
			}
		}
		return result;
	}

	private void method_20(int int_3)
	{
		MenuNode menuNode = method_19(int_3);
		Image image = null;
		if (menuNode != null)
		{
			string string_ = Form23.string_13;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
			defaultInterpolatedStringHandler.AppendLiteral(Class333.BAu());
			defaultInterpolatedStringHandler.AppendFormatted(int_3);
			defaultInterpolatedStringHandler.AppendLiteral(Class333.smethod_2366());
			string text = string_ + defaultInterpolatedStringHandler.ToStringAndClear();
			if (File.Exists(text) && !method_13(text))
			{
				FileStream fileStream = File.Open(text, FileMode.Open, FileAccess.Read);
				image = Image.FromStream(fileStream);
				image = method_17(image, Color.Black);
				fileStream.Dispose();
			}
			else if (BIm.awZ == 21 && !BIm.awP.method_98())
			{
				image = Class288.smethod_1(menuNode.method_80());
			}
		}
		if (BIq.Count > int_3)
		{
			Image image2 = BIq[int_3];
			BIq[int_3] = image;
			image2?.Dispose();
		}
		else
		{
			BIq.Add(image);
		}
	}

	private void method_21(bool bool_0, int int_3, int int_4, int int_5, int int_6)
	{
		Panel panel = null;
		if (!bool_0)
		{
			if (Controls.ContainsKey(Class333.BAV()))
			{
				panel = Controls[Class333.BAV()] as Panel;
			}
		}
		else
		{
			panel = new Panel();
			panel.Name = Class333.BAV();
			panel.BorderStyle = BorderStyle.None;
			panel.Width = int_6;
			panel.Height = 90;
		}
		panel.DoubleClick += method_32;
		panel.Click += method_30;
		panel.Paint += method_23;
		if (int_3 < BIN.method_79().Count)
		{
			panel.Enabled = true;
		}
		else
		{
			BIO = false;
			panel.Enabled = false;
		}
		panel.Left = int_4;
		panel.Top = int_5;
		if (bool_0)
		{
			Controls.Add(panel);
		}
		Label label = null;
		if (!bool_0)
		{
			if (Controls.ContainsKey(Class333.BAv()))
			{
				label = Controls[Class333.BAv()] as Label;
			}
		}
		else
		{
			label = new Label();
			label.Name = Class333.BAv();
			label.AutoSize = false;
			label.Width = int_6;
			label.TextAlign = ContentAlignment.TopCenter;
			label.ForeColor = Form23.color_14;
			label.Text = Class333.BAW() + BIN.method_79().Count + Class333.smethod_9();
		}
		label.Left = int_4;
		label.Top = int_5 + 90 + 5;
		if (bool_0)
		{
			Controls.Add(label);
		}
	}

	public override void UpdateLayout(bool resizingOnly)
	{
		method_14(bool_0: true);
	}

	private void method_22(object sender, EventArgs e)
	{
		method_14(bool_0: true);
	}

	private void method_23(object sender, PaintEventArgs e)
	{
		Panel panel = sender as Panel;
		e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		if (panel.Enabled)
		{
			if (BIO)
			{
				e.Graphics.FillRectangle(Brushes.DodgerBlue, 0, 0, panel.Width, panel.Height);
				e.Graphics.FillRectangle(Brushes.White, 7, 7, panel.Width - 14, panel.Height - 14);
			}
			else
			{
				e.Graphics.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
			}
			using (Pen pen = new Pen(Color.DodgerBlue, 8f))
			{
				e.Graphics.DrawEllipse(pen, panel.Width / 2 - 32, panel.Height / 2 - 32, 64, 64);
			}
			using Pen pen2 = new Pen(Color.DodgerBlue, 5f);
			e.Graphics.DrawLine(pen2, panel.Width / 2, panel.Height / 2 - 15, panel.Width / 2, panel.Height / 2 + 15);
			e.Graphics.DrawLine(pen2, panel.Width / 2 - 15, panel.Height / 2, panel.Width / 2 + 15, panel.Height / 2);
			return;
		}
		e.Graphics.FillRectangle(Brushes.DarkGray, 0, 0, panel.Width, panel.Height);
		using (Pen pen3 = new Pen(Color.Gray, 8f))
		{
			e.Graphics.DrawEllipse(pen3, panel.Width / 2 - 32, panel.Height / 2 - 32, 64, 64);
		}
		using Pen pen4 = new Pen(Color.Gray, 5f);
		e.Graphics.DrawLine(pen4, panel.Width / 2, panel.Height / 2 - 15, panel.Width / 2, panel.Height / 2 + 15);
		e.Graphics.DrawLine(pen4, panel.Width / 2 - 15, panel.Height / 2, panel.Width / 2 + 15, panel.Height / 2);
	}

	private ContextMenuStrip method_24(int int_3)
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip
		{
			BackColor = Form23.color_15,
			ForeColor = Form23.color_12
		};
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem.Tag = int_3;
		toolStripMenuItem.Text = Class333.smethod_544();
		toolStripMenuItem.Font = Font;
		toolStripMenuItem.Click += method_25;
		contextMenuStrip.Items.Add(toolStripMenuItem);
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem2.Tag = int_3;
		toolStripMenuItem2.Text = Class333.smethod_545();
		toolStripMenuItem2.Font = Font;
		toolStripMenuItem2.Click += method_26;
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		return contextMenuStrip;
	}

	private void method_25(object sender, EventArgs e)
	{
		int num = (int)(sender as ToolStripMenuItem).Tag;
		BIN.method_88(num);
	}

	private void method_26(object sender, EventArgs e)
	{
		int num = (int)(sender as ToolStripMenuItem).Tag;
		BIN.method_86(num);
	}

	private void method_27(int int_3)
	{
		foreach (Control control in Controls)
		{
			if (!(control is Panel) || control == BIQ)
			{
				continue;
			}
			if (control.Tag is int)
			{
				if ((int)control.Tag == int_3)
				{
					control.BackColor = Color.DodgerBlue;
				}
				else
				{
					control.BackColor = Color.White;
				}
			}
			else
			{
				control.BackColor = Color.White;
			}
		}
		BIO = false;
		BIn = int_3;
	}

	private void method_28(int int_3)
	{
		foreach (Control control in Controls)
		{
			if (control is Panel && control != BIQ && control.Tag is int && (int)control.Tag == int_3)
			{
				control.Refresh();
			}
		}
		BIO = false;
		BIn = int_3;
	}

	private void method_29(object sender, EventArgs e)
	{
		int int_ = (int)(sender as Class49).Tag;
		Form23.form23_0.control4_0.method_49(int_);
	}

	private void method_30(object sender, EventArgs e)
	{
		method_31();
		Focus();
	}

	private void method_31()
	{
		foreach (Control control in Controls)
		{
			if (control is Panel && control != BIQ)
			{
				if (control.Tag is int)
				{
					control.BackColor = Color.White;
				}
				else
				{
					control.BackColor = Color.DodgerBlue;
				}
			}
		}
		BIn = -1;
		BIO = true;
	}

	internal static void smethod_0(Framework framework_0, int int_3)
	{
		Cursor current = System.Windows.Forms.Cursor.Current;
		System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
		MenuNode menuNode = null;
		for (int i = 0; i < framework_0.awR.method_6().Count; i++)
		{
			MenuNode menuNode2 = framework_0.awR.method_6()[i];
			if (menuNode2.method_39() == int_3)
			{
				menuNode = menuNode2;
				break;
			}
		}
		if (menuNode != null)
		{
			Form30 form = new Form30(menuNode);
			if (form.ShowDialog(Form23.form23_0) == DialogResult.OK)
			{
				Class329.smethod_12();
				if (Form23.smethod_28(framework_0.aXc, bool_53: true))
				{
					Class1.smethod_66(framework_0.aXc, out var _);
				}
				if (Form23.form23_0.control4_0.method_0().method_2().Count != 0)
				{
					Form23.form23_0.control4_0.method_14(bool_7: false, bool_8: true, bool_9: true, bool_10: true);
					Form23.form23_0.control4_0.method_39(bool_7: false);
					if (Form23.framework_0 != null)
					{
						Form23.form23_0.control4_0.method_40(bool_7: false);
					}
				}
				if (framework_0 == Form23.framework_1 && Form23.smethod_28(framework_0.aXc, bool_53: true))
				{
					Form23.form23_0.method_223(null, -1);
				}
				Form23.form23_0.control4_0.method_49(int_3);
			}
			else
			{
				framework_0.awP.method_86(int_3);
			}
			form.Dispose();
		}
		System.Windows.Forms.Cursor.Current = current;
	}

	private void method_32(object sender, EventArgs e)
	{
		int int_ = BIN.method_72().method_256();
		if (BIN.method_82(int_))
		{
			smethod_0(BIm, int_);
		}
	}

	private void method_33(object sender, MouseEventArgs e)
	{
		BIQ.Tag = -1;
		BIQ.Visible = false;
		if (e.Button == MouseButtons.Left)
		{
			BIo = e.X;
			BIP = e.Y;
			int num = (int)(sender as Class49).Tag;
			method_27(num);
			BIp = num;
		}
		Focus();
	}

	private void method_34(object sender, MouseEventArgs e)
	{
		if (BIp == -1)
		{
			return;
		}
		Class49 @class = sender as Class49;
		@class.BringToFront();
		int num = e.X - BIo;
		int num2 = e.Y - BIP;
		@class.Left += num;
		@class.Top += num2;
		Rectangle rectangle = new Rectangle(@class.Left, @class.Top, @class.Width, @class.Height);
		int num3 = 15;
		int num4 = 10;
		int num5 = BIN.method_72().method_256();
		int num6 = Class88.smethod_0(BIm) * 90 / Class88.smethod_1(BIm);
		int num7 = 0;
		while (true)
		{
			if (num7 >= num5)
			{
				return;
			}
			Rectangle rect = new Rectangle(num3 - 15, num4, 15, 90);
			Rectangle rect2 = new Rectangle(num3 + num6, num4, 15, 90);
			if (BIp != num7)
			{
				if (rectangle.IntersectsWith(rect))
				{
					int num8 = num7;
					if (BIp != num8 - 1)
					{
						BIQ.Tag = num8;
					}
					BIQ.Left = num3 - 7 - BIQ.Width / 2;
					BIQ.Top = num4;
					BIQ.Visible = true;
					return;
				}
				if (rectangle.IntersectsWith(rect2))
				{
					break;
				}
			}
			if (num3 + 2 * num6 + 15 < Width - 15)
			{
				num3 += num6 + 15;
			}
			else
			{
				num3 = 15;
				num4 += 120;
			}
			num7++;
		}
		int num9 = num7 + 1;
		if (BIp != num9)
		{
			BIQ.Tag = num9;
		}
		BIQ.Left = num3 + num6 + 7 - BIQ.Width / 2;
		BIQ.Top = num4;
		BIQ.Visible = true;
	}

	private void method_35(object sender, MouseEventArgs e)
	{
		if (BIp == -1)
		{
			return;
		}
		BIQ.Visible = false;
		int num = (int)BIQ.Tag;
		bool flag = false;
		if (num != -1)
		{
			int bIp = BIp;
			if (bIp != num)
			{
				if (num < bIp)
				{
					BIn = num;
				}
				else
				{
					BIn = num - 1;
				}
				BIN.method_87(bIp, BIn);
			}
			else
			{
				flag = true;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			Class49 @class = sender as Class49;
			int num2 = (int)@class.Tag;
			int num3 = 15;
			int num4 = 10;
			int num5 = BIN.method_72().method_256();
			int num6 = Class88.smethod_0(BIm) * 90 / Class88.smethod_1(BIm);
			for (int i = 0; i < num5; i++)
			{
				if (i == num2)
				{
					@class.Left = num3;
					@class.Top = num4;
				}
				if (num3 + 2 * num6 + 15 < Width - 15)
				{
					num3 += num6 + 15;
					continue;
				}
				num3 = 15;
				num4 += 120;
			}
		}
		BIQ.Tag = -1;
		BIp = -1;
	}

	private void Class89_MouseDown(object sender, MouseEventArgs e)
	{
		Focus();
	}

	private void method_36()
	{
		if (BIn != -1)
		{
			Form23.form23_0.control4_0.method_49(BIn);
		}
		else if (BIO)
		{
			method_32(null, null);
		}
	}

	private void method_37()
	{
		int num = BIN.method_72().method_256();
		if (num != 0)
		{
			if (BIO)
			{
				method_27(0);
			}
			else if (BIn != -1)
			{
				if (BIn < num - 1)
				{
					method_27(BIn + 1);
				}
				else if (num < BIN.method_79().Count)
				{
					method_31();
				}
				else
				{
					method_27(0);
				}
			}
			else
			{
				method_27(0);
			}
		}
		else
		{
			method_31();
		}
	}

	private void method_38()
	{
		int num = BIN.method_72().method_256();
		if (num != 0)
		{
			if (BIO)
			{
				method_27(num - 1);
			}
			else if (BIn != -1)
			{
				if (BIn != 0)
				{
					method_27(BIn - 1);
				}
			}
			else
			{
				method_27(0);
			}
		}
		else
		{
			method_31();
		}
	}

	private void method_39()
	{
		int num = BIN.method_72().method_256();
		if (num != 0)
		{
			if (BIO)
			{
				return;
			}
			if (BIn != -1)
			{
				if (BIn < num - 1)
				{
					method_27(BIn + 1);
				}
				else if (num < BIN.method_79().Count)
				{
					method_31();
				}
			}
			else
			{
				method_27(0);
			}
		}
		else
		{
			method_31();
		}
	}

	private void method_40()
	{
		int num = -1;
		if (BIn != -1)
		{
			if (BIN.method_82(BIn + 1))
			{
				num = BIn + 1;
			}
		}
		else
		{
			int num2 = BIN.method_72().method_256();
			if (BIN.method_82(num2))
			{
				num = num2;
			}
		}
		if (num != -1)
		{
			smethod_0(BIm, num);
		}
	}

	private void method_41()
	{
		if (BIn != -1)
		{
			int bIn = BIn;
			BIn = -1;
			BIN.method_86(bIn);
		}
	}

	private void method_42()
	{
		if (BIn != -1 && BIn != 0)
		{
			int bIn = BIn;
			int num = --BIn;
			BIN.method_87(bIn, num);
		}
	}

	private void method_43()
	{
		int num = BIN.method_72().method_256();
		if (BIn != -1 && BIn != num - 1)
		{
			int num2 = BIn + 1;
			int num3 = BIn++;
			BIN.method_87(num2, num3);
		}
	}

	private void method_44()
	{
		BIN.method_89(BIn);
	}

	private void method_45()
	{
		BIN.method_90(BIn);
	}

	protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs previewKeyDownEventArgs_0)
	{
		previewKeyDownEventArgs_0.IsInputKey = previewKeyDownEventArgs_0.KeyData == Keys.Return || previewKeyDownEventArgs_0.KeyData == Keys.Return || previewKeyDownEventArgs_0.KeyData == Keys.Tab || previewKeyDownEventArgs_0.KeyData == Keys.Left || previewKeyDownEventArgs_0.KeyData == Keys.Right || previewKeyDownEventArgs_0.KeyData == Keys.Insert || previewKeyDownEventArgs_0.KeyData == Keys.Delete || previewKeyDownEventArgs_0.KeyData == (Keys.Left | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.Right | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.C | Keys.Control) || previewKeyDownEventArgs_0.KeyData == (Keys.V | Keys.Control);
	}

	protected override void OnKeyDown(KeyEventArgs keyEventArgs_0)
	{
		if (keyEventArgs_0.KeyData != Keys.Return && keyEventArgs_0.KeyData != Keys.Return)
		{
			if (keyEventArgs_0.KeyData == Keys.Tab)
			{
				method_37();
			}
			else if (keyEventArgs_0.KeyData == Keys.Left)
			{
				method_38();
			}
			else if (keyEventArgs_0.KeyData == Keys.Right)
			{
				method_39();
			}
			else if (keyEventArgs_0.KeyData == Keys.Insert)
			{
				method_40();
			}
			else if (keyEventArgs_0.KeyData == Keys.Delete)
			{
				method_41();
			}
			else if (keyEventArgs_0.KeyData == (Keys.Left | Keys.Control))
			{
				method_42();
			}
			else if (keyEventArgs_0.KeyData == (Keys.Right | Keys.Control))
			{
				method_43();
			}
			else if (keyEventArgs_0.KeyData == (Keys.C | Keys.Control))
			{
				method_44();
			}
			else if (keyEventArgs_0.KeyData == (Keys.V | Keys.Control))
			{
				method_45();
			}
		}
		else
		{
			method_36();
		}
	}

	private void method_46()
	{
		try
		{
			foreach (Control control in Controls)
			{
				if (control is Class49)
				{
					control.DoubleClick -= method_29;
					control.MouseDown -= method_33;
					control.MouseMove -= method_34;
					control.MouseUp -= method_35;
					if (control.ContextMenuStrip != null && !control.ContextMenuStrip.IsDisposed && !control.ContextMenuStrip.Disposing)
					{
						foreach (ToolStripMenuItem item in control.ContextMenuStrip.Items)
						{
							item.Click -= method_25;
							item.Click -= method_26;
						}
					}
				}
				control.DoubleClick -= method_32;
				control.Click -= method_30;
				control.Paint -= method_23;
			}
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			BIN.method_81(method_22);
			if (BIS != null)
			{
				BIS.Elapsed -= BIS_Elapsed;
				BIS.Close();
				BIS = null;
			}
			MouseDown -= Class89_MouseDown;
			method_46();
			for (int num = BIq.Count - 1; num >= 0; num--)
			{
				BIq[num]?.Dispose();
				BIq.RemoveAt(num);
			}
			BIR.Changed -= BIR_Created;
			BIR.Created -= BIR_Created;
			BIR.Dispose();
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
