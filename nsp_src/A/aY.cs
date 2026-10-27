using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using Microsoft.Win32;
using NSP.UserInterface;

namespace a;

internal class aY : Form
{
	private string Ll;

	private IContainer LM;

	private ag Lm;

	private Label LN;

	private Label Ln;

	private ThemedButton LO;

	private PictureBox Lo;

	private Label LP;

	internal aY()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		B();
		((Control)this).BackColor = BM.td;
		foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
		{
			Control val = item;
			if (val is Label)
			{
				((val is Label) ? val : null).ForeColor = BM.te;
			}
		}
		((Control)Lm).BackColor = BM.tH;
		((Control)Lm).ForeColor = BM.te;
		Version version = Assembly.GetEntryAssembly().GetName().Version;
		((Control)LN).Text = BM.Qp + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.go() + A(version);
		((Control)LP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gP() + A();
	}

	private void A(object P_0, EventArgs P_1)
	{
		((Control)this).Refresh();
		try
		{
			string text = a(Assembly.GetEntryAssembly().GetName().Version);
			if (!string.IsNullOrEmpty(text))
			{
				StreamReader val = File.OpenText(text);
				try
				{
					Ll = ((TextReader)val).ReadToEnd();
					a();
					return;
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gp() + ex.Message, true);
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		((Form)this).Close();
	}

	internal static string A(Version P_0)
	{
		List<string> val = new List<string>((System.Collections.Generic.IEnumerable<string>)((object)P_0).ToString().Split('.', (StringSplitOptions)0));
		if (val.Count > 3)
		{
			val.RemoveRange(3, val.Count - 3);
			return string.Join(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq(), val.ToArray());
		}
		return ((object)P_0).ToString();
	}

	public static string A()
	{
		string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gQ();
		try
		{
			RegistryKey val = RegistryKey.OpenBaseKey((RegistryHive)(-2147483646), (RegistryView)0);
			try
			{
				RegistryKey val2 = val.OpenSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gq());
				try
				{
					if (val2 != null)
					{
						text = (string)val2.GetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bs());
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return text;
		}
		catch
		{
			return text;
		}
	}

	internal static string a(Version P_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		string result = null;
		try
		{
			string[] files = Directory.GetFiles(BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gR(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gr(), (SearchOption)1);
			Version val = new Version(0, 0, 0);
			string[] array = files;
			Version val2 = default(Version);
			foreach (string text in array)
			{
				string[] array2 = Path.GetFileNameWithoutExtension(text).Split('_', (StringSplitOptions)0);
				if (array2.Length < 2 || !Version.TryParse(array2[1].Remove(0, 1), ref val2))
				{
					continue;
				}
				if (P_0 == (Version)null)
				{
					if (val2 > val)
					{
						val = val2;
						result = text;
					}
				}
				else if (val2.Major == P_0.Major && val2.Minor == P_0.Minor && val2.Build == P_0.Build)
				{
					result = text;
					break;
				}
			}
		}
		catch (System.Exception ex)
		{
			result = null;
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gS() + ex.Message, true);
		}
		return result;
	}

	private void a()
	{
		if (!string.IsNullOrEmpty(Ll))
		{
			if (!((Control)LO).Focused)
			{
				((Control)LO).Focus();
			}
			((RichTextBox)Lm).ScrollBars = (RichTextBoxScrollBars)0;
			Lm.A(Ll);
			((RichTextBox)Lm).ScrollBars = (RichTextBoxScrollBars)2;
			Lm.A();
		}
	}

	private void A(object P_0, LinkClickedEventArgs P_1)
	{
		Process.Start(P_1.LinkText);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && LM != null)
		{
			((System.IDisposable)LM).Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void B()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		ComponentResourceManager val = new ComponentResourceManager(typeof(aY));
		Lm = new ag();
		LN = new Label();
		Ln = new Label();
		LO = new ThemedButton();
		Lo = new PictureBox();
		LP = new Label();
		((ISupportInitialize)Lo).BeginInit();
		((Control)this).SuspendLayout();
		((TextBoxBase)Lm).BorderStyle = (BorderStyle)0;
		((Control)Lm).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
		((Control)Lm).Location = new Point(14, 52);
		((Control)Lm).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gs();
		((TextBoxBase)Lm).ReadOnly = true;
		((RichTextBox)Lm).ScrollBars = (RichTextBoxScrollBars)2;
		((Control)Lm).Size = new Size(346, 292);
		((Control)Lm).TabIndex = 1;
		((Control)Lm).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
		((RichTextBox)Lm).LinkClicked += new LinkClickedEventHandler(A);
		((Control)LN).AutoSize = true;
		((Control)LN).Location = new Point(12, 9);
		((Control)LN).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gT();
		((Control)LN).Size = new Size(139, 13);
		((Control)LN).TabIndex = 7;
		((Control)LN).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gt();
		((Control)Ln).AutoSize = true;
		((Control)Ln).Location = new Point(13, 37);
		((Control)Ln).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
		((Control)Ln).Size = new Size(80, 13);
		((Control)Ln).TabIndex = 8;
		((Control)Ln).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gU();
		((Button)LO).DialogResult = (DialogResult)2;
		((Control)LO).Location = new Point(147, 375);
		((Control)LO).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gu();
		((Control)LO).Size = new Size(80, 25);
		((Control)LO).TabIndex = 0;
		((Control)LO).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gV();
		((ButtonBase)LO).UseVisualStyleBackColor = true;
		((Control)LO).Click += new EventHandler(a);
		((Control)Lo).BackColor = Color.Transparent;
		Lo.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gv());
		((Control)Lo).Location = new Point(261, 6);
		((Control)Lo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gW();
		((Control)Lo).Size = new Size(107, 20);
		Lo.SizeMode = (PictureBoxSizeMode)2;
		Lo.TabIndex = 10;
		Lo.TabStop = false;
		((Control)LP).AutoSize = true;
		((Control)LP).Location = new Point(12, 354);
		((Control)LP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gw();
		((Control)LP).Size = new Size(115, 13);
		((Control)LP).TabIndex = 11;
		((Control)LP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gX();
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)LO;
		((Form)this).ClientSize = new Size(374, 409);
		((Control)this).Controls.Add((Control)(object)LP);
		((Control)this).Controls.Add((Control)(object)Lo);
		((Control)this).Controls.Add((Control)(object)LO);
		((Control)this).Controls.Add((Control)(object)Ln);
		((Control)this).Controls.Add((Control)(object)LN);
		((Control)this).Controls.Add((Control)(object)Lm);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gx();
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gY();
		((Form)this).Shown += new EventHandler(A);
		((ISupportInitialize)Lo).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
internal class ay : Form
{
	private IContainer Lp;

	private aP LQ;

	private ThemedTextBox Lq;

	private Label LR;

	private ThemedButton Lr;

	private Label LS;

	internal ay()
	{
		A();
	}

	private void A(object P_0, EventArgs P_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gy();
		((Control)this).BackColor = BM.tE;
		foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
		{
			Control val = item;
			if (val is Label)
			{
				val.ForeColor = BM.te;
			}
		}
		((Control)LQ).ForeColor = BM.te;
		((Control)Lq).BackColor = BM.to;
		((Control)Lq).ForeColor = BM.te;
		Be.a();
		((CheckBox)LQ).Checked = Be.nv;
		((Control)Lq).Text = Be.nV.ToString();
	}

	private void A(object P_0, FormClosingEventArgs P_1)
	{
		int nV = default(int);
		if (int.TryParse(((Control)Lq).Text, ref nV))
		{
			Be.nV = nV;
		}
		Be.B();
		if (!Be.nv && ((uint)BM.qI & 0x800u) != 0)
		{
			BM.TG.a();
		}
	}

	private void a(object P_0, EventArgs P_1)
	{
		Be.nv = ((CheckBox)LQ).Checked;
		Be.B();
	}

	private void B(object P_0, EventArgs P_1)
	{
		((Form)this).Close();
	}

	private void A(object P_0, KeyPressEventArgs P_1)
	{
		if (!char.IsControl(P_1.KeyChar) && !char.IsDigit(P_1.KeyChar) && P_1.KeyChar != '.')
		{
			P_1.Handled = true;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && Lp != null)
		{
			((System.IDisposable)Lp).Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void A()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		LR = new Label();
		Lq = new ThemedTextBox();
		LQ = new aP();
		Lr = new ThemedButton();
		LS = new Label();
		((Control)this).SuspendLayout();
		((Control)LR).AutoSize = true;
		((Control)LR).Location = new Point(9, 38);
		((Control)LR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
		((Control)LR).Size = new Size(138, 13);
		((Control)LR).TabIndex = 2;
		((Control)LR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gZ();
		((Control)Lq).Location = new Point(149, 34);
		((Control)Lq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gz();
		((Control)Lq).Size = new Size(70, 22);
		((Control)Lq).TabIndex = 1;
		((Control)Lq).KeyPress += new KeyPressEventHandler(A);
		((Control)LQ).AutoSize = true;
		((Control)LQ).Location = new Point(12, 12);
		((Control)LQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HA();
		((Control)LQ).Size = new Size(151, 17);
		((Control)LQ).TabIndex = 0;
		((Control)LQ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ha();
		((ButtonBase)LQ).UseVisualStyleBackColor = true;
		((CheckBox)LQ).CheckedChanged += new EventHandler(a);
		((Button)Lr).DialogResult = (DialogResult)2;
		((Control)Lr).Location = new Point(78, 67);
		((Control)Lr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gu();
		((Control)Lr).Size = new Size(105, 34);
		((Control)Lr).TabIndex = 11;
		((Control)Lr).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gV();
		((ButtonBase)Lr).UseVisualStyleBackColor = true;
		((Control)Lr).Click += new EventHandler(B);
		((Control)LS).AutoSize = true;
		((Control)LS).Location = new Point(221, 38);
		((Control)LS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fx();
		((Control)LS).Size = new Size(30, 13);
		((Control)LS).TabIndex = 12;
		((Control)LS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.HB();
		((Form)this).AcceptButton = (IButtonControl)(object)Lr;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)Lr;
		((Form)this).ClientSize = new Size(261, 107);
		((Control)this).Controls.Add((Control)(object)LS);
		((Control)this).Controls.Add((Control)(object)Lr);
		((Control)this).Controls.Add((Control)(object)LR);
		((Control)this).Controls.Add((Control)(object)Lq);
		((Control)this).Controls.Add((Control)(object)LQ);
		((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Hb();
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gy();
		((Form)this).FormClosing += new FormClosingEventHandler(A);
		((Form)this).Shown += new EventHandler(A);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
