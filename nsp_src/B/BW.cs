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
using System.Windows.Forms.Layout;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;
using crc;

namespace B
{
	internal class BW : Form
	{
		private class A
		{
			internal string BqZ;

			internal byte[] Bqz;

			internal bool BRA;
		}

		private class a
		{
			internal A BRa;

			internal uint BRB;

			internal global::A.A.b BRb;
		}

		internal class B : Form
		{
			private string BRC;

			private string BRc;

			private ThemedTextBox BRD = new ThemedTextBox();

			private int BRd = 50 - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG().Length;

			[SpecialName]
			internal string A()
			{
				return ((Control)BRD).Text;
			}

			internal B(string P_0, string P_1)
			{
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Unknown result type (might be due to invalid IL or missing references)
				//IL_012e: Unknown result type (might be due to invalid IL or missing references)
				//IL_015c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0179: Unknown result type (might be due to invalid IL or missing references)
				//IL_0199: Unknown result type (might be due to invalid IL or missing references)
				BRC = P_0;
				BRc = P_1;
				((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdD();
				((Control)this).Font = ((Control)BM.QQ).Font;
				((Control)this).BackColor = BM.td;
				((Control)this).ForeColor = BM.te;
				((Form)this).FormBorderStyle = (FormBorderStyle)3;
				((Form)this).MinimizeBox = false;
				((Form)this).MaximizeBox = false;
				((Form)this).ShowIcon = false;
				((Form)this).ShowInTaskbar = false;
				((Form)this).StartPosition = (FormStartPosition)4;
				((TextBoxBase)BRD).MaxLength = BRd;
				((Control)BRD).BackColor = BM.to;
				((Control)BRD).ForeColor = BM.te;
				((Control)BRD).Text = BRc;
				((Control)BRD).Width = 330;
				((Control)BRD).Location = new Point(10, 10);
				((Control)BRD).TabIndex = 0;
				ThemedButton themedButton = new ThemedButton();
				((Button)themedButton).DialogResult = (DialogResult)2;
				((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
				((Control)themedButton).Size = new Size(80, 30);
				((Control)themedButton).Location = new Point(260, 45);
				((Control)themedButton).TabIndex = 2;
				ThemedButton themedButton2 = new ThemedButton();
				((Button)themedButton2).DialogResult = (DialogResult)1;
				((Control)themedButton2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
				((Control)themedButton2).Size = new Size(80, 30);
				((Control)themedButton2).Location = new Point(((Control)themedButton).Left - (10 + ((Control)themedButton2).Width), 45);
				((Control)themedButton2).TabIndex = 1;
				((Form)this).CancelButton = (IButtonControl)(object)themedButton;
				((Form)this).ClientSize = new Size(350, 85);
				((Control)this).Controls.Add((Control)(object)themedButton2);
				((Control)this).Controls.Add((Control)(object)themedButton);
				((Control)this).Controls.Add((Control)(object)BRD);
			}

			protected override void OnShown(EventArgs e)
			{
				((Control)BRD).Focus();
				((TextBoxBase)BRD).SelectAll();
			}

			protected override void OnFormClosing(FormClosingEventArgs e)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Invalid comparison between Unknown and I4
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0163: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
				if ((int)((Form)this).DialogResult != 1)
				{
					return;
				}
				if (string.IsNullOrWhiteSpace(((Control)BRD).Text))
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdd(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((CancelEventArgs)e).Cancel = true;
					return;
				}
				string text = BRc.Substring(BRc.LastIndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()));
				char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
				int num = ((Control)BRD).Text.IndexOfAny(invalidFileNameChars);
				if (num >= 0)
				{
					System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mU());
					char c = ((Control)BRD).Text[num];
					bE.A((IWin32Window)(object)this, string.Concat(readOnlySpan, new System.ReadOnlySpan<char>(ref c), string.op_Implicit(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdE())), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((CancelEventArgs)e).Cancel = true;
					return;
				}
				if (((Control)BRD).Text.Contains(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()) && !((Control)BRD).Text.EndsWith(text))
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bde(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((CancelEventArgs)e).Cancel = true;
					return;
				}
				string text2 = ((Control)BRD).Text;
				if (!text2.ToLower().EndsWith(text.ToLower()))
				{
					text2 += text;
				}
				if (File.Exists(BRC + text2))
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wg() + ((Control)BRD).Text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BdF(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wh(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((CancelEventArgs)e).Cancel = true;
				}
				else if (text2.Length > BRd)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bdf() + BRd + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wG(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sO(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					((CancelEventArgs)e).Cancel = true;
				}
			}
		}

		internal class b : PictureBox
		{
			private const int BRE = 20;

			private BW BRe;

			private bool BRF;

			private bool BRf;

			[CompilerGenerated]
			private readonly bool BRG;

			[CompilerGenerated]
			private readonly string BRg = string.Empty;

			internal int BRH;

			[SpecialName]
			[CompilerGenerated]
			internal bool A()
			{
				return BRG;
			}

			[SpecialName]
			[CompilerGenerated]
			internal string a()
			{
				return BRg;
			}

			internal b(BW P_0, bool P_1, string P_2)
			{
				BRe = P_0;
				BRG = P_1;
				BRg = P_2;
			}

			[SpecialName]
			internal bool B()
			{
				return BRF;
			}

			[SpecialName]
			internal void A(bool P_0)
			{
				BRF = P_0;
				((Control)this).Invalidate();
			}

			protected override void OnPaint(PaintEventArgs e)
			{
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0042: Expected O, but got Unknown
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Expected O, but got Unknown
				if (B())
				{
					e.Graphics.Clear(Color.DodgerBlue);
				}
				else
				{
					e.Graphics.Clear(Color.WhiteSmoke);
				}
				if (BRf)
				{
					Pen val = new Pen(Color.DodgerBlue, 2f);
					try
					{
						e.Graphics.DrawRectangle(val, 1, 1, ((Control)this).Width - 2, ((Control)this).Height - 2);
					}
					finally
					{
						((System.IDisposable)val)?.Dispose();
					}
				}
				((PictureBox)this).OnPaint(e);
				if (B() && A())
				{
					Pen val2 = new Pen(Color.Red, 2f);
					try
					{
						e.Graphics.SmoothingMode = (SmoothingMode)2;
						e.Graphics.DrawLine(val2, ((Control)this).Width - 22, 2, ((Control)this).Width - 2, 22);
						e.Graphics.DrawLine(val2, ((Control)this).Width - 22, 22, ((Control)this).Width - 2, 2);
					}
					finally
					{
						((System.IDisposable)val2)?.Dispose();
					}
				}
			}

			protected override void OnMouseDown(MouseEventArgs e)
			{
				if (B() && A())
				{
					if (e.X > ((Control)this).Width - 22 && e.Y < 22)
					{
						BRe.D();
					}
					else if (e.Y > ((Control)this).Height - BRH)
					{
						BRe.d();
					}
					else
					{
						((Control)this).OnMouseClick(e);
					}
				}
				else
				{
					((Control)this).OnMouseClick(e);
				}
			}

			protected override void OnMouseEnter(EventArgs e)
			{
				((Control)this).OnMouseEnter(e);
				BRf = true;
				((Control)this).Invalidate();
			}

			protected override void OnMouseLeave(EventArgs e)
			{
				((Control)this).OnMouseLeave(e);
				BRf = false;
				((Control)this).Invalidate();
			}
		}

		private const int Wm = 140;

		private const int WN = 80;

		private const int Wn = 200;

		private const int WO = 90;

		private const float Wo = 8.5f;

		private const int WP = 5;

		private const int Wp = 10;

		private const string WQ = "Show All ";

		private const string Wq = "Show Default ";

		private const string WR = "Show Custom ";

		private string Wr;

		private string WS;

		private string Ws;

		private Framework WT;

		private bool Wt;

		private List<string> WU;

		private global::A.A.C Wu;

		private string WV;

		private bool Wv;

		private string WW;

		private string Ww;

		private int WX;

		private b Wx;

		internal string WY = string.Empty;

		internal bool Wy;

		private BackgroundWorker WZ;

		private BackgroundWorker Wz;

		private static readonly object wA = new object();

		private static bool wa = false;

		private IContainer wB;

		private TableLayoutPanelWithThemedScrollBars wb;

		private Panel wC;

		private ProgressBar wc;

		private ThemedButton wD;

		private ThemedButton wd;

		private ThemedButton wE;

		private Panel we;

		private SplitContainer wF;

		private W wf;

		private TableLayoutPanelWithThemedScrollBars wG;

		private PictureBox wg;

		private aF wH;

		private ThemedComboBox wh;

		public BW(Framework P_0, bool P_1, bool P_2, List<string> P_3, global::A.A.C P_4)
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected O, but got Unknown
			H();
			((Control)this).Text = Di.a(P_4) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wp();
			((Control)this).BackColor = BM.td;
			((Control)this).ForeColor = BM.te;
			((Control)wb).BackColor = ((Control)this).BackColor;
			((Control)we).BackColor = ((Control)this).BackColor;
			((Control)wF).BackColor = ((Control)this).BackColor;
			((Control)wF.Panel1).BackColor = ((Control)this).BackColor;
			((Control)wF.Panel2).BackColor = ((Control)this).BackColor;
			((Control)wG).BackColor = ((Control)this).BackColor;
			((Control)wC).BackColor = ((Control)this).BackColor;
			((Control)wf).BackColor = BM.tg;
			((Control)wH).BackColor = BM.tg;
			WT = P_0;
			Wr = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WQ() + Di.a(P_4);
			WS = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wq() + Di.a(P_4);
			Ws = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WR() + Di.a(P_4);
			((ComboBox)wh).Items.Add((object)Wr);
			((ComboBox)wh).Items.Add((object)WS);
			((ComboBox)wh).Items.Add((object)Ws);
			((ListControl)wh).SelectedIndex = 0;
			((ComboBox)wh).SelectedIndexChanged += new EventHandler(a);
			if (P_1)
			{
				Wt = true;
				((Control)wd).Visible = false;
				((Control)wD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.gV();
			}
			else
			{
				Wt = false;
				((Control)wd).Visible = true;
				((Control)wD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			}
			WU = P_3;
			Wu = P_4;
			WV = Di.B(P_4);
			Wv = P_2;
			WW = BM.Qu.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + WV + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK();
			Ww = BM.QR.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wr() + WV + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK();
		}

		private void A(object P_0, EventArgs P_1)
		{
			B();
		}

		private void a(object P_0, EventArgs P_1)
		{
			if (((ListControl)wh).SelectedIndex != -1)
			{
				if ((string)((ComboBox)wh).Items[((ListControl)wh).SelectedIndex] == Ws && !Wy)
				{
					E();
				}
				else if ((string)((ComboBox)wh).Items[((ListControl)wh).SelectedIndex] == WS && Wy)
				{
					E();
				}
				B();
			}
		}

		private bool A()
		{
			if (Directory.Exists(WW))
			{
				if (((ListControl)wh).SelectedIndex != -1 && !((string)((ComboBox)wh).Items[((ListControl)wh).SelectedIndex] == Ws))
				{
					return (string)((ComboBox)wh).Items[((ListControl)wh).SelectedIndex] == Wr;
				}
				return true;
			}
			return false;
		}

		private bool a()
		{
			if (Directory.Exists(Ww))
			{
				if (((ListControl)wh).SelectedIndex != -1 && !((string)((ComboBox)wh).Items[((ListControl)wh).SelectedIndex] == WS))
				{
					return (string)((ComboBox)wh).Items[((ListControl)wh).SelectedIndex] == Wr;
				}
				return true;
			}
			return false;
		}

		private void B()
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			((Control)wf).SuspendLayout();
			Wx = null;
			while (((ArrangedElementCollection)((Control)wf).Controls).Count != 0)
			{
				if (((Control)wf).Controls[0] is b b)
				{
					((Control)b).Click -= new EventHandler(B);
					((Control)b).DoubleClick -= new EventHandler(C);
					((PictureBox)b).Image.Dispose();
					((PictureBox)b).Image = null;
					((Component)b).Dispose();
				}
			}
			bool num = A();
			bool flag = a();
			List<string> val = new List<string>();
			if (num)
			{
				Enumerator<string> enumerator = WU.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WS() + current;
						val.AddRange((System.Collections.Generic.IEnumerable<string>)Directory.GetFiles(WW, text, (SearchOption)1));
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			List<string> val2 = new List<string>();
			if (flag)
			{
				Enumerator<string> enumerator = WU.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string current2 = enumerator.Current;
						string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WS() + current2;
						val2.AddRange((System.Collections.Generic.IEnumerable<string>)Directory.GetFiles(Ww, text2, (SearchOption)1));
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			b b2 = null;
			for (int i = 0; i < val.Count + val2.Count; i++)
			{
				bool flag2;
				b b3 = ((i >= val.Count) ? A(val2[i - val.Count], false, out flag2) : A(val[i], true, out flag2));
				if (flag2)
				{
					b2 = b3;
				}
			}
			((Control)wf).ResumeLayout(true);
			if (b2 != null)
			{
				B(b2, null);
				return;
			}
			this.b();
			C();
		}

		[DllImport("user32", EntryPoint = "GetWindowDC")]
		private static extern nint A(nint P_0);

		private b A(string P_0, bool P_1, out bool P_2)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0325: Unknown result type (might be due to invalid IL or missing references)
			//IL_032f: Expected O, but got Unknown
			//IL_0337: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected O, but got Unknown
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Expected O, but got Unknown
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Expected O, but got Unknown
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
			b b = new b(this, P_1, P_0);
			((Control)b).BackColor = Color.Transparent;
			((Control)b).Margin = new Padding(10);
			string fileName = Path.GetFileName(P_0);
			SizeF val = default(SizeF);
			Font val2 = new Font(((Control)this).Font.FontFamily, 8.5f);
			Image val3 = null;
			int num = 0;
			int num2 = 0;
			if (Wu == global::A.A.C.BFH)
			{
				try
				{
					Stream val4 = (Stream)(object)File.OpenRead(P_0);
					try
					{
						val3 = Image.FromStream(val4);
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
				catch
				{
					val3 = null;
				}
				if (val3 != null)
				{
					Size val5 = O.A(val3.Size, new Size(140, 140));
					num = ((Size)(ref val5)).Width;
					num2 = ((Size)(ref val5)).Height;
					int num3 = ((num >= 80) ? (5 + num + 5) : 90);
					Graphics val6 = Graphics.FromHdc((System.IntPtr)A(((Control)this).Handle));
					try
					{
						val = val6.MeasureString(fileName, val2, num3);
					}
					finally
					{
						((System.IDisposable)val6)?.Dispose();
					}
					((Control)b).Width = num3;
					((Control)b).Height = 5 + num2 + (int)((SizeF)(ref val)).Height + 5;
				}
				else if (IsMp4Path(P_0))
				{
					int num3 = 150;
					Graphics val6 = Graphics.FromHdc((System.IntPtr)A(((Control)this).Handle));
					try
					{
						val = val6.MeasureString(fileName, val2, num3);
					}
					finally
					{
						((System.IDisposable)val6)?.Dispose();
					}
					((Control)b).Width = num3;
					((Control)b).Height = 80 + (int)((SizeF)(ref val)).Height + 5;
				}
			}
			else if (Wu == global::A.A.C.BFh)
			{
				int num4 = 210;
				Graphics val7 = Graphics.FromHdc((System.IntPtr)A(((Control)this).Handle));
				try
				{
					val = val7.MeasureString(fileName, val2, num4);
				}
				finally
				{
					((System.IDisposable)val7)?.Dispose();
				}
				((Control)b).Width = num4;
				((Control)b).Height = 95 + (int)((SizeF)(ref val)).Height + 5;
			}
			Bitmap val8 = new Bitmap(((Control)b).Width, ((Control)b).Height);
			Graphics val9 = Graphics.FromImage((Image)(object)val8);
			val9.SmoothingMode = (SmoothingMode)2;
			if (Wu == global::A.A.C.BFH)
			{
				if (val3 != null)
				{
					int num5 = ((Control)b).Width / 2 - num / 2;
					int num6 = 5 + (((Control)b).Height - (5 + (int)((SizeF)(ref val)).Height + 5)) / 2 - num2 / 2;
					val9.DrawImage(val3, num5, num6, num, num2);
				}
				else if (IsMp4Path(P_0))
				{
					val9.FillRectangle(Brushes.LightGray, 5, 5, ((Control)b).Width - 10, 70);
					val9.DrawString("MP4 video", val2, Brushes.Black, 10f, 30f);
				}
			}
			else if (Wu == global::A.A.C.BFh)
			{
				try
				{
					A(P_0, val9, 18f, ((Control)b).Width, 95, false);
				}
				catch
				{
				}
			}
			if (((SizeF)(ref val)).Width != 0f && ((SizeF)(ref val)).Height != 0f)
			{
				StringFormat val10 = new StringFormat();
				try
				{
					SolidBrush val11 = new SolidBrush(Color.Black);
					try
					{
						val10.Alignment = (StringAlignment)1;
						val10.LineAlignment = (StringAlignment)1;
						val9.TextRenderingHint = (TextRenderingHint)3;
						float height = ((SizeF)(ref val)).Height;
						SizeF val12 = val9.MeasureString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ws(), val2);
						if (height <= ((SizeF)(ref val12)).Height * 1.2f)
						{
							val9.DrawString(fileName, val2, (Brush)(object)val11, (float)(((Control)b).Width / 2), (float)((Control)b).Height - ((SizeF)(ref val)).Height / 2f, val10);
						}
						else
						{
							val9.DrawString(fileName, val2, (Brush)(object)val11, new RectangleF(0f, (float)((Control)b).Height - ((SizeF)(ref val)).Height, ((SizeF)(ref val)).Width, ((SizeF)(ref val)).Height), val10);
						}
						b.BRH = (int)((SizeF)(ref val)).Height;
					}
					finally
					{
						((System.IDisposable)val11)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val10)?.Dispose();
				}
			}
			((PictureBox)b).Image = (Image)(object)val8;
			val9.Dispose();
			if (val3 != null)
			{
				val3.Dispose();
			}
			val2.Dispose();
			((Control)b).Click += new EventHandler(B);
			((Control)b).DoubleClick += new EventHandler(C);
			((Control)wf).Controls.Add((Control)(object)b);
			P_2 = false;
			if ((P_1 && Wy && P_0.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()).Substring(WW.Length) == WY.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK())) || (!P_1 && !Wy && P_0.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()).Substring(Ww.Length) == WY.Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK())))
			{
				P_2 = true;
			}
			return b;
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			b b = P_0 as b;
			b.A(true);
			Wx = b;
			if (b.A())
			{
				WY = b.a().Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()).Substring(WW.Length);
				Wy = true;
			}
			else
			{
				WY = b.a().Replace(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()).Substring(Ww.Length);
				Wy = false;
			}
			foreach (Control item in (ArrangedElementCollection)((Control)wf).Controls)
			{
				if (item is b b2 && b2 != b)
				{
					b2.A(false);
				}
			}
			((Control)wd).Enabled = true;
			((Control)wf).Focus();
			((ScrollableControl)wf).ScrollControlIntoView((Control)(object)b);
			wf.a();
			this.b();
			C();
		}

		private void b()
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
			Bitmap val = new Bitmap(((Control)wg).Width, ((Control)wg).Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				if (Wv)
				{
					val2.Clear(((Control)wg).Parent.BackColor);
					Size val3 = O.A(WT.awW.aa(), ((Control)wg).Size);
					val2.FillRectangle(Brushes.Black, ((Control)wg).Width / 2 - ((Size)(ref val3)).Width / 2, ((Control)wg).Height / 2 - ((Size)(ref val3)).Height / 2, ((Size)(ref val3)).Width, ((Size)(ref val3)).Height);
					if (Wx != null)
					{
						try
						{
							Stream val4 = (Stream)(object)File.OpenRead(Wx.a());
							try
							{
								Image val5 = Image.FromStream(val4);
								try
								{
									float num = ((Size)(ref val3)).Width;
									Size val6 = WT.awW.aa();
									float num2 = num / (float)((Size)(ref val6)).Width;
									Size val7 = O.A(new Size((int)((float)val5.Width * num2), (int)((float)val5.Height * num2)), val3);
									val2.InterpolationMode = (InterpolationMode)7;
									val2.SmoothingMode = (SmoothingMode)2;
									val2.CompositingQuality = (CompositingQuality)2;
									val2.PixelOffsetMode = (PixelOffsetMode)2;
									val2.DrawImage(val5, ((Control)wg).Width / 2 - ((Size)(ref val7)).Width / 2, ((Control)wg).Height / 2 - ((Size)(ref val7)).Height / 2, ((Size)(ref val7)).Width, ((Size)(ref val7)).Height);
								}
								finally
								{
									((System.IDisposable)val5)?.Dispose();
								}
							}
							finally
							{
								((System.IDisposable)val4)?.Dispose();
							}
						}
						catch (System.Exception ex)
						{
							bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WT() + Wx.a() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wt() + ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						}
					}
					val2.DrawRectangle(Pens.Gray, 1 + ((Control)wg).Width / 2 - ((Size)(ref val3)).Width / 2, 1 + ((Control)wg).Height / 2 - ((Size)(ref val3)).Height / 2, ((Size)(ref val3)).Width - 2, ((Size)(ref val3)).Height - 2);
				}
				else
				{
					for (int i = 0; i < ((Control)wg).Width; i += 15)
					{
						for (int j = 0; j < ((Control)wg).Height; j += 15)
						{
							if (((i & 1) == 1 && (j & 1) == 0) || ((i & 1) == 0 && (j & 1) == 1))
							{
								val2.FillRectangle(Brushes.White, i, j, 15, 15);
							}
							else
							{
								val2.FillRectangle(Brushes.WhiteSmoke, i, j, 15, 15);
							}
						}
					}
					if (Wx != null)
					{
						try
						{
							if (Wu == global::A.A.C.BFH)
							{
								Stream val8 = (Stream)(object)File.OpenRead(Wx.a());
								try
								{
									Image val9 = Image.FromStream(val8);
									try
									{
										Size val10 = O.A(val9.Size, ((Control)wg).Size);
										int width = ((Size)(ref val10)).Width;
										int height = ((Size)(ref val10)).Height;
										if (val10 != val9.Size)
										{
											val2.InterpolationMode = (InterpolationMode)7;
											val2.SmoothingMode = (SmoothingMode)2;
											val2.CompositingQuality = (CompositingQuality)2;
											val2.PixelOffsetMode = (PixelOffsetMode)2;
										}
										val2.DrawImage(val9, ((Control)wg).Width / 2 - width / 2, ((Control)wg).Height / 2 - height / 2, width, height);
									}
									finally
									{
										((System.IDisposable)val9)?.Dispose();
									}
								}
								finally
								{
									((System.IDisposable)val8)?.Dispose();
								}
							}
							else if (Wu == global::A.A.C.BFh)
							{
								A(Wx.a(), val2, 22f, ((Control)wg).Width, ((Control)wg).Height, true);
							}
						}
						catch (System.Exception ex2)
						{
							bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WU() + Wx.a() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wt() + ex2.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
			if (wg.Image != null)
			{
				wg.Image.Dispose();
			}
			wg.Image = (Image)(object)val;
		}

		private void C()
		{
			//IL_034b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected O, but got Unknown
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected O, but got Unknown
			//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a9: Expected O, but got Unknown
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f8: Expected O, but got Unknown
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected O, but got Unknown
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected O, but got Unknown
			//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0464: Unknown result type (might be due to invalid IL or missing references)
			//IL_0470: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected O, but got Unknown
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Expected O, but got Unknown
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0556: Unknown result type (might be due to invalid IL or missing references)
			//IL_055d: Expected O, but got Unknown
			//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0604: Unknown result type (might be due to invalid IL or missing references)
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			//IL_0618: Expected O, but got Unknown
			//IL_0649: Unknown result type (might be due to invalid IL or missing references)
			//IL_0655: Unknown result type (might be due to invalid IL or missing references)
			while (((ArrangedElementCollection)((Control)wH).Controls).Count != 0)
			{
				if (((Control)wH).Controls[0] is ThemedButton)
				{
					((Control)wH).Controls[0].Click -= new EventHandler(E);
					((Control)wH).Controls[0].Click -= new EventHandler(e);
					((Control)wH).Controls[0].Click -= new EventHandler(d);
				}
				((Component)((Control)wH).Controls[0]).Dispose();
			}
			if (string.IsNullOrWhiteSpace(WY) || Wx == null)
			{
				return;
			}
			int num = 10;
			Font font = new Font(((Control)this).Font.FontFamily, 9f);
			ThemedButton themedButton = null;
			ThemedButton themedButton2 = null;
			if (Wy)
			{
				themedButton = new ThemedButton();
				((Control)themedButton).Font = font;
				((Control)themedButton).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wu() + Di.A(Wu);
				((Control)themedButton).Size = new Size(120, 28);
				((Control)themedButton).Left = 10;
				((Control)themedButton).Top = num;
				((Control)wH).Controls.Add((Control)(object)themedButton);
				((Control)themedButton).Click += new EventHandler(E);
				themedButton2 = new ThemedButton();
				((Control)themedButton2).Font = font;
				((Control)themedButton2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WV() + Di.A(Wu);
				((Control)themedButton2).Size = new Size(120, 28);
				((Control)themedButton2).Left = ((Control)themedButton).Left + ((Control)themedButton).Width + 10;
				((Control)themedButton2).Top = num;
				((Control)wH).Controls.Add((Control)(object)themedButton2);
				((Control)themedButton2).Click += new EventHandler(e);
			}
			ThemedButton themedButton3 = new ThemedButton();
			((Control)themedButton3).Font = font;
			((Control)themedButton3).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wv() + Di.A(Wu);
			((Control)themedButton3).Size = new Size(120, 28);
			if (Wy)
			{
				((Control)themedButton3).Left = ((Control)themedButton2).Left + ((Control)themedButton2).Width + 10;
			}
			else
			{
				((Control)themedButton3).Left = 10;
			}
			((Control)themedButton3).Top = num;
			((Control)wH).Controls.Add((Control)(object)themedButton3);
			((Control)themedButton3).Click += new EventHandler(d);
			num += 35;
			Label val = new Label();
			((Control)val).AutoSize = true;
			((Control)val).Font = font;
			((Control)val).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WW() + WY;
			((Control)val).BackColor = ((Control)wH).BackColor;
			((Control)val).ForeColor = BM.te;
			((Control)val).Left = 10;
			((Control)val).Top = num;
			((Control)wH).Controls.Add((Control)(object)val);
			num += 20;
			int num2;
			int num3;
			int num4;
			try
			{
				Stream val2 = (Stream)(object)File.OpenRead(Wx.a());
				try
				{
					num2 = (int)val2.Length;
					if (Wu == global::A.A.C.BFH)
					{
						Image val3 = Image.FromStream(val2);
						try
						{
							num3 = val3.Width;
							num4 = val3.Height;
						}
						finally
						{
							((System.IDisposable)val3)?.Dispose();
						}
					}
					else
					{
						num3 = 0;
						num4 = 0;
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			catch
			{
				num2 = 0;
				num3 = 0;
				num4 = 0;
			}
			Label val4 = new Label();
			((Control)val4).AutoSize = true;
			((Control)val4).Font = font;
			if (num2 != 0)
			{
				((Control)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ww() + bS.a(num2, 94, -1) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.DG() + bS.A(0, 94, true, num2);
			}
			else
			{
				((Control)val4).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ww();
			}
			((Control)val4).BackColor = ((Control)wH).BackColor;
			((Control)val4).ForeColor = BM.te;
			((Control)val4).Left = 10;
			((Control)val4).Top = num;
			((Control)wH).Controls.Add((Control)(object)val4);
			num += 20;
			if (Wu == global::A.A.C.BFH)
			{
				Label val5 = new Label();
				((Control)val5).AutoSize = true;
				((Control)val5).Font = font;
				if (num3 != 0 && num4 != 0)
				{
					((Control)val5).Text = string.Concat(new string[5]
					{
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WX(),
						num3.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wx(),
						num4.ToString(),
						D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WY()
					});
				}
				else
				{
					((Control)val5).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WX();
				}
				((Control)val5).BackColor = ((Control)wH).BackColor;
				((Control)val5).ForeColor = BM.te;
				((Control)val5).Left = 10;
				((Control)val5).Top = num;
				((Control)wH).Controls.Add((Control)(object)val5);
				num += 20;
			}
			Label val6 = new Label();
			((Control)val6).AutoSize = true;
			((Control)val6).Font = font;
			((Control)val6).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wy() + (Wy ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wz() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WZ());
			((Control)val6).BackColor = ((Control)wH).BackColor;
			((Control)val6).ForeColor = BM.te;
			((Control)val6).Left = 10;
			((Control)val6).Top = num;
			((Control)wH).Controls.Add((Control)(object)val6);
			num += 20;
			if (WT.awP == null)
			{
				return;
			}
			List<Setting> obj2 = WT.awP.A(WY, Wu, Wy);
			Label val7 = new Label();
			((Control)val7).AutoSize = true;
			((Control)val7).Font = font;
			if (obj2.Count != 0)
			{
				((Control)val7).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wA() + Di.A(Wu) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wa();
			}
			else
			{
				((Control)val7).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wA() + Di.A(Wu) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wB();
			}
			((Control)val7).BackColor = ((Control)wH).BackColor;
			((Control)val7).ForeColor = BM.te;
			((Control)val7).Left = 10;
			((Control)val7).Top = num;
			((Control)wH).Controls.Add((Control)(object)val7);
			num += 17;
			Enumerator<Setting> enumerator = obj2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Setting current = enumerator.Current;
					Label val8 = new Label();
					((Control)val8).AutoSize = true;
					((Control)val8).Font = font;
					((Control)val8).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.VM() + ((SettingOrSpecialObject)current).A(bz.aYt);
					((Control)val8).BackColor = ((Control)wH).BackColor;
					((Control)val8).ForeColor = BM.te;
					((Control)val8).Left = 10;
					((Control)val8).Top = num;
					((Control)wH).Controls.Add((Control)(object)val8);
					num += 17;
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}

		private void c()
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected O, but got Unknown
			if (string.IsNullOrWhiteSpace(WY) || Wx == null)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wb(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wb(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else if (Wv && BM.A(WT.aXc, true))
			{
				((Control)wd).Enabled = false;
				if (WZ == null && Wz == null)
				{
					Wz = new BackgroundWorker();
					Wz.WorkerReportsProgress = true;
					Wz.WorkerSupportsCancellation = true;
					Wz.DoWork += new DoWorkEventHandler(A);
					Wz.ProgressChanged += new ProgressChangedEventHandler(A);
					Wz.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
					Wz.RunWorkerAsync();
				}
			}
			else
			{
				((Form)this).DialogResult = (DialogResult)1;
				((Form)this).Close();
			}
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			Wz.ReportProgress(0);
			((Control)this).Invoke((Action)([CompilerGenerated] () =>
			{
				((Control)wc).Visible = true;
				((Control)wc).BringToFront();
			}));
			string text = ((!Wy) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Oh() + WY) : (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG() + WY));
			uint num = 0u;
			Setting setting = WT.A(WT.awW.ab());
			if (setting != null)
			{
				num = (uint)setting.ax();
			}
			BM.A(Wz, 0, 100, text, -1, num, out var result);
			P_1.Result = result;
		}

		private void A(object P_0, ProgressChangedEventArgs P_1)
		{
			wc.Value = P_1.ProgressPercentage;
		}

		private void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			Wz = null;
			((Control)wd).Enabled = true;
			if (!(P_1.Result is string text))
			{
				string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wC();
				if (((Control)this).Disposing || ((Control)this).IsDisposed)
				{
					bE.A((IWin32Window)(object)BM.QQ, text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.g(), (MessageBoxButtons)0, (MessageBoxIcon)64);
					return;
				}
				bE.A((IWin32Window)(object)this, text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.g(), (MessageBoxButtons)0, (MessageBoxIcon)64);
				((Control)wc).Visible = false;
				((Form)this).DialogResult = (DialogResult)1;
				((Form)this).Close();
			}
			else if (((Control)this).Disposing || ((Control)this).IsDisposed)
			{
				bE.A((IWin32Window)(object)BM.QQ, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else
			{
				bE.A((IWin32Window)(object)this, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((Control)wc).Visible = false;
			}
		}

		private void b(object P_0, EventArgs P_1)
		{
			c();
		}

		private void C(object P_0, EventArgs P_1)
		{
			if (!Wt)
			{
				B(P_0, P_1);
				c();
			}
		}

		private void c(object P_0, EventArgs P_1)
		{
			((Form)this).DialogResult = (DialogResult)2;
			((Form)this).Close();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Invalid comparison between Unknown and I4
			if (WZ != null)
			{
				((CancelEventArgs)P_1).Cancel = true;
			}
			else if (Wv && (int)((Form)this).DialogResult == 2 && Wz != null)
			{
				Wz.CancelAsync();
			}
		}

		private void A(object P_0, DragEventArgs P_1)
		{
			if (P_1.Data.GetDataPresent(DataFormats.FileDrop))
			{
				P_1.Effect = (DragDropEffects)1;
			}
		}

		private void a(object P_0, DragEventArgs P_1)
		{
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				string[] array = (string[])P_1.Data.GetData(DataFormats.FileDrop);
				WX = array.Length;
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					bool flag = false;
					string extension = Path.GetExtension(text);
					if (!string.IsNullOrWhiteSpace(extension) && extension.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()))
					{
						string text2 = extension.Substring(1);
						Enumerator<string> enumerator = WU.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.ToLower() == text2.ToLower())
								{
									flag = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
					bool flag2 = array.Length > 1;
					if (flag)
					{
						if (!A(text, flag2))
						{
							WX--;
						}
						continue;
					}
					WX--;
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Og() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wc(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wD(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					if (flag2 && i == array.Length - 1)
					{
						B();
					}
				}
			}
			catch (System.Exception ex)
			{
				WX = 0;
				N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wd() + ex.Message, true);
			}
		}

		private void D(object P_0, EventArgs P_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Invalid comparison between Unknown and I4
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wE();
			val.Multiselect = true;
			string text = string.Empty;
			Enumerator<string> enumerator = WU.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.WS() + current;
					if (WU.IndexOf(current) != WU.Count - 1)
					{
						text += D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bV();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			((FileDialog)val).Filter = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.we() + text;
			if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
			{
				WX = ((FileDialog)val).FileNames.Length;
				string[] fileNames = ((FileDialog)val).FileNames;
				foreach (string text2 in fileNames)
				{
					if (!A(text2, ((FileDialog)val).FileNames.Length > 1))
					{
						WX--;
					}
				}
			}
			((Component)val).Dispose();
		}

		private bool A(string P_0, bool P_1)
		{
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Invalid comparison between Unknown and I4
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected O, but got Unknown
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected O, but got Unknown
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Expected O, but got Unknown
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Invalid comparison between Unknown and I4
			string fileName = Path.GetFileName(P_0);
			int num = 50 - D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG().Length;
			if (fileName.Length > num)
			{
				bE.A((IWin32Window)(object)this, string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wF(),
					fileName,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wf(),
					num.ToString(),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wG()
				}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sO(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return false;
			}
			if (File.Exists(WW + fileName) && (int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wg() + fileName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wH(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wh(), (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)256, new string[2]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wI(),
				P_1 ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wi() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV()
			}) == 2)
			{
				return false;
			}
			byte[] array;
			try
			{
				array = File.ReadAllBytes(P_0);
			}
			catch (System.Exception ex)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wJ() + fileName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wj() + ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return false;
			}
			byte[] array2;
			try
			{
				array2 = ((Wu != 0) ? array : A(array, Path.GetExtension(P_0)));
			}
			catch (System.Exception ex2)
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wK() + fileName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wj() + ex2.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return false;
			}
			if (Wu == global::A.A.C.BFH && array2 != array && (int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wk() + fileName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wL(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wl(), (MessageBoxButtons)1, (MessageBoxIcon)48, (MessageBoxDefaultButton)0, new string[2]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU(),
				P_1 ? D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wi() : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV()
			}) == 2)
			{
				return false;
			}
			A a = new A
			{
				BqZ = fileName,
				Bqz = array2,
				BRA = P_1
			};
			((Control)wD).Enabled = false;
			BackgroundWorker val = new BackgroundWorker
			{
				WorkerReportsProgress = true,
				WorkerSupportsCancellation = false
			};
			val.DoWork += new DoWorkEventHandler(this.a);
			val.ProgressChanged += new ProgressChangedEventHandler(this.a);
			val.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.a);
			val.RunWorkerAsync((object)a);
			return true;
		}

		private bool A(Image P_0, string P_1)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			string text = P_1.ToLower();
			if (text == ".gif")
			{
				return P_0.RawFormat.Guid == ImageFormat.Gif.Guid;
			}
			if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wM()))
			{
				if (!(text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wm()))
				{
					if (text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wN() || text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wn())
					{
						return P_0.RawFormat.Guid == ImageFormat.Jpeg.Guid;
					}
					return false;
				}
				return P_0.RawFormat.Guid == ImageFormat.Png.Guid;
			}
			return P_0.RawFormat.Guid == ImageFormat.Bmp.Guid;
		}

		private byte[] A(byte[] P_0, string P_1)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Expected O, but got Unknown
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			string extension = P_1.ToLowerInvariant();
			if (extension == ".gif")
			{
				MemoryStream gifStream = new MemoryStream(P_0);
				try
				{
					Image gifImage = Image.FromStream((Stream)(object)gifStream);
					try
					{
						if (A(gifImage, P_1))
						{
							return P_0;
						}
					}
					finally
					{
						((System.IDisposable)gifImage)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)gifStream)?.Dispose();
				}
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wO());
			}
			if (extension == ".mp4")
			{
				if (P_0.Length >= 12 && P_0[4] == (byte)'f' && P_0[5] == (byte)'t' && P_0[6] == (byte)'y' && P_0[7] == (byte)'p')
				{
					return P_0;
				}
				throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wO());
			}
			byte[] result = P_0;
			MemoryStream val = new MemoryStream(P_0);
			try
			{
				Image val2 = Image.FromStream((Stream)(object)val);
				try
				{
					if (!A(val2, P_1))
					{
						throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wO());
					}
					if (val2.Width > 2560 || val2.Height > 2560)
					{
						int num;
						int num2;
						if (val2.Width > val2.Height)
						{
							num = 2560;
							num2 = 2560 * val2.Height / val2.Width;
						}
						else
						{
							num2 = 2560;
							num = 2560 * val2.Width / val2.Height;
						}
						Bitmap val3 = new Bitmap(num, num2);
						try
						{
							Graphics val4 = Graphics.FromImage((Image)(object)val3);
							try
							{
								val4.SmoothingMode = (SmoothingMode)2;
								val4.DrawImage(val2, 0, 0, num, num2);
								MemoryStream val5 = new MemoryStream();
								try
								{
									((Image)val3).Save((Stream)(object)val5, val2.RawFormat);
									result = val5.ToArray();
								}
								finally
								{
									((System.IDisposable)val5)?.Dispose();
								}
							}
							finally
							{
								((System.IDisposable)val4)?.Dispose();
							}
						}
						finally
						{
							((System.IDisposable)val3)?.Dispose();
						}
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
			return result;
		}

		private static bool IsMp4Path(string P_0)
		{
			return string.Equals(Path.GetExtension(P_0), ".mp4", StringComparison.OrdinalIgnoreCase);
		}

		private void a(object P_0, DoWorkEventArgs P_1)
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			lock (wA)
			{
				WZ = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
				A a = P_1.Argument as A;
				uint num = 0u;
				global::A.A.b b = global::A.A.b.BFb;
				if (BM.A(WT.aXc, true))
				{
					((Control)this).Invoke((Action)([CompilerGenerated] () =>
					{
						((Control)wc).Visible = true;
						((Control)wc).BringToFront();
					}));
					WZ.ReportProgress(0);
					j j = new j();
					j.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG() + a.BqZ);
					j.CH = (uint)a.Bqz.Length;
					j.Cg = Wu;
					j.Ch = new global::crc.crc().crc_process(a.Bqz, 0u, (uint)a.Bqz.Length, 4294967295u, partial: false);
					j j2 = j;
					WZ.ReportProgress(10);
					do
					{
						uint num2 = global::A.A.a(WT.aXc, global::A.f.Bb);
						uint num3 = 68u;
						uint num4 = Math.Min(num2 - num3, (uint)a.Bqz.Length - num);
						byte[] array = new byte[num4];
						System.Array.Copy((System.Array)a.Bqz, (long)num, (System.Array)array, 0L, (long)num4);
						if (!global::A.A.A(WT.aXc, j2, num, array, out b, out var _) || b != 0)
						{
							break;
						}
						num += num4;
						WZ.ReportProgress((int)(10 + (long)num * 90L / a.Bqz.Length));
					}
					while (num < a.Bqz.Length);
					Thread.Sleep(300);
				}
				a result = new a
				{
					BRa = a,
					BRB = num,
					BRb = b
				};
				P_1.Result = result;
				WX--;
				if (WX <= 0 || !a.BRA)
				{
					WZ = null;
				}
			}
		}

		private void a(object P_0, ProgressChangedEventArgs P_1)
		{
			wc.Value = P_1.ProgressPercentage;
		}

		private void a(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			((Control)wD).Enabled = true;
			a a = P_1.Result as a;
			bool flag = WX <= 0 || !a.BRa.BRA;
			if (flag)
			{
				((Control)wc).Visible = false;
			}
			if (a.BRB == a.BRa.Bqz.Length || !BM.A(WT.aXc, true))
			{
				if (BM.A(BM.Qu, a.BRa.BqZ, a.BRa.Bqz, WV, out var text))
				{
					WY = a.BRa.BqZ;
					Wy = true;
				}
				else
				{
					bE.A((IWin32Window)(object)this, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				BM.A(WT, a.BRa.BqZ, a.BRa.Bqz, WV, out text);
			}
			else
			{
				bE.A((IWin32Window)(object)this, string.Concat(new string[5]
				{
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wo(),
					a.BRa.BqZ,
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wP(),
					global::A.A.A(a.BRb),
					D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E()
				}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			if (flag)
			{
				B();
			}
		}

		private void d(object P_0, EventArgs P_1)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Invalid comparison between Unknown and I4
			if (Wx == null)
			{
				return;
			}
			string text = null;
			string text2 = null;
			try
			{
				text = Path.GetExtension(Wx.a());
				text2 = Path.GetFileName(Wx.a());
			}
			catch (System.Exception ex)
			{
				bE.A((IWin32Window)(object)this, ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			SaveFileDialog val = new SaveFileDialog();
			((FileDialog)val).Title = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wp();
			((FileDialog)val).Filter = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wQ() + text;
			((FileDialog)val).FileName = text2;
			if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
			{
				try
				{
					File.Copy(Wx.a(), ((FileDialog)val).FileName);
				}
				catch (System.Exception ex2)
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wq() + ex2.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			((Component)val).Dispose();
		}

		private void E(object P_0, EventArgs P_1)
		{
			D();
		}

		private void D()
		{
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Invalid comparison between Unknown and I4
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			if (Wx == null)
			{
				return;
			}
			if (Wx.A())
			{
				string wY = WY;
				List<Setting> val = WT.awP.A(WY, Wu, true);
				string text = string.Empty;
				if (val.Count != 0)
				{
					text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wR();
					Enumerator<Setting> enumerator = val.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Setting current = enumerator.Current;
							text = text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wr() + ((SettingOrSpecialObject)current).A(bz.aYt);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				if ((int)bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wS() + wY + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ws() + text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.uK(), (MessageBoxButtons)4, (MessageBoxIcon)48, (MessageBoxDefaultButton)256) == 7)
				{
					return;
				}
				global::A.A.b b = global::A.A.b.BFb;
				bool flag = BM.A(WT.aXc, true);
				if (flag)
				{
					byte[] array;
					try
					{
						array = File.ReadAllBytes(Wx.a());
					}
					catch (System.Exception ex)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wT() + ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					j j = new j();
					j.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG() + wY);
					j.CH = (uint)array.Length;
					j.Cg = Wu;
					j.Ch = new global::crc.crc().crc_process(array, 0u, (uint)array.Length, 4294967295u, partial: false);
					j j2 = j;
					if (!global::A.A.A(WT.aXc, j2, out b, out var _))
					{
						b = global::A.A.b.BFb;
					}
				}
				if (b == global::A.A.b.BFC || b == global::A.A.b.BFG || !flag)
				{
					E();
					try
					{
						File.Delete(Wx.a());
					}
					catch (System.Exception ex2)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wt() + Wx.a() + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wt() + ex2.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					Enumerator<Setting> enumerator = val.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.A(string.Empty, true);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					B();
					((Control)wf).Focus();
					BM.A(WT, wY, WV, out var _);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wU() + global::A.A.A(b) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			else
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wu(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wV(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private void e(object P_0, EventArgs P_1)
		{
			d();
		}

		private void d()
		{
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Invalid comparison between Unknown and I4
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			if (Wx == null)
			{
				return;
			}
			if (Wx.A())
			{
				string wY = WY;
				string text = Wx.a();
				List<Setting> val = WT.awP.A(wY, Wu, true);
				if ((int)A(wY, out var text2) == 2)
				{
					return;
				}
				string text3 = text.Substring(0, text.IndexOf(wY)) + text2;
				global::A.A.b b = global::A.A.b.BFb;
				bool flag = BM.A(WT.aXc, true);
				if (flag)
				{
					byte[] array;
					try
					{
						array = File.ReadAllBytes(text);
					}
					catch (System.Exception ex)
					{
						bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wT() + ex.Message, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					j j = new j();
					j.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG() + wY);
					j.CH = (uint)array.Length;
					j.Cg = Wu;
					j.Ch = new global::crc.crc().crc_process(array, 0u, (uint)array.Length, 4294967295u, partial: false);
					j j2 = j;
					j j3 = new j();
					j3.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG() + text2);
					j3.CH = j2.CH;
					j3.Cg = j2.Cg;
					j3.Ch = j2.Ch;
					j j4 = j3;
					if (!global::A.A.A(WT.aXc, j2, j4, out b, out var _))
					{
						b = global::A.A.b.BFb;
					}
				}
				if (b == global::A.A.b.BFC || !flag)
				{
					E();
					try
					{
						File.Move(text, text3);
						WY = text2;
						Wy = true;
					}
					catch (System.Exception ex2)
					{
						bE.A((IWin32Window)(object)this, string.Concat(new string[6]
						{
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wv(),
							text,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TR(),
							text3,
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Wt(),
							ex2.Message
						}), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					Enumerator<Setting> enumerator = val.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG() + text2, true);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					B();
					((Control)wf).Focus();
					BM.A(WT, wY, text2, WV, out var _);
				}
				else
				{
					bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wW() + global::A.A.A(b) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.E(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			else
			{
				bE.A((IWin32Window)(object)this, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ww(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wX(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private DialogResult A(string P_0, out string P_1)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			B b = new B(WW, P_0);
			DialogResult result = ((Form)b).ShowDialog((IWin32Window)(object)this);
			string text = P_0.Substring(P_0.LastIndexOf(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bq()));
			P_1 = b.A();
			if (!P_1.ToLower().EndsWith(text.ToLower()))
			{
				P_1 += text;
			}
			((Component)b).Dispose();
			return result;
		}

		private void F(object P_0, EventArgs P_1)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			Wx = null;
			foreach (Control item in (ArrangedElementCollection)((Control)wf).Controls)
			{
				if (item is b b)
				{
					b.A(false);
				}
			}
			E();
			((Control)wf).Focus();
		}

		private void E()
		{
			WY = string.Empty;
			Wy = false;
			((Control)wd).Enabled = false;
			b();
			C();
		}

		private void A(object P_0, PreviewKeyDownEventArgs P_1)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Invalid comparison between Unknown and I4
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Invalid comparison between Unknown and I4
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Invalid comparison between Unknown and I4
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Invalid comparison between Unknown and I4
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Invalid comparison between Unknown and I4
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Invalid comparison between Unknown and I4
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Invalid comparison between Unknown and I4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Invalid comparison between Unknown and I4
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Invalid comparison between Unknown and I4
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Invalid comparison between Unknown and I4
			if (((ArrangedElementCollection)((Control)wf).Controls).Count != 0)
			{
				P_1.IsInputKey = true;
				if ((int)P_1.KeyData == 27)
				{
					e();
				}
				else if (((int)P_1.KeyData == 13 || (int)P_1.KeyData == 13) && !string.IsNullOrWhiteSpace(WY))
				{
					b(null, null);
				}
				else if ((int)P_1.KeyData == 46 && !string.IsNullOrWhiteSpace(WY))
				{
					E(null, null);
				}
				else if ((int)P_1.KeyData == 9 || (int)P_1.KeyData == 39)
				{
					f();
				}
				else if ((int)P_1.KeyData == 65545 || (int)P_1.KeyData == 37)
				{
					F();
				}
				else if ((int)P_1.KeyData == 40)
				{
					g();
				}
				else if ((int)P_1.KeyData == 38)
				{
					G();
				}
			}
		}

		private void e()
		{
			if (string.IsNullOrWhiteSpace(WY))
			{
				c(null, null);
			}
			else
			{
				F(null, null);
			}
		}

		private void F()
		{
			if (string.IsNullOrWhiteSpace(WY))
			{
				if (((ArrangedElementCollection)((Control)wf).Controls).Count != 0)
				{
					B(((Control)wf).Controls[0], null);
				}
			}
			else if (Wx != null)
			{
				int num = ((Control)wf).Controls.IndexOf((Control)(object)Wx);
				int num2 = ((num <= 0) ? (((ArrangedElementCollection)((Control)wf).Controls).Count - 1) : (num - 1));
				B(((Control)wf).Controls[num2], null);
			}
		}

		private void f()
		{
			if (string.IsNullOrWhiteSpace(WY))
			{
				if (((ArrangedElementCollection)((Control)wf).Controls).Count != 0)
				{
					B(((Control)wf).Controls[0], null);
				}
			}
			else if (Wx != null)
			{
				int num = ((Control)wf).Controls.IndexOf((Control)(object)Wx);
				int num2 = ((num < ((ArrangedElementCollection)((Control)wf).Controls).Count - 1) ? (num + 1) : 0);
				B(((Control)wf).Controls[num2], null);
			}
		}

		private void G()
		{
			if (string.IsNullOrWhiteSpace(WY))
			{
				if (((ArrangedElementCollection)((Control)wf).Controls).Count != 0)
				{
					B(((Control)wf).Controls[0], null);
				}
			}
			else
			{
				if (Wx == null)
				{
					return;
				}
				int num = ((Control)wf).Controls.IndexOf((Control)(object)Wx);
				int num2 = -1;
				bool flag = false;
				if (num > 0)
				{
					for (int num3 = num - 1; num3 >= 0; num3--)
					{
						if (((Control)wf).Controls[num3].Top < ((Control)Wx).Top)
						{
							flag = true;
							num2 = num3;
							int num4 = num3;
							while (num4 >= 0 && ((Control)wf).Controls[num4].Top == ((Control)wf).Controls[num3].Top)
							{
								if (A(((Control)wf).Controls[num4], (Control)(object)Wx))
								{
									num2 = num4;
									break;
								}
								num4--;
							}
							break;
						}
					}
				}
				if (!flag)
				{
					num2 = ((ArrangedElementCollection)((Control)wf).Controls).Count - 1;
				}
				B(((Control)wf).Controls[num2], null);
			}
		}

		private void g()
		{
			if (string.IsNullOrWhiteSpace(WY))
			{
				if (((ArrangedElementCollection)((Control)wf).Controls).Count != 0)
				{
					B(((Control)wf).Controls[0], null);
				}
			}
			else
			{
				if (Wx == null)
				{
					return;
				}
				int num = ((Control)wf).Controls.IndexOf((Control)(object)Wx);
				int num2 = -1;
				bool flag = false;
				if (num < ((ArrangedElementCollection)((Control)wf).Controls).Count - 1)
				{
					for (int i = num + 1; i < ((ArrangedElementCollection)((Control)wf).Controls).Count; i++)
					{
						if (((Control)wf).Controls[i].Top <= ((Control)Wx).Top)
						{
							continue;
						}
						flag = true;
						num2 = i;
						for (int j = i; j < ((ArrangedElementCollection)((Control)wf).Controls).Count && ((Control)wf).Controls[j].Top == ((Control)wf).Controls[i].Top; j++)
						{
							if (A(((Control)wf).Controls[j], (Control)(object)Wx))
							{
								num2 = j;
								break;
							}
						}
						break;
					}
				}
				if (!flag)
				{
					num2 = 0;
				}
				B(((Control)wf).Controls[num2], null);
			}
		}

		private bool A(Control P_0, Control P_1)
		{
			if ((P_0.Left < P_1.Left || P_0.Left > P_1.Right) && (P_0.Right < P_1.Left || P_0.Right > P_1.Right) && (P_1.Left < P_0.Left || P_1.Left > P_0.Right))
			{
				if (P_1.Right >= P_0.Left)
				{
					return P_1.Right <= P_0.Right;
				}
				return false;
			}
			return true;
		}

		private void f(object P_0, EventArgs P_1)
		{
			b();
		}

		private void A(object P_0, SplitterEventArgs P_1)
		{
			b();
		}

		private void A(string P_0, Graphics P_1, float P_2, int P_3, int P_4, bool P_5)
		{
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected O, but got Unknown
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected O, but got Unknown
			string text = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wx();
			if (!wa)
			{
				try
				{
					if (Directory.Exists(text))
					{
						Directory.Delete(text, true);
					}
					wa = true;
				}
				catch (System.Exception ex)
				{
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wY() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Rq() + ex.Message, true);
				}
			}
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = text + Path.GetFileName(P_0);
			if (File.Exists(text2))
			{
				byte[] array = File.ReadAllBytes(P_0);
				uint num = new global::crc.crc().crc_process(array, 0u, (uint)array.Length, 4294967295u, partial: false);
				byte[] array2 = File.ReadAllBytes(text2);
				uint num2 = new global::crc.crc().crc_process(array2, 0u, (uint)array2.Length, 4294967295u, partial: false);
				if (num != num2)
				{
					int num3 = 1;
					do
					{
						num3++;
						text2 = string.Concat(new string[5]
						{
							text,
							Path.GetFileNameWithoutExtension(P_0),
							D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ax(),
							num3.ToString(),
							Path.GetExtension(P_0)
						});
					}
					while (File.Exists(text2));
					File.Copy(P_0, text2);
				}
			}
			else
			{
				File.Copy(P_0, text2);
			}
			PrivateFontCollection val = new PrivateFontCollection();
			try
			{
				val.AddFontFile(text2);
				Font val2 = new Font(((FontCollection)val).Families[0], P_2);
				try
				{
					StringFormat val3 = new StringFormat();
					try
					{
						val3.Alignment = (StringAlignment)1;
						val3.LineAlignment = (StringAlignment)1;
						P_1.SmoothingMode = (SmoothingMode)2;
						P_1.InterpolationMode = (InterpolationMode)7;
						P_1.CompositingQuality = (CompositingQuality)2;
						P_1.PixelOffsetMode = (PixelOffsetMode)2;
						if (P_5)
						{
							P_1.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wy(), val2, Brushes.Black, (float)(P_3 / 2), (float)P_4 * 0.166f, val3);
							P_1.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wZ(), val2, Brushes.Black, (float)(P_3 / 2), (float)P_4 * 0.333f, val3);
							P_1.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.wz(), val2, Brushes.Black, (float)(P_3 / 2), (float)P_4 * 0.5f, val3);
							P_1.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XA(), val2, Brushes.Black, (float)(P_3 / 2), (float)P_4 * 0.666f, val3);
							P_1.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xa(), val2, Brushes.Black, (float)(P_3 / 2), (float)P_4 * 0.833f, val3);
						}
						else
						{
							P_1.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XB(), val2, Brushes.Black, (float)(P_3 / 2), (float)P_4 * 0.22f, val3);
							P_1.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xb(), val2, Brushes.Black, (float)(P_3 / 2), (float)P_4 * 0.55f, val3);
							P_1.DrawString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xa(), val2, Brushes.Black, (float)(P_3 / 2), (float)P_4 * 0.88f, val3);
						}
					}
					finally
					{
						((System.IDisposable)val3)?.Dispose();
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
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && wB != null)
			{
				((System.IDisposable)wB).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void H()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected O, but got Unknown
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Expected O, but got Unknown
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Expected O, but got Unknown
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_037e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Expected O, but got Unknown
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0414: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_045d: Expected O, but got Unknown
			//IL_0467: Unknown result type (might be due to invalid IL or missing references)
			//IL_048e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d7: Expected O, but got Unknown
			//IL_0501: Unknown result type (might be due to invalid IL or missing references)
			//IL_0512: Unknown result type (might be due to invalid IL or missing references)
			//IL_053c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0566: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0614: Unknown result type (might be due to invalid IL or missing references)
			//IL_0653: Unknown result type (might be due to invalid IL or missing references)
			//IL_065d: Expected O, but got Unknown
			//IL_066f: Unknown result type (might be due to invalid IL or missing references)
			//IL_069b: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0705: Unknown result type (might be due to invalid IL or missing references)
			//IL_070f: Expected O, but got Unknown
			//IL_071c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0726: Expected O, but got Unknown
			//IL_0743: Unknown result type (might be due to invalid IL or missing references)
			//IL_074d: Expected O, but got Unknown
			//IL_075f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0769: Expected O, but got Unknown
			//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0800: Expected O, but got Unknown
			//IL_0811: Unknown result type (might be due to invalid IL or missing references)
			//IL_082d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0871: Unknown result type (might be due to invalid IL or missing references)
			//IL_0883: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_091c: Unknown result type (might be due to invalid IL or missing references)
			//IL_092e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0958: Unknown result type (might be due to invalid IL or missing references)
			//IL_099f: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5a: Expected O, but got Unknown
			//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab3: Expected O, but got Unknown
			//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac5: Expected O, but got Unknown
			//IL_0acd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad7: Expected O, but got Unknown
			//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae9: Expected O, but got Unknown
			//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0afb: Expected O, but got Unknown
			wb = new TableLayoutPanelWithThemedScrollBars();
			wC = new Panel();
			wc = new ProgressBar();
			wD = new ThemedButton();
			wh = new ThemedComboBox();
			wd = new ThemedButton();
			wE = new ThemedButton();
			we = new Panel();
			wF = new SplitContainer();
			wf = new W();
			wG = new TableLayoutPanelWithThemedScrollBars();
			wg = new PictureBox();
			wH = new aF();
			((Control)wb).SuspendLayout();
			((Control)wC).SuspendLayout();
			((Control)we).SuspendLayout();
			((ISupportInitialize)wF).BeginInit();
			((Control)wF.Panel1).SuspendLayout();
			((Control)wF.Panel2).SuspendLayout();
			((Control)wF).SuspendLayout();
			((Control)wG).SuspendLayout();
			((ISupportInitialize)wg).BeginInit();
			((Control)this).SuspendLayout();
			((TableLayoutPanel)wb).ColumnCount = 1;
			((TableLayoutPanel)wb).ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
			((TableLayoutPanel)wb).Controls.Add((Control)(object)wC, 0, 1);
			((TableLayoutPanel)wb).Controls.Add((Control)(object)we, 0, 0);
			((Control)wb).Dock = (DockStyle)5;
			((Control)wb).Location = new Point(0, 0);
			((Control)wb).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.IC();
			((TableLayoutPanel)wb).RowCount = 2;
			((TableLayoutPanel)wb).RowStyles.Add(new RowStyle((SizeType)2, 100f));
			((TableLayoutPanel)wb).RowStyles.Add(new RowStyle((SizeType)1, 50f));
			((Control)wb).Size = new Size(1084, 621);
			((Control)wb).TabIndex = 8;
			((Control)wC).Controls.Add((Control)(object)wh);
			((Control)wC).Controls.Add((Control)(object)wc);
			((Control)wC).Controls.Add((Control)(object)wD);
			((Control)wC).Controls.Add((Control)(object)wd);
			((Control)wC).Controls.Add((Control)(object)wE);
			((Control)wC).Dock = (DockStyle)5;
			((Control)wC).Location = new Point(0, 571);
			((Control)wC).Margin = new Padding(0);
			((Control)wC).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ic();
			((Control)wC).Size = new Size(1084, 50);
			((Control)wC).TabIndex = 0;
			((Control)wc).Location = new Point(230, 13);
			((Control)wc).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Lb();
			((Control)wc).Size = new Size(200, 22);
			wc.Step = 1;
			wc.Style = (ProgressBarStyle)1;
			((Control)wc).TabIndex = 6;
			((Control)wc).Visible = false;
			((Control)wD).Anchor = (AnchorStyles)9;
			((Button)wD).DialogResult = (DialogResult)2;
			((Control)wD).Location = new Point(972, 9);
			((Control)wD).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)wD).Size = new Size(100, 30);
			((Control)wD).TabIndex = 3;
			((Control)wD).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)wD).UseVisualStyleBackColor = true;
			((Control)wD).Click += new EventHandler(c);
			((Control)wd).Anchor = (AnchorStyles)9;
			((Control)wd).Enabled = false;
			((Control)wd).Location = new Point(777, 9);
			((Control)wd).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XC();
			((Control)wd).Size = new Size(160, 30);
			((Control)wd).TabIndex = 2;
			((Control)wd).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xc();
			((ButtonBase)wd).UseVisualStyleBackColor = true;
			((Control)wd).Click += new EventHandler(b);
			((Control)wE).Location = new Point(12, 9);
			((Control)wE).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XD();
			((Control)wE).Size = new Size(180, 30);
			((Control)wE).TabIndex = 0;
			((Control)wE).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xd();
			((ButtonBase)wE).UseVisualStyleBackColor = true;
			((Control)wE).Click += new EventHandler(D);
			((Control)we).Controls.Add((Control)(object)wF);
			((Control)we).Dock = (DockStyle)5;
			((Control)we).Location = new Point(0, 0);
			((Control)we).Margin = new Padding(0);
			((Control)we).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XE();
			((Control)we).Size = new Size(1084, 571);
			((Control)we).TabIndex = 1;
			wF.Dock = (DockStyle)5;
			((Control)wF).Location = new Point(0, 0);
			((Control)wF).Margin = new Padding(0);
			((Control)wF).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xe();
			wF.Orientation = (Orientation)0;
			((Control)wF.Panel1).Controls.Add((Control)(object)wf);
			((Control)wF.Panel1).Padding = new Padding(10);
			wF.Panel1MinSize = 100;
			((Control)wF.Panel2).Controls.Add((Control)(object)wG);
			wF.Panel2MinSize = 100;
			((Control)wF).Size = new Size(1084, 571);
			wF.SplitterDistance = 308;
			wF.SplitterWidth = 3;
			((Control)wF).TabIndex = 5;
			wF.SplitterMoved += new SplitterEventHandler(A);
			((ScrollableControl)wf).AutoScroll = true;
			((Control)wf).BackColor = Color.White;
			((Panel)wf).BorderStyle = (BorderStyle)1;
			((Control)wf).Dock = (DockStyle)5;
			((Control)wf).Location = new Point(10, 10);
			((Control)wf).Margin = new Padding(0);
			((Control)wf).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XF();
			((Control)wf).Size = new Size(1064, 288);
			((Control)wf).TabIndex = 4;
			((Panel)wf).TabStop = true;
			((Control)wf).Click += new EventHandler(F);
			((Control)wf).PreviewKeyDown += new PreviewKeyDownEventHandler(A);
			((TableLayoutPanel)wG).ColumnCount = 2;
			((TableLayoutPanel)wG).ColumnStyles.Add(new ColumnStyle((SizeType)2, 60f));
			((TableLayoutPanel)wG).ColumnStyles.Add(new ColumnStyle((SizeType)2, 40f));
			((TableLayoutPanel)wG).Controls.Add((Control)(object)wg, 0, 0);
			((TableLayoutPanel)wG).Controls.Add((Control)(object)wH, 1, 0);
			((Control)wG).Dock = (DockStyle)5;
			((Control)wG).Location = new Point(0, 0);
			((Control)wG).Margin = new Padding(0);
			((Control)wG).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xf();
			((TableLayoutPanel)wG).RowCount = 1;
			((TableLayoutPanel)wG).RowStyles.Add(new RowStyle((SizeType)2, 100f));
			((Control)wG).Size = new Size(1084, 260);
			((Control)wG).TabIndex = 0;
			((Control)wg).BackColor = Color.White;
			wg.BorderStyle = (BorderStyle)0;
			((Control)wg).Dock = (DockStyle)5;
			wg.ErrorImage = null;
			wg.InitialImage = null;
			((Control)wg).Location = new Point(10, 10);
			((Control)wg).Margin = new Padding(10);
			((Control)wg).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XG();
			((Control)wg).Size = new Size(630, 240);
			wg.SizeMode = (PictureBoxSizeMode)4;
			wg.TabIndex = 1;
			wg.TabStop = false;
			((ScrollableControl)wH).AutoScroll = true;
			((Control)wH).BackColor = Color.White;
			((Panel)wH).BorderStyle = (BorderStyle)1;
			((Control)wH).Dock = (DockStyle)5;
			((Control)wH).Location = new Point(660, 10);
			((Control)wH).Margin = new Padding(10);
			((Control)wH).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xg();
			((Control)wH).Size = new Size(414, 240);
			((Control)wH).TabIndex = 6;
			((ComboBox)wh).DrawMode = (DrawMode)1;
			((ComboBox)wh).DropDownStyle = (ComboBoxStyle)2;
			((ListControl)wh).FormattingEnabled = true;
			((Control)wh).Location = new Point(505, 13);
			((Control)wh).Margin = new Padding(0);
			((Control)wh).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.jN();
			((Control)wh).Size = new Size(200, 23);
			((Control)wh).TabIndex = 1;
			((Control)this).AllowDrop = true;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)wD;
			((Form)this).ClientSize = new Size(1084, 621);
			((Control)this).Controls.Add((Control)(object)wb);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).MinimizeBox = false;
			((Control)this).MinimumSize = new Size(900, 500);
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XH();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xh();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).DragDrop += new DragEventHandler(a);
			((Control)this).DragEnter += new DragEventHandler(A);
			((Control)this).Resize += new EventHandler(f);
			((Control)wb).ResumeLayout(false);
			((Control)wC).ResumeLayout(false);
			((Control)wC).PerformLayout();
			((Control)we).ResumeLayout(false);
			((Control)wF.Panel1).ResumeLayout(false);
			((Control)wF.Panel2).ResumeLayout(false);
			((ISupportInitialize)wF).EndInit();
			((Control)wF).ResumeLayout(false);
			((Control)wG).ResumeLayout(false);
			((ISupportInitialize)wg).EndInit();
			((Control)this).ResumeLayout(false);
		}

		[CompilerGenerated]
		private void h()
		{
			((Control)wc).Visible = true;
			((Control)wc).BringToFront();
		}

		[CompilerGenerated]
		private void I()
		{
			((Control)wc).Visible = true;
			((Control)wc).BringToFront();
		}
	}
	internal class Bw : Form
	{
		private static readonly string wI = BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xl();

		private IContainer wi;

		private aP wJ;

		private ThemedButton wj;

		private ThemedButton wK;

		private Label wk;

		private Label wL;

		internal Bw(MenuNode P_0)
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			a();
			if (P_0.a() != null && P_0.a().a(P_0.b()) is Table)
			{
				((Control)wk).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XI();
			}
			else
			{
				((Control)wk).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xi();
			}
			((Control)wL).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu() + P_0.A(P_0.C() == null, false) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Nu();
			((Control)this).BackColor = BM.td;
			((Control)wJ).ForeColor = BM.te;
			((Control)wk).ForeColor = BM.te;
			((Control)wL).ForeColor = BM.te;
		}

		private void A(object P_0, EventArgs P_1)
		{
			((CheckBox)wJ).Checked = false;
			((Control)wj).Focus();
		}

		private void A(object P_0, FormClosingEventArgs P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			if ((int)((Form)this).DialogResult == 1 && ((CheckBox)wJ).Checked)
			{
				if (!Directory.Exists(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS()))
				{
					Directory.CreateDirectory(BM.QR + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FS());
				}
				else if (!File.Exists(wI))
				{
					((Stream)File.Create(wI)).Close();
				}
				List<string> val = new List<string>();
				val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XJ() + ((CheckBox)wJ).Checked);
				File.AppendAllLines(wI, (System.Collections.Generic.IEnumerable<string>)val);
			}
		}

		internal static bool A()
		{
			if (File.Exists(wI))
			{
				StreamReader val = File.OpenText(wI);
				try
				{
					string text;
					while ((text = ((TextReader)val).ReadLine()) != null)
					{
						if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XJ()) && bool.Parse(text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XJ().Length)))
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
			if (disposing && wi != null)
			{
				((System.IDisposable)wi).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void a()
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0308: Expected O, but got Unknown
			//IL_0350: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Expected O, but got Unknown
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_036c: Expected O, but got Unknown
			wJ = new aP();
			wj = new ThemedButton();
			wK = new ThemedButton();
			wk = new Label();
			wL = new Label();
			((Control)this).SuspendLayout();
			((Control)wJ).AutoSize = true;
			((Control)wJ).Location = new Point(27, 59);
			((Control)wJ).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KT();
			((Control)wJ).Size = new Size(212, 17);
			((Control)wJ).TabIndex = 2;
			((Control)wJ).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.KR();
			((ButtonBase)wJ).UseVisualStyleBackColor = true;
			((Button)wj).DialogResult = (DialogResult)1;
			((Control)wj).Location = new Point(266, 52);
			((Control)wj).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hY();
			((Control)wj).Size = new Size(102, 30);
			((Control)wj).TabIndex = 0;
			((Control)wj).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hU();
			((ButtonBase)wj).UseVisualStyleBackColor = true;
			((Button)wK).DialogResult = (DialogResult)2;
			((Control)wK).Location = new Point(383, 52);
			((Control)wK).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hy();
			((Control)wK).Size = new Size(103, 30);
			((Control)wK).TabIndex = 1;
			((Control)wK).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hV();
			((ButtonBase)wK).UseVisualStyleBackColor = true;
			((Control)wk).AutoSize = true;
			((Control)wk).Location = new Point(8, 9);
			((Control)wk).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.fw();
			((Control)wk).Size = new Size(491, 13);
			((Control)wk).TabIndex = 7;
			((Control)wk).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xi();
			((Control)wL).AutoSize = true;
			((Control)wL).Location = new Point(8, 31);
			((Control)wL).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xj();
			((Control)wL).Size = new Size(491, 13);
			((Control)wL).TabIndex = 8;
			((Control)wL).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XK();
			((Form)this).AcceptButton = (IButtonControl)(object)wj;
			((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			((Form)this).CancelButton = (IButtonControl)(object)wK;
			((Form)this).ClientSize = new Size(506, 94);
			((Form)this).ControlBox = false;
			((Control)this).Controls.Add((Control)(object)wk);
			((Control)this).Controls.Add((Control)(object)wL);
			((Control)this).Controls.Add((Control)(object)wJ);
			((Control)this).Controls.Add((Control)(object)wj);
			((Control)this).Controls.Add((Control)(object)wK);
			((Control)this).Font = new Font(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BU(), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
			((Form)this).FormBorderStyle = (FormBorderStyle)3;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Xk();
			((Form)this).ShowIcon = false;
			((Form)this).ShowInTaskbar = false;
			((Form)this).StartPosition = (FormStartPosition)4;
			((Control)this).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.XL();
			((Form)this).FormClosing += new FormClosingEventHandler(A);
			((Form)this).Shown += new EventHandler(A);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
namespace b
{
	internal class bW
	{
		internal int axS;

		internal int axs;

		internal k axT;

		internal byte[] axt;

		public virtual bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			if (obj == null)
			{
				return false;
			}
			if (obj is bW)
			{
				return this == obj as bW;
			}
			return false;
		}

		public static bool operator ==(bW P_0, bW P_1)
		{
			if ((object)P_0 == null || (object)P_1 == null)
			{
				return (object)P_0 == P_1;
			}
			if (P_0.axS == P_1.axS && P_0.axs == P_1.axs && P_0.axT == P_1.axT)
			{
				if (P_0.axt != null && P_1.axt != null)
				{
					return n.A(P_0.axt) == n.A(P_1.axt);
				}
				return P_0.axt == null == (P_1.axt == null);
			}
			return false;
		}

		public static bool operator !=(bW P_0, bW P_1)
		{
			return !(P_0 == P_1);
		}

		public virtual string ToString()
		{
			return string.Concat(new string[7]
			{
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amA(),
				axS.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ama(),
				axs.ToString(),
				D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aN(),
				((object)axT).ToString(),
				(axt != null) ? (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.amB() + n.A(axt)) : string.Empty
			});
		}
	}
	internal struct bw
	{
		internal int axU;

		internal int axu;

		internal bw(int P_0, int P_1)
		{
			axU = P_0;
			axu = P_1;
		}

		public bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			bw bw2 = (bw)obj;
			if (bw2.axU == axU)
			{
				return bw2.axu == axu;
			}
			return false;
		}

		public static bool operator ==(bw P_0, bw P_1)
		{
			return ((object)P_0).Equals((object)P_1);
		}

		public static bool operator !=(bw P_0, bw P_1)
		{
			return !((object)P_0).Equals((object)P_1);
		}

		public int GetHashCode()
		{
			return (axU << 8) | axu;
		}
	}
}
