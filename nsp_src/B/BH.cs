using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;

namespace B
{
	internal class BH : Form
	{
		private static readonly string on = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KW();

		private IContainer oO;

		private aP oo;

		private ThemedButton oP;

		private ThemedButton op;

		private Label oQ;

		internal BH()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			a();
			((Control)this).BackColor = BM.td;
			((Control)oo).ForeColor = BM.te;
			((Control)oQ).ForeColor = BM.te;
		}

		private void A(object P_0, EventArgs P_1)
		{
			((CheckBox)oo).Checked = false;
			((Control)oP).Focus();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)((Form)this).DialogResult == 1 && ((CheckBox)oo).Checked)
			{
				if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
				{
					Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
				}
				else if (!File.Exists(on))
				{
					((Stream)File.Create(on)).Close();
				}
				List<string> val = new List<string>();
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ks() + ((CheckBox)oo).Checked);
				File.AppendAllLines(on, (System.Collections.Generic.IEnumerable<string>)val);
			}
		}

		internal static bool A()
		{
			if (File.Exists(on))
			{
				StreamReader val = File.OpenText(on);
				try
				{
					string text;
					while ((text = ((TextReader)val).ReadLine()) != null)
					{
						if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ks()) && bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ks().Length)))
						{
							return true;
						}
					}
				}
				finally
				{
					((System.IDisposable)val)?.Dispose();
				}
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && oO != null)
			{
				((System.IDisposable)oO).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Expected O, but got Unknown
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dc: Expected O, but got Unknown
			//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Expected O, but got Unknown
			oo = new aP();
			oP = new ThemedButton();
			op = new ThemedButton();
			oQ = new Label();
			((Control)this).SuspendLayout();
			((Control)oo).AutoSize = true;
			((Control)oo).Location = new Point(12, 39);
			((Control)oo).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KT();
			((Control)oo).Size = new Size(212, 17);
			((Control)oo).TabIndex = 2;
			((Control)oo).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KR();
			((ButtonBase)oo).UseVisualStyleBackColor = true;
			((Button)oP).DialogResult = (DialogResult)1;
			((Control)oP).Location = new Point(232, 32);
			((Control)oP).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kt();
			((Control)oP).Size = new Size(90, 30);
			((Control)oP).TabIndex = 0;
			((Control)oP).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KU();
			((ButtonBase)oP).UseVisualStyleBackColor = true;
			((Button)op).DialogResult = (DialogResult)2;
			((Control)op).Location = new Point(332, 32);
			((Control)op).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)op).Size = new Size(90, 30);
			((Control)op).TabIndex = 1;
			((Control)op).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)op).UseVisualStyleBackColor = true;
			((Control)oQ).AutoSize = true;
			((Control)oQ).Location = new Point(8, 10);
			((Control)oQ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)oQ).Size = new Size(282, 13);
			((Control)oQ).TabIndex = 7;
			((Control)oQ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ku();
			((Form)this).AcceptButton = (IButtonControl)(object)oP;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)op;
			((Form)this).ClientSize = new Size(434, 74);
			((Form)this).ControlBox = false;
			((Control)this).Controls.Add((Control)(object)oQ);
			((Control)this).Controls.Add((Control)(object)oo);
			((Control)this).Controls.Add((Control)(object)oP);
			((Control)this).Controls.Add((Control)(object)op);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KV();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Kv();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class Bh : Form
	{
		private string oU;

		private IContainer ou;

		private ag oV;

		[SpecialName]
		internal static Version A()
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Expected O, but got Unknown
			Version val = new Version(0, 0, 0);
			try
			{
				string[] files = Directory.GetFiles(BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kB(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kb(), (SearchOption)1);
				Version val2 = default(Version);
				for (int i = 0; i < files.Length; i++)
				{
					string[] array = Path.GetFileNameWithoutExtension(files[i]).Split('_', (StringSplitOptions)0);
					if (array.Length >= 2 && Version.TryParse(array[1].Remove(0, 1), ref val2) && val2 > val)
					{
						val = val2;
					}
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kC() + ex.Message, true);
			}
			return val;
		}

		internal static string a()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			string result = null;
			try
			{
				Version val = new Version(0, 0, 0);
				string[] files = Directory.GetFiles(BM.Qr + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kB(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kb(), (SearchOption)1);
				Version val2 = default(Version);
				foreach (string text in files)
				{
					string[] array = Path.GetFileNameWithoutExtension(text).Split('_', (StringSplitOptions)0);
					if (array.Length >= 2 && Version.TryParse(array[1].Remove(0, 1), ref val2) && val2 > val)
					{
						val = val2;
						result = text;
					}
				}
			}
			catch (System.Exception ex)
			{
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kc() + ex.Message, true);
			}
			return result;
		}

		internal Bh()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			b();
			((Control)this).BackColor = BM.td;
			((Control)oV).BackColor = BM.tH;
			((Control)oV).ForeColor = BM.te;
			((TextBoxBase)oV).SelectionStart = 0;
		}

		private void A(object P_0, LinkClickedEventArgs P_1)
		{
			Process.Start(P_1.LinkText);
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kD() + aY.A(A());
			string text = a();
			if (string.IsNullOrEmpty(text))
			{
				ComponentResourceManager val = new ComponentResourceManager(typeof(Bh));
				oU = ((ResourceManager)val).GetString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kd());
			}
			else
			{
				StreamReader val2 = File.OpenText(text);
				try
				{
					oU = ((TextReader)val2).ReadToEnd();
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			B();
		}

		private void B()
		{
			if (!string.IsNullOrEmpty(oU))
			{
				((RichTextBox)oV).ScrollBars = (RichTextBoxScrollBars)0;
				oV.A(oU);
				((RichTextBox)oV).ScrollBars = (RichTextBoxScrollBars)2;
				oV.A();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && ou != null)
			{
				((System.IDisposable)ou).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void b()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Expected O, but got Unknown
			new ComponentResourceManager(typeof(Bh));
			oV = new ag();
			((Control)this).SuspendLayout();
			((Control)oV).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), ((Control)oV).Font.Size);
			((TextBoxBase)oV).BorderStyle = (BorderStyle)0;
			((Control)oV).Dock = (DockStyle)5;
			((Control)oV).Location = new Point(0, 0);
			((Control)oV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kE();
			((TextBoxBase)oV).ReadOnly = true;
			((Control)oV).Size = new Size(378, 555);
			((Control)oV).TabIndex = 0;
			((Control)oV).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay();
			((RichTextBox)oV).LinkClicked += new LinkClickedEventHandler(A);
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).ClientSize = new Size(384, 561);
			((Control)this).Controls.Add((Control)(object)oV);
			((Form)this).FormBorderStyle = (FormBorderStyle)5;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ke();
			((Control)this).Padding = new Padding(3);
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kF();
			((Form)this).TopMost = true;
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
		}
	}
}
namespace b
{
	internal class bH : Form
	{
		private bool aBp;

		private IContainer aBQ;

		private aP aBq;

		private ThemedButton aBR;

		private PictureBox aBr;

		private LinkLabel aBS;

		private Label aBs;

		internal bH()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			A();
			((Control)this).BackColor = BM.td;
			foreach (Control item in (ArrangedElementCollection)((Control)this).Controls)
			{
				Control val = item;
				if (val is LinkLabel)
				{
					((LinkLabel)((val is LinkLabel) ? val : null)).LinkColor = BM.te;
				}
				else if (val is Label || val is aP)
				{
					val.ForeColor = BM.te;
				}
			}
			((CheckBox)aBq).Checked = BM.QQ.qd.UserOptInPrivacy;
		}

		private void A(object P_0, EventArgs P_1)
		{
			((Form)this).Close();
		}

		private void a(object P_0, EventArgs P_1)
		{
			aBp = ((CheckBox)aBq).Checked;
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			BM.QQ.qd.UserOptInPrivacy = aBp;
			if (aBp)
			{
				BM.QQ.qd.LastAgreedPrivacyDocumentVer = Bh.A();
			}
			else if (BM.QQ.qd.LastAgreedPrivacyDocVerRegistryEntryExists())
			{
				BM.QQ.qd.DeleteLastAgreedPrivacyDocVerRegistryEntry();
			}
			BM.QQ.F();
		}

		private void A(object P_0, LinkLabelLinkClickedEventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			Bh obj = new Bh();
			((Form)obj).ShowDialog((IWin32Window)(object)this);
			((Component)obj).Dispose();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && aBQ != null)
			{
				((System.IDisposable)aBQ).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Expected O, but got Unknown
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Expected O, but got Unknown
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0366: Unknown result type (might be due to invalid IL or missing references)
			//IL_0370: Expected O, but got Unknown
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Expected O, but got Unknown
			ComponentResourceManager val = new ComponentResourceManager(typeof(bH));
			aBq = new aP();
			aBR = new ThemedButton();
			aBr = new PictureBox();
			aBS = new LinkLabel();
			aBs = new Label();
			((ISupportInitialize)aBr).BeginInit();
			((Control)this).SuspendLayout();
			((Control)aBq).AutoSize = true;
			((Control)aBq).Location = new Point(13, 64);
			((Control)aBq).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBR();
			((Control)aBq).Size = new Size(240, 17);
			((Control)aBq).TabIndex = 1;
			((Control)aBq).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBr();
			((ButtonBase)aBq).UseVisualStyleBackColor = true;
			((CheckBox)aBq).CheckedChanged += new EventHandler(a);
			((Control)aBR).Location = new Point(96, 89);
			((Control)aBR).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gu();
			((Control)aBR).Size = new Size(75, 23);
			((Control)aBR).TabIndex = 2;
			((Control)aBR).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gV();
			((ButtonBase)aBR).UseVisualStyleBackColor = true;
			((Control)aBR).Click += new EventHandler(A);
			((Control)aBr).BackColor = Color.Transparent;
			aBr.Image = (Image)((ResourceManager)val).GetObject(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gv());
			((Control)aBr).Location = new Point(136, 12);
			((Control)aBr).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gW();
			((Control)aBr).Size = new Size(107, 20);
			aBr.SizeMode = (PictureBoxSizeMode)2;
			aBr.TabIndex = 11;
			aBr.TabStop = false;
			((Control)aBS).AutoSize = true;
			((Control)aBS).Location = new Point(185, 41);
			((Control)aBS).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBS();
			((Control)aBS).Size = new Size(75, 13);
			((Control)aBS).TabIndex = 13;
			aBS.TabStop = true;
			((Control)aBS).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.kF();
			aBS.LinkClicked += new LinkLabelLinkClickedEventHandler(A);
			((Control)aBs).AutoSize = true;
			((Control)aBs).Location = new Point(7, 41);
			((Control)aBs).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)aBs).Size = new Size(180, 13);
			((Control)aBs).TabIndex = 14;
			((Control)aBs).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBs();
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((ScrollableControl)this).AutoScroll = true;
			((Control)this).AutoSize = true;
			((Form)this).ClientSize = new Size(264, 118);
			((Control)this).Controls.Add((Control)(object)aBs);
			((Control)this).Controls.Add((Control)(object)aBS);
			((Control)this).Controls.Add((Control)(object)aBr);
			((Control)this).Controls.Add((Control)(object)aBR);
			((Control)this).Controls.Add((Control)(object)aBq);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBT();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.pn();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((ISupportInitialize)aBr).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
	internal class bh : Form
	{
		private Framework aBT;

		private string aBt;

		private IContainer aBU;

		private ThemedButton aBu;

		private ThemedButton aBV;

		private ThemedTextBox aBv;

		private Label aBW;

		internal bh(Framework P_0)
		{
			A();
			aBT = P_0;
		}

		private void A(object P_0, EventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Invalid comparison between Unknown and I4
			((Control)this).BackColor = BM.td;
			((Control)aBW).ForeColor = BM.te;
			((Control)aBv).BackColor = BM.to;
			((Control)aBv).ForeColor = BM.te;
			((Control)aBv).Focus();
			string text = BM.h(aBT.aXc);
			if (!string.IsNullOrEmpty(text))
			{
				string text2 = ((FileSystemInfo)new DirectoryInfo(text)).Name;
				int num = text2.IndexOf('_');
				if (num != -1)
				{
					text2 = text2.Substring(0, num);
				}
				if (!string.IsNullOrEmpty(text2) && (int)bE.A((IWin32Window)(object)BM.QQ, string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBt(),
					text2,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBU(),
					text2,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ws()
				}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBu(), (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
				{
					aBt = text2;
					((Control)aBv).Text = text2;
				}
			}
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			if ((int)((Form)this).DialogResult != 1)
			{
				return;
			}
			if ((!string.IsNullOrEmpty(aBt) && ((Control)aBv).Text == aBt) || BM.A(string.Empty, ((Control)aBv).Text, aBT))
			{
				aBT.A(1501).A(((Control)aBv).Text, true);
				BM.b(1501);
				return;
			}
			if (!string.IsNullOrWhiteSpace(((Control)aBv).Text))
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBV(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			((CancelEventArgs)P_1).Cancel = true;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && aBU != null)
			{
				((System.IDisposable)aBU).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void A()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Expected O, but got Unknown
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			ComponentResourceManager val = new ComponentResourceManager(typeof(bh));
			aBu = new ThemedButton();
			aBV = new ThemedButton();
			aBv = new ThemedTextBox();
			aBW = new Label();
			((Control)this).SuspendLayout();
			((Button)aBu).DialogResult = (DialogResult)1;
			val.ApplyResources((object)aBu, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY());
			((Control)aBu).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((ButtonBase)aBu).UseVisualStyleBackColor = true;
			((Button)aBV).DialogResult = (DialogResult)2;
			val.ApplyResources((object)aBV, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy());
			((Control)aBV).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((ButtonBase)aBV).UseVisualStyleBackColor = true;
			val.ApplyResources((object)aBv, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBv());
			((Control)aBv).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBv();
			val.ApplyResources((object)aBW, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VF());
			((Control)aBW).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VF();
			((Form)this).AcceptButton = (IButtonControl)(object)aBu;
			val.ApplyResources((object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fr());
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)aBV;
			((Control)this).Controls.Add((Control)(object)aBu);
			((Control)this).Controls.Add((Control)(object)aBV);
			((Control)this).Controls.Add((Control)(object)aBv);
			((Control)this).Controls.Add((Control)(object)aBW);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aBW();
			((Form)this).ShowInTaskbar = false;
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
