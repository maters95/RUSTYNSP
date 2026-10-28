using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using NSP.Resources;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns2;
using ns4;
using ns6;
using ns7;

namespace ns1;

internal class Control14 : Control11
{
	private delegate void Delegate58(object sender, EventArgs e);

	private delegate void Delegate59(object sender, EventArgs e);

	internal const int Bmj = 158;

	internal const int BmK = 220;

	internal const int Bmk = 320;

	internal const int BmL = 100;

	internal const int Bml = 70;

	internal const int BmM = 240;

	private Label Bmm = new Label();

	private ThemedButton BmN = new ThemedButton();

	private ThemedButton Bmn = new ThemedButton();

	private PictureBox BmO;

	private string Bmo = string.Empty;

	private Class286 BmP;

	private bool Bmp;

	private bool BmQ;

	private string Bmq = string.Empty;

	internal Control14(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3, Class286 class286_0, bool bool_2, bool bool_3)
	{
		method_2(dataIdAndAttrId_1, framework_2, framework_3, class286_0, bool_2, bool_3);
	}

	private void method_2(DataIdAndAttrId dataIdAndAttrId_1, Framework framework_2, Framework framework_3, Class286 class286_0, bool bool_2, bool bool_3)
	{
		vmethod_0(framework_2, framework_3);
		vmethod_1(dataIdAndAttrId_1);
		BmP = class286_0;
		if (BmP != null)
		{
			BmQ = bool_2;
			Bmp = bool_3;
			int[] array = BmP.method_3(setting_0);
			if (array != null)
			{
				Encoding encoding = Encoding.GetEncoding(setting_0.method_70());
				byte[] array2 = new byte[array.Length];
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = (byte)array[i];
				}
				Bmq = encoding.GetString(array2).TrimEnd('\0');
			}
			else
			{
				BmP = null;
			}
		}
		vmethod_2();
		bool flag = vmethod_3();
		Form23.form23_0.method_9(method_6);
		Bmm.Font = new Font(Bmm.Font.FontFamily, 8.25f, Bmm.Font.Style);
		SuspendLayout();
		bool flag2;
		if (flag2 = Form23.enum60_0 == Form23.Enum60.BpF && (bool_0 || bool_1) && framework_1 != null)
		{
			Bmm.Text = Class333.Bci() + setting_0.method_22(bool_0: true) + Class333.smethod_180();
		}
		else if (flag)
		{
			Bmm.Text = Class333.smethod_180() + setting_0.method_22(bool_0: true) + Class333.BAO();
		}
		else
		{
			Bmm.Text = setting_0.method_22(bool_0: false);
		}
		BmN.Text = Class333.BcJ();
		BmN.Width = 100;
		Bmn.Text = Class333.Bcj();
		Bmn.Width = 70;
		Bmm.Left = 0;
		Bmm.Top = 3;
		Bmm.Height = 16;
		Bmm.Width = method_3();
		BmN.Left = Bmm.Right + 10;
		BmN.Top = 0;
		Bmn.Left = BmN.Right + 10;
		Bmn.Top = 0;
		Controls.Add(Bmm);
		if (setting_0.method_176())
		{
			if (BmO == null)
			{
				BmO = new PictureBox();
			}
			BmO.BackColor = Color.Black;
			BmO.BorderStyle = BorderStyle.FixedSingle;
			BmO.SizeMode = PictureBoxSizeMode.StretchImage;
			BmO.Left = 0;
			BmO.Top = BmN.Height + 20;
			BmO.Height = 240;
			BmO.Width = 240 * setting_0.method_178().Width / setting_0.method_178().Height;
			Controls.Add(BmO);
		}
		if (!flag && !flag2)
		{
			setting_0.method_264(method_8);
			setting_0.method_40(method_7);
			BmN.Click += BmN_Click;
			Controls.Add(BmN);
			Bmn.Click += Bmn_Click;
			Controls.Add(Bmn);
			MouseEnter += vmethod_4;
			Bmm.MouseEnter += vmethod_4;
			BmN.MouseEnter += vmethod_4;
			Bmn.MouseEnter += vmethod_4;
			pictureBox_0.MouseEnter += vmethod_4;
			BmN.MouseLeave += vmethod_5;
			Bmn.MouseLeave += vmethod_5;
			MouseLeave += vmethod_5;
		}
		AutoSize = false;
		Bmn.Visible = !setting_0.method_176();
		bool flag3;
		if (flag3 = framework_1 != null && (bool_0 || bool_1))
		{
			if (setting_0.method_176())
			{
				Width = Math.Max(method_3() + 10 + BmN.Width, BmO.Width);
			}
			else
			{
				Width = method_3() + 10 + BmN.Width + 10 + Bmn.Width;
			}
		}
		else if (setting_0.method_176())
		{
			Width = Math.Max(BmN.Right, BmO.Width);
		}
		else
		{
			Width = Bmn.Right;
		}
		if (setting_0.method_176())
		{
			Height = BmO.Top + BmO.Height;
		}
		else
		{
			Height = BmN.Height;
		}
		if (!flag && !flag2)
		{
			pictureBox_0.Tag = setting_0;
			pictureBox_0.Width = 18;
			pictureBox_0.Height = 18;
			pictureBox_0.Left = Width;
			pictureBox_0.Top = 1;
			pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox_0.Click += method_5;
			Controls.Add(pictureBox_0);
			if (!flag3)
			{
				Width = pictureBox_0.Right;
			}
			pictureBox_0.Visible = false;
		}
		method_4();
		method_12();
		ResumeLayout(performLayout: true);
	}

	private int method_3()
	{
		if (string.IsNullOrWhiteSpace(Bmm.Text))
		{
			return 2;
		}
		int width = TextRenderer.MeasureText(Bmm.Text, Bmm.Font).Width;
		if (width < 158)
		{
			return 158;
		}
		if (width < 220)
		{
			return 220;
		}
		return 320;
	}

	private void method_4()
	{
		if (setting_0.method_35() && framework_0.method_4())
		{
			Bmm.ForeColor = Form23.color_12;
		}
		else
		{
			Bmm.ForeColor = Form23.color_36;
		}
		bool flag;
		string text;
		if (Form23.enum60_0 == Form23.Enum60.BpG && setting_1 != null)
		{
			flag = false;
			text = setting_1.method_260();
		}
		else
		{
			flag = setting_0.method_35() && framework_0.method_4();
			text = setting_0.method_260();
		}
		string bmo;
		if (text.StartsWith(Class333.smethod_1469()))
		{
			bmo = text.Substring(Class333.smethod_1469().Length);
		}
		else
		{
			bmo = ((!text.StartsWith(Class333.smethod_1472())) ? text : text.Substring(Class333.smethod_1472().Length));
		}
		Bmo = bmo;
		method_11();
		if (flag && !setting_0.method_122())
		{
			BmN.Enabled = true;
			Bmn.Enabled = !string.IsNullOrWhiteSpace(Bmo);
			switch (setting_0.method_124())
			{
			default:
				pictureBox_0.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Error:
				pictureBox_0.Image = GeneralResources.RedError;
				break;
			case IllegalitySeverityLevel.Warning:
				pictureBox_0.Image = GeneralResources.YellowWarning;
				break;
			case IllegalitySeverityLevel.ErrorIfOnline:
				if (Form23.smethod_28(framework_0.aXc, bool_53: true))
				{
					pictureBox_0.Image = GeneralResources.RedError;
				}
				else
				{
					pictureBox_0.Image = GeneralResources.YellowWarning;
				}
				break;
			}
			pictureBox_0.Visible = true;
		}
		else
		{
			BmN.Enabled = flag;
			Bmn.Enabled = flag && !string.IsNullOrWhiteSpace(Bmo);
			pictureBox_0.Visible = false;
			pictureBox_0.Image = GeneralResources.QuestionMark;
		}
		TabStop = BmN.Enabled;
		BmN.TabStop = TabStop;
		Bmn.TabStop = TabStop;
	}

	private void method_5(object sender, EventArgs e)
	{
		Form23.smethod_50(setting_0, this);
	}

	private void method_6(object sender, EventArgs e)
	{
		if (!bool_0 && !bool_1)
		{
			method_4();
		}
		else
		{
			vmethod_8();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate58 method = method_7;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_4();
	}

	private void method_8(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate59 method = method_8;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		method_12();
		if (Form23.enum60_0 != Form23.Enum60.BpG)
		{
			string text = setting_0.method_260();
			string text2;
			if (text.StartsWith(Class333.smethod_1469()))
			{
				text2 = text.Substring(Class333.smethod_1469().Length);
			}
			else
			{
				text2 = ((!text.StartsWith(Class333.smethod_1472())) ? text : text.Substring(Class333.smethod_1472().Length));
			}
			if (Bmo != text2)
			{
				Bmo = text2;
				Form23.smethod_74(setting_0.method_64());
				method_11();
			}
			if (setting_1 != null)
			{
				method_4();
			}
		}
	}

	private void BmN_Click(object sender, EventArgs e)
	{
		if (Form23.bool_2 || Form23.enum60_0 == Form23.Enum60.BpG)
		{
			return;
		}
		Form40 form = new Form40(framework_0, bool_4: false, setting_0.method_176(), setting_0.method_172(), setting_0.method_174());
		string text = setting_0.method_260();
		if (text.StartsWith(Class333.smethod_1469()))
		{
			form.bool_2 = true;
			form.string_9 = text.Substring(Class333.smethod_1469().Length);
		}
		else
		{
			form.bool_2 = false;
			if (text.StartsWith(Class333.smethod_1472()))
			{
				form.string_9 = text.Substring(Class333.smethod_1472().Length);
			}
			else
			{
				form.string_9 = text;
			}
		}
		DialogResult dialogResult = form.ShowDialog(Form23.form23_0);
		string string_ = form.string_9;
		bool bool_ = form.bool_2;
		form.Dispose();
		if (dialogResult != DialogResult.Cancel)
		{
			string text2 = ((!bool_) ? (Class333.smethod_1472() + string_) : (Class333.smethod_1469() + string_));
			Class280 @class = Form23.smethod_95();
			@class?.method_2(setting_0.method_64());
			if (text == text2)
			{
				setting_0.method_262(string.Empty, bool_0: true);
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += method_9;
				backgroundWorker.RunWorkerCompleted += method_10;
				backgroundWorker.RunWorkerAsync(text2);
			}
			else
			{
				setting_0.method_262(text2, bool_0: true);
				@class?.method_4();
				Form23.smethod_74(setting_0.method_64());
			}
		}
	}

	private void method_9(object sender, DoWorkEventArgs e)
	{
		do
		{
			Thread.Sleep(10);
		}
		while (framework_0.method_75());
		string result = e.Argument as string;
		e.Result = result;
	}

	private void method_10(object sender, RunWorkerCompletedEventArgs e)
	{
		string string_ = e.Result as string;
		setting_0.method_262(string_, bool_0: true);
		Form23.smethod_95()?.method_4();
		Form23.smethod_74(setting_0.method_64());
	}

	private void Bmn_Click(object sender, EventArgs e)
	{
		if (!Form23.bool_2 && Form23.enum60_0 != Form23.Enum60.BpG && (!string.IsNullOrWhiteSpace(Bmo) || !string.IsNullOrWhiteSpace(setting_0.method_260())))
		{
			Class280 @class = Form23.smethod_95();
			@class?.method_2(setting_0.method_64());
			setting_0.method_262(string.Empty, bool_0: true);
			@class?.method_4();
			Form23.smethod_74(setting_0.method_64());
		}
	}

	private void method_11()
	{
		if (!setting_0.method_176())
		{
			return;
		}
		Image image = BmO.Image;
		Bitmap image2 = new Bitmap(BmO.Width, BmO.Height);
		using (Graphics graphics = Graphics.FromImage(image2))
		{
			graphics.Clear(Color.Black);
			string text = setting_0.method_260();
			bool flag;
			string text2;
			if (text.StartsWith(Class333.smethod_1469()))
			{
				flag = true;
				text2 = text.Substring(Class333.smethod_1469().Length);
			}
			else
			{
				flag = false;
				text2 = ((!text.StartsWith(Class333.smethod_1472())) ? text : text.Substring(Class333.smethod_1472().Length));
			}
			try
			{
				string path = ((!flag) ? (Form23.string_3 + Class333.smethod_1474() + text2) : (Form23.string_10 + Class333.smethod_1473() + text2));
				using FileStream stream = File.OpenRead(path);
				using Image image3 = Image.FromStream(stream);
				float num = (float)BmO.Width / (float)setting_0.method_178().Width;
				Size size = Class25.smethod_1(new Size((int)((float)image3.Width * num), (int)((float)image3.Height * num)), BmO.Size);
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				graphics.DrawImage(image3, BmO.Width / 2 - size.Width / 2, BmO.Height / 2 - size.Height / 2, size.Width, size.Height);
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.BcK() + ex.Message);
			}
			BmO.Image = image2;
		}
		image?.Dispose();
	}

	private void method_12()
	{
		FontStyle fontStyle = FontStyle.Regular;
		if (BmP != null && BmQ)
		{
			Setting setting = ((Form23.enum60_0 != Form23.Enum60.BpG || setting_1 == null) ? setting_0 : setting_1);
			if (setting.method_260() != Bmq)
			{
				fontStyle = FontStyle.Italic;
			}
		}
		if (Bmm.Font.Style != fontStyle)
		{
			Font font = Bmm.Font;
			Bmm.Font = new Font(Bmm.Font.FontFamily, Bmm.Font.Size, fontStyle);
			font.Dispose();
		}
	}

	public override string ToString()
	{
		return setting_0.method_22(bool_0: true);
	}

	protected override void vmethod_8()
	{
		method_13();
		int width = Width;
		int height = Height;
		if (Parent != null)
		{
			Parent.SuspendLayout();
		}
		SuspendLayout();
		Controls.Clear();
		ResumeLayout(performLayout: true);
		method_2(dataIdAndAttrId_0, framework_0, framework_1, BmP, BmQ, Bmp);
		if (!AutoSize)
		{
			Width = width;
			Height = height;
		}
		if (Parent != null)
		{
			Parent.ResumeLayout(performLayout: true);
		}
	}

	protected override ContextMenuStrip vmethod_9()
	{
		if (setting_0.method_176())
		{
			return null;
		}
		return base.vmethod_9();
	}

	private void method_13()
	{
		try
		{
			BmN.Click -= BmN_Click;
			Bmn.Click -= Bmn_Click;
			MouseEnter -= vmethod_4;
			Bmm.MouseEnter -= vmethod_4;
			BmN.MouseEnter -= vmethod_4;
			Bmn.MouseEnter -= vmethod_4;
			pictureBox_0.MouseEnter -= vmethod_4;
			BmN.MouseLeave -= vmethod_5;
			Bmn.MouseLeave -= vmethod_5;
			MouseLeave -= vmethod_5;
			pictureBox_0.Click -= method_5;
			setting_0.method_265(method_8);
			setting_0.method_41(method_7);
			if (setting_3 != null)
			{
				setting_3.method_41(vmethod_6);
			}
			if (setting_4 != null)
			{
				setting_4.method_265(vmethod_7);
			}
			Form23.form23_0.method_10(method_6);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		method_13();
		if (Form23.pictureBox_1 == pictureBox_0)
		{
			Form23.pictureBox_1 = null;
		}
		try
		{
			base.Dispose(disposing);
		}
		catch
		{
		}
	}
}
