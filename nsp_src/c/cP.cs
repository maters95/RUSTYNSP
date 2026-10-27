using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using A;
using B;
using D;
using NSP.SettingsFramework;
using NSP.UserInterface;
using a;
using b;

namespace c
{
	internal class cP : MovableResizablePanel
	{
		private GenericCANConfigControl Bkw;

		private Rectangle BkX;

		private Framework Bkx;

		private MenuNode BkY;

		private string Bky;

		internal cP(MenuNode P_0, Framework P_1, Rectangle P_2, bool P_3, bool P_4)
			: base(P_2, P_3, P_4, false)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			Bkx = P_1;
			BkY = P_0;
			Bky = string.Empty;
			BkX = P_2;
			((Control)this).ContextMenuStrip = C();
		}

		protected override void Dispose(bool disposing)
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			if (Bkw != null)
			{
				Bkw.Close();
			}
			if (((Control)this).ContextMenuStrip != null)
			{
				((ToolStripDropDown)((Control)this).ContextMenuStrip).Opening -= new CancelEventHandler(A);
				foreach (ToolStripItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
				{
					item.Click -= new EventHandler(B);
				}
			}
			base.Dispose(disposing);
		}

		internal new DN B()
		{
			string bky = Bky;
			if (!(bky == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMG()))
			{
				if (!(bky == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMf()))
				{
					if (bky == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aMg())
					{
						return Bkx.awt;
					}
					return null;
				}
				return Bkx.aws;
			}
			return Bkx.awT;
		}

		internal new void b()
		{
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected O, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected O, but got Unknown
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_0370: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Expected O, but got Unknown
			((Control)this).SuspendLayout();
			if (Bky == string.Empty)
			{
				Bky = BkY?.C()?.E();
			}
			TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars = new TableLayoutPanelWithThemedScrollBars();
			((Control)tableLayoutPanelWithThemedScrollBars).Left = 5;
			((Control)tableLayoutPanelWithThemedScrollBars).Top = 5;
			((Control)tableLayoutPanelWithThemedScrollBars).Name = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBu();
			((TableLayoutPanel)tableLayoutPanelWithThemedScrollBars).CellBorderStyle = (TableLayoutPanelCellBorderStyle)0;
			((TableLayoutPanel)tableLayoutPanelWithThemedScrollBars).GrowStyle = (TableLayoutPanelGrowStyle)1;
			((Control)tableLayoutPanelWithThemedScrollBars).BackColor = ((Control)this).BackColor;
			((TableLayoutPanel)tableLayoutPanelWithThemedScrollBars).ColumnCount = 1;
			((TableLayoutPanel)tableLayoutPanelWithThemedScrollBars).RowCount = 2;
			((TableLayoutPanel)tableLayoutPanelWithThemedScrollBars).RowStyles.Add(new RowStyle((SizeType)1, 24f));
			((TableLayoutPanel)tableLayoutPanelWithThemedScrollBars).RowStyles.Add(new RowStyle((SizeType)2, 100f));
			((Control)tableLayoutPanelWithThemedScrollBars).MouseDown += new MouseEventHandler(A);
			((Control)tableLayoutPanelWithThemedScrollBars).MouseMove += new MouseEventHandler(a);
			((Control)tableLayoutPanelWithThemedScrollBars).MouseUp += new MouseEventHandler(B);
			Label val = new Label();
			((Control)val).Text = Bky + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBV();
			((Control)val).ForeColor = BM.tf;
			((Control)val).Font = new Font(((Control)val).Font.FontFamily, 10f, (FontStyle)1);
			((Control)val).BackColor = Color.Transparent;
			((Control)val).AutoSize = true;
			((Control)val).Left = 5;
			((Control)val).Top = 2;
			((ControlCollection)((TableLayoutPanel)tableLayoutPanelWithThemedScrollBars).Controls).Add((Control)(object)val);
			DN dN = B();
			Setting setting = dN?.BZK;
			if (Bkx.B() && Bkx.b() && setting != null && setting.J())
			{
				Label val2 = new Label();
				((Control)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bl() + Bky + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBv();
				((Control)val2).ForeColor = BM.te;
				((Control)val2).BackColor = Color.Transparent;
				((Control)val2).AutoSize = true;
				((Control)val2).Left = 10;
				((Control)val2).Top = 10;
				((ControlCollection)((TableLayoutPanel)tableLayoutPanelWithThemedScrollBars).Controls).Add((Control)(object)val2);
			}
			else if (setting != null)
			{
				Bkw = new GenericCANConfigControl(Bkx, dN, Bky);
				((Control)Bkw).Dock = (DockStyle)5;
				((ControlCollection)((TableLayoutPanel)tableLayoutPanelWithThemedScrollBars).Controls).Add((Control)(object)Bkw);
			}
			((Control)this).Controls.Add((Control)(object)tableLayoutPanelWithThemedScrollBars);
			if (BkX != Rectangle.Empty)
			{
				((Control)this).Width = ((Rectangle)(ref BkX)).Width;
				((Control)this).Height = ((Rectangle)(ref BkX)).Height;
				((Control)this).Left = ((Rectangle)(ref BkX)).Left;
				((Control)this).Top = ((Rectangle)(ref BkX)).Top;
			}
			else
			{
				int num = 0;
				int num2 = 0;
				foreach (Control item in (ArrangedElementCollection)((TableLayoutPanel)tableLayoutPanelWithThemedScrollBars).Controls)
				{
					Control val3 = item;
					num = Math.Max(num, val3.Right + 10);
					num2 = Math.Max(num2, val3.Bottom + 10);
				}
				if (((Control)this).Width != num || ((Control)this).Height != num2)
				{
					((Control)this).Width = num;
					((Control)this).Height = num2;
				}
			}
			((Control)this).ResumeLayout(true);
			if (Bkw != null)
			{
				int top = ((Control)Bkw).Top;
				Size minimumSize = ((Control)Bkw).MinimumSize;
				((ScrollableControl)tableLayoutPanelWithThemedScrollBars).AutoScrollMinSize = new Size(0, top + ((Size)(ref minimumSize)).Height);
			}
			((Control)tableLayoutPanelWithThemedScrollBars).Size = new Size(((Control)this).Width - 10, ((Control)this).Height - 10);
		}

		protected override void OnResize(EventArgs e)
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			((Panel)this).OnResize(e);
			if (((Control)this).Controls.ContainsKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBu()))
			{
				((Control)(((Control)this).Controls[D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBu()] as TableLayoutPanelWithThemedScrollBars)).Size = new Size(((Control)this).Width - 10, ((Control)this).Height - 10);
			}
		}

		private void A(object P_0, MouseEventArgs P_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Invalid comparison between Unknown and I4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).BringToFront();
			if ((int)P_1.Button == 1048576)
			{
				TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars = P_0 as TableLayoutPanelWithThemedScrollBars;
				A(P_1.Button, ((Control)tableLayoutPanelWithThemedScrollBars).Left + P_1.X, ((Control)tableLayoutPanelWithThemedScrollBars).Top + P_1.Y);
			}
		}

		private void a(object P_0, MouseEventArgs P_1)
		{
			TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars = P_0 as TableLayoutPanelWithThemedScrollBars;
			base.A(((Control)tableLayoutPanelWithThemedScrollBars).Left + P_1.X, ((Control)tableLayoutPanelWithThemedScrollBars).Top + P_1.Y);
		}

		private void B(object P_0, MouseEventArgs P_1)
		{
			TableLayoutPanelWithThemedScrollBars tableLayoutPanelWithThemedScrollBars = P_0 as TableLayoutPanelWithThemedScrollBars;
			base.a(((Control)tableLayoutPanelWithThemedScrollBars).Left + P_1.X, ((Control)tableLayoutPanelWithThemedScrollBars).Top + P_1.Y);
		}

		private void B(object P_0, EventArgs P_1)
		{
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			BP num = (((TabControl)BM.QQ.rl).SelectedTab as ae).A();
			int selectedIndex = ((TabControl)BM.QQ.rl).SelectedIndex;
			if (num == BP.ua || BM.QQ.rl.A(selectedIndex) != this)
			{
				q.A((Control)(object)this);
				BM.QQ.rl.a(false);
			}
			else
			{
				bE.A((IWin32Window)(object)BM.QQ, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBW(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBw(), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}

		private void A(object P_0, CancelEventArgs P_1)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			if (((Control)this).ContextMenuStrip == null)
			{
				return;
			}
			foreach (ToolStripMenuItem item in (ArrangedElementCollection)((ToolStrip)((Control)this).ContextMenuStrip).Items)
			{
				ToolStripMenuItem val = item;
				if (((ToolStripItem)val).Text == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBX())
				{
					((ToolStripItem)val).Enabled = !BM.QQ.rl.a((Control)(object)this);
					break;
				}
			}
		}

		private ContextMenuStrip C()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			ContextMenuStrip val = new ContextMenuStrip
			{
				BackColor = BM.tG,
				ForeColor = BM.te
			};
			((ToolStripDropDown)val).Opening += new CancelEventHandler(A);
			ToolStripMenuItem val2 = new ToolStripMenuItem();
			((ToolStripItem)val2).Text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBX();
			((ToolStripItem)val2).Click += new EventHandler(B);
			((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
			return val;
		}

		internal void A(string P_0, int P_1, int P_2)
		{
			List<string> val = new List<string>();
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBx());
			int num = ((Control)this).Left - P_1;
			int num2 = ((Control)this).Top - P_2;
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bad() + num);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaE() + num2);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Bae() + ((Control)this).Width);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BaF() + ((Control)this).Height);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBY() + Bky);
			val.Add(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
			File.AppendAllLines(P_0, (System.Collections.Generic.IEnumerable<string>)val);
		}

		internal void A(StreamReader P_0)
		{
			string text;
			while ((text = ((TextReader)P_0).ReadLine()) != null)
			{
				if (text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBY()))
				{
					Bky = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BBY().Length);
				}
				else if (string.IsNullOrWhiteSpace(text))
				{
					break;
				}
			}
		}

		internal bool A(KeyEventArgs P_0)
		{
			if (Bkw != null)
			{
				return Bkw.A(P_0);
			}
			return false;
		}
	}
	internal class cp : MovableResizablePanel
	{
		private const int BkZ = 600;

		private const int Bkz = 250;

		private const int BLA = 120;

		private const int BLa = 160;

		private const int BLB = 10;

		private Z BLb;

		private z BLC;

		private y BLc;

		private Rectangle BLD;

		internal cp(KnockDetection P_0, Framework P_1, Rectangle P_2, bool P_3)
			: base(P_2, P_3, false, true)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			BLb = new Z(P_0, P_1);
			((Control)this).Controls.Add((Control)(object)BLb);
			BLC = new z(P_0, P_1);
			((Control)this).Controls.Add((Control)(object)BLC);
			if (P_0.DataIdsOfAngleBucketChannels != null && P_0.DataIdsOfAngleBucketChannels.Count != 0)
			{
				BLc = new y(P_0, P_1);
				((Control)this).Controls.Add((Control)(object)BLc);
			}
			BLD = P_2;
			if (BLD != Rectangle.Empty)
			{
				((Control)this).Width = ((Rectangle)(ref P_2)).Width;
				((Control)this).Height = ((Rectangle)(ref P_2)).Height;
				((Control)this).Left = ((Rectangle)(ref P_2)).Left;
				((Control)this).Top = ((Rectangle)(ref P_2)).Top;
			}
			else
			{
				((Control)this).Width = 600;
				if (BLc != null)
				{
					((Control)this).Height = 550;
				}
				else
				{
					((Control)this).Height = 380;
				}
			}
			UpdateLayout(resizingOnly: false);
		}

		public override void UpdateLayout(bool resizingOnly)
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			((Control)BLb).Top = 0;
			((Control)BLb).Left = 0;
			((Control)BLb).Width = ((Control)this).Width;
			((Control)BLC).Left = 0;
			((Control)BLC).Width = ((Control)this).Width;
			if (BLc != null)
			{
				((Control)BLc).Left = 0;
				((Control)BLc).Width = ((Control)this).Width;
			}
			if (BLD != Rectangle.Empty)
			{
				if (BLc != null)
				{
					((Control)BLb).Height = ((Control)this).Height * 250 / 550;
					((Control)BLC).Height = ((Control)this).Height * 120 / 550;
					((Control)BLc).Height = ((Control)this).Height * 160 / 550;
				}
				else
				{
					((Control)BLb).Height = ((Control)this).Height * 250 / 380;
					((Control)BLC).Height = ((Control)this).Height * 120 / 380;
				}
			}
			else
			{
				((Control)BLb).Height = 250;
				((Control)BLC).Height = 120;
				if (BLc != null)
				{
					((Control)BLc).Height = 160;
				}
			}
			((Control)BLC).Top = ((Control)BLb).Height + 10;
			if (BLc != null)
			{
				((Control)BLc).Top = ((Control)BLb).Height + 10 + ((Control)BLC).Height + 10;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			base.OnPaint(e);
			ControlPaint.DrawBorder(e.Graphics, ((Control)this).ClientRectangle, ((Control)this).BackColor, (ButtonBorderStyle)3);
		}
	}
}
namespace C
{
	internal class CP
	{
		private Cn BcH;

		private string Bch;

		private Framework BcI;

		private bool Bci;

		private MenuNode BcJ;

		private Image Bcj;

		internal CP(string P_0, Cn P_1, Framework P_2, MenuNode P_3, bool P_4, Image P_5)
		{
			Bch = P_0;
			BcH = P_1;
			BcI = P_2;
			BcJ = P_3;
			Bci = P_4;
			Bcj = P_5;
		}

		internal void A()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0234: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_0417: Unknown result type (might be due to invalid IL or missing references)
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0441: Unknown result type (might be due to invalid IL or missing references)
			//IL_0448: Expected O, but got Unknown
			//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
			MemoryStream val = new MemoryStream();
			XmlWriterSettings val2 = new XmlWriterSettings();
			val2.ConformanceLevel = (ConformanceLevel)2;
			val2.CloseOutput = false;
			val2.Indent = true;
			val2.NewLineChars = Environment.NewLine;
			XmlWriter val3 = XmlWriter.Create((Stream)(object)val, val2);
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awc());
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGX());
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWQ());
			val3.WriteString(BcH.BCX);
			val3.WriteEndElement();
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWq());
			val3.WriteString(((object)BcH.BCY).ToString());
			val3.WriteEndElement();
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWR());
			val3.WriteString(((object)BcH.BCZ).ToString());
			val3.WriteEndElement();
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWr());
			val3.WriteString(BcH.BCz.ToString());
			val3.WriteEndElement();
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWS());
			val3.WriteString(BcH.BcA.ToString());
			val3.WriteEndElement();
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWs());
			val3.WriteString(BcH.BCx.ToString());
			val3.WriteEndElement();
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWT());
			val3.WriteString(BcH.BCy);
			val3.WriteEndElement();
			if (!string.IsNullOrEmpty(BcH.BcB) && Bcj != null)
			{
				val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahj());
				val3.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWu());
				val3.WriteString(BcH.BcB);
				val3.WriteEndElement();
			}
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWt());
			val3.WriteString(BcH.Bca);
			val3.WriteEndElement();
			Enumerator<string, string> enumerator = BcH.Bcb.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, string> current = enumerator.Current;
					val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGx());
					val3.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ahQ(), current.Key);
					val3.WriteString(current.Value);
					val3.WriteEndElement();
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<string, Cn.A> enumerator2 = BcH.BcC.Keys.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					string current2 = enumerator2.Current;
					val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWU());
					val3.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWV(), current2);
					val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWv());
					val3.WriteString(BcH.BcC[current2].BsP);
					val3.WriteEndElement();
					val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWW());
					val3.WriteString(BcH.BcC[current2].Bsp);
					val3.WriteEndElement();
					val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWw());
					val3.WriteString(BcH.BcC[current2].BsQ);
					val3.WriteEndElement();
					val3.WriteEndElement();
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			val3.WriteEndElement();
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.hh());
			A(val3);
			val3.WriteEndElement();
			val3.Flush();
			BcH.BCw = n.A(A(val));
			val3.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWp());
			val3.WriteString(BcH.BCw);
			val3.WriteEndElement();
			val3.WriteEndElement();
			val3.Close();
			((Stream)val).Flush();
			if (Bci)
			{
				List<KeyValuePair<string, byte[]>> val4 = new List<KeyValuePair<string, byte[]>>();
				val4.Add(new KeyValuePair<string, byte[]>(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWP(), val.ToArray()));
				byte[] array = a();
				if (array != null)
				{
					val4.Add(new KeyValuePair<string, byte[]>(BcH.BcB, array));
				}
				if (BcI.awv.Count != 0)
				{
					List<KeyValuePair<string, byte[]>> val5 = B();
					val4.AddRange((System.Collections.Generic.IEnumerable<KeyValuePair<string, byte[]>>)val5);
				}
				KeyValuePair<string, byte[]>[] dataList = val4.ToArray();
				R.A(Bch, M.A(), true, dataList);
			}
			else
			{
				((Stream)val).Position = 0L;
				string text = ((TextReader)new StreamReader((Stream)(object)val)).ReadToEnd();
				if (File.Exists(Bch))
				{
					File.Delete(Bch);
				}
				StreamWriter val6 = new StreamWriter(Bch);
				try
				{
					((TextWriter)val6).Write(text);
				}
				finally
				{
					((System.IDisposable)val6)?.Dispose();
				}
				byte[] array2 = a();
				if (array2 != null)
				{
					string text2 = Path.Combine(Path.GetDirectoryName(Bch), BcH.BcB);
					if (File.Exists(text2))
					{
						File.Delete(text2);
					}
					File.WriteAllBytes(text2, array2);
				}
			}
			((Stream)val).Close();
		}

		private byte[] a()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			try
			{
				if (!string.IsNullOrEmpty(BcH.BcB) && Bcj != null)
				{
					byte[] result = null;
					MemoryStream val = new MemoryStream();
					try
					{
						Image val2 = (Image)new Bitmap(Bcj);
						try
						{
							val2.Save((Stream)(object)val, Bcj.RawFormat);
							result = val.ToArray();
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
				return null;
			}
			catch
			{
				return null;
			}
		}

		private void A(XmlWriter P_0)
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			if (!BcI.awF.ContainsKey(BcH.BCx))
			{
				return;
			}
			DO dO = BcI.awF[BcH.BCx];
			Enumerator<int> enumerator = dO.B().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					A(P_0, current);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (dO.a().Count == 0 && dO.b().Count == 0 && dO.C().Count == 0)
			{
				return;
			}
			HashSet<DataIdAndAttrId> val = MenuNode.A(BcJ, false);
			enumerator = dO.a().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current2 = enumerator.Current;
					A(P_0, val, current2);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			Enumerator<int, List<int>> enumerator2 = dO.b().Keys.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					int current3 = enumerator2.Current;
					enumerator = dO.b()[current3].GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current4 = enumerator.Current;
							A(P_0, val, current4, current3, 0);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			enumerator2 = dO.C().Keys.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					int current5 = enumerator2.Current;
					Dn dn = BcI.A(current5) as Dn;
					List<Setting> val2 = new List<Setting>();
					PortFunction.A(dn, val2, false);
					Enumerator<Setting> enumerator3 = val2.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							Setting current6 = enumerator3.Current;
							val.Add(current6.C());
						}
					}
					finally
					{
						((System.IDisposable)enumerator3).Dispose();
					}
					List<Table> val3 = new List<Table>();
					PortFunction.A(dn, val3, false);
					Enumerator<Table> enumerator4 = val3.GetEnumerator();
					try
					{
						while (enumerator4.MoveNext())
						{
							Enumerator<DataIdAndAttrId> enumerator5 = enumerator4.Current.GetIdsContained().GetEnumerator();
							try
							{
								while (enumerator5.MoveNext())
								{
									DataIdAndAttrId current7 = enumerator5.Current;
									val.Add(current7);
								}
							}
							finally
							{
								((System.IDisposable)enumerator5).Dispose();
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator4).Dispose();
					}
					enumerator = dO.C()[current5].GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							int current8 = enumerator.Current;
							A(P_0, val, current8, 0, current5);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
		}

		private void A(XmlWriter P_0, int P_1)
		{
			Setting setting = BcI.A(P_1);
			if (setting == null)
			{
				return;
			}
			P_0.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aGi());
			P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP(), setting.A().ToString());
			P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWx(), setting.B().ToString());
			byte[] array = setting.aY();
			if (BcI.awX.ContainsKey(P_1))
			{
				string text = n.A(array);
				if (BM.qB.ContainsKey(text))
				{
					string bCX = BM.qB[text].BcF.BCX;
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWY(), bCX);
				}
			}
			byte[] array2 = (BcI.aWR ? array : N.A(array, setting.aG()));
			P_0.WriteBinHex(array2, 0, array2.Length);
			P_0.WriteEndElement();
		}

		private void A(XmlWriter P_0, HashSet<DataIdAndAttrId> P_1, int P_2)
		{
			Setting setting = Cn.A(BcI, P_1, P_2);
			if (setting != null)
			{
				P_0.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mL());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP(), P_2.ToString());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWx(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
				byte[] array = setting.aY();
				byte[] array2 = (BcI.aWR ? array : N.A(array, setting.aG()));
				P_0.WriteBinHex(array2, 0, array2.Length);
				P_0.WriteEndElement();
			}
		}

		private void A(XmlWriter P_0, HashSet<DataIdAndAttrId> P_1, int P_2, int P_3, int P_4)
		{
			Setting setting = Cn.A(BcI, P_1, P_2, P_3, P_4);
			if (setting != null)
			{
				P_0.WriteStartElement(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.mL());
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aIP(), P_2.ToString());
				if (P_4 != 0)
				{
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWZ(), P_4.ToString());
				}
				else if (P_3 != 0)
				{
					P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWy(), P_3.ToString());
				}
				P_0.WriteAttributeString(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWx(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bn());
				byte[] array = setting.aY();
				byte[] array2 = (BcI.aWR ? array : N.A(array, setting.aG()));
				P_0.WriteBinHex(array2, 0, array2.Length);
				P_0.WriteEndElement();
			}
		}

		private byte[] A(MemoryStream P_0)
		{
			byte[] array = P_0.ToArray();
			MD5 obj = MD5.Create();
			byte[] result = ((HashAlgorithm)obj).ComputeHash(array);
			((HashAlgorithm)obj).Dispose();
			return result;
		}

		private List<KeyValuePair<string, byte[]>> B()
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			List<KeyValuePair<string, byte[]>> val = new List<KeyValuePair<string, byte[]>>();
			if (BcI.awF.ContainsKey(BcH.BCx))
			{
				DO dO = BcI.awF[BcH.BCx];
				HashSet<DataIdAndAttrId> val2 = MenuNode.A(BcJ, false);
				Enumerator<int> enumerator = dO.a().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						Setting setting = Cn.A(BcI, val2, current);
						if (setting == null || !((SettingOrSpecialObject)setting).l() || !setting.y())
						{
							continue;
						}
						string text = setting.ay();
						if (string.IsNullOrEmpty(text) || !text.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG()))
						{
							continue;
						}
						string text2 = text.Substring(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.OG().Length);
						if (string.IsNullOrEmpty(text2))
						{
							continue;
						}
						string text3 = Di.B(setting.z());
						if (text3 == null)
						{
							continue;
						}
						string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWz() + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + text2;
						bool flag = false;
						Enumerator<KeyValuePair<string, byte[]>> enumerator2 = val.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.Key == text4)
								{
									flag = true;
									break;
								}
							}
						}
						finally
						{
							((System.IDisposable)enumerator2).Dispose();
						}
						if (flag)
						{
							continue;
						}
						try
						{
							string text5 = BM.Qu + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj();
							if (File.Exists(text5 + text2))
							{
								byte[] array = File.ReadAllBytes(text5 + text2);
								val.Add(new KeyValuePair<string, byte[]>(text4, array));
							}
						}
						catch (System.Exception ex)
						{
							N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awD() + text + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TT() + ex.Message, true);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			return val;
		}
	}
	internal class Cp
	{
		[CompilerGenerated]
		private static class A
		{
			public static ProgressChangedEventHandler Bsq;
		}

		[CompilerGenerated]
		private sealed class a
		{
			public FileInfo BsR;

			internal void A()
			{
				BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEP() + ((FileSystemInfo)BsR).Name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FC());
			}
		}

		internal string BcK;

		internal bool Bck;

		internal Cp(string P_0, bool P_1)
		{
			BcK = P_0;
			Bck = P_1;
		}

		internal void A()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected O, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			DirectoryInfo val = new DirectoryInfo(BcK);
			if (((FileSystemInfo)val).Exists)
			{
				string text = ((FileSystemInfo)val.Parent).FullName + ((((FileSystemInfo)val.Parent).FullName.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) || ((FileSystemInfo)val.Parent).FullName.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj())) ? string.Empty : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()) + ((FileSystemInfo)val).Name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awd();
				if (!Directory.Exists(text))
				{
					try
					{
						Directory.CreateDirectory(text);
					}
					catch
					{
						string text2 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awE();
						if (!BM.qW)
						{
							bE.A((IWin32Window)(object)BM.QQ, text2, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
							return;
						}
						Console.WriteLine();
						Console.WriteLine(text2);
						Environment.Exit(1);
					}
					BackgroundWorker val2 = new BackgroundWorker();
					if (!BM.qW)
					{
						val2.WorkerReportsProgress = true;
					}
					val2.DoWork += new DoWorkEventHandler(A);
					object obj2 = Cp.A.Bsq;
					if (obj2 == null)
					{
						ProgressChangedEventHandler val3 = BM.a;
						Cp.A.Bsq = val3;
						obj2 = (object)val3;
					}
					val2.ProgressChanged += (ProgressChangedEventHandler)obj2;
					val2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(A);
					val2.RunWorkerAsync((object)text);
				}
				else
				{
					string text3 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awe();
					if (BM.qW)
					{
						Console.WriteLine();
						Console.WriteLine(text3);
						Environment.Exit(1);
					}
					else
					{
						bE.A((IWin32Window)(object)BM.QQ, text3, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
			}
			else
			{
				string text4 = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awF();
				if (BM.qW)
				{
					Console.WriteLine();
					Console.WriteLine(text4);
					Environment.Exit(1);
				}
				else
				{
					bE.A((IWin32Window)(object)BM.QQ, text4, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.dm(), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
		}

		private void A(string P_0, string P_1, List<string> P_2, BackgroundWorker P_3)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			DirectoryInfo val = new DirectoryInfo(P_0);
			if (!Directory.Exists(P_1))
			{
				Directory.CreateDirectory(P_1);
			}
			FileInfo[] files = val.GetFiles();
			foreach (FileInfo BsR in files)
			{
				string text = string.Empty;
				try
				{
					if (!BM.qW)
					{
						P_3.ReportProgress(0);
					}
					if (((FileSystemInfo)BsR).FullName.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.sU()))
					{
						if (!BM.qW)
						{
							((Control)BM.QQ).Invoke((Action)delegate
							{
								BM.C(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.BEP() + ((FileSystemInfo)BsR).Name + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FC());
							});
						}
						if (!BM.qW)
						{
							P_3.ReportProgress(10);
						}
						Stream val2 = (Stream)(object)File.OpenRead(((FileSystemInfo)BsR).FullName);
						if (!BM.qW)
						{
							P_3.ReportProgress(20);
						}
						Thread.Sleep(0);
						List<string> val3 = R.A(val2, M.A());
						for (int j = 0; j < val3.Count; j++)
						{
							string text2 = val3[j];
							if (R.A(val2, text2, out var val4, M.A()) && val4 != null)
							{
								if (!BM.qW)
								{
									P_3.ReportProgress(50 + (j + 1) * 40 / val3.Count);
								}
								Thread.Sleep(0);
								string text4;
								if (text2 == D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWP())
								{
									string text3 = Regex.Replace(Path.GetFileNameWithoutExtension(((FileSystemInfo)BsR).FullName), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awf(), D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.ay());
									text4 = Path.Combine(P_1, text3) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awG();
								}
								else
								{
									string text5 = A(text2, BsR, P_1);
									text4 = ((text5 == null) ? Path.Combine(P_1, text2) : text5);
								}
								byte[] array = new byte[val4.Length];
								if (N.A(val4, array, 0, (int)val4.Length))
								{
									File.WriteAllBytes(text4, array);
									if (val4 != null)
									{
										val4.Close();
									}
									continue;
								}
								throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awg() + val4.Length + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awH());
							}
							text = ((FileSystemInfo)BsR).FullName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awh();
							break;
						}
						if (val2 != null)
						{
							val2.Close();
						}
						if (!BM.qW)
						{
							P_3.ReportProgress(100);
						}
						Thread.Sleep(50);
						if (string.IsNullOrEmpty(text))
						{
							text = ((FileSystemInfo)BsR).FullName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awI();
						}
					}
				}
				catch (System.Exception ex)
				{
					text = ((FileSystemInfo)BsR).FullName + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.FZ() + ex.Message;
				}
				if (!string.IsNullOrEmpty(text))
				{
					P_2.Add(text);
				}
			}
			if (Bck)
			{
				DirectoryInfo[] directories = val.GetDirectories();
				foreach (DirectoryInfo val5 in directories)
				{
					string text6 = P_1 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK() + ((FileSystemInfo)val5).Name;
					A(((FileSystemInfo)val5).FullName, text6, P_2, P_3);
				}
			}
		}

		private string A(string P_0, FileInfo P_1, string P_2)
		{
			if (P_0.StartsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TQ()) && P_0.Length > D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TQ().Length + 1)
			{
				string text = Path.Combine(P_2, Path.GetFileNameWithoutExtension(((FileSystemInfo)P_1).FullName) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awi());
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				int num = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.TQ().Length + 1;
				string text2 = P_0.Substring(num);
				int num2 = text2.IndexOfAny(new char[2] { '\\', '/' });
				if (num2 != -1)
				{
					string text3 = text2.Substring(0, num2);
					int length = (D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.aWz() + text3 + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bK()).Length;
					if (length < P_0.Length)
					{
						string text4 = Path.Combine(text, text3);
						if (!Directory.Exists(text4))
						{
							Directory.CreateDirectory(text4);
						}
						string text5 = P_0.Substring(length);
						return Path.Combine(text4, text5);
					}
				}
			}
			return null;
		}

		private void A(object P_0, DoWorkEventArgs P_1)
		{
			BackgroundWorker val = (BackgroundWorker)((P_0 is BackgroundWorker) ? P_0 : null);
			string text = P_1.Argument as string;
			List<string> val2 = new List<string>();
			A(BcK, text, val2, val);
			P_1.Result = val2;
		}

		private void A(object P_0, RunWorkerCompletedEventArgs P_1)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			BM.P();
			List<string> val = P_1.Result as List<string>;
			int num = 0;
			Enumerator<string> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awJ()))
					{
						num++;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			bool flag = num == val.Count;
			string text = D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awj() + num + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awK() + (flag ? string.Empty : D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awk());
			enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					if (!current.EndsWith(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awJ()))
					{
						text = text + current + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Fy();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			if (BM.qW)
			{
				Console.WriteLine();
				Console.WriteLine(text);
				Environment.Exit((!flag) ? 1 : 0);
			}
			else
			{
				bE.A((IWin32Window)(object)BM.QQ, text, D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.awL(), (MessageBoxButtons)0);
			}
		}
	}
}
