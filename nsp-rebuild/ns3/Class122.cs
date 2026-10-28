using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NSP.SettingsFramework;
using NSP.UserInterface;
using ns0;
using ns1;
using ns4;
using ns5;
using ns7;

namespace ns3;

internal class Class122 : Class109
{
	private delegate void Delegate89(object sender, EventArgs e);

	private delegate void Delegate90(object sender, EventArgs e);

	private delegate void Delegate91(object sender, EventArgs e);

	private delegate void Delegate92(object sender, EventArgs e);

	internal class Form0 : Form
	{
		private delegate void Delegate93(object sender, EventArgs e);

		private delegate void Delegate94(object sender, EventArgs e);

		private Framework bBQ;

		private Setting bBq;

		private Label bBR;

		private Panel bBr;

		private RadioButton bBS;

		private RadioButton bBs;

		private Class122 bBT;

		private ThemedButton bBt;

		private ThemedButton bBU;

		internal Form0(Framework framework_0, Setting setting_0)
		{
			Class1.smethod_12(method_0);
			Form23.smethod_30(method_0);
			bBQ = framework_0;
			bBq = setting_0;
			bBq.method_264(method_1);
			BackColor = Form23.color_10;
			ForeColor = Form23.color_12;
			Text = Class333.BJM();
			FormBorderStyle = FormBorderStyle.FixedDialog;
			ControlBox = false;
			MinimizeBox = false;
			MaximizeBox = false;
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			bBR = new Label();
			bBR.Text = Class333.BJm();
			bBR.ForeColor = Form23.color_12;
			bBR.AutoSize = true;
			bBR.Left = 5;
			bBR.Top = 10;
			Controls.Add(bBR);
			bBr = new Panel();
			bBr.BorderStyle = BorderStyle.None;
			bBr.Left = 5;
			bBr.Top = bBR.Top + bBR.Height + 5;
			bBS = new RadioButton();
			bBS.Text = Class333.BJN();
			bBS.ForeColor = Form23.color_12;
			bBS.AutoSize = true;
			bBS.Left = 5;
			bBS.Top = 5;
			bBS.Checked = false;
			bBS.CheckedChanged += bBS_CheckedChanged;
			bBr.Controls.Add(bBS);
			bBs = new RadioButton();
			bBs.Text = Class333.BJn();
			bBs.ForeColor = Form23.color_12;
			bBs.AutoSize = true;
			bBs.Left = 5;
			bBs.Top = bBS.Top + bBS.Height + 5;
			bBs.Checked = true;
			bBs.CheckedChanged += bBs_CheckedChanged;
			bBr.Controls.Add(bBs);
			bBr.Width = bBS.Left + bBS.Width + 5;
			bBr.Height = bBs.Top + bBs.Height + 5;
			Controls.Add(bBr);
			bBT = new Class122(bBQ, Rectangle.Empty, bool_0: false);
			bBT.method_20();
			bBT.Left = 5;
			bBT.Top = bBr.Top + bBr.Height + 5;
			Controls.Add(bBT);
			bBU = new ThemedButton();
			bBU.DialogResult = DialogResult.Cancel;
			bBU.Text = Class333.smethod_2559();
			bBU.Enabled = true;
			bBU.Size = new Size(80, 30);
			bBU.Left = 5 + bBT.Width - bBU.Width;
			bBU.Top = bBT.Top + bBT.Height + 10;
			Controls.Add(bBU);
			bBt = new ThemedButton();
			bBt.DialogResult = DialogResult.OK;
			bBt.Text = Class333.smethod_821();
			bBt.Enabled = false;
			bBt.Size = new Size(80, 30);
			bBt.Left = bBU.Left - 5 - bBt.Width;
			bBt.Top = bBU.Top;
			Controls.Add(bBt);
			ClientSize = new Size(5 + bBT.Width + 5, bBt.Top + bBt.Height + 5);
		}

		protected override void Dispose(bool disposing)
		{
			try
			{
				Class1.smethod_13(method_0);
				Form23.smethod_31(method_0);
				bBq.method_265(method_1);
				bBS.CheckedChanged -= bBS_CheckedChanged;
				bBs.CheckedChanged -= bBs_CheckedChanged;
				base.Dispose(disposing);
			}
			catch
			{
			}
		}

		private void method_0(object sender, EventArgs e)
		{
			if (InvokeRequired)
			{
				try
				{
					Delegate93 method = method_0;
					BeginInvoke(method, sender, e);
					return;
				}
				catch
				{
					return;
				}
			}
			if (!Form23.smethod_28(bBQ.aXc, bool_53: true) && !IsDisposed)
			{
				Close();
			}
		}

		private void method_1(object sender, EventArgs e)
		{
			if (InvokeRequired)
			{
				try
				{
					Delegate94 method = method_1;
					Invoke(method, sender, e);
					return;
				}
				catch
				{
					return;
				}
			}
			bool flag = bBq.method_256() == 0;
			bool flag2 = bBq.method_256() == 2;
			bBS.Checked = flag;
			bBs.Checked = !flag;
			bBt.Enabled = !flag2;
		}

		private void bBS_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as RadioButton).Checked)
			{
				bBq.method_272(0, bool_0: true);
			}
			else
			{
				bBq.method_272(2, bool_0: true);
			}
		}

		private void bBs_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as RadioButton).Checked)
			{
				bBq.method_272(2, bool_0: true);
			}
			else
			{
				bBq.method_272(0, bool_0: true);
			}
		}
	}

	private Framework Bxo;

	private Rectangle BxP;

	private Setting Bxp;

	private Setting BxQ;

	private Setting Bxq;

	private Label BxR = new Label();

	private ThemedTextBox Bxr = new ThemedTextBox();

	private Label BxS = new Label();

	private ThemedTextBox Bxs = new ThemedTextBox();

	private ThemedButton BxT = new ThemedButton();

	private Label Bxt = new Label();

	private Label BxU = new Label();

	private bool Bxu;

	private string BxV = Class333.BHY();

	private string Bxv = string.Empty;

	internal Class122(Framework framework_0, Rectangle rectangle_0, bool bool_0)
		: base(rectangle_0, bool_0, bool_1: false)
	{
		Class1.smethod_12(method_16);
		Form23.smethod_30(method_16);
		Bxo = framework_0;
		BxP = rectangle_0;
		Bxp = Bxo.method_31(10195);
		if (Bxp != null)
		{
			if (Bxo.method_2() && Bxo.method_3() && Bxp.method_96())
			{
				Bxu = true;
			}
			else
			{
				Bxp.method_264(method_17);
			}
		}
		BxQ = Bxo.method_31(9869);
		if (BxQ != null && !Bxu)
		{
			BxQ.method_264(method_18);
		}
		Bxq = Bxo.method_31(9828);
		if (Bxq != null && !Bxu)
		{
			Bxq.method_264(method_19);
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			Class1.smethod_13(method_16);
			Form23.smethod_31(method_16);
			BxT.Click -= BxT_Click;
			if (Bxp != null && !Bxu)
			{
				Bxp.method_265(method_17);
			}
			if (BxQ != null && !Bxu)
			{
				BxQ.method_265(method_18);
			}
			if (Bxq != null && !Bxu)
			{
				Bxq.method_265(method_19);
			}
			base.Dispose(disposing);
		}
		catch
		{
		}
	}

	private string method_15()
	{
		string result = null;
		if (Bxq != null)
		{
			try
			{
				Encoding encoding = Encoding.GetEncoding(20127);
				byte[] array = new byte[32];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Bxq.method_254(i);
				}
				result = encoding.GetString(array).TrimEnd('\0');
			}
			catch
			{
				result = null;
			}
		}
		return result;
	}

	private void method_16(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate89 method = method_16;
				BeginInvoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (!Form23.smethod_28(Bxo.aXc, bool_53: true))
		{
			Bxt.Text = Class333.smethod_612();
		}
	}

	private void method_17(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate90 method = method_17;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		bool flag = Bxp != null && Bxp.method_256() != 0;
		foreach (Control control in method_12().Controls)
		{
			control.Enabled = flag;
		}
		if (flag)
		{
			string text = method_15();
			if (text != null)
			{
				Bxr.Text = text;
			}
		}
		if (Bxr.Enabled)
		{
			Bxr.BackColor = Form23.color_32;
			Bxr.ForeColor = Form23.color_12;
		}
		else
		{
			Bxr.BackColor = Form23.color_35;
			Bxr.ForeColor = Form23.color_36;
		}
		if (Bxs.Enabled)
		{
			Bxs.BackColor = Form23.color_32;
			Bxs.ForeColor = Form23.color_12;
		}
		else
		{
			Bxs.BackColor = Form23.color_35;
			Bxs.ForeColor = Form23.color_36;
		}
	}

	private void method_18(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate91 method = method_18;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (BxQ != null)
		{
			Bxt.Text = Class333.BHy() + BxQ.method_252().DisplayValueString;
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		if (InvokeRequired)
		{
			try
			{
				Delegate92 method = method_19;
				Invoke(method, sender, e);
				return;
			}
			catch
			{
				return;
			}
		}
		if (Bxq != null)
		{
			string text = method_15();
			if (Bxp != null && Bxp.method_256() != 0 && text != null && Bxr.Text != text && Bxv != text)
			{
				Bxr.Text = text;
			}
			Bxv = text;
		}
	}

	internal void method_20()
	{
		SuspendLayout();
		method_12().SuspendLayout();
		int top = 5;
		bool enabled = Bxp != null && Bxp.method_256() != 0 && !Bxu;
		Label label = new Label();
		if (Bxu)
		{
			label.Text = Class333.BHZ();
		}
		else
		{
			label.Text = Class333.BHz();
		}
		label.ForeColor = Form23.color_12;
		label.Font = new Font(label.Font.FontFamily, 8f, FontStyle.Bold);
		label.AutoSize = true;
		label.Left = 5;
		label.Top = top;
		label.Enabled = enabled;
		method_12().Controls.Add(label);
		top = label.Bottom + 20;
		BxR.Text = Class333.BhA();
		BxR.ForeColor = Form23.color_12;
		BxR.Height = (int)((float)BxR.Height * 0.7f);
		BxR.Width = 80;
		BxR.Left = 5;
		BxR.Top = top + 3;
		BxR.Enabled = enabled;
		method_12().Controls.Add(BxR);
		string text = method_15();
		Bxr.MaxLength = 32;
		if (text != null)
		{
			Bxr.Text = text;
		}
		Bxr.Left = 100;
		Bxr.Top = top;
		Bxr.Width = 200;
		Bxr.Enabled = enabled;
		if (Bxr.Enabled)
		{
			Bxr.BackColor = Form23.color_32;
			Bxr.ForeColor = Form23.color_12;
		}
		else
		{
			Bxr.BackColor = Form23.color_35;
			Bxr.ForeColor = Form23.color_36;
		}
		method_12().Controls.Add(Bxr);
		top = Bxr.Bottom + 10;
		BxS.Text = Class333.aGz();
		BxS.ForeColor = Form23.color_12;
		BxS.Height = (int)((float)BxS.Height * 0.7f);
		BxS.Width = 80;
		BxS.Left = 5;
		BxS.Top = top + 3;
		BxS.Enabled = enabled;
		method_12().Controls.Add(BxS);
		Bxs.UseSystemPasswordChar = true;
		Bxs.MaxLength = 64;
		Bxs.Left = 100;
		Bxs.Top = top;
		Bxs.Width = 200;
		Bxs.Enabled = enabled;
		if (Bxs.Enabled)
		{
			Bxs.BackColor = Form23.color_32;
			Bxs.ForeColor = Form23.color_12;
		}
		else
		{
			Bxs.BackColor = Form23.color_35;
			Bxs.ForeColor = Form23.color_36;
		}
		method_12().Controls.Add(Bxs);
		top = Bxs.Bottom + 10;
		Bxt.Text = Class333.BHy();
		Bxt.ForeColor = Form23.color_12;
		Bxt.Height = (int)((float)Bxt.Height * 0.7f);
		Bxt.Width = Bxs.Left + Bxs.Width;
		Bxt.Left = 5;
		Bxt.Top = top + 3;
		Bxt.Enabled = enabled;
		method_12().Controls.Add(Bxt);
		top = Bxt.Bottom + 10;
		BxU.Text = BxV + Class333.smethod_612();
		BxU.ForeColor = Form23.color_12;
		BxU.Height = 2 * (int)((float)BxU.Height * 0.7f);
		BxU.Width = Bxt.Width;
		BxU.Left = 5;
		BxU.Top = top + 3;
		BxU.Enabled = enabled;
		method_12().Controls.Add(BxU);
		top = BxU.Bottom + 5;
		BxT.Text = Class333.Bha();
		BxT.Width = 170;
		BxT.Height = 30;
		BxT.Left = 5;
		BxT.Top = top + 10;
		BxT.Click += BxT_Click;
		BxT.Enabled = enabled;
		method_12().Controls.Add(BxT);
		if (BxP != Rectangle.Empty)
		{
			Width = BxP.Width;
			Height = BxP.Height;
			Left = BxP.Left;
			Top = BxP.Top;
		}
		else
		{
			int num = 0;
			int num2 = 0;
			foreach (Control control in method_12().Controls)
			{
				num = Math.Max(num, control.Right + 20);
				num2 = Math.Max(num2, control.Bottom + 20);
			}
			Width = num;
			Height = num2;
		}
		method_12().ResumeLayout(performLayout: true);
		ResumeLayout(performLayout: true);
	}

	private void BxT_Click(object sender, EventArgs e)
	{
		if (!Form23.smethod_28(Bxo.aXc, bool_53: true))
		{
			BxU.Text = BxV + Class333.BhB();
		}
		else
		{
			if (Bxu)
			{
				return;
			}
			BxU.Text = BxV + Class333.smethod_612();
			string text = Bxr.Text;
			string text2 = Bxs.Text;
			if (text.Length == 0)
			{
				Form54.smethod_6(Form23.form23_0, Class333.Bhb(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (Class327.smethod_1(text))
			{
				string text3 = Class333.smethod_102();
				for (int i = 0; i < Class327.Bds.Length; i++)
				{
					text3 = text3 + Class333.smethod_325() + Class327.Bds[i];
				}
				Form54.smethod_6(Form23.form23_0, Class333.BhC() + text3, Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			bool flag = true;
			for (int j = 0; j < text.Length; j++)
			{
				if (text[j] != ' ')
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				Form54.smethod_6(Form23.form23_0, Class333.Bhc(), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (text2.Length < 8)
			{
				Form54.smethod_6(Form23.form23_0, string.Format(Class333.BhD(), 8), Class333.smethod_390(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Class1.smethod_61(Bxo.aXc, text, text2, out var _);
			if (Class327.smethod_2(text, text2))
			{
				BxU.Text = BxV + Class333.smethod_14();
			}
			else
			{
				BxU.Text = BxV + Class333.Bhd();
			}
		}
	}

	internal static void smethod_0(Framework framework_0, out bool bool_0)
	{
		bool_0 = false;
		if (framework_0 == null)
		{
			return;
		}
		Setting setting = framework_0.method_31(10195);
		if (setting != null && !setting.method_219() && setting.method_102().Count == 3 && setting.method_256() == 2 && setting.method_152() != null)
		{
			Form0 form = new Form0(framework_0, setting);
			if (form.ShowDialog(Form23.form23_0) == DialogResult.Cancel)
			{
				bool_0 = true;
			}
			form.Dispose();
		}
	}
}
