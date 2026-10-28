using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using crc;
using ns0;
using ns2;
using ns3;
using ns5;
using ns7;

namespace ns4;

internal class Form40 : Form
{
	private class Class224
	{
		internal string BqZ;

		internal byte[] Bqz;

		internal bool BRA;
	}

	private class Class225
	{
		internal Class224 BRa;

		internal uint BRB;

		internal Class1.Enum4 BRb;
	}

	internal class Form41 : Form
	{
		private string BRC;

		private string BRc;

		private ThemedTextBox BRD = new ThemedTextBox();

		private int BRd = 50 - Class333.smethod_1469().Length;

		[SpecialName]
		internal string method_0()
		{
			return BRD.Text;
		}

		internal Form41(string string_0, string string_1)
		{
			BRC = string_0;
			BRc = string_1;
			Text = Class333.BdD();
			Font = Form23.form23_0.Font;
			BackColor = Form23.color_10;
			ForeColor = Form23.color_12;
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MinimizeBox = false;
			MaximizeBox = false;
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			BRD.MaxLength = BRd;
			BRD.BackColor = Form23.color_32;
			BRD.ForeColor = Form23.color_12;
			BRD.Text = BRc;
			BRD.Width = 330;
			BRD.Location = new Point(10, 10);
			BRD.TabIndex = 0;
			ThemedButton themedButton = new ThemedButton
			{
				DialogResult = DialogResult.Cancel,
				Text = Class333.smethod_823(),
				Size = new Size(80, 30),
				Location = new Point(260, 45),
				TabIndex = 2
			};
			ThemedButton themedButton2 = new ThemedButton();
			themedButton2.DialogResult = DialogResult.OK;
			themedButton2.Text = Class333.smethod_821();
			themedButton2.Size = new Size(80, 30);
			themedButton2.Location = new Point(themedButton.Left - (10 + themedButton2.Width), 45);
			themedButton2.TabIndex = 1;
			CancelButton = themedButton;
			ClientSize = new Size(350, 85);
			Controls.Add(themedButton2);
			Controls.Add(themedButton);
			Controls.Add(BRD);
		}

		protected override void OnShown(EventArgs eventArgs_0)
		{
			BRD.Focus();
			BRD.SelectAll();
		}

		protected override void OnFormClosing(FormClosingEventArgs formClosingEventArgs_0)
		{
			if (DialogResult != DialogResult.OK)
			{
				return;
			}
			if (string.IsNullOrWhiteSpace(BRD.Text))
			{
				Form54.smethod_6(this, Class333.Bdd(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				formClosingEventArgs_0.Cancel = true;
				return;
			}
			string text = BRc.Substring(BRc.LastIndexOf(Class333.smethod_190()));
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			int num = BRD.Text.IndexOfAny(invalidFileNameChars);
			if (num >= 0)
			{
				Form54.smethod_6(this, Class333.smethod_1341() + BRD.Text[num] + Class333.BdE(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				formClosingEventArgs_0.Cancel = true;
				return;
			}
			if (BRD.Text.Contains(Class333.smethod_190()) && !BRD.Text.EndsWith(text))
			{
				Form54.smethod_6(this, Class333.Bde(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				formClosingEventArgs_0.Cancel = true;
				return;
			}
			string text2 = BRD.Text;
			if (!text2.ToLower().EndsWith(text.ToLower()))
			{
				text2 += text;
			}
			if (File.Exists(BRC + text2))
			{
				Form54.smethod_6(this, Class333.smethod_2354() + BRD.Text + Class333.BdF(), Class333.smethod_2356(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				formClosingEventArgs_0.Cancel = true;
			}
			else if (text2.Length > BRd)
			{
				Form54.smethod_6(this, Class333.Bdf() + BRd + Class333.smethod_2353(), Class333.smethod_1953(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				formClosingEventArgs_0.Cancel = true;
			}
		}
	}

	internal class Class226 : PictureBox
	{
		private const int BRE = 20;

		private Form40 BRe;

		private bool BRF;

		private bool BRf;

		[CompilerGenerated]
		private readonly bool BRG;

		[CompilerGenerated]
		private readonly string BRg = string.Empty;

		internal int BRH;

		[SpecialName]
		[CompilerGenerated]
		internal bool method_0()
		{
			return BRG;
		}

		[SpecialName]
		[CompilerGenerated]
		internal string method_1()
		{
			return BRg;
		}

		internal Class226(Form40 form40_0, bool bool_0, string string_0)
		{
			BRe = form40_0;
			BRG = bool_0;
			BRg = string_0;
		}

		[SpecialName]
		internal bool method_2()
		{
			return BRF;
		}

		[SpecialName]
		internal void method_3(bool bool_0)
		{
			BRF = bool_0;
			Invalidate();
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			if (method_2())
			{
				paintEventArgs_0.Graphics.Clear(Color.DodgerBlue);
			}
			else
			{
				paintEventArgs_0.Graphics.Clear(Color.WhiteSmoke);
			}
			if (BRf)
			{
				using Pen pen = new Pen(Color.DodgerBlue, 2f);
				paintEventArgs_0.Graphics.DrawRectangle(pen, 1, 1, Width - 2, Height - 2);
			}
			base.OnPaint(paintEventArgs_0);
			if (method_2() && method_0())
			{
				using (Pen pen2 = new Pen(Color.Red, 2f))
				{
					paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
					paintEventArgs_0.Graphics.DrawLine(pen2, Width - 22, 2, Width - 2, 22);
					paintEventArgs_0.Graphics.DrawLine(pen2, Width - 22, 22, Width - 2, 2);
				}
			}
		}

		protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
		{
			if (method_2() && method_0())
			{
				if (mouseEventArgs_0.X > Width - 22 && mouseEventArgs_0.Y < 22)
				{
					BRe.method_17();
				}
				else if (mouseEventArgs_0.Y > Height - BRH)
				{
					BRe.method_19();
				}
				else
				{
					base.OnMouseClick(mouseEventArgs_0);
				}
			}
			else
			{
				base.OnMouseClick(mouseEventArgs_0);
			}
		}

		protected override void OnMouseEnter(EventArgs eventArgs_0)
		{
			base.OnMouseEnter(eventArgs_0);
			BRf = true;
			Invalidate();
		}

		protected override void OnMouseLeave(EventArgs eventArgs_0)
		{
			base.OnMouseLeave(eventArgs_0);
			BRf = false;
			Invalidate();
		}
	}

	private const int int_0 = 140;

	private const int int_1 = 80;

	private const int int_2 = 200;

	private const int int_3 = 90;

	private const float float_0 = 8.5f;

	private const int int_4 = 5;

	private const int int_5 = 10;

	private const string string_0 = "Show All ";

	private const string string_1 = "Show Default ";

	private const string string_2 = "Show Custom ";

	private string string_3;

	private string string_4;

	private string string_5;

	private Framework framework_0;

	private bool bool_0;

	private List<string> list_0;

	private Class1.Enum5 enum5_0;

	private string string_6;

	private bool bool_1;

	private string string_7;

	private string string_8;

	private int int_6;

	private Class226 class226_0;

	internal string string_9 = string.Empty;

	internal bool bool_2;

	private BackgroundWorker backgroundWorker_0;

	private BackgroundWorker backgroundWorker_1;

	private static readonly object object_0 = new object();

	private static bool bool_3 = false;

	private IContainer icontainer_0;

	private TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars_0;

	private Panel panel_0;

	private ProgressBar progressBar_0;

	private ThemedButton themedButton_0;

	private ThemedButton themedButton_1;

	private ThemedButton themedButton_2;

	private Panel panel_1;

	private SplitContainer splitContainer_0;

	private Class61 class61_0;

	private TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars_1;

	private PictureBox pictureBox_0;

	private Class131 class131_0;

	private ThemedComboBox themedComboBox_0;

	public Form40(Framework framework_1, bool bool_4, bool bool_5, List<string> list_1, Class1.Enum5 enum5_1)
	{
		method_29();
		Text = Class247.smethod_6(enum5_1) + Class333.smethod_2320();
		BackColor = Form23.color_10;
		ForeColor = Form23.color_12;
		tableLayoutPanelWithThemedScrollBars_0.BackColor = BackColor;
		panel_1.BackColor = BackColor;
		splitContainer_0.BackColor = BackColor;
		splitContainer_0.Panel1.BackColor = BackColor;
		splitContainer_0.Panel2.BackColor = BackColor;
		tableLayoutPanelWithThemedScrollBars_1.BackColor = BackColor;
		panel_0.BackColor = BackColor;
		class61_0.BackColor = Form23.color_16;
		class131_0.BackColor = Form23.color_16;
		framework_0 = framework_1;
		string_3 = Class333.smethod_2321() + Class247.smethod_6(enum5_1);
		string_4 = Class333.smethod_2322() + Class247.smethod_6(enum5_1);
		string_5 = Class333.smethod_2323() + Class247.smethod_6(enum5_1);
		themedComboBox_0.Items.Add(string_3);
		themedComboBox_0.Items.Add(string_4);
		themedComboBox_0.Items.Add(string_5);
		themedComboBox_0.SelectedIndex = 0;
		themedComboBox_0.SelectedIndexChanged += themedComboBox_0_SelectedIndexChanged;
		if (bool_4)
		{
			bool_0 = true;
			themedButton_1.Visible = false;
			themedButton_0.Text = Class333.smethod_719();
		}
		else
		{
			bool_0 = false;
			themedButton_1.Visible = true;
			themedButton_0.Text = Class333.smethod_823();
		}
		list_0 = list_1;
		enum5_0 = enum5_1;
		string_6 = Class247.smethod_7(enum5_1);
		bool_1 = bool_5;
		string_7 = Form23.string_10.Replace(Class333.smethod_176(), Class333.smethod_177()) + Class333.smethod_177() + string_6 + Class333.smethod_177();
		string_8 = Form23.string_3.Replace(Class333.smethod_176(), Class333.smethod_177()) + Class333.smethod_2324() + string_6 + Class333.smethod_177();
	}

	private void Form40_Shown(object sender, EventArgs e)
	{
		method_2();
	}

	private void themedComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (themedComboBox_0.SelectedIndex != -1)
		{
			if ((string)themedComboBox_0.Items[themedComboBox_0.SelectedIndex] == string_5 && !bool_2)
			{
				method_21();
			}
			else if ((string)themedComboBox_0.Items[themedComboBox_0.SelectedIndex] == string_4 && bool_2)
			{
				method_21();
			}
			method_2();
		}
	}

	private bool method_0()
	{
		if (Directory.Exists(string_7))
		{
			if (themedComboBox_0.SelectedIndex != -1 && !((string)themedComboBox_0.Items[themedComboBox_0.SelectedIndex] == string_5))
			{
				return (string)themedComboBox_0.Items[themedComboBox_0.SelectedIndex] == string_3;
			}
			return true;
		}
		return false;
	}

	private bool method_1()
	{
		if (Directory.Exists(string_8))
		{
			if (themedComboBox_0.SelectedIndex != -1 && !((string)themedComboBox_0.Items[themedComboBox_0.SelectedIndex] == string_4))
			{
				return (string)themedComboBox_0.Items[themedComboBox_0.SelectedIndex] == string_3;
			}
			return true;
		}
		return false;
	}

	private void method_2()
	{
		class61_0.SuspendLayout();
		class226_0 = null;
		while (class61_0.Controls.Count != 0)
		{
			if (class61_0.Controls[0] is Class226 @class)
			{
				@class.Click -= method_4;
				@class.DoubleClick -= method_8;
				@class.Image.Dispose();
				@class.Image = null;
				@class.Dispose();
			}
		}
		bool flag = method_0();
		bool flag2 = method_1();
		List<string> list = new List<string>();
		if (flag)
		{
			foreach (string item in list_0)
			{
				string searchPattern = Class333.smethod_2325() + item;
				list.AddRange(Directory.GetFiles(string_7, searchPattern, SearchOption.AllDirectories));
			}
		}
		List<string> list2 = new List<string>();
		if (flag2)
		{
			foreach (string item2 in list_0)
			{
				string searchPattern2 = Class333.smethod_2325() + item2;
				list2.AddRange(Directory.GetFiles(string_8, searchPattern2, SearchOption.AllDirectories));
			}
		}
		Class226 class2 = null;
		for (int i = 0; i < list.Count + list2.Count; i++)
		{
			Class226 class3 = ((i >= list.Count) ? method_3(list2[i - list.Count], bool_4: false, out var bool_) : method_3(list[i], bool_4: true, out bool_));
			if (bool_)
			{
				class2 = class3;
			}
		}
		class61_0.ResumeLayout(performLayout: true);
		if (class2 != null)
		{
			method_4(class2, null);
			return;
		}
		method_5();
		method_6();
	}

	[DllImport("user32")]
	private static extern nint GetWindowDC(nint intptr_0);

	private Class226 method_3(string string_10, bool bool_4, out bool bool_5)
	{
		Class226 @class = new Class226(this, bool_4, string_10);
		@class.BackColor = Color.Transparent;
		@class.Margin = new Padding(10);
		string fileName = Path.GetFileName(string_10);
		SizeF sizeF = default;
		Font font = new Font(Font.FontFamily, 8.5f);
		Image image = null;
		int num = 0;
		int num2 = 0;
		if (enum5_0 == Class1.Enum5.BFH)
		{
			try
			{
				using Stream stream = File.OpenRead(string_10);
				image = Image.FromStream(stream);
			}
			catch
			{
				image = null;
			}
			if (image != null)
			{
				Size size = Class25.smethod_1(image.Size, new Size(140, 140));
				num = size.Width;
				num2 = size.Height;
				int width = ((num >= 80) ? (5 + num + 5) : 90);
				using (Graphics graphics = Graphics.FromHdc(GetWindowDC(Handle)))
				{
					sizeF = graphics.MeasureString(fileName, font, width);
				}
				@class.Width = width;
				@class.Height = 5 + num2 + (int)sizeF.Height + 5;
			}
			else if (IsMp4Path(string_10))
			{
				int width = 150;
				using (Graphics graphics = Graphics.FromHdc(GetWindowDC(Handle)))
				{
					sizeF = graphics.MeasureString(fileName, font, width);
				}
				@class.Width = width;
				@class.Height = 80 + (int)sizeF.Height + 5;
			}
		}
		else if (enum5_0 == Class1.Enum5.BFh)
		{
			int width2 = 210;
			using (Graphics graphics2 = Graphics.FromHdc(GetWindowDC(Handle)))
			{
				sizeF = graphics2.MeasureString(fileName, font, width2);
			}
			@class.Width = width2;
			@class.Height = 95 + (int)sizeF.Height + 5;
		}
		Bitmap image2 = new Bitmap(@class.Width, @class.Height);
		Graphics graphics3 = Graphics.FromImage(image2);
		graphics3.SmoothingMode = SmoothingMode.HighQuality;
		if (enum5_0 == Class1.Enum5.BFH)
		{
			if (image != null)
			{
				int x = @class.Width / 2 - num / 2;
				int y = 5 + (@class.Height - (5 + (int)sizeF.Height + 5)) / 2 - num2 / 2;
				graphics3.DrawImage(image, x, y, num, num2);
			}
			else if (IsMp4Path(string_10))
			{
				graphics3.FillRectangle(Brushes.LightGray, 5, 5, @class.Width - 10, 70);
				graphics3.DrawString("MP4 video", font, Brushes.Black, 10f, 30f);
			}
		}
		else if (enum5_0 == Class1.Enum5.BFh)
		{
			try
			{
				method_28(string_10, graphics3, 18f, @class.Width, 95, bool_4: false);
			}
			catch
			{
			}
		}
		if (sizeF.Width != 0f && sizeF.Height != 0f)
		{
			using StringFormat stringFormat = new StringFormat();
			using SolidBrush brush = new SolidBrush(Color.Black);
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			graphics3.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
			if (sizeF.Height <= graphics3.MeasureString(Class333.smethod_2326(), font).Height * 1.2f)
			{
				graphics3.DrawString(fileName, font, brush, @class.Width / 2, (float)@class.Height - sizeF.Height / 2f, stringFormat);
			}
			else
			{
				graphics3.DrawString(fileName, font, brush, new RectangleF(0f, (float)@class.Height - sizeF.Height, sizeF.Width, sizeF.Height), stringFormat);
			}
			@class.BRH = (int)sizeF.Height;
		}
		@class.Image = image2;
		graphics3.Dispose();
		image?.Dispose();
		font.Dispose();
		@class.Click += method_4;
		@class.DoubleClick += method_8;
		class61_0.Controls.Add(@class);
		bool_5 = false;
		if ((bool_4 && bool_2 && string_10.Replace(Class333.smethod_176(), Class333.smethod_177()).Substring(string_7.Length) == string_9.Replace(Class333.smethod_176(), Class333.smethod_177())) || (!bool_4 && !bool_2 && string_10.Replace(Class333.smethod_176(), Class333.smethod_177()).Substring(string_8.Length) == string_9.Replace(Class333.smethod_176(), Class333.smethod_177())))
		{
			bool_5 = true;
		}
		return @class;
	}

	private void method_4(object sender, EventArgs e)
	{
		Class226 @class = sender as Class226;
		@class.method_3(bool_0: true);
		class226_0 = @class;
		if (@class.method_0())
		{
			string_9 = @class.method_1().Replace(Class333.smethod_176(), Class333.smethod_177()).Substring(string_7.Length);
			bool_2 = true;
		}
		else
		{
			string_9 = @class.method_1().Replace(Class333.smethod_176(), Class333.smethod_177()).Substring(string_8.Length);
			bool_2 = false;
		}
		foreach (Control control in class61_0.Controls)
		{
			if (control is Class226 class2 && class2 != @class)
			{
				class2.method_3(bool_0: false);
			}
		}
		themedButton_1.Enabled = true;
		class61_0.Focus();
		class61_0.ScrollControlIntoView(@class);
		class61_0.method_2();
		method_5();
		method_6();
	}

	private void method_5()
	{
		Bitmap image = new Bitmap(pictureBox_0.Width, pictureBox_0.Height);
		using (Graphics graphics = Graphics.FromImage(image))
		{
			if (bool_1)
			{
				graphics.Clear(pictureBox_0.Parent.BackColor);
				Size size_ = Class25.smethod_1(framework_0.awW.method_178(), pictureBox_0.Size);
				graphics.FillRectangle(Brushes.Black, pictureBox_0.Width / 2 - size_.Width / 2, pictureBox_0.Height / 2 - size_.Height / 2, size_.Width, size_.Height);
				if (class226_0 != null)
				{
					try
					{
						using Stream stream = File.OpenRead(class226_0.method_1());
						using Image image2 = Image.FromStream(stream);
						float num = (float)size_.Width / (float)framework_0.awW.method_178().Width;
						Size size = Class25.smethod_1(new Size((int)((float)image2.Width * num), (int)((float)image2.Height * num)), size_);
						graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
						graphics.SmoothingMode = SmoothingMode.HighQuality;
						graphics.CompositingQuality = CompositingQuality.HighQuality;
						graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
						graphics.DrawImage(image2, pictureBox_0.Width / 2 - size.Width / 2, pictureBox_0.Height / 2 - size.Height / 2, size.Width, size.Height);
					}
					catch (Exception ex)
					{
						Form54.smethod_6(this, Class333.smethod_2327() + class226_0.method_1() + Class333.smethod_2328() + ex.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				graphics.DrawRectangle(Pens.Gray, 1 + pictureBox_0.Width / 2 - size_.Width / 2, 1 + pictureBox_0.Height / 2 - size_.Height / 2, size_.Width - 2, size_.Height - 2);
			}
			else
			{
				for (int i = 0; i < pictureBox_0.Width; i += 15)
				{
					for (int j = 0; j < pictureBox_0.Height; j += 15)
					{
						if (((i & 1) == 1 && (j & 1) == 0) || ((i & 1) == 0 && (j & 1) == 1))
						{
							graphics.FillRectangle(Brushes.White, i, j, 15, 15);
						}
						else
						{
							graphics.FillRectangle(Brushes.WhiteSmoke, i, j, 15, 15);
						}
					}
				}
				if (class226_0 != null)
				{
					try
					{
						if (enum5_0 == Class1.Enum5.BFH)
						{
							if (IsMp4Path(class226_0.method_1()))
							{
								graphics.FillRectangle(Brushes.LightGray, 0, 0, pictureBox_0.Width, pictureBox_0.Height);
								graphics.DrawString("MP4 video", SystemFonts.MessageBoxFont, Brushes.Black, 10f, pictureBox_0.Height / 2f);
							}
							else
							{
								using Stream stream2 = File.OpenRead(class226_0.method_1());
								using Image image3 = Image.FromStream(stream2);
								Size size2 = Class25.smethod_1(image3.Size, pictureBox_0.Size);
								int width = size2.Width;
								int height = size2.Height;
								if (size2 != image3.Size)
								{
									graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
									graphics.SmoothingMode = SmoothingMode.HighQuality;
									graphics.CompositingQuality = CompositingQuality.HighQuality;
									graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
								}
								graphics.DrawImage(image3, pictureBox_0.Width / 2 - width / 2, pictureBox_0.Height / 2 - height / 2, width, height);
							}
						}
						else if (enum5_0 == Class1.Enum5.BFh)
						{
							method_28(class226_0.method_1(), graphics, 22f, pictureBox_0.Width, pictureBox_0.Height, bool_4: true);
						}
					}
					catch (Exception ex2)
					{
						Form54.smethod_6(this, Class333.smethod_2329() + class226_0.method_1() + Class333.smethod_2328() + ex2.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
			}
		}
		if (pictureBox_0.Image != null)
		{
			pictureBox_0.Image.Dispose();
		}
		pictureBox_0.Image = image;
	}

	private void method_6()
	{
		while (class131_0.Controls.Count != 0)
		{
			if (class131_0.Controls[0] is ThemedButton)
			{
				class131_0.Controls[0].Click -= method_16;
				class131_0.Controls[0].Click -= method_18;
				class131_0.Controls[0].Click -= method_15;
			}
			class131_0.Controls[0].Dispose();
		}
		if (string.IsNullOrWhiteSpace(string_9) || class226_0 == null)
		{
			return;
		}
		int num = 10;
		Font font = new Font(Font.FontFamily, 9f);
		ThemedButton themedButton = null;
		ThemedButton themedButton2 = null;
		if (bool_2)
		{
			themedButton = new ThemedButton();
			themedButton.Font = font;
			themedButton.Text = Class333.smethod_2330() + Class247.smethod_5(enum5_0);
			themedButton.Size = new Size(120, 28);
			themedButton.Left = 10;
			themedButton.Top = num;
			class131_0.Controls.Add(themedButton);
			themedButton.Click += method_16;
			themedButton2 = new ThemedButton();
			themedButton2.Font = font;
			themedButton2.Text = Class333.smethod_2331() + Class247.smethod_5(enum5_0);
			themedButton2.Size = new Size(120, 28);
			themedButton2.Left = themedButton.Left + themedButton.Width + 10;
			themedButton2.Top = num;
			class131_0.Controls.Add(themedButton2);
			themedButton2.Click += method_18;
		}
		ThemedButton themedButton3 = new ThemedButton();
		themedButton3.Font = font;
		themedButton3.Text = Class333.smethod_2332() + Class247.smethod_5(enum5_0);
		themedButton3.Size = new Size(120, 28);
		if (bool_2)
		{
			themedButton3.Left = themedButton2.Left + themedButton2.Width + 10;
		}
		else
		{
			themedButton3.Left = 10;
		}
		themedButton3.Top = num;
		class131_0.Controls.Add(themedButton3);
		themedButton3.Click += method_15;
		num += 35;
		Label label = new Label();
		label.AutoSize = true;
		label.Font = font;
		label.Text = Class333.smethod_2333() + string_9;
		label.BackColor = class131_0.BackColor;
		label.ForeColor = Form23.color_12;
		label.Left = 10;
		label.Top = num;
		class131_0.Controls.Add(label);
		num += 20;
		int num2;
		int num3;
		int num4;
		try
		{
			using Stream stream = File.OpenRead(class226_0.method_1());
			num2 = (int)stream.Length;
			if (enum5_0 == Class1.Enum5.BFH)
			{
				using Image image = Image.FromStream(stream);
				num3 = image.Width;
				num4 = image.Height;
			}
			else
			{
				num3 = 0;
				num4 = 0;
			}
		}
		catch
		{
			num2 = 0;
			num3 = 0;
			num4 = 0;
		}
		Label label2 = new Label();
		label2.AutoSize = true;
		label2.Font = font;
		if (num2 != 0)
		{
			label2.Text = Class333.smethod_2334() + Class233.smethod_29(num2, 94) + Class333.smethod_325() + Class233.smethod_35(0, 94, bool_0: true, num2);
		}
		else
		{
			label2.Text = Class333.smethod_2334();
		}
		label2.BackColor = class131_0.BackColor;
		label2.ForeColor = Form23.color_12;
		label2.Left = 10;
		label2.Top = num;
		class131_0.Controls.Add(label2);
		num += 20;
		if (enum5_0 == Class1.Enum5.BFH)
		{
			Label label3 = new Label();
			label3.AutoSize = true;
			label3.Font = font;
			if (num3 != 0 && num4 != 0)
			{
				label3.Text = Class333.smethod_2335() + num3 + Class333.smethod_2336() + num4 + Class333.smethod_2337();
			}
			else
			{
				label3.Text = Class333.smethod_2335();
			}
			label3.BackColor = class131_0.BackColor;
			label3.ForeColor = Form23.color_12;
			label3.Left = 10;
			label3.Top = num;
			class131_0.Controls.Add(label3);
			num += 20;
		}
		Label label4 = new Label();
		label4.AutoSize = true;
		label4.Font = font;
		label4.Text = Class333.smethod_2338() + (bool_2 ? Class333.smethod_2340() : Class333.smethod_2339());
		label4.BackColor = class131_0.BackColor;
		label4.ForeColor = Form23.color_12;
		label4.Left = 10;
		label4.Top = num;
		class131_0.Controls.Add(label4);
		num += 20;
		if (framework_0.awP == null)
		{
			return;
		}
		List<Setting> list = framework_0.awP.method_95(string_9, enum5_0, bool_2);
		Label label5 = new Label
		{
			AutoSize = true,
			Font = font
		};
		if (list.Count != 0)
		{
			label5.Text = Class333.smethod_2341() + Class247.smethod_5(enum5_0) + Class333.smethod_2342();
		}
		else
		{
			label5.Text = Class333.smethod_2341() + Class247.smethod_5(enum5_0) + Class333.smethod_2343();
		}
		label5.BackColor = class131_0.BackColor;
		label5.ForeColor = Form23.color_12;
		label5.Left = 10;
		label5.Top = num;
		class131_0.Controls.Add(label5);
		num += 17;
		foreach (Setting item in list)
		{
			Label label6 = new Label();
			label6.AutoSize = true;
			label6.Font = font;
			label6.Text = Class333.smethod_2209() + item.method_60(Enum96.aYt);
			label6.BackColor = class131_0.BackColor;
			label6.ForeColor = Form23.color_12;
			label6.Left = 10;
			label6.Top = num;
			class131_0.Controls.Add(label6);
			num += 17;
		}
	}

	private void method_7()
	{
		if (!string.IsNullOrWhiteSpace(string_9) && class226_0 != null)
		{
			if (bool_1 && Form23.smethod_28(framework_0.aXc, bool_53: true))
			{
				themedButton_1.Enabled = false;
				if (backgroundWorker_0 == null && backgroundWorker_1 == null)
				{
					backgroundWorker_1 = new BackgroundWorker();
					backgroundWorker_1.WorkerReportsProgress = true;
					backgroundWorker_1.WorkerSupportsCancellation = true;
					backgroundWorker_1.DoWork += backgroundWorker_1_DoWork;
					backgroundWorker_1.ProgressChanged += backgroundWorker_1_ProgressChanged;
					backgroundWorker_1.RunWorkerCompleted += backgroundWorker_1_RunWorkerCompleted;
					backgroundWorker_1.RunWorkerAsync();
				}
			}
			else
			{
				DialogResult = DialogResult.OK;
				Close();
			}
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_2344(), Class333.smethod_2344(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void backgroundWorker_1_DoWork(object sender, DoWorkEventArgs e)
	{
		backgroundWorker_1.ReportProgress(0);
		Invoke(() =>
		{
			progressBar_0.Visible = true;
			progressBar_0.BringToFront();
		});
		string string_ = ((!bool_2) ? (Class333.smethod_1472() + string_9) : (Class333.smethod_1469() + string_9));
		uint uint_ = 0u;
		Setting setting = framework_0.method_31(framework_0.awW.method_182());
		if (setting != null)
		{
			uint_ = (uint)setting.method_256();
		}
		Form23.smethod_24(backgroundWorker_1, 0, 100, string_, -1, uint_, out var string_2);
		e.Result = string_2;
	}

	private void backgroundWorker_1_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		progressBar_0.Value = e.ProgressPercentage;
	}

	private void backgroundWorker_1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		backgroundWorker_1 = null;
		themedButton_1.Enabled = true;
		if (!(e.Result is string text))
		{
			string text2 = Class333.smethod_2345();
			if (!Disposing && !IsDisposed)
			{
				Form54.smethod_6(this, text2, Class333.smethod_14(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				progressBar_0.Visible = false;
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				Form54.smethod_6(Form23.form23_0, text2, Class333.smethod_14(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
		else if (!Disposing && !IsDisposed)
		{
			Form54.smethod_6(this, text, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			progressBar_0.Visible = false;
		}
		else
		{
			Form54.smethod_6(Form23.form23_0, text, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void themedButton_1_Click(object sender, EventArgs e)
	{
		method_7();
	}

	private void method_8(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_4(sender, e);
			method_7();
		}
	}

	private void themedButton_0_Click(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}

	private void Form40_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (backgroundWorker_0 != null)
		{
			e.Cancel = true;
		}
		else if (bool_1 && DialogResult == DialogResult.Cancel && backgroundWorker_1 != null)
		{
			backgroundWorker_1.CancelAsync();
		}
	}

	private void Form40_DragEnter(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			e.Effect = DragDropEffects.Copy;
		}
	}

	private void Form40_DragDrop(object sender, DragEventArgs e)
	{
		try
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			int_6 = array.Length;
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				bool flag = false;
				string extension = Path.GetExtension(text);
				if (!string.IsNullOrWhiteSpace(extension) && extension.StartsWith(Class333.smethod_190()))
				{
					string text2 = extension.Substring(1);
					foreach (string item in list_0)
					{
						if (item.ToLower() == text2.ToLower())
						{
							flag = true;
							break;
						}
					}
				}
				bool flag2 = array.Length > 1;
				if (flag)
				{
					if (!method_9(text, flag2))
					{
						int_6--;
					}
					continue;
				}
				int_6--;
				Form54.smethod_6(this, Class333.smethod_1470() + text + Class333.smethod_2346(), Class333.smethod_2347(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				if (flag2 && i == array.Length - 1)
				{
					method_2();
				}
			}
		}
		catch (Exception ex)
		{
			int_6 = 0;
			Class23.smethod_3(Class333.smethod_2348() + ex.Message);
		}
	}

	private void themedButton_2_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = Class333.smethod_2349();
		openFileDialog.Multiselect = true;
		string text = string.Empty;
		foreach (string item in list_0)
		{
			text = text + Class333.smethod_2325() + item;
			if (list_0.IndexOf(item) != list_0.Count - 1)
			{
				text += Class333.smethod_199();
			}
		}
		openFileDialog.Filter = Class333.smethod_2350() + text;
		if (openFileDialog.ShowDialog(this) == DialogResult.OK)
		{
			int_6 = openFileDialog.FileNames.Length;
			string[] fileNames = openFileDialog.FileNames;
			foreach (string string_ in fileNames)
			{
				if (!method_9(string_, openFileDialog.FileNames.Length > 1))
				{
					int_6--;
				}
			}
		}
		openFileDialog.Dispose();
	}

	private bool method_9(string string_10, bool bool_4)
	{
		string fileName = Path.GetFileName(string_10);
		int num = 50 - Class333.smethod_1469().Length;
		if (fileName.Length > num)
		{
			Form54.smethod_6(this, Class333.smethod_2351() + fileName + Class333.smethod_2352() + num + Class333.smethod_2353(), Class333.smethod_1953(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return false;
		}
		if (File.Exists(string_7 + fileName) && Form54.smethod_9(this, Class333.smethod_2354() + fileName + Class333.smethod_2355(), Class333.smethod_2356(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, new string[2]
		{
			Class333.smethod_2357(),
			bool_4 ? Class333.smethod_2358() : Class333.smethod_823()
		}) == DialogResult.Cancel)
		{
			return false;
		}
		byte[] array;
		try
		{
			array = File.ReadAllBytes(string_10);
		}
		catch (Exception ex)
		{
			Form54.smethod_6(this, Class333.smethod_2359() + fileName + Class333.smethod_2360() + ex.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return false;
		}
		byte[] array2;
		try
		{
			array2 = ((enum5_0 != Class1.Enum5.BFH) ? array : method_11(array, Path.GetExtension(string_10)));
		}
		catch (Exception ex2)
		{
			Form54.smethod_6(this, Class333.smethod_2361() + fileName + Class333.smethod_2360() + ex2.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return false;
		}
		if (enum5_0 == Class1.Enum5.BFH && array2 != array && Form54.smethod_9(this, Class333.smethod_2362() + fileName + Class333.smethod_2363(), Class333.smethod_2364(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, new string[2]
		{
			Class333.smethod_821(),
			bool_4 ? Class333.smethod_2358() : Class333.smethod_823()
		}) == DialogResult.Cancel)
		{
			return false;
		}
		Class224 argument = new Class224
		{
			BqZ = fileName,
			Bqz = array2,
			BRA = bool_4
		};
		themedButton_0.Enabled = false;
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.WorkerReportsProgress = true;
		backgroundWorker.WorkerSupportsCancellation = false;
		backgroundWorker.DoWork += method_12;
		backgroundWorker.ProgressChanged += method_13;
		backgroundWorker.RunWorkerCompleted += method_14;
		backgroundWorker.RunWorkerAsync(argument);
		return true;
	}

	private bool method_10(Image image_0, string string_10)
	{
		string text = string_10.ToLower();
		if (text == ".gif")
		{
			return image_0.RawFormat.Guid == ImageFormat.Gif.Guid;
		}
		if (!(text == Class333.smethod_2365()))
		{
			if (!(text == Class333.smethod_2366()))
			{
				if (!(text == Class333.smethod_2367()) && !(text == Class333.smethod_2368()))
				{
					return false;
				}
				return image_0.RawFormat.Guid == ImageFormat.Jpeg.Guid;
			}
			return image_0.RawFormat.Guid == ImageFormat.Png.Guid;
		}
		return image_0.RawFormat.Guid == ImageFormat.Bmp.Guid;
	}

	private byte[] method_11(byte[] byte_0, string string_10)
	{
		string extension = Path.GetExtension(string_10).ToLowerInvariant();
		if (extension == ".gif")
		{
			using MemoryStream gifStream = new MemoryStream(byte_0);
			using Image gifImage = Image.FromStream(gifStream);
			if (method_10(gifImage, extension))
			{
				return byte_0;
			}
			throw new Exception(Class333.smethod_2369());
		}
		if (extension == ".mp4")
		{
			if (byte_0.Length >= 12 && byte_0[4] == (byte)'f' && byte_0[5] == (byte)'t' && byte_0[6] == (byte)'y' && byte_0[7] == (byte)'p')
			{
				return byte_0;
			}
			throw new Exception(Class333.smethod_2369());
		}
		byte[] result = byte_0;
		using (MemoryStream stream = new MemoryStream(byte_0))
		{
			using Image image = Image.FromStream(stream);
			if (!method_10(image, string_10))
			{
				throw new Exception(Class333.smethod_2369());
			}
			if (image.Width > 2560 || image.Height > 2560)
			{
				int width;
				int height;
				if (image.Width > image.Height)
				{
					width = 2560;
					height = 2560 * image.Height / image.Width;
				}
				else
				{
					height = 2560;
					width = 2560 * image.Width / image.Height;
				}
				using Bitmap bitmap = new Bitmap(width, height);
				using Graphics graphics = Graphics.FromImage(bitmap);
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.DrawImage(image, 0, 0, width, height);
				using MemoryStream memoryStream = new MemoryStream();
				bitmap.Save(memoryStream, image.RawFormat);
				result = memoryStream.ToArray();
			}
		}
		return result;
	}

	private static bool IsMp4Path(string string_10)
	{
		return string.Equals(Path.GetExtension(string_10), ".mp4", StringComparison.OrdinalIgnoreCase);
	}

	private void method_12(object sender, DoWorkEventArgs e)
	{
		lock (object_0)
		{
			backgroundWorker_0 = sender as BackgroundWorker;
			Class224 @class = e.Argument as Class224;
			uint num = 0u;
			Class1.Enum4 enum4_ = Class1.Enum4.BFb;
			if (Form23.smethod_28(framework_0.aXc, bool_53: true))
			{
				Invoke(() =>
				{
					progressBar_0.Visible = true;
					progressBar_0.BringToFront();
				});
				backgroundWorker_0.ReportProgress(0);
				Class10 class2 = new Class10();
				class2.method_3(Class333.smethod_1469() + @class.BqZ);
				class2.uint_0 = (uint)@class.Bqz.Length;
				class2.enum5_0 = enum5_0;
				class2.uint_1 = new global::crc.crc().crc_process(@class.Bqz, 0u, (uint)@class.Bqz.Length, uint.MaxValue, partial: false);
				Class10 class10_ = class2;
				backgroundWorker_0.ReportProgress(10);
				do
				{
					uint num2 = Math.Min(Class1.smethod_74(framework_0.aXc, Enum10.const_14) - 68, (uint)@class.Bqz.Length - num);
					byte[] array = new byte[num2];
					Array.Copy(@class.Bqz, num, array, 0L, num2);
					if (!Class1.smethod_54(framework_0.aXc, class10_, num, array, out enum4_, out var _) || enum4_ != Class1.Enum4.BFC)
					{
						break;
					}
					num += num2;
					backgroundWorker_0.ReportProgress((int)(10L + (long)num * 90L / @class.Bqz.Length));
				}
				while (num < @class.Bqz.Length);
				Thread.Sleep(300);
			}
			Class225 result = new Class225
			{
				BRa = @class,
				BRB = num,
				BRb = enum4_
			};
			e.Result = result;
			int_6--;
			if (int_6 <= 0 || !@class.BRA)
			{
				backgroundWorker_0 = null;
			}
		}
	}

	private void method_13(object sender, ProgressChangedEventArgs e)
	{
		progressBar_0.Value = e.ProgressPercentage;
	}

	private void method_14(object sender, RunWorkerCompletedEventArgs e)
	{
		themedButton_0.Enabled = true;
		Class225 @class = e.Result as Class225;
		bool flag;
		if (flag = int_6 <= 0 || !@class.BRa.BRA)
		{
			progressBar_0.Visible = false;
		}
		if (@class.BRB != @class.BRa.Bqz.Length && Form23.smethod_28(framework_0.aXc, bool_53: true))
		{
			Form54.smethod_6(this, Class333.smethod_2370() + @class.BRa.BqZ + Class333.smethod_2371() + Class1.smethod_50(@class.BRb) + Class333.smethod_9(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			if (Form23.smethod_20(Form23.string_10, @class.BRa.BqZ, @class.BRa.Bqz, string_6, out var string_))
			{
				string_9 = @class.BRa.BqZ;
				bool_2 = true;
			}
			else
			{
				Form54.smethod_6(this, string_, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			Form23.smethod_18(framework_0, @class.BRa.BqZ, @class.BRa.Bqz, string_6, out string_);
		}
		if (flag)
		{
			method_2();
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		if (class226_0 == null)
		{
			return;
		}
		string text = null;
		string text2 = null;
		try
		{
			text = Path.GetExtension(class226_0.method_1());
			text2 = Path.GetFileName(class226_0.method_1());
		}
		catch (Exception ex)
		{
			Form54.smethod_6(this, ex.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Title = Class333.smethod_2372();
		saveFileDialog.Filter = text + Class333.smethod_2373() + text;
		saveFileDialog.FileName = text2;
		if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
		{
			try
			{
				File.Copy(class226_0.method_1(), saveFileDialog.FileName);
			}
			catch (Exception ex2)
			{
				Form54.smethod_6(this, Class333.smethod_2374() + ex2.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		saveFileDialog.Dispose();
	}

	private void method_16(object sender, EventArgs e)
	{
		method_17();
	}

	private void method_17()
	{
		if (class226_0 == null)
		{
			return;
		}
		if (class226_0.method_0())
		{
			string text = string_9;
			List<Setting> list = framework_0.awP.method_95(string_9, enum5_0, bool_0: true);
			string text2 = string.Empty;
			if (list.Count != 0)
			{
				text2 = Class333.smethod_2375();
				foreach (Setting item in list)
				{
					text2 = text2 + Class333.smethod_2376() + item.method_60(Enum96.aYt);
				}
			}
			if (Form54.smethod_8(this, Class333.smethod_2377() + text + Class333.smethod_2378() + text2, Class333.smethod_2153(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				return;
			}
			Class1.Enum4 enum4_ = Class1.Enum4.BFb;
			bool flag;
			if (flag = Form23.smethod_28(framework_0.aXc, bool_53: true))
			{
				byte[] array;
				try
				{
					array = File.ReadAllBytes(class226_0.method_1());
				}
				catch (Exception ex)
				{
					Form54.smethod_6(this, Class333.smethod_2379() + ex.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				Class10 @class = new Class10();
				@class.method_3(Class333.smethod_1469() + text);
				@class.uint_0 = (uint)array.Length;
				@class.enum5_0 = enum5_0;
				@class.uint_1 = new global::crc.crc().crc_process(array, 0u, (uint)array.Length, uint.MaxValue, partial: false);
				Class10 class10_ = @class;
				if (!Class1.smethod_56(framework_0.aXc, class10_, out enum4_, out var _))
				{
					enum4_ = Class1.Enum4.BFb;
				}
			}
			if (enum4_ != Class1.Enum4.BFC && enum4_ != Class1.Enum4.BFG && flag)
			{
				Form54.smethod_6(this, Class333.smethod_2381() + Class1.smethod_50(enum4_) + Class333.smethod_9(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			method_21();
			try
			{
				File.Delete(class226_0.method_1());
			}
			catch (Exception ex2)
			{
				Form54.smethod_6(this, Class333.smethod_2380() + class226_0.method_1() + Class333.smethod_2328() + ex2.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			foreach (Setting item2 in list)
			{
				item2.method_262(string.Empty, bool_0: true);
			}
			method_2();
			class61_0.Focus();
			Form23.smethod_16(framework_0, text, string_6, out var _);
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_2382(), Class333.smethod_2383(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void method_18(object sender, EventArgs e)
	{
		method_19();
	}

	private void method_19()
	{
		if (class226_0 == null)
		{
			return;
		}
		if (class226_0.method_0())
		{
			string text = string_9;
			string text2 = class226_0.method_1();
			List<Setting> list = framework_0.awP.method_95(text, enum5_0, bool_0: true);
			if (method_20(text, out var string_) == DialogResult.Cancel)
			{
				return;
			}
			string text3 = text2.Substring(0, text2.IndexOf(text)) + string_;
			Class1.Enum4 enum4_ = Class1.Enum4.BFb;
			bool flag;
			if (flag = Form23.smethod_28(framework_0.aXc, bool_53: true))
			{
				byte[] array;
				try
				{
					array = File.ReadAllBytes(text2);
				}
				catch (Exception ex)
				{
					Form54.smethod_6(this, Class333.smethod_2379() + ex.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				Class10 @class = new Class10();
				@class.method_3(Class333.smethod_1469() + text);
				@class.uint_0 = (uint)array.Length;
				@class.enum5_0 = enum5_0;
				@class.uint_1 = new global::crc.crc().crc_process(array, 0u, (uint)array.Length, uint.MaxValue, partial: false);
				Class10 class2 = @class;
				Class10 class3 = new Class10();
				class3.method_3(Class333.smethod_1469() + string_);
				class3.uint_0 = class2.uint_0;
				class3.enum5_0 = class2.enum5_0;
				class3.uint_1 = class2.uint_1;
				Class10 class10_ = class3;
				if (!Class1.smethod_55(framework_0.aXc, class2, class10_, out enum4_, out var _))
				{
					enum4_ = Class1.Enum4.BFb;
				}
			}
			if (enum4_ != Class1.Enum4.BFC && flag)
			{
				Form54.smethod_6(this, Class333.smethod_2385() + Class1.smethod_50(enum4_) + Class333.smethod_9(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			method_21();
			try
			{
				File.Move(text2, text3);
				string_9 = string_;
				bool_2 = true;
			}
			catch (Exception ex2)
			{
				Form54.smethod_6(this, Class333.smethod_2384() + text2 + Class333.smethod_2011() + text3 + Class333.smethod_2328() + ex2.Message, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			foreach (Setting item in list)
			{
				item.method_262(Class333.smethod_1469() + string_, bool_0: true);
			}
			method_2();
			class61_0.Focus();
			Form23.smethod_17(framework_0, text, string_, string_6, out var _);
		}
		else
		{
			Form54.smethod_6(this, Class333.smethod_2386(), Class333.smethod_2387(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private DialogResult method_20(string string_10, out string string_11)
	{
		Form41 form = new Form41(string_7, string_10);
		DialogResult result = form.ShowDialog(this);
		string text = string_10.Substring(string_10.LastIndexOf(Class333.smethod_190()));
		string_11 = form.method_0();
		if (!string_11.ToLower().EndsWith(text.ToLower()))
		{
			string_11 += text;
		}
		form.Dispose();
		return result;
	}

	private void class61_0_Click(object sender, EventArgs e)
	{
		class226_0 = null;
		foreach (Control control in class61_0.Controls)
		{
			if (control is Class226 @class)
			{
				@class.method_3(bool_0: false);
			}
		}
		method_21();
		class61_0.Focus();
	}

	private void method_21()
	{
		string_9 = string.Empty;
		bool_2 = false;
		themedButton_1.Enabled = false;
		method_5();
		method_6();
	}

	private void class61_0_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
	{
		if (class61_0.Controls.Count == 0)
		{
			return;
		}
		e.IsInputKey = true;
		if (e.KeyData == Keys.Escape)
		{
			method_22();
		}
		else if ((e.KeyData == Keys.Return || e.KeyData == Keys.Return) && !string.IsNullOrWhiteSpace(string_9))
		{
			themedButton_1_Click(null, null);
		}
		else if (e.KeyData == Keys.Delete && !string.IsNullOrWhiteSpace(string_9))
		{
			method_16(null, null);
		}
		else if (e.KeyData != Keys.Tab && e.KeyData != Keys.Right)
		{
			if (e.KeyData != (Keys.Tab | Keys.Shift) && e.KeyData != Keys.Left)
			{
				if (e.KeyData == Keys.Down)
				{
					method_26();
				}
				else if (e.KeyData == Keys.Up)
				{
					method_25();
				}
			}
			else
			{
				method_23();
			}
		}
		else
		{
			method_24();
		}
	}

	private void method_22()
	{
		if (string.IsNullOrWhiteSpace(string_9))
		{
			themedButton_0_Click(null, null);
		}
		else
		{
			class61_0_Click(null, null);
		}
	}

	private void method_23()
	{
		if (string.IsNullOrWhiteSpace(string_9))
		{
			if (class61_0.Controls.Count != 0)
			{
				method_4(class61_0.Controls[0], null);
			}
		}
		else if (class226_0 != null)
		{
			int num = class61_0.Controls.IndexOf(class226_0);
			int index = ((num <= 0) ? (class61_0.Controls.Count - 1) : (num - 1));
			method_4(class61_0.Controls[index], null);
		}
	}

	private void method_24()
	{
		if (string.IsNullOrWhiteSpace(string_9))
		{
			if (class61_0.Controls.Count != 0)
			{
				method_4(class61_0.Controls[0], null);
			}
		}
		else if (class226_0 != null)
		{
			int num = class61_0.Controls.IndexOf(class226_0);
			int index = ((num < class61_0.Controls.Count - 1) ? (num + 1) : 0);
			method_4(class61_0.Controls[index], null);
		}
	}

	private void method_25()
	{
		if (string.IsNullOrWhiteSpace(string_9))
		{
			if (class61_0.Controls.Count != 0)
			{
				method_4(class61_0.Controls[0], null);
			}
		}
		else
		{
			if (class226_0 == null)
			{
				return;
			}
			int num = class61_0.Controls.IndexOf(class226_0);
			int index = -1;
			bool flag = false;
			if (num > 0)
			{
				int num2 = num - 1;
				while (num2 >= 0)
				{
					if (class61_0.Controls[num2].Top >= class226_0.Top)
					{
						num2--;
						continue;
					}
					flag = true;
					index = num2;
					int num3 = num2;
					while (num3 >= 0 && class61_0.Controls[num3].Top == class61_0.Controls[num2].Top)
					{
						if (!method_27(class61_0.Controls[num3], class226_0))
						{
							num3--;
							continue;
						}
						index = num3;
						break;
					}
					break;
				}
			}
			if (!flag)
			{
				index = class61_0.Controls.Count - 1;
			}
			method_4(class61_0.Controls[index], null);
		}
	}

	private void method_26()
	{
		if (string.IsNullOrWhiteSpace(string_9))
		{
			if (class61_0.Controls.Count != 0)
			{
				method_4(class61_0.Controls[0], null);
			}
		}
		else
		{
			if (class226_0 == null)
			{
				return;
			}
			int num = class61_0.Controls.IndexOf(class226_0);
			int index = -1;
			bool flag = false;
			if (num < class61_0.Controls.Count - 1)
			{
				for (int i = num + 1; i < class61_0.Controls.Count; i++)
				{
					if (class61_0.Controls[i].Top <= class226_0.Top)
					{
						continue;
					}
					flag = true;
					index = i;
					for (int j = i; j < class61_0.Controls.Count && class61_0.Controls[j].Top == class61_0.Controls[i].Top; j++)
					{
						if (method_27(class61_0.Controls[j], class226_0))
						{
							index = j;
							break;
						}
					}
					break;
				}
			}
			if (!flag)
			{
				index = 0;
			}
			method_4(class61_0.Controls[index], null);
		}
	}

	private bool method_27(Control control_0, Control control_1)
	{
		if ((control_0.Left >= control_1.Left && control_0.Left <= control_1.Right) || (control_0.Right >= control_1.Left && control_0.Right <= control_1.Right) || (control_1.Left >= control_0.Left && control_1.Left <= control_0.Right))
		{
			return true;
		}
		if (control_1.Right >= control_0.Left)
		{
			return control_1.Right <= control_0.Right;
		}
		return false;
	}

	private void Form40_Resize(object sender, EventArgs e)
	{
		method_5();
	}

	private void splitContainer_0_SplitterMoved(object sender, SplitterEventArgs e)
	{
		method_5();
	}

	private void method_28(string string_10, Graphics graphics_0, float float_1, int int_7, int int_8, bool bool_4)
	{
		string text = Form23.string_3 + Class333.smethod_2388();
		if (!bool_3)
		{
			try
			{
				if (Directory.Exists(text))
				{
					Directory.Delete(text, recursive: true);
				}
				bool_3 = true;
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.smethod_2389() + text + Class333.smethod_1802() + ex.Message);
			}
		}
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		string text2 = text + Path.GetFileName(string_10);
		if (File.Exists(text2))
		{
			byte[] array = File.ReadAllBytes(string_10);
			uint num = new global::crc.crc().crc_process(array, 0u, (uint)array.Length, uint.MaxValue, partial: false);
			byte[] array2 = File.ReadAllBytes(text2);
			uint num2 = new global::crc.crc().crc_process(array2, 0u, (uint)array2.Length, uint.MaxValue, partial: false);
			if (num != num2)
			{
				int num3 = 1;
				do
				{
					num3++;
					text2 = text + Path.GetFileNameWithoutExtension(string_10) + Class333.smethod_100() + num3 + Path.GetExtension(string_10);
				}
				while (File.Exists(text2));
				File.Copy(string_10, text2);
			}
		}
		else
		{
			File.Copy(string_10, text2);
		}
		using PrivateFontCollection privateFontCollection = new PrivateFontCollection();
		privateFontCollection.AddFontFile(text2);
		using Font font = new Font(privateFontCollection.Families[0], float_1);
		using StringFormat stringFormat = new StringFormat();
		stringFormat.Alignment = StringAlignment.Center;
		stringFormat.LineAlignment = StringAlignment.Center;
		graphics_0.SmoothingMode = SmoothingMode.HighQuality;
		graphics_0.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics_0.CompositingQuality = CompositingQuality.HighQuality;
		graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
		if (bool_4)
		{
			graphics_0.DrawString(Class333.smethod_2390(), font, Brushes.Black, int_7 / 2, (float)int_8 * 0.166f, stringFormat);
			graphics_0.DrawString(Class333.smethod_2391(), font, Brushes.Black, int_7 / 2, (float)int_8 * 0.333f, stringFormat);
			graphics_0.DrawString(Class333.smethod_2392(), font, Brushes.Black, int_7 / 2, (float)int_8 * 0.5f, stringFormat);
			graphics_0.DrawString(Class333.smethod_2393(), font, Brushes.Black, int_7 / 2, (float)int_8 * 0.666f, stringFormat);
			graphics_0.DrawString(Class333.smethod_2394(), font, Brushes.Black, int_7 / 2, (float)int_8 * 0.833f, stringFormat);
		}
		else
		{
			graphics_0.DrawString(Class333.smethod_2395(), font, Brushes.Black, int_7 / 2, (float)int_8 * 0.22f, stringFormat);
			graphics_0.DrawString(Class333.smethod_2396(), font, Brushes.Black, int_7 / 2, (float)int_8 * 0.55f, stringFormat);
			graphics_0.DrawString(Class333.smethod_2394(), font, Brushes.Black, int_7 / 2, (float)int_8 * 0.88f, stringFormat);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_29()
	{
		tableLayoutPanelWithThemedScrollBars_0 = new TableLayoutPanelWithThemedScrollBars();
		panel_0 = new Panel();
		progressBar_0 = new ProgressBar();
		themedButton_0 = new ThemedButton();
		themedComboBox_0 = new ThemedComboBox();
		themedButton_1 = new ThemedButton();
		themedButton_2 = new ThemedButton();
		panel_1 = new Panel();
		splitContainer_0 = new SplitContainer();
		class61_0 = new Class61();
		tableLayoutPanelWithThemedScrollBars_1 = new TableLayoutPanelWithThemedScrollBars();
		pictureBox_0 = new PictureBox();
		class131_0 = new Class131();
		tableLayoutPanelWithThemedScrollBars_0.SuspendLayout();
		panel_0.SuspendLayout();
		panel_1.SuspendLayout();
		((ISupportInitialize)splitContainer_0).BeginInit();
		splitContainer_0.Panel1.SuspendLayout();
		splitContainer_0.Panel2.SuspendLayout();
		splitContainer_0.SuspendLayout();
		tableLayoutPanelWithThemedScrollBars_1.SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		tableLayoutPanelWithThemedScrollBars_0.ColumnCount = 1;
		tableLayoutPanelWithThemedScrollBars_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanelWithThemedScrollBars_0.Controls.Add(panel_0, 0, 1);
		tableLayoutPanelWithThemedScrollBars_0.Controls.Add(panel_1, 0, 0);
		tableLayoutPanelWithThemedScrollBars_0.Dock = DockStyle.Fill;
		tableLayoutPanelWithThemedScrollBars_0.Location = new Point(0, 0);
		tableLayoutPanelWithThemedScrollBars_0.Name = Class333.smethod_837();
		tableLayoutPanelWithThemedScrollBars_0.RowCount = 2;
		tableLayoutPanelWithThemedScrollBars_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanelWithThemedScrollBars_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));
		tableLayoutPanelWithThemedScrollBars_0.Size = new Size(1084, 621);
		tableLayoutPanelWithThemedScrollBars_0.TabIndex = 8;
		panel_0.Controls.Add(themedComboBox_0);
		panel_0.Controls.Add(progressBar_0);
		panel_0.Controls.Add(themedButton_0);
		panel_0.Controls.Add(themedButton_1);
		panel_0.Controls.Add(themedButton_2);
		panel_0.Dock = DockStyle.Fill;
		panel_0.Location = new Point(0, 571);
		panel_0.Margin = new Padding(0);
		panel_0.Name = Class333.smethod_838();
		panel_0.Size = new Size(1084, 50);
		panel_0.TabIndex = 0;
		progressBar_0.Location = new Point(230, 13);
		progressBar_0.Name = Class333.smethod_1148();
		progressBar_0.Size = new Size(200, 22);
		progressBar_0.Step = 1;
		progressBar_0.Style = ProgressBarStyle.Continuous;
		progressBar_0.TabIndex = 6;
		progressBar_0.Visible = false;
		themedButton_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		themedButton_0.DialogResult = DialogResult.Cancel;
		themedButton_0.Location = new Point(972, 9);
		themedButton_0.Name = Class333.smethod_830();
		themedButton_0.Size = new Size(100, 30);
		themedButton_0.TabIndex = 3;
		themedButton_0.Text = Class333.smethod_823();
		themedButton_0.UseVisualStyleBackColor = true;
		themedButton_0.Click += themedButton_0_Click;
		themedButton_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		themedButton_1.Enabled = false;
		themedButton_1.Location = new Point(777, 9);
		themedButton_1.Name = Class333.smethod_2397();
		themedButton_1.Size = new Size(160, 30);
		themedButton_1.TabIndex = 2;
		themedButton_1.Text = Class333.smethod_2398();
		themedButton_1.UseVisualStyleBackColor = true;
		themedButton_1.Click += themedButton_1_Click;
		themedButton_2.Location = new Point(12, 9);
		themedButton_2.Name = Class333.smethod_2399();
		themedButton_2.Size = new Size(180, 30);
		themedButton_2.TabIndex = 0;
		themedButton_2.Text = Class333.smethod_2400();
		themedButton_2.UseVisualStyleBackColor = true;
		themedButton_2.Click += themedButton_2_Click;
		panel_1.Controls.Add(splitContainer_0);
		panel_1.Dock = DockStyle.Fill;
		panel_1.Location = new Point(0, 0);
		panel_1.Margin = new Padding(0);
		panel_1.Name = Class333.smethod_2401();
		panel_1.Size = new Size(1084, 571);
		panel_1.TabIndex = 1;
		splitContainer_0.Dock = DockStyle.Fill;
		splitContainer_0.Location = new Point(0, 0);
		splitContainer_0.Margin = new Padding(0);
		splitContainer_0.Name = Class333.smethod_2402();
		splitContainer_0.Orientation = Orientation.Horizontal;
		splitContainer_0.Panel1.Controls.Add(class61_0);
		splitContainer_0.Panel1.Padding = new Padding(10);
		splitContainer_0.Panel1MinSize = 100;
		splitContainer_0.Panel2.Controls.Add(tableLayoutPanelWithThemedScrollBars_1);
		splitContainer_0.Panel2MinSize = 100;
		splitContainer_0.Size = new Size(1084, 571);
		splitContainer_0.SplitterDistance = 308;
		splitContainer_0.SplitterWidth = 3;
		splitContainer_0.TabIndex = 5;
		splitContainer_0.SplitterMoved += splitContainer_0_SplitterMoved;
		class61_0.AutoScroll = true;
		class61_0.BackColor = Color.White;
		class61_0.BorderStyle = BorderStyle.FixedSingle;
		class61_0.Dock = DockStyle.Fill;
		class61_0.Location = new Point(10, 10);
		class61_0.Margin = new Padding(0);
		class61_0.Name = Class333.smethod_2403();
		class61_0.Size = new Size(1064, 288);
		class61_0.TabIndex = 4;
		class61_0.TabStop = true;
		class61_0.Click += class61_0_Click;
		class61_0.PreviewKeyDown += class61_0_PreviewKeyDown;
		tableLayoutPanelWithThemedScrollBars_1.ColumnCount = 2;
		tableLayoutPanelWithThemedScrollBars_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60f));
		tableLayoutPanelWithThemedScrollBars_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
		tableLayoutPanelWithThemedScrollBars_1.Controls.Add(pictureBox_0, 0, 0);
		tableLayoutPanelWithThemedScrollBars_1.Controls.Add(class131_0, 1, 0);
		tableLayoutPanelWithThemedScrollBars_1.Dock = DockStyle.Fill;
		tableLayoutPanelWithThemedScrollBars_1.Location = new Point(0, 0);
		tableLayoutPanelWithThemedScrollBars_1.Margin = new Padding(0);
		tableLayoutPanelWithThemedScrollBars_1.Name = Class333.smethod_2404();
		tableLayoutPanelWithThemedScrollBars_1.RowCount = 1;
		tableLayoutPanelWithThemedScrollBars_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanelWithThemedScrollBars_1.Size = new Size(1084, 260);
		tableLayoutPanelWithThemedScrollBars_1.TabIndex = 0;
		pictureBox_0.BackColor = Color.White;
		pictureBox_0.BorderStyle = BorderStyle.None;
		pictureBox_0.Dock = DockStyle.Fill;
		pictureBox_0.ErrorImage = null;
		pictureBox_0.InitialImage = null;
		pictureBox_0.Location = new Point(10, 10);
		pictureBox_0.Margin = new Padding(10);
		pictureBox_0.Name = Class333.smethod_2405();
		pictureBox_0.Size = new Size(630, 240);
		pictureBox_0.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox_0.TabIndex = 1;
		pictureBox_0.TabStop = false;
		class131_0.AutoScroll = true;
		class131_0.BackColor = Color.White;
		class131_0.BorderStyle = BorderStyle.FixedSingle;
		class131_0.Dock = DockStyle.Fill;
		class131_0.Location = new Point(660, 10);
		class131_0.Margin = new Padding(10);
		class131_0.Name = Class333.smethod_2406();
		class131_0.Size = new Size(414, 240);
		class131_0.TabIndex = 6;
		themedComboBox_0.DrawMode = DrawMode.OwnerDrawFixed;
		themedComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		themedComboBox_0.FormattingEnabled = true;
		themedComboBox_0.Location = new Point(505, 13);
		themedComboBox_0.Margin = new Padding(0);
		themedComboBox_0.Name = Class333.smethod_1015();
		themedComboBox_0.Size = new Size(200, 23);
		themedComboBox_0.TabIndex = 1;
		AllowDrop = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = themedButton_0;
		ClientSize = new Size(1084, 621);
		Controls.Add(tableLayoutPanelWithThemedScrollBars_0);
		Font = new Font(Class333.smethod_145(), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		MinimizeBox = false;
		MinimumSize = new Size(900, 500);
		Name = Class333.smethod_2407();
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = Class333.smethod_2408();
		FormClosing += Form40_FormClosing;
		Shown += Form40_Shown;
		DragDrop += Form40_DragDrop;
		DragEnter += Form40_DragEnter;
		Resize += Form40_Resize;
		tableLayoutPanelWithThemedScrollBars_0.ResumeLayout(performLayout: false);
		panel_0.ResumeLayout(performLayout: false);
		panel_0.PerformLayout();
		panel_1.ResumeLayout(performLayout: false);
		splitContainer_0.Panel1.ResumeLayout(performLayout: false);
		splitContainer_0.Panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)splitContainer_0).EndInit();
		splitContainer_0.ResumeLayout(performLayout: false);
		tableLayoutPanelWithThemedScrollBars_1.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void method_30()
	{
		progressBar_0.Visible = true;
		progressBar_0.BringToFront();
	}

	[CompilerGenerated]
	private void method_31()
	{
		progressBar_0.Visible = true;
		progressBar_0.BringToFront();
	}
}
